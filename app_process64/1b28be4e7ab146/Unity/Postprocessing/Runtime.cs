class <Module>
{
}

namespace UnityEngine
{
    namespace Rendering
    {
        namespace PostProcessing
        {
            class DisplayNameAttribute : System.Attribute
            {
                /*0x10*/ string displayName;

                /*0x7afeca0*/ DisplayNameAttribute(string displayName);
            }

            class MinAttribute : System.Attribute
            {
                /*0x10*/ float min;

                /*0x7afecd0*/ MinAttribute(float min);
            }

            class MinMaxAttribute : System.Attribute
            {
                /*0x10*/ float min;
                /*0x14*/ float max;

                /*0x7afecf8*/ MinMaxAttribute(float min, float max);
            }

            class PostProcessAttribute : System.Attribute
            {
                /*0x10*/ System.Type renderer;
                /*0x18*/ UnityEngine.Rendering.PostProcessing.PostProcessEvent eventType;
                /*0x20*/ string menuItem;
                /*0x28*/ bool allowInSceneView;
                /*0x29*/ bool builtinEffect;

                /*0x7afed24*/ PostProcessAttribute(System.Type renderer, string menuItem, bool allowInSceneView);
            }

            class TrackballAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Rendering.PostProcessing.TrackballAttribute.Mode mode;

                /*0x7afed84*/ TrackballAttribute(UnityEngine.Rendering.PostProcessing.TrackballAttribute.Mode mode);

                enum Mode
                {
                    None = 0,
                    Lift = 1,
                    Gamma = 2,
                    Gain = 3,
                }
            }

            enum AmbientOcclusionMode
            {
                ScalableAmbientObscurance = 0,
                MultiScaleVolumetricObscurance = 1,
            }

            enum AmbientOcclusionQuality
            {
                Lowest = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                Ultra = 4,
            }

            class AmbientOcclusionModeParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.AmbientOcclusionMode>
            {
                /*0x7afedac*/ AmbientOcclusionModeParameter();
            }

            class AmbientOcclusionQualityParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.AmbientOcclusionQuality>
            {
                /*0x7afedf4*/ AmbientOcclusionQualityParameter();
            }

            class AmbientOcclusion : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.AmbientOcclusionModeParameter mode;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.ColorParameter color;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.BoolParameter ambientOnly;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter noiseFilterTolerance;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter blurTolerance;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.FloatParameter upsampleTolerance;
                /*0x68*/ UnityEngine.Rendering.PostProcessing.FloatParameter thicknessModifier;
                /*0x70*/ UnityEngine.Rendering.PostProcessing.FloatParameter zBias;
                /*0x78*/ UnityEngine.Rendering.PostProcessing.FloatParameter directLightingStrength;
                /*0x80*/ UnityEngine.Rendering.PostProcessing.FloatParameter radius;
                /*0x88*/ UnityEngine.Rendering.PostProcessing.AmbientOcclusionQualityParameter quality;

                /*0x7aff184*/ AmbientOcclusion();
                /*0x7afee3c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            interface IAmbientOcclusionMethod
            {
                /*0x3814574*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x3816710*/ void RenderAfterOpaque(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x3816710*/ void RenderAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x3816710*/ void CompositeAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x38159dc*/ void Release();
            }

            class AmbientOcclusionRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.AmbientOcclusion>
            {
                /*0x20*/ UnityEngine.Rendering.PostProcessing.IAmbientOcclusionMethod[] m_Methods;

                /*0x7affe58*/ AmbientOcclusionRenderer();
                /*0x7aff460*/ void Init();
                /*0x7affb4c*/ bool IsAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7affbdc*/ UnityEngine.Rendering.PostProcessing.IAmbientOcclusionMethod Get();
                /*0x7affc4c*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7affcf4*/ void Release();
                /*0x7affddc*/ UnityEngine.Rendering.PostProcessing.MultiScaleVO GetMultiScaleVO();
                /*0x7affe54*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            enum EyeAdaptation
            {
                Progressive = 0,
                Fixed = 1,
            }

            class EyeAdaptationParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.EyeAdaptation>
            {
                /*0x7affea0*/ EyeAdaptationParameter();
            }

            class AutoExposure : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.Vector2Parameter filtering;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter minLuminance;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.FloatParameter maxLuminance;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter keyValue;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.EyeAdaptationParameter eyeAdaptation;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter speedUp;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.FloatParameter speedDown;

                /*0x7b00040*/ AutoExposure();
                /*0x7affee8*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class AutoExposureRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.AutoExposure>
            {
                /*0x20*/ UnityEngine.RenderTexture[][] m_AutoExposurePool;
                /*0x28*/ int[] m_AutoExposurePingPong;
                /*0x30*/ UnityEngine.RenderTexture m_CurrentAutoExposure;

                /*0x7b00200*/ AutoExposureRenderer();
                /*0x7b0036c*/ void CheckTexture(int eye, int id);
                /*0x7b00568*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b00c48*/ void Release();
            }

            class Bloom : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter threshold;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.FloatParameter softKnee;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter clamp;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter diffusion;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter anamorphicRatio;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.ColorParameter color;
                /*0x68*/ UnityEngine.Rendering.PostProcessing.BoolParameter fastMode;
                /*0x70*/ UnityEngine.Rendering.PostProcessing.TextureParameter dirtTexture;
                /*0x78*/ UnityEngine.Rendering.PostProcessing.FloatParameter dirtIntensity;

                /*0x7b00d68*/ Bloom();
                /*0x7b00d2c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class BloomRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.Bloom>
            {
                /*0x20*/ UnityEngine.Rendering.PostProcessing.BloomRenderer.Level[] m_Pyramid;

                /*0x7b01e10*/ BloomRenderer();
                /*0x7b00fd4*/ void Init();
                /*0x7b01108*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);

                enum Pass
                {
                    Prefilter13 = 0,
                    Prefilter4 = 1,
                    Downsample13 = 2,
                    Downsample4 = 3,
                    UpsampleTent = 4,
                    UpsampleBox = 5,
                    DebugOverlayThreshold = 6,
                    DebugOverlayTent = 7,
                    DebugOverlayBox = 8,
                }

                struct Level
                {
                    /*0x10*/ int down;
                    /*0x14*/ int up;
                }
            }

            class ChromaticAberration : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.TextureParameter spectralLut;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.BoolParameter fastMode;

                /*0x7b01e94*/ ChromaticAberration();
                /*0x7b01e58*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class ChromaticAberrationRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.ChromaticAberration>
            {
                /*0x20*/ UnityEngine.Texture2D m_InternalSpectralLut;

                /*0x7b022fc*/ ChromaticAberrationRenderer();
                /*0x7b01f98*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b02290*/ void Release();
            }

            enum GradingMode
            {
                LowDefinitionRange = 0,
                HighDefinitionRange = 1,
                External = 2,
            }

            enum Tonemapper
            {
                None = 0,
                Neutral = 1,
                ACES = 2,
                Custom = 3,
            }

            class GradingModeParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.GradingMode>
            {
                /*0x7b02344*/ GradingModeParameter();
            }

            class TonemapperParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.Tonemapper>
            {
                /*0x7b0238c*/ TonemapperParameter();
            }

            class ColorGrading : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.GradingModeParameter gradingMode;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.TextureParameter externalLut;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.TonemapperParameter tonemapper;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveToeStrength;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveToeLength;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderStrength;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderLength;
                /*0x68*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderAngle;
                /*0x70*/ UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveGamma;
                /*0x78*/ UnityEngine.Rendering.PostProcessing.TextureParameter ldrLut;
                /*0x80*/ UnityEngine.Rendering.PostProcessing.FloatParameter ldrLutContribution;
                /*0x88*/ UnityEngine.Rendering.PostProcessing.FloatParameter temperature;
                /*0x90*/ UnityEngine.Rendering.PostProcessing.FloatParameter tint;
                /*0x98*/ UnityEngine.Rendering.PostProcessing.ColorParameter colorFilter;
                /*0xa0*/ UnityEngine.Rendering.PostProcessing.FloatParameter hueShift;
                /*0xa8*/ UnityEngine.Rendering.PostProcessing.FloatParameter saturation;
                /*0xb0*/ UnityEngine.Rendering.PostProcessing.FloatParameter brightness;
                /*0xb8*/ UnityEngine.Rendering.PostProcessing.FloatParameter postExposure;
                /*0xc0*/ UnityEngine.Rendering.PostProcessing.FloatParameter contrast;
                /*0xc8*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutRedIn;
                /*0xd0*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutGreenIn;
                /*0xd8*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutBlueIn;
                /*0xe0*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutRedIn;
                /*0xe8*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutGreenIn;
                /*0xf0*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutBlueIn;
                /*0xf8*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutRedIn;
                /*0x100*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutGreenIn;
                /*0x108*/ UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutBlueIn;
                /*0x110*/ UnityEngine.Rendering.PostProcessing.Vector4Parameter lift;
                /*0x118*/ UnityEngine.Rendering.PostProcessing.Vector4Parameter gamma;
                /*0x120*/ UnityEngine.Rendering.PostProcessing.Vector4Parameter gain;
                /*0x128*/ UnityEngine.Rendering.PostProcessing.SplineParameter masterCurve;
                /*0x130*/ UnityEngine.Rendering.PostProcessing.SplineParameter redCurve;
                /*0x138*/ UnityEngine.Rendering.PostProcessing.SplineParameter greenCurve;
                /*0x140*/ UnityEngine.Rendering.PostProcessing.SplineParameter blueCurve;
                /*0x148*/ UnityEngine.Rendering.PostProcessing.SplineParameter hueVsHueCurve;
                /*0x150*/ UnityEngine.Rendering.PostProcessing.SplineParameter hueVsSatCurve;
                /*0x158*/ UnityEngine.Rendering.PostProcessing.SplineParameter satVsSatCurve;
                /*0x160*/ UnityEngine.Rendering.PostProcessing.SplineParameter lumVsSatCurve;

                /*0x7b02430*/ ColorGrading();
                /*0x7b023d4*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class ColorGradingRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.ColorGrading>
            {
                /*0x20*/ UnityEngine.Texture2D m_GradingCurves;
                /*0x28*/ UnityEngine.Color[] m_Pixels;
                /*0x30*/ UnityEngine.RenderTexture m_InternalLdrLut;
                /*0x38*/ UnityEngine.RenderTexture m_InternalLogLut;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.HableCurve m_HableCurve;

                static /*0x7b058b0*/ bool IsRenderTextureFormatSupportedForLinearFiltering(UnityEngine.RenderTextureFormat format);
                static /*0x7b05850*/ UnityEngine.RenderTextureFormat GetLutFormat();
                static /*0x7b05888*/ UnityEngine.TextureFormat GetCurveFormat();
                /*0x7b059cc*/ ColorGradingRenderer();
                /*0x7b0319c*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b032e8*/ void RenderExternalPipeline3D(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b03508*/ void RenderHDRPipeline3D(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b03f48*/ void RenderHDRPipeline2D(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b048d4*/ void RenderLDRPipeline2D(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b05174*/ void CheckInternalLogLut();
                /*0x7b056a4*/ void CheckInternalStripLut();
                /*0x7b05354*/ UnityEngine.Texture2D GetCurveTexture(bool hdr);
                /*0x7b05918*/ void Release();

                enum Pass
                {
                    LutGenLDRFromScratch = 0,
                    LutGenLDR = 1,
                    LutGenHDR2D = 2,
                }
            }

            enum KernelSize
            {
                Small = 0,
                Medium = 1,
                Large = 2,
                VeryLarge = 3,
            }

            class KernelSizeParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.KernelSize>
            {
                /*0x7b05a84*/ KernelSizeParameter();
            }

            class DepthOfField : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.FloatParameter focusDistance;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter aperture;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.FloatParameter focalLength;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.KernelSizeParameter kernelSize;

                /*0x7b05b04*/ DepthOfField();
                /*0x7b05acc*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class DepthOfFieldRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.DepthOfField>
            {
                /*0x20*/ UnityEngine.RenderTexture[][] m_CoCHistoryTextures;
                /*0x28*/ int[] m_HistoryPingPong;

                /*0x7b05c24*/ DepthOfFieldRenderer();
                /*0x7b05d90*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b05d98*/ UnityEngine.RenderTextureFormat SelectFormat(UnityEngine.RenderTextureFormat primary, UnityEngine.RenderTextureFormat secondary);
                /*0x7b05e34*/ float CalculateMaxCoCRadius(int screenHeight);
                /*0x7b05eb0*/ UnityEngine.RenderTexture CheckHistory(int eye, int id, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, UnityEngine.RenderTextureFormat format);
                /*0x7b06108*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b06b24*/ void Release();

                enum Pass
                {
                    CoCCalculation = 0,
                    CoCTemporalFilter = 1,
                    DownsampleAndPrefilter = 2,
                    BokehSmallKernel = 3,
                    BokehMediumKernel = 4,
                    BokehLargeKernel = 5,
                    BokehVeryLargeKernel = 6,
                    PostFilter = 7,
                    Combine = 8,
                    DebugOverlay = 9,
                }
            }

            class Dithering
            {
                /*0x10*/ int m_NoiseTextureIndex;
                /*0x18*/ System.Random m_Random;

                /*0x7b06dac*/ Dithering();
                /*0x7b06c24*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class FastApproximateAntialiasing
            {
                /*0x10*/ bool fastMode;
                /*0x11*/ bool keepAlpha;

                /*0x7b06e1c*/ FastApproximateAntialiasing();
            }

            class Fog
            {
                /*0x10*/ bool enabled;
                /*0x11*/ bool excludeSkybox;

                /*0x7b0723c*/ Fog();
                /*0x7b06e24*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b06e2c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b06f34*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class Grain : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.BoolParameter colored;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.FloatParameter size;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter lumContrib;

                /*0x7b07288*/ Grain();
                /*0x7b0724c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class GrainRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.Grain>
            {
                /*0x20*/ UnityEngine.RenderTexture m_GrainLookupRT;
                /*0x28*/ int m_SampleIndex;

                /*0x7b07a74*/ GrainRenderer();
                /*0x7b073a8*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b07990*/ UnityEngine.RenderTextureFormat GetLookupFormat();
                /*0x7b079f4*/ void Release();
            }

            class LensDistortion : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensityX;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensityY;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter centerX;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter centerY;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter scale;

                /*0x7b07bc8*/ LensDistortion();
                /*0x7b07abc*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class LensDistortionRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.LensDistortion>
            {
                /*0x7b07f30*/ LensDistortionRenderer();
                /*0x7b07d2c*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class MotionBlur : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.FloatParameter shutterAngle;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.IntParameter sampleCount;

                /*0x7b08028*/ MotionBlur();
                /*0x7b07f78*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class MotionBlurRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.MotionBlur>
            {
                /*0x7b08aec*/ MotionBlurRenderer();
                /*0x7b080e8*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b080f0*/ void CreateTemporaryRT(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, int nameID, int width, int height, UnityEngine.RenderTextureFormat RTFormat);
                /*0x7b081b4*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);

                enum Pass
                {
                    VelocitySetup = 0,
                    TileMax1 = 1,
                    TileMax2 = 2,
                    TileMaxV = 3,
                    NeighborMax = 4,
                    Reconstruction = 5,
                }
            }

            class MultiScaleVO : UnityEngine.Rendering.PostProcessing.IAmbientOcclusionMethod
            {
                /*0x10*/ float[] m_SampleThickness;
                /*0x18*/ float[] m_InvThicknessTable;
                /*0x20*/ float[] m_SampleWeightTable;
                /*0x28*/ int[] m_Widths;
                /*0x30*/ int[] m_Heights;
                /*0x38*/ int[] m_ScaledWidths;
                /*0x40*/ int[] m_ScaledHeights;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.AmbientOcclusion m_Settings;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.PropertySheet m_PropertySheet;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources;
                /*0x60*/ UnityEngine.RenderTexture m_AmbientOnlyAO;
                /*0x68*/ UnityEngine.RenderTextureFormat m_R8Format;
                /*0x6c*/ UnityEngine.RenderTextureFormat m_R16Format;
                /*0x70*/ bool float4Texture;
                /*0x78*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT;

                /*0x7aff744*/ MultiScaleVO(UnityEngine.Rendering.PostProcessing.AmbientOcclusion settings);
                /*0x7b08b34*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b08b3c*/ void SetResources(UnityEngine.Rendering.PostProcessing.PostProcessResources resources);
                /*0x7b08b44*/ void Alloc(UnityEngine.Rendering.CommandBuffer cmd, int id, UnityEngine.Rendering.PostProcessing.MultiScaleVO.MipLevel size, UnityEngine.RenderTextureFormat format, bool uav, bool dynamicScale);
                /*0x7b08c98*/ void AllocArray(UnityEngine.Rendering.CommandBuffer cmd, int id, UnityEngine.Rendering.PostProcessing.MultiScaleVO.MipLevel size, UnityEngine.RenderTextureFormat format, bool uav, bool dynamicScale);
                /*0x7b08df0*/ void Release(UnityEngine.Rendering.CommandBuffer cmd, int id);
                /*0x7b08e0c*/ UnityEngine.Vector4 CalculateZBufferParams(UnityEngine.Camera camera);
                /*0x7b08e78*/ float CalculateTanHalfFovHeight(UnityEngine.Camera camera);
                /*0x7b08ed8*/ UnityEngine.Vector2 GetSize(UnityEngine.Rendering.PostProcessing.MultiScaleVO.MipLevel mip);
                /*0x7b08f30*/ UnityEngine.Vector3 GetSizeArray(UnityEngine.Rendering.PostProcessing.MultiScaleVO.MipLevel mip);
                /*0x7b08f8c*/ void GenerateAOMap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Rendering.RenderTargetIdentifier destination, System.Nullable<UnityEngine.Rendering.RenderTargetIdentifier> depthMap, bool invert, bool isMSAA);
                /*0x7b096bc*/ void PushAllocCommands(UnityEngine.Rendering.CommandBuffer cmd, bool isMSAA, UnityEngine.Camera camera);
                /*0x7b09c44*/ void PushDownsampleCommands(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.RenderTargetIdentifier> depthMap, bool isMSAA);
                /*0x7b0a3c8*/ void PushRenderCommands(UnityEngine.Rendering.CommandBuffer cmd, int source, int destination, UnityEngine.Vector3 sourceSize, float tanHalfFovH, bool isMSAA);
                /*0x7b0a998*/ void PushUpsampleCommands(UnityEngine.Rendering.CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, System.Nullable<int> highResAO, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Vector3 lowResDepthSize, UnityEngine.Vector2 highResDepthSize, bool isMSAA, bool invert);
                /*0x7b0ae80*/ void PushReleaseCommands(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b0b054*/ void PreparePropertySheet(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b144*/ void CheckAOTexture(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b360*/ void PushDebug(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b3e4*/ void RenderAfterOpaque(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b6ec*/ void RenderAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b7f8*/ void CompositeAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0b9b8*/ void Release();

                enum MipLevel
                {
                    Original = 0,
                    L1 = 1,
                    L2 = 2,
                    L3 = 3,
                    L4 = 4,
                    L5 = 5,
                    L6 = 6,
                }

                enum Pass
                {
                    DepthCopy = 0,
                    CompositionDeferred = 1,
                    CompositionForward = 2,
                    DebugOverlay = 3,
                }
            }

            class ScalableAO : UnityEngine.Rendering.PostProcessing.IAmbientOcclusionMethod
            {
                /*0x10*/ UnityEngine.RenderTexture m_Result;
                /*0x18*/ UnityEngine.Rendering.PostProcessing.PropertySheet m_PropertySheet;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.AmbientOcclusion m_Settings;
                /*0x28*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT;
                /*0x30*/ int[] m_SampleCount;

                /*0x7aff5c4*/ ScalableAO(UnityEngine.Rendering.PostProcessing.AmbientOcclusion settings);
                /*0x7b0ba24*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b0ba2c*/ void DoLazyInitialization(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0bbe8*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, int occlusionSource);
                /*0x7b0c104*/ void RenderAfterOpaque(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0c2d4*/ void RenderAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0c360*/ void CompositeAmbientOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0c520*/ void Release();

                enum Pass
                {
                    OcclusionEstimationForward = 0,
                    OcclusionEstimationDeferred = 1,
                    HorizontalBlurForward = 2,
                    HorizontalBlurDeferred = 3,
                    VerticalBlur = 4,
                    CompositionForward = 5,
                    CompositionDeferred = 6,
                    DebugOverlay = 7,
                }
            }

            enum ScreenSpaceReflectionPreset
            {
                Lower = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                Higher = 4,
                Ultra = 5,
                Overkill = 6,
                Custom = 7,
            }

            enum ScreenSpaceReflectionResolution
            {
                Downsampled = 0,
                FullSize = 1,
                Supersampled = 2,
            }

            class ScreenSpaceReflectionPresetParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionPreset>
            {
                /*0x7b0c58c*/ ScreenSpaceReflectionPresetParameter();
            }

            class ScreenSpaceReflectionResolutionParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionResolution>
            {
                /*0x7b0c5d4*/ ScreenSpaceReflectionResolutionParameter();
            }

            class ScreenSpaceReflections : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionPresetParameter preset;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.IntParameter maximumIterationCount;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionResolutionParameter resolution;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter thickness;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter maximumMarchDistance;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter distanceFade;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.FloatParameter vignette;

                /*0x7b0c758*/ ScreenSpaceReflections();
                /*0x7b0c61c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class ScreenSpaceReflectionsRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.ScreenSpaceReflections>
            {
                /*0x20*/ UnityEngine.RenderTexture m_Resolve;
                /*0x28*/ UnityEngine.RenderTexture m_History;
                /*0x30*/ int[] m_MipIDs;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets;

                /*0x7b0dd04*/ ScreenSpaceReflectionsRenderer();
                /*0x7b0c928*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b0c930*/ void CheckRT(ref UnityEngine.RenderTexture rt, int width, int height, UnityEngine.FilterMode filterMode, bool useMipMap);
                /*0x7b0cb40*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0dc70*/ void Release();

                class QualityPreset
                {
                    /*0x10*/ int maximumIterationCount;
                    /*0x14*/ float thickness;
                    /*0x18*/ UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionResolution downsampling;

                    /*0x7b0e028*/ QualityPreset();
                }

                enum Pass
                {
                    Test = 0,
                    Resolve = 1,
                    Reproject = 2,
                    Composite = 3,
                }
            }

            class SubpixelMorphologicalAntialiasing
            {
                /*0x10*/ UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing.Quality quality;

                /*0x7b0e494*/ SubpixelMorphologicalAntialiasing();
                /*0x7b0e030*/ bool IsSupported();
                /*0x7b0e08c*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);

                enum Pass
                {
                    EdgeDetection = 0,
                    BlendWeights = 3,
                    NeighborhoodBlending = 6,
                }

                enum Quality
                {
                    Low = 0,
                    Medium = 1,
                    High = 2,
                }
            }

            class TemporalAntialiasing
            {
                static int k_SampleCount = 8;
                static int k_NumEyes = 2;
                static int k_NumHistoryTextures = 2;
                /*0x10*/ float jitterSpread;
                /*0x14*/ float sharpness;
                /*0x18*/ float stationaryBlending;
                /*0x1c*/ float motionBlending;
                /*0x20*/ System.Func<UnityEngine.Camera, UnityEngine.Vector2, UnityEngine.Matrix4x4> jitteredMatrixFunc;
                /*0x28*/ UnityEngine.Vector2 <jitter>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_Mrt;
                /*0x38*/ bool m_ResetHistory;
                /*0x3c*/ int <sampleIndex>k__BackingField;
                /*0x40*/ UnityEngine.RenderTexture[][] m_HistoryTextures;
                /*0x48*/ int[] m_HistoryPingPong;

                /*0x7b0f35c*/ TemporalAntialiasing();
                /*0x7b0e4a4*/ UnityEngine.Vector2 get_jitter();
                /*0x7b0e4ac*/ void set_jitter(UnityEngine.Vector2 value);
                /*0x7b0e4b4*/ int get_sampleIndex();
                /*0x7b0e4bc*/ void set_sampleIndex(int value);
                /*0x7b0e4c4*/ bool IsSupported();
                /*0x7b0e4f0*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b0e4f8*/ void ResetHistory();
                /*0x7b0e504*/ UnityEngine.Vector2 GenerateRandomOffset();
                /*0x7b0e574*/ UnityEngine.Matrix4x4 GetJitteredProjectionMatrix(UnityEngine.Camera camera);
                /*0x7b0e6f4*/ void ConfigureJitteredProjectionMatrix(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0e784*/ void ConfigureStereoJitteredProjectionMatrices(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0e924*/ void GenerateHistoryName(UnityEngine.RenderTexture rt, int id, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0ea18*/ UnityEngine.RenderTexture CheckHistory(int id, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0eeac*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0f234*/ void Release();

                enum Pass
                {
                    SolverDilate = 0,
                    SolverNoDilate = 1,
                }
            }

            enum VignetteMode
            {
                Classic = 0,
                Masked = 1,
            }

            class VignetteModeParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.VignetteMode>
            {
                /*0x7b0f43c*/ VignetteModeParameter();
            }

            class Vignette : UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings
            {
                /*0x30*/ UnityEngine.Rendering.PostProcessing.VignetteModeParameter mode;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.ColorParameter color;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.Vector2Parameter center;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.FloatParameter smoothness;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.FloatParameter roundness;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.BoolParameter rounded;
                /*0x68*/ UnityEngine.Rendering.PostProcessing.TextureParameter mask;
                /*0x70*/ UnityEngine.Rendering.PostProcessing.FloatParameter opacity;

                /*0x7b0f558*/ Vignette();
                /*0x7b0f484*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class VignetteRenderer : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer<UnityEngine.Rendering.PostProcessing.Vignette>
            {
                /*0x7b0fa38*/ VignetteRenderer();
                /*0x7b0f7c0*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class HistogramMonitor : UnityEngine.Rendering.PostProcessing.Monitor
            {
                static int k_NumBins = 256;
                static int k_ThreadGroupSizeX = 16;
                static int k_ThreadGroupSizeY = 16;
                /*0x1c*/ int width;
                /*0x20*/ int height;
                /*0x24*/ UnityEngine.Rendering.PostProcessing.HistogramMonitor.Channel channel;
                /*0x28*/ UnityEngine.ComputeBuffer m_Data;

                /*0x7b10650*/ HistogramMonitor();
                /*0x7b0fa80*/ void OnDisable();
                /*0x7b0fb08*/ bool NeedsHalfRes();
                /*0x7b0fb10*/ bool ShaderResourcesAvailable(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b0fb84*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);

                enum Channel
                {
                    Red = 0,
                    Green = 1,
                    Blue = 2,
                    Master = 3,
                }
            }

            class LightMeterMonitor : UnityEngine.Rendering.PostProcessing.Monitor
            {
                /*0x1c*/ int width;
                /*0x20*/ int height;
                /*0x24*/ bool showCurves;

                /*0x7b10b94*/ LightMeterMonitor();
                /*0x7b10674*/ bool ShaderResourcesAvailable(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b1071c*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            enum MonitorType
            {
                LightMeter = 0,
                Histogram = 1,
                Waveform = 2,
                Vectorscope = 3,
            }

            class Monitor
            {
                /*0x10*/ UnityEngine.RenderTexture <output>k__BackingField;
                /*0x18*/ bool requested;

                /*0x7b1066c*/ Monitor();
                /*0x7b10bb0*/ UnityEngine.RenderTexture get_output();
                /*0x7b10bb8*/ void set_output(UnityEngine.RenderTexture value);
                /*0x7b10bc0*/ bool IsRequestedAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x38141c4*/ bool ShaderResourcesAvailable(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b10d50*/ bool NeedsHalfRes();
                /*0x7b100cc*/ void CheckOutput(int width, int height);
                /*0x7b10de0*/ void OnEnable();
                /*0x7b0fab0*/ void OnDisable();
                /*0x3816710*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class VectorscopeMonitor : UnityEngine.Rendering.PostProcessing.Monitor
            {
                static int k_ThreadGroupSizeX = 16;
                static int k_ThreadGroupSizeY = 16;
                /*0x1c*/ int size;
                /*0x20*/ float exposure;
                /*0x28*/ UnityEngine.ComputeBuffer m_Data;

                /*0x7b114bc*/ VectorscopeMonitor();
                /*0x7b10de4*/ void OnDisable();
                /*0x7b10e14*/ bool NeedsHalfRes();
                /*0x7b10e1c*/ bool ShaderResourcesAvailable(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b10e90*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class WaveformMonitor : UnityEngine.Rendering.PostProcessing.Monitor
            {
                static int k_ThreadGroupSize = 256;
                static int k_ThreadGroupSizeX = 16;
                static int k_ThreadGroupSizeY = 16;
                /*0x1c*/ float exposure;
                /*0x20*/ int height;
                /*0x28*/ UnityEngine.ComputeBuffer m_Data;

                /*0x7b11f5c*/ WaveformMonitor();
                /*0x7b114d4*/ void OnDisable();
                /*0x7b11504*/ bool NeedsHalfRes();
                /*0x7b1150c*/ bool ShaderResourcesAvailable(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b11580*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class ParameterOverride
            {
                /*0x10*/ bool overrideState;

                /*0x7b11f7c*/ ParameterOverride();
                void Interp(UnityEngine.Rendering.PostProcessing.ParameterOverride from, UnityEngine.Rendering.PostProcessing.ParameterOverride to, float t);
                /*0x3814574*/ int GetHash();
                /*0x3910ae8*/ T GetValue<T>();
                /*0x7b11f74*/ void OnEnable();
                /*0x7b11f78*/ void OnDisable();
                /*0x3816710*/ void SetValue(UnityEngine.Rendering.PostProcessing.ParameterOverride parameter);
            }

            class ParameterOverride<T> : UnityEngine.Rendering.PostProcessing.ParameterOverride
            {
                /*0x0*/ T value;

                static /*0x3910ae8*/ T op_Implicit(UnityEngine.Rendering.PostProcessing.ParameterOverride<T> prop);
                /*0x38159dc*/ ParameterOverride();
                /*0x3910ae8*/ ParameterOverride(T value, bool overrideState);
                void Interp(UnityEngine.Rendering.PostProcessing.ParameterOverride from, UnityEngine.Rendering.PostProcessing.ParameterOverride to, float t);
                /*0x3910ae8*/ void Interp(T from, T to, float t);
                /*0x3816710*/ void SetValue(UnityEngine.Rendering.PostProcessing.ParameterOverride parameter);
                /*0x3814574*/ int GetHash();
            }

            class FloatParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<float>
            {
                /*0x7b11f98*/ FloatParameter();
                /*0x7b11f84*/ void Interp(float from, float to, float t);
            }

            class IntParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<int>
            {
                /*0x7b12014*/ IntParameter();
                /*0x7b11fe0*/ void Interp(int from, int to, float t);
            }

            class BoolParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<bool>
            {
                /*0x7b1205c*/ BoolParameter();
            }

            class ColorParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Color>
            {
                /*0x7b120d4*/ ColorParameter();
                /*0x7b120a4*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
            }

            class Vector2Parameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Vector2>
            {
                /*0x7b1213c*/ Vector2Parameter();
                /*0x7b1211c*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
            }

            class Vector4Parameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Vector4>
            {
                /*0x7b121b4*/ Vector4Parameter();
                /*0x7b12184*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
            }

            class SplineParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Rendering.PostProcessing.Spline>
            {
                /*0x7b12608*/ SplineParameter();
                /*0x7b121fc*/ void OnEnable();
                /*0x7b1245c*/ void SetValue(UnityEngine.Rendering.PostProcessing.ParameterOverride parameter);
                /*0x7b124e0*/ void Interp(UnityEngine.Rendering.PostProcessing.Spline from, UnityEngine.Rendering.PostProcessing.Spline to, float t);
            }

            enum TextureParameterDefault
            {
                None = 0,
                Black = 1,
                White = 2,
                Transparent = 3,
                Lut2D = 4,
            }

            class TextureParameter : UnityEngine.Rendering.PostProcessing.ParameterOverride<UnityEngine.Texture>
            {
                /*0x20*/ UnityEngine.Rendering.PostProcessing.TextureParameterDefault defaultState;

                /*0x7b12d8c*/ TextureParameter();
                /*0x7b12650*/ void Interp(UnityEngine.Texture from, UnityEngine.Texture to, float t);
            }

            class PostProcessBundle
            {
                /*0x10*/ UnityEngine.Rendering.PostProcessing.PostProcessAttribute <attribute>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings <settings>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer m_Renderer;

                /*0x7b12f00*/ PostProcessBundle(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings settings);
                /*0x7b12ddc*/ UnityEngine.Rendering.PostProcessing.PostProcessAttribute get_attribute();
                /*0x7b12de4*/ void set_attribute(UnityEngine.Rendering.PostProcessing.PostProcessAttribute value);
                /*0x7b12dec*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings get_settings();
                /*0x7b12df4*/ void set_settings(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings value);
                /*0x7b12dfc*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer get_renderer();
                /*0x7b12fc0*/ void Release();
                /*0x7b1302c*/ void ResetHistory();
                /*0x3910ae8*/ T CastSettings<T>();
                /*0x3910ae8*/ T CastRenderer<T>();
            }

            enum DebugOverlay
            {
                None = 0,
                Depth = 1,
                Normals = 2,
                MotionVectors = 3,
                NANTracker = 4,
                ColorBlindnessSimulation = 5,
                _ = 6,
                AmbientOcclusion = 7,
                BloomBuffer = 8,
                BloomThreshold = 9,
                DepthOfField = 10,
            }

            enum ColorBlindnessType
            {
                Deuteranopia = 0,
                Protanopia = 1,
                Tritanopia = 2,
            }

            class PostProcessDebugLayer
            {
                /*0x10*/ UnityEngine.Rendering.PostProcessing.LightMeterMonitor lightMeter;
                /*0x18*/ UnityEngine.Rendering.PostProcessing.HistogramMonitor histogram;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.WaveformMonitor waveform;
                /*0x28*/ UnityEngine.Rendering.PostProcessing.VectorscopeMonitor vectorscope;
                /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Rendering.PostProcessing.MonitorType, UnityEngine.Rendering.PostProcessing.Monitor> m_Monitors;
                /*0x38*/ int frameWidth;
                /*0x3c*/ int frameHeight;
                /*0x40*/ UnityEngine.RenderTexture <debugOverlayTarget>k__BackingField;
                /*0x48*/ bool <debugOverlayActive>k__BackingField;
                /*0x4c*/ UnityEngine.Rendering.PostProcessing.DebugOverlay <debugOverlay>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer.OverlaySettings overlaySettings;

                /*0x7b14098*/ PostProcessDebugLayer();
                /*0x7b13044*/ UnityEngine.RenderTexture get_debugOverlayTarget();
                /*0x7b1304c*/ void set_debugOverlayTarget(UnityEngine.RenderTexture value);
                /*0x7b13054*/ bool get_debugOverlayActive();
                /*0x7b1305c*/ void set_debugOverlayActive(bool value);
                /*0x7b13068*/ UnityEngine.Rendering.PostProcessing.DebugOverlay get_debugOverlay();
                /*0x7b13070*/ void set_debugOverlay(UnityEngine.Rendering.PostProcessing.DebugOverlay value);
                /*0x7b13078*/ void OnEnable();
                /*0x7b1335c*/ void OnDisable();
                /*0x7b134c4*/ void DestroyDebugOverlayTarget();
                /*0x7b1352c*/ void SetFrameSize(int width, int height);
                /*0x7b13538*/ void PushDebugOverlay(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.PostProcessing.PropertySheet sheet, int pass);
                /*0x7b137d0*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b137f8*/ void RenderMonitors(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b13bd8*/ void RenderSpecialOverlays(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b13f30*/ void EndFrame();

                class OverlaySettings
                {
                    /*0x10*/ bool linearDepth;
                    /*0x14*/ float motionColorIntensity;
                    /*0x18*/ int motionGridSize;
                    /*0x1c*/ UnityEngine.Rendering.PostProcessing.ColorBlindnessType colorBlindnessType;
                    /*0x20*/ float colorBlindnessStrength;

                    /*0x7b140a0*/ OverlaySettings();
                }
            }

            class PostProcessEffectRenderer
            {
                /*0x10*/ bool m_ResetHistory;

                /*0x7b140e0*/ PostProcessEffectRenderer();
                /*0x7b140bc*/ void Init();
                /*0x7b140c0*/ UnityEngine.DepthTextureMode GetCameraFlags();
                /*0x7b140c8*/ void ResetHistory();
                /*0x7b140d4*/ void Release();
                /*0x3816710*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x3816710*/ void SetSettings(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings settings);
            }

            class PostProcessEffectRenderer<T> : UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer
            {
                /*0x0*/ T <settings>k__BackingField;

                /*0x38159dc*/ PostProcessEffectRenderer();
                /*0x3910ae8*/ T get_settings();
                /*0x3910ae8*/ void set_settings(T value);
                /*0x3816710*/ void SetSettings(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings settings);
            }

            class PostProcessEffectSettings : UnityEngine.ScriptableObject
            {
                /*0x18*/ bool active;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.BoolParameter enabled;
                /*0x28*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.PostProcessing.ParameterOverride> parameters;

                /*0x7b14dec*/ PostProcessEffectSettings();
                /*0x7b140f0*/ void OnEnable();
                /*0x7b14604*/ void OnDisable();
                /*0x7b14888*/ void SetAllOverridesTo(bool state, bool excludeEnabled);
                /*0x7b14b2c*/ bool IsEnabledAndSupported(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b14b48*/ int GetHash();
                /*0x7b14e68*/ UnityEngine.Rendering.PostProcessing.ParameterOverride <OnEnable>b__3_2(System.Reflection.FieldInfo t);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.FieldInfo, bool> <>9__3_0;
                    static /*0x10*/ System.Func<System.Reflection.FieldInfo, int> <>9__3_1;

                    static /*0x7b14f00*/ <>c();
                    /*0x7b14f68*/ <>c();
                    /*0x7b14f70*/ bool <OnEnable>b__3_0(System.Reflection.FieldInfo t);
                    /*0x7b15014*/ int <OnEnable>b__3_1(System.Reflection.FieldInfo t);
                }
            }

            enum PostProcessEvent
            {
                BeforeTransparent = 0,
                BeforeStack = 1,
                AfterStack = 2,
            }

            struct PostProcessEventComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Rendering.PostProcessing.PostProcessEvent>
            {
                /*0x7b1503c*/ bool Equals(UnityEngine.Rendering.PostProcessing.PostProcessEvent x, UnityEngine.Rendering.PostProcessing.PostProcessEvent y);
                /*0x7b15048*/ int GetHashCode(UnityEngine.Rendering.PostProcessing.PostProcessEvent obj);
            }

            class PostProcessLayer : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform volumeTrigger;
                /*0x28*/ UnityEngine.LayerMask volumeLayer;
                /*0x2c*/ bool stopNaNPropagation;
                /*0x2d*/ bool finalBlitToCameraTarget;
                /*0x30*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer.Antialiasing antialiasingMode;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.TemporalAntialiasing temporalAntialiasing;
                /*0x40*/ UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.FastApproximateAntialiasing fastApproximateAntialiasing;
                /*0x50*/ UnityEngine.Rendering.PostProcessing.Fog fog;
                /*0x58*/ UnityEngine.Rendering.PostProcessing.Dithering dithering;
                /*0x60*/ UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer debugLayer;
                /*0x68*/ UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources;
                /*0x70*/ UnityEngine.Rendering.PostProcessing.PostProcessResources m_OldResources;
                /*0x78*/ bool m_ShowToolkit;
                /*0x79*/ bool m_ShowCustomSorter;
                /*0x7a*/ bool breakBeforeColorGrading;
                /*0x80*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles;
                /*0x88*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles;
                /*0x90*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef> m_AfterStackBundles;
                /*0x98*/ System.Collections.Generic.Dictionary<UnityEngine.Rendering.PostProcessing.PostProcessEvent, System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField;
                /*0xa0*/ UnityEngine.DepthTextureMode <cameraDepthFlags>k__BackingField;
                /*0xa4*/ bool <haveBundlesBeenInited>k__BackingField;
                /*0xa8*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.PostProcessing.PostProcessBundle> m_Bundles;
                /*0xb0*/ UnityEngine.Rendering.PostProcessing.PropertySheetFactory m_PropertySheetFactory;
                /*0xb8*/ UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferBeforeReflections;
                /*0xc0*/ UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferBeforeLighting;
                /*0xc8*/ UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferOpaque;
                /*0xd0*/ UnityEngine.Rendering.CommandBuffer m_LegacyCmdBuffer;
                /*0xd8*/ UnityEngine.Camera m_Camera;
                /*0xe0*/ UnityEngine.Rendering.PostProcessing.PostProcessRenderContext m_CurrentContext;
                /*0xe8*/ UnityEngine.Rendering.PostProcessing.LogHistogram m_LogHistogram;
                /*0xf0*/ bool m_SettingsUpdateNeeded;
                /*0xf1*/ bool m_IsRenderingInSceneView;
                /*0xf8*/ UnityEngine.Rendering.PostProcessing.TargetPool m_TargetPool;
                /*0x100*/ bool m_NaNKilled;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer> m_ActiveEffects;
                /*0x110*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderTargetIdentifier> m_Targets;

                static /*0x7b17a60*/ bool RequiresInitialBlit(UnityEngine.Camera camera, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b1ce00*/ PostProcessLayer();
                /*0x7b15050*/ System.Collections.Generic.Dictionary<UnityEngine.Rendering.PostProcessing.PostProcessEvent, System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef>> get_sortedBundles();
                /*0x7b15058*/ void set_sortedBundles(System.Collections.Generic.Dictionary<UnityEngine.Rendering.PostProcessing.PostProcessEvent, System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef>> value);
                /*0x7b15060*/ UnityEngine.DepthTextureMode get_cameraDepthFlags();
                /*0x7b15068*/ void set_cameraDepthFlags(UnityEngine.DepthTextureMode value);
                /*0x7b15070*/ bool get_haveBundlesBeenInited();
                /*0x7b15078*/ void set_haveBundlesBeenInited(bool value);
                /*0x7b15084*/ void OnEnable();
                /*0x7b15900*/ void InitLegacy();
                /*0x7b15b4c*/ bool DynamicResolutionAllowsFinalBlitToCameraTarget();
                /*0x7b15ca4*/ void OnRenderImage(UnityEngine.RenderTexture src, UnityEngine.RenderTexture dst);
                /*0x7b151c8*/ void Init(UnityEngine.Rendering.PostProcessing.PostProcessResources resources);
                /*0x7b15330*/ void InitBundles();
                /*0x7b15dd4*/ void UpdateBundleSortList(System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef> sortedList, UnityEngine.Rendering.PostProcessing.PostProcessEvent evt);
                /*0x7b16530*/ void OnDisable();
                /*0x7b1697c*/ void Reset();
                /*0x7b169a0*/ void OnPreCull();
                /*0x7b179dc*/ void OnPreRender();
                /*0x7b17a68*/ void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, UnityEngine.Rendering.RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining);
                /*0x7b16e3c*/ void BuildCommandBuffers();
                /*0x7b19244*/ void OnPostRender();
                /*0x38148bc*/ UnityEngine.Rendering.PostProcessing.PostProcessBundle GetBundle<T>();
                /*0x7b193c4*/ UnityEngine.Rendering.PostProcessing.PostProcessBundle GetBundle(System.Type settingsType);
                /*0x3910ae8*/ T GetSettings<T>();
                /*0x7b1941c*/ void BakeMSVOMap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Rendering.RenderTargetIdentifier destination, System.Nullable<UnityEngine.Rendering.RenderTargetIdentifier> depthMap, bool invert, bool isMSAA);
                /*0x7b19528*/ void OverrideSettings(System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> baseSettings, float interpFactor);
                /*0x7b197c0*/ void SetLegacyCameraFlags(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b19a38*/ void ResetHistory();
                /*0x7b183a8*/ bool HasOpaqueOnlyEffects(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b19bb0*/ bool HasActiveEffects(UnityEngine.Rendering.PostProcessing.PostProcessEvent evt, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b18028*/ void SetupContext(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b181cc*/ void UpdateVolumeSystem(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b186a8*/ void RenderOpaqueOnly(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b18790*/ void Render(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b1b0e4*/ int RenderInjectionPoint(UnityEngine.Rendering.PostProcessing.PostProcessEvent evt, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, string marker, int releaseTargetAfterUse);
                /*0x7b1a4f0*/ void RenderList(System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef> list, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, string marker);
                /*0x7b1c2f4*/ void ApplyFlip(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, UnityEngine.MaterialPropertyBlock properties);
                /*0x7b1c398*/ void ApplyDefaultFlip(UnityEngine.MaterialPropertyBlock properties);
                /*0x7b1b280*/ int RenderBuiltins(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse, int eye);
                /*0x7b1bb04*/ void RenderFinalPass(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, int releaseTargetAfterUse, int eye);
                /*0x3910ae8*/ int RenderEffect<T>(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, bool useTempTarget);
                /*0x7b1c61c*/ bool ShouldGenerateLogHistogram(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);

                enum Antialiasing
                {
                    None = 0,
                    FastApproximateAntialiasing = 1,
                    SubpixelMorphologicalAntialiasing = 2,
                    TemporalAntialiasing = 3,
                }

                class SerializedBundleRef
                {
                    /*0x10*/ string assemblyQualifiedName;
                    /*0x18*/ UnityEngine.Rendering.PostProcessing.PostProcessBundle bundle;

                    /*0x7b16520*/ SerializedBundleRef();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<System.Type, UnityEngine.Rendering.PostProcessing.PostProcessBundle>, UnityEngine.Rendering.PostProcessing.PostProcessBundle> <>9__54_1;

                    static /*0x7b1cee8*/ <>c();
                    /*0x7b1cf50*/ <>c();
                    /*0x7b1cf58*/ UnityEngine.Rendering.PostProcessing.PostProcessBundle <UpdateBundleSortList>b__54_1(System.Collections.Generic.KeyValuePair<System.Type, UnityEngine.Rendering.PostProcessing.PostProcessBundle> kvp);
                }

                class <>c__DisplayClass54_0
                {
                    /*0x10*/ UnityEngine.Rendering.PostProcessing.PostProcessEvent evt;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessBundle> effects;

                    /*0x7b16510*/ <>c__DisplayClass54_0();
                    /*0x7b1cf94*/ bool <UpdateBundleSortList>b__0(System.Collections.Generic.KeyValuePair<System.Type, UnityEngine.Rendering.PostProcessing.PostProcessBundle> kvp);
                    /*0x7b1d004*/ bool <UpdateBundleSortList>b__2(UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef x);
                }

                class <>c__DisplayClass54_1
                {
                    /*0x10*/ string searchStr;

                    /*0x7b1d0f8*/ <>c__DisplayClass54_1();
                    /*0x7b1d100*/ bool <UpdateBundleSortList>b__3(UnityEngine.Rendering.PostProcessing.PostProcessBundle b);
                }

                class <>c__DisplayClass54_2
                {
                    /*0x10*/ string typeName;

                    /*0x7b16518*/ <>c__DisplayClass54_2();
                    /*0x7b1d144*/ bool <UpdateBundleSortList>b__4(UnityEngine.Rendering.PostProcessing.PostProcessLayer.SerializedBundleRef b);
                }

                class <>c__DisplayClass54_3
                {
                    /*0x10*/ string typeName;

                    /*0x7b16528*/ <>c__DisplayClass54_3();
                    /*0x7b1d168*/ bool <UpdateBundleSortList>b__5(UnityEngine.Rendering.PostProcessing.PostProcessBundle b);
                }
            }

            class PostProcessManager
            {
                static /*0x0*/ UnityEngine.Rendering.PostProcessing.PostProcessManager s_Instance;
                /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume>> m_SortedVolumes;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> m_Volumes;
                /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> m_BaseSettings;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;
                /*0x38*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.PostProcessing.PostProcessAttribute> settingsTypes;

                static /*0x7b15d50*/ UnityEngine.Rendering.PostProcessing.PostProcessManager get_instance();
                static /*0x7b1e810*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> volumes);
                /*0x7b1d1ac*/ PostProcessManager();
                /*0x7b1d950*/ void CleanBaseTypes();
                /*0x7b1d3d4*/ void ReloadBaseTypes();
                /*0x7b1db08*/ void SetLayerDirty(int layer);
                /*0x7b1dc8c*/ void UpdateVolumeLayer(UnityEngine.Rendering.PostProcessing.PostProcessVolume volume, int prevLayer, int newLayer);
                /*0x7b1de74*/ void Register(UnityEngine.Rendering.PostProcessing.PostProcessVolume volume, int layer);
                /*0x7b1e0d4*/ void Register(UnityEngine.Rendering.PostProcessing.PostProcessVolume volume);
                /*0x7b1dccc*/ void Unregister(UnityEngine.Rendering.PostProcessing.PostProcessVolume volume, int layer);
                /*0x7b1e11c*/ void Unregister(UnityEngine.Rendering.PostProcessing.PostProcessVolume volume);
                /*0x7b1e16c*/ void ReplaceData(UnityEngine.Rendering.PostProcessing.PostProcessLayer postProcessLayer);
                /*0x7b19f6c*/ void UpdateSettings(UnityEngine.Rendering.PostProcessing.PostProcessLayer postProcessLayer, UnityEngine.Camera camera);
                /*0x7b1e3e0*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessVolume> GrabVolumes(UnityEngine.LayerMask mask);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.PostProcessManager.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__12_0;

                    static /*0x7b1e944*/ <>c();
                    /*0x7b1e9ac*/ <>c();
                    /*0x7b1e9b4*/ bool <ReloadBaseTypes>b__12_0(System.Type t);
                }
            }

            class PostProcessProfile : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> settings;
                /*0x20*/ bool isDirty;

                /*0x7b1f124*/ PostProcessProfile();
                /*0x7b1ea58*/ void OnEnable();
                /*0x3910ae8*/ T AddSettings<T>();
                /*0x7b1eb5c*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings AddSettings(System.Type type);
                /*0x7b1eeb4*/ UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings AddSettings(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings effect);
                /*0x38159dc*/ void RemoveSettings<T>();
                /*0x7b1efd4*/ void RemoveSettings(System.Type type);
                /*0x3813ffc*/ bool HasSettings<T>();
                /*0x7b1ed0c*/ bool HasSettings(System.Type type);
                /*0x3910ae8*/ T GetSetting<T>();
                /*0x38141c4*/ bool TryGetSettings<T>(ref T outSetting);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> <>9__2_0;

                    static /*0x7b1f1b4*/ <>c();
                    /*0x7b1f21c*/ <>c();
                    /*0x7b1f224*/ bool <OnEnable>b__2_0(UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings x);
                }
            }

            class PostProcessRenderContext
            {
                /*0x10*/ UnityEngine.Camera m_Camera;
                /*0x18*/ UnityEngine.Rendering.CommandBuffer <command>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.RenderTargetIdentifier <source>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.RenderTargetIdentifier <destination>k__BackingField;
                /*0x70*/ UnityEngine.RenderTextureFormat <sourceFormat>k__BackingField;
                /*0x74*/ bool <flip>k__BackingField;
                /*0x78*/ UnityEngine.Rendering.PostProcessing.PostProcessResources <resources>k__BackingField;
                /*0x80*/ UnityEngine.Rendering.PostProcessing.PropertySheetFactory <propertySheets>k__BackingField;
                /*0x88*/ System.Collections.Generic.Dictionary<string, object> <userData>k__BackingField;
                /*0x90*/ UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer <debugLayer>k__BackingField;
                /*0x98*/ int <width>k__BackingField;
                /*0x9c*/ int <height>k__BackingField;
                /*0xa0*/ bool <stereoActive>k__BackingField;
                /*0xa4*/ int <xrActiveEye>k__BackingField;
                /*0xa8*/ int <numberOfEyes>k__BackingField;
                /*0xac*/ UnityEngine.Rendering.PostProcessing.PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField;
                /*0xb0*/ int <screenWidth>k__BackingField;
                /*0xb4*/ int <screenHeight>k__BackingField;
                /*0xb8*/ bool <isSceneView>k__BackingField;
                /*0xbc*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer.Antialiasing <antialiasing>k__BackingField;
                /*0xc0*/ UnityEngine.Rendering.PostProcessing.TemporalAntialiasing <temporalAntialiasing>k__BackingField;
                /*0xc8*/ UnityEngine.Rendering.PostProcessing.PropertySheet uberSheet;
                /*0xd0*/ UnityEngine.Texture autoExposureTexture;
                /*0xd8*/ UnityEngine.Rendering.PostProcessing.LogHistogram logHistogram;
                /*0xe0*/ UnityEngine.Texture logLut;
                /*0xe8*/ UnityEngine.Rendering.PostProcessing.AutoExposure autoExposure;
                /*0xf0*/ int bloomBufferNameID;
                /*0xf4*/ bool physicalCamera;
                /*0xf8*/ UnityEngine.RenderTextureDescriptor m_sourceDescriptor;

                /*0x7b15b44*/ PostProcessRenderContext();
                /*0x7b1f280*/ UnityEngine.Camera get_camera();
                /*0x7b17ee4*/ void set_camera(UnityEngine.Camera value);
                /*0x7b1f288*/ UnityEngine.Rendering.CommandBuffer get_command();
                /*0x7b1f290*/ void set_command(UnityEngine.Rendering.CommandBuffer value);
                /*0x7b1f298*/ UnityEngine.Rendering.RenderTargetIdentifier get_source();
                /*0x7b1f2ac*/ void set_source(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b1f2c0*/ UnityEngine.Rendering.RenderTargetIdentifier get_destination();
                /*0x7b1f2d8*/ void set_destination(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b1f2f0*/ UnityEngine.RenderTextureFormat get_sourceFormat();
                /*0x7b1f2f8*/ void set_sourceFormat(UnityEngine.RenderTextureFormat value);
                /*0x7b1f300*/ bool get_flip();
                /*0x7b1f308*/ void set_flip(bool value);
                /*0x7b1f314*/ UnityEngine.Rendering.PostProcessing.PostProcessResources get_resources();
                /*0x7b1f31c*/ void set_resources(UnityEngine.Rendering.PostProcessing.PostProcessResources value);
                /*0x7b1f324*/ UnityEngine.Rendering.PostProcessing.PropertySheetFactory get_propertySheets();
                /*0x7b1f32c*/ void set_propertySheets(UnityEngine.Rendering.PostProcessing.PropertySheetFactory value);
                /*0x7b1f334*/ System.Collections.Generic.Dictionary<string, object> get_userData();
                /*0x7b1f33c*/ void set_userData(System.Collections.Generic.Dictionary<string, object> value);
                /*0x7b1f344*/ UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer get_debugLayer();
                /*0x7b1f34c*/ void set_debugLayer(UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer value);
                /*0x7b1f354*/ int get_width();
                /*0x7b1f35c*/ void set_width(int value);
                /*0x7b1f364*/ int get_height();
                /*0x7b1f36c*/ void set_height(int value);
                /*0x7b1f374*/ bool get_stereoActive();
                /*0x7b1f37c*/ void set_stereoActive(bool value);
                /*0x7b1f388*/ int get_xrActiveEye();
                /*0x7b1f390*/ void set_xrActiveEye(int value);
                /*0x7b1f398*/ int get_numberOfEyes();
                /*0x7b1f3a0*/ void set_numberOfEyes(int value);
                /*0x7b1f3a8*/ UnityEngine.Rendering.PostProcessing.PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode();
                /*0x7b1f3b0*/ void set_stereoRenderingMode(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext.StereoRenderingMode value);
                /*0x7b1f3b8*/ int get_screenWidth();
                /*0x7b1f3c0*/ void set_screenWidth(int value);
                /*0x7b1f3c8*/ int get_screenHeight();
                /*0x7b1f3d0*/ void set_screenHeight(int value);
                /*0x7b1f3d8*/ bool get_isSceneView();
                /*0x7b1f3e0*/ void set_isSceneView(bool value);
                /*0x7b1f3ec*/ UnityEngine.Rendering.PostProcessing.PostProcessLayer.Antialiasing get_antialiasing();
                /*0x7b1f3f4*/ void set_antialiasing(UnityEngine.Rendering.PostProcessing.PostProcessLayer.Antialiasing value);
                /*0x7b1f3fc*/ UnityEngine.Rendering.PostProcessing.TemporalAntialiasing get_temporalAntialiasing();
                /*0x7b1f404*/ void set_temporalAntialiasing(UnityEngine.Rendering.PostProcessing.TemporalAntialiasing value);
                /*0x7b17cc8*/ void Reset();
                /*0x7b16e00*/ bool IsTemporalAntialiasingActive();
                /*0x7b1f40c*/ bool IsDebugOverlayEnabled(UnityEngine.Rendering.PostProcessing.DebugOverlay overlay);
                /*0x7b1f430*/ void PushDebugOverlay(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.PostProcessing.PropertySheet sheet, int pass);
                /*0x7b1f478*/ UnityEngine.RenderTextureDescriptor GetDescriptor(int depthBufferBits, UnityEngine.RenderTextureFormat colorFormat, UnityEngine.RenderTextureReadWrite readWrite);
                /*0x7b17ba8*/ void GetScreenSpaceTemporaryRT(UnityEngine.Rendering.CommandBuffer cmd, int nameID, int depthBufferBits, UnityEngine.RenderTextureFormat colorFormat, UnityEngine.RenderTextureReadWrite readWrite, UnityEngine.FilterMode filter, int widthOverride, int heightOverride);
                /*0x7b1f644*/ UnityEngine.RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits, UnityEngine.RenderTextureFormat colorFormat, UnityEngine.RenderTextureReadWrite readWrite, int widthOverride, int heightOverride);
                /*0x7b182c8*/ void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled);

                enum StereoRenderingMode
                {
                    MultiPass = 0,
                    SinglePass = 1,
                    SinglePassInstanced = 2,
                    SinglePassMultiview = 3,
                }
            }

            class PostProcessResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Texture2D[] blueNoise64;
                /*0x20*/ UnityEngine.Texture2D[] blueNoise256;
                /*0x28*/ UnityEngine.Rendering.PostProcessing.PostProcessResources.SMAALuts smaaLuts;
                /*0x30*/ UnityEngine.Rendering.PostProcessing.PostProcessResources.Shaders shaders;
                /*0x38*/ UnityEngine.Rendering.PostProcessing.PostProcessResources.ComputeShaders computeShaders;

                /*0x7b1f6cc*/ PostProcessResources();

                class Shaders
                {
                    /*0x10*/ UnityEngine.Shader bloom;
                    /*0x18*/ UnityEngine.Shader copy;
                    /*0x20*/ UnityEngine.Shader copyStd;
                    /*0x28*/ UnityEngine.Shader copyStdFromTexArray;
                    /*0x30*/ UnityEngine.Shader copyStdFromDoubleWide;
                    /*0x38*/ UnityEngine.Shader discardAlpha;
                    /*0x40*/ UnityEngine.Shader depthOfField;
                    /*0x48*/ UnityEngine.Shader finalPass;
                    /*0x50*/ UnityEngine.Shader grainBaker;
                    /*0x58*/ UnityEngine.Shader motionBlur;
                    /*0x60*/ UnityEngine.Shader temporalAntialiasing;
                    /*0x68*/ UnityEngine.Shader subpixelMorphologicalAntialiasing;
                    /*0x70*/ UnityEngine.Shader texture2dLerp;
                    /*0x78*/ UnityEngine.Shader uber;
                    /*0x80*/ UnityEngine.Shader lut2DBaker;
                    /*0x88*/ UnityEngine.Shader lightMeter;
                    /*0x90*/ UnityEngine.Shader gammaHistogram;
                    /*0x98*/ UnityEngine.Shader waveform;
                    /*0xa0*/ UnityEngine.Shader vectorscope;
                    /*0xa8*/ UnityEngine.Shader debugOverlays;
                    /*0xb0*/ UnityEngine.Shader deferredFog;
                    /*0xb8*/ UnityEngine.Shader scalableAO;
                    /*0xc0*/ UnityEngine.Shader multiScaleAO;
                    /*0xc8*/ UnityEngine.Shader screenSpaceReflections;

                    /*0x7b1f6d4*/ Shaders();
                }

                class ComputeShaders
                {
                    /*0x10*/ UnityEngine.ComputeShader autoExposure;
                    /*0x18*/ UnityEngine.ComputeShader exposureHistogram;
                    /*0x20*/ UnityEngine.ComputeShader lut3DBaker;
                    /*0x28*/ UnityEngine.ComputeShader texture3dLerp;
                    /*0x30*/ UnityEngine.ComputeShader gammaHistogram;
                    /*0x38*/ UnityEngine.ComputeShader waveform;
                    /*0x40*/ UnityEngine.ComputeShader vectorscope;
                    /*0x48*/ UnityEngine.ComputeShader multiScaleAODownsample1;
                    /*0x50*/ UnityEngine.ComputeShader multiScaleAODownsample2;
                    /*0x58*/ UnityEngine.ComputeShader multiScaleAORender;
                    /*0x60*/ UnityEngine.ComputeShader multiScaleAOUpsample;
                    /*0x68*/ UnityEngine.ComputeShader gaussianDownsample;

                    /*0x7b1f6dc*/ ComputeShaders();
                }

                class SMAALuts
                {
                    /*0x10*/ UnityEngine.Texture2D area;
                    /*0x18*/ UnityEngine.Texture2D search;

                    /*0x7b1f6e4*/ SMAALuts();
                }
            }

            class PostProcessVolume : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile sharedProfile;
                /*0x28*/ bool isGlobal;
                /*0x2c*/ float blendDistance;
                /*0x30*/ float weight;
                /*0x34*/ float priority;
                /*0x38*/ int m_PreviousLayer;
                /*0x3c*/ float m_PreviousPriority;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;
                /*0x48*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile m_InternalProfile;

                /*0x7b202e8*/ PostProcessVolume();
                /*0x7b1f6ec*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile get_profile();
                /*0x7b1f9ac*/ void set_profile(UnityEngine.Rendering.PostProcessing.PostProcessProfile value);
                /*0x7b1e798*/ UnityEngine.Rendering.PostProcessing.PostProcessProfile get_profileRef();
                /*0x7b1f9b4*/ bool HasInstantiatedProfile();
                /*0x7b1fa14*/ int get_previousLayer();
                /*0x7b1fa1c*/ void OnEnable();
                /*0x7b1fac0*/ void OnDisable();
                /*0x7b1fae0*/ void Update();
                /*0x7b1fb64*/ void OnDrawGizmos();
            }

            class ColorUtilities
            {
                static /*0x7b202f8*/ float StandardIlluminantY(float x);
                static /*0x7b20324*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
                static /*0x7b203b4*/ UnityEngine.Vector3 ComputeColorBalance(float temperature, float tint);
                static /*0x7b204b8*/ UnityEngine.Vector3 ColorToLift(UnityEngine.Vector4 color);
                static /*0x7b20500*/ UnityEngine.Vector3 ColorToInverseGamma(UnityEngine.Vector4 color);
                static /*0x7b20570*/ UnityEngine.Vector3 ColorToGain(UnityEngine.Vector4 color);
            }

            class HableCurve
            {
                /*0x10*/ float <whitePoint>k__BackingField;
                /*0x14*/ float <inverseWhitePoint>k__BackingField;
                /*0x18*/ float <x0>k__BackingField;
                /*0x1c*/ float <x1>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.HableCurve.Segment[] m_Segments;
                /*0x28*/ UnityEngine.Rendering.PostProcessing.HableCurve.Uniforms uniforms;

                /*0x7b205f8*/ HableCurve();
                /*0x7b205c0*/ void set_whitePoint(float value);
                /*0x7b205c8*/ float get_inverseWhitePoint();
                /*0x7b205d0*/ void set_inverseWhitePoint(float value);
                /*0x7b205d8*/ float get_x0();
                /*0x7b205e0*/ void set_x0(float value);
                /*0x7b205e8*/ float get_x1();
                /*0x7b205f0*/ void set_x1(float value);
                /*0x7b20788*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
                /*0x7b208f0*/ void InitSegments(UnityEngine.Rendering.PostProcessing.HableCurve.DirectParams srcParams);
                /*0x7b20c08*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
                /*0x7b20ba4*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
                /*0x7b20bd0*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

                class Segment
                {
                    /*0x10*/ float offsetX;
                    /*0x14*/ float offsetY;
                    /*0x18*/ float scaleX;
                    /*0x1c*/ float scaleY;
                    /*0x20*/ float lnA;
                    /*0x24*/ float B;

                    /*0x7b20750*/ Segment();
                    /*0x7b20c58*/ float Eval(float x);
                }

                struct DirectParams
                {
                    /*0x10*/ float x0;
                    /*0x14*/ float y0;
                    /*0x18*/ float x1;
                    /*0x1c*/ float y1;
                    /*0x20*/ float W;
                    /*0x24*/ float overshootX;
                    /*0x28*/ float overshootY;
                    /*0x2c*/ float gamma;
                }

                class Uniforms
                {
                    /*0x10*/ UnityEngine.Rendering.PostProcessing.HableCurve parent;

                    /*0x7b20758*/ Uniforms(UnityEngine.Rendering.PostProcessing.HableCurve parent);
                    /*0x7b20cb4*/ UnityEngine.Vector4 get_curve();
                    /*0x7b20cd8*/ UnityEngine.Vector4 get_toeSegmentA();
                    /*0x7b20d14*/ UnityEngine.Vector4 get_toeSegmentB();
                    /*0x7b20d54*/ UnityEngine.Vector4 get_midSegmentA();
                    /*0x7b20d94*/ UnityEngine.Vector4 get_midSegmentB();
                    /*0x7b20dd8*/ UnityEngine.Vector4 get_shoSegmentA();
                    /*0x7b20e18*/ UnityEngine.Vector4 get_shoSegmentB();
                }
            }

            class HaltonSeq
            {
                static /*0x7b20e5c*/ float Get(int index, int radix);
            }

            class LogHistogram
            {
                static int rangeMin = -9;
                static int rangeMax = 9;
                static int k_Bins = 128;
                /*0x10*/ UnityEngine.ComputeBuffer <data>k__BackingField;

                /*0x7b15740*/ LogHistogram();
                /*0x7b20ea0*/ UnityEngine.ComputeBuffer get_data();
                /*0x7b20ea8*/ void set_data(UnityEngine.ComputeBuffer value);
                /*0x7b1c6b8*/ void Generate(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b10b3c*/ UnityEngine.Vector4 GetHistogramScaleOffsetRes(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b167bc*/ void Release();
            }

            class PostProcessEffectRendererExtensions
            {
                static /*0x7b185e8*/ System.Exception RenderOrLog(UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer self, UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
            }

            class PropertySheet
            {
                /*0x10*/ UnityEngine.MaterialPropertyBlock <properties>k__BackingField;
                /*0x18*/ UnityEngine.Material <material>k__BackingField;

                /*0x7b20ed0*/ PropertySheet(UnityEngine.Material material);
                /*0x7b20eb0*/ UnityEngine.MaterialPropertyBlock get_properties();
                /*0x7b20eb8*/ void set_properties(UnityEngine.MaterialPropertyBlock value);
                /*0x7b20ec0*/ UnityEngine.Material get_material();
                /*0x7b20ec8*/ void set_material(UnityEngine.Material value);
                /*0x7b10b1c*/ void ClearKeywords();
                /*0x7b10b68*/ void EnableKeyword(string keyword);
                /*0x7b20f58*/ void Release();
            }

            class PropertySheetFactory
            {
                /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Shader, UnityEngine.Rendering.PostProcessing.PropertySheet> m_Sheets;

                /*0x7b15748*/ PropertySheetFactory();
                /*0x7b10278*/ UnityEngine.Rendering.PostProcessing.PropertySheet Get(UnityEngine.Shader shader);
                /*0x7b167e8*/ void Release();
            }

            class RuntimeUtilities
            {
                static /*0x0*/ UnityEngine.Texture2D m_WhiteTexture;
                static /*0x8*/ UnityEngine.Texture2D m_BlackTexture;
                static /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Texture2D> m_LutStrips;
                static /*0x18*/ UnityEngine.Rendering.PostProcessing.PostProcessResources s_Resources;
                static /*0x20*/ UnityEngine.Mesh s_FullscreenTriangle;
                static /*0x28*/ UnityEngine.Material s_CopyStdMaterial;
                static /*0x30*/ UnityEngine.Material s_CopyStdFromDoubleWideMaterial;
                static /*0x38*/ UnityEngine.Material s_CopyMaterial;
                static /*0x40*/ UnityEngine.Material s_CopyFromTexArrayMaterial;
                static /*0x48*/ UnityEngine.Rendering.PostProcessing.PropertySheet s_CopySheet;
                static /*0x50*/ UnityEngine.Rendering.PostProcessing.PropertySheet s_CopyFromTexArraySheet;
                static /*0x58*/ System.Collections.Generic.IEnumerable<System.Type> m_AssemblyTypes;

                static /*0x7b22400*/ RuntimeUtilities();
                static /*0x7b1c430*/ UnityEngine.Texture2D get_whiteTexture();
                static /*0x7b20fc0*/ UnityEngine.Texture2D get_blackTexture();
                static /*0x7b12a8c*/ UnityEngine.Texture2D GetLutStrip(int size);
                static /*0x7b211d8*/ UnityEngine.Mesh get_fullscreenTriangle();
                static /*0x7b183b4*/ UnityEngine.Material get_copyStdMaterial();
                static /*0x7b1ad80*/ UnityEngine.Material get_copyStdFromDoubleWideMaterial();
                static /*0x7b21554*/ UnityEngine.Material get_copyMaterial();
                static /*0x7b216a4*/ UnityEngine.Material get_copyFromTexArrayMaterial();
                static /*0x7b1b018*/ UnityEngine.Rendering.PostProcessing.PropertySheet get_copySheet();
                static /*0x7b1aab8*/ UnityEngine.Rendering.PostProcessing.PropertySheet get_copyFromTexArraySheet();
                static /*0x7b19dc8*/ bool isValidResources();
                static /*0x7b19e54*/ void UpdateResources(UnityEngine.Rendering.PostProcessing.PostProcessResources resources);
                static /*0x7b217f4*/ void SetRenderTargetWithLoadStoreAction(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                static /*0x7b2183c*/ void SetRenderTargetWithLoadStoreAction(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x7b11ccc*/ void BlitFullscreenTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, bool clear, System.Nullable<UnityEngine.Rect> viewport, bool preserveDepth);
                static /*0x7b21884*/ void BlitFullscreenTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, UnityEngine.Rendering.RenderBufferLoadAction loadAction, System.Nullable<UnityEngine.Rect> viewport, bool preserveDepth);
                static /*0x7b10484*/ void BlitFullscreenTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, bool clear, System.Nullable<UnityEngine.Rect> viewport, bool preserveDepth);
                static /*0x7b1aed0*/ void BlitFullscreenTriangleFromDoubleWide(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int pass, int eye);
                static /*0x7b1cc70*/ void BlitFullscreenTriangleToDoubleWide(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, int eye);
                static /*0x7b1ab84*/ void BlitFullscreenTriangleFromTexArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, bool clear, int depthSlice);
                static /*0x7b1ca8c*/ void BlitFullscreenTriangleToTexArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, bool clear, int depthSlice);
                static /*0x7b21b30*/ void BlitFullscreenTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier[] destinations, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.PostProcessing.PropertySheet propertySheet, int pass, bool clear, System.Nullable<UnityEngine.Rect> viewport);
                static /*0x7b18504*/ void BuiltinBlit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material mat, int pass);
                static /*0x7b21d34*/ void CopyTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination);
                static /*0x7b15874*/ bool get_scriptableRenderPipelineActive();
                static /*0x7b19398*/ bool get_isSinglePassStereoEnabled();
                static /*0x7b10c68*/ bool get_isAndroidOpenGL();
                static /*0x7b10cdc*/ bool get_isWebNonWebGPU();
                static /*0x7b17c98*/ UnityEngine.RenderTextureFormat get_defaultHDRRenderTextureFormat();
                static /*0x7b17ca0*/ bool isFloatingPointFormat(UnityEngine.RenderTextureFormat format);
                static /*0x7b1c5b8*/ bool hasAlpha(UnityEngine.RenderTextureFormat format);
                static /*0x7b10d58*/ void Destroy(UnityEngine.Object obj);
                static /*0x7b1025c*/ bool get_isLinearColorSpace();
                static /*0x7b21e80*/ bool IsResolvedDepthAvailable(UnityEngine.Camera camera);
                static /*0x7b15be8*/ bool IsDynamicResolutionEnabled(UnityEngine.Camera camera);
                static /*0x3840c74*/ void CreateIfNull<T>(ref T obj);
                static /*0x7b10b84*/ float Exp2(float x);
                static /*0x7b21ef0*/ UnityEngine.Matrix4x4 GetJitteredPerspectiveProjectionMatrix(UnityEngine.Camera camera, UnityEngine.Vector2 offset);
                static /*0x7b2204c*/ UnityEngine.Matrix4x4 GetJitteredOrthographicProjectionMatrix(UnityEngine.Camera camera, UnityEngine.Vector2 offset);
                static /*0x7b2214c*/ UnityEngine.Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context, UnityEngine.Matrix4x4 origProj, UnityEngine.Vector2 jitter);
                static /*0x7b22268*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
                static /*0x3836db8*/ System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
                static /*0x3910ae8*/ T GetAttribute<T>(System.Type type);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.RuntimeUtilities.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__93_0;

                    static /*0x7b22490*/ <>c();
                    /*0x7b224f8*/ <>c();
                    /*0x7b22500*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__93_0(System.Reflection.Assembly t);
                }

                class <>c__94<T>
                {
                    static /*0x0*/ UnityEngine.Rendering.PostProcessing.RuntimeUtilities.<>c__94<T> <>9;
                    static /*0x0*/ System.Func<System.Type, bool> <>9__94_0;

                    static /*0x383e7a0*/ <>c__94();
                    /*0x38159dc*/ <>c__94();
                    /*0x38141c4*/ bool <GetAllTypesDerivedFrom>b__94_0(System.Type t);
                }
            }

            class ShaderIDs
            {
                static /*0x0*/ int MainTex;
                static /*0x4*/ int Jitter;
                static /*0x8*/ int Sharpness;
                static /*0xc*/ int FinalBlendParameters;
                static /*0x10*/ int HistoryTex;
                static /*0x14*/ int SMAA_Flip;
                static /*0x18*/ int SMAA_Flop;
                static /*0x1c*/ int AOParams;
                static /*0x20*/ int AOColor;
                static /*0x24*/ int OcclusionTexture1;
                static /*0x28*/ int OcclusionTexture2;
                static /*0x2c*/ int SAOcclusionTexture;
                static /*0x30*/ int MSVOcclusionTexture;
                static /*0x34*/ int DepthCopy;
                static /*0x38*/ int LinearDepth;
                static /*0x3c*/ int LowDepth1;
                static /*0x40*/ int LowDepth2;
                static /*0x44*/ int LowDepth3;
                static /*0x48*/ int LowDepth4;
                static /*0x4c*/ int TiledDepth1;
                static /*0x50*/ int TiledDepth2;
                static /*0x54*/ int TiledDepth3;
                static /*0x58*/ int TiledDepth4;
                static /*0x5c*/ int Occlusion1;
                static /*0x60*/ int Occlusion2;
                static /*0x64*/ int Occlusion3;
                static /*0x68*/ int Occlusion4;
                static /*0x6c*/ int Combined1;
                static /*0x70*/ int Combined2;
                static /*0x74*/ int Combined3;
                static /*0x78*/ int SSRResolveTemp;
                static /*0x7c*/ int Noise;
                static /*0x80*/ int Test;
                static /*0x84*/ int Resolve;
                static /*0x88*/ int History;
                static /*0x8c*/ int ViewMatrix;
                static /*0x90*/ int InverseViewMatrix;
                static /*0x94*/ int ScreenSpaceProjectionMatrix;
                static /*0x98*/ int Params2;
                static /*0x9c*/ int FogColor;
                static /*0xa0*/ int FogParams;
                static /*0xa4*/ int VelocityScale;
                static /*0xa8*/ int MaxBlurRadius;
                static /*0xac*/ int RcpMaxBlurRadius;
                static /*0xb0*/ int VelocityTex;
                static /*0xb4*/ int Tile2RT;
                static /*0xb8*/ int Tile4RT;
                static /*0xbc*/ int Tile8RT;
                static /*0xc0*/ int TileMaxOffs;
                static /*0xc4*/ int TileMaxLoop;
                static /*0xc8*/ int TileVRT;
                static /*0xcc*/ int NeighborMaxTex;
                static /*0xd0*/ int LoopCount;
                static /*0xd4*/ int DepthOfFieldTemp;
                static /*0xd8*/ int DepthOfFieldTex;
                static /*0xdc*/ int Distance;
                static /*0xe0*/ int LensCoeff;
                static /*0xe4*/ int MaxCoC;
                static /*0xe8*/ int RcpMaxCoC;
                static /*0xec*/ int RcpAspect;
                static /*0xf0*/ int CoCTex;
                static /*0xf4*/ int TaaParams;
                static /*0xf8*/ int AutoExposureTex;
                static /*0xfc*/ int HistogramBuffer;
                static /*0x100*/ int Params;
                static /*0x104*/ int ScaleOffsetRes;
                static /*0x108*/ int BloomTex;
                static /*0x10c*/ int SampleScale;
                static /*0x110*/ int Threshold;
                static /*0x114*/ int ColorIntensity;
                static /*0x118*/ int Bloom_DirtTex;
                static /*0x11c*/ int Bloom_Settings;
                static /*0x120*/ int Bloom_Color;
                static /*0x124*/ int Bloom_DirtTileOffset;
                static /*0x128*/ int ChromaticAberration_Amount;
                static /*0x12c*/ int ChromaticAberration_SpectralLut;
                static /*0x130*/ int Distortion_CenterScale;
                static /*0x134*/ int Distortion_Amount;
                static /*0x138*/ int Lut2D;
                static /*0x13c*/ int Lut3D;
                static /*0x140*/ int Lut3D_Params;
                static /*0x144*/ int Lut2D_Params;
                static /*0x148*/ int UserLut2D_Params;
                static /*0x14c*/ int PostExposure;
                static /*0x150*/ int ColorBalance;
                static /*0x154*/ int ColorFilter;
                static /*0x158*/ int HueSatCon;
                static /*0x15c*/ int Brightness;
                static /*0x160*/ int ChannelMixerRed;
                static /*0x164*/ int ChannelMixerGreen;
                static /*0x168*/ int ChannelMixerBlue;
                static /*0x16c*/ int Lift;
                static /*0x170*/ int InvGamma;
                static /*0x174*/ int Gain;
                static /*0x178*/ int Curves;
                static /*0x17c*/ int CustomToneCurve;
                static /*0x180*/ int ToeSegmentA;
                static /*0x184*/ int ToeSegmentB;
                static /*0x188*/ int MidSegmentA;
                static /*0x18c*/ int MidSegmentB;
                static /*0x190*/ int ShoSegmentA;
                static /*0x194*/ int ShoSegmentB;
                static /*0x198*/ int Vignette_Color;
                static /*0x19c*/ int Vignette_Center;
                static /*0x1a0*/ int Vignette_Settings;
                static /*0x1a4*/ int Vignette_Mask;
                static /*0x1a8*/ int Vignette_Opacity;
                static /*0x1ac*/ int Vignette_Mode;
                static /*0x1b0*/ int Grain_Params1;
                static /*0x1b4*/ int Grain_Params2;
                static /*0x1b8*/ int GrainTex;
                static /*0x1bc*/ int Phase;
                static /*0x1c0*/ int GrainNoiseParameters;
                static /*0x1c4*/ int LumaInAlpha;
                static /*0x1c8*/ int DitheringTex;
                static /*0x1cc*/ int Dithering_Coords;
                static /*0x1d0*/ int From;
                static /*0x1d4*/ int To;
                static /*0x1d8*/ int Interp;
                static /*0x1dc*/ int TargetColor;
                static /*0x1e0*/ int HalfResFinalCopy;
                static /*0x1e4*/ int WaveformSource;
                static /*0x1e8*/ int WaveformBuffer;
                static /*0x1ec*/ int VectorscopeBuffer;
                static /*0x1f0*/ int RenderViewportScaleFactor;
                static /*0x1f4*/ int UVTransform;
                static /*0x1f8*/ int DepthSlice;
                static /*0x1fc*/ int UVScaleOffset;
                static /*0x200*/ int PosScaleOffset;

                static /*0x7b225e4*/ ShaderIDs();
            }

            class Spline
            {
                /*0x10*/ UnityEngine.AnimationCurve curve;
                /*0x18*/ bool m_Loop;
                /*0x1c*/ float m_ZeroValue;
                /*0x20*/ float m_Range;
                /*0x28*/ UnityEngine.AnimationCurve m_InternalLoopingCurve;
                /*0x30*/ int frameCount;
                /*0x38*/ float[] cachedData;

                /*0x7b23c6c*/ Spline(UnityEngine.AnimationCurve curve, float zeroValue, bool loop, UnityEngine.Vector2 bounds);
                /*0x7b12210*/ void Cache(int frame);
                /*0x7b23d70*/ float Evaluate(float t, int length);
                /*0x7b23db4*/ int GetHashCode();
            }

            class TargetPool
            {
                /*0x10*/ System.Collections.Generic.List<int> m_Pool;
                /*0x18*/ int m_Current;

                /*0x7b157d0*/ TargetPool();
                /*0x7b17b84*/ int Get();
                /*0x7b23ddc*/ int Get(int i);
                /*0x7b1a4e8*/ void Reset();
            }

            class TextureFormatUtilities
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.RenderTextureFormat> s_FormatAliasMap;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, bool> s_SupportedRenderTextureFormats;
                static /*0x10*/ System.Collections.Generic.Dictionary<int, bool> s_SupportedTextureFormats;

                static /*0x7b23f3c*/ TextureFormatUtilities();
                static /*0x7b24a88*/ bool IsObsolete(object value);
                static /*0x7b24b98*/ UnityEngine.RenderTextureFormat GetUncompressedRenderTextureFormat(UnityEngine.Texture texture);
                static /*0x7b24d04*/ bool IsSupported(UnityEngine.RenderTextureFormat format);
                static /*0x7b21140*/ bool IsSupported(UnityEngine.TextureFormat format);
            }

            class TextureLerper
            {
                static /*0x0*/ UnityEngine.Rendering.PostProcessing.TextureLerper m_Instance;
                /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Command;
                /*0x18*/ UnityEngine.Rendering.PostProcessing.PropertySheetFactory m_PropertySheets;
                /*0x20*/ UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.RenderTexture> m_Recycled;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.RenderTexture> m_Actives;

                static /*0x7b24d9c*/ UnityEngine.Rendering.PostProcessing.TextureLerper get_instance();
                /*0x7b24e20*/ TextureLerper();
                /*0x7b24ecc*/ void BeginFrame(UnityEngine.Rendering.PostProcessing.PostProcessRenderContext context);
                /*0x7b24f18*/ void EndFrame();
                /*0x7b2513c*/ UnityEngine.RenderTexture Get(UnityEngine.RenderTextureFormat format, int w, int h, int d, bool enableRandomWrite, bool force3D);
                /*0x7b25450*/ UnityEngine.Texture Lerp(UnityEngine.Texture from, UnityEngine.Texture to, float t);
                /*0x7b25b38*/ UnityEngine.Texture Lerp(UnityEngine.Texture from, UnityEngine.Color to, float t);
                /*0x7b26150*/ void Clear();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> BEE794DBCD4CBBBF1C7DAF41EF192F0C8543F2C04DCD5D88F445D71BB75FC08A;

    struct __StaticArrayInitTypeSize=20
    {
    }
}
