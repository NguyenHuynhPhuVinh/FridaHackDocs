class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7c03b74*/ EmbeddedAttribute();
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
                /*0x7c03b7c*/ IsUnmanagedAttribute();
            }
        }
    }
}

class FullScreenPassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature, UnityEngine.ISerializationCallbackReceiver
{
    /*0x1c*/ FullScreenPassRendererFeature.InjectionPoint injectionPoint;
    /*0x20*/ bool fetchColorBuffer;
    /*0x24*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput requirements;
    /*0x28*/ UnityEngine.Material passMaterial;
    /*0x30*/ int passIndex;
    /*0x34*/ bool bindDepthStencilAttachment;
    /*0x38*/ FullScreenPassRendererFeature.FullScreenRenderPass m_FullScreenPass;
    /*0x40*/ FullScreenPassRendererFeature.Version m_Version;

    /*0x7c04040*/ FullScreenPassRendererFeature();
    /*0x7c03b84*/ void Create();
    /*0x7c03c98*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
    /*0x7c03cac*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
    /*0x7c03fc8*/ void Dispose(bool disposing);
    /*0x7c04008*/ void UpgradeIfNeeded();
    /*0x7c0400c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    /*0x7c04028*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

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

        static /*0x7c0548c*/ FullScreenRenderPass();
        static /*0x7c04160*/ void ExecuteCopyColorPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture);
        static /*0x7c041e0*/ void ExecuteMainPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Material material, int passIndex);
        /*0x7c03bf8*/ FullScreenRenderPass(string passName);
        /*0x7c03f84*/ void SetupMembers(UnityEngine.Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment);
        /*0x7c04060*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
        /*0x7c040c4*/ void ReAllocate(UnityEngine.RenderTextureDescriptor desc);
        /*0x7c03ff4*/ void Dispose();
        /*0x7c043d0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
        /*0x7c046ec*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

        class CopyPassData
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

            /*0x7c05508*/ CopyPassData();
        }

        class MainPassData
        {
            /*0x10*/ UnityEngine.Material material;
            /*0x18*/ int passIndex;
            /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

            /*0x7c05510*/ MainPassData();
        }

        class <>c
        {
            static /*0x0*/ FullScreenPassRendererFeature.FullScreenRenderPass.<> <>9;
            static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;
            static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_1;

            static /*0x7c05518*/ <>c();
            /*0x7c05580*/ <>c();
            /*0x7c05588*/ void <RecordRenderGraph>b__14_0(FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
            /*0x7c05634*/ void <RecordRenderGraph>b__14_1(FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7c056f4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7c057e8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    namespace VFX
    {
        namespace Utility
        {
            class URPCameraBinder : UnityEngine.VFX.Utility.VFXBinderBase
            {
                /*0x28*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData AdditionalData;
                /*0x30*/ UnityEngine.Camera m_Camera;
                /*0x38*/ UnityEngine.VFX.Utility.ExposedProperty CameraProperty;
                /*0x40*/ UnityEngine.VFX.Utility.ExposedProperty m_Position;
                /*0x48*/ UnityEngine.VFX.Utility.ExposedProperty m_Angles;
                /*0x50*/ UnityEngine.VFX.Utility.ExposedProperty m_Scale;
                /*0x58*/ UnityEngine.VFX.Utility.ExposedProperty m_FieldOfView;
                /*0x60*/ UnityEngine.VFX.Utility.ExposedProperty m_NearPlane;
                /*0x68*/ UnityEngine.VFX.Utility.ExposedProperty m_FarPlane;
                /*0x70*/ UnityEngine.VFX.Utility.ExposedProperty m_AspectRatio;
                /*0x78*/ UnityEngine.VFX.Utility.ExposedProperty m_Dimensions;
                /*0x80*/ UnityEngine.VFX.Utility.ExposedProperty m_ScaledDimensions;
                /*0x88*/ UnityEngine.VFX.Utility.ExposedProperty m_DepthBuffer;
                /*0x90*/ UnityEngine.VFX.Utility.ExposedProperty m_ColorBuffer;
                /*0x98*/ UnityEngine.VFX.Utility.ExposedProperty m_Orthographic;
                /*0xa0*/ UnityEngine.VFX.Utility.ExposedProperty m_OrthographicSize;
                /*0xa8*/ UnityEngine.VFX.Utility.ExposedProperty m_LensShift;

                static /*0x7c05c94*/ void RequestHistoryAccess(UnityEngine.Rendering.IPerFrameHistoryAccessTracker access);
                /*0x7c06bec*/ URPCameraBinder();
                /*0x7c057f0*/ void SetCameraProperty(string name);
                /*0x7c05820*/ void UpdateSubProperties();
                /*0x7c05dd4*/ void OnEnable();
                /*0x7c05f18*/ void OnDisable();
                /*0x7c06060*/ void OnValidate();
                /*0x7c061a4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7c06414*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7c06aac*/ string ToString();
            }
        }
    }

    namespace Rendering
    {
        class RenderGraphGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;

            static /*0x7c06db0*/ RenderGraphGraphicsAutomatedTests();
            static /*0x7c06c50*/ bool get_activatedFromCommandLine();
            static /*0x7c06d58*/ bool get_enabled();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphGraphicsAutomatedTests.<> <>9;
                static /*0x8*/ System.Predicate<string> <>9__1_0;

                static /*0x7c06e00*/ <>c();
                /*0x7c06e68*/ <>c();
                /*0x7c06e70*/ bool <get_activatedFromCommandLine>b__1_0(string arg);
            }
        }

        namespace Universal
        {
            class ComponentUtility
            {
                static /*0x7c06ebc*/ bool IsUniversalCamera(UnityEngine.Camera camera);
                static /*0x7c06f48*/ bool IsUniversalLight(UnityEngine.Light light);
            }

            class PostProcessData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessData.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessData.TextureResources textures;

                /*0x7c06fd4*/ PostProcessData();

                class ShaderResources
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

                    /*0x7c06fdc*/ ShaderResources();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D[] blueNoise16LTex;
                    /*0x18*/ UnityEngine.Texture2D[] filmGrainTex;
                    /*0x20*/ UnityEngine.Texture2D smaaAreaTex;
                    /*0x28*/ UnityEngine.Texture2D smaaSearchTex;

                    /*0x7c06fe4*/ TextureResources();
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

                /*0x7c06fec*/ StencilStateData();
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

                static /*0x7c09474*/ UniversalRenderPipelineAsset();
                /*0x7c092a4*/ UniversalRenderPipelineAsset();
                /*0x7c06ffc*/ bool IsAtLastVersion();
                /*0x7c0700c*/ UnityEngine.Rendering.GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.get_gpuResidentDrawerSettings();
                /*0x7c070f8*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRendererData> get_rendererDataList();
                /*0x7c07140*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRenderer> get_renderers();
                /*0x7c07188*/ bool get_isImmediateModeSupported();
                /*0x7c07190*/ UnityEngine.Rendering.Universal.ScriptableRendererData LoadBuiltinRendererData(UnityEngine.Rendering.Universal.RendererType type);
                /*0x7c071d8*/ void EnsureGlobalSettings();
                /*0x7c071e0*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
                /*0x7c0739c*/ void DestroyRenderers();
                /*0x7c07630*/ void DestroyRenderer(ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x7c07664*/ void OnDisable();
                /*0x7c073fc*/ void CreateRenderers();
                /*0x7c07680*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x7c07974*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(int index);
                /*0x7c078b4*/ UnityEngine.Rendering.Universal.ScriptableRendererData get_scriptableRendererData();
                /*0x7c07c38*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_additionalLightsCookieFormat();
                /*0x7c07e64*/ UnityEngine.Vector2Int get_additionalLightsCookieResolution();
                /*0x7c07e70*/ int[] get_rendererIndexList();
                /*0x7c07f0c*/ bool get_supportsCameraDepthTexture();
                /*0x7c07f14*/ void set_supportsCameraDepthTexture(bool value);
                /*0x7c07f20*/ bool get_supportsCameraOpaqueTexture();
                /*0x7c07f28*/ void set_supportsCameraOpaqueTexture(bool value);
                /*0x7c07f34*/ UnityEngine.Rendering.Universal.Downsampling get_opaqueDownsampling();
                /*0x7c07f3c*/ bool get_supportsTerrainHoles();
                /*0x7c07f44*/ UnityEngine.Rendering.Universal.StoreActionsOptimization get_storeActionsOptimization();
                /*0x7c07f4c*/ void set_storeActionsOptimization(UnityEngine.Rendering.Universal.StoreActionsOptimization value);
                /*0x7c07f54*/ bool get_supportsHDR();
                /*0x7c07f5c*/ void set_supportsHDR(bool value);
                /*0x7c07f68*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x7c07f70*/ void set_hdrColorBufferPrecision(UnityEngine.Rendering.Universal.HDRColorBufferPrecision value);
                /*0x7c07f78*/ int get_msaaSampleCount();
                /*0x7c07f80*/ void set_msaaSampleCount(int value);
                /*0x7c07f88*/ float get_renderScale();
                /*0x7c07f90*/ void set_renderScale(float value);
                /*0x7c08024*/ bool get_enableLODCrossFade();
                /*0x7c0802c*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType get_lodCrossFadeDitheringType();
                /*0x7c08034*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection get_upscalingFilter();
                /*0x7c0803c*/ void set_upscalingFilter(UnityEngine.Rendering.Universal.UpscalingFilterSelection value);
                /*0x7c08044*/ bool get_fsrOverrideSharpness();
                /*0x7c0804c*/ void set_fsrOverrideSharpness(bool value);
                /*0x7c08058*/ float get_fsrSharpness();
                /*0x7c08060*/ void set_fsrSharpness(float value);
                /*0x7c08068*/ UnityEngine.Rendering.Universal.ShEvalMode get_shEvalMode();
                /*0x7c08070*/ void set_shEvalMode(UnityEngine.Rendering.Universal.ShEvalMode value);
                /*0x7c08078*/ UnityEngine.Rendering.Universal.LightProbeSystem get_lightProbeSystem();
                /*0x7c08080*/ void set_lightProbeSystem(UnityEngine.Rendering.Universal.LightProbeSystem value);
                /*0x7c08088*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_probeVolumeMemoryBudget();
                /*0x7c08090*/ void set_probeVolumeMemoryBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget value);
                /*0x7c08098*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget get_probeVolumeBlendingMemoryBudget();
                /*0x7c080a0*/ void set_probeVolumeBlendingMemoryBudget(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget value);
                /*0x7c080a8*/ bool get_supportProbeVolumeStreaming();
                /*0x7c080b0*/ void set_supportProbeVolumeStreaming(bool value);
                /*0x7c080bc*/ bool get_supportProbeVolumeGPUStreaming();
                /*0x7c080c4*/ void set_supportProbeVolumeGPUStreaming(bool value);
                /*0x7c080d0*/ bool get_supportProbeVolumeDiskStreaming();
                /*0x7c080d8*/ void set_supportProbeVolumeDiskStreaming(bool value);
                /*0x7c080e4*/ bool get_supportProbeVolumeScenarios();
                /*0x7c080ec*/ void set_supportProbeVolumeScenarios(bool value);
                /*0x7c080f8*/ bool get_supportProbeVolumeScenarioBlending();
                /*0x7c08100*/ void set_supportProbeVolumeScenarioBlending(bool value);
                /*0x7c0810c*/ UnityEngine.Rendering.ProbeVolumeSHBands get_probeVolumeSHBands();
                /*0x7c08114*/ void set_probeVolumeSHBands(UnityEngine.Rendering.ProbeVolumeSHBands value);
                /*0x7c0811c*/ UnityEngine.Rendering.Universal.LightRenderingMode get_mainLightRenderingMode();
                /*0x7c08124*/ void set_mainLightRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x7c0812c*/ bool get_supportsMainLightShadows();
                /*0x7c08134*/ void set_supportsMainLightShadows(bool value);
                /*0x7c08140*/ int get_mainLightShadowmapResolution();
                /*0x7c08148*/ void set_mainLightShadowmapResolution(int value);
                /*0x7c08150*/ UnityEngine.Rendering.Universal.LightRenderingMode get_additionalLightsRenderingMode();
                /*0x7c08158*/ void set_additionalLightsRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x7c08160*/ int get_maxAdditionalLightsCount();
                /*0x7c08168*/ void set_maxAdditionalLightsCount(int value);
                /*0x7c08220*/ bool get_supportsAdditionalLightShadows();
                /*0x7c08228*/ void set_supportsAdditionalLightShadows(bool value);
                /*0x7c08234*/ int get_additionalLightsShadowmapResolution();
                /*0x7c0823c*/ void set_additionalLightsShadowmapResolution(int value);
                /*0x7c08244*/ int get_additionalLightsShadowResolutionTierLow();
                /*0x7c0824c*/ void set_additionalLightsShadowResolutionTierLow(int value);
                /*0x7c08254*/ int get_additionalLightsShadowResolutionTierMedium();
                /*0x7c0825c*/ void set_additionalLightsShadowResolutionTierMedium(int value);
                /*0x7c08264*/ int get_additionalLightsShadowResolutionTierHigh();
                /*0x7c0826c*/ void set_additionalLightsShadowResolutionTierHigh(int value);
                /*0x7c08274*/ int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier);
                /*0x7c0833c*/ bool get_reflectionProbeBlending();
                /*0x7c08344*/ void set_reflectionProbeBlending(bool value);
                /*0x7c08350*/ bool get_reflectionProbeBoxProjection();
                /*0x7c08358*/ void set_reflectionProbeBoxProjection(bool value);
                /*0x7c08364*/ float get_shadowDistance();
                /*0x7c0836c*/ void set_shadowDistance(float value);
                /*0x7c0837c*/ int get_shadowCascadeCount();
                /*0x7c08384*/ void set_shadowCascadeCount(int value);
                /*0x7c08458*/ float get_cascade2Split();
                /*0x7c08460*/ void set_cascade2Split(float value);
                /*0x7c08468*/ UnityEngine.Vector2 get_cascade3Split();
                /*0x7c08470*/ void set_cascade3Split(UnityEngine.Vector2 value);
                /*0x7c08478*/ UnityEngine.Vector3 get_cascade4Split();
                /*0x7c08484*/ void set_cascade4Split(UnityEngine.Vector3 value);
                /*0x7c08490*/ float get_cascadeBorder();
                /*0x7c08498*/ void set_cascadeBorder(float value);
                /*0x7c084a0*/ float get_shadowDepthBias();
                /*0x7c084a8*/ void set_shadowDepthBias(float value);
                /*0x7c08530*/ float get_shadowNormalBias();
                /*0x7c08538*/ void set_shadowNormalBias(float value);
                /*0x7c08550*/ bool get_supportsSoftShadows();
                /*0x7c08558*/ void set_supportsSoftShadows(bool value);
                /*0x7c08564*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x7c0856c*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x7c08574*/ bool get_supportsDynamicBatching();
                /*0x7c0857c*/ void set_supportsDynamicBatching(bool value);
                /*0x7c08588*/ bool get_supportsMixedLighting();
                /*0x7c08590*/ bool get_supportsLightCookies();
                /*0x7c08598*/ bool get_supportsLightLayers();
                /*0x7c085a0*/ bool get_useRenderingLayers();
                /*0x7c085a8*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x7c085b0*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x7c085b8*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
                /*0x7c085c8*/ UnityEngine.Rendering.Universal.PipelineDebugLevel get_debugLevel();
                /*0x7c085d0*/ bool get_useSRPBatcher();
                /*0x7c085d8*/ void set_useSRPBatcher(bool value);
                /*0x7c085e4*/ bool get_enableRenderGraph();
                /*0x7c086e8*/ void OnEnableRenderGraphChanged();
                /*0x7c086f8*/ UnityEngine.Rendering.Universal.ColorGradingMode get_colorGradingMode();
                /*0x7c08700*/ void set_colorGradingMode(UnityEngine.Rendering.Universal.ColorGradingMode value);
                /*0x7c08708*/ int get_colorGradingLutSize();
                /*0x7c08710*/ void set_colorGradingLutSize(int value);
                /*0x7c08730*/ bool get_allowPostProcessAlphaOutput();
                /*0x7c08738*/ bool get_useFastSRGBLinearConversion();
                /*0x7c08740*/ bool get_supportScreenSpaceLensFlare();
                /*0x7c08748*/ bool get_supportDataDrivenLensFlare();
                /*0x7c08750*/ bool get_useAdaptivePerformance();
                /*0x7c08758*/ void set_useAdaptivePerformance(bool value);
                /*0x7c08764*/ bool get_conservativeEnclosingSphere();
                /*0x7c0876c*/ void set_conservativeEnclosingSphere(bool value);
                /*0x7c08778*/ int get_numIterationsEnclosingSphere();
                /*0x7c08780*/ void set_numIterationsEnclosingSphere(int value);
                /*0x7c08788*/ string get_renderPipelineShaderTag();
                /*0x7c087c8*/ string[] get_renderingLayerMaskNames();
                /*0x7c08818*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x7c088a4*/ string[] get_lightLayerMaskNames();
                /*0x7c088e8*/ UnityEngine.Rendering.GPUResidentDrawerMode get_gpuResidentDrawerMode();
                /*0x7c088f0*/ void set_gpuResidentDrawerMode(UnityEngine.Rendering.GPUResidentDrawerMode value);
                /*0x7c08914*/ bool get_gpuResidentDrawerEnableOcclusionCullingInCameras();
                /*0x7c0891c*/ void set_gpuResidentDrawerEnableOcclusionCullingInCameras(bool value);
                /*0x7c08944*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severty);
                /*0x7c08aa4*/ float get_smallMeshScreenPercentage();
                /*0x7c08aac*/ void set_smallMeshScreenPercentage(float value);
                /*0x7c08b58*/ void OnBeforeSerialize();
                /*0x7c08b5c*/ void OnAfterDeserialize();
                /*0x7c084c0*/ float ValidateShadowBias(float value);
                /*0x7c08180*/ int ValidatePerObjectLights(int value);
                /*0x7c07fa8*/ float ValidateRenderScale(float value);
                /*0x7c08de8*/ bool ValidateRendererDataList(bool partial);
                /*0x7c08e68*/ bool ValidateRendererData(int index);
                /*0x7c08f0c*/ bool get_supportProbeVolume();
                /*0x7c08f1c*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
                /*0x7c08f38*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
                /*0x7c08f40*/ bool get_isStpUsed();
                /*0x7c08f50*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DefaultMaterialType materialType);
                /*0x7c08f58*/ UnityEngine.Material get_defaultMaterial();
                /*0x7c08f60*/ UnityEngine.Material get_defaultParticleMaterial();
                /*0x7c08f68*/ UnityEngine.Material get_defaultLineMaterial();
                /*0x7c08f70*/ UnityEngine.Material get_defaultTerrainMaterial();
                /*0x7c08f78*/ UnityEngine.Material get_default2DMaterial();
                /*0x7c08f80*/ UnityEngine.Material get_default2DMaskMaterial();
                /*0x7c08f88*/ UnityEngine.Material get_decalMaterial();
                /*0x7c08f90*/ UnityEngine.Shader get_defaultShader();
                /*0x7c09048*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x7c090bc*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.Universal.ShaderVariantLogLevel value);
                /*0x7c09138*/ UnityEngine.Rendering.Universal.ShadowCascadesOption get_shadowCascadeOption();
                /*0x7c091bc*/ void set_shadowCascadeOption(UnityEngine.Rendering.Universal.ShadowCascadesOption value);
                /*0x7c09228*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources get_textures();

                class Strings
                {
                    static /*0x0*/ string notURPRenderer;
                    static /*0x8*/ string forwardPlusMissing;

                    static /*0x7c09684*/ Strings();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D blueNoise64LTex;
                    /*0x18*/ UnityEngine.Texture2D bayerMatrixTex;

                    /*0x7c0929c*/ TextureResources();
                    /*0x7c09720*/ bool NeedsReload();
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
                /*0x7c09b98*/ DebugDisplaySettingsCommon();
                /*0x7c097b8*/ bool get_AreAnySettingsActive();
                /*0x7c097c0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
                {
                    static string k_GoToSectionString = "Go to Section...";

                    /*0x7c09810*/ SettingsPanel();
                    /*0x7c09ba0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.DebugUI.Foldout foldout;

                        /*0x7c09ba8*/ <>c__DisplayClass3_0();
                        /*0x7c09bb0*/ void <.ctor>b__0();
                    }
                }
            }

            class DebugDisplaySettingsLighting : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugLightingMode <lightingDebugMode>k__BackingField;
                /*0x14*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode <hdrDebugMode>k__BackingField;

                /*0x7c09ec8*/ DebugDisplaySettingsLighting();
                /*0x7c09c78*/ UnityEngine.Rendering.Universal.DebugLightingMode get_lightingDebugMode();
                /*0x7c09c80*/ void set_lightingDebugMode(UnityEngine.Rendering.Universal.DebugLightingMode value);
                /*0x7c09c88*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags get_lightingFeatureFlags();
                /*0x7c09c90*/ void set_lightingFeatureFlags(UnityEngine.Rendering.Universal.DebugLightingFeatureFlags value);
                /*0x7c09c98*/ UnityEngine.Rendering.Universal.HDRDebugMode get_hdrDebugMode();
                /*0x7c09ca0*/ void set_hdrDebugMode(UnityEngine.Rendering.Universal.HDRDebugMode value);
                /*0x7c09ca8*/ bool get_AreAnySettingsActive();
                /*0x7c09cd0*/ bool get_IsPostProcessingAllowed();
                /*0x7c09ce4*/ bool get_IsLightingActive();
                /*0x7c09cec*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingDebugMode;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingFeatures;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDRDebugMode;

                    static /*0x7c09ed0*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c0a06c*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x7c0a2f0*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingFeatures(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x7c0a4ec*/ UnityEngine.Rendering.DebugUI.Widget CreateHDRDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c0a2e8*/ <>c__DisplayClass0_0();
                        /*0x7c0a770*/ int <CreateLightingDebugMode>b__0();
                        /*0x7c0a7c0*/ void <CreateLightingDebugMode>b__1(int value);
                        /*0x7c0a814*/ int <CreateLightingDebugMode>b__2();
                        /*0x7c0a864*/ void <CreateLightingDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c0a4e4*/ <>c__DisplayClass1_0();
                        /*0x7c0a8b8*/ System.Enum <CreateLightingFeatures>b__0();
                        /*0x7c0a92c*/ void <CreateLightingFeatures>b__1(System.Enum value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c0a768*/ <>c__DisplayClass2_0();
                        /*0x7c0a9c0*/ int <CreateHDRDebugMode>b__0();
                        /*0x7c0aa10*/ void <CreateHDRDebugMode>b__1(int value);
                        /*0x7c0aa64*/ int <CreateHDRDebugMode>b__2();
                        /*0x7c0aab4*/ void <CreateHDRDebugMode>b__3(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting>
                {
                    /*0x7c09d44*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
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

                /*0x7c0b744*/ DebugDisplaySettingsMaterial();
                /*0x7c0ab08*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoValidationPreset();
                /*0x7c0ab10*/ void set_albedoValidationPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value);
                /*0x7c0ab54*/ float get_albedoMinLuminance();
                /*0x7c0ab5c*/ void set_albedoMinLuminance(float value);
                /*0x7c0ab64*/ float get_albedoMaxLuminance();
                /*0x7c0ab6c*/ void set_albedoMaxLuminance(float value);
                /*0x7c0ab74*/ float get_albedoHueTolerance();
                /*0x7c0ab8c*/ void set_albedoHueTolerance(float value);
                /*0x7c0ab94*/ float get_albedoSaturationTolerance();
                /*0x7c0abac*/ void set_albedoSaturationTolerance(float value);
                /*0x7c0abb4*/ UnityEngine.Color get_albedoCompareColor();
                /*0x7c0abc0*/ void set_albedoCompareColor(UnityEngine.Color value);
                /*0x7c0abcc*/ float get_metallicMinValue();
                /*0x7c0abd4*/ void set_metallicMinValue(float value);
                /*0x7c0abdc*/ float get_metallicMaxValue();
                /*0x7c0abe4*/ void set_metallicMaxValue(float value);
                /*0x7c0abec*/ bool get_renderingLayersSelectedLight();
                /*0x7c0abf4*/ void set_renderingLayersSelectedLight(bool value);
                /*0x7c0ac00*/ bool get_selectedLightShadowLayerMask();
                /*0x7c0ac08*/ void set_selectedLightShadowLayerMask(bool value);
                /*0x7c0ac14*/ uint get_renderingLayerMask();
                /*0x7c0ac1c*/ void set_renderingLayerMask(uint value);
                /*0x7c0ac24*/ uint GetDebugLightLayersMask();
                /*0x7c0ac2c*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode get_materialValidationMode();
                /*0x7c0ac34*/ void set_materialValidationMode(UnityEngine.Rendering.Universal.DebugMaterialValidationMode value);
                /*0x7c0ac3c*/ UnityEngine.Rendering.Universal.DebugMaterialMode get_materialDebugMode();
                /*0x7c0ac44*/ void set_materialDebugMode(UnityEngine.Rendering.Universal.DebugMaterialMode value);
                /*0x7c0ac4c*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode get_vertexAttributeDebugMode();
                /*0x7c0ac54*/ void set_vertexAttributeDebugMode(UnityEngine.Rendering.Universal.DebugVertexAttributeMode value);
                /*0x7c0ac5c*/ bool get_AreAnySettingsActive();
                /*0x7c0ac84*/ bool get_IsPostProcessingAllowed();
                /*0x7c0acac*/ bool get_IsLightingActive();
                /*0x7c0acd4*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip RenderingLayerColors;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip FilterRenderingLayerMask;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValidationPreset;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoCustomColor;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;
                    static /*0xb0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;
                    static /*0xc0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;
                    static /*0xd0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMinValue;
                    static /*0xe0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMaxValue;

                    static /*0x7c0c1e8*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c0c844*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialOverride(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0cac8*/ UnityEngine.Rendering.DebugUI.Widget CreateVertexAttribute(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0cd4c*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0d08c*/ UnityEngine.Rendering.DebugUI.Widget CreateRenderingLayersSelectedLight(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0d244*/ UnityEngine.Rendering.DebugUI.Widget CreateSelectedLightShadowLayerMask(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0d43c*/ UnityEngine.Rendering.DebugUI.Widget CreateFilterRenderingLayerMasks(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0d648*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0d988*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoCustomColor(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0db94*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMinLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0dd50*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMaxLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0df0c*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoHueTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0e124*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoSaturationTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0e33c*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMinValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c0e4f8*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMaxValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x10*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__6_4;

                        static /*0x7c0e6b4*/ <>c();
                        /*0x7c0e71c*/ <>c();
                        /*0x7c0e724*/ void <CreateMaterialValidationMode>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c0e784*/ void <CreateAlbedoPreset>b__6_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0cac0*/ <>c__DisplayClass0_0();
                        /*0x7c0e7e4*/ int <CreateMaterialOverride>b__0();
                        /*0x7c0e834*/ void <CreateMaterialOverride>b__1(int value);
                        /*0x7c0e888*/ int <CreateMaterialOverride>b__2();
                        /*0x7c0e8d8*/ void <CreateMaterialOverride>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0e11c*/ <>c__DisplayClass10_0();
                        /*0x7c0e92c*/ float <CreateAlbedoHueTolerance>b__0();
                        /*0x7c0e98c*/ void <CreateAlbedoHueTolerance>b__1(float value);
                        /*0x7c0e9e8*/ bool <CreateAlbedoHueTolerance>b__2();
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0e334*/ <>c__DisplayClass11_0();
                        /*0x7c0ea40*/ float <CreateAlbedoSaturationTolerance>b__0();
                        /*0x7c0eaa0*/ void <CreateAlbedoSaturationTolerance>b__1(float value);
                        /*0x7c0eafc*/ bool <CreateAlbedoSaturationTolerance>b__2();
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0e4f0*/ <>c__DisplayClass12_0();
                        /*0x7c0eb54*/ float <CreateMetallicMinValue>b__0();
                        /*0x7c0eba4*/ void <CreateMetallicMinValue>b__1(float value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0e6ac*/ <>c__DisplayClass13_0();
                        /*0x7c0ec00*/ float <CreateMetallicMaxValue>b__0();
                        /*0x7c0ec50*/ void <CreateMetallicMaxValue>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0cd44*/ <>c__DisplayClass1_0();
                        /*0x7c0ecac*/ int <CreateVertexAttribute>b__0();
                        /*0x7c0ecfc*/ void <CreateVertexAttribute>b__1(int value);
                        /*0x7c0ed50*/ int <CreateVertexAttribute>b__2();
                        /*0x7c0eda0*/ void <CreateVertexAttribute>b__3(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0d084*/ <>c__DisplayClass2_0();
                        /*0x7c0edf4*/ int <CreateMaterialValidationMode>b__0();
                        /*0x7c0ee44*/ void <CreateMaterialValidationMode>b__1(int value);
                        /*0x7c0ee98*/ int <CreateMaterialValidationMode>b__2();
                        /*0x7c0eee8*/ void <CreateMaterialValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0d23c*/ <>c__DisplayClass3_0();
                        /*0x7c0ef3c*/ bool <CreateRenderingLayersSelectedLight>b__0();
                        /*0x7c0ef8c*/ void <CreateRenderingLayersSelectedLight>b__1(bool value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0d434*/ <>c__DisplayClass4_0();
                        /*0x7c0efe4*/ bool <CreateSelectedLightShadowLayerMask>b__0();
                        /*0x7c0f034*/ void <CreateSelectedLightShadowLayerMask>b__1(bool value);
                        /*0x7c0f08c*/ bool <CreateSelectedLightShadowLayerMask>b__2();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0d640*/ <>c__DisplayClass5_0();
                        /*0x7c0f0e4*/ uint <CreateFilterRenderingLayerMasks>b__0();
                        /*0x7c0f134*/ void <CreateFilterRenderingLayerMasks>b__1(uint value);
                        /*0x7c0f188*/ bool <CreateFilterRenderingLayerMasks>b__2();
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0d980*/ <>c__DisplayClass6_0();
                        /*0x7c0f1d8*/ int <CreateAlbedoPreset>b__0();
                        /*0x7c0f228*/ void <CreateAlbedoPreset>b__1(int value);
                        /*0x7c0f27c*/ int <CreateAlbedoPreset>b__2();
                        /*0x7c0f2cc*/ void <CreateAlbedoPreset>b__3(int value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0db8c*/ <>c__DisplayClass7_0();
                        /*0x7c0f320*/ UnityEngine.Color <CreateAlbedoCustomColor>b__0();
                        /*0x7c0f374*/ void <CreateAlbedoCustomColor>b__1(UnityEngine.Color value);
                        /*0x7c0f3e8*/ bool <CreateAlbedoCustomColor>b__2();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0dd48*/ <>c__DisplayClass8_0();
                        /*0x7c0f440*/ float <CreateAlbedoMinLuminance>b__0();
                        /*0x7c0f490*/ void <CreateAlbedoMinLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c0df04*/ <>c__DisplayClass9_0();
                        /*0x7c0f4ec*/ float <CreateAlbedoMaxLuminance>b__0();
                        /*0x7c0f53c*/ void <CreateAlbedoMaxLuminance>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial>
                {
                    /*0x7c0ad2c*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel <>4__this;
                        /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x7c0f598*/ <>c__DisplayClass0_0();
                        /*0x7c0f5a8*/ bool <.ctor>b__2();
                        /*0x7c0f5cc*/ bool <.ctor>b__3();
                        /*0x7c0f5f0*/ bool <.ctor>b__4();
                    }

                    class <>c__DisplayClass0_1
                    {
                        /*0x10*/ int index;
                        /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel.<> CS$<>8__locals1;

                        /*0x7c0f5a0*/ <>c__DisplayClass0_1();
                        /*0x7c0f614*/ UnityEngine.Color <.ctor>b__0();
                        /*0x7c0f690*/ void <.ctor>b__1(UnityEngine.Color value);
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

                /*0x7c1006c*/ DebugDisplaySettingsRendering();
                /*0x7c0f72c*/ UnityEngine.Rendering.Universal.DebugWireframeMode get_wireframeMode();
                /*0x7c0f734*/ void set_wireframeMode(UnityEngine.Rendering.Universal.DebugWireframeMode value);
                /*0x7c0f78c*/ bool get_overdraw();
                /*0x7c0f794*/ void set_overdraw(bool value);
                /*0x7c0f7c8*/ UnityEngine.Rendering.Universal.DebugOverdrawMode get_overdrawMode();
                /*0x7c0f7d0*/ void set_overdrawMode(UnityEngine.Rendering.Universal.DebugOverdrawMode value);
                /*0x7c0f7f4*/ int get_maxOverdrawCount();
                /*0x7c0f7fc*/ void set_maxOverdrawCount(int value);
                /*0x7c0f760*/ void UpdateDebugSceneOverrideMode();
                /*0x7c0f804*/ UnityEngine.Rendering.Universal.DebugFullScreenMode get_fullScreenDebugMode();
                /*0x7c0f80c*/ void set_fullScreenDebugMode(UnityEngine.Rendering.Universal.DebugFullScreenMode value);
                /*0x7c0f814*/ int get_stpDebugViewIndex();
                /*0x7c0f81c*/ void set_stpDebugViewIndex(int value);
                /*0x7c0f824*/ int get_fullScreenDebugModeOutputSizeScreenPercent();
                /*0x7c0f82c*/ void set_fullScreenDebugModeOutputSizeScreenPercent(int value);
                /*0x7c0f834*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode get_sceneOverrideMode();
                /*0x7c0f83c*/ void set_sceneOverrideMode(UnityEngine.Rendering.Universal.DebugSceneOverrideMode value);
                /*0x7c0f844*/ UnityEngine.Rendering.Universal.DebugMipInfoMode get_mipInfoMode();
                /*0x7c0f84c*/ void set_mipInfoMode(UnityEngine.Rendering.Universal.DebugMipInfoMode value);
                /*0x7c0f854*/ bool get_mipDebugStatusShowCode();
                /*0x7c0f85c*/ void set_mipDebugStatusShowCode(bool value);
                /*0x7c0f868*/ UnityEngine.Rendering.Universal.DebugMipMapStatusMode get_mipDebugStatusMode();
                /*0x7c0f870*/ void set_mipDebugStatusMode(UnityEngine.Rendering.Universal.DebugMipMapStatusMode value);
                /*0x7c0f878*/ float get_mipDebugOpacity();
                /*0x7c0f880*/ void set_mipDebugOpacity(float value);
                /*0x7c0f888*/ float get_mipDebugRecentUpdateCooldown();
                /*0x7c0f890*/ void set_mipDebugRecentUpdateCooldown(float value);
                /*0x7c0f898*/ int get_mipDebugMaterialTextureSlot();
                /*0x7c0f8a0*/ void set_mipDebugMaterialTextureSlot(int value);
                /*0x7c0f8a8*/ bool get_showInfoForAllSlots();
                /*0x7c0f8b0*/ void set_showInfoForAllSlots(bool value);
                /*0x7c0f8bc*/ bool get_canAggregateData();
                /*0x7c0f8d0*/ UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture get_mipDebugTerrainTexture();
                /*0x7c0f8d8*/ void set_mipDebugTerrainTexture(UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture value);
                /*0x7c0f8e0*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode get_postProcessingDebugMode();
                /*0x7c0f8e8*/ void set_postProcessingDebugMode(UnityEngine.Rendering.Universal.DebugPostProcessingMode value);
                /*0x7c0f8f0*/ bool get_enableMsaa();
                /*0x7c0f8f8*/ void set_enableMsaa(bool value);
                /*0x7c0f904*/ bool get_enableHDR();
                /*0x7c0f90c*/ void set_enableHDR(bool value);
                /*0x7c0f918*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode get_taaDebugMode();
                /*0x7c0f920*/ void set_taaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode value);
                /*0x7c0f928*/ UnityEngine.Rendering.Universal.DebugValidationMode get_validationMode();
                /*0x7c0f930*/ void set_validationMode(UnityEngine.Rendering.Universal.DebugValidationMode value);
                /*0x7c0f938*/ UnityEngine.Rendering.Universal.PixelValidationChannels get_validationChannels();
                /*0x7c0f940*/ void set_validationChannels(UnityEngine.Rendering.Universal.PixelValidationChannels value);
                /*0x7c0f948*/ float get_validationRangeMin();
                /*0x7c0f950*/ void set_validationRangeMin(float value);
                /*0x7c0f958*/ float get_validationRangeMax();
                /*0x7c0f960*/ void set_validationRangeMax(float value);
                /*0x7c0f968*/ bool get_AreAnySettingsActive();
                /*0x7c0f9bc*/ bool get_IsPostProcessingAllowed();
                /*0x7c0f9e4*/ bool get_IsLightingActive();
                /*0x7c0fa04*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x7c0faa4*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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

                    static /*0x7c100ac*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c10a70*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlays(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c10cf4*/ UnityEngine.Rendering.DebugUI.Widget CreateStpDebugViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c11050*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlaySize(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c11398*/ UnityEngine.Rendering.DebugUI.Widget CreateAdditionalWireframeShaderViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c116d8*/ UnityEngine.Rendering.DebugUI.Widget CreateWireframeNotSupportedWarning(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c1181c*/ UnityEngine.Rendering.DebugUI.Widget CreateOverdrawMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c11aa0*/ UnityEngine.Rendering.DebugUI.Widget CreateMaxOverdrawCount(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c11e40*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugWidget(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c12118*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c12394*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c12e18*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSlotSelector(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel, System.Func<bool> hiddenCB, UnityEngine.GUIContent[] texSlotStrings, int[] texSlotValues);
                    static /*0x7c13290*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugCooldownSlider(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c130a0*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapShowStatusCodeToggle(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c135d8*/ UnityEngine.Rendering.DebugUI.Widget CreatePostProcessing(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c1385c*/ UnityEngine.Rendering.DebugUI.Widget CreateMSAA(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c13a0c*/ UnityEngine.Rendering.DebugUI.Widget CreateHDR(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c13bbc*/ UnityEngine.Rendering.DebugUI.Widget CreateTaaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c13efc*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c1423c*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationChannels(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c144c0*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMin(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c1467c*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMax(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);

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

                        static /*0x7c14838*/ <>c();
                        /*0x7c148a0*/ <>c();
                        /*0x7c148a8*/ int <CreateMapOverlaySize>b__2_2();
                        /*0x7c148b0*/ int <CreateMapOverlaySize>b__2_3();
                        /*0x7c148b8*/ void <CreateAdditionalWireframeShaderViews>b__3_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c14918*/ int <CreateMaxOverdrawCount>b__6_3();
                        /*0x7c14920*/ int <CreateMaxOverdrawCount>b__6_4();
                        /*0x7c14928*/ bool <CreateMipMapDebugWidget>b__7_0();
                        /*0x7c14978*/ void <CreateMipMapDebugWidget>b__7_1(bool value);
                        /*0x7c149d0*/ float <CreateMipMapDebugSettings>b__9_4();
                        /*0x7c149d8*/ float <CreateMipMapDebugSettings>b__9_5();
                        /*0x7c149e0*/ bool <CreateMipMapDebugSettings>b__9_10();
                        /*0x7c149e8*/ float <CreateMipMapDebugCooldownSlider>b__11_3();
                        /*0x7c149f0*/ float <CreateMipMapDebugCooldownSlider>b__11_4();
                        /*0x7c149fc*/ void <CreateTaaDebugMode>b__16_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c14a5c*/ void <CreatePixelValidationMode>b__17_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c10cec*/ <>c__DisplayClass0_0();
                        /*0x7c14abc*/ int <CreateMapOverlays>b__0();
                        /*0x7c14b0c*/ void <CreateMapOverlays>b__1(int value);
                        /*0x7c14b60*/ int <CreateMapOverlays>b__2();
                        /*0x7c14bb0*/ void <CreateMapOverlays>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c135c0*/ <>c__DisplayClass10_0();
                        /*0x7c14c04*/ int <CreateMipMapDebugSlotSelector>b__0();
                        /*0x7c14c54*/ void <CreateMipMapDebugSlotSelector>b__1(int value);
                        /*0x7c14ca8*/ int <CreateMipMapDebugSlotSelector>b__2();
                        /*0x7c14cf8*/ void <CreateMipMapDebugSlotSelector>b__3(int value);
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c135c8*/ <>c__DisplayClass11_0();
                        /*0x7c14d4c*/ bool <CreateMipMapDebugCooldownSlider>b__0();
                        /*0x7c14da4*/ float <CreateMipMapDebugCooldownSlider>b__1();
                        /*0x7c14df4*/ void <CreateMipMapDebugCooldownSlider>b__2(float value);
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c135d0*/ <>c__DisplayClass12_0();
                        /*0x7c14e50*/ bool <CreateMipMapShowStatusCodeToggle>b__0();
                        /*0x7c14ea8*/ bool <CreateMipMapShowStatusCodeToggle>b__1();
                        /*0x7c14ef8*/ void <CreateMipMapShowStatusCodeToggle>b__2(bool value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c13854*/ <>c__DisplayClass13_0();
                        /*0x7c14f50*/ int <CreatePostProcessing>b__0();
                        /*0x7c14fa0*/ void <CreatePostProcessing>b__1(int value);
                        /*0x7c14ff4*/ int <CreatePostProcessing>b__2();
                        /*0x7c15044*/ void <CreatePostProcessing>b__3(int value);
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c13a04*/ <>c__DisplayClass14_0();
                        /*0x7c15098*/ bool <CreateMSAA>b__0();
                        /*0x7c150e8*/ void <CreateMSAA>b__1(bool value);
                    }

                    class <>c__DisplayClass15_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c13bb4*/ <>c__DisplayClass15_0();
                        /*0x7c15140*/ bool <CreateHDR>b__0();
                        /*0x7c15190*/ void <CreateHDR>b__1(bool value);
                    }

                    class <>c__DisplayClass16_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c13ef4*/ <>c__DisplayClass16_0();
                        /*0x7c151e8*/ int <CreateTaaDebugMode>b__0();
                        /*0x7c15238*/ void <CreateTaaDebugMode>b__1(int value);
                        /*0x7c1528c*/ int <CreateTaaDebugMode>b__2();
                        /*0x7c152dc*/ void <CreateTaaDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c14234*/ <>c__DisplayClass17_0();
                        /*0x7c15330*/ int <CreatePixelValidationMode>b__0();
                        /*0x7c15380*/ void <CreatePixelValidationMode>b__1(int value);
                        /*0x7c153d4*/ int <CreatePixelValidationMode>b__2();
                        /*0x7c15424*/ void <CreatePixelValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c144b8*/ <>c__DisplayClass18_0();
                        /*0x7c15478*/ int <CreatePixelValidationChannels>b__0();
                        /*0x7c154c8*/ void <CreatePixelValidationChannels>b__1(int value);
                        /*0x7c1551c*/ int <CreatePixelValidationChannels>b__2();
                        /*0x7c1556c*/ void <CreatePixelValidationChannels>b__3(int value);
                    }

                    class <>c__DisplayClass19_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c14674*/ <>c__DisplayClass19_0();
                        /*0x7c155c0*/ float <CreatePixelValueRangeMin>b__0();
                        /*0x7c15610*/ void <CreatePixelValueRangeMin>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c11048*/ <>c__DisplayClass1_0();
                        /*0x7c1566c*/ bool <CreateStpDebugViews>b__0();
                        /*0x7c156c4*/ int <CreateStpDebugViews>b__1();
                        /*0x7c15714*/ void <CreateStpDebugViews>b__2(int value);
                        /*0x7c15768*/ int <CreateStpDebugViews>b__3();
                        /*0x7c157b8*/ void <CreateStpDebugViews>b__4(int value);
                    }

                    class <>c__DisplayClass20_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c14830*/ <>c__DisplayClass20_0();
                        /*0x7c1580c*/ float <CreatePixelValueRangeMax>b__0();
                        /*0x7c1585c*/ void <CreatePixelValueRangeMax>b__1(float value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c11390*/ <>c__DisplayClass2_0();
                        /*0x7c158b8*/ int <CreateMapOverlaySize>b__0();
                        /*0x7c15908*/ void <CreateMapOverlaySize>b__1(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c116d0*/ <>c__DisplayClass3_0();
                        /*0x7c1595c*/ int <CreateAdditionalWireframeShaderViews>b__0();
                        /*0x7c159ac*/ void <CreateAdditionalWireframeShaderViews>b__1(int value);
                        /*0x7c15a24*/ int <CreateAdditionalWireframeShaderViews>b__2();
                        /*0x7c15a74*/ void <CreateAdditionalWireframeShaderViews>b__3(int value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c11814*/ <>c__DisplayClass4_0();
                        /*0x7c15aec*/ bool <CreateWireframeNotSupportedWarning>b__0();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c11a98*/ <>c__DisplayClass5_0();
                        /*0x7c15b64*/ int <CreateOverdrawMode>b__0();
                        /*0x7c15bb4*/ void <CreateOverdrawMode>b__1(int value);
                        /*0x7c15c24*/ int <CreateOverdrawMode>b__2();
                        /*0x7c15c74*/ void <CreateOverdrawMode>b__3(int value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c11e38*/ <>c__DisplayClass6_0();
                        /*0x7c15ce4*/ bool <CreateMaxOverdrawCount>b__0();
                        /*0x7c15d3c*/ int <CreateMaxOverdrawCount>b__1();
                        /*0x7c15d8c*/ void <CreateMaxOverdrawCount>b__2(int value);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c12e08*/ <>c__DisplayClass8_0();
                        /*0x7c15de0*/ int <CreateMipMapMode>b__0();
                        /*0x7c15e30*/ void <CreateMipMapMode>b__1(int value);
                        /*0x7c15e84*/ int <CreateMipMapMode>b__2();
                        /*0x7c15ed4*/ void <CreateMipMapMode>b__3(int value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c12e10*/ <>c__DisplayClass9_0();
                        /*0x7c15f28*/ bool <CreateMipMapDebugSettings>b__0();
                        /*0x7c15f80*/ float <CreateMipMapDebugSettings>b__2();
                        /*0x7c15fd0*/ void <CreateMipMapDebugSettings>b__3(float value);
                        /*0x7c1602c*/ bool <CreateMipMapDebugSettings>b__1();
                        /*0x7c16088*/ bool <CreateMipMapDebugSettings>b__6();
                        /*0x7c160e4*/ bool <CreateMipMapDebugSettings>b__7();
                        /*0x7c16134*/ void <CreateMipMapDebugSettings>b__8(bool value);
                        /*0x7c16198*/ bool <CreateMipMapDebugSettings>b__9();
                        /*0x7c16208*/ int <CreateMipMapDebugSettings>b__11();
                        /*0x7c16258*/ void <CreateMipMapDebugSettings>b__12(int value);
                        /*0x7c162ac*/ int <CreateMipMapDebugSettings>b__13();
                        /*0x7c162fc*/ void <CreateMipMapDebugSettings>b__14(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering>
                {
                    /*0x7c0fafc*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x7c16350*/ <>c__DisplayClass0_0();
                        /*0x7c16358*/ bool <.ctor>b__0();
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

                static /*0x7c19340*/ DebugHandler();
                static /*0x7c16af4*/ void ConfigureColorDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x7c16b38*/ void ConfigureDepthDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x7c1731c*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data);
                static /*0x7c18080*/ void Setup(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData);
                /*0x7c165b4*/ DebugHandler();
                /*0x7c1637c*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x7c16398*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x7c163b4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x7c163d0*/ bool get_AreAnySettingsActive();
                /*0x7c163f0*/ bool get_IsPostProcessingAllowed();
                /*0x7c16410*/ bool get_IsLightingActive();
                /*0x7c16430*/ bool get_IsActiveModeUnsupportedForDeferred();
                /*0x7c164a4*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x7c164c4*/ UnityEngine.Material get_ReplacementMaterial();
                /*0x7c164cc*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings();
                /*0x7c164d4*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenColorHandle();
                /*0x7c164dc*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenDepthHandle();
                /*0x7c164e4*/ UnityEngine.Rendering.Universal.HDRDebugViewPass get_hdrDebugViewPass();
                /*0x7c164ec*/ bool HDRDebugViewIsActive(bool resolveFinalTarget);
                /*0x7c1651c*/ bool WriteToDebugScreenTexture(bool resolveFinalTarget);
                /*0x7c16524*/ bool get_IsScreenClearNeeded();
                /*0x7c16564*/ bool get_IsRenderPassSupported();
                /*0x7c16590*/ int get_stpDebugViewIndex();
                /*0x7c169b0*/ void Dispose();
                /*0x7c16a6c*/ bool IsActiveForCamera(bool isPreviewCamera);
                /*0x7c16a9c*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode);
                /*0x7c16ab8*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode, ref int textureHeightPercent);
                /*0x7c16b88*/ void SetupShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, int passIndex);
                /*0x7c170c8*/ void SetDebugRenderTarget(UnityEngine.Rendering.RTHandle renderTarget, UnityEngine.Rect displayRect, bool supportsStereo, UnityEngine.Vector4 dataRangeRemap);
                /*0x7c17144*/ void ResetDebugRenderTarget();
                /*0x7c1714c*/ UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData InitDebugFinalValidationPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c17604*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c1779c*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c17fe8*/ UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData InitDebugSetupPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData, bool isPreviewCamera);
                /*0x7c18404*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, bool isPreviewCamera);
                /*0x7c18408*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isPreviewCamera);
                /*0x7c1882c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);
                /*0x7c188fc*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c18eec*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);

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

                    /*0x7c169a8*/ DebugFinalValidationPassData();
                }

                class DebugSetupPassData
                {
                    /*0x10*/ bool isActiveForCamera;
                    /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial materialSettings;
                    /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering renderingSettings;
                    /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting lightingSettings;

                    /*0x7c169a0*/ DebugSetupPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DebugHandler.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__101_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__106_0;

                    static /*0x7c19a5c*/ <>c();
                    /*0x7c19ac4*/ <>c();
                    /*0x7c19acc*/ void <UpdateShaderGlobalPropertiesForFinalValidationPass>b__101_0(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c19b30*/ void <Setup>b__106_0(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class DebugRendererLists
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DebugRenderSetup> m_DebugRenderSetups;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererList> m_ActiveDebugRendererList;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> m_ActiveDebugRendererListHdl;

                /*0x7c189b8*/ DebugRendererLists(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c19b34*/ void CreateDebugRenderSetups(UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c19ce4*/ void DisposeDebugRenderLists();
                /*0x7c18b24*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c18fa8*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c1a2bc*/ void PrepareRendererListForRasterPass(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder);
                /*0x7c1a494*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd);
            }

            class DebugRenderSetup : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ int m_Index;

                /*0x7c19c90*/ DebugRenderSetup(UnityEngine.Rendering.Universal.DebugHandler debugHandler, int index, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c1a888*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x7c1a8ac*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x7c1a8d0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x7c1a704*/ void Begin(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c1a81c*/ void End(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c1a8f4*/ void CreateRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x7c1aa10*/ void CreateRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl);
                /*0x7c1a770*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x7c19e9c*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.DrawingSettings drawingSettings);
                /*0x7c19fb0*/ UnityEngine.Rendering.RenderStateBlock GetRenderStateBlock(UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c1ab2c*/ int GetIndex();
                /*0x7c19e98*/ void Dispose();
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

                /*0x7c1ae20*/ UniversalRenderPipelineDebugDisplaySettings();
                /*0x7c1ab34*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon get_commonSettings();
                /*0x7c1ab3c*/ void set_commonSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon value);
                /*0x7c1ab44*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_materialSettings();
                /*0x7c1ab4c*/ void set_materialSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial value);
                /*0x7c1ab54*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_renderingSettings();
                /*0x7c1ab5c*/ void set_renderingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering value);
                /*0x7c1ab64*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_lightingSettings();
                /*0x7c1ab6c*/ void set_lightingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting value);
                /*0x7c1ab74*/ UnityEngine.Rendering.DebugDisplaySettingsVolume get_volumeSettings();
                /*0x7c1ab7c*/ void set_volumeSettings(UnityEngine.Rendering.DebugDisplaySettingsVolume value);
                /*0x7c1ab84*/ UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> get_displayStats();
                /*0x7c1ab8c*/ void set_displayStats(UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> value);
                /*0x7c1ab94*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer get_gpuResidentDrawerSettings();
                /*0x7c1ab9c*/ void set_gpuResidentDrawerSettings(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer value);
                /*0x7c1aba4*/ bool get_IsPostProcessingAllowed();
                /*0x7c1ae9c*/ void Reset();
                /*0x7c1b388*/ void UpdateDisplayStats();
                /*0x7c1b3e8*/ void UpdateMaterials();
            }

            class UniversalRenderPipelineDebugDisplayStats : UnityEngine.Rendering.DebugDisplayStats<UnityEngine.Rendering.Universal.URPProfileId>
            {
                /*0x30*/ UnityEngine.Rendering.DebugFrameTiming m_DebugFrameTiming;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.URPProfileId> m_RecordedSamplers;

                /*0x7c1b21c*/ UniversalRenderPipelineDebugDisplayStats();
                /*0x7c1b48c*/ void EnableProfilingRecorders();
                /*0x7c1b4e4*/ void DisableProfilingRecorders();
                /*0x7c1b678*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
                /*0x7c1bb08*/ void Update();
                /*0x7c1bb68*/ bool <RegisterDebugUI>b__4_0();
                /*0x7c1bb70*/ void <RegisterDebugUI>b__4_1(bool value);
                /*0x7c1bb7c*/ bool <RegisterDebugUI>b__4_2();
                /*0x7c1bb84*/ void <RegisterDebugUI>b__4_3(bool value);
            }

            class UniversalRenderPipelineVolumeDebugSettings : UnityEngine.Rendering.VolumeDebugSettings<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>
            {
                /*0x7c1b31c*/ UniversalRenderPipelineVolumeDebugSettings();
                /*0x7c1bb90*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
                /*0x7c1bcd0*/ UnityEngine.LayerMask get_selectedCameraLayerMask();
                /*0x7c1bdc0*/ UnityEngine.Vector3 get_selectedCameraPosition();
                /*0x7c1bec0*/ System.Type get_targetRenderPipeline();
            }

            class DBufferCopyDepthPass : UnityEngine.Rendering.Universal.Internal.CopyDepthPass
            {
                /*0x7c1bf20*/ DBufferCopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth);
                /*0x7c1bf38*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            }

            class DecalDrawDBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c1c19c*/ DecalDrawDBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c1c368*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
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

                static /*0x7c1f358*/ DBufferRenderPass();
                static /*0x7c1dc0c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList, bool renderGraph);
                static /*0x7c1d780*/ void SetGlobalTextures(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x7c1d8a8*/ void SetKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x7c1d994*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x7c1c3b8*/ DBufferRenderPass(UnityEngine.Material dBufferClear, UnityEngine.Rendering.Universal.DBufferSettings settings, UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem, bool decalLayers);
                /*0x7c1c380*/ UnityEngine.Rendering.RTHandle[] get_dBufferColorHandles();
                /*0x7c1c388*/ void set_dBufferColorHandles(UnityEngine.Rendering.RTHandle[] value);
                /*0x7c1c398*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                /*0x7c1c3a0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                /*0x7c1c3b0*/ UnityEngine.Rendering.RTHandle get_dBufferDepth();
                /*0x7c1cadc*/ void Dispose();
                /*0x7c1cb70*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c1ccb4*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle depthTextureHandle);
                /*0x7c1cfec*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c1d2b8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c1d634*/ void InitPassData(ref UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x7c1dad0*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c1dea0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c1f260*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

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

                    /*0x7c1cad4*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__36_0;

                    static /*0x7c1f504*/ <>c();
                    /*0x7c1f56c*/ <>c();
                    /*0x7c1f574*/ void <RecordRenderGraph>b__36_0(UnityEngine.Rendering.Universal.DBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawFowardEmissiveSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c1f624*/ DecalDrawFowardEmissiveSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c1f6a0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalForwardEmissivePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData m_PassData;

                static /*0x7c1fdcc*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c1f6b8*/ DecalForwardEmissivePass(UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem);
                /*0x7c1f9dc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c1fc68*/ void InitPassData(ref UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData);
                /*0x7c1fc8c*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c1fe3c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c1f9d4*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__10_0;

                    static /*0x7c20478*/ <>c();
                    /*0x7c204e0*/ <>c();
                    /*0x7c204e8*/ void <RecordRenderGraph>b__10_0(UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawErrorSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x40*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;

                /*0x7c20548*/ DecalDrawErrorSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, UnityEngine.Rendering.Universal.DecalTechnique technique);
                /*0x7c205d0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x7c20640*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
            }

            class DecalPreviewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalPreviewPass.PassData m_PassData;

                static /*0x7c20cf4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalPreviewPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c2072c*/ DecalPreviewPass();
                /*0x7c209bc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c20d3c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c209b4*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalPreviewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalPreviewPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__8_0;

                    static /*0x7c21440*/ <>c();
                    /*0x7c214a8*/ <>c();
                    /*0x7c214b0*/ void <RecordRenderGraph>b__8_0(UnityEngine.Rendering.Universal.DecalPreviewPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c21500*/ void add_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c215b8*/ void remove_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c21670*/ void add_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c2172c*/ void remove_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c217e8*/ void add_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c218a4*/ void remove_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c21960*/ void add_onAllDecalPropertyChange(System.Action value);
                static /*0x7c21a1c*/ void remove_onAllDecalPropertyChange(System.Action value);
                static /*0x7c21ad8*/ void add_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c21b94*/ void remove_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c21c50*/ UnityEngine.Material get_defaultMaterial();
                static /*0x7c21c98*/ void set_defaultMaterial(UnityEngine.Material value);
                static /*0x7c21ce8*/ bool get_isSupported();
                static /*0x7c222b0*/ void UpdateAllDecalProperties();
                /*0x7c22314*/ DecalProjector();
                /*0x7c21d38*/ UnityEngine.Rendering.Universal.DecalEntity get_decalEntity();
                /*0x7c21d40*/ void set_decalEntity(UnityEngine.Rendering.Universal.DecalEntity value);
                /*0x7c21d48*/ UnityEngine.Material get_material();
                /*0x7c21d50*/ void set_material(UnityEngine.Material value);
                /*0x7c21e70*/ float get_drawDistance();
                /*0x7c21e78*/ void set_drawDistance(float value);
                /*0x7c21e88*/ float get_fadeScale();
                /*0x7c21e90*/ void set_fadeScale(float value);
                /*0x7c21eac*/ float get_startAngleFade();
                /*0x7c21eb4*/ void set_startAngleFade(float value);
                /*0x7c21ed4*/ float get_endAngleFade();
                /*0x7c21edc*/ void set_endAngleFade(float value);
                /*0x7c21efc*/ UnityEngine.Vector2 get_uvScale();
                /*0x7c21f04*/ void set_uvScale(UnityEngine.Vector2 value);
                /*0x7c21f0c*/ UnityEngine.Vector2 get_uvBias();
                /*0x7c21f14*/ void set_uvBias(UnityEngine.Vector2 value);
                /*0x7c21f1c*/ uint get_renderingLayerMask();
                /*0x7c21f24*/ void set_renderingLayerMask(uint value);
                /*0x7c21f2c*/ UnityEngine.Rendering.Universal.DecalScaleMode get_scaleMode();
                /*0x7c21f34*/ void set_scaleMode(UnityEngine.Rendering.Universal.DecalScaleMode value);
                /*0x7c21f3c*/ UnityEngine.Vector3 get_pivot();
                /*0x7c21f48*/ void set_pivot(UnityEngine.Vector3 value);
                /*0x7c21f54*/ UnityEngine.Vector3 get_size();
                /*0x7c21f60*/ void set_size(UnityEngine.Vector3 value);
                /*0x7c21f6c*/ float get_fadeFactor();
                /*0x7c21f74*/ void set_fadeFactor(float value);
                /*0x7c21f90*/ UnityEngine.Vector3 get_effectiveScale();
                /*0x7c21ffc*/ UnityEngine.Vector3 get_decalSize();
                /*0x7c22008*/ UnityEngine.Vector3 get_decalOffset();
                /*0x7c22018*/ UnityEngine.Vector4 get_uvScaleBias();
                /*0x7c22024*/ void InitMaterial();
                /*0x7c22084*/ void OnEnable();
                /*0x7c22108*/ void OnDisable();
                /*0x7c21d6c*/ void OnValidate();
                /*0x7c22174*/ bool IsValid();

                class DecalProjectorAction : System.MulticastDelegate
                {
                    /*0x7c22354*/ DecalProjectorAction(object object, nint method);
                    /*0x7c2245c*/ void Invoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                    /*0x7c22470*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector, System.AsyncCallback callback, object object);
                    /*0x7c22490*/ void EndInvoke(System.IAsyncResult result);
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

                /*0x7c225b0*/ DecalChunk();
                /*0x7c2249c*/ int get_count();
                /*0x7c224a4*/ void set_count(int value);
                /*0x7c224ac*/ int get_capacity();
                /*0x7c224b4*/ void set_capacity(int value);
                /*0x7c224bc*/ Unity.Jobs.JobHandle get_currentJobHandle();
                /*0x7c224c8*/ void set_currentJobHandle(Unity.Jobs.JobHandle value);
                /*0x7c224d0*/ void Push();
                /*0x380cffc*/ void RemoveAtSwapBack(int index);
                /*0x380cffc*/ void SetCapacity(int capacity);
                /*0x7c224e0*/ void Dispose();
                /*0x7c224e4*/ void ResizeNativeArray(ref UnityEngine.Jobs.TransformAccessArray array, UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors, int capacity);
                void RemoveAtSwapBack<T>(ref Unity.Collections.NativeArray<T> array, int index, int count);
                void RemoveAtSwapBack<T>(ref T[] array, int index, int count);
            }

            struct DecalSubDrawCall
            {
                /*0x10*/ int start;
                /*0x14*/ int end;

                /*0x7c225b8*/ int get_count();
            }

            class DecalDrawCallChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecals;
                /*0x48*/ Unity.Collections.NativeArray<float> renderingLayerMasks;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                /*0x68*/ Unity.Collections.NativeArray<int> subCallCounts;

                /*0x7c22850*/ DecalDrawCallChunk();
                /*0x7c225c4*/ void set_subCallCount(int value);
                /*0x7c225d0*/ int get_subCallCount();
                /*0x7c225dc*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c226c4*/ void SetCapacity(int newCapacity);
                /*0x7c22784*/ void Dispose();
            }

            class DecalCreateDrawCallSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ float m_MaxDrawDistance;

                /*0x7c22868*/ DecalCreateDrawCallSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float maxDrawDistance);
                /*0x7c22858*/ float get_maxDrawDistance();
                /*0x7c22860*/ void set_maxDrawDistance(float value);
                /*0x7c2291c*/ void Execute();
                /*0x7c22b2c*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk, int count);

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

                    /*0x7c22d30*/ void Execute();
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

                static /*0x7c24024*/ DecalDrawSystem();
                /*0x7c1c218*/ DecalDrawSystem(string sampler, UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c2304c*/ UnityEngine.Material get_overrideMaterial();
                /*0x7c23054*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x7c2305c*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c1dc7c*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c23234*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
                /*0x380b7a8*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x7c230cc*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x7c234a8*/ void Draw(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x7c2324c*/ void DrawInstanced(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x7c237b4*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c239d4*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x7c23dc8*/ void Draw(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
                /*0x7c23b28*/ void DrawInstanced(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
            }

            class DecalEntityIndexer
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem> m_Entities;
                /*0x18*/ System.Collections.Generic.Queue<int> m_FreeIndices;

                /*0x7c245ac*/ DecalEntityIndexer();
                /*0x7c24070*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c240f8*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex);
                /*0x7c2427c*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c2432c*/ UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem GetItem(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c2438c*/ void UpdateIndex(UnityEngine.Rendering.Universal.DecalEntity decalEntity, int newArrayIndex);
                /*0x7c24428*/ void RemapChunkIndices(System.Collections.Generic.List<int> remaper);
                /*0x7c2453c*/ void Clear();

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

                /*0x7c2484c*/ DecalEntityChunk();
                /*0x7c24688*/ void Push();
                /*0x7c24698*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c24744*/ void SetCapacity(int newCapacity);
                /*0x7c247d8*/ void Dispose();
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

                /*0x7c24854*/ DecalEntityManager();
                /*0x7c20658*/ UnityEngine.Material get_errorMaterial();
                /*0x7c236f4*/ UnityEngine.Mesh get_decalProjectorMesh();
                /*0x7c24bb8*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c24bd0*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c2514c*/ int CreateChunkIndex(UnityEngine.Material material);
                /*0x7c25a58*/ void UpdateAllDecalEntitiesData();
                /*0x7c256f8*/ void UpdateDecalEntityData(UnityEngine.Rendering.Universal.DecalEntity decalEntity, UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c25c78*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c25e50*/ void Update();
                /*0x7c26838*/ void Dispose();

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

                    static /*0x7c271e4*/ <>c();
                    /*0x7c2724c*/ <>c();
                    /*0x7c27254*/ int <Update>b__26_0(UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks a, UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks b);
                }
            }

            class DecalSkipCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Camera m_Camera;

                static /*0x7c275d8*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x7c2730c*/ DecalSkipCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c273ac*/ void Execute(UnityEngine.Camera camera);
                /*0x7c2752c*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
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

                /*0x7c25a48*/ DecalCachedChunk();
                /*0x7c275e0*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c278d8*/ void SetCapacity(int newCapacity);
                /*0x7c27b40*/ void Dispose();
            }

            class DecalUpdateCachedSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler m_SamplerJob;

                /*0x7c27d48*/ DecalUpdateCachedSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c27e2c*/ void Execute();
                /*0x7c27fe8*/ void Execute(UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, int count);

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

                    static /*0x7c28a20*/ UpdateTransformsJob();
                    /*0x7c28298*/ float DistanceBetweenQuaternions(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
                    /*0x7c282c8*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
                    /*0x7c28894*/ UnityEngine.BoundingSphere GetDecalProjectBoundingSphere(UnityEngine.Matrix4x4 decalToWorld);
                }
            }

            class DecalUpdateCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                /*0x7c28b88*/ DecalUpdateCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c28c28*/ void Execute();
                /*0x7c28d8c*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
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

                /*0x7c25a50*/ DecalCulledChunk();
                /*0x7c28e2c*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c28ec8*/ void SetCapacity(int newCapacity);
                /*0x7c28f90*/ void Dispose();
            }

            class DecalUpdateCullingGroupSystem
            {
                /*0x10*/ float[] m_BoundingDistance;
                /*0x18*/ UnityEngine.Camera m_Camera;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                static /*0x7c29484*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x7c29074*/ DecalUpdateCullingGroupSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float drawDistance);
                /*0x7c29024*/ float get_boundingDistance();
                /*0x7c2904c*/ void set_boundingDistance(float value);
                /*0x7c29170*/ void Execute(UnityEngine.Camera camera);
                /*0x7c29344*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalDrawGBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c2948c*/ DecalDrawGBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c29508*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
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

                static /*0x7c29f88*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c29520*/ DecalGBufferRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem, bool decalLayers);
                /*0x7c29840*/ void Setup(UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                /*0x7c29848*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c29c0c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c29f20*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData);
                /*0x7c2a0f4*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c2ac54*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x28*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c29838*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__15_0;

                    static /*0x7c2ad4c*/ <>c();
                    /*0x7c2adb4*/ <>c();
                    /*0x7c2adbc*/ void <RecordRenderGraph>b__15_0(UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawScreenSpaceSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c2ae1c*/ DecalDrawScreenSpaceSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c2ae98*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalScreenSpaceRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0xf0*/ bool m_DecalLayers;
                /*0xf8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData m_PassData;

                static /*0x7c2b68c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c2aeb0*/ DecalScreenSpaceRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem, bool decalLayers);
                /*0x7c2b194*/ UnityEngine.Rendering.RendererListParams CreateRenderListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c2b2cc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c2b5d0*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData);
                /*0x7c2b800*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c2bfec*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x21*/ bool isGLDevice;
                    /*0x24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c2b18c*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__12_0;

                    static /*0x7c2c0e4*/ <>c();
                    /*0x7c2c14c*/ <>c();
                    /*0x7c2c154*/ void <RecordRenderGraph>b__12_0(UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c2d534*/ ScriptableRenderPass();
                static /*0x7c2c44c*/ UnityEngine.Rendering.Universal.DebugHandler GetActiveDebugHandler(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c2d378*/ bool op_LessThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x7c2d3a0*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x7c2d3c8*/ int GetRenderPassEventRange(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent);
                /*0x7c1c780*/ ScriptableRenderPass();
                /*0x7c2c24c*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c2c258*/ UnityEngine.Rendering.Universal.RenderPassEvent get_renderPassEvent();
                /*0x7c2c260*/ void set_renderPassEvent(UnityEngine.Rendering.Universal.RenderPassEvent value);
                /*0x7c2c268*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachments();
                /*0x7c2c2b4*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachment();
                /*0x7c2c300*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthAttachment();
                /*0x7c2c34c*/ UnityEngine.Rendering.RTHandle[] get_colorAttachmentHandles();
                /*0x7c2c354*/ UnityEngine.Rendering.RTHandle get_colorAttachmentHandle();
                /*0x7c2c37c*/ UnityEngine.Rendering.RTHandle get_depthAttachmentHandle();
                /*0x7c2c384*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
                /*0x7c2c38c*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
                /*0x7c2c394*/ bool[] get_overriddenColorStoreActions();
                /*0x7c2c39c*/ bool get_overriddenDepthStoreAction();
                /*0x7c2c3a4*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput get_input();
                /*0x7c2c3ac*/ UnityEngine.Rendering.ClearFlag get_clearFlag();
                /*0x7c2c3b4*/ UnityEngine.Color get_clearColor();
                /*0x7c2c3c0*/ bool get_requiresIntermediateTexture();
                /*0x7c2c3c8*/ void set_requiresIntermediateTexture(bool value);
                /*0x7c1d6d4*/ UnityEngine.Rendering.ProfilingSampler get_profilingSampler();
                /*0x7c1ca78*/ void set_profilingSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7c2c3d4*/ string get_passName();
                /*0x7c2c3dc*/ bool get_overrideCameraTarget();
                /*0x7c2c3e4*/ void set_overrideCameraTarget(bool value);
                /*0x7c2c3f0*/ bool get_isBlitRenderPass();
                /*0x7c2c3f8*/ void set_isBlitRenderPass(bool value);
                /*0x7c2c404*/ bool get_useNativeRenderPass();
                /*0x7c2c40c*/ void set_useNativeRenderPass(bool value);
                /*0x7c2c418*/ bool get_breakGBufferAndDeferredRenderPass();
                /*0x7c2c420*/ void set_breakGBufferAndDeferredRenderPass(bool value);
                /*0x7c2c42c*/ int get_renderPassQueueIndex();
                /*0x7c2c434*/ void set_renderPassQueueIndex(int value);
                /*0x7c2c43c*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_renderTargetFormat();
                /*0x7c2c444*/ void set_renderTargetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                /*0x7c2c494*/ void ConfigureInput(UnityEngine.Rendering.Universal.ScriptableRenderPassInput passInput);
                /*0x7c2c49c*/ void ConfigureColorStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction, uint attachmentIndex);
                /*0x7c2c4f0*/ void ConfigureColorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] storeActions);
                /*0x7c2c5d4*/ void ConfigureDepthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                /*0x7c2c5e4*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle input, bool isTransient);
                /*0x7c2c670*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs);
                /*0x7c29bdc*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs, bool[] isTransient);
                /*0x7c2c678*/ void SetInputAttachmentTransient(int idx, bool isTransient);
                /*0x7c2c6ac*/ bool IsInputAttachmentTransient(int idx);
                /*0x7c2c6dc*/ void ResetTarget();
                /*0x7c2c774*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x7c2c7c0*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x7c2c888*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x7c1cff4*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x7c2c8d4*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat[] formats);
                /*0x7c2c950*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment);
                /*0x7c2c99c*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment);
                /*0x7c2ca0c*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments);
                /*0x7c2ca58*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments);
                /*0x7c2cac8*/ void ConfigureClear(UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                /*0x7c2cad8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c2cadc*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c2cae0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c2cae4*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c2cae8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c2cba0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c2cc58*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                /*0x7c2cca4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int passIndex);
                /*0x7c2cdc4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Material material, int passIndex);
                /*0x7c2ced4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Material material, int passIndex);
                /*0x7c2cf30*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c2d078*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c2d154*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c2d29c*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
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

                static /*0x7c3b474*/ ScriptableRenderer();
                static /*0x7c30b38*/ uint GetSubPassAttachmentIndicesCount(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x7c30cc4*/ bool AreAttachmentIndicesCompatible(UnityEngine.Rendering.Universal.ScriptableRenderPass lastSubPass, UnityEngine.Rendering.Universal.ScriptableRenderPass currentSubPass);
                static /*0x7c30df8*/ uint GetValidColorAttachmentCount(UnityEngine.Rendering.AttachmentDescriptor[] colorAttachments);
                static /*0x7c30db0*/ int GetValidInputAttachmentCount(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x7c2ff04*/ int FindAttachmentDescriptorIndexInList(int attachmentIdx, UnityEngine.Rendering.AttachmentDescriptor attachmentDescriptor, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x7c2eecc*/ int FindAttachmentDescriptorIndexInList(UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x7c2e0a8*/ int GetValidPassIndexCount(int[] array);
                static /*0x7c2e414*/ UnityEngine.Rendering.RTHandle GetFirstAllocatedRTHandle(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x7c2efb0*/ bool PassHasInputAttachments(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x7c30f40*/ UnityEngine.Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex);
                static /*0x7c2e018*/ UnityEngine.Hash128 CreateRenderPassHash(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex);
                static /*0x7c30f6c*/ void GetRenderTextureDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.RenderTextureDescriptor targetRT);
                static /*0x7c31244*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices);
                static /*0x7c317a8*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices);
                static /*0x7c3130c*/ void SetCameraMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped);
                static /*0x7c32138*/ void CalculateBillboardProperties(ref UnityEngine.Matrix4x4 worldToCameraMatrix, ref UnityEngine.Vector3 billboardTangent, ref UnityEngine.Vector3 billboardNormal, ref float cameraXZAngle);
                static /*0x7c32748*/ void SetShaderTimeValues(UnityEngine.Rendering.IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime);
                static /*0x7c38988*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7c389f0*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c37968*/ void ClearRenderingState(UnityEngine.Rendering.IBaseCommandBuffer cmd);
                static /*0x7c3a7a4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x7c3ad18*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x7c3b0a8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x7c3abf8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachmentIDs, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x7c35984*/ void SortStable(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> list);
                /*0x7c32cec*/ ScriptableRenderer(UnityEngine.Rendering.Universal.ScriptableRendererData data);
                /*0x7c2d5f8*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepth();
                /*0x7c2d624*/ void ResetNativeRenderPassFrameData();
                /*0x7c2d76c*/ void SetupNativeRenderPassFrameData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isRenderPassEnabled);
                /*0x7c2e0fc*/ void UpdateFinalStoreActions(int[] currentMergeablePasses, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isLastMergeableGroup);
                /*0x7c2e4f0*/ void SetNativeRenderPassMRTAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool needCustomCameraColorClear, UnityEngine.Rendering.ClearFlag cameraClearFlag);
                /*0x7c2f2f4*/ bool IsDepthOnlyRenderTexture(UnityEngine.RenderTexture t);
                /*0x7c2f31c*/ void SetNativeRenderPassAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle passColorAttachment, UnityEngine.Rendering.RTHandle passDepthAttachment, UnityEngine.Rendering.ClearFlag finalClearFlag, UnityEngine.Color finalClearColor);
                /*0x7c30030*/ void ExecuteNativeRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c2efec*/ void SetupInputAttachmentIndices(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x7c2f1e0*/ void SetupTransientInputAttachments(int attachmentCount);
                /*0x7c2df0c*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x7c311f4*/ int SupportedCameraStackingTypes();
                /*0x7c311fc*/ bool SupportsCameraStackingType(UnityEngine.Rendering.Universal.CameraRenderType cameraRenderType);
                /*0x7c31224*/ bool SupportsMotionVectors();
                /*0x7c3122c*/ UnityEngine.Rendering.ProfilingSampler get_profilingExecute();
                /*0x7c31234*/ void set_profilingExecute(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7c3123c*/ UnityEngine.Rendering.Universal.DebugHandler get_DebugHandler();
                /*0x7c31868*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c318bc*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, bool isTargetFlipped);
                /*0x7c31f7c*/ void SetPerCameraBillboardProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c32504*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c32544*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isTargetFlipped);
                /*0x7c32bd0*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraColorTarget();
                /*0x7c2ce50*/ UnityEngine.Rendering.RTHandle get_cameraColorTargetHandle();
                /*0x7c32c1c*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c32c24*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c32c2c*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTarget();
                /*0x7c31170*/ UnityEngine.Rendering.RTHandle get_cameraDepthTargetHandle();
                /*0x7c32c78*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x7c32c80*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> get_activeRenderPassQueue();
                /*0x7c32c88*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures();
                /*0x7c32c90*/ void set_supportedRenderingFeatures(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures value);
                /*0x7c32c98*/ UnityEngine.Rendering.GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes();
                /*0x7c32ca0*/ void set_unsupportedGraphicsDeviceTypes(UnityEngine.Rendering.GraphicsDeviceType[] value);
                /*0x7c32ca8*/ UnityEngine.Rendering.ContextContainer get_frameData();
                /*0x7c32cb0*/ bool get_useDepthPriming();
                /*0x7c32cb8*/ void set_useDepthPriming(bool value);
                /*0x7c32cc4*/ bool get_stripShadowsOffVariants();
                /*0x7c32ccc*/ void set_stripShadowsOffVariants(bool value);
                /*0x7c32cd8*/ bool get_stripAdditionalLightOffVariants();
                /*0x7c32ce0*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x7c33950*/ void Dispose();
                /*0x7c33a88*/ void Dispose(bool disposing);
                /*0x7c33a9c*/ void ReleaseRenderTargets();
                /*0x7c33aa0*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget);
                /*0x7c33aec*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget);
                /*0x7c33b20*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget, UnityEngine.Rendering.RTHandle resolveTarget);
                /*0x7c33b68*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RTHandle colorTarget);
                void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c33b78*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c33b7c*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c33b80*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c33b84*/ void OnBeginRenderGraphFrame();
                /*0x7c33b88*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7c33b8c*/ void OnEndRenderGraphFrame();
                /*0x7c33b90*/ void InitRenderGraphFrame(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c33f58*/ void ProcessVFXCameraCommand(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c34460*/ void SetupRenderGraphCameraProperties(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isTargetBackbuffer);
                /*0x7c3490c*/ void DrawRenderGraphGizmos(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7c34910*/ void DrawRenderGraphWireOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color);
                /*0x7c34914*/ void BeginRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c34e5c*/ void EndRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c352d8*/ void SetEditorTarget(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c3568c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7c35ae4*/ void FinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c35d9c*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c35da0*/ void RecordCustomRenderGraphPassesInEventRange(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent eventStart, UnityEngine.Rendering.Universal.RenderPassEvent eventEnd);
                /*0x7c35f2c*/ void CalculateSplitEventRange(UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent targetEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent startEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent splitEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent endEvent);
                /*0x7c36048*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x7c360cc*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint);
                /*0x7c360d4*/ bool InterruptFramebufferFetch(UnityEngine.Rendering.Universal.FramebufferFetchEvent fetchEvent, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x7c36298*/ void SetPerCameraProperties(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c363dc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c388cc*/ void EnqueuePass(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x7c38b78*/ void OnPreCullRenderPasses(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c38c3c*/ void AddRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c375e0*/ void SetupRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c336c8*/ void Clear(UnityEngine.Rendering.Universal.CameraRenderType cameraType);
                /*0x7c382dc*/ void ExecuteBlock(int blockIndex, ref UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks renderBlocks, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool submit);
                /*0x7c2dedc*/ bool IsRenderPassEnabled(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x7c38f10*/ void ExecuteRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c3a79c*/ bool IsSceneFilteringEnabled(UnityEngine.Camera camera);
                /*0x7c393c4*/ void SetRenderPassAttachments(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c384b0*/ void BeginXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c38670*/ void EndXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c3b250*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c3b254*/ void EnableSwapBufferMSAA(bool enable);
                /*0x7c3b258*/ void DrawGizmos(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c3b25c*/ void DrawWireOverlay(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c37778*/ void InternalStartRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c35b68*/ void InternalFinishRenderingCommon(UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x7c38824*/ void InternalFinishRenderingExecute(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x7c3b2c8*/ int AdjustAndGetScreenMSAASamples(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useIntermediateColorTarget);
                /*0x7c3b464*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x7c3b46c*/ bool get_supportsGPUOcclusion();

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

                    static /*0x7c3bca0*/ Profiling();

                    class RenderBlock
                    {
                        static string k_Name = "RenderPassBlock";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beforeRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler mainRenderingOpaque;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler mainRenderingTransparent;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler afterRendering;

                        static /*0x7c3c254*/ RenderBlock();
                    }

                    class RenderPass
                    {
                        static string k_Name = "ScriptableRenderPass";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler configure;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setRenderPassAttachments;

                        static /*0x7c3c3b8*/ RenderPass();
                    }
                }

                struct RenderPassDescriptor
                {
                    /*0x10*/ int w;
                    /*0x14*/ int h;
                    /*0x18*/ int samples;
                    /*0x1c*/ int depthID;

                    /*0x7c3c494*/ RenderPassDescriptor(int width, int height, int sampleCount, int rtID);
                }

                class RenderingFeatures
                {
                    /*0x10*/ bool <cameraStacking>k__BackingField;
                    /*0x11*/ bool <msaa>k__BackingField;

                    /*0x7c3c4c8*/ RenderingFeatures();
                    /*0x7c3c4a0*/ bool get_cameraStacking();
                    /*0x7c3c4a8*/ void set_cameraStacking(bool value);
                    /*0x7c3c4b4*/ bool get_msaa();
                    /*0x7c3c4bc*/ void set_msaa(bool value);
                }

                class RenderPassBlock
                {
                    static /*0x0*/ int BeforeRendering;
                    static /*0x4*/ int MainRenderingOpaque;
                    static /*0x8*/ int MainRenderingTransparent;
                    static /*0xc*/ int AfterRendering;

                    static /*0x7c3c4d8*/ RenderPassBlock();
                }

                class VFXProcessCameraPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                    /*0x18*/ UnityEngine.Camera camera;
                    /*0x20*/ UnityEngine.VFX.VFXCameraXRSettings cameraXRSettings;
                    /*0x30*/ UnityEngine.Experimental.Rendering.XRPass xrPass;

                    /*0x7c3c528*/ VFXProcessCameraPassData();
                }

                class DrawGizmosPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle gizmoRenderList;

                    /*0x7c3c530*/ DrawGizmosPassData();
                }

                class DrawWireOverlayPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle wireOverlayList;

                    /*0x7c3c538*/ DrawWireOverlayPassData();
                }

                class BeginXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c3c540*/ BeginXRPassData();
                }

                class EndXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c3c548*/ EndXRPassData();
                }

                class DummyData
                {
                    /*0x7c3c550*/ DummyData();
                }

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x20*/ bool isTargetBackbuffer;
                    /*0x24*/ UnityEngine.Vector2Int cameraTargetSizeCopy;

                    /*0x7c3c558*/ PassData();
                }

                struct RenderBlocks : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.RenderPassEvent> m_BlockEventLimits;
                    /*0x20*/ Unity.Collections.NativeArray<int> m_BlockRanges;
                    /*0x30*/ Unity.Collections.NativeArray<int> m_BlockRangeLengths;

                    /*0x7c3c560*/ RenderBlocks(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x7c3c81c*/ void Dispose();
                    /*0x7c3c714*/ void FillBlockRanges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x7c3c870*/ int GetLength(int index);
                    /*0x7c3c87c*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index);

                    struct BlockRange : System.IDisposable
                    {
                        /*0x10*/ int m_Current;
                        /*0x14*/ int m_End;

                        /*0x7c3c8a8*/ BlockRange(int begin, int end);
                        /*0x7c3c8c4*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator();
                        /*0x7c3c8cc*/ bool MoveNext();
                        /*0x7c3c8e8*/ int get_Current();
                        /*0x7c3c8f0*/ void Dispose();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__138_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__140_0;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__141_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.BeginXRPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__147_0;
                    static /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.EndXRPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__149_0;
                    static /*0x30*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.DummyData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__151_0;

                    static /*0x7c3c8f4*/ <>c();
                    /*0x7c3c95c*/ <>c();
                    /*0x7c3c964*/ void <InitRenderGraphFrame>b__138_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    /*0x7c3ca14*/ void <ProcessVFXCameraCommand>b__140_0(UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c3cb08*/ void <SetupRenderGraphCameraProperties>b__141_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c3cc78*/ void <BeginRenderGraphXRRendering>b__147_0(UnityEngine.Rendering.Universal.ScriptableRenderer.BeginXRPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c3ce70*/ void <EndRenderGraphXRRendering>b__149_0(UnityEngine.Rendering.Universal.ScriptableRenderer.EndXRPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c3cfe0*/ void <SetEditorTarget>b__151_0(UnityEngine.Rendering.Universal.ScriptableRenderer.DummyData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
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

                /*0x7c3d0c4*/ ScriptableRendererData();
                /*0x7c3d058*/ bool get_isInvalidated();
                /*0x7c3d060*/ void set_isInvalidated(bool value);
                /*0x380b9e8*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c3d06c*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x7c3d074*/ void SetDirty();
                /*0x7c3d080*/ UnityEngine.Rendering.Universal.ScriptableRenderer InternalCreateRenderer();
                /*0x7c3d090*/ void OnValidate();
                /*0x7c3d09c*/ void OnEnable();
                /*0x7c3d0a8*/ bool get_useNativeRenderPass();
                /*0x7c3d0b0*/ void set_useNativeRenderPass(bool value);
                /*0x380b2f0*/ bool TryGetRendererFeature<T>(ref T rendererFeature);

                class DebugShaderResources
                {
                    /*0x10*/ UnityEngine.Shader debugReplacementPS;
                    /*0x18*/ UnityEngine.Shader hdrDebugViewPS;

                    /*0x7c3d1a8*/ DebugShaderResources();
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

                    /*0x7c3d1b0*/ ProbeVolumeResources();
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

                /*0x7c3d1f0*/ Bloom();
                /*0x7c3d1b8*/ bool IsActive();
                /*0x7c3d1e8*/ bool IsTileCompatible();
            }

            class XRSystemData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystemData.ShaderResources shaders;

                /*0x7c3d554*/ XRSystemData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader xrOcclusionMeshPS;
                    /*0x18*/ UnityEngine.Shader xrMirrorViewPS;

                    /*0x7c3d55c*/ ShaderResources();
                }
            }

            class UniversalRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_LatestAssetVersion = 2;
                /*0x48*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x50*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x58*/ int m_AssetVersion;
                /*0x5c*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x60*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x68*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x70*/ bool m_ShadowTransparentReceive;
                /*0x74*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x78*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x7c*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x80*/ UnityEngine.Rendering.Universal.DepthFormat m_DepthAttachmentFormat;
                /*0x84*/ UnityEngine.Rendering.Universal.DepthFormat m_DepthTextureFormat;
                /*0x88*/ bool m_AccurateGbufferNormals;
                /*0x8c*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;

                /*0x7c3d970*/ UniversalRendererData();
                /*0x7c3d564*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c3d5f0*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c3d5f8*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c3d608*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c3d610*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c3d620*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x7c3d628*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x7c3d638*/ bool get_shadowTransparentReceive();
                /*0x7c3d640*/ void set_shadowTransparentReceive(bool value);
                /*0x7c3d654*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c3d65c*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c3d66c*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x7c3d674*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x7c3d684*/ UnityEngine.Rendering.Universal.CopyDepthMode get_copyDepthMode();
                /*0x7c3d68c*/ void set_copyDepthMode(UnityEngine.Rendering.Universal.CopyDepthMode value);
                /*0x7c3d69c*/ UnityEngine.Rendering.Universal.DepthFormat get_depthAttachmentFormat();
                /*0x7c3d730*/ void set_depthAttachmentFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x7c3d7f4*/ UnityEngine.Rendering.Universal.DepthFormat get_depthTextureFormat();
                /*0x7c3d8f8*/ void set_depthTextureFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x7c3d908*/ bool get_accurateGbufferNormals();
                /*0x7c3d910*/ void set_accurateGbufferNormals(bool value);
                /*0x7c3d924*/ UnityEngine.Rendering.Universal.IntermediateTextureMode get_intermediateTextureMode();
                /*0x7c3d92c*/ void set_intermediateTextureMode(UnityEngine.Rendering.Universal.IntermediateTextureMode value);
                /*0x7c3d93c*/ void OnEnable();
                /*0x7c3d5ec*/ void ReloadAllNullProperties();
                /*0x7c3d948*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x7c3d954*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            }

            class UniversalRenderPipelineEditorResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.MaterialResources materials;

                /*0x7c3da18*/ UniversalRenderPipelineEditorResources();

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

                    /*0x7c3da20*/ ShaderResources();
                }

                class MaterialResources
                {
                    /*0x10*/ UnityEngine.Material lit;
                    /*0x18*/ UnityEngine.Material particleLit;
                    /*0x20*/ UnityEngine.Material terrainLit;
                    /*0x28*/ UnityEngine.Material decal;

                    /*0x7c3da28*/ MaterialResources();
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

                /*0x7c3da30*/ ShaderResources();
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

                static /*0x7c3dac0*/ UnityEngine.Rendering.VolumeProfile GetOrCreateDefaultVolumeProfile(UnityEngine.Rendering.VolumeProfile defaultVolumeProfile);
                /*0x7c3dc70*/ UniversalRenderPipelineGlobalSettings();
                /*0x7c3da38*/ bool get_stripUnusedLODCrossFadeVariants();
                /*0x7c3da40*/ void set_stripUnusedLODCrossFadeVariants(bool value);
                /*0x7c3da44*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
                /*0x7c3da60*/ bool IsAtLastVersion();
                /*0x7c3da70*/ void Reset();
                /*0x7c3dac4*/ string[] get_prefixedLightLayerNames();
                /*0x7c3db08*/ string[] get_lightLayerNames();
                /*0x7c3db4c*/ void ResetRenderingLayerNames();
                /*0x7c3dbe0*/ UnityEngine.Rendering.ProbeVolumeSceneData GetOrCreateAPVSceneData();
            }

            class URPHelpURLAttribute : UnityEngine.Rendering.CoreRPHelpURLAttribute
            {
                /*0x7c3de18*/ URPHelpURLAttribute(string pageName, string pageHash);
            }

            class Documentation : UnityEngine.Rendering.DocumentationInfo
            {
                static string packageName = "com.unity.render-pipelines.universal";

                static /*0x7c3de7c*/ string GetPageLink(string pageName);
                /*0x7c3dec8*/ Documentation();
            }

            class ForwardRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                static string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";
                /*0x48*/ UnityEngine.Rendering.Universal.ForwardRendererData.ShaderResources shaders;
                /*0x50*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x58*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x60*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x64*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x68*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x70*/ bool m_ShadowTransparentReceive;
                /*0x74*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x78*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x7c*/ bool m_AccurateGbufferNormals;
                /*0x7d*/ bool m_ClusteredRendering;
                /*0x80*/ UnityEngine.Rendering.Universal.TileSize m_TileSize;

                /*0x7c3e31c*/ ForwardRendererData();
                /*0x7c3ded0*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c3df8c*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c3dfd8*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c3e024*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c3e070*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c3e0bc*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x7c3e108*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x7c3e154*/ bool get_shadowTransparentReceive();
                /*0x7c3e1a0*/ void set_shadowTransparentReceive(bool value);
                /*0x7c3e1ec*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c3e238*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c3e284*/ bool get_accurateGbufferNormals();
                /*0x7c3e2d0*/ void set_accurateGbufferNormals(bool value);

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

                    /*0x7c3e320*/ ShaderResources();
                }
            }

            class Universal2DResourceData : UnityEngine.Rendering.Universal.UniversalResourceDataBase
            {
                /*0x14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _intermediateDepth;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] _lightTextures;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] _cameraNormalsTexture;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] _shadowTextures;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _shadowDepth;
                /*0x50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _upscaleTexture;
                /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle _cameraSortingLayerTexture;

                /*0x7c3ed30*/ Universal2DResourceData();
                /*0x7c3e328*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle);
                /*0x7c3e4e8*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] newHandle);
                /*0x7c3e5e0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_intermediateDepth();
                /*0x7c3e68c*/ void set_intermediateDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c3e6e8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_lightTextures();
                /*0x7c3e6f0*/ void set_lightTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x7c3e700*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_normalsTexture();
                /*0x7c3e7f0*/ void set_normalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c3e8f4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_shadowTextures();
                /*0x7c3e8fc*/ void set_shadowTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x7c3e90c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_shadowDepth();
                /*0x7c3e914*/ void set_shadowDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c3e940*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_upscaleTexture();
                /*0x7c3e948*/ void set_upscaleTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c3e974*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraSortingLayerTexture();
                /*0x7c3e97c*/ void set_cameraSortingLayerTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c3e9a8*/ void Reset();
            }

            class UniversalCameraData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ UnityEngine.Matrix4x4 m_ViewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 m_ProjectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 m_JitterMatrix;
                /*0xd0*/ bool m_CachedRenderIntoTextureXR;
                /*0xd1*/ bool m_InitBuiltinXRConstants;
                /*0xd8*/ UnityEngine.Camera camera;
                /*0xe0*/ UnityEngine.Rendering.Universal.UniversalCameraHistory m_HistoryManager;
                /*0xe8*/ UnityEngine.Rendering.Universal.CameraRenderType renderType;
                /*0xf0*/ UnityEngine.RenderTexture targetTexture;
                /*0xf8*/ UnityEngine.RenderTextureDescriptor cameraTargetDescriptor;
                /*0x12c*/ UnityEngine.Rect pixelRect;
                /*0x13c*/ bool useScreenCoordOverride;
                /*0x140*/ UnityEngine.Vector4 screenSizeOverride;
                /*0x150*/ UnityEngine.Vector4 screenCoordScaleBias;
                /*0x160*/ int pixelWidth;
                /*0x164*/ int pixelHeight;
                /*0x168*/ float aspectRatio;
                /*0x16c*/ float renderScale;
                /*0x170*/ UnityEngine.Rendering.Universal.ImageScalingMode imageScalingMode;
                /*0x174*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter upscalingFilter;
                /*0x178*/ bool fsrOverrideSharpness;
                /*0x17c*/ float fsrSharpness;
                /*0x180*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision hdrColorBufferPrecision;
                /*0x184*/ bool clearDepth;
                /*0x188*/ UnityEngine.CameraType cameraType;
                /*0x18c*/ bool isDefaultViewport;
                /*0x18d*/ bool isHdrEnabled;
                /*0x18e*/ bool allowHDROutput;
                /*0x18f*/ bool isAlphaOutputEnabled;
                /*0x190*/ bool requiresDepthTexture;
                /*0x191*/ bool requiresOpaqueTexture;
                /*0x192*/ bool postProcessingRequiresDepthTexture;
                /*0x193*/ bool xrRendering;
                /*0x194*/ bool useGPUOcclusionCulling;
                /*0x195*/ bool stackLastCameraOutputToHDR;
                /*0x198*/ UnityEngine.Rendering.SortingCriteria defaultOpaqueSortFlags;
                /*0x1a0*/ UnityEngine.Experimental.Rendering.XRPass <xr>k__BackingField;
                /*0x1a8*/ float maxShadowDistance;
                /*0x1ac*/ bool postProcessEnabled;
                /*0x1ad*/ bool stackAnyPostProcessingEnabled;
                /*0x1b0*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;
                /*0x1b8*/ UnityEngine.LayerMask volumeLayerMask;
                /*0x1c0*/ UnityEngine.Transform volumeTrigger;
                /*0x1c8*/ bool isStopNaNEnabled;
                /*0x1c9*/ bool isDitheringEnabled;
                /*0x1cc*/ UnityEngine.Rendering.Universal.AntialiasingMode antialiasing;
                /*0x1d0*/ UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality;
                /*0x1d8*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                /*0x1e0*/ bool resolveFinalTarget;
                /*0x1e4*/ UnityEngine.Vector3 worldSpaceCameraPos;
                /*0x1f0*/ UnityEngine.Color backgroundColor;
                /*0x200*/ UnityEngine.Rendering.Universal.TaaHistory taaHistory;
                /*0x208*/ UnityEngine.Rendering.Universal.StpHistory stpHistory;
                /*0x210*/ UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings;
                /*0x230*/ UnityEngine.Camera baseCamera;

                /*0x7c400f0*/ UniversalCameraData();
                /*0x7c3edf0*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x7c3ee68*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x7c3ee9c*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7c3f264*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7c3f170*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x7c3f2d8*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x7c3f34c*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x7c3f4b8*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x7c3f510*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x7c3f5a8*/ int get_scaledWidth();
                /*0x7c3f5f8*/ int get_scaledHeight();
                /*0x7c3f648*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7c3f650*/ void set_historyManager(UnityEngine.Rendering.Universal.UniversalCameraHistory value);
                /*0x7c3f658*/ bool get_requireSrgbConversion();
                /*0x7c3f7ec*/ bool get_isGameCamera();
                /*0x7c3f7fc*/ bool get_isSceneViewCamera();
                /*0x7c3f80c*/ bool get_isPreviewCamera();
                /*0x7c3f81c*/ bool get_isRenderPassSupportedCamera();
                /*0x7c3f838*/ bool get_resolveToScreen();
                /*0x7c3f8e0*/ bool get_isHDROutputActive();
                /*0x7c3f990*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x7c3fa88*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x7c3fb18*/ bool get_rendersOverlayUI();
                /*0x7c3fb94*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x7c3f3e8*/ bool IsCameraProjectionMatrixFlipped();
                /*0x7c3fd78*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7c3fe1c*/ bool IsTemporalAARequested();
                /*0x7c3fe2c*/ bool IsTemporalAAEnabled();
                /*0x7c3ff1c*/ bool IsSTPRequested();
                /*0x7c3ff40*/ bool IsSTPEnabled();
                /*0x7c3ff64*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x7c3ff6c*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x7c3cdf4*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x7c3ff7c*/ bool get_resetHistory();
                /*0x7c3ff8c*/ void Reset();
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

                /*0x7c40110*/ UniversalLightData();
                /*0x7c400f8*/ void Reset();
            }

            class UniversalPostProcessingData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool isEnabled;
                /*0x14*/ UnityEngine.Rendering.Universal.ColorGradingMode gradingMode;
                /*0x18*/ int lutSize;
                /*0x1c*/ bool useFastSRGBLinearConversion;
                /*0x1d*/ bool supportScreenSpaceLensFlare;
                /*0x1e*/ bool supportDataDrivenLensFlare;

                /*0x7c40128*/ UniversalPostProcessingData();
                /*0x7c40118*/ void Reset();
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

                /*0x7c40228*/ UniversalRenderingData();
                /*0x7c40130*/ UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x7c401ac*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c401b4*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c401bc*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c401c4*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c401cc*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c401d4*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c401dc*/ void Reset();
            }

            class UniversalResourceDataBase : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool <isAccessible>k__BackingField;

                /*0x7c3ede8*/ UniversalResourceDataBase();
                /*0x7c40230*/ bool get_isAccessible();
                /*0x7c40238*/ void set_isAccessible(bool value);
                /*0x7c40244*/ void InitFrame();
                /*0x7c40250*/ void EndFrame();
                /*0x7c3e6bc*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle newHandle);
                /*0x7c3e5e8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7c3e800*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] newHandle);
                /*0x7c3e708*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle);
                /*0x7c3e45c*/ bool CheckAndWarnAboutAccessibility();

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

                /*0x7c40fd4*/ UniversalResourceData();
                /*0x7c40258*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeColorID();
                /*0x7c40260*/ void set_activeColorID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x7c40268*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeColorTexture();
                /*0x7c4036c*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeDepthID();
                /*0x7c40374*/ void set_activeDepthID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x7c4037c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeDepthTexture();
                /*0x7c40480*/ bool get_isActiveTargetBackBuffer();
                /*0x7c40364*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferColor();
                /*0x7c4050c*/ void set_backBufferColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40478*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferDepth();
                /*0x7c4053c*/ void set_backBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c4035c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraColor();
                /*0x7c4056c*/ void set_cameraColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40470*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepth();
                /*0x7c4059c*/ void set_cameraDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c405cc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_mainShadowsTexture();
                /*0x7c405d4*/ void set_mainShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40604*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_additionalShadowsTexture();
                /*0x7c4060c*/ void set_additionalShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c4063c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_gBuffer();
                /*0x7c40644*/ void set_gBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c40654*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraOpaqueTexture();
                /*0x7c4065c*/ void set_cameraOpaqueTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40688*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepthTexture();
                /*0x7c40690*/ void set_cameraDepthTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c406bc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraNormalsTexture();
                /*0x7c406c4*/ void set_cameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c406f0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorColor();
                /*0x7c406f8*/ void set_motionVectorColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40724*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorDepth();
                /*0x7c4072c*/ void set_motionVectorDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40758*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_internalColorLut();
                /*0x7c40760*/ void set_internalColorLut(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c4078c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenColor();
                /*0x7c40794*/ void set_debugScreenColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c407c0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenDepth();
                /*0x7c407c8*/ void set_debugScreenDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c407f4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_afterPostProcessColor();
                /*0x7c407fc*/ void set_afterPostProcessColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40828*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_overlayUITexture();
                /*0x7c40830*/ void set_overlayUITexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c4085c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_renderingLayersTexture();
                /*0x7c40864*/ void set_renderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40890*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_dBuffer();
                /*0x7c40898*/ void set_dBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c408a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_dBufferDepth();
                /*0x7c408b0*/ void set_dBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c408dc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_ssaoTexture();
                /*0x7c408e4*/ void set_ssaoTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40910*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_stpDebugView();
                /*0x7c40918*/ void set_stpDebugView(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c40944*/ void Reset();
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

                /*0x7c41140*/ UniversalShadowData();
                /*0x7c41054*/ void Reset();
            }

            class RawColorHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c41618*/ RawColorHistory();
                /*0x7c415b4*/ RawColorHistory();
                /*0x7c41148*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c411bc*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x7c41208*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x7c41254*/ bool IsAllocated();
                /*0x7c41270*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c412e0*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c41434*/ void Reset();
                /*0x7c41494*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x7c414cc*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class RawDepthHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c41bbc*/ RawDepthHistory();
                /*0x7c41b58*/ RawDepthHistory();
                /*0x7c416fc*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c41770*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x7c417bc*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x7c41808*/ bool IsAllocated();
                /*0x7c41824*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c41894*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c419e8*/ void Reset();
                /*0x7c41a48*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x7c41a74*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class SingleHistoryBase : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x1c*/ int m_Id;
                /*0x20*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x58*/ UnityEngine.Hash128 m_DescKey;

                /*0x7c41f70*/ SingleHistoryBase();
                /*0x7c41ca0*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c41ccc*/ UnityEngine.Rendering.RTHandle GetTexture(int frameIndex);
                /*0x7c41d2c*/ UnityEngine.Rendering.RTHandle GetCurrentTexture();
                /*0x7c41d38*/ UnityEngine.Rendering.RTHandle GetPreviousTexture();
                /*0x7c41d40*/ bool IsAllocated();
                /*0x7c41d5c*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c41dcc*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c41e84*/ void Reset();
                /*0x7c41e90*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x380b6a0*/ int GetHistoryFrameCount();
                /*0x380b9e8*/ string GetHistoryName();
                UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
            }

            class StpHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x20*/ UnityEngine.Rendering.STP.HistoryContext[] m_historyContexts;

                /*0x7c421a0*/ StpHistory();
                /*0x7c41f78*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c4203c*/ void Reset();
                /*0x7c4209c*/ UnityEngine.Rendering.STP.HistoryContext GetHistoryContext(int eyeIndex);
                /*0x7c420cc*/ bool Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
            }

            class TaaHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_TaaAccumulationNames;
                /*0x20*/ int[] m_TaaAccumulationTextureIds;
                /*0x28*/ int[] m_TaaAccumulationVersions;
                /*0x30*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x68*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c42734*/ TaaHistory();
                /*0x7c426b4*/ TaaHistory();
                /*0x7c42204*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c42278*/ void Reset();
                /*0x7c42324*/ UnityEngine.Rendering.RTHandle GetAccumulationTexture(int eyeIndex);
                /*0x7c42358*/ int GetAccumulationVersion(int eyeIndex);
                /*0x7c42388*/ void SetAccumulationVersion(int eyeIndex, int version);
                /*0x7c423b8*/ bool IsValid();
                /*0x7c423d4*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c42444*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c42594*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
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

                static /*0x7c45160*/ LightCookieManager();
                /*0x7c42844*/ LightCookieManager(ref UnityEngine.Rendering.Universal.LightCookieManager.Settings settings);
                /*0x7c42818*/ bool get_IsKeywordLightCookieEnabled();
                /*0x7c42820*/ void set_IsKeywordLightCookieEnabled(bool value);
                /*0x7c4282c*/ UnityEngine.Rendering.RTHandle get_AdditionalLightsCookieAtlasTexture();
                /*0x7c428e8*/ void InitAdditionalLights(int size);
                /*0x7c42a68*/ bool isInitialized();
                /*0x7c42a88*/ void Dispose();
                /*0x7c42b04*/ int GetLightCookieShaderDataIndex(int visibleLightIndex);
                /*0x7c42b4c*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c42da8*/ bool SetupMainLight(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight visibleMainLight);
                /*0x7c433e0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(UnityEngine.Experimental.Rendering.GraphicsFormat cookieFormat);
                /*0x7c434b4*/ void GetLightUVScaleOffset(ref UnityEngine.Rendering.Universal.UniversalAdditionalLightData additionalLightData, ref UnityEngine.Matrix4x4 uvTransform);
                /*0x7c431b8*/ bool SetupAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c43734*/ int FilterAndValidateAdditionalLights(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] validLightMappings);
                /*0x7c43c28*/ int UpdateAdditionalLightsAtlas(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects);
                /*0x7c445f8*/ int FetchUVRects(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects, int cookieSizeDivisor);
                /*0x7c444d0*/ uint ComputeCookieRequestPixelCount(ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings);
                /*0x7c445cc*/ int ApproximateCookieSizeDivisor(float requestAtlasRatio);
                /*0x7c449b4*/ UnityEngine.Vector4 Fetch2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x7c44850*/ UnityEngine.Vector4 FetchCube(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x7c44bb8*/ int ComputeOctahedralCookieSize(UnityEngine.Texture cookie);
                /*0x7c44b0c*/ void AdjustUVRect(ref UnityEngine.Vector4 uvScaleOffset, UnityEngine.Texture cookie, ref UnityEngine.Vector2 cookieSize);
                /*0x7c44d10*/ void ShrinkUVRect(ref UnityEngine.Vector4 uvScaleOffset, float amountPixels, ref UnityEngine.Vector2 cookieSize);
                /*0x7c43da4*/ void UploadAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Vector4> validUvRects);

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

                    static /*0x7c451e8*/ ShaderProperty();
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

                    static /*0x7c45454*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings Create();

                    struct AtlasSettings
                    {
                        /*0x10*/ UnityEngine.Vector2Int resolution;
                        /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;

                        /*0x7c44ce4*/ bool get_isPow2();
                        /*0x7c45520*/ bool get_isSquare();
                    }
                }

                struct LightCookieMapping
                {
                    static /*0x0*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex;
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort lightBufferIndex;
                    /*0x18*/ UnityEngine.Light light;

                    static /*0x7c45530*/ LightCookieMapping();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping.<> <>9;

                        static /*0x7c45658*/ <>c();
                        /*0x7c456c0*/ <>c();
                        /*0x7c456c8*/ int <.cctor>b__6_0(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                        /*0x7c45794*/ int <.cctor>b__6_1(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                    }
                }

                struct WorkSlice<T>
                {
                    /*0x0*/ T[] m_Data;
                    /*0x0*/ int m_Start;
                    /*0x0*/ int m_Length;

                    /*0x380d8b8*/ WorkSlice(T[] src, int srcLen);
                    WorkSlice(T[] src, int srcStart, int srcLen);
                    /*0x3907c14*/ T get_Item(int index);
                    /*0x3907c14*/ void set_Item(int index, T value);
                    /*0x380b6a0*/ int get_length();
                    /*0x380b6a0*/ int get_capacity();
                    /*0x380d83c*/ void Sort(System.Func<T, T, int> compare);
                }

                class WorkMemory
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] lightMappings;
                    /*0x18*/ UnityEngine.Vector4[] uvRects;

                    /*0x7c428e0*/ WorkMemory();
                    /*0x7c435e8*/ void Resize(int size);
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

                    /*0x7c42a34*/ LightCookieShaderData(int size, bool useStructuredBuffer);
                    /*0x7c457a0*/ UnityEngine.Matrix4x4[] get_worldToLights();
                    /*0x7c457a8*/ UnityEngine.Rendering.Universal.ShaderBitArray get_cookieEnableBits();
                    /*0x7c457b0*/ UnityEngine.Vector4[] get_atlasUVRects();
                    /*0x7c457b8*/ float[] get_lightTypes();
                    /*0x7c457c0*/ bool get_isUploaded();
                    /*0x7c457c8*/ void set_isUploaded(bool value);
                    /*0x7c42ab8*/ void Dispose();
                    /*0x7c44da0*/ void Resize(int size);
                    /*0x7c44fcc*/ void Upload(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7c43350*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                }
            }

            struct BuddyAllocation
            {
                /*0x10*/ int level;
                /*0x14*/ int index;

                /*0x7c457d4*/ BuddyAllocation(int level, int index);
                /*0x7c457dc*/ Unity.Mathematics.uint2 get_index2D();
            }

            struct BuddyAllocator : System.IDisposable
            {
                /*0x10*/ void* m_Data;
                /*0x18*/ System.ValueTuple<int, int> m_ActiveFreeMaskCounts;
                /*0x20*/ System.ValueTuple<int, int> m_FreeMasksStorage;
                /*0x28*/ System.ValueTuple<int, int> m_FreeMaskIndicesStorage;
                /*0x30*/ Unity.Collections.Allocator m_Allocator;

                static /*0x7c46094*/ int LevelOffset(int level, int branchingOrder);
                static /*0x7c460b8*/ int LevelLength(int level, int branchingOrder);
                static /*0x7c459a0*/ int LevelOffset64(int level, int branchingOrder);
                static /*0x7c459dc*/ int LevelLength64(int level, int branchingOrder);
                static /*0x3907c14*/ System.ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize);
                static /*0x7c460dc*/ int AlignForward(int offset, int alignment);
                static /*0x7c460f8*/ void* PtrAdd(void* ptr, int bytes);
                static /*0x7c45f00*/ int Pow2(int n);
                static /*0x7c460cc*/ int Pow2N(int x, int n);
                /*0x7c45b70*/ BuddyAllocator(int levelCount, int branchingOrder, Unity.Collections.Allocator allocator);
                /*0x7c457e8*/ ref UnityEngine.Rendering.Universal.BuddyAllocator.Header get_header();
                /*0x7c45824*/ Unity.Collections.NativeArray<int> get_freeMaskCounts();
                /*0x7c45870*/ Unity.Collections.NativeArray<ulong> get_freeMasksStorage();
                /*0x7c458bc*/ Unity.Collections.NativeArray<ulong> FreeMasks(int level);
                /*0x7c45a00*/ Unity.Collections.NativeArray<int> get_freeMaskIndicesStorage();
                /*0x7c45a4c*/ Unity.Collections.NativeArray<int> FreeMaskIndices(int level);
                /*0x7c45b30*/ int get_levelCount();
                /*0x7c45cdc*/ bool TryAllocate(int requestedLevel, ref UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x7c45f0c*/ void Free(UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x7c4606c*/ void Dispose();
                /*0x3907c14*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(int offset, int length);

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

                static /*0x3837458*/ void CheckRange(int index);
                /*0x3907c14*/ Fixed2(T item1);
                /*0x3907c14*/ Fixed2(T item1, T item2);
                /*0x3907c14*/ T get_Item(int index);
                /*0x3907c14*/ void set_Item(int index, T value);
            }

            struct PinnedArray<T> : System.IDisposable
            {
                /*0x0*/ T[] managedArray;
                /*0x0*/ System.Runtime.InteropServices.GCHandle handle;
                /*0x0*/ Unity.Collections.NativeArray<T> nativeArray;

                /*0x380cffc*/ PinnedArray(int length);
                /*0x380b6a0*/ int get_length();
                /*0x380cb08*/ void Dispose();
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

                static /*0x7c467d4*/ int GetXRMultiPassId(UnityEngine.Experimental.Rendering.XRPass xr);
                /*0x7c46120*/ MotionVectorsPersistentData();
                /*0x7c466d0*/ int get_lastFrameIndex();
                /*0x7c466f8*/ UnityEngine.Matrix4x4 get_viewProjection();
                /*0x7c4672c*/ UnityEngine.Matrix4x4 get_previousViewProjection();
                /*0x7c46760*/ UnityEngine.Matrix4x4[] get_viewProjectionStereo();
                /*0x7c46768*/ UnityEngine.Matrix4x4[] get_previousViewProjectionStereo();
                /*0x7c46770*/ UnityEngine.Matrix4x4[] get_projectionStereo();
                /*0x7c46778*/ UnityEngine.Matrix4x4[] get_previousProjectionStereo();
                /*0x7c46780*/ UnityEngine.Matrix4x4[] get_previousPreviousProjectionStereo();
                /*0x7c46788*/ UnityEngine.Matrix4x4[] get_viewStereo();
                /*0x7c46790*/ UnityEngine.Matrix4x4[] get_previousViewStereo();
                /*0x7c46798*/ UnityEngine.Matrix4x4[] get_previousPreviousViewStereo();
                /*0x7c467a0*/ float get_deltaTime();
                /*0x7c467a8*/ float get_lastDeltaTime();
                /*0x7c467b0*/ UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x7c467bc*/ UnityEngine.Vector3 get_previousWorldSpaceCameraPos();
                /*0x7c467c8*/ UnityEngine.Vector3 get_previousPreviousWorldSpaceCameraPos();
                /*0x7c462b8*/ void Reset();
                /*0x7c46804*/ void Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c47184*/ void SetGlobalMotionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr);
            }

            struct Sorting
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_QuickSortSampler;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler s_InsertionSortSampler;

                static /*0x7c47320*/ Sorting();
                static /*0x383af28*/ void QuickSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x383a00c*/ void QuickSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x3907c14*/ T Median3Pivot<T>(T[] data, int start, int pivot, int end, System.Func<T, T, int> compare);
                static int Partition<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x383af28*/ void InsertionSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x383a00c*/ void InsertionSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
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
                /*0x7c3d4f4*/ DownscaleParameter(UnityEngine.Rendering.Universal.BloomDownscaleMode value, bool overrideState);
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

                /*0x7c47558*/ ChannelMixer();
                /*0x7c473fc*/ bool IsActive();
                /*0x7c47550*/ bool IsTileCompatible();
            }

            class ChromaticAberration : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;

                /*0x7c477d4*/ ChromaticAberration();
                /*0x7c4779c*/ bool IsActive();
                /*0x7c477cc*/ bool IsTileCompatible();
            }

            class ColorAdjustments : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.FloatParameter postExposure;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contrast;
                /*0x48*/ UnityEngine.Rendering.ColorParameter colorFilter;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShift;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter saturation;

                /*0x7c47940*/ ColorAdjustments();
                /*0x7c47850*/ bool IsActive();
                /*0x7c47938*/ bool IsTileCompatible();
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

                /*0x7c47af4*/ ColorCurves();
                /*0x7c47ae4*/ bool IsActive();
                /*0x7c47aec*/ bool IsTileCompatible();
            }

            class ColorLookup : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureParameter texture;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contribution;

                /*0x7c48408*/ ColorLookup();
                /*0x7c4816c*/ bool IsActive();
                /*0x7c48400*/ bool IsTileCompatible();
                /*0x7c481b0*/ bool ValidateLUT();
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

                /*0x7c48554*/ DepthOfField();
                /*0x7c484cc*/ bool IsActive();
                /*0x7c4854c*/ bool IsTileCompatible();
            }

            class DepthOfFieldModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.DepthOfFieldMode>
            {
                /*0x7c48834*/ DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode value, bool overrideState);
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

                /*0x7c48974*/ FilmGrain();
                /*0x7c48894*/ bool IsActive();
                /*0x7c4896c*/ bool IsTileCompatible();
            }

            class FilmGrainLookupParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.FilmGrainLookup>
            {
                /*0x7c48aac*/ FilmGrainLookupParameter(UnityEngine.Rendering.Universal.FilmGrainLookup value, bool overrideState);
            }

            class LensDistortion : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter xMultiplier;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter yMultiplier;
                /*0x50*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter scale;

                /*0x7c48b98*/ LensDistortion();
                /*0x7c48b0c*/ bool IsActive();
                /*0x7c48b90*/ bool IsTileCompatible();
            }

            class LiftGammaGain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter lift;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter gamma;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter gain;

                /*0x7c48db0*/ LiftGammaGain();
                /*0x7c48d00*/ bool IsActive();
                /*0x7c48da8*/ bool IsTileCompatible();
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

                /*0x7c48ed8*/ MotionBlur();
                /*0x7c48ea0*/ bool IsActive();
                /*0x7c48ed0*/ bool IsTileCompatible();
            }

            class MotionBlurModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurMode>
            {
                /*0x7c49010*/ MotionBlurModeParameter(UnityEngine.Rendering.Universal.MotionBlurMode value, bool overrideState);
            }

            class MotionBlurQualityParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurQuality>
            {
                /*0x7c49070*/ MotionBlurQualityParameter(UnityEngine.Rendering.Universal.MotionBlurQuality value, bool overrideState);
            }

            class PaniniProjection : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter distance;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter cropToFit;

                /*0x7c49108*/ PaniniProjection();
                /*0x7c490d0*/ bool IsActive();
                /*0x7c49100*/ bool IsTileCompatible();
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

                /*0x7c491b8*/ ScreenSpaceLensFlare();
                /*0x7c496a0*/ bool IsActive();
                /*0x7c496d0*/ bool IsStreaksActive();
                /*0x7c49700*/ bool IsTileCompatible();
            }

            class ScreenSpaceLensFlareResolutionParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution>
            {
                /*0x7c49640*/ ScreenSpaceLensFlareResolutionParameter(UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution value, bool overrideState);
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

                /*0x7c497b8*/ ShadowsMidtonesHighlights();
                /*0x7c49708*/ bool IsActive();
                /*0x7c497b0*/ bool IsTileCompatible();
            }

            class SplitToning : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter shadows;
                /*0x40*/ UnityEngine.Rendering.ColorParameter highlights;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter balance;

                /*0x7c49a1c*/ SplitToning();
                /*0x7c4998c*/ bool IsActive();
                /*0x7c49a14*/ bool IsTileCompatible();
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

                /*0x7c49b7c*/ Tonemapping();
                /*0x7c49b44*/ bool IsActive();
                /*0x7c49b74*/ bool IsTileCompatible();
            }

            class TonemappingModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.TonemappingMode>
            {
                /*0x7c49ddc*/ TonemappingModeParameter(UnityEngine.Rendering.Universal.TonemappingMode value, bool overrideState);
            }

            class NeutralRangeReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.NeutralRangeReductionMode>
            {
                /*0x7c49e3c*/ NeutralRangeReductionModeParameter(UnityEngine.Rendering.Universal.NeutralRangeReductionMode value, bool overrideState);
            }

            class HDRACESPresetParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.HDRACESPreset>
            {
                /*0x7c49e9c*/ HDRACESPresetParameter(UnityEngine.Rendering.Universal.HDRACESPreset value, bool overrideState);
            }

            class Vignette : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter color;
                /*0x40*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter smoothness;
                /*0x58*/ UnityEngine.Rendering.BoolParameter rounded;

                /*0x7c49f34*/ Vignette();
                /*0x7c49efc*/ bool IsActive();
                /*0x7c49f2c*/ bool IsTileCompatible();
            }

            class WhiteBalance : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter temperature;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter tint;

                /*0x7c4a13c*/ WhiteBalance();
                /*0x7c4a0d8*/ bool IsActive();
                /*0x7c4a134*/ bool IsTileCompatible();
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

                static /*0x7c4b350*/ void ClearStaticCaches();
                static /*0x7c4b258*/ int EstimateScaleFactorNeededToFitAllShadowsInAtlas(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasSize);
                static /*0x7c4b158*/ System.Func<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, int> CreateCompareShadowResolutionRequesPredicate();
                /*0x7c4a204*/ AdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c4b2c8*/ int GetTotalShadowSlicesCount();
                /*0x7c4b2d0*/ int GetTotalShadowResolutionRequestCount();
                /*0x7c4b2d8*/ bool HasTooManyShadowMaps();
                /*0x7c4b2e0*/ int GetShadowSlicesScaleFactor();
                /*0x7c4b2e8*/ int GetAtlasSize();
                /*0x7c4b2f0*/ bool HasSpaceForLight(int originalVisibleLightIndex);
                /*0x7c4b304*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex);
                /*0x7c4b324*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex);

                struct ShadowResolutionRequest
                {
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort perLightShadowSliceIndex;
                    /*0x14*/ ushort requestedResolution;
                    /*0x16*/ ushort offsetX;
                    /*0x18*/ ushort offsetY;
                    /*0x1a*/ ushort allocatedResolution;
                    /*0x1c*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest.SettingsOptions m_ShadowProperties;

                    /*0x7c4b2b0*/ bool get_softShadow();
                    /*0x7c4b228*/ void set_softShadow(bool value);
                    /*0x7c4b2bc*/ bool get_pointLightShadow();
                    /*0x7c4b238*/ void set_pointLightShadow(bool value);

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

                    static /*0x7c4b3f4*/ <>c();
                    /*0x7c4b45c*/ <>c();
                    /*0x7c4b464*/ int <CreateCompareShadowResolutionRequesPredicate>b__24_0(UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest curr, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest other);
                }
            }

            class CapturePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.RTHandle m_CameraColorHandle;

                /*0x7c4b5e8*/ CapturePass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c4b6a4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4b9b4*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                    /*0x20*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;

                    /*0x7c4be6c*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.CapturePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.CapturePass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__4_0;

                    static /*0x7c4be74*/ <>c();
                    /*0x7c4bedc*/ <>c();
                    /*0x7c4bee4*/ void <RecordRenderGraph>b__4_0(UnityEngine.Rendering.Universal.CapturePass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext unsafeContext);
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

                static /*0x7c4df4c*/ DrawScreenSpaceUIPass();
                static /*0x7c4c228*/ void ConfigureColorDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x7c4c25c*/ void ConfigureDepthDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x7c4c29c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c4c2e4*/ void ExecutePass(UnityEngine.Rendering.UnsafeCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c4c140*/ DrawScreenSpaceUIPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool renderOffscreen);
                /*0x7c4c32c*/ void Dispose();
                /*0x7c4c360*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x7c4c508*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4c730*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4c924*/ void RenderOffscreen(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle output);
                /*0x7c4d5a4*/ void RenderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c4c220*/ PassData();
                }

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;

                    /*0x7c4dfe8*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__18_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__18_1;

                    static /*0x7c4dff0*/ <>c();
                    /*0x7c4e058*/ <>c();
                    /*0x7c4e060*/ void <RenderOffscreen>b__17_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c4e104*/ void <RenderOffscreen>b__17_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c4e230*/ void <RenderOverlay>b__18_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c4e2d4*/ void <RenderOverlay>b__18_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                }
            }

            class DrawSkyboxPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x7c4e7ec*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c4e400*/ DrawSkyboxPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c4e49c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4e5c8*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c4e8e0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyBoxRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c4ea5c*/ void InitPassData(ref UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData passData, ref UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x7c4eac0*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Material skyboxMaterial);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle skyRendererListHandle;
                    /*0x28*/ UnityEngine.Material material;

                    /*0x7c4f19c*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawSkyboxPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                    static /*0x7c4f1a4*/ <>c();
                    /*0x7c4f20c*/ <>c();
                    /*0x7c4f214*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class HDRDebugViewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy m_PassDataCIExy;
                /*0xc0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView m_PassDataDebugView;
                /*0xc8*/ UnityEngine.Rendering.RTHandle m_CIExyTarget;
                /*0xd0*/ UnityEngine.Rendering.RTHandle m_PassthroughRT;
                /*0xd8*/ UnityEngine.Material m_material;

                static /*0x7c4f3f0*/ void ConfigureDescriptorForCIEPrepass(ref UnityEngine.RenderTextureDescriptor descriptor);
                static /*0x7c4f4b8*/ UnityEngine.Vector4 GetLuminanceParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c4f63c*/ void ExecuteCIExyPrepass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                static /*0x7c4f8bc*/ void ExecuteHDRDebugViewFinalPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle xyTarget);
                /*0x7c4f270*/ HDRDebugViewPass(UnityEngine.Material mat);
                /*0x7c4fc6c*/ void Dispose();
                /*0x7c4fca0*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.HDRDebugMode hdrdebugMode);
                /*0x7c4fe2c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c50008*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy dataCIExy, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView dataDebugView, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                /*0x7c50278*/ void RenderHDRDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor, UnityEngine.Rendering.Universal.HDRDebugMode hdrDebugMode);

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

                    /*0x7c4f3e0*/ PassDataCIExy();
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

                    /*0x7c4f3e8*/ PassDataDebugView();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _DebugHDRModeId;
                    static /*0x4*/ int _HDRDebugParamsId;
                    static /*0x8*/ int _xyTextureId;
                    static /*0xc*/ int _SizeOfHDRXYMapping;
                    static /*0x10*/ int _CIExyUAVIndex;

                    static /*0x7c50f70*/ ShaderConstants();
                    /*0x7c50f68*/ ShaderConstants();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x7c51044*/ <>c();
                    /*0x7c510ac*/ <>c();
                    /*0x7c510b4*/ void <RenderHDRDebug>b__17_0(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c5119c*/ void <RenderHDRDebug>b__17_1(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class InvokeOnRenderObjectCallbackPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x7c51264*/ InvokeOnRenderObjectCallbackPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c51324*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c5134c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget;

                    /*0x7c517e4*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__3_0;

                    static /*0x7c517ec*/ <>c();
                    /*0x7c51854*/ <>c();
                    /*0x7c5185c*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
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

                static /*0x7c5358c*/ MotionVectorRenderPass();
                static /*0x7c51b30*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c52334*/ UnityEngine.Rendering.DrawingSettings GetDrawingSettings(UnityEngine.Camera camera, bool supportsDynamicBatching);
                static /*0x7c51c40*/ void DrawCameraMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Material cameraMaterial);
                static /*0x7c51dbc*/ void DrawObjectMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c53038*/ void SetMotionVectorGlobalMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c530fc*/ void SetRenderGraphMotionVectorGlobalMatrices(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c5187c*/ MotionVectorRenderPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material cameraMaterial, UnityEngine.LayerMask opaqueLayerMask);
                /*0x7c51a24*/ void Setup(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7c51a54*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c51e74*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c5209c*/ void InitPassData(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c520fc*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, ref UnityEngine.Rendering.CullingResults cullResults, bool supportsDynamicBatching, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x7c52598*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorDepth);

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

                    /*0x7c51a1c*/ PassData();
                }

                class MotionMatrixPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData motionData;
                    /*0x18*/ UnityEngine.Experimental.Rendering.XRPass xr;

                    /*0x7c536c4*/ MotionMatrixPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__26_0;

                    static /*0x7c536cc*/ <>c();
                    /*0x7c53734*/ <>c();
                    /*0x7c5373c*/ void <Render>b__23_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c538a0*/ void <SetRenderGraphMotionVectorGlobalMatrices>b__26_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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
                static string _UpscaledColorTargetName = "_UpscaledColorTarget";
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

                static /*0x7c67c00*/ PostProcessPass();
                static /*0x7c57270*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(UnityEngine.RenderTextureDescriptor desc, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                static /*0x7c5be34*/ float GetMaxBokehRadiusInPixels(float viewportHeight);
                static /*0x7c5be4c*/ float GetLensFlareLightAttenuation(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                static /*0x7c5c0a4*/ void UpdateMotionBlurMatrices(ref UnityEngine.Material material, UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7c64108*/ void ScaleViewportAndBlit(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTextureHdl, UnityEngine.Rendering.RTHandle dest, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material, bool hasFinalPass);
                /*0x7c538c8*/ PostProcessPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x7c54364*/ void Cleanup();
                /*0x7c544f4*/ void Dispose();
                /*0x7c546d0*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.RTHandle source, bool resolveToScreen, ref UnityEngine.Rendering.RTHandle depth, ref UnityEngine.Rendering.RTHandle internalLut, ref UnityEngine.Rendering.RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding);
                /*0x7c5481c*/ void SetupFinalPass(ref UnityEngine.Rendering.RTHandle source, bool useSwapBuffer, bool enableColorEncoding);
                /*0x7c548c8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c548d4*/ bool CanRunOnTile();
                /*0x7c548dc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c5427c*/ bool IsHDRFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x7c5430c*/ bool IsAlphaFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x7c5710c*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor();
                /*0x7c57180*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x7c572c0*/ bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion);
                /*0x7c572dc*/ bool RequireHDROutput(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c55728*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c575b8*/ void DoSubpixelMorphologicalAntialiasing(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x7c57b88*/ void DoDepthOfField(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x7c5ae18*/ void DoGaussianDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x7c5bbd0*/ void PrepareBokehKernel(float maxRadius, float rcpAspect);
                /*0x7c5b5bc*/ void DoBokehDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x7c592fc*/ void LensFlareDataDrivenComputeOcclusion(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x7c59a10*/ void LensFlareDataDriven(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x7c58ca0*/ void DoLensFlareScreenSpace(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RTHandle originalBloomTexture, UnityEngine.Rendering.RTHandle screenSpaceLensFlareBloomMipTexture);
                /*0x7c57c7c*/ void DoMotionBlur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle motionVectors, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c57f14*/ void DoPaniniProjection(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x7c5c2ac*/ UnityEngine.Vector2 CalcViewExtents(UnityEngine.Camera camera);
                /*0x7c5c308*/ UnityEngine.Vector2 CalcCropExtents(UnityEngine.Camera camera, float d);
                /*0x7c58148*/ void SetupBloom(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Material uberMaterial, bool enableAlphaOutput);
                /*0x7c5a1f8*/ void SetupLensDistortion(UnityEngine.Material material, bool isSceneView);
                /*0x7c5a4d0*/ void SetupChromaticAberration(UnityEngine.Material material);
                /*0x7c5a5c4*/ void SetupVignette(UnityEngine.Material material, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7c5a818*/ void SetupColorGrading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material material);
                /*0x7c5ab74*/ void SetupGrain(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x7c5ac24*/ void SetupDithering(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x7c5acc0*/ void SetupHDROutput(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperations, bool rendersOverlayUI);
                /*0x7c54d84*/ void RenderFinalPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c5c35c*/ void UpdateCameraResolution(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int newCameraTargetSize);
                /*0x7c5c774*/ void RenderStopNaN(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget);
                /*0x7c5cd4c*/ void RenderSMAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle SMAATarget);
                /*0x7c5e418*/ void UberPostSetupBloomPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph rendergraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle bloomTexture, UnityEngine.Material uberMaterial);
                /*0x7c5ebdc*/ void RenderBloomTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x7c5fba8*/ void RenderDoF(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c5fe60*/ void RenderDoFGaussian(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x7c609ec*/ void RenderDoFBokeh(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x7c61540*/ void RenderPaniniProjection(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c61cc0*/ void RenderTemporalAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c61ed0*/ void RenderSTP(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c62180*/ void RenderMotionBlur(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c62aa0*/ void LensFlareDataDrivenComputeOcclusion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c630cc*/ void RenderLensFlareDataDriven(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c63794*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle RenderLensFlareScreenSpace(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle originalBloomTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle screenSpaceLensFlareBloomMipTexture, bool enableXR);
                /*0x7c64348*/ void RenderFinalSetup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x7c649f0*/ void RenderFinalFSRScale(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x7c64f40*/ void RenderFinalBlit(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x7c6564c*/ void RenderFinalPassRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded);
                /*0x7c65ce8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle TryGetCachedUserLutTextureHandle(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c65ef8*/ void RenderUberPost(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool resolveToDebugScreen, bool hasFinalPass);
                /*0x7c66bd8*/ void RenderPostProcessingRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColorTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded);
                /*0x7c57318*/ UnityEngine.Rendering.RTHandle <Render>g__GetSource|89_0(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x7c57320*/ UnityEngine.Rendering.RTHandle <Render>g__GetDestination|89_1(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x7c57480*/ void <Render>g__Swap|89_2(ref UnityEngine.Rendering.Universal.ScriptableRenderer r, ref UnityEngine.Rendering.Universal.PostProcessPass.<> );

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

                    /*0x7c53f80*/ MaterialLibrary(UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x7c67dd4*/ UnityEngine.Material Load(UnityEngine.Shader shader);
                    /*0x7c54388*/ void Cleanup();
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

                    static /*0x7c67f40*/ ShaderConstants();
                }

                class UpdateCameraResolutionPassData
                {
                    /*0x10*/ UnityEngine.Vector2Int newCameraTargetSize;

                    /*0x7c687dc*/ UpdateCameraResolutionPassData();
                }

                class StopNaNsPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material stopNaN;

                    /*0x7c687e4*/ StopNaNsPassData();
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

                    /*0x7c687ec*/ SMAASetupPassData();
                }

                class SMAAPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthStencilTexture;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle blendTexture;
                    /*0x50*/ UnityEngine.Material material;

                    /*0x7c687f4*/ SMAAPassData();
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

                    /*0x7c687fc*/ UberSetupBloomPassData();
                }

                class BloomPassData
                {
                    /*0x10*/ int mipCount;
                    /*0x18*/ UnityEngine.Material material;
                    /*0x20*/ UnityEngine.Material[] upsampleMaterials;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipUp;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipDown;

                    /*0x7c68804*/ BloomPassData();
                }

                struct BloomMaterialParams
                {
                    /*0x10*/ UnityEngine.Vector4 parameters;
                    /*0x20*/ bool highQualityFiltering;
                    /*0x21*/ bool enableAlphaOutput;

                    /*0x7c6880c*/ bool Equals(ref UnityEngine.Rendering.Universal.PostProcessPass.BloomMaterialParams other);
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

                    /*0x7c68874*/ DoFGaussianPassData();
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

                    /*0x7c688d8*/ DoFBokehPassData();
                }

                class PaniniProjectionPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.RenderTextureDescriptor sourceTextureDesc;
                    /*0x68*/ UnityEngine.Material material;
                    /*0x70*/ UnityEngine.Vector4 paniniParams;
                    /*0x80*/ bool isPaniniGeneric;

                    /*0x7c688e0*/ PaniniProjectionPassData();
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

                    /*0x7c688e8*/ MotionBlurPassData();
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

                    /*0x7c688f0*/ LensFlarePassData();
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

                    /*0x7c688f8*/ LensFlareScreenSpacePassData();
                }

                class PostProcessingFinalSetupPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c68900*/ PostProcessingFinalSetupPassData();
                }

                class PostProcessingFinalFSRScalePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ bool enableAlphaOutput;

                    /*0x7c68908*/ PostProcessingFinalFSRScalePassData();
                }

                class PostProcessingFinalBlitPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings;

                    /*0x7c68910*/ PostProcessingFinalBlitPassData();
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

                    static /*0x7c68918*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings Create();
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

                    /*0x7c68924*/ UberPostPassData();
                }

                class PostFXSetupPassData
                {
                    /*0x7c6892c*/ PostFXSetupPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.PostProcessPass.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__98_0;
                    static /*0x10*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__98_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UpdateCameraResolutionPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__122_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.StopNaNsPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__124_0;
                    static /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAASetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_0;
                    static /*0x30*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_1;
                    static /*0x38*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_2;
                    static /*0x40*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__127_3;
                    static /*0x48*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UberSetupBloomPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__129_0;
                    static /*0x50*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.BloomPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__132_0;
                    static /*0x58*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.DoFGaussianPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__135_0;
                    static /*0x60*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.DoFBokehPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__137_0;
                    static /*0x68*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PaniniProjectionPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__139_0;
                    static /*0x70*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.MotionBlurPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__145_0;
                    static /*0x78*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__147_0;
                    static /*0x80*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__148_1;
                    static /*0x88*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__148_2;
                    static /*0x90*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__148_0;
                    static /*0x98*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.LensFlareScreenSpacePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__150_0;
                    static /*0xa0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__153_0;
                    static /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalFSRScalePassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__155_0;
                    static /*0xb0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalBlitPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__158_0;
                    static /*0xb8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.UberPostPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__162_0;
                    static /*0xc0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.PostProcessPass.PostFXSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__164_0;

                    static /*0x7c68934*/ <>c();
                    /*0x7c6899c*/ <>c();
                    /*0x7c689a4*/ float <LensFlareDataDriven>b__98_0(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c68a34*/ float <LensFlareDataDriven>b__98_1(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c68ac4*/ void <UpdateCameraResolution>b__122_0(UnityEngine.Rendering.Universal.PostProcessPass.UpdateCameraResolutionPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c68b58*/ void <RenderStopNaN>b__124_0(UnityEngine.Rendering.Universal.PostProcessPass.StopNaNsPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c68ca0*/ void <RenderSMAA>b__127_0(UnityEngine.Rendering.Universal.PostProcessPass.SMAASetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c68e3c*/ void <RenderSMAA>b__127_1(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c68f84*/ void <RenderSMAA>b__127_2(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c690cc*/ void <RenderSMAA>b__127_3(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c69274*/ void <UberPostSetupBloomPass>b__129_0(UnityEngine.Rendering.Universal.PostProcessPass.UberSetupBloomPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c69448*/ void <RenderBloomTexture>b__132_0(UnityEngine.Rendering.Universal.PostProcessPass.BloomPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c69b08*/ void <RenderDoFGaussian>b__135_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFGaussianPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c6a610*/ void <RenderDoFBokeh>b__137_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFBokehPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c6ae7c*/ void <RenderPaniniProjection>b__139_0(UnityEngine.Rendering.Universal.PostProcessPass.PaniniProjectionPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6b058*/ void <RenderMotionBlur>b__145_0(UnityEngine.Rendering.Universal.PostProcessPass.MotionBlurPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6b3ac*/ void <LensFlareDataDrivenComputeOcclusion>b__147_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c6b960*/ void <RenderLensFlareDataDriven>b__148_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c6c160*/ float <RenderLensFlareDataDriven>b__148_1(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c6c1f0*/ float <RenderLensFlareDataDriven>b__148_2(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c6c280*/ void <RenderLensFlareScreenSpace>b__150_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlareScreenSpacePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c6c698*/ void <RenderFinalSetup>b__153_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6c778*/ void <RenderFinalFSRScale>b__155_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalFSRScalePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6c96c*/ void <RenderFinalBlit>b__158_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalBlitPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6cd80*/ void <RenderUberPost>b__162_0(UnityEngine.Rendering.Universal.PostProcessPass.UberPostPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6d018*/ void <RenderPostProcessingRenderGraph>b__164_0(UnityEngine.Rendering.Universal.PostProcessPass.PostFXSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                /*0x7c6d114*/ ProbeVolumeDebugPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.ComputeShader computeShader);
                /*0x7c6d1e0*/ void Setup(UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RTHandle normalBuffer);
                /*0x7c6d210*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6d4c0*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthPyramidBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer);

                class WriteApvData
                {
                    /*0x10*/ UnityEngine.ComputeShader computeShader;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle resultBuffer;
                    /*0x24*/ UnityEngine.Vector2 clickCoordinates;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;
                    /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer;

                    /*0x7c6dae0*/ WriteApvData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__7_0;

                    static /*0x7c6dae8*/ <>c();
                    /*0x7c6db50*/ <>c();
                    /*0x7c6db58*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
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

                static /*0x7c6eb2c*/ void ExecutePass(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList, bool isYFlipped);
                /*0x7c6deb0*/ RenderObjectsPass(string profilerTag, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c6e3e0*/ RenderObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c6dd0c*/ UnityEngine.Material get_overrideMaterial();
                /*0x7c6dd14*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x7c6dd1c*/ int get_overrideMaterialPassIndex();
                /*0x7c6dd24*/ void set_overrideMaterialPassIndex(int value);
                /*0x7c6dd2c*/ UnityEngine.Shader get_overrideShader();
                /*0x7c6dd34*/ void set_overrideShader(UnityEngine.Shader value);
                /*0x7c6dd3c*/ int get_overrideShaderPassIndex();
                /*0x7c6dd44*/ void set_overrideShaderPassIndex(int value);
                /*0x7c6dd4c*/ void SetDetphState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x7c6dd54*/ void SetDepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x7c6ddc0*/ void SetStencilState(int reference, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOp, UnityEngine.Rendering.StencilOp failOp, UnityEngine.Rendering.StencilOp zFailOp);
                /*0x7c6dfe4*/ void Init(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c6e510*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6e750*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData);
                /*0x7c6e7a4*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x7c6f994*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                    /*0x38*/ UnityEngine.Rendering.Universal.DebugRendererLists debugRendererLists;
                    /*0x40*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x48*/ UnityEngine.Rendering.RendererList rendererList;

                    /*0x7c6e508*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderObjectsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__33_0;

                    static /*0x7c706ec*/ <>c();
                    /*0x7c70754*/ <>c();
                    /*0x7c7075c*/ void <RecordRenderGraph>b__33_0(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c73af8*/ ScreenSpaceAmbientOcclusionPass();
                static /*0x7c70ce0*/ bool IsAfterOpaquePass(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x7c73688*/ void RenderAndSetBaseMap(ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material mat, ref UnityEngine.Rendering.RTHandle baseMap, ref UnityEngine.Rendering.RTHandle target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x7c734dc*/ void GetPassOrder(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.BlurTypes blurType, bool isAfterOpaque, ref int[] textureIndices, ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] shaderPasses);
                /*0x7c708ac*/ ScreenSpaceAmbientOcclusionPass();
                /*0x7c7083c*/ bool get_isRendererDeferred();
                /*0x7c70b20*/ bool Setup(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings featureSettings, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material material, ref UnityEngine.Texture2D[] blueNoiseTextures);
                /*0x7c70d08*/ void SetupKeywordsAndParameters(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c717a4*/ void InitSSAOPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data);
                /*0x7c71804*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c72260*/ void CreateRenderTextureHandles(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle aoTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle blurTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle finalTexture);
                /*0x7c7260c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c72e98*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c73980*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c73a48*/ void Dispose();

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

                    /*0x7c715c8*/ SSAOMaterialParams(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic);
                    /*0x7c716b4*/ bool Equals(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOMaterialParams other);
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

                    /*0x7c70b18*/ SSAOPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__52_0;

                    static /*0x7c73ff4*/ <>c();
                    /*0x7c7405c*/ <>c();
                    /*0x7c74064*/ void <RecordRenderGraph>b__52_0(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
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

                static /*0x7c74700*/ RenderPassEventsEnumValues();
            }

            class TransparentSettingsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ bool m_shouldReceiveShadows;

                static /*0x7c74c90*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                /*0x7c74a94*/ TransparentSettingsPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool shadowReceiveSupported);
                /*0x7c74b64*/ bool Setup();
                /*0x7c74b74*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class XRDepthMotionPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static int k_XRViewCount = 2;
                static /*0x0*/ UnityEngine.Rendering.ShaderTagId k_MotionOnlyShaderTagId;
                /*0xb8*/ UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData m_PassData;
                /*0xc0*/ UnityEngine.Rendering.RTHandle m_XRMotionVectorColor;
                /*0xc8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle xrMotionVectorColor;
                /*0xd8*/ UnityEngine.Rendering.RTHandle m_XRMotionVectorDepth;
                /*0xe0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle xrMotionVectorDepth;
                /*0xf0*/ UnityEngine.Matrix4x4[] m_ViewProjection;
                /*0xf8*/ UnityEngine.Matrix4x4[] m_PreviousViewProjection;
                /*0x100*/ int m_LastFrameIndex;
                /*0x108*/ UnityEngine.Material m_XRMotionVectorMaterial;

                static /*0x7c76450*/ XRDepthMotionPass();
                static /*0x7c7510c*/ UnityEngine.Rendering.DrawingSettings GetObjectMotionDrawingSettings(UnityEngine.Camera camera);
                /*0x7c74d18*/ XRDepthMotionPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader xrMotionVector);
                /*0x7c752d8*/ void InitObjectMotionRendererLists(ref UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera);
                /*0x7c754f4*/ void InitPassData(ref UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c75550*/ void ImportXRMotionColorAndDepth(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c75954*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c74fec*/ void ResetMotionData();
                /*0x7c7602c*/ void Update(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c763d4*/ void Dispose();

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objMotionRendererList;
                    /*0x20*/ UnityEngine.Matrix4x4[] previousViewProjectionStereo;
                    /*0x28*/ UnityEngine.Matrix4x4[] viewProjectionStereo;
                    /*0x30*/ UnityEngine.Material xrMotionVector;

                    /*0x7c74f6c*/ PassData();
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData;

                    /*0x7c76024*/ <>c__DisplayClass17_0();
                    /*0x7c764cc*/ void <Render>b__0(UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class XROcclusionMeshPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData m_PassData;
                /*0xc0*/ bool m_IsActiveTargetBackBuffer;

                static /*0x7c76718*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data);
                /*0x7c76618*/ XROcclusionMeshPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c767a4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c76854*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment;
                    /*0x38*/ bool isActiveTargetBackBuffer;

                    /*0x7c76710*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                    static /*0x7c76f14*/ <>c();
                    /*0x7c76f7c*/ <>c();
                    /*0x7c76f84*/ void <Render>b__6_0(UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            struct PostProcessParams
            {
                /*0x10*/ UnityEngine.Material blitMaterial;
                /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat requestColorFormat;

                static /*0x7c76f8c*/ UnityEngine.Rendering.Universal.PostProcessParams Create();
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

                /*0x7c77040*/ PostProcessPasses(UnityEngine.Rendering.Universal.PostProcessData rendererPostProcessData, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x7c76fb8*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x7c76fc0*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x7c76fc8*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x7c76fd0*/ UnityEngine.Rendering.RTHandle get_afterPostProcessColor();
                /*0x7c76fd8*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x7c76fe0*/ bool get_isCreated();
                /*0x7c770e8*/ void Recreate(UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams ppParams);
                /*0x7c7732c*/ void Dispose();
                /*0x7c77390*/ void ReleaseRenderTargets();
            }

            class PostProcessUtils
            {
                static /*0x7c773e4*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x7c77448*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x7c775dc*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x7c77640*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x7c6b2b4*/ void SetSourceSize(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source);
                static /*0x7c6a5a4*/ void SetSourceSize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source);

                class ShaderConstants
                {
                    static /*0x0*/ int _Grain_Texture;
                    static /*0x4*/ int _Grain_Params;
                    static /*0x8*/ int _Grain_TilingParams;
                    static /*0xc*/ int _BlueNoise_Texture;
                    static /*0x10*/ int _Dithering_Params;
                    static /*0x14*/ int _SourceSize;

                    static /*0x7c77900*/ ShaderConstants();
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

                static /*0x7c77a6c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager Create();
                /*0x7c77a5c*/ UnityEngine.RenderTexture get_atlasRT();
                /*0x7c77a64*/ UnityEngine.Rendering.RTHandle get_atlasRTHandle();
                /*0x7c77aac*/ void Init();
                /*0x7c77f88*/ void UpdateGpuData(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults);
                /*0x7c79958*/ Unity.Mathematics.float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip);
                /*0x7c79a1c*/ void Dispose();

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

                    static /*0x7c79adc*/ ShaderProperties();
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

                /*0x7c79c38*/ DBufferSettings();
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

                /*0x7c79c48*/ DecalScreenSpaceSettings();
            }

            class DecalSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalTechniqueOption technique;
                /*0x14*/ float maxDrawDistance;
                /*0x18*/ bool decalLayers;
                /*0x20*/ UnityEngine.Rendering.Universal.DBufferSettings dBufferSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings screenSpaceSettings;

                /*0x7c79c50*/ DecalSettings();
            }

            class SharedDecalEntityManager : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x18*/ int m_ReferenceCounter;

                /*0x7c7a1f8*/ SharedDecalEntityManager();
                /*0x7c79c60*/ UnityEngine.Rendering.Universal.DecalEntityManager Get();
                /*0x7c79f04*/ void Release(UnityEngine.Rendering.Universal.DecalEntityManager decalEntityManager);
                /*0x7c79f20*/ void Dispose();
                /*0x7c7a0e0*/ void OnDecalAdd(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c7a134*/ void OnDecalRemove(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c7a158*/ void OnDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c7a1b4*/ void OnAllDecalPropertyChange();
                /*0x7c7a1d0*/ void OnDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
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

                static /*0x7c7b67c*/ DecalRendererFeature();
                static /*0x7c7a200*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager get_sharedDecalEntityManager();
                static /*0x7c7a28c*/ bool get_isGLDevice();
                /*0x7c7b608*/ DecalRendererFeature();
                /*0x7c7a258*/ ref UnityEngine.Rendering.Universal.DecalSettings get_settings();
                /*0x7c7a260*/ bool get_intermediateRendering();
                /*0x7c7a270*/ bool get_requiresDecalLayers();
                /*0x7c7a2c0*/ void Create();
                /*0x7c7a32c*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x7c7a594*/ UnityEngine.Rendering.Universal.DBufferSettings GetDBufferSettings();
                /*0x7c7a614*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings GetScreenSpaceSettings();
                /*0x7c7a690*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRendererData renderer);
                /*0x7c7a7b8*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x7c7a3d8*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques);
                /*0x7c7a894*/ bool IsAutomaticDBuffer();
                /*0x7c7a960*/ bool RecreateSystemsIfNeeded(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c7b004*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c7b144*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7b2f4*/ bool SupportsNativeRenderPass();
                /*0x7c7b308*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7b4e4*/ void Dispose(bool disposing);
                /*0x7c7b604*/ void ChangeAdaptivePerformanceDrawDistances();
            }

            class DisallowMultipleRendererFeature : System.Attribute
            {
                /*0x10*/ string <customTitle>k__BackingField;

                /*0x7c7b708*/ DisallowMultipleRendererFeature(string customTitle);
                /*0x7c7b6f8*/ void set_customTitle(string value);
                /*0x7c7b700*/ string get_customTitle();
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

                /*0x7c7ba00*/ RenderObjects();
                /*0x7c7b738*/ void Create();
                /*0x7c7b948*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7b9f8*/ bool SupportsNativeRenderPass();

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

                    /*0x7c7ba68*/ RenderObjectsSettings();

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

                    /*0x7c7bbb4*/ FilterSettings();
                }

                class CustomCameraSettings
                {
                    /*0x10*/ bool overrideCamera;
                    /*0x11*/ bool restoreCamera;
                    /*0x14*/ UnityEngine.Vector4 offset;
                    /*0x24*/ float cameraFieldOfView;

                    /*0x7c7bbe0*/ CustomCameraSettings();
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

                /*0x7c70ae4*/ ScreenSpaceAmbientOcclusionSettings();

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
                /*0x28*/ UnityEngine.Texture2D[] m_BlueNoise256Textures;
                /*0x30*/ UnityEngine.Shader m_Shader;
                /*0x38*/ UnityEngine.Material m_Material;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass m_SSAOPass;

                /*0x7c7c030*/ ScreenSpaceAmbientOcclusion();
                /*0x7c7bbf8*/ ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings get_settings();
                /*0x7c7bc00*/ void Create();
                /*0x7c7bcbc*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7bfb4*/ void Dispose(bool disposing);
                /*0x7c7beb4*/ bool GetMaterials();
            }

            class ScreenSpaceShadowsSettings
            {
                /*0x7c7c0c8*/ ScreenSpaceShadowsSettings();
            }

            class ScreenSpaceShadows : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

                /*0x7c7c8a8*/ ScreenSpaceShadows();
                /*0x7c7c0d0*/ void Create();
                /*0x7c7c510*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7c80c*/ void Dispose(bool disposing);
                /*0x7c7c39c*/ bool LoadMaterial();

                class ScreenSpaceShadowsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Material m_Material;
                    /*0xc0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_CurrentSettings;
                    /*0xc8*/ UnityEngine.Rendering.RTHandle m_RenderTarget;
                    /*0xd0*/ int m_ScreenSpaceShadowmapTextureID;
                    /*0xd8*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData m_PassData;

                    static /*0x7c7d2a4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RTHandle target);
                    /*0x7c7c1a8*/ ScreenSpaceShadowsPass();
                    /*0x7c7c894*/ void Dispose();
                    /*0x7c7c774*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings featureSettings, UnityEngine.Material material);
                    /*0x7c7c91c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7c7caa0*/ void InitPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData passData);
                    /*0x7c7cae8*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                    /*0x7c7d3d8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle target;
                        /*0x20*/ UnityEngine.Material material;
                        /*0x28*/ int shadowmapID;

                        /*0x7c7c914*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__11_0;

                        static /*0x7c7d630*/ <>c();
                        /*0x7c7d698*/ <>c();
                        /*0x7c7d6a0*/ void <RecordRenderGraph>b__11_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }

                class ScreenSpaceShadowsPostPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.RTHandle k_CurrentActive;

                    static /*0x7c7de94*/ ScreenSpaceShadowsPostPass();
                    static /*0x7c7d788*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7c7c2f4*/ ScreenSpaceShadowsPostPass();
                    /*0x7c7d724*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7c7d850*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7c7d9e0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass pass;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;

                        /*0x7c7df58*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                        static /*0x7c7df60*/ <>c();
                        /*0x7c7dfc8*/ <>c();
                        /*0x7c7dfd0*/ void <RecordRenderGraph>b__6_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }
            }

            class RenderingLayerUtils
            {
                static /*0x7c7e038*/ void CombineRendererEvents(bool isDeferred, int msaaSampleCount, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event rendererEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent);
                static /*0x7c7e06c*/ bool RequireRenderingLayers(UnityEngine.Rendering.Universal.UniversalRenderer universalRenderer, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x7c7e0dc*/ bool RequireRenderingLayers(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, UnityEngine.Rendering.Universal.RenderingMode renderingMode, bool accurateGbufferNormals, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x7c7e408*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c7e474*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c7e588*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c7e610*/ uint ToValidRenderingLayers(uint renderingLayers);
                static /*0x7c7e3d4*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize GetMaskSize(int bits);
                static /*0x7c7e53c*/ int GetBits(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c7e060*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.Event a, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event b);
                static /*0x7c7e3c8*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize a, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize b);

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

                static /*0x7c82e5c*/ RenderingUtils();
                static /*0x7c7e6ec*/ UnityEngine.Rendering.AttachmentDescriptor get_emptyAttachment();
                static /*0x7c7e750*/ UnityEngine.Mesh get_fullscreenMesh();
                static /*0x7c7ed18*/ bool get_useStructuredBuffer();
                static /*0x7c7ed20*/ bool SupportsLightLayers(UnityEngine.Rendering.GraphicsDeviceType type);
                static /*0x7c7ed28*/ UnityEngine.Material get_errorMaterial();
                static /*0x7c7eec0*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x7c6ef08*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x7c7efc0*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle rTHandle);
                static /*0x7c7f134*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7c7f2d8*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x7c7f49c*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destinationColor, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle destinationDepthStencil, UnityEngine.Rendering.RenderBufferLoadAction depthStencilLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStencilStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x7c7f6a0*/ void FinalBlit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int passIndex);
                static /*0x7c7fb8c*/ void CreateRendererParamsObjectsWithError(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererListParams param);
                static /*0x7c7fe6c*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c7ffe0*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x7c800fc*/ void DrawRendererListObjectsWithError(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c6f6f0*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c6f408*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x7c80144*/ void ClearSystemInfoCache();
                static /*0x7c801bc*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
                static /*0x7c802b4*/ bool SupportsGraphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x7c802c4*/ int GetLastValidColorBufferIndex(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x7c80374*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x7c8044c*/ bool IsMRT(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x7c804ac*/ bool Contains(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x7c8055c*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x7c80614*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x7c806a8*/ uint CountDistinct(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x7c807fc*/ int LastValid(UnityEngine.Rendering.RTHandle[] source);
                static /*0x7c808c0*/ bool Contains(UnityEngine.Rendering.ClearFlag a, UnityEngine.Rendering.ClearFlag b);
                static /*0x7c808cc*/ bool SequenceEqual(UnityEngine.Rendering.RTHandle[] left, UnityEngine.Rendering.RTHandle[] right);
                static /*0x7c809c4*/ bool MultisampleDepthResolveSupported();
                static /*0x7c80a5c*/ bool RTHandleNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc descriptor, bool scaled);
                static /*0x7c80ec8*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraTargetIdentifier(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7c81084*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c814ec*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c818f0*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c72950*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c81d28*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c822d8*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c828a4*/ bool SetMaxRTHandlePoolCapacity(int capacity);
                static /*0x7c8141c*/ void AddStaleResourceToPoolOrRelease(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, UnityEngine.Rendering.RTHandle handle);
                static /*0x7c82940*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c82a90*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c82c38*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c6f1cc*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c82d88*/ UnityEngine.Vector4 GetFinalBlitScaleBias(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
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

                /*0x7c8370c*/ Renderer2DResources();
                /*0x7c8331c*/ int get_version();
                /*0x7c83324*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c8332c*/ UnityEngine.Shader get_lightShader();
                /*0x7c83334*/ void set_lightShader(UnityEngine.Shader value);
                /*0x7c833a8*/ UnityEngine.Shader get_projectedShadowShader();
                /*0x7c833b0*/ void set_projectedShadowShader(UnityEngine.Shader value);
                /*0x7c83424*/ UnityEngine.Shader get_spriteShadowShader();
                /*0x7c8342c*/ void set_spriteShadowShader(UnityEngine.Shader value);
                /*0x7c834a0*/ UnityEngine.Shader get_spriteUnshadowShader();
                /*0x7c834a8*/ void set_spriteUnshadowShader(UnityEngine.Shader value);
                /*0x7c8351c*/ UnityEngine.Shader get_geometryShadowShader();
                /*0x7c83524*/ void set_geometryShadowShader(UnityEngine.Shader value);
                /*0x7c83598*/ UnityEngine.Shader get_geometryUnshadowShader();
                /*0x7c835a0*/ void set_geometryUnshadowShader(UnityEngine.Shader value);
                /*0x7c83614*/ UnityEngine.Texture2D get_fallOffLookup();
                /*0x7c8361c*/ void set_fallOffLookup(UnityEngine.Texture2D value);
                /*0x7c83690*/ UnityEngine.Shader get_copyDepthPS();
                /*0x7c83698*/ void set_copyDepthPS(UnityEngine.Shader value);
            }

            class UniversalRendererResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_CopyDepthPS;
                /*0x20*/ UnityEngine.Shader m_CameraMotionVector;
                /*0x28*/ UnityEngine.Shader m_StencilDeferredPS;
                /*0x30*/ UnityEngine.Shader m_DBufferClear;

                /*0x7c83914*/ UniversalRendererResources();
                /*0x7c83714*/ int get_version();
                /*0x7c8371c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c83724*/ UnityEngine.Shader get_copyDepthPS();
                /*0x7c8372c*/ void set_copyDepthPS(UnityEngine.Shader value);
                /*0x7c837a0*/ UnityEngine.Shader get_cameraMotionVector();
                /*0x7c837a8*/ void set_cameraMotionVector(UnityEngine.Shader value);
                /*0x7c8381c*/ UnityEngine.Shader get_stencilDeferredPS();
                /*0x7c83824*/ void set_stencilDeferredPS(UnityEngine.Shader value);
                /*0x7c83898*/ UnityEngine.Shader get_decalDBufferClear();
                /*0x7c838a0*/ void set_decalDBufferClear(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineDebugShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_DebugReplacementPS;
                /*0x18*/ UnityEngine.Shader m_HdrDebugViewPS;
                /*0x20*/ UnityEngine.ComputeShader m_ProbeVolumeSamplingDebugComputeShader;

                /*0x7c83aa0*/ UniversalRenderPipelineDebugShaders();
                /*0x7c8391c*/ int get_version();
                /*0x7c83924*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c8392c*/ UnityEngine.Shader get_debugReplacementPS();
                /*0x7c83934*/ void set_debugReplacementPS(UnityEngine.Shader value);
                /*0x7c839a8*/ UnityEngine.Shader get_hdrDebugViewPS();
                /*0x7c839b0*/ void set_hdrDebugViewPS(UnityEngine.Shader value);
                /*0x7c83a24*/ UnityEngine.ComputeShader get_probeVolumeSamplingDebugComputeShader();
                /*0x7c83a2c*/ void set_probeVolumeSamplingDebugComputeShader(UnityEngine.ComputeShader value);
            }

            class UniversalRenderPipelineRuntimeShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_FallbackErrorShader;
                /*0x20*/ UnityEngine.Shader m_BlitHDROverlay;
                /*0x28*/ UnityEngine.Shader m_CoreBlitPS;
                /*0x30*/ UnityEngine.Shader m_CoreBlitColorAndDepthPS;
                /*0x38*/ UnityEngine.Shader m_SamplingPS;

                /*0x7c83d24*/ UniversalRenderPipelineRuntimeShaders();
                /*0x7c83aa8*/ int get_version();
                /*0x7c83ab0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c83ab8*/ UnityEngine.Shader get_fallbackErrorShader();
                /*0x7c83ac0*/ void set_fallbackErrorShader(UnityEngine.Shader value);
                /*0x7c83b34*/ UnityEngine.Shader get_blitHDROverlay();
                /*0x7c83b3c*/ void set_blitHDROverlay(UnityEngine.Shader value);
                /*0x7c83bb0*/ UnityEngine.Shader get_coreBlitPS();
                /*0x7c83bb8*/ void set_coreBlitPS(UnityEngine.Shader value);
                /*0x7c83c2c*/ UnityEngine.Shader get_coreBlitColorAndDepthPS();
                /*0x7c83c34*/ void set_coreBlitColorAndDepthPS(UnityEngine.Shader value);
                /*0x7c83ca8*/ UnityEngine.Shader get_samplingPS();
                /*0x7c83cb0*/ void set_samplingPS(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineRuntimeTextures : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Texture2D m_BlueNoise64LTex;
                /*0x20*/ UnityEngine.Texture2D m_BayerMatrixTex;
                /*0x28*/ UnityEngine.Texture2D m_DebugFontTex;

                /*0x7c83eb0*/ UniversalRenderPipelineRuntimeTextures();
                /*0x7c83d2c*/ int get_version();
                /*0x7c83d34*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c83d3c*/ UnityEngine.Texture2D get_blueNoise64LTex();
                /*0x7c83d44*/ void set_blueNoise64LTex(UnityEngine.Texture2D value);
                /*0x7c83db8*/ UnityEngine.Texture2D get_bayerMatrixTex();
                /*0x7c83dc0*/ void set_bayerMatrixTex(UnityEngine.Texture2D value);
                /*0x7c83e34*/ UnityEngine.Texture2D get_debugFontTexture();
                /*0x7c83e3c*/ void set_debugFontTexture(UnityEngine.Texture2D value);
            }

            class UniversalRenderPipelineRuntimeXRResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_xrOcclusionMeshPS;
                /*0x18*/ UnityEngine.Shader m_xrMirrorViewPS;
                /*0x20*/ UnityEngine.Shader m_xrMotionVector;

                /*0x7c84108*/ UniversalRenderPipelineRuntimeXRResources();
                /*0x7c83ec0*/ int get_version();
                /*0x7c83ec8*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c83ed0*/ UnityEngine.Shader get_xrOcclusionMeshPS();
                /*0x7c83ed8*/ void set_xrOcclusionMeshPS(UnityEngine.Shader value);
                /*0x7c83f4c*/ UnityEngine.Shader get_xrMirrorViewPS();
                /*0x7c83f54*/ void set_xrMirrorViewPS(UnityEngine.Shader value);
                /*0x7c83fc8*/ UnityEngine.Shader get_xrMotionVector();
                /*0x7c83fd0*/ void set_xrMotionVector(UnityEngine.Shader value);
                /*0x7c84044*/ bool get_valid();
            }

            struct RenderTargetHandle
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.RenderTargetHandle CameraTarget;
                /*0x10*/ int <id>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier <rtid>k__BackingField;

                static /*0x7c84a54*/ RenderTargetHandle();
                static /*0x7c843c8*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetCameraTarget(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7c84928*/ bool op_Equality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                static /*0x7c849bc*/ bool op_Inequality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                /*0x7c84150*/ RenderTargetHandle(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x7c841c8*/ RenderTargetHandle(UnityEngine.Rendering.RTHandle rtHandle);
                /*0x7c84110*/ void set_id(int value);
                /*0x7c84118*/ int get_id();
                /*0x7c84120*/ void set_rtid(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7c84138*/ UnityEngine.Rendering.RenderTargetIdentifier get_rtid();
                /*0x7c84498*/ void Init(string shaderProperty);
                /*0x7c8450c*/ void Init(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x7c84584*/ UnityEngine.Rendering.RenderTargetIdentifier Identifier();
                /*0x7c84694*/ bool HasInternalRenderTargetId();
                /*0x7c846f0*/ bool Equals(UnityEngine.Rendering.Universal.RenderTargetHandle other);
                /*0x7c84814*/ bool Equals(object obj);
                /*0x7c848d4*/ int GetHashCode();
            }

            class RTHandleResourcePool
            {
                static /*0x0*/ int s_CurrentStaleResourceCount;
                static /*0x4*/ int s_StaleResourceLifetime;
                static /*0x8*/ int s_StaleResourceMaxCapacity;
                /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<UnityEngine.Rendering.RTHandle, int>>> m_ResourcePool;
                /*0x18*/ System.Collections.Generic.List<int> m_RemoveList;

                static /*0x7c8625c*/ RTHandleResourcePool();
                static /*0x7c85418*/ bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                static /*0x7c86018*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc CreateTextureDesc(UnityEngine.RenderTextureDescriptor desc, UnityEngine.Rendering.RenderGraphModule.TextureSizeMode textureSizeMode, int anisoLevel, float mipMapBias, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, string name);
                /*0x7c8617c*/ RTHandleResourcePool();
                /*0x7c84ab0*/ int get_staleResourceCapacity();
                /*0x7c84b08*/ void set_staleResourceCapacity(int value);
                /*0x7c84fdc*/ bool AddResourceToPool(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, UnityEngine.Rendering.RTHandle resource, int currentFrameIndex);
                /*0x7c85238*/ bool TryGetResource(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, ref UnityEngine.Rendering.RTHandle resource, bool usepool);
                /*0x7c84ba4*/ void Cleanup();
                /*0x7c8548c*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x7c859e8*/ void LogDebugInfo();
                /*0x7c851e0*/ int GetHashCodeWithNameHash(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc);
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

                /*0x7c864f0*/ ScriptableRendererFeature();
                /*0x7c862b4*/ bool get_isActive();
                /*0x380cb08*/ void Create();
                /*0x7c862bc*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x380d93c*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c862c0*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c862c4*/ void OnEnable();
                /*0x7c86390*/ void OnValidate();
                /*0x7c8645c*/ bool SupportsNativeRenderPass();
                /*0x7c86464*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x7c86474*/ void SetActive(bool active);
                /*0x7c86480*/ void Dispose();
                /*0x7c864ec*/ void Dispose(bool disposing);
            }

            class RenderGraphSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.RenderGraphSettings.Version m_Version;
                /*0x14*/ bool m_EnableRenderCompatibilityMode;

                /*0x7c86628*/ RenderGraphSettings();
                /*0x7c86500*/ int get_version();
                /*0x7c86508*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c86510*/ bool get_enableRenderCompatibilityMode();
                /*0x7c865b4*/ void set_enableRenderCompatibilityMode(bool value);

                enum Version
                {
                    Initial = 0,
                }
            }

            class URPDefaultVolumeProfileSettings : UnityEngine.Rendering.IDefaultVolumeProfileSettings, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.URPDefaultVolumeProfileSettings.Version m_Version;
                /*0x18*/ UnityEngine.Rendering.VolumeProfile m_VolumeProfile;

                /*0x7c866b4*/ URPDefaultVolumeProfileSettings();
                /*0x7c86630*/ int get_version();
                /*0x7c86638*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x7c86640*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);

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

                /*0x7c86838*/ URPShaderStrippingSetting();
                /*0x7c866bc*/ int get_version();
                /*0x7c866c4*/ bool get_stripUnusedPostProcessingVariants();
                /*0x7c866cc*/ void set_stripUnusedPostProcessingVariants(bool value);
                /*0x7c86740*/ bool get_stripUnusedVariants();
                /*0x7c86748*/ void set_stripUnusedVariants(bool value);
                /*0x7c867bc*/ bool get_stripScreenCoordOverrideVariants();
                /*0x7c867c4*/ void set_stripScreenCoordOverrideVariants(bool value);

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

                /*0x7c86848*/ int get_elemLength();
                /*0x7c86860*/ int get_bitCapacity();
                /*0x7c8687c*/ float[] get_data();
                /*0x7c86884*/ void Resize(int bitCount);
                /*0x7c869e0*/ void Clear();
                /*0x7c86a30*/ void GetElementIndexAndBitOffset(int index, ref int elemIndex, ref int bitOffset);
                /*0x7c86a44*/ bool get_Item(int index);
                /*0x7c86a74*/ void set_Item(int index, bool value);
                /*0x7c86ab8*/ string ToString();
            }

            class ShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.ShaderData m_Instance;
                /*0x10*/ UnityEngine.ComputeBuffer m_LightDataBuffer;
                /*0x18*/ UnityEngine.ComputeBuffer m_LightIndicesBuffer;
                /*0x20*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;
                /*0x28*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

                static /*0x7c86c2c*/ UnityEngine.Rendering.Universal.ShaderData get_instance();
                /*0x7c86c24*/ ShaderData();
                /*0x7c86cb4*/ void Dispose();
                /*0x7c86d14*/ UnityEngine.ComputeBuffer GetLightDataBuffer(int size);
                /*0x7c86d70*/ UnityEngine.ComputeBuffer GetLightIndicesBuffer(int size);
                /*0x7c86dcc*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size);
                /*0x7c86e28*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size);
                /*0x380bc74*/ UnityEngine.ComputeBuffer GetOrUpdateBuffer<T>(ref UnityEngine.ComputeBuffer buffer, int size);
                /*0x7c86ce0*/ void DisposeBuffer(ref UnityEngine.ComputeBuffer buffer);
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

                static /*0x7c87288*/ ShaderUtils();
                static /*0x7c86e84*/ string GetShaderPath(UnityEngine.Rendering.Universal.ShaderPathID id);
                static /*0x7c870d8*/ UnityEngine.Rendering.Universal.ShaderPathID GetEnumFromPath(string path);
                static /*0x7c871f0*/ bool IsLWShader(UnityEngine.Shader shader);
                static /*0x7c87280*/ float get_PersistentDeltaTime();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string path;

                    /*0x7c871e8*/ <>c__DisplayClass2_0();
                    /*0x7c87574*/ bool <GetEnumFromPath>b__0(string m);
                }
            }

            struct URPLightShadowCullingInfos
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.ShadowSliceData> slices;
                /*0x20*/ uint slicesValidMask;

                /*0x7c87588*/ bool IsSliceValid(int i);
            }

            class ShadowCulling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler computeShadowCasterCullingInfosMarker;

                static /*0x7c88354*/ ShadowCulling();
                static /*0x7c87598*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> CullShadowCasters(ref UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullResults);
                static /*0x7c87684*/ void ComputeShadowCasterCullingInfos(UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.ShadowCastersCullingInfos shadowCullingInfos, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> urpVisibleLightsShadowCullingInfos);
                static /*0x7c88334*/ UnityEngine.Rendering.BatchCullingProjectionType GetCullingProjectionType(UnityEngine.LightType type);
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

                /*0x7c883f0*/ void Clear();
            }

            class ShadowUtils
            {
                static int kMinimumPunctualLightHardShadowResolution = 8;
                static int kMinimumPunctualLightSoftShadowResolution = 16;
                static /*0x0*/ bool m_ForceShadowPointSampling;

                static /*0x7c88480*/ ShadowUtils();
                static /*0x7c8854c*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix);
                static /*0x7c88688*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x7c87ec0*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x7c88a1c*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c88228*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c88ac0*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c880cc*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c88b84*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7c88cfc*/ void RenderShadowSlice(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.RendererList shadowRendererList, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7c88e38*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings);
                static /*0x7c88f08*/ int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount);
                static /*0x7c888e0*/ void ApplySliceTransform(ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight);
                static /*0x7c88f34*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, ref UnityEngine.Rendering.Universal.ShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7c893ac*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7c89014*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, System.Collections.Generic.List<UnityEngine.Vector4> bias, bool supportsSoftShadows, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7c89474*/ void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, ref float scale, ref float bias);
                static /*0x7c894c8*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x7c89594*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x7c896b8*/ void SetShadowBias(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 shadowBias);
                static /*0x7c89754*/ void SetLightDirection(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightDirection);
                static /*0x7c897ec*/ void SetLightPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightPosition);
                static /*0x7c89884*/ void SetCameraPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 worldSpaceCameraPos);
                static /*0x7c8991c*/ void SetWorldToCameraAndCameraToWorldMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix);
                static /*0x7c89a80*/ UnityEngine.RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits);
                static /*0x7c89b88*/ UnityEngine.RenderTexture GetTemporaryShadowTexture(int width, int height, int bits);
                static /*0x7c89c48*/ bool ShadowRTNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7c89ed8*/ UnityEngine.Rendering.RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7c89fc4*/ bool ShadowRTReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7c88760*/ UnityEngine.Matrix4x4 GetShadowTransform(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7c8a0c0*/ float SoftShadowQualityToShaderProperty(UnityEngine.Light light, bool softShadowsEnabled);
                static /*0x7c8a228*/ bool SupportsPerLightSoftShadowQuality();
                static /*0x7c8a2b8*/ void SetPerLightSoftShadowKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, bool hasSoftShadows);
                static /*0x7c8a360*/ void SetSoftShadowQualityShaderKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x7c8a5dc*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i);
                static /*0x7c8a724*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i, UnityEngine.LightType lightType, UnityEngine.LightShadows lightShadows, float shadowStrength);
                static /*0x7c880ac*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                static /*0x7c8a768*/ bool FastApproximately(float a, float b);
                static /*0x7c8a780*/ bool FastApproximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
                static /*0x7c8a880*/ int MinimalPunctualLightShadowResolution(bool softShadow);
            }

            class SpaceFillingCurves
            {
                static /*0x7c8a894*/ uint Part1By1(uint x);
                static /*0x7c8a8bc*/ uint Compact1By1(uint x);
                static /*0x7c8a8e4*/ uint EncodeMorton2D(Unity.Mathematics.uint2 coord);
                static /*0x7c8a938*/ Unity.Mathematics.uint2 DecodeMorton2D(uint code);
            }

            class StpUtils
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.JitterFunc s_JitterFunc;

                static /*0x7c8b2b8*/ StpUtils();
                static /*0x7c8a98c*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x7c8aa08*/ void PopulateStpConfig(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, int debugViewIndex, UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture, ref UnityEngine.Rendering.STP.Config config);
                static /*0x7c8afcc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture);
            }

            class SupportedOnRendererAttribute : System.Attribute
            {
                /*0x10*/ System.Type[] <rendererTypes>k__BackingField;

                /*0x7c8b3fc*/ SupportedOnRendererAttribute(System.Type renderer);
                /*0x7c8b4a8*/ SupportedOnRendererAttribute(System.Type[] renderers);
                /*0x7c8b3f4*/ System.Type[] get_rendererTypes();
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

                static /*0x7c8d278*/ TemporalAA();
                static /*0x7c8afb0*/ int CalculateTaaFrameIndex(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x7c8b64c*/ UnityEngine.Matrix4x4 CalculateJitterMatrix(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.TemporalAA.JitterFunc jitterFunc);
                static /*0x7c8b7c0*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x7c8b824*/ float[] CalculateFilterWeights(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x7c8b9d8*/ UnityEngine.RenderTextureDescriptor TemporalAADescFromCameraDesc(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                static /*0x7c8bbe8*/ string ValidateAndWarn(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isSTPRequested);
                static /*0x7c8c03c*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material taaMaterial, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.RenderTexture motionVectors);
                static /*0x7c8c588*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Material taaMaterial, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcDepth, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcMotionVectors, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);

                class ShaderConstants
                {
                    static /*0x0*/ int _TaaAccumulationTex;
                    static /*0x4*/ int _TaaMotionVectorTex;
                    static /*0x8*/ int _TaaFilterWeights;
                    static /*0xc*/ int _TaaFrameInfluence;
                    static /*0x10*/ int _TaaVarianceClampScale;
                    static /*0x14*/ int _CameraDepthTexture;

                    static /*0x7c8d4ac*/ ShaderConstants();
                }

                class ShaderKeywords
                {
                    static /*0x0*/ string TAA_LOW_PRECISION_SOURCE;

                    static /*0x7c8d608*/ ShaderKeywords();
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

                    static /*0x7c8d758*/ UnityEngine.Rendering.Universal.TemporalAA.Settings Create();
                    /*0x7c8d674*/ UnityEngine.Rendering.Universal.TemporalAAQuality get_quality();
                    /*0x7c8d67c*/ void set_quality(UnityEngine.Rendering.Universal.TemporalAAQuality value);
                    /*0x7c8d694*/ float get_baseBlendFactor();
                    /*0x7c8d6a4*/ void set_baseBlendFactor(float value);
                    /*0x7c8d6c4*/ float get_jitterScale();
                    /*0x7c8d6cc*/ void set_jitterScale(float value);
                    /*0x7c8d6e8*/ float get_mipBias();
                    /*0x7c8d6f0*/ void set_mipBias(float value);
                    /*0x7c8d70c*/ float get_varianceClampScale();
                    /*0x7c8d714*/ void set_varianceClampScale(float value);
                    /*0x7c8d734*/ float get_contrastAdaptiveSharpening();
                    /*0x7c8d73c*/ void set_contrastAdaptiveSharpening(float value);
                }

                class JitterFunc : System.MulticastDelegate
                {
                    /*0x7c8b354*/ JitterFunc(object object, nint method);
                    /*0x7c8d778*/ void Invoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                    /*0x7c8d78c*/ System.IAsyncResult BeginInvoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.AsyncCallback callback, object object);
                    /*0x7c8d854*/ void EndInvoke(ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.IAsyncResult result);
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

                    /*0x7c8d878*/ TaaPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x7c8d880*/ <>c();
                    /*0x7c8d8e8*/ <>c();
                    /*0x7c8d8f0*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c8dbfc*/ void <Render>b__17_1(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            struct InclusiveRange
            {
                /*0x10*/ short start;
                /*0x12*/ short end;

                static /*0x7c8de6c*/ UnityEngine.Rendering.Universal.InclusiveRange Merge(UnityEngine.Rendering.Universal.InclusiveRange a, UnityEngine.Rendering.Universal.InclusiveRange b);
                static /*0x7c8df00*/ UnityEngine.Rendering.Universal.InclusiveRange get_empty();
                /*0x7c8dd04*/ InclusiveRange(short startEnd);
                /*0x7c8dd10*/ InclusiveRange(short start, short end);
                /*0x7c8dd1c*/ void Expand(short index);
                /*0x7c8dda8*/ void Clamp(short min, short max);
                /*0x7c8de34*/ bool get_isEmpty();
                /*0x7c8de48*/ bool Contains(short index);
                /*0x7c8df08*/ string ToString();
            }

            struct LightMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x7c8df9c*/ void Execute(int index);
            }

            struct ReflectionProbeMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x7c8e4c8*/ void Execute(int index);
            }

            struct TileRangeExpansionJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x20*/ Unity.Collections.NativeArray<uint> tileMasks;
                /*0x30*/ int rangesPerItem;
                /*0x34*/ int itemsPerTile;
                /*0x38*/ int wordsPerTile;
                /*0x3c*/ Unity.Mathematics.int2 tileResolution;

                /*0x7c8e6b4*/ void Execute(int jobIndex);
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
                static /*0x7c8e8c4*/ bool IsValid(UnityEngine.Rendering.Universal.TileSize tileSize);
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

                static /*0x7c93f1c*/ TilingJob();
                static /*0x7c91cf0*/ float square(float x);
                static /*0x7c91cf8*/ void GetSphereHorizon(Unity.Mathematics.float2 center, float radius, float near, float clipRadius, ref Unity.Mathematics.float2 p0, ref Unity.Mathematics.float2 p1);
                static /*0x7c93664*/ void GetSphereYPlaneHorizon(Unity.Mathematics.float3 center, float sphereRadius, float near, float clipRadius, float y, ref Unity.Mathematics.float3 left, ref Unity.Mathematics.float3 right);
                static /*0x7c92264*/ bool GetCircleClipPoints(Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, float circleRadius, float near, ref Unity.Mathematics.float3 p0, ref Unity.Mathematics.float3 p1);
                static /*0x7c93db4*/ System.ValueTuple<float, float> IntersectEllipseLine(float a, float b, Unity.Mathematics.float3 line);
                static /*0x7c9206c*/ void GetProjectedCircleHorizon(Unity.Mathematics.float2 center, float radius, Unity.Mathematics.float2 U, Unity.Mathematics.float2 V, ref Unity.Mathematics.float2 uv1, ref Unity.Mathematics.float2 uv2);
                static /*0x7c92f58*/ bool IntersectCircleYPlane(float y, Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, float circleRadius, ref Unity.Mathematics.float3 p1, ref Unity.Mathematics.float3 p2);
                static /*0x7c929d0*/ void GetConeSideTangentPoints(Unity.Mathematics.float3 vertex, Unity.Mathematics.float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, ref Unity.Mathematics.float3 l1, ref Unity.Mathematics.float3 l2);
                static /*0x7c926f0*/ Unity.Mathematics.float3 EvaluateNearConic(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float theta);
                static /*0x7c92464*/ Unity.Mathematics.float2 FindNearConicTangentTheta(Unity.Mathematics.float2 o, Unity.Mathematics.float2 d, float r, Unity.Mathematics.float2 u, Unity.Mathematics.float2 v);
                static /*0x7c93200*/ Unity.Mathematics.float2 FindNearConicYTheta(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float y);
                static /*0x7c91f7c*/ bool <TileLight>g__SpherePointIsValid|19_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x7c928bc*/ bool <TileLight>g__ConicPointIsValid|19_1(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x7c93b5c*/ bool <TileLightOrthographic>g__SpherePointIsValid|20_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                /*0x7c8e8ec*/ void Execute(int jobIndex);
                /*0x7c8f67c*/ void TileLight(int lightIndex);
                /*0x7c8e9f4*/ void TileLightOrthographic(int lightIndex);
                /*0x7c913a8*/ void TileReflectionProbe(int index);
                /*0x7c92eb4*/ Unity.Mathematics.float2 ViewToTileSpace(Unity.Mathematics.float3 positionVS);
                /*0x7c93d24*/ Unity.Mathematics.float2 ViewToTileSpaceOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x7c91bd4*/ void ExpandY(Unity.Mathematics.float3 positionVS);
                /*0x7c93a40*/ void ExpandOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x7c93c4c*/ void ExpandRangeOrthographic(ref UnityEngine.Rendering.Universal.InclusiveRange range, float xVS);

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

                static /*0x7c940dc*/ uint EncodeHeader(uint min, uint max);
                static /*0x7c940e4*/ System.ValueTuple<uint, uint> DecodeHeader(uint zBin);
                /*0x7c94148*/ void Execute(int jobIndex);
                /*0x7c9425c*/ void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset);
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
                static /*0x7c94480*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData GetUniversalAdditionalCameraData(UnityEngine.Camera camera);
                static /*0x7c9451c*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(UnityEngine.Camera camera);
                static /*0x7c94538*/ void SetVolumeFrameworkUpdateMode(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode mode);
                static /*0x7c94750*/ void UpdateVolumeStack(UnityEngine.Camera camera);
                static /*0x7c94620*/ void UpdateVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x7c94a9c*/ void DestroyVolumeStack(UnityEngine.Camera camera);
                static /*0x7c94ab0*/ void DestroyVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x7c9489c*/ void GetVolumeLayerMaskAndTrigger(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData, ref UnityEngine.LayerMask layerMask, ref UnityEngine.Transform trigger);
            }

            class CameraTypeUtility
            {
                static /*0x0*/ string[] s_CameraTypeNames;

                static /*0x7c94d38*/ CameraTypeUtility();
                static /*0x7c94c8c*/ string GetName(UnityEngine.Rendering.Universal.CameraRenderType type);
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

                static /*0x7c94e18*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData get_defaultAdditionalCameraData();
                /*0x7c94ed0*/ UniversalAdditionalCameraData();
                /*0x7c94e10*/ float get_version();
                /*0x7c95034*/ UnityEngine.Camera get_camera();
                /*0x7c950dc*/ void Start();
                /*0x7c95110*/ bool get_renderShadows();
                /*0x7c95118*/ void set_renderShadows(bool value);
                /*0x7c95124*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresDepthOption();
                /*0x7c9512c*/ void set_requiresDepthOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x7c95134*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresColorOption();
                /*0x7c9513c*/ void set_requiresColorOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x7c95144*/ UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x7c9514c*/ void set_renderType(UnityEngine.Rendering.Universal.CameraRenderType value);
                /*0x7c8beb8*/ System.Collections.Generic.List<UnityEngine.Camera> get_cameraStack();
                /*0x7c95438*/ void UpdateCameraStack();
                /*0x7c9572c*/ bool get_clearDepth();
                /*0x7c95734*/ bool get_requiresDepthTexture();
                /*0x7c957b8*/ void set_requiresDepthTexture(bool value);
                /*0x7c957d4*/ bool get_requiresColorTexture();
                /*0x7c95858*/ void set_requiresColorTexture(bool value);
                /*0x7c95154*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x7c95874*/ void SetRenderer(int index);
                /*0x7c9587c*/ UnityEngine.LayerMask get_volumeLayerMask();
                /*0x7c95884*/ void set_volumeLayerMask(UnityEngine.LayerMask value);
                /*0x7c9588c*/ UnityEngine.Transform get_volumeTrigger();
                /*0x7c95894*/ void set_volumeTrigger(UnityEngine.Transform value);
                /*0x7c9589c*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x7c958a4*/ void set_volumeFrameworkUpdateMode(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode value);
                /*0x7c945a0*/ bool get_requiresVolumeFrameworkUpdate();
                /*0x7c958ac*/ UnityEngine.Rendering.VolumeStack get_volumeStack();
                /*0x7c94b38*/ void set_volumeStack(UnityEngine.Rendering.VolumeStack value);
                /*0x7c9476c*/ void GetOrCreateVolumeStack();
                /*0x7c958b4*/ bool get_renderPostProcessing();
                /*0x7c958bc*/ void set_renderPostProcessing(bool value);
                /*0x7c958c8*/ UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x7c958d0*/ void set_antialiasing(UnityEngine.Rendering.Universal.AntialiasingMode value);
                /*0x7c958d8*/ UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x7c958e0*/ void set_antialiasingQuality(UnityEngine.Rendering.Universal.AntialiasingQuality value);
                /*0x7c958e8*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x7c958f0*/ UnityEngine.Rendering.ICameraHistoryReadAccess get_history();
                /*0x7c958f8*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7c95900*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData get_motionVectorsPersistentData();
                /*0x7c95908*/ bool get_resetHistory();
                /*0x7c95918*/ void set_resetHistory(bool value);
                /*0x7c9595c*/ bool get_stopNaN();
                /*0x7c95964*/ void set_stopNaN(bool value);
                /*0x7c95970*/ bool get_dithering();
                /*0x7c95978*/ void set_dithering(bool value);
                /*0x7c95984*/ bool get_allowXRRendering();
                /*0x7c9598c*/ void set_allowXRRendering(bool value);
                /*0x7c95998*/ bool get_useScreenCoordOverride();
                /*0x7c959a0*/ void set_useScreenCoordOverride(bool value);
                /*0x7c959ac*/ UnityEngine.Vector4 get_screenSizeOverride();
                /*0x7c959b8*/ void set_screenSizeOverride(UnityEngine.Vector4 value);
                /*0x7c959c4*/ UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x7c959d0*/ void set_screenCoordScaleBias(UnityEngine.Vector4 value);
                /*0x7c959dc*/ bool get_allowHDROutput();
                /*0x7c959e4*/ void set_allowHDROutput(bool value);
                /*0x7c959f0*/ void OnBeforeSerialize();
                /*0x7c959f4*/ void OnAfterDeserialize();
                /*0x7c95a1c*/ void OnValidate();
                /*0x7c95ab0*/ void OnDrawGizmos();
                /*0x7c95bc8*/ void OnDestroy();
                /*0x7c95c34*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRawRenderer();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Camera> <>9__53_0;

                    static /*0x7c95d94*/ <>c();
                    /*0x7c95dfc*/ <>c();
                    /*0x7c95e04*/ bool <UpdateCameraStack>b__53_0(UnityEngine.Camera cam);
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
                static /*0x7c95e60*/ UnityEngine.Rendering.Universal.UniversalAdditionalLightData GetUniversalAdditionalLightData(UnityEngine.Light light);
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

                static /*0x7c962cc*/ UniversalAdditionalLightData();
                /*0x7c961e4*/ UniversalAdditionalLightData();
                /*0x7c95efc*/ int get_version();
                /*0x7c95f04*/ bool get_usePipelineSettings();
                /*0x7c95f0c*/ void set_usePipelineSettings(bool value);
                /*0x7c95f18*/ UnityEngine.Light get_light();
                /*0x7c95fb0*/ int get_additionalLightsShadowResolutionTier();
                /*0x7c95fb8*/ UnityEngine.Rendering.Universal.LightLayerEnum get_lightLayerMask();
                /*0x7c95fc0*/ void set_lightLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x7c95fc8*/ uint get_renderingLayers();
                /*0x7c95fd0*/ void set_renderingLayers(uint value);
                /*0x7c96090*/ bool get_customShadowLayers();
                /*0x7c96098*/ void set_customShadowLayers(bool value);
                /*0x7c960b4*/ UnityEngine.Rendering.Universal.LightLayerEnum get_shadowLayerMask();
                /*0x7c960bc*/ void set_shadowLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x7c960c4*/ uint get_shadowRenderingLayers();
                /*0x7c960cc*/ void set_shadowRenderingLayers(uint value);
                /*0x7c960e4*/ UnityEngine.Vector2 get_lightCookieSize();
                /*0x7c960ec*/ void set_lightCookieSize(UnityEngine.Vector2 value);
                /*0x7c960f4*/ UnityEngine.Vector2 get_lightCookieOffset();
                /*0x7c960fc*/ void set_lightCookieOffset(UnityEngine.Vector2 value);
                /*0x7c96104*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x7c9610c*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x7c96114*/ void OnBeforeSerialize();
                /*0x7c96118*/ void OnAfterDeserialize();
                /*0x7c95fe8*/ void SyncLightAndShadowLayers();
            }

            class UniversalCameraHistory : UnityEngine.Rendering.ICameraHistoryReadAccess, UnityEngine.Rendering.ICameraHistoryWriteAccess, UnityEngine.Rendering.IPerFrameHistoryAccessTracker, System.IDisposable
            {
                static int k_ValidVersionCount = 2;
                static /*0x0*/ uint s_TypeCount;
                /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraHistory.Item[] m_Items;
                /*0x18*/ int m_Version;
                /*0x20*/ UnityEngine.Rendering.BufferedRTHandleSystem m_HistoryTextures;
                /*0x28*/ UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate OnGatherHistoryRequests;

                /*0x7c96468*/ UniversalCameraHistory();
                /*0x380cb08*/ void RequestAccess<Type>();
                /*0x3907c14*/ Type GetHistoryForRead<Type>();
                /*0x380b128*/ bool IsAccessRequested<Type>();
                /*0x3907c14*/ Type GetHistoryForWrite<Type>();
                /*0x380b128*/ bool IsWritten<Type>();
                /*0x7c96330*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x7c963cc*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x7c965a4*/ void Dispose();
                /*0x7c96634*/ void GatherHistoryRequests();
                /*0x7c96654*/ bool IsValidRequest(int i);
                /*0x7c96694*/ bool IsValid(int i);
                /*0x7c966d4*/ void ReleaseUnusedHistory();
                /*0x7c96790*/ void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight);

                class TypeId<T>
                {
                    static /*0x0*/ uint value;

                    static /*0x38358cc*/ TypeId();
                }

                struct Item
                {
                    /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                    /*0x18*/ int requestVersion;
                    /*0x1c*/ int writeVersion;

                    /*0x7c96578*/ void Reset();
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
                static string _CameraUpscaledTargetAttachmentAName = "_CameraUpscaledTargetAttachmentA";
                static string _CameraUpscaledTargetAttachmentBName = "_CameraUpscaledTargetAttachmentB";
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormalsOnly;
                static /*0x8*/ UnityEngine.Rendering.RTHandle[] m_RenderGraphCameraColorHandles;
                static /*0x10*/ UnityEngine.Rendering.RTHandle[] m_RenderGraphUpscaledCameraColorHandles;
                static /*0x18*/ UnityEngine.Rendering.RTHandle m_RenderGraphCameraDepthHandle;
                static /*0x20*/ int m_CurrentColorHandle;
                static /*0x24*/ bool m_UseUpscaledColorHandle;
                static /*0x28*/ UnityEngine.Rendering.RTHandle m_RenderGraphDebugTextureHandle;
                static /*0x30*/ bool m_RequiresIntermediateAttachments;
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
                /*0x1e8*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass m_XROcclusionMeshPass;
                /*0x1f0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_XRCopyDepthPass;
                /*0x1f8*/ UnityEngine.Rendering.Universal.XRDepthMotionPass m_XRDepthMotionPass;
                /*0x200*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOffscreenUIPass;
                /*0x208*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOverlayUIPass;
                /*0x210*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass m_HistoryRawColorCopyPass;
                /*0x218*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_HistoryRawDepthCopyPass;
                /*0x220*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem m_ColorBufferSystem;
                /*0x228*/ UnityEngine.Rendering.RTHandle m_ActiveCameraColorAttachment;
                /*0x230*/ UnityEngine.Rendering.RTHandle m_ColorFrontBuffer;
                /*0x238*/ UnityEngine.Rendering.RTHandle m_ActiveCameraDepthAttachment;
                /*0x240*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment;
                /*0x248*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment_D3d_11;
                /*0x250*/ UnityEngine.Rendering.RTHandle m_TargetColorHandle;
                /*0x258*/ UnityEngine.Rendering.RTHandle m_TargetDepthHandle;
                /*0x260*/ UnityEngine.Rendering.RTHandle m_DepthTexture;
                /*0x268*/ UnityEngine.Rendering.RTHandle m_NormalsTexture;
                /*0x270*/ UnityEngine.Rendering.RTHandle m_DecalLayersTexture;
                /*0x278*/ UnityEngine.Rendering.RTHandle m_OpaqueColor;
                /*0x280*/ UnityEngine.Rendering.RTHandle m_MotionVectorColor;
                /*0x288*/ UnityEngine.Rendering.RTHandle m_MotionVectorDepth;
                /*0x290*/ UnityEngine.Rendering.Universal.Internal.ForwardLights m_ForwardLights;
                /*0x298*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x2a0*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x2a4*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x2a8*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x2ac*/ UnityEngine.Rendering.Universal.DepthFormat m_CameraDepthAttachmentFormat;
                /*0x2b0*/ UnityEngine.Rendering.Universal.DepthFormat m_CameraDepthTextureFormat;
                /*0x2b4*/ bool m_DepthPrimingRecommended;
                /*0x2b5*/ UnityEngine.Rendering.StencilState m_DefaultStencilState;
                /*0x2c8*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                /*0x2d0*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;
                /*0x2d4*/ bool m_VulkanEnablePreTransform;
                /*0x2d8*/ UnityEngine.Material m_BlitMaterial;
                /*0x2e0*/ UnityEngine.Material m_BlitHDRMaterial;
                /*0x2e8*/ UnityEngine.Material m_SamplingMaterial;
                /*0x2f0*/ UnityEngine.Material m_StencilDeferredMaterial;
                /*0x2f8*/ UnityEngine.Material m_CameraMotionVecMaterial;
                /*0x300*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;
                /*0x340*/ UnityEngine.LayerMask <opaqueLayerMask>k__BackingField;
                /*0x344*/ UnityEngine.LayerMask <transparentLayerMask>k__BackingField;
                /*0x348*/ UnityEngine.Material m_DebugBlitMaterial;
                /*0x350*/ bool m_RequiresRenderingLayer;
                /*0x354*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event m_RenderingLayersEvent;
                /*0x358*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize m_RenderingLayersMaskSize;
                /*0x35c*/ bool m_RenderingLayerProvidesRenderObjectPass;
                /*0x35d*/ bool m_RenderingLayerProvidesByDepthNormalPass;
                /*0x360*/ string m_RenderingLayersTextureName;
                /*0x368*/ bool m_IssuedGPUOcclusionUnsupportedMsg;

                static /*0x7ca4d50*/ UniversalRenderer();
                static /*0x7c98580*/ bool IsOffscreenDepthTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7c985e8*/ bool IsOffscreenDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c9e678*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                static /*0x7c9e7cc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.Color color, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                /*0x7c968f0*/ UniversalRenderer(UnityEngine.Rendering.Universal.UniversalRendererData data);
                /*0x7c967ac*/ int SupportedCameraStackingTypes();
                /*0x7c967d0*/ bool SupportsMotionVectors();
                /*0x7c967d8*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeRequested();
                /*0x7c967e0*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeActual();
                /*0x7c96850*/ bool get_accurateGbufferNormals();
                /*0x7c96870*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x7c96878*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x7c96880*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x7c96888*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x7c96890*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x7c96898*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x7c968a0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x7c968a8*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c968b0*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c968b8*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c968c0*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c968c8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthTextureFormat();
                /*0x7c968dc*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthAttachmentFormat();
                /*0x7c97d28*/ void Dispose(bool disposing);
                /*0x7c980b4*/ void ReleaseRenderTargets();
                /*0x7c981ac*/ void SetupFinalPassDebug(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c98678*/ bool IsDepthPrimingEnabled(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9885c*/ bool IsWebGL();
                /*0x7c98864*/ bool IsGLESDevice();
                /*0x7c98880*/ bool IsGLDevice();
                /*0x7c988b4*/ bool HasActiveRenderFeatures();
                /*0x7c98a28*/ bool HasPassesRequiringIntermediateTexture();
                /*0x7c98b9c*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c9c438*/ void SetupVFXCameraBuffer(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9c690*/ void SetupRawColorDepthHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.RenderTextureDescriptor cameraTargetDescriptor);
                /*0x7c9c9c4*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c9cb48*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c9cf2c*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c9c2b0*/ void EnqueueDeferred(UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow);
                /*0x7c9b800*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera);
                /*0x7c9bc98*/ void CreateCameraRenderTarget(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9cf6c*/ bool PlatformRequiresExplicitMsaaResolve();
                /*0x7c9bac8*/ bool RequiresIntermediateColorTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7c98778*/ bool CanCopyDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9cfe0*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c9d19c*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c9d1b8*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c9d1d4*/ void EnableSwapBufferMSAA(bool enable);
                /*0x7c9d1f4*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x7c9d1fc*/ bool DebugHandlerRequireDepthPass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9d26c*/ void CreateDebugTexture(UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7c9d374*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, float width, float height);
                /*0x7c9d3ac*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, int textureHeightPercent);
                /*0x7c98540*/ void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight);
                /*0x7c9d404*/ void SetupRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c9de64*/ void SetupAfterPostRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c9db9c*/ void BlitToDebugTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool isSourceTextureColor);
                /*0x7c9e128*/ void BlitEmptyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, string passName);
                /*0x7c9e550*/ UnityEngine.Rendering.RTHandle get_currentRenderGraphCameraColorHandle();
                /*0x7c9e604*/ UnityEngine.Rendering.RTHandle get_nextRenderGraphCameraColorHandle();
                /*0x7c97f1c*/ void CleanupRenderGraphResources();
                /*0x7c9e91c*/ bool ShouldApplyPostProcessing(bool postProcessEnabled);
                /*0x7c9e934*/ bool CameraHasPostProcessingWithDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9e978*/ bool RequiresIntermediateAttachments(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7c9b744*/ void UpdateCameraHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c9ec34*/ void CreateRenderGraphCameraRenderTargets(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isCameraTargetOffscreenDepth);
                /*0x7ca08e8*/ void SetupRenderingLayers(int msaaSamples);
                /*0x7ca0964*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7ca09e8*/ void RenderRawColorDepthHistory(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7ca0eb0*/ void OnBeginRenderGraphFrame();
                /*0x7ca0f0c*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7ca32a0*/ void OnEndRenderGraphFrame();
                /*0x7ca32fc*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7ca336c*/ bool get_supportsGPUOcclusion();
                /*0x7ca11b8*/ void OnOffscreenDepthTextureRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7ca1568*/ void OnBeforeRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7ca3ae4*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture);
                /*0x7ca3e98*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.OcclusionTest occlusionTest);
                /*0x7ca4090*/ void RecordCustomPassesWithDepthCopyAndMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, UnityEngine.Rendering.Universal.RenderPassEvent currentEvent, bool renderMotionVectors);
                /*0x7ca417c*/ bool AllowPartialDepthNormalsPrepass(bool isDeferred, UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalEvent);
                /*0x7ca4190*/ UnityEngine.Rendering.Universal.UniversalRenderer.DepthCopySchedule CalculateDepthCopySchedule(UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass);
                /*0x7ca41e8*/ UnityEngine.Rendering.Universal.UniversalRenderer.TextureCopySchedules CalculateTextureCopySchedules(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass);
                /*0x7ca433c*/ void CopyDepthToDepthTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7ca43fc*/ void RenderMotionVectors(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7ca412c*/ void ExecuteScheduledDepthCopyWithMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, bool renderMotionVectors);
                /*0x7ca1818*/ void OnMainRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7ca2700*/ void OnAfterRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c9eaa0*/ bool RequireDepthPrepass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7c9eb4c*/ bool RequireDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool requiresDepthPrepass, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7ca4664*/ void SetRenderingLayersGlobalTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c9fee4*/ void CreateCameraDepthCopyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor, bool isDepthTexture);
                /*0x7ca02a4*/ void CreateMotionVectorTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7ca0070*/ void CreateCameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7ca04b8*/ void CreateRenderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7ca071c*/ void CreateAfterPostProcessTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7ca44a8*/ void DepthNormalPrepassRender(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                class Profiling
                {
                    static string k_Name = "UniversalRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler createCameraRenderTarget;

                    static /*0x7ca4ef0*/ Profiling();
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

                    /*0x7ca4f8c*/ CopyToDebugTexturePassData();
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
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__110_0;
                    static /*0x10*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__110_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.UniversalRenderer.CopyToDebugTexturePassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__139_0;
                    static /*0x20*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__194_0;

                    static /*0x7ca4f94*/ <>c();
                    /*0x7ca4ffc*/ <>c();
                    /*0x7ca5004*/ bool <Setup>b__110_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x7ca5024*/ bool <Setup>b__110_1(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x7ca5058*/ void <BlitEmptyTexture>b__139_0(UnityEngine.Rendering.Universal.UniversalRenderer.CopyToDebugTexturePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7ca5120*/ bool <OnAfterRendering>b__194_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
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

                /*0x7ca5140*/ RenderPathCompatibleAttribute(UnityEngine.Rendering.Universal.RenderPathCompatibility renderPath);
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

                static /*0x7ca5344*/ RenderGraphUtils();
                static /*0x7ca5168*/ void UseDBufferIfValid(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                static /*0x7ca485c*/ void SetGlobalTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, int nameId, UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, string passName, string file, int line);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle texture;
                    /*0x20*/ int nameID;

                    /*0x7ca53e0*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderGraphUtils.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderGraphUtils.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                    static /*0x7ca53e8*/ <>c();
                    /*0x7ca5450*/ <>c();
                    /*0x7ca5458*/ void <SetGlobalTexture>b__6_0(UnityEngine.Rendering.Universal.RenderGraphUtils.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class ClearTargetsPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_ClearProfilingSampler;

                static /*0x7ca5560*/ ClearTargetsPass();
                static /*0x7ca545c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7ca341c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color clearColor);
                /*0x7ca5558*/ ClearTargetsPass();

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                    /*0x30*/ UnityEngine.Rendering.RTClearFlags clearFlags;
                    /*0x34*/ UnityEngine.Color clearColor;

                    /*0x7ca55fc*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ClearTargetsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ClearTargetsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__3_0;

                    static /*0x7ca5604*/ <>c();
                    /*0x7ca566c*/ <>c();
                    /*0x7ca5674*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.ClearTargetsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                static /*0x7caf5a4*/ UniversalRenderPipeline();
                static /*0x7ca56a8*/ float get_maxShadowBias();
                static /*0x7ca56b0*/ float get_minRenderScale();
                static /*0x7ca56bc*/ float get_maxRenderScale();
                static /*0x7ca56c4*/ int get_maxNumIterationsEnclosingSphere();
                static /*0x7ca56cc*/ int get_maxPerObjectLights();
                static /*0x7c9ce20*/ int get_maxVisibleAdditionalLights();
                static /*0x7ca56d4*/ int get_lightsPerTile();
                static /*0x7ca5738*/ int get_maxZBinWords();
                static /*0x7ca5740*/ int get_maxTileWords();
                static /*0x7ca57a0*/ int get_maxVisibleReflectionProbes();
                static /*0x7ca5840*/ bool get_canOptimizeScreenMSAASamples();
                static /*0x7ca5898*/ void set_canOptimizeScreenMSAASamples(bool value);
                static /*0x7ca58f8*/ int get_startFrameScreenMSAASamples();
                static /*0x7ca5950*/ void set_startFrameScreenMSAASamples(int value);
                static /*0x7ca8d74*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x7ca8cb0*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x7ca8dd8*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, ref UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cab2f8*/ bool TryGetCullingParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                static /*0x7caa08c*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cacf10*/ void CreateShadowAtlasAndCullShadowCasters(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.ScriptableRenderContext context);
                static /*0x7ca73b0*/ void RenderCameraStack(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera baseCamera);
                static /*0x7cad698*/ void UpdateCameraData(UnityEngine.Rendering.Universal.UniversalCameraData baseCameraData, ref UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7ca89ac*/ void UpdateVolumeFramework(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cada34*/ bool CheckPostProcessForDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cad428*/ bool CheckPostProcessForDepth();
                static /*0x7ca626c*/ void SetSupportedRenderingFeatures(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset);
                static /*0x7ca91ec*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7ca92d4*/ UnityEngine.Rendering.Universal.UniversalCameraData CreateCameraData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget);
                static /*0x7cadac4*/ void InitializeStackedCameraData(UnityEngine.Camera baseCamera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData baseAdditionalCameraData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7ca9850*/ void InitializeAdditionalCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cacb80*/ UnityEngine.Rendering.Universal.UniversalRenderingData CreateRenderingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, UnityEngine.Rendering.CommandBuffer cmd, bool isForwardPlus, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x7cabc48*/ UnityEngine.Rendering.Universal.UniversalShadowData CreateShadowData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset, bool isForwardPlus);
                static /*0x7cae9a4*/ UnityEngine.Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset);
                static /*0x7cad148*/ void InitializeMainLightShadowResolution(UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x7cacaac*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData CreatePostProcessingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings);
                static /*0x7cab950*/ UnityEngine.Rendering.Universal.UniversalResourceData CreateUniversalResourceData(UnityEngine.Rendering.ContextContainer frameData);
                static /*0x7cab9a0*/ UnityEngine.Rendering.Universal.UniversalLightData CreateLightData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x7cae778*/ void ApplyTaaRenderingDebugOverrides(ref UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings);
                static /*0x7cae654*/ void UpdateTemporalAAData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cab83c*/ void UpdateTemporalAATargets(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cad4f4*/ void UpdateCameraStereoMatrices(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7cae840*/ UnityEngine.Rendering.PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus, bool reflectionProbeBlending);
                static /*0x7caea04*/ int GetMainLightIndex(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x7cab478*/ void SetupPerCameraShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x7caccec*/ void CheckAndApplyDebugSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7cae4b0*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter ResolveUpscalingFilterSelection(UnityEngine.Vector2 imageSize, float renderScale, UnityEngine.Rendering.Universal.UpscalingFilterSelection selection, bool enableRenderGraph);
                static /*0x7cad348*/ bool HDROutputForMainDisplayIsActive();
                static /*0x7caec6c*/ bool HDROutputForAnyDisplayIsActive();
                static /*0x7caed14*/ void GetHDROutputLuminanceParameters(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x7caee04*/ void GetHDROutputGradingParameters(UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x7cad1e0*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7ca6dd4*/ void AdjustUIOverlayOwnership(int cameraCount);
                static /*0x7ca6e7c*/ void SetupScreenMSAASamplesState(int cameraCount);
                static /*0x7ca72d4*/ bool IsGameCamera(UnityEngine.Camera camera);
                static /*0x7c97c20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset get_asset();
                static /*0x7c97cc0*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha);
                static /*0x7caeecc*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeUnormRenderTextureGraphicsFormat();
                static /*0x7cae218*/ UnityEngine.RenderTextureDescriptor CreateRenderTextureDescriptor(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture);
                static /*0x7caeef8*/ void GetLightAttenuationAndSpotDirection(UnityEngine.LightType lightType, float lightRange, UnityEngine.Matrix4x4 lightLocalToWorldMatrix, float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x7caf044*/ void GetPunctualLightDistanceAttenuation(float lightRange, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x7caf0b0*/ void GetSpotAngleAttenuation(float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x7caf07c*/ void GetSpotDirection(ref UnityEngine.Matrix4x4 lightLocalToWorldMatrix, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x7caf1b0*/ void InitializeLightConstants_Common(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel);
                static /*0x7caf580*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x7cad03c*/ void RecordAndExecuteRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, string cameraName);
                /*0x7ca59c4*/ UniversalRenderPipeline(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset);
                /*0x7ca5828*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures get_runtimeTextures();
                /*0x7ca5830*/ void set_runtimeTextures(UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures value);
                /*0x7ca5838*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();
                /*0x7ca59ac*/ string ToString();
                /*0x7ca62ec*/ void Dispose(bool disposing);
                /*0x7ca65e0*/ void DisposeAdditionalCameraData();
                /*0x7ca6698*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Camera[] cameras);
                /*0x7ca6730*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x3907c14*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
                /*0x3907c14*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
                /*0x7ca6f58*/ void SetupPerFrameShaderConstants();
                /*0x7ca6c90*/ void SetHDRState(System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x7ca7258*/ void SortCameras(System.Collections.Generic.List<UnityEngine.Camera> cameras);

                class CameraMetadataCache
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry> s_MetadataCache;
                    static /*0x8*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry k_NoAllocEntry;

                    static /*0x7caf924*/ CameraMetadataCache();
                    static /*0x7caf75c*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry GetCached(UnityEngine.Camera camera);

                    class CameraMetadataCacheEntry
                    {
                        /*0x10*/ string name;
                        /*0x18*/ UnityEngine.Rendering.ProfilingSampler sampler;

                        /*0x7caf91c*/ CameraMetadataCacheEntry();
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

                        static /*0x7cafa60*/ Pipeline();

                        class Renderer
                        {
                            static string k_Name = "ScriptableRenderer";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setupCullingParameters;
                            static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setup;

                            static /*0x7cafd94*/ Renderer();
                        }

                        class Context
                        {
                            static string k_Name = "ScriptableRenderContext";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler submit;

                            static /*0x7cafe70*/ Context();
                        }
                    }
                }

                struct CameraRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginCameraRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endCameraRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ UnityEngine.Camera m_Camera;

                    static /*0x7cb0118*/ CameraRenderingScope();
                    /*0x7caff0c*/ CameraRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x7cb0028*/ void Dispose();
                }

                struct ContextRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginContextRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endContextRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;

                    static /*0x7cb03f8*/ ContextRenderingScope();
                    /*0x7cb01f4*/ ContextRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                    /*0x7cb0308*/ void Dispose();
                }

                class SingleCameraRequest
                {
                    /*0x10*/ UnityEngine.RenderTexture destination;
                    /*0x18*/ int mipLevel;
                    /*0x1c*/ UnityEngine.CubemapFace face;
                    /*0x20*/ int slice;

                    /*0x7cb04d4*/ SingleCameraRequest();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Camera> <>9__47_0;

                    static /*0x7cb04e4*/ <>c();
                    /*0x7cb054c*/ <>c();
                    /*0x7cb0554*/ int <.ctor>b__47_0(UnityEngine.Camera camera1, UnityEngine.Camera camera2);
                    /*0x7cb05bc*/ void <.cctor>b__122_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }

            class NativeArrayExtensions
            {
                static /*0x3907c14*/ ref T UnsafeElementAt<T>(Unity.Collections.NativeArray<T> array, int index);
                static /*0x3907c14*/ ref T UnsafeElementAtMutable<T>(Unity.Collections.NativeArray<T> array, int index);
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

                /*0x7cb0888*/ RenderingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb0944*/ UnityEngine.Rendering.Universal.UniversalRenderingData get_universalRenderingData();
                /*0x7cb0994*/ ref UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x7cb0a40*/ ref UnityEngine.Rendering.CullingResults get_cullResults();
                /*0x7cb0a9c*/ ref bool get_supportsDynamicBatching();
                /*0x7cb0af8*/ ref UnityEngine.Rendering.PerObjectData get_perObjectData();
                /*0x7cb0b54*/ ref bool get_postProcessingEnabled();
            }

            struct LightData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cb0bb0*/ LightData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb0bb8*/ UnityEngine.Rendering.Universal.UniversalLightData get_universalLightData();
                /*0x7cb0c08*/ ref int get_mainLightIndex();
                /*0x7cb0c64*/ ref int get_additionalLightsCount();
                /*0x7cb0cc0*/ ref int get_maxPerObjectAdditionalLightsCount();
                /*0x7cb0d1c*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
                /*0x7cb0d78*/ ref bool get_shadeAdditionalLightsPerVertex();
                /*0x7cb0dd4*/ ref bool get_supportsMixedLighting();
                /*0x7cb0e30*/ ref bool get_reflectionProbeBoxProjection();
                /*0x7cb0e8c*/ ref bool get_reflectionProbeBlending();
                /*0x7cb0ee8*/ ref bool get_supportsLightLayers();
                /*0x7cb0f44*/ ref bool get_supportsAdditionalLights();
            }

            struct CameraData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cb0fa0*/ CameraData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb0fa8*/ UnityEngine.Rendering.Universal.UniversalCameraData get_universalCameraData();
                /*0x7cb0ff8*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x7cb10b8*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x7cb11a8*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7cb121c*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7cb12ac*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x7cb133c*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x7cb13cc*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x7cb145c*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x7cb14ec*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x7cb1584*/ ref UnityEngine.Camera get_camera();
                /*0x7cb15e0*/ ref UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7cb163c*/ ref UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x7cb1698*/ ref UnityEngine.RenderTexture get_targetTexture();
                /*0x7cb16f4*/ ref UnityEngine.RenderTextureDescriptor get_cameraTargetDescriptor();
                /*0x7cb1750*/ ref UnityEngine.Rect get_pixelRect();
                /*0x7cb17ac*/ ref bool get_useScreenCoordOverride();
                /*0x7cb1808*/ ref UnityEngine.Vector4 get_screenSizeOverride();
                /*0x7cb1864*/ ref UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x7cb18c0*/ ref int get_pixelWidth();
                /*0x7cb191c*/ ref int get_pixelHeight();
                /*0x7cb1978*/ ref float get_aspectRatio();
                /*0x7cb19d4*/ ref float get_renderScale();
                /*0x7cb1a30*/ ref UnityEngine.Rendering.Universal.ImageScalingMode get_imageScalingMode();
                /*0x7cb1a8c*/ ref UnityEngine.Rendering.Universal.ImageUpscalingFilter get_upscalingFilter();
                /*0x7cb1ae8*/ ref bool get_fsrOverrideSharpness();
                /*0x7cb1b44*/ ref float get_fsrSharpness();
                /*0x7cb1ba0*/ ref UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x7cb1bfc*/ ref bool get_clearDepth();
                /*0x7cb1c58*/ ref UnityEngine.CameraType get_cameraType();
                /*0x7cb1cb4*/ ref bool get_isDefaultViewport();
                /*0x7cb1d10*/ ref bool get_isHdrEnabled();
                /*0x7cb1d6c*/ ref bool get_allowHDROutput();
                /*0x7cb1dc8*/ ref bool get_isAlphaOutputEnabled();
                /*0x7cb1e24*/ ref bool get_requiresDepthTexture();
                /*0x7cb1e80*/ ref bool get_requiresOpaqueTexture();
                /*0x7cb1edc*/ ref bool get_postProcessingRequiresDepthTexture();
                /*0x7cb1f38*/ ref bool get_xrRendering();
                /*0x7cb1f94*/ bool get_requireSrgbConversion();
                /*0x7cb1ff0*/ bool get_isSceneViewCamera();
                /*0x7cb204c*/ bool get_isPreviewCamera();
                /*0x7cb20a8*/ bool get_isRenderPassSupportedCamera();
                /*0x7cb2104*/ bool get_resolveToScreen();
                /*0x7cb2160*/ bool get_isHDROutputActive();
                /*0x7cb21bc*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x7cb2218*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x7cb2274*/ bool get_rendersOverlayUI();
                /*0x7cb22d0*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x7cb2334*/ bool IsCameraProjectionMatrixFlipped();
                /*0x7cb2390*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7cb2404*/ bool IsTemporalAAEnabled();
                /*0x7cb2460*/ ref UnityEngine.Rendering.SortingCriteria get_defaultOpaqueSortFlags();
                /*0x7cb24bc*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x7cb2518*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x7cb2584*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x7cb25e0*/ ref float get_maxShadowDistance();
                /*0x7cb263c*/ ref bool get_postProcessEnabled();
                /*0x7cb2698*/ ref System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> get_captureActions();
                /*0x7cb26f4*/ ref UnityEngine.LayerMask get_volumeLayerMask();
                /*0x7cb2750*/ ref UnityEngine.Transform get_volumeTrigger();
                /*0x7cb27ac*/ ref bool get_isStopNaNEnabled();
                /*0x7cb2808*/ ref bool get_isDitheringEnabled();
                /*0x7cb2864*/ ref UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x7cb28c0*/ ref UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x7cb291c*/ ref UnityEngine.Rendering.Universal.ScriptableRenderer get_renderer();
                /*0x7cb2978*/ ref bool get_resolveFinalTarget();
                /*0x7cb29d4*/ ref UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x7cb2a30*/ ref UnityEngine.Color get_backgroundColor();
                /*0x7cb2a8c*/ ref UnityEngine.Rendering.Universal.TaaHistory get_taaHistory();
                /*0x7cb2ae8*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x7cb2b44*/ bool get_resetHistory();
                /*0x7cb2ba0*/ ref UnityEngine.Camera get_baseCamera();
            }

            struct ShadowData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cb2bfc*/ ShadowData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb2c04*/ UnityEngine.Rendering.Universal.UniversalShadowData get_universalShadowData();
                /*0x7cb2c54*/ ref bool get_supportsMainLightShadows();
                /*0x7cb2cb0*/ ref bool get_mainLightShadowsEnabled();
                /*0x7cb2d0c*/ ref int get_mainLightShadowmapWidth();
                /*0x7cb2d68*/ ref int get_mainLightShadowmapHeight();
                /*0x7cb2dc4*/ ref int get_mainLightShadowCascadesCount();
                /*0x7cb2e20*/ ref UnityEngine.Vector3 get_mainLightShadowCascadesSplit();
                /*0x7cb2e7c*/ ref float get_mainLightShadowCascadeBorder();
                /*0x7cb2ed8*/ ref bool get_supportsAdditionalLightShadows();
                /*0x7cb2f34*/ ref bool get_additionalLightShadowsEnabled();
                /*0x7cb2f90*/ ref int get_additionalLightsShadowmapWidth();
                /*0x7cb2fec*/ ref int get_additionalLightsShadowmapHeight();
                /*0x7cb3048*/ ref bool get_supportsSoftShadows();
                /*0x7cb30a4*/ ref int get_shadowmapDepthBufferBits();
                /*0x7cb3100*/ ref System.Collections.Generic.List<UnityEngine.Vector4> get_bias();
                /*0x7cb315c*/ ref System.Collections.Generic.List<int> get_resolution();
                /*0x7cb31b8*/ ref bool get_isKeywordAdditionalLightShadowsEnabled();
                /*0x7cb3214*/ ref bool get_isKeywordSoftShadowsEnabled();
                /*0x7cb3270*/ ref int get_mainLightShadowResolution();
                /*0x7cb32cc*/ ref int get_mainLightRenderTargetWidth();
                /*0x7cb3328*/ ref int get_mainLightRenderTargetHeight();
                /*0x7cb3384*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> get_visibleLightsShadowCullingInfos();
                /*0x7cb33e0*/ ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout get_shadowAtlasLayout();
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
                static /*0xac*/ int previousViewProjectionNoJitterStereo;
                static /*0xb0*/ int viewProjectionNoJitterStereo;
                static /*0xb4*/ int blitTexture;
                static /*0xb8*/ int blitScaleBias;
                static /*0xbc*/ int sourceTex;
                static /*0xc0*/ int scaleBias;
                static /*0xc4*/ int scaleBiasRt;
                static /*0xc8*/ int rtHandleScale;
                static /*0xcc*/ int rendererColor;
                static /*0xd0*/ int ditheringTexture;
                static /*0xd4*/ int ditheringTextureInvSize;
                static /*0xd8*/ int renderingLayerMaxInt;
                static /*0xdc*/ int renderingLayerRcpMaxInt;
                static /*0xe0*/ int overlayUITexture;
                static /*0xe4*/ int hdrOutputLuminanceParams;
                static /*0xe8*/ int hdrOutputGradingParams;

                static /*0x7cb343c*/ ShaderPropertyId();
            }

            struct PostProcessingData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cb3ebc*/ PostProcessingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb3ec4*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData get_universalPostProcessingData();
                /*0x7cb3f14*/ ref UnityEngine.Rendering.Universal.ColorGradingMode get_gradingMode();
                /*0x7cb3f70*/ ref int get_lutSize();
                /*0x7cb3fcc*/ ref bool get_useFastSRGBLinearConversion();
                /*0x7cb4028*/ ref bool get_supportScreenSpaceLensFlare();
                /*0x7cb4084*/ ref bool get_supportDataDrivenLensFlare();
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

                static /*0x7cb40e0*/ void InitializeShaderGlobalKeywords();
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
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.XR.XRDisplaySubsystem> displaySubsystemList;
                static /*0x8*/ bool <isXRMobile>k__BackingField;
                static /*0x9*/ bool <isShaderAPIMobileDefined>k__BackingField;
                static /*0xa*/ bool <isSwitch>k__BackingField;
                static /*0xb*/ bool isRunningOnPowerVRGPU;

                static /*0x7cb5a4c*/ PlatformAutoDetect();
                static /*0x7cb53f8*/ void Initialize();
                static /*0x7cb5574*/ bool IsRunningXRMobile();
                static /*0x7cb56e4*/ bool get_isXRMobile();
                static /*0x7cb573c*/ void set_isXRMobile(bool value);
                static /*0x7cb579c*/ bool get_isShaderAPIMobileDefined();
                static /*0x7cb57f4*/ void set_isShaderAPIMobileDefined(bool value);
                static /*0x7cb5854*/ bool get_isSwitch();
                static /*0x7cb58ac*/ void set_isSwitch(bool value);
                static /*0x7cb590c*/ UnityEngine.Rendering.Universal.ShEvalMode ShAutoDetect(UnityEngine.Rendering.Universal.ShEvalMode mode);
            }

            class VolumeRequiresRendererFeatures : System.Attribute
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> TargetFeatureTypes;

                /*0x7cb5b38*/ VolumeRequiresRendererFeatures(System.Type[] featureTypes);
            }

            class XRPassUniversal : UnityEngine.Experimental.Rendering.XRPass
            {
                /*0x734*/ bool <isLateLatchEnabled>k__BackingField;
                /*0x735*/ bool <canMarkLateLatch>k__BackingField;
                /*0x736*/ bool <hasMarkedLateLatch>k__BackingField;
                /*0x737*/ bool <canFoveateIntermediatePasses>k__BackingField;

                static /*0x7cb5c28*/ UnityEngine.Experimental.Rendering.XRPass Create(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7cb5dd0*/ XRPassUniversal();
                /*0x7cb5d14*/ void Release();
                /*0x7cb5d80*/ bool get_isLateLatchEnabled();
                /*0x7cb5d88*/ void set_isLateLatchEnabled(bool value);
                /*0x7cb5d94*/ bool get_canMarkLateLatch();
                /*0x7cb5d9c*/ void set_canMarkLateLatch(bool value);
                /*0x7cb5da8*/ bool get_hasMarkedLateLatch();
                /*0x7cb5db0*/ void set_hasMarkedLateLatch(bool value);
                /*0x7cb5dbc*/ bool get_canFoveateIntermediatePasses();
                /*0x7cb5dc4*/ void set_canFoveateIntermediatePasses(bool value);
            }

            class XRSystemUniversal
            {
                static /*0x0*/ UnityEngine.Matrix4x4[] s_projMatrix;

                static /*0x7cb61cc*/ XRSystemUniversal();
                static /*0x7cb5dd8*/ void BeginLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7cb5ea8*/ void EndLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7cb5f64*/ void UnmarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7cb5fe0*/ void MarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass, bool renderIntoTexture);
            }

            namespace Internal
            {
                class DeferredConfig
                {
                    static /*0x0*/ bool <IsOpenGL>k__BackingField;
                    static /*0x1*/ bool <IsDX10>k__BackingField;

                    static /*0x7cb6240*/ bool get_IsOpenGL();
                    static /*0x7cb6288*/ void set_IsOpenGL(bool value);
                    static /*0x7cb62d8*/ bool get_IsDX10();
                    static /*0x7cb6320*/ void set_IsDX10(bool value);
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

                    static /*0x7cbc228*/ DeferredLights();
                    static /*0x7cb87b0*/ UnityEngine.Rendering.StencilState OverwriteStencil(UnityEngine.Rendering.StencilState s, int stencilWriteMask);
                    static /*0x7cb8964*/ UnityEngine.Rendering.RenderStateBlock OverwriteStencil(UnityEngine.Rendering.RenderStateBlock block, int stencilWriteMask, int stencilRef);
                    static /*0x7cbb69c*/ UnityEngine.Mesh CreateSphereMesh();
                    static /*0x7cbbc80*/ UnityEngine.Mesh CreateHemisphereMesh();
                    static /*0x7cb8dac*/ UnityEngine.Mesh CreateFullscreenMesh();
                    /*0x7cb67c8*/ DeferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights.InitParams initParams, bool useNativeRenderPass);
                    /*0x7cb6370*/ int get_GBufferAlbedoIndex();
                    /*0x7cb6378*/ int get_GBufferSpecularMetallicIndex();
                    /*0x7cb6380*/ int get_GBufferNormalSmoothnessIndex();
                    /*0x7cb6388*/ int get_GBufferLightingIndex();
                    /*0x7cb6390*/ int get_GbufferDepthIndex();
                    /*0x7cb63a4*/ int get_GBufferRenderingLayers();
                    /*0x7cb6408*/ int get_GBufferShadowMask();
                    /*0x7cb6470*/ int get_GBufferSliceCount();
                    /*0x7cb64bc*/ int get_GBufferInputAttachmentCount();
                    /*0x7cb64d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGBufferFormat(int index);
                    /*0x7cb6460*/ bool get_UseShadowMask();
                    /*0x7cb63dc*/ bool get_UseRenderingLayers();
                    /*0x7cb6668*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_RenderingLayerMaskSize();
                    /*0x7cb6670*/ void set_RenderingLayerMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x7cb6678*/ bool get_UseDecalLayers();
                    /*0x7cb6680*/ void set_UseDecalLayers(bool value);
                    /*0x7cb6608*/ bool get_UseLightLayers();
                    /*0x7cb668c*/ bool get_UseFramebufferFetch();
                    /*0x7cb6694*/ void set_UseFramebufferFetch(bool value);
                    /*0x7cb66a0*/ bool get_HasDepthPrepass();
                    /*0x7cb66a8*/ void set_HasDepthPrepass(bool value);
                    /*0x7cb66b4*/ bool get_HasNormalPrepass();
                    /*0x7cb66bc*/ void set_HasNormalPrepass(bool value);
                    /*0x7cb66c8*/ bool get_HasRenderingLayerPrepass();
                    /*0x7cb66d0*/ void set_HasRenderingLayerPrepass(bool value);
                    /*0x7cb66dc*/ bool get_IsOverlay();
                    /*0x7cb66e4*/ void set_IsOverlay(bool value);
                    /*0x7cb66f0*/ bool get_AccurateGbufferNormals();
                    /*0x7cb66f8*/ void set_AccurateGbufferNormals(bool value);
                    /*0x7cb6704*/ UnityEngine.Rendering.Universal.MixedLightingSetup get_MixedLightingSetup();
                    /*0x7cb670c*/ void set_MixedLightingSetup(UnityEngine.Rendering.Universal.MixedLightingSetup value);
                    /*0x7cb6714*/ bool get_UseJobSystem();
                    /*0x7cb671c*/ void set_UseJobSystem(bool value);
                    /*0x7cb6728*/ int get_RenderWidth();
                    /*0x7cb6730*/ void set_RenderWidth(int value);
                    /*0x7cb6738*/ int get_RenderHeight();
                    /*0x7cb6740*/ void set_RenderHeight(int value);
                    /*0x7cb6748*/ UnityEngine.Rendering.RTHandle[] get_GbufferAttachments();
                    /*0x7cb6750*/ void set_GbufferAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x7cb6758*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_GbufferTextureHandles();
                    /*0x7cb6760*/ void set_GbufferTextureHandles(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0x7cb6768*/ UnityEngine.Rendering.RTHandle[] get_DeferredInputAttachments();
                    /*0x7cb6770*/ void set_DeferredInputAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x7cb6778*/ bool[] get_DeferredInputIsTransient();
                    /*0x7cb6780*/ void set_DeferredInputIsTransient(bool[] value);
                    /*0x7cb6788*/ UnityEngine.Rendering.RTHandle get_DepthAttachment();
                    /*0x7cb6790*/ void set_DepthAttachment(UnityEngine.Rendering.RTHandle value);
                    /*0x7cb6798*/ UnityEngine.Rendering.RTHandle get_DepthCopyTexture();
                    /*0x7cb67a0*/ void set_DepthCopyTexture(UnityEngine.Rendering.RTHandle value);
                    /*0x7cb67a8*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_GbufferFormats();
                    /*0x7cb67b0*/ void set_GbufferFormats(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                    /*0x7cb67b8*/ UnityEngine.Rendering.RTHandle get_DepthAttachmentHandle();
                    /*0x7cb67c0*/ void set_DepthAttachmentHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7cb6e24*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cb7244*/ void SetupLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool isRenderGraph);
                    /*0x7cb7994*/ void ResolveMixedLightingMode(UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cb7e0c*/ void DisableFramebufferFetchInput();
                    /*0x7cb7e14*/ void ReleaseGbufferResources();
                    /*0x7cb7ea0*/ void ReAllocateGBufferIfNeeded(UnityEngine.RenderTextureDescriptor gbufferSlice, int gbufferIndex);
                    /*0x7cb7b0c*/ void CreateGbufferResources();
                    /*0x7cb8088*/ void UpdateDeferredInputAttachments();
                    /*0x7cb83bc*/ bool IsRuntimeSupportedThisFrame();
                    /*0x7cb8458*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, UnityEngine.Rendering.RTHandle depthCopyTexture, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RTHandle colorAttachment);
                    /*0x7cb86f0*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass);
                    /*0x7cb86f8*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cb8bcc*/ void ClearStencilPartial(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x7cb8ef8*/ void ExecuteDeferredPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cb7990*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cb9d54*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cb92b0*/ void SetupMatrixConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x7cb7678*/ void PrecomputeLights(ref Unity.Collections.NativeArray<ushort> stencilVisLights, ref Unity.Collections.NativeArray<ushort> stencilVisLightOffsets, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLights);
                    /*0x7cb965c*/ bool HasStencilLightsOfType(UnityEngine.LightType type);
                    /*0x7cb9820*/ void RenderStencilLights(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, bool stripShadowsOffVariants);
                    /*0x7cb9f78*/ void RenderStencilDirectionalLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex);
                    /*0x7cba598*/ void RenderStencilPointLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x7cbac10*/ void RenderStencilSpotLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x7cb96d4*/ void RenderSSAOBeforeShading(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x7cb9b60*/ void RenderFog(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isOrthographic);
                    /*0x7cb6a64*/ void InitStencilDeferredMaterial();
                    /*0x7cb9f28*/ void SetRenderingLayersMask(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Light light, int shaderPropertyID);
                    /*0x7cbb508*/ void SetAdditionalLightsShadowsKeyword(ref UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword);
                    /*0x7cbb5bc*/ void SetSoftShadowsKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow);
                    /*0x7cbb3cc*/ void SetLightCookiesKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex);

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

                        static /*0x7cbc9ac*/ ShaderConstants();
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

                        /*0x7cbd0e8*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__139_0;

                        static /*0x7cbd0f0*/ <>c();
                        /*0x7cbd158*/ <>c();
                        /*0x7cbd160*/ void <SetupRenderGraphLights>b__139_0(UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
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
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_AdditionalLightsShadowmapHandle;
                    /*0xc0*/ int renderTargetWidth;
                    /*0xc4*/ int renderTargetHeight;
                    /*0xc8*/ bool m_CreateEmptyShadowmap;
                    /*0xc9*/ bool m_EmptyShadowmapNeedsClear;
                    /*0xca*/ bool m_IssuedMessageAboutShadowSlicesTooMany;
                    /*0xcb*/ bool m_IssuedMessageAboutShadowMapsRescale;
                    /*0xcc*/ bool m_IssuedMessageAboutShadowMapsTooBig;
                    /*0xcd*/ bool m_IssuedMessageAboutRemovedShadowSlices;
                    /*0xce*/ bool m_UseStructuredBuffer;
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

                    static /*0x7cc1d44*/ AdditionalLightsShadowCasterPass();
                    static /*0x7cbd738*/ float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels);
                    static /*0x7cbd7a8*/ float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering);
                    static /*0x7cc0234*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x7cbd1e4*/ AdditionalLightsShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x7cbd704*/ void Dispose();
                    /*0x7cbda50*/ ulong ResolutionLog2ForHash(int resolution);
                    /*0x7cbda9c*/ ulong ComputeShadowRequestHash(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cbdd84*/ float GetLightTypeIdentifierForShadowParams(UnityEngine.LightType lightType);
                    /*0x7cbdda4*/ bool UsesBakedShadows(UnityEngine.Light light);
                    /*0x7cbdddc*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cbdec0*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cbfd28*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x7cbf8a8*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cbfdd4*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cbff2c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cbb364*/ int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
                    /*0x7cbfcb8*/ void Clear();
                    /*0x7cc0744*/ void RenderAdditionalShadowmapAtlas(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, bool useRenderGraph);
                    /*0x7cc10d0*/ void SetupAdditionalLightsShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows);
                    /*0x7cc03f8*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cc04e4*/ void InitRendererLists(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7cc13c0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

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

                        static /*0x7cc1d94*/ AdditionalShadowsConstantBuffer();
                    }

                    class PassData
                    {
                        /*0x10*/ int shadowmapID;
                        /*0x14*/ bool emptyShadowmap;
                        /*0x15*/ bool useStructuredBuffer;
                        /*0x16*/ bool stripShadowsOffVariants;
                        /*0x18*/ UnityEngine.Matrix4x4 viewMatrix;
                        /*0x58*/ UnityEngine.Vector2Int allocatedShadowAtlasSize;
                        /*0x60*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x70*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x78*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x80*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass pass;
                        /*0x88*/ UnityEngine.Rendering.RendererList[] shadowRendererLists;
                        /*0x90*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle[] shadowRendererListsHdl;

                        /*0x7cbd668*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__61_0;

                        static /*0x7cc1f7c*/ <>c();
                        /*0x7cc1fe4*/ <>c();
                        /*0x7cc1fec*/ void <Render>b__61_0(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cc59b4*/ ForwardLights();
                    static /*0x7cc271c*/ int AlignByteCount(int count, int align);
                    static /*0x7cc3c30*/ bool <PreSetup>g__IsProbeGreater|40_0(UnityEngine.Rendering.VisibleReflectionProbe probe, UnityEngine.Rendering.VisibleReflectionProbe otherProbe);
                    /*0x7cc20b8*/ ForwardLights();
                    /*0x7cc20e4*/ ForwardLights(UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams initParams);
                    /*0x7cc2530*/ void CreateForwardPlusBuffers();
                    /*0x7cc270c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager get_reflectionProbeManager();
                    /*0x7cc2730*/ void GetViewParams(UnityEngine.Camera camera, Unity.Mathematics.float4x4 viewToClip, ref float viewPlaneBot, ref float viewPlaneTop, ref Unity.Mathematics.float4 viewToViewportScaleBias);
                    /*0x7cc288c*/ void PreSetup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc3d10*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cc4960*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc3e1c*/ void SetupLights(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc4dd8*/ void Cleanup();
                    /*0x7cc4ea4*/ void InitializeLightConstants(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, bool supportsLightLayers, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel, ref uint lightLayerMask, ref bool isSubtractive);
                    /*0x7cc4d90*/ void SetupShaderLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc50a0*/ void SetupMainLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc51f4*/ void SetupAdditionalLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cc5738*/ int SetupPerObjectLightIndices(UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);

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

                        static /*0x7cc5b60*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams Create();
                    }

                    class SetupLightPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.ForwardLights forwardLights;

                        /*0x7cc5c8c*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__44_0;

                        static /*0x7cc5c94*/ <>c();
                        /*0x7cc5cfc*/ <>c();
                        /*0x7cc5d04*/ void <SetupRenderGraphLights>b__44_0(UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    }
                }

                class NormalReconstruction
                {
                    static /*0x0*/ int s_NormalReconstructionMatrixID;
                    static /*0x8*/ UnityEngine.Matrix4x4[] s_NormalReconstructionMatrix;

                    static /*0x7cc61f0*/ NormalReconstruction();
                    static /*0x7cc5d38*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x7cc5dd4*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x7cc6150*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    static /*0x7cc5e68*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
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

                    static /*0x7cc6888*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData passData, UnityEngine.Rendering.RTHandle internalLutTarget);
                    static /*0x7cc64b8*/ UnityEngine.Material <.ctor>g__Load|7_0(UnityEngine.Shader shader);
                    /*0x7cc6294*/ ColorGradingLutPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x7cc65a4*/ void Setup(ref UnityEngine.Rendering.RTHandle internalLut);
                    /*0x7cc65b0*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x7cc6608*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x7cc6698*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cc7b0c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle internalColorLut);
                    /*0x7cc80e8*/ void Cleanup();

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData;
                        /*0x20*/ UnityEngine.Material lutBuilderLdr;
                        /*0x28*/ UnityEngine.Material lutBuilderHdr;
                        /*0x30*/ bool allowColorGradingACESHDR;
                        /*0x34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle internalLut;

                        /*0x7cc659c*/ PassData();
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

                        static /*0x7cc8150*/ ShaderConstants();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;

                        static /*0x7cc85cc*/ <>c();
                        /*0x7cc8634*/ <>c();
                        /*0x7cc863c*/ void <Render>b__14_0(UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cc8870*/ void ConfigureDescriptor(UnityEngine.Rendering.Universal.Downsampling downsamplingMethod, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    static /*0x7cc8bd4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData passData, UnityEngine.Rendering.RTHandle source, bool useDrawProceduralBlit);
                    /*0x7cc86e4*/ CopyColorPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material samplingMaterial, UnityEngine.Material copyColorMaterial, string customPassName);
                    /*0x7cc86c4*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x7cc86cc*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x7cc86d4*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7cc86dc*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7cc88c4*/ void Setup(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cc8910*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cc894c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cc89ac*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cc8fb4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cc97dc*/ void RenderToExistingTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cc914c*/ void RenderInternal(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool useProceduralBlit);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ bool useProceduralBlit;
                        /*0x38*/ UnityEngine.Material samplingMaterial;
                        /*0x40*/ UnityEngine.Material copyColorMaterial;
                        /*0x48*/ UnityEngine.Rendering.Universal.Downsampling downsamplingMethod;
                        /*0x4c*/ int sampleOffsetShaderHandle;

                        /*0x7cc8868*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;

                        static /*0x7cc9880*/ <>c();
                        /*0x7cc98e8*/ <>c();
                        /*0x7cc98f0*/ void <RenderInternal>b__23_0(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cc9ec8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData passData, UnityEngine.Rendering.RTHandle source);
                    /*0x7cc99e4*/ CopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth, string customPassName);
                    /*0x7cc9978*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x7cc9980*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x7cc9988*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7cc9990*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7cc9998*/ int get_MssaSamples();
                    /*0x7cc99a0*/ void set_MssaSamples(int value);
                    /*0x7cc99a8*/ bool get_CopyToDepth();
                    /*0x7cc99b0*/ void set_CopyToDepth(bool value);
                    /*0x7cc99bc*/ bool get_CopyToDepthXR();
                    /*0x7cc99c4*/ void set_CopyToDepthXR(bool value);
                    /*0x7cc99d0*/ bool get_CopyToBackbuffer();
                    /*0x7cc99d8*/ void set_CopyToBackbuffer(bool value);
                    /*0x7cc9be8*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                    /*0x7cc9c24*/ void Dispose();
                    /*0x7cc9c80*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cc9cc8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cca514*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cca5c8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool bindAsCameraDepth, string passName);
                    /*0x7cca6b8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool bindAsCameraDepth, string passName);

                    class ShaderConstants
                    {
                        static /*0x0*/ int _CameraDepthAttachment;
                        static /*0x4*/ int _CameraDepthTexture;
                        static /*0x8*/ int _ZWriteShaderHandle;

                        static /*0x7ccafa8*/ ShaderConstants();
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

                        /*0x7cc9be0*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__38_0;

                        static /*0x7ccb070*/ <>c();
                        /*0x7ccb0d8*/ <>c();
                        /*0x7ccb0e0*/ void <Render>b__38_0(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DeferredPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                    /*0x7ccb164*/ DeferredPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x7ccb230*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescripor);
                    /*0x7ccb2b0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ccb3cc*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer);
                    /*0x7ccbbd4*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x50*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;

                        /*0x7ccbbf0*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__5_0;

                        static /*0x7ccbbf8*/ <>c();
                        /*0x7ccbc60*/ <>c();
                        /*0x7ccbc68*/ void <Render>b__5_0(UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7ccd1a0*/ DepthNormalOnlyPass();
                    static /*0x7ccbea0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat();
                    static /*0x7ccc168*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                    /*0x7ccbcfc*/ DepthNormalOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x7ccbc98*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> get_shaderTagIds();
                    /*0x7ccbca0*/ void set_shaderTagIds(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> value);
                    /*0x7ccbca8*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                    /*0x7ccbcb0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccbcb8*/ UnityEngine.Rendering.RTHandle get_normalHandle();
                    /*0x7ccbcc0*/ void set_normalHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccbcc8*/ UnityEngine.Rendering.RTHandle get_renderingLayersHandle();
                    /*0x7ccbcd0*/ void set_renderingLayersHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccbcd8*/ bool get_enableRenderingLayers();
                    /*0x7ccbce0*/ void set_enableRenderingLayers(bool value);
                    /*0x7ccbcec*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_renderingLayersMaskSize();
                    /*0x7ccbcf4*/ void set_renderingLayersMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x7ccbeec*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle);
                    /*0x7ccbf24*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle, UnityEngine.Rendering.RTHandle decalLayerHandle);
                    /*0x7ccbf78*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ccc264*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ccc690*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7ccc518*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7ccc774*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;
                        /*0x30*/ bool enableRenderingLayers;
                        /*0x34*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x7ccbe98*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__42_0;

                        static /*0x7ccd440*/ <>c();
                        /*0x7ccd4a8*/ <>c();
                        /*0x7ccd4b0*/ void <Render>b__42_0(UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cce4a8*/ DepthOnlyPass();
                    static /*0x7ccd874*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
                    /*0x7ccd588*/ DepthOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x7ccd568*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7ccd570*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccd578*/ UnityEngine.Rendering.ShaderTagId get_shaderTagId();
                    /*0x7ccd580*/ void set_shaderTagId(UnityEngine.Rendering.ShaderTagId value);
                    /*0x7ccd758*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle depthAttachmentHandle);
                    /*0x7ccd78c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ccd994*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ccdba0*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7ccdd18*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, uint batchLayerMask, bool setGlobalDepth);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x7ccd750*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__20_0;

                        static /*0x7cce550*/ <>c();
                        /*0x7cce5b8*/ <>c();
                        /*0x7cce5c0*/ void <Render>b__20_0(UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cd0388*/ DrawObjectsPass();
                    static /*0x7ccf348*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList objectsWithErrorRendererList, bool yFlip);
                    /*0x7cce664*/ DrawObjectsPass(string profilerTag, UnityEngine.Rendering.ShaderTagId[] shaderTagIds, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7cceadc*/ DrawObjectsPass(string profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7cceb20*/ DrawObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7cce7b4*/ void Init(bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.ShaderTagId[] shaderTagIds);
                    /*0x7ccec6c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cceeec*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer);
                    /*0x7ccef54*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7ccf584*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, uint batchLayerMask);

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

                        /*0x7ccec64*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x7cd03f0*/ <>c();
                        /*0x7cd0458*/ <>c();
                        /*0x7cd0460*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DrawObjectsWithRenderingLayersPass : UnityEngine.Rendering.Universal.Internal.DrawObjectsPass
                {
                    /*0x160*/ UnityEngine.Rendering.RTHandle[] m_ColorTargetIndentifiers;
                    /*0x168*/ UnityEngine.Rendering.RTHandle m_DepthTargetIndentifiers;

                    /*0x7cd05b4*/ DrawObjectsWithRenderingLayersPass(UnityEngine.Rendering.Universal.URPProfileId profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7cd06a0*/ void Setup(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle renderingLayersTexture, UnityEngine.Rendering.RTHandle depthAttachment);
                    /*0x7cd0820*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cd082c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd08d8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize, uint batchLayerMask);

                    class RenderingLayersPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData basePassData;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;

                        /*0x7cd1628*/ RenderingLayersPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                        static /*0x7cd1694*/ <>c();
                        /*0x7cd16fc*/ <>c();
                        /*0x7cd1704*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class FinalBlitPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraDepthTextureID;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_Source;
                    /*0xc0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData m_PassData;
                    /*0xc8*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData[] m_BlitMaterialData;

                    static /*0x7cd3544*/ FinalBlitPass();
                    static /*0x7cd1b80*/ void SetupHDROutput(UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperation, UnityEngine.Vector4 hdrOutputParameters, bool rendersOverlayUI);
                    static /*0x7cd28b8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x7cd18e0*/ FinalBlitPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial, UnityEngine.Material blitHDRMaterial);
                    /*0x7cd1b24*/ void Dispose();
                    /*0x7cd1b28*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                    /*0x7cd1b74*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle colorHandle);
                    /*0x7cd1c98*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd1d7c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd2810*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData passData, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitType blitType, bool enableAlphaOutput);
                    /*0x7cd2b64*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle src, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dest, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture);

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

                        /*0x7cd1b1c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x7cd35ac*/ <>c();
                        /*0x7cd3614*/ <>c();
                        /*0x7cd361c*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cd56d8*/ GBufferPass();
                    static /*0x7cd49b4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList errorRendererList);
                    /*0x7cd39d0*/ GBufferPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x7cd3fe4*/ void Dispose();
                    /*0x7cd3ff8*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cd42f4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd4630*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool useRenderGraph);
                    /*0x7cd4adc*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;
                        /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                        /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objectsWithErrorRendererListHdl;
                        /*0x48*/ UnityEngine.Rendering.RendererList rendererList;
                        /*0x60*/ UnityEngine.Rendering.RendererList objectsWithErrorRendererList;

                        /*0x7cd3fdc*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__21_0;

                        static /*0x7cd58e4*/ <>c();
                        /*0x7cd594c*/ <>c();
                        /*0x7cd5954*/ void <Render>b__21_0(UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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
                    /*0xcd*/ bool m_EmptyShadowmapNeedsClear;
                    /*0xd0*/ float m_CascadeBorder;
                    /*0xd4*/ float m_MaxShadowDistanceSq;
                    /*0xd8*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData m_PassData;
                    /*0xe0*/ UnityEngine.Rendering.RTHandle m_EmptyMainLightShadowmapTexture;
                    /*0xe8*/ UnityEngine.RenderTextureDescriptor m_MainLightShadowDescriptor;
                    /*0x120*/ UnityEngine.Vector4[] m_CascadeSplitDistances;
                    /*0x128*/ UnityEngine.Matrix4x4[] m_MainLightShadowMatrices;
                    /*0x130*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;
                    /*0x138*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_CascadeSlices;

                    static /*0x7cd82e8*/ MainLightShadowCasterPass();
                    static /*0x7cd6a34*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x7cd5a10*/ MainLightShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x7cd5c88*/ void Dispose();
                    /*0x7cd5cbc*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd5da0*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd6558*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x7cd6264*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, UnityEngine.Light light, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd6604*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cd675c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd6410*/ void Clear();
                    /*0x7cd6de4*/ void RenderMainLightCascadeShadowmap(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, bool isRenderGraph);
                    /*0x7cd748c*/ void SetupMainLightShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd6b0c*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd6bb8*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7cd79b0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

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

                        static /*0x7cd8348*/ MainLightShadowConstantBuffer();
                    }

                    class PassData
                    {
                        /*0x10*/ bool emptyShadowmap;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x28*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x30*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x38*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass pass;
                        /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x50*/ UnityEngine.Rendering.RendererList[] shadowRendererLists;
                        /*0x58*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle[] shadowRendererListsHandle;

                        /*0x7cd5bec*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__38_0;

                        static /*0x7cd8588*/ <>c();
                        /*0x7cd85f0*/ <>c();
                        /*0x7cd85f8*/ void <Render>b__38_0(UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cd8e34*/ RenderTargetBufferSystem();
                    /*0x7cd8798*/ RenderTargetBufferSystem(string name);
                    /*0x7cd86c0*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_backBuffer();
                    /*0x7cd872c*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_frontBuffer();
                    /*0x7cd8848*/ void Dispose();
                    /*0x7cd889c*/ UnityEngine.Rendering.RTHandle PeekBackBuffer();
                    /*0x7cd88e4*/ UnityEngine.Rendering.RTHandle GetBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cd8b44*/ UnityEngine.Rendering.RTHandle GetFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cd8bd0*/ void Swap();
                    /*0x7cd88fc*/ void ReAllocate(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cd8c30*/ void Clear();
                    /*0x7cd8cac*/ void SetCameraSettings(UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x7cd8e0c*/ UnityEngine.Rendering.RTHandle GetBufferA();
                    /*0x7cd8d90*/ void EnableMSAA(bool enable);

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
    static /*0x28*/ <PrivateImplementationDetails> 2F3098FBF1A569BA2FF640E404CC08AA80B09AD71BBEFF74C94AD2A9F83A36A0;
    static /*0x4b0a*/ <PrivateImplementationDetails> 4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D;
    static /*0x4b16*/ <PrivateImplementationDetails> 6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64;
    static /*0x4ed6*/ <PrivateImplementationDetails> 888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1;
    static /*0x4ee6*/ <PrivateImplementationDetails> 9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD;
    static /*0x4ef2*/ <PrivateImplementationDetails> B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;
    static /*0x4efe*/ <PrivateImplementationDetails> BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE;
    static /*0x4f0e*/ <PrivateImplementationDetails> C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101;
    static /*0x4f1e*/ <PrivateImplementationDetails> E158C3048949734DCC78A79A3CD152853CF8E43528A81241BB0392FE5781F4D3;
    static /*0xada5*/ <PrivateImplementationDetails> E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01;

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

    struct __StaticArrayInitTypeSize=19170
    {
    }

    struct __StaticArrayInitTypeSize=24199
    {
    }
}
