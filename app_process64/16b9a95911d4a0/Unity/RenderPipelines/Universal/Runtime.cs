class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3bcb468*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x3bcb470*/ IsUnmanagedAttribute();
            }
        }
    }
}

class FullScreenPassRendererFeature_OldGUID : UnityEngine.Rendering.Universal.FullScreenPassRendererFeature, UnityEngine.ISerializationCallbackReceiver
{
    /*0x3bcb47c*/ FullScreenPassRendererFeature_OldGUID();
    /*0x3bcb478*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3bcb484*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3bcb578*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace Rendering
    {
        class RenderGraphGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;

            static /*0x3bcb6e0*/ RenderGraphGraphicsAutomatedTests();
            static /*0x3bcb580*/ bool get_activatedFromCommandLine();
            static /*0x3bcb688*/ bool get_enabled();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphGraphicsAutomatedTests.<> <>9;
                static /*0x8*/ System.Predicate<string> <>9__1_0;

                static /*0x3bcb730*/ <>c();
                /*0x3bcb798*/ <>c();
                /*0x3bcb7a0*/ bool <get_activatedFromCommandLine>b__1_0(string arg);
            }
        }

        namespace Universal
        {
            class ComponentUtility
            {
                static /*0x3bcb7ec*/ bool IsUniversalCamera(UnityEngine.Camera camera);
                static /*0x3bcb880*/ bool IsUniversalLight(UnityEngine.Light light);
            }

            class PostProcessData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessData.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessData.TextureResources textures;

                /*0x3bcb914*/ PostProcessData();

                class ShaderResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
                {
                    /*0x10*/ UnityEngine.Shader stopNanPS;
                    /*0x18*/ UnityEngine.Shader subpixelMorphologicalAntialiasingPS;
                    /*0x20*/ UnityEngine.Shader gaussianDepthOfFieldPS;
                    /*0x28*/ UnityEngine.Shader bokehDepthOfFieldPS;
                    /*0x30*/ UnityEngine.Shader cameraMotionBlurPS;
                    /*0x38*/ UnityEngine.Shader paniniProjectionPS;
                    /*0x40*/ UnityEngine.Shader lutBuilderLdrPS;
                    /*0x48*/ UnityEngine.Shader lutBuilderHdrPS;
                    /*0x50*/ UnityEngine.Shader bloomPS;
                    /*0x58*/ UnityEngine.Shader temporalAntialiasingPS;
                    /*0x60*/ UnityEngine.Shader LensFlareDataDrivenPS;
                    /*0x68*/ UnityEngine.Shader LensFlareScreenSpacePS;
                    /*0x70*/ UnityEngine.Shader scalingSetupPS;
                    /*0x78*/ UnityEngine.Shader easuPS;
                    /*0x80*/ UnityEngine.Shader uberPostPS;
                    /*0x88*/ UnityEngine.Shader finalPostPassPS;
                    /*0x90*/ int m_ShaderResourcesVersion;

                    /*0x3bcb92c*/ ShaderResources();
                    /*0x3bcb91c*/ int get_version();
                    /*0x3bcb924*/ bool get_isAvailableInPlayerBuild();
                }

                class TextureResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
                {
                    /*0x10*/ UnityEngine.Texture2D[] blueNoise16LTex;
                    /*0x18*/ UnityEngine.Texture2D[] filmGrainTex;
                    /*0x20*/ UnityEngine.Texture2D smaaAreaTex;
                    /*0x28*/ UnityEngine.Texture2D smaaSearchTex;
                    /*0x30*/ int m_TexturesResourcesVersion;

                    /*0x3bcb944*/ TextureResources();
                    /*0x3bcb934*/ int get_version();
                    /*0x3bcb93c*/ bool get_isAvailableInPlayerBuild();
                }
            }

            class StencilStateData
            {
                /*0x10*/ bool overrideStencilState;
                /*0x14*/ int stencilReference;
                /*0x18*/ UnityEngine.Rendering.CompareFunction stencilCompareFunction;
                /*0x1c*/ UnityEngine.Rendering.StencilOp passOperation;
                /*0x20*/ UnityEngine.Rendering.StencilOp failOperation;
                /*0x24*/ UnityEngine.Rendering.StencilOp zFailOperation;

                /*0x3bcb94c*/ StencilStateData();
            }

            enum ShadowQuality
            {
                Disabled = 0,
                HardShadows = 1,
                SoftShadows = 2,
            }

            enum SoftShadowQuality
            {
                UsePipelineSettings = 0,
                Low = 1,
                Medium = 2,
                High = 3,
            }

            enum ShadowResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
                _8192 = 8192,
            }

            enum LightCookieResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
            }

            enum LightCookieFormat
            {
                GrayscaleLow = 0,
                GrayscaleHigh = 1,
                ColorLow = 2,
                ColorHigh = 3,
                ColorHDR = 4,
            }

            enum HDRColorBufferPrecision
            {
                _32Bits = 0,
                _64Bits = 1,
            }

            enum MsaaQuality
            {
                Disabled = 1,
                _2x = 2,
                _4x = 4,
                _8x = 8,
            }

            enum Downsampling
            {
                None = 0,
                _2xBilinear = 1,
                _4xBox = 2,
                _4xBilinear = 3,
            }

            enum LightRenderingMode
            {
                Disabled = 0,
                PerVertex = 2,
                PerPixel = 1,
            }

            enum PipelineDebugLevel
            {
                Disabled = 0,
                Profiling = 1,
            }

            enum RendererType
            {
                Custom = 0,
                UniversalRenderer = 1,
                _2DRenderer = 2,
            }

            enum ColorGradingMode
            {
                LowDynamicRange = 0,
                HighDynamicRange = 1,
            }

            enum StoreActionsOptimization
            {
                Auto = 0,
                Discard = 1,
                Store = 2,
            }

            enum VolumeFrameworkUpdateMode
            {
                EveryFrame = 0,
                ViaScripting = 1,
                UsePipelineSettings = 2,
            }

            enum UpscalingFilterSelection
            {
                Auto = 0,
                Linear = 1,
                Point = 2,
                FSR = 3,
                STP = 4,
            }

            enum LODCrossFadeDitheringType
            {
                BayerMatrix = 0,
                BlueNoise = 1,
            }

            enum LightProbeSystem
            {
                LegacyLightProbes = 0,
                ProbeVolumes = 1,
            }

            enum ShEvalMode
            {
                Auto = 0,
                PerVertex = 1,
                Mixed = 2,
                PerPixel = 3,
            }

            struct DeprecationMessage
            {
                static string CompatibilityScriptingAPIObsolete = "This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.";
                static string CompatibilityScriptingAPIConsoleWarning = "The project currently uses the compatibility mode where the Render Graph API is disabled. Support for this mode will be removed in future Unity versions. Migrate existing ScriptableRenderPasses to the new RenderGraph API. After the migration, disable the compatibility mode in Edit > Projects Settings > Graphics > Render Graph.";
            }

            class UniversalRenderPipelineAsset : UnityEngine.Rendering.RenderPipelineAsset<UnityEngine.Rendering.Universal.UniversalRenderPipeline>, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IProbeVolumeEnabledRenderPipeline, UnityEngine.Rendering.IGPUResidentRenderPipeline, UnityEngine.Rendering.RenderGraphModule.IRenderGraphEnabledRenderPipeline, UnityEngine.Rendering.ISTPEnabledRenderPipeline
            {
                static int k_LastVersion = 12;
                static int k_MinLutSize = 16;
                static int k_MaxLutSize = 65;
                static int k_ShadowCascadeMinCount = 1;
                static int k_ShadowCascadeMaxCount = 4;
                static /*0x0*/ int AdditionalLightsDefaultShadowResolutionTierLow;
                static /*0x4*/ int AdditionalLightsDefaultShadowResolutionTierMedium;
                static /*0x8*/ int AdditionalLightsDefaultShadowResolutionTierHigh;
                static /*0x10*/ string[] s_Names;
                static /*0x18*/ int[] s_Values;
                static /*0x20*/ UnityEngine.Experimental.Rendering.GraphicsFormat[][] s_LightCookieFormatList;
                /*0x18*/ UnityEngine.Rendering.Universal.ScriptableRenderer[] m_Renderers;
                /*0x20*/ int k_AssetVersion;
                /*0x24*/ int k_AssetPreviousVersion;
                /*0x28*/ UnityEngine.Rendering.Universal.RendererType m_RendererType;
                /*0x30*/ UnityEngine.Rendering.Universal.ScriptableRendererData m_RendererData;
                /*0x38*/ UnityEngine.Rendering.Universal.ScriptableRendererData[] m_RendererDataList;
                /*0x40*/ int m_DefaultRendererIndex;
                /*0x44*/ bool m_RequireDepthTexture;
                /*0x45*/ bool m_RequireOpaqueTexture;
                /*0x48*/ UnityEngine.Rendering.Universal.Downsampling m_OpaqueDownsampling;
                /*0x4c*/ bool m_SupportsTerrainHoles;
                /*0x4d*/ bool m_SupportsHDR;
                /*0x50*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision m_HDRColorBufferPrecision;
                /*0x54*/ UnityEngine.Rendering.Universal.MsaaQuality m_MSAA;
                /*0x58*/ float m_RenderScale;
                /*0x5c*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection m_UpscalingFilter;
                /*0x60*/ bool m_FsrOverrideSharpness;
                /*0x64*/ float m_FsrSharpness;
                /*0x68*/ bool m_EnableLODCrossFade;
                /*0x6c*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType m_LODCrossFadeDitheringType;
                /*0x70*/ UnityEngine.Rendering.Universal.ShEvalMode m_ShEvalMode;
                /*0x74*/ UnityEngine.Rendering.Universal.LightProbeSystem m_LightProbeSystem;
                /*0x78*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_ProbeVolumeMemoryBudget;
                /*0x7c*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget m_ProbeVolumeBlendingMemoryBudget;
                /*0x80*/ bool m_SupportProbeVolumeGPUStreaming;
                /*0x81*/ bool m_SupportProbeVolumeDiskStreaming;
                /*0x82*/ bool m_SupportProbeVolumeScenarios;
                /*0x83*/ bool m_SupportProbeVolumeScenarioBlending;
                /*0x84*/ UnityEngine.Rendering.ProbeVolumeSHBands m_ProbeVolumeSHBands;
                /*0x88*/ UnityEngine.Rendering.Universal.LightRenderingMode m_MainLightRenderingMode;
                /*0x8c*/ bool m_MainLightShadowsSupported;
                /*0x90*/ UnityEngine.Rendering.Universal.ShadowResolution m_MainLightShadowmapResolution;
                /*0x94*/ UnityEngine.Rendering.Universal.LightRenderingMode m_AdditionalLightsRenderingMode;
                /*0x98*/ int m_AdditionalLightsPerObjectLimit;
                /*0x9c*/ bool m_AdditionalLightShadowsSupported;
                /*0xa0*/ UnityEngine.Rendering.Universal.ShadowResolution m_AdditionalLightsShadowmapResolution;
                /*0xa4*/ int m_AdditionalLightsShadowResolutionTierLow;
                /*0xa8*/ int m_AdditionalLightsShadowResolutionTierMedium;
                /*0xac*/ int m_AdditionalLightsShadowResolutionTierHigh;
                /*0xb0*/ bool m_ReflectionProbeBlending;
                /*0xb1*/ bool m_ReflectionProbeBoxProjection;
                /*0xb4*/ float m_ShadowDistance;
                /*0xb8*/ int m_ShadowCascadeCount;
                /*0xbc*/ float m_Cascade2Split;
                /*0xc0*/ UnityEngine.Vector2 m_Cascade3Split;
                /*0xc8*/ UnityEngine.Vector3 m_Cascade4Split;
                /*0xd4*/ float m_CascadeBorder;
                /*0xd8*/ float m_ShadowDepthBias;
                /*0xdc*/ float m_ShadowNormalBias;
                /*0xe0*/ bool m_SoftShadowsSupported;
                /*0xe1*/ bool m_ConservativeEnclosingSphere;
                /*0xe4*/ int m_NumIterationsEnclosingSphere;
                /*0xe8*/ UnityEngine.Rendering.Universal.SoftShadowQuality m_SoftShadowQuality;
                /*0xec*/ UnityEngine.Rendering.Universal.LightCookieResolution m_AdditionalLightsCookieResolution;
                /*0xf0*/ UnityEngine.Rendering.Universal.LightCookieFormat m_AdditionalLightsCookieFormat;
                /*0xf4*/ bool m_UseSRPBatcher;
                /*0xf5*/ bool m_SupportsDynamicBatching;
                /*0xf6*/ bool m_MixedLightingSupported;
                /*0xf7*/ bool m_SupportsLightCookies;
                /*0xf8*/ bool m_SupportsLightLayers;
                /*0xfc*/ UnityEngine.Rendering.Universal.PipelineDebugLevel m_DebugLevel;
                /*0x100*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimization;
                /*0x104*/ bool m_UseAdaptivePerformance;
                /*0x108*/ UnityEngine.Rendering.Universal.ColorGradingMode m_ColorGradingMode;
                /*0x10c*/ int m_ColorGradingLutSize;
                /*0x110*/ bool m_AllowPostProcessAlphaOutput;
                /*0x111*/ bool m_UseFastSRGBLinearConversion;
                /*0x112*/ bool m_SupportDataDrivenLensFlare;
                /*0x113*/ bool m_SupportScreenSpaceLensFlare;
                /*0x114*/ UnityEngine.Rendering.GPUResidentDrawerMode m_GPUResidentDrawerMode;
                /*0x118*/ float m_SmallMeshScreenPercentage;
                /*0x11c*/ bool m_GPUResidentDrawerEnableOcclusionCullingInCameras;
                /*0x120*/ UnityEngine.Rendering.Universal.ShadowQuality m_ShadowType;
                /*0x124*/ bool m_LocalShadowsSupported;
                /*0x128*/ UnityEngine.Rendering.Universal.ShadowResolution m_LocalShadowsAtlasResolution;
                /*0x12c*/ int m_MaxPixelLights;
                /*0x130*/ UnityEngine.Rendering.Universal.ShadowResolution m_ShadowAtlasResolution;
                /*0x134*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode;
                /*0x138*/ UnityEngine.Rendering.VolumeProfile m_VolumeProfile;
                /*0x140*/ UnityEngine.Rendering.ProbeVolumeSceneData apvScenesData;
                /*0x148*/ UnityEngine.Shader m_DefaultShader;
                /*0x150*/ int m_ShaderVariantLogLevel;
                /*0x154*/ UnityEngine.Rendering.Universal.ShadowCascadesOption m_ShadowCascades;
                /*0x158*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources m_Textures;

                static /*0x3bce010*/ UniversalRenderPipelineAsset();
                /*0x3bcde40*/ UniversalRenderPipelineAsset();
                /*0x3bcb95c*/ bool IsAtLastVersion();
                /*0x3bcb96c*/ UnityEngine.Rendering.GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.get_gpuResidentDrawerSettings();
                /*0x3bcba50*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRendererData> get_rendererDataList();
                /*0x3bcba98*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRenderer> get_renderers();
                /*0x3bcbae0*/ bool get_isImmediateModeSupported();
                /*0x3bcbae8*/ UnityEngine.Rendering.Universal.ScriptableRendererData LoadBuiltinRendererData(UnityEngine.Rendering.Universal.RendererType type);
                /*0x3bcbb30*/ void EnsureGlobalSettings();
                /*0x3bcbb38*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
                /*0x3bcbcf4*/ void DestroyRenderers();
                /*0x3bcbf88*/ void DestroyRenderer(ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x3bcbfb8*/ void OnDisable();
                /*0x3bcbd54*/ void CreateRenderers();
                /*0x3bcbfd4*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x3bcc39c*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(int index);
                /*0x3bcc2dc*/ UnityEngine.Rendering.Universal.ScriptableRendererData get_scriptableRendererData();
                /*0x3bcc658*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_additionalLightsCookieFormat();
                /*0x3bcc880*/ UnityEngine.Vector2Int get_additionalLightsCookieResolution();
                /*0x3bcc88c*/ int[] get_rendererIndexList();
                /*0x3bcc924*/ bool get_supportsCameraDepthTexture();
                /*0x3bcc92c*/ void set_supportsCameraDepthTexture(bool value);
                /*0x3bcc934*/ bool get_supportsCameraOpaqueTexture();
                /*0x3bcc93c*/ void set_supportsCameraOpaqueTexture(bool value);
                /*0x3bcc944*/ UnityEngine.Rendering.Universal.Downsampling get_opaqueDownsampling();
                /*0x3bcc94c*/ bool get_supportsTerrainHoles();
                /*0x3bcc954*/ UnityEngine.Rendering.Universal.StoreActionsOptimization get_storeActionsOptimization();
                /*0x3bcc95c*/ void set_storeActionsOptimization(UnityEngine.Rendering.Universal.StoreActionsOptimization value);
                /*0x3bcc964*/ bool get_supportsHDR();
                /*0x3bcc96c*/ void set_supportsHDR(bool value);
                /*0x3bcc974*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x3bcc97c*/ void set_hdrColorBufferPrecision(UnityEngine.Rendering.Universal.HDRColorBufferPrecision value);
                /*0x3bcc984*/ int get_msaaSampleCount();
                /*0x3bcc98c*/ void set_msaaSampleCount(int value);
                /*0x3bcc994*/ float get_renderScale();
                /*0x3bcc99c*/ void set_renderScale(float value);
                /*0x3bcca30*/ bool get_enableLODCrossFade();
                /*0x3bcca38*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType get_lodCrossFadeDitheringType();
                /*0x3bcca40*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection get_upscalingFilter();
                /*0x3bcca48*/ void set_upscalingFilter(UnityEngine.Rendering.Universal.UpscalingFilterSelection value);
                /*0x3bcca50*/ bool get_fsrOverrideSharpness();
                /*0x3bcca58*/ void set_fsrOverrideSharpness(bool value);
                /*0x3bcca60*/ float get_fsrSharpness();
                /*0x3bcca68*/ void set_fsrSharpness(float value);
                /*0x3bcca70*/ UnityEngine.Rendering.Universal.ShEvalMode get_shEvalMode();
                /*0x3bcca78*/ void set_shEvalMode(UnityEngine.Rendering.Universal.ShEvalMode value);
                /*0x3bcca80*/ UnityEngine.Rendering.Universal.LightProbeSystem get_lightProbeSystem();
                /*0x3bcca88*/ void set_lightProbeSystem(UnityEngine.Rendering.Universal.LightProbeSystem value);
                /*0x3bcca90*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_probeVolumeMemoryBudget();
                /*0x3bcca98*/ void set_probeVolumeMemoryBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget value);
                /*0x3bccaa0*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget get_probeVolumeBlendingMemoryBudget();
                /*0x3bccaa8*/ void set_probeVolumeBlendingMemoryBudget(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget value);
                /*0x3bccab0*/ bool get_supportProbeVolumeStreaming();
                /*0x3bccab8*/ void set_supportProbeVolumeStreaming(bool value);
                /*0x3bccac0*/ bool get_supportProbeVolumeGPUStreaming();
                /*0x3bccac8*/ void set_supportProbeVolumeGPUStreaming(bool value);
                /*0x3bccad0*/ bool get_supportProbeVolumeDiskStreaming();
                /*0x3bccad8*/ void set_supportProbeVolumeDiskStreaming(bool value);
                /*0x3bccae0*/ bool get_supportProbeVolumeScenarios();
                /*0x3bccae8*/ void set_supportProbeVolumeScenarios(bool value);
                /*0x3bccaf0*/ bool get_supportProbeVolumeScenarioBlending();
                /*0x3bccaf8*/ void set_supportProbeVolumeScenarioBlending(bool value);
                /*0x3bccb00*/ UnityEngine.Rendering.ProbeVolumeSHBands get_probeVolumeSHBands();
                /*0x3bccb08*/ void set_probeVolumeSHBands(UnityEngine.Rendering.ProbeVolumeSHBands value);
                /*0x3bccb10*/ UnityEngine.Rendering.Universal.LightRenderingMode get_mainLightRenderingMode();
                /*0x3bccb18*/ void set_mainLightRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x3bccb20*/ bool get_supportsMainLightShadows();
                /*0x3bccb28*/ void set_supportsMainLightShadows(bool value);
                /*0x3bccb30*/ int get_mainLightShadowmapResolution();
                /*0x3bccb38*/ void set_mainLightShadowmapResolution(int value);
                /*0x3bccb40*/ UnityEngine.Rendering.Universal.LightRenderingMode get_additionalLightsRenderingMode();
                /*0x3bccb48*/ void set_additionalLightsRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x3bccb50*/ int get_maxAdditionalLightsCount();
                /*0x3bccb58*/ void set_maxAdditionalLightsCount(int value);
                /*0x3bccc10*/ bool get_supportsAdditionalLightShadows();
                /*0x3bccc18*/ void set_supportsAdditionalLightShadows(bool value);
                /*0x3bccc20*/ int get_additionalLightsShadowmapResolution();
                /*0x3bccc28*/ void set_additionalLightsShadowmapResolution(int value);
                /*0x3bccc30*/ int get_additionalLightsShadowResolutionTierLow();
                /*0x3bccc38*/ void set_additionalLightsShadowResolutionTierLow(int value);
                /*0x3bccc40*/ int get_additionalLightsShadowResolutionTierMedium();
                /*0x3bccc48*/ void set_additionalLightsShadowResolutionTierMedium(int value);
                /*0x3bccc50*/ int get_additionalLightsShadowResolutionTierHigh();
                /*0x3bccc58*/ void set_additionalLightsShadowResolutionTierHigh(int value);
                /*0x3bccc60*/ int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier);
                /*0x3bccd28*/ bool get_reflectionProbeBlending();
                /*0x3bccd30*/ void set_reflectionProbeBlending(bool value);
                /*0x3bccd38*/ bool ShouldUseReflectionProbeBlending();
                /*0x3bccd58*/ bool get_reflectionProbeBoxProjection();
                /*0x3bccd60*/ void set_reflectionProbeBoxProjection(bool value);
                /*0x3bccd68*/ float get_shadowDistance();
                /*0x3bccd70*/ void set_shadowDistance(float value);
                /*0x3bccd84*/ int get_shadowCascadeCount();
                /*0x3bccd8c*/ void set_shadowCascadeCount(int value);
                /*0x3bcce54*/ float get_cascade2Split();
                /*0x3bcce5c*/ void set_cascade2Split(float value);
                /*0x3bcce64*/ UnityEngine.Vector2 get_cascade3Split();
                /*0x3bcce6c*/ void set_cascade3Split(UnityEngine.Vector2 value);
                /*0x3bcce74*/ UnityEngine.Vector3 get_cascade4Split();
                /*0x3bcce80*/ void set_cascade4Split(UnityEngine.Vector3 value);
                /*0x3bcce8c*/ float get_cascadeBorder();
                /*0x3bcce94*/ void set_cascadeBorder(float value);
                /*0x3bcce9c*/ float get_shadowDepthBias();
                /*0x3bccea4*/ void set_shadowDepthBias(float value);
                /*0x3bccf30*/ float get_shadowNormalBias();
                /*0x3bccf38*/ void set_shadowNormalBias(float value);
                /*0x3bccf50*/ bool get_supportsSoftShadows();
                /*0x3bccf58*/ void set_supportsSoftShadows(bool value);
                /*0x3bccf60*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x3bccf68*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x3bccf70*/ bool get_supportsDynamicBatching();
                /*0x3bccf78*/ void set_supportsDynamicBatching(bool value);
                /*0x3bccf80*/ bool get_supportsMixedLighting();
                /*0x3bccf88*/ bool get_supportsLightCookies();
                /*0x3bccf90*/ bool get_supportsLightLayers();
                /*0x3bccf98*/ bool get_useRenderingLayers();
                /*0x3bccfa0*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x3bccfa8*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x3bccfb0*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
                /*0x3bccfc0*/ UnityEngine.Rendering.Universal.PipelineDebugLevel get_debugLevel();
                /*0x3bccfc8*/ bool get_useSRPBatcher();
                /*0x3bccfd0*/ void set_useSRPBatcher(bool value);
                /*0x3bccfd8*/ bool get_enableRenderGraph();
                /*0x3bcd0dc*/ void OnEnableRenderGraphChanged();
                /*0x3bcd0ec*/ UnityEngine.Rendering.Universal.ColorGradingMode get_colorGradingMode();
                /*0x3bcd0f4*/ void set_colorGradingMode(UnityEngine.Rendering.Universal.ColorGradingMode value);
                /*0x3bcd0fc*/ int get_colorGradingLutSize();
                /*0x3bcd104*/ void set_colorGradingLutSize(int value);
                /*0x3bcd124*/ bool get_allowPostProcessAlphaOutput();
                /*0x3bcd12c*/ bool get_useFastSRGBLinearConversion();
                /*0x3bcd134*/ bool get_supportScreenSpaceLensFlare();
                /*0x3bcd13c*/ bool get_supportDataDrivenLensFlare();
                /*0x3bcd144*/ bool get_useAdaptivePerformance();
                /*0x3bcd14c*/ void set_useAdaptivePerformance(bool value);
                /*0x3bcd154*/ bool get_conservativeEnclosingSphere();
                /*0x3bcd15c*/ void set_conservativeEnclosingSphere(bool value);
                /*0x3bcd164*/ int get_numIterationsEnclosingSphere();
                /*0x3bcd16c*/ void set_numIterationsEnclosingSphere(int value);
                /*0x3bcd174*/ string get_renderPipelineShaderTag();
                /*0x3bcd1b4*/ string[] get_renderingLayerMaskNames();
                /*0x3bcd204*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x3bcd298*/ string[] get_lightLayerMaskNames();
                /*0x3bcd2dc*/ UnityEngine.Rendering.GPUResidentDrawerMode get_gpuResidentDrawerMode();
                /*0x3bcd2e4*/ void set_gpuResidentDrawerMode(UnityEngine.Rendering.GPUResidentDrawerMode value);
                /*0x3bcd30c*/ bool get_gpuResidentDrawerEnableOcclusionCullingInCameras();
                /*0x3bcd314*/ void set_gpuResidentDrawerEnableOcclusionCullingInCameras(bool value);
                /*0x3bcd33c*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severty);
                /*0x3bcd4a8*/ float get_smallMeshScreenPercentage();
                /*0x3bcd4b0*/ void set_smallMeshScreenPercentage(float value);
                /*0x3bcd560*/ void OnBeforeSerialize();
                /*0x3bcd564*/ void OnAfterDeserialize();
                /*0x3bccebc*/ float ValidateShadowBias(float value);
                /*0x3bccb70*/ int ValidatePerObjectLights(int value);
                /*0x3bcc9b4*/ float ValidateRenderScale(float value);
                /*0x3bcd7f0*/ bool ValidateRendererDataList(bool partial);
                /*0x3bcd870*/ bool ValidateRendererData(int index);
                /*0x3bcd914*/ bool get_supportProbeVolume();
                /*0x3bcd924*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
                /*0x3bcd940*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
                /*0x3bcd948*/ bool get_isStpUsed();
                /*0x3bcd958*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DefaultMaterialType materialType);
                /*0x3bcd960*/ UnityEngine.Material get_defaultMaterial();
                /*0x3bcd968*/ UnityEngine.Material get_defaultParticleMaterial();
                /*0x3bcd970*/ UnityEngine.Material get_defaultLineMaterial();
                /*0x3bcd978*/ UnityEngine.Material get_defaultTerrainMaterial();
                /*0x3bcd980*/ UnityEngine.Material get_default2DMaterial();
                /*0x3bcd988*/ UnityEngine.Material get_default2DMaskMaterial();
                /*0x3bcd990*/ UnityEngine.Material get_decalMaterial();
                /*0x3bcd998*/ UnityEngine.Shader get_defaultShader();
                /*0x3bcda4c*/ UnityEngine.Shader get_terrainDetailLitShader();
                /*0x3bcdad8*/ UnityEngine.Shader get_terrainDetailGrassShader();
                /*0x3bcdb64*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
                /*0x3bcdbf0*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x3bcdc64*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.Universal.ShaderVariantLogLevel value);
                /*0x3bcdce0*/ UnityEngine.Rendering.Universal.ShadowCascadesOption get_shadowCascadeOption();
                /*0x3bcdd60*/ void set_shadowCascadeOption(UnityEngine.Rendering.Universal.ShadowCascadesOption value);
                /*0x3bcddc8*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources get_textures();

                class Strings
                {
                    static /*0x0*/ string notURPRenderer;
                    static /*0x8*/ string forwardPlusMissing;

                    static /*0x3bce220*/ Strings();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D blueNoise64LTex;
                    /*0x18*/ UnityEngine.Texture2D bayerMatrixTex;

                    /*0x3bcde38*/ TextureResources();
                    /*0x3bce2b8*/ bool NeedsReload();
                }
            }

            enum DefaultMaterialType
            {
                Default = 0,
                Particle = 1,
                Terrain = 2,
                Sprite = 3,
                SpriteMask = 4,
                Decal = 5,
            }

            class DebugDisplaySettingsCommon : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x3bce6e4*/ DebugDisplaySettingsCommon();
                /*0x3bce350*/ bool get_AreAnySettingsActive();
                /*0x3bce358*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
                {
                    static string k_GoToSectionString = "Go to Section...";

                    /*0x3bce3a8*/ SettingsPanel();
                    /*0x3bce6ec*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.DebugUI.Foldout foldout;

                        /*0x3bce6f4*/ <>c__DisplayClass3_0();
                        /*0x3bce6fc*/ void <.ctor>b__0();
                    }
                }
            }

            class DebugDisplaySettingsLighting : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugLightingMode <lightingDebugMode>k__BackingField;
                /*0x14*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode <hdrDebugMode>k__BackingField;

                /*0x3bcea14*/ DebugDisplaySettingsLighting();
                /*0x3bce7c4*/ UnityEngine.Rendering.Universal.DebugLightingMode get_lightingDebugMode();
                /*0x3bce7cc*/ void set_lightingDebugMode(UnityEngine.Rendering.Universal.DebugLightingMode value);
                /*0x3bce7d4*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags get_lightingFeatureFlags();
                /*0x3bce7dc*/ void set_lightingFeatureFlags(UnityEngine.Rendering.Universal.DebugLightingFeatureFlags value);
                /*0x3bce7e4*/ UnityEngine.Rendering.Universal.HDRDebugMode get_hdrDebugMode();
                /*0x3bce7ec*/ void set_hdrDebugMode(UnityEngine.Rendering.Universal.HDRDebugMode value);
                /*0x3bce7f4*/ bool get_AreAnySettingsActive();
                /*0x3bce81c*/ bool get_IsPostProcessingAllowed();
                /*0x3bce830*/ bool get_IsLightingActive();
                /*0x3bce838*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingDebugMode;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingFeatures;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDRDebugMode;

                    static /*0x3bcea1c*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x3bcebb4*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x3bcee40*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingFeatures(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x3bcf044*/ UnityEngine.Rendering.DebugUI.Widget CreateHDRDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x3bcee38*/ <>c__DisplayClass0_0();
                        /*0x3bcf2d0*/ int <CreateLightingDebugMode>b__0();
                        /*0x3bcf354*/ void <CreateLightingDebugMode>b__1(int value);
                        /*0x3bcf3e4*/ int <CreateLightingDebugMode>b__2();
                        /*0x3bcf468*/ void <CreateLightingDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x3bcf03c*/ <>c__DisplayClass1_0();
                        /*0x3bcf4f8*/ System.Enum <CreateLightingFeatures>b__0();
                        /*0x3bcf5a8*/ void <CreateLightingFeatures>b__1(System.Enum value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x3bcf2c8*/ <>c__DisplayClass2_0();
                        /*0x3bcf678*/ int <CreateHDRDebugMode>b__0();
                        /*0x3bcf6fc*/ void <CreateHDRDebugMode>b__1(int value);
                        /*0x3bcf78c*/ int <CreateHDRDebugMode>b__2();
                        /*0x3bcf810*/ void <CreateHDRDebugMode>b__3(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting>
                {
                    /*0x3bce890*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
                }
            }

            class DebugDisplaySettingsMaterial : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset m_AlbedoValidationPreset;
                /*0x1c*/ float <albedoMinLuminance>k__BackingField;
                /*0x20*/ float <albedoMaxLuminance>k__BackingField;
                /*0x24*/ float m_AlbedoHueTolerance;
                /*0x28*/ float m_AlbedoSaturationTolerance;
                /*0x2c*/ UnityEngine.Color <albedoCompareColor>k__BackingField;
                /*0x3c*/ float <metallicMinValue>k__BackingField;
                /*0x40*/ float <metallicMaxValue>k__BackingField;
                /*0x44*/ bool <renderingLayersSelectedLight>k__BackingField;
                /*0x45*/ bool <selectedLightShadowLayerMask>k__BackingField;
                /*0x48*/ uint <renderingLayerMask>k__BackingField;
                /*0x50*/ UnityEngine.Vector4[] debugRenderingLayersColors;
                /*0x58*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode <materialValidationMode>k__BackingField;
                /*0x5c*/ UnityEngine.Rendering.Universal.DebugMaterialMode <materialDebugMode>k__BackingField;
                /*0x60*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode <vertexAttributeDebugMode>k__BackingField;

                /*0x3bd0038*/ DebugDisplaySettingsMaterial();
                /*0x3bcf8a0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoValidationPreset();
                /*0x3bcf8a8*/ void set_albedoValidationPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value);
                /*0x3bcf8ec*/ float get_albedoMinLuminance();
                /*0x3bcf8f4*/ void set_albedoMinLuminance(float value);
                /*0x3bcf8fc*/ float get_albedoMaxLuminance();
                /*0x3bcf904*/ void set_albedoMaxLuminance(float value);
                /*0x3bcf90c*/ float get_albedoHueTolerance();
                /*0x3bcf924*/ void set_albedoHueTolerance(float value);
                /*0x3bcf92c*/ float get_albedoSaturationTolerance();
                /*0x3bcf944*/ void set_albedoSaturationTolerance(float value);
                /*0x3bcf94c*/ UnityEngine.Color get_albedoCompareColor();
                /*0x3bcf958*/ void set_albedoCompareColor(UnityEngine.Color value);
                /*0x3bcf964*/ float get_metallicMinValue();
                /*0x3bcf96c*/ void set_metallicMinValue(float value);
                /*0x3bcf974*/ float get_metallicMaxValue();
                /*0x3bcf97c*/ void set_metallicMaxValue(float value);
                /*0x3bcf984*/ bool get_renderingLayersSelectedLight();
                /*0x3bcf98c*/ void set_renderingLayersSelectedLight(bool value);
                /*0x3bcf994*/ bool get_selectedLightShadowLayerMask();
                /*0x3bcf99c*/ void set_selectedLightShadowLayerMask(bool value);
                /*0x3bcf9a4*/ uint get_renderingLayerMask();
                /*0x3bcf9ac*/ void set_renderingLayerMask(uint value);
                /*0x3bcf9b4*/ uint GetDebugLightLayersMask();
                /*0x3bcf9bc*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode get_materialValidationMode();
                /*0x3bcf9c4*/ void set_materialValidationMode(UnityEngine.Rendering.Universal.DebugMaterialValidationMode value);
                /*0x3bcf9cc*/ UnityEngine.Rendering.Universal.DebugMaterialMode get_materialDebugMode();
                /*0x3bcf9d4*/ void set_materialDebugMode(UnityEngine.Rendering.Universal.DebugMaterialMode value);
                /*0x3bcf9dc*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode get_vertexAttributeDebugMode();
                /*0x3bcf9e4*/ void set_vertexAttributeDebugMode(UnityEngine.Rendering.Universal.DebugVertexAttributeMode value);
                /*0x3bcf9ec*/ bool get_AreAnySettingsActive();
                /*0x3bcfa14*/ bool get_IsPostProcessingAllowed();
                /*0x3bcfa3c*/ bool get_IsLightingActive();
                /*0x3bcfa64*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                enum AlbedoDebugValidationPreset
                {
                    DefaultLuminance = 0,
                    BlackAcrylicPaint = 1,
                    DarkSoil = 2,
                    WornAsphalt = 3,
                    DryClaySoil = 4,
                    GreenGrass = 5,
                    OldConcrete = 6,
                    RedClayTile = 7,
                    DrySand = 8,
                    NewConcrete = 9,
                    WhiteAcrylicPaint = 10,
                    FreshSnow = 11,
                    BlueSky = 12,
                    Foliage = 13,
                    Custom = 14,
                }

                struct AlbedoDebugValidationPresetData
                {
                    /*0x10*/ string name;
                    /*0x18*/ UnityEngine.Color color;
                    /*0x28*/ float minLuminance;
                    /*0x2c*/ float maxLuminance;
                }

                class Strings
                {
                    static string AlbedoSettingsContainerName = "Albedo Settings";
                    static string MetallicSettingsContainerName = "Metallic Settings";
                    static string RenderingLayerMasksSettingsContainerName = "Rendering Layer Masks Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialOverride;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip VertexAttribute;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialValidationMode;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip RenderingLayersSelectedLight;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip SelectedLightShadowLayerMask;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip FilterRenderingLayerMask;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValidationPreset;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoCustomColor;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;
                    static /*0xb0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;
                    static /*0xc0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMinValue;
                    static /*0xd0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMaxValue;

                    static /*0x3bd0a50*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x3bd1040*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialOverride(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd12cc*/ UnityEngine.Rendering.DebugUI.Widget CreateVertexAttribute(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd1558*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd1898*/ UnityEngine.Rendering.DebugUI.Widget CreateRenderingLayersSelectedLight(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd1a50*/ UnityEngine.Rendering.DebugUI.Widget CreateSelectedLightShadowLayerMask(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd1c50*/ UnityEngine.Rendering.DebugUI.RenderingLayerField CreateFilterRenderingLayerMasks(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd1f0c*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd224c*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoCustomColor(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd2458*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMinLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd2614*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMaxLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd27d0*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoHueTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd29e8*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoSaturationTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd2c00*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMinValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x3bd2dbc*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMaxValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x10*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__6_4;

                        static /*0x3bd2f78*/ <>c();
                        /*0x3bd2fe0*/ <>c();
                        /*0x3bd2fe8*/ void <CreateMaterialValidationMode>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x3bd3048*/ void <CreateAlbedoPreset>b__6_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd12c4*/ <>c__DisplayClass0_0();
                        /*0x3bd30a8*/ int <CreateMaterialOverride>b__0();
                        /*0x3bd312c*/ void <CreateMaterialOverride>b__1(int value);
                        /*0x3bd31bc*/ int <CreateMaterialOverride>b__2();
                        /*0x3bd3240*/ void <CreateMaterialOverride>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd29e0*/ <>c__DisplayClass10_0();
                        /*0x3bd32d0*/ float <CreateAlbedoHueTolerance>b__0();
                        /*0x3bd3364*/ void <CreateAlbedoHueTolerance>b__1(float value);
                        /*0x3bd33fc*/ bool <CreateAlbedoHueTolerance>b__2();
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd2bf8*/ <>c__DisplayClass11_0();
                        /*0x3bd3488*/ float <CreateAlbedoSaturationTolerance>b__0();
                        /*0x3bd351c*/ void <CreateAlbedoSaturationTolerance>b__1(float value);
                        /*0x3bd35b4*/ bool <CreateAlbedoSaturationTolerance>b__2();
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd2db4*/ <>c__DisplayClass12_0();
                        /*0x3bd3640*/ float <CreateMetallicMinValue>b__0();
                        /*0x3bd36c4*/ void <CreateMetallicMinValue>b__1(float value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd2f70*/ <>c__DisplayClass13_0();
                        /*0x3bd375c*/ float <CreateMetallicMaxValue>b__0();
                        /*0x3bd37e0*/ void <CreateMetallicMaxValue>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd1550*/ <>c__DisplayClass1_0();
                        /*0x3bd3878*/ int <CreateVertexAttribute>b__0();
                        /*0x3bd38fc*/ void <CreateVertexAttribute>b__1(int value);
                        /*0x3bd398c*/ int <CreateVertexAttribute>b__2();
                        /*0x3bd3a10*/ void <CreateVertexAttribute>b__3(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd1890*/ <>c__DisplayClass2_0();
                        /*0x3bd3aa0*/ int <CreateMaterialValidationMode>b__0();
                        /*0x3bd3b24*/ void <CreateMaterialValidationMode>b__1(int value);
                        /*0x3bd3bb4*/ int <CreateMaterialValidationMode>b__2();
                        /*0x3bd3c38*/ void <CreateMaterialValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd1a48*/ <>c__DisplayClass3_0();
                        /*0x3bd3cc8*/ bool <CreateRenderingLayersSelectedLight>b__0();
                        /*0x3bd3d4c*/ void <CreateRenderingLayersSelectedLight>b__1(bool value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd1c48*/ <>c__DisplayClass4_0();
                        /*0x3bd3de0*/ bool <CreateSelectedLightShadowLayerMask>b__0();
                        /*0x3bd3e64*/ void <CreateSelectedLightShadowLayerMask>b__1(bool value);
                        /*0x3bd3ef8*/ bool <CreateSelectedLightShadowLayerMask>b__2();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd1f04*/ <>c__DisplayClass5_0();
                        /*0x3bd3f84*/ UnityEngine.RenderingLayerMask <CreateFilterRenderingLayerMasks>b__0();
                        /*0x3bd4034*/ void <CreateFilterRenderingLayerMasks>b__1(UnityEngine.RenderingLayerMask value);
                        /*0x3bd40f4*/ UnityEngine.Vector4 <CreateFilterRenderingLayerMasks>b__2(int index);
                        /*0x3bd41a4*/ void <CreateFilterRenderingLayerMasks>b__3(UnityEngine.Vector4 value, int index);
                        /*0x3bd4274*/ bool <CreateFilterRenderingLayerMasks>b__4();
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd2244*/ <>c__DisplayClass6_0();
                        /*0x3bd42f8*/ int <CreateAlbedoPreset>b__0();
                        /*0x3bd437c*/ void <CreateAlbedoPreset>b__1(int value);
                        /*0x3bd440c*/ int <CreateAlbedoPreset>b__2();
                        /*0x3bd4490*/ void <CreateAlbedoPreset>b__3(int value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd2450*/ <>c__DisplayClass7_0();
                        /*0x3bd4520*/ UnityEngine.Color <CreateAlbedoCustomColor>b__0();
                        /*0x3bd45a8*/ void <CreateAlbedoCustomColor>b__1(UnityEngine.Color value);
                        /*0x3bd4650*/ bool <CreateAlbedoCustomColor>b__2();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd260c*/ <>c__DisplayClass8_0();
                        /*0x3bd46dc*/ float <CreateAlbedoMinLuminance>b__0();
                        /*0x3bd4760*/ void <CreateAlbedoMinLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x3bd27c8*/ <>c__DisplayClass9_0();
                        /*0x3bd47f8*/ float <CreateAlbedoMaxLuminance>b__0();
                        /*0x3bd487c*/ void <CreateAlbedoMaxLuminance>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial>
                {
                    /*0x3bcfabc*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x3bd4914*/ <>c__DisplayClass0_0();
                        /*0x3bd491c*/ bool <.ctor>b__0();
                        /*0x3bd493c*/ bool <.ctor>b__1();
                        /*0x3bd495c*/ bool <.ctor>b__2();
                    }
                }
            }

            enum DebugWireframeMode
            {
                None = 0,
                Wireframe = 1,
                SolidWireframe = 2,
                ShadedWireframe = 3,
            }

            class DebugDisplaySettingsRendering : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugWireframeMode m_WireframeMode;
                /*0x14*/ bool m_Overdraw;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugOverdrawMode m_OverdrawMode;
                /*0x1c*/ int <maxOverdrawCount>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugFullScreenMode <fullScreenDebugMode>k__BackingField;
                /*0x24*/ int <stpDebugViewIndex>k__BackingField;
                /*0x28*/ int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField;
                /*0x2c*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode <sceneOverrideMode>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugMipInfoMode <mipInfoMode>k__BackingField;
                /*0x34*/ bool <mipDebugStatusShowCode>k__BackingField;
                /*0x38*/ UnityEngine.Rendering.Universal.DebugMipMapStatusMode <mipDebugStatusMode>k__BackingField;
                /*0x3c*/ float <mipDebugOpacity>k__BackingField;
                /*0x40*/ float <mipDebugRecentUpdateCooldown>k__BackingField;
                /*0x44*/ int <mipDebugMaterialTextureSlot>k__BackingField;
                /*0x48*/ bool <showInfoForAllSlots>k__BackingField;
                /*0x4c*/ UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture <mipDebugTerrainTexture>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode <postProcessingDebugMode>k__BackingField;
                /*0x54*/ bool <enableMsaa>k__BackingField;
                /*0x55*/ bool <enableHDR>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode <taaDebugMode>k__BackingField;
                /*0x5c*/ UnityEngine.Rendering.Universal.DebugValidationMode <validationMode>k__BackingField;
                /*0x60*/ UnityEngine.Rendering.Universal.PixelValidationChannels <validationChannels>k__BackingField;
                /*0x64*/ float <validationRangeMin>k__BackingField;
                /*0x68*/ float <validationRangeMax>k__BackingField;

                /*0x3bd52bc*/ DebugDisplaySettingsRendering();
                /*0x3bd497c*/ UnityEngine.Rendering.Universal.DebugWireframeMode get_wireframeMode();
                /*0x3bd4984*/ void set_wireframeMode(UnityEngine.Rendering.Universal.DebugWireframeMode value);
                /*0x3bd49dc*/ bool get_overdraw();
                /*0x3bd49e4*/ void set_overdraw(bool value);
                /*0x3bd4a14*/ UnityEngine.Rendering.Universal.DebugOverdrawMode get_overdrawMode();
                /*0x3bd4a1c*/ void set_overdrawMode(UnityEngine.Rendering.Universal.DebugOverdrawMode value);
                /*0x3bd4a40*/ int get_maxOverdrawCount();
                /*0x3bd4a48*/ void set_maxOverdrawCount(int value);
                /*0x3bd49b0*/ void UpdateDebugSceneOverrideMode();
                /*0x3bd4a50*/ UnityEngine.Rendering.Universal.DebugFullScreenMode get_fullScreenDebugMode();
                /*0x3bd4a58*/ void set_fullScreenDebugMode(UnityEngine.Rendering.Universal.DebugFullScreenMode value);
                /*0x3bd4a60*/ int get_stpDebugViewIndex();
                /*0x3bd4a68*/ void set_stpDebugViewIndex(int value);
                /*0x3bd4a70*/ int get_fullScreenDebugModeOutputSizeScreenPercent();
                /*0x3bd4a78*/ void set_fullScreenDebugModeOutputSizeScreenPercent(int value);
                /*0x3bd4a80*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode get_sceneOverrideMode();
                /*0x3bd4a88*/ void set_sceneOverrideMode(UnityEngine.Rendering.Universal.DebugSceneOverrideMode value);
                /*0x3bd4a90*/ UnityEngine.Rendering.Universal.DebugMipInfoMode get_mipInfoMode();
                /*0x3bd4a98*/ void set_mipInfoMode(UnityEngine.Rendering.Universal.DebugMipInfoMode value);
                /*0x3bd4aa0*/ bool get_mipDebugStatusShowCode();
                /*0x3bd4aa8*/ void set_mipDebugStatusShowCode(bool value);
                /*0x3bd4ab0*/ UnityEngine.Rendering.Universal.DebugMipMapStatusMode get_mipDebugStatusMode();
                /*0x3bd4ab8*/ void set_mipDebugStatusMode(UnityEngine.Rendering.Universal.DebugMipMapStatusMode value);
                /*0x3bd4ac0*/ float get_mipDebugOpacity();
                /*0x3bd4ac8*/ void set_mipDebugOpacity(float value);
                /*0x3bd4ad0*/ float get_mipDebugRecentUpdateCooldown();
                /*0x3bd4ad8*/ void set_mipDebugRecentUpdateCooldown(float value);
                /*0x3bd4ae0*/ int get_mipDebugMaterialTextureSlot();
                /*0x3bd4ae8*/ void set_mipDebugMaterialTextureSlot(int value);
                /*0x3bd4af0*/ bool get_showInfoForAllSlots();
                /*0x3bd4af8*/ void set_showInfoForAllSlots(bool value);
                /*0x3bd4b00*/ bool get_canAggregateData();
                /*0x3bd4b14*/ UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture get_mipDebugTerrainTexture();
                /*0x3bd4b1c*/ void set_mipDebugTerrainTexture(UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture value);
                /*0x3bd4b24*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode get_postProcessingDebugMode();
                /*0x3bd4b2c*/ void set_postProcessingDebugMode(UnityEngine.Rendering.Universal.DebugPostProcessingMode value);
                /*0x3bd4b34*/ bool get_enableMsaa();
                /*0x3bd4b3c*/ void set_enableMsaa(bool value);
                /*0x3bd4b44*/ bool get_enableHDR();
                /*0x3bd4b4c*/ void set_enableHDR(bool value);
                /*0x3bd4b54*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode get_taaDebugMode();
                /*0x3bd4b5c*/ void set_taaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode value);
                /*0x3bd4b64*/ UnityEngine.Rendering.Universal.DebugValidationMode get_validationMode();
                /*0x3bd4b6c*/ void set_validationMode(UnityEngine.Rendering.Universal.DebugValidationMode value);
                /*0x3bd4b74*/ UnityEngine.Rendering.Universal.PixelValidationChannels get_validationChannels();
                /*0x3bd4b7c*/ void set_validationChannels(UnityEngine.Rendering.Universal.PixelValidationChannels value);
                /*0x3bd4b84*/ float get_validationRangeMin();
                /*0x3bd4b8c*/ void set_validationRangeMin(float value);
                /*0x3bd4b94*/ float get_validationRangeMax();
                /*0x3bd4b9c*/ void set_validationRangeMax(float value);
                /*0x3bd4ba4*/ bool get_AreAnySettingsActive();
                /*0x3bd4bf8*/ bool get_IsPostProcessingAllowed();
                /*0x3bd4c20*/ bool get_IsLightingActive();
                /*0x3bd4c40*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x3bd4cf4*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                enum TaaDebugMode
                {
                    None = 0,
                    ShowRawFrame = 1,
                    ShowRawFrameNoJitter = 2,
                    ShowClampedHistory = 3,
                }

                class Strings
                {
                    static string RangeValidationSettingsContainerName = "Pixel Range Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapOverlays;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip StpDebugViews;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapSize;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip OverdrawMode;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaxOverdrawCount;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapDisableMipCaching;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapDebugView;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapDebugOpacity;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapMaterialTextureSlot;
                    static /*0xb0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapTerrainTexture;
                    static /*0xc0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapDisplayStatusCodes;
                    static /*0xd0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapActivityTimespan;
                    static /*0xe0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MipMapCombinePerMaterial;
                    static /*0xf0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PostProcessing;
                    static /*0x100*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MSAA;
                    static /*0x110*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDR;
                    static /*0x120*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip TaaDebugMode;
                    static /*0x130*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PixelValidationMode;
                    static /*0x140*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip Channels;
                    static /*0x150*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMin;
                    static /*0x160*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMax;

                    static /*0x3bd52fc*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x3bd5cbc*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlays(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd5f48*/ UnityEngine.Rendering.DebugUI.Widget CreateStpDebugViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd62a4*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlaySize(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd65f4*/ UnityEngine.Rendering.DebugUI.Widget CreateAdditionalWireframeShaderViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd6934*/ UnityEngine.Rendering.DebugUI.Widget CreateWireframeNotSupportedWarning(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd6a78*/ UnityEngine.Rendering.DebugUI.Widget CreateOverdrawMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd6d04*/ UnityEngine.Rendering.DebugUI.Widget CreateMaxOverdrawCount(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd70ac*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugWidget(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd7384*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd7608*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd8074*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSlotSelector(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel, System.Func<bool> hiddenCB, UnityEngine.GUIContent[] texSlotStrings, int[] texSlotValues);
                    static /*0x3bd84ec*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugCooldownSlider(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd82fc*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapShowStatusCodeToggle(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd8834*/ UnityEngine.Rendering.DebugUI.Widget CreatePostProcessing(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd8ac0*/ UnityEngine.Rendering.DebugUI.Widget CreateMSAA(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd8c70*/ UnityEngine.Rendering.DebugUI.Widget CreateHDR(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd8e20*/ UnityEngine.Rendering.DebugUI.Widget CreateTaaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd9160*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd94a0*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationChannels(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd972c*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMin(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x3bd98e8*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMax(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Func<int> <>9__2_2;
                        static /*0x10*/ System.Func<int> <>9__2_3;
                        static /*0x18*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__3_4;
                        static /*0x20*/ System.Func<int> <>9__6_3;
                        static /*0x28*/ System.Func<int> <>9__6_4;
                        static /*0x30*/ System.Func<bool> <>9__7_0;
                        static /*0x38*/ System.Action<bool> <>9__7_1;
                        static /*0x40*/ System.Func<float> <>9__9_4;
                        static /*0x48*/ System.Func<float> <>9__9_5;
                        static /*0x50*/ System.Func<bool> <>9__9_10;
                        static /*0x58*/ System.Func<float> <>9__11_3;
                        static /*0x60*/ System.Func<float> <>9__11_4;
                        static /*0x68*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__16_4;
                        static /*0x70*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__17_4;

                        static /*0x3bd9aa4*/ <>c();
                        /*0x3bd9b0c*/ <>c();
                        /*0x3bd9b14*/ int <CreateMapOverlaySize>b__2_2();
                        /*0x3bd9b1c*/ int <CreateMapOverlaySize>b__2_3();
                        /*0x3bd9b24*/ void <CreateAdditionalWireframeShaderViews>b__3_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x3bd9b84*/ int <CreateMaxOverdrawCount>b__6_3();
                        /*0x3bd9b8c*/ int <CreateMaxOverdrawCount>b__6_4();
                        /*0x3bd9b94*/ bool <CreateMipMapDebugWidget>b__7_0();
                        /*0x3bd9be4*/ void <CreateMipMapDebugWidget>b__7_1(bool value);
                        /*0x3bd9c3c*/ float <CreateMipMapDebugSettings>b__9_4();
                        /*0x3bd9c44*/ float <CreateMipMapDebugSettings>b__9_5();
                        /*0x3bd9c4c*/ bool <CreateMipMapDebugSettings>b__9_10();
                        /*0x3bd9c54*/ float <CreateMipMapDebugCooldownSlider>b__11_3();
                        /*0x3bd9c5c*/ float <CreateMipMapDebugCooldownSlider>b__11_4();
                        /*0x3bd9c68*/ void <CreateTaaDebugMode>b__16_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x3bd9cc8*/ void <CreatePixelValidationMode>b__17_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd5f40*/ <>c__DisplayClass0_0();
                        /*0x3bd9d28*/ int <CreateMapOverlays>b__0();
                        /*0x3bd9dac*/ void <CreateMapOverlays>b__1(int value);
                        /*0x3bd9e3c*/ int <CreateMapOverlays>b__2();
                        /*0x3bd9ec0*/ void <CreateMapOverlays>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd881c*/ <>c__DisplayClass10_0();
                        /*0x3bd9f50*/ int <CreateMipMapDebugSlotSelector>b__0();
                        /*0x3bd9fd4*/ void <CreateMipMapDebugSlotSelector>b__1(int value);
                        /*0x3bda064*/ int <CreateMipMapDebugSlotSelector>b__2();
                        /*0x3bda0e8*/ void <CreateMipMapDebugSlotSelector>b__3(int value);
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd8824*/ <>c__DisplayClass11_0();
                        /*0x3bda178*/ bool <CreateMipMapDebugCooldownSlider>b__0();
                        /*0x3bda204*/ float <CreateMipMapDebugCooldownSlider>b__1();
                        /*0x3bda288*/ void <CreateMipMapDebugCooldownSlider>b__2(float value);
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd882c*/ <>c__DisplayClass12_0();
                        /*0x3bda320*/ bool <CreateMipMapShowStatusCodeToggle>b__0();
                        /*0x3bda3ac*/ bool <CreateMipMapShowStatusCodeToggle>b__1();
                        /*0x3bda430*/ void <CreateMipMapShowStatusCodeToggle>b__2(bool value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd8ab8*/ <>c__DisplayClass13_0();
                        /*0x3bda4c4*/ int <CreatePostProcessing>b__0();
                        /*0x3bda548*/ void <CreatePostProcessing>b__1(int value);
                        /*0x3bda5d8*/ int <CreatePostProcessing>b__2();
                        /*0x3bda65c*/ void <CreatePostProcessing>b__3(int value);
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd8c68*/ <>c__DisplayClass14_0();
                        /*0x3bda6ec*/ bool <CreateMSAA>b__0();
                        /*0x3bda770*/ void <CreateMSAA>b__1(bool value);
                    }

                    class <>c__DisplayClass15_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd8e18*/ <>c__DisplayClass15_0();
                        /*0x3bda804*/ bool <CreateHDR>b__0();
                        /*0x3bda888*/ void <CreateHDR>b__1(bool value);
                    }

                    class <>c__DisplayClass16_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd9158*/ <>c__DisplayClass16_0();
                        /*0x3bda91c*/ int <CreateTaaDebugMode>b__0();
                        /*0x3bda9a0*/ void <CreateTaaDebugMode>b__1(int value);
                        /*0x3bdaa30*/ int <CreateTaaDebugMode>b__2();
                        /*0x3bdaab4*/ void <CreateTaaDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd9498*/ <>c__DisplayClass17_0();
                        /*0x3bdab44*/ int <CreatePixelValidationMode>b__0();
                        /*0x3bdabc8*/ void <CreatePixelValidationMode>b__1(int value);
                        /*0x3bdac58*/ int <CreatePixelValidationMode>b__2();
                        /*0x3bdacdc*/ void <CreatePixelValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd9724*/ <>c__DisplayClass18_0();
                        /*0x3bdad6c*/ int <CreatePixelValidationChannels>b__0();
                        /*0x3bdadf0*/ void <CreatePixelValidationChannels>b__1(int value);
                        /*0x3bdae80*/ int <CreatePixelValidationChannels>b__2();
                        /*0x3bdaf04*/ void <CreatePixelValidationChannels>b__3(int value);
                    }

                    class <>c__DisplayClass19_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd98e0*/ <>c__DisplayClass19_0();
                        /*0x3bdaf94*/ float <CreatePixelValueRangeMin>b__0();
                        /*0x3bdb018*/ void <CreatePixelValueRangeMin>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd629c*/ <>c__DisplayClass1_0();
                        /*0x3bdb0b0*/ bool <CreateStpDebugViews>b__0();
                        /*0x3bdb13c*/ int <CreateStpDebugViews>b__1();
                        /*0x3bdb1c0*/ void <CreateStpDebugViews>b__2(int value);
                        /*0x3bdb250*/ int <CreateStpDebugViews>b__3();
                        /*0x3bdb2d4*/ void <CreateStpDebugViews>b__4(int value);
                    }

                    class <>c__DisplayClass20_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd9a9c*/ <>c__DisplayClass20_0();
                        /*0x3bdb364*/ float <CreatePixelValueRangeMax>b__0();
                        /*0x3bdb3e8*/ void <CreatePixelValueRangeMax>b__1(float value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd65ec*/ <>c__DisplayClass2_0();
                        /*0x3bdb480*/ int <CreateMapOverlaySize>b__0();
                        /*0x3bdb504*/ void <CreateMapOverlaySize>b__1(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd692c*/ <>c__DisplayClass3_0();
                        /*0x3bdb594*/ int <CreateAdditionalWireframeShaderViews>b__0();
                        /*0x3bdb618*/ void <CreateAdditionalWireframeShaderViews>b__1(int value);
                        /*0x3bdb6cc*/ int <CreateAdditionalWireframeShaderViews>b__2();
                        /*0x3bdb750*/ void <CreateAdditionalWireframeShaderViews>b__3(int value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd6a70*/ <>c__DisplayClass4_0();
                        /*0x3bdb804*/ bool <CreateWireframeNotSupportedWarning>b__0();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd6cfc*/ <>c__DisplayClass5_0();
                        /*0x3bdb8b0*/ int <CreateOverdrawMode>b__0();
                        /*0x3bdb934*/ void <CreateOverdrawMode>b__1(int value);
                        /*0x3bdb9e0*/ int <CreateOverdrawMode>b__2();
                        /*0x3bdba64*/ void <CreateOverdrawMode>b__3(int value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd70a4*/ <>c__DisplayClass6_0();
                        /*0x3bdbb10*/ bool <CreateMaxOverdrawCount>b__0();
                        /*0x3bdbb9c*/ int <CreateMaxOverdrawCount>b__1();
                        /*0x3bdbc20*/ void <CreateMaxOverdrawCount>b__2(int value);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd8064*/ <>c__DisplayClass8_0();
                        /*0x3bdbcb0*/ int <CreateMipMapMode>b__0();
                        /*0x3bdbd34*/ void <CreateMipMapMode>b__1(int value);
                        /*0x3bdbdc4*/ int <CreateMipMapMode>b__2();
                        /*0x3bdbe48*/ void <CreateMipMapMode>b__3(int value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x3bd806c*/ <>c__DisplayClass9_0();
                        /*0x3bdbed8*/ bool <CreateMipMapDebugSettings>b__0();
                        /*0x3bdbf64*/ float <CreateMipMapDebugSettings>b__2();
                        /*0x3bdbfe8*/ void <CreateMipMapDebugSettings>b__3(float value);
                        /*0x3bdc080*/ bool <CreateMipMapDebugSettings>b__1();
                        /*0x3bdc110*/ bool <CreateMipMapDebugSettings>b__6();
                        /*0x3bdc1a0*/ bool <CreateMipMapDebugSettings>b__7();
                        /*0x3bdc224*/ void <CreateMipMapDebugSettings>b__8(bool value);
                        /*0x3bdc300*/ bool <CreateMipMapDebugSettings>b__9();
                        /*0x3bdc3e8*/ int <CreateMipMapDebugSettings>b__11();
                        /*0x3bdc46c*/ void <CreateMipMapDebugSettings>b__12(int value);
                        /*0x3bdc4fc*/ int <CreateMipMapDebugSettings>b__13();
                        /*0x3bdc580*/ void <CreateMipMapDebugSettings>b__14(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering>
                {
                    /*0x3bd4d4c*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x3bdc610*/ <>c__DisplayClass0_0();
                        /*0x3bdc618*/ bool <.ctor>b__0();
                    }
                }
            }

            class DebugHandler : UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                static /*0x0*/ int k_DebugColorInvalidModePropertyId;
                static /*0x4*/ int k_DebugCurrentRealTimeId;
                static /*0x8*/ int k_DebugColorPropertyId;
                static /*0xc*/ int k_DebugTexturePropertyId;
                static /*0x10*/ int k_DebugFontId;
                static /*0x14*/ int k_DebugTextureNoStereoPropertyId;
                static /*0x18*/ int k_DebugTextureDisplayRect;
                static /*0x1c*/ int k_DebugRenderTargetSupportsStereo;
                static /*0x20*/ int k_DebugRenderTargetRangeRemap;
                static /*0x24*/ int k_DebugMaterialModeId;
                static /*0x28*/ int k_DebugVertexAttributeModeId;
                static /*0x2c*/ int k_DebugMaterialValidationModeId;
                static /*0x30*/ int k_DebugMipInfoModeId;
                static /*0x34*/ int k_DebugMipMapStatusModeId;
                static /*0x38*/ int k_DebugMipMapShowStatusCodeId;
                static /*0x3c*/ int k_DebugMipMapOpacityId;
                static /*0x40*/ int k_DebugMipMapRecentlyUpdatedCooldownId;
                static /*0x44*/ int k_DebugMipMapTerrainTextureModeId;
                static /*0x48*/ int k_DebugSceneOverrideModeId;
                static /*0x4c*/ int k_DebugFullScreenModeId;
                static /*0x50*/ int k_DebugValidationModeId;
                static /*0x54*/ int k_DebugValidateBelowMinThresholdColorPropertyId;
                static /*0x58*/ int k_DebugValidateAboveMaxThresholdColorPropertyId;
                static /*0x5c*/ int k_DebugMaxPixelCost;
                static /*0x60*/ int k_DebugLightingModeId;
                static /*0x64*/ int k_DebugLightingFeatureFlagsId;
                static /*0x68*/ int k_DebugValidateAlbedoMinLuminanceId;
                static /*0x6c*/ int k_DebugValidateAlbedoMaxLuminanceId;
                static /*0x70*/ int k_DebugValidateAlbedoSaturationToleranceId;
                static /*0x74*/ int k_DebugValidateAlbedoHueToleranceId;
                static /*0x78*/ int k_DebugValidateAlbedoCompareColorId;
                static /*0x7c*/ int k_DebugValidateMetallicMinValueId;
                static /*0x80*/ int k_DebugValidateMetallicMaxValueId;
                static /*0x84*/ int k_ValidationChannelsId;
                static /*0x88*/ int k_RangeMinimumId;
                static /*0x8c*/ int k_RangeMaximumId;
                static /*0x90*/ UnityEngine.Rendering.ProfilingSampler s_DebugSetupSampler;
                static /*0x98*/ UnityEngine.Rendering.ProfilingSampler s_DebugFinalValidationSampler;
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData s_DebugSetupPassData;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData s_DebugFinalValidationPassData;
                /*0x20*/ UnityEngine.Material m_ReplacementMaterial;
                /*0x28*/ UnityEngine.Material m_HDRDebugViewMaterial;
                /*0x30*/ UnityEngine.Rendering.Universal.HDRDebugViewPass m_HDRDebugViewPass;
                /*0x38*/ UnityEngine.Rendering.RTHandle m_DebugScreenColorHandle;
                /*0x40*/ UnityEngine.Rendering.RTHandle m_DebugScreenDepthHandle;
                /*0x48*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures m_RuntimeTextures;
                /*0x50*/ bool m_HasDebugRenderTarget;
                /*0x51*/ bool m_DebugRenderTargetSupportsStereo;
                /*0x54*/ UnityEngine.Vector4 m_DebugRenderTargetPixelRect;
                /*0x64*/ UnityEngine.Vector4 m_DebugRenderTargetRangeRemap;
                /*0x78*/ UnityEngine.Rendering.RTHandle m_DebugRenderTarget;
                /*0x80*/ UnityEngine.Rendering.RTHandle m_DebugFontTexture;
                /*0x88*/ UnityEngine.GraphicsBuffer m_debugDisplayConstant;
                /*0x90*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings;

                static /*0x3bdf670*/ DebugHandler();
                static /*0x3bdcd94*/ void ConfigureColorDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x3bdcdd8*/ void ConfigureDepthDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x3bdd5d4*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data);
                static /*0x3bde370*/ void Setup(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData);
                /*0x3bdc850*/ DebugHandler();
                /*0x3bdc638*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x3bdc650*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x3bdc668*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x3bdc680*/ bool get_AreAnySettingsActive();
                /*0x3bdc69c*/ bool get_IsPostProcessingAllowed();
                /*0x3bdc6b8*/ bool get_IsLightingActive();
                /*0x3bdc6d4*/ bool get_IsActiveModeUnsupportedForDeferred();
                /*0x3bdc748*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x3bdc764*/ UnityEngine.Material get_ReplacementMaterial();
                /*0x3bdc76c*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings();
                /*0x3bdc774*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenColorHandle();
                /*0x3bdc77c*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenDepthHandle();
                /*0x3bdc784*/ UnityEngine.Rendering.Universal.HDRDebugViewPass get_hdrDebugViewPass();
                /*0x3bdc78c*/ bool HDRDebugViewIsActive(bool resolveFinalTarget);
                /*0x3bdc7bc*/ bool WriteToDebugScreenTexture(bool resolveFinalTarget);
                /*0x3bdc7c0*/ bool get_IsScreenClearNeeded();
                /*0x3bdc800*/ bool get_IsRenderPassSupported();
                /*0x3bdc82c*/ int get_stpDebugViewIndex();
                /*0x3bdcc58*/ void Dispose();
                /*0x3bdcd14*/ bool IsActiveForCamera(bool isPreviewCamera);
                /*0x3bdcd3c*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode);
                /*0x3bdcd58*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode, ref int textureHeightPercent);
                /*0x3bdce34*/ void SetupShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, int passIndex);
                /*0x3bdd37c*/ void SetDebugRenderTarget(UnityEngine.Rendering.RTHandle renderTarget, UnityEngine.Rect displayRect, bool supportsStereo, UnityEngine.Vector4 dataRangeRemap);
                /*0x3bdd3f4*/ void ResetDebugRenderTarget();
                /*0x3bdd3fc*/ UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData InitDebugFinalValidationPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x3bdd8c4*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x3bdda98*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x3bde2d8*/ UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData InitDebugSetupPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData, bool isPreviewCamera);
                /*0x3bde704*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, bool isPreviewCamera);
                /*0x3bde708*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isPreviewCamera);
                /*0x3bdeaf0*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);
                /*0x3bdebc0*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x3bdf1d0*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);

                class DebugFinalValidationPassData
                {
                    /*0x10*/ bool isFinalPass;
                    /*0x11*/ bool resolveFinalTarget;
                    /*0x12*/ bool isActiveForCamera;
                    /*0x13*/ bool hasDebugRenderTarget;
                    /*0x14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugRenderTargetHandle;
                    /*0x24*/ int debugTexturePropertyId;
                    /*0x28*/ UnityEngine.Vector4 debugRenderTargetPixelRect;
                    /*0x38*/ int debugRenderTargetSupportsStereo;
                    /*0x3c*/ UnityEngine.Vector4 debugRenderTargetRangeRemap;
                    /*0x4c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugFontTextureHandle;
                    /*0x60*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering renderingSettings;

                    /*0x3bdcc50*/ DebugFinalValidationPassData();
                }

                class DebugSetupPassData
                {
                    /*0x10*/ bool isActiveForCamera;
                    /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial materialSettings;
                    /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering renderingSettings;
                    /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting lightingSettings;

                    /*0x3bdcc48*/ DebugSetupPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DebugHandler.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__101_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__106_0;

                    static /*0x3bdfe1c*/ <>c();
                    /*0x3bdfe84*/ <>c();
                    /*0x3bdfe8c*/ void <UpdateShaderGlobalPropertiesForFinalValidationPass>b__101_0(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3bdfef0*/ void <Setup>b__106_0(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class DebugRendererLists
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DebugRenderSetup> m_DebugRenderSetups;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererList> m_ActiveDebugRendererList;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> m_ActiveDebugRendererListHdl;

                /*0x3bdec7c*/ DebugRendererLists(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x3bdfef4*/ void CreateDebugRenderSetups(UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x3be0064*/ void DisposeDebugRenderLists();
                /*0x3bdede8*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x3bdf28c*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x3be07c0*/ void PrepareRendererListForRasterPass(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder);
                /*0x3be0a04*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd);
            }

            class DebugRenderSetup : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ int m_Index;

                /*0x3be0010*/ DebugRenderSetup(UnityEngine.Rendering.Universal.DebugHandler debugHandler, int index, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x3be0e60*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x3be0e84*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x3be0ea8*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x3be0cec*/ void Begin(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x3be0df4*/ void End(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x3be0ecc*/ void CreateRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x3be0fec*/ void CreateRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl);
                /*0x3be0d58*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x3be0360*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.DrawingSettings drawingSettings);
                /*0x3be04a8*/ UnityEngine.Rendering.RenderStateBlock GetRenderStateBlock(UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x3be110c*/ int GetIndex();
                /*0x3be035c*/ void Dispose();
            }

            class UniversalRenderPipelineDebugDisplaySettings : UnityEngine.Rendering.DebugDisplaySettings<UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings>
            {
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon <commonSettings>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial <materialSettings>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering <renderingSettings>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting <lightingSettings>k__BackingField;
                /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume <volumeSettings>k__BackingField;
                /*0x40*/ UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> <displayStats>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer <gpuResidentDrawerSettings>k__BackingField;

                /*0x3be1474*/ UniversalRenderPipelineDebugDisplaySettings();
                /*0x3be1114*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon get_commonSettings();
                /*0x3be111c*/ void set_commonSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon value);
                /*0x3be1124*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_materialSettings();
                /*0x3be112c*/ void set_materialSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial value);
                /*0x3be1134*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_renderingSettings();
                /*0x3be113c*/ void set_renderingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering value);
                /*0x3be1144*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_lightingSettings();
                /*0x3be114c*/ void set_lightingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting value);
                /*0x3be1154*/ UnityEngine.Rendering.DebugDisplaySettingsVolume get_volumeSettings();
                /*0x3be115c*/ void set_volumeSettings(UnityEngine.Rendering.DebugDisplaySettingsVolume value);
                /*0x3be1164*/ UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> get_displayStats();
                /*0x3be116c*/ void set_displayStats(UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> value);
                /*0x3be1174*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer get_gpuResidentDrawerSettings();
                /*0x3be117c*/ void set_gpuResidentDrawerSettings(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer value);
                /*0x3be1184*/ bool get_IsPostProcessingAllowed();
                /*0x3be14f0*/ void Reset();
                /*0x3be1a38*/ void UpdateDisplayStats();
                /*0x3be1a98*/ void UpdateMaterials();
            }

            class UniversalRenderPipelineDebugDisplayStats : UnityEngine.Rendering.DebugDisplayStats<UnityEngine.Rendering.Universal.URPProfileId>
            {
                /*0x30*/ UnityEngine.Rendering.DebugFrameTiming m_DebugFrameTiming;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.URPProfileId> m_RecordedSamplers;

                /*0x3be18cc*/ UniversalRenderPipelineDebugDisplayStats();
                /*0x3be1b30*/ void EnableProfilingRecorders();
                /*0x3be1b88*/ void DisableProfilingRecorders();
                /*0x3be1dd8*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
                /*0x3be21bc*/ void Update();
                /*0x3be221c*/ bool <RegisterDebugUI>b__4_0();
                /*0x3be2224*/ void <RegisterDebugUI>b__4_1(bool value);
                /*0x3be222c*/ bool <RegisterDebugUI>b__4_2();
                /*0x3be2234*/ void <RegisterDebugUI>b__4_3(bool value);
            }

            class UniversalRenderPipelineVolumeDebugSettings : UnityEngine.Rendering.VolumeDebugSettings<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>
            {
                /*0x3be19cc*/ UniversalRenderPipelineVolumeDebugSettings();
                /*0x3be223c*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
                /*0x3be237c*/ UnityEngine.LayerMask get_selectedCameraLayerMask();
                /*0x3be2468*/ UnityEngine.Vector3 get_selectedCameraPosition();
                /*0x3be2568*/ System.Type get_targetRenderPipeline();
            }

            class DBufferCopyDepthPass : UnityEngine.Rendering.Universal.Internal.CopyDepthPass
            {
                /*0x3be25c8*/ DBufferCopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth);
                /*0x3be25d4*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            }

            class DecalDrawDBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x3be282c*/ DecalDrawDBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3be28ac*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ string[] s_DBufferNames;
                static /*0x8*/ string s_DBufferDepthName;
                static /*0x10*/ int s_SSAOTextureID;
                /*0xb8*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DrawSystem;
                /*0xc0*/ UnityEngine.Rendering.Universal.DBufferSettings m_Settings;
                /*0xc8*/ UnityEngine.Material m_DBufferClear;
                /*0xd0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xf8*/ UnityEngine.Rendering.ProfilingSampler m_DBufferClearSampler;
                /*0x100*/ bool m_DecalLayers;
                /*0x108*/ UnityEngine.Rendering.RTHandle m_DBufferDepth;
                /*0x110*/ UnityEngine.Rendering.Universal.DBufferRenderPass.PassData m_PassData;
                /*0x118*/ UnityEngine.Rendering.RTHandle[] <dBufferColorHandles>k__BackingField;
                /*0x120*/ UnityEngine.Rendering.RTHandle <depthHandle>k__BackingField;
                /*0x128*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] dbufferHandles;

                static /*0x3be53d8*/ DBufferRenderPass();
                static /*0x3be3ae8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList, bool renderGraph);
                static /*0x3be3688*/ void SetGlobalTextures(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x3be37a0*/ void SetKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x3be388c*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x3be28f8*/ DBufferRenderPass(UnityEngine.Material dBufferClear, UnityEngine.Rendering.Universal.DBufferSettings settings, UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem, bool decalLayers);
                /*0x3be28c0*/ UnityEngine.Rendering.RTHandle[] get_dBufferColorHandles();
                /*0x3be28c8*/ void set_dBufferColorHandles(UnityEngine.Rendering.RTHandle[] value);
                /*0x3be28d8*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                /*0x3be28e0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                /*0x3be28f0*/ UnityEngine.Rendering.RTHandle get_dBufferDepth();
                /*0x3be2c54*/ void Dispose();
                /*0x3be2ccc*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3be2e0c*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle depthTextureHandle);
                /*0x3be3144*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3be3150*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3be35e8*/ void InitPassData(ref UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x3be39bc*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3be3b4c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3be52e0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DBufferSettings settings;
                    /*0x20*/ UnityEngine.Material dBufferClear;
                    /*0x28*/ UnityEngine.Rendering.ProfilingSampler dBufferClearSampler;
                    /*0x30*/ bool decalLayers;
                    /*0x38*/ UnityEngine.Rendering.RTHandle dBufferDepth;
                    /*0x40*/ UnityEngine.Rendering.RTHandle[] dBufferColorHandles;
                    /*0x48*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3be5584*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__36_0;

                    static /*0x3be558c*/ <>c();
                    /*0x3be55f4*/ <>c();
                    /*0x3be55fc*/ void <RecordRenderGraph>b__36_0(UnityEngine.Rendering.Universal.DBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawFowardEmissiveSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x3be56b4*/ DecalDrawFowardEmissiveSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3be5880*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalForwardEmissivePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData m_PassData;

                static /*0x3be63a8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x3be5894*/ DecalForwardEmissivePass(UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem);
                /*0x3be5ea0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3be61ac*/ void InitPassData(ref UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData);
                /*0x3be61cc*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3be6634*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3be5e98*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__10_0;

                    static /*0x3be6d08*/ <>c();
                    /*0x3be6d70*/ <>c();
                    /*0x3be6d78*/ void <RecordRenderGraph>b__10_0(UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawErrorSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x40*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;

                /*0x3be6dd8*/ DecalDrawErrorSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, UnityEngine.Rendering.Universal.DecalTechnique technique);
                /*0x3be6e60*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x3be6ed0*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
            }

            class DecalPreviewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalPreviewPass.PassData m_PassData;

                static /*0x3be75c8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalPreviewPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x3be6fb8*/ DecalPreviewPass();
                /*0x3be7210*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3be7600*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3be7208*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalPreviewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalPreviewPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__8_0;

                    static /*0x3be7d8c*/ <>c();
                    /*0x3be7df4*/ <>c();
                    /*0x3be7dfc*/ void <RecordRenderGraph>b__8_0(UnityEngine.Rendering.Universal.DecalPreviewPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            enum DecalScaleMode
            {
                ScaleInvariant = 0,
                InheritFromHierarchy = 1,
            }

            class DecalProjector : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalAdd;
                static /*0x8*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalRemove;
                static /*0x10*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalPropertyChange;
                static /*0x18*/ System.Action onAllDecalPropertyChange;
                static /*0x20*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalMaterialChange;
                static /*0x28*/ UnityEngine.Material <defaultMaterial>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntity <decalEntity>k__BackingField;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ float m_DrawDistance;
                /*0x34*/ float m_FadeScale;
                /*0x38*/ float m_StartAngleFade;
                /*0x3c*/ float m_EndAngleFade;
                /*0x40*/ UnityEngine.Vector2 m_UVScale;
                /*0x48*/ UnityEngine.Vector2 m_UVBias;
                /*0x50*/ uint m_DecalLayerMask;
                /*0x54*/ UnityEngine.Rendering.Universal.DecalScaleMode m_ScaleMode;
                /*0x58*/ UnityEngine.Vector3 m_Offset;
                /*0x64*/ UnityEngine.Vector3 m_Size;
                /*0x70*/ float m_FadeFactor;
                /*0x78*/ UnityEngine.Material m_OldMaterial;
                /*0x80*/ float m_OldDrawDistance;
                /*0x84*/ float m_OldFadeScale;
                /*0x88*/ float m_OldStartAngleFade;
                /*0x8c*/ float m_OldEndAngleFade;
                /*0x90*/ UnityEngine.Vector2 m_OldUVScale;
                /*0x98*/ UnityEngine.Vector2 m_OldUVBias;
                /*0xa0*/ UnityEngine.Rendering.Universal.DecalScaleMode m_OldScaleMode;
                /*0xa4*/ UnityEngine.Vector3 m_OldOffset;
                /*0xb0*/ UnityEngine.Vector3 m_OldSize;
                /*0xbc*/ float m_OldFadeFactor;

                static /*0x3be7e54*/ void add_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be7f0c*/ void remove_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be7fc4*/ void add_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be8080*/ void remove_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be813c*/ void add_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be81f8*/ void remove_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be82b4*/ void add_onAllDecalPropertyChange(System.Action value);
                static /*0x3be8370*/ void remove_onAllDecalPropertyChange(System.Action value);
                static /*0x3be842c*/ void add_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be84e8*/ void remove_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x3be85a4*/ UnityEngine.Material get_defaultMaterial();
                static /*0x3be85ec*/ void set_defaultMaterial(UnityEngine.Material value);
                static /*0x3be863c*/ bool get_isSupported();
                static /*0x3be8dec*/ void UpdateAllDecalProperties();
                /*0x3be8e50*/ DecalProjector();
                /*0x3be868c*/ UnityEngine.Rendering.Universal.DecalEntity get_decalEntity();
                /*0x3be8694*/ void set_decalEntity(UnityEngine.Rendering.Universal.DecalEntity value);
                /*0x3be869c*/ UnityEngine.Material get_material();
                /*0x3be86a4*/ void set_material(UnityEngine.Material value);
                /*0x3be87e8*/ float get_drawDistance();
                /*0x3be87f0*/ void set_drawDistance(float value);
                /*0x3be8804*/ float get_fadeScale();
                /*0x3be880c*/ void set_fadeScale(float value);
                /*0x3be882c*/ float get_startAngleFade();
                /*0x3be8834*/ void set_startAngleFade(float value);
                /*0x3be8858*/ float get_endAngleFade();
                /*0x3be8860*/ void set_endAngleFade(float value);
                /*0x3be8884*/ UnityEngine.Vector2 get_uvScale();
                /*0x3be888c*/ void set_uvScale(UnityEngine.Vector2 value);
                /*0x3be8894*/ UnityEngine.Vector2 get_uvBias();
                /*0x3be889c*/ void set_uvBias(UnityEngine.Vector2 value);
                /*0x3be88a4*/ uint get_renderingLayerMask();
                /*0x3be88ac*/ void set_renderingLayerMask(uint value);
                /*0x3be88b4*/ UnityEngine.Rendering.Universal.DecalScaleMode get_scaleMode();
                /*0x3be88bc*/ void set_scaleMode(UnityEngine.Rendering.Universal.DecalScaleMode value);
                /*0x3be88c4*/ UnityEngine.Vector3 get_pivot();
                /*0x3be88d0*/ void set_pivot(UnityEngine.Vector3 value);
                /*0x3be88dc*/ UnityEngine.Vector3 get_size();
                /*0x3be88e8*/ void set_size(UnityEngine.Vector3 value);
                /*0x3be88f4*/ float get_fadeFactor();
                /*0x3be88fc*/ void set_fadeFactor(float value);
                /*0x3be891c*/ UnityEngine.Vector3 get_effectiveScale();
                /*0x3be8988*/ UnityEngine.Vector3 get_decalSize();
                /*0x3be8994*/ UnityEngine.Vector3 get_decalOffset();
                /*0x3be89a4*/ UnityEngine.Vector4 get_uvScaleBias();
                /*0x3be89b0*/ void InitMaterial();
                /*0x3be8a10*/ void OnEnable();
                /*0x3be8a94*/ void OnDisable();
                /*0x3be86c0*/ void OnValidate();
                /*0x3be8b00*/ void OnDidApplyAnimationProperties();
                /*0x3be8cb0*/ bool IsValid();

                class DecalProjectorAction : System.MulticastDelegate
                {
                    /*0x3be8ea0*/ DecalProjectorAction(object object, nint method);
                    /*0x3be8fa8*/ void Invoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                    /*0x3be8fbc*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector, System.AsyncCallback callback, object object);
                    /*0x3be8fdc*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DecalShaderPassNames
            {
                static string DecalPreview = "DecalPreview";
                static string DBufferProjector = "DBufferProjector";
                static string DecalProjectorForwardEmissive = "DecalProjectorForwardEmissive";
                static string DecalScreenSpaceProjector = "DecalScreenSpaceProjector";
                static string DecalGBufferProjector = "DecalGBufferProjector";
                static string DBufferMesh = "DBufferMesh";
                static string DecalMeshForwardEmissive = "DecalMeshForwardEmissive";
                static string DecalScreenSpaceMesh = "DecalScreenSpaceMesh";
                static string DecalGBufferMesh = "DecalGBufferMesh";
                static string DBufferProjectorVFX = "DBufferProjectorVFX";
                static string DecalProjectorForwardEmissiveVFX = "DecalProjectorForwardEmissiveVFX";
                static string DecalScreenSpaceProjectorVFX = "DecalScreenSpaceProjectorVFX";
                static string DecalGBufferProjectorVFX = "DecalGBufferProjectorVFX";
            }

            class DecalChunk : System.IDisposable
            {
                /*0x10*/ int <count>k__BackingField;
                /*0x14*/ int <capacity>k__BackingField;
                /*0x18*/ Unity.Jobs.JobHandle <currentJobHandle>k__BackingField;

                /*0x3be90fc*/ DecalChunk();
                /*0x3be8fe8*/ int get_count();
                /*0x3be8ff0*/ void set_count(int value);
                /*0x3be8ff8*/ int get_capacity();
                /*0x3be9000*/ void set_capacity(int value);
                /*0x3be9008*/ Unity.Jobs.JobHandle get_currentJobHandle();
                /*0x3be9014*/ void set_currentJobHandle(Unity.Jobs.JobHandle value);
                /*0x3be901c*/ void Push();
                /*0x1f30b78*/ void RemoveAtSwapBack(int index);
                /*0x1f30b78*/ void SetCapacity(int capacity);
                /*0x3be902c*/ void Dispose();
                /*0x3be9030*/ void ResizeNativeArray(ref UnityEngine.Jobs.TransformAccessArray array, UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors, int capacity);
                void RemoveAtSwapBack<T>(ref Unity.Collections.NativeArray<T> array, int index, int count);
                void RemoveAtSwapBack<T>(ref T[] array, int index, int count);
            }

            struct DecalSubDrawCall
            {
                /*0x10*/ int start;
                /*0x14*/ int end;

                /*0x3be9104*/ int get_count();
            }

            class DecalDrawCallChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecals;
                /*0x48*/ Unity.Collections.NativeArray<float> renderingLayerMasks;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                /*0x68*/ Unity.Collections.NativeArray<int> subCallCounts;

                /*0x3be939c*/ DecalDrawCallChunk();
                /*0x3be9110*/ void set_subCallCount(int value);
                /*0x3be911c*/ int get_subCallCount();
                /*0x3be9128*/ void RemoveAtSwapBack(int entityIndex);
                /*0x3be9210*/ void SetCapacity(int newCapacity);
                /*0x3be92d0*/ void Dispose();
            }

            class DecalCreateDrawCallSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ float m_MaxDrawDistance;

                /*0x3be93b4*/ DecalCreateDrawCallSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float maxDrawDistance);
                /*0x3be93a4*/ float get_maxDrawDistance();
                /*0x3be93ac*/ void set_maxDrawDistance(float value);
                /*0x3be9468*/ void Execute();
                /*0x3be9688*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk, int count);

                struct DrawCallJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                    /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBiases;
                    /*0x70*/ Unity.Collections.NativeArray<int> layerMasks;
                    /*0x80*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                    /*0x90*/ Unity.Collections.NativeArray<float> fadeFactors;
                    /*0xa0*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xb0*/ Unity.Collections.NativeArray<uint> renderingLayerMasks;
                    /*0xc0*/ UnityEngine.Vector3 cameraPosition;
                    /*0xd0*/ ulong sceneCullingMask;
                    /*0xd8*/ int cullingMask;
                    /*0xe0*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                    /*0xf0*/ int visibleDecalCount;
                    /*0xf4*/ float maxDrawDistance;
                    /*0xf8*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorldsDraw;
                    /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecalsDraw;
                    /*0x118*/ Unity.Collections.NativeArray<float> renderingLayerMasksDraw;
                    /*0x128*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                    /*0x138*/ Unity.Collections.NativeArray<int> subCallCount;

                    /*0x3be9874*/ void Execute();
                }
            }

            class DecalDrawSystem
            {
                static /*0x0*/ uint MaxBatchSize;
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToDecals;
                /*0x20*/ UnityEngine.Matrix4x4[] m_NormalToDecals;
                /*0x28*/ float[] m_DecalLayerMasks;
                /*0x30*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x38*/ UnityEngine.Material <overrideMaterial>k__BackingField;

                static /*0x3beab44*/ DecalDrawSystem();
                /*0x3be5730*/ DecalDrawSystem(string sampler, UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3be9b70*/ UnityEngine.Material get_overrideMaterial();
                /*0x3be9b78*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x3be9b80*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3be6408*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x3be9da4*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
                /*0x1f3008c*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x3be9c3c*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x3bea000*/ void Draw(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x3be9db8*/ void DrawInstanced(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x3bea2ec*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3bea514*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x3bea8f8*/ void Draw(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
                /*0x3bea668*/ void DrawInstanced(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
            }

            class DecalEntityIndexer
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem> m_Entities;
                /*0x18*/ System.Collections.Generic.Queue<int> m_FreeIndices;

                /*0x3beb158*/ DecalEntityIndexer();
                /*0x3beab90*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x3beac28*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex);
                /*0x3bead7c*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x3beae50*/ UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem GetItem(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x3beaec0*/ void UpdateIndex(UnityEngine.Rendering.Universal.DecalEntity decalEntity, int newArrayIndex);
                /*0x3beaf74*/ void RemapChunkIndices(System.Collections.Generic.List<int> remaper);
                /*0x3beb0a0*/ void Clear();

                struct DecalEntityItem
                {
                    /*0x10*/ int chunkIndex;
                    /*0x14*/ int arrayIndex;
                    /*0x18*/ int version;
                }
            }

            struct DecalEntity
            {
                /*0x10*/ int index;
                /*0x14*/ int version;
            }

            class DecalEntityChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalEntity> decalEntities;
                /*0x40*/ UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors;
                /*0x48*/ UnityEngine.Jobs.TransformAccessArray transformAccessArray;

                /*0x3beb3f8*/ DecalEntityChunk();
                /*0x3beb234*/ void Push();
                /*0x3beb244*/ void RemoveAtSwapBack(int entityIndex);
                /*0x3beb2f0*/ void SetCapacity(int newCapacity);
                /*0x3beb384*/ void Dispose();
            }

            class DecalEntityManager : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityChunk> entityChunks;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCachedChunk> cachedChunks;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCulledChunk> culledChunks;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalDrawCallChunk> drawCallChunks;
                /*0x30*/ int chunkCount;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_AddDecalSampler;
                /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ResizeChunks;
                /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_SortChunks;
                /*0x50*/ UnityEngine.Rendering.Universal.DecalEntityIndexer m_DecalEntityIndexer;
                /*0x58*/ System.Collections.Generic.Dictionary<UnityEngine.Material, int> m_MaterialToChunkIndex;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> m_CombinedChunks;
                /*0x68*/ System.Collections.Generic.List<int> m_CombinedChunkRemmap;
                /*0x70*/ UnityEngine.Material m_ErrorMaterial;
                /*0x78*/ UnityEngine.Mesh m_DecalProjectorMesh;

                /*0x3beb400*/ DecalEntityManager();
                /*0x3be6ee4*/ UnityEngine.Material get_errorMaterial();
                /*0x3bea22c*/ UnityEngine.Mesh get_decalProjectorMesh();
                /*0x3beb764*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x3beb778*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x3bebd00*/ int CreateChunkIndex(UnityEngine.Material material);
                /*0x3bec418*/ void UpdateAllDecalEntitiesData();
                /*0x3bec0c4*/ void UpdateDecalEntityData(UnityEngine.Rendering.Universal.DecalEntity decalEntity, UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x3bec6a4*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x3bec870*/ void Update();
                /*0x3bed260*/ void Dispose();

                struct CombinedChunks
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk;
                    /*0x20*/ UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk;
                    /*0x28*/ UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk;
                    /*0x30*/ int previousChunkIndex;
                    /*0x34*/ bool valid;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalEntityManager.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> <>9__26_0;

                    static /*0x3bedff8*/ <>c();
                    /*0x3bee060*/ <>c();
                    /*0x3bee068*/ int <Update>b__26_0(UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks a, UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks b);
                }
            }

            class DecalSkipCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Camera m_Camera;

                static /*0x3bee3f4*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x3bee120*/ DecalSkipCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3bee1c0*/ void Execute(UnityEngine.Camera camera);
                /*0x3bee348*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCachedChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.MaterialPropertyBlock propertyBlock;
                /*0x30*/ int passIndexDBuffer;
                /*0x34*/ int passIndexEmissive;
                /*0x38*/ int passIndexScreenSpace;
                /*0x3c*/ int passIndexGBuffer;
                /*0x40*/ int drawOrder;
                /*0x44*/ bool isCreated;
                /*0x48*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x58*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                /*0x68*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                /*0x78*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                /*0x88*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                /*0x98*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBias;
                /*0xa8*/ Unity.Collections.NativeArray<int> layerMasks;
                /*0xb8*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                /*0xc8*/ Unity.Collections.NativeArray<float> fadeFactors;
                /*0xd8*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                /*0xf8*/ Unity.Collections.NativeArray<uint> renderingLayerMasks;
                /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                /*0x118*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotation;
                /*0x128*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                /*0x138*/ Unity.Collections.NativeArray<bool> dirty;
                /*0x148*/ UnityEngine.BoundingSphere[] boundingSphereArray;

                /*0x3bec408*/ DecalCachedChunk();
                /*0x3bee3fc*/ void RemoveAtSwapBack(int entityIndex);
                /*0x3bee6f4*/ void SetCapacity(int newCapacity);
                /*0x3bee95c*/ void Dispose();
            }

            class DecalUpdateCachedSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler m_SamplerJob;

                /*0x3beeb64*/ DecalUpdateCachedSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3beec48*/ void Execute();
                /*0x3beee10*/ void Execute(UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, int count);

                struct UpdateTransformsJob : UnityEngine.Jobs.IJobParallelForTransform
                {
                    static /*0x0*/ Unity.Mathematics.quaternion k_MinusYtoZRotation;
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                    /*0x40*/ Unity.Collections.NativeArray<bool> dirty;
                    /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x70*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x80*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x90*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xa0*/ float minDistance;

                    static /*0x3bef858*/ UpdateTransformsJob();
                    /*0x3bef09c*/ float DistanceBetweenQuaternions(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
                    /*0x3bef0cc*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
                    /*0x3bef680*/ UnityEngine.BoundingSphere GetDecalProjectBoundingSphere(UnityEngine.Matrix4x4 decalToWorld);
                }
            }

            class DecalUpdateCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                /*0x3bef9c0*/ DecalUpdateCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3befa60*/ void Execute();
                /*0x3befbcc*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCulledChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Vector3 cameraPosition;
                /*0x38*/ ulong sceneCullingMask;
                /*0x40*/ int cullingMask;
                /*0x48*/ UnityEngine.CullingGroup cullingGroups;
                /*0x50*/ int[] visibleDecalIndexArray;
                /*0x58*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                /*0x68*/ int visibleDecalCount;

                /*0x3bec410*/ DecalCulledChunk();
                /*0x3befc6c*/ void RemoveAtSwapBack(int entityIndex);
                /*0x3befd08*/ void SetCapacity(int newCapacity);
                /*0x3befdd0*/ void Dispose();
            }

            class DecalUpdateCullingGroupSystem
            {
                /*0x10*/ float[] m_BoundingDistance;
                /*0x18*/ UnityEngine.Camera m_Camera;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                static /*0x3bf02d0*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x3befeb4*/ DecalUpdateCullingGroupSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float drawDistance);
                /*0x3befe64*/ float get_boundingDistance();
                /*0x3befe8c*/ void set_boundingDistance(float value);
                /*0x3beffb0*/ void Execute(UnityEngine.Camera camera);
                /*0x3bf0190*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalDrawGBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x3bf02d8*/ DecalDrawGBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3bf0354*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalGBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0xf0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0xf8*/ UnityEngine.Rendering.RTHandle[] m_GbufferAttachments;
                /*0x100*/ bool m_DecalLayers;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData m_PassData;

                static /*0x3bf1224*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x3bf0368*/ DecalGBufferRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem, bool decalLayers);
                /*0x3bf0650*/ void Setup(UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                /*0x3bf0658*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x3bf0e34*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bf11bc*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData);
                /*0x3bf138c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3bf22dc*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x28*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3bf0648*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__15_0;

                    static /*0x3bf23d4*/ <>c();
                    /*0x3bf243c*/ <>c();
                    /*0x3bf2444*/ void <RecordRenderGraph>b__15_0(UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawScreenSpaceSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x3bf24a4*/ DecalDrawScreenSpaceSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x3bf2520*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalScreenSpaceRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0xf0*/ bool m_DecalLayers;
                /*0xf8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData m_PassData;

                static /*0x3bf2d8c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x3bf2534*/ DecalScreenSpaceRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem, bool decalLayers);
                /*0x3bf27e0*/ UnityEngine.Rendering.RendererListParams CreateRenderListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3bf2908*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bf2ccc*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData);
                /*0x3bf2efc*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3bf37a0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x21*/ bool isGLDevice;
                    /*0x24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3bf27d8*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__12_0;

                    static /*0x3bf3898*/ <>c();
                    /*0x3bf3900*/ <>c();
                    /*0x3bf3908*/ void <RecordRenderGraph>b__12_0(UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class ScriptableRenderPass : UnityEngine.Rendering.RenderGraphModule.IRenderGraphRecorder
            {
                static /*0x0*/ UnityEngine.Rendering.RTHandle k_CameraTarget;
                /*0x10*/ UnityEngine.Rendering.Universal.RenderPassEvent <renderPassEvent>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions;
                /*0x20*/ UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction;
                /*0x24*/ bool <requiresIntermediateTexture>k__BackingField;
                /*0x28*/ bool[] m_OverriddenColorStoreActions;
                /*0x30*/ bool m_OverriddenDepthStoreAction;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_ProfingSampler;
                /*0x40*/ string m_PassName;
                /*0x48*/ UnityEngine.Rendering.Universal.RenderGraphSettings m_RenderGraphSettings;
                /*0x50*/ bool <overrideCameraTarget>k__BackingField;
                /*0x51*/ bool <isBlitRenderPass>k__BackingField;
                /*0x52*/ bool <useNativeRenderPass>k__BackingField;
                /*0x53*/ bool <breakGBufferAndDeferredRenderPass>k__BackingField;
                /*0x54*/ int <renderPassQueueIndex>k__BackingField;
                /*0x58*/ Unity.Collections.NativeArray<int> m_ColorAttachmentIndices;
                /*0x68*/ Unity.Collections.NativeArray<int> m_InputAttachmentIndices;
                /*0x78*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <renderTargetFormat>k__BackingField;
                /*0x80*/ UnityEngine.Rendering.RTHandle[] m_ColorAttachments;
                /*0x88*/ UnityEngine.Rendering.RTHandle[] m_InputAttachments;
                /*0x90*/ bool[] m_InputAttachmentIsTransient;
                /*0x98*/ UnityEngine.Rendering.RTHandle m_DepthAttachment;
                /*0xa0*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput m_Input;
                /*0xa4*/ UnityEngine.Rendering.ClearFlag m_ClearFlag;
                /*0xa8*/ UnityEngine.Color m_ClearColor;

                static /*0x3bf4cf0*/ ScriptableRenderPass();
                static /*0x3bf3bec*/ UnityEngine.Rendering.Universal.DebugHandler GetActiveDebugHandler(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3bf4b38*/ bool op_LessThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x3bf4b60*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x3bf4b88*/ int GetRenderPassEventRange(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent);
                /*0x3be5b3c*/ ScriptableRenderPass();
                /*0x3bf3a00*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bf3a0c*/ UnityEngine.Rendering.Universal.RenderPassEvent get_renderPassEvent();
                /*0x3bf3a14*/ void set_renderPassEvent(UnityEngine.Rendering.Universal.RenderPassEvent value);
                /*0x3bf3a1c*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachments();
                /*0x3bf3a68*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachment();
                /*0x3bf3ab4*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthAttachment();
                /*0x3bf3b00*/ UnityEngine.Rendering.RTHandle[] get_colorAttachmentHandles();
                /*0x3bf3b08*/ UnityEngine.Rendering.RTHandle get_colorAttachmentHandle();
                /*0x3bf3b30*/ UnityEngine.Rendering.RTHandle get_depthAttachmentHandle();
                /*0x3bf3b38*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
                /*0x3bf3b40*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
                /*0x3bf3b48*/ bool[] get_overriddenColorStoreActions();
                /*0x3bf3b50*/ bool get_overriddenDepthStoreAction();
                /*0x3bf3b58*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput get_input();
                /*0x3bf3b60*/ UnityEngine.Rendering.ClearFlag get_clearFlag();
                /*0x3bf3b68*/ UnityEngine.Color get_clearColor();
                /*0x3bf3b74*/ bool get_requiresIntermediateTexture();
                /*0x3bf3b7c*/ void set_requiresIntermediateTexture(bool value);
                /*0x3be62fc*/ UnityEngine.Rendering.ProfilingSampler get_profilingSampler();
                /*0x3be5e3c*/ void set_profilingSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x3bf3b84*/ string get_passName();
                /*0x3bf3b8c*/ bool get_overrideCameraTarget();
                /*0x3bf3b94*/ void set_overrideCameraTarget(bool value);
                /*0x3bf3b9c*/ bool get_isBlitRenderPass();
                /*0x3bf3ba4*/ void set_isBlitRenderPass(bool value);
                /*0x3bf3bac*/ bool get_useNativeRenderPass();
                /*0x3bf3bb4*/ void set_useNativeRenderPass(bool value);
                /*0x3bf3bbc*/ bool get_breakGBufferAndDeferredRenderPass();
                /*0x3bf3bc4*/ void set_breakGBufferAndDeferredRenderPass(bool value);
                /*0x3bf3bcc*/ int get_renderPassQueueIndex();
                /*0x3bf3bd4*/ void set_renderPassQueueIndex(int value);
                /*0x3bf3bdc*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_renderTargetFormat();
                /*0x3bf3be4*/ void set_renderTargetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                /*0x3bf3c34*/ void ConfigureInput(UnityEngine.Rendering.Universal.ScriptableRenderPassInput passInput);
                /*0x3bf3c3c*/ void ConfigureColorStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction, uint attachmentIndex);
                /*0x3bf3c90*/ void ConfigureColorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] storeActions);
                /*0x3bf3d74*/ void ConfigureDepthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                /*0x3bf3d84*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle input, bool isTransient);
                /*0x3bf3e10*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs);
                /*0x3bf0b3c*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs, bool[] isTransient);
                /*0x3bf3e18*/ void SetInputAttachmentTransient(int idx, bool isTransient);
                /*0x3bf3e4c*/ bool IsInputAttachmentTransient(int idx);
                /*0x3bf3e7c*/ void ResetTarget();
                /*0x3bf3f14*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x3bf3f60*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x3bf4028*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x3bf0b6c*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x3bf4074*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat[] formats);
                /*0x3bf40f0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment);
                /*0x3bf413c*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment);
                /*0x3bf41ac*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments);
                /*0x3bf41f8*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments);
                /*0x3bf4268*/ void ConfigureClear(UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                /*0x3bf4278*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bf427c*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x3bf4280*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bf4284*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bf4288*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bf4340*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3bf43f8*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                /*0x3bf4444*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int passIndex);
                /*0x3bf4564*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Material material, int passIndex);
                /*0x3bf4674*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Material material, int passIndex);
                /*0x3bf46d0*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x3bf4828*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x3bf4904*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x3bf4a5c*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
            }

            enum ShadowCascadesOption
            {
                NoCascades = 0,
                TwoCascades = 1,
                FourCascades = 2,
            }

            enum ShaderVariantLogLevel
            {
                Disabled = 0,
                OnlyUniversalRPShaders = 1,
                AllShaders = 2,
            }

            class ScriptableRenderer : System.IDisposable
            {
                static int kRenderPassMapSize = 10;
                static int kRenderPassMaxCount = 20;
                static int k_RenderPassBlockCount = 4;
                static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer current;
                static /*0x8*/ bool m_UseOptimizedStoreActions;
                static /*0x10*/ UnityEngine.Rendering.RTHandle k_CameraTarget;
                static /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ActiveColorAttachmentIDs;
                static /*0x20*/ UnityEngine.Rendering.RTHandle[] m_ActiveColorAttachments;
                static /*0x28*/ UnityEngine.Rendering.RTHandle m_ActiveDepthAttachment;
                static /*0x30*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ActiveColorStoreActions;
                static /*0x38*/ UnityEngine.Rendering.RenderBufferStoreAction m_ActiveDepthStoreAction;
                static /*0x40*/ UnityEngine.Rendering.RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopyIDs;
                static /*0x48*/ UnityEngine.Rendering.RTHandle[][] m_TrimmedColorAttachmentCopies;
                static /*0x50*/ UnityEngine.Plane[] s_Planes;
                static /*0x58*/ UnityEngine.Vector4[] s_VectorPlanes;
                /*0x10*/ int m_LastBeginSubpassPassIndex;
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, System.Int32[]> m_MergeableRenderPassesMap;
                /*0x20*/ int[][] m_MergeableRenderPassesMapArrays;
                /*0x28*/ UnityEngine.Hash128[] m_PassIndexToPassHash;
                /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, int> m_RenderPassesAttachmentCount;
                /*0x38*/ int m_firstPassIndexOfLastMergeableGroup;
                /*0x40*/ UnityEngine.Rendering.AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;
                /*0x48*/ UnityEngine.Rendering.AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;
                /*0xc0*/ bool[] m_IsActiveColorAttachmentTransient;
                /*0xc8*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_FinalColorStoreAction;
                /*0xd0*/ UnityEngine.Rendering.RenderBufferStoreAction m_FinalDepthStoreAction;
                /*0xd8*/ UnityEngine.Rendering.ProfilingSampler <profilingExecute>k__BackingField;
                /*0xe0*/ bool hasReleasedRTs;
                /*0xe8*/ UnityEngine.Rendering.Universal.DebugHandler <DebugHandler>k__BackingField;
                /*0xf0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures <supportedRenderingFeatures>k__BackingField;
                /*0xf8*/ UnityEngine.Rendering.GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField;
                /*0x100*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimizationSetting;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> m_ActiveRenderPassQueue;
                /*0x110*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x118*/ UnityEngine.Rendering.RTHandle m_CameraColorTarget;
                /*0x120*/ UnityEngine.Rendering.RTHandle m_CameraDepthTarget;
                /*0x128*/ UnityEngine.Rendering.RTHandle m_CameraResolveTarget;
                /*0x130*/ bool m_FirstTimeCameraColorTargetIsBound;
                /*0x131*/ bool m_FirstTimeCameraDepthTargetIsBound;
                /*0x132*/ bool m_IsPipelineExecuting;
                /*0x133*/ bool disableNativeRenderPassInFeatures;
                /*0x134*/ bool useRenderPassEnabled;
                /*0x138*/ UnityEngine.Rendering.ContextContainer m_frameData;
                /*0x140*/ bool <useDepthPriming>k__BackingField;
                /*0x141*/ bool <stripShadowsOffVariants>k__BackingField;
                /*0x142*/ bool <stripAdditionalLightOffVariants>k__BackingField;

                static /*0x3c01a18*/ ScriptableRenderer();
                static /*0x3bf835c*/ uint GetSubPassAttachmentIndicesCount(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x3bf8504*/ bool AreAttachmentIndicesCompatible(UnityEngine.Rendering.Universal.ScriptableRenderPass lastSubPass, UnityEngine.Rendering.Universal.ScriptableRenderPass currentSubPass);
                static /*0x3bf863c*/ uint GetValidColorAttachmentCount(UnityEngine.Rendering.AttachmentDescriptor[] colorAttachments);
                static /*0x3bf85f4*/ int GetValidInputAttachmentCount(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x3bf76f4*/ int FindAttachmentDescriptorIndexInList(int attachmentIdx, UnityEngine.Rendering.AttachmentDescriptor attachmentDescriptor, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x3bf66f4*/ int FindAttachmentDescriptorIndexInList(UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x3bf58cc*/ int GetValidPassIndexCount(int[] array);
                static /*0x3bf5c14*/ UnityEngine.Rendering.RTHandle GetFirstAllocatedRTHandle(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x3bf67d8*/ bool PassHasInputAttachments(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x3bf8784*/ UnityEngine.Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex);
                static /*0x3bf583c*/ UnityEngine.Hash128 CreateRenderPassHash(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex);
                static /*0x3bf87b0*/ void GetRenderTextureDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.RenderTextureDescriptor targetRT);
                static /*0x3bf8a78*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices);
                static /*0x3bf8f78*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices);
                static /*0x3bf8b8c*/ void SetCameraMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped);
                static /*0x3bf9940*/ void CalculateBillboardProperties(ref UnityEngine.Matrix4x4 worldToCameraMatrix, ref UnityEngine.Vector3 billboardTangent, ref UnityEngine.Vector3 billboardNormal, ref float cameraXZAngle);
                static /*0x3bf9ee8*/ void SetShaderTimeValues(UnityEngine.Rendering.IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime);
                static /*0x3bff2b4*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x3bff31c*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3bfe654*/ void ClearRenderingState(UnityEngine.Rendering.IBaseCommandBuffer cmd);
                static /*0x3c00d7c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x3c012e0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x3c0165c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x3c011c0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachmentIDs, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x3bfc5c8*/ void SortStable(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> list);
                /*0x3bfa478*/ ScriptableRenderer(UnityEngine.Rendering.Universal.ScriptableRendererData data);
                /*0x3bf4da4*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepth();
                /*0x3bf4dcc*/ void ResetNativeRenderPassFrameData();
                /*0x3bf4f14*/ void SetupNativeRenderPassFrameData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isRenderPassEnabled);
                /*0x3bf590c*/ void UpdateFinalStoreActions(int[] currentMergeablePasses, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isLastMergeableGroup);
                /*0x3bf5cf0*/ void SetNativeRenderPassMRTAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool needCustomCameraColorClear, UnityEngine.Rendering.ClearFlag cameraClearFlag);
                /*0x3bf6af8*/ bool IsDepthOnlyRenderTexture(UnityEngine.RenderTexture t);
                /*0x3bf6b20*/ void SetNativeRenderPassAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle passColorAttachment, UnityEngine.Rendering.RTHandle passDepthAttachment, UnityEngine.Rendering.ClearFlag finalClearFlag, UnityEngine.Color finalClearColor);
                /*0x3bf7814*/ void ExecuteNativeRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bf6814*/ void SetupInputAttachmentIndices(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x3bf69f4*/ void SetupTransientInputAttachments(int attachmentCount);
                /*0x3bf5734*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x3bf8a18*/ int SupportedCameraStackingTypes();
                /*0x3bf8a20*/ bool SupportsCameraStackingType(UnityEngine.Rendering.Universal.CameraRenderType cameraRenderType);
                /*0x3bf8a48*/ bool SupportsMotionVectors();
                /*0x3bf8a50*/ bool SupportsCameraOpaque();
                /*0x3bf8a58*/ bool SupportsCameraNormals();
                /*0x3bf8a60*/ UnityEngine.Rendering.ProfilingSampler get_profilingExecute();
                /*0x3bf8a68*/ void set_profilingExecute(UnityEngine.Rendering.ProfilingSampler value);
                /*0x3bf8a70*/ UnityEngine.Rendering.Universal.DebugHandler get_DebugHandler();
                /*0x3bf9080*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3bf90d8*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, bool isTargetFlipped);
                /*0x3bf97b0*/ void SetPerCameraBillboardProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3bf9cec*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3bf9d2c*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isTargetFlipped);
                /*0x3bfa368*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraColorTarget();
                /*0x3bf45f0*/ UnityEngine.Rendering.RTHandle get_cameraColorTargetHandle();
                /*0x3bfa3b4*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfa3bc*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfa3c4*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTarget();
                /*0x3bf8994*/ UnityEngine.Rendering.RTHandle get_cameraDepthTargetHandle();
                /*0x3bfa410*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x3bfa418*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> get_activeRenderPassQueue();
                /*0x3bfa420*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures();
                /*0x3bfa428*/ void set_supportedRenderingFeatures(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures value);
                /*0x3bfa430*/ UnityEngine.Rendering.GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes();
                /*0x3bfa438*/ void set_unsupportedGraphicsDeviceTypes(UnityEngine.Rendering.GraphicsDeviceType[] value);
                /*0x3bfa440*/ UnityEngine.Rendering.ContextContainer get_frameData();
                /*0x3bfa448*/ bool get_useDepthPriming();
                /*0x3bfa450*/ void set_useDepthPriming(bool value);
                /*0x3bfa458*/ bool get_stripShadowsOffVariants();
                /*0x3bfa460*/ void set_stripShadowsOffVariants(bool value);
                /*0x3bfa468*/ bool get_stripAdditionalLightOffVariants();
                /*0x3bfa470*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x3bfb06c*/ void Dispose();
                /*0x3bfb1b0*/ void Dispose(bool disposing);
                /*0x3bfb1c4*/ void ReleaseRenderTargets();
                /*0x3bfb1c8*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget);
                /*0x3bfb214*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget);
                /*0x3bfb248*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget, UnityEngine.Rendering.RTHandle resolveTarget);
                /*0x3bfb290*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RTHandle colorTarget);
                void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bfb2a0*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bfb2a4*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3bfb2a8*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfb2ac*/ void OnBeginRenderGraphFrame();
                /*0x3bfb2b0*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x3bfb2b4*/ void OnEndRenderGraphFrame();
                /*0x3bfb2b8*/ void InitRenderGraphFrame(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3bfb63c*/ void ProcessVFXCameraCommand(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3bfbafc*/ void SetupRenderGraphCameraProperties(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isTargetBackbuffer);
                /*0x3bfbf6c*/ void DrawRenderGraphGizmos(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x3bfbf70*/ void DrawRenderGraphWireOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color);
                /*0x3bfbf74*/ void BeginRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3bfbf78*/ void EndRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3bfbf7c*/ void SetEditorTarget(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3bfc2ec*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x3bfc730*/ void FinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfca18*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfca1c*/ void RecordCustomRenderGraphPassesInEventRange(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent eventStart, UnityEngine.Rendering.Universal.RenderPassEvent eventEnd);
                /*0x3bfcc10*/ void CalculateSplitEventRange(UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent targetEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent startEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent splitEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent endEvent);
                /*0x3bfcd38*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x3bfcdc0*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint);
                /*0x3bfcdc8*/ bool InterruptFramebufferFetch(UnityEngine.Rendering.Universal.FramebufferFetchEvent fetchEvent, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x3bfcfec*/ void SetPerCameraProperties(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3bfd248*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bff248*/ void EnqueuePass(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x3bff4a4*/ void OnPreCullRenderPasses(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3bff578*/ void AddRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bfe2c8*/ void SetupRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bfae08*/ void Clear(UnityEngine.Rendering.Universal.CameraRenderType cameraType);
                /*0x3bfefc4*/ void ExecuteBlock(int blockIndex, ref UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks renderBlocks, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool submit);
                /*0x3bf5708*/ bool IsRenderPassEnabled(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x3bff860*/ void ExecuteRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c00d74*/ bool IsSceneFilteringEnabled(UnityEngine.Camera camera);
                /*0x3bffd44*/ void SetRenderPassAttachments(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3bff198*/ void BeginXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3bff19c*/ void EndXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3c017f4*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c017f8*/ void EnableSwapBufferMSAA(bool enable);
                /*0x3c017fc*/ void DrawGizmos(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c01800*/ void DrawWireOverlay(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x3bfe46c*/ void InternalStartRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3bfc7b4*/ void InternalFinishRenderingCommon(UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x3bff1a0*/ void InternalFinishRenderingExecute(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x3c0186c*/ int AdjustAndGetScreenMSAASamples(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useIntermediateColorTarget);
                /*0x3c01a08*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x3c01a10*/ bool get_supportsGPUOcclusion();

                class Profiling
                {
                    static string k_Name = "ScriptableRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setMRTAttachmentsList;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setAttachmentList;
                    static /*0x10*/ UnityEngine.Rendering.ProfilingSampler execute;
                    static /*0x18*/ UnityEngine.Rendering.ProfilingSampler setupFrameData;
                    static /*0x20*/ UnityEngine.Rendering.ProfilingSampler setPerCameraShaderVariables;
                    static /*0x28*/ UnityEngine.Rendering.ProfilingSampler sortRenderPasses;
                    static /*0x30*/ UnityEngine.Rendering.ProfilingSampler recordRenderGraph;
                    static /*0x38*/ UnityEngine.Rendering.ProfilingSampler setupLights;
                    static /*0x40*/ UnityEngine.Rendering.ProfilingSampler setupCamera;
                    static /*0x48*/ UnityEngine.Rendering.ProfilingSampler vfxProcessCamera;
                    static /*0x50*/ UnityEngine.Rendering.ProfilingSampler addRenderPasses;
                    static /*0x58*/ UnityEngine.Rendering.ProfilingSampler setupRenderPasses;
                    static /*0x60*/ UnityEngine.Rendering.ProfilingSampler clearRenderingState;
                    static /*0x68*/ UnityEngine.Rendering.ProfilingSampler internalStartRendering;
                    static /*0x70*/ UnityEngine.Rendering.ProfilingSampler internalFinishRenderingCommon;
                    static /*0x78*/ UnityEngine.Rendering.ProfilingSampler drawGizmos;
                    static /*0x80*/ UnityEngine.Rendering.ProfilingSampler drawWireOverlay;
                    static /*0x88*/ UnityEngine.Rendering.ProfilingSampler beginXRRendering;
                    static /*0x90*/ UnityEngine.Rendering.ProfilingSampler endXRRendering;
                    static /*0x98*/ UnityEngine.Rendering.ProfilingSampler initRenderGraphFrame;
                    static /*0xa0*/ UnityEngine.Rendering.ProfilingSampler setEditorTarget;

                    static /*0x3c0214c*/ Profiling();

                    class RenderBlock
                    {
                        static string k_Name = "RenderPassBlock";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beforeRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler mainRenderingOpaque;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler mainRenderingTransparent;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler afterRendering;

                        static /*0x3c02700*/ RenderBlock();
                    }

                    class RenderPass
                    {
                        static string k_Name = "ScriptableRenderPass";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler configure;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setRenderPassAttachments;

                        static /*0x3c02864*/ RenderPass();
                    }
                }

                struct RenderPassDescriptor
                {
                    /*0x10*/ int w;
                    /*0x14*/ int h;
                    /*0x18*/ int samples;
                    /*0x1c*/ int depthID;

                    /*0x3c02940*/ RenderPassDescriptor(int width, int height, int sampleCount, int rtID);
                }

                class RenderingFeatures
                {
                    /*0x10*/ bool <cameraStacking>k__BackingField;
                    /*0x11*/ bool <msaa>k__BackingField;

                    /*0x3c0296c*/ RenderingFeatures();
                    /*0x3c0294c*/ bool get_cameraStacking();
                    /*0x3c02954*/ void set_cameraStacking(bool value);
                    /*0x3c0295c*/ bool get_msaa();
                    /*0x3c02964*/ void set_msaa(bool value);
                }

                class RenderPassBlock
                {
                    static /*0x0*/ int BeforeRendering;
                    static /*0x4*/ int MainRenderingOpaque;
                    static /*0x8*/ int MainRenderingTransparent;
                    static /*0xc*/ int AfterRendering;

                    static /*0x3c0297c*/ RenderPassBlock();
                }

                class VFXProcessCameraPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                    /*0x18*/ UnityEngine.Camera camera;
                    /*0x20*/ UnityEngine.VFX.VFXCameraXRSettings cameraXRSettings;
                    /*0x30*/ UnityEngine.Experimental.Rendering.XRPass xrPass;

                    /*0x3c029cc*/ VFXProcessCameraPassData();
                }

                class DrawGizmosPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle gizmoRenderList;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;

                    /*0x3c029d4*/ DrawGizmosPassData();
                }

                class DrawWireOverlayPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle wireOverlayList;

                    /*0x3c029dc*/ DrawWireOverlayPassData();
                }

                class BeginXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x3c029e4*/ BeginXRPassData();
                }

                class EndXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x3c029ec*/ EndXRPassData();
                }

                class DummyData
                {
                    /*0x3c029f4*/ DummyData();
                }

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x20*/ bool isTargetBackbuffer;
                    /*0x24*/ UnityEngine.Vector2Int cameraTargetSizeCopy;

                    /*0x3c029fc*/ PassData();
                }

                struct RenderBlocks : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.RenderPassEvent> m_BlockEventLimits;
                    /*0x20*/ Unity.Collections.NativeArray<int> m_BlockRanges;
                    /*0x30*/ Unity.Collections.NativeArray<int> m_BlockRangeLengths;

                    /*0x3c02a04*/ RenderBlocks(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x3c02cc0*/ void Dispose();
                    /*0x3c02bb0*/ void FillBlockRanges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x3c02d14*/ int GetLength(int index);
                    /*0x3c02d20*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index);

                    struct BlockRange : System.IDisposable
                    {
                        /*0x10*/ int m_Current;
                        /*0x14*/ int m_End;

                        /*0x3c02d4c*/ BlockRange(int begin, int end);
                        /*0x3c02d68*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator();
                        /*0x3c02d70*/ bool MoveNext();
                        /*0x3c02d8c*/ int get_Current();
                        /*0x3c02d94*/ void Dispose();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__140_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__142_0;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__143_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.DummyData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__153_0;

                    static /*0x3c02d98*/ <>c();
                    /*0x3c02e00*/ <>c();
                    /*0x3c02e08*/ void <InitRenderGraphFrame>b__140_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    /*0x3c02eb8*/ void <ProcessVFXCameraCommand>b__142_0(UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c02fac*/ void <SetupRenderGraphCameraProperties>b__143_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c03118*/ void <SetEditorTarget>b__153_0(UnityEngine.Rendering.Universal.ScriptableRenderer.DummyData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                }
            }

            class ScriptableRendererData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.ScriptableRendererData.DebugShaderResources debugShaders;
                /*0x20*/ UnityEngine.Rendering.Universal.ScriptableRendererData.ProbeVolumeResources probeVolumeResources;
                /*0x28*/ bool <isInvalidated>k__BackingField;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x38*/ System.Collections.Generic.List<long> m_RendererFeatureMap;
                /*0x40*/ bool m_UseNativeRenderPass;
                /*0x41*/ bool m_StripShadowsOffVariants;
                /*0x42*/ bool m_StripAdditionalLightOffVariants;

                /*0x3c03204*/ ScriptableRendererData();
                /*0x3c03180*/ bool get_isInvalidated();
                /*0x3c03188*/ void set_isInvalidated(bool value);
                /*0x3c03190*/ bool get_stripShadowsOffVariants();
                /*0x3c03198*/ void set_stripShadowsOffVariants(bool value);
                /*0x3c031a0*/ bool get_stripAdditionalLightOffVariants();
                /*0x3c031a8*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x1f30214*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x3c031b0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x3c031b8*/ void SetDirty();
                /*0x3c031c4*/ UnityEngine.Rendering.Universal.ScriptableRenderer InternalCreateRenderer();
                /*0x3c031d4*/ void OnValidate();
                /*0x3c031e0*/ void OnEnable();
                /*0x3c031ec*/ bool get_useNativeRenderPass();
                /*0x3c031f4*/ void set_useNativeRenderPass(bool value);
                /*0x1f2fec8*/ bool TryGetRendererFeature<T>(ref T rendererFeature);

                class DebugShaderResources
                {
                    /*0x10*/ UnityEngine.Shader debugReplacementPS;
                    /*0x18*/ UnityEngine.Shader hdrDebugViewPS;

                    /*0x3c032e8*/ DebugShaderResources();
                }

                class ProbeVolumeResources
                {
                    /*0x10*/ UnityEngine.Shader probeVolumeDebugShader;
                    /*0x18*/ UnityEngine.Shader probeVolumeFragmentationDebugShader;
                    /*0x20*/ UnityEngine.Shader probeVolumeOffsetDebugShader;
                    /*0x28*/ UnityEngine.Shader probeVolumeSamplingDebugShader;
                    /*0x30*/ UnityEngine.Mesh probeSamplingDebugMesh;
                    /*0x38*/ UnityEngine.Texture2D probeSamplingDebugTexture;
                    /*0x40*/ UnityEngine.ComputeShader probeVolumeBlendStatesCS;

                    /*0x3c032f0*/ ProbeVolumeResources();
                }
            }

            class Bloom : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedIntParameter skipIterations;
                /*0x40*/ UnityEngine.Rendering.MinFloatParameter threshold;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter scatter;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter clamp;
                /*0x60*/ UnityEngine.Rendering.ColorParameter tint;
                /*0x68*/ UnityEngine.Rendering.BoolParameter highQualityFiltering;
                /*0x70*/ UnityEngine.Rendering.Universal.DownscaleParameter downscale;
                /*0x78*/ UnityEngine.Rendering.ClampedIntParameter maxIterations;
                /*0x80*/ UnityEngine.Rendering.TextureParameter dirtTexture;
                /*0x88*/ UnityEngine.Rendering.MinFloatParameter dirtIntensity;

                /*0x3c03330*/ Bloom();
                /*0x3c032f8*/ bool IsActive();
                /*0x3c03328*/ bool IsTileCompatible();
            }

            class XRSystemData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystemData.ShaderResources shaders;

                /*0x3c036a4*/ XRSystemData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader xrOcclusionMeshPS;
                    /*0x18*/ UnityEngine.Shader xrMirrorViewPS;

                    /*0x3c036ac*/ ShaderResources();
                }
            }

            class UniversalRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_LatestAssetVersion = 2;
                /*0x48*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x50*/ int m_AssetVersion;
                /*0x54*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x58*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x60*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x68*/ bool m_ShadowTransparentReceive;
                /*0x6c*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x70*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x74*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x78*/ UnityEngine.Rendering.Universal.DepthFormat m_DepthAttachmentFormat;
                /*0x7c*/ UnityEngine.Rendering.Universal.DepthFormat m_DepthTextureFormat;
                /*0x80*/ bool m_AccurateGbufferNormals;
                /*0x84*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;
                /*0x88*/ bool m_StripShadowsOffVariants;
                /*0x89*/ bool m_StripAdditionalLightOffVariants;

                /*0x3c03ad4*/ UniversalRendererData();
                /*0x3c036b4*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x3c03740*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x3c03748*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x3c03758*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x3c03760*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x3c03770*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x3c03778*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x3c03788*/ bool get_shadowTransparentReceive();
                /*0x3c03790*/ void set_shadowTransparentReceive(bool value);
                /*0x3c037a0*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x3c037a8*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x3c037b8*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x3c037c0*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x3c037d0*/ UnityEngine.Rendering.Universal.CopyDepthMode get_copyDepthMode();
                /*0x3c037d8*/ void set_copyDepthMode(UnityEngine.Rendering.Universal.CopyDepthMode value);
                /*0x3c037e8*/ UnityEngine.Rendering.Universal.DepthFormat get_depthAttachmentFormat();
                /*0x3c0387c*/ void set_depthAttachmentFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x3c03940*/ UnityEngine.Rendering.Universal.DepthFormat get_depthTextureFormat();
                /*0x3c03a40*/ void set_depthTextureFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x3c03a50*/ bool get_accurateGbufferNormals();
                /*0x3c03a58*/ void set_accurateGbufferNormals(bool value);
                /*0x3c03a68*/ UnityEngine.Rendering.Universal.IntermediateTextureMode get_intermediateTextureMode();
                /*0x3c03a70*/ void set_intermediateTextureMode(UnityEngine.Rendering.Universal.IntermediateTextureMode value);
                /*0x3c03a80*/ bool get_stripShadowsOffVariants();
                /*0x3c03a88*/ void set_stripShadowsOffVariants(bool value);
                /*0x3c03a90*/ bool get_stripAdditionalLightOffVariants();
                /*0x3c03a98*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x3c03aa0*/ void OnEnable();
                /*0x3c0373c*/ void ReloadAllNullProperties();
                /*0x3c03aac*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x3c03ab8*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            }

            class UniversalRenderPipelineEditorResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.MaterialResources materials;

                /*0x3c03b88*/ UniversalRenderPipelineEditorResources();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader autodeskInteractivePS;
                    /*0x18*/ UnityEngine.Shader autodeskInteractiveTransparentPS;
                    /*0x20*/ UnityEngine.Shader autodeskInteractiveMaskedPS;
                    /*0x28*/ UnityEngine.Shader terrainDetailLitPS;
                    /*0x30*/ UnityEngine.Shader terrainDetailGrassPS;
                    /*0x38*/ UnityEngine.Shader terrainDetailGrassBillboardPS;
                    /*0x40*/ UnityEngine.Shader defaultSpeedTree7PS;
                    /*0x48*/ UnityEngine.Shader defaultSpeedTree8PS;

                    /*0x3c03b90*/ ShaderResources();
                }

                class MaterialResources
                {
                    /*0x10*/ UnityEngine.Material lit;
                    /*0x18*/ UnityEngine.Material particleLit;
                    /*0x20*/ UnityEngine.Material terrainLit;
                    /*0x28*/ UnityEngine.Material decal;

                    /*0x3c03b98*/ MaterialResources();
                }
            }

            class ShaderResources
            {
                /*0x10*/ UnityEngine.Shader blitPS;
                /*0x18*/ UnityEngine.Shader copyDepthPS;
                /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                /*0x28*/ UnityEngine.Shader samplingPS;
                /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                /*0x40*/ UnityEngine.Shader fallbackLoadingPS;
                /*0x48*/ UnityEngine.Shader materialErrorPS;
                /*0x50*/ UnityEngine.Shader coreBlitPS;
                /*0x58*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                /*0x60*/ UnityEngine.Shader blitHDROverlay;
                /*0x68*/ UnityEngine.Shader cameraMotionVector;
                /*0x70*/ UnityEngine.Shader screenSpaceLensFlare;
                /*0x78*/ UnityEngine.Shader dataDrivenLensFlare;

                /*0x3c03ba0*/ ShaderResources();
            }

            class UniversalRenderPipelineGlobalSettings : UnityEngine.Rendering.RenderPipelineGlobalSettings<UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings, UnityEngine.Rendering.Universal.UniversalRenderPipeline>
            {
                static int k_LastVersion = 8;
                static string defaultAssetName = "UniversalRenderPipelineGlobalSettings";
                /*0x20*/ UnityEngine.Rendering.ShaderStrippingSetting m_ShaderStrippingSetting;
                /*0x28*/ UnityEngine.Rendering.Universal.URPShaderStrippingSetting m_URPShaderStrippingSetting;
                /*0x30*/ UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;
                /*0x34*/ bool m_ExportShaderVariants;
                /*0x35*/ bool m_StripDebugVariants;
                /*0x36*/ bool m_StripUnusedPostProcessingVariants;
                /*0x37*/ bool m_StripUnusedVariants;
                /*0x38*/ bool m_StripScreenCoordOverrideVariants;
                /*0x39*/ bool supportRuntimeDebugDisplay;
                /*0x3a*/ bool m_EnableRenderGraph;
                /*0x40*/ UnityEngine.Rendering.RenderPipelineGraphicsSettingsContainer m_Settings;
                /*0x48*/ int m_AssetVersion;
                /*0x50*/ UnityEngine.Rendering.VolumeProfile m_ObsoleteDefaultVolumeProfile;
                /*0x58*/ string[] m_RenderingLayerNames;
                /*0x60*/ uint m_ValidRenderingLayers;
                /*0x68*/ string lightLayerName0;
                /*0x70*/ string lightLayerName1;
                /*0x78*/ string lightLayerName2;
                /*0x80*/ string lightLayerName3;
                /*0x88*/ string lightLayerName4;
                /*0x90*/ string lightLayerName5;
                /*0x98*/ string lightLayerName6;
                /*0xa0*/ string lightLayerName7;
                /*0xa8*/ UnityEngine.Rendering.ProbeVolumeSceneData apvScenesData;

                static /*0x3c03c2c*/ UnityEngine.Rendering.VolumeProfile GetOrCreateDefaultVolumeProfile(UnityEngine.Rendering.VolumeProfile defaultVolumeProfile);
                /*0x3c03ddc*/ UniversalRenderPipelineGlobalSettings();
                /*0x3c03ba8*/ bool get_stripUnusedLODCrossFadeVariants();
                /*0x3c03bb0*/ void set_stripUnusedLODCrossFadeVariants(bool value);
                /*0x3c03bb4*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
                /*0x3c03bcc*/ bool IsAtLastVersion();
                /*0x3c03bdc*/ void Reset();
                /*0x3c03c30*/ string[] get_prefixedLightLayerNames();
                /*0x3c03c74*/ string[] get_lightLayerNames();
                /*0x3c03cb8*/ void ResetRenderingLayerNames();
                /*0x3c03d4c*/ UnityEngine.Rendering.ProbeVolumeSceneData GetOrCreateAPVSceneData();
            }

            class URPHelpURLAttribute : UnityEngine.Rendering.CoreRPHelpURLAttribute
            {
                /*0x3c03f84*/ URPHelpURLAttribute(string pageName, string pageHash);
            }

            class Documentation : UnityEngine.Rendering.DocumentationInfo
            {
                static string packageName = "com.unity.render-pipelines.universal";

                static /*0x3c03fe8*/ string GetPageLink(string pageName);
                /*0x3c04034*/ Documentation();
            }

            class ForwardRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                static string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";
                /*0x48*/ UnityEngine.Rendering.Universal.ForwardRendererData.ShaderResources shaders;
                /*0x50*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x58*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x5c*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x60*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x68*/ bool m_ShadowTransparentReceive;
                /*0x6c*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x70*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x74*/ bool m_AccurateGbufferNormals;
                /*0x75*/ bool m_ClusteredRendering;
                /*0x78*/ UnityEngine.Rendering.Universal.TileSize m_TileSize;

                /*0x3c04488*/ ForwardRendererData();
                /*0x3c0403c*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x3c040f8*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x3c04144*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x3c04190*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x3c041dc*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x3c04228*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x3c04274*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x3c042c0*/ bool get_shadowTransparentReceive();
                /*0x3c0430c*/ void set_shadowTransparentReceive(bool value);
                /*0x3c04358*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x3c043a4*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x3c043f0*/ bool get_accurateGbufferNormals();
                /*0x3c0443c*/ void set_accurateGbufferNormals(bool value);

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader blitPS;
                    /*0x18*/ UnityEngine.Shader copyDepthPS;
                    /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                    /*0x28*/ UnityEngine.Shader samplingPS;
                    /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                    /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                    /*0x40*/ UnityEngine.Shader fallbackLoadingPS;
                    /*0x48*/ UnityEngine.Shader materialErrorPS;
                    /*0x50*/ UnityEngine.Shader coreBlitPS;
                    /*0x58*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                    /*0x60*/ UnityEngine.Shader cameraMotionVector;
                    /*0x68*/ UnityEngine.Shader objectMotionVector;

                    /*0x3c0448c*/ ShaderResources();
                }
            }

            class Universal2DResourceData : UnityEngine.Rendering.Universal.UniversalResourceDataBase
            {
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] _lightTextures;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _cameraNormalsTexture;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _normalsDepth;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] _shadowTextures;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _shadowDepth;
                /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _upscaleTexture;
                /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraSortingLayerTexture;

                /*0x3c04e5c*/ Universal2DResourceData();
                /*0x3c04494*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle);
                /*0x3c04654*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] newHandle);
                /*0x3c0474c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_lightTextures();
                /*0x3c04754*/ void set_lightTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x3c04760*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_normalsTexture();
                /*0x3c04850*/ void set_normalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x3c0494c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_normalsDepth();
                /*0x3c049f0*/ void set_normalsDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c04a48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_shadowTextures();
                /*0x3c04a50*/ void set_shadowTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x3c04a5c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_shadowDepth();
                /*0x3c04a64*/ void set_shadowDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c04a90*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_upscaleTexture();
                /*0x3c04a98*/ void set_upscaleTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c04ac4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraSortingLayerTexture();
                /*0x3c04acc*/ void set_cameraSortingLayerTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c04af8*/ void Reset();
            }

            class UniversalCameraData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ UnityEngine.Matrix4x4 m_ViewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 m_ProjectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 m_JitterMatrix;
                /*0xd0*/ UnityEngine.Camera camera;
                /*0xd8*/ UnityEngine.Rendering.Universal.UniversalCameraHistory m_HistoryManager;
                /*0xe0*/ UnityEngine.Rendering.Universal.CameraRenderType renderType;
                /*0xe8*/ UnityEngine.RenderTexture targetTexture;
                /*0xf0*/ UnityEngine.RenderTextureDescriptor cameraTargetDescriptor;
                /*0x124*/ UnityEngine.Rect pixelRect;
                /*0x134*/ bool useScreenCoordOverride;
                /*0x138*/ UnityEngine.Vector4 screenSizeOverride;
                /*0x148*/ UnityEngine.Vector4 screenCoordScaleBias;
                /*0x158*/ int pixelWidth;
                /*0x15c*/ int pixelHeight;
                /*0x160*/ float aspectRatio;
                /*0x164*/ float renderScale;
                /*0x168*/ UnityEngine.Rendering.Universal.ImageScalingMode imageScalingMode;
                /*0x16c*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter upscalingFilter;
                /*0x170*/ bool fsrOverrideSharpness;
                /*0x174*/ float fsrSharpness;
                /*0x178*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision hdrColorBufferPrecision;
                /*0x17c*/ bool clearDepth;
                /*0x180*/ UnityEngine.CameraType cameraType;
                /*0x184*/ bool isDefaultViewport;
                /*0x185*/ bool isHdrEnabled;
                /*0x186*/ bool allowHDROutput;
                /*0x187*/ bool isAlphaOutputEnabled;
                /*0x188*/ bool requiresDepthTexture;
                /*0x189*/ bool requiresOpaqueTexture;
                /*0x18a*/ bool postProcessingRequiresDepthTexture;
                /*0x18b*/ bool xrRendering;
                /*0x18c*/ bool useGPUOcclusionCulling;
                /*0x18d*/ bool stackLastCameraOutputToHDR;
                /*0x190*/ UnityEngine.Rendering.SortingCriteria defaultOpaqueSortFlags;
                /*0x198*/ UnityEngine.Experimental.Rendering.XRPass <xr>k__BackingField;
                /*0x1a0*/ float maxShadowDistance;
                /*0x1a4*/ bool postProcessEnabled;
                /*0x1a5*/ bool stackAnyPostProcessingEnabled;
                /*0x1a8*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;
                /*0x1b0*/ UnityEngine.LayerMask volumeLayerMask;
                /*0x1b8*/ UnityEngine.Transform volumeTrigger;
                /*0x1c0*/ bool isStopNaNEnabled;
                /*0x1c1*/ bool isDitheringEnabled;
                /*0x1c4*/ UnityEngine.Rendering.Universal.AntialiasingMode antialiasing;
                /*0x1c8*/ UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality;
                /*0x1d0*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                /*0x1d8*/ bool resolveFinalTarget;
                /*0x1dc*/ UnityEngine.Vector3 worldSpaceCameraPos;
                /*0x1e8*/ UnityEngine.Color backgroundColor;
                /*0x1f8*/ UnityEngine.Rendering.Universal.TaaHistory taaHistory;
                /*0x200*/ UnityEngine.Rendering.Universal.StpHistory stpHistory;
                /*0x208*/ UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings;
                /*0x228*/ UnityEngine.Camera baseCamera;
                /*0x230*/ bool isLastBaseCamera;

                /*0x3c05c74*/ UniversalCameraData();
                /*0x3c04f1c*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x3c04f94*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x3c04fc8*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x3c04fcc*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x3c04fe0*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x3c0503c*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x3c05050*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x3c051c0*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x3c05214*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x3c052e4*/ int get_scaledWidth();
                /*0x3c05330*/ int get_scaledHeight();
                /*0x3c0537c*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x3c05384*/ void set_historyManager(UnityEngine.Rendering.Universal.UniversalCameraHistory value);
                /*0x3c0538c*/ bool get_requireSrgbConversion();
                /*0x3c0543c*/ bool get_isGameCamera();
                /*0x3c0544c*/ bool get_isSceneViewCamera();
                /*0x3c0545c*/ bool get_isPreviewCamera();
                /*0x3c0546c*/ bool get_isRenderPassSupportedCamera();
                /*0x3c05480*/ bool get_resolveToScreen();
                /*0x3c05528*/ bool get_isHDROutputActive();
                /*0x3c055a0*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x3c05668*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x3c056c8*/ bool get_rendersOverlayUI();
                /*0x3c05744*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x3c050f0*/ bool IsCameraProjectionMatrixFlipped();
                /*0x3c0588c*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x3c05930*/ bool IsTemporalAARequested();
                /*0x3c05940*/ bool IsTemporalAAEnabled();
                /*0x3c05a30*/ bool IsSTPRequested();
                /*0x3c05a54*/ bool IsSTPEnabled();
                /*0x3c05a78*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x3c05a80*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x3c05a90*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x3c05b0c*/ bool get_resetHistory();
                /*0x3c05b1c*/ void Reset();
            }

            class UniversalLightData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ int mainLightIndex;
                /*0x14*/ int additionalLightsCount;
                /*0x18*/ int maxPerObjectAdditionalLightsCount;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights;
                /*0x30*/ bool shadeAdditionalLightsPerVertex;
                /*0x31*/ bool supportsMixedLighting;
                /*0x32*/ bool reflectionProbeBoxProjection;
                /*0x33*/ bool reflectionProbeBlending;
                /*0x34*/ bool supportsLightLayers;
                /*0x35*/ bool supportsAdditionalLights;

                /*0x3c05c94*/ UniversalLightData();
                /*0x3c05c7c*/ void Reset();
            }

            class UniversalPostProcessingData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool isEnabled;
                /*0x14*/ UnityEngine.Rendering.Universal.ColorGradingMode gradingMode;
                /*0x18*/ int lutSize;
                /*0x1c*/ bool useFastSRGBLinearConversion;
                /*0x1d*/ bool supportScreenSpaceLensFlare;
                /*0x1e*/ bool supportDataDrivenLensFlare;

                /*0x3c05cac*/ UniversalPostProcessingData();
                /*0x3c05c9c*/ void Reset();
            }

            class UniversalRenderingData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                /*0x18*/ UnityEngine.Rendering.CullingResults cullResults;
                /*0x28*/ bool supportsDynamicBatching;
                /*0x2c*/ UnityEngine.Rendering.PerObjectData perObjectData;
                /*0x30*/ UnityEngine.Rendering.Universal.RenderingMode <renderingMode>k__BackingField;
                /*0x34*/ UnityEngine.LayerMask <opaqueLayerMask>k__BackingField;
                /*0x38*/ UnityEngine.LayerMask <transparentLayerMask>k__BackingField;

                /*0x3c05dac*/ UniversalRenderingData();
                /*0x3c05cb4*/ UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x3c05d30*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x3c05d38*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x3c05d40*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x3c05d48*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x3c05d50*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x3c05d58*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x3c05d60*/ void Reset();
            }

            class UniversalResourceDataBase : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool <isAccessible>k__BackingField;

                /*0x3c04f14*/ UniversalResourceDataBase();
                /*0x3c05db4*/ bool get_isAccessible();
                /*0x3c05dbc*/ void set_isAccessible(bool value);
                /*0x3c05dc4*/ void InitFrame();
                /*0x3c05dd0*/ void EndFrame();
                /*0x3c04a1c*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle newHandle);
                /*0x3c04954*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x3c0485c*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] newHandle);
                /*0x3c04768*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle);
                /*0x3c045c8*/ bool CheckAndWarnAboutAccessibility();

                enum ActiveID
                {
                    Camera = 0,
                    BackBuffer = 1,
                }
            }

            class UniversalResourceData : UnityEngine.Rendering.Universal.UniversalResourceDataBase
            {
                /*0x14*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID <activeColorID>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID <activeDepthID>k__BackingField;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _backBufferColor;
                /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _backBufferDepth;
                /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraColor;
                /*0x4c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraDepth;
                /*0x5c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _mainShadowsTexture;
                /*0x6c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _additionalShadowsTexture;
                /*0x80*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _gBuffer;
                /*0x88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraOpaqueTexture;
                /*0x98*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraDepthTexture;
                /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraNormalsTexture;
                /*0xb8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _motionVectorColor;
                /*0xc8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _motionVectorDepth;
                /*0xd8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _internalColorLut;
                /*0xe8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _debugScreenColor;
                /*0xf8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _debugScreenDepth;
                /*0x108*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _afterPostProcessColor;
                /*0x118*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _overlayUITexture;
                /*0x128*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _renderingLayersTexture;
                /*0x138*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _dBuffer;
                /*0x140*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _dBufferDepth;
                /*0x150*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _ssaoTexture;
                /*0x160*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _stpDebugView;

                /*0x3c06bbc*/ UniversalResourceData();
                /*0x3c05dd8*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeColorID();
                /*0x3c05de0*/ void set_activeColorID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x3c05de8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeColorTexture();
                /*0x3c05eec*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeDepthID();
                /*0x3c05ef4*/ void set_activeDepthID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x3c05efc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeDepthTexture();
                /*0x3c06000*/ bool get_isActiveTargetBackBuffer();
                /*0x3c05ee4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferColor();
                /*0x3c0608c*/ void set_backBufferColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c05ff8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferDepth();
                /*0x3c060bc*/ void set_backBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c05edc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraColor();
                /*0x3c060ec*/ void set_cameraColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c05ff0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepth();
                /*0x3c0611c*/ void set_cameraDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c0614c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_mainShadowsTexture();
                /*0x3c06154*/ void set_mainShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06184*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_additionalShadowsTexture();
                /*0x3c0618c*/ void set_additionalShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c061bc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_gBuffer();
                /*0x3c061c4*/ void set_gBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x3c061d0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraOpaqueTexture();
                /*0x3c061d8*/ void set_cameraOpaqueTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06204*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepthTexture();
                /*0x3c0620c*/ void set_cameraDepthTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06238*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraNormalsTexture();
                /*0x3c06240*/ void set_cameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c0626c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorColor();
                /*0x3c06274*/ void set_motionVectorColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c062a0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorDepth();
                /*0x3c062a8*/ void set_motionVectorDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c062d4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_internalColorLut();
                /*0x3c062dc*/ void set_internalColorLut(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06308*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenColor();
                /*0x3c06310*/ void set_debugScreenColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c0633c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenDepth();
                /*0x3c06344*/ void set_debugScreenDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06370*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_afterPostProcessColor();
                /*0x3c06378*/ void set_afterPostProcessColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c063a4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_overlayUITexture();
                /*0x3c063ac*/ void set_overlayUITexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c063d8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_renderingLayersTexture();
                /*0x3c063e0*/ void set_renderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c0640c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_dBuffer();
                /*0x3c06414*/ void set_dBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x3c06420*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_dBufferDepth();
                /*0x3c06428*/ void set_dBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06454*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_ssaoTexture();
                /*0x3c0645c*/ void set_ssaoTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c06488*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_stpDebugView();
                /*0x3c06490*/ void set_stpDebugView(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c064bc*/ void Reset();
            }

            class UniversalShadowData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool supportsMainLightShadows;
                /*0x11*/ bool mainLightShadowsEnabled;
                /*0x14*/ int mainLightShadowmapWidth;
                /*0x18*/ int mainLightShadowmapHeight;
                /*0x1c*/ int mainLightShadowCascadesCount;
                /*0x20*/ UnityEngine.Vector3 mainLightShadowCascadesSplit;
                /*0x2c*/ float mainLightShadowCascadeBorder;
                /*0x30*/ bool supportsAdditionalLightShadows;
                /*0x31*/ bool additionalLightShadowsEnabled;
                /*0x34*/ int additionalLightsShadowmapWidth;
                /*0x38*/ int additionalLightsShadowmapHeight;
                /*0x3c*/ bool supportsSoftShadows;
                /*0x40*/ int shadowmapDepthBufferBits;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector4> bias;
                /*0x50*/ System.Collections.Generic.List<int> resolution;
                /*0x58*/ bool isKeywordAdditionalLightShadowsEnabled;
                /*0x59*/ bool isKeywordSoftShadowsEnabled;
                /*0x5c*/ int mainLightShadowResolution;
                /*0x60*/ int mainLightRenderTargetWidth;
                /*0x64*/ int mainLightRenderTargetHeight;
                /*0x68*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> visibleLightsShadowCullingInfos;
                /*0x78*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout;

                /*0x3c06db8*/ UniversalShadowData();
                /*0x3c06c3c*/ void Reset();
            }

            class RawColorHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x3c07290*/ RawColorHistory();
                /*0x3c0722c*/ RawColorHistory();
                /*0x3c06dc0*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x3c06e34*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x3c06e80*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x3c06ecc*/ bool IsAllocated();
                /*0x3c06ee8*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x3c06f58*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x3c070ac*/ void Reset();
                /*0x3c0710c*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x3c07144*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class RawDepthHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x3c07834*/ RawDepthHistory();
                /*0x3c077d0*/ RawDepthHistory();
                /*0x3c07374*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x3c073e8*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x3c07434*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x3c07480*/ bool IsAllocated();
                /*0x3c0749c*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x3c0750c*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x3c07660*/ void Reset();
                /*0x3c076c0*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x3c076ec*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class SingleHistoryBase : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x1c*/ int m_Id;
                /*0x20*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x58*/ UnityEngine.Hash128 m_DescKey;

                /*0x3c07be8*/ SingleHistoryBase();
                /*0x3c07918*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x3c07944*/ UnityEngine.Rendering.RTHandle GetTexture(int frameIndex);
                /*0x3c079a4*/ UnityEngine.Rendering.RTHandle GetCurrentTexture();
                /*0x3c079b0*/ UnityEngine.Rendering.RTHandle GetPreviousTexture();
                /*0x3c079b8*/ bool IsAllocated();
                /*0x3c079d4*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x3c07a44*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x3c07afc*/ void Reset();
                /*0x3c07b08*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x1f2ffc8*/ int GetHistoryFrameCount();
                /*0x1f30214*/ string GetHistoryName();
                UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
            }

            class StpHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x20*/ UnityEngine.Rendering.STP.HistoryContext[] m_historyContexts;

                /*0x3c07e1c*/ StpHistory();
                /*0x3c07bf0*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x3c07cb4*/ void Reset();
                /*0x3c07d14*/ UnityEngine.Rendering.STP.HistoryContext GetHistoryContext(int eyeIndex);
                /*0x3c07d44*/ bool Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
            }

            class TaaHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_TaaAccumulationNames;
                /*0x20*/ int[] m_TaaAccumulationTextureIds;
                /*0x28*/ int[] m_TaaAccumulationVersions;
                /*0x30*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x68*/ UnityEngine.Hash128 m_DescKey;

                static /*0x3c083ac*/ TaaHistory();
                /*0x3c0832c*/ TaaHistory();
                /*0x3c07e80*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x3c07ef4*/ void Reset();
                /*0x3c07f9c*/ UnityEngine.Rendering.RTHandle GetAccumulationTexture(int eyeIndex);
                /*0x3c07fd0*/ int GetAccumulationVersion(int eyeIndex);
                /*0x3c08000*/ void SetAccumulationVersion(int eyeIndex, int version);
                /*0x3c08030*/ bool IsValid();
                /*0x3c0804c*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x3c080bc*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x3c0820c*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            enum IntermediateTextureMode
            {
                Auto = 0,
                Always = 1,
            }

            class LightCookieManager : System.IDisposable
            {
                static int k_MaxCookieSizeDivisor = 16;
                static /*0x0*/ UnityEngine.Matrix4x4 s_DirLightProj;
                /*0x10*/ UnityEngine.Rendering.Texture2DAtlas m_AdditionalLightsCookieAtlas;
                /*0x18*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderData m_AdditionalLightsCookieShaderData;
                /*0x20*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings m_Settings;
                /*0x38*/ UnityEngine.Rendering.Universal.LightCookieManager.WorkMemory m_WorkMem;
                /*0x40*/ int[] m_VisibleLightIndexToShaderDataIndex;
                /*0x48*/ int m_CookieSizeDivisor;
                /*0x4c*/ uint m_PrevCookieRequestPixelCount;
                /*0x50*/ int m_PrevWarnFrame;
                /*0x54*/ bool <IsKeywordLightCookieEnabled>k__BackingField;

                static /*0x3c0ae64*/ LightCookieManager();
                /*0x3c084b8*/ LightCookieManager(ref UnityEngine.Rendering.Universal.LightCookieManager.Settings settings);
                /*0x3c08490*/ bool get_IsKeywordLightCookieEnabled();
                /*0x3c08498*/ void set_IsKeywordLightCookieEnabled(bool value);
                /*0x3c084a0*/ UnityEngine.Rendering.RTHandle get_AdditionalLightsCookieAtlasTexture();
                /*0x3c0855c*/ void InitAdditionalLights(int size);
                /*0x3c086dc*/ bool isInitialized();
                /*0x3c086fc*/ void Dispose();
                /*0x3c08774*/ int GetLightCookieShaderDataIndex(int visibleLightIndex);
                /*0x3c087bc*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3c08a50*/ bool SetupMainLight(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight visibleMainLight);
                /*0x3c09060*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(UnityEngine.Experimental.Rendering.GraphicsFormat cookieFormat);
                /*0x3c09140*/ void GetLightUVScaleOffset(ref UnityEngine.Rendering.Universal.UniversalAdditionalLightData additionalLightData, ref UnityEngine.Matrix4x4 uvTransform);
                /*0x3c08e38*/ bool SetupAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3c0947c*/ int FilterAndValidateAdditionalLights(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] validLightMappings);
                /*0x3c09978*/ int UpdateAdditionalLightsAtlas(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects);
                /*0x3c0a2dc*/ int FetchUVRects(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects, int cookieSizeDivisor);
                /*0x3c0a1a8*/ uint ComputeCookieRequestPixelCount(ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings);
                /*0x3c0a2b0*/ int ApproximateCookieSizeDivisor(float requestAtlasRatio);
                /*0x3c0a6a4*/ UnityEngine.Vector4 Fetch2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x3c0a540*/ UnityEngine.Vector4 FetchCube(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x3c0a8ac*/ int ComputeOctahedralCookieSize(UnityEngine.Texture cookie);
                /*0x3c0a800*/ void AdjustUVRect(ref UnityEngine.Vector4 uvScaleOffset, UnityEngine.Texture cookie, ref UnityEngine.Vector2 cookieSize);
                /*0x3c0aa00*/ void ShrinkUVRect(ref UnityEngine.Vector4 uvScaleOffset, float amountPixels, ref UnityEngine.Vector2 cookieSize);
                /*0x3c09af4*/ void UploadAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Vector4> validUvRects);

                class ShaderProperty
                {
                    static /*0x0*/ int mainLightTexture;
                    static /*0x4*/ int mainLightWorldToLight;
                    static /*0x8*/ int mainLightCookieTextureFormat;
                    static /*0xc*/ int additionalLightsCookieAtlasTexture;
                    static /*0x10*/ int additionalLightsCookieAtlasTextureFormat;
                    static /*0x14*/ int additionalLightsCookieEnableBits;
                    static /*0x18*/ int additionalLightsCookieAtlasUVRectBuffer;
                    static /*0x1c*/ int additionalLightsCookieAtlasUVRects;
                    static /*0x20*/ int additionalLightsWorldToLightBuffer;
                    static /*0x24*/ int additionalLightsLightTypeBuffer;
                    static /*0x28*/ int additionalLightsWorldToLights;
                    static /*0x2c*/ int additionalLightsLightTypes;

                    static /*0x3c0aee4*/ ShaderProperty();
                }

                enum LightCookieShaderFormat
                {
                    None = -1,
                    RGB = 0,
                    Alpha = 1,
                    Red = 2,
                }

                struct Settings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings.AtlasSettings atlas;
                    /*0x1c*/ int maxAdditionalLights;
                    /*0x20*/ float cubeOctahedralSizeScale;
                    /*0x24*/ bool useStructuredBuffer;

                    static /*0x3c0b17c*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings Create();

                    struct AtlasSettings
                    {
                        /*0x10*/ UnityEngine.Vector2Int resolution;
                        /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;

                        /*0x3c0a9d4*/ bool get_isPow2();
                        /*0x3c0b230*/ bool get_isSquare();
                    }
                }

                struct LightCookieMapping
                {
                    static /*0x0*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex;
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort lightBufferIndex;
                    /*0x18*/ UnityEngine.Light light;

                    static /*0x3c0b240*/ LightCookieMapping();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping.<> <>9;

                        static /*0x3c0b368*/ <>c();
                        /*0x3c0b3d0*/ <>c();
                        /*0x3c0b3d8*/ int <.cctor>b__6_0(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                        /*0x3c0b4a4*/ int <.cctor>b__6_1(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                    }
                }

                struct WorkSlice<T>
                {
                    /*0x0*/ T[] m_Data;
                    /*0x0*/ int m_Start;
                    /*0x0*/ int m_Length;

                    /*0x1f30ee8*/ WorkSlice(T[] src, int srcLen);
                    WorkSlice(T[] src, int srcStart, int srcLen);
                    /*0x1ffc854*/ T get_Item(int index);
                    /*0x1ffc854*/ void set_Item(int index, T value);
                    /*0x1f2ffc8*/ int get_length();
                    /*0x1f2ffc8*/ int get_capacity();
                    /*0x1f30ebc*/ void Sort(System.Func<T, T, int> compare);
                }

                class WorkMemory
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] lightMappings;
                    /*0x18*/ UnityEngine.Vector4[] uvRects;

                    /*0x3c08554*/ WorkMemory();
                    /*0x3c09264*/ void Resize(int size);
                }

                class LightCookieShaderData : System.IDisposable
                {
                    /*0x10*/ int m_Size;
                    /*0x14*/ bool m_UseStructuredBuffer;
                    /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToLightCpuData;
                    /*0x20*/ UnityEngine.Vector4[] m_AtlasUVRectCpuData;
                    /*0x28*/ float[] m_LightTypeCpuData;
                    /*0x30*/ UnityEngine.Rendering.Universal.ShaderBitArray m_CookieEnableBitsCpuData;
                    /*0x38*/ UnityEngine.ComputeBuffer m_WorldToLightBuffer;
                    /*0x40*/ UnityEngine.ComputeBuffer m_AtlasUVRectBuffer;
                    /*0x48*/ UnityEngine.ComputeBuffer m_LightTypeBuffer;
                    /*0x50*/ bool <isUploaded>k__BackingField;

                    /*0x3c086a8*/ LightCookieShaderData(int size, bool useStructuredBuffer);
                    /*0x3c0b4b0*/ UnityEngine.Matrix4x4[] get_worldToLights();
                    /*0x3c0b4b8*/ UnityEngine.Rendering.Universal.ShaderBitArray get_cookieEnableBits();
                    /*0x3c0b4c0*/ UnityEngine.Vector4[] get_atlasUVRects();
                    /*0x3c0b4c8*/ float[] get_lightTypes();
                    /*0x3c0b4d0*/ bool get_isUploaded();
                    /*0x3c0b4d8*/ void set_isUploaded(bool value);
                    /*0x3c0872c*/ void Dispose();
                    /*0x3c0aaa4*/ void Resize(int size);
                    /*0x3c0acd0*/ void Upload(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c08fd0*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                }
            }

            struct BuddyAllocation
            {
                /*0x10*/ int level;
                /*0x14*/ int index;

                /*0x3c0b4e0*/ BuddyAllocation(int level, int index);
                /*0x3c0b4e8*/ Unity.Mathematics.uint2 get_index2D();
            }

            struct BuddyAllocator : System.IDisposable
            {
                /*0x10*/ void* m_Data;
                /*0x18*/ System.ValueTuple<int, int> m_ActiveFreeMaskCounts;
                /*0x20*/ System.ValueTuple<int, int> m_FreeMasksStorage;
                /*0x28*/ System.ValueTuple<int, int> m_FreeMaskIndicesStorage;
                /*0x30*/ Unity.Collections.Allocator m_Allocator;

                static /*0x3c0bd5c*/ int LevelOffset(int level, int branchingOrder);
                static /*0x3c0bd7c*/ int LevelLength(int level, int branchingOrder);
                static /*0x3c0b6a4*/ int LevelOffset64(int level, int branchingOrder);
                static /*0x3c0b6dc*/ int LevelLength64(int level, int branchingOrder);
                static /*0x1ffc854*/ System.ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize);
                static /*0x3c0bd9c*/ int AlignForward(int offset, int alignment);
                static /*0x3c0bdb8*/ void* PtrAdd(void* ptr, int bytes);
                static /*0x3c0bbc8*/ int Pow2(int n);
                static /*0x3c0bd8c*/ int Pow2N(int x, int n);
                /*0x3c0b868*/ BuddyAllocator(int levelCount, int branchingOrder, Unity.Collections.Allocator allocator);
                /*0x3c0b4f4*/ ref UnityEngine.Rendering.Universal.BuddyAllocator.Header get_header();
                /*0x3c0b530*/ Unity.Collections.NativeArray<int> get_freeMaskCounts();
                /*0x3c0b57c*/ Unity.Collections.NativeArray<ulong> get_freeMasksStorage();
                /*0x3c0b5c8*/ Unity.Collections.NativeArray<ulong> FreeMasks(int level);
                /*0x3c0b700*/ Unity.Collections.NativeArray<int> get_freeMaskIndicesStorage();
                /*0x3c0b74c*/ Unity.Collections.NativeArray<int> FreeMaskIndices(int level);
                /*0x3c0b828*/ int get_levelCount();
                /*0x3c0b9c8*/ bool TryAllocate(int requestedLevel, ref UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x3c0bbd4*/ void Free(UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x3c0bd34*/ void Dispose();
                /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(int offset, int length);

                struct Header
                {
                    /*0x10*/ int branchingOrder;
                    /*0x14*/ int levelCount;
                    /*0x18*/ int allocationCount;
                    /*0x1c*/ int freeAllocationIdsCount;
                }
            }

            struct Fixed2<T>
            {
                /*0x0*/ T item1;
                /*0x0*/ T item2;

                static /*0x1f346e4*/ void CheckRange(int index);
                /*0x1ffc854*/ Fixed2(T item1);
                /*0x1ffc854*/ Fixed2(T item1, T item2);
                /*0x1ffc854*/ T get_Item(int index);
                /*0x1ffc854*/ void set_Item(int index, T value);
            }

            struct PinnedArray<T> : System.IDisposable
            {
                /*0x0*/ T[] managedArray;
                /*0x0*/ System.Runtime.InteropServices.GCHandle handle;
                /*0x0*/ Unity.Collections.NativeArray<T> nativeArray;

                /*0x1f30b78*/ PinnedArray(int length);
                /*0x1f2ffc8*/ int get_length();
                /*0x1f309e4*/ void Dispose();
            }

            class MotionVectorsPersistentData
            {
                static int k_EyeCount = 2;
                /*0x10*/ UnityEngine.Matrix4x4[] m_Projection;
                /*0x18*/ UnityEngine.Matrix4x4[] m_View;
                /*0x20*/ UnityEngine.Matrix4x4[] m_ViewProjection;
                /*0x28*/ UnityEngine.Matrix4x4[] m_PreviousProjection;
                /*0x30*/ UnityEngine.Matrix4x4[] m_PreviousView;
                /*0x38*/ UnityEngine.Matrix4x4[] m_PreviousViewProjection;
                /*0x40*/ UnityEngine.Matrix4x4[] m_PreviousPreviousProjection;
                /*0x48*/ UnityEngine.Matrix4x4[] m_PreviousPreviousView;
                /*0x50*/ int[] m_LastFrameIndex;
                /*0x58*/ float[] m_PrevAspectRatio;
                /*0x60*/ float m_deltaTime;
                /*0x64*/ float m_lastDeltaTime;
                /*0x68*/ UnityEngine.Vector3 m_worldSpaceCameraPos;
                /*0x74*/ UnityEngine.Vector3 m_previousWorldSpaceCameraPos;
                /*0x80*/ UnityEngine.Vector3 m_previousPreviousWorldSpaceCameraPos;

                static /*0x3c0c348*/ int GetXRMultiPassId(UnityEngine.Experimental.Rendering.XRPass xr);
                /*0x3c0bde0*/ MotionVectorsPersistentData();
                /*0x3c0c244*/ int get_lastFrameIndex();
                /*0x3c0c26c*/ UnityEngine.Matrix4x4 get_viewProjection();
                /*0x3c0c2a0*/ UnityEngine.Matrix4x4 get_previousViewProjection();
                /*0x3c0c2d4*/ UnityEngine.Matrix4x4[] get_viewProjectionStereo();
                /*0x3c0c2dc*/ UnityEngine.Matrix4x4[] get_previousViewProjectionStereo();
                /*0x3c0c2e4*/ UnityEngine.Matrix4x4[] get_projectionStereo();
                /*0x3c0c2ec*/ UnityEngine.Matrix4x4[] get_previousProjectionStereo();
                /*0x3c0c2f4*/ UnityEngine.Matrix4x4[] get_previousPreviousProjectionStereo();
                /*0x3c0c2fc*/ UnityEngine.Matrix4x4[] get_viewStereo();
                /*0x3c0c304*/ UnityEngine.Matrix4x4[] get_previousViewStereo();
                /*0x3c0c30c*/ UnityEngine.Matrix4x4[] get_previousPreviousViewStereo();
                /*0x3c0c314*/ float get_deltaTime();
                /*0x3c0c31c*/ float get_lastDeltaTime();
                /*0x3c0c324*/ UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x3c0c330*/ UnityEngine.Vector3 get_previousWorldSpaceCameraPos();
                /*0x3c0c33c*/ UnityEngine.Vector3 get_previousPreviousWorldSpaceCameraPos();
                /*0x3c0bf78*/ void Reset();
                /*0x3c0c350*/ void Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c0c8b0*/ void SetGlobalMotionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr);
            }

            struct Sorting
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_QuickSortSampler;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler s_InsertionSortSampler;

                static /*0x3c0c998*/ Sorting();
                static /*0x1f36f18*/ void QuickSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x1f36320*/ void QuickSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x1ffc854*/ T Median3Pivot<T>(T[] data, int start, int pivot, int end, System.Func<T, T, int> compare);
                static /*0x1ffc854*/ int Partition<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x1f36f18*/ void InsertionSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x1f36320*/ void InsertionSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static void <Median3Pivot>g__Swap|4_0<T>(int a, int b, ref UnityEngine.Rendering.Universal.Sorting.<>c__DisplayClass4_0<T> );

                struct <>c__DisplayClass4_0<T>
                {
                    /*0x0*/ T[] data;
                }
            }

            enum BloomDownscaleMode
            {
                Half = 0,
                Quarter = 1,
            }

            class DownscaleParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.BloomDownscaleMode>
            {
                /*0x3c03634*/ DownscaleParameter(UnityEngine.Rendering.Universal.BloomDownscaleMode value, bool overrideState);
            }

            class ChannelMixer : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter redOutRedIn;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter redOutGreenIn;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter redOutBlueIn;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter greenOutRedIn;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter greenOutGreenIn;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter greenOutBlueIn;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter blueOutRedIn;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter blueOutGreenIn;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter blueOutBlueIn;

                /*0x3c0cbd0*/ ChannelMixer();
                /*0x3c0ca74*/ bool IsActive();
                /*0x3c0cbc8*/ bool IsTileCompatible();
            }

            class ChromaticAberration : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;

                /*0x3c0ce4c*/ ChromaticAberration();
                /*0x3c0ce14*/ bool IsActive();
                /*0x3c0ce44*/ bool IsTileCompatible();
            }

            class ColorAdjustments : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.FloatParameter postExposure;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contrast;
                /*0x48*/ UnityEngine.Rendering.ColorParameter colorFilter;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShift;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter saturation;

                /*0x3c0cfc4*/ ColorAdjustments();
                /*0x3c0cec8*/ bool IsActive();
                /*0x3c0cfbc*/ bool IsTileCompatible();
            }

            class ColorCurves : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureCurveParameter master;
                /*0x40*/ UnityEngine.Rendering.TextureCurveParameter red;
                /*0x48*/ UnityEngine.Rendering.TextureCurveParameter green;
                /*0x50*/ UnityEngine.Rendering.TextureCurveParameter blue;
                /*0x58*/ UnityEngine.Rendering.TextureCurveParameter hueVsHue;
                /*0x60*/ UnityEngine.Rendering.TextureCurveParameter hueVsSat;
                /*0x68*/ UnityEngine.Rendering.TextureCurveParameter satVsSat;
                /*0x70*/ UnityEngine.Rendering.TextureCurveParameter lumVsSat;

                /*0x3c0d178*/ ColorCurves();
                /*0x3c0d168*/ bool IsActive();
                /*0x3c0d170*/ bool IsTileCompatible();
            }

            class ColorLookup : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureParameter texture;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contribution;

                /*0x3c0da38*/ ColorLookup();
                /*0x3c0d7a0*/ bool IsActive();
                /*0x3c0da30*/ bool IsTileCompatible();
                /*0x3c0d7e4*/ bool ValidateLUT();
            }

            enum DepthOfFieldMode
            {
                Off = 0,
                Gaussian = 1,
                Bokeh = 2,
            }

            class DepthOfField : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.DepthOfFieldModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.MinFloatParameter gaussianStart;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter gaussianEnd;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter gaussianMaxRadius;
                /*0x58*/ UnityEngine.Rendering.BoolParameter highQualitySampling;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter focusDistance;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter aperture;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter focalLength;
                /*0x78*/ UnityEngine.Rendering.ClampedIntParameter bladeCount;
                /*0x80*/ UnityEngine.Rendering.ClampedFloatParameter bladeCurvature;
                /*0x88*/ UnityEngine.Rendering.ClampedFloatParameter bladeRotation;

                /*0x3c0db84*/ DepthOfField();
                /*0x3c0dafc*/ bool IsActive();
                /*0x3c0db7c*/ bool IsTileCompatible();
            }

            class DepthOfFieldModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.DepthOfFieldMode>
            {
                /*0x3c0de60*/ DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode value, bool overrideState);
            }

            enum FilmGrainLookup
            {
                Thin1 = 0,
                Thin2 = 1,
                Medium1 = 2,
                Medium2 = 3,
                Medium3 = 4,
                Medium4 = 5,
                Medium5 = 6,
                Medium6 = 7,
                Large01 = 8,
                Large02 = 9,
                Custom = 10,
            }

            class FilmGrain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.FilmGrainLookupParameter type;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter response;
                /*0x50*/ UnityEngine.Rendering.NoInterpTextureParameter texture;

                /*0x3c0dfb0*/ FilmGrain();
                /*0x3c0ded0*/ bool IsActive();
                /*0x3c0dfa8*/ bool IsTileCompatible();
            }

            class FilmGrainLookupParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.FilmGrainLookup>
            {
                /*0x3c0e0e8*/ FilmGrainLookupParameter(UnityEngine.Rendering.Universal.FilmGrainLookup value, bool overrideState);
            }

            class LensDistortion : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter xMultiplier;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter yMultiplier;
                /*0x50*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter scale;

                /*0x3c0e1e4*/ LensDistortion();
                /*0x3c0e158*/ bool IsActive();
                /*0x3c0e1dc*/ bool IsTileCompatible();
            }

            class LiftGammaGain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter lift;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter gamma;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter gain;

                /*0x3c0e3fc*/ LiftGammaGain();
                /*0x3c0e34c*/ bool IsActive();
                /*0x3c0e3f4*/ bool IsTileCompatible();
            }

            enum MotionBlurMode
            {
                CameraOnly = 0,
                CameraAndObjects = 1,
            }

            enum MotionBlurQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class MotionBlur : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.MotionBlurModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.Universal.MotionBlurQualityParameter quality;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter clamp;

                /*0x3c0e524*/ MotionBlur();
                /*0x3c0e4ec*/ bool IsActive();
                /*0x3c0e51c*/ bool IsTileCompatible();
            }

            class MotionBlurModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurMode>
            {
                /*0x3c0e65c*/ MotionBlurModeParameter(UnityEngine.Rendering.Universal.MotionBlurMode value, bool overrideState);
            }

            class MotionBlurQualityParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurQuality>
            {
                /*0x3c0e6cc*/ MotionBlurQualityParameter(UnityEngine.Rendering.Universal.MotionBlurQuality value, bool overrideState);
            }

            class PaniniProjection : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter distance;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter cropToFit;

                /*0x3c0e774*/ PaniniProjection();
                /*0x3c0e73c*/ bool IsActive();
                /*0x3c0e76c*/ bool IsTileCompatible();
            }

            enum ScreenSpaceLensFlareResolution
            {
                Half = 2,
                Quarter = 4,
                Eighth = 8,
            }

            class ScreenSpaceLensFlare : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.MinFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ColorParameter tintColor;
                /*0x48*/ UnityEngine.Rendering.ClampedIntParameter bloomMip;
                /*0x50*/ UnityEngine.Rendering.MinFloatParameter firstFlareIntensity;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter secondaryFlareIntensity;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter warpedFlareIntensity;
                /*0x68*/ UnityEngine.Rendering.Vector2Parameter warpedFlareScale;
                /*0x70*/ UnityEngine.Rendering.ClampedIntParameter samples;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter sampleDimmer;
                /*0x80*/ UnityEngine.Rendering.ClampedFloatParameter vignetteEffect;
                /*0x88*/ UnityEngine.Rendering.ClampedFloatParameter startingPosition;
                /*0x90*/ UnityEngine.Rendering.ClampedFloatParameter scale;
                /*0x98*/ UnityEngine.Rendering.MinFloatParameter streaksIntensity;
                /*0xa0*/ UnityEngine.Rendering.ClampedFloatParameter streaksLength;
                /*0xa8*/ UnityEngine.Rendering.FloatParameter streaksOrientation;
                /*0xb0*/ UnityEngine.Rendering.ClampedFloatParameter streaksThreshold;
                /*0xb8*/ UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolutionParameter resolution;
                /*0xc0*/ UnityEngine.Rendering.ClampedFloatParameter chromaticAbberationIntensity;

                /*0x3c0e824*/ ScreenSpaceLensFlare();
                /*0x3c0ed1c*/ bool IsActive();
                /*0x3c0ed4c*/ bool IsStreaksActive();
                /*0x3c0ed7c*/ bool IsTileCompatible();
            }

            class ScreenSpaceLensFlareResolutionParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution>
            {
                /*0x3c0ecac*/ ScreenSpaceLensFlareResolutionParameter(UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution value, bool overrideState);
            }

            class ShadowsMidtonesHighlights : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter shadows;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter midtones;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter highlights;
                /*0x50*/ UnityEngine.Rendering.MinFloatParameter shadowsStart;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter shadowsEnd;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter highlightsStart;
                /*0x68*/ UnityEngine.Rendering.MinFloatParameter highlightsEnd;

                /*0x3c0ee34*/ ShadowsMidtonesHighlights();
                /*0x3c0ed84*/ bool IsActive();
                /*0x3c0ee2c*/ bool IsTileCompatible();
            }

            class SplitToning : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter shadows;
                /*0x40*/ UnityEngine.Rendering.ColorParameter highlights;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter balance;

                /*0x3c0f09c*/ SplitToning();
                /*0x3c0f008*/ bool IsActive();
                /*0x3c0f094*/ bool IsTileCompatible();
            }

            enum TonemappingMode
            {
                None = 0,
                Neutral = 1,
                ACES = 2,
            }

            enum NeutralRangeReductionMode
            {
                Reinhard = 1,
                BT2390 = 2,
            }

            enum HDRACESPreset
            {
                ACES1000Nits = 3,
                ACES2000Nits = 4,
                ACES4000Nits = 5,
            }

            class Tonemapping : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.TonemappingModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.Universal.NeutralRangeReductionModeParameter neutralHDRRangeReductionMode;
                /*0x48*/ UnityEngine.Rendering.Universal.HDRACESPresetParameter acesPreset;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShiftAmount;
                /*0x58*/ UnityEngine.Rendering.BoolParameter detectPaperWhite;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter paperWhite;
                /*0x68*/ UnityEngine.Rendering.BoolParameter detectBrightnessLimits;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter minNits;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter maxNits;

                /*0x3c0f1fc*/ Tonemapping();
                /*0x3c0f1c4*/ bool IsActive();
                /*0x3c0f1f4*/ bool IsTileCompatible();
            }

            class TonemappingModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.TonemappingMode>
            {
                /*0x3c0f45c*/ TonemappingModeParameter(UnityEngine.Rendering.Universal.TonemappingMode value, bool overrideState);
            }

            class NeutralRangeReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.NeutralRangeReductionMode>
            {
                /*0x3c0f4cc*/ NeutralRangeReductionModeParameter(UnityEngine.Rendering.Universal.NeutralRangeReductionMode value, bool overrideState);
            }

            class HDRACESPresetParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.HDRACESPreset>
            {
                /*0x3c0f53c*/ HDRACESPresetParameter(UnityEngine.Rendering.Universal.HDRACESPreset value, bool overrideState);
            }

            class Vignette : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter color;
                /*0x40*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter smoothness;
                /*0x58*/ UnityEngine.Rendering.BoolParameter rounded;

                /*0x3c0f5e4*/ Vignette();
                /*0x3c0f5ac*/ bool IsActive();
                /*0x3c0f5dc*/ bool IsTileCompatible();
            }

            class WhiteBalance : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter temperature;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter tint;

                /*0x3c0f7ec*/ WhiteBalance();
                /*0x3c0f788*/ bool IsActive();
                /*0x3c0f7e4*/ bool IsTileCompatible();
            }

            struct AdditionalLightsShadowAtlasLayout
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.RectInt> s_UnusedAtlasSquareAreas;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest> s_ShadowResolutionRequests;
                static /*0x10*/ float[] s_VisibleLightIndexToCameraSquareDistance;
                static /*0x18*/ System.Func<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, int> s_CompareShadowResolutionRequest;
                static /*0x20*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest[] s_SortedShadowResolutionRequests;
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest> m_SortedShadowResolutionRequests;
                /*0x20*/ Unity.Collections.NativeArray<int> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;
                /*0x30*/ int m_TotalShadowSlicesCount;
                /*0x34*/ int m_TotalShadowResolutionRequestCount;
                /*0x38*/ bool m_TooManyShadowMaps;
                /*0x3c*/ int m_ShadowSlicesScaleFactor;
                /*0x40*/ int m_AtlasSize;

                static /*0x3c10970*/ void ClearStaticCaches();
                static /*0x3c1086c*/ int EstimateScaleFactorNeededToFitAllShadowsInAtlas(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasSize);
                static /*0x3c1076c*/ System.Func<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, int> CreateCompareShadowResolutionRequesPredicate();
                /*0x3c0f8b4*/ AdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c108e4*/ int GetTotalShadowSlicesCount();
                /*0x3c108ec*/ int GetTotalShadowResolutionRequestCount();
                /*0x3c108f4*/ bool HasTooManyShadowMaps();
                /*0x3c108fc*/ int GetShadowSlicesScaleFactor();
                /*0x3c10904*/ int GetAtlasSize();
                /*0x3c1090c*/ bool HasSpaceForLight(int originalVisibleLightIndex);
                /*0x3c10920*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex);
                /*0x3c10944*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex);

                struct ShadowResolutionRequest
                {
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort perLightShadowSliceIndex;
                    /*0x14*/ ushort requestedResolution;
                    /*0x16*/ ushort offsetX;
                    /*0x18*/ ushort offsetY;
                    /*0x1a*/ ushort allocatedResolution;
                    /*0x1c*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest.SettingsOptions m_ShadowProperties;

                    /*0x3c108cc*/ bool get_softShadow();
                    /*0x3c1083c*/ void set_softShadow(bool value);
                    /*0x3c108d8*/ bool get_pointLightShadow();
                    /*0x3c1084c*/ void set_pointLightShadow(bool value);

                    enum SettingsOptions
                    {
                        None = 0,
                        SoftShadow = 1,
                        PointLightShadow = 2,
                        All = 65535,
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, int> <>9__24_0;

                    static /*0x3c10a14*/ <>c();
                    /*0x3c10a7c*/ <>c();
                    /*0x3c10a84*/ int <CreateCompareShadowResolutionRequesPredicate>b__24_0(UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest curr, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest other);
                }
            }

            class CapturePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.RTHandle m_CameraColorHandle;

                /*0x3c10c14*/ CapturePass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x3c10cd0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c10fc0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                    /*0x20*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;

                    /*0x3c11430*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.CapturePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.CapturePass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__4_0;

                    static /*0x3c11438*/ <>c();
                    /*0x3c114a0*/ <>c();
                    /*0x3c114a8*/ void <RecordRenderGraph>b__4_0(UnityEngine.Rendering.Universal.CapturePass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext unsafeContext);
                }
            }

            class DrawScreenSpaceUIPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ int s_CameraDepthTextureID;
                static /*0x4*/ int s_CameraOpaqueTextureID;
                /*0xb8*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData m_PassData;
                /*0xc0*/ UnityEngine.Rendering.RTHandle m_ColorTarget;
                /*0xc8*/ UnityEngine.Rendering.RTHandle m_DepthTarget;
                /*0xd0*/ bool m_RenderOffscreen;

                static /*0x3c13444*/ DrawScreenSpaceUIPass();
                static /*0x3c117f4*/ void ConfigureColorDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x3c11828*/ void ConfigureDepthDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x3c11868*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x3c118a0*/ void ExecutePass(UnityEngine.Rendering.UnsafeCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x3c116f8*/ DrawScreenSpaceUIPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool renderOffscreen);
                /*0x3c118d8*/ void Dispose();
                /*0x3c1190c*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x3c11ab0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c11cd8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c11f08*/ void RenderOffscreen(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle output);
                /*0x3c12b18*/ void RenderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x3c117ec*/ PassData();
                }

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;

                    /*0x3c134e4*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__18_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__18_1;

                    static /*0x3c134ec*/ <>c();
                    /*0x3c13554*/ <>c();
                    /*0x3c1355c*/ void <RenderOffscreen>b__17_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c135f8*/ void <RenderOffscreen>b__17_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c13714*/ void <RenderOverlay>b__18_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c137b0*/ void <RenderOverlay>b__18_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                }
            }

            class DrawSkyboxPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x3c13b7c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Rendering.RendererList rendererList);
                /*0x3c138cc*/ DrawSkyboxPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x3c13970*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c13aec*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c13bb4*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyBoxRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c13be0*/ void InitPassData(ref UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData passData, ref UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x3c13c2c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Material skyboxMaterial);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle skyRendererListHandle;
                    /*0x28*/ UnityEngine.Material material;

                    /*0x3c142ec*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawSkyboxPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                    static /*0x3c142f4*/ <>c();
                    /*0x3c1435c*/ <>c();
                    /*0x3c14364*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class HDRDebugViewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy m_PassDataCIExy;
                /*0xc0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView m_PassDataDebugView;
                /*0xc8*/ UnityEngine.Rendering.RTHandle m_CIExyTarget;
                /*0xd0*/ UnityEngine.Rendering.RTHandle m_PassthroughRT;
                /*0xd8*/ UnityEngine.Material m_material;

                static /*0x3c1453c*/ void ConfigureDescriptorForCIEPrepass(ref UnityEngine.RenderTextureDescriptor descriptor);
                static /*0x3c14604*/ UnityEngine.Vector4 GetLuminanceParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c14764*/ void ExecuteCIExyPrepass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                static /*0x3c149d0*/ void ExecuteHDRDebugViewFinalPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle xyTarget);
                /*0x3c143bc*/ HDRDebugViewPass(UnityEngine.Material mat);
                /*0x3c14d28*/ void Dispose();
                /*0x3c14d5c*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.HDRDebugMode hdrdebugMode);
                /*0x3c14ee8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c150c4*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy dataCIExy, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView dataDebugView, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                /*0x3c15368*/ void RenderHDRDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor, UnityEngine.Rendering.Universal.HDRDebugMode hdrDebugMode);

                enum HDRDebugPassId
                {
                    CIExyPrepass = 0,
                    DebugViewPass = 1,
                }

                class PassDataCIExy
                {
                    /*0x10*/ UnityEngine.Material material;
                    /*0x18*/ UnityEngine.Vector4 luminanceParameters;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle xyBuffer;
                    /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle passThrough;

                    /*0x3c1452c*/ PassDataCIExy();
                }

                class PassDataDebugView
                {
                    /*0x10*/ UnityEngine.Material material;
                    /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode hdrDebugMode;
                    /*0x20*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x28*/ UnityEngine.Vector4 luminanceParameters;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture;
                    /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle xyBuffer;
                    /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor;
                    /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor;

                    /*0x3c14534*/ PassDataDebugView();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _DebugHDRModeId;
                    static /*0x4*/ int _HDRDebugParamsId;
                    static /*0x8*/ int _xyTextureId;
                    static /*0xc*/ int _SizeOfHDRXYMapping;
                    static /*0x10*/ int _CIExyUAVIndex;

                    static /*0x3c15fe4*/ ShaderConstants();
                    /*0x3c15fdc*/ ShaderConstants();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x3c160c0*/ <>c();
                    /*0x3c16128*/ <>c();
                    /*0x3c16130*/ void <RenderHDRDebug>b__17_0(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c16218*/ void <RenderHDRDebug>b__17_1(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class InvokeOnRenderObjectCallbackPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x3c162e0*/ InvokeOnRenderObjectCallbackPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x3c163a0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c163c8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget;

                    /*0x3c16824*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__3_0;

                    static /*0x3c1682c*/ <>c();
                    /*0x3c16894*/ <>c();
                    /*0x3c1689c*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                }
            }

            class MotionVectorRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string k_MotionVectorTextureName = "_MotionVectorTexture";
                static string k_MotionVectorDepthTextureName = "_MotionVectorDepthTexture";
                static UnityEngine.Experimental.Rendering.GraphicsFormat k_TargetFormat = 46;
                static string k_MotionVectorsLightModeTag = "MotionVectors";
                static /*0x0*/ string[] s_ShaderTags;
                static /*0x8*/ int s_CameraDepthTextureID;
                static /*0x10*/ UnityEngine.Rendering.ProfilingSampler s_SetMotionMatrixProfilingSampler;
                /*0xb8*/ UnityEngine.Rendering.RTHandle m_Color;
                /*0xc0*/ UnityEngine.Rendering.RTHandle m_Depth;
                /*0xc8*/ UnityEngine.Material m_CameraMaterial;
                /*0xd0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf0*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData m_PassData;

                static /*0x3c18550*/ MotionVectorRenderPass();
                static /*0x3c16c2c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x3c172fc*/ UnityEngine.Rendering.DrawingSettings GetDrawingSettings(UnityEngine.Camera camera, bool supportsDynamicBatching);
                static /*0x3c16d44*/ void DrawCameraMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Material cameraMaterial);
                static /*0x3c16dd4*/ void DrawObjectMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RendererList rendererList);
                static /*0x3c18000*/ void SetMotionVectorGlobalMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c18104*/ void SetRenderGraphMotionVectorGlobalMatrices(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c16984*/ MotionVectorRenderPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material cameraMaterial, UnityEngine.LayerMask opaqueLayerMask);
                /*0x3c16b30*/ void Setup(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x3c16b60*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x3c16e0c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c1706c*/ void InitPassData(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c170cc*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, ref UnityEngine.Rendering.CullingResults cullResults, bool supportsDynamicBatching, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x3c17560*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorDepth);

                class PassData
                {
                    /*0x10*/ UnityEngine.Camera camera;
                    /*0x18*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorColor;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorDepth;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepth;
                    /*0x50*/ UnityEngine.Material cameraMaterial;
                    /*0x58*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                    /*0x68*/ UnityEngine.Rendering.RendererList rendererList;

                    /*0x3c1868c*/ PassData();
                }

                class MotionMatrixPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData motionData;
                    /*0x18*/ UnityEngine.Experimental.Rendering.XRPass xr;

                    /*0x3c18694*/ MotionMatrixPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__26_0;

                    static /*0x3c1869c*/ <>c();
                    /*0x3c18704*/ <>c();
                    /*0x3c1870c*/ void <Render>b__23_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c18868*/ void <SetRenderGraphMotionVectorGlobalMatrices>b__26_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class PostProcessPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string k_RenderPostProcessingTag = "Blit PostProcessing Effects";
                static string k_RenderFinalPostProcessingTag = "Blit Final PostProcessing";
                static int k_GaussianDoFPassComputeCoc = 0;
                static int k_GaussianDoFPassDownscalePrefilter = 1;
                static int k_GaussianDoFPassBlurH = 2;
                static int k_GaussianDoFPassBlurV = 3;
                static int k_GaussianDoFPassComposite = 4;
                static int k_BokehDoFPassComputeCoc = 0;
                static int k_BokehDoFPassDownscalePrefilter = 1;
                static int k_BokehDoFPassBlur = 2;
                static int k_BokehDoFPassPostFilter = 3;
                static int k_BokehDoFPassComposite = 4;
                static int k_MaxPyramidSize = 16;
                static string _TemporalAATargetName = "_TemporalAATarget";
                static string _UpscaledColorTargetName = "_CameraColorUpscaledSTP";
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderPostProcessing;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderFinalPostProcessing;
                static /*0x10*/ int k_ShaderPropertyId_ViewProjM;
                static /*0x14*/ int k_ShaderPropertyId_PrevViewProjM;
                static /*0x18*/ int k_ShaderPropertyId_ViewProjMStereo;
                static /*0x1c*/ int k_ShaderPropertyId_PrevViewProjMStereo;
                static /*0x20*/ int s_CameraDepthTextureID;
                /*0xb8*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0xf0*/ UnityEngine.Rendering.RTHandle m_Source;
                /*0xf8*/ UnityEngine.Rendering.RTHandle m_Destination;
                /*0x100*/ UnityEngine.Rendering.RTHandle m_Depth;
                /*0x108*/ UnityEngine.Rendering.RTHandle m_InternalLut;
                /*0x110*/ UnityEngine.Rendering.RTHandle m_MotionVectors;
                /*0x118*/ UnityEngine.Rendering.RTHandle m_FullCoCTexture;
                /*0x120*/ UnityEngine.Rendering.RTHandle m_HalfCoCTexture;
                /*0x128*/ UnityEngine.Rendering.RTHandle m_PingTexture;
                /*0x130*/ UnityEngine.Rendering.RTHandle m_PongTexture;
                /*0x138*/ UnityEngine.Rendering.RTHandle[] m_BloomMipDown;
                /*0x140*/ UnityEngine.Rendering.RTHandle[] m_BloomMipUp;
                /*0x148*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _BloomMipUp;
                /*0x150*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _BloomMipDown;
                /*0x158*/ UnityEngine.Rendering.RTHandle m_BlendTexture;
                /*0x160*/ UnityEngine.Rendering.RTHandle m_EdgeColorTexture;
                /*0x168*/ UnityEngine.Rendering.RTHandle m_EdgeStencilTexture;
                /*0x170*/ UnityEngine.Rendering.RTHandle m_TempTarget;
                /*0x178*/ UnityEngine.Rendering.RTHandle m_TempTarget2;
                /*0x180*/ UnityEngine.Rendering.RTHandle m_StreakTmpTexture;
                /*0x188*/ UnityEngine.Rendering.RTHandle m_StreakTmpTexture2;
                /*0x190*/ UnityEngine.Rendering.RTHandle m_ScreenSpaceLensFlareResult;
                /*0x198*/ UnityEngine.Rendering.RTHandle m_UserLut;
                /*0x1a0*/ UnityEngine.Rendering.Universal.PostProcessPass.MaterialLibrary m_Materials;
                /*0x1a8*/ UnityEngine.Rendering.Universal.PostProcessData m_Data;
                /*0x1b0*/ UnityEngine.Rendering.Universal.DepthOfField m_DepthOfField;
                /*0x1b8*/ UnityEngine.Rendering.Universal.MotionBlur m_MotionBlur;
                /*0x1c0*/ UnityEngine.Rendering.Universal.ScreenSpaceLensFlare m_LensFlareScreenSpace;
                /*0x1c8*/ UnityEngine.Rendering.Universal.PaniniProjection m_PaniniProjection;
                /*0x1d0*/ UnityEngine.Rendering.Universal.Bloom m_Bloom;
                /*0x1d8*/ UnityEngine.Rendering.Universal.LensDistortion m_LensDistortion;
                /*0x1e0*/ UnityEngine.Rendering.Universal.ChromaticAberration m_ChromaticAberration;
                /*0x1e8*/ UnityEngine.Rendering.Universal.Vignette m_Vignette;
                /*0x1f0*/ UnityEngine.Rendering.Universal.ColorLookup m_ColorLookup;
                /*0x1f8*/ UnityEngine.Rendering.Universal.ColorAdjustments m_ColorAdjustments;
                /*0x200*/ UnityEngine.Rendering.Universal.Tonemapping m_Tonemapping;
                /*0x208*/ UnityEngine.Rendering.Universal.FilmGrain m_FilmGrain;
                /*0x210*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_DefaultColorFormat;
                /*0x214*/ bool m_DefaultColorFormatIsAlpha;
                /*0x218*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_SMAAEdgeFormat;
                /*0x21c*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_GaussianCoCFormat;
                /*0x220*/ int m_DitheringTextureIndex;
                /*0x228*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT2;
                /*0x230*/ UnityEngine.Vector4[] m_BokehKernel;
                /*0x238*/ int m_BokehHash;
                /*0x23c*/ float m_BokehMaxRadius;
                /*0x240*/ float m_BokehRCPAspect;
                /*0x244*/ bool m_IsFinalPass;
                /*0x245*/ bool m_HasFinalPass;
                /*0x246*/ bool m_EnableColorEncodingIfNeeded;
                /*0x247*/ bool m_UseFastSRGBLinearConversion;
                /*0x248*/ bool m_SupportScreenSpaceLensFlare;
                /*0x249*/ bool m_SupportDataDrivenLensFlare;
                /*0x24a*/ bool m_ResolveToScreen;
                /*0x24b*/ bool m_UseSwapBuffer;
                /*0x250*/ UnityEngine.Rendering.RTHandle m_ScalingSetupTarget;
                /*0x258*/ UnityEngine.Rendering.RTHandle m_UpscaledTarget;
                /*0x260*/ UnityEngine.Material m_BlitMaterial;
                /*0x268*/ UnityEngine.Rendering.Universal.PostProcessPass.BloomMaterialParams m_BloomParamsPrev;

                static /*0x3c2b728*/ PostProcessPass();
                static /*0x3c1c09c*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(UnityEngine.RenderTextureDescriptor desc, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                static /*0x3c201bc*/ float GetMaxBokehRadiusInPixels(float viewportHeight);
                static /*0x3c201d8*/ float GetLensFlareLightAttenuation(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                static /*0x3c20430*/ void UpdateMotionBlurMatrices(ref UnityEngine.Material material, UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x3c2807c*/ void ScaleViewportAndBlit(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTextureHdl, UnityEngine.Rendering.RTHandle dest, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material, bool hasFinalPass);
                /*0x3c18890*/ PostProcessPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x3c19300*/ void Cleanup();
                /*0x3c19490*/ void Dispose();
                /*0x3c19644*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.RTHandle source, bool resolveToScreen, ref UnityEngine.Rendering.RTHandle depth, ref UnityEngine.Rendering.RTHandle internalLut, ref UnityEngine.Rendering.RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding);
                /*0x3c1978c*/ void SetupFinalPass(ref UnityEngine.Rendering.RTHandle source, bool useSwapBuffer, bool enableColorEncoding);
                /*0x3c19838*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c19844*/ bool CanRunOnTile();
                /*0x3c1984c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c19218*/ bool IsHDRFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x3c192a8*/ bool IsAlphaFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x3c1bf38*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor();
                /*0x3c1bfac*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x3c1c0ec*/ bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion);
                /*0x3c1c108*/ bool RequireHDROutput(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c1a6a8*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c1c3a4*/ void DoSubpixelMorphologicalAntialiasing(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x3c1c950*/ void DoDepthOfField(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x3c1f20c*/ void DoGaussianDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x3c1ff58*/ void PrepareBokehKernel(float maxRadius, float rcpAspect);
                /*0x3c1f944*/ void DoBokehDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x3c1e080*/ void LensFlareDataDrivenComputeOcclusion(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x3c1e2d4*/ void LensFlareDataDriven(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x3c1da50*/ void DoLensFlareScreenSpace(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RTHandle originalBloomTexture, UnityEngine.Rendering.RTHandle screenSpaceLensFlareBloomMipTexture);
                /*0x3c1ca4c*/ void DoMotionBlur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle motionVectors, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3c1ccd8*/ void DoPaniniProjection(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x3c20560*/ UnityEngine.Vector2 CalcViewExtents(UnityEngine.Camera camera);
                /*0x3c205bc*/ UnityEngine.Vector2 CalcCropExtents(UnityEngine.Camera camera, float d);
                /*0x3c1cf18*/ void SetupBloom(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Material uberMaterial, bool enableAlphaOutput);
                /*0x3c1e664*/ void SetupLensDistortion(UnityEngine.Material material, bool isSceneView);
                /*0x3c1e960*/ void SetupChromaticAberration(UnityEngine.Material material);
                /*0x3c1ea54*/ void SetupVignette(UnityEngine.Material material, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x3c1ec0c*/ void SetupColorGrading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material material);
                /*0x3c1ef68*/ void SetupGrain(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x3c1f018*/ void SetupDithering(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x3c1f0b4*/ void SetupHDROutput(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperations, bool rendersOverlayUI);
                /*0x3c19cd4*/ void RenderFinalPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c20610*/ void UpdateCameraResolution(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int newCameraTargetSize);
                /*0x3c209f8*/ void RenderStopNaN(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget);
                /*0x3c20f8c*/ void RenderSMAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle SMAATarget);
                /*0x3c22538*/ void UberPostSetupBloomPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph rendergraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle bloomTexture, UnityEngine.Material uberMaterial);
                /*0x3c22cb4*/ void RenderBloomTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x3c23c3c*/ void RenderDoF(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c23ef8*/ void RenderDoFGaussian(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x3c24a58*/ void RenderDoFBokeh(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x3c25584*/ void RenderPaniniProjection(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c25cdc*/ void RenderTemporalAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c25ee8*/ void RenderSTP(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c26194*/ void RenderMotionBlur(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c26a84*/ void LensFlareDataDrivenComputeOcclusion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c27068*/ void RenderLensFlareDataDriven(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x3c276d4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle RenderLensFlareScreenSpace(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle originalBloomTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle screenSpaceLensFlareBloomMipTexture, bool enableXR, bool sameInputOutputTex);
                /*0x3c28268*/ void RenderFinalSetup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x3c288e0*/ void RenderFinalFSRScale(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x3c28df0*/ void RenderFinalBlit(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x3c293b8*/ void RenderFinalPassRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded);
                /*0x3c29a14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle TryGetCachedUserLutTextureHandle(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3c29c18*/ void RenderUberPost(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool resolveToDebugScreen, bool hasFinalPass);
                /*0x3c2a78c*/ void RenderPostProcessingRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColorTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded);
                /*0x3c1c144*/ UnityEngine.Rendering.RTHandle <Render>g__GetSource|89_0(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x3c1c14c*/ UnityEngine.Rendering.RTHandle <Render>g__GetDestination|89_1(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x3c1c270*/ void <Render>g__Swap|89_2(ref UnityEngine.Rendering.Universal.ScriptableRenderer r, ref UnityEngine.Rendering.Universal.PostProcessPass.<> );

                class MaterialLibrary
                {
                    /*0x10*/ UnityEngine.Material stopNaN;
                    /*0x18*/ UnityEngine.Material subpixelMorphologicalAntialiasing;
                    /*0x20*/ UnityEngine.Material gaussianDepthOfField;
                    /*0x28*/ UnityEngine.Material gaussianDepthOfFieldCoC;
                    /*0x30*/ UnityEngine.Material bokehDepthOfField;
                    /*0x38*/ UnityEngine.Material bokehDepthOfFieldCoC;
                    /*0x40*/ UnityEngine.Material cameraMotionBlur;
                    /*0x48*/ UnityEngine.Material paniniProjection;
                    /*0x50*/ UnityEngine.Material bloom;
                    /*0x58*/ UnityEngine.Material[] bloomUpsample;
                    /*0x60*/ UnityEngine.Material temporalAntialiasing;
                    /*0x68*/ UnityEngine.Material scalingSetup;
                    /*0x70*/ UnityEngine.Material easu;
                    /*0x78*/ UnityEngine.Material uber;
                    /*0x80*/ UnityEngine.Material finalPass;
                    /*0x88*/ UnityEngine.Material lensFlareDataDriven;
                    /*0x90*/ UnityEngine.Material lensFlareScreenSpace;

                    /*0x3c18f1c*/ MaterialLibrary(UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x3c2b90c*/ UnityEngine.Material Load(UnityEngine.Shader shader);
                    /*0x3c19324*/ void Cleanup();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _TempTarget;
                    static /*0x4*/ int _TempTarget2;
                    static /*0x8*/ int _StencilRef;
                    static /*0xc*/ int _StencilMask;
                    static /*0x10*/ int _FullCoCTexture;
                    static /*0x14*/ int _HalfCoCTexture;
                    static /*0x18*/ int _DofTexture;
                    static /*0x1c*/ int _CoCParams;
                    static /*0x20*/ int _BokehKernel;
                    static /*0x24*/ int _BokehConstants;
                    static /*0x28*/ int _PongTexture;
                    static /*0x2c*/ int _PingTexture;
                    static /*0x30*/ int _Metrics;
                    static /*0x34*/ int _AreaTexture;
                    static /*0x38*/ int _SearchTexture;
                    static /*0x3c*/ int _EdgeTexture;
                    static /*0x40*/ int _BlendTexture;
                    static /*0x44*/ int _ColorTexture;
                    static /*0x48*/ int _Params;
                    static /*0x4c*/ int _SourceTexLowMip;
                    static /*0x50*/ int _Bloom_Params;
                    static /*0x54*/ int _Bloom_Texture;
                    static /*0x58*/ int _LensDirt_Texture;
                    static /*0x5c*/ int _LensDirt_Params;
                    static /*0x60*/ int _LensDirt_Intensity;
                    static /*0x64*/ int _Distortion_Params1;
                    static /*0x68*/ int _Distortion_Params2;
                    static /*0x6c*/ int _Chroma_Params;
                    static /*0x70*/ int _Vignette_Params1;
                    static /*0x74*/ int _Vignette_Params2;
                    static /*0x78*/ int _Vignette_ParamsXR;
                    static /*0x7c*/ int _Lut_Params;
                    static /*0x80*/ int _UserLut_Params;
                    static /*0x84*/ int _InternalLut;
                    static /*0x88*/ int _UserLut;
                    static /*0x8c*/ int _DownSampleScaleFactor;
                    static /*0x90*/ int _FlareOcclusionRemapTex;
                    static /*0x94*/ int _FlareOcclusionTex;
                    static /*0x98*/ int _FlareOcclusionIndex;
                    static /*0x9c*/ int _FlareTex;
                    static /*0xa0*/ int _FlareColorValue;
                    static /*0xa4*/ int _FlareData0;
                    static /*0xa8*/ int _FlareData1;
                    static /*0xac*/ int _FlareData2;
                    static /*0xb0*/ int _FlareData3;
                    static /*0xb4*/ int _FlareData4;
                    static /*0xb8*/ int _FlareData5;
                    static /*0xbc*/ int _FullscreenProjMat;
                    static /*0xc0*/ int[] _BloomMipUp;
                    static /*0xc8*/ int[] _BloomMipDown;

                    static /*0x3c2ba80*/ ShaderConstants();
                }

                class UpdateCameraResolutionPassData
                {
                    /*0x10*/ UnityEngine.Vector2Int newCameraTargetSize;

                    /*0x3c2c3d8*/ UpdateCameraResolutionPassData();
                }

                class StopNaNsPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material stopNaN;

                    /*0x3c2c3e0*/ StopNaNsPassData();
                }

                class SMAASetupPassData
                {
                    /*0x10*/ UnityEngine.Vector4 metrics;
                    /*0x20*/ UnityEngine.Texture2D areaTexture;
                    /*0x28*/ UnityEngine.Texture2D searchTexture;
                    /*0x30*/ float stencilRef;
                    /*0x34*/ float stencilMask;
                    /*0x38*/ UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality;
                    /*0x40*/ UnityEngine.Material material;

                    /*0x3c2c3e8*/ SMAASetupPassData();
                }

                class SMAAPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthStencilTexture;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle blendTexture;
                    /*0x50*/ UnityEngine.Material material;

                    /*0x3c2c3f0*/ SMAAPassData();
                }

                class UberSetupBloomPassData
                {
                    /*0x10*/ UnityEngine.Vector4 bloomParams;
                    /*0x20*/ UnityEngine.Vector4 dirtScaleOffset;
                    /*0x30*/ float dirtIntensity;
                    /*0x38*/ UnityEngine.Texture dirtTexture;
                    /*0x40*/ bool highQualityFilteringValue;
                    /*0x44*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle bloomTexture;
                    /*0x58*/ UnityEngine.Material uberMaterial;

                    /*0x3c2c3f8*/ UberSetupBloomPassData();
                }

                class BloomPassData
                {
                    /*0x10*/ int mipCount;
                    /*0x18*/ UnityEngine.Material material;
                    /*0x20*/ UnityEngine.Material[] upsampleMaterials;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipUp;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipDown;

                    /*0x3c2c400*/ BloomPassData();
                }

                struct BloomMaterialParams
                {
                    /*0x10*/ UnityEngine.Vector4 parameters;
                    /*0x20*/ bool highQualityFiltering;
                    /*0x21*/ bool enableAlphaOutput;

                    /*0x3c23bd4*/ bool Equals(ref UnityEngine.Rendering.Universal.PostProcessPass.BloomMaterialParams other);
                }

                class DoFGaussianPassData
                {
                    /*0x10*/ int downsample;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x40*/ UnityEngine.Vector3 cocParams;
                    /*0x4c*/ bool highQualitySamplingValue;
                    /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture;
                    /*0x70*/ UnityEngine.Material material;
                    /*0x78*/ UnityEngine.Material materialCoC;
                    /*0x80*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle halfCoCTexture;
                    /*0x90*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle fullCoCTexture;
                    /*0xa0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle pingTexture;
                    /*0xb0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle pongTexture;
                    /*0xc0*/ UnityEngine.Rendering.RenderTargetIdentifier[] multipleRenderTargets;
                    /*0xc8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;

                    /*0x3c2c408*/ DoFGaussianPassData();
                }

                class DoFBokehPassData
                {
                    /*0x10*/ UnityEngine.Vector4[] bokehKernel;
                    /*0x18*/ int downSample;
                    /*0x1c*/ float uvMargin;
                    /*0x20*/ UnityEngine.Vector4 cocParams;
                    /*0x30*/ bool useFastSRGBLinearConversion;
                    /*0x34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x44*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture;
                    /*0x58*/ UnityEngine.Material material;
                    /*0x60*/ UnityEngine.Material materialCoC;
                    /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle halfCoCTexture;
                    /*0x78*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle fullCoCTexture;
                    /*0x88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle pingTexture;
                    /*0x98*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle pongTexture;
                    /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;

                    /*0x3c2c46c*/ DoFBokehPassData();
                }

                class PaniniProjectionPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.RenderTextureDescriptor sourceTextureDesc;
                    /*0x68*/ UnityEngine.Material material;
                    /*0x70*/ UnityEngine.Vector4 paniniParams;
                    /*0x80*/ bool isPaniniGeneric;

                    /*0x3c2c474*/ PaniniProjectionPassData();
                }

                class MotionBlurPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectors;
                    /*0x40*/ UnityEngine.Material material;
                    /*0x48*/ int passIndex;
                    /*0x50*/ UnityEngine.Camera camera;
                    /*0x58*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x60*/ float intensity;
                    /*0x64*/ float clamp;
                    /*0x68*/ bool enableAlphaOutput;

                    /*0x3c2c47c*/ MotionBlurPassData();
                }

                class LensFlarePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.RenderTextureDescriptor sourceDescriptor;
                    /*0x58*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x60*/ UnityEngine.Material material;
                    /*0x68*/ UnityEngine.Rect viewport;
                    /*0x78*/ float paniniDistance;
                    /*0x7c*/ float paniniCropToFit;
                    /*0x80*/ float width;
                    /*0x84*/ float height;
                    /*0x88*/ bool usePanini;

                    /*0x3c2c484*/ LensFlarePassData();
                }

                class LensFlareScreenSpacePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle streakTmpTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle streakTmpTexture2;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle originalBloomTexture;
                    /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle screenSpaceLensFlareBloomMipTexture;
                    /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle result;
                    /*0x70*/ UnityEngine.RenderTextureDescriptor sourceDescriptor;
                    /*0xa8*/ UnityEngine.Camera camera;
                    /*0xb0*/ UnityEngine.Material material;
                    /*0xb8*/ UnityEngine.Rendering.Universal.ScreenSpaceLensFlare lensFlareScreenSpace;
                    /*0xc0*/ int downsample;

                    /*0x3c2c48c*/ LensFlareScreenSpacePassData();
                }

                class PostProcessingFinalSetupPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x3c2c494*/ PostProcessingFinalSetupPassData();
                }

                class PostProcessingFinalFSRScalePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ bool enableAlphaOutput;

                    /*0x3c2c49c*/ PostProcessingFinalFSRScalePassData();
                }

                class PostProcessingFinalBlitPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings;

                    /*0x3c2c4a4*/ PostProcessingFinalBlitPassData();
                }

                struct FinalBlitSettings
                {
                    /*0x10*/ bool isFxaaEnabled;
                    /*0x11*/ bool isFsrEnabled;
                    /*0x12*/ bool isTaaSharpeningEnabled;
                    /*0x13*/ bool requireHDROutput;
                    /*0x14*/ bool resolveToDebugScreen;
                    /*0x15*/ bool isAlphaOutputEnabled;
                    /*0x18*/ UnityEngine.Rendering.HDROutputUtils.Operation hdrOperations;

                    static /*0x3c29a08*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings Create();
                }

                class UberPostPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture;
                    /*0x40*/ UnityEngine.Vector4 lutParams;
                    /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle userLutTexture;
                    /*0x60*/ UnityEngine.Vector4 userLutParams;
                    /*0x70*/ UnityEngine.Material material;
                    /*0x78*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x80*/ UnityEngine.Rendering.Universal.TonemappingMode toneMappingMode;
                    /*0x84*/ bool isHdrGrading;
                    /*0x85*/ bool isBackbuffer;
                    /*0x86*/ bool enableAlphaOutput;
                    /*0x87*/ bool hasFinalPass;

                    /*0x3c2c4ac*/ UberPostPassData();
                }

                class PostFXSetupPassData
                {
                    /*0x3c2c4b4*/ PostFXSetupPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.PostProcessPass.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__98_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UpdateCameraResolutionPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__122_0;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.StopNaNsPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__124_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAASetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_0;
                    static /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_1;
                    static /*0x30*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_2;
                    static /*0x38*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_3;
                    static /*0x40*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UberSetupBloomPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__129_0;
                    static /*0x48*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.BloomPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__132_0;
                    static /*0x50*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.DoFGaussianPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__135_0;
                    static /*0x58*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.DoFBokehPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__137_0;
                    static /*0x60*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PaniniProjectionPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__139_0;
                    static /*0x68*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.MotionBlurPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__145_0;
                    static /*0x70*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__147_0;
                    static /*0x78*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__148_1;
                    static /*0x80*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__148_0;
                    static /*0x88*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlareScreenSpacePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__150_0;
                    static /*0x90*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__153_0;
                    static /*0x98*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalFSRScalePassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__155_0;
                    static /*0xa0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalBlitPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__158_0;
                    static /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UberPostPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__162_0;
                    static /*0xb0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostFXSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__164_0;

                    static /*0x3c2c4bc*/ <>c();
                    /*0x3c2c524*/ <>c();
                    /*0x3c2c52c*/ float <LensFlareDataDriven>b__98_0(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x3c2c5b8*/ void <UpdateCameraResolution>b__122_0(UnityEngine.Rendering.Universal.PostProcessPass.UpdateCameraResolutionPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x3c2c64c*/ void <RenderStopNaN>b__124_0(UnityEngine.Rendering.Universal.PostProcessPass.StopNaNsPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2c794*/ void <RenderSMAA>b__127_0(UnityEngine.Rendering.Universal.PostProcessPass.SMAASetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2c930*/ void <RenderSMAA>b__127_1(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2ca78*/ void <RenderSMAA>b__127_2(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2cbc0*/ void <RenderSMAA>b__127_3(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2cd68*/ void <UberPostSetupBloomPass>b__129_0(UnityEngine.Rendering.Universal.PostProcessPass.UberSetupBloomPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2cf40*/ void <RenderBloomTexture>b__132_0(UnityEngine.Rendering.Universal.PostProcessPass.BloomPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c2d628*/ void <RenderDoFGaussian>b__135_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFGaussianPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c2e0d8*/ void <RenderDoFBokeh>b__137_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFBokehPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c2e950*/ void <RenderPaniniProjection>b__139_0(UnityEngine.Rendering.Universal.PostProcessPass.PaniniProjectionPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2eb2c*/ void <RenderMotionBlur>b__145_0(UnityEngine.Rendering.Universal.PostProcessPass.MotionBlurPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2ed84*/ void <LensFlareDataDrivenComputeOcclusion>b__147_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x3c2ef70*/ void <RenderLensFlareDataDriven>b__148_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x3c2f2e8*/ float <RenderLensFlareDataDriven>b__148_1(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x3c2f374*/ void <RenderLensFlareScreenSpace>b__150_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlareScreenSpacePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x3c2f77c*/ void <RenderFinalSetup>b__153_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2f85c*/ void <RenderFinalFSRScale>b__155_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalFSRScalePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2fa4c*/ void <RenderFinalBlit>b__158_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalBlitPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c2fddc*/ void <RenderUberPost>b__162_0(UnityEngine.Rendering.Universal.PostProcessPass.UberPostPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c30070*/ void <RenderPostProcessingRenderGraph>b__164_0(UnityEngine.Rendering.Universal.PostProcessPass.PostFXSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }

                struct <>c__DisplayClass89_0
                {
                    /*0x10*/ UnityEngine.Rendering.RTHandle source;
                    /*0x18*/ UnityEngine.Rendering.RTHandle destination;
                    /*0x20*/ UnityEngine.Rendering.Universal.PostProcessPass <>4__this;
                    /*0x28*/ int amountOfPassesRemaining;
                    /*0x30*/ UnityEngine.Rendering.CommandBuffer cmd;
                }
            }

            class ProbeVolumeDebugPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.ComputeShader m_ComputeShader;
                /*0xc0*/ UnityEngine.Rendering.RTHandle m_DepthTexture;
                /*0xc8*/ UnityEngine.Rendering.RTHandle m_NormalTexture;

                /*0x3c30154*/ ProbeVolumeDebugPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.ComputeShader computeShader);
                /*0x3c30220*/ void Setup(UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RTHandle normalBuffer);
                /*0x3c30250*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c304ec*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthPyramidBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer);

                class WriteApvData
                {
                    /*0x10*/ UnityEngine.ComputeShader computeShader;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle resultBuffer;
                    /*0x24*/ UnityEngine.Vector2 clickCoordinates;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;
                    /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer;

                    /*0x3c30ad4*/ WriteApvData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__7_0;

                    static /*0x3c30adc*/ <>c();
                    /*0x3c30b44*/ <>c();
                    /*0x3c30b4c*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                }
            }

            class RenderObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.RenderQueueType renderQueueType;
                /*0xbc*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xe0*/ UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings m_CameraSettings;
                /*0xe8*/ UnityEngine.Material <overrideMaterial>k__BackingField;
                /*0xf0*/ int <overrideMaterialPassIndex>k__BackingField;
                /*0xf8*/ UnityEngine.Shader <overrideShader>k__BackingField;
                /*0x100*/ int <overrideShaderPassIndex>k__BackingField;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x110*/ UnityEngine.Rendering.Universal.RenderObjectsPass.PassData m_PassData;
                /*0x118*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;

                static /*0x3c31a94*/ void ExecutePass(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList, bool isYFlipped);
                /*0x3c30ea4*/ RenderObjectsPass(string profilerTag, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x3c312f4*/ RenderObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x3c30d00*/ UnityEngine.Material get_overrideMaterial();
                /*0x3c30d08*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x3c30d10*/ int get_overrideMaterialPassIndex();
                /*0x3c30d18*/ void set_overrideMaterialPassIndex(int value);
                /*0x3c30d20*/ UnityEngine.Shader get_overrideShader();
                /*0x3c30d28*/ void set_overrideShader(UnityEngine.Shader value);
                /*0x3c30d30*/ int get_overrideShaderPassIndex();
                /*0x3c30d38*/ void set_overrideShaderPassIndex(int value);
                /*0x3c30d40*/ void SetDetphState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x3c30d44*/ void SetDepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x3c30db4*/ void SetStencilState(int reference, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOp, UnityEngine.Rendering.StencilOp failOp, UnityEngine.Rendering.StencilOp zFailOp);
                /*0x3c30fd8*/ void Init(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x3c31434*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c316ac*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData);
                /*0x3c31700*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x3c328a0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                    /*0x38*/ UnityEngine.Rendering.Universal.DebugRendererLists debugRendererLists;
                    /*0x40*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x48*/ UnityEngine.Rendering.RendererList rendererList;

                    /*0x3c3142c*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderObjectsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__33_0;

                    static /*0x3c3360c*/ <>c();
                    /*0x3c33674*/ <>c();
                    /*0x3c3367c*/ void <RecordRenderGraph>b__33_0(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class ScreenSpaceAmbientOcclusionPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
                static string k_AmbientOcclusionParamName = "_AmbientOcclusionParam";
                static /*0x0*/ int s_AmbientOcclusionParamID;
                static /*0x4*/ int s_SSAOParamsID;
                static /*0x8*/ int s_SSAOBlueNoiseParamsID;
                static /*0xc*/ int s_BlueNoiseTextureID;
                static /*0x10*/ int s_SSAOFinalTextureID;
                static /*0x14*/ int s_CameraViewXExtentID;
                static /*0x18*/ int s_CameraViewYExtentID;
                static /*0x1c*/ int s_CameraViewZExtentID;
                static /*0x20*/ int s_ProjectionParams2ID;
                static /*0x24*/ int s_CameraViewProjectionsID;
                static /*0x28*/ int s_CameraViewTopLeftCornerID;
                static /*0x2c*/ int s_CameraDepthTextureID;
                static /*0x30*/ int s_CameraNormalsTextureID;
                static /*0x38*/ int[] m_BilateralTexturesIndices;
                static /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_BilateralPasses;
                static /*0x48*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_BilateralAfterOpaquePasses;
                static /*0x50*/ int[] m_GaussianTexturesIndices;
                static /*0x58*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_GaussianPasses;
                static /*0x60*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_GaussianAfterOpaquePasses;
                static /*0x68*/ int[] m_KawaseTexturesIndices;
                static /*0x70*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_KawasePasses;
                static /*0x78*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_KawaseAfterOpaquePasses;
                /*0xb8*/ bool m_SupportsR8RenderTextureFormat;
                /*0xbc*/ int m_BlueNoiseTextureIndex;
                /*0xc0*/ UnityEngine.Material m_Material;
                /*0xc8*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData m_PassData;
                /*0xd0*/ UnityEngine.Texture2D[] m_BlueNoiseTextures;
                /*0xd8*/ UnityEngine.Vector4[] m_CameraTopLeftCorner;
                /*0xe0*/ UnityEngine.Vector4[] m_CameraXExtent;
                /*0xe8*/ UnityEngine.Vector4[] m_CameraYExtent;
                /*0xf0*/ UnityEngine.Vector4[] m_CameraZExtent;
                /*0xf8*/ UnityEngine.Rendering.RTHandle[] m_SSAOTextures;
                /*0x100*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.BlurTypes m_BlurType;
                /*0x108*/ UnityEngine.Matrix4x4[] m_CameraViewProjections;
                /*0x110*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x118*/ UnityEngine.Rendering.Universal.ScriptableRenderer m_Renderer;
                /*0x120*/ UnityEngine.RenderTextureDescriptor m_AOPassDescriptor;
                /*0x158*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;
                /*0x160*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOMaterialParams m_SSAOParamsPrev;

                static /*0x3c36a00*/ ScreenSpaceAmbientOcclusionPass();
                static /*0x3c33c14*/ bool IsAfterOpaquePass(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x3c36590*/ void RenderAndSetBaseMap(ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material mat, ref UnityEngine.Rendering.RTHandle baseMap, ref UnityEngine.Rendering.RTHandle target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x3c363b0*/ void GetPassOrder(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.BlurTypes blurType, bool isAfterOpaque, ref int[] textureIndices, ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] shaderPasses);
                /*0x3c337cc*/ ScreenSpaceAmbientOcclusionPass();
                /*0x3c3375c*/ bool get_isRendererDeferred();
                /*0x3c33a50*/ bool Setup(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings featureSettings, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material material, ref UnityEngine.Texture2D[] blueNoiseTextures);
                /*0x3c33c30*/ void SetupKeywordsAndParameters(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c345fc*/ void InitSSAOPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data);
                /*0x3c3465c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c351fc*/ void CreateRenderTextureHandles(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle aoTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle blurTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle finalTexture);
                /*0x3c3558c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c35e5c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c36888*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c36950*/ void Dispose();

                enum BlurTypes
                {
                    Bilateral = 0,
                    Gaussian = 1,
                    Kawase = 2,
                }

                enum ShaderPasses
                {
                    AmbientOcclusion = 0,
                    BilateralBlurHorizontal = 1,
                    BilateralBlurVertical = 2,
                    BilateralBlurFinal = 3,
                    BilateralAfterOpaque = 4,
                    GaussianBlurHorizontal = 5,
                    GaussianBlurVertical = 6,
                    GaussianAfterOpaque = 7,
                    KawaseBlur = 8,
                    KawaseAfterOpaque = 9,
                }

                struct SSAOMaterialParams
                {
                    /*0x10*/ bool orthographicCamera;
                    /*0x11*/ bool aoBlueNoise;
                    /*0x12*/ bool aoInterleavedGradient;
                    /*0x13*/ bool sampleCountHigh;
                    /*0x14*/ bool sampleCountMedium;
                    /*0x15*/ bool sampleCountLow;
                    /*0x16*/ bool sourceDepthNormals;
                    /*0x17*/ bool sourceDepthHigh;
                    /*0x18*/ bool sourceDepthMedium;
                    /*0x19*/ bool sourceDepthLow;
                    /*0x1c*/ UnityEngine.Vector4 ssaoParams;

                    /*0x3c3442c*/ SSAOMaterialParams(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic);
                    /*0x3c3450c*/ bool Equals(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOMaterialParams other);
                }

                class SSAOPassData
                {
                    /*0x10*/ bool afterOpaque;
                    /*0x14*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality;
                    /*0x18*/ UnityEngine.Material material;
                    /*0x20*/ float directLightingStrength;
                    /*0x24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColor;
                    /*0x34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle AOTexture;
                    /*0x44*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle finalTexture;
                    /*0x54*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle blurTexture;
                    /*0x64*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;

                    /*0x3c33a48*/ SSAOPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__52_0;

                    static /*0x3c36f30*/ <>c();
                    /*0x3c36f98*/ <>c();
                    /*0x3c36fa0*/ void <RecordRenderGraph>b__52_0(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                }
            }

            enum ScriptableRenderPassInput
            {
                None = 0,
                Depth = 1,
                Normal = 2,
                Color = 4,
                Motion = 8,
            }

            enum RenderPassEvent
            {
                BeforeRendering = 0,
                BeforeRenderingShadows = 50,
                AfterRenderingShadows = 100,
                BeforeRenderingPrePasses = 150,
                AfterRenderingPrePasses = 200,
                BeforeRenderingGbuffer = 210,
                AfterRenderingGbuffer = 220,
                BeforeRenderingDeferredLights = 230,
                AfterRenderingDeferredLights = 240,
                BeforeRenderingOpaques = 250,
                AfterRenderingOpaques = 300,
                BeforeRenderingSkybox = 350,
                AfterRenderingSkybox = 400,
                BeforeRenderingTransparents = 450,
                AfterRenderingTransparents = 500,
                BeforeRenderingPostProcessing = 550,
                AfterRenderingPostProcessing = 600,
                AfterRendering = 1000,
            }

            enum FramebufferFetchEvent
            {
                None = 0,
                FetchGbufferInDeferred = 1,
            }

            class RenderPassEventsEnumValues
            {
                static /*0x0*/ int[] values;

                static /*0x3c37640*/ RenderPassEventsEnumValues();
            }

            class TransparentSettingsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ bool m_shouldReceiveShadows;

                static /*0x3c37be4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                /*0x3c379a0*/ TransparentSettingsPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool shadowReceiveSupported);
                /*0x3c37a70*/ bool Setup();
                /*0x3c37a80*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            struct PostProcessParams
            {
                /*0x10*/ UnityEngine.Material blitMaterial;
                /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat requestColorFormat;

                static /*0x3c37c6c*/ UnityEngine.Rendering.Universal.PostProcessParams Create();
            }

            struct PostProcessPasses : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass m_ColorGradingLutPass;
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessPass m_PostProcessPass;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessPass m_FinalPostProcessPass;
                /*0x28*/ UnityEngine.Rendering.RTHandle m_AfterPostProcessColor;
                /*0x30*/ UnityEngine.Rendering.RTHandle m_ColorGradingLut;
                /*0x38*/ UnityEngine.Rendering.Universal.PostProcessData m_RendererPostProcessData;
                /*0x40*/ UnityEngine.Rendering.Universal.PostProcessData m_CurrentPostProcessData;
                /*0x48*/ UnityEngine.Material m_BlitMaterial;

                /*0x3c37d20*/ PostProcessPasses(UnityEngine.Rendering.Universal.PostProcessData rendererPostProcessData, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x3c37c98*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x3c37ca0*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x3c37ca8*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x3c37cb0*/ UnityEngine.Rendering.RTHandle get_afterPostProcessColor();
                /*0x3c37cb8*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x3c37cc0*/ bool get_isCreated();
                /*0x3c37dc8*/ void Recreate(UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams ppParams);
                /*0x3c3800c*/ void Dispose();
                /*0x3c38070*/ void ReleaseRenderTargets();
            }

            class PostProcessUtils
            {
                static /*0x3c380c4*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x3c38128*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x3c382bc*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x3c38320*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x3c385e8*/ void SetSourceSize(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source);
                static /*0x3c35da0*/ void SetSourceSize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source);

                class ShaderConstants
                {
                    static /*0x0*/ int _Grain_Texture;
                    static /*0x4*/ int _Grain_Params;
                    static /*0x8*/ int _Grain_TilingParams;
                    static /*0xc*/ int _BlueNoise_Texture;
                    static /*0x10*/ int _Dithering_Params;
                    static /*0x14*/ int _SourceSize;

                    static /*0x3c386e0*/ ShaderConstants();
                }
            }

            struct ReflectionProbeManager : System.IDisposable
            {
                static int k_MaxMipCount = 7;
                static string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas";
                /*0x10*/ Unity.Mathematics.int2 m_Resolution;
                /*0x18*/ UnityEngine.RenderTexture m_AtlasTexture0;
                /*0x20*/ UnityEngine.RenderTexture m_AtlasTexture1;
                /*0x28*/ UnityEngine.Rendering.RTHandle m_AtlasTexture0Handle;
                /*0x30*/ UnityEngine.Rendering.Universal.BuddyAllocator m_AtlasAllocator;
                /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe> m_Cache;
                /*0x60*/ System.Collections.Generic.Dictionary<int, int> m_WarningCache;
                /*0x68*/ System.Collections.Generic.List<int> m_NeedsUpdate;
                /*0x70*/ System.Collections.Generic.List<int> m_NeedsRemove;
                /*0x78*/ UnityEngine.Vector4[] m_BoxMax;
                /*0x80*/ UnityEngine.Vector4[] m_BoxMin;
                /*0x88*/ UnityEngine.Vector4[] m_ProbePosition;
                /*0x90*/ UnityEngine.Vector4[] m_MipScaleOffset;

                static /*0x3c38860*/ UnityEngine.Rendering.Universal.ReflectionProbeManager Create();
                /*0x3c38850*/ UnityEngine.RenderTexture get_atlasRT();
                /*0x3c38858*/ UnityEngine.Rendering.RTHandle get_atlasRTHandle();
                /*0x3c388a0*/ void Init();
                /*0x3c38d68*/ void UpdateGpuData(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults);
                /*0x3c3a9a0*/ Unity.Mathematics.float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip);
                /*0x3c3aa68*/ void Dispose();

                struct CachedProbe
                {
                    /*0x10*/ uint updateCount;
                    /*0x18*/ UnityEngine.Hash128 imageContentsHash;
                    /*0x28*/ int size;
                    /*0x2c*/ int mipCount;
                    /*0x30*/ UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe.<dataIndices> dataIndices;
                    /*0x4c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe.<levels> levels;
                    /*0x68*/ UnityEngine.Texture texture;
                    /*0x70*/ int lastUsed;
                    /*0x74*/ UnityEngine.Vector4 hdrData;

                    struct <dataIndices>e__FixedBuffer
                    {
                        /*0x10*/ int FixedElementField;
                    }

                    struct <levels>e__FixedBuffer
                    {
                        /*0x10*/ int FixedElementField;
                    }
                }

                class ShaderProperties
                {
                    static /*0x0*/ int BoxMin;
                    static /*0x4*/ int BoxMax;
                    static /*0x8*/ int ProbePosition;
                    static /*0xc*/ int MipScaleOffset;
                    static /*0x10*/ int Count;
                    static /*0x14*/ int Atlas;

                    static /*0x3c3ab34*/ ShaderProperties();
                }
            }

            enum DecalSurfaceData
            {
                Albedo = 0,
                AlbedoNormal = 1,
                AlbedoNormalMAOS = 2,
            }

            enum DecalTechnique
            {
                Invalid = 0,
                DBuffer = 1,
                ScreenSpace = 2,
                GBuffer = 3,
            }

            enum DecalTechniqueOption
            {
                Automatic = 0,
                DBuffer = 1,
                ScreenSpace = 2,
            }

            class DBufferSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalSurfaceData surfaceData;

                /*0x3c3aca4*/ DBufferSettings();
            }

            enum DecalNormalBlend
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class DecalScreenSpaceSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalNormalBlend normalBlend;

                /*0x3c3acb4*/ DecalScreenSpaceSettings();
            }

            class DecalSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalTechniqueOption technique;
                /*0x14*/ float maxDrawDistance;
                /*0x18*/ bool decalLayers;
                /*0x20*/ UnityEngine.Rendering.Universal.DBufferSettings dBufferSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings screenSpaceSettings;

                /*0x3c3acbc*/ DecalSettings();
            }

            class SharedDecalEntityManager : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x18*/ int m_ReferenceCounter;

                /*0x3c3b260*/ SharedDecalEntityManager();
                /*0x3c3accc*/ UnityEngine.Rendering.Universal.DecalEntityManager Get();
                /*0x3c3af70*/ void Release(UnityEngine.Rendering.Universal.DecalEntityManager decalEntityManager);
                /*0x3c3af8c*/ void Dispose();
                /*0x3c3b14c*/ void OnDecalAdd(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x3c3b1a0*/ void OnDecalRemove(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x3c3b1c4*/ void OnDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x3c3b220*/ void OnAllDecalPropertyChange();
                /*0x3c3b238*/ void OnDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
            }

            class DecalRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalSettings m_Settings;
                /*0x28*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;
                /*0x30*/ UnityEngine.Rendering.Universal.DBufferSettings m_DBufferSettings;
                /*0x38*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_ScreenSpaceSettings;
                /*0x40*/ bool m_RecreateSystems;
                /*0x48*/ UnityEngine.Rendering.Universal.DecalPreviewPass m_DecalPreviewPass;
                /*0x50*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x58*/ UnityEngine.Rendering.Universal.DecalUpdateCachedSystem m_DecalUpdateCachedSystem;
                /*0x60*/ UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;
                /*0x68*/ UnityEngine.Rendering.Universal.DecalUpdateCulledSystem m_DecalUpdateCulledSystem;
                /*0x70*/ UnityEngine.Rendering.Universal.DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;
                /*0x78*/ UnityEngine.Rendering.Universal.DecalDrawErrorSystem m_DrawErrorSystem;
                /*0x80*/ UnityEngine.Rendering.Universal.DBufferCopyDepthPass m_CopyDepthPass;
                /*0x88*/ UnityEngine.Rendering.Universal.DBufferRenderPass m_DBufferRenderPass;
                /*0x90*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass m_ForwardEmissivePass;
                /*0x98*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DecalDrawDBufferSystem;
                /*0xa0*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;
                /*0xa8*/ UnityEngine.Material m_DBufferClearMaterial;
                /*0xb0*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;
                /*0xb8*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;
                /*0xc0*/ UnityEngine.Rendering.Universal.DecalSkipCulledSystem m_DecalSkipCulledSystem;
                /*0xc8*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass m_GBufferRenderPass;
                /*0xd0*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawGBufferSystem;
                /*0xd8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                static /*0x3c3c6e4*/ DecalRendererFeature();
                static /*0x3c3b268*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager get_sharedDecalEntityManager();
                static /*0x3c3b2f0*/ bool get_isGLDevice();
                /*0x3c3c670*/ DecalRendererFeature();
                /*0x3c3b2c0*/ ref UnityEngine.Rendering.Universal.DecalSettings get_settings();
                /*0x3c3b2c8*/ bool get_intermediateRendering();
                /*0x3c3b2d8*/ bool get_requiresDecalLayers();
                /*0x3c3b324*/ void Create();
                /*0x3c3b390*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x3c3b5f8*/ UnityEngine.Rendering.Universal.DBufferSettings GetDBufferSettings();
                /*0x3c3b678*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings GetScreenSpaceSettings();
                /*0x3c3b6f4*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRendererData renderer);
                /*0x3c3b81c*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x3c3b43c*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques);
                /*0x3c3b8fc*/ bool IsAutomaticDBuffer();
                /*0x3c3b9c8*/ bool RecreateSystemsIfNeeded(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3c3c074*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3c3c1ac*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3c360*/ bool SupportsNativeRenderPass();
                /*0x3c3c374*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3c54c*/ void Dispose(bool disposing);
                /*0x3c3c66c*/ void ChangeAdaptivePerformanceDrawDistances();
            }

            class DisallowMultipleRendererFeature : System.Attribute
            {
                /*0x10*/ string <customTitle>k__BackingField;

                /*0x3c3c770*/ DisallowMultipleRendererFeature(string customTitle);
                /*0x3c3c760*/ void set_customTitle(string value);
                /*0x3c3c768*/ string get_customTitle();
            }

            class FullScreenPassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x1c*/ UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.InjectionPoint injectionPoint;
                /*0x20*/ bool fetchColorBuffer;
                /*0x24*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput requirements;
                /*0x28*/ UnityEngine.Material passMaterial;
                /*0x30*/ int passIndex;
                /*0x34*/ bool bindDepthStencilAttachment;
                /*0x38*/ UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass m_FullScreenPass;
                /*0x40*/ UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.Version m_Version;

                /*0x3c3cc50*/ FullScreenPassRendererFeature();
                /*0x3c3c7a0*/ void Create();
                /*0x3c3c8b4*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x3c3c8c8*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3cbe0*/ void Dispose(bool disposing);
                /*0x3c3cc18*/ void UpgradeIfNeeded();
                /*0x3c3cc1c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x3c3cc38*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

                enum InjectionPoint
                {
                    BeforeRenderingTransparents = 450,
                    BeforeRenderingPostProcessing = 550,
                    AfterRenderingPostProcessing = 600,
                }

                class FullScreenRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.MaterialPropertyBlock s_SharedPropertyBlock;
                    /*0xb8*/ UnityEngine.Material m_Material;
                    /*0xc0*/ int m_PassIndex;
                    /*0xc4*/ bool m_FetchActiveColor;
                    /*0xc5*/ bool m_BindDepthStencilAttachment;
                    /*0xc8*/ UnityEngine.Rendering.RTHandle m_CopiedColor;

                    static /*0x3c3e108*/ FullScreenRenderPass();
                    static /*0x3c3cd6c*/ void ExecuteCopyColorPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture);
                    static /*0x3c3cdec*/ void ExecuteMainPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Material material, int passIndex);
                    /*0x3c3c814*/ FullScreenRenderPass(string passName);
                    /*0x3c3cb9c*/ void SetupMembers(UnityEngine.Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment);
                    /*0x3c3cc70*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c3ccd4*/ void ReAllocate(UnityEngine.RenderTextureDescriptor desc);
                    /*0x3c3cc04*/ void Dispose();
                    /*0x3c3cfcc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c3d324*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                    class CopyPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

                        /*0x3c3e184*/ CopyPassData();
                    }

                    class MainPassData
                    {
                        /*0x10*/ UnityEngine.Material material;
                        /*0x18*/ int passIndex;
                        /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

                        /*0x3c3e18c*/ MainPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;
                        static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_1;

                        static /*0x3c3e194*/ <>c();
                        /*0x3c3e1fc*/ <>c();
                        /*0x3c3e204*/ void <RecordRenderGraph>b__14_0(UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                        /*0x3c3e2b0*/ void <RecordRenderGraph>b__14_1(UnityEngine.Rendering.Universal.FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }

                enum Version
                {
                    Uninitialised = -1,
                    Initial = 0,
                    AddFetchColorBufferCheckbox = 1,
                    Count = 2,
                    Latest = 1,
                }
            }

            enum RenderQueueType
            {
                Opaque = 0,
                Transparent = 1,
            }

            class RenderObjects : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                /*0x20*/ UnityEngine.Rendering.Universal.RenderObjects.RenderObjectsSettings settings;
                /*0x28*/ UnityEngine.Rendering.Universal.RenderObjectsPass renderObjectsPass;

                /*0x3c3e634*/ RenderObjects();
                /*0x3c3e370*/ void Create();
                /*0x3c3e580*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3e62c*/ bool SupportsNativeRenderPass();

                class RenderObjectsSettings
                {
                    /*0x10*/ string passTag;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent Event;
                    /*0x20*/ UnityEngine.Rendering.Universal.RenderObjects.FilterSettings filterSettings;
                    /*0x28*/ UnityEngine.Material overrideMaterial;
                    /*0x30*/ int overrideMaterialPassIndex;
                    /*0x38*/ UnityEngine.Shader overrideShader;
                    /*0x40*/ int overrideShaderPassIndex;
                    /*0x44*/ UnityEngine.Rendering.Universal.RenderObjects.RenderObjectsSettings.OverrideMaterialMode overrideMode;
                    /*0x48*/ bool overrideDepthState;
                    /*0x4c*/ UnityEngine.Rendering.CompareFunction depthCompareFunction;
                    /*0x50*/ bool enableWrite;
                    /*0x58*/ UnityEngine.Rendering.Universal.StencilStateData stencilSettings;
                    /*0x60*/ UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;

                    /*0x3c3e69c*/ RenderObjectsSettings();

                    enum OverrideMaterialMode
                    {
                        None = 0,
                        Material = 1,
                        Shader = 2,
                    }
                }

                class FilterSettings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderQueueType RenderQueueType;
                    /*0x14*/ UnityEngine.LayerMask LayerMask;
                    /*0x18*/ string[] PassNames;

                    /*0x3c3e7ec*/ FilterSettings();
                }

                class CustomCameraSettings
                {
                    /*0x10*/ bool overrideCamera;
                    /*0x11*/ bool restoreCamera;
                    /*0x14*/ UnityEngine.Vector4 offset;
                    /*0x24*/ float cameraFieldOfView;

                    /*0x3c3e818*/ CustomCameraSettings();
                }
            }

            class ScreenSpaceAmbientOcclusionSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.AOMethodOptions AOMethod;
                /*0x14*/ bool Downsample;
                /*0x15*/ bool AfterOpaque;
                /*0x18*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.DepthSource Source;
                /*0x1c*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.NormalQuality NormalSamples;
                /*0x20*/ float Intensity;
                /*0x24*/ float DirectLightingStrength;
                /*0x28*/ float Radius;
                /*0x2c*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.AOSampleOption Samples;
                /*0x30*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality;
                /*0x34*/ float Falloff;
                /*0x38*/ int SampleCount;

                /*0x3c33a14*/ ScreenSpaceAmbientOcclusionSettings();

                enum DepthSource
                {
                    Depth = 0,
                    DepthNormals = 1,
                }

                enum NormalQuality
                {
                    Low = 0,
                    Medium = 1,
                    High = 2,
                }

                enum AOSampleOption
                {
                    High = 0,
                    Medium = 1,
                    Low = 2,
                }

                enum AOMethodOptions
                {
                    BlueNoise = 0,
                    InterleavedGradient = 1,
                }

                enum BlurQualityOptions
                {
                    High = 0,
                    Medium = 1,
                    Low = 2,
                }
            }

            class ScreenSpaceAmbientOcclusionPersistentResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_Shader;
                /*0x18*/ int m_Version;

                /*0x3c3e8bc*/ ScreenSpaceAmbientOcclusionPersistentResources();
                /*0x3c3e830*/ UnityEngine.Shader get_Shader();
                /*0x3c3e838*/ void set_Shader(UnityEngine.Shader value);
                /*0x3c3e8ac*/ bool get_isAvailableInPlayerBuild();
                /*0x3c3e8b4*/ int get_version();
            }

            class ScreenSpaceAmbientOcclusionDynamicResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Texture2D[] m_BlueNoise256Textures;
                /*0x18*/ int m_Version;

                /*0x3c3e950*/ ScreenSpaceAmbientOcclusionDynamicResources();
                /*0x3c3e8c4*/ UnityEngine.Texture2D[] get_BlueNoise256Textures();
                /*0x3c3e8cc*/ void set_BlueNoise256Textures(UnityEngine.Texture2D[] value);
                /*0x3c3e940*/ bool get_isAvailableInPlayerBuild();
                /*0x3c3e948*/ int get_version();
            }

            class ScreenSpaceAmbientOcclusion : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";
                static string k_AOBlueNoiseKeyword = "_BLUE_NOISE";
                static string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
                static string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";
                static string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";
                static string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";
                static string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
                static string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";
                static string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";
                static string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";
                /*0x20*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_Settings;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass m_SSAOPass;
                /*0x38*/ UnityEngine.Shader m_Shader;
                /*0x40*/ UnityEngine.Texture2D[] m_BlueNoise256Textures;

                /*0x3c3ef74*/ ScreenSpaceAmbientOcclusion();
                /*0x3c3e958*/ ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings get_settings();
                /*0x3c3e960*/ void Create();
                /*0x3c3ea1c*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3eef8*/ void Dispose(bool disposing);
                /*0x3c3eaec*/ bool TryPrepareResources();
            }

            class ScreenSpaceShadowsSettings
            {
                /*0x3c3f00c*/ ScreenSpaceShadowsSettings();
            }

            class ScreenSpaceShadows : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

                /*0x3c3f7dc*/ ScreenSpaceShadows();
                /*0x3c3f014*/ void Create();
                /*0x3c3f458*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c3f740*/ void Dispose(bool disposing);
                /*0x3c3f2e4*/ bool LoadMaterial();

                class ScreenSpaceShadowsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Material m_Material;
                    /*0xc0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_CurrentSettings;
                    /*0xc8*/ UnityEngine.Rendering.RTHandle m_RenderTarget;
                    /*0xd0*/ int m_ScreenSpaceShadowmapTextureID;
                    /*0xd8*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData m_PassData;

                    static /*0x3c4018c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RTHandle target);
                    /*0x3c3f0ec*/ ScreenSpaceShadowsPass();
                    /*0x3c3f7c8*/ void Dispose();
                    /*0x3c3f6a8*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings featureSettings, UnityEngine.Material material);
                    /*0x3c3f850*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c3f9c0*/ void InitPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData passData);
                    /*0x3c3fa08*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                    /*0x3c402c0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle target;
                        /*0x20*/ UnityEngine.Material material;
                        /*0x28*/ int shadowmapID;

                        /*0x3c3f848*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__11_0;

                        static /*0x3c40570*/ <>c();
                        /*0x3c405d8*/ <>c();
                        /*0x3c405e0*/ void <RecordRenderGraph>b__11_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }

                class ScreenSpaceShadowsPostPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.RTHandle k_CurrentActive;

                    static /*0x3c40dd8*/ ScreenSpaceShadowsPostPass();
                    static /*0x3c406c8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c3f23c*/ ScreenSpaceShadowsPostPass();
                    /*0x3c40664*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x3c40788*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c40960*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass pass;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;

                        /*0x3c40e8c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                        static /*0x3c40e94*/ <>c();
                        /*0x3c40efc*/ <>c();
                        /*0x3c40f04*/ void <RecordRenderGraph>b__6_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }
            }

            class RenderingLayerUtils
            {
                static /*0x3c40f6c*/ void CombineRendererEvents(bool isDeferred, int msaaSampleCount, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event rendererEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent);
                static /*0x3c40fa0*/ bool RequireRenderingLayers(UnityEngine.Rendering.Universal.UniversalRenderer universalRenderer, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x3c41014*/ bool RequireRenderingLayers(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, UnityEngine.Rendering.Universal.RenderingMode renderingMode, bool accurateGbufferNormals, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x3c413a0*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x3c4145c*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x3c41570*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x3c415fc*/ uint ToValidRenderingLayers(uint renderingLayers);
                static /*0x3c4136c*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize GetMaskSize(int bits);
                static /*0x3c41524*/ int GetBits(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x3c40f94*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.Event a, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event b);
                static /*0x3c41360*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize a, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize b);

                enum Event
                {
                    DepthNormalPrePass = 0,
                    Opaque = 1,
                }

                enum MaskSize
                {
                    Bits8 = 0,
                    Bits16 = 1,
                    Bits24 = 2,
                    Bits32 = 3,
                }
            }

            class RenderingUtils
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_LegacyShaderPassNames;
                static /*0x8*/ UnityEngine.Rendering.AttachmentDescriptor s_EmptyAttachment;
                static /*0x80*/ UnityEngine.Mesh s_FullscreenMesh;
                static /*0x88*/ UnityEngine.Material s_ErrorMaterial;
                static /*0x90*/ UnityEngine.Rendering.ShaderTagId[] s_ShaderTagValues;
                static /*0x98*/ UnityEngine.Rendering.RenderStateBlock[] s_RenderStateBlocks;
                static /*0xa0*/ System.Collections.Generic.Dictionary<UnityEngine.RenderTextureFormat, bool> m_RenderTextureFormatSupport;

                static /*0x3c45f0c*/ RenderingUtils();
                static /*0x3c416d8*/ UnityEngine.Rendering.AttachmentDescriptor get_emptyAttachment();
                static /*0x3c4173c*/ UnityEngine.Mesh get_fullscreenMesh();
                static /*0x3c41ad0*/ bool get_useStructuredBuffer();
                static /*0x3c41ad8*/ bool SupportsLightLayers(UnityEngine.Rendering.GraphicsDeviceType type);
                static /*0x3c41ae0*/ UnityEngine.Material get_errorMaterial();
                static /*0x3c41c78*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x3c31df8*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x3c41da0*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle rTHandle);
                static /*0x3c41f1c*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x3c420c4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x3c42288*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destinationColor, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle destinationDepthStencil, UnityEngine.Rendering.RenderBufferLoadAction depthStencilLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStencilStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x3c42498*/ void FinalBlit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int passIndex);
                static /*0x3c42898*/ void CreateRendererParamsObjectsWithError(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererListParams param);
                static /*0x3c42b6c*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererList rl);
                static /*0x3c42cec*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x3c42e28*/ void DrawRendererListObjectsWithError(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rl);
                static /*0x3c32608*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RendererList rl);
                static /*0x3c32310*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x3c42e60*/ void ClearSystemInfoCache();
                static /*0x3c42ed8*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
                static /*0x3c42fe0*/ bool SupportsGraphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x3c42ff0*/ int GetLastValidColorBufferIndex(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x3c430a8*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x3c43180*/ bool IsMRT(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x3c431e0*/ bool Contains(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x3c43290*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x3c43348*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x3c433cc*/ uint CountDistinct(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x3c43508*/ int LastValid(UnityEngine.Rendering.RTHandle[] source);
                static /*0x3c435c8*/ bool Contains(UnityEngine.Rendering.ClearFlag a, UnityEngine.Rendering.ClearFlag b);
                static /*0x3c435d4*/ bool SequenceEqual(UnityEngine.Rendering.RTHandle[] left, UnityEngine.Rendering.RTHandle[] right);
                static /*0x3c436bc*/ bool MultisampleDepthResolveSupported();
                static /*0x3c43754*/ bool RTHandleNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc descriptor, bool scaled);
                static /*0x3c43bc0*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraTargetIdentifier(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x3c43ca4*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x3c443f8*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x3c447b8*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x3c358b4*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x3c44b94*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x3c450e8*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x3c45670*/ bool SetMaxRTHandlePoolCapacity(int capacity);
                static /*0x3c44144*/ void AddStaleResourceToPoolOrRelease(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, UnityEngine.Rendering.RTHandle handle);
                static /*0x3c459c0*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x3c45b20*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x3c45cd8*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x3c320d4*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x3c45e38*/ UnityEngine.Vector4 GetFinalBlitScaleBias(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
            }

            class Renderer2DResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_LightShader;
                /*0x20*/ UnityEngine.Shader m_ProjectedShadowShader;
                /*0x28*/ UnityEngine.Shader m_SpriteShadowShader;
                /*0x30*/ UnityEngine.Shader m_SpriteUnshadowShader;
                /*0x38*/ UnityEngine.Shader m_GeometryShadowShader;
                /*0x40*/ UnityEngine.Shader m_GeometryUnshadowShader;
                /*0x48*/ UnityEngine.Texture2D m_FallOffLookup;
                /*0x50*/ UnityEngine.Shader m_CopyDepthPS;

                /*0x3c46664*/ Renderer2DResources();
                /*0x3c46274*/ int get_version();
                /*0x3c4627c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c46284*/ UnityEngine.Shader get_lightShader();
                /*0x3c4628c*/ void set_lightShader(UnityEngine.Shader value);
                /*0x3c46300*/ UnityEngine.Shader get_projectedShadowShader();
                /*0x3c46308*/ void set_projectedShadowShader(UnityEngine.Shader value);
                /*0x3c4637c*/ UnityEngine.Shader get_spriteShadowShader();
                /*0x3c46384*/ void set_spriteShadowShader(UnityEngine.Shader value);
                /*0x3c463f8*/ UnityEngine.Shader get_spriteUnshadowShader();
                /*0x3c46400*/ void set_spriteUnshadowShader(UnityEngine.Shader value);
                /*0x3c46474*/ UnityEngine.Shader get_geometryShadowShader();
                /*0x3c4647c*/ void set_geometryShadowShader(UnityEngine.Shader value);
                /*0x3c464f0*/ UnityEngine.Shader get_geometryUnshadowShader();
                /*0x3c464f8*/ void set_geometryUnshadowShader(UnityEngine.Shader value);
                /*0x3c4656c*/ UnityEngine.Texture2D get_fallOffLookup();
                /*0x3c46574*/ void set_fallOffLookup(UnityEngine.Texture2D value);
                /*0x3c465e8*/ UnityEngine.Shader get_copyDepthPS();
                /*0x3c465f0*/ void set_copyDepthPS(UnityEngine.Shader value);
            }

            class UniversalRendererResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_CopyDepthPS;
                /*0x20*/ UnityEngine.Shader m_CameraMotionVector;
                /*0x28*/ UnityEngine.Shader m_StencilDeferredPS;
                /*0x30*/ UnityEngine.Shader m_DBufferClear;

                /*0x3c4686c*/ UniversalRendererResources();
                /*0x3c4666c*/ int get_version();
                /*0x3c46674*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c4667c*/ UnityEngine.Shader get_copyDepthPS();
                /*0x3c46684*/ void set_copyDepthPS(UnityEngine.Shader value);
                /*0x3c466f8*/ UnityEngine.Shader get_cameraMotionVector();
                /*0x3c46700*/ void set_cameraMotionVector(UnityEngine.Shader value);
                /*0x3c46774*/ UnityEngine.Shader get_stencilDeferredPS();
                /*0x3c4677c*/ void set_stencilDeferredPS(UnityEngine.Shader value);
                /*0x3c467f0*/ UnityEngine.Shader get_decalDBufferClear();
                /*0x3c467f8*/ void set_decalDBufferClear(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineDebugShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_DebugReplacementPS;
                /*0x18*/ UnityEngine.Shader m_HdrDebugViewPS;
                /*0x20*/ UnityEngine.ComputeShader m_ProbeVolumeSamplingDebugComputeShader;

                /*0x3c469f8*/ UniversalRenderPipelineDebugShaders();
                /*0x3c46874*/ int get_version();
                /*0x3c4687c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c46884*/ UnityEngine.Shader get_debugReplacementPS();
                /*0x3c4688c*/ void set_debugReplacementPS(UnityEngine.Shader value);
                /*0x3c46900*/ UnityEngine.Shader get_hdrDebugViewPS();
                /*0x3c46908*/ void set_hdrDebugViewPS(UnityEngine.Shader value);
                /*0x3c4697c*/ UnityEngine.ComputeShader get_probeVolumeSamplingDebugComputeShader();
                /*0x3c46984*/ void set_probeVolumeSamplingDebugComputeShader(UnityEngine.ComputeShader value);
            }

            class UniversalRenderPipelineRuntimeShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_FallbackErrorShader;
                /*0x20*/ UnityEngine.Shader m_BlitHDROverlay;
                /*0x28*/ UnityEngine.Shader m_CoreBlitPS;
                /*0x30*/ UnityEngine.Shader m_CoreBlitColorAndDepthPS;
                /*0x38*/ UnityEngine.Shader m_SamplingPS;
                /*0x40*/ UnityEngine.Shader m_TerrainDetailLit;
                /*0x48*/ UnityEngine.Shader m_TerrainDetailGrassBillboard;
                /*0x50*/ UnityEngine.Shader m_TerrainDetailGrass;

                /*0x3c46df0*/ UniversalRenderPipelineRuntimeShaders();
                /*0x3c46a00*/ int get_version();
                /*0x3c46a08*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c46a10*/ UnityEngine.Shader get_fallbackErrorShader();
                /*0x3c46a18*/ void set_fallbackErrorShader(UnityEngine.Shader value);
                /*0x3c46a8c*/ UnityEngine.Shader get_blitHDROverlay();
                /*0x3c46a94*/ void set_blitHDROverlay(UnityEngine.Shader value);
                /*0x3c46b08*/ UnityEngine.Shader get_coreBlitPS();
                /*0x3c46b10*/ void set_coreBlitPS(UnityEngine.Shader value);
                /*0x3c46b84*/ UnityEngine.Shader get_coreBlitColorAndDepthPS();
                /*0x3c46b8c*/ void set_coreBlitColorAndDepthPS(UnityEngine.Shader value);
                /*0x3c46c00*/ UnityEngine.Shader get_samplingPS();
                /*0x3c46c08*/ void set_samplingPS(UnityEngine.Shader value);
                /*0x3c46c7c*/ UnityEngine.Shader get_terrainDetailLitShader();
                /*0x3c46c84*/ void set_terrainDetailLitShader(UnityEngine.Shader value);
                /*0x3c46cf8*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
                /*0x3c46d00*/ void set_terrainDetailGrassBillboardShader(UnityEngine.Shader value);
                /*0x3c46d74*/ UnityEngine.Shader get_terrainDetailGrassShader();
                /*0x3c46d7c*/ void set_terrainDetailGrassShader(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineRuntimeTextures : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Texture2D m_BlueNoise64LTex;
                /*0x20*/ UnityEngine.Texture2D m_BayerMatrixTex;
                /*0x28*/ UnityEngine.Texture2D m_DebugFontTex;

                /*0x3c46f7c*/ UniversalRenderPipelineRuntimeTextures();
                /*0x3c46df8*/ int get_version();
                /*0x3c46e00*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c46e08*/ UnityEngine.Texture2D get_blueNoise64LTex();
                /*0x3c46e10*/ void set_blueNoise64LTex(UnityEngine.Texture2D value);
                /*0x3c46e84*/ UnityEngine.Texture2D get_bayerMatrixTex();
                /*0x3c46e8c*/ void set_bayerMatrixTex(UnityEngine.Texture2D value);
                /*0x3c46f00*/ UnityEngine.Texture2D get_debugFontTexture();
                /*0x3c46f08*/ void set_debugFontTexture(UnityEngine.Texture2D value);
            }

            class UniversalRenderPipelineRuntimeXRResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_xrOcclusionMeshPS;
                /*0x18*/ UnityEngine.Shader m_xrMirrorViewPS;
                /*0x20*/ UnityEngine.Shader m_xrMotionVector;

                /*0x3c471d4*/ UniversalRenderPipelineRuntimeXRResources();
                /*0x3c46f8c*/ int get_version();
                /*0x3c46f94*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c46f9c*/ UnityEngine.Shader get_xrOcclusionMeshPS();
                /*0x3c46fa4*/ void set_xrOcclusionMeshPS(UnityEngine.Shader value);
                /*0x3c47018*/ UnityEngine.Shader get_xrMirrorViewPS();
                /*0x3c47020*/ void set_xrMirrorViewPS(UnityEngine.Shader value);
                /*0x3c47094*/ UnityEngine.Shader get_xrMotionVector();
                /*0x3c4709c*/ void set_xrMotionVector(UnityEngine.Shader value);
                /*0x3c47110*/ bool get_valid();
            }

            struct RenderTargetHandle
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.RenderTargetHandle CameraTarget;
                /*0x10*/ int <id>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier <rtid>k__BackingField;

                static /*0x3c47a70*/ RenderTargetHandle();
                static /*0x3c47484*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetCameraTarget(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x3c47964*/ bool op_Equality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                static /*0x3c479e8*/ bool op_Inequality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                /*0x3c4721c*/ RenderTargetHandle(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x3c47294*/ RenderTargetHandle(UnityEngine.Rendering.RTHandle rtHandle);
                /*0x3c471dc*/ void set_id(int value);
                /*0x3c471e4*/ int get_id();
                /*0x3c471ec*/ void set_rtid(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x3c47204*/ UnityEngine.Rendering.RenderTargetIdentifier get_rtid();
                /*0x3c474ec*/ void Init(string shaderProperty);
                /*0x3c47560*/ void Init(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x3c475d8*/ UnityEngine.Rendering.RenderTargetIdentifier Identifier();
                /*0x3c476e8*/ bool HasInternalRenderTargetId();
                /*0x3c47744*/ bool Equals(UnityEngine.Rendering.Universal.RenderTargetHandle other);
                /*0x3c47850*/ bool Equals(object obj);
                /*0x3c47910*/ int GetHashCode();
            }

            class RTHandleResourcePool
            {
                static /*0x0*/ int s_CurrentStaleResourceCount;
                static /*0x4*/ int s_StaleResourceLifetime;
                static /*0x8*/ int s_StaleResourceMaxCapacity;
                /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<UnityEngine.Rendering.RTHandle, int>>> m_ResourcePool;
                /*0x18*/ System.Collections.Generic.List<int> m_RemoveList;

                static /*0x3c49048*/ RTHandleResourcePool();
                static /*0x3c48120*/ bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                static /*0x3c43fe0*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc CreateTextureDesc(UnityEngine.RenderTextureDescriptor desc, UnityEngine.Rendering.RenderGraphModule.TextureSizeMode textureSizeMode, int anisoLevel, float mipMapBias, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, string name);
                /*0x3c48f68*/ RTHandleResourcePool();
                /*0x3c47acc*/ int get_staleResourceCapacity();
                /*0x3c45708*/ void set_staleResourceCapacity(int value);
                /*0x3c457a4*/ bool AddResourceToPool(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, UnityEngine.Rendering.RTHandle resource, int currentFrameIndex);
                /*0x3c44210*/ bool TryGetResource(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, ref UnityEngine.Rendering.RTHandle resource, bool usepool);
                /*0x3c47b24*/ void Cleanup();
                /*0x3c48194*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x3c48850*/ void LogDebugInfo();
                /*0x3c480c8*/ int GetHashCodeWithNameHash(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc);
            }

            enum SampleCount
            {
                One = 1,
                Two = 2,
                Four = 4,
            }

            class ScriptableRendererFeature : UnityEngine.ScriptableObject, System.IDisposable
            {
                /*0x18*/ bool m_Active;

                /*0x3c492d8*/ ScriptableRendererFeature();
                /*0x3c490a0*/ bool get_isActive();
                /*0x1f309e4*/ void Create();
                /*0x3c490a8*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1f30ff0*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c490ac*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c490b0*/ void OnEnable();
                /*0x3c4917c*/ void OnValidate();
                /*0x3c49248*/ bool SupportsNativeRenderPass();
                /*0x3c49250*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x3c49260*/ void SetActive(bool active);
                /*0x3c49268*/ void Dispose();
                /*0x3c492d4*/ void Dispose(bool disposing);
            }

            class RenderGraphSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.RenderGraphSettings.Version m_Version;
                /*0x14*/ bool m_EnableRenderCompatibilityMode;

                /*0x3c49424*/ RenderGraphSettings();
                /*0x3c492e8*/ int get_version();
                /*0x3c492f0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x3c492f8*/ bool get_enableRenderCompatibilityMode();
                /*0x3c4939c*/ void set_enableRenderCompatibilityMode(bool value);

                enum Version
                {
                    Initial = 0,
                }
            }

            class URPDefaultVolumeProfileSettings : UnityEngine.Rendering.IDefaultVolumeProfileSettings, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.URPDefaultVolumeProfileSettings.Version m_Version;
                /*0x18*/ UnityEngine.Rendering.VolumeProfile m_VolumeProfile;

                /*0x3c494b0*/ URPDefaultVolumeProfileSettings();
                /*0x3c4942c*/ int get_version();
                /*0x3c49434*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x3c4943c*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);

                enum Version
                {
                    Initial = 0,
                }
            }

            class URPShaderStrippingSetting : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.URPShaderStrippingSetting.Version m_Version;
                /*0x14*/ bool m_StripUnusedPostProcessingVariants;
                /*0x15*/ bool m_StripUnusedVariants;
                /*0x16*/ bool m_StripScreenCoordOverrideVariants;

                /*0x3c49670*/ URPShaderStrippingSetting();
                /*0x3c494b8*/ int get_version();
                /*0x3c494c0*/ bool get_stripUnusedPostProcessingVariants();
                /*0x3c494c8*/ void set_stripUnusedPostProcessingVariants(bool value);
                /*0x3c49550*/ bool get_stripUnusedVariants();
                /*0x3c49558*/ void set_stripUnusedVariants(bool value);
                /*0x3c495e0*/ bool get_stripScreenCoordOverrideVariants();
                /*0x3c495e8*/ void set_stripScreenCoordOverrideVariants(bool value);

                enum Version
                {
                    Initial = 0,
                }
            }

            struct ShaderBitArray
            {
                static int k_BitsPerElement = 32;
                static int k_ElementShift = 5;
                static int k_ElementMask = 31;
                /*0x10*/ float[] m_Data;

                /*0x3c49680*/ int get_elemLength();
                /*0x3c49698*/ int get_bitCapacity();
                /*0x3c496b4*/ float[] get_data();
                /*0x3c496bc*/ void Resize(int bitCount);
                /*0x3c498c8*/ void Clear();
                /*0x3c49910*/ void GetElementIndexAndBitOffset(int index, ref int elemIndex, ref int bitOffset);
                /*0x3c49924*/ bool get_Item(int index);
                /*0x3c49950*/ void set_Item(int index, bool value);
                /*0x3c49990*/ string ToString();
            }

            class ShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.ShaderData m_Instance;
                /*0x10*/ UnityEngine.ComputeBuffer m_LightDataBuffer;
                /*0x18*/ UnityEngine.ComputeBuffer m_LightIndicesBuffer;
                /*0x20*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;
                /*0x28*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

                static /*0x3c49b00*/ UnityEngine.Rendering.Universal.ShaderData get_instance();
                /*0x3c49af8*/ ShaderData();
                /*0x3c49b88*/ void Dispose();
                /*0x3c49be4*/ UnityEngine.ComputeBuffer GetLightDataBuffer(int size);
                /*0x3c49c40*/ UnityEngine.ComputeBuffer GetLightIndicesBuffer(int size);
                /*0x3c49c9c*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size);
                /*0x3c49cf8*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size);
                /*0x1f30300*/ UnityEngine.ComputeBuffer GetOrUpdateBuffer<T>(ref UnityEngine.ComputeBuffer buffer, int size);
                /*0x3c49bb4*/ void DisposeBuffer(ref UnityEngine.ComputeBuffer buffer);
            }

            enum ShaderPathID
            {
                Lit = 0,
                SimpleLit = 1,
                Unlit = 2,
                TerrainLit = 3,
                ParticlesLit = 4,
                ParticlesSimpleLit = 5,
                ParticlesUnlit = 6,
                BakedLit = 7,
                SpeedTree7 = 8,
                SpeedTree7Billboard = 9,
                SpeedTree8 = 10,
                SpeedTree9 = 11,
                ComplexLit = 12,
            }

            class ShaderUtils
            {
                static /*0x0*/ string[] s_ShaderPaths;

                static /*0x3c4a158*/ ShaderUtils();
                static /*0x3c49d54*/ string GetShaderPath(UnityEngine.Rendering.Universal.ShaderPathID id);
                static /*0x3c49fa8*/ UnityEngine.Rendering.Universal.ShaderPathID GetEnumFromPath(string path);
                static /*0x3c4a0c0*/ bool IsLWShader(UnityEngine.Shader shader);
                static /*0x3c4a150*/ float get_PersistentDeltaTime();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string path;

                    /*0x3c4a0b8*/ <>c__DisplayClass2_0();
                    /*0x3c4a444*/ bool <GetEnumFromPath>b__0(string m);
                }
            }

            struct URPLightShadowCullingInfos
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.ShadowSliceData> slices;
                /*0x20*/ uint slicesValidMask;

                /*0x3c4a458*/ bool IsSliceValid(int i);
            }

            class ShadowCulling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler computeShadowCasterCullingInfosMarker;

                static /*0x3c4b200*/ ShadowCulling();
                static /*0x3c4a468*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> CullShadowCasters(ref UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullResults);
                static /*0x3c4a54c*/ void ComputeShadowCasterCullingInfos(UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.ShadowCastersCullingInfos shadowCullingInfos, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> urpVisibleLightsShadowCullingInfos);
                static /*0x3c4b1e0*/ UnityEngine.Rendering.BatchCullingProjectionType GetCullingProjectionType(UnityEngine.LightType type);
            }

            struct ShadowSliceData
            {
                /*0x10*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 projectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 shadowTransform;
                /*0xd0*/ int offsetX;
                /*0xd4*/ int offsetY;
                /*0xd8*/ int resolution;
                /*0xdc*/ UnityEngine.Rendering.ShadowSplitData splitData;

                /*0x3c4b29c*/ void Clear();
            }

            class ShadowUtils
            {
                static int kMinimumPunctualLightHardShadowResolution = 8;
                static int kMinimumPunctualLightSoftShadowResolution = 16;
                static /*0x0*/ bool m_ForceShadowPointSampling;

                static /*0x3c4b32c*/ ShadowUtils();
                static /*0x3c4b3f8*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix);
                static /*0x3c4b52c*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x3c4ade0*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x3c4b8b0*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x3c4b0f8*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x3c4b954*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x3c4afc0*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x3c4ba18*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x3c4bb78*/ void RenderShadowSlice(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.RendererList shadowRendererList, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x3c4bcb4*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings);
                static /*0x3c4bd64*/ int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount);
                static /*0x3c4b784*/ void ApplySliceTransform(ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight);
                static /*0x3c4bd90*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, ref UnityEngine.Rendering.Universal.ShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x3c4c1ec*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x3c4be64*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, System.Collections.Generic.List<UnityEngine.Vector4> bias, bool supportsSoftShadows, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x3c4c2a4*/ void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, ref float scale, ref float bias);
                static /*0x3c4c2f8*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x3c4c40c*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x3c4c530*/ void SetShadowBias(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 shadowBias);
                static /*0x3c4c5cc*/ void SetLightDirection(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightDirection);
                static /*0x3c4c664*/ void SetLightPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightPosition);
                static /*0x3c4c6fc*/ void SetCameraPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 worldSpaceCameraPos);
                static /*0x3c4c794*/ void SetWorldToCameraAndCameraToWorldMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix);
                static /*0x3c4c8e0*/ UnityEngine.RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits);
                static /*0x3c4c9e8*/ UnityEngine.RenderTexture GetTemporaryShadowTexture(int width, int height, int bits);
                static /*0x3c4caa8*/ bool ShadowRTNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x3c4cd14*/ UnityEngine.Rendering.RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x3c4ce00*/ bool ShadowRTReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x3c4b604*/ UnityEngine.Matrix4x4 GetShadowTransform(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x3c4cefc*/ float SoftShadowQualityToShaderProperty(UnityEngine.Light light, bool softShadowsEnabled);
                static /*0x3c4d080*/ bool SupportsPerLightSoftShadowQuality();
                static /*0x3c4d088*/ void SetPerLightSoftShadowKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, bool hasSoftShadows);
                static /*0x3c4d118*/ void SetSoftShadowQualityShaderKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x3c4d20c*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i);
                static /*0x3c4d344*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i, UnityEngine.LightType lightType, UnityEngine.LightShadows lightShadows, float shadowStrength);
                static /*0x3c4afa4*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                static /*0x3c4d370*/ bool FastApproximately(float a, float b);
                static /*0x3c4d388*/ bool FastApproximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
                static /*0x3c4d484*/ int MinimalPunctualLightShadowResolution(bool softShadow);
            }

            class SpaceFillingCurves
            {
                static /*0x3c4d498*/ uint Part1By1(uint x);
                static /*0x3c4d4bc*/ uint Compact1By1(uint x);
                static /*0x3c4d4e4*/ uint EncodeMorton2D(Unity.Mathematics.uint2 coord);
                static /*0x3c4d558*/ Unity.Mathematics.uint2 DecodeMorton2D(uint code);
            }

            class StpUtils
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.JitterFunc s_JitterFunc;

                static /*0x3c4deb4*/ StpUtils();
                static /*0x3c4d5b0*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x3c4d62c*/ void PopulateStpConfig(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, int debugViewIndex, UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture, ref UnityEngine.Rendering.STP.Config config);
                static /*0x3c4dbb4*/ void Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture);
            }

            class SupportedOnRendererAttribute : System.Attribute
            {
                /*0x10*/ System.Type[] <rendererTypes>k__BackingField;

                /*0x3c4dff8*/ SupportedOnRendererAttribute(System.Type renderer);
                /*0x3c4e0a4*/ SupportedOnRendererAttribute(System.Type[] renderers);
                /*0x3c4dff0*/ System.Type[] get_rendererTypes();
            }

            enum TemporalAAQuality
            {
                VeryLow = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                VeryHigh = 4,
            }

            class TemporalAA
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.JitterFunc s_JitterFunc;
                static /*0x8*/ UnityEngine.Vector2[] taaFilterOffsets;
                static /*0x10*/ float[] taaFilterWeights;
                static /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] AccumulationFormatList;
                static /*0x20*/ uint s_warnCounter;

                static /*0x3c4fd88*/ TemporalAA();
                static /*0x3c4db98*/ int CalculateTaaFrameIndex(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x3c4e248*/ UnityEngine.Matrix4x4 CalculateJitterMatrix(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.TemporalAA.JitterFunc jitterFunc);
                static /*0x3c4e3ac*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x3c4e40c*/ float[] CalculateFilterWeights(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x3c4e5d4*/ UnityEngine.RenderTextureDescriptor TemporalAADescFromCameraDesc(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                static /*0x3c4e7e8*/ string ValidateAndWarn(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isSTPRequested);
                static /*0x3c4ec4c*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material taaMaterial, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.RenderTexture motionVectors);
                static /*0x3c4f178*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Material taaMaterial, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcDepth, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcMotionVectors, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);

                class ShaderConstants
                {
                    static /*0x0*/ int _TaaAccumulationTex;
                    static /*0x4*/ int _TaaMotionVectorTex;
                    static /*0x8*/ int _TaaFilterWeights;
                    static /*0xc*/ int _TaaFrameInfluence;
                    static /*0x10*/ int _TaaVarianceClampScale;
                    static /*0x14*/ int _CameraDepthTexture;

                    static /*0x3c4ffbc*/ ShaderConstants();
                }

                class ShaderKeywords
                {
                    static /*0x0*/ string TAA_LOW_PRECISION_SOURCE;

                    static /*0x3c5012c*/ ShaderKeywords();
                }

                struct Settings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.TemporalAAQuality m_Quality;
                    /*0x14*/ float m_FrameInfluence;
                    /*0x18*/ float m_JitterScale;
                    /*0x1c*/ float m_MipBias;
                    /*0x20*/ float m_VarianceClampScale;
                    /*0x24*/ float m_ContrastAdaptiveSharpening;
                    /*0x28*/ int resetHistoryFrames;
                    /*0x2c*/ int jitterFrameCountOffset;

                    static /*0x3c5028c*/ UnityEngine.Rendering.Universal.TemporalAA.Settings Create();
                    /*0x3c50194*/ UnityEngine.Rendering.Universal.TemporalAAQuality get_quality();
                    /*0x3c5019c*/ void set_quality(UnityEngine.Rendering.Universal.TemporalAAQuality value);
                    /*0x3c501b4*/ float get_baseBlendFactor();
                    /*0x3c501c4*/ void set_baseBlendFactor(float value);
                    /*0x3c501e8*/ float get_jitterScale();
                    /*0x3c501f0*/ void set_jitterScale(float value);
                    /*0x3c50210*/ float get_mipBias();
                    /*0x3c50218*/ void set_mipBias(float value);
                    /*0x3c50238*/ float get_varianceClampScale();
                    /*0x3c50240*/ void set_varianceClampScale(float value);
                    /*0x3c50264*/ float get_contrastAdaptiveSharpening();
                    /*0x3c5026c*/ void set_contrastAdaptiveSharpening(float value);
                }

                class JitterFunc : System.MulticastDelegate
                {
                    /*0x3c4df50*/ JitterFunc(object object, nint method);
                    /*0x3c502ac*/ void Invoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                    /*0x3c502c0*/ System.IAsyncResult BeginInvoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.AsyncCallback callback, object object);
                    /*0x3c50388*/ void EndInvoke(ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.IAsyncResult result);
                }

                class TaaPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle dstTex;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColorTex;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcDepthTex;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcMotionVectorTex;
                    /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle srcTaaAccumTex;
                    /*0x60*/ UnityEngine.Material material;
                    /*0x68*/ int passIndex;
                    /*0x6c*/ float taaFrameInfluence;
                    /*0x70*/ float taaVarianceClampScale;
                    /*0x78*/ float[] taaFilterWeights;
                    /*0x80*/ bool taaLowPrecisionSource;
                    /*0x81*/ bool taaAlphaOutput;

                    /*0x3c503ac*/ TaaPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x3c503b4*/ <>c();
                    /*0x3c5041c*/ <>c();
                    /*0x3c50424*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c50734*/ void <Render>b__17_1(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            struct InclusiveRange
            {
                /*0x10*/ short start;
                /*0x12*/ short end;

                static /*0x3c509a4*/ UnityEngine.Rendering.Universal.InclusiveRange Merge(UnityEngine.Rendering.Universal.InclusiveRange a, UnityEngine.Rendering.Universal.InclusiveRange b);
                static /*0x3c50a34*/ UnityEngine.Rendering.Universal.InclusiveRange get_empty();
                /*0x3c5083c*/ InclusiveRange(short startEnd);
                /*0x3c50848*/ InclusiveRange(short start, short end);
                /*0x3c50854*/ void Expand(short index);
                /*0x3c508e0*/ void Clamp(short min, short max);
                /*0x3c5096c*/ bool get_isEmpty();
                /*0x3c50980*/ bool Contains(short index);
                /*0x3c50a3c*/ string ToString();
            }

            struct LightMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x3c50ad0*/ void Execute(int index);
            }

            struct ReflectionProbeMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x3c50ff0*/ void Execute(int index);
            }

            struct TileRangeExpansionJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x20*/ Unity.Collections.NativeArray<uint> tileMasks;
                /*0x30*/ int rangesPerItem;
                /*0x34*/ int itemsPerTile;
                /*0x38*/ int wordsPerTile;
                /*0x3c*/ Unity.Mathematics.int2 tileResolution;

                /*0x3c511d8*/ void Execute(int jobIndex);
            }

            enum TileSize
            {
                _8 = 8,
                _16 = 16,
                _32 = 32,
                _64 = 64,
            }

            class TileSizeExtensions
            {
                static /*0x3c513dc*/ bool IsValid(UnityEngine.Rendering.Universal.TileSize tileSize);
            }

            struct TilingJob : Unity.Jobs.IJobFor
            {
                static /*0x0*/ Unity.Mathematics.float3[] k_CubePoints;
                static /*0x8*/ Unity.Mathematics.int4[] k_CubeLineIndices;
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x40*/ int itemsPerTile;
                /*0x44*/ int rangesPerItem;
                /*0x48*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0xc8*/ Unity.Mathematics.float2 tileScale;
                /*0xd0*/ Unity.Mathematics.float2 tileScaleInv;
                /*0xd8*/ UnityEngine.Rendering.Universal.Fixed2<float> viewPlaneBottoms;
                /*0xe0*/ UnityEngine.Rendering.Universal.Fixed2<float> viewPlaneTops;
                /*0xe8*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4> viewToViewportScaleBiases;
                /*0x108*/ Unity.Mathematics.int2 tileCount;
                /*0x110*/ float near;
                /*0x114*/ bool isOrthographic;
                /*0x116*/ UnityEngine.Rendering.Universal.InclusiveRange m_TileYRange;
                /*0x11c*/ int m_Offset;
                /*0x120*/ int m_ViewIndex;
                /*0x124*/ Unity.Mathematics.float2 m_CenterOffset;

                static /*0x3c568f0*/ TilingJob();
                static /*0x3c54710*/ float square(float x);
                static /*0x3c54718*/ void GetSphereHorizon(Unity.Mathematics.float2 center, float radius, float near, float clipRadius, ref Unity.Mathematics.float2 p0, ref Unity.Mathematics.float2 p1);
                static /*0x3c5600c*/ void GetSphereYPlaneHorizon(Unity.Mathematics.float3 center, float sphereRadius, float near, float clipRadius, float y, ref Unity.Mathematics.float3 left, ref Unity.Mathematics.float3 right);
                static /*0x3c54c5c*/ bool GetCircleClipPoints(Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, float circleRadius, float near, ref Unity.Mathematics.float3 p0, ref Unity.Mathematics.float3 p1);
                static /*0x3c56770*/ System.ValueTuple<float, float> IntersectEllipseLine(float a, float b, Unity.Mathematics.float3 line);
                static /*0x3c54a64*/ void GetProjectedCircleHorizon(Unity.Mathematics.float2 center, float radius, Unity.Mathematics.float2 U, Unity.Mathematics.float2 V, ref Unity.Mathematics.float2 uv1, ref Unity.Mathematics.float2 uv2);
                static /*0x3c55914*/ bool IntersectCircleYPlane(float y, Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, float circleRadius, ref Unity.Mathematics.float3 p1, ref Unity.Mathematics.float3 p2);
                static /*0x3c553a4*/ void GetConeSideTangentPoints(Unity.Mathematics.float3 vertex, Unity.Mathematics.float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, ref Unity.Mathematics.float3 l1, ref Unity.Mathematics.float3 l2);
                static /*0x3c550d0*/ Unity.Mathematics.float3 EvaluateNearConic(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float theta);
                static /*0x3c54e60*/ Unity.Mathematics.float2 FindNearConicTangentTheta(Unity.Mathematics.float2 o, Unity.Mathematics.float2 d, float r, Unity.Mathematics.float2 u, Unity.Mathematics.float2 v);
                static /*0x3c55bac*/ Unity.Mathematics.float2 FindNearConicYTheta(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float y);
                static /*0x3c54974*/ bool <TileLight>g__SpherePointIsValid|19_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x3c55288*/ bool <TileLight>g__ConicPointIsValid|19_1(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x3c56508*/ bool <TileLightOrthographic>g__SpherePointIsValid|20_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                /*0x3c513fc*/ void Execute(int jobIndex);
                /*0x3c52168*/ void TileLight(int lightIndex);
                /*0x3c51504*/ void TileLightOrthographic(int lightIndex);
                /*0x3c53d9c*/ void TileReflectionProbe(int index);
                /*0x3c55864*/ Unity.Mathematics.float2 ViewToTileSpace(Unity.Mathematics.float3 positionVS);
                /*0x3c566d0*/ Unity.Mathematics.float2 ViewToTileSpaceOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x3c545f4*/ void ExpandY(Unity.Mathematics.float3 positionVS);
                /*0x3c563ec*/ void ExpandOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x3c565f8*/ void ExpandRangeOrthographic(ref UnityEngine.Rendering.Universal.InclusiveRange range, float xVS);

                struct <>c__DisplayClass19_0
                {
                    /*0x10*/ UnityEngine.Rendering.VisibleLight light;
                    /*0x84*/ Unity.Mathematics.float3 lightPositionVS;
                    /*0x90*/ Unity.Mathematics.float3 lightDirectionVS;
                    /*0x9c*/ float cosHalfAngle;
                    /*0xa0*/ float coneHeight;
                }

                struct <>c__DisplayClass20_0
                {
                    /*0x10*/ UnityEngine.Rendering.VisibleLight light;
                    /*0x84*/ Unity.Mathematics.float3 lightPosVS;
                    /*0x90*/ Unity.Mathematics.float3 lightDirVS;
                    /*0x9c*/ float cosHalfAngle;
                }
            }

            struct ZBinningJob : Unity.Jobs.IJobFor
            {
                static int batchSize = 128;
                static int headerLength = 2;
                /*0x10*/ Unity.Collections.NativeArray<uint> bins;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;
                /*0x30*/ float zBinScale;
                /*0x34*/ float zBinOffset;
                /*0x38*/ int binCount;
                /*0x3c*/ int wordsPerTile;
                /*0x40*/ int lightCount;
                /*0x44*/ int reflectionProbeCount;
                /*0x48*/ int batchCount;
                /*0x4c*/ int viewCount;
                /*0x50*/ bool isOrthographic;

                static /*0x3c56ab0*/ uint EncodeHeader(uint min, uint max);
                static /*0x3c56ab8*/ System.ValueTuple<uint, uint> DecodeHeader(uint zBin);
                /*0x3c56b28*/ void Execute(int jobIndex);
                /*0x3c56c3c*/ void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset);
            }

            enum CameraOverrideOption
            {
                Off = 0,
                On = 1,
                UsePipelineSettings = 2,
            }

            enum RendererOverrideOption
            {
                Custom = 0,
                UsePipelineSettings = 1,
            }

            enum AntialiasingMode
            {
                None = 0,
                FastApproximateAntialiasing = 1,
                SubpixelMorphologicalAntiAliasing = 2,
                TemporalAntiAliasing = 3,
            }

            enum CameraRenderType
            {
                Base = 0,
                Overlay = 1,
            }

            enum AntialiasingQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class CameraExtensions
            {
                static /*0x3c56e60*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData GetUniversalAdditionalCameraData(UnityEngine.Camera camera);
                static /*0x3c56efc*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(UnityEngine.Camera camera);
                static /*0x3c56f18*/ void SetVolumeFrameworkUpdateMode(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode mode);
                static /*0x3c57140*/ void UpdateVolumeStack(UnityEngine.Camera camera);
                static /*0x3c57004*/ void UpdateVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x3c574a0*/ void DestroyVolumeStack(UnityEngine.Camera camera);
                static /*0x3c574b4*/ void DestroyVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x3c5728c*/ void GetVolumeLayerMaskAndTrigger(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData, ref UnityEngine.LayerMask layerMask, ref UnityEngine.Transform trigger);
            }

            class CameraTypeUtility
            {
                static /*0x0*/ string[] s_CameraTypeNames;

                static /*0x3c576f4*/ CameraTypeUtility();
                static /*0x3c57644*/ string GetName(UnityEngine.Rendering.Universal.CameraRenderType type);
            }

            class UniversalAdditionalCameraData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IAdditionalData
            {
                static string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";
                static string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";
                static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData s_DefaultAdditionalCameraData;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeStack> s_CachedVolumeStacks;
                /*0x20*/ bool m_RenderShadows;
                /*0x24*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresDepthTextureOption;
                /*0x28*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresOpaqueTextureOption;
                /*0x2c*/ UnityEngine.Rendering.Universal.CameraRenderType m_CameraType;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;
                /*0x38*/ int m_RendererIndex;
                /*0x3c*/ UnityEngine.LayerMask m_VolumeLayerMask;
                /*0x40*/ UnityEngine.Transform m_VolumeTrigger;
                /*0x48*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption;
                /*0x4c*/ bool m_RenderPostProcessing;
                /*0x50*/ UnityEngine.Rendering.Universal.AntialiasingMode m_Antialiasing;
                /*0x54*/ UnityEngine.Rendering.Universal.AntialiasingQuality m_AntialiasingQuality;
                /*0x58*/ bool m_StopNaN;
                /*0x59*/ bool m_Dithering;
                /*0x5a*/ bool m_ClearDepth;
                /*0x5b*/ bool m_AllowXRRendering;
                /*0x5c*/ bool m_AllowHDROutput;
                /*0x5d*/ bool m_UseScreenCoordOverride;
                /*0x60*/ UnityEngine.Vector4 m_ScreenSizeOverride;
                /*0x70*/ UnityEngine.Vector4 m_ScreenCoordScaleBias;
                /*0x80*/ UnityEngine.Camera m_Camera;
                /*0x88*/ bool m_RequiresDepthTexture;
                /*0x89*/ bool m_RequiresColorTexture;
                /*0x8c*/ float m_Version;
                /*0x90*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData m_MotionVectorsPersistentData;
                /*0x98*/ UnityEngine.Rendering.Universal.UniversalCameraHistory m_History;
                /*0xa0*/ UnityEngine.Rendering.Universal.TemporalAA.Settings m_TaaSettings;
                /*0xc0*/ UnityEngine.Rendering.VolumeStack m_VolumeStack;

                static /*0x3c577d4*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData get_defaultAdditionalCameraData();
                /*0x3c5788c*/ UniversalAdditionalCameraData();
                /*0x3c577cc*/ float get_version();
                /*0x3c579ec*/ UnityEngine.Camera get_camera();
                /*0x3c57a8c*/ void Start();
                /*0x3c57ac0*/ bool get_renderShadows();
                /*0x3c57ac8*/ void set_renderShadows(bool value);
                /*0x3c57ad0*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresDepthOption();
                /*0x3c57ad8*/ void set_requiresDepthOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x3c57ae0*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresColorOption();
                /*0x3c57ae8*/ void set_requiresColorOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x3c57af0*/ UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x3c57af8*/ void set_renderType(UnityEngine.Rendering.Universal.CameraRenderType value);
                /*0x3c4eab8*/ System.Collections.Generic.List<UnityEngine.Camera> get_cameraStack();
                /*0x3c57dec*/ void UpdateCameraStack();
                /*0x3c580e0*/ bool get_clearDepth();
                /*0x3c580e8*/ bool get_requiresDepthTexture();
                /*0x3c5816c*/ void set_requiresDepthTexture(bool value);
                /*0x3c58184*/ bool get_requiresColorTexture();
                /*0x3c58208*/ void set_requiresColorTexture(bool value);
                /*0x3c57b00*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x3c58220*/ void SetRenderer(int index);
                /*0x3c58228*/ UnityEngine.LayerMask get_volumeLayerMask();
                /*0x3c58230*/ void set_volumeLayerMask(UnityEngine.LayerMask value);
                /*0x3c58238*/ UnityEngine.Transform get_volumeTrigger();
                /*0x3c58240*/ void set_volumeTrigger(UnityEngine.Transform value);
                /*0x3c58248*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x3c58250*/ void set_volumeFrameworkUpdateMode(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode value);
                /*0x3c56f80*/ bool get_requiresVolumeFrameworkUpdate();
                /*0x3c58258*/ UnityEngine.Rendering.VolumeStack get_volumeStack();
                /*0x3c5753c*/ void set_volumeStack(UnityEngine.Rendering.VolumeStack value);
                /*0x3c5715c*/ void GetOrCreateVolumeStack();
                /*0x3c58260*/ bool get_renderPostProcessing();
                /*0x3c58268*/ void set_renderPostProcessing(bool value);
                /*0x3c58270*/ UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x3c58278*/ void set_antialiasing(UnityEngine.Rendering.Universal.AntialiasingMode value);
                /*0x3c58280*/ UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x3c58288*/ void set_antialiasingQuality(UnityEngine.Rendering.Universal.AntialiasingQuality value);
                /*0x3c58290*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x3c58298*/ UnityEngine.Rendering.ICameraHistoryReadAccess get_history();
                /*0x3c582a0*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x3c582a8*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData get_motionVectorsPersistentData();
                /*0x3c582b0*/ bool get_resetHistory();
                /*0x3c582c0*/ void set_resetHistory(bool value);
                /*0x3c58304*/ bool get_stopNaN();
                /*0x3c5830c*/ void set_stopNaN(bool value);
                /*0x3c58314*/ bool get_dithering();
                /*0x3c5831c*/ void set_dithering(bool value);
                /*0x3c58324*/ bool get_allowXRRendering();
                /*0x3c5832c*/ void set_allowXRRendering(bool value);
                /*0x3c58334*/ bool get_useScreenCoordOverride();
                /*0x3c5833c*/ void set_useScreenCoordOverride(bool value);
                /*0x3c58344*/ UnityEngine.Vector4 get_screenSizeOverride();
                /*0x3c58350*/ void set_screenSizeOverride(UnityEngine.Vector4 value);
                /*0x3c5835c*/ UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x3c58368*/ void set_screenCoordScaleBias(UnityEngine.Vector4 value);
                /*0x3c58374*/ bool get_allowHDROutput();
                /*0x3c5837c*/ void set_allowHDROutput(bool value);
                /*0x3c58384*/ void OnBeforeSerialize();
                /*0x3c58388*/ void OnAfterDeserialize();
                /*0x3c583b0*/ void OnValidate();
                /*0x3c58444*/ void OnDrawGizmos();
                /*0x3c5855c*/ void OnDestroy();
                /*0x3c585c4*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRawRenderer();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Camera> <>9__53_0;

                    static /*0x3c588b8*/ <>c();
                    /*0x3c58920*/ <>c();
                    /*0x3c58928*/ bool <UpdateCameraStack>b__53_0(UnityEngine.Camera cam);
                }
            }

            enum LightLayerEnum
            {
                Nothing = 0,
                LightLayerDefault = 1,
                LightLayer1 = 2,
                LightLayer2 = 4,
                LightLayer3 = 8,
                LightLayer4 = 16,
                LightLayer5 = 32,
                LightLayer6 = 64,
                LightLayer7 = 128,
                Everything = 255,
            }

            class LightExtensions
            {
                static /*0x3c58984*/ UnityEngine.Rendering.Universal.UniversalAdditionalLightData GetUniversalAdditionalLightData(UnityEngine.Light light);
            }

            class UniversalAdditionalLightData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IAdditionalData
            {
                static /*0x0*/ int AdditionalLightsShadowResolutionTierCustom;
                static /*0x4*/ int AdditionalLightsShadowResolutionTierLow;
                static /*0x8*/ int AdditionalLightsShadowResolutionTierMedium;
                static /*0xc*/ int AdditionalLightsShadowResolutionTierHigh;
                static /*0x10*/ int AdditionalLightsShadowDefaultResolutionTier;
                static /*0x14*/ int AdditionalLightsShadowDefaultCustomResolution;
                static /*0x18*/ int AdditionalLightsShadowMinimumResolution;
                /*0x20*/ int m_Version;
                /*0x24*/ bool m_UsePipelineSettings;
                /*0x28*/ UnityEngine.Light m_Light;
                /*0x30*/ int m_AdditionalLightsShadowResolutionTier;
                /*0x34*/ UnityEngine.Rendering.Universal.LightLayerEnum m_LightLayerMask;
                /*0x38*/ uint m_RenderingLayers;
                /*0x3c*/ bool m_CustomShadowLayers;
                /*0x40*/ UnityEngine.Rendering.Universal.LightLayerEnum m_ShadowLayerMask;
                /*0x44*/ uint m_ShadowRenderingLayers;
                /*0x48*/ UnityEngine.Vector2 m_LightCookieSize;
                /*0x50*/ UnityEngine.Vector2 m_LightCookieOffset;
                /*0x58*/ UnityEngine.Rendering.Universal.SoftShadowQuality m_SoftShadowQuality;

                static /*0x3c58de4*/ UniversalAdditionalLightData();
                /*0x3c58cfc*/ UniversalAdditionalLightData();
                /*0x3c58a20*/ int get_version();
                /*0x3c58a28*/ bool get_usePipelineSettings();
                /*0x3c58a30*/ void set_usePipelineSettings(bool value);
                /*0x3c58a38*/ UnityEngine.Light get_light();
                /*0x3c58ac8*/ int get_additionalLightsShadowResolutionTier();
                /*0x3c58ad0*/ UnityEngine.Rendering.Universal.LightLayerEnum get_lightLayerMask();
                /*0x3c58ad8*/ void set_lightLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x3c58ae0*/ uint get_renderingLayers();
                /*0x3c58ae8*/ void set_renderingLayers(uint value);
                /*0x3c58ba8*/ bool get_customShadowLayers();
                /*0x3c58bb0*/ void set_customShadowLayers(bool value);
                /*0x3c58bcc*/ UnityEngine.Rendering.Universal.LightLayerEnum get_shadowLayerMask();
                /*0x3c58bd4*/ void set_shadowLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x3c58bdc*/ uint get_shadowRenderingLayers();
                /*0x3c58be4*/ void set_shadowRenderingLayers(uint value);
                /*0x3c58bfc*/ UnityEngine.Vector2 get_lightCookieSize();
                /*0x3c58c04*/ void set_lightCookieSize(UnityEngine.Vector2 value);
                /*0x3c58c0c*/ UnityEngine.Vector2 get_lightCookieOffset();
                /*0x3c58c14*/ void set_lightCookieOffset(UnityEngine.Vector2 value);
                /*0x3c58c1c*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x3c58c24*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x3c58c2c*/ void OnBeforeSerialize();
                /*0x3c58c30*/ void OnAfterDeserialize();
                /*0x3c58b00*/ void SyncLightAndShadowLayers();
            }

            class UniversalCameraHistory : UnityEngine.Rendering.ICameraHistoryReadAccess, UnityEngine.Rendering.ICameraHistoryWriteAccess, UnityEngine.Rendering.IPerFrameHistoryAccessTracker, System.IDisposable
            {
                static int k_ValidVersionCount = 2;
                static /*0x0*/ uint s_TypeCount;
                /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraHistory.Item[] m_Items;
                /*0x18*/ int m_Version;
                /*0x20*/ UnityEngine.Rendering.BufferedRTHandleSystem m_HistoryTextures;
                /*0x28*/ UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate OnGatherHistoryRequests;

                /*0x3c587a8*/ UniversalCameraHistory();
                /*0x1f309e4*/ void RequestAccess<Type>();
                /*0x1ffc854*/ Type GetHistoryForRead<Type>();
                /*0x1f2fe14*/ bool IsAccessRequested<Type>();
                /*0x1ffc854*/ Type GetHistoryForWrite<Type>();
                /*0x1f2fe14*/ bool IsWritten<Type>();
                /*0x3c58e48*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x3c58ee4*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x3c58718*/ void Dispose();
                /*0x3c58fac*/ void GatherHistoryRequests();
                /*0x3c58fcc*/ bool IsValidRequest(int i);
                /*0x3c5900c*/ bool IsValid(int i);
                /*0x3c5904c*/ void ReleaseUnusedHistory();
                /*0x3c59108*/ void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight);

                class TypeId<T>
                {
                    static /*0x0*/ uint value;

                    static /*0x1f33998*/ TypeId();
                }

                struct Item
                {
                    /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                    /*0x18*/ int requestVersion;
                    /*0x1c*/ int writeVersion;

                    /*0x3c58f80*/ void Reset();
                }
            }

            enum RenderingMode
            {
                Forward = 0,
                ForwardPlus = 2,
                Deferred = 1,
            }

            enum DepthPrimingMode
            {
                Disabled = 0,
                Auto = 1,
                Forced = 2,
            }

            class UniversalRenderer : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static UnityEngine.Experimental.Rendering.GraphicsFormat k_DepthStencilFormatDefault = 92;
                static int k_FinalBlitPassQueueOffset = 1;
                static int k_AfterFinalBlitPassQueueOffset = 2;
                static string _CameraTargetAttachmentAName = "_CameraTargetAttachmentA";
                static string _CameraTargetAttachmentBName = "_CameraTargetAttachmentB";
                static string _SingleCameraTargetAttachmentName = "_CameraTargetAttachment";
                static string _CameraDepthAttachmentName = "_CameraDepthAttachment";
                static string _CameraColorUpscaled = "_CameraColorUpscaled";
                static string _CameraColorAfterPostProcessingName = "_CameraColorAfterPostProcessing";
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormalsOnly;
                static /*0x8*/ UnityEngine.Rendering.RTHandle[] m_RenderGraphCameraColorHandles;
                static /*0x10*/ UnityEngine.Rendering.RTHandle m_RenderGraphCameraDepthHandle;
                static /*0x18*/ int m_CurrentColorHandle;
                static /*0x20*/ UnityEngine.Rendering.RTHandle m_RenderGraphDebugTextureHandle;
                static /*0x28*/ bool m_RequiresIntermediateAttachments;
                /*0x143*/ bool m_Clustering;
                /*0x148*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass m_DepthPrepass;
                /*0x150*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass m_DepthNormalPrepass;
                /*0x158*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_PrimedDepthCopyPass;
                /*0x160*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass m_MotionVectorPass;
                /*0x168*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass m_MainLightShadowCasterPass;
                /*0x170*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                /*0x178*/ UnityEngine.Rendering.Universal.Internal.GBufferPass m_GBufferPass;
                /*0x180*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_GBufferCopyDepthPass;
                /*0x188*/ UnityEngine.Rendering.Universal.Internal.DeferredPass m_DeferredPass;
                /*0x190*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardOnlyPass;
                /*0x198*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardPass;
                /*0x1a0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass;
                /*0x1a8*/ UnityEngine.Rendering.Universal.DrawSkyboxPass m_DrawSkyboxPass;
                /*0x1b0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_CopyDepthPass;
                /*0x1b8*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass m_CopyColorPass;
                /*0x1c0*/ UnityEngine.Rendering.Universal.TransparentSettingsPass m_TransparentSettingsPass;
                /*0x1c8*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderTransparentForwardPass;
                /*0x1d0*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;
                /*0x1d8*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass m_FinalBlitPass;
                /*0x1e0*/ UnityEngine.Rendering.Universal.CapturePass m_CapturePass;
                /*0x1e8*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOffscreenUIPass;
                /*0x1f0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOverlayUIPass;
                /*0x1f8*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass m_HistoryRawColorCopyPass;
                /*0x200*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_HistoryRawDepthCopyPass;
                /*0x208*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem m_ColorBufferSystem;
                /*0x210*/ UnityEngine.Rendering.RTHandle m_ActiveCameraColorAttachment;
                /*0x218*/ UnityEngine.Rendering.RTHandle m_ColorFrontBuffer;
                /*0x220*/ UnityEngine.Rendering.RTHandle m_ActiveCameraDepthAttachment;
                /*0x228*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment;
                /*0x230*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment_D3d_11;
                /*0x238*/ UnityEngine.Rendering.RTHandle m_TargetColorHandle;
                /*0x240*/ UnityEngine.Rendering.RTHandle m_TargetDepthHandle;
                /*0x248*/ UnityEngine.Rendering.RTHandle m_DepthTexture;
                /*0x250*/ UnityEngine.Rendering.RTHandle m_NormalsTexture;
                /*0x258*/ UnityEngine.Rendering.RTHandle m_DecalLayersTexture;
                /*0x260*/ UnityEngine.Rendering.RTHandle m_OpaqueColor;
                /*0x268*/ UnityEngine.Rendering.RTHandle m_MotionVectorColor;
                /*0x270*/ UnityEngine.Rendering.RTHandle m_MotionVectorDepth;
                /*0x278*/ UnityEngine.Rendering.Universal.Internal.ForwardLights m_ForwardLights;
                /*0x280*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x288*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x28c*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x290*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x294*/ UnityEngine.Rendering.Universal.DepthFormat m_CameraDepthAttachmentFormat;
                /*0x298*/ UnityEngine.Rendering.Universal.DepthFormat m_CameraDepthTextureFormat;
                /*0x29c*/ bool m_DepthPrimingRecommended;
                /*0x29d*/ UnityEngine.Rendering.StencilState m_DefaultStencilState;
                /*0x2b0*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                /*0x2b8*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;
                /*0x2bc*/ bool m_VulkanEnablePreTransform;
                /*0x2c0*/ UnityEngine.Material m_BlitMaterial;
                /*0x2c8*/ UnityEngine.Material m_BlitHDRMaterial;
                /*0x2d0*/ UnityEngine.Material m_SamplingMaterial;
                /*0x2d8*/ UnityEngine.Material m_StencilDeferredMaterial;
                /*0x2e0*/ UnityEngine.Material m_CameraMotionVecMaterial;
                /*0x2e8*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;
                /*0x328*/ UnityEngine.LayerMask <opaqueLayerMask>k__BackingField;
                /*0x32c*/ UnityEngine.LayerMask <transparentLayerMask>k__BackingField;
                /*0x330*/ bool <shadowTransparentReceive>k__BackingField;
                /*0x338*/ UnityEngine.Material m_DebugBlitMaterial;
                /*0x340*/ bool m_RequiresRenderingLayer;
                /*0x344*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event m_RenderingLayersEvent;
                /*0x348*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize m_RenderingLayersMaskSize;
                /*0x34c*/ bool m_RenderingLayerProvidesRenderObjectPass;
                /*0x34d*/ bool m_RenderingLayerProvidesByDepthNormalPass;
                /*0x350*/ string m_RenderingLayersTextureName;
                /*0x358*/ bool m_IssuedGPUOcclusionUnsupportedMsg;

                static /*0x3c65f34*/ UniversalRenderer();
                static /*0x3c5abd0*/ bool IsOffscreenDepthTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x3c5ac38*/ bool IsOffscreenDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c5f1e8*/ bool PlatformRequiresExplicitMsaaResolve();
                static /*0x3c60754*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                static /*0x3c608a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.Color color, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool discardOnLastUse);
                static /*0x3c65f1c*/ void <OnAfterRendering>g__MakeCompatible|197_1(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3c59284*/ UniversalRenderer(UnityEngine.Rendering.Universal.UniversalRendererData data);
                /*0x3c59120*/ int SupportedCameraStackingTypes();
                /*0x3c59144*/ bool SupportsMotionVectors();
                /*0x3c5914c*/ bool SupportsCameraOpaque();
                /*0x3c59154*/ bool SupportsCameraNormals();
                /*0x3c5915c*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeRequested();
                /*0x3c59164*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeActual();
                /*0x3c591d4*/ bool get_accurateGbufferNormals();
                /*0x3c591f4*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x3c591fc*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x3c59204*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x3c5920c*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x3c59214*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x3c5921c*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x3c59224*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x3c5922c*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x3c59234*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x3c5923c*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x3c59244*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x3c5924c*/ bool get_shadowTransparentReceive();
                /*0x3c59254*/ void set_shadowTransparentReceive(bool value);
                /*0x3c5925c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthTextureFormat();
                /*0x3c59270*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthAttachmentFormat();
                /*0x3c5a41c*/ void Dispose(bool disposing);
                /*0x3c5a6e0*/ void ReleaseRenderTargets();
                /*0x3c5a7d8*/ void SetupFinalPassDebug(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5acc8*/ bool IsDepthPrimingEnabled(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5ae88*/ bool IsWebGL();
                /*0x3c5ae90*/ bool IsGLESDevice();
                /*0x3c5aeac*/ bool IsGLDevice();
                /*0x3c5aee0*/ bool HasActiveRenderFeatures();
                /*0x3c5b0ac*/ bool HasPassesRequiringIntermediateTexture();
                /*0x3c5b278*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c5ea5c*/ void SetupVFXCameraBuffer(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5e770*/ void SetupRawColorDepthHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.RenderTextureDescriptor cameraTargetDescriptor);
                /*0x3c5ecb4*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x3c5ee8c*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3c5f1a8*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c5e618*/ void EnqueueDeferred(UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow);
                /*0x3c5dbec*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera);
                /*0x3c5e050*/ void CreateCameraRenderTarget(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5dea0*/ bool RequiresIntermediateColorTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x3c5adb0*/ bool CanCopyDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5f25c*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c5f418*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c5f430*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c5f448*/ void EnableSwapBufferMSAA(bool enable);
                /*0x3c5f464*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x3c5f46c*/ bool DebugHandlerRequireDepthPass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c5f4dc*/ void CreateDebugTexture(UnityEngine.RenderTextureDescriptor descriptor);
                /*0x3c5f5e4*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, float width, float height);
                /*0x3c5f618*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, int textureHeightPercent);
                /*0x3c5ab90*/ void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight);
                /*0x3c5f670*/ void SetupRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c60024*/ void SetupAfterPostRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c5fd5c*/ void BlitToDebugTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool isSourceTextureColor);
                /*0x3c60230*/ void BlitEmptyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, string passName);
                /*0x3c6061c*/ UnityEngine.Rendering.RTHandle get_currentRenderGraphCameraColorHandle();
                /*0x3c606bc*/ UnityEngine.Rendering.RTHandle get_nextRenderGraphCameraColorHandle();
                /*0x3c5a5c4*/ void CleanupRenderGraphResources();
                /*0x3c60a10*/ bool ShouldApplyPostProcessing(bool postProcessEnabled);
                /*0x3c60a28*/ bool CameraHasPostProcessingWithDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c60a6c*/ bool RequiresIntermediateAttachments(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x3c5db84*/ void UpdateCameraHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c60d24*/ void CreateRenderGraphCameraRenderTargets(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isCameraTargetOffscreenDepth);
                /*0x3c627a8*/ void SetupRenderingLayers(int msaaSamples);
                /*0x3c62828*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x3c628ac*/ void RenderRawColorDepthHistory(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x3c62c94*/ void OnBeginRenderGraphFrame();
                /*0x3c62cf0*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x3c64f68*/ void OnEndRenderGraphFrame();
                /*0x3c64fc4*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3c65034*/ bool get_supportsGPUOcclusion();
                /*0x3c62f8c*/ void OnOffscreenDepthTextureRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x3c6335c*/ void OnBeforeRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3c650dc*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture);
                /*0x3c654f4*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.OcclusionTest occlusionTest);
                /*0x3c65748*/ void RecordCustomPassesWithDepthCopyAndMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, UnityEngine.Rendering.Universal.RenderPassEvent currentEvent, bool renderMotionVectors);
                /*0x3c65834*/ bool AllowPartialDepthNormalsPrepass(bool isDeferred, UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalEvent);
                /*0x3c65848*/ UnityEngine.Rendering.Universal.UniversalRenderer.DepthCopySchedule CalculateDepthCopySchedule(UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass);
                /*0x3c658a0*/ UnityEngine.Rendering.Universal.UniversalRenderer.TextureCopySchedules CalculateTextureCopySchedules(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass);
                /*0x3c659f0*/ void CopyDepthToDepthTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x3c65ab0*/ void RenderMotionVectors(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x3c657e4*/ void ExecuteScheduledDepthCopyWithMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, bool renderMotionVectors);
                /*0x3c6360c*/ void OnMainRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x3c643b4*/ void OnAfterRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3c60ba0*/ bool RequireDepthPrepass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x3c60c40*/ bool RequireDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool requiresDepthPrepass, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x3c65d20*/ void SetRenderingLayersGlobalTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3c61dbc*/ void CreateCameraDepthCopyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor, bool isDepthTexture);
                /*0x3c6217c*/ void CreateMotionVectorTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x3c61f48*/ void CreateCameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x3c62390*/ void CreateRenderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x3c625f4*/ void CreateAfterPostProcessTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x3c65b60*/ void DepthNormalPrepassRender(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                class Profiling
                {
                    static string k_Name = "UniversalRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler createCameraRenderTarget;

                    static /*0x3c661d4*/ Profiling();
                }

                struct RenderPassInputSummary
                {
                    /*0x10*/ bool requiresDepthTexture;
                    /*0x11*/ bool requiresDepthPrepass;
                    /*0x12*/ bool requiresNormalsTexture;
                    /*0x13*/ bool requiresColorTexture;
                    /*0x14*/ bool requiresColorTextureCreated;
                    /*0x15*/ bool requiresMotionVectors;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalAtEvent;
                    /*0x1c*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthTextureEarliestEvent;
                }

                class CopyToDebugTexturePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle src;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle dest;

                    /*0x3c66270*/ CopyToDebugTexturePassData();
                }

                enum DepthCopySchedule
                {
                    DuringPrepass = 0,
                    AfterPrepass = 1,
                    AfterGBuffer = 2,
                    AfterOpaques = 3,
                    AfterSkybox = 4,
                    AfterTransparents = 5,
                    None = 6,
                }

                enum ColorCopySchedule
                {
                    AfterSkybox = 0,
                    None = 1,
                }

                struct TextureCopySchedules
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderer.DepthCopySchedule depth;
                    /*0x14*/ UnityEngine.Rendering.Universal.UniversalRenderer.ColorCopySchedule color;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderer.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__113_0;
                    static /*0x10*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__113_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.UniversalRenderer.CopyToDebugTexturePassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__142_0;
                    static /*0x20*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__197_0;

                    static /*0x3c66278*/ <>c();
                    /*0x3c662e0*/ <>c();
                    /*0x3c662e8*/ bool <Setup>b__113_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x3c66304*/ bool <Setup>b__113_1(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x3c66334*/ void <BlitEmptyTexture>b__142_0(UnityEngine.Rendering.Universal.UniversalRenderer.CopyToDebugTexturePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x3c663fc*/ bool <OnAfterRendering>b__197_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                }
            }

            enum CopyDepthMode
            {
                AfterOpaques = 0,
                AfterTransparents = 1,
                ForcePrepass = 2,
            }

            enum RenderPathCompatibility
            {
                Forward = 1,
                Deferred = 2,
                ForwardPlus = 4,
                All = 7,
            }

            class RenderPathCompatibleAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Rendering.Universal.RenderPathCompatibility renderPath;

                /*0x3c66418*/ RenderPathCompatibleAttribute(UnityEngine.Rendering.Universal.RenderPathCompatibility renderPath);
            }

            enum DepthFormat
            {
                Default = 0,
                Depth_16 = 90,
                Depth_24 = 91,
                Depth_32 = 93,
                Depth_16_Stencil_8 = 151,
                Depth_24_Stencil_8 = 92,
                Depth_32_Stencil_8 = 94,
            }

            enum UniversalResource
            {
                BackBufferColor = 0,
                BackBufferDepth = 1,
                CameraColor = 2,
                CameraDepth = 3,
                MainShadowsTexture = 4,
                AdditionalShadowsTexture = 5,
                GBuffer0 = 6,
                GBuffer1 = 7,
                GBuffer2 = 8,
                GBuffer3 = 9,
                GBuffer4 = 10,
                GBuffer5 = 11,
                GBuffer6 = 12,
                CameraOpaqueTexture = 13,
                CameraDepthTexture = 14,
                CameraNormalsTexture = 15,
                MotionVectorColor = 16,
                MotionVectorDepth = 17,
                InternalColorLut = 18,
                DebugScreenColor = 19,
                DebugScreenDepth = 20,
                AfterPostProcessColor = 21,
                OverlayUITexture = 22,
                RenderingLayersTexture = 23,
                DBuffer0 = 24,
                DBuffer1 = 25,
                DBuffer2 = 26,
                DBufferDepth = 27,
                SSAOTexture = 28,
            }

            class RenderGraphUtils
            {
                static int GBufferSize = 7;
                static int DBufferSize = 3;
                static int LightTextureSize = 4;
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_SetGlobalTextureProfilingSampler;

                static /*0x3c66aec*/ RenderGraphUtils();
                static /*0x3c66440*/ void UseDBufferIfValid(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                static /*0x3c6661c*/ void SetGlobalTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, int nameId, UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, string passName, string file, int line);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle texture;
                    /*0x20*/ int nameID;

                    /*0x3c66b88*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderGraphUtils.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderGraphUtils.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                    static /*0x3c66b90*/ <>c();
                    /*0x3c66bf8*/ <>c();
                    /*0x3c66c00*/ void <SetGlobalTexture>b__6_0(UnityEngine.Rendering.Universal.RenderGraphUtils.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class ClearTargetsPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_ClearProfilingSampler;

                static /*0x3c6738c*/ ClearTargetsPass();
                static /*0x3c66c04*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c66d00*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color clearColor);
                /*0x3c67384*/ ClearTargetsPass();

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                    /*0x30*/ UnityEngine.Rendering.RTClearFlags clearFlags;
                    /*0x34*/ UnityEngine.Color clearColor;

                    /*0x3c67428*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ClearTargetsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ClearTargetsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__3_0;

                    static /*0x3c67430*/ <>c();
                    /*0x3c67498*/ <>c();
                    /*0x3c674a0*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.ClearTargetsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class UniversalRenderPipeline : UnityEngine.Rendering.RenderPipeline
            {
                static string k_ShaderTagName = "UniversalPipeline";
                static int k_DefaultRenderingLayerMask = 1;
                static /*0x0*/ bool cameraStackRequiresDepthForPostprocessing;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph s_RenderGraph;
                static /*0x10*/ UnityEngine.Rendering.Universal.RTHandleResourcePool s_RTHandlePool;
                static /*0x18*/ bool useRenderGraph;
                static /*0x19*/ bool <canOptimizeScreenMSAASamples>k__BackingField;
                static /*0x1c*/ int <startFrameScreenMSAASamples>k__BackingField;
                static /*0x20*/ UnityEngine.Vector4 k_DefaultLightPosition;
                static /*0x30*/ UnityEngine.Vector4 k_DefaultLightColor;
                static /*0x40*/ UnityEngine.Vector4 k_DefaultLightAttenuation;
                static /*0x50*/ UnityEngine.Vector4 k_DefaultLightSpotDirection;
                static /*0x60*/ UnityEngine.Vector4 k_DefaultLightsProbeChannel;
                static /*0x70*/ System.Collections.Generic.List<UnityEngine.Vector4> m_ShadowBiasData;
                static /*0x78*/ System.Collections.Generic.List<int> m_ShadowResolutionData;
                static /*0x80*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate lightsDelegate;
                /*0x18*/ UnityEngine.Rendering.DebugDisplaySettingsUI m_DebugDisplaySettingsUI;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings m_GlobalSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures <runtimeTextures>k__BackingField;
                /*0x30*/ bool apvIsEnabled;
                /*0x38*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset;
                /*0x40*/ bool enableHDROnce;
                /*0x48*/ System.Comparison<UnityEngine.Camera> cameraComparison;

                static /*0x3c72840*/ UniversalRenderPipeline();
                static /*0x3c674d8*/ float get_maxShadowBias();
                static /*0x3c674e0*/ float get_minRenderScale();
                static /*0x3c674ec*/ float get_maxRenderScale();
                static /*0x3c674f4*/ int get_maxNumIterationsEnclosingSphere();
                static /*0x3c674fc*/ int get_maxPerObjectLights();
                static /*0x3c67504*/ int get_maxVisibleAdditionalLights();
                static /*0x3c67610*/ int get_lightsPerTile();
                static /*0x3c67674*/ int get_maxZBinWords();
                static /*0x3c6767c*/ int get_maxTileWords();
                static /*0x3c676dc*/ int get_maxVisibleReflectionProbes();
                static /*0x3c6777c*/ bool get_canOptimizeScreenMSAASamples();
                static /*0x3c677d4*/ void set_canOptimizeScreenMSAASamples(bool value);
                static /*0x3c67834*/ int get_startFrameScreenMSAASamples();
                static /*0x3c6788c*/ void set_startFrameScreenMSAASamples(int value);
                static /*0x3c6c058*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x3c6bf84*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, bool isLastBaseCamera);
                static /*0x3c6c0c0*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, ref UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool isLastBaseCamera);
                static /*0x3c6e6dc*/ bool TryGetCullingParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                static /*0x3c6d334*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c701d0*/ void CreateShadowAtlasAndCullShadowCasters(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.ScriptableRenderContext context);
                static /*0x3c6a820*/ void RenderCameraStack(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera baseCamera, bool isLastBaseCamera);
                static /*0x3c707ac*/ void UpdateCameraData(UnityEngine.Rendering.Universal.UniversalCameraData baseCameraData, ref UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x3c6bc84*/ void UpdateVolumeFramework(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x3c70b44*/ bool CheckPostProcessForDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c706d8*/ bool CheckPostProcessForDepth();
                static /*0x3c681a0*/ void SetSupportedRenderingFeatures(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset);
                static /*0x3c6c4ec*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x3c6c5d4*/ UnityEngine.Rendering.Universal.UniversalCameraData CreateCameraData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget);
                static /*0x3c70bd4*/ void InitializeStackedCameraData(UnityEngine.Camera baseCamera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData baseAdditionalCameraData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c6cb3c*/ void InitializeAdditionalCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, bool isLastBaseCamera, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c6fda0*/ UnityEngine.Rendering.Universal.UniversalRenderingData CreateRenderingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, UnityEngine.Rendering.CommandBuffer cmd, bool isForwardPlus, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x3c6f05c*/ UnityEngine.Rendering.Universal.UniversalShadowData CreateShadowData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset, bool isForwardPlus);
                static /*0x3c71a9c*/ UnityEngine.Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset);
                static /*0x3c70404*/ void InitializeMainLightShadowResolution(UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x3c6fccc*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData CreatePostProcessingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings);
                static /*0x3c6ed50*/ UnityEngine.Rendering.Universal.UniversalResourceData CreateUniversalResourceData(UnityEngine.Rendering.ContextContainer frameData);
                static /*0x3c6eda0*/ UnityEngine.Rendering.Universal.UniversalLightData CreateLightData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x3c71870*/ void ApplyTaaRenderingDebugOverrides(ref UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings);
                static /*0x3c71740*/ void UpdateTemporalAAData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x3c6ec88*/ void UpdateTemporalAATargets(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c707a4*/ void UpdateCameraStereoMatrices(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x3c71944*/ UnityEngine.Rendering.PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus, bool reflectionProbeBlending);
                static /*0x3c71afc*/ int GetMainLightIndex(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x3c6e8cc*/ void SetupPerCameraShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x3c6ffcc*/ void CheckAndApplyDebugSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x3c715a0*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter ResolveUpscalingFilterSelection(UnityEngine.Vector2 imageSize, float renderScale, UnityEngine.Rendering.Universal.UpscalingFilterSelection selection, bool enableRenderGraph);
                static /*0x3c705f8*/ bool HDROutputForMainDisplayIsActive();
                static /*0x3c71f94*/ bool HDROutputForAnyDisplayIsActive();
                static /*0x3c71fe0*/ void GetHDROutputLuminanceParameters(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x3c720d0*/ void GetHDROutputGradingParameters(UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x3c7049c*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x3c69fa8*/ void AdjustUIOverlayOwnership(int cameraCount);
                static /*0x3c6a068*/ void SetupScreenMSAASamplesState(int cameraCount);
                static /*0x3c6a744*/ bool IsGameCamera(UnityEngine.Camera camera);
                static /*0x3c6a540*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset get_asset();
                static /*0x3c71f2c*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha);
                static /*0x3c72198*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeUnormRenderTextureGraphicsFormat();
                static /*0x3c71304*/ UnityEngine.RenderTextureDescriptor CreateRenderTextureDescriptor(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture);
                static /*0x3c721c4*/ void GetLightAttenuationAndSpotDirection(UnityEngine.LightType lightType, float lightRange, UnityEngine.Matrix4x4 lightLocalToWorldMatrix, float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x3c72314*/ void GetPunctualLightDistanceAttenuation(float lightRange, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x3c72384*/ void GetSpotAngleAttenuation(float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x3c72350*/ void GetSpotDirection(ref UnityEngine.Matrix4x4 lightLocalToWorldMatrix, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x3c724c4*/ void InitializeLightConstants_Common(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel);
                static /*0x3c7281c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x3c702f8*/ void RecordAndExecuteRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, string cameraName);
                /*0x3c67900*/ UniversalRenderPipeline(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset);
                /*0x3c67764*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures get_runtimeTextures();
                /*0x3c6776c*/ void set_runtimeTextures(UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures value);
                /*0x3c67774*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();
                /*0x3c678e8*/ string ToString();
                /*0x3c69538*/ void Dispose(bool disposing);
                /*0x3c69830*/ void DisposeAdditionalCameraData();
                /*0x3c698ec*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Camera[] cameras);
                /*0x3c69984*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x1ffc854*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
                /*0x1ffc854*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
                /*0x3c6a24c*/ void SetupPerFrameShaderConstants();
                /*0x3c69e68*/ void SetHDRState(System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x3c6a5e0*/ void SortCameras(System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x3c6a65c*/ int GetLastBaseCameraIndex(System.Collections.Generic.List<UnityEngine.Camera> cameras);

                class CameraMetadataCache
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry> s_MetadataCache;
                    static /*0x8*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry k_NoAllocEntry;

                    static /*0x3c72a08*/ CameraMetadataCache();
                    static /*0x3c6e704*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry GetCached(UnityEngine.Camera camera);

                    class CameraMetadataCacheEntry
                    {
                        /*0x10*/ string name;
                        /*0x18*/ UnityEngine.Rendering.ProfilingSampler sampler;

                        /*0x3c72a00*/ CameraMetadataCacheEntry();
                    }
                }

                class Profiling
                {
                    class Pipeline
                    {
                        static string k_Name = "UniversalRenderPipeline";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler initializeCameraData;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler initializeStackedCameraData;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler initializeAdditionalCameraData;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler initializeRenderingData;
                        static /*0x20*/ UnityEngine.Rendering.ProfilingSampler initializeShadowData;
                        static /*0x28*/ UnityEngine.Rendering.ProfilingSampler initializeLightData;
                        static /*0x30*/ UnityEngine.Rendering.ProfilingSampler buildAdditionalLightsShadowAtlasLayout;
                        static /*0x38*/ UnityEngine.Rendering.ProfilingSampler getPerObjectLightFlags;
                        static /*0x40*/ UnityEngine.Rendering.ProfilingSampler getMainLightIndex;
                        static /*0x48*/ UnityEngine.Rendering.ProfilingSampler setupPerFrameShaderConstants;
                        static /*0x50*/ UnityEngine.Rendering.ProfilingSampler setupPerCameraShaderConstants;

                        static /*0x3c72b44*/ Pipeline();

                        class Renderer
                        {
                            static string k_Name = "ScriptableRenderer";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setupCullingParameters;
                            static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setup;

                            static /*0x3c72e78*/ Renderer();
                        }

                        class Context
                        {
                            static string k_Name = "ScriptableRenderContext";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler submit;

                            static /*0x3c72f54*/ Context();
                        }
                    }
                }

                struct CameraRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginCameraRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endCameraRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ UnityEngine.Camera m_Camera;

                    static /*0x3c730d4*/ CameraRenderingScope();
                    /*0x3c6bb74*/ CameraRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x3c72ff0*/ void Dispose();
                }

                struct ContextRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginContextRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endContextRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;

                    static /*0x3c73294*/ ContextRenderingScope();
                    /*0x3c6a144*/ ContextRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                    /*0x3c731b0*/ void Dispose();
                }

                class SingleCameraRequest
                {
                    /*0x10*/ UnityEngine.RenderTexture destination;
                    /*0x18*/ int mipLevel;
                    /*0x1c*/ UnityEngine.CubemapFace face;
                    /*0x20*/ int slice;

                    /*0x3c73370*/ SingleCameraRequest();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Camera> <>9__47_0;

                    static /*0x3c73380*/ <>c();
                    /*0x3c733e8*/ <>c();
                    /*0x3c733f0*/ int <.ctor>b__47_0(UnityEngine.Camera camera1, UnityEngine.Camera camera2);
                    /*0x3c73458*/ void <.cctor>b__123_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }

            class NativeArrayExtensions
            {
                static /*0x1ffc854*/ ref T UnsafeElementAt<T>(Unity.Collections.NativeArray<T> array, int index);
                static /*0x1ffc854*/ ref T UnsafeElementAtMutable<T>(Unity.Collections.NativeArray<T> array, int index);
            }

            enum MixedLightingSetup
            {
                None = 0,
                ShadowMask = 1,
                Subtractive = 2,
            }

            enum ImageScalingMode
            {
                None = 0,
                Upscaling = 1,
                Downscaling = 2,
            }

            enum ImageUpscalingFilter
            {
                Linear = 0,
                Point = 1,
                FSR = 2,
                STP = 3,
            }

            struct RenderingData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;
                /*0x18*/ UnityEngine.Rendering.Universal.CameraData cameraData;
                /*0x20*/ UnityEngine.Rendering.Universal.LightData lightData;
                /*0x28*/ UnityEngine.Rendering.Universal.ShadowData shadowData;
                /*0x30*/ UnityEngine.Rendering.Universal.PostProcessingData postProcessingData;

                /*0x3c6ff10*/ RenderingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c73720*/ UnityEngine.Rendering.Universal.UniversalRenderingData get_universalRenderingData();
                /*0x3c73770*/ ref UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x3c7381c*/ ref UnityEngine.Rendering.CullingResults get_cullResults();
                /*0x3c73878*/ ref bool get_supportsDynamicBatching();
                /*0x3c738d4*/ ref UnityEngine.Rendering.PerObjectData get_perObjectData();
                /*0x3c73930*/ ref bool get_postProcessingEnabled();
            }

            struct LightData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x3c7398c*/ LightData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c73994*/ UnityEngine.Rendering.Universal.UniversalLightData get_universalLightData();
                /*0x3c739e4*/ ref int get_mainLightIndex();
                /*0x3c73a40*/ ref int get_additionalLightsCount();
                /*0x3c73a9c*/ ref int get_maxPerObjectAdditionalLightsCount();
                /*0x3c73af8*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
                /*0x3c73b54*/ ref bool get_shadeAdditionalLightsPerVertex();
                /*0x3c73bb0*/ ref bool get_supportsMixedLighting();
                /*0x3c73c0c*/ ref bool get_reflectionProbeBoxProjection();
                /*0x3c73c68*/ ref bool get_reflectionProbeBlending();
                /*0x3c73cc4*/ ref bool get_supportsLightLayers();
                /*0x3c73d20*/ ref bool get_supportsAdditionalLights();
            }

            struct CameraData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x3c73d7c*/ CameraData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c73d84*/ UnityEngine.Rendering.Universal.UniversalCameraData get_universalCameraData();
                /*0x3c73dd4*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x3c73e74*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x3c73f2c*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x3c73fa0*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x3c7400c*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x3c7409c*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x3c74108*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x3c74198*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x3c74228*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x3c742c0*/ ref UnityEngine.Camera get_camera();
                /*0x3c7431c*/ ref UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x3c74378*/ ref UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x3c743d4*/ ref UnityEngine.RenderTexture get_targetTexture();
                /*0x3c71dbc*/ ref UnityEngine.RenderTextureDescriptor get_cameraTargetDescriptor();
                /*0x3c74430*/ ref UnityEngine.Rect get_pixelRect();
                /*0x3c7448c*/ ref bool get_useScreenCoordOverride();
                /*0x3c744e8*/ ref UnityEngine.Vector4 get_screenSizeOverride();
                /*0x3c74544*/ ref UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x3c745a0*/ ref int get_pixelWidth();
                /*0x3c745fc*/ ref int get_pixelHeight();
                /*0x3c74658*/ ref float get_aspectRatio();
                /*0x3c746b4*/ ref float get_renderScale();
                /*0x3c74710*/ ref UnityEngine.Rendering.Universal.ImageScalingMode get_imageScalingMode();
                /*0x3c7476c*/ ref UnityEngine.Rendering.Universal.ImageUpscalingFilter get_upscalingFilter();
                /*0x3c747c8*/ ref bool get_fsrOverrideSharpness();
                /*0x3c74824*/ ref float get_fsrSharpness();
                /*0x3c71ed0*/ ref UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x3c74880*/ ref bool get_clearDepth();
                /*0x3c748dc*/ ref UnityEngine.CameraType get_cameraType();
                /*0x3c74938*/ ref bool get_isDefaultViewport();
                /*0x3c71e18*/ ref bool get_isHdrEnabled();
                /*0x3c74994*/ ref bool get_allowHDROutput();
                /*0x3c749f0*/ ref bool get_isAlphaOutputEnabled();
                /*0x3c74a4c*/ ref bool get_requiresDepthTexture();
                /*0x3c74aa8*/ ref bool get_requiresOpaqueTexture();
                /*0x3c74b04*/ ref bool get_postProcessingRequiresDepthTexture();
                /*0x3c74b60*/ ref bool get_xrRendering();
                /*0x3c74bbc*/ bool get_requireSrgbConversion();
                /*0x3c74c18*/ bool get_isSceneViewCamera();
                /*0x3c71d60*/ bool get_isPreviewCamera();
                /*0x3c74c74*/ bool get_isRenderPassSupportedCamera();
                /*0x3c74cd0*/ bool get_resolveToScreen();
                /*0x3c74d2c*/ bool get_isHDROutputActive();
                /*0x3c74d88*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x3c74de4*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x3c74e40*/ bool get_rendersOverlayUI();
                /*0x3c74e9c*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x3c74f00*/ bool IsCameraProjectionMatrixFlipped();
                /*0x3c74f5c*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x3c74fd0*/ bool IsTemporalAAEnabled();
                /*0x3c7502c*/ ref UnityEngine.Rendering.SortingCriteria get_defaultOpaqueSortFlags();
                /*0x3c75088*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x3c750e4*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x3c75150*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x3c751ac*/ ref float get_maxShadowDistance();
                /*0x3c71e74*/ ref bool get_postProcessEnabled();
                /*0x3c75208*/ ref System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> get_captureActions();
                /*0x3c75264*/ ref UnityEngine.LayerMask get_volumeLayerMask();
                /*0x3c752c0*/ ref UnityEngine.Transform get_volumeTrigger();
                /*0x3c7531c*/ ref bool get_isStopNaNEnabled();
                /*0x3c75378*/ ref bool get_isDitheringEnabled();
                /*0x3c753d4*/ ref UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x3c75430*/ ref UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x3c7548c*/ ref UnityEngine.Rendering.Universal.ScriptableRenderer get_renderer();
                /*0x3c754e8*/ ref bool get_resolveFinalTarget();
                /*0x3c75544*/ ref UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x3c755a0*/ ref UnityEngine.Color get_backgroundColor();
                /*0x3c755fc*/ ref UnityEngine.Rendering.Universal.TaaHistory get_taaHistory();
                /*0x3c75658*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x3c756b4*/ bool get_resetHistory();
                /*0x3c75710*/ ref UnityEngine.Camera get_baseCamera();
            }

            struct ShadowData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x3c7576c*/ ShadowData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c75774*/ UnityEngine.Rendering.Universal.UniversalShadowData get_universalShadowData();
                /*0x3c757c4*/ ref bool get_supportsMainLightShadows();
                /*0x3c75820*/ ref bool get_mainLightShadowsEnabled();
                /*0x3c7587c*/ ref int get_mainLightShadowmapWidth();
                /*0x3c758d8*/ ref int get_mainLightShadowmapHeight();
                /*0x3c75934*/ ref int get_mainLightShadowCascadesCount();
                /*0x3c75990*/ ref UnityEngine.Vector3 get_mainLightShadowCascadesSplit();
                /*0x3c759ec*/ ref float get_mainLightShadowCascadeBorder();
                /*0x3c75a48*/ ref bool get_supportsAdditionalLightShadows();
                /*0x3c75aa4*/ ref bool get_additionalLightShadowsEnabled();
                /*0x3c75b00*/ ref int get_additionalLightsShadowmapWidth();
                /*0x3c75b5c*/ ref int get_additionalLightsShadowmapHeight();
                /*0x3c75bb8*/ ref bool get_supportsSoftShadows();
                /*0x3c75c14*/ ref int get_shadowmapDepthBufferBits();
                /*0x3c75c70*/ ref System.Collections.Generic.List<UnityEngine.Vector4> get_bias();
                /*0x3c75ccc*/ ref System.Collections.Generic.List<int> get_resolution();
                /*0x3c75d28*/ ref bool get_isKeywordAdditionalLightShadowsEnabled();
                /*0x3c75d84*/ ref bool get_isKeywordSoftShadowsEnabled();
                /*0x3c75de0*/ ref int get_mainLightShadowResolution();
                /*0x3c75e3c*/ ref int get_mainLightRenderTargetWidth();
                /*0x3c75e98*/ ref int get_mainLightRenderTargetHeight();
                /*0x3c75ef4*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> get_visibleLightsShadowCullingInfos();
                /*0x3c75f50*/ ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout get_shadowAtlasLayout();
            }

            struct PreTile
            {
                /*0x10*/ Unity.Mathematics.float4 planeLeft;
                /*0x20*/ Unity.Mathematics.float4 planeRight;
                /*0x30*/ Unity.Mathematics.float4 planeBottom;
                /*0x40*/ Unity.Mathematics.float4 planeTop;
            }

            struct TileData
            {
                /*0x10*/ uint tileID;
                /*0x14*/ uint listBitMask;
                /*0x18*/ uint relLightOffset;
                /*0x1c*/ uint unused;
            }

            struct PunctualLightData
            {
                /*0x10*/ UnityEngine.Vector3 wsPos;
                /*0x1c*/ float radius;
                /*0x20*/ UnityEngine.Vector4 color;
                /*0x30*/ UnityEngine.Vector4 attenuation;
                /*0x40*/ UnityEngine.Vector3 spotDirection;
                /*0x4c*/ int flags;
                /*0x50*/ UnityEngine.Vector4 occlusionProbeInfo;
                /*0x60*/ uint layerMask;
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int glossyEnvironmentColor;
                static /*0x4*/ int subtractiveShadowColor;
                static /*0x8*/ int glossyEnvironmentCubeMap;
                static /*0xc*/ int glossyEnvironmentCubeMapHDR;
                static /*0x10*/ int ambientSkyColor;
                static /*0x14*/ int ambientEquatorColor;
                static /*0x18*/ int ambientGroundColor;
                static /*0x1c*/ int time;
                static /*0x20*/ int sinTime;
                static /*0x24*/ int cosTime;
                static /*0x28*/ int deltaTime;
                static /*0x2c*/ int timeParameters;
                static /*0x30*/ int lastTimeParameters;
                static /*0x34*/ int scaledScreenParams;
                static /*0x38*/ int worldSpaceCameraPos;
                static /*0x3c*/ int screenParams;
                static /*0x40*/ int alphaToMaskAvailable;
                static /*0x44*/ int projectionParams;
                static /*0x48*/ int zBufferParams;
                static /*0x4c*/ int orthoParams;
                static /*0x50*/ int globalMipBias;
                static /*0x54*/ int screenSize;
                static /*0x58*/ int screenCoordScaleBias;
                static /*0x5c*/ int screenSizeOverride;
                static /*0x60*/ int viewMatrix;
                static /*0x64*/ int projectionMatrix;
                static /*0x68*/ int viewAndProjectionMatrix;
                static /*0x6c*/ int inverseViewMatrix;
                static /*0x70*/ int inverseProjectionMatrix;
                static /*0x74*/ int inverseViewAndProjectionMatrix;
                static /*0x78*/ int cameraProjectionMatrix;
                static /*0x7c*/ int inverseCameraProjectionMatrix;
                static /*0x80*/ int worldToCameraMatrix;
                static /*0x84*/ int cameraToWorldMatrix;
                static /*0x88*/ int shadowBias;
                static /*0x8c*/ int lightDirection;
                static /*0x90*/ int lightPosition;
                static /*0x94*/ int cameraWorldClipPlanes;
                static /*0x98*/ int billboardNormal;
                static /*0x9c*/ int billboardTangent;
                static /*0xa0*/ int billboardCameraParams;
                static /*0xa4*/ int previousViewProjectionNoJitter;
                static /*0xa8*/ int viewProjectionNoJitter;
                static /*0xac*/ int blitTexture;
                static /*0xb0*/ int blitScaleBias;
                static /*0xb4*/ int sourceTex;
                static /*0xb8*/ int scaleBias;
                static /*0xbc*/ int scaleBiasRt;
                static /*0xc0*/ int rtHandleScale;
                static /*0xc4*/ int rendererColor;
                static /*0xc8*/ int ditheringTexture;
                static /*0xcc*/ int ditheringTextureInvSize;
                static /*0xd0*/ int renderingLayerMaxInt;
                static /*0xd4*/ int renderingLayerRcpMaxInt;
                static /*0xd8*/ int overlayUITexture;
                static /*0xdc*/ int hdrOutputLuminanceParams;
                static /*0xe0*/ int hdrOutputGradingParams;

                static /*0x3c75fac*/ ShaderPropertyId();
            }

            struct PostProcessingData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x3c76ab4*/ PostProcessingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x3c76abc*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData get_universalPostProcessingData();
                /*0x3c76b0c*/ ref UnityEngine.Rendering.Universal.ColorGradingMode get_gradingMode();
                /*0x3c76b68*/ ref int get_lutSize();
                /*0x3c76bc4*/ ref bool get_useFastSRGBLinearConversion();
                /*0x3c76c20*/ ref bool get_supportScreenSpaceLensFlare();
                /*0x3c76c7c*/ ref bool get_supportDataDrivenLensFlare();
            }

            class ShaderGlobalKeywords
            {
                static /*0x0*/ UnityEngine.Rendering.GlobalKeyword MainLightShadows;
                static /*0x10*/ UnityEngine.Rendering.GlobalKeyword MainLightShadowCascades;
                static /*0x20*/ UnityEngine.Rendering.GlobalKeyword MainLightShadowScreen;
                static /*0x30*/ UnityEngine.Rendering.GlobalKeyword CastingPunctualLightShadow;
                static /*0x40*/ UnityEngine.Rendering.GlobalKeyword AdditionalLightsVertex;
                static /*0x50*/ UnityEngine.Rendering.GlobalKeyword AdditionalLightsPixel;
                static /*0x60*/ UnityEngine.Rendering.GlobalKeyword ForwardPlus;
                static /*0x70*/ UnityEngine.Rendering.GlobalKeyword AdditionalLightShadows;
                static /*0x80*/ UnityEngine.Rendering.GlobalKeyword ReflectionProbeBoxProjection;
                static /*0x90*/ UnityEngine.Rendering.GlobalKeyword ReflectionProbeBlending;
                static /*0xa0*/ UnityEngine.Rendering.GlobalKeyword SoftShadows;
                static /*0xb0*/ UnityEngine.Rendering.GlobalKeyword SoftShadowsLow;
                static /*0xc0*/ UnityEngine.Rendering.GlobalKeyword SoftShadowsMedium;
                static /*0xd0*/ UnityEngine.Rendering.GlobalKeyword SoftShadowsHigh;
                static /*0xe0*/ UnityEngine.Rendering.GlobalKeyword MixedLightingSubtractive;
                static /*0xf0*/ UnityEngine.Rendering.GlobalKeyword LightmapShadowMixing;
                static /*0x100*/ UnityEngine.Rendering.GlobalKeyword ShadowsShadowMask;
                static /*0x110*/ UnityEngine.Rendering.GlobalKeyword LightLayers;
                static /*0x120*/ UnityEngine.Rendering.GlobalKeyword RenderPassEnabled;
                static /*0x130*/ UnityEngine.Rendering.GlobalKeyword BillboardFaceCameraPos;
                static /*0x140*/ UnityEngine.Rendering.GlobalKeyword LightCookies;
                static /*0x150*/ UnityEngine.Rendering.GlobalKeyword DepthNoMsaa;
                static /*0x160*/ UnityEngine.Rendering.GlobalKeyword DepthMsaa2;
                static /*0x170*/ UnityEngine.Rendering.GlobalKeyword DepthMsaa4;
                static /*0x180*/ UnityEngine.Rendering.GlobalKeyword DepthMsaa8;
                static /*0x190*/ UnityEngine.Rendering.GlobalKeyword DBufferMRT1;
                static /*0x1a0*/ UnityEngine.Rendering.GlobalKeyword DBufferMRT2;
                static /*0x1b0*/ UnityEngine.Rendering.GlobalKeyword DBufferMRT3;
                static /*0x1c0*/ UnityEngine.Rendering.GlobalKeyword DecalNormalBlendLow;
                static /*0x1d0*/ UnityEngine.Rendering.GlobalKeyword DecalNormalBlendMedium;
                static /*0x1e0*/ UnityEngine.Rendering.GlobalKeyword DecalNormalBlendHigh;
                static /*0x1f0*/ UnityEngine.Rendering.GlobalKeyword DecalLayers;
                static /*0x200*/ UnityEngine.Rendering.GlobalKeyword WriteRenderingLayers;
                static /*0x210*/ UnityEngine.Rendering.GlobalKeyword ScreenSpaceOcclusion;
                static /*0x220*/ UnityEngine.Rendering.GlobalKeyword _SPOT;
                static /*0x230*/ UnityEngine.Rendering.GlobalKeyword _DIRECTIONAL;
                static /*0x240*/ UnityEngine.Rendering.GlobalKeyword _POINT;
                static /*0x250*/ UnityEngine.Rendering.GlobalKeyword _DEFERRED_STENCIL;
                static /*0x260*/ UnityEngine.Rendering.GlobalKeyword _DEFERRED_FIRST_LIGHT;
                static /*0x270*/ UnityEngine.Rendering.GlobalKeyword _DEFERRED_MAIN_LIGHT;
                static /*0x280*/ UnityEngine.Rendering.GlobalKeyword _GBUFFER_NORMALS_OCT;
                static /*0x290*/ UnityEngine.Rendering.GlobalKeyword _DEFERRED_MIXED_LIGHTING;
                static /*0x2a0*/ UnityEngine.Rendering.GlobalKeyword LIGHTMAP_ON;
                static /*0x2b0*/ UnityEngine.Rendering.GlobalKeyword DYNAMICLIGHTMAP_ON;
                static /*0x2c0*/ UnityEngine.Rendering.GlobalKeyword _ALPHATEST_ON;
                static /*0x2d0*/ UnityEngine.Rendering.GlobalKeyword DIRLIGHTMAP_COMBINED;
                static /*0x2e0*/ UnityEngine.Rendering.GlobalKeyword _DETAIL_MULX2;
                static /*0x2f0*/ UnityEngine.Rendering.GlobalKeyword _DETAIL_SCALED;
                static /*0x300*/ UnityEngine.Rendering.GlobalKeyword _CLEARCOAT;
                static /*0x310*/ UnityEngine.Rendering.GlobalKeyword _CLEARCOATMAP;
                static /*0x320*/ UnityEngine.Rendering.GlobalKeyword DEBUG_DISPLAY;
                static /*0x330*/ UnityEngine.Rendering.GlobalKeyword LOD_FADE_CROSSFADE;
                static /*0x340*/ UnityEngine.Rendering.GlobalKeyword USE_UNITY_CROSSFADE;
                static /*0x350*/ UnityEngine.Rendering.GlobalKeyword _EMISSION;
                static /*0x360*/ UnityEngine.Rendering.GlobalKeyword _RECEIVE_SHADOWS_OFF;
                static /*0x370*/ UnityEngine.Rendering.GlobalKeyword _SURFACE_TYPE_TRANSPARENT;
                static /*0x380*/ UnityEngine.Rendering.GlobalKeyword _ALPHAPREMULTIPLY_ON;
                static /*0x390*/ UnityEngine.Rendering.GlobalKeyword _ALPHAMODULATE_ON;
                static /*0x3a0*/ UnityEngine.Rendering.GlobalKeyword _NORMALMAP;
                static /*0x3b0*/ UnityEngine.Rendering.GlobalKeyword _ADD_PRECOMPUTED_VELOCITY;
                static /*0x3c0*/ UnityEngine.Rendering.GlobalKeyword EDITOR_VISUALIZATION;
                static /*0x3d0*/ UnityEngine.Rendering.GlobalKeyword FoveatedRenderingNonUniformRaster;
                static /*0x3e0*/ UnityEngine.Rendering.GlobalKeyword DisableTexture2DXArray;
                static /*0x3f0*/ UnityEngine.Rendering.GlobalKeyword BlitSingleSlice;
                static /*0x400*/ UnityEngine.Rendering.GlobalKeyword XROcclusionMeshCombined;
                static /*0x410*/ UnityEngine.Rendering.GlobalKeyword SCREEN_COORD_OVERRIDE;
                static /*0x420*/ UnityEngine.Rendering.GlobalKeyword DOWNSAMPLING_SIZE_2;
                static /*0x430*/ UnityEngine.Rendering.GlobalKeyword DOWNSAMPLING_SIZE_4;
                static /*0x440*/ UnityEngine.Rendering.GlobalKeyword DOWNSAMPLING_SIZE_8;
                static /*0x450*/ UnityEngine.Rendering.GlobalKeyword DOWNSAMPLING_SIZE_16;
                static /*0x460*/ UnityEngine.Rendering.GlobalKeyword EVALUATE_SH_MIXED;
                static /*0x470*/ UnityEngine.Rendering.GlobalKeyword EVALUATE_SH_VERTEX;
                static /*0x480*/ UnityEngine.Rendering.GlobalKeyword ProbeVolumeL1;
                static /*0x490*/ UnityEngine.Rendering.GlobalKeyword ProbeVolumeL2;
                static /*0x4a0*/ UnityEngine.Rendering.GlobalKeyword _OUTPUT_DEPTH;
                static /*0x4b0*/ UnityEngine.Rendering.GlobalKeyword LinearToSRGBConversion;
                static /*0x4c0*/ UnityEngine.Rendering.GlobalKeyword _ENABLE_ALPHA_OUTPUT;

                static /*0x3c68220*/ void InitializeShaderGlobalKeywords();
            }

            class ShaderKeywordStrings
            {
                static string MainLightShadows = "_MAIN_LIGHT_SHADOWS";
                static string MainLightShadowCascades = "_MAIN_LIGHT_SHADOWS_CASCADE";
                static string MainLightShadowScreen = "_MAIN_LIGHT_SHADOWS_SCREEN";
                static string CastingPunctualLightShadow = "_CASTING_PUNCTUAL_LIGHT_SHADOW";
                static string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";
                static string AdditionalLightsPixel = "_ADDITIONAL_LIGHTS";
                static string ForwardPlus = "_FORWARD_PLUS";
                static string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";
                static string ReflectionProbeBoxProjection = "_REFLECTION_PROBE_BOX_PROJECTION";
                static string ReflectionProbeBlending = "_REFLECTION_PROBE_BLENDING";
                static string SoftShadows = "_SHADOWS_SOFT";
                static string SoftShadowsLow = "_SHADOWS_SOFT_LOW";
                static string SoftShadowsMedium = "_SHADOWS_SOFT_MEDIUM";
                static string SoftShadowsHigh = "_SHADOWS_SOFT_HIGH";
                static string MixedLightingSubtractive = "_MIXED_LIGHTING_SUBTRACTIVE";
                static string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";
                static string ShadowsShadowMask = "SHADOWS_SHADOWMASK";
                static string LightLayers = "_LIGHT_LAYERS";
                static string RenderPassEnabled = "_RENDER_PASS_ENABLED";
                static string BillboardFaceCameraPos = "BILLBOARD_FACE_CAMERA_POS";
                static string LightCookies = "_LIGHT_COOKIES";
                static string DepthNoMsaa = "_DEPTH_NO_MSAA";
                static string DepthMsaa2 = "_DEPTH_MSAA_2";
                static string DepthMsaa4 = "_DEPTH_MSAA_4";
                static string DepthMsaa8 = "_DEPTH_MSAA_8";
                static string LinearToSRGBConversion = "_LINEAR_TO_SRGB_CONVERSION";
                static string UseFastSRGBLinearConversion = "_USE_FAST_SRGB_LINEAR_CONVERSION";
                static string DBufferMRT1 = "_DBUFFER_MRT1";
                static string DBufferMRT2 = "_DBUFFER_MRT2";
                static string DBufferMRT3 = "_DBUFFER_MRT3";
                static string DecalNormalBlendLow = "_DECAL_NORMAL_BLEND_LOW";
                static string DecalNormalBlendMedium = "_DECAL_NORMAL_BLEND_MEDIUM";
                static string DecalNormalBlendHigh = "_DECAL_NORMAL_BLEND_HIGH";
                static string DecalLayers = "_DECAL_LAYERS";
                static string WriteRenderingLayers = "_WRITE_RENDERING_LAYERS";
                static string SmaaLow = "_SMAA_PRESET_LOW";
                static string SmaaMedium = "_SMAA_PRESET_MEDIUM";
                static string SmaaHigh = "_SMAA_PRESET_HIGH";
                static string PaniniGeneric = "_GENERIC";
                static string PaniniUnitDistance = "_UNIT_DISTANCE";
                static string BloomLQ = "_BLOOM_LQ";
                static string BloomHQ = "_BLOOM_HQ";
                static string BloomLQDirt = "_BLOOM_LQ_DIRT";
                static string BloomHQDirt = "_BLOOM_HQ_DIRT";
                static string Distortion = "_DISTORTION";
                static string ChromaticAberration = "_CHROMATIC_ABERRATION";
                static string HDRGrading = "_HDR_GRADING";
                static string HDROverlay = "_HDR_OVERLAY";
                static string TonemapACES = "_TONEMAP_ACES";
                static string TonemapNeutral = "_TONEMAP_NEUTRAL";
                static string FilmGrain = "_FILM_GRAIN";
                static string Fxaa = "_FXAA";
                static string Dithering = "_DITHERING";
                static string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";
                static string PointSampling = "_POINT_SAMPLING";
                static string Rcas = "_RCAS";
                static string EasuRcasAndHDRInput = "_EASU_RCAS_AND_HDR_INPUT";
                static string Gamma20 = "_GAMMA_20";
                static string Gamma20AndHDRInput = "_GAMMA_20_AND_HDR_INPUT";
                static string HighQualitySampling = "_HIGH_QUALITY_SAMPLING";
                static string _SPOT = "_SPOT";
                static string _DIRECTIONAL = "_DIRECTIONAL";
                static string _POINT = "_POINT";
                static string _DEFERRED_STENCIL = "_DEFERRED_STENCIL";
                static string _DEFERRED_FIRST_LIGHT = "_DEFERRED_FIRST_LIGHT";
                static string _DEFERRED_MAIN_LIGHT = "_DEFERRED_MAIN_LIGHT";
                static string _GBUFFER_NORMALS_OCT = "_GBUFFER_NORMALS_OCT";
                static string _DEFERRED_MIXED_LIGHTING = "_DEFERRED_MIXED_LIGHTING";
                static string LIGHTMAP_ON = "LIGHTMAP_ON";
                static string DYNAMICLIGHTMAP_ON = "DYNAMICLIGHTMAP_ON";
                static string _ALPHATEST_ON = "_ALPHATEST_ON";
                static string DIRLIGHTMAP_COMBINED = "DIRLIGHTMAP_COMBINED";
                static string _DETAIL_MULX2 = "_DETAIL_MULX2";
                static string _DETAIL_SCALED = "_DETAIL_SCALED";
                static string _CLEARCOAT = "_CLEARCOAT";
                static string _CLEARCOATMAP = "_CLEARCOATMAP";
                static string DEBUG_DISPLAY = "DEBUG_DISPLAY";
                static string LOD_FADE_CROSSFADE = "LOD_FADE_CROSSFADE";
                static string USE_UNITY_CROSSFADE = "USE_UNITY_CROSSFADE";
                static string _EMISSION = "_EMISSION";
                static string _RECEIVE_SHADOWS_OFF = "_RECEIVE_SHADOWS_OFF";
                static string _SURFACE_TYPE_TRANSPARENT = "_SURFACE_TYPE_TRANSPARENT";
                static string _ALPHAPREMULTIPLY_ON = "_ALPHAPREMULTIPLY_ON";
                static string _ALPHAMODULATE_ON = "_ALPHAMODULATE_ON";
                static string _NORMALMAP = "_NORMALMAP";
                static string _ADD_PRECOMPUTED_VELOCITY = "_ADD_PRECOMPUTED_VELOCITY";
                static string EDITOR_VISUALIZATION = "EDITOR_VISUALIZATION";
                static string FoveatedRenderingNonUniformRaster = "_FOVEATED_RENDERING_NON_UNIFORM_RASTER";
                static string DisableTexture2DXArray = "DISABLE_TEXTURE2D_X_ARRAY";
                static string BlitSingleSlice = "BLIT_SINGLE_SLICE";
                static string XROcclusionMeshCombined = "XR_OCCLUSION_MESH_COMBINED";
                static string SCREEN_COORD_OVERRIDE = "SCREEN_COORD_OVERRIDE";
                static string DOWNSAMPLING_SIZE_2 = "DOWNSAMPLING_SIZE_2";
                static string DOWNSAMPLING_SIZE_4 = "DOWNSAMPLING_SIZE_4";
                static string DOWNSAMPLING_SIZE_8 = "DOWNSAMPLING_SIZE_8";
                static string DOWNSAMPLING_SIZE_16 = "DOWNSAMPLING_SIZE_16";
                static string EVALUATE_SH_MIXED = "EVALUATE_SH_MIXED";
                static string EVALUATE_SH_VERTEX = "EVALUATE_SH_VERTEX";
                static string ProbeVolumeL1 = "PROBE_VOLUMES_L1";
                static string ProbeVolumeL2 = "PROBE_VOLUMES_L2";
                static string USE_LEGACY_LIGHTMAPS = "USE_LEGACY_LIGHTMAPS";
                static string _OUTPUT_DEPTH = "_OUTPUT_DEPTH";
                static string _ENABLE_ALPHA_OUTPUT = "_ENABLE_ALPHA_OUTPUT";
            }

            enum URPProfileId
            {
                UniversalRenderTotal = 0,
                UpdateVolumeFramework = 1,
                RenderCameraStack = 2,
                AdditionalLightsShadow = 3,
                ColorGradingLUT = 4,
                CopyColor = 5,
                CopyDepth = 6,
                DrawDepthNormalPrepass = 7,
                DepthPrepass = 8,
                UpdateReflectionProbeAtlas = 9,
                DrawOpaqueObjects = 10,
                DrawTransparentObjects = 11,
                DrawScreenSpaceUI = 12,
                RecordRenderGraph = 13,
                LightCookies = 14,
                MainLightShadow = 15,
                ResolveShadows = 16,
                SSAO = 17,
                StopNaNs = 18,
                SMAA = 19,
                GaussianDepthOfField = 20,
                BokehDepthOfField = 21,
                TemporalAA = 22,
                MotionBlur = 23,
                PaniniProjection = 24,
                UberPostProcess = 25,
                Bloom = 26,
                LensFlareDataDrivenComputeOcclusion = 27,
                LensFlareDataDriven = 28,
                LensFlareScreenSpace = 29,
                DrawMotionVectors = 30,
                DrawFullscreen = 31,
                RG_SetupPostFX = 32,
                RG_StopNaNs = 33,
                RG_SMAAMaterialSetup = 34,
                RG_SMAAEdgeDetection = 35,
                RG_SMAABlendWeight = 36,
                RG_SMAANeighborhoodBlend = 37,
                RG_SetupDoF = 38,
                RG_DOFComputeCOC = 39,
                RG_DOFDownscalePrefilter = 40,
                RG_DOFBlurH = 41,
                RG_DOFBlurV = 42,
                RG_DOFBlurBokeh = 43,
                RG_DOFPostFilter = 44,
                RG_DOFComposite = 45,
                RG_TAA = 46,
                RG_TAACopyHistory = 47,
                RG_MotionBlur = 48,
                RG_BloomSetup = 49,
                RG_BloomPrefilter = 50,
                RG_BloomDownsample = 51,
                RG_BloomUpsample = 52,
                RG_UberPostSetupBloomPass = 53,
                RG_UberPost = 54,
                RG_FinalSetup = 55,
                RG_FinalFSRScale = 56,
                RG_FinalBlit = 57,
                BlitFinalToBackBuffer = 58,
                DrawSkybox = 59,
            }

            class PlatformAutoDetect
            {
                static /*0x0*/ bool <isXRMobile>k__BackingField;
                static /*0x1*/ bool <isShaderAPIMobileDefined>k__BackingField;
                static /*0x2*/ bool <isSwitch>k__BackingField;
                static /*0x3*/ bool isRunningOnPowerVRGPU;

                static /*0x3c771b8*/ PlatformAutoDetect();
                static /*0x3c76cd8*/ void Initialize();
                static /*0x3c76e50*/ bool get_isXRMobile();
                static /*0x3c76ea8*/ void set_isXRMobile(bool value);
                static /*0x3c76f08*/ bool get_isShaderAPIMobileDefined();
                static /*0x3c76f60*/ void set_isShaderAPIMobileDefined(bool value);
                static /*0x3c76fc0*/ bool get_isSwitch();
                static /*0x3c77018*/ void set_isSwitch(bool value);
                static /*0x3c77078*/ UnityEngine.Rendering.Universal.ShEvalMode ShAutoDetect(UnityEngine.Rendering.Universal.ShEvalMode mode);
            }

            class VolumeRequiresRendererFeatures : System.Attribute
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> TargetFeatureTypes;

                /*0x3c77244*/ VolumeRequiresRendererFeatures(System.Type[] featureTypes);
            }

            class XRPassUniversal : UnityEngine.Experimental.Rendering.XRPass
            {
                /*0x734*/ bool <isLateLatchEnabled>k__BackingField;
                /*0x735*/ bool <canMarkLateLatch>k__BackingField;
                /*0x736*/ bool <hasMarkedLateLatch>k__BackingField;
                /*0x737*/ bool <canFoveateIntermediatePasses>k__BackingField;

                static /*0x3c77334*/ UnityEngine.Experimental.Rendering.XRPass Create(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x3c774c8*/ XRPassUniversal();
                /*0x3c7741c*/ void Release();
                /*0x3c77488*/ bool get_isLateLatchEnabled();
                /*0x3c77490*/ void set_isLateLatchEnabled(bool value);
                /*0x3c77498*/ bool get_canMarkLateLatch();
                /*0x3c774a0*/ void set_canMarkLateLatch(bool value);
                /*0x3c774a8*/ bool get_hasMarkedLateLatch();
                /*0x3c774b0*/ void set_hasMarkedLateLatch(bool value);
                /*0x3c774b8*/ bool get_canFoveateIntermediatePasses();
                /*0x3c774c0*/ void set_canFoveateIntermediatePasses(bool value);
            }

            class XRSystemUniversal
            {
                static /*0x0*/ UnityEngine.Matrix4x4[] s_projMatrix;

                static /*0x3c774dc*/ XRSystemUniversal();
                static /*0x3c774d0*/ void BeginLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x3c707a8*/ void EndLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x3c774d4*/ void UnmarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x3c774d8*/ void MarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass, bool renderIntoTexture);
            }

            namespace Internal
            {
                class DeferredConfig
                {
                    static /*0x0*/ bool <IsOpenGL>k__BackingField;
                    static /*0x1*/ bool <IsDX10>k__BackingField;

                    static /*0x3c77550*/ bool get_IsOpenGL();
                    static /*0x3c77598*/ void set_IsOpenGL(bool value);
                    static /*0x3c775e8*/ bool get_IsDX10();
                    static /*0x3c77630*/ void set_IsDX10(bool value);
                }

                enum LightFlag
                {
                    SubtractiveMixedLighting = 4,
                }

                class DeferredLights
                {
                    static /*0x0*/ string[] k_GBufferNames;
                    static /*0x8*/ int[] k_GBufferShaderPropertyIDs;
                    static /*0x10*/ string[] k_StencilDeferredPassNames;
                    static /*0x18*/ ushort k_InvalidLightOffset;
                    static /*0x20*/ string k_SetupLights;
                    static /*0x28*/ string k_DeferredPass;
                    static /*0x30*/ string k_DeferredStencilPass;
                    static /*0x38*/ string k_DeferredFogPass;
                    static /*0x40*/ string k_ClearStencilPartial;
                    static /*0x48*/ string k_SetupLightConstants;
                    static /*0x50*/ float kStencilShapeGuard;
                    static /*0x58*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLights;
                    static /*0x60*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDeferredPass;
                    static /*0x68*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLightConstants;
                    static /*0x70*/ UnityEngine.Rendering.ProfilingSampler s_SetupDeferredLights;
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize <RenderingLayerMaskSize>k__BackingField;
                    /*0x14*/ bool <UseDecalLayers>k__BackingField;
                    /*0x15*/ bool <UseFramebufferFetch>k__BackingField;
                    /*0x16*/ bool <HasDepthPrepass>k__BackingField;
                    /*0x17*/ bool <HasNormalPrepass>k__BackingField;
                    /*0x18*/ bool <HasRenderingLayerPrepass>k__BackingField;
                    /*0x19*/ bool <IsOverlay>k__BackingField;
                    /*0x1a*/ bool <AccurateGbufferNormals>k__BackingField;
                    /*0x1c*/ UnityEngine.Rendering.Universal.MixedLightingSetup <MixedLightingSetup>k__BackingField;
                    /*0x20*/ bool <UseJobSystem>k__BackingField;
                    /*0x24*/ int <RenderWidth>k__BackingField;
                    /*0x28*/ int <RenderHeight>k__BackingField;
                    /*0x30*/ UnityEngine.Rendering.RTHandle[] <GbufferAttachments>k__BackingField;
                    /*0x38*/ UnityEngine.Rendering.RTHandle[] GbufferRTHandles;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] <GbufferTextureHandles>k__BackingField;
                    /*0x48*/ UnityEngine.Rendering.RTHandle[] <DeferredInputAttachments>k__BackingField;
                    /*0x50*/ bool[] <DeferredInputIsTransient>k__BackingField;
                    /*0x58*/ UnityEngine.Rendering.RTHandle <DepthAttachment>k__BackingField;
                    /*0x60*/ UnityEngine.Rendering.RTHandle <DepthCopyTexture>k__BackingField;
                    /*0x68*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <GbufferFormats>k__BackingField;
                    /*0x70*/ UnityEngine.Rendering.RTHandle <DepthAttachmentHandle>k__BackingField;
                    /*0x78*/ Unity.Collections.NativeArray<ushort> m_stencilVisLights;
                    /*0x88*/ Unity.Collections.NativeArray<ushort> m_stencilVisLightOffsets;
                    /*0x98*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                    /*0xa0*/ UnityEngine.Mesh m_SphereMesh;
                    /*0xa8*/ UnityEngine.Mesh m_HemisphereMesh;
                    /*0xb0*/ UnityEngine.Mesh m_FullscreenMesh;
                    /*0xb8*/ UnityEngine.Material m_StencilDeferredMaterial;
                    /*0xc0*/ int[] m_StencilDeferredPasses;
                    /*0xc8*/ UnityEngine.Matrix4x4[] m_ScreenToWorld;
                    /*0xd0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredStencilPass;
                    /*0xd8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredFogPass;
                    /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;
                    /*0xe8*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;

                    static /*0x3c7d2a0*/ DeferredLights();
                    static /*0x3c799f4*/ UnityEngine.Rendering.StencilState OverwriteStencil(UnityEngine.Rendering.StencilState s, int stencilWriteMask);
                    static /*0x3c79bac*/ UnityEngine.Rendering.RenderStateBlock OverwriteStencil(UnityEngine.Rendering.RenderStateBlock block, int stencilWriteMask, int stencilRef);
                    static /*0x3c7c7b4*/ UnityEngine.Mesh CreateSphereMesh();
                    static /*0x3c7cd78*/ UnityEngine.Mesh CreateHemisphereMesh();
                    static /*0x3c79fdc*/ UnityEngine.Mesh CreateFullscreenMesh();
                    /*0x3c77a8c*/ DeferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights.InitParams initParams, bool useNativeRenderPass);
                    /*0x3c77680*/ int get_GBufferAlbedoIndex();
                    /*0x3c77688*/ int get_GBufferSpecularMetallicIndex();
                    /*0x3c77690*/ int get_GBufferNormalSmoothnessIndex();
                    /*0x3c77698*/ int get_GBufferLightingIndex();
                    /*0x3c776a0*/ int get_GbufferDepthIndex();
                    /*0x3c776b4*/ int get_GBufferRenderingLayers();
                    /*0x3c77710*/ int get_GBufferShadowMask();
                    /*0x3c77768*/ int get_GBufferSliceCount();
                    /*0x3c777ac*/ int get_GBufferInputAttachmentCount();
                    /*0x3c777c0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGBufferFormat(int index);
                    /*0x3c77758*/ bool get_UseShadowMask();
                    /*0x3c776e4*/ bool get_UseRenderingLayers();
                    /*0x3c7794c*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_RenderingLayerMaskSize();
                    /*0x3c77954*/ void set_RenderingLayerMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x3c7795c*/ bool get_UseDecalLayers();
                    /*0x3c77964*/ void set_UseDecalLayers(bool value);
                    /*0x3c778f0*/ bool get_UseLightLayers();
                    /*0x3c7796c*/ bool get_UseFramebufferFetch();
                    /*0x3c77974*/ void set_UseFramebufferFetch(bool value);
                    /*0x3c7797c*/ bool get_HasDepthPrepass();
                    /*0x3c77984*/ void set_HasDepthPrepass(bool value);
                    /*0x3c7798c*/ bool get_HasNormalPrepass();
                    /*0x3c77994*/ void set_HasNormalPrepass(bool value);
                    /*0x3c7799c*/ bool get_HasRenderingLayerPrepass();
                    /*0x3c779a4*/ void set_HasRenderingLayerPrepass(bool value);
                    /*0x3c779ac*/ bool get_IsOverlay();
                    /*0x3c779b4*/ void set_IsOverlay(bool value);
                    /*0x3c779bc*/ bool get_AccurateGbufferNormals();
                    /*0x3c779c4*/ void set_AccurateGbufferNormals(bool value);
                    /*0x3c779cc*/ UnityEngine.Rendering.Universal.MixedLightingSetup get_MixedLightingSetup();
                    /*0x3c779d4*/ void set_MixedLightingSetup(UnityEngine.Rendering.Universal.MixedLightingSetup value);
                    /*0x3c779dc*/ bool get_UseJobSystem();
                    /*0x3c779e4*/ void set_UseJobSystem(bool value);
                    /*0x3c779ec*/ int get_RenderWidth();
                    /*0x3c779f4*/ void set_RenderWidth(int value);
                    /*0x3c779fc*/ int get_RenderHeight();
                    /*0x3c77a04*/ void set_RenderHeight(int value);
                    /*0x3c77a0c*/ UnityEngine.Rendering.RTHandle[] get_GbufferAttachments();
                    /*0x3c77a14*/ void set_GbufferAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x3c77a1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_GbufferTextureHandles();
                    /*0x3c77a24*/ void set_GbufferTextureHandles(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0x3c77a2c*/ UnityEngine.Rendering.RTHandle[] get_DeferredInputAttachments();
                    /*0x3c77a34*/ void set_DeferredInputAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x3c77a3c*/ bool[] get_DeferredInputIsTransient();
                    /*0x3c77a44*/ void set_DeferredInputIsTransient(bool[] value);
                    /*0x3c77a4c*/ UnityEngine.Rendering.RTHandle get_DepthAttachment();
                    /*0x3c77a54*/ void set_DepthAttachment(UnityEngine.Rendering.RTHandle value);
                    /*0x3c77a5c*/ UnityEngine.Rendering.RTHandle get_DepthCopyTexture();
                    /*0x3c77a64*/ void set_DepthCopyTexture(UnityEngine.Rendering.RTHandle value);
                    /*0x3c77a6c*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_GbufferFormats();
                    /*0x3c77a74*/ void set_GbufferFormats(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                    /*0x3c77a7c*/ UnityEngine.Rendering.RTHandle get_DepthAttachmentHandle();
                    /*0x3c77a84*/ void set_DepthAttachmentHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x3c780e4*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c784c8*/ void SetupLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool isRenderGraph);
                    /*0x3c78c10*/ void ResolveMixedLightingMode(UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c7906c*/ void DisableFramebufferFetchInput();
                    /*0x3c79074*/ void ReleaseGbufferResources();
                    /*0x3c79100*/ void ReAllocateGBufferIfNeeded(UnityEngine.RenderTextureDescriptor gbufferSlice, int gbufferIndex);
                    /*0x3c78d7c*/ void CreateGbufferResources();
                    /*0x3c792e8*/ void UpdateDeferredInputAttachments();
                    /*0x3c7960c*/ bool IsRuntimeSupportedThisFrame();
                    /*0x3c796a8*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, UnityEngine.Rendering.RTHandle depthCopyTexture, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RTHandle colorAttachment);
                    /*0x3c79934*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass);
                    /*0x3c7993c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c79e18*/ void ClearStencilPartial(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x3c7a128*/ void ExecuteDeferredPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c78c0c*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c7acb0*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c7af14*/ UnityEngine.Matrix4x4[] GetScreenToWorldMatrix(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x3c7a4d4*/ void SetupMatrixConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x3c788f4*/ void PrecomputeLights(ref Unity.Collections.NativeArray<ushort> stencilVisLights, ref Unity.Collections.NativeArray<ushort> stencilVisLightOffsets, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLights);
                    /*0x3c7a564*/ bool HasStencilLightsOfType(UnityEngine.LightType type);
                    /*0x3c7a718*/ void RenderStencilLights(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, bool stripShadowsOffVariants);
                    /*0x3c7b14c*/ void RenderStencilDirectionalLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex);
                    /*0x3c7b770*/ void RenderStencilPointLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x3c7bdb0*/ void RenderStencilSpotLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x3c7a5dc*/ void RenderSSAOBeforeShading(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x3c7aa60*/ void RenderFog(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isOrthographic);
                    /*0x3c77d28*/ void InitStencilDeferredMaterial();
                    /*0x3c7aec4*/ void SetRenderingLayersMask(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Light light, int shaderPropertyID);
                    /*0x3c7c620*/ void SetAdditionalLightsShadowsKeyword(ref UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword);
                    /*0x3c7c6d4*/ void SetSoftShadowsKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow);
                    /*0x3c7c4e4*/ void SetLightCookiesKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex);

                    class ShaderConstants
                    {
                        static /*0x0*/ int _LitStencilRef;
                        static /*0x4*/ int _LitStencilReadMask;
                        static /*0x8*/ int _LitStencilWriteMask;
                        static /*0xc*/ int _SimpleLitStencilRef;
                        static /*0x10*/ int _SimpleLitStencilReadMask;
                        static /*0x14*/ int _SimpleLitStencilWriteMask;
                        static /*0x18*/ int _StencilRef;
                        static /*0x1c*/ int _StencilReadMask;
                        static /*0x20*/ int _StencilWriteMask;
                        static /*0x24*/ int _LitPunctualStencilRef;
                        static /*0x28*/ int _LitPunctualStencilReadMask;
                        static /*0x2c*/ int _LitPunctualStencilWriteMask;
                        static /*0x30*/ int _SimpleLitPunctualStencilRef;
                        static /*0x34*/ int _SimpleLitPunctualStencilReadMask;
                        static /*0x38*/ int _SimpleLitPunctualStencilWriteMask;
                        static /*0x3c*/ int _LitDirStencilRef;
                        static /*0x40*/ int _LitDirStencilReadMask;
                        static /*0x44*/ int _LitDirStencilWriteMask;
                        static /*0x48*/ int _SimpleLitDirStencilRef;
                        static /*0x4c*/ int _SimpleLitDirStencilReadMask;
                        static /*0x50*/ int _SimpleLitDirStencilWriteMask;
                        static /*0x54*/ int _ClearStencilRef;
                        static /*0x58*/ int _ClearStencilReadMask;
                        static /*0x5c*/ int _ClearStencilWriteMask;
                        static /*0x60*/ int _ScreenToWorld;
                        static /*0x64*/ int _MainLightPosition;
                        static /*0x68*/ int _MainLightColor;
                        static /*0x6c*/ int _MainLightLayerMask;
                        static /*0x70*/ int _SpotLightScale;
                        static /*0x74*/ int _SpotLightBias;
                        static /*0x78*/ int _SpotLightGuard;
                        static /*0x7c*/ int _LightPosWS;
                        static /*0x80*/ int _LightColor;
                        static /*0x84*/ int _LightAttenuation;
                        static /*0x88*/ int _LightOcclusionProbInfo;
                        static /*0x8c*/ int _LightDirection;
                        static /*0x90*/ int _LightFlags;
                        static /*0x94*/ int _ShadowLightIndex;
                        static /*0x98*/ int _LightLayerMask;
                        static /*0x9c*/ int _CookieLightIndex;

                        static /*0x3c7dc54*/ ShaderConstants();
                    }

                    enum StencilDeferredPasses
                    {
                        StencilVolume = 0,
                        PunctualLit = 1,
                        PunctualSimpleLit = 2,
                        DirectionalLit = 3,
                        DirectionalSimpleLit = 4,
                        ClearStencilPartial = 5,
                        Fog = 6,
                        SSAOOnly = 7,
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Material stencilDeferredMaterial;
                        /*0x18*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                    }

                    class SetupLightPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x20*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;
                        /*0x28*/ UnityEngine.Vector2Int cameraTargetSizeCopy;

                        /*0x3c7e42c*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__139_0;

                        static /*0x3c7e434*/ <>c();
                        /*0x3c7e49c*/ <>c();
                        /*0x3c7e4a4*/ void <SetupRenderGraphLights>b__139_0(UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    }
                }

                class AdditionalLightsShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_ShadowmapBufferBits = 16;
                    static int k_EmptyShadowMapDimensions = 1;
                    static float k_LightTypeIdentifierInShadowParams_Spot = 0;
                    static float k_LightTypeIdentifierInShadowParams_Point = 1;
                    static string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture";
                    static string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture";
                    static /*0x0*/ int m_AdditionalShadowsBufferId;
                    static /*0x4*/ int m_AdditionalShadowsIndicesId;
                    static /*0x8*/ bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall;
                    static /*0x9*/ bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall;
                    static /*0xc*/ UnityEngine.Vector4 c_DefaultShadowParams;
                    static /*0x1c*/ UnityEngine.Vector4 s_EmptyAdditionalShadowFadeParams;
                    static /*0x30*/ UnityEngine.Vector4[] s_EmptyAdditionalLightIndexToShadowParams;
                    static /*0x38*/ bool isAdditionalShadowParamsDirty;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_AdditionalLightsShadowmapHandle;
                    /*0xc0*/ int renderTargetWidth;
                    /*0xc4*/ int renderTargetHeight;
                    /*0xc8*/ bool m_CreateEmptyShadowmap;
                    /*0xc9*/ bool m_SetKeywordForEmptyShadowmap;
                    /*0xca*/ bool m_EmptyShadowmapNeedsClear;
                    /*0xcb*/ bool m_IssuedMessageAboutShadowSlicesTooMany;
                    /*0xcc*/ bool m_IssuedMessageAboutShadowMapsRescale;
                    /*0xcd*/ bool m_IssuedMessageAboutShadowMapsTooBig;
                    /*0xce*/ bool m_IssuedMessageAboutRemovedShadowSlices;
                    /*0xcf*/ bool m_UseStructuredBuffer;
                    /*0xd0*/ float m_MaxShadowDistanceSq;
                    /*0xd4*/ float m_CascadeBorder;
                    /*0xd8*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData m_PassData;
                    /*0xe0*/ UnityEngine.Rendering.RTHandle m_EmptyAdditionalLightShadowmapTexture;
                    /*0xe8*/ bool[] m_VisibleLightIndexToIsCastingShadows;
                    /*0xf0*/ short[] m_VisibleLightIndexToAdditionalLightIndex;
                    /*0xf8*/ short[] m_AdditionalLightIndexToVisibleLightIndex;
                    /*0x100*/ UnityEngine.Vector4[] m_AdditionalLightIndexToShadowParams;
                    /*0x108*/ UnityEngine.Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;
                    /*0x110*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_AdditionalLightsShadowSlices;
                    /*0x118*/ System.Collections.Generic.List<byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;
                    /*0x120*/ System.Collections.Generic.List<short> m_ShadowSliceToAdditionalLightIndex;
                    /*0x128*/ System.Collections.Generic.Dictionary<int, ulong> m_ShadowRequestsHashes;
                    /*0x130*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;
                    /*0x138*/ UnityEngine.RenderTextureDescriptor m_AdditionalLightShadowDescriptor;

                    static /*0x3c833e4*/ AdditionalLightsShadowCasterPass();
                    static /*0x3c7ea84*/ float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels);
                    static /*0x3c7eaf4*/ float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering);
                    static /*0x3c81664*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x3c7e52c*/ AdditionalLightsShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x3c7ea50*/ void Dispose();
                    /*0x3c7ed9c*/ ulong ResolutionLog2ForHash(int resolution);
                    /*0x3c7ede8*/ ulong ComputeShadowRequestHash(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c7f0f4*/ float GetLightTypeIdentifierForShadowParams(UnityEngine.LightType lightType);
                    /*0x3c7f114*/ bool UsesBakedShadows(UnityEngine.Light light);
                    /*0x3c7f14c*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c7f230*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c8113c*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x3c809f0*/ bool AnyAdditionalLightHasMixedShadows(UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c80afc*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c811e8*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x3c8132c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c82740*/ int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
                    /*0x3c81038*/ void Clear();
                    /*0x3c81bc4*/ void RenderAdditionalShadowmapAtlas(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, bool useRenderGraph);
                    /*0x3c827a0*/ void SetupAdditionalLightsShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows);
                    /*0x3c81890*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c81950*/ void InitRendererLists(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x3c82a90*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

                    class AdditionalShadowsConstantBuffer
                    {
                        static /*0x0*/ int _AdditionalLightsWorldToShadow;
                        static /*0x4*/ int _AdditionalShadowParams;
                        static /*0x8*/ int _AdditionalShadowOffset0;
                        static /*0xc*/ int _AdditionalShadowOffset1;
                        static /*0x10*/ int _AdditionalShadowFadeParams;
                        static /*0x14*/ int _AdditionalShadowmapSize;
                        static /*0x18*/ int _AdditionalLightsShadowmapID;
                        static /*0x1c*/ int _AdditionalLightsWorldToShadow_SSBO;
                        static /*0x20*/ int _AdditionalShadowParams_SSBO;

                        static /*0x3c83434*/ AdditionalShadowsConstantBuffer();
                    }

                    class PassData
                    {
                        /*0x10*/ int shadowmapID;
                        /*0x14*/ bool emptyShadowmap;
                        /*0x15*/ bool setKeywordForEmptyShadowmap;
                        /*0x16*/ bool useStructuredBuffer;
                        /*0x17*/ bool stripShadowsOffVariants;
                        /*0x18*/ UnityEngine.Matrix4x4 viewMatrix;
                        /*0x58*/ UnityEngine.Vector2Int allocatedShadowAtlasSize;
                        /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x70*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x78*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x80*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass pass;
                        /*0x88*/ UnityEngine.Rendering.RendererList[] shadowRendererLists;
                        /*0x90*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle[] shadowRendererListsHdl;

                        /*0x3c7e9b4*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__64_0;

                        static /*0x3c8363c*/ <>c();
                        /*0x3c836a4*/ <>c();
                        /*0x3c836ac*/ void <Render>b__64_0(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class ForwardLights
                {
                    static string k_SetupLightConstants = "Setup Light Constants";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPSetup;
                    static /*0x10*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPComplete;
                    static /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPUpload;
                    static /*0x20*/ UnityEngine.Rendering.ProfilingSampler s_SetupForwardLights;
                    /*0x10*/ int m_AdditionalLightsBufferId;
                    /*0x14*/ int m_AdditionalLightsIndicesId;
                    /*0x18*/ UnityEngine.Rendering.Universal.MixedLightingSetup m_MixedLightingSetup;
                    /*0x20*/ UnityEngine.Vector4[] m_AdditionalLightPositions;
                    /*0x28*/ UnityEngine.Vector4[] m_AdditionalLightColors;
                    /*0x30*/ UnityEngine.Vector4[] m_AdditionalLightAttenuations;
                    /*0x38*/ UnityEngine.Vector4[] m_AdditionalLightSpotDirections;
                    /*0x40*/ UnityEngine.Vector4[] m_AdditionalLightOcclusionProbeChannels;
                    /*0x48*/ float[] m_AdditionalLightsLayerMasks;
                    /*0x50*/ bool m_UseStructuredBuffer;
                    /*0x51*/ bool m_UseForwardPlus;
                    /*0x54*/ int m_DirectionalLightCount;
                    /*0x58*/ int m_ActualTileWidth;
                    /*0x5c*/ Unity.Mathematics.int2 m_TileResolution;
                    /*0x68*/ Unity.Jobs.JobHandle m_CullingHandle;
                    /*0x78*/ Unity.Collections.NativeArray<uint> m_ZBins;
                    /*0x88*/ UnityEngine.GraphicsBuffer m_ZBinsBuffer;
                    /*0x90*/ Unity.Collections.NativeArray<uint> m_TileMasks;
                    /*0xa0*/ UnityEngine.GraphicsBuffer m_TileMasksBuffer;
                    /*0xa8*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                    /*0xb0*/ UnityEngine.Rendering.Universal.ReflectionProbeManager m_ReflectionProbeManager;
                    /*0x138*/ int m_WordsPerTile;
                    /*0x13c*/ float m_ZBinScale;
                    /*0x140*/ float m_ZBinOffset;
                    /*0x144*/ int m_LightCount;
                    /*0x148*/ int m_BinCount;

                    static /*0x3c8705c*/ ForwardLights();
                    static /*0x3c83f74*/ int AlignByteCount(int count, int align);
                    static /*0x3c8529c*/ bool <PreSetup>g__IsProbeGreater|40_0(UnityEngine.Rendering.VisibleReflectionProbe probe, UnityEngine.Rendering.VisibleReflectionProbe otherProbe);
                    /*0x3c83780*/ ForwardLights();
                    /*0x3c838d8*/ ForwardLights(UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams initParams);
                    /*0x3c83d40*/ void CreateForwardPlusBuffers();
                    /*0x3c83f64*/ UnityEngine.Rendering.Universal.ReflectionProbeManager get_reflectionProbeManager();
                    /*0x3c83f88*/ void GetViewParams(UnityEngine.Camera camera, Unity.Mathematics.float4x4 viewToClip, ref float viewPlaneBot, ref float viewPlaneTop, ref Unity.Mathematics.float4 viewToViewportScaleBias);
                    /*0x3c840ec*/ void PreSetup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c8537c*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c86044*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c854d4*/ void SetupLights(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c86474*/ void Cleanup();
                    /*0x3c86554*/ void InitializeLightConstants(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, bool supportsLightLayers, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel, ref uint lightLayerMask, ref bool isSubtractive);
                    /*0x3c8642c*/ void SetupShaderLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c86748*/ void SetupMainLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c8689c*/ void SetupAdditionalLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c86de0*/ int SetupPerObjectLightIndices(UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);

                    class LightConstantBuffer
                    {
                        static /*0x0*/ int _MainLightPosition;
                        static /*0x4*/ int _MainLightColor;
                        static /*0x8*/ int _MainLightOcclusionProbesChannel;
                        static /*0xc*/ int _MainLightLayerMask;
                        static /*0x10*/ int _AdditionalLightsCount;
                        static /*0x14*/ int _AdditionalLightsPosition;
                        static /*0x18*/ int _AdditionalLightsColor;
                        static /*0x1c*/ int _AdditionalLightsAttenuation;
                        static /*0x20*/ int _AdditionalLightsSpotDir;
                        static /*0x24*/ int _AdditionalLightOcclusionProbeChannel;
                        static /*0x28*/ int _AdditionalLightsLayerMasks;
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                        /*0x18*/ bool forwardPlus;

                        static /*0x3c837a8*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams Create();
                    }

                    class SetupLightPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.ForwardLights forwardLights;

                        /*0x3c87208*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__44_0;

                        static /*0x3c87210*/ <>c();
                        /*0x3c87278*/ <>c();
                        /*0x3c87280*/ void <SetupRenderGraphLights>b__44_0(UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    }
                }

                class NormalReconstruction
                {
                    static /*0x0*/ int s_NormalReconstructionMatrixID;
                    static /*0x8*/ UnityEngine.Matrix4x4[] s_NormalReconstructionMatrix;

                    static /*0x3c8770c*/ NormalReconstruction();
                    static /*0x3c872b0*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x3c87394*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x3c87624*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    static /*0x3c87424*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                }

                class ColorGradingLutPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Material m_LutBuilderLdr;
                    /*0xc0*/ UnityEngine.Material m_LutBuilderHdr;
                    /*0xc8*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_HdrLutFormat;
                    /*0xcc*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_LdrLutFormat;
                    /*0xd0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData m_PassData;
                    /*0xd8*/ UnityEngine.Rendering.RTHandle m_InternalLut;
                    /*0xe0*/ bool m_AllowColorGradingACESHDR;

                    static /*0x3c87db8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData passData, UnityEngine.Rendering.RTHandle internalLutTarget);
                    static /*0x3c879d8*/ UnityEngine.Material <.ctor>g__Load|7_0(UnityEngine.Shader shader);
                    /*0x3c877b4*/ ColorGradingLutPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x3c87ac4*/ void Setup(ref UnityEngine.Rendering.RTHandle internalLut);
                    /*0x3c87ad0*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x3c87b28*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x3c87bb8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c89058*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle internalColorLut);
                    /*0x3c895d8*/ void Cleanup();

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData;
                        /*0x20*/ UnityEngine.Material lutBuilderLdr;
                        /*0x28*/ UnityEngine.Material lutBuilderHdr;
                        /*0x30*/ bool allowColorGradingACESHDR;
                        /*0x34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle internalLut;

                        /*0x3c87abc*/ PassData();
                    }

                    class ShaderConstants
                    {
                        static /*0x0*/ int _Lut_Params;
                        static /*0x4*/ int _ColorBalance;
                        static /*0x8*/ int _ColorFilter;
                        static /*0xc*/ int _ChannelMixerRed;
                        static /*0x10*/ int _ChannelMixerGreen;
                        static /*0x14*/ int _ChannelMixerBlue;
                        static /*0x18*/ int _HueSatCon;
                        static /*0x1c*/ int _Lift;
                        static /*0x20*/ int _Gamma;
                        static /*0x24*/ int _Gain;
                        static /*0x28*/ int _Shadows;
                        static /*0x2c*/ int _Midtones;
                        static /*0x30*/ int _Highlights;
                        static /*0x34*/ int _ShaHiLimits;
                        static /*0x38*/ int _SplitShadows;
                        static /*0x3c*/ int _SplitHighlights;
                        static /*0x40*/ int _CurveMaster;
                        static /*0x44*/ int _CurveRed;
                        static /*0x48*/ int _CurveGreen;
                        static /*0x4c*/ int _CurveBlue;
                        static /*0x50*/ int _CurveHueVsHue;
                        static /*0x54*/ int _CurveHueVsSat;
                        static /*0x58*/ int _CurveLumVsSat;
                        static /*0x5c*/ int _CurveSatVsSat;

                        static /*0x3c89640*/ ShaderConstants();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;

                        static /*0x3c89b18*/ <>c();
                        /*0x3c89b80*/ <>c();
                        /*0x3c89b88*/ void <Render>b__14_0(UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class CopyColorPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ int m_SampleOffsetShaderHandle;
                    /*0xc0*/ UnityEngine.Material m_SamplingMaterial;
                    /*0xc8*/ UnityEngine.Rendering.Universal.Downsampling m_DownsamplingMethod;
                    /*0xd0*/ UnityEngine.Material m_CopyColorMaterial;
                    /*0xd8*/ UnityEngine.Rendering.RTHandle <source>k__BackingField;
                    /*0xe0*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0xe8*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData m_PassData;

                    static /*0x3c89dcc*/ void ConfigureDescriptor(UnityEngine.Rendering.Universal.Downsampling downsamplingMethod, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    static /*0x3c8a130*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData passData, UnityEngine.Rendering.RTHandle source, bool useDrawProceduralBlit);
                    /*0x3c89c30*/ CopyColorPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material samplingMaterial, UnityEngine.Material copyColorMaterial, string customPassName);
                    /*0x3c89c10*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x3c89c18*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x3c89c20*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x3c89c28*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x3c89e20*/ void Setup(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x3c89e6c*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x3c89ea8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c89ef8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8a520*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x3c8ad0c*/ void RenderToExistingTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x3c8a6bc*/ void RenderInternal(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool useProceduralBlit);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ bool useProceduralBlit;
                        /*0x38*/ UnityEngine.Material samplingMaterial;
                        /*0x40*/ UnityEngine.Material copyColorMaterial;
                        /*0x48*/ UnityEngine.Rendering.Universal.Downsampling downsamplingMethod;
                        /*0x4c*/ int sampleOffsetShaderHandle;

                        /*0x3c89dc4*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;

                        static /*0x3c8adb4*/ <>c();
                        /*0x3c8ae1c*/ <>c();
                        /*0x3c8ae24*/ void <RenderInternal>b__23_0(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class CopyDepthPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Rendering.RTHandle <source>k__BackingField;
                    /*0xc0*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0xc8*/ int <MssaSamples>k__BackingField;
                    /*0xcc*/ bool <CopyToDepth>k__BackingField;
                    /*0xcd*/ bool <CopyToDepthXR>k__BackingField;
                    /*0xce*/ bool <CopyToBackbuffer>k__BackingField;
                    /*0xd0*/ UnityEngine.Material m_CopyDepthMaterial;
                    /*0xd8*/ bool m_CopyResolvedDepth;
                    /*0xd9*/ bool m_ShouldClear;
                    /*0xe0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData m_PassData;

                    static /*0x3c8b3e0*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData passData, UnityEngine.Rendering.RTHandle source);
                    /*0x3c8af0c*/ CopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth, string customPassName);
                    /*0x3c8aeac*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x3c8aeb4*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8aebc*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x3c8aec4*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8aecc*/ int get_MssaSamples();
                    /*0x3c8aed4*/ void set_MssaSamples(int value);
                    /*0x3c8aedc*/ bool get_CopyToDepth();
                    /*0x3c8aee4*/ void set_CopyToDepth(bool value);
                    /*0x3c8aeec*/ bool get_CopyToDepthXR();
                    /*0x3c8aef4*/ void set_CopyToDepthXR(bool value);
                    /*0x3c8aefc*/ bool get_CopyToBackbuffer();
                    /*0x3c8af04*/ void set_CopyToBackbuffer(bool value);
                    /*0x3c8b118*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                    /*0x3c8b154*/ void Dispose();
                    /*0x3c8b1b0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8b1f8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8ba4c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c8bb00*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool bindAsCameraDepth, string passName);
                    /*0x3c8bbe8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool bindAsCameraDepth, string passName);

                    class ShaderConstants
                    {
                        static /*0x0*/ int _CameraDepthAttachment;
                        static /*0x4*/ int _CameraDepthTexture;
                        static /*0x8*/ int _ZWriteShaderHandle;

                        static /*0x3c8c3ec*/ ShaderConstants();
                    }

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x28*/ UnityEngine.Material copyDepthMaterial;
                        /*0x30*/ int msaaSamples;
                        /*0x34*/ bool copyResolvedDepth;
                        /*0x35*/ bool copyToDepth;
                        /*0x36*/ bool isDstBackbuffer;

                        /*0x3c8b110*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__38_0;

                        static /*0x3c8c4bc*/ <>c();
                        /*0x3c8c524*/ <>c();
                        /*0x3c8c52c*/ void <Render>b__38_0(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DeferredPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                    /*0x3c8c5b0*/ DeferredPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x3c8c67c*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescripor);
                    /*0x3c8c6fc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8c860*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer);
                    /*0x3c8d058*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x50*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;

                        /*0x3c8d070*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__5_0;

                        static /*0x3c8d078*/ <>c();
                        /*0x3c8d0e0*/ <>c();
                        /*0x3c8d0e8*/ void <Render>b__5_0(UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DepthNormalOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormals;
                    static /*0x8*/ UnityEngine.Rendering.RTHandle[] k_ColorAttachment1;
                    static /*0x10*/ UnityEngine.Rendering.RTHandle[] k_ColorAttachment2;
                    static /*0x18*/ int s_CameraDepthTextureID;
                    static /*0x1c*/ int s_CameraNormalsTextureID;
                    static /*0x20*/ int s_CameraRenderingLayersTextureID;
                    /*0xb8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> <shaderTagIds>k__BackingField;
                    /*0xc0*/ UnityEngine.Rendering.RTHandle <depthHandle>k__BackingField;
                    /*0xc8*/ UnityEngine.Rendering.RTHandle <normalHandle>k__BackingField;
                    /*0xd0*/ UnityEngine.Rendering.RTHandle <renderingLayersHandle>k__BackingField;
                    /*0xd8*/ bool <enableRenderingLayers>k__BackingField;
                    /*0xdc*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize <renderingLayersMaskSize>k__BackingField;
                    /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x100*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData m_PassData;

                    static /*0x3c8e834*/ DepthNormalOnlyPass();
                    static /*0x3c8d328*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat();
                    static /*0x3c8d604*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                    /*0x3c8d178*/ DepthNormalOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x3c8d118*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> get_shaderTagIds();
                    /*0x3c8d120*/ void set_shaderTagIds(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> value);
                    /*0x3c8d128*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                    /*0x3c8d130*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8d138*/ UnityEngine.Rendering.RTHandle get_normalHandle();
                    /*0x3c8d140*/ void set_normalHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8d148*/ UnityEngine.Rendering.RTHandle get_renderingLayersHandle();
                    /*0x3c8d150*/ void set_renderingLayersHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8d158*/ bool get_enableRenderingLayers();
                    /*0x3c8d160*/ void set_enableRenderingLayers(bool value);
                    /*0x3c8d168*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_renderingLayersMaskSize();
                    /*0x3c8d170*/ void set_renderingLayersMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x3c8d370*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle);
                    /*0x3c8d3a8*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle, UnityEngine.Rendering.RTHandle decalLayerHandle);
                    /*0x3c8d3fc*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8d6f8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8db90*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c8da08*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c8dc74*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;
                        /*0x30*/ bool enableRenderingLayers;
                        /*0x34*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x3c8d320*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__42_0;

                        static /*0x3c8ea6c*/ <>c();
                        /*0x3c8ead4*/ <>c();
                        /*0x3c8eadc*/ void <Render>b__42_0(UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DepthOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.ShaderTagId k_ShaderTagId;
                    static /*0x4*/ int s_CameraDepthTextureID;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0xc0*/ UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat;
                    /*0xc4*/ UnityEngine.Rendering.ShaderTagId <shaderTagId>k__BackingField;
                    /*0xc8*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData m_PassData;
                    /*0xd0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

                    static /*0x3c8fbd4*/ DepthOnlyPass();
                    static /*0x3c8ee7c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
                    /*0x3c8eba4*/ DepthOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x3c8eb84*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x3c8eb8c*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x3c8eb94*/ UnityEngine.Rendering.ShaderTagId get_shaderTagId();
                    /*0x3c8eb9c*/ void set_shaderTagId(UnityEngine.Rendering.ShaderTagId value);
                    /*0x3c8ed78*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle depthAttachmentHandle);
                    /*0x3c8edac*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8ef88*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c8f1d8*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x3c8f360*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, uint batchLayerMask, bool setGlobalDepth);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x3c8ed70*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__20_0;

                        static /*0x3c8fc7c*/ <>c();
                        /*0x3c8fce4*/ <>c();
                        /*0x3c8fcec*/ void <Render>b__20_0(UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DrawObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_DrawObjectPassDataPropID;
                    /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0xd8*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                    /*0x148*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                    /*0x150*/ bool m_IsOpaque;
                    /*0x151*/ bool m_IsActiveTargetBackBuffer;
                    /*0x152*/ bool m_ShouldTransparentsReceiveShadows;
                    /*0x158*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData m_PassData;

                    static /*0x3c91adc*/ DrawObjectsPass();
                    static /*0x3c90a68*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList objectsWithErrorRendererList, bool yFlip);
                    /*0x3c8fd80*/ DrawObjectsPass(string profilerTag, UnityEngine.Rendering.ShaderTagId[] shaderTagIds, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x3c901bc*/ DrawObjectsPass(string profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x3c90200*/ DrawObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x3c8fed0*/ void Init(bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.ShaderTagId[] shaderTagIds);
                    /*0x3c90354*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c90610*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer);
                    /*0x3c90678*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x3c90cac*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, uint batchLayerMask);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle albedoHdl;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHdl;
                        /*0x30*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x38*/ bool isOpaque;
                        /*0x39*/ bool shouldTransparentsReceiveShadows;
                        /*0x3c*/ uint batchLayerMask;
                        /*0x40*/ bool isActiveTargetBackBuffer;
                        /*0x44*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                        /*0x50*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objectsWithErrorRendererListHdl;
                        /*0x60*/ UnityEngine.Rendering.Universal.DebugRendererLists debugRendererLists;
                        /*0x68*/ UnityEngine.Rendering.RendererList rendererList;
                        /*0x80*/ UnityEngine.Rendering.RendererList objectsWithErrorRendererList;

                        /*0x3c9034c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x3c91b44*/ <>c();
                        /*0x3c91bac*/ <>c();
                        /*0x3c91bb4*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DrawObjectsWithRenderingLayersPass : UnityEngine.Rendering.Universal.Internal.DrawObjectsPass
                {
                    /*0x160*/ UnityEngine.Rendering.RTHandle[] m_ColorTargetIndentifiers;
                    /*0x168*/ UnityEngine.Rendering.RTHandle m_DepthTargetIndentifiers;

                    /*0x3c91cf8*/ DrawObjectsWithRenderingLayersPass(UnityEngine.Rendering.Universal.URPProfileId profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x3c91de4*/ void Setup(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle renderingLayersTexture, UnityEngine.Rendering.RTHandle depthAttachment);
                    /*0x3c91f64*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x3c91f70*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c9201c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize, uint batchLayerMask);

                    class RenderingLayersPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData basePassData;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;

                        /*0x3c92d90*/ RenderingLayersPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                        static /*0x3c92dfc*/ <>c();
                        /*0x3c92e64*/ <>c();
                        /*0x3c92e6c*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class FinalBlitPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraDepthTextureID;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_Source;
                    /*0xc0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData m_PassData;
                    /*0xc8*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData[] m_BlitMaterialData;

                    static /*0x3c94a74*/ FinalBlitPass();
                    static /*0x3c932cc*/ void SetupHDROutput(UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperation, UnityEngine.Vector4 hdrOutputParameters, bool rendersOverlayUI);
                    static /*0x3c93ffc*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x3c93038*/ FinalBlitPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial, UnityEngine.Material blitHDRMaterial);
                    /*0x3c93270*/ void Dispose();
                    /*0x3c93274*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                    /*0x3c932c0*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle colorHandle);
                    /*0x3c933e4*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c934c8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c93f50*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData passData, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitType blitType, bool enableAlphaOutput);
                    /*0x3c941cc*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle src, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dest, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture);

                    class BlitPassNames
                    {
                        static string NearestSampler = "NearestDebugDraw";
                        static string BilinearSampler = "BilinearDebugDraw";
                    }

                    enum BlitType
                    {
                        Core = 0,
                        HDR = 1,
                        Count = 2,
                    }

                    struct BlitMaterialData
                    {
                        /*0x10*/ UnityEngine.Material material;
                        /*0x18*/ int nearestSamplerPass;
                        /*0x1c*/ int bilinearSamplerPass;
                    }

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ int sourceID;
                        /*0x34*/ UnityEngine.Vector4 hdrOutputLuminanceParams;
                        /*0x44*/ bool requireSrgbConversion;
                        /*0x45*/ bool enableAlphaOutput;
                        /*0x48*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData blitMaterialData;
                        /*0x58*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                        /*0x3c93268*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x3c94adc*/ <>c();
                        /*0x3c94b44*/ <>c();
                        /*0x3c94b4c*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class GBufferPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraNormalsTextureID;
                    static /*0x4*/ int s_CameraRenderingLayersTextureID;
                    static /*0x8*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagLit;
                    static /*0xc*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagSimpleLit;
                    static /*0x10*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUnlit;
                    static /*0x14*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagComplexLit;
                    static /*0x18*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalGBuffer;
                    static /*0x1c*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalMaterialType;
                    static /*0x20*/ UnityEngine.Rendering.ShaderTagId[] s_ShaderTagValues;
                    static /*0x28*/ UnityEngine.Rendering.RenderStateBlock[] s_RenderStateBlocks;
                    /*0xb8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                    /*0xc0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0xe0*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                    /*0x150*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData m_PassData;

                    static /*0x3c96ba4*/ GBufferPass();
                    static /*0x3c95e94*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList errorRendererList);
                    /*0x3c94f20*/ GBufferPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x3c95490*/ void Dispose();
                    /*0x3c954a4*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x3c9579c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c95b14*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool useRenderGraph);
                    /*0x3c95fac*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;
                        /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                        /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objectsWithErrorRendererListHdl;
                        /*0x48*/ UnityEngine.Rendering.RendererList rendererList;
                        /*0x60*/ UnityEngine.Rendering.RendererList objectsWithErrorRendererList;

                        /*0x3c96db4*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__21_0;

                        static /*0x3c96dbc*/ <>c();
                        /*0x3c96e24*/ <>c();
                        /*0x3c96e2c*/ void <Render>b__21_0(UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class MainLightShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_EmptyShadowMapDimensions = 1;
                    static int k_MaxCascades = 4;
                    static int k_ShadowmapBufferBits = 16;
                    static string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";
                    static string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";
                    static /*0x0*/ UnityEngine.Vector4 s_EmptyShadowParams;
                    static /*0x10*/ UnityEngine.Vector4 s_EmptyShadowmapSize;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_MainLightShadowmapTexture;
                    /*0xc0*/ int renderTargetWidth;
                    /*0xc4*/ int renderTargetHeight;
                    /*0xc8*/ int m_ShadowCasterCascadesCount;
                    /*0xcc*/ bool m_CreateEmptyShadowmap;
                    /*0xcd*/ bool m_SetKeywordForEmptyShadowmap;
                    /*0xce*/ bool m_EmptyShadowmapNeedsClear;
                    /*0xd0*/ float m_CascadeBorder;
                    /*0xd4*/ float m_MaxShadowDistanceSq;
                    /*0xd8*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData m_PassData;
                    /*0xe0*/ UnityEngine.Rendering.RTHandle m_EmptyMainLightShadowmapTexture;
                    /*0xe8*/ UnityEngine.RenderTextureDescriptor m_MainLightShadowDescriptor;
                    /*0x120*/ UnityEngine.Vector4[] m_CascadeSplitDistances;
                    /*0x128*/ UnityEngine.Matrix4x4[] m_MainLightShadowMatrices;
                    /*0x130*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;
                    /*0x138*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_CascadeSlices;

                    static /*0x3c998e8*/ MainLightShadowCasterPass();
                    static /*0x3c980f4*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x3c96ef0*/ MainLightShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x3c97168*/ void Dispose();
                    /*0x3c9719c*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c97280*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c97c00*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x3c97a38*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UnityEngine.Light light, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c97cac*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x3c97df0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3c97908*/ void Clear();
                    /*0x3c984a8*/ void RenderMainLightCascadeShadowmap(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, bool isRenderGraph);
                    /*0x3c98b44*/ void SetupMainLightShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c981cc*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x3c98278*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x3c98fe4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

                    class MainLightShadowConstantBuffer
                    {
                        static /*0x0*/ int _WorldToShadow;
                        static /*0x4*/ int _ShadowParams;
                        static /*0x8*/ int _CascadeShadowSplitSpheres0;
                        static /*0xc*/ int _CascadeShadowSplitSpheres1;
                        static /*0x10*/ int _CascadeShadowSplitSpheres2;
                        static /*0x14*/ int _CascadeShadowSplitSpheres3;
                        static /*0x18*/ int _CascadeShadowSplitSphereRadii;
                        static /*0x1c*/ int _ShadowOffset0;
                        static /*0x20*/ int _ShadowOffset1;
                        static /*0x24*/ int _ShadowmapSize;
                        static /*0x28*/ int _MainLightShadowmapID;

                        static /*0x3c99948*/ MainLightShadowConstantBuffer();
                    }

                    class PassData
                    {
                        /*0x10*/ bool emptyShadowmap;
                        /*0x11*/ bool setKeywordForEmptyShadowmap;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x28*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x30*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x38*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass pass;
                        /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x50*/ UnityEngine.Rendering.RendererList[] shadowRendererLists;
                        /*0x58*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle[] shadowRendererListsHandle;

                        /*0x3c970cc*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__39_0;

                        static /*0x3c99bb0*/ <>c();
                        /*0x3c99c18*/ <>c();
                        /*0x3c99c20*/ void <Render>b__39_0(UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class RenderTargetBufferSystem
                {
                    static /*0x0*/ bool m_AisBackBuffer;
                    static /*0x4*/ UnityEngine.RenderTextureDescriptor m_Desc;
                    /*0x10*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_A;
                    /*0x30*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_B;
                    /*0x50*/ UnityEngine.FilterMode m_FilterMode;
                    /*0x54*/ bool m_AllowMSAA;

                    static /*0x3c9a448*/ RenderTargetBufferSystem();
                    /*0x3c99dc8*/ RenderTargetBufferSystem(string name);
                    /*0x3c99cf0*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_backBuffer();
                    /*0x3c99d5c*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_frontBuffer();
                    /*0x3c99e78*/ void Dispose();
                    /*0x3c99ecc*/ UnityEngine.Rendering.RTHandle PeekBackBuffer();
                    /*0x3c99f14*/ UnityEngine.Rendering.RTHandle GetBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c9a158*/ UnityEngine.Rendering.RTHandle GetFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c9a1e4*/ void Swap();
                    /*0x3c99f2c*/ void ReAllocate(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3c9a244*/ void Clear();
                    /*0x3c9a2c0*/ void SetCameraSettings(UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x3c9a420*/ UnityEngine.Rendering.RTHandle GetBufferA();
                    /*0x3c9a3a4*/ void EnableMSAA(bool enable);

                    struct SwapBuffer
                    {
                        /*0x10*/ UnityEngine.Rendering.RTHandle rtMSAA;
                        /*0x18*/ UnityEngine.Rendering.RTHandle rtResolve;
                        /*0x20*/ string name;
                        /*0x28*/ int msaa;
                    }
                }

                enum StencilUsage
                {
                    UserMask = 15,
                    StencilLight = 16,
                    MaterialMask = 96,
                    MaterialUnlit = 0,
                    MaterialLit = 32,
                    MaterialSimpleLit = 64,
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6;
    static /*0x10*/ <PrivateImplementationDetails> 18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34;
    static /*0x28*/ <PrivateImplementationDetails> 4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D;
    static /*0x34*/ <PrivateImplementationDetails> 6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64;
    static /*0x3f4*/ <PrivateImplementationDetails> 6A4DCF2E6C3AF9695B244D170D663282976BAF9D022FF5D445F95CC0CA5E73CA;
    static /*0x4df4*/ <PrivateImplementationDetails> 888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1;
    static /*0x4e04*/ <PrivateImplementationDetails> 952F64AAAB6BA3EC372BD120F69E1B881AA6D7F630FDE93112C667448DE5ACA1;
    static /*0xacdd*/ <PrivateImplementationDetails> 9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD;
    static /*0xace9*/ <PrivateImplementationDetails> B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;
    static /*0xacf5*/ <PrivateImplementationDetails> BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE;
    static /*0xad05*/ <PrivateImplementationDetails> C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101;
    static /*0xad15*/ <PrivateImplementationDetails> E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=960
    {
    }

    struct __StaticArrayInitTypeSize=18944
    {
    }

    struct __StaticArrayInitTypeSize=24281
    {
    }
}
