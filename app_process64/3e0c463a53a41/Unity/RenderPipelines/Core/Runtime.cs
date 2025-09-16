class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7b0efc8*/ EmbeddedAttribute();
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
                /*0x7b0efd0*/ IsUnmanagedAttribute();
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

    static /*0x7b0f50c*/ RenderGraphCompilationCache();
    static /*0x3907c14*/ int HashEntryComparer<T>(RenderGraphCompilationCache.HashEntry<T> a, RenderGraphCompilationCache.HashEntry<T> b);
    /*0x7b0efd8*/ RenderGraphCompilationCache();
    /*0x3907c14*/ bool GetCompilationCache<T>(int hash, int frameIndex, ref T outGraph, UnityEngine.Rendering.DynamicArray<RenderGraphCompilationCache.HashEntry<T>> hashEntries, System.Collections.Generic.Stack<T> pool, UnityEngine.Rendering.DynamicArray.SortComparer<RenderGraphCompilationCache.HashEntry<T>> comparer);
    /*0x7b0f224*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph outGraph);
    /*0x7b0f2dc*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData outGraph);
    /*0x7b0f394*/ void Clear();

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

        static /*0x38358cc*/ <>c__();
        /*0x380cb08*/ <>c__();
        /*0x3907c14*/ bool <GetCompilationCache>b__11_0(RenderGraphCompilationCache.HashEntry<T> value);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7b0f60c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7b0f700*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        static /*0x7b0f748*/ float NormalizeAngleDegree(float angle);
        /*0x7b10b88*/ LightAnchor();
        /*0x7b0f708*/ float get_yaw();
        /*0x7b0f710*/ void set_yaw(float value);
        /*0x7b0f77c*/ float get_pitch();
        /*0x7b0f784*/ void set_pitch(float value);
        /*0x7b0f7bc*/ float get_roll();
        /*0x7b0f7c4*/ void set_roll(float value);
        /*0x7b0f7fc*/ float get_distance();
        /*0x7b0f804*/ void set_distance(float value);
        /*0x7b0f824*/ UnityEngine.LightAnchor.UpDirection get_frameSpace();
        /*0x7b0f82c*/ void set_frameSpace(UnityEngine.LightAnchor.UpDirection value);
        /*0x7b0f834*/ UnityEngine.Vector3 get_anchorPosition();
        /*0x7b0f940*/ UnityEngine.Transform get_anchorPositionOverride();
        /*0x7b0f948*/ void set_anchorPositionOverride(UnityEngine.Transform value);
        /*0x7b0f950*/ UnityEngine.Vector3 get_anchorPositionOffset();
        /*0x7b0f95c*/ void set_anchorPositionOffset(UnityEngine.Vector3 value);
        /*0x7b0f968*/ void SynchronizeOnTransform(UnityEngine.Camera camera);
        /*0x7b10674*/ void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x7b0fe40*/ UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x7b109b8*/ void Update();
        /*0x7b10ab8*/ void OnDrawGizmosSelected();
        /*0x7b106dc*/ void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor);

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

                static /*0x7b11a7c*/ XRBuiltinShaderConstants();
                static /*0x7b10b90*/ void UpdateBuiltinShaderConstants(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex);
                static /*0x7b1106c*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x7b111bc*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.RasterCommandBuffer cmd);
                static /*0x7b1121c*/ void Update(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
            }

            class XRLayout
            {
                /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> m_ActivePasses;

                /*0x7b13048*/ XRLayout();
                /*0x7b11dcc*/ void AddCamera(UnityEngine.Camera camera, bool enableXR);
                /*0x7b12690*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                /*0x7b129bc*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> GetActivePasses();
                /*0x7b12590*/ void AddPass(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7b129c4*/ void Clear();
                /*0x7b12af0*/ void LogDebugInfo();
            }

            class XRLayoutStack : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.XRLayout> m_Stack;

                /*0x7b1335c*/ XRLayoutStack();
                /*0x7b130d0*/ UnityEngine.Experimental.Rendering.XRLayout New();
                /*0x7b1317c*/ UnityEngine.Experimental.Rendering.XRLayout get_top();
                /*0x7b131cc*/ void Release();
                /*0x7b132c8*/ void Dispose();
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

                static /*0x7b14258*/ XRMirrorView();
                static /*0x7b133e4*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Material mat, UnityEngine.XR.XRDisplaySubsystem display);
            }

            class XROcclusionMesh
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler k_OcclusionMeshProfilingSampler;
                /*0x10*/ UnityEngine.Experimental.Rendering.XRPass m_Pass;
                /*0x18*/ UnityEngine.Mesh m_CombinedMesh;
                /*0x20*/ UnityEngine.Material m_Material;
                /*0x28*/ int m_CombinedMeshHashCode;

                static /*0x7b152ac*/ XROcclusionMesh();
                /*0x7b14504*/ XROcclusionMesh(UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7b14534*/ void SetMaterial(UnityEngine.Material mat);
                /*0x7b1453c*/ bool get_hasValidOcclusionMesh();
                /*0x7b146fc*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, float occlusionMeshScale, bool yFlip);
                /*0x7b14d90*/ void UpdateCombinedMesh();
                /*0x7b14600*/ bool IsOcclusionMeshSupported();
                /*0x7b14e64*/ bool TryGetOcclusionMeshCombinedHashCode(ref int hashCode);
                /*0x7b14f58*/ void CreateOcclusionMeshCombined();
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

                static /*0x7b1541c*/ UnityEngine.Experimental.Rendering.XRPass CreateDefault(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7b15348*/ XRPass();
                /*0x7b15750*/ void Release();
                /*0x7b1191c*/ bool get_enabled();
                /*0x7b157bc*/ bool get_supportsFoveatedRendering();
                /*0x7b15870*/ bool get_copyDepth();
                /*0x7b15878*/ void set_copyDepth(bool value);
                /*0x7b15884*/ bool get_hasMotionVectorPass();
                /*0x7b1588c*/ void set_hasMotionVectorPass(bool value);
                /*0x7b15898*/ bool get_isFirstCameraPass();
                /*0x7b158a8*/ bool get_isLastCameraPass();
                /*0x7b15914*/ int get_multipassId();
                /*0x7b1591c*/ void set_multipassId(int value);
                /*0x7b15924*/ int get_cullingPassId();
                /*0x7b1592c*/ void set_cullingPassId(int value);
                /*0x7b15934*/ UnityEngine.Rendering.RenderTargetIdentifier get_renderTarget();
                /*0x7b15948*/ void set_renderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b1595c*/ UnityEngine.RenderTextureDescriptor get_renderTargetDesc();
                /*0x7b1597c*/ void set_renderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x7b1599c*/ UnityEngine.Rendering.RenderTargetIdentifier get_motionVectorRenderTarget();
                /*0x7b159b0*/ void set_motionVectorRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x7b159c4*/ UnityEngine.RenderTextureDescriptor get_motionVectorRenderTargetDesc();
                /*0x7b159e4*/ void set_motionVectorRenderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x7b15a04*/ UnityEngine.Rendering.ScriptableCullingParameters get_cullingParams();
                /*0x7b15a14*/ void set_cullingParams(UnityEngine.Rendering.ScriptableCullingParameters value);
                /*0x7b13000*/ int get_viewCount();
                /*0x7b11a64*/ bool get_singlePassEnabled();
                /*0x7b15a2c*/ nint get_foveatedRenderingInfo();
                /*0x7b15a34*/ void set_foveatedRenderingInfo(nint value);
                /*0x7b15a3c*/ bool get_isHDRDisplayOutputActive();
                /*0x7b15ae8*/ UnityEngine.ColorGamut get_hdrDisplayOutputColorGamut();
                /*0x7b15b94*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation();
                /*0x7b15db8*/ float get_occlusionMeshScale();
                /*0x7b15dc0*/ void set_occlusionMeshScale(float value);
                /*0x7b119cc*/ UnityEngine.Matrix4x4 GetProjMatrix(int viewIndex);
                /*0x7b11934*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x7b15dc8*/ bool GetPrevViewValid(int viewIndex);
                /*0x7b15e40*/ UnityEngine.Matrix4x4 GetPrevViewMatrix(int viewIndex);
                /*0x7b12f14*/ UnityEngine.Rect GetViewport(int viewIndex);
                /*0x7b14688*/ UnityEngine.Mesh GetOcclusionMesh(int viewIndex);
                /*0x7b12f8c*/ int GetTextureArraySlice(int viewIndex);
                /*0x7b14ba8*/ void StartSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b15ed8*/ void StartSinglePass(UnityEngine.Rendering.IRasterCommandBuffer cmd);
                /*0x7b14aec*/ void StopSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x7b15f58*/ void StopSinglePass(UnityEngine.Rendering.BaseCommandBuffer cmd);
                /*0x7b15f70*/ bool get_hasValidOcclusionMesh();
                /*0x7b15f88*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
                /*0x7b15fb8*/ void RenderOcclusionMesh(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x7b15ff0*/ void RenderDebugXRViewsFrustum();
                /*0x7b16260*/ UnityEngine.Vector4 ApplyXRViewCenterOffset(UnityEngine.Vector2 center);
                /*0x7b163a4*/ void AssignView(int viewId, UnityEngine.Experimental.Rendering.XRView xrView);
                /*0x7b164a4*/ void AssignCullingParams(int cullingPassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                /*0x7b129a4*/ void UpdateCombinedOcclusionMesh();
                /*0x7b154fc*/ void InitBase(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x7b16534*/ void AddView(UnityEngine.Experimental.Rendering.XRView xrView);
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

                static /*0x7b18430*/ XRSystem();
                static /*0x7b1674c*/ UnityEngine.XR.XRDisplaySubsystem GetActiveDisplay();
                static /*0x7b11f7c*/ bool get_displayActive();
                static /*0x7b167a4*/ bool get_isHDRDisplayOutputActive();
                static /*0x7b16854*/ bool get_singlePassAllowed();
                static /*0x7b168ac*/ void set_singlePassAllowed(bool value);
                static /*0x7b1690c*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
                static /*0x7b16964*/ void set_foveatedRenderingCaps(UnityEngine.Rendering.FoveatedRenderingCaps value);
                static /*0x7b169c0*/ bool get_dumpDebugInfo();
                static /*0x7b16a18*/ void set_dumpDebugInfo(bool value);
                static /*0x7b16a78*/ void Initialize(System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> passAllocator, UnityEngine.Shader occlusionMeshPS, UnityEngine.Shader mirrorViewPS);
                static /*0x7b17188*/ void SetDisplayMSAASamples(UnityEngine.Rendering.MSAASamples msaaSamples);
                static /*0x7b17398*/ UnityEngine.Rendering.MSAASamples GetDisplayMSAASamples();
                static /*0x7b173f0*/ void SetOcclusionMeshScale(float occlusionMeshScale);
                static /*0x7b17454*/ float GetOcclusionMeshScale();
                static /*0x7b174ac*/ void SetMirrorViewMode(int mirrorBlitMode);
                static /*0x7b17544*/ int GetMirrorViewMode();
                static /*0x7b175d8*/ void SetRenderScale(float renderScale);
                static /*0x7b177b0*/ float GetRenderViewportScale();
                static /*0x7b17814*/ UnityEngine.Experimental.Rendering.XRLayout NewLayout();
                static /*0x7b17878*/ void EndLayout();
                static /*0x7b17950*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                static /*0x7b179f0*/ void Dispose();
                static /*0x7b12010*/ void SetDisplayZRange(float zNear, float zFar);
                static /*0x7b17b90*/ void SetLayoutOverride(System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> action);
                static /*0x7b17bf0*/ void XRSystemInit();
                static /*0x7b16ea0*/ void RefreshDeviceInfo();
                static /*0x7b120d4*/ void CreateDefaultLayout(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRLayout layout);
                static /*0x7b1271c*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                static /*0x7b17cb4*/ bool CanUseSinglePass(UnityEngine.Camera camera, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
                static /*0x7b1817c*/ UnityEngine.Experimental.Rendering.XRView BuildView(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                static /*0x7b18374*/ UnityEngine.RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(UnityEngine.RenderTextureDescriptor xrDesc);
                static /*0x7b17df4*/ UnityEngine.Experimental.Rendering.XRPassCreateInfo BuildPass(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrRenderPass, UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, UnityEngine.Experimental.Rendering.XRLayout layout);
                static /*0x7b1805c*/ void <CreateDefaultLayout>g__AddViewToPass|44_0(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, int renderParamIndex, ref UnityEngine.Experimental.Rendering.XRSystem.<> );

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

                static /*0x7b1858c*/ UnityEngine.Vector2 ComputeEyeCenterUV(UnityEngine.Matrix4x4 proj);
                /*0x7b182d4*/ XRView(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, UnityEngine.Rect viewport, UnityEngine.Mesh occlusionMesh, int textureArraySlice);
            }
        }
    }

    namespace Rendering
    {
        interface IPerFrameHistoryAccessTracker
        {
            /*0x380cb08*/ void RequestAccess<Type>();
        }

        interface ICameraHistoryWriteAccess
        {
            /*0x380b128*/ bool IsAccessRequested<Type>();
            /*0x3907c14*/ Type GetHistoryForWrite<Type>();
            /*0x380b128*/ bool IsWritten<Type>();
        }

        interface ICameraHistoryReadAccess
        {
            /*0x3907c14*/ Type GetHistoryForRead<Type>();
            /*0x380d83c*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
            /*0x380d83c*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);

            class HistoryRequestDelegate : System.MulticastDelegate
            {
                /*0x7b1862c*/ HistoryRequestDelegate(object object, nint method);
                /*0x7b18734*/ void Invoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess);
                /*0x7b18748*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess, System.AsyncCallback callback, object object);
                /*0x7b18768*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class CameraHistoryItem : UnityEngine.Rendering.ContextItem
        {
            /*0x10*/ UnityEngine.Rendering.BufferedRTHandleSystem m_owner;
            /*0x18*/ uint m_TypeId;

            /*0x7b18860*/ CameraHistoryItem();
            /*0x7b18774*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
            /*0x7b187a0*/ UnityEngine.Rendering.BufferedRTHandleSystem get_storage();
            /*0x7b187a8*/ int MakeId(uint index);
            /*0x7b187b8*/ UnityEngine.Rendering.RTHandle AllocHistoryFrameRT(int id, int count, ref UnityEngine.RenderTextureDescriptor desc, string name);
            /*0x7b18824*/ void ReleaseHistoryFrameRT(int id);
            /*0x7b18840*/ UnityEngine.Rendering.RTHandle GetPreviousFrameRT(int id);
            /*0x7b18804*/ UnityEngine.Rendering.RTHandle GetCurrentFrameRT(int id);
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

            /*0x7b19170*/ CameraSwitcher();
            /*0x7b18878*/ void OnEnable();
            /*0x7b18e6c*/ void OnDisable();
            /*0x7b18e4c*/ int GetCameraCount();
            /*0x7b18efc*/ UnityEngine.Camera GetNextCamera();
            /*0x7b18f44*/ void SetCameraIndex(int index);
            /*0x7b19180*/ int <OnEnable>b__10_0();
            /*0x7b19188*/ void <OnEnable>b__10_1(int value);
            /*0x7b1918c*/ int <OnEnable>b__10_2();
            /*0x7b19194*/ void <OnEnable>b__10_3(int value);
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

            /*0x7b19fac*/ FreeCamera();
            /*0x7b1919c*/ void OnEnable();
            /*0x7b191a0*/ void RegisterInputs();
            /*0x7b19964*/ void UpdateInputs();
            /*0x7b19be4*/ void Update();
        }

        class BaseCommandBuffer
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_WrappedCommandBuffer;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_ExecutingPass;

            /*0x7b19fc8*/ BaseCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b1a048*/ string get_name();
            /*0x7b1a064*/ int get_sizeInBytes();
            /*0x7b1a080*/ void ThrowIfGlobalStateNotAllowed();
            /*0x7b1a108*/ void ThrowIfRasterNotAllowed();
            /*0x7b1a19c*/ void ValidateTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x7b1a36c*/ void ValidateTextureHandleRead(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x7b1a4dc*/ void ValidateTextureHandleWrite(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
        }

        struct CommandBufferHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rasterCmd;
            static /*0x8*/ UnityEngine.Rendering.ComputeCommandBuffer computeCmd;
            static /*0x10*/ UnityEngine.Rendering.UnsafeCommandBuffer unsafeCmd;

            static /*0x7b1a8e0*/ CommandBufferHelpers();
            static /*0x7b1a6b8*/ UnityEngine.Rendering.RasterCommandBuffer GetRasterCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b1a734*/ UnityEngine.Rendering.ComputeCommandBuffer GetComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b1a7b0*/ UnityEngine.Rendering.UnsafeCommandBuffer GetUnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x7b1a82c*/ UnityEngine.Rendering.CommandBuffer GetNativeCommandBuffer(UnityEngine.Rendering.UnsafeCommandBuffer baseBuffer);
            static /*0x7b1a844*/ void VFXManager_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
        }

        class ComputeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x7b1a9fc*/ ComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b1aa0c*/ void SetInvertCulling(bool invertCulling);
            /*0x7b1aa2c*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7b1aa48*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7b1aa64*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b1aa80*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b1aa9c*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b1aae8*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1ab04*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b1ab20*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b1ab3c*/ void DisableScissorRect();
            /*0x7b1ab58*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b1ab74*/ void SetGlobalInt(int nameID, int value);
            /*0x7b1ab90*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b1abac*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b1abc8*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b1abe4*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b1ac30*/ void EnableShaderKeyword(string keyword);
            /*0x7b1ac4c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1ac68*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1ac84*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1aca0*/ void DisableShaderKeyword(string keyword);
            /*0x7b1acbc*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1acd8*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1acf4*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1ad10*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b1ad30*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1ad50*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1ad70*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b1ade0*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b1adfc*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b1ae18*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b1ae34*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1ae50*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b1ae6c*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b1ae88*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b1aea4*/ void BeginSample(string name);
            /*0x7b1aec0*/ void EndSample(string name);
            /*0x7b1aedc*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1aef8*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1af14*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1af18*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1af1c*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b1af68*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b1af84*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b1afa0*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7b1afbc*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b1afd8*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b1aff4*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7b1b010*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b1b02c*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b1b048*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7b1b064*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7b1b080*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7b1b09c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7b1b0b8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b1b104*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b1b120*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7b1b13c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7b1b158*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7b1b174*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7b1b190*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1b274*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1b358*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b1b444*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b1b530*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1b62c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1b728*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b1b744*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b1b760*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1b780*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1b7a0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1b7bc*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1b7d8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1b7f4*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1b810*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1b82c*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1b848*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7b1b864*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7b1b880*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7b1b89c*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7b1b8b8*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7b1b8d4*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1b8f0*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1b90c*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1b928*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1b944*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b1b960*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b1b97c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1b998*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1b9b4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1b9d4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1b9f4*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1ba10*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1ba2c*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1ba48*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1ba64*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1bb38*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1bc0c*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7b1bc28*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7b1bc44*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7b1bc60*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7b1bc7c*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7b1bc98*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7b1bcb4*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7b1bcd0*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7b1bcec*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7b1bd08*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b1bd24*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7b1bd40*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b1bd5c*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b1bda8*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b1bdf4*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b1be10*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1be2c*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7b1be48*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b1be64*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b1be80*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b1be9c*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b1beb8*/ void SetGlobalFloat(string name, float value);
            /*0x7b1bed4*/ void SetGlobalInt(string name, int value);
            /*0x7b1bef0*/ void SetGlobalInteger(string name, int value);
            /*0x7b1bf0c*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b1bf28*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b1bf44*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b1bf90*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b1bfac*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b1bfc8*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b1bfe4*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b1c000*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b1c01c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b1c038*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b1c054*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b1c070*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b1c08c*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b1c158*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b1c224*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1c2f8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1c3cc*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b1c3e8*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b1c404*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b1c420*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b1c43c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b1c458*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b1c474*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b1c490*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b1c4ac*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b1c4f8*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b1c514*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b1c530*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b1c54c*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b1c5bc*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b1c5d8*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1c5f4*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c610*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c62c*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1c648*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c664*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c680*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b1c6a0*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1c6c0*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        interface IBaseCommandBuffer
        {
            /*0x380cdf0*/ void SetInvertCulling(bool invertCulling);
            void SetViewport(UnityEngine.Rect pixelRect);
            void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x380cb08*/ void DisableScissorRect();
            /*0x380d250*/ void SetGlobalFloat(int nameID, float value);
            /*0x380d0e4*/ void SetGlobalInt(int nameID, int value);
            /*0x380d0e4*/ void SetGlobalInteger(int nameID, int value);
            /*0x380d3e8*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3907c14*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3907c14*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x380d83c*/ void EnableShaderKeyword(string keyword);
            /*0x380d83c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x380d93c*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x380d93c*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x380d83c*/ void DisableShaderKeyword(string keyword);
            /*0x380d83c*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x380d93c*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x380d93c*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3907c14*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x380d170*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x380d170*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x380d170*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x380d83c*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x380d0e4*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x380cffc*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x380d83c*/ void BeginSample(string name);
            /*0x380d83c*/ void EndSample(string name);
            /*0x380d83c*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x380d83c*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3907c14*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3907c14*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x380d83c*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x380cb08*/ void InvokeOnRenderObjectCallbacks();
            void SetGlobalFloat(string name, float value);
            /*0x380d8b8*/ void SetGlobalInt(string name, int value);
            /*0x380d8b8*/ void SetGlobalInteger(string name, int value);
            void SetGlobalVector(string name, UnityEngine.Vector4 value);
            void SetGlobalColor(string name, UnityEngine.Color value);
            void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x380d93c*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x380d170*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x380d93c*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x380d93c*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x380d170*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x380d93c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x380d93c*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x380d170*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x380d93c*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3907c14*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3907c14*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3907c14*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3907c14*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x380d93c*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x380d170*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x380d93c*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x380d170*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3907c14*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x380cffc*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3907c14*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3907c14*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3907c14*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3907c14*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
        }

        interface IComputeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3907c14*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x380d93c*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x380d93c*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x380da4c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x3907c14*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x380da4c*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x380da4c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x380da4c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3907c14*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3907c14*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3907c14*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3907c14*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3907c14*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3907c14*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3907c14*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3907c14*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x380d83c*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x380da4c*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x380da4c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x380da4c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3907c14*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3907c14*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3907c14*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3907c14*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3907c14*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3907c14*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x380da4c*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x380da4c*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x380da4c*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3907c14*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3907c14*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x380da4c*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3907c14*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
        }

        interface IRasterCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x3907c14*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x3907c14*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x3907c14*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3907c14*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3907c14*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x380e284*/ void SetInstanceMultiplier(uint multiplier);
            /*0x380cffc*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x380cdf0*/ void SetWireframe(bool enable);
            void ConfigureFoveatedRendering(nint platformData);
            /*0x3907c14*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3907c14*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x3907c14*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x3907c14*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x380d93c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x3907c14*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3907c14*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x3907c14*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x3907c14*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3907c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
        }

        interface IUnsafeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x380cb08*/ void Clear();
            void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3907c14*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
        }

        class RasterCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x7b1a9f4*/ RasterCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x7b1c6e0*/ void SetInvertCulling(bool invertCulling);
            /*0x7b1c700*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b1c71c*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b1c738*/ void DisableScissorRect();
            /*0x7b1c754*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7b1c778*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7b1c79c*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b1c7c0*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b1c7dc*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7b1c7f8*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b1c814*/ void SetGlobalInt(int nameID, int value);
            /*0x7b1c830*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b1c84c*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b1c868*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b1c884*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b1c8d0*/ void EnableShaderKeyword(string keyword);
            /*0x7b1c8ec*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1c908*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c924*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c940*/ void DisableShaderKeyword(string keyword);
            /*0x7b1c95c*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1c978*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c994*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1c9b0*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b1c9d0*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1c9f0*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1ca10*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b1ca80*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b1ca9c*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b1cab8*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b1cad4*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1caf0*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b1cb0c*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b1cb28*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b1cb44*/ void BeginSample(string name);
            /*0x7b1cb60*/ void EndSample(string name);
            /*0x7b1cb7c*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1cb98*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1cbb4*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1cbb8*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1cbbc*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b1cc08*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7b1cc24*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7b1cc40*/ void SetWireframe(bool enable);
            /*0x7b1cc60*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7b1cc7c*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b1cc98*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b1ccb4*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1cd00*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b1cd4c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7b1cd98*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7b1cde4*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1ce00*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b1ce1c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7b1ce38*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7b1ce54*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7b1cea0*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1ceec*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7b1cf38*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7b1cf84*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1cfd4*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7b1d020*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7b1d06c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d0b8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d104*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b1d150*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d1a0*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d1ec*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b1d238*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d284*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d2d0*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b1d31c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d36c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d3b8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b1d404*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d420*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7b1d43c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7b1d458*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d474*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d490*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d4ac*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b1d4c8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1d4e4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b1d500*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b1d51c*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7b1d538*/ void SetGlobalFloat(string name, float value);
            /*0x7b1d554*/ void SetGlobalInt(string name, int value);
            /*0x7b1d570*/ void SetGlobalInteger(string name, int value);
            /*0x7b1d58c*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b1d5a8*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b1d5c4*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b1d610*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b1d62c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b1d648*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b1d664*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b1d680*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b1d69c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b1d6b8*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b1d6d4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b1d6f0*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b1d70c*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b1d7d8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b1d8a4*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1d978*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1da4c*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b1da68*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b1da84*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b1daa0*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b1dabc*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b1dad8*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b1daf4*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b1db10*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b1db2c*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b1db78*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b1db94*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b1dbb0*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b1dbcc*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b1dc3c*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b1dc58*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1dc74*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1dc90*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1dcac*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1dcc8*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1dce4*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1dd00*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b1dd20*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1dd40*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class UnsafeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IUnsafeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x7b1aa04*/ UnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7b1dd60*/ void SetInvertCulling(bool invertCulling);
            /*0x7b1dd80*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7b1dd9c*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7b1ddb8*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b1ddd4*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b1ddf0*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b1de3c*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1de58*/ void Clear();
            /*0x7b1de74*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7b1de90*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7b1deac*/ void DisableScissorRect();
            /*0x7b1dec8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7b1deec*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7b1df10*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b1df34*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7b1df50*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7b1df6c*/ void SetGlobalFloat(int nameID, float value);
            /*0x7b1df88*/ void SetGlobalInt(int nameID, int value);
            /*0x7b1dfa4*/ void SetGlobalInteger(int nameID, int value);
            /*0x7b1dfc0*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7b1dfdc*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7b1dff8*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7b1e044*/ void EnableShaderKeyword(string keyword);
            /*0x7b1e060*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1e07c*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1e098*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1e0b4*/ void DisableShaderKeyword(string keyword);
            /*0x7b1e0d0*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b1e0ec*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1e108*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b1e124*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b1e144*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1e164*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b1e184*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7b1e1f4*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7b1e210*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7b1e22c*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7b1e248*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1e264*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7b1e280*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7b1e29c*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7b1e2b8*/ void BeginSample(string name);
            /*0x7b1e2d4*/ void EndSample(string name);
            /*0x7b1e2f0*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1e30c*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b1e328*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1e32c*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x7b1e330*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7b1e37c*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7b1e398*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7b1e3b4*/ void SetWireframe(bool enable);
            /*0x7b1e3d4*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7b1e3f0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7b1e43c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x7b1e488*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7b1e4d4*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7b1e520*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7b1e56c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b1e5b8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7b1e628*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x7b1e698*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7b1e708*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b1e778*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7b1e7e8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7b1e834*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b1e880*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7b1e8f4*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x7b1e940*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b1e95c*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b1e978*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7b1e994*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7b1e9b0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7b1e9cc*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7b1e9e8*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7b1ea04*/ void InvokeOnRenderObjectCallbacks();
            /*0x7b1ea20*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7b1ea3c*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7b1ea58*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7b1ea74*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7b1ea90*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b1eadc*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b1eaf8*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7b1eb14*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7b1eb30*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7b1eb4c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7b1eb68*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1ec4c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1ed30*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b1ee1c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x7b1ef08*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1f004*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b1f100*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b1f11c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b1f138*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1f158*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1f178*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1f194*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1f1b0*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1f1cc*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1f1e8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1f204*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1f220*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7b1f23c*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7b1f258*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7b1f274*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7b1f290*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7b1f2ac*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1f2c8*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1f2e4*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1f300*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7b1f31c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7b1f338*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7b1f354*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1f370*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7b1f38c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1f3ac*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7b1f3cc*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1f3e8*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7b1f404*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1f420*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7b1f43c*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1f510*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x7b1f5e4*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7b1f600*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7b1f61c*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7b1f638*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7b1f654*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7b1f670*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7b1f68c*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7b1f6a8*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7b1f6c4*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7b1f6e0*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7b1f6fc*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7b1f718*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7b1f734*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7b1f780*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7b1f7cc*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7b1f7e8*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7b1f804*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7b1f820*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1f86c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b1f8b8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7b1f904*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7b1f950*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1f96c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7b1f988*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7b1f9a4*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7b1f9c0*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7b1fa0c*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fa58*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7b1faa4*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7b1faf0*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fb40*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7b1fb8c*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7b1fbd8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fc24*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b1fc70*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b1fcbc*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fd0c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b1fd58*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b1fda4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fdf0*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b1fe3c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b1fe88*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fed8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b1ff24*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b1ff70*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1ff8c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7b1ffa8*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7b1ffc4*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1ffe0*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b1fffc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7b20018*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7b20034*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7b20050*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7b2006c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7b20088*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7b200a4*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b200c0*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7b200dc*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b200f8*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7b20114*/ void SetGlobalFloat(string name, float value);
            /*0x7b20130*/ void SetGlobalInt(string name, int value);
            /*0x7b2014c*/ void SetGlobalInteger(string name, int value);
            /*0x7b20168*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7b20184*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7b201a0*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7b201ec*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7b20208*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7b20224*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7b20240*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b2025c*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7b20278*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7b20294*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b202b0*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7b202cc*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7b202e8*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b203b4*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x7b20480*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b20554*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7b20628*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7b20644*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7b20660*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7b2067c*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7b20698*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7b206b4*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7b206d0*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7b206ec*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7b20708*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7b20754*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7b20770*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7b2078c*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7b207a8*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7b20818*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x7b20834*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b20850*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b2086c*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b20888*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7b208a4*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b208c0*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7b208dc*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7b208fc*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7b2091c*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class CommandBufferPool
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;

            static /*0x7b20afc*/ CommandBufferPool();
            static /*0x7b2093c*/ UnityEngine.Rendering.CommandBuffer Get();
            static /*0x7b209e4*/ UnityEngine.Rendering.CommandBuffer Get(string name);
            static /*0x7b20a7c*/ void Release(UnityEngine.Rendering.CommandBuffer buffer);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CommandBufferPool.<> <>9;

                static /*0x7b20c1c*/ <>c();
                /*0x7b20c84*/ <>c();
                /*0x7b20c8c*/ void <.cctor>b__4_0(UnityEngine.Rendering.CommandBuffer x);
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

            static /*0x3907c14*/ TType get_instance();
            static /*0x38358cc*/ void Release();
        }

        class ConstantBuffer
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;

            static /*0x7b20f48*/ ConstantBuffer();
            static /*0x383b458*/ void PushGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            static /*0x3839e58*/ void PushGlobal<CBType>(ref CBType data, int shaderId);
            static /*0x383bd40*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x383b458*/ void Push<CBType>(ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x383bd40*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x383b458*/ void Push<CBType>(ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x383af28*/ void UpdateData<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            static /*0x3837da0*/ void UpdateData<CBType>(ref CBType data);
            static /*0x3839e58*/ void SetGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            static /*0x3837458*/ void SetGlobal<CBType>(int shaderId);
            static /*0x383b458*/ void Set<CBType>(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x3839e58*/ void Set<CBType>(UnityEngine.ComputeShader cs, int shaderId);
            static /*0x3839e58*/ void Set<CBType>(UnityEngine.Material mat, int shaderId);
            static /*0x7b20ca4*/ void ReleaseAll();
            static /*0x7b20e6c*/ void Register(UnityEngine.Rendering.ConstantBufferBase cb);
            /*0x7b20f40*/ ConstantBuffer();
        }

        class ConstantBufferBase
        {
            /*0x7b20fe0*/ ConstantBufferBase();
            /*0x380cb08*/ void Release();
        }

        class ConstantBuffer<CBType> : UnityEngine.Rendering.ConstantBufferBase
        {
            /*0x0*/ System.Collections.Generic.HashSet<int> m_GlobalBindings;
            /*0x0*/ CBType[] m_Data;
            /*0x0*/ UnityEngine.ComputeBuffer m_GPUConstantBuffer;

            /*0x380cb08*/ ConstantBuffer();
            /*0x380d93c*/ void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            /*0x380d83c*/ void UpdateData(ref CBType data);
            /*0x380d8b8*/ void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            /*0x380cffc*/ void SetGlobal(int shaderId);
            void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            /*0x380d8b8*/ void Set(UnityEngine.ComputeShader cs, int shaderId);
            /*0x380d8b8*/ void Set(UnityEngine.Material mat, int shaderId);
            /*0x380d8b8*/ void Set(UnityEngine.MaterialPropertyBlock mpb, int shaderId);
            void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            /*0x380d8b8*/ void PushGlobal(ref CBType data, int shaderId);
            /*0x380cb08*/ void Release();
        }

        class ConstantBufferSingleton<CBType> : UnityEngine.Rendering.ConstantBuffer<CBType>
        {
            static /*0x0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;

            static /*0x382dee4*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance();
            static /*0x3837da0*/ void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value);
            /*0x380cb08*/ ConstantBufferSingleton();
            /*0x380cb08*/ void Release();
        }

        class ContextContainer : System.IDisposable
        {
            static /*0x0*/ uint s_TypeCount;
            /*0x10*/ UnityEngine.Rendering.ContextContainer.Item[] m_Items;
            /*0x18*/ System.Collections.Generic.List<uint> m_ActiveItemIndices;

            /*0x7b211e4*/ ContextContainer();
            /*0x3907c14*/ T Get<T>();
            /*0x3907c14*/ T Create<T>();
            /*0x3907c14*/ T GetOrCreate<T>();
            /*0x380b128*/ bool Contains<T>();
            /*0x7b20fe8*/ bool Contains(uint typeId);
            /*0x3907c14*/ T CreateAndGetData<T>(uint typeId);
            /*0x7b21034*/ void Dispose();

            class TypeId<T>
            {
                static /*0x0*/ uint value;

                static /*0x38358cc*/ TypeId();
            }

            struct Item
            {
                /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                /*0x18*/ bool isSet;
            }
        }

        class ContextItem
        {
            /*0x7b18870*/ ContextItem();
            /*0x380cb08*/ void Reset();
        }

        class DisplayInfoAttribute : System.Attribute
        {
            /*0x10*/ string name;
            /*0x18*/ int order;

            /*0x7b2129c*/ DisplayInfoAttribute();
        }

        class AdditionalPropertyAttribute : System.Attribute
        {
            /*0x7b212a4*/ AdditionalPropertyAttribute();
        }

        class HideInDebugUIAttribute : System.Attribute
        {
            /*0x7b212ac*/ HideInDebugUIAttribute();
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
            static /*0x3907c14*/ void CopyTo<T>(System.Collections.Generic.List<T> list, void* dest, int count);
            static /*0x3907c14*/ void CopyTo<T>(T[] list, void* dest, int count);
            static /*0x7b212b4*/ void CalculateRadixParams(int radixBits, ref int bitStates);
            static /*0x7b212c4*/ int CalculateRadixSupportSize(int bitStates, int arrayLength);
            static /*0x7b212d0*/ void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, ref uint* bucketIndices, ref uint* bucketSizes, ref uint* bucketPrefix, ref uint* arrayOutput);
            static /*0x7b212f0*/ void MergeSort(uint* array, uint* support, int length);
            static /*0x7b21424*/ void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
            static /*0x7b2153c*/ void MergeSort(Unity.Collections.NativeArray<uint> arr, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray);
            static /*0x7b21660*/ void InsertionSort(uint* arr, int length);
            static /*0x7b216cc*/ void InsertionSort(uint[] arr, int sortSize);
            static /*0x7b2175c*/ void InsertionSort(Unity.Collections.NativeArray<uint> arr, int sortSize);
            static /*0x7b2181c*/ void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length);
            static /*0x7b21994*/ void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits);
            static /*0x7b21acc*/ void RadixSort(Unity.Collections.NativeArray<uint> array, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray, int radixBits);
            static /*0x7b21c10*/ void QuickSort(uint[] arr, int left, int right);
            static /*0x7b21c84*/ void QuickSort(ulong[] arr, int left, int right);
            static /*0x3907c14*/ void QuickSort<T>(int count, void* data);
            static /*0x3907c14*/ void QuickSort<TValue, TKey, TGetter>(int count, void* data);
            static /*0x3907c14*/ void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x3907c14*/ int IndexOf<T>(void* data, int count, T v);
            static /*0x3907c14*/ int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x7b21cf8*/ int CompareHashes(int oldHashCount, UnityEngine.Hash128* oldHashes, int newHashCount, UnityEngine.Hash128* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x3907c14*/ void CombineHashes<TValue, TGetter>(int count, void* hashes, UnityEngine.Hash128* outHash);
            static /*0x7b21d9c*/ void CombineHashes(int count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash);
            static /*0x3907c14*/ int Partition<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x7b21dfc*/ bool HaveDuplicates(int[] arr);

            struct FixedBufferStringQueue
            {
                /*0x10*/ byte* m_ReadCursor;
                /*0x18*/ byte* m_WriteCursor;
                /*0x20*/ byte* m_BufferEnd;
                /*0x28*/ byte* m_BufferStart;
                /*0x30*/ int m_BufferLength;
                /*0x34*/ int <Count>k__BackingField;

                /*0x7b21f74*/ FixedBufferStringQueue(byte* ptr, int length);
                /*0x7b21f64*/ int get_Count();
                /*0x7b21f6c*/ void set_Count(int value);
                /*0x7b21fb4*/ bool TryPush(string v);
                /*0x7b22064*/ bool TryPop(ref string v);
                /*0x7b21f98*/ void Clear();
            }

            interface IKeyGetter<TValue, TKey>
            {
                /*0x3907c14*/ TKey Get(ref TValue v);
            }

            struct DefaultKeyGetter<T> : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<T, T>
            {
                /*0x3907c14*/ T Get(ref T v);
            }

            struct UintKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<uint, uint>
            {
                /*0x7b220e4*/ uint Get(ref uint v);
            }

            struct UlongKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<ulong, ulong>
            {
                /*0x7b220ec*/ ulong Get(ref ulong v);
            }
        }

        class DynamicArray<T>
        {
            /*0x0*/ T[] m_Array;
            /*0x0*/ int <size>k__BackingField;

            static /*0x382eaf0*/ T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x3907c14*/ System.ReadOnlySpan<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x3907c14*/ System.Span<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x380cb08*/ DynamicArray();
            /*0x380cffc*/ DynamicArray(int size);
            /*0x380d03c*/ DynamicArray(int capacity, bool resize);
            /*0x380d83c*/ DynamicArray(UnityEngine.Rendering.DynamicArray<T> deepCopy);
            /*0x380b6a0*/ int get_size();
            /*0x380cffc*/ void set_size(int value);
            /*0x380b6a0*/ int get_capacity();
            /*0x380cb08*/ void Clear();
            /*0x3907c14*/ bool Contains(T item);
            /*0x380b7a8*/ int Add(ref T value);
            /*0x380d83c*/ void AddRange(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x3907c14*/ void Insert(int index, T item);
            /*0x3907c14*/ bool Remove(T item);
            /*0x380cffc*/ void RemoveAt(int index);
            /*0x380d0e4*/ void RemoveRange(int index, int count);
            /*0x3907c14*/ int FindIndex(int startIndex, int count, System.Predicate<T> match);
            /*0x3907c14*/ int IndexOf(T item, int index, int count);
            /*0x3907c14*/ int IndexOf(T item, int index);
            /*0x3907c14*/ int IndexOf(T item);
            /*0x380d03c*/ void Resize(int newSize, bool keepContent);
            /*0x380cffc*/ void ResizeAndClear(int newSize);
            /*0x380d03c*/ void Reserve(int newCapacity, bool keepContent);
            /*0x380ba90*/ ref T get_Item(int index);
            /*0x3907c14*/ UnityEngine.Rendering.DynamicArray.Iterator<T> GetEnumerator();
            /*0x3907c14*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems);
            /*0x380cb08*/ void BumpVersion();

            struct Iterator<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                /*0x0*/ int index;

                /*0x380d83c*/ Iterator(UnityEngine.Rendering.DynamicArray<T> setOwner);
                /*0x380b9e8*/ ref T get_Current();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
            }

            struct RangeEnumerable<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> iterator;

                /*0x3907c14*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> GetEnumerator();

                struct RangeIterator<T>
                {
                    /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                    /*0x0*/ int index;
                    /*0x0*/ int first;
                    /*0x0*/ int last;

                    RangeIterator(UnityEngine.Rendering.DynamicArray<T> setOwner, int first, int numItems);
                    /*0x380b9e8*/ ref T get_Current();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                }
            }

            class SortComparer<T> : System.MulticastDelegate
            {
                SortComparer(object object, nint method);
                /*0x3907c14*/ int Invoke(T x, T y);
                /*0x3907c14*/ System.IAsyncResult BeginInvoke(T x, T y, System.AsyncCallback callback, object object);
                /*0x380b7a8*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class DynamicArrayExtensions
        {
            static /*0x3907c14*/ int Partition<T>(System.Span<T> data, int left, int right);
            static /*0x3907c14*/ void QuickSort<T>(System.Span<T> data, int left, int right);
            static /*0x3907c14*/ int Partition<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x3907c14*/ void QuickSort<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x3837da0*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x383af28*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
        }

        class PerformDynamicRes : System.MulticastDelegate
        {
            /*0x7b220f4*/ PerformDynamicRes(object object, nint method);
            /*0x7b22190*/ float Invoke();
            /*0x7b221a4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x7b221c4*/ float EndInvoke(System.IAsyncResult result);
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

            static /*0x7b238dc*/ DynamicResolutionHandler();
            static /*0x7b223e8*/ UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera);
            static /*0x7b228b8*/ UnityEngine.Rendering.DynamicResolutionHandler get_instance();
            static /*0x7b22a94*/ float DefaultDynamicResMethod();
            static /*0x7b22d68*/ void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x7b22e1c*/ void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x7b22ed4*/ void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot);
            static /*0x7b22f30*/ void ClearSelectedCamera();
            static /*0x7b22fa4*/ void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter);
            static /*0x7b230d4*/ void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange);
            /*0x7b22820*/ DynamicResolutionHandler();
            /*0x7b221ec*/ void Reset();
            /*0x7b22228*/ UnityEngine.Rendering.DynamicResUpscaleFilter get_filter();
            /*0x7b22230*/ void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value);
            /*0x7b22238*/ UnityEngine.Vector2Int get_finalViewport();
            /*0x7b22240*/ void set_finalViewport(UnityEngine.Vector2Int value);
            /*0x7b22248*/ void set_runUpscalerFilterOnFullResolution(bool value);
            /*0x7b22254*/ bool get_runUpscalerFilterOnFullResolution();
            /*0x7b22274*/ bool get_forcingResolution();
            /*0x7b2227c*/ bool FlushScalableBufferManagerState();
            /*0x7b228a8*/ void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value);
            /*0x7b228b0*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule();
            /*0x7b22a9c*/ void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings);
            /*0x7b22c64*/ UnityEngine.Vector2 GetResolvedScale();
            /*0x7b22cd8*/ float CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, bool forceApply);
            /*0x7b230c8*/ void SetCurrentCameraRequest(bool cameraRequest);
            /*0x7b232b8*/ void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange);
            /*0x7b23534*/ bool SoftwareDynamicResIsEnabled();
            /*0x7b223b8*/ bool HardwareDynamicResIsEnabled();
            /*0x7b23590*/ bool RequestsHardwareDynamicResolution();
            /*0x7b235b0*/ bool DynamicResolutionEnabled();
            /*0x7b235f8*/ void ForceSoftwareFallback();
            /*0x7b23604*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size);
            /*0x7b23654*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size);
            /*0x7b2367c*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales);
            /*0x7b23804*/ float GetCurrentScale();
            /*0x7b23820*/ UnityEngine.Vector2Int GetLastScaledSize();
            /*0x7b23828*/ float GetLowResMultiplier(float targetLowRes);
            /*0x7b23830*/ float GetLowResMultiplier(float targetLowRes, float minimumThreshold);

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
            /*0x7b23b50*/ DynamicString();
            /*0x7b23b98*/ DynamicString(string s);
            /*0x7b23c50*/ DynamicString(int capacity);
            /*0x7b23cac*/ void Append(string s);
            /*0x7b23dc4*/ void Append(UnityEngine.Rendering.DynamicString s);
            /*0x7b23e1c*/ string ToString();
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

            static /*0x7b22910*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault();
        }

        interface IAdditionalData
        {
        }

        interface IVirtualTexturingEnabledRenderPipeline
        {
            /*0x380b128*/ bool get_virtualTexturingEnabled();
        }

        struct ListBuffer<T>
        {
            /*0x0*/ T* m_BufferPtr;
            /*0x0*/ int m_Capacity;
            /*0x0*/ int* m_CountPtr;

            /*0x3907c14*/ ListBuffer(T* bufferPtr, int* countPtr, int capacity);
            /*0x3907c14*/ T* get_BufferPtr();
            /*0x380b6a0*/ int get_Count();
            /*0x380b6a0*/ int get_Capacity();
            /*0x380bb68*/ ref T get_Item(ref int index);
            /*0x380bb68*/ ref T GetUnchecked(ref int index);
            /*0x380b2f0*/ bool TryAdd(ref T value);
            /*0x3907c14*/ void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
            /*0x3907c14*/ bool TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other);
            /*0x3907c14*/ bool TryCopyFrom(T* srcPtr, int count);
        }

        class ListBufferExtensions
        {
            static /*0x3907c14*/ void QuickSort<T>(UnityEngine.Rendering.ListBuffer<T> self);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, bool collectionCheck);
            /*0x380b6a0*/ int get_countAll();
            /*0x380cffc*/ void set_countAll(int value);
            /*0x380b6a0*/ int get_countActive();
            /*0x380b6a0*/ int get_countInactive();
            /*0x3907c14*/ T Get();
            /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T v);
            /*0x3907c14*/ void Release(T element);

            struct PooledObject<T> : System.IDisposable
            {
                /*0x0*/ T m_ToReturn;
                /*0x0*/ UnityEngine.Rendering.ObjectPool<T> m_Pool;

                /*0x3907c14*/ PooledObject(T value, UnityEngine.Rendering.ObjectPool<T> pool);
                /*0x380cb08*/ void System.IDisposable.Dispose();
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x38358cc*/ GenericPool();
            static /*0x3907c14*/ T Get();
            static /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x3907c14*/ void Release(T toRelease);
        }

        class UnsafeGenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x38358cc*/ UnsafeGenericPool();
            static /*0x3907c14*/ T Get();
            static /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x3907c14*/ void Release(T toRelease);
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;

            static /*0x38358cc*/ ListPool();
            static /*0x382dee4*/ System.Collections.Generic.List<T> Get();
            static /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(ref System.Collections.Generic.List<T> value);
            static /*0x3837da0*/ void Release(System.Collections.Generic.List<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ListPool.<>c<T> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380d83c*/ void <.cctor>b__4_0(System.Collections.Generic.List<T> l);
            }
        }

        class HashSetPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;

            static /*0x38358cc*/ HashSetPool();
            static /*0x382dee4*/ System.Collections.Generic.HashSet<T> Get();
            static /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(ref System.Collections.Generic.HashSet<T> value);
            static /*0x3837da0*/ void Release(System.Collections.Generic.HashSet<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.HashSetPool.<>c<T> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380d83c*/ void <.cctor>b__4_0(System.Collections.Generic.HashSet<T> l);
            }
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey, TValue>> s_Pool;

            static /*0x38358cc*/ DictionaryPool();
            static /*0x382dee4*/ System.Collections.Generic.Dictionary<TKey, TValue> Get();
            static /*0x3907c14*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey, TValue>> Get(ref System.Collections.Generic.Dictionary<TKey, TValue> value);
            static /*0x3837da0*/ void Release(System.Collections.Generic.Dictionary<TKey, TValue> toRelease);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ UnityEngine.Rendering.DictionaryPool.<>c<TKey, TValue> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380d83c*/ void <.cctor>b__4_0(System.Collections.Generic.Dictionary<TKey, TValue> l);
            }
        }

        struct Observable<T>
        {
            /*0x0*/ System.Action<T> onValueChanged;
            /*0x0*/ T m_Value;

            /*0x3907c14*/ Observable(T newValue);
            /*0x380d83c*/ void add_onValueChanged(System.Action<T> value);
            /*0x380d83c*/ void remove_onValueChanged(System.Action<T> value);
            /*0x3907c14*/ T get_value();
            /*0x3907c14*/ void set_value(T value);
        }

        class ListChangedEventArgs<T> : System.EventArgs
        {
            /*0x0*/ int index;
            /*0x0*/ T item;

            /*0x3907c14*/ ListChangedEventArgs(int index, T item);
        }

        class ListChangedEventHandler<T> : System.MulticastDelegate
        {
            ListChangedEventHandler(object object, nint method);
            /*0x380d93c*/ void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e);
            /*0x380bd7c*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, object object);
            /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
        }

        class ObservableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<T> m_List;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;

            /*0x380cb08*/ ObservableList();
            /*0x380cffc*/ ObservableList(int capacity);
            /*0x380d83c*/ ObservableList(System.Collections.Generic.IEnumerable<T> collection);
            /*0x380d83c*/ void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x380d83c*/ void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x380d83c*/ void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x380d83c*/ void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x3907c14*/ T get_Item(int index);
            /*0x3907c14*/ void set_Item(int index, T value);
            /*0x380b6a0*/ int get_Count();
            /*0x380b128*/ bool get_IsReadOnly();
            /*0x3907c14*/ void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, int index, T item);
            /*0x3907c14*/ bool Contains(T item);
            /*0x3907c14*/ int IndexOf(T item);
            /*0x3907c14*/ void Add(T item);
            /*0x380d83c*/ void Add(T[] items);
            /*0x3907c14*/ void Insert(int index, T item);
            /*0x3907c14*/ bool Remove(T item);
            /*0x380b7a8*/ int Remove(T[] items);
            /*0x380cffc*/ void RemoveAt(int index);
            /*0x380cb08*/ void Clear();
            /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class ReloadAttribute : System.Attribute
        {
            /*0x7b23e68*/ ReloadAttribute(string[] paths, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x7b23e70*/ ReloadAttribute(string path, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x7b23ef0*/ ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package);

            enum Package
            {
                Builtin = 0,
                Root = 1,
                BuiltinExtra = 2,
            }
        }

        class ReloadGroupAttribute : System.Attribute
        {
            /*0x7b23ef8*/ ReloadGroupAttribute();
        }

        class RemoveRangeExtensions
        {
            static bool TryRemoveElementsInRange<TValue>(System.Collections.Generic.IList<TValue> list, int index, int count, ref System.Exception error);
        }

        class SerializableEnum
        {
            /*0x10*/ string m_EnumValueAsString;
            /*0x18*/ string m_EnumTypeAsString;

            /*0x7b24058*/ SerializableEnum(System.Type enumType);
            /*0x7b23f00*/ System.Enum get_value();
            /*0x7b24020*/ void set_value(System.Enum value);
        }

        class SerializedDictionaryDebugView<K, V>
        {
            /*0x0*/ System.Collections.Generic.IDictionary<K, V> dict;

            /*0x380d83c*/ SerializedDictionaryDebugView(System.Collections.Generic.IDictionary<K, V> dictionary);
            /*0x380b9e8*/ System.Collections.Generic.KeyValuePair<K, V> get_Items();
        }

        class SerializedDictionary<K, V> : UnityEngine.Rendering.SerializedDictionary<K, V, K, V>
        {
            /*0x380cb08*/ SerializedDictionary();
            /*0x3907c14*/ K SerializeKey(K key);
            /*0x3907c14*/ V SerializeValue(V val);
            /*0x3907c14*/ K DeserializeKey(K key);
            /*0x3907c14*/ V DeserializeValue(V val);
        }

        class SerializedDictionary<K, V, SK, SV> : System.Collections.Generic.Dictionary<K, V>, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x0*/ System.Collections.Generic.List<SK> m_Keys;
            /*0x0*/ System.Collections.Generic.List<SV> m_Values;

            /*0x380cb08*/ SerializedDictionary();
            /*0x3907c14*/ SK SerializeKey(K key);
            /*0x3907c14*/ SV SerializeValue(V value);
            /*0x3907c14*/ K DeserializeKey(SK serializedKey);
            /*0x3907c14*/ V DeserializeValue(SV serializedValue);
            /*0x380cb08*/ void OnBeforeSerialize();
            /*0x380cb08*/ void OnAfterDeserialize();
        }

        class SwapCollectionExtensions
        {
            static bool TrySwap<TValue>(System.Collections.Generic.IList<TValue> list, int from, int to, ref System.Exception error);
        }

        class DebugDisplaySettings<T> : UnityEngine.Rendering.IDebugDisplaySettings
        {
            static /*0x0*/ System.Lazy<T> s_Instance;
            /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.IDebugDisplaySettingsData> m_Settings;

            static /*0x38358cc*/ DebugDisplaySettings();
            static /*0x3907c14*/ T get_Instance();
            /*0x380cb08*/ DebugDisplaySettings();
            /*0x380b128*/ bool get_AreAnySettingsActive();
            /*0x380b128*/ bool get_IsPostProcessingAllowed();
            /*0x380b128*/ bool get_IsLightingActive();
            /*0x3907c14*/ TData Add<TData>(TData newData);
            /*0x380bb68*/ UnityEngine.Rendering.IDebugDisplaySettingsData UnityEngine.Rendering.IDebugDisplaySettings.Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
            /*0x380d83c*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x380cb08*/ void Reset();
            /*0x380b2f0*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);

            class IDebugDisplaySettingsDataComparer<T> : System.Collections.Generic.IEqualityComparer<UnityEngine.Rendering.IDebugDisplaySettingsData>
            {
                /*0x380cb08*/ IDebugDisplaySettingsDataComparer();
                /*0x380b32c*/ bool Equals(UnityEngine.Rendering.IDebugDisplaySettingsData x, UnityEngine.Rendering.IDebugDisplaySettingsData y);
                /*0x380b7a8*/ int GetHashCode(UnityEngine.Rendering.IDebugDisplaySettingsData obj);
            }

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.DebugDisplaySettings.<>c<T> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ T <.cctor>b__17_0();
            }
        }

        class DebugDisplaySettingsHDROutput
        {
            static /*0x7b240e8*/ UnityEngine.Rendering.DebugUI.Table CreateHDROuputDisplayTable();
            /*0x7b24b98*/ DebugDisplaySettingsHDROutput();

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

                static /*0x7b25440*/ Strings();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.HDROutputSettings d;

                /*0x7b256d4*/ <>c__DisplayClass1_0();
                /*0x7b256dc*/ object <CreateHDROuputDisplayTable>b__0();
                /*0x7b2571c*/ object <CreateHDROuputDisplayTable>b__1();
                /*0x7b2575c*/ object <CreateHDROuputDisplayTable>b__2();
                /*0x7b2580c*/ object <CreateHDROuputDisplayTable>b__3();
                /*0x7b258bc*/ object <CreateHDROuputDisplayTable>b__4();
                /*0x7b25964*/ object <CreateHDROuputDisplayTable>b__5();
                /*0x7b25a04*/ object <CreateHDROuputDisplayTable>b__6();
                /*0x7b25aa8*/ object <CreateHDROuputDisplayTable>b__7();
                /*0x7b25b4c*/ object <CreateHDROuputDisplayTable>b__8();
                /*0x7b25bf0*/ object <CreateHDROuputDisplayTable>b__9();
            }
        }

        class DebugDisplaySettingsPanel : UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable, UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> m_Widgets;
            /*0x18*/ UnityEngine.Rendering.DisplayInfoAttribute m_DisplayInfo;

            /*0x7b25ea0*/ DebugDisplaySettingsPanel();
            /*0x7b25c98*/ string get_PanelName();
            /*0x7b25cc4*/ int get_Order();
            /*0x7b25cdc*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x7b25d2c*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
            /*0x7b25d34*/ void AddWidget(UnityEngine.Rendering.DebugUI.Widget widget);
            /*0x7b25e2c*/ void Clear();
            /*0x7b25e9c*/ void Dispose();
        }

        class DebugDisplaySettingsPanel<T> : UnityEngine.Rendering.DebugDisplaySettingsPanel
        {
            /*0x0*/ T m_Data;

            /*0x3907c14*/ DebugDisplaySettingsPanel(T data);
            /*0x3907c14*/ T get_data();
            /*0x3907c14*/ void set_data(T value);
        }

        class DebugDisplaySettingsStats<TProfileId> : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <debugDisplayStats>k__BackingField;

            /*0x380d83c*/ DebugDisplaySettingsStats(UnityEngine.Rendering.DebugDisplayStats<TProfileId> debugDisplayStats);
            /*0x380b9e8*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> get_debugDisplayStats();
            /*0x380b128*/ bool get_AreAnySettingsActive();
            /*0x380b9e8*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class StatsPanel<TProfileId> : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x0*/ UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> m_Data;

                /*0x380d83c*/ StatsPanel(UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> displaySettingsStats);
                /*0x380b6a0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x380cb08*/ void Dispose();
            }
        }

        class DebugDisplaySettingsUI : UnityEngine.Rendering.IDebugData
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;
            /*0x18*/ UnityEngine.Rendering.IDebugDisplaySettings m_Settings;

            /*0x7b26ce8*/ DebugDisplaySettingsUI();
            /*0x7b26000*/ void Reset();
            /*0x7b26618*/ void RegisterDebug(UnityEngine.Rendering.IDebugDisplaySettings settings);
            /*0x7b260ec*/ void UnregisterDebug();
            /*0x7b26c6c*/ System.Action GetReset();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager debugManager;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> panels;

                /*0x7b26918*/ <>c__DisplayClass3_0();
                /*0x7b26cf0*/ void <RegisterDebug>b__0(UnityEngine.Rendering.IDebugDisplaySettingsData data);
            }
        }

        class DebugDisplaySettingsVolume : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            static string k_PanelTitle = "Volume";
            /*0x10*/ UnityEngine.Rendering.IVolumeDebugSettings <volumeDebugSettings>k__BackingField;
            /*0x18*/ int volumeComponentEnumIndex;
            /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.VolumeComponent> debugState;

            /*0x7b27004*/ DebugDisplaySettingsVolume(UnityEngine.Rendering.IVolumeDebugSettings volumeDebugSettings);
            /*0x7b26ffc*/ UnityEngine.Rendering.IVolumeDebugSettings get_volumeDebugSettings();
            /*0x7b270a0*/ bool get_AreAnySettingsActive();
            /*0x7b270a8*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class Styles
            {
                static /*0x0*/ UnityEngine.GUIContent none;
                static /*0x8*/ UnityEngine.GUIContent editorCamera;

                static /*0x7b27264*/ Styles();
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

                static /*0x7b27340*/ Strings();
            }

            class WidgetFactory
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Value s_EmptyDebugUIValue;

                static /*0x7b2a4d0*/ WidgetFactory();
                static /*0x7b2764c*/ UnityEngine.Rendering.DebugUI.EnumField CreateComponentSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> refresh);
                static /*0x7b28018*/ UnityEngine.Rendering.DebugUI.ObjectPopupField CreateCameraSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>, UnityEngine.Object> refresh);
                static /*0x7b2827c*/ UnityEngine.Rendering.DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, UnityEngine.Rendering.VolumeParameter param, System.Func<bool> isHiddenCallback);
                static /*0x7b28330*/ UnityEngine.Rendering.VolumeComponent GetSelectedVolumeComponent(UnityEngine.Rendering.VolumeProfile profile, System.Type selectedType);
                static /*0x7b28520*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x7b29258*/ UnityEngine.Rendering.DebugUI.Table CreateVolumeTable(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x7b2a000*/ void SetTableColumnVisibility(UnityEngine.Rendering.DebugDisplaySettingsVolume data, UnityEngine.Rendering.DebugUI.Table table);
                static /*0x7b29804*/ void GenerateTableColumns(UnityEngine.Rendering.DebugUI.Table table, UnityEngine.Rendering.DebugDisplaySettingsVolume data, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);
                static /*0x7b2956c*/ void GenerateTableRows(UnityEngine.Rendering.DebugUI.Table table, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);

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

                    static /*0x7b2a5dc*/ <>c();
                    /*0x7b2a644*/ <>c();
                    /*0x7b2a64c*/ object <GenerateTableColumns>b__9_2();
                    /*0x7b2a664*/ object <.cctor>b__11_0();
                }

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x7b27d18*/ <>c__DisplayClass0_0();
                    /*0x7b2a67c*/ int <CreateComponentSelector>b__0();
                    /*0x7b2a738*/ void <CreateComponentSelector>b__1(int value);
                    /*0x7b2a800*/ int <CreateComponentSelector>b__2();
                    /*0x7b2a850*/ void <CreateComponentSelector>b__3(int value);
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x7b2822c*/ <>c__DisplayClass1_0();
                    /*0x7b2a8a4*/ UnityEngine.Object <CreateCameraSelector>b__0();
                    /*0x7b2a964*/ void <CreateCameraSelector>b__1(UnityEngine.Object value);
                    /*0x7b2ab14*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <CreateCameraSelector>b__2();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;
                    /*0x18*/ float timer;
                    /*0x1c*/ float refreshRate;
                    /*0x20*/ UnityEngine.Rendering.DebugUI.Table table;
                    /*0x28*/ UnityEngine.Rendering.Volume[] volumes;

                    /*0x7b29510*/ <>c__DisplayClass7_0();
                    /*0x7b2abd4*/ bool <CreateVolumeTable>b__1();
                    /*0x7b2ac88*/ bool <CreateVolumeTable>b__0();
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;

                    /*0x7b2a3a8*/ <>c__DisplayClass9_0();
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain;
                    /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.<> CS$<>8__locals1;

                    /*0x7b2a3b0*/ <>c__DisplayClass9_1();
                    /*0x7b2aef4*/ object <GenerateTableColumns>b__0();
                    /*0x7b2b070*/ UnityEngine.Object <GenerateTableColumns>b__1();
                    /*0x7b2b078*/ UnityEngine.Object <GenerateTableColumns>b__3();
                }
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.DebugDisplaySettingsVolume>
            {
                /*0x28*/ UnityEngine.Rendering.DebugUI.Table m_VolumeTable;

                /*0x7b27100*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                /*0x7b2b080*/ void Refresh();
                /*0x7b2b32c*/ void <.ctor>b__0_0(UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object> _, UnityEngine.Object __);
                /*0x7b2b330*/ void <.ctor>b__0_1(UnityEngine.Rendering.DebugUI.Field<int> _, int __);
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

            static /*0x38358cc*/ DebugDisplayStats();
            /*0x380cb08*/ DebugDisplayStats();
            /*0x380cb08*/ void EnableProfilingRecorders();
            /*0x380cb08*/ void DisableProfilingRecorders();
            /*0x380d83c*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x380cb08*/ void Update();
            /*0x380b9e8*/ System.Collections.Generic.List<TProfileId> GetProfilerIdsToDisplay();
            /*0x380d83c*/ void UpdateDetailedStats(System.Collections.Generic.List<TProfileId> samplers);
            /*0x380bcbc*/ UnityEngine.Rendering.DebugUI.Widget BuildDetailedStatsList(string title, System.Collections.Generic.List<TProfileId> samplers);
            void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, System.Collections.Generic.List<TProfileId> samplers);
            /*0x3907c14*/ float GetSamplerTiming(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);
            /*0x380bb68*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> BuildProfilingSamplerWidgetList(System.Collections.Generic.IEnumerable<TProfileId> samplers);
            /*0x3907c14*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);

            class AccumulatedTiming<TProfileId>
            {
                /*0x0*/ float accumulatedValue;
                /*0x0*/ float lastAverage;

                /*0x380cb08*/ AccumulatedTiming();
                /*0x380cffc*/ void UpdateLastAverage(int frameCount);
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

                /*0x380cb08*/ <>c__DisplayClass19_0();
                /*0x380b9e8*/ object <BuildProfilingSamplerWidgetList>b__1();
            }

            class <>c__DisplayClass19_<TProfileId>
            {
                /*0x0*/ TProfileId samplerId;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <>4__this;

                /*0x380cb08*/ <>c__DisplayClass19_();
                /*0x380b128*/ bool <BuildProfilingSamplerWidgetList>b__2();
            }

            class <>c__DisplayClass19_2<TProfileId>
            {
                /*0x0*/ UnityEngine.Rendering.ProfilingSampler sampler;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats.<>c__DisplayClass19_1<TProfileId> CS$<>8__locals1;

                /*0x380cb08*/ <>c__DisplayClass19_2();
                /*0x3907c14*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>b__3(UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> e);
            }

            class <>c__DisplayClass6_0<TProfileId>
            {
                /*0x0*/ System.Type type;
                /*0x0*/ System.Func<System.Reflection.MemberInfo, bool> <>9__0;

                /*0x380cb08*/ <>c__DisplayClass6_0();
                /*0x380b2f0*/ bool <GetProfilerIdsToDisplay>b__0(System.Reflection.MemberInfo m);
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

            /*0x7b2b354*/ DebugFrameTiming();
            /*0x7b2b334*/ int get_bottleneckHistorySize();
            /*0x7b2b33c*/ void set_bottleneckHistorySize(int value);
            /*0x7b2b344*/ int get_sampleHistorySize();
            /*0x7b2b34c*/ void set_sampleHistorySize(int value);
            /*0x7b2b5bc*/ void UpdateFrameTiming();
            /*0x7b2be38*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x7b2d354*/ void Reset();
            /*0x7b2d420*/ object <RegisterDebugUI>b__17_0();
            /*0x7b2d454*/ object <RegisterDebugUI>b__17_1();
            /*0x7b2d488*/ object <RegisterDebugUI>b__17_2();
            /*0x7b2d4bc*/ object <RegisterDebugUI>b__17_3();
            /*0x7b2d4f0*/ object <RegisterDebugUI>b__17_4();
            /*0x7b2d524*/ object <RegisterDebugUI>b__17_5();
            /*0x7b2d558*/ object <RegisterDebugUI>b__17_6();
            /*0x7b2d58c*/ object <RegisterDebugUI>b__17_7();
            /*0x7b2d5c0*/ object <RegisterDebugUI>b__17_8();
            /*0x7b2d5f4*/ object <RegisterDebugUI>b__17_9();
            /*0x7b2d628*/ object <RegisterDebugUI>b__17_10();
            /*0x7b2d65c*/ object <RegisterDebugUI>b__17_11();
            /*0x7b2d690*/ object <RegisterDebugUI>b__17_12();
            /*0x7b2d6c4*/ object <RegisterDebugUI>b__17_13();
            /*0x7b2d6f8*/ object <RegisterDebugUI>b__17_14();
            /*0x7b2d72c*/ object <RegisterDebugUI>b__17_15();
            /*0x7b2d760*/ object <RegisterDebugUI>b__17_16();
            /*0x7b2d794*/ object <RegisterDebugUI>b__17_17();
            /*0x7b2d7c8*/ object <RegisterDebugUI>b__17_18();
            /*0x7b2d7fc*/ object <RegisterDebugUI>b__17_19();
            /*0x7b2d830*/ object <RegisterDebugUI>b__17_20();
            /*0x7b2d864*/ object <RegisterDebugUI>b__17_21();
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

            static /*0x7b32130*/ DebugManager();
            static /*0x7b26894*/ UnityEngine.Rendering.DebugManager get_instance();
            static /*0x7b31a0c*/ void add_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            static /*0x7b31b00*/ void remove_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            /*0x7b2f810*/ DebugManager();
            /*0x7b2d898*/ void RegisterActions();
            /*0x7b2de0c*/ void EnableInputActions();
            /*0x7b2dd14*/ void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc);
            /*0x7b2e080*/ void SampleAction(int actionIndex);
            /*0x7b2e230*/ void UpdateAction(int actionIndex);
            /*0x7b2e46c*/ void UpdateActions();
            /*0x7b2e4c4*/ float GetAction(UnityEngine.Rendering.DebugAction action);
            /*0x7b2e4fc*/ bool GetActionToggleDebugMenuWithTouch();
            /*0x7b2e78c*/ bool GetActionReleaseScrollTarget();
            /*0x7b2e8f0*/ void RegisterInputs();
            /*0x7b2f260*/ void UpdateReadOnlyCollection();
            /*0x7b2f2e4*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels();
            /*0x7b2f308*/ void add_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x7b2f3b8*/ void remove_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x7b2f468*/ void add_onSetDirty(System.Action value);
            /*0x7b2f504*/ void remove_onSetDirty(System.Action value);
            /*0x7b2f5a0*/ void add_resetData(System.Action value);
            /*0x7b2f63c*/ void remove_resetData(System.Action value);
            /*0x7b2f6d8*/ bool get_isAnyDebugUIActive();
            /*0x7b2690c*/ void RefreshEditor();
            /*0x7b2fac8*/ void Reset();
            /*0x7b2aec8*/ void ReDrawOnScreenDebug();
            /*0x7b26920*/ void RegisterData(UnityEngine.Rendering.IDebugData data);
            /*0x7b26bc0*/ void UnregisterData(UnityEngine.Rendering.IDebugData data);
            /*0x7b2faf4*/ int GetState();
            /*0x7b2fc5c*/ void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root);
            /*0x7b2fca8*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
            /*0x7b2fcc8*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
            /*0x7b2fd60*/ void EnsurePersistentCanvas();
            /*0x7b2ff8c*/ void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget, System.Nullable<int> forceTupleIndex);
            /*0x7b304fc*/ void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x7b30520*/ int PanelIndex(string displayName);
            /*0x7b305ec*/ string PanelDiplayName(int panelIndex);
            /*0x7b30688*/ void RequestEditorWindowPanelIndex(int index);
            /*0x7b306f0*/ System.Nullable<int> GetRequestedEditorWindowPanelIndex();
            /*0x7b269cc*/ UnityEngine.Rendering.DebugUI.Panel GetPanel(string displayName, bool createIfNull, int groupIndex, bool overrideIfExist);
            /*0x7b30ac4*/ int FindPanelIndex(string displayName);
            /*0x7b30bb0*/ void RemovePanel(string displayName);
            /*0x7b307b0*/ void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x7b30d68*/ UnityEngine.Rendering.DebugUI.Widget[] GetItems(UnityEngine.Rendering.DebugUI.Flags flags);
            /*0x7b3100c*/ UnityEngine.Rendering.DebugUI.Widget[] GetItemsFromContainer(UnityEngine.Rendering.DebugUI.Flags flags, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x7b31558*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath);
            /*0x7b316b0*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x7b31bf4*/ bool get_displayEditorUI();
            /*0x7b31c10*/ void set_displayEditorUI(bool value);
            /*0x7b31cc0*/ bool get_enableRuntimeUI();
            /*0x7b31cc8*/ void set_enableRuntimeUI(bool value);
            /*0x7b2f700*/ bool get_displayRuntimeUI();
            /*0x7b31cf8*/ void set_displayRuntimeUI(bool value);
            /*0x7b2f788*/ bool get_displayPersistentRuntimeUI();
            /*0x7b32078*/ void set_displayPersistentRuntimeUI(bool value);
            /*0x7b32114*/ void ToggleEditorUI(bool open);

            enum UIMode
            {
                EditorMode = 0,
                RuntimeMode = 1,
            }

            class UIState
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager.UIMode mode;
                /*0x14*/ bool m_Open;

                /*0x7b2fac0*/ UIState();
                /*0x7b32248*/ bool get_open();
                /*0x7b31c2c*/ void set_open(bool value);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.DebugManager.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__49_0;
                static /*0x10*/ System.Action <>9__49_1;
                static /*0x18*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, int> <>9__60_0;

                static /*0x7b32250*/ <>c();
                /*0x7b322b8*/ <>c();
                /*0x7b322c0*/ void <.ctor>b__49_0(bool <p0>);
                /*0x7b322c4*/ void <.ctor>b__49_1();
                /*0x7b322c8*/ int <TogglePersistent>b__60_0(UnityEngine.Rendering.DebugUI.Widget w);
                /*0x7b32344*/ UnityEngine.Rendering.DebugManager <.cctor>b__95_0();
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ string displayName;

                /*0x7b30ba8*/ <>c__DisplayClass67_0();
                /*0x7b32394*/ bool <FindPanelIndex>b__0(UnityEngine.Rendering.DebugUI.Panel p);
            }
        }

        class DebugActionDesc
        {
            /*0x10*/ UnityEngine.InputSystem.InputAction buttonAction;
            /*0x18*/ UnityEngine.Rendering.DebugActionRepeatMode repeatMode;
            /*0x1c*/ float repeatDelay;

            /*0x7b2dd0c*/ DebugActionDesc();
        }

        class DebugActionState
        {
            /*0x10*/ UnityEngine.Rendering.DebugActionState.DebugActionKeyType m_Type;
            /*0x18*/ UnityEngine.InputSystem.InputAction inputAction;
            /*0x20*/ bool[] m_TriggerPressedUp;
            /*0x28*/ float m_Timer;
            /*0x2c*/ bool <runningAction>k__BackingField;
            /*0x30*/ float <actionState>k__BackingField;

            /*0x7b2e078*/ DebugActionState();
            /*0x7b323b8*/ bool get_runningAction();
            /*0x7b323c0*/ void set_runningAction(bool value);
            /*0x7b323cc*/ float get_actionState();
            /*0x7b323d4*/ void set_actionState(float value);
            /*0x7b323dc*/ void Trigger(int triggerCount, float state);
            /*0x7b2e1b8*/ void TriggerWithButton(UnityEngine.InputSystem.InputAction action, float state);
            /*0x7b324a4*/ void Reset();
            /*0x7b2e294*/ void Update(UnityEngine.Rendering.DebugActionDesc desc);

            enum DebugActionKeyType
            {
                Button = 0,
                Axis = 1,
                Key = 2,
            }
        }

        interface IDebugData
        {
            /*0x380b9e8*/ System.Action GetReset();
        }

        class DebugOverlay
        {
            /*0x10*/ int <x>k__BackingField;
            /*0x14*/ int <y>k__BackingField;
            /*0x18*/ int <overlaySize>k__BackingField;
            /*0x1c*/ int m_InitialPositionX;
            /*0x20*/ int m_ScreenWidth;

            /*0x7b3259c*/ DebugOverlay();
            /*0x7b324b8*/ int get_x();
            /*0x7b324c0*/ void set_x(int value);
            /*0x7b324c8*/ int get_y();
            /*0x7b324d0*/ void set_y(int value);
            /*0x7b324d8*/ int get_overlaySize();
            /*0x7b324e0*/ void set_overlaySize(int value);
            /*0x7b324e8*/ void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth);
            /*0x7b324f8*/ UnityEngine.Rect Next(float aspect);
            /*0x7b32568*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd);
        }

        class DebugShapes
        {
            static /*0x0*/ UnityEngine.Rendering.DebugShapes s_Instance;
            /*0x10*/ UnityEngine.Mesh m_sphereMesh;
            /*0x18*/ UnityEngine.Mesh m_boxMesh;
            /*0x20*/ UnityEngine.Mesh m_coneMesh;
            /*0x28*/ UnityEngine.Mesh m_pyramidMesh;

            static /*0x7b325a4*/ UnityEngine.Rendering.DebugShapes get_instance();
            /*0x7b3262c*/ DebugShapes();
            /*0x7b32634*/ void BuildSphere(ref UnityEngine.Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv);
            /*0x7b32d1c*/ void BuildBox(ref UnityEngine.Mesh outputMesh, float length, float width, float height);
            /*0x7b33470*/ void BuildCone(ref UnityEngine.Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides);
            /*0x7b33d98*/ void BuildPyramid(ref UnityEngine.Mesh outputMesh, float width, float height, float depth);
            /*0x7b34088*/ void BuildShapes();
            /*0x7b341bc*/ void RebuildResources();
            /*0x7b342ac*/ UnityEngine.Mesh RequestSphereMesh();
            /*0x7b342c4*/ UnityEngine.Mesh BuildCustomSphereMesh(float radius, uint longSubdiv, uint latSubdiv);
            /*0x7b34358*/ UnityEngine.Mesh RequestBoxMesh();
            /*0x7b34370*/ UnityEngine.Mesh RequestConeMesh();
            /*0x7b34388*/ UnityEngine.Mesh RequestPyramidMesh();
        }

        class DebugUI
        {
            /*0x7b343a0*/ DebugUI();

            class Container : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IContainer
            {
                static string k_IDToken = "#";
                /*0x48*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;

                /*0x7b3450c*/ Container();
                /*0x7b34794*/ Container(string id);
                /*0x7b3459c*/ Container(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children);
                /*0x7b343a8*/ bool get_hideDisplayName();
                /*0x7b3441c*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x7b34424*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x7b3442c*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x7b34434*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x7b34850*/ void GenerateQueryPath();
                /*0x7b34a0c*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b34b3c*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b34ba4*/ int GetHashCode();
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

                /*0x7b2d290*/ Foldout();
                /*0x7b34fec*/ Foldout(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips);
                /*0x7b34d04*/ bool get_isReadOnly();
                /*0x7b34d0c*/ string[] get_columnLabels();
                /*0x7b2d314*/ void set_columnLabels(string[] value);
                /*0x7b34d14*/ string[] get_columnTooltips();
                /*0x7b34d1c*/ void set_columnTooltips(string[] value);
                /*0x7b34d40*/ System.Collections.Generic.List<UnityEngine.GUIContent> get_rowContents();
                /*0x7b350c8*/ bool GetValue();
                /*0x7b350d0*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x7b350f8*/ void SetValue(object value);
                /*0x7b3514c*/ object ValidateValue(object value);
                /*0x7b35154*/ void SetValue(bool value);

                struct ContextMenuItem
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ System.Action action;
                }
            }

            class HBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x7b35160*/ HBox();
            }

            class VBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x7b351b4*/ VBox();
            }

            class Table : UnityEngine.Rendering.DebugUI.Container
            {
                static /*0x0*/ UnityEngine.GUIStyle columnHeaderStyle;
                /*0x50*/ bool isReadOnly;
                /*0x58*/ bool[] m_Header;

                static /*0x7b354d4*/ Table();
                /*0x7b29518*/ Table();
                /*0x7b2a35c*/ void SetColumnVisibility(int index, bool visible);
                /*0x7b35448*/ bool GetColumnVisibility(int index);
                /*0x7b35208*/ bool[] get_VisibleColumns();
                /*0x7b35494*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b354b4*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);

                class Row : UnityEngine.Rendering.DebugUI.Foldout
                {
                    /*0x7b2a47c*/ Row();
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

                /*0x7b34848*/ Widget();
                /*0x7b35568*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x7b35570*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x7b35578*/ UnityEngine.Rendering.DebugUI.IContainer get_parent();
                /*0x7b35580*/ void set_parent(UnityEngine.Rendering.DebugUI.IContainer value);
                /*0x7b35588*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x7b35590*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x7b35598*/ string get_displayName();
                /*0x7b355a0*/ void set_displayName(string value);
                /*0x7b355a8*/ string get_tooltip();
                /*0x7b355b0*/ void set_tooltip(string value);
                /*0x7b355b8*/ string get_queryPath();
                /*0x7b355c0*/ void set_queryPath(string value);
                /*0x7b355c8*/ bool get_isEditorOnly();
                /*0x7b355d4*/ bool get_isRuntimeOnly();
                /*0x7b355e0*/ bool get_isInactiveInEditor();
                /*0x7b34ce4*/ bool get_isHidden();
                /*0x7b34908*/ void GenerateQueryPath();
                /*0x7b35650*/ int GetHashCode();
                /*0x7b2a3b8*/ void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value);

                struct NameAndTooltip
                {
                    /*0x10*/ string name;
                    /*0x18*/ string tooltip;
                }
            }

            interface IContainer
            {
                /*0x380b9e8*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x380b9e8*/ string get_displayName();
                /*0x380d83c*/ void set_displayName(string value);
                /*0x380b9e8*/ string get_queryPath();
            }

            interface IValueField
            {
                /*0x380b9e8*/ object GetValue();
                /*0x380d83c*/ void SetValue(object value);
                /*0x380bb68*/ object ValidateValue(object value);
            }

            class Button : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Action <action>k__BackingField;

                /*0x7b356ec*/ Button();
                /*0x7b356dc*/ System.Action get_action();
                /*0x7b356e4*/ void set_action(System.Action value);
            }

            class Value : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Func<object> <getter>k__BackingField;
                /*0x50*/ float refreshRate;
                /*0x58*/ string formatString;

                /*0x7b282cc*/ Value();
                /*0x7b356f4*/ System.Func<object> get_getter();
                /*0x7b356fc*/ void set_getter(System.Func<object> value);
                /*0x7b35704*/ object GetValue();
                /*0x7b35728*/ string FormatString(object value);
            }

            class ProgressBarValue : UnityEngine.Rendering.DebugUI.Value
            {
                /*0x60*/ float min;
                /*0x64*/ float max;

                static /*0x7b3586c*/ float <FormatString>g__Remap01|2_0(float v, float x0, float y0);
                /*0x7b2d348*/ ProgressBarValue();
                /*0x7b35794*/ string FormatString(object value);
            }

            class ValueTuple : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.Value[] values;
                /*0x50*/ int pinnedElementIndex;

                /*0x7b2d338*/ ValueTuple();
                /*0x7b3587c*/ int get_numElements();
                /*0x7b35898*/ float get_refreshRate();
            }

            class Field<T> : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x0*/ System.Func<T> <getter>k__BackingField;
                /*0x0*/ System.Action<T> <setter>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.Rendering.DebugUI.Field<T>, T> onValueChanged;

                /*0x380cb08*/ Field();
                /*0x380b9e8*/ System.Func<T> get_getter();
                /*0x380d83c*/ void set_getter(System.Func<T> value);
                /*0x380b9e8*/ System.Action<T> get_setter();
                /*0x380d83c*/ void set_setter(System.Action<T> value);
                /*0x380bb68*/ object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
                /*0x3907c14*/ T ValidateValue(T value);
                /*0x380b9e8*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x3907c14*/ T GetValue();
                /*0x380d83c*/ void SetValue(object value);
                /*0x3907c14*/ void SetValue(T value);
            }

            class BoolField : UnityEngine.Rendering.DebugUI.Field<bool>
            {
                /*0x7b358f8*/ BoolField();
            }

            class HistoryBoolField : UnityEngine.Rendering.DebugUI.BoolField
            {
                /*0x60*/ System.Func<bool> <historyGetter>k__BackingField;

                /*0x7b359a8*/ HistoryBoolField();
                /*0x7b35940*/ System.Func<bool> get_historyGetter();
                /*0x7b35948*/ void set_historyGetter(System.Func<bool> value);
                /*0x7b35950*/ int get_historyDepth();
                /*0x7b35968*/ bool GetHistoryValue(int historyIndex);
            }

            class IntField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ System.Func<int> min;
                /*0x68*/ System.Func<int> max;
                /*0x70*/ int incStep;
                /*0x74*/ int intStepMult;

                /*0x7b35a0c*/ IntField();
                /*0x7b359ac*/ int ValidateValue(int value);
            }

            class UIntField : UnityEngine.Rendering.DebugUI.Field<uint>
            {
                /*0x60*/ System.Func<uint> min;
                /*0x68*/ System.Func<uint> max;
                /*0x70*/ uint incStep;
                /*0x74*/ uint intStepMult;

                /*0x7b35ac0*/ UIntField();
                /*0x7b35a60*/ uint ValidateValue(uint value);
            }

            class FloatField : UnityEngine.Rendering.DebugUI.Field<float>
            {
                /*0x60*/ System.Func<float> min;
                /*0x68*/ System.Func<float> max;
                /*0x70*/ float incStep;
                /*0x74*/ float incStepMult;
                /*0x78*/ int decimals;

                /*0x7b35b74*/ FloatField();
                /*0x7b35b14*/ float ValidateValue(float value);
            }

            class EnumField<T> : UnityEngine.Rendering.DebugUI.Field<T>
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_NicifyRegEx;
                /*0x0*/ UnityEngine.GUIContent[] enumNames;
                /*0x0*/ int[] m_EnumValues;

                static /*0x38358cc*/ EnumField();
                /*0x380cb08*/ EnumField();
                /*0x380b9e8*/ int[] get_enumValues();
                /*0x380d83c*/ void set_enumValues(int[] value);
                /*0x380d83c*/ void AutoFillFromType(System.Type enumType);

                class <>c<T>
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__6_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x380b2f0*/ bool <AutoFillFromType>b__6_0(System.Reflection.FieldInfo fieldInfo);
                }
            }

            class EnumField : UnityEngine.Rendering.DebugUI.EnumField<int>
            {
                /*0x70*/ int[] quickSeparators;
                /*0x78*/ int[] m_Indexes;
                /*0x80*/ System.Func<int> <getIndex>k__BackingField;
                /*0x88*/ System.Action<int> <setIndex>k__BackingField;

                /*0x7b27fac*/ EnumField();
                /*0x7b35bd0*/ int[] get_indexes();
                /*0x7b35c5c*/ System.Func<int> get_getIndex();
                /*0x7b35c64*/ void set_getIndex(System.Func<int> value);
                /*0x7b35c6c*/ System.Action<int> get_setIndex();
                /*0x7b35c74*/ void set_setIndex(System.Action<int> value);
                /*0x7b35c7c*/ int get_currentIndex();
                /*0x7b35ca0*/ void set_currentIndex(int value);
                /*0x7b35cc4*/ void set_autoEnum(System.Type value);
                /*0x7b35d24*/ void InitQuickSeparators();
                /*0x7b35f48*/ void SetValue(int value);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.GUIContent, string> <>9__17_0;

                    static /*0x7b36098*/ <>c();
                    /*0x7b36100*/ <>c();
                    /*0x7b36108*/ string <InitQuickSeparators>b__17_0(UnityEngine.GUIContent x);
                }
            }

            class ObjectPopupField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> <getObjects>k__BackingField;

                /*0x7b28234*/ ObjectPopupField();
                /*0x7b36194*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> get_getObjects();
                /*0x7b3619c*/ void set_getObjects(System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> value);
            }

            class HistoryEnumField : UnityEngine.Rendering.DebugUI.EnumField
            {
                /*0x90*/ System.Func<int> <historyIndexGetter>k__BackingField;

                /*0x7b3620c*/ HistoryEnumField();
                /*0x7b361a4*/ System.Func<int> get_historyIndexGetter();
                /*0x7b361ac*/ void set_historyIndexGetter(System.Func<int> value);
                /*0x7b361b4*/ int get_historyDepth();
                /*0x7b361cc*/ int GetHistoryValue(int historyIndex);
            }

            class BitField : UnityEngine.Rendering.DebugUI.EnumField<System.Enum>
            {
                /*0x70*/ System.Type m_EnumType;

                /*0x7b36280*/ BitField();
                /*0x7b36210*/ System.Type get_enumType();
                /*0x7b36218*/ void set_enumType(System.Type value);
            }

            class MaskField : UnityEngine.Rendering.DebugUI.EnumField<uint>
            {
                /*0x7b367ec*/ MaskField();
                /*0x7b362ec*/ void Fill(string[] names);
                /*0x7b36710*/ void SetValue(uint value);
            }

            class ColorField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Color>
            {
                /*0x60*/ bool hdr;
                /*0x61*/ bool showAlpha;
                /*0x62*/ bool showPicker;
                /*0x64*/ float incStep;
                /*0x68*/ float incStepMult;
                /*0x6c*/ int decimals;

                /*0x7b368a8*/ ColorField();
                /*0x7b36858*/ UnityEngine.Color ValidateValue(UnityEngine.Color value);
            }

            class Vector2Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector2>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b3690c*/ Vector2Field();
            }

            class Vector3Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector3>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b36968*/ Vector3Field();
            }

            class Vector4Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector4>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x7b369c4*/ Vector4Field();
            }

            class ObjectField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Type type;

                /*0x7b2a3e8*/ ObjectField();
            }

            class ObjectListField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object[]>
            {
                /*0x60*/ System.Type type;

                /*0x7b36a20*/ ObjectListField();
            }

            class MessageBox : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.MessageBox.Style style;
                /*0x50*/ System.Func<string> messageCallback;

                /*0x7b36ad4*/ MessageBox();
                /*0x7b36ab4*/ string get_message();

                enum Style
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }

            class RuntimeDebugShadersMessageBox : UnityEngine.Rendering.DebugUI.MessageBox
            {
                /*0x7b36adc*/ RuntimeDebugShadersMessageBox();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.RuntimeDebugShadersMessageBox.<> <>9;
                    static /*0x8*/ System.Func<bool> <>9__0_0;

                    static /*0x7b36bfc*/ <>c();
                    /*0x7b36c64*/ <>c();
                    /*0x7b36c6c*/ bool <.ctor>b__0_0();
                }
            }

            class Panel : UnityEngine.Rendering.DebugUI.IContainer, System.IComparable<UnityEngine.Rendering.DebugUI.Panel>
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x18*/ string <displayName>k__BackingField;
                /*0x20*/ int <groupIndex>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;
                /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;

                /*0x7b30820*/ Panel();
                /*0x7b36d00*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x7b36d08*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x7b36d10*/ string get_displayName();
                /*0x7b36d18*/ void set_displayName(string value);
                /*0x7b36d20*/ int get_groupIndex();
                /*0x7b36d28*/ void set_groupIndex(int value);
                /*0x7b36d30*/ string get_queryPath();
                /*0x7b36d38*/ bool get_isEditorOnly();
                /*0x7b36d44*/ bool get_isRuntimeOnly();
                /*0x7b36d50*/ bool get_isInactiveInEditor();
                /*0x7b36dc0*/ bool get_editorForceUpdate();
                /*0x7b36dcc*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x7b36dd4*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x7b30a14*/ void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x7b30700*/ void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x7b36ddc*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b36e34*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x7b34a74*/ void SetDirty();
                /*0x7b36e8c*/ int GetHashCode();
                /*0x7b36f6c*/ int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Panel.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> <>9__29_0;

                    static /*0x7b36fa0*/ <>c();
                    /*0x7b37008*/ <>c();
                    /*0x7b37010*/ void <.ctor>b__29_0(UnityEngine.Rendering.DebugUI.Panel <p0>);
                }
            }
        }

        class DebugUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.Rendering.DebugUpdater s_Instance;
            /*0x20*/ UnityEngine.ScreenOrientation m_Orientation;
            /*0x24*/ bool m_RuntimeUiWasVisibleLastFrame;

            static /*0x7b37014*/ void RuntimeInit();
            static /*0x7b31cec*/ void SetEnabled(bool enabled);
            static /*0x7b37018*/ void EnableRuntime();
            static /*0x7b371a0*/ void DisableRuntime();
            static /*0x7b31fb4*/ void HandleInternalEventSystemComponents(bool uiEnabled);
            static /*0x7b37b68*/ System.Collections.IEnumerator RefreshRuntimeUINextFrame();
            /*0x7b37be8*/ DebugUpdater();
            /*0x7b372dc*/ void EnsureExactlyOneEventSystem();
            /*0x7b376f8*/ System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action);
            /*0x7b3778c*/ void CheckInputModuleExists();
            /*0x7b378b8*/ void AssignDefaultActions();
            /*0x7b37618*/ void CreateDebugEventSystem();
            /*0x7b374b8*/ void DestroyDebugEventSystem();
            /*0x7b37a10*/ void Update();

            class <DoAfterInputModuleUpdated>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Action action;

                /*0x7b37764*/ <DoAfterInputModuleUpdated>d__9(int <>1__state);
                /*0x7b37bf0*/ void System.IDisposable.Dispose();
                /*0x7b37bf4*/ bool MoveNext();
                /*0x7b37cf0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7b37cf8*/ void System.Collections.IEnumerator.Reset();
                /*0x7b37d30*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RefreshRuntimeUINextFrame>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x7b37bc0*/ <RefreshRuntimeUINextFrame>d__15(int <>1__state);
                /*0x7b37d38*/ void System.IDisposable.Dispose();
                /*0x7b37d3c*/ bool MoveNext();
                /*0x7b37ddc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7b37de4*/ void System.Collections.IEnumerator.Reset();
                /*0x7b37e1c*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x7b37e24*/ UnityEngine.Rendering.PerformanceBottleneck DetermineBottleneck(UnityEngine.Rendering.FrameTimeSample s);
            /*0x7b2b500*/ BottleneckHistory(int initialCapacity);
            /*0x7b2bbbc*/ void DiscardOldSamples(int historySize);
            /*0x7b2bc5c*/ void AddBottleneckFromAveragedSample(UnityEngine.Rendering.FrameTimeSample frameHistorySampleAverage);
            /*0x7b2bd28*/ void ComputeHistogram();
            /*0x7b2d37c*/ void Clear();
        }

        struct FrameTimeSample
        {
            /*0x10*/ float FramesPerSecond;
            /*0x14*/ float FullFrameTime;
            /*0x18*/ float MainThreadCPUFrameTime;
            /*0x1c*/ float MainThreadCPUPresentWaitTime;
            /*0x20*/ float RenderThreadCPUFrameTime;
            /*0x24*/ float GPUFrameTime;

            /*0x7b37ecc*/ FrameTimeSample(float initValue);
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

            static /*0x7b37fac*/ FrameTimeSampleHistory();
            static /*0x7b37edc*/ void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref UnityEngine.Rendering.FrameTimeSample aggregate, UnityEngine.Rendering.FrameTimeSample sample, System.Func<float, float, float> func);
            /*0x7b2b444*/ FrameTimeSampleHistory(int initialCapacity);
            /*0x7b2b844*/ void Add(UnityEngine.Rendering.FrameTimeSample sample);
            /*0x7b2b92c*/ void ComputeAggregateValues();
            /*0x7b2b7a4*/ void DiscardOldSamples(int sampleHistorySize);
            /*0x7b2d3d0*/ void Clear();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.FrameTimeSampleHistory.<> <>9;

                static /*0x7b38224*/ <>c();
                /*0x7b3828c*/ <>c();
                /*0x7b38294*/ float <.cctor>b__15_0(float value, float other);
                /*0x7b3829c*/ float <.cctor>b__15_1(float value, float other);
                /*0x7b382b0*/ float <.cctor>b__15_2(float value, float other);
                /*0x7b382bc*/ float <.cctor>b__15_3(float value, float other);
                /*0x7b382d0*/ float <.cctor>b__15_4(float value, float other);
                /*0x7b382e0*/ float <.cctor>b__15_5(float value, float other);
            }
        }

        interface IDebugDisplaySettings
        {
            /*0x380cb08*/ void Reset();
            /*0x380d83c*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x7b382f4*/ UnityEngine.Rendering.IDebugDisplaySettingsData Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
        }

        interface IDebugDisplaySettingsData : UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x380b9e8*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();
        }

        interface IDebugDisplaySettingsPanel
        {
            /*0x380b9e8*/ string get_PanelName();
            /*0x380b9e8*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x380b6a0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
        }

        interface IDebugDisplaySettingsPanelDisposable : UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
        }

        interface IDebugDisplaySettingsQuery
        {
            /*0x380b128*/ bool get_AreAnySettingsActive();
            /*0x7b382fc*/ bool get_IsPostProcessingAllowed();
            /*0x7b38304*/ bool get_IsLightingActive();
            /*0x7b3830c*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
        }

        interface IVolumeDebugSettings
        {
            /*0x380b6a0*/ int get_selectedComponent();
            /*0x380cffc*/ void set_selectedComponent(int value);
            /*0x380b9e8*/ UnityEngine.Camera get_selectedCamera();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x380b6a0*/ int get_selectedCameraIndex();
            /*0x380cffc*/ void set_selectedCameraIndex(int value);
            /*0x380b9e8*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x380cad0*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x380b9e8*/ System.Type get_selectedComponentType();
            /*0x380d83c*/ void set_selectedComponentType(System.Type value);
            /*0x380b9e8*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x380b2f0*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);
            /*0x380b2f0*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
        }

        interface IVolumeDebugSettings2 : UnityEngine.Rendering.IVolumeDebugSettings
        {
            /*0x380b9e8*/ System.Type get_targetRenderPipeline();
            /*0x380b9e8*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
        }

        class MousePositionDebug
        {
            static /*0x0*/ UnityEngine.Rendering.MousePositionDebug s_Instance;

            static /*0x7b38314*/ UnityEngine.Rendering.MousePositionDebug get_instance();
            /*0x7b3839c*/ MousePositionDebug();
            /*0x7b383a4*/ void Build();
            /*0x7b383a8*/ void Cleanup();
            /*0x7b383ac*/ UnityEngine.Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
            /*0x7b383b0*/ UnityEngine.Vector2 GetInputMousePosition();
            /*0x7b3843c*/ UnityEngine.Vector2 GetMouseClickPosition(float ScreenHeight);
        }

        class TProfilingSampler<TEnum> : UnityEngine.Rendering.ProfilingSampler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<TEnum, UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;

            static /*0x38358cc*/ TProfilingSampler();
            /*0x380d83c*/ TProfilingSampler(string name);
        }

        class ProfilingSampler
        {
            /*0x10*/ UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;
            /*0x18*/ UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;
            /*0x20*/ string <name>k__BackingField;
            /*0x28*/ UnityEngine.Profiling.Recorder m_Recorder;
            /*0x30*/ UnityEngine.Profiling.Recorder m_InlineRecorder;

            static /*0x3907c14*/ UnityEngine.Rendering.ProfilingSampler Get<TEnum>(TEnum marker);
            /*0x7b3847c*/ ProfilingSampler(string name);
            /*0x7b388c8*/ ProfilingSampler();
            /*0x7b385c8*/ void Begin(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b3862c*/ void End(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b38690*/ bool IsValid();
            /*0x7b386b0*/ UnityEngine.Profiling.CustomSampler get_sampler();
            /*0x7b386b8*/ void set_sampler(UnityEngine.Profiling.CustomSampler value);
            /*0x7b386c0*/ UnityEngine.Profiling.CustomSampler get_inlineSampler();
            /*0x7b386c8*/ void set_inlineSampler(UnityEngine.Profiling.CustomSampler value);
            /*0x7b386d0*/ string get_name();
            /*0x7b386d8*/ void set_name(string value);
            /*0x7b386e0*/ void set_enableRecording(bool value);
            /*0x7b38724*/ float get_gpuElapsedTime();
            /*0x7b38770*/ int get_gpuSampleCount();
            /*0x7b387b0*/ float get_cpuElapsedTime();
            /*0x7b387fc*/ int get_cpuSampleCount();
            /*0x7b3883c*/ float get_inlineCpuElapsedTime();
            /*0x7b38888*/ int get_inlineCpuSampleCount();
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x7b388d0*/ ProfilingScope(UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b388d4*/ ProfilingScope(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b388d8*/ ProfilingScope(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x7b388dc*/ void Dispose();
        }

        struct ProfilingSample : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
            /*0x18*/ string m_Name;
            /*0x20*/ bool m_Disposed;
            /*0x28*/ UnityEngine.Profiling.CustomSampler m_Sampler;

            /*0x7b388e0*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string name, UnityEngine.Profiling.CustomSampler sampler);
            /*0x7b38990*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object arg);
            /*0x7b389cc*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object[] args);
            /*0x7b38a08*/ void Dispose();
            /*0x7b38a10*/ void Dispose(bool disposing);
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

            static /*0x7b3a154*/ ShaderDebugPrintManager();
            static /*0x7b38dac*/ UnityEngine.Rendering.ShaderDebugPrintManager get_instance();
            /*0x7b38ac0*/ ShaderDebugPrintManager();
            /*0x7b38a9c*/ int DebugValueTypeToElemSize(UnityEngine.Rendering.ShaderDebugPrintManager.DebugValueType type);
            /*0x7b38e04*/ void SetShaderDebugPrintInputConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ShaderDebugPrintInput input);
            /*0x7b38ecc*/ void SetShaderDebugPrintBindings(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b39008*/ void ClearShaderDebugPrintBuffer();
            /*0x7b390f4*/ void BufferReadComplete(UnityEngine.Rendering.AsyncGPUReadbackRequest request);
            /*0x7b39f6c*/ void EndFrame();
            /*0x7b3a02c*/ void PrintImmediate();
            /*0x7b3a0ec*/ string get_outputLine();
            /*0x7b3a0f4*/ void set_outputAction(System.Action<string> value);
            /*0x7b3a0fc*/ void DefaultOutput(string line);

            class Profiling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler BufferReadComplete;

                static /*0x7b3a248*/ Profiling();
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

            /*0x7b3a2e0*/ UnityEngine.Vector2 get_pos();
            /*0x7b3a2e8*/ void set_pos(UnityEngine.Vector2 value);
            /*0x7b3a2f0*/ bool get_leftDown();
            /*0x7b3a2f8*/ void set_leftDown(bool value);
            /*0x7b3a304*/ bool get_rightDown();
            /*0x7b3a30c*/ void set_rightDown(bool value);
            /*0x7b3a318*/ bool get_middleDown();
            /*0x7b3a320*/ void set_middleDown(bool value);
            /*0x7b3a32c*/ string String();
        }

        class ShaderDebugPrintInputProducer
        {
            static /*0x7b3a548*/ UnityEngine.Rendering.ShaderDebugPrintInput Get();
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

            static /*0x38358cc*/ VolumeDebugSettings();
            static /*0x382dee4*/ System.Collections.Generic.List<System.Type> get_componentTypes();
            static /*0x382eaf0*/ string ComponentDisplayName(System.Type component);
            static /*0x382dee4*/ System.Collections.Generic.List<T> get_additionalCameraDatas();
            static /*0x3837da0*/ void set_additionalCameraDatas(System.Collections.Generic.List<T> value);
            static /*0x3907c14*/ void RegisterCamera(T additionalCamera);
            static /*0x3907c14*/ void UnRegisterCamera(T additionalCamera);
            /*0x380cb08*/ VolumeDebugSettings();
            /*0x380b6a0*/ int get_selectedComponent();
            /*0x380cffc*/ void set_selectedComponent(int value);
            /*0x380b9e8*/ UnityEngine.Camera get_selectedCamera();
            /*0x380b6a0*/ int get_selectedCameraIndex();
            /*0x380cffc*/ void set_selectedCameraIndex(int value);
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x380b9e8*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x380cad0*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x380b9e8*/ System.Type get_selectedComponentType();
            /*0x380d83c*/ void set_selectedComponentType(System.Type value);
            /*0x380b9e8*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
            /*0x380b9e8*/ System.Type get_targetRenderPipeline();
            /*0x380bcbc*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.VolumeComponent component, System.Reflection.FieldInfo field);
            /*0x380bb68*/ UnityEngine.Rendering.VolumeParameter GetParameter(System.Reflection.FieldInfo field);
            /*0x380bcbc*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.Volume volume, System.Reflection.FieldInfo field);
            /*0x380c39c*/ float ComputeWeight(UnityEngine.Rendering.Volume volume, UnityEngine.Vector3 triggerPos);
            /*0x380b9e8*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x380b9e8*/ UnityEngine.Rendering.VolumeParameter[,] GetStates();
            /*0x380b2f0*/ bool ChangedStates(UnityEngine.Rendering.VolumeParameter[,] newStates);
            /*0x380b2f0*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
            /*0x380b2f0*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeDebugSettings.<>c<T> <>9;
                static /*0x0*/ System.Func<UnityEngine.Rendering.Volume, bool> <>9__34_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__36_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_1;
                static /*0x0*/ System.Func<System.Type, string> <>9__43_2;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380b2f0*/ bool <GetVolumes>b__34_0(UnityEngine.Rendering.Volume v);
                /*0x380b2f0*/ bool <GetStates>b__36_0(System.Reflection.FieldInfo t);
                /*0x380b2f0*/ bool <get_componentTypes>b__43_0(System.Type t);
                /*0x380b2f0*/ bool <get_componentTypes>b__43_1(System.Type t);
                /*0x380bb68*/ string <get_componentTypes>b__43_2(System.Type t);
            }

            class <>c__DisplayClass22_0<T>
            {
                /*0x0*/ System.Type value;

                /*0x380cb08*/ <>c__DisplayClass22_0();
                bool <set_selectedComponentType>b__0(System.ValueTuple<string, System.Type> t);
            }
        }

        interface IShaderVariantSettings
        {
            /*0x380b6a0*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x380cffc*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x380b128*/ bool get_exportShaderVariants();
            /*0x380cdf0*/ void set_exportShaderVariants(bool value);
            /*0x7b3a648*/ bool get_stripDebugVariants();
            /*0x7b3a650*/ void set_stripDebugVariants(bool value);
        }

        class ProbeTouchupVolume : UnityEngine.Rendering.ProbeAdjustmentVolume
        {
            /*0x7b3a654*/ ProbeTouchupVolume();
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

            static /*0x7b3dbe0*/ VolumeManager();
            static /*0x7b27d20*/ UnityEngine.Rendering.VolumeManager get_instance();
            static /*0x7b3dbd8*/ bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera);
            static /*0x7b3ccb4*/ void <EvaluateVolumeDefaultState>g__ApplyDefaultProfile|58_0(UnityEngine.Rendering.VolumeProfile profile, ref UnityEngine.Rendering.VolumeManager.<> );
            /*0x7b3b698*/ VolumeManager();
            /*0x7b3a65c*/ void Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b3a930*/ void Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b3ac04*/ UnityEngine.Rendering.VolumeStack get_stack();
            /*0x7b3ac0c*/ void set_stack(UnityEngine.Rendering.VolumeStack value);
            /*0x7b3ac14*/ System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes();
            /*0x7b27d98*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> GetVolumeComponentsForDisplay(System.Type currentPipelineAssetType);
            /*0x7b3b180*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> BuildVolumeComponentDisplayList(System.Type[] types);
            /*0x7b3b53c*/ System.Type[] get_baseComponentTypeArray();
            /*0x7b3b544*/ void set_baseComponentTypeArray(System.Type[] value);
            /*0x7b3b54c*/ UnityEngine.Rendering.VolumeProfile get_globalDefaultProfile();
            /*0x7b3b554*/ void set_globalDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7b3b55c*/ UnityEngine.Rendering.VolumeProfile get_qualityDefaultProfile();
            /*0x7b3b564*/ void set_qualityDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7b3b56c*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> get_customDefaultProfiles();
            /*0x7b3b574*/ void set_customDefaultProfiles(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> value);
            /*0x7b3b57c*/ UnityEngine.Rendering.VolumeComponent GetVolumeComponentDefaultState(System.Type volumeComponentType);
            /*0x7b3b7b0*/ bool get_isInitialized();
            /*0x7b3b7b8*/ void set_isInitialized(bool value);
            /*0x7b3b7c4*/ void Initialize(UnityEngine.Rendering.VolumeProfile globalDefaultVolumeProfile, UnityEngine.Rendering.VolumeProfile qualityDefaultVolumeProfile);
            /*0x7b3c2e0*/ void Deinitialize();
            /*0x7b3c530*/ void SetGlobalDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b3c54c*/ void SetQualityDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b3c568*/ void SetCustomDefaultProfiles(System.Collections.Generic.List<UnityEngine.Rendering.VolumeProfile> profiles);
            /*0x7b3c704*/ void OnVolumeProfileChanged(UnityEngine.Rendering.VolumeProfile profile);
            /*0x7b3c7e8*/ void OnVolumeComponentChanged(UnityEngine.Rendering.VolumeComponent component);
            /*0x7b3c1f8*/ UnityEngine.Rendering.VolumeStack CreateStack();
            /*0x7b3ca94*/ void ResetMainStack();
            /*0x7b3c4c8*/ void DestroyStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b3caa0*/ bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(System.Type t, System.Type pipelineAssetType);
            /*0x7b3ac1c*/ void LoadBaseTypes(System.Type pipelineAssetType);
            /*0x7b3b89c*/ void InitializeVolumeComponents();
            /*0x7b3b964*/ void EvaluateVolumeDefaultState();
            /*0x7b3a8e0*/ void Register(UnityEngine.Rendering.Volume volume);
            /*0x7b3abb4*/ void Unregister(UnityEngine.Rendering.Volume volume);
            /*0x3907c14*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
            /*0x7b3cea0*/ void SetLayerDirty(int layer);
            /*0x7b3cebc*/ void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer);
            /*0x7b3ced8*/ void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, float interpFactor);
            /*0x7b3d008*/ void ReplaceData(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b3d1f4*/ void CheckDefaultVolumeState();
            /*0x7b3d284*/ void CheckStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b3d47c*/ bool CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack);
            /*0x7b3d4cc*/ void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x7b3d4e0*/ void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x7b3da9c*/ UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask);
            /*0x7b3da7c*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeManager.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<string, System.Type>, string> <>9__16_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.VolumeProfile> <>9__49_0;
                static /*0x18*/ System.Predicate<UnityEngine.Rendering.Volume> <>9__71_0;

                static /*0x7b52874*/ <>c();
                /*0x7b528dc*/ <>c();
                /*0x7b528e4*/ string <BuildVolumeComponentDisplayList>b__16_0(System.ValueTuple<string, System.Type> i);
                /*0x7b528ec*/ bool <SetCustomDefaultProfiles>b__49_0(UnityEngine.Rendering.VolumeProfile x);
                /*0x7b52948*/ bool <GetVolumes>b__71_0(UnityEngine.Rendering.Volume v);
                /*0x7b529a4*/ UnityEngine.Rendering.VolumeManager <.cctor>b__74_0();
            }

            struct <>c__DisplayClass58_0
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentsDefaultStateList;
            }

            class <>c__DisplayClass58_1
            {
                /*0x10*/ UnityEngine.Rendering.VolumeComponent profileComponent;

                /*0x7b529f8*/ <>c__DisplayClass58_1();
                /*0x7b52a00*/ bool <EvaluateVolumeDefaultState>b__1(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class CoreRPHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x7b52a70*/ CoreRPHelpURLAttribute(string pageName, string packageName);
            /*0x7b52c6c*/ CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName);
        }

        class CurrentPipelineHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x28*/ string <pageName>k__BackingField;

            /*0x7b52c98*/ CurrentPipelineHelpURLAttribute(string pageName);
            /*0x7b52c90*/ string get_pageName();
            /*0x7b52ccc*/ string get_URL();
        }

        class DocumentationInfo
        {
            static string fallbackVersion = "13.1";
            static string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html#{3}";

            static /*0x7b52ce4*/ string get_version();
            static /*0x7b52d24*/ string GetPackageLink(string packageName, string packageVersion, string pageName);
            static /*0x7b52ea4*/ string GetPageLink(string packageName, string pageName);
            static /*0x7b52adc*/ string GetPageLink(string packageName, string pageName, string pageHash);
            /*0x7b5304c*/ DocumentationInfo();
        }

        class DocumentationUtils
        {
            static /*0x3907c14*/ string GetHelpURL<TEnum>(TEnum mask);
            static /*0x7b53054*/ bool TryGetHelpURL(System.Type type, ref string url);
        }

        interface IProbeVolumeEnabledRenderPipeline
        {
            /*0x380b128*/ bool get_supportProbeVolume();
            /*0x380b6a0*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
            /*0x380b9e8*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
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

            /*0x7b5314c*/ ProbeAdjustmentVolume();
            /*0x7b530e8*/ void Awake();
            /*0x7b53120*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7b53138*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

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

            static /*0x7b53e88*/ bool BrickOverlapEntry(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, UnityEngine.Vector3Int entryMin, UnityEngine.Vector3Int entryMax);
            static /*0x7b53ed4*/ int LocationToIndex(int x, int y, int z, UnityEngine.Vector3Int sizeOfValid);
            /*0x7b53284*/ ProbeBrickIndex(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x7b53214*/ int get_estimatedVMemCost();
            /*0x7b5321c*/ void set_estimatedVMemCost(int value);
            /*0x7b53224*/ UnityEngine.ComputeBuffer GetDebugFragmentationBuffer();
            /*0x7b5322c*/ float get_fragmentationRate();
            /*0x7b53234*/ void set_fragmentationRate(float value);
            /*0x7b5323c*/ int SizeOfPhysicalIndexFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x7b53544*/ int GetRemainingChunkCount();
            /*0x7b5354c*/ void UploadIndexData();
            /*0x7b535c4*/ void UpdateDebugData();
            /*0x7b534ac*/ void Clear();
            /*0x7b5375c*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b53848*/ void Cleanup();
            /*0x7b538fc*/ void ComputeFragmentationRate();
            /*0x7b53964*/ int MergeIndex(int index, int size);
            /*0x7b53970*/ int GetNumberOfChunks(int brickCount);
            /*0x7b539ec*/ bool FindSlotsForEntries(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo);
            /*0x7b53d54*/ bool ReserveChunks(UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog);
            /*0x7b53ee4*/ void MarkBrickInPhysicalBuffer(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo entry, UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx);
            /*0x7b54288*/ void AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight);
            /*0x7b5463c*/ void RemoveBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);

            struct Brick : System.IEquatable<UnityEngine.Rendering.ProbeBrickIndex.Brick>
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int subdivisionLevel;

                /*0x7b54700*/ Brick(UnityEngine.Vector3Int position, int subdivisionLevel);
                /*0x7b5470c*/ bool Equals(UnityEngine.Rendering.ProbeBrickIndex.Brick other);
                /*0x7b54758*/ bool IntersectArea(UnityEngine.Bounds boundInBricksToCheck);
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

                /*0x7b548f4*/ int GetNumberOfChunks();
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

            static /*0x7b57828*/ ProbeBrickPool();
            static /*0x7b5494c*/ int DivRoundUp(int x, int y);
            static /*0x7b5496c*/ void Initialize();
            static /*0x7b55a6c*/ int GetChunkSizeInBrickCount();
            static /*0x7b55a74*/ int GetChunkSizeInProbeCount();
            static /*0x7b560dc*/ int GetChunkCount(int brickCount);
            static /*0x7b57410*/ UnityEngine.Vector3Int ProbeCountToDataLocSize(int numProbes);
            static /*0x7b5748c*/ int EstimateMemoryCost(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x7b574b4*/ int EstimateMemoryCostForBlending(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            static /*0x7b575f4*/ UnityEngine.Texture CreateDataTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes);
            static /*0x7b550b4*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, ref int allocatedBytes);
            static /*0x7b54f6c*/ void DerivePoolSizeFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, ref int width, ref int height, ref int depth);
            /*0x7b54df8*/ ProbeBrickPool(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool allocateValidityData, bool allocateRenderingLayerData, bool allocateSkyOcclusion, bool allocateSkyShadingData, bool allocateProbeOcclusionData);
            /*0x7b5495c*/ int get_estimatedVMemCost();
            /*0x7b54964*/ void set_estimatedVMemCost(int value);
            /*0x7b54dd8*/ UnityEngine.Texture GetValidityTexture();
            /*0x7b54de0*/ UnityEngine.Texture GetSkyOcclusionTexture();
            /*0x7b54de8*/ UnityEngine.Texture GetSkyShadingDirectionIndicesTexture();
            /*0x7b54df0*/ UnityEngine.Texture GetProbeOcclusionTexture();
            /*0x7b54f80*/ void AllocatePool(int width, int height, int depth);
            /*0x7b5576c*/ int GetRemainingChunkCount();
            /*0x7b55774*/ void EnsureTextureValidity();
            /*0x7b559d8*/ bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion);
            /*0x7b55a7c*/ int GetPoolWidth();
            /*0x7b55a84*/ int GetPoolHeight();
            /*0x7b55a8c*/ UnityEngine.Vector3Int GetPoolDimensions();
            /*0x7b55a98*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b56080*/ void Clear();
            /*0x7b560f4*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog);
            /*0x7b56364*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x7b564ec*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            /*0x7b5698c*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, bool updateSharedData, UnityEngine.Texture validityTexture, UnityEngine.Rendering.ProbeVolumeSHBands bands, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x7b5727c*/ void UpdateValidity(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex);
            /*0x7b57820*/ void Cleanup();

            struct BrickChunkAlloc
            {
                /*0x10*/ int x;
                /*0x14*/ int y;
                /*0x18*/ int z;

                /*0x7b54628*/ int flattenIndex(int sx, int sy);
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

                /*0x7b5580c*/ void Cleanup();
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

            static /*0x7b58de4*/ ProbeBrickBlendingPool();
            static /*0x7b57ac0*/ void Initialize();
            /*0x7b57d94*/ ProbeBrickBlendingPool(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool probeOcclusion);
            /*0x7b57c30*/ bool get_isAllocated();
            /*0x7b57c40*/ int get_estimatedVMemCost();
            /*0x7b57d40*/ int GetPoolWidth();
            /*0x7b57d5c*/ int GetPoolHeight();
            /*0x7b57d78*/ int GetPoolDepth();
            /*0x7b57dd0*/ void AllocateResourcesIfNeeded();
            /*0x7b57f38*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state);
            /*0x7b57fc8*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state, UnityEngine.Texture validityTexture, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x7b580b8*/ void PerformBlending(UnityEngine.Rendering.CommandBuffer cmd, float factor, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x7b58b90*/ void BlendChunks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x7b58cb0*/ void Clear();
            /*0x7b58cc0*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations);
            /*0x7b58d18*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x7b58d7c*/ void EnsureTextureValidity();
            /*0x7b58dac*/ void Cleanup();
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

            /*0x7b59204*/ ProbeGlobalIndirection(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, int cellSizeInMinBricks);
            /*0x7b59168*/ int get_estimatedVMemCost();
            /*0x7b59170*/ void set_estimatedVMemCost(int value);
            /*0x7b59178*/ void GetMinMaxEntry(ref UnityEngine.Vector3Int minEntry, ref UnityEngine.Vector3Int maxEntry);
            /*0x7b5919c*/ UnityEngine.Vector3Int GetGlobalIndirectionDimension();
            /*0x7b591ac*/ UnityEngine.Vector3Int GetGlobalIndirectionMinEntry();
            /*0x7b591bc*/ int get_entrySizeInBricks();
            /*0x7b591d0*/ int get_entriesPerCellDimension();
            /*0x7b591f0*/ int GetFlatIndex(UnityEngine.Vector3Int normalizedPos);
            /*0x7b593f8*/ int GetFlatIdxForEntry(UnityEngine.Vector3Int entryPosition);
            /*0x7b59424*/ int[] GetFlatIndicesForCell(UnityEngine.Vector3Int cellPosition);
            /*0x7b59560*/ void UpdateCell(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);
            /*0x7b59910*/ void MarkEntriesAsUnloaded(int[] entriesFlatIndices);
            /*0x7b59998*/ void PushComputeData();
            /*0x7b599c4*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x7b599fc*/ void Cleanup();

            struct IndexMetaData
            {
                static /*0x0*/ uint[] s_PackedValues;
                /*0x10*/ UnityEngine.Vector3Int minLocalIdx;
                /*0x1c*/ UnityEngine.Vector3Int maxLocalIdxPlusOne;
                /*0x28*/ int firstChunkIndex;
                /*0x2c*/ int minSubdiv;

                static /*0x7b59a68*/ IndexMetaData();
                /*0x7b597e4*/ void Pack(ref uint[] vals);
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

            static /*0x7b5150c*/ ProbeReferenceVolume();
            static /*0x7b3f4d8*/ string GetSceneGUID(UnityEngine.SceneManagement.Scene scene);
            static /*0x7b40534*/ UnityEngine.Rendering.ProbeReferenceVolume get_instance();
            static /*0x7b42854*/ int GetNumberOfBricksAtSubdiv(UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo);
            static /*0x7b42824*/ int CellSize(int subdivisionLevel);
            static /*0x7b4c3e8*/ void UpdateDebugFromSelection(ref UnityEngine.Vector4[] _AdjustmentVolumeBounds, ref int _AdjustmentVolumeCount);
            static /*0x7b4db18*/ void ComputeCellStreamingScore(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            static /*0x7b505e4*/ int BlendingComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            static /*0x7b50634*/ int DefragComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            /*0x7b47cd0*/ ProbeReferenceVolume();
            /*0x7b3ddf8*/ void BindAPVRuntimeResources(UnityEngine.Rendering.CommandBuffer cmdBuffer, bool isProbeVolumeEnabled);
            /*0x7b3ea3c*/ bool UpdateShaderVariablesProbeVolumes(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumesOptions probeVolumeOptions, int taaFrameIndex, bool supportRenderingLayers);
            /*0x7b3f0a4*/ UnityEngine.Bounds get_globalBounds();
            /*0x7b3f0b8*/ void set_globalBounds(UnityEngine.Bounds value);
            /*0x7b3f0cc*/ bool get_isInitialized();
            /*0x7b3f0d4*/ bool get_enabledBySRP();
            /*0x7b3f0dc*/ bool get_vertexSampling();
            /*0x7b3f0e4*/ bool get_hasUnloadedCells();
            /*0x7b3f134*/ bool get_supportLightingScenarios();
            /*0x7b3f13c*/ bool get_supportScenarioBlending();
            /*0x7b3f144*/ bool get_gpuStreamingEnabled();
            /*0x7b3f14c*/ bool get_diskStreamingEnabled();
            /*0x7b3f16c*/ bool get_probeOcclusion();
            /*0x7b3ecac*/ bool get_skyOcclusion();
            /*0x7b3ed30*/ bool get_skyOcclusionShadingDirection();
            /*0x7b3f1f0*/ bool get_useRenderingLayers();
            /*0x7b3f214*/ UnityEngine.Rendering.ProbeVolumeSHBands get_shBands();
            /*0x7b3f21c*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_currentBakingSet();
            /*0x7b3f224*/ string get_lightingScenario();
            /*0x7b3f2a0*/ void set_lightingScenario(string value);
            /*0x7b3f348*/ string get_otherScenario();
            /*0x7b3f3c4*/ float get_scenarioBlendingFactor();
            /*0x7b3f43c*/ void set_scenarioBlendingFactor(float value);
            /*0x7b3f2a8*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x7b3f530*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x7b3f5dc*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget();
            /*0x7b3f5e4*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> get_perSceneDataList();
            /*0x7b3f5ec*/ void set_perSceneDataList(System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> value);
            /*0x7b3f5fc*/ void RegisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b3f6f4*/ void SetActiveScene(UnityEngine.SceneManagement.Scene scene);
            /*0x7b3f98c*/ void SetActiveBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b3fd10*/ void SetBakingSetAsCurrent(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b403cc*/ void RegisterBakingSet(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b3fc44*/ void UnloadBakingSet();
            /*0x7b40480*/ void UnregisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x7b3f788*/ bool TryGetPerSceneData(string sceneGUID, ref UnityEngine.Rendering.ProbeVolumePerSceneData perSceneData);
            /*0x7b40508*/ float get_indexFragmentationRate();
            /*0x7b4058c*/ void Initialize(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x7b40b4c*/ void SetEnableStateFromSRP(bool srpEnablesPV);
            /*0x7b40b58*/ void SetVertexSamplingEnabled(bool value);
            /*0x7b40b64*/ void ForceSHBand(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x7b40f44*/ void ForceNoDiskStreaming(bool state);
            /*0x7b40f50*/ void Cleanup();
            /*0x7b413cc*/ int GetVideoMemoryCost();
            /*0x7b41448*/ void RemoveCell(int cellIndex);
            /*0x7b41594*/ void UnloadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b416f8*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b419d0*/ void UnloadAllCells();
            /*0x7b41aac*/ void UnloadAllBlendingCells();
            /*0x7b41b88*/ void AddCell(int cellIndex);
            /*0x7b41db4*/ bool LoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, bool ignoreErrorLog);
            /*0x7b42cdc*/ void LoadAllCells();
            /*0x7b42e18*/ void ComputeCellGlobalInfo();
            /*0x7b43028*/ void AddPendingSceneLoading(string sceneGUID, UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x7b43480*/ void AddPendingSceneRemoval(string sceneGUID);
            /*0x7b435bc*/ void RemovePendingScene(string sceneGUID, System.Collections.Generic.List<int> cellList);
            /*0x7b43770*/ void PerformPendingIndexChangeAndInit();
            /*0x7b40390*/ void SetSubdivisionDimensions(float minBrickSize, int maxSubdiv, UnityEngine.Vector3 offset);
            /*0x7b43af4*/ bool LoadCells(System.Collections.Generic.List<int> cellIndices);
            /*0x7b43bb8*/ void PerformPendingLoading();
            /*0x7b43fc0*/ void PerformPendingDeletion();
            /*0x7b42440*/ void ComputeEntryMinMax(ref UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo, System.ReadOnlySpan<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks);
            /*0x7b40460*/ void PerformPendingOperations();
            /*0x7b437a4*/ void InitializeGlobalIndirection();
            /*0x7b3fe24*/ void InitProbeReferenceVolume();
            /*0x7b3e8e0*/ UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources();
            /*0x7b43a18*/ void SetMaxSubdivision(int maxSubdivision);
            /*0x7b4858c*/ float BrickSize(int subdivisionLevel);
            /*0x7b48624*/ float MinBrickSize();
            /*0x7b4862c*/ float MaxBrickSize();
            /*0x7b48638*/ UnityEngine.Vector3 ProbeOffset();
            /*0x7b48644*/ int GetMaxSubdivision();
            /*0x7b4864c*/ int GetMaxSubdivision(float multiplier);
            /*0x7b486cc*/ float GetDistanceBetweenProbes(int subdivisionLevel);
            /*0x7b486e4*/ float MinDistanceBetweenProbes();
            /*0x7b48700*/ int GetGlobalIndirectionEntryMaxSubdiv();
            /*0x7b4280c*/ int GetEntrySubdivLevel();
            /*0x7b48708*/ float GetEntrySize();
            /*0x7b3ec5c*/ bool DataHasBeenLoaded();
            /*0x7b48720*/ void Clear();
            /*0x7b48838*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, UnityEngine.Rendering.ProbeBrickPool.DataLocation dataLoc);
            /*0x3907c14*/ void UpdateDataLocationTexture<T>(UnityEngine.Texture output, Unity.Collections.NativeArray<T> input);
            /*0x7b489c4*/ void UpdateValidityTextureWithoutMask(UnityEngine.Texture output, Unity.Collections.NativeArray<byte> input);
            /*0x7b48b58*/ void UpdatePool(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionL0L1Data, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex, int poolIndex);
            /*0x7b4909c*/ void UpdatePool(UnityEngine.Rendering.CommandBuffer cmd, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex);
            /*0x7b492b8*/ void UpdateSharedData(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionData, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex);
            /*0x7b49598*/ bool AddBlendingBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b42390*/ bool ReservePoolChunks(int brickCount, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, bool ignoreErrorLog);
            /*0x7b42b74*/ void ReleasePoolChunks(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList);
            /*0x7b49e14*/ void UpdatePoolAndIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b4291c*/ bool AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b49cf8*/ void UpdateCellIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b41828*/ void ReleaseBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b3edb4*/ void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumeShadingParameters parameters);
            /*0x7b40cc8*/ void DeinitProbeReferenceVolume();
            /*0x7b41074*/ void CleanupLoadedData();
            /*0x7b4a2d4*/ UnityEngine.Rendering.ProbeVolumeDebug get_probeVolumeDebug();
            /*0x7b4a2dc*/ UnityEngine.Color[] get_subdivisionDebugColors();
            /*0x7b4a2e4*/ UnityEngine.Mesh get_debugMesh();
            /*0x7b4a458*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x7b4a464*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options, UnityEngine.Texture exposureTexture);
            /*0x7b4b664*/ bool IsProbeSamplingDebugEnabled();
            /*0x7b4b6d0*/ bool GetProbeSamplingDebugResources(UnityEngine.Camera camera, ref UnityEngine.GraphicsBuffer resultBuffer, ref UnityEngine.Vector2 coords);
            /*0x7b4b7fc*/ bool TryCreateDebugRenderData();
            /*0x7b40a64*/ void InitializeDebug();
            /*0x7b41078*/ void CleanupDebug();
            /*0x3907c14*/ void DebugCellIndexChanged<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x7b44244*/ void RegisterDebug();
            /*0x7b44148*/ void UnregisterDebug(bool destroyPanel);
            /*0x7b4bdec*/ void RenderFragmentationOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer, UnityEngine.Rendering.DebugOverlay debugOverlay);
            /*0x7b4c100*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes);
            /*0x7b4c2a8*/ UnityEngine.Bounds GetCellBounds(UnityEngine.Vector3 cellPosition);
            /*0x7b4c414*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Vector4[] adjustmentVolumeBounds, int adjustmentVolumeCount);
            /*0x7b4a568*/ void DrawProbeDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x7b4d4c0*/ void ResetDebugViewToMaxSubdiv();
            /*0x7b41934*/ void ClearDebugData();
            /*0x7b4c6dc*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b4d5f4*/ void OnClearLightingdata();
            /*0x7b4d5f8*/ void EnableMaxCellStreaming(bool value);
            /*0x7b4d604*/ void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
            /*0x7b4d620*/ bool get_loadMaxCellsPerFrame();
            /*0x7b4d628*/ void set_loadMaxCellsPerFrame(bool value);
            /*0x7b4d634*/ int get_numberOfCellsLoadedPerFrame();
            /*0x7b4d69c*/ int get_numberOfCellsBlendedPerFrame();
            /*0x7b4d6a4*/ void set_numberOfCellsBlendedPerFrame(int value);
            /*0x7b4d6b4*/ float get_turnoverRate();
            /*0x7b4d6bc*/ void set_turnoverRate(float value);
            /*0x7b40a88*/ void InitStreaming();
            /*0x7b41174*/ void CleanupStreaming();
            /*0x7b4da70*/ void ScenarioBlendingChanged(bool scenarioChanged);
            /*0x7b4dd0c*/ void ComputeStreamingScore(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells);
            /*0x7b4de14*/ void ComputeBestToBeLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x7b4e160*/ void ComputeStreamingScoreAndWorseLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x7b4e514*/ void ComputeBlendingScore(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells, float worstScore);
            /*0x7b4e604*/ bool TryLoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, ref int shBudget, ref int indexBudget, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x7b4e70c*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> unloadedCells);
            /*0x7b4e784*/ bool TryLoadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x7b4e838*/ void ComputeMinMaxStreamingScore();
            /*0x7b4e994*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
            /*0x7b4e99c*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options);
            /*0x7b504d0*/ int FindWorstBlendingCellToBeLoaded();
            /*0x7b4fedc*/ void UpdateBlendingCellStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b42bd8*/ void StartIndexDefragmentation();
            /*0x7b4f5e8*/ void UpdateIndexDefragmentation();
            /*0x7b506cc*/ void OnStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b50754*/ void OnBlendingStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b49b78*/ void PushDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, string scenario, int poolIndex, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete);
            /*0x7b417b4*/ void CancelStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b41984*/ void CancelBlendingStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b50854*/ bool ProcessDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request);
            /*0x7b513bc*/ void AllocateScratchBufferPoolIfNeeded();
            /*0x7b4d7bc*/ void UpdateActiveRequests(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b4d6d8*/ void ProcessNewRequests();
            /*0x7b4fadc*/ void UpdateDiskStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b4d4ec*/ bool HasActiveStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x7b514b4*/ void LogStreaming(string log);
            /*0x3907c14*/ void <RegisterDebug>g__RefreshDebug|219_0<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x7b516ec*/ bool <RegisterDebug>b__219_2();
            /*0x7b51708*/ void <RegisterDebug>b__219_3(bool value);
            /*0x7b51728*/ bool <RegisterDebug>b__219_4();
            /*0x7b51744*/ void <RegisterDebug>b__219_5(bool value);
            /*0x7b51764*/ float <RegisterDebug>b__219_6();
            /*0x7b51780*/ void <RegisterDebug>b__219_7(float value);
            /*0x7b5179c*/ bool <RegisterDebug>b__219_9();
            /*0x7b517b8*/ void <RegisterDebug>b__219_10(bool value);
            /*0x7b517d8*/ bool <RegisterDebug>b__219_11();
            /*0x7b517fc*/ int <RegisterDebug>b__219_12();
            /*0x7b51818*/ void <RegisterDebug>b__219_13(int value);
            /*0x7b51834*/ int <RegisterDebug>b__219_14();
            /*0x7b51850*/ void <RegisterDebug>b__219_15(int value);
            /*0x7b5186c*/ float <RegisterDebug>b__219_16();
            /*0x7b51888*/ void <RegisterDebug>b__219_17(float value);
            /*0x7b518a4*/ float <RegisterDebug>b__219_20();
            /*0x7b518c0*/ void <RegisterDebug>b__219_21(float value);
            /*0x7b518dc*/ bool <RegisterDebug>b__219_22();
            /*0x7b51914*/ int <RegisterDebug>b__219_23();
            /*0x7b51930*/ void <RegisterDebug>b__219_24(int v);
            /*0x7b51960*/ int <RegisterDebug>b__219_26();
            /*0x7b51970*/ int <RegisterDebug>b__219_27();
            /*0x7b5198c*/ void <RegisterDebug>b__219_28(int v);
            /*0x7b519ac*/ int <RegisterDebug>b__219_30();
            /*0x7b519bc*/ bool <RegisterDebug>b__219_31();
            /*0x7b519d8*/ void <RegisterDebug>b__219_32(bool value);
            /*0x7b51a5c*/ bool <RegisterDebug>b__219_33();
            /*0x7b51a80*/ float <RegisterDebug>b__219_34();
            /*0x7b51a9c*/ void <RegisterDebug>b__219_35(float value);
            /*0x7b51ab8*/ bool <RegisterDebug>b__219_38();
            /*0x7b51ad4*/ void <RegisterDebug>b__219_39(bool value);
            /*0x7b51af4*/ bool <RegisterDebug>b__219_40();
            /*0x7b51b10*/ void <RegisterDebug>b__219_41(bool value);
            /*0x7b51c10*/ bool <RegisterDebug>b__219_42();
            /*0x7b51c34*/ float <RegisterDebug>b__219_43();
            /*0x7b51c50*/ void <RegisterDebug>b__219_44(float value);
            /*0x7b51c6c*/ bool <RegisterDebug>b__219_47();
            /*0x7b51c90*/ float <RegisterDebug>b__219_48();
            /*0x7b51cac*/ void <RegisterDebug>b__219_49(float value);
            /*0x7b51cc8*/ bool <RegisterDebug>b__219_51();
            /*0x7b51ce4*/ void <RegisterDebug>b__219_52(bool value);
            /*0x7b51d04*/ bool <RegisterDebug>b__219_53();
            /*0x7b51d20*/ void <RegisterDebug>b__219_54(bool value);
            /*0x7b51d40*/ bool <RegisterDebug>b__219_55();
            /*0x7b51d70*/ bool <RegisterDebug>b__219_56();
            /*0x7b51d8c*/ void <RegisterDebug>b__219_57(bool value);
            /*0x7b51dac*/ bool <RegisterDebug>b__219_58();
            /*0x7b51dc8*/ void <RegisterDebug>b__219_59(bool value);
            /*0x7b51de8*/ bool <RegisterDebug>b__219_67();
            /*0x7b51e04*/ void <RegisterDebug>b__219_68(bool value);
            /*0x7b51e24*/ bool <RegisterDebug>b__219_69();
            /*0x7b51e48*/ bool <RegisterDebug>b__219_71();
            /*0x7b51e64*/ void <RegisterDebug>b__219_72(bool value);
            /*0x7b51e84*/ bool <RegisterDebug>b__219_73();
            /*0x7b51ea0*/ void <RegisterDebug>b__219_74(bool value);
            /*0x7b51ec0*/ void <RegisterDebug>g__RefreshScenarioNames|219_75(string guid);
            /*0x7b52648*/ int <RegisterDebug>b__219_83();
            /*0x7b527c0*/ void <RegisterDebug>b__219_84(int value);
            /*0x7b5283c*/ int <RegisterDebug>b__219_85();
            /*0x7b52858*/ void <RegisterDebug>b__219_86(int value);

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

                static /*0x7b59adc*/ ShaderIDs();
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

                /*0x7b59e84*/ CellDesc();
                /*0x7b59dcc*/ string ToString();
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

                /*0x7b5a474*/ CellData();
                /*0x7b59e8c*/ Unity.Collections.NativeArray<ushort> get_skyOcclusionDataL0L1();
                /*0x7b59e98*/ void set_skyOcclusionDataL0L1(Unity.Collections.NativeArray<ushort> value);
                /*0x7b59ea0*/ Unity.Collections.NativeArray<byte> get_skyShadingDirectionIndices();
                /*0x7b59eac*/ void set_skyShadingDirectionIndices(Unity.Collections.NativeArray<byte> value);
                /*0x7b59eb4*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> get_bricks();
                /*0x7b59ec0*/ void set_bricks(Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> value);
                /*0x7b59ec8*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_probePositions();
                /*0x7b59ed4*/ void set_probePositions(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x7b59edc*/ Unity.Collections.NativeArray<float> get_touchupVolumeInteraction();
                /*0x7b59ee8*/ void set_touchupVolumeInteraction(Unity.Collections.NativeArray<float> value);
                /*0x7b59ef0*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_offsetVectors();
                /*0x7b59efc*/ void set_offsetVectors(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x7b59f04*/ Unity.Collections.NativeArray<float> get_validity();
                /*0x7b59f10*/ void set_validity(Unity.Collections.NativeArray<float> value);
                /*0x7b59f18*/ Unity.Collections.NativeArray<byte> get_layer();
                /*0x7b59f24*/ void set_layer(Unity.Collections.NativeArray<byte> value);
                /*0x7b59f2c*/ void CleanupPerScenarioData(ref UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data);
                /*0x7b5a07c*/ void Cleanup(bool cleanScenarioList);

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

                /*0x7b5a54c*/ CellPoolInfo();
                /*0x7b5a4fc*/ void Clear();
            }

            class CellIndexInfo
            {
                /*0x10*/ int[] flatIndicesInGlobalIndirection;
                /*0x18*/ UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo updateInfo;
                /*0x20*/ bool indexUpdated;
                /*0x28*/ UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo[] indirectionEntryInfo;
                /*0x30*/ int indexChunkCount;

                /*0x7b5a604*/ CellIndexInfo();
                /*0x7b5a5d4*/ void Clear();
            }

            class CellBlendingInfo
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x18*/ float blendingScore;
                /*0x1c*/ float blendingFactor;
                /*0x20*/ bool blending;

                /*0x7b5a6c8*/ CellBlendingInfo();
                /*0x7b5a60c*/ void MarkUpToDate();
                /*0x7b5a618*/ bool IsUpToDate();
                /*0x7b5a630*/ void ForceReupload();
                /*0x7b5a63c*/ bool ShouldReupload();
                /*0x7b5a650*/ void Prioritize();
                /*0x7b5a65c*/ bool ShouldPrioritize();
                /*0x7b5a670*/ void Clear();
            }

            class CellStreamingInfo
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest0;
                /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest1;
                /*0x28*/ float streamingScore;

                /*0x7b5a7fc*/ CellStreamingInfo();
                /*0x7b5a750*/ bool IsStreaming();
                /*0x7b5a780*/ bool IsBlendingStreaming();
                /*0x7b5a7bc*/ void Clear();
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

                /*0x7b5a9c8*/ Cell();
                /*0x7b5a804*/ int CompareTo(UnityEngine.Rendering.ProbeReferenceVolume.Cell other);
                /*0x7b5a850*/ bool UpdateCellScenarioData(string scenario0, string scenario1);
                /*0x7b5a910*/ void Clear();
            }

            struct Volume : System.IEquatable<UnityEngine.Rendering.ProbeReferenceVolume.Volume>
            {
                /*0x10*/ UnityEngine.Vector3 corner;
                /*0x1c*/ UnityEngine.Vector3 X;
                /*0x28*/ UnityEngine.Vector3 Y;
                /*0x34*/ UnityEngine.Vector3 Z;
                /*0x40*/ float maxSubdivisionMultiplier;
                /*0x44*/ float minSubdivisionMultiplier;

                /*0x7b5aae4*/ Volume(UnityEngine.Matrix4x4 trs, float maxSubdivision, float minSubdivision);
                /*0x7b5abc8*/ Volume(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, float maxSubdivision, float minSubdivision);
                /*0x7b5ac04*/ Volume(UnityEngine.Rendering.ProbeReferenceVolume.Volume copy);
                /*0x7b5aca8*/ Volume(UnityEngine.Bounds bounds);
                /*0x7b5ad08*/ UnityEngine.Bounds CalculateAABB();
                /*0x7b5ae10*/ void CalculateCenterAndSize(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
                /*0x7b5afd8*/ void Transform(UnityEngine.Matrix4x4 trs);
                /*0x7b5b088*/ string ToString();
                /*0x7b5b2d8*/ bool Equals(UnityEngine.Rendering.ProbeReferenceVolume.Volume other);
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

                /*0x7b5b3dc*/ CellInstancedDebugProbes();
            }

            class RenderFragmentationOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugFragmentationMaterial;
                /*0x18*/ UnityEngine.Rendering.DebugOverlay debugOverlay;
                /*0x20*/ int chunkCount;
                /*0x28*/ UnityEngine.ComputeBuffer debugFragmentationData;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;

                /*0x7b5b3e4*/ RenderFragmentationOverlayPassData();
            }

            class DiskStreamingRequest
            {
                /*0x10*/ Unity.IO.LowLevel.Unsafe.ReadHandle m_ReadHandle;
                /*0x20*/ Unity.IO.LowLevel.Unsafe.ReadCommandArray m_ReadCommandArray;
                /*0x30*/ Unity.Collections.NativeArray<Unity.IO.LowLevel.Unsafe.ReadCommand> m_ReadCommandBuffer;
                /*0x40*/ int m_BytesWritten;

                /*0x7b5b3ec*/ DiskStreamingRequest(int maxRequestCount);
                /*0x7b5b470*/ void AddReadCommand(int offset, int size, byte* dest);
                /*0x7b5b4a8*/ int RunCommands(Unity.IO.LowLevel.Unsafe.FileHandle file);
                /*0x7b5b524*/ void Clear();
                /*0x7b5b584*/ void Cancel();
                /*0x7b5b5b4*/ void Wait();
                /*0x7b5b5fc*/ void Dispose();
                /*0x7b5b644*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus();
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

                /*0x7b5b678*/ CellStreamingScratchBuffer(int chunkCount, int chunkSize, bool allocateGraphicsBuffers);
                /*0x7b5b7ec*/ void Swap();
                /*0x7b5b810*/ void Dispose();
                /*0x7b57248*/ UnityEngine.GraphicsBuffer get_buffer();
                /*0x7b5b8bc*/ int get_chunkCount();
                /*0x7b5b8c4*/ int get_chunkSize();
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

                /*0x7b5bd18*/ CellStreamingRequest();
                /*0x7b5b8cc*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell get_cell();
                /*0x7b5b8d4*/ void set_cell(UnityEngine.Rendering.ProbeReferenceVolume.Cell value);
                /*0x7b5b8dc*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State get_state();
                /*0x7b5b8e4*/ void set_state(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State value);
                /*0x7b5b8ec*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer get_scratchBuffer();
                /*0x7b5b8f4*/ void set_scratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer value);
                /*0x7b5b8fc*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout get_scratchBufferLayout();
                /*0x7b5b90c*/ void set_scratchBufferLayout(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout value);
                /*0x7b5b924*/ UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo get_scenarioData();
                /*0x7b5b92c*/ void set_scenarioData(UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo value);
                /*0x7b5b934*/ int get_poolIndex();
                /*0x7b5b93c*/ void set_poolIndex(int value);
                /*0x7b5b944*/ bool get_streamSharedData();
                /*0x7b5b94c*/ void set_streamSharedData(bool value);
                /*0x7b5a770*/ bool IsStreaming();
                /*0x7b5b958*/ void Cancel();
                /*0x7b5ba78*/ void WaitAll();
                /*0x7b5bae4*/ bool UpdateRequestState(UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest request, ref bool isComplete);
                /*0x7b5bb50*/ void UpdateState();
                /*0x7b5bc20*/ void Clear();
                /*0x7b5bc40*/ void Reset();
                /*0x7b5bcc0*/ void Dispose();

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
                    /*0x7b5be38*/ OnStreamingCompleteDelegate(object object, nint method);
                    /*0x7b5bf44*/ void Invoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x7b5bf58*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd, System.AsyncCallback callback, object object);
                    /*0x7b5bf80*/ void EndInvoke(System.IAsyncResult result);
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

                static /*0x7b5bf8c*/ <>c();
                /*0x7b5bff4*/ <>c();
                /*0x7b5bffc*/ void <.ctor>b__148_0(UnityEngine.Rendering.ProbeReferenceVolume.Cell x);
                /*0x7b5c010*/ void <.ctor>b__148_1(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
                /*0x7b5c03c*/ bool <RegisterDebug>b__219_1();
                /*0x7b5c044*/ float <RegisterDebug>b__219_8();
                /*0x7b5c04c*/ float <RegisterDebug>b__219_18();
                /*0x7b5c058*/ float <RegisterDebug>b__219_19();
                /*0x7b5c060*/ int <RegisterDebug>b__219_25();
                /*0x7b5c068*/ int <RegisterDebug>b__219_29();
                /*0x7b5c070*/ float <RegisterDebug>b__219_36();
                /*0x7b5c07c*/ float <RegisterDebug>b__219_37();
                /*0x7b5c084*/ float <RegisterDebug>b__219_45();
                /*0x7b5c090*/ float <RegisterDebug>b__219_46();
                /*0x7b5c09c*/ float <RegisterDebug>b__219_50();
                /*0x7b5c0a4*/ bool <RegisterDebug>b__219_60();
                /*0x7b5c138*/ void <RegisterDebug>b__219_61(bool value);
                /*0x7b5c1d4*/ bool <RegisterDebug>b__219_62();
                /*0x7b5c268*/ int <RegisterDebug>b__219_63();
                /*0x7b5c2fc*/ void <RegisterDebug>b__219_64(int value);
                /*0x7b5c398*/ int <RegisterDebug>b__219_65();
                /*0x7b5c3a0*/ int <RegisterDebug>b__219_66();
                /*0x7b5c3a8*/ object <RegisterDebug>b__219_70();
                /*0x7b5c458*/ int <RegisterDebug>b__219_76();
                /*0x7b5c4ec*/ void <RegisterDebug>b__219_77(int value);
                /*0x7b5c588*/ int <RegisterDebug>b__219_78();
                /*0x7b5c590*/ float <RegisterDebug>b__219_79();
                /*0x7b5c624*/ void <RegisterDebug>b__219_80(float value);
                /*0x7b5c6c8*/ float <RegisterDebug>b__219_81();
                /*0x7b5c6d0*/ float <RegisterDebug>b__219_82();
                /*0x7b5c6d8*/ float <RegisterDebug>b__219_87();
                /*0x7b5c76c*/ void <RegisterDebug>b__219_88(float value);
                /*0x7b5c810*/ float <RegisterDebug>b__219_89();
                /*0x7b5c818*/ float <RegisterDebug>b__219_90();
                /*0x7b5c820*/ void <RenderFragmentationOverlay>b__222_0(UnityEngine.Rendering.ProbeReferenceVolume.RenderFragmentationOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                /*0x7b5c998*/ void <CleanupStreaming>b__283_0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
            }

            class <>c__DisplayClass314_0
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell cell;

                /*0x7b5c9c4*/ <>c__DisplayClass314_0();
                /*0x7b5c9cc*/ bool <HasActiveStreamingRequest>b__0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest x);
            }
        }

        class SceneExtensions
        {
            static /*0x0*/ System.Reflection.PropertyInfo s_SceneGUID;

            static /*0x7b5cab0*/ SceneExtensions();
            static /*0x7b5c9f0*/ string GetGUID(UnityEngine.SceneManagement.Scene scene);
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

            /*0x7b5cb6c*/ ProbeSamplingDebugData();
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

            /*0x7b5cb7c*/ ProbeVolumeDebug();
            /*0x7b5cc2c*/ void Init();
            /*0x7b5cc98*/ System.Action GetReset();
            /*0x7b5cd14*/ void <GetReset>b__32_0();
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

            static /*0x7b5cd80*/ ProbeVolumeDebugColorPreferences();
            /*0x7b5ce20*/ ProbeVolumeDebugColorPreferences();
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

            /*0x7b5ce5c*/ ProbeVolume();
            /*0x7b5ce28*/ void Awake();

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
            /*0x7b5ceb0*/ ObsoleteProbeVolumeAsset();
        }

        struct ProbeDilationSettings
        {
            /*0x10*/ bool enableDilation;
            /*0x14*/ float dilationDistance;
            /*0x18*/ float dilationValidityThreshold;
            /*0x1c*/ int dilationIterations;
            /*0x20*/ bool squaredDistWeighting;

            /*0x7b5ceb8*/ void SetDefaults();
            /*0x7b5ced8*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct VirtualOffsetSettings
        {
            /*0x10*/ bool useVirtualOffset;
            /*0x14*/ float validityThreshold;
            /*0x18*/ float outOfGeoOffset;
            /*0x1c*/ float searchMultiplier;
            /*0x20*/ float rayOriginBias;
            /*0x24*/ UnityEngine.LayerMask collisionMask;

            /*0x7b5cedc*/ void SetDefaults();
            /*0x7b5cf10*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct ProbeVolumeBakingProcessSettings
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion m_Version;
            /*0x14*/ UnityEngine.Rendering.ProbeDilationSettings dilationSettings;
            /*0x28*/ UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings;

            static /*0x7b5cf4c*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings get_Default();
            /*0x7b5d000*/ ProbeVolumeBakingProcessSettings(UnityEngine.Rendering.ProbeDilationSettings dilationSettings, UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings);
            /*0x7b5cfb0*/ void SetDefaults();
            /*0x7b5d02c*/ void Upgrade();

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

            /*0x7b5d074*/ LogarithmicAttribute(int min, int max);
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

            static /*0x7b5d16c*/ int GetCellSizeInBricks(int simplificationLevels);
            static /*0x7b5d1a8*/ int GetMaxSubdivision(int simplificationLevels);
            static /*0x7b5d1cc*/ float GetMinBrickSize(float minDistanceBetweenProbes);
            static /*0x7b5efbc*/ int AlignUp16(int count);
            /*0x7b60fb8*/ ProbeVolumeBakingSet();
            /*0x7b5d0a0*/ bool get_hasDilation();
            /*0x7b5d0c0*/ System.Collections.Generic.IReadOnlyList<string> get_sceneGUIDs();
            /*0x7b5d0c8*/ System.Collections.Generic.IReadOnlyList<string> get_lightingScenarios();
            /*0x7b5d0d0*/ bool get_bakedSkyOcclusion();
            /*0x7b5d0e0*/ void set_bakedSkyOcclusion(bool value);
            /*0x7b5d0fc*/ bool get_bakedSkyShadingDirection();
            /*0x7b5d10c*/ void set_bakedSkyShadingDirection(bool value);
            /*0x7b5d128*/ string get_otherScenario();
            /*0x7b5d130*/ float get_scenarioBlendingFactor();
            /*0x7b5d138*/ int get_cellSizeInBricks();
            /*0x7b5d19c*/ int get_maxSubdivision();
            /*0x7b5d1b0*/ float get_minBrickSize();
            /*0x7b5d1e4*/ float get_cellSizeInMeters();
            /*0x7b5d248*/ Unity.Mathematics.uint4 ComputeRegionMasks();
            /*0x7b5d32c*/ void OnValidate();
            /*0x7b5d4c4*/ void OnEnable();
            /*0x7b5d4f8*/ void Migrate();
            /*0x7b5d5ec*/ bool ComputeHasValidSharedData();
            /*0x7b5d6e8*/ bool HasValidSharedData();
            /*0x7b5d6f0*/ bool CheckCompatibleCellLayout();
            /*0x7b5d5ac*/ bool ComputeHasSupportData();
            /*0x7b5d79c*/ bool HasSupportData();
            /*0x7b5d7a4*/ bool HasBakedData(string scenario);
            /*0x7b5d8dc*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7b5dd44*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7b5dfb0*/ void Initialize(bool useStreamingAsset);
            /*0x7b5e748*/ void Cleanup();
            /*0x7b5eb2c*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x7b5e418*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x7b5edb4*/ int GetBakingHashCode();
            /*0x3907c14*/ Unity.Collections.NativeArray<T> GetSubArray<T>(Unity.Collections.NativeArray<byte> input, int count, ref int offset);
            /*0x7b5efe4*/ Unity.Collections.NativeArray<byte> RequestScratchBuffer(int size);
            /*0x3907c14*/ Unity.Collections.NativeArray<T> LoadStreambleAssetData<T>(UnityEngine.Rendering.ProbeVolumeStreamableAsset asset, System.Collections.Generic.List<int> cellIndices);
            /*0x3907c14*/ void ReleaseStreamableAssetData<T>(Unity.Collections.NativeArray<T> buffer);
            /*0x7b5f0c8*/ void PruneCellIndexList(System.Collections.Generic.List<int> cellIndices, System.Collections.Generic.List<int> prunedIndexList);
            /*0x7b5f2dc*/ void PruneCellIndexListForScenario(System.Collections.Generic.List<int> cellIndices, UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo scenarioData, System.Collections.Generic.List<int> prunedIndexList);
            /*0x7b5f50c*/ System.Collections.Generic.List<int> GetSceneCellIndexList(string sceneGUID);
            /*0x7b5e3e8*/ bool ResolveAllCellData();
            /*0x7b5fd68*/ bool ResolveCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b6019c*/ void ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricksData, Unity.Collections.NativeArray<byte> cellSharedData, Unity.Collections.NativeArray<byte> cellSupportData);
            /*0x7b5f584*/ bool ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b5f7a4*/ bool ResolvePerScenarioCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x7b6087c*/ bool ResolvePerScenarioCellData(Unity.Collections.NativeArray<byte> cellData, Unity.Collections.NativeArray<byte> cellOptionalData, Unity.Collections.NativeArray<byte> cellProbeOcclusionData, string scenario, System.Collections.Generic.List<int> cellIndices);
            /*0x7b60e00*/ void ReleaseCell(int cellIndex);
            /*0x7b60e8c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellDesc GetCellDesc(int cellIndex);
            /*0x7b60f04*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData GetCellData(int cellIndex);
            /*0x7b60f7c*/ int GetChunkGPUMemory(UnityEngine.Rendering.ProbeVolumeSHBands shBands);

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

                /*0x7b61478*/ PerScenarioDataInfo();
                /*0x7b5e3cc*/ void Initialize(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x7b5eb04*/ bool IsValid();
                /*0x7b61470*/ bool HasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x7b61418*/ bool ComputeHasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            }

            struct CellCounts
            {
                /*0x10*/ int bricksCount;
                /*0x14*/ int chunksCount;

                /*0x7b61480*/ void Add(UnityEngine.Rendering.ProbeVolumeBakingSet.CellCounts o);
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

            static /*0x7b619bc*/ ProbeVolumeConstantRuntimeResources();
            static /*0x7b61498*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            static /*0x7b61514*/ void Initialize();
            static /*0x7b61898*/ UnityEngine.Vector3[] GetSkySamplingDirections();
            static /*0x7b618f0*/ void Cleanup();
            static /*0x7b616ac*/ UnityEngine.Vector3[] GenerateSkyDirections();
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

            /*0x7b61ac4*/ ProbeVolumeRuntimeResources();
            /*0x7b61abc*/ int get_version();
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

            /*0x7b61adc*/ ProbeVolumeDebugResources();
            /*0x7b61ad4*/ int get_version();
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

            /*0x7b61af4*/ ProbeVolumeBakingResources();
            /*0x7b61aec*/ int get_version();
        }

        class ProbeVolumeGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x14*/ bool m_ProbeVolumeDisableStreamingAssets;

            /*0x7b61b88*/ ProbeVolumeGlobalSettings();
            /*0x7b61b04*/ int get_version();
            /*0x7b61b0c*/ bool get_probeVolumeDisableStreamingAssets();
            /*0x7b61b14*/ void set_probeVolumeDisableStreamingAssets(bool value);
        }

        class ProbeVolumePerSceneData : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Rendering.ProbeVolumeBakingSet serializedBakingSet;
            /*0x28*/ string sceneGUID;
            /*0x30*/ UnityEngine.Rendering.ObsoleteProbeVolumeAsset obsoleteAsset;
            /*0x38*/ UnityEngine.TextAsset obsoleteCellSharedDataAsset;
            /*0x40*/ UnityEngine.TextAsset obsoleteCellSupportDataAsset;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData.ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios;

            /*0x7b62010*/ ProbeVolumePerSceneData();
            /*0x7b61b98*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_bakingSet();
            /*0x7b61ba0*/ void Clear();
            /*0x7b61ca4*/ void QueueSceneLoading();
            /*0x7b61bc0*/ void QueueSceneRemoval();
            /*0x7b61d88*/ void OnEnable();
            /*0x7b61e24*/ void OnDisable();
            /*0x7b61ec8*/ void OnValidate();
            /*0x7b61ecc*/ void Initialize();
            /*0x7b61f78*/ bool ResolveCellData();

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

            static /*0x7b62ee0*/ ProbeVolumePositioning();
            static /*0x7b620bc*/ bool OBBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Rendering.ProbeReferenceVolume.Volume b);
            static /*0x7b62838*/ bool OBBContains(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume obb, UnityEngine.Vector3 point);
            static /*0x7b62920*/ bool OBBAABBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Bounds b, ref UnityEngine.Bounds aAABB);
            static /*0x7b62750*/ UnityEngine.Vector2 ProjectOBB(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, UnityEngine.Vector3 axis);
            static /*0x7b62e3c*/ UnityEngine.Vector2 ProjectAABB(ref UnityEngine.Vector3[] corners, UnityEngine.Vector3 axis);
        }

        class ProbeVolumeSceneData
        {
            /*0x10*/ UnityEngine.Object parentAsset;
            /*0x18*/ UnityEngine.Rendering.SerializedDictionary<string, UnityEngine.Bounds> obsoleteSceneBounds;
            /*0x20*/ UnityEngine.Rendering.SerializedDictionary<string, bool> obsoleteHasProbeVolumes;

            /*0x7b62f78*/ ProbeVolumeSceneData(UnityEngine.Object parentAsset);
            /*0x7b62fa8*/ void SetParentObject(UnityEngine.Object parent);
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

            /*0x7b62fe0*/ ProbeVolumeScratchBufferPool(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet, UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x7b62fb0*/ int get_chunkSize();
            /*0x7b62fb8*/ void set_chunkSize(int value);
            /*0x7b62fc0*/ int get_maxChunkCount();
            /*0x7b62fc8*/ void set_maxChunkCount(int value);
            /*0x7b62fd0*/ int get_allocatedMemory();
            /*0x7b63140*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount);
            /*0x7b633a8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers);
            /*0x7b63428*/ bool AllocateScratchBuffer(int chunkCount, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers);
            /*0x7b63860*/ void ReleaseScratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer);
            /*0x7b639e0*/ void Cleanup();

            class ScratchBufferPool : System.IComparable<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool>
            {
                /*0x10*/ int chunkCount;
                /*0x18*/ System.Collections.Generic.Stack<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer> pool;

                /*0x7b637c4*/ ScratchBufferPool(int chunkCount);
                /*0x7b63bc0*/ ScratchBufferPool();
                /*0x7b63c50*/ int CompareTo(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool other);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeVolumeScratchBufferPool.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__26_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__27_0;

                static /*0x7b63c80*/ <>c();
                /*0x7b63ce8*/ <>c();
                /*0x7b63cf0*/ bool <AllocateScratchBuffer>b__26_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
                /*0x7b63d50*/ bool <ReleaseScratchBuffer>b__27_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
            }
        }

        class APVLeakReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.APVLeakReductionMode>
        {
            /*0x7b63db0*/ APVLeakReductionModeParameter(UnityEngine.Rendering.APVLeakReductionMode value, bool overrideState);
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

            /*0x7b63e10*/ ProbeVolumesOptions();
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

            /*0x7b64160*/ ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID);
            /*0x7b64140*/ string get_assetGUID();
            /*0x7b64148*/ UnityEngine.TextAsset get_asset();
            /*0x7b64150*/ int get_elementSize();
            /*0x7b64158*/ UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> get_streamableCellDescs();
            /*0x7b642f8*/ void RefreshAssetPath();
            /*0x7b6439c*/ string GetAssetPath();
            /*0x7b5d624*/ bool FileExists();
            /*0x7b643c8*/ long GetFileSize();
            /*0x7b64440*/ bool IsOpen();
            /*0x7b6444c*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFile();
            /*0x7b64488*/ void CloseFile();
            /*0x7b5d77c*/ bool IsValid();
            /*0x7b5eaac*/ void Dispose();

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

            static /*0x7b644f8*/ APVDefinitions();
            /*0x7b644f0*/ APVDefinitions();
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

            static /*0x7b649d8*/ SphericalHarmonicsL1();
            static /*0x7b645ec*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b64614*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b6463c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x7b6465c*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x7b64680*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x7b64730*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            /*0x7b647e4*/ bool Equals(object other);
            /*0x7b648c4*/ int GetHashCode();
        }

        class SphericalHarmonicsL2Utils
        {
            static /*0x7b64a6c*/ void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L1_R, ref UnityEngine.Vector3 L1_G, ref UnityEngine.Vector3 L1_B);
            static /*0x7b64b80*/ void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L2_0, ref UnityEngine.Vector3 L2_1, ref UnityEngine.Vector3 L2_2, ref UnityEngine.Vector3 L2_3, ref UnityEngine.Vector3 L2_4);
            static /*0x7b64d3c*/ void SetL0(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L0);
            static /*0x7b64d98*/ void SetL1R(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R);
            static /*0x7b64df4*/ void SetL1G(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_G);
            static /*0x7b64e50*/ void SetL1B(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_B);
            static /*0x7b64eac*/ void SetL1(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B);
            static /*0x7b64f10*/ void SetCoefficient(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index, UnityEngine.Vector3 coefficient);
            static /*0x7b64f78*/ UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index);
            /*0x7b64fe8*/ SphericalHarmonicsL2Utils();
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
            /*0x380b128*/ bool IsActive();
            /*0x7b64ff0*/ bool IsTileCompatible();
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

            static /*0x7b6c368*/ LensFlareCommonSRP();
            static /*0x7b65000*/ bool IsOcclusionRTCompatible();
            static /*0x7b650c4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetOcclusionRTFormat();
            static /*0x7b6512c*/ void Initialize();
            static /*0x7b65320*/ void Dispose();
            static /*0x7b653f8*/ UnityEngine.Rendering.LensFlareCommonSRP get_Instance();
            static /*0x7b65c00*/ float ShapeAttenuationPointLight();
            static /*0x7b65c08*/ float ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b65c2c*/ float ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, float spotAngle, float innerSpotPercent01);
            static /*0x7b65cd8*/ float ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b65d00*/ float ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b65da0*/ float ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, float lightWidth, UnityEngine.Camera cam);
            static /*0x7b662b8*/ float ShapeAttenuateForwardLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b662d8*/ float ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b66370*/ float ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x7b66408*/ bool IsLensFlareSRPHidden(UnityEngine.Camera cam, UnityEngine.Rendering.LensFlareComponentSRP comp, UnityEngine.Rendering.LensFlareDataSRP data);
            static /*0x7b6652c*/ UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, UnityEngine.Vector2 positionOffset, bool autoRotate);
            static /*0x7b66744*/ UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, float position, float globalCos0, float globalSin0, UnityEngine.Vector2 vAspectRatio);
            static /*0x7b6677c*/ UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, bool isLocalLight, bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS);
            static /*0x7b668c0*/ UnityEngine.Vector3 WorldToViewportLocal(bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS);
            static /*0x7b66938*/ UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS);
            static /*0x7b66a18*/ bool IsCloudLayerOpacityNeeded(UnityEngine.Camera cam);
            static /*0x7b66cb8*/ void SetOcclusionPermutation(UnityEngine.Rendering.CommandBuffer cmd, bool useFogOpacityOcclusion, int _FlareSunOcclusionTex, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b66ddc*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x7b67080*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b66f38*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x7b681c0*/ bool ForceSingleElement(UnityEngine.Rendering.LensFlareDataElementSRP element);
            static /*0x7b671d4*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x7b68424*/ void ProcessLensFlareSRPElementsSingle(UnityEngine.Rendering.LensFlareDataElementSRP element, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x7b69ac8*/ void ProcessLensFlareSRPElements(ref UnityEngine.Rendering.LensFlareDataElementSRP[] elements, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x7b69e44*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x7b6a07c*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x7b6b250*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x7b6a268*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x7b6b428*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x7b6bfc8*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, int _LensFlareScreenSpaceBloomMipTexture, int _LensFlareScreenSpaceResultTexture, int _LensFlareScreenSpaceSpectralLut, int _LensFlareScreenSpaceStreakTex, int _LensFlareScreenSpaceMipLevel, int _LensFlareScreenSpaceTintColor, int _LensFlareScreenSpaceParams1, int _LensFlareScreenSpaceParams2, int _LensFlareScreenSpaceParams3, int _LensFlareScreenSpaceParams4, int _LensFlareScreenSpaceParams5, bool debugView);
            static /*0x7b6b66c*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x7b681fc*/ UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance);
            static /*0x7b6c230*/ UnityEngine.Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView);
            static /*0x7b6c270*/ UnityEngine.Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d);
            static /*0x7b6c334*/ UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, float d);
            static /*0x7b6c9d4*/ float <ShapeAttenuationAreaTubeLight>g__Fpo|57_0(float d, float l);
            static /*0x7b6ca14*/ float <ShapeAttenuationAreaTubeLight>g__Fwt|57_1(float d, float l);
            static /*0x7b65fd0*/ float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|57_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
            static /*0x7b69c9c*/ UnityEngine.Vector2 <ProcessLensFlareSRPElementsSingle>g__ComputeLocalSize|74_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, ref UnityEngine.Rendering.LensFlareCommonSRP.<> );
            static /*0x7b69e3c*/ float <ProcessLensFlareSRPElementsSingle>g__RandomRange|74_1(float min, float max);
            /*0x7b64ff8*/ LensFlareCommonSRP();
            /*0x7b65584*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo> get_Data();
            /*0x7b655dc*/ bool IsEmpty();
            /*0x7b65660*/ int GetNextAvailableIndex();
            /*0x7b65774*/ void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData);
            /*0x7b659cc*/ void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data);

            class LensFlareCompInfo
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.Rendering.LensFlareComponentSRP comp;

                /*0x7b65994*/ LensFlareCompInfo(int idx, UnityEngine.Rendering.LensFlareComponentSRP cmp);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP newData;

                /*0x7b6598c*/ <>c__DisplayClass50_0();
                /*0x7b6ca2c*/ bool <AddData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP data;

                /*0x7b65bf8*/ <>c__DisplayClass51_0();
                /*0x7b6ca9c*/ bool <RemoveData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
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

            static /*0x7b6d0d4*/ LensFlareComponentSRP();
            /*0x7b6cd30*/ LensFlareComponentSRP();
            /*0x7b6cb0c*/ UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData();
            /*0x7b6cb14*/ void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value);
            /*0x7b6835c*/ float celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam);
            /*0x7b6cc04*/ void Awake();
            /*0x7b6cc08*/ void OnEnable();
            /*0x7b6ccb4*/ void OnDisable();
            /*0x7b6cb30*/ void OnValidate();
            /*0x7b6cd14*/ void OnDestroy();

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

            /*0x7b6d124*/ LensFlareDataElementSRP();
            /*0x7b6da2c*/ UnityEngine.Rendering.LensFlareDataElementSRP Clone();
            /*0x7b6df2c*/ float get_localIntensity();
            /*0x7b6d994*/ void set_localIntensity(float value);
            /*0x7b6df34*/ int get_count();
            /*0x7b6d9a4*/ void set_count(int value);
            /*0x7b6df3c*/ float get_intensityVariation();
            /*0x7b6d9b4*/ void set_intensityVariation(float value);
            /*0x7b6df44*/ float get_fallOff();
            /*0x7b6d9c4*/ void set_fallOff(float value);
            /*0x7b6df4c*/ float get_edgeOffset();
            /*0x7b6d9e0*/ void set_edgeOffset(float value);
            /*0x7b6df54*/ int get_sideCount();
            /*0x7b6da18*/ void set_sideCount(int value);
            /*0x7b6df5c*/ float get_sdfRoundness();
            /*0x7b6d9fc*/ void set_sdfRoundness(float value);
        }

        class LensFlareDataSRP : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.LensFlareDataElementSRP[] elements;

            /*0x7b6df64*/ LensFlareDataSRP();
            /*0x7b6df88*/ bool HasAModulateByLightColorElement();
        }

        enum LensFlareOcclusionPermutation
        {
            Depth = 1,
            FogOpacity = 4,
        }

        class DebugDisplaySettingsRenderGraph : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x7b6dfec*/ DebugDisplaySettingsRenderGraph();
            /*0x7b6e1b0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();
            /*0x7b6e55c*/ bool get_AreAnySettingsActive();

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x7b6e200*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsRenderGraph _);
                /*0x7b6e728*/ string get_PanelName();
            }
        }

        class RenderGraphGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphGlobalSettings.Version m_version;
            /*0x14*/ bool m_EnableCompilationCaching;
            /*0x15*/ bool m_EnableValidityChecks;

            /*0x7b6e870*/ RenderGraphGlobalSettings();
            /*0x7b6e768*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x7b6e770*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7b6e778*/ bool get_enableCompilationCaching();
            /*0x7b6e780*/ void set_enableCompilationCaching(bool value);
            /*0x7b6e7f4*/ bool get_enableValidityChecks();
            /*0x7b6e7fc*/ void set_enableValidityChecks(bool value);

            enum Version
            {
                Initial = 0,
                Count = 1,
                Last = 0,
            }
        }

        interface ICloudBackground
        {
            /*0x380b128*/ bool IsCloudBackgroundUsable();
        }

        interface IVolumetricCloud
        {
            /*0x380b128*/ bool IsVolumetricCloudUsable();
        }

        class RenderPipelineGlobalSettings<TGlobalRenderPipelineSettings, TRenderPipeline> : UnityEngine.Rendering.RenderPipelineGlobalSettings
        {
            static /*0x0*/ System.Lazy<TGlobalRenderPipelineSettings> s_Instance;

            static /*0x38358cc*/ RenderPipelineGlobalSettings();
            static /*0x3907c14*/ TGlobalRenderPipelineSettings get_instance();
            /*0x380cb08*/ RenderPipelineGlobalSettings();
            /*0x380cb08*/ void Reset();

            class <>c<TGlobalRenderPipelineSettings, TRenderPipeline>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderPipelineGlobalSettings.<>c<TGlobalRenderPipelineSettings, TRenderPipeline> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ TGlobalRenderPipelineSettings <.cctor>b__5_0();
            }
        }

        class RenderPipelineGraphicsSettingsContainer : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Rendering.RenderPipelineGraphicsSettingsCollection m_RuntimeSettings;

            /*0x7b6e8a4*/ RenderPipelineGraphicsSettingsContainer();
            /*0x7b6e880*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x7b6e89c*/ void OnBeforeSerialize();
            /*0x7b6e8a0*/ void OnAfterDeserialize();
        }

        class RenderPipelineResources : UnityEngine.ScriptableObject
        {
            /*0x7b6e924*/ RenderPipelineResources();
            /*0x7b6e910*/ string get_packagePath();
            /*0x7b6e918*/ string get_packagePath_Internal();
        }

        interface IDefaultVolumeProfileAsset : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x380b9e8*/ UnityEngine.Rendering.VolumeProfile get_defaultVolumeProfile();
            /*0x380d83c*/ void set_defaultVolumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        interface IDefaultVolumeProfileSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x7b6e92c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x380b9e8*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
            /*0x380d83c*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        class IncludeAdditionalRPAssets : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.IncludeAdditionalRPAssets.Version m_version;
            /*0x14*/ bool m_IncludeReferencedInScenes;
            /*0x15*/ bool m_IncludeAssetsByLabel;
            /*0x18*/ string m_LabelToInclude;

            /*0x7b6eab0*/ IncludeAdditionalRPAssets();
            /*0x7b6e934*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7b6e93c*/ bool get_includeReferencedInScenes();
            /*0x7b6e944*/ void set_includeReferencedInScenes(bool value);
            /*0x7b6e9b8*/ bool get_includeAssetsByLabel();
            /*0x7b6e9c0*/ void set_includeAssetsByLabel(bool value);
            /*0x7b6ea34*/ string get_labelToInclude();
            /*0x7b6ea3c*/ void set_labelToInclude(string value);

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

            /*0x7b6ec3c*/ ShaderStrippingSetting();
            /*0x7b6eab8*/ int get_version();
            /*0x7b6eac0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x7b6eac8*/ bool get_exportShaderVariants();
            /*0x7b6ead0*/ void set_exportShaderVariants(bool value);
            /*0x7b6eb44*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x7b6eb4c*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x7b6ebc0*/ bool get_stripRuntimeDebugShaders();
            /*0x7b6ebc8*/ void set_stripRuntimeDebugShaders(bool value);

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

            /*0x7b6ec50*/ GenerateHLSL(UnityEngine.Rendering.PackingRules rules, bool needAccessors, bool needSetters, bool needParamDebug, int paramDefinesStart, bool omitStructDeclaration, bool containsPackedFields, bool generateCBuffer, int constantRegister, string sourcePath);
        }

        class SurfaceDataAttributes : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ bool isDirection;
            /*0x19*/ bool sRGBDisplay;
            /*0x1c*/ UnityEngine.Rendering.FieldPrecision precision;
            /*0x20*/ bool checkIsNormalized;
            /*0x28*/ string preprocessor;

            /*0x7b6ecf0*/ SurfaceDataAttributes(string displayName, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
            /*0x7b6edd8*/ SurfaceDataAttributes(string[] displayNames, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
        }

        class HLSLArray : System.Attribute
        {
            /*0x10*/ int arraySize;
            /*0x18*/ System.Type elementType;

            /*0x7b6ee4c*/ HLSLArray(int arraySize, System.Type elementType);
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

            /*0x7b6ee84*/ PackingAttribute(string[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
            /*0x7b6efa0*/ PackingAttribute(string displayName, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
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

            static /*0x7b6f5e8*/ Hammersley();
            static /*0x7b6f0f8*/ void Initialize();
            static /*0x7b6f494*/ void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs);

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
            /*0x380b128*/ bool get_isStpUsed();
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

            static /*0x7b72ce4*/ STP();
            static /*0x7b6f820*/ bool IsSupported();
            static /*0x7b6f84c*/ UnityEngine.Vector2 Jit16(int frameIndex);
            static /*0x7b6f890*/ UnityEngine.GUIContent[] get_debugViewDescriptions();
            static /*0x7b6f8e8*/ int[] get_debugViewIndices();
            static /*0x7b6f940*/ UnityEngine.Rendering.STP.PerViewConfig[] get_perViewConfigs();
            static /*0x7b6f998*/ void set_perViewConfigs(UnityEngine.Rendering.STP.PerViewConfig[] value);
            static /*0x7b6f9f8*/ UnityEngine.Hash128 ComputeHistoryHash(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
            static /*0x7b6faac*/ UnityEngine.Vector2Int CalculateConvergenceTextureSize(UnityEngine.Vector2Int historyTextureSize);
            static /*0x7b6fb30*/ float CalculateMotionScale(float deltaTime, float lastDeltaTime);
            static /*0x7b6fbbc*/ UnityEngine.Matrix4x4 ExtractRotation(UnityEngine.Matrix4x4 input);
            static /*0x7b6fc44*/ int PackVector2ToInt(UnityEngine.Vector2 value);
            static /*0x7b6fc7c*/ void PopulateConstantData(ref UnityEngine.Rendering.STP.Config config, ref UnityEngine.Rendering.STP.StpConstantBufferData constants);
            static /*0x7b70ae0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseTexture(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder, UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
            static /*0x7b70b9c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.STP.Config config);

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

                /*0x7b73528*/ HistoryContext();
                /*0x7b7310c*/ bool Update(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
                /*0x7b72cac*/ UnityEngine.Rendering.RTHandle GetCurrentHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x7b72c70*/ UnityEngine.Rendering.RTHandle GetPreviousHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x7b7348c*/ void Dispose();
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

                static /*0x7b7359c*/ ShaderResources();
            }

            class ShaderKeywords
            {
                static /*0x0*/ string EnableDebugMode;
                static /*0x8*/ string EnableLargeKernel;
                static /*0x10*/ string EnableStencilResponsive;
                static /*0x18*/ string DisableTexture2DXArray;

                static /*0x7b7393c*/ ShaderKeywords();
            }

            class RuntimeResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.ComputeShader m_setupCS;
                /*0x18*/ UnityEngine.ComputeShader m_preTaaCS;
                /*0x20*/ UnityEngine.ComputeShader m_taaCS;

                /*0x7b73bac*/ RuntimeResources();
                /*0x7b73a30*/ int get_version();
                /*0x7b73a38*/ UnityEngine.ComputeShader get_setupCS();
                /*0x7b73a40*/ void set_setupCS(UnityEngine.ComputeShader value);
                /*0x7b73ab4*/ UnityEngine.ComputeShader get_preTaaCS();
                /*0x7b73abc*/ void set_preTaaCS(UnityEngine.ComputeShader value);
                /*0x7b73b30*/ UnityEngine.ComputeShader get_taaCS();
                /*0x7b73b38*/ void set_taaCS(UnityEngine.ComputeShader value);
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

                /*0x7b73bb4*/ SetupData();
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

                /*0x7b73bbc*/ PreTaaData();
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

                /*0x7b73bc4*/ TaaData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.STP.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.SetupData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.PreTaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_1;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.TaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_2;

                static /*0x7b73bcc*/ <>c();
                /*0x7b73c34*/ <>c();
                /*0x7b73c3c*/ void <Execute>b__38_0(UnityEngine.Rendering.STP.SetupData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7b741b0*/ void <Execute>b__38_1(UnityEngine.Rendering.STP.PreTaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7b74488*/ void <Execute>b__38_2(UnityEngine.Rendering.STP.TaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
            }
        }

        class BufferedRTHandleSystem : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RTHandle[]> m_RTHandles;
            /*0x18*/ UnityEngine.Rendering.RTHandleSystem m_RTHandleSystem;
            /*0x20*/ bool m_DisposedValue;

            /*0x7b757a4*/ BufferedRTHandleSystem();
            /*0x7b747d8*/ int get_maxWidth();
            /*0x7b747f4*/ int get_maxHeight();
            /*0x7b74810*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b74838*/ UnityEngine.Rendering.RTHandle GetFrameRT(int bufferId, int frameIndex);
            /*0x7b748f0*/ void ClearBuffers(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b74af4*/ void AllocBuffer(int bufferId, System.Func<UnityEngine.Rendering.RTHandleSystem, int, UnityEngine.Rendering.RTHandle> allocator, int bufferCount);
            /*0x7b74c94*/ void AllocBuffer(int bufferId, int bufferCount, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            /*0x7b75040*/ void ReleaseBuffer(int bufferId);
            /*0x7b75130*/ void SwapAndSetReferenceSize(int width, int height);
            /*0x7b75474*/ void ResetReferenceSize(int width, int height);
            /*0x7b75490*/ int GetNumFramesAllocated(int bufferId);
            /*0x7b75528*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
            /*0x7b7516c*/ void Swap();
            /*0x7b7555c*/ void Dispose(bool disposing);
            /*0x7b7579c*/ void Dispose();
            /*0x7b755b8*/ void ReleaseAll();
            /*0x7b74ee8*/ UnityEngine.Rendering.RTHandle <AllocBuffer>g__Alloc|12_0(ref UnityEngine.RenderTextureDescriptor d, UnityEngine.FilterMode fMode, UnityEngine.TextureWrapMode wMode, bool isShadow, int aniso, float mipBias, string n, ref UnityEngine.Rendering.BufferedRTHandleSystem.<> );

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

            static /*0x7b75b04*/ UnityEngine.Vector4 GetPayloadScaleOffset(ref UnityEngine.Vector2 textureSize, ref UnityEngine.Vector2 paddingSize, ref UnityEngine.Vector4 scaleOffset);
            static /*0x7b76c90*/ long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x7b76d58*/ int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x7b75864*/ PowerOfTwoTextureAtlas(int size, int mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, string name, bool useMipMap);
            /*0x7b7596c*/ int get_mipPadding();
            /*0x7b75974*/ int GetTexturePadding();
            /*0x7b759a4*/ UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b75b3c*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType);
            /*0x7b75f10*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b7601c*/ void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b76128*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b76234*/ void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b76340*/ void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, ref int width, ref int height);
            /*0x7b75a78*/ UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture);
            /*0x7b7638c*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x7b76598*/ void ResetRequestedTexture();
            /*0x7b765e8*/ bool ReserveSpace(UnityEngine.Texture texture);
            /*0x7b7665c*/ bool ReserveSpace(UnityEngine.Texture texture, int width, int height);
            /*0x7b767c0*/ bool ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, int width, int height);
            /*0x7b76694*/ bool ReserveSpace(int id, int width, int height);
            /*0x7b767f8*/ bool RelayoutEntries();

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

                static /*0x7b76e34*/ <>c();
                /*0x7b76e9c*/ <>c();
                /*0x7b76ea4*/ int <RelayoutEntries>b__23_0(System.ValueTuple<int, UnityEngine.Vector2Int> c1, System.ValueTuple<int, UnityEngine.Vector2Int> c2);
            }
        }

        struct RTHandleStaticHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandle s_RTHandleWrapper;

            static /*0x7b76ee8*/ void SetRTHandleStaticWrapper(UnityEngine.Rendering.RenderTargetIdentifier rtId);
            static /*0x7b770d0*/ void SetRTHandleUserManagedWrapper(ref UnityEngine.Rendering.RTHandle rtWrapper, UnityEngine.Rendering.RenderTargetIdentifier rtId);
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

            static /*0x7b7723c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x7b77268*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x7b772e8*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            /*0x7b77204*/ RTHandle(UnityEngine.Rendering.RTHandleSystem owner);
            /*0x7b77130*/ void SetCustomHandleProperties(ref UnityEngine.Rendering.RTHandleProperties properties);
            /*0x7b77150*/ void ClearCustomHandleProperties();
            /*0x7b77158*/ UnityEngine.Vector2 get_scaleFactor();
            /*0x7b77160*/ void set_scaleFactor(UnityEngine.Vector2 value);
            /*0x7b77168*/ bool get_useScaling();
            /*0x7b77170*/ void set_useScaling(bool value);
            /*0x7b7717c*/ UnityEngine.Vector2Int get_referenceSize();
            /*0x7b77184*/ void set_referenceSize(UnityEngine.Vector2Int value);
            /*0x7b7718c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b771cc*/ UnityEngine.RenderTexture get_rt();
            /*0x7b771d4*/ UnityEngine.Texture get_externalTexture();
            /*0x7b771dc*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
            /*0x7b771f4*/ string get_name();
            /*0x7b771fc*/ bool get_isMSAAEnabled();
            /*0x7b772f4*/ void SetRenderTexture(UnityEngine.RenderTexture rt, bool transferOwnership);
            /*0x7b77368*/ void SetTexture(UnityEngine.Texture tex);
            /*0x7b77084*/ void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex);
            /*0x7b773d8*/ int GetInstanceID();
            /*0x7b77494*/ void Release();
            /*0x7b7764c*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int refSize);
            /*0x7b77840*/ UnityEngine.Vector2Int GetScaledSize();
            /*0x7b77a34*/ void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, bool copyContents);
            /*0x7b77ab8*/ void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags);
            /*0x7b77ac0*/ void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, bool copyContents);
        }

        class RTHandles
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;

            static /*0x7b7ad6c*/ RTHandles();
            static /*0x7b77b1c*/ int get_maxWidth();
            static /*0x7b77b80*/ int get_maxHeight();
            static /*0x7b77be4*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            static /*0x7b77c58*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            static /*0x7b77e98*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            static /*0x7b77f50*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b78214*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b78420*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b78700*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b78918*/ UnityEngine.Rendering.RTHandle Alloc(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b78ba0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
            static /*0x7b78bac*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b78e64*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b790d4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b79340*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b79600*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b7989c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x7b79b0c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x7b79d70*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x7b79ebc*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex);
            static /*0x7b79fdc*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex, bool transferOwnership);
            static /*0x7b76ff0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex);
            static /*0x7b7a188*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, string name);
            static /*0x7b7a314*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            static /*0x7b7a384*/ void Initialize(int width, int height);
            static /*0x7b7a6a8*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            static /*0x7b7a764*/ void Release(UnityEngine.Rendering.RTHandle rth);
            static /*0x7b7a7ec*/ void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
            static /*0x7b7a9c8*/ void SetReferenceSize(int width, int height);
            static /*0x7b7aa4c*/ void ResetReferenceSize(int width, int height);
            static /*0x7b7aad8*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        }

        class ScaleFunc : System.MulticastDelegate
        {
            /*0x7b7ae9c*/ ScaleFunc(object object, nint method);
            /*0x7b7af3c*/ UnityEngine.Vector2Int Invoke(UnityEngine.Vector2Int size);
            /*0x7b7af50*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2Int size, System.AsyncCallback callback, object object);
            /*0x7b7afd4*/ UnityEngine.Vector2Int EndInvoke(System.IAsyncResult result);
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

            /*0x7b7b130*/ RTHandleAllocInfo(string name);
            /*0x7b7affc*/ int get_slices();
            /*0x7b7b004*/ void set_slices(int value);
            /*0x7b7b00c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_format();
            /*0x7b7b014*/ void set_format(UnityEngine.Experimental.Rendering.GraphicsFormat value);
            /*0x7b7b01c*/ UnityEngine.FilterMode get_filterMode();
            /*0x7b7b024*/ void set_filterMode(UnityEngine.FilterMode value);
            /*0x7b7b02c*/ UnityEngine.TextureWrapMode get_wrapModeU();
            /*0x7b7b034*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
            /*0x7b7b03c*/ UnityEngine.TextureWrapMode get_wrapModeV();
            /*0x7b7b044*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
            /*0x7b7b04c*/ UnityEngine.TextureWrapMode get_wrapModeW();
            /*0x7b7b054*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
            /*0x7b7b05c*/ UnityEngine.Rendering.TextureDimension get_dimension();
            /*0x7b7b064*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
            /*0x7b7b06c*/ bool get_enableRandomWrite();
            /*0x7b7b074*/ void set_enableRandomWrite(bool value);
            /*0x7b7b080*/ bool get_useMipMap();
            /*0x7b7b088*/ void set_useMipMap(bool value);
            /*0x7b7b094*/ bool get_autoGenerateMips();
            /*0x7b7b09c*/ void set_autoGenerateMips(bool value);
            /*0x7b7b0a8*/ int get_anisoLevel();
            /*0x7b7b0b0*/ void set_anisoLevel(int value);
            /*0x7b7b0b8*/ float get_mipMapBias();
            /*0x7b7b0c0*/ void set_mipMapBias(float value);
            /*0x7b7b0c8*/ UnityEngine.Rendering.MSAASamples get_msaaSamples();
            /*0x7b7b0d0*/ void set_msaaSamples(UnityEngine.Rendering.MSAASamples value);
            /*0x7b7b0d8*/ bool get_bindTextureMS();
            /*0x7b7b0e0*/ void set_bindTextureMS(bool value);
            /*0x7b7b0ec*/ bool get_useDynamicScale();
            /*0x7b7b0f4*/ void set_useDynamicScale(bool value);
            /*0x7b7b100*/ UnityEngine.RenderTextureMemoryless get_memoryless();
            /*0x7b7b108*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
            /*0x7b7b110*/ UnityEngine.VRTextureUsage get_vrUsage();
            /*0x7b7b118*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
            /*0x7b7b120*/ string get_name();
            /*0x7b7b128*/ void set_name(string value);
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

            static /*0x7b7c93c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            /*0x7b7ade4*/ RTHandleSystem();
            /*0x7b7b16c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x7b7b180*/ void Dispose();
            /*0x7b7a3fc*/ void Initialize(int width, int height);
            /*0x7b7a738*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            /*0x7b7a7dc*/ void Release(UnityEngine.Rendering.RTHandle rth);
            /*0x7b7756c*/ void Remove(UnityEngine.Rendering.RTHandle rth);
            /*0x7b7aacc*/ void ResetReferenceSize(int width, int height);
            /*0x7b7aa44*/ void SetReferenceSize(int width, int height);
            /*0x7b7b358*/ void SetReferenceSize(int width, int height, bool reset);
            /*0x7b7ab60*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(ref UnityEngine.Vector2Int viewportSize);
            /*0x7b7a854*/ void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
            /*0x7b7b800*/ void SwitchResizeMode(UnityEngine.Rendering.RTHandle rth, UnityEngine.Rendering.RTHandleSystem.ResizeMode mode);
            /*0x7b7b914*/ void DemandResize(UnityEngine.Rendering.RTHandle rth);
            /*0x7b7bcac*/ int GetMaxWidth();
            /*0x7b7bcb4*/ int GetMaxHeight();
            /*0x7b7b188*/ void Dispose(bool disposing);
            /*0x7b7b4e4*/ void Resize(int width, int height, bool sizeChanged);
            /*0x7b780a8*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b7836c*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b78588*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b7bcbc*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b7bee0*/ UnityEngine.RenderTexture CreateRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b787ac*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b77cd0*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            /*0x7b78fb4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b78d08*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b793ec*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b77f00*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            /*0x7b79750*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b799e0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b79e14*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b7c598*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x7b7c7b0*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x7b7a054*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture, bool transferOwnership);
            /*0x7b79f24*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture);
            /*0x7b7a114*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture);
            /*0x7b7a22c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, string name);
            /*0x7b7c9ac*/ string DumpRTInfo();
            /*0x7b7c514*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);

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

            /*0x7b7ccd4*/ AtlasAllocator(int width, int height, bool potPadding);
            /*0x7b7cf18*/ bool Allocate(ref UnityEngine.Vector4 result, int width, int height);
            /*0x7b7d1ac*/ void Reset();

            class AtlasNode
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;
                /*0x18*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x7b7cf0c*/ AtlasNode();
                /*0x7b7cf9c*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding);
                /*0x7b7d1e8*/ void Release(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.AtlasAllocator.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_1;

                static /*0x7b7d2dc*/ <>c();
                /*0x7b7d344*/ <>c();
                /*0x7b7d34c*/ void <.ctor>b__6_0(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
                /*0x7b7d350*/ void <.ctor>b__6_1(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
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

            static /*0x7b7ffd0*/ Texture2DAtlas();
            static /*0x7b7d354*/ int get_maxMipLevelPadding();
            /*0x7b7d3b4*/ Texture2DAtlas(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, bool powerOfTwoPadding, string name, bool useMipMap);
            /*0x7b7d3ac*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x7b7d6f0*/ void Release();
            /*0x7b7d764*/ void ResetAllocator();
            /*0x7b7d7e4*/ void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x7b7d668*/ int GetTextureMipmapCount(int width, int height);
            /*0x7b7dc58*/ bool Is2D(UnityEngine.Texture texture);
            /*0x7b7dd24*/ bool IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination);
            /*0x7b7df68*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType);
            /*0x7b7e8f4*/ void MarkGPUTextureValid(int instanceId, bool mipAreValid);
            /*0x7b7e964*/ void MarkGPUTextureInvalid(int instanceId);
            /*0x7b7e9c0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b7ece4*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x7b7ecf4*/ void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, bool blitMips, int overrideInstanceID);
            /*0x7b7ee74*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x7b7f044*/ bool AllocateTextureWithoutBlit(UnityEngine.Texture texture, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b7f0a0*/ bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x7b7f228*/ int GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b7eb5c*/ int GetTextureID(UnityEngine.Texture texture);
            /*0x7b7f2a0*/ int GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b7f2e8*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x7b7f3a4*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x7b7f31c*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int id);
            /*0x7b7f3e0*/ UnityEngine.Vector2Int GetCachedTextureSize(int id);
            /*0x7b7f454*/ bool NeedsUpdate(UnityEngine.Texture texture, bool needMips);
            /*0x7b7f6c8*/ bool NeedsUpdate(int id, int updateCount, bool needMips);
            /*0x7b7f784*/ bool NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, bool needMips);
            /*0x7b7fb90*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x7b7fc30*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Vector4 sourceScaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x7b7fdac*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x7b7fe60*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleBias, int key, int width, int height);

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

            static /*0x7b81278*/ TextureXR();
            static /*0x7b80030*/ void set_maxViews(int value);
            static /*0x7b8008c*/ int get_slices();
            static /*0x7b800e4*/ bool get_useTexArray();
            static /*0x7b8014c*/ UnityEngine.Rendering.TextureDimension get_dimension();
            static /*0x7b801ac*/ UnityEngine.Rendering.RTHandle GetBlackUIntTexture();
            static /*0x7b80230*/ UnityEngine.Rendering.RTHandle GetClearTexture();
            static /*0x7b802b4*/ UnityEngine.Rendering.RTHandle GetMagentaTexture();
            static /*0x7b80338*/ UnityEngine.Rendering.RTHandle GetBlackTexture();
            static /*0x7b803bc*/ UnityEngine.Rendering.RTHandle GetBlackTextureArray();
            static /*0x7b80414*/ UnityEngine.Rendering.RTHandle GetBlackTexture3D();
            static /*0x7b8046c*/ UnityEngine.Rendering.RTHandle GetWhiteTexture();
            static /*0x7b804f0*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b80fd8*/ UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, string name);
            static /*0x7b80bc8*/ UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b80e1c*/ UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x7b811b8*/ UnityEngine.Texture3D CreateBlackTexture3D(string name);
        }

        class ArrayExtensions
        {
            static /*0x3839e58*/ void ResizeArray<T>(ref Unity.Collections.NativeArray<T> array, int capacity);
            static /*0x7b812c4*/ void ResizeArray(ref UnityEngine.Jobs.TransformAccessArray array, int capacity);
            static /*0x3839e58*/ void ResizeArray<T>(ref T[] array, int capacity);
            static /*0x383b540*/ void FillArray<T>(ref Unity.Collections.NativeArray<T> array, ref T value, int startIndex, int length);
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

            static /*0x7b814bc*/ UnityEngine.Vector4 GetSHA(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x7b81564*/ UnityEngine.Vector4 GetSHB(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x7b815f8*/ UnityEngine.Vector4 GetSHC(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            static /*0x7b81ac8*/ bool op_Equality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            static /*0x7b81afc*/ bool op_Inequality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            /*0x7b81364*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            /*0x7b81660*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector4 probesOcclusion);
            /*0x7b816b8*/ bool Equals(UnityEngine.Rendering.SHCoefficients other);
            /*0x7b818c4*/ bool Equals(object obj);
            /*0x7b81954*/ int GetHashCode();
        }

        struct BatchRendererGroupGlobals : System.IEquatable<UnityEngine.Rendering.BatchRendererGroupGlobals>
        {
            static string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
            static /*0x0*/ int kGlobalsPropertyId;
            /*0x10*/ UnityEngine.Vector4 ProbesOcclusion;
            /*0x20*/ UnityEngine.Vector4 SpecCube0_HDR;
            /*0x30*/ UnityEngine.Vector4 SpecCube1_HDR;
            /*0x40*/ UnityEngine.Rendering.SHCoefficients SHCoefficients;

            static /*0x7b82068*/ BatchRendererGroupGlobals();
            static /*0x7b81b34*/ UnityEngine.Rendering.BatchRendererGroupGlobals get_Default();
            static /*0x7b81f3c*/ bool op_Equality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            static /*0x7b81fd0*/ bool op_Inequality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            /*0x7b81c58*/ bool Equals(UnityEngine.Rendering.BatchRendererGroupGlobals other);
            /*0x7b81d70*/ bool Equals(object obj);
            /*0x7b81e28*/ int GetHashCode();
        }

        interface IBitArray
        {
            /*0x380c7f0*/ uint get_capacity();
            /*0x380b128*/ bool get_allFalse();
            /*0x380b128*/ bool get_allTrue();
            /*0x380b3f4*/ bool get_Item(uint index);
            /*0x3907c14*/ void set_Item(uint index, bool value);
            /*0x380b9e8*/ string get_humanizedData();
            /*0x380bb68*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x380bb68*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x380b9e8*/ UnityEngine.Rendering.IBitArray BitNot();
        }

        struct BitArray8 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ byte data;

            static /*0x7b82310*/ UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a);
            static /*0x7b8231c*/ UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b82328*/ UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b824c4*/ bool op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x7b824d4*/ bool op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            /*0x7b82258*/ BitArray8(byte initValue);
            /*0x7b82260*/ BitArray8(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b820d0*/ uint get_capacity();
            /*0x7b820d8*/ bool get_allFalse();
            /*0x7b820e8*/ bool get_allTrue();
            /*0x7b820f8*/ string get_humanizedData();
            /*0x7b821f0*/ bool get_Item(uint index);
            /*0x7b82210*/ void set_Item(uint index, bool value);
            /*0x7b82334*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b823cc*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b82464*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b824e4*/ bool Equals(object obj);
            /*0x7b8255c*/ int GetHashCode();
        }

        struct BitArray16 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ushort data;

            static /*0x7b82834*/ UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a);
            static /*0x7b82840*/ UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b8284c*/ UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b829e8*/ bool op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x7b829f8*/ bool op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            /*0x7b8277c*/ BitArray16(ushort initValue);
            /*0x7b82784*/ BitArray16(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b8257c*/ uint get_capacity();
            /*0x7b82584*/ bool get_allFalse();
            /*0x7b82594*/ bool get_allTrue();
            /*0x7b825a4*/ string get_humanizedData();
            /*0x7b82714*/ bool get_Item(uint index);
            /*0x7b82734*/ void set_Item(uint index, bool value);
            /*0x7b82858*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b828f0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b82988*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b82a08*/ bool Equals(object obj);
            /*0x7b82a80*/ int GetHashCode();
        }

        struct BitArray32 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ uint data;

            static /*0x7b82f54*/ UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a);
            static /*0x7b82eec*/ UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b82e4c*/ UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b82f5c*/ bool op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x7b82f68*/ bool op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            /*0x7b82cfc*/ BitArray32(uint initValue);
            /*0x7b82d04*/ BitArray32(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b82aa0*/ uint get_capacity();
            /*0x7b82aa8*/ bool get_allFalse();
            /*0x7b82ab8*/ bool get_allTrue();
            /*0x7b82ac8*/ string get_humanizedVersion();
            /*0x7b82b28*/ string get_humanizedData();
            /*0x7b82c98*/ bool get_Item(uint index);
            /*0x7b82cb4*/ void set_Item(uint index, bool value);
            /*0x7b82db4*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b82e54*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b82ef4*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b82f74*/ bool Equals(object obj);
            /*0x7b82fec*/ int GetHashCode();
        }

        struct BitArray64 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data;

            static /*0x7b832c0*/ UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a);
            static /*0x7b832c8*/ UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b832d0*/ UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b83468*/ bool op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x7b83474*/ bool op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            /*0x7b83208*/ BitArray64(ulong initValue);
            /*0x7b83210*/ BitArray64(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b8300c*/ uint get_capacity();
            /*0x7b83014*/ bool get_allFalse();
            /*0x7b83024*/ bool get_allTrue();
            /*0x7b83034*/ string get_humanizedData();
            /*0x7b831a4*/ bool get_Item(uint index);
            /*0x7b831c0*/ void set_Item(uint index, bool value);
            /*0x7b832d8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b83370*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b83408*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b83480*/ bool Equals(object obj);
            /*0x7b834f8*/ int GetHashCode();
        }

        struct BitArray128 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;

            static /*0x7b83894*/ UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a);
            static /*0x7b838a0*/ UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b838ac*/ UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b83a60*/ bool op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x7b83a78*/ bool op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            /*0x7b837b4*/ BitArray128(ulong initValue1, ulong initValue2);
            /*0x7b837bc*/ BitArray128(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b83518*/ uint get_capacity();
            /*0x7b83520*/ bool get_allFalse();
            /*0x7b83540*/ bool get_allTrue();
            /*0x7b83564*/ string get_humanizedData();
            /*0x7b83760*/ bool get_Item(uint index);
            /*0x7b83780*/ void set_Item(uint index, bool value);
            /*0x7b838b8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b8395c*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b83a00*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b83a90*/ bool Equals(object obj);
            /*0x7b83b20*/ int GetHashCode();
        }

        struct BitArray256 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;
            /*0x20*/ ulong data3;
            /*0x28*/ ulong data4;

            static /*0x7b8414c*/ UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a);
            static /*0x7b84160*/ UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b84194*/ UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b843ac*/ bool op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x7b843f8*/ bool op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            /*0x7b8402c*/ BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4);
            /*0x7b84038*/ BitArray256(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x7b83b68*/ uint get_capacity();
            /*0x7b83b70*/ bool get_allFalse();
            /*0x7b83ba0*/ bool get_allTrue();
            /*0x7b83bdc*/ string get_humanizedData();
            /*0x7b83edc*/ bool get_Item(uint index);
            /*0x7b83f60*/ void set_Item(uint index, bool value);
            /*0x7b841c8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x7b84288*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x7b84348*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x7b84444*/ bool Equals(object obj);
            /*0x7b8450c*/ int GetHashCode();
        }

        class BitArrayUtilities
        {
            static /*0x7b82200*/ bool Get8(uint index, byte data);
            static /*0x7b82724*/ bool Get16(uint index, ushort data);
            static /*0x7b82ca8*/ bool Get32(uint index, uint data);
            static /*0x7b831b4*/ bool Get64(uint index, ulong data);
            static /*0x7b84588*/ bool Get128(uint index, ulong data1, ulong data2);
            static /*0x7b83f24*/ bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4);
            static /*0x7b82234*/ void Set8(uint index, ref byte data, bool value);
            static /*0x7b82758*/ void Set16(uint index, ref ushort data, bool value);
            static /*0x7b82cd8*/ void Set32(uint index, ref uint data, bool value);
            static /*0x7b831e4*/ void Set64(uint index, ref ulong data, bool value);
            static /*0x7b8459c*/ void Set128(uint index, ref ulong data1, ref ulong data2, bool value);
            static /*0x7b83f84*/ void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value);
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

            static /*0x7b88468*/ Blitter();
            static /*0x7b845dc*/ void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS);
            static /*0x7b851ac*/ void Cleanup();
            static /*0x7b85324*/ UnityEngine.Material GetBlitMaterial(UnityEngine.Rendering.TextureDimension dimension, bool singleSlice);
            static /*0x7b853fc*/ void DrawTriangle(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b85474*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b854ec*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b85678*/ void DrawQuadMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b85774*/ void DrawQuad(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b85980*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x7b857f4*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x7b859f8*/ bool CanCopyMSAA();
            static /*0x7b85a68*/ void CopyTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isMSAA);
            static /*0x7b85af4*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear);
            static /*0x7b85c08*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass, float sourceMipLevel, int sourceDepthSlice);
            static /*0x7b85e80*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b85f38*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b860b8*/ void BlitTexture2D(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b86170*/ void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b862cc*/ void BlitColorAndDepth(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x7b8638c*/ void BlitColorAndDepth(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x7b8658c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b85d4c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b8663c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b86718*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b86874*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int pass);
            static /*0x7b86a0c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x7b86bbc*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b86cac*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x7b86d9c*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x7b86f98*/ void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x7b870f0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int pass);
            static /*0x7b87248*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x7b874e8*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x7b875e0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, float mipLevel, bool bilinear);
            static /*0x7b7d99c*/ void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear);
            static /*0x7b87778*/ void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b87a14*/ void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b87cb0*/ void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b87ee8*/ void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x7b7e1f4*/ void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b88120*/ void BlitCubeToOctahedral2DQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, System.Nullable<UnityEngine.Vector4> decodeInstructions);
            static /*0x7b7e660*/ void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b7e3ac*/ void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x7b84ecc*/ UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|14_0(float z);
            static /*0x7b84f80*/ UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|14_1();
            static /*0x7b85048*/ UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|14_2(float z);
            static /*0x7b850f0*/ UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|14_3();

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

                static /*0x7b884dc*/ BlitShaderIDs();
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

            static /*0x7b88d90*/ CameraCaptureBridge();
            static /*0x7b886f0*/ bool get_enabled();
            static /*0x7b88748*/ void set_enabled(bool value);
            static /*0x7b887a8*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera);
            static /*0x7b888bc*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCachedCaptureActionsEnumerator(UnityEngine.Camera camera);
            static /*0x7b88a04*/ void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
            static /*0x7b88c14*/ void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);

            class CameraEntry
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> actions;
                /*0x18*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> cachedEnumerator;

                /*0x7b88c0c*/ CameraEntry();
            }
        }

        class ColorSpaceUtils
        {
            static /*0x0*/ Unity.Mathematics.float3x3 Rec709ToRec2020Mat;
            static /*0x24*/ Unity.Mathematics.float3x3 Rec709ToP3D65Mat;
            static /*0x48*/ Unity.Mathematics.float3x3 Rec2020ToRec709Mat;
            static /*0x6c*/ Unity.Mathematics.float3x3 Rec2020ToP3D65Mat;
            static /*0x90*/ Unity.Mathematics.float3x3 P3D65ToRec2020Mat;

            static /*0x7b88e28*/ ColorSpaceUtils();
        }

        class ColorUtils
        {
            static /*0x0*/ float s_LightMeterCalibrationConstant;
            static /*0x4*/ float s_LensAttenuation;

            static /*0x7b89a54*/ ColorUtils();
            static /*0x7b88f2c*/ float get_lensImperfectionExposureScale();
            static /*0x7b88f9c*/ float StandardIlluminantY(float x);
            static /*0x7b88fc8*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
            static /*0x7b89058*/ UnityEngine.Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
            static /*0x7b891bc*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inMidtones, ref UnityEngine.Vector4 inHighlights);
            static /*0x7b893c4*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareLiftGammaGain(ref UnityEngine.Vector4 inLift, ref UnityEngine.Vector4 inGamma, ref UnityEngine.Vector4 inGain);
            static /*0x7b89670*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4> PrepareSplitToning(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inHighlights, float balance);
            static /*0x7b89638*/ float Luminance(ref UnityEngine.Color color);
            static /*0x7b896fc*/ float ComputeEV100(float aperture, float shutterSpeed, float ISO);
            static /*0x7b89788*/ float ConvertEV100ToExposure(float EV100);
            static /*0x7b897fc*/ float ConvertExposureToEV100(float exposure);
            static /*0x7b898b4*/ float ComputeEV100FromAvgLuminance(float avgLuminance);
            static /*0x7b89974*/ float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
            static /*0x7b899b0*/ uint ToHex(UnityEngine.Color c);
            static /*0x7b89a18*/ UnityEngine.Color ToRGBA(uint hex);
        }

        class CoreMatrixUtils
        {
            static /*0x7b89aa4*/ void MatrixTimesTranslation(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x7b89b00*/ void TranslationTimesMatrix(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x7b89b88*/ UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs);
            static /*0x7b89c3c*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x7b89ce0*/ UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x7b89dd0*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, bool centered);
            static /*0x7b89eb8*/ UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, bool orthoCentered);
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

            static /*0x7b8e1a0*/ CoreUtils();
            static /*0x7b89f80*/ UnityEngine.Cubemap get_blackCubeTexture();
            static /*0x7b8a0f0*/ UnityEngine.Cubemap get_magentaCubeTexture();
            static /*0x7b8a260*/ UnityEngine.CubemapArray get_magentaCubeTextureArray();
            static /*0x7b8a434*/ UnityEngine.Cubemap get_whiteCubeTexture();
            static /*0x7b8a5a4*/ UnityEngine.RenderTexture get_emptyUAV();
            static /*0x7b8a6e4*/ UnityEngine.GraphicsBuffer get_emptyBuffer();
            static /*0x7b8a7e4*/ UnityEngine.Texture3D get_blackVolumeTexture();
            static /*0x7b8a970*/ UnityEngine.Texture3D get_whiteVolumeTexture();
            static /*0x7b8aaf8*/ void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8ab1c*/ int FixupDepthSlice(int depthSlice, UnityEngine.Rendering.RTHandle buffer);
            static /*0x7b8ab60*/ int FixupDepthSlice(int depthSlice, UnityEngine.CubemapFace cubemapFace);
            static /*0x7b8ab74*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8ac84*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8ad54*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8af88*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8ae48*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8b088*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer);
            static /*0x7b8b224*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7b8b134*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8b2dc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8b3d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8b4d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8b5f4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7b8b6b4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8b7f0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8b960*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8badc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8bbe8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7b8bcf0*/ void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8be08*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b86ef4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8bf24*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8c100*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8bfcc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b873d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8c1ac*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7b8c30c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer);
            static /*0x7b8c3cc*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x7b8c490*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x7b8bd94*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target);
            static /*0x7b7c418*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.RenderTextureFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x7b8c804*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x7b7bb9c*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x7b8c58c*/ string GetRenderTargetAutoName(int width, int height, int depth, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x7b8c900*/ string GetTextureAutoName(int width, int height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7b8cdf8*/ string GetTextureAutoName(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7b8c9e8*/ string GetTextureAutoName(int width, int height, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x7b8cee0*/ void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips);
            static /*0x7b8d094*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d148*/ void DrawFullScreen(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d1c8*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d2a4*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d3ac*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d490*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x7b8d558*/ UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color);
            static /*0x7b8d5d4*/ UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color);
            static /*0x7b8d650*/ UnityEngine.Material CreateEngineMaterial(string shaderPath);
            static /*0x7b84dd4*/ UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader);
            static /*0x3907c14*/ bool HasFlag<T>(T mask, T flag);
            static /*0x383af28*/ void Swap<T>(ref T a, ref T b);
            static /*0x7b8d7cc*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, string keyword, bool state);
            static /*0x7b8d7ec*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x7b8d850*/ void SetKeyword(UnityEngine.Rendering.BaseCommandBuffer cmd, string keyword, bool state);
            static /*0x7b8d880*/ void SetKeyword(UnityEngine.Material material, string keyword, bool state);
            static /*0x7b8d8a0*/ void SetKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool state);
            static /*0x7b8d8c0*/ void SetKeyword(UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x7b775c4*/ void Destroy(UnityEngine.Object obj);
            static /*0x7b8d8e0*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
            static /*0x382dee4*/ System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
            static /*0x7b8da78*/ void SafeRelease(UnityEngine.GraphicsBuffer buffer);
            static /*0x7b8da88*/ void SafeRelease(UnityEngine.ComputeBuffer buffer);
            static /*0x7b8da98*/ UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x7b8de3c*/ bool ArePostProcessesEnabled(UnityEngine.Camera camera);
            static /*0x7b8de44*/ bool AreAnimatedMaterialsEnabled(UnityEngine.Camera camera);
            static /*0x7b8de4c*/ bool IsSceneLightingDisabled(UnityEngine.Camera camera);
            static /*0x7b8de54*/ bool IsLightOverlapDebugEnabled(UnityEngine.Camera camera);
            static /*0x7b8de5c*/ bool IsSceneViewFogEnabled(UnityEngine.Camera camera);
            static /*0x7b8de64*/ bool IsSceneFilteringEnabled();
            static /*0x7b8de6c*/ bool IsSceneViewPrefabStageContextHidden();
            static /*0x7b8de74*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
            static /*0x7b7eb74*/ int GetTextureHash(UnityEngine.Texture texture);
            static /*0x7b8dec0*/ int PreviousPowerOfTwo(int size);
            static /*0x7b8deec*/ int GetMipCount(int size);
            static /*0x7b7db9c*/ int GetMipCount(float size);
            static /*0x7b8dfac*/ int DivRoundUp(int value, int divisor);
            static /*0x3907c14*/ T GetLastEnumValue<T>();
            static /*0x7b8dfbc*/ string GetCorePath();
            static /*0x7b8dffc*/ UnityEngine.Vector3[] CalculateViewSpaceCorners(UnityEngine.Matrix4x4 proj, float z);

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

                static /*0x7b8e33c*/ <>c();
                /*0x7b8e3a4*/ <>c();
                /*0x7b8e3ac*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__97_0(System.Reflection.Assembly t);
            }

            class <>c__98<T>
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<>c__98<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__98_0;

                static /*0x38358cc*/ <>c__98();
                /*0x380cb08*/ <>c__98();
                /*0x380b2f0*/ bool <GetAllTypesDerivedFrom>b__98_0(System.Type t);
            }
        }

        class DelegateUtility
        {
            static /*0x7b8e490*/ System.Delegate Cast(System.Delegate source, System.Type type);
        }

        class FSRUtils
        {
            static float kMaxSharpnessStops = 2.5;
            static float kDefaultSharpnessStops = 0.20000000298023224;
            static float kDefaultSharpnessLinear = 0.9200000166893005;

            static /*0x7b8e630*/ void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x7b8e7b4*/ void SetEasuConstants(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x7b8e7cc*/ void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessStops);
            static /*0x7b8e878*/ void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessLinear);
            static /*0x7b8e88c*/ void SetRcasConstantsLinear(UnityEngine.Rendering.RasterCommandBuffer cmd, float sharpnessLinear);
            static /*0x7b8e8b4*/ bool IsSupported();

            class ShaderConstants
            {
                static /*0x0*/ int _FsrEasuConstants0;
                static /*0x4*/ int _FsrEasuConstants1;
                static /*0x8*/ int _FsrEasuConstants2;
                static /*0xc*/ int _FsrEasuConstants3;
                static /*0x10*/ int _FsrRcasConstants;

                static /*0x7b8e8d0*/ ShaderConstants();
            }
        }

        struct GPUPrefixSum
        {
            /*0x10*/ UnityEngine.Rendering.GPUPrefixSum.SystemResources resources;

            /*0x7b8e9f8*/ GPUPrefixSum(UnityEngine.Rendering.GPUPrefixSum.SystemResources resources);
            /*0x7b8ebdc*/ UnityEngine.Vector4 PackPrefixSumArgs(int a, int b, int c, int d);
            /*0x7b8ebf0*/ void ExecuteCommonIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.GraphicsBuffer inputBuffer, ref UnityEngine.Rendering.GPUPrefixSum.SupportResources supportResources, bool isExclusive);
            /*0x7b8ef70*/ void DispatchDirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.DirectArgs arguments);
            /*0x7b8f170*/ void DispatchIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.IndirectDirectArgs arguments);

            class ShaderDefs
            {
                static int GroupSize = 128;
                static int ArgsBufferStride = 16;
                static int ArgsBufferUpper = 0;
                static int ArgsBufferLower = 8;

                static /*0x7b8f370*/ int DivUpGroup(int value);
                static /*0x7b8f388*/ int AlignUpGroup(int value);
                static /*0x7b8f3a0*/ void CalculateTotalBufferSize(int maxElementCount, ref int totalSize, ref int levelCounts);
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

                static /*0x7b8f428*/ UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources Create(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
                /*0x7b8f418*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_output();
                /*0x7b8f484*/ void Initialize(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
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

                static /*0x7b8f80c*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Create(int maxElementCount);
                static /*0x7b8fb24*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Load(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                static /*0x7b8fd10*/ void <Dispose>g__TryFreeBuffer|15_0(UnityEngine.GraphicsBuffer resource);
                /*0x7b8f804*/ UnityEngine.GraphicsBuffer get_output();
                /*0x7b8f878*/ void Resize(int newMaxElementCount);
                /*0x7b8fb80*/ void LoadFromShaderGraph(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                /*0x7b8fc98*/ void Dispose();
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

                /*0x7b8ea24*/ void LoadKernels();
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

                static /*0x7b8fd20*/ ShaderIDs();
            }
        }

        struct GPUSort
        {
            static uint kWorkGroupSize = 1024;
            /*0x10*/ UnityEngine.Rendering.LocalKeyword[] m_Keywords;
            /*0x18*/ UnityEngine.Rendering.GPUSort.SystemResources resources;

            static /*0x7b905b0*/ int DivRoundUp(int x, int y);
            /*0x7b8ff08*/ GPUSort(UnityEngine.Rendering.GPUSort.SystemResources resources);
            /*0x7b90134*/ void DispatchStage(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args, uint h, UnityEngine.Rendering.GPUSort.Stage stage);
            /*0x7b903f4*/ void CopyBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst);
            /*0x7b905c0*/ void Dispatch(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args);

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

                static /*0x7b907a8*/ UnityEngine.Rendering.GPUSort.RenderGraphResources Create(int count, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder);
            }

            struct SupportResources
            {
                /*0x10*/ UnityEngine.GraphicsBuffer sortBufferKeys;
                /*0x18*/ UnityEngine.GraphicsBuffer sortBufferValues;

                static /*0x7b908c4*/ UnityEngine.Rendering.GPUSort.SupportResources Load(UnityEngine.Rendering.GPUSort.RenderGraphResources renderGraphResources);
                /*0x7b90970*/ void Dispose();
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

            /*0x7b90a04*/ HableCurve();
            /*0x7b909c4*/ float get_whitePoint();
            /*0x7b909cc*/ void set_whitePoint(float value);
            /*0x7b909d4*/ float get_inverseWhitePoint();
            /*0x7b909dc*/ void set_inverseWhitePoint(float value);
            /*0x7b909e4*/ float get_x0();
            /*0x7b909ec*/ void set_x0(float value);
            /*0x7b909f4*/ float get_x1();
            /*0x7b909fc*/ void set_x1(float value);
            /*0x7b90b94*/ float Eval(float x);
            /*0x7b90ca0*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
            /*0x7b90db8*/ void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams);
            /*0x7b910d0*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
            /*0x7b9106c*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
            /*0x7b91098*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

            class Segment
            {
                /*0x10*/ float offsetX;
                /*0x14*/ float offsetY;
                /*0x18*/ float scaleX;
                /*0x1c*/ float scaleY;
                /*0x20*/ float lnA;
                /*0x24*/ float B;

                /*0x7b90b5c*/ Segment();
                /*0x7b90c44*/ float Eval(float x);
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

                /*0x7b90b64*/ Uniforms(UnityEngine.Rendering.HableCurve parent);
                /*0x7b91120*/ UnityEngine.Vector4 get_curve();
                /*0x7b91144*/ UnityEngine.Vector4 get_toeSegmentA();
                /*0x7b91180*/ UnityEngine.Vector4 get_toeSegmentB();
                /*0x7b911c0*/ UnityEngine.Vector4 get_midSegmentA();
                /*0x7b91200*/ UnityEngine.Vector4 get_midSegmentB();
                /*0x7b91244*/ UnityEngine.Vector4 get_shoSegmentA();
                /*0x7b91284*/ UnityEngine.Vector4 get_shoSegmentB();
            }
        }

        class HaltonSequence
        {
            static /*0x7b912c8*/ float Get(int index, int radix);
        }

        struct HashFNV1A32
        {
            static uint k_Prime = 16777619;
            static uint k_OffsetBasis = 2166136261;
            /*0x10*/ uint m_Hash;

            static /*0x7b9130c*/ UnityEngine.Rendering.HashFNV1A32 Create();
            static /*0x7b91604*/ int GetFuncHashCode(System.Delegate del);
            /*0x7b91318*/ void Append(ref int input);
            /*0x7b91338*/ void Append(ref uint input);
            /*0x7b91358*/ void Append(ref bool input);
            /*0x7b91380*/ void Append(ref float input);
            /*0x7b913bc*/ void Append(ref double input);
            /*0x7b913f4*/ void Append(ref UnityEngine.Vector2 input);
            /*0x7b9145c*/ void Append(ref UnityEngine.Vector3 input);
            /*0x7b914f0*/ void Append(ref UnityEngine.Vector4 input);
            /*0x3907c14*/ void Append<T>(T input);
            /*0x7b91594*/ void Append(System.Delegate del);
            /*0x7b9164c*/ int get_value();
            /*0x7b91654*/ int GetHashCode();
        }

        class HDROutputUtils
        {
            static /*0x7b9165c*/ bool GetColorSpaceForGamut(UnityEngine.ColorGamut gamut, ref int colorspace);
            static /*0x7b91870*/ bool GetColorEncodingForGamut(UnityEngine.ColorGamut gamut, ref int encoding);
            static /*0x7b919f4*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7b91c58*/ void ConfigureHDROutput(UnityEngine.MaterialPropertyBlock properties, UnityEngine.ColorGamut gamut);
            static /*0x7b91d18*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7b91ef0*/ void ConfigureHDROutput(UnityEngine.ComputeShader computeShader, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x7b92154*/ bool IsShaderVariantValid(UnityEngine.Rendering.ShaderKeywordSet shaderKeywordSet, bool isHDREnabled);

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

                /*0x7b92260*/ HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits);
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

                static /*0x7b92270*/ ShaderKeywords();
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int hdrColorSpace;
                static /*0x4*/ int hdrEncoding;

                static /*0x7b923e4*/ ShaderPropertyId();
            }
        }

        class LightUnitUtils
        {
            static float SphereSolidAngle = 12.566370964050293;

            static /*0x7b92480*/ float get_k_LuminanceToEvFactor();
            static /*0x7b92538*/ float get_k_EvToLuminanceFactor();
            static /*0x7b9254c*/ UnityEngine.Rendering.LightUnit GetNativeLightUnit(UnityEngine.LightType lightType);
            static /*0x7b925a0*/ bool IsLightUnitSupported(UnityEngine.LightType lightType, UnityEngine.Rendering.LightUnit lightUnit);
            static /*0x7b92604*/ float GetSolidAngleFromPointLight();
            static /*0x7b92610*/ float GetSolidAngleFromSpotLight(float spotAngle);
            static /*0x7b926a8*/ float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio);
            static /*0x7b92780*/ float GetSolidAngle(UnityEngine.LightType lightType, bool spotReflector, float spotAngle, float aspectRatio);
            static /*0x7b92864*/ float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY);
            static /*0x7b9287c*/ float GetAreaFromRectangleLight(UnityEngine.Vector2 rectSize);
            static /*0x7b92894*/ float GetAreaFromDiscLight(float discRadius);
            static /*0x7b928ac*/ float GetAreaFromTubeLight(float tubeLength);
            static /*0x7b928c8*/ float LumenToCandela(float lumen, float solidAngle);
            static /*0x7b928d0*/ float CandelaToLumen(float candela, float solidAngle);
            static /*0x7b928d8*/ float LumenToNits(float lumen, float area);
            static /*0x7b928e0*/ float NitsToLumen(float nits, float area);
            static /*0x7b928e8*/ float LuxToCandela(float lux, float distance);
            static /*0x7b928f4*/ float CandelaToLux(float candela, float distance);
            static /*0x7b92900*/ float Ev100ToNits(float ev100);
            static /*0x7b92920*/ float NitsToEv100(float nits);
            static /*0x7b9298c*/ float Ev100ToCandela(float ev100);
            static /*0x7b929ac*/ float CandelaToEv100(float candela);
            static /*0x7b929b0*/ float ConvertIntensityInternal(float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit, UnityEngine.LightType lightType, float area, float luxAtDistance, float solidAngle);
            static /*0x7b92ef0*/ float ConvertIntensity(UnityEngine.Light light, float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit);
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

            static /*0x7b9344c*/ MaterialQualityUtilities();
            static /*0x7b93044*/ UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels);
            static /*0x7b930d0*/ UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel);
            static /*0x7b93290*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level);
            static /*0x7b93368*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd);
            static /*0x7b931f8*/ int ToFirstIndex(UnityEngine.Rendering.MaterialQuality level);
            static /*0x7b93284*/ UnityEngine.Rendering.MaterialQuality FromIndex(int index);
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

            static /*0x7b940d8*/ MeshGizmo();
            /*0x7b93714*/ MeshGizmo(int capacity);
            /*0x7b938bc*/ void Clear();
            /*0x7b9394c*/ void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color);
            /*0x7b93e94*/ void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x7b9403c*/ void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x7b9407c*/ void Dispose();
            /*0x7b93ba0*/ void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, ref UnityEngine.Rendering.MeshGizmo.<> );

            struct <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Rendering.MeshGizmo <>4__this;
                /*0x18*/ UnityEngine.Color color;
            }
        }

        class SceneRenderPipeline : UnityEngine.MonoBehaviour
        {
            /*0x7b94124*/ SceneRenderPipeline();
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

            static /*0x7b9439c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x7b9417c*/ TextureCurve(UnityEngine.AnimationCurve baseCurve, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x7b941d0*/ TextureCurve(UnityEngine.Keyframe[] keys, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x7b9412c*/ int get_length();
            /*0x7b94134*/ void set_length(int value);
            /*0x7b9413c*/ UnityEngine.Keyframe get_Item(int index);
            /*0x7b942e4*/ void Dispose();
            /*0x7b942e8*/ void Release();
            /*0x7b94390*/ void SetDirty();
            /*0x7b943e8*/ UnityEngine.Texture2D GetTexture();
            /*0x7b945f0*/ float Evaluate(float time);
            /*0x7b94828*/ int AddKey(float time, float value);
            /*0x7b94860*/ int MoveKey(int index, ref UnityEngine.Keyframe key);
            /*0x7b948b8*/ void RemoveKey(int index);
            /*0x7b948e4*/ void SmoothTangents(int index, float weight);
        }

        class TextureCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureCurve>
        {
            /*0x7b94910*/ TextureCurveParameter(UnityEngine.Rendering.TextureCurve value, bool overrideState);
            /*0x7b94970*/ void Release();
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

            static /*0x7b94fd4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x7b949c0*/ TextureGradient(UnityEngine.Gradient baseCurve);
            /*0x7b94ab0*/ TextureGradient(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x7b94988*/ int get_textureSize();
            /*0x7b94990*/ void set_textureSize(int value);
            /*0x7b94998*/ UnityEngine.GradientColorKey[] get_colorKeys();
            /*0x7b949ac*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
            /*0x7b94b28*/ void Rebuild(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x7b94f1c*/ void Dispose();
            /*0x7b94f20*/ void Release();
            /*0x7b94fc8*/ void SetDirty();
            /*0x7b94fdc*/ UnityEngine.Texture2D GetTexture();
            /*0x7b9527c*/ UnityEngine.Color Evaluate(float time);
            /*0x7b952bc*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace);
        }

        class TextureGradientParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureGradient>
        {
            /*0x7b95344*/ TextureGradientParameter(UnityEngine.Rendering.TextureGradient value, bool overrideState);
            /*0x7b953a4*/ void Release();
        }

        class TileLayoutUtils
        {
            static /*0x7b953bc*/ bool TryLayoutByTiles(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt topRow, ref UnityEngine.RectInt rightCol, ref UnityEngine.RectInt topRight);
            static /*0x7b95464*/ bool TryLayoutByRow(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
            static /*0x7b954c4*/ bool TryLayoutByCol(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
        }

        interface IVolume
        {
            /*0x380b128*/ bool get_isGlobal();
            /*0x380cdf0*/ void set_isGlobal(bool value);
            /*0x380b9e8*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
        }

        class KeyframeUtility
        {
            static /*0x7b95524*/ void ResetAnimationCurve(UnityEngine.AnimationCurve curve);
            static /*0x7b95538*/ UnityEngine.Keyframe LerpSingleKeyframe(UnityEngine.Keyframe lhs, UnityEngine.Keyframe rhs, float t);
            static /*0x7b956f4*/ UnityEngine.Keyframe GetKeyframeAndClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index);
            static /*0x7b95808*/ UnityEngine.Keyframe FetchKeyFromIndexClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index, float segmentStartTime, float segmentEndTime);
            static /*0x7b95994*/ void EvalCurveSegmentAndDeriv(ref float dstValue, ref float dstDeriv, UnityEngine.Keyframe lhsKey, UnityEngine.Keyframe rhsKey, float desiredTime);
            static /*0x7b95b20*/ UnityEngine.Keyframe EvalKeyAtTime(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime);
            static /*0x7b95c0c*/ void InterpAnimationCurve(ref UnityEngine.AnimationCurve lhsAndResultCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x7b962b8*/ KeyframeUtility();
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

            /*0x7b96974*/ Volume();
            /*0x7b962c0*/ bool get_isGlobal();
            /*0x7b962c8*/ void set_isGlobal(bool value);
            /*0x7b962d4*/ UnityEngine.Rendering.VolumeProfile get_profile();
            /*0x7b965bc*/ void set_profile(UnityEngine.Rendering.VolumeProfile value);
            /*0x7b965c4*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
            /*0x7b965cc*/ UnityEngine.Rendering.VolumeProfile get_profileRef();
            /*0x7b96644*/ bool HasInstantiatedProfile();
            /*0x7b966a4*/ void OnEnable();
            /*0x7b9674c*/ void OnDisable();
            /*0x7b967b4*/ void Update();
            /*0x7b967cc*/ void UpdateLayer();
            /*0x7b9686c*/ void UpdatePriority();
            /*0x7b96960*/ void OnValidate();
        }

        class VolumeCollection
        {
            static int k_MaxLayerCount = 32;
            /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;
            /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;

            static /*0x7b972a8*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes);
            /*0x7b976bc*/ VolumeCollection();
            /*0x7b96a0c*/ int get_count();
            /*0x7b96a54*/ bool Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b96f4c*/ bool Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x7b971b0*/ bool ChangeLayer(UnityEngine.Rendering.Volume volume, int previousLayerIndex, int currentLayerIndex);
            /*0x7b973dc*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);
            /*0x7b96dc8*/ void SetLayerIndexDirty(int layerIndex);
            /*0x3907c14*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
        }

        class VolumeComponentMenu : System.Attribute
        {
            /*0x10*/ string menu;

            /*0x7b977ec*/ VolumeComponentMenu(string menu);
        }

        class VolumeComponentMenuForRenderPipeline : UnityEngine.Rendering.VolumeComponentMenu
        {
            /*0x18*/ System.Type[] <pipelineTypes>k__BackingField;

            /*0x7b97824*/ VolumeComponentMenuForRenderPipeline(string menu, System.Type[] pipelineTypes);
            /*0x7b9781c*/ System.Type[] get_pipelineTypes();
        }

        class VolumeComponentDeprecated : System.Attribute
        {
            /*0x7b979fc*/ VolumeComponentDeprecated();
        }

        class VolumeComponent : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool active;
            /*0x20*/ string <displayName>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameterList;
            /*0x30*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> m_ParameterReadOnlyCollection;

            static /*0x7b97a88*/ void FindParameters(object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo, bool> filter);
            /*0x7b98c88*/ VolumeComponent();
            /*0x7b97a04*/ string get_displayName();
            /*0x7b97a0c*/ void set_displayName(string value);
            /*0x7b97a14*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x7b980b4*/ void OnEnable();
            /*0x7b982f8*/ void OnDisable();
            /*0x7b98440*/ void Override(UnityEngine.Rendering.VolumeComponent state, float interpFactor);
            /*0x7b98564*/ void SetAllOverridesTo(bool state);
            /*0x7b98574*/ void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, bool state);
            /*0x7b98a8c*/ int GetHashCode();
            /*0x7b98b38*/ bool AnyPropertiesIsOverridden();
            /*0x7b98bdc*/ void OnDestroy();
            /*0x7b98be0*/ void Release();

            class Indent : UnityEngine.PropertyAttribute
            {
                /*0x18*/ int relativeAmount;

                /*0x7b98d3c*/ Indent(int relativeAmount);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeComponent.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__10_0;

                static /*0x7b98d64*/ <>c();
                /*0x7b98dcc*/ <>c();
                /*0x7b98dd4*/ int <FindParameters>b__10_0(System.Reflection.FieldInfo t);
            }
        }

        struct VolumeIsolationScope : System.IDisposable
        {
            /*0x7b98dfc*/ VolumeIsolationScope(bool unused);
            /*0x7b98e00*/ void System.IDisposable.Dispose();
        }

        class VolumeParameter : System.ICloneable
        {
            static string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
            /*0x10*/ bool m_OverrideState;

            static /*0x7b98960*/ bool IsObjectParameter(System.Type type);
            /*0x7b98e24*/ VolumeParameter();
            /*0x7b98e04*/ bool get_overrideState();
            /*0x7b98e0c*/ void set_overrideState(bool value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x3907c14*/ T GetValue<T>();
            /*0x380d83c*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x7b98e18*/ void OnEnable();
            /*0x7b98e1c*/ void OnDisable();
            /*0x7b98e20*/ void Release();
            /*0x380b9e8*/ object Clone();
        }

        class VolumeParameter<T> : UnityEngine.Rendering.VolumeParameter, System.IEquatable<UnityEngine.Rendering.VolumeParameter<T>>
        {
            /*0x0*/ T m_Value;

            static /*0x3907c14*/ bool op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x3907c14*/ bool op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x3907c14*/ T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop);
            /*0x380cb08*/ VolumeParameter();
            /*0x3907c14*/ VolumeParameter(T value, bool overrideState);
            /*0x3907c14*/ T get_value();
            /*0x3907c14*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x3907c14*/ void Interp(T from, T to, float t);
            /*0x3907c14*/ void Override(T x);
            /*0x380d83c*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x380b6a0*/ int GetHashCode();
            /*0x380b9e8*/ string ToString();
            /*0x380b2f0*/ bool Equals(UnityEngine.Rendering.VolumeParameter<T> other);
            /*0x380b2f0*/ bool Equals(object obj);
            /*0x380b9e8*/ object Clone();
        }

        class EnumParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x3907c14*/ EnumParameter(T value, bool overrideState);
        }

        class BoolParameter : UnityEngine.Rendering.VolumeParameter<bool>
        {
            /*0x14*/ UnityEngine.Rendering.BoolParameter.DisplayType displayType;

            /*0x7b98e2c*/ BoolParameter(bool value, bool overrideState);
            /*0x7b98e8c*/ BoolParameter(bool value, UnityEngine.Rendering.BoolParameter.DisplayType displayType, bool overrideState);

            enum DisplayType
            {
                Checkbox = 0,
                EnumPopup = 1,
            }
        }

        class LayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.LayerMask>
        {
            /*0x7b98f00*/ LayerMaskParameter(UnityEngine.LayerMask value, bool overrideState);
        }

        class RenderingLayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderingLayerMask>
        {
            /*0x7b98f60*/ RenderingLayerMaskParameter(UnityEngine.RenderingLayerMask value, bool overrideState);
        }

        class IntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x7b98fc0*/ IntParameter(int value, bool overrideState);
            /*0x7b99020*/ void Interp(int from, int to, float t);
        }

        class NoInterpIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x7b99054*/ NoInterpIntParameter(int value, bool overrideState);
        }

        class MinIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;

            /*0x7b990d0*/ MinIntParameter(int value, int min, bool overrideState);
            /*0x7b990b4*/ int get_value();
            /*0x7b990bc*/ void set_value(int value);
        }

        class NoInterpMinIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;

            /*0x7b99114*/ NoInterpMinIntParameter(int value, int min, bool overrideState);
            /*0x7b990f8*/ int get_value();
            /*0x7b99100*/ void set_value(int value);
        }

        class MaxIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int max;

            /*0x7b991a4*/ MaxIntParameter(int value, int max, bool overrideState);
            /*0x7b99188*/ int get_value();
            /*0x7b99190*/ void set_value(int value);
        }

        class NoInterpMaxIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int max;

            /*0x7b991e8*/ NoInterpMaxIntParameter(int value, int max, bool overrideState);
            /*0x7b991cc*/ int get_value();
            /*0x7b991d4*/ void set_value(int value);
        }

        class ClampedIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x7b99280*/ ClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x7b9925c*/ int get_value();
            /*0x7b99264*/ void set_value(int value);
        }

        class NoInterpClampedIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x7b992d0*/ NoInterpClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x7b992ac*/ int get_value();
            /*0x7b992b4*/ void set_value(int value);
        }

        class FloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x7b99348*/ FloatParameter(float value, bool overrideState);
            /*0x7b993b0*/ void Interp(float from, float to, float t);
        }

        class NoInterpFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x7b993c4*/ NoInterpFloatParameter(float value, bool overrideState);
        }

        class MinFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;

            /*0x7b99448*/ MinFloatParameter(float value, float min, bool overrideState);
            /*0x7b9942c*/ float get_value();
            /*0x7b99434*/ void set_value(float value);
        }

        class NoInterpMinFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;

            /*0x7b9948c*/ NoInterpMinFloatParameter(float value, float min, bool overrideState);
            /*0x7b99470*/ float get_value();
            /*0x7b99478*/ void set_value(float value);
        }

        class MaxFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float max;

            /*0x7b9951c*/ MaxFloatParameter(float value, float max, bool overrideState);
            /*0x7b99500*/ float get_value();
            /*0x7b99508*/ void set_value(float value);
        }

        class NoInterpMaxFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float max;

            /*0x7b99560*/ NoInterpMaxFloatParameter(float value, float max, bool overrideState);
            /*0x7b99544*/ float get_value();
            /*0x7b9954c*/ void set_value(float value);
        }

        class ClampedFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x7b995f8*/ ClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x7b995d4*/ float get_value();
            /*0x7b995dc*/ void set_value(float value);
        }

        class NoInterpClampedFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x7b99648*/ NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x7b99624*/ float get_value();
            /*0x7b9962c*/ void set_value(float value);
        }

        class FloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x7b996ec*/ FloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x7b996c8*/ UnityEngine.Vector2 get_value();
            /*0x7b996d0*/ void set_value(UnityEngine.Vector2 value);
            /*0x7b99774*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpFloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x7b997b8*/ NoInterpFloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x7b99794*/ UnityEngine.Vector2 get_value();
            /*0x7b9979c*/ void set_value(UnityEngine.Vector2 value);
        }

        class ColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x7b99840*/ ColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x7b998d0*/ ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
            /*0x7b999a4*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
        }

        class NoInterpColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x7b999d4*/ NoInterpColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x7b99a64*/ NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
        }

        class Vector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x7b99b38*/ Vector2Parameter(UnityEngine.Vector2 value, bool overrideState);
            /*0x7b99ba8*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpVector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x7b99bc8*/ NoInterpVector2Parameter(UnityEngine.Vector2 value, bool overrideState);
        }

        class Vector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x7b99c38*/ Vector3Parameter(UnityEngine.Vector3 value, bool overrideState);
            /*0x7b99cb8*/ void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float t);
        }

        class NoInterpVector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x7b99ce8*/ NoInterpVector3Parameter(UnityEngine.Vector3 value, bool overrideState);
        }

        class Vector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x7b99d68*/ Vector4Parameter(UnityEngine.Vector4 value, bool overrideState);
            /*0x7b99df0*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
        }

        class NoInterpVector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x7b99e20*/ NoInterpVector4Parameter(UnityEngine.Vector4 value, bool overrideState);
        }

        class TextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x20*/ UnityEngine.Rendering.TextureDimension dimension;

            /*0x7b99ea8*/ TextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7b99eb4*/ TextureParameter(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, bool overrideState);
            /*0x7b99f28*/ int GetHashCode();
        }

        class NoInterpTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7b9a02c*/ NoInterpTextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7b9a08c*/ int GetHashCode();
        }

        class Texture2DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7b9a190*/ Texture2DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7b9a1f0*/ int GetHashCode();
        }

        class Texture3DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7b9a2f4*/ Texture3DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7b9a354*/ int GetHashCode();
        }

        class RenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x7b9a458*/ RenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x7b9a4b8*/ int GetHashCode();
        }

        class NoInterpRenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x7b9a5bc*/ NoInterpRenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x7b9a61c*/ int GetHashCode();
        }

        class CubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x7b9a720*/ CubemapParameter(UnityEngine.Texture value, bool overrideState);
            /*0x7b9a780*/ int GetHashCode();
        }

        class NoInterpCubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Cubemap>
        {
            /*0x7b9a884*/ NoInterpCubemapParameter(UnityEngine.Cubemap value, bool overrideState);
            /*0x7b9a8e4*/ int GetHashCode();
        }

        class ObjectParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            /*0x3907c14*/ ObjectParameter(T value);
            /*0x380b9e8*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x380d83c*/ void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            /*0x380b128*/ bool get_overrideState();
            /*0x380cdf0*/ void set_overrideState(bool value);
            /*0x3907c14*/ T get_value();
            /*0x3907c14*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x380bb68*/ UnityEngine.Rendering.VolumeParameter <set_value>b__9_2(System.Reflection.FieldInfo t);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ObjectParameter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__9_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, int> <>9__9_1;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380b2f0*/ bool <set_value>b__9_0(System.Reflection.FieldInfo t);
                /*0x380b7a8*/ int <set_value>b__9_1(System.Reflection.FieldInfo t);
            }
        }

        class AnimationCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.AnimationCurve>
        {
            /*0x7b9a9e8*/ AnimationCurveParameter(UnityEngine.AnimationCurve value, bool overrideState);
            /*0x7b9aa48*/ void Interp(UnityEngine.AnimationCurve lhsCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x7b9aa88*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x7b9ab18*/ object Clone();
            /*0x7b9abf8*/ int GetHashCode();
        }

        class MaterialParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Material>
        {
            /*0x7b9ac84*/ MaterialParameter(UnityEngine.Material value, bool overrideState);
        }

        class VolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;
            /*0x20*/ bool isDirty;

            /*0x7b9b700*/ VolumeProfile();
            /*0x7b9ace4*/ void OnEnable();
            /*0x7b9ade8*/ void OnDisable();
            /*0x7b9aecc*/ void Reset();
            /*0x3907c14*/ T Add<T>(bool overrides);
            /*0x7b9aed8*/ UnityEngine.Rendering.VolumeComponent Add(System.Type type, bool overrides);
            /*0x380cb08*/ void Remove<T>();
            /*0x7b9b208*/ void Remove(System.Type type);
            /*0x380b128*/ bool Has<T>();
            /*0x7b9b060*/ bool Has(System.Type type);
            /*0x7b9b314*/ bool HasSubclassOf(System.Type type);
            /*0x380b2f0*/ bool TryGet<T>(ref T component);
            /*0x380b32c*/ bool TryGet<T>(System.Type type, ref T component);
            /*0x380b32c*/ bool TryGetSubclassOf<T>(System.Type type, ref T component);
            /*0x380b32c*/ bool TryGetAllSubclassOf<T>(System.Type type, System.Collections.Generic.List<T> result);
            /*0x7b9b4a4*/ int GetHashCode();
            /*0x7b9b550*/ int GetComponentListHashCode();
            /*0x7b9b608*/ void Sanitize();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeProfile.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.VolumeComponent> <>9__2_0;

                static /*0x7b9b790*/ <>c();
                /*0x7b9b7f8*/ <>c();
                /*0x7b9b800*/ bool <OnEnable>b__2_0(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class VolumeStack : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.VolumeComponent> components;
            /*0x18*/ UnityEngine.Rendering.VolumeParameter[] parameters;
            /*0x20*/ bool requiresReset;
            /*0x21*/ bool requiresResetForAllProperties;
            /*0x22*/ bool <isValid>k__BackingField;

            /*0x7b9b85c*/ VolumeStack();
            /*0x7b9b8ec*/ void Clear();
            /*0x7b9ba98*/ void Reload(System.Type[] componentTypes);
            /*0x3907c14*/ T GetComponent<T>();
            /*0x7b9bc6c*/ UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type);
            /*0x7b9bcdc*/ void Dispose();
            /*0x7b9bcf4*/ bool get_isValid();
            /*0x7b9bcfc*/ void set_isValid(bool value);
        }

        class XRGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;
            static /*0x1*/ bool running;

            static /*0x7b9c2d4*/ XRGraphicsAutomatedTests();
            static /*0x7b9bd08*/ bool get_activatedFromCommandLine();
            static /*0x7b9bd10*/ bool get_enabled();
            static /*0x7b9bd68*/ void OverrideLayout(UnityEngine.Experimental.Rendering.XRLayout layout, UnityEngine.Camera camera);
        }

        class XRSRPSettings
        {
            static /*0x7b9c31c*/ bool get_enabled();
            static /*0x7b9c324*/ bool get_isDeviceActive();
            static /*0x7b9c34c*/ string get_loadedDeviceName();
            static /*0x7b9c39c*/ string[] get_supportedDevices();
            static /*0x7b9c3f0*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x7b9c468*/ int get_eyeTextureWidth();
            static /*0x7b9c490*/ int get_eyeTextureHeight();
            static /*0x7b9c4b8*/ float get_occlusionMeshScale();
            static /*0x7b9c550*/ void set_occlusionMeshScale(float value);
            static /*0x7b9c5f0*/ int get_mirrorViewMode();
            static /*0x7b9c650*/ void set_mirrorViewMode(int value);
            /*0x7b9c6c0*/ XRSRPSettings();
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

                /*0x7b9d128*/ RenderGraphDebugParams();
                /*0x7b9c6c8*/ void Reset();
                /*0x7b9c6d4*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList(string name);
                /*0x7b9ce5c*/ bool IsImmediateModeSupported();
                /*0x7b9cf34*/ void RegisterDebug(string name, UnityEngine.Rendering.DebugUI.Panel debugPanel);
                /*0x7b9d070*/ void UnRegisterDebug(string name);
                /*0x7b9d0f0*/ bool get_AreAnySettingsActive();
                /*0x7b9d130*/ bool <GetWidgetList>b__11_0();
                /*0x7b9d138*/ void <GetWidgetList>b__11_1(bool value);
                /*0x7b9d144*/ bool <GetWidgetList>b__11_2();
                /*0x7b9d14c*/ void <GetWidgetList>b__11_3(bool value);
                /*0x7b9d158*/ bool <GetWidgetList>b__11_4();
                /*0x7b9d160*/ void <GetWidgetList>b__11_5(bool value);
                /*0x7b9d16c*/ bool <GetWidgetList>b__11_6();
                /*0x7b9d174*/ void <GetWidgetList>b__11_7(bool value);
                /*0x7b9d180*/ bool <GetWidgetList>b__11_8();
                /*0x7b9d198*/ bool <GetWidgetList>b__11_9();
                /*0x7b9d1a0*/ void <GetWidgetList>b__11_10(bool value);
                /*0x7b9d1ac*/ void <GetWidgetList>b__11_11();
                /*0x7b9d22c*/ void <GetWidgetList>b__11_12();

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

                    static /*0x7b9d2ac*/ Strings();
                }
            }

            interface IBaseRenderGraphBuilder : System.IDisposable
            {
                /*0x380d8b8*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x380d0e4*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x380cdf0*/ void UseAllGlobalTextures(bool enable);
                /*0x380d8b8*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x380d83c*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x380cdf0*/ void EnableAsyncCompute(bool value);
                /*0x380cdf0*/ void AllowPassCulling(bool value);
                /*0x380cdf0*/ void AllowGlobalStateModification(bool value);
                /*0x380cdf0*/ void EnableFoveatedRasterization(bool value);
            }

            interface IComputeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
            }

            interface IUnsafeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
            }

            interface IRasterRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x7b9d658*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7b9d728*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7b9d7f8*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
            }

            interface IRenderGraphEnabledRenderPipeline
            {
                /*0x380b128*/ bool get_isImmediateModeSupported();
            }

            interface IRenderGraphRecorder
            {
                /*0x380d93c*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
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

                static /*0x7ba7cf8*/ RenderGraph();
                static /*0x7b9dd84*/ bool get_isRenderGraphViewerActive();
                static /*0x7b9dddc*/ void set_isRenderGraphViewerActive(bool value);
                static /*0x7b9de3c*/ bool get_enableValidityChecks();
                static /*0x7b9de94*/ void set_enableValidityChecks(bool value);
                static /*0x7b9e880*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs();
                static /*0x7ba0848*/ void add_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7ba0924*/ void remove_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7ba0a00*/ void add_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7ba0adc*/ void remove_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x7ba0bb8*/ void add_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7ba0c94*/ void remove_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7ba0d70*/ void add_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7ba0e4c*/ void remove_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x7ba0f28*/ void add_onDebugDataCaptured(System.Action value);
                static /*0x7ba1004*/ void remove_onDebugDataCaptured(System.Action value);
                /*0x7b9defc*/ RenderGraph(string name);
                /*0x7b9d8c0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler CompileNativeRenderGraph(int graphHash);
                /*0x7b9dbd0*/ void ExecuteNativeRenderGraph();
                /*0x7b9dd58*/ bool get_nativeRenderPassesEnabled();
                /*0x7b9dd60*/ void set_nativeRenderPassesEnabled(bool value);
                /*0x7b9dd6c*/ string get_name();
                /*0x7b9dd74*/ void set_name(string value);
                /*0x7b9dd7c*/ void RequestCaptureDebugData(string executionName);
                /*0x7b9def4*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7b9e6c8*/ void Cleanup();
                /*0x7b9e7d0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams get_debugParams();
                /*0x7b9e7d8*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList();
                /*0x7b9e7f8*/ bool get_areAnySettingsActive();
                /*0x7b9e844*/ void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x7b9e868*/ void UnRegisterDebug();
                /*0x7b9e8d8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData GetDebugData(string executionName);
                /*0x7b9e950*/ void EndFrame();
                /*0x7b9ea18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                /*0x7b9ea44*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7b9ea70*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7b9eac0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x7b9eaec*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7b9eb38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                /*0x7b9ebb0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7b9ebd0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x7b9ec40*/ void RefreshSharedTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7b9ec74*/ void ReleaseSharedTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7b9ecf4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7b9ed70*/ void CreateTextureIfInvalid(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7b9ee98*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7b9eee4*/ UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo GetRenderTargetInfo(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7b9ef34*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7b9ef58*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x7b9ef7c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawingSettings);
                /*0x7b9efb0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7b9efe8*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x7b9f02c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x7b9f064*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x7b9f098*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera);
                /*0x7b9f0cc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x7b9f154*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x7b9f224*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x7b8f7dc*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7b9f24c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x7b9f2b0*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x7b9f2f4*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3907c14*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x7b9f318*/ void BeginRecording(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphParameters parameters);
                /*0x7b9f820*/ void EndRecordingAndExecute();
                /*0x7b9f824*/ void Execute();
                /*0x7ba00c4*/ void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x7ba02f8*/ void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x7ba052c*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos();
                /*0x7ba0548*/ void ClearCompiledGraph();
                /*0x7ba0554*/ void ClearCompiledGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph compiledGraph, bool useCompilationCaching);
                /*0x7ba07a8*/ void InvalidateContext();
                /*0x7ba07f4*/ void OnPassAdded(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7b9fa50*/ int ComputeGraphHash();
                /*0x7ba10e0*/ void CountReferences();
                /*0x7ba18b0*/ void CullUnusedPasses();
                /*0x7ba22b0*/ void UpdatePassSynchronization(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo currentPassInfo, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex);
                /*0x7ba22d8*/ void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo resource);
                /*0x7ba25c4*/ int GetFirstValidConsumerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7ba2770*/ int FindTextureProducer(int consumerPass, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info, ref int index);
                /*0x7ba2410*/ int GetLatestProducerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7ba288c*/ int GetLatestValidReadIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7ba296c*/ int GetFirstValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7ba2a60*/ int GetLatestValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x7ba2b40*/ void CreateRendererLists();
                /*0x7ba2c64*/ bool GetImportedFallback(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle fallback);
                /*0x7ba2f3c*/ void AllocateCulledPassResources(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7ba3308*/ void UpdateResourceAllocationAndSynchronization();
                /*0x7ba3bec*/ void UpdateAllSharedResourceLastFrameIndex();
                /*0x7ba3d1c*/ bool AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists);
                /*0x7ba3f54*/ void TryCullPassAtIndex(int passIndex);
                /*0x7ba4028*/ void CullRendererLists();
                /*0x7b9f5f4*/ bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching);
                /*0x7b9fbc4*/ void CompileRenderGraph(int graphHash);
                /*0x7ba423c*/ ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo CompilePassImmediatly(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7ba082c*/ void ExecutePassImmediately(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x7ba4b6c*/ void ExecuteCompiledPass(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7b9fd50*/ void ExecuteRenderGraph();
                /*0x7ba5a24*/ void PreRenderPassSetRenderTargets(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7ba5270*/ void PreRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7ba55cc*/ void PostRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x7ba061c*/ void ClearRenderPasses();
                /*0x7ba5fa0*/ void ReleaseImmediateModeResources();
                /*0x7b9f640*/ void LogFrameInformation();
                /*0x7ba4128*/ void LogRendererListsCreation();
                /*0x7ba4f30*/ void LogRenderPassBegin(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x7ba1ec8*/ void LogCulledPasses();
                /*0x7ba6138*/ UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(string name);
                /*0x7ba6140*/ void UpdateImportedResourceLifeTime(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData data, System.Collections.Generic.List<int> passList);
                /*0x7ba6314*/ void GenerateDebugData();
                /*0x7ba66e4*/ void GenerateCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);
                /*0x7ba6528*/ void CleanupDebugData();
                /*0x7ba7890*/ void SetGlobal(UnityEngine.Rendering.RenderGraphModule.TextureHandle h, int globalPropertyId);
                /*0x7ba7a18*/ bool IsGlobal(int globalPropertyId);
                /*0x7ba7a70*/ System.Collections.Generic.Dictionary.ValueCollection<int, UnityEngine.Rendering.RenderGraphModule.TextureHandle> AllGlobals();
                /*0x7ba7ac0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle GetGlobal(int globalPropertyId);
                /*0x7b9feb8*/ void ClearGlobalBindings();
                /*0x7ba7b30*/ void AddPassDebugMetadata(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, string file, int line);
                /*0x7ba7c80*/ void ClearPassDebugMetadata();

                struct CompiledResourceInfo
                {
                    /*0x10*/ System.Collections.Generic.List<int> producers;
                    /*0x18*/ System.Collections.Generic.List<int> consumers;
                    /*0x20*/ int refCount;
                    /*0x24*/ bool imported;

                    /*0x7ba7d98*/ void Reset();
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

                    /*0x7ba7e98*/ void Reset(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int index);
                }

                interface ICompiledGraph
                {
                    /*0x380cb08*/ void Clear();
                }

                class CompiledGraph : UnityEngine.Rendering.RenderGraphModule.RenderGraph.ICompiledGraph
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> compiledResourcesInfos;
                    /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> compiledPassInfos;
                    /*0x20*/ int lastExecutionFrame;

                    /*0x7ba80f4*/ CompiledGraph();
                    /*0x7ba8260*/ void Clear();
                    /*0x7ba8308*/ void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, int count);
                    /*0x7ba83bc*/ void InitializeCompilationData(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                }

                class ProfilingScopePassData
                {
                    /*0x10*/ UnityEngine.Rendering.ProfilingSampler sampler;

                    /*0x7ba8574*/ ProfilingScopePassData();
                }

                class OnGraphRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x7ba857c*/ OnGraphRegisteredDelegate(object object, nint method);
                    /*0x7ba8684*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph);
                    /*0x7ba8698*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, object object);
                    /*0x7ba86b8*/ void EndInvoke(System.IAsyncResult result);
                }

                class OnExecutionRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x7ba86c4*/ OnExecutionRegisteredDelegate(object object, nint method);
                    /*0x7ba87d0*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName);
                    /*0x7ba87e4*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName, System.AsyncCallback callback, object object);
                    /*0x7ba880c*/ void EndInvoke(System.IAsyncResult result);
                }

                class DebugData
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<object, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassScriptInfo> s_PassScriptMetadata;
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData> passList;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData> resourceLists;
                    /*0x20*/ bool isNRPCompiler;

                    static /*0x7ba8a50*/ DebugData();
                    /*0x7ba8818*/ DebugData();
                    /*0x7ba8984*/ void Clear();

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

                            /*0x7ba8ae8*/ NRPInfo();

                            class NativeRenderPassInfo
                            {
                                /*0x10*/ string passBreakReasoning;
                                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo> attachmentInfos;
                                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.PassCompatibilityInfo> passCompatibility;
                                /*0x28*/ System.Collections.Generic.List<int> mergedPassIds;

                                /*0x7ba8b94*/ NativeRenderPassInfo();

                                class AttachmentInfo
                                {
                                    /*0x10*/ string resourceName;
                                    /*0x18*/ string loadReason;
                                    /*0x20*/ string storeReason;
                                    /*0x28*/ string storeMsaaReason;
                                    /*0x30*/ int attachmentIndex;
                                    /*0x34*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment attachment;

                                    /*0x7ba8b9c*/ AttachmentInfo();
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

                        /*0x7ba8ba4*/ BufferResourceData();
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

                        /*0x7ba8bac*/ TextureResourceData();
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

                        /*0x7ba8bb4*/ PassScriptInfo();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__110_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__111_0;

                    static /*0x7ba8bbc*/ <>c();
                    /*0x7ba8c24*/ <>c();
                    /*0x7ba8c2c*/ void <BeginProfilingSampler>b__110_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                    /*0x7ba8c70*/ void <EndProfilingSampler>b__111_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
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

                /*0x7ba8c98*/ InternalRenderGraphContext();
            }

            interface IDerivedRendergraphContext
            {
                /*0x380d83c*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            struct RenderGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;

                /*0x7ba8ca0*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
                /*0x7ba8ca8*/ UnityEngine.Rendering.ScriptableRenderContext get_renderContext();
                /*0x7ba8c54*/ UnityEngine.Rendering.CommandBuffer get_cmd();
                /*0x7ba8cc4*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7ba8ce0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
            }

            struct RasterGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rastercmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.RasterCommandBuffer cmd;

                static /*0x7ba8dfc*/ RasterGraphContext();
                /*0x7ba8cfc*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7ba8d18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7ba8d34*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class ComputeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.ComputeCommandBuffer computecmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.ComputeCommandBuffer cmd;

                static /*0x7ba8f90*/ ComputeGraphContext();
                /*0x7ba8f88*/ ComputeGraphContext();
                /*0x7ba8e84*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7ba8ea0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7ba8ebc*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class UnsafeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.UnsafeCommandBuffer unsCmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.UnsafeCommandBuffer cmd;

                static /*0x7ba9124*/ UnsafeGraphContext();
                /*0x7ba911c*/ UnsafeGraphContext();
                /*0x7ba9018*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x7ba9034*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x7ba9050*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
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
                /*0x3907c14*/ void Invoke(PassData data, ContextType renderGraphContext);
                /*0x3907c14*/ System.IAsyncResult BeginInvoke(PassData data, ContextType renderGraphContext, System.AsyncCallback callback, object object);
                /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
            }

            struct RenderGraphProfilingScope : System.IDisposable
            {
                /*0x7ba91ac*/ RenderGraphProfilingScope(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x7ba91b0*/ void Dispose();
                /*0x7ba91b4*/ void Dispose(bool disposing);
            }

            struct RenderGraphBuilder : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x7baa294*/ RenderGraphBuilder(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7ba91b8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index);
                /*0x7ba9384*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x7ba969c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7ba9658*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle WriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7ba987c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x7ba98d4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7ba9a2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7ba9c1c*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x7ba9c64*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x7ba9c90*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7ba9d50*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ReadBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x7ba9d7c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle WriteBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x7ba9dc4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7ba9f24*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsbuffer);
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> renderFunc);
                /*0x7baa11c*/ void EnableAsyncCompute(bool value);
                /*0x7baa13c*/ void AllowPassCulling(bool value);
                /*0x7baa15c*/ void EnableFoveatedRasterization(bool value);
                /*0x7baa17c*/ void Dispose();
                /*0x7baa1bc*/ void AllowRendererListCulling(bool value);
                /*0x7baa1dc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle DependsOn(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7baa184*/ void Dispose(bool disposing);
                /*0x7baa2e0*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x7baa6a4*/ void GenerateDebugData(bool value);
            }

            class RenderGraphBuilders : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable, UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x7baa6c4*/ RenderGraphBuilders();
                /*0x7baa714*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x7baa7c4*/ void EnableAsyncCompute(bool value);
                /*0x7baa7e4*/ void AllowPassCulling(bool value);
                /*0x7baa818*/ void AllowGlobalStateModification(bool value);
                /*0x7baa840*/ void EnableFoveatedRasterization(bool value);
                /*0x7baa860*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7baab08*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x7baab50*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7baabb8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7baac08*/ void Dispose();
                /*0x7baac1c*/ void Dispose(bool disposing);
                /*0x7bab06c*/ void ValidateWriteTo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7baa8d0*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle UseResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, bool isTransient);
                /*0x7bab78c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bab7ac*/ void CheckNotUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex);
                /*0x7bab064*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7babbb8*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7babd74*/ void UseAllGlobalTextures(bool enable);
                /*0x7babd94*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x7babebc*/ void CheckUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, bool isDepth);
                /*0x7bac958*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bac9d8*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7baca58*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x7bacad0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bacb54*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bacbe4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
                /*0x380d83c*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
                /*0x7bacc80*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x7bab4dc*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bacd34*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x7bad048*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bad050*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x7bad054*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x7bad074*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bad078*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bad07c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bad090*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x7bad0a4*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
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

                /*0x7bad170*/ RenderGraphDefaultResources();
                /*0x7bad0a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture();
                /*0x7bad0b4*/ void set_blackTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad0bc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTexture();
                /*0x7bad0c8*/ void set_whiteTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad0d0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR();
                /*0x7bad0dc*/ void set_clearTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad0e4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR();
                /*0x7bad0f0*/ void set_magentaTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad0f8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR();
                /*0x7bad104*/ void set_blackTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad10c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR();
                /*0x7bad118*/ void set_blackTextureArrayXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad120*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR();
                /*0x7bad12c*/ void set_blackUIntTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad134*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR();
                /*0x7bad140*/ void set_blackTexture3DXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad148*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR();
                /*0x7bad154*/ void set_whiteTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad15c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture();
                /*0x7bad168*/ void set_defaultShadowTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x7bad29c*/ void Cleanup();
                /*0x7bad2dc*/ void InitializeForRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            }

            struct RenderGraphLogIndent : System.IDisposable
            {
                /*0x10*/ int m_Indentation;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;
                /*0x20*/ bool m_Disposed;

                /*0x7bad4d0*/ RenderGraphLogIndent(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger, int indentation);
                /*0x7bad580*/ void Dispose();
                /*0x7bad5b0*/ void Dispose(bool disposing);
            }

            class RenderGraphLogger
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, System.Text.StringBuilder> m_LogMap;
                /*0x18*/ System.Text.StringBuilder m_CurrentBuilder;
                /*0x20*/ int m_CurrentIndentation;

                /*0x7bada3c*/ RenderGraphLogger();
                /*0x7bad660*/ void Initialize(string logName);
                /*0x7bad510*/ void IncrementIndentation(int value);
                /*0x7bad5e4*/ void DecrementIndentation(int value);
                /*0x7bad750*/ void LogLine(string format, object[] args);
                /*0x7bad7c8*/ string GetLog(string logName);
                /*0x7bad868*/ string GetAllLogs();
            }

            class RenderGraphObjectPool
            {
                static /*0x0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;
                /*0x10*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, int>, System.Collections.Generic.Stack<object>> m_ArrayPool;
                /*0x18*/ System.Collections.Generic.List<System.ValueTuple<object, System.ValueTuple<System.Type, int>>> m_AllocatedArrays;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

                static /*0x7bae1d8*/ RenderGraphObjectPool();
                /*0x7badac4*/ RenderGraphObjectPool();
                /*0x380ba90*/ T[] GetTempArray<T>(int size);
                /*0x7badbf4*/ UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock();
                /*0x7badcf0*/ void ReleaseAllTempAlloc();
                /*0x3907c14*/ T Get<T>();
                /*0x3907c14*/ void Release<T>(T value);
                /*0x7bae048*/ void Cleanup();

                class SharedObjectPoolBase
                {
                    /*0x7bae270*/ SharedObjectPoolBase();
                    /*0x7bae278*/ void Clear();
                }

                class SharedObjectPool<T> : UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase
                {
                    static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

                    static /*0x38358cc*/ SharedObjectPool();
                    static /*0x382dee4*/ UnityEngine.Pool.ObjectPool<T> AllocatePool();
                    static /*0x3907c14*/ T Get();
                    static /*0x3907c14*/ void Release(T toRelease);
                    /*0x380cb08*/ SharedObjectPool();
                    /*0x380cb08*/ void Clear();

                    class <>c<T>
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool.<>c<T> <>9;
                        static /*0x0*/ System.Func<T> <>9__1_0;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x3907c14*/ T <AllocatePool>b__1_0();
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

                static /*0x7bb0eb8*/ void ComputeHashForTextureAccess(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureAccess textureAccess);
                /*0x7bae3c4*/ RenderGraphPass();
                /*0x380d83c*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x380b128*/ bool HasRenderFunc();
                /*0x380b6a0*/ int GetRenderFuncHash();
                /*0x7bae27c*/ string get_name();
                /*0x7bae284*/ void set_name(string value);
                /*0x7bae28c*/ int get_index();
                /*0x7bae294*/ void set_index(int value);
                /*0x7bae29c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType get_type();
                /*0x7bae2a4*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType value);
                /*0x7bae2ac*/ UnityEngine.Rendering.ProfilingSampler get_customSampler();
                /*0x7bae2b4*/ void set_customSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x7bae2bc*/ bool get_enableAsyncCompute();
                /*0x7bae2c4*/ void set_enableAsyncCompute(bool value);
                /*0x7bae2d0*/ bool get_allowPassCulling();
                /*0x7bae2d8*/ void set_allowPassCulling(bool value);
                /*0x7bae2e4*/ bool get_allowGlobalState();
                /*0x7bae2ec*/ void set_allowGlobalState(bool value);
                /*0x7bae2f8*/ bool get_enableFoveatedRasterization();
                /*0x7bae300*/ void set_enableFoveatedRasterization(bool value);
                /*0x7bae30c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess get_depthAccess();
                /*0x7bae320*/ void set_depthAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess value);
                /*0x7bae33c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_colorBufferAccess();
                /*0x7bae344*/ void set_colorBufferAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x7bae34c*/ int get_colorBufferMaxIndex();
                /*0x7bae354*/ void set_colorBufferMaxIndex(int value);
                /*0x7bae35c*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_fragmentInputAccess();
                /*0x7bae364*/ void set_fragmentInputAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x7bae36c*/ int get_fragmentInputMaxIndex();
                /*0x7bae374*/ void set_fragmentInputMaxIndex(int value);
                /*0x7bae37c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] get_randomAccessResource();
                /*0x7bae384*/ void set_randomAccessResource(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] value);
                /*0x7bae38c*/ int get_randomAccessResourceMaxIndex();
                /*0x7bae394*/ void set_randomAccessResourceMaxIndex(int value);
                /*0x7bae39c*/ bool get_generateDebugData();
                /*0x7bae3a4*/ void set_generateDebugData(bool value);
                /*0x7bae3b0*/ bool get_allowRendererListCulling();
                /*0x7bae3b8*/ void set_allowRendererListCulling(bool value);
                /*0x7bae758*/ void Clear();
                /*0x7bae8ec*/ bool HasRenderAttachments();
                /*0x7baeac8*/ bool IsTransient(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baeba0*/ bool IsWritten(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baed20*/ bool IsRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baef5c*/ bool IsAttachment(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle res);
                /*0x7baf1bc*/ void AddResourceWrite(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baf2ec*/ void AddResourceRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baf41c*/ void AddTransientResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7baf54c*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x7baf5fc*/ void EnableAsyncCompute(bool value);
                /*0x7baf608*/ void AllowPassCulling(bool value);
                /*0x7baf614*/ void EnableFoveatedRasterization(bool value);
                /*0x7baf620*/ void AllowRendererListCulling(bool value);
                /*0x7baf62c*/ void AllowGlobalState(bool value);
                /*0x7baf638*/ void GenerateDebugData(bool value);
                /*0x7baf644*/ void SetColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index);
                /*0x7baf704*/ void SetColorBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7baf99c*/ void SetFragmentInputRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7bafc34*/ void SetRandomWriteResourceRaw(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags);
                /*0x7bafe84*/ void SetDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x7bafef4*/ void SetDepthBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x7bb00b0*/ void ComputeTextureHash(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                /*0x7bb05a8*/ void ComputeHash(ref UnityEngine.Rendering.HashFNV1A32 generator, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);

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

                /*0x380cb08*/ BaseRenderGraphPass();
                /*0x3907c14*/ void Initialize(int passIndex, PassData passData, string passName, UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType passType, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x380b128*/ bool HasRenderFunc();
                /*0x380b6a0*/ int GetRenderFuncHash();
            }

            class RenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphContext c;

                static /*0x38358cc*/ RenderGraphPass();
                /*0x380cb08*/ RenderGraphPass();
                /*0x380d83c*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class ComputeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext c;

                static /*0x38358cc*/ ComputeRenderGraphPass();
                /*0x380cb08*/ ComputeRenderGraphPass();
                /*0x380d83c*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class RasterRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RasterGraphContext c;

                static /*0x38358cc*/ RasterRenderGraphPass();
                /*0x380cb08*/ RasterRenderGraphPass();
                /*0x380d83c*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class UnsafeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext c;

                static /*0x38358cc*/ UnsafeRenderGraphPass();
                /*0x380cb08*/ UnsafeRenderGraphPass();
                /*0x380d83c*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x380d83c*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
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

                static /*0x7bb12f4*/ RayTracingAccelerationStructureHandle();
                static /*0x7bb0f64*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle get_nullHandle();
                static /*0x7bb10a4*/ UnityEngine.Rendering.RayTracingAccelerationStructure op_Implicit(UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x7bb0fc0*/ RayTracingAccelerationStructureHandle(int handle);
                /*0x7bb1184*/ bool IsValid();
            }

            struct RayTracingAccelerationStructureDesc
            {
                /*0x10*/ string name;
            }

            class RayTracingAccelerationStructureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc, UnityEngine.Rendering.RayTracingAccelerationStructure>
            {
                /*0x7bb1300*/ RayTracingAccelerationStructureResource();
                /*0x7bb12f8*/ string GetName();
            }

            struct BufferHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;

                static /*0x7bb1648*/ BufferHandle();
                static /*0x7bb1348*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_nullHandle();
                static /*0x7bb13f8*/ UnityEngine.GraphicsBuffer op_Implicit(UnityEngine.Rendering.RenderGraphModule.BufferHandle buffer);
                /*0x7bb13a4*/ BufferHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x7bb13b8*/ BufferHandle(int handle, bool shared);
                /*0x7bb14d8*/ bool IsValid();
            }

            struct BufferDesc
            {
                /*0x10*/ int count;
                /*0x14*/ int stride;
                /*0x18*/ string name;
                /*0x20*/ UnityEngine.GraphicsBuffer.Target target;
                /*0x24*/ UnityEngine.GraphicsBuffer.UsageFlags usageFlags;

                /*0x7bb164c*/ BufferDesc(int count, int stride);
                /*0x7bb1664*/ BufferDesc(int count, int stride, UnityEngine.GraphicsBuffer.Target target);
                /*0x7bb1678*/ int GetHashCode();
            }

            class BufferResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.BufferDesc, UnityEngine.GraphicsBuffer>
            {
                /*0x7bb1a1c*/ BufferResource();
                /*0x7bb16c0*/ string GetName();
                /*0x7bb1714*/ int GetDescHashCode();
                /*0x7bb175c*/ void CreateGraphicsResource();
                /*0x7bb17f4*/ void UpdateGraphicsResource();
                /*0x7bb1828*/ void ReleaseGraphicsResource();
                /*0x7bb1874*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bb1948*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class BufferPool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.GraphicsBuffer>
            {
                /*0x7bb1b64*/ BufferPool();
                /*0x7bb1a64*/ void ReleaseInternalResource(UnityEngine.GraphicsBuffer res);
                /*0x7bb1a7c*/ string GetResourceName(ref UnityEngine.GraphicsBuffer res);
                /*0x7bb1abc*/ long GetResourceSize(ref UnityEngine.GraphicsBuffer res);
                /*0x7bb1b00*/ string GetResourceTypeName();
                /*0x7bb1b40*/ int GetSortIndex(UnityEngine.GraphicsBuffer res);
            }

            class IRenderGraphResourcePool
            {
                /*0x7bb1bd0*/ IRenderGraphResourcePool();
                /*0x380cffc*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x380cb08*/ void Cleanup();
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x380d83c*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class RenderGraphResourcePool<Type> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool
            {
                static int kStaleResourceLifetime = 10;
                static /*0x0*/ System.Collections.Generic.List<int> s_ToRemoveList;
                /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<Type, int>>> m_ResourcePool;
                /*0x0*/ System.Collections.Generic.List<System.ValueTuple<int, Type>> m_FrameAllocatedResources;

                static /*0x38358cc*/ RenderGraphResourcePool();
                /*0x380cb08*/ RenderGraphResourcePool();
                /*0x3907c14*/ void ReleaseInternalResource(Type res);
                /*0x380bb68*/ string GetResourceName(ref Type res);
                long GetResourceSize(ref Type res);
                /*0x380b9e8*/ string GetResourceTypeName();
                /*0x3907c14*/ int GetSortIndex(Type res);
                /*0x3907c14*/ void ReleaseResource(int hash, Type resource, int currentFrameIndex);
                /*0x380b26c*/ bool TryGetResource(int hashCode, ref Type resource);
                /*0x380cb08*/ void Cleanup();
                /*0x3907c14*/ void RegisterFrameAllocation(int hash, Type value);
                /*0x3907c14*/ void UnregisterFrameAllocation(int hash, Type value);
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x380d83c*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x380cffc*/ void PurgeUnusedResources(int currentFrameIndex);

                struct ResourceLogInfo<Type>
                {
                    /*0x0*/ string name;
                    /*0x0*/ long size;
                }

                class <>c<Type>
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.<>c<Type> <>9;
                    static /*0x0*/ System.Comparison<UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__15_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x3907c14*/ int <LogResources>b__15_0(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> a, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> b);
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

                static /*0x7bb68ec*/ RenderGraphResourceRegistry();
                static /*0x7bb1bd8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current();
                static /*0x7bb1c30*/ void set_current(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry value);
                /*0x7bb2470*/ RenderGraphResourceRegistry();
                /*0x7bb2618*/ RenderGraphResourceRegistry(UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger);
                /*0x7bb1c98*/ void CheckTextureResource(UnityEngine.Rendering.RenderGraphModule.TextureResource texResource);
                /*0x7bb1d50*/ UnityEngine.Rendering.RTHandle GetTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7bb1e74*/ UnityEngine.Rendering.RTHandle GetTexture(int index);
                /*0x7ba9524*/ bool TextureNeedsFallback(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x7bb1f58*/ UnityEngine.Rendering.RendererList GetRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x7bb20b0*/ void CheckBufferResource(UnityEngine.Rendering.RenderGraphModule.BufferResource bufferResource);
                /*0x7bb15a8*/ UnityEngine.GraphicsBuffer GetBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle handle);
                /*0x7bb2258*/ UnityEngine.GraphicsBuffer GetBuffer(int index);
                /*0x7bb1254*/ UnityEngine.Rendering.RayTracingAccelerationStructure GetRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x7bb2438*/ int GetSharedResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x7bb2d4c*/ void BeginRenderGraph(int executionCount);
                /*0x7bb2eb8*/ void BeginExecute(int currentFrameIndex);
                /*0x7bb30b8*/ void EndExecute();
                /*0x7bb314c*/ void CheckHandleValidity(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb3150*/ void CheckHandleValidity(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7ba9294*/ void IncrementWriteCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bab52c*/ void IncrementReadCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb330c*/ void NewVersion(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bab3a8*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb34d4*/ int GetLatestVersionNumber(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bab61c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetZeroVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bab64c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetNewVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb35e4*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource GetResourceLowLevel(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bab2b8*/ string GetRenderGraphResourceName(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb36c8*/ string GetRenderGraphResourceName(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7ba9438*/ bool IsRenderGraphResourceImported(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb3764*/ bool IsRenderGraphResourceForceReleased(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bb37fc*/ bool IsRenderGraphResourceShared(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7bb33fc*/ bool IsRenderGraphResourceShared(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb383c*/ bool IsGraphicsResourceCreated(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb392c*/ bool IsRendererListCreated(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle res);
                /*0x7bb3a30*/ bool IsRenderGraphResourceImported(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x7baa5b8*/ int GetRenderGraphResourceTransientIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bb3ac8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x7bb3aec*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams, bool isBuiltin);
                /*0x7bb3ea4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bb4078*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x7bb426c*/ void RefreshSharedTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bb42c0*/ void ReleaseSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb4388*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x7bb4564*/ void ValidateRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x7bac588*/ void GetRenderTargetInfo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo outInfo);
                /*0x7bb4620*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x7bb4728*/ void ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x7ba9928*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, int transientPassIndex);
                /*0x7bb481c*/ int GetResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x7ba855c*/ int GetTextureResourceCount();
                /*0x7ba9788*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bb1e90*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(int index);
                /*0x7ba9aac*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x7bb488c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7bb49f4*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x7bb4acc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawinSettings);
                /*0x7bb4b90*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x7bb4c68*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x7bb4d40*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x7bb4e08*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x7bb4ed0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x7bb4ff4*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x7bb5174*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x7ba9e24*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc, int transientPassIndex);
                /*0x7ba9fa4*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x7ba8564*/ int GetBufferResourceCount();
                /*0x7bb2160*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bb2274*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(int index);
                /*0x7bb2340*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7ba856c*/ int GetRayTracingAccelerationStructureResourceCount();
                /*0x7bb5260*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                /*0x7bb5350*/ void UpdateSharedResourceLastFrameIndex(int type, int index);
                /*0x7bb53ec*/ void UpdateSharedResourceLastFrameIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bb2f68*/ void ManageSharedRenderGraphResources();
                /*0x7bb5454*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x7bb55dc*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bb5688*/ bool CreateTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x7bb5858*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x7bb5990*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x7bb5a3c*/ void ReleaseTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x7bb5b88*/ void ValidateTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x7bb5d70*/ void ValidateRendererListDesc(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7bb5f34*/ void ValidateBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x7bb6040*/ void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, bool manualDispatch);
                /*0x7bb6388*/ void Clear(bool onException);
                /*0x7bb66b0*/ void PurgeUnusedGraphicsResources();
                /*0x7bb6730*/ void Cleanup();
                /*0x7bb687c*/ void FlushLogs();
                /*0x7bb6478*/ void LogResources();

                class ResourceCreateCallback : System.MulticastDelegate
                {
                    /*0x7bb2ac8*/ ResourceCreateCallback(object object, nint method);
                    /*0x7bb6978*/ bool Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x7bb698c*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x7bb69b4*/ bool EndInvoke(System.IAsyncResult result);
                }

                class ResourceCallback : System.MulticastDelegate
                {
                    /*0x7bb2bd4*/ ResourceCallback(object object, nint method);
                    /*0x7bb69dc*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x7bb69f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x7bb6a18*/ void EndInvoke(System.IAsyncResult result);
                }

                class RenderGraphResourcesData
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;
                    /*0x18*/ int sharedResourcesCount;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;

                    /*0x7bb2a0c*/ RenderGraphResourcesData();
                    /*0x7bb6618*/ void Clear(bool onException, int frameIndex);
                    /*0x7bb67c8*/ void Cleanup();
                    /*0x7bb6718*/ void PurgeUnusedGraphicsResources(int frameIndex);
                    /*0x3907c14*/ int AddNewRenderGraphResource<ResType>(ref ResType outRes, bool pooledResource);
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

                static /*0x7bb20a8*/ int op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                static /*0x7bb6a34*/ UnityEngine.Rendering.RendererList op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x7bb49e0*/ RendererListHandle(int handle, UnityEngine.Rendering.RenderGraphModule.RendererListHandleType type);
                /*0x7bb6a24*/ int get_handle();
                /*0x7bb6a2c*/ void set_handle(int value);
                /*0x7bb6b3c*/ bool IsValid();
            }

            struct RendererListResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererListParams desc;
                /*0x140*/ UnityEngine.Rendering.RendererList rendererList;

                /*0x7bb49c0*/ RendererListResource(ref UnityEngine.Rendering.RendererListParams desc);
            }

            struct RendererListLegacyResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererList rendererList;
                /*0x28*/ bool isActive;

                /*0x7bb6b44*/ RendererListLegacyResource(ref bool active);
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

                static /*0x7bb6d78*/ ResourceHandle();
                static /*0x7bb2df8*/ void NewFrame(int executionIndex);
                /*0x7bb1000*/ ResourceHandle(int value, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, bool shared);
                /*0x7bb3464*/ ResourceHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int version);
                /*0x7bb6b60*/ int get_index();
                /*0x7bb6b68*/ int get_iType();
                /*0x7bb6bbc*/ int get_version();
                /*0x7bb6bc4*/ void set_version(int value);
                /*0x7bb6bcc*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType get_type();
                /*0x7bb6bd4*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType value);
                /*0x7bb6bdc*/ bool IsValid();
                /*0x7bb6c7c*/ bool IsNull();
                /*0x7bb6cd8*/ bool get_IsVersioned();
                /*0x7bb6ce8*/ bool Equals(UnityEngine.Rendering.RenderGraphModule.ResourceHandle hdl);
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

                /*0x7bb6eb0*/ IRenderGraphResource();
                /*0x7bb6dc8*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool _);
                /*0x7bb6de8*/ string GetName();
                /*0x7bb6e28*/ bool IsCreated();
                /*0x7bb6e30*/ void IncrementWriteCount();
                /*0x7bb6e40*/ void IncrementReadCount();
                /*0x7bb6e50*/ int NewVersion();
                /*0x7bb6e64*/ bool NeedsFallBack();
                /*0x7bb6e84*/ void CreatePooledGraphicsResource();
                /*0x7bb6e88*/ void CreateGraphicsResource();
                /*0x7bb6e8c*/ void UpdateGraphicsResource();
                /*0x7bb6e90*/ void ReleasePooledGraphicsResource(int frameIndex);
                /*0x7bb6e94*/ void ReleaseGraphicsResource();
                /*0x7bb6e98*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bb6e9c*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bb6ea0*/ int GetSortIndex();
                /*0x7bb6ea8*/ int GetDescHashCode();
            }

            class RenderGraphResource<DescType, ResType> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource
            {
                /*0x0*/ DescType desc;
                /*0x0*/ bool validDesc;
                /*0x0*/ ResType graphicsResource;
                /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<ResType> m_Pool;

                /*0x380cb08*/ RenderGraphResource();
                /*0x380d83c*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                /*0x380b128*/ bool IsCreated();
                /*0x380cb08*/ void ReleaseGraphicsResource();
                /*0x380cb08*/ void CreatePooledGraphicsResource();
                /*0x380cffc*/ void ReleasePooledGraphicsResource(int frameIndex);
            }

            struct TextureAccess
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle textureHandle;
                /*0x20*/ int mipLevel;
                /*0x24*/ int depthSlice;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.AccessFlags flags;

                /*0x7bafee4*/ TextureAccess(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
            }

            struct TextureHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;
                /*0x1c*/ bool builtin;

                static /*0x7bb7664*/ TextureHandle();
                static /*0x7bb6eb8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_nullHandle();
                static /*0x7bb6f28*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bb70d4*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bb7250*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x7bb73cc*/ UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x7bb6f10*/ TextureHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x7bb3e54*/ TextureHandle(int handle, bool shared, bool builtin);
                /*0x7bb7544*/ bool IsValid();
                /*0x7bb7614*/ bool IsBuiltin();
                /*0x7bb761c*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetDescriptor(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
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

                /*0x7bb789c*/ TextureDesc(int width, int height, bool dynamicResolution, bool xrReady);
                /*0x7bb78d0*/ TextureDesc(UnityEngine.Vector2 scale, bool dynamicResolution, bool xrReady);
                /*0x7bb7908*/ TextureDesc(UnityEngine.Rendering.ScaleFunc func, bool dynamicResolution, bool xrReady);
                /*0x7bb796c*/ TextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureDesc input);
                /*0x7bb798c*/ TextureDesc(UnityEngine.RenderTextureDescriptor input);
                /*0x7bb3d78*/ TextureDesc(UnityEngine.RenderTexture input);
                /*0x7bb7668*/ UnityEngine.Rendering.DepthBits get_depthBufferBits();
                /*0x7bb76c4*/ void set_depthBufferBits(UnityEngine.Rendering.DepthBits value);
                /*0x7bb7758*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_colorFormat();
                /*0x7bb77c8*/ void set_colorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
                /*0x7bb77d0*/ void InitDefaultValues(bool dynamicResolution, bool xrReady);
                /*0x7bb7b1c*/ int GetHashCode();
                /*0x7bb462c*/ UnityEngine.Vector2Int CalculateFinalDimensions();
            }

            class TextureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.TextureDesc, UnityEngine.Rendering.RTHandle>
            {
                static /*0x0*/ int m_TextureCreationIndex;

                /*0x7bb83d0*/ TextureResource();
                /*0x7bb7d04*/ string GetName();
                /*0x7bb7d70*/ int GetDescHashCode();
                /*0x7bb7d78*/ void CreateGraphicsResource();
                /*0x7bb8174*/ void UpdateGraphicsResource();
                /*0x7bb81a8*/ void ReleaseGraphicsResource();
                /*0x7bb81f4*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x7bb82fc*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class TexturePool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.Rendering.RTHandle>
            {
                /*0x7bb2ce0*/ TexturePool();
                /*0x7bb8418*/ void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res);
                /*0x7bb8430*/ string GetResourceName(ref UnityEngine.Rendering.RTHandle res);
                /*0x7bb8454*/ long GetResourceSize(ref UnityEngine.Rendering.RTHandle res);
                /*0x7bb8474*/ string GetResourceTypeName();
                /*0x7bb84b4*/ int GetSortIndex(UnityEngine.Rendering.RTHandle res);
            }

            namespace Util
            {
                class RenderGraphUtils
                {
                    static /*0x0*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
                    static /*0x8*/ UnityEngine.Vector4 s_BlitScaleBias;

                    static /*0x7bb9f60*/ RenderGraphUtils();
                    static /*0x7bb84cc*/ bool CanAddCopyPassMSAA();
                    static /*0x7bb851c*/ void AddCopyPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, int sourceSlice, int destinationSlice, int sourceMip, int destinationMip, string passName, string file, int line);
                    static /*0x7bb8be8*/ void CopyRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    static /*0x7bb8c58*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceSlice, int destinationSlice, int numSlices, int sourceMip, int destinationMip, int numMips, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitFilterMode filterMode, string passName, string file, int line);
                    static /*0x7bb92ac*/ void BlitRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    static /*0x7bb94d8*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialParameters blitParameters, string passName, string file, int line);
                    static /*0x7bb9bc8*/ void BlitMaterialRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);

                    class CopyPassData
                    {
                        /*0x10*/ bool isMSAA;

                        /*0x7bb9fec*/ CopyPassData();
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

                        /*0x7bb9ff4*/ BlitPassData();
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

                        static /*0x7bba788*/ BlitMaterialParameters();
                        /*0x7bb9ffc*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass);
                        /*0x7bba11c*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass);
                        /*0x7bba220*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x7bba39c*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
                        /*0x7bba4f8*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x7bba654*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
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

                        /*0x7bba884*/ BlitMaterialPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__3_0;
                        static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__7_0;
                        static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__13_0;

                        static /*0x7bba88c*/ <>c();
                        /*0x7bba8f4*/ <>c();
                        /*0x7bba8fc*/ void <AddCopyPass>b__3_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                        /*0x7bba968*/ void <AddBlitPass>b__7_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                        /*0x7bba9cc*/ void <AddBlitPass>b__13_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    }
                }

                class RenderGraphUtilsResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtilsResources.Version m_Version;
                    /*0x18*/ UnityEngine.Shader m_CoreCopyPS;

                    /*0x7bbaab4*/ RenderGraphUtilsResources();
                    /*0x7bbaa30*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
                    /*0x7bbaa38*/ UnityEngine.Shader get_coreCopyPS();
                    /*0x7bbaa40*/ void set_coreCopyPS(UnityEngine.Shader value);

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

                    /*0x7bbaabc*/ Name(string name, bool computeUTF8ByteCount);
                }

                class NativeListExtensions
                {
                    static /*0x3907c14*/ System.ReadOnlySpan<T> MakeReadOnlySpan<T>(ref Unity.Collections.NativeList<T> list, int first, int numElements);
                    static /*0x3824ba4*/ int LastIndex<T>(ref Unity.Collections.NativeList<T> list);
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

                    /*0x7bbab88*/ CompilerContextData(int estimatedNumPasses);
                    /*0x7bbaef4*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resourceRegistry);
                    /*0x7bbaf10*/ void Clear();
                    /*0x7bbb0a8*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData UnversionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bbb184*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData VersionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bbb1a4*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> Readers(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bbb32c*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData ResourceReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int i);
                    /*0x7bbb474*/ bool AddToFragmentList(UnityEngine.Rendering.RenderGraphModule.TextureAccess access, int listFirstIndex, int numItems);
                    /*0x7bbb5b8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetFullPassName(int passId);
                    /*0x7bbb61c*/ string GetPassName(int passId);
                    /*0x7bbb67c*/ string GetResourceName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bbb764*/ string GetResourceVersionedName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bbb828*/ bool AddToRandomAccessResourceList(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems);
                    /*0x7bbba94*/ void TagAllPasses(int value);
                    /*0x7bbbb44*/ void CullAllPasses(bool isCulled);
                    /*0x7bbbbf4*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator get_NativePasses();
                    /*0x7bbbc44*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData> GetNativePasses();
                    /*0x7bbbef0*/ void Finalize();
                    /*0x7bbc0e0*/ void Dispose();
                    /*0x7bbbf84*/ void Cleanup();

                    struct NativePassIterator
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData m_Ctx;
                        /*0x18*/ int m_Index;

                        /*0x7bbbc24*/ NativePassIterator(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                        /*0x7bbbdd4*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData get_Current();
                        /*0x7bbbe2c*/ bool MoveNext();
                        /*0x7bbbdc8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator GetEnumerator();
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

                    static /*0x38358cc*/ FixedAttachmentArray();
                    /*0x380cffc*/ FixedAttachmentArray(int numAttachments);
                    /*0x380d83c*/ FixedAttachmentArray(DataType[] attachments);
                    /*0x3907c14*/ FixedAttachmentArray(Unity.Collections.NativeArray<DataType> attachments);
                    /*0x380b6a0*/ int get_size();
                    /*0x380cb08*/ void Clear();
                    /*0x380b7a8*/ int Add(ref DataType data);
                    /*0x380ba90*/ ref DataType get_Item(int index);
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

                    static /*0x7bbf190*/ bool IsGlobalTextureInPass(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                    static /*0x7bbf338*/ bool IsSameNativeSubPass(ref UnityEngine.Rendering.SubPassDescriptor a, ref UnityEngine.Rendering.SubPassDescriptor b);
                    static /*0x7bc12e0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo MakeAttachmentInfo(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int attachmentIndex);
                    static /*0x7bc17b4*/ string MakePassBreakInfoMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    static /*0x7bc18d4*/ string MakePassMergeMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData prevPass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit mergeResult);
                    static /*0x7bc1fd4*/ string InjectSpaces(string camelCaseString);
                    /*0x7bbc140*/ NativePassCompiler(RenderGraphCompilationCache cache);
                    /*0x7bbc2c4*/ void Finalize();
                    /*0x7bbc3b4*/ void Dispose();
                    /*0x7bbc358*/ void Cleanup();
                    /*0x7bbc414*/ bool Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> renderPasses, bool disableCulling, string debugName, bool useCompilationCaching, int graphHash, int frameIndex);
                    /*0x7bbc540*/ void Compile(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7bbc4dc*/ void Clear(bool clearContextData);
                    /*0x7bbeb78*/ void SetPassStatesForNativePass(int nativePassId);
                    /*0x7bbc580*/ void SetupContextData(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7bbc680*/ void BuildGraph();
                    /*0x7bbd558*/ void CullUnusedRenderPasses();
                    /*0x7bbd948*/ void TryMergeNativePasses();
                    /*0x7bbdc94*/ void FindResourceUsageRanges();
                    /*0x7bbeab8*/ void PrepareNativeRenderPasses();
                    /*0x7bbe5cc*/ void DetectMemoryLessResources();
                    /*0x7bbf4f4*/ void ExecuteCreateRessource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x7bbeb84*/ void DetermineLoadStoreActions(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x7bbf980*/ void ValidateNativePass(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount);
                    /*0x7bbfaf8*/ void ValidateAttachmentRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo attRenderTargetInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples);
                    /*0x7bbfc10*/ void ExecuteBeginRenderPass(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x7bc0314*/ void ExecuteDestroyResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x7bc0768*/ void SetRandomWriteTarget(ref UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int index, UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, bool preserveCounterValue);
                    /*0x7bc0970*/ void ExecuteGraphNode(ref UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x7bc0ca0*/ void ExecuteGraph(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes);
                    /*0x7bc214c*/ void GenerateNativeCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);

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

                    static /*0x7bc6778*/ bool SameSubResource(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData x, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData y);
                    /*0x7bc66c0*/ int GetHashCode();
                }

                struct PassRandomWriteData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                    /*0x1c*/ int index;
                    /*0x20*/ bool preserveCounterValue;

                    /*0x7bc6810*/ int GetHashCode();
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

                    /*0x7bc6900*/ PassData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x7bc6898*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6974*/ void ResetAndInitialize(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x7bc69e8*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassOutputData> Outputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6a84*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassInputData> Inputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6b20*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> Fragments(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6bbc*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> FragmentInputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6c58*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> FirstUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6cf4*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData> RandomWriteTextures(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6d90*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> LastUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6e2c*/ void SetupAndValidateFragmentInfo(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6e6c*/ void AddFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6e90*/ void AddFragmentInput(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc6eb4*/ void AddRandomAccessResource();
                    /*0x7bc6ec4*/ void AddFirstUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc7090*/ void AddLastUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc725c*/ bool IsUsedAsFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
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

                    static /*0x7bc7460*/ LoadAudit();
                    /*0x7bc7458*/ LoadAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.LoadReason setReason, int setPassId);
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

                    static /*0x7bc7620*/ StoreAudit();
                    /*0x7bc7614*/ StoreAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setReason, int setPassId, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setMsaaReason, int setMsaaPassId);
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

                    static /*0x7bc7810*/ PassBreakAudit();
                    /*0x7bc7808*/ PassBreakAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakReason reason, int breakPass);
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

                    static /*0x7bc88d8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit CanMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x7bc9198*/ bool CanMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x7bc7d34*/ void TryMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x7bc9768*/ void UpdateNativeSubPassesAttachments(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    static /*0x7bc9b04*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit TryMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x7bca19c*/ void SetPassStatesForNativePass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int nativePassId);
                    /*0x7bc7afc*/ NativePassData(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc83f0*/ void Clear();
                    /*0x7bc8540*/ bool IsValid();
                    /*0x7bc8550*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData> GraphPasses(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x7bc87d4*/ void GetGraphPassNames(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> dest);
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

                    /*0x7bca2fc*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool isResourceShared);
                    /*0x7bca358*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.BufferDesc _, bool isResourceShared);
                    /*0x7bca3a4*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc _, bool isResourceShared);
                    /*0x7bca2d8*/ string GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bca3f0*/ void InitializeNullResource();
                }

                struct ResourceVersionedData
                {
                    /*0x10*/ bool written;
                    /*0x14*/ int writePassId;
                    /*0x18*/ int numReaders;

                    /*0x7bca404*/ void SetWritingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                    /*0x7bca414*/ void RegisterReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId, int index);
                    /*0x7bca590*/ void RemoveReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                }

                class ResourcesData
                {
                    /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData> unversionedData;
                    /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData> versionedData;
                    /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> readerData;
                    /*0x28*/ int MaxVersions;
                    /*0x2c*/ int MaxReaders;
                    /*0x30*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> resourceNames;

                    /*0x7bca864*/ ResourcesData();
                    /*0x7bcab4c*/ void Clear();
                    /*0x7bcac84*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x7bcb424*/ int Index(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bcb490*/ int IndexReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int readerID);
                    /*0x7bc9080*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData get_Item(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x7bcb504*/ void Dispose();
                }
            }
        }

        namespace LookDev
        {
            interface IDataProvider
            {
                /*0x380d83c*/ void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x3907c14*/ void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<string> get_supportedDebugModes();
                /*0x380cffc*/ void UpdateDebugMode(int debugIndex);
                /*0x380d93c*/ void GetShadowMask(ref UnityEngine.RenderTexture output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x380d83c*/ void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x380d83c*/ void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x380d83c*/ void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI);
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

                /*0x7bcb5fc*/ StageRuntimeInterface(System.Func<bool, UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight);
                /*0x7bcb65c*/ UnityEngine.GameObject AddGameObject(bool persistent);
                /*0x7bcb680*/ UnityEngine.Camera get_camera();
                /*0x7bcb6a0*/ UnityEngine.Light get_sunLight();
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

                /*0x7bcc474*/ DebugUIHandlerBitField();
                /*0x7bcb6c0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bcbb08*/ bool GetValue(int index);
                /*0x7bcbbb0*/ void SetValue(int index, bool value);
                /*0x7bcbf00*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bcc180*/ void OnDeselection();
                /*0x7bcc1b0*/ void OnIncrement(bool fast);
                /*0x7bcc1d0*/ void OnDecrement(bool fast);
                /*0x7bcc1f0*/ void OnAction();
                /*0x7bcc218*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerButton : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Button m_Field;

                /*0x7bcc5e4*/ DebugUIHandlerButton();
                /*0x7bcc4ac*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bcc548*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bcc580*/ void OnDeselection();
                /*0x7bcc5b0*/ void OnAction();
            }

            class DebugUIPrefabBundle
            {
                /*0x10*/ string type;
                /*0x18*/ UnityEngine.RectTransform prefab;

                /*0x7bcc600*/ DebugUIPrefabBundle();
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

                /*0x7bce88c*/ DebugUIHandlerCanvas();
                /*0x7bcc608*/ void OnEnable();
                /*0x7bcc780*/ void Update();
                /*0x7bccf40*/ void RequestHierarchyReset();
                /*0x7bcc8a8*/ void ResetAllHierarchy();
                /*0x7bccf4c*/ void Rebuild();
                /*0x7bcd9a4*/ void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, ref UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedHandler);
                /*0x7bce060*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(string queryPath);
                /*0x7bcde5c*/ void ActivatePanel(int index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget);
                /*0x7bce210*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
                /*0x7bce560*/ void SelectPreviousItem();
                /*0x7bce624*/ void SelectNextPanel();
                /*0x7bce698*/ void SelectPreviousPanel();
                /*0x7bce49c*/ void SelectNextItem();
                /*0x7bce718*/ void ChangeSelectionValue(float multiplier);
                /*0x7bce804*/ void ActivateSelection();
                /*0x7bccbb4*/ void HandleInput();
                /*0x7bce3b0*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, bool> <>9__12_0;
                    static /*0x10*/ System.Action<UnityEngine.Rendering.UI.DebugUIHandlerPanel> <>9__15_0;

                    static /*0x7bce894*/ <>c();
                    /*0x7bce8fc*/ <>c();
                    /*0x7bce904*/ bool <Rebuild>b__12_0(UnityEngine.Rendering.DebugUI.Widget x);
                    /*0x7bce948*/ void <ActivatePanel>b__15_0(UnityEngine.Rendering.UI.DebugUIHandlerPanel p);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string queryPath;

                    /*0x7bce1b4*/ <>c__DisplayClass14_0();
                    /*0x7bce974*/ bool <GetWidgetFromPath>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget w);
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

                /*0x7bcf2c0*/ DebugUIHandlerColor();
                /*0x7bce9a0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bcefbc*/ void SetValue(float x, bool r, bool g, bool b, bool a);
                /*0x7bcedd8*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bcf07c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bcf160*/ void OnDeselection();
                /*0x7bcf190*/ void OnIncrement(bool fast);
                /*0x7bcf1b0*/ void OnDecrement(bool fast);
                /*0x7bcf1d0*/ void OnAction();
                /*0x7bcef08*/ void UpdateColor();
                /*0x7bcf1f8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bcf2dc*/ float <SetWidget>b__9_0();
                /*0x7bcf32c*/ void <SetWidget>b__9_1(float x);
                /*0x7bcf340*/ float <SetWidget>b__9_2();
                /*0x7bcf398*/ void <SetWidget>b__9_3(float x);
                /*0x7bcf3ac*/ float <SetWidget>b__9_4();
                /*0x7bcf404*/ void <SetWidget>b__9_5(float x);
                /*0x7bcf418*/ float <SetWidget>b__9_6();
                /*0x7bcf470*/ void <SetWidget>b__9_7(float x);
                /*0x7bcf484*/ float <SetupSettings>b__11_0();
                /*0x7bcf4a0*/ float <SetupSettings>b__11_1();
                /*0x7bcf4bc*/ float <SetupSettings>b__11_2();
            }

            class DebugUIHandlerContainer : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform contentHolder;

                /*0x7bcf910*/ DebugUIHandlerContainer();
                /*0x7bcc3e4*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x7bcc0f0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem();
                /*0x7bcbfe4*/ bool IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
                /*0x7bcf4dc*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget widget;

                    /*0x7bcf908*/ <>c__DisplayClass3_0();
                    /*0x7bcf918*/ bool <IsDirectChild>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget x);
                }
            }

            class DebugUIHandlerEnumField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.EnumField>
            {
                /*0x7bcfd34*/ DebugUIHandlerEnumField();
                /*0x7bcf984*/ void OnIncrement(bool fast);
                /*0x7bcfaf8*/ void OnDecrement(bool fast);
                /*0x7bcfc9c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerEnumHistory : UnityEngine.Rendering.UI.DebugUIHandlerEnumField
            {
                static float k_XOffset = 230;
                /*0x88*/ UnityEngine.UI.Text[] historyValues;

                /*0x7bd02d8*/ DebugUIHandlerEnumHistory();
                /*0x7bcfd7c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd0028*/ void UpdateValueLabel();
                /*0x7bd0244*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory <>4__this;

                    /*0x7bd02b0*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x7bd02dc*/ void System.IDisposable.Dispose();
                    /*0x7bd02e0*/ bool MoveNext();
                    /*0x7bd03d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7bd03d8*/ void System.Collections.IEnumerator.Reset();
                    /*0x7bd0410*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerField<T> : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x0*/ UnityEngine.UI.Text nextButtonText;
                /*0x0*/ UnityEngine.UI.Text previousButtonText;
                /*0x0*/ UnityEngine.UI.Text nameLabel;
                /*0x0*/ UnityEngine.UI.Text valueLabel;
                /*0x0*/ T m_Field;

                /*0x380cb08*/ DebugUIHandlerField();
                /*0x380d83c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x380cb08*/ void OnDeselection();
                /*0x380cb08*/ void OnAction();
                /*0x380cb08*/ void UpdateValueLabel();
                /*0x380d83c*/ void SetLabelText(string text);
            }

            class DebugUIHandlerFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.FloatField m_Field;

                /*0x7bd06e4*/ DebugUIHandlerFloatField();
                /*0x7bd0418*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd0588*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd05e0*/ void OnDeselection();
                /*0x7bd0630*/ void OnIncrement(bool fast);
                /*0x7bd06d8*/ void OnDecrement(bool fast);
                /*0x7bd063c*/ void ChangeValue(bool fast, float multiplier);
                /*0x7bd04c0*/ void UpdateValueLabel();
            }

            class DebugUIHandlerFoldout : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float k_FoldoutXOffset = 215;
                static float k_XOffset = 230;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Foldout m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bd0cd4*/ DebugUIHandlerFoldout();
                /*0x7bd0700*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd0a98*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd0b7c*/ void OnDeselection();
                /*0x7bd0bac*/ void OnIncrement(bool fast);
                /*0x7bd0bcc*/ void OnDecrement(bool fast);
                /*0x7bd0be8*/ void OnAction();
                /*0x7bd0a70*/ void UpdateValue();
                /*0x7bd0c0c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerGroup : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Transform header;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Container m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bd0f70*/ DebugUIHandlerGroup();
                /*0x7bd0cf0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd0e00*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd0eb8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerHBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bd1170*/ DebugUIHandlerHBox();
                /*0x7bd0f8c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd1000*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd10b8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
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

                /*0x7bd1414*/ DebugUIHandlerIndirectFloatField();
                /*0x7bcf078*/ void Init();
                /*0x7bd12a0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd12f8*/ void OnDeselection();
                /*0x7bd1348*/ void OnIncrement(bool fast);
                /*0x7bd1408*/ void OnDecrement(bool fast);
                /*0x7bd1354*/ void ChangeValue(bool fast, float multiplier);
                /*0x7bd118c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIndirectToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ System.Func<int, bool> getter;
                /*0x80*/ System.Action<int, bool> setter;
                /*0x88*/ int index;

                /*0x7bd1564*/ DebugUIHandlerIndirectToggle();
                /*0x7bcba5c*/ void Init();
                /*0x7bd1430*/ void OnToggleValueChanged(bool value);
                /*0x7bd1460*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd14b8*/ void OnDeselection();
                /*0x7bd1508*/ void OnAction();
                /*0x7bcbe58*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.IntField m_Field;

                /*0x7bd186c*/ DebugUIHandlerIntField();
                /*0x7bd1580*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd170c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd1764*/ void OnDeselection();
                /*0x7bd17b4*/ void OnIncrement(bool fast);
                /*0x7bd1860*/ void OnDecrement(bool fast);
                /*0x7bd17c0*/ void ChangeValue(bool fast, int multiplier);
                /*0x7bd1628*/ void UpdateValueLabel();
            }

            class DebugUIHandlerMessageBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color32 k_WarningBackgroundColor;
                static /*0x4*/ UnityEngine.Color32 k_WarningTextColor;
                static /*0x8*/ UnityEngine.Color32 k_ErrorBackgroundColor;
                static /*0xc*/ UnityEngine.Color32 k_ErrorTextColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.MessageBox m_Field;

                static /*0x7bd1a88*/ DebugUIHandlerMessageBox();
                /*0x7bd1a6c*/ DebugUIHandlerMessageBox();
                /*0x7bd1888*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd1a24*/ void Update();
                /*0x7bd1a64*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
            }

            class DebugUIHandlerObject : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;

                /*0x7bd1c90*/ DebugUIHandlerObject();
                /*0x7bd1b10*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd1be8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd1c40*/ void OnDeselection();
            }

            class DebugUIHandlerObjectList : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectListField>
            {
                /*0x88*/ int m_Index;

                /*0x7bd1eb4*/ DebugUIHandlerObjectList();
                /*0x7bd1cac*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd1d0c*/ void OnIncrement(bool fast);
                /*0x7bd1d28*/ void OnDecrement(bool fast);
                /*0x7bd1d44*/ void UpdateValueLabel();
            }

            class DebugUIHandlerObjectPopupField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectPopupField>
            {
                /*0x88*/ int m_Index;

                /*0x7bd215c*/ DebugUIHandlerObjectPopupField();
                /*0x7bd1efc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd1f5c*/ void ChangeSelectedObject();
                /*0x7bd205c*/ void OnIncrement(bool fast);
                /*0x7bd206c*/ void OnDecrement(bool fast);
                /*0x7bd207c*/ void UpdateValueLabel();
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

                /*0x7bd2468*/ DebugUIHandlerPanel();
                /*0x7bd21a4*/ void OnEnable();
                /*0x7bcd95c*/ void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x7bd2278*/ UnityEngine.Rendering.DebugUI.Panel GetPanel();
                /*0x7bd2280*/ void SelectNextItem();
                /*0x7bd2298*/ void SelectPreviousItem();
                /*0x7bd22b0*/ void OnScrollbarClicked();
                /*0x7bd2314*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target);
                /*0x7bccdc8*/ void UpdateScroll();
                /*0x7bd231c*/ float GetYPosInScroll(UnityEngine.RectTransform target);
                /*0x7bce1bc*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x7bd2408*/ void ResetDebugManager();
            }

            class DebugUIHandlerPersistentCanvas : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform panel;
                /*0x28*/ UnityEngine.RectTransform valuePrefab;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.ValueTuple> m_ValueTupleWidgets;

                /*0x7bd2d10*/ DebugUIHandlerPersistentCanvas();
                /*0x7bd2470*/ void Toggle(UnityEngine.Rendering.DebugUI.Value widget, string displayName);
                /*0x7bd276c*/ void Toggle(UnityEngine.Rendering.DebugUI.ValueTuple widget, System.Nullable<int> forceTupleIndex);
                /*0x7bd2b0c*/ bool IsEmpty();
                /*0x7bd2b5c*/ void Clear();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Value widget;

                    /*0x7bd2764*/ <>c__DisplayClass3_0();
                    /*0x7bd2dec*/ bool <Toggle>b__0(UnityEngine.Rendering.UI.DebugUIHandlerValue x);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.ValueTuple widget;

                    /*0x7bd2b04*/ <>c__DisplayClass5_0();
                    /*0x7bd2e10*/ bool <Toggle>b__0(UnityEngine.Rendering.DebugUI.ValueTuple x);
                }
            }

            class DebugUIHandlerProgressBar : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.RectTransform progressBarRect;
                /*0x78*/ UnityEngine.Rendering.DebugUI.ProgressBarValue m_Value;
                /*0x80*/ float m_Timer;

                /*0x7bd3088*/ DebugUIHandlerProgressBar();
                /*0x7bd2e20*/ void OnEnable();
                /*0x7bd2e28*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd2fbc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd2ff4*/ void OnDeselection();
                /*0x7bd3024*/ void Update();
                /*0x7bd2ed0*/ void UpdateValue();
            }

            class DebugUIHandlerRow : UnityEngine.Rendering.UI.DebugUIHandlerFoldout
            {
                /*0x80*/ float m_Timer;

                /*0x7bd378c*/ DebugUIHandlerRow();
                /*0x7bd30a4*/ void OnEnable();
                /*0x7bd30ac*/ UnityEngine.GameObject GetChild(int index);
                /*0x7bd31dc*/ bool TryGetChild(int index, ref UnityEngine.GameObject child);
                /*0x7bd3268*/ bool IsActive(UnityEngine.Rendering.DebugUI.Table table, int index, UnityEngine.GameObject child);
                /*0x7bd339c*/ void Update();
            }

            class DebugUIHandlerToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ UnityEngine.Rendering.DebugUI.BoolField m_Field;

                /*0x7bd3adc*/ DebugUIHandlerToggle();
                /*0x7bd37a8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd38d4*/ void OnToggleValueChanged(bool value);
                /*0x7bd38fc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd3954*/ void OnDeselection();
                /*0x7bd39a4*/ void OnAction();
                /*0x7bd3a2c*/ void UpdateValueLabel();
            }

            class DebugUIHandlerToggleHistory : UnityEngine.Rendering.UI.DebugUIHandlerToggle
            {
                static float k_XOffset = 230;
                /*0x80*/ UnityEngine.UI.Toggle[] historyToggles;

                /*0x7bd40c4*/ DebugUIHandlerToggleHistory();
                /*0x7bd3af8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd3ea0*/ void UpdateValueLabel();
                /*0x7bd4030*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory <>4__this;

                    /*0x7bd409c*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x7bd40e0*/ void System.IDisposable.Dispose();
                    /*0x7bd40e4*/ bool MoveNext();
                    /*0x7bd41a0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7bd41a8*/ void System.Collections.IEnumerator.Reset();
                    /*0x7bd41e0*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerUIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.UIntField m_Field;

                /*0x7bd44ec*/ DebugUIHandlerUIntField();
                /*0x7bd41e8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd4374*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd43cc*/ void OnDeselection();
                /*0x7bd441c*/ void OnIncrement(bool fast);
                /*0x7bd44e0*/ void OnDecrement(bool fast);
                /*0x7bd4428*/ void ChangeValue(bool fast, int multiplier);
                /*0x7bd4290*/ void UpdateValueLabel();
            }

            class DebugUIHandlerValue : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color k_ZeroColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Value m_Field;
                /*0x78*/ float m_Timer;

                static /*0x7bd47e4*/ DebugUIHandlerValue();
                /*0x7bd47c8*/ DebugUIHandlerValue();
                /*0x7bd4508*/ void OnEnable();
                /*0x7bd4510*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd45ac*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd4604*/ void OnDeselection();
                /*0x7bd4654*/ void Update();
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

                static /*0x7bd4f1c*/ DebugUIHandlerValueTuple();
                /*0x7bd4f00*/ DebugUIHandlerValueTuple();
                /*0x7bd4834*/ void OnEnable();
                /*0x7bd483c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd4874*/ void OnDeselection();
                /*0x7bd48a4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd4c40*/ void UpdateValueLabels();
                /*0x7bd4e84*/ void Update();
            }

            class DebugUIHandlerVBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bd5150*/ DebugUIHandlerVBox();
                /*0x7bd4f6c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd4fe0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd5098*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerVector2 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.DebugUI.Vector2Field m_Field;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x7bd57d8*/ DebugUIHandlerVector2();
                /*0x7bd516c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd5500*/ void SetValue(float v, bool x, bool y);
                /*0x7bd53d0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bd5594*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd5678*/ void OnDeselection();
                /*0x7bd56a8*/ void OnIncrement(bool fast);
                /*0x7bd56c8*/ void OnDecrement(bool fast);
                /*0x7bd56e8*/ void OnAction();
                /*0x7bd5710*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bd57f4*/ float <SetWidget>b__6_0();
                /*0x7bd5844*/ void <SetWidget>b__6_1(float x);
                /*0x7bd5850*/ float <SetWidget>b__6_2();
                /*0x7bd58a8*/ void <SetWidget>b__6_3(float x);
                /*0x7bd58b4*/ float <SetupSettings>b__8_0();
                /*0x7bd58d0*/ float <SetupSettings>b__8_1();
                /*0x7bd58ec*/ float <SetupSettings>b__8_2();
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

                /*0x7bd6048*/ DebugUIHandlerVector3();
                /*0x7bd590c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd5d64*/ void SetValue(float v, bool x, bool y, bool z);
                /*0x7bd5c34*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bd5e04*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd5ee8*/ void OnDeselection();
                /*0x7bd5f18*/ void OnIncrement(bool fast);
                /*0x7bd5f38*/ void OnDecrement(bool fast);
                /*0x7bd5f58*/ void OnAction();
                /*0x7bd5f80*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bd6064*/ float <SetWidget>b__7_0();
                /*0x7bd60b4*/ void <SetWidget>b__7_1(float v);
                /*0x7bd60c4*/ float <SetWidget>b__7_2();
                /*0x7bd611c*/ void <SetWidget>b__7_3(float v);
                /*0x7bd612c*/ float <SetWidget>b__7_4();
                /*0x7bd6184*/ void <SetWidget>b__7_5(float v);
                /*0x7bd6194*/ float <SetupSettings>b__9_0();
                /*0x7bd61b0*/ float <SetupSettings>b__9_1();
                /*0x7bd61cc*/ float <SetupSettings>b__9_2();
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

                /*0x7bd6a00*/ DebugUIHandlerVector4();
                /*0x7bd61ec*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd6708*/ void SetValue(float v, bool x, bool y, bool z, bool w);
                /*0x7bd65d8*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x7bd67bc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd68a0*/ void OnDeselection();
                /*0x7bd68d0*/ void OnIncrement(bool fast);
                /*0x7bd68f0*/ void OnDecrement(bool fast);
                /*0x7bd6910*/ void OnAction();
                /*0x7bd6938*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x7bd6a1c*/ float <SetWidget>b__8_0();
                /*0x7bd6a6c*/ void <SetWidget>b__8_1(float x);
                /*0x7bd6a80*/ float <SetWidget>b__8_2();
                /*0x7bd6ad8*/ void <SetWidget>b__8_3(float x);
                /*0x7bd6aec*/ float <SetWidget>b__8_4();
                /*0x7bd6b44*/ void <SetWidget>b__8_5(float x);
                /*0x7bd6b58*/ float <SetWidget>b__8_6();
                /*0x7bd6bb0*/ void <SetWidget>b__8_7(float x);
                /*0x7bd6bc4*/ float <SetupSettings>b__10_0();
                /*0x7bd6be0*/ float <SetupSettings>b__10_1();
                /*0x7bd6bfc*/ float <SetupSettings>b__10_2();
            }

            class DebugUIHandlerWidget : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Color colorDefault;
                /*0x30*/ UnityEngine.Color colorSelected;
                /*0x40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.DebugUI.Widget m_Widget;

                /*0x7bcc490*/ DebugUIHandlerWidget();
                /*0x7bd6c1c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler();
                /*0x7bd6c24*/ void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bd6c2c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler();
                /*0x7bd6c34*/ void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bd6c3c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler();
                /*0x7bd6c44*/ void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x7bd6c4c*/ void OnEnable();
                /*0x7bd6c50*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x7bd6c58*/ UnityEngine.Rendering.DebugUI.Widget GetWidget();
                /*0x3907c14*/ T CastWidget<T>();
                /*0x7bd6c60*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x7bd6c68*/ void OnDeselection();
                /*0x7bd6c6c*/ void OnAction();
                /*0x7bd6c70*/ void OnIncrement(bool fast);
                /*0x7bd6c74*/ void OnDecrement(bool fast);
                /*0x7bd6c78*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous();
                /*0x7bcc2e0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class UIFoldout : UnityEngine.UI.Toggle
            {
                /*0x128*/ UnityEngine.GameObject content;
                /*0x130*/ UnityEngine.GameObject arrowOpened;
                /*0x138*/ UnityEngine.GameObject arrowClosed;

                /*0x7bd6fec*/ UIFoldout();
                /*0x7bd6d24*/ void Start();
                /*0x7bd6df0*/ void OnValidate();
                /*0x7bd6de4*/ void SetState(bool state);
                /*0x7bd6dfc*/ void SetState(bool state, bool rebuildLayout);
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
