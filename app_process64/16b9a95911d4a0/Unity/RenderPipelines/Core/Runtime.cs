class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3ad3864*/ EmbeddedAttribute();
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
                /*0x3ad386c*/ IsUnmanagedAttribute();
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

    static /*0x3ad3da4*/ RenderGraphCompilationCache();
    static /*0x1ffc854*/ int HashEntryComparer<T>(RenderGraphCompilationCache.HashEntry<T> a, RenderGraphCompilationCache.HashEntry<T> b);
    /*0x3ad3874*/ RenderGraphCompilationCache();
    /*0x1ffc854*/ bool GetCompilationCache<T>(int hash, int frameIndex, ref T outGraph, UnityEngine.Rendering.DynamicArray<RenderGraphCompilationCache.HashEntry<T>> hashEntries, System.Collections.Generic.Stack<T> pool, UnityEngine.Rendering.DynamicArray.SortComparer<RenderGraphCompilationCache.HashEntry<T>> comparer);
    /*0x3ad3abc*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph outGraph);
    /*0x3ad3b74*/ bool GetCompilationCache(int hash, int frameIndex, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData outGraph);
    /*0x3ad3c2c*/ void Clear();

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

        static /*0x1f33998*/ <>c__();
        /*0x1f309e4*/ <>c__();
        /*0x1ffc854*/ bool <GetCompilationCache>b__11_0(RenderGraphCompilationCache.HashEntry<T> value);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3ad3ea4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3ad3f98*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        static /*0x3ad3fe0*/ float NormalizeAngleDegree(float angle);
        /*0x3ad5400*/ LightAnchor();
        /*0x3ad3fa0*/ float get_yaw();
        /*0x3ad3fa8*/ void set_yaw(float value);
        /*0x3ad4014*/ float get_pitch();
        /*0x3ad401c*/ void set_pitch(float value);
        /*0x3ad4054*/ float get_roll();
        /*0x3ad405c*/ void set_roll(float value);
        /*0x3ad4094*/ float get_distance();
        /*0x3ad409c*/ void set_distance(float value);
        /*0x3ad40c0*/ UnityEngine.LightAnchor.UpDirection get_frameSpace();
        /*0x3ad40c8*/ void set_frameSpace(UnityEngine.LightAnchor.UpDirection value);
        /*0x3ad40d0*/ UnityEngine.Vector3 get_anchorPosition();
        /*0x3ad41dc*/ UnityEngine.Transform get_anchorPositionOverride();
        /*0x3ad41e4*/ void set_anchorPositionOverride(UnityEngine.Transform value);
        /*0x3ad41ec*/ UnityEngine.Vector3 get_anchorPositionOffset();
        /*0x3ad41f8*/ void set_anchorPositionOffset(UnityEngine.Vector3 value);
        /*0x3ad4204*/ void SynchronizeOnTransform(UnityEngine.Camera camera);
        /*0x3ad4ef0*/ void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x3ad46d0*/ UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x3ad5230*/ void Update();
        /*0x3ad5330*/ void OnDrawGizmosSelected();
        /*0x3ad4f58*/ void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor);

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

                static /*0x3ad5474*/ XRBuiltinShaderConstants();
                static /*0x3ad5408*/ void UpdateBuiltinShaderConstants(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex);
                static /*0x3ad540c*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x3ad5410*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.RasterCommandBuffer cmd);
                static /*0x3ad5470*/ void Update(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
            }

            class XRLayout
            {
                /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> m_ActivePasses;

                /*0x3ad60ec*/ XRLayout();
                /*0x3ad57e8*/ void AddCamera(UnityEngine.Camera camera, bool enableXR);
                /*0x3ad59dc*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                /*0x3ad5a3c*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> GetActivePasses();
                /*0x3ad5924*/ void AddPass(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x3ad5a44*/ void Clear();
                /*0x3ad5b9c*/ void LogDebugInfo();
            }

            class XRLayoutStack : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Stack<UnityEngine.Experimental.Rendering.XRLayout> m_Stack;

                /*0x3ad640c*/ XRLayoutStack();
                /*0x3ad6174*/ UnityEngine.Experimental.Rendering.XRLayout New();
                /*0x3ad6220*/ UnityEngine.Experimental.Rendering.XRLayout get_top();
                /*0x3ad627c*/ void Release();
                /*0x3ad6378*/ void Dispose();
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

                static /*0x3ad6494*/ XRMirrorView();
            }

            class XROcclusionMesh
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler k_OcclusionMeshProfilingSampler;
                /*0x10*/ UnityEngine.Experimental.Rendering.XRPass m_Pass;
                /*0x18*/ UnityEngine.Mesh m_CombinedMesh;
                /*0x20*/ UnityEngine.Material m_Material;
                /*0x28*/ int m_CombinedMeshHashCode;

                static /*0x3ad6e10*/ XROcclusionMesh();
                /*0x3ad6764*/ XROcclusionMesh(UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x3ad6794*/ void SetMaterial(UnityEngine.Material mat);
                /*0x3ad679c*/ bool get_hasValidOcclusionMesh();
                /*0x3ad68b4*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, float occlusionMeshScale, bool yFlip);
                /*0x3ad696c*/ void UpdateCombinedMesh();
                /*0x3ad67e0*/ bool IsOcclusionMeshSupported();
                /*0x3ad69c0*/ bool TryGetOcclusionMeshCombinedHashCode(ref int hashCode);
                /*0x3ad6ab4*/ void CreateOcclusionMeshCombined();
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
                /*0x72a*/ bool spaceWarpRightHandedNDC;
            }

            class XRPass
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.XRView> m_Views;
                /*0x18*/ UnityEngine.Experimental.Rendering.XROcclusionMesh m_OcclusionMesh;
                /*0x20*/ bool <copyDepth>k__BackingField;
                /*0x21*/ bool <hasMotionVectorPass>k__BackingField;
                /*0x22*/ bool <spaceWarpRightHandedNDC>k__BackingField;
                /*0x24*/ int <multipassId>k__BackingField;
                /*0x28*/ int <cullingPassId>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier <renderTarget>k__BackingField;
                /*0x58*/ UnityEngine.RenderTextureDescriptor <renderTargetDesc>k__BackingField;
                /*0x90*/ UnityEngine.Rendering.RenderTargetIdentifier <motionVectorRenderTarget>k__BackingField;
                /*0xb8*/ UnityEngine.RenderTextureDescriptor <motionVectorRenderTargetDesc>k__BackingField;
                /*0xf0*/ UnityEngine.Rendering.ScriptableCullingParameters <cullingParams>k__BackingField;
                /*0x728*/ nint <foveatedRenderingInfo>k__BackingField;
                /*0x730*/ float <occlusionMeshScale>k__BackingField;

                static /*0x3ad6f80*/ UnityEngine.Experimental.Rendering.XRPass CreateDefault(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x3ad6eac*/ XRPass();
                /*0x3ad72f4*/ void Release();
                /*0x3ad5a1c*/ bool get_enabled();
                /*0x3ad7360*/ bool get_supportsFoveatedRendering();
                /*0x3ad7368*/ bool get_copyDepth();
                /*0x3ad7370*/ void set_copyDepth(bool value);
                /*0x3ad7378*/ bool get_hasMotionVectorPass();
                /*0x3ad7380*/ void set_hasMotionVectorPass(bool value);
                /*0x3ad7388*/ bool get_spaceWarpRightHandedNDC();
                /*0x3ad7390*/ void set_spaceWarpRightHandedNDC(bool value);
                /*0x3ad7398*/ bool get_isFirstCameraPass();
                /*0x3ad73a8*/ bool get_isLastCameraPass();
                /*0x3ad7414*/ int get_multipassId();
                /*0x3ad741c*/ void set_multipassId(int value);
                /*0x3ad7424*/ int get_cullingPassId();
                /*0x3ad742c*/ void set_cullingPassId(int value);
                /*0x3ad7434*/ UnityEngine.Rendering.RenderTargetIdentifier get_renderTarget();
                /*0x3ad7448*/ void set_renderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x3ad745c*/ UnityEngine.RenderTextureDescriptor get_renderTargetDesc();
                /*0x3ad747c*/ void set_renderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x3ad749c*/ UnityEngine.Rendering.RenderTargetIdentifier get_motionVectorRenderTarget();
                /*0x3ad74b0*/ void set_motionVectorRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x3ad74c4*/ UnityEngine.RenderTextureDescriptor get_motionVectorRenderTargetDesc();
                /*0x3ad74e4*/ void set_motionVectorRenderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x3ad7504*/ UnityEngine.Rendering.ScriptableCullingParameters get_cullingParams();
                /*0x3ad7514*/ void set_cullingParams(UnityEngine.Rendering.ScriptableCullingParameters value);
                /*0x3ad60a4*/ int get_viewCount();
                /*0x3ad6828*/ bool get_singlePassEnabled();
                /*0x3ad7520*/ nint get_foveatedRenderingInfo();
                /*0x3ad7528*/ void set_foveatedRenderingInfo(nint value);
                /*0x3ad7530*/ bool get_isHDRDisplayOutputActive();
                /*0x3ad7538*/ UnityEngine.ColorGamut get_hdrDisplayOutputColorGamut();
                /*0x3ad7540*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation();
                /*0x3ad757c*/ float get_occlusionMeshScale();
                /*0x3ad7584*/ void set_occlusionMeshScale(float value);
                /*0x3ad758c*/ UnityEngine.Matrix4x4 GetProjMatrix(int viewIndex);
                /*0x3ad7618*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x3ad76a4*/ bool GetPrevViewValid(int viewIndex);
                /*0x3ad771c*/ UnityEngine.Matrix4x4 GetPrevViewMatrix(int viewIndex);
                /*0x3ad5fb8*/ UnityEngine.Rect GetViewport(int viewIndex);
                /*0x3ad6840*/ UnityEngine.Mesh GetOcclusionMesh(int viewIndex);
                /*0x3ad6030*/ int GetTextureArraySlice(int viewIndex);
                /*0x3ad6934*/ void StartSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3ad77a8*/ void StartSinglePass(UnityEngine.Rendering.IRasterCommandBuffer cmd);
                /*0x3ad6908*/ void StopSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x3ad7848*/ void StopSinglePass(UnityEngine.Rendering.BaseCommandBuffer cmd);
                /*0x3ad787c*/ bool get_hasValidOcclusionMesh();
                /*0x3ad789c*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
                /*0x3ad78c4*/ void RenderOcclusionMesh(UnityEngine.Rendering.RasterCommandBuffer cmd, bool renderIntoTexture);
                /*0x3ad78f8*/ void RenderDebugXRViewsFrustum();
                /*0x3ad7b80*/ UnityEngine.Vector4 ApplyXRViewCenterOffset(UnityEngine.Vector2 center);
                /*0x3ad7cc4*/ void AssignView(int viewId, UnityEngine.Experimental.Rendering.XRView xrView);
                /*0x3ad7db0*/ void AssignCullingParams(int cullingPassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                /*0x3ad5a28*/ void UpdateCombinedOcclusionMesh();
                /*0x3ad705c*/ void InitBase(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x3ad7e3c*/ void AddView(UnityEngine.Experimental.Rendering.XRView xrView);
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
                static /*0x10*/ UnityEngine.Rendering.MSAASamples s_MSAASamples;
                static /*0x18*/ UnityEngine.Material s_OcclusionMeshMaterial;
                static /*0x20*/ UnityEngine.Material s_MirrorViewMaterial;
                static /*0x28*/ System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> s_LayoutOverride;
                static /*0x30*/ UnityEngine.Experimental.Rendering.XRPass emptyPass;
                static /*0x38*/ bool <singlePassAllowed>k__BackingField;
                static /*0x3c*/ UnityEngine.Rendering.FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField;
                static /*0x40*/ bool <dumpDebugInfo>k__BackingField;

                static /*0x3ad8b1c*/ XRSystem();
                static /*0x3ad5914*/ bool get_displayActive();
                static /*0x3ad7fd0*/ bool get_isHDRDisplayOutputActive();
                static /*0x3ad7fd8*/ bool get_singlePassAllowed();
                static /*0x3ad8030*/ void set_singlePassAllowed(bool value);
                static /*0x3ad8090*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
                static /*0x3ad80e8*/ void set_foveatedRenderingCaps(UnityEngine.Rendering.FoveatedRenderingCaps value);
                static /*0x3ad8144*/ bool get_dumpDebugInfo();
                static /*0x3ad819c*/ void set_dumpDebugInfo(bool value);
                static /*0x3ad81fc*/ void Initialize(System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> passAllocator, UnityEngine.Shader occlusionMeshPS, UnityEngine.Shader mirrorViewPS);
                static /*0x3ad8628*/ void SetDisplayMSAASamples(UnityEngine.Rendering.MSAASamples msaaSamples);
                static /*0x3ad86a4*/ UnityEngine.Rendering.MSAASamples GetDisplayMSAASamples();
                static /*0x3ad86fc*/ void SetOcclusionMeshScale(float occlusionMeshScale);
                static /*0x3ad8700*/ float GetOcclusionMeshScale();
                static /*0x3ad8708*/ void SetMirrorViewMode(int mirrorBlitMode);
                static /*0x3ad870c*/ int GetMirrorViewMode();
                static /*0x3ad8714*/ void SetRenderScale(float renderScale);
                static /*0x3ad8718*/ float GetRenderViewportScale();
                static /*0x3ad8720*/ UnityEngine.Experimental.Rendering.XRLayout NewLayout();
                static /*0x3ad8780*/ void EndLayout();
                static /*0x3ad8858*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                static /*0x3ad885c*/ void Dispose();
                static /*0x3ad591c*/ void SetDisplayZRange(float zNear, float zFar);
                static /*0x3ad89fc*/ void SetLayoutOverride(System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> action);
                static /*0x3ad8a5c*/ void XRSystemInit();
                static /*0x3ad8624*/ void RefreshDeviceInfo();
                static /*0x3ad5920*/ void CreateDefaultLayout(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRLayout layout);
                static /*0x3ad5a24*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
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

                static /*0x3ad8cb8*/ UnityEngine.Vector2 ComputeEyeCenterUV(UnityEngine.Matrix4x4 proj);
                /*0x3ad8c18*/ XRView(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, UnityEngine.Rect viewport, UnityEngine.Mesh occlusionMesh, int textureArraySlice);
            }
        }
    }

    namespace Rendering
    {
        interface IPerFrameHistoryAccessTracker
        {
            /*0x1f309e4*/ void RequestAccess<Type>();
        }

        interface ICameraHistoryWriteAccess
        {
            /*0x1f2fe14*/ bool IsAccessRequested<Type>();
            /*0x1ffc854*/ Type GetHistoryForWrite<Type>();
            /*0x1f2fe14*/ bool IsWritten<Type>();
        }

        interface ICameraHistoryReadAccess
        {
            /*0x1ffc854*/ Type GetHistoryForRead<Type>();
            /*0x1f30ebc*/ void add_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);
            /*0x1f30ebc*/ void remove_OnGatherHistoryRequests(UnityEngine.Rendering.ICameraHistoryReadAccess.HistoryRequestDelegate value);

            class HistoryRequestDelegate : System.MulticastDelegate
            {
                /*0x3ad8d54*/ HistoryRequestDelegate(object object, nint method);
                /*0x3ad8e5c*/ void Invoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess);
                /*0x3ad8e70*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.IPerFrameHistoryAccessTracker historyAccess, System.AsyncCallback callback, object object);
                /*0x3ad8e90*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class CameraHistoryItem : UnityEngine.Rendering.ContextItem
        {
            /*0x10*/ UnityEngine.Rendering.BufferedRTHandleSystem m_owner;
            /*0x18*/ uint m_TypeId;

            /*0x3ad8f7c*/ CameraHistoryItem();
            /*0x3ad8e9c*/ void OnCreate(UnityEngine.Rendering.BufferedRTHandleSystem owner, uint typeId);
            /*0x3ad8ec8*/ UnityEngine.Rendering.BufferedRTHandleSystem get_storage();
            /*0x3ad8ed0*/ int MakeId(uint index);
            /*0x3ad8ee0*/ UnityEngine.Rendering.RTHandle AllocHistoryFrameRT(int id, int count, ref UnityEngine.RenderTextureDescriptor desc, string name);
            /*0x3ad8f48*/ void ReleaseHistoryFrameRT(int id);
            /*0x3ad8f60*/ UnityEngine.Rendering.RTHandle GetPreviousFrameRT(int id);
            /*0x3ad8f2c*/ UnityEngine.Rendering.RTHandle GetCurrentFrameRT(int id);
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

            /*0x3ad9888*/ CameraSwitcher();
            /*0x3ad8f94*/ void OnEnable();
            /*0x3ad9578*/ void OnDisable();
            /*0x3ad955c*/ int GetCameraCount();
            /*0x3ad9608*/ UnityEngine.Camera GetNextCamera();
            /*0x3ad9650*/ void SetCameraIndex(int index);
            /*0x3ad9898*/ int <OnEnable>b__10_0();
            /*0x3ad98a0*/ void <OnEnable>b__10_1(int value);
            /*0x3ad98a4*/ int <OnEnable>b__10_2();
            /*0x3ad98ac*/ void <OnEnable>b__10_3(int value);
        }

        class FreeCamera : UnityEngine.MonoBehaviour
        {
            static float k_MouseSensitivityMultiplier = 0.009999999776482582;
            static /*0x0*/ string kMouseX;
            static /*0x8*/ string kMouseY;
            static /*0x10*/ string kRightStickX;
            static /*0x18*/ string kRightStickY;
            static /*0x20*/ string kVertical;
            static /*0x28*/ string kHorizontal;
            static /*0x30*/ string kYAxis;
            static /*0x38*/ string kSpeedAxis;
            /*0x20*/ float m_LookSpeedController;
            /*0x24*/ float m_LookSpeedMouse;
            /*0x28*/ float m_MoveSpeed;
            /*0x2c*/ float m_MoveSpeedIncrement;
            /*0x30*/ float m_Turbo;
            /*0x34*/ float inputRotateAxisX;
            /*0x38*/ float inputRotateAxisY;
            /*0x3c*/ float inputChangeSpeed;
            /*0x40*/ float inputVertical;
            /*0x44*/ float inputHorizontal;
            /*0x48*/ float inputYAxis;
            /*0x4c*/ bool leftShiftBoost;
            /*0x4d*/ bool leftShift;
            /*0x4e*/ bool fire1;

            static /*0x3ad9e34*/ FreeCamera();
            /*0x3ad9e18*/ FreeCamera();
            /*0x3ad98b4*/ void OnEnable();
            /*0x3ad98b8*/ void RegisterInputs();
            /*0x3ad98bc*/ void UpdateInputs();
            /*0x3ad9a8c*/ void Update();
        }

        class BaseCommandBuffer
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_WrappedCommandBuffer;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_ExecutingPass;

            /*0x3ad9fd4*/ BaseCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x3ada054*/ string get_name();
            /*0x3ada06c*/ int get_sizeInBytes();
            /*0x3ada084*/ void ThrowIfGlobalStateNotAllowed();
            /*0x3ada10c*/ void ThrowIfRasterNotAllowed();
            /*0x3ada1a0*/ void ValidateTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x3ada388*/ void ValidateTextureHandleRead(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
            /*0x3ada518*/ void ValidateTextureHandleWrite(UnityEngine.Rendering.RenderGraphModule.TextureHandle h);
        }

        struct CommandBufferHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rasterCmd;
            static /*0x8*/ UnityEngine.Rendering.ComputeCommandBuffer computeCmd;
            static /*0x10*/ UnityEngine.Rendering.UnsafeCommandBuffer unsafeCmd;

            static /*0x3ada938*/ CommandBufferHelpers();
            static /*0x3ada714*/ UnityEngine.Rendering.RasterCommandBuffer GetRasterCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x3ada790*/ UnityEngine.Rendering.ComputeCommandBuffer GetComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x3ada80c*/ UnityEngine.Rendering.UnsafeCommandBuffer GetUnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer baseBuffer);
            static /*0x3ada888*/ UnityEngine.Rendering.CommandBuffer GetNativeCommandBuffer(UnityEngine.Rendering.UnsafeCommandBuffer baseBuffer);
            static /*0x3ada89c*/ void VFXManager_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
        }

        class ComputeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x3adaa50*/ ComputeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x3adaa58*/ void SetInvertCulling(bool invertCulling);
            /*0x3adaa74*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x3adaa8c*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x3adaaa4*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x3adaabc*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3adaad4*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3adab10*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3adab28*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x3adab40*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x3adab58*/ void DisableScissorRect();
            /*0x3adab70*/ void SetGlobalFloat(int nameID, float value);
            /*0x3adab88*/ void SetGlobalInt(int nameID, int value);
            /*0x3adaba0*/ void SetGlobalInteger(int nameID, int value);
            /*0x3adabb8*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3adabd0*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3adabe8*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x3adac24*/ void EnableShaderKeyword(string keyword);
            /*0x3adac3c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adac54*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adac6c*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adac84*/ void DisableShaderKeyword(string keyword);
            /*0x3adac9c*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adacb4*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adaccc*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adace4*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3adad00*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adad1c*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adad38*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x3adad88*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x3adada0*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x3adadb8*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x3adadd0*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3adade8*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x3adae00*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x3adae18*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x3adae30*/ void BeginSample(string name);
            /*0x3adae48*/ void EndSample(string name);
            /*0x3adae60*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3adae78*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3adae90*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3adae94*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3adae98*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3adaed4*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3adaeec*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3adaf04*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x3adaf1c*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3adaf34*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3adaf4c*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x3adaf64*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x3adaf7c*/ void InvokeOnRenderObjectCallbacks();
            /*0x3adaf94*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x3adafac*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x3adafc4*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x3adafdc*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x3adaff4*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3adb030*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3adb048*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x3adb060*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x3adb078*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x3adb090*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3adb0a8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adb17c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adb250*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3adb32c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3adb408*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adb4f4*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adb5e0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3adb5f8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3adb610*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3adb62c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3adb648*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3adb660*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3adb678*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3adb690*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3adb6a8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3adb6c0*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3adb6d8*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3adb6f0*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3adb708*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x3adb720*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x3adb738*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x3adb750*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3adb768*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3adb780*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3adb798*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3adb7b0*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3adb7c8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3adb7e0*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3adb7f8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3adb810*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3adb82c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3adb848*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3adb860*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3adb878*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3adb890*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3adb8a8*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adb96c*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adba30*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x3adba48*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x3adba60*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x3adba78*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x3adba90*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x3adbaa8*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x3adbac0*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x3adbad8*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x3adbaf0*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x3adbb08*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x3adbb20*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x3adbb38*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3adbb50*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3adbb8c*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3adbbc8*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3adbbe0*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3adbbf8*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x3adbc10*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3adbc28*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3adbc40*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3adbc58*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3adbc70*/ void SetGlobalFloat(string name, float value);
            /*0x3adbc88*/ void SetGlobalInt(string name, int value);
            /*0x3adbca0*/ void SetGlobalInteger(string name, int value);
            /*0x3adbcb8*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x3adbcd0*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x3adbce8*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x3adbd24*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x3adbd3c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x3adbd54*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x3adbd6c*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3adbd84*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3adbd9c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x3adbdb4*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3adbdcc*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3adbde4*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3adbdfc*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3adbeb8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3adbf74*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adc038*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adc0fc*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x3adc114*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3adc12c*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x3adc144*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x3adc15c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x3adc174*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x3adc18c*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x3adc1a4*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3adc1bc*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3adc1f8*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3adc210*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3adc228*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3adc240*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3adc290*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x3adc2a8*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adc2c0*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc2d8*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc2f0*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adc308*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc320*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc338*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3adc354*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adc370*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        interface IBaseCommandBuffer
        {
            /*0x1f30a84*/ void SetInvertCulling(bool invertCulling);
            void SetViewport(UnityEngine.Rect pixelRect);
            void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x1f309e4*/ void DisableScissorRect();
            void SetGlobalFloat(int nameID, float value);
            /*0x1f30bb4*/ void SetGlobalInt(int nameID, int value);
            /*0x1f30bb4*/ void SetGlobalInteger(int nameID, int value);
            void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x1ffc854*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x1f30ebc*/ void EnableShaderKeyword(string keyword);
            /*0x1f30ebc*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x1f30ff0*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x1f30ff0*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x1f30ebc*/ void DisableShaderKeyword(string keyword);
            /*0x1f30ebc*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x1f30ff0*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x1f30ff0*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x1ffc854*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x1f30c88*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x1f30c88*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x1f30c88*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x1f30ebc*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x1f30bb4*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x1f30b78*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x1f30ebc*/ void BeginSample(string name);
            /*0x1f30ebc*/ void EndSample(string name);
            /*0x1f30ebc*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x1f30ebc*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x1ffc854*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x1ffc854*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x1ffc854*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x1f30ebc*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x1f309e4*/ void InvokeOnRenderObjectCallbacks();
            void SetGlobalFloat(string name, float value);
            /*0x1f30ee8*/ void SetGlobalInt(string name, int value);
            /*0x1f30ee8*/ void SetGlobalInteger(string name, int value);
            /*0x1ffc854*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x1ffc854*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x1f30ff0*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x1f30c88*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x1f30ff0*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x1f30ff0*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x1f30c88*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x1f30ff0*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x1f30ff0*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x1f30c88*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x1f30ff0*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x1ffc854*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x1ffc854*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x1ffc854*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x1ffc854*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x1f30ff0*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x1f30c88*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x1f30ff0*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x1f30c88*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x1ffc854*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x1f30b78*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            void IssuePluginEvent(nint callback, int eventID);
            void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x1ffc854*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x1ffc854*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
        }

        interface IComputeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x1ffc854*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x1f30f2c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x1ffc854*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x1f30f2c*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x1f30ff0*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x1f30ff0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x1f3102c*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x1ffc854*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x1f310fc*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x1ffc854*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x1f310fc*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x1f310fc*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x1f30f2c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x1f310fc*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x1f30f2c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x1ffc854*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x1f30f6c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x1ffc854*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x1ffc854*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x1f30f6c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x1ffc854*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x1ffc854*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x1ffc854*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x1f30ebc*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x1ffc854*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x1f310fc*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x1f30f2c*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x1f30f6c*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x1f310fc*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x1f30f2c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x1f310fc*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x1f30f2c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x1ffc854*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x1ffc854*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x1ffc854*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x1ffc854*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x1ffc854*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x1f310fc*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x1f30f2c*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x1f3102c*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x1f310fc*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x1f30f2c*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x1ffc854*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x1ffc854*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x1f310fc*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x1f30f2c*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x1ffc854*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x1ffc854*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x1f310fc*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x1f30f2c*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x1ffc854*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
        }

        interface IRasterCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x1ffc854*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x1ffc854*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x1ffc854*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x1ffc854*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x1ffc854*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x1f316b8*/ void SetInstanceMultiplier(uint multiplier);
            /*0x1f30b78*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x1f30a84*/ void SetWireframe(bool enable);
            void ConfigureFoveatedRendering(nint platformData);
            /*0x1ffc854*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x1ffc854*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x1ffc854*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x1ffc854*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x1f3102c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x1f30ff0*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x1ffc854*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x1ffc854*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x1ffc854*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x1ffc854*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x1ffc854*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x1ffc854*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
        }

        interface IUnsafeCommandBuffer : UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x1f309e4*/ void Clear();
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x1ffc854*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
        }

        class RasterCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer
        {
            /*0x3adaa4c*/ RasterCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x3adc38c*/ void SetInvertCulling(bool invertCulling);
            /*0x3adc3a8*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x3adc3c0*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x3adc3d8*/ void DisableScissorRect();
            /*0x3adc3f0*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x3adc410*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x3adc430*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3adc450*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3adc468*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x3adc480*/ void SetGlobalFloat(int nameID, float value);
            /*0x3adc498*/ void SetGlobalInt(int nameID, int value);
            /*0x3adc4b0*/ void SetGlobalInteger(int nameID, int value);
            /*0x3adc4c8*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3adc4e0*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3adc4f8*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x3adc534*/ void EnableShaderKeyword(string keyword);
            /*0x3adc54c*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adc564*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc57c*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc594*/ void DisableShaderKeyword(string keyword);
            /*0x3adc5ac*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adc5c4*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc5dc*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adc5f4*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3adc610*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adc62c*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adc648*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x3adc698*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x3adc6b0*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x3adc6c8*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x3adc6e0*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3adc6f8*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x3adc710*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x3adc728*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x3adc740*/ void BeginSample(string name);
            /*0x3adc758*/ void EndSample(string name);
            /*0x3adc770*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3adc788*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3adc7a0*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3adc7a4*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3adc7a8*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3adc7e4*/ void SetInstanceMultiplier(uint multiplier);
            /*0x3adc7fc*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x3adc814*/ void SetWireframe(bool enable);
            /*0x3adc830*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x3adc848*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x3adc860*/ void InvokeOnRenderObjectCallbacks();
            /*0x3adc878*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adc8b4*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3adc8f0*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x3adc92c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x3adc968*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adc984*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3adc99c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x3adc9b4*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x3adc9cc*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3adca08*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adca44*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x3adca80*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x3adcabc*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcafc*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x3adcb38*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x3adcb74*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcbb0*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adcbec*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adcc28*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcc68*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adcca4*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adcce0*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcd1c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adcd58*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adcd94*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcdd4*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adce10*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adce4c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adce68*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x3adce80*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x3adce98*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adceb0*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcecc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adcee4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adcefc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adcf18*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adcf30*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adcf48*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x3adcf60*/ void SetGlobalFloat(string name, float value);
            /*0x3adcf78*/ void SetGlobalInt(string name, int value);
            /*0x3adcf90*/ void SetGlobalInteger(string name, int value);
            /*0x3adcfa8*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x3adcfc0*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x3adcfd8*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x3add014*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x3add02c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x3add044*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x3add05c*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3add074*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3add08c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x3add0a4*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3add0bc*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3add0d4*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3add0ec*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3add1a8*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3add264*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3add328*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3add3ec*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x3add404*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3add41c*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x3add434*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x3add44c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x3add464*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x3add47c*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x3add494*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3add4ac*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3add4e8*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3add500*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3add518*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3add530*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3add580*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x3add598*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3add5b0*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add5c8*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add5e0*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3add5f8*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add610*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add628*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3add644*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3add660*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class UnsafeCommandBuffer : UnityEngine.Rendering.BaseCommandBuffer, UnityEngine.Rendering.IUnsafeCommandBuffer, UnityEngine.Rendering.IBaseCommandBuffer, UnityEngine.Rendering.IRasterCommandBuffer, UnityEngine.Rendering.IComputeCommandBuffer
        {
            /*0x3adaa54*/ UnsafeCommandBuffer(UnityEngine.Rendering.CommandBuffer wrapped, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass executingPass, bool isAsync);
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3add67c*/ void SetInvertCulling(bool invertCulling);
            /*0x3add698*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x3add6b0*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x3add6c8*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x3add6e0*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3add6f8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3add734*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3add74c*/ void Clear();
            /*0x3add764*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x3add77c*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x3add794*/ void DisableScissorRect();
            /*0x3add7ac*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x3add7cc*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x3add7ec*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3add80c*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3add824*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x3add83c*/ void SetGlobalFloat(int nameID, float value);
            /*0x3add854*/ void SetGlobalInt(int nameID, int value);
            /*0x3add86c*/ void SetGlobalInteger(int nameID, int value);
            /*0x3add884*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3add89c*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3add8b4*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x3add8f0*/ void EnableShaderKeyword(string keyword);
            /*0x3add908*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3add920*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add938*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add950*/ void DisableShaderKeyword(string keyword);
            /*0x3add968*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3add980*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add998*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3add9b0*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3add9cc*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3add9e8*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adda04*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x3adda54*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x3adda6c*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x3adda84*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x3adda9c*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3addab4*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x3addacc*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x3addae4*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x3addafc*/ void BeginSample(string name);
            /*0x3addb14*/ void EndSample(string name);
            /*0x3addb2c*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3addb44*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3addb5c*/ void BeginSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3addb60*/ void EndSample(Unity.Profiling.ProfilerMarker marker);
            /*0x3addb64*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3addba0*/ void SetInstanceMultiplier(uint multiplier);
            /*0x3addbb8*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x3addbd0*/ void SetWireframe(bool enable);
            /*0x3addbec*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x3addc04*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3addc40*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x3addc7c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3addcb8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3addcf4*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3addd30*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3addd6c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3adddbc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x3adde0c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3adde5c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3addeac*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3addefc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3addf38*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3addf74*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3addfd8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x3ade014*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3ade02c*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3ade044*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x3ade05c*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3ade074*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3ade08c*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x3ade0a4*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x3ade0bc*/ void InvokeOnRenderObjectCallbacks();
            /*0x3ade0d4*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x3ade0ec*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x3ade104*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x3ade11c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x3ade134*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3ade170*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3ade188*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x3ade1a0*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x3ade1b8*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x3ade1d0*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3ade1e8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3ade2bc*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3ade390*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3ade46c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel);
            /*0x3ade548*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3ade634*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3ade720*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3ade738*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3ade750*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3ade76c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3ade788*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3ade7a0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3ade7b8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3ade7d0*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3ade7e8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3ade800*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3ade818*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3ade830*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3ade848*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x3ade860*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x3ade878*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x3ade890*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3ade8a8*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3ade8c0*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3ade8d8*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3ade8f0*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3ade908*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3ade920*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3ade938*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3ade950*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3ade96c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3ade988*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3ade9a0*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3ade9b8*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3ade9d0*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3ade9e8*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adeaac*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle rt);
            /*0x3adeb70*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x3adeb88*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x3adeba0*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x3adebb8*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x3adebd0*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x3adebe8*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x3adec00*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x3adec18*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x3adec30*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x3adec48*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x3adec60*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x3adec78*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3adec90*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3adeccc*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3aded08*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3aded20*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3aded38*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x3aded50*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3aded8c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3adedc8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x3adee04*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x3adee40*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adee5c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3adee74*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x3adee8c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x3adeea4*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3adeee0*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adef1c*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x3adef58*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x3adef94*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adefd4*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x3adf010*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x3adf04c*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf088*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adf0c4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adf100*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf140*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adf17c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adf1b8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf1f4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adf230*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adf26c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf2ac*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adf2e8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adf324*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf340*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x3adf358*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x3adf370*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf388*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf3a4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3adf3bc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3adf3d4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3adf3f0*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3adf408*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3adf420*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x3adf438*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3adf450*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3adf468*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3adf480*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3adf498*/ void SetGlobalFloat(string name, float value);
            /*0x3adf4b0*/ void SetGlobalInt(string name, int value);
            /*0x3adf4c8*/ void SetGlobalInteger(string name, int value);
            /*0x3adf4e0*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x3adf4f8*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x3adf510*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x3adf54c*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x3adf564*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x3adf57c*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x3adf594*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3adf5ac*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3adf5c4*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x3adf5dc*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3adf5f4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3adf60c*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3adf624*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3adf6e0*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
            /*0x3adf79c*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adf860*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderGraphModule.TextureHandle value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3adf924*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x3adf93c*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3adf954*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x3adf96c*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x3adf984*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x3adf99c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x3adf9b4*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x3adf9cc*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3adf9e4*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3adfa20*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3adfa38*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3adfa50*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3adfa68*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3adfab8*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);
            /*0x3adfad0*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adfae8*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adfb00*/ void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adfb18*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3adfb30*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adfb48*/ void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3adfb60*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3adfb7c*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3adfb98*/ void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        }

        class CommandBufferPool
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;

            static /*0x3adfd8c*/ CommandBufferPool();
            static /*0x3adfbb4*/ UnityEngine.Rendering.CommandBuffer Get();
            static /*0x3adfc64*/ UnityEngine.Rendering.CommandBuffer Get(string name);
            static /*0x3adfd0c*/ void Release(UnityEngine.Rendering.CommandBuffer buffer);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CommandBufferPool.<> <>9;

                static /*0x3adfeac*/ <>c();
                /*0x3adff14*/ <>c();
                /*0x3adff1c*/ void <.cctor>b__4_0(UnityEngine.Rendering.CommandBuffer x);
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

            static /*0x1ffc854*/ TType get_instance();
            static /*0x1f33998*/ void Release();
        }

        class ConstantBuffer
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;

            static /*0x3ae0224*/ ConstantBuffer();
            static /*0x1f370c8*/ void PushGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            static /*0x1f36244*/ void PushGlobal<CBType>(ref CBType data, int shaderId);
            static /*0x1f37438*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1f370c8*/ void Push<CBType>(ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1f37438*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x1f370c8*/ void Push<CBType>(ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x1f36f18*/ void UpdateData<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            static /*0x1f350f8*/ void UpdateData<CBType>(ref CBType data);
            static /*0x1f36244*/ void SetGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            static /*0x1f346e4*/ void SetGlobal<CBType>(int shaderId);
            static /*0x1f370c8*/ void Set<CBType>(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1f36244*/ void Set<CBType>(UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1f36244*/ void Set<CBType>(UnityEngine.Material mat, int shaderId);
            static /*0x3adff34*/ void ReleaseAll();
            static /*0x3ae019c*/ void Register(UnityEngine.Rendering.ConstantBufferBase cb);
            /*0x3ae021c*/ ConstantBuffer();
        }

        class ConstantBufferBase
        {
            /*0x3ae02bc*/ ConstantBufferBase();
            /*0x1f309e4*/ void Release();
        }

        class ConstantBuffer<CBType> : UnityEngine.Rendering.ConstantBufferBase
        {
            /*0x0*/ System.Collections.Generic.HashSet<int> m_GlobalBindings;
            /*0x0*/ CBType[] m_Data;
            /*0x0*/ UnityEngine.ComputeBuffer m_GPUConstantBuffer;

            /*0x1f309e4*/ ConstantBuffer();
            /*0x1f30ff0*/ void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            /*0x1f30ebc*/ void UpdateData(ref CBType data);
            /*0x1f30ee8*/ void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            /*0x1f30b78*/ void SetGlobal(int shaderId);
            /*0x1f3102c*/ void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            /*0x1f30ee8*/ void Set(UnityEngine.ComputeShader cs, int shaderId);
            /*0x1f30ee8*/ void Set(UnityEngine.Material mat, int shaderId);
            /*0x1f30ee8*/ void Set(UnityEngine.MaterialPropertyBlock mpb, int shaderId);
            /*0x1f3102c*/ void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            /*0x1f30ee8*/ void PushGlobal(ref CBType data, int shaderId);
            /*0x1f309e4*/ void Release();
        }

        class ConstantBufferSingleton<CBType> : UnityEngine.Rendering.ConstantBuffer<CBType>
        {
            static /*0x0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;

            static /*0x1f327a0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance();
            static /*0x1f350f8*/ void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value);
            /*0x1f309e4*/ ConstantBufferSingleton();
            /*0x1f309e4*/ void Release();
        }

        class ContextContainer : System.IDisposable
        {
            static /*0x0*/ uint s_TypeCount;
            /*0x10*/ UnityEngine.Rendering.ContextContainer.Item[] m_Items;
            /*0x18*/ System.Collections.Generic.List<uint> m_ActiveItemIndices;

            /*0x3ae0574*/ ContextContainer();
            /*0x1ffc854*/ T Get<T>();
            /*0x1ffc854*/ T Create<T>();
            /*0x1ffc854*/ T GetOrCreate<T>();
            /*0x1f2fe14*/ bool Contains<T>();
            /*0x3ae02c4*/ bool Contains(uint typeId);
            /*0x1ffc854*/ T CreateAndGetData<T>(uint typeId);
            /*0x3ae0310*/ void Dispose();

            class TypeId<T>
            {
                static /*0x0*/ uint value;

                static /*0x1f33998*/ TypeId();
            }

            struct Item
            {
                /*0x10*/ UnityEngine.Rendering.ContextItem storage;
                /*0x18*/ bool isSet;
            }
        }

        class ContextItem
        {
            /*0x3ad8f8c*/ ContextItem();
            /*0x1f309e4*/ void Reset();
        }

        class DisplayInfoAttribute : System.Attribute
        {
            /*0x10*/ string name;
            /*0x18*/ int order;

            /*0x3ae062c*/ DisplayInfoAttribute();
        }

        class AdditionalPropertyAttribute : System.Attribute
        {
            /*0x3ae0634*/ AdditionalPropertyAttribute();
        }

        class HideInDebugUIAttribute : System.Attribute
        {
            /*0x3ae063c*/ HideInDebugUIAttribute();
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
            static /*0x1ffc854*/ void CopyTo<T>(System.Collections.Generic.List<T> list, void* dest, int count);
            static /*0x1ffc854*/ void CopyTo<T>(T[] list, void* dest, int count);
            static /*0x3ae0644*/ void CalculateRadixParams(int radixBits, ref int bitStates);
            static /*0x3ae0654*/ int CalculateRadixSupportSize(int bitStates, int arrayLength);
            static /*0x3ae0660*/ void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, ref uint* bucketIndices, ref uint* bucketSizes, ref uint* bucketPrefix, ref uint* arrayOutput);
            static /*0x3ae0680*/ void MergeSort(uint* array, uint* support, int length);
            static /*0x3ae07a8*/ void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
            static /*0x3ae08b0*/ void MergeSort(Unity.Collections.NativeArray<uint> arr, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray);
            static /*0x3ae09d4*/ void InsertionSort(uint* arr, int length);
            static /*0x3ae0a34*/ void InsertionSort(uint[] arr, int sortSize);
            static /*0x3ae0ac4*/ void InsertionSort(Unity.Collections.NativeArray<uint> arr, int sortSize);
            static /*0x3ae0b84*/ void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length);
            static /*0x3ae0d3c*/ void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits);
            static /*0x3ae0e64*/ void RadixSort(Unity.Collections.NativeArray<uint> array, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray, int radixBits);
            static /*0x3ae0fa8*/ void QuickSort(uint[] arr, int left, int right);
            static /*0x3ae1020*/ void QuickSort(ulong[] arr, int left, int right);
            static /*0x1ffc854*/ void QuickSort<T>(int count, void* data);
            static /*0x1ffc854*/ void QuickSort<TValue, TKey, TGetter>(int count, void* data);
            static /*0x1ffc854*/ void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x1ffc854*/ int IndexOf<T>(void* data, int count, T v);
            static /*0x1ffc854*/ int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x3ae1098*/ int CompareHashes(int oldHashCount, UnityEngine.Hash128* oldHashes, int newHashCount, UnityEngine.Hash128* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x1ffc854*/ void CombineHashes<TValue, TGetter>(int count, void* hashes, UnityEngine.Hash128* outHash);
            static /*0x3ae113c*/ void CombineHashes(int count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash);
            static /*0x1ffc854*/ int Partition<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x3ae119c*/ bool HaveDuplicates(int[] arr);

            struct FixedBufferStringQueue
            {
                /*0x10*/ byte* m_ReadCursor;
                /*0x18*/ byte* m_WriteCursor;
                /*0x20*/ byte* m_BufferEnd;
                /*0x28*/ byte* m_BufferStart;
                /*0x30*/ int m_BufferLength;
                /*0x34*/ int <Count>k__BackingField;

                /*0x3ae138c*/ FixedBufferStringQueue(byte* ptr, int length);
                /*0x3ae137c*/ int get_Count();
                /*0x3ae1384*/ void set_Count(int value);
                /*0x3ae13d8*/ bool TryPush(string v);
                /*0x3ae1488*/ bool TryPop(ref string v);
                /*0x3ae13bc*/ void Clear();
            }

            interface IKeyGetter<TValue, TKey>
            {
                /*0x1ffc854*/ TKey Get(ref TValue v);
            }

            struct DefaultKeyGetter<T> : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<T, T>
            {
                /*0x1ffc854*/ T Get(ref T v);
            }

            struct UintKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<uint, uint>
            {
                /*0x3ae1518*/ uint Get(ref uint v);
            }

            struct UlongKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<ulong, ulong>
            {
                /*0x3ae1520*/ ulong Get(ref ulong v);
            }
        }

        class DynamicArray<T>
        {
            /*0x0*/ T[] m_Array;
            /*0x0*/ int <size>k__BackingField;

            static /*0x1f327cc*/ T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x1ffc854*/ System.ReadOnlySpan<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x1ffc854*/ System.Span<T> op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x1f309e4*/ DynamicArray();
            /*0x1f30b78*/ DynamicArray(int size);
            DynamicArray(int capacity, bool resize);
            /*0x1f30ebc*/ DynamicArray(UnityEngine.Rendering.DynamicArray<T> deepCopy);
            /*0x1f2ffc8*/ int get_size();
            /*0x1f30b78*/ void set_size(int value);
            /*0x1f2ffc8*/ int get_capacity();
            /*0x1f309e4*/ void Clear();
            /*0x1ffc854*/ bool Contains(T item);
            /*0x1f3008c*/ int Add(ref T value);
            /*0x1f30ebc*/ void AddRange(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x1ffc854*/ void Insert(int index, T item);
            /*0x1ffc854*/ bool Remove(T item);
            /*0x1f30b78*/ void RemoveAt(int index);
            /*0x1f30bb4*/ void RemoveRange(int index, int count);
            /*0x1ffc854*/ int FindIndex(int startIndex, int count, System.Predicate<T> match);
            /*0x1ffc854*/ int IndexOf(T item, int index, int count);
            /*0x1ffc854*/ int IndexOf(T item, int index);
            /*0x1ffc854*/ int IndexOf(T item);
            void Resize(int newSize, bool keepContent);
            /*0x1f30b78*/ void ResizeAndClear(int newSize);
            void Reserve(int newCapacity, bool keepContent);
            /*0x1f30240*/ ref T get_Item(int index);
            /*0x1ffc854*/ UnityEngine.Rendering.DynamicArray.Iterator<T> GetEnumerator();
            /*0x1ffc854*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems);
            /*0x1f309e4*/ void BumpVersion();

            struct Iterator<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                /*0x0*/ int index;

                /*0x1f30ebc*/ Iterator(UnityEngine.Rendering.DynamicArray<T> setOwner);
                /*0x1f30214*/ ref T get_Current();
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1f309e4*/ void Reset();
            }

            struct RangeEnumerable<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> iterator;

                /*0x1ffc854*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> GetEnumerator();

                struct RangeIterator<T>
                {
                    /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                    /*0x0*/ int index;
                    /*0x0*/ int first;
                    /*0x0*/ int last;

                    RangeIterator(UnityEngine.Rendering.DynamicArray<T> setOwner, int first, int numItems);
                    /*0x1f30214*/ ref T get_Current();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Reset();
                }
            }

            class SortComparer<T> : System.MulticastDelegate
            {
                SortComparer(object object, nint method);
                /*0x1ffc854*/ int Invoke(T x, T y);
                /*0x1ffc854*/ System.IAsyncResult BeginInvoke(T x, T y, System.AsyncCallback callback, object object);
                /*0x1f3008c*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class DynamicArrayExtensions
        {
            static /*0x1ffc854*/ int Partition<T>(System.Span<T> data, int left, int right);
            static /*0x1ffc854*/ void QuickSort<T>(System.Span<T> data, int left, int right);
            static /*0x1ffc854*/ int Partition<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x1ffc854*/ void QuickSort<T>(System.Span<T> data, int left, int right, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
            static /*0x1f350f8*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array);
            static /*0x1f36f18*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array, UnityEngine.Rendering.DynamicArray.SortComparer<T> comparer);
        }

        class PerformDynamicRes : System.MulticastDelegate
        {
            /*0x3ae1528*/ PerformDynamicRes(object object, nint method);
            /*0x3ae15c4*/ float Invoke();
            /*0x3ae15d8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x3ae15f4*/ float EndInvoke(System.IAsyncResult result);
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

            static /*0x3ae2f98*/ DynamicResolutionHandler();
            static /*0x3ae1814*/ UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera);
            static /*0x3ae1f50*/ UnityEngine.Rendering.DynamicResolutionHandler get_instance();
            static /*0x3ae20e8*/ float DefaultDynamicResMethod();
            static /*0x3ae23dc*/ void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x3ae2494*/ void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x3ae2550*/ void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot);
            static /*0x3ae25ac*/ void ClearSelectedCamera();
            static /*0x3ae2620*/ void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter);
            static /*0x3ae2770*/ void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange);
            /*0x3ae1eb8*/ DynamicResolutionHandler();
            /*0x3ae161c*/ void Reset();
            /*0x3ae1658*/ UnityEngine.Rendering.DynamicResUpscaleFilter get_filter();
            /*0x3ae1660*/ void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value);
            /*0x3ae1668*/ UnityEngine.Vector2Int get_finalViewport();
            /*0x3ae1670*/ void set_finalViewport(UnityEngine.Vector2Int value);
            /*0x3ae1678*/ void set_runUpscalerFilterOnFullResolution(bool value);
            /*0x3ae1680*/ bool get_runUpscalerFilterOnFullResolution();
            /*0x3ae16a0*/ bool get_forcingResolution();
            /*0x3ae16a8*/ bool FlushScalableBufferManagerState();
            /*0x3ae1f40*/ void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value);
            /*0x3ae1f48*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule();
            /*0x3ae20f0*/ void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings);
            /*0x3ae22d8*/ UnityEngine.Vector2 GetResolvedScale();
            /*0x3ae234c*/ float CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, bool forceApply);
            /*0x3ae2768*/ void SetCurrentCameraRequest(bool cameraRequest);
            /*0x3ae2980*/ void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange);
            /*0x3ae2bf0*/ bool SoftwareDynamicResIsEnabled();
            /*0x3ae17e4*/ bool HardwareDynamicResIsEnabled();
            /*0x3ae2c4c*/ bool RequestsHardwareDynamicResolution();
            /*0x3ae2c6c*/ bool DynamicResolutionEnabled();
            /*0x3ae2cb4*/ void ForceSoftwareFallback();
            /*0x3ae2cc0*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size);
            /*0x3ae2d10*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size);
            /*0x3ae2d38*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales);
            /*0x3ae2ebc*/ float GetCurrentScale();
            /*0x3ae2ed8*/ UnityEngine.Vector2Int GetLastScaledSize();
            /*0x3ae2ee0*/ float GetLowResMultiplier(float targetLowRes);
            /*0x3ae2ee8*/ float GetLowResMultiplier(float targetLowRes, float minimumThreshold);

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
            /*0x3ae3208*/ DynamicString();
            /*0x3ae3250*/ DynamicString(string s);
            /*0x3ae3308*/ DynamicString(int capacity);
            /*0x3ae3364*/ void Append(string s);
            /*0x3ae347c*/ void Append(UnityEngine.Rendering.DynamicString s);
            /*0x3ae34d4*/ string ToString();
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

            static /*0x3ae1fa8*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault();
        }

        interface IAdditionalData
        {
        }

        interface IVirtualTexturingEnabledRenderPipeline
        {
            /*0x1f2fe14*/ bool get_virtualTexturingEnabled();
        }

        struct ListBuffer<T>
        {
            /*0x0*/ T* m_BufferPtr;
            /*0x0*/ int m_Capacity;
            /*0x0*/ int* m_CountPtr;

            /*0x1ffc854*/ ListBuffer(T* bufferPtr, int* countPtr, int capacity);
            /*0x1ffc854*/ T* get_BufferPtr();
            /*0x1f2ffc8*/ int get_Count();
            /*0x1f2ffc8*/ int get_Capacity();
            /*0x1f302cc*/ ref T get_Item(ref int index);
            /*0x1f302cc*/ ref T GetUnchecked(ref int index);
            /*0x1f2fec8*/ bool TryAdd(ref T value);
            /*0x1ffc854*/ void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
            /*0x1ffc854*/ bool TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other);
            /*0x1ffc854*/ bool TryCopyFrom(T* srcPtr, int count);
        }

        class ListBufferExtensions
        {
            static /*0x1ffc854*/ void QuickSort<T>(UnityEngine.Rendering.ListBuffer<T> self);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, bool collectionCheck);
            /*0x1f2ffc8*/ int get_countAll();
            /*0x1f30b78*/ void set_countAll(int value);
            /*0x1f2ffc8*/ int get_countActive();
            /*0x1f2ffc8*/ int get_countInactive();
            /*0x1ffc854*/ T Get();
            /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T v);
            /*0x1ffc854*/ void Release(T element);

            struct PooledObject<T> : System.IDisposable
            {
                /*0x0*/ T m_ToReturn;
                /*0x0*/ UnityEngine.Rendering.ObjectPool<T> m_Pool;

                /*0x1ffc854*/ PooledObject(T value, UnityEngine.Rendering.ObjectPool<T> pool);
                /*0x1f309e4*/ void System.IDisposable.Dispose();
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x1f33998*/ GenericPool();
            static /*0x1ffc854*/ T Get();
            static /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x1ffc854*/ void Release(T toRelease);
        }

        class UnsafeGenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x1f33998*/ UnsafeGenericPool();
            static /*0x1ffc854*/ T Get();
            static /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x1ffc854*/ void Release(T toRelease);
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;

            static /*0x1f33998*/ ListPool();
            static /*0x1f327a0*/ System.Collections.Generic.List<T> Get();
            static /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(ref System.Collections.Generic.List<T> value);
            static /*0x1f350f8*/ void Release(System.Collections.Generic.List<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ListPool.<>c<T> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f30ebc*/ void <.cctor>b__4_0(System.Collections.Generic.List<T> l);
            }
        }

        class HashSetPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;

            static /*0x1f33998*/ HashSetPool();
            static /*0x1f327a0*/ System.Collections.Generic.HashSet<T> Get();
            static /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(ref System.Collections.Generic.HashSet<T> value);
            static /*0x1f350f8*/ void Release(System.Collections.Generic.HashSet<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.HashSetPool.<>c<T> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f30ebc*/ void <.cctor>b__4_0(System.Collections.Generic.HashSet<T> l);
            }
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey, TValue>> s_Pool;

            static /*0x1f33998*/ DictionaryPool();
            static /*0x1f327a0*/ System.Collections.Generic.Dictionary<TKey, TValue> Get();
            static /*0x1ffc854*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey, TValue>> Get(ref System.Collections.Generic.Dictionary<TKey, TValue> value);
            static /*0x1f350f8*/ void Release(System.Collections.Generic.Dictionary<TKey, TValue> toRelease);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ UnityEngine.Rendering.DictionaryPool.<>c<TKey, TValue> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f30ebc*/ void <.cctor>b__4_0(System.Collections.Generic.Dictionary<TKey, TValue> l);
            }
        }

        struct Observable<T>
        {
            /*0x0*/ System.Action<T> onValueChanged;
            /*0x0*/ T m_Value;

            /*0x1ffc854*/ Observable(T newValue);
            /*0x1f30ebc*/ void add_onValueChanged(System.Action<T> value);
            /*0x1f30ebc*/ void remove_onValueChanged(System.Action<T> value);
            /*0x1ffc854*/ T get_value();
            /*0x1ffc854*/ void set_value(T value);
        }

        class ListChangedEventArgs<T> : System.EventArgs
        {
            /*0x0*/ int index;
            /*0x0*/ T item;

            /*0x1ffc854*/ ListChangedEventArgs(int index, T item);
        }

        class ListChangedEventHandler<T> : System.MulticastDelegate
        {
            ListChangedEventHandler(object object, nint method);
            /*0x1f30ff0*/ void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e);
            /*0x1f3040c*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, object object);
            /*0x1f30ebc*/ void EndInvoke(System.IAsyncResult result);
        }

        class ObservableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<T> m_List;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;

            /*0x1f309e4*/ ObservableList();
            /*0x1f30b78*/ ObservableList(int capacity);
            /*0x1f30ebc*/ ObservableList(System.Collections.Generic.IEnumerable<T> collection);
            /*0x1f30ebc*/ void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x1f30ebc*/ void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x1f30ebc*/ void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x1f30ebc*/ void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x1ffc854*/ T get_Item(int index);
            /*0x1ffc854*/ void set_Item(int index, T value);
            /*0x1f2ffc8*/ int get_Count();
            /*0x1f2fe14*/ bool get_IsReadOnly();
            /*0x1ffc854*/ void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, int index, T item);
            /*0x1ffc854*/ bool Contains(T item);
            /*0x1ffc854*/ int IndexOf(T item);
            /*0x1ffc854*/ void Add(T item);
            /*0x1f30ebc*/ void Add(T[] items);
            /*0x1ffc854*/ void Insert(int index, T item);
            /*0x1ffc854*/ bool Remove(T item);
            /*0x1f3008c*/ int Remove(T[] items);
            /*0x1f30b78*/ void RemoveAt(int index);
            /*0x1f309e4*/ void Clear();
            /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
            /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class ReloadAttribute : System.Attribute
        {
            /*0x3ae3520*/ ReloadAttribute(string[] paths, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x3ae3528*/ ReloadAttribute(string path, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x3ae35a8*/ ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package);

            enum Package
            {
                Builtin = 0,
                Root = 1,
                BuiltinExtra = 2,
            }
        }

        class ReloadGroupAttribute : System.Attribute
        {
            /*0x3ae35b0*/ ReloadGroupAttribute();
        }

        class RemoveRangeExtensions
        {
            static bool TryRemoveElementsInRange<TValue>(System.Collections.Generic.IList<TValue> list, int index, int count, ref System.Exception error);
        }

        class SerializableEnum
        {
            /*0x10*/ string m_EnumValueAsString;
            /*0x18*/ string m_EnumTypeAsString;

            /*0x3ae3710*/ SerializableEnum(System.Type enumType);
            /*0x3ae35b8*/ System.Enum get_value();
            /*0x3ae36d8*/ void set_value(System.Enum value);
        }

        class SerializedDictionaryDebugView<K, V>
        {
            /*0x0*/ System.Collections.Generic.IDictionary<K, V> dict;

            /*0x1f30ebc*/ SerializedDictionaryDebugView(System.Collections.Generic.IDictionary<K, V> dictionary);
            /*0x1f30214*/ System.Collections.Generic.KeyValuePair<K, V> get_Items();
        }

        class SerializedDictionary<K, V> : UnityEngine.Rendering.SerializedDictionary<K, V, K, V>
        {
            /*0x1f309e4*/ SerializedDictionary();
            /*0x1ffc854*/ K SerializeKey(K key);
            /*0x1ffc854*/ V SerializeValue(V val);
            /*0x1ffc854*/ K DeserializeKey(K key);
            /*0x1ffc854*/ V DeserializeValue(V val);
        }

        class SerializedDictionary<K, V, SK, SV> : System.Collections.Generic.Dictionary<K, V>, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x0*/ System.Collections.Generic.List<SK> m_Keys;
            /*0x0*/ System.Collections.Generic.List<SV> m_Values;

            /*0x1f309e4*/ SerializedDictionary();
            /*0x1ffc854*/ SK SerializeKey(K key);
            /*0x1ffc854*/ SV SerializeValue(V value);
            /*0x1ffc854*/ K DeserializeKey(SK serializedKey);
            /*0x1ffc854*/ V DeserializeValue(SV serializedValue);
            /*0x1f309e4*/ void OnBeforeSerialize();
            /*0x1f309e4*/ void OnAfterDeserialize();
        }

        class SwapCollectionExtensions
        {
            static bool TrySwap<TValue>(System.Collections.Generic.IList<TValue> list, int from, int to, ref System.Exception error);
        }

        class DebugDisplaySettings<T> : UnityEngine.Rendering.IDebugDisplaySettings
        {
            static /*0x0*/ System.Lazy<T> s_Instance;
            /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.IDebugDisplaySettingsData> m_Settings;

            static /*0x1f33998*/ DebugDisplaySettings();
            static /*0x1ffc854*/ T get_Instance();
            /*0x1f309e4*/ DebugDisplaySettings();
            /*0x1f2fe14*/ bool get_AreAnySettingsActive();
            /*0x1f2fe14*/ bool get_IsPostProcessingAllowed();
            /*0x1f2fe14*/ bool get_IsLightingActive();
            /*0x1ffc854*/ TData Add<TData>(TData newData);
            /*0x1f302cc*/ UnityEngine.Rendering.IDebugDisplaySettingsData UnityEngine.Rendering.IDebugDisplaySettings.Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
            /*0x1f30ebc*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x1f309e4*/ void Reset();
            /*0x1f2fec8*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);

            class IDebugDisplaySettingsDataComparer<T> : System.Collections.Generic.IEqualityComparer<UnityEngine.Rendering.IDebugDisplaySettingsData>
            {
                /*0x1f309e4*/ IDebugDisplaySettingsDataComparer();
                /*0x1f2ff00*/ bool Equals(UnityEngine.Rendering.IDebugDisplaySettingsData x, UnityEngine.Rendering.IDebugDisplaySettingsData y);
                /*0x1f3008c*/ int GetHashCode(UnityEngine.Rendering.IDebugDisplaySettingsData obj);
            }

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.DebugDisplaySettings.<>c<T> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1ffc854*/ T <.cctor>b__17_0();
            }
        }

        class DebugDisplaySettingsHDROutput
        {
            static /*0x3ae37a0*/ UnityEngine.Rendering.DebugUI.Table CreateHDROuputDisplayTable();
            /*0x3ae4258*/ DebugDisplaySettingsHDROutput();

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

                static /*0x3ae4260*/ Strings();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.HDROutputSettings d;

                /*0x3ae4250*/ <>c__DisplayClass1_0();
                /*0x3ae44f0*/ object <CreateHDROuputDisplayTable>b__0();
                /*0x3ae452c*/ object <CreateHDROuputDisplayTable>b__1();
                /*0x3ae4568*/ object <CreateHDROuputDisplayTable>b__2();
                /*0x3ae4618*/ object <CreateHDROuputDisplayTable>b__3();
                /*0x3ae46c8*/ object <CreateHDROuputDisplayTable>b__4();
                /*0x3ae476c*/ object <CreateHDROuputDisplayTable>b__5();
                /*0x3ae480c*/ object <CreateHDROuputDisplayTable>b__6();
                /*0x3ae48b0*/ object <CreateHDROuputDisplayTable>b__7();
                /*0x3ae4954*/ object <CreateHDROuputDisplayTable>b__8();
                /*0x3ae49f8*/ object <CreateHDROuputDisplayTable>b__9();
            }
        }

        class DebugDisplaySettingsPanel : UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable, UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> m_Widgets;
            /*0x18*/ UnityEngine.Rendering.DisplayInfoAttribute m_DisplayInfo;

            /*0x3ae4c7c*/ DebugDisplaySettingsPanel();
            /*0x3ae4a9c*/ string get_PanelName();
            /*0x3ae4ac8*/ int get_Order();
            /*0x3ae4ae0*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x3ae4b30*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
            /*0x3ae4b38*/ void AddWidget(UnityEngine.Rendering.DebugUI.Widget widget);
            /*0x3ae4bdc*/ void Clear();
            /*0x3ae4c78*/ void Dispose();
        }

        class DebugDisplaySettingsPanel<T> : UnityEngine.Rendering.DebugDisplaySettingsPanel
        {
            /*0x0*/ T m_Data;

            /*0x1ffc854*/ DebugDisplaySettingsPanel(T data);
            /*0x1ffc854*/ T get_data();
            /*0x1ffc854*/ void set_data(T value);
        }

        class DebugDisplaySettingsStats<TProfileId> : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <debugDisplayStats>k__BackingField;

            /*0x1f30ebc*/ DebugDisplaySettingsStats(UnityEngine.Rendering.DebugDisplayStats<TProfileId> debugDisplayStats);
            /*0x1f30214*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> get_debugDisplayStats();
            /*0x1f2fe14*/ bool get_AreAnySettingsActive();
            /*0x1f30214*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class StatsPanel<TProfileId> : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x0*/ UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> m_Data;

                /*0x1f30ebc*/ StatsPanel(UnityEngine.Rendering.DebugDisplaySettingsStats<TProfileId> displaySettingsStats);
                /*0x1f2ffc8*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x1f309e4*/ void Dispose();
            }
        }

        class DebugDisplaySettingsUI : UnityEngine.Rendering.IDebugData
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;
            /*0x18*/ UnityEngine.Rendering.IDebugDisplaySettings m_Settings;

            /*0x3ae56a0*/ DebugDisplaySettingsUI();
            /*0x3ae4ddc*/ void Reset();
            /*0x3ae5398*/ void RegisterDebug(UnityEngine.Rendering.IDebugDisplaySettings settings);
            /*0x3ae4ed4*/ void UnregisterDebug();
            /*0x3ae5624*/ System.Action GetReset();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager debugManager;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> panels;

                /*0x3ae561c*/ <>c__DisplayClass3_0();
                /*0x3ae56a8*/ void <RegisterDebug>b__0(UnityEngine.Rendering.IDebugDisplaySettingsData data);
            }
        }

        class DebugDisplaySettingsVolume : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            static string k_PanelTitle = "Volume";
            /*0x10*/ UnityEngine.Rendering.IVolumeDebugSettings <volumeDebugSettings>k__BackingField;
            /*0x18*/ int volumeComponentEnumIndex;
            /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.VolumeComponent> debugState;

            /*0x3ae5974*/ DebugDisplaySettingsVolume(UnityEngine.Rendering.IVolumeDebugSettings volumeDebugSettings);
            /*0x3ae596c*/ UnityEngine.Rendering.IVolumeDebugSettings get_volumeDebugSettings();
            /*0x3ae5a10*/ bool get_AreAnySettingsActive();
            /*0x3ae5a18*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class Styles
            {
                static /*0x0*/ UnityEngine.GUIContent none;
                static /*0x8*/ UnityEngine.GUIContent editorCamera;

                static /*0x3ae5a74*/ Styles();
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

                static /*0x3ae5b50*/ Strings();
            }

            class WidgetFactory
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Value s_EmptyDebugUIValue;

                static /*0x3ae8600*/ WidgetFactory();
                static /*0x3ae5e58*/ UnityEngine.Rendering.DebugUI.EnumField CreateComponentSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> refresh);
                static /*0x3ae6488*/ UnityEngine.Rendering.DebugUI.ObjectPopupField CreateCameraSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>, UnityEngine.Object> refresh);
                static /*0x3ae66a8*/ UnityEngine.Rendering.DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, UnityEngine.Rendering.VolumeParameter param, System.Func<bool> isHiddenCallback);
                static /*0x3ae66fc*/ UnityEngine.Rendering.VolumeComponent GetSelectedVolumeComponent(UnityEngine.Rendering.VolumeProfile profile, System.Type selectedType);
                static /*0x3ae695c*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x3ae7400*/ UnityEngine.Rendering.DebugUI.Table CreateVolumeTable(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x3ae823c*/ void SetTableColumnVisibility(UnityEngine.Rendering.DebugDisplaySettingsVolume data, UnityEngine.Rendering.DebugUI.Table table);
                static /*0x3ae7968*/ void GenerateTableColumns(UnityEngine.Rendering.DebugUI.Table table, UnityEngine.Rendering.DebugDisplaySettingsVolume data, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);
                static /*0x3ae76b8*/ void GenerateTableRows(UnityEngine.Rendering.DebugUI.Table table, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);

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

                    static /*0x3ae8710*/ <>c();
                    /*0x3ae8778*/ <>c();
                    /*0x3ae8780*/ object <GenerateTableColumns>b__9_2();
                    /*0x3ae8798*/ object <.cctor>b__11_0();
                }

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x3ae6480*/ <>c__DisplayClass0_0();
                    /*0x3ae87b0*/ int <CreateComponentSelector>b__0();
                    /*0x3ae88a0*/ void <CreateComponentSelector>b__1(int value);
                    /*0x3ae89a4*/ int <CreateComponentSelector>b__2();
                    /*0x3ae8a28*/ void <CreateComponentSelector>b__3(int value);
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x3ae66a0*/ <>c__DisplayClass1_0();
                    /*0x3ae8ab8*/ UnityEngine.Object <CreateCameraSelector>b__0();
                    /*0x3ae8bac*/ void <CreateCameraSelector>b__1(UnityEngine.Object value);
                    /*0x3ae8dd0*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <CreateCameraSelector>b__2();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;
                    /*0x18*/ float timer;
                    /*0x1c*/ float refreshRate;
                    /*0x20*/ UnityEngine.Rendering.DebugUI.Table table;
                    /*0x28*/ UnityEngine.Rendering.Volume[] volumes;

                    /*0x3ae76b0*/ <>c__DisplayClass7_0();
                    /*0x3ae8ec4*/ bool <CreateVolumeTable>b__1();
                    /*0x3ae8f78*/ bool <CreateVolumeTable>b__0();
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;

                    /*0x3ae9c08*/ <>c__DisplayClass9_0();
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain;
                    /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.<> CS$<>8__locals1;

                    /*0x3ae9c10*/ <>c__DisplayClass9_1();
                    /*0x3ae9c18*/ object <GenerateTableColumns>b__0();
                    /*0x3ae9da4*/ UnityEngine.Object <GenerateTableColumns>b__1();
                    /*0x3ae9dac*/ UnityEngine.Object <GenerateTableColumns>b__3();
                }
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.DebugDisplaySettingsVolume>
            {
                /*0x28*/ UnityEngine.Rendering.DebugUI.Table m_VolumeTable;

                /*0x3ae9db4*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                /*0x3ae9f38*/ void Refresh();
                /*0x3aea444*/ void <.ctor>b__0_0(UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object> _, UnityEngine.Object __);
                /*0x3aea448*/ void <.ctor>b__0_1(UnityEngine.Rendering.DebugUI.Field<int> _, int __);
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

            static /*0x1f33998*/ DebugDisplayStats();
            /*0x1f309e4*/ DebugDisplayStats();
            /*0x1f309e4*/ void EnableProfilingRecorders();
            /*0x1f309e4*/ void DisableProfilingRecorders();
            /*0x1f30ebc*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x1f309e4*/ void Update();
            /*0x1f30214*/ System.Collections.Generic.List<TProfileId> GetProfilerIdsToDisplay();
            /*0x1f30ebc*/ void UpdateDetailedStats(System.Collections.Generic.List<TProfileId> samplers);
            /*0x1f30394*/ UnityEngine.Rendering.DebugUI.Widget BuildDetailedStatsList(string title, System.Collections.Generic.List<TProfileId> samplers);
            /*0x1f30ac0*/ void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, System.Collections.Generic.List<TProfileId> samplers);
            /*0x1ffc854*/ float GetSamplerTiming(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);
            /*0x1f302cc*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> BuildProfilingSamplerWidgetList(System.Collections.Generic.IEnumerable<TProfileId> samplers);
            /*0x1ffc854*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0(TProfileId samplerId, UnityEngine.Rendering.ProfilingSampler sampler, UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> type);

            class AccumulatedTiming<TProfileId>
            {
                /*0x0*/ float accumulatedValue;
                /*0x0*/ float lastAverage;

                /*0x1f309e4*/ AccumulatedTiming();
                /*0x1f30b78*/ void UpdateLastAverage(int frameCount);
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

                /*0x1f309e4*/ <>c__DisplayClass19_0();
                /*0x1f30214*/ object <BuildProfilingSamplerWidgetList>b__1();
            }

            class <>c__DisplayClass19_<TProfileId>
            {
                /*0x0*/ TProfileId samplerId;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats<TProfileId> <>4__this;

                /*0x1f309e4*/ <>c__DisplayClass19_();
                /*0x1f2fe14*/ bool <BuildProfilingSamplerWidgetList>b__2();
            }

            class <>c__DisplayClass19_2<TProfileId>
            {
                /*0x0*/ UnityEngine.Rendering.ProfilingSampler sampler;
                /*0x0*/ UnityEngine.Rendering.DebugDisplayStats.<>c__DisplayClass19_1<TProfileId> CS$<>8__locals1;

                /*0x1f309e4*/ <>c__DisplayClass19_2();
                /*0x1ffc854*/ UnityEngine.Rendering.DebugUI.Value <BuildProfilingSamplerWidgetList>b__3(UnityEngine.Rendering.DebugDisplayStats.DebugProfilingType<TProfileId> e);
            }

            class <>c__DisplayClass6_0<TProfileId>
            {
                /*0x0*/ System.Type type;
                /*0x0*/ System.Func<System.Reflection.MemberInfo, bool> <>9__0;

                /*0x1f309e4*/ <>c__DisplayClass6_0();
                /*0x1f2fec8*/ bool <GetProfilerIdsToDisplay>b__0(System.Reflection.MemberInfo m);
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

            /*0x3aea46c*/ DebugFrameTiming();
            /*0x3aea44c*/ int get_bottleneckHistorySize();
            /*0x3aea454*/ void set_bottleneckHistorySize(int value);
            /*0x3aea45c*/ int get_sampleHistorySize();
            /*0x3aea464*/ void set_sampleHistorySize(int value);
            /*0x3aea6d4*/ void UpdateFrameTiming();
            /*0x3aeae60*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x3aec308*/ void Reset();
            /*0x3aec468*/ object <RegisterDebugUI>b__17_0();
            /*0x3aec49c*/ object <RegisterDebugUI>b__17_1();
            /*0x3aec4d0*/ object <RegisterDebugUI>b__17_2();
            /*0x3aec504*/ object <RegisterDebugUI>b__17_3();
            /*0x3aec538*/ object <RegisterDebugUI>b__17_4();
            /*0x3aec56c*/ object <RegisterDebugUI>b__17_5();
            /*0x3aec5a0*/ object <RegisterDebugUI>b__17_6();
            /*0x3aec5d4*/ object <RegisterDebugUI>b__17_7();
            /*0x3aec608*/ object <RegisterDebugUI>b__17_8();
            /*0x3aec63c*/ object <RegisterDebugUI>b__17_9();
            /*0x3aec670*/ object <RegisterDebugUI>b__17_10();
            /*0x3aec6a4*/ object <RegisterDebugUI>b__17_11();
            /*0x3aec6d8*/ object <RegisterDebugUI>b__17_12();
            /*0x3aec70c*/ object <RegisterDebugUI>b__17_13();
            /*0x3aec740*/ object <RegisterDebugUI>b__17_14();
            /*0x3aec774*/ object <RegisterDebugUI>b__17_15();
            /*0x3aec7a8*/ object <RegisterDebugUI>b__17_16();
            /*0x3aec7dc*/ object <RegisterDebugUI>b__17_17();
            /*0x3aec810*/ object <RegisterDebugUI>b__17_18();
            /*0x3aec844*/ object <RegisterDebugUI>b__17_19();
            /*0x3aec878*/ object <RegisterDebugUI>b__17_20();
            /*0x3aec8ac*/ object <RegisterDebugUI>b__17_21();
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
            /*0x20*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> m_ReadOnlyPanels;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Panel> m_Panels;
            /*0x30*/ System.Action<bool> onDisplayRuntimeUIChanged;
            /*0x38*/ System.Action onSetDirty;
            /*0x40*/ System.Action resetData;
            /*0x48*/ bool refreshEditorRequested;
            /*0x4c*/ System.Nullable<int> m_RequestedPanelIndex;
            /*0x58*/ UnityEngine.GameObject m_Root;
            /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas m_RootUICanvas;
            /*0x68*/ UnityEngine.GameObject m_PersistentRoot;
            /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas;
            /*0x78*/ UnityEngine.Rendering.DebugManager.UIState editorUIState;
            /*0x80*/ bool m_EnableRuntimeUI;
            /*0x88*/ UnityEngine.Rendering.DebugManager.UIState runtimeUIState;

            static /*0x3af0ce0*/ DebugManager();
            static /*0x3aea1ec*/ UnityEngine.Rendering.DebugManager get_instance();
            static /*0x3af05a4*/ void add_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            static /*0x3af0698*/ void remove_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            /*0x3aee1e0*/ DebugManager();
            /*0x3aec8e0*/ void RegisterActions();
            /*0x3aed0e8*/ void EnableInputActions();
            /*0x3aecffc*/ void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc);
            /*0x3aed144*/ void SampleAction(int actionIndex);
            /*0x3aed6f4*/ void UpdateAction(int actionIndex);
            /*0x3aed978*/ void UpdateActions();
            /*0x3aed9d0*/ float GetAction(UnityEngine.Rendering.DebugAction action);
            /*0x3aeda08*/ bool GetActionToggleDebugMenuWithTouch();
            /*0x3aedba0*/ bool GetActionReleaseScrollTarget();
            /*0x3aedc2c*/ void RegisterInputs();
            /*0x3aedc30*/ void UpdateReadOnlyCollection();
            /*0x3aedcb4*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels();
            /*0x3aedcd8*/ void add_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x3aedd88*/ void remove_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x3aede38*/ void add_onSetDirty(System.Action value);
            /*0x3aeded4*/ void remove_onSetDirty(System.Action value);
            /*0x3aedf70*/ void add_resetData(System.Action value);
            /*0x3aee00c*/ void remove_resetData(System.Action value);
            /*0x3aee0a8*/ bool get_isAnyDebugUIActive();
            /*0x3aee440*/ void RefreshEditor();
            /*0x3aee44c*/ void Reset();
            /*0x3aea418*/ void ReDrawOnScreenDebug();
            /*0x3aee478*/ void RegisterData(UnityEngine.Rendering.IDebugData data);
            /*0x3aee524*/ void UnregisterData(UnityEngine.Rendering.IDebugData data);
            /*0x3aee5d0*/ int GetState();
            /*0x3aee794*/ void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root);
            /*0x3aee7e0*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
            /*0x3aee7fc*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
            /*0x3aee894*/ void EnsurePersistentCanvas();
            /*0x3aeeab8*/ void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget, System.Nullable<int> forceTupleIndex);
            /*0x3aeefec*/ void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x3aef00c*/ int PanelIndex(string displayName);
            /*0x3aef0e0*/ string PanelDiplayName(int panelIndex);
            /*0x3aef18c*/ void RequestEditorWindowPanelIndex(int index);
            /*0x3aef1fc*/ System.Nullable<int> GetRequestedEditorWindowPanelIndex();
            /*0x3aea270*/ UnityEngine.Rendering.DebugUI.Panel GetPanel(string displayName, bool createIfNull, int groupIndex, bool overrideIfExist);
            /*0x3aef5d0*/ int FindPanelIndex(string displayName);
            /*0x3aef6bc*/ void RemovePanel(string displayName);
            /*0x3aef2bc*/ void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x3aef8f0*/ UnityEngine.Rendering.DebugUI.Widget[] GetItems(UnityEngine.Rendering.DebugUI.Flags flags);
            /*0x3aefc04*/ UnityEngine.Rendering.DebugUI.Widget[] GetItemsFromContainer(UnityEngine.Rendering.DebugUI.Flags flags, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x3af00ac*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath);
            /*0x3af0278*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x3af078c*/ bool get_displayEditorUI();
            /*0x3af07a4*/ void set_displayEditorUI(bool value);
            /*0x3af0860*/ bool get_enableRuntimeUI();
            /*0x3af0868*/ void set_enableRuntimeUI(bool value);
            /*0x3aee0d0*/ bool get_displayRuntimeUI();
            /*0x3af0898*/ void set_displayRuntimeUI(bool value);
            /*0x3aee158*/ bool get_displayPersistentRuntimeUI();
            /*0x3af0c30*/ void set_displayPersistentRuntimeUI(bool value);
            /*0x3af0cc8*/ void ToggleEditorUI(bool open);

            enum UIMode
            {
                EditorMode = 0,
                RuntimeMode = 1,
            }

            class UIState
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager.UIMode mode;
                /*0x14*/ bool m_Open;

                /*0x3aee438*/ UIState();
                /*0x3af0df8*/ bool get_open();
                /*0x3af07bc*/ void set_open(bool value);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.DebugManager.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__48_0;
                static /*0x10*/ System.Action <>9__48_1;
                static /*0x18*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, int> <>9__59_0;

                static /*0x3af0e00*/ <>c();
                /*0x3af0e68*/ <>c();
                /*0x3af0e70*/ void <.ctor>b__48_0(bool <p0>);
                /*0x3af0e74*/ void <.ctor>b__48_1();
                /*0x3af0e78*/ int <TogglePersistent>b__59_0(UnityEngine.Rendering.DebugUI.Widget w);
                /*0x3af0ef4*/ UnityEngine.Rendering.DebugManager <.cctor>b__94_0();
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ string displayName;

                /*0x3aef6b4*/ <>c__DisplayClass66_0();
                /*0x3af0f44*/ bool <FindPanelIndex>b__0(UnityEngine.Rendering.DebugUI.Panel p);
            }
        }

        class DebugActionDesc
        {
            /*0x10*/ string axisTrigger;
            /*0x18*/ System.Collections.Generic.List<System.String[]> buttonTriggerList;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.KeyCode[]> keyTriggerList;
            /*0x28*/ UnityEngine.Rendering.DebugActionRepeatMode repeatMode;
            /*0x2c*/ float repeatDelay;

            /*0x3aecefc*/ DebugActionDesc();
        }

        class DebugActionState
        {
            /*0x10*/ UnityEngine.Rendering.DebugActionState.DebugActionKeyType m_Type;
            /*0x18*/ string[] m_PressedButtons;
            /*0x20*/ string m_PressedAxis;
            /*0x28*/ UnityEngine.KeyCode[] m_PressedKeys;
            /*0x30*/ bool[] m_TriggerPressedUp;
            /*0x38*/ float m_Timer;
            /*0x3c*/ bool <runningAction>k__BackingField;
            /*0x40*/ float <actionState>k__BackingField;

            /*0x3aed0ec*/ DebugActionState();
            /*0x3af0f64*/ bool get_runningAction();
            /*0x3af0f6c*/ void set_runningAction(bool value);
            /*0x3af0f74*/ float get_actionState();
            /*0x3af0f7c*/ void set_actionState(float value);
            /*0x3af0f84*/ void Trigger(int triggerCount, float state);
            /*0x3aed598*/ void TriggerWithButton(string[] buttons, float state);
            /*0x3aed628*/ void TriggerWithAxis(string axis, float state);
            /*0x3aed660*/ void TriggerWithKey(UnityEngine.KeyCode[] keys, float state);
            /*0x3af1044*/ void Reset();
            /*0x3aed758*/ void Update(UnityEngine.Rendering.DebugActionDesc desc);

            enum DebugActionKeyType
            {
                Button = 0,
                Axis = 1,
                Key = 2,
            }
        }

        interface IDebugData
        {
            /*0x1f30214*/ System.Action GetReset();
        }

        class DebugOverlay
        {
            /*0x10*/ int <x>k__BackingField;
            /*0x14*/ int <y>k__BackingField;
            /*0x18*/ int <overlaySize>k__BackingField;
            /*0x1c*/ int m_InitialPositionX;
            /*0x20*/ int m_ScreenWidth;

            /*0x3af1138*/ DebugOverlay();
            /*0x3af1058*/ int get_x();
            /*0x3af1060*/ void set_x(int value);
            /*0x3af1068*/ int get_y();
            /*0x3af1070*/ void set_y(int value);
            /*0x3af1078*/ int get_overlaySize();
            /*0x3af1080*/ void set_overlaySize(int value);
            /*0x3af1088*/ void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth);
            /*0x3af1098*/ UnityEngine.Rect Next(float aspect);
            /*0x3af1108*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd);
        }

        class DebugShapes
        {
            static /*0x0*/ UnityEngine.Rendering.DebugShapes s_Instance;
            /*0x10*/ UnityEngine.Mesh m_sphereMesh;
            /*0x18*/ UnityEngine.Mesh m_boxMesh;
            /*0x20*/ UnityEngine.Mesh m_coneMesh;
            /*0x28*/ UnityEngine.Mesh m_pyramidMesh;

            static /*0x3af1140*/ UnityEngine.Rendering.DebugShapes get_instance();
            /*0x3af11c8*/ DebugShapes();
            /*0x3af11d0*/ void BuildSphere(ref UnityEngine.Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv);
            /*0x3af18c8*/ void BuildBox(ref UnityEngine.Mesh outputMesh, float length, float width, float height);
            /*0x3af2010*/ void BuildCone(ref UnityEngine.Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides);
            /*0x3af2928*/ void BuildPyramid(ref UnityEngine.Mesh outputMesh, float width, float height, float depth);
            /*0x3af2c20*/ void BuildShapes();
            /*0x3af2d54*/ void RebuildResources();
            /*0x3af2e44*/ UnityEngine.Mesh RequestSphereMesh();
            /*0x3af2e5c*/ UnityEngine.Mesh BuildCustomSphereMesh(float radius, uint longSubdiv, uint latSubdiv);
            /*0x3af2ef0*/ UnityEngine.Mesh RequestBoxMesh();
            /*0x3af2f08*/ UnityEngine.Mesh RequestConeMesh();
            /*0x3af2f20*/ UnityEngine.Mesh RequestPyramidMesh();
        }

        class DebugUI
        {
            /*0x3af2f38*/ DebugUI();

            class Container : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IContainer
            {
                static string k_IDToken = "#";
                /*0x48*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;

                /*0x3af30b4*/ Container();
                /*0x3af333c*/ Container(string id);
                /*0x3af3144*/ Container(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children);
                /*0x3af2f40*/ bool get_hideDisplayName();
                /*0x3af2fb4*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x3af2fbc*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x3af2fc4*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x3af2fcc*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x3af33f8*/ void GenerateQueryPath();
                /*0x3af35bc*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x3af36f8*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x3af3760*/ int GetHashCode();
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

                /*0x3aec1e0*/ Foldout();
                /*0x3af3bb8*/ Foldout(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips);
                /*0x3af38ec*/ bool get_isReadOnly();
                /*0x3af38f4*/ string[] get_columnLabels();
                /*0x3aec264*/ void set_columnLabels(string[] value);
                /*0x3af38fc*/ string[] get_columnTooltips();
                /*0x3af3904*/ void set_columnTooltips(string[] value);
                /*0x3af3928*/ System.Collections.Generic.List<UnityEngine.GUIContent> get_rowContents();
                /*0x3af3c94*/ bool GetValue();
                /*0x3af3c9c*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x3af3cc4*/ void SetValue(object value);
                /*0x3af3d18*/ object ValidateValue(object value);
                /*0x3af3d20*/ void SetValue(bool value);

                struct ContextMenuItem
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ System.Action action;
                }
            }

            class HBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x3af3d28*/ HBox();
            }

            class VBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x3af3d7c*/ VBox();
            }

            class Table : UnityEngine.Rendering.DebugUI.Container
            {
                static /*0x0*/ UnityEngine.GUIStyle columnHeaderStyle;
                /*0x50*/ bool isReadOnly;
                /*0x58*/ bool[] m_Header;

                static /*0x3af4154*/ Table();
                /*0x3af3dd0*/ Table();
                /*0x3af3e24*/ void SetColumnVisibility(int index, bool visible);
                /*0x3af40c8*/ bool GetColumnVisibility(int index);
                /*0x3af3e70*/ bool[] get_VisibleColumns();
                /*0x3af4114*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x3af4134*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);

                class Row : UnityEngine.Rendering.DebugUI.Foldout
                {
                    /*0x3af41e8*/ Row();
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

                /*0x3af33f0*/ Widget();
                /*0x3af423c*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x3af4244*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x3af424c*/ UnityEngine.Rendering.DebugUI.IContainer get_parent();
                /*0x3af4254*/ void set_parent(UnityEngine.Rendering.DebugUI.IContainer value);
                /*0x3af425c*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x3af4264*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x3af426c*/ string get_displayName();
                /*0x3af4274*/ void set_displayName(string value);
                /*0x3af427c*/ string get_tooltip();
                /*0x3af4284*/ void set_tooltip(string value);
                /*0x3af428c*/ string get_queryPath();
                /*0x3af4294*/ void set_queryPath(string value);
                /*0x3af429c*/ bool get_isEditorOnly();
                /*0x3af42a8*/ bool get_isRuntimeOnly();
                /*0x3af42b4*/ bool get_isInactiveInEditor();
                /*0x3af38b0*/ bool get_isHidden();
                /*0x3af34b8*/ void GenerateQueryPath();
                /*0x3af4324*/ int GetHashCode();
                /*0x3af43b0*/ void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value);

                struct NameAndTooltip
                {
                    /*0x10*/ string name;
                    /*0x18*/ string tooltip;
                }
            }

            interface IContainer
            {
                /*0x1f30214*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x1f30214*/ string get_displayName();
                /*0x1f30ebc*/ void set_displayName(string value);
                /*0x1f30214*/ string get_queryPath();
            }

            interface IValueField
            {
                /*0x1f30214*/ object GetValue();
                /*0x1f30ebc*/ void SetValue(object value);
                /*0x1f302cc*/ object ValidateValue(object value);
            }

            class Button : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Action <action>k__BackingField;

                /*0x3af43f0*/ Button();
                /*0x3af43e0*/ System.Action get_action();
                /*0x3af43e8*/ void set_action(System.Action value);
            }

            class Value : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Func<object> <getter>k__BackingField;
                /*0x50*/ float refreshRate;
                /*0x58*/ string formatString;

                /*0x3aec298*/ Value();
                /*0x3af43f8*/ System.Func<object> get_getter();
                /*0x3af4400*/ void set_getter(System.Func<object> value);
                /*0x3af4408*/ object GetValue();
                /*0x3af4438*/ string FormatString(object value);
            }

            class ProgressBarValue : UnityEngine.Rendering.DebugUI.Value
            {
                /*0x60*/ float min;
                /*0x64*/ float max;

                static /*0x3af457c*/ float <FormatString>g__Remap01|2_0(float v, float x0, float y0);
                /*0x3aec2fc*/ ProgressBarValue();
                /*0x3af44a4*/ string FormatString(object value);
            }

            class ValueTuple : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.Value[] values;
                /*0x50*/ int pinnedElementIndex;

                /*0x3aec288*/ ValueTuple();
                /*0x3af458c*/ int get_numElements();
                /*0x3af45a4*/ float get_refreshRate();
            }

            class Field<T> : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x0*/ System.Func<T> <getter>k__BackingField;
                /*0x0*/ System.Action<T> <setter>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.Rendering.DebugUI.Field<T>, T> onValueChanged;

                /*0x1f309e4*/ Field();
                /*0x1f30214*/ System.Func<T> get_getter();
                /*0x1f30ebc*/ void set_getter(System.Func<T> value);
                /*0x1f30214*/ System.Action<T> get_setter();
                /*0x1f30ebc*/ void set_setter(System.Action<T> value);
                /*0x1f302cc*/ object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
                /*0x1ffc854*/ T ValidateValue(T value);
                /*0x1f30214*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x1ffc854*/ T GetValue();
                /*0x1f30ebc*/ void SetValue(object value);
                /*0x1ffc854*/ void SetValue(T value);
            }

            class BoolField : UnityEngine.Rendering.DebugUI.Field<bool>
            {
                /*0x3af4614*/ BoolField();
            }

            class HistoryBoolField : UnityEngine.Rendering.DebugUI.BoolField
            {
                /*0x60*/ System.Func<bool> <historyGetter>k__BackingField;

                /*0x3af46d0*/ HistoryBoolField();
                /*0x3af465c*/ System.Func<bool> get_historyGetter();
                /*0x3af4664*/ void set_historyGetter(System.Func<bool> value);
                /*0x3af466c*/ int get_historyDepth();
                /*0x3af4684*/ bool GetHistoryValue(int historyIndex);
            }

            class IntField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ System.Func<int> min;
                /*0x68*/ System.Func<int> max;
                /*0x70*/ int incStep;
                /*0x74*/ int intStepMult;

                /*0x3af4744*/ IntField();
                /*0x3af46d4*/ int ValidateValue(int value);
            }

            class UIntField : UnityEngine.Rendering.DebugUI.Field<uint>
            {
                /*0x60*/ System.Func<uint> min;
                /*0x68*/ System.Func<uint> max;
                /*0x70*/ uint incStep;
                /*0x74*/ uint intStepMult;

                /*0x3af4808*/ UIntField();
                /*0x3af4798*/ uint ValidateValue(uint value);
            }

            class FloatField : UnityEngine.Rendering.DebugUI.Field<float>
            {
                /*0x60*/ System.Func<float> min;
                /*0x68*/ System.Func<float> max;
                /*0x70*/ float incStep;
                /*0x74*/ float incStepMult;
                /*0x78*/ int decimals;

                /*0x3af48cc*/ FloatField();
                /*0x3af485c*/ float ValidateValue(float value);
            }

            class RenderingLayerField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.RenderingLayerMask>, UnityEngine.Rendering.DebugUI.IContainer
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip s_RenderingLayerColors;
                /*0x60*/ string[] m_RenderingLayersNames;
                /*0x68*/ int m_DefinedRenderingLayersCount;
                /*0x70*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> m_RenderingLayersColors;
                /*0x78*/ System.Func<int, UnityEngine.Vector4> <getRenderingLayerColor>k__BackingField;
                /*0x80*/ System.Action<UnityEngine.Vector4, int> <setRenderingLayerColor>k__BackingField;

                static /*0x3af50d8*/ RenderingLayerField();
                /*0x3af4fbc*/ RenderingLayerField();
                /*0x3af4928*/ int get_maxRenderingLayerCount();
                /*0x3af4978*/ void Resize();
                /*0x3af4df4*/ string[] get_renderingLayersNames();
                /*0x3af4e64*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x3af4ed4*/ System.Func<int, UnityEngine.Vector4> get_getRenderingLayerColor();
                /*0x3af4edc*/ void set_getRenderingLayerColor(System.Func<int, UnityEngine.Vector4> value);
                /*0x3af4ee4*/ System.Action<UnityEngine.Vector4, int> get_setRenderingLayerColor();
                /*0x3af4eec*/ void set_setRenderingLayerColor(System.Action<UnityEngine.Vector4, int> value);
                /*0x3af4ef4*/ void GenerateQueryPath();

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ int index;
                    /*0x18*/ UnityEngine.Rendering.DebugUI.RenderingLayerField <>4__this;

                    /*0x3af4d88*/ <>c__DisplayClass5_0();
                    /*0x3af5190*/ UnityEngine.Color <Resize>b__0();
                    /*0x3af51e0*/ void <Resize>b__1(UnityEngine.Color value);
                }
            }

            class EnumField<T> : UnityEngine.Rendering.DebugUI.Field<T>
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_NicifyRegEx;
                /*0x0*/ UnityEngine.GUIContent[] enumNames;
                /*0x0*/ int[] m_EnumValues;

                static /*0x1f33998*/ EnumField();
                /*0x1f309e4*/ EnumField();
                /*0x1f30214*/ int[] get_enumValues();
                /*0x1f30ebc*/ void set_enumValues(int[] value);
                /*0x1f30ebc*/ void AutoFillFromType(System.Type enumType);

                class <>c<T>
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__6_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1f2fec8*/ bool <AutoFillFromType>b__6_0(System.Reflection.FieldInfo fieldInfo);
                }
            }

            class EnumField : UnityEngine.Rendering.DebugUI.EnumField<int>
            {
                /*0x70*/ int[] quickSeparators;
                /*0x78*/ int[] m_Indexes;
                /*0x80*/ System.Func<int> <getIndex>k__BackingField;
                /*0x88*/ System.Action<int> <setIndex>k__BackingField;

                /*0x3af5728*/ EnumField();
                /*0x3af5230*/ int[] get_indexes();
                /*0x3af52bc*/ System.Func<int> get_getIndex();
                /*0x3af52c4*/ void set_getIndex(System.Func<int> value);
                /*0x3af52cc*/ System.Action<int> get_setIndex();
                /*0x3af52d4*/ void set_setIndex(System.Action<int> value);
                /*0x3af52dc*/ int get_currentIndex();
                /*0x3af530c*/ void set_currentIndex(int value);
                /*0x3af533c*/ void set_autoEnum(System.Type value);
                /*0x3af539c*/ void InitQuickSeparators();
                /*0x3af55cc*/ void SetValue(int value);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.GUIContent, string> <>9__17_0;

                    static /*0x3af5794*/ <>c();
                    /*0x3af57fc*/ <>c();
                    /*0x3af5804*/ string <InitQuickSeparators>b__17_0(UnityEngine.GUIContent x);
                }
            }

            class ObjectPopupField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> <getObjects>k__BackingField;

                /*0x3af58a0*/ ObjectPopupField();
                /*0x3af5890*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> get_getObjects();
                /*0x3af5898*/ void set_getObjects(System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> value);
            }

            class HistoryEnumField : UnityEngine.Rendering.DebugUI.EnumField
            {
                /*0x90*/ System.Func<int> <historyIndexGetter>k__BackingField;

                /*0x3af595c*/ HistoryEnumField();
                /*0x3af58e8*/ System.Func<int> get_historyIndexGetter();
                /*0x3af58f0*/ void set_historyIndexGetter(System.Func<int> value);
                /*0x3af58f8*/ int get_historyDepth();
                /*0x3af5910*/ int GetHistoryValue(int historyIndex);
            }

            class BitField : UnityEngine.Rendering.DebugUI.EnumField<System.Enum>
            {
                /*0x70*/ System.Type m_EnumType;

                /*0x3af59d0*/ BitField();
                /*0x3af5960*/ System.Type get_enumType();
                /*0x3af5968*/ void set_enumType(System.Type value);
            }

            class ColorField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Color>
            {
                /*0x60*/ bool hdr;
                /*0x61*/ bool showAlpha;
                /*0x62*/ bool showPicker;
                /*0x64*/ float incStep;
                /*0x68*/ float incStepMult;
                /*0x6c*/ int decimals;

                /*0x3af4d90*/ ColorField();
                /*0x3af5a3c*/ UnityEngine.Color ValidateValue(UnityEngine.Color value);
            }

            class Vector2Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector2>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x3af5a94*/ Vector2Field();
            }

            class Vector3Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector3>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x3af5af0*/ Vector3Field();
            }

            class Vector4Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector4>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x3af5b4c*/ Vector4Field();
            }

            class ObjectField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Type type;

                /*0x3af5ba8*/ ObjectField();
            }

            class ObjectListField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object[]>
            {
                /*0x60*/ System.Type type;

                /*0x3af5c3c*/ ObjectListField();
            }

            class MessageBox : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.MessageBox.Style style;
                /*0x50*/ System.Func<string> messageCallback;

                /*0x3af5d04*/ MessageBox();
                /*0x3af5cd0*/ string get_message();

                enum Style
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }

            class RuntimeDebugShadersMessageBox : UnityEngine.Rendering.DebugUI.MessageBox
            {
                /*0x3af5d0c*/ RuntimeDebugShadersMessageBox();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.RuntimeDebugShadersMessageBox.<> <>9;
                    static /*0x8*/ System.Func<bool> <>9__0_0;

                    static /*0x3af5e2c*/ <>c();
                    /*0x3af5e94*/ <>c();
                    /*0x3af5e9c*/ bool <.ctor>b__0_0();
                }
            }

            class Panel : UnityEngine.Rendering.DebugUI.IContainer, System.IComparable<UnityEngine.Rendering.DebugUI.Panel>
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x18*/ string <displayName>k__BackingField;
                /*0x20*/ int <groupIndex>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;
                /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;

                /*0x3aef32c*/ Panel();
                /*0x3af5f30*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x3af5f38*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x3af5f40*/ string get_displayName();
                /*0x3af5f48*/ void set_displayName(string value);
                /*0x3af5f50*/ int get_groupIndex();
                /*0x3af5f58*/ void set_groupIndex(int value);
                /*0x3af5f60*/ string get_queryPath();
                /*0x3af5f68*/ bool get_isEditorOnly();
                /*0x3af5f74*/ bool get_isRuntimeOnly();
                /*0x3af5f80*/ bool get_isInactiveInEditor();
                /*0x3af5ff0*/ bool get_editorForceUpdate();
                /*0x3af5ffc*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x3af6004*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x3aef520*/ void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x3aef20c*/ void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x3af600c*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x3af6064*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x3af3624*/ void SetDirty();
                /*0x3af60bc*/ int GetHashCode();
                /*0x3af61a4*/ int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Panel.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> <>9__29_0;

                    static /*0x3af61d8*/ <>c();
                    /*0x3af6240*/ <>c();
                    /*0x3af6248*/ void <.ctor>b__29_0(UnityEngine.Rendering.DebugUI.Panel <p0>);
                }
            }

            class MaskField : UnityEngine.Rendering.DebugUI.EnumField<uint>
            {
                /*0x3af66a4*/ MaskField();
                /*0x3af624c*/ void Fill(string[] names);
                /*0x3af65b4*/ void SetValue(uint value);
            }
        }

        class DebugUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.Rendering.DebugUpdater s_Instance;
            /*0x20*/ UnityEngine.ScreenOrientation m_Orientation;
            /*0x24*/ bool m_RuntimeUiWasVisibleLastFrame;

            static /*0x3af6710*/ void RuntimeInit();
            static /*0x3af088c*/ void SetEnabled(bool enabled);
            static /*0x3af6714*/ void EnableRuntime();
            static /*0x3af688c*/ void DisableRuntime();
            static /*0x3af0b68*/ void HandleInternalEventSystemComponents(bool uiEnabled);
            static /*0x3af7030*/ System.Collections.IEnumerator RefreshRuntimeUINextFrame();
            /*0x3af70b0*/ DebugUpdater();
            /*0x3af69c8*/ void EnsureExactlyOneEventSystem();
            /*0x3af6d18*/ System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action);
            /*0x3af6dac*/ void CheckInputModuleExists();
            /*0x3af6c94*/ void CreateDebugEventSystem();
            /*0x3af6b9c*/ void DestroyDebugEventSystem();
            /*0x3af6ed8*/ void Update();

            class <DoAfterInputModuleUpdated>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Action action;

                /*0x3af6d84*/ <DoAfterInputModuleUpdated>d__9(int <>1__state);
                /*0x3af70b8*/ void System.IDisposable.Dispose();
                /*0x3af70bc*/ bool MoveNext();
                /*0x3af71b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x3af71c0*/ void System.Collections.IEnumerator.Reset();
                /*0x3af71f8*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RefreshRuntimeUINextFrame>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x3af7088*/ <RefreshRuntimeUINextFrame>d__14(int <>1__state);
                /*0x3af7200*/ void System.IDisposable.Dispose();
                /*0x3af7204*/ bool MoveNext();
                /*0x3af72a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x3af72b0*/ void System.Collections.IEnumerator.Reset();
                /*0x3af72e8*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x3af72f0*/ UnityEngine.Rendering.PerformanceBottleneck DetermineBottleneck(UnityEngine.Rendering.FrameTimeSample s);
            /*0x3aea618*/ BottleneckHistory(int initialCapacity);
            /*0x3aeac28*/ void DiscardOldSamples(int historySize);
            /*0x3aeacc8*/ void AddBottleneckFromAveragedSample(UnityEngine.Rendering.FrameTimeSample frameHistorySampleAverage);
            /*0x3aead4c*/ void ComputeHistogram();
            /*0x3aec330*/ void Clear();
        }

        struct FrameTimeSample
        {
            /*0x10*/ float FramesPerSecond;
            /*0x14*/ float FullFrameTime;
            /*0x18*/ float MainThreadCPUFrameTime;
            /*0x1c*/ float MainThreadCPUPresentWaitTime;
            /*0x20*/ float RenderThreadCPUFrameTime;
            /*0x24*/ float GPUFrameTime;

            /*0x3af7394*/ FrameTimeSample(float initValue);
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

            static /*0x3af74f4*/ FrameTimeSampleHistory();
            static /*0x3af73a4*/ void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref UnityEngine.Rendering.FrameTimeSample aggregate, UnityEngine.Rendering.FrameTimeSample sample, System.Func<float, float, float> func);
            /*0x3aea55c*/ FrameTimeSampleHistory(int initialCapacity);
            /*0x3aea93c*/ void Add(UnityEngine.Rendering.FrameTimeSample sample);
            /*0x3aea9b0*/ void ComputeAggregateValues();
            /*0x3aea89c*/ void DiscardOldSamples(int sampleHistorySize);
            /*0x3aec3cc*/ void Clear();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.FrameTimeSampleHistory.<> <>9;

                static /*0x3af776c*/ <>c();
                /*0x3af77d4*/ <>c();
                /*0x3af77dc*/ float <.cctor>b__15_0(float value, float other);
                /*0x3af77e4*/ float <.cctor>b__15_1(float value, float other);
                /*0x3af77f8*/ float <.cctor>b__15_2(float value, float other);
                /*0x3af7804*/ float <.cctor>b__15_3(float value, float other);
                /*0x3af7818*/ float <.cctor>b__15_4(float value, float other);
                /*0x3af7828*/ float <.cctor>b__15_5(float value, float other);
            }
        }

        interface IDebugDisplaySettings
        {
            /*0x1f309e4*/ void Reset();
            /*0x1f30ebc*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x3af783c*/ UnityEngine.Rendering.IDebugDisplaySettingsData Add(UnityEngine.Rendering.IDebugDisplaySettingsData newData);
        }

        interface IDebugDisplaySettingsData : UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x1f30214*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();
        }

        interface IDebugDisplaySettingsPanel
        {
            /*0x1f30214*/ string get_PanelName();
            /*0x1f30214*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x1f2ffc8*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
        }

        interface IDebugDisplaySettingsPanelDisposable : UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
        }

        interface IDebugDisplaySettingsQuery
        {
            /*0x1f2fe14*/ bool get_AreAnySettingsActive();
            /*0x3af7844*/ bool get_IsPostProcessingAllowed();
            /*0x3af784c*/ bool get_IsLightingActive();
            /*0x3af7854*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
        }

        interface IVolumeDebugSettings
        {
            /*0x1f2ffc8*/ int get_selectedComponent();
            /*0x1f30b78*/ void set_selectedComponent(int value);
            /*0x1f30214*/ UnityEngine.Camera get_selectedCamera();
            /*0x1f30214*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x1f2ffc8*/ int get_selectedCameraIndex();
            /*0x1f30b78*/ void set_selectedCameraIndex(int value);
            /*0x1f30214*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x1f30214*/ System.Type get_selectedComponentType();
            /*0x1f30ebc*/ void set_selectedComponentType(System.Type value);
            /*0x1f30214*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x1f2fec8*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);
            /*0x1f2fec8*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
        }

        interface IVolumeDebugSettings2 : UnityEngine.Rendering.IVolumeDebugSettings
        {
            /*0x1f30214*/ System.Type get_targetRenderPipeline();
            /*0x1f30214*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
        }

        class MousePositionDebug
        {
            static /*0x0*/ UnityEngine.Rendering.MousePositionDebug s_Instance;

            static /*0x3af785c*/ UnityEngine.Rendering.MousePositionDebug get_instance();
            /*0x3af78e4*/ MousePositionDebug();
            /*0x3af78ec*/ void Build();
            /*0x3af78f0*/ void Cleanup();
            /*0x3af78f4*/ UnityEngine.Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
            /*0x3af78fc*/ UnityEngine.Vector2 GetInputMousePosition();
            /*0x3af7904*/ UnityEngine.Vector2 GetMouseClickPosition(float ScreenHeight);
        }

        class TProfilingSampler<TEnum> : UnityEngine.Rendering.ProfilingSampler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<TEnum, UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;

            static /*0x1f33998*/ TProfilingSampler();
            /*0x1f30ebc*/ TProfilingSampler(string name);
        }

        class ProfilingSampler
        {
            /*0x10*/ UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;
            /*0x18*/ UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;
            /*0x20*/ string <name>k__BackingField;
            /*0x28*/ UnityEngine.Profiling.Recorder m_Recorder;
            /*0x30*/ UnityEngine.Profiling.Recorder m_InlineRecorder;

            static /*0x1ffc854*/ UnityEngine.Rendering.ProfilingSampler Get<TEnum>(TEnum marker);
            /*0x3af7944*/ ProfilingSampler(string name);
            /*0x3af7d90*/ ProfilingSampler();
            /*0x3af7a90*/ void Begin(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3af7af4*/ void End(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3af7b58*/ bool IsValid();
            /*0x3af7b78*/ UnityEngine.Profiling.CustomSampler get_sampler();
            /*0x3af7b80*/ void set_sampler(UnityEngine.Profiling.CustomSampler value);
            /*0x3af7b88*/ UnityEngine.Profiling.CustomSampler get_inlineSampler();
            /*0x3af7b90*/ void set_inlineSampler(UnityEngine.Profiling.CustomSampler value);
            /*0x3af7b98*/ string get_name();
            /*0x3af7ba0*/ void set_name(string value);
            /*0x3af7ba8*/ void set_enableRecording(bool value);
            /*0x3af7bec*/ float get_gpuElapsedTime();
            /*0x3af7c38*/ int get_gpuSampleCount();
            /*0x3af7c78*/ float get_cpuElapsedTime();
            /*0x3af7cc4*/ int get_cpuSampleCount();
            /*0x3af7d04*/ float get_inlineCpuElapsedTime();
            /*0x3af7d50*/ int get_inlineCpuSampleCount();
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x3af7d98*/ ProfilingScope(UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x3af7d9c*/ ProfilingScope(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x3af7da0*/ ProfilingScope(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x3af7da4*/ void Dispose();
        }

        struct ProfilingSample : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
            /*0x18*/ string m_Name;
            /*0x20*/ bool m_Disposed;
            /*0x28*/ UnityEngine.Profiling.CustomSampler m_Sampler;

            /*0x3af7da8*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string name, UnityEngine.Profiling.CustomSampler sampler);
            /*0x3af7e58*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object arg);
            /*0x3af7e94*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object[] args);
            /*0x3af7ed0*/ void Dispose();
            /*0x3af7ed8*/ void Dispose(bool disposing);
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

            static /*0x3af9580*/ ShaderDebugPrintManager();
            static /*0x3af81f0*/ UnityEngine.Rendering.ShaderDebugPrintManager get_instance();
            /*0x3af7f88*/ ShaderDebugPrintManager();
            /*0x3af7f64*/ int DebugValueTypeToElemSize(UnityEngine.Rendering.ShaderDebugPrintManager.DebugValueType type);
            /*0x3af8248*/ void SetShaderDebugPrintInputConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ShaderDebugPrintInput input);
            /*0x3af8310*/ void SetShaderDebugPrintBindings(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3af845c*/ void ClearShaderDebugPrintBuffer();
            /*0x3af854c*/ void BufferReadComplete(UnityEngine.Rendering.AsyncGPUReadbackRequest request);
            /*0x3af9380*/ void EndFrame();
            /*0x3af944c*/ void PrintImmediate();
            /*0x3af9518*/ string get_outputLine();
            /*0x3af9520*/ void set_outputAction(System.Action<string> value);
            /*0x3af9528*/ void DefaultOutput(string line);

            class Profiling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler BufferReadComplete;

                static /*0x3af967c*/ Profiling();
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

            /*0x3af9714*/ UnityEngine.Vector2 get_pos();
            /*0x3af971c*/ void set_pos(UnityEngine.Vector2 value);
            /*0x3af9724*/ bool get_leftDown();
            /*0x3af972c*/ void set_leftDown(bool value);
            /*0x3af9734*/ bool get_rightDown();
            /*0x3af973c*/ void set_rightDown(bool value);
            /*0x3af9744*/ bool get_middleDown();
            /*0x3af974c*/ void set_middleDown(bool value);
            /*0x3af9754*/ string String();
        }

        class ShaderDebugPrintInputProducer
        {
            static /*0x3af9970*/ UnityEngine.Rendering.ShaderDebugPrintInput Get();
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

            static /*0x1f33998*/ VolumeDebugSettings();
            static /*0x1f327a0*/ System.Collections.Generic.List<System.Type> get_componentTypes();
            static /*0x1f327cc*/ string ComponentDisplayName(System.Type component);
            static /*0x1f327a0*/ System.Collections.Generic.List<T> get_additionalCameraDatas();
            static /*0x1f350f8*/ void set_additionalCameraDatas(System.Collections.Generic.List<T> value);
            static /*0x1ffc854*/ void RegisterCamera(T additionalCamera);
            static /*0x1ffc854*/ void UnRegisterCamera(T additionalCamera);
            /*0x1f309e4*/ VolumeDebugSettings();
            /*0x1f2ffc8*/ int get_selectedComponent();
            /*0x1f30b78*/ void set_selectedComponent(int value);
            /*0x1f30214*/ UnityEngine.Camera get_selectedCamera();
            /*0x1f2ffc8*/ int get_selectedCameraIndex();
            /*0x1f30b78*/ void set_selectedCameraIndex(int value);
            /*0x1f30214*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x1f30214*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x1f30214*/ System.Type get_selectedComponentType();
            /*0x1f30ebc*/ void set_selectedComponentType(System.Type value);
            /*0x1f30214*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
            /*0x1f30214*/ System.Type get_targetRenderPipeline();
            /*0x1f30394*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.VolumeComponent component, System.Reflection.FieldInfo field);
            /*0x1f302cc*/ UnityEngine.Rendering.VolumeParameter GetParameter(System.Reflection.FieldInfo field);
            /*0x1f30394*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.Volume volume, System.Reflection.FieldInfo field);
            /*0x1ffc854*/ float ComputeWeight(UnityEngine.Rendering.Volume volume, UnityEngine.Vector3 triggerPos);
            /*0x1f30214*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x1f30214*/ UnityEngine.Rendering.VolumeParameter[,] GetStates();
            /*0x1f2fec8*/ bool ChangedStates(UnityEngine.Rendering.VolumeParameter[,] newStates);
            /*0x1f2fec8*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
            /*0x1f2fec8*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeDebugSettings.<>c<T> <>9;
                static /*0x0*/ System.Func<UnityEngine.Rendering.Volume, bool> <>9__34_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__36_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__43_1;
                static /*0x0*/ System.Func<System.Type, string> <>9__43_2;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f2fec8*/ bool <GetVolumes>b__34_0(UnityEngine.Rendering.Volume v);
                /*0x1f2fec8*/ bool <GetStates>b__36_0(System.Reflection.FieldInfo t);
                /*0x1f2fec8*/ bool <get_componentTypes>b__43_0(System.Type t);
                /*0x1f2fec8*/ bool <get_componentTypes>b__43_1(System.Type t);
                /*0x1f302cc*/ string <get_componentTypes>b__43_2(System.Type t);
            }

            class <>c__DisplayClass22_0<T>
            {
                /*0x0*/ System.Type value;

                /*0x1f309e4*/ <>c__DisplayClass22_0();
                /*0x1ffc854*/ bool <set_selectedComponentType>b__0(System.ValueTuple<string, System.Type> t);
            }
        }

        interface IShaderVariantSettings
        {
            /*0x1f2ffc8*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x1f30b78*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x1f2fe14*/ bool get_exportShaderVariants();
            /*0x1f30a84*/ void set_exportShaderVariants(bool value);
            /*0x3af99f0*/ bool get_stripDebugVariants();
            /*0x3af99f8*/ void set_stripDebugVariants(bool value);
        }

        class ProbeTouchupVolume : UnityEngine.Rendering.ProbeAdjustmentVolume
        {
            /*0x3af99fc*/ ProbeTouchupVolume();
        }

        class VolumeManager
        {
            static /*0x0*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerUpdate;
            static /*0x8*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerReplaceData;
            static /*0x10*/ Unity.Profiling.ProfilerMarker k_ProfilerMarkerEvaluateVolumeDefaultState;
            static /*0x18*/ System.Lazy<UnityEngine.Rendering.VolumeManager> s_Instance;
            static /*0x20*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.ValueTuple<string, System.Type>>> s_SupportedVolumeComponentsForRenderPipeline;
            /*0x10*/ UnityEngine.Rendering.VolumeStack <stack>k__BackingField;
            /*0x18*/ System.Type[] m_BaseComponentTypeArray;
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

            static /*0x3afd4b8*/ VolumeManager();
            static /*0x3afa070*/ UnityEngine.Rendering.VolumeManager get_instance();
            static /*0x3afd4b0*/ bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera);
            static /*0x3afc3e8*/ void <EvaluateVolumeDefaultState>g__ApplyDefaultProfile|60_0(UnityEngine.Rendering.VolumeProfile profile, ref UnityEngine.Rendering.VolumeManager.<> );
            /*0x3afad08*/ VolumeManager();
            /*0x3af9ac8*/ void Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x3af9d9c*/ void Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x3afa0f4*/ UnityEngine.Rendering.VolumeStack get_stack();
            /*0x3afa0fc*/ void set_stack(UnityEngine.Rendering.VolumeStack value);
            /*0x3afa104*/ System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes();
            /*0x3afa164*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> GetVolumeComponentsForDisplay(System.Type currentPipelineAssetType);
            /*0x3afa834*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> BuildVolumeComponentDisplayList(System.Type[] types);
            /*0x3afa108*/ System.Type[] get_baseComponentTypeArray();
            /*0x3afabb4*/ void set_baseComponentTypeArray(System.Type[] value);
            /*0x3afabbc*/ UnityEngine.Rendering.VolumeProfile get_globalDefaultProfile();
            /*0x3afabc4*/ void set_globalDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x3afabcc*/ UnityEngine.Rendering.VolumeProfile get_qualityDefaultProfile();
            /*0x3afabd4*/ void set_qualityDefaultProfile(UnityEngine.Rendering.VolumeProfile value);
            /*0x3afabdc*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> get_customDefaultProfiles();
            /*0x3afabe4*/ void set_customDefaultProfiles(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeProfile> value);
            /*0x3afabec*/ UnityEngine.Rendering.VolumeComponent GetVolumeComponentDefaultState(System.Type volumeComponentType);
            /*0x3afae20*/ bool get_isInitialized();
            /*0x3afae28*/ void set_isInitialized(bool value);
            /*0x3afae30*/ void Initialize(UnityEngine.Rendering.VolumeProfile globalDefaultVolumeProfile, UnityEngine.Rendering.VolumeProfile qualityDefaultVolumeProfile);
            /*0x3afaeb0*/ void InitializeInternal(UnityEngine.Rendering.VolumeProfile globalDefaultVolumeProfile, UnityEngine.Rendering.VolumeProfile qualityDefaultVolumeProfile);
            /*0x3afb950*/ void Deinitialize();
            /*0x3afbc30*/ void SetGlobalDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x3afbc4c*/ void SetQualityDefaultProfile(UnityEngine.Rendering.VolumeProfile profile);
            /*0x3afbc68*/ void SetCustomDefaultProfiles(System.Collections.Generic.List<UnityEngine.Rendering.VolumeProfile> profiles);
            /*0x3afbe04*/ void OnVolumeProfileChanged(UnityEngine.Rendering.VolumeProfile profile);
            /*0x3afbee8*/ void OnVolumeComponentChanged(UnityEngine.Rendering.VolumeComponent component);
            /*0x3afc188*/ UnityEngine.Rendering.VolumeStack CreateStack();
            /*0x3afb8b8*/ UnityEngine.Rendering.VolumeStack CreateStackInternal();
            /*0x3afc1e0*/ void ResetMainStack();
            /*0x3afbbc8*/ void DestroyStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x3afc1ec*/ bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(System.Type t, System.Type pipelineAssetType);
            /*0x3afa384*/ void LoadBaseTypes(System.Type pipelineAssetType);
            /*0x3afaf30*/ void InitializeVolumeComponents();
            /*0x3afaff8*/ void EvaluateVolumeDefaultState();
            /*0x3af9d4c*/ void Register(UnityEngine.Rendering.Volume volume);
            /*0x3afa020*/ void Unregister(UnityEngine.Rendering.Volume volume);
            /*0x1ffc854*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
            /*0x3afc5e0*/ void SetLayerDirty(int layer);
            /*0x3afc5f8*/ void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer);
            /*0x3afc610*/ void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, float interpFactor);
            /*0x3afc74c*/ void ReplaceData(UnityEngine.Rendering.VolumeStack stack);
            /*0x3afc92c*/ void CheckDefaultVolumeState();
            /*0x3afc9bc*/ void CheckStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x3afcd54*/ bool CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack);
            /*0x3afcda8*/ void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x3afcdbc*/ void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x3afd374*/ UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask);
            /*0x3afd358*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeManager.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<string, System.Type>, string> <>9__16_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.VolumeProfile> <>9__50_0;
                static /*0x18*/ System.Predicate<UnityEngine.Rendering.Volume> <>9__73_0;

                static /*0x3afd6e4*/ <>c();
                /*0x3afd74c*/ <>c();
                /*0x3afd754*/ string <BuildVolumeComponentDisplayList>b__16_0(System.ValueTuple<string, System.Type> i);
                /*0x3afd75c*/ bool <SetCustomDefaultProfiles>b__50_0(UnityEngine.Rendering.VolumeProfile x);
                /*0x3afd7b8*/ bool <GetVolumes>b__73_0(UnityEngine.Rendering.Volume v);
                /*0x3afd814*/ UnityEngine.Rendering.VolumeManager <.cctor>b__76_0();
            }

            struct <>c__DisplayClass60_0
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentsDefaultStateList;
            }

            class <>c__DisplayClass60_1
            {
                /*0x10*/ UnityEngine.Rendering.VolumeComponent profileComponent;

                /*0x3afd6dc*/ <>c__DisplayClass60_1();
                /*0x3afd864*/ bool <EvaluateVolumeDefaultState>b__1(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class CoreRPHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x3afd8d4*/ CoreRPHelpURLAttribute(string pageName, string packageName);
            /*0x3afdb20*/ CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName);
        }

        class CurrentPipelineHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x28*/ string <pageName>k__BackingField;
            /*0x30*/ string <pageHash>k__BackingField;

            /*0x3afdb54*/ CurrentPipelineHelpURLAttribute(string pageName, string pageHash);
            /*0x3afdb44*/ string get_pageName();
            /*0x3afdb4c*/ string get_pageHash();
            /*0x3afdb9c*/ string get_URL();
        }

        class DocumentationInfo
        {
            static string fallbackVersion = "13.1";
            static string packageDocumentationUrl = "https://docs.unity3d.com/Packages/{0}@{1}/manual/";
            static string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}";

            static /*0x3afdbb4*/ string get_version();
            static /*0x3afdbf4*/ string GetPackageLink(string packageName, string packageVersion, string pageName);
            static /*0x3afdd6c*/ string GetPackageLink(string packageName, string packageVersion, string pageName, string pageHash);
            static /*0x3afdf24*/ string GetPageLink(string packageName, string pageName);
            static /*0x3afd940*/ string GetPageLink(string packageName, string pageName, string pageHash);
            static /*0x3afe0c4*/ string GetDefaultPackageLink(string packageName, string packageVersion);
            static /*0x3afe120*/ string GetDefaultPackageLink(string packageName);
            /*0x3afe1a0*/ DocumentationInfo();
        }

        class DocumentationUtils
        {
            static /*0x1ffc854*/ string GetHelpURL<TEnum>(TEnum mask);
            static /*0x3afe1a8*/ bool TryGetHelpURL(System.Type type, ref string url);
        }

        interface IProbeVolumeEnabledRenderPipeline
        {
            /*0x1f2fe14*/ bool get_supportProbeVolume();
            /*0x1f2ffc8*/ UnityEngine.Rendering.ProbeVolumeSHBands get_maxSHBands();
            /*0x1f30214*/ UnityEngine.Rendering.ProbeVolumeSceneData get_probeVolumeSceneData();
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

            /*0x3af9a00*/ ProbeAdjustmentVolume();
            /*0x3afe23c*/ void Awake();
            /*0x3afe274*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3afe28c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

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

            static /*0x3afef18*/ bool BrickOverlapEntry(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, UnityEngine.Vector3Int entryMin, UnityEngine.Vector3Int entryMax);
            static /*0x3afef64*/ int LocationToIndex(int x, int y, int z, UnityEngine.Vector3Int sizeOfValid);
            /*0x3afe310*/ ProbeBrickIndex(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x3afe2a0*/ int get_estimatedVMemCost();
            /*0x3afe2a8*/ void set_estimatedVMemCost(int value);
            /*0x3afe2b0*/ UnityEngine.ComputeBuffer GetDebugFragmentationBuffer();
            /*0x3afe2b8*/ float get_fragmentationRate();
            /*0x3afe2c0*/ void set_fragmentationRate(float value);
            /*0x3afe2c8*/ int SizeOfPhysicalIndexFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x3afe5cc*/ int GetRemainingChunkCount();
            /*0x3afe5d4*/ void UploadIndexData();
            /*0x3afe64c*/ void UpdateDebugData();
            /*0x3afe534*/ void Clear();
            /*0x3afe7e4*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x3afe8d0*/ void Cleanup();
            /*0x3afe984*/ void ComputeFragmentationRate();
            /*0x3afe9ec*/ int MergeIndex(int index, int size);
            /*0x3afe9f8*/ int GetNumberOfChunks(int brickCount);
            /*0x3afea74*/ bool FindSlotsForEntries(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo);
            /*0x3afedd0*/ bool ReserveChunks(UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog);
            /*0x3afef74*/ void MarkBrickInPhysicalBuffer(ref UnityEngine.Rendering.ProbeBrickIndex.IndirectionEntryUpdateInfo entry, UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx);
            /*0x3aff2cc*/ void AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight);
            /*0x3aff67c*/ void RemoveBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);

            struct Brick : System.IEquatable<UnityEngine.Rendering.ProbeBrickIndex.Brick>
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int subdivisionLevel;

                /*0x3b14d8c*/ Brick(UnityEngine.Vector3Int position, int subdivisionLevel);
                /*0x3b14d98*/ bool Equals(UnityEngine.Rendering.ProbeBrickIndex.Brick other);
                /*0x3b14de0*/ bool IntersectArea(UnityEngine.Bounds boundInBricksToCheck);
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

                /*0x3b14f64*/ int GetNumberOfChunks();
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

            static /*0x3b17eb0*/ ProbeBrickPool();
            static /*0x3b14fbc*/ int DivRoundUp(int x, int y);
            static /*0x3b14fdc*/ void Initialize();
            static /*0x3b1607c*/ int GetChunkSizeInBrickCount();
            static /*0x3b16084*/ int GetChunkSizeInProbeCount();
            static /*0x3b166f0*/ int GetChunkCount(int brickCount);
            static /*0x3b17aa8*/ UnityEngine.Vector3Int ProbeCountToDataLocSize(int numProbes);
            static /*0x3b17b14*/ int EstimateMemoryCost(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x3b17b3c*/ int EstimateMemoryCostForBlending(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            static /*0x3b17c78*/ UnityEngine.Texture CreateDataTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes);
            static /*0x3b15720*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, ref int allocatedBytes);
            static /*0x3b155dc*/ void DerivePoolSizeFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, ref int width, ref int height, ref int depth);
            /*0x3b15468*/ ProbeBrickPool(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool allocateValidityData, bool allocateRenderingLayerData, bool allocateSkyOcclusion, bool allocateSkyShadingData, bool allocateProbeOcclusionData);
            /*0x3b14fcc*/ int get_estimatedVMemCost();
            /*0x3b14fd4*/ void set_estimatedVMemCost(int value);
            /*0x3b15448*/ UnityEngine.Texture GetValidityTexture();
            /*0x3b15450*/ UnityEngine.Texture GetSkyOcclusionTexture();
            /*0x3b15458*/ UnityEngine.Texture GetSkyShadingDirectionIndicesTexture();
            /*0x3b15460*/ UnityEngine.Texture GetProbeOcclusionTexture();
            /*0x3b155f0*/ void AllocatePool(int width, int height, int depth);
            /*0x3b15d88*/ int GetRemainingChunkCount();
            /*0x3b15d90*/ void EnsureTextureValidity();
            /*0x3b15fe8*/ bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion);
            /*0x3b1608c*/ int GetPoolWidth();
            /*0x3b16094*/ int GetPoolHeight();
            /*0x3b1609c*/ UnityEngine.Vector3Int GetPoolDimensions();
            /*0x3b160ac*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x3b16694*/ void Clear();
            /*0x3b16708*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog);
            /*0x3b1694c*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x3b16b4c*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            /*0x3b16ffc*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, bool updateSharedData, UnityEngine.Texture validityTexture, UnityEngine.Rendering.ProbeVolumeSHBands bands, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x3b17914*/ void UpdateValidity(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex);
            /*0x3b17ea8*/ void Cleanup();

            struct BrickChunkAlloc
            {
                /*0x10*/ int x;
                /*0x14*/ int y;
                /*0x18*/ int z;

                /*0x3b18178*/ int flattenIndex(int sx, int sy);
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

                /*0x3b15e1c*/ void Cleanup();
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

            static /*0x3b194c8*/ ProbeBrickBlendingPool();
            static /*0x3b1818c*/ void Initialize();
            /*0x3b18454*/ ProbeBrickBlendingPool(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool probeOcclusion);
            /*0x3b182fc*/ bool get_isAllocated();
            /*0x3b1830c*/ int get_estimatedVMemCost();
            /*0x3b1840c*/ int GetPoolWidth();
            /*0x3b18424*/ int GetPoolHeight();
            /*0x3b1843c*/ int GetPoolDepth();
            /*0x3b18490*/ void AllocateResourcesIfNeeded();
            /*0x3b185f8*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state);
            /*0x3b18670*/ void Update(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state, UnityEngine.Texture validityTexture, bool skyOcclusion, UnityEngine.Texture skyOcclusionTexture, bool skyShadingDirections, UnityEngine.Texture skyShadingDirectionsTexture, bool probeOcclusion);
            /*0x3b1874c*/ void PerformBlending(UnityEngine.Rendering.CommandBuffer cmd, float factor, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x3b19258*/ void BlendChunks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x3b19394*/ void Clear();
            /*0x3b193a4*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations);
            /*0x3b193fc*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x3b19460*/ void EnsureTextureValidity();
            /*0x3b19490*/ void Cleanup();
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

            /*0x3b19930*/ ProbeGlobalIndirection(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, int cellSizeInMinBricks);
            /*0x3b19890*/ int get_estimatedVMemCost();
            /*0x3b19898*/ void set_estimatedVMemCost(int value);
            /*0x3b198a0*/ void GetMinMaxEntry(ref UnityEngine.Vector3Int minEntry, ref UnityEngine.Vector3Int maxEntry);
            /*0x3b198c4*/ UnityEngine.Vector3Int GetGlobalIndirectionDimension();
            /*0x3b198d4*/ UnityEngine.Vector3Int GetGlobalIndirectionMinEntry();
            /*0x3b198e4*/ int get_entrySizeInBricks();
            /*0x3b198f8*/ int get_entriesPerCellDimension();
            /*0x3b19918*/ int GetFlatIndex(UnityEngine.Vector3Int normalizedPos);
            /*0x3b19b14*/ int GetFlatIdxForEntry(UnityEngine.Vector3Int entryPosition);
            /*0x3b19b44*/ int[] GetFlatIndicesForCell(UnityEngine.Vector3Int cellPosition);
            /*0x3b19c8c*/ void UpdateCell(UnityEngine.Rendering.ProbeReferenceVolume.CellIndexInfo cellInfo);
            /*0x3b1a030*/ void MarkEntriesAsUnloaded(int[] entriesFlatIndices);
            /*0x3b1a0b8*/ void PushComputeData();
            /*0x3b1a0e4*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x3b1a11c*/ void Cleanup();

            struct IndexMetaData
            {
                static /*0x0*/ uint[] s_PackedValues;
                /*0x10*/ UnityEngine.Vector3Int minLocalIdx;
                /*0x1c*/ UnityEngine.Vector3Int maxLocalIdxPlusOne;
                /*0x28*/ int firstChunkIndex;
                /*0x2c*/ int minSubdiv;

                static /*0x3b1a188*/ IndexMetaData();
                /*0x3b19f00*/ void Pack(ref uint[] vals);
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
            /*0x148*/ UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference m_CurrentBakingSetReference;
            /*0x150*/ UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference m_LazyBakingSetReference;
            /*0x158*/ bool m_NeedLoadAsset;
            /*0x159*/ bool m_ProbeReferenceVolumeInit;
            /*0x15a*/ bool m_EnabledBySRP;
            /*0x15b*/ bool m_VertexSampling;
            /*0x15c*/ bool m_NeedsIndexRebuild;
            /*0x15d*/ bool m_HasChangedIndex;
            /*0x160*/ int m_CBShaderID;
            /*0x164*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
            /*0x168*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;
            /*0x16c*/ UnityEngine.Rendering.ProbeVolumeSHBands m_SHBands;
            /*0x170*/ bool clearAssetsOnVolumeClear;
            /*0x178*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> <perSceneDataList>k__BackingField;
            /*0x180*/ UnityEngine.Rendering.ProbeVolumeDebug <probeVolumeDebug>k__BackingField;
            /*0x188*/ UnityEngine.Color[] <subdivisionDebugColors>k__BackingField;
            /*0x190*/ UnityEngine.Mesh m_DebugMesh;
            /*0x198*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
            /*0x1a0*/ UnityEngine.Material m_DebugMaterial;
            /*0x1a8*/ UnityEngine.Mesh m_DebugProbeSamplingMesh;
            /*0x1b0*/ UnityEngine.Material m_ProbeSamplingDebugMaterial;
            /*0x1b8*/ UnityEngine.Material m_ProbeSamplingDebugMaterial02;
            /*0x1c0*/ UnityEngine.Texture m_DisplayNumbersTexture;
            /*0x1c8*/ UnityEngine.Mesh m_DebugOffsetMesh;
            /*0x1d0*/ UnityEngine.Material m_DebugOffsetMaterial;
            /*0x1d8*/ UnityEngine.Material m_DebugFragmentationMaterial;
            /*0x1e0*/ UnityEngine.Plane[] m_DebugFrustumPlanes;
            /*0x1e8*/ UnityEngine.GUIContent[] m_DebugScenarioNames;
            /*0x1f0*/ int[] m_DebugScenarioValues;
            /*0x1f8*/ string m_DebugActiveSceneGUID;
            /*0x200*/ string m_DebugActiveScenario;
            /*0x208*/ UnityEngine.Rendering.DebugUI.EnumField m_DebugScenarioField;
            /*0x210*/ System.Collections.Generic.Dictionary<UnityEngine.Bounds, UnityEngine.Rendering.ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;
            /*0x218*/ bool m_MaxSubdivVisualizedIsMaxAvailable;
            /*0x219*/ bool m_LoadMaxCellsPerFrame;
            /*0x21c*/ int m_NumberOfCellsLoadedPerFrame;
            /*0x220*/ int m_NumberOfCellsBlendedPerFrame;
            /*0x224*/ float m_TurnoverRate;
            /*0x228*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_LoadedCells;
            /*0x230*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_ToBeLoadedCells;
            /*0x238*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_WorseLoadedCells;
            /*0x240*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_BestToBeLoadedCells;
            /*0x248*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempCellToLoadList;
            /*0x250*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempCellToUnloadList;
            /*0x258*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_LoadedBlendingCells;
            /*0x260*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_ToBeLoadedBlendingCells;
            /*0x268*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempBlendingCellToLoadList;
            /*0x270*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempBlendingCellToUnloadList;
            /*0x278*/ UnityEngine.Vector3 m_FrozenCameraPosition;
            /*0x284*/ UnityEngine.Vector3 m_FrozenCameraDirection;
            /*0x290*/ bool m_IndexDefragmentationInProgress;
            /*0x298*/ UnityEngine.Rendering.ProbeBrickIndex m_DefragIndex;
            /*0x2a0*/ UnityEngine.Rendering.ProbeGlobalIndirection m_DefragCellIndices;
            /*0x2a8*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_IndexDefragCells;
            /*0x2b0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> m_TempIndexDefragCells;
            /*0x2b8*/ float minStreamingScore;
            /*0x2bc*/ float maxStreamingScore;
            /*0x2c0*/ System.Collections.Generic.Queue<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_StreamingQueue;
            /*0x2c8*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_ActiveStreamingRequests;
            /*0x2d0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> m_StreamingRequestsPool;
            /*0x2d8*/ bool m_DiskStreamingUseCompute;
            /*0x2e0*/ UnityEngine.Rendering.ProbeVolumeScratchBufferPool m_ScratchBufferPool;
            /*0x2e8*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate m_OnStreamingComplete;
            /*0x2f0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate m_OnBlendingStreamingComplete;

            static /*0x3b139f8*/ ProbeReferenceVolume();
            static /*0x3b010bc*/ string GetSceneGUID(UnityEngine.SceneManagement.Scene scene);
            static /*0x3b02334*/ UnityEngine.Rendering.ProbeReferenceVolume get_instance();
            static /*0x3b04820*/ int GetNumberOfBricksAtSubdiv(UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo);
            static /*0x3b047f0*/ int CellSize(int subdivisionLevel);
            static /*0x3b0e7b0*/ void UpdateDebugFromSelection(ref UnityEngine.Vector4[] _AdjustmentVolumeBounds, ref int _AdjustmentVolumeCount);
            static /*0x3b0fe00*/ void ComputeCellStreamingScore(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            static /*0x3b1294c*/ int BlendingComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            static /*0x3b1299c*/ int DefragComparer(UnityEngine.Rendering.ProbeReferenceVolume.Cell a, UnityEngine.Rendering.ProbeReferenceVolume.Cell b);
            /*0x3b09ff4*/ ProbeReferenceVolume();
            /*0x3aff744*/ void BindAPVRuntimeResources(UnityEngine.Rendering.CommandBuffer cmdBuffer, bool isProbeVolumeEnabled);
            /*0x3b0034c*/ bool UpdateShaderVariablesProbeVolumes(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumesOptions probeVolumeOptions, int taaFrameIndex, bool supportRenderingLayers);
            /*0x3b00b44*/ UnityEngine.Bounds get_globalBounds();
            /*0x3b00b58*/ void set_globalBounds(UnityEngine.Bounds value);
            /*0x3b00834*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_m_CurrentBakingSet();
            /*0x3b00b6c*/ void set_m_CurrentBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet value);
            /*0x3b00b84*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_m_LazyBakingSet();
            /*0x3b00b9c*/ void set_m_LazyBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet value);
            /*0x3b00bb4*/ bool get_isInitialized();
            /*0x3b00bbc*/ bool get_enabledBySRP();
            /*0x3b00bc4*/ bool get_vertexSampling();
            /*0x3b00bcc*/ bool get_hasUnloadedCells();
            /*0x3b00c1c*/ bool get_supportLightingScenarios();
            /*0x3b00c24*/ bool get_supportScenarioBlending();
            /*0x3b00c2c*/ bool get_gpuStreamingEnabled();
            /*0x3b00c34*/ bool get_diskStreamingEnabled();
            /*0x3b00c54*/ bool get_probeOcclusion();
            /*0x3b006ec*/ bool get_skyOcclusion();
            /*0x3b00790*/ bool get_skyOcclusionShadingDirection();
            /*0x3b00cf8*/ bool get_useRenderingLayers();
            /*0x3b00d28*/ UnityEngine.Rendering.ProbeVolumeSHBands get_shBands();
            /*0x3b00d30*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_currentBakingSet();
            /*0x3b00d48*/ string get_lightingScenario();
            /*0x3b00de4*/ void set_lightingScenario(string value);
            /*0x3b00eac*/ string get_otherScenario();
            /*0x3b00f48*/ float get_scenarioBlendingFactor();
            /*0x3b00fe0*/ void set_scenarioBlendingFactor(float value);
            /*0x3b00dec*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x3b01114*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x3b011d4*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget();
            /*0x3b011dc*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> get_perSceneDataList();
            /*0x3b011e4*/ void set_perSceneDataList(System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> value);
            /*0x3b011f4*/ void RegisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x3b0129c*/ bool ScheduleBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b012cc*/ bool ProcessScheduledBakingSet();
            /*0x3b01734*/ void SetActiveScene(UnityEngine.SceneManagement.Scene scene);
            /*0x3b01388*/ void SetActiveBakingSet(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b01b2c*/ void SetBakingSetAsCurrent(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b021c8*/ void RegisterBakingSet(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x3b01a40*/ void UnloadBakingSet();
            /*0x3b02284*/ void UnregisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x3b017c8*/ bool TryGetPerSceneData(string sceneGUID, ref UnityEngine.Rendering.ProbeVolumePerSceneData perSceneData);
            /*0x3b0230c*/ float get_indexFragmentationRate();
            /*0x3b0238c*/ void Initialize(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x3b02950*/ void SetEnableStateFromSRP(bool srpEnablesPV);
            /*0x3b02958*/ void SetVertexSamplingEnabled(bool value);
            /*0x3b02960*/ void ForceMemoryBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget budget);
            /*0x3b02968*/ void ForceSHBand(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x3b02e24*/ void ForceNoDiskStreaming(bool state);
            /*0x3b02e2c*/ void Cleanup();
            /*0x3b032e8*/ int GetVideoMemoryCost();
            /*0x3b03364*/ void RemoveCell(int cellIndex);
            /*0x3b034c4*/ void UnloadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b03628*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b0399c*/ void UnloadAllCells();
            /*0x3b03a78*/ void UnloadAllBlendingCells();
            /*0x3b03b54*/ void AddCell(int cellIndex);
            /*0x3b03db0*/ bool LoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, bool ignoreErrorLog);
            /*0x3b04d04*/ void LoadAllCells();
            /*0x3b04e40*/ void ComputeCellGlobalInfo();
            /*0x3b050c8*/ void AddPendingSceneLoading(string sceneGUID, UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b055dc*/ void AddPendingSceneRemoval(string sceneGUID);
            /*0x3b05738*/ void RemovePendingScene(string sceneGUID, System.Collections.Generic.List<int> cellList);
            /*0x3b05948*/ void PerformPendingIndexChangeAndInit();
            /*0x3b0218c*/ void SetSubdivisionDimensions(float minBrickSize, int maxSubdiv, UnityEngine.Vector3 offset);
            /*0x3b05d00*/ bool LoadCells(System.Collections.Generic.List<int> cellIndices);
            /*0x3b05ddc*/ void PerformPendingLoading();
            /*0x3b06394*/ void PerformPendingDeletion();
            /*0x3b04434*/ void ComputeEntryMinMax(ref UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo entryInfo, System.ReadOnlySpan<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks);
            /*0x3b02264*/ void PerformPendingOperations();
            /*0x3b0597c*/ void InitializeGlobalIndirection();
            /*0x3b01c68*/ void InitProbeReferenceVolume();
            /*0x3b001f0*/ UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources();
            /*0x3b05c24*/ void SetMaxSubdivision(int maxSubdivision);
            /*0x3b0a8f4*/ float BrickSize(int subdivisionLevel);
            /*0x3b0a988*/ float MinBrickSize();
            /*0x3b0a990*/ float MaxBrickSize();
            /*0x3b0a99c*/ UnityEngine.Vector3 ProbeOffset();
            /*0x3b0a9a8*/ int GetMaxSubdivision();
            /*0x3b0a9b0*/ int GetMaxSubdivision(float multiplier);
            /*0x3b0aa30*/ float GetDistanceBetweenProbes(int subdivisionLevel);
            /*0x3b0aa48*/ float MinDistanceBetweenProbes();
            /*0x3b0aa64*/ int GetGlobalIndirectionEntryMaxSubdiv();
            /*0x3b047d8*/ int GetEntrySubdivLevel();
            /*0x3b0aa6c*/ float GetEntrySize();
            /*0x3b0069c*/ bool DataHasBeenLoaded();
            /*0x3b0aa84*/ void Clear();
            /*0x3b0abcc*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, UnityEngine.Rendering.ProbeBrickPool.DataLocation dataLoc);
            /*0x1ffc854*/ void UpdateDataLocationTexture<T>(UnityEngine.Texture output, Unity.Collections.NativeArray<T> input);
            /*0x3b0ad38*/ void UpdateValidityTextureWithoutMask(UnityEngine.Texture output, Unity.Collections.NativeArray<byte> input);
            /*0x3b0aeec*/ void UpdatePool(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionL0L1Data, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex, int poolIndex);
            /*0x3b0b428*/ void UpdatePool(UnityEngine.Rendering.CommandBuffer cmd, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex);
            /*0x3b0b644*/ void UpdateSharedData(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, Unity.Collections.NativeArray<byte> validityNeighMaskData, Unity.Collections.NativeArray<ushort> skyOcclusionData, Unity.Collections.NativeArray<byte> skyShadingDirectionIndices, int chunkIndex);
            /*0x3b0b92c*/ bool AddBlendingBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b04338*/ bool ReservePoolChunks(int brickCount, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, bool ignoreErrorLog);
            /*0x3b04b50*/ void ReleasePoolChunks(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList);
            /*0x3b0c128*/ void UpdatePoolAndIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, int poolIndex, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b048e8*/ bool AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b0c00c*/ void UpdateCellIndex(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b037a8*/ void ReleaseBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b0084c*/ void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumeShadingParameters parameters);
            /*0x3b02b24*/ void DeinitProbeReferenceVolume();
            /*0x3b02f50*/ void CleanupLoadedData();
            /*0x3b0c5ac*/ UnityEngine.Rendering.ProbeVolumeDebug get_probeVolumeDebug();
            /*0x3b0c5b4*/ UnityEngine.Color[] get_subdivisionDebugColors();
            /*0x3b0c5bc*/ UnityEngine.Mesh get_debugMesh();
            /*0x3b0c730*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x3b0c73c*/ void RenderDebug(UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options, UnityEngine.Texture exposureTexture);
            /*0x3b0da20*/ bool IsProbeSamplingDebugEnabled();
            /*0x3b0da8c*/ bool GetProbeSamplingDebugResources(UnityEngine.Camera camera, ref UnityEngine.GraphicsBuffer resultBuffer, ref UnityEngine.Vector2 coords);
            /*0x3b0dbc0*/ bool TryCreateDebugRenderData();
            /*0x3b02868*/ void InitializeDebug();
            /*0x3b02f54*/ void CleanupDebug();
            /*0x1ffc854*/ void DebugCellIndexChanged<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x3b067cc*/ void RegisterDebug();
            /*0x3b06694*/ void UnregisterDebug(bool destroyPanel);
            /*0x3b0e1bc*/ void RenderFragmentationOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer, UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer, UnityEngine.Rendering.DebugOverlay debugOverlay);
            /*0x3b0e4c0*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes);
            /*0x3b0e65c*/ UnityEngine.Bounds GetCellBounds(UnityEngine.Vector3 cellPosition);
            /*0x3b0e7dc*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Vector4[] adjustmentVolumeBounds, int adjustmentVolumeCount);
            /*0x3b0c840*/ void DrawProbeDebug(UnityEngine.Camera camera, UnityEngine.Texture exposureTexture);
            /*0x3b0f794*/ void ResetDebugViewToMaxSubdiv();
            /*0x3b03900*/ void ClearDebugData();
            /*0x3b0ead0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b0f8c4*/ void OnClearLightingdata();
            /*0x3b0f8c8*/ void EnableMaxCellStreaming(bool value);
            /*0x3b0f8d0*/ void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
            /*0x3b0f8ec*/ bool get_loadMaxCellsPerFrame();
            /*0x3b0f8f4*/ void set_loadMaxCellsPerFrame(bool value);
            /*0x3b0f8fc*/ int get_numberOfCellsLoadedPerFrame();
            /*0x3b0f964*/ int get_numberOfCellsBlendedPerFrame();
            /*0x3b0f96c*/ void set_numberOfCellsBlendedPerFrame(int value);
            /*0x3b0f97c*/ float get_turnoverRate();
            /*0x3b0f984*/ void set_turnoverRate(float value);
            /*0x3b0288c*/ void InitStreaming();
            /*0x3b03050*/ void CleanupStreaming();
            /*0x3b0fd58*/ void ScenarioBlendingChanged(bool scenarioChanged);
            /*0x3b10000*/ void ComputeStreamingScore(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells);
            /*0x3b10108*/ void ComputeBestToBeLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x3b10454*/ void ComputeStreamingScoreAndWorseLoadedCells(UnityEngine.Vector3 cameraPosition, UnityEngine.Vector3 cameraDirection);
            /*0x3b1080c*/ void ComputeBlendingScore(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> cells, float worstScore);
            /*0x3b108fc*/ bool TryLoadCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, ref int shBudget, ref int indexBudget, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x3b10a04*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> unloadedCells);
            /*0x3b10a7c*/ bool TryLoadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.Cell> loadedCells);
            /*0x3b10b44*/ void ComputeMinMaxStreamingScore();
            /*0x3b10ca4*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
            /*0x3b10cac*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Rendering.ProbeVolumesOptions options);
            /*0x3b12838*/ int FindWorstBlendingCellToBeLoaded();
            /*0x3b1223c*/ void UpdateBlendingCellStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b04c00*/ void StartIndexDefragmentation();
            /*0x3b118ec*/ void UpdateIndexDefragmentation();
            /*0x3b12a34*/ void OnStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b12abc*/ void OnBlendingStreamingComplete(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b0be6c*/ void PushDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, string scenario, int poolIndex, UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete);
            /*0x3b03734*/ void CancelStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b03950*/ void CancelBlendingStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b12bbc*/ bool ProcessDiskStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request);
            /*0x3b13878*/ void AllocateScratchBufferPoolIfNeeded();
            /*0x3b0fa94*/ void UpdateActiveRequests(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b0f9a4*/ void ProcessNewRequests();
            /*0x3b11dd4*/ void UpdateDiskStreaming(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b0f7bc*/ bool HasActiveStreamingRequest(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x3b139a0*/ void LogStreaming(string log);
            /*0x1ffc854*/ void <RegisterDebug>g__RefreshDebug|229_0<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x3b13bd4*/ bool <RegisterDebug>b__229_2();
            /*0x3b13bec*/ void <RegisterDebug>b__229_3(bool value);
            /*0x3b13c08*/ bool <RegisterDebug>b__229_4();
            /*0x3b13c20*/ void <RegisterDebug>b__229_5(bool value);
            /*0x3b13c3c*/ float <RegisterDebug>b__229_6();
            /*0x3b13c54*/ void <RegisterDebug>b__229_7(float value);
            /*0x3b13c6c*/ bool <RegisterDebug>b__229_9();
            /*0x3b13c84*/ void <RegisterDebug>b__229_10(bool value);
            /*0x3b13ca0*/ bool <RegisterDebug>b__229_11();
            /*0x3b13cc0*/ int <RegisterDebug>b__229_12();
            /*0x3b13cd8*/ void <RegisterDebug>b__229_13(int value);
            /*0x3b13cf0*/ int <RegisterDebug>b__229_14();
            /*0x3b13d08*/ void <RegisterDebug>b__229_15(int value);
            /*0x3b13d20*/ float <RegisterDebug>b__229_16();
            /*0x3b13d38*/ void <RegisterDebug>b__229_17(float value);
            /*0x3b13d50*/ float <RegisterDebug>b__229_20();
            /*0x3b13d68*/ void <RegisterDebug>b__229_21(float value);
            /*0x3b13d80*/ bool <RegisterDebug>b__229_22();
            /*0x3b13db0*/ int <RegisterDebug>b__229_23();
            /*0x3b13dc8*/ void <RegisterDebug>b__229_24(int v);
            /*0x3b13df4*/ int <RegisterDebug>b__229_26();
            /*0x3b13e04*/ int <RegisterDebug>b__229_27();
            /*0x3b13e1c*/ void <RegisterDebug>b__229_28(int v);
            /*0x3b13e38*/ int <RegisterDebug>b__229_30();
            /*0x3b13e48*/ bool <RegisterDebug>b__229_31();
            /*0x3b13e60*/ void <RegisterDebug>b__229_32(bool value);
            /*0x3b13ee4*/ bool <RegisterDebug>b__229_33();
            /*0x3b13f04*/ float <RegisterDebug>b__229_34();
            /*0x3b13f1c*/ void <RegisterDebug>b__229_35(float value);
            /*0x3b13f34*/ bool <RegisterDebug>b__229_38();
            /*0x3b13f4c*/ void <RegisterDebug>b__229_39(bool value);
            /*0x3b13f68*/ bool <RegisterDebug>b__229_40();
            /*0x3b13f80*/ void <RegisterDebug>b__229_41(bool value);
            /*0x3b140c8*/ bool <RegisterDebug>b__229_42();
            /*0x3b140e8*/ float <RegisterDebug>b__229_43();
            /*0x3b14100*/ void <RegisterDebug>b__229_44(float value);
            /*0x3b14118*/ bool <RegisterDebug>b__229_47();
            /*0x3b14138*/ float <RegisterDebug>b__229_48();
            /*0x3b14150*/ void <RegisterDebug>b__229_49(float value);
            /*0x3b14168*/ bool <RegisterDebug>b__229_51();
            /*0x3b14180*/ void <RegisterDebug>b__229_52(bool value);
            /*0x3b1419c*/ bool <RegisterDebug>b__229_53();
            /*0x3b141b4*/ void <RegisterDebug>b__229_54(bool value);
            /*0x3b141d0*/ bool <RegisterDebug>b__229_55();
            /*0x3b14200*/ bool <RegisterDebug>b__229_56();
            /*0x3b14218*/ void <RegisterDebug>b__229_57(bool value);
            /*0x3b14234*/ bool <RegisterDebug>b__229_58();
            /*0x3b1424c*/ void <RegisterDebug>b__229_59(bool value);
            /*0x3b14268*/ bool <RegisterDebug>b__229_67();
            /*0x3b14280*/ void <RegisterDebug>b__229_68(bool value);
            /*0x3b1429c*/ bool <RegisterDebug>b__229_69();
            /*0x3b142bc*/ bool <RegisterDebug>b__229_71();
            /*0x3b142d4*/ void <RegisterDebug>b__229_72(bool value);
            /*0x3b142f0*/ bool <RegisterDebug>b__229_73();
            /*0x3b14308*/ void <RegisterDebug>b__229_74(bool value);
            /*0x3b14324*/ void <RegisterDebug>g__RefreshScenarioNames|229_75(string guid);
            /*0x3b14ae8*/ int <RegisterDebug>b__229_83();
            /*0x3b14ca8*/ void <RegisterDebug>b__229_84(int value);
            /*0x3b14d5c*/ int <RegisterDebug>b__229_85();
            /*0x3b14d74*/ void <RegisterDebug>b__229_86(int value);

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

                static /*0x3b1a1fc*/ ShaderIDs();
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

                /*0x3b1a5dc*/ CellDesc();
                /*0x3b1a524*/ string ToString();
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

                /*0x3b1ac00*/ CellData();
                /*0x3b1a5e4*/ Unity.Collections.NativeArray<ushort> get_skyOcclusionDataL0L1();
                /*0x3b1a5f0*/ void set_skyOcclusionDataL0L1(Unity.Collections.NativeArray<ushort> value);
                /*0x3b1a5f8*/ Unity.Collections.NativeArray<byte> get_skyShadingDirectionIndices();
                /*0x3b1a604*/ void set_skyShadingDirectionIndices(Unity.Collections.NativeArray<byte> value);
                /*0x3b1a60c*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> get_bricks();
                /*0x3b1a618*/ void set_bricks(Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> value);
                /*0x3b1a620*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_probePositions();
                /*0x3b1a62c*/ void set_probePositions(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x3b1a634*/ Unity.Collections.NativeArray<float> get_touchupVolumeInteraction();
                /*0x3b1a640*/ void set_touchupVolumeInteraction(Unity.Collections.NativeArray<float> value);
                /*0x3b1a648*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_offsetVectors();
                /*0x3b1a654*/ void set_offsetVectors(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x3b1a65c*/ Unity.Collections.NativeArray<float> get_validity();
                /*0x3b1a668*/ void set_validity(Unity.Collections.NativeArray<float> value);
                /*0x3b1a670*/ Unity.Collections.NativeArray<byte> get_layer();
                /*0x3b1a67c*/ void set_layer(Unity.Collections.NativeArray<byte> value);
                /*0x3b1a684*/ void CleanupPerScenarioData(ref UnityEngine.Rendering.ProbeReferenceVolume.CellData.PerScenarioData data);
                /*0x3b1a7cc*/ void Cleanup(bool cleanScenarioList);

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

                /*0x3b1ad24*/ CellPoolInfo();
                /*0x3b1ac88*/ void Clear();
            }

            class CellIndexInfo
            {
                /*0x10*/ int[] flatIndicesInGlobalIndirection;
                /*0x18*/ UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo updateInfo;
                /*0x20*/ bool indexUpdated;
                /*0x28*/ UnityEngine.Rendering.ProbeReferenceVolume.IndirectionEntryInfo[] indirectionEntryInfo;
                /*0x30*/ int indexChunkCount;

                /*0x3b1addc*/ CellIndexInfo();
                /*0x3b1adac*/ void Clear();
            }

            class CellBlendingInfo
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x18*/ float blendingScore;
                /*0x1c*/ float blendingFactor;
                /*0x20*/ bool blending;

                /*0x3b1aee8*/ CellBlendingInfo();
                /*0x3b1ade4*/ void MarkUpToDate();
                /*0x3b1adf0*/ bool IsUpToDate();
                /*0x3b1ae08*/ void ForceReupload();
                /*0x3b1ae14*/ bool ShouldReupload();
                /*0x3b1ae28*/ void Prioritize();
                /*0x3b1ae34*/ bool ShouldPrioritize();
                /*0x3b1ae48*/ void Clear();
            }

            class CellStreamingInfo
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest0;
                /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest blendingRequest1;
                /*0x28*/ float streamingScore;

                /*0x3b1b01c*/ CellStreamingInfo();
                /*0x3b1af70*/ bool IsStreaming();
                /*0x3b1afa0*/ bool IsBlendingStreaming();
                /*0x3b1afdc*/ void Clear();
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

                /*0x3b1b1e4*/ Cell();
                /*0x3b1b024*/ int CompareTo(UnityEngine.Rendering.ProbeReferenceVolume.Cell other);
                /*0x3b1b070*/ bool UpdateCellScenarioData(string scenario0, string scenario1);
                /*0x3b1b130*/ void Clear();
            }

            struct Volume : System.IEquatable<UnityEngine.Rendering.ProbeReferenceVolume.Volume>
            {
                /*0x10*/ UnityEngine.Vector3 corner;
                /*0x1c*/ UnityEngine.Vector3 X;
                /*0x28*/ UnityEngine.Vector3 Y;
                /*0x34*/ UnityEngine.Vector3 Z;
                /*0x40*/ float maxSubdivisionMultiplier;
                /*0x44*/ float minSubdivisionMultiplier;

                /*0x3b1b300*/ Volume(UnityEngine.Matrix4x4 trs, float maxSubdivision, float minSubdivision);
                /*0x3b1b3e4*/ Volume(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, float maxSubdivision, float minSubdivision);
                /*0x3b1b424*/ Volume(UnityEngine.Rendering.ProbeReferenceVolume.Volume copy);
                /*0x3b1b4b8*/ Volume(UnityEngine.Bounds bounds);
                /*0x3b1b518*/ UnityEngine.Bounds CalculateAABB();
                /*0x3b1b620*/ void CalculateCenterAndSize(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
                /*0x3b1b7d0*/ void Transform(UnityEngine.Matrix4x4 trs);
                /*0x3b1b868*/ string ToString();
                /*0x3b1bab8*/ bool Equals(UnityEngine.Rendering.ProbeReferenceVolume.Volume other);
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

                /*0x3b1bbac*/ CellInstancedDebugProbes();
            }

            class RenderFragmentationOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugFragmentationMaterial;
                /*0x18*/ UnityEngine.Rendering.DebugOverlay debugOverlay;
                /*0x20*/ int chunkCount;
                /*0x28*/ UnityEngine.ComputeBuffer debugFragmentationData;
                /*0x30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer;
                /*0x40*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthBuffer;

                /*0x3b1bbb4*/ RenderFragmentationOverlayPassData();
            }

            class DiskStreamingRequest
            {
                /*0x10*/ Unity.IO.LowLevel.Unsafe.ReadHandle m_ReadHandle;
                /*0x20*/ Unity.IO.LowLevel.Unsafe.ReadCommandArray m_ReadCommandArray;
                /*0x30*/ Unity.Collections.NativeArray<Unity.IO.LowLevel.Unsafe.ReadCommand> m_ReadCommandBuffer;
                /*0x40*/ int m_BytesWritten;

                /*0x3b1bbbc*/ DiskStreamingRequest(int maxRequestCount);
                /*0x3b1bc40*/ void AddReadCommand(int offset, int size, byte* dest);
                /*0x3b1bc7c*/ int RunCommands(Unity.IO.LowLevel.Unsafe.FileHandle file);
                /*0x3b1bcf8*/ void Clear();
                /*0x3b1bd4c*/ void Cancel();
                /*0x3b1bd7c*/ void Wait();
                /*0x3b1bdc4*/ void Dispose();
                /*0x3b1be0c*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus();
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

                /*0x3b1be40*/ CellStreamingScratchBuffer(int chunkCount, int chunkSize, bool allocateGraphicsBuffers);
                /*0x3b1bfb4*/ void Swap();
                /*0x3b1bfd0*/ void Dispose();
                /*0x3b178e0*/ UnityEngine.GraphicsBuffer get_buffer();
                /*0x3b1c060*/ int get_chunkCount();
                /*0x3b1c068*/ int get_chunkSize();
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

                /*0x3b1c49c*/ CellStreamingRequest();
                /*0x3b1c070*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell get_cell();
                /*0x3b1c078*/ void set_cell(UnityEngine.Rendering.ProbeReferenceVolume.Cell value);
                /*0x3b1c080*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State get_state();
                /*0x3b1c088*/ void set_state(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest.State value);
                /*0x3b1c090*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer get_scratchBuffer();
                /*0x3b1c098*/ void set_scratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer value);
                /*0x3b1c0a0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout get_scratchBufferLayout();
                /*0x3b1c0b0*/ void set_scratchBufferLayout(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout value);
                /*0x3b1c0bc*/ UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo get_scenarioData();
                /*0x3b1c0c4*/ void set_scenarioData(UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo value);
                /*0x3b1c0cc*/ int get_poolIndex();
                /*0x3b1c0d4*/ void set_poolIndex(int value);
                /*0x3b1c0dc*/ bool get_streamSharedData();
                /*0x3b1c0e4*/ void set_streamSharedData(bool value);
                /*0x3b1af90*/ bool IsStreaming();
                /*0x3b1c0ec*/ void Cancel();
                /*0x3b1c1f4*/ void WaitAll();
                /*0x3b1c260*/ bool UpdateRequestState(UnityEngine.Rendering.ProbeReferenceVolume.DiskStreamingRequest request, ref bool isComplete);
                /*0x3b1c2d4*/ void UpdateState();
                /*0x3b1c3a4*/ void Clear();
                /*0x3b1c3c4*/ void Reset();
                /*0x3b1c444*/ void Dispose();

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
                    /*0x3b1c5bc*/ OnStreamingCompleteDelegate(object object, nint method);
                    /*0x3b1c6c8*/ void Invoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x3b1c6dc*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest request, UnityEngine.Rendering.CommandBuffer cmd, System.AsyncCallback callback, object object);
                    /*0x3b1c704*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeReferenceVolume.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.Cell> <>9__158_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> <>9__158_1;
                static /*0x18*/ System.Func<bool> <>9__229_1;
                static /*0x20*/ System.Func<float> <>9__229_8;
                static /*0x28*/ System.Func<float> <>9__229_18;
                static /*0x30*/ System.Func<float> <>9__229_19;
                static /*0x38*/ System.Func<int> <>9__229_25;
                static /*0x40*/ System.Func<int> <>9__229_29;
                static /*0x48*/ System.Func<float> <>9__229_36;
                static /*0x50*/ System.Func<float> <>9__229_37;
                static /*0x58*/ System.Func<float> <>9__229_45;
                static /*0x60*/ System.Func<float> <>9__229_46;
                static /*0x68*/ System.Func<float> <>9__229_50;
                static /*0x70*/ System.Func<bool> <>9__229_60;
                static /*0x78*/ System.Action<bool> <>9__229_61;
                static /*0x80*/ System.Func<bool> <>9__229_62;
                static /*0x88*/ System.Func<int> <>9__229_63;
                static /*0x90*/ System.Action<int> <>9__229_64;
                static /*0x98*/ System.Func<int> <>9__229_65;
                static /*0xa0*/ System.Func<int> <>9__229_66;
                static /*0xa8*/ System.Func<object> <>9__229_70;
                static /*0xb0*/ System.Func<int> <>9__229_76;
                static /*0xb8*/ System.Action<int> <>9__229_77;
                static /*0xc0*/ System.Func<int> <>9__229_78;
                static /*0xc8*/ System.Func<float> <>9__229_79;
                static /*0xd0*/ System.Action<float> <>9__229_80;
                static /*0xd8*/ System.Func<float> <>9__229_81;
                static /*0xe0*/ System.Func<float> <>9__229_82;
                static /*0xe8*/ System.Func<float> <>9__229_87;
                static /*0xf0*/ System.Action<float> <>9__229_88;
                static /*0xf8*/ System.Func<float> <>9__229_89;
                static /*0x100*/ System.Func<float> <>9__229_90;
                static /*0x108*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.ProbeReferenceVolume.RenderFragmentationOverlayPassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__232_0;
                static /*0x110*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest> <>9__293_0;

                static /*0x3b1c710*/ <>c();
                /*0x3b1c778*/ <>c();
                /*0x3b1c780*/ void <.ctor>b__158_0(UnityEngine.Rendering.ProbeReferenceVolume.Cell x);
                /*0x3b1c794*/ void <.ctor>b__158_1(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
                /*0x3b1c7c0*/ bool <RegisterDebug>b__229_1();
                /*0x3b1c7c8*/ float <RegisterDebug>b__229_8();
                /*0x3b1c7d0*/ float <RegisterDebug>b__229_18();
                /*0x3b1c7dc*/ float <RegisterDebug>b__229_19();
                /*0x3b1c7e4*/ int <RegisterDebug>b__229_25();
                /*0x3b1c7ec*/ int <RegisterDebug>b__229_29();
                /*0x3b1c7f4*/ float <RegisterDebug>b__229_36();
                /*0x3b1c800*/ float <RegisterDebug>b__229_37();
                /*0x3b1c808*/ float <RegisterDebug>b__229_45();
                /*0x3b1c814*/ float <RegisterDebug>b__229_46();
                /*0x3b1c820*/ float <RegisterDebug>b__229_50();
                /*0x3b1c828*/ bool <RegisterDebug>b__229_60();
                /*0x3b1c8bc*/ void <RegisterDebug>b__229_61(bool value);
                /*0x3b1c958*/ bool <RegisterDebug>b__229_62();
                /*0x3b1c9ec*/ int <RegisterDebug>b__229_63();
                /*0x3b1ca80*/ void <RegisterDebug>b__229_64(int value);
                /*0x3b1cb1c*/ int <RegisterDebug>b__229_65();
                /*0x3b1cb24*/ int <RegisterDebug>b__229_66();
                /*0x3b1cb2c*/ object <RegisterDebug>b__229_70();
                /*0x3b1cbdc*/ int <RegisterDebug>b__229_76();
                /*0x3b1cc70*/ void <RegisterDebug>b__229_77(int value);
                /*0x3b1cd0c*/ int <RegisterDebug>b__229_78();
                /*0x3b1cd14*/ float <RegisterDebug>b__229_79();
                /*0x3b1cda8*/ void <RegisterDebug>b__229_80(float value);
                /*0x3b1ce4c*/ float <RegisterDebug>b__229_81();
                /*0x3b1ce54*/ float <RegisterDebug>b__229_82();
                /*0x3b1ce5c*/ float <RegisterDebug>b__229_87();
                /*0x3b1cef0*/ void <RegisterDebug>b__229_88(float value);
                /*0x3b1cf94*/ float <RegisterDebug>b__229_89();
                /*0x3b1cf9c*/ float <RegisterDebug>b__229_90();
                /*0x3b1cfa4*/ void <RenderFragmentationOverlay>b__232_0(UnityEngine.Rendering.ProbeReferenceVolume.RenderFragmentationOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                /*0x3b1d10c*/ void <CleanupStreaming>b__293_0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest val);
            }

            class <>c__DisplayClass324_0
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell cell;

                /*0x3b1d138*/ <>c__DisplayClass324_0();
                /*0x3b1d140*/ bool <HasActiveStreamingRequest>b__0(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingRequest x);
            }
        }

        class SceneExtensions
        {
            static /*0x0*/ System.Reflection.PropertyInfo s_SceneGUID;

            static /*0x3b1d220*/ SceneExtensions();
            static /*0x3b1d160*/ string GetGUID(UnityEngine.SceneManagement.Scene scene);
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

            /*0x3b1d2dc*/ ProbeSamplingDebugData();
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

            /*0x3b1d2ec*/ ProbeVolumeDebug();
            /*0x3b1d3a4*/ void Init();
            /*0x3b1d410*/ System.Action GetReset();
            /*0x3b1d48c*/ void <GetReset>b__32_0();
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

            static /*0x3b1d4f8*/ ProbeVolumeDebugColorPreferences();
            /*0x3b1d598*/ ProbeVolumeDebugColorPreferences();
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

            /*0x3b1d5d4*/ ProbeVolume();
            /*0x3b1d5a0*/ void Awake();

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
            /*0x3b1d628*/ ObsoleteProbeVolumeAsset();
        }

        struct ProbeDilationSettings
        {
            /*0x10*/ bool enableDilation;
            /*0x14*/ float dilationDistance;
            /*0x18*/ float dilationValidityThreshold;
            /*0x1c*/ int dilationIterations;
            /*0x20*/ bool squaredDistWeighting;

            /*0x3b1d630*/ void SetDefaults();
            /*0x3b1d650*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct VirtualOffsetSettings
        {
            /*0x10*/ bool useVirtualOffset;
            /*0x14*/ float validityThreshold;
            /*0x18*/ float outOfGeoOffset;
            /*0x1c*/ float searchMultiplier;
            /*0x20*/ float rayOriginBias;
            /*0x24*/ UnityEngine.LayerMask collisionMask;

            /*0x3b1d654*/ void SetDefaults();
            /*0x3b1d688*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct ProbeVolumeBakingProcessSettings
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion m_Version;
            /*0x14*/ UnityEngine.Rendering.ProbeDilationSettings dilationSettings;
            /*0x28*/ UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings;

            static /*0x3b1d6c4*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings get_Default();
            /*0x3b1d770*/ ProbeVolumeBakingProcessSettings(UnityEngine.Rendering.ProbeDilationSettings dilationSettings, UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings);
            /*0x3b1d720*/ void SetDefaults();
            /*0x3b1d79c*/ void Upgrade();

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

            /*0x3b1d7e4*/ LogarithmicAttribute(int min, int max);
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

            static /*0x3b1d8d4*/ int GetCellSizeInBricks(int simplificationLevels);
            static /*0x3b1d910*/ int GetMaxSubdivision(int simplificationLevels);
            static /*0x3b1d938*/ float GetMinBrickSize(float minDistanceBetweenProbes);
            static /*0x3b1fdb0*/ int AlignUp16(int count);
            /*0x3b22304*/ ProbeVolumeBakingSet();
            /*0x3b1d810*/ bool get_hasDilation();
            /*0x3b1d830*/ System.Collections.Generic.IReadOnlyList<string> get_sceneGUIDs();
            /*0x3b1d838*/ System.Collections.Generic.IReadOnlyList<string> get_lightingScenarios();
            /*0x3b1d840*/ bool get_bakedSkyOcclusion();
            /*0x3b1d850*/ void set_bakedSkyOcclusion(bool value);
            /*0x3b1d868*/ bool get_bakedSkyShadingDirection();
            /*0x3b1d878*/ void set_bakedSkyShadingDirection(bool value);
            /*0x3b1d890*/ string get_otherScenario();
            /*0x3b1d898*/ float get_scenarioBlendingFactor();
            /*0x3b1d8a0*/ int get_cellSizeInBricks();
            /*0x3b1d904*/ int get_maxSubdivision();
            /*0x3b1d918*/ float get_minBrickSize();
            /*0x3b1d954*/ float get_cellSizeInMeters();
            /*0x3b1d9b8*/ Unity.Mathematics.uint4 ComputeRegionMasks();
            /*0x3b1da9c*/ void OnValidate();
            /*0x3b1dbec*/ void OnEnable();
            /*0x3b1dc20*/ void Migrate();
            /*0x3b1dda4*/ bool ComputeHasValidSharedData();
            /*0x3b1dea0*/ bool HasValidSharedData();
            /*0x3b1dea8*/ bool CheckCompatibleCellLayout();
            /*0x3b1dd64*/ bool ComputeHasSupportData();
            /*0x3b1df54*/ bool HasSupportData();
            /*0x3b1df5c*/ bool HasBakedData(string scenario);
            /*0x3b1e098*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3b1e658*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3b1e9e0*/ void Initialize(bool useStreamingAsset);
            /*0x3b1f2c8*/ void Cleanup();
            /*0x3b1f8f8*/ void SetActiveScenario(string scenario, bool verbose);
            /*0x3b1efa8*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x3b1fbc0*/ int GetBakingHashCode();
            /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetSubArray<T>(Unity.Collections.NativeArray<byte> input, int count, ref int offset);
            /*0x3b1fdd8*/ Unity.Collections.NativeArray<byte> RequestScratchBuffer(int size);
            /*0x3b1fec4*/ bool FileExists(string path);
            /*0x1ffc854*/ Unity.Collections.NativeArray<T> LoadStreambleAssetData<T>(UnityEngine.Rendering.ProbeVolumeStreamableAsset asset, System.Collections.Generic.List<int> cellIndices);
            /*0x1ffc854*/ void ReleaseStreamableAssetData<T>(Unity.Collections.NativeArray<T> buffer);
            /*0x3b1ff20*/ void PruneCellIndexList(System.Collections.Generic.List<int> cellIndices, System.Collections.Generic.List<int> prunedIndexList);
            /*0x3b2019c*/ void PruneCellIndexListForScenario(System.Collections.Generic.List<int> cellIndices, UnityEngine.Rendering.ProbeVolumeBakingSet.PerScenarioDataInfo scenarioData, System.Collections.Generic.List<int> prunedIndexList);
            /*0x3b20444*/ System.Collections.Generic.List<int> GetSceneCellIndexList(string sceneGUID);
            /*0x3b1ef78*/ bool ResolveAllCellData();
            /*0x3b20dec*/ bool ResolveCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x3b2135c*/ void ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricksData, Unity.Collections.NativeArray<byte> cellSharedData, Unity.Collections.NativeArray<byte> cellSupportData);
            /*0x3b204bc*/ bool ResolveSharedCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x3b206dc*/ bool ResolvePerScenarioCellData(System.Collections.Generic.List<int> cellIndices);
            /*0x3b21a08*/ bool ResolvePerScenarioCellData(Unity.Collections.NativeArray<byte> cellData, Unity.Collections.NativeArray<byte> cellOptionalData, Unity.Collections.NativeArray<byte> cellProbeOcclusionData, string scenario, System.Collections.Generic.List<int> cellIndices);
            /*0x3b21f60*/ void ReleaseCell(int cellIndex);
            /*0x3b22008*/ UnityEngine.Rendering.ProbeReferenceVolume.CellDesc GetCellDesc(int cellIndex);
            /*0x3b22084*/ UnityEngine.Rendering.ProbeReferenceVolume.CellData GetCellData(int cellIndex);
            /*0x3b22100*/ int GetChunkGPUMemory(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x3b2213c*/ bool HasSameSceneGUIDs(UnityEngine.Rendering.ProbeVolumeBakingSet other);

            enum Version
            {
                Initial = 0,
                RemoveProbeVolumeSceneData = 1,
                AssetsAlwaysReferenced = 2,
            }

            class PerScenarioDataInfo
            {
                /*0x10*/ int sceneHash;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellDataAsset;
                /*0x20*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellOptionalDataAsset;
                /*0x28*/ UnityEngine.Rendering.ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset;
                /*0x30*/ bool m_HasValidData;

                /*0x3b227d8*/ PerScenarioDataInfo();
                /*0x3b1ef5c*/ void Initialize(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x3b1f8d0*/ bool IsValid();
                /*0x3b227d0*/ bool HasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
                /*0x3b22778*/ bool ComputeHasValidData(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            }

            struct CellCounts
            {
                /*0x10*/ int bricksCount;
                /*0x14*/ int chunksCount;

                /*0x3b227e0*/ void Add(UnityEngine.Rendering.ProbeVolumeBakingSet.CellCounts o);
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

        class ProbeVolumeBakingSetWeakReference
        {
            /*0x10*/ int m_InstanceID;

            /*0x3b227f8*/ ProbeVolumeBakingSetWeakReference(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b228b4*/ ProbeVolumeBakingSetWeakReference();
            /*0x3b22824*/ void Set(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet);
            /*0x3b228d0*/ UnityEngine.Rendering.ProbeVolumeBakingSet Get();
            /*0x3b22930*/ bool IsLoaded();
            /*0x3b2293c*/ void Unload();
        }

        class ProbeVolumeConstantRuntimeResources
        {
            static int NB_SKY_PRECOMPUTED_DIRECTIONS = 255;
            static /*0x0*/ UnityEngine.ComputeBuffer m_SkySamplingDirectionsBuffer;
            static /*0x8*/ UnityEngine.ComputeBuffer m_AntiLeakDataBuffer;
            static /*0x10*/ UnityEngine.Vector3[] k_SkyDirections;
            static /*0x18*/ uint[] k_AntiLeakData;

            static /*0x3b22ea0*/ ProbeVolumeConstantRuntimeResources();
            static /*0x3b22970*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            static /*0x3b229ec*/ void Initialize();
            static /*0x3b22d7c*/ UnityEngine.Vector3[] GetSkySamplingDirections();
            static /*0x3b22dd4*/ void Cleanup();
            static /*0x3b22b84*/ UnityEngine.Vector3[] GenerateSkyDirections();
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

            /*0x3b22fa8*/ ProbeVolumeRuntimeResources();
            /*0x3b22fa0*/ int get_version();
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

            /*0x3b22fc0*/ ProbeVolumeDebugResources();
            /*0x3b22fb8*/ int get_version();
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

            /*0x3b22fd8*/ ProbeVolumeBakingResources();
            /*0x3b22fd0*/ int get_version();
        }

        class ProbeVolumeGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ int m_Version;
            /*0x14*/ bool m_ProbeVolumeDisableStreamingAssets;

            /*0x3b23080*/ ProbeVolumeGlobalSettings();
            /*0x3b22fe8*/ int get_version();
            /*0x3b22ff0*/ bool get_probeVolumeDisableStreamingAssets();
            /*0x3b22ff8*/ void set_probeVolumeDisableStreamingAssets(bool value);
        }

        class ProbeVolumePerSceneData : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Rendering.ProbeVolumeBakingSet serializedBakingSet;
            /*0x28*/ string sceneGUID;
            /*0x30*/ UnityEngine.Rendering.ObsoleteProbeVolumeAsset obsoleteAsset;
            /*0x38*/ UnityEngine.TextAsset obsoleteCellSharedDataAsset;
            /*0x40*/ UnityEngine.TextAsset obsoleteCellSupportDataAsset;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData.ObsoleteSerializablePerScenarioDataItem> obsoleteSerializedScenarios;

            /*0x3b23508*/ ProbeVolumePerSceneData();
            /*0x3b23090*/ UnityEngine.Rendering.ProbeVolumeBakingSet get_bakingSet();
            /*0x3b23098*/ void Clear();
            /*0x3b2319c*/ void QueueSceneLoading();
            /*0x3b230b8*/ void QueueSceneRemoval();
            /*0x3b23280*/ void OnEnable();
            /*0x3b2331c*/ void OnDisable();
            /*0x3b233c0*/ void OnValidate();
            /*0x3b233c4*/ void Initialize();
            /*0x3b23470*/ bool ResolveCellData();

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

            static /*0x3b243b8*/ ProbeVolumePositioning();
            static /*0x3b235b4*/ bool OBBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Rendering.ProbeReferenceVolume.Volume b);
            static /*0x3b23d20*/ bool OBBContains(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume obb, UnityEngine.Vector3 point);
            static /*0x3b23df8*/ bool OBBAABBIntersect(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, ref UnityEngine.Bounds b, ref UnityEngine.Bounds aAABB);
            static /*0x3b23c40*/ UnityEngine.Vector2 ProjectOBB(ref UnityEngine.Rendering.ProbeReferenceVolume.Volume a, UnityEngine.Vector3 axis);
            static /*0x3b24318*/ UnityEngine.Vector2 ProjectAABB(ref UnityEngine.Vector3[] corners, UnityEngine.Vector3 axis);
        }

        class ProbeVolumeSceneData
        {
            /*0x10*/ UnityEngine.Object parentAsset;
            /*0x18*/ UnityEngine.Rendering.SerializedDictionary<string, UnityEngine.Bounds> obsoleteSceneBounds;
            /*0x20*/ UnityEngine.Rendering.SerializedDictionary<string, bool> obsoleteHasProbeVolumes;

            /*0x3b24450*/ ProbeVolumeSceneData(UnityEngine.Object parentAsset);
            /*0x3b24480*/ void SetParentObject(UnityEngine.Object parent);
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

            /*0x3b244b8*/ ProbeVolumeScratchBufferPool(UnityEngine.Rendering.ProbeVolumeBakingSet bakingSet, UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x3b24488*/ int get_chunkSize();
            /*0x3b24490*/ void set_chunkSize(int value);
            /*0x3b24498*/ int get_maxChunkCount();
            /*0x3b244a0*/ void set_maxChunkCount(int value);
            /*0x3b244a8*/ int get_allocatedMemory();
            /*0x3b2461c*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount);
            /*0x3b24870*/ UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers);
            /*0x3b248f0*/ bool AllocateScratchBuffer(int chunkCount, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer, ref UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers);
            /*0x3b24ce0*/ void ReleaseScratchBuffer(UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer);
            /*0x3b24e78*/ void Cleanup();

            class ScratchBufferPool : System.IComparable<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool>
            {
                /*0x10*/ int chunkCount;
                /*0x18*/ System.Collections.Generic.Stack<UnityEngine.Rendering.ProbeReferenceVolume.CellStreamingScratchBuffer> pool;

                /*0x3b24c44*/ ScratchBufferPool(int chunkCount);
                /*0x3b250fc*/ ScratchBufferPool();
                /*0x3b2518c*/ int CompareTo(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool other);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeVolumeScratchBufferPool.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__26_0;
                static /*0x10*/ System.Predicate<UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool> <>9__27_0;

                static /*0x3b251b0*/ <>c();
                /*0x3b25218*/ <>c();
                /*0x3b25220*/ bool <AllocateScratchBuffer>b__26_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
                /*0x3b25280*/ bool <ReleaseScratchBuffer>b__27_0(UnityEngine.Rendering.ProbeVolumeScratchBufferPool.ScratchBufferPool o);
            }
        }

        class APVLeakReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.APVLeakReductionMode>
        {
            /*0x3b252e0*/ APVLeakReductionModeParameter(UnityEngine.Rendering.APVLeakReductionMode value, bool overrideState);
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

            /*0x3b25350*/ ProbeVolumesOptions();
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

            /*0x3b256a0*/ ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID);
            /*0x3b25680*/ string get_assetGUID();
            /*0x3b25688*/ UnityEngine.TextAsset get_asset();
            /*0x3b25690*/ int get_elementSize();
            /*0x3b25698*/ UnityEngine.Rendering.SerializedDictionary<int, UnityEngine.Rendering.ProbeVolumeStreamableAsset.StreamableCellDesc> get_streamableCellDescs();
            /*0x3b25838*/ void RefreshAssetPath();
            /*0x3b258dc*/ string GetAssetPath();
            /*0x3b25908*/ bool HasValidAssetReference();
            /*0x3b1dddc*/ bool FileExists();
            /*0x3b25994*/ long GetFileSize();
            /*0x3b25a0c*/ bool IsOpen();
            /*0x3b25a18*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFile();
            /*0x3b25a54*/ void CloseFile();
            /*0x3b1df34*/ bool IsValid();
            /*0x3b1f878*/ void Dispose();

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

            static /*0x3b25ac4*/ APVDefinitions();
            /*0x3b25abc*/ APVDefinitions();
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

            static /*0x3b25f74*/ SphericalHarmonicsL1();
            static /*0x3b25bb8*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x3b25be0*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x3b25c08*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x3b25c28*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x3b25c4c*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x3b25cfc*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            /*0x3b25d94*/ bool Equals(object other);
            /*0x3b25e64*/ int GetHashCode();
        }

        class SphericalHarmonicsL2Utils
        {
            static /*0x3b26008*/ void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L1_R, ref UnityEngine.Vector3 L1_G, ref UnityEngine.Vector3 L1_B);
            static /*0x3b2611c*/ void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L2_0, ref UnityEngine.Vector3 L2_1, ref UnityEngine.Vector3 L2_2, ref UnityEngine.Vector3 L2_3, ref UnityEngine.Vector3 L2_4);
            static /*0x3b262d8*/ void SetL0(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L0);
            static /*0x3b26334*/ void SetL1R(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R);
            static /*0x3b26390*/ void SetL1G(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_G);
            static /*0x3b263ec*/ void SetL1B(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_B);
            static /*0x3b26448*/ void SetL1(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B);
            static /*0x3b264ac*/ void SetCoefficient(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index, UnityEngine.Vector3 coefficient);
            static /*0x3b26514*/ UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index);
            /*0x3b26584*/ SphericalHarmonicsL2Utils();
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
            /*0x1f2fe14*/ bool IsActive();
            /*0x3b2658c*/ bool IsTileCompatible();
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

            static /*0x3b2d698*/ LensFlareCommonSRP();
            static /*0x3b2659c*/ bool IsOcclusionRTCompatible();
            static /*0x3b26660*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetOcclusionRTFormat();
            static /*0x3b266c8*/ void Initialize();
            static /*0x3b268b8*/ void Dispose();
            static /*0x3b26990*/ UnityEngine.Rendering.LensFlareCommonSRP get_Instance();
            static /*0x3b27110*/ float ShapeAttenuationPointLight();
            static /*0x3b27118*/ float ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b27138*/ float ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, float spotAngle, float innerSpotPercent01);
            static /*0x3b271ec*/ float ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b2721c*/ float ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b272c4*/ float ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, float lightWidth, UnityEngine.Camera cam);
            static /*0x3b277d8*/ float ShapeAttenuateForwardLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b277f8*/ float ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b27890*/ float ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x3b27928*/ bool IsLensFlareSRPHidden(UnityEngine.Camera cam, UnityEngine.Rendering.LensFlareComponentSRP comp, UnityEngine.Rendering.LensFlareDataSRP data);
            static /*0x3b27a4c*/ UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, UnityEngine.Vector2 positionOffset, bool autoRotate);
            static /*0x3b27c40*/ UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, float position, float globalCos0, float globalSin0, UnityEngine.Vector2 vAspectRatio);
            static /*0x3b27c74*/ UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, bool isLocalLight, bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS);
            static /*0x3b27db8*/ UnityEngine.Vector3 WorldToViewportLocal(bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS);
            static /*0x3b27e34*/ UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS);
            static /*0x3b27f1c*/ bool IsCloudLayerOpacityNeeded(UnityEngine.Camera cam);
            static /*0x3b2820c*/ void SetOcclusionPermutation(UnityEngine.Rendering.CommandBuffer cmd, bool useFogOpacityOcclusion, int _FlareSunOcclusionTex, UnityEngine.Texture sunOcclusionTexture);
            static /*0x3b28320*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x3b285b4*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x3b2847c*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x3b296c4*/ bool ForceSingleElement(UnityEngine.Rendering.LensFlareDataElementSRP element);
            static /*0x3b28708*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x3b29868*/ void ProcessLensFlareSRPElementsSingle(UnityEngine.Rendering.LensFlareDataElementSRP element, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x3b2af2c*/ void ProcessLensFlareSRPElements(ref UnityEngine.Rendering.LensFlareDataElementSRP[] elements, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Color globalColorModulation, UnityEngine.Light light, float compIntensity, float scale, UnityEngine.Material lensFlareShader, UnityEngine.Vector2 screenPos, bool compAllowOffScreen, UnityEngine.Vector2 vScreenRatio, UnityEngine.Vector4 flareData1, bool preview, int depth);
            static /*0x3b2b2ac*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x3b2b4bc*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x3b2c5f0*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x3b2b67c*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, UnityEngine.Rect viewport, UnityEngine.Experimental.Rendering.XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, bool debugView);
            static /*0x3b2c798*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.UnsafeCommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x3b2d2f4*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, int _LensFlareScreenSpaceBloomMipTexture, int _LensFlareScreenSpaceResultTexture, int _LensFlareScreenSpaceSpectralLut, int _LensFlareScreenSpaceStreakTex, int _LensFlareScreenSpaceMipLevel, int _LensFlareScreenSpaceTintColor, int _LensFlareScreenSpaceParams1, int _LensFlareScreenSpaceParams2, int _LensFlareScreenSpaceParams3, int _LensFlareScreenSpaceParams4, int _LensFlareScreenSpaceParams5, bool debugView);
            static /*0x3b2c9e4*/ void DoLensFlareScreenSpaceCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, UnityEngine.Color tintColor, UnityEngine.Texture originalBloomTexture, UnityEngine.Texture bloomMipTexture, UnityEngine.Texture spectralLut, UnityEngine.Texture streakTextureTmp, UnityEngine.Texture streakTextureTmp2, UnityEngine.Vector4 parameters1, UnityEngine.Vector4 parameters2, UnityEngine.Vector4 parameters3, UnityEngine.Vector4 parameters4, UnityEngine.Vector4 parameters5, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle result, bool debugView);
            static /*0x3b296fc*/ UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance);
            static /*0x3b2d55c*/ UnityEngine.Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView);
            static /*0x3b2d5a0*/ UnityEngine.Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d);
            static /*0x3b2d664*/ UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, float d);
            static /*0x3b2dd6c*/ float <ShapeAttenuationAreaTubeLight>g__Fpo|57_0(float d, float l);
            static /*0x3b2ddac*/ float <ShapeAttenuationAreaTubeLight>g__Fwt|57_1(float d, float l);
            static /*0x3b274f4*/ float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|57_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
            static /*0x3b2b0f8*/ UnityEngine.Vector2 <ProcessLensFlareSRPElementsSingle>g__ComputeLocalSize|74_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, ref UnityEngine.Rendering.LensFlareCommonSRP.<> );
            static /*0x3b2b2a4*/ float <ProcessLensFlareSRPElementsSingle>g__RandomRange|74_1(float min, float max);
            /*0x3b26594*/ LensFlareCommonSRP();
            /*0x3b26b20*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo> get_Data();
            /*0x3b26b78*/ bool IsEmpty();
            /*0x3b26bfc*/ int GetNextAvailableIndex();
            /*0x3b26d20*/ void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData);
            /*0x3b26ed4*/ void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data);

            class LensFlareCompInfo
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.Rendering.LensFlareComponentSRP comp;

                /*0x3b2ddc4*/ LensFlareCompInfo(int idx, UnityEngine.Rendering.LensFlareComponentSRP cmp);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP newData;

                /*0x3b2ddfc*/ <>c__DisplayClass50_0();
                /*0x3b2de04*/ bool <AddData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP data;

                /*0x3b2de74*/ <>c__DisplayClass51_0();
                /*0x3b2de7c*/ bool <RemoveData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
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

            static /*0x3b2e57c*/ LensFlareComponentSRP();
            /*0x3b2e20c*/ LensFlareComponentSRP();
            /*0x3b2deec*/ UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData();
            /*0x3b2def4*/ void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value);
            /*0x3b2dff4*/ float celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam);
            /*0x3b2e0bc*/ void Awake();
            /*0x3b2e0c0*/ void OnEnable();
            /*0x3b2e18c*/ void OnDisable();
            /*0x3b2df10*/ void OnValidate();
            /*0x3b2e1f4*/ void OnDestroy();

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

            /*0x3b2e5cc*/ LensFlareDataElementSRP();
            /*0x3b2ee54*/ UnityEngine.Rendering.LensFlareDataElementSRP Clone();
            /*0x3b2f354*/ float get_localIntensity();
            /*0x3b2eda8*/ void set_localIntensity(float value);
            /*0x3b2f35c*/ int get_count();
            /*0x3b2edbc*/ void set_count(int value);
            /*0x3b2f364*/ float get_intensityVariation();
            /*0x3b2edcc*/ void set_intensityVariation(float value);
            /*0x3b2f36c*/ float get_fallOff();
            /*0x3b2ede0*/ void set_fallOff(float value);
            /*0x3b2f374*/ float get_edgeOffset();
            /*0x3b2ee00*/ void set_edgeOffset(float value);
            /*0x3b2f37c*/ int get_sideCount();
            /*0x3b2ee40*/ void set_sideCount(int value);
            /*0x3b2f384*/ float get_sdfRoundness();
            /*0x3b2ee20*/ void set_sdfRoundness(float value);
        }

        class LensFlareDataSRP : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.LensFlareDataElementSRP[] elements;

            /*0x3b2f38c*/ LensFlareDataSRP();
            /*0x3b2f3b0*/ bool HasAModulateByLightColorElement();
        }

        enum LensFlareOcclusionPermutation
        {
            Depth = 1,
            FogOpacity = 4,
        }

        class DebugDisplaySettingsRenderGraph : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x3b2f408*/ DebugDisplaySettingsRenderGraph();
            /*0x3b2f628*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();
            /*0x3b2facc*/ bool get_AreAnySettingsActive();

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x3b2f678*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsRenderGraph _);
                /*0x3b2fcdc*/ string get_PanelName();
            }
        }

        class RenderGraphGlobalSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphGlobalSettings.Version m_version;
            /*0x14*/ bool m_EnableCompilationCaching;
            /*0x15*/ bool m_EnableValidityChecks;

            /*0x3b2fe4c*/ RenderGraphGlobalSettings();
            /*0x3b2fd1c*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x3b2fd24*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x3b2fd2c*/ bool get_enableCompilationCaching();
            /*0x3b2fd34*/ void set_enableCompilationCaching(bool value);
            /*0x3b2fdbc*/ bool get_enableValidityChecks();
            /*0x3b2fdc4*/ void set_enableValidityChecks(bool value);

            enum Version
            {
                Initial = 0,
                Count = 1,
                Last = 0,
            }
        }

        interface ICloudBackground
        {
            /*0x1f2fe14*/ bool IsCloudBackgroundUsable();
        }

        interface IVolumetricCloud
        {
            /*0x1f2fe14*/ bool IsVolumetricCloudUsable();
        }

        class RenderPipelineGlobalSettings<TGlobalRenderPipelineSettings, TRenderPipeline> : UnityEngine.Rendering.RenderPipelineGlobalSettings
        {
            static /*0x0*/ System.Lazy<TGlobalRenderPipelineSettings> s_Instance;

            static /*0x1f33998*/ RenderPipelineGlobalSettings();
            static /*0x1ffc854*/ TGlobalRenderPipelineSettings get_instance();
            /*0x1f309e4*/ RenderPipelineGlobalSettings();
            /*0x1f309e4*/ void Reset();

            class <>c<TGlobalRenderPipelineSettings, TRenderPipeline>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderPipelineGlobalSettings.<>c<TGlobalRenderPipelineSettings, TRenderPipeline> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1ffc854*/ TGlobalRenderPipelineSettings <.cctor>b__5_0();
            }
        }

        class RenderPipelineGraphicsSettingsContainer : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Rendering.RenderPipelineGraphicsSettingsCollection m_RuntimeSettings;

            /*0x3b2fe7c*/ RenderPipelineGraphicsSettingsContainer();
            /*0x3b2fe5c*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x3b2fe74*/ void OnBeforeSerialize();
            /*0x3b2fe78*/ void OnAfterDeserialize();
        }

        class RenderPipelineResources : UnityEngine.ScriptableObject
        {
            /*0x3b2fefc*/ RenderPipelineResources();
            /*0x3b2fee8*/ string get_packagePath();
            /*0x3b2fef0*/ string get_packagePath_Internal();
        }

        interface IDefaultVolumeProfileAsset : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x1f30214*/ UnityEngine.Rendering.VolumeProfile get_defaultVolumeProfile();
            /*0x1f30ebc*/ void set_defaultVolumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        interface IDefaultVolumeProfileSettings : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x3b2ff04*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x1f30214*/ UnityEngine.Rendering.VolumeProfile get_volumeProfile();
            /*0x1f30ebc*/ void set_volumeProfile(UnityEngine.Rendering.VolumeProfile value);
        }

        class IncludeAdditionalRPAssets : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.IncludeAdditionalRPAssets.Version m_version;
            /*0x14*/ bool m_IncludeReferencedInScenes;
            /*0x15*/ bool m_IncludeAssetsByLabel;
            /*0x18*/ string m_LabelToInclude;

            /*0x3b300b0*/ IncludeAdditionalRPAssets();
            /*0x3b2ff0c*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x3b2ff14*/ bool get_includeReferencedInScenes();
            /*0x3b2ff1c*/ void set_includeReferencedInScenes(bool value);
            /*0x3b2ffa4*/ bool get_includeAssetsByLabel();
            /*0x3b2ffac*/ void set_includeAssetsByLabel(bool value);
            /*0x3b30034*/ string get_labelToInclude();
            /*0x3b3003c*/ void set_labelToInclude(string value);

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

            /*0x3b30274*/ ShaderStrippingSetting();
            /*0x3b300b8*/ int get_version();
            /*0x3b300c0*/ bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild();
            /*0x3b300c8*/ bool get_exportShaderVariants();
            /*0x3b300d0*/ void set_exportShaderVariants(bool value);
            /*0x3b30158*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x3b30160*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x3b301e4*/ bool get_stripRuntimeDebugShaders();
            /*0x3b301ec*/ void set_stripRuntimeDebugShaders(bool value);

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

            /*0x3b30288*/ GenerateHLSL(UnityEngine.Rendering.PackingRules rules, bool needAccessors, bool needSetters, bool needParamDebug, int paramDefinesStart, bool omitStructDeclaration, bool containsPackedFields, bool generateCBuffer, int constantRegister, string sourcePath);
        }

        class SurfaceDataAttributes : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ bool isDirection;
            /*0x19*/ bool sRGBDisplay;
            /*0x1c*/ UnityEngine.Rendering.FieldPrecision precision;
            /*0x20*/ bool checkIsNormalized;
            /*0x28*/ string preprocessor;

            /*0x3b30324*/ SurfaceDataAttributes(string displayName, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
            /*0x3b3040c*/ SurfaceDataAttributes(string[] displayNames, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
        }

        class HLSLArray : System.Attribute
        {
            /*0x10*/ int arraySize;
            /*0x18*/ System.Type elementType;

            /*0x3b30480*/ HLSLArray(int arraySize, System.Type elementType);
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

            /*0x3b304b8*/ PackingAttribute(string[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
            /*0x3b305d4*/ PackingAttribute(string displayName, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
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

            static /*0x3b30c3c*/ Hammersley();
            static /*0x3b3072c*/ void Initialize();
            static /*0x3b30ae8*/ void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs);

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
            /*0x1f2fe14*/ bool get_isStpUsed();
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

            static /*0x3b34194*/ STP();
            static /*0x3b30e80*/ bool IsSupported();
            static /*0x3b30eac*/ UnityEngine.Vector2 Jit16(int frameIndex);
            static /*0x3b30ef4*/ UnityEngine.GUIContent[] get_debugViewDescriptions();
            static /*0x3b30f4c*/ int[] get_debugViewIndices();
            static /*0x3b30fa4*/ UnityEngine.Rendering.STP.PerViewConfig[] get_perViewConfigs();
            static /*0x3b30ffc*/ void set_perViewConfigs(UnityEngine.Rendering.STP.PerViewConfig[] value);
            static /*0x3b3105c*/ UnityEngine.Hash128 ComputeHistoryHash(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
            static /*0x3b31110*/ UnityEngine.Vector2Int CalculateConvergenceTextureSize(UnityEngine.Vector2Int historyTextureSize);
            static /*0x3b31190*/ float CalculateMotionScale(float deltaTime, float lastDeltaTime);
            static /*0x3b3121c*/ UnityEngine.Matrix4x4 ExtractRotation(UnityEngine.Matrix4x4 input);
            static /*0x3b312a4*/ int PackVector2ToInt(UnityEngine.Vector2 value);
            static /*0x3b312dc*/ void PopulateConstantData(ref UnityEngine.Rendering.STP.Config config, ref UnityEngine.Rendering.STP.StpConstantBufferData constants);
            static /*0x3b31fc8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseTexture(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder, UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
            static /*0x3b32084*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle Execute(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.STP.Config config);

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

                /*0x3b34c08*/ HistoryContext();
                /*0x3b345bc*/ bool Update(ref UnityEngine.Rendering.STP.HistoryUpdateInfo info);
                /*0x3b3415c*/ UnityEngine.Rendering.RTHandle GetCurrentHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x3b34120*/ UnityEngine.Rendering.RTHandle GetPreviousHistoryTexture(UnityEngine.Rendering.STP.HistoryTextureType historyType, int frameIndex);
                /*0x3b3493c*/ void Dispose();
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

                static /*0x3b34c80*/ ShaderResources();
            }

            class ShaderKeywords
            {
                static /*0x0*/ string EnableDebugMode;
                static /*0x8*/ string EnableLargeKernel;
                static /*0x10*/ string EnableStencilResponsive;
                static /*0x18*/ string DisableTexture2DXArray;

                static /*0x3b35068*/ ShaderKeywords();
            }

            class RuntimeResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
            {
                /*0x10*/ UnityEngine.ComputeShader m_setupCS;
                /*0x18*/ UnityEngine.ComputeShader m_preTaaCS;
                /*0x20*/ UnityEngine.ComputeShader m_taaCS;

                /*0x3b352d4*/ RuntimeResources();
                /*0x3b35158*/ int get_version();
                /*0x3b35160*/ UnityEngine.ComputeShader get_setupCS();
                /*0x3b35168*/ void set_setupCS(UnityEngine.ComputeShader value);
                /*0x3b351dc*/ UnityEngine.ComputeShader get_preTaaCS();
                /*0x3b351e4*/ void set_preTaaCS(UnityEngine.ComputeShader value);
                /*0x3b35258*/ UnityEngine.ComputeShader get_taaCS();
                /*0x3b35260*/ void set_taaCS(UnityEngine.ComputeShader value);
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

                /*0x3b352dc*/ SetupData();
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

                /*0x3b352e4*/ PreTaaData();
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

                /*0x3b352ec*/ TaaData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.STP.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.SetupData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.PreTaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_1;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.STP.TaaData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__38_2;

                static /*0x3b352f4*/ <>c();
                /*0x3b3535c*/ <>c();
                /*0x3b35364*/ void <Execute>b__38_0(UnityEngine.Rendering.STP.SetupData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x3b358d8*/ void <Execute>b__38_1(UnityEngine.Rendering.STP.PreTaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x3b35bb4*/ void <Execute>b__38_2(UnityEngine.Rendering.STP.TaaData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
            }
        }

        class BufferedRTHandleSystem : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RTHandle[]> m_RTHandles;
            /*0x18*/ UnityEngine.Rendering.RTHandleSystem m_RTHandleSystem;
            /*0x20*/ bool m_DisposedValue;

            /*0x3b37a90*/ BufferedRTHandleSystem();
            /*0x3b35f08*/ int get_maxWidth();
            /*0x3b35f20*/ int get_maxHeight();
            /*0x3b35f38*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x3b35f5c*/ UnityEngine.Rendering.RTHandle GetFrameRT(int bufferId, int frameIndex);
            /*0x3b3602c*/ void ClearBuffers(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b36390*/ void AllocBuffer(int bufferId, System.Func<UnityEngine.Rendering.RTHandleSystem, int, UnityEngine.Rendering.RTHandle> allocator, int bufferCount);
            /*0x3b3665c*/ void AllocBuffer(int bufferId, int bufferCount, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            /*0x3b36a1c*/ void ReleaseBuffer(int bufferId);
            /*0x3b36b24*/ void SwapAndSetReferenceSize(int width, int height);
            /*0x3b373d8*/ void ResetReferenceSize(int width, int height);
            /*0x3b37400*/ int GetNumFramesAllocated(int bufferId);
            /*0x3b374b0*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
            /*0x3b36b60*/ void Swap();
            /*0x3b376d4*/ void Dispose(bool disposing);
            /*0x3b37a88*/ void Dispose();
            /*0x3b37730*/ void ReleaseAll();
            /*0x3b368b4*/ UnityEngine.Rendering.RTHandle <AllocBuffer>g__Alloc|12_0(ref UnityEngine.RenderTextureDescriptor d, UnityEngine.FilterMode fMode, UnityEngine.TextureWrapMode wMode, bool isShadow, int aniso, float mipBias, string n, ref UnityEngine.Rendering.BufferedRTHandleSystem.<> );

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

            static /*0x3b381e0*/ UnityEngine.Vector4 GetPayloadScaleOffset(ref UnityEngine.Vector2 textureSize, ref UnityEngine.Vector2 paddingSize, ref UnityEngine.Vector4 scaleOffset);
            static /*0x3b39a9c*/ long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x3b39b64*/ int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x3b37ca0*/ PowerOfTwoTextureAtlas(int size, int mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, string name, bool useMipMap);
            /*0x3b38058*/ int get_mipPadding();
            /*0x3b38060*/ int GetTexturePadding();
            /*0x3b38090*/ UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset);
            /*0x3b38218*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType);
            /*0x3b386bc*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b38908*/ void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b38a0c*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b38b10*/ void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b38c14*/ void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, ref int width, ref int height);
            /*0x3b38154*/ UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture);
            /*0x3b38c60*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x3b39040*/ void ResetRequestedTexture();
            /*0x3b39090*/ bool ReserveSpace(UnityEngine.Texture texture);
            /*0x3b390e8*/ bool ReserveSpace(UnityEngine.Texture texture, int width, int height);
            /*0x3b39274*/ bool ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, int width, int height);
            /*0x3b39144*/ bool ReserveSpace(int id, int width, int height);
            /*0x3b393f4*/ bool RelayoutEntries();

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

                static /*0x3b39c40*/ <>c();
                /*0x3b39ca8*/ <>c();
                /*0x3b39cb0*/ int <RelayoutEntries>b__23_0(System.ValueTuple<int, UnityEngine.Vector2Int> c1, System.ValueTuple<int, UnityEngine.Vector2Int> c2);
            }
        }

        struct RTHandleStaticHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandle s_RTHandleWrapper;

            static /*0x3b34020*/ void SetRTHandleStaticWrapper(UnityEngine.Rendering.RenderTargetIdentifier rtId);
            static /*0x3b39dc4*/ void SetRTHandleUserManagedWrapper(ref UnityEngine.Rendering.RTHandle rtWrapper, UnityEngine.Rendering.RenderTargetIdentifier rtId);
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

            static /*0x3b38690*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x3b39f28*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x3b39fac*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            /*0x3b39ef0*/ RTHandle(UnityEngine.Rendering.RTHandleSystem owner);
            /*0x3b39e24*/ void SetCustomHandleProperties(ref UnityEngine.Rendering.RTHandleProperties properties);
            /*0x3b39e44*/ void ClearCustomHandleProperties();
            /*0x3b39e4c*/ UnityEngine.Vector2 get_scaleFactor();
            /*0x3b39e54*/ void set_scaleFactor(UnityEngine.Vector2 value);
            /*0x3b39e5c*/ bool get_useScaling();
            /*0x3b39e64*/ void set_useScaling(bool value);
            /*0x3b39e6c*/ UnityEngine.Vector2Int get_referenceSize();
            /*0x3b39e74*/ void set_referenceSize(UnityEngine.Vector2Int value);
            /*0x3b39e7c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x3b39eb8*/ UnityEngine.RenderTexture get_rt();
            /*0x3b39ec0*/ UnityEngine.Texture get_externalTexture();
            /*0x3b39ec8*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
            /*0x3b39ee0*/ string get_name();
            /*0x3b39ee8*/ bool get_isMSAAEnabled();
            /*0x3b39fb8*/ void SetRenderTexture(UnityEngine.RenderTexture rt, bool transferOwnership);
            /*0x3b3a02c*/ void SetTexture(UnityEngine.Texture tex);
            /*0x3b39d78*/ void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex);
            /*0x3b3a09c*/ int GetInstanceID();
            /*0x3b34b34*/ void Release();
            /*0x3b3a1b0*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int refSize);
            /*0x3b3a3a4*/ UnityEngine.Vector2Int GetScaledSize();
            /*0x3b3a598*/ void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, bool copyContents);
            /*0x3b3a620*/ void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags);
            /*0x3b3a628*/ void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, bool copyContents);
        }

        class RTHandles
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;

            static /*0x3b3d410*/ RTHandles();
            static /*0x3b3a684*/ int get_maxWidth();
            static /*0x3b3a6e8*/ int get_maxHeight();
            static /*0x3b3a74c*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            static /*0x3b3a7c0*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            static /*0x3b3a9f8*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            static /*0x3b3aaa4*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b349dc*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3ad68*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3b048*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x3b3b250*/ UnityEngine.Rendering.RTHandle Alloc(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x3b368a8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
            static /*0x3b3b4c8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3b784*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3b9d8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x3b3bc34*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x3b3bed8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3c16c*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x3b3c3c0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x3b3c610*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            static /*0x3b3c748*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex);
            static /*0x3b3c868*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex, bool transferOwnership);
            static /*0x3b39cf4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex);
            static /*0x3b3ca14*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, string name);
            static /*0x3b3cb90*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            static /*0x3b3cc00*/ void Initialize(int width, int height);
            static /*0x3b3cf80*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            static /*0x3b3d03c*/ void Release(UnityEngine.Rendering.RTHandle rth);
            static /*0x3b3d0b4*/ void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
            static /*0x3b3d28c*/ void SetReferenceSize(int width, int height);
            static /*0x3b3d308*/ void ResetReferenceSize(int width, int height);
            static /*0x3b3d388*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        }

        class ScaleFunc : System.MulticastDelegate
        {
            /*0x3b3d488*/ ScaleFunc(object object, nint method);
            /*0x3b3d528*/ UnityEngine.Vector2Int Invoke(UnityEngine.Vector2Int size);
            /*0x3b3d53c*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2Int size, System.AsyncCallback callback, object object);
            /*0x3b3d5c0*/ UnityEngine.Vector2Int EndInvoke(System.IAsyncResult result);
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

            /*0x3b3d708*/ RTHandleAllocInfo(string name);
            /*0x3b3d5e8*/ int get_slices();
            /*0x3b3d5f0*/ void set_slices(int value);
            /*0x3b3d5f8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_format();
            /*0x3b3d600*/ void set_format(UnityEngine.Experimental.Rendering.GraphicsFormat value);
            /*0x3b3d608*/ UnityEngine.FilterMode get_filterMode();
            /*0x3b3d610*/ void set_filterMode(UnityEngine.FilterMode value);
            /*0x3b3d618*/ UnityEngine.TextureWrapMode get_wrapModeU();
            /*0x3b3d620*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
            /*0x3b3d628*/ UnityEngine.TextureWrapMode get_wrapModeV();
            /*0x3b3d630*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
            /*0x3b3d638*/ UnityEngine.TextureWrapMode get_wrapModeW();
            /*0x3b3d640*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
            /*0x3b3d648*/ UnityEngine.Rendering.TextureDimension get_dimension();
            /*0x3b3d650*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
            /*0x3b3d658*/ bool get_enableRandomWrite();
            /*0x3b3d660*/ void set_enableRandomWrite(bool value);
            /*0x3b3d668*/ bool get_useMipMap();
            /*0x3b3d670*/ void set_useMipMap(bool value);
            /*0x3b3d678*/ bool get_autoGenerateMips();
            /*0x3b3d680*/ void set_autoGenerateMips(bool value);
            /*0x3b3d688*/ int get_anisoLevel();
            /*0x3b3d690*/ void set_anisoLevel(int value);
            /*0x3b3d698*/ float get_mipMapBias();
            /*0x3b3d6a0*/ void set_mipMapBias(float value);
            /*0x3b3d6a8*/ UnityEngine.Rendering.MSAASamples get_msaaSamples();
            /*0x3b3d6b0*/ void set_msaaSamples(UnityEngine.Rendering.MSAASamples value);
            /*0x3b3d6b8*/ bool get_bindTextureMS();
            /*0x3b3d6c0*/ void set_bindTextureMS(bool value);
            /*0x3b3d6c8*/ bool get_useDynamicScale();
            /*0x3b3d6d0*/ void set_useDynamicScale(bool value);
            /*0x3b3d6d8*/ UnityEngine.RenderTextureMemoryless get_memoryless();
            /*0x3b3d6e0*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
            /*0x3b3d6e8*/ UnityEngine.VRTextureUsage get_vrUsage();
            /*0x3b3d6f0*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
            /*0x3b3d6f8*/ string get_name();
            /*0x3b3d700*/ void set_name(string value);
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

            static /*0x3b3eb94*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            /*0x3b37b4c*/ RTHandleSystem();
            /*0x3b3d744*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x3b37a80*/ void Dispose();
            /*0x3b3cc78*/ void Initialize(int width, int height);
            /*0x3b3d010*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            /*0x3b36b14*/ void Release(UnityEngine.Rendering.RTHandle rth);
            /*0x3b3a158*/ void Remove(UnityEngine.Rendering.RTHandle rth);
            /*0x3b373f4*/ void ResetReferenceSize(int width, int height);
            /*0x3b373d0*/ void SetReferenceSize(int width, int height);
            /*0x3b3d910*/ void SetReferenceSize(int width, int height, bool reset);
            /*0x3b374d8*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(ref UnityEngine.Vector2Int viewportSize);
            /*0x3b3d11c*/ void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
            /*0x3b36548*/ void SwitchResizeMode(UnityEngine.Rendering.RTHandle rth, UnityEngine.Rendering.RTHandleSystem.ResizeMode mode);
            /*0x3b3ddac*/ void DemandResize(UnityEngine.Rendering.RTHandle rth);
            /*0x3b3e038*/ int GetMaxWidth();
            /*0x3b3e040*/ int GetMaxHeight();
            /*0x3b3d758*/ void Dispose(bool disposing);
            /*0x3b3da98*/ void Resize(int width, int height, bool sizeChanged);
            /*0x3b3abfc*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b37c04*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3aed0*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3e048*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3e258*/ UnityEngine.RenderTexture CreateRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3b0e4*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x3b3a838*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Vector2 scaleFactor);
            /*0x3b3b8d4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3b624*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3bcd0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x3b3aa60*/ UnityEngine.Vector2Int CalculateDimensions(UnityEngine.Rendering.ScaleFunc scaleFunc);
            /*0x3b3c028*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3c2b0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Experimental.Rendering.GraphicsFormat format, int slices, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3c6a4*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x3b3e7f4*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x3b3ea08*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, UnityEngine.Rendering.RTHandleAllocInfo info);
            /*0x3b3c8e0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture, bool transferOwnership);
            /*0x3b3c7b0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture);
            /*0x3b3c9a0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture);
            /*0x3b3caa8*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, string name);
            /*0x3b3ec04*/ string DumpRTInfo();
            /*0x3b3e770*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);

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

            /*0x3b3ef28*/ AtlasAllocator(int width, int height, bool potPadding);
            /*0x3b3f16c*/ bool Allocate(ref UnityEngine.Vector4 result, int width, int height);
            /*0x3b3f410*/ void Reset();

            class AtlasNode
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;
                /*0x18*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x3b3f160*/ AtlasNode();
                /*0x3b3f1f0*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding);
                /*0x3b3f44c*/ void Release(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.AtlasAllocator.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_1;

                static /*0x3b3f540*/ <>c();
                /*0x3b3f5a8*/ <>c();
                /*0x3b3f5b0*/ void <.ctor>b__6_0(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
                /*0x3b3f5b4*/ void <.ctor>b__6_1(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
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

            static /*0x3b40f58*/ Texture2DAtlas();
            static /*0x3b3f5b8*/ int get_maxMipLevelPadding();
            /*0x3b37da4*/ Texture2DAtlas(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, bool powerOfTwoPadding, string name, bool useMipMap);
            /*0x3b3f610*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x3b3f618*/ void Release();
            /*0x3b39a1c*/ void ResetAllocator();
            /*0x3b3f68c*/ void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x3b38604*/ int GetTextureMipmapCount(int width, int height);
            /*0x3b387c0*/ bool Is2D(UnityEngine.Texture texture);
            /*0x3b3f848*/ bool IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination);
            /*0x3b3fa90*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType);
            /*0x3b3888c*/ void MarkGPUTextureValid(int instanceId, bool mipAreValid);
            /*0x3b3fd24*/ void MarkGPUTextureInvalid(int instanceId);
            /*0x3b3fd90*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b3ff10*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x3b3ff1c*/ void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, bool blitMips, int overrideInstanceID);
            /*0x3b38e68*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x3b40088*/ bool AllocateTextureWithoutBlit(UnityEngine.Texture texture, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x3b400e4*/ bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x3b40280*/ int GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x3b3912c*/ int GetTextureID(UnityEngine.Texture texture);
            /*0x3b392a8*/ int GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x3b40300*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x3b40334*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x3b39368*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int id);
            /*0x3b392f0*/ UnityEngine.Vector2Int GetCachedTextureSize(int id);
            /*0x3b40370*/ bool NeedsUpdate(UnityEngine.Texture texture, bool needMips);
            /*0x3b405fc*/ bool NeedsUpdate(int id, int updateCount, bool needMips);
            /*0x3b406e8*/ bool NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, bool needMips);
            /*0x3b40b0c*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x3b40bac*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Vector4 sourceScaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x3b40d28*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x3b40ddc*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleBias, int key, int width, int height);

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

            static /*0x3b4221c*/ TextureXR();
            static /*0x3b40fb8*/ void set_maxViews(int value);
            static /*0x3b41014*/ int get_slices();
            static /*0x3b4106c*/ bool get_useTexArray();
            static /*0x3b410d4*/ UnityEngine.Rendering.TextureDimension get_dimension();
            static /*0x3b41134*/ UnityEngine.Rendering.RTHandle GetBlackUIntTexture();
            static /*0x3b411c4*/ UnityEngine.Rendering.RTHandle GetClearTexture();
            static /*0x3b41254*/ UnityEngine.Rendering.RTHandle GetMagentaTexture();
            static /*0x3b412e4*/ UnityEngine.Rendering.RTHandle GetBlackTexture();
            static /*0x3b41374*/ UnityEngine.Rendering.RTHandle GetBlackTextureArray();
            static /*0x3b413cc*/ UnityEngine.Rendering.RTHandle GetBlackTexture3D();
            static /*0x3b41424*/ UnityEngine.Rendering.RTHandle GetWhiteTexture();
            static /*0x3b414b4*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x3b41f7c*/ UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, string name);
            static /*0x3b41b8c*/ UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x3b41dd0*/ UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x3b4215c*/ UnityEngine.Texture3D CreateBlackTexture3D(string name);
        }

        class ArrayExtensions
        {
            static /*0x1f36244*/ void ResizeArray<T>(ref Unity.Collections.NativeArray<T> array, int capacity);
            static /*0x3b42268*/ void ResizeArray(ref UnityEngine.Jobs.TransformAccessArray array, int capacity);
            static /*0x1f36244*/ void ResizeArray<T>(ref T[] array, int capacity);
            static /*0x1f37108*/ void FillArray<T>(ref Unity.Collections.NativeArray<T> array, ref T value, int startIndex, int length);
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

            static /*0x3b42460*/ UnityEngine.Vector4 GetSHA(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x3b42508*/ UnityEngine.Vector4 GetSHB(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x3b4259c*/ UnityEngine.Vector4 GetSHC(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            static /*0x3b429d8*/ bool op_Equality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            static /*0x3b42a0c*/ bool op_Inequality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            /*0x3b42308*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            /*0x3b42604*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector4 probesOcclusion);
            /*0x3b4265c*/ bool Equals(UnityEngine.Rendering.SHCoefficients other);
            /*0x3b42868*/ bool Equals(object obj);
            /*0x3b428f8*/ int GetHashCode();
        }

        struct BatchRendererGroupGlobals : System.IEquatable<UnityEngine.Rendering.BatchRendererGroupGlobals>
        {
            static string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
            static /*0x0*/ int kGlobalsPropertyId;
            /*0x10*/ UnityEngine.Vector4 ProbesOcclusion;
            /*0x20*/ UnityEngine.Vector4 SpecCube0_HDR;
            /*0x30*/ UnityEngine.Vector4 SpecCube1_HDR;
            /*0x40*/ UnityEngine.Rendering.SHCoefficients SHCoefficients;

            static /*0x3b42f04*/ BatchRendererGroupGlobals();
            static /*0x3b42a44*/ UnityEngine.Rendering.BatchRendererGroupGlobals get_Default();
            static /*0x3b42df8*/ bool op_Equality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            static /*0x3b42e7c*/ bool op_Inequality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            /*0x3b42b6c*/ bool Equals(UnityEngine.Rendering.BatchRendererGroupGlobals other);
            /*0x3b42c8c*/ bool Equals(object obj);
            /*0x3b42d2c*/ int GetHashCode();
        }

        interface IBitArray
        {
            uint get_capacity();
            /*0x1f2fe14*/ bool get_allFalse();
            /*0x1f2fe14*/ bool get_allTrue();
            /*0x1f2ff88*/ bool get_Item(uint index);
            /*0x1ffc854*/ void set_Item(uint index, bool value);
            /*0x1f30214*/ string get_humanizedData();
            /*0x1f302cc*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1f302cc*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1f30214*/ UnityEngine.Rendering.IBitArray BitNot();
        }

        struct BitArray8 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ byte data;

            static /*0x3b431c4*/ UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a);
            static /*0x3b431cc*/ UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x3b431d4*/ UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x3b43374*/ bool op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x3b43384*/ bool op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            /*0x3b430f4*/ BitArray8(byte initValue);
            /*0x3b430fc*/ BitArray8(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b42f6c*/ uint get_capacity();
            /*0x3b42f74*/ bool get_allFalse();
            /*0x3b42f84*/ bool get_allTrue();
            /*0x3b42f94*/ string get_humanizedData();
            /*0x3b4308c*/ bool get_Item(uint index);
            /*0x3b430ac*/ void set_Item(uint index, bool value);
            /*0x3b431dc*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b43278*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b43314*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b43394*/ bool Equals(object obj);
            /*0x3b4340c*/ int GetHashCode();
        }

        struct BitArray16 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ushort data;

            static /*0x3b436fc*/ UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a);
            static /*0x3b43704*/ UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x3b4370c*/ UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x3b438ac*/ bool op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x3b438bc*/ bool op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            /*0x3b4362c*/ BitArray16(ushort initValue);
            /*0x3b43634*/ BitArray16(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b4342c*/ uint get_capacity();
            /*0x3b43434*/ bool get_allFalse();
            /*0x3b43444*/ bool get_allTrue();
            /*0x3b43454*/ string get_humanizedData();
            /*0x3b435c4*/ bool get_Item(uint index);
            /*0x3b435e4*/ void set_Item(uint index, bool value);
            /*0x3b43714*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b437b0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b4384c*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b438cc*/ bool Equals(object obj);
            /*0x3b43944*/ int GetHashCode();
        }

        struct BitArray32 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ uint data;

            static /*0x3b43e38*/ UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a);
            static /*0x3b43dd0*/ UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x3b43d2c*/ UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x3b43e40*/ bool op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x3b43e4c*/ bool op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            /*0x3b43bc0*/ BitArray32(uint initValue);
            /*0x3b43bc8*/ BitArray32(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b43964*/ uint get_capacity();
            /*0x3b4396c*/ bool get_allFalse();
            /*0x3b4397c*/ bool get_allTrue();
            /*0x3b4398c*/ string get_humanizedVersion();
            /*0x3b439ec*/ string get_humanizedData();
            /*0x3b43b5c*/ bool get_Item(uint index);
            /*0x3b43b78*/ void set_Item(uint index, bool value);
            /*0x3b43c90*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b43d34*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b43dd8*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b43e58*/ bool Equals(object obj);
            /*0x3b43ed0*/ int GetHashCode();
        }

        struct BitArray64 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data;

            static /*0x3b441bc*/ UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a);
            static /*0x3b441c4*/ UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x3b441cc*/ UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x3b4436c*/ bool op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x3b44378*/ bool op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            /*0x3b440ec*/ BitArray64(ulong initValue);
            /*0x3b440f4*/ BitArray64(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b43ef0*/ uint get_capacity();
            /*0x3b43ef8*/ bool get_allFalse();
            /*0x3b43f08*/ bool get_allTrue();
            /*0x3b43f18*/ string get_humanizedData();
            /*0x3b44088*/ bool get_Item(uint index);
            /*0x3b440a4*/ void set_Item(uint index, bool value);
            /*0x3b441d4*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b44270*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b4430c*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b44384*/ bool Equals(object obj);
            /*0x3b443fc*/ int GetHashCode();
        }

        struct BitArray128 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;

            static /*0x3b447b4*/ UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a);
            static /*0x3b447c0*/ UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x3b447cc*/ UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x3b44978*/ bool op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x3b44988*/ bool op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            /*0x3b446c8*/ BitArray128(ulong initValue1, ulong initValue2);
            /*0x3b446d0*/ BitArray128(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b4441c*/ uint get_capacity();
            /*0x3b44424*/ bool get_allFalse();
            /*0x3b44444*/ bool get_allTrue();
            /*0x3b44468*/ string get_humanizedData();
            /*0x3b44664*/ bool get_Item(uint index);
            /*0x3b4467c*/ void set_Item(uint index, bool value);
            /*0x3b447d8*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b44878*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b44918*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b44998*/ bool Equals(object obj);
            /*0x3b44a28*/ int GetHashCode();
        }

        struct BitArray256 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;
            /*0x20*/ ulong data3;
            /*0x28*/ ulong data4;

            static /*0x3b45058*/ UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a);
            static /*0x3b4506c*/ UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x3b45084*/ UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x3b45250*/ bool op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x3b4529c*/ bool op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            /*0x3b44f2c*/ BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4);
            /*0x3b44f38*/ BitArray256(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3b44a70*/ uint get_capacity();
            /*0x3b44a78*/ bool get_allFalse();
            /*0x3b44aa8*/ bool get_allTrue();
            /*0x3b44ae4*/ string get_humanizedData();
            /*0x3b44de4*/ bool get_Item(uint index);
            /*0x3b44e64*/ void set_Item(uint index, bool value);
            /*0x3b4509c*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x3b45144*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x3b451ec*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x3b452e8*/ bool Equals(object obj);
            /*0x3b453b0*/ int GetHashCode();
        }

        class BitArrayUtilities
        {
            static /*0x3b4309c*/ bool Get8(uint index, byte data);
            static /*0x3b435d4*/ bool Get16(uint index, ushort data);
            static /*0x3b43b6c*/ bool Get32(uint index, uint data);
            static /*0x3b44098*/ bool Get64(uint index, ulong data);
            static /*0x3b4542c*/ bool Get128(uint index, ulong data1, ulong data2);
            static /*0x3b44e28*/ bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4);
            static /*0x3b430d0*/ void Set8(uint index, ref byte data, bool value);
            static /*0x3b43608*/ void Set16(uint index, ref ushort data, bool value);
            static /*0x3b43b9c*/ void Set32(uint index, ref uint data, bool value);
            static /*0x3b440c8*/ void Set64(uint index, ref ulong data, bool value);
            static /*0x3b45440*/ void Set128(uint index, ref ulong data1, ref ulong data2, bool value);
            static /*0x3b44e84*/ void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value);
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

            static /*0x3b49dfc*/ Blitter();
            static /*0x3b4547c*/ void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS);
            static /*0x3b46050*/ void Cleanup();
            static /*0x3b46250*/ UnityEngine.Material GetBlitMaterial(UnityEngine.Rendering.TextureDimension dimension, bool singleSlice);
            static /*0x3b46340*/ void DrawTriangle(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x3b463b8*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x3b46430*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x3b4659c*/ void DrawQuadMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x3b46688*/ void DrawQuad(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x3b46874*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x3b46708*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock propertyBlock);
            static /*0x3b468ec*/ bool CanCopyMSAA();
            static /*0x3b4696c*/ bool CanCopyMSAA(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc sourceDesc);
            static /*0x3b46a1c*/ void CopyTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, bool isMSAA, bool force2DForXR);
            static /*0x3b46b0c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear);
            static /*0x3b46c20*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass, float sourceMipLevel, int sourceDepthSlice);
            static /*0x3b46e9c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x3b46f54*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x3b470d8*/ void BlitTexture2D(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x3b47190*/ void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x3b472ec*/ void BlitColorAndDepth(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x3b473ac*/ void BlitColorAndDepth(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x3b475ac*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b46d64*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b4765c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b47728*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b47874*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int pass);
            static /*0x3b479fc*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x3b47b9c*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b47c8c*/ void BlitTexture(UnityEngine.Rendering.RasterCommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x3b47d7c*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x3b47f7c*/ void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x3b480d8*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int pass);
            static /*0x3b4822c*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x3b484c0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x3b485b8*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, float mipLevel, bool bilinear);
            static /*0x3b48754*/ void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear);
            static /*0x3b48954*/ void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x3b48c10*/ void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x3b48ecc*/ void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x3b49104*/ void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x3b4933c*/ void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x3b494f4*/ void BlitCubeToOctahedral2DQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, System.Nullable<UnityEngine.Vector4> decodeInstructions);
            static /*0x3b498b4*/ void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x3b49b48*/ void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x3b45d70*/ UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|14_0(float z);
            static /*0x3b45e20*/ UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|14_1();
            static /*0x3b45ef4*/ UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|14_2(float z);
            static /*0x3b45f98*/ UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|14_3();

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

                static /*0x3b49e70*/ BlitShaderIDs();
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

            static /*0x3b4a748*/ CameraCaptureBridge();
            static /*0x3b4a0a8*/ bool get_enabled();
            static /*0x3b4a100*/ void set_enabled(bool value);
            static /*0x3b4a160*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera);
            static /*0x3b4a274*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCachedCaptureActionsEnumerator(UnityEngine.Camera camera);
            static /*0x3b4a3bc*/ void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
            static /*0x3b4a5cc*/ void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);

            class CameraEntry
            {
                /*0x10*/ System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> actions;
                /*0x18*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> cachedEnumerator;

                /*0x3b4a5c4*/ CameraEntry();
            }
        }

        class ColorSpaceUtils
        {
            static /*0x0*/ Unity.Mathematics.float3x3 Rec709ToRec2020Mat;
            static /*0x24*/ Unity.Mathematics.float3x3 Rec709ToP3D65Mat;
            static /*0x48*/ Unity.Mathematics.float3x3 Rec2020ToRec709Mat;
            static /*0x6c*/ Unity.Mathematics.float3x3 Rec2020ToP3D65Mat;
            static /*0x90*/ Unity.Mathematics.float3x3 P3D65ToRec2020Mat;

            static /*0x3b4a7e0*/ ColorSpaceUtils();
        }

        class ColorUtils
        {
            static /*0x0*/ float s_LightMeterCalibrationConstant;
            static /*0x4*/ float s_LensAttenuation;

            static /*0x3b4b46c*/ ColorUtils();
            static /*0x3b4a8e4*/ float get_lensImperfectionExposureScale();
            static /*0x3b4a954*/ float StandardIlluminantY(float x);
            static /*0x3b4a980*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
            static /*0x3b4aa10*/ UnityEngine.Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
            static /*0x3b4ab6c*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inMidtones, ref UnityEngine.Vector4 inHighlights);
            static /*0x3b4ad5c*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareLiftGammaGain(ref UnityEngine.Vector4 inLift, ref UnityEngine.Vector4 inGamma, ref UnityEngine.Vector4 inGain);
            static /*0x3b4b04c*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4> PrepareSplitToning(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inHighlights, float balance);
            static /*0x3b4b01c*/ float Luminance(ref UnityEngine.Color color);
            static /*0x3b4b0fc*/ float ComputeEV100(float aperture, float shutterSpeed, float ISO);
            static /*0x3b4b188*/ float ConvertEV100ToExposure(float EV100);
            static /*0x3b4b1fc*/ float ConvertExposureToEV100(float exposure);
            static /*0x3b4b2b4*/ float ComputeEV100FromAvgLuminance(float avgLuminance);
            static /*0x3b4b374*/ float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
            static /*0x3b4b3b0*/ uint ToHex(UnityEngine.Color c);
            static /*0x3b4b420*/ UnityEngine.Color ToRGBA(uint hex);
        }

        class CoreMatrixUtils
        {
            static /*0x3b4b4bc*/ void MatrixTimesTranslation(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x3b4b518*/ void TranslationTimesMatrix(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x3b4b5a0*/ UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs);
            static /*0x3b4b648*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x3b4b6e0*/ UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x3b4b79c*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, bool centered);
            static /*0x3b4b890*/ UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, bool orthoCentered);
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

            static /*0x3b4fe8c*/ CoreUtils();
            static /*0x3b4b94c*/ UnityEngine.Cubemap get_blackCubeTexture();
            static /*0x3b4bad4*/ UnityEngine.Cubemap get_magentaCubeTexture();
            static /*0x3b4bc5c*/ UnityEngine.CubemapArray get_magentaCubeTextureArray();
            static /*0x3b4be30*/ UnityEngine.Cubemap get_whiteCubeTexture();
            static /*0x3b4bfb8*/ UnityEngine.RenderTexture get_emptyUAV();
            static /*0x3b4c0f8*/ UnityEngine.GraphicsBuffer get_emptyBuffer();
            static /*0x3b4c1f8*/ UnityEngine.Texture3D get_blackVolumeTexture();
            static /*0x3b4c384*/ UnityEngine.Texture3D get_whiteVolumeTexture();
            static /*0x3b4c50c*/ void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4c530*/ int FixupDepthSlice(int depthSlice, UnityEngine.Rendering.RTHandle buffer);
            static /*0x3b4c574*/ int FixupDepthSlice(int depthSlice, UnityEngine.CubemapFace cubemapFace);
            static /*0x3b4c588*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4c688*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4c748*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4c934*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4c81c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4ca0c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer);
            static /*0x3b4cb8c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x3b4caa8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4cc34*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4cd1c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4ce0c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4cf30*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x3b4cfe0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4d0f8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4d248*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4d3c4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4d4c4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x3b4d5ac*/ void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4d6c8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b47ed8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4d7d4*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4d9a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4d87c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b483a8*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4da4c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3b4dbac*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer);
            static /*0x3b4dc5c*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x3b4dd10*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x3b4d650*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target);
            static /*0x3b4de00*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.RenderTextureFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x3b4e174*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x3b4e270*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x3b4defc*/ string GetRenderTargetAutoName(int width, int height, int depth, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit);
            static /*0x3b4e380*/ string GetTextureAutoName(int width, int height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x3b4e878*/ string GetTextureAutoName(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x3b4e468*/ string GetTextureAutoName(int width, int height, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x3b4e960*/ void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips);
            static /*0x3b4eb14*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4ebb8*/ void DrawFullScreen(UnityEngine.Rendering.RasterCommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4ec38*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4ed04*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4ede4*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4eeb8*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x3b4ef70*/ UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color);
            static /*0x3b4efec*/ UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color);
            static /*0x3b4f068*/ UnityEngine.Material CreateEngineMaterial(string shaderPath);
            static /*0x3b45c78*/ UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader);
            static /*0x1ffc854*/ bool HasFlag<T>(T mask, T flag);
            static /*0x1f36f18*/ void Swap<T>(ref T a, ref T b);
            static /*0x3b4f1e4*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, string keyword, bool state);
            static /*0x3b4f210*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x3b4f288*/ void SetKeyword(UnityEngine.Rendering.BaseCommandBuffer cmd, string keyword, bool state);
            static /*0x3b4f2c4*/ void SetKeyword(UnityEngine.Material material, string keyword, bool state);
            static /*0x3b4f2f0*/ void SetKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool state);
            static /*0x3b4f31c*/ void SetKeyword(UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x3b461c8*/ void Destroy(UnityEngine.Object obj);
            static /*0x3b4f348*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
            static /*0x1f327a0*/ System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
            static /*0x3b4f4e0*/ void SafeRelease(UnityEngine.GraphicsBuffer buffer);
            static /*0x3b4f4f0*/ void SafeRelease(UnityEngine.ComputeBuffer buffer);
            static /*0x3b4f500*/ UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x3b4f8a4*/ bool ArePostProcessesEnabled(UnityEngine.Camera camera);
            static /*0x3b4f8ac*/ bool AreAnimatedMaterialsEnabled(UnityEngine.Camera camera);
            static /*0x3b4f8b4*/ bool IsSceneLightingDisabled(UnityEngine.Camera camera);
            static /*0x3b4f8bc*/ bool IsLightOverlapDebugEnabled(UnityEngine.Camera camera);
            static /*0x3b4f8c4*/ bool IsSceneViewFogEnabled(UnityEngine.Camera camera);
            static /*0x3b4f8cc*/ bool IsSceneFilteringEnabled();
            static /*0x3b4f8d4*/ bool IsSceneViewPrefabStageContextHidden();
            static /*0x3b4f8dc*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
            static /*0x3b4f918*/ int GetTextureHash(UnityEngine.Texture texture);
            static /*0x3b4fa88*/ int PreviousPowerOfTwo(int size);
            static /*0x3b4fab4*/ int GetMipCount(int size);
            static /*0x3b4fb74*/ int GetMipCount(float size);
            static /*0x3b4fc30*/ int DivRoundUp(int value, int divisor);
            static /*0x1ffc854*/ T GetLastEnumValue<T>();
            static /*0x3b4fc40*/ string GetCorePath();
            static /*0x3b4fc80*/ UnityEngine.Vector3[] CalculateViewSpaceCorners(UnityEngine.Matrix4x4 proj, float z);
            static /*0x3b4fe24*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat();
            static /*0x3b4fe2c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthOnlyFormat();
            static /*0x3b4fe84*/ UnityEngine.Rendering.DepthBits GetDefaultDepthBufferBits();

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

                static /*0x3b50028*/ <>c();
                /*0x3b50090*/ <>c();
                /*0x3b50098*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__97_0(System.Reflection.Assembly t);
            }

            class <>c__98<T>
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<>c__98<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__98_0;

                static /*0x1f33998*/ <>c__98();
                /*0x1f309e4*/ <>c__98();
                /*0x1f2fec8*/ bool <GetAllTypesDerivedFrom>b__98_0(System.Type t);
            }
        }

        class DelegateUtility
        {
            static /*0x3b5017c*/ System.Delegate Cast(System.Delegate source, System.Type type);
        }

        class FSRUtils
        {
            static float kMaxSharpnessStops = 2.5;
            static float kDefaultSharpnessStops = 0.20000000298023224;
            static float kDefaultSharpnessLinear = 0.9200000166893005;

            static /*0x3b50304*/ void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x3b50484*/ void SetEasuConstants(UnityEngine.Rendering.BaseCommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x3b50498*/ void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessStops);
            static /*0x3b50540*/ void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessLinear);
            static /*0x3b50554*/ void SetRcasConstantsLinear(UnityEngine.Rendering.RasterCommandBuffer cmd, float sharpnessLinear);
            static /*0x3b50578*/ bool IsSupported();

            class ShaderConstants
            {
                static /*0x0*/ int _FsrEasuConstants0;
                static /*0x4*/ int _FsrEasuConstants1;
                static /*0x8*/ int _FsrEasuConstants2;
                static /*0xc*/ int _FsrEasuConstants3;
                static /*0x10*/ int _FsrRcasConstants;

                static /*0x3b50594*/ ShaderConstants();
            }
        }

        struct GPUPrefixSum
        {
            /*0x10*/ UnityEngine.Rendering.GPUPrefixSum.SystemResources resources;

            /*0x3b506cc*/ GPUPrefixSum(UnityEngine.Rendering.GPUPrefixSum.SystemResources resources);
            /*0x3b508b0*/ UnityEngine.Vector4 PackPrefixSumArgs(int a, int b, int c, int d);
            /*0x3b508c4*/ void ExecuteCommonIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.GraphicsBuffer inputBuffer, ref UnityEngine.Rendering.GPUPrefixSum.SupportResources supportResources, bool isExclusive);
            /*0x3b50c64*/ void DispatchDirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.DirectArgs arguments);
            /*0x3b50e60*/ void DispatchIndirect(UnityEngine.Rendering.CommandBuffer cmdBuffer, ref UnityEngine.Rendering.GPUPrefixSum.IndirectDirectArgs arguments);

            class ShaderDefs
            {
                static int GroupSize = 128;
                static int ArgsBufferStride = 16;
                static int ArgsBufferUpper = 0;
                static int ArgsBufferLower = 8;

                static /*0x3b51054*/ int DivUpGroup(int value);
                static /*0x3b5106c*/ int AlignUpGroup(int value);
                static /*0x3b51084*/ void CalculateTotalBufferSize(int maxElementCount, ref int totalSize, ref int levelCounts);
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

                static /*0x3b510ec*/ UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources Create(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
                /*0x3b510dc*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_output();
                /*0x3b51148*/ void Initialize(int newMaxElementCount, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder, bool outputIsTemp);
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

                static /*0x3b51490*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Create(int maxElementCount);
                static /*0x3b5177c*/ UnityEngine.Rendering.GPUPrefixSum.SupportResources Load(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                static /*0x3b51968*/ void <Dispose>g__TryFreeBuffer|15_0(UnityEngine.GraphicsBuffer resource);
                /*0x3b51488*/ UnityEngine.GraphicsBuffer get_output();
                /*0x3b514f8*/ void Resize(int newMaxElementCount);
                /*0x3b517d8*/ void LoadFromShaderGraph(UnityEngine.Rendering.GPUPrefixSum.RenderGraphResources shaderGraphResources);
                /*0x3b518f0*/ void Dispose();
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

                /*0x3b506f8*/ void LoadKernels();
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

                static /*0x3b51978*/ ShaderIDs();
            }
        }

        struct GPUSort
        {
            static uint kWorkGroupSize = 1024;
            /*0x10*/ UnityEngine.Rendering.LocalKeyword[] m_Keywords;
            /*0x18*/ UnityEngine.Rendering.GPUSort.SystemResources resources;

            static /*0x3b521d8*/ int DivRoundUp(int x, int y);
            /*0x3b51b80*/ GPUSort(UnityEngine.Rendering.GPUSort.SystemResources resources);
            /*0x3b51d6c*/ void DispatchStage(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args, uint h, UnityEngine.Rendering.GPUSort.Stage stage);
            /*0x3b52020*/ void CopyBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst);
            /*0x3b521e8*/ void Dispatch(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.GPUSort.Args args);

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

                static /*0x3b523d0*/ UnityEngine.Rendering.GPUSort.RenderGraphResources Create(int count, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder builder);
            }

            struct SupportResources
            {
                /*0x10*/ UnityEngine.GraphicsBuffer sortBufferKeys;
                /*0x18*/ UnityEngine.GraphicsBuffer sortBufferValues;

                static /*0x3b524e4*/ UnityEngine.Rendering.GPUSort.SupportResources Load(UnityEngine.Rendering.GPUSort.RenderGraphResources renderGraphResources);
                /*0x3b52590*/ void Dispose();
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

            /*0x3b52624*/ HableCurve();
            /*0x3b525e4*/ float get_whitePoint();
            /*0x3b525ec*/ void set_whitePoint(float value);
            /*0x3b525f4*/ float get_inverseWhitePoint();
            /*0x3b525fc*/ void set_inverseWhitePoint(float value);
            /*0x3b52604*/ float get_x0();
            /*0x3b5260c*/ void set_x0(float value);
            /*0x3b52614*/ float get_x1();
            /*0x3b5261c*/ void set_x1(float value);
            /*0x3b527b4*/ float Eval(float x);
            /*0x3b528c4*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
            /*0x3b52a00*/ void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams);
            /*0x3b52d24*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
            /*0x3b52cbc*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
            /*0x3b52ce8*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

            class Segment
            {
                /*0x10*/ float offsetX;
                /*0x14*/ float offsetY;
                /*0x18*/ float scaleX;
                /*0x1c*/ float scaleY;
                /*0x20*/ float lnA;
                /*0x24*/ float B;

                /*0x3b5277c*/ Segment();
                /*0x3b52864*/ float Eval(float x);
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

                /*0x3b52784*/ Uniforms(UnityEngine.Rendering.HableCurve parent);
                /*0x3b52d74*/ UnityEngine.Vector4 get_curve();
                /*0x3b52d94*/ UnityEngine.Vector4 get_toeSegmentA();
                /*0x3b52dd0*/ UnityEngine.Vector4 get_toeSegmentB();
                /*0x3b52e10*/ UnityEngine.Vector4 get_midSegmentA();
                /*0x3b52e50*/ UnityEngine.Vector4 get_midSegmentB();
                /*0x3b52e94*/ UnityEngine.Vector4 get_shoSegmentA();
                /*0x3b52ed4*/ UnityEngine.Vector4 get_shoSegmentB();
            }
        }

        class HaltonSequence
        {
            static /*0x3b52f18*/ float Get(int index, int radix);
        }

        struct HashFNV1A32
        {
            static uint k_Prime = 16777619;
            static uint k_OffsetBasis = 2166136261;
            /*0x10*/ uint m_Hash;

            static /*0x3b52f5c*/ UnityEngine.Rendering.HashFNV1A32 Create();
            static /*0x3b53244*/ int GetFuncHashCode(System.Delegate del);
            /*0x3b52f68*/ void Append(ref int input);
            /*0x3b52f88*/ void Append(ref uint input);
            /*0x3b52fa8*/ void Append(ref bool input);
            /*0x3b52fd0*/ void Append(ref float input);
            /*0x3b53014*/ void Append(ref double input);
            /*0x3b5304c*/ void Append(ref UnityEngine.Vector2 input);
            /*0x3b530b0*/ void Append(ref UnityEngine.Vector3 input);
            /*0x3b53138*/ void Append(ref UnityEngine.Vector4 input);
            /*0x1ffc854*/ void Append<T>(T input);
            /*0x3b531d4*/ void Append(System.Delegate del);
            /*0x3b5328c*/ int get_value();
            /*0x3b53294*/ int GetHashCode();
        }

        class HDROutputUtils
        {
            static /*0x3b5329c*/ bool GetColorSpaceForGamut(UnityEngine.ColorGamut gamut, ref int colorspace);
            static /*0x3b534b0*/ bool GetColorEncodingForGamut(UnityEngine.ColorGamut gamut, ref int encoding);
            static /*0x3b53634*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x3b53888*/ void ConfigureHDROutput(UnityEngine.MaterialPropertyBlock properties, UnityEngine.ColorGamut gamut);
            static /*0x3b53954*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x3b53b1c*/ void ConfigureHDROutput(UnityEngine.ComputeShader computeShader, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x3b53d70*/ bool IsShaderVariantValid(UnityEngine.Rendering.ShaderKeywordSet shaderKeywordSet, bool isHDREnabled);

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

                /*0x3b53e7c*/ HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits);
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

                static /*0x3b53e8c*/ ShaderKeywords();
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int hdrColorSpace;
                static /*0x4*/ int hdrEncoding;

                static /*0x3b54000*/ ShaderPropertyId();
            }
        }

        class LightUnitUtils
        {
            static float SphereSolidAngle = 12.566370964050293;

            static /*0x3b540a0*/ float get_k_LuminanceToEvFactor();
            static /*0x3b54158*/ float get_k_EvToLuminanceFactor();
            static /*0x3b5416c*/ UnityEngine.Rendering.LightUnit GetNativeLightUnit(UnityEngine.LightType lightType);
            static /*0x3b541bc*/ bool IsLightUnitSupported(UnityEngine.LightType lightType, UnityEngine.Rendering.LightUnit lightUnit);
            static /*0x3b54218*/ float GetSolidAngleFromPointLight();
            static /*0x3b54224*/ float GetSolidAngleFromSpotLight(float spotAngle);
            static /*0x3b542bc*/ float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio);
            static /*0x3b54398*/ float GetSolidAngle(UnityEngine.LightType lightType, bool spotReflector, float spotAngle, float aspectRatio);
            static /*0x3b54458*/ float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY);
            static /*0x3b54470*/ float GetAreaFromRectangleLight(UnityEngine.Vector2 rectSize);
            static /*0x3b54488*/ float GetAreaFromDiscLight(float discRadius);
            static /*0x3b544a0*/ float GetAreaFromTubeLight(float tubeLength);
            static /*0x3b544bc*/ float LumenToCandela(float lumen, float solidAngle);
            static /*0x3b544c4*/ float CandelaToLumen(float candela, float solidAngle);
            static /*0x3b544cc*/ float LumenToNits(float lumen, float area);
            static /*0x3b544d4*/ float NitsToLumen(float nits, float area);
            static /*0x3b544dc*/ float LuxToCandela(float lux, float distance);
            static /*0x3b544e8*/ float CandelaToLux(float candela, float distance);
            static /*0x3b544f4*/ float Ev100ToNits(float ev100);
            static /*0x3b54514*/ float NitsToEv100(float nits);
            static /*0x3b54580*/ float Ev100ToCandela(float ev100);
            static /*0x3b545a0*/ float CandelaToEv100(float candela);
            static /*0x3b545a4*/ float ConvertIntensityInternal(float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit, UnityEngine.LightType lightType, float area, float luxAtDistance, float solidAngle);
            static /*0x3b54ab0*/ float ConvertIntensity(UnityEngine.Light light, float intensity, UnityEngine.Rendering.LightUnit fromUnit, UnityEngine.Rendering.LightUnit toUnit);
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

            static /*0x3b5506c*/ MaterialQualityUtilities();
            static /*0x3b54c0c*/ UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels);
            static /*0x3b54c98*/ UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel);
            static /*0x3b54e60*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level);
            static /*0x3b54f58*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd);
            static /*0x3b54dc8*/ int ToFirstIndex(UnityEngine.Rendering.MaterialQuality level);
            static /*0x3b54e54*/ UnityEngine.Rendering.MaterialQuality FromIndex(int index);
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

            static /*0x3b55c28*/ MeshGizmo();
            /*0x3b55334*/ MeshGizmo(int capacity);
            /*0x3b554dc*/ void Clear();
            /*0x3b55648*/ void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color);
            /*0x3b559f8*/ void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x3b55b90*/ void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x3b55bcc*/ void Dispose();
            /*0x3b5589c*/ void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, ref UnityEngine.Rendering.MeshGizmo.<> );

            struct <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Rendering.MeshGizmo <>4__this;
                /*0x18*/ UnityEngine.Color color;
            }
        }

        class SceneRenderPipeline : UnityEngine.MonoBehaviour
        {
            /*0x3b55c74*/ SceneRenderPipeline();
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

            static /*0x3b55ee8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x3b55ccc*/ TextureCurve(UnityEngine.AnimationCurve baseCurve, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x3b55d20*/ TextureCurve(UnityEngine.Keyframe[] keys, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x3b55c7c*/ int get_length();
            /*0x3b55c84*/ void set_length(int value);
            /*0x3b55c8c*/ UnityEngine.Keyframe get_Item(int index);
            /*0x3b55e30*/ void Dispose();
            /*0x3b55e34*/ void Release();
            /*0x3b55edc*/ void SetDirty();
            /*0x3b55f30*/ UnityEngine.Texture2D GetTexture();
            /*0x3b56124*/ float Evaluate(float time);
            /*0x3b5635c*/ int AddKey(float time, float value);
            /*0x3b56394*/ int MoveKey(int index, ref UnityEngine.Keyframe key);
            /*0x3b563dc*/ void RemoveKey(int index);
            /*0x3b56408*/ void SmoothTangents(int index, float weight);
        }

        class TextureCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureCurve>
        {
            /*0x3b56434*/ TextureCurveParameter(UnityEngine.Rendering.TextureCurve value, bool overrideState);
            /*0x3b56494*/ void Release();
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

            static /*0x3b56acc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x3b564e0*/ TextureGradient(UnityEngine.Gradient baseCurve);
            /*0x3b565d0*/ TextureGradient(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x3b564a8*/ int get_textureSize();
            /*0x3b564b0*/ void set_textureSize(int value);
            /*0x3b564b8*/ UnityEngine.GradientColorKey[] get_colorKeys();
            /*0x3b564cc*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
            /*0x3b56648*/ void Rebuild(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace, int requestedTextureSize, bool precise);
            /*0x3b56a14*/ void Dispose();
            /*0x3b56a18*/ void Release();
            /*0x3b56ac0*/ void SetDirty();
            /*0x3b56ad4*/ UnityEngine.Texture2D GetTexture();
            /*0x3b56d74*/ UnityEngine.Color Evaluate(float time);
            /*0x3b56dac*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys, UnityEngine.GradientMode mode, UnityEngine.ColorSpace colorSpace);
        }

        class TextureGradientParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureGradient>
        {
            /*0x3b56e34*/ TextureGradientParameter(UnityEngine.Rendering.TextureGradient value, bool overrideState);
            /*0x3b56e94*/ void Release();
        }

        class TileLayoutUtils
        {
            static /*0x3b56ea8*/ bool TryLayoutByTiles(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt topRow, ref UnityEngine.RectInt rightCol, ref UnityEngine.RectInt topRight);
            static /*0x3b56f34*/ bool TryLayoutByRow(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
            static /*0x3b56f94*/ bool TryLayoutByCol(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
        }

        interface IVolume
        {
            /*0x1f2fe14*/ bool get_isGlobal();
            /*0x1f30a84*/ void set_isGlobal(bool value);
            /*0x1f30214*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
        }

        class KeyframeUtility
        {
            static /*0x3b56ff4*/ void ResetAnimationCurve(UnityEngine.AnimationCurve curve);
            static /*0x3b57008*/ UnityEngine.Keyframe LerpSingleKeyframe(UnityEngine.Keyframe lhs, UnityEngine.Keyframe rhs, float t);
            static /*0x3b571c8*/ UnityEngine.Keyframe GetKeyframeAndClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index);
            static /*0x3b572dc*/ UnityEngine.Keyframe FetchKeyFromIndexClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index, float segmentStartTime, float segmentEndTime);
            static /*0x3b57458*/ void EvalCurveSegmentAndDeriv(ref float dstValue, ref float dstDeriv, UnityEngine.Keyframe lhsKey, UnityEngine.Keyframe rhsKey, float desiredTime);
            static /*0x3b575e4*/ UnityEngine.Keyframe EvalKeyAtTime(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime);
            static /*0x3b576a8*/ void InterpAnimationCurve(ref UnityEngine.AnimationCurve lhsAndResultCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x3b57d4c*/ KeyframeUtility();
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

            /*0x3b58418*/ Volume();
            /*0x3b57d54*/ bool get_isGlobal();
            /*0x3b57d5c*/ void set_isGlobal(bool value);
            /*0x3b57d64*/ UnityEngine.Rendering.VolumeProfile get_profile();
            /*0x3b5805c*/ void set_profile(UnityEngine.Rendering.VolumeProfile value);
            /*0x3b58064*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
            /*0x3b5806c*/ UnityEngine.Rendering.VolumeProfile get_profileRef();
            /*0x3b580e4*/ bool HasInstantiatedProfile();
            /*0x3b58144*/ void OnEnable();
            /*0x3b581f0*/ void OnDisable();
            /*0x3b58258*/ void Update();
            /*0x3b58270*/ void UpdateLayer();
            /*0x3b58310*/ void UpdatePriority();
            /*0x3b58404*/ void OnValidate();
        }

        class VolumeCollection
        {
            static int k_MaxLayerCount = 32;
            /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;
            /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;

            static /*0x3b5911c*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes);
            /*0x3b5951c*/ VolumeCollection();
            /*0x3b584b0*/ int get_count();
            /*0x3b584f8*/ bool Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x3b58c4c*/ bool Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x3b59024*/ bool ChangeLayer(UnityEngine.Rendering.Volume volume, int previousLayerIndex, int currentLayerIndex);
            /*0x3b59260*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);
            /*0x3b589b0*/ void SetLayerIndexDirty(int layerIndex);
            /*0x1ffc854*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
        }

        class VolumeComponentMenu : System.Attribute
        {
            /*0x10*/ string menu;

            /*0x3b5964c*/ VolumeComponentMenu(string menu);
        }

        class VolumeComponentMenuForRenderPipeline : UnityEngine.Rendering.VolumeComponentMenu
        {
            /*0x18*/ System.Type[] <pipelineTypes>k__BackingField;

            /*0x3b59684*/ VolumeComponentMenuForRenderPipeline(string menu, System.Type[] pipelineTypes);
            /*0x3b5967c*/ System.Type[] get_pipelineTypes();
        }

        class VolumeComponentDeprecated : System.Attribute
        {
            /*0x3b5985c*/ VolumeComponentDeprecated();
        }

        class VolumeComponent : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool active;
            /*0x20*/ string <displayName>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameterList;
            /*0x30*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> m_ParameterReadOnlyCollection;

            static /*0x3b598e8*/ void FindParameters(object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo, bool> filter);
            /*0x3b5ab74*/ VolumeComponent();
            /*0x3b59864*/ string get_displayName();
            /*0x3b5986c*/ void set_displayName(string value);
            /*0x3b59874*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x3b59e98*/ void OnEnable();
            /*0x3b5a180*/ void OnDisable();
            /*0x3b5a32c*/ void Override(UnityEngine.Rendering.VolumeComponent state, float interpFactor);
            /*0x3b5a458*/ void SetAllOverridesTo(bool state);
            /*0x3b5a468*/ void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, bool state);
            /*0x3b5a94c*/ int GetHashCode();
            /*0x3b5aa04*/ bool AnyPropertiesIsOverridden();
            /*0x3b5aab0*/ void OnDestroy();
            /*0x3b5aab4*/ void Release();

            class Indent : UnityEngine.PropertyAttribute
            {
                /*0x18*/ int relativeAmount;

                /*0x3b5ac28*/ Indent(int relativeAmount);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeComponent.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__10_0;

                static /*0x3b5ac50*/ <>c();
                /*0x3b5acb8*/ <>c();
                /*0x3b5acc0*/ int <FindParameters>b__10_0(System.Reflection.FieldInfo t);
            }
        }

        struct VolumeIsolationScope : System.IDisposable
        {
            /*0x3b5ace4*/ VolumeIsolationScope(bool unused);
            /*0x3b5ace8*/ void System.IDisposable.Dispose();
        }

        class VolumeParameter : System.ICloneable
        {
            static string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
            /*0x10*/ bool m_OverrideState;

            static /*0x3b5a820*/ bool IsObjectParameter(System.Type type);
            /*0x3b5ad08*/ VolumeParameter();
            /*0x3b5acec*/ bool get_overrideState();
            /*0x3b5acf4*/ void set_overrideState(bool value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x1ffc854*/ T GetValue<T>();
            /*0x1f30ebc*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x3b5acfc*/ void OnEnable();
            /*0x3b5ad00*/ void OnDisable();
            /*0x3b5ad04*/ void Release();
            /*0x1f30214*/ object Clone();
        }

        class VolumeParameter<T> : UnityEngine.Rendering.VolumeParameter, System.IEquatable<UnityEngine.Rendering.VolumeParameter<T>>
        {
            /*0x0*/ T m_Value;

            static /*0x1ffc854*/ bool op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x1ffc854*/ bool op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x1ffc854*/ T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop);
            /*0x1f309e4*/ VolumeParameter();
            /*0x1ffc854*/ VolumeParameter(T value, bool overrideState);
            /*0x1ffc854*/ T get_value();
            /*0x1ffc854*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x1ffc854*/ void Interp(T from, T to, float t);
            /*0x1ffc854*/ void Override(T x);
            /*0x1f30ebc*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1f30214*/ string ToString();
            /*0x1f2fec8*/ bool Equals(UnityEngine.Rendering.VolumeParameter<T> other);
            /*0x1f2fec8*/ bool Equals(object obj);
            /*0x1f30214*/ object Clone();
        }

        class EnumParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x1ffc854*/ EnumParameter(T value, bool overrideState);
        }

        class BoolParameter : UnityEngine.Rendering.VolumeParameter<bool>
        {
            /*0x14*/ UnityEngine.Rendering.BoolParameter.DisplayType displayType;

            /*0x3b5ad10*/ BoolParameter(bool value, bool overrideState);
            /*0x3b5ad84*/ BoolParameter(bool value, UnityEngine.Rendering.BoolParameter.DisplayType displayType, bool overrideState);

            enum DisplayType
            {
                Checkbox = 0,
                EnumPopup = 1,
            }
        }

        class LayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.LayerMask>
        {
            /*0x3b5ae00*/ LayerMaskParameter(UnityEngine.LayerMask value, bool overrideState);
        }

        class RenderingLayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderingLayerMask>
        {
            /*0x3b5ae70*/ RenderingLayerMaskParameter(UnityEngine.RenderingLayerMask value, bool overrideState);
        }

        class IntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x3b5aee0*/ IntParameter(int value, bool overrideState);
            /*0x3b5af50*/ void Interp(int from, int to, float t);
        }

        class NoInterpIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x3b5af84*/ NoInterpIntParameter(int value, bool overrideState);
        }

        class MinIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;

            /*0x3b5b010*/ MinIntParameter(int value, int min, bool overrideState);
            /*0x3b5aff4*/ int get_value();
            /*0x3b5affc*/ void set_value(int value);
        }

        class NoInterpMinIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;

            /*0x3b5b054*/ NoInterpMinIntParameter(int value, int min, bool overrideState);
            /*0x3b5b038*/ int get_value();
            /*0x3b5b040*/ void set_value(int value);
        }

        class MaxIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int max;

            /*0x3b5b0e8*/ MaxIntParameter(int value, int max, bool overrideState);
            /*0x3b5b0cc*/ int get_value();
            /*0x3b5b0d4*/ void set_value(int value);
        }

        class NoInterpMaxIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int max;

            /*0x3b5b12c*/ NoInterpMaxIntParameter(int value, int max, bool overrideState);
            /*0x3b5b110*/ int get_value();
            /*0x3b5b118*/ void set_value(int value);
        }

        class ClampedIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x3b5b1c8*/ ClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x3b5b1a4*/ int get_value();
            /*0x3b5b1ac*/ void set_value(int value);
        }

        class NoInterpClampedIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x18*/ int min;
            /*0x1c*/ int max;

            /*0x3b5b218*/ NoInterpClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x3b5b1f4*/ int get_value();
            /*0x3b5b1fc*/ void set_value(int value);
        }

        class FloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x3b5b29c*/ FloatParameter(float value, bool overrideState);
            /*0x3b5b314*/ void Interp(float from, float to, float t);
        }

        class NoInterpFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x3b5b328*/ NoInterpFloatParameter(float value, bool overrideState);
        }

        class MinFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;

            /*0x3b5b3bc*/ MinFloatParameter(float value, float min, bool overrideState);
            /*0x3b5b3a0*/ float get_value();
            /*0x3b5b3a8*/ void set_value(float value);
        }

        class NoInterpMinFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;

            /*0x3b5b3fc*/ NoInterpMinFloatParameter(float value, float min, bool overrideState);
            /*0x3b5b3e0*/ float get_value();
            /*0x3b5b3e8*/ void set_value(float value);
        }

        class MaxFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float max;

            /*0x3b5b490*/ MaxFloatParameter(float value, float max, bool overrideState);
            /*0x3b5b474*/ float get_value();
            /*0x3b5b47c*/ void set_value(float value);
        }

        class NoInterpMaxFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float max;

            /*0x3b5b4d0*/ NoInterpMaxFloatParameter(float value, float max, bool overrideState);
            /*0x3b5b4b4*/ float get_value();
            /*0x3b5b4bc*/ void set_value(float value);
        }

        class ClampedFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x3b5b56c*/ ClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x3b5b548*/ float get_value();
            /*0x3b5b550*/ void set_value(float value);
        }

        class NoInterpClampedFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x18*/ float min;
            /*0x1c*/ float max;

            /*0x3b5b5b8*/ NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0x3b5b594*/ float get_value();
            /*0x3b5b59c*/ void set_value(float value);
        }

        class FloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x3b5b678*/ FloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x3b5b644*/ UnityEngine.Vector2 get_value();
            /*0x3b5b64c*/ void set_value(UnityEngine.Vector2 value);
            /*0x3b5b700*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpFloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x1c*/ float min;
            /*0x20*/ float max;

            /*0x3b5b754*/ NoInterpFloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0x3b5b720*/ UnityEngine.Vector2 get_value();
            /*0x3b5b728*/ void set_value(UnityEngine.Vector2 value);
        }

        class ColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x3b5b7dc*/ ColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x3b5b874*/ ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
            /*0x3b5b94c*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
        }

        class NoInterpColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x24*/ bool hdr;
            /*0x25*/ bool showAlpha;
            /*0x26*/ bool showEyeDropper;

            /*0x3b5b97c*/ NoInterpColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x3b5ba14*/ NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
        }

        class Vector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x3b5baec*/ Vector2Parameter(UnityEngine.Vector2 value, bool overrideState);
            /*0x3b5bb60*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpVector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x3b5bb80*/ NoInterpVector2Parameter(UnityEngine.Vector2 value, bool overrideState);
        }

        class Vector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x3b5bbf4*/ Vector3Parameter(UnityEngine.Vector3 value, bool overrideState);
            /*0x3b5bc80*/ void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float t);
        }

        class NoInterpVector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x3b5bcb0*/ NoInterpVector3Parameter(UnityEngine.Vector3 value, bool overrideState);
        }

        class Vector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x3b5bd3c*/ Vector4Parameter(UnityEngine.Vector4 value, bool overrideState);
            /*0x3b5bdcc*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
        }

        class NoInterpVector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x3b5bdfc*/ NoInterpVector4Parameter(UnityEngine.Vector4 value, bool overrideState);
        }

        class TextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x20*/ UnityEngine.Rendering.TextureDimension dimension;

            /*0x3b5be8c*/ TextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x3b5be98*/ TextureParameter(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, bool overrideState);
            /*0x3b5bf0c*/ int GetHashCode();
        }

        class NoInterpTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x3b5c010*/ NoInterpTextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x3b5c070*/ int GetHashCode();
        }

        class Texture2DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x3b5c174*/ Texture2DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x3b5c1d4*/ int GetHashCode();
        }

        class Texture3DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x3b5c2d8*/ Texture3DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x3b5c338*/ int GetHashCode();
        }

        class RenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x3b5c43c*/ RenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x3b5c49c*/ int GetHashCode();
        }

        class NoInterpRenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x3b5c5a0*/ NoInterpRenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x3b5c600*/ int GetHashCode();
        }

        class CubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x3b5c704*/ CubemapParameter(UnityEngine.Texture value, bool overrideState);
            /*0x3b5c764*/ int GetHashCode();
        }

        class NoInterpCubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Cubemap>
        {
            /*0x3b5c868*/ NoInterpCubemapParameter(UnityEngine.Cubemap value, bool overrideState);
            /*0x3b5c8c8*/ int GetHashCode();
        }

        class ObjectParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            /*0x1ffc854*/ ObjectParameter(T value);
            /*0x1f30214*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x1f30ebc*/ void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            /*0x1f2fe14*/ bool get_overrideState();
            /*0x1f30a84*/ void set_overrideState(bool value);
            /*0x1ffc854*/ T get_value();
            /*0x1ffc854*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x1f302cc*/ UnityEngine.Rendering.VolumeParameter <set_value>b__9_2(System.Reflection.FieldInfo t);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ObjectParameter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__9_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, int> <>9__9_1;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f2fec8*/ bool <set_value>b__9_0(System.Reflection.FieldInfo t);
                /*0x1f3008c*/ int <set_value>b__9_1(System.Reflection.FieldInfo t);
            }
        }

        class AnimationCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.AnimationCurve>
        {
            /*0x3b5c9cc*/ AnimationCurveParameter(UnityEngine.AnimationCurve value, bool overrideState);
            /*0x3b5ca2c*/ void Interp(UnityEngine.AnimationCurve lhsCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x3b5ca6c*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x3b5cafc*/ object Clone();
            /*0x3b5cbe4*/ int GetHashCode();
        }

        class MaterialParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Material>
        {
            /*0x3b5cc70*/ MaterialParameter(UnityEngine.Material value, bool overrideState);
        }

        class VolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;
            /*0x20*/ UnityEngine.Rendering.VolumeProfile.DirtyState dirtyState;

            /*0x3b5d7e0*/ VolumeProfile();
            /*0x3b5ccd0*/ bool get_isDirty();
            /*0x3b5cce0*/ void set_isDirty(bool value);
            /*0x3b5cd00*/ void OnEnable();
            /*0x3b5ce04*/ void OnDisable();
            /*0x3b5cef8*/ void Reset();
            /*0x1ffc854*/ T Add<T>(bool overrides);
            /*0x3b5cf08*/ UnityEngine.Rendering.VolumeComponent Add(System.Type type, bool overrides);
            /*0x1f309e4*/ void Remove<T>();
            /*0x3b5d254*/ void Remove(System.Type type);
            /*0x1f2fe14*/ bool Has<T>();
            /*0x3b5d044*/ bool Has(System.Type type);
            /*0x3b5d368*/ bool HasSubclassOf(System.Type type);
            /*0x1f2fec8*/ bool TryGet<T>(ref T component);
            /*0x1f2ff00*/ bool TryGet<T>(System.Type type, ref T component);
            /*0x1f2ff00*/ bool TryGetSubclassOf<T>(System.Type type, ref T component);
            /*0x1f2ff00*/ bool TryGetAllSubclassOf<T>(System.Type type, System.Collections.Generic.List<T> result);
            /*0x3b5d568*/ int GetHashCode();
            /*0x3b5d620*/ int GetComponentListHashCode();
            /*0x3b5d6e4*/ void Sanitize();

            enum DirtyState
            {
                None = 0,
                DirtyByComponentChange = 1,
                DirtyByProfileReset = 2,
                Other = 4,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeProfile.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.VolumeComponent> <>9__6_0;

                static /*0x3b5d868*/ <>c();
                /*0x3b5d8d0*/ <>c();
                /*0x3b5d8d8*/ bool <OnEnable>b__6_0(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class VolumeStack : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.VolumeComponent> components;
            /*0x18*/ UnityEngine.Rendering.VolumeParameter[] parameters;
            /*0x20*/ bool requiresReset;
            /*0x21*/ bool requiresResetForAllProperties;
            /*0x22*/ bool <isValid>k__BackingField;

            /*0x3b5d934*/ VolumeStack();
            /*0x3b5d9c4*/ void Clear();
            /*0x3b5dc6c*/ void Reload(System.Type[] componentTypes);
            /*0x1ffc854*/ T GetComponent<T>();
            /*0x3b5de40*/ UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type);
            /*0x3b5deb0*/ void Dispose();
            /*0x3b5dec8*/ bool get_isValid();
            /*0x3b5ded0*/ void set_isValid(bool value);
        }

        class XRGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;
            static /*0x1*/ bool running;

            static /*0x3b5df3c*/ XRGraphicsAutomatedTests();
            static /*0x3b5ded8*/ bool get_activatedFromCommandLine();
            static /*0x3b5dee0*/ bool get_enabled();
            static /*0x3b5df38*/ void OverrideLayout(UnityEngine.Experimental.Rendering.XRLayout layout, UnityEngine.Camera camera);
        }

        class XRSRPSettings
        {
            static /*0x3b5df84*/ bool get_enabled();
            static /*0x3b5df8c*/ bool get_isDeviceActive();
            static /*0x3b5df94*/ string get_loadedDeviceName();
            static /*0x3b5dfd4*/ string[] get_supportedDevices();
            static /*0x3b5e018*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x3b5e03c*/ int get_eyeTextureWidth();
            static /*0x3b5e044*/ int get_eyeTextureHeight();
            static /*0x3b5e04c*/ float get_occlusionMeshScale();
            static /*0x3b5e054*/ void set_occlusionMeshScale(float value);
            static /*0x3b5e058*/ int get_mirrorViewMode();
            static /*0x3b5e060*/ void set_mirrorViewMode(int value);
            /*0x3b5e064*/ XRSRPSettings();
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

                /*0x3b5ea78*/ RenderGraphDebugParams();
                /*0x3b5e06c*/ void Reset();
                /*0x3b5e078*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList(string name);
                /*0x3b5e7b8*/ bool IsImmediateModeSupported();
                /*0x3b5e890*/ void RegisterDebug(string name, UnityEngine.Rendering.DebugUI.Panel debugPanel);
                /*0x3b5e9c0*/ void UnRegisterDebug(string name);
                /*0x3b5ea40*/ bool get_AreAnySettingsActive();
                /*0x3b5ea80*/ bool <GetWidgetList>b__11_0();
                /*0x3b5ea88*/ void <GetWidgetList>b__11_1(bool value);
                /*0x3b5ea90*/ bool <GetWidgetList>b__11_2();
                /*0x3b5ea98*/ void <GetWidgetList>b__11_3(bool value);
                /*0x3b5eaa0*/ bool <GetWidgetList>b__11_4();
                /*0x3b5eaa8*/ void <GetWidgetList>b__11_5(bool value);
                /*0x3b5eab0*/ bool <GetWidgetList>b__11_6();
                /*0x3b5eab8*/ void <GetWidgetList>b__11_7(bool value);
                /*0x3b5eac0*/ bool <GetWidgetList>b__11_8();
                /*0x3b5ead8*/ bool <GetWidgetList>b__11_9();
                /*0x3b5eae0*/ void <GetWidgetList>b__11_10(bool value);
                /*0x3b5eae8*/ void <GetWidgetList>b__11_11();
                /*0x3b5eb68*/ void <GetWidgetList>b__11_12();

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

                    static /*0x3b5ebe8*/ Strings();
                }
            }

            interface IBaseRenderGraphBuilder : System.IDisposable
            {
                /*0x1f30ee8*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1f30bb4*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1f30a84*/ void UseAllGlobalTextures(bool enable);
                /*0x1f30ee8*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x1f30ebc*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x1f30a84*/ void EnableAsyncCompute(bool value);
                /*0x1f30a84*/ void AllowPassCulling(bool value);
                /*0x1f30a84*/ void AllowGlobalStateModification(bool value);
                /*0x1f30a84*/ void EnableFoveatedRasterization(bool value);
            }

            interface IComputeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
            }

            interface IUnsafeRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
            }

            interface IRasterRenderGraphBuilder : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable
            {
                /*0x3b5ef90*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3b5f060*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3b5f130*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle tex, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
            }

            interface IRenderGraphEnabledRenderPipeline
            {
                /*0x1f2fe14*/ bool get_isImmediateModeSupported();
            }

            interface IRenderGraphRecorder
            {
                /*0x1f30ff0*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
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

                static /*0x3b6a9e8*/ RenderGraph();
                static /*0x3b5f6b0*/ bool get_isRenderGraphViewerActive();
                static /*0x3b5f708*/ void set_isRenderGraphViewerActive(bool value);
                static /*0x3b5f768*/ bool get_enableValidityChecks();
                static /*0x3b5f7c0*/ void set_enableValidityChecks(bool value);
                static /*0x3b60318*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs();
                static /*0x3b625ac*/ void add_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x3b62688*/ void remove_onGraphRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x3b62764*/ void add_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x3b62840*/ void remove_onGraphUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                static /*0x3b6291c*/ void add_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x3b629f8*/ void remove_onExecutionRegistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x3b62ad4*/ void add_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x3b62bb0*/ void remove_onExecutionUnregistered(UnityEngine.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                static /*0x3b62c8c*/ void add_onDebugDataCaptured(System.Action value);
                static /*0x3b62d68*/ void remove_onDebugDataCaptured(System.Action value);
                /*0x3b5f828*/ RenderGraph(string name);
                /*0x3b5f1f8*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler CompileNativeRenderGraph(int graphHash);
                /*0x3b5f504*/ void ExecuteNativeRenderGraph();
                /*0x3b5f688*/ bool get_nativeRenderPassesEnabled();
                /*0x3b5f690*/ void set_nativeRenderPassesEnabled(bool value);
                /*0x3b5f698*/ string get_name();
                /*0x3b5f6a0*/ void set_name(string value);
                /*0x3b5f6a8*/ void RequestCaptureDebugData(string executionName);
                /*0x3b5f820*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x3b6015c*/ void Cleanup();
                /*0x3b60278*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams get_debugParams();
                /*0x3b60280*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> GetWidgetList();
                /*0x3b6029c*/ bool get_areAnySettingsActive();
                /*0x3b602e4*/ void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x3b60304*/ void UnRegisterDebug();
                /*0x3b60370*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData GetDebugData(string executionName);
                /*0x3b603e8*/ void EndFrame();
                /*0x3b604b0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                /*0x3b604d8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x3b60500*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x3b60540*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x3b60568*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x3b605a4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                /*0x3b60608*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b60624*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x3b60694*/ void RefreshSharedTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b606c8*/ void ReleaseSharedTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b60748*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b607c4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, string name, bool clear);
                /*0x3b60890*/ void CreateTextureIfInvalid(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b60844*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b609b8*/ UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo GetRenderTargetInfo(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b60a08*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x3b60a2c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x3b60a50*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawingSettings);
                /*0x3b60a84*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x3b60abc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x3b60b00*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x3b60b38*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(ref UnityEngine.Camera camera);
                /*0x3b60b6c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera);
                /*0x3b60ba0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x3b60c08*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x3b60c98*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x3b60cc0*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3b60ce8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x3b60d4c*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsBuffer);
                /*0x3b60d90*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x1ffc854*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, string file, int line);
                /*0x3b60db4*/ void BeginRecording(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphParameters parameters);
                /*0x3b61318*/ void EndRecordingAndExecute();
                /*0x3b6131c*/ void Execute();
                /*0x3b61cb8*/ void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3b61f00*/ void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler, string file, int line);
                /*0x3b62110*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos();
                /*0x3b6026c*/ void ClearCompiledGraph();
                /*0x3b62128*/ void ClearCompiledGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledGraph compiledGraph, bool useCompilationCaching);
                /*0x3b6250c*/ void InvalidateContext();
                /*0x3b62558*/ void OnPassAdded(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x3b61554*/ int ComputeGraphHash();
                /*0x3b62e44*/ void CountReferences();
                /*0x3b6362c*/ void CullUnusedPasses();
                /*0x3b6411c*/ void UpdatePassSynchronization(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo currentPassInfo, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex);
                /*0x3b64144*/ void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo resource);
                /*0x3b64494*/ int GetFirstValidConsumerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x3b6469c*/ int FindTextureProducer(int consumerPass, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info, ref int index);
                /*0x3b6427c*/ int GetLatestProducerIndex(int passIndex, ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x3b647bc*/ int GetLatestValidReadIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x3b648a8*/ int GetFirstValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x3b649a8*/ int GetLatestValidWriteIndex(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                /*0x3b64a94*/ void CreateRendererLists();
                /*0x3b64bcc*/ bool GetImportedFallback(UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle fallback);
                /*0x3b64ec0*/ void AllocateCulledPassResources(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x3b652f4*/ void UpdateResourceAllocationAndSynchronization();
                /*0x3b65c28*/ void UpdateAllSharedResourceLastFrameIndex();
                /*0x3b65d60*/ bool AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists);
                /*0x3b65fe8*/ void TryCullPassAtIndex(int passIndex);
                /*0x3b660cc*/ void CullRendererLists();
                /*0x3b610e4*/ bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching);
                /*0x3b616c8*/ void CompileRenderGraph(int graphHash);
                /*0x3b66494*/ ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo CompilePassImmediatly(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x3b62590*/ void ExecutePassImmediately(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                /*0x3b670d8*/ void ExecuteCompiledPass(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x3b61844*/ void ExecuteRenderGraph();
                /*0x3b680c8*/ void PreRenderPassSetRenderTargets(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x3b677d8*/ void PreRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x3b67ba4*/ void PostRenderPassExecute(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext);
                /*0x3b62234*/ void ClearRenderPasses();
                /*0x3b68650*/ void ReleaseImmediateModeResources();
                /*0x3b61130*/ void LogFrameInformation();
                /*0x3b66380*/ void LogRendererListsCreation();
                /*0x3b674a8*/ void LogRenderPassBegin(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                /*0x3b63d2c*/ void LogCulledPasses();
                /*0x3b6885c*/ UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(string name);
                /*0x3b68864*/ void UpdateImportedResourceLifeTime(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData data, System.Collections.Generic.List<int> passList);
                /*0x3b68aa4*/ void GenerateDebugData();
                /*0x3b69208*/ void GenerateCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);
                /*0x3b68cb8*/ void CleanupDebugData();
                /*0x3b6a550*/ void SetGlobal(UnityEngine.Rendering.RenderGraphModule.TextureHandle h, int globalPropertyId);
                /*0x3b6a6e8*/ bool IsGlobal(int globalPropertyId);
                /*0x3b6a754*/ System.Collections.Generic.Dictionary.ValueCollection<int, UnityEngine.Rendering.RenderGraphModule.TextureHandle> AllGlobals();
                /*0x3b6a7a4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle GetGlobal(int globalPropertyId);
                /*0x3b619b0*/ void ClearGlobalBindings();
                /*0x3b6a818*/ void AddPassDebugMetadata(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, string file, int line);
                /*0x3b6a970*/ void ClearPassDebugMetadata();

                struct CompiledResourceInfo
                {
                    /*0x10*/ System.Collections.Generic.List<int> producers;
                    /*0x18*/ System.Collections.Generic.List<int> consumers;
                    /*0x20*/ int refCount;
                    /*0x24*/ bool imported;

                    /*0x3b6aa88*/ void Reset();
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

                    /*0x3b66e0c*/ void Reset(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int index);
                }

                interface ICompiledGraph
                {
                    /*0x1f309e4*/ void Clear();
                }

                class CompiledGraph : UnityEngine.Rendering.RenderGraphModule.RenderGraph.ICompiledGraph
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> compiledResourcesInfos;
                    /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> compiledPassInfos;
                    /*0x20*/ int lastExecutionFrame;

                    /*0x3b5fff0*/ CompiledGraph();
                    /*0x3b62464*/ void Clear();
                    /*0x3b6ac18*/ void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, int count);
                    /*0x3b661dc*/ void InitializeCompilationData(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                }

                class ProfilingScopePassData
                {
                    /*0x10*/ UnityEngine.Rendering.ProfilingSampler sampler;

                    /*0x3b6accc*/ ProfilingScopePassData();
                }

                class OnGraphRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x3b6acd4*/ OnGraphRegisteredDelegate(object object, nint method);
                    /*0x3b6addc*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph);
                    /*0x3b6adf0*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, object object);
                    /*0x3b6ae10*/ void EndInvoke(System.IAsyncResult result);
                }

                class OnExecutionRegisteredDelegate : System.MulticastDelegate
                {
                    /*0x3b6ae1c*/ OnExecutionRegisteredDelegate(object object, nint method);
                    /*0x3b6af28*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName);
                    /*0x3b6af3c*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, string executionName, System.AsyncCallback callback, object object);
                    /*0x3b6af64*/ void EndInvoke(System.IAsyncResult result);
                }

                class DebugData
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<object, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassScriptInfo> s_PassScriptMetadata;
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData> passList;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.ResourceData> resourceLists;
                    /*0x20*/ bool isNRPCompiler;

                    static /*0x3b6af70*/ DebugData();
                    /*0x3b68f68*/ DebugData();
                    /*0x3b690d4*/ void Clear();

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

                            /*0x3b6b008*/ NRPInfo();

                            class NativeRenderPassInfo
                            {
                                /*0x10*/ string passBreakReasoning;
                                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo> attachmentInfos;
                                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.PassCompatibilityInfo> passCompatibility;
                                /*0x28*/ System.Collections.Generic.List<int> mergedPassIds;

                                /*0x3b6b0b4*/ NativeRenderPassInfo();

                                class AttachmentInfo
                                {
                                    /*0x10*/ string resourceName;
                                    /*0x18*/ string loadReason;
                                    /*0x20*/ string storeReason;
                                    /*0x28*/ string storeMsaaReason;
                                    /*0x30*/ int attachmentIndex;
                                    /*0x34*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment attachment;

                                    /*0x3b6b0bc*/ AttachmentInfo();
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

                        /*0x3b6a548*/ BufferResourceData();
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

                        /*0x3b6a540*/ TextureResourceData();
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

                        /*0x3b6a968*/ PassScriptInfo();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__111_0;
                    static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> <>9__112_0;

                    static /*0x3b6b0c4*/ <>c();
                    /*0x3b6b12c*/ <>c();
                    /*0x3b6b134*/ void <BeginProfilingSampler>b__111_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
                    /*0x3b6b174*/ void <EndProfilingSampler>b__112_0(UnityEngine.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext ctx);
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

                /*0x3b5ffe8*/ InternalRenderGraphContext();
            }

            interface IDerivedRendergraphContext
            {
                /*0x1f30ebc*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            struct RenderGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;

                /*0x3b6b19c*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
                /*0x3b6b1a4*/ UnityEngine.Rendering.ScriptableRenderContext get_renderContext();
                /*0x3b6b15c*/ UnityEngine.Rendering.CommandBuffer get_cmd();
                /*0x3b6b1bc*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x3b6b1d4*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
            }

            struct RasterGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.RasterCommandBuffer rastercmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.RasterCommandBuffer cmd;

                static /*0x3b6b2e4*/ RasterGraphContext();
                /*0x3b6b1ec*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x3b6b204*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x3b6b21c*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class ComputeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.ComputeCommandBuffer computecmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.ComputeCommandBuffer cmd;

                static /*0x3b6b470*/ ComputeGraphContext();
                /*0x3b6b468*/ ComputeGraphContext();
                /*0x3b6b36c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x3b6b384*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x3b6b39c*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
            }

            class UnsafeGraphContext : UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext
            {
                static /*0x0*/ UnityEngine.Rendering.UnsafeCommandBuffer unsCmd;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext wrappedContext;
                /*0x18*/ UnityEngine.Rendering.UnsafeCommandBuffer cmd;

                static /*0x3b6b5fc*/ UnsafeGraphContext();
                /*0x3b6b5f4*/ UnsafeGraphContext();
                /*0x3b6b4f8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                /*0x3b6b510*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool get_renderGraphPool();
                /*0x3b6b528*/ void FromInternalContext(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext context);
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
                /*0x1ffc854*/ void Invoke(PassData data, ContextType renderGraphContext);
                /*0x1ffc854*/ System.IAsyncResult BeginInvoke(PassData data, ContextType renderGraphContext, System.AsyncCallback callback, object object);
                /*0x1f30ebc*/ void EndInvoke(System.IAsyncResult result);
            }

            struct RenderGraphProfilingScope : System.IDisposable
            {
                /*0x3b6b684*/ RenderGraphProfilingScope(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x3b6b688*/ void Dispose();
                /*0x3b6b68c*/ void Dispose(bool disposing);
            }

            struct RenderGraphBuilder : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x3b6be60*/ RenderGraphBuilder(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3b6b690*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index);
                /*0x3b6b760*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x3b6b898*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x3b6b850*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle WriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x3b6b978*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input);
                /*0x3b6b9d4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b6ba30*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b6bad4*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle WriteRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x3b6bb20*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ReadRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle input);
                /*0x3b6bb4c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x3b6bbd4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ReadBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x3b6bc00*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle WriteBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input);
                /*0x3b6bc4c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3b6bcb4*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle graphicsbuffer);
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext> renderFunc);
                /*0x3b6bd50*/ void EnableAsyncCompute(bool value);
                /*0x3b61ec8*/ void AllowPassCulling(bool value);
                /*0x3b6bd6c*/ void EnableFoveatedRasterization(bool value);
                /*0x3b6bd88*/ void Dispose();
                /*0x3b6bdc4*/ void AllowRendererListCulling(bool value);
                /*0x3b6bde0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle DependsOn(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x3b6bd90*/ void Dispose(bool disposing);
                /*0x3b6beac*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x3b61ee4*/ void GenerateDebugData(bool value);
            }

            class RenderGraphBuilders : UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder, System.IDisposable, UnityEngine.Rendering.RenderGraphModule.IComputeRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IRasterRenderGraphBuilder, UnityEngine.Rendering.RenderGraphModule.IUnsafeRenderGraphBuilder
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                /*0x20*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                /*0x28*/ bool m_Disposed;

                /*0x3b5ff98*/ RenderGraphBuilders();
                /*0x3b6c188*/ void Setup(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
                /*0x3b6c238*/ void EnableAsyncCompute(bool value);
                /*0x3b6c254*/ void AllowPassCulling(bool value);
                /*0x3b6c288*/ void AllowGlobalStateModification(bool value);
                /*0x3b6c2ac*/ void EnableFoveatedRasterization(bool value);
                /*0x3b6c2c8*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3b6c528*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x3b6c584*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b6c5dc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b6c648*/ void Dispose();
                /*0x3b6c65c*/ void Dispose(bool disposing);
                /*0x3b6cb24*/ void ValidateWriteTo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b6c32c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle UseResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, bool isTransient);
                /*0x3b6cdac*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6cdcc*/ void CheckNotUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex);
                /*0x3b6cb1c*/ void UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6d1b8*/ void UseGlobalTexture(int propertyId, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6d370*/ void UseAllGlobalTextures(bool enable);
                /*0x3b6d38c*/ void SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x3b6d44c*/ void CheckUseFragment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, bool isDepth);
                /*0x3b6db8c*/ void SetRenderAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3b6dc10*/ void SetInputAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3b6dc94*/ void SetRenderAttachmentDepth(UnityEngine.Rendering.RenderGraphModule.TextureHandle tex, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
                /*0x3b6dd10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle SetRandomAccessAttachment(UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6dd84*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6de08*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UseBufferRandomAccess(UnityEngine.Rendering.RenderGraphModule.BufferHandle input, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> renderFunc);
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> renderFunc);
                /*0x1f30ebc*/ void SetRenderFunc<PassData>(UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> renderFunc);
                /*0x3b6de98*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
                /*0x3b6cd54*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b6df10*/ void CheckResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, bool checkTransientReadWrite);
                /*0x3b6e228*/ void CheckFrameBufferFetchEmulationIsSupported(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle tex);
                /*0x3b6e3e0*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6e3e8*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.SetGlobalTextureAfterPass(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle input, int propertyId);
                /*0x3b6e3ec*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle input, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags);
                /*0x3b6e40c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b6e410*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b6e414*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3b6e428*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.CreateTransientBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle computebuffer);
                /*0x3b6e43c*/ void UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder.UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle input);
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

                /*0x3b6f10c*/ RenderGraphDefaultResources();
                /*0x3b6f044*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture();
                /*0x3b6f050*/ void set_blackTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f058*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTexture();
                /*0x3b6f064*/ void set_whiteTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f06c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR();
                /*0x3b6f078*/ void set_clearTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f080*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR();
                /*0x3b6f08c*/ void set_magentaTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f094*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR();
                /*0x3b6f0a0*/ void set_blackTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f0a8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR();
                /*0x3b6f0b4*/ void set_blackTextureArrayXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f0bc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR();
                /*0x3b6f0c8*/ void set_blackUIntTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f0d0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR();
                /*0x3b6f0dc*/ void set_blackTexture3DXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f0e4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR();
                /*0x3b6f0f0*/ void set_whiteTextureXR(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f0f8*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture();
                /*0x3b6f104*/ void set_defaultShadowTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3b6f128*/ void InitDefaultResourcesIfNeeded();
                /*0x3b6f2b4*/ void Cleanup();
                /*0x3b6f330*/ void InitializeForRendering(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            }

            struct RenderGraphLogIndent : System.IDisposable
            {
                /*0x10*/ int m_Indentation;
                /*0x18*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;
                /*0x20*/ bool m_Disposed;

                /*0x3b6f530*/ RenderGraphLogIndent(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger, int indentation);
                /*0x3b6f5e0*/ void Dispose();
                /*0x3b6f614*/ void Dispose(bool disposing);
            }

            class RenderGraphLogger
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, System.Text.StringBuilder> m_LogMap;
                /*0x18*/ System.Text.StringBuilder m_CurrentBuilder;
                /*0x20*/ int m_CurrentIndentation;

                /*0x3b6fbac*/ RenderGraphLogger();
                /*0x3b6f6c8*/ void Initialize(string logName);
                /*0x3b6f570*/ void IncrementIndentation(int value);
                /*0x3b6f64c*/ void DecrementIndentation(int value);
                /*0x3b6f7b8*/ void LogLine(string format, object[] args);
                /*0x3b6f83c*/ string GetLog(string logName);
                /*0x3b6f8dc*/ string GetAllLogs();
            }

            class RenderGraphObjectPool
            {
                static /*0x0*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;
                /*0x10*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, int>, System.Collections.Generic.Stack<object>> m_ArrayPool;
                /*0x18*/ System.Collections.Generic.List<System.ValueTuple<object, System.ValueTuple<System.Type, int>>> m_AllocatedArrays;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

                static /*0x3b70504*/ RenderGraphObjectPool();
                /*0x3b6fc34*/ RenderGraphObjectPool();
                /*0x1f30240*/ T[] GetTempArray<T>(int size);
                /*0x3b6fd64*/ UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock();
                /*0x3b6fe10*/ void ReleaseAllTempAlloc();
                /*0x3b702a0*/ bool IsEmpty();
                /*0x1ffc854*/ T Get<T>();
                /*0x1ffc854*/ void Release<T>(T value);
                /*0x3b70314*/ void Cleanup();

                class SharedObjectPoolBase
                {
                    /*0x3b7059c*/ SharedObjectPoolBase();
                    /*0x3b705a4*/ void Clear();
                }

                class SharedObjectPool<T> : UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase
                {
                    static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

                    static /*0x1f33998*/ SharedObjectPool();
                    static /*0x1f327a0*/ UnityEngine.Pool.ObjectPool<T> AllocatePool();
                    static /*0x1ffc854*/ T Get();
                    static /*0x1ffc854*/ void Release(T toRelease);
                    /*0x1f309e4*/ SharedObjectPool();
                    /*0x1f309e4*/ void Clear();

                    class <>c<T>
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool.<>c<T> <>9;
                        static /*0x0*/ System.Func<T> <>9__1_0;

                        static /*0x1f33998*/ <>c();
                        /*0x1f309e4*/ <>c();
                        /*0x1ffc854*/ T <AllocatePool>b__1_0();
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

                static /*0x3b735d8*/ void ComputeHashForTextureAccess(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, ref UnityEngine.Rendering.RenderGraphModule.TextureAccess textureAccess);
                /*0x3b706d8*/ RenderGraphPass();
                /*0x1f30ebc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x1f2fe14*/ bool HasRenderFunc();
                /*0x1f2ffc8*/ int GetRenderFuncHash();
                /*0x3b705a8*/ string get_name();
                /*0x3b705b0*/ void set_name(string value);
                /*0x3b705b8*/ int get_index();
                /*0x3b705c0*/ void set_index(int value);
                /*0x3b705c8*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType get_type();
                /*0x3b705d0*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType value);
                /*0x3b705d8*/ UnityEngine.Rendering.ProfilingSampler get_customSampler();
                /*0x3b705e0*/ void set_customSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0x3b705e8*/ bool get_enableAsyncCompute();
                /*0x3b705f0*/ void set_enableAsyncCompute(bool value);
                /*0x3b705f8*/ bool get_allowPassCulling();
                /*0x3b70600*/ void set_allowPassCulling(bool value);
                /*0x3b70608*/ bool get_allowGlobalState();
                /*0x3b70610*/ void set_allowGlobalState(bool value);
                /*0x3b70618*/ bool get_enableFoveatedRasterization();
                /*0x3b70620*/ void set_enableFoveatedRasterization(bool value);
                /*0x3b70628*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess get_depthAccess();
                /*0x3b7063c*/ void set_depthAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess value);
                /*0x3b70658*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_colorBufferAccess();
                /*0x3b70660*/ void set_colorBufferAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x3b70668*/ int get_colorBufferMaxIndex();
                /*0x3b70670*/ void set_colorBufferMaxIndex(int value);
                /*0x3b70678*/ UnityEngine.Rendering.RenderGraphModule.TextureAccess[] get_fragmentInputAccess();
                /*0x3b70680*/ void set_fragmentInputAccess(UnityEngine.Rendering.RenderGraphModule.TextureAccess[] value);
                /*0x3b70688*/ int get_fragmentInputMaxIndex();
                /*0x3b70690*/ void set_fragmentInputMaxIndex(int value);
                /*0x3b70698*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] get_randomAccessResource();
                /*0x3b706a0*/ void set_randomAccessResource(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass.RandomWriteResourceInfo[] value);
                /*0x3b706a8*/ int get_randomAccessResourceMaxIndex();
                /*0x3b706b0*/ void set_randomAccessResourceMaxIndex(int value);
                /*0x3b706b8*/ bool get_generateDebugData();
                /*0x3b706c0*/ void set_generateDebugData(bool value);
                /*0x3b706c8*/ bool get_allowRendererListCulling();
                /*0x3b706d0*/ void set_allowRendererListCulling(bool value);
                /*0x3b70a6c*/ void Clear();
                /*0x3b70da4*/ bool HasRenderAttachments();
                /*0x3b70f80*/ bool IsTransient(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b71110*/ bool IsWritten(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b712a0*/ bool IsRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b714e4*/ bool IsAttachment(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle res);
                /*0x3b71744*/ void AddResourceWrite(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b71834*/ void AddResourceRead(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b71924*/ void AddTransientResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b71a14*/ void UseRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x3b71a88*/ void EnableAsyncCompute(bool value);
                /*0x3b71a90*/ void AllowPassCulling(bool value);
                /*0x3b71a98*/ void EnableFoveatedRasterization(bool value);
                /*0x3b71aa0*/ void AllowRendererListCulling(bool value);
                /*0x3b71aa8*/ void AllowGlobalState(bool value);
                /*0x3b71ab0*/ void GenerateDebugData(bool value);
                /*0x3b71ab8*/ void SetColorBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index);
                /*0x3b71b68*/ void SetColorBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x3b71dec*/ void SetFragmentInputRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, int index, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x3b72070*/ void SetRandomWriteResourceRaw(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, int index, bool preserveCounterValue, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags);
                /*0x3b722bc*/ void SetDepthBuffer(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.DepthAccess flags);
                /*0x3b7232c*/ void SetDepthBufferRaw(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Rendering.RenderGraphModule.AccessFlags accessFlags, int mipLevel, int depthSlice);
                /*0x3b724e8*/ void ComputeTextureHash(ref UnityEngine.Rendering.HashFNV1A32 generator, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                /*0x3b72cec*/ void ComputeHash(ref UnityEngine.Rendering.HashFNV1A32 generator, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);

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

                /*0x1f309e4*/ BaseRenderGraphPass();
                /*0x1ffc854*/ void Initialize(int passIndex, PassData passData, string passName, UnityEngine.Rendering.RenderGraphModule.RenderGraphPassType passType, UnityEngine.Rendering.ProfilingSampler sampler);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                /*0x1f2fe14*/ bool HasRenderFunc();
                /*0x1f2ffc8*/ int GetRenderFuncHash();
            }

            class RenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RenderGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphContext c;

                static /*0x1f33998*/ RenderGraphPass();
                /*0x1f309e4*/ RenderGraphPass();
                /*0x1f30ebc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class ComputeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext c;

                static /*0x1f33998*/ ComputeRenderGraphPass();
                /*0x1f309e4*/ ComputeRenderGraphPass();
                /*0x1f30ebc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class RasterRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RasterGraphContext c;

                static /*0x1f33998*/ RasterRenderGraphPass();
                /*0x1f309e4*/ RasterRenderGraphPass();
                /*0x1f30ebc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
            }

            class UnsafeRenderGraphPass<PassData> : UnityEngine.Rendering.RenderGraphModule.BaseRenderGraphPass<PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext>
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext c;

                static /*0x1f33998*/ UnsafeRenderGraphPass();
                /*0x1f309e4*/ UnsafeRenderGraphPass();
                /*0x1f30ebc*/ void Execute(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext renderGraphContext);
                /*0x1f30ebc*/ void Release(UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
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

                static /*0x3b73a20*/ RayTracingAccelerationStructureHandle();
                static /*0x3b73680*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle get_nullHandle();
                static /*0x3b737d0*/ UnityEngine.Rendering.RayTracingAccelerationStructure op_Implicit(UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x3b736dc*/ RayTracingAccelerationStructureHandle(int handle);
                /*0x3b738b0*/ bool IsValid();
            }

            struct RayTracingAccelerationStructureDesc
            {
                /*0x10*/ string name;
            }

            class RayTracingAccelerationStructureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc, UnityEngine.Rendering.RayTracingAccelerationStructure>
            {
                /*0x3b73a2c*/ RayTracingAccelerationStructureResource();
                /*0x3b73a24*/ string GetName();
            }

            struct BufferHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;

                static /*0x3b73d74*/ BufferHandle();
                static /*0x3b73a74*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle get_nullHandle();
                static /*0x3b73b24*/ UnityEngine.GraphicsBuffer op_Implicit(UnityEngine.Rendering.RenderGraphModule.BufferHandle buffer);
                /*0x3b73ad0*/ BufferHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x3b73ae4*/ BufferHandle(int handle, bool shared);
                /*0x3b73c04*/ bool IsValid();
            }

            struct BufferDesc
            {
                /*0x10*/ int count;
                /*0x14*/ int stride;
                /*0x18*/ string name;
                /*0x20*/ UnityEngine.GraphicsBuffer.Target target;
                /*0x24*/ UnityEngine.GraphicsBuffer.UsageFlags usageFlags;

                /*0x3b73d78*/ BufferDesc(int count, int stride);
                /*0x3b73d98*/ BufferDesc(int count, int stride, UnityEngine.GraphicsBuffer.Target target);
                /*0x3b73dac*/ int GetHashCode();
            }

            class BufferResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.BufferDesc, UnityEngine.GraphicsBuffer>
            {
                /*0x3b74188*/ BufferResource();
                /*0x3b73df4*/ string GetName();
                /*0x3b73e48*/ int GetDescHashCode();
                /*0x3b73e90*/ void CreateGraphicsResource();
                /*0x3b73f28*/ void UpdateGraphicsResource();
                /*0x3b73f5c*/ void ReleaseGraphicsResource();
                /*0x3b73fd0*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x3b740ac*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class BufferPool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.GraphicsBuffer>
            {
                /*0x3b742cc*/ BufferPool();
                /*0x3b741d0*/ void ReleaseInternalResource(UnityEngine.GraphicsBuffer res);
                /*0x3b741e8*/ string GetResourceName(ref UnityEngine.GraphicsBuffer res);
                /*0x3b74228*/ long GetResourceSize(ref UnityEngine.GraphicsBuffer res);
                /*0x3b7426c*/ string GetResourceTypeName();
                /*0x3b742ac*/ int GetSortIndex(UnityEngine.GraphicsBuffer res);
            }

            class IRenderGraphResourcePool
            {
                /*0x3b74338*/ IRenderGraphResourcePool();
                /*0x1f30b78*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x1f309e4*/ void Cleanup();
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x1f30ebc*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class RenderGraphResourcePool<Type> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool
            {
                static int kStaleResourceLifetime = 10;
                static /*0x0*/ System.Collections.Generic.List<int> s_ToRemoveList;
                /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<Type, int>>> m_ResourcePool;
                /*0x0*/ System.Collections.Generic.List<System.ValueTuple<int, Type>> m_FrameAllocatedResources;

                static /*0x1f33998*/ RenderGraphResourcePool();
                /*0x1f309e4*/ RenderGraphResourcePool();
                /*0x1ffc854*/ void ReleaseInternalResource(Type res);
                /*0x1f302cc*/ string GetResourceName(ref Type res);
                long GetResourceSize(ref Type res);
                /*0x1f30214*/ string GetResourceTypeName();
                /*0x1ffc854*/ int GetSortIndex(Type res);
                /*0x1ffc854*/ void ReleaseResource(int hash, Type resource, int currentFrameIndex);
                /*0x1f2fe80*/ bool TryGetResource(int hashCode, ref Type resource);
                /*0x1f309e4*/ void Cleanup();
                /*0x1ffc854*/ void RegisterFrameAllocation(int hash, Type value);
                /*0x1ffc854*/ void UnregisterFrameAllocation(int hash, Type value);
                void CheckFrameAllocation(bool onException, int frameIndex);
                /*0x1f30ebc*/ void LogResources(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x1f30b78*/ void PurgeUnusedResources(int currentFrameIndex);

                struct ResourceLogInfo<Type>
                {
                    /*0x0*/ string name;
                    /*0x0*/ long size;
                }

                class <>c<Type>
                {
                    static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.<>c<Type> <>9;
                    static /*0x0*/ System.Comparison<UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__15_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1ffc854*/ int <LogResources>b__15_0(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> a, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> b);
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

                static /*0x3b7a1c0*/ RenderGraphResourceRegistry();
                static /*0x3b74340*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current();
                static /*0x3b74398*/ void set_current(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry value);
                /*0x3b74cf8*/ RenderGraphResourceRegistry();
                /*0x3b74ea0*/ RenderGraphResourceRegistry(UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger);
                /*0x3b74400*/ void CheckTextureResource(UnityEngine.Rendering.RenderGraphModule.TextureResource texResource);
                /*0x3b744b8*/ UnityEngine.Rendering.RTHandle GetTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x3b745dc*/ UnityEngine.Rendering.RTHandle GetTexture(int index);
                /*0x3b746c0*/ bool TextureNeedsFallback(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle handle);
                /*0x3b747f4*/ UnityEngine.Rendering.RendererList GetRendererList(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                /*0x3b74938*/ void CheckBufferResource(UnityEngine.Rendering.RenderGraphModule.BufferResource bufferResource);
                /*0x3b73cd4*/ UnityEngine.GraphicsBuffer GetBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferHandle handle);
                /*0x3b74ae0*/ UnityEngine.GraphicsBuffer GetBuffer(int index);
                /*0x3b73980*/ UnityEngine.Rendering.RayTracingAccelerationStructure GetRayTracingAccelerationStructure(ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle handle);
                /*0x3b74cc0*/ int GetSharedResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x3b755d4*/ void BeginRenderGraph(int executionCount);
                /*0x3b75740*/ void BeginExecute(int currentFrameIndex);
                /*0x3b75948*/ void EndExecute();
                /*0x3b759dc*/ void CheckHandleValidity(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b759e0*/ void CheckHandleValidity(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x3b75b9c*/ void IncrementWriteCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b75c8c*/ void IncrementReadCount(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b75d7c*/ void NewVersion(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b75e6c*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetLatestVersionHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b76078*/ int GetLatestVersionNumber(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b76188*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetZeroVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b761b8*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle GetNewVersionedHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b762f8*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource GetResourceLowLevel(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b763dc*/ string GetRenderGraphResourceName(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b764cc*/ string GetRenderGraphResourceName(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x3b7299c*/ bool IsRenderGraphResourceImported(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b76568*/ bool IsRenderGraphResourceForceReleased(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x3b76600*/ bool IsRenderGraphResourceShared(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x3b75fa0*/ bool IsRenderGraphResourceShared(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b76640*/ bool IsGraphicsResourceCreated(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b76730*/ bool IsRendererListCreated(ref UnityEngine.Rendering.RenderGraphModule.RendererListHandle res);
                /*0x3b7684c*/ bool IsRenderGraphResourceImported(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                /*0x3b768e4*/ int GetRenderGraphResourceTransientIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b769d0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, bool isBuiltin);
                /*0x3b769f4*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams, bool isBuiltin);
                /*0x3b76db0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportTexture(ref UnityEngine.Rendering.RTHandle rt, UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x3b76f84*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                /*0x3b7717c*/ void RefreshSharedTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b771d0*/ void ReleaseSharedTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b77298*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.ImportResourceParams importParams);
                /*0x3b77474*/ void ValidateRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res);
                /*0x3b77530*/ void GetRenderTargetInfo(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle res, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo outInfo);
                /*0x3b77900*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x3b77a08*/ void ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat color, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencil);
                /*0x3b77afc*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, int transientPassIndex);
                /*0x3b77bf0*/ int GetResourceCount(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type);
                /*0x3b77c60*/ int GetTextureResourceCount();
                /*0x3b72a88*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b745f8*/ UnityEngine.Rendering.RenderGraphModule.TextureResource GetTextureResource(int index);
                /*0x3b72b7c*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x3b77c68*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x3b77dc0*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererListParams desc);
                /*0x3b77e98*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateShadowRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.ShadowDrawingSettings shadowDrawinSettings);
                /*0x3b77f64*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateGizmoRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.GizmoSubset gizmoSubset);
                /*0x3b78040*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateUIOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, ref UnityEngine.Rendering.UISubset uiSubset);
                /*0x3b7811c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateWireOverlayRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x3b781ec*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera);
                /*0x3b782bc*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
                /*0x3b783e4*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
                /*0x3b78568*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle ImportBuffer(UnityEngine.GraphicsBuffer graphicsBuffer, bool forceRelease);
                /*0x3b78654*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle CreateBuffer(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc, int transientPassIndex);
                /*0x3b78744*/ UnityEngine.Rendering.RenderGraphModule.BufferDesc GetBufferResourceDesc(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle, bool noThrowOnInvalidDesc);
                /*0x3b788bc*/ int GetBufferResourceCount();
                /*0x3b749e8*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b74afc*/ UnityEngine.Rendering.RenderGraphModule.BufferResource GetBufferResource(int index);
                /*0x3b74bc8*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureResource GetRayTracingAccelerationStructureResource(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b788c4*/ int GetRayTracingAccelerationStructureResourceCount();
                /*0x3b788cc*/ UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(ref UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct, string name);
                /*0x3b789bc*/ void UpdateSharedResourceLastFrameIndex(int type, int index);
                /*0x3b78a58*/ void UpdateSharedResourceLastFrameIndex(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b757f0*/ void ManageSharedRenderGraphResources();
                /*0x3b78ac0*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x3b78cc8*/ bool CreatePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b78d74*/ bool CreateTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x3b78fac*/ void ClearResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x3b78e60*/ void ClearTexture(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.TextureResource resource);
                /*0x3b7909c*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, int type, int index);
                /*0x3b791d4*/ void ReleasePooledResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                /*0x3b79280*/ void ReleaseTextureCallback(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                /*0x3b793cc*/ void ValidateTextureDesc(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc);
                /*0x3b795b4*/ void ValidateRendererListDesc(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x3b79778*/ void ValidateBufferDesc(ref UnityEngine.Rendering.RenderGraphModule.BufferDesc desc);
                /*0x3b79884*/ void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, bool manualDispatch);
                /*0x3b79bf4*/ void Clear(bool onException);
                /*0x3b79f84*/ void PurgeUnusedGraphicsResources();
                /*0x3b7a004*/ void Cleanup();
                /*0x3b7a150*/ void FlushLogs();
                /*0x3b79d3c*/ void LogResources();

                class ResourceCreateCallback : System.MulticastDelegate
                {
                    /*0x3b75350*/ ResourceCreateCallback(object object, nint method);
                    /*0x3b7a24c*/ bool Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x3b7a260*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x3b7a288*/ bool EndInvoke(System.IAsyncResult result);
                }

                class ResourceCallback : System.MulticastDelegate
                {
                    /*0x3b7545c*/ ResourceCallback(object object, nint method);
                    /*0x3b7a2b0*/ void Invoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x3b7a2c4*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                    /*0x3b7a2ec*/ void EndInvoke(System.IAsyncResult result);
                }

                class RenderGraphResourcesData
                {
                    /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;
                    /*0x18*/ int sharedResourcesCount;
                    /*0x20*/ UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;
                    /*0x28*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback;
                    /*0x30*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;

                    /*0x3b75294*/ RenderGraphResourcesData();
                    /*0x3b79eec*/ void Clear(bool onException, int frameIndex);
                    /*0x3b7a09c*/ void Cleanup();
                    /*0x3b79fec*/ void PurgeUnusedGraphicsResources(int frameIndex);
                    /*0x1ffc854*/ int AddNewRenderGraphResource<ResType>(ref ResType outRes, bool pooledResource);
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

                static /*0x3b74930*/ int op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle handle);
                static /*0x3b7a308*/ UnityEngine.Rendering.RendererList op_Implicit(UnityEngine.Rendering.RenderGraphModule.RendererListHandle rendererList);
                /*0x3b77dac*/ RendererListHandle(int handle, UnityEngine.Rendering.RenderGraphModule.RendererListHandleType type);
                /*0x3b7a2f8*/ int get_handle();
                /*0x3b7a300*/ void set_handle(int value);
                /*0x3b7a40c*/ bool IsValid();
            }

            struct RendererListResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererListParams desc;
                /*0x140*/ UnityEngine.Rendering.RendererList rendererList;

                /*0x3b77d8c*/ RendererListResource(ref UnityEngine.Rendering.RendererListParams desc);
            }

            struct RendererListLegacyResource
            {
                /*0x10*/ UnityEngine.Rendering.RendererList rendererList;
                /*0x28*/ bool isActive;

                /*0x3b7a414*/ RendererListLegacyResource(ref bool active);
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

                static /*0x3b7a648*/ ResourceHandle();
                static /*0x3b75680*/ void NewFrame(int executionIndex);
                /*0x3b7371c*/ ResourceHandle(int value, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType type, bool shared);
                /*0x3b76008*/ ResourceHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int version);
                /*0x3b7a430*/ int get_index();
                /*0x3b7a438*/ int get_iType();
                /*0x3b7a48c*/ int get_version();
                /*0x3b7a494*/ void set_version(int value);
                /*0x3b7a49c*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType get_type();
                /*0x3b7a4a4*/ void set_type(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceType value);
                /*0x3b7a4ac*/ bool IsValid();
                /*0x3b7a54c*/ bool IsNull();
                /*0x3b7a5a8*/ bool get_IsVersioned();
                /*0x3b7a5b8*/ bool Equals(UnityEngine.Rendering.RenderGraphModule.ResourceHandle hdl);
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

                /*0x3b7a780*/ IRenderGraphResource();
                /*0x3b7a698*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool _);
                /*0x3b7a6b8*/ string GetName();
                /*0x3b7a6f8*/ bool IsCreated();
                /*0x3b7a700*/ void IncrementWriteCount();
                /*0x3b7a710*/ void IncrementReadCount();
                /*0x3b7a720*/ int NewVersion();
                /*0x3b7a734*/ bool NeedsFallBack();
                /*0x3b7a754*/ void CreatePooledGraphicsResource();
                /*0x3b7a758*/ void CreateGraphicsResource();
                /*0x3b7a75c*/ void UpdateGraphicsResource();
                /*0x3b7a760*/ void ReleasePooledGraphicsResource(int frameIndex);
                /*0x3b7a764*/ void ReleaseGraphicsResource();
                /*0x3b7a768*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x3b7a76c*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x3b7a770*/ int GetSortIndex();
                /*0x3b7a778*/ int GetDescHashCode();
            }

            class RenderGraphResource<DescType, ResType> : UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource
            {
                /*0x0*/ DescType desc;
                /*0x0*/ bool validDesc;
                /*0x0*/ ResType graphicsResource;
                /*0x0*/ UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<ResType> m_Pool;

                /*0x1f309e4*/ RenderGraphResource();
                /*0x1f30ebc*/ void Reset(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                /*0x1f2fe14*/ bool IsCreated();
                /*0x1f309e4*/ void ReleaseGraphicsResource();
                /*0x1f309e4*/ void CreatePooledGraphicsResource();
                /*0x1f30b78*/ void ReleasePooledGraphicsResource(int frameIndex);
            }

            struct TextureAccess
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle textureHandle;
                /*0x20*/ int mipLevel;
                /*0x24*/ int depthSlice;
                /*0x28*/ UnityEngine.Rendering.RenderGraphModule.AccessFlags flags;

                /*0x3b7231c*/ TextureAccess(UnityEngine.Rendering.RenderGraphModule.TextureHandle handle, UnityEngine.Rendering.RenderGraphModule.AccessFlags flags, int mipLevel, int depthSlice);
            }

            struct TextureHandle
            {
                static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle s_NullHandle;
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle;
                /*0x1c*/ bool builtin;

                static /*0x3b7af34*/ TextureHandle();
                static /*0x3b7a788*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_nullHandle();
                static /*0x3b7a7f8*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x3b7a9a4*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x3b7ab20*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                static /*0x3b7ac9c*/ UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Rendering.RenderGraphModule.TextureHandle texture);
                /*0x3b7a7e0*/ TextureHandle(ref UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                /*0x3b76d60*/ TextureHandle(int handle, bool shared, bool builtin);
                /*0x3b7ae14*/ bool IsValid();
                /*0x3b7aee4*/ bool IsBuiltin();
                /*0x3b7aeec*/ UnityEngine.Rendering.RenderGraphModule.TextureDesc GetDescriptor(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
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

                /*0x3b7b16c*/ TextureDesc(int width, int height, bool dynamicResolution, bool xrReady);
                /*0x3b7b198*/ TextureDesc(UnityEngine.Vector2 scale, bool dynamicResolution, bool xrReady);
                /*0x3b7b1c8*/ TextureDesc(UnityEngine.Rendering.ScaleFunc func, bool dynamicResolution, bool xrReady);
                /*0x3b7b22c*/ TextureDesc(UnityEngine.Rendering.RenderGraphModule.TextureDesc input);
                /*0x3b7b24c*/ TextureDesc(UnityEngine.RenderTextureDescriptor input);
                /*0x3b76c84*/ TextureDesc(UnityEngine.RenderTexture input);
                /*0x3b7af38*/ UnityEngine.Rendering.DepthBits get_depthBufferBits();
                /*0x3b7af94*/ void set_depthBufferBits(UnityEngine.Rendering.DepthBits value);
                /*0x3b7b028*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_colorFormat();
                /*0x3b7b098*/ void set_colorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
                /*0x3b7b0a0*/ void InitDefaultValues(bool dynamicResolution, bool xrReady);
                /*0x3b7b3d8*/ int GetHashCode();
                /*0x3b7790c*/ UnityEngine.Vector2Int CalculateFinalDimensions();
            }

            class TextureResource : UnityEngine.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Rendering.RenderGraphModule.TextureDesc, UnityEngine.Rendering.RTHandle>
            {
                static /*0x0*/ int m_TextureCreationIndex;

                /*0x3b7bcc8*/ TextureResource();
                /*0x3b7b5c4*/ string GetName();
                /*0x3b7b630*/ int GetDescHashCode();
                /*0x3b7b638*/ void CreateGraphicsResource();
                /*0x3b7ba34*/ void UpdateGraphicsResource();
                /*0x3b7ba68*/ void ReleaseGraphicsResource();
                /*0x3b7badc*/ void LogCreation(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
                /*0x3b7bbec*/ void LogRelease(UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger logger);
            }

            class TexturePool : UnityEngine.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.Rendering.RTHandle>
            {
                /*0x3b75568*/ TexturePool();
                /*0x3b7bd10*/ void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res);
                /*0x3b7bd28*/ string GetResourceName(ref UnityEngine.Rendering.RTHandle res);
                /*0x3b7bd4c*/ long GetResourceSize(ref UnityEngine.Rendering.RTHandle res);
                /*0x3b7bd68*/ string GetResourceTypeName();
                /*0x3b7bda8*/ int GetSortIndex(UnityEngine.Rendering.RTHandle res);
            }

            namespace Util
            {
                class RenderGraphUtils
                {
                    static string DisableTexture2DXArray = "DISABLE_TEXTURE2D_X_ARRAY";
                    static /*0x0*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
                    static /*0x8*/ UnityEngine.Vector4 s_BlitScaleBias;

                    static /*0x3b7e1e8*/ RenderGraphUtils();
                    static /*0x3b7bdc0*/ bool CanAddCopyPassMSAA();
                    static /*0x3b7be90*/ bool CanAddCopyPassMSAA(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc sourceDesc);
                    static /*0x3b7bf24*/ bool IsFramebufferFetchEmulationSupportedOnCurrentPlatform();
                    static /*0x3b7be4c*/ bool IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform();
                    static /*0x3b7bf2c*/ bool IsFramebufferFetchSupportedOnCurrentPlatform(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, ref UnityEngine.Rendering.RenderGraphModule.TextureHandle tex);
                    static /*0x3b7bfe0*/ void AddCopyPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, string passName, string file, int line);
                    static /*0x3b7c650*/ void AddCopyPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, int sourceSlice, int destinationSlice, int sourceMip, int destinationMip, string passName, string file, int line);
                    static /*0x3b7c6f8*/ void CopyRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext rgContext);
                    static /*0x3b7c774*/ bool IsTextureXR(ref UnityEngine.Rendering.RenderGraphModule.TextureDesc destDesc, int sourceSlice, int destinationSlice, int numSlices, int numMips);
                    static /*0x3b7c8bc*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceSlice, int destinationSlice, int numSlices, int sourceMip, int destinationMip, int numMips, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitFilterMode filterMode, string passName, string file, int line);
                    static /*0x3b7cf40*/ void BlitRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    static /*0x3b7d248*/ void AddBlitPass(UnityEngine.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialParameters blitParameters, string passName, string file, int line);
                    static /*0x3b7dc5c*/ void BlitMaterialRenderFunc(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);

                    class CopyPassData
                    {
                        /*0x10*/ bool isMSAA;
                        /*0x11*/ bool force2DForXR;

                        /*0x3b7e274*/ CopyPassData();
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
                        /*0x5c*/ bool isXR;

                        /*0x3b7e27c*/ BlitPassData();
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

                        static /*0x3b7ea50*/ BlitMaterialParameters();
                        /*0x3b7e284*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass);
                        /*0x3b7e3a4*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass);
                        /*0x3b7e4a8*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x3b7e624*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices, int numMips, int sourceSlice, int sourceMip, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
                        /*0x3b7e7c0*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID);
                        /*0x3b7e91c*/ BlitMaterialParameters(UnityEngine.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.RenderGraphModule.TextureHandle destination, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock mpb, UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.FullScreenGeometryType geometry, int sourceTexturePropertyID, int sourceSlicePropertyID, int sourceMipPropertyID, int scaleBiasPropertyID);
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
                        /*0x88*/ bool isXR;

                        /*0x3b7eb58*/ BlitMaterialPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__8_0;
                        static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__14_0;
                        static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__20_0;

                        static /*0x3b7eb60*/ <>c();
                        /*0x3b7ebc8*/ <>c();
                        /*0x3b7ebd0*/ void <AddCopyPass>b__8_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.CopyPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext context);
                        /*0x3b7ec3c*/ void <AddBlitPass>b__14_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                        /*0x3b7eca0*/ void <AddBlitPass>b__20_0(UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils.BlitMaterialPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    }
                }

                class RenderGraphUtilsResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtilsResources.Version m_Version;
                    /*0x18*/ UnityEngine.Shader m_CoreCopyPS;

                    /*0x3b7ed88*/ RenderGraphUtilsResources();
                    /*0x3b7ed04*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
                    /*0x3b7ed0c*/ UnityEngine.Shader get_coreCopyPS();
                    /*0x3b7ed14*/ void set_coreCopyPS(UnityEngine.Shader value);

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

                    /*0x3b7ed90*/ Name(string name, bool computeUTF8ByteCount);
                }

                class NativeListExtensions
                {
                    static /*0x1ffc854*/ System.ReadOnlySpan<T> MakeReadOnlySpan<T>(ref Unity.Collections.NativeList<T> list, int first, int numElements);
                    static /*0x1f31f88*/ int LastIndex<T>(ref Unity.Collections.NativeList<T> list);
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
                    /*0x70*/ bool m_AreNativeListsAllocated;

                    /*0x3b7ee40*/ CompilerContextData();
                    /*0x3b7ef5c*/ void AllocateNativeDataStructuresIfNeeded(int estimatedNumPasses);
                    /*0x3b7f1dc*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resourceRegistry, int estimatedNumPasses);
                    /*0x3b7f264*/ void Clear();
                    /*0x3b7f42c*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData UnversionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b7f504*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData VersionedResourceData(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b7f520*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> Readers(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b7f674*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData ResourceReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int i);
                    /*0x3b7f7b8*/ bool AddToFragmentList(UnityEngine.Rendering.RenderGraphModule.TextureAccess access, int listFirstIndex, int numItems);
                    /*0x3b7f8f0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetFullPassName(int passId);
                    /*0x3b7f954*/ string GetPassName(int passId);
                    /*0x3b7f9b4*/ string GetResourceName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b7fa98*/ string GetResourceVersionedName(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b7fb5c*/ bool AddToRandomAccessResourceList(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems);
                    /*0x3b7fd80*/ void TagAllPasses(int value);
                    /*0x3b7fe30*/ void CullAllPasses(bool isCulled);
                    /*0x3b7fee0*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator get_NativePasses();
                    /*0x3b7ff30*/ System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData> GetNativePasses();
                    /*0x3b80160*/ void Finalize();
                    /*0x3b80354*/ void Dispose();
                    /*0x3b801e4*/ void Cleanup();

                    struct NativePassIterator
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData m_Ctx;
                        /*0x18*/ int m_Index;

                        /*0x3b7ff10*/ NativePassIterator(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                        /*0x3b80040*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData get_Current();
                        /*0x3b80098*/ bool MoveNext();
                        /*0x3b80034*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData.NativePassIterator GetEnumerator();
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

                    static /*0x1f33998*/ FixedAttachmentArray();
                    /*0x1f30b78*/ FixedAttachmentArray(int numAttachments);
                    /*0x1f30ebc*/ FixedAttachmentArray(DataType[] attachments);
                    /*0x1ffc854*/ FixedAttachmentArray(Unity.Collections.NativeArray<DataType> attachments);
                    /*0x1f2ffc8*/ int get_size();
                    /*0x1f309e4*/ void Clear();
                    /*0x1f3008c*/ int Add(ref DataType data);
                    /*0x1f30240*/ ref DataType get_Item(int index);
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
                    /*0x60*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> graphPassNamesForDebug;

                    static /*0x3b833cc*/ bool IsGlobalTextureInPass(UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, UnityEngine.Rendering.RenderGraphModule.ResourceHandle handle);
                    static /*0x3b835b8*/ bool IsSameNativeSubPass(ref UnityEngine.Rendering.SubPassDescriptor a, ref UnityEngine.Rendering.SubPassDescriptor b);
                    static /*0x3b85764*/ UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo MakeAttachmentInfo(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int attachmentIndex);
                    static /*0x3b85c44*/ string MakePassBreakInfoMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    static /*0x3b85d64*/ string MakePassMergeMessage(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData prevPass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit mergeResult);
                    static /*0x3b86498*/ string InjectSpaces(string camelCaseString);
                    /*0x3b803b4*/ NativePassCompiler(RenderGraphCompilationCache cache);
                    /*0x3b804e8*/ void Finalize();
                    /*0x3b805ec*/ void Dispose();
                    /*0x3b8056c*/ void Cleanup();
                    /*0x3b8064c*/ bool Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> renderPasses, bool disableCulling, string debugName, bool useCompilationCaching, int graphHash, int frameIndex);
                    /*0x3b80778*/ void Compile(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x3b80714*/ void Clear(bool clearContextData);
                    /*0x3b82d80*/ void SetPassStatesForNativePass(int nativePassId);
                    /*0x3b807b8*/ void SetupContextData(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x3b808b0*/ void BuildGraph();
                    /*0x3b817ac*/ void CullUnusedRenderPasses();
                    /*0x3b81c44*/ void TryMergeNativePasses();
                    /*0x3b81f8c*/ void FindResourceUsageRanges();
                    /*0x3b82cbc*/ void PrepareNativeRenderPasses();
                    /*0x3b82810*/ void DetectMemoryLessResources();
                    /*0x3b83764*/ void ExecuteInitializeResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x3b82d8c*/ void DetermineLoadStoreActions(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x3b83c7c*/ void ValidateNativePass(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount);
                    /*0x3b83e54*/ void ValidateAttachmentRenderTarget(ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo attRenderTargetInfo, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples);
                    /*0x3b83f6c*/ void ExecuteBeginRenderPass(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass);
                    /*0x3b846f8*/ void ExecuteDestroyResource(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass);
                    /*0x3b84b04*/ void ExecuteSetRandomWriteTarget(ref UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, int index, UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource, bool preserveCounterValue);
                    /*0x3b84d08*/ void ExecuteGraphNode(ref UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x3b850a8*/ void ExecuteGraph(UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext rgContext, UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, ref System.Collections.Generic.List<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass> passes);
                    /*0x3b86610*/ void GenerateNativeCompilerDebugData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraph.DebugData debugData);

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
                        NRPRGComp_ExecuteInitializeResources = 7,
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

                    static /*0x3b8a21c*/ bool SameSubResource(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData x, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData y);
                    /*0x3b8a164*/ int GetHashCode();
                }

                struct PassRandomWriteData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderGraphModule.ResourceHandle resource;
                    /*0x1c*/ int index;
                    /*0x20*/ bool preserveCounterValue;

                    /*0x3b8a2b4*/ int GetHashCode();
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

                    /*0x3b8a3a4*/ PassData(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x3b8a33c*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a414*/ void ResetAndInitialize(ref UnityEngine.Rendering.RenderGraphModule.RenderGraphPass pass, int passIndex);
                    /*0x3b8a484*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassOutputData> Outputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a4dc*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassInputData> Inputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a534*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> Fragments(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a58c*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData> FragmentInputs(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a5e4*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> FirstUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a63c*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassRandomWriteData> RandomWriteTextures(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a694*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.ResourceHandle> LastUsedResources(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a6ec*/ void SetupAndValidateFragmentInfo(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a72c*/ void AddFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a750*/ void AddFragmentInput(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a774*/ void AddRandomAccessResource();
                    /*0x3b8a784*/ void AddFirstUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8a924*/ void AddLastUse(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8aac4*/ bool IsUsedAsFragment(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
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

                    static /*0x3b8ac58*/ LoadAudit();
                    /*0x3b8ac50*/ LoadAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.LoadReason setReason, int setPassId);
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

                    static /*0x3b8ae18*/ StoreAudit();
                    /*0x3b8ae0c*/ StoreAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setReason, int setPassId, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.StoreReason setMsaaReason, int setMsaaPassId);
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

                    static /*0x3b8b008*/ PassBreakAudit();
                    /*0x3b8b000*/ PassBreakAudit(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakReason reason, int breakPass);
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

                    static /*0x3b8c0f4*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit CanMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x3b8c99c*/ bool CanMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x3b8b4c8*/ void TryMergeNativeSubPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData nativePass, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData passToMerge);
                    static /*0x3b8d2b4*/ UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassBreakAudit TryMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int activeNativePassId, int passIdToMerge);
                    static /*0x3b8d830*/ void SetPassStatesForNativePass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, int nativePassId);
                    /*0x3b8b2f4*/ NativePassData(ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData pass, UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8bb90*/ UnityEngine.Rendering.SubPassFlags GetSubPassFlagForMerging();
                    /*0x3b8bc78*/ void Clear();
                    /*0x3b8bdc0*/ bool IsValid();
                    /*0x3b8bdd0*/ System.ReadOnlySpan<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData> GraphPasses(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx);
                    /*0x3b8bff4*/ void GetGraphPassNames(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> dest);
                    /*0x3b8cf9c*/ void AddDepthAttachmentFirstDuringMerge(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData contextData, ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData depthAttachment);
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

                    /*0x3b8d99c*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RenderTargetInfo info, ref UnityEngine.Rendering.RenderGraphModule.TextureDesc desc, bool isResourceShared);
                    /*0x3b8d9f4*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.BufferDesc _, bool isResourceShared);
                    /*0x3b8da3c*/ ResourceUnversionedData(UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource rll, ref UnityEngine.Rendering.RenderGraphModule.RayTracingAccelerationStructureDesc _, bool isResourceShared);
                    /*0x3b8d978*/ string GetName(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b8da84*/ void InitializeNullResource();
                }

                struct ResourceVersionedData
                {
                    /*0x10*/ bool written;
                    /*0x14*/ int writePassId;
                    /*0x18*/ int numReaders;

                    /*0x3b8da98*/ void SetWritingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                    /*0x3b8daa8*/ void RegisterReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId, int index);
                    /*0x3b8dc14*/ void RemoveReadingPass(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData ctx, UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int passId);
                }

                class ResourcesData
                {
                    /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData> unversionedData;
                    /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData> versionedData;
                    /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceReaderData> readerData;
                    /*0x28*/ int MaxVersions;
                    /*0x2c*/ int MaxReaders;
                    /*0x30*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name> resourceNames;

                    /*0x3b8ded0*/ ResourcesData();
                    /*0x3b8e080*/ void Clear();
                    void AllocateAndResizeNativeListIfNeeded<T>(ref Unity.Collections.NativeList<T> nativeList, int size, Unity.Collections.NativeArrayOptions options);
                    /*0x3b8e1ec*/ void Initialize(UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources);
                    /*0x3b8e968*/ int Index(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b8e9d4*/ int IndexReader(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h, int readerID);
                    /*0x3b8c888*/ ref UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceVersionedData get_Item(UnityEngine.Rendering.RenderGraphModule.ResourceHandle h);
                    /*0x3b8ea48*/ void Dispose();
                }
            }
        }

        namespace LookDev
        {
            interface IDataProvider
            {
                /*0x1f30ebc*/ void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1ffc854*/ void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<string> get_supportedDebugModes();
                /*0x1f30b78*/ void UpdateDebugMode(int debugIndex);
                /*0x1f30ff0*/ void GetShadowMask(ref UnityEngine.RenderTexture output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1f30ebc*/ void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1f30ebc*/ void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1f30ebc*/ void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI);
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

                /*0x3b8eb7c*/ StageRuntimeInterface(System.Func<bool, UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight);
                /*0x3b8ebdc*/ UnityEngine.GameObject AddGameObject(bool persistent);
                /*0x3b8ec20*/ UnityEngine.Camera get_camera();
                /*0x3b8ec54*/ UnityEngine.Light get_sunLight();
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

                /*0x3b8fafc*/ DebugUIHandlerBitField();
                /*0x3b8ec88*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b8f0f4*/ bool GetValue(int index);
                /*0x3b8f1a4*/ void SetValue(int index, bool value);
                /*0x3b8f590*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b8f814*/ void OnDeselection();
                /*0x3b8f840*/ void OnIncrement(bool fast);
                /*0x3b8f85c*/ void OnDecrement(bool fast);
                /*0x3b8f878*/ void OnAction();
                /*0x3b8f89c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerButton : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Button m_Field;

                /*0x3b8fc60*/ DebugUIHandlerButton();
                /*0x3b8fb34*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b8fbd0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b8fc08*/ void OnDeselection();
                /*0x3b8fc34*/ void OnAction();
            }

            class DebugUIPrefabBundle
            {
                /*0x10*/ string type;
                /*0x18*/ UnityEngine.RectTransform prefab;

                /*0x3b8fc7c*/ DebugUIPrefabBundle();
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

                /*0x3b91f04*/ DebugUIHandlerCanvas();
                /*0x3b8fc84*/ void OnEnable();
                /*0x3b8fdfc*/ void Update();
                /*0x3b905a0*/ void RequestHierarchyReset();
                /*0x3b8ff2c*/ void ResetAllHierarchy();
                /*0x3b905ac*/ void Rebuild();
                /*0x3b91024*/ void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, ref UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedHandler);
                /*0x3b916a8*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(string queryPath);
                /*0x3b914a8*/ void ActivatePanel(int index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget);
                /*0x3b91874*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
                /*0x3b91bc0*/ void SelectPreviousItem();
                /*0x3b91c84*/ void SelectNextPanel();
                /*0x3b91cf8*/ void SelectPreviousPanel();
                /*0x3b91afc*/ void SelectNextItem();
                /*0x3b91d78*/ void ChangeSelectionValue(float multiplier);
                /*0x3b91e7c*/ void ActivateSelection();
                /*0x3b90210*/ void HandleInput();
                /*0x3b91a14*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, bool> <>9__12_0;
                    static /*0x10*/ System.Action<UnityEngine.Rendering.UI.DebugUIHandlerPanel> <>9__15_0;

                    static /*0x3b91f0c*/ <>c();
                    /*0x3b91f74*/ <>c();
                    /*0x3b91f7c*/ bool <Rebuild>b__12_0(UnityEngine.Rendering.DebugUI.Widget x);
                    /*0x3b91fc0*/ void <ActivatePanel>b__15_0(UnityEngine.Rendering.UI.DebugUIHandlerPanel p);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string queryPath;

                    /*0x3b91804*/ <>c__DisplayClass14_0();
                    /*0x3b91fec*/ bool <GetWidgetFromPath>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget w);
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

                /*0x3b9295c*/ DebugUIHandlerColor();
                /*0x3b92018*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b92650*/ void SetValue(float x, bool r, bool g, bool b, bool a);
                /*0x3b92460*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x3b92728*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b9280c*/ void OnDeselection();
                /*0x3b92838*/ void OnIncrement(bool fast);
                /*0x3b92854*/ void OnDecrement(bool fast);
                /*0x3b92870*/ void OnAction();
                /*0x3b92590*/ void UpdateColor();
                /*0x3b92894*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x3b92978*/ float <SetWidget>b__9_0();
                /*0x3b929dc*/ void <SetWidget>b__9_1(float x);
                /*0x3b929f0*/ float <SetWidget>b__9_2();
                /*0x3b92a54*/ void <SetWidget>b__9_3(float x);
                /*0x3b92a68*/ float <SetWidget>b__9_4();
                /*0x3b92acc*/ void <SetWidget>b__9_5(float x);
                /*0x3b92ae0*/ float <SetWidget>b__9_6();
                /*0x3b92b44*/ void <SetWidget>b__9_7(float x);
                /*0x3b92b58*/ float <SetupSettings>b__11_0();
                /*0x3b92b70*/ float <SetupSettings>b__11_1();
                /*0x3b92b88*/ float <SetupSettings>b__11_2();
            }

            class DebugUIHandlerContainer : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform contentHolder;

                /*0x3b92f58*/ DebugUIHandlerContainer();
                /*0x3b8fa68*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x3b8f780*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem();
                /*0x3b8f674*/ bool IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
                /*0x3b92ba4*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget widget;

                    /*0x3b92f50*/ <>c__DisplayClass3_0();
                    /*0x3b92f60*/ bool <IsDirectChild>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget x);
                }
            }

            class DebugUIHandlerEnumField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.EnumField>
            {
                /*0x3b93378*/ DebugUIHandlerEnumField();
                /*0x3b92fcc*/ void OnIncrement(bool fast);
                /*0x3b93140*/ void OnDecrement(bool fast);
                /*0x3b932e0*/ void UpdateValueLabel();
            }

            class DebugUIHandlerEnumHistory : UnityEngine.Rendering.UI.DebugUIHandlerEnumField
            {
                static float k_XOffset = 230;
                /*0x88*/ UnityEngine.UI.Text[] historyValues;

                /*0x3b9391c*/ DebugUIHandlerEnumHistory();
                /*0x3b933c0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b9366c*/ void UpdateValueLabel();
                /*0x3b93888*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory <>4__this;

                    /*0x3b938f4*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x3b93920*/ void System.IDisposable.Dispose();
                    /*0x3b93924*/ bool MoveNext();
                    /*0x3b93a24*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3b93a2c*/ void System.Collections.IEnumerator.Reset();
                    /*0x3b93a64*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerField<T> : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x0*/ UnityEngine.UI.Text nextButtonText;
                /*0x0*/ UnityEngine.UI.Text previousButtonText;
                /*0x0*/ UnityEngine.UI.Text nameLabel;
                /*0x0*/ UnityEngine.UI.Text valueLabel;
                /*0x0*/ T m_Field;

                /*0x1f309e4*/ DebugUIHandlerField();
                /*0x1f30ebc*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1f309e4*/ void OnDeselection();
                /*0x1f309e4*/ void OnAction();
                /*0x1f309e4*/ void UpdateValueLabel();
                /*0x1f30ebc*/ void SetLabelText(string text);
            }

            class DebugUIHandlerFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.FloatField m_Field;

                /*0x3b93d3c*/ DebugUIHandlerFloatField();
                /*0x3b93a6c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b93bdc*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b93c34*/ void OnDeselection();
                /*0x3b93c84*/ void OnIncrement(bool fast);
                /*0x3b93d34*/ void OnDecrement(bool fast);
                /*0x3b93c8c*/ void ChangeValue(bool fast, float multiplier);
                /*0x3b93b14*/ void UpdateValueLabel();
            }

            class DebugUIHandlerFoldout : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float k_FoldoutXOffset = 215;
                static float k_XOffset = 230;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Foldout m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b94330*/ DebugUIHandlerFoldout();
                /*0x3b93d58*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b94104*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b941e8*/ void OnDeselection();
                /*0x3b94214*/ void OnIncrement(bool fast);
                /*0x3b94230*/ void OnDecrement(bool fast);
                /*0x3b94248*/ void OnAction();
                /*0x3b940dc*/ void UpdateValue();
                /*0x3b94268*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerGroup : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Transform header;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Container m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b945d4*/ DebugUIHandlerGroup();
                /*0x3b9434c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b94464*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b9451c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerHBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b947dc*/ DebugUIHandlerHBox();
                /*0x3b945f0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b9466c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b94724*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
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

                /*0x3b94a9c*/ DebugUIHandlerIndirectFloatField();
                /*0x3b92724*/ void Init();
                /*0x3b9490c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b94964*/ void OnDeselection();
                /*0x3b949b4*/ void OnIncrement(bool fast);
                /*0x3b94a94*/ void OnDecrement(bool fast);
                /*0x3b949bc*/ void ChangeValue(bool fast, float multiplier);
                /*0x3b947f8*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIndirectToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ System.Func<int, bool> getter;
                /*0x80*/ System.Action<int, bool> setter;
                /*0x88*/ int index;

                /*0x3b94c20*/ DebugUIHandlerIndirectToggle();
                /*0x3b8f048*/ void Init();
                /*0x3b94ab8*/ void OnToggleValueChanged(bool value);
                /*0x3b94af8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b94b50*/ void OnDeselection();
                /*0x3b94ba0*/ void OnAction();
                /*0x3b8f4d4*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.IntField m_Field;

                /*0x3b94f28*/ DebugUIHandlerIntField();
                /*0x3b94c3c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b94dc8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b94e20*/ void OnDeselection();
                /*0x3b94e70*/ void OnIncrement(bool fast);
                /*0x3b94f20*/ void OnDecrement(bool fast);
                /*0x3b94e78*/ void ChangeValue(bool fast, int multiplier);
                /*0x3b94ce4*/ void UpdateValueLabel();
            }

            class DebugUIHandlerMessageBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color32 k_WarningBackgroundColor;
                static /*0x4*/ UnityEngine.Color32 k_WarningTextColor;
                static /*0x8*/ UnityEngine.Color32 k_ErrorBackgroundColor;
                static /*0xc*/ UnityEngine.Color32 k_ErrorTextColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.MessageBox m_Field;

                static /*0x3b9513c*/ DebugUIHandlerMessageBox();
                /*0x3b95120*/ DebugUIHandlerMessageBox();
                /*0x3b94f44*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b950d8*/ void Update();
                /*0x3b95118*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
            }

            class DebugUIHandlerObject : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;

                /*0x3b95350*/ DebugUIHandlerObject();
                /*0x3b951c4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b952a8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b95300*/ void OnDeselection();
            }

            class DebugUIHandlerObjectList : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectListField>
            {
                /*0x88*/ int m_Index;

                /*0x3b9558c*/ DebugUIHandlerObjectList();
                /*0x3b9536c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b953cc*/ void OnIncrement(bool fast);
                /*0x3b953e8*/ void OnDecrement(bool fast);
                /*0x3b95404*/ void UpdateValueLabel();
            }

            class DebugUIHandlerObjectPopupField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectPopupField>
            {
                /*0x88*/ int m_Index;

                /*0x3b95838*/ DebugUIHandlerObjectPopupField();
                /*0x3b955d4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b95634*/ void ChangeSelectedObject();
                /*0x3b95734*/ void OnIncrement(bool fast);
                /*0x3b95744*/ void OnDecrement(bool fast);
                /*0x3b95754*/ void UpdateValueLabel();
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

                /*0x3b95b54*/ DebugUIHandlerPanel();
                /*0x3b95880*/ void OnEnable();
                /*0x3b90fdc*/ void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0x3b9596c*/ UnityEngine.Rendering.DebugUI.Panel GetPanel();
                /*0x3b95974*/ void SelectNextItem();
                /*0x3b95988*/ void SelectPreviousItem();
                /*0x3b9599c*/ void OnScrollbarClicked();
                /*0x3b95a00*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target);
                /*0x3b90424*/ void UpdateScroll();
                /*0x3b95a08*/ float GetYPosInScroll(UnityEngine.RectTransform target);
                /*0x3b9180c*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x3b95af4*/ void ResetDebugManager();
            }

            class DebugUIHandlerPersistentCanvas : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform panel;
                /*0x28*/ UnityEngine.RectTransform valuePrefab;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.ValueTuple> m_ValueTupleWidgets;

                /*0x3b96448*/ DebugUIHandlerPersistentCanvas();
                /*0x3b95b5c*/ void Toggle(UnityEngine.Rendering.DebugUI.Value widget, string displayName);
                /*0x3b95e0c*/ void Toggle(UnityEngine.Rendering.DebugUI.ValueTuple widget, System.Nullable<int> forceTupleIndex);
                /*0x3b9619c*/ bool IsEmpty();
                /*0x3b961ec*/ void Clear();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Value widget;

                    /*0x3b95e04*/ <>c__DisplayClass3_0();
                    /*0x3b96524*/ bool <Toggle>b__0(UnityEngine.Rendering.UI.DebugUIHandlerValue x);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.ValueTuple widget;

                    /*0x3b96194*/ <>c__DisplayClass5_0();
                    /*0x3b96544*/ bool <Toggle>b__0(UnityEngine.Rendering.DebugUI.ValueTuple x);
                }
            }

            class DebugUIHandlerProgressBar : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.RectTransform progressBarRect;
                /*0x78*/ UnityEngine.Rendering.DebugUI.ProgressBarValue m_Value;
                /*0x80*/ float m_Timer;

                /*0x3b967b8*/ DebugUIHandlerProgressBar();
                /*0x3b96554*/ void OnEnable();
                /*0x3b9655c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b966f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b96728*/ void OnDeselection();
                /*0x3b96754*/ void Update();
                /*0x3b96604*/ void UpdateValue();
            }

            class DebugUIHandlerRenderingLayerField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle> toggles;
                /*0x78*/ UnityEngine.Rendering.DebugUI.RenderingLayerField m_Field;
                /*0x80*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b96f58*/ DebugUIHandlerRenderingLayerField();
                /*0x3b967d4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b96b8c*/ bool GetValue(int index);
                /*0x3b96c2c*/ void SetValue(int index, bool value);
                /*0x3b96d24*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b96e08*/ void OnDeselection();
                /*0x3b96e34*/ void OnIncrement(bool fast);
                /*0x3b96e50*/ void OnDecrement(bool fast);
                /*0x3b96e6c*/ void OnAction();
                /*0x3b96e90*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerRow : UnityEngine.Rendering.UI.DebugUIHandlerFoldout
            {
                /*0x80*/ float m_Timer;

                /*0x3b9765c*/ DebugUIHandlerRow();
                /*0x3b96f74*/ void OnEnable();
                /*0x3b96f7c*/ UnityEngine.GameObject GetChild(int index);
                /*0x3b970ac*/ bool TryGetChild(int index, ref UnityEngine.GameObject child);
                /*0x3b97138*/ bool IsActive(UnityEngine.Rendering.DebugUI.Table table, int index, UnityEngine.GameObject child);
                /*0x3b9726c*/ void Update();
            }

            class DebugUIHandlerToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ UnityEngine.Rendering.DebugUI.BoolField m_Field;

                /*0x3b979bc*/ DebugUIHandlerToggle();
                /*0x3b97678*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b977a4*/ void OnToggleValueChanged(bool value);
                /*0x3b977c8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b97820*/ void OnDeselection();
                /*0x3b97870*/ void OnAction();
                /*0x3b97900*/ void UpdateValueLabel();
            }

            class DebugUIHandlerToggleHistory : UnityEngine.Rendering.UI.DebugUIHandlerToggle
            {
                static float k_XOffset = 230;
                /*0x80*/ UnityEngine.UI.Toggle[] historyToggles;

                /*0x3b97fb8*/ DebugUIHandlerToggleHistory();
                /*0x3b979d8*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b97d94*/ void UpdateValueLabel();
                /*0x3b97f24*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory <>4__this;

                    /*0x3b97f90*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x3b97fd4*/ void System.IDisposable.Dispose();
                    /*0x3b97fd8*/ bool MoveNext();
                    /*0x3b980a4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3b980ac*/ void System.Collections.IEnumerator.Reset();
                    /*0x3b980e4*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerUIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.UIntField m_Field;

                /*0x3b983e0*/ DebugUIHandlerUIntField();
                /*0x3b980ec*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b98278*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b982d0*/ void OnDeselection();
                /*0x3b98320*/ void OnIncrement(bool fast);
                /*0x3b983d8*/ void OnDecrement(bool fast);
                /*0x3b98328*/ void ChangeValue(bool fast, int multiplier);
                /*0x3b98194*/ void UpdateValueLabel();
            }

            class DebugUIHandlerValue : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color k_ZeroColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Value m_Field;
                /*0x78*/ float m_Timer;

                static /*0x3b986d8*/ DebugUIHandlerValue();
                /*0x3b986bc*/ DebugUIHandlerValue();
                /*0x3b983fc*/ void OnEnable();
                /*0x3b98404*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b984a0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b984f8*/ void OnDeselection();
                /*0x3b98548*/ void Update();
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

                static /*0x3b98e0c*/ DebugUIHandlerValueTuple();
                /*0x3b98df0*/ DebugUIHandlerValueTuple();
                /*0x3b98728*/ void OnEnable();
                /*0x3b98730*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b98768*/ void OnDeselection();
                /*0x3b98794*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b98b30*/ void UpdateValueLabels();
                /*0x3b98d74*/ void Update();
            }

            class DebugUIHandlerVBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b99048*/ DebugUIHandlerVBox();
                /*0x3b98e5c*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b98ed8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b98f90*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerVector2 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.DebugUI.Vector2Field m_Field;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x3b996dc*/ DebugUIHandlerVector2();
                /*0x3b99064*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b99400*/ void SetValue(float v, bool x, bool y);
                /*0x3b992d0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x3b994a8*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b9958c*/ void OnDeselection();
                /*0x3b995b8*/ void OnIncrement(bool fast);
                /*0x3b995d4*/ void OnDecrement(bool fast);
                /*0x3b995f0*/ void OnAction();
                /*0x3b99614*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x3b996f8*/ float <SetWidget>b__6_0();
                /*0x3b99754*/ void <SetWidget>b__6_1(float x);
                /*0x3b99760*/ float <SetWidget>b__6_2();
                /*0x3b997bc*/ void <SetWidget>b__6_3(float x);
                /*0x3b997c8*/ float <SetupSettings>b__8_0();
                /*0x3b997e0*/ float <SetupSettings>b__8_1();
                /*0x3b997f8*/ float <SetupSettings>b__8_2();
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

                /*0x3b99f60*/ DebugUIHandlerVector3();
                /*0x3b99814*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b99c74*/ void SetValue(float v, bool x, bool y, bool z);
                /*0x3b99b44*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x3b99d2c*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b99e10*/ void OnDeselection();
                /*0x3b99e3c*/ void OnIncrement(bool fast);
                /*0x3b99e58*/ void OnDecrement(bool fast);
                /*0x3b99e74*/ void OnAction();
                /*0x3b99e98*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x3b99f7c*/ float <SetWidget>b__7_0();
                /*0x3b99fe0*/ void <SetWidget>b__7_1(float v);
                /*0x3b99ff0*/ float <SetWidget>b__7_2();
                /*0x3b9a054*/ void <SetWidget>b__7_3(float v);
                /*0x3b9a064*/ float <SetWidget>b__7_4();
                /*0x3b9a0c8*/ void <SetWidget>b__7_5(float v);
                /*0x3b9a0d8*/ float <SetupSettings>b__9_0();
                /*0x3b9a0f0*/ float <SetupSettings>b__9_1();
                /*0x3b9a108*/ float <SetupSettings>b__9_2();
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

                /*0x3b9a948*/ DebugUIHandlerVector4();
                /*0x3b9a124*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b9a648*/ void SetValue(float v, bool x, bool y, bool z, bool w);
                /*0x3b9a518*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x3b9a714*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b9a7f8*/ void OnDeselection();
                /*0x3b9a824*/ void OnIncrement(bool fast);
                /*0x3b9a840*/ void OnDecrement(bool fast);
                /*0x3b9a85c*/ void OnAction();
                /*0x3b9a880*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x3b9a964*/ float <SetWidget>b__8_0();
                /*0x3b9a9c8*/ void <SetWidget>b__8_1(float x);
                /*0x3b9a9dc*/ float <SetWidget>b__8_2();
                /*0x3b9aa40*/ void <SetWidget>b__8_3(float x);
                /*0x3b9aa54*/ float <SetWidget>b__8_4();
                /*0x3b9aab8*/ void <SetWidget>b__8_5(float x);
                /*0x3b9aacc*/ float <SetWidget>b__8_6();
                /*0x3b9ab30*/ void <SetWidget>b__8_7(float x);
                /*0x3b9ab44*/ float <SetupSettings>b__10_0();
                /*0x3b9ab5c*/ float <SetupSettings>b__10_1();
                /*0x3b9ab74*/ float <SetupSettings>b__10_2();
            }

            class DebugUIHandlerWidget : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Color colorDefault;
                /*0x30*/ UnityEngine.Color colorSelected;
                /*0x40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.DebugUI.Widget m_Widget;

                /*0x3b8fb18*/ DebugUIHandlerWidget();
                /*0x3b9ab90*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler();
                /*0x3b9ab98*/ void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x3b9aba0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler();
                /*0x3b9aba8*/ void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x3b9abb0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler();
                /*0x3b9abb8*/ void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x3b9abc0*/ void OnEnable();
                /*0x3b9abc4*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x3b9abcc*/ UnityEngine.Rendering.DebugUI.Widget GetWidget();
                /*0x1ffc854*/ T CastWidget<T>();
                /*0x3b9abd4*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x3b9abdc*/ void OnDeselection();
                /*0x3b9abe0*/ void OnAction();
                /*0x3b9abe4*/ void OnIncrement(bool fast);
                /*0x3b9abe8*/ void OnDecrement(bool fast);
                /*0x3b9abec*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous();
                /*0x3b8f964*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class UIFoldout : UnityEngine.UI.Toggle
            {
                /*0x128*/ UnityEngine.GameObject content;
                /*0x130*/ UnityEngine.GameObject arrowOpened;
                /*0x138*/ UnityEngine.GameObject arrowClosed;

                /*0x3b9af5c*/ UIFoldout();
                /*0x3b9ac98*/ void Start();
                /*0x3b9ad60*/ void OnValidate();
                /*0x3b9ad58*/ void SetState(bool state);
                /*0x3b9ad6c*/ void SetState(bool state, bool rebuildLayout);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2B243200B0E83AB0F0C562B83DB43D12DC5F8E5E193C6428D7E90D0878E027C9;
    static /*0x75fb*/ <PrivateImplementationDetails> 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097;
    static /*0x76fb*/ <PrivateImplementationDetails> 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A;
    static /*0x78fb*/ <PrivateImplementationDetails> 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4;
    static /*0x7cfb*/ <PrivateImplementationDetails> BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158;
    static /*0x7d8b*/ <PrivateImplementationDetails> C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF;
    static /*0x8d8b*/ <PrivateImplementationDetails> CD9A54ED1F18BF97DB08914E280EA7349E11CA2C4885A4D8052552CEBA84208D;
    static /*0x8da3*/ <PrivateImplementationDetails> E806AA89271C778BAF8A2CC19587A816553FEE987D203B134B3B1435B1D158C7;
    static /*0x91a3*/ <PrivateImplementationDetails> F1A2175FA35FAA10D6D61390A177FBF1CF06B9A5AA630A3403091234F0C4C6D2;
    static /*0xfc0a*/ <PrivateImplementationDetails> FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE;

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

    struct __StaticArrayInitTypeSize=27239
    {
    }

    struct __StaticArrayInitTypeSize=30203
    {
    }
}
