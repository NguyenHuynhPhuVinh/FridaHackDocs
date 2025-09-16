class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7bee528*/ EmbeddedAttribute();
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
                /*0x7bee530*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace UnityEngine
{
    namespace Rendering
    {
        struct AABB
        {
            /*0x10*/ Unity.Mathematics.float3 center;
            /*0x1c*/ Unity.Mathematics.float3 extents;

            static /*0x7bee630*/ Unity.Mathematics.float3 RotateExtents(Unity.Mathematics.float3 extents, Unity.Mathematics.float3 m0, Unity.Mathematics.float3 m1, Unity.Mathematics.float3 m2);
            static /*0x7bee69c*/ UnityEngine.Rendering.AABB Transform(Unity.Mathematics.float4x4 transform, UnityEngine.Rendering.AABB localBounds);
            /*0x7bee538*/ Unity.Mathematics.float3 get_min();
            /*0x7bee558*/ Unity.Mathematics.float3 get_max();
            /*0x7bee578*/ string ToString();
        }

        class AABBExtensions
        {
            static /*0x7bee76c*/ UnityEngine.Rendering.AABB ToAABB(UnityEngine.Bounds bounds);
            static /*0x7bee7d4*/ UnityEngine.Bounds ToBounds(UnityEngine.Rendering.AABB aabb);
        }

        class DebugDisplayGPUResidentDrawer : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
        {
            static string k_FormatString = "{0}";
            static float k_RefreshRate = 0.20000000298023224;
            static int k_MaxViewCount = 32;
            static int k_MaxOcclusionPassCount = 32;
            static int k_MaxContextCount = 16;
            /*0x10*/ bool occluderDebugViewEnable;
            /*0x11*/ bool occluderContextStats;
            /*0x14*/ UnityEngine.Vector2 occluderDebugViewRange;
            /*0x1c*/ int occluderDebugViewIndex;

            static /*0x7beea7c*/ UnityEngine.Rendering.InstanceCullerViewStats GetInstanceCullerViewStats(int viewIndex);
            static /*0x7beeb5c*/ UnityEngine.Rendering.InstanceOcclusionEventStats GetInstanceOcclusionEventStats(int passIndex);
            static /*0x7beec4c*/ UnityEngine.Rendering.DebugOccluderStats GetOccluderStats(int occluderIndex);
            static /*0x7beed00*/ int GetOcclusionContextsCounts();
            static /*0x7beed5c*/ int GetInstanceCullerViewCount();
            static /*0x7beedb8*/ int GetInstanceOcclusionEventCount();
            static /*0x7beee14*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceCullerViewDataRow(int viewIndex);
            static /*0x7bef308*/ object OccluderVersionString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bef380*/ object OcclusionTestString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bef3f8*/ object VisibleInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bef464*/ object CulledInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bef4d0*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceOcclusionPassDataRow(int eventIndex);
            static /*0x7befb24*/ UnityEngine.Rendering.DebugUI.Table.Row AddOcclusionContextDataRow(int index);
            /*0x7bf0eb0*/ DebugDisplayGPUResidentDrawer();
            /*0x7bee83c*/ bool get_displayBatcherStats();
            /*0x7bee8c0*/ void set_displayBatcherStats(bool value);
            /*0x7bee8e0*/ bool GetOccluderViewInstanceID(ref int viewInstanceID);
            /*0x7bee9bc*/ bool get_occlusionTestOverlayEnable();
            /*0x7bee9dc*/ void set_occlusionTestOverlayEnable(bool value);
            /*0x7bee9fc*/ bool get_occlusionTestOverlayCountVisible();
            /*0x7beea1c*/ void set_occlusionTestOverlayCountVisible(bool value);
            /*0x7beea3c*/ bool get_overrideOcclusionTestToAlwaysPass();
            /*0x7beea5c*/ void set_overrideOcclusionTestToAlwaysPass(bool value);
            /*0x7befeb8*/ bool get_AreAnySettingsActive();
            /*0x7befed8*/ bool get_IsPostProcessingAllowed();
            /*0x7befee0*/ bool get_IsLightingActive();
            /*0x7befee8*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
            /*0x7befef0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

            class Strings
            {
                static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip displayBatcherStats;
                static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occlusionTestOverlayEnable;
                static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occlusionTestOverlayCountVisible;
                static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip overrideOcclusionTestToAlwaysPass;
                static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occluderContextStats;
                static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occluderDebugViewEnable;
                static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occluderDebugViewIndex;
                static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occluderDebugViewRangeMin;
                static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip occluderDebugViewRangeMax;

                static /*0x7bf0ec4*/ Strings();
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x7beff48*/ SettingsPanel(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x7bf12c4*/ string get_PanelName();
                /*0x7bf1304*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x7bf16fc*/ void AddInstanceCullingStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x7bf1314*/ void AddOcclusionContextStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer.SettingsPanel.<> <>9;
                    static /*0x8*/ System.Func<string> <>9__4_0;
                    static /*0x10*/ System.Func<bool> <>9__4_1;
                    static /*0x18*/ System.Func<bool> <>9__4_2;
                    static /*0x20*/ System.Func<int> <>9__4_16;
                    static /*0x28*/ System.Func<int> <>9__4_17;
                    static /*0x30*/ System.Func<bool> <>9__4_24;
                    static /*0x38*/ System.Func<object> <>9__5_1;
                    static /*0x40*/ System.Func<object> <>9__6_1;

                    static /*0x7bf1cd0*/ <>c();
                    /*0x7bf1d38*/ <>c();
                    /*0x7bf1d40*/ string <.ctor>b__4_0();
                    /*0x7bf2094*/ bool <.ctor>b__4_1();
                    /*0x7bf2134*/ bool <.ctor>b__4_2();
                    /*0x7bf2184*/ int <.ctor>b__4_16();
                    /*0x7bf218c*/ int <.ctor>b__4_17();
                    /*0x7bf21f0*/ bool <.ctor>b__4_24();
                    /*0x7bf2240*/ object <AddInstanceCullingStatsWidget>b__5_1();
                    /*0x7bf226c*/ object <AddOcclusionContextStatsWidget>b__6_1();
                }

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bf130c*/ <>c__DisplayClass4_0();
                    /*0x7bf2298*/ bool <.ctor>b__3();
                    /*0x7bf22c4*/ void <.ctor>b__4(bool value);
                    /*0x7bf22f0*/ bool <.ctor>b__5();
                    /*0x7bf231c*/ void <.ctor>b__6(bool value);
                    /*0x7bf2348*/ bool <.ctor>b__7();
                    /*0x7bf2374*/ void <.ctor>b__8(bool value);
                    /*0x7bf23a0*/ bool <.ctor>b__9();
                    /*0x7bf23bc*/ void <.ctor>b__10(bool value);
                    /*0x7bf23dc*/ bool <.ctor>b__11();
                    /*0x7bf23f8*/ void <.ctor>b__12(bool value);
                    /*0x7bf2418*/ int <.ctor>b__13();
                    /*0x7bf2434*/ void <.ctor>b__14(int value);
                    /*0x7bf2450*/ bool <.ctor>b__15();
                    /*0x7bf2474*/ float <.ctor>b__18();
                    /*0x7bf2490*/ void <.ctor>b__19(float value);
                    /*0x7bf24ac*/ bool <.ctor>b__20();
                    /*0x7bf24d0*/ float <.ctor>b__21();
                    /*0x7bf24ec*/ void <.ctor>b__22(float value);
                    /*0x7bf2508*/ bool <.ctor>b__23();
                    /*0x7bf252c*/ bool <.ctor>b__25();
                    /*0x7bf2558*/ void <.ctor>b__26(bool value);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bf1cc0*/ <>c__DisplayClass5_0();
                    /*0x7bf2584*/ bool <AddInstanceCullingStatsWidget>b__0();
                    /*0x7bf25b8*/ bool <AddInstanceCullingStatsWidget>b__2();
                    /*0x7bf25ec*/ bool <AddInstanceCullingStatsWidget>b__3();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bf1cc8*/ <>c__DisplayClass6_0();
                    /*0x7bf2620*/ bool <AddOcclusionContextStatsWidget>b__0();
                }
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ int viewIndex;

                /*0x7bef300*/ <>c__DisplayClass29_0();
                /*0x7bf2644*/ bool <AddInstanceCullerViewDataRow>b__0();
                /*0x7bf2660*/ object <AddInstanceCullerViewDataRow>b__1();
                /*0x7bf26c8*/ object <AddInstanceCullerViewDataRow>b__2();
                /*0x7bf2704*/ object <AddInstanceCullerViewDataRow>b__3();
                /*0x7bf2740*/ object <AddInstanceCullerViewDataRow>b__4();
                /*0x7bf277c*/ object <AddInstanceCullerViewDataRow>b__5();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ int eventIndex;

                /*0x7befb1c*/ <>c__DisplayClass34_0();
                /*0x7bf27b8*/ bool <AddInstanceOcclusionPassDataRow>b__0();
                /*0x7bf27d4*/ object <AddInstanceOcclusionPassDataRow>b__1();
                /*0x7bf2810*/ object <AddInstanceOcclusionPassDataRow>b__2();
                /*0x7bf28a8*/ object <AddInstanceOcclusionPassDataRow>b__3();
                /*0x7bf28dc*/ object <AddInstanceOcclusionPassDataRow>b__4();
                /*0x7bf2960*/ object <AddInstanceOcclusionPassDataRow>b__5();
                /*0x7bf29d8*/ object <AddInstanceOcclusionPassDataRow>b__6();
                /*0x7bf2a0c*/ object <AddInstanceOcclusionPassDataRow>b__7();
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int index;

                /*0x7befeb0*/ <>c__DisplayClass35_0();
                /*0x7bf2a40*/ bool <AddOcclusionContextDataRow>b__0();
                /*0x7bf2a5c*/ object <AddOcclusionContextDataRow>b__1();
                /*0x7bf2a8c*/ object <AddOcclusionContextDataRow>b__2();
                /*0x7bf2ac0*/ object <AddOcclusionContextDataRow>b__3();
            }
        }

        struct Line
        {
            /*0x10*/ Unity.Mathematics.float3 m;
            /*0x1c*/ Unity.Mathematics.float3 t;

            static /*0x7bf2b58*/ UnityEngine.Rendering.Line LineOfPlaneIntersectingPlane(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b);
            static /*0x7bf2bb0*/ Unity.Mathematics.float4 PlaneContainingLineAndPoint(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
            static /*0x7bf2c08*/ Unity.Mathematics.float4 PlaneContainingLineWithNormalPerpendicularToVector(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
        }

        struct ReceiverPlanes
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Plane> planes;
            /*0x18*/ int lightFacingPlaneCount;

            static /*0x7bf2c5c*/ bool IsSignBitSet(float x);
            static /*0x7bf2e1c*/ UnityEngine.Rendering.ReceiverPlanes Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            /*0x7bf2c68*/ Unity.Collections.NativeArray<UnityEngine.Plane> LightFacingFrustumPlaneSubArray();
            /*0x7bf2cf4*/ Unity.Collections.NativeArray<UnityEngine.Plane> SilhouettePlaneSubArray();
            /*0x7bf2dbc*/ void Dispose(Unity.Jobs.JobHandle job);
        }

        struct FrustumPlaneCuller
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets;
            /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos;

            static /*0x7bf3780*/ UnityEngine.Rendering.FrustumPlaneCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.NativeArray<UnityEngine.Plane> receiverPlanes, ref UnityEngine.Rendering.ReceiverSphereCuller receiverSphereCuller, Unity.Collections.Allocator allocator);
            static /*0x7bf3cd4*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets, Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos, ref UnityEngine.Rendering.AABB bounds);
            /*0x7bf36f0*/ void Dispose(Unity.Jobs.JobHandle job);

            struct PlanePacket4
            {
                /*0x10*/ Unity.Mathematics.float4 nx;
                /*0x20*/ Unity.Mathematics.float4 ny;
                /*0x30*/ Unity.Mathematics.float4 nz;
                /*0x40*/ Unity.Mathematics.float4 d;
                /*0x50*/ Unity.Mathematics.float4 nxAbs;
                /*0x60*/ Unity.Mathematics.float4 nyAbs;
                /*0x70*/ Unity.Mathematics.float4 nzAbs;

                /*0x7bf3c1c*/ PlanePacket4(Unity.Collections.NativeArray<UnityEngine.Plane> planes, int offset, int limit);
            }

            struct SplitInfo
            {
                /*0x10*/ int packetCount;
            }
        }

        struct ReceiverSphereCuller
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.ReceiverSphereCuller.SplitInfo> splitInfos;
            /*0x18*/ Unity.Mathematics.float3x3 worldToLightSpaceRotation;

            static /*0x7bf3f4c*/ UnityEngine.Rendering.ReceiverSphereCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            static /*0x7bf41dc*/ float DistanceUntilCylinderFullyCrossesPlane(Unity.Mathematics.float3 cylinderCenter, Unity.Mathematics.float3 cylinderDirection, float cylinderRadius, UnityEngine.Plane plane);
            static /*0x7bf430c*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Plane> lightFacingFrustumPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.ReceiverSphereCuller.SplitInfo> splitInfos, Unity.Mathematics.float3x3 worldToLightSpaceRotation, ref UnityEngine.Rendering.AABB bounds);
            /*0x7bf3eec*/ void Dispose(Unity.Jobs.JobHandle job);
            /*0x7bf3bb8*/ bool UseReceiverPlanes();

            struct SplitInfo
            {
                /*0x10*/ Unity.Mathematics.float4 receiverSphereLightSpace;
                /*0x20*/ float cascadeBlendCullingFactor;
            }
        }

        class GPUResidentBatcher : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.RenderersBatchersContext m_BatchersContext;
            /*0x18*/ UnityEngine.Rendering.GPUDrivenProcessor m_GPUDrivenProcessor;
            /*0x20*/ UnityEngine.Rendering.GPUDrivenRendererDataCallback m_UpdateRendererDataCallback;
            /*0x28*/ UnityEngine.Rendering.InstanceCullingBatcher m_InstanceCullingBatcher;
            /*0x30*/ UnityEngine.Rendering.ParallelBitArray m_ProcessedThisFrameTreeBits;

            /*0x7bf45d0*/ GPUResidentBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc instanceCullerBatcherDesc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor);
            /*0x7bf45a4*/ UnityEngine.Rendering.RenderersBatchersContext get_batchersContext();
            /*0x7bf45ac*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x7bf45c8*/ UnityEngine.Rendering.InstanceCullingBatcher get_instanceCullingBatcher();
            /*0x7bf472c*/ void Dispose();
            /*0x7bf4784*/ void OnBeginContextRendering();
            /*0x7bf47b4*/ void OnEndContextRendering();
            /*0x7bf47c8*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7bf47dc*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x7bf47f0*/ void UpdateFrame();
            /*0x7bf4820*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x7bf483c*/ void DestroyInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf4858*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x7bf4874*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs);
            /*0x7bf49a0*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            /*0x7bf4f5c*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x7bf4fd8*/ void UpdateRenderers(Unity.Collections.NativeArray<int> renderersID);
            /*0x7bf508c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x7bf50a8*/ void UpdateRendererData(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
            /*0x7bf52a4*/ void OnFinishedCulling(nint customCullingResult);
            /*0x7bf52d8*/ void ProcessTrees();
            /*0x7bf5624*/ void UpdateSpeedTreeWindAndUploadWindParamsToGPU(Unity.Collections.NativeArray<int> treeRendererIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> treeInstances, bool history);
        }

        class GPUResidentDrawer
        {
            static /*0x0*/ UnityEngine.Rendering.GPUResidentDrawer s_Instance;
            /*0x10*/ nint m_ContextIntPtr;
            /*0x18*/ UnityEngine.Rendering.GPUResidentDrawerSettings m_Settings;
            /*0x30*/ UnityEngine.Rendering.GPUDrivenProcessor m_GPUDrivenProcessor;
            /*0x38*/ UnityEngine.Rendering.RenderersBatchersContext m_BatchersContext;
            /*0x40*/ UnityEngine.Rendering.GPUResidentBatcher m_Batcher;
            /*0x48*/ UnityEngine.ObjectDispatcher m_Dispatcher;

            static /*0x7bf58bc*/ UnityEngine.Rendering.GPUResidentDrawer get_instance();
            static /*0x7bf5904*/ bool IsInstanceOcclusionCullingEnabled();
            static /*0x7bf596c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            static /*0x7bf59e4*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            static /*0x7bf5a80*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParameters, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            static /*0x7bf5b1c*/ void ReinitializeIfNeeded();
            static /*0x7bf5b20*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x7bf5bd8*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x7bee85c*/ UnityEngine.Rendering.DebugRendererBatcherStats GetDebugStats();
            static /*0x7bf20e4*/ bool IsEnabled();
            static /*0x7bf1d90*/ UnityEngine.Rendering.GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset();
            static /*0x7bf6540*/ bool IsForcedOnViaCommandLine();
            static /*0x7bf6548*/ bool IsOcclusionForcedOnViaCommandLine();
            static /*0x7bf6550*/ void Reinitialize();
            static /*0x7bf6644*/ void CleanUp();
            static /*0x7bf6574*/ void Recreate(UnityEngine.Rendering.GPUResidentDrawerSettings settings);
            static /*0x7bf6fa8*/ void PostPostLateUpdateStatic();
            static /*0x7bf7c44*/ bool IsProjectSupported(ref string message, ref UnityEngine.LogType severity);
            static /*0x7bf1ed8*/ bool IsGPUResidentDrawerSupportedBySRP(UnityEngine.Rendering.GPUResidentDrawerSettings settings, ref string message, ref UnityEngine.LogType severity);
            static /*0x7bf6e94*/ void LogMessage(string message, UnityEngine.LogType severity);
            /*0x7bf6964*/ GPUResidentDrawer(UnityEngine.Rendering.GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount);
            /*0x7bf5cb8*/ void InsertIntoPlayerLoop();
            /*0x7bf61d4*/ void RemoveFromPlayerLoop();
            /*0x7bf6f3c*/ UnityEngine.Rendering.GPUResidentBatcher get_batcher();
            /*0x7bf6f44*/ UnityEngine.Rendering.GPUResidentDrawerSettings get_settings();
            /*0x7bf66b8*/ void Dispose();
            /*0x7bf6f78*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x7bf733c*/ void OnBeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7bf7400*/ void OnEndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7bf74b8*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7bf74e8*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7bf7000*/ void PostPostLateUpdate();
            /*0x7bf7728*/ void ProcessMaterials(Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.NativeArray<int> unsupportedMaterials);
            /*0x7bf779c*/ void ProcessMeshes(Unity.Collections.NativeArray<int> destroyedID);
            /*0x7bf78d4*/ void ProcessLODGroups(Unity.Collections.NativeArray<int> changedID, Unity.Collections.NativeArray<int> destroyed, Unity.Collections.NativeArray<int> transformedID);
            /*0x7bf794c*/ void ProcessRenderers(UnityEngine.TypeDispatchData rendererChanges, Unity.Collections.NativeArray<int> unsupportedRenderers);
            /*0x7bf7c28*/ void TransformInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x7bf7b58*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> unsupportedRendererGroupIDs);
            /*0x7bf7b3c*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf7b20*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf7518*/ Unity.Collections.NativeList<int> FindUnsupportedMaterials(Unity.Collections.NativeArray<int> changedMaterialIDs);
            /*0x7bf75e4*/ Unity.Collections.NativeList<int> FindUnsupportedRenderers(Unity.Collections.NativeArray<int> unsupportedMaterials);

            struct FindUnsupportedMaterialsJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash;
                /*0x20*/ Unity.Collections.NativeArray<int> changedMaterialIDs;
                /*0x30*/ Unity.Collections.NativeList<int> unsupportedMaterialIDs;

                /*0x7bf7d04*/ void Execute();
            }

            struct FindUnsupportedRenderersJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray.ReadOnly<int> unsupportedMaterials;
                /*0x20*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays;
                /*0x30*/ Unity.Collections.NativeArray.ReadOnly<int> rendererGroups;
                /*0x40*/ Unity.Collections.NativeList<int> unsupportedRenderers;

                /*0x7bf8028*/ void Execute();
            }

            class Strings
            {
                static /*0x0*/ string drawerModeDisabled;
                static /*0x8*/ string allowInEditModeDisabled;
                static /*0x10*/ string notGPUResidentRenderPipeline;
                static /*0x18*/ string rawBufferNotSupportedByPlatform;
                static /*0x20*/ string kernelNotPresent;
                static /*0x28*/ string batchRendererGroupShaderStrippingModeInvalid;

                static /*0x7bf81fc*/ Strings();
            }
        }

        struct InstanceCullerViewStats
        {
            /*0x10*/ UnityEngine.Rendering.BatchCullingViewType viewType;
            /*0x14*/ int viewInstanceID;
            /*0x18*/ int splitIndex;
            /*0x1c*/ int visibleInstances;
            /*0x20*/ int drawCommands;
        }

        enum InstanceOcclusionEventType
        {
            OcclusionTest = 0,
            OccluderUpdate = 1,
        }

        struct InstanceOcclusionEventStats
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ UnityEngine.Rendering.InstanceOcclusionEventType eventType;
            /*0x18*/ int occluderVersion;
            /*0x1c*/ int subviewMask;
            /*0x20*/ UnityEngine.Rendering.OcclusionTest occlusionTest;
            /*0x24*/ int visibleInstances;
            /*0x28*/ int culledInstances;
        }

        struct DebugOccluderStats
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ int subviewCount;
            /*0x18*/ UnityEngine.Vector2Int occluderMipLayoutSize;
        }

        class DebugRendererBatcherStats : System.IDisposable
        {
            /*0x10*/ bool enabled;
            /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceCullerViewStats> instanceCullerStats;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceOcclusionEventStats> instanceOcclusionEventStats;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.DebugOccluderStats> occluderStats;
            /*0x30*/ bool occlusionOverlayEnabled;
            /*0x31*/ bool occlusionOverlayCountVisible;
            /*0x32*/ bool overrideOcclusionTestToAlwaysPass;

            /*0x7bf83b4*/ DebugRendererBatcherStats();
            /*0x7bf84b0*/ void Dispose();
        }

        struct OcclusionCullingDebugOutput
        {
            /*0x10*/ UnityEngine.Rendering.RTHandle occluderDepthPyramid;
            /*0x18*/ UnityEngine.GraphicsBuffer occlusionDebugOverlay;
            /*0x20*/ UnityEngine.Rendering.OcclusionCullingDebugShaderVariables cb;
        }

        class GPUResidentDrawerResources : UnityEngine.Rendering.IRenderPipelineResources, UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
            /*0x10*/ UnityEngine.Rendering.GPUResidentDrawerResources.Version m_Version;
            /*0x18*/ UnityEngine.ComputeShader m_InstanceDataBufferCopyKernels;
            /*0x20*/ UnityEngine.ComputeShader m_InstanceDataBufferUploadKernels;
            /*0x28*/ UnityEngine.ComputeShader m_TransformUpdaterKernels;
            /*0x30*/ UnityEngine.ComputeShader m_WindDataUpdaterKernels;
            /*0x38*/ UnityEngine.ComputeShader m_OccluderDepthPyramidKernels;
            /*0x40*/ UnityEngine.ComputeShader m_InstanceOcclusionCullingKernels;
            /*0x48*/ UnityEngine.ComputeShader m_OcclusionCullingDebugKernels;
            /*0x50*/ UnityEngine.Shader m_DebugOcclusionTestPS;
            /*0x58*/ UnityEngine.Shader m_DebugOccluderPS;

            /*0x7bf85d0*/ GPUResidentDrawerResources();
            /*0x7bf8580*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7bf8588*/ UnityEngine.ComputeShader get_instanceDataBufferCopyKernels();
            /*0x7bf8590*/ UnityEngine.ComputeShader get_instanceDataBufferUploadKernels();
            /*0x7bf8598*/ UnityEngine.ComputeShader get_transformUpdaterKernels();
            /*0x7bf85a0*/ UnityEngine.ComputeShader get_windDataUpdaterKernels();
            /*0x7bf85a8*/ UnityEngine.ComputeShader get_occluderDepthPyramidKernels();
            /*0x7bf85b0*/ UnityEngine.ComputeShader get_instanceOcclusionCullingKernels();
            /*0x7bf85b8*/ UnityEngine.ComputeShader get_occlusionCullingDebugKernels();
            /*0x7bf85c0*/ UnityEngine.Shader get_debugOcclusionTestPS();
            /*0x7bf85c8*/ UnityEngine.Shader get_debugOccluderPS();

            enum Version
            {
                Initial = 0,
                Count = 1,
                Latest = 0,
            }
        }

        struct RenderRequestBatcherContext
        {
            /*0x10*/ UnityEngine.Rendering.CommandBuffer commandBuffer;
        }

        enum OcclusionTest
        {
            None = 0,
            TestAll = 1,
            TestCulled = 2,
        }

        class OcclusionTestMethods
        {
            static /*0x7bf85d8*/ uint GetBatchLayerMask(UnityEngine.Rendering.OcclusionTest occlusionTest);
        }

        struct SubviewOcclusionTest
        {
            /*0x10*/ int cullingSplitIndex;
            /*0x14*/ int occluderSubviewIndex;
        }

        struct OcclusionCullingSettings
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ UnityEngine.Rendering.OcclusionTest occlusionTest;
            /*0x18*/ int instanceMultiplier;

            /*0x7bf85e8*/ OcclusionCullingSettings(int viewInstanceID, UnityEngine.Rendering.OcclusionTest occlusionTest);
        }

        struct OccluderSubviewUpdate
        {
            /*0x10*/ int subviewIndex;
            /*0x14*/ int depthSliceIndex;
            /*0x18*/ UnityEngine.Vector2Int depthOffset;
            /*0x20*/ UnityEngine.Matrix4x4 viewMatrix;
            /*0x60*/ UnityEngine.Matrix4x4 invViewMatrix;
            /*0xa0*/ UnityEngine.Matrix4x4 gpuProjMatrix;
            /*0xe0*/ UnityEngine.Vector3 viewOffsetWorldSpace;

            /*0x7bf85f8*/ OccluderSubviewUpdate(int subviewIndex);
        }

        struct OccluderParameters
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ int subviewCount;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture;
            /*0x28*/ UnityEngine.Vector2Int depthSize;
            /*0x30*/ bool depthIsArray;

            /*0x7bf86f4*/ OccluderParameters(int viewInstanceID);
        }

        enum GPUResidentDrawerMode
        {
            Disabled = 0,
            InstancedDrawing = 1,
        }

        struct GPUResidentDrawerSettings
        {
            /*0x10*/ UnityEngine.Rendering.GPUResidentDrawerMode mode;
            /*0x11*/ bool supportDitheringCrossFade;
            /*0x12*/ bool enableOcclusionCulling;
            /*0x13*/ bool allowInEditMode;
            /*0x14*/ float smallMeshScreenPercentage;
            /*0x18*/ UnityEngine.Shader errorShader;
            /*0x20*/ UnityEngine.Shader loadingShader;
        }

        interface IGPUResidentRenderPipeline
        {
            static /*0x7bf87d4*/ void ReinitializeGPUResidentDrawer();
            UnityEngine.Rendering.GPUResidentDrawerSettings get_gpuResidentDrawerSettings();
            /*0x7bf87f8*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severity);
        }

        struct RangeKey : System.IEquatable<UnityEngine.Rendering.RangeKey>
        {
            /*0x10*/ byte layer;
            /*0x14*/ uint renderingLayerMask;
            /*0x18*/ UnityEngine.MotionVectorGenerationMode motionMode;
            /*0x1c*/ UnityEngine.Rendering.ShadowCastingMode shadowCastingMode;
            /*0x20*/ bool staticShadowCaster;
            /*0x24*/ int rendererPriority;
            /*0x28*/ bool supportsIndirect;

            /*0x7bf8838*/ bool Equals(UnityEngine.Rendering.RangeKey other);
            /*0x7bf88bc*/ int GetHashCode();
        }

        struct DrawRange
        {
            /*0x10*/ UnityEngine.Rendering.RangeKey key;
            /*0x2c*/ int drawCount;
            /*0x30*/ int drawOffset;
        }

        struct DrawKey : System.IEquatable<UnityEngine.Rendering.DrawKey>
        {
            /*0x10*/ UnityEngine.Rendering.BatchMeshID meshID;
            /*0x14*/ int submeshIndex;
            /*0x18*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x1c*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x20*/ int transparentInstanceId;
            /*0x24*/ uint overridenComponents;
            /*0x28*/ UnityEngine.Rendering.RangeKey range;
            /*0x44*/ int lightmapIndex;

            /*0x7bf8900*/ bool Equals(UnityEngine.Rendering.DrawKey other);
            /*0x7bf8a50*/ int GetHashCode();
        }

        struct DrawBatch
        {
            /*0x10*/ UnityEngine.Rendering.DrawKey key;
            /*0x48*/ int instanceCount;
            /*0x4c*/ int instanceOffset;
            /*0x50*/ UnityEngine.Rendering.MeshProceduralInfo procInfo;
        }

        struct DrawInstance
        {
            /*0x10*/ UnityEngine.Rendering.DrawKey key;
            /*0x48*/ int instanceIndex;
        }

        struct BinningConfig
        {
            /*0x10*/ int viewCount;
            /*0x14*/ bool supportsCrossFade;
            /*0x15*/ bool supportsMotionCheck;

            /*0x7bf8ac0*/ int get_visibilityConfigCount();
        }

        struct CullingJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ UnityEngine.Rendering.BinningConfig binningConfig;
            /*0x18*/ UnityEngine.Rendering.BatchCullingViewType viewType;
            /*0x1c*/ Unity.Mathematics.float3 cameraPosition;
            /*0x28*/ float sqrScreenRelativeMetric;
            /*0x2c*/ float minScreenRelativeHeight;
            /*0x30*/ bool isOrtho;
            /*0x31*/ bool cullLightmappedShadowCasters;
            /*0x34*/ int maxLOD;
            /*0x38*/ uint cullingLayerMask;
            /*0x40*/ ulong sceneCullingMask;
            /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> frustumPlanePackets;
            /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> frustumSplitInfos;
            /*0x68*/ Unity.Collections.NativeArray<UnityEngine.Plane> lightFacingFrustumPlanes;
            /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ReceiverSphereCuller.SplitInfo> receiverSplitInfos;
            /*0x88*/ Unity.Mathematics.float3x3 worldToLightSpaceRotation;
            /*0xb0*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
            /*0x188*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData;
            /*0x228*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData;
            /*0x230*/ nint occlusionBuffer;
            /*0x238*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x248*/ Unity.Collections.NativeArray<byte> rendererCrossFadeValues;

            static /*0x7bf8ae4*/ uint PackFloatToUint8(float percent);
            /*0x7bf8b44*/ float CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x7bf8ff8*/ uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x7bf9188*/ void Execute(int instanceIndex);

            enum CrossFadeType
            {
                kDisabled = 0,
                kCrossFadeOut = 1,
                kCrossFadeIn = 2,
                kVisible = 3,
            }
        }

        struct AllocateBinsPerBatch : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ UnityEngine.Rendering.BinningConfig binningConfig;
            /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x20*/ Unity.Collections.NativeArray<int> drawInstanceIndices;
            /*0x30*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
            /*0x108*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x118*/ Unity.Collections.NativeArray<int> batchBinAllocOffsets;
            /*0x128*/ Unity.Collections.NativeArray<int> batchBinCounts;
            /*0x138*/ Unity.Collections.NativeArray<int> binAllocCounter;
            /*0x148*/ Unity.Collections.NativeArray<short> binConfigIndices;
            /*0x158*/ Unity.Collections.NativeArray<int> binVisibleInstanceCounts;
            /*0x168*/ int debugCounterIndexBase;
            /*0x170*/ Unity.Collections.NativeArray<int> splitDebugCounters;

            /*0x7bf9354*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x7bf93fc*/ void Execute(int batchIndex);
        }

        struct PrefixSumDrawsAndInstances : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x18*/ Unity.Collections.NativeArray<int> drawBatchIndices;
            /*0x28*/ Unity.Collections.NativeArray<int> batchBinAllocOffsets;
            /*0x38*/ Unity.Collections.NativeArray<int> batchBinCounts;
            /*0x48*/ Unity.Collections.NativeArray<int> binVisibleInstanceCounts;
            /*0x58*/ Unity.Collections.NativeArray<int> batchDrawCommandOffsets;
            /*0x68*/ Unity.Collections.NativeArray<int> binVisibleInstanceOffsets;
            /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> cullingOutput;
            /*0x88*/ UnityEngine.Rendering.IndirectBufferLimits indirectBufferLimits;
            /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> indirectBufferAllocInfo;
            /*0xa0*/ Unity.Collections.NativeArray<int> indirectAllocationCounters;

            /*0x7bf9978*/ void Execute();
        }

        struct DrawCommandOutputPerBatch : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ UnityEngine.Rendering.BinningConfig binningConfig;
            /*0x18*/ Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> batchIDs;
            /*0x28*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly instanceDataBuffer;
            /*0x38*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x40*/ Unity.Collections.NativeArray<int> drawInstanceIndices;
            /*0x50*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
            /*0x128*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x138*/ Unity.Collections.NativeArray<byte> rendererCrossFadeValues;
            /*0x148*/ Unity.Collections.NativeArray<int> batchBinAllocOffsets;
            /*0x158*/ Unity.Collections.NativeArray<int> batchBinCounts;
            /*0x168*/ Unity.Collections.NativeArray<int> batchDrawCommandOffsets;
            /*0x178*/ Unity.Collections.NativeArray<short> binConfigIndices;
            /*0x188*/ Unity.Collections.NativeArray<int> binVisibleInstanceOffsets;
            /*0x198*/ Unity.Collections.NativeArray<int> binVisibleInstanceCounts;
            /*0x1a8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> cullingOutput;
            /*0x1b8*/ UnityEngine.Rendering.IndirectBufferLimits indirectBufferLimits;
            /*0x1c0*/ UnityEngine.GraphicsBufferHandle visibleInstancesBufferHandle;
            /*0x1c4*/ UnityEngine.GraphicsBufferHandle indirectArgsBufferHandle;
            /*0x1c8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> indirectBufferAllocInfo;
            /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectDrawInfo> indirectDrawInfoGlobalArray;
            /*0x1e8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectInstanceInfo> indirectInstanceInfoGlobalArray;

            /*0x7bf9e34*/ int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade);
            /*0x7bf9f00*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x7bf9fa8*/ void Execute(int batchIndex);
        }

        struct CompactVisibilityMasksJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x20*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;

            /*0x7bfa688*/ void Execute(int startIndex, int count);
        }

        struct InstanceCullerSplitDebugArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceCullerSplitDebugArray.Info> m_Info;
            /*0x18*/ Unity.Collections.NativeArray<int> m_Counters;
            /*0x28*/ Unity.Collections.NativeQueue<Unity.Jobs.JobHandle> m_CounterSync;

            /*0x7bfa6f4*/ Unity.Collections.NativeArray<int> get_Counters();
            /*0x7bfa700*/ void Init();
            /*0x7bfa7ec*/ void Dispose();
            /*0x7bfa87c*/ int TryAddSplits(UnityEngine.Rendering.BatchCullingViewType viewType, int viewInstanceID, int splitCount);
            /*0x7bfa964*/ void AddSync(int baseIndex, Unity.Jobs.JobHandle jobHandle);
            /*0x7bfa9e0*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

            struct Info
            {
                /*0x10*/ UnityEngine.Rendering.BatchCullingViewType viewType;
                /*0x14*/ int viewInstanceID;
                /*0x18*/ int splitIndex;
            }
        }

        struct InstanceOcclusionEventDebugArray : System.IDisposable
        {
            /*0x10*/ UnityEngine.GraphicsBuffer m_CounterBuffer;
            /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Rendering.InstanceOcclusionEventDebugArray.Info> m_PendingInfo;
            /*0x30*/ Unity.Collections.NativeQueue<UnityEngine.Rendering.InstanceOcclusionEventDebugArray.Request> m_Requests;
            /*0x38*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Rendering.InstanceOcclusionEventDebugArray.Info> m_LatestInfo;
            /*0x50*/ Unity.Collections.NativeArray<int> m_LatestCounters;
            /*0x60*/ bool m_HasLatest;

            /*0x7bfabf0*/ UnityEngine.GraphicsBuffer get_CounterBuffer();
            /*0x7bfabf8*/ void Init();
            /*0x7bfad04*/ void Dispose();
            /*0x7bfae40*/ int TryAdd(int viewInstanceID, UnityEngine.Rendering.InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, UnityEngine.Rendering.OcclusionTest occlusionTest);
            /*0x7bfaf54*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

            struct Info
            {
                /*0x10*/ int viewInstanceID;
                /*0x14*/ UnityEngine.Rendering.InstanceOcclusionEventType eventType;
                /*0x18*/ int occluderVersion;
                /*0x1c*/ int subviewMask;
                /*0x20*/ UnityEngine.Rendering.OcclusionTest occlusionTest;

                /*0x7bfb3e4*/ bool HasVersion();
            }

            struct Request
            {
                /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Rendering.InstanceOcclusionEventDebugArray.Info> info;
                /*0x28*/ UnityEngine.Rendering.AsyncGPUReadbackRequest readback;
            }
        }

        struct InstanceCuller : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.ParallelBitArray m_CompactedVisibilityMasks;
            /*0x30*/ Unity.Jobs.JobHandle m_CompactedVisibilityMasksJobsHandle;
            /*0x40*/ UnityEngine.Rendering.IndirectBufferContextStorage m_IndirectStorage;
            /*0xc0*/ UnityEngine.Rendering.OcclusionTestComputeShader m_OcclusionTestShader;
            /*0xe0*/ int m_ResetDrawArgsKernel;
            /*0xe4*/ int m_CopyInstancesKernel;
            /*0xe8*/ int m_CullInstancesKernel;
            /*0xf0*/ UnityEngine.Rendering.DebugRendererBatcherStats m_DebugStats;
            /*0xf8*/ UnityEngine.Rendering.InstanceCullerSplitDebugArray m_SplitDebugArray;
            /*0x118*/ UnityEngine.Rendering.InstanceOcclusionEventDebugArray m_OcclusionEventDebugArray;
            /*0x170*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampleInstanceOcclusionTest;
            /*0x178*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceOcclusionCullerShaderVariables> m_ShaderVariables;
            /*0x188*/ UnityEngine.ComputeBuffer m_ConstantBuffer;
            /*0x190*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;

            /*0x7bfb408*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources, UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x7bfb680*/ Unity.Jobs.JobHandle CreateFrustumCullingJob(ref UnityEngine.Rendering.BatchCullingContext cc, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref UnityEngine.Rendering.BinningConfig binningConfig, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Collections.NativeArray<byte> rendererCrossFadeValues);
            /*0x7bfbad8*/ int ComputeWorstCaseDrawCommandCount(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BinningConfig binningConfig, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, int crossFadedRendererCount);
            /*0x7bfbbc4*/ Unity.Jobs.JobHandle CreateCullJobTree(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, ref UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly instanceDataBuffer, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> batchIDs, int crossFadedRendererCount, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon);
            /*0x7bfc54c*/ Unity.Jobs.JobHandle CreateCompactedVisibilityMaskJob(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Jobs.JobHandle cullingJobHandle);
            /*0x7bfc654*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7bfc6dc*/ void DisposeCompactVisibilityMasks();
            /*0x7bfc708*/ void DisposeSceneViewHiddenBits();
            /*0x7bfc70c*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x7bf4a1c*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7bfc740*/ void EnsureValidOcclusionTestResults(int viewInstanceID);
            /*0x7bfc9e8*/ void AddOcclusionCullingDispatch(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles, ref UnityEngine.Rendering.OccluderHandles occluderHandles, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7bfd3f8*/ void FlushDebugCounters();
            /*0x7bfd430*/ void OnBeginSceneViewCameraRendering();
            /*0x7bfd434*/ void OnEndSceneViewCameraRendering();
            /*0x7bfd438*/ void UpdateFrame();
            /*0x7bfd470*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7bfd488*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x7bfd4a0*/ void Dispose();

            class ShaderIDs
            {
                static /*0x0*/ int InstanceOcclusionCullerShaderVariables;
                static /*0x4*/ int _DrawInfo;
                static /*0x8*/ int _InstanceInfo;
                static /*0xc*/ int _DrawArgs;
                static /*0x10*/ int _InstanceIndices;
                static /*0x14*/ int _InstanceDataBuffer;
                static /*0x18*/ int _OccluderDepthPyramid;
                static /*0x1c*/ int _OcclusionDebugCounters;

                static /*0x7bfd558*/ ShaderIDs();
            }

            struct SetupCullingJobInput : Unity.Jobs.IJob
            {
                /*0x10*/ float lodBias;
                /*0x18*/ UnityEngine.Rendering.BatchCullingContext* context;
                /*0x20*/ UnityEngine.Rendering.ReceiverPlanes* receiverPlanes;
                /*0x28*/ UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller;
                /*0x30*/ UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller;
                /*0x38*/ float* screenRelativeMetric;

                /*0x7bfd714*/ void Execute();
            }

            class InstanceOcclusionTestPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingSettings settings;
                /*0x1c*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings;
                /*0x30*/ UnityEngine.Rendering.OccluderHandles occluderHandles;
                /*0x4c*/ UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles;

                /*0x7bfd800*/ InstanceOcclusionTestPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.InstanceCuller.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__26_0;

                static /*0x7bfd808*/ <>c();
                /*0x7bfd870*/ <>c();
                /*0x7bfd878*/ void <InstanceOcclusionTest>b__26_0(UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
            }
        }

        class OnCullingCompleteCallback : System.MulticastDelegate
        {
            /*0x7bfd908*/ OnCullingCompleteCallback(object object, nint method);
            /*0x7bfd9a8*/ void Invoke(Unity.Jobs.JobHandle jobHandle, ref UnityEngine.Rendering.BatchCullingContext cullingContext, ref UnityEngine.Rendering.BatchCullingOutput cullingOutput);
        }

        struct InstanceCullingBatcherDesc
        {
            /*0x10*/ UnityEngine.Rendering.OnCullingCompleteCallback onCompleteCallback;

            static /*0x7bf6f58*/ UnityEngine.Rendering.InstanceCullingBatcherDesc NewDefault();
        }

        struct MeshProceduralInfo
        {
            /*0x10*/ UnityEngine.MeshTopology topology;
            /*0x14*/ uint baseVertex;
            /*0x18*/ uint firstIndex;
            /*0x1c*/ uint indexCount;
        }

        struct PrefixSumDrawInstancesJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x30*/ Unity.Collections.NativeArray<int> drawBatchIndices;

            /*0x7bfd9bc*/ void Execute();
        }

        struct BuildDrawListsJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x30*/ Unity.Collections.NativeArray<int> internalDrawIndex;
            /*0x40*/ Unity.Collections.NativeArray<int> drawInstanceIndices;

            static /*0x7bfdc28*/ int IncrementCounter(int* counter);
            /*0x7bfdc70*/ void Execute(int index);
        }

        struct FindDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instancesSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x7bfdda0*/ void Execute(int startIndex, int count);
        }

        struct FindMaterialDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<uint> materialsSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x7bfdf24*/ void Execute(int startIndex, int count);
        }

        struct FindNonRegisteredInstancesJob<T> : Unity.Jobs.IJobParallelForBatch
        {
            /*0x0*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x0*/ Unity.Collections.NativeParallelHashMap<int, T> hashMap;
            /*0x0*/ Unity.Collections.NativeList.ParallelWriter<int> outInstancesWriter;

            /*0x3815fb8*/ void Execute(int startIndex, int count);
        }

        struct RegisterNewInstancesJob<T> : Unity.Jobs.IJobParallelFor
        {
            /*0x0*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x0*/ Unity.Collections.NativeArray<T> batchIDs;
            /*0x0*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<int, T> hashMap;

            /*0x3815ed0*/ void Execute(int index);
        }

        struct RemoveDrawInstanceIndicesJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> drawInstanceIndices;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash;
            /*0x38*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x48*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x50*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;

            /*0x7bfe064*/ void RemoveDrawRange(ref UnityEngine.Rendering.RangeKey key);
            /*0x7bfe208*/ void RemoveDrawBatch(ref UnityEngine.Rendering.DrawKey key);
            /*0x7bfe454*/ void Execute();
        }

        struct CreateDrawBatchesJob : Unity.Jobs.IJob
        {
            /*0x10*/ bool implicitInstanceIndices;
            /*0x18*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
            /*0x28*/ UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData;
            /*0x1e8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash;
            /*0x1f8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash;
            /*0x208*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash;
            /*0x218*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x220*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x230*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x238*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;

            /*0x7bfe600*/ ref UnityEngine.Rendering.DrawRange EditDrawRange(ref UnityEngine.Rendering.RangeKey key);
            /*0x7bfe788*/ ref UnityEngine.Rendering.DrawBatch EditDrawBatch(ref UnityEngine.Rendering.DrawKey key, ref UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor);
            /*0x7bfe948*/ void ProcessRenderer(int i);
            /*0x7bfeeb4*/ void Execute();
        }

        class CPUDrawInstanceData
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> m_RangeHash;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> m_DrawRanges;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> m_BatchHash;
            /*0x38*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> m_DrawBatches;
            /*0x40*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> m_DrawInstances;
            /*0x48*/ Unity.Collections.NativeList<int> m_DrawInstanceIndices;
            /*0x50*/ Unity.Collections.NativeList<int> m_DrawBatchIndices;
            /*0x58*/ bool m_NeedsRebuild;

            /*0x7bffb78*/ CPUDrawInstanceData();
            /*0x7bfeef8*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> get_drawInstances();
            /*0x7bfef00*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> get_batchHash();
            /*0x7bfef0c*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> get_drawBatches();
            /*0x7bfef14*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> get_rangeHash();
            /*0x7bfef20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> get_drawRanges();
            /*0x7bfef28*/ Unity.Collections.NativeArray<int> get_drawBatchIndices();
            /*0x7bfef70*/ Unity.Collections.NativeArray<int> get_drawInstanceIndices();
            /*0x7bfefb8*/ void Initialize();
            /*0x7bff1a8*/ void Dispose();
            /*0x7bff350*/ void RebuildDrawListsIfNeeded();
            /*0x7bff5cc*/ void DestroyDrawInstanceIndices(Unity.Collections.NativeArray<int> drawInstanceIndicesToDestroy);
            /*0x7bff674*/ void DestroyDrawInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> destroyedInstances);
            /*0x7bff8fc*/ void DestroyMaterialDrawInstances(Unity.Collections.NativeArray<uint> destroyedBatchMaterials);
            /*0x7bff8f0*/ void NeedsRebuild();
        }

        class InstanceCullingBatcher : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.RenderersBatchersContext m_BatchersContext;
            /*0x18*/ UnityEngine.Rendering.CPUDrawInstanceData m_DrawInstanceData;
            /*0x20*/ UnityEngine.Rendering.BatchRendererGroup m_BRG;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> m_GlobalBatchIDs;
            /*0x38*/ UnityEngine.Rendering.InstanceCuller m_Culler;
            /*0x1c0*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> m_BatchMaterialHash;
            /*0x1d0*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> m_BatchMeshHash;
            /*0x1e0*/ int m_CachedInstanceDataBufferLayoutVersion;
            /*0x1e8*/ UnityEngine.Rendering.OnCullingCompleteCallback m_OnCompleteCallback;

            /*0x7bffb8c*/ InstanceCullingBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc desc, UnityEngine.Rendering.BatchRendererGroup.OnFinishedCulling onFinishedCulling);
            /*0x7bffb80*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> get_batchMaterialHash();
            /*0x7c00148*/ ref UnityEngine.Rendering.InstanceCuller get_culler();
            /*0x7c00150*/ void Dispose();
            /*0x7bffefc*/ UnityEngine.Rendering.BatchID GetBatchID(UnityEngine.Rendering.InstanceComponentGroup componentsOverriden);
            /*0x7c00460*/ void UpdateInstanceDataBufferLayoutVersion();
            /*0x7c00748*/ Unity.Jobs.JobHandle OnPerformCulling(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            /*0x7c00b34*/ void OnFinishedCulling(nint customCullingResult);
            /*0x7c00b60*/ void DestroyInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c00b84*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x7c00e50*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x7c0105c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x7c01060*/ void RegisterBatchMeshes(Unity.Collections.NativeArray<int> meshIDs);
            /*0x7c0149c*/ void RegisterBatchMaterials(ref Unity.Collections.NativeArray<int> usedMaterialIDs);
            /*0x7c01904*/ void BuildBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<int> usedMaterialIDs, Unity.Collections.NativeArray<int> usedMeshIDs, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData);
            /*0x7c01ac0*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask);
            /*0x7c01ad0*/ void UpdateFrame();
            /*0x7c01adc*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x7c01b10*/ void OnEndContextRendering();
            /*0x7c01b74*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7c01b80*/ void OnEndCameraRendering(UnityEngine.Camera camera);
        }

        struct GPUInstanceComponentDesc
        {
            /*0x10*/ int propertyID;
            /*0x14*/ int byteSize;
            /*0x18*/ bool isOverriden;
            /*0x19*/ bool isPerInstance;
            /*0x1c*/ UnityEngine.Rendering.InstanceType instanceType;
            /*0x20*/ UnityEngine.Rendering.InstanceComponentGroup componentGroup;

            /*0x7c01b8c*/ GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, UnityEngine.Rendering.InstanceType inInstanceType, UnityEngine.Rendering.InstanceComponentGroup inComponentType);
        }

        class GPUInstanceDataBuffer : System.IDisposable
        {
            static /*0x0*/ int s_NextLayoutVersion;
            /*0x10*/ UnityEngine.Rendering.InstanceNumInfo instanceNumInfo;
            /*0x18*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;
            /*0x28*/ Unity.Collections.NativeArray<int> instancesSpan;
            /*0x38*/ int byteSize;
            /*0x3c*/ int perInstanceComponentCount;
            /*0x40*/ int version;
            /*0x44*/ int layoutVersion;
            /*0x48*/ UnityEngine.GraphicsBuffer gpuBuffer;
            /*0x50*/ UnityEngine.GraphicsBuffer validComponentsIndicesGpuBuffer;
            /*0x58*/ UnityEngine.GraphicsBuffer componentAddressesGpuBuffer;
            /*0x60*/ UnityEngine.GraphicsBuffer componentInstanceIndexRangesGpuBuffer;
            /*0x68*/ UnityEngine.GraphicsBuffer componentByteCountsGpuBuffer;
            /*0x70*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceComponentDesc> descriptions;
            /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> defaultMetadata;
            /*0x90*/ Unity.Collections.NativeArray<int> gpuBufferComponentAddress;
            /*0xa0*/ Unity.Collections.NativeParallelHashMap<int, int> nameToMetadataMap;

            static /*0x7c01ba8*/ int NextVersion();
            static /*0x7c01bf8*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(ref Unity.Collections.NativeArray<int> instancesNumPrefixSum, UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c02108*/ GPUInstanceDataBuffer();
            /*0x7c01e00*/ int GetPropertyIndex(int propertyID, bool assertOnFail);
            /*0x7c01e70*/ int GetGpuAddress(int propertyID, bool assertOnFail);
            /*0x7c01e98*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x7c01f40*/ void Dispose();
            /*0x7c020d0*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly AsReadOnly();

            struct ReadOnly
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;

                /*0x7c020ec*/ ReadOnly(UnityEngine.Rendering.GPUInstanceDataBuffer buffer);
                /*0x7c02110*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(UnityEngine.Rendering.InstanceHandle instance);
                /*0x7c02128*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            }

            struct ConvertCPUInstancesToGPUInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices;

                /*0x7c021d8*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferBuilder : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceComponentDesc> m_Components;

            /*0x7c02208*/ UnityEngine.Rendering.MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden);
            /*0x3910ae8*/ void AddComponent<T>(int propertyID, bool isOverriden, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x7c02224*/ void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x7c0234c*/ UnityEngine.Rendering.GPUInstanceDataBuffer Build(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7c02d9c*/ void Dispose();
        }

        struct GPUInstanceDataBufferUploader : System.IDisposable
        {
            /*0x10*/ int m_UintPerInstance;
            /*0x14*/ int m_Capacity;
            /*0x18*/ int m_InstanceCount;
            /*0x20*/ Unity.Collections.NativeArray<bool> m_ComponentIsInstanced;
            /*0x30*/ Unity.Collections.NativeArray<int> m_ComponentDataIndex;
            /*0x40*/ Unity.Collections.NativeArray<int> m_DescriptionsUintSize;
            /*0x50*/ Unity.Collections.NativeArray<uint> m_TmpDataBuffer;
            /*0x60*/ Unity.Collections.NativeList<int> m_WritenComponentIndices;
            /*0x68*/ Unity.Collections.NativeArray<int> m_DummyArray;

            /*0x7c02e04*/ GPUInstanceDataBufferUploader(ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceComponentDesc> descriptions, int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c03070*/ nint GetUploadBufferPtr();
            /*0x7c030b8*/ int GetUIntPerInstance();
            /*0x7c030c0*/ int GetParamUIntOffset(int parameterIndex);
            /*0x38145a0*/ int PrepareParamWrite<T>(int parameterIndex);
            /*0x7c030cc*/ void AllocateUploadHandles(int handlesLength);
            /*0x3910ae8*/ Unity.Jobs.JobHandle WriteInstanceDataJob<T>(int parameterIndex, Unity.Collections.NativeArray<T> instanceData, Unity.Collections.NativeArray<int> gatherIndices);
            /*0x7c030d4*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x7c0376c*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x7c03850*/ void Dispose();

            class UploadKernelIDs
            {
                static /*0x0*/ int _InputValidComponentCounts;
                static /*0x4*/ int _InputInstanceCounts;
                static /*0x8*/ int _InputInstanceByteSize;
                static /*0xc*/ int _InputComponentOffsets;
                static /*0x10*/ int _InputInstanceData;
                static /*0x14*/ int _InputInstanceIndices;
                static /*0x18*/ int _InputValidComponentIndices;
                static /*0x1c*/ int _InputComponentAddresses;
                static /*0x20*/ int _InputComponentByteCounts;
                static /*0x24*/ int _InputComponentInstanceIndexRanges;
                static /*0x28*/ int _OutputBuffer;

                static /*0x7c0397c*/ UploadKernelIDs();
            }

            struct GPUResources : System.IDisposable
            {
                /*0x10*/ UnityEngine.ComputeBuffer instanceData;
                /*0x18*/ UnityEngine.ComputeBuffer instanceIndices;
                /*0x20*/ UnityEngine.ComputeBuffer inputComponentOffsets;
                /*0x28*/ UnityEngine.ComputeBuffer validComponentIndices;
                /*0x30*/ UnityEngine.ComputeShader cs;
                /*0x38*/ int kernelId;
                /*0x3c*/ int m_InstanceDataByteSize;
                /*0x40*/ int m_InstanceCount;
                /*0x44*/ int m_ComponentCounts;
                /*0x48*/ int m_ValidComponentIndicesCount;

                /*0x7c03bbc*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x7c03590*/ void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount);
                /*0x7c03c78*/ void Dispose();
            }

            struct WriteInstanceDataParameterJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ bool gatherData;
                /*0x14*/ int parameterIndex;
                /*0x18*/ int uintPerParameter;
                /*0x1c*/ int uintPerInstance;
                /*0x20*/ Unity.Collections.NativeArray<int> componentDataIndex;
                /*0x30*/ Unity.Collections.NativeArray<int> gatherIndices;
                /*0x40*/ Unity.Collections.NativeArray<uint> instanceData;
                /*0x50*/ Unity.Collections.NativeArray<uint> tmpDataBuffer;

                /*0x7c03cd8*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferGrower : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_SrcBuffer;
            /*0x18*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_DstBuffer;

            /*0x7c03d9c*/ GPUInstanceDataBufferGrower(UnityEngine.Rendering.GPUInstanceDataBuffer sourceBuffer, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7c03fd4*/ UnityEngine.Rendering.GPUInstanceDataBuffer SubmitToGpu(ref UnityEngine.Rendering.GPUInstanceDataBufferGrower.GPUResources gpuResources);
            /*0x7c042cc*/ void Dispose();

            class CopyInstancesKernelIDs
            {
                static /*0x0*/ int _InputValidComponentCounts;
                static /*0x4*/ int _InstanceCounts;
                static /*0x8*/ int _InstanceOffset;
                static /*0xc*/ int _OutputInstanceOffset;
                static /*0x10*/ int _ValidComponentIndices;
                static /*0x14*/ int _ComponentByteCounts;
                static /*0x18*/ int _InputComponentAddresses;
                static /*0x1c*/ int _OutputComponentAddresses;
                static /*0x20*/ int _InputComponentInstanceIndexRanges;
                static /*0x24*/ int _InputBuffer;
                static /*0x28*/ int _OutputBuffer;

                static /*0x7c042d0*/ CopyInstancesKernelIDs();
            }

            struct GPUResources : System.IDisposable
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelId;

                /*0x7c04510*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x7c042c0*/ void CreateResources();
                /*0x7c045c8*/ void Dispose();
            }
        }

        struct InstanceHandle : System.IEquatable<UnityEngine.Rendering.InstanceHandle>, System.IComparable<UnityEngine.Rendering.InstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.InstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7c0476c*/ InstanceHandle();
            static /*0x7c045e4*/ UnityEngine.Rendering.InstanceHandle FromInt(int value);
            /*0x7c045d4*/ int get_index();
            /*0x7c045dc*/ void set_index(int value);
            /*0x7c01da8*/ int get_instanceIndex();
            /*0x7c01d50*/ UnityEngine.Rendering.InstanceType get_type();
            /*0x7c01cf4*/ bool get_valid();
            /*0x7c04638*/ bool Equals(UnityEngine.Rendering.InstanceHandle other);
            /*0x7c046a0*/ int CompareTo(UnityEngine.Rendering.InstanceHandle other);
            /*0x7c04718*/ int GetHashCode();
        }

        struct SharedInstanceHandle : System.IEquatable<UnityEngine.Rendering.SharedInstanceHandle>, System.IComparable<UnityEngine.Rendering.SharedInstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.SharedInstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7c048fc*/ SharedInstanceHandle();
            /*0x7c047b8*/ int get_index();
            /*0x7c047c0*/ void set_index(int value);
            /*0x7c047c8*/ bool Equals(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x7c04830*/ int CompareTo(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x7c048a8*/ int GetHashCode();
        }

        struct GPUInstanceIndex : System.IEquatable<UnityEngine.Rendering.GPUInstanceIndex>, System.IComparable<UnityEngine.Rendering.GPUInstanceIndex>
        {
            static /*0x0*/ UnityEngine.Rendering.GPUInstanceIndex Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7c04a8c*/ GPUInstanceIndex();
            /*0x7c04948*/ int get_index();
            /*0x7c04950*/ void set_index(int value);
            /*0x7c04958*/ bool Equals(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x7c049c0*/ int CompareTo(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x7c04a38*/ int GetHashCode();
        }

        struct InstanceAllocator
        {
            /*0x10*/ Unity.Collections.NativeArray<int> m_StructData;
            /*0x20*/ Unity.Collections.NativeList<int> m_FreeInstances;
            /*0x28*/ int m_BaseInstanceOffset;
            /*0x2c*/ int m_InstanceStride;

            /*0x7c04ad8*/ int get_length();
            /*0x7c04ae4*/ void set_length(int value);
            /*0x7c04af0*/ void Initialize(int baseInstanceOffset, int instanceStride);
            /*0x7c04bb0*/ void Dispose();
            /*0x7c04c20*/ int AllocateInstance();
            /*0x7c04d4c*/ void FreeInstance(int instance);
            /*0x7c04da8*/ int GetNumAllocated();
        }

        struct InstanceAllocators
        {
            /*0x10*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_MeshRenderer;
            /*0x30*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_SpeedTree;
            /*0x50*/ UnityEngine.Rendering.InstanceAllocator m_SharedInstanceAlloc;

            /*0x7c04e10*/ void Initialize();
            /*0x7c04e70*/ void Dispose();
            /*0x7c04e90*/ UnityEngine.Rendering.InstanceAllocator GetInstanceAllocator(UnityEngine.Rendering.InstanceType type);
            /*0x7c04f00*/ int GetInstanceHandlesLength(UnityEngine.Rendering.InstanceType type);
            /*0x7c04f24*/ int GetInstancesLength(UnityEngine.Rendering.InstanceType type);
            /*0x7c04f50*/ UnityEngine.Rendering.InstanceHandle AllocateInstance(UnityEngine.Rendering.InstanceType type);
            /*0x7c04fe8*/ void FreeInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c0507c*/ UnityEngine.Rendering.SharedInstanceHandle AllocateSharedInstance();
            /*0x7c050e0*/ void FreeSharedInstance(UnityEngine.Rendering.SharedInstanceHandle instance);
        }

        struct CPUInstanceData : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeArray<int> m_StructData;
            /*0x20*/ Unity.Collections.NativeList<int> m_InstanceIndices;
            /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
            /*0x38*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SharedInstanceHandle> sharedInstances;
            /*0x48*/ UnityEngine.Rendering.ParallelBitArray localToWorldIsFlippedBits;
            /*0x68*/ Unity.Collections.NativeArray<UnityEngine.Rendering.AABB> worldAABBs;
            /*0x78*/ Unity.Collections.NativeArray<int> tetrahedronCacheIndices;
            /*0x88*/ UnityEngine.Rendering.ParallelBitArray movedInCurrentFrameBits;
            /*0xa8*/ UnityEngine.Rendering.ParallelBitArray movedInPreviousFrameBits;
            /*0xc8*/ UnityEngine.Rendering.ParallelBitArray visibleInPreviousFrameBits;
            /*0xe8*/ UnityEngine.Rendering.EditorInstanceDataArrays editorData;

            /*0x7c05144*/ int get_instancesLength();
            /*0x7c05150*/ void set_instancesLength(int value);
            /*0x7c0515c*/ int get_instancesCapacity();
            /*0x7c05168*/ void set_instancesCapacity(int value);
            /*0x7c05174*/ void Initialize(int initCapacity);
            /*0x7c054d0*/ void Dispose();
            /*0x7c055e8*/ void Grow(int newCapacity);
            /*0x7c05814*/ void AddUnsafe(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c059e0*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05a74*/ UnityEngine.Rendering.InstanceHandle IndexToInstance(int index);
            /*0x7c05a80*/ bool IsValidInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05bd0*/ int GetFreeInstancesCount();
            /*0x7c05be0*/ void EnsureFreeInstances(int instancesCount);
            /*0x7c05c08*/ void AddNoGrow(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05cd8*/ void Remove(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05ec0*/ void Set(UnityEngine.Rendering.InstanceHandle instance, UnityEngine.Rendering.SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, ref UnityEngine.Rendering.AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame);
            /*0x7c05c34*/ void SetDefault(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05fac*/ UnityEngine.Rendering.SharedInstanceHandle Get_SharedInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c05fcc*/ void Set_TetrahedronCacheIndex(UnityEngine.Rendering.InstanceHandle instance, int tetrahedronCacheIndex);
            /*0x7c05ff8*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly AsReadOnly();

            struct ReadOnly
            {
                /*0x10*/ Unity.Collections.NativeArray.ReadOnly<int> instanceIndices;
                /*0x20*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x30*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SharedInstanceHandle> sharedInstances;
                /*0x40*/ UnityEngine.Rendering.ParallelBitArray localToWorldIsFlippedBits;
                /*0x60*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.AABB> worldAABBs;
                /*0x70*/ Unity.Collections.NativeArray.ReadOnly<int> tetrahedronCacheIndices;
                /*0x80*/ UnityEngine.Rendering.ParallelBitArray movedInCurrentFrameBits;
                /*0xa0*/ UnityEngine.Rendering.ParallelBitArray movedInPreviousFrameBits;
                /*0xc0*/ UnityEngine.Rendering.ParallelBitArray visibleInPreviousFrameBits;
                /*0xe0*/ UnityEngine.Rendering.EditorInstanceDataArrays.ReadOnly editorData;

                /*0x7c0602c*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
                /*0x7c06324*/ int get_handlesLength();
                /*0x7c06360*/ int get_instancesLength();
                /*0x7c063a0*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
            }
        }

        struct CPUSharedInstanceData : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeArray<int> m_StructData;
            /*0x20*/ Unity.Collections.NativeList<int> m_InstanceIndices;
            /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SharedInstanceHandle> instances;
            /*0x38*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
            /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays;
            /*0x58*/ Unity.Collections.NativeArray<int> meshIDs;
            /*0x68*/ Unity.Collections.NativeArray<UnityEngine.Rendering.AABB> localAABBs;
            /*0x78*/ Unity.Collections.NativeArray<UnityEngine.Rendering.CPUSharedInstanceFlags> flags;
            /*0x88*/ Unity.Collections.NativeArray<uint> lodGroupAndMasks;
            /*0x98*/ Unity.Collections.NativeArray<int> gameObjectLayers;
            /*0xa8*/ Unity.Collections.NativeArray<int> refCounts;

            /*0x7c06430*/ int get_instancesLength();
            /*0x7c0643c*/ void set_instancesLength(int value);
            /*0x7c06448*/ int get_instancesCapacity();
            /*0x7c06454*/ void set_instancesCapacity(int value);
            /*0x7c06460*/ void Initialize(int initCapacity);
            /*0x7c06790*/ void Dispose();
            /*0x7c06b0c*/ void Grow(int newCapacity);
            /*0x7c06d7c*/ void AddUnsafe(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c06f48*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c06fdc*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData instanceData, UnityEngine.Rendering.InstanceHandle instance);
            /*0x7c07030*/ int GetFreeInstancesCount();
            /*0x7c07040*/ void EnsureFreeInstances(int instancesCount);
            /*0x7c07068*/ void AddNoGrow(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c0710c*/ void Remove(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c0731c*/ int Get_RendererGroupID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c0733c*/ int Get_MeshID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c0735c*/ int Get_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c0737c*/ void Set_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance, int refCount);
            /*0x7c073a8*/ void Set(UnityEngine.Rendering.SharedInstanceHandle instance, int rendererGroupID, ref UnityEngine.Rendering.SmallIntegerArray materialIDs, int meshID, ref UnityEngine.Rendering.AABB localAABB, UnityEngine.Rendering.TransformUpdateFlags transformUpdateFlags, UnityEngine.Rendering.InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount);
            /*0x7c07094*/ void SetDefault(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7c074f0*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly AsReadOnly();

            struct ReadOnly
            {
                /*0x10*/ Unity.Collections.NativeArray.ReadOnly<int> instanceIndices;
                /*0x20*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SharedInstanceHandle> instances;
                /*0x30*/ Unity.Collections.NativeArray.ReadOnly<int> rendererGroupIDs;
                /*0x40*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays;
                /*0x50*/ Unity.Collections.NativeArray.ReadOnly<int> meshIDs;
                /*0x60*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.AABB> localAABBs;
                /*0x70*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.CPUSharedInstanceFlags> flags;
                /*0x80*/ Unity.Collections.NativeArray.ReadOnly<uint> lodGroupAndMasks;
                /*0x90*/ Unity.Collections.NativeArray.ReadOnly<int> gameObjectLayers;
                /*0xa0*/ Unity.Collections.NativeArray.ReadOnly<int> refCounts;

                /*0x7c07524*/ ReadOnly(ref UnityEngine.Rendering.CPUSharedInstanceData instanceData);
                /*0x7c078c0*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
                /*0x7c07950*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, UnityEngine.Rendering.InstanceHandle instance);
            }
        }

        struct SmallIntegerArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<int> m_FixedArray;
            /*0x30*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<int> m_List;
            /*0x48*/ bool m_IsEmbedded;
            /*0x49*/ bool <Valid>k__BackingField;
            /*0x4c*/ int Length;

            /*0x7c079e8*/ SmallIntegerArray(int length, Unity.Collections.Allocator allocator);
            /*0x7c079d4*/ bool get_Valid();
            /*0x7c079dc*/ void set_Valid(bool value);
            /*0x7c07b94*/ int get_Item(int index);
            /*0x7c07c8c*/ void set_Item(int index, int value);
            /*0x7c06ab4*/ void Dispose();
        }

        struct EditorInstanceDataArrays
        {
            /*0x7c054cc*/ void Initialize(int initCapacity);
            /*0x7c055e4*/ void Dispose();
            /*0x7c05810*/ void Grow(int newCapacity);
            /*0x7c05ebc*/ void Remove(int index, int lastIndex);
            /*0x7c05fa8*/ void SetDefault(int index);

            struct ReadOnly
            {
                /*0x7c0639c*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
            }
        }

        enum TransformUpdateFlags
        {
            None = 0,
            HasLightProbeCombined = 1,
            IsPartOfStaticBatch = 2,
        }

        enum InstanceFlags
        {
            None = 0,
            AffectsLightmaps = 1,
            IsShadowsOff = 2,
            IsShadowsOnly = 4,
            HasProgressiveLod = 8,
            SmallMeshCulling = 16,
        }

        struct CPUSharedInstanceFlags
        {
            /*0x10*/ UnityEngine.Rendering.TransformUpdateFlags transformUpdateFlags;
            /*0x11*/ UnityEngine.Rendering.InstanceFlags instanceFlags;
        }

        struct PackedMatrix
        {
            /*0x10*/ Unity.Mathematics.float4 packed0;
            /*0x20*/ Unity.Mathematics.float4 packed1;
            /*0x30*/ Unity.Mathematics.float4 packed2;

            static /*0x7c07d90*/ UnityEngine.Rendering.PackedMatrix FromMatrix4x4(ref UnityEngine.Matrix4x4 m);
            static /*0x7c07dd4*/ UnityEngine.Rendering.PackedMatrix FromFloat4x4(ref Unity.Mathematics.float4x4 m);
        }

        class InstanceDataSystem : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.InstanceAllocators m_InstanceAllocators;
            /*0x70*/ UnityEngine.Rendering.CPUSharedInstanceData m_SharedInstanceData;
            /*0x118*/ UnityEngine.Rendering.CPUInstanceData m_InstanceData;
            /*0x1f8*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> m_RendererGroupInstanceMultiHash;
            /*0x208*/ UnityEngine.ComputeShader m_TransformUpdateCS;
            /*0x210*/ UnityEngine.ComputeShader m_WindDataUpdateCS;
            /*0x218*/ int m_TransformInitKernel;
            /*0x21c*/ int m_TransformUpdateKernel;
            /*0x220*/ int m_MotionUpdateKernel;
            /*0x224*/ int m_ProbeUpdateKernel;
            /*0x228*/ int m_WindDataCopyHistoryKernel;
            /*0x230*/ UnityEngine.ComputeBuffer m_UpdateIndexQueueBuffer;
            /*0x238*/ UnityEngine.ComputeBuffer m_ProbeUpdateDataQueueBuffer;
            /*0x240*/ UnityEngine.ComputeBuffer m_ProbeOcclusionUpdateDataQueueBuffer;
            /*0x248*/ UnityEngine.ComputeBuffer m_TransformUpdateDataQueueBuffer;
            /*0x250*/ UnityEngine.ComputeBuffer m_BoundingSpheresUpdateDataQueueBuffer;
            /*0x258*/ bool m_EnableBoundingSpheres;
            /*0x260*/ int[] m_ScratchWindParamAddressArray;

            static /*0x382f8e8*/ int AtomicAddLengthNoResize<T>(ref Unity.Collections.NativeList<T> list, int count);
            /*0x7c07f14*/ InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7c07e18*/ bool get_hasBoundingSpheres();
            /*0x7c07e20*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x7c07e70*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x7c07ec0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x7c0817c*/ void Dispose();
            /*0x7c08238*/ int GetMaxInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c08260*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c08290*/ void EnsureIndexQueueBufferCapacity(int capacity);
            /*0x7c08338*/ void EnsureProbeBuffersCapacity(int capacity);
            /*0x7c084b4*/ void EnsureTransformBuffersCapacity(int capacity);
            /*0x7c08658*/ Unity.Jobs.JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeUpdateInstanceQueue, Unity.Collections.NativeArray<int> compactTetrahedronCache, Unity.Collections.NativeArray<UnityEngine.Vector3> probeQueryPosition, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue);
            /*0x7c087f8*/ void DispatchProbeUpdateCommand(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c08ae0*/ void DispatchMotionUpdateCommand(int motionQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c08d50*/ void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.TransformUpdatePacket> updateDataQueue, Unity.Collections.NativeArray<Unity.Mathematics.float4> boundingSphereUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c090f8*/ void DispatchWindDataCopyHistoryCommand(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c09364*/ void UpdateInstanceMotionsData(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c0954c*/ void UpdateInstanceTransformsData(bool initialize, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c09b84*/ void UpdateInstanceProbesData(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c09ea0*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c09f00*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0a24c*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x7c0a30c*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap);
            /*0x7c0a478*/ void UpdateAllInstanceProbes(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c0a510*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c0a554*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c0a590*/ void UpdateInstanceMotions(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7c0a5a4*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0a650*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0a764*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> instancesOffset, Unity.Collections.NativeArray<int> instancesCount, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0a95c*/ Unity.Jobs.JobHandle ScheduleQuerySortedMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0aa8c*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x7c0ae88*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);

            class InstanceTransformUpdateIDs
            {
                static /*0x0*/ int _TransformUpdateQueueCount;
                static /*0x4*/ int _TransformUpdateOutputL2WVec4Offset;
                static /*0x8*/ int _TransformUpdateOutputW2LVec4Offset;
                static /*0xc*/ int _TransformUpdateOutputPrevL2WVec4Offset;
                static /*0x10*/ int _TransformUpdateOutputPrevW2LVec4Offset;
                static /*0x14*/ int _BoundingSphereOutputVec4Offset;
                static /*0x18*/ int _TransformUpdateDataQueue;
                static /*0x1c*/ int _TransformUpdateIndexQueue;
                static /*0x20*/ int _BoundingSphereDataQueue;
                static /*0x24*/ int _OutputTransformBuffer;
                static /*0x28*/ int _ProbeUpdateQueueCount;
                static /*0x2c*/ int _SHUpdateVec4Offset;
                static /*0x30*/ int _ProbeUpdateDataQueue;
                static /*0x34*/ int _ProbeOcclusionUpdateDataQueue;
                static /*0x38*/ int _ProbeUpdateIndexQueue;
                static /*0x3c*/ int _OutputProbeBuffer;

                static /*0x7c0af68*/ InstanceTransformUpdateIDs();
            }

            class InstanceWindDataUpdateIDs
            {
                static /*0x0*/ int _WindDataQueueCount;
                static /*0x4*/ int _WindDataUpdateIndexQueue;
                static /*0x8*/ int _WindDataBuffer;
                static /*0xc*/ int _WindParamAddressArray;
                static /*0x10*/ int _WindHistoryParamAddressArray;

                static /*0x7c0b284*/ InstanceWindDataUpdateIDs();
            }

            struct QueryRendererGroupInstancesCountJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x1a8*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x1b8*/ Unity.Collections.NativeArray<int> instancesCount;

                /*0x7c0b3ac*/ void Execute(int startIndex, int count);
            }

            struct ComputeInstancesOffsetAndResizeInstancesArrayJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesCount;
                /*0x20*/ Unity.Collections.NativeArray<int> instancesOffset;
                /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x7c0b490*/ void Execute();
            }

            struct QueryRendererGroupInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x20*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x40*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

                /*0x7c0b518*/ void Execute(int startIndex, int count);
            }

            struct QueryRendererGroupInstancesMultiJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x20*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x30*/ Unity.Collections.NativeArray<int> instancesOffsets;
                /*0x40*/ Unity.Collections.NativeArray<int> instancesCounts;
                /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x60*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicNonFoundSharedInstancesCount;
                /*0x68*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

                /*0x7c0b628*/ void Execute(int startIndex, int count);
            }

            struct QuerySortedMeshInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<int> sortedMeshID;
                /*0x1a8*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x7c0b7d8*/ void Execute(int startIndex, int count);
            }

            struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int probesCount;
                /*0x18*/ UnityEngine.LightProbesQuery lightProbesQuery;
                /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Vector3> queryPostitions;
                /*0x38*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probesSphericalHarmonics;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Vector4> probesOcclusion;

                /*0x7c0b9f0*/ void Execute(int index);
            }

            struct ScatterTetrahedronCacheIndicesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstances;
                /*0x20*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x7c0bb44*/ void Execute(int index);
            }

            struct TransformUpdateJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ bool initialize;
                /*0x11*/ bool enableBoundingSpheres;
                /*0x18*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices;
                /*0x38*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices;
                /*0x48*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicTransformQueueCount;
                /*0x50*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0xf8*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformUpdateInstanceQueue;
                /*0x1e8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.TransformUpdatePacket> transformUpdateDataQueue;
                /*0x1f8*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> boundingSpheresDataQueue;

                /*0x7c0bb80*/ void Execute(int startIndex, int count);
            }

            struct ProbesUpdateJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x100*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x1a8*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicProbesQueueCount;
                /*0x1b0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstanceQueue;
                /*0x1c0*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x1d0*/ Unity.Collections.NativeArray<UnityEngine.Vector3> probeQueryPosition;

                /*0x7c0c1d0*/ void Execute(int startIndex, int count);
            }

            struct MotionUpdateJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int queueWriteBase;
                /*0x18*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf8*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicUpdateQueueCount;
                /*0x100*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformUpdateInstanceQueue;

                /*0x7c0c470*/ void Execute(int chunk_index);
            }

            struct ReallocateInstancesJob : Unity.Jobs.IJob
            {
                /*0x10*/ bool implicitInstanceIndices;
                /*0x18*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData;
                /*0x38*/ Unity.Collections.NativeArray<int> instanceOffsets;
                /*0x48*/ Unity.Collections.NativeArray<int> instanceCounts;
                /*0x58*/ UnityEngine.Rendering.InstanceAllocators instanceAllocators;
                /*0xb8*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x198*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x240*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x250*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;

                /*0x7c0c624*/ void Execute();
            }

            struct FreeInstancesJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.InstanceAllocators instanceAllocators;
                /*0x80*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x160*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x208*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;

                /*0x7c0c9a0*/ void Execute();
            }

            struct FreeRendererGroupInstancesJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<int> rendererGroupsID;
                /*0x20*/ UnityEngine.Rendering.InstanceAllocators instanceAllocators;
                /*0x80*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x160*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x208*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;

                /*0x7c0ccbc*/ void Execute();
            }

            struct UpdateRendererInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ bool implicitInstanceIndices;
                /*0x18*/ UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData;
                /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x1e8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap;
                /*0x1f8*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x2d8*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;

                /*0x7c0cf70*/ void Execute(int index);
            }

            struct CollectInstancesLODGroupsAndMasksJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
                /*0xf8*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<uint> lodGroupAndMasks;

                /*0x7c0d45c*/ void Execute(int index);
            }

            struct GetVisibleNonProcessedTreeInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;
                /*0x1b8*/ bool becomeVisible;
                /*0x1c0*/ UnityEngine.Rendering.ParallelBitArray processedBits;
                /*0x1e0*/ Unity.Collections.NativeArray<int> rendererIDs;
                /*0x1f0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x200*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicTreeInstancesCount;

                /*0x7c0d4ec*/ void Execute(int startIndex, int count);
            }

            struct UpdateCompactedInstanceVisibilityJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x7c0d790*/ void Execute(int startIndex, int count);
            }
        }

        struct TransformUpdatePacket
        {
            /*0x10*/ Unity.Mathematics.float4 localToWorld0;
            /*0x20*/ Unity.Mathematics.float4 localToWorld1;
            /*0x30*/ Unity.Mathematics.float4 localToWorld2;
        }

        struct SHUpdatePacket
        {
            /*0x10*/ float shr0;
            /*0x14*/ float shr1;
            /*0x18*/ float shr2;
            /*0x1c*/ float shr3;
            /*0x20*/ float shr4;
            /*0x24*/ float shr5;
            /*0x28*/ float shr6;
            /*0x2c*/ float shr7;
            /*0x30*/ float shr8;
            /*0x34*/ float shg0;
            /*0x38*/ float shg1;
            /*0x3c*/ float shg2;
            /*0x40*/ float shg3;
            /*0x44*/ float shg4;
            /*0x48*/ float shg5;
            /*0x4c*/ float shg6;
            /*0x50*/ float shg7;
            /*0x54*/ float shg8;
            /*0x58*/ float shb0;
            /*0x5c*/ float shb1;
            /*0x60*/ float shb2;
            /*0x64*/ float shb3;
            /*0x68*/ float shb4;
            /*0x6c*/ float shb5;
            /*0x70*/ float shb6;
            /*0x74*/ float shb7;
            /*0x78*/ float shb8;
        }

        enum InstanceType
        {
            MeshRenderer = 0,
            SpeedTree = 1,
            Count = 2,
            LODGroup = 0,
        }

        class InstanceTypeInfo
        {
            static /*0x0*/ UnityEngine.Rendering.InstanceType[] s_ParentTypes;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.InstanceType> s_ChildTypes;

            static /*0x7c0d878*/ InstanceTypeInfo();
            static /*0x7c0d88c*/ void InitParentTypes();
            static /*0x7c0d94c*/ void InitChildTypes();
            static /*0x7c0dcbc*/ void FlattenChildInstanceTypes(UnityEngine.Rendering.InstanceType instanceType, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceType> instanceTypes);
            static /*0x7c0db90*/ void ValidateTypeRelationsAreCorrectlySorted();
            static /*0x7c0de80*/ System.Collections.Generic.List<UnityEngine.Rendering.InstanceType> GetChildTypes(UnityEngine.Rendering.InstanceType type);
        }

        struct InstanceNumInfo
        {
            /*0x10*/ UnityEngine.Rendering.InstanceNumInfo.<InstanceNums> InstanceNums;

            /*0x7c0df04*/ InstanceNumInfo(int meshRendererNum, int speedTreeNum);
            /*0x7c0defc*/ void InitDefault();
            /*0x7c042c4*/ int GetInstanceNum(UnityEngine.Rendering.InstanceType type);
            /*0x7c02c2c*/ int GetInstanceNumIncludingChildren(UnityEngine.Rendering.InstanceType type);
            /*0x7c042b4*/ int GetTotalInstanceNum();

            struct <InstanceNums>e__FixedBuffer
            {
                /*0x10*/ int FixedElementField;
            }
        }

        struct OccluderDerivedData
        {
            /*0x10*/ UnityEngine.Matrix4x4 viewProjMatrix;
            /*0x50*/ UnityEngine.Vector4 viewOriginWorldSpace;
            /*0x60*/ UnityEngine.Vector4 radialDirWorldSpace;
            /*0x70*/ UnityEngine.Vector4 facingDirWorldSpace;

            static /*0x7c0df0c*/ UnityEngine.Rendering.OccluderDerivedData FromParameters(ref UnityEngine.Rendering.OccluderSubviewUpdate occluderSubviewUpdate);
        }

        struct OccluderHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle occluderDepthPyramid;
            /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle occlusionDebugOverlay;

            /*0x7c0e23c*/ bool IsValid();
            /*0x7c0e344*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
            /*0x7c0e4a0*/ void UseForOccluderUpdate(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
        }

        struct IndirectInstanceInfo
        {
            /*0x10*/ int drawOffsetAndSplitMask;
            /*0x14*/ int instanceIndexAndCrossFade;
        }

        struct IndirectDrawInfo
        {
            /*0x10*/ uint indexCount;
            /*0x14*/ uint firstIndex;
            /*0x18*/ uint baseVertex;
            /*0x1c*/ uint firstInstanceGlobalIndex;
            /*0x20*/ uint maxInstanceCount;
        }

        struct IndirectBufferAllocInfo
        {
            /*0x10*/ int drawAllocIndex;
            /*0x14*/ int drawCount;
            /*0x18*/ int instanceAllocIndex;
            /*0x1c*/ int instanceCount;

            /*0x7c0e5fc*/ bool IsEmpty();
            /*0x7c0e60c*/ bool IsWithinLimits(ref UnityEngine.Rendering.IndirectBufferLimits limits);
            /*0x7c0e640*/ int GetExtraDrawInfoSlotIndex();
        }

        struct IndirectBufferContext
        {
            /*0x10*/ Unity.Jobs.JobHandle cullingJobHandle;
            /*0x20*/ UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState;
            /*0x24*/ int occluderVersion;
            /*0x28*/ int subviewMask;

            /*0x7c0e64c*/ IndirectBufferContext(Unity.Jobs.JobHandle cullingJobHandle);
            /*0x7c0e65c*/ bool Matches(UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState, int occluderVersion, int subviewMask);

            enum BufferState
            {
                Pending = 0,
                Zeroed = 1,
                NoOcclusionTest = 2,
                AllInstancesOcclusionTested = 3,
                OccludedInstancesReTested = 4,
            }
        }

        struct OccluderMipBounds
        {
            /*0x10*/ UnityEngine.Vector2Int offset;
            /*0x18*/ UnityEngine.Vector2Int size;
        }

        struct OccluderContext : System.IDisposable
        {
            /*0x10*/ int version;
            /*0x14*/ UnityEngine.Vector2Int depthBufferSize;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.OccluderDerivedData> subviewData;
            /*0x30*/ int subviewValidMask;
            /*0x38*/ Unity.Collections.NativeArray<UnityEngine.Rendering.OccluderMipBounds> occluderMipBounds;
            /*0x48*/ UnityEngine.Vector2Int occluderMipLayoutSize;
            /*0x50*/ UnityEngine.Vector2Int occluderDepthPyramidSize;
            /*0x58*/ UnityEngine.Rendering.RTHandle occluderDepthPyramid;
            /*0x60*/ int occlusionDebugOverlaySize;
            /*0x68*/ UnityEngine.GraphicsBuffer occlusionDebugOverlay;
            /*0x70*/ bool debugNeedsClear;
            /*0x78*/ UnityEngine.ComputeBuffer constantBuffer;
            /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Rendering.OccluderDepthPyramidConstants> constantBufferData;

            static /*0x7c0ec4c*/ void SetKeyword(UnityEngine.Rendering.ComputeCommandBuffer cmd, UnityEngine.ComputeShader cs, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7c0e68c*/ int get_subviewCount();
            /*0x7c0e694*/ bool IsSubviewValid(int subviewIndex);
            /*0x7c0e6b8*/ UnityEngine.Vector2 get_depthBufferSizeInOccluderPixels();
            /*0x7c0e6d0*/ void Dispose();
            /*0x7c0e80c*/ void UpdateMipBounds();
            /*0x7c0e9c8*/ void AllocateTexturesIfNecessary(bool debugOverlayEnabled);
            /*0x7c0ec6c*/ UnityEngine.Rendering.OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes);
            /*0x7c0f078*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes, UnityEngine.ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel);
            /*0x7c0f524*/ UnityEngine.Rendering.OccluderHandles Import(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x7c0f5f4*/ void PrepareOccluders(ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x7c0f6ec*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetDebugOutput();

            class ShaderIDs
            {
                static /*0x0*/ int _SrcDepth;
                static /*0x4*/ int _DstDepth;
                static /*0x8*/ int OccluderDepthPyramidConstants;

                static /*0x7c0f820*/ ShaderIDs();
            }
        }

        struct IndirectBufferLimits
        {
            /*0x10*/ int maxInstanceCount;
            /*0x14*/ int maxDrawCount;
        }

        struct InstanceOcclusionTestSubviewSettings
        {
            /*0x10*/ int testCount;
            /*0x14*/ int occluderSubviewIndices;
            /*0x18*/ int occluderSubviewMask;
            /*0x1c*/ int cullingSplitIndices;
            /*0x20*/ int cullingSplitMask;

            static /*0x7c0f8e8*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings FromSpan(System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
        }

        struct IndirectBufferContextHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceBuffer;
            /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceInfoBuffer;
            /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle argsBuffer;
            /*0x34*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle drawInfoBuffer;

            /*0x7c0f9b4*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
        }

        struct IndirectBufferContextStorage : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.IndirectBufferLimits m_BufferLimits;
            /*0x18*/ UnityEngine.GraphicsBuffer m_InstanceBuffer;
            /*0x20*/ UnityEngine.GraphicsBuffer m_InstanceInfoBuffer;
            /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectInstanceInfo> m_InstanceInfoStaging;
            /*0x38*/ UnityEngine.GraphicsBuffer m_ArgsBuffer;
            /*0x40*/ UnityEngine.GraphicsBuffer m_DrawInfoBuffer;
            /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectDrawInfo> m_DrawInfoStaging;
            /*0x58*/ int m_ContextAllocCounter;
            /*0x60*/ Unity.Collections.NativeHashMap<int, int> m_ContextIndexFromViewID;
            /*0x68*/ Unity.Collections.NativeList<UnityEngine.Rendering.IndirectBufferContext> m_Contexts;
            /*0x70*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> m_ContextAllocInfo;
            /*0x80*/ Unity.Collections.NativeArray<int> m_AllocationCounters;

            /*0x7c0fbc4*/ UnityEngine.GraphicsBuffer get_instanceBuffer();
            /*0x7c0fbcc*/ UnityEngine.GraphicsBuffer get_instanceInfoBuffer();
            /*0x7c0fbd4*/ UnityEngine.GraphicsBuffer get_argsBuffer();
            /*0x7c0fbdc*/ UnityEngine.GraphicsBuffer get_drawInfoBuffer();
            /*0x7c0fbe4*/ UnityEngine.GraphicsBufferHandle get_visibleInstanceBufferHandle();
            /*0x7c0fc08*/ UnityEngine.GraphicsBufferHandle get_indirectArgsBufferHandle();
            /*0x7c0fc2c*/ UnityEngine.Rendering.IndirectBufferContextHandles ImportBuffers(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x7c0fd00*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectInstanceInfo> get_instanceInfoGlobalArray();
            /*0x7c0fd0c*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectDrawInfo> get_drawInfoGlobalArray();
            /*0x7c0fd18*/ Unity.Collections.NativeArray<int> get_allocationCounters();
            /*0x7c0fd24*/ void Init();
            /*0x7c0fe78*/ void AllocateInstanceBuffers(int maxInstanceCount);
            /*0x7c101b0*/ void FreeInstanceBuffers();
            /*0x7c0ffb8*/ void AllocateDrawBuffers(int maxDrawCount);
            /*0x7c10224*/ void FreeDrawBuffers();
            /*0x7c10298*/ void Dispose();
            /*0x7c10368*/ void SyncContexts();
            /*0x7c100fc*/ void ResetAllocators();
            /*0x7c10448*/ void GrowBuffers();
            /*0x7c105f0*/ void ClearContextsAndGrowBuffers();
            /*0x7c10610*/ int TryAllocateContext(int viewID);
            /*0x7c10754*/ int TryGetContextIndex(int viewID);
            /*0x7c107cc*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex);
            /*0x7c10828*/ UnityEngine.Rendering.IndirectBufferAllocInfo GetAllocInfo(int contextIndex);
            /*0x7c108ac*/ void CopyFromStaging(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.IndirectBufferAllocInfo allocInfo);
            /*0x7c10970*/ UnityEngine.Rendering.IndirectBufferLimits GetLimits(int contextIndex);
            /*0x7c10984*/ UnityEngine.Rendering.IndirectBufferContext GetBufferContext(int contextIndex);
            /*0x7c10a54*/ void SetBufferContext(int contextIndex, UnityEngine.Rendering.IndirectBufferContext ctx);
        }

        struct InstanceOcclusionCullerShaderVariables
        {
            /*0x10*/ uint _DrawInfoAllocIndex;
            /*0x14*/ uint _DrawInfoCount;
            /*0x18*/ uint _InstanceInfoAllocIndex;
            /*0x1c*/ uint _InstanceInfoCount;
            /*0x20*/ int _BoundingSphereInstanceDataAddress;
            /*0x24*/ int _DebugCounterIndex;
            /*0x28*/ int _InstanceMultiplierShift;
            /*0x2c*/ int _InstanceOcclusionCullerPad0;
        }

        struct LODGroupData
        {
            /*0x10*/ bool valid;
            /*0x14*/ int lodCount;
            /*0x18*/ int rendererCount;
            /*0x1c*/ UnityEngine.Rendering.LODGroupData.<screenRelativeTransitionHeights> screenRelativeTransitionHeights;
            /*0x3c*/ UnityEngine.Rendering.LODGroupData.<fadeTransitionWidth> fadeTransitionWidth;

            struct <fadeTransitionWidth>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <screenRelativeTransitionHeights>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }
        }

        struct LODGroupCullingData
        {
            /*0x10*/ Unity.Mathematics.float3 worldSpaceReferencePoint;
            /*0x1c*/ int lodCount;
            /*0x20*/ UnityEngine.Rendering.LODGroupCullingData.<sqrDistances> sqrDistances;
            /*0x40*/ UnityEngine.Rendering.LODGroupCullingData.<transitionDistances> transitionDistances;
            /*0x60*/ float worldSpaceSize;
            /*0x64*/ UnityEngine.Rendering.LODGroupCullingData.<percentageFlags> percentageFlags;

            struct <percentageFlags>e__FixedBuffer
            {
                /*0x10*/ bool FixedElementField;
            }

            struct <sqrDistances>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <transitionDistances>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }
        }

        struct UpdateLODGroupTransformJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash;
            /*0x20*/ Unity.Collections.NativeArray<int> lodGroupIDs;
            /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Vector3> worldSpaceReferencePoints;
            /*0x40*/ Unity.Collections.NativeArray<float> worldSpaceSizes;
            /*0x50*/ bool requiresGPUUpload;
            /*0x51*/ bool supportDitheringCrossFade;
            /*0x58*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupData;
            /*0x60*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData;
            /*0x68*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicUpdateCount;

            /*0x7c10b24*/ void Execute(int index);
        }

        struct AllocateOrGetLODGroupDataInstancesJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> lodGroupsID;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData;
            /*0x30*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash;
            /*0x40*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles;
            /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances;
            /*0x58*/ int* previousRendererCount;

            /*0x7c10d0c*/ void Execute();
        }

        struct UpdateLODGroupDataJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances;
            /*0x20*/ UnityEngine.Rendering.GPUDrivenLODGroupData inputData;
            /*0xe0*/ bool supportDitheringCrossFade;
            /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0xf8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupCullingData> lodGroupsCullingData;
            /*0x108*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 rendererCount;

            /*0x7c10f88*/ void Execute(int index);
        }

        struct FreeLODGroupDataJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> destroyedLODGroupsID;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash;
            /*0x38*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles;
            /*0x40*/ int* removedRendererCount;

            /*0x7c11258*/ void Execute();
        }

        class LODGroupDataPool : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> m_LODGroupData;
            /*0x18*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> m_LODGroupDataHash;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> m_LODGroupCullingData;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> m_FreeLODGroupDataHandles;
            /*0x38*/ int m_CrossfadedRendererCount;
            /*0x3c*/ bool m_SupportDitheringCrossFade;

            /*0x7c11504*/ LODGroupDataPool(UnityEngine.Rendering.GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade);
            /*0x7c114e8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> get_lodGroupDataHash();
            /*0x7c114f4*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x7c114fc*/ int get_crossfadedRendererCount();
            /*0x7c11654*/ void Dispose();
            /*0x7c1170c*/ void UpdateLODGroupTransformData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x7c118cc*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x7c11be4*/ void FreeLODGroupData(Unity.Collections.NativeArray<int> destroyedLODGroupsID);
        }

        class LODGroupRenderingUtils
        {
            static /*0x7c11c84*/ float CalculateFOVHalfAngle(float fieldOfView);
            static /*0x7c11c9c*/ float CalculateScreenRelativeMetric(UnityEngine.Rendering.LODParameters lodParams, float lodBias);
            static /*0x7c11d00*/ float CalculateSqrPerspectiveDistance(UnityEngine.Vector3 objPosition, UnityEngine.Vector3 camPosition, float sqrScreenRelativeMetric);
            static /*0x7c10d04*/ float CalculateLODDistance(float relativeScreenHeight, float size);
        }

        struct OccluderDepthPyramidConstants
        {
            /*0x10*/ UnityEngine.Rendering.OccluderDepthPyramidConstants.<_InvViewProjMatrix> _InvViewProjMatrix;
            /*0x190*/ UnityEngine.Rendering.OccluderDepthPyramidConstants.<_SilhouettePlanes> _SilhouettePlanes;
            /*0x1f0*/ UnityEngine.Rendering.OccluderDepthPyramidConstants.<_SrcOffset> _SrcOffset;
            /*0x250*/ UnityEngine.Rendering.OccluderDepthPyramidConstants.<_MipOffsetAndSize> _MipOffsetAndSize;
            /*0x2a0*/ uint _OccluderMipLayoutSizeX;
            /*0x2a4*/ uint _OccluderMipLayoutSizeY;
            /*0x2a8*/ uint _OccluderDepthPyramidPad0;
            /*0x2ac*/ uint _OccluderDepthPyramidPad1;
            /*0x2b0*/ uint _SrcSliceIndices;
            /*0x2b4*/ uint _DstSubviewIndices;
            /*0x2b8*/ uint _MipCount;
            /*0x2bc*/ uint _SilhouettePlaneCount;

            struct <_InvViewProjMatrix>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <_MipOffsetAndSize>e__FixedBuffer
            {
                /*0x10*/ uint FixedElementField;
            }

            struct <_SilhouettePlanes>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <_SrcOffset>e__FixedBuffer
            {
                /*0x10*/ uint FixedElementField;
            }
        }

        struct OcclusionTestComputeShader
        {
            /*0x10*/ UnityEngine.ComputeShader cs;
            /*0x18*/ UnityEngine.Rendering.LocalKeyword occlusionDebugKeyword;

            /*0x7c11d28*/ void Init(UnityEngine.ComputeShader cs);
        }

        struct SilhouettePlaneCache : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<int, int> m_SubviewIDToIndexMap;
            /*0x20*/ Unity.Collections.NativeList<int> m_SlotFreeList;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.SilhouettePlaneCache.Slot> m_Slots;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Plane> m_PlaneStorage;

            /*0x7c11dc4*/ void Init();
            /*0x7c11f08*/ void Dispose();
            /*0x7c11fc0*/ void Update(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes, int frameIndex);
            /*0x7c123d4*/ void FreeUnusedSlots(int frameIndex, int maximumAge);
            /*0x7c1255c*/ Unity.Collections.NativeArray<UnityEngine.Plane> GetSubArray(int viewInstanceID);

            struct Slot
            {
                /*0x10*/ bool isActive;
                /*0x14*/ int viewInstanceID;
                /*0x18*/ int planeCount;
                /*0x1c*/ int lastUsedFrameIndex;

                /*0x7c123c0*/ Slot(int viewInstanceID, int planeCount, int frameIndex);
            }
        }

        class OcclusionCullingCommon : System.IDisposable
        {
            static /*0x0*/ int s_MaxContextGCFrame;
            /*0x10*/ UnityEngine.Material m_DebugOcclusionTestMaterial;
            /*0x18*/ UnityEngine.Material m_OccluderDebugViewMaterial;
            /*0x20*/ UnityEngine.ComputeShader m_OcclusionDebugCS;
            /*0x28*/ int m_ClearOcclusionDebugKernel;
            /*0x30*/ UnityEngine.ComputeShader m_OccluderDepthPyramidCS;
            /*0x38*/ int m_OccluderDepthDownscaleKernel;
            /*0x3c*/ int m_FrameIndex;
            /*0x40*/ UnityEngine.Rendering.SilhouettePlaneCache m_SilhouettePlaneCache;
            /*0x68*/ Unity.Collections.NativeParallelHashMap<int, int> m_ViewIDToIndexMap;
            /*0x78*/ System.Collections.Generic.List<UnityEngine.Rendering.OccluderContext> m_OccluderContextData;
            /*0x80*/ Unity.Collections.NativeList<UnityEngine.Rendering.OcclusionCullingCommon.OccluderContextSlot> m_OccluderContextSlots;
            /*0x88*/ Unity.Collections.NativeList<int> m_FreeOccluderContexts;
            /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.OcclusionCullingCommonShaderVariables> m_CommonShaderVariables;
            /*0xa0*/ UnityEngine.ComputeBuffer m_CommonConstantBuffer;
            /*0xa8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.OcclusionCullingDebugShaderVariables> m_DebugShaderVariables;
            /*0xb8*/ UnityEngine.ComputeBuffer m_DebugConstantBuffer;
            /*0xc0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerUpdateOccluders;
            /*0xc8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerOcclusionTestOverlay;
            /*0xd0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerOccluderOverlay;

            static /*0x7c15dd8*/ OcclusionCullingCommon();
            static /*0x7c12a88*/ bool UseOcclusionDebug(ref UnityEngine.Rendering.OccluderContext occluderCtx);
            static /*0x7c13234*/ void SetDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            static /*0x7c132cc*/ void SetDebugPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x7c15dd0*/ OcclusionCullingCommon();
            /*0x7c12670*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7c12a98*/ void PrepareCulling(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, bool useOcclusionDebug);
            /*0x7c133a4*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x7c13d38*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x7c12fe4*/ void DispatchDebugClear(UnityEngine.Rendering.ComputeCommandBuffer cmd, int viewInstanceID);
            /*0x7c14294*/ UnityEngine.Rendering.OccluderHandles PrepareOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x7c149d8*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x7c14c08*/ bool UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x7c15358*/ void UpdateSilhouettePlanes(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes);
            /*0x7c13bd0*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID);
            /*0x7c15364*/ void UpdateOccluderStats(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x7c15748*/ bool HasOccluderContext(int viewInstanceID);
            /*0x7c157a0*/ bool GetOccluderContext(int viewInstanceID, ref UnityEngine.Rendering.OccluderContext occluderContext);
            /*0x7c158dc*/ void UpdateFrame();
            /*0x7c14508*/ int NewContext(int viewInstanceID);
            /*0x7c1482c*/ void DeleteContext(int viewInstanceID);
            /*0x7c15b68*/ void Dispose();
            /*0x7c15e24*/ void <RenderDebugOcclusionTestOverlay>b__29_1(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);

            struct OccluderContextSlot
            {
                /*0x10*/ bool valid;
                /*0x14*/ int lastUsedFrameIndex;
                /*0x18*/ int viewInstanceID;
            }

            class ShaderIDs
            {
                static /*0x0*/ int OcclusionCullingCommonShaderVariables;
                static /*0x4*/ int _OccluderDepthPyramid;
                static /*0x8*/ int _OcclusionDebugOverlay;
                static /*0xc*/ int OcclusionCullingDebugShaderVariables;

                static /*0x7c15f28*/ ShaderIDs();
            }

            class OcclusionTestOverlaySetupPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingDebugShaderVariables cb;

                /*0x7c16024*/ OcclusionTestOverlaySetupPassData();
            }

            class OcclusionTestOverlayPassData
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle debugPyramid;

                /*0x7c1602c*/ OcclusionTestOverlayPassData();
            }

            class OccluderOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugMaterial;
                /*0x18*/ UnityEngine.Rendering.RTHandle occluderTexture;
                /*0x20*/ UnityEngine.Rect viewport;
                /*0x30*/ int passIndex;
                /*0x34*/ UnityEngine.Vector2 validRange;

                /*0x7c16034*/ OccluderOverlayPassData();
            }

            class UpdateOccludersPassData
            {
                /*0x10*/ UnityEngine.Rendering.OccluderParameters occluderParams;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates;
                /*0x40*/ UnityEngine.Rendering.OccluderHandles occluderHandles;

                /*0x7c1603c*/ UpdateOccludersPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.OcclusionCullingCommon.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__29_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__32_0;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__37_0;

                static /*0x7c16044*/ <>c();
                /*0x7c160ac*/ <>c();
                /*0x7c160b4*/ void <RenderDebugOcclusionTestOverlay>b__29_0(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7c16224*/ void <RenderDebugOccluderOverlay>b__32_0(UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);
                /*0x7c163ac*/ void <UpdateInstanceOccluders>b__37_0(UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
            }
        }

        struct OcclusionCullingCommonShaderVariables
        {
            /*0x10*/ UnityEngine.Rendering.OcclusionCullingCommonShaderVariables.<_OccluderMipBounds> _OccluderMipBounds;
            /*0x90*/ UnityEngine.Rendering.OcclusionCullingCommonShaderVariables.<_ViewProjMatrix> _ViewProjMatrix;
            /*0x210*/ UnityEngine.Rendering.OcclusionCullingCommonShaderVariables.<_ViewOriginWorldSpace> _ViewOriginWorldSpace;
            /*0x270*/ UnityEngine.Rendering.OcclusionCullingCommonShaderVariables.<_FacingDirWorldSpace> _FacingDirWorldSpace;
            /*0x2d0*/ UnityEngine.Rendering.OcclusionCullingCommonShaderVariables.<_RadialDirWorldSpace> _RadialDirWorldSpace;
            /*0x330*/ UnityEngine.Vector4 _DepthSizeInOccluderPixels;
            /*0x340*/ UnityEngine.Vector4 _OccluderDepthPyramidSize;
            /*0x350*/ uint _OccluderMipLayoutSizeX;
            /*0x354*/ uint _OccluderMipLayoutSizeY;
            /*0x358*/ uint _OcclusionTestDebugFlags;
            /*0x35c*/ uint _OcclusionCullingCommonPad0;
            /*0x360*/ int _OcclusionTestCount;
            /*0x364*/ int _OccluderSubviewIndices;
            /*0x368*/ int _CullingSplitIndices;
            /*0x36c*/ int _CullingSplitMask;

            /*0x7c12c4c*/ OcclusionCullingCommonShaderVariables(ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass);

            struct <_FacingDirWorldSpace>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <_OccluderMipBounds>e__FixedBuffer
            {
                /*0x10*/ uint FixedElementField;
            }

            struct <_RadialDirWorldSpace>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <_ViewOriginWorldSpace>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <_ViewProjMatrix>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }
        }

        struct OcclusionCullingDebugShaderVariables
        {
            /*0x10*/ UnityEngine.Vector4 _DepthSizeInOccluderPixels;
            /*0x20*/ UnityEngine.Rendering.OcclusionCullingDebugShaderVariables.<_OccluderMipBounds> _OccluderMipBounds;
            /*0xa0*/ uint _OccluderMipLayoutSizeX;
            /*0xa4*/ uint _OccluderMipLayoutSizeY;
            /*0xa8*/ uint _OcclusionCullingDebugPad0;
            /*0xac*/ uint _OcclusionCullingDebugPad1;

            struct <_OccluderMipBounds>e__FixedBuffer
            {
                /*0x10*/ uint FixedElementField;
            }
        }

        struct RenderersBatchersContextDesc
        {
            /*0x10*/ UnityEngine.Rendering.InstanceNumInfo instanceNumInfo;
            /*0x18*/ bool supportDitheringCrossFade;
            /*0x19*/ bool enableBoundingSpheresInstanceData;
            /*0x1c*/ float smallMeshScreenPercentage;
            /*0x20*/ bool enableCullerDebugStats;

            static /*0x7c16624*/ UnityEngine.Rendering.RenderersBatchersContextDesc NewDefault();
        }

        class RenderersBatchersContext : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.InstanceDataSystem m_InstanceDataSystem;
            /*0x18*/ UnityEngine.Rendering.GPUResidentDrawerResources m_Resources;
            /*0x20*/ UnityEngine.Rendering.GPUDrivenProcessor m_GPUDrivenProcessor;
            /*0x28*/ UnityEngine.Rendering.LODGroupDataPool m_LODGroupDataPool;
            /*0x30*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_InstanceDataBuffer;
            /*0x38*/ UnityEngine.Rendering.RenderersParameters m_RenderersParameters;
            /*0xa0*/ UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources m_UploadResources;
            /*0xe0*/ UnityEngine.Rendering.GPUInstanceDataBufferGrower.GPUResources m_GrowerResources;
            /*0xf0*/ UnityEngine.Rendering.CommandBuffer m_CmdBuffer;
            /*0xf8*/ UnityEngine.Rendering.SphericalHarmonicsL2 m_CachedAmbientProbe;
            /*0x164*/ float m_SmallMeshScreenPercentage;
            /*0x168*/ UnityEngine.Rendering.GPUDrivenLODGroupDataCallback m_UpdateLODGroupCallback;
            /*0x170*/ UnityEngine.Rendering.GPUDrivenLODGroupDataCallback m_TransformLODGroupCallback;
            /*0x178*/ UnityEngine.Rendering.OcclusionCullingCommon m_OcclusionCullingCommon;
            /*0x180*/ UnityEngine.Rendering.DebugRendererBatcherStats m_DebugStats;

            /*0x7c16844*/ RenderersBatchersContext(ref UnityEngine.Rendering.RenderersBatchersContextDesc desc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7c16660*/ UnityEngine.Rendering.RenderersParameters get_renderersParameters();
            /*0x7c16670*/ UnityEngine.GraphicsBuffer get_gpuInstanceDataBuffer();
            /*0x7c1668c*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.GPUInstanceComponentDesc> get_defaultDescriptions();
            /*0x7c166e0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> get_defaultMetadata();
            /*0x7c166fc*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x7c16718*/ int get_instanceDataBufferLayoutVersion();
            /*0x7c16734*/ int get_crossfadedRendererCount();
            /*0x7c16750*/ bool get_hasBoundingSpheres();
            /*0x7c1676c*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x7c167ac*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x7c167ec*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly get_instanceDataBuffer();
            /*0x7c16808*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x7c16824*/ float get_smallMeshScreenPercentage();
            /*0x7c1682c*/ UnityEngine.Rendering.GPUResidentDrawerResources get_resources();
            /*0x7c16834*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x7c1683c*/ UnityEngine.Rendering.DebugRendererBatcherStats get_debugStats();
            /*0x7c17280*/ void Dispose();
            /*0x7c173fc*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c17418*/ void GrowInstanceBuffer(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7c17558*/ void EnsureInstanceBufferCapacity();
            /*0x7c17638*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x7c17650*/ void TransformLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x7c17668*/ void DestroyLODGroups(Unity.Collections.NativeArray<int> destroyed);
            /*0x7c1768c*/ void UpdateLODGroups(Unity.Collections.NativeArray<int> changedID);
            /*0x7c17718*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c17740*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData);
            /*0x7c17768*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x7c17784*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c177a0*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c177bc*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c177d8*/ void ChangeInstanceBufferVersion();
            /*0x7c177fc*/ UnityEngine.Rendering.GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c1783c*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x7c17868*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x7c17894*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices);
            /*0x7c178e0*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x7c17924*/ void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate);
            /*0x7c179f4*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x7c17a90*/ void UpdateInstanceMotions();
            /*0x7c17ad0*/ void TransformLODGroups(Unity.Collections.NativeArray<int> lodGroupsID);
            /*0x7c17b5c*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);
            /*0x7c17b78*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x7c17b98*/ void UpdateFrame();
        }

        enum InstanceComponentGroup
        {
            Default = 1,
            Wind = 2,
            LightProbe = 4,
            Lightmap = 8,
            DefaultWind = 3,
            DefaultLightProbe = 5,
            DefaultLightmap = 9,
            DefaultWindLightProbe = 7,
            DefaultWindLightmap = 11,
        }

        struct RenderersParameters
        {
            static /*0x0*/ int s_uintSize;
            /*0x10*/ UnityEngine.Rendering.RenderersParameters.ParamInfo lightmapScale;
            /*0x1c*/ UnityEngine.Rendering.RenderersParameters.ParamInfo localToWorld;
            /*0x28*/ UnityEngine.Rendering.RenderersParameters.ParamInfo worldToLocal;
            /*0x34*/ UnityEngine.Rendering.RenderersParameters.ParamInfo matrixPreviousM;
            /*0x40*/ UnityEngine.Rendering.RenderersParameters.ParamInfo matrixPreviousMI;
            /*0x4c*/ UnityEngine.Rendering.RenderersParameters.ParamInfo shCoefficients;
            /*0x58*/ UnityEngine.Rendering.RenderersParameters.ParamInfo boundingSphere;
            /*0x68*/ UnityEngine.Rendering.RenderersParameters.ParamInfo[] windParams;
            /*0x70*/ UnityEngine.Rendering.RenderersParameters.ParamInfo[] windHistoryParams;

            static /*0x7c17c90*/ RenderersParameters();
            static /*0x7c16c0c*/ UnityEngine.Rendering.GPUInstanceDataBuffer CreateInstanceDataBuffer(UnityEngine.Rendering.RenderersParameters.Flags flags, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            static /*0x7c17bd0*/ UnityEngine.Rendering.RenderersParameters.ParamInfo <.ctor>g__GetParamInfo|14_0(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail);
            /*0x7c16fd0*/ RenderersParameters(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer);

            enum Flags
            {
                None = 0,
                UseBoundingSphereParameter = 1,
            }

            class ParamNames
            {
                static /*0x0*/ int _BaseColor;
                static /*0x4*/ int unity_SpecCube0_HDR;
                static /*0x8*/ int unity_SHCoefficients;
                static /*0xc*/ int unity_LightmapST;
                static /*0x10*/ int unity_ObjectToWorld;
                static /*0x14*/ int unity_WorldToObject;
                static /*0x18*/ int unity_MatrixPreviousM;
                static /*0x1c*/ int unity_MatrixPreviousMI;
                static /*0x20*/ int unity_WorldBoundingSphere;
                static /*0x28*/ int[] DOTS_ST_WindParams;
                static /*0x30*/ int[] DOTS_ST_WindHistoryParams;

                static /*0x7c17ce8*/ ParamNames();
            }

            struct ParamInfo
            {
                /*0x10*/ int index;
                /*0x14*/ int gpuAddress;
                /*0x18*/ int uintOffset;
            }
        }

        class MemoryUtilities
        {
            static /*0x3910ae8*/ T* Malloc<T>(int count, Unity.Collections.Allocator allocator);
        }

        struct ParallelBitArray
        {
            /*0x10*/ Unity.Collections.Allocator m_Allocator;
            /*0x18*/ Unity.Collections.NativeArray<long> m_Bits;
            /*0x28*/ int m_Length;

            /*0x7c18068*/ ParallelBitArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x7c1801c*/ int get_Length();
            /*0x7c18024*/ bool get_IsCreated();
            /*0x7c18108*/ void Dispose();
            /*0x7c18158*/ void Resize(int newLength);
            /*0x7c18318*/ void Set(int index, bool value);
            /*0x7c183c0*/ bool Get(int index);
            /*0x7c18428*/ ulong GetChunk(int chunk_index);
            /*0x7c18434*/ void SetChunk(int chunk_index, ulong chunk_bits);
            /*0x7c18440*/ void InterlockedOrChunk(int chunk_index, ulong chunk_bits);
            /*0x7c184cc*/ UnityEngine.Rendering.ParallelBitArray GetSubArray(int length);
        }

        class ParallelSortExtensions
        {
            static /*0x7c1854c*/ Unity.Jobs.JobHandle ParallelSort(Unity.Collections.NativeArray<int> array);
            static /*0x7c18a5c*/ void <ParallelSort>g__Swap|2_0(ref Unity.Collections.NativeArray<int> a, ref Unity.Collections.NativeArray<int> b);

            struct RadixSortBucketCountJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int jobsCount;
                /*0x18*/ int batchSize;
                /*0x20*/ Unity.Collections.NativeArray<int> array;
                /*0x30*/ Unity.Collections.NativeArray<int> buckets;

                /*0x7c18a7c*/ void Execute(int index);
            }

            struct RadixSortBatchPrefixSumJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int jobsCount;
                /*0x18*/ Unity.Collections.NativeArray<int> array;
                /*0x28*/ Unity.Collections.NativeArray<int> counter;
                /*0x38*/ Unity.Collections.NativeArray<int> indicesSum;
                /*0x48*/ Unity.Collections.NativeArray<int> buckets;
                /*0x58*/ Unity.Collections.NativeArray<int> indices;

                static /*0x7c18ae4*/ int AtomicIncrement(Unity.Collections.NativeArray<int> counter);
                /*0x7c18b50*/ int JobIndexPrefixSum(int sum, int i);
                /*0x7c18b98*/ void Execute(int index);
            }

            struct RadixSortPrefixSumJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int jobsCount;
                /*0x18*/ Unity.Collections.NativeArray<int> indicesSum;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;

                /*0x7c18c84*/ void Execute(int index);
            }

            struct RadixSortBucketSortJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int batchSize;
                /*0x18*/ Unity.Collections.NativeArray<int> array;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;
                /*0x38*/ Unity.Collections.NativeArray<int> arraySorted;

                /*0x7c18cfc*/ void Execute(int index);
            }
        }
    }
}

class __JobReflectionRegistrationOutput__15867191014387474753
{
    static /*0x7c18d6c*/ void CreateJobReflectionData();
    static /*0x7c1931c*/ void EarlyInit();
}
