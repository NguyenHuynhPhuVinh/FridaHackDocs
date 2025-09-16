class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7b263f8*/ EmbeddedAttribute();
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
                /*0x7b26400*/ IsUnmanagedAttribute();
            }
        }
    }
}

class RenderGraphCompilationCache
{
    static int k_CachedGraphCount = 20;
    static /*0x0*/ UnityEngine.Rendering.DynamicArray.SortComparer<RenderGraphCompilationCache.HashEntry<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph>> s_EntryComparer;
    static /*0x8*/ UnityEngine.Rendering.DynamicArray.SortComparer<RenderGraphCompilationCache.HashEntry<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData>> s_NativeEntryComparer;
    static /*0x10*/ int s_Hash;
    /*0x10*/ UnityEngine.Rendering.DynamicArray<RenderGraphCompilationCache.HashEntry<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph>> m_HashEntries;
    /*0x18*/ UnityEngine.Rendering.DynamicArray<RenderGraphCompilationCache.HashEntry<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData>> m_NativeHashEntries;
    /*0x20*/ System.Collections.Generic.Stack<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph> m_CompiledGraphPool;
    /*0x28*/ System.Collections.Generic.Stack<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData> m_NativeCompiledGraphPool;

    static /*0x7b2693c*/ RenderGraphCompilationCache();
    static /*0x3910ae8*/ int HashEntryComparer<T>(RenderGraphCompilationCache.HashEntry<T> a, RenderGraphCompilationCache.HashEntry<T> b);
    /*0x7b26408*/ RenderGraphCompilationCache();
    /*0x3910ae8*/ bool GetCompilationCache<T>(int hash, int frameIndex, ref T outGraph, UnityEngine.Rendering.DynamicArray<RenderGraphCompilationCache.HashEntry<T>> hashEntries, System.Collections.Generic.Stack<T> pool, UnityEngine.Rendering.DynamicArray.SortComparer<RenderGraphCompilationCache.HashEntry<T>> comparer);
    /*0x7b26654*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph outGraph);
    /*0x7b2670c*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData outGraph);
    /*0x7b267c4*/ void Clear();

    struct HashEntry<T>
    {
        /*0x0*/ int hash;
        /*0x0*/ int lastFrameUsed;
        /*0x0*/ T compiledGraph;
    }

    class <>c__<T>
    {
        static /*0x0*/ RenderGraphCompilationCache.<>c__11<T> <>9;
        static /*0x0*/ System.Predicate<RenderGraphCompilationCache.HashEntry<T>> <>9__11_0;

        static /*0x383e7a0*/ <>c__();
        /*0x38159dc*/ <>c__();
        /*0x3910ae8*/ bool <GetCompilationCache>b__11_0(RenderGraphCompilationCache.HashEntry<T> value);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7b26a3c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7b26b30*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    class LightAnchor : UnityEngine.MonoBehaviour
    {
        static float k_ArcRadius = 5;
        static float k_AxisLength = 10;
        static float k_MaxDistance = 10000;
        /*0x20*/ float m_Distance;
        /*0x24*/ UnityEngine.LightAnchor.UpDirection m_FrameSpace;
        /*0x28*/ UnityEngine.Transform m_AnchorPositionOverride;
        /*0x30*/ UnityEngine.Vector3 m_AnchorPositionOffset;
        /*0x3c*/ float m_Yaw;
        /*0x40*/ float m_Pitch;
        /*0x44*/ float m_Roll;

        static /*0x7b26b78*/ float NormalizeAngleDegree(float angle);
        /*0x7b27fb8*/ LightAnchor();
        /*0x7b26b38*/ float get_yaw();
        /*0x7b26b40*/ void set_yaw(float value);
        /*0x7b26bac*/ float get_pitch();
        /*0x7b26bb4*/ void set_pitch(float value);
        /*0x7b26bec*/ float get_roll();
        /*0x7b26bf4*/ void set_roll(float value);
        /*0x7b26c2c*/ float get_distance();
        /*0x7b26c34*/ void set_distance(float value);
        /*0x7b26c54*/ UnityEngine.LightAnchor.UpDirection get_frameSpace();
        /*0x7b26c5c*/ void set_frameSpace(UnityEngine.LightAnchor.UpDirection value);
        /*0x7b26c64*/ UnityEngine.Vector3 get_anchorPosition();
        /*0x7b26d70*/ UnityEngine.Transform get_anchorPositionOverride();
        /*0x7b26d78*/ void set_anchorPositionOverride(UnityEngine.Transform value);
        /*0x7b26d80*/ UnityEngine.Vector3 get_anchorPositionOffset();
        /*0x7b26d8c*/ void set_anchorPositionOffset(UnityEngine.Vector3 value);
        /*0x7b26d98*/ void SynchronizeOnTransform(UnityEngine.Camera camera);
        /*0x7b27aa4*/ void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x7b27270*/ UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x7b27de8*/ void Update();
        /*0x7b27ee8*/ void OnDrawGizmosSelected();
        /*0x7b27b0c*/ void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor);

        enum UpDirection
        {
            World = 0,
            Local = 1,
        }

        struct Axes
        {
            /*0x10*/ UnityEngine.Vector3 up;
            /*0x1c*/ UnityEngine.Vector3 right;
            /*0x28*/ UnityEngine.Vector3 forward;
        }
    }

    namespace Experimental
    {
        namespace Rendering
        {
            class XRBuiltinShaderConstants
            {
                static /*0x0*/ int unity_StereoCameraProjection;
                static /*0x4*/ int unity_StereoCameraInvProjection;
                static /*0x8*/ int unity_StereoMatrixV;
                static /*0xc*/ int unity_StereoMatrixInvV;
                static /*0x10*/ int unity_StereoMatrixP;
                static /*0x14*/ int unity_StereoMatrixInvP;
                static /*0x18*/ int unity_StereoMatrixVP;
                static /*0x1c*/ int unity_StereoMatrixInvVP;
                static /*0x20*/ int unity_StereoWorldSpaceCameraPos;
                static /*0x28*/ UnityEngine.Matrix4x4[] s_cameraProjMatrix;
                static /*0x30*/ UnityEngine.Matrix4x4[] s_invCameraProjMatrix;
                static /*0x38*/ UnityEngine.Matrix4x4[] s_viewMatrix;
                static /*0x40*/ UnityEngine.Matrix4x4[] s_invViewMatrix;
                static /*0x48*/ UnityEngine.Matrix4x4[] s_projMatrix;
                static /*0x50*/ UnityEngine.Matrix4x4[] s_invProjMatrix;
                static /*0x58*/ UnityEngine.Matrix4x4[] s_viewProjMatrix;
                static /*0x60*/ UnityEngine.Matrix4x4[] s_invViewProjMatrix;
                static /*0x68*/ UnityEngine.Vector4[] s_worldSpaceCameraPos;

                static /*0x7b28eac*/ XRBuiltinShaderConstants();
                static /*0x7b27fc0*/ void UpdateBuiltinShaderConstants(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex);
                static /*0x7b2849c*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x7b285ec*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.RasterCommandBuffer cmd);
                static /*0x7b2864c*/ void Update(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
            }

            class XRLayout
            {
                /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> m_ActivePasses;

                /*0x7b2a478*/ XRLayout();
                /*0x7b291fc*/ void AddCamera(UnityEngine.Camera camera, bool enableXR);
                /*0x7b29ac0*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                /*0x7b29dec*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> GetActivePasses();
                /*0x7b299c0*/ void AddPass(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7b29df4*/ void Clear();
                /*0x7b29f20*/ void LogDebugInfo();
            }

            class XRLayoutStack : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.XRLayout> m_Stack;

                /*0x7b2a78c*/ XRLayoutStack();
                /*0x7b2a500*/ UnityEngine.Experimental.Rendering.XRLayout New();
                /*0x7b2a5ac*/ UnityEngine.Experimental.Rendering.XRLayout get_top();
                /*0x7b2a5fc*/ void Release();
                /*0x7b2a6f8*/ void Dispose();
            }

            class XRMirrorView
            {
                static /*0x0*/ UnityEngine.MaterialPropertyBlock s_MirrorViewMaterialProperty;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler k_MirrorViewProfilingSampler;
                static /*0x10*/ int k_SourceTex;
                static /*0x14*/ int k_SourceTexArraySlice;
                static /*0x18*/ int k_ScaleBias;
                static /*0x1c*/ int k_ScaleBiasRt;
                static /*0x20*/ int k_SRGBRead;
                static /*0x24*/ int k_SRGBWrite;
                static /*0x28*/ int k_MaxNits;
                static /*0x2c*/ int k_SourceMaxNits;
                static /*0x30*/ int k_SourceHDREncoding;
                static /*0x34*/ int k_ColorTransform;

                static /*0x7b2b688*/ XRMirrorView();
                static /*0x7b2a814*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Material mat, UnityEngine.XR.XRDisplaySubsystem display);
            }

            class XROcclusionMesh
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler k_OcclusionMeshProfilingSampler;
                /*0x10*/ UnityEngine.Experimental.Rendering.XRPass m_Pass;
                /*0x18*/ UnityEngine.Mesh m_CombinedMesh;
                /*0x20*/ UnityEngine.Material m_Material;
                /*0x28*/ int m_CombinedMeshHashCode;

                static /*0x7b2c6dc*/ XROcclusionMesh();
                /*0x7b2b934*/ XROcclusionMesh(UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7b2b964*/ void SetMaterial(UnityEngine.Material mat);
                /*0x7b2b96c*/ bool get_hasValidOcclusionMesh();
                /*0x7b2bb2c*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, float occlusionMeshScale, bool yFlip);
                /*0x7b2c1c0*/ void UpdateCombinedMesh();
                /*0x7b2ba30*/ bool IsOcclusionMeshSupported();
                /*0x7b2c294*/ bool TryGetOcclusionMeshCombinedHashCode(ref int hashCode);
                /*0x7b2c388*/ void CreateOcclusionMeshCombined();
            }

            struct XRPassCreateInfo
            {
                /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier renderTarget;
                /*0x38*/ UnityEngine.RenderTextureDescriptor renderTargetDesc;
                /*0x70*/ UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget;
                /*0x98*/ UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc;
                /*0xd0*/ UnityEngine.Rendering.ScriptableCullingParameters cullingParameters;
                /*0x708*/ UnityEngine.Material occlusionMeshMaterial;
                /*0x710*/ float occlusionMeshScale;
                /*0x718*/ nint foveatedRenderingInfo;
                /*0x720*/ int multipassId;
                /*0x724*/ int cullingPassId;
                /*0x728*/ bool copyDepth;
                /*0x729*/ bool hasMotionVectorPass;
                /*0x730*/ UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrSdkRenderPass;
            }

            class XRPass
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.XRView> m_Views;
                /*0x18*/ UnityEngine.Experimental.Rendering.XROcclusionMesh m_OcclusionMesh;
                /*0x20*/ bool <copyDepth>k__BackingField;
                /*0x21*/ bool <hasMotionVectorPass>k__BackingField;
                /*0x24*/ int <multipassId>k__BackingField;
                /*0x28*/ int <cullingPassId>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier <renderTarget>k__BackingField;
                /*0x58*/ UnityEngine.RenderTextureDescriptor <renderTargetDesc>k__BackingField;
                /*0x90*/ UnityEngine.Rendering.RenderTargetIdentifier <motionVectorRenderTarget>k__BackingField;
                /*0xb8*/ UnityEngine.RenderTextureDescriptor <motionVectorRenderTargetDesc>k__BackingField;
                /*0xf0*/ UnityEngine.Rendering.ScriptableCullingParameters <cullingParams>k__BackingField;
                /*0x728*/ nint <foveatedRenderingInfo>k__BackingField;
                /*0x730*/ float <occlusionMeshScale>k__BackingField;

                static /*0x7b2c84c*/ UnityEngine.Experimental.Rendering.XRPass CreateDefault(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7b2c778*/ XRPass();
                /*0x7b2cb80*/ void Release();
                /*0x7b28d4c*/ bool get_enabled();
                /*0x7b2cbec*/ bool get_supportsFoveatedRendering();
                /*0x7b2cca0*/ bool get_copyDepth();
                /*0x7b2cca8*/ void set_copyDepth(bool value);
                /*0x7b2ccb4*/ bool get_hasMotionVectorPass();
                /*0x7b2ccbc*/ void set_hasMotionVectorPass(bool value);
                /*0x7b2ccc8*/ bool get_isFirstCameraPass();
                /*0x7b2ccd8*/ bool get_isLastCameraPass();
                /*0x7b2cd44*/ int get_multipassId();
                /*0x7b2cd4c*/ void set_multipassId(int value);
                /*0x7b2cd54*/ int get_cullingPassId();
                /*0x7b2cd5c*/ void set_cullingPassId(int value);
                /*0x7b2cd64*/ UnityEngine.Rendering.RenderTargetIdentifier get_renderTarget();
                /*0x7b2cd78*/ void set_renderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b2cd8c*/ UnityEngine.RenderTextureDescriptor get_renderTargetDesc();
                /*0x7b2cdac*/ void set_renderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x7b2cdcc*/ UnityEngine.Rendering.RenderTargetIdentifier get_motionVectorRenderTarget();
                /*0x7b2cde0*/ void set_motionVectorRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b2cdf4*/ UnityEngine.RenderTextureDescriptor get_motionVectorRenderTargetDesc();
                /*0x7b2ce14*/ void set_motionVectorRenderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x7b2ce34*/ UnityEngine.Rendering.ScriptableCullingParameters get_cullingParams();
                /*0x7b2ce44*/ void set_cullingParams(UnityEngine.Rendering.ScriptableCullingParameters value);
                /*0x7b2a430*/ int get_viewCount();
                /*0x7b28e94*/ bool get_singlePassEnabled();
                /*0x7b2ce5c*/ nint get_foveatedRenderingInfo();
                /*0x7b2ce64*/ void set_foveatedRenderingInfo(nint value);
                /*0x7b2ce6c*/ bool get_isHDRDisplayOutputActive();
                /*0x7b2cf18*/ UnityEngine.ColorGamut get_hdrDisplayOutputColorGamut();
                /*0x7b2cfc4*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation();
                /*0x7b2d1e8*/ float get_occlusionMeshScale();
                /*0x7b2d1f0*/ void set_occlusionMeshScale(float value);
                /*0x7b28dfc*/ UnityEngine.Matrix4x4 GetProjMatrix(int viewIndex);
                /*0x7b28d64*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7b2d1f8*/ bool GetPrevViewValid(int viewIndex);
                /*0x7b2d270*/ UnityEngine.Matrix4x4 GetPrevViewMatrix(int viewIndex);
                /*0x7b2a344*/ UnityEngine.Rect GetViewport(int viewIndex);
                /*0x7b2bab8*/ UnityEngine.Mesh GetOcclusionMesh(int viewIndex);
                /*0x7b2a3bc*/ int GetTextureArraySlice(int viewIndex);
                /*0x7b2bfd8*/ void StartSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b2d308*/ void StartSinglePass(UnityEngine.Rendering.IRasterCommandBuffer cmd);
                /*0x7b2bf1c*/ void StopSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b2d388*/ void StopSinglePass(UnityEngine.Rendering.BaseCommandBuffer cmd);
                /*0x7b2d3a0*/ bool get_hasValidOcclusionMesh();
                /*0x7b2d3b8*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
                /*0x7b2d3e8*/ void RenderOcclusionMesh(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7b2d420*/ void RenderDebugXRViewsFrustum();
                /*0x7b2d690*/ UnityEngine.Vector4 ApplyXRViewCenterOffset(UnityEngine.Vector2 center);
                /*0x7b2d7d4*/ void AssignView(int viewId, UnityEngine.Experimental.Rendering.XRView xrView);
                /*0x7b2d8d4*/ void AssignCullingParams(int cullingPassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                /*0x7b29dd4*/ void UpdateCombinedOcclusionMesh();
                /*0x7b2c92c*/ void InitBase(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7b2d964*/ void AddView(UnityEngine.Experimental.Rendering.XRView xrView);
            }

            class SinglepassKeywords
            {
                static /*0x0*/ UnityEngine.Rendering.GlobalKeyword STEREO_MULTIVIEW_ON;
                static /*0x10*/ UnityEngine.Rendering.GlobalKeyword STEREO_INSTANCING_ON;
            }

            class XRSystem
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.XRLayoutStack s_Layout;
                static /*0x8*/ System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> s_PassAllocator;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.XR.XRDisplaySubsystem> s_DisplayList;
                static /*0x18*/ UnityEngine.XR.XRDisplaySubsystem s_Display;
                static /*0x20*/ UnityEngine.Rendering.MSAASamples s_MSAASamples;
                static /*0x24*/ float s_OcclusionMeshScaling;
                static /*0x28*/ UnityEngine.Material s_OcclusionMeshMaterial;
                static /*0x30*/ UnityEngine.Material s_MirrorViewMaterial;
                static /*0x38*/ System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> s_LayoutOverride;
                static /*0x40*/ UnityEngine.Experimental.Rendering.XRPass emptyPass;
                static /*0x48*/ bool <singlePassAllowed>k__BackingField;
                static /*0x4c*/ UnityEngine.Rendering.FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField;
                static /*0x50*/ bool <dumpDebugInfo>k__BackingField;

                static /*0x7b2f860*/ XRSystem();
                static /*0x7b2db7c*/ UnityEngine.XR.XRDisplaySubsystem GetActiveDisplay();
                static /*0x7b293ac*/ bool get_displayActive();
                static /*0x7b2dbd4*/ bool get_isHDRDisplayOutputActive();
                static /*0x7b2dc84*/ bool get_singlePassAllowed();
                static /*0x7b2dcdc*/ void set_singlePassAllowed(bool value);
                static /*0x7b2dd3c*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
                static /*0x7b2dd94*/ void set_foveatedRenderingCaps(UnityEngine.Rendering.FoveatedRenderingCaps value);
                static /*0x7b2ddf0*/ bool get_dumpDebugInfo();
                static /*0x7b2de48*/ void set_dumpDebugInfo(bool value);
                static /*0x7b2dea8*/ void Initialize(System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> passAllocator, UnityEngine.Shader occlusionMeshPS, UnityEngine.Shader mirrorViewPS);
                static /*0x7b2e5b8*/ void SetDisplayMSAASamples(UnityEngine.Rendering.MSAASamples msaaSamples);
                static /*0x7b2e7c8*/ UnityEngine.Rendering.MSAASamples GetDisplayMSAASamples();
                static /*0x7b2e820*/ void SetOcclusionMeshScale(float occlusionMeshScale);
                static /*0x7b2e884*/ float GetOcclusionMeshScale();
                static /*0x7b2e8dc*/ void SetMirrorViewMode(int mirrorBlitMode);
                static /*0x7b2e974*/ int GetMirrorViewMode();
                static /*0x7b2ea08*/ void SetRenderScale(float renderScale);
                static /*0x7b2ebe0*/ float GetRenderViewportScale();
                static /*0x7b2ec44*/ UnityEngine.Experimental.Rendering.XRLayout NewLayout();
                static /*0x7b2eca8*/ void EndLayout();
                static /*0x7b2ed80*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                static /*0x7b2ee20*/ void Dispose();
                static /*0x7b29440*/ void SetDisplayZRange(float zNear, float zFar);
                static /*0x7b2efc0*/ void SetLayoutOverride(System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> action);
                static /*0x7b2f020*/ void XRSystemInit();
                static /*0x7b2e2d0*/ void RefreshDeviceInfo();
                static /*0x7b29504*/ void CreateDefaultLayout(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRLayout layout);
                static /*0x7b29b4c*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                static /*0x7b2f0e4*/ bool CanUseSinglePass(UnityEngine.Camera camera, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
                static /*0x7b2f5ac*/ UnityEngine.Experimental.Rendering.XRView BuildView(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                static /*0x7b2f7a4*/ UnityEngine.RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(UnityEngine.RenderTextureDescriptor xrDesc);
                static /*0x7b2f224*/ UnityEngine.Experimental.Rendering.XRPassCreateInfo BuildPass(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrRenderPass, UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, UnityEngine.Experimental.Rendering.XRLayout layout);
                static /*0x7b2f48c*/ void <CreateDefaultLayout>g__AddViewToPass|44_0(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, int renderParamIndex, ref UnityEngine.Experimental.Rendering.XRSystem.<> );

                struct <>c__DisplayClass44_0
                {
                    /*0x10*/ UnityEngine.Camera camera;
                }
            }

            struct XRView
            {
                /*0x10*/ UnityEngine.Matrix4x4 projMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 prevViewMatrix;
                /*0xd0*/ UnityEngine.Rect viewport;
                /*0xe0*/ UnityEngine.Mesh occlusionMesh;
                /*0xe8*/ int textureArraySlice;
                /*0xec*/ UnityEngine.Vector2 eyeCenterUV;
                /*0xf4*/ bool isPrevViewMatrixValid;

                static /*0x7b2f9bc*/ UnityEngine.Vector2 ComputeEyeCenterUV(UnityEngine.Matrix4x4 proj);
                /*0x7b2f704*/ XRView(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, UnityEngine.Rect viewport, UnityEngine.Mesh occlusionMesh, int textureArraySlice);
            }
        }
    }

    namespace Rendering
    {
        interface IPerFrameHistoryAccessTracker
        {
            /*0x38159dc*/ void RequestAccess<Type>();
        }

        interface ICameraHistoryWriteAccess
        {
            /*0x3813ffc*/ bool IsAccessRequested<Type>();
            /*0x3910ae8*/ Type GetHistoryForWrite<Type>();
            /*0x3813ffc*/ bool IsWritten<Type>();
        }

        interface ICameraHistoryReadAccess
        {
            /*0x3910ae8*/ Type GetHistoryForRead<Type>();
            /*0x3816710*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
            /*0x3816710*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);

            class HistoryRequestDelegate : System.MulticastDelegate
            {
                /*0x7b2fa5c*/ HistoryRequestDelegate(object object, nint method);
                /*0x7b2fb64*/ void Invoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess);
                /*0x7b2fb78*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess, System.AsyncCallback callback, object object);
                /*0x7b2fb98*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class CameraHistoryItem : UnityEngine.Rendering.ContextItem
        {
            /*0x10*/ UnityEngine.Rendering.BufferedRTHandleSystem m_owner;
            /*0x18*/ uint m_TypeId;

            /*0x7b2fc90*/ CameraHistoryItem();
            /*0x7b2fba4*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
            /*0x7b2fbd0*/ UnityEngine.Rendering.BufferedRTHandleSystem get_storage();
            /*0x7b2fbd8*/ int MakeId(uint index);
            /*0x7b2fbe8*/ UnityEngine.Rendering.RTHandle AllocHistoryFrameRT(int id, int count, ref UnityEngine.RenderTextureDescriptor desc, string name);
            /*0x7b2fc54*/ void ReleaseHistoryFrameRT(int id);
            /*0x7b2fc70*/ UnityEngine.Rendering.RTHandle GetPreviousFrameRT(int id);
            /*0x7b2fc34*/ UnityEngine.Rendering.RTHandle GetCurrentFrameRT(int id);
        }

        class CameraSwitcher : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Camera[] m_Cameras;
            /*0x28*/ int m_CurrentCameraIndex;
            /*0x30*/ UnityEngine.Camera m_OriginalCamera;
            /*0x38*/ UnityEngine.Vector3 m_OriginalCameraPosition;
            /*0x44*/ UnityEngine.Quaternion m_OriginalCameraRotation;
            /*0x58*/ UnityEngine.Camera m_CurrentCamera;
            /*0x60*/ UnityEngine.GUIContent[] m_CameraNames;
            /*0x68*/ int[] m_CameraIndices;
            /*0x70*/ UnityEngine.Rendering.DebugUI.EnumField m_DebugEntry;
            /*0x78*/ int m_DebugEntryEnumIndex;

            /*0x7b305a0*/ CameraSwitcher();
            /*0x7b2fca8*/ void OnEnable();
            /*0x7b3029c*/ void OnDisable();
            /*0x7b3027c*/ int GetCameraCount();
            /*0x7b3032c*/ UnityEngine.Camera GetNextCamera();
            /*0x7b30374*/ void SetCameraIndex(int index);
            /*0x7b305b0*/ int <OnEnable>b__10_0();
            /*0x7b305b8*/ void <OnEnable>b__10_1(int value);
            /*0x7b305bc*/ int <OnEnable>b__10_2();
            /*0x7b305c4*/ void <OnEnable>b__10_3(int value);
        }

        class FreeCamera : UnityEngine.MonoBehaviour
        {
            static float k_MouseSensitivityMultiplier = 0.009999999776482582;
            /*0x20*/ float m_LookSpeedController;
            /*0x24*/ float m_LookSpeedMouse;
            /*0x28*/ float m_MoveSpeed;
            /*0x2c*/ float m_MoveSpeedIncrement;
            /*0x30*/ float m_Turbo;
            /*0x38*/ UnityEngine.InputSystem.InputAction lookAction;
            /*0x40*/ UnityEngine.InputSystem.InputAction moveAction;
            /*0x48*/ UnityEngine.InputSystem.InputAction speedAction;
            /*0x50*/ UnityEngine.InputSystem.InputAction yMoveAction;
            /*0x58*/ float inputRotateAxisX;
            /*0x5c*/ float inputRotateAxisY;
            /*0x60*/ float inputChangeSpeed;
            /*0x64*/ float inputVertical;
            /*0x68*/ float inputHorizontal;
            /*0x6c*/ float inputYAxis;
            /*0x70*/ bool leftShiftBoost;
            /*0x71*/ bool leftShift;
            /*0x72*/ bool fire1;

            /*0x7b313dc*/ FreeCamera();
            /*0x7b305cc*/ void OnEnable();
            /*0x7b305d0*/ void RegisterInputs();
            /*0x7b30d94*/ void UpdateInputs();
            /*0x7b31014*/ void Update();
        }

        class BaseCommandBuffer
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_WrappedCommandBuffer;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_ExecutingPass;

            /*0x7b313f8*/ BaseCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b31478*/ string get_name();
            /*0x7b31494*/ int get_sizeInBytes();
            /*0x7b314b0*/ void ThrowIfGlobalStateNotAllowed();
            /*0x7b31538*/ void ThrowIfRasterNotAllowed();
            /*0x7b315cc*/ void ValidateTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x7b3179c*/ void ValidateTextureHandleRead(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x7b3190c*/ void ValidateTextureHandleWrite(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
        }

        struct CommandBufferHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rasterCmd;
            static /*0x8*/ UnityEngine.Rendering.ComputeCommandBuffer computeCmd;
            static /*0x10*/ UnityEngine.Rendering.UnsafeCommandBuffer unsafeCmd;

            static /*0x7b31d10*/ CommandBufferHelpers();
            static /*0x7b31ae8*/ UnityEngine.Rendering.RasterCommandBuffer GetRasterCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b31b64*/ UnityEngine.Rendering.ComputeCommandBuffer GetComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b31be0*/ UnityEngine.Rendering.UnsafeCommandBuffer GetUnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b31c5c*/ UnityEngine.Rendering.CommandBuffer GetNativeCommandBuffer(UnityEngine.Rendering.UnsafeCommandBuffer baseBuffer);
            static /*0x7b31c74*/ void VFXManager_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
        }

        class ComputeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x7b31e2c*/ ComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b31e3c*/ void SetInvertCulling(bool invertCulling);
            /*0x7b31e5c*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7b31e78*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7b31e94*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b31eb0*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b31ecc*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b31f18*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b31f34*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b31f50*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b31f6c*/ void DisableScissorRect();
            /*0x7b31f88*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b31fa4*/ void SetGlobalInt(int nameID, int value);
            /*0x7b31fc0*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b31fdc*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b31ff8*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b32014*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b32060*/ void EnableShaderKeyword(string keyword);
            /*0x7b3207c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b32098*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b320b4*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b320d0*/ void DisableShaderKeyword(string keyword);
            /*0x7b320ec*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b32108*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b32124*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b32140*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b32160*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b32180*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b321a0*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b32210*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b3222c*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b32248*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b32264*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b32280*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b3229c*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b322b8*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b322d4*/ void BeginSample(string name);
            /*0x7b322f0*/ void EndSample(string name);
            /*0x7b3230c*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b32328*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b32344*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b32348*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b3234c*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b32398*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b323b4*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b323d0*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7b323ec*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b32408*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b32424*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7b32440*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b3245c*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b32478*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7b32494*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7b324b0*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7b324cc*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7b324e8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b32534*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b32550*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7b3256c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7b32588*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7b325a4*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7b325c0*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b326a4*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b32788*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b32874*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b32960*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b32a5c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b32b58*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b32b74*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b32b90*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b32bb0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b32bd0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b32bec*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b32c08*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b32c24*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b32c40*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b32c5c*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b32c78*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7b32c94*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7b32cb0*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7b32ccc*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7b32ce8*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7b32d04*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b32d20*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b32d3c*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b32d58*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b32d74*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b32d90*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b32dac*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b32dc8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b32de4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b32e04*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b32e24*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b32e40*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b32e5c*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b32e78*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b32e94*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b32f68*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b3303c*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7b33058*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7b33074*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7b33090*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7b330ac*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7b330c8*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7b330e4*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7b33100*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7b3311c*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7b33138*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b33154*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7b33170*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b3318c*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b331d8*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b33224*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b33240*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b3325c*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7b33278*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b33294*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b332b0*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b332cc*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b332e8*/ void SetGlobalFloat(string name, float value);
            /*0x7b33304*/ void SetGlobalInt(string name, int value);
            /*0x7b33320*/ void SetGlobalInteger(string name, int value);
            /*0x7b3333c*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b33358*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b33374*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b333c0*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b333dc*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b333f8*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b33414*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b33430*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b3344c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b33468*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b33484*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b334a0*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b334bc*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b33588*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b33654*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b33728*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b337fc*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b33818*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b33834*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b33850*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b3386c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b33888*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b338a4*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b338c0*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b338dc*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b33928*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b33944*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b33960*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b3397c*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b339ec*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b33a08*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b33a24*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33a40*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33a5c*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b33a78*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33a94*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33ab0*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b33ad0*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b33af0*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        interface IBaseCommandBuffer
        {
            /*0x3815cc4*/ void SetInvertCulling(bool invertCulling);
            void SetViewport(UnityEngine.Rect pixelRect);
            void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x38159dc*/ void DisableScissorRect();
            /*0x3816124*/ void SetGlobalFloat(int nameID, float value);
            /*0x3815fb8*/ void SetGlobalInt(int nameID, int value);
            /*0x3815fb8*/ void SetGlobalInteger(int nameID, int value);
            /*0x38162bc*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3910ae8*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3910ae8*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x3816710*/ void EnableShaderKeyword(string keyword);
            /*0x3816710*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3816810*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3816810*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3816710*/ void DisableShaderKeyword(string keyword);
            /*0x3816710*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3816810*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3816810*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3910ae8*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x3816044*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x3816044*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x3816044*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3816710*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x3815fb8*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x3815ed0*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x3816710*/ void BeginSample(string name);
            /*0x3816710*/ void EndSample(string name);
            /*0x3816710*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3816710*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3910ae8*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3910ae8*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3816710*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x38159dc*/ void InvokeOnRenderObjectCallbacks();
            void SetGlobalFloat(string name, float value);
            /*0x381678c*/ void SetGlobalInt(string name, int value);
            /*0x381678c*/ void SetGlobalInteger(string name, int value);
            void SetGlobalVector(string name, UnityEngine.Vector4 value);
            void SetGlobalColor(string name, UnityEngine.Color value);
            void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x3816810*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x3816044*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x3816810*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x3816810*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3816044*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3816810*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x3816810*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3816044*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3816810*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3910ae8*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3910ae8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3910ae8*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3910ae8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3816810*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x3816044*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3816810*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x3816044*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3910ae8*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3815ed0*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3910ae8*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3910ae8*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3910ae8*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3910ae8*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
        }

        interface IComputeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3910ae8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3816810*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x3816810*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x3816920*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x3910ae8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3816920*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3816920*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x3816920*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3910ae8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3910ae8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3910ae8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3910ae8*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3910ae8*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x3816710*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x3816920*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3816920*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3816920*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3910ae8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3910ae8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3910ae8*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3910ae8*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x3816920*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x3816920*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x3816920*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3910ae8*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3910ae8*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3816920*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3910ae8*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
        }

        interface IRasterCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x3910ae8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x3910ae8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x3910ae8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3910ae8*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3910ae8*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x3817158*/ void SetInstanceMultiplier(uint multiplier);
            /*0x3815ed0*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x3815cc4*/ void SetWireframe(bool enable);
            void ConfigureFoveatedRendering(nint platformData);
            /*0x3910ae8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3910ae8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x3910ae8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x3910ae8*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x3816810*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x3910ae8*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3910ae8*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x3910ae8*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x3910ae8*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3910ae8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
        }

        interface IUnsafeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x38159dc*/ void Clear();
            void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3910ae8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
        }

        class RasterCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x7b31e24*/ RasterCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b33b10*/ void SetInvertCulling(bool invertCulling);
            /*0x7b33b30*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b33b4c*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b33b68*/ void DisableScissorRect();
            /*0x7b33b84*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7b33ba8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7b33bcc*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b33bf0*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b33c0c*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7b33c28*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b33c44*/ void SetGlobalInt(int nameID, int value);
            /*0x7b33c60*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b33c7c*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b33c98*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b33cb4*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b33d00*/ void EnableShaderKeyword(string keyword);
            /*0x7b33d1c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b33d38*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33d54*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33d70*/ void DisableShaderKeyword(string keyword);
            /*0x7b33d8c*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b33da8*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33dc4*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b33de0*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b33e00*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b33e20*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b33e40*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b33eb0*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b33ecc*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b33ee8*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b33f04*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b33f20*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b33f3c*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b33f58*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b33f74*/ void BeginSample(string name);
            /*0x7b33f90*/ void EndSample(string name);
            /*0x7b33fac*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b33fc8*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b33fe4*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b33fe8*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b33fec*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b34038*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7b34054*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7b34070*/ void SetWireframe(bool enable);
            /*0x7b34090*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7b340ac*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b340c8*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b340e4*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b34130*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b3417c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7b341c8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7b34214*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b34230*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b3424c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7b34268*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7b34284*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7b342d0*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b3431c*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7b34368*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7b343b4*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b34404*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7b34450*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7b3449c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b344e8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b34534*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b34580*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b345d0*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b3461c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b34668*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b346b4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b34700*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b3474c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b3479c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b347e8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b34834*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b34850*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7b3486c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7b34888*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b348a4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b348c0*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b348dc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b348f8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b34914*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b34930*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b3494c*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7b34968*/ void SetGlobalFloat(string name, float value);
            /*0x7b34984*/ void SetGlobalInt(string name, int value);
            /*0x7b349a0*/ void SetGlobalInteger(string name, int value);
            /*0x7b349bc*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b349d8*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b349f4*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b34a40*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b34a5c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b34a78*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b34a94*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b34ab0*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b34acc*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b34ae8*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b34b04*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b34b20*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b34b3c*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b34c08*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b34cd4*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b34da8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b34e7c*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b34e98*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b34eb4*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b34ed0*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b34eec*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b34f08*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b34f24*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b34f40*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b34f5c*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b34fa8*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b34fc4*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b34fe0*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b34ffc*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b3506c*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b35088*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b350a4*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b350c0*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b350dc*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b350f8*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b35114*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b35130*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b35150*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b35170*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class UnsafeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IUnsafeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x7b31e34*/ UnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7b35190*/ void SetInvertCulling(bool invertCulling);
            /*0x7b351b0*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7b351cc*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7b351e8*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b35204*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b35220*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b3526c*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b35288*/ void Clear();
            /*0x7b352a4*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b352c0*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b352dc*/ void DisableScissorRect();
            /*0x7b352f8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7b3531c*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7b35340*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b35364*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b35380*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7b3539c*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b353b8*/ void SetGlobalInt(int nameID, int value);
            /*0x7b353d4*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b353f0*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b3540c*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b35428*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b35474*/ void EnableShaderKeyword(string keyword);
            /*0x7b35490*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b354ac*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b354c8*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b354e4*/ void DisableShaderKeyword(string keyword);
            /*0x7b35500*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b3551c*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b35538*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b35554*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b35574*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b35594*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b355b4*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b35624*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b35640*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b3565c*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b35678*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b35694*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b356b0*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b356cc*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b356e8*/ void BeginSample(string name);
            /*0x7b35704*/ void EndSample(string name);
            /*0x7b35720*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b3573c*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b35758*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b3575c*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b35760*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b357ac*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7b357c8*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7b357e4*/ void SetWireframe(bool enable);
            /*0x7b35804*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7b35820*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7b3586c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x7b358b8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7b35904*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7b35950*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7b3599c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b359e8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7b35a58*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x7b35ac8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7b35b38*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b35ba8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7b35c18*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7b35c64*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b35cb0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b35d24*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x7b35d70*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b35d8c*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b35da8*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7b35dc4*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b35de0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b35dfc*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7b35e18*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b35e34*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b35e50*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7b35e6c*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7b35e88*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7b35ea4*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7b35ec0*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b35f0c*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b35f28*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7b35f44*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7b35f60*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7b35f7c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7b35f98*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b3607c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b36160*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b3624c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b36338*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b36434*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b36530*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b3654c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b36568*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b36588*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b365a8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b365c4*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b365e0*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b365fc*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b36618*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b36634*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b36650*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7b3666c*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7b36688*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7b366a4*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7b366c0*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7b366dc*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b366f8*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b36714*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b36730*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b3674c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b36768*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b36784*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b367a0*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b367bc*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b367dc*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b367fc*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b36818*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b36834*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b36850*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b3686c*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b36940*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b36a14*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7b36a30*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7b36a4c*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7b36a68*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7b36a84*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7b36aa0*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7b36abc*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7b36ad8*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7b36af4*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7b36b10*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b36b2c*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7b36b48*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b36b64*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b36bb0*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b36bfc*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b36c18*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b36c34*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7b36c50*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b36c9c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b36ce8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7b36d34*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7b36d80*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b36d9c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b36db8*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7b36dd4*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7b36df0*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7b36e3c*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b36e88*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7b36ed4*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7b36f20*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b36f70*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7b36fbc*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7b37008*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b37054*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b370a0*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b370ec*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b3713c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b37188*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b371d4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b37220*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b3726c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b372b8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b37308*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b37354*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b373a0*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b373bc*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7b373d8*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7b373f4*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b37410*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b3742c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b37448*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b37464*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b37480*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b3749c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b374b8*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7b374d4*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b374f0*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b3750c*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b37528*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b37544*/ void SetGlobalFloat(string name, float value);
            /*0x7b37560*/ void SetGlobalInt(string name, int value);
            /*0x7b3757c*/ void SetGlobalInteger(string name, int value);
            /*0x7b37598*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b375b4*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b375d0*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b3761c*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b37638*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b37654*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b37670*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b3768c*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b376a8*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b376c4*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b376e0*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b376fc*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b37718*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b377e4*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b378b0*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b37984*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b37a58*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b37a74*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b37a90*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b37aac*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b37ac8*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b37ae4*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b37b00*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b37b1c*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b37b38*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b37b84*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b37ba0*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b37bbc*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b37bd8*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b37c48*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b37c64*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b37c80*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b37c9c*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b37cb8*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b37cd4*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b37cf0*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b37d0c*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b37d2c*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b37d4c*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class CommandBufferPool
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;

            static /*0x7b37f2c*/ CommandBufferPool();
            static /*0x7b37d6c*/ UnityEngine.Rendering.CommandBuffer Get();
            static /*0x7b37e14*/ UnityEngine.Rendering.CommandBuffer Get(string name);
            static /*0x7b37eac*/ void Release(UnityEngine.Rendering.CommandBuffer buffer);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CommandBufferPool.<> <>9;

                static /*0x7b3804c*/ <>c();
                /*0x7b380b4*/ <>c();
                /*0x7b380bc*/ void <.cctor>b__4_0(UnityEngine.Rendering.CommandBuffer x);
            }
        }

        enum ClearFlag
        {
            None = 0,
            Color = 1,
            Depth = 2,
            Stencil = 4,
            DepthStencil = 6,
            ColorStencil = 5,
            All = 7,
        }

        class ComponentSingleton<TType>
        {
            static /*0x0*/ TType s_Instance;

            static /*0x3910ae8*/ TType get_instance();
            static /*0x383e7a0*/ void Release();
        }

        class ConstantBuffer
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;

            static /*0x7b38378*/ ConstantBuffer();
            static /*0x384432c*/ void PushGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            static /*0x3842d2c*/ void PushGlobal<CBType>(ref CBType data, int shaderId);
            static /*0x3844c14*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x384432c*/ void Push<CBType>(ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x3844c14*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x384432c*/ void Push<CBType>(ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x3843dfc*/ void UpdateData<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            static /*0x3840c74*/ void UpdateData<CBType>(ref CBType data);
            static /*0x3842d2c*/ void SetGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            static /*0x384032c*/ void SetGlobal<CBType>(int shaderId);
            static /*0x384432c*/ void Set<CBType>(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x3842d2c*/ void Set<CBType>(UnityEngine.ComputeShader cs, int shaderId);
            static /*0x3842d2c*/ void Set<CBType>(UnityEngine.Material mat, int shaderId);
            static /*0x7b380d4*/ void ReleaseAll();
            static /*0x7b3829c*/ void Register(UnityEngine.Rendering.ConstantBufferBase cb);
            /*0x7b38370*/ ConstantBuffer();
        }

        class ConstantBufferBase
        {
            /*0x7b38410*/ ConstantBufferBase();
            /*0x38159dc*/ void Release();
        }

        class ConstantBuffer<CBType> : UnityEngine.Rendering.ConstantBufferBase
        {
            /*0x0*/ System.Collections.Generic.HashSet<int> m_GlobalBindings;
            /*0x0*/ CBType[] m_Data;
            /*0x0*/ UnityEngine.ComputeBuffer m_GPUConstantBuffer;

            /*0x38159dc*/ ConstantBuffer();
            /*0x3816810*/ void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            /*0x3816710*/ void UpdateData(ref CBType data);
            /*0x381678c*/ void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            /*0x3815ed0*/ void SetGlobal(int shaderId);
            void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            /*0x381678c*/ void Set(UnityEngine.ComputeShader cs, int shaderId);
            /*0x381678c*/ void Set(UnityEngine.Material mat, int shaderId);
            /*0x381678c*/ void Set(UnityEngine.MaterialPropertyBlock mpb, int shaderId);
            void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            /*0x381678c*/ void PushGlobal(ref CBType data, int shaderId);
            /*0x38159dc*/ void Release();
        }

        class ConstantBufferSingleton<CBType> : UnityEngine.Rendering.ConstantBuffer<CBType>
        {
            static /*0x0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;

            static /*0x3836db8*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance();
            static /*0x3840c74*/ void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value);
            /*0x38159dc*/ ConstantBufferSingleton();
            /*0x38159dc*/ void Release();
        }

        class ContextContainer : System.IDisposable
        {
            static /*0x0*/ uint s_TypeCount;
            /*0x10*/ UnityEngine.Rendering.ContextContainer.Item[] m_Items;
            /*0x18*/ System.Collections.Generic.List<uint> m_ActiveItemIndices;

            /*0x7b38614*/ ContextContainer();
            /*0x3910ae8*/ T Get<T>();
            /*0x3910ae8*/ T Create<T>();
            /*0x3910ae8*/ T GetOrCreate<T>();
            /*0x3813ffc*/ bool Contains<T>();
            /*0x7b38418*/ bool Contains(uint typeId);
            /*0x3910ae8*/ T CreateAndGetData<T>(uint typeId);
            /*0x7b38464*/ void Dispose();

            class TypeId<T>
            {
                static /*0x0*/ uint value;

                static /*0x383e7a0*/ TypeId();
            }

            struct Item
            {
                /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                /*0x18*/ bool isSet;
            }
        }

        class ContextItem
        {
            /*0x7b2fca0*/ ContextItem();
            /*0x38159dc*/ void Reset();
        }

        class DisplayInfoAttribute : System.Attribute
        {
            /*0x10*/ string name;
            /*0x18*/ int order;

            /*0x7b386cc*/ DisplayInfoAttribute();
        }

        class AdditionalPropertyAttribute : System.Attribute
        {
            /*0x7b386d4*/ AdditionalPropertyAttribute();
        }

        class HideInDebugUIAttribute : System.Attribute
        {
            /*0x7b386dc*/ HideInDebugUIAttribute();
        }

        enum CoreProfileId
        {
            BlitTextureInPotAtlas = 0,
            APVCellStreamingUpdate = 1,
            APVScenarioBlendingUpdate = 2,
            APVIndexDefragUpdate = 3,
            APVDiskStreamingUpdate = 4,
            APVDiskStreamingUpdatePool = 5,
            APVSamplingDebug = 6,
        }

        class CoreUnsafeUtils
        {
            static /*0x3910ae8*/ void CopyTo<T>(System.Collections.Generic.List<T> list, void* dest, int count);
            static /*0x3910ae8*/ void CopyTo<T>(T[] list, void* dest, int count);
            static /*0x7b386e4*/ void CalculateRadixParams(int radixBits, ref int bitStates);
            static /*0x7b386f4*/ int CalculateRadixSupportSize(int bitStates, int arrayLength);
            static /*0x7b38700*/ void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, ref uint* bucketIndices, ref uint* bucketSizes, ref uint* bucketPrefix, ref uint* arrayOutput);
            static /*0x7b38720*/ void MergeSort(uint* array, uint* support, int length);
            static /*0x7b38854*/ void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
            static /*0x7b3896c*/ void MergeSort(Unity.Collections.NativeArray<uint> arr, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray);
            static /*0x7b38a90*/ void InsertionSort(uint* arr, int length);
            static /*0x7b38afc*/ void InsertionSort(uint[] arr, int sortSize);
            static /*0x7b38b8c*/ void InsertionSort(Unity.Collections.NativeArray<uint> arr, int sortSize);
            static /*0x7b38c4c*/ void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length);
            static /*0x7b38dc4*/ void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits);
            static /*0x7b38efc*/ void RadixSort(Unity.Collections.NativeArray<uint> array, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray, int radixBits);
            static /*0x7b39040*/ void QuickSort(uint[] arr, int left, int right);
            static /*0x7b390b4*/ void QuickSort(ulong[] arr, int left, int right);
            static /*0x3910ae8*/ void QuickSort<T>(int count, void* data);
            static /*0x3910ae8*/ void QuickSort<TValue, TKey, TGetter>(int count, void* data);
            static /*0x3910ae8*/ void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x3910ae8*/ int IndexOf<T>(void* data, int count, T v);
            static /*0x3910ae8*/ int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x7b39128*/ int CompareHashes(int oldHashCount, UnityEngine.Hash128* oldHashes, int newHashCount, UnityEngine.Hash128* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x3910ae8*/ void CombineHashes<TValue, TGetter>(int count, void* hashes, UnityEngine.Hash128* outHash);
            static /*0x7b391cc*/ void CombineHashes(int count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash);
            static /*0x3910ae8*/ int Partition<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x7b3922c*/ bool HaveDuplicates(int[] arr);

            struct FixedBufferStringQueue
            {
                /*0x10*/ byte* m_ReadCursor;
                /*0x18*/ byte* m_WriteCursor;
                /*0x20*/ byte* m_BufferEnd;
                /*0x28*/ byte* m_BufferStart;
                /*0x30*/ int m_BufferLength;
                /*0x34*/ int <Count>k__BackingField;

                /*0x7b393a4*/ FixedBufferStringQueue(byte* ptr, int length);
                /*0x7b39394*/ int get_Count();
                /*0x7b3939c*/ void set_Count(int value);
                /*0x7b393e4*/ bool TryPush(string v);
                /*0x7b39494*/ bool TryPop(ref string v);
                /*0x7b393c8*/ void Clear();
            }

            interface IKeyGetter<TValue, TKey>
            {
                /*0x3910ae8*/ TKey Get(ref TValue v);
            }

            struct DefaultKeyGetter<T> : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<T, T>
            {
                /*0x3910ae8*/ T Get(ref T v);
            }

            struct UintKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<uint, uint>
            {
                /*0x7b39514*/ uint Get(ref uint v);
            }

            struct UlongKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<ulong, ulong>
            {
                /*0x7b3951c*/ ulong Get(ref ulong v);
            }
        }

        class DynamicArray<T>
        {
            /*0x0*/ T[] m_Array;
            /*0x0*/ int <size>k__BackingField;

            static /*0x38379c4*/ T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x3910ae8*/ System.ReadOnlySpan<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x3910ae8*/ System.Span<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x38159dc*/ DynamicArray();
            /*0x3815ed0*/ DynamicArray(int size);
            /*0x3815f10*/ DynamicArray(int capacity, bool resize);
            /*0x3816710*/ DynamicArray(UnityEngine.Rendering.DynamicArray<T> deepCopy);
            /*0x3814574*/ int get_size();
            /*0x3815ed0*/ void set_size(int value);
            /*0x3814574*/ int get_capacity();
            /*0x38159dc*/ void Clear();
            /*0x3910ae8*/ bool Contains(T item);
            /*0x381467c*/ int Add(ref T value);
            /*0x3816710*/ void AddRange(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x3910ae8*/ void Insert(int index, T item);
            /*0x3910ae8*/ bool Remove(T item);
            /*0x3815ed0*/ void RemoveAt(int index);
            /*0x3815fb8*/ void RemoveRange(int index, int count);
            /*0x3910ae8*/ int FindIndex(int startIndex, int count, System.Predicate<T> match);
            /*0x3910ae8*/ int IndexOf(T item, int index, int count);
            /*0x3910ae8*/ int IndexOf(T item, int index);
            /*0x3910ae8*/ int IndexOf(T item);
            /*0x3815f10*/ void Resize(int newSize, bool keepContent);
            /*0x3815ed0*/ void ResizeAndClear(int newSize);
            /*0x3815f10*/ void Reserve(int newCapacity, bool keepContent);
            /*0x3814964*/ ref T get_Item(int index);
            /*0x3910ae8*/ UnityEngine.Rendering.DynamicArray.Iterator<T> GetEnumerator();
            /*0x3910ae8*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems);
            /*0x38159dc*/ void BumpVersion();

            struct Iterator<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                /*0x0*/ int index;

                /*0x3816710*/ Iterator(UnityEngine.Rendering.DynamicArray<T> setOwner);
                /*0x38148bc*/ ref T get_Current();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
            }

            struct RangeEnumerable<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> iterator;

                /*0x3910ae8*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> GetEnumerator();

                struct RangeIterator<T>
                {
                    /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                    /*0x0*/ int index;
                    /*0x0*/ int first;
                    /*0x0*/ int last;

                    RangeIterator(UnityEngine.Rendering.DynamicArray<T> setOwner, int first, int numItems);
                    /*0x38148bc*/ ref T get_Current();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                }
            }

            class SortComparer<T> : System.MulticastDelegate
            {
                SortComparer(object object, nint method);
                /*0x3910ae8*/ int Invoke(T x, T y);
                /*0x3910ae8*/ System.IAsyncResult BeginInvoke(T x, T y, System.AsyncCallback callback, object object);
                /*0x381467c*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class DynamicArrayExtensions
        {
            static /*0x3910ae8*/ int Partition<T>(System.Span<T> data, int left, int right);
            static /*0x3910ae8*/ void QuickSort<T>(System.Span<T> data, int left, int right);
            static /*0x3910ae8*/ int Partition<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x3910ae8*/ void QuickSort<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x3840c74*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x3843dfc*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
        }

        class PerformDynamicRes : System.MulticastDelegate
        {
            /*0x7b39524*/ PerformDynamicRes(object object, nint method);
            /*0x7b395c0*/ float Invoke();
            /*0x7b395d4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x7b395f4*/ float EndInvoke(System.IAsyncResult result);
        }

        enum DynamicResScalePolicyType
        {
            ReturnsPercentage = 0,
            ReturnsMinMaxLerpFactor = 1,
        }

        enum DynamicResScalerSlot
        {
            User = 0,
            System = 1,
            Count = 2,
        }

        class DynamicResolutionHandler
        {
            static int CameraDictionaryMaxcCapacity = 32;
            static /*0x0*/ UnityEngine.Rendering.DynamicResScalerSlot s_ActiveScalerSlot;
            static /*0x8*/ UnityEngine.Rendering.DynamicResolutionHandler.ScalerContainer[] s_ScalerContainers;
            static /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.DynamicResUpscaleFilter> s_CameraUpscaleFilters;
            static /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.DynamicResolutionHandler> s_CameraInstances;
            static /*0x20*/ UnityEngine.Rendering.DynamicResolutionHandler s_DefaultInstance;
            static /*0x28*/ int s_ActiveCameraId;
            static /*0x30*/ UnityEngine.Rendering.DynamicResolutionHandler s_ActiveInstance;
            static /*0x38*/ bool s_ActiveInstanceDirty;
            static /*0x3c*/ float s_GlobalHwFraction;
            static /*0x40*/ bool s_GlobalHwUpresActive;
            /*0x10*/ bool m_Enabled;
            /*0x11*/ bool m_UseMipBias;
            /*0x14*/ float m_MinScreenFraction;
            /*0x18*/ float m_MaxScreenFraction;
            /*0x1c*/ float m_CurrentFraction;
            /*0x20*/ bool m_ForcingRes;
            /*0x21*/ bool m_CurrentCameraRequest;
            /*0x24*/ float m_PrevFraction;
            /*0x28*/ bool m_ForceSoftwareFallback;
            /*0x29*/ bool m_RunUpscalerFilterOnFullResolution;
            /*0x2c*/ float m_PrevHWScaleWidth;
            /*0x30*/ float m_PrevHWScaleHeight;
            /*0x34*/ UnityEngine.Vector2Int m_LastScaledSize;
            /*0x3c*/ UnityEngine.Vector2Int cachedOriginalSize;
            /*0x44*/ UnityEngine.Rendering.DynamicResUpscaleFilter <filter>k__BackingField;
            /*0x48*/ UnityEngine.Vector2Int <finalViewport>k__BackingField;
            /*0x50*/ UnityEngine.Rendering.DynamicResolutionType type;
            /*0x58*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings m_CachedSettings;
            /*0xc8*/ System.WeakReference m_OwnerCameraWeakRef;
            /*0xd0*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule;

            static /*0x7b3ad0c*/ DynamicResolutionHandler();
            static /*0x7b39818*/ UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera);
            static /*0x7b39ce8*/ UnityEngine.Rendering.DynamicResolutionHandler get_instance();
            static /*0x7b39ec4*/ float DefaultDynamicResMethod();
            static /*0x7b3a198*/ void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x7b3a24c*/ void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x7b3a304*/ void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot);
            static /*0x7b3a360*/ void ClearSelectedCamera();
            static /*0x7b3a3d4*/ void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter);
            static /*0x7b3a504*/ void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange);
            /*0x7b39c50*/ DynamicResolutionHandler();
            /*0x7b3961c*/ void Reset();
            /*0x7b39658*/ UnityEngine.Rendering.DynamicResUpscaleFilter get_filter();
            /*0x7b39660*/ void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value);
            /*0x7b39668*/ UnityEngine.Vector2Int get_finalViewport();
            /*0x7b39670*/ void set_finalViewport(UnityEngine.Vector2Int value);
            /*0x7b39678*/ void set_runUpscalerFilterOnFullResolution(bool value);
            /*0x7b39684*/ bool get_runUpscalerFilterOnFullResolution();
            /*0x7b396a4*/ bool get_forcingResolution();
            /*0x7b396ac*/ bool FlushScalableBufferManagerState();
            /*0x7b39cd8*/ void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value);
            /*0x7b39ce0*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule();
            /*0x7b39ecc*/ void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings);
            /*0x7b3a094*/ UnityEngine.Vector2 GetResolvedScale();
            /*0x7b3a108*/ float CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, bool forceApply);
            /*0x7b3a4f8*/ void SetCurrentCameraRequest(bool cameraRequest);
            /*0x7b3a6e8*/ void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange);
            /*0x7b3a964*/ bool SoftwareDynamicResIsEnabled();
            /*0x7b397e8*/ bool HardwareDynamicResIsEnabled();
            /*0x7b3a9c0*/ bool RequestsHardwareDynamicResolution();
            /*0x7b3a9e0*/ bool DynamicResolutionEnabled();
            /*0x7b3aa28*/ void ForceSoftwareFallback();
            /*0x7b3aa34*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size);
            /*0x7b3aa84*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size);
            /*0x7b3aaac*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales);
            /*0x7b3ac34*/ float GetCurrentScale();
            /*0x7b3ac50*/ UnityEngine.Vector2Int GetLastScaledSize();
            /*0x7b3ac58*/ float GetLowResMultiplier(float targetLowRes);
            /*0x7b3ac60*/ float GetLowResMultiplier(float targetLowRes, float minimumThreshold);

            struct ScalerContainer
            {
                /*0x10*/ UnityEngine.Rendering.DynamicResScalePolicyType type;
                /*0x18*/ UnityEngine.Rendering.PerformDynamicRes method;
            }

            enum UpsamplerScheduleType
            {
                BeforePost = 0,
                AfterDepthOfField = 1,
                AfterPost = 2,
            }
        }

        class DynamicString : UnityEngine.Rendering.DynamicArray<char>
        {
            /*0x7b3af80*/ DynamicString();
            /*0x7b3afc8*/ DynamicString(string s);
            /*0x7b3b080*/ DynamicString(int capacity);
            /*0x7b3b0dc*/ void Append(string s);
            /*0x7b3b1f4*/ void Append(UnityEngine.Rendering.DynamicString s);
            /*0x7b3b24c*/ string ToString();
        }

        enum DynamicResolutionType
        {
            Software = 0,
            Hardware = 1,
        }

        enum DynamicResUpscaleFilter
        {
            Bilinear = 0,
            CatmullRom = 1,
            Lanczos = 2,
            ContrastAdaptiveSharpen = 3,
            EdgeAdaptiveScalingUpres = 4,
            TAAU = 5,
        }

        enum AdvancedUpscalers
        {
            DLSS = 0,
            FSR2 = 1,
            STP = 2,
        }

        struct GlobalDynamicResolutionSettings
        {
            /*0x10*/ bool enabled;
            /*0x11*/ bool useMipBias;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.AdvancedUpscalers> advancedUpscalersByPriority;
            /*0x20*/ uint DLSSPerfQualitySetting;
            /*0x24*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;
            /*0x28*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType TAAUInjectionPoint;
            /*0x2c*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType STPInjectionPoint;
            /*0x30*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType defaultInjectionPoint;
            /*0x34*/ bool DLSSUseOptimalSettings;
            /*0x38*/ float DLSSSharpness;
            /*0x3c*/ bool FSR2EnableSharpness;
            /*0x40*/ float FSR2Sharpness;
            /*0x44*/ bool FSR2UseOptimalSettings;
            /*0x48*/ uint FSR2QualitySetting;
            /*0x4c*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType FSR2InjectionPoint;
            /*0x50*/ bool fsrOverrideSharpness;
            /*0x54*/ float fsrSharpness;
            /*0x58*/ float maxPercentage;
            /*0x5c*/ float minPercentage;
            /*0x60*/ UnityEngine.Rendering.DynamicResolutionType dynResType;
            /*0x61*/ UnityEngine.Rendering.DynamicResUpscaleFilter upsampleFilter;
            /*0x62*/ bool forceResolution;
            /*0x64*/ float forcedPercentage;
            /*0x68*/ float lowResTransparencyMinimumThreshold;
            /*0x6c*/ float rayTracingHalfResThreshold;
            /*0x70*/ float lowResSSGIMinimumThreshold;
            /*0x74*/ float lowResVolumetricCloudsMinimumThreshold;
            /*0x78*/ bool enableDLSS;

            static /*0x7b39d40*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault();
        }

        interface IAdditionalData
        {
        }

        interface IVirtualTexturingEnabledRenderPipeline
        {
            /*0x3813ffc*/ bool get_virtualTexturingEnabled();
        }

        struct ListBuffer<T>
        {
            /*0x0*/ T* m_BufferPtr;
            /*0x0*/ int m_Capacity;
            /*0x0*/ int* m_CountPtr;

            /*0x3910ae8*/ ListBuffer(T* bufferPtr, int* countPtr, int capacity);
            /*0x3910ae8*/ T* get_BufferPtr();
            /*0x3814574*/ int get_Count();
            /*0x3814574*/ int get_Capacity();
            /*0x3814a3c*/ ref T get_Item(ref int index);
            /*0x3814a3c*/ ref T GetUnchecked(ref int index);
            /*0x38141c4*/ bool TryAdd(ref T value);
            /*0x3910ae8*/ void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
            /*0x3910ae8*/ bool TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other);
            /*0x3910ae8*/ bool TryCopyFrom(T* srcPtr, int count);
        }

        class ListBufferExtensions
        {
            static /*0x3910ae8*/ void QuickSort<T>(UnityEngine.Rendering.ListBuffer<T> self);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, bool collectionCheck);
            /*0x3814574*/ int get_countAll();
            /*0x3815ed0*/ void set_countAll(int value);
            /*0x3814574*/ int get_countActive();
            /*0x3814574*/ int get_countInactive();
            /*0x3910ae8*/ T Get();
            /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T v);
            /*0x3910ae8*/ void Release(T element);

            struct PooledObject<T> : System.IDisposable
            {
                /*0x0*/ T m_ToReturn;
                /*0x0*/ UnityEngine.Rendering.ObjectPool<T> m_Pool;

                /*0x3910ae8*/ PooledObject(T value, UnityEngine.Rendering.ObjectPool<T> pool);
                /*0x38159dc*/ void System.IDisposable.Dispose();
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x383e7a0*/ GenericPool();
            static /*0x3910ae8*/ T Get();
            static /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x3910ae8*/ void Release(T toRelease);
        }

        class UnsafeGenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x383e7a0*/ UnsafeGenericPool();
            static /*0x3910ae8*/ T Get();
            static /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x3910ae8*/ void Release(T toRelease);
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;

            static /*0x383e7a0*/ ListPool();
            static /*0x3836db8*/ System.Collections.Generic.List<T> Get();
            static /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(ref System.Collections.Generic.List<T> value);
            static /*0x3840c74*/ void Release(System.Collections.Generic.List<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ListPool.<>c<T> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3816710*/ void <.cctor>b__4_0(System.Collections.Generic.List<T> l);
            }
        }

        class HashSetPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;

            static /*0x383e7a0*/ HashSetPool();
            static /*0x3836db8*/ System.Collections.Generic.HashSet<T> Get();
            static /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(ref System.Collections.Generic.HashSet<T> value);
            static /*0x3840c74*/ void Release(System.Collections.Generic.HashSet<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.HashSetPool.<>c<T> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3816710*/ void <.cctor>b__4_0(System.Collections.Generic.HashSet<T> l);
            }
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey, TValue>> s_Pool;

            static /*0x383e7a0*/ DictionaryPool();
            static /*0x3836db8*/ System.Collections.Generic.Dictionary<TKey, TValue> Get();
            static /*0x3910ae8*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey, TValue>> Get(ref System.Collections.Generic.Dictionary<TKey, TValue> value);
            static /*0x3840c74*/ void Release(System.Collections.Generic.Dictionary<TKey, TValue> toRelease);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ UnityEngine.Rendering.DictionaryPool.<>c<TKey, TValue> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3816710*/ void <.cctor>b__4_0(System.Collections.Generic.Dictionary<TKey, TValue> l);
            }
        }

        struct Observable<T>
        {
            /*0x0*/ System.Action<T> onValueChanged;
            /*0x0*/ T m_Value;

            /*0x3910ae8*/ Observable(T newValue);
            /*0x3816710*/ void add_onValueChanged(System.Action<T> value);
            /*0x3816710*/ void remove_onValueChanged(System.Action<T> value);
            /*0x3910ae8*/ T get_value();
            /*0x3910ae8*/ void set_value(T value);
        }

        class ListChangedEventArgs<T> : System.EventArgs
        {
            /*0x0*/ int index;
            /*0x0*/ T item;

            /*0x3910ae8*/ ListChangedEventArgs(int index, T item);
        }

        class ListChangedEventHandler<T> : System.MulticastDelegate
        {
            ListChangedEventHandler(object object, nint method);
            /*0x3816810*/ void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e);
            /*0x3814c50*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, object object);
            /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
        }

        class ObservableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<T> m_List;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;

            /*0x38159dc*/ ObservableList();
            /*0x3815ed0*/ ObservableList(int capacity);
            /*0x3816710*/ ObservableList(System.Collections.Generic.IEnumerable<T> collection);
            /*0x3816710*/ void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x3816710*/ void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x3816710*/ void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x3816710*/ void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x3910ae8*/ T get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, T value);
            /*0x3814574*/ int get_Count();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x3910ae8*/ void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, int index, T item);
            /*0x3910ae8*/ bool Contains(T item);
            /*0x3910ae8*/ int IndexOf(T item);
            /*0x3910ae8*/ void Add(T item);
            /*0x3816710*/ void Add(T[] items);
            /*0x3910ae8*/ void Insert(int index, T item);
            /*0x3910ae8*/ bool Remove(T item);
            /*0x381467c*/ int Remove(T[] items);
            /*0x3815ed0*/ void RemoveAt(int index);
            /*0x38159dc*/ void Clear();
            /*0x381678c*/ void CopyTo(T[] array, int arrayIndex);
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class ReloadAttribute : System.Attribute
        {
            /*0x7b3b298*/ ReloadAttribute(string[] paths, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x7b3b2a0*/ ReloadAttribute(string path, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x7b3b320*/ ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package);

            enum Package
            {
                Builtin = 0,
                Root = 1,
                BuiltinExtra = 2,
            }
        }

        class ReloadGroupAttribute : System.Attribute
        {
            /*0x7b3b328*/ ReloadGroupAttribute();
        }

        class RemoveRangeExtensions
        {
            static bool TryRemoveElementsInRange<TValue>(System.Collections.Generic.IList<TValue> list, int index, int count, ref System.Exception error);
        }

        class SerializableEnum
        {
            /*0x10*/ string m_EnumValueAsString;
            /*0x18*/ string m_EnumTypeAsString;

            /*0x7b3b488*/ SerializableEnum(System.Type enumType);
            /*0x7b3b330*/ System.Enum get_value();
            /*0x7b3b450*/ void set_value(System.Enum value);
        }

        class SerializedDictionaryDebugView<K, V>
        {
            /*0x0*/ System.Collections.Generic.IDictionary<K, V> dict;

            /*0x3816710*/ SerializedDictionaryDebugView(System.Collections.Generic.IDictionary<K, V> dictionary);
            /*0x38148bc*/ System.Collections.Generic.KeyValuePair<K, V> get_Items();
        }

        class SerializedDictionary<K, V> : UnityEngine.Rendering.SerializedDictionary<K, V, K, V>
        {
            /*0x38159dc*/ SerializedDictionary();
            /*0x3910ae8*/ K SerializeKey(K key);
            /*0x3910ae8*/ V SerializeValue(V val);
            /*0x3910ae8*/ K DeserializeKey(K key);
            /*0x3910ae8*/ V DeserializeValue(V val);
        }

        class SerializedDictionary<K, V, SK, SV> : System.Collections.Generic.Dictionary<K, V>, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x0*/ System.Collections.Generic.List<SK> m_Keys;
            /*0x0*/ System.Collections.Generic.List<SV> m_Values;

            /*0x38159dc*/ SerializedDictionary();
            /*0x3910ae8*/ SK SerializeKey(K key);
            /*0x3910ae8*/ SV SerializeValue(V value);
            /*0x3910ae8*/ K DeserializeKey(SK serializedKey);
            /*0x3910ae8*/ V DeserializeValue(SV serializedValue);
            /*0x38159dc*/ void OnBeforeSerialize();
            /*0x38159dc*/ void OnAfterDeserialize();
        }

        class SwapCollectionExtensions
        {
            static bool TrySwap<TValue>(System.Collections.Generic.IList<TValue> list, int from, int to, ref System.Exception error);
        }

        class DebugDisplaySettings<T> : UnityEngine.Rendering.IDebugDisplaySettings
        {
            static /*0x0*/ System.Lazy<T> s_Instance;
            /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.IDebugDisplaySettingsData> m_Settings;

            static /*0x383e7a0*/ DebugDisplaySettings();
            static /*0x3910ae8*/ T get_Instance();
            /*0x38159dc*/ DebugDisplaySettings();
            /*0x3813ffc*/ bool get_AreAnySettingsActive();
            /*0x3813ffc*/ bool get_IsPostProcessingAllowed();
            /*0x3813ffc*/ bool get_IsLightingActive();
            /*0x3910ae8*/ TData Add<TData>(TData newData);
            /*0x3814a3c*/ UnityEngine.Rendering.IDebugDisplaySettingsData UnityEngine.Rendering.IDebugDisplaySettings.Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
            /*0x3816710*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x38159dc*/ void Reset();
            /*0x38141c4*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);

            class IDebugDisplaySettingsDataComparer<T> : System.Collections.Generic.IEqualityComparer<UnityEngine.Rendering.IDebugDisplaySettingsData>
            {
                /*0x38159dc*/ IDebugDisplaySettingsDataComparer();
                /*0x3814200*/ bool Equals(UnityEngine.Rendering.IDebugDisplaySettingsData x, UnityEngine.Rendering.IDebugDisplaySettingsData y);
                /*0x381467c*/ int GetHashCode(UnityEngine.Rendering.IDebugDisplaySettingsData obj);
            }

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.DebugDisplaySettings.<>c<T> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3910ae8*/ T <.cctor>b__17_0();
            }
        }

        class DebugDisplaySettingsHDROutput
        {
            static /*0x7b3b518*/ UnityEngine.Rendering.DebugUI.Table CreateHDROuputDisplayTable();
            /*0x7b3bfc8*/ DebugDisplaySettingsHDROutput();

            class Strings
            {
                static /*0x0*/ string hdrOutputAPI;
                static /*0x8*/ string displayName;
                static /*0x10*/ string displayMain;
                static /*0x18*/ string hdrActive;
                static /*0x20*/ string hdrAvailable;
                static /*0x28*/ string gamut;
                static /*0x30*/ string format;
                static /*0x38*/ string autoHdrTonemapping;
                static /*0x40*/ string paperWhite;
                static /*0x48*/ string minLuminance;
                static /*0x50*/ string maxLuminance;
                static /*0x58*/ string maxFullFrameLuminance;
                static /*0x60*/ string modeChangeRequested;
                static /*0x68*/ string notAvailable;

                static /*0x7b3c870*/ Strings();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.HDROutputSettings d;

                /*0x7b3cb04*/ <>c__DisplayClass1_0();
                /*0x7b3cb0c*/ object <CreateHDROuputDisplayTable>b__0();
                /*0x7b3cb4c*/ object <CreateHDROuputDisplayTable>b__1();
                /*0x7b3cb8c*/ object <CreateHDROuputDisplayTable>b__2();
                /*0x7b3cc3c*/ object <CreateHDROuputDisplayTable>b__3();
                /*0x7b3ccec*/ object <CreateHDROuputDisplayTable>b__4();
                /*0x7b3cd94*/ object <CreateHDROuputDisplayTable>b__5();
                /*0x7b3ce34*/ object <CreateHDROuputDisplayTable>b__6();
                /*0x7b3ced8*/ object <CreateHDROuputDisplayTable>b__7();
                /*0x7b3cf7c*/ object <CreateHDROuputDisplayTable>b__8();
                /*0x7b3d020*/ object <CreateHDROuputDisplayTable>b__9();
            }
        }

        class DebugDisplaySettingsPanel : UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable, UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> m_Widgets;
            /*0x18*/ UnityEngine.Rendering.DisplayInfoAttribute m_DisplayInfo;

            /*0x7b3d2d0*/ DebugDisplaySettingsPanel();
            /*0x7b3d0c8*/ string get_PanelName();
            /*0x7b3d0f4*/ int get_Order();
            /*0x7b3d10c*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x7b3d15c*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
            /*0x7b3d164*/ void AddWidget(UnityEngine.Rendering.DebugUI.Widget widget);
            /*0x7b3d25c*/ void Clear();
            /*0x7b3d2cc*/ void Dispose();
        }

        class DebugDisplaySettingsPanel<T> : UnityEngine.Rendering.DebugDisplaySettingsPanel
        {
            /*0x0*/ T m_Data;

            /*0x3910ae8*/ DebugDisplaySettingsPanel(T data);
            /*0x3910ae8*/ T get_data();
            /*0x3910ae8*/ void set_data(T value);
        }

        class DebugDisplaySettingsStats<TProfileId> : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <debugDisplayStats>k__BackingField;

            /*0x3816710*/ DebugDisplaySettingsStats(UnityEngine.Rendering.DebugDisplayStats<TProfileId> debugDisplayStats);
            /*0x38148bc*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> get_debugDisplayStats();
            /*0x3813ffc*/ bool get_AreAnySettingsActive();
            /*0x38148bc*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class StatsPanel<TProfileId> : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x0*/ UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> m_Data;

                /*0x3816710*/ StatsPanel(UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> displaySettingsStats);
                /*0x3814574*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x38159dc*/ void Dispose();
            }
        }

        class DebugDisplaySettingsUI : UnityEngine.Rendering.IDebugData
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;
            /*0x18*/ UnityEngine.Rendering.IDebugDisplaySettings m_Settings;

            /*0x7b3e118*/ DebugDisplaySettingsUI();
            /*0x7b3d430*/ void Reset();
            /*0x7b3da48*/ void RegisterDebug(UnityEngine.Rendering.IDebugDisplaySettings settings);
            /*0x7b3d51c*/ void UnregisterDebug();
            /*0x7b3e09c*/ System.Action GetReset();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager debugManager;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> panels;

                /*0x7b3dd48*/ <>c__DisplayClass3_0();
                /*0x7b3e120*/ void <RegisterDebug>b__0(UnityEngine.Rendering.IDebugDisplaySettingsData data);
            }
        }

        class DebugDisplaySettingsVolume : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            static string k_PanelTitle = "Volume";
            /*0x10*/ UnityEngine.Rendering.IVolumeDebugSettings <volumeDebugSettings>k__BackingField;
            /*0x18*/ int volumeComponentEnumIndex;
            /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.VolumeComponent> debugState;

            /*0x7b3e434*/ DebugDisplaySettingsVolume(UnityEngine.Rendering.IVolumeDebugSettings volumeDebugSettings);
            /*0x7b3e42c*/ UnityEngine.Rendering.IVolumeDebugSettings get_volumeDebugSettings();
            /*0x7b3e4d0*/ bool get_AreAnySettingsActive();
            /*0x7b3e4d8*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class Styles
            {
                static /*0x0*/ UnityEngine.GUIContent none;
                static /*0x8*/ UnityEngine.GUIContent editorCamera;

                static /*0x7b3e694*/ Styles();
            }

            class Strings
            {
                static /*0x0*/ string none;
                static /*0x8*/ string camera;
                static /*0x10*/ string parameter;
                static /*0x18*/ string component;
                static /*0x20*/ string debugViewNotSupported;
                static /*0x28*/ string parameterNotOverrided;
                static /*0x30*/ string volumeInfo;
                static /*0x38*/ string gameObject;
                static /*0x40*/ string resultValue;
                static /*0x48*/ string resultValueTooltip;
                static /*0x50*/ string globalDefaultValue;
                static /*0x58*/ string globalDefaultValueTooltip;
                static /*0x60*/ string qualityLevelValue;
                static /*0x68*/ string qualityLevelValueTooltip;
                static /*0x70*/ string global;
                static /*0x78*/ string local;
                static /*0x80*/ string volumeProfile;

                static /*0x7b3e770*/ Strings();
            }

            class WidgetFactory
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Value s_EmptyDebugUIValue;

                static /*0x7b41900*/ WidgetFactory();
                static /*0x7b3ea7c*/ UnityEngine.Rendering.DebugUI.EnumField CreateComponentSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> refresh);
                static /*0x7b3f448*/ UnityEngine.Rendering.DebugUI.ObjectPopupField CreateCameraSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>, UnityEngine.Object> refresh);
                static /*0x7b3f6ac*/ UnityEngine.Rendering.DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, UnityEngine.Rendering.VolumeParameter param, System.Func<bool> isHiddenCallback);
                static /*0x7b3f760*/ UnityEngine.Rendering.VolumeComponent GetSelectedVolumeComponent(UnityEngine.Rendering.VolumeProfile profile, System.Type selectedType);
                static /*0x7b3f950*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x7b40688*/ UnityEngine.Rendering.DebugUI.Table CreateVolumeTable(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x7b41430*/ void SetTableColumnVisibility(UnityEngine.Rendering.DebugDisplaySettingsVolume data, UnityEngine.Rendering.DebugUI.Table table);
                static /*0x7b40c34*/ void GenerateTableColumns(UnityEngine.Rendering.DebugUI.Table table, UnityEngine.Rendering.DebugDisplaySettingsVolume data, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);
                static /*0x7b4099c*/ void GenerateTableRows(UnityEngine.Rendering.DebugUI.Table table, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);

                struct VolumeParameterChain
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip nameAndTooltip;
                    /*0x20*/ UnityEngine.Rendering.VolumeProfile volumeProfile;
                    /*0x28*/ UnityEngine.Rendering.VolumeComponent volumeComponent;
                    /*0x30*/ UnityEngine.Rendering.Volume volume;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.<> <>9;
                    static /*0x8*/ System.Func<object> <>9__9_2;

                    static /*0x7b41a0c*/ <>c();
                    /*0x7b41a74*/ <>c();
                    /*0x7b41a7c*/ object <GenerateTableColumns>b__9_2();
                    /*0x7b41a94*/ object <.cctor>b__11_0();
                }

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x7b3f148*/ <>c__DisplayClass0_0();
                    /*0x7b41aac*/ int <CreateComponentSelector>b__0();
                    /*0x7b41b68*/ void <CreateComponentSelector>b__1(int value);
                    /*0x7b41c30*/ int <CreateComponentSelector>b__2();
                    /*0x7b41c80*/ void <CreateComponentSelector>b__3(int value);
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x7b3f65c*/ <>c__DisplayClass1_0();
                    /*0x7b41cd4*/ UnityEngine.Object <CreateCameraSelector>b__0();
                    /*0x7b41d94*/ void <CreateCameraSelector>b__1(UnityEngine.Object value);
                    /*0x7b41f44*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <CreateCameraSelector>b__2();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;
                    /*0x18*/ float timer;
                    /*0x1c*/ float refreshRate;
                    /*0x20*/ UnityEngine.Rendering.DebugUI.Table table;
                    /*0x28*/ UnityEngine.Rendering.Volume[] volumes;

                    /*0x7b40940*/ <>c__DisplayClass7_0();
                    /*0x7b42004*/ bool <CreateVolumeTable>b__1();
                    /*0x7b420b8*/ bool <CreateVolumeTable>b__0();
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;

                    /*0x7b417d8*/ <>c__DisplayClass9_0();
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain;
                    /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.<> CS$<>8__locals1;

                    /*0x7b417e0*/ <>c__DisplayClass9_1();
                    /*0x7b42324*/ object <GenerateTableColumns>b__0();
                    /*0x7b424a0*/ UnityEngine.Object <GenerateTableColumns>b__1();
                    /*0x7b424a8*/ UnityEngine.Object <GenerateTableColumns>b__3();
                }
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.DebugDisplaySettingsVolume>
            {
                /*0x28*/ UnityEngine.Rendering.DebugUI.Table m_VolumeTable;

                /*0x7b3e530*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                /*0x7b424b0*/ void Refresh();
                /*0x7b4275c*/ void <.ctor>b__0_0(UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object> _, UnityEngine.Object __);
                /*0x7b42760*/ void <.ctor>b__0_1(UnityEngine.Rendering.DebugUI.Field<int> _, int __);
            }
        }

        class DebugDisplayStats<TProfileId>
        {
            static float k_AccumulationTimeInSeconds = 1;
            static /*0x0*/ string[] k_DetailedStatsColumnLabels;
            /*0x0*/ System.Collections.Generic.Dictionary<TProfileId, UnityEngine.Rendering.DebugDisplayStats.AccumulatedTiming<TProfileId>> m_AccumulatedTiming;
            /*0x0*/ float m_TimeSinceLastAvgValue;
            /*0x0*/ int m_AccumulatedFrames;
            /*0x0*/ System.Collections.Generic.HashSet<TProfileId> m_HiddenProfileIds;
            /*0x0*/ bool averageProfilerTimingsOverASecond;
            /*0x0*/ bool hideEmptyScopes;

            static /*0x383e7a0*/ DebugDisplayStats();
            /*0x38159dc*/ DebugDisplayStats();
            /*0x38159dc*/ void EnableProfilingRecorders();
            /*0x38159dc*/ void DisableProfilingRecorders();
            /*0x3816710*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x38159dc*/ void Update();
            /*0x38148bc*/ System.Collections.Generic.List<TProfileId> GetProfilerIdsToDisplay();
            /*0x3816710*/ void UpdateDetailedStats(System.Collections.Generic.List<TProfileId> samplers);
            /*0x3814b90*/ UnityEngine.Rendering.DebugUI.Widget BuildDetailedStatsList(string title, System.Collections.Generic.List<TProfileId> samplers);
            void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, System.Collections.Generic.List<TProfileId> samplers);
            /*0x3910ae8*/ float GetSamplerTiming(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);
            /*0x3814a3c*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> BuildProfilingSamplerWidgetList(System.Collections.Generic.IEnumerable<TProfileId> samplers);
            /*0x3910ae8*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);

            class AccumulatedTiming<TProfileId>
            {
                /*0x0*/ float accumulatedValue;
                /*0x0*/ float lastAverage;

                /*0x38159dc*/ AccumulatedTiming();
                /*0x3815ed0*/ void UpdateLastAverage(int frameCount);
            }

            enum DebugProfilingType<TProfileId>
            {
                CPU = 0,
                InlineCPU = 1,
                GPU = 2,
            }

            class <>c__DisplayClass19_0<TProfileId>
            {
                /*0x0*/ TProfileId samplerId;
                /*0x0*/ UnityEngine.Rendering.ProfilingSampler sampler;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <>4__this;

                /*0x38159dc*/ <>c__DisplayClass19_0();
                /*0x38148bc*/ object <BuildProfilingSamplerWidgetList>b__1();
            }

            class <>c__DisplayClass19_<TProfileId>
            {
                /*0x0*/ TProfileId samplerId;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <>4__this;

                /*0x38159dc*/ <>c__DisplayClass19_();
                /*0x3813ffc*/ bool <BuildProfilingSamplerWidgetList>b__2();
            }

            class <>c__DisplayClass19_2<TProfileId>
            {
                /*0x0*/ UnityEngine.Rendering.ProfilingSampler sampler;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats.<>c__DisplayClass19_1<TProfileId> CS$<>8__locals1;

                /*0x38159dc*/ <>c__DisplayClass19_2();
                /*0x3910ae8*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>b__3(UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> e);
            }

            class <>c__DisplayClass6_0<TProfileId>
            {
                /*0x0*/ System.Type type;
                /*0x0*/ System.Func<System.Reflection.MemberInfo, bool> <>9__0;

                /*0x38159dc*/ <>c__DisplayClass6_0();
                /*0x38141c4*/ bool <GetProfilerIdsToDisplay>b__0(System.Reflection.MemberInfo m);
            }
        }

        class DebugFrameTiming
        {
            static string k_FpsFormatString = "{0:F1}";
            static string k_MsFormatString = "{0:F2}ms";
            static float k_RefreshRate = 0.20000000298023224;
            /*0x10*/ UnityEngine.Rendering.FrameTimeSampleHistory m_FrameHistory;
            /*0x18*/ UnityEngine.Rendering.BottleneckHistory m_BottleneckHistory;
            /*0x20*/ int <bottleneckHistorySize>k__BackingField;
            /*0x24*/ int <sampleHistorySize>k__BackingField;
            /*0x28*/ UnityEngine.FrameTiming[] m_Timing;
            /*0x30*/ UnityEngine.Rendering.FrameTimeSample m_Sample;

            /*0x7b42784*/ DebugFrameTiming();
            /*0x7b42764*/ int get_bottleneckHistorySize();
            /*0x7b4276c*/ void set_bottleneckHistorySize(int value);
            /*0x7b42774*/ int get_sampleHistorySize();
            /*0x7b4277c*/ void set_sampleHistorySize(int value);
            /*0x7b429ec*/ void UpdateFrameTiming();
            /*0x7b43268*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x7b44784*/ void Reset();
            /*0x7b44850*/ object <RegisterDebugUI>b__17_0();
            /*0x7b44884*/ object <RegisterDebugUI>b__17_1();
            /*0x7b448b8*/ object <RegisterDebugUI>b__17_2();
            /*0x7b448ec*/ object <RegisterDebugUI>b__17_3();
            /*0x7b44920*/ object <RegisterDebugUI>b__17_4();
            /*0x7b44954*/ object <RegisterDebugUI>b__17_5();
            /*0x7b44988*/ object <RegisterDebugUI>b__17_6();
            /*0x7b449bc*/ object <RegisterDebugUI>b__17_7();
            /*0x7b449f0*/ object <RegisterDebugUI>b__17_8();
            /*0x7b44a24*/ object <RegisterDebugUI>b__17_9();
            /*0x7b44a58*/ object <RegisterDebugUI>b__17_10();
            /*0x7b44a8c*/ object <RegisterDebugUI>b__17_11();
            /*0x7b44ac0*/ object <RegisterDebugUI>b__17_12();
            /*0x7b44af4*/ object <RegisterDebugUI>b__17_13();
            /*0x7b44b28*/ object <RegisterDebugUI>b__17_14();
            /*0x7b44b5c*/ object <RegisterDebugUI>b__17_15();
            /*0x7b44b90*/ object <RegisterDebugUI>b__17_16();
            /*0x7b44bc4*/ object <RegisterDebugUI>b__17_17();
            /*0x7b44bf8*/ object <RegisterDebugUI>b__17_18();
            /*0x7b44c2c*/ object <RegisterDebugUI>b__17_19();
            /*0x7b44c60*/ object <RegisterDebugUI>b__17_20();
            /*0x7b44c94*/ object <RegisterDebugUI>b__17_21();
        }

        enum DebugAction
        {
            EnableDebugMenu = 0,
            PreviousDebugPanel = 1,
            NextDebugPanel = 2,
            Action = 3,
            MakePersistent = 4,
            MoveVertical = 5,
            MoveHorizontal = 6,
            Multiplier = 7,
            ResetAll = 8,
            DebugActionCount = 9,
        }

        enum DebugActionRepeatMode
        {
            Never = 0,
            Delay = 1,
        }

        class DebugManager
        {
            static string kEnableDebugBtn1 = "Enable Debug Button 1";
            static string kEnableDebugBtn2 = "Enable Debug Button 2";
            static string kDebugPreviousBtn = "Debug Previous";
            static string kDebugNextBtn = "Debug Next";
            static string kValidateBtn = "Debug Validate";
            static string kPersistentBtn = "Debug Persistent";
            static string kDPadVertical = "Debug Vertical";
            static string kDPadHorizontal = "Debug Horizontal";
            static string kMultiplierBtn = "Debug Multiplier";
            static string kResetBtn = "Debug Reset";
            static string kEnableDebug = "Enable Debug";
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.DebugManager> s_Instance;
            static /*0x8*/ System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> windowStateChanged;
            /*0x10*/ UnityEngine.Rendering.DebugActionDesc[] m_DebugActions;
            /*0x18*/ UnityEngine.Rendering.DebugActionState[] m_DebugActionStates;
            /*0x20*/ UnityEngine.InputSystem.InputActionMap debugActionMap;
            /*0x28*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> m_ReadOnlyPanels;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Panel> m_Panels;
            /*0x38*/ System.Action<bool> onDisplayRuntimeUIChanged;
            /*0x40*/ System.Action onSetDirty;
            /*0x48*/ System.Action resetData;
            /*0x50*/ bool refreshEditorRequested;
            /*0x54*/ System.Nullable<int> m_RequestedPanelIndex;
            /*0x60*/ UnityEngine.GameObject m_Root;
            /*0x68*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas m_RootUICanvas;
            /*0x70*/ UnityEngine.GameObject m_PersistentRoot;
            /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;
            /*0x80*/ UnityEngine.Rendering.DebugManager.UIState editorUIState;
            /*0x88*/ bool m_EnableRuntimeUI;
            /*0x90*/ UnityEngine.Rendering.DebugManager.UIState runtimeUIState;

            static /*0x7b49560*/ DebugManager();
            static /*0x7b3dcc4*/ UnityEngine.Rendering.DebugManager get_instance();
            static /*0x7b48e3c*/ void add_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            static /*0x7b48f30*/ void remove_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            /*0x7b46c40*/ DebugManager();
            /*0x7b44cc8*/ void RegisterActions();
            /*0x7b4523c*/ void EnableInputActions();
            /*0x7b45144*/ void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc);
            /*0x7b454b0*/ void SampleAction(int actionIndex);
            /*0x7b45660*/ void UpdateAction(int actionIndex);
            /*0x7b4589c*/ void UpdateActions();
            /*0x7b458f4*/ float GetAction(UnityEngine.Rendering.DebugAction action);
            /*0x7b4592c*/ bool GetActionToggleDebugMenuWithTouch();
            /*0x7b45bbc*/ bool GetActionReleaseScrollTarget();
            /*0x7b45d20*/ void RegisterInputs();
            /*0x7b46690*/ void UpdateReadOnlyCollection();
            /*0x7b46714*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels();
            /*0x7b46738*/ void add_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x7b467e8*/ void remove_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x7b46898*/ void add_onSetDirty(System.Action value);
            /*0x7b46934*/ void remove_onSetDirty(System.Action value);
            /*0x7b469d0*/ void add_resetData(System.Action value);
            /*0x7b46a6c*/ void remove_resetData(System.Action value);
            /*0x7b46b08*/ bool get_isAnyDebugUIActive();
            /*0x7b3dd3c*/ void RefreshEditor();
            /*0x7b46ef8*/ void Reset();
            /*0x7b422f8*/ void ReDrawOnScreenDebug();
            /*0x7b3dd50*/ void RegisterData(UnityEngine.Rendering.IDebugData data);
            /*0x7b3dff0*/ void UnregisterData(UnityEngine.Rendering.IDebugData data);
            /*0x7b46f24*/ int GetState();
            /*0x7b4708c*/ void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root);
            /*0x7b470d8*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
            /*0x7b470f8*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
            /*0x7b47190*/ void EnsurePersistentCanvas();
            /*0x7b473bc*/ void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget, System.Nullable<int> forceTupleIndex);
            /*0x7b4792c*/ void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x7b47950*/ int PanelIndex(string displayName);
            /*0x7b47a1c*/ string PanelDiplayName(int panelIndex);
            /*0x7b47ab8*/ void RequestEditorWindowPanelIndex(int index);
            /*0x7b47b20*/ System.Nullable<int> GetRequestedEditorWindowPanelIndex();
            /*0x7b3ddfc*/ UnityEngine.Rendering.DebugUI.Panel GetPanel(string displayName, bool createIfNull, int groupIndex, bool overrideIfExist);
            /*0x7b47ef4*/ int FindPanelIndex(string displayName);
            /*0x7b47fe0*/ void RemovePanel(string displayName);
            /*0x7b47be0*/ void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x7b48198*/ UnityEngine.Rendering.DebugUI.Widget[] GetItems(UnityEngine.Rendering.DebugUI.Flags flags);
            /*0x7b4843c*/ UnityEngine.Rendering.DebugUI.Widget[] GetItemsFromContainer(UnityEngine.Rendering.DebugUI.Flags flags, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x7b48988*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath);
            /*0x7b48ae0*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x7b49024*/ bool get_displayEditorUI();
            /*0x7b49040*/ void set_displayEditorUI(bool value);
            /*0x7b490f0*/ bool get_enableRuntimeUI();
            /*0x7b490f8*/ void set_enableRuntimeUI(bool value);
            /*0x7b46b30*/ bool get_displayRuntimeUI();
            /*0x7b49128*/ void set_displayRuntimeUI(bool value);
            /*0x7b46bb8*/ bool get_displayPersistentRuntimeUI();
            /*0x7b494a8*/ void set_displayPersistentRuntimeUI(bool value);
            /*0x7b49544*/ void ToggleEditorUI(bool open);

            enum UIMode
            {
                EditorMode = 0,
                RuntimeMode = 1,
            }

            class UIState
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager.UIMode mode;
                /*0x14*/ bool m_Open;

                /*0x7b46ef0*/ UIState();
                /*0x7b49678*/ bool get_open();
                /*0x7b4905c*/ void set_open(bool value);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.DebugManager.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__49_0;
                static /*0x10*/ System.Action <>9__49_1;
                static /*0x18*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, int> <>9__60_0;

                static /*0x7b49680*/ <>c();
                /*0x7b496e8*/ <>c();
                /*0x7b496f0*/ void <.ctor>b__49_0(bool <p0>);
                /*0x7b496f4*/ void <.ctor>b__49_1();
                /*0x7b496f8*/ int <TogglePersistent>b__60_0(UnityEngine.Rendering.DebugUI.Widget w);
                /*0x7b49774*/ UnityEngine.Rendering.DebugManager <.cctor>b__95_0();
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ string displayName;

                /*0x7b47fd8*/ <>c__DisplayClass67_0();
                /*0x7b497c4*/ bool <FindPanelIndex>b__0(UnityEngine.Rendering.DebugUI.Panel p);
            }
        }

        class DebugActionDesc
        {
            /*0x10*/ UnityEngine.InputSystem.InputAction buttonAction;
            /*0x18*/ UnityEngine.Rendering.DebugActionRepeatMode repeatMode;
            /*0x1c*/ float repeatDelay;

            /*0x7b4513c*/ DebugActionDesc();
        }

        class DebugActionState
        {
            /*0x10*/ UnityEngine.Rendering.DebugActionState.DebugActionKeyType m_Type;
            /*0x18*/ UnityEngine.InputSystem.InputAction inputAction;
            /*0x20*/ bool[] m_TriggerPressedUp;
            /*0x28*/ float m_Timer;
            /*0x2c*/ bool <runningAction>k__BackingField;
            /*0x30*/ float <actionState>k__BackingField;

            /*0x7b454a8*/ DebugActionState();
            /*0x7b497e8*/ bool get_runningAction();
            /*0x7b497f0*/ void set_runningAction(bool value);
            /*0x7b497fc*/ float get_actionState();
            /*0x7b49804*/ void set_actionState(float value);
            /*0x7b4980c*/ void Trigger(int triggerCount, float state);
            /*0x7b455e8*/ void TriggerWithButton(UnityEngine.InputSystem.InputAction action, float state);
            /*0x7b498d4*/ void Reset();
            /*0x7b456c4*/ void Update(UnityEngine.Rendering.DebugActionDesc desc);

            enum DebugActionKeyType
            {
                Button = 0,
                Axis = 1,
                Key = 2,
            }
        }

        interface IDebugData
        {
            /*0x38148bc*/ System.Action GetReset();
        }

        class DebugOverlay
        {
            /*0x10*/ int <x>k__BackingField;
            /*0x14*/ int <y>k__BackingField;
            /*0x18*/ int <overlaySize>k__BackingField;
            /*0x1c*/ int m_InitialPositionX;
            /*0x20*/ int m_ScreenWidth;

            /*0x7b499cc*/ DebugOverlay();
            /*0x7b498e8*/ int get_x();
            /*0x7b498f0*/ void set_x(int value);
            /*0x7b498f8*/ int get_y();
            /*0x7b49900*/ void set_y(int value);
            /*0x7b49908*/ int get_overlaySize();
            /*0x7b49910*/ void set_overlaySize(int value);
            /*0x7b49918*/ void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth);
            /*0x7b49928*/ UnityEngine.Rect Next(float aspect);
            /*0x7b49998*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd);
        }

        class DebugShapes
        {
            static /*0x0*/ UnityEngine.Rendering.DebugShapes s_Instance;
            /*0x10*/ UnityEngine.Mesh m_sphereMesh;
            /*0x18*/ UnityEngine.Mesh m_boxMesh;
            /*0x20*/ UnityEngine.Mesh m_coneMesh;
            /*0x28*/ UnityEngine.Mesh m_pyramidMesh;

            static /*0x7b499d4*/ UnityEngine.Rendering.DebugShapes get_instance();
            /*0x7b49a5c*/ DebugShapes();
            /*0x7b49a64*/ void BuildSphere(ref UnityEngine.Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv);
            /*0x7b4a14c*/ void BuildBox(ref UnityEngine.Mesh outputMesh, float length, float width, float height);
            /*0x7b4a8a0*/ void BuildCone(ref UnityEngine.Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides);
            /*0x7b4b1c8*/ void BuildPyramid(ref UnityEngine.Mesh outputMesh, float width, float height, float depth);
            /*0x7b4b4b8*/ void BuildShapes();
            /*0x7b4b5ec*/ void RebuildResources();
            /*0x7b4b6dc*/ UnityEngine.Mesh RequestSphereMesh();
            /*0x7b4b6f4*/ UnityEngine.Mesh BuildCustomSphereMesh(float radius, uint longSubdiv, uint latSubdiv);
            /*0x7b4b788*/ UnityEngine.Mesh RequestBoxMesh();
            /*0x7b4b7a0*/ UnityEngine.Mesh RequestConeMesh();
            /*0x7b4b7b8*/ UnityEngine.Mesh RequestPyramidMesh();
        }

        class DebugUI
        {
            /*0x7b4b7d0*/ DebugUI();

            class Container : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IContainer
            {
                static string k_IDToken = "#";
                /*0x48*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;

                /*0x7b4b93c*/ Container();
                /*0x7b4bbc4*/ Container(string id);
                /*0x7b4b9cc*/ Container(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children);
                /*0x7b4b7d8*/ bool get_hideDisplayName();
                /*0x7b4b84c*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x7b4b854*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x7b4b85c*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x7b4b864*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x7b4bc80*/ void GenerateQueryPath();
                /*0x7b4be3c*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b4bf6c*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b4bfd4*/ int GetHashCode();
            }

            class Foldout : UnityEngine.Rendering.DebugUI.Container, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x50*/ bool opened;
                /*0x51*/ bool isHeader;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Foldout.ContextMenuItem> contextMenuItems;
                /*0x60*/ bool m_Dirty;
                /*0x68*/ string[] m_ColumnLabels;
                /*0x70*/ string[] m_ColumnTooltips;
                /*0x78*/ System.Collections.Generic.List<UnityEngine.GUIContent> m_RowContents;

                /*0x7b446c0*/ Foldout();
                /*0x7b4c41c*/ Foldout(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips);
                /*0x7b4c134*/ bool get_isReadOnly();
                /*0x7b4c13c*/ string[] get_columnLabels();
                /*0x7b44744*/ void set_columnLabels(string[] value);
                /*0x7b4c144*/ string[] get_columnTooltips();
                /*0x7b4c14c*/ void set_columnTooltips(string[] value);
                /*0x7b4c170*/ System.Collections.Generic.List<UnityEngine.GUIContent> get_rowContents();
                /*0x7b4c4f8*/ bool GetValue();
                /*0x7b4c500*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x7b4c528*/ void SetValue(object value);
                /*0x7b4c57c*/ object ValidateValue(object value);
                /*0x7b4c584*/ void SetValue(bool value);

                struct ContextMenuItem
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ System.Action action;
                }
            }

            class HBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x7b4c590*/ HBox();
            }

            class VBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x7b4c5e4*/ VBox();
            }

            class Table : UnityEngine.Rendering.DebugUI.Container
            {
                static /*0x0*/ UnityEngine.GUIStyle columnHeaderStyle;
                /*0x50*/ bool isReadOnly;
                /*0x58*/ bool[] m_Header;

                static /*0x7b4c904*/ Table();
                /*0x7b40948*/ Table();
                /*0x7b4178c*/ void SetColumnVisibility(int index, bool visible);
                /*0x7b4c878*/ bool GetColumnVisibility(int index);
                /*0x7b4c638*/ bool[] get_VisibleColumns();
                /*0x7b4c8c4*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b4c8e4*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);

                class Row : UnityEngine.Rendering.DebugUI.Foldout
                {
                    /*0x7b418ac*/ Row();
                }
            }

            enum Flags
            {
                None = 0,
                EditorOnly = 2,
                RuntimeOnly = 4,
                EditorForceUpdate = 8,
                FrequentlyUsed = 16,
            }

            class Widget
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Panel m_Panel;
                /*0x18*/ UnityEngine.Rendering.DebugUI.IContainer m_Parent;
                /*0x20*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x28*/ string <displayName>k__BackingField;
                /*0x30*/ string <tooltip>k__BackingField;
                /*0x38*/ string <queryPath>k__BackingField;
                /*0x40*/ System.Func<bool> isHiddenCallback;

                /*0x7b4bc78*/ Widget();
                /*0x7b4c998*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x7b4c9a0*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x7b4c9a8*/ UnityEngine.Rendering.DebugUI.IContainer get_parent();
                /*0x7b4c9b0*/ void set_parent(UnityEngine.Rendering.DebugUI.IContainer value);
                /*0x7b4c9b8*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x7b4c9c0*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x7b4c9c8*/ string get_displayName();
                /*0x7b4c9d0*/ void set_displayName(string value);
                /*0x7b4c9d8*/ string get_tooltip();
                /*0x7b4c9e0*/ void set_tooltip(string value);
                /*0x7b4c9e8*/ string get_queryPath();
                /*0x7b4c9f0*/ void set_queryPath(string value);
                /*0x7b4c9f8*/ bool get_isEditorOnly();
                /*0x7b4ca04*/ bool get_isRuntimeOnly();
                /*0x7b4ca10*/ bool get_isInactiveInEditor();
                /*0x7b4c114*/ bool get_isHidden();
                /*0x7b4bd38*/ void GenerateQueryPath();
                /*0x7b4ca80*/ int GetHashCode();
                /*0x7b417e8*/ void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value);

                struct NameAndTooltip
                {
                    /*0x10*/ string name;
                    /*0x18*/ string tooltip;
                }
            }

            interface IContainer
            {
                /*0x38148bc*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x38148bc*/ string get_displayName();
                /*0x3816710*/ void set_displayName(string value);
                /*0x38148bc*/ string get_queryPath();
            }

            interface IValueField
            {
                /*0x38148bc*/ object GetValue();
                /*0x3816710*/ void SetValue(object value);
                /*0x3814a3c*/ object ValidateValue(object value);
            }

            class Button : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Action <action>k__BackingField;

                /*0x7b4cb1c*/ Button();
                /*0x7b4cb0c*/ System.Action get_action();
                /*0x7b4cb14*/ void set_action(System.Action value);
            }

            class Value : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Func<object> <getter>k__BackingField;
                /*0x50*/ float refreshRate;
                /*0x58*/ string formatString;

                /*0x7b3f6fc*/ Value();
                /*0x7b4cb24*/ System.Func<object> get_getter();
                /*0x7b4cb2c*/ void set_getter(System.Func<object> value);
                /*0x7b4cb34*/ object GetValue();
                /*0x7b4cb58*/ string FormatString(object value);
            }

            class ProgressBarValue : UnityEngine.Rendering.DebugUI.Value
            {
                /*0x60*/ float min;
                /*0x64*/ float max;

                static /*0x7b4cc9c*/ float <FormatString>g__Remap01|2_0(float v, float x0, float y0);
                /*0x7b44778*/ ProgressBarValue();
                /*0x7b4cbc4*/ string FormatString(object value);
            }

            class ValueTuple : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.Value[] values;
                /*0x50*/ int pinnedElementIndex;

                /*0x7b44768*/ ValueTuple();
                /*0x7b4ccac*/ int get_numElements();
                /*0x7b4ccc8*/ float get_refreshRate();
            }

            class Field<T> : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x0*/ System.Func<T> <getter>k__BackingField;
                /*0x0*/ System.Action<T> <setter>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.Rendering.DebugUI.Field<T>, T> onValueChanged;

                /*0x38159dc*/ Field();
                /*0x38148bc*/ System.Func<T> get_getter();
                /*0x3816710*/ void set_getter(System.Func<T> value);
                /*0x38148bc*/ System.Action<T> get_setter();
                /*0x3816710*/ void set_setter(System.Action<T> value);
                /*0x3814a3c*/ object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
                /*0x3910ae8*/ T ValidateValue(T value);
                /*0x38148bc*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x3910ae8*/ T GetValue();
                /*0x3816710*/ void SetValue(object value);
                /*0x3910ae8*/ void SetValue(T value);
            }

            class BoolField : UnityEngine.Rendering.DebugUI.Field<bool>
            {
                /*0x7b4cd28*/ BoolField();
            }

            class HistoryBoolField : UnityEngine.Rendering.DebugUI.BoolField
            {
                /*0x60*/ System.Func<bool> <historyGetter>k__BackingField;

                /*0x7b4cdd8*/ HistoryBoolField();
                /*0x7b4cd70*/ System.Func<bool> get_historyGetter();
                /*0x7b4cd78*/ void set_historyGetter(System.Func<bool> value);
                /*0x7b4cd80*/ int get_historyDepth();
                /*0x7b4cd98*/ bool GetHistoryValue(int historyIndex);
            }

            class IntField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ System.Func<int> min;
                /*0x68*/ System.Func<int> max;
                /*0x70*/ int incStep;
                /*0x74*/ int intStepMult;

                /*0x7b4ce3c*/ IntField();
                /*0x7b4cddc*/ int ValidateValue(int value);
            }

            class UIntField : UnityEngine.Rendering.DebugUI.Field<uint>
            {
                /*0x60*/ System.Func<uint> min;
                /*0x68*/ System.Func<uint> max;
                /*0x70*/ uint incStep;
                /*0x74*/ uint intStepMult;

                /*0x7b4cef0*/ UIntField();
                /*0x7b4ce90*/ uint ValidateValue(uint value);
            }

            class FloatField : UnityEngine.Rendering.DebugUI.Field<float>
            {
                /*0x60*/ System.Func<float> min;
                /*0x68*/ System.Func<float> max;
                /*0x70*/ float incStep;
                /*0x74*/ float incStepMult;
                /*0x78*/ int decimals;

                /*0x7b4cfa4*/ FloatField();
                /*0x7b4cf44*/ float ValidateValue(float value);
            }

            class EnumField<T> : UnityEngine.Rendering.DebugUI.Field<T>
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_NicifyRegEx;
                /*0x0*/ UnityEngine.GUIContent[] enumNames;
                /*0x0*/ int[] m_EnumValues;

                static /*0x383e7a0*/ EnumField();
                /*0x38159dc*/ EnumField();
                /*0x38148bc*/ int[] get_enumValues();
                /*0x3816710*/ void set_enumValues(int[] value);
                /*0x3816710*/ void AutoFillFromType(System.Type enumType);

                class <>c<T>
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__6_0;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x38141c4*/ bool <AutoFillFromType>b__6_0(System.Reflection.FieldInfo fieldInfo);
                }
            }

            class EnumField : UnityEngine.Rendering.DebugUI.EnumField<int>
            {
                /*0x70*/ int[] quickSeparators;
                /*0x78*/ int[] m_Indexes;
                /*0x80*/ System.Func<int> <getIndex>k__BackingField;
                /*0x88*/ System.Action<int> <setIndex>k__BackingField;

                /*0x7b3f3dc*/ EnumField();
                /*0x7b4d000*/ int[] get_indexes();
                /*0x7b4d08c*/ System.Func<int> get_getIndex();
                /*0x7b4d094*/ void set_getIndex(System.Func<int> value);
                /*0x7b4d09c*/ System.Action<int> get_setIndex();
                /*0x7b4d0a4*/ void set_setIndex(System.Action<int> value);
                /*0x7b4d0ac*/ int get_currentIndex();
                /*0x7b4d0d0*/ void set_currentIndex(int value);
                /*0x7b4d0f4*/ void set_autoEnum(System.Type value);
                /*0x7b4d154*/ void InitQuickSeparators();
                /*0x7b4d378*/ void SetValue(int value);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.GUIContent, string> <>9__17_0;

                    static /*0x7b4d4c8*/ <>c();
                    /*0x7b4d530*/ <>c();
                    /*0x7b4d538*/ string <InitQuickSeparators>b__17_0(UnityEngine.GUIContent x);
                }
            }

            class ObjectPopupField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> <getObjects>k__BackingField;

                /*0x7b3f664*/ ObjectPopupField();
                /*0x7b4d5c4*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> get_getObjects();
                /*0x7b4d5cc*/ void set_getObjects(System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> value);
            }

            class HistoryEnumField : UnityEngine.Rendering.DebugUI.EnumField
            {
                /*0x90*/ System.Func<int> <historyIndexGetter>k__BackingField;

                /*0x7b4d63c*/ HistoryEnumField();
                /*0x7b4d5d4*/ System.Func<int> get_historyIndexGetter();
                /*0x7b4d5dc*/ void set_historyIndexGetter(System.Func<int> value);
                /*0x7b4d5e4*/ int get_historyDepth();
                /*0x7b4d5fc*/ int GetHistoryValue(int historyIndex);
            }

            class BitField : UnityEngine.Rendering.DebugUI.EnumField<System.Enum>
            {
                /*0x70*/ System.Type m_EnumType;

                /*0x7b4d6b0*/ BitField();
                /*0x7b4d640*/ System.Type get_enumType();
                /*0x7b4d648*/ void set_enumType(System.Type value);
            }

            class MaskField : UnityEngine.Rendering.DebugUI.EnumField<uint>
            {
                /*0x7b4dc1c*/ MaskField();
                /*0x7b4d71c*/ void Fill(string[] names);
                /*0x7b4db40*/ void SetValue(uint value);
            }

            class ColorField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Color>
            {
                /*0x60*/ bool hdr;
                /*0x61*/ bool showAlpha;
                /*0x62*/ bool showPicker;
                /*0x64*/ float incStep;
                /*0x68*/ float incStepMult;
                /*0x6c*/ int decimals;

                /*0x7b4dcd8*/ ColorField();
                /*0x7b4dc88*/ UnityEngine.Color ValidateValue(UnityEngine.Color value);
            }

            class Vector2Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector2>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b4dd3c*/ Vector2Field();
            }

            class Vector3Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector3>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b4dd98*/ Vector3Field();
            }

            class Vector4Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector4>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b4ddf4*/ Vector4Field();
            }

            class ObjectField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Type type;

                /*0x7b41818*/ ObjectField();
            }

            class ObjectListField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object[]>
            {
                /*0x60*/ System.Type type;

                /*0x7b4de50*/ ObjectListField();
            }

            class MessageBox : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.MessageBox.Style style;
                /*0x50*/ System.Func<string> messageCallback;

                /*0x7b4df04*/ MessageBox();
                /*0x7b4dee4*/ string get_message();

                enum Style
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }

            class RuntimeDebugShadersMessageBox : UnityEngine.Rendering.DebugUI.MessageBox
            {
                /*0x7b4df0c*/ RuntimeDebugShadersMessageBox();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.RuntimeDebugShadersMessageBox.<> <>9;
                    static /*0x8*/ System.Func<bool> <>9__0_0;

                    static /*0x7b4e02c*/ <>c();
                    /*0x7b4e094*/ <>c();
                    /*0x7b4e09c*/ bool <.ctor>b__0_0();
                }
            }

            class Panel : UnityEngine.Rendering.DebugUI.IContainer, System.IComparable<UnityEngine.Rendering.DebugUI.Panel>
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x18*/ string <displayName>k__BackingField;
                /*0x20*/ int <groupIndex>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;
                /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;

                /*0x7b47c50*/ Panel();
                /*0x7b4e130*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x7b4e138*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x7b4e140*/ string get_displayName();
                /*0x7b4e148*/ void set_displayName(string value);
                /*0x7b4e150*/ int get_groupIndex();
                /*0x7b4e158*/ void set_groupIndex(int value);
                /*0x7b4e160*/ string get_queryPath();
                /*0x7b4e168*/ bool get_isEditorOnly();
                /*0x7b4e174*/ bool get_isRuntimeOnly();
                /*0x7b4e180*/ bool get_isInactiveInEditor();
                /*0x7b4e1f0*/ bool get_editorForceUpdate();
                /*0x7b4e1fc*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x7b4e204*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x7b47e44*/ void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x7b47b30*/ void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x7b4e20c*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b4e264*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b4bea4*/ void SetDirty();
                /*0x7b4e2bc*/ int GetHashCode();
                /*0x7b4e39c*/ int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Panel.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> <>9__29_0;

                    static /*0x7b4e3d0*/ <>c();
                    /*0x7b4e438*/ <>c();
                    /*0x7b4e440*/ void <.ctor>b__29_0(UnityEngine.Rendering.DebugUI.Panel <p0>);
                }
            }
        }

        class DebugUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.Rendering.DebugUpdater s_Instance;
            /*0x20*/ UnityEngine.ScreenOrientation m_Orientation;
            /*0x24*/ bool m_RuntimeUiWasVisibleLastFrame;

            static /*0x7b4e444*/ void RuntimeInit();
            static /*0x7b4911c*/ void SetEnabled(bool enabled);
            static /*0x7b4e448*/ void EnableRuntime();
            static /*0x7b4e5d0*/ void DisableRuntime();
            static /*0x7b493e4*/ void HandleInternalEventSystemComponents(bool uiEnabled);
            static /*0x7b4ef98*/ System.Collections.IEnumerator RefreshRuntimeUINextFrame();
            /*0x7b4f018*/ DebugUpdater();
            /*0x7b4e70c*/ void EnsureExactlyOneEventSystem();
            /*0x7b4eb28*/ System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action);
            /*0x7b4ebbc*/ void CheckInputModuleExists();
            /*0x7b4ece8*/ void AssignDefaultActions();
            /*0x7b4ea48*/ void CreateDebugEventSystem();
            /*0x7b4e8e8*/ void DestroyDebugEventSystem();
            /*0x7b4ee40*/ void Update();

            class <DoAfterInputModuleUpdated>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Action action;

                /*0x7b4eb94*/ <DoAfterInputModuleUpdated>d__9(int <>1__state);
                /*0x7b4f020*/ void System.IDisposable.Dispose();
                /*0x7b4f024*/ bool MoveNext();
                /*0x7b4f120*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7b4f128*/ void System.Collections.IEnumerator.Reset();
                /*0x7b4f160*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RefreshRuntimeUINextFrame>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x7b4eff0*/ <RefreshRuntimeUINextFrame>d__15(int <>1__state);
                /*0x7b4f168*/ void System.IDisposable.Dispose();
                /*0x7b4f16c*/ bool MoveNext();
                /*0x7b4f20c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7b4f214*/ void System.Collections.IEnumerator.Reset();
                /*0x7b4f24c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        enum PerformanceBottleneck
        {
            Indeterminate = 0,
            PresentLimited = 1,
            CPU = 2,
            GPU = 3,
            Balanced = 4,
        }

        struct BottleneckHistogram
        {
            /*0x10*/ float PresentLimited;
            /*0x14*/ float CPU;
            /*0x18*/ float GPU;
            /*0x1c*/ float Balanced;
        }

        class BottleneckHistory
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.PerformanceBottleneck> m_Bottlenecks;
            /*0x18*/ UnityEngine.Rendering.BottleneckHistogram Histogram;

            static /*0x7b4f254*/ UnityEngine.Rendering.PerformanceBottleneck DetermineBottleneck(UnityEngine.Rendering.FrameTimeSample s);
            /*0x7b42930*/ BottleneckHistory(int initialCapacity);
            /*0x7b42fec*/ void DiscardOldSamples(int historySize);
            /*0x7b4308c*/ void AddBottleneckFromAveragedSample(UnityEngine.Rendering.FrameTimeSample frameHistorySampleAverage);
            /*0x7b43158*/ void ComputeHistogram();
            /*0x7b447ac*/ void Clear();
        }

        struct FrameTimeSample
        {
            /*0x10*/ float FramesPerSecond;
            /*0x14*/ float FullFrameTime;
            /*0x18*/ float MainThreadCPUFrameTime;
            /*0x1c*/ float MainThreadCPUPresentWaitTime;
            /*0x20*/ float RenderThreadCPUFrameTime;
            /*0x24*/ float GPUFrameTime;

            /*0x7b4f2fc*/ FrameTimeSample(float initValue);
        }

        class FrameTimeSampleHistory
        {
            static /*0x0*/ System.Func<float, float, float> s_SampleValueAdd;
            static /*0x8*/ System.Func<float, float, float> s_SampleValueMin;
            static /*0x10*/ System.Func<float, float, float> s_SampleValueMax;
            static /*0x18*/ System.Func<float, float, float> s_SampleValueCountValid;
            static /*0x20*/ System.Func<float, float, float> s_SampleValueEnsureValid;
            static /*0x28*/ System.Func<float, float, float> s_SampleValueDivide;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.FrameTimeSample> m_Samples;
            /*0x18*/ UnityEngine.Rendering.FrameTimeSample SampleAverage;
            /*0x30*/ UnityEngine.Rendering.FrameTimeSample SampleMin;
            /*0x48*/ UnityEngine.Rendering.FrameTimeSample SampleMax;

            static /*0x7b4f3dc*/ FrameTimeSampleHistory();
            static /*0x7b4f30c*/ void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref UnityEngine.Rendering.FrameTimeSample aggregate, UnityEngine.Rendering.FrameTimeSample sample, System.Func<float, float, float> func);
            /*0x7b42874*/ FrameTimeSampleHistory(int initialCapacity);
            /*0x7b42c74*/ void Add(UnityEngine.Rendering.FrameTimeSample sample);
            /*0x7b42d5c*/ void ComputeAggregateValues();
            /*0x7b42bd4*/ void DiscardOldSamples(int sampleHistorySize);
            /*0x7b44800*/ void Clear();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.FrameTimeSampleHistory.<> <>9;

                static /*0x7b4f654*/ <>c();
                /*0x7b4f6bc*/ <>c();
                /*0x7b4f6c4*/ float <.cctor>b__15_0(float value, float other);
                /*0x7b4f6cc*/ float <.cctor>b__15_1(float value, float other);
                /*0x7b4f6e0*/ float <.cctor>b__15_2(float value, float other);
                /*0x7b4f6ec*/ float <.cctor>b__15_3(float value, float other);
                /*0x7b4f700*/ float <.cctor>b__15_4(float value, float other);
                /*0x7b4f710*/ float <.cctor>b__15_5(float value, float other);
            }
        }

        interface IDebugDisplaySettings
        {
            /*0x38159dc*/ void Reset();
            /*0x3816710*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x7b4f724*/ UnityEngine.Rendering.IDebugDisplaySettingsData Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
        }

        interface IDebugDisplaySettingsData : UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x38148bc*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();
        }

        interface IDebugDisplaySettingsPanel
        {
            /*0x38148bc*/ string get_PanelName();
            /*0x38148bc*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x3814574*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
        }

        interface IDebugDisplaySettingsPanelDisposable : UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
        }

        interface IDebugDisplaySettingsQuery
        {
            /*0x3813ffc*/ bool get_AreAnySettingsActive();
            /*0x7b4f72c*/ bool get_IsPostProcessingAllowed();
            /*0x7b4f734*/ bool get_IsLightingActive();
            /*0x7b4f73c*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
        }

        interface IVolumeDebugSettings
        {
            /*0x3814574*/ int get_selectedComponent();
            /*0x3815ed0*/ void set_selectedComponent(int value);
            /*0x38148bc*/ UnityEngine.Camera get_selectedCamera();
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x3814574*/ int get_selectedCameraIndex();
            /*0x3815ed0*/ void set_selectedCameraIndex(int value);
            /*0x38148bc*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x38159a4*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x38148bc*/ System.Type get_selectedComponentType();
            /*0x3816710*/ void set_selectedComponentType(System.Type value);
            /*0x38148bc*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x38141c4*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);
            /*0x38141c4*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
        }

        interface IVolumeDebugSettings2 : UnityEngine.Rendering.IVolumeDebugSettings
        {
            /*0x38148bc*/ System.Type get_targetRenderPipeline();
            /*0x38148bc*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
        }

        class MousePositionDebug
        {
            static /*0x0*/ UnityEngine.Rendering.MousePositionDebug s_Instance;

            static /*0x7b4f744*/ UnityEngine.Rendering.MousePositionDebug get_instance();
            /*0x7b4f7cc*/ MousePositionDebug();
            /*0x7b4f7d4*/ void Build();
            /*0x7b4f7d8*/ void Cleanup();
            /*0x7b4f7dc*/ UnityEngine.Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
            /*0x7b4f7e0*/ UnityEngine.Vector2 GetInputMousePosition();
            /*0x7b4f86c*/ UnityEngine.Vector2 GetMouseClickPosition(float ScreenHeight);
        }

        class TProfilingSampler<TEnum> : UnityEngine.Rendering.ProfilingSampler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<TEnum, UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;

            static /*0x383e7a0*/ TProfilingSampler();
            /*0x3816710*/ TProfilingSampler(string name);
        }

        class ProfilingSampler
        {
            /*0x10*/ UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;
            /*0x18*/ UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;
            /*0x20*/ string <name>k__BackingField;
            /*0x28*/ UnityEngine.Profiling.Recorder m_Recorder;
            /*0x30*/ UnityEngine.Profiling.Recorder m_InlineRecorder;

            static /*0x3910ae8*/ UnityEngine.Rendering.ProfilingSampler Get<TEnum>(TEnum marker);
            /*0x7b4f8ac*/ ProfilingSampler(string name);
            /*0x7b4fcf8*/ ProfilingSampler();
            /*0x7b4f9f8*/ void Begin(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b4fa5c*/ void End(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b4fac0*/ bool IsValid();
            /*0x7b4fae0*/ UnityEngine.Profiling.CustomSampler get_sampler();
            /*0x7b4fae8*/ void set_sampler(UnityEngine.Profiling.CustomSampler value);
            /*0x7b4faf0*/ UnityEngine.Profiling.CustomSampler get_inlineSampler();
            /*0x7b4faf8*/ void set_inlineSampler(UnityEngine.Profiling.CustomSampler value);
            /*0x7b4fb00*/ string get_name();
            /*0x7b4fb08*/ void set_name(string value);
            /*0x7b4fb10*/ void set_enableRecording(bool value);
            /*0x7b4fb54*/ float get_gpuElapsedTime();
            /*0x7b4fba0*/ int get_gpuSampleCount();
            /*0x7b4fbe0*/ float get_cpuElapsedTime();
            /*0x7b4fc2c*/ int get_cpuSampleCount();
            /*0x7b4fc6c*/ float get_inlineCpuElapsedTime();
            /*0x7b4fcb8*/ int get_inlineCpuSampleCount();
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x7b4fd00*/ ProfilingScope(UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b4fd04*/ ProfilingScope(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b4fd08*/ ProfilingScope(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b4fd0c*/ void Dispose();
        }

        struct ProfilingSample : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
            /*0x18*/ string m_Name;
            /*0x20*/ bool m_Disposed;
            /*0x28*/ UnityEngine.Profiling.CustomSampler m_Sampler;

            /*0x7b4fd10*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string name, UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b4fdc0*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object arg);
            /*0x7b4fdfc*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object[] args);
            /*0x7b4fe38*/ void Dispose();
            /*0x7b4fe40*/ void Dispose(bool disposing);
        }

        class ShaderDebugPrintManager
        {
            static int k_FramesInFlight = 4;
            static int k_MaxBufferElements = 16384;
            static uint k_TypeHasTag = 128;
            static /*0x0*/ UnityEngine.Rendering.ShaderDebugPrintManager s_Instance;
            static /*0x8*/ int m_ShaderPropertyIDInputMouse;
            static /*0xc*/ int m_ShaderPropertyIDInputFrame;
            static /*0x10*/ int m_shaderDebugOutputData;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.GraphicsBuffer> m_OutputBuffers;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.AsyncGPUReadbackRequest> m_ReadbackRequests;
            /*0x20*/ System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> m_BufferReadCompleteAction;
            /*0x28*/ int m_FrameCounter;
            /*0x2c*/ bool m_FrameCleared;
            /*0x30*/ string m_OutputLine;
            /*0x38*/ System.Action<string> m_OutputAction;

            static /*0x7b51584*/ ShaderDebugPrintManager();
            static /*0x7b501dc*/ UnityEngine.Rendering.ShaderDebugPrintManager get_instance();
            /*0x7b4fef0*/ ShaderDebugPrintManager();
            /*0x7b4fecc*/ int DebugValueTypeToElemSize(UnityEngine.Rendering.ShaderDebugPrintManager.DebugValueType type);
            /*0x7b50234*/ void SetShaderDebugPrintInputConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ShaderDebugPrintInput input);
            /*0x7b502fc*/ void SetShaderDebugPrintBindings(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b50438*/ void ClearShaderDebugPrintBuffer();
            /*0x7b50524*/ void BufferReadComplete(UnityEngine.Rendering.AsyncGPUReadbackRequest request);
            /*0x7b5139c*/ void EndFrame();
            /*0x7b5145c*/ void PrintImmediate();
            /*0x7b5151c*/ string get_outputLine();
            /*0x7b51524*/ void set_outputAction(System.Action<string> value);
            /*0x7b5152c*/ void DefaultOutput(string line);

            class Profiling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler BufferReadComplete;

                static /*0x7b51678*/ Profiling();
            }

            enum DebugValueType
            {
                TypeUint = 1,
                TypeInt = 2,
                TypeFloat = 3,
                TypeUint2 = 4,
                TypeInt2 = 5,
                TypeFloat2 = 6,
                TypeUint3 = 7,
                TypeInt3 = 8,
                TypeFloat3 = 9,
                TypeUint4 = 10,
                TypeInt4 = 11,
                TypeFloat4 = 12,
                TypeBool = 13,
            }
        }

        struct ShaderDebugPrintInput
        {
            /*0x10*/ UnityEngine.Vector2 <pos>k__BackingField;
            /*0x18*/ bool <leftDown>k__BackingField;
            /*0x19*/ bool <rightDown>k__BackingField;
            /*0x1a*/ bool <middleDown>k__BackingField;

            /*0x7b51710*/ UnityEngine.Vector2 get_pos();
            /*0x7b51718*/ void set_pos(UnityEngine.Vector2 value);
            /*0x7b51720*/ bool get_leftDown();
            /*0x7b51728*/ void set_leftDown(bool value);
            /*0x7b51734*/ bool get_rightDown();
            /*0x7b5173c*/ void set_rightDown(bool value);
            /*0x7b51748*/ bool get_middleDown();
            /*0x7b51750*/ void set_middleDown(bool value);
            /*0x7b5175c*/ string String();
        }

        class ShaderDebugPrintInputProducer
        {
            static /*0x7b51978*/ UnityEngine.Rendering.ShaderDebugPrintInput Get();
        }

        class VolumeDebugSettings<T> : UnityEngine.Rendering.IVolumeDebugSettings
        {
            static /*0x0*/ System.Collections.Generic.List<System.Type> s_ComponentTypes;
            static /*0x0*/ System.Collections.Generic.List<T> <additionalCameraDatas>k__BackingField;
            /*0x0*/ int <selectedComponent>k__BackingField;
            /*0x0*/ int m_SelectedCameraIndex;
            /*0x0*/ UnityEngine.Camera[] m_CamerasArray;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;
            /*0x0*/ System.Type <targetRenderPipeline>k__BackingField;
            /*0x0*/ float[] weights;
            /*0x0*/ UnityEngine.Rendering.Volume[] volumes;
            /*0x0*/ UnityEngine.Rendering.VolumeParameter[,] savedStates;

            static /*0x383e7a0*/ VolumeDebugSettings();
            static /*0x3836db8*/ System.Collections.Generic.List<System.Type> get_componentTypes();
            static /*0x38379c4*/ string ComponentDisplayName(System.Type component);
            static /*0x3836db8*/ System.Collections.Generic.List<T> get_additionalCameraDatas();
            static /*0x3840c74*/ void set_additionalCameraDatas(System.Collections.Generic.List<T> value);
            static /*0x3910ae8*/ void RegisterCamera(T additionalCamera);
            static /*0x3910ae8*/ void UnRegisterCamera(T additionalCamera);
            /*0x38159dc*/ VolumeDebugSettings();
            /*0x3814574*/ int get_selectedComponent();
            /*0x3815ed0*/ void set_selectedComponent(int value);
            /*0x38148bc*/ UnityEngine.Camera get_selectedCamera();
            /*0x3814574*/ int get_selectedCameraIndex();
            /*0x3815ed0*/ void set_selectedCameraIndex(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x38148bc*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x38159a4*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x38148bc*/ System.Type get_selectedComponentType();
            /*0x3816710*/ void set_selectedComponentType(System.Type value);
            /*0x38148bc*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
            /*0x38148bc*/ System.Type get_targetRenderPipeline();
            /*0x3814b90*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.VolumeComponent component, System.Reflection.FieldInfo field);
            /*0x3814a3c*/ UnityEngine.Rendering.VolumeParameter GetParameter(System.Reflection.FieldInfo field);
            /*0x3814b90*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.Volume volume, System.Reflection.FieldInfo field);
            /*0x3815270*/ float ComputeWeight(UnityEngine.Rendering.Volume volume, UnityEngine.Vector3 triggerPos);
            /*0x38148bc*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x38148bc*/ UnityEngine.Rendering.VolumeParameter[,] GetStates();
            /*0x38141c4*/ bool ChangedStates(UnityEngine.Rendering.VolumeParameter[,] newStates);
            /*0x38141c4*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
            /*0x38141c4*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeDebugSettings.<>c<T> <>9;
                static /*0x0*/ System.Func<UnityEngine.Rendering.Volume, bool> <>9__34_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__36_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_1;
                static /*0x0*/ System.Func<System.Type, string> <>9__43_2;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x38141c4*/ bool <GetVolumes>b__34_0(UnityEngine.Rendering.Volume v);
                /*0x38141c4*/ bool <GetStates>b__36_0(System.Reflection.FieldInfo t);
                /*0x38141c4*/ bool <get_componentTypes>b__43_0(System.Type t);
                /*0x38141c4*/ bool <get_componentTypes>b__43_1(System.Type t);
                /*0x3814a3c*/ string <get_componentTypes>b__43_2(System.Type t);
            }

            class <>c__DisplayClass22_0<T>
            {
                /*0x0*/ System.Type value;

                /*0x38159dc*/ <>c__DisplayClass22_0();
                bool <set_selectedComponentType>b__0(System.ValueTuple<string, System.Type> t);
            }
        }

        interface IShaderVariantSettings
        {
            /*0x3814574*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x3815ed0*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x3813ffc*/ bool get_exportShaderVariants();
            /*0x3815cc4*/ void set_exportShaderVariants(bool value);
            /*0x7b51a78*/ bool get_stripDebugVariants();
            /*0x7b51a80*/ void set_stripDebugVariants(bool value);
        }

        class ProbeTouchupVolume : UnityEngine.Rendering.ProbeAdjustmentVolume
        {
            /*0x7b51a84*/ ProbeTouchupVolume();
        }

        class VolumeManager
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerUpdate;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerReplaceData;
            static /*0x10*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerEvaluateVolumeDefaultState;
            static /*0x18*/ System.Lazy<UnityEngine.Rendering.VolumeManager> s_Instance;
            static /*0x20*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.ValueTuple<string, System.Type>>> s_SupportedVolumeComponentsForRenderPipeline;
            /*0x10*/ UnityEngine.Rendering.VolumeStack <stack>k__BackingField;
            /*0x18*/ System.Type[] <baseComponentTypeArray>k__BackingField;
            /*0x20*/ UnityEngine.Rendering.VolumeProfile <globalDefaultProfile>k__BackingField;
            /*0x28*/ UnityEngine.Rendering.VolumeProfile <qualityDefaultProfile>k__BackingField;
            /*0x30*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> <customDefaultProfiles>k__BackingField;
            /*0x38*/ UnityEngine.Rendering.VolumeCollection m_VolumeCollection;
            /*0x40*/ UnityEngine.Rendering.VolumeComponent[] m_ComponentsDefaultState;
            /*0x48*/ UnityEngine.Rendering.VolumeParameter[] m_ParametersDefaultState;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;
            /*0x58*/ UnityEngine.Rendering.VolumeStack m_DefaultStack;
            /*0x60*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeStack> m_CreatedVolumeStacks;
            /*0x68*/ bool <isInitialized>k__BackingField;

            static /*0x7b55010*/ VolumeManager();
            static /*0x7b3f150*/ UnityEngine.Rendering.VolumeManager get_instance();
            static /*0x7b55008*/ bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera);
            static /*0x7b540e4*/ void <EvaluateVolumeDefaultState>g__ApplyDefaultProfile|58_0(UnityEngine.Rendering.VolumeProfile profile, ref UnityEngine.Rendering.VolumeManager.<> );
            /*0x7b52ac8*/ VolumeManager();
            /*0x7b51a8c*/ void Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b51d60*/ void Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b52034*/ UnityEngine.Rendering.VolumeStack get_stack();
            /*0x7b5203c*/ void set_stack(UnityEngine.Rendering.VolumeStack value);
            /*0x7b52044*/ System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes();
            /*0x7b3f1c8*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> GetVolumeComponentsForDisplay(System.Type currentPipelineAssetType);
            /*0x7b525b0*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> BuildVolumeComponentDisplayList(System.Type[] types);
            /*0x7b5296c*/ System.Type[] get_baseComponentTypeArray();
            /*0x7b52974*/ void set_baseComponentTypeArray(System.Type[] value);
            /*0x7b5297c*/ UnityEngine.Rendering.VolumeProfile get_globalDefaultProfile();
            /*0x7b52984*/ void set_globalDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7b5298c*/ UnityEngine.Rendering.VolumeProfile get_qualityDefaultProfile();
            /*0x7b52994*/ void set_qualityDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7b5299c*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> get_customDefaultProfiles();
            /*0x7b529a4*/ void set_customDefaultProfiles(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> value);
            /*0x7b529ac*/ UnityEngine.Rendering.VolumeComponent GetVolumeComponentDefaultState(System.Type volumeComponentType);
            /*0x7b52be0*/ bool get_isInitialized();
            /*0x7b52be8*/ void set_isInitialized(bool value);
            /*0x7b52bf4*/ void Initialize(UnityEngine.Rendering.VolumeProfile globalDefaultVolumeProfile, UnityEngine.Rendering.VolumeProfile qualityDefaultVolumeProfile);
            /*0x7b53710*/ void Deinitialize();
            /*0x7b53960*/ void SetGlobalDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b5397c*/ void SetQualityDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b53998*/ void SetCustomDefaultProfiles(System.Collections.Generic.List<UnityEngine.Rendering.VolumeProfile> profiles);
            /*0x7b53b34*/ void OnVolumeProfileChanged(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b53c18*/ void OnVolumeComponentChanged(UnityEngine.Rendering.VolumeComponent component);
            /*0x7b53628*/ UnityEngine.Rendering.VolumeStack CreateStack();
            /*0x7b53ec4*/ void ResetMainStack();
            /*0x7b538f8*/ void DestroyStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b53ed0*/ bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(System.Type t, System.Type pipelineAssetType);
            /*0x7b5204c*/ void LoadBaseTypes(System.Type pipelineAssetType);
            /*0x7b52ccc*/ void InitializeVolumeComponents();
            /*0x7b52d94*/ void EvaluateVolumeDefaultState();
            /*0x7b51d10*/ void Register(UnityEngine.Rendering.Volume volume);
            /*0x7b51fe4*/ void Unregister(UnityEngine.Rendering.Volume volume);
            /*0x3910ae8*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
            /*0x7b542d0*/ void SetLayerDirty(int layer);
            /*0x7b542ec*/ void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer);
            /*0x7b54308*/ void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, float interpFactor);
            /*0x7b54438*/ void ReplaceData(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b54624*/ void CheckDefaultVolumeState();
            /*0x7b546b4*/ void CheckStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b548ac*/ bool CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b548fc*/ void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x7b54910*/ void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x7b54ecc*/ UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask);
            /*0x7b54eac*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeManager.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<string, System.Type>, string> <>9__16_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.VolumeProfile> <>9__49_0;
                static /*0x18*/ System.Predicate<UnityEngine.Rendering.Volume> <>9__71_0;

                static /*0x7b69ca4*/ <>c();
                /*0x7b69d0c*/ <>c();
                /*0x7b69d14*/ string <BuildVolumeComponentDisplayList>b__16_0(System.ValueTuple<string, System.Type> i);
                /*0x7b69d1c*/ bool <SetCustomDefaultProfiles>b__49_0(UnityEngine.Rendering.VolumeProfile x);
                /*0x7b69d78*/ bool <GetVolumes>b__71_0(UnityEngine.Rendering.Volume v);
                /*0x7b69dd4*/ UnityEngine.Rendering.VolumeManager <.cctor>b__74_0();
            }

            struct <>c__DisplayClass58_0
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentsDefaultStateList;
            }

            class <>c__DisplayClass58_1
            {
                /*0x10*/ UnityEngine.Rendering.VolumeComponent profileComponent;

                /*0x7b69e28*/ <>c__DisplayClass58_1();
                /*0x7b69e30*/ bool <EvaluateVolumeDefaultState>b__1(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class CoreRPHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x7b69ea0*/ CoreRPHelpURLAttribute(string pageName, string packageName);
            /*0x7b6a09c*/ CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName);
        }

        class CurrentPipelineHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x28*/ string <pageName>k__BackingField;

            /*0x7b6a0c8*/ CurrentPipelineHelpURLAttribute(string pageName);
            /*0x7b6a0c0*/ string get_pageName();
            /*0x7b6a0fc*/ string get_URL();
        }

        class DocumentationInfo
        {
            static string fallbackVersion = "13.1";
            static string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html#{3}";

            static /*0x7b6a114*/ string get_version();
            static /*0x7b6a154*/ string GetPackageLink(string packageName, string packageVersion, string pageName);
            static /*0x7b6a2d4*/ string GetPageLink(string packageName, string pageName);
            static /*0x7b69f0c*/ string GetPageLink(string packageName, string pageName, string pageHash);
            /*0x7b6a47c*/ DocumentationInfo();
        }

        class DocumentationUtils
        {
            static /*0x3910ae8*/ string GetHelpURL<TEnum>(TEnum mask);
            static /*0x7b6a484*/ bool TryGetHelpURL(System.Type type, ref string url);
        }

        interface IProbeVolumeEnabledRenderPipeline
        {
            /*0x3813ffc*/ bool get_supportProbeVolume();
            /*0x3814574*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
            /*0x38148bc*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
        }

        class ProbeAdjustmentVolume : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x20*/ UnityEngine.Rendering.ProbeAdjustmentVolume.Shape shape;
            /*0x24*/ UnityEngine.Vector3 size;
            /*0x30*/ float radius;
            /*0x34*/ UnityEngine.Rendering.ProbeAdjustmentVolume.Mode mode;
            /*0x38*/ float intensityScale;
            /*0x3c*/ float overriddenDilationThreshold;
            /*0x40*/ UnityEngine.Vector3 virtualOffsetRotation;
            /*0x4c*/ float virtualOffsetDistance;
            /*0x50*/ float geometryBias;
            /*0x54*/ float virtualOffsetThreshold;
            /*0x58*/ float rayOriginBias;
            /*0x5c*/ UnityEngine.Vector3 skyDirection;
            /*0x68*/ UnityEngine.Vector3 skyShadingDirectionRotation;
            /*0x74*/ int directSampleCount;
            /*0x78*/ int indirectSampleCount;
            /*0x7c*/ int sampleCountMultiplier;
            /*0x80*/ int maxBounces;
            /*0x84*/ int skyOcclusionSampleCount;
            /*0x88*/ int skyOcclusionMaxBounces;
            /*0x8c*/ UnityEngine.Rendering.ProbeAdjustmentVolume.RenderingLayerMaskOperation renderingLayerMaskOperation;
            /*0x90*/ byte renderingLayerMask;
            /*0x94*/ UnityEngine.Rendering.ProbeAdjustmentVolume.Version version;
            /*0x98*/ bool invalidateProbes;
            /*0x99*/ bool overrideDilationThreshold;

            /*0x7b6a57c*/ ProbeAdjustmentVolume();
            /*0x7b6a518*/ void Awake();
            /*0x7b6a550*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7b6a568*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

            enum Shape
            {
                Box = 0,
                Sphere = 1,
            }

            enum Mode
            {
                InvalidateProbes = 0,
                OverrideValidityThreshold = 1,
                ApplyVirtualOffset = 2,
                OverrideVirtualOffsetSettings = 3,
                OverrideSkyDirection = 4,
                OverrideSampleCount = 5,
                OverrideRenderingLayerMask = 6,
                IntensityScale = 99,
            }

            enum RenderingLayerMaskOperation
            {
                Override = 0,
                Add = 1,
                Remove = 2,
            }

            enum Version
            {
                Initial = 0,
                Mode = 1,
                Count = 2,
            }
        }

        class ProbeBrickIndex
        {
            static int kMaxSubdivisionLevels = 7;
            static int kIndexChunkSize = 243;
            static int kFailChunkIndex = -1;
            static int kEmptyIndex = -2;
            /*0x10*/ System.Collections.BitArray m_IndexChunks;
            /*0x18*/ System.Collections.BitArray m_IndexChunksCopyForChecks;
            /*0x20*/ int m_ChunksCount;
            /*0x24*/ int m_AvailableChunkCount;
            /*0x28*/ UnityEngine.ComputeBuffer m_PhysicalIndexBuffer;
            /*0x30*/ Unity.Collections.NativeArray<int> m_PhysicalIndexBufferData;
            /*0x40*/ UnityEngine.ComputeBuffer m_DebugFragmentationBuffer;
            /*0x48*/ int[] m_DebugFragmentationData;
            /*0x50*/ bool m_NeedUpdateIndexComputeBuffer;
            /*0x54*/ int m_UpdateMinIndex;
            /*0x58*/ int m_UpdateMaxIndex;
            /*0x5c*/ int <estimatedVMemCost>k__BackingField;
            /*0x60*/ float <fragmentationRate>k__BackingField;
            /*0x64*/ UnityEngine.Vector3Int m_CenterRS;

            static /*0x7b6b2b8*/ bool BrickOverlapEntry(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, UnityEngine.Vector3Int entryMin, UnityEngine.Vector3Int entryMax);
            static /*0x7b6b304*/ int LocationToIndex(int x, int y, int z, UnityEngine.Vector3Int sizeOfValid);
            /*0x7b6a6b4*/ ProbeBrickIndex(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x7b6a644*/ int get_estimatedVMemCost();
            /*0x7b6a64c*/ void set_estimatedVMemCost(int value);
            /*0x7b6a654*/ UnityEngine.ComputeBuffer GetDebugFragmentationBuffer();
            /*0x7b6a65c*/ float get_fragmentationRate();
            /*0x7b6a664*/ void set_fragmentationRate(float value);
            /*0x7b6a66c*/ int SizeOfPhysicalIndexFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x7b6a974*/ int GetRemainingChunkCount();
            /*0x7b6a97c*/ void UploadIndexData();
            /*0x7b6a9f4*/ void UpdateDebugData();
            /*0x7b6a8dc*/ void Clear();
            /*0x7b6ab8c*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b6ac78*/ void Cleanup();
            /*0x7b6ad2c*/ void ComputeFragmentationRate();
            /*0x7b6ad94*/ int MergeIndex(int index, int size);
            /*0x7b6ada0*/ int GetNumberOfChunks(int brickCount);
            /*0x7b6ae1c*/ bool FindSlotsForEntries(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo);
            /*0x7b6b184*/ bool ReserveChunks(UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog);
            /*0x7b6b314*/ void MarkBrickInPhysicalBuffer(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo entry, UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx);
            /*0x7b6b6b8*/ void AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight);
            /*0x7b6ba6c*/ void RemoveBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);

            struct Brick : System.IEquatable<UnityEngine.Rendering.ProbeBrickIndex.Brick>
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int subdivisionLevel;

                /*0x7b6bb30*/ Brick(UnityEngine.Vector3Int position, int subdivisionLevel);
                /*0x7b6bb3c*/ bool Equals(UnityEngine.Rendering.ProbeBrickIndex.Brick other);
                /*0x7b6bb88*/ bool IntersectArea(UnityEngine.Bounds boundInBricksToCheck);
            }

            struct IndirectionEntryUpdateInfo
            {
                /*0x10*/ int firstChunkIndex;
                /*0x14*/ int numberOfChunks;
                /*0x18*/ int minSubdivInCell;
                /*0x1c*/ UnityEngine.Vector3Int minValidBrickIndexForCellAtMaxRes;
                /*0x28*/ UnityEngine.Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;
                /*0x34*/ UnityEngine.Vector3Int entryPositionInBricksAtMaxRes;
                /*0x40*/ bool hasOnlyBiggerBricks;
            }

            struct CellIndexUpdateInfo
            {
                /*0x10*/ UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo;

                /*0x7b6bd24*/ int GetNumberOfChunks();
            }
        }

        class ProbeBrickPool
        {
            static int kChunkSizeInBricks = 128;
            static int kBrickCellCount = 3;
            static int kBrickProbeCountPerDim = 4;
            static int kBrickProbeCountTotal = 64;
            static int kChunkProbeCountPerDim = 512;
            static int kMaxPoolWidth = 2048;
            static /*0x0*/ int _Out_L0_L1Rx;
            static /*0x4*/ int _Out_L1G_L1Ry;
            static /*0x8*/ int _Out_L1B_L1Rz;
            static /*0xc*/ int _Out_Shared;
            static /*0x10*/ int _Out_ProbeOcclusion;
            static /*0x14*/ int _Out_SkyOcclusionL0L1;
            static /*0x18*/ int _Out_SkyShadingDirectionIndices;
            static /*0x1c*/ int _Out_L2_0;
            static /*0x20*/ int _Out_L2_1;
            static /*0x24*/ int _Out_L2_2;
            static /*0x28*/ int _Out_L2_3;
            static /*0x2c*/ int _ProbeVolumeScratchBufferLayout;
            static /*0x30*/ int _ProbeVolumeScratchBuffer;
            static /*0x38*/ UnityEngine.ComputeShader s_DataUploadCS;
            static /*0x40*/ int s_DataUploadKernel;
            static /*0x48*/ UnityEngine.ComputeShader s_DataUploadL2CS;
            static /*0x50*/ int s_DataUploadL2Kernel;
            static /*0x58*/ UnityEngine.Rendering.LocalKeyword s_DataUpload_Shared;
            static /*0x70*/ UnityEngine.Rendering.LocalKeyword s_DataUpload_ProbeOcclusion;
            static /*0x88*/ UnityEngine.Rendering.LocalKeyword s_DataUpload_SkyOcclusion;
            static /*0xa0*/ UnityEngine.Rendering.LocalKeyword s_DataUpload_SkyShadingDirection;
            /*0x10*/ int <estimatedVMemCost>k__BackingField;
            /*0x18*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation m_Pool;
            /*0x80*/ UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk;
            /*0x90*/ System.Collections.Generic.Stack<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> m_FreeList;
            /*0x98*/ int m_AvailableChunkCount;
            /*0x9c*/ UnityEngine.Rendering.ProbeVolumeSHBands m_SHBands;
            /*0xa0*/ bool m_ContainsValidity;
            /*0xa1*/ bool m_ContainsProbeOcclusion;
            /*0xa2*/ bool m_ContainsRenderingLayers;
            /*0xa3*/ bool m_ContainsSkyOcclusion;
            /*0xa4*/ bool m_ContainsSkyShadingDirection;

            static /*0x7b6ec58*/ ProbeBrickPool();
            static /*0x7b6bd7c*/ int DivRoundUp(int x, int y);
            static /*0x7b6bd9c*/ void Initialize();
            static /*0x7b6ce9c*/ int GetChunkSizeInBrickCount();
            static /*0x7b6cea4*/ int GetChunkSizeInProbeCount();
            static /*0x7b6d50c*/ int GetChunkCount(int brickCount);
            static /*0x7b6e840*/ UnityEngine.Vector3Int ProbeCountToDataLocSize(int numProbes);
            static /*0x7b6e8bc*/ int EstimateMemoryCost(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x7b6e8e4*/ int EstimateMemoryCostForBlending(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            static /*0x7b6ea24*/ UnityEngine.Texture CreateDataTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes);
            static /*0x7b6c4e4*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, ref int allocatedBytes);
            static /*0x7b6c39c*/ void DerivePoolSizeFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, ref int width, ref int height, ref int depth);
            /*0x7b6c228*/ ProbeBrickPool(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool allocateValidityData, bool allocateRenderingLayerData, bool allocateSkyOcclusion, bool allocateSkyShadingData, bool allocateProbeOcclusionData);
            /*0x7b6bd8c*/ int get_estimatedVMemCost();
            /*0x7b6bd94*/ void set_estimatedVMemCost(int value);
            /*0x7b6c208*/ UnityEngine.Texture GetValidityTexture();
            /*0x7b6c210*/ UnityEngine.Texture GetSkyOcclusionTexture();
            /*0x7b6c218*/ UnityEngine.Texture GetSkyShadingDirectionIndicesTexture();
            /*0x7b6c220*/ UnityEngine.Texture GetProbeOcclusionTexture();
            /*0x7b6c3b0*/ void AllocatePool(int width, int height, int depth);
            /*0x7b6cb9c*/ int GetRemainingChunkCount();
            /*0x7b6cba4*/ void EnsureTextureValidity();
            /*0x7b6ce08*/ bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion);
            /*0x7b6ceac*/ int GetPoolWidth();
            /*0x7b6ceb4*/ int GetPoolHeight();
            /*0x7b6cebc*/ UnityEngine.Vector3Int GetPoolDimensions();
            /*0x7b6cec8*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b6d4b0*/ void Clear();
            /*0x7b6d524*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog);
            /*0x7b6d794*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x7b6d91c*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            /*0x7b6ddbc*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, bool updateSharedData, UnityEngine.Texture validityTexture, UnityEngine.Rendering.ProbeVolumeSHBands bands, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x7b6e6ac*/ void UpdateValidity(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex);
            /*0x7b6ec50*/ void Cleanup();

            struct BrickChunkAlloc
            {
                /*0x10*/ int x;
                /*0x14*/ int y;
                /*0x18*/ int z;

                /*0x7b6ba58*/ int flattenIndex(int sx, int sy);
            }

            struct DataLocation
            {
                /*0x10*/ UnityEngine.Texture TexL0_L1rx;
                /*0x18*/ UnityEngine.Texture TexL1_G_ry;
                /*0x20*/ UnityEngine.Texture TexL1_B_rz;
                /*0x28*/ UnityEngine.Texture TexL2_0;
                /*0x30*/ UnityEngine.Texture TexL2_1;
                /*0x38*/ UnityEngine.Texture TexL2_2;
                /*0x40*/ UnityEngine.Texture TexL2_3;
                /*0x48*/ UnityEngine.Texture TexProbeOcclusion;
                /*0x50*/ UnityEngine.Texture TexValidity;
                /*0x58*/ UnityEngine.Texture TexSkyOcclusion;
                /*0x60*/ UnityEngine.Texture TexSkyShadingDirectionIndices;
                /*0x68*/ int width;
                /*0x6c*/ int height;
                /*0x70*/ int depth;

                /*0x7b6cc3c*/ void Cleanup();
            }
        }

        class ProbeBrickBlendingPool
        {
            static /*0x0*/ UnityEngine.ComputeShader stateBlendShader;
            static /*0x8*/ int scenarioBlendingKernel;
            static /*0xc*/ int _PoolDim_LerpFactor;
            static /*0x10*/ int _ChunkList;
            static /*0x14*/ int _State0_L0_L1Rx;
            static /*0x18*/ int _State0_L1G_L1Ry;
            static /*0x1c*/ int _State0_L1B_L1Rz;
            static /*0x20*/ int _State0_L2_0;
            static /*0x24*/ int _State0_L2_1;
            static /*0x28*/ int _State0_L2_2;
            static /*0x2c*/ int _State0_L2_3;
            static /*0x30*/ int _State0_ProbeOcclusion;
            static /*0x34*/ int _State1_L0_L1Rx;
            static /*0x38*/ int _State1_L1G_L1Ry;
            static /*0x3c*/ int _State1_L1B_L1Rz;
            static /*0x40*/ int _State1_L2_0;
            static /*0x44*/ int _State1_L2_1;
            static /*0x48*/ int _State1_L2_2;
            static /*0x4c*/ int _State1_L2_3;
            static /*0x50*/ int _State1_ProbeOcclusion;
            /*0x10*/ UnityEngine.Vector4[] m_ChunkList;
            /*0x18*/ int m_MappedChunks;
            /*0x20*/ UnityEngine.Rendering.ProbeBrickPool m_State0;
            /*0x28*/ UnityEngine.Rendering.ProbeBrickPool m_State1;
            /*0x30*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
            /*0x34*/ UnityEngine.Rendering.ProbeVolumeSHBands m_ShBands;
            /*0x38*/ bool m_ProbeOcclusion;

            static /*0x7b70214*/ ProbeBrickBlendingPool();
            static /*0x7b6eef0*/ void Initialize();
            /*0x7b6f1c4*/ ProbeBrickBlendingPool(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool probeOcclusion);
            /*0x7b6f060*/ bool get_isAllocated();
            /*0x7b6f070*/ int get_estimatedVMemCost();
            /*0x7b6f170*/ int GetPoolWidth();
            /*0x7b6f18c*/ int GetPoolHeight();
            /*0x7b6f1a8*/ int GetPoolDepth();
            /*0x7b6f200*/ void AllocateResourcesIfNeeded();
            /*0x7b6f368*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state);
            /*0x7b6f3f8*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state, UnityEngine.Texture validityTexture, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x7b6f4e8*/ void PerformBlending(UnityEngine.Rendering.CommandBuffer cmd, float factor, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x7b6ffc0*/ void BlendChunks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x7b700e0*/ void Clear();
            /*0x7b700f0*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations);
            /*0x7b70148*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x7b701ac*/ void EnsureTextureValidity();
            /*0x7b701dc*/ void Cleanup();
        }

        class ProbeGlobalIndirection
        {
            static int kUintPerEntry = 3;
            static int kEntryMaxSubdivLevel = 3;
            /*0x10*/ int <estimatedVMemCost>k__BackingField;
            /*0x18*/ UnityEngine.ComputeBuffer m_IndexOfIndicesBuffer;
            /*0x20*/ uint[] m_IndexOfIndicesData;
            /*0x28*/ int m_CellSizeInMinBricks;
            /*0x2c*/ UnityEngine.Vector3Int m_EntriesCount;
            /*0x38*/ UnityEngine.Vector3Int m_EntryMin;
            /*0x44*/ UnityEngine.Vector3Int m_EntryMax;
            /*0x50*/ bool m_NeedUpdateComputeBuffer;

            /*0x7b70634*/ ProbeGlobalIndirection(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, int cellSizeInMinBricks);
            /*0x7b70598*/ int get_estimatedVMemCost();
            /*0x7b705a0*/ void set_estimatedVMemCost(int value);
            /*0x7b705a8*/ void GetMinMaxEntry(ref UnityEngine.Vector3Int minEntry, ref UnityEngine.Vector3Int maxEntry);
            /*0x7b705cc*/ UnityEngine.Vector3Int GetGlobalIndirectionDimension();
            /*0x7b705dc*/ UnityEngine.Vector3Int GetGlobalIndirectionMinEntry();
            /*0x7b705ec*/ int get_entrySizeInBricks();
            /*0x7b70600*/ int get_entriesPerCellDimension();
            /*0x7b70620*/ int GetFlatIndex(UnityEngine.Vector3Int normalizedPos);
            /*0x7b70828*/ int GetFlatIdxForEntry(UnityEngine.Vector3Int entryPosition);
            /*0x7b70854*/ int[] GetFlatIndicesForCell(UnityEngine.Vector3Int cellPosition);
            /*0x7b70990*/ void UpdateCell(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);
            /*0x7b70d40*/ void MarkEntriesAsUnloaded(int[] entriesFlatIndices);
            /*0x7b70dc8*/ void PushComputeData();
            /*0x7b70df4*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b70e2c*/ void Cleanup();

            struct IndexMetaData
            {
                static /*0x0*/ uint[] s_PackedValues;
                /*0x10*/ UnityEngine.Vector3Int minLocalIdx;
                /*0x1c*/ UnityEngine.Vector3Int maxLocalIdxPlusOne;
                /*0x28*/ int firstChunkIndex;
                /*0x2c*/ int minSubdiv;

                static /*0x7b70e98*/ IndexMetaData();
                /*0x7b70c14*/ void Pack(ref uint[] vals);
            }
        }

        class ProbeReferenceVolume
        {
            static int kProbesPerBatch = 511;
            static int kMaxCellLoadedPerFrame = 10;
            static float kIndexFragmentationThreshold = 0.20000000298023224;
            static /*0x0*/ string defaultLightingScenario;
            static /*0x8*/ UnityEngine.Rendering.ProbeReferenceVolume _instance;
            static /*0x10*/ string k_DebugPanelName;
            static /*0x18*/ UnityEngine.Rendering.ProbeSamplingDebugData probeSamplingDebugData;
            static /*0x20*/ UnityEngine.Vector4[] s_BoundsArray;
            static /*0x28*/ UnityEngine.Rendering.DynamicArray.SortComparer<UnityEngine.Rendering.ProbeReferenceVolume.Cell> s_BlendingComparer;
            static /*0x30*/ UnityEngine.Rendering.DynamicArray.SortComparer<UnityEngine.Rendering.ProbeReferenceVolume.Cell> s_DefragComparer;
            /*0x10*/ UnityEngine.ComputeBuffer m_EmptyIndexBuffer;
            /*0x18*/ bool m_IsInitialized;
            /*0x19*/ bool m_SupportScenarios;
            /*0x1a*/ bool m_SupportScenarioBlending;
            /*0x1b*/ bool m_ForceNoDiskStreaming;
            /*0x1c*/ bool m_SupportDiskStreaming;
            /*0x1d*/ bool m_SupportGPUStreaming;
            /*0x1e*/ bool m_UseStreamingAssets;
            /*0x20*/ float m_MinBrickSize;
            /*0x24*/ int m_MaxSubdivision;
            /*0x28*/ UnityEngine.Vector3 m_ProbeOffset;
            /*0x38*/ UnityEngine.Rendering.ProbeBrickPool m_Pool;
            /*0x40*/ UnityEngine.Rendering.ProbeBrickIndex m_Index;
            /*0x48*/ UnityEngine.Rendering.ProbeGlobalIndirection m_CellIndices;
            /*0x50*/ UnityEngine.Rendering.ProbeBrickBlendingPool m_BlendingPool;
            /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;
            /*0x60*/ float[] m_PositionOffsets;
            /*0x68*/ UnityEngine.Bounds m_CurrGlobalBounds;
            /*0x80*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells;
            /*0x88*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_CellPool;
            /*0x90*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation m_TemporaryDataLocation;
            /*0xf8*/ int m_TemporaryDataLocationMemCost;
            /*0x100*/ UnityEngine.Rendering.ProbeVolumeSceneData sceneData;
            /*0x108*/ UnityEngine.Vector3Int minLoadedCellPos;
            /*0x114*/ UnityEngine.Vector3Int maxLoadedCellPos;
            /*0x120*/ System.Action<UnityEngine.Rendering.ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction;
            /*0x128*/ System.Action checksDuringBakeAction;
            /*0x130*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<UnityEngine.Rendering.ProbeVolumeBakingSet, System.Collections.Generic.List<int>>> m_PendingScenesToBeLoaded;
            /*0x138*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> m_PendingScenesToBeUnloaded;
            /*0x140*/ System.Collections.Generic.List<string> m_ActiveScenes;
            /*0x148*/ UnityEngine.Rendering.ProbeVolumeBakingSet m_CurrentBakingSet;
            /*0x150*/ bool m_NeedLoadAsset;
            /*0x151*/ bool m_ProbeReferenceVolumeInit;
            /*0x152*/ bool m_EnabledBySRP;
            /*0x153*/ bool m_VertexSampling;
            /*0x154*/ bool m_NeedsIndexRebuild;
            /*0x155*/ bool m_HasChangedIndex;
            /*0x158*/ int m_CBShaderID;
            /*0x15c*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
            /*0x160*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;
            /*0x164*/ UnityEngine.Rendering.ProbeVolumeSHBands m_SHBands;
            /*0x168*/ bool clearAssetsOnVolumeClear;
            /*0x170*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> <perSceneDataList>k__BackingField;
            /*0x178*/ UnityEngine.Rendering.ProbeVolumeDebug <probeVolumeDebug>k__BackingField;
            /*0x180*/ UnityEngine.Color[] <subdivisionDebugColors>k__BackingField;
            /*0x188*/ UnityEngine.Mesh m_DebugMesh;
            /*0x190*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
            /*0x198*/ UnityEngine.Material m_DebugMaterial;
            /*0x1a0*/ UnityEngine.Mesh m_DebugProbeSamplingMesh;
            /*0x1a8*/ UnityEngine.Material m_ProbeSamplingDebugMaterial;
            /*0x1b0*/ UnityEngine.Material m_ProbeSamplingDebugMaterial02;
            /*0x1b8*/ UnityEngine.Texture m_DisplayNumbersTexture;
            /*0x1c0*/ UnityEngine.Mesh m_DebugOffsetMesh;
            /*0x1c8*/ UnityEngine.Material m_DebugOffsetMaterial;
            /*0x1d0*/ UnityEngine.Material m_DebugFragmentationMaterial;
            /*0x1d8*/ UnityEngine.Plane[] m_DebugFrustumPlanes;
            /*0x1e0*/ UnityEngine.GUIContent[] m_DebugScenarioNames;
            /*0x1e8*/ int[] m_DebugScenarioValues;
            /*0x1f0*/ string m_DebugActiveSceneGUID;
            /*0x1f8*/ string m_DebugActiveScenario;
            /*0x200*/ UnityEngine.Rendering.DebugUI.EnumField m_DebugScenarioField;
            /*0x208*/ System.Collections.Generic.Dictionary<UnityEngine.Bounds, UnityEngine.Rendering.ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;
            /*0x210*/ bool m_MaxSubdivVisualizedIsMaxAvailable;
            /*0x211*/ bool m_LoadMaxCellsPerFrame;
            /*0x214*/ int m_NumberOfCellsLoadedPerFrame;
            /*0x218*/ int m_NumberOfCellsBlendedPerFrame;
            /*0x21c*/ float m_TurnoverRate;
            /*0x220*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_LoadedCells;
            /*0x228*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_ToBeLoadedCells;
            /*0x230*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_WorseLoadedCells;
            /*0x238*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_BestToBeLoadedCells;
            /*0x240*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempCellToLoadList;
            /*0x248*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempCellToUnloadList;
            /*0x250*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_LoadedBlendingCells;
            /*0x258*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_ToBeLoadedBlendingCells;
            /*0x260*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempBlendingCellToLoadList;
            /*0x268*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempBlendingCellToUnloadList;
            /*0x270*/ UnityEngine.Vector3 m_FrozenCameraPosition;
            /*0x27c*/ UnityEngine.Vector3 m_FrozenCameraDirection;
            /*0x288*/ bool m_IndexDefragmentationInProgress;
            /*0x290*/ UnityEngine.Rendering.ProbeBrickIndex m_DefragIndex;
            /*0x298*/ UnityEngine.Rendering.ProbeGlobalIndirection m_DefragCellIndices;
            /*0x2a0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_IndexDefragCells;
            /*0x2a8*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempIndexDefragCells;
            /*0x2b0*/ float minStreamingScore;
            /*0x2b4*/ float maxStreamingScore;
            /*0x2b8*/ System.Collections.Generic.Queue<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_StreamingQueue;
            /*0x2c0*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_ActiveStreamingRequests;
            /*0x2c8*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_StreamingRequestsPool;
            /*0x2d0*/ bool m_DiskStreamingUseCompute;
            /*0x2d8*/ UnityEngine.Rendering.ProbeVolumeScratchBufferPool m_ScratchBufferPool;
            /*0x2e0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate m_OnStreamingComplete;
            /*0x2e8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate m_OnBlendingStreamingComplete;

            static /*0x7b6893c*/ ProbeReferenceVolume();
            static /*0x7b56908*/ string GetSceneGUID(UnityEngine.SceneManagement.Scene scene);
            static /*0x7b57964*/ UnityEngine.Rendering.ProbeReferenceVolume get_instance();
            static /*0x7b59c84*/ int GetNumberOfBricksAtSubdiv(UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo);
            static /*0x7b59c54*/ int CellSize(int subdivisionLevel);
            static /*0x7b63818*/ void UpdateDebugFromSelection(ref UnityEngine.Vector4[] _AdjustmentVolumeBounds, ref int _AdjustmentVolumeCount);
            static /*0x7b64f48*/ void ComputeCellStreamingScore(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            static /*0x7b67a14*/ int BlendingComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            static /*0x7b67a64*/ int DefragComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            /*0x7b5f100*/ ProbeReferenceVolume();
            /*0x7b55228*/ void BindAPVRuntimeResources(UnityEngine.Rendering.CommandBuffer cmdBuffer, bool isProbeVolumeEnabled);
            /*0x7b55e6c*/ bool UpdateShaderVariablesProbeVolumes(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumesOptions probeVolumeOptions, int taaFrameIndex, bool supportRenderingLayers);
            /*0x7b564d4*/ UnityEngine.Bounds get_globalBounds();
            /*0x7b564e8*/ void set_globalBounds(UnityEngine.Bounds value);
            /*0x7b564fc*/ bool get_isInitialized();
            /*0x7b56504*/ bool get_enabledBySRP();
            /*0x7b5650c*/ bool get_vertexSampling();
            /*0x7b56514*/ bool get_hasUnloadedCells();
            /*0x7b56564*/ bool get_supportLightingScenarios();
            /*0x7b5656c*/ bool get_supportScenarioBlending();
            /*0x7b56574*/ bool get_gpuStreamingEnabled();
            /*0x7b5657c*/ bool get_diskStreamingEnabled();
            /*0x7b5659c*/ bool get_probeOcclusion();
            /*0x7b560dc*/ bool get_skyOcclusion();
            /*0x7b56160*/ bool get_skyOcclusionShadingDirection();
            /*0x7b56620*/ bool get_useRenderingLayers();
            /*0x7b56644*/ UnityEngine.Rendering.ProbeVolumeSHBands get_shBands();
            /*0x7b5664c*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_currentBakingSet();
            /*0x7b56654*/ string get_lightingScenario();
            /*0x7b566d0*/ void set_lightingScenario(string value);
            /*0x7b56778*/ string get_otherScenario();
            /*0x7b567f4*/ float get_scenarioBlendingFactor();
            /*0x7b5686c*/ void set_scenarioBlendingFactor(float value);
            /*0x7b566d8*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x7b56960*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x7b56a0c*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget();
            /*0x7b56a14*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> get_perSceneDataList();
            /*0x7b56a1c*/ void set_perSceneDataList(System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> value);
            /*0x7b56a2c*/ void RegisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b56b24*/ void SetActiveScene(UnityEngine.SceneManagement.Scene scene);
            /*0x7b56dbc*/ void SetActiveBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b57140*/ void SetBakingSetAsCurrent(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b577fc*/ void RegisterBakingSet(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b57074*/ void UnloadBakingSet();
            /*0x7b578b0*/ void UnregisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b56bb8*/ bool TryGetPerSceneData(string sceneGUID, ref UnityEngine.Rendering.ProbeVolumePerSceneData perSceneData);
            /*0x7b57938*/ float get_indexFragmentationRate();
            /*0x7b579bc*/ void Initialize(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x7b57f7c*/ void SetEnableStateFromSRP(bool srpEnablesPV);
            /*0x7b57f88*/ void SetVertexSamplingEnabled(bool value);
            /*0x7b57f94*/ void ForceSHBand(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x7b58374*/ void ForceNoDiskStreaming(bool state);
            /*0x7b58380*/ void Cleanup();
            /*0x7b587fc*/ int GetVideoMemoryCost();
            /*0x7b58878*/ void RemoveCell(int cellIndex);
            /*0x7b589c4*/ void UnloadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b58b28*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b58e00*/ void UnloadAllCells();
            /*0x7b58edc*/ void UnloadAllBlendingCells();
            /*0x7b58fb8*/ void AddCell(int cellIndex);
            /*0x7b591e4*/ bool LoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, bool ignoreErrorLog);
            /*0x7b5a10c*/ void LoadAllCells();
            /*0x7b5a248*/ void ComputeCellGlobalInfo();
            /*0x7b5a458*/ void AddPendingSceneLoading(string sceneGUID, UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b5a8b0*/ void AddPendingSceneRemoval(string sceneGUID);
            /*0x7b5a9ec*/ void RemovePendingScene(string sceneGUID, System.Collections.Generic.List<int> cellList);
            /*0x7b5aba0*/ void PerformPendingIndexChangeAndInit();
            /*0x7b577c0*/ void SetSubdivisionDimensions(float minBrickSize, int maxSubdiv, UnityEngine.Vector3 offset);
            /*0x7b5af24*/ bool LoadCells(System.Collections.Generic.List<int> cellIndices);
            /*0x7b5afe8*/ void PerformPendingLoading();
            /*0x7b5b3f0*/ void PerformPendingDeletion();
            /*0x7b59870*/ void ComputeEntryMinMax(ref UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo, System.ReadOnlySpan<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks);
            /*0x7b57890*/ void PerformPendingOperations();
            /*0x7b5abd4*/ void InitializeGlobalIndirection();
            /*0x7b57254*/ void InitProbeReferenceVolume();
            /*0x7b55d10*/ UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources();
            /*0x7b5ae48*/ void SetMaxSubdivision(int maxSubdivision);
            /*0x7b5f9bc*/ float BrickSize(int subdivisionLevel);
            /*0x7b5fa54*/ float MinBrickSize();
            /*0x7b5fa5c*/ float MaxBrickSize();
            /*0x7b5fa68*/ UnityEngine.Vector3 ProbeOffset();
            /*0x7b5fa74*/ int GetMaxSubdivision();
            /*0x7b5fa7c*/ int GetMaxSubdivision(float multiplier);
            /*0x7b5fafc*/ float GetDistanceBetweenProbes(int subdivisionLevel);
            /*0x7b5fb14*/ float MinDistanceBetweenProbes();
            /*0x7b5fb30*/ int GetGlobalIndirectionEntryMaxSubdiv();
            /*0x7b59c3c*/ int GetEntrySubdivLevel();
            /*0x7b5fb38*/ float GetEntrySize();
            /*0x7b5608c*/ bool DataHasBeenLoaded();
            /*0x7b5fb50*/ void Clear();
            /*0x7b5fc68*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, UnityEngine.Rendering.ProbeBrickPool.DataLocation dataLoc);
            /*0x3910ae8*/ void UpdateDataLocationTexture<T>(UnityEngine.Texture output, Unity.Collections.NativeArray<T> input);
            /*0x7b5fdf4*/ void UpdateValidityTextureWithoutMask(UnityEngine.Texture output, Unity.Collections.NativeArray<byte> input);
            /*0x7b5ff88*/ void UpdatePool(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionL0L1Data, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex, int poolIndex);
            /*0x7b604cc*/ void UpdatePool(UnityEngine.Rendering.CommandBuffer cmd, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex);
            /*0x7b606e8*/ void UpdateSharedData(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionData, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex);
            /*0x7b609c8*/ bool AddBlendingBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b597c0*/ bool ReservePoolChunks(int brickCount, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, bool ignoreErrorLog);
            /*0x7b59fa4*/ void ReleasePoolChunks(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList);
            /*0x7b61244*/ void UpdatePoolAndIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b59d4c*/ bool AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b61128*/ void UpdateCellIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b58c58*/ void ReleaseBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b561e4*/ void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumeShadingParameters parameters);
            /*0x7b580f8*/ void DeinitProbeReferenceVolume();
            /*0x7b584a4*/ void CleanupLoadedData();
            /*0x7b61704*/ UnityEngine.Rendering.ProbeVolumeDebug get_probeVolumeDebug();
            /*0x7b6170c*/ UnityEngine.Color[] get_subdivisionDebugColors();
            /*0x7b61714*/ UnityEngine.Mesh get_debugMesh();
            /*0x7b61888*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x7b61894*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options, UnityEngine.Texture exposureTexture);
            /*0x7b62a94*/ bool IsProbeSamplingDebugEnabled();
            /*0x7b62b00*/ bool GetProbeSamplingDebugResources(UnityEngine.Camera camera, ref UnityEngine.GraphicsBuffer resultBuffer, ref UnityEngine.Vector2 coords);
            /*0x7b62c2c*/ bool TryCreateDebugRenderData();
            /*0x7b57e94*/ void InitializeDebug();
            /*0x7b584a8*/ void CleanupDebug();
            /*0x3910ae8*/ void DebugCellIndexChanged<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x7b5b674*/ void RegisterDebug();
            /*0x7b5b578*/ void UnregisterDebug(bool destroyPanel);
            /*0x7b6321c*/ void RenderFragmentationOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer, UnityEngine.Rendering.DebugOverlay debugOverlay);
            /*0x7b63530*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes);
            /*0x7b636d8*/ UnityEngine.Bounds GetCellBounds(UnityEngine.Vector3 cellPosition);
            /*0x7b63844*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Vector4[] adjustmentVolumeBounds, int adjustmentVolumeCount);
            /*0x7b61998*/ void DrawProbeDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x7b648f0*/ void ResetDebugViewToMaxSubdiv();
            /*0x7b58d64*/ void ClearDebugData();
            /*0x7b63b0c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b64a24*/ void OnClearLightingdata();
            /*0x7b64a28*/ void EnableMaxCellStreaming(bool value);
            /*0x7b64a34*/ void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
            /*0x7b64a50*/ bool get_loadMaxCellsPerFrame();
            /*0x7b64a58*/ void set_loadMaxCellsPerFrame(bool value);
            /*0x7b64a64*/ int get_numberOfCellsLoadedPerFrame();
            /*0x7b64acc*/ int get_numberOfCellsBlendedPerFrame();
            /*0x7b64ad4*/ void set_numberOfCellsBlendedPerFrame(int value);
            /*0x7b64ae4*/ float get_turnoverRate();
            /*0x7b64aec*/ void set_turnoverRate(float value);
            /*0x7b57eb8*/ void InitStreaming();
            /*0x7b585a4*/ void CleanupStreaming();
            /*0x7b64ea0*/ void ScenarioBlendingChanged(bool scenarioChanged);
            /*0x7b6513c*/ void ComputeStreamingScore(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells);
            /*0x7b65244*/ void ComputeBestToBeLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x7b65590*/ void ComputeStreamingScoreAndWorseLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x7b65944*/ void ComputeBlendingScore(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells, float worstScore);
            /*0x7b65a34*/ bool TryLoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, ref int shBudget, ref int indexBudget, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x7b65b3c*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> unloadedCells);
            /*0x7b65bb4*/ bool TryLoadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x7b65c68*/ void ComputeMinMaxStreamingScore();
            /*0x7b65dc4*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
            /*0x7b65dcc*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options);
            /*0x7b67900*/ int FindWorstBlendingCellToBeLoaded();
            /*0x7b6730c*/ void UpdateBlendingCellStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b5a008*/ void StartIndexDefragmentation();
            /*0x7b66a18*/ void UpdateIndexDefragmentation();
            /*0x7b67afc*/ void OnStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b67b84*/ void OnBlendingStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b60fa8*/ void PushDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, string scenario, int poolIndex, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete);
            /*0x7b58be4*/ void CancelStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b58db4*/ void CancelBlendingStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b67c84*/ bool ProcessDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request);
            /*0x7b687ec*/ void AllocateScratchBufferPoolIfNeeded();
            /*0x7b64bec*/ void UpdateActiveRequests(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b64b08*/ void ProcessNewRequests();
            /*0x7b66f0c*/ void UpdateDiskStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b6491c*/ bool HasActiveStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b688e4*/ void LogStreaming(string log);
            /*0x3910ae8*/ void <RegisterDebug>g__RefreshDebug|219_0<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x7b68b1c*/ bool <RegisterDebug>b__219_2();
            /*0x7b68b38*/ void <RegisterDebug>b__219_3(bool value);
            /*0x7b68b58*/ bool <RegisterDebug>b__219_4();
            /*0x7b68b74*/ void <RegisterDebug>b__219_5(bool value);
            /*0x7b68b94*/ float <RegisterDebug>b__219_6();
            /*0x7b68bb0*/ void <RegisterDebug>b__219_7(float value);
            /*0x7b68bcc*/ bool <RegisterDebug>b__219_9();
            /*0x7b68be8*/ void <RegisterDebug>b__219_10(bool value);
            /*0x7b68c08*/ bool <RegisterDebug>b__219_11();
            /*0x7b68c2c*/ int <RegisterDebug>b__219_12();
            /*0x7b68c48*/ void <RegisterDebug>b__219_13(int value);
            /*0x7b68c64*/ int <RegisterDebug>b__219_14();
            /*0x7b68c80*/ void <RegisterDebug>b__219_15(int value);
            /*0x7b68c9c*/ float <RegisterDebug>b__219_16();
            /*0x7b68cb8*/ void <RegisterDebug>b__219_17(float value);
            /*0x7b68cd4*/ float <RegisterDebug>b__219_20();
            /*0x7b68cf0*/ void <RegisterDebug>b__219_21(float value);
            /*0x7b68d0c*/ bool <RegisterDebug>b__219_22();
            /*0x7b68d44*/ int <RegisterDebug>b__219_23();
            /*0x7b68d60*/ void <RegisterDebug>b__219_24(int v);
            /*0x7b68d90*/ int <RegisterDebug>b__219_26();
            /*0x7b68da0*/ int <RegisterDebug>b__219_27();
            /*0x7b68dbc*/ void <RegisterDebug>b__219_28(int v);
            /*0x7b68ddc*/ int <RegisterDebug>b__219_30();
            /*0x7b68dec*/ bool <RegisterDebug>b__219_31();
            /*0x7b68e08*/ void <RegisterDebug>b__219_32(bool value);
            /*0x7b68e8c*/ bool <RegisterDebug>b__219_33();
            /*0x7b68eb0*/ float <RegisterDebug>b__219_34();
            /*0x7b68ecc*/ void <RegisterDebug>b__219_35(float value);
            /*0x7b68ee8*/ bool <RegisterDebug>b__219_38();
            /*0x7b68f04*/ void <RegisterDebug>b__219_39(bool value);
            /*0x7b68f24*/ bool <RegisterDebug>b__219_40();
            /*0x7b68f40*/ void <RegisterDebug>b__219_41(bool value);
            /*0x7b69040*/ bool <RegisterDebug>b__219_42();
            /*0x7b69064*/ float <RegisterDebug>b__219_43();
            /*0x7b69080*/ void <RegisterDebug>b__219_44(float value);
            /*0x7b6909c*/ bool <RegisterDebug>b__219_47();
            /*0x7b690c0*/ float <RegisterDebug>b__219_48();
            /*0x7b690dc*/ void <RegisterDebug>b__219_49(float value);
            /*0x7b690f8*/ bool <RegisterDebug>b__219_51();
            /*0x7b69114*/ void <RegisterDebug>b__219_52(bool value);
            /*0x7b69134*/ bool <RegisterDebug>b__219_53();
            /*0x7b69150*/ void <RegisterDebug>b__219_54(bool value);
            /*0x7b69170*/ bool <RegisterDebug>b__219_55();
            /*0x7b691a0*/ bool <RegisterDebug>b__219_56();
            /*0x7b691bc*/ void <RegisterDebug>b__219_57(bool value);
            /*0x7b691dc*/ bool <RegisterDebug>b__219_58();
            /*0x7b691f8*/ void <RegisterDebug>b__219_59(bool value);
            /*0x7b69218*/ bool <RegisterDebug>b__219_67();
            /*0x7b69234*/ void <RegisterDebug>b__219_68(bool value);
            /*0x7b69254*/ bool <RegisterDebug>b__219_69();
            /*0x7b69278*/ bool <RegisterDebug>b__219_71();
            /*0x7b69294*/ void <RegisterDebug>b__219_72(bool value);
            /*0x7b692b4*/ bool <RegisterDebug>b__219_73();
            /*0x7b692d0*/ void <RegisterDebug>b__219_74(bool value);
            /*0x7b692f0*/ void <RegisterDebug>g__RefreshScenarioNames|219_75(string guid);
            /*0x7b69a78*/ int <RegisterDebug>b__219_83();
            /*0x7b69bf0*/ void <RegisterDebug>b__219_84(int value);
            /*0x7b69c6c*/ int <RegisterDebug>b__219_85();
            /*0x7b69c88*/ void <RegisterDebug>b__219_86(int value);

            class ShaderIDs
            {
                static /*0x0*/ int _APVResIndex;
                static /*0x4*/ int _APVResCellIndices;
                static /*0x8*/ int _APVResL0_L1Rx;
                static /*0xc*/ int _APVResL1G_L1Ry;
                static /*0x10*/ int _APVResL1B_L1Rz;
                static /*0x14*/ int _APVResL2_0;
                static /*0x18*/ int _APVResL2_1;
                static /*0x1c*/ int _APVResL2_2;
                static /*0x20*/ int _APVResL2_3;
                static /*0x24*/ int _APVProbeOcclusion;
                static /*0x28*/ int _APVResValidity;
                static /*0x2c*/ int _SkyOcclusionTexL0L1;
                static /*0x30*/ int _SkyShadingDirectionIndicesTex;
                static /*0x34*/ int _SkyPrecomputedDirections;
                static /*0x38*/ int _AntiLeakData;

                static /*0x7b70f0c*/ ShaderIDs();
            }

            struct IndirectionEntryInfo
            {
                /*0x10*/ UnityEngine.Vector3Int positionInBricks;
                /*0x1c*/ int minSubdiv;
                /*0x20*/ UnityEngine.Vector3Int minBrickPos;
                /*0x2c*/ UnityEngine.Vector3Int maxBrickPosPlusOne;
                /*0x38*/ bool hasMinMax;
                /*0x39*/ bool hasOnlyBiggerBricks;
            }

            class CellDesc
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int index;
                /*0x20*/ int probeCount;
                /*0x24*/ int minSubdiv;
                /*0x28*/ int indexChunkCount;
                /*0x2c*/ int shChunkCount;
                /*0x30*/ int bricksCount;
                /*0x38*/ UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo[] indirectionEntryInfo;

                /*0x7b712b4*/ CellDesc();
                /*0x7b711fc*/ string ToString();
            }

            class CellData
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> validityNeighMaskData;
                /*0x20*/ Unity.Collections.NativeArray<ushort> <skyOcclusionDataL0L1>k__BackingField;
                /*0x30*/ Unity.Collections.NativeArray<byte> <skyShadingDirectionIndices>k__BackingField;
                /*0x40*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData> scenarios;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> <bricks>k__BackingField;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Vector3> <probePositions>k__BackingField;
                /*0x68*/ Unity.Collections.NativeArray<float> <touchupVolumeInteraction>k__BackingField;
                /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Vector3> <offsetVectors>k__BackingField;
                /*0x88*/ Unity.Collections.NativeArray<float> <validity>k__BackingField;
                /*0x98*/ Unity.Collections.NativeArray<byte> <layer>k__BackingField;

                /*0x7b718a4*/ CellData();
                /*0x7b712bc*/ Unity.Collections.NativeArray<ushort> get_skyOcclusionDataL0L1();
                /*0x7b712c8*/ void set_skyOcclusionDataL0L1(Unity.Collections.NativeArray<ushort> value);
                /*0x7b712d0*/ Unity.Collections.NativeArray<byte> get_skyShadingDirectionIndices();
                /*0x7b712dc*/ void set_skyShadingDirectionIndices(Unity.Collections.NativeArray<byte> value);
                /*0x7b712e4*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> get_bricks();
                /*0x7b712f0*/ void set_bricks(Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> value);
                /*0x7b712f8*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_probePositions();
                /*0x7b71304*/ void set_probePositions(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x7b7130c*/ Unity.Collections.NativeArray<float> get_touchupVolumeInteraction();
                /*0x7b71318*/ void set_touchupVolumeInteraction(Unity.Collections.NativeArray<float> value);
                /*0x7b71320*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_offsetVectors();
                /*0x7b7132c*/ void set_offsetVectors(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x7b71334*/ Unity.Collections.NativeArray<float> get_validity();
                /*0x7b71340*/ void set_validity(Unity.Collections.NativeArray<float> value);
                /*0x7b71348*/ Unity.Collections.NativeArray<byte> get_layer();
                /*0x7b71354*/ void set_layer(Unity.Collections.NativeArray<byte> value);
                /*0x7b7135c*/ void CleanupPerScenarioData(ref UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data);
                /*0x7b714ac*/ void Cleanup(bool cleanScenarioList);

                struct PerScenarioData
                {
                    /*0x10*/ Unity.Collections.NativeArray<ushort> shL0L1RxData;
                    /*0x20*/ Unity.Collections.NativeArray<byte> shL1GL1RyData;
                    /*0x30*/ Unity.Collections.NativeArray<byte> shL1BL1RzData;
                    /*0x40*/ Unity.Collections.NativeArray<byte> shL2Data_0;
                    /*0x50*/ Unity.Collections.NativeArray<byte> shL2Data_1;
                    /*0x60*/ Unity.Collections.NativeArray<byte> shL2Data_2;
                    /*0x70*/ Unity.Collections.NativeArray<byte> shL2Data_3;
                    /*0x80*/ Unity.Collections.NativeArray<byte> probeOcclusion;
                }
            }

            class CellPoolInfo
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x18*/ int shChunkCount;

                /*0x7b7197c*/ CellPoolInfo();
                /*0x7b7192c*/ void Clear();
            }

            class CellIndexInfo
            {
                /*0x10*/ int[] flatIndicesInGlobalIndirection;
                /*0x18*/ UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo updateInfo;
                /*0x20*/ bool indexUpdated;
                /*0x28*/ UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo[] indirectionEntryInfo;
                /*0x30*/ int indexChunkCount;

                /*0x7b71a34*/ CellIndexInfo();
                /*0x7b71a04*/ void Clear();
            }

            class CellBlendingInfo
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x18*/ float blendingScore;
                /*0x1c*/ float blendingFactor;
                /*0x20*/ bool blending;

                /*0x7b71af8*/ CellBlendingInfo();
                /*0x7b71a3c*/ void MarkUpToDate();
                /*0x7b71a48*/ bool IsUpToDate();
                /*0x7b71a60*/ void ForceReupload();
                /*0x7b71a6c*/ bool ShouldReupload();
                /*0x7b71a80*/ void Prioritize();
                /*0x7b71a8c*/ bool ShouldPrioritize();
                /*0x7b71aa0*/ void Clear();
            }

            class CellStreamingInfo
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest0;
                /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest1;
                /*0x28*/ float streamingScore;

                /*0x7b71c2c*/ CellStreamingInfo();
                /*0x7b71b80*/ bool IsStreaming();
                /*0x7b71bb0*/ bool IsBlendingStreaming();
                /*0x7b71bec*/ void Clear();
            }

            class Cell : System.IComparable<UnityEngine.Rendering.ProbeReferenceVolume.Cell>
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.CellDesc desc;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData data;
                /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.CellPoolInfo poolInfo;
                /*0x28*/ UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo indexInfo;
                /*0x30*/ UnityEngine.Rendering.ProbeReferenceVolume.CellBlendingInfo blendingInfo;
                /*0x38*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingInfo streamingInfo;
                /*0x40*/ int referenceCount;
                /*0x44*/ bool loaded;
                /*0x48*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData scenario0;
                /*0xc8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData scenario1;
                /*0x148*/ bool hasTwoScenarios;
                /*0x150*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes debugProbes;

                /*0x7b71df8*/ Cell();
                /*0x7b71c34*/ int CompareTo(UnityEngine.Rendering.ProbeReferenceVolume.Cell other);
                /*0x7b71c80*/ bool UpdateCellScenarioData(string scenario0, string scenario1);
                /*0x7b71d40*/ void Clear();
            }

            struct Volume : System.IEquatable<UnityEngine.Rendering.ProbeReferenceVolume.Volume>
            {
                /*0x10*/ UnityEngine.Vector3 corner;
                /*0x1c*/ UnityEngine.Vector3 X;
                /*0x28*/ UnityEngine.Vector3 Y;
                /*0x34*/ UnityEngine.Vector3 Z;
                /*0x40*/ float maxSubdivisionMultiplier;
                /*0x44*/ float minSubdivisionMultiplier;

                /*0x7b71f14*/ Volume(UnityEngine.Matrix4x4 trs, float maxSubdivision, float minSubdivision);
                /*0x7b71ff8*/ Volume(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, float maxSubdivision, float minSubdivision);
                /*0x7b72034*/ Volume(UnityEngine.Rendering.ProbeReferenceVolume.Volume copy);
                /*0x7b720d8*/ Volume(UnityEngine.Bounds bounds);
                /*0x7b72138*/ UnityEngine.Bounds CalculateAABB();
                /*0x7b72240*/ void CalculateCenterAndSize(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
                /*0x7b72408*/ void Transform(UnityEngine.Matrix4x4 trs);
                /*0x7b724b8*/ string ToString();
                /*0x7b72708*/ bool Equals(UnityEngine.Rendering.ProbeReferenceVolume.Volume other);
            }

            struct RefVolTransform
            {
                /*0x10*/ UnityEngine.Vector3 posWS;
                /*0x1c*/ UnityEngine.Quaternion rot;
                /*0x2c*/ float scale;
            }

            struct RuntimeResources
            {
                /*0x10*/ UnityEngine.ComputeBuffer index;
                /*0x18*/ UnityEngine.ComputeBuffer cellIndices;
                /*0x20*/ UnityEngine.RenderTexture L0_L1rx;
                /*0x28*/ UnityEngine.RenderTexture L1_G_ry;
                /*0x30*/ UnityEngine.RenderTexture L1_B_rz;
                /*0x38*/ UnityEngine.RenderTexture L2_0;
                /*0x40*/ UnityEngine.RenderTexture L2_1;
                /*0x48*/ UnityEngine.RenderTexture L2_2;
                /*0x50*/ UnityEngine.RenderTexture L2_3;
                /*0x58*/ UnityEngine.RenderTexture ProbeOcclusion;
                /*0x60*/ UnityEngine.RenderTexture Validity;
                /*0x68*/ UnityEngine.RenderTexture SkyOcclusionL0L1;
                /*0x70*/ UnityEngine.RenderTexture SkyShadingDirectionIndices;
                /*0x78*/ UnityEngine.ComputeBuffer SkyPrecomputedDirections;
                /*0x80*/ UnityEngine.ComputeBuffer QualityLeakReductionData;
            }

            struct ExtraDataActionInput
            {
            }

            class CellInstancedDebugProbes
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Matrix4x4[]> probeBuffers;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Matrix4x4[]> offsetBuffers;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> props;

                /*0x7b7280c*/ CellInstancedDebugProbes();
            }

            class RenderFragmentationOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugFragmentationMaterial;
                /*0x18*/ UnityEngine.Rendering.DebugOverlay debugOverlay;
                /*0x20*/ int chunkCount;
                /*0x28*/ UnityEngine.ComputeBuffer debugFragmentationData;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;

                /*0x7b72814*/ RenderFragmentationOverlayPassData();
            }

            class DiskStreamingRequest
            {
                /*0x10*/ Unity.IO.LowLevel.Unsafe.ReadHandle m_ReadHandle;
                /*0x20*/ Unity.IO.LowLevel.Unsafe.ReadCommandArray m_ReadCommandArray;
                /*0x30*/ Unity.Collections.NativeArray<Unity.IO.LowLevel.Unsafe.ReadCommand> m_ReadCommandBuffer;
                /*0x40*/ int m_BytesWritten;

                /*0x7b7281c*/ DiskStreamingRequest(int maxRequestCount);
                /*0x7b728a0*/ void AddReadCommand(int offset, int size, byte* dest);
                /*0x7b728d8*/ int RunCommands(Unity.IO.LowLevel.Unsafe.FileHandle file);
                /*0x7b72954*/ void Clear();
                /*0x7b729b4*/ void Cancel();
                /*0x7b729e4*/ void Wait();
                /*0x7b72a2c*/ void Dispose();
                /*0x7b72a74*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus();
            }

            struct CellStreamingScratchBufferLayout
            {
                /*0x10*/ int _SharedDestChunksOffset;
                /*0x14*/ int _L0L1rxOffset;
                /*0x18*/ int _L1GryOffset;
                /*0x1c*/ int _L1BrzOffset;
                /*0x20*/ int _ValidityOffset;
                /*0x24*/ int _ProbeOcclusionOffset;
                /*0x28*/ int _SkyOcclusionOffset;
                /*0x2c*/ int _SkyShadingDirectionOffset;
                /*0x30*/ int _L2_0Offset;
                /*0x34*/ int _L2_1Offset;
                /*0x38*/ int _L2_2Offset;
                /*0x3c*/ int _L2_3Offset;
                /*0x40*/ int _L0Size;
                /*0x44*/ int _L0ProbeSize;
                /*0x48*/ int _L1Size;
                /*0x4c*/ int _L1ProbeSize;
                /*0x50*/ int _ValiditySize;
                /*0x54*/ int _ValidityProbeSize;
                /*0x58*/ int _ProbeOcclusionSize;
                /*0x5c*/ int _ProbeOcclusionProbeSize;
                /*0x60*/ int _SkyOcclusionSize;
                /*0x64*/ int _SkyOcclusionProbeSize;
                /*0x68*/ int _SkyShadingDirectionSize;
                /*0x6c*/ int _SkyShadingDirectionProbeSize;
                /*0x70*/ int _L2Size;
                /*0x74*/ int _L2ProbeSize;
                /*0x78*/ int _ProbeCountInChunkLine;
                /*0x7c*/ int _ProbeCountInChunkSlice;
            }

            class CellStreamingScratchBuffer
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> stagingBuffer;
                /*0x20*/ int <chunkCount>k__BackingField;
                /*0x24*/ int <chunkSize>k__BackingField;
                /*0x28*/ int m_CurrentBuffer;
                /*0x30*/ UnityEngine.GraphicsBuffer[] m_GraphicsBuffers;

                /*0x7b72aa8*/ CellStreamingScratchBuffer(int chunkCount, int chunkSize, bool allocateGraphicsBuffers);
                /*0x7b72c1c*/ void Swap();
                /*0x7b72c40*/ void Dispose();
                /*0x7b6e678*/ UnityEngine.GraphicsBuffer get_buffer();
                /*0x7b72cec*/ int get_chunkCount();
                /*0x7b72cf4*/ int get_chunkSize();
            }

            class CellStreamingRequest
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell <cell>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State <state>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer <scratchBuffer>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout <scratchBufferLayout>k__BackingField;
                /*0x98*/ UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo <scenarioData>k__BackingField;
                /*0xa0*/ int <poolIndex>k__BackingField;
                /*0xa4*/ bool <streamSharedData>k__BackingField;
                /*0xa8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete;
                /*0xb0*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest cellDataStreamingRequest;
                /*0xb8*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest cellOptionalDataStreamingRequest;
                /*0xc0*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest cellSharedDataStreamingRequest;
                /*0xc8*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest cellProbeOcclusionDataStreamingRequest;
                /*0xd0*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest brickStreamingRequest;
                /*0xd8*/ UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest supportStreamingRequest;
                /*0xe0*/ int bytesWritten;

                /*0x7b73148*/ CellStreamingRequest();
                /*0x7b72cfc*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell get_cell();
                /*0x7b72d04*/ void set_cell(UnityEngine.Rendering.ProbeReferenceVolume.Cell value);
                /*0x7b72d0c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State get_state();
                /*0x7b72d14*/ void set_state(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State value);
                /*0x7b72d1c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer get_scratchBuffer();
                /*0x7b72d24*/ void set_scratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer value);
                /*0x7b72d2c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout get_scratchBufferLayout();
                /*0x7b72d3c*/ void set_scratchBufferLayout(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout value);
                /*0x7b72d54*/ UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo get_scenarioData();
                /*0x7b72d5c*/ void set_scenarioData(UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo value);
                /*0x7b72d64*/ int get_poolIndex();
                /*0x7b72d6c*/ void set_poolIndex(int value);
                /*0x7b72d74*/ bool get_streamSharedData();
                /*0x7b72d7c*/ void set_streamSharedData(bool value);
                /*0x7b71ba0*/ bool IsStreaming();
                /*0x7b72d88*/ void Cancel();
                /*0x7b72ea8*/ void WaitAll();
                /*0x7b72f14*/ bool UpdateRequestState(UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest request, ref bool isComplete);
                /*0x7b72f80*/ void UpdateState();
                /*0x7b73050*/ void Clear();
                /*0x7b73070*/ void Reset();
                /*0x7b730f0*/ void Dispose();

                enum State
                {
                    Pending = 0,
                    Active = 1,
                    Canceled = 2,
                    Invalid = 3,
                    Complete = 4,
                }

                class OnStreamingCompleteDelegate : System.MulticastDelegate
                {
                    /*0x7b73268*/ OnStreamingCompleteDelegate(object object, nint method);
                    /*0x7b73374*/ void Invoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7b73388*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd, System.AsyncCallback callback, object object);
                    /*0x7b733b0*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeReferenceVolume.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.Cell> <>9__148_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> <>9__148_1;
                static /*0x18*/ System.Func<bool> <>9__219_1;
                static /*0x20*/ System.Func<float> <>9__219_8;
                static /*0x28*/ System.Func<float> <>9__219_18;
                static /*0x30*/ System.Func<float> <>9__219_19;
                static /*0x38*/ System.Func<int> <>9__219_25;
                static /*0x40*/ System.Func<int> <>9__219_29;
                static /*0x48*/ System.Func<float> <>9__219_36;
                static /*0x50*/ System.Func<float> <>9__219_37;
                static /*0x58*/ System.Func<float> <>9__219_45;
                static /*0x60*/ System.Func<float> <>9__219_46;
                static /*0x68*/ System.Func<float> <>9__219_50;
                static /*0x70*/ System.Func<bool> <>9__219_60;
                static /*0x78*/ System.Action<bool> <>9__219_61;
                static /*0x80*/ System.Func<bool> <>9__219_62;
                static /*0x88*/ System.Func<int> <>9__219_63;
                static /*0x90*/ System.Action<int> <>9__219_64;
                static /*0x98*/ System.Func<int> <>9__219_65;
                static /*0xa0*/ System.Func<int> <>9__219_66;
                static /*0xa8*/ System.Func<object> <>9__219_70;
                static /*0xb0*/ System.Func<int> <>9__219_76;
                static /*0xb8*/ System.Action<int> <>9__219_77;
                static /*0xc0*/ System.Func<int> <>9__219_78;
                static /*0xc8*/ System.Func<float> <>9__219_79;
                static /*0xd0*/ System.Action<float> <>9__219_80;
                static /*0xd8*/ System.Func<float> <>9__219_81;
                static /*0xe0*/ System.Func<float> <>9__219_82;
                static /*0xe8*/ System.Func<float> <>9__219_87;
                static /*0xf0*/ System.Action<float> <>9__219_88;
                static /*0xf8*/ System.Func<float> <>9__219_89;
                static /*0x100*/ System.Func<float> <>9__219_90;
                static /*0x108*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.ProbeReferenceVolume.RenderFragmentationOverlayPassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__222_0;
                static /*0x110*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> <>9__283_0;

                static /*0x7b733bc*/ <>c();
                /*0x7b73424*/ <>c();
                /*0x7b7342c*/ void <.ctor>b__148_0(UnityEngine.Rendering.ProbeReferenceVolume.Cell x);
                /*0x7b73440*/ void <.ctor>b__148_1(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
                /*0x7b7346c*/ bool <RegisterDebug>b__219_1();
                /*0x7b73474*/ float <RegisterDebug>b__219_8();
                /*0x7b7347c*/ float <RegisterDebug>b__219_18();
                /*0x7b73488*/ float <RegisterDebug>b__219_19();
                /*0x7b73490*/ int <RegisterDebug>b__219_25();
                /*0x7b73498*/ int <RegisterDebug>b__219_29();
                /*0x7b734a0*/ float <RegisterDebug>b__219_36();
                /*0x7b734ac*/ float <RegisterDebug>b__219_37();
                /*0x7b734b4*/ float <RegisterDebug>b__219_45();
                /*0x7b734c0*/ float <RegisterDebug>b__219_46();
                /*0x7b734cc*/ float <RegisterDebug>b__219_50();
                /*0x7b734d4*/ bool <RegisterDebug>b__219_60();
                /*0x7b73568*/ void <RegisterDebug>b__219_61(bool value);
                /*0x7b73604*/ bool <RegisterDebug>b__219_62();
                /*0x7b73698*/ int <RegisterDebug>b__219_63();
                /*0x7b7372c*/ void <RegisterDebug>b__219_64(int value);
                /*0x7b737c8*/ int <RegisterDebug>b__219_65();
                /*0x7b737d0*/ int <RegisterDebug>b__219_66();
                /*0x7b737d8*/ object <RegisterDebug>b__219_70();
                /*0x7b73888*/ int <RegisterDebug>b__219_76();
                /*0x7b7391c*/ void <RegisterDebug>b__219_77(int value);
                /*0x7b739b8*/ int <RegisterDebug>b__219_78();
                /*0x7b739c0*/ float <RegisterDebug>b__219_79();
                /*0x7b73a54*/ void <RegisterDebug>b__219_80(float value);
                /*0x7b73af8*/ float <RegisterDebug>b__219_81();
                /*0x7b73b00*/ float <RegisterDebug>b__219_82();
                /*0x7b73b08*/ float <RegisterDebug>b__219_87();
                /*0x7b73b9c*/ void <RegisterDebug>b__219_88(float value);
                /*0x7b73c40*/ float <RegisterDebug>b__219_89();
                /*0x7b73c48*/ float <RegisterDebug>b__219_90();
                /*0x7b73c50*/ void <RenderFragmentationOverlay>b__222_0(UnityEngine.Rendering.ProbeReferenceVolume.RenderFragmentationOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                /*0x7b73dc8*/ void <CleanupStreaming>b__283_0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
            }

            class <>c__DisplayClass314_0
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell cell;

                /*0x7b73df4*/ <>c__DisplayClass314_0();
                /*0x7b73dfc*/ bool <HasActiveStreamingRequest>b__0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest x);
            }
        }

        class SceneExtensions
        {
            static /*0x0*/ System.Reflection.PropertyInfo s_SceneGUID;

            static /*0x7b73ee0*/ SceneExtensions();
            static /*0x7b73e20*/ string GetGUID(UnityEngine.SceneManagement.Scene scene);
        }

        struct ProbeVolumeSystemParameters
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget;
            /*0x14*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget;
            /*0x18*/ UnityEngine.Rendering.ProbeVolumeSHBands shBands;
            /*0x1c*/ bool supportScenarios;
            /*0x1d*/ bool supportScenarioBlending;
            /*0x1e*/ bool supportGPUStreaming;
            /*0x1f*/ bool supportDiskStreaming;
            /*0x20*/ UnityEngine.Shader probeDebugShader;
            /*0x28*/ UnityEngine.Shader probeSamplingDebugShader;
            /*0x30*/ UnityEngine.Texture probeSamplingDebugTexture;
            /*0x38*/ UnityEngine.Mesh probeSamplingDebugMesh;
            /*0x40*/ UnityEngine.Shader offsetDebugShader;
            /*0x48*/ UnityEngine.Shader fragmentationDebugShader;
            /*0x50*/ UnityEngine.ComputeShader scenarioBlendingShader;
            /*0x58*/ UnityEngine.ComputeShader streamingUploadShader;
            /*0x60*/ UnityEngine.Rendering.ProbeVolumeSceneData sceneData;
            /*0x68*/ bool supportsRuntimeDebug;
        }

        struct ProbeVolumeShadingParameters
        {
            /*0x10*/ float normalBias;
            /*0x14*/ float viewBias;
            /*0x18*/ bool scaleBiasByMinDistanceBetweenProbes;
            /*0x1c*/ float samplingNoise;
            /*0x20*/ float weight;
            /*0x24*/ UnityEngine.Rendering.APVLeakReductionMode leakReductionMode;
            /*0x28*/ int frameIndexForNoise;
            /*0x2c*/ float reflNormalizationLowerClamp;
            /*0x30*/ float reflNormalizationUpperClamp;
            /*0x34*/ float skyOcclusionIntensity;
            /*0x38*/ bool skyOcclusionShadingDirection;
            /*0x3c*/ int regionCount;
            /*0x40*/ Unity.Mathematics.uint4 regionLayerMasks;
            /*0x50*/ UnityEngine.Vector3 worldOffset;
        }

        enum ProbeVolumeTextureMemoryBudget
        {
            MemoryBudgetLow = 512,
            MemoryBudgetMedium = 1024,
            MemoryBudgetHigh = 2048,
        }

        enum ProbeVolumeBlendingTextureMemoryBudget
        {
            MemoryBudgetLow = 128,
            MemoryBudgetMedium = 256,
            MemoryBudgetHigh = 512,
        }

        enum ProbeVolumeSHBands
        {
            SphericalHarmonicsL1 = 1,
            SphericalHarmonicsL2 = 2,
        }

        enum DebugProbeShadingMode
        {
            SH = 0,
            SHL0 = 1,
            SHL0L1 = 2,
            Validity = 3,
            ValidityOverDilationThreshold = 4,
            RenderingLayerMasks = 5,
            InvalidatedByAdjustmentVolumes = 6,
            Size = 7,
            SkyOcclusionSH = 8,
            SkyDirection = 9,
            ProbeOcclusion = 10,
        }

        enum ProbeSamplingDebugUpdate
        {
            Never = 0,
            Once = 1,
            Always = 2,
        }

        class ProbeSamplingDebugData
        {
            /*0x10*/ UnityEngine.Rendering.ProbeSamplingDebugUpdate update;
            /*0x14*/ UnityEngine.Vector2 coordinates;
            /*0x1c*/ bool forceScreenCenterCoordinates;
            /*0x20*/ UnityEngine.Camera camera;
            /*0x28*/ bool shortcutPressed;
            /*0x30*/ UnityEngine.GraphicsBuffer positionNormalBuffer;

            /*0x7b73f9c*/ ProbeSamplingDebugData();
        }

        class ProbeVolumeDebug : UnityEngine.Rendering.IDebugData
        {
            static /*0x0*/ UnityEngine.Vector3 currentOffset;
            static /*0xc*/ int s_ActiveAdjustmentVolumes;
            /*0x10*/ bool drawProbes;
            /*0x11*/ bool drawBricks;
            /*0x12*/ bool drawCells;
            /*0x13*/ bool realtimeSubdivision;
            /*0x14*/ int subdivisionCellUpdatePerFrame;
            /*0x18*/ float subdivisionDelayInSeconds;
            /*0x1c*/ UnityEngine.Rendering.DebugProbeShadingMode probeShading;
            /*0x20*/ float probeSize;
            /*0x24*/ float subdivisionViewCullingDistance;
            /*0x28*/ float probeCullingDistance;
            /*0x2c*/ int maxSubdivToVisualize;
            /*0x30*/ int minSubdivToVisualize;
            /*0x34*/ float exposureCompensation;
            /*0x38*/ bool drawProbeSamplingDebug;
            /*0x3c*/ float probeSamplingDebugSize;
            /*0x40*/ bool debugWithSamplingNoise;
            /*0x44*/ uint samplingRenderingLayer;
            /*0x48*/ bool drawVirtualOffsetPush;
            /*0x4c*/ float offsetSize;
            /*0x50*/ bool freezeStreaming;
            /*0x51*/ bool displayCellStreamingScore;
            /*0x52*/ bool displayIndexFragmentation;
            /*0x54*/ int otherStateIndex;
            /*0x58*/ bool verboseStreamingLog;
            /*0x59*/ bool debugStreaming;
            /*0x5a*/ bool autoDrawProbes;
            /*0x5b*/ bool isolationProbeDebug;
            /*0x5c*/ byte visibleLayers;

            /*0x7b73fac*/ ProbeVolumeDebug();
            /*0x7b7405c*/ void Init();
            /*0x7b740c8*/ System.Action GetReset();
            /*0x7b74144*/ void <GetReset>b__32_0();
        }

        class ProbeVolumeDebugColorPreferences
        {
            static /*0x0*/ System.Func<UnityEngine.Color> GetDetailSubdivisionColor;
            static /*0x8*/ System.Func<UnityEngine.Color> GetMediumSubdivisionColor;
            static /*0x10*/ System.Func<UnityEngine.Color> GetLowSubdivisionColor;
            static /*0x18*/ System.Func<UnityEngine.Color> GetVeryLowSubdivisionColor;
            static /*0x20*/ System.Func<UnityEngine.Color> GetSparseSubdivisionColor;
            static /*0x28*/ System.Func<UnityEngine.Color> GetSparsestSubdivisionColor;
            static /*0x30*/ UnityEngine.Color s_DetailSubdivision;
            static /*0x40*/ UnityEngine.Color s_MediumSubdivision;
            static /*0x50*/ UnityEngine.Color s_LowSubdivision;
            static /*0x60*/ UnityEngine.Color s_VeryLowSubdivision;
            static /*0x70*/ UnityEngine.Color s_SparseSubdivision;
            static /*0x80*/ UnityEngine.Color s_SparsestSubdivision;

            static /*0x7b741b0*/ ProbeVolumeDebugColorPreferences();
            /*0x7b74250*/ ProbeVolumeDebugColorPreferences();
        }

        class ProbeVolume : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Rendering.ProbeVolume.Mode mode;
            /*0x24*/ UnityEngine.Vector3 size;
            /*0x30*/ bool overrideRendererFilters;
            /*0x34*/ float minRendererVolumeSize;
            /*0x38*/ UnityEngine.LayerMask objectLayerMask;
            /*0x3c*/ int lowestSubdivLevelOverride;
            /*0x40*/ int highestSubdivLevelOverride;
            /*0x44*/ bool overridesSubdivLevels;
            /*0x45*/ bool mightNeedRebaking;
            /*0x48*/ UnityEngine.Matrix4x4 cachedTransform;
            /*0x88*/ int cachedHashCode;
            /*0x8c*/ bool fillEmptySpaces;
            /*0x90*/ UnityEngine.Rendering.ProbeVolume.Version version;
            /*0x94*/ bool globalVolume;

            /*0x7b7428c*/ ProbeVolume();
            /*0x7b74258*/ void Awake();

            enum Mode
            {
                Global = 0,
                Scene = 1,
                Local = 2,
            }

            enum Version
            {
                Initial = 0,
                LocalMode = 1,
                InvertOverrideLevels = 2,
                Count = 3,
            }
        }

        class ObsoleteProbeVolumeAsset : UnityEngine.ScriptableObject
        {
            /*0x7b742e0*/ ObsoleteProbeVolumeAsset();
        }

        struct ProbeDilationSettings
        {
            /*0x10*/ bool enableDilation;
            /*0x14*/ float dilationDistance;
            /*0x18*/ float dilationValidityThreshold;
            /*0x1c*/ int dilationIterations;
            /*0x20*/ bool squaredDistWeighting;

            /*0x7b742e8*/ void SetDefaults();
            /*0x7b74308*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct VirtualOffsetSettings
        {
            /*0x10*/ bool useVirtualOffset;
            /*0x14*/ float validityThreshold;
            /*0x18*/ float outOfGeoOffset;
            /*0x1c*/ float searchMultiplier;
            /*0x20*/ float rayOriginBias;
            /*0x24*/ UnityEngine.LayerMask collisionMask;

            /*0x7b7430c*/ void SetDefaults();
            /*0x7b74340*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct ProbeVolumeBakingProcessSettings
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion m_Version;
            /*0x14*/ UnityEngine.Rendering.ProbeDilationSettings dilationSettings;
            /*0x28*/ UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings;

            static /*0x7b7437c*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings get_Default();
            /*0x7b74430*/ ProbeVolumeBakingProcessSettings(UnityEngine.Rendering.ProbeDilationSettings dilationSettings, UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings);
            /*0x7b743e0*/ void SetDefaults();
            /*0x7b7445c*/ void Upgrade();

            enum SettingsVersion
            {
                Initial = 0,
                ThreadedVirtualOffset = 1,
                Max = 2,
                Current = 1,
            }
        }

        class LogarithmicAttribute : UnityEngine.PropertyAttribute
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x7b744a4*/ LogarithmicAttribute(int min, int max);
        }

        class ProbeVolumeBakingSet : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            static int k_MaxSkyOcclusionBakingSamples = 8192;
            /*0x18*/ bool singleSceneMode;
            /*0x19*/ bool dialogNoProbeVolumeInSetShown;
            /*0x1c*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings settings;
            /*0x50*/ System.Collections.Generic.List<string> m_SceneGUIDs;
            /*0x58*/ System.Collections.Generic.List<string> obsoleteScenesToNotBake;
            /*0x60*/ System.Collections.Generic.List<string> m_LightingScenarios;
            /*0x68*/ UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeReferenceVolume.CellDesc> cellDescs;
            /*0x70*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProbeReferenceVolume.CellData> cellDataMap;
            /*0x78*/ System.Collections.Generic.List<int> m_TotalIndexList;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeBakingSet.SerializedPerSceneCellList> m_SerializedPerSceneCellList;
            /*0x88*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> perSceneCellLists;
            /*0x90*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellSharedDataAsset;
            /*0x98*/ UnityEngine.Rendering.SerializedDictionary<string, UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo> scenarios;
            /*0xa0*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellBricksDataAsset;
            /*0xa8*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellSupportDataAsset;
            /*0xb0*/ int chunkSizeInBricks;
            /*0xb4*/ UnityEngine.Vector3Int maxCellPosition;
            /*0xc0*/ UnityEngine.Vector3Int minCellPosition;
            /*0xcc*/ UnityEngine.Bounds globalBounds;
            /*0xe4*/ int bakedSimplificationLevels;
            /*0xe8*/ float bakedMinDistanceBetweenProbes;
            /*0xec*/ bool bakedProbeOcclusion;
            /*0xf0*/ int bakedSkyOcclusionValue;
            /*0xf4*/ int bakedSkyShadingDirectionValue;
            /*0xf8*/ UnityEngine.Vector3 bakedProbeOffset;
            /*0x104*/ int bakedMaskCount;
            /*0x108*/ Unity.Mathematics.uint4 bakedLayerMasks;
            /*0x118*/ int maxSHChunkCount;
            /*0x11c*/ int L0ChunkSize;
            /*0x120*/ int L1ChunkSize;
            /*0x124*/ int L2TextureChunkSize;
            /*0x128*/ int ProbeOcclusionChunkSize;
            /*0x12c*/ int sharedValidityMaskChunkSize;
            /*0x130*/ int sharedSkyOcclusionL0L1ChunkSize;
            /*0x134*/ int sharedSkyShadingDirectionIndicesChunkSize;
            /*0x138*/ int sharedDataChunkSize;
            /*0x13c*/ int supportPositionChunkSize;
            /*0x140*/ int supportValidityChunkSize;
            /*0x144*/ int supportTouchupChunkSize;
            /*0x148*/ int supportLayerMaskChunkSize;
            /*0x14c*/ int supportOffsetsChunkSize;
            /*0x150*/ int supportDataChunkSize;
            /*0x158*/ string lightingScenario;
            /*0x160*/ string m_OtherScenario;
            /*0x168*/ float m_ScenarioBlendingFactor;
            /*0x170*/ Unity.IO.LowLevel.Unsafe.ReadCommandArray m_ReadCommandArray;
            /*0x180*/ Unity.Collections.NativeArray<Unity.IO.LowLevel.Unsafe.ReadCommand> m_ReadCommandBuffer;
            /*0x190*/ System.Collections.Generic.Stack<Unity.Collections.NativeArray<byte>> m_ReadOperationScratchBuffers;
            /*0x198*/ System.Collections.Generic.List<int> m_PrunedIndexList;
            /*0x1a0*/ System.Collections.Generic.List<int> m_PrunedScenarioIndexList;
            /*0x1a8*/ UnityEngine.Rendering.ProbeVolumeBakingSet.Version version;
            /*0x1ac*/ bool freezePlacement;
            /*0x1b0*/ UnityEngine.Vector3 probeOffset;
            /*0x1bc*/ int simplificationLevels;
            /*0x1c0*/ float minDistanceBetweenProbes;
            /*0x1c4*/ UnityEngine.LayerMask renderersLayerMask;
            /*0x1c8*/ float minRendererVolumeSize;
            /*0x1cc*/ bool skyOcclusion;
            /*0x1d0*/ int skyOcclusionBakingSamples;
            /*0x1d4*/ int skyOcclusionBakingBounces;
            /*0x1d8*/ float skyOcclusionAverageAlbedo;
            /*0x1dc*/ bool skyOcclusionBackFaceCulling;
            /*0x1dd*/ bool skyOcclusionShadingDirection;
            /*0x1de*/ bool useRenderingLayers;
            /*0x1e0*/ UnityEngine.Rendering.ProbeVolumeBakingSet.ProbeLayerMask[] renderingLayerMasks;
            /*0x1e8*/ bool m_HasSupportData;
            /*0x1e9*/ bool m_SharedDataIsValid;
            /*0x1ea*/ bool m_UseStreamingAsset;

            static /*0x7b7459c*/ int GetCellSizeInBricks(int simplificationLevels);
            static /*0x7b745d8*/ int GetMaxSubdivision(int simplificationLevels);
            static /*0x7b745fc*/ float GetMinBrickSize(float minDistanceBetweenProbes);
            static /*0x7b763ec*/ int AlignUp16(int count);
            /*0x7b783e8*/ ProbeVolumeBakingSet();
            /*0x7b744d0*/ bool get_hasDilation();
            /*0x7b744f0*/ System.Collections.Generic.IReadOnlyList<string> get_sceneGUIDs();
            /*0x7b744f8*/ System.Collections.Generic.IReadOnlyList<string> get_lightingScenarios();
            /*0x7b74500*/ bool get_bakedSkyOcclusion();
            /*0x7b74510*/ void set_bakedSkyOcclusion(bool value);
            /*0x7b7452c*/ bool get_bakedSkyShadingDirection();
            /*0x7b7453c*/ void set_bakedSkyShadingDirection(bool value);
            /*0x7b74558*/ string get_otherScenario();
            /*0x7b74560*/ float get_scenarioBlendingFactor();
            /*0x7b74568*/ int get_cellSizeInBricks();
            /*0x7b745cc*/ int get_maxSubdivision();
            /*0x7b745e0*/ float get_minBrickSize();
            /*0x7b74614*/ float get_cellSizeInMeters();
            /*0x7b74678*/ Unity.Mathematics.uint4 ComputeRegionMasks();
            /*0x7b7475c*/ void OnValidate();
            /*0x7b748f4*/ void OnEnable();
            /*0x7b74928*/ void Migrate();
            /*0x7b74a1c*/ bool ComputeHasValidSharedData();
            /*0x7b74b18*/ bool HasValidSharedData();
            /*0x7b74b20*/ bool CheckCompatibleCellLayout();
            /*0x7b749dc*/ bool ComputeHasSupportData();
            /*0x7b74bcc*/ bool HasSupportData();
            /*0x7b74bd4*/ bool HasBakedData(string scenario);
            /*0x7b74d0c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7b75174*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7b753e0*/ void Initialize(bool useStreamingAsset);
            /*0x7b75b78*/ void Cleanup();
            /*0x7b75f5c*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x7b75848*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x7b761e4*/ int GetBakingHashCode();
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetSubArray<T>(Unity.Collections.NativeArray<byte> input, int count, ref int offset);
            /*0x7b76414*/ Unity.Collections.NativeArray<byte> RequestScratchBuffer(int size);
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> LoadStreambleAssetData<T>(UnityEngine.Rendering.ProbeVolumeStreamableAsset asset, System.Collections.Generic.List<int> cellIndices);
            /*0x3910ae8*/ void ReleaseStreamableAssetData<T>(Unity.Collections.NativeArray<T> buffer);
            /*0x7b764f8*/ void PruneCellIndexList(System.Collections.Generic.List<int> cellIndices, System.Collections.Generic.List<int> prunedIndexList);
            /*0x7b7670c*/ void PruneCellIndexListForScenario(System.Collections.Generic.List<int> cellIndices, UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo scenarioData, System.Collections.Generic.List<int> prunedIndexList);
            /*0x7b7693c*/ System.Collections.Generic.List<int> GetSceneCellIndexList(string sceneGUID);
            /*0x7b75818*/ bool ResolveAllCellData();
            /*0x7b77198*/ bool ResolveCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b775cc*/ void ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricksData, Unity.Collections.NativeArray<byte> cellSharedData, Unity.Collections.NativeArray<byte> cellSupportData);
            /*0x7b769b4*/ bool ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b76bd4*/ bool ResolvePerScenarioCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b77cac*/ bool ResolvePerScenarioCellData(Unity.Collections.NativeArray<byte> cellData, Unity.Collections.NativeArray<byte> cellOptionalData, Unity.Collections.NativeArray<byte> cellProbeOcclusionData, string scenario, System.Collections.Generic.List<int> cellIndices);
            /*0x7b78230*/ void ReleaseCell(int cellIndex);
            /*0x7b782bc*/ UnityEngine.Rendering.ProbeReferenceVolume.CellDesc GetCellDesc(int cellIndex);
            /*0x7b78334*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData GetCellData(int cellIndex);
            /*0x7b783ac*/ int GetChunkGPUMemory(UnityEngine.Rendering.ProbeVolumeSHBands shBands);

            enum Version
            {
                Initial = 0,
                RemoveProbeVolumeSceneData = 1,
            }

            class PerScenarioDataInfo
            {
                /*0x10*/ int sceneHash;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellDataAsset;
                /*0x20*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellOptionalDataAsset;
                /*0x28*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset;
                /*0x30*/ bool m_HasValidData;

                /*0x7b788a8*/ PerScenarioDataInfo();
                /*0x7b757fc*/ void Initialize(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x7b75f34*/ bool IsValid();
                /*0x7b788a0*/ bool HasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x7b78848*/ bool ComputeHasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            }

            struct CellCounts
            {
                /*0x10*/ int bricksCount;
                /*0x14*/ int chunksCount;

                /*0x7b788b0*/ void Add(UnityEngine.Rendering.ProbeVolumeBakingSet.CellCounts o);
            }

            struct SerializedPerSceneCellList
            {
                /*0x10*/ string sceneGUID;
                /*0x18*/ System.Collections.Generic.List<int> cellList;
            }

            struct ProbeLayerMask
            {
                /*0x10*/ UnityEngine.RenderingLayerMask mask;
                /*0x18*/ string name;
            }
        }

        class ProbeVolumeConstantRuntimeResources
        {
            static int NB_SKY_PRECOMPUTED_DIRECTIONS = 255;
            static /*0x0*/ UnityEngine.ComputeBuffer m_SkySamplingDirectionsBuffer;
            static /*0x8*/ UnityEngine.ComputeBuffer m_AntiLeakDataBuffer;
            static /*0x10*/ UnityEngine.Vector3[] k_SkyDirections;
            static /*0x18*/ uint[] k_AntiLeakData;

            static /*0x7b78dec*/ ProbeVolumeConstantRuntimeResources();
            static /*0x7b788c8*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            static /*0x7b78944*/ void Initialize();
            static /*0x7b78cc8*/ UnityEngine.Vector3[] GetSkySamplingDirections();
            static /*0x7b78d20*/ void Cleanup();
            static /*0x7b78adc*/ UnityEngine.Vector3[] GenerateSkyDirections();
        }

        struct GIContributors
        {
        }

        class ProbeVolumeRuntimeResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x18*/ UnityEngine.ComputeShader probeVolumeBlendStatesCS;
            /*0x20*/ UnityEngine.ComputeShader probeVolumeUploadDataCS;
            /*0x28*/ UnityEngine.ComputeShader probeVolumeUploadDataL2CS;

            /*0x7b78ef4*/ ProbeVolumeRuntimeResources();
            /*0x7b78eec*/ int get_version();
        }

        class ProbeVolumeDebugResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x18*/ UnityEngine.Shader probeVolumeDebugShader;
            /*0x20*/ UnityEngine.Shader probeVolumeFragmentationDebugShader;
            /*0x28*/ UnityEngine.Shader probeVolumeSamplingDebugShader;
            /*0x30*/ UnityEngine.Shader probeVolumeOffsetDebugShader;
            /*0x38*/ UnityEngine.Mesh probeSamplingDebugMesh;
            /*0x40*/ UnityEngine.Texture2D numbersDisplayTex;

            /*0x7b78f0c*/ ProbeVolumeDebugResources();
            /*0x7b78f04*/ int get_version();
        }

        class ProbeVolumeBakingResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x18*/ UnityEngine.ComputeShader dilationShader;
            /*0x20*/ UnityEngine.ComputeShader subdivideSceneCS;
            /*0x28*/ UnityEngine.Shader voxelizeSceneShader;
            /*0x30*/ UnityEngine.ComputeShader traceVirtualOffsetCS;
            /*0x38*/ UnityEngine.Rendering.RayTracingShader traceVirtualOffsetRT;
            /*0x40*/ UnityEngine.ComputeShader skyOcclusionCS;
            /*0x48*/ UnityEngine.Rendering.RayTracingShader skyOcclusionRT;
            /*0x50*/ UnityEngine.ComputeShader renderingLayerCS;
            /*0x58*/ UnityEngine.Rendering.RayTracingShader renderingLayerRT;

            /*0x7b78f24*/ ProbeVolumeBakingResources();
            /*0x7b78f1c*/ int get_version();
        }

        class ProbeVolumeGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x14*/ bool m_ProbeVolumeDisableStreamingAssets;

            /*0x7b78fb8*/ ProbeVolumeGlobalSettings();
            /*0x7b78f34*/ int get_version();
            /*0x7b78f3c*/ bool get_probeVolumeDisableStreamingAssets();
            /*0x7b78f44*/ void set_probeVolumeDisableStreamingAssets(bool value);
        }

        class ProbeVolumePerSceneData : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Rendering.ProbeVolumeBakingSet serializedBakingSet;
            /*0x28*/ string sceneGUID;
            /*0x30*/ UnityEngine.Rendering.ObsoleteProbeVolumeAsset obsoleteAsset;
            /*0x38*/ UnityEngine.TextAsset obsoleteCellSharedDataAsset;
            /*0x40*/ UnityEngine.TextAsset obsoleteCellSupportDataAsset;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData.ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios;

            /*0x7b79440*/ ProbeVolumePerSceneData();
            /*0x7b78fc8*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_bakingSet();
            /*0x7b78fd0*/ void Clear();
            /*0x7b790d4*/ void QueueSceneLoading();
            /*0x7b78ff0*/ void QueueSceneRemoval();
            /*0x7b791b8*/ void OnEnable();
            /*0x7b79254*/ void OnDisable();
            /*0x7b792f8*/ void OnValidate();
            /*0x7b792fc*/ void Initialize();
            /*0x7b793a8*/ bool ResolveCellData();

            struct ObsoletePerScenarioData
            {
                /*0x10*/ int sceneHash;
                /*0x18*/ UnityEngine.TextAsset cellDataAsset;
                /*0x20*/ UnityEngine.TextAsset cellOptionalDataAsset;
            }

            struct ObsoleteSerializablePerScenarioDataItem
            {
                /*0x10*/ string scenario;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumePerSceneData.ObsoletePerScenarioData data;
            }
        }

        class ProbeVolumePositioning
        {
            static /*0x0*/ UnityEngine.Vector3[] m_Axes;
            static /*0x8*/ UnityEngine.Vector3[] m_AABBCorners;

            static /*0x7b7a310*/ ProbeVolumePositioning();
            static /*0x7b794ec*/ bool OBBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Rendering.ProbeReferenceVolume.Volume b);
            static /*0x7b79c68*/ bool OBBContains(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume obb, UnityEngine.Vector3 point);
            static /*0x7b79d50*/ bool OBBAABBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Bounds b, ref UnityEngine.Bounds aAABB);
            static /*0x7b79b80*/ UnityEngine.Vector2 ProjectOBB(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, UnityEngine.Vector3 axis);
            static /*0x7b7a26c*/ UnityEngine.Vector2 ProjectAABB(ref UnityEngine.Vector3[] corners, UnityEngine.Vector3 axis);
        }

        class ProbeVolumeSceneData
        {
            /*0x10*/ UnityEngine.Object parentAsset;
            /*0x18*/ UnityEngine.Rendering.SerializedDictionary<string, UnityEngine.Bounds> obsoleteSceneBounds;
            /*0x20*/ UnityEngine.Rendering.SerializedDictionary<string, bool> obsoleteHasProbeVolumes;

            /*0x7b7a3a8*/ ProbeVolumeSceneData(UnityEngine.Object parentAsset);
            /*0x7b7a3d8*/ void SetParentObject(UnityEngine.Object parent);
        }

        class ProbeVolumeScratchBufferPool
        {
            static /*0x0*/ int s_ChunkCount;
            /*0x10*/ int <chunkSize>k__BackingField;
            /*0x14*/ int <maxChunkCount>k__BackingField;
            /*0x18*/ int m_L0Size;
            /*0x1c*/ int m_L1Size;
            /*0x20*/ int m_ValiditySize;
            /*0x24*/ int m_ValidityLayerCount;
            /*0x28*/ int m_L2Size;
            /*0x2c*/ int m_ProbeOcclusionSize;
            /*0x30*/ int m_SkyOcclusionSize;
            /*0x34*/ int m_SkyShadingDirectionSize;
            /*0x38*/ int m_CurrentlyAllocatedChunkCount;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> m_Pools;
            /*0x48*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout> m_Layouts;

            /*0x7b7a410*/ ProbeVolumeScratchBufferPool(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet, UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x7b7a3e0*/ int get_chunkSize();
            /*0x7b7a3e8*/ void set_chunkSize(int value);
            /*0x7b7a3f0*/ int get_maxChunkCount();
            /*0x7b7a3f8*/ void set_maxChunkCount(int value);
            /*0x7b7a400*/ int get_allocatedMemory();
            /*0x7b7a570*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount);
            /*0x7b7a7d8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers);
            /*0x7b7a858*/ bool AllocateScratchBuffer(int chunkCount, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers);
            /*0x7b7ac90*/ void ReleaseScratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer);
            /*0x7b7ae10*/ void Cleanup();

            class ScratchBufferPool : System.IComparable<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool>
            {
                /*0x10*/ int chunkCount;
                /*0x18*/ System.Collections.Generic.Stack<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer> pool;

                /*0x7b7abf4*/ ScratchBufferPool(int chunkCount);
                /*0x7b7aff0*/ ScratchBufferPool();
                /*0x7b7b080*/ int CompareTo(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool other);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeVolumeScratchBufferPool.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__26_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__27_0;

                static /*0x7b7b0b0*/ <>c();
                /*0x7b7b118*/ <>c();
                /*0x7b7b120*/ bool <AllocateScratchBuffer>b__26_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
                /*0x7b7b180*/ bool <ReleaseScratchBuffer>b__27_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
            }
        }

        class APVLeakReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.APVLeakReductionMode>
        {
            /*0x7b7b1e0*/ APVLeakReductionModeParameter(UnityEngine.Rendering.APVLeakReductionMode value, bool overrideState);
        }

        class ProbeVolumesOptions : UnityEngine.Rendering.VolumeComponent
        {
            /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter normalBias;
            /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter viewBias;
            /*0x48*/ UnityEngine.Rendering.BoolParameter scaleBiasWithMinProbeDistance;
            /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter samplingNoise;
            /*0x58*/ UnityEngine.Rendering.BoolParameter animateSamplingNoise;
            /*0x60*/ UnityEngine.Rendering.APVLeakReductionModeParameter leakReductionMode;
            /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter minValidDotProductValue;
            /*0x70*/ UnityEngine.Rendering.BoolParameter occlusionOnlyReflectionNormalization;
            /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter intensityMultiplier;
            /*0x80*/ UnityEngine.Rendering.ClampedFloatParameter skyOcclusionIntensityMultiplier;
            /*0x88*/ UnityEngine.Rendering.Vector3Parameter worldOffset;

            /*0x7b7b240*/ ProbeVolumesOptions();
        }

        class ProbeVolumeStreamableAsset
        {
            /*0x10*/ string m_AssetGUID;
            /*0x18*/ string m_StreamableAssetPath;
            /*0x20*/ int m_ElementSize;
            /*0x28*/ UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> m_StreamableCellDescs;
            /*0x30*/ UnityEngine.TextAsset m_Asset;
            /*0x38*/ string m_FinalAssetPath;
            /*0x40*/ Unity.IO.LowLevel.Unsafe.FileHandle m_AssetFileHandle;

            /*0x7b7b590*/ ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID);
            /*0x7b7b570*/ string get_assetGUID();
            /*0x7b7b578*/ UnityEngine.TextAsset get_asset();
            /*0x7b7b580*/ int get_elementSize();
            /*0x7b7b588*/ UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> get_streamableCellDescs();
            /*0x7b7b728*/ void RefreshAssetPath();
            /*0x7b7b7cc*/ string GetAssetPath();
            /*0x7b74a54*/ bool FileExists();
            /*0x7b7b7f8*/ long GetFileSize();
            /*0x7b7b870*/ bool IsOpen();
            /*0x7b7b87c*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFile();
            /*0x7b7b8b8*/ void CloseFile();
            /*0x7b74bac*/ bool IsValid();
            /*0x7b75edc*/ void Dispose();

            struct StreamableCellDesc
            {
                /*0x10*/ int offset;
                /*0x14*/ int elementCount;
            }
        }

        class APVDefinitions
        {
            static float probeValidityThreshold = 0.05000000074505806;
            static /*0x0*/ int probeIndexChunkSize;
            static /*0x4*/ int probeMaxRegionCount;
            static /*0x8*/ UnityEngine.Color32[] layerMaskColors;
            static /*0x10*/ UnityEngine.Color debugEmptyColor;

            static /*0x7b7b928*/ APVDefinitions();
            /*0x7b7b920*/ APVDefinitions();
        }

        enum APVConstantBufferRegister
        {
            GlobalRegister = 6,
        }

        enum APVLeakReductionMode
        {
            None = 0,
            Performance = 1,
            Quality = 2,
            ValidityBased = 1,
            ValidityAndNormalBased = 2,
        }

        struct ShaderVariablesProbeVolumes
        {
            /*0x10*/ UnityEngine.Vector4 _Offset_LayerCount;
            /*0x20*/ UnityEngine.Vector4 _MinLoadedCellInEntries_IndirectionEntryDim;
            /*0x30*/ UnityEngine.Vector4 _MaxLoadedCellInEntries_RcpIndirectionEntryDim;
            /*0x40*/ UnityEngine.Vector4 _PoolDim_MinBrickSize;
            /*0x50*/ UnityEngine.Vector4 _RcpPoolDim_XY;
            /*0x60*/ UnityEngine.Vector4 _MinEntryPos_Noise;
            /*0x70*/ Unity.Mathematics.uint4 _EntryCount_X_XY_LeakReduction;
            /*0x80*/ UnityEngine.Vector4 _Biases_NormalizationClamp;
            /*0x90*/ UnityEngine.Vector4 _FrameIndex_Weights;
            /*0xa0*/ Unity.Mathematics.uint4 _ProbeVolumeLayerMask;
        }

        struct SphericalHarmonicsL1
        {
            static /*0x0*/ UnityEngine.Rendering.SphericalHarmonicsL1 zero;
            /*0x10*/ UnityEngine.Vector4 shAr;
            /*0x20*/ UnityEngine.Vector4 shAg;
            /*0x30*/ UnityEngine.Vector4 shAb;

            static /*0x7b7be08*/ SphericalHarmonicsL1();
            static /*0x7b7ba1c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b7ba44*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b7ba6c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x7b7ba8c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x7b7bab0*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b7bb60*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            /*0x7b7bc14*/ bool Equals(object other);
            /*0x7b7bcf4*/ int GetHashCode();
        }

        class SphericalHarmonicsL2Utils
        {
            static /*0x7b7be9c*/ void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L1_R, ref UnityEngine.Vector3 L1_G, ref UnityEngine.Vector3 L1_B);
            static /*0x7b7bfb0*/ void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L2_0, ref UnityEngine.Vector3 L2_1, ref UnityEngine.Vector3 L2_2, ref UnityEngine.Vector3 L2_3, ref UnityEngine.Vector3 L2_4);
            static /*0x7b7c16c*/ void SetL0(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L0);
            static /*0x7b7c1c8*/ void SetL1R(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R);
            static /*0x7b7c224*/ void SetL1G(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_G);
            static /*0x7b7c280*/ void SetL1B(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_B);
            static /*0x7b7c2dc*/ void SetL1(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B);
            static /*0x7b7c340*/ void SetCoefficient(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index, UnityEngine.Vector3 coefficient);
            static /*0x7b7c3a8*/ UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index);
            /*0x7b7c418*/ SphericalHarmonicsL2Utils();
        }

        enum HDRRangeReduction
        {
            None = 0,
            Reinhard = 1,
            BT2390 = 2,
            ACES1000Nits = 3,
            ACES2000Nits = 4,
            ACES4000Nits = 5,
        }

        enum HDRColorspace
        {
            Rec709 = 0,
            Rec2020 = 1,
            P3D65 = 2,
        }

        enum HDREncoding
        {
            Linear = 3,
            PQ = 2,
            Gamma22 = 4,
            sRGB = 0,
        }

        interface IPostProcessComponent
        {
            /*0x3813ffc*/ bool IsActive();
            /*0x7b7c420*/ bool IsTileCompatible();
        }

        class LensFlareCommonSRP
        {
            static /*0x0*/ UnityEngine.Rendering.LensFlareCommonSRP m_Instance;
            static /*0x8*/ object m_Padlock;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo> m_Data;
            static /*0x18*/ System.Collections.Generic.List<int> m_AvailableIndicies;
            static /*0x20*/ int maxLensFlareWithOcclusion;
            static /*0x24*/ int maxLensFlareWithOcclusionTemporalSample;
            static /*0x28*/ int mergeNeeded;
            static /*0x30*/ UnityEngine.Rendering.RTHandle occlusionRT;
            static /*0x38*/ int frameIdx;
            static /*0x3c*/ int _FlareOcclusionPermutation;
            static /*0x40*/ int _FlareOcclusionRemapTex;
            static /*0x44*/ int _FlareOcclusionTex;
            static /*0x48*/ int _FlareOcclusionIndex;
            static /*0x4c*/ int _FlareCloudOpacity;
            static /*0x50*/ int _FlareSunOcclusionTex;
            static /*0x54*/ int _FlareTex;
            static /*0x58*/ int _FlareColorValue;
            static /*0x5c*/ int _FlareData0;
            static /*0x60*/ int _FlareData1;
            static /*0x64*/ int _FlareData2;
            static /*0x68*/ int _FlareData3;
            static /*0x6c*/ int _FlareData4;
            static /*0x70*/ int _FlareData5;
            static /*0x74*/ int _FlareRadialTint;
            static /*0x78*/ int _ViewId;
            static /*0x7c*/ int _LensFlareScreenSpaceBloomMipTexture;
            static /*0x80*/ int _LensFlareScreenSpaceResultTexture;
            static /*0x84*/ int _LensFlareScreenSpaceSpectralLut;
            static /*0x88*/ int _LensFlareScreenSpaceStreakTex;
            static /*0x8c*/ int _LensFlareScreenSpaceMipLevel;
            static /*0x90*/ int _LensFlareScreenSpaceTintColor;
            static /*0x94*/ int _LensFlareScreenSpaceParams1;
            static /*0x98*/ int _LensFlareScreenSpaceParams2;
            static /*0x9c*/ int _LensFlareScreenSpaceParams3;
            static /*0xa0*/ int _LensFlareScreenSpaceParams4;
            static /*0xa4*/ int _LensFlareScreenSpaceParams5;
            static /*0xa8*/ bool s_SupportsLensFlare16bitsFormat;
            static /*0xa9*/ bool s_SupportsLensFlare32bitsFormat;

            static /*0x7b83798*/ LensFlareCommonSRP();
            static /*0x7b7c430*/ bool IsOcclusionRTCompatible();
            static /*0x7b7c4f4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetOcclusionRTFormat();
            static /*0x7b7c55c*/ void Initialize();
            static /*0x7b7c750*/ void Dispose();
            static /*0x7b7c828*/ UnityEngine.Rendering.LensFlareCommonSRP get_Instance();
            static /*0x7b7d030*/ float ShapeAttenuationPointLight();
            static /*0x7b7d038*/ float ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d05c*/ float ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, float spotAngle, float innerSpotPercent01);
            static /*0x7b7d108*/ float ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d130*/ float ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d1d0*/ float ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, float lightWidth, UnityEngine.Camera cam);
            static /*0x7b7d6e8*/ float ShapeAttenuateForwardLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d708*/ float ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d7a0*/ float ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b7d838*/ bool IsLensFlareSRPHidden(UnityEngine.Camera cam, UnityEngine.Rendering.LensFlareComponentSRP comp, UnityEngine.Rendering.LensFlareDataSRP data);
            static /*0x7b7d95c*/ UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, UnityEngine.Vector2 positionOffset, bool autoRotate);
            static /*0x7b7db74*/ UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, float position, float globalCos0, float globalSin0, UnityEngine.Vector2 vAspectRatio);
            static /*0x7b7dbac*/ UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, bool isLocalLight, bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS);
            static /*0x7b7dcf0*/ UnityEngine.Vector3 WorldToViewportLocal(bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS);
            static /*0x7b7dd68*/ UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS);
            static /*0x7b7de48*/ bool IsCloudLayerOpacityNeeded(UnityEngine.Camera cam);
            static /*0x7b7e0e8*/ void SetOcclusionPermutation(UnityEngine.Rendering.CommandBuffer cmd, bool useFogOpacityOcclusion, int _FlareSunOcclusionTex, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b7e20c*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x7b7e4b0*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b7e368*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x7b7f5f0*/ bool ForceSingleElement(UnityEngine.Rendering.LensFlareDataElementSRP element);
            static /*0x7b7e604*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b7f854*/ void ProcessLensFlareSRPElementsSingle(UnityEngine.Rendering.LensFlareDataElementSRP element, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x7b80ef8*/ void ProcessLensFlareSRPElements(ref UnityEngine.Rendering.LensFlareDataElementSRP[] elements, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x7b81274*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x7b814ac*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x7b82680*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x7b81698*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x7b82858*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x7b833f8*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, int _LensFlareScreenSpaceBloomMipTexture, int _LensFlareScreenSpaceResultTexture, int _LensFlareScreenSpaceSpectralLut, int _LensFlareScreenSpaceStreakTex, int _LensFlareScreenSpaceMipLevel, int _LensFlareScreenSpaceTintColor, int _LensFlareScreenSpaceParams1, int _LensFlareScreenSpaceParams2, int _LensFlareScreenSpaceParams3, int _LensFlareScreenSpaceParams4, int _LensFlareScreenSpaceParams5, bool debugView);
            static /*0x7b82a9c*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x7b7f62c*/ UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance);
            static /*0x7b83660*/ UnityEngine.Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView);
            static /*0x7b836a0*/ UnityEngine.Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d);
            static /*0x7b83764*/ UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, float d);
            static /*0x7b83e04*/ float <ShapeAttenuationAreaTubeLight>g__Fpo|57_0(float d, float l);
            static /*0x7b83e44*/ float <ShapeAttenuationAreaTubeLight>g__Fwt|57_1(float d, float l);
            static /*0x7b7d400*/ float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|57_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
            static /*0x7b810cc*/ UnityEngine.Vector2 <ProcessLensFlareSRPElementsSingle>g__ComputeLocalSize|74_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, ref UnityEngine.Rendering.LensFlareCommonSRP.<> );
            static /*0x7b8126c*/ float <ProcessLensFlareSRPElementsSingle>g__RandomRange|74_1(float min, float max);
            /*0x7b7c428*/ LensFlareCommonSRP();
            /*0x7b7c9b4*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo> get_Data();
            /*0x7b7ca0c*/ bool IsEmpty();
            /*0x7b7ca90*/ int GetNextAvailableIndex();
            /*0x7b7cba4*/ void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData);
            /*0x7b7cdfc*/ void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data);

            class LensFlareCompInfo
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.Rendering.LensFlareComponentSRP comp;

                /*0x7b7cdc4*/ LensFlareCompInfo(int idx, UnityEngine.Rendering.LensFlareComponentSRP cmp);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP newData;

                /*0x7b7cdbc*/ <>c__DisplayClass50_0();
                /*0x7b83e5c*/ bool <AddData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP data;

                /*0x7b7d028*/ <>c__DisplayClass51_0();
                /*0x7b83ecc*/ bool <RemoveData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            struct <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Vector2 screenPos;
                /*0x18*/ float position;
                /*0x1c*/ float globalCos0;
                /*0x20*/ float globalSin0;
                /*0x24*/ UnityEngine.Vector2 vScreenRatio;
                /*0x30*/ UnityEngine.Rendering.LensFlareDataElementSRP element;
                /*0x38*/ float combinedScale;
                /*0x3c*/ float usedAspectRatio;
            }
        }

        class LensFlareComponentSRP : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ float sCelestialAngularRadius;
            /*0x20*/ UnityEngine.Rendering.LensFlareDataSRP m_LensFlareData;
            /*0x28*/ UnityEngine.Rendering.LensFlareComponentSRP.Version version;
            /*0x2c*/ float intensity;
            /*0x30*/ float maxAttenuationDistance;
            /*0x34*/ float maxAttenuationScale;
            /*0x38*/ UnityEngine.AnimationCurve distanceAttenuationCurve;
            /*0x40*/ UnityEngine.AnimationCurve scaleByDistanceCurve;
            /*0x48*/ bool attenuationByLightShape;
            /*0x50*/ UnityEngine.AnimationCurve radialScreenAttenuationCurve;
            /*0x58*/ bool useOcclusion;
            /*0x59*/ bool useBackgroundCloudOcclusion;
            /*0x5a*/ bool environmentOcclusion;
            /*0x5b*/ bool useWaterOcclusion;
            /*0x5c*/ float occlusionRadius;
            /*0x60*/ uint sampleCount;
            /*0x64*/ float occlusionOffset;
            /*0x68*/ float scale;
            /*0x6c*/ bool allowOffScreen;
            /*0x6d*/ bool volumetricCloudOcclusion;
            /*0x70*/ UnityEngine.Rendering.TextureCurve occlusionRemapCurve;
            /*0x78*/ UnityEngine.Light lightOverride;

            static /*0x7b84504*/ LensFlareComponentSRP();
            /*0x7b84160*/ LensFlareComponentSRP();
            /*0x7b83f3c*/ UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData();
            /*0x7b83f44*/ void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value);
            /*0x7b7f78c*/ float celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam);
            /*0x7b84034*/ void Awake();
            /*0x7b84038*/ void OnEnable();
            /*0x7b840e4*/ void OnDisable();
            /*0x7b83f60*/ void OnValidate();
            /*0x7b84144*/ void OnDestroy();

            enum Version
            {
                Initial = 0,
            }
        }

        enum SRPLensFlareBlendMode
        {
            Additive = 0,
            Screen = 1,
            Premultiply = 2,
            Lerp = 3,
        }

        enum SRPLensFlareDistribution
        {
            Uniform = 0,
            Curve = 1,
            Random = 2,
        }

        enum SRPLensFlareType
        {
            Image = 0,
            Circle = 1,
            Polygon = 2,
            Ring = 3,
            LensFlareDataSRP = 4,
        }

        enum SRPLensFlareColorType
        {
            Constant = 0,
            RadialGradient = 1,
            AngularGradient = 2,
        }

        class LensFlareDataElementSRP
        {
            /*0x10*/ UnityEngine.Rendering.LensFlareDataSRP lensFlareDataSRP;
            /*0x18*/ bool visible;
            /*0x1c*/ float position;
            /*0x20*/ UnityEngine.Vector2 positionOffset;
            /*0x28*/ float angularOffset;
            /*0x2c*/ UnityEngine.Vector2 translationScale;
            /*0x34*/ float ringThickness;
            /*0x38*/ float hoopFactor;
            /*0x3c*/ float noiseAmplitude;
            /*0x40*/ int noiseFrequency;
            /*0x44*/ float noiseSpeed;
            /*0x48*/ float shapeCutOffSpeed;
            /*0x4c*/ float shapeCutOffRadius;
            /*0x50*/ float m_LocalIntensity;
            /*0x58*/ UnityEngine.Texture lensFlareTexture;
            /*0x60*/ float uniformScale;
            /*0x64*/ UnityEngine.Vector2 sizeXY;
            /*0x6c*/ bool allowMultipleElement;
            /*0x70*/ int m_Count;
            /*0x74*/ bool preserveAspectRatio;
            /*0x78*/ float rotation;
            /*0x7c*/ UnityEngine.Rendering.SRPLensFlareColorType tintColorType;
            /*0x80*/ UnityEngine.Color tint;
            /*0x90*/ UnityEngine.Rendering.TextureGradient tintGradient;
            /*0x98*/ UnityEngine.Rendering.SRPLensFlareBlendMode blendMode;
            /*0x9c*/ bool autoRotate;
            /*0xa0*/ UnityEngine.Rendering.SRPLensFlareType flareType;
            /*0xa4*/ bool modulateByLightColor;
            /*0xa5*/ bool isFoldOpened;
            /*0xa8*/ UnityEngine.Rendering.SRPLensFlareDistribution distribution;
            /*0xac*/ float lengthSpread;
            /*0xb0*/ UnityEngine.AnimationCurve positionCurve;
            /*0xb8*/ UnityEngine.AnimationCurve scaleCurve;
            /*0xc0*/ int seed;
            /*0xc8*/ UnityEngine.Gradient colorGradient;
            /*0xd0*/ float m_IntensityVariation;
            /*0xd4*/ UnityEngine.Vector2 positionVariation;
            /*0xdc*/ float scaleVariation;
            /*0xe0*/ float rotationVariation;
            /*0xe4*/ bool enableRadialDistortion;
            /*0xe8*/ UnityEngine.Vector2 targetSizeDistortion;
            /*0xf0*/ UnityEngine.AnimationCurve distortionCurve;
            /*0xf8*/ bool distortionRelativeToCenter;
            /*0xfc*/ float m_FallOff;
            /*0x100*/ float m_EdgeOffset;
            /*0x104*/ int m_SideCount;
            /*0x108*/ float m_SdfRoundness;
            /*0x10c*/ bool inverseSDF;
            /*0x110*/ float uniformAngle;
            /*0x118*/ UnityEngine.AnimationCurve uniformAngleCurve;

            /*0x7b84554*/ LensFlareDataElementSRP();
            /*0x7b84e5c*/ UnityEngine.Rendering.LensFlareDataElementSRP Clone();
            /*0x7b8535c*/ float get_localIntensity();
            /*0x7b84dc4*/ void set_localIntensity(float value);
            /*0x7b85364*/ int get_count();
            /*0x7b84dd4*/ void set_count(int value);
            /*0x7b8536c*/ float get_intensityVariation();
            /*0x7b84de4*/ void set_intensityVariation(float value);
            /*0x7b85374*/ float get_fallOff();
            /*0x7b84df4*/ void set_fallOff(float value);
            /*0x7b8537c*/ float get_edgeOffset();
            /*0x7b84e10*/ void set_edgeOffset(float value);
            /*0x7b85384*/ int get_sideCount();
            /*0x7b84e48*/ void set_sideCount(int value);
            /*0x7b8538c*/ float get_sdfRoundness();
            /*0x7b84e2c*/ void set_sdfRoundness(float value);
        }

        class LensFlareDataSRP : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.LensFlareDataElementSRP[] elements;

            /*0x7b85394*/ LensFlareDataSRP();
            /*0x7b853b8*/ bool HasAModulateByLightColorElement();
        }

        enum LensFlareOcclusionPermutation
        {
            Depth = 1,
            FogOpacity = 4,
        }

        class DebugDisplaySettingsRenderGraph : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x7b8541c*/ DebugDisplaySettingsRenderGraph();
            /*0x7b855e0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();
            /*0x7b8598c*/ bool get_AreAnySettingsActive();

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x7b85630*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsRenderGraph _);
                /*0x7b85b58*/ string get_PanelName();
            }
        }

        class RenderGraphGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphGlobalSettings.Version m_version;
            /*0x14*/ bool m_EnableCompilationCaching;
            /*0x15*/ bool m_EnableValidityChecks;

            /*0x7b85ca0*/ RenderGraphGlobalSettings();
            /*0x7b85b98*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x7b85ba0*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7b85ba8*/ bool get_enableCompilationCaching();
            /*0x7b85bb0*/ void set_enableCompilationCaching(bool value);
            /*0x7b85c24*/ bool get_enableValidityChecks();
            /*0x7b85c2c*/ void set_enableValidityChecks(bool value);

            enum Version
            {
                Initial = 0,
                Count = 1,
                Last = 0,
            }
        }

        interface ICloudBackground
        {
            /*0x3813ffc*/ bool IsCloudBackgroundUsable();
        }

        interface IVolumetricCloud
        {
            /*0x3813ffc*/ bool IsVolumetricCloudUsable();
        }

        class RenderPipelineGlobalSettings<TGlobalRenderPipelineSettings, TRenderPipeline> : UnityEngine.Rendering.RenderPipelineGlobalSettings
        {
            static /*0x0*/ System.Lazy<TGlobalRenderPipelineSettings> s_Instance;

            static /*0x383e7a0*/ RenderPipelineGlobalSettings();
            static /*0x3910ae8*/ TGlobalRenderPipelineSettings get_instance();
            /*0x38159dc*/ RenderPipelineGlobalSettings();
            /*0x38159dc*/ void Reset();

            class <>c<TGlobalRenderPipelineSettings, TRenderPipeline>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderPipelineGlobalSettings.<>c<TGlobalRenderPipelineSettings, TRenderPipeline> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3910ae8*/ TGlobalRenderPipelineSettings <.cctor>b__5_0();
            }
        }

        class RenderPipelineGraphicsSettingsContainer : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Rendering.RenderPipelineGraphicsSettingsCollection m_RuntimeSettings;

            /*0x7b85cd4*/ RenderPipelineGraphicsSettingsContainer();
            /*0x7b85cb0*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x7b85ccc*/ void OnBeforeSerialize();
            /*0x7b85cd0*/ void OnAfterDeserialize();
        }

        class RenderPipelineResources : UnityEngine.ScriptableObject
        {
            /*0x7b85d54*/ RenderPipelineResources();
            /*0x7b85d40*/ string get_packagePath();
            /*0x7b85d48*/ string get_packagePath_Internal();
        }

        interface IDefaultVolumeProfileAsset : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x38148bc*/ UnityEngine.Rendering.VolumeProfile get_defaultVolumeProfile();
            /*0x3816710*/ void set_defaultVolumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        interface IDefaultVolumeProfileSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x7b85d5c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x38148bc*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
            /*0x3816710*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        class IncludeAdditionalRPAssets : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.IncludeAdditionalRPAssets.Version m_version;
            /*0x14*/ bool m_IncludeReferencedInScenes;
            /*0x15*/ bool m_IncludeAssetsByLabel;
            /*0x18*/ string m_LabelToInclude;

            /*0x7b85ee0*/ IncludeAdditionalRPAssets();
            /*0x7b85d64*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7b85d6c*/ bool get_includeReferencedInScenes();
            /*0x7b85d74*/ void set_includeReferencedInScenes(bool value);
            /*0x7b85de8*/ bool get_includeAssetsByLabel();
            /*0x7b85df0*/ void set_includeAssetsByLabel(bool value);
            /*0x7b85e64*/ string get_labelToInclude();
            /*0x7b85e6c*/ void set_labelToInclude(string value);

            enum Version
            {
                Initial = 0,
                Count = 1,
                Last = 0,
            }
        }

        enum ShaderVariantLogLevel
        {
            Disabled = 0,
            OnlySRPShaders = 1,
            AllShaders = 2,
        }

        class ShaderStrippingSetting : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.ShaderStrippingSetting.Version m_Version;
            /*0x14*/ bool m_ExportShaderVariants;
            /*0x18*/ UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;
            /*0x1c*/ bool m_StripRuntimeDebugShaders;

            /*0x7b8606c*/ ShaderStrippingSetting();
            /*0x7b85ee8*/ int get_version();
            /*0x7b85ef0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x7b85ef8*/ bool get_exportShaderVariants();
            /*0x7b85f00*/ void set_exportShaderVariants(bool value);
            /*0x7b85f74*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x7b85f7c*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x7b85ff0*/ bool get_stripRuntimeDebugShaders();
            /*0x7b85ff8*/ void set_stripRuntimeDebugShaders(bool value);

            enum Version
            {
                Initial = 0,
            }
        }

        enum PackingRules
        {
            Exact = 0,
            Aggressive = 1,
        }

        enum FieldPacking
        {
            NoPacking = 0,
            R11G11B10 = 1,
            PackedFloat = 2,
            PackedUint = 3,
        }

        enum FieldPrecision
        {
            Half = 0,
            Real = 1,
            Default = 2,
        }

        class GenerateHLSL : System.Attribute
        {
            /*0x10*/ UnityEngine.Rendering.PackingRules packingRules;
            /*0x14*/ bool containsPackedFields;
            /*0x15*/ bool needAccessors;
            /*0x16*/ bool needSetters;
            /*0x17*/ bool needParamDebug;
            /*0x18*/ int paramDefinesStart;
            /*0x1c*/ bool omitStructDeclaration;
            /*0x1d*/ bool generateCBuffer;
            /*0x20*/ int constantRegister;
            /*0x28*/ string sourcePath;

            /*0x7b86080*/ GenerateHLSL(UnityEngine.Rendering.PackingRules rules, bool needAccessors, bool needSetters, bool needParamDebug, int paramDefinesStart, bool omitStructDeclaration, bool containsPackedFields, bool generateCBuffer, int constantRegister, string sourcePath);
        }

        class SurfaceDataAttributes : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ bool isDirection;
            /*0x19*/ bool sRGBDisplay;
            /*0x1c*/ UnityEngine.Rendering.FieldPrecision precision;
            /*0x20*/ bool checkIsNormalized;
            /*0x28*/ string preprocessor;

            /*0x7b86120*/ SurfaceDataAttributes(string displayName, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
            /*0x7b86208*/ SurfaceDataAttributes(string[] displayNames, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
        }

        class HLSLArray : System.Attribute
        {
            /*0x10*/ int arraySize;
            /*0x18*/ System.Type elementType;

            /*0x7b8627c*/ HLSLArray(int arraySize, System.Type elementType);
        }

        class PackingAttribute : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ float[] range;
            /*0x20*/ UnityEngine.Rendering.FieldPacking packingScheme;
            /*0x24*/ int offsetInSource;
            /*0x28*/ int sizeInBits;
            /*0x2c*/ bool isDirection;
            /*0x2d*/ bool sRGBDisplay;
            /*0x2e*/ bool checkIsNormalized;
            /*0x30*/ string preprocessor;

            /*0x7b862b4*/ PackingAttribute(string[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
            /*0x7b863d0*/ PackingAttribute(string displayName, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
        }

        struct ShaderGenUInt4
        {
        }

        class Hammersley
        {
            static /*0x0*/ float[] k_Hammersley2dSeq16;
            static /*0x8*/ float[] k_Hammersley2dSeq32;
            static /*0x10*/ float[] k_Hammersley2dSeq64;
            static /*0x18*/ float[] k_Hammersley2dSeq256;
            static /*0x20*/ int s_hammersley2DSeq16Id;
            static /*0x24*/ int s_hammersley2DSeq32Id;
            static /*0x28*/ int s_hammersley2DSeq64Id;
            static /*0x2c*/ int s_hammersley2DSeq256Id;

            static /*0x7b86a18*/ Hammersley();
            static /*0x7b86528*/ void Initialize();
            static /*0x7b868c4*/ void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs);

            struct Hammersley2dSeq16
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq16.<hammersley2dSeq16> hammersley2dSeq16;

                struct <hammersley2dSeq16>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq32
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq32.<hammersley2dSeq32> hammersley2dSeq32;

                struct <hammersley2dSeq32>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq64
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq64.<hammersley2dSeq64> hammersley2dSeq64;

                struct <hammersley2dSeq64>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            struct Hammersley2dSeq256
            {
                /*0x10*/ UnityEngine.Rendering.Hammersley.Hammersley2dSeq256.<hammersley2dSeq256> hammersley2dSeq256;

                struct <hammersley2dSeq256>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }
        }

        interface ISTPEnabledRenderPipeline
        {
            /*0x3813ffc*/ bool get_isStpUsed();
        }

        class STP
        {
            static int kNumDebugViews = 6;
            static int kMaxPerViewConfigs = 2;
            static int kNumHistoryTextureTypes = 4;
            static int kTotalSetupViewConstantsCount = 16;
            static /*0x0*/ UnityEngine.GUIContent[] s_DebugViewDescriptions;
            static /*0x8*/ int[] s_DebugViewIndices;
            static /*0x10*/ UnityEngine.Rendering.STP.PerViewConfig[] s_PerViewConfigs;
            static /*0x18*/ int kQualcommVendorId;

            static /*0x7b8a114*/ STP();
            static /*0x7b86c50*/ bool IsSupported();
            static /*0x7b86c7c*/ UnityEngine.Vector2 Jit16(int frameIndex);
            static /*0x7b86cc0*/ UnityEngine.GUIContent[] get_debugViewDescriptions();
            static /*0x7b86d18*/ int[] get_debugViewIndices();
            static /*0x7b86d70*/ UnityEngine.Rendering.STP.PerViewConfig[] get_perViewConfigs();
            static /*0x7b86dc8*/ void set_perViewConfigs(UnityEngine.Rendering.STP.PerViewConfig[] value);
            static /*0x7b86e28*/ UnityEngine.Hash128 ComputeHistoryHash(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
            static /*0x7b86edc*/ UnityEngine.Vector2Int CalculateConvergenceTextureSize(UnityEngine.Vector2Int historyTextureSize);
            static /*0x7b86f60*/ float CalculateMotionScale(float deltaTime, float lastDeltaTime);
            static /*0x7b86fec*/ UnityEngine.Matrix4x4 ExtractRotation(UnityEngine.Matrix4x4 input);
            static /*0x7b87074*/ int PackVector2ToInt(UnityEngine.Vector2 value);
            static /*0x7b870ac*/ void PopulateConstantData(ref UnityEngine.Rendering.STP.Config config, ref UnityEngine.Rendering.STP.StpConstantBufferData constants);
            static /*0x7b87f10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseTexture(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder, UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
            static /*0x7b87fcc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.STP.Config config);

            struct PerViewConfig
            {
                /*0x10*/ UnityEngine.Matrix4x4 currentProj;
                /*0x50*/ UnityEngine.Matrix4x4 lastProj;
                /*0x90*/ UnityEngine.Matrix4x4 lastLastProj;
                /*0xd0*/ UnityEngine.Matrix4x4 currentView;
                /*0x110*/ UnityEngine.Matrix4x4 lastView;
                /*0x150*/ UnityEngine.Matrix4x4 lastLastView;
            }

            struct Config
            {
                /*0x10*/ UnityEngine.Texture2D noiseTexture;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputStencil;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                /*0x78*/ UnityEngine.Rendering.STP.HistoryContext historyContext;
                /*0x80*/ bool enableHwDrs;
                /*0x81*/ bool enableTexArray;
                /*0x82*/ bool enableMotionScaling;
                /*0x84*/ float nearPlane;
                /*0x88*/ float farPlane;
                /*0x8c*/ int frameIndex;
                /*0x90*/ bool hasValidHistory;
                /*0x94*/ int stencilMask;
                /*0x98*/ int debugViewIndex;
                /*0x9c*/ float deltaTime;
                /*0xa0*/ float lastDeltaTime;
                /*0xa4*/ UnityEngine.Vector2Int currentImageSize;
                /*0xac*/ UnityEngine.Vector2Int priorImageSize;
                /*0xb4*/ UnityEngine.Vector2Int outputImageSize;
                /*0xbc*/ int numActiveViews;
                /*0xc0*/ UnityEngine.Rendering.STP.PerViewConfig[] perViewConfigs;
            }

            enum HistoryTextureType
            {
                DepthMotion = 0,
                Luma = 1,
                Convergence = 2,
                Feedback = 3,
                Count = 4,
            }

            struct HistoryUpdateInfo
            {
                /*0x10*/ UnityEngine.Vector2Int preUpscaleSize;
                /*0x18*/ UnityEngine.Vector2Int postUpscaleSize;
                /*0x20*/ bool useHwDrs;
                /*0x21*/ bool useTexArray;
            }

            class HistoryContext : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.RTHandle[] m_textures;
                /*0x18*/ UnityEngine.Hash128 m_hash;

                /*0x7b8a958*/ HistoryContext();
                /*0x7b8a53c*/ bool Update(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
                /*0x7b8a0dc*/ UnityEngine.Rendering.RTHandle GetCurrentHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x7b8a0a0*/ UnityEngine.Rendering.RTHandle GetPreviousHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x7b8a8bc*/ void Dispose();
            }

            enum StpSetupPerViewConstants
            {
                Count = 8,
            }

            struct StpConstantBufferData
            {
                /*0x10*/ UnityEngine.Vector4 _StpCommonConstant;
                /*0x20*/ UnityEngine.Vector4 _StpSetupConstants0;
                /*0x30*/ UnityEngine.Vector4 _StpSetupConstants1;
                /*0x40*/ UnityEngine.Vector4 _StpSetupConstants2;
                /*0x50*/ UnityEngine.Vector4 _StpSetupConstants3;
                /*0x60*/ UnityEngine.Vector4 _StpSetupConstants4;
                /*0x70*/ UnityEngine.Vector4 _StpSetupConstants5;
                /*0x80*/ UnityEngine.Rendering.STP.StpConstantBufferData.<_StpSetupPerViewConstants> _StpSetupPerViewConstants;
                /*0x180*/ UnityEngine.Vector4 _StpDilConstants0;
                /*0x190*/ UnityEngine.Vector4 _StpTaaConstants0;
                /*0x1a0*/ UnityEngine.Vector4 _StpTaaConstants1;
                /*0x1b0*/ UnityEngine.Vector4 _StpTaaConstants2;
                /*0x1c0*/ UnityEngine.Vector4 _StpTaaConstants3;

                struct <_StpSetupPerViewConstants>e__FixedBuffer
                {
                    /*0x10*/ float FixedElementField;
                }
            }

            class ShaderResources
            {
                static /*0x0*/ int _StpConstantBufferData;
                static /*0x4*/ int _StpBlueNoiseIn;
                static /*0x8*/ int _StpDebugOut;
                static /*0xc*/ int _StpInputColor;
                static /*0x10*/ int _StpInputDepth;
                static /*0x14*/ int _StpInputMotion;
                static /*0x18*/ int _StpInputStencil;
                static /*0x1c*/ int _StpIntermediateColor;
                static /*0x20*/ int _StpIntermediateConvergence;
                static /*0x24*/ int _StpIntermediateWeights;
                static /*0x28*/ int _StpPriorLuma;
                static /*0x2c*/ int _StpLuma;
                static /*0x30*/ int _StpPriorDepthMotion;
                static /*0x34*/ int _StpDepthMotion;
                static /*0x38*/ int _StpPriorFeedback;
                static /*0x3c*/ int _StpFeedback;
                static /*0x40*/ int _StpPriorConvergence;
                static /*0x44*/ int _StpConvergence;
                static /*0x48*/ int _StpOutput;

                static /*0x7b8a9cc*/ ShaderResources();
            }

            class ShaderKeywords
            {
                static /*0x0*/ string EnableDebugMode;
                static /*0x8*/ string EnableLargeKernel;
                static /*0x10*/ string EnableStencilResponsive;
                static /*0x18*/ string DisableTexture2DXArray;

                static /*0x7b8ad6c*/ ShaderKeywords();
            }

            class RuntimeResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.ComputeShader m_setupCS;
                /*0x18*/ UnityEngine.ComputeShader m_preTaaCS;
                /*0x20*/ UnityEngine.ComputeShader m_taaCS;

                /*0x7b8afdc*/ RuntimeResources();
                /*0x7b8ae60*/ int get_version();
                /*0x7b8ae68*/ UnityEngine.ComputeShader get_setupCS();
                /*0x7b8ae70*/ void set_setupCS(UnityEngine.ComputeShader value);
                /*0x7b8aee4*/ UnityEngine.ComputeShader get_preTaaCS();
                /*0x7b8aeec*/ void set_preTaaCS(UnityEngine.ComputeShader value);
                /*0x7b8af60*/ UnityEngine.ComputeShader get_taaCS();
                /*0x7b8af68*/ void set_taaCS(UnityEngine.ComputeShader value);
            }

            enum ProfileId
            {
                StpSetup = 0,
                StpPreTaa = 1,
                StpTaa = 2,
            }

            class SetupData
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelIndex;
                /*0x1c*/ int viewCount;
                /*0x20*/ UnityEngine.Vector2Int dispatchSize;
                /*0x28*/ UnityEngine.Rendering.STP.StpConstantBufferData constantBufferData;
                /*0x1e8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle noiseTexture;
                /*0x1f8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView;
                /*0x208*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputColor;
                /*0x218*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputDepth;
                /*0x228*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputMotion;
                /*0x238*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle inputStencil;
                /*0x248*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateColor;
                /*0x258*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateConvergence;
                /*0x268*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle priorDepthMotion;
                /*0x278*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthMotion;
                /*0x288*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle priorLuma;
                /*0x298*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle luma;
                /*0x2a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle priorFeedback;
                /*0x2b8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle priorConvergence;

                /*0x7b8afe4*/ SetupData();
            }

            class PreTaaData
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelIndex;
                /*0x1c*/ int viewCount;
                /*0x20*/ UnityEngine.Vector2Int dispatchSize;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle noiseTexture;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateConvergence;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateWeights;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle luma;
                /*0x78*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle convergence;

                /*0x7b8afec*/ PreTaaData();
            }

            class TaaData
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelIndex;
                /*0x1c*/ int viewCount;
                /*0x20*/ UnityEngine.Vector2Int dispatchSize;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle noiseTexture;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle debugView;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateColor;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle intermediateWeights;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle priorFeedback;
                /*0x78*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthMotion;
                /*0x88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle convergence;
                /*0x98*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle feedback;
                /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle output;

                /*0x7b8aff4*/ TaaData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.STP.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.SetupData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.PreTaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_1;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.TaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_2;

                static /*0x7b8affc*/ <>c();
                /*0x7b8b064*/ <>c();
                /*0x7b8b06c*/ void <Execute>b__38_0(UnityEngine.Rendering.STP.SetupData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7b8b5e0*/ void <Execute>b__38_1(UnityEngine.Rendering.STP.PreTaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7b8b8b8*/ void <Execute>b__38_2(UnityEngine.Rendering.STP.TaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
            }
        }

        class BufferedRTHandleSystem : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RTHandle[]> m_RTHandles;
            /*0x18*/ UnityEngine.Rendering.RTHandleSystem m_RTHandleSystem;
            /*0x20*/ bool m_DisposedValue;

            /*0x7b8cbd4*/ BufferedRTHandleSystem();
            /*0x7b8bc08*/ int get_maxWidth();
            /*0x7b8bc24*/ int get_maxHeight();
            /*0x7b8bc40*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b8bc68*/ UnityEngine.Rendering.RTHandle GetFrameRT(int bufferId, int frameIndex);
            /*0x7b8bd20*/ void ClearBuffers(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b8bf24*/ void AllocBuffer(int bufferId, System.Func<UnityEngine.Rendering.RTHandleSystem, int, UnityEngine.Rendering.RTHandle> allocator, int bufferCount);
            /*0x7b8c0c4*/ void AllocBuffer(int bufferId, int bufferCount, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            /*0x7b8c470*/ void ReleaseBuffer(int bufferId);
            /*0x7b8c560*/ void SwapAndSetReferenceSize(int width, int height);
            /*0x7b8c8a4*/ void ResetReferenceSize(int width, int height);
            /*0x7b8c8c0*/ int GetNumFramesAllocated(int bufferId);
            /*0x7b8c958*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
            /*0x7b8c59c*/ void Swap();
            /*0x7b8c98c*/ void Dispose(bool disposing);
            /*0x7b8cbcc*/ void Dispose();
            /*0x7b8c9e8*/ void ReleaseAll();
            /*0x7b8c318*/ UnityEngine.Rendering.RTHandle <AllocBuffer>g__Alloc|12_0(ref UnityEngine.RenderTextureDescriptor d, UnityEngine.FilterMode fMode, UnityEngine.TextureWrapMode wMode, bool isShadow, int aniso, float mipBias, string n, ref UnityEngine.Rendering.BufferedRTHandleSystem.<> );

            struct <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Rendering.BufferedRTHandleSystem <>4__this;
                /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
            }
        }

        enum DepthBits
        {
            None = 0,
            Depth8 = 8,
            Depth16 = 16,
            Depth24 = 24,
            Depth32 = 32,
        }

        enum MSAASamples
        {
            None = 1,
            MSAA2x = 2,
            MSAA4x = 4,
            MSAA8x = 8,
        }

        class PowerOfTwoTextureAtlas : UnityEngine.Rendering.Texture2DAtlas
        {
            static float k_MipmapFactorApprox = 1.3300000429153442;
            /*0x48*/ int m_MipPadding;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> m_RequestedTextures;

            static /*0x7b8cf34*/ UnityEngine.Vector4 GetPayloadScaleOffset(ref UnityEngine.Vector2 textureSize, ref UnityEngine.Vector2 paddingSize, ref UnityEngine.Vector4 scaleOffset);
            static /*0x7b8e0c0*/ long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x7b8e188*/ int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x7b8cc94*/ PowerOfTwoTextureAtlas(int size, int mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, string name, bool useMipMap);
            /*0x7b8cd9c*/ int get_mipPadding();
            /*0x7b8cda4*/ int GetTexturePadding();
            /*0x7b8cdd4*/ UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b8cf6c*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType);
            /*0x7b8d340*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b8d44c*/ void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b8d558*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b8d664*/ void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b8d770*/ void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, ref int width, ref int height);
            /*0x7b8cea8*/ UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture);
            /*0x7b8d7bc*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x7b8d9c8*/ void ResetRequestedTexture();
            /*0x7b8da18*/ bool ReserveSpace(UnityEngine.Texture texture);
            /*0x7b8da8c*/ bool ReserveSpace(UnityEngine.Texture texture, int width, int height);
            /*0x7b8dbf0*/ bool ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, int width, int height);
            /*0x7b8dac4*/ bool ReserveSpace(int id, int width, int height);
            /*0x7b8dc28*/ bool RelayoutEntries();

            enum BlitType
            {
                Padding = 0,
                PaddingMultiply = 1,
                OctahedralPadding = 2,
                OctahedralPaddingMultiply = 3,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.PowerOfTwoTextureAtlas.<> <>9;
                static /*0x8*/ System.Comparison<System.ValueTuple<int, UnityEngine.Vector2Int>> <>9__23_0;

                static /*0x7b8e264*/ <>c();
                /*0x7b8e2cc*/ <>c();
                /*0x7b8e2d4*/ int <RelayoutEntries>b__23_0(System.ValueTuple<int, UnityEngine.Vector2Int> c1, System.ValueTuple<int, UnityEngine.Vector2Int> c2);
            }
        }

        struct RTHandleStaticHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandle s_RTHandleWrapper;

            static /*0x7b8e318*/ void SetRTHandleStaticWrapper(UnityEngine.Rendering.RenderTargetIdentifier rtId);
            static /*0x7b8e500*/ void SetRTHandleUserManagedWrapper(ref UnityEngine.Rendering.RTHandle rtWrapper, UnityEngine.Rendering.RenderTargetIdentifier rtId);
        }

        class RTHandle
        {
            /*0x10*/ UnityEngine.Rendering.RTHandleSystem m_Owner;
            /*0x18*/ UnityEngine.RenderTexture m_RT;
            /*0x20*/ UnityEngine.Texture m_ExternalTexture;
            /*0x28*/ UnityEngine.Rendering.RenderTargetIdentifier m_NameID;
            /*0x50*/ bool m_EnableMSAA;
            /*0x51*/ bool m_EnableRandomWrite;
            /*0x52*/ bool m_EnableHWDynamicScale;
            /*0x53*/ bool m_RTHasOwnership;
            /*0x58*/ string m_Name;
            /*0x60*/ bool m_UseCustomHandleScales;
            /*0x64*/ UnityEngine.Rendering.RTHandleProperties m_CustomHandleProperties;
            /*0x94*/ UnityEngine.Vector2 <scaleFactor>k__BackingField;
            /*0xa0*/ UnityEngine.Rendering.ScaleFunc scaleFunc;
            /*0xa8*/ bool <useScaling>k__BackingField;
            /*0xac*/ UnityEngine.Vector2Int <referenceSize>k__BackingField;

            static /*0x7b8e66c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x7b8e698*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x7b8e718*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            /*0x7b8e634*/ RTHandle(UnityEngine.Rendering.RTHandleSystem owner);
            /*0x7b8e560*/ void SetCustomHandleProperties(ref UnityEngine.Rendering.RTHandleProperties properties);
            /*0x7b8e580*/ void ClearCustomHandleProperties();
            /*0x7b8e588*/ UnityEngine.Vector2 get_scaleFactor();
            /*0x7b8e590*/ void set_scaleFactor(UnityEngine.Vector2 value);
            /*0x7b8e598*/ bool get_useScaling();
            /*0x7b8e5a0*/ void set_useScaling(bool value);
            /*0x7b8e5ac*/ UnityEngine.Vector2Int get_referenceSize();
            /*0x7b8e5b4*/ void set_referenceSize(UnityEngine.Vector2Int value);
            /*0x7b8e5bc*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b8e5fc*/ UnityEngine.RenderTexture get_rt();
            /*0x7b8e604*/ UnityEngine.Texture get_externalTexture();
            /*0x7b8e60c*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
            /*0x7b8e624*/ string get_name();
            /*0x7b8e62c*/ bool get_isMSAAEnabled();
            /*0x7b8e724*/ void SetRenderTexture(UnityEngine.RenderTexture rt, bool transferOwnership);
            /*0x7b8e798*/ void SetTexture(UnityEngine.Texture tex);
            /*0x7b8e4b4*/ void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex);
            /*0x7b8e808*/ int GetInstanceID();
            /*0x7b8e8c4*/ void Release();
            /*0x7b8ea7c*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int refSize);
            /*0x7b8ec70*/ UnityEngine.Vector2Int GetScaledSize();
            /*0x7b8ee64*/ void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, bool copyContents);
            /*0x7b8eee8*/ void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags);
            /*0x7b8eef0*/ void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, bool copyContents);
        }

        class RTHandles
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;

            static /*0x7b9219c*/ RTHandles();
            static /*0x7b8ef4c*/ int get_maxWidth();
            static /*0x7b8efb0*/ int get_maxHeight();
            static /*0x7b8f014*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            static /*0x7b8f088*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            static /*0x7b8f2c8*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            static /*0x7b8f380*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b8f644*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b8f850*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b8fb30*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b8fd48*/ UnityEngine.Rendering.RTHandle Alloc(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b8ffd0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
            static /*0x7b8ffdc*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b90294*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b90504*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b90770*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b90a30*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b90ccc*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b90f3c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b911a0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b912ec*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex);
            static /*0x7b9140c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex, bool transferOwnership);
            static /*0x7b8e420*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex);
            static /*0x7b915b8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, string name);
            static /*0x7b91744*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            static /*0x7b917b4*/ void Initialize(int width, int height);
            static /*0x7b91ad8*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            static /*0x7b91b94*/ void Release(UnityEngine.Rendering.RTHandle rth);
            static /*0x7b91c1c*/ void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
            static /*0x7b91df8*/ void SetReferenceSize(int width, int height);
            static /*0x7b91e7c*/ void ResetReferenceSize(int width, int height);
            static /*0x7b91f08*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        }

        class ScaleFunc : System.MulticastDelegate
        {
            /*0x7b922cc*/ ScaleFunc(object object, nint method);
            /*0x7b9236c*/ UnityEngine.Vector2Int Invoke(UnityEngine.Vector2Int size);
            /*0x7b92380*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2Int size, System.AsyncCallback callback, object object);
            /*0x7b92404*/ UnityEngine.Vector2Int EndInvoke(System.IAsyncResult result);
        }

        struct RTHandleProperties
        {
            /*0x10*/ UnityEngine.Vector2Int previousViewportSize;
            /*0x18*/ UnityEngine.Vector2Int previousRenderTargetSize;
            /*0x20*/ UnityEngine.Vector2Int currentViewportSize;
            /*0x28*/ UnityEngine.Vector2Int currentRenderTargetSize;
            /*0x30*/ UnityEngine.Vector4 rtHandleScale;
        }

        struct RTHandleAllocInfo
        {
            /*0x10*/ int <slices>k__BackingField;
            /*0x14*/ UnityEngine.Experimental.Rendering.GraphicsFormat <format>k__BackingField;
            /*0x18*/ UnityEngine.FilterMode <filterMode>k__BackingField;
            /*0x1c*/ UnityEngine.TextureWrapMode <wrapModeU>k__BackingField;
            /*0x20*/ UnityEngine.TextureWrapMode <wrapModeV>k__BackingField;
            /*0x24*/ UnityEngine.TextureWrapMode <wrapModeW>k__BackingField;
            /*0x28*/ UnityEngine.Rendering.TextureDimension <dimension>k__BackingField;
            /*0x2c*/ bool <enableRandomWrite>k__BackingField;
            /*0x2d*/ bool <useMipMap>k__BackingField;
            /*0x2e*/ bool <autoGenerateMips>k__BackingField;
            /*0x30*/ int <anisoLevel>k__BackingField;
            /*0x34*/ float <mipMapBias>k__BackingField;
            /*0x38*/ UnityEngine.Rendering.MSAASamples <msaaSamples>k__BackingField;
            /*0x3c*/ bool <bindTextureMS>k__BackingField;
            /*0x3d*/ bool <useDynamicScale>k__BackingField;
            /*0x40*/ UnityEngine.RenderTextureMemoryless <memoryless>k__BackingField;
            /*0x44*/ UnityEngine.VRTextureUsage <vrUsage>k__BackingField;
            /*0x48*/ string <name>k__BackingField;

            /*0x7b92560*/ RTHandleAllocInfo(string name);
            /*0x7b9242c*/ int get_slices();
            /*0x7b92434*/ void set_slices(int value);
            /*0x7b9243c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_format();
            /*0x7b92444*/ void set_format(UnityEngine.Experimental.Rendering.GraphicsFormat value);
            /*0x7b9244c*/ UnityEngine.FilterMode get_filterMode();
            /*0x7b92454*/ void set_filterMode(UnityEngine.FilterMode value);
            /*0x7b9245c*/ UnityEngine.TextureWrapMode get_wrapModeU();
            /*0x7b92464*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
            /*0x7b9246c*/ UnityEngine.TextureWrapMode get_wrapModeV();
            /*0x7b92474*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
            /*0x7b9247c*/ UnityEngine.TextureWrapMode get_wrapModeW();
            /*0x7b92484*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
            /*0x7b9248c*/ UnityEngine.Rendering.TextureDimension get_dimension();
            /*0x7b92494*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
            /*0x7b9249c*/ bool get_enableRandomWrite();
            /*0x7b924a4*/ void set_enableRandomWrite(bool value);
            /*0x7b924b0*/ bool get_useMipMap();
            /*0x7b924b8*/ void set_useMipMap(bool value);
            /*0x7b924c4*/ bool get_autoGenerateMips();
            /*0x7b924cc*/ void set_autoGenerateMips(bool value);
            /*0x7b924d8*/ int get_anisoLevel();
            /*0x7b924e0*/ void set_anisoLevel(int value);
            /*0x7b924e8*/ float get_mipMapBias();
            /*0x7b924f0*/ void set_mipMapBias(float value);
            /*0x7b924f8*/ UnityEngine.Rendering.MSAASamples get_msaaSamples();
            /*0x7b92500*/ void set_msaaSamples(UnityEngine.Rendering.MSAASamples value);
            /*0x7b92508*/ bool get_bindTextureMS();
            /*0x7b92510*/ void set_bindTextureMS(bool value);
            /*0x7b9251c*/ bool get_useDynamicScale();
            /*0x7b92524*/ void set_useDynamicScale(bool value);
            /*0x7b92530*/ UnityEngine.RenderTextureMemoryless get_memoryless();
            /*0x7b92538*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
            /*0x7b92540*/ UnityEngine.VRTextureUsage get_vrUsage();
            /*0x7b92548*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
            /*0x7b92550*/ string get_name();
            /*0x7b92558*/ void set_name(string value);
        }

        class RTHandleSystem : System.IDisposable
        {
            /*0x10*/ bool m_HardwareDynamicResRequested;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.RTHandle> m_AutoSizedRTs;
            /*0x20*/ UnityEngine.Rendering.RTHandle[] m_AutoSizedRTsArray;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.RTHandle> m_ResizeOnDemandRTs;
            /*0x30*/ UnityEngine.Rendering.RTHandleProperties m_RTHandleProperties;
            /*0x60*/ int m_MaxWidths;
            /*0x64*/ int m_MaxHeights;

            static /*0x7b93d6c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            /*0x7b92214*/ RTHandleSystem();
            /*0x7b9259c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b925b0*/ void Dispose();
            /*0x7b9182c*/ void Initialize(int width, int height);
            /*0x7b91b68*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            /*0x7b91c0c*/ void Release(UnityEngine.Rendering.RTHandle rth);
            /*0x7b8e99c*/ void Remove(UnityEngine.Rendering.RTHandle rth);
            /*0x7b91efc*/ void ResetReferenceSize(int width, int height);
            /*0x7b91e74*/ void SetReferenceSize(int width, int height);
            /*0x7b92788*/ void SetReferenceSize(int width, int height, bool reset);
            /*0x7b91f90*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(ref UnityEngine.Vector2Int viewportSize);
            /*0x7b91c84*/ void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
            /*0x7b92c30*/ void SwitchResizeMode(UnityEngine.Rendering.RTHandle rth, UnityEngine.Rendering.RTHandleSystem.ResizeMode mode);
            /*0x7b92d44*/ void DemandResize(UnityEngine.Rendering.RTHandle rth);
            /*0x7b930dc*/ int GetMaxWidth();
            /*0x7b930e4*/ int GetMaxHeight();
            /*0x7b925b8*/ void Dispose(bool disposing);
            /*0x7b92914*/ void Resize(int width, int height, bool sizeChanged);
            /*0x7b8f4d8*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b8f79c*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b8f9b8*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b930ec*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b93310*/ UnityEngine.RenderTexture CreateRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b8fbdc*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b8f100*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            /*0x7b903e4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b90138*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b9081c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b8f330*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            /*0x7b90b80*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b90e10*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b91244*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b939c8*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b93be0*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b91484*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture, bool transferOwnership);
            /*0x7b91354*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture);
            /*0x7b91544*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture);
            /*0x7b9165c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, string name);
            /*0x7b93ddc*/ string DumpRTInfo();
            /*0x7b93944*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);

            enum ResizeMode
            {
                Auto = 0,
                OnDemand = 1,
            }
        }

        class AtlasAllocator
        {
            /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_Root;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;
            /*0x20*/ bool powerOfTwoPadding;
            /*0x28*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> m_NodePool;

            /*0x7b94104*/ AtlasAllocator(int width, int height, bool potPadding);
            /*0x7b94348*/ bool Allocate(ref UnityEngine.Vector4 result, int width, int height);
            /*0x7b945dc*/ void Reset();

            class AtlasNode
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;
                /*0x18*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x7b9433c*/ AtlasNode();
                /*0x7b943cc*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding);
                /*0x7b94618*/ void Release(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.AtlasAllocator.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_1;

                static /*0x7b9470c*/ <>c();
                /*0x7b94774*/ <>c();
                /*0x7b9477c*/ void <.ctor>b__6_0(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
                /*0x7b94780*/ void <.ctor>b__6_1(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
            }
        }

        class Texture2DAtlas
        {
            static int kGPUTexInvalid = 0;
            static int kGPUTexValidMip0 = 1;
            static int kGPUTexValidMipAll = 2;
            static /*0x0*/ UnityEngine.Vector4 fullScaleOffset;
            static /*0x10*/ int s_MaxMipLevelPadding;
            /*0x10*/ UnityEngine.Rendering.RTHandle m_AtlasTexture;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;
            /*0x20*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;
            /*0x24*/ bool m_UseMipMaps;
            /*0x25*/ bool m_IsAtlasTextureOwner;
            /*0x28*/ UnityEngine.Rendering.AtlasAllocator m_AtlasAllocator;
            /*0x30*/ System.Collections.Generic.Dictionary<int, System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector2Int>> m_AllocationCache;
            /*0x38*/ System.Collections.Generic.Dictionary<int, int> m_IsGPUTextureUpToDate;
            /*0x40*/ System.Collections.Generic.Dictionary<int, int> m_TextureHashes;

            static /*0x7b97400*/ Texture2DAtlas();
            static /*0x7b94784*/ int get_maxMipLevelPadding();
            /*0x7b947e4*/ Texture2DAtlas(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, bool powerOfTwoPadding, string name, bool useMipMap);
            /*0x7b947dc*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x7b94b20*/ void Release();
            /*0x7b94b94*/ void ResetAllocator();
            /*0x7b94c14*/ void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b94a98*/ int GetTextureMipmapCount(int width, int height);
            /*0x7b95088*/ bool Is2D(UnityEngine.Texture texture);
            /*0x7b95154*/ bool IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination);
            /*0x7b95398*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType);
            /*0x7b95d24*/ void MarkGPUTextureValid(int instanceId, bool mipAreValid);
            /*0x7b95d94*/ void MarkGPUTextureInvalid(int instanceId);
            /*0x7b95df0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b96114*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b96124*/ void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, bool blitMips, int overrideInstanceID);
            /*0x7b962a4*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x7b96474*/ bool AllocateTextureWithoutBlit(UnityEngine.Texture texture, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b964d0*/ bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b96658*/ int GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b95f8c*/ int GetTextureID(UnityEngine.Texture texture);
            /*0x7b966d0*/ int GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b96718*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b967d4*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x7b9674c*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int id);
            /*0x7b96810*/ UnityEngine.Vector2Int GetCachedTextureSize(int id);
            /*0x7b96884*/ bool NeedsUpdate(UnityEngine.Texture texture, bool needMips);
            /*0x7b96af8*/ bool NeedsUpdate(int id, int updateCount, bool needMips);
            /*0x7b96bb4*/ bool NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, bool needMips);
            /*0x7b96fc0*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x7b97060*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Vector4 sourceScaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x7b971dc*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x7b97290*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleBias, int key, int width, int height);

            enum BlitType
            {
                Default = 0,
                CubeTo2DOctahedral = 1,
                SingleChannel = 2,
                CubeTo2DOctahedralSingleChannel = 3,
            }
        }

        class TextureXR
        {
            static /*0x0*/ int m_MaxViews;
            static /*0x8*/ UnityEngine.Texture m_BlackUIntTexture2DArray;
            static /*0x10*/ UnityEngine.Texture m_BlackUIntTexture;
            static /*0x18*/ UnityEngine.Rendering.RTHandle m_BlackUIntTexture2DArrayRTH;
            static /*0x20*/ UnityEngine.Rendering.RTHandle m_BlackUIntTextureRTH;
            static /*0x28*/ UnityEngine.Texture2DArray m_ClearTexture2DArray;
            static /*0x30*/ UnityEngine.Texture2D m_ClearTexture;
            static /*0x38*/ UnityEngine.Rendering.RTHandle m_ClearTexture2DArrayRTH;
            static /*0x40*/ UnityEngine.Rendering.RTHandle m_ClearTextureRTH;
            static /*0x48*/ UnityEngine.Texture2DArray m_MagentaTexture2DArray;
            static /*0x50*/ UnityEngine.Texture2D m_MagentaTexture;
            static /*0x58*/ UnityEngine.Rendering.RTHandle m_MagentaTexture2DArrayRTH;
            static /*0x60*/ UnityEngine.Rendering.RTHandle m_MagentaTextureRTH;
            static /*0x68*/ UnityEngine.Texture2D m_BlackTexture;
            static /*0x70*/ UnityEngine.Texture3D m_BlackTexture3D;
            static /*0x78*/ UnityEngine.Texture2DArray m_BlackTexture2DArray;
            static /*0x80*/ UnityEngine.Rendering.RTHandle m_BlackTexture2DArrayRTH;
            static /*0x88*/ UnityEngine.Rendering.RTHandle m_BlackTextureRTH;
            static /*0x90*/ UnityEngine.Rendering.RTHandle m_BlackTexture3DRTH;
            static /*0x98*/ UnityEngine.Texture2DArray m_WhiteTexture2DArray;
            static /*0xa0*/ UnityEngine.Rendering.RTHandle m_WhiteTexture2DArrayRTH;
            static /*0xa8*/ UnityEngine.Rendering.RTHandle m_WhiteTextureRTH;

            static /*0x7b986a8*/ TextureXR();
            static /*0x7b97460*/ void set_maxViews(int value);
            static /*0x7b974bc*/ int get_slices();
            static /*0x7b97514*/ bool get_useTexArray();
            static /*0x7b9757c*/ UnityEngine.Rendering.TextureDimension get_dimension();
            static /*0x7b975dc*/ UnityEngine.Rendering.RTHandle GetBlackUIntTexture();
            static /*0x7b97660*/ UnityEngine.Rendering.RTHandle GetClearTexture();
            static /*0x7b976e4*/ UnityEngine.Rendering.RTHandle GetMagentaTexture();
            static /*0x7b97768*/ UnityEngine.Rendering.RTHandle GetBlackTexture();
            static /*0x7b977ec*/ UnityEngine.Rendering.RTHandle GetBlackTextureArray();
            static /*0x7b97844*/ UnityEngine.Rendering.RTHandle GetBlackTexture3D();
            static /*0x7b9789c*/ UnityEngine.Rendering.RTHandle GetWhiteTexture();
            static /*0x7b97920*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b98408*/ UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, string name);
            static /*0x7b97ff8*/ UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b9824c*/ UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b985e8*/ UnityEngine.Texture3D CreateBlackTexture3D(string name);
        }

        class ArrayExtensions
        {
            static /*0x3842d2c*/ void ResizeArray<T>(ref Unity.Collections.NativeArray<T> array, int capacity);
            static /*0x7b986f4*/ void ResizeArray(ref UnityEngine.Jobs.TransformAccessArray array, int capacity);
            static /*0x3842d2c*/ void ResizeArray<T>(ref T[] array, int capacity);
            static /*0x3844414*/ void FillArray<T>(ref Unity.Collections.NativeArray<T> array, ref T value, int startIndex, int length);
        }

        struct SHCoefficients : System.IEquatable<UnityEngine.Rendering.SHCoefficients>
        {
            /*0x10*/ UnityEngine.Vector4 SHAr;
            /*0x20*/ UnityEngine.Vector4 SHAg;
            /*0x30*/ UnityEngine.Vector4 SHAb;
            /*0x40*/ UnityEngine.Vector4 SHBr;
            /*0x50*/ UnityEngine.Vector4 SHBg;
            /*0x60*/ UnityEngine.Vector4 SHBb;
            /*0x70*/ UnityEngine.Vector4 SHC;
            /*0x80*/ UnityEngine.Vector4 ProbesOcclusion;

            static /*0x7b988ec*/ UnityEngine.Vector4 GetSHA(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x7b98994*/ UnityEngine.Vector4 GetSHB(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x7b98a28*/ UnityEngine.Vector4 GetSHC(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            static /*0x7b98ef8*/ bool op_Equality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            static /*0x7b98f2c*/ bool op_Inequality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            /*0x7b98794*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            /*0x7b98a90*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector4 probesOcclusion);
            /*0x7b98ae8*/ bool Equals(UnityEngine.Rendering.SHCoefficients other);
            /*0x7b98cf4*/ bool Equals(object obj);
            /*0x7b98d84*/ int GetHashCode();
        }

        struct BatchRendererGroupGlobals : System.IEquatable<UnityEngine.Rendering.BatchRendererGroupGlobals>
        {
            static string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
            static /*0x0*/ int kGlobalsPropertyId;
            /*0x10*/ UnityEngine.Vector4 ProbesOcclusion;
            /*0x20*/ UnityEngine.Vector4 SpecCube0_HDR;
            /*0x30*/ UnityEngine.Vector4 SpecCube1_HDR;
            /*0x40*/ UnityEngine.Rendering.SHCoefficients SHCoefficients;

            static /*0x7b99498*/ BatchRendererGroupGlobals();
            static /*0x7b98f64*/ UnityEngine.Rendering.BatchRendererGroupGlobals get_Default();
            static /*0x7b9936c*/ bool op_Equality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            static /*0x7b99400*/ bool op_Inequality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            /*0x7b99088*/ bool Equals(UnityEngine.Rendering.BatchRendererGroupGlobals other);
            /*0x7b991a0*/ bool Equals(object obj);
            /*0x7b99258*/ int GetHashCode();
        }

        interface IBitArray
        {
            /*0x38156c4*/ uint get_capacity();
            /*0x3813ffc*/ bool get_allFalse();
            /*0x3813ffc*/ bool get_allTrue();
            /*0x38142c8*/ bool get_Item(uint index);
            /*0x3910ae8*/ void set_Item(uint index, bool value);
            /*0x38148bc*/ string get_humanizedData();
            /*0x3814a3c*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3814a3c*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x38148bc*/ UnityEngine.Rendering.IBitArray BitNot();
        }

        struct BitArray8 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ byte data;

            static /*0x7b99740*/ UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a);
            static /*0x7b9974c*/ UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b99758*/ UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b998f4*/ bool op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b99904*/ bool op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            /*0x7b99688*/ BitArray8(byte initValue);
            /*0x7b99690*/ BitArray8(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b99500*/ uint get_capacity();
            /*0x7b99508*/ bool get_allFalse();
            /*0x7b99518*/ bool get_allTrue();
            /*0x7b99528*/ string get_humanizedData();
            /*0x7b99620*/ bool get_Item(uint index);
            /*0x7b99640*/ void set_Item(uint index, bool value);
            /*0x7b99764*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b997fc*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b99894*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b99914*/ bool Equals(object obj);
            /*0x7b9998c*/ int GetHashCode();
        }

        struct BitArray16 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ushort data;

            static /*0x7b99c64*/ UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a);
            static /*0x7b99c70*/ UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b99c7c*/ UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b99e18*/ bool op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b99e28*/ bool op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            /*0x7b99bac*/ BitArray16(ushort initValue);
            /*0x7b99bb4*/ BitArray16(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b999ac*/ uint get_capacity();
            /*0x7b999b4*/ bool get_allFalse();
            /*0x7b999c4*/ bool get_allTrue();
            /*0x7b999d4*/ string get_humanizedData();
            /*0x7b99b44*/ bool get_Item(uint index);
            /*0x7b99b64*/ void set_Item(uint index, bool value);
            /*0x7b99c88*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b99d20*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b99db8*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b99e38*/ bool Equals(object obj);
            /*0x7b99eb0*/ int GetHashCode();
        }

        struct BitArray32 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ uint data;

            static /*0x7b9a384*/ UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a);
            static /*0x7b9a31c*/ UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b9a27c*/ UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b9a38c*/ bool op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b9a398*/ bool op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            /*0x7b9a12c*/ BitArray32(uint initValue);
            /*0x7b9a134*/ BitArray32(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b99ed0*/ uint get_capacity();
            /*0x7b99ed8*/ bool get_allFalse();
            /*0x7b99ee8*/ bool get_allTrue();
            /*0x7b99ef8*/ string get_humanizedVersion();
            /*0x7b99f58*/ string get_humanizedData();
            /*0x7b9a0c8*/ bool get_Item(uint index);
            /*0x7b9a0e4*/ void set_Item(uint index, bool value);
            /*0x7b9a1e4*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b9a284*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b9a324*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b9a3a4*/ bool Equals(object obj);
            /*0x7b9a41c*/ int GetHashCode();
        }

        struct BitArray64 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data;

            static /*0x7b9a6f0*/ UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a);
            static /*0x7b9a6f8*/ UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b9a700*/ UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b9a898*/ bool op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b9a8a4*/ bool op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            /*0x7b9a638*/ BitArray64(ulong initValue);
            /*0x7b9a640*/ BitArray64(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b9a43c*/ uint get_capacity();
            /*0x7b9a444*/ bool get_allFalse();
            /*0x7b9a454*/ bool get_allTrue();
            /*0x7b9a464*/ string get_humanizedData();
            /*0x7b9a5d4*/ bool get_Item(uint index);
            /*0x7b9a5f0*/ void set_Item(uint index, bool value);
            /*0x7b9a708*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b9a7a0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b9a838*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b9a8b0*/ bool Equals(object obj);
            /*0x7b9a928*/ int GetHashCode();
        }

        struct BitArray128 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;

            static /*0x7b9acc4*/ UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a);
            static /*0x7b9acd0*/ UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b9acdc*/ UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b9ae90*/ bool op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b9aea8*/ bool op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            /*0x7b9abe4*/ BitArray128(ulong initValue1, ulong initValue2);
            /*0x7b9abec*/ BitArray128(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b9a948*/ uint get_capacity();
            /*0x7b9a950*/ bool get_allFalse();
            /*0x7b9a970*/ bool get_allTrue();
            /*0x7b9a994*/ string get_humanizedData();
            /*0x7b9ab90*/ bool get_Item(uint index);
            /*0x7b9abb0*/ void set_Item(uint index, bool value);
            /*0x7b9ace8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b9ad8c*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b9ae30*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b9aec0*/ bool Equals(object obj);
            /*0x7b9af50*/ int GetHashCode();
        }

        struct BitArray256 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;
            /*0x20*/ ulong data3;
            /*0x28*/ ulong data4;

            static /*0x7b9b57c*/ UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a);
            static /*0x7b9b590*/ UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b9b5c4*/ UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b9b7dc*/ bool op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b9b828*/ bool op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            /*0x7b9b45c*/ BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4);
            /*0x7b9b468*/ BitArray256(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b9af98*/ uint get_capacity();
            /*0x7b9afa0*/ bool get_allFalse();
            /*0x7b9afd0*/ bool get_allTrue();
            /*0x7b9b00c*/ string get_humanizedData();
            /*0x7b9b30c*/ bool get_Item(uint index);
            /*0x7b9b390*/ void set_Item(uint index, bool value);
            /*0x7b9b5f8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b9b6b8*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b9b778*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b9b874*/ bool Equals(object obj);
            /*0x7b9b93c*/ int GetHashCode();
        }

        class BitArrayUtilities
        {
            static /*0x7b99630*/ bool Get8(uint index, byte data);
            static /*0x7b99b54*/ bool Get16(uint index, ushort data);
            static /*0x7b9a0d8*/ bool Get32(uint index, uint data);
            static /*0x7b9a5e4*/ bool Get64(uint index, ulong data);
            static /*0x7b9b9b8*/ bool Get128(uint index, ulong data1, ulong data2);
            static /*0x7b9b354*/ bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4);
            static /*0x7b99664*/ void Set8(uint index, ref byte data, bool value);
            static /*0x7b99b88*/ void Set16(uint index, ref ushort data, bool value);
            static /*0x7b9a108*/ void Set32(uint index, ref uint data, bool value);
            static /*0x7b9a614*/ void Set64(uint index, ref ulong data, bool value);
            static /*0x7b9b9cc*/ void Set128(uint index, ref ulong data1, ref ulong data2, bool value);
            static /*0x7b9b3b4*/ void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value);
        }

        class Blitter
        {
            static /*0x0*/ UnityEngine.Material s_Copy;
            static /*0x8*/ UnityEngine.Material s_Blit;
            static /*0x10*/ UnityEngine.Material s_BlitTexArray;
            static /*0x18*/ UnityEngine.Material s_BlitTexArraySingleSlice;
            static /*0x20*/ UnityEngine.Material s_BlitColorAndDepth;
            static /*0x28*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
            static /*0x30*/ UnityEngine.Mesh s_TriangleMesh;
            static /*0x38*/ UnityEngine.Mesh s_QuadMesh;
            static /*0x40*/ UnityEngine.Rendering.LocalKeyword s_DecodeHdrKeyword;
            static /*0x58*/ int[] s_BlitShaderPassIndicesMap;
            static /*0x60*/ int[] s_BlitColorAndDepthShaderPassIndicesMap;

            static /*0x7b9f898*/ Blitter();
            static /*0x7b9ba0c*/ void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS);
            static /*0x7b9c5dc*/ void Cleanup();
            static /*0x7b9c754*/ UnityEngine.Material GetBlitMaterial(UnityEngine.Rendering.TextureDimension dimension, bool singleSlice);
            static /*0x7b9c82c*/ void DrawTriangle(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b9c8a4*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b9c91c*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b9caa8*/ void DrawQuadMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b9cba4*/ void DrawQuad(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b9cdb0*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b9cc24*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b9ce28*/ bool CanCopyMSAA();
            static /*0x7b9ce98*/ void CopyTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isMSAA);
            static /*0x7b9cf24*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear);
            static /*0x7b9d038*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass, float sourceMipLevel, int sourceDepthSlice);
            static /*0x7b9d2b0*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b9d368*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b9d4e8*/ void BlitTexture2D(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b9d5a0*/ void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b9d6fc*/ void BlitColorAndDepth(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x7b9d7bc*/ void BlitColorAndDepth(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x7b9d9bc*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9d17c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9da6c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9db48*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9dca4*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int pass);
            static /*0x7b9de3c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x7b9dfec*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9e0dc*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b9e1cc*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x7b9e3c8*/ void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x7b9e520*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int pass);
            static /*0x7b9e678*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x7b9e918*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b9ea10*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, float mipLevel, bool bilinear);
            static /*0x7b94dcc*/ void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear);
            static /*0x7b9eba8*/ void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b9ee44*/ void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b9f0e0*/ void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b9f318*/ void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b95624*/ void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b9f550*/ void BlitCubeToOctahedral2DQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, System.Nullable<UnityEngine.Vector4> decodeInstructions);
            static /*0x7b95a90*/ void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b957dc*/ void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b9c2fc*/ UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|14_0(float z);
            static /*0x7b9c3b0*/ UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|14_1();
            static /*0x7b9c478*/ UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|14_2(float z);
            static /*0x7b9c520*/ UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|14_3();

            class BlitShaderIDs
            {
                static /*0x0*/ int _BlitTexture;
                static /*0x4*/ int _BlitCubeTexture;
                static /*0x8*/ int _BlitScaleBias;
                static /*0xc*/ int _BlitScaleBiasRt;
                static /*0x10*/ int _BlitMipLevel;
                static /*0x14*/ int _BlitTexArraySlice;
                static /*0x18*/ int _BlitTextureSize;
                static /*0x1c*/ int _BlitPaddingSize;
                static /*0x20*/ int _BlitDecodeInstructions;
                static /*0x24*/ int _InputDepth;

                static /*0x7b9f90c*/ BlitShaderIDs();
            }

            enum BlitShaderPassNames
            {
                Nearest = 0,
                Bilinear = 1,
                NearestQuad = 2,
                BilinearQuad = 3,
                NearestQuadPadding = 4,
                BilinearQuadPadding = 5,
                NearestQuadPaddingRepeat = 6,
                BilinearQuadPaddingRepeat = 7,
                BilinearQuadPaddingOctahedral = 8,
                NearestQuadPaddingAlphaBlend = 9,
                BilinearQuadPaddingAlphaBlend = 10,
                NearestQuadPaddingAlphaBlendRepeat = 11,
                BilinearQuadPaddingAlphaBlendRepeat = 12,
                BilinearQuadPaddingAlphaBlendOctahedral = 13,
                CubeToOctahedral = 14,
                CubeToOctahedralLuminance = 15,
                CubeToOctahedralAlpha = 16,
                CubeToOctahedralRed = 17,
                BilinearQuadLuminance = 18,
                BilinearQuadAlpha = 19,
                BilinearQuadRed = 20,
                NearestCubeToOctahedralPadding = 21,
                BilinearCubeToOctahedralPadding = 22,
            }

            enum BlitColorAndDepthPassNames
            {
                ColorOnly = 0,
                ColorAndDepth = 1,
            }
        }

        class CameraCaptureBridge
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Rendering.CameraCaptureBridge.CameraEntry> actionDict;
            static /*0x8*/ bool _enabled;

            static /*0x7ba01c0*/ CameraCaptureBridge();
            static /*0x7b9fb20*/ bool get_enabled();
            static /*0x7b9fb78*/ void set_enabled(bool value);
            static /*0x7b9fbd8*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera);
            static /*0x7b9fcec*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCachedCaptureActionsEnumerator(UnityEngine.Camera camera);
            static /*0x7b9fe34*/ void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
            static /*0x7ba0044*/ void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);

            class CameraEntry
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> actions;
                /*0x18*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> cachedEnumerator;

                /*0x7ba003c*/ CameraEntry();
            }
        }

        class ColorSpaceUtils
        {
            static /*0x0*/ Unity.Mathematics.float3x3 Rec709ToRec2020Mat;
            static /*0x24*/ Unity.Mathematics.float3x3 Rec709ToP3D65Mat;
            static /*0x48*/ Unity.Mathematics.float3x3 Rec2020ToRec709Mat;
            static /*0x6c*/ Unity.Mathematics.float3x3 Rec2020ToP3D65Mat;
            static /*0x90*/ Unity.Mathematics.float3x3 P3D65ToRec2020Mat;

            static /*0x7ba0258*/ ColorSpaceUtils();
        }

        class ColorUtils
        {
            static /*0x0*/ float s_LightMeterCalibrationConstant;
            static /*0x4*/ float s_LensAttenuation;

            static /*0x7ba0e84*/ ColorUtils();
            static /*0x7ba035c*/ float get_lensImperfectionExposureScale();
            static /*0x7ba03cc*/ float StandardIlluminantY(float x);
            static /*0x7ba03f8*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
            static /*0x7ba0488*/ UnityEngine.Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
            static /*0x7ba05ec*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inMidtones, ref UnityEngine.Vector4 inHighlights);
            static /*0x7ba07f4*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareLiftGammaGain(ref UnityEngine.Vector4 inLift, ref UnityEngine.Vector4 inGamma, ref UnityEngine.Vector4 inGain);
            static /*0x7ba0aa0*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4> PrepareSplitToning(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inHighlights, float balance);
            static /*0x7ba0a68*/ float Luminance(ref UnityEngine.Color color);
            static /*0x7ba0b2c*/ float ComputeEV100(float aperture, float shutterSpeed, float ISO);
            static /*0x7ba0bb8*/ float ConvertEV100ToExposure(float EV100);
            static /*0x7ba0c2c*/ float ConvertExposureToEV100(float exposure);
            static /*0x7ba0ce4*/ float ComputeEV100FromAvgLuminance(float avgLuminance);
            static /*0x7ba0da4*/ float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
            static /*0x7ba0de0*/ uint ToHex(UnityEngine.Color c);
            static /*0x7ba0e48*/ UnityEngine.Color ToRGBA(uint hex);
        }

        class CoreMatrixUtils
        {
            static /*0x7ba0ed4*/ void MatrixTimesTranslation(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x7ba0f30*/ void TranslationTimesMatrix(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x7ba0fb8*/ UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs);
            static /*0x7ba106c*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x7ba1110*/ UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x7ba1200*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, bool centered);
            static /*0x7ba12e8*/ UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, bool orthoCentered);
        }

        class CoreUtils
        {
            static string obsoletePriorityMessage = "Use CoreUtils.Priorities instead";
            static int editMenuPriority1 = 320;
            static int editMenuPriority2 = 331;
            static int editMenuPriority3 = 342;
            static int editMenuPriority4 = 353;
            static int assetCreateMenuPriority1 = 230;
            static int assetCreateMenuPriority2 = 241;
            static int assetCreateMenuPriority3 = 300;
            static int gameObjectMenuPriority = 10;
            static /*0x0*/ UnityEngine.Vector3[] lookAtList;
            static /*0x8*/ UnityEngine.Vector3[] upVectorList;
            static /*0x10*/ UnityEngine.Cubemap m_BlackCubeTexture;
            static /*0x18*/ UnityEngine.Cubemap m_MagentaCubeTexture;
            static /*0x20*/ UnityEngine.CubemapArray m_MagentaCubeTextureArray;
            static /*0x28*/ UnityEngine.Cubemap m_WhiteCubeTexture;
            static /*0x30*/ UnityEngine.RenderTexture m_EmptyUAV;
            static /*0x38*/ UnityEngine.GraphicsBuffer m_EmptyBuffer;
            static /*0x40*/ UnityEngine.Texture3D m_BlackVolumeTexture;
            static /*0x48*/ UnityEngine.Texture3D m_WhiteVolumeTexture;
            static /*0x50*/ System.Collections.Generic.IEnumerable<System.Type> m_AssemblyTypes;

            static /*0x7ba55d0*/ CoreUtils();
            static /*0x7ba13b0*/ UnityEngine.Cubemap get_blackCubeTexture();
            static /*0x7ba1520*/ UnityEngine.Cubemap get_magentaCubeTexture();
            static /*0x7ba1690*/ UnityEngine.CubemapArray get_magentaCubeTextureArray();
            static /*0x7ba1864*/ UnityEngine.Cubemap get_whiteCubeTexture();
            static /*0x7ba19d4*/ UnityEngine.RenderTexture get_emptyUAV();
            static /*0x7ba1b14*/ UnityEngine.GraphicsBuffer get_emptyBuffer();
            static /*0x7ba1c14*/ UnityEngine.Texture3D get_blackVolumeTexture();
            static /*0x7ba1da0*/ UnityEngine.Texture3D get_whiteVolumeTexture();
            static /*0x7ba1f28*/ void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba1f4c*/ int FixupDepthSlice(int depthSlice, UnityEngine.Rendering.RTHandle buffer);
            static /*0x7ba1f90*/ int FixupDepthSlice(int depthSlice, UnityEngine.CubemapFace cubemapFace);
            static /*0x7ba1fa4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba20b4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2184*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba23b8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2278*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba24b8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer);
            static /*0x7ba2654*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7ba2564*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba270c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba2800*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2900*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2a24*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7ba2ae4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba2c20*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2d90*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba2f0c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba3018*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7ba3120*/ void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba3238*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b9e324*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba3354*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba3530*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba33fc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b9e800*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba35dc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7ba373c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer);
            static /*0x7ba37fc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7ba38c0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7ba31c4*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target);
            static /*0x7b93848*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.RenderTextureFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x7ba3c34*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x7b92fcc*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x7ba39bc*/ string GetRenderTargetAutoName(int width, int height, int depth, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x7ba3d30*/ string GetTextureAutoName(int width, int height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7ba4228*/ string GetTextureAutoName(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7ba3e18*/ string GetTextureAutoName(int width, int height, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7ba4310*/ void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips);
            static /*0x7ba44c4*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba4578*/ void DrawFullScreen(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba45f8*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba46d4*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba47dc*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba48c0*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7ba4988*/ UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color);
            static /*0x7ba4a04*/ UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color);
            static /*0x7ba4a80*/ UnityEngine.Material CreateEngineMaterial(string shaderPath);
            static /*0x7b9c204*/ UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader);
            static /*0x3910ae8*/ bool HasFlag<T>(T mask, T flag);
            static /*0x3843dfc*/ void Swap<T>(ref T a, ref T b);
            static /*0x7ba4bfc*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, string keyword, bool state);
            static /*0x7ba4c1c*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x7ba4c80*/ void SetKeyword(UnityEngine.Rendering.BaseCommandBuffer cmd, string keyword, bool state);
            static /*0x7ba4cb0*/ void SetKeyword(UnityEngine.Material material, string keyword, bool state);
            static /*0x7ba4cd0*/ void SetKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool state);
            static /*0x7ba4cf0*/ void SetKeyword(UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x7b8e9f4*/ void Destroy(UnityEngine.Object obj);
            static /*0x7ba4d10*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
            static /*0x3836db8*/ System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
            static /*0x7ba4ea8*/ void SafeRelease(UnityEngine.GraphicsBuffer buffer);
            static /*0x7ba4eb8*/ void SafeRelease(UnityEngine.ComputeBuffer buffer);
            static /*0x7ba4ec8*/ UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x7ba526c*/ bool ArePostProcessesEnabled(UnityEngine.Camera camera);
            static /*0x7ba5274*/ bool AreAnimatedMaterialsEnabled(UnityEngine.Camera camera);
            static /*0x7ba527c*/ bool IsSceneLightingDisabled(UnityEngine.Camera camera);
            static /*0x7ba5284*/ bool IsLightOverlapDebugEnabled(UnityEngine.Camera camera);
            static /*0x7ba528c*/ bool IsSceneViewFogEnabled(UnityEngine.Camera camera);
            static /*0x7ba5294*/ bool IsSceneFilteringEnabled();
            static /*0x7ba529c*/ bool IsSceneViewPrefabStageContextHidden();
            static /*0x7ba52a4*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
            static /*0x7b95fa4*/ int GetTextureHash(UnityEngine.Texture texture);
            static /*0x7ba52f0*/ int PreviousPowerOfTwo(int size);
            static /*0x7ba531c*/ int GetMipCount(int size);
            static /*0x7b94fcc*/ int GetMipCount(float size);
            static /*0x7ba53dc*/ int DivRoundUp(int value, int divisor);
            static /*0x3910ae8*/ T GetLastEnumValue<T>();
            static /*0x7ba53ec*/ string GetCorePath();
            static /*0x7ba542c*/ UnityEngine.Vector3[] CalculateViewSpaceCorners(UnityEngine.Matrix4x4 proj, float z);

            class Sections
            {
                static int section1 = 10000;
                static int section2 = 20000;
                static int section3 = 30000;
                static int section4 = 40000;
                static int section5 = 50000;
                static int section6 = 60000;
                static int section7 = 70000;
                static int section8 = 80000;
            }

            class Priorities
            {
                static int assetsCreateShaderMenuPriority = 83;
                static int assetsCreateRenderingMenuPriority = 308;
                static int editMenuPriority = 320;
                static int gameObjectMenuPriority = 10;
                static int srpLensFlareMenuPriority = 303;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__97_0;

                static /*0x7ba576c*/ <>c();
                /*0x7ba57d4*/ <>c();
                /*0x7ba57dc*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__97_0(System.Reflection.Assembly t);
            }

            class <>c__98<T>
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<>c__98<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__98_0;

                static /*0x383e7a0*/ <>c__98();
                /*0x38159dc*/ <>c__98();
                /*0x38141c4*/ bool <GetAllTypesDerivedFrom>b__98_0(System.Type t);
            }
        }

        class DelegateUtility
        {
            static /*0x7ba58c0*/ System.Delegate Cast(System.Delegate source, System.Type type);
        }

        class FSRUtils
        {
            static float kMaxSharpnessStops = 2.5;
            static float kDefaultSharpnessStops = 0.20000000298023224;
            static float kDefaultSharpnessLinear = 0.9200000166893005;

            static /*0x7ba5a60*/ void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x7ba5be4*/ void SetEasuConstants(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x7ba5bfc*/ void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessStops);
            static /*0x7ba5ca8*/ void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessLinear);
            static /*0x7ba5cbc*/ void SetRcasConstantsLinear(UnityEngine.Rendering.RasterCommandBuffer cmd, float sharpnessLinear);
            static /*0x7ba5ce4*/ bool IsSupported();

            class ShaderConstants
            {
                static /*0x0*/ int _FsrEasuConstants0;
                static /*0x4*/ int _FsrEasuConstants1;
                static /*0x8*/ int _FsrEasuConstants2;
                static /*0xc*/ int _FsrEasuConstants3;
                static /*0x10*/ int _FsrRcasConstants;

                static /*0x7ba5d00*/ ShaderConstants();
            }
        }

        struct GPUPrefixSum
        {
            /*0x10*/ UnityEngine.Rendering.GPUPrefixSum.SystemResources resources;

            /*0x7ba5e28*/ GPUPrefixSum(UnityEngine.Rendering.GPUPrefixSum.SystemResources resources);
            /*0x7ba600c*/ UnityEngine.Vector4 PackPrefixSumArgs(int a, int b, int c, int d);
            /*0x7ba6020*/ void ExecuteCommonIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.GraphicsBuffer inputBuffer, ref UnityEngine.Rendering.GPUPrefixSum.SupportResources supportResources, bool isExclusive);
            /*0x7ba63a0*/ void DispatchDirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.DirectArgs arguments);
            /*0x7ba65a0*/ void DispatchIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.IndirectDirectArgs arguments);

            class ShaderDefs
            {
                static int GroupSize = 128;
                static int ArgsBufferStride = 16;
                static int ArgsBufferUpper = 0;
                static int ArgsBufferLower = 8;

                static /*0x7ba67a0*/ int DivUpGroup(int value);
                static /*0x7ba67b8*/ int AlignUpGroup(int value);
                static /*0x7ba67d0*/ void CalculateTotalBufferSize(int maxElementCount, ref int totalSize, ref int levelCounts);
            }

            struct LevelOffsets
            {
                /*0x10*/ uint count;
                /*0x14*/ uint offset;
                /*0x18*/ uint parentOffset;
            }

            struct RenderGraphResources
            {
                /*0x10*/ int alignedElementCount;
                /*0x14*/ int maxBufferCount;
                /*0x18*/ int maxLevelCount;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle prefixBuffer0;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle prefixBuffer1;
                /*0x34*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle totalLevelCountBuffer;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle levelOffsetBuffer;
                /*0x4c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle indirectDispatchArgsBuffer;

                static /*0x7ba6858*/ UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources Create(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
                /*0x7ba6848*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_output();
                /*0x7ba68b4*/ void Initialize(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
            }

            struct SupportResources
            {
                /*0x10*/ bool ownsResources;
                /*0x14*/ int alignedElementCount;
                /*0x18*/ int maxBufferCount;
                /*0x1c*/ int maxLevelCount;
                /*0x20*/ UnityEngine.GraphicsBuffer prefixBuffer0;
                /*0x28*/ UnityEngine.GraphicsBuffer prefixBuffer1;
                /*0x30*/ UnityEngine.GraphicsBuffer totalLevelCountBuffer;
                /*0x38*/ UnityEngine.GraphicsBuffer levelOffsetBuffer;
                /*0x40*/ UnityEngine.GraphicsBuffer indirectDispatchArgsBuffer;

                static /*0x7ba6c3c*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Create(int maxElementCount);
                static /*0x7ba6f54*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Load(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                static /*0x7ba7140*/ void <Dispose>g__TryFreeBuffer|15_0(UnityEngine.GraphicsBuffer resource);
                /*0x7ba6c34*/ UnityEngine.GraphicsBuffer get_output();
                /*0x7ba6ca8*/ void Resize(int newMaxElementCount);
                /*0x7ba6fb0*/ void LoadFromShaderGraph(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                /*0x7ba70c8*/ void Dispose();
            }

            struct DirectArgs
            {
                /*0x10*/ bool exclusive;
                /*0x14*/ int inputCount;
                /*0x18*/ UnityEngine.GraphicsBuffer input;
                /*0x20*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources supportResources;
            }

            struct IndirectDirectArgs
            {
                /*0x10*/ bool exclusive;
                /*0x14*/ int inputCountBufferByteOffset;
                /*0x18*/ UnityEngine.ComputeBuffer inputCountBuffer;
                /*0x20*/ UnityEngine.GraphicsBuffer input;
                /*0x28*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources supportResources;
            }

            struct SystemResources
            {
                /*0x10*/ UnityEngine.ComputeShader computeAsset;
                /*0x18*/ int kernelCalculateLevelDispatchArgsFromConst;
                /*0x1c*/ int kernelCalculateLevelDispatchArgsFromBuffer;
                /*0x20*/ int kernelPrefixSumOnGroup;
                /*0x24*/ int kernelPrefixSumOnGroupExclusive;
                /*0x28*/ int kernelPrefixSumNextInput;
                /*0x2c*/ int kernelPrefixSumResolveParent;
                /*0x30*/ int kernelPrefixSumResolveParentExclusive;

                /*0x7ba5e54*/ void LoadKernels();
            }

            class ShaderIDs
            {
                static /*0x0*/ int _InputBuffer;
                static /*0x4*/ int _OutputBuffer;
                static /*0x8*/ int _InputCountBuffer;
                static /*0xc*/ int _TotalLevelsBuffer;
                static /*0x10*/ int _OutputTotalLevelsBuffer;
                static /*0x14*/ int _OutputDispatchLevelArgsBuffer;
                static /*0x18*/ int _LevelsOffsetsBuffer;
                static /*0x1c*/ int _OutputLevelsOffsetsBuffer;
                static /*0x20*/ int _PrefixSumIntArgs;

                static /*0x7ba7150*/ ShaderIDs();
            }
        }

        struct GPUSort
        {
            static uint kWorkGroupSize = 1024;
            /*0x10*/ UnityEngine.Rendering.LocalKeyword[] m_Keywords;
            /*0x18*/ UnityEngine.Rendering.GPUSort.SystemResources resources;

            static /*0x7ba79e0*/ int DivRoundUp(int x, int y);
            /*0x7ba7338*/ GPUSort(UnityEngine.Rendering.GPUSort.SystemResources resources);
            /*0x7ba7564*/ void DispatchStage(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args, uint h, UnityEngine.Rendering.GPUSort.Stage stage);
            /*0x7ba7824*/ void CopyBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst);
            /*0x7ba79f0*/ void Dispatch(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args);

            enum Stage
            {
                LocalBMS = 0,
                LocalDisperse = 1,
                BigFlip = 2,
                BigDisperse = 3,
            }

            struct Args
            {
                /*0x10*/ uint count;
                /*0x14*/ uint maxDepth;
                /*0x18*/ UnityEngine.GraphicsBuffer inputKeys;
                /*0x20*/ UnityEngine.GraphicsBuffer inputValues;
                /*0x28*/ UnityEngine.Rendering.GPUSort.SupportResources resources;
                /*0x38*/ int workGroupCount;
            }

            struct RenderGraphResources
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle sortBufferKeys;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle sortBufferValues;

                static /*0x7ba7bd8*/ UnityEngine.Rendering.GPUSort.RenderGraphResources Create(int count, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder);
            }

            struct SupportResources
            {
                /*0x10*/ UnityEngine.GraphicsBuffer sortBufferKeys;
                /*0x18*/ UnityEngine.GraphicsBuffer sortBufferValues;

                static /*0x7ba7cf4*/ UnityEngine.Rendering.GPUSort.SupportResources Load(UnityEngine.Rendering.GPUSort.RenderGraphResources renderGraphResources);
                /*0x7ba7da0*/ void Dispose();
            }

            struct SystemResources
            {
                /*0x10*/ UnityEngine.ComputeShader computeAsset;
            }
        }

        class HableCurve
        {
            /*0x10*/ float <whitePoint>k__BackingField;
            /*0x14*/ float <inverseWhitePoint>k__BackingField;
            /*0x18*/ float <x0>k__BackingField;
            /*0x1c*/ float <x1>k__BackingField;
            /*0x20*/ UnityEngine.Rendering.HableCurve.Segment[] segments;
            /*0x28*/ UnityEngine.Rendering.HableCurve.Uniforms uniforms;

            /*0x7ba7e34*/ HableCurve();
            /*0x7ba7df4*/ float get_whitePoint();
            /*0x7ba7dfc*/ void set_whitePoint(float value);
            /*0x7ba7e04*/ float get_inverseWhitePoint();
            /*0x7ba7e0c*/ void set_inverseWhitePoint(float value);
            /*0x7ba7e14*/ float get_x0();
            /*0x7ba7e1c*/ void set_x0(float value);
            /*0x7ba7e24*/ float get_x1();
            /*0x7ba7e2c*/ void set_x1(float value);
            /*0x7ba7fc4*/ float Eval(float x);
            /*0x7ba80d0*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
            /*0x7ba81e8*/ void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams);
            /*0x7ba8500*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
            /*0x7ba849c*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
            /*0x7ba84c8*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

            class Segment
            {
                /*0x10*/ float offsetX;
                /*0x14*/ float offsetY;
                /*0x18*/ float scaleX;
                /*0x1c*/ float scaleY;
                /*0x20*/ float lnA;
                /*0x24*/ float B;

                /*0x7ba7f8c*/ Segment();
                /*0x7ba8074*/ float Eval(float x);
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
                /*0x10*/ UnityEngine.Rendering.HableCurve parent;

                /*0x7ba7f94*/ Uniforms(UnityEngine.Rendering.HableCurve parent);
                /*0x7ba8550*/ UnityEngine.Vector4 get_curve();
                /*0x7ba8574*/ UnityEngine.Vector4 get_toeSegmentA();
                /*0x7ba85b0*/ UnityEngine.Vector4 get_toeSegmentB();
                /*0x7ba85f0*/ UnityEngine.Vector4 get_midSegmentA();
                /*0x7ba8630*/ UnityEngine.Vector4 get_midSegmentB();
                /*0x7ba8674*/ UnityEngine.Vector4 get_shoSegmentA();
                /*0x7ba86b4*/ UnityEngine.Vector4 get_shoSegmentB();
            }
        }

        class HaltonSequence
        {
            static /*0x7ba86f8*/ float Get(int index, int radix);
        }

        struct HashFNV1A32
        {
            static uint k_Prime = 16777619;
            static uint k_OffsetBasis = 2166136261;
            /*0x10*/ uint m_Hash;

            static /*0x7ba873c*/ UnityEngine.Rendering.HashFNV1A32 Create();
            static /*0x7ba8a34*/ int GetFuncHashCode(System.Delegate del);
            /*0x7ba8748*/ void Append(ref int input);
            /*0x7ba8768*/ void Append(ref uint input);
            /*0x7ba8788*/ void Append(ref bool input);
            /*0x7ba87b0*/ void Append(ref float input);
            /*0x7ba87ec*/ void Append(ref double input);
            /*0x7ba8824*/ void Append(ref UnityEngine.Vector2 input);
            /*0x7ba888c*/ void Append(ref UnityEngine.Vector3 input);
            /*0x7ba8920*/ void Append(ref UnityEngine.Vector4 input);
            /*0x3910ae8*/ void Append<T>(T input);
            /*0x7ba89c4*/ void Append(System.Delegate del);
            /*0x7ba8a7c*/ int get_value();
            /*0x7ba8a84*/ int GetHashCode();
        }

        class HDROutputUtils
        {
            static /*0x7ba8a8c*/ bool GetColorSpaceForGamut(UnityEngine.ColorGamut gamut, ref int colorspace);
            static /*0x7ba8ca0*/ bool GetColorEncodingForGamut(UnityEngine.ColorGamut gamut, ref int encoding);
            static /*0x7ba8e24*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7ba9088*/ void ConfigureHDROutput(UnityEngine.MaterialPropertyBlock properties, UnityEngine.ColorGamut gamut);
            static /*0x7ba9148*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7ba9320*/ void ConfigureHDROutput(UnityEngine.ComputeShader computeShader, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7ba9584*/ bool IsShaderVariantValid(UnityEngine.Rendering.ShaderKeywordSet shaderKeywordSet, bool isHDREnabled);

            enum Operation
            {
                None = 0,
                ColorConversion = 1,
                ColorEncoding = 2,
            }

            struct HDRDisplayInformation
            {
                /*0x10*/ int maxFullFrameToneMapLuminance;
                /*0x14*/ int maxToneMapLuminance;
                /*0x18*/ int minToneMapLuminance;
                /*0x1c*/ float paperWhiteNits;

                /*0x7ba9690*/ HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits);
            }

            class ShaderKeywords
            {
                static string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION";
                static string HDR_ENCODING = "HDR_ENCODING";
                static string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING";
                static string HDR_INPUT = "HDR_INPUT";
                static /*0x0*/ UnityEngine.Rendering.ShaderKeyword HDRColorSpaceConversion;
                static /*0x10*/ UnityEngine.Rendering.ShaderKeyword HDREncoding;
                static /*0x20*/ UnityEngine.Rendering.ShaderKeyword HDRColorSpaceConversionAndEncoding;
                static /*0x30*/ UnityEngine.Rendering.ShaderKeyword HDRInput;

                static /*0x7ba96a0*/ ShaderKeywords();
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int hdrColorSpace;
                static /*0x4*/ int hdrEncoding;

                static /*0x7ba9814*/ ShaderPropertyId();
            }
        }

        class LightUnitUtils
        {
            static float SphereSolidAngle = 12.566370964050293;

            static /*0x7ba98b0*/ float get_k_LuminanceToEvFactor();
            static /*0x7ba9968*/ float get_k_EvToLuminanceFactor();
            static /*0x7ba997c*/ UnityEngine.Rendering.LightUnit GetNativeLightUnit(UnityEngine.LightType lightType);
            static /*0x7ba99d0*/ bool IsLightUnitSupported(UnityEngine.LightType lightType, UnityEngine.Rendering.LightUnit lightUnit);
            static /*0x7ba9a34*/ float GetSolidAngleFromPointLight();
            static /*0x7ba9a40*/ float GetSolidAngleFromSpotLight(float spotAngle);
            static /*0x7ba9ad8*/ float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio);
            static /*0x7ba9bb0*/ float GetSolidAngle(UnityEngine.LightType lightType, bool spotReflector, float spotAngle, float aspectRatio);
            static /*0x7ba9c94*/ float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY);
            static /*0x7ba9cac*/ float GetAreaFromRectangleLight(UnityEngine.Vector2 rectSize);
            static /*0x7ba9cc4*/ float GetAreaFromDiscLight(float discRadius);
            static /*0x7ba9cdc*/ float GetAreaFromTubeLight(float tubeLength);
            static /*0x7ba9cf8*/ float LumenToCandela(float lumen, float solidAngle);
            static /*0x7ba9d00*/ float CandelaToLumen(float candela, float solidAngle);
            static /*0x7ba9d08*/ float LumenToNits(float lumen, float area);
            static /*0x7ba9d10*/ float NitsToLumen(float nits, float area);
            static /*0x7ba9d18*/ float LuxToCandela(float lux, float distance);
            static /*0x7ba9d24*/ float CandelaToLux(float candela, float distance);
            static /*0x7ba9d30*/ float Ev100ToNits(float ev100);
            static /*0x7ba9d50*/ float NitsToEv100(float nits);
            static /*0x7ba9dbc*/ float Ev100ToCandela(float ev100);
            static /*0x7ba9ddc*/ float CandelaToEv100(float candela);
            static /*0x7ba9de0*/ float ConvertIntensityInternal(float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit, UnityEngine.LightType lightType, float area, float luxAtDistance, float solidAngle);
            static /*0x7baa320*/ float ConvertIntensity(UnityEngine.Light light, float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit);
        }

        enum MaterialQuality
        {
            Low = 1,
            Medium = 2,
            High = 4,
        }

        class MaterialQualityUtilities
        {
            static /*0x0*/ string[] KeywordNames;
            static /*0x8*/ string[] EnumNames;
            static /*0x10*/ UnityEngine.Rendering.ShaderKeyword[] Keywords;

            static /*0x7baa87c*/ MaterialQualityUtilities();
            static /*0x7baa474*/ UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels);
            static /*0x7baa500*/ UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel);
            static /*0x7baa6c0*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level);
            static /*0x7baa798*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd);
            static /*0x7baa628*/ int ToFirstIndex(UnityEngine.Rendering.MaterialQuality level);
            static /*0x7baa6b4*/ UnityEngine.Rendering.MaterialQuality FromIndex(int index);
        }

        class MeshGizmo : System.IDisposable
        {
            static /*0x0*/ int vertexCountPerCube;
            /*0x10*/ UnityEngine.Mesh mesh;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Vector3> vertices;
            /*0x20*/ System.Collections.Generic.List<int> indices;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Color> colors;
            /*0x30*/ UnityEngine.Material wireMaterial;
            /*0x38*/ UnityEngine.Material dottedWireMaterial;
            /*0x40*/ UnityEngine.Material solidMaterial;

            static /*0x7bab508*/ MeshGizmo();
            /*0x7baab44*/ MeshGizmo(int capacity);
            /*0x7baacec*/ void Clear();
            /*0x7baad7c*/ void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color);
            /*0x7bab2c4*/ void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x7bab46c*/ void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x7bab4ac*/ void Dispose();
            /*0x7baafd0*/ void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, ref UnityEngine.Rendering.MeshGizmo.<> );

            struct <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Rendering.MeshGizmo <>4__this;
                /*0x18*/ UnityEngine.Color color;
            }
        }

        class SceneRenderPipeline : UnityEngine.MonoBehaviour
        {
            /*0x7bab554*/ SceneRenderPipeline();
        }

        class TextureCurve : System.IDisposable
        {
            static int k_Precision = 128;
            static float k_Step = 0.0078125;
            /*0x10*/ int <length>k__BackingField;
            /*0x14*/ bool m_Loop;
            /*0x18*/ float m_ZeroValue;
            /*0x1c*/ float m_Range;
            /*0x20*/ UnityEngine.AnimationCurve m_Curve;
            /*0x28*/ UnityEngine.AnimationCurve m_LoopingCurve;
            /*0x30*/ UnityEngine.Texture2D m_Texture;
            /*0x38*/ bool m_IsCurveDirty;
            /*0x39*/ bool m_IsTextureDirty;

            static /*0x7bab7cc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x7bab5ac*/ TextureCurve(UnityEngine.AnimationCurve baseCurve, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x7bab600*/ TextureCurve(UnityEngine.Keyframe[] keys, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x7bab55c*/ int get_length();
            /*0x7bab564*/ void set_length(int value);
            /*0x7bab56c*/ UnityEngine.Keyframe get_Item(int index);
            /*0x7bab714*/ void Dispose();
            /*0x7bab718*/ void Release();
            /*0x7bab7c0*/ void SetDirty();
            /*0x7bab818*/ UnityEngine.Texture2D GetTexture();
            /*0x7baba20*/ float Evaluate(float time);
            /*0x7babc58*/ int AddKey(float time, float value);
            /*0x7babc90*/ int MoveKey(int index, ref UnityEngine.Keyframe key);
            /*0x7babce8*/ void RemoveKey(int index);
            /*0x7babd14*/ void SmoothTangents(int index, float weight);
        }

        class TextureCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureCurve>
        {
            /*0x7babd40*/ TextureCurveParameter(UnityEngine.Rendering.TextureCurve value, bool overrideState);
            /*0x7babda0*/ void Release();
        }

        class TextureGradient : System.IDisposable
        {
            /*0x10*/ int <textureSize>k__BackingField;
            /*0x18*/ UnityEngine.Gradient m_Gradient;
            /*0x20*/ UnityEngine.Texture2D m_Texture;
            /*0x28*/ int m_RequestedTextureSize;
            /*0x2c*/ bool m_IsTextureDirty;
            /*0x2d*/ bool m_Precise;
            /*0x30*/ UnityEngine.GradientMode mode;
            /*0x34*/ UnityEngine.ColorSpace colorSpace;

            static /*0x7bac404*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x7babdf0*/ TextureGradient(UnityEngine.Gradient baseCurve);
            /*0x7babee0*/ TextureGradient(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x7babdb8*/ int get_textureSize();
            /*0x7babdc0*/ void set_textureSize(int value);
            /*0x7babdc8*/ UnityEngine.GradientColorKey[] get_colorKeys();
            /*0x7babddc*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
            /*0x7babf58*/ void Rebuild(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x7bac34c*/ void Dispose();
            /*0x7bac350*/ void Release();
            /*0x7bac3f8*/ void SetDirty();
            /*0x7bac40c*/ UnityEngine.Texture2D GetTexture();
            /*0x7bac6ac*/ UnityEngine.Color Evaluate(float time);
            /*0x7bac6ec*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace);
        }

        class TextureGradientParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureGradient>
        {
            /*0x7bac774*/ TextureGradientParameter(UnityEngine.Rendering.TextureGradient value, bool overrideState);
            /*0x7bac7d4*/ void Release();
        }

        class TileLayoutUtils
        {
            static /*0x7bac7ec*/ bool TryLayoutByTiles(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt topRow, ref UnityEngine.RectInt rightCol, ref UnityEngine.RectInt topRight);
            static /*0x7bac894*/ bool TryLayoutByRow(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
            static /*0x7bac8f4*/ bool TryLayoutByCol(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
        }

        interface IVolume
        {
            /*0x3813ffc*/ bool get_isGlobal();
            /*0x3815cc4*/ void set_isGlobal(bool value);
            /*0x38148bc*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
        }

        class KeyframeUtility
        {
            static /*0x7bac954*/ void ResetAnimationCurve(UnityEngine.AnimationCurve curve);
            static /*0x7bac968*/ UnityEngine.Keyframe LerpSingleKeyframe(UnityEngine.Keyframe lhs, UnityEngine.Keyframe rhs, float t);
            static /*0x7bacb24*/ UnityEngine.Keyframe GetKeyframeAndClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index);
            static /*0x7bacc38*/ UnityEngine.Keyframe FetchKeyFromIndexClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index, float segmentStartTime, float segmentEndTime);
            static /*0x7bacdc4*/ void EvalCurveSegmentAndDeriv(ref float dstValue, ref float dstDeriv, UnityEngine.Keyframe lhsKey, UnityEngine.Keyframe rhsKey, float desiredTime);
            static /*0x7bacf50*/ UnityEngine.Keyframe EvalKeyAtTime(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime);
            static /*0x7bad03c*/ void InterpAnimationCurve(ref UnityEngine.AnimationCurve lhsAndResultCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x7bad6e8*/ KeyframeUtility();
        }

        class Volume : UnityEngine.MonoBehaviour, UnityEngine.Rendering.IVolume
        {
            /*0x20*/ bool m_IsGlobal;
            /*0x24*/ float priority;
            /*0x28*/ float blendDistance;
            /*0x2c*/ float weight;
            /*0x30*/ UnityEngine.Rendering.VolumeProfile sharedProfile;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Collider> m_Colliders;
            /*0x40*/ int m_PreviousLayer;
            /*0x44*/ float m_PreviousPriority;
            /*0x48*/ UnityEngine.Rendering.VolumeProfile m_InternalProfile;

            /*0x7badda4*/ Volume();
            /*0x7bad6f0*/ bool get_isGlobal();
            /*0x7bad6f8*/ void set_isGlobal(bool value);
            /*0x7bad704*/ UnityEngine.Rendering.VolumeProfile get_profile();
            /*0x7bad9ec*/ void set_profile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7bad9f4*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
            /*0x7bad9fc*/ UnityEngine.Rendering.VolumeProfile get_profileRef();
            /*0x7bada74*/ bool HasInstantiatedProfile();
            /*0x7badad4*/ void OnEnable();
            /*0x7badb7c*/ void OnDisable();
            /*0x7badbe4*/ void Update();
            /*0x7badbfc*/ void UpdateLayer();
            /*0x7badc9c*/ void UpdatePriority();
            /*0x7badd90*/ void OnValidate();
        }

        class VolumeCollection
        {
            static int k_MaxLayerCount = 32;
            /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;
            /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;

            static /*0x7bae6d8*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes);
            /*0x7baeaec*/ VolumeCollection();
            /*0x7bade3c*/ int get_count();
            /*0x7bade84*/ bool Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7bae37c*/ bool Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7bae5e0*/ bool ChangeLayer(UnityEngine.Rendering.Volume volume, int previousLayerIndex, int currentLayerIndex);
            /*0x7bae80c*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);
            /*0x7bae1f8*/ void SetLayerIndexDirty(int layerIndex);
            /*0x3910ae8*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
        }

        class VolumeComponentMenu : System.Attribute
        {
            /*0x10*/ string menu;

            /*0x7baec1c*/ VolumeComponentMenu(string menu);
        }

        class VolumeComponentMenuForRenderPipeline : UnityEngine.Rendering.VolumeComponentMenu
        {
            /*0x18*/ System.Type[] <pipelineTypes>k__BackingField;

            /*0x7baec54*/ VolumeComponentMenuForRenderPipeline(string menu, System.Type[] pipelineTypes);
            /*0x7baec4c*/ System.Type[] get_pipelineTypes();
        }

        class VolumeComponentDeprecated : System.Attribute
        {
            /*0x7baee2c*/ VolumeComponentDeprecated();
        }

        class VolumeComponent : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool active;
            /*0x20*/ string <displayName>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameterList;
            /*0x30*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> m_ParameterReadOnlyCollection;

            static /*0x7baeeb8*/ void FindParameters(object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo, bool> filter);
            /*0x7bb00b8*/ VolumeComponent();
            /*0x7baee34*/ string get_displayName();
            /*0x7baee3c*/ void set_displayName(string value);
            /*0x7baee44*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x7baf4e4*/ void OnEnable();
            /*0x7baf728*/ void OnDisable();
            /*0x7baf870*/ void Override(UnityEngine.Rendering.VolumeComponent state, float interpFactor);
            /*0x7baf994*/ void SetAllOverridesTo(bool state);
            /*0x7baf9a4*/ void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, bool state);
            /*0x7bafebc*/ int GetHashCode();
            /*0x7baff68*/ bool AnyPropertiesIsOverridden();
            /*0x7bb000c*/ void OnDestroy();
            /*0x7bb0010*/ void Release();

            class Indent : UnityEngine.PropertyAttribute
            {
                /*0x18*/ int relativeAmount;

                /*0x7bb016c*/ Indent(int relativeAmount);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeComponent.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__10_0;

                static /*0x7bb0194*/ <>c();
                /*0x7bb01fc*/ <>c();
                /*0x7bb0204*/ int <FindParameters>b__10_0(System.Reflection.FieldInfo t);
            }
        }

        struct VolumeIsolationScope : System.IDisposable
        {
            /*0x7bb022c*/ VolumeIsolationScope(bool unused);
            /*0x7bb0230*/ void System.IDisposable.Dispose();
        }

        class VolumeParameter : System.ICloneable
        {
            static string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
            /*0x10*/ bool m_OverrideState;

            static /*0x7bafd90*/ bool IsObjectParameter(System.Type type);
            /*0x7bb0254*/ VolumeParameter();
            /*0x7bb0234*/ bool get_overrideState();
            /*0x7bb023c*/ void set_overrideState(bool value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x3910ae8*/ T GetValue<T>();
            /*0x3816710*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x7bb0248*/ void OnEnable();
            /*0x7bb024c*/ void OnDisable();
            /*0x7bb0250*/ void Release();
            /*0x38148bc*/ object Clone();
        }

        class VolumeParameter<T> : UnityEngine.Rendering.VolumeParameter, System.IEquatable<UnityEngine.Rendering.VolumeParameter<T>>
        {
            /*0x0*/ T m_Value;

            static /*0x3910ae8*/ bool op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x3910ae8*/ bool op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x3910ae8*/ T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop);
            /*0x38159dc*/ VolumeParameter();
            /*0x3910ae8*/ VolumeParameter(T value, bool overrideState);
            /*0x3910ae8*/ T get_value();
            /*0x3910ae8*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x3910ae8*/ void Interp(T from, T to, float t);
            /*0x3910ae8*/ void Override(T x);
            /*0x3816710*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ string ToString();
            /*0x38141c4*/ bool Equals(UnityEngine.Rendering.VolumeParameter<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ object Clone();
        }

        class EnumParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x3910ae8*/ EnumParameter(T value, bool overrideState);
        }

        class BoolParameter : UnityEngine.Rendering.VolumeParameter<bool>
        {
            /*0x14*/ UnityEngine.Rendering.BoolParameter.DisplayType displayType;

            /*0x7bb025c*/ BoolParameter(bool value, bool overrideState);
            /*0x7bb02bc*/ BoolParameter(bool value, UnityEngine.Rendering.BoolParameter.DisplayType displayType, bool overrideState);

            enum DisplayType
            {
                Checkbox = 0,
                EnumPopup = 1,
            }
        }

        class LayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.LayerMask>
        {
            /*0x7bb0330*/ LayerMaskParameter(UnityEngine.LayerMask value, bool overrideState);
        }

        class RenderingLayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderingLayerMask>
        {
            /*0x7bb0390*/ RenderingLayerMaskParameter(UnityEngine.RenderingLayerMask value, bool overrideState);
        }

        class IntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x7bb03f0*/ IntParameter(int value, bool overrideState);
            /*0x7bb0450*/ void Interp(int from, int to, float t);
        }

        class NoInterpIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x7bb0484*/ NoInterpIntParameter(int value, bool overrideState);
        }

        class MinIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;

            /*0x7bb0500*/ MinIntParameter(int value, int min, bool overrideState);
            /*0x7bb04e4*/ int get_value();
            /*0x7bb04ec*/ void set_value(int value);
        }

        class NoInterpMinIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;

            /*0x7bb0544*/ NoInterpMinIntParameter(int value, int min, bool overrideState);
            /*0x7bb0528*/ int get_value();
            /*0x7bb0530*/ void set_value(int value);
        }

        class MaxIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int max;

            /*0x7bb05d4*/ MaxIntParameter(int value, int max, bool overrideState);
            /*0x7bb05b8*/ int get_value();
            /*0x7bb05c0*/ void set_value(int value);
        }

        class NoInterpMaxIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int max;

            /*0x7bb0618*/ NoInterpMaxIntParameter(int value, int max, bool overrideState);
            /*0x7bb05fc*/ int get_value();
            /*0x7bb0604*/ void set_value(int value);
        }

        class ClampedIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x7bb06b0*/ ClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x7bb068c*/ int get_value();
            /*0x7bb0694*/ void set_value(int value);
        }

        class NoInterpClampedIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x7bb0700*/ NoInterpClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x7bb06dc*/ int get_value();
            /*0x7bb06e4*/ void set_value(int value);
        }

        class FloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x7bb0778*/ FloatParameter(float value, bool overrideState);
            /*0x7bb07e0*/ void Interp(float from, float to, float t);
        }

        class NoInterpFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x7bb07f4*/ NoInterpFloatParameter(float value, bool overrideState);
        }

        class MinFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;

            /*0x7bb0878*/ MinFloatParameter(float value, float min, bool overrideState);
            /*0x7bb085c*/ float get_value();
            /*0x7bb0864*/ void set_value(float value);
        }

        class NoInterpMinFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;

            /*0x7bb08bc*/ NoInterpMinFloatParameter(float value, float min, bool overrideState);
            /*0x7bb08a0*/ float get_value();
            /*0x7bb08a8*/ void set_value(float value);
        }

        class MaxFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float max;

            /*0x7bb094c*/ MaxFloatParameter(float value, float max, bool overrideState);
            /*0x7bb0930*/ float get_value();
            /*0x7bb0938*/ void set_value(float value);
        }

        class NoInterpMaxFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float max;

            /*0x7bb0990*/ NoInterpMaxFloatParameter(float value, float max, bool overrideState);
            /*0x7bb0974*/ float get_value();
            /*0x7bb097c*/ void set_value(float value);
        }

        class ClampedFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x7bb0a28*/ ClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x7bb0a04*/ float get_value();
            /*0x7bb0a0c*/ void set_value(float value);
        }

        class NoInterpClampedFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x7bb0a78*/ NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x7bb0a54*/ float get_value();
            /*0x7bb0a5c*/ void set_value(float value);
        }

        class FloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x7bb0b1c*/ FloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x7bb0af8*/ UnityEngine.Vector2 get_value();
            /*0x7bb0b00*/ void set_value(UnityEngine.Vector2 value);
            /*0x7bb0ba4*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpFloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x7bb0be8*/ NoInterpFloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x7bb0bc4*/ UnityEngine.Vector2 get_value();
            /*0x7bb0bcc*/ void set_value(UnityEngine.Vector2 value);
        }

        class ColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x7bb0c70*/ ColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x7bb0d00*/ ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
            /*0x7bb0dd4*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
        }

        class NoInterpColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x7bb0e04*/ NoInterpColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x7bb0e94*/ NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
        }

        class Vector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x7bb0f68*/ Vector2Parameter(UnityEngine.Vector2 value, bool overrideState);
            /*0x7bb0fd8*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpVector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x7bb0ff8*/ NoInterpVector2Parameter(UnityEngine.Vector2 value, bool overrideState);
        }

        class Vector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x7bb1068*/ Vector3Parameter(UnityEngine.Vector3 value, bool overrideState);
            /*0x7bb10e8*/ void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float t);
        }

        class NoInterpVector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x7bb1118*/ NoInterpVector3Parameter(UnityEngine.Vector3 value, bool overrideState);
        }

        class Vector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x7bb1198*/ Vector4Parameter(UnityEngine.Vector4 value, bool overrideState);
            /*0x7bb1220*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
        }

        class NoInterpVector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x7bb1250*/ NoInterpVector4Parameter(UnityEngine.Vector4 value, bool overrideState);
        }

        class TextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x20*/ UnityEngine.Rendering.TextureDimension dimension;

            /*0x7bb12d8*/ TextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7bb12e4*/ TextureParameter(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, bool overrideState);
            /*0x7bb1358*/ int GetHashCode();
        }

        class NoInterpTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7bb145c*/ NoInterpTextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7bb14bc*/ int GetHashCode();
        }

        class Texture2DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7bb15c0*/ Texture2DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7bb1620*/ int GetHashCode();
        }

        class Texture3DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7bb1724*/ Texture3DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7bb1784*/ int GetHashCode();
        }

        class RenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x7bb1888*/ RenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x7bb18e8*/ int GetHashCode();
        }

        class NoInterpRenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x7bb19ec*/ NoInterpRenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x7bb1a4c*/ int GetHashCode();
        }

        class CubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7bb1b50*/ CubemapParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7bb1bb0*/ int GetHashCode();
        }

        class NoInterpCubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Cubemap>
        {
            /*0x7bb1cb4*/ NoInterpCubemapParameter(UnityEngine.Cubemap value, bool overrideState);
            /*0x7bb1d14*/ int GetHashCode();
        }

        class ObjectParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            /*0x3910ae8*/ ObjectParameter(T value);
            /*0x38148bc*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x3816710*/ void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            /*0x3813ffc*/ bool get_overrideState();
            /*0x3815cc4*/ void set_overrideState(bool value);
            /*0x3910ae8*/ T get_value();
            /*0x3910ae8*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x3814a3c*/ UnityEngine.Rendering.VolumeParameter <set_value>b__9_2(System.Reflection.FieldInfo t);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ObjectParameter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__9_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, int> <>9__9_1;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x38141c4*/ bool <set_value>b__9_0(System.Reflection.FieldInfo t);
                /*0x381467c*/ int <set_value>b__9_1(System.Reflection.FieldInfo t);
            }
        }

        class AnimationCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.AnimationCurve>
        {
            /*0x7bb1e18*/ AnimationCurveParameter(UnityEngine.AnimationCurve value, bool overrideState);
            /*0x7bb1e78*/ void Interp(UnityEngine.AnimationCurve lhsCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x7bb1eb8*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x7bb1f48*/ object Clone();
            /*0x7bb2028*/ int GetHashCode();
        }

        class MaterialParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Material>
        {
            /*0x7bb20b4*/ MaterialParameter(UnityEngine.Material value, bool overrideState);
        }

        class VolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;
            /*0x20*/ bool isDirty;

            /*0x7bb2b30*/ VolumeProfile();
            /*0x7bb2114*/ void OnEnable();
            /*0x7bb2218*/ void OnDisable();
            /*0x7bb22fc*/ void Reset();
            /*0x3910ae8*/ T Add<T>(bool overrides);
            /*0x7bb2308*/ UnityEngine.Rendering.VolumeComponent Add(System.Type type, bool overrides);
            /*0x38159dc*/ void Remove<T>();
            /*0x7bb2638*/ void Remove(System.Type type);
            /*0x3813ffc*/ bool Has<T>();
            /*0x7bb2490*/ bool Has(System.Type type);
            /*0x7bb2744*/ bool HasSubclassOf(System.Type type);
            /*0x38141c4*/ bool TryGet<T>(ref T component);
            /*0x3814200*/ bool TryGet<T>(System.Type type, ref T component);
            /*0x3814200*/ bool TryGetSubclassOf<T>(System.Type type, ref T component);
            /*0x3814200*/ bool TryGetAllSubclassOf<T>(System.Type type, System.Collections.Generic.List<T> result);
            /*0x7bb28d4*/ int GetHashCode();
            /*0x7bb2980*/ int GetComponentListHashCode();
            /*0x7bb2a38*/ void Sanitize();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeProfile.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.VolumeComponent> <>9__2_0;

                static /*0x7bb2bc0*/ <>c();
                /*0x7bb2c28*/ <>c();
                /*0x7bb2c30*/ bool <OnEnable>b__2_0(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class VolumeStack : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.VolumeComponent> components;
            /*0x18*/ UnityEngine.Rendering.VolumeParameter[] parameters;
            /*0x20*/ bool requiresReset;
            /*0x21*/ bool requiresResetForAllProperties;
            /*0x22*/ bool <isValid>k__BackingField;

            /*0x7bb2c8c*/ VolumeStack();
            /*0x7bb2d1c*/ void Clear();
            /*0x7bb2ec8*/ void Reload(System.Type[] componentTypes);
            /*0x3910ae8*/ T GetComponent<T>();
            /*0x7bb309c*/ UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type);
            /*0x7bb310c*/ void Dispose();
            /*0x7bb3124*/ bool get_isValid();
            /*0x7bb312c*/ void set_isValid(bool value);
        }

        class XRGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;
            static /*0x1*/ bool running;

            static /*0x7bb3704*/ XRGraphicsAutomatedTests();
            static /*0x7bb3138*/ bool get_activatedFromCommandLine();
            static /*0x7bb3140*/ bool get_enabled();
            static /*0x7bb3198*/ void OverrideLayout(UnityEngine.Experimental.Rendering.XRLayout layout, UnityEngine.Camera camera);
        }

        class XRSRPSettings
        {
            static /*0x7bb374c*/ bool get_enabled();
            static /*0x7bb3754*/ bool get_isDeviceActive();
            static /*0x7bb377c*/ string get_loadedDeviceName();
            static /*0x7bb37cc*/ string[] get_supportedDevices();
            static /*0x7bb3820*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x7bb3898*/ int get_eyeTextureWidth();
            static /*0x7bb38c0*/ int get_eyeTextureHeight();
            static /*0x7bb38e8*/ float get_occlusionMeshScale();
            static /*0x7bb3980*/ void set_occlusionMeshScale(float value);
            static /*0x7bb3a20*/ int get_mirrorViewMode();
            static /*0x7bb3a80*/ void set_mirrorViewMode(int value);
            /*0x7bb3af0*/ XRSRPSettings();
        }

        namespace RenderGraphModule
        {
            class RenderGraphDebugParams : UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
                /*0x18*/ UnityEngine.Rendering.DebugUI.Panel m_DebugPanel;
                /*0x20*/ bool clearRenderTargetsAtCreation;
                /*0x21*/ bool clearRenderTargetsAtRelease;
                /*0x22*/ bool disablePassCulling;
                /*0x23*/ bool immediateMode;
                /*0x24*/ bool enableLogging;
                /*0x25*/ bool logFrameInformation;
                /*0x26*/ bool logResources;

                /*0x7bb4558*/ RenderGraphDebugParams();
                /*0x7bb3af8*/ void Reset();
                /*0x7bb3b04*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList(string name);
                /*0x7bb428c*/ bool IsImmediateModeSupported();
                /*0x7bb4364*/ void RegisterDebug(string name, UnityEngine.Rendering.DebugUI.Panel debugPanel);
                /*0x7bb44a0*/ void UnRegisterDebug(string name);
                /*0x7bb4520*/ bool get_AreAnySettingsActive();
                /*0x7bb4560*/ bool <GetWidgetList>b__11_0();
                /*0x7bb4568*/ void <GetWidgetList>b__11_1(bool value);
                /*0x7bb4574*/ bool <GetWidgetList>b__11_2();
                /*0x7bb457c*/ void <GetWidgetList>b__11_3(bool value);
                /*0x7bb4588*/ bool <GetWidgetList>b__11_4();
                /*0x7bb4590*/ void <GetWidgetList>b__11_5(bool value);
                /*0x7bb459c*/ bool <GetWidgetList>b__11_6();
                /*0x7bb45a4*/ void <GetWidgetList>b__11_7(bool value);
                /*0x7bb45b0*/ bool <GetWidgetList>b__11_8();
                /*0x7bb45c8*/ bool <GetWidgetList>b__11_9();
                /*0x7bb45d0*/ void <GetWidgetList>b__11_10(bool value);
                /*0x7bb45dc*/ void <GetWidgetList>b__11_11();
                /*0x7bb465c*/ void <GetWidgetList>b__11_12();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtFree;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip DisablePassCulling;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ImmediateMode;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip EnableLogging;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogFrameInformation;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogResources;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip EnableNativeCompiler;

                    static /*0x7bb46dc*/ Strings();
                }
            }

            interface IBaseRenderGraphBuilder : System.IDisposable
            {
                /*0x381678c*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3815fb8*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3815cc4*/ void UseAllGlobalTextures(bool enable);
                /*0x381678c*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x3816710*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x3815cc4*/ void EnableAsyncCompute(bool value);
                /*0x3815cc4*/ void AllowPassCulling(bool value);
                /*0x3815cc4*/ void AllowGlobalStateModification(bool value);
                /*0x3815cc4*/ void EnableFoveatedRasterization(bool value);
            }

            interface IComputeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
            }

            interface IUnsafeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
            }

            interface IRasterRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x7bb4a88*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bb4b58*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bb4c28*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
            }

            interface IRenderGraphEnabledRenderPipeline
            {
                /*0x3813ffc*/ bool get_isImmediateModeSupported();
            }

            interface IRenderGraphRecorder
            {
                /*0x3816810*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            }

            class RenderGraph
            {
                static string k_BeginProfilingSamplerPassName = "BeginProfile";
                static string k_EndProfilingSamplerPassName = "EndProfile";
                static /*0x0*/ int kMaxMRTCount;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph> s_RegisteredGraphs;
                static /*0x10*/ bool <isRenderGraphViewerActive>k__BackingField;
                static /*0x11*/ bool <enableValidityChecks>k__BackingField;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphRegistered;
                static /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered;
                static /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered;
                static /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered;
                static /*0x38*/ System.Action onDebugDataCaptured;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler nativeCompiler;
                /*0x18*/ bool <nativeRenderPassesEnabled>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool m_RenderGraphPool;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilders m_builderInstance;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> m_RenderPasses;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> m_RendererLists;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams m_DebugParameters;
                /*0x50*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources m_DefaultResources;
                /*0x60*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProfilingSampler> m_DefaultProfilingSamplers;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext m_RenderGraphContext;
                /*0x70*/ UnityEngine.Rendering.CommandBuffer m_PreviousCommandBuffer;
                /*0x78*/ System.Collections.Generic.List<int> m_ImmediateModeResourceList;
                /*0x80*/ RenderGraphCompilationCache m_CompilationCache;
                /*0x88*/ UnityEngine.Rendering.RenderTargetIdentifier[][] m_TempMRTArrays;
                /*0x90*/ System.Collections.Generic.Stack<int> m_CullingStack;
                /*0x98*/ string m_CurrentExecutionName;
                /*0xa0*/ int m_ExecutionCount;
                /*0xa4*/ int m_CurrentFrameIndex;
                /*0xa8*/ int m_CurrentImmediatePassIndex;
                /*0xac*/ bool m_ExecutionExceptionWasRaised;
                /*0xad*/ bool m_HasRenderGraphBegun;
                /*0xae*/ bool m_RendererListCulling;
                /*0xaf*/ bool m_EnableCompilationCaching;
                /*0xb0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph m_DefaultCompiledGraph;
                /*0xb8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph m_CurrentCompiledGraph;
                /*0xc0*/ string m_CaptureDebugDataForExecution;
                /*0xc8*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData> m_DebugData;
                /*0xd0*/ string <name>k__BackingField;
                /*0xd8*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RenderGraphModule.TextureHandle> registeredGlobals;
                /*0xe0*/ string[] k_PassNameDebugIgnoreList;

                static /*0x7bbf128*/ RenderGraph();
                static /*0x7bb51b4*/ bool get_isRenderGraphViewerActive();
                static /*0x7bb520c*/ void set_isRenderGraphViewerActive(bool value);
                static /*0x7bb526c*/ bool get_enableValidityChecks();
                static /*0x7bb52c4*/ void set_enableValidityChecks(bool value);
                static /*0x7bb5cb0*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs();
                static /*0x7bb7c78*/ void add_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7bb7d54*/ void remove_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7bb7e30*/ void add_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7bb7f0c*/ void remove_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7bb7fe8*/ void add_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7bb80c4*/ void remove_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7bb81a0*/ void add_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7bb827c*/ void remove_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7bb8358*/ void add_onDebugDataCaptured(System.Action value);
                static /*0x7bb8434*/ void remove_onDebugDataCaptured(System.Action value);
                /*0x7bb532c*/ RenderGraph(string name);
                /*0x7bb4cf0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler CompileNativeRenderGraph(int graphHash);
                /*0x7bb5000*/ void ExecuteNativeRenderGraph();
                /*0x7bb5188*/ bool get_nativeRenderPassesEnabled();
                /*0x7bb5190*/ void set_nativeRenderPassesEnabled(bool value);
                /*0x7bb519c*/ string get_name();
                /*0x7bb51a4*/ void set_name(string value);
                /*0x7bb51ac*/ void RequestCaptureDebugData(string executionName);
                /*0x7bb5324*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7bb5af8*/ void Cleanup();
                /*0x7bb5c00*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams get_debugParams();
                /*0x7bb5c08*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList();
                /*0x7bb5c28*/ bool get_areAnySettingsActive();
                /*0x7bb5c74*/ void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x7bb5c98*/ void UnRegisterDebug();
                /*0x7bb5d08*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData GetDebugData(string executionName);
                /*0x7bb5d80*/ void EndFrame();
                /*0x7bb5e48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                /*0x7bb5e74*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bb5ea0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bb5ef0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x7bb5f1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bb5f68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                /*0x7bb5fe0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bb6000*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x7bb6070*/ void RefreshSharedTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bb60a4*/ void ReleaseSharedTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb6124*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb61a0*/ void CreateTextureIfInvalid(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb62c8*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb6314*/ UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo GetRenderTargetInfo(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb6364*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7bb6388*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x7bb63ac*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawingSettings);
                /*0x7bb63e0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7bb6418*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x7bb645c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x7bb6494*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x7bb64c8*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera);
                /*0x7bb64fc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x7bb6584*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x7bb6654*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x7ba6c0c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bb667c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x7bb66e0*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x7bb6724*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3910ae8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x7bb6748*/ void BeginRecording(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphParameters parameters);
                /*0x7bb6c50*/ void EndRecordingAndExecute();
                /*0x7bb6c54*/ void Execute();
                /*0x7bb74f4*/ void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x7bb7728*/ void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x7bb795c*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos();
                /*0x7bb7978*/ void ClearCompiledGraph();
                /*0x7bb7984*/ void ClearCompiledGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph compiledGraph, bool useCompilationCaching);
                /*0x7bb7bd8*/ void InvalidateContext();
                /*0x7bb7c24*/ void OnPassAdded(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7bb6e80*/ int ComputeGraphHash();
                /*0x7bb8510*/ void CountReferences();
                /*0x7bb8ce0*/ void CullUnusedPasses();
                /*0x7bb96e0*/ void UpdatePassSynchronization(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo currentPassInfo, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex);
                /*0x7bb9708*/ void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo resource);
                /*0x7bb99f4*/ int GetFirstValidConsumerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7bb9ba0*/ int FindTextureProducer(int consumerPass, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info, ref int index);
                /*0x7bb9840*/ int GetLatestProducerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7bb9cbc*/ int GetLatestValidReadIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7bb9d9c*/ int GetFirstValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7bb9e90*/ int GetLatestValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7bb9f70*/ void CreateRendererLists();
                /*0x7bba094*/ bool GetImportedFallback(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle fallback);
                /*0x7bba36c*/ void AllocateCulledPassResources(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7bba738*/ void UpdateResourceAllocationAndSynchronization();
                /*0x7bbb01c*/ void UpdateAllSharedResourceLastFrameIndex();
                /*0x7bbb14c*/ bool AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists);
                /*0x7bbb384*/ void TryCullPassAtIndex(int passIndex);
                /*0x7bbb458*/ void CullRendererLists();
                /*0x7bb6a24*/ bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching);
                /*0x7bb6ff4*/ void CompileRenderGraph(int graphHash);
                /*0x7bbb66c*/ ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo CompilePassImmediatly(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7bb7c5c*/ void ExecutePassImmediately(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7bbbf9c*/ void ExecuteCompiledPass(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7bb7180*/ void ExecuteRenderGraph();
                /*0x7bbce54*/ void PreRenderPassSetRenderTargets(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7bbc6a0*/ void PreRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7bbc9fc*/ void PostRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7bb7a4c*/ void ClearRenderPasses();
                /*0x7bbd3d0*/ void ReleaseImmediateModeResources();
                /*0x7bb6a70*/ void LogFrameInformation();
                /*0x7bbb558*/ void LogRendererListsCreation();
                /*0x7bbc360*/ void LogRenderPassBegin(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7bb92f8*/ void LogCulledPasses();
                /*0x7bbd568*/ UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(string name);
                /*0x7bbd570*/ void UpdateImportedResourceLifeTime(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData data, System.Collections.Generic.List<int> passList);
                /*0x7bbd744*/ void GenerateDebugData();
                /*0x7bbdb14*/ void GenerateCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);
                /*0x7bbd958*/ void CleanupDebugData();
                /*0x7bbecc0*/ void SetGlobal(UnityEngine.Rendering.RenderGraphModule.TextureHandle h, int globalPropertyId);
                /*0x7bbee48*/ bool IsGlobal(int globalPropertyId);
                /*0x7bbeea0*/ System.Collections.Generic.Dictionary.ValueCollection<int, UnityEngine.Rendering.RenderGraphModule.TextureHandle> AllGlobals();
                /*0x7bbeef0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle GetGlobal(int globalPropertyId);
                /*0x7bb72e8*/ void ClearGlobalBindings();
                /*0x7bbef60*/ void AddPassDebugMetadata(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, string file, int line);
                /*0x7bbf0b0*/ void ClearPassDebugMetadata();

                struct CompiledResourceInfo
                {
                    /*0x10*/ System.Collections.Generic.List<int> producers;
                    /*0x18*/ System.Collections.Generic.List<int> consumers;
                    /*0x20*/ int refCount;
                    /*0x24*/ bool imported;

                    /*0x7bbf1c8*/ void Reset();
                }

                struct CompiledPassInfo
                {
                    /*0x10*/ string name;
                    /*0x18*/ int index;
                    /*0x20*/ System.Collections.Generic.List<int> resourceCreateList;
                    /*0x28*/ System.Collections.Generic.List<int> resourceReleaseList;
                    /*0x30*/ UnityEngine.Rendering.GraphicsFence fence;
                    /*0x40*/ int refCount;
                    /*0x44*/ int syncToPassIndex;
                    /*0x48*/ int syncFromPassIndex;
                    /*0x4c*/ bool enableAsyncCompute;
                    /*0x4d*/ bool allowPassCulling;
                    /*0x4e*/ bool needGraphicsFence;
                    /*0x4f*/ bool culled;
                    /*0x50*/ bool culledByRendererList;
                    /*0x51*/ bool hasSideEffect;
                    /*0x52*/ bool enableFoveatedRasterization;

                    /*0x7bbf2c8*/ void Reset(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int index);
                }

                interface ICompiledGraph
                {
                    /*0x38159dc*/ void Clear();
                }

                class CompiledGraph : UnityEngine.Rendering.RenderGraphModule.RenderGraph.ICompiledGraph
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> compiledResourcesInfos;
                    /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> compiledPassInfos;
                    /*0x20*/ int lastExecutionFrame;

                    /*0x7bbf524*/ CompiledGraph();
                    /*0x7bbf690*/ void Clear();
                    /*0x7bbf738*/ void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, int count);
                    /*0x7bbf7ec*/ void InitializeCompilationData(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                }

                class ProfilingScopePassData
                {
                    /*0x10*/ UnityEngine.Rendering.ProfilingSampler sampler;

                    /*0x7bbf9a4*/ ProfilingScopePassData();
                }

                class OnGraphRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x7bbf9ac*/ OnGraphRegisteredDelegate(object object, nint method);
                    /*0x7bbfab4*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph);
                    /*0x7bbfac8*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, object object);
                    /*0x7bbfae8*/ void EndInvoke(System.IAsyncResult result);
                }

                class OnExecutionRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x7bbfaf4*/ OnExecutionRegisteredDelegate(object object, nint method);
                    /*0x7bbfc00*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName);
                    /*0x7bbfc14*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName, System.AsyncCallback callback, object object);
                    /*0x7bbfc3c*/ void EndInvoke(System.IAsyncResult result);
                }

                class DebugData
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<object, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassScriptInfo> s_PassScriptMetadata;
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData> passList;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData> resourceLists;
                    /*0x20*/ bool isNRPCompiler;

                    static /*0x7bbfe80*/ DebugData();
                    /*0x7bbfc48*/ DebugData();
                    /*0x7bbfdb4*/ void Clear();

                    struct PassData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType type;
                        /*0x20*/ System.Collections.Generic.List<int> resourceReadLists;
                        /*0x28*/ System.Collections.Generic.List<int> resourceWriteLists;
                        /*0x30*/ bool culled;
                        /*0x31*/ bool async;
                        /*0x34*/ int nativeSubPassIndex;
                        /*0x38*/ int syncToPassIndex;
                        /*0x3c*/ int syncFromPassIndex;
                        /*0x40*/ bool generateDebugData;
                        /*0x48*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo nrpInfo;
                        /*0x50*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassScriptInfo scriptInfo;

                        class NRPInfo
                        {
                            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo nativePassInfo;
                            /*0x18*/ System.Collections.Generic.List<int> textureFBFetchList;
                            /*0x20*/ System.Collections.Generic.List<int> setGlobals;
                            /*0x28*/ int width;
                            /*0x2c*/ int height;
                            /*0x30*/ int volumeDepth;
                            /*0x34*/ int samples;
                            /*0x38*/ bool hasDepth;

                            /*0x7bbff18*/ NRPInfo();

                            class NativeRenderPassInfo
                            {
                                /*0x10*/ string passBreakReasoning;
                                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo> attachmentInfos;
                                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.PassCompatibilityInfo> passCompatibility;
                                /*0x28*/ System.Collections.Generic.List<int> mergedPassIds;

                                /*0x7bbffc4*/ NativeRenderPassInfo();

                                class AttachmentInfo
                                {
                                    /*0x10*/ string resourceName;
                                    /*0x18*/ string loadReason;
                                    /*0x20*/ string storeReason;
                                    /*0x28*/ string storeMsaaReason;
                                    /*0x30*/ int attachmentIndex;
                                    /*0x34*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment attachment;

                                    /*0x7bbffcc*/ AttachmentInfo();
                                }

                                struct PassCompatibilityInfo
                                {
                                    /*0x10*/ string message;
                                    /*0x18*/ bool isCompatible;
                                }
                            }
                        }
                    }

                    class BufferResourceData
                    {
                        /*0x10*/ int count;
                        /*0x14*/ int stride;
                        /*0x18*/ UnityEngine.GraphicsBuffer.Target target;
                        /*0x1c*/ UnityEngine.GraphicsBuffer.UsageFlags usage;

                        /*0x7bbffd4*/ BufferResourceData();
                    }

                    class TextureResourceData
                    {
                        /*0x10*/ int width;
                        /*0x14*/ int height;
                        /*0x18*/ int depth;
                        /*0x1c*/ bool bindMS;
                        /*0x20*/ int samples;
                        /*0x24*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
                        /*0x28*/ bool clearBuffer;

                        /*0x7bbffdc*/ TextureResourceData();
                    }

                    struct ResourceData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ bool imported;
                        /*0x1c*/ int creationPassIndex;
                        /*0x20*/ int releasePassIndex;
                        /*0x28*/ System.Collections.Generic.List<int> consumerList;
                        /*0x30*/ System.Collections.Generic.List<int> producerList;
                        /*0x38*/ bool memoryless;
                        /*0x40*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.TextureResourceData textureData;
                        /*0x48*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.BufferResourceData bufferData;
                    }

                    class PassScriptInfo
                    {
                        /*0x10*/ string filePath;
                        /*0x18*/ int line;

                        /*0x7bbffe4*/ PassScriptInfo();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__110_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__111_0;

                    static /*0x7bbffec*/ <>c();
                    /*0x7bc0054*/ <>c();
                    /*0x7bc005c*/ void <BeginProfilingSampler>b__110_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                    /*0x7bc00a0*/ void <EndProfilingSampler>b__111_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                }
            }

            enum DepthAccess
            {
                Read = 1,
                Write = 2,
                ReadWrite = 3,
            }

            enum AccessFlags
            {
                None = 0,
                Read = 1,
                Write = 2,
                Discard = 4,
                WriteAll = 6,
                ReadWrite = 3,
            }

            class InternalRenderGraphContext
            {
                /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext renderContext;
                /*0x18*/ UnityEngine.Rendering.CommandBuffer cmd;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool renderGraphPool;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources defaultResources;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass;
                /*0x38*/ bool contextlessTesting;

                /*0x7bc00c8*/ InternalRenderGraphContext();
            }

            interface IDerivedRendergraphContext
            {
                /*0x3816710*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            struct RenderGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;

                /*0x7bc00d0*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
                /*0x7bc00d8*/ UnityEngine.Rendering.ScriptableRenderContext get_renderContext();
                /*0x7bc0084*/ UnityEngine.Rendering.CommandBuffer get_cmd();
                /*0x7bc00f4*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7bc0110*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
            }

            struct RasterGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rastercmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.RasterCommandBuffer cmd;

                static /*0x7bc022c*/ RasterGraphContext();
                /*0x7bc012c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7bc0148*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7bc0164*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class ComputeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.ComputeCommandBuffer computecmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.ComputeCommandBuffer cmd;

                static /*0x7bc03c0*/ ComputeGraphContext();
                /*0x7bc03b8*/ ComputeGraphContext();
                /*0x7bc02b4*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7bc02d0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7bc02ec*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class UnsafeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.UnsafeCommandBuffer unsCmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.UnsafeCommandBuffer cmd;

                static /*0x7bc0554*/ UnsafeGraphContext();
                /*0x7bc054c*/ UnsafeGraphContext();
                /*0x7bc0448*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7bc0464*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7bc0480*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            struct RenderGraphParameters
            {
                /*0x10*/ string executionName;
                /*0x18*/ int currentFrameIndex;
                /*0x1c*/ bool rendererListCulling;
                /*0x20*/ UnityEngine.Rendering.ScriptableRenderContext scriptableRenderContext;
                /*0x28*/ UnityEngine.Rendering.CommandBuffer commandBuffer;
                /*0x30*/ bool invalidContextForTesting;
            }

            class BaseRenderFunc<PassData, ContextType> : System.MulticastDelegate
            {
                BaseRenderFunc(object object, nint method);
                /*0x3910ae8*/ void Invoke(PassData data, ContextType renderGraphContext);
                /*0x3910ae8*/ System.IAsyncResult BeginInvoke(PassData data, ContextType renderGraphContext, System.AsyncCallback callback, object object);
                /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
            }

            struct RenderGraphProfilingScope : System.IDisposable
            {
                /*0x7bc05dc*/ RenderGraphProfilingScope(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x7bc05e0*/ void Dispose();
                /*0x7bc05e4*/ void Dispose(bool disposing);
            }

            struct RenderGraphBuilder : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x7bc16c4*/ RenderGraphBuilder(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7bc05e8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index);
                /*0x7bc07b4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x7bc0acc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7bc0a88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle WriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7bc0cac*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7bc0d04*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bc0e5c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bc104c*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x7bc1094*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x7bc10c0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7bc1180*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ReadBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x7bc11ac*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle WriteBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x7bc11f4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bc1354*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsbuffer);
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> renderFunc);
                /*0x7bc154c*/ void EnableAsyncCompute(bool value);
                /*0x7bc156c*/ void AllowPassCulling(bool value);
                /*0x7bc158c*/ void EnableFoveatedRasterization(bool value);
                /*0x7bc15ac*/ void Dispose();
                /*0x7bc15ec*/ void AllowRendererListCulling(bool value);
                /*0x7bc160c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle DependsOn(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7bc15b4*/ void Dispose(bool disposing);
                /*0x7bc1710*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x7bc1ad4*/ void GenerateDebugData(bool value);
            }

            class RenderGraphBuilders : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable, UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x7bc1af4*/ RenderGraphBuilders();
                /*0x7bc1b44*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7bc1bf4*/ void EnableAsyncCompute(bool value);
                /*0x7bc1c14*/ void AllowPassCulling(bool value);
                /*0x7bc1c48*/ void AllowGlobalStateModification(bool value);
                /*0x7bc1c70*/ void EnableFoveatedRasterization(bool value);
                /*0x7bc1c90*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bc1f38*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x7bc1f80*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bc1fe8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bc2038*/ void Dispose();
                /*0x7bc204c*/ void Dispose(bool disposing);
                /*0x7bc249c*/ void ValidateWriteTo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bc1d00*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle UseResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, bool isTransient);
                /*0x7bc2bbc*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc2bdc*/ void CheckNotUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex);
                /*0x7bc2494*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc2fe8*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc31a4*/ void UseAllGlobalTextures(bool enable);
                /*0x7bc31c4*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x7bc32ec*/ void CheckUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, bool isDepth);
                /*0x7bc3d88*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bc3e08*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bc3e88*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bc3f00*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc3f84*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc4014*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
                /*0x3816710*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
                /*0x7bc40b0*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7bc290c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bc4164*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x7bc4478*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc4480*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x7bc4484*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bc44a4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bc44a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bc44ac*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bc44c0*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x7bc44d4*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
            }

            class RenderGraphDefaultResources
            {
                /*0x10*/ UnityEngine.Rendering.RTHandle m_BlackTexture2D;
                /*0x18*/ UnityEngine.Rendering.RTHandle m_WhiteTexture2D;
                /*0x20*/ UnityEngine.Rendering.RTHandle m_ShadowTexture2D;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <blackTexture>k__BackingField;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <whiteTexture>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <clearTextureXR>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <magentaTextureXR>k__BackingField;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <blackTextureXR>k__BackingField;
                /*0x78*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <blackTextureArrayXR>k__BackingField;
                /*0x88*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <blackUIntTextureXR>k__BackingField;
                /*0x98*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <blackTexture3DXR>k__BackingField;
                /*0xa8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <whiteTextureXR>k__BackingField;
                /*0xb8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <defaultShadowTexture>k__BackingField;

                /*0x7bc45a0*/ RenderGraphDefaultResources();
                /*0x7bc44d8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture();
                /*0x7bc44e4*/ void set_blackTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc44ec*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTexture();
                /*0x7bc44f8*/ void set_whiteTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4500*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR();
                /*0x7bc450c*/ void set_clearTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4514*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR();
                /*0x7bc4520*/ void set_magentaTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4528*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR();
                /*0x7bc4534*/ void set_blackTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc453c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR();
                /*0x7bc4548*/ void set_blackTextureArrayXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4550*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR();
                /*0x7bc455c*/ void set_blackUIntTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4564*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR();
                /*0x7bc4570*/ void set_blackTexture3DXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc4578*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR();
                /*0x7bc4584*/ void set_whiteTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc458c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture();
                /*0x7bc4598*/ void set_defaultShadowTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bc46cc*/ void Cleanup();
                /*0x7bc470c*/ void InitializeForRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            }

            struct RenderGraphLogIndent : System.IDisposable
            {
                /*0x10*/ int m_Indentation;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;
                /*0x20*/ bool m_Disposed;

                /*0x7bc4900*/ RenderGraphLogIndent(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger, int indentation);
                /*0x7bc49b0*/ void Dispose();
                /*0x7bc49e0*/ void Dispose(bool disposing);
            }

            class RenderGraphLogger
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, System.Text.StringBuilder> m_LogMap;
                /*0x18*/ System.Text.StringBuilder m_CurrentBuilder;
                /*0x20*/ int m_CurrentIndentation;

                /*0x7bc4e6c*/ RenderGraphLogger();
                /*0x7bc4a90*/ void Initialize(string logName);
                /*0x7bc4940*/ void IncrementIndentation(int value);
                /*0x7bc4a14*/ void DecrementIndentation(int value);
                /*0x7bc4b80*/ void LogLine(string format, object[] args);
                /*0x7bc4bf8*/ string GetLog(string logName);
                /*0x7bc4c98*/ string GetAllLogs();
            }

            class RenderGraphObjectPool
            {
                static /*0x0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;
                /*0x10*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, int>, System.Collections.Generic.Stack<object>> m_ArrayPool;
                /*0x18*/ System.Collections.Generic.List<System.ValueTuple<object, System.ValueTuple<System.Type, int>>> m_AllocatedArrays;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

                static /*0x7bc5608*/ RenderGraphObjectPool();
                /*0x7bc4ef4*/ RenderGraphObjectPool();
                /*0x3814964*/ T[] GetTempArray<T>(int size);
                /*0x7bc5024*/ UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock();
                /*0x7bc5120*/ void ReleaseAllTempAlloc();
                /*0x3910ae8*/ T Get<T>();
                /*0x3910ae8*/ void Release<T>(T value);
                /*0x7bc5478*/ void Cleanup();

                class SharedObjectPoolBase
                {
                    /*0x7bc56a0*/ SharedObjectPoolBase();
                    /*0x7bc56a8*/ void Clear();
                }

                class SharedObjectPool<T> : UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase
                {
                    static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

                    static /*0x383e7a0*/ SharedObjectPool();
                    static /*0x3836db8*/ UnityEngine.Pool.ObjectPool<T> AllocatePool();
                    static /*0x3910ae8*/ T Get();
                    static /*0x3910ae8*/ void Release(T toRelease);
                    /*0x38159dc*/ SharedObjectPool();
                    /*0x38159dc*/ void Clear();

                    class <>c<T>
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool.<>c<T> <>9;
                        static /*0x0*/ System.Func<T> <>9__1_0;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3910ae8*/ T <AllocatePool>b__1_0();
                    }
                }
            }

            class RenderGraphPass
            {
                /*0x10*/ string <name>k__BackingField;
                /*0x18*/ int <index>k__BackingField;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType <type>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler <customSampler>k__BackingField;
                /*0x28*/ bool <enableAsyncCompute>k__BackingField;
                /*0x29*/ bool <allowPassCulling>k__BackingField;
                /*0x2a*/ bool <allowGlobalState>k__BackingField;
                /*0x2b*/ bool <enableFoveatedRasterization>k__BackingField;
                /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess <depthAccess>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] <colorBufferAccess>k__BackingField;
                /*0x50*/ int <colorBufferMaxIndex>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] <fragmentInputAccess>k__BackingField;
                /*0x60*/ int <fragmentInputMaxIndex>k__BackingField;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] <randomAccessResource>k__BackingField;
                /*0x70*/ int <randomAccessResourceMaxIndex>k__BackingField;
                /*0x74*/ bool <generateDebugData>k__BackingField;
                /*0x75*/ bool <allowRendererListCulling>k__BackingField;
                /*0x78*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> resourceReadLists;
                /*0x80*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> resourceWriteLists;
                /*0x88*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> transientResourceList;
                /*0x90*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> usedRendererListList;
                /*0x98*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Rendering.RenderGraphModule.TextureHandle, int>> setGlobalsList;
                /*0xa0*/ bool useAllGlobalTextures;
                /*0xa8*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> implicitReadsList;

                static /*0x7bc82e8*/ void ComputeHashForTextureAccess(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureAccess textureAccess);
                /*0x7bc57f4*/ RenderGraphPass();
                /*0x3816710*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x3813ffc*/ bool HasRenderFunc();
                /*0x3814574*/ int GetRenderFuncHash();
                /*0x7bc56ac*/ string get_name();
                /*0x7bc56b4*/ void set_name(string value);
                /*0x7bc56bc*/ int get_index();
                /*0x7bc56c4*/ void set_index(int value);
                /*0x7bc56cc*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType get_type();
                /*0x7bc56d4*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType value);
                /*0x7bc56dc*/ UnityEngine.Rendering.ProfilingSampler get_customSampler();
                /*0x7bc56e4*/ void set_customSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7bc56ec*/ bool get_enableAsyncCompute();
                /*0x7bc56f4*/ void set_enableAsyncCompute(bool value);
                /*0x7bc5700*/ bool get_allowPassCulling();
                /*0x7bc5708*/ void set_allowPassCulling(bool value);
                /*0x7bc5714*/ bool get_allowGlobalState();
                /*0x7bc571c*/ void set_allowGlobalState(bool value);
                /*0x7bc5728*/ bool get_enableFoveatedRasterization();
                /*0x7bc5730*/ void set_enableFoveatedRasterization(bool value);
                /*0x7bc573c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess get_depthAccess();
                /*0x7bc5750*/ void set_depthAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess value);
                /*0x7bc576c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_colorBufferAccess();
                /*0x7bc5774*/ void set_colorBufferAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x7bc577c*/ int get_colorBufferMaxIndex();
                /*0x7bc5784*/ void set_colorBufferMaxIndex(int value);
                /*0x7bc578c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_fragmentInputAccess();
                /*0x7bc5794*/ void set_fragmentInputAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x7bc579c*/ int get_fragmentInputMaxIndex();
                /*0x7bc57a4*/ void set_fragmentInputMaxIndex(int value);
                /*0x7bc57ac*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] get_randomAccessResource();
                /*0x7bc57b4*/ void set_randomAccessResource(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] value);
                /*0x7bc57bc*/ int get_randomAccessResourceMaxIndex();
                /*0x7bc57c4*/ void set_randomAccessResourceMaxIndex(int value);
                /*0x7bc57cc*/ bool get_generateDebugData();
                /*0x7bc57d4*/ void set_generateDebugData(bool value);
                /*0x7bc57e0*/ bool get_allowRendererListCulling();
                /*0x7bc57e8*/ void set_allowRendererListCulling(bool value);
                /*0x7bc5b88*/ void Clear();
                /*0x7bc5d1c*/ bool HasRenderAttachments();
                /*0x7bc5ef8*/ bool IsTransient(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc5fd0*/ bool IsWritten(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc6150*/ bool IsRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc638c*/ bool IsAttachment(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle res);
                /*0x7bc65ec*/ void AddResourceWrite(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc671c*/ void AddResourceRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc684c*/ void AddTransientResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc697c*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x7bc6a2c*/ void EnableAsyncCompute(bool value);
                /*0x7bc6a38*/ void AllowPassCulling(bool value);
                /*0x7bc6a44*/ void EnableFoveatedRasterization(bool value);
                /*0x7bc6a50*/ void AllowRendererListCulling(bool value);
                /*0x7bc6a5c*/ void AllowGlobalState(bool value);
                /*0x7bc6a68*/ void GenerateDebugData(bool value);
                /*0x7bc6a74*/ void SetColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index);
                /*0x7bc6b34*/ void SetColorBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7bc6dcc*/ void SetFragmentInputRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7bc7064*/ void SetRandomWriteResourceRaw(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags);
                /*0x7bc72b4*/ void SetDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x7bc7324*/ void SetDepthBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7bc74e0*/ void ComputeTextureHash(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                /*0x7bc79d8*/ void ComputeHash(ref UnityEngine.Rendering.HashFNV1A32 generator, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);

                struct RandomWriteResourceInfo
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle h;
                    /*0x1c*/ bool preserveCounterValue;
                }
            }

            class BaseRenderGraphPass<PassData, TRenderGraphContext> : UnityEngine.Rendering.RenderGraphModule.RenderGraphPass
            {
                /*0x0*/ PassData data;
                /*0x0*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, TRenderGraphContext> renderFunc;

                /*0x38159dc*/ BaseRenderGraphPass();
                /*0x3910ae8*/ void Initialize(int passIndex, PassData passData, string passName, UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType passType, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x3813ffc*/ bool HasRenderFunc();
                /*0x3814574*/ int GetRenderFuncHash();
            }

            class RenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphContext c;

                static /*0x383e7a0*/ RenderGraphPass();
                /*0x38159dc*/ RenderGraphPass();
                /*0x3816710*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class ComputeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext c;

                static /*0x383e7a0*/ ComputeRenderGraphPass();
                /*0x38159dc*/ ComputeRenderGraphPass();
                /*0x3816710*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class RasterRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RasterGraphContext c;

                static /*0x383e7a0*/ RasterRenderGraphPass();
                /*0x38159dc*/ RasterRenderGraphPass();
                /*0x3816710*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class UnsafeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext c;

                static /*0x383e7a0*/ UnsafeRenderGraphPass();
                /*0x38159dc*/ UnsafeRenderGraphPass();
                /*0x3816710*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x3816710*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            enum RenderGraphPassType
            {
                Legacy = 0,
                Unsafe = 1,
                Raster = 2,
                Compute = 3,
            }

            enum RenderGraphProfileId
            {
                CompileRenderGraph = 0,
                ExecuteRenderGraph = 1,
                ComputeHashRenderGraph = 2,
            }

            struct RayTracingAccelerationStructureHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;

                static /*0x7bc8724*/ RayTracingAccelerationStructureHandle();
                static /*0x7bc8394*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle get_nullHandle();
                static /*0x7bc84d4*/ UnityEngine.Rendering.RayTracingAccelerationStructure op_Implicit(UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x7bc83f0*/ RayTracingAccelerationStructureHandle(int handle);
                /*0x7bc85b4*/ bool IsValid();
            }

            struct RayTracingAccelerationStructureDesc
            {
                /*0x10*/ string name;
            }

            class RayTracingAccelerationStructureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc, UnityEngine.Rendering.RayTracingAccelerationStructure>
            {
                /*0x7bc8730*/ RayTracingAccelerationStructureResource();
                /*0x7bc8728*/ string GetName();
            }

            struct BufferHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;

                static /*0x7bc8a78*/ BufferHandle();
                static /*0x7bc8778*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_nullHandle();
                static /*0x7bc8828*/ UnityEngine.GraphicsBuffer op_Implicit(UnityEngine.Rendering.RenderGraphModule.BufferHandle buffer);
                /*0x7bc87d4*/ BufferHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x7bc87e8*/ BufferHandle(int handle, bool shared);
                /*0x7bc8908*/ bool IsValid();
            }

            struct BufferDesc
            {
                /*0x10*/ int count;
                /*0x14*/ int stride;
                /*0x18*/ string name;
                /*0x20*/ UnityEngine.GraphicsBuffer.Target target;
                /*0x24*/ UnityEngine.GraphicsBuffer.UsageFlags usageFlags;

                /*0x7bc8a7c*/ BufferDesc(int count, int stride);
                /*0x7bc8a94*/ BufferDesc(int count, int stride, UnityEngine.GraphicsBuffer.Target target);
                /*0x7bc8aa8*/ int GetHashCode();
            }

            class BufferResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.BufferDesc, UnityEngine.GraphicsBuffer>
            {
                /*0x7bc8e4c*/ BufferResource();
                /*0x7bc8af0*/ string GetName();
                /*0x7bc8b44*/ int GetDescHashCode();
                /*0x7bc8b8c*/ void CreateGraphicsResource();
                /*0x7bc8c24*/ void UpdateGraphicsResource();
                /*0x7bc8c58*/ void ReleaseGraphicsResource();
                /*0x7bc8ca4*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bc8d78*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class BufferPool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.GraphicsBuffer>
            {
                /*0x7bc8f94*/ BufferPool();
                /*0x7bc8e94*/ void ReleaseInternalResource(UnityEngine.GraphicsBuffer res);
                /*0x7bc8eac*/ string GetResourceName(ref UnityEngine.GraphicsBuffer res);
                /*0x7bc8eec*/ long GetResourceSize(ref UnityEngine.GraphicsBuffer res);
                /*0x7bc8f30*/ string GetResourceTypeName();
                /*0x7bc8f70*/ int GetSortIndex(UnityEngine.GraphicsBuffer res);
            }

            class IRenderGraphResourcePool
            {
                /*0x7bc9000*/ IRenderGraphResourcePool();
                /*0x3815ed0*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x38159dc*/ void Cleanup();
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x3816710*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class RenderGraphResourcePool<Type> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool
            {
                static int kStaleResourceLifetime = 10;
                static /*0x0*/ System.Collections.Generic.List<int> s_ToRemoveList;
                /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<Type, int>>> m_ResourcePool;
                /*0x0*/ System.Collections.Generic.List<System.ValueTuple<int, Type>> m_FrameAllocatedResources;

                static /*0x383e7a0*/ RenderGraphResourcePool();
                /*0x38159dc*/ RenderGraphResourcePool();
                /*0x3910ae8*/ void ReleaseInternalResource(Type res);
                /*0x3814a3c*/ string GetResourceName(ref Type res);
                long GetResourceSize(ref Type res);
                /*0x38148bc*/ string GetResourceTypeName();
                /*0x3910ae8*/ int GetSortIndex(Type res);
                /*0x3910ae8*/ void ReleaseResource(int hash, Type resource, int currentFrameIndex);
                /*0x3814140*/ bool TryGetResource(int hashCode, ref Type resource);
                /*0x38159dc*/ void Cleanup();
                /*0x3910ae8*/ void RegisterFrameAllocation(int hash, Type value);
                /*0x3910ae8*/ void UnregisterFrameAllocation(int hash, Type value);
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x3816710*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x3815ed0*/ void PurgeUnusedResources(int currentFrameIndex);

                struct ResourceLogInfo<Type>
                {
                    /*0x0*/ string name;
                    /*0x0*/ long size;
                }

                class <>c<Type>
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.<>c<Type> <>9;
                    static /*0x0*/ System.Comparison<UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__15_0;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x3910ae8*/ int <LogResources>b__15_0(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> a, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> b);
                }
            }

            struct RenderTargetInfo
            {
                /*0x10*/ int width;
                /*0x14*/ int height;
                /*0x18*/ int volumeDepth;
                /*0x1c*/ int msaaSamples;
                /*0x20*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
                /*0x24*/ bool bindMS;
            }

            struct ImportResourceParams
            {
                /*0x10*/ bool clearOnFirstUse;
                /*0x14*/ UnityEngine.Color clearColor;
                /*0x24*/ bool discardOnLastUse;
            }

            class RenderGraphResourceRegistry
            {
                static int kSharedResourceLifetime = 30;
                static int kInitialRendererListCount = 256;
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_CurrentRegistry;
                static /*0x8*/ UnityEngine.Rendering.RenderTargetIdentifier emptyId;
                static /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier builtinCameraRenderTarget;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources;
                /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RendererListResource> m_RendererListResources;
                /*0x20*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RendererListLegacyResource> m_RendererListLegacyResources;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams m_RenderGraphDebug;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_ResourceLogger;
                /*0x38*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                /*0x40*/ int m_CurrentFrameIndex;
                /*0x44*/ int m_ExecutionCount;
                /*0x48*/ UnityEngine.Rendering.RTHandle m_CurrentBackbuffer;
                /*0x50*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererList> m_ActiveRendererLists;
                /*0x58*/ bool forceManualClearOfResource;

                static /*0x7bcdd1c*/ RenderGraphResourceRegistry();
                static /*0x7bc9008*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current();
                static /*0x7bc9060*/ void set_current(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry value);
                /*0x7bc98a0*/ RenderGraphResourceRegistry();
                /*0x7bc9a48*/ RenderGraphResourceRegistry(UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger);
                /*0x7bc90c8*/ void CheckTextureResource(UnityEngine.Rendering.RenderGraphModule.TextureResource texResource);
                /*0x7bc9180*/ UnityEngine.Rendering.RTHandle GetTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7bc92a4*/ UnityEngine.Rendering.RTHandle GetTexture(int index);
                /*0x7bc0954*/ bool TextureNeedsFallback(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7bc9388*/ UnityEngine.Rendering.RendererList GetRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x7bc94e0*/ void CheckBufferResource(UnityEngine.Rendering.RenderGraphModule.BufferResource bufferResource);
                /*0x7bc89d8*/ UnityEngine.GraphicsBuffer GetBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle handle);
                /*0x7bc9688*/ UnityEngine.GraphicsBuffer GetBuffer(int index);
                /*0x7bc8684*/ UnityEngine.Rendering.RayTracingAccelerationStructure GetRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x7bc9868*/ int GetSharedResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x7bca17c*/ void BeginRenderGraph(int executionCount);
                /*0x7bca2e8*/ void BeginExecute(int currentFrameIndex);
                /*0x7bca4e8*/ void EndExecute();
                /*0x7bca57c*/ void CheckHandleValidity(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bca580*/ void CheckHandleValidity(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bc06c4*/ void IncrementWriteCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc295c*/ void IncrementReadCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bca73c*/ void NewVersion(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc27d8*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bca904*/ int GetLatestVersionNumber(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc2a4c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetZeroVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc2a7c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetNewVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcaa14*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource GetResourceLowLevel(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc26e8*/ string GetRenderGraphResourceName(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcaaf8*/ string GetRenderGraphResourceName(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bc0868*/ bool IsRenderGraphResourceImported(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcab94*/ bool IsRenderGraphResourceForceReleased(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bcac2c*/ bool IsRenderGraphResourceShared(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bca82c*/ bool IsRenderGraphResourceShared(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcac6c*/ bool IsGraphicsResourceCreated(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcad5c*/ bool IsRendererListCreated(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle res);
                /*0x7bcae60*/ bool IsRenderGraphResourceImported(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bc19e8*/ int GetRenderGraphResourceTransientIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bcaef8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x7bcaf1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams, bool isBuiltin);
                /*0x7bcb2d4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bcb4a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x7bcb69c*/ void RefreshSharedTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bcb6f0*/ void ReleaseSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bcb7b8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bcb994*/ void ValidateRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bc39b8*/ void GetRenderTargetInfo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo outInfo);
                /*0x7bcba50*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x7bcbb58*/ void ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x7bc0d58*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, int transientPassIndex);
                /*0x7bcbc4c*/ int GetResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x7bbf98c*/ int GetTextureResourceCount();
                /*0x7bc0bb8*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bc92c0*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(int index);
                /*0x7bc0edc*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x7bcbcbc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7bcbe24*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x7bcbefc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawinSettings);
                /*0x7bcbfc0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7bcc098*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x7bcc170*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x7bcc238*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x7bcc300*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x7bcc424*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x7bcc5a4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x7bc1254*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc, int transientPassIndex);
                /*0x7bc13d4*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x7bbf994*/ int GetBufferResourceCount();
                /*0x7bc9590*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bc96a4*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(int index);
                /*0x7bc9770*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bbf99c*/ int GetRayTracingAccelerationStructureResourceCount();
                /*0x7bcc690*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                /*0x7bcc780*/ void UpdateSharedResourceLastFrameIndex(int type, int index);
                /*0x7bcc81c*/ void UpdateSharedResourceLastFrameIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bca398*/ void ManageSharedRenderGraphResources();
                /*0x7bcc884*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x7bcca0c*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bccab8*/ bool CreateTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x7bccc88*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x7bccdc0*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bcce6c*/ void ReleaseTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x7bccfb8*/ void ValidateTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bcd1a0*/ void ValidateRendererListDesc(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7bcd364*/ void ValidateBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bcd470*/ void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, bool manualDispatch);
                /*0x7bcd7b8*/ void Clear(bool onException);
                /*0x7bcdae0*/ void PurgeUnusedGraphicsResources();
                /*0x7bcdb60*/ void Cleanup();
                /*0x7bcdcac*/ void FlushLogs();
                /*0x7bcd8a8*/ void LogResources();

                class ResourceCreateCallback : System.MulticastDelegate
                {
                    /*0x7bc9ef8*/ ResourceCreateCallback(object object, nint method);
                    /*0x7bcdda8*/ bool Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x7bcddbc*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x7bcdde4*/ bool EndInvoke(System.IAsyncResult result);
                }

                class ResourceCallback : System.MulticastDelegate
                {
                    /*0x7bca004*/ ResourceCallback(object object, nint method);
                    /*0x7bcde0c*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x7bcde20*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x7bcde48*/ void EndInvoke(System.IAsyncResult result);
                }

                class RenderGraphResourcesData
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;
                    /*0x18*/ int sharedResourcesCount;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;

                    /*0x7bc9e3c*/ RenderGraphResourcesData();
                    /*0x7bcda48*/ void Clear(bool onException, int frameIndex);
                    /*0x7bcdbf8*/ void Cleanup();
                    /*0x7bcdb48*/ void PurgeUnusedGraphicsResources(int frameIndex);
                    /*0x3910ae8*/ int AddNewRenderGraphResource<ResType>(ref ResType outRes, bool pooledResource);
                }
            }

            enum RendererListHandleType
            {
                Renderers = 0,
                Legacy = 1,
            }

            struct RendererListHandle
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandleType type;
                /*0x14*/ bool m_IsValid;
                /*0x18*/ int <handle>k__BackingField;

                static /*0x7bc94d8*/ int op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                static /*0x7bcde64*/ UnityEngine.Rendering.RendererList op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x7bcbe10*/ RendererListHandle(int handle, UnityEngine.Rendering.RenderGraphModule.RendererListHandleType type);
                /*0x7bcde54*/ int get_handle();
                /*0x7bcde5c*/ void set_handle(int value);
                /*0x7bcdf6c*/ bool IsValid();
            }

            struct RendererListResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererListParams desc;
                /*0x140*/ UnityEngine.Rendering.RendererList rendererList;

                /*0x7bcbdf0*/ RendererListResource(ref UnityEngine.Rendering.RendererListParams desc);
            }

            struct RendererListLegacyResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererList rendererList;
                /*0x28*/ bool isActive;

                /*0x7bcdf74*/ RendererListLegacyResource(ref bool active);
            }

            enum RenderGraphResourceType
            {
                Texture = 0,
                Buffer = 1,
                AccelerationStructure = 2,
                Count = 3,
            }

            struct ResourceHandle : System.IEquatable<UnityEngine.Rendering.RenderGraphModule.ResourceHandle>
            {
                static uint kValidityMask = 4294901760;
                static uint kIndexMask = 65535;
                static /*0x0*/ uint s_CurrentValidBit;
                static /*0x4*/ uint s_SharedResourceValidBit;
                /*0x10*/ uint m_Value;
                /*0x14*/ int m_Version;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType <type>k__BackingField;

                static /*0x7bce1a8*/ ResourceHandle();
                static /*0x7bca228*/ void NewFrame(int executionIndex);
                /*0x7bc8430*/ ResourceHandle(int value, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, bool shared);
                /*0x7bca894*/ ResourceHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int version);
                /*0x7bcdf90*/ int get_index();
                /*0x7bcdf98*/ int get_iType();
                /*0x7bcdfec*/ int get_version();
                /*0x7bcdff4*/ void set_version(int value);
                /*0x7bcdffc*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType get_type();
                /*0x7bce004*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType value);
                /*0x7bce00c*/ bool IsValid();
                /*0x7bce0ac*/ bool IsNull();
                /*0x7bce108*/ bool get_IsVersioned();
                /*0x7bce118*/ bool Equals(UnityEngine.Rendering.RenderGraphModule.ResourceHandle hdl);
            }

            class IRenderGraphResource
            {
                /*0x10*/ bool imported;
                /*0x11*/ bool shared;
                /*0x12*/ bool sharedExplicitRelease;
                /*0x13*/ bool requestFallBack;
                /*0x14*/ bool forceRelease;
                /*0x18*/ uint writeCount;
                /*0x1c*/ uint readCount;
                /*0x20*/ int cachedHash;
                /*0x24*/ int transientPassIndex;
                /*0x28*/ int sharedResourceLastFrameUsed;
                /*0x2c*/ int version;

                /*0x7bce2e0*/ IRenderGraphResource();
                /*0x7bce1f8*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool _);
                /*0x7bce218*/ string GetName();
                /*0x7bce258*/ bool IsCreated();
                /*0x7bce260*/ void IncrementWriteCount();
                /*0x7bce270*/ void IncrementReadCount();
                /*0x7bce280*/ int NewVersion();
                /*0x7bce294*/ bool NeedsFallBack();
                /*0x7bce2b4*/ void CreatePooledGraphicsResource();
                /*0x7bce2b8*/ void CreateGraphicsResource();
                /*0x7bce2bc*/ void UpdateGraphicsResource();
                /*0x7bce2c0*/ void ReleasePooledGraphicsResource(int frameIndex);
                /*0x7bce2c4*/ void ReleaseGraphicsResource();
                /*0x7bce2c8*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bce2cc*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bce2d0*/ int GetSortIndex();
                /*0x7bce2d8*/ int GetDescHashCode();
            }

            class RenderGraphResource<DescType, ResType> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource
            {
                /*0x0*/ DescType desc;
                /*0x0*/ bool validDesc;
                /*0x0*/ ResType graphicsResource;
                /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<ResType> m_Pool;

                /*0x38159dc*/ RenderGraphResource();
                /*0x3816710*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                /*0x3813ffc*/ bool IsCreated();
                /*0x38159dc*/ void ReleaseGraphicsResource();
                /*0x38159dc*/ void CreatePooledGraphicsResource();
                /*0x3815ed0*/ void ReleasePooledGraphicsResource(int frameIndex);
            }

            struct TextureAccess
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle textureHandle;
                /*0x20*/ int mipLevel;
                /*0x24*/ int depthSlice;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.AccessFlags flags;

                /*0x7bc7314*/ TextureAccess(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
            }

            struct TextureHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;
                /*0x1c*/ bool builtin;

                static /*0x7bcea94*/ TextureHandle();
                static /*0x7bce2e8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_nullHandle();
                static /*0x7bce358*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bce504*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bce680*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bce7fc*/ UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bce340*/ TextureHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x7bcb284*/ TextureHandle(int handle, bool shared, bool builtin);
                /*0x7bce974*/ bool IsValid();
                /*0x7bcea44*/ bool IsBuiltin();
                /*0x7bcea4c*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetDescriptor(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            }

            enum TextureSizeMode
            {
                Explicit = 0,
                Scale = 1,
                Functor = 2,
            }

            struct FastMemoryDesc
            {
                /*0x10*/ bool inFastMemory;
                /*0x14*/ UnityEngine.Rendering.FastMemoryFlags flags;
                /*0x18*/ float residencyFraction;
            }

            struct TextureDesc
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureSizeMode sizeMode;
                /*0x14*/ int width;
                /*0x18*/ int height;
                /*0x1c*/ int slices;
                /*0x20*/ UnityEngine.Vector2 scale;
                /*0x28*/ UnityEngine.Rendering.ScaleFunc func;
                /*0x30*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
                /*0x34*/ UnityEngine.FilterMode filterMode;
                /*0x38*/ UnityEngine.TextureWrapMode wrapMode;
                /*0x3c*/ UnityEngine.Rendering.TextureDimension dimension;
                /*0x40*/ bool enableRandomWrite;
                /*0x41*/ bool useMipMap;
                /*0x42*/ bool autoGenerateMips;
                /*0x43*/ bool isShadowMap;
                /*0x44*/ int anisoLevel;
                /*0x48*/ float mipMapBias;
                /*0x4c*/ UnityEngine.Rendering.MSAASamples msaaSamples;
                /*0x50*/ bool bindTextureMS;
                /*0x51*/ bool useDynamicScale;
                /*0x52*/ bool useDynamicScaleExplicit;
                /*0x54*/ UnityEngine.RenderTextureMemoryless memoryless;
                /*0x58*/ UnityEngine.VRTextureUsage vrUsage;
                /*0x60*/ string name;
                /*0x68*/ UnityEngine.Rendering.RenderGraphModule.FastMemoryDesc fastMemoryDesc;
                /*0x74*/ bool fallBackToBlackTexture;
                /*0x75*/ bool disableFallBackToImportedTexture;
                /*0x76*/ bool clearBuffer;
                /*0x78*/ UnityEngine.Color clearColor;
                /*0x88*/ bool discardBuffer;

                /*0x7bceccc*/ TextureDesc(int width, int height, bool dynamicResolution, bool xrReady);
                /*0x7bced00*/ TextureDesc(UnityEngine.Vector2 scale, bool dynamicResolution, bool xrReady);
                /*0x7bced38*/ TextureDesc(UnityEngine.Rendering.ScaleFunc func, bool dynamicResolution, bool xrReady);
                /*0x7bced9c*/ TextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureDesc input);
                /*0x7bcedbc*/ TextureDesc(UnityEngine.RenderTextureDescriptor input);
                /*0x7bcb1a8*/ TextureDesc(UnityEngine.RenderTexture input);
                /*0x7bcea98*/ UnityEngine.Rendering.DepthBits get_depthBufferBits();
                /*0x7bceaf4*/ void set_depthBufferBits(UnityEngine.Rendering.DepthBits value);
                /*0x7bceb88*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_colorFormat();
                /*0x7bcebf8*/ void set_colorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
                /*0x7bcec00*/ void InitDefaultValues(bool dynamicResolution, bool xrReady);
                /*0x7bcef4c*/ int GetHashCode();
                /*0x7bcba5c*/ UnityEngine.Vector2Int CalculateFinalDimensions();
            }

            class TextureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.TextureDesc, UnityEngine.Rendering.RTHandle>
            {
                static /*0x0*/ int m_TextureCreationIndex;

                /*0x7bcf800*/ TextureResource();
                /*0x7bcf134*/ string GetName();
                /*0x7bcf1a0*/ int GetDescHashCode();
                /*0x7bcf1a8*/ void CreateGraphicsResource();
                /*0x7bcf5a4*/ void UpdateGraphicsResource();
                /*0x7bcf5d8*/ void ReleaseGraphicsResource();
                /*0x7bcf624*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bcf72c*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class TexturePool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.Rendering.RTHandle>
            {
                /*0x7bca110*/ TexturePool();
                /*0x7bcf848*/ void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res);
                /*0x7bcf860*/ string GetResourceName(ref UnityEngine.Rendering.RTHandle res);
                /*0x7bcf884*/ long GetResourceSize(ref UnityEngine.Rendering.RTHandle res);
                /*0x7bcf8a4*/ string GetResourceTypeName();
                /*0x7bcf8e4*/ int GetSortIndex(UnityEngine.Rendering.RTHandle res);
            }

            namespace Util
            {
                class RenderGraphUtils
                {
                    static /*0x0*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
                    static /*0x8*/ UnityEngine.Vector4 s_BlitScaleBias;

                    static /*0x7bd1390*/ RenderGraphUtils();
                    static /*0x7bcf8fc*/ bool CanAddCopyPassMSAA();
                    static /*0x7bcf94c*/ void AddCopyPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, int sourceSlice, int destinationSlice, int sourceMip, int destinationMip, string passName, string file, int line);
                    static /*0x7bd0018*/ void CopyRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    static /*0x7bd0088*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceSlice, int destinationSlice, int numSlices, int sourceMip, int destinationMip, int numMips, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitFilterMode filterMode, string passName, string file, int line);
                    static /*0x7bd06dc*/ void BlitRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    static /*0x7bd0908*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialParameters blitParameters, string passName, string file, int line);
                    static /*0x7bd0ff8*/ void BlitMaterialRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);

                    class CopyPassData
                    {
                        /*0x10*/ bool isMSAA;

                        /*0x7bd141c*/ CopyPassData();
                    }

                    enum BlitFilterMode
                    {
                        ClampNearest = 0,
                        ClampBilinear = 1,
                    }

                    class BlitPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ UnityEngine.Vector2 scale;
                        /*0x38*/ UnityEngine.Vector2 offset;
                        /*0x40*/ int sourceSlice;
                        /*0x44*/ int destinationSlice;
                        /*0x48*/ int numSlices;
                        /*0x4c*/ int sourceMip;
                        /*0x50*/ int destinationMip;
                        /*0x54*/ int numMips;
                        /*0x58*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitFilterMode filterMode;

                        /*0x7bd1424*/ BlitPassData();
                    }

                    enum FullScreenGeometryType
                    {
                        Mesh = 0,
                        ProceduralTriangle = 1,
                        ProceduralQuad = 2,
                    }

                    struct BlitMaterialParameters
                    {
                        static /*0x0*/ int blitTextureProperty;
                        static /*0x4*/ int blitSliceProperty;
                        static /*0x8*/ int blitMipProperty;
                        static /*0xc*/ int blitScaleBias;
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x30*/ UnityEngine.Vector2 scale;
                        /*0x38*/ UnityEngine.Vector2 offset;
                        /*0x40*/ int sourceSlice;
                        /*0x44*/ int destinationSlice;
                        /*0x48*/ int numSlices;
                        /*0x4c*/ int sourceMip;
                        /*0x50*/ int destinationMip;
                        /*0x54*/ int numMips;
                        /*0x58*/ UnityEngine.Material material;
                        /*0x60*/ int shaderPass;
                        /*0x68*/ UnityEngine.MaterialPropertyBlock propertyBlock;
                        /*0x70*/ int sourceTexturePropertyID;
                        /*0x74*/ int sourceSlicePropertyID;
                        /*0x78*/ int sourceMipPropertyID;
                        /*0x7c*/ int scaleBiasPropertyID;
                        /*0x80*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry;

                        static /*0x7bd1bb8*/ BlitMaterialParameters();
                        /*0x7bd142c*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass);
                        /*0x7bd154c*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass);
                        /*0x7bd1650*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x7bd17cc*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
                        /*0x7bd1928*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x7bd1a84*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
                    }

                    class BlitMaterialPassData
                    {
                        /*0x10*/ int sourceTexturePropertyID;
                        /*0x14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x24*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x34*/ UnityEngine.Vector2 scale;
                        /*0x3c*/ UnityEngine.Vector2 offset;
                        /*0x48*/ UnityEngine.Material material;
                        /*0x50*/ int shaderPass;
                        /*0x58*/ UnityEngine.MaterialPropertyBlock propertyBlock;
                        /*0x60*/ int sourceSlice;
                        /*0x64*/ int destinationSlice;
                        /*0x68*/ int numSlices;
                        /*0x6c*/ int sourceMip;
                        /*0x70*/ int destinationMip;
                        /*0x74*/ int numMips;
                        /*0x78*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry;
                        /*0x7c*/ int sourceSlicePropertyID;
                        /*0x80*/ int sourceMipPropertyID;
                        /*0x84*/ int scaleBiasPropertyID;

                        /*0x7bd1cb4*/ BlitMaterialPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__3_0;
                        static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__7_0;
                        static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__13_0;

                        static /*0x7bd1cbc*/ <>c();
                        /*0x7bd1d24*/ <>c();
                        /*0x7bd1d2c*/ void <AddCopyPass>b__3_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                        /*0x7bd1d98*/ void <AddBlitPass>b__7_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                        /*0x7bd1dfc*/ void <AddBlitPass>b__13_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    }
                }

                class RenderGraphUtilsResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtilsResources.Version m_Version;
                    /*0x18*/ UnityEngine.Shader m_CoreCopyPS;

                    /*0x7bd1ee4*/ RenderGraphUtilsResources();
                    /*0x7bd1e60*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
                    /*0x7bd1e68*/ UnityEngine.Shader get_coreCopyPS();
                    /*0x7bd1e70*/ void set_coreCopyPS(UnityEngine.Shader value);

                    enum Version
                    {
                        Initial = 0,
                        Count = 1,
                        Latest = 0,
                    }
                }
            }

            namespace NativeRenderPassCompiler
            {
                struct Name
                {
                    /*0x10*/ string name;
                    /*0x18*/ int utf8ByteCount;

                    /*0x7bd1eec*/ Name(string name, bool computeUTF8ByteCount);
                }

                class NativeListExtensions
                {
                    static /*0x3910ae8*/ System.ReadOnlySpan<T> MakeReadOnlySpan<T>(ref Unity.Collections.NativeList<T> list, int first, int numElements);
                    static /*0x382da78*/ int LastIndex<T>(ref Unity.Collections.NativeList<T> list);
                }

                class CompilerContextData : System.IDisposable, UnityEngine.Rendering.RenderGraphModule.RenderGraph.ICompiledGraph
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourcesData resources;
                    /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData> passData;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.GraphicsFence> fences;
                    /*0x28*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> passNames;
                    /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassInputData> inputData;
                    /*0x38*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassOutputData> outputData;
                    /*0x40*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> fragmentData;
                    /*0x48*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> createData;
                    /*0x50*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> destroyData;
                    /*0x58*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData> randomAccessResourceData;
                    /*0x60*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData> nativePassData;
                    /*0x68*/ Unity.Collections.NativeList<UnityEngine.Rendering.SubPassDescriptor> nativeSubPassData;
                    /*0x70*/ bool m_Disposed;

                    /*0x7bd1fb8*/ CompilerContextData(int estimatedNumPasses);
                    /*0x7bd2324*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resourceRegistry);
                    /*0x7bd2340*/ void Clear();
                    /*0x7bd24d8*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData UnversionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bd25b4*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData VersionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bd25d4*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> Readers(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bd275c*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData ResourceReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int i);
                    /*0x7bd28a4*/ bool AddToFragmentList(UnityEngine.Rendering.RenderGraphModule.TextureAccess access, int listFirstIndex, int numItems);
                    /*0x7bd29e8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetFullPassName(int passId);
                    /*0x7bd2a4c*/ string GetPassName(int passId);
                    /*0x7bd2aac*/ string GetResourceName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bd2b94*/ string GetResourceVersionedName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bd2c58*/ bool AddToRandomAccessResourceList(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems);
                    /*0x7bd2ec4*/ void TagAllPasses(int value);
                    /*0x7bd2f74*/ void CullAllPasses(bool isCulled);
                    /*0x7bd3024*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator get_NativePasses();
                    /*0x7bd3074*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData> GetNativePasses();
                    /*0x7bd3320*/ void Finalize();
                    /*0x7bd3510*/ void Dispose();
                    /*0x7bd33b4*/ void Cleanup();

                    struct NativePassIterator
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData m_Ctx;
                        /*0x18*/ int m_Index;

                        /*0x7bd3054*/ NativePassIterator(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                        /*0x7bd3204*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData get_Current();
                        /*0x7bd325c*/ bool MoveNext();
                        /*0x7bd31f8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator GetEnumerator();
                    }
                }

                struct FixedAttachmentArray<DataType>
                {
                    static int MaxAttachments = 8;
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray<DataType> Empty;
                    /*0x0*/ DataType a0;
                    /*0x0*/ DataType a1;
                    /*0x0*/ DataType a2;
                    /*0x0*/ DataType a3;
                    /*0x0*/ DataType a4;
                    /*0x0*/ DataType a5;
                    /*0x0*/ DataType a6;
                    /*0x0*/ DataType a7;
                    /*0x0*/ int activeAttachments;

                    static /*0x383e7a0*/ FixedAttachmentArray();
                    /*0x3815ed0*/ FixedAttachmentArray(int numAttachments);
                    /*0x3816710*/ FixedAttachmentArray(DataType[] attachments);
                    /*0x3910ae8*/ FixedAttachmentArray(Unity.Collections.NativeArray<DataType> attachments);
                    /*0x3814574*/ int get_size();
                    /*0x38159dc*/ void Clear();
                    /*0x381467c*/ int Add(ref DataType data);
                    /*0x3814964*/ ref DataType get_Item(int index);
                }

                class NativePassCompiler : System.IDisposable
                {
                    static int k_EstimatedPassCount = 100;
                    static int k_MaxSubpass = 8;
                    static int ArbitraryMaxNbMergedPasses = 16;
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler.RenderGraphInputInfo graph;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData;
                    /*0x38*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData defaultContextData;
                    /*0x40*/ UnityEngine.Rendering.CommandBuffer previousCommandBuffer;
                    /*0x48*/ System.Collections.Generic.Stack<int> toVisitPassIds;
                    /*0x50*/ RenderGraphCompilationCache m_CompilationCache;
                    /*0x58*/ Unity.Collections.NativeList<UnityEngine.Rendering.AttachmentDescriptor> m_BeginRenderPassAttachments;
                    /*0x60*/ bool m_Disposed;
                    /*0x68*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> graphPassNamesForDebug;

                    static /*0x7bd65c0*/ bool IsGlobalTextureInPass(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                    static /*0x7bd6768*/ bool IsSameNativeSubPass(ref UnityEngine.Rendering.SubPassDescriptor a, ref UnityEngine.Rendering.SubPassDescriptor b);
                    static /*0x7bd8710*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo MakeAttachmentInfo(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int attachmentIndex);
                    static /*0x7bd8be4*/ string MakePassBreakInfoMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    static /*0x7bd8d04*/ string MakePassMergeMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData prevPass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit mergeResult);
                    static /*0x7bd9404*/ string InjectSpaces(string camelCaseString);
                    /*0x7bd3570*/ NativePassCompiler(RenderGraphCompilationCache cache);
                    /*0x7bd36f4*/ void Finalize();
                    /*0x7bd37e4*/ void Dispose();
                    /*0x7bd3788*/ void Cleanup();
                    /*0x7bd3844*/ bool Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> renderPasses, bool disableCulling, string debugName, bool useCompilationCaching, int graphHash, int frameIndex);
                    /*0x7bd3970*/ void Compile(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7bd390c*/ void Clear(bool clearContextData);
                    /*0x7bd5fa8*/ void SetPassStatesForNativePass(int nativePassId);
                    /*0x7bd39b0*/ void SetupContextData(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7bd3ab0*/ void BuildGraph();
                    /*0x7bd4988*/ void CullUnusedRenderPasses();
                    /*0x7bd4d78*/ void TryMergeNativePasses();
                    /*0x7bd50c4*/ void FindResourceUsageRanges();
                    /*0x7bd5ee8*/ void PrepareNativeRenderPasses();
                    /*0x7bd59fc*/ void DetectMemoryLessResources();
                    /*0x7bd6924*/ void ExecuteCreateRessource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x7bd5fb4*/ void DetermineLoadStoreActions(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x7bd6db0*/ void ValidateNativePass(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount);
                    /*0x7bd6f28*/ void ValidateAttachmentRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo attRenderTargetInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples);
                    /*0x7bd7040*/ void ExecuteBeginRenderPass(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x7bd7744*/ void ExecuteDestroyResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x7bd7b98*/ void SetRandomWriteTarget(ref UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int index, UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, bool preserveCounterValue);
                    /*0x7bd7da0*/ void ExecuteGraphNode(ref UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x7bd80d0*/ void ExecuteGraph(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes);
                    /*0x7bd957c*/ void GenerateNativeCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);

                    struct RenderGraphInputInfo
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_ResourcesForDebugOnly;
                        /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> m_RenderPasses;
                        /*0x20*/ string debugName;
                        /*0x28*/ bool disableCulling;
                    }

                    enum NativeCompilerProfileId
                    {
                        NRPRGComp_PrepareNativePass = 0,
                        NRPRGComp_SetupContextData = 1,
                        NRPRGComp_BuildGraph = 2,
                        NRPRGComp_CullNodes = 3,
                        NRPRGComp_TryMergeNativePasses = 4,
                        NRPRGComp_FindResourceUsageRanges = 5,
                        NRPRGComp_DetectMemorylessResources = 6,
                        NRPRGComp_ExecuteCreateResources = 7,
                        NRPRGComp_ExecuteBeginRenderpassCommand = 8,
                        NRPRGComp_ExecuteDestroyResources = 9,
                    }
                }

                struct PassInputData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                }

                struct PassOutputData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                }

                struct PassFragmentData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                    /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags;
                    /*0x20*/ int mipLevel;
                    /*0x24*/ int depthSlice;

                    static /*0x7bddba8*/ bool SameSubResource(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData x, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData y);
                    /*0x7bddaf0*/ int GetHashCode();
                }

                struct PassRandomWriteData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                    /*0x1c*/ int index;
                    /*0x20*/ bool preserveCounterValue;

                    /*0x7bddc40*/ int GetHashCode();
                }

                enum PassMergeState
                {
                    None = -1,
                    Begin = 0,
                    SubPass = 1,
                    End = 2,
                }

                struct PassData
                {
                    /*0x10*/ int passId;
                    /*0x14*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType type;
                    /*0x18*/ bool hasFoveatedRasterization;
                    /*0x1c*/ int tag;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassMergeState mergeState;
                    /*0x24*/ int nativePassIndex;
                    /*0x28*/ int nativeSubPassIndex;
                    /*0x2c*/ int firstInput;
                    /*0x30*/ int numInputs;
                    /*0x34*/ int firstOutput;
                    /*0x38*/ int numOutputs;
                    /*0x3c*/ int firstFragment;
                    /*0x40*/ int numFragments;
                    /*0x44*/ int firstFragmentInput;
                    /*0x48*/ int numFragmentInputs;
                    /*0x4c*/ int firstRandomAccessResource;
                    /*0x50*/ int numRandomAccessResources;
                    /*0x54*/ int firstCreate;
                    /*0x58*/ int numCreated;
                    /*0x5c*/ int firstDestroy;
                    /*0x60*/ int numDestroyed;
                    /*0x64*/ int fragmentInfoWidth;
                    /*0x68*/ int fragmentInfoHeight;
                    /*0x6c*/ int fragmentInfoVolumeDepth;
                    /*0x70*/ int fragmentInfoSamples;
                    /*0x74*/ int waitOnGraphicsFencePassId;
                    /*0x78*/ bool asyncCompute;
                    /*0x79*/ bool hasSideEffects;
                    /*0x7a*/ bool culled;
                    /*0x7b*/ bool beginNativeSubpass;
                    /*0x7c*/ bool fragmentInfoValid;
                    /*0x7d*/ bool fragmentInfoHasDepth;
                    /*0x7e*/ bool insertGraphicsFence;

                    /*0x7bddd30*/ PassData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x7bddcc8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bddda4*/ void ResetAndInitialize(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x7bdde18*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassOutputData> Outputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bddeb4*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassInputData> Inputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bddf50*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> Fragments(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bddfec*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> FragmentInputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde088*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> FirstUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde124*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData> RandomWriteTextures(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde1c0*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> LastUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde25c*/ void SetupAndValidateFragmentInfo(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde29c*/ void AddFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde2c0*/ void AddFragmentInput(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde2e4*/ void AddRandomAccessResource();
                    /*0x7bde2f4*/ void AddFirstUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde4c0*/ void AddLastUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bde68c*/ bool IsUsedAsFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                }

                struct NativePassAttachment
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;
                    /*0x1c*/ UnityEngine.Rendering.RenderBufferLoadAction loadAction;
                    /*0x20*/ UnityEngine.Rendering.RenderBufferStoreAction storeAction;
                    /*0x24*/ bool memoryless;
                    /*0x28*/ int mipLevel;
                    /*0x2c*/ int depthSlice;
                }

                enum LoadReason
                {
                    InvalidReason = 0,
                    LoadImported = 1,
                    LoadPreviouslyWritten = 2,
                    ClearImported = 3,
                    ClearCreated = 4,
                    FullyRewritten = 5,
                    Count = 6,
                }

                struct LoadAudit
                {
                    static /*0x0*/ string[] LoadReasonMessages;
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.LoadReason reason;
                    /*0x14*/ int passId;

                    static /*0x7bde890*/ LoadAudit();
                    /*0x7bde888*/ LoadAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.LoadReason setReason, int setPassId);
                }

                enum StoreReason
                {
                    InvalidReason = 0,
                    StoreImported = 1,
                    StoreUsedByLaterPass = 2,
                    DiscardImported = 3,
                    DiscardUnused = 4,
                    DiscardBindMs = 5,
                    NoMSAABuffer = 6,
                    Count = 7,
                }

                struct StoreAudit
                {
                    static /*0x0*/ string[] StoreReasonMessages;
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason reason;
                    /*0x14*/ int passId;
                    /*0x18*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason msaaReason;
                    /*0x1c*/ int msaaPassId;

                    static /*0x7bdea50*/ StoreAudit();
                    /*0x7bdea44*/ StoreAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setReason, int setPassId, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setMsaaReason, int setMsaaPassId);
                }

                enum PassBreakReason
                {
                    NotOptimized = 0,
                    TargetSizeMismatch = 1,
                    NextPassReadsTexture = 2,
                    NonRasterPass = 3,
                    DifferentDepthTextures = 4,
                    AttachmentLimitReached = 5,
                    SubPassLimitReached = 6,
                    EndOfGraph = 7,
                    FRStateMismatch = 8,
                    Merged = 9,
                    Count = 10,
                }

                struct PassBreakAudit
                {
                    static /*0x0*/ string[] BreakReasonMessages;
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakReason reason;
                    /*0x14*/ int breakPass;

                    static /*0x7bdec40*/ PassBreakAudit();
                    /*0x7bdec38*/ PassBreakAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakReason reason, int breakPass);
                }

                struct NativePassData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.LoadAudit> loadAudit;
                    /*0x54*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreAudit> storeAudit;
                    /*0xd8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit breakAudit;
                    /*0xe0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> fragments;
                    /*0x1a4*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment> attachments;
                    /*0x2a8*/ int firstGraphPass;
                    /*0x2ac*/ int lastGraphPass;
                    /*0x2b0*/ int numGraphPasses;
                    /*0x2b4*/ int firstNativeSubPass;
                    /*0x2b8*/ int numNativeSubPasses;
                    /*0x2bc*/ int width;
                    /*0x2c0*/ int height;
                    /*0x2c4*/ int volumeDepth;
                    /*0x2c8*/ int samples;
                    /*0x2cc*/ bool hasDepth;
                    /*0x2cd*/ bool hasFoveatedRasterization;

                    static /*0x7bdfd08*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit CanMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x7be05c8*/ bool CanMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x7bdf164*/ void TryMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x7be0b98*/ void UpdateNativeSubPassesAttachments(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    static /*0x7be0f34*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit TryMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x7be15cc*/ void SetPassStatesForNativePass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int nativePassId);
                    /*0x7bdef2c*/ NativePassData(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bdf820*/ void Clear();
                    /*0x7bdf970*/ bool IsValid();
                    /*0x7bdf980*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData> GraphPasses(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bdfc04*/ void GetGraphPassNames(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> dest);
                }

                struct ResourceReaderData
                {
                    /*0x10*/ int passId;
                    /*0x14*/ int inputSlot;
                }

                struct ResourceUnversionedData
                {
                    /*0x10*/ bool isImported;
                    /*0x11*/ bool isShared;
                    /*0x14*/ int tag;
                    /*0x18*/ int lastUsePassID;
                    /*0x1c*/ int lastWritePassID;
                    /*0x20*/ int firstUsePassID;
                    /*0x24*/ bool memoryLess;
                    /*0x28*/ int width;
                    /*0x2c*/ int height;
                    /*0x30*/ int volumeDepth;
                    /*0x34*/ int msaaSamples;
                    /*0x38*/ int latestVersionNumber;
                    /*0x3c*/ bool clear;
                    /*0x3d*/ bool discard;
                    /*0x3e*/ bool bindMS;

                    /*0x7be172c*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool isResourceShared);
                    /*0x7be1788*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.BufferDesc _, bool isResourceShared);
                    /*0x7be17d4*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc _, bool isResourceShared);
                    /*0x7be1708*/ string GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7be1820*/ void InitializeNullResource();
                }

                struct ResourceVersionedData
                {
                    /*0x10*/ bool written;
                    /*0x14*/ int writePassId;
                    /*0x18*/ int numReaders;

                    /*0x7be1834*/ void SetWritingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                    /*0x7be1844*/ void RegisterReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId, int index);
                    /*0x7be19c0*/ void RemoveReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                }

                class ResourcesData
                {
                    /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData> unversionedData;
                    /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData> versionedData;
                    /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> readerData;
                    /*0x28*/ int MaxVersions;
                    /*0x2c*/ int MaxReaders;
                    /*0x30*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> resourceNames;

                    /*0x7be1c94*/ ResourcesData();
                    /*0x7be1f7c*/ void Clear();
                    /*0x7be20b4*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7be2854*/ int Index(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7be28c0*/ int IndexReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int readerID);
                    /*0x7be04b0*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData get_Item(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7be2934*/ void Dispose();
                }
            }
        }

        namespace LookDev
        {
            interface IDataProvider
            {
                /*0x3816710*/ void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x3910ae8*/ void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<string> get_supportedDebugModes();
                /*0x3815ed0*/ void UpdateDebugMode(int debugIndex);
                /*0x3816810*/ void GetShadowMask(ref UnityEngine.RenderTexture output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x3816710*/ void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x3816710*/ void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x3816710*/ void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI);
            }

            struct Sky
            {
                /*0x10*/ UnityEngine.Cubemap cubemap;
                /*0x18*/ float longitudeOffset;
                /*0x1c*/ float exposure;
            }

            class StageRuntimeInterface
            {
                /*0x10*/ System.Func<bool, UnityEngine.GameObject> m_AddGameObject;
                /*0x18*/ System.Func<UnityEngine.Camera> m_GetCamera;
                /*0x20*/ System.Func<UnityEngine.Light> m_GetSunLight;
                /*0x28*/ object SRPData;

                /*0x7be2a2c*/ StageRuntimeInterface(System.Func<bool, UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight);
                /*0x7be2a8c*/ UnityEngine.GameObject AddGameObject(bool persistent);
                /*0x7be2ab0*/ UnityEngine.Camera get_camera();
                /*0x7be2ad0*/ UnityEngine.Light get_sunLight();
            }
        }

        namespace UI
        {
            class DebugUIHandlerBitField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle> toggles;
                /*0x78*/ UnityEngine.Rendering.DebugUI.BitField m_Field;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7be38a4*/ DebugUIHandlerBitField();
                /*0x7be2af0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be2f38*/ bool GetValue(int index);
                /*0x7be2fe0*/ void SetValue(int index, bool value);
                /*0x7be3330*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be35b0*/ void OnDeselection();
                /*0x7be35e0*/ void OnIncrement(bool fast);
                /*0x7be3600*/ void OnDecrement(bool fast);
                /*0x7be3620*/ void OnAction();
                /*0x7be3648*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerButton : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Button m_Field;

                /*0x7be3a14*/ DebugUIHandlerButton();
                /*0x7be38dc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be3978*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be39b0*/ void OnDeselection();
                /*0x7be39e0*/ void OnAction();
            }

            class DebugUIPrefabBundle
            {
                /*0x10*/ string type;
                /*0x18*/ UnityEngine.RectTransform prefab;

                /*0x7be3a30*/ DebugUIPrefabBundle();
            }

            class DebugUIHandlerCanvas : UnityEngine.MonoBehaviour
            {
                /*0x20*/ int m_DebugTreeState;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Transform> m_PrefabsMap;
                /*0x30*/ UnityEngine.Transform panelPrefab;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIPrefabBundle> prefabs;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerPanel> m_UIPanels;
                /*0x48*/ int m_SelectedPanel;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget m_SelectedWidget;
                /*0x58*/ string m_CurrentQueryPath;

                /*0x7be5cbc*/ DebugUIHandlerCanvas();
                /*0x7be3a38*/ void OnEnable();
                /*0x7be3bb0*/ void Update();
                /*0x7be4370*/ void RequestHierarchyReset();
                /*0x7be3cd8*/ void ResetAllHierarchy();
                /*0x7be437c*/ void Rebuild();
                /*0x7be4dd4*/ void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, ref UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedHandler);
                /*0x7be5490*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(string queryPath);
                /*0x7be528c*/ void ActivatePanel(int index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget);
                /*0x7be5640*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
                /*0x7be5990*/ void SelectPreviousItem();
                /*0x7be5a54*/ void SelectNextPanel();
                /*0x7be5ac8*/ void SelectPreviousPanel();
                /*0x7be58cc*/ void SelectNextItem();
                /*0x7be5b48*/ void ChangeSelectionValue(float multiplier);
                /*0x7be5c34*/ void ActivateSelection();
                /*0x7be3fe4*/ void HandleInput();
                /*0x7be57e0*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, bool> <>9__12_0;
                    static /*0x10*/ System.Action<UnityEngine.Rendering.UI.DebugUIHandlerPanel> <>9__15_0;

                    static /*0x7be5cc4*/ <>c();
                    /*0x7be5d2c*/ <>c();
                    /*0x7be5d34*/ bool <Rebuild>b__12_0(UnityEngine.Rendering.DebugUI.Widget x);
                    /*0x7be5d78*/ void <ActivatePanel>b__15_0(UnityEngine.Rendering.UI.DebugUIHandlerPanel p);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string queryPath;

                    /*0x7be55e4*/ <>c__DisplayClass14_0();
                    /*0x7be5da4*/ bool <GetWidgetFromPath>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget w);
                }
            }

            class DebugUIHandlerColor : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.UI.Image colorImage;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldR;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldG;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldB;
                /*0x90*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldA;
                /*0x98*/ UnityEngine.Rendering.DebugUI.ColorField m_Field;
                /*0xa0*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7be66f0*/ DebugUIHandlerColor();
                /*0x7be5dd0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be63ec*/ void SetValue(float x, bool r, bool g, bool b, bool a);
                /*0x7be6208*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7be64ac*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be6590*/ void OnDeselection();
                /*0x7be65c0*/ void OnIncrement(bool fast);
                /*0x7be65e0*/ void OnDecrement(bool fast);
                /*0x7be6600*/ void OnAction();
                /*0x7be6338*/ void UpdateColor();
                /*0x7be6628*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7be670c*/ float <SetWidget>b__9_0();
                /*0x7be675c*/ void <SetWidget>b__9_1(float x);
                /*0x7be6770*/ float <SetWidget>b__9_2();
                /*0x7be67c8*/ void <SetWidget>b__9_3(float x);
                /*0x7be67dc*/ float <SetWidget>b__9_4();
                /*0x7be6834*/ void <SetWidget>b__9_5(float x);
                /*0x7be6848*/ float <SetWidget>b__9_6();
                /*0x7be68a0*/ void <SetWidget>b__9_7(float x);
                /*0x7be68b4*/ float <SetupSettings>b__11_0();
                /*0x7be68d0*/ float <SetupSettings>b__11_1();
                /*0x7be68ec*/ float <SetupSettings>b__11_2();
            }

            class DebugUIHandlerContainer : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform contentHolder;

                /*0x7be6d40*/ DebugUIHandlerContainer();
                /*0x7be3814*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x7be3520*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem();
                /*0x7be3414*/ bool IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
                /*0x7be690c*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget widget;

                    /*0x7be6d38*/ <>c__DisplayClass3_0();
                    /*0x7be6d48*/ bool <IsDirectChild>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget x);
                }
            }

            class DebugUIHandlerEnumField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.EnumField>
            {
                /*0x7be7164*/ DebugUIHandlerEnumField();
                /*0x7be6db4*/ void OnIncrement(bool fast);
                /*0x7be6f28*/ void OnDecrement(bool fast);
                /*0x7be70cc*/ void UpdateValueLabel();
            }

            class DebugUIHandlerEnumHistory : UnityEngine.Rendering.UI.DebugUIHandlerEnumField
            {
                static float k_XOffset = 230;
                /*0x88*/ UnityEngine.UI.Text[] historyValues;

                /*0x7be7708*/ DebugUIHandlerEnumHistory();
                /*0x7be71ac*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be7458*/ void UpdateValueLabel();
                /*0x7be7674*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory <>4__this;

                    /*0x7be76e0*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x7be770c*/ void System.IDisposable.Dispose();
                    /*0x7be7710*/ bool MoveNext();
                    /*0x7be7800*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7be7808*/ void System.Collections.IEnumerator.Reset();
                    /*0x7be7840*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerField<T> : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x0*/ UnityEngine.UI.Text nextButtonText;
                /*0x0*/ UnityEngine.UI.Text previousButtonText;
                /*0x0*/ UnityEngine.UI.Text nameLabel;
                /*0x0*/ UnityEngine.UI.Text valueLabel;
                /*0x0*/ T m_Field;

                /*0x38159dc*/ DebugUIHandlerField();
                /*0x3816710*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x38159dc*/ void OnDeselection();
                /*0x38159dc*/ void OnAction();
                /*0x38159dc*/ void UpdateValueLabel();
                /*0x3816710*/ void SetLabelText(string text);
            }

            class DebugUIHandlerFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.FloatField m_Field;

                /*0x7be7b14*/ DebugUIHandlerFloatField();
                /*0x7be7848*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be79b8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be7a10*/ void OnDeselection();
                /*0x7be7a60*/ void OnIncrement(bool fast);
                /*0x7be7b08*/ void OnDecrement(bool fast);
                /*0x7be7a6c*/ void ChangeValue(bool fast, float multiplier);
                /*0x7be78f0*/ void UpdateValueLabel();
            }

            class DebugUIHandlerFoldout : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float k_FoldoutXOffset = 215;
                static float k_XOffset = 230;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Foldout m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7be8104*/ DebugUIHandlerFoldout();
                /*0x7be7b30*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be7ec8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be7fac*/ void OnDeselection();
                /*0x7be7fdc*/ void OnIncrement(bool fast);
                /*0x7be7ffc*/ void OnDecrement(bool fast);
                /*0x7be8018*/ void OnAction();
                /*0x7be7ea0*/ void UpdateValue();
                /*0x7be803c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerGroup : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Transform header;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Container m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7be83a0*/ DebugUIHandlerGroup();
                /*0x7be8120*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be8230*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be82e8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerHBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7be85a0*/ DebugUIHandlerHBox();
                /*0x7be83bc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be8430*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be84e8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerIndirectFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ System.Func<float> getter;
                /*0x78*/ System.Action<float> setter;
                /*0x80*/ System.Func<float> incStepGetter;
                /*0x88*/ System.Func<float> incStepMultGetter;
                /*0x90*/ System.Func<float> decimalsGetter;

                /*0x7be8844*/ DebugUIHandlerIndirectFloatField();
                /*0x7be64a8*/ void Init();
                /*0x7be86d0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be8728*/ void OnDeselection();
                /*0x7be8778*/ void OnIncrement(bool fast);
                /*0x7be8838*/ void OnDecrement(bool fast);
                /*0x7be8784*/ void ChangeValue(bool fast, float multiplier);
                /*0x7be85bc*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIndirectToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ System.Func<int, bool> getter;
                /*0x80*/ System.Action<int, bool> setter;
                /*0x88*/ int index;

                /*0x7be8994*/ DebugUIHandlerIndirectToggle();
                /*0x7be2e8c*/ void Init();
                /*0x7be8860*/ void OnToggleValueChanged(bool value);
                /*0x7be8890*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be88e8*/ void OnDeselection();
                /*0x7be8938*/ void OnAction();
                /*0x7be3288*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.IntField m_Field;

                /*0x7be8c9c*/ DebugUIHandlerIntField();
                /*0x7be89b0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be8b3c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be8b94*/ void OnDeselection();
                /*0x7be8be4*/ void OnIncrement(bool fast);
                /*0x7be8c90*/ void OnDecrement(bool fast);
                /*0x7be8bf0*/ void ChangeValue(bool fast, int multiplier);
                /*0x7be8a58*/ void UpdateValueLabel();
            }

            class DebugUIHandlerMessageBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color32 k_WarningBackgroundColor;
                static /*0x4*/ UnityEngine.Color32 k_WarningTextColor;
                static /*0x8*/ UnityEngine.Color32 k_ErrorBackgroundColor;
                static /*0xc*/ UnityEngine.Color32 k_ErrorTextColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.MessageBox m_Field;

                static /*0x7be8eb8*/ DebugUIHandlerMessageBox();
                /*0x7be8e9c*/ DebugUIHandlerMessageBox();
                /*0x7be8cb8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be8e54*/ void Update();
                /*0x7be8e94*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
            }

            class DebugUIHandlerObject : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;

                /*0x7be90c0*/ DebugUIHandlerObject();
                /*0x7be8f40*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be9018*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7be9070*/ void OnDeselection();
            }

            class DebugUIHandlerObjectList : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectListField>
            {
                /*0x88*/ int m_Index;

                /*0x7be92e4*/ DebugUIHandlerObjectList();
                /*0x7be90dc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be913c*/ void OnIncrement(bool fast);
                /*0x7be9158*/ void OnDecrement(bool fast);
                /*0x7be9174*/ void UpdateValueLabel();
            }

            class DebugUIHandlerObjectPopupField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectPopupField>
            {
                /*0x88*/ int m_Index;

                /*0x7be958c*/ DebugUIHandlerObjectPopupField();
                /*0x7be932c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7be938c*/ void ChangeSelectedObject();
                /*0x7be948c*/ void OnIncrement(bool fast);
                /*0x7be949c*/ void OnDecrement(bool fast);
                /*0x7be94ac*/ void UpdateValueLabel();
            }

            class DebugUIHandlerPanel : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Text nameLabel;
                /*0x28*/ UnityEngine.UI.ScrollRect scrollRect;
                /*0x30*/ UnityEngine.RectTransform viewport;
                /*0x38*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas Canvas;
                /*0x40*/ UnityEngine.RectTransform m_ScrollTransform;
                /*0x48*/ UnityEngine.RectTransform m_ContentTransform;
                /*0x50*/ UnityEngine.RectTransform m_MaskTransform;
                /*0x58*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget m_ScrollTarget;
                /*0x60*/ UnityEngine.Rendering.DebugUI.Panel m_Panel;

                /*0x7be9898*/ DebugUIHandlerPanel();
                /*0x7be95d4*/ void OnEnable();
                /*0x7be4d8c*/ void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x7be96a8*/ UnityEngine.Rendering.DebugUI.Panel GetPanel();
                /*0x7be96b0*/ void SelectNextItem();
                /*0x7be96c8*/ void SelectPreviousItem();
                /*0x7be96e0*/ void OnScrollbarClicked();
                /*0x7be9744*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target);
                /*0x7be41f8*/ void UpdateScroll();
                /*0x7be974c*/ float GetYPosInScroll(UnityEngine.RectTransform target);
                /*0x7be55ec*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x7be9838*/ void ResetDebugManager();
            }

            class DebugUIHandlerPersistentCanvas : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform panel;
                /*0x28*/ UnityEngine.RectTransform valuePrefab;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.ValueTuple> m_ValueTupleWidgets;

                /*0x7bea140*/ DebugUIHandlerPersistentCanvas();
                /*0x7be98a0*/ void Toggle(UnityEngine.Rendering.DebugUI.Value widget, string displayName);
                /*0x7be9b9c*/ void Toggle(UnityEngine.Rendering.DebugUI.ValueTuple widget, System.Nullable<int> forceTupleIndex);
                /*0x7be9f3c*/ bool IsEmpty();
                /*0x7be9f8c*/ void Clear();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Value widget;

                    /*0x7be9b94*/ <>c__DisplayClass3_0();
                    /*0x7bea21c*/ bool <Toggle>b__0(UnityEngine.Rendering.UI.DebugUIHandlerValue x);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.ValueTuple widget;

                    /*0x7be9f34*/ <>c__DisplayClass5_0();
                    /*0x7bea240*/ bool <Toggle>b__0(UnityEngine.Rendering.DebugUI.ValueTuple x);
                }
            }

            class DebugUIHandlerProgressBar : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.RectTransform progressBarRect;
                /*0x78*/ UnityEngine.Rendering.DebugUI.ProgressBarValue m_Value;
                /*0x80*/ float m_Timer;

                /*0x7bea4b8*/ DebugUIHandlerProgressBar();
                /*0x7bea250*/ void OnEnable();
                /*0x7bea258*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bea3ec*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bea424*/ void OnDeselection();
                /*0x7bea454*/ void Update();
                /*0x7bea300*/ void UpdateValue();
            }

            class DebugUIHandlerRow : UnityEngine.Rendering.UI.DebugUIHandlerFoldout
            {
                /*0x80*/ float m_Timer;

                /*0x7beabbc*/ DebugUIHandlerRow();
                /*0x7bea4d4*/ void OnEnable();
                /*0x7bea4dc*/ UnityEngine.GameObject GetChild(int index);
                /*0x7bea60c*/ bool TryGetChild(int index, ref UnityEngine.GameObject child);
                /*0x7bea698*/ bool IsActive(UnityEngine.Rendering.DebugUI.Table table, int index, UnityEngine.GameObject child);
                /*0x7bea7cc*/ void Update();
            }

            class DebugUIHandlerToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ UnityEngine.Rendering.DebugUI.BoolField m_Field;

                /*0x7beaf0c*/ DebugUIHandlerToggle();
                /*0x7beabd8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bead04*/ void OnToggleValueChanged(bool value);
                /*0x7bead2c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bead84*/ void OnDeselection();
                /*0x7beadd4*/ void OnAction();
                /*0x7beae5c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerToggleHistory : UnityEngine.Rendering.UI.DebugUIHandlerToggle
            {
                static float k_XOffset = 230;
                /*0x80*/ UnityEngine.UI.Toggle[] historyToggles;

                /*0x7beb4f4*/ DebugUIHandlerToggleHistory();
                /*0x7beaf28*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7beb2d0*/ void UpdateValueLabel();
                /*0x7beb460*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory <>4__this;

                    /*0x7beb4cc*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x7beb510*/ void System.IDisposable.Dispose();
                    /*0x7beb514*/ bool MoveNext();
                    /*0x7beb5d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7beb5d8*/ void System.Collections.IEnumerator.Reset();
                    /*0x7beb610*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerUIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.UIntField m_Field;

                /*0x7beb91c*/ DebugUIHandlerUIntField();
                /*0x7beb618*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7beb7a4*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7beb7fc*/ void OnDeselection();
                /*0x7beb84c*/ void OnIncrement(bool fast);
                /*0x7beb910*/ void OnDecrement(bool fast);
                /*0x7beb858*/ void ChangeValue(bool fast, int multiplier);
                /*0x7beb6c0*/ void UpdateValueLabel();
            }

            class DebugUIHandlerValue : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color k_ZeroColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Value m_Field;
                /*0x78*/ float m_Timer;

                static /*0x7bebc14*/ DebugUIHandlerValue();
                /*0x7bebbf8*/ DebugUIHandlerValue();
                /*0x7beb938*/ void OnEnable();
                /*0x7beb940*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7beb9dc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7beba34*/ void OnDeselection();
                /*0x7beba84*/ void Update();
            }

            class DebugUIHandlerValueTuple : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float k_XOffset = 230;
                static /*0x0*/ UnityEngine.Color k_ZeroColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.ValueTuple m_Field;
                /*0x78*/ UnityEngine.UI.Text[] valueElements;
                /*0x80*/ float m_Timer;

                static /*0x7bec34c*/ DebugUIHandlerValueTuple();
                /*0x7bec330*/ DebugUIHandlerValueTuple();
                /*0x7bebc64*/ void OnEnable();
                /*0x7bebc6c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bebca4*/ void OnDeselection();
                /*0x7bebcd4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bec070*/ void UpdateValueLabels();
                /*0x7bec2b4*/ void Update();
            }

            class DebugUIHandlerVBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bec580*/ DebugUIHandlerVBox();
                /*0x7bec39c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bec410*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bec4c8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerVector2 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.DebugUI.Vector2Field m_Field;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7becc08*/ DebugUIHandlerVector2();
                /*0x7bec59c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bec930*/ void SetValue(float v, bool x, bool y);
                /*0x7bec800*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bec9c4*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7becaa8*/ void OnDeselection();
                /*0x7becad8*/ void OnIncrement(bool fast);
                /*0x7becaf8*/ void OnDecrement(bool fast);
                /*0x7becb18*/ void OnAction();
                /*0x7becb40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7becc24*/ float <SetWidget>b__6_0();
                /*0x7becc74*/ void <SetWidget>b__6_1(float x);
                /*0x7becc80*/ float <SetWidget>b__6_2();
                /*0x7beccd8*/ void <SetWidget>b__6_3(float x);
                /*0x7becce4*/ float <SetupSettings>b__8_0();
                /*0x7becd00*/ float <SetupSettings>b__8_1();
                /*0x7becd1c*/ float <SetupSettings>b__8_2();
            }

            class DebugUIHandlerVector3 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;
                /*0x88*/ UnityEngine.Rendering.DebugUI.Vector3Field m_Field;
                /*0x90*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bed478*/ DebugUIHandlerVector3();
                /*0x7becd3c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bed194*/ void SetValue(float v, bool x, bool y, bool z);
                /*0x7bed064*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bed234*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bed318*/ void OnDeselection();
                /*0x7bed348*/ void OnIncrement(bool fast);
                /*0x7bed368*/ void OnDecrement(bool fast);
                /*0x7bed388*/ void OnAction();
                /*0x7bed3b0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bed494*/ float <SetWidget>b__7_0();
                /*0x7bed4e4*/ void <SetWidget>b__7_1(float v);
                /*0x7bed4f4*/ float <SetWidget>b__7_2();
                /*0x7bed54c*/ void <SetWidget>b__7_3(float v);
                /*0x7bed55c*/ float <SetWidget>b__7_4();
                /*0x7bed5b4*/ void <SetWidget>b__7_5(float v);
                /*0x7bed5c4*/ float <SetupSettings>b__9_0();
                /*0x7bed5e0*/ float <SetupSettings>b__9_1();
                /*0x7bed5fc*/ float <SetupSettings>b__9_2();
            }

            class DebugUIHandlerVector4 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldZ;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldW;
                /*0x90*/ UnityEngine.Rendering.DebugUI.Vector4Field m_Field;
                /*0x98*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bede30*/ DebugUIHandlerVector4();
                /*0x7bed61c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bedb38*/ void SetValue(float v, bool x, bool y, bool z, bool w);
                /*0x7beda08*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bedbec*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bedcd0*/ void OnDeselection();
                /*0x7bedd00*/ void OnIncrement(bool fast);
                /*0x7bedd20*/ void OnDecrement(bool fast);
                /*0x7bedd40*/ void OnAction();
                /*0x7bedd68*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bede4c*/ float <SetWidget>b__8_0();
                /*0x7bede9c*/ void <SetWidget>b__8_1(float x);
                /*0x7bedeb0*/ float <SetWidget>b__8_2();
                /*0x7bedf08*/ void <SetWidget>b__8_3(float x);
                /*0x7bedf1c*/ float <SetWidget>b__8_4();
                /*0x7bedf74*/ void <SetWidget>b__8_5(float x);
                /*0x7bedf88*/ float <SetWidget>b__8_6();
                /*0x7bedfe0*/ void <SetWidget>b__8_7(float x);
                /*0x7bedff4*/ float <SetupSettings>b__10_0();
                /*0x7bee010*/ float <SetupSettings>b__10_1();
                /*0x7bee02c*/ float <SetupSettings>b__10_2();
            }

            class DebugUIHandlerWidget : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Color colorDefault;
                /*0x30*/ UnityEngine.Color colorSelected;
                /*0x40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.DebugUI.Widget m_Widget;

                /*0x7be38c0*/ DebugUIHandlerWidget();
                /*0x7bee04c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler();
                /*0x7bee054*/ void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bee05c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler();
                /*0x7bee064*/ void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bee06c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler();
                /*0x7bee074*/ void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bee07c*/ void OnEnable();
                /*0x7bee080*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bee088*/ UnityEngine.Rendering.DebugUI.Widget GetWidget();
                /*0x3910ae8*/ T CastWidget<T>();
                /*0x7bee090*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bee098*/ void OnDeselection();
                /*0x7bee09c*/ void OnAction();
                /*0x7bee0a0*/ void OnIncrement(bool fast);
                /*0x7bee0a4*/ void OnDecrement(bool fast);
                /*0x7bee0a8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous();
                /*0x7be3710*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class UIFoldout : UnityEngine.UI.Toggle
            {
                /*0x128*/ UnityEngine.GameObject content;
                /*0x130*/ UnityEngine.GameObject arrowOpened;
                /*0x138*/ UnityEngine.GameObject arrowClosed;

                /*0x7bee41c*/ UIFoldout();
                /*0x7bee154*/ void Start();
                /*0x7bee220*/ void OnValidate();
                /*0x7bee214*/ void SetState(bool state);
                /*0x7bee22c*/ void SetState(bool state, bool rebuildLayout);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 23E369F2425336C1B0D0BDCA510A150AA6C65461DD681F84783FB6F9A9C44E26;
    static /*0x694a*/ <PrivateImplementationDetails> 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097;
    static /*0x6a4a*/ <PrivateImplementationDetails> 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A;
    static /*0x6c4a*/ <PrivateImplementationDetails> 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4;
    static /*0x704a*/ <PrivateImplementationDetails> BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158;
    static /*0x70da*/ <PrivateImplementationDetails> C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF;
    static /*0x80da*/ <PrivateImplementationDetails> CD9A54ED1F18BF97DB08914E280EA7349E11CA2C4885A4D8052552CEBA84208D;
    static /*0x80f2*/ <PrivateImplementationDetails> E4F1DAF1D677D145964FCFF943A857E8E5240534B804C03496DCAE3539792897;
    static /*0xf61a*/ <PrivateImplementationDetails> E806AA89271C778BAF8A2CC19587A816553FEE987D203B134B3B1435B1D158C7;
    static /*0xfa1a*/ <PrivateImplementationDetails> FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE;

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=144
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=512
    {
    }

    struct __StaticArrayInitTypeSize=1024
    {
    }

    struct __StaticArrayInitTypeSize=4096
    {
    }

    struct __StaticArrayInitTypeSize=26954
    {
    }

    struct __StaticArrayInitTypeSize=29992
    {
    }
}
