class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x534220*/ EmbeddedAttribute();
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
                /*0x534220*/ IsUnmanagedAttribute();
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x12b1ad0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        static /*0x129e480*/ float NormalizeAngleDegree(float angle);
        /*0x31c640*/ LightAnchor();
        /*0x129f7b0*/ float get_yaw();
        /*0x129f8a0*/ void set_yaw(float value);
        /*0xcf6cb0*/ float get_pitch();
        /*0x129f800*/ void set_pitch(float value);
        /*0x129f7a0*/ float get_roll();
        /*0x129f850*/ void set_roll(float value);
        /*0x129f790*/ float get_distance();
        /*0x129f7d0*/ void set_distance(float value);
        /*0x3e3ad0*/ UnityEngine.LightAnchor.UpDirection get_frameSpace();
        /*0xc70b30*/ void set_frameSpace(UnityEngine.LightAnchor.UpDirection value);
        /*0x129f5e0*/ UnityEngine.Vector3 get_anchorPosition();
        /*0x79a150*/ UnityEngine.Transform get_anchorPositionOverride();
        /*0x98b030*/ void set_anchorPositionOverride(UnityEngine.Transform value);
        /*0x129f5c0*/ UnityEngine.Vector3 get_anchorPositionOffset();
        /*0x129f7c0*/ void set_anchorPositionOffset(UnityEngine.Vector3 value);
        /*0x129e5c0*/ void SynchronizeOnTransform(UnityEngine.Camera camera);
        /*0x129edd0*/ void UpdateTransform(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x129db20*/ UnityEngine.LightAnchor.Axes GetWorldSpaceAxes(UnityEngine.Camera camera, UnityEngine.Vector3 anchor);
        /*0x129f3e0*/ void Update();
        /*0x129e4d0*/ void OnDrawGizmosSelected();
        /*0x129eec0*/ void UpdateTransform(UnityEngine.Vector3 up, UnityEngine.Vector3 right, UnityEngine.Vector3 forward, UnityEngine.Vector3 anchor);

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

                static /*0x12b2b90*/ XRBuiltinShaderConstants();
                static /*0x12b1d30*/ void UpdateBuiltinShaderConstants(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex);
                static /*0x12b1bb0*/ void SetBuiltinShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x12b22d0*/ void Update(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
            }

            class XRLayout
            {
                /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> m_ActivePasses;

                /*0x12b39e0*/ XRLayout();
                /*0x12b2f80*/ void AddCamera(UnityEngine.Camera camera, bool enableXR);
                /*0x12b3940*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                /*0x73d3e0*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Camera, UnityEngine.Experimental.Rendering.XRPass>> GetActivePasses();
                /*0x12b31c0*/ void AddPass(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x12b32e0*/ void Clear();
                /*0x12b3410*/ void LogDebugInfo();
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

                static /*0x12b4830*/ XRMirrorView();
                static /*0x12b3a60*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, UnityEngine.Material mat, UnityEngine.XR.XRDisplaySubsystem display);
            }

            class XROcclusionMesh
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler k_OcclusionMeshProfilingSampler;
                /*0x10*/ UnityEngine.Experimental.Rendering.XRPass m_Pass;
                /*0x18*/ UnityEngine.Mesh m_CombinedMesh;
                /*0x20*/ UnityEngine.Material m_Material;
                /*0x28*/ int m_CombinedMeshHashCode;

                static /*0x12b5860*/ XROcclusionMesh();
                /*0x49b490*/ XROcclusionMesh(UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x7965a0*/ void SetMaterial(UnityEngine.Material mat);
                /*0x12b58f0*/ bool get_hasValidOcclusionMesh();
                /*0x12b4f70*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, float occlusionMeshScale, bool yFlip);
                /*0x12b5620*/ void UpdateCombinedMesh();
                /*0x12b4ed0*/ bool IsOcclusionMeshSupported();
                /*0x12b54b0*/ bool TryGetOcclusionMeshCombinedHashCode(ref int hashCode);
                /*0x12b4ac0*/ void CreateOcclusionMeshCombined();
            }

            struct XRPassCreateInfo
            {
                /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier renderTarget;
                /*0x38*/ UnityEngine.RenderTextureDescriptor renderTargetDesc;
                /*0x70*/ UnityEngine.Rendering.ScriptableCullingParameters cullingParameters;
                /*0x6a0*/ UnityEngine.Material occlusionMeshMaterial;
                /*0x6a8*/ float occlusionMeshScale;
                /*0x6b0*/ nint foveatedRenderingInfo;
                /*0x6b8*/ int multipassId;
                /*0x6bc*/ int cullingPassId;
                /*0x6c0*/ bool copyDepth;
                /*0x6c8*/ UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrSdkRenderPass;
            }

            class XRPass
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.XRView> m_Views;
                /*0x18*/ UnityEngine.Experimental.Rendering.XROcclusionMesh m_OcclusionMesh;
                /*0x20*/ bool <copyDepth>k__BackingField;
                /*0x24*/ int <multipassId>k__BackingField;
                /*0x28*/ int <cullingPassId>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.RenderTargetIdentifier <renderTarget>k__BackingField;
                /*0x58*/ UnityEngine.RenderTextureDescriptor <renderTargetDesc>k__BackingField;
                /*0x90*/ UnityEngine.Rendering.ScriptableCullingParameters <cullingParams>k__BackingField;
                /*0x6c0*/ nint <foveatedRenderingInfo>k__BackingField;
                /*0x6c8*/ float <occlusionMeshScale>k__BackingField;

                static /*0x12b6030*/ UnityEngine.Experimental.Rendering.XRPass CreateDefault(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x12b6c90*/ XRPass();
                /*0x12b68b0*/ void Release();
                /*0x12b6d90*/ bool get_enabled();
                /*0x12b7340*/ bool get_supportsFoveatedRendering();
                /*0x796120*/ bool get_copyDepth();
                /*0x7963b0*/ void set_copyDepth(bool value);
                /*0x3e3ad0*/ int get_multipassId();
                /*0xc70b30*/ void set_multipassId(int value);
                /*0x3e3ae0*/ int get_cullingPassId();
                /*0xc6dab0*/ void set_cullingPassId(int value);
                /*0x12b72d0*/ UnityEngine.Rendering.RenderTargetIdentifier get_renderTarget();
                /*0x12b74d0*/ void set_renderTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x12b72a0*/ UnityEngine.RenderTextureDescriptor get_renderTargetDesc();
                /*0x12b74a0*/ void set_renderTargetDesc(UnityEngine.RenderTextureDescriptor value);
                /*0x12b6d60*/ UnityEngine.Rendering.ScriptableCullingParameters get_cullingParams();
                /*0x12b7460*/ void set_cullingParams(UnityEngine.Rendering.ScriptableCullingParameters value);
                /*0x12b7420*/ int get_viewCount();
                /*0x12b72f0*/ bool get_singlePassEnabled();
                /*0x12b6de0*/ nint get_foveatedRenderingInfo();
                /*0x12b7480*/ void set_foveatedRenderingInfo(nint value);
                /*0x12b71e0*/ bool get_isHDRDisplayOutputActive();
                /*0x12b6ec0*/ UnityEngine.ColorGamut get_hdrDisplayOutputColorGamut();
                /*0x12b6f70*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation();
                /*0x12b7290*/ float get_occlusionMeshScale();
                /*0x12b7490*/ void set_occlusionMeshScale(float value);
                /*0x12b63c0*/ UnityEngine.Matrix4x4 GetProjMatrix(int viewIndex);
                /*0x12b64d0*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x12b6570*/ UnityEngine.Rect GetViewport(int viewIndex);
                /*0x12b6350*/ UnityEngine.Mesh GetOcclusionMesh(int viewIndex);
                /*0x12b6460*/ int GetTextureArraySlice(int viewIndex);
                /*0x12b6950*/ void StartSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x12b6b80*/ void StopSinglePass(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x12b6df0*/ bool get_hasValidOcclusionMesh();
                /*0x12b6910*/ void RenderOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
                /*0x12b5ca0*/ UnityEngine.Vector4 ApplyXRViewCenterOffset(UnityEngine.Vector2 center);
                /*0x12b5ee0*/ void AssignView(int viewId, UnityEngine.Experimental.Rendering.XRView xrView);
                /*0x12b5e50*/ void AssignCullingParams(int cullingPassId, UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                /*0x12b6c70*/ void UpdateCombinedOcclusionMesh();
                /*0x12b65f0*/ void InitBase(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x12b59b0*/ void AddView(UnityEngine.Experimental.Rendering.XRView xrView);
            }

            class XRSystem
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.XRLayout s_Layout;
                static /*0x8*/ System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> s_PassAllocator;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.XR.XRDisplaySubsystem> s_DisplayList;
                static /*0x18*/ UnityEngine.XR.XRDisplaySubsystem s_Display;
                static /*0x20*/ UnityEngine.Rendering.MSAASamples s_MSAASamples;
                static /*0x28*/ UnityEngine.Material s_OcclusionMeshMaterial;
                static /*0x30*/ UnityEngine.Material s_MirrorViewMaterial;
                static /*0x38*/ System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> s_LayoutOverride;
                static /*0x40*/ UnityEngine.Experimental.Rendering.XRPass emptyPass;
                static /*0x48*/ bool <singlePassAllowed>k__BackingField;
                static /*0x4c*/ UnityEngine.Rendering.FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField;
                static /*0x50*/ bool <dumpDebugInfo>k__BackingField;

                static /*0x12ba630*/ XRSystem();
                static /*0x12b9050*/ UnityEngine.XR.XRDisplaySubsystem GetActiveDisplay();
                static /*0x12ba8f0*/ bool get_displayActive();
                static /*0x12baa20*/ bool get_isHDRDisplayOutputActive();
                static /*0x12baae0*/ bool get_singlePassAllowed();
                static /*0x12babf0*/ void set_singlePassAllowed(bool value);
                static /*0x12ba9d0*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
                static /*0x12bab90*/ void set_foveatedRenderingCaps(UnityEngine.Rendering.FoveatedRenderingCaps value);
                static /*0x12ba980*/ bool get_dumpDebugInfo();
                static /*0x12bab30*/ void set_dumpDebugInfo(bool value);
                static /*0x12b90f0*/ void Initialize(System.Func<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass> passAllocator, UnityEngine.Shader occlusionMeshPS, UnityEngine.Shader mirrorViewPS);
                static /*0x12ba0d0*/ void SetDisplayMSAASamples(UnityEngine.Rendering.MSAASamples msaaSamples);
                static /*0x12b90a0*/ UnityEngine.Rendering.MSAASamples GetDisplayMSAASamples();
                static /*0x12ba400*/ void SetRenderScale(float renderScale);
                static /*0x12b9510*/ UnityEngine.Experimental.Rendering.XRLayout NewLayout();
                static /*0x12b8e40*/ void EndLayout();
                static /*0x12ba010*/ void RenderMirrorView(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
                static /*0x12b8c60*/ void Dispose();
                static /*0x12ba2c0*/ void SetDisplayZRange(float zNear, float zFar);
                static /*0x12ba390*/ void SetLayoutOverride(System.Action<UnityEngine.Experimental.Rendering.XRLayout, UnityEngine.Camera> action);
                static /*0x12ba5a0*/ void XRSystemInit();
                static /*0x12b9cc0*/ void RefreshDeviceInfo();
                static /*0x12b7fe0*/ void CreateDefaultLayout(UnityEngine.Camera camera);
                static /*0x12b9610*/ void ReconfigurePass(UnityEngine.Experimental.Rendering.XRPass xrPass, UnityEngine.Camera camera);
                static /*0x12b7e30*/ bool CanUseSinglePass(UnityEngine.Camera camera, UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass);
                static /*0x12b7a20*/ UnityEngine.Experimental.Rendering.XRView BuildView(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass, UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter);
                static /*0x12b74f0*/ UnityEngine.Experimental.Rendering.XRPassCreateInfo BuildPass(UnityEngine.XR.XRDisplaySubsystem.XRRenderPass xrRenderPass, UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);
            }

            struct XRView
            {
                /*0x10*/ UnityEngine.Matrix4x4 projMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x90*/ UnityEngine.Rect viewport;
                /*0xa0*/ UnityEngine.Mesh occlusionMesh;
                /*0xa8*/ int textureArraySlice;
                /*0xac*/ UnityEngine.Vector2 eyeCenterUV;

                static /*0x12bac50*/ UnityEngine.Vector2 ComputeEyeCenterUV(UnityEngine.Matrix4x4 proj);
                /*0x12bacf0*/ XRView(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Rect viewport, UnityEngine.Mesh occlusionMesh, int textureArraySlice);
            }

            namespace RenderGraphModule
            {
                enum DepthAccess
                {
                    Read = 1,
                    Write = 2,
                    ReadWrite = 3,
                }

                class RenderGraphContext
                {
                    /*0x10*/ UnityEngine.Rendering.ScriptableRenderContext renderContext;
                    /*0x18*/ UnityEngine.Rendering.CommandBuffer cmd;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool renderGraphPool;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources defaultResources;

                    /*0x32f970*/ RenderGraphContext();
                }

                struct RenderGraphParameters
                {
                    /*0x10*/ string executionName;
                    /*0x18*/ int currentFrameIndex;
                    /*0x1c*/ bool rendererListCulling;
                    /*0x20*/ UnityEngine.Rendering.ScriptableRenderContext scriptableRenderContext;
                    /*0x28*/ UnityEngine.Rendering.CommandBuffer commandBuffer;
                }

                struct RenderGraphExecution : System.IDisposable
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph;

                    /*0x792990*/ RenderGraphExecution(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                    /*0x12a10e0*/ void Dispose();
                }

                class RenderGraphDebugParams
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

                    /*0x32f970*/ RenderGraphDebugParams();
                    /*0x12a0390*/ void RegisterDebug(string name, UnityEngine.Rendering.DebugUI.Panel debugPanel);
                    /*0x12a0c70*/ void UnRegisterDebug(string name);
                    /*0x796120*/ bool <RegisterDebug>b__10_0();
                    /*0x7963b0*/ void <RegisterDebug>b__10_1(bool value);
                    /*0x12a0b50*/ bool <RegisterDebug>b__10_2();
                    /*0x12a0b60*/ void <RegisterDebug>b__10_3(bool value);
                    /*0x12a0b70*/ bool <RegisterDebug>b__10_4();
                    /*0x12a0b80*/ void <RegisterDebug>b__10_5(bool value);
                    /*0xed9100*/ bool <RegisterDebug>b__10_6();
                    /*0x117be00*/ void <RegisterDebug>b__10_7(bool value);
                    /*0x12a0b90*/ void <RegisterDebug>b__10_8();
                    /*0x12a0c00*/ void <RegisterDebug>b__10_9();

                    class Strings
                    {
                        static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;
                        static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip DisablePassCulling;
                        static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ImmediateMode;
                        static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip EnableLogging;
                        static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogFrameInformation;
                        static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LogResources;

                        static /*0x12b1280*/ Strings();
                    }
                }

                class RenderFunc<PassData> : System.MulticastDelegate
                {
                    RenderFunc(object object, nint method);
                    /*0x2a5510*/ void Invoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    /*0x2a5510*/ System.IAsyncResult BeginInvoke(PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext, System.AsyncCallback callback, object object);
                    /*0x17aec0*/ void EndInvoke(System.IAsyncResult result);
                }

                class RenderGraphDebugData
                {
                    /*0x10*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.PassDebugData> passList;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData> resourceLists;

                    /*0x12a02e0*/ RenderGraphDebugData();
                    /*0x12a0120*/ void Clear();

                    struct PassDebugData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ System.Collections.Generic.List<int> resourceReadLists;
                        /*0x20*/ System.Collections.Generic.List<int> resourceWriteLists;
                        /*0x28*/ bool culled;
                        /*0x29*/ bool async;
                        /*0x2c*/ int syncToPassIndex;
                        /*0x30*/ int syncFromPassIndex;
                        /*0x34*/ bool generateDebugData;
                    }

                    struct ResourceDebugData
                    {
                        /*0x10*/ string name;
                        /*0x18*/ bool imported;
                        /*0x1c*/ int creationPassIndex;
                        /*0x20*/ int releasePassIndex;
                        /*0x28*/ System.Collections.Generic.List<int> consumerList;
                        /*0x30*/ System.Collections.Generic.List<int> producerList;
                    }
                }

                class RenderGraph
                {
                    static /*0x0*/ int kMaxMRTCount;
                    static /*0x8*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> s_RegisteredGraphs;
                    static /*0x10*/ bool <requireDebugData>k__BackingField;
                    static /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphRegistered;
                    static /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered;
                    static /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered;
                    static /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool m_RenderGraphPool;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass> m_RenderPasses;
                    /*0x28*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> m_RendererLists;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_DebugParameters;
                    /*0x38*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources m_DefaultResources;
                    /*0x48*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProfilingSampler> m_DefaultProfilingSamplers;
                    /*0x50*/ bool m_ExecutionExceptionWasRaised;
                    /*0x58*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext m_RenderGraphContext;
                    /*0x60*/ UnityEngine.Rendering.CommandBuffer m_PreviousCommandBuffer;
                    /*0x68*/ int m_CurrentImmediatePassIndex;
                    /*0x70*/ System.Collections.Generic.List<int> m_ImmediateModeResourceList;
                    /*0x78*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> m_CompiledResourcesInfos;
                    /*0x80*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> m_CompiledPassInfos;
                    /*0x88*/ System.Collections.Generic.Stack<int> m_CullingStack;
                    /*0x90*/ int m_ExecutionCount;
                    /*0x94*/ int m_CurrentFrameIndex;
                    /*0x98*/ bool m_HasRenderGraphBegun;
                    /*0xa0*/ string m_CurrentExecutionName;
                    /*0xa8*/ bool m_RendererListCulling;
                    /*0xb0*/ System.Collections.Generic.Dictionary<string, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData> m_DebugData;
                    /*0xb8*/ string <name>k__BackingField;

                    static /*0x12afa80*/ RenderGraph();
                    static /*0x12b06c0*/ bool get_requireDebugData();
                    static /*0x12b0b10*/ void set_requireDebugData(bool value);
                    static /*0x12ac360*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph> GetRegisteredRenderGraphs();
                    static /*0x12b04c0*/ void add_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x12b0910*/ void remove_onGraphRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x12b05c0*/ void add_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x12b0a10*/ void remove_onGraphUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnGraphRegisteredDelegate value);
                    static /*0x12b02c0*/ void add_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x12b0710*/ void remove_onExecutionRegistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x12b03c0*/ void add_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    static /*0x12b0810*/ void remove_onExecutionUnregistered(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.OnExecutionRegisteredDelegate value);
                    /*0x12afb30*/ RenderGraph(string name);
                    /*0xb69980*/ string get_name();
                    /*0xb699b0*/ void set_name(string value);
                    /*0xb61870*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources get_defaultResources();
                    /*0x12a7980*/ void Cleanup();
                    /*0x12ae8c0*/ void RegisterDebug(UnityEngine.Rendering.DebugUI.Panel panel);
                    /*0x12aedc0*/ void UnRegisterDebug();
                    /*0x12ab8f0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData GetDebugData(string executionName);
                    /*0x12a9e50*/ void EndFrame();
                    /*0x12ac740*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                    /*0x12ac430*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                    /*0x12a9720*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x12a95e0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                    /*0x12ae6b0*/ void RefreshSharedTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle handle, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x12aea80*/ void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12a9750*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12a9660*/ void CreateTextureIfInvalid(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12ac3b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12a9390*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x12ac610*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer);
                    /*0x12a9360*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x12a9300*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computeBuffer);
                    /*0x12ab8b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computeBuffer);
                    /*0x2a5510*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData, UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x2a5510*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder AddRenderPass<PassData>(string passName, ref PassData passData);
                    /*0x12ae260*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution RecordAndExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters parameters);
                    /*0x12aa6a0*/ void Execute();
                    /*0x12a75c0*/ void BeginProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x12a9fe0*/ void EndProfilingSampler(UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0xeeac90*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo> GetCompiledPassInfos();
                    /*0x12a7ca0*/ void ClearCompiledGraph();
                    /*0x12acc30*/ void InvalidateContext();
                    /*0x12ad6f0*/ void OnPassAdded(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x12ac870*/ void InitResourceInfosData(UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo> resourceInfos, int count);
                    /*0x12aca00*/ void InitializeCompilationData();
                    /*0x12a8c80*/ void CountReferences();
                    /*0x12a9910*/ void CullUnusedPasses();
                    /*0x12aefd0*/ void UpdatePassSynchronization(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo currentPassInfo, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex);
                    /*0x12af950*/ void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo resource);
                    /*0x12aba70*/ int GetFirstValidConsumerIndex(int passIndex, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x12aa840*/ int FindTextureProducer(int consumerPass, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info, ref int index);
                    /*0x12ac000*/ int GetLatestProducerIndex(int passIndex, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x12ac1a0*/ int GetLatestValidReadIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x12abbd0*/ int GetFirstValidWriteIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x12ac280*/ int GetLatestValidWriteIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledResourceInfo info);
                    /*0x12a94e0*/ void CreateRendererLists();
                    /*0x12abcb0*/ bool GetImportedFallback(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle fallback);
                    /*0x12a6f50*/ void AllocateCulledPassResources(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, int passIndex);
                    /*0x12aeff0*/ void UpdateResourceAllocationAndSynchronization();
                    /*0x12a7340*/ bool AreRendererListsEmpty(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists);
                    /*0x12aeca0*/ void TryCullPassAtIndex(int passIndex);
                    /*0x12a9800*/ void CullRendererLists();
                    /*0x12a8880*/ void CompileRenderGraph();
                    /*0x12a8020*/ ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo CompilePassImmediatly(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x12aa560*/ void ExecutePassImmediately(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    /*0x12aa1f0*/ void ExecuteCompiledPass(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, int passIndex);
                    /*0x12aa590*/ void ExecuteRenderGraph();
                    /*0x12add20*/ void PreRenderPassSetRenderTargets(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x12ad9c0*/ void PreRenderPassExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x12ad740*/ void PostRenderPassExecute(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x12a7eb0*/ void ClearRenderPasses();
                    /*0x12ae8f0*/ void ReleaseImmediateModeResources();
                    /*0x12ad070*/ void LogFrameInformation();
                    /*0x12ad5c0*/ void LogRendererListsCreation();
                    /*0x12ad220*/ void LogRenderPassBegin(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.CompiledPassInfo passInfo);
                    /*0x12acca0*/ void LogCulledPasses();
                    /*0x12ab970*/ UnityEngine.Rendering.ProfilingSampler GetDefaultProfilingSampler(string name);
                    /*0x12aee40*/ void UpdateImportedResourceLifeTime(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData.ResourceDebugData data, System.Collections.Generic.List<int> passList);
                    /*0x12aa920*/ void GenerateDebugData();
                    /*0x12a77d0*/ void CleanupDebugData();

                    struct CompiledResourceInfo
                    {
                        /*0x10*/ System.Collections.Generic.List<int> producers;
                        /*0x18*/ System.Collections.Generic.List<int> consumers;
                        /*0x20*/ int refCount;
                        /*0x24*/ bool imported;

                        /*0x129cc30*/ void Reset();
                    }

                    struct CompiledPassInfo
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass;
                        /*0x18*/ System.Collections.Generic.List<int> resourceCreateList;
                        /*0x20*/ System.Collections.Generic.List<int> resourceReleaseList;
                        /*0x28*/ int refCount;
                        /*0x2c*/ bool culled;
                        /*0x2d*/ bool culledByRendererList;
                        /*0x2e*/ bool hasSideEffect;
                        /*0x30*/ int syncToPassIndex;
                        /*0x34*/ int syncFromPassIndex;
                        /*0x38*/ bool needGraphicsFence;
                        /*0x40*/ UnityEngine.Rendering.GraphicsFence fence;
                        /*0x50*/ bool enableAsyncCompute;

                        /*0x129cc10*/ bool get_allowPassCulling();
                        /*0x129c990*/ void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass pass);
                    }

                    class ProfilingScopePassData
                    {
                        /*0x10*/ UnityEngine.Rendering.ProfilingSampler sampler;

                        /*0x32f970*/ ProfilingScopePassData();
                    }

                    class OnGraphRegisteredDelegate : System.MulticastDelegate
                    {
                        /*0xcf9550*/ OnGraphRegisteredDelegate(object object, nint method);
                        /*0x720980*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph);
                        /*0xe29290*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, System.AsyncCallback callback, object object);
                        /*0x723cb0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnExecutionRegisteredDelegate : System.MulticastDelegate
                    {
                        /*0x722be0*/ OnExecutionRegisteredDelegate(object object, nint method);
                        /*0x722200*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, string executionName);
                        /*0x98b3f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, string executionName, System.AsyncCallback callback, object object);
                        /*0x723cb0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData> <>9__62_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData> <>9__63_0;

                        static /*0x12b1a60*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x12b1a00*/ void <BeginProfilingSampler>b__62_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext ctx);
                        /*0x12b1a30*/ void <EndProfilingSampler>b__63_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph.ProfilingScopePassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext ctx);
                    }
                }

                struct RenderGraphProfilingScope : System.IDisposable
                {
                    /*0x10*/ bool m_Disposed;
                    /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;

                    /*0x12a29e0*/ RenderGraphProfilingScope(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x12a29a0*/ void Dispose();
                    /*0x12a2960*/ void Dispose(bool disposing);
                }

                struct RenderGraphBuilder : System.IDisposable
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass m_RenderPass;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_Resources;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph m_RenderGraph;
                    /*0x28*/ bool m_Disposed;

                    /*0x12a00c0*/ RenderGraphBuilder(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass renderPass, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry resources, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                    /*0x129fe50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseColorBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input, int index);
                    /*0x129ff20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle UseDepthBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags);
                    /*0x129fc70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x12a0070*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle WriteTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x129fdf0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ReadWriteTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle input);
                    /*0x129fa20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x129fa80*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTransientTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x129fb60*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle UseRendererList(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle input);
                    /*0x129fc40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ReadComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle input);
                    /*0x12a0020*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle WriteComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle input);
                    /*0x129f9c0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x129f930*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateTransientComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle computebuffer);
                    /*0x17aec0*/ void SetRenderFunc<PassData>(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc);
                    /*0x129fc00*/ void EnableAsyncCompute(bool value);
                    /*0x129f8f0*/ void AllowPassCulling(bool value);
                    /*0x129fb90*/ void Dispose();
                    /*0x129f910*/ void AllowRendererListCulling(bool value);
                    /*0x129fb60*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle DependsOn(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle input);
                    /*0x129fb90*/ void Dispose(bool disposing);
                    /*0x32d010*/ void CheckResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res, bool dontCheckTransientReadWrite);
                    /*0x129fc20*/ void GenerateDebugData(bool value);
                }

                class RenderGraphDefaultResources
                {
                    /*0x10*/ bool m_IsValid;
                    /*0x18*/ UnityEngine.Rendering.RTHandle m_BlackTexture2D;
                    /*0x20*/ UnityEngine.Rendering.RTHandle m_WhiteTexture2D;
                    /*0x28*/ UnityEngine.Rendering.RTHandle m_ShadowTexture2D;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture>k__BackingField;
                    /*0x38*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTexture>k__BackingField;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <clearTextureXR>k__BackingField;
                    /*0x48*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <magentaTextureXR>k__BackingField;
                    /*0x50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureXR>k__BackingField;
                    /*0x58*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTextureArrayXR>k__BackingField;
                    /*0x60*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackUIntTextureXR>k__BackingField;
                    /*0x68*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <blackTexture3DXR>k__BackingField;
                    /*0x70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <whiteTextureXR>k__BackingField;
                    /*0x78*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <defaultShadowTexture>k__BackingField;

                    /*0x12a0f10*/ RenderGraphDefaultResources();
                    /*0x997630*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture();
                    /*0x12a1090*/ void set_blackTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x995140*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTexture();
                    /*0x995200*/ void set_whiteTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0xb61870*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_clearTextureXR();
                    /*0xcf6ce0*/ void set_clearTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x4e40d0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_magentaTextureXR();
                    /*0x12a10c0*/ void set_magentaTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x4e40e0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureXR();
                    /*0x12a1080*/ void set_blackTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0xb61940*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTextureArrayXR();
                    /*0x12a1070*/ void set_blackTextureArrayXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0xe643b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackUIntTextureXR();
                    /*0x12a10a0*/ void set_blackUIntTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x8af030*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_blackTexture3DXR();
                    /*0x12a1060*/ void set_blackTexture3DXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0xd184b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_whiteTextureXR();
                    /*0x12a10d0*/ void set_whiteTextureXR(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0xecb7b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_defaultShadowTexture();
                    /*0x12a10b0*/ void set_defaultShadowTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x12a0cf0*/ void Cleanup();
                    /*0x12a0d40*/ void InitializeForRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph);
                }

                struct RenderGraphLogIndent : System.IDisposable
                {
                    /*0x10*/ int m_Indentation;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_Logger;
                    /*0x20*/ bool m_Disposed;

                    /*0x12a1230*/ RenderGraphLogIndent(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger, int indentation);
                    /*0x12a1100*/ void Dispose();
                    /*0x12a1190*/ void Dispose(bool disposing);
                }

                class RenderGraphLogger
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, System.Text.StringBuilder> m_LogMap;
                    /*0x18*/ System.Text.StringBuilder m_CurrentBuilder;
                    /*0x20*/ int m_CurrentIndentation;

                    /*0x12a1760*/ RenderGraphLogger();
                    /*0x12a15e0*/ void Initialize(string logName);
                    /*0x12a1570*/ void IncrementIndentation(int value);
                    /*0x12a12c0*/ void DecrementIndentation(int value);
                    /*0x12a16d0*/ void LogLine(string format, object[] args);
                    /*0x12a14c0*/ string GetLog(string logName);
                    /*0x12a1330*/ string GetAllLogs();
                }

                class RenderGraphObjectPool
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, int>, System.Collections.Generic.Stack<object>> m_ArrayPool;
                    /*0x18*/ System.Collections.Generic.List<System.ValueTuple<object, System.ValueTuple<System.Type, int>>> m_AllocatedArrays;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

                    /*0x12a1d80*/ RenderGraphObjectPool();
                    /*0x184ab0*/ T[] GetTempArray<T>(int size);
                    /*0x12a18c0*/ UnityEngine.MaterialPropertyBlock GetTempMaterialPropertyBlock();
                    /*0x12a19f0*/ void ReleaseAllTempAlloc();
                    /*0x2a5510*/ T Get<T>();
                    /*0x2a5510*/ void Release<T>(T value);
                    /*0x12a17e0*/ void Cleanup();

                    class SharedObjectPoolBase
                    {
                        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools;

                        static /*0x12b11f0*/ SharedObjectPoolBase();
                        static /*0x12b10b0*/ void ClearAll();
                        /*0x32f970*/ SharedObjectPoolBase();
                        /*0x180fc0*/ void Clear();
                    }

                    class SharedObjectPool<T> : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPoolBase
                    {
                        static /*0x0*/ System.Lazy<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T>> s_Instance;
                        /*0x0*/ System.Collections.Generic.Stack<T> m_Pool;

                        static /*0x180ff0*/ SharedObjectPool();
                        static /*0x180cf0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> AllocatePool();
                        static /*0x180cf0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool();
                        /*0x180fc0*/ SharedObjectPool();
                        /*0x2a5510*/ T Get();
                        /*0x2a5510*/ void Release(T value);
                        /*0x180fc0*/ void Clear();
                    }
                }

                class RenderGraphPass
                {
                    /*0x10*/ string <name>k__BackingField;
                    /*0x18*/ int <index>k__BackingField;
                    /*0x20*/ UnityEngine.Rendering.ProfilingSampler <customSampler>k__BackingField;
                    /*0x28*/ bool <enableAsyncCompute>k__BackingField;
                    /*0x29*/ bool <allowPassCulling>k__BackingField;
                    /*0x2c*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle <depthBuffer>k__BackingField;
                    /*0x38*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] <colorBuffers>k__BackingField;
                    /*0x40*/ int <colorBufferMaxIndex>k__BackingField;
                    /*0x44*/ int <refCount>k__BackingField;
                    /*0x48*/ bool <generateDebugData>k__BackingField;
                    /*0x49*/ bool <allowRendererListCulling>k__BackingField;
                    /*0x50*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> resourceReadLists;
                    /*0x58*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> resourceWriteLists;
                    /*0x60*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle> transientResourceList;
                    /*0x68*/ System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> usedRendererListList;

                    /*0x12a2620*/ RenderGraphPass();
                    /*0x1803b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> GetExecuteDelegate<PassData>();
                    /*0x17aec0*/ void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    /*0x17aec0*/ void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                    /*0x17cb40*/ bool HasRenderFunc();
                    /*0x73d3e0*/ string get_name();
                    /*0x9f12f0*/ void set_name(string value);
                    /*0x8a5c20*/ int get_index();
                    /*0x8a5c50*/ void set_index(int value);
                    /*0x61a260*/ UnityEngine.Rendering.ProfilingSampler get_customSampler();
                    /*0x7965a0*/ void set_customSampler(UnityEngine.Rendering.ProfilingSampler value);
                    /*0x4ba480*/ bool get_enableAsyncCompute();
                    /*0xd18990*/ void set_enableAsyncCompute(bool value);
                    /*0x12a2930*/ bool get_allowPassCulling();
                    /*0x12a21f0*/ void set_allowPassCulling(bool value);
                    /*0x12a2940*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_depthBuffer();
                    /*0x12a2950*/ void set_depthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle value);
                    /*0x995140*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] get_colorBuffers();
                    /*0xe5a080*/ void set_colorBuffers(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0xbe6be0*/ int get_colorBufferMaxIndex();
                    /*0xbe6cc0*/ void set_colorBufferMaxIndex(int value);
                    /*0x10eed50*/ int get_refCount();
                    /*0x10eed60*/ void set_refCount(int value);
                    /*0xe85db0*/ bool get_generateDebugData();
                    /*0x10d9810*/ void set_generateDebugData(bool value);
                    /*0x10d9730*/ bool get_allowRendererListCulling();
                    /*0x12a2200*/ void set_allowRendererListCulling(bool value);
                    /*0x12a2210*/ void Clear();
                    /*0x12a1fb0*/ void AddResourceWrite(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a1e90*/ void AddResourceRead(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a20d0*/ void AddTransientResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a2580*/ void UseRendererList(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList);
                    /*0xd18990*/ void EnableAsyncCompute(bool value);
                    /*0x12a21f0*/ void AllowPassCulling(bool value);
                    /*0x12a2200*/ void AllowRendererListCulling(bool value);
                    /*0x10d9810*/ void GenerateDebugData(bool value);
                    /*0x12a2480*/ void SetColorBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, int index);
                    /*0x12a2530*/ void SetDepthBuffer(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle resource, UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess flags);
                }

                class RenderGraphPass<PassData> : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass
                {
                    /*0x0*/ PassData data;
                    /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData> renderFunc;

                    /*0x180fc0*/ RenderGraphPass();
                    /*0x17aec0*/ void Execute(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext renderGraphContext);
                    /*0x2a5510*/ void Initialize(int passIndex, PassData passData, string passName, UnityEngine.Rendering.ProfilingSampler sampler);
                    /*0x17aec0*/ void Release(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool pool);
                    /*0x17cb40*/ bool HasRenderFunc();
                }

                enum RenderGraphProfileId
                {
                    CompileRenderGraph = 0,
                    ExecuteRenderGraph = 1,
                    RenderGraphClear = 2,
                    RenderGraphClearDebug = 3,
                }

                struct ComputeBufferHandle
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle s_NullHandle;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;

                    static /*0x32d010*/ ComputeBufferHandle();
                    static /*0x129ce10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle get_nullHandle();
                    static /*0x129ce60*/ UnityEngine.ComputeBuffer op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle buffer);
                    /*0x129cdd0*/ ComputeBufferHandle(int handle, bool shared);
                    /*0x129cd80*/ bool IsValid();
                }

                struct ComputeBufferDesc
                {
                    /*0x10*/ int count;
                    /*0x14*/ int stride;
                    /*0x18*/ UnityEngine.ComputeBufferType type;
                    /*0x20*/ string name;

                    /*0x129cd60*/ ComputeBufferDesc(int count, int stride);
                    /*0x129cd40*/ ComputeBufferDesc(int count, int stride, UnityEngine.ComputeBufferType type);
                    /*0x129cd10*/ int GetHashCode();
                }

                class ComputeBufferResource : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc, UnityEngine.ComputeBuffer>
                {
                    /*0x129da50*/ ComputeBufferResource();
                    /*0x129d750*/ string GetName();
                    /*0x129d5b0*/ void CreatePooledGraphicsResource();
                    /*0x129d8f0*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x129d450*/ void CreateGraphicsResource(string name);
                    /*0x129d8a0*/ void ReleaseGraphicsResource();
                    /*0x129d7a0*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x129d820*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class ComputeBufferPool : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.ComputeBuffer>
                {
                    /*0x129d410*/ ComputeBufferPool();
                    /*0x129d3f0*/ void ReleaseInternalResource(UnityEngine.ComputeBuffer res);
                    /*0x129cf30*/ string GetResourceName(UnityEngine.ComputeBuffer res);
                    /*0x129cf60*/ long GetResourceSize(UnityEngine.ComputeBuffer res);
                    /*0x129cfa0*/ string GetResourceTypeName();
                    /*0x129cfd0*/ int GetSortIndex(UnityEngine.ComputeBuffer res);
                    /*0x129d000*/ void PurgeUnusedResources(int currentFrameIndex);
                }

                class IRenderGraphResourcePool
                {
                    /*0x32f970*/ IRenderGraphResourcePool();
                    /*0x17aa40*/ void PurgeUnusedResources(int currentFrameIndex);
                    /*0x180fc0*/ void Cleanup();
                    void CheckFrameAllocation(bool onException, int frameIndex);
                    /*0x17aec0*/ void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class RenderGraphResourcePool<Type> : UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool
                {
                    static int kStaleResourceLifetime = 10;
                    static /*0x0*/ int s_CurrentFrameIndex;
                    /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<Type, int>>> m_ResourcePool;
                    /*0x0*/ System.Collections.Generic.List<int> m_RemoveList;
                    /*0x0*/ System.Collections.Generic.List<System.ValueTuple<int, Type>> m_FrameAllocatedResources;

                    static /*0x17c3f0*/ bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                    /*0x180fc0*/ RenderGraphResourcePool();
                    /*0x2a5510*/ void ReleaseInternalResource(Type res);
                    /*0x2a5510*/ string GetResourceName(Type res);
                    /*0x2a5510*/ long GetResourceSize(Type res);
                    /*0x1803b0*/ string GetResourceTypeName();
                    /*0x2a5510*/ int GetSortIndex(Type res);
                    /*0x2a5510*/ void ReleaseResource(int hash, Type resource, int currentFrameIndex);
                    bool TryGetResource(int hashCode, ref Type resource);
                    /*0x180fc0*/ void Cleanup();
                    /*0x2a5510*/ void RegisterFrameAllocation(int hash, Type value);
                    /*0x2a5510*/ void UnregisterFrameAllocation(int hash, Type value);
                    void CheckFrameAllocation(bool onException, int frameIndex);
                    /*0x17aec0*/ void LogResources(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);

                    struct ResourceLogInfo<Type>
                    {
                        /*0x0*/ string name;
                        /*0x0*/ long size;
                    }

                    class <>c<Type>
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.<>c<Type> <>9;
                        static /*0x0*/ System.Comparison<UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__17_0;

                        static /*0x180ff0*/ <>c();
                        /*0x180fc0*/ <>c();
                        /*0x2a5510*/ int <LogResources>b__17_0(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> a, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool.ResourceLogInfo<Type> b);
                    }
                }

                class RenderGraphResourceRegistry
                {
                    static int kSharedResourceLifetime = 30;
                    static int kInitialRendererListCount = 256;
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry m_CurrentRegistry;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources;
                    /*0x18*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource> m_RendererListResources;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams m_RenderGraphDebug;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_ResourceLogger;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger m_FrameInformationLogger;
                    /*0x38*/ int m_CurrentFrameIndex;
                    /*0x3c*/ int m_ExecutionCount;
                    /*0x40*/ UnityEngine.Rendering.RTHandle m_CurrentBackbuffer;
                    /*0x48*/ System.Collections.Generic.List<UnityEngine.Rendering.RendererList> m_ActiveRendererLists;

                    static /*0x12a6cd0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry get_current();
                    static /*0x12a6d10*/ void set_current(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry value);
                    /*0x12a6ba0*/ RenderGraphResourceRegistry();
                    /*0x12a6610*/ RenderGraphResourceRegistry(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams renderGraphDebug, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger frameInformationLogger);
                    /*0x12a4e90*/ UnityEngine.Rendering.RTHandle GetTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle handle);
                    /*0x12a64a0*/ bool TextureNeedsFallback(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle handle);
                    /*0x12a49e0*/ UnityEngine.Rendering.RendererList GetRendererList(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle);
                    /*0x12a44e0*/ UnityEngine.ComputeBuffer GetComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle handle);
                    /*0x12a2c10*/ void BeginRenderGraph(int executionCount);
                    /*0x12a2a40*/ void BeginExecute(int currentFrameIndex);
                    /*0x12a4110*/ void EndExecute();
                    /*0x12a2d80*/ void CheckHandleValidity(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a2de0*/ void CheckHandleValidity(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x12a53f0*/ void IncrementWriteCount(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a46e0*/ string GetRenderGraphResourceName(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a4810*/ string GetRenderGraphResourceName(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x12a56f0*/ bool IsRenderGraphResourceImported(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a5820*/ bool IsRenderGraphResourceShared(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x12a5520*/ bool IsGraphicsResourceCreated(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a5880*/ bool IsRendererListCreated(ref UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle res);
                    /*0x12a5650*/ bool IsRenderGraphResourceImported(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, int index);
                    /*0x12a48c0*/ int GetRenderGraphResourceTransientIndex(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle res);
                    /*0x12a52d0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportTexture(UnityEngine.Rendering.RTHandle rt);
                    /*0x12a3a00*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateSharedTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, bool explicitRelease);
                    /*0x12a5d20*/ void RefreshSharedTextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x12a6100*/ void ReleaseSharedTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12a4fe0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle ImportBackbuffer(UnityEngine.Rendering.RenderTargetIdentifier rt);
                    /*0x12a3f70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateTexture(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, int transientPassIndex);
                    /*0x12a4ac0*/ int GetResourceCount(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type);
                    /*0x12a4b30*/ int GetTextureResourceCount();
                    /*0x12a4d50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource GetTextureResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a4b90*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc GetTextureResourceDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a3510*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle CreateRendererList(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x12a51b0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle ImportComputeBuffer(UnityEngine.ComputeBuffer computeBuffer);
                    /*0x12a31a0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle CreateComputeBuffer(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc, int transientPassIndex);
                    /*0x12a4230*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc GetComputeBufferResourceDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a41d0*/ int GetComputeBufferResourceCount();
                    /*0x12a43a0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource GetComputeBufferResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a6580*/ void UpdateSharedResourceLastFrameIndex(int type, int index);
                    /*0x12a5b10*/ void ManageSharedRenderGraphResources();
                    /*0x12a32d0*/ bool CreatePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, int type, int index);
                    /*0x12a3460*/ bool CreatePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a3cf0*/ bool CreateTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x12a5fd0*/ void ReleasePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, int type, int index);
                    /*0x12a5f20*/ void ReleasePooledResource(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    /*0x12a62b0*/ void ReleaseTextureCallback(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                    /*0x32d010*/ void ValidateTextureDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc);
                    /*0x32d010*/ void ValidateRendererListDesc(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                    /*0x32d010*/ void ValidateComputeBufferDesc(ref UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc desc);
                    /*0x12a3650*/ void CreateRendererLists(System.Collections.Generic.List<UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle> rendererLists, UnityEngine.Rendering.ScriptableRenderContext context, bool manualDispatch);
                    /*0x12a3050*/ void Clear(bool onException);
                    /*0x12a5ca0*/ void PurgeUnusedGraphicsResources();
                    /*0x12a2f00*/ void Cleanup();
                    /*0x12a4160*/ void FlushLogs();
                    /*0x12a5910*/ void LogResources();

                    class ResourceCreateCallback : System.MulticastDelegate
                    {
                        /*0x9deed0*/ ResourceCreateCallback(object object, nint method);
                        /*0x722200*/ bool Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                        /*0x98b3f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                        /*0xa75650*/ bool EndInvoke(System.IAsyncResult result);
                    }

                    class ResourceCallback : System.MulticastDelegate
                    {
                        /*0x722be0*/ ResourceCallback(object object, nint method);
                        /*0x722200*/ void Invoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res);
                        /*0x98b3f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext, UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource res, System.AsyncCallback callback, object object);
                        /*0x723cb0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class RenderGraphResourcesData
                    {
                        /*0x10*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource> resourceArray;
                        /*0x18*/ int sharedResourcesCount;
                        /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool;
                        /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback;
                        /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback;

                        /*0x12a6ed0*/ RenderGraphResourcesData();
                        /*0x12a6e10*/ void Clear(bool onException, int frameIndex);
                        /*0x12a6d70*/ void Cleanup();
                        /*0x12a6ea0*/ void PurgeUnusedGraphicsResources(int frameIndex);
                        /*0x2a5510*/ int AddNewRenderGraphResource<ResType>(ref ResType outRes, bool pooledResource);
                    }
                }

                struct RendererListHandle
                {
                    /*0x10*/ bool m_IsValid;
                    /*0x14*/ int <handle>k__BackingField;

                    static /*0xf57180*/ int op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle handle);
                    static /*0x12b0b70*/ UnityEngine.Rendering.RendererList op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle rendererList);
                    /*0xbad3d0*/ RendererListHandle(int handle);
                    /*0xa5a7c0*/ int get_handle();
                    /*0xfc2c10*/ void set_handle(int value);
                    /*0xbad660*/ bool IsValid();
                }

                struct RendererListResource
                {
                    /*0x10*/ UnityEngine.Rendering.RendererUtils.RendererListDesc desc;
                    /*0xe0*/ UnityEngine.Rendering.RendererList rendererList;

                    /*0x12b0c40*/ RendererListResource(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                }

                enum RenderGraphResourceType
                {
                    Texture = 0,
                    ComputeBuffer = 1,
                    Count = 2,
                }

                struct ResourceHandle
                {
                    static uint kValidityMask = 4294901760;
                    static uint kIndexMask = 65535;
                    static /*0x0*/ uint s_CurrentValidBit;
                    static /*0x4*/ uint s_SharedResourceValidBit;
                    /*0x10*/ uint m_Value;
                    /*0x14*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType <type>k__BackingField;

                    static /*0x12b0f00*/ ResourceHandle();
                    static /*0x12b1060*/ int op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle);
                    static /*0x12b0e10*/ void NewFrame(int executionIndex);
                    /*0x12b0f50*/ ResourceHandle(int value, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType type, bool shared);
                    /*0x6bba60*/ int get_index();
                    /*0xa5a7c0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType get_type();
                    /*0xfc2c10*/ void set_type(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType value);
                    /*0x12b1010*/ int get_iType();
                    /*0x12b0d80*/ bool IsValid();
                }

                class IRenderGraphResource
                {
                    /*0x10*/ bool imported;
                    /*0x11*/ bool shared;
                    /*0x12*/ bool sharedExplicitRelease;
                    /*0x13*/ bool requestFallBack;
                    /*0x14*/ uint writeCount;
                    /*0x18*/ int cachedHash;
                    /*0x1c*/ int transientPassIndex;
                    /*0x20*/ int sharedResourceLastFrameUsed;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool m_Pool;

                    /*0x32f970*/ IRenderGraphResource();
                    /*0x129daf0*/ void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                    /*0x129da90*/ string GetName();
                    /*0x348b00*/ bool IsCreated();
                    /*0x129dac0*/ void IncrementWriteCount();
                    /*0x129dad0*/ bool NeedsFallBack();
                    /*0x32d010*/ void CreatePooledGraphicsResource();
                    /*0x32d010*/ void CreateGraphicsResource(string name);
                    /*0x32d010*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x32d010*/ void ReleaseGraphicsResource();
                    /*0x32d010*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x32d010*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x388e90*/ int GetSortIndex();
                }

                class RenderGraphResource<DescType, ResType> : UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource
                {
                    /*0x0*/ DescType desc;
                    /*0x0*/ ResType graphicsResource;

                    /*0x180fc0*/ RenderGraphResource();
                    /*0x17aec0*/ void Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool pool);
                    /*0x17cb40*/ bool IsCreated();
                    /*0x180fc0*/ void ReleaseGraphicsResource();
                }

                struct TextureHandle
                {
                    static /*0x0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle s_NullHandle;
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle handle;

                    static /*0x32d010*/ TextureHandle();
                    static /*0x12b1600*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle get_nullHandle();
                    static /*0x12b18e0*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x12b1650*/ UnityEngine.Texture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x12b1800*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    static /*0x12b1730*/ UnityEngine.Rendering.RTHandle op_Implicit(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle texture);
                    /*0x12b15c0*/ TextureHandle(int handle, bool shared);
                    /*0x12b1570*/ bool IsValid();
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
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode sizeMode;
                    /*0x14*/ int width;
                    /*0x18*/ int height;
                    /*0x1c*/ int slices;
                    /*0x20*/ UnityEngine.Vector2 scale;
                    /*0x28*/ UnityEngine.Rendering.ScaleFunc func;
                    /*0x30*/ UnityEngine.Rendering.DepthBits depthBufferBits;
                    /*0x34*/ UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat;
                    /*0x38*/ UnityEngine.FilterMode filterMode;
                    /*0x3c*/ UnityEngine.TextureWrapMode wrapMode;
                    /*0x40*/ UnityEngine.Rendering.TextureDimension dimension;
                    /*0x44*/ bool enableRandomWrite;
                    /*0x45*/ bool useMipMap;
                    /*0x46*/ bool autoGenerateMips;
                    /*0x47*/ bool isShadowMap;
                    /*0x48*/ int anisoLevel;
                    /*0x4c*/ float mipMapBias;
                    /*0x50*/ UnityEngine.Rendering.MSAASamples msaaSamples;
                    /*0x54*/ bool bindTextureMS;
                    /*0x55*/ bool useDynamicScale;
                    /*0x58*/ UnityEngine.RenderTextureMemoryless memoryless;
                    /*0x5c*/ UnityEngine.VRTextureUsage vrUsage;
                    /*0x60*/ string name;
                    /*0x68*/ UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDesc fastMemoryDesc;
                    /*0x74*/ bool fallBackToBlackTexture;
                    /*0x75*/ bool disableFallBackToImportedTexture;
                    /*0x76*/ bool clearBuffer;
                    /*0x78*/ UnityEngine.Color clearColor;

                    /*0x12cdda0*/ TextureDesc(int width, int height, bool dynamicResolution, bool xrReady);
                    /*0x12cdd40*/ TextureDesc(UnityEngine.Vector2 scale, bool dynamicResolution, bool xrReady);
                    /*0x12cdc60*/ TextureDesc(UnityEngine.Rendering.ScaleFunc func, bool dynamicResolution, bool xrReady);
                    /*0x12cdcf0*/ TextureDesc(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc input);
                    /*0x12cdb80*/ void InitDefaultValues(bool dynamicResolution, bool xrReady);
                    /*0x12cd9a0*/ int GetHashCode();
                }

                class TextureResource : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource<UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc, UnityEngine.Rendering.RTHandle>
                {
                    static /*0x0*/ int m_TextureCreationIndex;

                    /*0x12cee00*/ TextureResource();
                    /*0x12cea70*/ string GetName();
                    /*0x12ce8d0*/ void CreatePooledGraphicsResource();
                    /*0x12cec90*/ void ReleasePooledGraphicsResource(int frameIndex);
                    /*0x12ce2f0*/ void CreateGraphicsResource(string name);
                    /*0x12cec30*/ void ReleaseGraphicsResource();
                    /*0x12ceae0*/ void LogCreation(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                    /*0x12ceba0*/ void LogRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger logger);
                }

                class TexturePool : UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool<UnityEngine.Rendering.RTHandle>
                {
                    /*0x12ce2b0*/ TexturePool();
                    /*0x12ce290*/ void ReleaseInternalResource(UnityEngine.Rendering.RTHandle res);
                    /*0x12cddf0*/ string GetResourceName(UnityEngine.Rendering.RTHandle res);
                    /*0x12cde20*/ long GetResourceSize(UnityEngine.Rendering.RTHandle res);
                    /*0x12cde50*/ string GetResourceTypeName();
                    /*0x12cde80*/ int GetSortIndex(UnityEngine.Rendering.RTHandle res);
                    /*0x12cdea0*/ void PurgeUnusedResources(int currentFrameIndex);
                }
            }
        }
    }

    namespace Rendering
    {
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

            /*0x12bba80*/ CameraSwitcher();
            /*0x12bb060*/ void OnEnable();
            /*0x12bafc0*/ void OnDisable();
            /*0x12baf50*/ int GetCameraCount();
            /*0x12baf70*/ UnityEngine.Camera GetNextCamera();
            /*0x12bb780*/ void SetCameraIndex(int index);
            /*0x3e3ae0*/ int <OnEnable>b__10_0();
            /*0x12bba60*/ void <OnEnable>b__10_1(int value);
            /*0x1101d10*/ int <OnEnable>b__10_2();
            /*0x12bba70*/ void <OnEnable>b__10_3(int value);
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

            static /*0x12cb9a0*/ FreeCamera();
            /*0x12cbbe0*/ FreeCamera();
            /*0x32d010*/ void OnEnable();
            /*0x32d010*/ void RegisterInputs();
            /*0x12cb150*/ void UpdateInputs();
            /*0x12cb330*/ void Update();
        }

        class CommandBufferPool
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.CommandBuffer> s_BufferPool;

            static /*0x12bbd70*/ CommandBufferPool();
            static /*0x12bbba0*/ UnityEngine.Rendering.CommandBuffer Get();
            static /*0x12bbc50*/ UnityEngine.Rendering.CommandBuffer Get(string name);
            static /*0x12bbcf0*/ void Release(UnityEngine.Rendering.CommandBuffer buffer);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.CommandBufferPool.<> <>9;

                static /*0x12cfc90*/ <>c();
                /*0x32f970*/ <>c();
                /*0x12cf1f0*/ void <.cctor>b__4_0(UnityEngine.Rendering.CommandBuffer x);
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

            static /*0x2a5510*/ TType get_instance();
            static /*0x180ff0*/ void Release();
        }

        class ConstantBuffer
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ConstantBufferBase> m_RegisteredConstantBuffers;

            static /*0x12bc0f0*/ ConstantBuffer();
            static /*0x183270*/ void PushGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            static /*0x1827f0*/ void PushGlobal<CBType>(ref CBType data, int shaderId);
            static /*0x183870*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x183270*/ void Push<CBType>(ref CBType data, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x183870*/ void Push<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x183270*/ void Push<CBType>(ref CBType data, UnityEngine.Material mat, int shaderId);
            static /*0x177670*/ void UpdateData<CBType>(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            static /*0x177be0*/ void UpdateData<CBType>(ref CBType data);
            static /*0x1827f0*/ void SetGlobal<CBType>(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            static /*0x1784c0*/ void SetGlobal<CBType>(int shaderId);
            static /*0x183270*/ void Set<CBType>(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1827f0*/ void Set<CBType>(UnityEngine.ComputeShader cs, int shaderId);
            static /*0x1827f0*/ void Set<CBType>(UnityEngine.Material mat, int shaderId);
            static /*0x12bbf50*/ void ReleaseAll();
            static /*0x12bbe80*/ void Register(UnityEngine.Rendering.ConstantBufferBase cb);
            /*0x32f970*/ ConstantBuffer();
        }

        class ConstantBufferBase
        {
            /*0x32f970*/ ConstantBufferBase();
            /*0x180fc0*/ void Release();
        }

        class ConstantBuffer<CBType> : UnityEngine.Rendering.ConstantBufferBase
        {
            /*0x0*/ System.Collections.Generic.HashSet<int> m_GlobalBindings;
            /*0x0*/ CBType[] m_Data;
            /*0x0*/ UnityEngine.ComputeBuffer m_GPUConstantBuffer;

            /*0x180fc0*/ ConstantBuffer();
            /*0x183150*/ void UpdateData(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data);
            /*0x17aec0*/ void UpdateData(ref CBType data);
            /*0x182a70*/ void SetGlobal(UnityEngine.Rendering.CommandBuffer cmd, int shaderId);
            /*0x17aa40*/ void SetGlobal(int shaderId);
            void Set(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs, int shaderId);
            /*0x182a70*/ void Set(UnityEngine.ComputeShader cs, int shaderId);
            /*0x182a70*/ void Set(UnityEngine.Material mat, int shaderId);
            void PushGlobal(UnityEngine.Rendering.CommandBuffer cmd, ref CBType data, int shaderId);
            /*0x182a70*/ void PushGlobal(ref CBType data, int shaderId);
            /*0x180fc0*/ void Release();
        }

        class ConstantBufferSingleton<CBType> : UnityEngine.Rendering.ConstantBuffer<CBType>
        {
            static /*0x0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> s_Instance;

            static /*0x180cf0*/ UnityEngine.Rendering.ConstantBufferSingleton<CBType> get_instance();
            static /*0x177be0*/ void set_instance(UnityEngine.Rendering.ConstantBufferSingleton<CBType> value);
            /*0x180fc0*/ ConstantBufferSingleton();
            /*0x180fc0*/ void Release();
        }

        class DisplayInfoAttribute : System.Attribute
        {
            /*0x10*/ string name;
            /*0x18*/ int order;

            /*0x534220*/ DisplayInfoAttribute();
        }

        class AdditionalPropertyAttribute : System.Attribute
        {
            /*0x534220*/ AdditionalPropertyAttribute();
        }

        enum CoreProfileId
        {
            BlitTextureInPotAtlas = 0,
            APVCellStreamingUpdate = 1,
            APVScenarioBlendingUpdate = 2,
        }

        class CoreUnsafeUtils
        {
            static /*0x2a5510*/ void CopyTo<T>(System.Collections.Generic.List<T> list, void* dest, int count);
            static /*0x2a5510*/ void CopyTo<T>(T[] list, void* dest, int count);
            static /*0x12bc970*/ void CalculateRadixParams(int radixBits, ref int bitStates);
            static /*0x12bca30*/ int CalculateRadixSupportSize(int bitStates, int arrayLength);
            static /*0x12bc9f0*/ void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, ref uint* bucketIndices, ref uint* bucketSizes, ref uint* bucketPrefix, ref uint* arrayOutput);
            static /*0x12bcf40*/ void MergeSort(uint* array, uint* support, int length);
            static /*0x12bd120*/ void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray);
            static /*0x12bce40*/ void MergeSort(Unity.Collections.NativeArray<uint> arr, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray);
            static /*0x12bcd20*/ void InsertionSort(uint* arr, int length);
            static /*0x12bcd70*/ void InsertionSort(uint[] arr, int sortSize);
            static /*0x12bcc30*/ void InsertionSort(Unity.Collections.NativeArray<uint> arr, int sortSize);
            static /*0x12bd280*/ void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length);
            static /*0x12bd440*/ void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits);
            static /*0x12bd5c0*/ void RadixSort(Unity.Collections.NativeArray<uint> array, int sortSize, ref Unity.Collections.NativeArray<uint> supportArray, int radixBits);
            static /*0x12bd210*/ void QuickSort(uint[] arr, int left, int right);
            static /*0x2a5510*/ void QuickSort<T>(int count, void* data);
            static /*0x2a5510*/ void QuickSort<TValue, TKey, TGetter>(int count, void* data);
            static /*0x2a5510*/ void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x2a5510*/ int IndexOf<T>(void* data, int count, T v);
            static /*0x2a5510*/ int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x12bcaa0*/ int CompareHashes(int oldHashCount, UnityEngine.Hash128* oldHashes, int newHashCount, UnityEngine.Hash128* newHashes, int* addIndices, int* removeIndices, ref int addCount, ref int remCount);
            static /*0x2a5510*/ void CombineHashes<TValue, TGetter>(int count, void* hashes, UnityEngine.Hash128* outHash);
            static /*0x12bca40*/ void CombineHashes(int count, UnityEngine.Hash128* hashes, UnityEngine.Hash128* outHash);
            static /*0x2a5510*/ int Partition<TValue, TKey, TGetter>(void* data, int left, int right);
            static /*0x12bcb10*/ bool HaveDuplicates(int[] arr);

            struct FixedBufferStringQueue
            {
                /*0x10*/ byte* m_ReadCursor;
                /*0x18*/ byte* m_WriteCursor;
                /*0x20*/ byte* m_BufferEnd;
                /*0x28*/ byte* m_BufferStart;
                /*0x30*/ int m_BufferLength;
                /*0x34*/ int <Count>k__BackingField;

                /*0x12caf40*/ FixedBufferStringQueue(byte* ptr, int length);
                /*0x3e3ad0*/ int get_Count();
                /*0xc70b30*/ void set_Count(int value);
                /*0x12cae90*/ bool TryPush(string v);
                /*0x12cae00*/ bool TryPop(ref string v);
                /*0x12cadd0*/ void Clear();
            }

            interface IKeyGetter<TValue, TKey>
            {
                /*0x2a5510*/ TKey Get(ref TValue v);
            }

            struct DefaultKeyGetter<T> : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<T, T>
            {
                /*0x2a5510*/ T Get(ref T v);
            }

            struct UintKeyGetter : UnityEngine.Rendering.CoreUnsafeUtils.IKeyGetter<uint, uint>
            {
                /*0x798800*/ uint Get(ref uint v);
            }
        }

        class DynamicArray<T>
        {
            /*0x0*/ T[] m_Array;
            /*0x0*/ int <size>k__BackingField;

            static /*0x17e030*/ T[] op_Implicit(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x180fc0*/ DynamicArray();
            /*0x17aa40*/ DynamicArray(int size);
            /*0x180980*/ int get_size();
            /*0x17aa40*/ void set_size(int value);
            /*0x180980*/ int get_capacity();
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(T item);
            /*0x17b580*/ int Add(ref T value);
            /*0x17aec0*/ void AddRange(UnityEngine.Rendering.DynamicArray<T> array);
            /*0x2a5510*/ bool Remove(T item);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x2a5510*/ int FindIndex(int startIndex, int count, System.Predicate<T> match);
            /*0x2a5510*/ int IndexOf(T item, int index, int count);
            /*0x2a5510*/ int IndexOf(T item, int index);
            /*0x2a5510*/ int IndexOf(T item);
            void Resize(int newSize, bool keepContent);
            void Reserve(int newCapacity, bool keepContent);
            /*0x184ab0*/ ref T get_Item(int index);
            /*0x2a5510*/ UnityEngine.Rendering.DynamicArray.Iterator<T> GetEnumerator();
            /*0x2a5510*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems);
            /*0x180fc0*/ void BumpVersion();

            struct Iterator<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                /*0x0*/ int index;

                /*0x17aec0*/ Iterator(UnityEngine.Rendering.DynamicArray<T> setOwner);
                /*0x1803b0*/ ref T get_Current();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
            }

            struct RangeEnumerable<T>
            {
                /*0x0*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> iterator;

                /*0x2a5510*/ UnityEngine.Rendering.DynamicArray.RangeEnumerable.RangeIterator<T> GetEnumerator();

                struct RangeIterator<T>
                {
                    /*0x0*/ UnityEngine.Rendering.DynamicArray<T> owner;
                    /*0x0*/ int index;
                    /*0x0*/ int first;
                    /*0x0*/ int last;

                    RangeIterator(UnityEngine.Rendering.DynamicArray<T> setOwner, int first, int numItems);
                    /*0x1803b0*/ ref T get_Current();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x180fc0*/ void Reset();
                }
            }
        }

        class DynamicArrayExtensions
        {
            static /*0x17c550*/ int Partition<T>(T[] data, int left, int right);
            static /*0x182b00*/ void QuickSort<T>(T[] data, int left, int right);
            static /*0x177be0*/ void QuickSort<T>(UnityEngine.Rendering.DynamicArray<T> array);
        }

        class PerformDynamicRes : System.MulticastDelegate
        {
            /*0x9dc300*/ PerformDynamicRes(object object, nint method);
            /*0x9dbe20*/ float Invoke();
            /*0x1121b60*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x12cc660*/ float EndInvoke(System.IAsyncResult result);
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
            /*0x54*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings m_CachedSettings;
            /*0x90*/ System.WeakReference m_OwnerCameraWeakRef;
            /*0x98*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule;

            static /*0x12ca2d0*/ DynamicResolutionHandler();
            static /*0x12c9040*/ UnityEngine.Rendering.DynamicResolutionHandler GetOrCreateDrsInstanceHandler(UnityEngine.Camera camera);
            static /*0x12ca7e0*/ UnityEngine.Rendering.DynamicResolutionHandler get_instance();
            static /*0x12c8cc0*/ float DefaultDynamicResMethod();
            static /*0x12c9ab0*/ void SetDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x12c9b70*/ void SetSystemDynamicResScaler(UnityEngine.Rendering.PerformDynamicRes scaler, UnityEngine.Rendering.DynamicResScalePolicyType scalerType);
            static /*0x12c9a50*/ void SetActiveDynamicScalerSlot(UnityEngine.Rendering.DynamicResScalerSlot slot);
            static /*0x12c8c30*/ void ClearSelectedCamera();
            static /*0x12c9c30*/ void SetUpscaleFilter(UnityEngine.Camera camera, UnityEngine.Rendering.DynamicResUpscaleFilter filter);
            static /*0x12c9db0*/ void UpdateAndUseCamera(UnityEngine.Camera camera, System.Nullable<UnityEngine.Rendering.GlobalDynamicResolutionSettings> settings, System.Action OnResolutionChange);
            /*0x12ca6c0*/ DynamicResolutionHandler();
            /*0x12c9a00*/ void Reset();
            /*0x12ca7d0*/ UnityEngine.Rendering.DynamicResUpscaleFilter get_filter();
            /*0x12ca860*/ void set_filter(UnityEngine.Rendering.DynamicResUpscaleFilter value);
            /*0x4e40d0*/ UnityEngine.Vector2Int get_finalViewport();
            /*0x12a10c0*/ void set_finalViewport(UnityEngine.Vector2Int value);
            /*0x12a21f0*/ void set_runUpscalerFilterOnFullResolution(bool value);
            /*0x12ca830*/ bool get_runUpscalerFilterOnFullResolution();
            /*0x12c8d00*/ bool FlushScalableBufferManagerState();
            /*0x12ca870*/ void set_upsamplerSchedule(UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType value);
            /*0x12ca850*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule();
            /*0x12c97c0*/ void ProcessSettings(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings);
            /*0x12c9570*/ UnityEngine.Vector2 GetResolvedScale();
            /*0x12c8b90*/ float CalculateMipBias(UnityEngine.Vector2Int inputResolution, UnityEngine.Vector2Int outputResolution, bool forceApply);
            /*0xff32d0*/ void SetCurrentCameraRequest(bool cameraRequest);
            /*0x12c9fe0*/ void Update(UnityEngine.Rendering.GlobalDynamicResolutionSettings settings, System.Action OnResolutionChange);
            /*0x12c9d70*/ bool SoftwareDynamicResIsEnabled();
            /*0x12c97a0*/ bool HardwareDynamicResIsEnabled();
            /*0x12c99e0*/ bool RequestsHardwareDynamicResolution();
            /*0x12c8cd0*/ bool DynamicResolutionEnabled();
            /*0x12c8e60*/ void ForceSoftwareFallback();
            /*0x12c95e0*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int size);
            /*0x12c8890*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size);
            /*0x12c8a40*/ UnityEngine.Vector2Int ApplyScalesOnSize(UnityEngine.Vector2Int size, UnityEngine.Vector2 scales);
            /*0x12c8e70*/ float GetCurrentScale();
            /*0x12c8e90*/ UnityEngine.Vector2Int GetLastScaledSize();
            /*0x12c8f70*/ float GetLowResMultiplier(float targetLowRes);
            /*0x12c8ea0*/ float GetLowResMultiplier(float targetLowRes, float minimumThreshold);

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

        struct GlobalDynamicResolutionSettings
        {
            /*0x10*/ bool enabled;
            /*0x11*/ bool useMipBias;
            /*0x12*/ bool enableDLSS;
            /*0x14*/ uint DLSSPerfQualitySetting;
            /*0x18*/ UnityEngine.Rendering.DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;
            /*0x1c*/ bool DLSSUseOptimalSettings;
            /*0x20*/ float DLSSSharpness;
            /*0x24*/ bool fsrOverrideSharpness;
            /*0x28*/ float fsrSharpness;
            /*0x2c*/ float maxPercentage;
            /*0x30*/ float minPercentage;
            /*0x34*/ UnityEngine.Rendering.DynamicResolutionType dynResType;
            /*0x35*/ UnityEngine.Rendering.DynamicResUpscaleFilter upsampleFilter;
            /*0x36*/ bool forceResolution;
            /*0x38*/ float forcedPercentage;
            /*0x3c*/ float lowResTransparencyMinimumThreshold;
            /*0x40*/ float rayTracingHalfResThreshold;
            /*0x44*/ float lowResSSGIMinimumThreshold;
            /*0x48*/ float lowResVolumetricCloudsMinimumThreshold;

            static /*0x12cbc10*/ UnityEngine.Rendering.GlobalDynamicResolutionSettings NewDefault();
        }

        interface IAdditionalData
        {
        }

        interface IVirtualTexturingEnabledRenderPipeline
        {
            /*0x17cb40*/ bool get_virtualTexturingEnabled();
        }

        struct ListBuffer<T>
        {
            /*0x0*/ T* m_BufferPtr;
            /*0x0*/ int m_Capacity;
            /*0x0*/ int* m_CountPtr;

            /*0x2a5510*/ ListBuffer(T* bufferPtr, int* countPtr, int capacity);
            /*0x2a5510*/ T* get_BufferPtr();
            /*0x180980*/ int get_Count();
            /*0x180980*/ int get_Capacity();
            /*0x1858d0*/ ref T get_Item(ref int index);
            /*0x1858d0*/ ref T GetUnchecked(ref int index);
            /*0x17e620*/ bool TryAdd(ref T value);
            /*0x2a5510*/ void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
            /*0x2a5510*/ bool TryCopyTo(UnityEngine.Rendering.ListBuffer<T> other);
            /*0x2a5510*/ bool TryCopyFrom(T* srcPtr, int count);
        }

        class ListBufferExtensions
        {
            static /*0x2a5510*/ void QuickSort<T>(UnityEngine.Rendering.ListBuffer<T> self);
        }

        class ObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
            /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <countAll>k__BackingField;

            ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease, bool collectionCheck);
            /*0x180980*/ int get_countAll();
            /*0x17aa40*/ void set_countAll(int value);
            /*0x180980*/ int get_countActive();
            /*0x180980*/ int get_countInactive();
            /*0x2a5510*/ T Get();
            /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T v);
            /*0x2a5510*/ void Release(T element);

            struct PooledObject<T> : System.IDisposable
            {
                /*0x0*/ T m_ToReturn;
                /*0x0*/ UnityEngine.Rendering.ObjectPool<T> m_Pool;

                /*0x2a5510*/ PooledObject(T value, UnityEngine.Rendering.ObjectPool<T> pool);
                /*0x180fc0*/ void System.IDisposable.Dispose();
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x180ff0*/ GenericPool();
            static /*0x2a5510*/ T Get();
            static /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x2a5510*/ void Release(T toRelease);
        }

        class UnsafeGenericPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<T> s_Pool;

            static /*0x180ff0*/ UnsafeGenericPool();
            static /*0x2a5510*/ T Get();
            static /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<T> Get(ref T value);
            static /*0x2a5510*/ void Release(T toRelease);
        }

        class ListPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<T>> s_Pool;

            static /*0x180ff0*/ ListPool();
            static /*0x180cf0*/ System.Collections.Generic.List<T> Get();
            static /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.List<T>> Get(ref System.Collections.Generic.List<T> value);
            static /*0x177be0*/ void Release(System.Collections.Generic.List<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ListPool.<>c<T> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x17aec0*/ void <.cctor>b__4_0(System.Collections.Generic.List<T> l);
            }
        }

        class HashSetPool<T>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.HashSet<T>> s_Pool;

            static /*0x180ff0*/ HashSetPool();
            static /*0x180cf0*/ System.Collections.Generic.HashSet<T> Get();
            static /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.HashSet<T>> Get(ref System.Collections.Generic.HashSet<T> value);
            static /*0x177be0*/ void Release(System.Collections.Generic.HashSet<T> toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.HashSetPool.<>c<T> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x17aec0*/ void <.cctor>b__4_0(System.Collections.Generic.HashSet<T> l);
            }
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.Dictionary<TKey, TValue>> s_Pool;

            static /*0x180ff0*/ DictionaryPool();
            static /*0x180cf0*/ System.Collections.Generic.Dictionary<TKey, TValue> Get();
            static /*0x2a5510*/ UnityEngine.Rendering.ObjectPool.PooledObject<System.Collections.Generic.Dictionary<TKey, TValue>> Get(ref System.Collections.Generic.Dictionary<TKey, TValue> value);
            static /*0x177be0*/ void Release(System.Collections.Generic.Dictionary<TKey, TValue> toRelease);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ UnityEngine.Rendering.DictionaryPool.<>c<TKey, TValue> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x17aec0*/ void <.cctor>b__4_0(System.Collections.Generic.Dictionary<TKey, TValue> l);
            }
        }

        class ListChangedEventArgs<T> : System.EventArgs
        {
            /*0x0*/ int index;
            /*0x0*/ T item;

            /*0x2a5510*/ ListChangedEventArgs(int index, T item);
        }

        class ListChangedEventHandler<T> : System.MulticastDelegate
        {
            ListChangedEventHandler(object object, nint method);
            /*0x183150*/ void Invoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e);
            /*0x177ff0*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ObservableList<T> sender, UnityEngine.Rendering.ListChangedEventArgs<T> e, System.AsyncCallback callback, object object);
            /*0x17aec0*/ void EndInvoke(System.IAsyncResult result);
        }

        class ObservableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<T> m_List;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemAdded;
            /*0x0*/ UnityEngine.Rendering.ListChangedEventHandler<T> ItemRemoved;

            /*0x180fc0*/ ObservableList();
            /*0x17aa40*/ ObservableList(int capacity);
            /*0x17aec0*/ ObservableList(System.Collections.Generic.IEnumerable<T> collection);
            /*0x17aec0*/ void add_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x17aec0*/ void remove_ItemAdded(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x17aec0*/ void add_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x17aec0*/ void remove_ItemRemoved(UnityEngine.Rendering.ListChangedEventHandler<T> value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x2a5510*/ void OnEvent(UnityEngine.Rendering.ListChangedEventHandler<T> e, int index, T item);
            /*0x2a5510*/ bool Contains(T item);
            /*0x2a5510*/ int IndexOf(T item);
            /*0x2a5510*/ void Add(T item);
            /*0x17aec0*/ void Add(T[] items);
            /*0x2a5510*/ void Insert(int index, T item);
            /*0x2a5510*/ bool Remove(T item);
            /*0x17b580*/ int Remove(T[] items);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x180fc0*/ void Clear();
            /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class RemoveRangeExtensions
        {
            static /*0x2a5510*/ bool TryRemoveElementsInRange<TValue>(System.Collections.Generic.IList<TValue> list, int index, int count, ref System.Exception error);
        }

        class SerializableEnum
        {
            /*0x10*/ string m_EnumValueAsString;
            /*0x18*/ string m_EnumTypeAsString;

            /*0x12cc830*/ SerializableEnum(System.Type enumType);
            /*0x12cc8f0*/ System.Enum get_value();
            /*0x12cca30*/ void set_value(System.Enum value);
        }

        class SerializedDictionary<K, V> : UnityEngine.Rendering.SerializedDictionary<K, V, K, V>
        {
            /*0x180fc0*/ SerializedDictionary();
            /*0x2a5510*/ K SerializeKey(K key);
            /*0x2a5510*/ V SerializeValue(V val);
            /*0x2a5510*/ K DeserializeKey(K key);
            /*0x2a5510*/ V DeserializeValue(V val);
        }

        class SerializedDictionary<K, V, SK, SV> : System.Collections.Generic.Dictionary<K, V>, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x0*/ System.Collections.Generic.List<SK> m_Keys;
            /*0x0*/ System.Collections.Generic.List<SV> m_Values;

            /*0x180fc0*/ SerializedDictionary();
            /*0x2a5510*/ SK SerializeKey(K key);
            /*0x2a5510*/ SV SerializeValue(V value);
            /*0x2a5510*/ K DeserializeKey(SK serializedKey);
            /*0x2a5510*/ V DeserializeValue(SV serializedValue);
            /*0x180fc0*/ void OnBeforeSerialize();
            /*0x180fc0*/ void OnAfterDeserialize();
        }

        class SwapCollectionExtensions
        {
            static /*0x2a5510*/ bool TrySwap<TValue>(System.Collections.Generic.IList<TValue> list, int from, int to, ref System.Exception error);
        }

        class XRGraphics
        {
            static /*0x12d29f0*/ float get_eyeTextureResolutionScale();
            static /*0x12d2b70*/ void set_eyeTextureResolutionScale(float value);
            static /*0x12d2ac0*/ float get_renderViewportScale();
            static /*0x12d2930*/ bool get_enabled();
            static /*0x12d2a50*/ bool get_isDeviceActive();
            static /*0x12d2a70*/ string get_loadedDeviceName();
            static /*0x12d2b20*/ string[] get_supportedDevices();
            static /*0x12d2af0*/ UnityEngine.Rendering.XRGraphics.StereoRenderingMode get_stereoRenderingMode();
            static /*0x12d2940*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x12d2a20*/ int get_eyeTextureWidth();
            static /*0x12d29c0*/ int get_eyeTextureHeight();
            /*0x32f970*/ XRGraphics();

            enum StereoRenderingMode
            {
                MultiPass = 0,
                SinglePass = 1,
                SinglePassInstanced = 2,
                SinglePassMultiView = 3,
            }
        }

        class DebugDisplaySettings<T> : UnityEngine.Rendering.IDebugDisplaySettings, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            static /*0x0*/ System.Lazy<T> s_Instance;
            /*0x0*/ System.Collections.Generic.HashSet<UnityEngine.Rendering.IDebugDisplaySettingsData> m_Settings;

            static /*0x180ff0*/ DebugDisplaySettings();
            static /*0x2a5510*/ T get_Instance();
            /*0x180fc0*/ DebugDisplaySettings();
            /*0x17cb40*/ bool get_AreAnySettingsActive();
            /*0x17cb40*/ bool get_IsPostProcessingAllowed();
            /*0x17cb40*/ bool get_IsLightingActive();
            /*0x2a5510*/ TData Add<TData>(TData newData);
            /*0x17aec0*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
            /*0x180fc0*/ void Reset();
            /*0x17e620*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.DebugDisplaySettings.<>c<T> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x2a5510*/ T <.cctor>b__15_0();
            }
        }

        class DebugDisplaySettingsPanel : UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable, UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> m_Widgets;
            /*0x18*/ UnityEngine.Rendering.DisplayInfoAttribute m_DisplayInfo;

            /*0x12bde10*/ DebugDisplaySettingsPanel();
            /*0x12bdf40*/ string get_PanelName();
            /*0x12bdf30*/ int get_Order();
            /*0x12bdf90*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x388e90*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
            /*0x12bdd00*/ void AddWidget(UnityEngine.Rendering.DebugUI.Widget widget);
            /*0x12bddb0*/ void Clear();
            /*0x12bddb0*/ void Dispose();
        }

        class DebugDisplaySettingsPanel<T> : UnityEngine.Rendering.DebugDisplaySettingsPanel
        {
            /*0x0*/ T m_Data;

            /*0x2a5510*/ DebugDisplaySettingsPanel(T data);
            /*0x2a5510*/ T get_data();
            /*0x2a5510*/ void set_data(T value);
        }

        class DebugDisplaySettingsUI : UnityEngine.Rendering.IDebugData
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;
            /*0x18*/ UnityEngine.Rendering.IDebugDisplaySettings m_Settings;

            /*0x32f970*/ DebugDisplaySettingsUI();
            /*0x12be310*/ void Reset();
            /*0x12be050*/ void RegisterDebug(UnityEngine.Rendering.IDebugDisplaySettings settings);
            /*0x12be3b0*/ void UnregisterDebug();
            /*0x12bdfe0*/ System.Action GetReset();

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager debugManager;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable> panels;

                /*0x32f970*/ <>c__DisplayClass3_0();
                /*0x12cf5f0*/ void <RegisterDebug>b__0(UnityEngine.Rendering.IDebugDisplaySettingsData data);
            }
        }

        class DebugDisplaySettingsVolume : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x10*/ UnityEngine.Rendering.IVolumeDebugSettings2 <volumeDebugSettings>k__BackingField;
            /*0x18*/ int volumeComponentEnumIndex;

            /*0x49b490*/ DebugDisplaySettingsVolume(UnityEngine.Rendering.IVolumeDebugSettings2 volumeDebugSettings);
            /*0x73d3e0*/ UnityEngine.Rendering.IVolumeDebugSettings2 get_volumeDebugSettings();
            /*0x348b00*/ bool get_AreAnySettingsActive();
            /*0x3ce290*/ bool get_IsPostProcessingAllowed();
            /*0x3ce290*/ bool get_IsLightingActive();
            /*0x348b00*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
            /*0x12be870*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

            class Styles
            {
                static /*0x0*/ UnityEngine.GUIContent none;
                static /*0x8*/ UnityEngine.GUIContent editorCamera;

                static /*0x12cd420*/ Styles();
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

                static /*0x12ccf80*/ Strings();
            }

            class WidgetFactory
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Value s_EmptyDebugUIValue;

                static /*0x12d25c0*/ WidgetFactory();
                static /*0x12d0370*/ UnityEngine.Rendering.DebugUI.EnumField CreateComponentSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> refresh);
                static /*0x12d0140*/ UnityEngine.Rendering.DebugUI.ObjectPopupField CreateCameraSelector(UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel, System.Action<UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>, UnityEngine.Object> refresh);
                static /*0x12d0ac0*/ UnityEngine.Rendering.DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, UnityEngine.Rendering.VolumeParameter param, System.Func<bool> isHiddenCallback);
                static /*0x12d20a0*/ UnityEngine.Rendering.VolumeComponent GetSelectedVolumeComponent(UnityEngine.Rendering.VolumeProfile profile, System.Type selectedType);
                static /*0x12d1b60*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x12d0b40*/ UnityEngine.Rendering.DebugUI.Table CreateVolumeTable(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                static /*0x12d2260*/ void SetTableColumnVisibility(UnityEngine.Rendering.DebugDisplaySettingsVolume data, UnityEngine.Rendering.DebugUI.Table table);
                static /*0x12d0db0*/ void GenerateTableColumns(UnityEngine.Rendering.DebugUI.Table table, UnityEngine.Rendering.DebugDisplaySettingsVolume data, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);
                static /*0x12d1790*/ void GenerateTableRows(UnityEngine.Rendering.DebugUI.Table table, System.Collections.Generic.List<UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain);

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

                    static /*0x12cfbb0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x12cf080*/ object <GenerateTableColumns>b__9_2();
                    /*0x12cf1b0*/ object <.cctor>b__11_0();
                }

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x32f970*/ <>c__DisplayClass0_0();
                    /*0x12cf260*/ int <CreateComponentSelector>b__0();
                    /*0x12cf2d0*/ void <CreateComponentSelector>b__1(int value);
                    /*0x12cf350*/ int <CreateComponentSelector>b__2();
                    /*0x12cf3a0*/ void <CreateComponentSelector>b__3(int value);
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.SettingsPanel panel;

                    /*0x32f970*/ <>c__DisplayClass1_0();
                    /*0x12cf400*/ UnityEngine.Object <CreateCameraSelector>b__0();
                    /*0x12cf470*/ void <CreateCameraSelector>b__1(UnityEngine.Object value);
                    /*0x12cf580*/ System.Collections.Generic.IEnumerable<UnityEngine.Object> <CreateCameraSelector>b__2();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ float timer;
                    /*0x14*/ float refreshRate;
                    /*0x18*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;
                    /*0x20*/ UnityEngine.Rendering.DebugUI.Table table;
                    /*0x28*/ UnityEngine.Rendering.Volume[] volumes;

                    /*0x32f970*/ <>c__DisplayClass7_0();
                    /*0x12cf820*/ bool <CreateVolumeTable>b__0();
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume data;

                    /*0x32f970*/ <>c__DisplayClass9_0();
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain;
                    /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume.WidgetFactory.<> CS$<>8__locals1;

                    /*0x32f970*/ <>c__DisplayClass9_1();
                    /*0x12cf9f0*/ object <GenerateTableColumns>b__0();
                    /*0x997630*/ UnityEngine.Object <GenerateTableColumns>b__1();
                    /*0x61a260*/ UnityEngine.Object <GenerateTableColumns>b__3();
                }
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.DebugDisplaySettingsVolume>
            {
                /*0x28*/ UnityEngine.Rendering.DebugUI.Table m_VolumeTable;

                /*0x12ccd60*/ SettingsPanel(UnityEngine.Rendering.DebugDisplaySettingsVolume data);
                /*0x12cca80*/ void Refresh();
                /*0x12ccd50*/ void <.ctor>b__0_0(UnityEngine.Rendering.DebugUI.Field<int> _, int __);
                /*0x12ccd50*/ void <.ctor>b__0_1(UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object> _, UnityEngine.Object __);
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

            /*0x12c0e60*/ DebugFrameTiming();
            /*0x3e3af0*/ int get_bottleneckHistorySize();
            /*0x11172b0*/ void set_bottleneckHistorySize(int value);
            /*0x3e3ad0*/ int get_sampleHistorySize();
            /*0xc70b30*/ void set_sampleHistorySize(int value);
            /*0x12c0c30*/ void UpdateFrameTiming();
            /*0x12be8d0*/ void RegisterDebugUI(System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Widget> list);
            /*0x12c03b0*/ void Reset();
            /*0x12c03f0*/ object <RegisterDebugUI>b__17_0();
            /*0x12c0810*/ object <RegisterDebugUI>b__17_1();
            /*0x12c0930*/ object <RegisterDebugUI>b__17_2();
            /*0x12c0990*/ object <RegisterDebugUI>b__17_3();
            /*0x12c09f0*/ object <RegisterDebugUI>b__17_4();
            /*0x12c0a50*/ object <RegisterDebugUI>b__17_5();
            /*0x12c0ab0*/ object <RegisterDebugUI>b__17_6();
            /*0x12c0b10*/ object <RegisterDebugUI>b__17_7();
            /*0x12c0b70*/ object <RegisterDebugUI>b__17_8();
            /*0x12c0bd0*/ object <RegisterDebugUI>b__17_9();
            /*0x12c0450*/ object <RegisterDebugUI>b__17_10();
            /*0x12c04b0*/ object <RegisterDebugUI>b__17_11();
            /*0x12c0510*/ object <RegisterDebugUI>b__17_12();
            /*0x12c0570*/ object <RegisterDebugUI>b__17_13();
            /*0x12c05d0*/ object <RegisterDebugUI>b__17_14();
            /*0x12c0630*/ object <RegisterDebugUI>b__17_15();
            /*0x12c0690*/ object <RegisterDebugUI>b__17_16();
            /*0x12c06f0*/ object <RegisterDebugUI>b__17_17();
            /*0x12c0750*/ object <RegisterDebugUI>b__17_18();
            /*0x12c07b0*/ object <RegisterDebugUI>b__17_19();
            /*0x12c0870*/ object <RegisterDebugUI>b__17_20();
            /*0x12c08d0*/ object <RegisterDebugUI>b__17_21();
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

            static /*0x12c3e20*/ DebugManager();
            static /*0x12c4600*/ UnityEngine.Rendering.DebugManager get_instance();
            static /*0x12c43c0*/ void add_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            static /*0x12c4920*/ void remove_windowStateChanged(System.Action<UnityEngine.Rendering.DebugManager.UIMode, bool> value);
            /*0x12c3f30*/ DebugManager();
            /*0x12c25e0*/ void RegisterActions();
            /*0x32d010*/ void EnableInputActions();
            /*0x12c0f50*/ void AddAction(UnityEngine.Rendering.DebugAction action, UnityEngine.Rendering.DebugActionDesc desc);
            /*0x12c3410*/ void SampleAction(int actionIndex);
            /*0x12c3ca0*/ void UpdateAction(int actionIndex);
            /*0x12c3d00*/ void UpdateActions();
            /*0x12c15c0*/ float GetAction(UnityEngine.Rendering.DebugAction action);
            /*0x12c1450*/ bool GetActionToggleDebugMenuWithTouch();
            /*0x12c13c0*/ bool GetActionReleaseScrollTarget();
            /*0x32d010*/ void RegisterInputs();
            /*0x12c3da0*/ void UpdateReadOnlyCollection();
            /*0x12c4700*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.DebugUI.Panel> get_panels();
            /*0x12c41d0*/ void add_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x12c4730*/ void remove_onDisplayRuntimeUIChanged(System.Action<bool> value);
            /*0x12c4280*/ void add_onSetDirty(System.Action value);
            /*0x12c47e0*/ void remove_onSetDirty(System.Action value);
            /*0x12c4320*/ void add_resetData(System.Action value);
            /*0x12c4880*/ void remove_resetData(System.Action value);
            /*0x12c4670*/ bool get_isAnyDebugUIActive();
            /*0x12c25d0*/ void RefreshEditor();
            /*0x12c33c0*/ void Reset();
            /*0x12c25a0*/ void ReDrawOnScreenDebug();
            /*0x12c2fc0*/ void RegisterData(UnityEngine.Rendering.IDebugData data);
            /*0x12c3bb0*/ void UnregisterData(UnityEngine.Rendering.IDebugData data);
            /*0x12c22a0*/ int GetState();
            /*0x12c30b0*/ void RegisterRootCanvas(UnityEngine.Rendering.UI.DebugUIHandlerCanvas root);
            /*0x12c10a0*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
            /*0x12c36f0*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
            /*0x12c10c0*/ void EnsurePersistentCanvas();
            /*0x12c37a0*/ void TogglePersistent(UnityEngine.Rendering.DebugUI.Widget widget, System.Nullable<int> forceTupleIndex);
            /*0x12c23d0*/ void OnPanelDirty(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x12c24b0*/ int PanelIndex(string displayName);
            /*0x12c2400*/ string PanelDiplayName(int panelIndex);
            /*0x12c3360*/ void RequestEditorWindowPanelIndex(int index);
            /*0x12c2290*/ System.Nullable<int> GetRequestedEditorWindowPanelIndex();
            /*0x12c1f20*/ UnityEngine.Rendering.DebugUI.Panel GetPanel(string displayName, bool createIfNull, int groupIndex, bool overrideIfExist);
            /*0x12c12e0*/ int FindPanelIndex(string displayName);
            /*0x12c3100*/ void RemovePanel(string displayName);
            /*0x12c32f0*/ void RemovePanel(UnityEngine.Rendering.DebugUI.Panel panel);
            /*0x12c1cd0*/ UnityEngine.Rendering.DebugUI.Widget[] GetItems(UnityEngine.Rendering.DebugUI.Flags flags);
            /*0x12c1940*/ UnityEngine.Rendering.DebugUI.Widget[] GetItemsFromContainer(UnityEngine.Rendering.DebugUI.Flags flags, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x12c1800*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath);
            /*0x12c1600*/ UnityEngine.Rendering.DebugUI.Widget GetItem(string queryPath, UnityEngine.Rendering.DebugUI.IContainer container);
            /*0x12c44d0*/ bool get_displayEditorUI();
            /*0x12c3780*/ void set_displayEditorUI(bool value);
            /*0x12c45f0*/ bool get_enableRuntimeUI();
            /*0x12c4d50*/ void set_enableRuntimeUI(bool value);
            /*0x12c4570*/ bool get_displayRuntimeUI();
            /*0x12c4ad0*/ void set_displayRuntimeUI(bool value);
            /*0x12c44f0*/ bool get_displayPersistentRuntimeUI();
            /*0x12c4a30*/ void set_displayPersistentRuntimeUI(bool value);
            /*0x12c3780*/ void ToggleEditorUI(bool open);

            enum UIMode
            {
                EditorMode = 0,
                RuntimeMode = 1,
            }

            class UIState
            {
                /*0x10*/ UnityEngine.Rendering.DebugManager.UIMode mode;
                /*0x14*/ bool m_Open;

                /*0x32f970*/ UIState();
                /*0x8b9820*/ bool get_open();
                /*0x12cfde0*/ void set_open(bool value);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.DebugManager.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__48_0;
                static /*0x10*/ System.Action <>9__48_1;
                static /*0x18*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, int> <>9__59_0;

                static /*0x12cfd70*/ <>c();
                /*0x32f970*/ <>c();
                /*0x32d010*/ void <.ctor>b__48_0(bool <p0>);
                /*0x32d010*/ void <.ctor>b__48_1();
                /*0x12cf140*/ int <TogglePersistent>b__59_0(UnityEngine.Rendering.DebugUI.Widget w);
                /*0x12cf210*/ UnityEngine.Rendering.DebugManager <.cctor>b__94_0();
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ string displayName;

                /*0x32f970*/ <>c__DisplayClass66_0();
                /*0x12cf7f0*/ bool <FindPanelIndex>b__0(UnityEngine.Rendering.DebugUI.Panel p);
            }
        }

        class DebugActionDesc
        {
            /*0x10*/ string axisTrigger;
            /*0x18*/ System.Collections.Generic.List<System.String[]> buttonTriggerList;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.KeyCode[]> keyTriggerList;
            /*0x28*/ UnityEngine.Rendering.DebugActionRepeatMode repeatMode;
            /*0x2c*/ float repeatDelay;

            /*0x12bd750*/ DebugActionDesc();
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

            /*0x12bdcb0*/ DebugActionState();
            /*0xc77220*/ bool get_runningAction();
            /*0xc77230*/ void set_runningAction(bool value);
            /*0xcf6cb0*/ float get_actionState();
            /*0xcf6d00*/ void set_actionState(float value);
            /*0x12bd9f0*/ void Trigger(int triggerCount, float state);
            /*0x12bd8b0*/ void TriggerWithButton(string[] buttons, float state);
            /*0x12bd860*/ void TriggerWithAxis(string axis, float state);
            /*0x12bd950*/ void TriggerWithKey(UnityEngine.KeyCode[] keys, float state);
            /*0x12bd840*/ void Reset();
            /*0x12bdab0*/ void Update(UnityEngine.Rendering.DebugActionDesc desc);

            enum DebugActionKeyType
            {
                Button = 0,
                Axis = 1,
                Key = 2,
            }
        }

        interface IDebugData
        {
            /*0x1803b0*/ System.Action GetReset();
        }

        class DebugShapes
        {
            static /*0x0*/ UnityEngine.Rendering.DebugShapes s_Instance;
            /*0x10*/ UnityEngine.Mesh m_sphereMesh;
            /*0x18*/ UnityEngine.Mesh m_boxMesh;
            /*0x20*/ UnityEngine.Mesh m_coneMesh;
            /*0x28*/ UnityEngine.Mesh m_pyramidMesh;

            static /*0x12c7700*/ UnityEngine.Rendering.DebugShapes get_instance();
            /*0x32f970*/ DebugShapes();
            /*0x12c6ac0*/ void BuildSphere(ref UnityEngine.Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv);
            /*0x12c4d70*/ void BuildBox(ref UnityEngine.Mesh outputMesh, float length, float width, float height);
            /*0x12c5a30*/ void BuildCone(ref UnityEngine.Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides);
            /*0x12c64c0*/ void BuildPyramid(ref UnityEngine.Mesh outputMesh, float width, float height, float depth);
            /*0x12c6940*/ void BuildShapes();
            /*0x12c7430*/ void RebuildResources();
            /*0x12c76e0*/ UnityEngine.Mesh RequestSphereMesh();
            /*0x12c7680*/ UnityEngine.Mesh RequestBoxMesh();
            /*0x12c76a0*/ UnityEngine.Mesh RequestConeMesh();
            /*0x12c76c0*/ UnityEngine.Mesh RequestPyramidMesh();
        }

        class DebugUI
        {
            /*0x32f970*/ DebugUI();

            class Container : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IContainer
            {
                static string k_IDToken = "#";
                /*0x48*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;

                /*0x12bc500*/ Container();
                /*0x12bc790*/ Container(string id);
                /*0x12bc5a0*/ Container(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children);
                /*0x12bc830*/ bool get_hideDisplayName();
                /*0x4e40d0*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x4e4360*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x73d3e0*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x12bc890*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x12bc180*/ void GenerateQueryPath();
                /*0x12bc400*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x12bc480*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x12bc2c0*/ int GetHashCode();
            }

            class Foldout : UnityEngine.Rendering.DebugUI.Container, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x50*/ bool opened;
                /*0x51*/ bool isHeader;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.Foldout.ContextMenuItem> contextMenuItems;
                /*0x60*/ string[] <columnLabels>k__BackingField;
                /*0x68*/ string[] <columnTooltips>k__BackingField;

                /*0x12cb0f0*/ Foldout();
                /*0x12cb100*/ Foldout(string displayName, UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips);
                /*0x348b00*/ bool get_isReadOnly();
                /*0xe643b0*/ string[] get_columnLabels();
                /*0xe643c0*/ void set_columnLabels(string[] value);
                /*0x8af030*/ string[] get_columnTooltips();
                /*0xe69480*/ void set_columnTooltips(string[] value);
                /*0x9ef740*/ bool GetValue();
                /*0x12cb0a0*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x12cb030*/ void SetValue(object value);
                /*0x718e40*/ object ValidateValue(object value);
                /*0x9ef990*/ void SetValue(bool value);

                struct ContextMenuItem
                {
                    /*0x10*/ string displayName;
                    /*0x18*/ System.Action action;
                }
            }

            class HBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x12cbc70*/ HBox();
            }

            class VBox : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x12cfec0*/ VBox();
            }

            class Table : UnityEngine.Rendering.DebugUI.Container
            {
                /*0x50*/ bool isReadOnly;
                /*0x58*/ bool[] m_Header;

                /*0x12cd6c0*/ Table();
                /*0x12cd670*/ void SetColumnVisibility(int index, bool visible);
                /*0x12cd500*/ bool GetColumnVisibility(int index);
                /*0x12cd710*/ bool[] get_VisibleColumns();
                /*0x12cd550*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x12cd5e0*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);

                class Row : UnityEngine.Rendering.DebugUI.Foldout
                {
                    /*0x12cc7e0*/ Row();
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

                /*0x32f970*/ Widget();
                /*0x73d3e0*/ UnityEngine.Rendering.DebugUI.Panel get_panel();
                /*0x9f12f0*/ void set_panel(UnityEngine.Rendering.DebugUI.Panel value);
                /*0x32f410*/ UnityEngine.Rendering.DebugUI.IContainer get_parent();
                /*0x7963c0*/ void set_parent(UnityEngine.Rendering.DebugUI.IContainer value);
                /*0x3e3af0*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0x11172b0*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x79a150*/ string get_displayName();
                /*0x98b030*/ void set_displayName(string value);
                /*0x997630*/ string get_tooltip();
                /*0x997640*/ void set_tooltip(string value);
                /*0x995140*/ string get_queryPath();
                /*0xe5a080*/ void set_queryPath(string value);
                /*0x12d2850*/ bool get_isEditorOnly();
                /*0x12d28e0*/ bool get_isRuntimeOnly();
                /*0x12d2880*/ bool get_isInactiveInEditor();
                /*0x12d2860*/ bool get_isHidden();
                /*0x12d2700*/ void GenerateQueryPath();
                /*0x12d27b0*/ int GetHashCode();
                /*0x12d28f0*/ void set_nameAndTooltip(UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip value);

                struct NameAndTooltip
                {
                    /*0x10*/ string name;
                    /*0x18*/ string tooltip;
                }
            }

            interface IContainer
            {
                /*0x1803b0*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x1803b0*/ string get_displayName();
                /*0x17aec0*/ void set_displayName(string value);
                /*0x1803b0*/ string get_queryPath();
            }

            interface IValueField
            {
                /*0x1803b0*/ object GetValue();
                /*0x17aec0*/ void SetValue(object value);
                /*0x1858d0*/ object ValidateValue(object value);
            }

            class Button : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Action <action>k__BackingField;

                /*0x32f970*/ Button();
                /*0x4e40d0*/ System.Action get_action();
                /*0x4e4360*/ void set_action(System.Action value);
            }

            class Value : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ System.Func<object> <getter>k__BackingField;
                /*0x50*/ float refreshRate;
                /*0x58*/ string formatString;

                /*0x12d0000*/ Value();
                /*0x4e40d0*/ System.Func<object> get_getter();
                /*0x4e4360*/ void set_getter(System.Func<object> value);
                /*0x995340*/ object GetValue();
                /*0x12cffa0*/ string FormatString(object value);
            }

            class ProgressBarValue : UnityEngine.Rendering.DebugUI.Value
            {
                /*0x60*/ float min;
                /*0x64*/ float max;

                static /*0x12cc770*/ float <FormatString>g__Remap01|2_0(float v, float x0, float y0);
                /*0x12cc780*/ ProgressBarValue();
                /*0x12cc690*/ string FormatString(object value);
            }

            class ValueTuple : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.Value[] values;
                /*0x50*/ int pinnedElementIndex;

                /*0x12cff10*/ ValueTuple();
                /*0x12cff20*/ int get_numElements();
                /*0x12cff40*/ float get_refreshRate();
            }

            class Field<T> : UnityEngine.Rendering.DebugUI.Widget, UnityEngine.Rendering.DebugUI.IValueField
            {
                /*0x0*/ System.Func<T> <getter>k__BackingField;
                /*0x0*/ System.Action<T> <setter>k__BackingField;
                /*0x0*/ System.Action<UnityEngine.Rendering.DebugUI.Field<T>, T> onValueChanged;

                /*0x180fc0*/ Field();
                /*0x1803b0*/ System.Func<T> get_getter();
                /*0x17aec0*/ void set_getter(System.Func<T> value);
                /*0x1803b0*/ System.Action<T> get_setter();
                /*0x17aec0*/ void set_setter(System.Action<T> value);
                /*0x1858d0*/ object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
                /*0x2a5510*/ T ValidateValue(T value);
                /*0x1803b0*/ object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
                /*0x2a5510*/ T GetValue();
                /*0x17aec0*/ void SetValue(object value);
                /*0x2a5510*/ void SetValue(T value);
            }

            class BoolField : UnityEngine.Rendering.DebugUI.Field<bool>
            {
                /*0x12baf10*/ BoolField();
            }

            class HistoryBoolField : UnityEngine.Rendering.DebugUI.BoolField
            {
                /*0x60*/ System.Func<bool> <historyGetter>k__BackingField;

                /*0x12baf10*/ HistoryBoolField();
                /*0xe643b0*/ System.Func<bool> get_historyGetter();
                /*0xe643c0*/ void set_historyGetter(System.Func<bool> value);
                /*0x12cbd00*/ int get_historyDepth();
                /*0x12cbcc0*/ bool GetHistoryValue(int historyIndex);
            }

            class IntField : UnityEngine.Rendering.DebugUI.Field<int>
            {
                /*0x60*/ System.Func<int> min;
                /*0x68*/ System.Func<int> max;
                /*0x70*/ int incStep;
                /*0x74*/ int intStepMult;

                /*0x12cbdf0*/ IntField();
                /*0x12cbd80*/ int ValidateValue(int value);
            }

            class UIntField : UnityEngine.Rendering.DebugUI.Field<uint>
            {
                /*0x60*/ System.Func<uint> min;
                /*0x68*/ System.Func<uint> max;
                /*0x70*/ uint incStep;
                /*0x74*/ uint intStepMult;

                /*0x12cfe70*/ UIntField();
                /*0x12cbd80*/ uint ValidateValue(uint value);
            }

            class FloatField : UnityEngine.Rendering.DebugUI.Field<float>
            {
                /*0x60*/ System.Func<float> min;
                /*0x68*/ System.Func<float> max;
                /*0x70*/ float incStep;
                /*0x74*/ float incStepMult;
                /*0x78*/ int decimals;

                /*0x12cafe0*/ FloatField();
                /*0x12caf80*/ float ValidateValue(float value);
            }

            class EnumField<T> : UnityEngine.Rendering.DebugUI.Field<T>
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex s_NicifyRegEx;
                /*0x0*/ UnityEngine.GUIContent[] enumNames;
                /*0x0*/ int[] m_EnumValues;

                static /*0x180ff0*/ EnumField();
                /*0x180fc0*/ EnumField();
                /*0x1803b0*/ int[] get_enumValues();
                /*0x17aec0*/ void set_enumValues(int[] value);
                /*0x17aec0*/ void AutoFillFromType(System.Type enumType);

                class <>c<T>
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__6_0;

                    static /*0x180ff0*/ <>c();
                    /*0x180fc0*/ <>c();
                    /*0x17e620*/ bool <AutoFillFromType>b__6_0(System.Reflection.FieldInfo fieldInfo);
                }
            }

            class EnumField : UnityEngine.Rendering.DebugUI.EnumField<int>
            {
                /*0x70*/ int[] quickSeparators;
                /*0x78*/ int[] m_Indexes;
                /*0x80*/ System.Func<int> <getIndex>k__BackingField;
                /*0x88*/ System.Action<int> <setIndex>k__BackingField;

                /*0x12cac20*/ EnumField();
                /*0x12cacb0*/ int[] get_indexes();
                /*0xeeac90*/ System.Func<int> get_getIndex();
                /*0x12cadc0*/ void set_getIndex(System.Func<int> value);
                /*0x7379f0*/ System.Action<int> get_setIndex();
                /*0x737e30*/ void set_setIndex(System.Action<int> value);
                /*0x12cac80*/ int get_currentIndex();
                /*0x12cad90*/ void set_currentIndex(int value);
                /*0x12cad30*/ void set_autoEnum(System.Type value);
                /*0x12ca880*/ void InitQuickSeparators();
                /*0x12caae0*/ void SetValue(int value);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.EnumField.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.GUIContent, string> <>9__17_0;

                    static /*0x12cfc20*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x12cf0c0*/ string <InitQuickSeparators>b__17_0(UnityEngine.GUIContent x);
                }
            }

            class ObjectPopupField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> <getObjects>k__BackingField;

                /*0x12cbf60*/ ObjectPopupField();
                /*0xe643b0*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> get_getObjects();
                /*0xe643c0*/ void set_getObjects(System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Object>> value);
            }

            class HistoryEnumField : UnityEngine.Rendering.DebugUI.EnumField
            {
                /*0x90*/ System.Func<int> <historyIndexGetter>k__BackingField;

                /*0x12cac20*/ HistoryEnumField();
                /*0x7378b0*/ System.Func<int> get_historyIndexGetter();
                /*0x737b80*/ void set_historyIndexGetter(System.Func<int> value);
                /*0x12cbd60*/ int get_historyDepth();
                /*0x12cbd10*/ int GetHistoryValue(int historyIndex);
            }

            class BitField : UnityEngine.Rendering.DebugUI.EnumField<System.Enum>
            {
                /*0x70*/ System.Type m_EnumType;

                /*0x12bae50*/ BitField();
                /*0xd184b0*/ System.Type get_enumType();
                /*0x12baeb0*/ void set_enumType(System.Type value);
            }

            class ColorField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Color>
            {
                /*0x60*/ bool hdr;
                /*0x61*/ bool showAlpha;
                /*0x62*/ bool showPicker;
                /*0x64*/ float incStep;
                /*0x68*/ float incStepMult;
                /*0x6c*/ int decimals;

                /*0x12bbb40*/ ColorField();
                /*0x12bba90*/ UnityEngine.Color ValidateValue(UnityEngine.Color value);
            }

            class Vector2Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector2>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x12d0050*/ Vector2Field();
            }

            class Vector3Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector3>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x12d00a0*/ Vector3Field();
            }

            class Vector4Field : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Vector4>
            {
                /*0x60*/ float incStep;
                /*0x64*/ float incStepMult;
                /*0x68*/ int decimals;

                /*0x12d00f0*/ Vector4Field();
            }

            class ObjectField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object>
            {
                /*0x60*/ System.Type type;

                /*0x12cbe40*/ ObjectField();
            }

            class ObjectListField : UnityEngine.Rendering.DebugUI.Field<UnityEngine.Object[]>
            {
                /*0x60*/ System.Type type;

                /*0x12cbed0*/ ObjectListField();
            }

            class MessageBox : UnityEngine.Rendering.DebugUI.Widget
            {
                /*0x48*/ UnityEngine.Rendering.DebugUI.MessageBox.Style style;

                /*0x32f970*/ MessageBox();

                enum Style
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }

            class Panel : UnityEngine.Rendering.DebugUI.IContainer, System.IComparable<UnityEngine.Rendering.DebugUI.Panel>
            {
                /*0x10*/ UnityEngine.Rendering.DebugUI.Flags <flags>k__BackingField;
                /*0x18*/ string <displayName>k__BackingField;
                /*0x20*/ int <groupIndex>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> <children>k__BackingField;
                /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> onSetDirty;

                /*0x12cc260*/ Panel();
                /*0x417e30*/ UnityEngine.Rendering.DebugUI.Flags get_flags();
                /*0xdcd9c0*/ void set_flags(UnityEngine.Rendering.DebugUI.Flags value);
                /*0x32f410*/ string get_displayName();
                /*0x7963c0*/ void set_displayName(string value);
                /*0x3e3af0*/ int get_groupIndex();
                /*0x11172b0*/ void set_groupIndex(int value);
                /*0x32f410*/ string get_queryPath();
                /*0x12cc530*/ bool get_isEditorOnly();
                /*0x12cc5a0*/ bool get_isRuntimeOnly();
                /*0x12cc540*/ bool get_isInactiveInEditor();
                /*0x12cc520*/ bool get_editorForceUpdate();
                /*0x79a150*/ UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> get_children();
                /*0x98b030*/ void set_children(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> value);
                /*0x12cc470*/ void add_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x12cc5b0*/ void remove_onSetDirty(System.Action<UnityEngine.Rendering.DebugUI.Panel> value);
                /*0x12cc080*/ void OnItemAdded(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x12cc0f0*/ void OnItemRemoved(UnityEngine.Rendering.ObservableList<UnityEngine.Rendering.DebugUI.Widget> sender, UnityEngine.Rendering.ListChangedEventArgs<UnityEngine.Rendering.DebugUI.Widget> e);
                /*0x12cc160*/ void SetDirty();
                /*0x12cbfa0*/ int GetHashCode();
                /*0x12cc230*/ int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(UnityEngine.Rendering.DebugUI.Panel other);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Panel.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Panel> <>9__29_0;

                    static /*0x12cfd00*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x32d010*/ void <.ctor>b__29_0(UnityEngine.Rendering.DebugUI.Panel <p0>);
                }
            }
        }

        class DebugUpdater : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ UnityEngine.Rendering.DebugUpdater s_Instance;
            /*0x20*/ UnityEngine.ScreenOrientation m_Orientation;
            /*0x24*/ bool m_RuntimeUiWasVisibleLastFrame;

            static /*0x32d010*/ void RuntimeInit();
            static /*0x12c80e0*/ void SetEnabled(bool enabled);
            static /*0x12c7bf0*/ void EnableRuntime();
            static /*0x12c79f0*/ void DisableRuntime();
            static /*0x12c7fd0*/ void HandleInternalEventSystemComponents(bool uiEnabled);
            static /*0x12c8090*/ System.Collections.IEnumerator RefreshRuntimeUINextFrame();
            /*0x31c640*/ DebugUpdater();
            /*0x12c7d70*/ void EnsureExactlyOneEventSystem();
            /*0x12c7b80*/ System.Collections.IEnumerator DoAfterInputModuleUpdated(System.Action action);
            /*0x12c7790*/ void CheckInputModuleExists();
            /*0x12c78a0*/ void CreateDebugEventSystem();
            /*0x12c7920*/ void DestroyDebugEventSystem();
            /*0x12c83e0*/ void Update();

            class <DoAfterInputModuleUpdated>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Action action;

                /*0x32f460*/ <DoAfterInputModuleUpdated>d__9(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x12cee40*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x12cef40*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
            }

            class <RefreshRuntimeUINextFrame>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x32f460*/ <RefreshRuntimeUINextFrame>d__14(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x12cef80*/ bool MoveNext();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x12cf040*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
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

            static /*0x12d2ee0*/ UnityEngine.Rendering.PerformanceBottleneck DetermineBottleneck(UnityEngine.Rendering.FrameTimeSample s);
            /*0x12d3050*/ BottleneckHistory(int initialCapacity);
            /*0x12d2fb0*/ void DiscardOldSamples(int historySize);
            /*0x12d2bd0*/ void AddBottleneckFromAveragedSample(UnityEngine.Rendering.FrameTimeSample frameHistorySampleAverage);
            /*0x12d2d60*/ void ComputeHistogram();
            /*0x12d2d10*/ void Clear();
        }

        struct FrameTimeSample
        {
            /*0x10*/ float FramesPerSecond;
            /*0x14*/ float FullFrameTime;
            /*0x18*/ float MainThreadCPUFrameTime;
            /*0x1c*/ float MainThreadCPUPresentWaitTime;
            /*0x20*/ float RenderThreadCPUFrameTime;
            /*0x24*/ float GPUFrameTime;

            /*0x1232fe0*/ FrameTimeSample(float initValue);
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

            static /*0x12d4470*/ FrameTimeSampleHistory();
            static /*0x12d4380*/ void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref UnityEngine.Rendering.FrameTimeSample aggregate, UnityEngine.Rendering.FrameTimeSample sample, System.Func<float, float, float> func);
            /*0x12d4760*/ FrameTimeSampleHistory(int initialCapacity);
            /*0x12d38c0*/ void Add(UnityEngine.Rendering.FrameTimeSample sample);
            /*0x12d39e0*/ void ComputeAggregateValues();
            /*0x12d42e0*/ void DiscardOldSamples(int sampleHistorySize);
            /*0x12d3990*/ void Clear();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.FrameTimeSampleHistory.<> <>9;

                static /*0x12ea780*/ <>c();
                /*0x32f970*/ <>c();
                /*0x12ea570*/ float <.cctor>b__15_0(float value, float other);
                /*0x12ea580*/ float <.cctor>b__15_1(float value, float other);
                /*0x12ea590*/ float <.cctor>b__15_2(float value, float other);
                /*0x12ea5a0*/ float <.cctor>b__15_3(float value, float other);
                /*0x12ea5c0*/ float <.cctor>b__15_4(float value, float other);
                /*0x12ea5d0*/ float <.cctor>b__15_5(float value, float other);
            }
        }

        interface IDebugDisplaySettings : UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x180fc0*/ void Reset();
            /*0x17aec0*/ void ForEach(System.Action<UnityEngine.Rendering.IDebugDisplaySettingsData> onExecute);
        }

        interface IDebugDisplaySettingsData : UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            /*0x1803b0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();
        }

        interface IDebugDisplaySettingsPanel
        {
            /*0x1803b0*/ string get_PanelName();
            /*0x1803b0*/ UnityEngine.Rendering.DebugUI.Widget[] get_Widgets();
            /*0x180980*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
        }

        interface IDebugDisplaySettingsPanelDisposable : UnityEngine.Rendering.IDebugDisplaySettingsPanel, System.IDisposable
        {
        }

        interface IDebugDisplaySettingsQuery
        {
            /*0x17cb40*/ bool get_AreAnySettingsActive();
            /*0x17cb40*/ bool get_IsPostProcessingAllowed();
            /*0x17cb40*/ bool get_IsLightingActive();
            /*0x17e620*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
        }

        interface IVolumeDebugSettings
        {
            /*0x180980*/ int get_selectedComponent();
            /*0x17aa40*/ void set_selectedComponent(int value);
            /*0x1803b0*/ UnityEngine.Camera get_selectedCamera();
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x180980*/ int get_selectedCameraIndex();
            /*0x17aa40*/ void set_selectedCameraIndex(int value);
            /*0x1803b0*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x180e40*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x1803b0*/ System.Type get_selectedComponentType();
            /*0x17aec0*/ void set_selectedComponentType(System.Type value);
            /*0x1803b0*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x17e620*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);
            /*0x17e620*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
        }

        interface IVolumeDebugSettings2 : UnityEngine.Rendering.IVolumeDebugSettings
        {
            /*0x1803b0*/ System.Type get_targetRenderPipeline();
            /*0x1803b0*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
        }

        class MousePositionDebug
        {
            static /*0x0*/ UnityEngine.Rendering.MousePositionDebug s_Instance;

            static /*0x12d4a50*/ UnityEngine.Rendering.MousePositionDebug get_instance();
            /*0x32f970*/ MousePositionDebug();
            /*0x32d010*/ void Build();
            /*0x32d010*/ void Cleanup();
            /*0x12d4a20*/ UnityEngine.Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
            /*0x12d4a20*/ UnityEngine.Vector2 GetInputMousePosition();
            /*0x347e50*/ UnityEngine.Vector2 GetMouseClickPosition(float ScreenHeight);
        }

        class TProfilingSampler<TEnum> : UnityEngine.Rendering.ProfilingSampler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<TEnum, UnityEngine.Rendering.TProfilingSampler<TEnum>> samples;

            static /*0x180ff0*/ TProfilingSampler();
            /*0x17aec0*/ TProfilingSampler(string name);
        }

        class ProfilingSampler
        {
            /*0x10*/ UnityEngine.Profiling.CustomSampler <sampler>k__BackingField;
            /*0x18*/ UnityEngine.Profiling.CustomSampler <inlineSampler>k__BackingField;
            /*0x20*/ string <name>k__BackingField;
            /*0x28*/ UnityEngine.Profiling.Recorder m_Recorder;
            /*0x30*/ UnityEngine.Profiling.Recorder m_InlineRecorder;

            static /*0x2a5510*/ UnityEngine.Rendering.ProfilingSampler Get<TEnum>(TEnum marker);
            /*0x12e8560*/ ProfilingSampler(string name);
            /*0x32f970*/ ProfilingSampler();
            /*0x12e8480*/ void Begin(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x12e84e0*/ void End(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x12e8540*/ bool IsValid();
            /*0x73d3e0*/ UnityEngine.Profiling.CustomSampler get_sampler();
            /*0x9f12f0*/ void set_sampler(UnityEngine.Profiling.CustomSampler value);
            /*0x32f410*/ UnityEngine.Profiling.CustomSampler get_inlineSampler();
            /*0x7963c0*/ void set_inlineSampler(UnityEngine.Profiling.CustomSampler value);
            /*0x61a260*/ string get_name();
            /*0x7965a0*/ void set_name(string value);
            /*0x12e8870*/ void set_enableRecording(bool value);
            /*0x12e8730*/ float get_gpuElapsedTime();
            /*0x12e8790*/ int get_gpuSampleCount();
            /*0x12e8690*/ float get_cpuElapsedTime();
            /*0x12e86f0*/ int get_cpuSampleCount();
            /*0x12e87d0*/ float get_inlineCpuElapsedTime();
            /*0x12e8830*/ int get_inlineCpuSampleCount();
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x32d010*/ ProfilingScope(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProfilingSampler sampler);
            /*0x32d010*/ void Dispose();
        }

        struct ProfilingSample : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer m_Cmd;
            /*0x18*/ string m_Name;
            /*0x20*/ bool m_Disposed;
            /*0x28*/ UnityEngine.Profiling.CustomSampler m_Sampler;

            /*0x12e8250*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string name, UnityEngine.Profiling.CustomSampler sampler);
            /*0x12e8300*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object arg);
            /*0x12e83c0*/ ProfilingSample(UnityEngine.Rendering.CommandBuffer cmd, string format, object[] args);
            /*0x12e81e0*/ void Dispose();
            /*0x12e8160*/ void Dispose(bool disposing);
        }

        class ShaderDebugPrintManager
        {
            static int k_DebugUAVSlot = 7;
            static int k_FramesInFlight = 4;
            static int k_MaxBufferElements = 16384;
            static uint k_TypeHasTag = 128;
            static /*0x0*/ UnityEngine.Rendering.ShaderDebugPrintManager s_Instance;
            static /*0x8*/ int m_ShaderPropertyIDInputMouse;
            static /*0xc*/ int m_ShaderPropertyIDInputFrame;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.GraphicsBuffer> m_OutputBuffers;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.AsyncGPUReadbackRequest> m_ReadbackRequests;
            /*0x20*/ System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> m_BufferReadCompleteAction;
            /*0x28*/ int m_FrameCounter;
            /*0x2c*/ bool m_FrameCleared;
            /*0x30*/ string m_OutputLine;
            /*0x38*/ System.Action<string> m_OutputAction;

            static /*0x12ea0c0*/ ShaderDebugPrintManager();
            static /*0x12ea480*/ UnityEngine.Rendering.ShaderDebugPrintManager get_instance();
            /*0x12ea180*/ ShaderDebugPrintManager();
            /*0x12e9c50*/ int DebugValueTypeToElemSize(UnityEngine.Rendering.ShaderDebugPrintManager.DebugValueType type);
            /*0x12e9fc0*/ void SetShaderDebugPrintInputConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ShaderDebugPrintInput input);
            /*0x12e9dd0*/ void SetShaderDebugPrintBindings(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x12e9b50*/ void ClearShaderDebugPrintBuffer();
            /*0x12e8d80*/ void BufferReadComplete(UnityEngine.Rendering.AsyncGPUReadbackRequest request);
            /*0x12e9d10*/ void EndFrame();
            /*0x997630*/ string get_outputLine();
            /*0xe5a080*/ void set_outputAction(System.Action<string> value);
            /*0x12e9cc0*/ void DefaultOutput(string line);

            class Profiling
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler BufferReadComplete;

                static /*0x12e88c0*/ Profiling();
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

            /*0x1230500*/ UnityEngine.Vector2 get_pos();
            /*0x9e29e0*/ void set_pos(UnityEngine.Vector2 value);
            /*0xa5a920*/ bool get_leftDown();
            /*0x12e8d50*/ void set_leftDown(bool value);
            /*0xe48180*/ bool get_rightDown();
            /*0x12e8d70*/ void set_rightDown(bool value);
            /*0xe48170*/ bool get_middleDown();
            /*0x12e8d60*/ void set_middleDown(bool value);
            /*0x12e8ad0*/ string String();
        }

        class ShaderDebugPrintInputProducer
        {
            static /*0x12e8a60*/ UnityEngine.Rendering.ShaderDebugPrintInput Get();
        }

        class VolumeDebugSettings<T> : UnityEngine.Rendering.IVolumeDebugSettings2, UnityEngine.Rendering.IVolumeDebugSettings
        {
            static /*0x0*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> s_ComponentPathAndType;
            static /*0x0*/ System.Collections.Generic.List<System.Type> s_ComponentTypes;
            static /*0x0*/ System.Collections.Generic.List<T> <additionalCameraDatas>k__BackingField;
            /*0x0*/ int <selectedComponent>k__BackingField;
            /*0x0*/ UnityEngine.Camera m_SelectedCamera;
            /*0x0*/ int m_SelectedCameraIndex;
            /*0x0*/ UnityEngine.Camera[] m_CamerasArray;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;
            /*0x0*/ float[] weights;
            /*0x0*/ UnityEngine.Rendering.Volume[] volumes;
            /*0x0*/ UnityEngine.Rendering.VolumeParameter[,] savedStates;

            static /*0x180ff0*/ VolumeDebugSettings();
            static /*0x180cf0*/ System.Collections.Generic.List<System.Type> get_componentTypes();
            static /*0x17e030*/ string ComponentDisplayName(System.Type component);
            static /*0x180cf0*/ System.Collections.Generic.List<T> get_additionalCameraDatas();
            static /*0x177be0*/ void set_additionalCameraDatas(System.Collections.Generic.List<T> value);
            static /*0x2a5510*/ void RegisterCamera(T additionalCamera);
            static /*0x2a5510*/ void UnRegisterCamera(T additionalCamera);
            /*0x180fc0*/ VolumeDebugSettings();
            /*0x180980*/ int get_selectedComponent();
            /*0x17aa40*/ void set_selectedComponent(int value);
            /*0x1803b0*/ UnityEngine.Camera get_selectedCamera();
            /*0x180980*/ int get_selectedCameraIndex();
            /*0x17aa40*/ void set_selectedCameraIndex(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<UnityEngine.Camera> get_cameras();
            /*0x1803b0*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
            UnityEngine.LayerMask get_selectedCameraLayerMask();
            /*0x180e40*/ UnityEngine.Vector3 get_selectedCameraPosition();
            /*0x1803b0*/ System.Type get_selectedComponentType();
            /*0x17aec0*/ void set_selectedComponentType(System.Type value);
            /*0x1803b0*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> get_volumeComponentsPathAndType();
            /*0x1803b0*/ System.Type get_targetRenderPipeline();
            /*0x177730*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.VolumeComponent component, System.Reflection.FieldInfo field);
            /*0x1858d0*/ UnityEngine.Rendering.VolumeParameter GetParameter(System.Reflection.FieldInfo field);
            /*0x177730*/ UnityEngine.Rendering.VolumeParameter GetParameter(UnityEngine.Rendering.Volume volume, System.Reflection.FieldInfo field);
            /*0x180070*/ float ComputeWeight(UnityEngine.Rendering.Volume volume, UnityEngine.Vector3 triggerPos);
            /*0x1803b0*/ UnityEngine.Rendering.Volume[] GetVolumes();
            /*0x1803b0*/ UnityEngine.Rendering.VolumeParameter[,] GetStates();
            /*0x17e620*/ bool ChangedStates(UnityEngine.Rendering.VolumeParameter[,] newStates);
            /*0x17e620*/ bool RefreshVolumes(UnityEngine.Rendering.Volume[] newVolumes);
            float GetVolumeWeight(UnityEngine.Rendering.Volume volume);
            /*0x17e620*/ bool VolumeHasInfluence(UnityEngine.Rendering.Volume volume);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeDebugSettings.<>c<T> <>9;
                static /*0x0*/ System.Func<UnityEngine.Rendering.Volume, bool> <>9__35_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__37_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__44_0;
                static /*0x0*/ System.Func<System.Type, bool> <>9__44_1;
                static /*0x0*/ System.Func<System.Type, string> <>9__44_2;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x17e620*/ bool <GetVolumes>b__35_0(UnityEngine.Rendering.Volume v);
                /*0x17e620*/ bool <GetStates>b__37_0(System.Reflection.FieldInfo t);
                /*0x17e620*/ bool <get_componentTypes>b__44_0(System.Type t);
                /*0x17e620*/ bool <get_componentTypes>b__44_1(System.Type t);
                /*0x1858d0*/ string <get_componentTypes>b__44_2(System.Type t);
            }

            class <>c__DisplayClass23_0<T>
            {
                /*0x0*/ System.Type value;

                /*0x180fc0*/ <>c__DisplayClass23_0();
                bool <set_selectedComponentType>b__0(System.ValueTuple<string, System.Type> t);
            }
        }

        class CoreRPHelpURLAttribute : UnityEngine.HelpURLAttribute
        {
            /*0x12d32e0*/ CoreRPHelpURLAttribute(string pageName, string packageName);
            /*0x12d32b0*/ CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName);
        }

        class DocumentationInfo
        {
            static string fallbackVersion = "13.1";
            static string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}";

            static /*0x12d3820*/ string get_version();
            static /*0x12d3640*/ string GetPageLink(string packageName, string pageName);
            static /*0x12d3470*/ string GetPageLink(string packageName, string pageName, string pageHash);
            /*0x32f970*/ DocumentationInfo();
        }

        class DocumentationUtils
        {
            static /*0x2a5510*/ string GetHelpURL<TEnum>(TEnum mask);
            static /*0x12d3850*/ bool TryGetHelpURL(System.Type type, ref string url);
        }

        class ProbeBrickIndex
        {
            static int kMaxSubdivisionLevels = 7;
            static int kIndexChunkSize = 243;
            static /*0x0*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell g_Cell;
            /*0x10*/ System.Collections.BitArray m_IndexChunks;
            /*0x18*/ int m_IndexInChunks;
            /*0x1c*/ int m_NextFreeChunk;
            /*0x20*/ int m_AvailableChunkCount;
            /*0x28*/ UnityEngine.ComputeBuffer m_PhysicalIndexBuffer;
            /*0x30*/ int[] m_PhysicalIndexBufferData;
            /*0x38*/ int <estimatedVMemCost>k__BackingField;
            /*0x3c*/ UnityEngine.Vector3Int m_CenterRS;
            /*0x48*/ System.Collections.Generic.Dictionary<UnityEngine.Vector3Int, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks;
            /*0x50*/ System.Collections.Generic.Dictionary<UnityEngine.Rendering.ProbeReferenceVolume.Cell, UnityEngine.Rendering.ProbeBrickIndex.BrickMeta> m_BricksToVoxels;
            /*0x58*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeBrickIndex.BrickMeta> m_BrickMetaPool;
            /*0x60*/ UnityEngine.Rendering.ObjectPool<System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta>> m_VoxelMetaListPool;
            /*0x68*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta> m_VoxelMetaPool;
            /*0x70*/ bool m_NeedUpdateIndexComputeBuffer;
            /*0x74*/ int m_UpdateMinIndex;
            /*0x78*/ int m_UpdateMaxIndex;

            /*0x12d89e0*/ ProbeBrickIndex(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0xeab1d0*/ int get_estimatedVMemCost();
            /*0x12d8f70*/ void set_estimatedVMemCost(int value);
            /*0x12d7530*/ int GetVoxelSubdivLevel();
            /*0x12d7e60*/ int SizeOfPhysicalIndexFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget);
            /*0x3e3af0*/ int GetRemainingChunkCount();
            /*0x12d8980*/ void UploadIndexData();
            /*0x12d6de0*/ void Clear();
            /*0x12d75d0*/ void MapBrickToVoxels(UnityEngine.Rendering.ProbeBrickIndex.Brick brick, System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels);
            /*0x12d6cd0*/ void ClearVoxel(UnityEngine.Vector3Int pos, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
            /*0x12d74b0*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x12d6c60*/ void Cleanup();
            /*0x12d78d0*/ int MergeIndex(int index, int size);
            /*0x12d6aa0*/ bool AssignIndexChunksToCell(int bricksCount, ref UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog);
            /*0x12d62c0*/ void AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> bricks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
            /*0x12d78f0*/ void RemoveBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo);
            /*0x12d7e90*/ void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
            /*0x12d84f0*/ void UpdatePhysicalIndex(UnityEngine.Vector3Int brickMin, UnityEngine.Vector3Int brickMax, int value, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
            /*0x12d72a0*/ void ClipToIndexSpace(UnityEngine.Vector3Int pos, int subdiv, ref UnityEngine.Vector3Int outMinpos, ref UnityEngine.Vector3Int outMaxpos, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);
            /*0x12d80f0*/ void UpdateIndexForVoxel(UnityEngine.Vector3Int voxel, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.ReservedBrick> bricks, System.Collections.Generic.List<ushort> indices, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellInfo);

            struct Brick : System.IEquatable<UnityEngine.Rendering.ProbeBrickIndex.Brick>
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int subdivisionLevel;

                /*0xa5a270*/ Brick(UnityEngine.Vector3Int position, int subdivisionLevel);
                /*0x12d3250*/ bool Equals(UnityEngine.Rendering.ProbeBrickIndex.Brick other);
            }

            struct ReservedBrick
            {
                /*0x10*/ UnityEngine.Rendering.ProbeBrickIndex.Brick brick;
                /*0x20*/ int flattenedIdx;
            }

            class VoxelMeta
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell cell;
                /*0x18*/ System.Collections.Generic.List<ushort> brickIndices;

                /*0x12ea850*/ VoxelMeta();
                /*0x12ea7f0*/ void Clear();
            }

            class BrickMeta
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.ReservedBrick> bricks;

                /*0x12d3190*/ BrickMeta();
                /*0x12d3120*/ void Clear();
            }

            struct CellIndexUpdateInfo
            {
                /*0x10*/ int firstChunkIndex;
                /*0x14*/ int numberOfChunks;
                /*0x18*/ int minSubdivInCell;
                /*0x1c*/ UnityEngine.Vector3Int minValidBrickIndexForCellAtMaxRes;
                /*0x28*/ UnityEngine.Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;
                /*0x34*/ UnityEngine.Vector3Int cellPositionInBricksAtMaxRes;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeBrickIndex.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeBrickIndex.BrickMeta> <>9__28_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta>> <>9__28_1;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta> <>9__28_2;
                static /*0x20*/ System.Predicate<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta> <>9__39_0;
                static /*0x28*/ System.Predicate<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta> <>9__40_0;

                static /*0x12ea710*/ <>c();
                /*0x32f970*/ <>c();
                /*0x12ea5e0*/ void <.ctor>b__28_0(UnityEngine.Rendering.ProbeBrickIndex.BrickMeta x);
                /*0x12ea650*/ void <.ctor>b__28_1(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta> x);
                /*0x12ea6b0*/ void <.ctor>b__28_2(UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta x);
                /*0x12ea4d0*/ bool <AddBricks>b__39_0(UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta lhs);
                /*0x12ea520*/ bool <RemoveBricks>b__40_0(UnityEngine.Rendering.ProbeBrickIndex.VoxelMeta lhs);
            }
        }

        class ProbeBrickPool
        {
            static int kProbePoolChunkSizeInBricks = 128;
            static int kBrickCellCount = 3;
            static int kBrickProbeCountPerDim = 4;
            static int kBrickProbeCountTotal = 64;
            static int kChunkProbeCountPerDim = 512;
            static int kMaxPoolWidth = 2048;
            /*0x10*/ int <estimatedVMemCost>k__BackingField;
            /*0x18*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation m_Pool;
            /*0x68*/ UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk;
            /*0x78*/ System.Collections.Generic.Stack<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> m_FreeList;
            /*0x80*/ int m_AvailableChunkCount;
            /*0x84*/ UnityEngine.Rendering.ProbeVolumeSHBands m_SHBands;
            /*0x88*/ bool m_ContainsValidity;

            static /*0x6d5e20*/ int GetChunkSizeInBrickCount();
            static /*0x6d5f40*/ int GetChunkSizeInProbeCount();
            static /*0x12d5050*/ int GetChunkCount(int brickCount, int chunkSizeInBricks);
            static /*0x12da0b0*/ UnityEngine.Vector3Int ProbeCountToDataLocSize(int numProbes);
            static /*0x12d9730*/ UnityEngine.Texture CreateDataTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes);
            static /*0x12d9210*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, UnityEngine.Rendering.ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, ref int allocatedBytes);
            /*0x12da780*/ ProbeBrickPool(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands, bool allocateValidityData);
            /*0x417e30*/ int get_estimatedVMemCost();
            /*0xdcd9c0*/ void set_estimatedVMemCost(int value);
            /*0x12d9c50*/ int GetRemainingChunkCount();
            /*0x12d9b00*/ void EnsureTextureValidity();
            /*0x104a520*/ int GetPoolWidth();
            /*0x12d9c40*/ int GetPoolHeight();
            /*0x12d9c20*/ UnityEngine.Vector3Int GetPoolDimensions();
            /*0x12d9c60*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x12d91c0*/ void Clear();
            /*0x12d8f80*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog);
            /*0x12d9980*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x12da330*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands);
            /*0x12da130*/ void UpdateValidity(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex);
            /*0x12d9ae0*/ void DerivePoolSizeFromBudget(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, ref int width, ref int height, ref int depth);
            /*0x12d91b0*/ void Cleanup();

            struct BrickChunkAlloc
            {
                /*0x10*/ int x;
                /*0x14*/ int y;
                /*0x18*/ int z;

                /*0x12d3100*/ int flattenIndex(int sx, int sy);
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
                /*0x48*/ UnityEngine.Texture3D TexValidity;
                /*0x50*/ int width;
                /*0x54*/ int height;
                /*0x58*/ int depth;

                /*0x12d3350*/ void Cleanup();
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
            static /*0x30*/ int _State1_L0_L1Rx;
            static /*0x34*/ int _State1_L1G_L1Ry;
            static /*0x38*/ int _State1_L1B_L1Rz;
            static /*0x3c*/ int _State1_L2_0;
            static /*0x40*/ int _State1_L2_1;
            static /*0x44*/ int _State1_L2_2;
            static /*0x48*/ int _State1_L2_3;
            static /*0x4c*/ int _Out_L0_L1Rx;
            static /*0x50*/ int _Out_L1G_L1Ry;
            static /*0x54*/ int _Out_L1B_L1Rz;
            static /*0x58*/ int _Out_L2_0;
            static /*0x5c*/ int _Out_L2_1;
            static /*0x60*/ int _Out_L2_2;
            static /*0x64*/ int _Out_L2_3;
            /*0x10*/ UnityEngine.Vector4[] m_ChunkList;
            /*0x18*/ int m_MappedChunks;
            /*0x20*/ UnityEngine.Rendering.ProbeBrickPool m_State0;
            /*0x28*/ UnityEngine.Rendering.ProbeBrickPool m_State1;
            /*0x30*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
            /*0x34*/ UnityEngine.Rendering.ProbeVolumeSHBands m_ShBands;

            static /*0x12d5db0*/ ProbeBrickBlendingPool();
            static /*0x12d6240*/ bool get_isSupported();
            static /*0x12d5100*/ void Initialize(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            static /*0x12d5050*/ int DivRoundUp(int x, int y);
            /*0x12d61d0*/ ProbeBrickBlendingPool(UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x104b330*/ bool get_isAllocated();
            /*0x12d6210*/ int get_estimatedVMemCost();
            /*0x12d50e0*/ int GetPoolWidth();
            /*0x12d50c0*/ int GetPoolHeight();
            /*0x12d50a0*/ int GetPoolDepth();
            /*0x12d4ae0*/ void AllocateResourcesIfNeeded();
            /*0x12d5d20*/ void Update(UnityEngine.Rendering.ProbeBrickPool.DataLocation source, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> srcLocations, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, UnityEngine.Rendering.ProbeVolumeSHBands bands, int state);
            /*0x12d5230*/ void PerformBlending(UnityEngine.Rendering.CommandBuffer cmd, float factor, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x12d4dd0*/ void BlendChunks(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell, UnityEngine.Rendering.ProbeBrickPool dstPool);
            /*0x12d4f90*/ void Clear();
            /*0x12d4c30*/ bool Allocate(int numberOfBrickChunks, System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> outAllocations);
            /*0x12d4ff0*/ void Deallocate(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> allocations);
            /*0x12d5060*/ void EnsureTextureValidity();
            /*0x12d4f40*/ void Cleanup();
        }

        class ProbeCellIndices
        {
            static int kUintPerEntry = 3;
            /*0x10*/ int <estimatedVMemCost>k__BackingField;
            /*0x18*/ UnityEngine.ComputeBuffer m_IndexOfIndicesBuffer;
            /*0x20*/ uint[] m_IndexOfIndicesData;
            /*0x28*/ UnityEngine.Vector3Int m_CellCount;
            /*0x34*/ UnityEngine.Vector3Int m_CellMin;
            /*0x40*/ int m_CellSizeInMinBricks;
            /*0x44*/ bool m_NeedUpdateComputeBuffer;

            /*0x12dae70*/ ProbeCellIndices(UnityEngine.Vector3Int cellMin, UnityEngine.Vector3Int cellMax, int cellSizeInMinBricks);
            /*0x417e30*/ int get_estimatedVMemCost();
            /*0xdcd9c0*/ void set_estimatedVMemCost(int value);
            /*0x12da980*/ UnityEngine.Vector3Int GetCellIndexDimension();
            /*0x12da9a0*/ UnityEngine.Vector3Int GetCellMinPosition();
            /*0x12daa10*/ int GetFlatIndex(UnityEngine.Vector3Int normalizedPos);
            /*0x12da9c0*/ int GetFlatIdxForCell(UnityEngine.Vector3Int cellPosition);
            /*0x12dab10*/ void UpdateCell(int cellFlatIdx, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo);
            /*0x12daa80*/ void MarkCellAsUnloaded(int cellFlatIdx);
            /*0x12daae0*/ void PushComputeData();
            /*0x12daa30*/ void GetRuntimeResources(ref UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources rr);
            /*0x12da910*/ void Cleanup();

            struct IndexMetaData
            {
                static /*0x0*/ uint[] s_PackedValues;
                /*0x10*/ UnityEngine.Vector3Int minLocalIdx;
                /*0x1c*/ UnityEngine.Vector3Int maxLocalIdx;
                /*0x28*/ int firstChunkIndex;
                /*0x2c*/ int minSubdiv;

                static /*0x12d49b0*/ IndexMetaData();
                /*0x12d4810*/ void Pack(ref uint[] vals);
            }
        }

        struct ProbeVolumeSystemParameters
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget;
            /*0x14*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget;
            /*0x18*/ UnityEngine.Mesh probeDebugMesh;
            /*0x20*/ UnityEngine.Shader probeDebugShader;
            /*0x28*/ UnityEngine.Mesh offsetDebugMesh;
            /*0x30*/ UnityEngine.Shader offsetDebugShader;
            /*0x38*/ UnityEngine.ComputeShader scenarioBlendingShader;
            /*0x40*/ UnityEngine.Rendering.ProbeVolumeSceneData sceneData;
            /*0x48*/ UnityEngine.Rendering.ProbeVolumeSHBands shBands;
            /*0x4c*/ bool supportsRuntimeDebug;
            /*0x4d*/ bool supportStreaming;
        }

        struct ProbeVolumeShadingParameters
        {
            /*0x10*/ float normalBias;
            /*0x14*/ float viewBias;
            /*0x18*/ bool scaleBiasByMinDistanceBetweenProbes;
            /*0x1c*/ float samplingNoise;
            /*0x20*/ float weight;
            /*0x24*/ UnityEngine.Rendering.APVLeakReductionMode leakReductionMode;
            /*0x28*/ float occlusionWeightContribution;
            /*0x2c*/ float minValidNormalWeight;
            /*0x30*/ int frameIndexForNoise;
            /*0x34*/ float reflNormalizationLowerClamp;
            /*0x38*/ float reflNormalizationUpperClamp;
        }

        enum ProbeVolumeTextureMemoryBudget
        {
            MemoryBudgetLow = 512,
            MemoryBudgetMedium = 1024,
            MemoryBudgetHigh = 2048,
        }

        enum ProbeVolumeBlendingTextureMemoryBudget
        {
            None = 0,
            MemoryBudgetLow = 128,
            MemoryBudgetMedium = 256,
            MemoryBudgetHigh = 512,
        }

        enum ProbeVolumeSHBands
        {
            SphericalHarmonicsL1 = 1,
            SphericalHarmonicsL2 = 2,
        }

        class ProbeReferenceVolume
        {
            static int kProbesPerBatch = 511;
            static /*0x0*/ string defaultLightingScenario;
            static /*0x8*/ UnityEngine.Rendering.ProbeReferenceVolume _instance;
            static /*0x10*/ string k_DebugPanelName;
            /*0x10*/ bool m_IsInitialized;
            /*0x11*/ bool m_SupportStreaming;
            /*0x14*/ UnityEngine.Rendering.ProbeReferenceVolume.RefVolTransform m_Transform;
            /*0x34*/ int m_MaxSubdivision;
            /*0x38*/ UnityEngine.Rendering.ProbeBrickPool m_Pool;
            /*0x40*/ UnityEngine.Rendering.ProbeBrickIndex m_Index;
            /*0x48*/ UnityEngine.Rendering.ProbeCellIndices m_CellIndices;
            /*0x50*/ UnityEngine.Rendering.ProbeBrickBlendingPool m_BlendingPool;
            /*0x58*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;
            /*0x60*/ float[] m_PositionOffsets;
            /*0x68*/ UnityEngine.Bounds m_CurrGlobalBounds;
            /*0x80*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> cells;
            /*0x88*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> m_CellInfoPool;
            /*0x90*/ UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> m_BlendingCellInfoPool;
            /*0x98*/ UnityEngine.Rendering.ProbeBrickPool.DataLocation m_TemporaryDataLocation;
            /*0xe8*/ int m_TemporaryDataLocationMemCost;
            /*0xec*/ int m_CurrentProbeVolumeChunkSizeInBricks;
            /*0xf0*/ UnityEngine.Rendering.ProbeVolumeSceneData sceneData;
            /*0xf8*/ UnityEngine.Vector3Int minLoadedCellPos;
            /*0x104*/ UnityEngine.Vector3Int maxLoadedCellPos;
            /*0x110*/ System.Action<UnityEngine.Rendering.ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction;
            /*0x118*/ System.Action checksDuringBakeAction;
            /*0x120*/ bool m_BricksLoaded;
            /*0x128*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeLoaded;
            /*0x130*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;
            /*0x138*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumeAsset> m_ActiveAssets;
            /*0x140*/ bool m_NeedLoadAsset;
            /*0x141*/ bool m_ProbeReferenceVolumeInit;
            /*0x142*/ bool m_EnabledBySRP;
            /*0x144*/ UnityEngine.Rendering.ProbeReferenceVolume.InitInfo m_PendingInitInfo;
            /*0x15c*/ bool m_NeedsIndexRebuild;
            /*0x15d*/ bool m_HasChangedIndex;
            /*0x160*/ int m_CBShaderID;
            /*0x164*/ int m_NumberOfCellsLoadedPerFrame;
            /*0x168*/ int m_NumberOfCellsBlendedPerFrame;
            /*0x16c*/ float m_TurnoverRate;
            /*0x170*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget m_MemoryBudget;
            /*0x174*/ UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;
            /*0x178*/ UnityEngine.Rendering.ProbeVolumeSHBands m_SHBands;
            /*0x17c*/ float m_ProbeVolumesWeight;
            /*0x180*/ bool clearAssetsOnVolumeClear;
            /*0x188*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> <perSceneDataList>k__BackingField;
            /*0x190*/ UnityEngine.Rendering.ProbeVolumeDebug <probeVolumeDebug>k__BackingField;
            /*0x198*/ UnityEngine.Color[] <subdivisionDebugColors>k__BackingField;
            /*0x1a0*/ UnityEngine.Rendering.DebugUI.Widget[] m_DebugItems;
            /*0x1a8*/ UnityEngine.Mesh m_DebugMesh;
            /*0x1b0*/ UnityEngine.Material m_DebugMaterial;
            /*0x1b8*/ UnityEngine.Mesh m_DebugOffsetMesh;
            /*0x1c0*/ UnityEngine.Material m_DebugOffsetMaterial;
            /*0x1c8*/ UnityEngine.Plane[] m_DebugFrustumPlanes;
            /*0x1d0*/ UnityEngine.GUIContent[] m_DebugScenarioNames;
            /*0x1d8*/ int[] m_DebugScenarioValues;
            /*0x1e0*/ string m_DebugActiveSceneGUID;
            /*0x1e8*/ string m_DebugActiveScenario;
            /*0x1f0*/ UnityEngine.Rendering.DebugUI.EnumField m_DebugScenarioField;
            /*0x1f8*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings bakingProcessSettings;
            /*0x228*/ System.Collections.Generic.Dictionary<UnityEngine.Bounds, UnityEngine.Rendering.ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;
            /*0x230*/ bool m_MaxSubdivVisualizedIsMaxAvailable;
            /*0x238*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> m_LoadedCells;
            /*0x240*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> m_ToBeLoadedCells;
            /*0x248*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> m_TempCellToLoadList;
            /*0x250*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> m_TempCellToUnloadList;
            /*0x258*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> m_LoadedBlendingCells;
            /*0x260*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> m_ToBeLoadedBlendingCells;
            /*0x268*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToLoadList;
            /*0x270*/ UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToUnloadList;
            /*0x278*/ UnityEngine.Vector3 m_FrozenCameraPosition;
            /*0x284*/ bool m_HasRemainingCellsToBlend;

            static /*0x12e7490*/ ProbeReferenceVolume();
            static /*0x12e7f00*/ UnityEngine.Rendering.ProbeReferenceVolume get_instance();
            static /*0x12dc710*/ int CellSize(int subdivisionLevel);
            /*0x12e7580*/ ProbeReferenceVolume();
            /*0x12e7e90*/ UnityEngine.Bounds get_globalBounds();
            /*0x12e8040*/ void set_globalBounds(UnityEngine.Bounds value);
            /*0x12e7f50*/ bool get_isInitialized();
            /*0x12e7e80*/ bool get_enabledBySRP();
            /*0x12e7eb0*/ bool get_hasUnloadedCells();
            /*0x12e7dc0*/ bool get_enableScenarioBlending();
            /*0x12e7fa0*/ int get_numberOfCellsLoadedPerFrame();
            /*0x12e7f90*/ int get_numberOfCellsBlendedPerFrame();
            /*0x12e8090*/ void set_numberOfCellsBlendedPerFrame(int value);
            /*0x12e8030*/ float get_turnoverRate();
            /*0x12e8130*/ void set_turnoverRate(float value);
            /*0x12e8010*/ UnityEngine.Rendering.ProbeVolumeSHBands get_shBands();
            /*0x12e7f60*/ string get_lightingScenario();
            /*0x12e8060*/ void set_lightingScenario(string value);
            /*0x12e7fe0*/ float get_scenarioBlendingFactor();
            /*0x12e8100*/ void set_scenarioBlendingFactor(float value);
            /*0x12dc660*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x12e7f80*/ UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget get_memoryBudget();
            /*0x12e7fd0*/ float get_probeVolumesWeight();
            /*0x12e80d0*/ void set_probeVolumesWeight(float value);
            /*0x12e7fb0*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> get_perSceneDataList();
            /*0x12e80b0*/ void set_perSceneDataList(System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData> value);
            /*0x12e3a10*/ void RegisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x12e5380*/ void UnregisterPerSceneData(UnityEngine.Rendering.ProbeVolumePerSceneData data);
            /*0x12dfeb0*/ void Initialize(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x12e45d0*/ void SetEnableStateFromSRP(bool srpEnablesPV);
            /*0x12deb30*/ void ForceSHBand(UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x12dcbb0*/ void Cleanup();
            /*0x12df810*/ int GetVideoMemoryCost();
            /*0x12e3be0*/ void RemoveCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell);
            /*0x12e4ff0*/ void UnloadCell(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo);
            /*0x12e4ec0*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell);
            /*0x12e4dd0*/ void UnloadAllCells();
            /*0x12e4c30*/ void UnloadAllBlendingCells();
            /*0x12dbab0*/ void AddCell(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, int assetInstanceID);
            /*0x12e0620*/ bool LoadCell(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo, bool ignoreErrorLog);
            /*0x12e0250*/ void LoadAllCells();
            /*0x12e0ef0*/ void RecomputeMinMaxLoadedCellPos();
            /*0x12dc740*/ bool CheckCompatibilityWithCollection(UnityEngine.Rendering.ProbeVolumeAsset asset, System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumeAsset> collection);
            /*0x12dbcf0*/ void AddPendingAssetLoading(UnityEngine.Rendering.ProbeVolumeAsset asset);
            /*0x12dc4a0*/ void AddPendingAssetRemoval(UnityEngine.Rendering.ProbeVolumeAsset asset);
            /*0x12e3f90*/ void RemovePendingAsset(UnityEngine.Rendering.ProbeVolumeAsset asset);
            /*0x12e0aa0*/ void PerformPendingIndexChangeAndInit();
            /*0x12e4640*/ void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv);
            /*0x12e03c0*/ void LoadAsset(UnityEngine.Rendering.ProbeVolumeAsset asset);
            /*0x12e0b00*/ void PerformPendingLoading();
            /*0x12e0920*/ void PerformPendingDeletion();
            /*0x12dedc0*/ int GetNumberOfBricksAtSubdiv(UnityEngine.Vector3Int position, int minSubdiv, ref UnityEngine.Vector3Int minValidLocalIdxAtMaxRes, ref UnityEngine.Vector3Int sizeOfValidIndicesAtMaxRes);
            /*0x12deb90*/ bool GetCellIndexUpdate(UnityEngine.Rendering.ProbeReferenceVolume.Cell cell, ref UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog);
            /*0x12e0e80*/ void PerformPendingOperations();
            /*0x12df890*/ void InitProbeReferenceVolume(UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget memoryBudget, UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, UnityEngine.Rendering.ProbeVolumeSHBands shBands);
            /*0x12dc590*/ void AllocateTemporaryDataLocation();
            /*0x12df4e0*/ UnityEngine.Rendering.ProbeReferenceVolume.RuntimeResources GetRuntimeResources();
            /*0x12e4750*/ void SetTRS(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, float minBrickSize);
            /*0x12e45e0*/ void SetMaxSubdivision(int maxSubdivision);
            /*0x12dc690*/ float BrickSize(int subdivisionLevel);
            /*0x1101d20*/ float MinBrickSize();
            /*0x12e08f0*/ float MaxBrickSize();
            /*0x8b9880*/ UnityEngine.Rendering.ProbeReferenceVolume.RefVolTransform GetTransform();
            /*0x995160*/ int GetMaxSubdivision();
            /*0x12ded60*/ int GetMaxSubdivision(float multiplier);
            /*0x12ded40*/ float GetDistanceBetweenProbes(int subdivisionLevel);
            /*0x12e0900*/ float MinDistanceBetweenProbes();
            /*0x12ddf30*/ bool DataHasBeenLoaded();
            /*0x12dcd80*/ void Clear();
            /*0x12df660*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, UnityEngine.Rendering.ProbeBrickPool.DataLocation dataLoc);
            /*0x12e6d40*/ void UpdatePool(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.Cell.PerScenarioData data, Unity.Collections.NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex);
            /*0x12e6a80*/ void UpdatePoolValidity(System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList, UnityEngine.Rendering.ProbeReferenceVolume.Cell.PerScenarioData data, Unity.Collections.NativeArray<byte> validityNeighMaskData, int chunkIndex);
            /*0x12db000*/ bool AddBlendingBricks(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell);
            /*0x12db6d0*/ bool AddBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo, UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog);
            /*0x12e5cf0*/ void UpdateCellIndex(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo);
            /*0x12e3af0*/ void ReleaseBricks(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo);
            /*0x12e6700*/ void UpdateConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ProbeVolumeShadingParameters parameters);
            /*0x12dca10*/ void CleanupLoadedData();
            /*0x12e7fc0*/ UnityEngine.Rendering.ProbeVolumeDebug get_probeVolumeDebug();
            /*0x12e8020*/ UnityEngine.Color[] get_subdivisionDebugColors();
            /*0x12e4280*/ void RenderDebug(UnityEngine.Camera camera);
            /*0x12dfc60*/ void InitializeDebug(ref UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x12dc910*/ void CleanupDebug();
            /*0x2a5510*/ void DebugCellIndexChanged<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
            /*0x12e11a0*/ void RegisterDebug(UnityEngine.Rendering.ProbeVolumeSystemParameters parameters);
            /*0x12e5230*/ void UnregisterDebug(bool destroyPanel);
            /*0x12e4770*/ bool ShouldCullCell(UnityEngine.Vector3 cellPosition, UnityEngine.Transform cameraTransform, UnityEngine.Plane[] frustumPlanes);
            /*0x12ddf40*/ void DrawProbeDebug(UnityEngine.Camera camera);
            /*0x12e42e0*/ void ResetDebugViewToMaxSubdiv();
            /*0x12dcd30*/ void ClearDebugData();
            /*0x12dd1a0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo);
            /*0x12dcd30*/ void OnClearLightingdata();
            /*0x12e4390*/ void ScenarioBlendingChanged(bool scenarioChanged);
            /*0x12e4730*/ void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
            /*0x12dcef0*/ void ComputeCellCameraDistance(UnityEngine.Vector3 cameraPosition, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> cells);
            /*0x12dd0a0*/ void ComputeStreamingScoreForBlending(UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> cells, float worstScore);
            /*0x12e4b40*/ bool TryLoadCell(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo, ref int shBudget, ref int indexBudget, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> loadedCells);
            /*0x12e4f80*/ void UnloadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> unloadedCells);
            /*0x12e4ac0*/ bool TryLoadBlendingCell(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell, UnityEngine.Rendering.DynamicArray<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> loadedCells);
            /*0x12e5e30*/ void UpdateCellStreaming(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera);
            /*0x12de9e0*/ int FindWorstBlendingCellToBeLoaded();
            /*0x12e53e0*/ void UpdateBlendingCellStreaming(UnityEngine.Rendering.CommandBuffer cmd);

            class Cell
            {
                /*0x10*/ UnityEngine.Vector3Int position;
                /*0x1c*/ int index;
                /*0x20*/ int probeCount;
                /*0x24*/ int minSubdiv;
                /*0x28*/ int maxSubdiv;
                /*0x2c*/ int indexChunkCount;
                /*0x30*/ int shChunkCount;
                /*0x34*/ bool hasTwoScenarios;
                /*0x38*/ UnityEngine.Rendering.ProbeVolumeSHBands shBands;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> <bricks>k__BackingField;
                /*0x50*/ Unity.Collections.NativeArray<byte> <validityNeighMaskData>k__BackingField;
                /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Vector3> <probePositions>k__BackingField;
                /*0x70*/ Unity.Collections.NativeArray<float> <touchupVolumeInteraction>k__BackingField;
                /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Vector3> <offsetVectors>k__BackingField;
                /*0x90*/ Unity.Collections.NativeArray<float> <validity>k__BackingField;
                /*0xa0*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell.PerScenarioData scenario0;
                /*0x110*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell.PerScenarioData scenario1;

                /*0x32f970*/ Cell();
                /*0xcf6ca0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> get_bricks();
                /*0xcf6cf0*/ void set_bricks(Unity.Collections.NativeArray<UnityEngine.Rendering.ProbeBrickIndex.Brick> value);
                /*0x12ebbf0*/ Unity.Collections.NativeArray<byte> get_validityNeighMaskData();
                /*0x12ebc40*/ void set_validityNeighMaskData(Unity.Collections.NativeArray<byte> value);
                /*0x12ebbd0*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_probePositions();
                /*0x12ebc20*/ void set_probePositions(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x12ebbe0*/ Unity.Collections.NativeArray<float> get_touchupVolumeInteraction();
                /*0x12ebc30*/ void set_touchupVolumeInteraction(Unity.Collections.NativeArray<float> value);
                /*0x12ebbc0*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_offsetVectors();
                /*0x12ebc10*/ void set_offsetVectors(Unity.Collections.NativeArray<UnityEngine.Vector3> value);
                /*0x12ebc00*/ Unity.Collections.NativeArray<float> get_validity();
                /*0x12ebc50*/ void set_validity(Unity.Collections.NativeArray<float> value);
                /*0x12ebb70*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell.PerScenarioData get_bakingScenario();

                struct PerScenarioData
                {
                    /*0x10*/ Unity.Collections.NativeArray<ushort> <shL0L1RxData>k__BackingField;
                    /*0x20*/ Unity.Collections.NativeArray<byte> <shL1GL1RyData>k__BackingField;
                    /*0x30*/ Unity.Collections.NativeArray<byte> <shL1BL1RzData>k__BackingField;
                    /*0x40*/ Unity.Collections.NativeArray<byte> <shL2Data_0>k__BackingField;
                    /*0x50*/ Unity.Collections.NativeArray<byte> <shL2Data_1>k__BackingField;
                    /*0x60*/ Unity.Collections.NativeArray<byte> <shL2Data_2>k__BackingField;
                    /*0x70*/ Unity.Collections.NativeArray<byte> <shL2Data_3>k__BackingField;

                    /*0x6bba70*/ Unity.Collections.NativeArray<ushort> get_shL0L1RxData();
                    /*0xdb4640*/ void set_shL0L1RxData(Unity.Collections.NativeArray<ushort> value);
                    /*0x8b2880*/ Unity.Collections.NativeArray<byte> get_shL1GL1RyData();
                    /*0x9f0700*/ void set_shL1GL1RyData(Unity.Collections.NativeArray<byte> value);
                    /*0xc53890*/ Unity.Collections.NativeArray<byte> get_shL1BL1RzData();
                    /*0x12f4b90*/ void set_shL1BL1RzData(Unity.Collections.NativeArray<byte> value);
                    /*0x10daa90*/ Unity.Collections.NativeArray<byte> get_shL2Data_0();
                    /*0x12f4ba0*/ void set_shL2Data_0(Unity.Collections.NativeArray<byte> value);
                    /*0xcf6ca0*/ Unity.Collections.NativeArray<byte> get_shL2Data_1();
                    /*0xcf6cf0*/ void set_shL2Data_1(Unity.Collections.NativeArray<byte> value);
                    /*0x12ebbf0*/ Unity.Collections.NativeArray<byte> get_shL2Data_2();
                    /*0x12ebc40*/ void set_shL2Data_2(Unity.Collections.NativeArray<byte> value);
                    /*0x12ebbd0*/ Unity.Collections.NativeArray<byte> get_shL2Data_3();
                    /*0x12ebc20*/ void set_shL2Data_3(Unity.Collections.NativeArray<byte> value);
                }
            }

            class CellInfo : System.IComparable<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo>
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell cell;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo blendingCell;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x28*/ int flatIdxInCellIndices;
                /*0x2c*/ bool loaded;
                /*0x30*/ UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo updateInfo;
                /*0x60*/ bool indexUpdated;
                /*0x64*/ UnityEngine.Rendering.ProbeBrickIndex.CellIndexUpdateInfo tempUpdateInfo;
                /*0x94*/ int sourceAssetInstanceID;
                /*0x98*/ float streamingScore;
                /*0x9c*/ int referenceCount;
                /*0xa0*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInstancedDebugProbes debugProbes;

                /*0x12ebaf0*/ CellInfo();
                /*0x12ebaa0*/ int CompareTo(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo other);
                /*0x12eb9f0*/ void Clear();
            }

            class BlendingCellInfo : System.IComparable<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo>
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume.CellInfo cellInfo;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeBrickPool.BrickChunkAlloc> chunkList;
                /*0x20*/ float streamingScore;
                /*0x24*/ float blendingFactor;
                /*0x28*/ bool blending;

                /*0x12eacd0*/ BlendingCellInfo();
                /*0x12eac00*/ int CompareTo(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo other);
                /*0x12eab90*/ void Clear();
                /*0x12eac70*/ void MarkUpToDate();
                /*0x12eac50*/ bool IsUpToDate();
                /*0x12eac40*/ void ForceReupload();
                /*0x12eacb0*/ bool ShouldReupload();
                /*0x12eac80*/ void Prioritize();
                /*0x12eac90*/ bool ShouldPrioritize();
            }

            struct Volume : System.IEquatable<UnityEngine.Rendering.ProbeReferenceVolume.Volume>
            {
                /*0x10*/ UnityEngine.Vector3 corner;
                /*0x1c*/ UnityEngine.Vector3 X;
                /*0x28*/ UnityEngine.Vector3 Y;
                /*0x34*/ UnityEngine.Vector3 Z;
                /*0x40*/ float maxSubdivisionMultiplier;
                /*0x44*/ float minSubdivisionMultiplier;

                /*0x1303bb0*/ Volume(UnityEngine.Matrix4x4 trs, float maxSubdivision, float minSubdivision);
                /*0x1303b00*/ Volume(UnityEngine.Vector3 corner, UnityEngine.Vector3 X, UnityEngine.Vector3 Y, UnityEngine.Vector3 Z, float maxSubdivision, float minSubdivision);
                /*0x1303b60*/ Volume(UnityEngine.Rendering.ProbeReferenceVolume.Volume copy);
                /*0x1303d70*/ Volume(UnityEngine.Bounds bounds);
                /*0x1303220*/ UnityEngine.Bounds CalculateAABB();
                /*0x13034c0*/ void CalculateCenterAndSize(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
                /*0x1303a10*/ void Transform(UnityEngine.Matrix4x4 trs);
                /*0x1303750*/ string ToString();
                /*0x13035e0*/ bool Equals(UnityEngine.Rendering.ProbeReferenceVolume.Volume other);
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
                /*0x58*/ UnityEngine.Texture3D Validity;
            }

            struct ExtraDataActionInput
            {
            }

            struct InitInfo
            {
                /*0x10*/ UnityEngine.Vector3Int pendingMinCellPosition;
                /*0x1c*/ UnityEngine.Vector3Int pendingMaxCellPosition;
            }

            class CellInstancedDebugProbes
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Matrix4x4[]> probeBuffers;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Matrix4x4[]> offsetBuffers;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.MaterialPropertyBlock> props;

                /*0x32f970*/ CellInstancedDebugProbes();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.ProbeReferenceVolume.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.CellInfo> <>9__120_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo> <>9__120_1;
                static /*0x18*/ System.Func<float> <>9__171_7;
                static /*0x20*/ System.Func<float> <>9__171_16;
                static /*0x28*/ System.Func<float> <>9__171_17;
                static /*0x30*/ System.Func<int> <>9__171_22;
                static /*0x38*/ System.Func<int> <>9__171_23;
                static /*0x40*/ System.Func<int> <>9__171_26;
                static /*0x48*/ System.Func<int> <>9__171_27;
                static /*0x50*/ System.Func<float> <>9__171_32;
                static /*0x58*/ System.Func<float> <>9__171_33;
                static /*0x60*/ System.Func<float> <>9__171_36;
                static /*0x68*/ System.Func<int> <>9__171_39;
                static /*0x70*/ System.Action<int> <>9__171_40;
                static /*0x78*/ System.Func<int> <>9__171_41;
                static /*0x80*/ System.Func<int> <>9__171_43;
                static /*0x88*/ System.Action<int> <>9__171_44;
                static /*0x90*/ System.Func<int> <>9__171_45;
                static /*0x98*/ System.Func<float> <>9__171_46;
                static /*0xa0*/ System.Action<float> <>9__171_47;
                static /*0xa8*/ System.Func<float> <>9__171_48;
                static /*0xb0*/ System.Func<float> <>9__171_49;
                static /*0xb8*/ System.Func<float> <>9__171_54;
                static /*0xc0*/ System.Action<float> <>9__171_55;
                static /*0xc8*/ System.Func<float> <>9__171_56;
                static /*0xd0*/ System.Func<float> <>9__171_57;

                static /*0x13030c0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1301cf0*/ void <.ctor>b__120_0(UnityEngine.Rendering.ProbeReferenceVolume.CellInfo x);
                /*0x1301db0*/ void <.ctor>b__120_1(UnityEngine.Rendering.ProbeReferenceVolume.BlendingCellInfo x);
                /*0x1301790*/ float <RegisterDebug>b__171_7();
                /*0x1301630*/ float <RegisterDebug>b__171_16();
                /*0x1301640*/ float <RegisterDebug>b__171_17();
                /*0x388e90*/ int <RegisterDebug>b__171_22();
                /*0x1301650*/ int <RegisterDebug>b__171_23();
                /*0x388e90*/ int <RegisterDebug>b__171_26();
                /*0x13016e0*/ int <RegisterDebug>b__171_27();
                /*0x1301770*/ float <RegisterDebug>b__171_32();
                /*0x1301780*/ float <RegisterDebug>b__171_33();
                /*0x1301790*/ float <RegisterDebug>b__171_36();
                /*0x13017a0*/ int <RegisterDebug>b__171_39();
                /*0x1301830*/ void <RegisterDebug>b__171_40(int value);
                /*0x388e90*/ int <RegisterDebug>b__171_41();
                /*0x13018d0*/ int <RegisterDebug>b__171_43();
                /*0x1301960*/ void <RegisterDebug>b__171_44(int value);
                /*0x388e90*/ int <RegisterDebug>b__171_45();
                /*0x1301a00*/ float <RegisterDebug>b__171_46();
                /*0x1301a90*/ void <RegisterDebug>b__171_47(float value);
                /*0x1301790*/ float <RegisterDebug>b__171_48();
                /*0x12c8cc0*/ float <RegisterDebug>b__171_49();
                /*0x1301b30*/ float <RegisterDebug>b__171_54();
                /*0x1301bc0*/ void <RegisterDebug>b__171_55(float value);
                /*0x1301790*/ float <RegisterDebug>b__171_56();
                /*0x12c8cc0*/ float <RegisterDebug>b__171_57();
            }

            class <>c__DisplayClass171_0
            {
                /*0x10*/ UnityEngine.Rendering.ProbeReferenceVolume <>4__this;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumeSystemParameters parameters;

                /*0x32f970*/ <>c__DisplayClass171_0();
                /*0x2a5510*/ void <RegisterDebug>g__RefreshDebug|0<T>(UnityEngine.Rendering.DebugUI.Field<T> field, T value);
                /*0x1301f40*/ bool <RegisterDebug>b__1();
                /*0x1302230*/ void <RegisterDebug>b__2(bool value);
                /*0x1302380*/ bool <RegisterDebug>b__3();
                /*0x13023b0*/ void <RegisterDebug>b__4(bool value);
                /*0x1302760*/ float <RegisterDebug>b__5();
                /*0x1302790*/ void <RegisterDebug>b__6(float value);
                /*0x13027c0*/ bool <RegisterDebug>b__8();
                /*0x13027f0*/ void <RegisterDebug>b__9(bool value);
                /*0x1301e20*/ int <RegisterDebug>b__10();
                /*0x1301e50*/ void <RegisterDebug>b__11(int value);
                /*0x1301e20*/ int <RegisterDebug>b__12();
                /*0x1301e50*/ void <RegisterDebug>b__13(int value);
                /*0x1301e80*/ float <RegisterDebug>b__14();
                /*0x1301eb0*/ void <RegisterDebug>b__15(float value);
                /*0x1301ee0*/ float <RegisterDebug>b__18();
                /*0x1301f10*/ void <RegisterDebug>b__19(float value);
                /*0x1301f70*/ int <RegisterDebug>b__20();
                /*0x1301fa0*/ void <RegisterDebug>b__21(int v);
                /*0x1302060*/ int <RegisterDebug>b__24();
                /*0x1302090*/ void <RegisterDebug>b__25(int v);
                /*0x13020c0*/ bool <RegisterDebug>b__28();
                /*0x13020f0*/ void <RegisterDebug>b__29(bool value);
                /*0x1302260*/ float <RegisterDebug>b__30();
                /*0x1302290*/ void <RegisterDebug>b__31(float value);
                /*0x13022c0*/ float <RegisterDebug>b__34();
                /*0x13022f0*/ void <RegisterDebug>b__35(float value);
                /*0x1302320*/ bool <RegisterDebug>b__37();
                /*0x1302350*/ void <RegisterDebug>b__38(bool value);
                /*0x1302820*/ void <RegisterDebug>g__RefreshScenarioNames|42(string guid);
                /*0x13023e0*/ int <RegisterDebug>b__50();
                /*0x1302660*/ void <RegisterDebug>b__51(int value);
                /*0x1302700*/ int <RegisterDebug>b__52();
                /*0x1302730*/ void <RegisterDebug>b__53(int value);
            }
        }

        enum DebugProbeShadingMode
        {
            SH = 0,
            SHL0 = 1,
            SHL0L1 = 2,
            Validity = 3,
            ValidityOverDilationThreshold = 4,
            InvalidatedByTouchupVolumes = 5,
            Size = 6,
        }

        class ProbeVolumeDebug : UnityEngine.Rendering.IDebugData
        {
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
            /*0x38*/ bool drawVirtualOffsetPush;
            /*0x3c*/ float offsetSize;
            /*0x40*/ bool freezeStreaming;
            /*0x44*/ int otherStateIndex;

            /*0x12f7670*/ ProbeVolumeDebug();
            /*0x12f7620*/ void Init();
            /*0x12f75b0*/ System.Action GetReset();
            /*0x12f7620*/ void <GetReset>b__19_0();
        }

        class ProbeReferenceVolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolumeProfile.Version version;
            /*0x1c*/ bool freezePlacement;
            /*0x20*/ int simplificationLevels;
            /*0x24*/ float minDistanceBetweenProbes;
            /*0x28*/ UnityEngine.LayerMask renderersLayerMask;
            /*0x2c*/ float minRendererVolumeSize;

            /*0x12f64e0*/ ProbeReferenceVolumeProfile();
            /*0x12f6570*/ int get_cellSizeInBricks();
            /*0x12f65f0*/ int get_maxSubdivision();
            /*0x12f6600*/ float get_minBrickSize();
            /*0x12f65a0*/ float get_cellSizeInMeters();
            /*0x12f6480*/ void OnEnable();
            /*0x12f6370*/ bool IsEquivalent(UnityEngine.Rendering.ProbeReferenceVolumeProfile otherProfile);

            enum Version
            {
                Initial = 0,
            }
        }

        class ProbeTouchupVolume : UnityEngine.MonoBehaviour
        {
            /*0x20*/ float intensityScale;
            /*0x24*/ bool invalidateProbes;
            /*0x25*/ bool overrideDilationThreshold;
            /*0x28*/ float overriddenDilationThreshold;
            /*0x2c*/ UnityEngine.Vector3 size;

            /*0x12f6620*/ ProbeTouchupVolume();
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

            /*0x12fb230*/ ProbeVolume();
            /*0x12fb200*/ void Awake();

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
                Count = 2,
            }
        }

        class ProbeVolumeAsset : UnityEngine.ScriptableObject
        {
            /*0x18*/ int m_Version;
            /*0x20*/ UnityEngine.Rendering.ProbeReferenceVolume.Cell[] cells;
            /*0x28*/ UnityEngine.Rendering.ProbeVolumeAsset.CellCounts[] cellCounts;
            /*0x30*/ UnityEngine.Rendering.ProbeVolumeAsset.CellCounts totalCellCounts;
            /*0x40*/ UnityEngine.Vector3Int maxCellPosition;
            /*0x4c*/ UnityEngine.Vector3Int minCellPosition;
            /*0x58*/ UnityEngine.Bounds globalBounds;
            /*0x70*/ UnityEngine.Rendering.ProbeVolumeSHBands bands;
            /*0x74*/ int chunkSizeInBricks;
            /*0x78*/ string m_AssetFullPath;
            /*0x80*/ int cellSizeInBricks;
            /*0x84*/ int simplificationLevels;
            /*0x88*/ float minDistanceBetweenProbes;

            static /*0x12f6650*/ int AlignUp16(int count);
            /*0x12f73c0*/ ProbeVolumeAsset();
            /*0x8a5c20*/ int get_Version();
            /*0x12f7420*/ int get_maxSubdivision();
            /*0x12f7430*/ float get_minBrickSize();
            /*0x12f6680*/ bool CompatibleWith(UnityEngine.Rendering.ProbeVolumeAsset otherAsset);
            /*0x12f6700*/ bool IsInvalid();
            /*0xecb7b0*/ string GetSerializedFullPath();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> GetSubArray<T>(Unity.Collections.NativeArray<byte> input, int count, ref int offset);
            /*0x12f6df0*/ bool ResolveSharedCellData(UnityEngine.TextAsset cellSharedDataAsset, UnityEngine.TextAsset cellSupportDataAsset);
            /*0x12f6720*/ bool ResolvePerScenarioCellData(UnityEngine.TextAsset cellDataAsset, UnityEngine.TextAsset cellOptionalDataAsset, int stateIndex);

            enum AssetVersion
            {
                First = 0,
                AddProbeVolumesAtlasEncodingModes = 1,
                PV2 = 2,
                ChunkBasedIndex = 3,
                BinaryRuntimeDebugSplit = 4,
                BinaryTextureData = 5,
                Max = 6,
                Current = 5,
            }

            struct CellCounts
            {
                /*0x10*/ int bricksCount;
                /*0x14*/ int probesCount;
                /*0x18*/ int offsetsCount;
                /*0x1c*/ int chunksCount;

                /*0x12eb9d0*/ void Add(UnityEngine.Rendering.ProbeVolumeAsset.CellCounts o);
            }
        }

        struct ProbeDilationSettings
        {
            /*0x10*/ bool enableDilation;
            /*0x14*/ float dilationDistance;
            /*0x18*/ float dilationValidityThreshold;
            /*0x1c*/ int dilationIterations;
            /*0x20*/ bool squaredDistWeighting;

            /*0x12f6350*/ void SetDefaults();
            /*0x32d010*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct VirtualOffsetSettings
        {
            /*0x10*/ bool useVirtualOffset;
            /*0x14*/ float outOfGeoOffset;
            /*0x18*/ float searchMultiplier;
            /*0x1c*/ float rayOriginBias;
            /*0x20*/ int maxHitsPerRay;
            /*0x24*/ UnityEngine.LayerMask collisionMask;

            /*0x13031a0*/ void SetDefaults();
            /*0x13031e0*/ void UpgradeFromTo(UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion from, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion to);
        }

        struct ProbeVolumeBakingProcessSettings
        {
            /*0x10*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings.SettingsVersion m_Version;
            /*0x14*/ UnityEngine.Rendering.ProbeDilationSettings dilationSettings;
            /*0x28*/ UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings;

            static /*0x12f7530*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings get_Default();
            /*0x12f7500*/ ProbeVolumeBakingProcessSettings(UnityEngine.Rendering.ProbeDilationSettings dilationSettings, UnityEngine.Rendering.VirtualOffsetSettings virtualOffsetSettings);
            /*0x12f7450*/ void SetDefaults();
            /*0x12f74c0*/ void Upgrade();

            enum SettingsVersion
            {
                Initial = 0,
                ThreadedVirtualOffset = 1,
                Max = 2,
                Current = 1,
            }
        }

        struct GIContributors
        {
        }

        class ProbeVolumePerSceneData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x20*/ UnityEngine.Rendering.ProbeVolumeAsset asset;
            /*0x28*/ UnityEngine.TextAsset cellSharedDataAsset;
            /*0x30*/ UnityEngine.TextAsset cellSupportDataAsset;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumePerSceneData.SerializablePerScenarioDataItem> serializedScenarios;
            /*0x40*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumePerSceneData.PerScenarioData> scenarios;
            /*0x48*/ bool assetLoaded;
            /*0x50*/ string activeScenario;
            /*0x58*/ string otherScenario;

            /*0x12f8660*/ ProbeVolumePerSceneData();
            /*0x12f8130*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x12f82a0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x12f7700*/ void Clear();
            /*0x12f7d50*/ void RemoveScenario(string scenario);
            /*0x12f7db0*/ void RenameScenario(string scenario, string newName);
            /*0x12f7e90*/ bool ResolveCells();
            /*0x12f80a0*/ bool ResolveSharedCellData();
            /*0x12f7ec0*/ bool ResolvePerScenarioCellData();
            /*0x12f7b90*/ void QueueAssetLoading();
            /*0x12f7c70*/ void QueueAssetRemoval();
            /*0x12f7960*/ void OnEnable();
            /*0x12f7890*/ void OnDisable();
            /*0x12f7750*/ void Initialize();
            /*0x12f85a0*/ void UpdateActiveScenario(string activeScenario, string otherScenario);

            struct PerScenarioData
            {
                /*0x10*/ int sceneHash;
                /*0x18*/ UnityEngine.TextAsset cellDataAsset;
                /*0x20*/ UnityEngine.TextAsset cellOptionalDataAsset;
            }

            struct SerializablePerScenarioDataItem
            {
                /*0x10*/ string scenario;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumePerSceneData.PerScenarioData data;
            }
        }

        class ProbeVolumeSceneData : UnityEngine.ISerializationCallbackReceiver
        {
            static /*0x0*/ System.Reflection.PropertyInfo s_SceneGUID;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.SerializableBoundItem> serializedBounds;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.BakingSet> serializedBakingSets;
            /*0x38*/ UnityEngine.Object parentAsset;
            /*0x40*/ string parentSceneDataPropertyName;
            /*0x48*/ System.Collections.Generic.Dictionary<string, UnityEngine.Bounds> sceneBounds;
            /*0x50*/ System.Collections.Generic.Dictionary<string, bool> hasProbeVolumes;
            /*0x58*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeReferenceVolumeProfile> sceneProfiles;
            /*0x60*/ System.Collections.Generic.Dictionary<string, UnityEngine.Rendering.ProbeVolumeBakingProcessSettings> sceneBakingSettings;
            /*0x68*/ System.Collections.Generic.List<UnityEngine.Rendering.ProbeVolumeSceneData.BakingSet> bakingSets;
            /*0x70*/ string m_LightingScenario;
            /*0x78*/ string m_OtherScenario;
            /*0x80*/ float m_ScenarioBlendingFactor;

            static /*0x12fae00*/ ProbeVolumeSceneData();
            static /*0x12f8cb0*/ string GetSceneGUID(UnityEngine.SceneManagement.Scene scene);
            /*0x12faec0*/ ProbeVolumeSceneData(UnityEngine.Object parentAsset, string parentSceneDataPropertyName);
            /*0xd184b0*/ string get_lightingScenario();
            /*0xecb7b0*/ string get_otherScenario();
            /*0x12fb1f0*/ float get_scenarioBlendingFactor();
            /*0x12fa640*/ void SetActiveScenario(string scenario);
            /*0x12f8720*/ void BlendLightingScenario(string otherScenario, float blendingFactor);
            /*0x12fa950*/ void SetParentObject(UnityEngine.Object parent, string parentSceneDataPropertyName);
            /*0x12f8fd0*/ void OnAfterDeserialize();
            /*0x12fac50*/ void UpdateBakingSets();
            /*0x12f9930*/ void OnBeforeSerialize();
            /*0x12f8b30*/ UnityEngine.Rendering.ProbeVolumeSceneData.BakingSet CreateNewBakingSet(string name);
            /*0x12f8d80*/ void InitializeBakingSet(UnityEngine.Rendering.ProbeVolumeSceneData.BakingSet set, string name);
            /*0x12f8eb0*/ void InitializeScenarios(UnityEngine.Rendering.ProbeVolumeSceneData.BakingSet set);
            /*0x12fa9a0*/ void SyncBakingSetSettings();

            struct SerializableBoundItem
            {
                /*0x10*/ string sceneGUID;
                /*0x18*/ UnityEngine.Bounds bounds;
            }

            struct SerializableHasPVItem
            {
                /*0x10*/ string sceneGUID;
                /*0x18*/ bool hasProbeVolumes;
            }

            struct SerializablePVProfile
            {
                /*0x10*/ string sceneGUID;
                /*0x18*/ UnityEngine.Rendering.ProbeReferenceVolumeProfile profile;
            }

            struct SerializablePVBakeSettings
            {
                /*0x10*/ string sceneGUID;
                /*0x18*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings settings;
            }

            class BakingSet
            {
                /*0x10*/ string name;
                /*0x18*/ System.Collections.Generic.List<string> sceneGUIDs;
                /*0x20*/ UnityEngine.Rendering.ProbeVolumeBakingProcessSettings settings;
                /*0x50*/ UnityEngine.Rendering.ProbeReferenceVolumeProfile profile;
                /*0x58*/ System.Collections.Generic.List<string> lightingScenarios;

                /*0x12eaae0*/ BakingSet();
                /*0x12ea920*/ string CreateScenario(string name);
                /*0x12eaa80*/ bool RemoveScenario(string name);
            }
        }

        enum APVConstantBufferRegister
        {
            GlobalRegister = 5,
        }

        enum APVLeakReductionMode
        {
            None = 0,
            ValidityAndNormalBased = 1,
        }

        struct ShaderVariablesProbeVolumes
        {
            /*0x10*/ UnityEngine.Vector4 _PoolDim_CellInMeters;
            /*0x20*/ UnityEngine.Vector4 _MinCellPos_Noise;
            /*0x30*/ UnityEngine.Vector4 _IndicesDim_IndexChunkSize;
            /*0x40*/ UnityEngine.Vector4 _Biases_CellInMinBrick_MinBrickSize;
            /*0x50*/ UnityEngine.Vector4 _LeakReductionParams;
            /*0x60*/ UnityEngine.Vector4 _Weight_MinLoadedCell;
            /*0x70*/ UnityEngine.Vector4 _MaxLoadedCell_FrameIndex;
            /*0x80*/ UnityEngine.Vector4 _NormalizationClamp_Padding12;
        }

        struct SphericalHarmonicsL1
        {
            static /*0x0*/ UnityEngine.Rendering.SphericalHarmonicsL1 zero;
            /*0x10*/ UnityEngine.Vector4 shAr;
            /*0x20*/ UnityEngine.Vector4 shAg;
            /*0x30*/ UnityEngine.Vector4 shAb;

            static /*0x1300640*/ SphericalHarmonicsL1();
            static /*0x1300720*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x1300c20*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Subtraction(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x1300b30*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x1300850*/ UnityEngine.Rendering.SphericalHarmonicsL1 op_Division(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, float rhs);
            static /*0x1300940*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            static /*0x1300a90*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL1 lhs, UnityEngine.Rendering.SphericalHarmonicsL1 rhs);
            /*0x13003f0*/ bool Equals(object other);
            /*0x1300510*/ int GetHashCode();
        }

        class SphericalHarmonicsL2Utils
        {
            static /*0x1300de0*/ void GetL1(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L1_R, ref UnityEngine.Vector3 L1_G, ref UnityEngine.Vector3 L1_B);
            static /*0x1300f20*/ void GetL2(UnityEngine.Rendering.SphericalHarmonicsL2 sh, ref UnityEngine.Vector3 L2_0, ref UnityEngine.Vector3 L2_1, ref UnityEngine.Vector3 L2_2, ref UnityEngine.Vector3 L2_3, ref UnityEngine.Vector3 L2_4);
            static /*0x1301190*/ void SetL0(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L0);
            static /*0x1301300*/ void SetL1R(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R);
            static /*0x1301280*/ void SetL1G(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_G);
            static /*0x1301200*/ void SetL1B(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_B);
            static /*0x1301380*/ void SetL1(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector3 L1_R, UnityEngine.Vector3 L1_G, UnityEngine.Vector3 L1_B);
            static /*0x1301110*/ void SetCoefficient(ref UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index, UnityEngine.Vector3 coefficient);
            static /*0x1300d50*/ UnityEngine.Vector3 GetCoefficient(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int index);
            /*0x32f970*/ SphericalHarmonicsL2Utils();
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
            static /*0x3c*/ bool s_SupportsLensFlareTexFormat;

            static /*0x12f3450*/ LensFlareCommonSRP();
            static /*0x12f1a50*/ bool IsOcclusionRTCompatible();
            static /*0x12f12e0*/ void Initialize();
            static /*0x12edae0*/ void Dispose();
            static /*0x12f36b0*/ UnityEngine.Rendering.LensFlareCommonSRP get_Instance();
            static /*0x12c8cc0*/ float ShapeAttenuationPointLight();
            static /*0x12f24a0*/ float ShapeAttenuationDirLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x12f2550*/ float ShapeAttenuationSpotConeLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo, float spotAngle, float innerSpotPercent01);
            static /*0x12f24f0*/ float ShapeAttenuationSpotBoxLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x12f2670*/ float ShapeAttenuationSpotPyramidLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x12f2050*/ float ShapeAttenuationAreaTubeLight(UnityEngine.Vector3 lightPositionWS, UnityEngine.Vector3 lightSide, float lightWidth, UnityEngine.Camera cam);
            static /*0x12f1fc0*/ float ShapeAttenuationAreaRectangleLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x12f1f30*/ float ShapeAttenuationAreaDiscLight(UnityEngine.Vector3 forward, UnityEngine.Vector3 wo);
            static /*0x12f1910*/ bool IsLensFlareSRPHidden(UnityEngine.Camera cam, UnityEngine.Rendering.LensFlareComponentSRP comp, UnityEngine.Rendering.LensFlareDataSRP data);
            static /*0x12f0e80*/ UnityEngine.Vector4 GetFlareData0(UnityEngine.Vector2 screenPos, UnityEngine.Vector2 translationScale, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, UnityEngine.Vector2 positionOffset, bool autoRotate);
            static /*0x12f1130*/ UnityEngine.Vector2 GetLensFlareRayOffset(UnityEngine.Vector2 screenPos, float position, float globalCos0, float globalSin0);
            static /*0x12f3130*/ UnityEngine.Vector3 WorldToViewport(UnityEngine.Camera camera, bool isLocalLight, bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 positionWS);
            static /*0x12f2fa0*/ UnityEngine.Vector3 WorldToViewportLocal(bool isCameraRelative, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Vector3 cameraPosWS, UnityEngine.Vector3 positionWS);
            static /*0x12f2de0*/ UnityEngine.Vector3 WorldToViewportDistance(UnityEngine.Camera cam, UnityEngine.Vector3 positionWS);
            static /*0x12f1610*/ bool IsCloudLayerOpacityNeeded(UnityEngine.Camera cam);
            static /*0x12f1db0*/ void SetOcclusionPermutation(UnityEngine.Rendering.CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture);
            static /*0x12ec910*/ void ComputeOcclusion(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
            static /*0x12edc40*/ void DoLensFlareDataDrivenCommon(UnityEngine.Material lensFlareShader, UnityEngine.Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, UnityEngine.Vector3 cameraPositionWS, UnityEngine.Matrix4x4 viewProjMatrix, UnityEngine.Rendering.CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, UnityEngine.Texture cloudOpacityTexture, UnityEngine.Texture sunOcclusionTexture, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
            static /*0x12f0be0*/ UnityEngine.Vector2 DoPaniniProjection(UnityEngine.Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance);
            static /*0x12ec8c0*/ UnityEngine.Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView);
            static /*0x12ec7a0*/ UnityEngine.Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d);
            static /*0x12f1ad0*/ UnityEngine.Vector2 Panini_Generic_Inv(UnityEngine.Vector2 projPos, float d);
            static /*0x12f2d60*/ float <ShapeAttenuationAreaTubeLight>g__Fpo|28_0(float d, float l);
            static /*0x12f2dc0*/ float <ShapeAttenuationAreaTubeLight>g__Fwt|28_1(float d, float l);
            static /*0x12f2920*/ float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|28_2(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
            static /*0x12f2720*/ UnityEngine.Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|40_0(UnityEngine.Vector2 rayOff, UnityEngine.Vector2 rayOff0, UnityEngine.Vector2 curSize, UnityEngine.AnimationCurve distortionCurve, ref UnityEngine.Rendering.LensFlareCommonSRP.<> , ref UnityEngine.Rendering.LensFlareCommonSRP.<> , ref UnityEngine.Rendering.LensFlareCommonSRP.<> );
            static /*0x12f2910*/ float <DoLensFlareDataDrivenCommon>g__RandomRange|40_1(float min, float max);
            /*0x32f970*/ LensFlareCommonSRP();
            /*0x12f3660*/ System.Collections.Generic.List<UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo> get_Data();
            /*0x12f1890*/ bool IsEmpty();
            /*0x12f11a0*/ int GetNextAvailableIndex();
            /*0x12ec480*/ void AddData(UnityEngine.Rendering.LensFlareComponentSRP newData);
            /*0x12f1b60*/ void RemoveData(UnityEngine.Rendering.LensFlareComponentSRP data);

            class LensFlareCompInfo
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.Rendering.LensFlareComponentSRP comp;

                /*0x12f3850*/ LensFlareCompInfo(int idx, UnityEngine.Rendering.LensFlareComponentSRP cmp);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP newData;

                /*0x32f970*/ <>c__DisplayClass21_0();
                /*0x1302fe0*/ bool <AddData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareComponentSRP data;

                /*0x32f970*/ <>c__DisplayClass22_0();
                /*0x1303050*/ bool <RemoveData>b__0(UnityEngine.Rendering.LensFlareCommonSRP.LensFlareCompInfo x);
            }

            struct <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Vector2 screenPos;
            }

            struct <>c__DisplayClass40_1
            {
                /*0x10*/ UnityEngine.Rendering.LensFlareDataElementSRP element;
            }

            struct <>c__DisplayClass40_2
            {
                /*0x10*/ float position;
                /*0x14*/ float globalCos0;
                /*0x18*/ float globalSin0;
                /*0x1c*/ float combinedScale;
                /*0x20*/ float usedAspectRatio;
            }
        }

        class LensFlareComponentSRP : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ float sCelestialAngularRadius;
            /*0x20*/ UnityEngine.Rendering.LensFlareDataSRP m_LensFlareData;
            /*0x28*/ float intensity;
            /*0x2c*/ float maxAttenuationDistance;
            /*0x30*/ float maxAttenuationScale;
            /*0x38*/ UnityEngine.AnimationCurve distanceAttenuationCurve;
            /*0x40*/ UnityEngine.AnimationCurve scaleByDistanceCurve;
            /*0x48*/ bool attenuationByLightShape;
            /*0x50*/ UnityEngine.AnimationCurve radialScreenAttenuationCurve;
            /*0x58*/ bool useOcclusion;
            /*0x5c*/ float occlusionRadius;
            /*0x60*/ bool useBackgroundCloudOcclusion;
            /*0x64*/ uint sampleCount;
            /*0x68*/ float occlusionOffset;
            /*0x6c*/ float scale;
            /*0x70*/ bool allowOffScreen;
            /*0x71*/ bool volumetricCloudOcclusion;
            /*0x78*/ UnityEngine.Rendering.TextureCurve occlusionRemapCurve;

            static /*0x12f3ab0*/ LensFlareComponentSRP();
            /*0x12f3af0*/ LensFlareComponentSRP();
            /*0x61a260*/ UnityEngine.Rendering.LensFlareDataSRP get_lensFlareData();
            /*0x12f3f70*/ void set_lensFlareData(UnityEngine.Rendering.LensFlareDataSRP value);
            /*0x12f3ea0*/ float celestialProjectedOcclusionRadius(UnityEngine.Camera mainCam);
            /*0x12f38f0*/ void OnEnable();
            /*0x12f3890*/ void OnDisable();
            /*0x12f39c0*/ void OnValidate();
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
        }

        class LensFlareDataElementSRP
        {
            /*0x10*/ bool visible;
            /*0x14*/ float position;
            /*0x18*/ UnityEngine.Vector2 positionOffset;
            /*0x20*/ float angularOffset;
            /*0x24*/ UnityEngine.Vector2 translationScale;
            /*0x2c*/ float m_LocalIntensity;
            /*0x30*/ UnityEngine.Texture lensFlareTexture;
            /*0x38*/ float uniformScale;
            /*0x3c*/ UnityEngine.Vector2 sizeXY;
            /*0x44*/ bool allowMultipleElement;
            /*0x48*/ int m_Count;
            /*0x4c*/ bool preserveAspectRatio;
            /*0x50*/ float rotation;
            /*0x54*/ UnityEngine.Color tint;
            /*0x64*/ UnityEngine.Rendering.SRPLensFlareBlendMode blendMode;
            /*0x68*/ bool autoRotate;
            /*0x6c*/ UnityEngine.Rendering.SRPLensFlareType flareType;
            /*0x70*/ bool modulateByLightColor;
            /*0x71*/ bool isFoldOpened;
            /*0x74*/ UnityEngine.Rendering.SRPLensFlareDistribution distribution;
            /*0x78*/ float lengthSpread;
            /*0x80*/ UnityEngine.AnimationCurve positionCurve;
            /*0x88*/ UnityEngine.AnimationCurve scaleCurve;
            /*0x90*/ int seed;
            /*0x98*/ UnityEngine.Gradient colorGradient;
            /*0xa0*/ float m_IntensityVariation;
            /*0xa4*/ UnityEngine.Vector2 positionVariation;
            /*0xac*/ float scaleVariation;
            /*0xb0*/ float rotationVariation;
            /*0xb4*/ bool enableRadialDistortion;
            /*0xb8*/ UnityEngine.Vector2 targetSizeDistortion;
            /*0xc0*/ UnityEngine.AnimationCurve distortionCurve;
            /*0xc8*/ bool distortionRelativeToCenter;
            /*0xcc*/ float m_FallOff;
            /*0xd0*/ float m_EdgeOffset;
            /*0xd4*/ int m_SideCount;
            /*0xd8*/ float m_SdfRoundness;
            /*0xdc*/ bool inverseSDF;
            /*0xe0*/ float uniformAngle;
            /*0xe8*/ UnityEngine.AnimationCurve uniformAngleCurve;

            /*0x12f4060*/ LensFlareDataElementSRP();
            /*0x4ccc40*/ float get_localIntensity();
            /*0x12f48c0*/ void set_localIntensity(float value);
            /*0x12f47d0*/ int get_count();
            /*0x12f4830*/ void set_count(int value);
            /*0x12f4800*/ float get_intensityVariation();
            /*0x12f48a0*/ void set_intensityVariation(float value);
            /*0x12f47f0*/ float get_fallOff();
            /*0x12f4870*/ void set_fallOff(float value);
            /*0x12f47e0*/ float get_edgeOffset();
            /*0x12f4840*/ void set_edgeOffset(float value);
            /*0x12f4820*/ int get_sideCount();
            /*0x12f4900*/ void set_sideCount(int value);
            /*0x12f4810*/ float get_sdfRoundness();
            /*0x12f48d0*/ void set_sdfRoundness(float value);
        }

        class LensFlareDataSRP : UnityEngine.ScriptableObject
        {
            /*0x18*/ UnityEngine.Rendering.LensFlareDataElementSRP[] elements;

            /*0x12f4920*/ LensFlareDataSRP();
        }

        interface ICloudBackground
        {
            /*0x17cb40*/ bool IsCloudBackgroundUsable();
        }

        enum ShaderVariantLogLevel
        {
            Disabled = 0,
            OnlySRPShaders = 1,
            AllShaders = 2,
        }

        interface IShaderVariantSettings
        {
            /*0x180980*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
            /*0x17aa40*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
            /*0x17cb40*/ bool get_exportShaderVariants();
            /*0x181190*/ void set_exportShaderVariants(bool value);
        }

        interface IVolumetricCloud
        {
            /*0x17cb40*/ bool IsVolumetricCloudUsable();
        }

        class RenderPipelineResources : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ RenderPipelineResources();
            /*0x388e90*/ string get_packagePath();
            /*0x5699c0*/ string get_packagePath_Internal();
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

            /*0x12ebc60*/ GenerateHLSL(UnityEngine.Rendering.PackingRules rules, bool needAccessors, bool needSetters, bool needParamDebug, int paramDefinesStart, bool omitStructDeclaration, bool containsPackedFields, bool generateCBuffer, int constantRegister, string sourcePath);
        }

        class SurfaceDataAttributes : System.Attribute
        {
            /*0x10*/ string[] displayNames;
            /*0x18*/ bool isDirection;
            /*0x19*/ bool sRGBDisplay;
            /*0x1c*/ UnityEngine.Rendering.FieldPrecision precision;
            /*0x20*/ bool checkIsNormalized;
            /*0x28*/ string preprocessor;

            /*0x13014d0*/ SurfaceDataAttributes(string displayName, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
            /*0x13015b0*/ SurfaceDataAttributes(string[] displayNames, bool isDirection, bool sRGBDisplay, UnityEngine.Rendering.FieldPrecision precision, bool checkIsNormalized, string preprocessor);
        }

        class HLSLArray : System.Attribute
        {
            /*0x10*/ int arraySize;
            /*0x18*/ System.Type elementType;

            /*0x12ebcf0*/ HLSLArray(int arraySize, System.Type elementType);
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

            /*0x12f4950*/ PackingAttribute(string[] displayNames, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
            /*0x12f4a50*/ PackingAttribute(string displayName, UnityEngine.Rendering.FieldPacking packingScheme, int bitSize, int offsetInSource, float minValue, float maxValue, bool isDirection, bool sRGBDisplay, bool checkIsNormalized, string preprocessor);
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

            static /*0x12ec220*/ Hammersley();
            static /*0x12ebe70*/ void Initialize();
            static /*0x12ebd30*/ void BindConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader cs);

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

        class BufferedRTHandleSystem : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.RTHandle[]> m_RTHandles;
            /*0x18*/ UnityEngine.Rendering.RTHandleSystem m_RTHandleSystem;
            /*0x20*/ bool m_DisposedValue;

            /*0x12eb8a0*/ BufferedRTHandleSystem();
            /*0x12eb970*/ int get_maxWidth();
            /*0x12eb950*/ int get_maxHeight();
            /*0x12eb990*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x12eb080*/ UnityEngine.Rendering.RTHandle GetFrameRT(int bufferId, int frameIndex);
            /*0x12ead50*/ void AllocBuffer(int bufferId, System.Func<UnityEngine.Rendering.RTHandleSystem, int, UnityEngine.Rendering.RTHandle> allocator, int bufferCount);
            /*0x12eb390*/ void ReleaseBuffer(int bufferId);
            /*0x12eb4a0*/ void SwapAndSetReferenceSize(int width, int height);
            /*0x12eb470*/ void ResetReferenceSize(int width, int height);
            /*0x12eb130*/ int GetNumFramesAllocated(int bufferId);
            /*0x12eafa0*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
            /*0x12eb500*/ void Swap();
            /*0x12eafe0*/ void Dispose(bool disposing);
            /*0x12eb030*/ void Dispose();
            /*0x12eb1c0*/ void ReleaseAll();
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

            static /*0x12f5730*/ UnityEngine.Vector4 GetPayloadScaleOffset(ref UnityEngine.Vector2 textureSize, ref UnityEngine.Vector2 paddingSize, ref UnityEngine.Vector4 scaleOffset);
            static /*0x12f5570*/ long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            static /*0x12f5640*/ int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x12f6250*/ PowerOfTwoTextureAtlas(int size, int mipPadding, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, string name, bool useMipMap);
            /*0x12f47d0*/ int get_mipPadding();
            /*0x12f5a50*/ int GetTexturePadding();
            /*0x12f5810*/ UnityEngine.Vector4 GetPayloadScaleOffset(UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset);
            /*0x12f4d90*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.PowerOfTwoTextureAtlas.BlitType blitType);
            /*0x12f54a0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x12f53c0*/ void BlitTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x12f52e0*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x12f5200*/ void BlitOctahedralTextureMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x12f6210*/ void TextureSizeToPowerOfTwo(UnityEngine.Texture texture, ref int width, ref int height);
            /*0x12f59d0*/ UnityEngine.Vector2 GetPowerOfTwoTextureSize(UnityEngine.Texture texture);
            /*0x12f4bb0*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x12f61c0*/ void ResetRequestedTexture();
            /*0x12f5f60*/ bool ReserveSpace(UnityEngine.Texture texture);
            /*0x12f6170*/ bool ReserveSpace(UnityEngine.Texture texture, int width, int height);
            /*0x12f6130*/ bool ReserveSpace(UnityEngine.Texture textureA, UnityEngine.Texture textureB, int width, int height);
            /*0x12f6000*/ bool ReserveSpace(int id, int width, int height);
            /*0x12f5a80*/ bool RelayoutEntries();

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

                static /*0x1303130*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1301c60*/ int <RelayoutEntries>b__23_0(System.ValueTuple<int, UnityEngine.Vector2Int> c1, System.ValueTuple<int, UnityEngine.Vector2Int> c2);
            }
        }

        struct RTHandleStaticHelpers
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandle s_RTHandleWrapper;

            static /*0x12fb290*/ void SetRTHandleStaticWrapper(UnityEngine.Rendering.RenderTargetIdentifier rtId);
            static /*0x12fb410*/ void SetRTHandleUserManagedWrapper(ref UnityEngine.Rendering.RTHandle rtWrapper, UnityEngine.Rendering.RenderTargetIdentifier rtId);
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
            /*0x58*/ string m_Name;
            /*0x60*/ bool m_UseCustomHandleScales;
            /*0x64*/ UnityEngine.Rendering.RTHandleProperties m_CustomHandleProperties;
            /*0x94*/ UnityEngine.Vector2 <scaleFactor>k__BackingField;
            /*0xa0*/ UnityEngine.Rendering.ScaleFunc scaleFunc;
            /*0xa8*/ bool <useScaling>k__BackingField;
            /*0xac*/ UnityEngine.Vector2Int <referenceSize>k__BackingField;

            static /*0x12fe990*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x12fe9f0*/ UnityEngine.Texture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            static /*0x12fe9e0*/ UnityEngine.RenderTexture op_Implicit(UnityEngine.Rendering.RTHandle handle);
            /*0x49b490*/ RTHandle(UnityEngine.Rendering.RTHandleSystem owner);
            /*0x12fe650*/ void SetCustomHandleProperties(ref UnityEngine.Rendering.RTHandleProperties properties);
            /*0x12fe2a0*/ void ClearCustomHandleProperties();
            /*0xb69aa0*/ UnityEngine.Vector2 get_scaleFactor();
            /*0xb69c50*/ void set_scaleFactor(UnityEngine.Vector2 value);
            /*0x12fe980*/ bool get_useScaling();
            /*0x12fea80*/ void set_useScaling(bool value);
            /*0x12fe910*/ UnityEngine.Vector2Int get_referenceSize();
            /*0x12fea70*/ void set_referenceSize(UnityEngine.Vector2Int value);
            /*0x12fe920*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x32f410*/ UnityEngine.RenderTexture get_rt();
            /*0x12fe8f0*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
            /*0xb61940*/ string get_name();
            /*0x9ef740*/ bool get_isMSAAEnabled();
            /*0x12fe670*/ void SetRenderTexture(UnityEngine.RenderTexture rt);
            /*0x12fe750*/ void SetTexture(UnityEngine.Texture tex);
            /*0x12fe6f0*/ void SetTexture(UnityEngine.Rendering.RenderTargetIdentifier tex);
            /*0x12fe360*/ int GetInstanceID();
            /*0x12fe560*/ void Release();
            /*0x12fe4d0*/ UnityEngine.Vector2Int GetScaledSize(UnityEngine.Vector2Int refSize);
            /*0x12fe420*/ UnityEngine.Vector2Int GetScaledSize();
            /*0x12fe840*/ void SwitchToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags, bool copyContents);
            /*0x12fe2b0*/ void CopyToFastMemory(UnityEngine.Rendering.CommandBuffer cmd, float residencyFraction, UnityEngine.Rendering.FastMemoryFlags flags);
            /*0x12fe7d0*/ void SwitchOutFastMemory(UnityEngine.Rendering.CommandBuffer cmd, bool copyContents);
        }

        class RTHandles
        {
            static /*0x0*/ UnityEngine.Rendering.RTHandleSystem s_DefaultInstance;

            static /*0x13001b0*/ RTHandles();
            static /*0x1300290*/ int get_maxWidth();
            static /*0x1300230*/ int get_maxHeight();
            static /*0x13002f0*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            static /*0x12ff130*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x12ff9f0*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x12fee90*/ UnityEngine.Rendering.RTHandle Alloc(ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x12ff4f0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x12fea90*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x12ff2c0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            static /*0x12ff670*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
            static /*0x12fed30*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture tex);
            static /*0x12ffb90*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture tex);
            static /*0x12ff430*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex);
            static /*0x12ff950*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier tex, string name);
            static /*0x12ff8f0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            static /*0x12ffd20*/ void Initialize(int width, int height);
            static /*0x12ffda0*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            static /*0x12ffe40*/ void Release(UnityEngine.Rendering.RTHandle rth);
            static /*0x12fff40*/ void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
            static /*0x1300130*/ void SetReferenceSize(int width, int height);
            static /*0x12ffeb0*/ void ResetReferenceSize(int width, int height);
            static /*0x12ffc90*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        }

        class ScaleFunc : System.MulticastDelegate
        {
            /*0x9ddba0*/ ScaleFunc(object object, nint method);
            /*0x720980*/ UnityEngine.Vector2Int Invoke(UnityEngine.Vector2Int size);
            /*0x1300370*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2Int size, System.AsyncCallback callback, object object);
            /*0xe61b10*/ UnityEngine.Vector2Int EndInvoke(System.IAsyncResult result);
        }

        struct RTHandleProperties
        {
            /*0x10*/ UnityEngine.Vector2Int previousViewportSize;
            /*0x18*/ UnityEngine.Vector2Int previousRenderTargetSize;
            /*0x20*/ UnityEngine.Vector2Int currentViewportSize;
            /*0x28*/ UnityEngine.Vector2Int currentRenderTargetSize;
            /*0x30*/ UnityEngine.Vector4 rtHandleScale;
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

            static /*0x12fc7e0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RTHandle tex);
            /*0x12fe1c0*/ RTHandleSystem();
            /*0x12fe280*/ UnityEngine.Rendering.RTHandleProperties get_rtHandleProperties();
            /*0x12fd0d0*/ void Dispose();
            /*0x12fd4f0*/ void Initialize(int width, int height);
            /*0x12fd4c0*/ void Initialize(int width, int height, bool useLegacyDynamicResControl);
            /*0x12fd770*/ void Release(UnityEngine.Rendering.RTHandle rth);
            /*0x12fd870*/ void Remove(UnityEngine.Rendering.RTHandle rth);
            /*0x12fd8d0*/ void ResetReferenceSize(int width, int height);
            /*0x12fe0a0*/ void SetReferenceSize(int width, int height);
            /*0x12fdea0*/ void SetReferenceSize(int width, int height, bool reset);
            /*0x12fca00*/ UnityEngine.Vector2 CalculateRatioAgainstMaxSize(ref UnityEngine.Vector2Int viewportSize);
            /*0x12fdcf0*/ void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
            /*0x12fe0c0*/ void SwitchResizeMode(UnityEngine.Rendering.RTHandle rth, UnityEngine.Rendering.RTHandleSystem.ResizeMode mode);
            /*0x12fcc30*/ void DemandResize(UnityEngine.Rendering.RTHandle rth);
            /*0xf91dd0*/ int GetMaxWidth();
            /*0x12fd4b0*/ int GetMaxHeight();
            /*0x12fcee0*/ void Dispose(bool disposing);
            /*0x12fd900*/ void Resize(int width, int height, bool sizeChanged);
            /*0x12fc6e0*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x12fbcf0*/ UnityEngine.Rendering.RTHandle Alloc(int width, int height, UnityEngine.TextureWrapMode wrapModeU, UnityEngine.TextureWrapMode wrapModeV, UnityEngine.TextureWrapMode wrapModeW, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x12fc840*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Vector2 scaleFactor, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x12fc510*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.ScaleFunc scaleFunc, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x12fb630*/ UnityEngine.Rendering.RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, UnityEngine.Rendering.DepthBits depthBufferBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, UnityEngine.Rendering.TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, UnityEngine.Rendering.MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, UnityEngine.RenderTextureMemoryless memoryless, UnityEngine.VRTextureUsage vrUsage, string name);
            /*0x12fbc30*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.RenderTexture texture);
            /*0x12fc320*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Texture texture);
            /*0x12fc2b0*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture);
            /*0x12fc430*/ UnityEngine.Rendering.RTHandle Alloc(UnityEngine.Rendering.RenderTargetIdentifier texture, string name);
            /*0x12fd0e0*/ string DumpRTInfo();

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

            /*0x13049f0*/ AtlasAllocator(int width, int height, bool potPadding);
            /*0x1304910*/ bool Allocate(ref UnityEngine.Vector4 result, int width, int height);
            /*0x1304990*/ void Reset();

            class AtlasNode
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_RightChild;
                /*0x18*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode m_BottomChild;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x1305ae0*/ AtlasNode();
                /*0x1304ee0*/ UnityEngine.Rendering.AtlasAllocator.AtlasNode Allocate(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding);
                /*0x13059e0*/ void Release(ref UnityEngine.Rendering.ObjectPool<UnityEngine.Rendering.AtlasAllocator.AtlasNode> pool);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.AtlasAllocator.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Rendering.AtlasAllocator.AtlasNode> <>9__6_1;

                static /*0x131c960*/ <>c();
                /*0x32f970*/ <>c();
                /*0x32d010*/ void <.ctor>b__6_0(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
                /*0x32d010*/ void <.ctor>b__6_1(UnityEngine.Rendering.AtlasAllocator.AtlasNode _);
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

            static /*0x131ab90*/ Texture2DAtlas();
            static /*0x131aed0*/ int get_maxMipLevelPadding();
            /*0x131abf0*/ Texture2DAtlas(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.FilterMode filterMode, bool powerOfTwoPadding, string name, bool useMipMap);
            /*0x73d3e0*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x131a700*/ void Release();
            /*0x131a810*/ void ResetAllocator();
            /*0x13194f0*/ void ClearTarget(UnityEngine.Rendering.CommandBuffer cmd);
            /*0x1319a10*/ int GetTextureMipmapCount(int width, int height);
            /*0x1319ae0*/ bool Is2D(UnityEngine.Texture texture);
            /*0x1319cd0*/ bool IsSingleChannelBlit(UnityEngine.Texture source, UnityEngine.Texture destination);
            /*0x1318eb0*/ void Blit2DTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, UnityEngine.Rendering.Texture2DAtlas.BlitType blitType);
            /*0x1319fc0*/ void MarkGPUTextureValid(int instanceId, bool mipAreValid);
            /*0x1319f60*/ void MarkGPUTextureInvalid(int instanceId);
            /*0x1319360*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x13192f0*/ void BlitOctahedralTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, UnityEngine.Vector4 sourceScaleOffset, bool blitMips, int overrideInstanceID);
            /*0x1319150*/ void BlitCubeTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, bool blitMips, int overrideInstanceID);
            /*0x1318c80*/ bool AllocateTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture, int width, int height, int overrideInstanceID);
            /*0x1318c10*/ bool AllocateTextureWithoutBlit(UnityEngine.Texture texture, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x13189f0*/ bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref UnityEngine.Vector4 scaleOffset);
            /*0x1319930*/ int GetTextureHash(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x13199f0*/ int GetTextureID(UnityEngine.Texture texture);
            /*0x13199a0*/ int GetTextureID(UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x1319ba0*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture textureA, UnityEngine.Texture textureB);
            /*0x1319c90*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x1319c10*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int id);
            /*0x13198c0*/ UnityEngine.Vector2Int GetCachedTextureSize(int id);
            /*0x131a4b0*/ bool NeedsUpdate(UnityEngine.Texture texture, bool needMips);
            /*0x131a030*/ bool NeedsUpdate(UnityEngine.Texture textureA, UnityEngine.Texture textureB, bool needMips);
            /*0x1318910*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x131a8d0*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture oldTexture, UnityEngine.Texture newTexture, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Vector4 sourceScaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x131aac0*/ bool UpdateTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, ref UnityEngine.Vector4 scaleOffset, bool updateIfNeeded, bool blitMips);
            /*0x13196c0*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleBias, int key, int width, int height);

            enum BlitType
            {
                Default = 0,
                CubeTo2DOctahedral = 1,
                SingleChannel = 2,
                CubeTo2DOctahedralSingleChannel = 3,
            }
        }

        class AtlasAllocatorDynamic
        {
            /*0x10*/ int m_Width;
            /*0x14*/ int m_Height;
            /*0x18*/ UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool m_Pool;
            /*0x20*/ short m_Root;
            /*0x28*/ System.Collections.Generic.Dictionary<int, short> m_NodeFromID;

            /*0x1304770*/ AtlasAllocatorDynamic(int width, int height, int capacityAllocations);
            /*0x1303f40*/ bool Allocate(ref UnityEngine.Vector4 result, int key, int width, int height);
            /*0x13045e0*/ void Release(int key);
            /*0x13046a0*/ void Release();
            /*0x1304570*/ string DebugStringFromRoot(int depthMax);
            /*0x1304070*/ void DebugStringFromNode(ref string res, short n, int depthCurrent, int depthMax);

            class AtlasNodePool
            {
                /*0x10*/ UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNode[] m_Nodes;
                /*0x18*/ short m_Next;
                /*0x1a*/ short m_FreelistHead;

                /*0x1304e70*/ AtlasNodePool(short capacity);
                /*0x1304e50*/ void Dispose();
                /*0x1304e40*/ void Clear();
                /*0x1304c80*/ short AtlasNodeCreate(short parent);
                /*0x1304e00*/ void AtlasNodeFree(short index);
            }

            struct AtlasNode
            {
                /*0x10*/ short m_Self;
                /*0x12*/ short m_Parent;
                /*0x14*/ short m_LeftChild;
                /*0x16*/ short m_RightChild;
                /*0x18*/ short m_FreelistNext;
                /*0x1a*/ ushort m_Flags;
                /*0x20*/ UnityEngine.Vector4 m_Rect;

                /*0x1305af0*/ AtlasNode(short self, short parent);
                /*0x13057b0*/ bool IsOccupied();
                /*0x1305ad0*/ void SetIsOccupied();
                /*0x1305700*/ void ClearIsOccupied();
                /*0x1305710*/ bool IsLeafNode();
                /*0x1305230*/ short Allocate(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool, int width, int height);
                /*0x13058f0*/ void ReleaseChildren(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);
                /*0x13057c0*/ void ReleaseAndMerge(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);
                /*0x1305720*/ bool IsMergeNeeded(UnityEngine.Rendering.AtlasAllocatorDynamic.AtlasNodePool pool);

                enum AtlasNodeFlags
                {
                    IsOccupied = 1,
                }
            }
        }

        class Texture2DAtlasDynamic
        {
            /*0x10*/ UnityEngine.Rendering.RTHandle m_AtlasTexture;
            /*0x18*/ bool isAtlasTextureOwner;
            /*0x1c*/ int m_Width;
            /*0x20*/ int m_Height;
            /*0x24*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;
            /*0x28*/ UnityEngine.Rendering.AtlasAllocatorDynamic m_AtlasAllocator;
            /*0x30*/ System.Collections.Generic.Dictionary<int, UnityEngine.Vector4> m_AllocationCache;

            /*0x1318740*/ Texture2DAtlasDynamic(int width, int height, int capacity, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x1318610*/ Texture2DAtlasDynamic(int width, int height, int capacity, UnityEngine.Rendering.RTHandle atlasTexture);
            /*0x73d3e0*/ UnityEngine.Rendering.RTHandle get_AtlasTexture();
            /*0x1318380*/ void Release();
            /*0x13184f0*/ void ResetAllocator();
            /*0x1317db0*/ bool AddTexture(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Vector4 scaleOffset, UnityEngine.Texture texture);
            /*0x13181f0*/ bool IsCached(ref UnityEngine.Vector4 scaleOffset, int key);
            /*0x1318090*/ bool EnsureTextureSlot(ref bool isUploadNeeded, ref UnityEngine.Vector4 scaleOffset, int key, int width, int height);
            /*0x1318260*/ void ReleaseTextureSlot(int key);
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

            static /*0x131c730*/ TextureXR();
            static /*0x131c890*/ void set_maxViews(int value);
            static /*0x131c7f0*/ int get_slices();
            static /*0x131c840*/ bool get_useTexArray();
            static /*0x131c770*/ UnityEngine.Rendering.TextureDimension get_dimension();
            static /*0x131b800*/ UnityEngine.Rendering.RTHandle GetBlackUIntTexture();
            static /*0x131b8c0*/ UnityEngine.Rendering.RTHandle GetClearTexture();
            static /*0x131b980*/ UnityEngine.Rendering.RTHandle GetMagentaTexture();
            static /*0x131b730*/ UnityEngine.Rendering.RTHandle GetBlackTexture();
            static /*0x131b6d0*/ UnityEngine.Rendering.RTHandle GetBlackTextureArray();
            static /*0x131b670*/ UnityEngine.Rendering.RTHandle GetBlackTexture3D();
            static /*0x131ba40*/ UnityEngine.Rendering.RTHandle GetWhiteTexture();
            static /*0x131bb10*/ void Initialize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x131b450*/ UnityEngine.Texture2DArray CreateTexture2DArrayFromTexture2D(UnityEngine.Texture2D source, string name);
            static /*0x131aff0*/ UnityEngine.Texture CreateBlackUIntTextureArray(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x131b270*/ UnityEngine.Texture CreateBlackUintTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.ComputeShader clearR32_UIntShader);
            static /*0x131af20*/ UnityEngine.Texture3D CreateBlackTexture3D(string name);
        }

        class ArrayExtensions
        {
            static /*0x1827f0*/ void ResizeArray<T>(ref Unity.Collections.NativeArray<T> array, int capacity);
            static /*0x1303eb0*/ void ResizeArray(ref UnityEngine.Jobs.TransformAccessArray array, int capacity);
            static /*0x1827f0*/ void ResizeArray<T>(ref T[] array, int capacity);
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

            static /*0x1317270*/ UnityEngine.Vector4 GetSHA(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x1317350*/ UnityEngine.Vector4 GetSHB(UnityEngine.Rendering.SphericalHarmonicsL2 sh, int i);
            static /*0x1317410*/ UnityEngine.Vector4 GetSHC(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            static /*0x1317b90*/ bool op_Equality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            static /*0x1317bf0*/ bool op_Inequality(UnityEngine.Rendering.SHCoefficients left, UnityEngine.Rendering.SHCoefficients right);
            /*0x1317520*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh);
            /*0x13174a0*/ SHCoefficients(UnityEngine.Rendering.SphericalHarmonicsL2 sh, UnityEngine.Vector4 probesOcclusion);
            /*0x1316ce0*/ bool Equals(UnityEngine.Rendering.SHCoefficients other);
            /*0x1317000*/ bool Equals(object obj);
            /*0x1317100*/ int GetHashCode();
        }

        struct BatchRendererGroupGlobals : System.IEquatable<UnityEngine.Rendering.BatchRendererGroupGlobals>
        {
            static string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
            static /*0x0*/ int kGlobalsPropertyId;
            /*0x10*/ UnityEngine.Vector4 ProbesOcclusion;
            /*0x20*/ UnityEngine.Vector4 SpecCube0_HDR;
            /*0x30*/ UnityEngine.Vector4 SpecCube1_HDR;
            /*0x40*/ UnityEngine.Rendering.SHCoefficients SHCoefficients;

            static /*0x1306160*/ BatchRendererGroupGlobals();
            static /*0x13061b0*/ UnityEngine.Rendering.BatchRendererGroupGlobals get_Default();
            static /*0x13063b0*/ bool op_Equality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            static /*0x1306490*/ bool op_Inequality(UnityEngine.Rendering.BatchRendererGroupGlobals left, UnityEngine.Rendering.BatchRendererGroupGlobals right);
            /*0x1305cf0*/ bool Equals(UnityEngine.Rendering.BatchRendererGroupGlobals other);
            /*0x1305b50*/ bool Equals(object obj);
            /*0x1305fd0*/ int GetHashCode();
        }

        interface IBitArray
        {
            /*0x180980*/ uint get_capacity();
            /*0x17cb40*/ bool get_allFalse();
            /*0x17cb40*/ bool get_allTrue();
            bool get_Item(uint index);
            /*0x2a5510*/ void set_Item(uint index, bool value);
            /*0x1803b0*/ string get_humanizedData();
            /*0x1858d0*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1858d0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1803b0*/ UnityEngine.Rendering.IBitArray BitNot();
        }

        struct BitArray8 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ byte data;

            static /*0x1308890*/ UnityEngine.Rendering.BitArray8 op_OnesComplement(UnityEngine.Rendering.BitArray8 a);
            static /*0x1308860*/ UnityEngine.Rendering.BitArray8 op_BitwiseOr(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x1308850*/ UnityEngine.Rendering.BitArray8 op_BitwiseAnd(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x1308870*/ bool op_Equality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            static /*0x1308880*/ bool op_Inequality(UnityEngine.Rendering.BitArray8 a, UnityEngine.Rendering.BitArray8 b);
            /*0xd340f0*/ BitArray8(byte initValue);
            /*0x13086a0*/ BitArray8(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x6bbae0*/ uint get_capacity();
            /*0xe04730*/ bool get_allFalse();
            /*0x1308760*/ bool get_allTrue();
            /*0x1308770*/ string get_humanizedData();
            /*0x1308740*/ bool get_Item(uint index);
            /*0x13088a0*/ void set_Item(uint index, bool value);
            /*0x1308490*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1308570*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1308520*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x13085f0*/ bool Equals(object obj);
            /*0x1308680*/ int GetHashCode();
        }

        struct BitArray16 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ushort data;

            static /*0x1307040*/ UnityEngine.Rendering.BitArray16 op_OnesComplement(UnityEngine.Rendering.BitArray16 a);
            static /*0x1307030*/ UnityEngine.Rendering.BitArray16 op_BitwiseOr(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x1307020*/ UnityEngine.Rendering.BitArray16 op_BitwiseAnd(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x125ae10*/ bool op_Equality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            static /*0x125aef0*/ bool op_Inequality(UnityEngine.Rendering.BitArray16 a, UnityEngine.Rendering.BitArray16 b);
            /*0x9a9130*/ BitArray16(ushort initValue);
            /*0x1306e10*/ BitArray16(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x6bbaf0*/ uint get_capacity();
            /*0x1160f50*/ bool get_allFalse();
            /*0x1306ed0*/ bool get_allTrue();
            /*0x1306ee0*/ string get_humanizedData();
            /*0x1306eb0*/ bool get_Item(uint index);
            /*0x1307050*/ void set_Item(uint index, bool value);
            /*0x1306c00*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1306ce0*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1306c90*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x1306d60*/ bool Equals(object obj);
            /*0x1306df0*/ int GetHashCode();
        }

        struct BitArray32 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ uint data;

            static /*0x1307ff0*/ UnityEngine.Rendering.BitArray32 op_OnesComplement(UnityEngine.Rendering.BitArray32 a);
            static /*0x1307fd0*/ UnityEngine.Rendering.BitArray32 op_BitwiseOr(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0xfc56e0*/ UnityEngine.Rendering.BitArray32 op_BitwiseAnd(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x6d51d0*/ bool op_Equality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            static /*0x1307fe0*/ bool op_Inequality(UnityEngine.Rendering.BitArray32 a, UnityEngine.Rendering.BitArray32 b);
            /*0x6bbd40*/ BitArray32(uint initValue);
            /*0x1307d60*/ BitArray32(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x6d5de0*/ uint get_capacity();
            /*0x1142940*/ bool get_allFalse();
            /*0x1307e20*/ bool get_allTrue();
            /*0x1307f70*/ string get_humanizedVersion();
            /*0x1307e30*/ string get_humanizedData();
            /*0x1307e00*/ bool get_Item(uint index);
            /*0x1308000*/ void set_Item(uint index, bool value);
            /*0x1307b70*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1307c40*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1307bf0*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x1307cc0*/ bool Equals(object obj);
            /*0x1307d40*/ int GetHashCode();
        }

        struct BitArray64 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data;

            static /*0x1308460*/ UnityEngine.Rendering.BitArray64 op_OnesComplement(UnityEngine.Rendering.BitArray64 a);
            static /*0x1308450*/ UnityEngine.Rendering.BitArray64 op_BitwiseOr(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x1308440*/ UnityEngine.Rendering.BitArray64 op_BitwiseAnd(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0x6bb8b0*/ bool op_Equality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            static /*0xf789c0*/ bool op_Inequality(UnityEngine.Rendering.BitArray64 a, UnityEngine.Rendering.BitArray64 b);
            /*0x9e29e0*/ BitArray64(ulong initValue);
            /*0x1308230*/ BitArray64(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x3a0a50*/ uint get_capacity();
            /*0xe832e0*/ bool get_allFalse();
            /*0x13082f0*/ bool get_allTrue();
            /*0x1308300*/ string get_humanizedData();
            /*0x13082d0*/ bool get_Item(uint index);
            /*0x1308470*/ void set_Item(uint index, bool value);
            /*0x1308020*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1308100*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x13080b0*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x1308180*/ bool Equals(object obj);
            /*0x1308210*/ int GetHashCode();
        }

        struct BitArray128 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;

            static /*0x1306ba0*/ UnityEngine.Rendering.BitArray128 op_OnesComplement(UnityEngine.Rendering.BitArray128 a);
            static /*0x1155b70*/ UnityEngine.Rendering.BitArray128 op_BitwiseOr(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x1153db0*/ UnityEngine.Rendering.BitArray128 op_BitwiseAnd(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x1306b60*/ bool op_Equality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            static /*0x1306b80*/ bool op_Inequality(UnityEngine.Rendering.BitArray128 a, UnityEngine.Rendering.BitArray128 b);
            /*0xbee490*/ BitArray128(ulong initValue1, ulong initValue2);
            /*0x1306850*/ BitArray128(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x6d5e20*/ uint get_capacity();
            /*0x1306940*/ bool get_allFalse();
            /*0x1306960*/ bool get_allTrue();
            /*0x1306980*/ string get_humanizedData();
            /*0x1306910*/ bool get_Item(uint index);
            /*0x1306bc0*/ void set_Item(uint index, bool value);
            /*0x1306570*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1306690*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1306630*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x1306750*/ bool Equals(object obj);
            /*0x1306810*/ int GetHashCode();
        }

        struct BitArray256 : UnityEngine.Rendering.IBitArray
        {
            /*0x10*/ ulong data1;
            /*0x18*/ ulong data2;
            /*0x20*/ ulong data3;
            /*0x28*/ ulong data4;

            static /*0x1307ab0*/ UnityEngine.Rendering.BitArray256 op_OnesComplement(UnityEngine.Rendering.BitArray256 a);
            static /*0x13079f0*/ UnityEngine.Rendering.BitArray256 op_BitwiseOr(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x13079b0*/ UnityEngine.Rendering.BitArray256 op_BitwiseAnd(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x1307a30*/ bool op_Equality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            static /*0x1307a70*/ bool op_Inequality(UnityEngine.Rendering.BitArray256 a, UnityEngine.Rendering.BitArray256 b);
            /*0x11536f0*/ BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4);
            /*0x1307510*/ BitArray256(System.Collections.Generic.IEnumerable<uint> bitIndexTrue);
            /*0x6d5f00*/ uint get_capacity();
            /*0x1307660*/ bool get_allFalse();
            /*0x1307680*/ bool get_allTrue();
            /*0x13076a0*/ string get_humanizedData();
            /*0x1307610*/ bool get_Item(uint index);
            /*0x1307ae0*/ void set_Item(uint index, bool value);
            /*0x1307070*/ UnityEngine.Rendering.IBitArray BitAnd(UnityEngine.Rendering.IBitArray other);
            /*0x1307230*/ UnityEngine.Rendering.IBitArray BitOr(UnityEngine.Rendering.IBitArray other);
            /*0x1307190*/ UnityEngine.Rendering.IBitArray BitNot();
            /*0x1307350*/ bool Equals(object obj);
            /*0x1307490*/ int GetHashCode();
        }

        class BitArrayUtilities
        {
            static /*0x1308960*/ bool Get8(uint index, byte data);
            static /*0x13088e0*/ bool Get16(uint index, ushort data);
            static /*0x1308940*/ bool Get32(uint index, uint data);
            static /*0x1308950*/ bool Get64(uint index, ulong data);
            static /*0x13088c0*/ bool Get128(uint index, ulong data1, ulong data2);
            static /*0x1308900*/ bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4);
            static /*0x1308a90*/ void Set8(uint index, ref byte data, bool value);
            static /*0x13089c0*/ void Set16(uint index, ref ushort data, bool value);
            static /*0x1308a50*/ void Set32(uint index, ref uint data, bool value);
            static /*0x1308a70*/ void Set64(uint index, ref ulong data, bool value);
            static /*0x1308980*/ void Set128(uint index, ref ulong data1, ref ulong data2, bool value);
            static /*0x13089e0*/ void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value);
        }

        class Blitter
        {
            static /*0x0*/ UnityEngine.Material s_Blit;
            static /*0x8*/ UnityEngine.Material s_BlitTexArray;
            static /*0x10*/ UnityEngine.Material s_BlitTexArraySingleSlice;
            static /*0x18*/ UnityEngine.Material s_BlitColorAndDepth;
            static /*0x20*/ UnityEngine.MaterialPropertyBlock s_PropertyBlock;
            static /*0x28*/ UnityEngine.Mesh s_TriangleMesh;
            static /*0x30*/ UnityEngine.Mesh s_QuadMesh;
            static /*0x38*/ UnityEngine.Rendering.LocalKeyword s_DecodeHdrKeyword;

            static /*0x130d5f0*/ Blitter();
            static /*0x130c910*/ void Initialize(UnityEngine.Shader blitPS, UnityEngine.Shader blitColorAndDepthPS);
            static /*0x130c1d0*/ void Cleanup();
            static /*0x130c840*/ UnityEngine.Material GetBlitMaterial(UnityEngine.Rendering.TextureDimension dimension, bool singleSlice);
            static /*0x130c610*/ void DrawTriangle(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x130c3d0*/ void DrawQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material material, int shaderPass);
            static /*0x130bfc0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x130b6d0*/ void BlitTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x13098d0*/ void BlitColorAndDepth(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture sourceColor, UnityEngine.RenderTexture sourceDepth, UnityEngine.Vector4 scaleBias, float mipLevel, bool blitDepth);
            static /*0x130ba30*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x130bb70*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x130b840*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int pass);
            static /*0x130bcd0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x130bed0*/ void BlitTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 scaleBias, UnityEngine.Material material, int pass);
            static /*0x1308f10*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x1308c60*/ void BlitCameraTexture2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, float mipLevel, bool bilinear);
            static /*0x1309710*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int pass);
            static /*0x13093a0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int pass);
            static /*0x13092b0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Vector4 scaleBias, float mipLevel, bool bilinear);
            static /*0x13090d0*/ void BlitCameraTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect destViewport, float mipLevel, bool bilinear);
            static /*0x130b480*/ void BlitQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear);
            static /*0x130b0c0*/ void BlitQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x130ad00*/ void BlitQuadWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x130a720*/ void BlitOctahedralWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x130a440*/ void BlitOctahedralWithPaddingMultiply(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels);
            static /*0x130a200*/ void BlitCubeToOctahedral2DQuad(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x1309df0*/ void BlitCubeToOctahedral2DQuadWithPadding(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector2 textureSize, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, System.Nullable<UnityEngine.Vector4> decodeInstructions);
            static /*0x1309af0*/ void BlitCubeToOctahedral2DQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x130aa00*/ void BlitQuadSingleChannel(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture source, UnityEngine.Vector4 scaleBiasTex, UnityEngine.Vector4 scaleBiasRT, int mipLevelTex);
            static /*0x130d370*/ UnityEngine.Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|9_0(float z);
            static /*0x130d260*/ UnityEngine.Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|9_1();
            static /*0x130d530*/ UnityEngine.Vector3[] <Initialize>g__GetQuadVertexPosition|9_2(float z);
            static /*0x130d440*/ UnityEngine.Vector2[] <Initialize>g__GetQuadTexCoord|9_3();

            class BlitShaderIDs
            {
                static /*0x0*/ int _BlitTexture;
                static /*0x4*/ int _BlitCubeTexture;
                static /*0x8*/ int _BlitScaleBias;
                static /*0xc*/ int _BlitScaleBiasRt;
                static /*0x10*/ int _BlitMipLevel;
                static /*0x14*/ int _BlitTextureSize;
                static /*0x18*/ int _BlitPaddingSize;
                static /*0x1c*/ int _BlitDecodeInstructions;
                static /*0x20*/ int _InputDepth;

                static /*0x1308ab0*/ BlitShaderIDs();
            }
        }

        class CameraCaptureBridge
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, System.Collections.Generic.HashSet<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>>> actionDict;
            static /*0x8*/ bool _enabled;

            static /*0x130d9c0*/ CameraCaptureBridge();
            static /*0x130da50*/ bool get_enabled();
            static /*0x130daa0*/ void set_enabled(bool value);
            static /*0x130d7d0*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> GetCaptureActions(UnityEngine.Camera camera);
            static /*0x130d670*/ void AddCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
            static /*0x130d8d0*/ void RemoveCaptureAction(UnityEngine.Camera camera, System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer> action);
        }

        class ColorSpaceUtils
        {
            static /*0x0*/ UnityEngine.Matrix4x4 Rec709ToRec2020Mat;
            static /*0x40*/ UnityEngine.Matrix4x4 Rec709ToP3D65Mat;
            static /*0x80*/ UnityEngine.Matrix4x4 Rec2020ToRec709Mat;
            static /*0xc0*/ UnityEngine.Matrix4x4 Rec2020ToP3D65Mat;
            static /*0x100*/ UnityEngine.Matrix4x4 P3D65ToRec2020Mat;

            static /*0x130db00*/ ColorSpaceUtils();
        }

        class ColorUtils
        {
            static /*0x0*/ float s_LightMeterCalibrationConstant;
            static /*0x4*/ float s_LensAttenuation;

            static /*0x130ec10*/ ColorUtils();
            static /*0x130ec60*/ float get_lensImperfectionExposureScale();
            static /*0x130eae0*/ float StandardIlluminantY(float x);
            static /*0x130de60*/ UnityEngine.Vector3 CIExyToLMS(float x, float y);
            static /*0x130def0*/ UnityEngine.Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint);
            static /*0x130e750*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareShadowsMidtonesHighlights(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inMidtones, ref UnityEngine.Vector4 inHighlights);
            static /*0x130e3f0*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4, UnityEngine.Vector4> PrepareLiftGammaGain(ref UnityEngine.Vector4 inLift, ref UnityEngine.Vector4 inGamma, ref UnityEngine.Vector4 inGain);
            static /*0x130ea00*/ System.ValueTuple<UnityEngine.Vector4, UnityEngine.Vector4> PrepareSplitToning(ref UnityEngine.Vector4 inShadows, ref UnityEngine.Vector4 inHighlights, float balance);
            static /*0x130e3c0*/ float Luminance(ref UnityEngine.Color color);
            static /*0x130e120*/ float ComputeEV100(float aperture, float shutterSpeed, float ISO);
            static /*0x130e1f0*/ float ConvertEV100ToExposure(float EV100);
            static /*0x130e2c0*/ float ConvertExposureToEV100(float exposure);
            static /*0x130e070*/ float ComputeEV100FromAvgLuminance(float avgLuminance);
            static /*0x130e1a0*/ float ComputeISO(float aperture, float shutterSpeed, float targetEV100);
            static /*0x130eb10*/ uint ToHex(UnityEngine.Color c);
            static /*0x130eb90*/ UnityEngine.Color ToRGBA(uint hex);
        }

        class CoreMatrixUtils
        {
            static /*0x130ecd0*/ void MatrixTimesTranslation(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x130f830*/ void TranslationTimesMatrix(ref UnityEngine.Matrix4x4 inOutMatrix, UnityEngine.Vector3 translation);
            static /*0x130f340*/ UnityEngine.Matrix4x4 MultiplyPerspectiveMatrix(UnityEngine.Matrix4x4 perspective, UnityEngine.Matrix4x4 rhs);
            static /*0x130ef10*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrixCentered(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x130ed60*/ UnityEngine.Matrix4x4 MultiplyGenericOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs);
            static /*0x130f050*/ UnityEngine.Matrix4x4 MultiplyOrthoMatrix(UnityEngine.Matrix4x4 ortho, UnityEngine.Matrix4x4 rhs, bool centered);
            static /*0x130f490*/ UnityEngine.Matrix4x4 MultiplyProjectionMatrix(UnityEngine.Matrix4x4 projMatrix, UnityEngine.Matrix4x4 rhs, bool orthoCentered);
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
            static /*0x38*/ UnityEngine.Texture3D m_BlackVolumeTexture;
            static /*0x40*/ System.Collections.Generic.IEnumerable<System.Type> m_AssemblyTypes;

            static /*0x1314a90*/ CoreUtils();
            static /*0x1314cc0*/ UnityEngine.Cubemap get_blackCubeTexture();
            static /*0x1315430*/ UnityEngine.Cubemap get_magentaCubeTexture();
            static /*0x1315200*/ UnityEngine.CubemapArray get_magentaCubeTextureArray();
            static /*0x1315620*/ UnityEngine.Cubemap get_whiteCubeTexture();
            static /*0x1315080*/ UnityEngine.RenderTexture get_emptyUAV();
            static /*0x1314eb0*/ UnityEngine.Texture3D get_blackVolumeTexture();
            static /*0x130fb90*/ void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x1310ab0*/ int FixupDepthSlice(int depthSlice, UnityEngine.Rendering.RTHandle buffer);
            static /*0x1310aa0*/ int FixupDepthSlice(int depthSlice, UnityEngine.CubemapFace cubemapFace);
            static /*0x1312680*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312900*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x13144a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312790*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1313a00*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x13125a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer);
            static /*0x1312480*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x1313b50*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x13145d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x1312b30*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1311ed0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x13140a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x1314360*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x1311d20*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1313c50*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312a30*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier buffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x1313050*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x13148d0*/ void SetViewportAndClear(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x1313ec0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x13146c0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312e80*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1311b40*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x13131c0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312210*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle buffer, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1313590*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorBuffer, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x1312070*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer);
            static /*0x1312c40*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag);
            static /*0x13141b0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RTHandle depthBuffer, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
            static /*0x13149f0*/ void SetViewport(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle target);
            static /*0x1311140*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.RenderTextureFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x1311050*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples);
            static /*0x1310d20*/ string GetRenderTargetAutoName(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes);
            static /*0x1310e20*/ string GetRenderTargetAutoName(int width, int height, int depth, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, bool enableMSAA, UnityEngine.Rendering.MSAASamples msaaSamples, bool dynamicRes);
            static /*0x1311310*/ string GetTextureAutoName(int width, int height, UnityEngine.TextureFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x1311230*/ string GetTextureAutoName(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x13113f0*/ string GetTextureAutoName(int width, int height, string format, UnityEngine.Rendering.TextureDimension dim, string name, bool mips, int depth);
            static /*0x130f920*/ void ClearCubemap(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips);
            static /*0x13106a0*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x1310770*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x1310880*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier colorBuffer, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x13103e0*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.Rendering.RenderTargetIdentifier depthStencilBuffer, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x1310500*/ void DrawFullScreen(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Material material, UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers, UnityEngine.MaterialPropertyBlock properties, int shaderPassId);
            static /*0x130fc70*/ UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color);
            static /*0x130fbd0*/ UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color);
            static /*0x1310150*/ UnityEngine.Material CreateEngineMaterial(string shaderPath);
            static /*0x1310270*/ UnityEngine.Material CreateEngineMaterial(UnityEngine.Shader shader);
            static /*0x2a5510*/ bool HasFlag<T>(T mask, T flag);
            static /*0x177670*/ void Swap<T>(ref T a, ref T b);
            static /*0x1311b10*/ void SetKeyword(UnityEngine.Rendering.CommandBuffer cmd, string keyword, bool state);
            static /*0x1311ab0*/ void SetKeyword(UnityEngine.Material material, string keyword, bool state);
            static /*0x1311ae0*/ void SetKeyword(UnityEngine.ComputeShader cs, string keyword, bool state);
            static /*0x1310360*/ void Destroy(UnityEngine.Object obj);
            static /*0x1310b00*/ System.Collections.Generic.IEnumerable<System.Type> GetAllAssemblyTypes();
            static /*0x180cf0*/ System.Collections.Generic.IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
            static /*0x1311aa0*/ void SafeRelease(UnityEngine.GraphicsBuffer buffer);
            static /*0x1311a90*/ void SafeRelease(UnityEngine.ComputeBuffer buffer);
            static /*0x130fd10*/ UnityEngine.Mesh CreateCubeMesh(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x3ce290*/ bool ArePostProcessesEnabled(UnityEngine.Camera camera);
            static /*0x3ce290*/ bool AreAnimatedMaterialsEnabled(UnityEngine.Camera camera);
            static /*0x348b00*/ bool IsSceneLightingDisabled(UnityEngine.Camera camera);
            static /*0x348b00*/ bool IsLightOverlapDebugEnabled(UnityEngine.Camera camera);
            static /*0x3ce290*/ bool IsSceneViewFogEnabled(UnityEngine.Camera camera);
            static /*0x348b00*/ bool IsSceneFilteringEnabled();
            static /*0x348b00*/ bool IsSceneViewPrefabStageContextHidden();
            static /*0x13109c0*/ void DrawRendererList(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList);
            static /*0x13118e0*/ int GetTextureHash(UnityEngine.Texture texture);
            static /*0x1311a60*/ int PreviousPowerOfTwo(int size);
            static /*0x2a5510*/ T GetLastEnumValue<T>();
            static /*0x1310cf0*/ string GetCorePath();

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
                static /*0x8*/ System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__87_0;

                static /*0x131c9d0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x131c8f0*/ System.Collections.Generic.IEnumerable<System.Type> <GetAllAssemblyTypes>b__87_0(System.Reflection.Assembly t);
            }

            class <>c__88<T>
            {
                static /*0x0*/ UnityEngine.Rendering.CoreUtils.<>c__88<T> <>9;
                static /*0x0*/ System.Func<System.Type, bool> <>9__88_0;

                static /*0x180ff0*/ <>c__88();
                /*0x180fc0*/ <>c__88();
                /*0x17e620*/ bool <GetAllTypesDerivedFrom>b__88_0(System.Type t);
            }
        }

        class DelegateUtility
        {
            static /*0x1315810*/ System.Delegate Cast(System.Delegate source, System.Type type);
        }

        class FSRUtils
        {
            static float kMaxSharpnessStops = 2.5;
            static float kDefaultSharpnessStops = 0.20000000298023224;
            static float kDefaultSharpnessLinear = 0.9200000166893005;

            static /*0x13159e0*/ void SetEasuConstants(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector2 inputViewportSizeInPixels, UnityEngine.Vector2 inputImageSizeInPixels, UnityEngine.Vector2 outputImageSizeInPixels);
            static /*0x1315dc0*/ void SetRcasConstants(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessStops);
            static /*0x1315ce0*/ void SetRcasConstantsLinear(UnityEngine.Rendering.CommandBuffer cmd, float sharpnessLinear);
            static /*0x13159c0*/ bool IsSupported();

            class ShaderConstants
            {
                static /*0x0*/ int _FsrEasuConstants0;
                static /*0x4*/ int _FsrEasuConstants1;
                static /*0x8*/ int _FsrEasuConstants2;
                static /*0xc*/ int _FsrEasuConstants3;
                static /*0x10*/ int _FsrRcasConstants;

                static /*0x1317cb0*/ ShaderConstants();
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

            /*0x13167a0*/ HableCurve();
            /*0x8c2b50*/ float get_whitePoint();
            /*0x10e91a0*/ void set_whitePoint(float value);
            /*0x8c1b90*/ float get_inverseWhitePoint();
            /*0x10e9190*/ void set_inverseWhitePoint(float value);
            /*0xdd3690*/ float get_x0();
            /*0xdd5200*/ void set_x0(float value);
            /*0x1316910*/ float get_x1();
            /*0x1316920*/ void set_x1(float value);
            /*0x1315f40*/ float Eval(float x);
            /*0x1316520*/ void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma);
            /*0x1315fe0*/ void InitSegments(UnityEngine.Rendering.HableCurve.DirectParams srcParams);
            /*0x1316730*/ void SolveAB(ref float lnA, ref float B, float x0, float y0, float m);
            /*0x1315e90*/ void AsSlopeIntercept(ref float m, ref float b, float x0, float x1, float y0, float y1);
            /*0x1315ef0*/ float EvalDerivativeLinearGamma(float m, float b, float g, float x);

            class Segment
            {
                /*0x10*/ float offsetX;
                /*0x14*/ float offsetY;
                /*0x18*/ float scaleX;
                /*0x1c*/ float scaleY;
                /*0x20*/ float lnA;
                /*0x24*/ float B;

                /*0x32f970*/ Segment();
                /*0x1317c60*/ float Eval(float x);
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

                /*0x49b490*/ Uniforms(UnityEngine.Rendering.HableCurve parent);
                /*0x131ca40*/ UnityEngine.Vector4 get_curve();
                /*0x131cca0*/ UnityEngine.Vector4 get_toeSegmentA();
                /*0x131cd40*/ UnityEngine.Vector4 get_toeSegmentB();
                /*0x131ca80*/ UnityEngine.Vector4 get_midSegmentA();
                /*0x131cb20*/ UnityEngine.Vector4 get_midSegmentB();
                /*0x131cb90*/ UnityEngine.Vector4 get_shoSegmentA();
                /*0x131cc30*/ UnityEngine.Vector4 get_shoSegmentB();
            }
        }

        class HaltonSequence
        {
            static /*0x1316930*/ float Get(int index, int radix);
        }

        struct HashFNV1A32
        {
            static uint k_Prime = 16777619;
            static uint k_OffsetBasis = 2166136261;
            /*0x10*/ uint m_Hash;

            static /*0x1316c60*/ UnityEngine.Rendering.HashFNV1A32 Create();
            static /*0x1316c70*/ int GetFuncHashCode(System.Delegate del);
            /*0x1316a60*/ void Append(ref int input);
            /*0x1316a60*/ void Append(ref uint input);
            /*0x1316ba0*/ void Append(ref bool input);
            /*0x1316a20*/ void Append(ref float input);
            /*0x1316bc0*/ void Append(ref double input);
            /*0x1316c00*/ void Append(ref UnityEngine.Vector2 input);
            /*0x1316a70*/ void Append(ref UnityEngine.Vector3 input);
            /*0x1316b00*/ void Append(ref UnityEngine.Vector4 input);
            /*0x2a5510*/ void Append<T>(T input);
            /*0x1316990*/ void Append(System.Delegate del);
            /*0x6bba50*/ int get_value();
            /*0x6bba50*/ int GetHashCode();
        }

        class HDROutputUtils
        {
            static /*0x132a5b0*/ bool GetColorSpaceForGamut(UnityEngine.ColorGamut gamut, ref int colorspace);
            static /*0x132a410*/ bool GetColorEncodingForGamut(UnityEngine.ColorGamut gamut, ref int encoding);
            static /*0x132a160*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x1329de0*/ void ConfigureHDROutput(UnityEngine.MaterialPropertyBlock properties, UnityEngine.ColorGamut gamut);
            static /*0x1329bc0*/ void ConfigureHDROutput(UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x1329eb0*/ void ConfigureHDROutput(UnityEngine.ComputeShader computeShader, UnityEngine.ColorGamut gamut, UnityEngine.Rendering.HDROutputUtils.Operation operations);
            static /*0x132a820*/ bool IsShaderVariantValid(UnityEngine.Rendering.ShaderKeywordSet shaderKeywordSet, bool isHDREnabled);

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

                /*0x1329ba0*/ HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits);
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

                static /*0x132e260*/ ShaderKeywords();
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int hdrColorSpace;
                static /*0x4*/ int hdrEncoding;

                static /*0x132e3e0*/ ShaderPropertyId();
            }
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

            static /*0x132c090*/ MaterialQualityUtilities();
            static /*0x132bcf0*/ UnityEngine.Rendering.MaterialQuality GetHighestQuality(UnityEngine.Rendering.MaterialQuality levels);
            static /*0x132bb20*/ UnityEngine.Rendering.MaterialQuality GetClosestQuality(UnityEngine.Rendering.MaterialQuality availableLevels, UnityEngine.Rendering.MaterialQuality requestedLevel);
            static /*0x132bd80*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level);
            static /*0x132beb0*/ void SetGlobalShaderKeywords(UnityEngine.Rendering.MaterialQuality level, UnityEngine.Rendering.CommandBuffer cmd);
            static /*0x132c000*/ int ToFirstIndex(UnityEngine.Rendering.MaterialQuality level);
            static /*0x132bb10*/ UnityEngine.Rendering.MaterialQuality FromIndex(int index);
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

            static /*0x132d430*/ MeshGizmo();
            /*0x132d470*/ MeshGizmo(int capacity);
            /*0x132cca0*/ void Clear();
            /*0x132c490*/ void AddWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size, UnityEngine.Color color);
            /*0x132cd70*/ void DrawMesh(UnityEngine.Matrix4x4 trs, UnityEngine.Material mat, UnityEngine.MeshTopology topology, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x132cf50*/ void RenderWireframe(UnityEngine.Matrix4x4 trs, UnityEngine.Rendering.CompareFunction depthTest, string gizmoName);
            /*0x132cd20*/ void Dispose();
            /*0x132d120*/ void <AddWireCube>g__AddEdge|10_0(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, ref UnityEngine.Rendering.MeshGizmo.<> );

            struct <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Rendering.MeshGizmo <>4__this;
                /*0x18*/ UnityEngine.Color color;
            }
        }

        class ReloadAttribute : System.Attribute
        {
            /*0x534220*/ ReloadAttribute(string[] paths, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x132e080*/ ReloadAttribute(string path, UnityEngine.Rendering.ReloadAttribute.Package package);
            /*0x534220*/ ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.ReloadAttribute.Package package);

            enum Package
            {
                Builtin = 0,
                Root = 1,
                BuiltinExtra = 2,
            }
        }

        class ReloadGroupAttribute : System.Attribute
        {
            /*0x534220*/ ReloadGroupAttribute();
        }

        class SceneRenderPipeline : UnityEngine.MonoBehaviour
        {
            /*0x31c640*/ SceneRenderPipeline();
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

            static /*0x132eb10*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetTextureFormat();
            /*0x132eef0*/ TextureCurve(UnityEngine.AnimationCurve baseCurve, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x132f040*/ TextureCurve(UnityEngine.Keyframe[] keys, float zeroValue, bool loop, ref UnityEngine.Vector2 bounds);
            /*0x417e30*/ int get_length();
            /*0xdcd9c0*/ void set_length(int value);
            /*0x132f170*/ UnityEngine.Keyframe get_Item(int index);
            /*0xea43a0*/ void Finalize();
            /*0x32d010*/ void Dispose();
            /*0x132ee10*/ void Release();
            /*0x132eeb0*/ void SetDirty();
            /*0x132eb70*/ UnityEngine.Texture2D GetTexture();
            /*0x132e8a0*/ float Evaluate(float time);
            /*0x132e860*/ int AddKey(float time, float value);
            /*0x132edc0*/ int MoveKey(int index, ref UnityEngine.Keyframe key);
            /*0x132ee80*/ void RemoveKey(int index);
            /*0x132eec0*/ void SmoothTangents(int index, float weight);
        }

        class TextureCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.TextureCurve>
        {
            /*0x132e800*/ TextureCurveParameter(UnityEngine.Rendering.TextureCurve value, bool overrideState);
            /*0x132e780*/ void Release();
        }

        class TileLayoutUtils
        {
            static /*0x132f480*/ bool TryLayoutByTiles(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt topRow, ref UnityEngine.RectInt rightCol, ref UnityEngine.RectInt topRight);
            static /*0x132f410*/ bool TryLayoutByRow(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
            static /*0x132f3a0*/ bool TryLayoutByCol(UnityEngine.RectInt src, uint tileSize, ref UnityEngine.RectInt main, ref UnityEngine.RectInt other);
        }

        class XRUtils
        {
            static /*0x1335590*/ void DrawOcclusionMesh(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Camera camera, bool stereoEnabled);
        }

        interface IVolume
        {
            /*0x17cb40*/ bool get_isGlobal();
            /*0x181190*/ void set_isGlobal(bool value);
            /*0x1803b0*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
        }

        class KeyframeUtility
        {
            static /*0x132ba30*/ void ResetAnimationCurve(UnityEngine.AnimationCurve curve);
            static /*0x132b7e0*/ UnityEngine.Keyframe LerpSingleKeyframe(UnityEngine.Keyframe lhs, UnityEngine.Keyframe rhs, float t);
            static /*0x132af80*/ UnityEngine.Keyframe GetKeyframeAndClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index);
            static /*0x132add0*/ UnityEngine.Keyframe FetchKeyFromIndexClampEdge(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int index, float segmentStartTime, float segmentEndTime);
            static /*0x132aa50*/ void EvalCurveSegmentAndDeriv(ref float dstValue, ref float dstDeriv, UnityEngine.Keyframe lhsKey, UnityEngine.Keyframe rhsKey, float desiredTime);
            static /*0x132ac50*/ UnityEngine.Keyframe EvalKeyAtTime(Unity.Collections.NativeArray<UnityEngine.Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime);
            static /*0x132b0b0*/ void InterpAnimationCurve(ref UnityEngine.AnimationCurve lhsAndResultCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x32f970*/ KeyframeUtility();
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

            /*0x1334a90*/ Volume();
            /*0x796120*/ bool get_isGlobal();
            /*0x7963b0*/ void set_isGlobal(bool value);
            /*0x1334ba0*/ UnityEngine.Rendering.VolumeProfile get_profile();
            /*0x4e4360*/ void set_profile(UnityEngine.Rendering.VolumeProfile value);
            /*0x995140*/ System.Collections.Generic.List<UnityEngine.Collider> get_colliders();
            /*0x1334b20*/ UnityEngine.Rendering.VolumeProfile get_profileRef();
            /*0x1334730*/ bool HasInstantiatedProfile();
            /*0x1334810*/ void OnEnable();
            /*0x1334780*/ void OnDisable();
            /*0x1334960*/ void Update();
            /*0x13348b0*/ void UpdateLayer();
        }

        class VolumeComponentMenu : System.Attribute
        {
            /*0x10*/ string menu;

            /*0xa32e30*/ VolumeComponentMenu(string menu);
        }

        class VolumeComponentMenuForRenderPipeline : UnityEngine.Rendering.VolumeComponentMenu
        {
            /*0x18*/ System.Type[] <pipelineTypes>k__BackingField;

            /*0x132fd70*/ VolumeComponentMenuForRenderPipeline(string menu, System.Type[] pipelineTypes);
            /*0x32f410*/ System.Type[] get_pipelineTypes();
        }

        class VolumeComponentDeprecated : System.Attribute
        {
            /*0x534220*/ VolumeComponentDeprecated();
        }

        class VolumeComponent : UnityEngine.ScriptableObject
        {
            /*0x18*/ bool active;
            /*0x20*/ string <displayName>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameterList;
            /*0x30*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> m_ParameterReadOnlyCollection;

            static /*0x1330010*/ void FindParameters(object o, System.Collections.Generic.List<UnityEngine.Rendering.VolumeParameter> parameters, System.Func<System.Reflection.FieldInfo, bool> filter);
            /*0x1330dc0*/ VolumeComponent();
            /*0x61a260*/ string get_displayName();
            /*0x7965a0*/ void set_displayName(string value);
            /*0x1330e70*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x13306c0*/ void OnEnable();
            /*0x13305b0*/ void OnDisable();
            /*0x13308c0*/ void Override(UnityEngine.Rendering.VolumeComponent state, float interpFactor);
            /*0x1330ae0*/ void SetAllOverridesTo(bool state);
            /*0x1330af0*/ void SetOverridesTo(System.Collections.Generic.IEnumerable<UnityEngine.Rendering.VolumeParameter> enumerable, bool state);
            /*0x13304e0*/ int GetHashCode();
            /*0x132ff60*/ bool AnyPropertiesIsOverridden();
            /*0x13305a0*/ void OnDestroy();
            /*0x1330a20*/ void Release();

            class Indent : UnityEngine.PropertyAttribute
            {
                /*0x10*/ int relativeAmount;

                /*0x132a990*/ Indent(int relativeAmount);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeComponent.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__10_0;

                static /*0x132fa90*/ <>c();
                /*0x32f970*/ <>c();
                /*0x7190b0*/ int <FindParameters>b__10_0(System.Reflection.FieldInfo t);
            }
        }

        class VolumeManager
        {
            static int k_MaxLayerCount = 32;
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.VolumeManager> s_Instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.ValueTuple<string, System.Type>>> s_SupportedVolumeComponentsForRenderPipeline;
            /*0x10*/ UnityEngine.Rendering.VolumeStack <stack>k__BackingField;
            /*0x18*/ System.Type[] <baseComponentTypeArray>k__BackingField;
            /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Rendering.Volume>> m_SortedVolumes;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> m_Volumes;
            /*0x30*/ System.Collections.Generic.Dictionary<int, bool> m_SortNeeded;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> m_ComponentsDefaultState;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Collider> m_TempColliders;
            /*0x48*/ UnityEngine.Rendering.VolumeStack m_DefaultStack;

            static /*0x1332fd0*/ VolumeManager();
            static /*0x13333b0*/ UnityEngine.Rendering.VolumeManager get_instance();
            static /*0x13318b0*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> GetSupportedVolumeComponents(System.Type currentPipelineType);
            static /*0x1331300*/ System.Collections.Generic.List<System.ValueTuple<string, System.Type>> FilterVolumeComponentTypes(System.Type[] types, System.Type currentPipelineType);
            static /*0x13326a0*/ void SortByPriority(System.Collections.Generic.List<UnityEngine.Rendering.Volume> volumes);
            static /*0x3ce290*/ bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, UnityEngine.Camera camera);
            /*0x1333140*/ VolumeManager();
            /*0x73d3e0*/ UnityEngine.Rendering.VolumeStack get_stack();
            /*0x9f12f0*/ void set_stack(UnityEngine.Rendering.VolumeStack value);
            /*0x32f410*/ System.Collections.Generic.IEnumerable<System.Type> get_baseComponentTypes();
            /*0x1333420*/ void set_baseComponentTypes(System.Collections.Generic.IEnumerable<System.Type> value);
            /*0x32f410*/ System.Type[] get_baseComponentTypeArray();
            /*0x7963c0*/ void set_baseComponentTypeArray(System.Type[] value);
            /*0x1331730*/ UnityEngine.Rendering.VolumeComponent GetDefaultVolumeComponent(System.Type volumeComponentType);
            /*0x1331210*/ UnityEngine.Rendering.VolumeStack CreateStack();
            /*0x1332520*/ void ResetMainStack();
            /*0x13312e0*/ void DestroyStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x1332180*/ void ReloadBaseTypes();
            /*0x1331f60*/ void Register(UnityEngine.Rendering.Volume volume, int layer);
            /*0x13327c0*/ void Unregister(UnityEngine.Rendering.Volume volume, int layer);
            /*0x2a5510*/ bool IsComponentActiveInMask<T>(UnityEngine.LayerMask layerMask);
            /*0x1332540*/ void SetLayerDirty(int layer);
            /*0x1332960*/ void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer);
            /*0x1331e70*/ void OverrideData(UnityEngine.Rendering.VolumeStack stack, System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components, float interpFactor);
            /*0x1332450*/ void ReplaceData(UnityEngine.Rendering.VolumeStack stack);
            /*0x1330ee0*/ void CheckBaseTypes();
            /*0x1330f90*/ void CheckStack(UnityEngine.Rendering.VolumeStack stack);
            /*0x1331190*/ bool CheckUpdateRequired(UnityEngine.Rendering.VolumeStack stack);
            /*0x1332fa0*/ void Update(UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x13329a0*/ void Update(UnityEngine.Rendering.VolumeStack stack, UnityEngine.Transform trigger, UnityEngine.LayerMask layerMask);
            /*0x13319b0*/ UnityEngine.Rendering.Volume[] GetVolumes(UnityEngine.LayerMask layerMask);
            /*0x1331b00*/ System.Collections.Generic.List<UnityEngine.Rendering.Volume> GrabVolumes(UnityEngine.LayerMask mask);

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeManager.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<string, System.Type>, string> <>9__12_0;
                static /*0x10*/ System.Func<System.Type, bool> <>9__29_0;
                static /*0x18*/ System.Predicate<UnityEngine.Rendering.Volume> <>9__42_0;

                static /*0x132fa20*/ <>c();
                /*0x32f970*/ <>c();
                /*0x132f7f0*/ string <FilterVolumeComponentTypes>b__12_0(System.ValueTuple<string, System.Type> i);
                /*0x132f8e0*/ bool <ReloadBaseTypes>b__29_0(System.Type t);
                /*0x132f800*/ bool <GetVolumes>b__42_0(UnityEngine.Rendering.Volume v);
                /*0x132f910*/ UnityEngine.Rendering.VolumeManager <.cctor>b__46_0();
            }
        }

        struct VolumeIsolationScope : System.IDisposable
        {
            /*0x32d010*/ VolumeIsolationScope(bool unused);
            /*0x32d010*/ void System.IDisposable.Dispose();
        }

        class VolumeParameter : System.ICloneable
        {
            static string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
            /*0x10*/ bool m_OverrideState;

            static /*0x1333480*/ bool IsObjectParameter(System.Type type);
            /*0x32f970*/ VolumeParameter();
            /*0x793eb0*/ bool get_overrideState();
            /*0x793ec0*/ void set_overrideState(bool value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x2a5510*/ T GetValue<T>();
            /*0x17aec0*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x32d010*/ void OnEnable();
            /*0x32d010*/ void OnDisable();
            /*0x32d010*/ void Release();
            /*0x1803b0*/ object Clone();
        }

        class VolumeParameter<T> : UnityEngine.Rendering.VolumeParameter, System.IEquatable<UnityEngine.Rendering.VolumeParameter<T>>
        {
            /*0x0*/ T m_Value;

            static /*0x2a5510*/ bool op_Equality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x2a5510*/ bool op_Inequality(UnityEngine.Rendering.VolumeParameter<T> lhs, T rhs);
            static /*0x2a5510*/ T op_Explicit(UnityEngine.Rendering.VolumeParameter<T> prop);
            /*0x180fc0*/ VolumeParameter();
            /*0x2a5510*/ VolumeParameter(T value, bool overrideState);
            /*0x2a5510*/ T get_value();
            /*0x2a5510*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x2a5510*/ void Interp(T from, T to, float t);
            /*0x2a5510*/ void Override(T x);
            /*0x17aec0*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x180980*/ int GetHashCode();
            /*0x1803b0*/ string ToString();
            /*0x17e620*/ bool Equals(UnityEngine.Rendering.VolumeParameter<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x1803b0*/ object Clone();
        }

        class BoolParameter : UnityEngine.Rendering.VolumeParameter<bool>
        {
            /*0x20*/ UnityEngine.Rendering.BoolParameter.DisplayType displayType;

            /*0x131d0a0*/ BoolParameter(bool value, bool overrideState);
            /*0x131d100*/ BoolParameter(bool value, UnityEngine.Rendering.BoolParameter.DisplayType displayType, bool overrideState);

            enum DisplayType
            {
                Checkbox = 0,
                EnumPopup = 1,
            }
        }

        class LayerMaskParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.LayerMask>
        {
            /*0x132ba50*/ LayerMaskParameter(UnityEngine.LayerMask value, bool overrideState);
        }

        class IntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x132a9f0*/ IntParameter(int value, bool overrideState);
            /*0x132a9c0*/ void Interp(int from, int to, float t);
        }

        class NoInterpIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x132da60*/ NoInterpIntParameter(int value, bool overrideState);
        }

        class MinIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x20*/ int min;

            /*0x132c410*/ MinIntParameter(int value, int min, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x132d600*/ void set_value(int value);
        }

        class NoInterpMinIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x20*/ int min;

            /*0x132dc10*/ NoInterpMinIntParameter(int value, int min, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x132d600*/ void set_value(int value);
        }

        class MaxIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x20*/ int max;

            /*0x132c410*/ MaxIntParameter(int value, int max, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x132c480*/ void set_value(int value);
        }

        class NoInterpMaxIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x20*/ int max;

            /*0x132db30*/ NoInterpMaxIntParameter(int value, int max, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x132c480*/ void set_value(int value);
        }

        class ClampedIntParameter : UnityEngine.Rendering.IntParameter
        {
            /*0x20*/ int min;
            /*0x24*/ int max;

            /*0x131d210*/ ClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x131d280*/ void set_value(int value);
        }

        class NoInterpClampedIntParameter : UnityEngine.Rendering.VolumeParameter<int>
        {
            /*0x20*/ int min;
            /*0x24*/ int max;

            /*0x132d690*/ NoInterpClampedIntParameter(int value, int min, int max, bool overrideState);
            /*0x8a5c20*/ int get_value();
            /*0x131d280*/ void set_value(int value);
        }

        class FloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x1329a40*/ FloatParameter(float value, bool overrideState);
            /*0x1329a20*/ void Interp(float from, float to, float t);
        }

        class NoInterpFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x132d980*/ NoInterpFloatParameter(float value, bool overrideState);
        }

        class MinFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x20*/ float min;

            /*0x132c390*/ MinFloatParameter(float value, float min, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x132d5f0*/ void set_value(float value);
        }

        class NoInterpMinFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x20*/ float min;

            /*0x132dba0*/ NoInterpMinFloatParameter(float value, float min, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x132d5f0*/ void set_value(float value);
        }

        class MaxFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x20*/ float max;

            /*0x132c390*/ MaxFloatParameter(float value, float max, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x132c400*/ void set_value(float value);
        }

        class NoInterpMaxFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x20*/ float max;

            /*0x132dac0*/ NoInterpMaxFloatParameter(float value, float max, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x132c400*/ void set_value(float value);
        }

        class ClampedFloatParameter : UnityEngine.Rendering.FloatParameter
        {
            /*0x20*/ float min;
            /*0x24*/ float max;

            /*0x131d170*/ ClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x131d1f0*/ void set_value(float value);
        }

        class NoInterpClampedFloatParameter : UnityEngine.Rendering.VolumeParameter<float>
        {
            /*0x20*/ float min;
            /*0x24*/ float max;

            /*0x132d610*/ NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState);
            /*0xdd3690*/ float get_value();
            /*0x131d1f0*/ void set_value(float value);
        }

        class FloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x20*/ float min;
            /*0x24*/ float max;

            /*0x1329af0*/ FloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0xa3cb00*/ UnityEngine.Vector2 get_value();
            /*0x1329b70*/ void set_value(UnityEngine.Vector2 value);
            /*0x1329aa0*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpFloatRangeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x20*/ float min;
            /*0x24*/ float max;

            /*0x132d9e0*/ NoInterpFloatRangeParameter(UnityEngine.Vector2 value, float min, float max, bool overrideState);
            /*0xa3cb00*/ UnityEngine.Vector2 get_value();
            /*0x1329b70*/ void set_value(UnityEngine.Vector2 value);
        }

        class ColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x28*/ bool hdr;
            /*0x29*/ bool showAlpha;
            /*0x2a*/ bool showEyeDropper;

            /*0x131d3c0*/ ColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x131d310*/ ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
            /*0x131d2a0*/ void Interp(UnityEngine.Color from, UnityEngine.Color to, float t);
        }

        class NoInterpColorParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Color>
        {
            /*0x28*/ bool hdr;
            /*0x29*/ bool showAlpha;
            /*0x2a*/ bool showEyeDropper;

            /*0x132d700*/ NoInterpColorParameter(UnityEngine.Color value, bool overrideState);
            /*0x132d770*/ NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState);
        }

        class Vector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x132fbe0*/ Vector2Parameter(UnityEngine.Vector2 value, bool overrideState);
            /*0x1329aa0*/ void Interp(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float t);
        }

        class NoInterpVector2Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector2>
        {
            /*0x132df40*/ NoInterpVector2Parameter(UnityEngine.Vector2 value, bool overrideState);
        }

        class Vector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x132fc90*/ Vector3Parameter(UnityEngine.Vector3 value, bool overrideState);
            /*0x132fc40*/ void Interp(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float t);
        }

        class NoInterpVector3Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector3>
        {
            /*0x132dfa0*/ NoInterpVector3Parameter(UnityEngine.Vector3 value, bool overrideState);
        }

        class Vector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x132fd00*/ Vector4Parameter(UnityEngine.Vector4 value, bool overrideState);
            /*0x131d2a0*/ void Interp(UnityEngine.Vector4 from, UnityEngine.Vector4 to, float t);
        }

        class NoInterpVector4Parameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Vector4>
        {
            /*0x132e010*/ NoInterpVector4Parameter(UnityEngine.Vector4 value, bool overrideState);
        }

        class TextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x20*/ UnityEngine.Rendering.TextureDimension dimension;

            /*0x132f330*/ TextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x132f2c0*/ TextureParameter(UnityEngine.Texture value, UnityEngine.Rendering.TextureDimension dimension, bool overrideState);
            /*0x132f1c0*/ int GetHashCode();
        }

        class NoInterpTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x132dee0*/ NoInterpTextureParameter(UnityEngine.Texture value, bool overrideState);
            /*0x132dde0*/ int GetHashCode();
        }

        class Texture2DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x132e5c0*/ Texture2DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x132e4c0*/ int GetHashCode();
        }

        class Texture3DParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x132e720*/ Texture3DParameter(UnityEngine.Texture value, bool overrideState);
            /*0x132e620*/ int GetHashCode();
        }

        class RenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x132e200*/ RenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x132e100*/ int GetHashCode();
        }

        class NoInterpRenderTextureParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.RenderTexture>
        {
            /*0x132dd80*/ NoInterpRenderTextureParameter(UnityEngine.RenderTexture value, bool overrideState);
            /*0x132dc80*/ int GetHashCode();
        }

        class CubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Texture>
        {
            /*0x131d530*/ CubemapParameter(UnityEngine.Texture value, bool overrideState);
            /*0x131d430*/ int GetHashCode();
        }

        class NoInterpCubemapParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Cubemap>
        {
            /*0x132d920*/ NoInterpCubemapParameter(UnityEngine.Cubemap value, bool overrideState);
            /*0x132d820*/ int GetHashCode();
        }

        class ObjectParameter<T> : UnityEngine.Rendering.VolumeParameter<T>
        {
            /*0x0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> <parameters>k__BackingField;

            /*0x2a5510*/ ObjectParameter(T value);
            /*0x1803b0*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> get_parameters();
            /*0x17aec0*/ void set_parameters(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Rendering.VolumeParameter> value);
            /*0x17cb40*/ bool get_overrideState();
            /*0x181190*/ void set_overrideState(bool value);
            /*0x2a5510*/ T get_value();
            /*0x2a5510*/ void set_value(T value);
            void Interp(UnityEngine.Rendering.VolumeParameter from, UnityEngine.Rendering.VolumeParameter to, float t);
            /*0x1858d0*/ UnityEngine.Rendering.VolumeParameter <set_value>b__9_2(System.Reflection.FieldInfo t);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Rendering.ObjectParameter.<>c<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__9_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, int> <>9__9_1;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x17e620*/ bool <set_value>b__9_0(System.Reflection.FieldInfo t);
                /*0x17b580*/ int <set_value>b__9_1(System.Reflection.FieldInfo t);
            }
        }

        class AnimationCurveParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.AnimationCurve>
        {
            /*0x131d040*/ AnimationCurveParameter(UnityEngine.AnimationCurve value, bool overrideState);
            /*0x131cf60*/ void Interp(UnityEngine.AnimationCurve lhsCurve, UnityEngine.AnimationCurve rhsCurve, float t);
            /*0x131cfb0*/ void SetValue(UnityEngine.Rendering.VolumeParameter parameter);
            /*0x131cdb0*/ object Clone();
            /*0x131ceb0*/ int GetHashCode();
        }

        class MaterialParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Material>
        {
            /*0x132bab0*/ MaterialParameter(UnityEngine.Material value, bool overrideState);
        }

        class VolumeProfile : UnityEngine.ScriptableObject
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> components;
            /*0x20*/ bool isDirty;

            /*0x1333f90*/ VolumeProfile();
            /*0x1333c60*/ void OnEnable();
            /*0x1333b70*/ void OnDisable();
            /*0x1333ea0*/ void Reset();
            /*0x2a5510*/ T Add<T>(bool overrides);
            /*0x13335c0*/ UnityEngine.Rendering.VolumeComponent Add(System.Type type, bool overrides);
            /*0x180fc0*/ void Remove<T>();
            /*0x1333d80*/ void Remove(System.Type type);
            /*0x17cb40*/ bool Has<T>();
            /*0x13339f0*/ bool Has(System.Type type);
            /*0x1333890*/ bool HasSubclassOf(System.Type type);
            /*0x17e620*/ bool TryGet<T>(ref T component);
            bool TryGet<T>(System.Type type, ref T component);
            bool TryGetSubclassOf<T>(System.Type type, ref T component);
            bool TryGetAllSubclassOf<T>(System.Type type, System.Collections.Generic.List<T> result);
            /*0x13337d0*/ int GetHashCode();
            /*0x1333700*/ int GetComponentListHashCode();
            /*0x1333eb0*/ void Sanitize();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.VolumeProfile.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Rendering.VolumeComponent> <>9__2_0;

                static /*0x132fb00*/ <>c();
                /*0x32f970*/ <>c();
                /*0x132f850*/ bool <OnEnable>b__2_0(UnityEngine.Rendering.VolumeComponent x);
            }
        }

        class VolumeStack : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Rendering.VolumeComponent> components;
            /*0x18*/ System.ValueTuple<UnityEngine.Rendering.VolumeParameter, UnityEngine.Rendering.VolumeParameter> defaultParameters;
            /*0x20*/ bool requiresReset;

            /*0x13346b0*/ VolumeStack();
            /*0x1334010*/ void Clear();
            /*0x1334280*/ void Reload(System.Collections.Generic.List<UnityEngine.Rendering.VolumeComponent> componentDefaultStates);
            /*0x2a5510*/ T GetComponent<T>();
            /*0x1334210*/ UnityEngine.Rendering.VolumeComponent GetComponent(System.Type type);
            /*0x1334200*/ void Dispose();
        }

        class XRGraphicsAutomatedTests
        {
            static /*0x0*/ bool <enabled>k__BackingField;
            static /*0x1*/ bool running;

            static /*0x13354f0*/ XRGraphicsAutomatedTests();
            static /*0x348b00*/ bool get_activatedFromCommandLine();
            static /*0x1335540*/ bool get_enabled();
            static /*0x1334e60*/ void OverrideLayout(UnityEngine.Experimental.Rendering.XRLayout layout, UnityEngine.Camera camera);
        }

        namespace LookDev
        {
            interface IDataProvider
            {
                /*0x17aec0*/ void FirstInitScene(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x2a5510*/ void UpdateSky(UnityEngine.Camera camera, UnityEngine.Rendering.LookDev.Sky sky, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x1803b0*/ System.Collections.Generic.IEnumerable<string> get_supportedDebugModes();
                /*0x17aa40*/ void UpdateDebugMode(int debugIndex);
                /*0x183150*/ void GetShadowMask(ref UnityEngine.RenderTexture output, UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x17aec0*/ void OnBeginRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x17aec0*/ void OnEndRendering(UnityEngine.Rendering.LookDev.StageRuntimeInterface stage);
                /*0x17aec0*/ void Cleanup(UnityEngine.Rendering.LookDev.StageRuntimeInterface SRI);
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

                /*0xce5250*/ StageRuntimeInterface(System.Func<bool, UnityEngine.GameObject> AddGameObject, System.Func<UnityEngine.Camera> GetCamera, System.Func<UnityEngine.Light> GetSunLight);
                /*0x132e460*/ UnityEngine.GameObject AddGameObject(bool persistent);
                /*0x132e480*/ UnityEngine.Camera get_camera();
                /*0x132e4a0*/ UnityEngine.Light get_sunLight();
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

                /*0x798050*/ DebugUIHandlerBitField();
                /*0x131dbe0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x131d590*/ bool GetValue(int index);
                /*0x131d910*/ void SetValue(int index, bool value);
                /*0x131d7f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131d7c0*/ void OnIncrement(bool fast);
                /*0x131d750*/ void OnDecrement(bool fast);
                /*0x131d720*/ void OnAction();
                /*0x131d640*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerButton : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.Button m_Field;

                /*0x798050*/ DebugUIHandlerButton();
                /*0x131e020*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x131dfe0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131dfa0*/ void OnAction();
            }

            class DebugUIPrefabBundle
            {
                /*0x10*/ string type;
                /*0x18*/ UnityEngine.RectTransform prefab;

                /*0x32f970*/ DebugUIPrefabBundle();
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

                /*0x31c640*/ DebugUIHandlerCanvas();
                /*0x131ec20*/ void OnEnable();
                /*0x1320060*/ void Update();
                /*0x8b4d70*/ void RequestHierarchyReset();
                /*0x131f570*/ void ResetAllHierarchy();
                /*0x131ed70*/ void Rebuild();
                /*0x131fb00*/ void Traverse(UnityEngine.Rendering.DebugUI.IContainer container, UnityEngine.Transform parentTransform, UnityEngine.Rendering.UI.DebugUIHandlerWidget parentUIHandler, ref UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedHandler);
                /*0x131e6f0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetWidgetFromPath(string queryPath);
                /*0x131e0c0*/ void ActivatePanel(int index, UnityEngine.Rendering.UI.DebugUIHandlerWidget selectedWidget);
                /*0x131e4a0*/ void ChangeSelection(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget, bool fromNext);
                /*0x131f8f0*/ void SelectPreviousItem();
                /*0x131f880*/ void SelectNextPanel();
                /*0x131f9b0*/ void SelectPreviousPanel();
                /*0x131f7c0*/ void SelectNextItem();
                /*0x131e390*/ void ChangeSelectionValue(float multiplier);
                /*0x131e310*/ void ActivateSelection();
                /*0x131e830*/ void HandleInput();
                /*0x131fa20*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.UI.DebugUIHandlerCanvas.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.DebugUI.Widget, bool> <>9__12_0;
                    static /*0x10*/ System.Action<UnityEngine.Rendering.UI.DebugUIHandlerPanel> <>9__15_0;

                    static /*0x132fb70*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x132f8a0*/ bool <Rebuild>b__12_0(UnityEngine.Rendering.DebugUI.Widget x);
                    /*0x4741b0*/ void <ActivatePanel>b__15_0(UnityEngine.Rendering.UI.DebugUIHandlerPanel p);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string queryPath;

                    /*0x32f970*/ <>c__DisplayClass14_0();
                    /*0x132f960*/ bool <GetWidgetFromPath>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget w);
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

                /*0x798050*/ DebugUIHandlerColor();
                /*0x13204a0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1320390*/ void SetValue(float x, bool r, bool g, bool b, bool a);
                /*0x1320990*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x1320270*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131d7c0*/ void OnIncrement(bool fast);
                /*0x131d750*/ void OnDecrement(bool fast);
                /*0x131d720*/ void OnAction();
                /*0x1321000*/ void UpdateColor();
                /*0x1320190*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x1320ad0*/ float <SetWidget>b__9_0();
                /*0x1320b30*/ void <SetWidget>b__9_1(float x);
                /*0x1320c00*/ float <SetWidget>b__9_2();
                /*0x1320c60*/ void <SetWidget>b__9_3(float x);
                /*0x1320d30*/ float <SetWidget>b__9_4();
                /*0x1320d90*/ void <SetWidget>b__9_5(float x);
                /*0x1320e60*/ float <SetWidget>b__9_6();
                /*0x1320ec0*/ void <SetWidget>b__9_7(float x);
                /*0x1320f90*/ float <SetupSettings>b__11_0();
                /*0x1320fb0*/ float <SetupSettings>b__11_1();
                /*0x1320fd0*/ float <SetupSettings>b__11_2();
            }

            class DebugUIHandlerContainer : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform contentHolder;

                /*0x31c640*/ DebugUIHandlerContainer();
                /*0x13213a0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x1321420*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetLastItem();
                /*0x13214b0*/ bool IsDirectChild(UnityEngine.Rendering.UI.DebugUIHandlerWidget widget);
                /*0x13210c0*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerWidget> GetActiveChildren();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget widget;

                    /*0x32f970*/ <>c__DisplayClass3_0();
                    /*0x132f990*/ bool <IsDirectChild>b__0(UnityEngine.Rendering.UI.DebugUIHandlerWidget x);
                }
            }

            class DebugUIHandlerEnumField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.EnumField>
            {
                /*0x13219d0*/ DebugUIHandlerEnumField();
                /*0x13217b0*/ void OnIncrement(bool fast);
                /*0x13215c0*/ void OnDecrement(bool fast);
                /*0x1321940*/ void UpdateValueLabel();
            }

            class DebugUIHandlerEnumHistory : UnityEngine.Rendering.UI.DebugUIHandlerEnumField
            {
                static float k_XOffset = 230;
                /*0x88*/ UnityEngine.UI.Text[] historyValues;

                /*0x13219d0*/ DebugUIHandlerEnumHistory();
                /*0x1321a80*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1321de0*/ void UpdateValueLabel();
                /*0x1321a10*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory <>4__this;

                    /*0x32f460*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x32d010*/ void System.IDisposable.Dispose();
                    /*0x132f640*/ bool MoveNext();
                    /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x132f7b0*/ void System.Collections.IEnumerator.Reset();
                    /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerField<T> : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x0*/ UnityEngine.UI.Text nextButtonText;
                /*0x0*/ UnityEngine.UI.Text previousButtonText;
                /*0x0*/ UnityEngine.UI.Text nameLabel;
                /*0x0*/ UnityEngine.UI.Text valueLabel;
                /*0x0*/ T m_Field;

                /*0x180fc0*/ DebugUIHandlerField();
                /*0x17aec0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x180fc0*/ void OnDeselection();
                /*0x180fc0*/ void OnAction();
                /*0x180fc0*/ void UpdateValueLabel();
                /*0x17aec0*/ void SetLabelText(string text);
            }

            class DebugUIHandlerFloatField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.FloatField m_Field;

                /*0x798050*/ DebugUIHandlerFloatField();
                /*0x1322260*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
                /*0x13221e0*/ void OnIncrement(bool fast);
                /*0x1322160*/ void OnDecrement(bool fast);
                /*0x13220b0*/ void ChangeValue(bool fast, float multiplier);
                /*0x1322300*/ void UpdateValueLabel();
            }

            class DebugUIHandlerFoldout : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static float k_FoldoutXOffset = 215;
                static float k_XOffset = 230;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Foldout m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x798050*/ DebugUIHandlerFoldout();
                /*0x1322660*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1322550*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x1322510*/ void OnIncrement(bool fast);
                /*0x13224d0*/ void OnDecrement(bool fast);
                /*0x1322490*/ void OnAction();
                /*0x1322b40*/ void UpdateValue();
                /*0x13223c0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerGroup : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Transform header;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Container m_Field;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x798050*/ DebugUIHandlerGroup();
                /*0x1322cf0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1322c30*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322b70*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerHBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x798050*/ DebugUIHandlerHBox();
                /*0x1322f70*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1322eb0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322df0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
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

                /*0x798050*/ DebugUIHandlerIndirectFloatField();
                /*0x13230c0*/ void Init();
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
                /*0x13230e0*/ void OnIncrement(bool fast);
                /*0x13230d0*/ void OnDecrement(bool fast);
                /*0x1322fe0*/ void ChangeValue(bool fast, float multiplier);
                /*0x13230f0*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIndirectToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ System.Func<int, bool> getter;
                /*0x80*/ System.Action<int, bool> setter;
                /*0x88*/ int index;

                /*0x798050*/ DebugUIHandlerIndirectToggle();
                /*0x1323200*/ void Init();
                /*0x1323410*/ void OnToggleValueChanged(bool value);
                /*0x13233a0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1323330*/ void OnDeselection();
                /*0x13232c0*/ void OnAction();
                /*0x1323450*/ void UpdateValueLabel();
            }

            class DebugUIHandlerIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.IntField m_Field;

                /*0x798050*/ DebugUIHandlerIntField();
                /*0x13235c0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
                /*0x13235b0*/ void OnIncrement(bool fast);
                /*0x13235a0*/ void OnDecrement(bool fast);
                /*0x13234f0*/ void ChangeValue(bool fast, int multiplier);
                /*0x1323660*/ void UpdateValueLabel();
            }

            class DebugUIHandlerMessageBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color32 k_WarningBackgroundColor;
                static /*0x4*/ UnityEngine.Color32 k_WarningTextColor;
                static /*0x8*/ UnityEngine.Color32 k_ErrorBackgroundColor;
                static /*0xc*/ UnityEngine.Color32 k_ErrorTextColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.DebugUI.MessageBox m_Field;

                static /*0x1323900*/ DebugUIHandlerMessageBox();
                /*0x798050*/ DebugUIHandlerMessageBox();
                /*0x1323730*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x348b00*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
            }

            class DebugUIHandlerObject : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;

                /*0x798050*/ DebugUIHandlerObject();
                /*0x1323e90*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
            }

            class DebugUIHandlerObjectList : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectListField>
            {
                /*0x88*/ int m_Index;

                /*0x1323ba0*/ DebugUIHandlerObjectList();
                /*0x13239e0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13239c0*/ void OnIncrement(bool fast);
                /*0x13239a0*/ void OnDecrement(bool fast);
                /*0x1323a40*/ void UpdateValueLabel();
            }

            class DebugUIHandlerObjectPopupField : UnityEngine.Rendering.UI.DebugUIHandlerField<UnityEngine.Rendering.DebugUI.ObjectPopupField>
            {
                /*0x88*/ int m_Index;

                /*0x1323e50*/ DebugUIHandlerObjectPopupField();
                /*0x1323d20*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1323be0*/ void ChangeSelectedObject();
                /*0x1323d10*/ void OnIncrement(bool fast);
                /*0x1323d00*/ void OnDecrement(bool fast);
                /*0x1323d80*/ void UpdateValueLabel();
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

                /*0x31c640*/ DebugUIHandlerPanel();
                /*0x1324130*/ void OnEnable();
                /*0x13243b0*/ void SetPanel(UnityEngine.Rendering.DebugUI.Panel panel);
                /*0xe643b0*/ UnityEngine.Rendering.DebugUI.Panel GetPanel();
                /*0x13242c0*/ void SelectNextItem();
                /*0x1324330*/ void SelectPreviousItem();
                /*0x1324200*/ void OnScrollbarClicked();
                /*0xb61a20*/ void SetScrollTarget(UnityEngine.Rendering.UI.DebugUIHandlerWidget target);
                /*0x1324410*/ void UpdateScroll();
                /*0x1323fc0*/ float GetYPosInScroll(UnityEngine.RectTransform target);
                /*0x1323f70*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget GetFirstItem();
                /*0x1324260*/ void ResetDebugManager();
            }

            class DebugUIHandlerPersistentCanvas : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform panel;
                /*0x28*/ UnityEngine.RectTransform valuePrefab;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.UI.DebugUIHandlerValue> m_Items;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.DebugUI.ValueTuple> m_ValueTupleWidgets;

                /*0x1324eb0*/ DebugUIHandlerPersistentCanvas();
                /*0x13247d0*/ void Toggle(UnityEngine.Rendering.DebugUI.Value widget, string displayName);
                /*0x1324ad0*/ void Toggle(UnityEngine.Rendering.DebugUI.ValueTuple widget, System.Nullable<int> forceTupleIndex);
                /*0x1324780*/ bool IsEmpty();
                /*0x13245f0*/ void Clear();

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.Value widget;

                    /*0x32f970*/ <>c__DisplayClass3_0();
                    /*0x132f9f0*/ bool <Toggle>b__0(UnityEngine.Rendering.UI.DebugUIHandlerValue x);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugUI.ValueTuple widget;

                    /*0x32f970*/ <>c__DisplayClass5_0();
                    /*0x132fa10*/ bool <Toggle>b__0(UnityEngine.Rendering.DebugUI.ValueTuple x);
                }
            }

            class DebugUIHandlerProgressBar : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.RectTransform progressBarRect;
                /*0x78*/ UnityEngine.Rendering.DebugUI.ProgressBarValue m_Value;
                /*0x80*/ float m_Timer;

                /*0x798050*/ DebugUIHandlerProgressBar();
                /*0x1324f70*/ void OnEnable();
                /*0x1324f80*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x131dfe0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x1325180*/ void Update();
                /*0x1325020*/ void UpdateValue();
            }

            class DebugUIHandlerRow : UnityEngine.Rendering.UI.DebugUIHandlerFoldout
            {
                /*0x80*/ float m_Timer;

                /*0x798050*/ DebugUIHandlerRow();
                /*0x1324f70*/ void OnEnable();
                /*0x1325200*/ UnityEngine.GameObject GetChild(int index);
                /*0x1325480*/ bool TryGetChild(int index, ref UnityEngine.GameObject child);
                /*0x1325330*/ bool IsActive(UnityEngine.Rendering.DebugUI.Table table, int index, UnityEngine.GameObject child);
                /*0x1325510*/ void Update();
            }

            class DebugUIHandlerToggle : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Toggle valueToggle;
                /*0x70*/ UnityEngine.UI.Image checkmarkImage;
                /*0x78*/ UnityEngine.Rendering.DebugUI.BoolField m_Field;

                /*0x798050*/ DebugUIHandlerToggle();
                /*0x13266e0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13266b0*/ void OnToggleValueChanged(bool value);
                /*0x13233a0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1323330*/ void OnDeselection();
                /*0x1326630*/ void OnAction();
                /*0x1326810*/ void UpdateValueLabel();
            }

            class DebugUIHandlerToggleHistory : UnityEngine.Rendering.UI.DebugUIHandlerToggle
            {
                static float k_XOffset = 230;
                /*0x80*/ UnityEngine.UI.Toggle[] historyToggles;

                /*0x798050*/ DebugUIHandlerToggleHistory();
                /*0x1325d80*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13263a0*/ void UpdateValueLabel();
                /*0x1325d10*/ System.Collections.IEnumerator RefreshAfterSanitization();

                class <RefreshAfterSanitization>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory <>4__this;

                    /*0x32f460*/ <RefreshAfterSanitization>d__4(int <>1__state);
                    /*0x32d010*/ void System.IDisposable.Dispose();
                    /*0x132f590*/ bool MoveNext();
                    /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x132f770*/ void System.Collections.IEnumerator.Reset();
                    /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DebugUIHandlerUIntField : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.UIntField m_Field;

                /*0x798050*/ DebugUIHandlerUIntField();
                /*0x1326a90*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
                /*0x1326a00*/ void OnIncrement(bool fast);
                /*0x1326960*/ void OnDecrement(bool fast);
                /*0x13268b0*/ void ChangeValue(bool fast, int multiplier);
                /*0x1326b30*/ void UpdateValueLabel();
            }

            class DebugUIHandlerValue : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                static /*0x0*/ UnityEngine.Color k_ZeroColor;
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.UI.Text valueLabel;
                /*0x70*/ UnityEngine.Rendering.DebugUI.Value m_Field;
                /*0x78*/ float m_Timer;

                static /*0x1327850*/ DebugUIHandlerValue();
                /*0x798050*/ DebugUIHandlerValue();
                /*0x13275f0*/ void OnEnable();
                /*0x1327600*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x13221f0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1322170*/ void OnDeselection();
                /*0x13276a0*/ void Update();
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

                static /*0x13275b0*/ DebugUIHandlerValueTuple();
                /*0x798050*/ DebugUIHandlerValueTuple();
                /*0x1324f70*/ void OnEnable();
                /*0x131dfe0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x1326df0*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1327270*/ void UpdateValueLabels();
                /*0x1327510*/ void Update();
            }

            class DebugUIHandlerVBox : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x798050*/ DebugUIHandlerVBox();
                /*0x1326d80*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1326cc0*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x1326c00*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class DebugUIHandlerVector2 : UnityEngine.Rendering.UI.DebugUIHandlerWidget
            {
                /*0x60*/ UnityEngine.UI.Text nameLabel;
                /*0x68*/ UnityEngine.Rendering.UI.UIFoldout valueToggle;
                /*0x70*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldX;
                /*0x78*/ UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField fieldY;
                /*0x80*/ UnityEngine.Rendering.DebugUI.Vector2Field m_Field;
                /*0x88*/ UnityEngine.Rendering.UI.DebugUIHandlerContainer m_Container;

                /*0x798050*/ DebugUIHandlerVector2();
                /*0x1327b50*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1327a90*/ void SetValue(float v, bool x, bool y);
                /*0x1327dd0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x1327970*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131d7c0*/ void OnIncrement(bool fast);
                /*0x131d750*/ void OnDecrement(bool fast);
                /*0x131d720*/ void OnAction();
                /*0x1327890*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x1327f10*/ float <SetWidget>b__6_0();
                /*0x1327f70*/ void <SetWidget>b__6_1(float x);
                /*0x1328000*/ float <SetWidget>b__6_2();
                /*0x1328060*/ void <SetWidget>b__6_3(float x);
                /*0x13280f0*/ float <SetupSettings>b__8_0();
                /*0x1328110*/ float <SetupSettings>b__8_1();
                /*0x1328130*/ float <SetupSettings>b__8_2();
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

                /*0x798050*/ DebugUIHandlerVector3();
                /*0x1328440*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1328360*/ void SetValue(float v, bool x, bool y, bool z);
                /*0x13287c0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x1328240*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131d7c0*/ void OnIncrement(bool fast);
                /*0x131d750*/ void OnDecrement(bool fast);
                /*0x131d720*/ void OnAction();
                /*0x1328160*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x1328900*/ float <SetWidget>b__7_0();
                /*0x1328960*/ void <SetWidget>b__7_1(float v);
                /*0x1328a00*/ float <SetWidget>b__7_2();
                /*0x1328a60*/ void <SetWidget>b__7_3(float v);
                /*0x1328b00*/ float <SetWidget>b__7_4();
                /*0x1328b60*/ void <SetWidget>b__7_5(float v);
                /*0x1328c00*/ float <SetupSettings>b__9_0();
                /*0x1328c20*/ float <SetupSettings>b__9_1();
                /*0x1328c40*/ float <SetupSettings>b__9_2();
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

                /*0x798050*/ DebugUIHandlerVector4();
                /*0x1328f80*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0x1328e70*/ void SetValue(float v, bool x, bool y, bool z, bool w);
                /*0x13293f0*/ void SetupSettings(UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField field);
                /*0x1328d50*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x131d780*/ void OnDeselection();
                /*0x131d7c0*/ void OnIncrement(bool fast);
                /*0x131d750*/ void OnDecrement(bool fast);
                /*0x131d720*/ void OnAction();
                /*0x1328c70*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
                /*0x1329530*/ float <SetWidget>b__8_0();
                /*0x1329590*/ void <SetWidget>b__8_1(float x);
                /*0x1329650*/ float <SetWidget>b__8_2();
                /*0x13296b0*/ void <SetWidget>b__8_3(float x);
                /*0x1329770*/ float <SetWidget>b__8_4();
                /*0x13297d0*/ void <SetWidget>b__8_5(float x);
                /*0x1329890*/ float <SetWidget>b__8_6();
                /*0x13298f0*/ void <SetWidget>b__8_7(float x);
                /*0x13299b0*/ float <SetupSettings>b__10_0();
                /*0x13299d0*/ float <SetupSettings>b__10_1();
                /*0x13299f0*/ float <SetupSettings>b__10_2();
            }

            class DebugUIHandlerWidget : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Color colorDefault;
                /*0x30*/ UnityEngine.Color colorSelected;
                /*0x40*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <parentUIHandler>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <previousUIHandler>k__BackingField;
                /*0x50*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget <nextUIHandler>k__BackingField;
                /*0x58*/ UnityEngine.Rendering.DebugUI.Widget m_Widget;

                /*0x1335800*/ DebugUIHandlerWidget();
                /*0xb61870*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_parentUIHandler();
                /*0xcf6cd0*/ void set_parentUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x4e40d0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_previousUIHandler();
                /*0x4e4360*/ void set_previousUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x4e40e0*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget get_nextUIHandler();
                /*0x4e4370*/ void set_nextUIHandler(UnityEngine.Rendering.UI.DebugUIHandlerWidget value);
                /*0x32d010*/ void OnEnable();
                /*0xb61a20*/ void SetWidget(UnityEngine.Rendering.DebugUI.Widget widget);
                /*0xb61940*/ UnityEngine.Rendering.DebugUI.Widget GetWidget();
                /*0x2a5510*/ T CastWidget<T>();
                /*0x3ce290*/ bool OnSelection(bool fromNext, UnityEngine.Rendering.UI.DebugUIHandlerWidget previous);
                /*0x32d010*/ void OnDeselection();
                /*0x32d010*/ void OnAction();
                /*0x32d010*/ void OnIncrement(bool fast);
                /*0x32d010*/ void OnDecrement(bool fast);
                /*0x1335750*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Previous();
                /*0x1335630*/ UnityEngine.Rendering.UI.DebugUIHandlerWidget Next();
            }

            class UIFoldout : UnityEngine.UI.Toggle
            {
                /*0x128*/ UnityEngine.GameObject content;
                /*0x130*/ UnityEngine.GameObject arrowOpened;
                /*0x138*/ UnityEngine.GameObject arrowClosed;

                /*0x1335b10*/ UIFoldout();
                /*0x1335a50*/ void Start();
                /*0x1335820*/ void OnValidate();
                /*0x1335840*/ void SetState(bool state);
                /*0x1335850*/ void SetState(bool state, bool rebuildLayout);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097;
    static /*0x100*/ <PrivateImplementationDetails> 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A;
    static /*0x300*/ <PrivateImplementationDetails> 7DE9E34DC6DC53F9052337C321856C2B209C506DFB969F9FA2126D5F5F76BCD8;
    static /*0x4c9b*/ <PrivateImplementationDetails> 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4;
    static /*0x509b*/ <PrivateImplementationDetails> BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158;
    static /*0x512b*/ <PrivateImplementationDetails> C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF;
    static /*0x612b*/ <PrivateImplementationDetails> CD4AC44D3D07CBFB8F72693232F0A04A4D44369E9180E37EF6E673C579594EA7;
    static /*0xb04d*/ <PrivateImplementationDetails> FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE;

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

    struct __StaticArrayInitTypeSize=18843
    {
    }

    struct __StaticArrayInitTypeSize=20258
    {
    }
}
