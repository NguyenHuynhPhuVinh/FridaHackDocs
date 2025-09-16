class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7c1afa4*/ EmbeddedAttribute();
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
                /*0x7c1afac*/ IsUnmanagedAttribute();
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

    /*0x7c1b470*/ FullScreenPassRendererFeature();
    /*0x7c1afb4*/ void Create();
    /*0x7c1b0c8*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
    /*0x7c1b0dc*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
    /*0x7c1b3f8*/ void Dispose(bool disposing);
    /*0x7c1b438*/ void UpgradeIfNeeded();
    /*0x7c1b43c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    /*0x7c1b458*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

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

        static /*0x7c1c8bc*/ FullScreenRenderPass();
        static /*0x7c1b590*/ void ExecuteCopyColorPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture);
        static /*0x7c1b610*/ void ExecuteMainPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Material material, int passIndex);
        /*0x7c1b028*/ FullScreenRenderPass(string passName);
        /*0x7c1b3b4*/ void SetupMembers(UnityEngine.Material material, int passIndex, bool fetchActiveColor, bool bindDepthStencilAttachment);
        /*0x7c1b490*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
        /*0x7c1b4f4*/ void ReAllocate(UnityEngine.RenderTextureDescriptor desc);
        /*0x7c1b424*/ void Dispose();
        /*0x7c1b800*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
        /*0x7c1bb1c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

        class CopyPassData
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

            /*0x7c1c938*/ CopyPassData();
        }

        class MainPassData
        {
            /*0x10*/ UnityEngine.Material material;
            /*0x18*/ int passIndex;
            /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputTexture;

            /*0x7c1c940*/ MainPassData();
        }

        class <>c
        {
            static /*0x0*/ FullScreenPassRendererFeature.FullScreenRenderPass.<> <>9;
            static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;
            static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_1;

            static /*0x7c1c948*/ <>c();
            /*0x7c1c9b0*/ <>c();
            /*0x7c1c9b8*/ void <RecordRenderGraph>b__14_0(FullScreenPassRendererFeature.FullScreenRenderPass.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
            /*0x7c1ca64*/ void <RecordRenderGraph>b__14_1(FullScreenPassRendererFeature.FullScreenRenderPass.MainPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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
    static /*0x7c1cb24*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7c1cc18*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

                static /*0x7c1d0c4*/ void RequestHistoryAccess(UnityEngine.Rendering.IPerFrameHistoryAccessTracker access);
                /*0x7c1e01c*/ URPCameraBinder();
                /*0x7c1cc20*/ void SetCameraProperty(string name);
                /*0x7c1cc50*/ void UpdateSubProperties();
                /*0x7c1d204*/ void OnEnable();
                /*0x7c1d348*/ void OnDisable();
                /*0x7c1d490*/ void OnValidate();
                /*0x7c1d5d4*/ bool IsValid(UnityEngine.VFX.VisualEffect component);
                /*0x7c1d844*/ void UpdateBinding(UnityEngine.VFX.VisualEffect component);
                /*0x7c1dedc*/ string ToString();
            }
        }
    }

    namespace Rendering
    {
        class RenderGraphGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;

            static /*0x7c1e1e0*/ RenderGraphGraphicsAutomatedTests();
            static /*0x7c1e080*/ bool get_activatedFromCommandLine();
            static /*0x7c1e188*/ bool get_enabled();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphGraphicsAutomatedTests.<> <>9;
                static /*0x8*/ System.Predicate<string> <>9__1_0;

                static /*0x7c1e230*/ <>c();
                /*0x7c1e298*/ <>c();
                /*0x7c1e2a0*/ bool <get_activatedFromCommandLine>b__1_0(string arg);
            }
        }

        namespace Universal
        {
            class ComponentUtility
            {
                static /*0x7c1e2ec*/ bool IsUniversalCamera(UnityEngine.Camera camera);
                static /*0x7c1e378*/ bool IsUniversalLight(UnityEngine.Light light);
            }

            class PostProcessData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessData.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessData.TextureResources textures;

                /*0x7c1e404*/ PostProcessData();

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

                    /*0x7c1e40c*/ ShaderResources();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D[] blueNoise16LTex;
                    /*0x18*/ UnityEngine.Texture2D[] filmGrainTex;
                    /*0x20*/ UnityEngine.Texture2D smaaAreaTex;
                    /*0x28*/ UnityEngine.Texture2D smaaSearchTex;

                    /*0x7c1e414*/ TextureResources();
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

                /*0x7c1e41c*/ StencilStateData();
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

                static /*0x7c208a4*/ UniversalRenderPipelineAsset();
                /*0x7c206d4*/ UniversalRenderPipelineAsset();
                /*0x7c1e42c*/ bool IsAtLastVersion();
                /*0x7c1e43c*/ UnityEngine.Rendering.GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.get_gpuResidentDrawerSettings();
                /*0x7c1e528*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRendererData> get_rendererDataList();
                /*0x7c1e570*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRenderer> get_renderers();
                /*0x7c1e5b8*/ bool get_isImmediateModeSupported();
                /*0x7c1e5c0*/ UnityEngine.Rendering.Universal.ScriptableRendererData LoadBuiltinRendererData(UnityEngine.Rendering.Universal.RendererType type);
                /*0x7c1e608*/ void EnsureGlobalSettings();
                /*0x7c1e610*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
                /*0x7c1e7cc*/ void DestroyRenderers();
                /*0x7c1ea60*/ void DestroyRenderer(ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x7c1ea94*/ void OnDisable();
                /*0x7c1e82c*/ void CreateRenderers();
                /*0x7c1eab0*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x7c1eda4*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(int index);
                /*0x7c1ece4*/ UnityEngine.Rendering.Universal.ScriptableRendererData get_scriptableRendererData();
                /*0x7c1f068*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_additionalLightsCookieFormat();
                /*0x7c1f294*/ UnityEngine.Vector2Int get_additionalLightsCookieResolution();
                /*0x7c1f2a0*/ int[] get_rendererIndexList();
                /*0x7c1f33c*/ bool get_supportsCameraDepthTexture();
                /*0x7c1f344*/ void set_supportsCameraDepthTexture(bool value);
                /*0x7c1f350*/ bool get_supportsCameraOpaqueTexture();
                /*0x7c1f358*/ void set_supportsCameraOpaqueTexture(bool value);
                /*0x7c1f364*/ UnityEngine.Rendering.Universal.Downsampling get_opaqueDownsampling();
                /*0x7c1f36c*/ bool get_supportsTerrainHoles();
                /*0x7c1f374*/ UnityEngine.Rendering.Universal.StoreActionsOptimization get_storeActionsOptimization();
                /*0x7c1f37c*/ void set_storeActionsOptimization(UnityEngine.Rendering.Universal.StoreActionsOptimization value);
                /*0x7c1f384*/ bool get_supportsHDR();
                /*0x7c1f38c*/ void set_supportsHDR(bool value);
                /*0x7c1f398*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x7c1f3a0*/ void set_hdrColorBufferPrecision(UnityEngine.Rendering.Universal.HDRColorBufferPrecision value);
                /*0x7c1f3a8*/ int get_msaaSampleCount();
                /*0x7c1f3b0*/ void set_msaaSampleCount(int value);
                /*0x7c1f3b8*/ float get_renderScale();
                /*0x7c1f3c0*/ void set_renderScale(float value);
                /*0x7c1f454*/ bool get_enableLODCrossFade();
                /*0x7c1f45c*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType get_lodCrossFadeDitheringType();
                /*0x7c1f464*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection get_upscalingFilter();
                /*0x7c1f46c*/ void set_upscalingFilter(UnityEngine.Rendering.Universal.UpscalingFilterSelection value);
                /*0x7c1f474*/ bool get_fsrOverrideSharpness();
                /*0x7c1f47c*/ void set_fsrOverrideSharpness(bool value);
                /*0x7c1f488*/ float get_fsrSharpness();
                /*0x7c1f490*/ void set_fsrSharpness(float value);
                /*0x7c1f498*/ UnityEngine.Rendering.Universal.ShEvalMode get_shEvalMode();
                /*0x7c1f4a0*/ void set_shEvalMode(UnityEngine.Rendering.Universal.ShEvalMode value);
                /*0x7c1f4a8*/ UnityEngine.Rendering.Universal.LightProbeSystem get_lightProbeSystem();
                /*0x7c1f4b0*/ void set_lightProbeSystem(UnityEngine.Rendering.Universal.LightProbeSystem value);
                /*0x7c1f4b8*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_probeVolumeMemoryBudget();
                /*0x7c1f4c0*/ void set_probeVolumeMemoryBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget value);
                /*0x7c1f4c8*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget get_probeVolumeBlendingMemoryBudget();
                /*0x7c1f4d0*/ void set_probeVolumeBlendingMemoryBudget(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget value);
                /*0x7c1f4d8*/ bool get_supportProbeVolumeStreaming();
                /*0x7c1f4e0*/ void set_supportProbeVolumeStreaming(bool value);
                /*0x7c1f4ec*/ bool get_supportProbeVolumeGPUStreaming();
                /*0x7c1f4f4*/ void set_supportProbeVolumeGPUStreaming(bool value);
                /*0x7c1f500*/ bool get_supportProbeVolumeDiskStreaming();
                /*0x7c1f508*/ void set_supportProbeVolumeDiskStreaming(bool value);
                /*0x7c1f514*/ bool get_supportProbeVolumeScenarios();
                /*0x7c1f51c*/ void set_supportProbeVolumeScenarios(bool value);
                /*0x7c1f528*/ bool get_supportProbeVolumeScenarioBlending();
                /*0x7c1f530*/ void set_supportProbeVolumeScenarioBlending(bool value);
                /*0x7c1f53c*/ UnityEngine.Rendering.ProbeVolumeSHBands get_probeVolumeSHBands();
                /*0x7c1f544*/ void set_probeVolumeSHBands(UnityEngine.Rendering.ProbeVolumeSHBands value);
                /*0x7c1f54c*/ UnityEngine.Rendering.Universal.LightRenderingMode get_mainLightRenderingMode();
                /*0x7c1f554*/ void set_mainLightRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x7c1f55c*/ bool get_supportsMainLightShadows();
                /*0x7c1f564*/ void set_supportsMainLightShadows(bool value);
                /*0x7c1f570*/ int get_mainLightShadowmapResolution();
                /*0x7c1f578*/ void set_mainLightShadowmapResolution(int value);
                /*0x7c1f580*/ UnityEngine.Rendering.Universal.LightRenderingMode get_additionalLightsRenderingMode();
                /*0x7c1f588*/ void set_additionalLightsRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x7c1f590*/ int get_maxAdditionalLightsCount();
                /*0x7c1f598*/ void set_maxAdditionalLightsCount(int value);
                /*0x7c1f650*/ bool get_supportsAdditionalLightShadows();
                /*0x7c1f658*/ void set_supportsAdditionalLightShadows(bool value);
                /*0x7c1f664*/ int get_additionalLightsShadowmapResolution();
                /*0x7c1f66c*/ void set_additionalLightsShadowmapResolution(int value);
                /*0x7c1f674*/ int get_additionalLightsShadowResolutionTierLow();
                /*0x7c1f67c*/ void set_additionalLightsShadowResolutionTierLow(int value);
                /*0x7c1f684*/ int get_additionalLightsShadowResolutionTierMedium();
                /*0x7c1f68c*/ void set_additionalLightsShadowResolutionTierMedium(int value);
                /*0x7c1f694*/ int get_additionalLightsShadowResolutionTierHigh();
                /*0x7c1f69c*/ void set_additionalLightsShadowResolutionTierHigh(int value);
                /*0x7c1f6a4*/ int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier);
                /*0x7c1f76c*/ bool get_reflectionProbeBlending();
                /*0x7c1f774*/ void set_reflectionProbeBlending(bool value);
                /*0x7c1f780*/ bool get_reflectionProbeBoxProjection();
                /*0x7c1f788*/ void set_reflectionProbeBoxProjection(bool value);
                /*0x7c1f794*/ float get_shadowDistance();
                /*0x7c1f79c*/ void set_shadowDistance(float value);
                /*0x7c1f7ac*/ int get_shadowCascadeCount();
                /*0x7c1f7b4*/ void set_shadowCascadeCount(int value);
                /*0x7c1f888*/ float get_cascade2Split();
                /*0x7c1f890*/ void set_cascade2Split(float value);
                /*0x7c1f898*/ UnityEngine.Vector2 get_cascade3Split();
                /*0x7c1f8a0*/ void set_cascade3Split(UnityEngine.Vector2 value);
                /*0x7c1f8a8*/ UnityEngine.Vector3 get_cascade4Split();
                /*0x7c1f8b4*/ void set_cascade4Split(UnityEngine.Vector3 value);
                /*0x7c1f8c0*/ float get_cascadeBorder();
                /*0x7c1f8c8*/ void set_cascadeBorder(float value);
                /*0x7c1f8d0*/ float get_shadowDepthBias();
                /*0x7c1f8d8*/ void set_shadowDepthBias(float value);
                /*0x7c1f960*/ float get_shadowNormalBias();
                /*0x7c1f968*/ void set_shadowNormalBias(float value);
                /*0x7c1f980*/ bool get_supportsSoftShadows();
                /*0x7c1f988*/ void set_supportsSoftShadows(bool value);
                /*0x7c1f994*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x7c1f99c*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x7c1f9a4*/ bool get_supportsDynamicBatching();
                /*0x7c1f9ac*/ void set_supportsDynamicBatching(bool value);
                /*0x7c1f9b8*/ bool get_supportsMixedLighting();
                /*0x7c1f9c0*/ bool get_supportsLightCookies();
                /*0x7c1f9c8*/ bool get_supportsLightLayers();
                /*0x7c1f9d0*/ bool get_useRenderingLayers();
                /*0x7c1f9d8*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x7c1f9e0*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x7c1f9e8*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
                /*0x7c1f9f8*/ UnityEngine.Rendering.Universal.PipelineDebugLevel get_debugLevel();
                /*0x7c1fa00*/ bool get_useSRPBatcher();
                /*0x7c1fa08*/ void set_useSRPBatcher(bool value);
                /*0x7c1fa14*/ bool get_enableRenderGraph();
                /*0x7c1fb18*/ void OnEnableRenderGraphChanged();
                /*0x7c1fb28*/ UnityEngine.Rendering.Universal.ColorGradingMode get_colorGradingMode();
                /*0x7c1fb30*/ void set_colorGradingMode(UnityEngine.Rendering.Universal.ColorGradingMode value);
                /*0x7c1fb38*/ int get_colorGradingLutSize();
                /*0x7c1fb40*/ void set_colorGradingLutSize(int value);
                /*0x7c1fb60*/ bool get_allowPostProcessAlphaOutput();
                /*0x7c1fb68*/ bool get_useFastSRGBLinearConversion();
                /*0x7c1fb70*/ bool get_supportScreenSpaceLensFlare();
                /*0x7c1fb78*/ bool get_supportDataDrivenLensFlare();
                /*0x7c1fb80*/ bool get_useAdaptivePerformance();
                /*0x7c1fb88*/ void set_useAdaptivePerformance(bool value);
                /*0x7c1fb94*/ bool get_conservativeEnclosingSphere();
                /*0x7c1fb9c*/ void set_conservativeEnclosingSphere(bool value);
                /*0x7c1fba8*/ int get_numIterationsEnclosingSphere();
                /*0x7c1fbb0*/ void set_numIterationsEnclosingSphere(int value);
                /*0x7c1fbb8*/ string get_renderPipelineShaderTag();
                /*0x7c1fbf8*/ string[] get_renderingLayerMaskNames();
                /*0x7c1fc48*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x7c1fcd4*/ string[] get_lightLayerMaskNames();
                /*0x7c1fd18*/ UnityEngine.Rendering.GPUResidentDrawerMode get_gpuResidentDrawerMode();
                /*0x7c1fd20*/ void set_gpuResidentDrawerMode(UnityEngine.Rendering.GPUResidentDrawerMode value);
                /*0x7c1fd44*/ bool get_gpuResidentDrawerEnableOcclusionCullingInCameras();
                /*0x7c1fd4c*/ void set_gpuResidentDrawerEnableOcclusionCullingInCameras(bool value);
                /*0x7c1fd74*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severty);
                /*0x7c1fed4*/ float get_smallMeshScreenPercentage();
                /*0x7c1fedc*/ void set_smallMeshScreenPercentage(float value);
                /*0x7c1ff88*/ void OnBeforeSerialize();
                /*0x7c1ff8c*/ void OnAfterDeserialize();
                /*0x7c1f8f0*/ float ValidateShadowBias(float value);
                /*0x7c1f5b0*/ int ValidatePerObjectLights(int value);
                /*0x7c1f3d8*/ float ValidateRenderScale(float value);
                /*0x7c20218*/ bool ValidateRendererDataList(bool partial);
                /*0x7c20298*/ bool ValidateRendererData(int index);
                /*0x7c2033c*/ bool get_supportProbeVolume();
                /*0x7c2034c*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
                /*0x7c20368*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
                /*0x7c20370*/ bool get_isStpUsed();
                /*0x7c20380*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DefaultMaterialType materialType);
                /*0x7c20388*/ UnityEngine.Material get_defaultMaterial();
                /*0x7c20390*/ UnityEngine.Material get_defaultParticleMaterial();
                /*0x7c20398*/ UnityEngine.Material get_defaultLineMaterial();
                /*0x7c203a0*/ UnityEngine.Material get_defaultTerrainMaterial();
                /*0x7c203a8*/ UnityEngine.Material get_default2DMaterial();
                /*0x7c203b0*/ UnityEngine.Material get_default2DMaskMaterial();
                /*0x7c203b8*/ UnityEngine.Material get_decalMaterial();
                /*0x7c203c0*/ UnityEngine.Shader get_defaultShader();
                /*0x7c20478*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x7c204ec*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.Universal.ShaderVariantLogLevel value);
                /*0x7c20568*/ UnityEngine.Rendering.Universal.ShadowCascadesOption get_shadowCascadeOption();
                /*0x7c205ec*/ void set_shadowCascadeOption(UnityEngine.Rendering.Universal.ShadowCascadesOption value);
                /*0x7c20658*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources get_textures();

                class Strings
                {
                    static /*0x0*/ string notURPRenderer;
                    static /*0x8*/ string forwardPlusMissing;

                    static /*0x7c20ab4*/ Strings();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D blueNoise64LTex;
                    /*0x18*/ UnityEngine.Texture2D bayerMatrixTex;

                    /*0x7c206cc*/ TextureResources();
                    /*0x7c20b50*/ bool NeedsReload();
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
                /*0x7c20fc8*/ DebugDisplaySettingsCommon();
                /*0x7c20be8*/ bool get_AreAnySettingsActive();
                /*0x7c20bf0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
                {
                    static string k_GoToSectionString = "Go to Section...";

                    /*0x7c20c40*/ SettingsPanel();
                    /*0x7c20fd0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.DebugUI.Foldout foldout;

                        /*0x7c20fd8*/ <>c__DisplayClass3_0();
                        /*0x7c20fe0*/ void <.ctor>b__0();
                    }
                }
            }

            class DebugDisplaySettingsLighting : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugLightingMode <lightingDebugMode>k__BackingField;
                /*0x14*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode <hdrDebugMode>k__BackingField;

                /*0x7c212f8*/ DebugDisplaySettingsLighting();
                /*0x7c210a8*/ UnityEngine.Rendering.Universal.DebugLightingMode get_lightingDebugMode();
                /*0x7c210b0*/ void set_lightingDebugMode(UnityEngine.Rendering.Universal.DebugLightingMode value);
                /*0x7c210b8*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags get_lightingFeatureFlags();
                /*0x7c210c0*/ void set_lightingFeatureFlags(UnityEngine.Rendering.Universal.DebugLightingFeatureFlags value);
                /*0x7c210c8*/ UnityEngine.Rendering.Universal.HDRDebugMode get_hdrDebugMode();
                /*0x7c210d0*/ void set_hdrDebugMode(UnityEngine.Rendering.Universal.HDRDebugMode value);
                /*0x7c210d8*/ bool get_AreAnySettingsActive();
                /*0x7c21100*/ bool get_IsPostProcessingAllowed();
                /*0x7c21114*/ bool get_IsLightingActive();
                /*0x7c2111c*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingDebugMode;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingFeatures;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDRDebugMode;

                    static /*0x7c21300*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c2149c*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x7c21720*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingFeatures(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x7c2191c*/ UnityEngine.Rendering.DebugUI.Widget CreateHDRDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c21718*/ <>c__DisplayClass0_0();
                        /*0x7c21ba0*/ int <CreateLightingDebugMode>b__0();
                        /*0x7c21bf0*/ void <CreateLightingDebugMode>b__1(int value);
                        /*0x7c21c44*/ int <CreateLightingDebugMode>b__2();
                        /*0x7c21c94*/ void <CreateLightingDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c21914*/ <>c__DisplayClass1_0();
                        /*0x7c21ce8*/ System.Enum <CreateLightingFeatures>b__0();
                        /*0x7c21d5c*/ void <CreateLightingFeatures>b__1(System.Enum value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x7c21b98*/ <>c__DisplayClass2_0();
                        /*0x7c21df0*/ int <CreateHDRDebugMode>b__0();
                        /*0x7c21e40*/ void <CreateHDRDebugMode>b__1(int value);
                        /*0x7c21e94*/ int <CreateHDRDebugMode>b__2();
                        /*0x7c21ee4*/ void <CreateHDRDebugMode>b__3(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting>
                {
                    /*0x7c21174*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
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

                /*0x7c22b74*/ DebugDisplaySettingsMaterial();
                /*0x7c21f38*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoValidationPreset();
                /*0x7c21f40*/ void set_albedoValidationPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value);
                /*0x7c21f84*/ float get_albedoMinLuminance();
                /*0x7c21f8c*/ void set_albedoMinLuminance(float value);
                /*0x7c21f94*/ float get_albedoMaxLuminance();
                /*0x7c21f9c*/ void set_albedoMaxLuminance(float value);
                /*0x7c21fa4*/ float get_albedoHueTolerance();
                /*0x7c21fbc*/ void set_albedoHueTolerance(float value);
                /*0x7c21fc4*/ float get_albedoSaturationTolerance();
                /*0x7c21fdc*/ void set_albedoSaturationTolerance(float value);
                /*0x7c21fe4*/ UnityEngine.Color get_albedoCompareColor();
                /*0x7c21ff0*/ void set_albedoCompareColor(UnityEngine.Color value);
                /*0x7c21ffc*/ float get_metallicMinValue();
                /*0x7c22004*/ void set_metallicMinValue(float value);
                /*0x7c2200c*/ float get_metallicMaxValue();
                /*0x7c22014*/ void set_metallicMaxValue(float value);
                /*0x7c2201c*/ bool get_renderingLayersSelectedLight();
                /*0x7c22024*/ void set_renderingLayersSelectedLight(bool value);
                /*0x7c22030*/ bool get_selectedLightShadowLayerMask();
                /*0x7c22038*/ void set_selectedLightShadowLayerMask(bool value);
                /*0x7c22044*/ uint get_renderingLayerMask();
                /*0x7c2204c*/ void set_renderingLayerMask(uint value);
                /*0x7c22054*/ uint GetDebugLightLayersMask();
                /*0x7c2205c*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode get_materialValidationMode();
                /*0x7c22064*/ void set_materialValidationMode(UnityEngine.Rendering.Universal.DebugMaterialValidationMode value);
                /*0x7c2206c*/ UnityEngine.Rendering.Universal.DebugMaterialMode get_materialDebugMode();
                /*0x7c22074*/ void set_materialDebugMode(UnityEngine.Rendering.Universal.DebugMaterialMode value);
                /*0x7c2207c*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode get_vertexAttributeDebugMode();
                /*0x7c22084*/ void set_vertexAttributeDebugMode(UnityEngine.Rendering.Universal.DebugVertexAttributeMode value);
                /*0x7c2208c*/ bool get_AreAnySettingsActive();
                /*0x7c220b4*/ bool get_IsPostProcessingAllowed();
                /*0x7c220dc*/ bool get_IsLightingActive();
                /*0x7c22104*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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

                    static /*0x7c23618*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c23c74*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialOverride(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c23ef8*/ UnityEngine.Rendering.DebugUI.Widget CreateVertexAttribute(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c2417c*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c244bc*/ UnityEngine.Rendering.DebugUI.Widget CreateRenderingLayersSelectedLight(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c24674*/ UnityEngine.Rendering.DebugUI.Widget CreateSelectedLightShadowLayerMask(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c2486c*/ UnityEngine.Rendering.DebugUI.Widget CreateFilterRenderingLayerMasks(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c24a78*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c24db8*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoCustomColor(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c24fc4*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMinLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c25180*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMaxLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c2533c*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoHueTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c25554*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoSaturationTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c2576c*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMinValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x7c25928*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMaxValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x10*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__6_4;

                        static /*0x7c25ae4*/ <>c();
                        /*0x7c25b4c*/ <>c();
                        /*0x7c25b54*/ void <CreateMaterialValidationMode>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c25bb4*/ void <CreateAlbedoPreset>b__6_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c23ef0*/ <>c__DisplayClass0_0();
                        /*0x7c25c14*/ int <CreateMaterialOverride>b__0();
                        /*0x7c25c64*/ void <CreateMaterialOverride>b__1(int value);
                        /*0x7c25cb8*/ int <CreateMaterialOverride>b__2();
                        /*0x7c25d08*/ void <CreateMaterialOverride>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c2554c*/ <>c__DisplayClass10_0();
                        /*0x7c25d5c*/ float <CreateAlbedoHueTolerance>b__0();
                        /*0x7c25dbc*/ void <CreateAlbedoHueTolerance>b__1(float value);
                        /*0x7c25e18*/ bool <CreateAlbedoHueTolerance>b__2();
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c25764*/ <>c__DisplayClass11_0();
                        /*0x7c25e70*/ float <CreateAlbedoSaturationTolerance>b__0();
                        /*0x7c25ed0*/ void <CreateAlbedoSaturationTolerance>b__1(float value);
                        /*0x7c25f2c*/ bool <CreateAlbedoSaturationTolerance>b__2();
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c25920*/ <>c__DisplayClass12_0();
                        /*0x7c25f84*/ float <CreateMetallicMinValue>b__0();
                        /*0x7c25fd4*/ void <CreateMetallicMinValue>b__1(float value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c25adc*/ <>c__DisplayClass13_0();
                        /*0x7c26030*/ float <CreateMetallicMaxValue>b__0();
                        /*0x7c26080*/ void <CreateMetallicMaxValue>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c24174*/ <>c__DisplayClass1_0();
                        /*0x7c260dc*/ int <CreateVertexAttribute>b__0();
                        /*0x7c2612c*/ void <CreateVertexAttribute>b__1(int value);
                        /*0x7c26180*/ int <CreateVertexAttribute>b__2();
                        /*0x7c261d0*/ void <CreateVertexAttribute>b__3(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c244b4*/ <>c__DisplayClass2_0();
                        /*0x7c26224*/ int <CreateMaterialValidationMode>b__0();
                        /*0x7c26274*/ void <CreateMaterialValidationMode>b__1(int value);
                        /*0x7c262c8*/ int <CreateMaterialValidationMode>b__2();
                        /*0x7c26318*/ void <CreateMaterialValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c2466c*/ <>c__DisplayClass3_0();
                        /*0x7c2636c*/ bool <CreateRenderingLayersSelectedLight>b__0();
                        /*0x7c263bc*/ void <CreateRenderingLayersSelectedLight>b__1(bool value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c24864*/ <>c__DisplayClass4_0();
                        /*0x7c26414*/ bool <CreateSelectedLightShadowLayerMask>b__0();
                        /*0x7c26464*/ void <CreateSelectedLightShadowLayerMask>b__1(bool value);
                        /*0x7c264bc*/ bool <CreateSelectedLightShadowLayerMask>b__2();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c24a70*/ <>c__DisplayClass5_0();
                        /*0x7c26514*/ uint <CreateFilterRenderingLayerMasks>b__0();
                        /*0x7c26564*/ void <CreateFilterRenderingLayerMasks>b__1(uint value);
                        /*0x7c265b8*/ bool <CreateFilterRenderingLayerMasks>b__2();
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c24db0*/ <>c__DisplayClass6_0();
                        /*0x7c26608*/ int <CreateAlbedoPreset>b__0();
                        /*0x7c26658*/ void <CreateAlbedoPreset>b__1(int value);
                        /*0x7c266ac*/ int <CreateAlbedoPreset>b__2();
                        /*0x7c266fc*/ void <CreateAlbedoPreset>b__3(int value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c24fbc*/ <>c__DisplayClass7_0();
                        /*0x7c26750*/ UnityEngine.Color <CreateAlbedoCustomColor>b__0();
                        /*0x7c267a4*/ void <CreateAlbedoCustomColor>b__1(UnityEngine.Color value);
                        /*0x7c26818*/ bool <CreateAlbedoCustomColor>b__2();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c25178*/ <>c__DisplayClass8_0();
                        /*0x7c26870*/ float <CreateAlbedoMinLuminance>b__0();
                        /*0x7c268c0*/ void <CreateAlbedoMinLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x7c25334*/ <>c__DisplayClass9_0();
                        /*0x7c2691c*/ float <CreateAlbedoMaxLuminance>b__0();
                        /*0x7c2696c*/ void <CreateAlbedoMaxLuminance>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial>
                {
                    /*0x7c2215c*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel <>4__this;
                        /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x7c269c8*/ <>c__DisplayClass0_0();
                        /*0x7c269d8*/ bool <.ctor>b__2();
                        /*0x7c269fc*/ bool <.ctor>b__3();
                        /*0x7c26a20*/ bool <.ctor>b__4();
                    }

                    class <>c__DisplayClass0_1
                    {
                        /*0x10*/ int index;
                        /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel.<> CS$<>8__locals1;

                        /*0x7c269d0*/ <>c__DisplayClass0_1();
                        /*0x7c26a44*/ UnityEngine.Color <.ctor>b__0();
                        /*0x7c26ac0*/ void <.ctor>b__1(UnityEngine.Color value);
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

                /*0x7c2749c*/ DebugDisplaySettingsRendering();
                /*0x7c26b5c*/ UnityEngine.Rendering.Universal.DebugWireframeMode get_wireframeMode();
                /*0x7c26b64*/ void set_wireframeMode(UnityEngine.Rendering.Universal.DebugWireframeMode value);
                /*0x7c26bbc*/ bool get_overdraw();
                /*0x7c26bc4*/ void set_overdraw(bool value);
                /*0x7c26bf8*/ UnityEngine.Rendering.Universal.DebugOverdrawMode get_overdrawMode();
                /*0x7c26c00*/ void set_overdrawMode(UnityEngine.Rendering.Universal.DebugOverdrawMode value);
                /*0x7c26c24*/ int get_maxOverdrawCount();
                /*0x7c26c2c*/ void set_maxOverdrawCount(int value);
                /*0x7c26b90*/ void UpdateDebugSceneOverrideMode();
                /*0x7c26c34*/ UnityEngine.Rendering.Universal.DebugFullScreenMode get_fullScreenDebugMode();
                /*0x7c26c3c*/ void set_fullScreenDebugMode(UnityEngine.Rendering.Universal.DebugFullScreenMode value);
                /*0x7c26c44*/ int get_stpDebugViewIndex();
                /*0x7c26c4c*/ void set_stpDebugViewIndex(int value);
                /*0x7c26c54*/ int get_fullScreenDebugModeOutputSizeScreenPercent();
                /*0x7c26c5c*/ void set_fullScreenDebugModeOutputSizeScreenPercent(int value);
                /*0x7c26c64*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode get_sceneOverrideMode();
                /*0x7c26c6c*/ void set_sceneOverrideMode(UnityEngine.Rendering.Universal.DebugSceneOverrideMode value);
                /*0x7c26c74*/ UnityEngine.Rendering.Universal.DebugMipInfoMode get_mipInfoMode();
                /*0x7c26c7c*/ void set_mipInfoMode(UnityEngine.Rendering.Universal.DebugMipInfoMode value);
                /*0x7c26c84*/ bool get_mipDebugStatusShowCode();
                /*0x7c26c8c*/ void set_mipDebugStatusShowCode(bool value);
                /*0x7c26c98*/ UnityEngine.Rendering.Universal.DebugMipMapStatusMode get_mipDebugStatusMode();
                /*0x7c26ca0*/ void set_mipDebugStatusMode(UnityEngine.Rendering.Universal.DebugMipMapStatusMode value);
                /*0x7c26ca8*/ float get_mipDebugOpacity();
                /*0x7c26cb0*/ void set_mipDebugOpacity(float value);
                /*0x7c26cb8*/ float get_mipDebugRecentUpdateCooldown();
                /*0x7c26cc0*/ void set_mipDebugRecentUpdateCooldown(float value);
                /*0x7c26cc8*/ int get_mipDebugMaterialTextureSlot();
                /*0x7c26cd0*/ void set_mipDebugMaterialTextureSlot(int value);
                /*0x7c26cd8*/ bool get_showInfoForAllSlots();
                /*0x7c26ce0*/ void set_showInfoForAllSlots(bool value);
                /*0x7c26cec*/ bool get_canAggregateData();
                /*0x7c26d00*/ UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture get_mipDebugTerrainTexture();
                /*0x7c26d08*/ void set_mipDebugTerrainTexture(UnityEngine.Rendering.Universal.DebugMipMapModeTerrainTexture value);
                /*0x7c26d10*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode get_postProcessingDebugMode();
                /*0x7c26d18*/ void set_postProcessingDebugMode(UnityEngine.Rendering.Universal.DebugPostProcessingMode value);
                /*0x7c26d20*/ bool get_enableMsaa();
                /*0x7c26d28*/ void set_enableMsaa(bool value);
                /*0x7c26d34*/ bool get_enableHDR();
                /*0x7c26d3c*/ void set_enableHDR(bool value);
                /*0x7c26d48*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode get_taaDebugMode();
                /*0x7c26d50*/ void set_taaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode value);
                /*0x7c26d58*/ UnityEngine.Rendering.Universal.DebugValidationMode get_validationMode();
                /*0x7c26d60*/ void set_validationMode(UnityEngine.Rendering.Universal.DebugValidationMode value);
                /*0x7c26d68*/ UnityEngine.Rendering.Universal.PixelValidationChannels get_validationChannels();
                /*0x7c26d70*/ void set_validationChannels(UnityEngine.Rendering.Universal.PixelValidationChannels value);
                /*0x7c26d78*/ float get_validationRangeMin();
                /*0x7c26d80*/ void set_validationRangeMin(float value);
                /*0x7c26d88*/ float get_validationRangeMax();
                /*0x7c26d90*/ void set_validationRangeMax(float value);
                /*0x7c26d98*/ bool get_AreAnySettingsActive();
                /*0x7c26dec*/ bool get_IsPostProcessingAllowed();
                /*0x7c26e14*/ bool get_IsLightingActive();
                /*0x7c26e34*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x7c26ed4*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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

                    static /*0x7c274dc*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x7c27ea0*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlays(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c28124*/ UnityEngine.Rendering.DebugUI.Widget CreateStpDebugViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c28480*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlaySize(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c287c8*/ UnityEngine.Rendering.DebugUI.Widget CreateAdditionalWireframeShaderViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c28b08*/ UnityEngine.Rendering.DebugUI.Widget CreateWireframeNotSupportedWarning(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c28c4c*/ UnityEngine.Rendering.DebugUI.Widget CreateOverdrawMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c28ed0*/ UnityEngine.Rendering.DebugUI.Widget CreateMaxOverdrawCount(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c29270*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugWidget(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c29548*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c297c4*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2a248*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugSlotSelector(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel, System.Func<bool> hiddenCB, UnityEngine.GUIContent[] texSlotStrings, int[] texSlotValues);
                    static /*0x7c2a6c0*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapDebugCooldownSlider(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2a4d0*/ UnityEngine.Rendering.DebugUI.Widget CreateMipMapShowStatusCodeToggle(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2aa08*/ UnityEngine.Rendering.DebugUI.Widget CreatePostProcessing(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2ac8c*/ UnityEngine.Rendering.DebugUI.Widget CreateMSAA(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2ae3c*/ UnityEngine.Rendering.DebugUI.Widget CreateHDR(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2afec*/ UnityEngine.Rendering.DebugUI.Widget CreateTaaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2b32c*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2b66c*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationChannels(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2b8f0*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMin(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x7c2baac*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMax(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);

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

                        static /*0x7c2bc68*/ <>c();
                        /*0x7c2bcd0*/ <>c();
                        /*0x7c2bcd8*/ int <CreateMapOverlaySize>b__2_2();
                        /*0x7c2bce0*/ int <CreateMapOverlaySize>b__2_3();
                        /*0x7c2bce8*/ void <CreateAdditionalWireframeShaderViews>b__3_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c2bd48*/ int <CreateMaxOverdrawCount>b__6_3();
                        /*0x7c2bd50*/ int <CreateMaxOverdrawCount>b__6_4();
                        /*0x7c2bd58*/ bool <CreateMipMapDebugWidget>b__7_0();
                        /*0x7c2bda8*/ void <CreateMipMapDebugWidget>b__7_1(bool value);
                        /*0x7c2be00*/ float <CreateMipMapDebugSettings>b__9_4();
                        /*0x7c2be08*/ float <CreateMipMapDebugSettings>b__9_5();
                        /*0x7c2be10*/ bool <CreateMipMapDebugSettings>b__9_10();
                        /*0x7c2be18*/ float <CreateMipMapDebugCooldownSlider>b__11_3();
                        /*0x7c2be20*/ float <CreateMipMapDebugCooldownSlider>b__11_4();
                        /*0x7c2be2c*/ void <CreateTaaDebugMode>b__16_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x7c2be8c*/ void <CreatePixelValidationMode>b__17_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2811c*/ <>c__DisplayClass0_0();
                        /*0x7c2beec*/ int <CreateMapOverlays>b__0();
                        /*0x7c2bf3c*/ void <CreateMapOverlays>b__1(int value);
                        /*0x7c2bf90*/ int <CreateMapOverlays>b__2();
                        /*0x7c2bfe0*/ void <CreateMapOverlays>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2a9f0*/ <>c__DisplayClass10_0();
                        /*0x7c2c034*/ int <CreateMipMapDebugSlotSelector>b__0();
                        /*0x7c2c084*/ void <CreateMipMapDebugSlotSelector>b__1(int value);
                        /*0x7c2c0d8*/ int <CreateMipMapDebugSlotSelector>b__2();
                        /*0x7c2c128*/ void <CreateMipMapDebugSlotSelector>b__3(int value);
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2a9f8*/ <>c__DisplayClass11_0();
                        /*0x7c2c17c*/ bool <CreateMipMapDebugCooldownSlider>b__0();
                        /*0x7c2c1d4*/ float <CreateMipMapDebugCooldownSlider>b__1();
                        /*0x7c2c224*/ void <CreateMipMapDebugCooldownSlider>b__2(float value);
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2aa00*/ <>c__DisplayClass12_0();
                        /*0x7c2c280*/ bool <CreateMipMapShowStatusCodeToggle>b__0();
                        /*0x7c2c2d8*/ bool <CreateMipMapShowStatusCodeToggle>b__1();
                        /*0x7c2c328*/ void <CreateMipMapShowStatusCodeToggle>b__2(bool value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2ac84*/ <>c__DisplayClass13_0();
                        /*0x7c2c380*/ int <CreatePostProcessing>b__0();
                        /*0x7c2c3d0*/ void <CreatePostProcessing>b__1(int value);
                        /*0x7c2c424*/ int <CreatePostProcessing>b__2();
                        /*0x7c2c474*/ void <CreatePostProcessing>b__3(int value);
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2ae34*/ <>c__DisplayClass14_0();
                        /*0x7c2c4c8*/ bool <CreateMSAA>b__0();
                        /*0x7c2c518*/ void <CreateMSAA>b__1(bool value);
                    }

                    class <>c__DisplayClass15_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2afe4*/ <>c__DisplayClass15_0();
                        /*0x7c2c570*/ bool <CreateHDR>b__0();
                        /*0x7c2c5c0*/ void <CreateHDR>b__1(bool value);
                    }

                    class <>c__DisplayClass16_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2b324*/ <>c__DisplayClass16_0();
                        /*0x7c2c618*/ int <CreateTaaDebugMode>b__0();
                        /*0x7c2c668*/ void <CreateTaaDebugMode>b__1(int value);
                        /*0x7c2c6bc*/ int <CreateTaaDebugMode>b__2();
                        /*0x7c2c70c*/ void <CreateTaaDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2b664*/ <>c__DisplayClass17_0();
                        /*0x7c2c760*/ int <CreatePixelValidationMode>b__0();
                        /*0x7c2c7b0*/ void <CreatePixelValidationMode>b__1(int value);
                        /*0x7c2c804*/ int <CreatePixelValidationMode>b__2();
                        /*0x7c2c854*/ void <CreatePixelValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2b8e8*/ <>c__DisplayClass18_0();
                        /*0x7c2c8a8*/ int <CreatePixelValidationChannels>b__0();
                        /*0x7c2c8f8*/ void <CreatePixelValidationChannels>b__1(int value);
                        /*0x7c2c94c*/ int <CreatePixelValidationChannels>b__2();
                        /*0x7c2c99c*/ void <CreatePixelValidationChannels>b__3(int value);
                    }

                    class <>c__DisplayClass19_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2baa4*/ <>c__DisplayClass19_0();
                        /*0x7c2c9f0*/ float <CreatePixelValueRangeMin>b__0();
                        /*0x7c2ca40*/ void <CreatePixelValueRangeMin>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c28478*/ <>c__DisplayClass1_0();
                        /*0x7c2ca9c*/ bool <CreateStpDebugViews>b__0();
                        /*0x7c2caf4*/ int <CreateStpDebugViews>b__1();
                        /*0x7c2cb44*/ void <CreateStpDebugViews>b__2(int value);
                        /*0x7c2cb98*/ int <CreateStpDebugViews>b__3();
                        /*0x7c2cbe8*/ void <CreateStpDebugViews>b__4(int value);
                    }

                    class <>c__DisplayClass20_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2bc60*/ <>c__DisplayClass20_0();
                        /*0x7c2cc3c*/ float <CreatePixelValueRangeMax>b__0();
                        /*0x7c2cc8c*/ void <CreatePixelValueRangeMax>b__1(float value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c287c0*/ <>c__DisplayClass2_0();
                        /*0x7c2cce8*/ int <CreateMapOverlaySize>b__0();
                        /*0x7c2cd38*/ void <CreateMapOverlaySize>b__1(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c28b00*/ <>c__DisplayClass3_0();
                        /*0x7c2cd8c*/ int <CreateAdditionalWireframeShaderViews>b__0();
                        /*0x7c2cddc*/ void <CreateAdditionalWireframeShaderViews>b__1(int value);
                        /*0x7c2ce54*/ int <CreateAdditionalWireframeShaderViews>b__2();
                        /*0x7c2cea4*/ void <CreateAdditionalWireframeShaderViews>b__3(int value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c28c44*/ <>c__DisplayClass4_0();
                        /*0x7c2cf1c*/ bool <CreateWireframeNotSupportedWarning>b__0();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c28ec8*/ <>c__DisplayClass5_0();
                        /*0x7c2cf94*/ int <CreateOverdrawMode>b__0();
                        /*0x7c2cfe4*/ void <CreateOverdrawMode>b__1(int value);
                        /*0x7c2d054*/ int <CreateOverdrawMode>b__2();
                        /*0x7c2d0a4*/ void <CreateOverdrawMode>b__3(int value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c29268*/ <>c__DisplayClass6_0();
                        /*0x7c2d114*/ bool <CreateMaxOverdrawCount>b__0();
                        /*0x7c2d16c*/ int <CreateMaxOverdrawCount>b__1();
                        /*0x7c2d1bc*/ void <CreateMaxOverdrawCount>b__2(int value);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2a238*/ <>c__DisplayClass8_0();
                        /*0x7c2d210*/ int <CreateMipMapMode>b__0();
                        /*0x7c2d260*/ void <CreateMipMapMode>b__1(int value);
                        /*0x7c2d2b4*/ int <CreateMipMapMode>b__2();
                        /*0x7c2d304*/ void <CreateMipMapMode>b__3(int value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x7c2a240*/ <>c__DisplayClass9_0();
                        /*0x7c2d358*/ bool <CreateMipMapDebugSettings>b__0();
                        /*0x7c2d3b0*/ float <CreateMipMapDebugSettings>b__2();
                        /*0x7c2d400*/ void <CreateMipMapDebugSettings>b__3(float value);
                        /*0x7c2d45c*/ bool <CreateMipMapDebugSettings>b__1();
                        /*0x7c2d4b8*/ bool <CreateMipMapDebugSettings>b__6();
                        /*0x7c2d514*/ bool <CreateMipMapDebugSettings>b__7();
                        /*0x7c2d564*/ void <CreateMipMapDebugSettings>b__8(bool value);
                        /*0x7c2d5c8*/ bool <CreateMipMapDebugSettings>b__9();
                        /*0x7c2d638*/ int <CreateMipMapDebugSettings>b__11();
                        /*0x7c2d688*/ void <CreateMipMapDebugSettings>b__12(int value);
                        /*0x7c2d6dc*/ int <CreateMipMapDebugSettings>b__13();
                        /*0x7c2d72c*/ void <CreateMipMapDebugSettings>b__14(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering>
                {
                    /*0x7c26f2c*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x7c2d780*/ <>c__DisplayClass0_0();
                        /*0x7c2d788*/ bool <.ctor>b__0();
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

                static /*0x7c30770*/ DebugHandler();
                static /*0x7c2df24*/ void ConfigureColorDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x7c2df68*/ void ConfigureDepthDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x7c2e74c*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data);
                static /*0x7c2f4b0*/ void Setup(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData);
                /*0x7c2d9e4*/ DebugHandler();
                /*0x7c2d7ac*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x7c2d7c8*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x7c2d7e4*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x7c2d800*/ bool get_AreAnySettingsActive();
                /*0x7c2d820*/ bool get_IsPostProcessingAllowed();
                /*0x7c2d840*/ bool get_IsLightingActive();
                /*0x7c2d860*/ bool get_IsActiveModeUnsupportedForDeferred();
                /*0x7c2d8d4*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x7c2d8f4*/ UnityEngine.Material get_ReplacementMaterial();
                /*0x7c2d8fc*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings();
                /*0x7c2d904*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenColorHandle();
                /*0x7c2d90c*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenDepthHandle();
                /*0x7c2d914*/ UnityEngine.Rendering.Universal.HDRDebugViewPass get_hdrDebugViewPass();
                /*0x7c2d91c*/ bool HDRDebugViewIsActive(bool resolveFinalTarget);
                /*0x7c2d94c*/ bool WriteToDebugScreenTexture(bool resolveFinalTarget);
                /*0x7c2d954*/ bool get_IsScreenClearNeeded();
                /*0x7c2d994*/ bool get_IsRenderPassSupported();
                /*0x7c2d9c0*/ int get_stpDebugViewIndex();
                /*0x7c2dde0*/ void Dispose();
                /*0x7c2de9c*/ bool IsActiveForCamera(bool isPreviewCamera);
                /*0x7c2decc*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode);
                /*0x7c2dee8*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode, ref int textureHeightPercent);
                /*0x7c2dfb8*/ void SetupShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, int passIndex);
                /*0x7c2e4f8*/ void SetDebugRenderTarget(UnityEngine.Rendering.RTHandle renderTarget, UnityEngine.Rect displayRect, bool supportsStereo, UnityEngine.Vector4 dataRangeRemap);
                /*0x7c2e574*/ void ResetDebugRenderTarget();
                /*0x7c2e57c*/ UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData InitDebugFinalValidationPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c2ea34*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c2ebcc*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isFinalPass);
                /*0x7c2f418*/ UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData InitDebugSetupPassData(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData passData, bool isPreviewCamera);
                /*0x7c2f834*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, bool isPreviewCamera);
                /*0x7c2f838*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isPreviewCamera);
                /*0x7c2fc5c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);
                /*0x7c2fd2c*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c3031c*/ UnityEngine.Rendering.Universal.DebugRendererLists CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);

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

                    /*0x7c2ddd8*/ DebugFinalValidationPassData();
                }

                class DebugSetupPassData
                {
                    /*0x10*/ bool isActiveForCamera;
                    /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial materialSettings;
                    /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering renderingSettings;
                    /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting lightingSettings;

                    /*0x7c2ddd0*/ DebugSetupPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DebugHandler.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__101_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__106_0;

                    static /*0x7c30e8c*/ <>c();
                    /*0x7c30ef4*/ <>c();
                    /*0x7c30efc*/ void <UpdateShaderGlobalPropertiesForFinalValidationPass>b__101_0(UnityEngine.Rendering.Universal.DebugHandler.DebugFinalValidationPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c30f60*/ void <Setup>b__106_0(UnityEngine.Rendering.Universal.DebugHandler.DebugSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class DebugRendererLists
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DebugRenderSetup> m_DebugRenderSetups;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererList> m_ActiveDebugRendererList;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> m_ActiveDebugRendererListHdl;

                /*0x7c2fde8*/ DebugRendererLists(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c30f64*/ void CreateDebugRenderSetups(UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c31114*/ void DisposeDebugRenderLists();
                /*0x7c2ff54*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c303d8*/ void CreateRendererListsWithDebugRenderState(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c316ec*/ void PrepareRendererListForRasterPass(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder);
                /*0x7c318c4*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd);
            }

            class DebugRenderSetup : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x38*/ int m_Index;

                /*0x7c310c0*/ DebugRenderSetup(UnityEngine.Rendering.Universal.DebugHandler debugHandler, int index, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x7c31cb8*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x7c31cdc*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x7c31d00*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x7c31b34*/ void Begin(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c31c4c*/ void End(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c31d24*/ void CreateRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x7c31e40*/ void CreateRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl);
                /*0x7c31ba0*/ void DrawWithRendererList(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rendererList);
                /*0x7c312cc*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.DrawingSettings drawingSettings);
                /*0x7c313e0*/ UnityEngine.Rendering.RenderStateBlock GetRenderStateBlock(UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x7c31f5c*/ int GetIndex();
                /*0x7c312c8*/ void Dispose();
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

                /*0x7c32250*/ UniversalRenderPipelineDebugDisplaySettings();
                /*0x7c31f64*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon get_commonSettings();
                /*0x7c31f6c*/ void set_commonSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon value);
                /*0x7c31f74*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_materialSettings();
                /*0x7c31f7c*/ void set_materialSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial value);
                /*0x7c31f84*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_renderingSettings();
                /*0x7c31f8c*/ void set_renderingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering value);
                /*0x7c31f94*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_lightingSettings();
                /*0x7c31f9c*/ void set_lightingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting value);
                /*0x7c31fa4*/ UnityEngine.Rendering.DebugDisplaySettingsVolume get_volumeSettings();
                /*0x7c31fac*/ void set_volumeSettings(UnityEngine.Rendering.DebugDisplaySettingsVolume value);
                /*0x7c31fb4*/ UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> get_displayStats();
                /*0x7c31fbc*/ void set_displayStats(UnityEngine.Rendering.DebugDisplaySettingsStats<UnityEngine.Rendering.Universal.URPProfileId> value);
                /*0x7c31fc4*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer get_gpuResidentDrawerSettings();
                /*0x7c31fcc*/ void set_gpuResidentDrawerSettings(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer value);
                /*0x7c31fd4*/ bool get_IsPostProcessingAllowed();
                /*0x7c322cc*/ void Reset();
                /*0x7c327b8*/ void UpdateDisplayStats();
                /*0x7c32818*/ void UpdateMaterials();
            }

            class UniversalRenderPipelineDebugDisplayStats : UnityEngine.Rendering.DebugDisplayStats<UnityEngine.Rendering.Universal.URPProfileId>
            {
                /*0x30*/ UnityEngine.Rendering.DebugFrameTiming m_DebugFrameTiming;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.URPProfileId> m_RecordedSamplers;

                /*0x7c3264c*/ UniversalRenderPipelineDebugDisplayStats();
                /*0x7c328bc*/ void EnableProfilingRecorders();
                /*0x7c32914*/ void DisableProfilingRecorders();
                /*0x7c32aa8*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
                /*0x7c32f38*/ void Update();
                /*0x7c32f98*/ bool <RegisterDebugUI>b__4_0();
                /*0x7c32fa0*/ void <RegisterDebugUI>b__4_1(bool value);
                /*0x7c32fac*/ bool <RegisterDebugUI>b__4_2();
                /*0x7c32fb4*/ void <RegisterDebugUI>b__4_3(bool value);
            }

            class UniversalRenderPipelineVolumeDebugSettings : UnityEngine.Rendering.VolumeDebugSettings<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>
            {
                /*0x7c3274c*/ UniversalRenderPipelineVolumeDebugSettings();
                /*0x7c32fc0*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
                /*0x7c33100*/ UnityEngine.LayerMask get_selectedCameraLayerMask();
                /*0x7c331f0*/ UnityEngine.Vector3 get_selectedCameraPosition();
                /*0x7c332f0*/ System.Type get_targetRenderPipeline();
            }

            class DBufferCopyDepthPass : UnityEngine.Rendering.Universal.Internal.CopyDepthPass
            {
                /*0x7c33350*/ DBufferCopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth);
                /*0x7c33368*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            }

            class DecalDrawDBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c335cc*/ DecalDrawDBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c33798*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
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

                static /*0x7c36788*/ DBufferRenderPass();
                static /*0x7c3503c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList, bool renderGraph);
                static /*0x7c34bb0*/ void SetGlobalTextures(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x7c34cd8*/ void SetKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                static /*0x7c34dc4*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x7c337e8*/ DBufferRenderPass(UnityEngine.Material dBufferClear, UnityEngine.Rendering.Universal.DBufferSettings settings, UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem, bool decalLayers);
                /*0x7c337b0*/ UnityEngine.Rendering.RTHandle[] get_dBufferColorHandles();
                /*0x7c337b8*/ void set_dBufferColorHandles(UnityEngine.Rendering.RTHandle[] value);
                /*0x7c337c8*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                /*0x7c337d0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                /*0x7c337e0*/ UnityEngine.Rendering.RTHandle get_dBufferDepth();
                /*0x7c33f0c*/ void Dispose();
                /*0x7c33fa0*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c340e4*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle depthTextureHandle);
                /*0x7c3441c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c346e8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c34a64*/ void InitPassData(ref UnityEngine.Rendering.Universal.DBufferRenderPass.PassData passData);
                /*0x7c34f00*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c352d0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c36690*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

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

                    /*0x7c33f04*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__36_0;

                    static /*0x7c36934*/ <>c();
                    /*0x7c3699c*/ <>c();
                    /*0x7c369a4*/ void <RecordRenderGraph>b__36_0(UnityEngine.Rendering.Universal.DBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawFowardEmissiveSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c36a54*/ DecalDrawFowardEmissiveSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c36ad0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalForwardEmissivePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData m_PassData;

                static /*0x7c371fc*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c36ae8*/ DecalForwardEmissivePass(UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem);
                /*0x7c36e0c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c37098*/ void InitPassData(ref UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData passData);
                /*0x7c370bc*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c3726c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c36e04*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__10_0;

                    static /*0x7c378a8*/ <>c();
                    /*0x7c37910*/ <>c();
                    /*0x7c37918*/ void <RecordRenderGraph>b__10_0(UnityEngine.Rendering.Universal.DecalForwardEmissivePass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawErrorSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x40*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;

                /*0x7c37978*/ DecalDrawErrorSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, UnityEngine.Rendering.Universal.DecalTechnique technique);
                /*0x7c37a00*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x7c37a70*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
            }

            class DecalPreviewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalPreviewPass.PassData m_PassData;

                static /*0x7c38124*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalPreviewPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c37b5c*/ DecalPreviewPass();
                /*0x7c37dec*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c3816c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c37de4*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalPreviewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalPreviewPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__8_0;

                    static /*0x7c38870*/ <>c();
                    /*0x7c388d8*/ <>c();
                    /*0x7c388e0*/ void <RecordRenderGraph>b__8_0(UnityEngine.Rendering.Universal.DecalPreviewPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c38930*/ void add_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c389e8*/ void remove_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38aa0*/ void add_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38b5c*/ void remove_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38c18*/ void add_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38cd4*/ void remove_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38d90*/ void add_onAllDecalPropertyChange(System.Action value);
                static /*0x7c38e4c*/ void remove_onAllDecalPropertyChange(System.Action value);
                static /*0x7c38f08*/ void add_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c38fc4*/ void remove_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x7c39080*/ UnityEngine.Material get_defaultMaterial();
                static /*0x7c390c8*/ void set_defaultMaterial(UnityEngine.Material value);
                static /*0x7c39118*/ bool get_isSupported();
                static /*0x7c396e0*/ void UpdateAllDecalProperties();
                /*0x7c39744*/ DecalProjector();
                /*0x7c39168*/ UnityEngine.Rendering.Universal.DecalEntity get_decalEntity();
                /*0x7c39170*/ void set_decalEntity(UnityEngine.Rendering.Universal.DecalEntity value);
                /*0x7c39178*/ UnityEngine.Material get_material();
                /*0x7c39180*/ void set_material(UnityEngine.Material value);
                /*0x7c392a0*/ float get_drawDistance();
                /*0x7c392a8*/ void set_drawDistance(float value);
                /*0x7c392b8*/ float get_fadeScale();
                /*0x7c392c0*/ void set_fadeScale(float value);
                /*0x7c392dc*/ float get_startAngleFade();
                /*0x7c392e4*/ void set_startAngleFade(float value);
                /*0x7c39304*/ float get_endAngleFade();
                /*0x7c3930c*/ void set_endAngleFade(float value);
                /*0x7c3932c*/ UnityEngine.Vector2 get_uvScale();
                /*0x7c39334*/ void set_uvScale(UnityEngine.Vector2 value);
                /*0x7c3933c*/ UnityEngine.Vector2 get_uvBias();
                /*0x7c39344*/ void set_uvBias(UnityEngine.Vector2 value);
                /*0x7c3934c*/ uint get_renderingLayerMask();
                /*0x7c39354*/ void set_renderingLayerMask(uint value);
                /*0x7c3935c*/ UnityEngine.Rendering.Universal.DecalScaleMode get_scaleMode();
                /*0x7c39364*/ void set_scaleMode(UnityEngine.Rendering.Universal.DecalScaleMode value);
                /*0x7c3936c*/ UnityEngine.Vector3 get_pivot();
                /*0x7c39378*/ void set_pivot(UnityEngine.Vector3 value);
                /*0x7c39384*/ UnityEngine.Vector3 get_size();
                /*0x7c39390*/ void set_size(UnityEngine.Vector3 value);
                /*0x7c3939c*/ float get_fadeFactor();
                /*0x7c393a4*/ void set_fadeFactor(float value);
                /*0x7c393c0*/ UnityEngine.Vector3 get_effectiveScale();
                /*0x7c3942c*/ UnityEngine.Vector3 get_decalSize();
                /*0x7c39438*/ UnityEngine.Vector3 get_decalOffset();
                /*0x7c39448*/ UnityEngine.Vector4 get_uvScaleBias();
                /*0x7c39454*/ void InitMaterial();
                /*0x7c394b4*/ void OnEnable();
                /*0x7c39538*/ void OnDisable();
                /*0x7c3919c*/ void OnValidate();
                /*0x7c395a4*/ bool IsValid();

                class DecalProjectorAction : System.MulticastDelegate
                {
                    /*0x7c39784*/ DecalProjectorAction(object object, nint method);
                    /*0x7c3988c*/ void Invoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                    /*0x7c398a0*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector, System.AsyncCallback callback, object object);
                    /*0x7c398c0*/ void EndInvoke(System.IAsyncResult result);
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

                /*0x7c399e0*/ DecalChunk();
                /*0x7c398cc*/ int get_count();
                /*0x7c398d4*/ void set_count(int value);
                /*0x7c398dc*/ int get_capacity();
                /*0x7c398e4*/ void set_capacity(int value);
                /*0x7c398ec*/ Unity.Jobs.JobHandle get_currentJobHandle();
                /*0x7c398f8*/ void set_currentJobHandle(Unity.Jobs.JobHandle value);
                /*0x7c39900*/ void Push();
                /*0x3815ed0*/ void RemoveAtSwapBack(int index);
                /*0x3815ed0*/ void SetCapacity(int capacity);
                /*0x7c39910*/ void Dispose();
                /*0x7c39914*/ void ResizeNativeArray(ref UnityEngine.Jobs.TransformAccessArray array, UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors, int capacity);
                void RemoveAtSwapBack<T>(ref Unity.Collections.NativeArray<T> array, int index, int count);
                void RemoveAtSwapBack<T>(ref T[] array, int index, int count);
            }

            struct DecalSubDrawCall
            {
                /*0x10*/ int start;
                /*0x14*/ int end;

                /*0x7c399e8*/ int get_count();
            }

            class DecalDrawCallChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecals;
                /*0x48*/ Unity.Collections.NativeArray<float> renderingLayerMasks;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                /*0x68*/ Unity.Collections.NativeArray<int> subCallCounts;

                /*0x7c39c80*/ DecalDrawCallChunk();
                /*0x7c399f4*/ void set_subCallCount(int value);
                /*0x7c39a00*/ int get_subCallCount();
                /*0x7c39a0c*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c39af4*/ void SetCapacity(int newCapacity);
                /*0x7c39bb4*/ void Dispose();
            }

            class DecalCreateDrawCallSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ float m_MaxDrawDistance;

                /*0x7c39c98*/ DecalCreateDrawCallSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float maxDrawDistance);
                /*0x7c39c88*/ float get_maxDrawDistance();
                /*0x7c39c90*/ void set_maxDrawDistance(float value);
                /*0x7c39d4c*/ void Execute();
                /*0x7c39f5c*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk, int count);

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

                    /*0x7c3a160*/ void Execute();
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

                static /*0x7c3b454*/ DecalDrawSystem();
                /*0x7c33648*/ DecalDrawSystem(string sampler, UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c3a47c*/ UnityEngine.Material get_overrideMaterial();
                /*0x7c3a484*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x7c3a48c*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c350ac*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd);
                /*0x7c3a664*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
                /*0x381467c*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x7c3a4fc*/ void Execute(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x7c3a8d8*/ void Draw(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x7c3a67c*/ void DrawInstanced(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x7c3abe4*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c3ae04*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x7c3b1f8*/ void Draw(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
                /*0x7c3af58*/ void DrawInstanced(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
            }

            class DecalEntityIndexer
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem> m_Entities;
                /*0x18*/ System.Collections.Generic.Queue<int> m_FreeIndices;

                /*0x7c3b9dc*/ DecalEntityIndexer();
                /*0x7c3b4a0*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c3b528*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex);
                /*0x7c3b6ac*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c3b75c*/ UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem GetItem(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c3b7bc*/ void UpdateIndex(UnityEngine.Rendering.Universal.DecalEntity decalEntity, int newArrayIndex);
                /*0x7c3b858*/ void RemapChunkIndices(System.Collections.Generic.List<int> remaper);
                /*0x7c3b96c*/ void Clear();

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

                /*0x7c3bc7c*/ DecalEntityChunk();
                /*0x7c3bab8*/ void Push();
                /*0x7c3bac8*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c3bb74*/ void SetCapacity(int newCapacity);
                /*0x7c3bc08*/ void Dispose();
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

                /*0x7c3bc84*/ DecalEntityManager();
                /*0x7c37a88*/ UnityEngine.Material get_errorMaterial();
                /*0x7c3ab24*/ UnityEngine.Mesh get_decalProjectorMesh();
                /*0x7c3bfe8*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c3c000*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c3c57c*/ int CreateChunkIndex(UnityEngine.Material material);
                /*0x7c3ce88*/ void UpdateAllDecalEntitiesData();
                /*0x7c3cb28*/ void UpdateDecalEntityData(UnityEngine.Rendering.Universal.DecalEntity decalEntity, UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c3d0a8*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x7c3d280*/ void Update();
                /*0x7c3dc68*/ void Dispose();

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

                    static /*0x7c3e614*/ <>c();
                    /*0x7c3e67c*/ <>c();
                    /*0x7c3e684*/ int <Update>b__26_0(UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks a, UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks b);
                }
            }

            class DecalSkipCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Camera m_Camera;

                static /*0x7c3ea08*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x7c3e73c*/ DecalSkipCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c3e7dc*/ void Execute(UnityEngine.Camera camera);
                /*0x7c3e95c*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
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

                /*0x7c3ce78*/ DecalCachedChunk();
                /*0x7c3ea10*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c3ed08*/ void SetCapacity(int newCapacity);
                /*0x7c3ef70*/ void Dispose();
            }

            class DecalUpdateCachedSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler m_SamplerJob;

                /*0x7c3f178*/ DecalUpdateCachedSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c3f25c*/ void Execute();
                /*0x7c3f418*/ void Execute(UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, int count);

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

                    static /*0x7c3fe50*/ UpdateTransformsJob();
                    /*0x7c3f6c8*/ float DistanceBetweenQuaternions(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
                    /*0x7c3f6f8*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
                    /*0x7c3fcc4*/ UnityEngine.BoundingSphere GetDecalProjectBoundingSphere(UnityEngine.Matrix4x4 decalToWorld);
                }
            }

            class DecalUpdateCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                /*0x7c3ffb8*/ DecalUpdateCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c40058*/ void Execute();
                /*0x7c401bc*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
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

                /*0x7c3ce80*/ DecalCulledChunk();
                /*0x7c4025c*/ void RemoveAtSwapBack(int entityIndex);
                /*0x7c402f8*/ void SetCapacity(int newCapacity);
                /*0x7c403c0*/ void Dispose();
            }

            class DecalUpdateCullingGroupSystem
            {
                /*0x10*/ float[] m_BoundingDistance;
                /*0x18*/ UnityEngine.Camera m_Camera;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                static /*0x7c408b4*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x7c404a4*/ DecalUpdateCullingGroupSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float drawDistance);
                /*0x7c40454*/ float get_boundingDistance();
                /*0x7c4047c*/ void set_boundingDistance(float value);
                /*0x7c405a0*/ void Execute(UnityEngine.Camera camera);
                /*0x7c40774*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalDrawGBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c408bc*/ DecalDrawGBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c40938*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
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

                static /*0x7c413b8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c40950*/ DecalGBufferRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem, bool decalLayers);
                /*0x7c40c70*/ void Setup(UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                /*0x7c40c78*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c4103c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c41350*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData passData);
                /*0x7c41524*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c42084*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x28*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c40c68*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__15_0;

                    static /*0x7c4217c*/ <>c();
                    /*0x7c421e4*/ <>c();
                    /*0x7c421ec*/ void <RecordRenderGraph>b__15_0(UnityEngine.Rendering.Universal.DecalGBufferRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                }
            }

            class DecalDrawScreenSpaceSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x7c4224c*/ DecalDrawScreenSpaceSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x7c422c8*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalScreenSpaceRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xd8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0xf0*/ bool m_DecalLayers;
                /*0xf8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData m_PassData;

                static /*0x7c42abc*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c422e0*/ DecalScreenSpaceRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem, bool decalLayers);
                /*0x7c425c4*/ UnityEngine.Rendering.RendererListParams CreateRenderListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c426fc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c42a00*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData passData);
                /*0x7c42c30*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c4341c*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings;
                    /*0x20*/ bool decalLayers;
                    /*0x21*/ bool isGLDevice;
                    /*0x24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c425bc*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__12_0;

                    static /*0x7c43514*/ <>c();
                    /*0x7c4357c*/ <>c();
                    /*0x7c43584*/ void <RecordRenderGraph>b__12_0(UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c44964*/ ScriptableRenderPass();
                static /*0x7c4387c*/ UnityEngine.Rendering.Universal.DebugHandler GetActiveDebugHandler(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c447a8*/ bool op_LessThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x7c447d0*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x7c447f8*/ int GetRenderPassEventRange(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent);
                /*0x7c33bb0*/ ScriptableRenderPass();
                /*0x7c4367c*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c43688*/ UnityEngine.Rendering.Universal.RenderPassEvent get_renderPassEvent();
                /*0x7c43690*/ void set_renderPassEvent(UnityEngine.Rendering.Universal.RenderPassEvent value);
                /*0x7c43698*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachments();
                /*0x7c436e4*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachment();
                /*0x7c43730*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthAttachment();
                /*0x7c4377c*/ UnityEngine.Rendering.RTHandle[] get_colorAttachmentHandles();
                /*0x7c43784*/ UnityEngine.Rendering.RTHandle get_colorAttachmentHandle();
                /*0x7c437ac*/ UnityEngine.Rendering.RTHandle get_depthAttachmentHandle();
                /*0x7c437b4*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
                /*0x7c437bc*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
                /*0x7c437c4*/ bool[] get_overriddenColorStoreActions();
                /*0x7c437cc*/ bool get_overriddenDepthStoreAction();
                /*0x7c437d4*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput get_input();
                /*0x7c437dc*/ UnityEngine.Rendering.ClearFlag get_clearFlag();
                /*0x7c437e4*/ UnityEngine.Color get_clearColor();
                /*0x7c437f0*/ bool get_requiresIntermediateTexture();
                /*0x7c437f8*/ void set_requiresIntermediateTexture(bool value);
                /*0x7c34b04*/ UnityEngine.Rendering.ProfilingSampler get_profilingSampler();
                /*0x7c33ea8*/ void set_profilingSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7c43804*/ string get_passName();
                /*0x7c4380c*/ bool get_overrideCameraTarget();
                /*0x7c43814*/ void set_overrideCameraTarget(bool value);
                /*0x7c43820*/ bool get_isBlitRenderPass();
                /*0x7c43828*/ void set_isBlitRenderPass(bool value);
                /*0x7c43834*/ bool get_useNativeRenderPass();
                /*0x7c4383c*/ void set_useNativeRenderPass(bool value);
                /*0x7c43848*/ bool get_breakGBufferAndDeferredRenderPass();
                /*0x7c43850*/ void set_breakGBufferAndDeferredRenderPass(bool value);
                /*0x7c4385c*/ int get_renderPassQueueIndex();
                /*0x7c43864*/ void set_renderPassQueueIndex(int value);
                /*0x7c4386c*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_renderTargetFormat();
                /*0x7c43874*/ void set_renderTargetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                /*0x7c438c4*/ void ConfigureInput(UnityEngine.Rendering.Universal.ScriptableRenderPassInput passInput);
                /*0x7c438cc*/ void ConfigureColorStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction, uint attachmentIndex);
                /*0x7c43920*/ void ConfigureColorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] storeActions);
                /*0x7c43a04*/ void ConfigureDepthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                /*0x7c43a14*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle input, bool isTransient);
                /*0x7c43aa0*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs);
                /*0x7c4100c*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs, bool[] isTransient);
                /*0x7c43aa8*/ void SetInputAttachmentTransient(int idx, bool isTransient);
                /*0x7c43adc*/ bool IsInputAttachmentTransient(int idx);
                /*0x7c43b0c*/ void ResetTarget();
                /*0x7c43ba4*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x7c43bf0*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x7c43cb8*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x7c34424*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x7c43d04*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat[] formats);
                /*0x7c43d80*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment);
                /*0x7c43dcc*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment);
                /*0x7c43e3c*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments);
                /*0x7c43e88*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments);
                /*0x7c43ef8*/ void ConfigureClear(UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                /*0x7c43f08*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c43f0c*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c43f10*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c43f14*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c43f18*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c43fd0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c44088*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                /*0x7c440d4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int passIndex);
                /*0x7c441f4*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Material material, int passIndex);
                /*0x7c44304*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Material material, int passIndex);
                /*0x7c44360*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c444a8*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c44584*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x7c446cc*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
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

                static /*0x7c528a4*/ ScriptableRenderer();
                static /*0x7c47f68*/ uint GetSubPassAttachmentIndicesCount(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x7c480f4*/ bool AreAttachmentIndicesCompatible(UnityEngine.Rendering.Universal.ScriptableRenderPass lastSubPass, UnityEngine.Rendering.Universal.ScriptableRenderPass currentSubPass);
                static /*0x7c48228*/ uint GetValidColorAttachmentCount(UnityEngine.Rendering.AttachmentDescriptor[] colorAttachments);
                static /*0x7c481e0*/ int GetValidInputAttachmentCount(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x7c47334*/ int FindAttachmentDescriptorIndexInList(int attachmentIdx, UnityEngine.Rendering.AttachmentDescriptor attachmentDescriptor, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x7c462fc*/ int FindAttachmentDescriptorIndexInList(UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x7c454d8*/ int GetValidPassIndexCount(int[] array);
                static /*0x7c45844*/ UnityEngine.Rendering.RTHandle GetFirstAllocatedRTHandle(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x7c463e0*/ bool PassHasInputAttachments(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x7c48370*/ UnityEngine.Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex);
                static /*0x7c45448*/ UnityEngine.Hash128 CreateRenderPassHash(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex);
                static /*0x7c4839c*/ void GetRenderTextureDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.RenderTextureDescriptor targetRT);
                static /*0x7c48674*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices);
                static /*0x7c48bd8*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices);
                static /*0x7c4873c*/ void SetCameraMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped);
                static /*0x7c49568*/ void CalculateBillboardProperties(ref UnityEngine.Matrix4x4 worldToCameraMatrix, ref UnityEngine.Vector3 billboardTangent, ref UnityEngine.Vector3 billboardNormal, ref float cameraXZAngle);
                static /*0x7c49b78*/ void SetShaderTimeValues(UnityEngine.Rendering.IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime);
                static /*0x7c4fdb8*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7c4fe20*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c4ed98*/ void ClearRenderingState(UnityEngine.Rendering.IBaseCommandBuffer cmd);
                static /*0x7c51bd4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x7c52148*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x7c524d8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x7c52028*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachmentIDs, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x7c4cdb4*/ void SortStable(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> list);
                /*0x7c4a11c*/ ScriptableRenderer(UnityEngine.Rendering.Universal.ScriptableRendererData data);
                /*0x7c44a28*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepth();
                /*0x7c44a54*/ void ResetNativeRenderPassFrameData();
                /*0x7c44b9c*/ void SetupNativeRenderPassFrameData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isRenderPassEnabled);
                /*0x7c4552c*/ void UpdateFinalStoreActions(int[] currentMergeablePasses, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isLastMergeableGroup);
                /*0x7c45920*/ void SetNativeRenderPassMRTAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool needCustomCameraColorClear, UnityEngine.Rendering.ClearFlag cameraClearFlag);
                /*0x7c46724*/ bool IsDepthOnlyRenderTexture(UnityEngine.RenderTexture t);
                /*0x7c4674c*/ void SetNativeRenderPassAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle passColorAttachment, UnityEngine.Rendering.RTHandle passDepthAttachment, UnityEngine.Rendering.ClearFlag finalClearFlag, UnityEngine.Color finalClearColor);
                /*0x7c47460*/ void ExecuteNativeRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4641c*/ void SetupInputAttachmentIndices(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x7c46610*/ void SetupTransientInputAttachments(int attachmentCount);
                /*0x7c4533c*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x7c48624*/ int SupportedCameraStackingTypes();
                /*0x7c4862c*/ bool SupportsCameraStackingType(UnityEngine.Rendering.Universal.CameraRenderType cameraRenderType);
                /*0x7c48654*/ bool SupportsMotionVectors();
                /*0x7c4865c*/ UnityEngine.Rendering.ProfilingSampler get_profilingExecute();
                /*0x7c48664*/ void set_profilingExecute(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7c4866c*/ UnityEngine.Rendering.Universal.DebugHandler get_DebugHandler();
                /*0x7c48c98*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c48cec*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, bool isTargetFlipped);
                /*0x7c493ac*/ void SetPerCameraBillboardProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c49934*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c49974*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isTargetFlipped);
                /*0x7c4a000*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraColorTarget();
                /*0x7c44280*/ UnityEngine.Rendering.RTHandle get_cameraColorTargetHandle();
                /*0x7c4a04c*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4a054*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4a05c*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTarget();
                /*0x7c485a0*/ UnityEngine.Rendering.RTHandle get_cameraDepthTargetHandle();
                /*0x7c4a0a8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x7c4a0b0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> get_activeRenderPassQueue();
                /*0x7c4a0b8*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures();
                /*0x7c4a0c0*/ void set_supportedRenderingFeatures(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures value);
                /*0x7c4a0c8*/ UnityEngine.Rendering.GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes();
                /*0x7c4a0d0*/ void set_unsupportedGraphicsDeviceTypes(UnityEngine.Rendering.GraphicsDeviceType[] value);
                /*0x7c4a0d8*/ UnityEngine.Rendering.ContextContainer get_frameData();
                /*0x7c4a0e0*/ bool get_useDepthPriming();
                /*0x7c4a0e8*/ void set_useDepthPriming(bool value);
                /*0x7c4a0f4*/ bool get_stripShadowsOffVariants();
                /*0x7c4a0fc*/ void set_stripShadowsOffVariants(bool value);
                /*0x7c4a108*/ bool get_stripAdditionalLightOffVariants();
                /*0x7c4a110*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x7c4ad80*/ void Dispose();
                /*0x7c4aeb8*/ void Dispose(bool disposing);
                /*0x7c4aecc*/ void ReleaseRenderTargets();
                /*0x7c4aed0*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget);
                /*0x7c4af1c*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget);
                /*0x7c4af50*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget, UnityEngine.Rendering.RTHandle resolveTarget);
                /*0x7c4af98*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RTHandle colorTarget);
                void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4afa8*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4afac*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c4afb0*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4afb4*/ void OnBeginRenderGraphFrame();
                /*0x7c4afb8*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7c4afbc*/ void OnEndRenderGraphFrame();
                /*0x7c4afc0*/ void InitRenderGraphFrame(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c4b388*/ void ProcessVFXCameraCommand(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c4b890*/ void SetupRenderGraphCameraProperties(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isTargetBackbuffer);
                /*0x7c4bd3c*/ void DrawRenderGraphGizmos(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7c4bd40*/ void DrawRenderGraphWireOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color);
                /*0x7c4bd44*/ void BeginRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c4c28c*/ void EndRenderGraphXRRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c4c708*/ void SetEditorTarget(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c4cabc*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7c4cf14*/ void FinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4d1cc*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4d1d0*/ void RecordCustomRenderGraphPassesInEventRange(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent eventStart, UnityEngine.Rendering.Universal.RenderPassEvent eventEnd);
                /*0x7c4d35c*/ void CalculateSplitEventRange(UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent targetEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent startEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent splitEvent, ref UnityEngine.Rendering.Universal.RenderPassEvent endEvent);
                /*0x7c4d478*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x7c4d4fc*/ void RecordCustomRenderGraphPasses(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint);
                /*0x7c4d504*/ bool InterruptFramebufferFetch(UnityEngine.Rendering.Universal.FramebufferFetchEvent fetchEvent, UnityEngine.Rendering.Universal.RenderPassEvent startInjectionPoint, UnityEngine.Rendering.Universal.RenderPassEvent endInjectionPoint);
                /*0x7c4d6c8*/ void SetPerCameraProperties(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c4d80c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4fcfc*/ void EnqueuePass(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x7c4ffa8*/ void OnPreCullRenderPasses(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c5006c*/ void AddRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4ea10*/ void SetupRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4aaf8*/ void Clear(UnityEngine.Rendering.Universal.CameraRenderType cameraType);
                /*0x7c4f70c*/ void ExecuteBlock(int blockIndex, ref UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks renderBlocks, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool submit);
                /*0x7c4530c*/ bool IsRenderPassEnabled(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x7c50340*/ void ExecuteRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c51bcc*/ bool IsSceneFilteringEnabled(UnityEngine.Camera camera);
                /*0x7c507f4*/ void SetRenderPassAttachments(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c4f8e0*/ void BeginXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c4faa0*/ void EndXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c52680*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c52684*/ void EnableSwapBufferMSAA(bool enable);
                /*0x7c52688*/ void DrawGizmos(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c5268c*/ void DrawWireOverlay(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c4eba8*/ void InternalStartRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c4cf98*/ void InternalFinishRenderingCommon(UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x7c4fc54*/ void InternalFinishRenderingExecute(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, bool resolveFinalTarget);
                /*0x7c526f8*/ int AdjustAndGetScreenMSAASamples(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useIntermediateColorTarget);
                /*0x7c52894*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x7c5289c*/ bool get_supportsGPUOcclusion();

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

                    static /*0x7c530d0*/ Profiling();

                    class RenderBlock
                    {
                        static string k_Name = "RenderPassBlock";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beforeRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler mainRenderingOpaque;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler mainRenderingTransparent;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler afterRendering;

                        static /*0x7c53684*/ RenderBlock();
                    }

                    class RenderPass
                    {
                        static string k_Name = "ScriptableRenderPass";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler configure;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setRenderPassAttachments;

                        static /*0x7c537e8*/ RenderPass();
                    }
                }

                struct RenderPassDescriptor
                {
                    /*0x10*/ int w;
                    /*0x14*/ int h;
                    /*0x18*/ int samples;
                    /*0x1c*/ int depthID;

                    /*0x7c538c4*/ RenderPassDescriptor(int width, int height, int sampleCount, int rtID);
                }

                class RenderingFeatures
                {
                    /*0x10*/ bool <cameraStacking>k__BackingField;
                    /*0x11*/ bool <msaa>k__BackingField;

                    /*0x7c538f8*/ RenderingFeatures();
                    /*0x7c538d0*/ bool get_cameraStacking();
                    /*0x7c538d8*/ void set_cameraStacking(bool value);
                    /*0x7c538e4*/ bool get_msaa();
                    /*0x7c538ec*/ void set_msaa(bool value);
                }

                class RenderPassBlock
                {
                    static /*0x0*/ int BeforeRendering;
                    static /*0x4*/ int MainRenderingOpaque;
                    static /*0x8*/ int MainRenderingTransparent;
                    static /*0xc*/ int AfterRendering;

                    static /*0x7c53908*/ RenderPassBlock();
                }

                class VFXProcessCameraPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                    /*0x18*/ UnityEngine.Camera camera;
                    /*0x20*/ UnityEngine.VFX.VFXCameraXRSettings cameraXRSettings;
                    /*0x30*/ UnityEngine.Experimental.Rendering.XRPass xrPass;

                    /*0x7c53958*/ VFXProcessCameraPassData();
                }

                class DrawGizmosPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle gizmoRenderList;

                    /*0x7c53960*/ DrawGizmosPassData();
                }

                class DrawWireOverlayPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle wireOverlayList;

                    /*0x7c53968*/ DrawWireOverlayPassData();
                }

                class BeginXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c53970*/ BeginXRPassData();
                }

                class EndXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c53978*/ EndXRPassData();
                }

                class DummyData
                {
                    /*0x7c53980*/ DummyData();
                }

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x20*/ bool isTargetBackbuffer;
                    /*0x24*/ UnityEngine.Vector2Int cameraTargetSizeCopy;

                    /*0x7c53988*/ PassData();
                }

                struct RenderBlocks : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.RenderPassEvent> m_BlockEventLimits;
                    /*0x20*/ Unity.Collections.NativeArray<int> m_BlockRanges;
                    /*0x30*/ Unity.Collections.NativeArray<int> m_BlockRangeLengths;

                    /*0x7c53990*/ RenderBlocks(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x7c53c4c*/ void Dispose();
                    /*0x7c53b44*/ void FillBlockRanges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x7c53ca0*/ int GetLength(int index);
                    /*0x7c53cac*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index);

                    struct BlockRange : System.IDisposable
                    {
                        /*0x10*/ int m_Current;
                        /*0x14*/ int m_End;

                        /*0x7c53cd8*/ BlockRange(int begin, int end);
                        /*0x7c53cf4*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator();
                        /*0x7c53cfc*/ bool MoveNext();
                        /*0x7c53d18*/ int get_Current();
                        /*0x7c53d20*/ void Dispose();
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

                    static /*0x7c53d24*/ <>c();
                    /*0x7c53d8c*/ <>c();
                    /*0x7c53d94*/ void <InitRenderGraphFrame>b__138_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    /*0x7c53e44*/ void <ProcessVFXCameraCommand>b__140_0(UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c53f38*/ void <SetupRenderGraphCameraProperties>b__141_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c540a8*/ void <BeginRenderGraphXRRendering>b__147_0(UnityEngine.Rendering.Universal.ScriptableRenderer.BeginXRPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c542a0*/ void <EndRenderGraphXRRendering>b__149_0(UnityEngine.Rendering.Universal.ScriptableRenderer.EndXRPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c54410*/ void <SetEditorTarget>b__151_0(UnityEngine.Rendering.Universal.ScriptableRenderer.DummyData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
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

                /*0x7c544f4*/ ScriptableRendererData();
                /*0x7c54488*/ bool get_isInvalidated();
                /*0x7c54490*/ void set_isInvalidated(bool value);
                /*0x38148bc*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c5449c*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x7c544a4*/ void SetDirty();
                /*0x7c544b0*/ UnityEngine.Rendering.Universal.ScriptableRenderer InternalCreateRenderer();
                /*0x7c544c0*/ void OnValidate();
                /*0x7c544cc*/ void OnEnable();
                /*0x7c544d8*/ bool get_useNativeRenderPass();
                /*0x7c544e0*/ void set_useNativeRenderPass(bool value);
                /*0x38141c4*/ bool TryGetRendererFeature<T>(ref T rendererFeature);

                class DebugShaderResources
                {
                    /*0x10*/ UnityEngine.Shader debugReplacementPS;
                    /*0x18*/ UnityEngine.Shader hdrDebugViewPS;

                    /*0x7c545d8*/ DebugShaderResources();
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

                    /*0x7c545e0*/ ProbeVolumeResources();
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

                /*0x7c54620*/ Bloom();
                /*0x7c545e8*/ bool IsActive();
                /*0x7c54618*/ bool IsTileCompatible();
            }

            class XRSystemData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystemData.ShaderResources shaders;

                /*0x7c54984*/ XRSystemData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader xrOcclusionMeshPS;
                    /*0x18*/ UnityEngine.Shader xrMirrorViewPS;

                    /*0x7c5498c*/ ShaderResources();
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

                /*0x7c54da0*/ UniversalRendererData();
                /*0x7c54994*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c54a20*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c54a28*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c54a38*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c54a40*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c54a50*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x7c54a58*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x7c54a68*/ bool get_shadowTransparentReceive();
                /*0x7c54a70*/ void set_shadowTransparentReceive(bool value);
                /*0x7c54a84*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c54a8c*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c54a9c*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x7c54aa4*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x7c54ab4*/ UnityEngine.Rendering.Universal.CopyDepthMode get_copyDepthMode();
                /*0x7c54abc*/ void set_copyDepthMode(UnityEngine.Rendering.Universal.CopyDepthMode value);
                /*0x7c54acc*/ UnityEngine.Rendering.Universal.DepthFormat get_depthAttachmentFormat();
                /*0x7c54b60*/ void set_depthAttachmentFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x7c54c24*/ UnityEngine.Rendering.Universal.DepthFormat get_depthTextureFormat();
                /*0x7c54d28*/ void set_depthTextureFormat(UnityEngine.Rendering.Universal.DepthFormat value);
                /*0x7c54d38*/ bool get_accurateGbufferNormals();
                /*0x7c54d40*/ void set_accurateGbufferNormals(bool value);
                /*0x7c54d54*/ UnityEngine.Rendering.Universal.IntermediateTextureMode get_intermediateTextureMode();
                /*0x7c54d5c*/ void set_intermediateTextureMode(UnityEngine.Rendering.Universal.IntermediateTextureMode value);
                /*0x7c54d6c*/ void OnEnable();
                /*0x7c54a1c*/ void ReloadAllNullProperties();
                /*0x7c54d78*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x7c54d84*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            }

            class UniversalRenderPipelineEditorResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.MaterialResources materials;

                /*0x7c54e48*/ UniversalRenderPipelineEditorResources();

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

                    /*0x7c54e50*/ ShaderResources();
                }

                class MaterialResources
                {
                    /*0x10*/ UnityEngine.Material lit;
                    /*0x18*/ UnityEngine.Material particleLit;
                    /*0x20*/ UnityEngine.Material terrainLit;
                    /*0x28*/ UnityEngine.Material decal;

                    /*0x7c54e58*/ MaterialResources();
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

                /*0x7c54e60*/ ShaderResources();
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

                static /*0x7c54ef0*/ UnityEngine.Rendering.VolumeProfile GetOrCreateDefaultVolumeProfile(UnityEngine.Rendering.VolumeProfile defaultVolumeProfile);
                /*0x7c550a0*/ UniversalRenderPipelineGlobalSettings();
                /*0x7c54e68*/ bool get_stripUnusedLODCrossFadeVariants();
                /*0x7c54e70*/ void set_stripUnusedLODCrossFadeVariants(bool value);
                /*0x7c54e74*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
                /*0x7c54e90*/ bool IsAtLastVersion();
                /*0x7c54ea0*/ void Reset();
                /*0x7c54ef4*/ string[] get_prefixedLightLayerNames();
                /*0x7c54f38*/ string[] get_lightLayerNames();
                /*0x7c54f7c*/ void ResetRenderingLayerNames();
                /*0x7c55010*/ UnityEngine.Rendering.ProbeVolumeSceneData GetOrCreateAPVSceneData();
            }

            class URPHelpURLAttribute : UnityEngine.Rendering.CoreRPHelpURLAttribute
            {
                /*0x7c55248*/ URPHelpURLAttribute(string pageName, string pageHash);
            }

            class Documentation : UnityEngine.Rendering.DocumentationInfo
            {
                static string packageName = "com.unity.render-pipelines.universal";

                static /*0x7c552ac*/ string GetPageLink(string pageName);
                /*0x7c552f8*/ Documentation();
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

                /*0x7c5574c*/ ForwardRendererData();
                /*0x7c55300*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x7c553bc*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c55408*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c55454*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c554a0*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c554ec*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x7c55538*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x7c55584*/ bool get_shadowTransparentReceive();
                /*0x7c555d0*/ void set_shadowTransparentReceive(bool value);
                /*0x7c5561c*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c55668*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c556b4*/ bool get_accurateGbufferNormals();
                /*0x7c55700*/ void set_accurateGbufferNormals(bool value);

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

                    /*0x7c55750*/ ShaderResources();
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

                /*0x7c56160*/ Universal2DResourceData();
                /*0x7c55758*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle);
                /*0x7c55918*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] newHandle);
                /*0x7c55a10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_intermediateDepth();
                /*0x7c55abc*/ void set_intermediateDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c55b18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_lightTextures();
                /*0x7c55b20*/ void set_lightTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x7c55b30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_normalsTexture();
                /*0x7c55c20*/ void set_normalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c55d24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] get_shadowTextures();
                /*0x7c55d2c*/ void set_shadowTextures(UnityEngine.Rendering.RenderGraphModule.TextureHandle[][] value);
                /*0x7c55d3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_shadowDepth();
                /*0x7c55d44*/ void set_shadowDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c55d70*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_upscaleTexture();
                /*0x7c55d78*/ void set_upscaleTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c55da4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraSortingLayerTexture();
                /*0x7c55dac*/ void set_cameraSortingLayerTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c55dd8*/ void Reset();
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

                /*0x7c57520*/ UniversalCameraData();
                /*0x7c56220*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x7c56298*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x7c562cc*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7c56694*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7c565a0*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x7c56708*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x7c5677c*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x7c568e8*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x7c56940*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x7c569d8*/ int get_scaledWidth();
                /*0x7c56a28*/ int get_scaledHeight();
                /*0x7c56a78*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7c56a80*/ void set_historyManager(UnityEngine.Rendering.Universal.UniversalCameraHistory value);
                /*0x7c56a88*/ bool get_requireSrgbConversion();
                /*0x7c56c1c*/ bool get_isGameCamera();
                /*0x7c56c2c*/ bool get_isSceneViewCamera();
                /*0x7c56c3c*/ bool get_isPreviewCamera();
                /*0x7c56c4c*/ bool get_isRenderPassSupportedCamera();
                /*0x7c56c68*/ bool get_resolveToScreen();
                /*0x7c56d10*/ bool get_isHDROutputActive();
                /*0x7c56dc0*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x7c56eb8*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x7c56f48*/ bool get_rendersOverlayUI();
                /*0x7c56fc4*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x7c56818*/ bool IsCameraProjectionMatrixFlipped();
                /*0x7c571a8*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7c5724c*/ bool IsTemporalAARequested();
                /*0x7c5725c*/ bool IsTemporalAAEnabled();
                /*0x7c5734c*/ bool IsSTPRequested();
                /*0x7c57370*/ bool IsSTPEnabled();
                /*0x7c57394*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x7c5739c*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x7c54224*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x7c573ac*/ bool get_resetHistory();
                /*0x7c573bc*/ void Reset();
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

                /*0x7c57540*/ UniversalLightData();
                /*0x7c57528*/ void Reset();
            }

            class UniversalPostProcessingData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool isEnabled;
                /*0x14*/ UnityEngine.Rendering.Universal.ColorGradingMode gradingMode;
                /*0x18*/ int lutSize;
                /*0x1c*/ bool useFastSRGBLinearConversion;
                /*0x1d*/ bool supportScreenSpaceLensFlare;
                /*0x1e*/ bool supportDataDrivenLensFlare;

                /*0x7c57558*/ UniversalPostProcessingData();
                /*0x7c57548*/ void Reset();
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

                /*0x7c57658*/ UniversalRenderingData();
                /*0x7c57560*/ UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x7c575dc*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x7c575e4*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x7c575ec*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7c575f4*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7c575fc*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7c57604*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7c5760c*/ void Reset();
            }

            class UniversalResourceDataBase : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ bool <isAccessible>k__BackingField;

                /*0x7c56218*/ UniversalResourceDataBase();
                /*0x7c57660*/ bool get_isAccessible();
                /*0x7c57668*/ void set_isAccessible(bool value);
                /*0x7c57674*/ void InitFrame();
                /*0x7c57680*/ void EndFrame();
                /*0x7c55aec*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle newHandle);
                /*0x7c55a18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7c55c30*/ void CheckAndSetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] newHandle);
                /*0x7c55b38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] CheckAndGetTextureHandle(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle[] handle);
                /*0x7c5588c*/ bool CheckAndWarnAboutAccessibility();

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

                /*0x7c58404*/ UniversalResourceData();
                /*0x7c57688*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeColorID();
                /*0x7c57690*/ void set_activeColorID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x7c57698*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeColorTexture();
                /*0x7c5779c*/ UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID get_activeDepthID();
                /*0x7c577a4*/ void set_activeDepthID(UnityEngine.Rendering.Universal.UniversalResourceDataBase.ActiveID value);
                /*0x7c577ac*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_activeDepthTexture();
                /*0x7c578b0*/ bool get_isActiveTargetBackBuffer();
                /*0x7c57794*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferColor();
                /*0x7c5793c*/ void set_backBufferColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c578a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_backBufferDepth();
                /*0x7c5796c*/ void set_backBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c5778c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraColor();
                /*0x7c5799c*/ void set_cameraColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c578a0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepth();
                /*0x7c579cc*/ void set_cameraDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c579fc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_mainShadowsTexture();
                /*0x7c57a04*/ void set_mainShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57a34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_additionalShadowsTexture();
                /*0x7c57a3c*/ void set_additionalShadowsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57a6c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_gBuffer();
                /*0x7c57a74*/ void set_gBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c57a84*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraOpaqueTexture();
                /*0x7c57a8c*/ void set_cameraOpaqueTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57ab8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraDepthTexture();
                /*0x7c57ac0*/ void set_cameraDepthTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57aec*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_cameraNormalsTexture();
                /*0x7c57af4*/ void set_cameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57b20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorColor();
                /*0x7c57b28*/ void set_motionVectorColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57b54*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_motionVectorDepth();
                /*0x7c57b5c*/ void set_motionVectorDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57b88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_internalColorLut();
                /*0x7c57b90*/ void set_internalColorLut(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57bbc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenColor();
                /*0x7c57bc4*/ void set_debugScreenColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57bf0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_debugScreenDepth();
                /*0x7c57bf8*/ void set_debugScreenDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57c24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_afterPostProcessColor();
                /*0x7c57c2c*/ void set_afterPostProcessColor(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57c58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_overlayUITexture();
                /*0x7c57c60*/ void set_overlayUITexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57c8c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_renderingLayersTexture();
                /*0x7c57c94*/ void set_renderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57cc0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_dBuffer();
                /*0x7c57cc8*/ void set_dBuffer(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                /*0x7c57cd8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_dBufferDepth();
                /*0x7c57ce0*/ void set_dBufferDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57d0c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_ssaoTexture();
                /*0x7c57d14*/ void set_ssaoTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57d40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_stpDebugView();
                /*0x7c57d48*/ void set_stpDebugView(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7c57d74*/ void Reset();
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

                /*0x7c58570*/ UniversalShadowData();
                /*0x7c58484*/ void Reset();
            }

            class RawColorHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c58a48*/ RawColorHistory();
                /*0x7c589e4*/ RawColorHistory();
                /*0x7c58578*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c585ec*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x7c58638*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x7c58684*/ bool IsAllocated();
                /*0x7c586a0*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c58710*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c58864*/ void Reset();
                /*0x7c588c4*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x7c588fc*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class RawDepthHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_Names;
                /*0x20*/ int[] m_Ids;
                /*0x28*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x60*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c58fec*/ RawDepthHistory();
                /*0x7c58f88*/ RawDepthHistory();
                /*0x7c58b2c*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c58ba0*/ UnityEngine.Rendering.RTHandle GetCurrentTexture(int eyeIndex);
                /*0x7c58bec*/ UnityEngine.Rendering.RTHandle GetPreviousTexture(int eyeIndex);
                /*0x7c58c38*/ bool IsAllocated();
                /*0x7c58c54*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c58cc4*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c58e18*/ void Reset();
                /*0x7c58e78*/ UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x7c58ea4*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
            }

            class SingleHistoryBase : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x1c*/ int m_Id;
                /*0x20*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x58*/ UnityEngine.Hash128 m_DescKey;

                /*0x7c593a0*/ SingleHistoryBase();
                /*0x7c590d0*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c590fc*/ UnityEngine.Rendering.RTHandle GetTexture(int frameIndex);
                /*0x7c5915c*/ UnityEngine.Rendering.RTHandle GetCurrentTexture();
                /*0x7c59168*/ UnityEngine.Rendering.RTHandle GetPreviousTexture();
                /*0x7c59170*/ bool IsAllocated();
                /*0x7c5918c*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c591fc*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c592b4*/ void Reset();
                /*0x7c592c0*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                /*0x3814574*/ int GetHistoryFrameCount();
                /*0x38148bc*/ string GetHistoryName();
                UnityEngine.RenderTextureDescriptor GetHistoryDescriptor(ref UnityEngine.RenderTextureDescriptor cameraDesc);
            }

            class StpHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                /*0x20*/ UnityEngine.Rendering.STP.HistoryContext[] m_historyContexts;

                /*0x7c595d0*/ StpHistory();
                /*0x7c593a8*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c5946c*/ void Reset();
                /*0x7c594cc*/ UnityEngine.Rendering.STP.HistoryContext GetHistoryContext(int eyeIndex);
                /*0x7c594fc*/ bool Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
            }

            class TaaHistory : UnityEngine.Rendering.CameraHistoryItem
            {
                static /*0x0*/ string[] m_TaaAccumulationNames;
                /*0x20*/ int[] m_TaaAccumulationTextureIds;
                /*0x28*/ int[] m_TaaAccumulationVersions;
                /*0x30*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x68*/ UnityEngine.Hash128 m_DescKey;

                static /*0x7c59b64*/ TaaHistory();
                /*0x7c59ae4*/ TaaHistory();
                /*0x7c59634*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
                /*0x7c596a8*/ void Reset();
                /*0x7c59754*/ UnityEngine.Rendering.RTHandle GetAccumulationTexture(int eyeIndex);
                /*0x7c59788*/ int GetAccumulationVersion(int eyeIndex);
                /*0x7c597b8*/ void SetAccumulationVersion(int eyeIndex, int version);
                /*0x7c597e8*/ bool IsValid();
                /*0x7c59804*/ bool IsDirty(ref UnityEngine.RenderTextureDescriptor desc);
                /*0x7c59874*/ void Alloc(ref UnityEngine.RenderTextureDescriptor desc, bool xrMultipassEnabled);
                /*0x7c599c4*/ bool Update(ref UnityEngine.RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled);
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

                static /*0x7c5c590*/ LightCookieManager();
                /*0x7c59c74*/ LightCookieManager(ref UnityEngine.Rendering.Universal.LightCookieManager.Settings settings);
                /*0x7c59c48*/ bool get_IsKeywordLightCookieEnabled();
                /*0x7c59c50*/ void set_IsKeywordLightCookieEnabled(bool value);
                /*0x7c59c5c*/ UnityEngine.Rendering.RTHandle get_AdditionalLightsCookieAtlasTexture();
                /*0x7c59d18*/ void InitAdditionalLights(int size);
                /*0x7c59e98*/ bool isInitialized();
                /*0x7c59eb8*/ void Dispose();
                /*0x7c59f34*/ int GetLightCookieShaderDataIndex(int visibleLightIndex);
                /*0x7c59f7c*/ void Setup(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c5a1d8*/ bool SetupMainLight(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight visibleMainLight);
                /*0x7c5a810*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(UnityEngine.Experimental.Rendering.GraphicsFormat cookieFormat);
                /*0x7c5a8e4*/ void GetLightUVScaleOffset(ref UnityEngine.Rendering.Universal.UniversalAdditionalLightData additionalLightData, ref UnityEngine.Matrix4x4 uvTransform);
                /*0x7c5a5e8*/ bool SetupAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7c5ab64*/ int FilterAndValidateAdditionalLights(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] validLightMappings);
                /*0x7c5b058*/ int UpdateAdditionalLightsAtlas(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects);
                /*0x7c5ba28*/ int FetchUVRects(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects, int cookieSizeDivisor);
                /*0x7c5b900*/ uint ComputeCookieRequestPixelCount(ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings);
                /*0x7c5b9fc*/ int ApproximateCookieSizeDivisor(float requestAtlasRatio);
                /*0x7c5bde4*/ UnityEngine.Vector4 Fetch2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x7c5bc80*/ UnityEngine.Vector4 FetchCube(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x7c5bfe8*/ int ComputeOctahedralCookieSize(UnityEngine.Texture cookie);
                /*0x7c5bf3c*/ void AdjustUVRect(ref UnityEngine.Vector4 uvScaleOffset, UnityEngine.Texture cookie, ref UnityEngine.Vector2 cookieSize);
                /*0x7c5c140*/ void ShrinkUVRect(ref UnityEngine.Vector4 uvScaleOffset, float amountPixels, ref UnityEngine.Vector2 cookieSize);
                /*0x7c5b1d4*/ void UploadAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Vector4> validUvRects);

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

                    static /*0x7c5c618*/ ShaderProperty();
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

                    static /*0x7c5c884*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings Create();

                    struct AtlasSettings
                    {
                        /*0x10*/ UnityEngine.Vector2Int resolution;
                        /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;

                        /*0x7c5c114*/ bool get_isPow2();
                        /*0x7c5c950*/ bool get_isSquare();
                    }
                }

                struct LightCookieMapping
                {
                    static /*0x0*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex;
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort lightBufferIndex;
                    /*0x18*/ UnityEngine.Light light;

                    static /*0x7c5c960*/ LightCookieMapping();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping.<> <>9;

                        static /*0x7c5ca88*/ <>c();
                        /*0x7c5caf0*/ <>c();
                        /*0x7c5caf8*/ int <.cctor>b__6_0(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                        /*0x7c5cbc4*/ int <.cctor>b__6_1(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                    }
                }

                struct WorkSlice<T>
                {
                    /*0x0*/ T[] m_Data;
                    /*0x0*/ int m_Start;
                    /*0x0*/ int m_Length;

                    /*0x381678c*/ WorkSlice(T[] src, int srcLen);
                    WorkSlice(T[] src, int srcStart, int srcLen);
                    /*0x3910ae8*/ T get_Item(int index);
                    /*0x3910ae8*/ void set_Item(int index, T value);
                    /*0x3814574*/ int get_length();
                    /*0x3814574*/ int get_capacity();
                    /*0x3816710*/ void Sort(System.Func<T, T, int> compare);
                }

                class WorkMemory
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] lightMappings;
                    /*0x18*/ UnityEngine.Vector4[] uvRects;

                    /*0x7c59d10*/ WorkMemory();
                    /*0x7c5aa18*/ void Resize(int size);
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

                    /*0x7c59e64*/ LightCookieShaderData(int size, bool useStructuredBuffer);
                    /*0x7c5cbd0*/ UnityEngine.Matrix4x4[] get_worldToLights();
                    /*0x7c5cbd8*/ UnityEngine.Rendering.Universal.ShaderBitArray get_cookieEnableBits();
                    /*0x7c5cbe0*/ UnityEngine.Vector4[] get_atlasUVRects();
                    /*0x7c5cbe8*/ float[] get_lightTypes();
                    /*0x7c5cbf0*/ bool get_isUploaded();
                    /*0x7c5cbf8*/ void set_isUploaded(bool value);
                    /*0x7c59ee8*/ void Dispose();
                    /*0x7c5c1d0*/ void Resize(int size);
                    /*0x7c5c3fc*/ void Upload(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7c5a780*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                }
            }

            struct BuddyAllocation
            {
                /*0x10*/ int level;
                /*0x14*/ int index;

                /*0x7c5cc04*/ BuddyAllocation(int level, int index);
                /*0x7c5cc0c*/ Unity.Mathematics.uint2 get_index2D();
            }

            struct BuddyAllocator : System.IDisposable
            {
                /*0x10*/ void* m_Data;
                /*0x18*/ System.ValueTuple<int, int> m_ActiveFreeMaskCounts;
                /*0x20*/ System.ValueTuple<int, int> m_FreeMasksStorage;
                /*0x28*/ System.ValueTuple<int, int> m_FreeMaskIndicesStorage;
                /*0x30*/ Unity.Collections.Allocator m_Allocator;

                static /*0x7c5d4c4*/ int LevelOffset(int level, int branchingOrder);
                static /*0x7c5d4e8*/ int LevelLength(int level, int branchingOrder);
                static /*0x7c5cdd0*/ int LevelOffset64(int level, int branchingOrder);
                static /*0x7c5ce0c*/ int LevelLength64(int level, int branchingOrder);
                static /*0x3910ae8*/ System.ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize);
                static /*0x7c5d50c*/ int AlignForward(int offset, int alignment);
                static /*0x7c5d528*/ void* PtrAdd(void* ptr, int bytes);
                static /*0x7c5d330*/ int Pow2(int n);
                static /*0x7c5d4fc*/ int Pow2N(int x, int n);
                /*0x7c5cfa0*/ BuddyAllocator(int levelCount, int branchingOrder, Unity.Collections.Allocator allocator);
                /*0x7c5cc18*/ ref UnityEngine.Rendering.Universal.BuddyAllocator.Header get_header();
                /*0x7c5cc54*/ Unity.Collections.NativeArray<int> get_freeMaskCounts();
                /*0x7c5cca0*/ Unity.Collections.NativeArray<ulong> get_freeMasksStorage();
                /*0x7c5ccec*/ Unity.Collections.NativeArray<ulong> FreeMasks(int level);
                /*0x7c5ce30*/ Unity.Collections.NativeArray<int> get_freeMaskIndicesStorage();
                /*0x7c5ce7c*/ Unity.Collections.NativeArray<int> FreeMaskIndices(int level);
                /*0x7c5cf60*/ int get_levelCount();
                /*0x7c5d10c*/ bool TryAllocate(int requestedLevel, ref UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x7c5d33c*/ void Free(UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x7c5d49c*/ void Dispose();
                /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(int offset, int length);

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

                static /*0x384032c*/ void CheckRange(int index);
                /*0x3910ae8*/ Fixed2(T item1);
                /*0x3910ae8*/ Fixed2(T item1, T item2);
                /*0x3910ae8*/ T get_Item(int index);
                /*0x3910ae8*/ void set_Item(int index, T value);
            }

            struct PinnedArray<T> : System.IDisposable
            {
                /*0x0*/ T[] managedArray;
                /*0x0*/ System.Runtime.InteropServices.GCHandle handle;
                /*0x0*/ Unity.Collections.NativeArray<T> nativeArray;

                /*0x3815ed0*/ PinnedArray(int length);
                /*0x3814574*/ int get_length();
                /*0x38159dc*/ void Dispose();
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

                static /*0x7c5dc04*/ int GetXRMultiPassId(UnityEngine.Experimental.Rendering.XRPass xr);
                /*0x7c5d550*/ MotionVectorsPersistentData();
                /*0x7c5db00*/ int get_lastFrameIndex();
                /*0x7c5db28*/ UnityEngine.Matrix4x4 get_viewProjection();
                /*0x7c5db5c*/ UnityEngine.Matrix4x4 get_previousViewProjection();
                /*0x7c5db90*/ UnityEngine.Matrix4x4[] get_viewProjectionStereo();
                /*0x7c5db98*/ UnityEngine.Matrix4x4[] get_previousViewProjectionStereo();
                /*0x7c5dba0*/ UnityEngine.Matrix4x4[] get_projectionStereo();
                /*0x7c5dba8*/ UnityEngine.Matrix4x4[] get_previousProjectionStereo();
                /*0x7c5dbb0*/ UnityEngine.Matrix4x4[] get_previousPreviousProjectionStereo();
                /*0x7c5dbb8*/ UnityEngine.Matrix4x4[] get_viewStereo();
                /*0x7c5dbc0*/ UnityEngine.Matrix4x4[] get_previousViewStereo();
                /*0x7c5dbc8*/ UnityEngine.Matrix4x4[] get_previousPreviousViewStereo();
                /*0x7c5dbd0*/ float get_deltaTime();
                /*0x7c5dbd8*/ float get_lastDeltaTime();
                /*0x7c5dbe0*/ UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x7c5dbec*/ UnityEngine.Vector3 get_previousWorldSpaceCameraPos();
                /*0x7c5dbf8*/ UnityEngine.Vector3 get_previousPreviousWorldSpaceCameraPos();
                /*0x7c5d6e8*/ void Reset();
                /*0x7c5dc34*/ void Update(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c5e5b4*/ void SetGlobalMotionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr);
            }

            struct Sorting
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_QuickSortSampler;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler s_InsertionSortSampler;

                static /*0x7c5e750*/ Sorting();
                static /*0x3843dfc*/ void QuickSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x3842ee0*/ void QuickSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x3910ae8*/ T Median3Pivot<T>(T[] data, int start, int pivot, int end, System.Func<T, T, int> compare);
                static int Partition<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                static /*0x3843dfc*/ void InsertionSort<T>(T[] data, System.Func<T, T, int> compare);
                static /*0x3842ee0*/ void InsertionSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
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
                /*0x7c54924*/ DownscaleParameter(UnityEngine.Rendering.Universal.BloomDownscaleMode value, bool overrideState);
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

                /*0x7c5e988*/ ChannelMixer();
                /*0x7c5e82c*/ bool IsActive();
                /*0x7c5e980*/ bool IsTileCompatible();
            }

            class ChromaticAberration : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;

                /*0x7c5ec04*/ ChromaticAberration();
                /*0x7c5ebcc*/ bool IsActive();
                /*0x7c5ebfc*/ bool IsTileCompatible();
            }

            class ColorAdjustments : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.FloatParameter postExposure;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contrast;
                /*0x48*/ UnityEngine.Rendering.ColorParameter colorFilter;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShift;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter saturation;

                /*0x7c5ed70*/ ColorAdjustments();
                /*0x7c5ec80*/ bool IsActive();
                /*0x7c5ed68*/ bool IsTileCompatible();
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

                /*0x7c5ef24*/ ColorCurves();
                /*0x7c5ef14*/ bool IsActive();
                /*0x7c5ef1c*/ bool IsTileCompatible();
            }

            class ColorLookup : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureParameter texture;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contribution;

                /*0x7c5f838*/ ColorLookup();
                /*0x7c5f59c*/ bool IsActive();
                /*0x7c5f830*/ bool IsTileCompatible();
                /*0x7c5f5e0*/ bool ValidateLUT();
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

                /*0x7c5f984*/ DepthOfField();
                /*0x7c5f8fc*/ bool IsActive();
                /*0x7c5f97c*/ bool IsTileCompatible();
            }

            class DepthOfFieldModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.DepthOfFieldMode>
            {
                /*0x7c5fc64*/ DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode value, bool overrideState);
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

                /*0x7c5fda4*/ FilmGrain();
                /*0x7c5fcc4*/ bool IsActive();
                /*0x7c5fd9c*/ bool IsTileCompatible();
            }

            class FilmGrainLookupParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.FilmGrainLookup>
            {
                /*0x7c5fedc*/ FilmGrainLookupParameter(UnityEngine.Rendering.Universal.FilmGrainLookup value, bool overrideState);
            }

            class LensDistortion : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter xMultiplier;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter yMultiplier;
                /*0x50*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter scale;

                /*0x7c5ffc8*/ LensDistortion();
                /*0x7c5ff3c*/ bool IsActive();
                /*0x7c5ffc0*/ bool IsTileCompatible();
            }

            class LiftGammaGain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter lift;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter gamma;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter gain;

                /*0x7c601e0*/ LiftGammaGain();
                /*0x7c60130*/ bool IsActive();
                /*0x7c601d8*/ bool IsTileCompatible();
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

                /*0x7c60308*/ MotionBlur();
                /*0x7c602d0*/ bool IsActive();
                /*0x7c60300*/ bool IsTileCompatible();
            }

            class MotionBlurModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurMode>
            {
                /*0x7c60440*/ MotionBlurModeParameter(UnityEngine.Rendering.Universal.MotionBlurMode value, bool overrideState);
            }

            class MotionBlurQualityParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurQuality>
            {
                /*0x7c604a0*/ MotionBlurQualityParameter(UnityEngine.Rendering.Universal.MotionBlurQuality value, bool overrideState);
            }

            class PaniniProjection : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter distance;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter cropToFit;

                /*0x7c60538*/ PaniniProjection();
                /*0x7c60500*/ bool IsActive();
                /*0x7c60530*/ bool IsTileCompatible();
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

                /*0x7c605e8*/ ScreenSpaceLensFlare();
                /*0x7c60ad0*/ bool IsActive();
                /*0x7c60b00*/ bool IsStreaksActive();
                /*0x7c60b30*/ bool IsTileCompatible();
            }

            class ScreenSpaceLensFlareResolutionParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution>
            {
                /*0x7c60a70*/ ScreenSpaceLensFlareResolutionParameter(UnityEngine.Rendering.Universal.ScreenSpaceLensFlareResolution value, bool overrideState);
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

                /*0x7c60be8*/ ShadowsMidtonesHighlights();
                /*0x7c60b38*/ bool IsActive();
                /*0x7c60be0*/ bool IsTileCompatible();
            }

            class SplitToning : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter shadows;
                /*0x40*/ UnityEngine.Rendering.ColorParameter highlights;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter balance;

                /*0x7c60e4c*/ SplitToning();
                /*0x7c60dbc*/ bool IsActive();
                /*0x7c60e44*/ bool IsTileCompatible();
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

                /*0x7c60fac*/ Tonemapping();
                /*0x7c60f74*/ bool IsActive();
                /*0x7c60fa4*/ bool IsTileCompatible();
            }

            class TonemappingModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.TonemappingMode>
            {
                /*0x7c6120c*/ TonemappingModeParameter(UnityEngine.Rendering.Universal.TonemappingMode value, bool overrideState);
            }

            class NeutralRangeReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.NeutralRangeReductionMode>
            {
                /*0x7c6126c*/ NeutralRangeReductionModeParameter(UnityEngine.Rendering.Universal.NeutralRangeReductionMode value, bool overrideState);
            }

            class HDRACESPresetParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.HDRACESPreset>
            {
                /*0x7c612cc*/ HDRACESPresetParameter(UnityEngine.Rendering.Universal.HDRACESPreset value, bool overrideState);
            }

            class Vignette : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter color;
                /*0x40*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter smoothness;
                /*0x58*/ UnityEngine.Rendering.BoolParameter rounded;

                /*0x7c61364*/ Vignette();
                /*0x7c6132c*/ bool IsActive();
                /*0x7c6135c*/ bool IsTileCompatible();
            }

            class WhiteBalance : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter temperature;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter tint;

                /*0x7c6156c*/ WhiteBalance();
                /*0x7c61508*/ bool IsActive();
                /*0x7c61564*/ bool IsTileCompatible();
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

                static /*0x7c62780*/ void ClearStaticCaches();
                static /*0x7c62688*/ int EstimateScaleFactorNeededToFitAllShadowsInAtlas(ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasSize);
                static /*0x7c62588*/ System.Func<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest, int> CreateCompareShadowResolutionRequesPredicate();
                /*0x7c61634*/ AdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c626f8*/ int GetTotalShadowSlicesCount();
                /*0x7c62700*/ int GetTotalShadowResolutionRequestCount();
                /*0x7c62708*/ bool HasTooManyShadowMaps();
                /*0x7c62710*/ int GetShadowSlicesScaleFactor();
                /*0x7c62718*/ int GetAtlasSize();
                /*0x7c62720*/ bool HasSpaceForLight(int originalVisibleLightIndex);
                /*0x7c62734*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex);
                /*0x7c62754*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex);

                struct ShadowResolutionRequest
                {
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort perLightShadowSliceIndex;
                    /*0x14*/ ushort requestedResolution;
                    /*0x16*/ ushort offsetX;
                    /*0x18*/ ushort offsetY;
                    /*0x1a*/ ushort allocatedResolution;
                    /*0x1c*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest.SettingsOptions m_ShadowProperties;

                    /*0x7c626e0*/ bool get_softShadow();
                    /*0x7c62658*/ void set_softShadow(bool value);
                    /*0x7c626ec*/ bool get_pointLightShadow();
                    /*0x7c62668*/ void set_pointLightShadow(bool value);

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

                    static /*0x7c62824*/ <>c();
                    /*0x7c6288c*/ <>c();
                    /*0x7c62894*/ int <CreateCompareShadowResolutionRequesPredicate>b__24_0(UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest curr, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout.ShadowResolutionRequest other);
                }
            }

            class CapturePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.RTHandle m_CameraColorHandle;

                /*0x7c62a18*/ CapturePass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c62ad4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c62de4*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                    /*0x20*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;

                    /*0x7c6329c*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.CapturePass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.CapturePass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__4_0;

                    static /*0x7c632a4*/ <>c();
                    /*0x7c6330c*/ <>c();
                    /*0x7c63314*/ void <RecordRenderGraph>b__4_0(UnityEngine.Rendering.Universal.CapturePass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext unsafeContext);
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

                static /*0x7c6537c*/ DrawScreenSpaceUIPass();
                static /*0x7c63658*/ void ConfigureColorDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x7c6368c*/ void ConfigureDepthDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight);
                static /*0x7c636cc*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c63714*/ void ExecutePass(UnityEngine.Rendering.UnsafeCommandBuffer commandBuffer, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData passData, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c63570*/ DrawScreenSpaceUIPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool renderOffscreen);
                /*0x7c6375c*/ void Dispose();
                /*0x7c63790*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x7c63938*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c63b60*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c63d54*/ void RenderOffscreen(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle output);
                /*0x7c649d4*/ void RenderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                    /*0x7c63650*/ PassData();
                }

                class UnsafePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;

                    /*0x7c65418*/ UnsafePassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_1;
                    static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__18_0;
                    static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__18_1;

                    static /*0x7c65420*/ <>c();
                    /*0x7c65488*/ <>c();
                    /*0x7c65490*/ void <RenderOffscreen>b__17_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c65534*/ void <RenderOffscreen>b__17_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c65660*/ void <RenderOverlay>b__18_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c65704*/ void <RenderOverlay>b__18_1(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.UnsafePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                }
            }

            class DrawSkyboxPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x7c65c1c*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Rendering.RendererList rendererList);
                /*0x7c65830*/ DrawSkyboxPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c658cc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c659f8*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c65d10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyBoxRendererList(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c65e8c*/ void InitPassData(ref UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData passData, ref UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x7c65ef0*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Material skyboxMaterial);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle skyRendererListHandle;
                    /*0x28*/ UnityEngine.Material material;

                    /*0x7c665cc*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawSkyboxPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                    static /*0x7c665d4*/ <>c();
                    /*0x7c6663c*/ <>c();
                    /*0x7c66644*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class HDRDebugViewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy m_PassDataCIExy;
                /*0xc0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView m_PassDataDebugView;
                /*0xc8*/ UnityEngine.Rendering.RTHandle m_CIExyTarget;
                /*0xd0*/ UnityEngine.Rendering.RTHandle m_PassthroughRT;
                /*0xd8*/ UnityEngine.Material m_material;

                static /*0x7c66820*/ void ConfigureDescriptorForCIEPrepass(ref UnityEngine.RenderTextureDescriptor descriptor);
                static /*0x7c668e8*/ UnityEngine.Vector4 GetLuminanceParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c66a6c*/ void ExecuteCIExyPrepass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                static /*0x7c66cec*/ void ExecuteHDRDebugViewFinalPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle xyTarget);
                /*0x7c666a0*/ HDRDebugViewPass(UnityEngine.Material mat);
                /*0x7c6709c*/ void Dispose();
                /*0x7c670d0*/ void Setup(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.HDRDebugMode hdrdebugMode);
                /*0x7c6725c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c67438*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy dataCIExy, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView dataDebugView, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                /*0x7c676a8*/ void RenderHDRDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor, UnityEngine.Rendering.Universal.HDRDebugMode hdrDebugMode);

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

                    /*0x7c66810*/ PassDataCIExy();
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

                    /*0x7c66818*/ PassDataDebugView();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _DebugHDRModeId;
                    static /*0x4*/ int _HDRDebugParamsId;
                    static /*0x8*/ int _xyTextureId;
                    static /*0xc*/ int _SizeOfHDRXYMapping;
                    static /*0x10*/ int _CIExyUAVIndex;

                    static /*0x7c683a0*/ ShaderConstants();
                    /*0x7c68398*/ ShaderConstants();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x7c68474*/ <>c();
                    /*0x7c684dc*/ <>c();
                    /*0x7c684e4*/ void <RenderHDRDebug>b__17_0(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataCIExy data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c685cc*/ void <RenderHDRDebug>b__17_1(UnityEngine.Rendering.Universal.HDRDebugViewPass.PassDataDebugView data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class InvokeOnRenderObjectCallbackPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x7c68694*/ InvokeOnRenderObjectCallbackPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c68754*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6877c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget;

                    /*0x7c68c14*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__3_0;

                    static /*0x7c68c1c*/ <>c();
                    /*0x7c68c84*/ <>c();
                    /*0x7c68c8c*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
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

                static /*0x7c6a9bc*/ MotionVectorRenderPass();
                static /*0x7c68f60*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c69764*/ UnityEngine.Rendering.DrawingSettings GetDrawingSettings(UnityEngine.Camera camera, bool supportsDynamicBatching);
                static /*0x7c69070*/ void DrawCameraMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, UnityEngine.Material cameraMaterial);
                static /*0x7c691ec*/ void DrawObjectMotionVectors(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Experimental.Rendering.XRPass xr, ref UnityEngine.Rendering.RendererList rendererList);
                static /*0x7c6a468*/ void SetMotionVectorGlobalMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7c6a52c*/ void SetRenderGraphMotionVectorGlobalMatrices(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c68cac*/ MotionVectorRenderPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material cameraMaterial, UnityEngine.LayerMask opaqueLayerMask);
                /*0x7c68e54*/ void Setup(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7c68e84*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x7c692a4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c694cc*/ void InitPassData(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c6952c*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, ref UnityEngine.Rendering.CullingResults cullResults, bool supportsDynamicBatching, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x7c699c8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle motionVectorDepth);

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

                    /*0x7c68e4c*/ PassData();
                }

                class MotionMatrixPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData motionData;
                    /*0x18*/ UnityEngine.Experimental.Rendering.XRPass xr;

                    /*0x7c6aaf4*/ MotionMatrixPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__26_0;

                    static /*0x7c6aafc*/ <>c();
                    /*0x7c6ab64*/ <>c();
                    /*0x7c6ab6c*/ void <Render>b__23_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c6acd0*/ void <SetRenderGraphMotionVectorGlobalMatrices>b__26_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.MotionMatrixPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                static /*0x7c7f030*/ PostProcessPass();
                static /*0x7c6e6a0*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(UnityEngine.RenderTextureDescriptor desc, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                static /*0x7c73264*/ float GetMaxBokehRadiusInPixels(float viewportHeight);
                static /*0x7c7327c*/ float GetLensFlareLightAttenuation(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                static /*0x7c734d4*/ void UpdateMotionBlurMatrices(ref UnityEngine.Material material, UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7c7b538*/ void ScaleViewportAndBlit(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTextureHdl, UnityEngine.Rendering.RTHandle dest, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material, bool hasFinalPass);
                /*0x7c6acf8*/ PostProcessPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x7c6b794*/ void Cleanup();
                /*0x7c6b924*/ void Dispose();
                /*0x7c6bb00*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.RTHandle source, bool resolveToScreen, ref UnityEngine.Rendering.RTHandle depth, ref UnityEngine.Rendering.RTHandle internalLut, ref UnityEngine.Rendering.RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding);
                /*0x7c6bc4c*/ void SetupFinalPass(ref UnityEngine.Rendering.RTHandle source, bool useSwapBuffer, bool enableColorEncoding);
                /*0x7c6bcf8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6bd04*/ bool CanRunOnTile();
                /*0x7c6bd0c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6b6ac*/ bool IsHDRFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x7c6b73c*/ bool IsAlphaFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                /*0x7c6e53c*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor();
                /*0x7c6e5b0*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
                /*0x7c6e6f0*/ bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion);
                /*0x7c6e70c*/ bool RequireHDROutput(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c6cb58*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c6e9e8*/ void DoSubpixelMorphologicalAntialiasing(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x7c6efb8*/ void DoDepthOfField(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x7c72248*/ void DoGaussianDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x7c73000*/ void PrepareBokehKernel(float maxRadius, float rcpAspect);
                /*0x7c729ec*/ void DoBokehDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect, bool enableAlphaOutput);
                /*0x7c7072c*/ void LensFlareDataDrivenComputeOcclusion(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x7c70e40*/ void LensFlareDataDriven(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x7c700d0*/ void DoLensFlareScreenSpace(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RTHandle originalBloomTexture, UnityEngine.Rendering.RTHandle screenSpaceLensFlareBloomMipTexture);
                /*0x7c6f0ac*/ void DoMotionBlur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle motionVectors, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c6f344*/ void DoPaniniProjection(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x7c736dc*/ UnityEngine.Vector2 CalcViewExtents(UnityEngine.Camera camera);
                /*0x7c73738*/ UnityEngine.Vector2 CalcCropExtents(UnityEngine.Camera camera, float d);
                /*0x7c6f578*/ void SetupBloom(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Material uberMaterial, bool enableAlphaOutput);
                /*0x7c71628*/ void SetupLensDistortion(UnityEngine.Material material, bool isSceneView);
                /*0x7c71900*/ void SetupChromaticAberration(UnityEngine.Material material);
                /*0x7c719f4*/ void SetupVignette(UnityEngine.Material material, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7c71c48*/ void SetupColorGrading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material material);
                /*0x7c71fa4*/ void SetupGrain(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x7c72054*/ void SetupDithering(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Material material);
                /*0x7c720f0*/ void SetupHDROutput(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperations, bool rendersOverlayUI);
                /*0x7c6c1b4*/ void RenderFinalPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c7378c*/ void UpdateCameraResolution(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int newCameraTargetSize);
                /*0x7c73ba4*/ void RenderStopNaN(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget);
                /*0x7c7417c*/ void RenderSMAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle SMAATarget);
                /*0x7c75848*/ void UberPostSetupBloomPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph rendergraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle bloomTexture, UnityEngine.Material uberMaterial);
                /*0x7c7600c*/ void RenderBloomTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x7c76fd8*/ void RenderDoF(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c77290*/ void RenderDoFGaussian(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x7c77e1c*/ void RenderDoFBokeh(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Material dofMaterial);
                /*0x7c78970*/ void RenderPaniniProjection(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c790f0*/ void RenderTemporalAA(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c79300*/ void RenderSTP(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c795b0*/ void RenderMotionBlur(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c79ed0*/ void LensFlareDataDrivenComputeOcclusion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c7a4fc*/ void RenderLensFlareDataDriven(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination);
                /*0x7c7abc4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle RenderLensFlareScreenSpace(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle originalBloomTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle screenSpaceLensFlareBloomMipTexture, bool enableXR);
                /*0x7c7b778*/ void RenderFinalSetup(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x7c7be20*/ void RenderFinalFSRScale(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool enableAlphaOutput);
                /*0x7c7c370*/ void RenderFinalBlit(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, ref UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings);
                /*0x7c7ca7c*/ void RenderFinalPassRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded);
                /*0x7c7d118*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle TryGetCachedUserLutTextureHandle(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7c7d328*/ void RenderUberPost(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool resolveToDebugScreen, bool hasFinalPass);
                /*0x7c7e008*/ void RenderPostProcessingRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle activeCameraColorTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle lutTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded);
                /*0x7c6e748*/ UnityEngine.Rendering.RTHandle <Render>g__GetSource|89_0(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x7c6e750*/ UnityEngine.Rendering.RTHandle <Render>g__GetDestination|89_1(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x7c6e8b0*/ void <Render>g__Swap|89_2(ref UnityEngine.Rendering.Universal.ScriptableRenderer r, ref UnityEngine.Rendering.Universal.PostProcessPass.<> );

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

                    /*0x7c6b3b0*/ MaterialLibrary(UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x7c7f204*/ UnityEngine.Material Load(UnityEngine.Shader shader);
                    /*0x7c6b7b8*/ void Cleanup();
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

                    static /*0x7c7f370*/ ShaderConstants();
                }

                class UpdateCameraResolutionPassData
                {
                    /*0x10*/ UnityEngine.Vector2Int newCameraTargetSize;

                    /*0x7c7fc0c*/ UpdateCameraResolutionPassData();
                }

                class StopNaNsPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle stopNaNTarget;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material stopNaN;

                    /*0x7c7fc14*/ StopNaNsPassData();
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

                    /*0x7c7fc1c*/ SMAASetupPassData();
                }

                class SMAAPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthStencilTexture;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle blendTexture;
                    /*0x50*/ UnityEngine.Material material;

                    /*0x7c7fc24*/ SMAAPassData();
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

                    /*0x7c7fc2c*/ UberSetupBloomPassData();
                }

                class BloomPassData
                {
                    /*0x10*/ int mipCount;
                    /*0x18*/ UnityEngine.Material material;
                    /*0x20*/ UnityEngine.Material[] upsampleMaterials;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipUp;
                    /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] bloomMipDown;

                    /*0x7c7fc34*/ BloomPassData();
                }

                struct BloomMaterialParams
                {
                    /*0x10*/ UnityEngine.Vector4 parameters;
                    /*0x20*/ bool highQualityFiltering;
                    /*0x21*/ bool enableAlphaOutput;

                    /*0x7c7fc3c*/ bool Equals(ref UnityEngine.Rendering.Universal.PostProcessPass.BloomMaterialParams other);
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

                    /*0x7c7fca4*/ DoFGaussianPassData();
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

                    /*0x7c7fd08*/ DoFBokehPassData();
                }

                class PaniniProjectionPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.RenderTextureDescriptor sourceTextureDesc;
                    /*0x68*/ UnityEngine.Material material;
                    /*0x70*/ UnityEngine.Vector4 paniniParams;
                    /*0x80*/ bool isPaniniGeneric;

                    /*0x7c7fd10*/ PaniniProjectionPassData();
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

                    /*0x7c7fd18*/ MotionBlurPassData();
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

                    /*0x7c7fd20*/ LensFlarePassData();
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

                    /*0x7c7fd28*/ LensFlareScreenSpacePassData();
                }

                class PostProcessingFinalSetupPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;

                    /*0x7c7fd30*/ PostProcessingFinalSetupPassData();
                }

                class PostProcessingFinalFSRScalePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ bool enableAlphaOutput;

                    /*0x7c7fd38*/ PostProcessingFinalFSRScalePassData();
                }

                class PostProcessingFinalBlitPassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destinationTexture;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTexture;
                    /*0x30*/ UnityEngine.Material material;
                    /*0x38*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x40*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings settings;

                    /*0x7c7fd40*/ PostProcessingFinalBlitPassData();
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

                    static /*0x7c7fd48*/ UnityEngine.Rendering.Universal.PostProcessPass.FinalBlitSettings Create();
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

                    /*0x7c7fd54*/ UberPostPassData();
                }

                class PostFXSetupPassData
                {
                    /*0x7c7fd5c*/ PostFXSetupPassData();
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

                    static /*0x7c7fd64*/ <>c();
                    /*0x7c7fdcc*/ <>c();
                    /*0x7c7fdd4*/ float <LensFlareDataDriven>b__98_0(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c7fe64*/ float <LensFlareDataDriven>b__98_1(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c7fef4*/ void <UpdateCameraResolution>b__122_0(UnityEngine.Rendering.Universal.PostProcessPass.UpdateCameraResolutionPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c7ff88*/ void <RenderStopNaN>b__124_0(UnityEngine.Rendering.Universal.PostProcessPass.StopNaNsPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c800d0*/ void <RenderSMAA>b__127_0(UnityEngine.Rendering.Universal.PostProcessPass.SMAASetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c8026c*/ void <RenderSMAA>b__127_1(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c803b4*/ void <RenderSMAA>b__127_2(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c804fc*/ void <RenderSMAA>b__127_3(UnityEngine.Rendering.Universal.PostProcessPass.SMAAPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c806a4*/ void <UberPostSetupBloomPass>b__129_0(UnityEngine.Rendering.Universal.PostProcessPass.UberSetupBloomPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c80878*/ void <RenderBloomTexture>b__132_0(UnityEngine.Rendering.Universal.PostProcessPass.BloomPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c80f38*/ void <RenderDoFGaussian>b__135_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFGaussianPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c81a40*/ void <RenderDoFBokeh>b__137_0(UnityEngine.Rendering.Universal.PostProcessPass.DoFBokehPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c822ac*/ void <RenderPaniniProjection>b__139_0(UnityEngine.Rendering.Universal.PostProcessPass.PaniniProjectionPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c82488*/ void <RenderMotionBlur>b__145_0(UnityEngine.Rendering.Universal.PostProcessPass.MotionBlurPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c827dc*/ void <LensFlareDataDrivenComputeOcclusion>b__147_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c82d90*/ void <RenderLensFlareDataDriven>b__148_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlarePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext ctx);
                    /*0x7c83590*/ float <RenderLensFlareDataDriven>b__148_1(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c83620*/ float <RenderLensFlareDataDriven>b__148_2(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                    /*0x7c836b0*/ void <RenderLensFlareScreenSpace>b__150_0(UnityEngine.Rendering.Universal.PostProcessPass.LensFlareScreenSpacePassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    /*0x7c83ac8*/ void <RenderFinalSetup>b__153_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c83ba8*/ void <RenderFinalFSRScale>b__155_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalFSRScalePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c83d9c*/ void <RenderFinalBlit>b__158_0(UnityEngine.Rendering.Universal.PostProcessPass.PostProcessingFinalBlitPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c841b0*/ void <RenderUberPost>b__162_0(UnityEngine.Rendering.Universal.PostProcessPass.UberPostPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7c84448*/ void <RenderPostProcessingRenderGraph>b__164_0(UnityEngine.Rendering.Universal.PostProcessPass.PostFXSetupPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                /*0x7c84544*/ ProbeVolumeDebugPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.ComputeShader computeShader);
                /*0x7c84610*/ void Setup(UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RTHandle normalBuffer);
                /*0x7c84640*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c848f0*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthPyramidBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer);

                class WriteApvData
                {
                    /*0x10*/ UnityEngine.ComputeShader computeShader;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle resultBuffer;
                    /*0x24*/ UnityEngine.Vector2 clickCoordinates;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;
                    /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle normalBuffer;

                    /*0x7c84f10*/ WriteApvData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__7_0;

                    static /*0x7c84f18*/ <>c();
                    /*0x7c84f80*/ <>c();
                    /*0x7c84f88*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.ProbeVolumeDebugPass.WriteApvData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
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

                static /*0x7c85f5c*/ void ExecutePass(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList, bool isYFlipped);
                /*0x7c852e0*/ RenderObjectsPass(string profilerTag, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c85810*/ RenderObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c8513c*/ UnityEngine.Material get_overrideMaterial();
                /*0x7c85144*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x7c8514c*/ int get_overrideMaterialPassIndex();
                /*0x7c85154*/ void set_overrideMaterialPassIndex(int value);
                /*0x7c8515c*/ UnityEngine.Shader get_overrideShader();
                /*0x7c85164*/ void set_overrideShader(UnityEngine.Shader value);
                /*0x7c8516c*/ int get_overrideShaderPassIndex();
                /*0x7c85174*/ void set_overrideShaderPassIndex(int value);
                /*0x7c8517c*/ void SetDetphState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x7c85184*/ void SetDepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                /*0x7c851f0*/ void SetStencilState(int reference, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOp, UnityEngine.Rendering.StencilOp failOp, UnityEngine.Rendering.StencilOp zFailOp);
                /*0x7c85414*/ void Init(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                /*0x7c85940*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c85b80*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData);
                /*0x7c85bd4*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.RenderObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                /*0x7c86dc4*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                    /*0x38*/ UnityEngine.Rendering.Universal.DebugRendererLists debugRendererLists;
                    /*0x40*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                    /*0x48*/ UnityEngine.Rendering.RendererList rendererList;

                    /*0x7c85938*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderObjectsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__33_0;

                    static /*0x7c87b1c*/ <>c();
                    /*0x7c87b84*/ <>c();
                    /*0x7c87b8c*/ void <RecordRenderGraph>b__33_0(UnityEngine.Rendering.Universal.RenderObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
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

                static /*0x7c8af28*/ ScreenSpaceAmbientOcclusionPass();
                static /*0x7c88110*/ bool IsAfterOpaquePass(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x7c8aab8*/ void RenderAndSetBaseMap(ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material mat, ref UnityEngine.Rendering.RTHandle baseMap, ref UnityEngine.Rendering.RTHandle target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                static /*0x7c8a90c*/ void GetPassOrder(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.BlurTypes blurType, bool isAfterOpaque, ref int[] textureIndices, ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] shaderPasses);
                /*0x7c87cdc*/ ScreenSpaceAmbientOcclusionPass();
                /*0x7c87c6c*/ bool get_isRendererDeferred();
                /*0x7c87f50*/ bool Setup(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings featureSettings, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material material, ref UnityEngine.Texture2D[] blueNoiseTextures);
                /*0x7c88138*/ void SetupKeywordsAndParameters(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c88bd4*/ void InitSSAOPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data);
                /*0x7c88c34*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c89690*/ void CreateRenderTextureHandles(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle aoTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle blurTexture, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle finalTexture);
                /*0x7c89a3c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c8a2c8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c8adb0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7c8ae78*/ void Dispose();

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

                    /*0x7c889f8*/ SSAOMaterialParams(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic);
                    /*0x7c88ae4*/ bool Equals(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOMaterialParams other);
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

                    /*0x7c87f48*/ SSAOPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__52_0;

                    static /*0x7c8b424*/ <>c();
                    /*0x7c8b48c*/ <>c();
                    /*0x7c8b494*/ void <RecordRenderGraph>b__52_0(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass.SSAOPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
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

                static /*0x7c8bb30*/ RenderPassEventsEnumValues();
            }

            class TransparentSettingsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ bool m_shouldReceiveShadows;

                static /*0x7c8c0c0*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                /*0x7c8bec4*/ TransparentSettingsPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool shadowReceiveSupported);
                /*0x7c8bf94*/ bool Setup();
                /*0x7c8bfa4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
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

                static /*0x7c8d880*/ XRDepthMotionPass();
                static /*0x7c8c53c*/ UnityEngine.Rendering.DrawingSettings GetObjectMotionDrawingSettings(UnityEngine.Camera camera);
                /*0x7c8c148*/ XRDepthMotionPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader xrMotionVector);
                /*0x7c8c708*/ void InitObjectMotionRendererLists(ref UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Camera camera);
                /*0x7c8c924*/ void InitPassData(ref UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c8c980*/ void ImportXRMotionColorAndDepth(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c8cd84*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7c8c41c*/ void ResetMotionData();
                /*0x7c8d45c*/ void Update(ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7c8d804*/ void Dispose();

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objMotionRendererList;
                    /*0x20*/ UnityEngine.Matrix4x4[] previousViewProjectionStereo;
                    /*0x28*/ UnityEngine.Matrix4x4[] viewProjectionStereo;
                    /*0x30*/ UnityEngine.Material xrMotionVector;

                    /*0x7c8c39c*/ PassData();
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData passData;

                    /*0x7c8d454*/ <>c__DisplayClass17_0();
                    /*0x7c8d8fc*/ void <Render>b__0(UnityEngine.Rendering.Universal.XRDepthMotionPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class XROcclusionMeshPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xb8*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData m_PassData;
                /*0xc0*/ bool m_IsActiveTargetBackBuffer;

                static /*0x7c8db48*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data);
                /*0x7c8da48*/ XROcclusionMeshPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x7c8dbd4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c8dc84*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.XRPass xr;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment;
                    /*0x38*/ bool isActiveTargetBackBuffer;

                    /*0x7c8db40*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                    static /*0x7c8e344*/ <>c();
                    /*0x7c8e3ac*/ <>c();
                    /*0x7c8e3b4*/ void <Render>b__6_0(UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            struct PostProcessParams
            {
                /*0x10*/ UnityEngine.Material blitMaterial;
                /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat requestColorFormat;

                static /*0x7c8e3bc*/ UnityEngine.Rendering.Universal.PostProcessParams Create();
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

                /*0x7c8e470*/ PostProcessPasses(UnityEngine.Rendering.Universal.PostProcessData rendererPostProcessData, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x7c8e3e8*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x7c8e3f0*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x7c8e3f8*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x7c8e400*/ UnityEngine.Rendering.RTHandle get_afterPostProcessColor();
                /*0x7c8e408*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x7c8e410*/ bool get_isCreated();
                /*0x7c8e518*/ void Recreate(UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams ppParams);
                /*0x7c8e75c*/ void Dispose();
                /*0x7c8e7c0*/ void ReleaseRenderTargets();
            }

            class PostProcessUtils
            {
                static /*0x7c8e814*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x7c8e878*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x7c8ea0c*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x7c8ea70*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x7c826e4*/ void SetSourceSize(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source);
                static /*0x7c819d4*/ void SetSourceSize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source);

                class ShaderConstants
                {
                    static /*0x0*/ int _Grain_Texture;
                    static /*0x4*/ int _Grain_Params;
                    static /*0x8*/ int _Grain_TilingParams;
                    static /*0xc*/ int _BlueNoise_Texture;
                    static /*0x10*/ int _Dithering_Params;
                    static /*0x14*/ int _SourceSize;

                    static /*0x7c8ed30*/ ShaderConstants();
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

                static /*0x7c8ee9c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager Create();
                /*0x7c8ee8c*/ UnityEngine.RenderTexture get_atlasRT();
                /*0x7c8ee94*/ UnityEngine.Rendering.RTHandle get_atlasRTHandle();
                /*0x7c8eedc*/ void Init();
                /*0x7c8f3b8*/ void UpdateGpuData(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults);
                /*0x7c90d88*/ Unity.Mathematics.float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip);
                /*0x7c90e4c*/ void Dispose();

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

                    static /*0x7c90f0c*/ ShaderProperties();
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

                /*0x7c91068*/ DBufferSettings();
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

                /*0x7c91078*/ DecalScreenSpaceSettings();
            }

            class DecalSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalTechniqueOption technique;
                /*0x14*/ float maxDrawDistance;
                /*0x18*/ bool decalLayers;
                /*0x20*/ UnityEngine.Rendering.Universal.DBufferSettings dBufferSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings screenSpaceSettings;

                /*0x7c91080*/ DecalSettings();
            }

            class SharedDecalEntityManager : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x18*/ int m_ReferenceCounter;

                /*0x7c91628*/ SharedDecalEntityManager();
                /*0x7c91090*/ UnityEngine.Rendering.Universal.DecalEntityManager Get();
                /*0x7c91334*/ void Release(UnityEngine.Rendering.Universal.DecalEntityManager decalEntityManager);
                /*0x7c91350*/ void Dispose();
                /*0x7c91510*/ void OnDecalAdd(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c91564*/ void OnDecalRemove(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c91588*/ void OnDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x7c915e4*/ void OnAllDecalPropertyChange();
                /*0x7c91600*/ void OnDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
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

                static /*0x7c92aac*/ DecalRendererFeature();
                static /*0x7c91630*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager get_sharedDecalEntityManager();
                static /*0x7c916bc*/ bool get_isGLDevice();
                /*0x7c92a38*/ DecalRendererFeature();
                /*0x7c91688*/ ref UnityEngine.Rendering.Universal.DecalSettings get_settings();
                /*0x7c91690*/ bool get_intermediateRendering();
                /*0x7c916a0*/ bool get_requiresDecalLayers();
                /*0x7c916f0*/ void Create();
                /*0x7c9175c*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x7c919c4*/ UnityEngine.Rendering.Universal.DBufferSettings GetDBufferSettings();
                /*0x7c91a44*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings GetScreenSpaceSettings();
                /*0x7c91ac0*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRendererData renderer);
                /*0x7c91be8*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x7c91808*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques);
                /*0x7c91cc4*/ bool IsAutomaticDBuffer();
                /*0x7c91d90*/ bool RecreateSystemsIfNeeded(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c92434*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7c92574*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c92724*/ bool SupportsNativeRenderPass();
                /*0x7c92738*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c92914*/ void Dispose(bool disposing);
                /*0x7c92a34*/ void ChangeAdaptivePerformanceDrawDistances();
            }

            class DisallowMultipleRendererFeature : System.Attribute
            {
                /*0x10*/ string <customTitle>k__BackingField;

                /*0x7c92b38*/ DisallowMultipleRendererFeature(string customTitle);
                /*0x7c92b28*/ void set_customTitle(string value);
                /*0x7c92b30*/ string get_customTitle();
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

                /*0x7c92e30*/ RenderObjects();
                /*0x7c92b68*/ void Create();
                /*0x7c92d78*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c92e28*/ bool SupportsNativeRenderPass();

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

                    /*0x7c92e98*/ RenderObjectsSettings();

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

                    /*0x7c92fe4*/ FilterSettings();
                }

                class CustomCameraSettings
                {
                    /*0x10*/ bool overrideCamera;
                    /*0x11*/ bool restoreCamera;
                    /*0x14*/ UnityEngine.Vector4 offset;
                    /*0x24*/ float cameraFieldOfView;

                    /*0x7c93010*/ CustomCameraSettings();
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

                /*0x7c87f14*/ ScreenSpaceAmbientOcclusionSettings();

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

                /*0x7c93460*/ ScreenSpaceAmbientOcclusion();
                /*0x7c93028*/ ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings get_settings();
                /*0x7c93030*/ void Create();
                /*0x7c930ec*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c933e4*/ void Dispose(bool disposing);
                /*0x7c932e4*/ bool GetMaterials();
            }

            class ScreenSpaceShadowsSettings
            {
                /*0x7c934f8*/ ScreenSpaceShadowsSettings();
            }

            class ScreenSpaceShadows : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

                /*0x7c93cd8*/ ScreenSpaceShadows();
                /*0x7c93500*/ void Create();
                /*0x7c93940*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c93c3c*/ void Dispose(bool disposing);
                /*0x7c937cc*/ bool LoadMaterial();

                class ScreenSpaceShadowsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Material m_Material;
                    /*0xc0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_CurrentSettings;
                    /*0xc8*/ UnityEngine.Rendering.RTHandle m_RenderTarget;
                    /*0xd0*/ int m_ScreenSpaceShadowmapTextureID;
                    /*0xd8*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData m_PassData;

                    static /*0x7c946d4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RTHandle target);
                    /*0x7c935d8*/ ScreenSpaceShadowsPass();
                    /*0x7c93cc4*/ void Dispose();
                    /*0x7c93ba4*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings featureSettings, UnityEngine.Material material);
                    /*0x7c93d4c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7c93ed0*/ void InitPassData(ref UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData passData);
                    /*0x7c93f18*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                    /*0x7c94808*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle target;
                        /*0x20*/ UnityEngine.Material material;
                        /*0x28*/ int shadowmapID;

                        /*0x7c93d44*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__11_0;

                        static /*0x7c94a60*/ <>c();
                        /*0x7c94ac8*/ <>c();
                        /*0x7c94ad0*/ void <RecordRenderGraph>b__11_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }

                class ScreenSpaceShadowsPostPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.RTHandle k_CurrentActive;

                    static /*0x7c952c4*/ ScreenSpaceShadowsPostPass();
                    static /*0x7c94bb8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7c93724*/ ScreenSpaceShadowsPostPass();
                    /*0x7c94b54*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7c94c80*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7c94e10*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass pass;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;

                        /*0x7c95388*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                        static /*0x7c95390*/ <>c();
                        /*0x7c953f8*/ <>c();
                        /*0x7c95400*/ void <RecordRenderGraph>b__6_0(UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    }
                }
            }

            class RenderingLayerUtils
            {
                static /*0x7c95468*/ void CombineRendererEvents(bool isDeferred, int msaaSampleCount, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event rendererEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent);
                static /*0x7c9549c*/ bool RequireRenderingLayers(UnityEngine.Rendering.Universal.UniversalRenderer universalRenderer, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x7c9550c*/ bool RequireRenderingLayers(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, UnityEngine.Rendering.Universal.RenderingMode renderingMode, bool accurateGbufferNormals, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x7c95838*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c958a4*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c959b8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c95a40*/ uint ToValidRenderingLayers(uint renderingLayers);
                static /*0x7c95804*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize GetMaskSize(int bits);
                static /*0x7c9596c*/ int GetBits(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x7c95490*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.Event a, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event b);
                static /*0x7c957f8*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize a, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize b);

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

                static /*0x7c9a28c*/ RenderingUtils();
                static /*0x7c95b1c*/ UnityEngine.Rendering.AttachmentDescriptor get_emptyAttachment();
                static /*0x7c95b80*/ UnityEngine.Mesh get_fullscreenMesh();
                static /*0x7c96148*/ bool get_useStructuredBuffer();
                static /*0x7c96150*/ bool SupportsLightLayers(UnityEngine.Rendering.GraphicsDeviceType type);
                static /*0x7c96158*/ UnityEngine.Material get_errorMaterial();
                static /*0x7c962f0*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x7c86338*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x7c963f0*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle rTHandle);
                static /*0x7c96564*/ void SetScaleBiasRt(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7c96708*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x7c968cc*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destinationColor, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle destinationDepthStencil, UnityEngine.Rendering.RenderBufferLoadAction depthStencilLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStencilStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x7c96ad0*/ void FinalBlit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int passIndex);
                static /*0x7c96fbc*/ void CreateRendererParamsObjectsWithError(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererListParams param);
                static /*0x7c9729c*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c97410*/ void CreateRendererListObjectsWithError(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x7c9752c*/ void DrawRendererListObjectsWithError(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c86b20*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RendererList rl);
                static /*0x7c86838*/ void CreateRendererListWithRenderStateBlock(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.DrawingSettings ds, UnityEngine.Rendering.FilteringSettings fs, UnityEngine.Rendering.RenderStateBlock rsb, ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rl);
                static /*0x7c97574*/ void ClearSystemInfoCache();
                static /*0x7c975ec*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
                static /*0x7c976e4*/ bool SupportsGraphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x7c976f4*/ int GetLastValidColorBufferIndex(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x7c977a4*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x7c9787c*/ bool IsMRT(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x7c978dc*/ bool Contains(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x7c9798c*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x7c97a44*/ int IndexOf(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x7c97ad8*/ uint CountDistinct(UnityEngine.Rendering.RTHandle[] source, UnityEngine.Rendering.RTHandle value);
                static /*0x7c97c2c*/ int LastValid(UnityEngine.Rendering.RTHandle[] source);
                static /*0x7c97cf0*/ bool Contains(UnityEngine.Rendering.ClearFlag a, UnityEngine.Rendering.ClearFlag b);
                static /*0x7c97cfc*/ bool SequenceEqual(UnityEngine.Rendering.RTHandle[] left, UnityEngine.Rendering.RTHandle[] right);
                static /*0x7c97df4*/ bool MultisampleDepthResolveSupported();
                static /*0x7c97e8c*/ bool RTHandleNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc descriptor, bool scaled);
                static /*0x7c982f8*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraTargetIdentifier(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7c984b4*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c9891c*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c98d20*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x7c89d80*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c99158*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c99708*/ bool ReAllocateHandleIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name);
                static /*0x7c99cd4*/ bool SetMaxRTHandlePoolCapacity(int capacity);
                static /*0x7c9884c*/ void AddStaleResourceToPoolOrRelease(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, UnityEngine.Rendering.RTHandle handle);
                static /*0x7c99d70*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c99ec0*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c9a068*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c865fc*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x7c9a1b8*/ UnityEngine.Vector4 GetFinalBlitScaleBias(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
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

                /*0x7c9ab3c*/ Renderer2DResources();
                /*0x7c9a74c*/ int get_version();
                /*0x7c9a754*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9a75c*/ UnityEngine.Shader get_lightShader();
                /*0x7c9a764*/ void set_lightShader(UnityEngine.Shader value);
                /*0x7c9a7d8*/ UnityEngine.Shader get_projectedShadowShader();
                /*0x7c9a7e0*/ void set_projectedShadowShader(UnityEngine.Shader value);
                /*0x7c9a854*/ UnityEngine.Shader get_spriteShadowShader();
                /*0x7c9a85c*/ void set_spriteShadowShader(UnityEngine.Shader value);
                /*0x7c9a8d0*/ UnityEngine.Shader get_spriteUnshadowShader();
                /*0x7c9a8d8*/ void set_spriteUnshadowShader(UnityEngine.Shader value);
                /*0x7c9a94c*/ UnityEngine.Shader get_geometryShadowShader();
                /*0x7c9a954*/ void set_geometryShadowShader(UnityEngine.Shader value);
                /*0x7c9a9c8*/ UnityEngine.Shader get_geometryUnshadowShader();
                /*0x7c9a9d0*/ void set_geometryUnshadowShader(UnityEngine.Shader value);
                /*0x7c9aa44*/ UnityEngine.Texture2D get_fallOffLookup();
                /*0x7c9aa4c*/ void set_fallOffLookup(UnityEngine.Texture2D value);
                /*0x7c9aac0*/ UnityEngine.Shader get_copyDepthPS();
                /*0x7c9aac8*/ void set_copyDepthPS(UnityEngine.Shader value);
            }

            class UniversalRendererResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_CopyDepthPS;
                /*0x20*/ UnityEngine.Shader m_CameraMotionVector;
                /*0x28*/ UnityEngine.Shader m_StencilDeferredPS;
                /*0x30*/ UnityEngine.Shader m_DBufferClear;

                /*0x7c9ad44*/ UniversalRendererResources();
                /*0x7c9ab44*/ int get_version();
                /*0x7c9ab4c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9ab54*/ UnityEngine.Shader get_copyDepthPS();
                /*0x7c9ab5c*/ void set_copyDepthPS(UnityEngine.Shader value);
                /*0x7c9abd0*/ UnityEngine.Shader get_cameraMotionVector();
                /*0x7c9abd8*/ void set_cameraMotionVector(UnityEngine.Shader value);
                /*0x7c9ac4c*/ UnityEngine.Shader get_stencilDeferredPS();
                /*0x7c9ac54*/ void set_stencilDeferredPS(UnityEngine.Shader value);
                /*0x7c9acc8*/ UnityEngine.Shader get_decalDBufferClear();
                /*0x7c9acd0*/ void set_decalDBufferClear(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineDebugShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_DebugReplacementPS;
                /*0x18*/ UnityEngine.Shader m_HdrDebugViewPS;
                /*0x20*/ UnityEngine.ComputeShader m_ProbeVolumeSamplingDebugComputeShader;

                /*0x7c9aed0*/ UniversalRenderPipelineDebugShaders();
                /*0x7c9ad4c*/ int get_version();
                /*0x7c9ad54*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9ad5c*/ UnityEngine.Shader get_debugReplacementPS();
                /*0x7c9ad64*/ void set_debugReplacementPS(UnityEngine.Shader value);
                /*0x7c9add8*/ UnityEngine.Shader get_hdrDebugViewPS();
                /*0x7c9ade0*/ void set_hdrDebugViewPS(UnityEngine.Shader value);
                /*0x7c9ae54*/ UnityEngine.ComputeShader get_probeVolumeSamplingDebugComputeShader();
                /*0x7c9ae5c*/ void set_probeVolumeSamplingDebugComputeShader(UnityEngine.ComputeShader value);
            }

            class UniversalRenderPipelineRuntimeShaders : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Shader m_FallbackErrorShader;
                /*0x20*/ UnityEngine.Shader m_BlitHDROverlay;
                /*0x28*/ UnityEngine.Shader m_CoreBlitPS;
                /*0x30*/ UnityEngine.Shader m_CoreBlitColorAndDepthPS;
                /*0x38*/ UnityEngine.Shader m_SamplingPS;

                /*0x7c9b154*/ UniversalRenderPipelineRuntimeShaders();
                /*0x7c9aed8*/ int get_version();
                /*0x7c9aee0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9aee8*/ UnityEngine.Shader get_fallbackErrorShader();
                /*0x7c9aef0*/ void set_fallbackErrorShader(UnityEngine.Shader value);
                /*0x7c9af64*/ UnityEngine.Shader get_blitHDROverlay();
                /*0x7c9af6c*/ void set_blitHDROverlay(UnityEngine.Shader value);
                /*0x7c9afe0*/ UnityEngine.Shader get_coreBlitPS();
                /*0x7c9afe8*/ void set_coreBlitPS(UnityEngine.Shader value);
                /*0x7c9b05c*/ UnityEngine.Shader get_coreBlitColorAndDepthPS();
                /*0x7c9b064*/ void set_coreBlitColorAndDepthPS(UnityEngine.Shader value);
                /*0x7c9b0d8*/ UnityEngine.Shader get_samplingPS();
                /*0x7c9b0e0*/ void set_samplingPS(UnityEngine.Shader value);
            }

            class UniversalRenderPipelineRuntimeTextures : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.Texture2D m_BlueNoise64LTex;
                /*0x20*/ UnityEngine.Texture2D m_BayerMatrixTex;
                /*0x28*/ UnityEngine.Texture2D m_DebugFontTex;

                /*0x7c9b2e0*/ UniversalRenderPipelineRuntimeTextures();
                /*0x7c9b15c*/ int get_version();
                /*0x7c9b164*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9b16c*/ UnityEngine.Texture2D get_blueNoise64LTex();
                /*0x7c9b174*/ void set_blueNoise64LTex(UnityEngine.Texture2D value);
                /*0x7c9b1e8*/ UnityEngine.Texture2D get_bayerMatrixTex();
                /*0x7c9b1f0*/ void set_bayerMatrixTex(UnityEngine.Texture2D value);
                /*0x7c9b264*/ UnityEngine.Texture2D get_debugFontTexture();
                /*0x7c9b26c*/ void set_debugFontTexture(UnityEngine.Texture2D value);
            }

            class UniversalRenderPipelineRuntimeXRResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Shader m_xrOcclusionMeshPS;
                /*0x18*/ UnityEngine.Shader m_xrMirrorViewPS;
                /*0x20*/ UnityEngine.Shader m_xrMotionVector;

                /*0x7c9b538*/ UniversalRenderPipelineRuntimeXRResources();
                /*0x7c9b2f0*/ int get_version();
                /*0x7c9b2f8*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9b300*/ UnityEngine.Shader get_xrOcclusionMeshPS();
                /*0x7c9b308*/ void set_xrOcclusionMeshPS(UnityEngine.Shader value);
                /*0x7c9b37c*/ UnityEngine.Shader get_xrMirrorViewPS();
                /*0x7c9b384*/ void set_xrMirrorViewPS(UnityEngine.Shader value);
                /*0x7c9b3f8*/ UnityEngine.Shader get_xrMotionVector();
                /*0x7c9b400*/ void set_xrMotionVector(UnityEngine.Shader value);
                /*0x7c9b474*/ bool get_valid();
            }

            struct RenderTargetHandle
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.RenderTargetHandle CameraTarget;
                /*0x10*/ int <id>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier <rtid>k__BackingField;

                static /*0x7c9be84*/ RenderTargetHandle();
                static /*0x7c9b7f8*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetCameraTarget(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7c9bd58*/ bool op_Equality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                static /*0x7c9bdec*/ bool op_Inequality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                /*0x7c9b580*/ RenderTargetHandle(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x7c9b5f8*/ RenderTargetHandle(UnityEngine.Rendering.RTHandle rtHandle);
                /*0x7c9b540*/ void set_id(int value);
                /*0x7c9b548*/ int get_id();
                /*0x7c9b550*/ void set_rtid(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7c9b568*/ UnityEngine.Rendering.RenderTargetIdentifier get_rtid();
                /*0x7c9b8c8*/ void Init(string shaderProperty);
                /*0x7c9b93c*/ void Init(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x7c9b9b4*/ UnityEngine.Rendering.RenderTargetIdentifier Identifier();
                /*0x7c9bac4*/ bool HasInternalRenderTargetId();
                /*0x7c9bb20*/ bool Equals(UnityEngine.Rendering.Universal.RenderTargetHandle other);
                /*0x7c9bc44*/ bool Equals(object obj);
                /*0x7c9bd04*/ int GetHashCode();
            }

            class RTHandleResourcePool
            {
                static /*0x0*/ int s_CurrentStaleResourceCount;
                static /*0x4*/ int s_StaleResourceLifetime;
                static /*0x8*/ int s_StaleResourceMaxCapacity;
                /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<UnityEngine.Rendering.RTHandle, int>>> m_ResourcePool;
                /*0x18*/ System.Collections.Generic.List<int> m_RemoveList;

                static /*0x7c9d68c*/ RTHandleResourcePool();
                static /*0x7c9c848*/ bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                static /*0x7c9d448*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc CreateTextureDesc(UnityEngine.RenderTextureDescriptor desc, UnityEngine.Rendering.RenderGraphModule.TextureSizeMode textureSizeMode, int anisoLevel, float mipMapBias, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, string name);
                /*0x7c9d5ac*/ RTHandleResourcePool();
                /*0x7c9bee0*/ int get_staleResourceCapacity();
                /*0x7c9bf38*/ void set_staleResourceCapacity(int value);
                /*0x7c9c40c*/ bool AddResourceToPool(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, UnityEngine.Rendering.RTHandle resource, int currentFrameIndex);
                /*0x7c9c668*/ bool TryGetResource(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc, ref UnityEngine.Rendering.RTHandle resource, bool usepool);
                /*0x7c9bfd4*/ void Cleanup();
                /*0x7c9c8bc*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x7c9ce18*/ void LogDebugInfo();
                /*0x7c9c610*/ int GetHashCodeWithNameHash(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc texDesc);
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

                /*0x7c9d920*/ ScriptableRendererFeature();
                /*0x7c9d6e4*/ bool get_isActive();
                /*0x38159dc*/ void Create();
                /*0x7c9d6ec*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x3816810*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c9d6f0*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7c9d6f4*/ void OnEnable();
                /*0x7c9d7c0*/ void OnValidate();
                /*0x7c9d88c*/ bool SupportsNativeRenderPass();
                /*0x7c9d894*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x7c9d8a4*/ void SetActive(bool active);
                /*0x7c9d8b0*/ void Dispose();
                /*0x7c9d91c*/ void Dispose(bool disposing);
            }

            class RenderGraphSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.RenderGraphSettings.Version m_Version;
                /*0x14*/ bool m_EnableRenderCompatibilityMode;

                /*0x7c9da58*/ RenderGraphSettings();
                /*0x7c9d930*/ int get_version();
                /*0x7c9d938*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
                /*0x7c9d940*/ bool get_enableRenderCompatibilityMode();
                /*0x7c9d9e4*/ void set_enableRenderCompatibilityMode(bool value);

                enum Version
                {
                    Initial = 0,
                }
            }

            class URPDefaultVolumeProfileSettings : UnityEngine.Rendering.IDefaultVolumeProfileSettings, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.URPDefaultVolumeProfileSettings.Version m_Version;
                /*0x18*/ UnityEngine.Rendering.VolumeProfile m_VolumeProfile;

                /*0x7c9dae4*/ URPDefaultVolumeProfileSettings();
                /*0x7c9da60*/ int get_version();
                /*0x7c9da68*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
                /*0x7c9da70*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);

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

                /*0x7c9dc68*/ URPShaderStrippingSetting();
                /*0x7c9daec*/ int get_version();
                /*0x7c9daf4*/ bool get_stripUnusedPostProcessingVariants();
                /*0x7c9dafc*/ void set_stripUnusedPostProcessingVariants(bool value);
                /*0x7c9db70*/ bool get_stripUnusedVariants();
                /*0x7c9db78*/ void set_stripUnusedVariants(bool value);
                /*0x7c9dbec*/ bool get_stripScreenCoordOverrideVariants();
                /*0x7c9dbf4*/ void set_stripScreenCoordOverrideVariants(bool value);

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

                /*0x7c9dc78*/ int get_elemLength();
                /*0x7c9dc90*/ int get_bitCapacity();
                /*0x7c9dcac*/ float[] get_data();
                /*0x7c9dcb4*/ void Resize(int bitCount);
                /*0x7c9de10*/ void Clear();
                /*0x7c9de60*/ void GetElementIndexAndBitOffset(int index, ref int elemIndex, ref int bitOffset);
                /*0x7c9de74*/ bool get_Item(int index);
                /*0x7c9dea4*/ void set_Item(int index, bool value);
                /*0x7c9dee8*/ string ToString();
            }

            class ShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.ShaderData m_Instance;
                /*0x10*/ UnityEngine.ComputeBuffer m_LightDataBuffer;
                /*0x18*/ UnityEngine.ComputeBuffer m_LightIndicesBuffer;
                /*0x20*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;
                /*0x28*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

                static /*0x7c9e05c*/ UnityEngine.Rendering.Universal.ShaderData get_instance();
                /*0x7c9e054*/ ShaderData();
                /*0x7c9e0e4*/ void Dispose();
                /*0x7c9e144*/ UnityEngine.ComputeBuffer GetLightDataBuffer(int size);
                /*0x7c9e1a0*/ UnityEngine.ComputeBuffer GetLightIndicesBuffer(int size);
                /*0x7c9e1fc*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size);
                /*0x7c9e258*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size);
                /*0x3814b48*/ UnityEngine.ComputeBuffer GetOrUpdateBuffer<T>(ref UnityEngine.ComputeBuffer buffer, int size);
                /*0x7c9e110*/ void DisposeBuffer(ref UnityEngine.ComputeBuffer buffer);
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

                static /*0x7c9e6b8*/ ShaderUtils();
                static /*0x7c9e2b4*/ string GetShaderPath(UnityEngine.Rendering.Universal.ShaderPathID id);
                static /*0x7c9e508*/ UnityEngine.Rendering.Universal.ShaderPathID GetEnumFromPath(string path);
                static /*0x7c9e620*/ bool IsLWShader(UnityEngine.Shader shader);
                static /*0x7c9e6b0*/ float get_PersistentDeltaTime();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string path;

                    /*0x7c9e618*/ <>c__DisplayClass2_0();
                    /*0x7c9e9a4*/ bool <GetEnumFromPath>b__0(string m);
                }
            }

            struct URPLightShadowCullingInfos
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.ShadowSliceData> slices;
                /*0x20*/ uint slicesValidMask;

                /*0x7c9e9b8*/ bool IsSliceValid(int i);
            }

            class ShadowCulling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler computeShadowCasterCullingInfosMarker;

                static /*0x7c9f784*/ ShadowCulling();
                static /*0x7c9e9c8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> CullShadowCasters(ref UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullResults);
                static /*0x7c9eab4*/ void ComputeShadowCasterCullingInfos(UnityEngine.Rendering.Universal.UniversalShadowData shadowData, ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.ShadowCastersCullingInfos shadowCullingInfos, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> urpVisibleLightsShadowCullingInfos);
                static /*0x7c9f764*/ UnityEngine.Rendering.BatchCullingProjectionType GetCullingProjectionType(UnityEngine.LightType type);
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

                /*0x7c9f820*/ void Clear();
            }

            class ShadowUtils
            {
                static int kMinimumPunctualLightHardShadowResolution = 8;
                static int kMinimumPunctualLightSoftShadowResolution = 16;
                static /*0x0*/ bool m_ForceShadowPointSampling;

                static /*0x7c9f8b0*/ ShadowUtils();
                static /*0x7c9f97c*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix);
                static /*0x7c9fab8*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x7c9f2f0*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x7c9fe4c*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c9f658*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c9fef0*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c9f4fc*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x7c9ffb4*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7ca012c*/ void RenderShadowSlice(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.RendererList shadowRendererList, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7ca0268*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings);
                static /*0x7ca0338*/ int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount);
                static /*0x7c9fd10*/ void ApplySliceTransform(ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight);
                static /*0x7ca0364*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, ref UnityEngine.Rendering.Universal.ShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7ca07dc*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7ca0444*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, System.Collections.Generic.List<UnityEngine.Vector4> bias, bool supportsSoftShadows, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x7ca08a4*/ void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, ref float scale, ref float bias);
                static /*0x7ca08f8*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x7ca09c4*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x7ca0ae8*/ void SetShadowBias(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 shadowBias);
                static /*0x7ca0b84*/ void SetLightDirection(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightDirection);
                static /*0x7ca0c1c*/ void SetLightPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 lightPosition);
                static /*0x7ca0cb4*/ void SetCameraPosition(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector3 worldSpaceCameraPos);
                static /*0x7ca0d4c*/ void SetWorldToCameraAndCameraToWorldMatrices(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix);
                static /*0x7ca0eb0*/ UnityEngine.RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits);
                static /*0x7ca0fb8*/ UnityEngine.RenderTexture GetTemporaryShadowTexture(int width, int height, int bits);
                static /*0x7ca1078*/ bool ShadowRTNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7ca1308*/ UnityEngine.Rendering.RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7ca13f4*/ bool ShadowRTReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x7c9fb90*/ UnityEngine.Matrix4x4 GetShadowTransform(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x7ca14f0*/ float SoftShadowQualityToShaderProperty(UnityEngine.Light light, bool softShadowsEnabled);
                static /*0x7ca1658*/ bool SupportsPerLightSoftShadowQuality();
                static /*0x7ca16e8*/ void SetPerLightSoftShadowKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, bool hasSoftShadows);
                static /*0x7ca1790*/ void SetSoftShadowQualityShaderKeywords(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x7ca1a0c*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i);
                static /*0x7ca1b54*/ bool IsValidShadowCastingLight(UnityEngine.Rendering.Universal.UniversalLightData lightData, int i, UnityEngine.LightType lightType, UnityEngine.LightShadows lightShadows, float shadowStrength);
                static /*0x7c9f4dc*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                static /*0x7ca1b98*/ bool FastApproximately(float a, float b);
                static /*0x7ca1bb0*/ bool FastApproximately(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
                static /*0x7ca1cb0*/ int MinimalPunctualLightShadowResolution(bool softShadow);
            }

            class SpaceFillingCurves
            {
                static /*0x7ca1cc4*/ uint Part1By1(uint x);
                static /*0x7ca1cec*/ uint Compact1By1(uint x);
                static /*0x7ca1d14*/ uint EncodeMorton2D(Unity.Mathematics.uint2 coord);
                static /*0x7ca1d68*/ Unity.Mathematics.uint2 DecodeMorton2D(uint code);
            }

            class StpUtils
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.JitterFunc s_JitterFunc;

                static /*0x7ca26e8*/ StpUtils();
                static /*0x7ca1dbc*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x7ca1e38*/ void PopulateStpConfig(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, int debugViewIndex, UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture, ref UnityEngine.Rendering.STP.Config config);
                static /*0x7ca23fc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth, UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Texture2D noiseTexture);
            }

            class SupportedOnRendererAttribute : System.Attribute
            {
                /*0x10*/ System.Type[] <rendererTypes>k__BackingField;

                /*0x7ca282c*/ SupportedOnRendererAttribute(System.Type renderer);
                /*0x7ca28d8*/ SupportedOnRendererAttribute(System.Type[] renderers);
                /*0x7ca2824*/ System.Type[] get_rendererTypes();
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

                static /*0x7ca46a8*/ TemporalAA();
                static /*0x7ca23e0*/ int CalculateTaaFrameIndex(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x7ca2a7c*/ UnityEngine.Matrix4x4 CalculateJitterMatrix(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.TemporalAA.JitterFunc jitterFunc);
                static /*0x7ca2bf0*/ void CalculateJitter(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                static /*0x7ca2c54*/ float[] CalculateFilterWeights(ref UnityEngine.Rendering.Universal.TemporalAA.Settings settings);
                static /*0x7ca2e08*/ UnityEngine.RenderTextureDescriptor TemporalAADescFromCameraDesc(ref UnityEngine.RenderTextureDescriptor cameraDesc);
                static /*0x7ca3018*/ string ValidateAndWarn(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isSTPRequested);
                static /*0x7ca346c*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material taaMaterial, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.RenderTexture motionVectors);
                static /*0x7ca39b8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Material taaMaterial, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcColor, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcDepth, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle srcMotionVectors, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dstColor);

                class ShaderConstants
                {
                    static /*0x0*/ int _TaaAccumulationTex;
                    static /*0x4*/ int _TaaMotionVectorTex;
                    static /*0x8*/ int _TaaFilterWeights;
                    static /*0xc*/ int _TaaFrameInfluence;
                    static /*0x10*/ int _TaaVarianceClampScale;
                    static /*0x14*/ int _CameraDepthTexture;

                    static /*0x7ca48dc*/ ShaderConstants();
                }

                class ShaderKeywords
                {
                    static /*0x0*/ string TAA_LOW_PRECISION_SOURCE;

                    static /*0x7ca4a38*/ ShaderKeywords();
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

                    static /*0x7ca4b88*/ UnityEngine.Rendering.Universal.TemporalAA.Settings Create();
                    /*0x7ca4aa4*/ UnityEngine.Rendering.Universal.TemporalAAQuality get_quality();
                    /*0x7ca4aac*/ void set_quality(UnityEngine.Rendering.Universal.TemporalAAQuality value);
                    /*0x7ca4ac4*/ float get_baseBlendFactor();
                    /*0x7ca4ad4*/ void set_baseBlendFactor(float value);
                    /*0x7ca4af4*/ float get_jitterScale();
                    /*0x7ca4afc*/ void set_jitterScale(float value);
                    /*0x7ca4b18*/ float get_mipBias();
                    /*0x7ca4b20*/ void set_mipBias(float value);
                    /*0x7ca4b3c*/ float get_varianceClampScale();
                    /*0x7ca4b44*/ void set_varianceClampScale(float value);
                    /*0x7ca4b64*/ float get_contrastAdaptiveSharpening();
                    /*0x7ca4b6c*/ void set_contrastAdaptiveSharpening(float value);
                }

                class JitterFunc : System.MulticastDelegate
                {
                    /*0x7ca2784*/ JitterFunc(object object, nint method);
                    /*0x7ca4ba8*/ void Invoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling);
                    /*0x7ca4bbc*/ System.IAsyncResult BeginInvoke(int frameIndex, ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.AsyncCallback callback, object object);
                    /*0x7ca4c84*/ void EndInvoke(ref UnityEngine.Vector2 jitter, ref bool allowScaling, System.IAsyncResult result);
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

                    /*0x7ca4ca8*/ TaaPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_1;

                    static /*0x7ca4cb0*/ <>c();
                    /*0x7ca4d18*/ <>c();
                    /*0x7ca4d20*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7ca502c*/ void <Render>b__17_1(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            struct InclusiveRange
            {
                /*0x10*/ short start;
                /*0x12*/ short end;

                static /*0x7ca529c*/ UnityEngine.Rendering.Universal.InclusiveRange Merge(UnityEngine.Rendering.Universal.InclusiveRange a, UnityEngine.Rendering.Universal.InclusiveRange b);
                static /*0x7ca5330*/ UnityEngine.Rendering.Universal.InclusiveRange get_empty();
                /*0x7ca5134*/ InclusiveRange(short startEnd);
                /*0x7ca5140*/ InclusiveRange(short start, short end);
                /*0x7ca514c*/ void Expand(short index);
                /*0x7ca51d8*/ void Clamp(short min, short max);
                /*0x7ca5264*/ bool get_isEmpty();
                /*0x7ca5278*/ bool Contains(short index);
                /*0x7ca5338*/ string ToString();
            }

            struct LightMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x7ca53cc*/ void Execute(int index);
            }

            struct ReflectionProbeMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x7ca58f8*/ void Execute(int index);
            }

            struct TileRangeExpansionJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x20*/ Unity.Collections.NativeArray<uint> tileMasks;
                /*0x30*/ int rangesPerItem;
                /*0x34*/ int itemsPerTile;
                /*0x38*/ int wordsPerTile;
                /*0x3c*/ Unity.Mathematics.int2 tileResolution;

                /*0x7ca5ae4*/ void Execute(int jobIndex);
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
                static /*0x7ca5cf4*/ bool IsValid(UnityEngine.Rendering.Universal.TileSize tileSize);
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

                static /*0x7cab34c*/ TilingJob();
                static /*0x7ca9120*/ float square(float x);
                static /*0x7ca9128*/ void GetSphereHorizon(Unity.Mathematics.float2 center, float radius, float near, float clipRadius, ref Unity.Mathematics.float2 p0, ref Unity.Mathematics.float2 p1);
                static /*0x7caaa94*/ void GetSphereYPlaneHorizon(Unity.Mathematics.float3 center, float sphereRadius, float near, float clipRadius, float y, ref Unity.Mathematics.float3 left, ref Unity.Mathematics.float3 right);
                static /*0x7ca9694*/ bool GetCircleClipPoints(Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, float circleRadius, float near, ref Unity.Mathematics.float3 p0, ref Unity.Mathematics.float3 p1);
                static /*0x7cab1e4*/ System.ValueTuple<float, float> IntersectEllipseLine(float a, float b, Unity.Mathematics.float3 line);
                static /*0x7ca949c*/ void GetProjectedCircleHorizon(Unity.Mathematics.float2 center, float radius, Unity.Mathematics.float2 U, Unity.Mathematics.float2 V, ref Unity.Mathematics.float2 uv1, ref Unity.Mathematics.float2 uv2);
                static /*0x7caa388*/ bool IntersectCircleYPlane(float y, Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, float circleRadius, ref Unity.Mathematics.float3 p1, ref Unity.Mathematics.float3 p2);
                static /*0x7ca9e00*/ void GetConeSideTangentPoints(Unity.Mathematics.float3 vertex, Unity.Mathematics.float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, ref Unity.Mathematics.float3 l1, ref Unity.Mathematics.float3 l2);
                static /*0x7ca9b20*/ Unity.Mathematics.float3 EvaluateNearConic(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float theta);
                static /*0x7ca9894*/ Unity.Mathematics.float2 FindNearConicTangentTheta(Unity.Mathematics.float2 o, Unity.Mathematics.float2 d, float r, Unity.Mathematics.float2 u, Unity.Mathematics.float2 v);
                static /*0x7caa630*/ Unity.Mathematics.float2 FindNearConicYTheta(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float y);
                static /*0x7ca93ac*/ bool <TileLight>g__SpherePointIsValid|19_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x7ca9cec*/ bool <TileLight>g__ConicPointIsValid|19_1(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x7caaf8c*/ bool <TileLightOrthographic>g__SpherePointIsValid|20_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                /*0x7ca5d1c*/ void Execute(int jobIndex);
                /*0x7ca6aac*/ void TileLight(int lightIndex);
                /*0x7ca5e24*/ void TileLightOrthographic(int lightIndex);
                /*0x7ca87d8*/ void TileReflectionProbe(int index);
                /*0x7caa2e4*/ Unity.Mathematics.float2 ViewToTileSpace(Unity.Mathematics.float3 positionVS);
                /*0x7cab154*/ Unity.Mathematics.float2 ViewToTileSpaceOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x7ca9004*/ void ExpandY(Unity.Mathematics.float3 positionVS);
                /*0x7caae70*/ void ExpandOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x7cab07c*/ void ExpandRangeOrthographic(ref UnityEngine.Rendering.Universal.InclusiveRange range, float xVS);

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

                static /*0x7cab50c*/ uint EncodeHeader(uint min, uint max);
                static /*0x7cab514*/ System.ValueTuple<uint, uint> DecodeHeader(uint zBin);
                /*0x7cab578*/ void Execute(int jobIndex);
                /*0x7cab68c*/ void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset);
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
                static /*0x7cab8b0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData GetUniversalAdditionalCameraData(UnityEngine.Camera camera);
                static /*0x7cab94c*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(UnityEngine.Camera camera);
                static /*0x7cab968*/ void SetVolumeFrameworkUpdateMode(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode mode);
                static /*0x7cabb80*/ void UpdateVolumeStack(UnityEngine.Camera camera);
                static /*0x7caba50*/ void UpdateVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x7cabecc*/ void DestroyVolumeStack(UnityEngine.Camera camera);
                static /*0x7cabee0*/ void DestroyVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x7cabccc*/ void GetVolumeLayerMaskAndTrigger(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData, ref UnityEngine.LayerMask layerMask, ref UnityEngine.Transform trigger);
            }

            class CameraTypeUtility
            {
                static /*0x0*/ string[] s_CameraTypeNames;

                static /*0x7cac168*/ CameraTypeUtility();
                static /*0x7cac0bc*/ string GetName(UnityEngine.Rendering.Universal.CameraRenderType type);
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

                static /*0x7cac248*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData get_defaultAdditionalCameraData();
                /*0x7cac300*/ UniversalAdditionalCameraData();
                /*0x7cac240*/ float get_version();
                /*0x7cac464*/ UnityEngine.Camera get_camera();
                /*0x7cac50c*/ void Start();
                /*0x7cac540*/ bool get_renderShadows();
                /*0x7cac548*/ void set_renderShadows(bool value);
                /*0x7cac554*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresDepthOption();
                /*0x7cac55c*/ void set_requiresDepthOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x7cac564*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresColorOption();
                /*0x7cac56c*/ void set_requiresColorOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x7cac574*/ UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x7cac57c*/ void set_renderType(UnityEngine.Rendering.Universal.CameraRenderType value);
                /*0x7ca32e8*/ System.Collections.Generic.List<UnityEngine.Camera> get_cameraStack();
                /*0x7cac868*/ void UpdateCameraStack();
                /*0x7cacb5c*/ bool get_clearDepth();
                /*0x7cacb64*/ bool get_requiresDepthTexture();
                /*0x7cacbe8*/ void set_requiresDepthTexture(bool value);
                /*0x7cacc04*/ bool get_requiresColorTexture();
                /*0x7cacc88*/ void set_requiresColorTexture(bool value);
                /*0x7cac584*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x7cacca4*/ void SetRenderer(int index);
                /*0x7caccac*/ UnityEngine.LayerMask get_volumeLayerMask();
                /*0x7caccb4*/ void set_volumeLayerMask(UnityEngine.LayerMask value);
                /*0x7caccbc*/ UnityEngine.Transform get_volumeTrigger();
                /*0x7caccc4*/ void set_volumeTrigger(UnityEngine.Transform value);
                /*0x7cacccc*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x7caccd4*/ void set_volumeFrameworkUpdateMode(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode value);
                /*0x7cab9d0*/ bool get_requiresVolumeFrameworkUpdate();
                /*0x7caccdc*/ UnityEngine.Rendering.VolumeStack get_volumeStack();
                /*0x7cabf68*/ void set_volumeStack(UnityEngine.Rendering.VolumeStack value);
                /*0x7cabb9c*/ void GetOrCreateVolumeStack();
                /*0x7cacce4*/ bool get_renderPostProcessing();
                /*0x7caccec*/ void set_renderPostProcessing(bool value);
                /*0x7caccf8*/ UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x7cacd00*/ void set_antialiasing(UnityEngine.Rendering.Universal.AntialiasingMode value);
                /*0x7cacd08*/ UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x7cacd10*/ void set_antialiasingQuality(UnityEngine.Rendering.Universal.AntialiasingQuality value);
                /*0x7cacd18*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x7cacd20*/ UnityEngine.Rendering.ICameraHistoryReadAccess get_history();
                /*0x7cacd28*/ UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7cacd30*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData get_motionVectorsPersistentData();
                /*0x7cacd38*/ bool get_resetHistory();
                /*0x7cacd48*/ void set_resetHistory(bool value);
                /*0x7cacd8c*/ bool get_stopNaN();
                /*0x7cacd94*/ void set_stopNaN(bool value);
                /*0x7cacda0*/ bool get_dithering();
                /*0x7cacda8*/ void set_dithering(bool value);
                /*0x7cacdb4*/ bool get_allowXRRendering();
                /*0x7cacdbc*/ void set_allowXRRendering(bool value);
                /*0x7cacdc8*/ bool get_useScreenCoordOverride();
                /*0x7cacdd0*/ void set_useScreenCoordOverride(bool value);
                /*0x7cacddc*/ UnityEngine.Vector4 get_screenSizeOverride();
                /*0x7cacde8*/ void set_screenSizeOverride(UnityEngine.Vector4 value);
                /*0x7cacdf4*/ UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x7cace00*/ void set_screenCoordScaleBias(UnityEngine.Vector4 value);
                /*0x7cace0c*/ bool get_allowHDROutput();
                /*0x7cace14*/ void set_allowHDROutput(bool value);
                /*0x7cace20*/ void OnBeforeSerialize();
                /*0x7cace24*/ void OnAfterDeserialize();
                /*0x7cace4c*/ void OnValidate();
                /*0x7cacee0*/ void OnDrawGizmos();
                /*0x7cacff8*/ void OnDestroy();
                /*0x7cad064*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRawRenderer();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Camera> <>9__53_0;

                    static /*0x7cad1c4*/ <>c();
                    /*0x7cad22c*/ <>c();
                    /*0x7cad234*/ bool <UpdateCameraStack>b__53_0(UnityEngine.Camera cam);
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
                static /*0x7cad290*/ UnityEngine.Rendering.Universal.UniversalAdditionalLightData GetUniversalAdditionalLightData(UnityEngine.Light light);
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

                static /*0x7cad6fc*/ UniversalAdditionalLightData();
                /*0x7cad614*/ UniversalAdditionalLightData();
                /*0x7cad32c*/ int get_version();
                /*0x7cad334*/ bool get_usePipelineSettings();
                /*0x7cad33c*/ void set_usePipelineSettings(bool value);
                /*0x7cad348*/ UnityEngine.Light get_light();
                /*0x7cad3e0*/ int get_additionalLightsShadowResolutionTier();
                /*0x7cad3e8*/ UnityEngine.Rendering.Universal.LightLayerEnum get_lightLayerMask();
                /*0x7cad3f0*/ void set_lightLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x7cad3f8*/ uint get_renderingLayers();
                /*0x7cad400*/ void set_renderingLayers(uint value);
                /*0x7cad4c0*/ bool get_customShadowLayers();
                /*0x7cad4c8*/ void set_customShadowLayers(bool value);
                /*0x7cad4e4*/ UnityEngine.Rendering.Universal.LightLayerEnum get_shadowLayerMask();
                /*0x7cad4ec*/ void set_shadowLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x7cad4f4*/ uint get_shadowRenderingLayers();
                /*0x7cad4fc*/ void set_shadowRenderingLayers(uint value);
                /*0x7cad514*/ UnityEngine.Vector2 get_lightCookieSize();
                /*0x7cad51c*/ void set_lightCookieSize(UnityEngine.Vector2 value);
                /*0x7cad524*/ UnityEngine.Vector2 get_lightCookieOffset();
                /*0x7cad52c*/ void set_lightCookieOffset(UnityEngine.Vector2 value);
                /*0x7cad534*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x7cad53c*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x7cad544*/ void OnBeforeSerialize();
                /*0x7cad548*/ void OnAfterDeserialize();
                /*0x7cad418*/ void SyncLightAndShadowLayers();
            }

            class UniversalCameraHistory : UnityEngine.Rendering.ICameraHistoryReadAccess, UnityEngine.Rendering.ICameraHistoryWriteAccess, UnityEngine.Rendering.IPerFrameHistoryAccessTracker, System.IDisposable
            {
                static int k_ValidVersionCount = 2;
                static /*0x0*/ uint s_TypeCount;
                /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraHistory.Item[] m_Items;
                /*0x18*/ int m_Version;
                /*0x20*/ UnityEngine.Rendering.BufferedRTHandleSystem m_HistoryTextures;
                /*0x28*/ UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate OnGatherHistoryRequests;

                /*0x7cad898*/ UniversalCameraHistory();
                /*0x38159dc*/ void RequestAccess<Type>();
                /*0x3910ae8*/ Type GetHistoryForRead<Type>();
                /*0x3813ffc*/ bool IsAccessRequested<Type>();
                /*0x3910ae8*/ Type GetHistoryForWrite<Type>();
                /*0x3813ffc*/ bool IsWritten<Type>();
                /*0x7cad760*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x7cad7fc*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
                /*0x7cad9d4*/ void Dispose();
                /*0x7cada64*/ void GatherHistoryRequests();
                /*0x7cada84*/ bool IsValidRequest(int i);
                /*0x7cadac4*/ bool IsValid(int i);
                /*0x7cadb04*/ void ReleaseUnusedHistory();
                /*0x7cadbc0*/ void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight);

                class TypeId<T>
                {
                    static /*0x0*/ uint value;

                    static /*0x383e7a0*/ TypeId();
                }

                struct Item
                {
                    /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                    /*0x18*/ int requestVersion;
                    /*0x1c*/ int writeVersion;

                    /*0x7cad9a8*/ void Reset();
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

                static /*0x7cbc180*/ UniversalRenderer();
                static /*0x7caf9b0*/ bool IsOffscreenDepthTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x7cafa18*/ bool IsOffscreenDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cb5aa8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                static /*0x7cb5bfc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.Color color, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                /*0x7cadd20*/ UniversalRenderer(UnityEngine.Rendering.Universal.UniversalRendererData data);
                /*0x7cadbdc*/ int SupportedCameraStackingTypes();
                /*0x7cadc00*/ bool SupportsMotionVectors();
                /*0x7cadc08*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeRequested();
                /*0x7cadc10*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeActual();
                /*0x7cadc80*/ bool get_accurateGbufferNormals();
                /*0x7cadca0*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x7cadca8*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x7cadcb0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x7cadcb8*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x7cadcc0*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x7cadcc8*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x7cadcd0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x7cadcd8*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x7cadce0*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x7cadce8*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x7cadcf0*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x7cadcf8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthTextureFormat();
                /*0x7cadd0c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_cameraDepthAttachmentFormat();
                /*0x7caf158*/ void Dispose(bool disposing);
                /*0x7caf4e4*/ void ReleaseRenderTargets();
                /*0x7caf5dc*/ void SetupFinalPassDebug(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cafaa8*/ bool IsDepthPrimingEnabled(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cafc8c*/ bool IsWebGL();
                /*0x7cafc94*/ bool IsGLESDevice();
                /*0x7cafcb0*/ bool IsGLDevice();
                /*0x7cafce4*/ bool HasActiveRenderFeatures();
                /*0x7cafe58*/ bool HasPassesRequiringIntermediateTexture();
                /*0x7caffcc*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7cb3868*/ void SetupVFXCameraBuffer(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb3ac0*/ void SetupRawColorDepthHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.RenderTextureDescriptor cameraTargetDescriptor);
                /*0x7cb3df4*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x7cb3f78*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x7cb435c*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7cb36e0*/ void EnqueueDeferred(UnityEngine.RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow);
                /*0x7cb2c30*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera);
                /*0x7cb30c8*/ void CreateCameraRenderTarget(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb439c*/ bool PlatformRequiresExplicitMsaaResolve();
                /*0x7cb2ef8*/ bool RequiresIntermediateColorTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7cafba8*/ bool CanCopyDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb4410*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7cb45cc*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7cb45e8*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7cb4604*/ void EnableSwapBufferMSAA(bool enable);
                /*0x7cb4624*/ bool get_supportsNativeRenderPassRendergraphCompiler();
                /*0x7cb462c*/ bool DebugHandlerRequireDepthPass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb469c*/ void CreateDebugTexture(UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7cb47a4*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, float width, float height);
                /*0x7cb47dc*/ UnityEngine.Rect CalculateUVRect(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, int textureHeightPercent);
                /*0x7caf970*/ void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight);
                /*0x7cb4834*/ void SetupRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb5294*/ void SetupAfterPostRenderGraphFinalPassDebug(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cb4fcc*/ void BlitToDebugTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, bool isSourceTextureColor);
                /*0x7cb5558*/ void BlitEmptyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, string passName);
                /*0x7cb5980*/ UnityEngine.Rendering.RTHandle get_currentRenderGraphCameraColorHandle();
                /*0x7cb5a34*/ UnityEngine.Rendering.RTHandle get_nextRenderGraphCameraColorHandle();
                /*0x7caf34c*/ void CleanupRenderGraphResources();
                /*0x7cb5d4c*/ bool ShouldApplyPostProcessing(bool postProcessEnabled);
                /*0x7cb5d64*/ bool CameraHasPostProcessingWithDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb5da8*/ bool RequiresIntermediateAttachments(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7cb2b74*/ void UpdateCameraHistory(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb6064*/ void CreateRenderGraphCameraRenderTargets(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool isCameraTargetOffscreenDepth);
                /*0x7cb7d18*/ void SetupRenderingLayers(int msaaSamples);
                /*0x7cb7d94*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                /*0x7cb7e18*/ void RenderRawColorDepthHistory(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7cb82e0*/ void OnBeginRenderGraphFrame();
                /*0x7cb833c*/ void OnRecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7cba6d0*/ void OnEndRenderGraphFrame();
                /*0x7cba72c*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7cba79c*/ bool get_supportsGPUOcclusion();
                /*0x7cb85e8*/ void OnOffscreenDepthTextureRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                /*0x7cb8998*/ void OnBeforeRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7cbaf14*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture);
                /*0x7cbb2c8*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.OcclusionTest occlusionTest);
                /*0x7cbb4c0*/ void RecordCustomPassesWithDepthCopyAndMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, UnityEngine.Rendering.Universal.RenderPassEvent currentEvent, bool renderMotionVectors);
                /*0x7cbb5ac*/ bool AllowPartialDepthNormalsPrepass(bool isDeferred, UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalEvent);
                /*0x7cbb5c0*/ UnityEngine.Rendering.Universal.UniversalRenderer.DepthCopySchedule CalculateDepthCopySchedule(UnityEngine.Rendering.Universal.RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass);
                /*0x7cbb618*/ UnityEngine.Rendering.Universal.UniversalRenderer.TextureCopySchedules CalculateTextureCopySchedules(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass);
                /*0x7cbb76c*/ void CopyDepthToDepthTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7cbb82c*/ void RenderMotionVectors(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                /*0x7cbb55c*/ void ExecuteScheduledDepthCopyWithMotion(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, bool renderMotionVectors);
                /*0x7cb8c48*/ void OnMainRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context);
                /*0x7cb9b30*/ void OnAfterRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7cb5ed0*/ bool RequireDepthPrepass(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7cb5f7c*/ bool RequireDepthTexture(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool requiresDepthPrepass, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x7cbba94*/ void SetRenderingLayersGlobalTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7cb7314*/ void CreateCameraDepthCopyTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor, bool isDepthTexture);
                /*0x7cb76d4*/ void CreateMotionVectorTextures(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7cb74a0*/ void CreateCameraNormalsTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7cb78e8*/ void CreateRenderingLayersTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7cb7b4c*/ void CreateAfterPostProcessTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor descriptor);
                /*0x7cbb8d8*/ void DepthNormalPrepassRender(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                class Profiling
                {
                    static string k_Name = "UniversalRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler createCameraRenderTarget;

                    static /*0x7cbc320*/ Profiling();
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

                    /*0x7cbc3bc*/ CopyToDebugTexturePassData();
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

                    static /*0x7cbc3c4*/ <>c();
                    /*0x7cbc42c*/ <>c();
                    /*0x7cbc434*/ bool <Setup>b__110_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x7cbc454*/ bool <Setup>b__110_1(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x7cbc488*/ void <BlitEmptyTexture>b__139_0(UnityEngine.Rendering.Universal.UniversalRenderer.CopyToDebugTexturePassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    /*0x7cbc550*/ bool <OnAfterRendering>b__194_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
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

                /*0x7cbc570*/ RenderPathCompatibleAttribute(UnityEngine.Rendering.Universal.RenderPathCompatibility renderPath);
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

                static /*0x7cbc774*/ RenderGraphUtils();
                static /*0x7cbc598*/ void UseDBufferIfValid(UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder builder, UnityEngine.Rendering.Universal.UniversalResourceData resourceData);
                static /*0x7cbbc8c*/ void SetGlobalTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, int nameId, UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, string passName, string file, int line);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle texture;
                    /*0x20*/ int nameID;

                    /*0x7cbc810*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.RenderGraphUtils.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.RenderGraphUtils.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__6_0;

                    static /*0x7cbc818*/ <>c();
                    /*0x7cbc880*/ <>c();
                    /*0x7cbc888*/ void <SetGlobalTexture>b__6_0(UnityEngine.Rendering.Universal.RenderGraphUtils.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                }
            }

            class ClearTargetsPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_ClearProfilingSampler;

                static /*0x7cbc990*/ ClearTargetsPass();
                static /*0x7cbc88c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cba84c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorHandle, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthHandle, UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color clearColor);
                /*0x7cbc988*/ ClearTargetsPass();

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                    /*0x30*/ UnityEngine.Rendering.RTClearFlags clearFlags;
                    /*0x34*/ UnityEngine.Color clearColor;

                    /*0x7cbca2c*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ClearTargetsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.ClearTargetsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__3_0;

                    static /*0x7cbca34*/ <>c();
                    /*0x7cbca9c*/ <>c();
                    /*0x7cbcaa4*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.ClearTargetsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                static /*0x7cc69d4*/ UniversalRenderPipeline();
                static /*0x7cbcad8*/ float get_maxShadowBias();
                static /*0x7cbcae0*/ float get_minRenderScale();
                static /*0x7cbcaec*/ float get_maxRenderScale();
                static /*0x7cbcaf4*/ int get_maxNumIterationsEnclosingSphere();
                static /*0x7cbcafc*/ int get_maxPerObjectLights();
                static /*0x7cb4250*/ int get_maxVisibleAdditionalLights();
                static /*0x7cbcb04*/ int get_lightsPerTile();
                static /*0x7cbcb68*/ int get_maxZBinWords();
                static /*0x7cbcb70*/ int get_maxTileWords();
                static /*0x7cbcbd0*/ int get_maxVisibleReflectionProbes();
                static /*0x7cbcc70*/ bool get_canOptimizeScreenMSAASamples();
                static /*0x7cbccc8*/ void set_canOptimizeScreenMSAASamples(bool value);
                static /*0x7cbcd28*/ int get_startFrameScreenMSAASamples();
                static /*0x7cbcd80*/ void set_startFrameScreenMSAASamples(int value);
                static /*0x7cc01a4*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x7cc00e0*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x7cc0208*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, ref UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cc2728*/ bool TryGetCullingParameters(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                static /*0x7cc14bc*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cc4340*/ void CreateShadowAtlasAndCullShadowCasters(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.ScriptableRenderContext context);
                static /*0x7cbe7e0*/ void RenderCameraStack(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera baseCamera);
                static /*0x7cc4ac8*/ void UpdateCameraData(UnityEngine.Rendering.Universal.UniversalCameraData baseCameraData, ref UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7cbfddc*/ void UpdateVolumeFramework(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cc4e64*/ bool CheckPostProcessForDepth(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cc4858*/ bool CheckPostProcessForDepth();
                static /*0x7cbd69c*/ void SetSupportedRenderingFeatures(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset);
                static /*0x7cc061c*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cc0704*/ UnityEngine.Rendering.Universal.UniversalCameraData CreateCameraData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget);
                static /*0x7cc4ef4*/ void InitializeStackedCameraData(UnityEngine.Camera baseCamera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData baseAdditionalCameraData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cc0c80*/ void InitializeAdditionalCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cc3fb0*/ UnityEngine.Rendering.Universal.UniversalRenderingData CreateRenderingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, UnityEngine.Rendering.CommandBuffer cmd, bool isForwardPlus, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x7cc3078*/ UnityEngine.Rendering.Universal.UniversalShadowData CreateShadowData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset, bool isForwardPlus);
                static /*0x7cc5dd4*/ UnityEngine.Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset urpAsset);
                static /*0x7cc4578*/ void InitializeMainLightShadowResolution(UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                static /*0x7cc3edc*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData CreatePostProcessingData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings);
                static /*0x7cc2d80*/ UnityEngine.Rendering.Universal.UniversalResourceData CreateUniversalResourceData(UnityEngine.Rendering.ContextContainer frameData);
                static /*0x7cc2dd0*/ UnityEngine.Rendering.Universal.UniversalLightData CreateLightData(UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x7cc5ba8*/ void ApplyTaaRenderingDebugOverrides(ref UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings);
                static /*0x7cc5a84*/ void UpdateTemporalAAData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x7cc2c6c*/ void UpdateTemporalAATargets(UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cc4924*/ void UpdateCameraStereoMatrices(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x7cc5c70*/ UnityEngine.Rendering.PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus, bool reflectionProbeBlending);
                static /*0x7cc5e34*/ int GetMainLightIndex(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x7cc28a8*/ void SetupPerCameraShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x7cc411c*/ void CheckAndApplyDebugSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x7cc58e0*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter ResolveUpscalingFilterSelection(UnityEngine.Vector2 imageSize, float renderScale, UnityEngine.Rendering.Universal.UpscalingFilterSelection selection, bool enableRenderGraph);
                static /*0x7cc4778*/ bool HDROutputForMainDisplayIsActive();
                static /*0x7cc609c*/ bool HDROutputForAnyDisplayIsActive();
                static /*0x7cc6144*/ void GetHDROutputLuminanceParameters(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x7cc6234*/ void GetHDROutputGradingParameters(UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x7cc4610*/ UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                static /*0x7cbe204*/ void AdjustUIOverlayOwnership(int cameraCount);
                static /*0x7cbe2ac*/ void SetupScreenMSAASamplesState(int cameraCount);
                static /*0x7cbe704*/ bool IsGameCamera(UnityEngine.Camera camera);
                static /*0x7caf050*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset get_asset();
                static /*0x7caf0f0*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha);
                static /*0x7cc62fc*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeUnormRenderTextureGraphicsFormat();
                static /*0x7cc5648*/ UnityEngine.RenderTextureDescriptor CreateRenderTextureDescriptor(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture);
                static /*0x7cc6328*/ void GetLightAttenuationAndSpotDirection(UnityEngine.LightType lightType, float lightRange, UnityEngine.Matrix4x4 lightLocalToWorldMatrix, float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x7cc6474*/ void GetPunctualLightDistanceAttenuation(float lightRange, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x7cc64e0*/ void GetSpotAngleAttenuation(float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x7cc64ac*/ void GetSpotDirection(ref UnityEngine.Matrix4x4 lightLocalToWorldMatrix, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x7cc65e0*/ void InitializeLightConstants_Common(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel);
                static /*0x7cc69b0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                static /*0x7cc446c*/ void RecordAndExecuteRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderer renderer, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, string cameraName);
                /*0x7cbcdf4*/ UniversalRenderPipeline(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset);
                /*0x7cbcc58*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures get_runtimeTextures();
                /*0x7cbcc60*/ void set_runtimeTextures(UnityEngine.Rendering.Universal.UniversalRenderPipelineRuntimeTextures value);
                /*0x7cbcc68*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();
                /*0x7cbcddc*/ string ToString();
                /*0x7cbd71c*/ void Dispose(bool disposing);
                /*0x7cbda10*/ void DisposeAdditionalCameraData();
                /*0x7cbdac8*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Camera[] cameras);
                /*0x7cbdb60*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x3910ae8*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
                /*0x3910ae8*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
                /*0x7cbe388*/ void SetupPerFrameShaderConstants();
                /*0x7cbe0c0*/ void SetHDRState(System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x7cbe688*/ void SortCameras(System.Collections.Generic.List<UnityEngine.Camera> cameras);

                class CameraMetadataCache
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry> s_MetadataCache;
                    static /*0x8*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry k_NoAllocEntry;

                    static /*0x7cc6d54*/ CameraMetadataCache();
                    static /*0x7cc6b8c*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.CameraMetadataCache.CameraMetadataCacheEntry GetCached(UnityEngine.Camera camera);

                    class CameraMetadataCacheEntry
                    {
                        /*0x10*/ string name;
                        /*0x18*/ UnityEngine.Rendering.ProfilingSampler sampler;

                        /*0x7cc6d4c*/ CameraMetadataCacheEntry();
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

                        static /*0x7cc6e90*/ Pipeline();

                        class Renderer
                        {
                            static string k_Name = "ScriptableRenderer";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setupCullingParameters;
                            static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setup;

                            static /*0x7cc71c4*/ Renderer();
                        }

                        class Context
                        {
                            static string k_Name = "ScriptableRenderContext";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler submit;

                            static /*0x7cc72a0*/ Context();
                        }
                    }
                }

                struct CameraRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginCameraRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endCameraRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ UnityEngine.Camera m_Camera;

                    static /*0x7cc7548*/ CameraRenderingScope();
                    /*0x7cc733c*/ CameraRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x7cc7458*/ void Dispose();
                }

                struct ContextRenderingScope : System.IDisposable
                {
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginContextRenderingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endContextRenderingSampler;
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;

                    static /*0x7cc7828*/ ContextRenderingScope();
                    /*0x7cc7624*/ ContextRenderingScope(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                    /*0x7cc7738*/ void Dispose();
                }

                class SingleCameraRequest
                {
                    /*0x10*/ UnityEngine.RenderTexture destination;
                    /*0x18*/ int mipLevel;
                    /*0x1c*/ UnityEngine.CubemapFace face;
                    /*0x20*/ int slice;

                    /*0x7cc7904*/ SingleCameraRequest();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Camera> <>9__47_0;

                    static /*0x7cc7914*/ <>c();
                    /*0x7cc797c*/ <>c();
                    /*0x7cc7984*/ int <.ctor>b__47_0(UnityEngine.Camera camera1, UnityEngine.Camera camera2);
                    /*0x7cc79ec*/ void <.cctor>b__122_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }

            class NativeArrayExtensions
            {
                static /*0x3910ae8*/ ref T UnsafeElementAt<T>(Unity.Collections.NativeArray<T> array, int index);
                static /*0x3910ae8*/ ref T UnsafeElementAtMutable<T>(Unity.Collections.NativeArray<T> array, int index);
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

                /*0x7cc7cb8*/ RenderingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cc7d74*/ UnityEngine.Rendering.Universal.UniversalRenderingData get_universalRenderingData();
                /*0x7cc7dc4*/ ref UnityEngine.Rendering.CommandBuffer get_commandBuffer();
                /*0x7cc7e70*/ ref UnityEngine.Rendering.CullingResults get_cullResults();
                /*0x7cc7ecc*/ ref bool get_supportsDynamicBatching();
                /*0x7cc7f28*/ ref UnityEngine.Rendering.PerObjectData get_perObjectData();
                /*0x7cc7f84*/ ref bool get_postProcessingEnabled();
            }

            struct LightData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cc7fe0*/ LightData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cc7fe8*/ UnityEngine.Rendering.Universal.UniversalLightData get_universalLightData();
                /*0x7cc8038*/ ref int get_mainLightIndex();
                /*0x7cc8094*/ ref int get_additionalLightsCount();
                /*0x7cc80f0*/ ref int get_maxPerObjectAdditionalLightsCount();
                /*0x7cc814c*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
                /*0x7cc81a8*/ ref bool get_shadeAdditionalLightsPerVertex();
                /*0x7cc8204*/ ref bool get_supportsMixedLighting();
                /*0x7cc8260*/ ref bool get_reflectionProbeBoxProjection();
                /*0x7cc82bc*/ ref bool get_reflectionProbeBlending();
                /*0x7cc8318*/ ref bool get_supportsLightLayers();
                /*0x7cc8374*/ ref bool get_supportsAdditionalLights();
            }

            struct CameraData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cc83d0*/ CameraData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cc83d8*/ UnityEngine.Rendering.Universal.UniversalCameraData get_universalCameraData();
                /*0x7cc8428*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x7cc84e8*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x7cc85d8*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7cc864c*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7cc86dc*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x7cc876c*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x7cc87fc*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x7cc888c*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x7cc891c*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x7cc89b4*/ ref UnityEngine.Camera get_camera();
                /*0x7cc8a10*/ ref UnityEngine.Rendering.Universal.UniversalCameraHistory get_historyManager();
                /*0x7cc8a6c*/ ref UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0x7cc8ac8*/ ref UnityEngine.RenderTexture get_targetTexture();
                /*0x7cc8b24*/ ref UnityEngine.RenderTextureDescriptor get_cameraTargetDescriptor();
                /*0x7cc8b80*/ ref UnityEngine.Rect get_pixelRect();
                /*0x7cc8bdc*/ ref bool get_useScreenCoordOverride();
                /*0x7cc8c38*/ ref UnityEngine.Vector4 get_screenSizeOverride();
                /*0x7cc8c94*/ ref UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x7cc8cf0*/ ref int get_pixelWidth();
                /*0x7cc8d4c*/ ref int get_pixelHeight();
                /*0x7cc8da8*/ ref float get_aspectRatio();
                /*0x7cc8e04*/ ref float get_renderScale();
                /*0x7cc8e60*/ ref UnityEngine.Rendering.Universal.ImageScalingMode get_imageScalingMode();
                /*0x7cc8ebc*/ ref UnityEngine.Rendering.Universal.ImageUpscalingFilter get_upscalingFilter();
                /*0x7cc8f18*/ ref bool get_fsrOverrideSharpness();
                /*0x7cc8f74*/ ref float get_fsrSharpness();
                /*0x7cc8fd0*/ ref UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x7cc902c*/ ref bool get_clearDepth();
                /*0x7cc9088*/ ref UnityEngine.CameraType get_cameraType();
                /*0x7cc90e4*/ ref bool get_isDefaultViewport();
                /*0x7cc9140*/ ref bool get_isHdrEnabled();
                /*0x7cc919c*/ ref bool get_allowHDROutput();
                /*0x7cc91f8*/ ref bool get_isAlphaOutputEnabled();
                /*0x7cc9254*/ ref bool get_requiresDepthTexture();
                /*0x7cc92b0*/ ref bool get_requiresOpaqueTexture();
                /*0x7cc930c*/ ref bool get_postProcessingRequiresDepthTexture();
                /*0x7cc9368*/ ref bool get_xrRendering();
                /*0x7cc93c4*/ bool get_requireSrgbConversion();
                /*0x7cc9420*/ bool get_isSceneViewCamera();
                /*0x7cc947c*/ bool get_isPreviewCamera();
                /*0x7cc94d8*/ bool get_isRenderPassSupportedCamera();
                /*0x7cc9534*/ bool get_resolveToScreen();
                /*0x7cc9590*/ bool get_isHDROutputActive();
                /*0x7cc95ec*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x7cc9648*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x7cc96a4*/ bool get_rendersOverlayUI();
                /*0x7cc9700*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x7cc9764*/ bool IsCameraProjectionMatrixFlipped();
                /*0x7cc97c0*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x7cc9834*/ bool IsTemporalAAEnabled();
                /*0x7cc9890*/ ref UnityEngine.Rendering.SortingCriteria get_defaultOpaqueSortFlags();
                /*0x7cc98ec*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x7cc9948*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x7cc99b4*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x7cc9a10*/ ref float get_maxShadowDistance();
                /*0x7cc9a6c*/ ref bool get_postProcessEnabled();
                /*0x7cc9ac8*/ ref System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> get_captureActions();
                /*0x7cc9b24*/ ref UnityEngine.LayerMask get_volumeLayerMask();
                /*0x7cc9b80*/ ref UnityEngine.Transform get_volumeTrigger();
                /*0x7cc9bdc*/ ref bool get_isStopNaNEnabled();
                /*0x7cc9c38*/ ref bool get_isDitheringEnabled();
                /*0x7cc9c94*/ ref UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x7cc9cf0*/ ref UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x7cc9d4c*/ ref UnityEngine.Rendering.Universal.ScriptableRenderer get_renderer();
                /*0x7cc9da8*/ ref bool get_resolveFinalTarget();
                /*0x7cc9e04*/ ref UnityEngine.Vector3 get_worldSpaceCameraPos();
                /*0x7cc9e60*/ ref UnityEngine.Color get_backgroundColor();
                /*0x7cc9ebc*/ ref UnityEngine.Rendering.Universal.TaaHistory get_taaHistory();
                /*0x7cc9f18*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x7cc9f74*/ bool get_resetHistory();
                /*0x7cc9fd0*/ ref UnityEngine.Camera get_baseCamera();
            }

            struct ShadowData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7cca02c*/ ShadowData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7cca034*/ UnityEngine.Rendering.Universal.UniversalShadowData get_universalShadowData();
                /*0x7cca084*/ ref bool get_supportsMainLightShadows();
                /*0x7cca0e0*/ ref bool get_mainLightShadowsEnabled();
                /*0x7cca13c*/ ref int get_mainLightShadowmapWidth();
                /*0x7cca198*/ ref int get_mainLightShadowmapHeight();
                /*0x7cca1f4*/ ref int get_mainLightShadowCascadesCount();
                /*0x7cca250*/ ref UnityEngine.Vector3 get_mainLightShadowCascadesSplit();
                /*0x7cca2ac*/ ref float get_mainLightShadowCascadeBorder();
                /*0x7cca308*/ ref bool get_supportsAdditionalLightShadows();
                /*0x7cca364*/ ref bool get_additionalLightShadowsEnabled();
                /*0x7cca3c0*/ ref int get_additionalLightsShadowmapWidth();
                /*0x7cca41c*/ ref int get_additionalLightsShadowmapHeight();
                /*0x7cca478*/ ref bool get_supportsSoftShadows();
                /*0x7cca4d4*/ ref int get_shadowmapDepthBufferBits();
                /*0x7cca530*/ ref System.Collections.Generic.List<UnityEngine.Vector4> get_bias();
                /*0x7cca58c*/ ref System.Collections.Generic.List<int> get_resolution();
                /*0x7cca5e8*/ ref bool get_isKeywordAdditionalLightShadowsEnabled();
                /*0x7cca644*/ ref bool get_isKeywordSoftShadowsEnabled();
                /*0x7cca6a0*/ ref int get_mainLightShadowResolution();
                /*0x7cca6fc*/ ref int get_mainLightRenderTargetWidth();
                /*0x7cca758*/ ref int get_mainLightRenderTargetHeight();
                /*0x7cca7b4*/ ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.URPLightShadowCullingInfos> get_visibleLightsShadowCullingInfos();
                /*0x7cca810*/ ref UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout get_shadowAtlasLayout();
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

                static /*0x7cca86c*/ ShaderPropertyId();
            }

            struct PostProcessingData
            {
                /*0x10*/ UnityEngine.Rendering.ContextContainer frameData;

                /*0x7ccb2ec*/ PostProcessingData(UnityEngine.Rendering.ContextContainer frameData);
                /*0x7ccb2f4*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData get_universalPostProcessingData();
                /*0x7ccb344*/ ref UnityEngine.Rendering.Universal.ColorGradingMode get_gradingMode();
                /*0x7ccb3a0*/ ref int get_lutSize();
                /*0x7ccb3fc*/ ref bool get_useFastSRGBLinearConversion();
                /*0x7ccb458*/ ref bool get_supportScreenSpaceLensFlare();
                /*0x7ccb4b4*/ ref bool get_supportDataDrivenLensFlare();
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

                static /*0x7ccb510*/ void InitializeShaderGlobalKeywords();
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

                static /*0x7ccce7c*/ PlatformAutoDetect();
                static /*0x7ccc828*/ void Initialize();
                static /*0x7ccc9a4*/ bool IsRunningXRMobile();
                static /*0x7cccb14*/ bool get_isXRMobile();
                static /*0x7cccb6c*/ void set_isXRMobile(bool value);
                static /*0x7cccbcc*/ bool get_isShaderAPIMobileDefined();
                static /*0x7cccc24*/ void set_isShaderAPIMobileDefined(bool value);
                static /*0x7cccc84*/ bool get_isSwitch();
                static /*0x7ccccdc*/ void set_isSwitch(bool value);
                static /*0x7cccd3c*/ UnityEngine.Rendering.Universal.ShEvalMode ShAutoDetect(UnityEngine.Rendering.Universal.ShEvalMode mode);
            }

            class VolumeRequiresRendererFeatures : System.Attribute
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Type> TargetFeatureTypes;

                /*0x7cccf68*/ VolumeRequiresRendererFeatures(System.Type[] featureTypes);
            }

            class XRPassUniversal : UnityEngine.Experimental.Rendering.XRPass
            {
                /*0x734*/ bool <isLateLatchEnabled>k__BackingField;
                /*0x735*/ bool <canMarkLateLatch>k__BackingField;
                /*0x736*/ bool <hasMarkedLateLatch>k__BackingField;
                /*0x737*/ bool <canFoveateIntermediatePasses>k__BackingField;

                static /*0x7ccd058*/ UnityEngine.Experimental.Rendering.XRPass Create(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7ccd200*/ XRPassUniversal();
                /*0x7ccd144*/ void Release();
                /*0x7ccd1b0*/ bool get_isLateLatchEnabled();
                /*0x7ccd1b8*/ void set_isLateLatchEnabled(bool value);
                /*0x7ccd1c4*/ bool get_canMarkLateLatch();
                /*0x7ccd1cc*/ void set_canMarkLateLatch(bool value);
                /*0x7ccd1d8*/ bool get_hasMarkedLateLatch();
                /*0x7ccd1e0*/ void set_hasMarkedLateLatch(bool value);
                /*0x7ccd1ec*/ bool get_canFoveateIntermediatePasses();
                /*0x7ccd1f4*/ void set_canFoveateIntermediatePasses(bool value);
            }

            class XRSystemUniversal
            {
                static /*0x0*/ UnityEngine.Matrix4x4[] s_projMatrix;

                static /*0x7ccd5fc*/ XRSystemUniversal();
                static /*0x7ccd208*/ void BeginLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7ccd2d8*/ void EndLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7ccd394*/ void UnmarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x7ccd410*/ void MarkShaderProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass, bool renderIntoTexture);
            }

            namespace Internal
            {
                class DeferredConfig
                {
                    static /*0x0*/ bool <IsOpenGL>k__BackingField;
                    static /*0x1*/ bool <IsDX10>k__BackingField;

                    static /*0x7ccd670*/ bool get_IsOpenGL();
                    static /*0x7ccd6b8*/ void set_IsOpenGL(bool value);
                    static /*0x7ccd708*/ bool get_IsDX10();
                    static /*0x7ccd750*/ void set_IsDX10(bool value);
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

                    static /*0x7cd3658*/ DeferredLights();
                    static /*0x7ccfbe0*/ UnityEngine.Rendering.StencilState OverwriteStencil(UnityEngine.Rendering.StencilState s, int stencilWriteMask);
                    static /*0x7ccfd94*/ UnityEngine.Rendering.RenderStateBlock OverwriteStencil(UnityEngine.Rendering.RenderStateBlock block, int stencilWriteMask, int stencilRef);
                    static /*0x7cd2acc*/ UnityEngine.Mesh CreateSphereMesh();
                    static /*0x7cd30b0*/ UnityEngine.Mesh CreateHemisphereMesh();
                    static /*0x7cd01dc*/ UnityEngine.Mesh CreateFullscreenMesh();
                    /*0x7ccdbf8*/ DeferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights.InitParams initParams, bool useNativeRenderPass);
                    /*0x7ccd7a0*/ int get_GBufferAlbedoIndex();
                    /*0x7ccd7a8*/ int get_GBufferSpecularMetallicIndex();
                    /*0x7ccd7b0*/ int get_GBufferNormalSmoothnessIndex();
                    /*0x7ccd7b8*/ int get_GBufferLightingIndex();
                    /*0x7ccd7c0*/ int get_GbufferDepthIndex();
                    /*0x7ccd7d4*/ int get_GBufferRenderingLayers();
                    /*0x7ccd838*/ int get_GBufferShadowMask();
                    /*0x7ccd8a0*/ int get_GBufferSliceCount();
                    /*0x7ccd8ec*/ int get_GBufferInputAttachmentCount();
                    /*0x7ccd900*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGBufferFormat(int index);
                    /*0x7ccd890*/ bool get_UseShadowMask();
                    /*0x7ccd80c*/ bool get_UseRenderingLayers();
                    /*0x7ccda98*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_RenderingLayerMaskSize();
                    /*0x7ccdaa0*/ void set_RenderingLayerMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x7ccdaa8*/ bool get_UseDecalLayers();
                    /*0x7ccdab0*/ void set_UseDecalLayers(bool value);
                    /*0x7ccda38*/ bool get_UseLightLayers();
                    /*0x7ccdabc*/ bool get_UseFramebufferFetch();
                    /*0x7ccdac4*/ void set_UseFramebufferFetch(bool value);
                    /*0x7ccdad0*/ bool get_HasDepthPrepass();
                    /*0x7ccdad8*/ void set_HasDepthPrepass(bool value);
                    /*0x7ccdae4*/ bool get_HasNormalPrepass();
                    /*0x7ccdaec*/ void set_HasNormalPrepass(bool value);
                    /*0x7ccdaf8*/ bool get_HasRenderingLayerPrepass();
                    /*0x7ccdb00*/ void set_HasRenderingLayerPrepass(bool value);
                    /*0x7ccdb0c*/ bool get_IsOverlay();
                    /*0x7ccdb14*/ void set_IsOverlay(bool value);
                    /*0x7ccdb20*/ bool get_AccurateGbufferNormals();
                    /*0x7ccdb28*/ void set_AccurateGbufferNormals(bool value);
                    /*0x7ccdb34*/ UnityEngine.Rendering.Universal.MixedLightingSetup get_MixedLightingSetup();
                    /*0x7ccdb3c*/ void set_MixedLightingSetup(UnityEngine.Rendering.Universal.MixedLightingSetup value);
                    /*0x7ccdb44*/ bool get_UseJobSystem();
                    /*0x7ccdb4c*/ void set_UseJobSystem(bool value);
                    /*0x7ccdb58*/ int get_RenderWidth();
                    /*0x7ccdb60*/ void set_RenderWidth(int value);
                    /*0x7ccdb68*/ int get_RenderHeight();
                    /*0x7ccdb70*/ void set_RenderHeight(int value);
                    /*0x7ccdb78*/ UnityEngine.Rendering.RTHandle[] get_GbufferAttachments();
                    /*0x7ccdb80*/ void set_GbufferAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x7ccdb88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] get_GbufferTextureHandles();
                    /*0x7ccdb90*/ void set_GbufferTextureHandles(UnityEngine.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0x7ccdb98*/ UnityEngine.Rendering.RTHandle[] get_DeferredInputAttachments();
                    /*0x7ccdba0*/ void set_DeferredInputAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x7ccdba8*/ bool[] get_DeferredInputIsTransient();
                    /*0x7ccdbb0*/ void set_DeferredInputIsTransient(bool[] value);
                    /*0x7ccdbb8*/ UnityEngine.Rendering.RTHandle get_DepthAttachment();
                    /*0x7ccdbc0*/ void set_DepthAttachment(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccdbc8*/ UnityEngine.Rendering.RTHandle get_DepthCopyTexture();
                    /*0x7ccdbd0*/ void set_DepthCopyTexture(UnityEngine.Rendering.RTHandle value);
                    /*0x7ccdbd8*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_GbufferFormats();
                    /*0x7ccdbe0*/ void set_GbufferFormats(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                    /*0x7ccdbe8*/ UnityEngine.Rendering.RTHandle get_DepthAttachmentHandle();
                    /*0x7ccdbf0*/ void set_DepthAttachmentHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7cce254*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cce674*/ void SetupLights(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Vector2Int cameraTargetSizeCopy, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool isRenderGraph);
                    /*0x7ccedc4*/ void ResolveMixedLightingMode(UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7ccf23c*/ void DisableFramebufferFetchInput();
                    /*0x7ccf244*/ void ReleaseGbufferResources();
                    /*0x7ccf2d0*/ void ReAllocateGBufferIfNeeded(UnityEngine.RenderTextureDescriptor gbufferSlice, int gbufferIndex);
                    /*0x7ccef3c*/ void CreateGbufferResources();
                    /*0x7ccf4b8*/ void UpdateDeferredInputAttachments();
                    /*0x7ccf7ec*/ bool IsRuntimeSupportedThisFrame();
                    /*0x7ccf888*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, UnityEngine.Rendering.RTHandle depthCopyTexture, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RTHandle colorAttachment);
                    /*0x7ccfb20*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass);
                    /*0x7ccfb28*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7ccfffc*/ void ClearStencilPartial(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x7cd0328*/ void ExecuteDeferredPass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7ccedc0*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cd1184*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cd06e0*/ void SetupMatrixConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x7cceaa8*/ void PrecomputeLights(ref Unity.Collections.NativeArray<ushort> stencilVisLights, ref Unity.Collections.NativeArray<ushort> stencilVisLightOffsets, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLights);
                    /*0x7cd0a8c*/ bool HasStencilLightsOfType(UnityEngine.LightType type);
                    /*0x7cd0c50*/ void RenderStencilLights(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, bool stripShadowsOffVariants);
                    /*0x7cd13a8*/ void RenderStencilDirectionalLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex);
                    /*0x7cd19c8*/ void RenderStencilPointLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x7cd2040*/ void RenderStencilSpotLights(UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager);
                    /*0x7cd0b04*/ void RenderSSAOBeforeShading(UnityEngine.Rendering.RasterCommandBuffer cmd);
                    /*0x7cd0f90*/ void RenderFog(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isOrthographic);
                    /*0x7ccde94*/ void InitStencilDeferredMaterial();
                    /*0x7cd1358*/ void SetRenderingLayersMask(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Light light, int shaderPropertyID);
                    /*0x7cd2938*/ void SetAdditionalLightsShadowsKeyword(ref UnityEngine.Rendering.RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword);
                    /*0x7cd29ec*/ void SetSoftShadowsKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalShadowData shadowData, UnityEngine.Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow);
                    /*0x7cd27fc*/ void SetLightCookiesKeyword(UnityEngine.Rendering.RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex);

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

                        static /*0x7cd3ddc*/ ShaderConstants();
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

                        /*0x7cd4518*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__139_0;

                        static /*0x7cd4520*/ <>c();
                        /*0x7cd4588*/ <>c();
                        /*0x7cd4590*/ void <SetupRenderGraphLights>b__139_0(UnityEngine.Rendering.Universal.Internal.DeferredLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
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

                    static /*0x7cd9174*/ AdditionalLightsShadowCasterPass();
                    static /*0x7cd4b68*/ float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels);
                    static /*0x7cd4bd8*/ float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering);
                    static /*0x7cd7664*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x7cd4614*/ AdditionalLightsShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x7cd4b34*/ void Dispose();
                    /*0x7cd4e80*/ ulong ResolutionLog2ForHash(int resolution);
                    /*0x7cd4ecc*/ ulong ComputeShadowRequestHash(UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd51b4*/ float GetLightTypeIdentifierForShadowParams(UnityEngine.LightType lightType);
                    /*0x7cd51d4*/ bool UsesBakedShadows(UnityEngine.Light light);
                    /*0x7cd520c*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd52f0*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd7158*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x7cd6cd8*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd7204*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cd735c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cd2794*/ int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
                    /*0x7cd70e8*/ void Clear();
                    /*0x7cd7b74*/ void RenderAdditionalShadowmapAtlas(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, bool useRenderGraph);
                    /*0x7cd8500*/ void SetupAdditionalLightsShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows);
                    /*0x7cd7828*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cd7914*/ void InitRendererLists(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7cd87f0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

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

                        static /*0x7cd91c4*/ AdditionalShadowsConstantBuffer();
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

                        /*0x7cd4a98*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__61_0;

                        static /*0x7cd93ac*/ <>c();
                        /*0x7cd9414*/ <>c();
                        /*0x7cd941c*/ void <Render>b__61_0(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cdcde4*/ ForwardLights();
                    static /*0x7cd9b4c*/ int AlignByteCount(int count, int align);
                    static /*0x7cdb060*/ bool <PreSetup>g__IsProbeGreater|40_0(UnityEngine.Rendering.VisibleReflectionProbe probe, UnityEngine.Rendering.VisibleReflectionProbe otherProbe);
                    /*0x7cd94e8*/ ForwardLights();
                    /*0x7cd9514*/ ForwardLights(UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams initParams);
                    /*0x7cd9960*/ void CreateForwardPlusBuffers();
                    /*0x7cd9b3c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager get_reflectionProbeManager();
                    /*0x7cd9b60*/ void GetViewParams(UnityEngine.Camera camera, Unity.Mathematics.float4x4 viewToClip, ref float viewPlaneBot, ref float viewPlaneTop, ref Unity.Mathematics.float4 viewToViewportScaleBias);
                    /*0x7cd9cbc*/ void PreSetup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdb140*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cdbd90*/ void SetupRenderGraphLights(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdb24c*/ void SetupLights(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdc208*/ void Cleanup();
                    /*0x7cdc2d4*/ void InitializeLightConstants(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, bool supportsLightLayers, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel, ref uint lightLayerMask, ref bool isSubtractive);
                    /*0x7cdc1c0*/ void SetupShaderLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdc4d0*/ void SetupMainLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdc624*/ void SetupAdditionalLightConstants(UnityEngine.Rendering.UnsafeCommandBuffer cmd, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7cdcb68*/ int SetupPerObjectLightIndices(UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.Universal.UniversalLightData lightData);

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

                        static /*0x7cdcf90*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams Create();
                    }

                    class SetupLightPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalRenderingData renderingData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.ForwardLights forwardLights;

                        /*0x7cdd0bc*/ SetupLightPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__44_0;

                        static /*0x7cdd0c4*/ <>c();
                        /*0x7cdd12c*/ <>c();
                        /*0x7cdd134*/ void <SetupRenderGraphLights>b__44_0(UnityEngine.Rendering.Universal.Internal.ForwardLights.SetupLightPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext rgContext);
                    }
                }

                class NormalReconstruction
                {
                    static /*0x0*/ int s_NormalReconstructionMatrixID;
                    static /*0x8*/ UnityEngine.Matrix4x4[] s_NormalReconstructionMatrix;

                    static /*0x7cdd620*/ NormalReconstruction();
                    static /*0x7cdd168*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x7cdd204*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                    static /*0x7cdd580*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    static /*0x7cdd298*/ void SetupProperties(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
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

                    static /*0x7cddcb8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData passData, UnityEngine.Rendering.RTHandle internalLutTarget);
                    static /*0x7cdd8e8*/ UnityEngine.Material <.ctor>g__Load|7_0(UnityEngine.Shader shader);
                    /*0x7cdd6c4*/ ColorGradingLutPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x7cdd9d4*/ void Setup(ref UnityEngine.Rendering.RTHandle internalLut);
                    /*0x7cdd9e0*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x7cdda38*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x7cddac8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cdef3c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle internalColorLut);
                    /*0x7cdf518*/ void Cleanup();

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalPostProcessingData postProcessingData;
                        /*0x20*/ UnityEngine.Material lutBuilderLdr;
                        /*0x28*/ UnityEngine.Material lutBuilderHdr;
                        /*0x30*/ bool allowColorGradingACESHDR;
                        /*0x34*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle internalLut;

                        /*0x7cdd9cc*/ PassData();
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

                        static /*0x7cdf580*/ ShaderConstants();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__14_0;

                        static /*0x7cdf9fc*/ <>c();
                        /*0x7cdfa64*/ <>c();
                        /*0x7cdfa6c*/ void <Render>b__14_0(UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cdfca0*/ void ConfigureDescriptor(UnityEngine.Rendering.Universal.Downsampling downsamplingMethod, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    static /*0x7ce0004*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData passData, UnityEngine.Rendering.RTHandle source, bool useDrawProceduralBlit);
                    /*0x7cdfb14*/ CopyColorPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material samplingMaterial, UnityEngine.Material copyColorMaterial, string customPassName);
                    /*0x7cdfaf4*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x7cdfafc*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x7cdfb04*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7cdfb0c*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7cdfcf4*/ void Setup(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cdfd40*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7cdfd7c*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7cdfddc*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce03e4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7ce0c0c*/ void RenderToExistingTexture(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x7ce057c*/ void RenderInternal(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool useProceduralBlit);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ bool useProceduralBlit;
                        /*0x38*/ UnityEngine.Material samplingMaterial;
                        /*0x40*/ UnityEngine.Material copyColorMaterial;
                        /*0x48*/ UnityEngine.Rendering.Universal.Downsampling downsamplingMethod;
                        /*0x4c*/ int sampleOffsetShaderHandle;

                        /*0x7cdfc98*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__23_0;

                        static /*0x7ce0cb0*/ <>c();
                        /*0x7ce0d18*/ <>c();
                        /*0x7ce0d20*/ void <RenderInternal>b__23_0(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7ce12f8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData passData, UnityEngine.Rendering.RTHandle source);
                    /*0x7ce0e14*/ CopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Shader copyDepthShader, bool shouldClear, bool copyToDepth, bool copyResolvedDepth, string customPassName);
                    /*0x7ce0da8*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x7ce0db0*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce0db8*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7ce0dc0*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce0dc8*/ int get_MssaSamples();
                    /*0x7ce0dd0*/ void set_MssaSamples(int value);
                    /*0x7ce0dd8*/ bool get_CopyToDepth();
                    /*0x7ce0de0*/ void set_CopyToDepth(bool value);
                    /*0x7ce0dec*/ bool get_CopyToDepthXR();
                    /*0x7ce0df4*/ void set_CopyToDepthXR(bool value);
                    /*0x7ce0e00*/ bool get_CopyToBackbuffer();
                    /*0x7ce0e08*/ void set_CopyToBackbuffer(bool value);
                    /*0x7ce1018*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                    /*0x7ce1054*/ void Dispose();
                    /*0x7ce10b0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce10f8*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce1944*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7ce19f8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, bool bindAsCameraDepth, string passName);
                    /*0x7ce1ae8*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.UniversalResourceData resourceData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, bool bindAsCameraDepth, string passName);

                    class ShaderConstants
                    {
                        static /*0x0*/ int _CameraDepthAttachment;
                        static /*0x4*/ int _CameraDepthTexture;
                        static /*0x8*/ int _ZWriteShaderHandle;

                        static /*0x7ce23d8*/ ShaderConstants();
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

                        /*0x7ce1010*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__38_0;

                        static /*0x7ce24a0*/ <>c();
                        /*0x7ce2508*/ <>c();
                        /*0x7ce2510*/ void <Render>b__38_0(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DeferredPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xb8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                    /*0x7ce2594*/ DeferredPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x7ce2660*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescripor);
                    /*0x7ce26e0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce27fc*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer);
                    /*0x7ce3004*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.UniversalCameraData cameraData;
                        /*0x18*/ UnityEngine.Rendering.Universal.UniversalLightData lightData;
                        /*0x20*/ UnityEngine.Rendering.Universal.UniversalShadowData shadowData;
                        /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle color;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x50*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;

                        /*0x7ce3020*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__5_0;

                        static /*0x7ce3028*/ <>c();
                        /*0x7ce3090*/ <>c();
                        /*0x7ce3098*/ void <Render>b__5_0(UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7ce45d0*/ DepthNormalOnlyPass();
                    static /*0x7ce32d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat();
                    static /*0x7ce3598*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData passData, UnityEngine.Rendering.RendererList rendererList);
                    /*0x7ce312c*/ DepthNormalOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x7ce30c8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> get_shaderTagIds();
                    /*0x7ce30d0*/ void set_shaderTagIds(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> value);
                    /*0x7ce30d8*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                    /*0x7ce30e0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce30e8*/ UnityEngine.Rendering.RTHandle get_normalHandle();
                    /*0x7ce30f0*/ void set_normalHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce30f8*/ UnityEngine.Rendering.RTHandle get_renderingLayersHandle();
                    /*0x7ce3100*/ void set_renderingLayersHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce3108*/ bool get_enableRenderingLayers();
                    /*0x7ce3110*/ void set_enableRenderingLayers(bool value);
                    /*0x7ce311c*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_renderingLayersMaskSize();
                    /*0x7ce3124*/ void set_renderingLayersMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x7ce331c*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle);
                    /*0x7ce3354*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle, UnityEngine.Rendering.RTHandle decalLayerHandle);
                    /*0x7ce33a8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce3694*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce3ac0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7ce3948*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7ce3ba4*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;
                        /*0x30*/ bool enableRenderingLayers;
                        /*0x34*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;
                        /*0x38*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x7ce32c8*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__42_0;

                        static /*0x7ce4870*/ <>c();
                        /*0x7ce48d8*/ <>c();
                        /*0x7ce48e0*/ void <Render>b__42_0(UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7ce58d8*/ DepthOnlyPass();
                    static /*0x7ce4ca4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
                    /*0x7ce49b8*/ DepthOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x7ce4998*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x7ce49a0*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x7ce49a8*/ UnityEngine.Rendering.ShaderTagId get_shaderTagId();
                    /*0x7ce49b0*/ void set_shaderTagId(UnityEngine.Rendering.ShaderTagId value);
                    /*0x7ce4b88*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle depthAttachmentHandle);
                    /*0x7ce4bbc*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce4dc4*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce4fd0*/ UnityEngine.Rendering.RendererListParams InitRendererListParams(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData);
                    /*0x7ce5148*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, uint batchLayerMask, bool setGlobalDepth);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList;

                        /*0x7ce4b80*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__20_0;

                        static /*0x7ce5980*/ <>c();
                        /*0x7ce59e8*/ <>c();
                        /*0x7ce59f0*/ void <Render>b__20_0(UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7ce77b8*/ DrawObjectsPass();
                    static /*0x7ce6778*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList objectsWithErrorRendererList, bool yFlip);
                    /*0x7ce5a94*/ DrawObjectsPass(string profilerTag, UnityEngine.Rendering.ShaderTagId[] shaderTagIds, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7ce5f0c*/ DrawObjectsPass(string profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7ce5f50*/ DrawObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7ce5be4*/ void Init(bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.ShaderTagId[] shaderTagIds);
                    /*0x7ce609c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce631c*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, uint batchLayerMask, bool isActiveTargetBackBuffer);
                    /*0x7ce6384*/ void InitRendererLists(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, ref UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7ce69b4*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, uint batchLayerMask);

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

                        /*0x7ce6094*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x7ce7820*/ <>c();
                        /*0x7ce7888*/ <>c();
                        /*0x7ce7890*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class DrawObjectsWithRenderingLayersPass : UnityEngine.Rendering.Universal.Internal.DrawObjectsPass
                {
                    /*0x160*/ UnityEngine.Rendering.RTHandle[] m_ColorTargetIndentifiers;
                    /*0x168*/ UnityEngine.Rendering.RTHandle m_DepthTargetIndentifiers;

                    /*0x7ce79e4*/ DrawObjectsWithRenderingLayersPass(UnityEngine.Rendering.Universal.URPProfileId profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x7ce7ad0*/ void Setup(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle renderingLayersTexture, UnityEngine.Rendering.RTHandle depthAttachment);
                    /*0x7ce7c50*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7ce7c5c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce7d08*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle renderingLayersTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize, uint batchLayerMask);

                    class RenderingLayersPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData basePassData;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize;

                        /*0x7ce8a58*/ RenderingLayersPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__7_0;

                        static /*0x7ce8ac4*/ <>c();
                        /*0x7ce8b2c*/ <>c();
                        /*0x7ce8b34*/ void <Render>b__7_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass.RenderingLayersPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                    }
                }

                class FinalBlitPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraDepthTextureID;
                    /*0xb8*/ UnityEngine.Rendering.RTHandle m_Source;
                    /*0xc0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData m_PassData;
                    /*0xc8*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData[] m_BlitMaterialData;

                    static /*0x7cea974*/ FinalBlitPass();
                    static /*0x7ce8fb0*/ void SetupHDROutput(UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperation, UnityEngine.Vector4 hdrOutputParameters, bool rendersOverlayUI);
                    static /*0x7ce9ce8*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.UniversalCameraData cameraData);
                    /*0x7ce8d10*/ FinalBlitPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial, UnityEngine.Material blitHDRMaterial);
                    /*0x7ce8f54*/ void Dispose();
                    /*0x7ce8f58*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                    /*0x7ce8fa4*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle colorHandle);
                    /*0x7ce90c8*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce91ac*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ce9c40*/ void InitPassData(UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData passData, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitType blitType, bool enableAlphaOutput);
                    /*0x7ce9f94*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle src, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle dest, UnityEngine.Rendering.RenderGraphModule.TextureHandle overlayUITexture);

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

                        /*0x7ce8f4c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__17_0;

                        static /*0x7cea9dc*/ <>c();
                        /*0x7ceaa44*/ <>c();
                        /*0x7ceaa4c*/ void <Render>b__17_0(UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cecb08*/ GBufferPass();
                    static /*0x7cebde4*/ void ExecutePass(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RendererList rendererList, UnityEngine.Rendering.RendererList errorRendererList);
                    /*0x7ceae00*/ GBufferPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x7ceb414*/ void Dispose();
                    /*0x7ceb428*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7ceb724*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ceba60*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, bool useRenderGraph);
                    /*0x7cebf0c*/ void Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraColor, UnityEngine.Rendering.RenderGraphModule.TextureHandle cameraDepth, bool setGlobalTextures);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x28*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;
                        /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererListHdl;
                        /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle objectsWithErrorRendererListHdl;
                        /*0x48*/ UnityEngine.Rendering.RendererList rendererList;
                        /*0x60*/ UnityEngine.Rendering.RendererList objectsWithErrorRendererList;

                        /*0x7ceb40c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__21_0;

                        static /*0x7cecd14*/ <>c();
                        /*0x7cecd7c*/ <>c();
                        /*0x7cecd84*/ void <Render>b__21_0(UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cef718*/ MainLightShadowCasterPass();
                    static /*0x7cede64*/ void SetShadowParamsForEmptyShadowmap(UnityEngine.Rendering.RasterCommandBuffer rasterCommandBuffer);
                    /*0x7cece40*/ MainLightShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x7ced0b8*/ void Dispose();
                    /*0x7ced0ec*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ced1d0*/ bool Setup(UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7ced988*/ void UpdateTextureDescriptorIfNeeded();
                    /*0x7ced694*/ bool SetupForEmptyRendering(bool stripShadowsOffVariants, UnityEngine.Light light, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7ceda34*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x7cedb8c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x7ced840*/ void Clear();
                    /*0x7cee214*/ void RenderMainLightCascadeShadowmap(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, bool isRenderGraph);
                    /*0x7cee8bc*/ void SetupMainLightShadowReceiverConstants(UnityEngine.Rendering.RasterCommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cedf3c*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.Universal.UniversalRenderingData renderingData, UnityEngine.Rendering.Universal.UniversalCameraData cameraData, UnityEngine.Rendering.Universal.UniversalLightData lightData, UnityEngine.Rendering.Universal.UniversalShadowData shadowData);
                    /*0x7cedfe8*/ void InitRendererLists(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, bool useRenderGraph);
                    /*0x7ceede0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.ContextContainer frameData);

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

                        static /*0x7cef778*/ MainLightShadowConstantBuffer();
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

                        /*0x7ced01c*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__38_0;

                        static /*0x7cef9b8*/ <>c();
                        /*0x7cefa20*/ <>c();
                        /*0x7cefa28*/ void <Render>b__38_0(UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
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

                    static /*0x7cf0264*/ RenderTargetBufferSystem();
                    /*0x7cefbc8*/ RenderTargetBufferSystem(string name);
                    /*0x7cefaf0*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_backBuffer();
                    /*0x7cefb5c*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_frontBuffer();
                    /*0x7cefc78*/ void Dispose();
                    /*0x7cefccc*/ UnityEngine.Rendering.RTHandle PeekBackBuffer();
                    /*0x7cefd14*/ UnityEngine.Rendering.RTHandle GetBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7ceff74*/ UnityEngine.Rendering.RTHandle GetFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cf0000*/ void Swap();
                    /*0x7cefd2c*/ void ReAllocate(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7cf0060*/ void Clear();
                    /*0x7cf00dc*/ void SetCameraSettings(UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x7cf023c*/ UnityEngine.Rendering.RTHandle GetBufferA();
                    /*0x7cf01c0*/ void EnableMSAA(bool enable);

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
