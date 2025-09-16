class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7bd70f8*/ EmbeddedAttribute();
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
                /*0x7bd7100*/ IsUnmanagedAttribute();
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

            static /*0x7bd7200*/ Unity.Mathematics.float3 RotateExtents(Unity.Mathematics.float3 extents, Unity.Mathematics.float3 m0, Unity.Mathematics.float3 m1, Unity.Mathematics.float3 m2);
            static /*0x7bd726c*/ UnityEngine.Rendering.AABB Transform(Unity.Mathematics.float4x4 transform, UnityEngine.Rendering.AABB localBounds);
            /*0x7bd7108*/ Unity.Mathematics.float3 get_min();
            /*0x7bd7128*/ Unity.Mathematics.float3 get_max();
            /*0x7bd7148*/ string ToString();
        }

        class AABBExtensions
        {
            static /*0x7bd733c*/ UnityEngine.Rendering.AABB ToAABB(UnityEngine.Bounds bounds);
            static /*0x7bd73a4*/ UnityEngine.Bounds ToBounds(UnityEngine.Rendering.AABB aabb);
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

            static /*0x7bd764c*/ UnityEngine.Rendering.InstanceCullerViewStats GetInstanceCullerViewStats(int viewIndex);
            static /*0x7bd772c*/ UnityEngine.Rendering.InstanceOcclusionEventStats GetInstanceOcclusionEventStats(int passIndex);
            static /*0x7bd781c*/ UnityEngine.Rendering.DebugOccluderStats GetOccluderStats(int occluderIndex);
            static /*0x7bd78d0*/ int GetOcclusionContextsCounts();
            static /*0x7bd792c*/ int GetInstanceCullerViewCount();
            static /*0x7bd7988*/ int GetInstanceOcclusionEventCount();
            static /*0x7bd79e4*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceCullerViewDataRow(int viewIndex);
            static /*0x7bd7ed8*/ object OccluderVersionString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bd7f50*/ object OcclusionTestString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bd7fc8*/ object VisibleInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bd8034*/ object CulledInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x7bd80a0*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceOcclusionPassDataRow(int eventIndex);
            static /*0x7bd86f4*/ UnityEngine.Rendering.DebugUI.Table.Row AddOcclusionContextDataRow(int index);
            /*0x7bd9a80*/ DebugDisplayGPUResidentDrawer();
            /*0x7bd740c*/ bool get_displayBatcherStats();
            /*0x7bd7490*/ void set_displayBatcherStats(bool value);
            /*0x7bd74b0*/ bool GetOccluderViewInstanceID(ref int viewInstanceID);
            /*0x7bd758c*/ bool get_occlusionTestOverlayEnable();
            /*0x7bd75ac*/ void set_occlusionTestOverlayEnable(bool value);
            /*0x7bd75cc*/ bool get_occlusionTestOverlayCountVisible();
            /*0x7bd75ec*/ void set_occlusionTestOverlayCountVisible(bool value);
            /*0x7bd760c*/ bool get_overrideOcclusionTestToAlwaysPass();
            /*0x7bd762c*/ void set_overrideOcclusionTestToAlwaysPass(bool value);
            /*0x7bd8a88*/ bool get_AreAnySettingsActive();
            /*0x7bd8aa8*/ bool get_IsPostProcessingAllowed();
            /*0x7bd8ab0*/ bool get_IsLightingActive();
            /*0x7bd8ab8*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
            /*0x7bd8ac0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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

                static /*0x7bd9a94*/ Strings();
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x7bd8b18*/ SettingsPanel(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x7bd9e94*/ string get_PanelName();
                /*0x7bd9ed4*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x7bda2cc*/ void AddInstanceCullingStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x7bd9ee4*/ void AddOcclusionContextStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);

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

                    static /*0x7bda8a0*/ <>c();
                    /*0x7bda908*/ <>c();
                    /*0x7bda910*/ string <.ctor>b__4_0();
                    /*0x7bdac64*/ bool <.ctor>b__4_1();
                    /*0x7bdad04*/ bool <.ctor>b__4_2();
                    /*0x7bdad54*/ int <.ctor>b__4_16();
                    /*0x7bdad5c*/ int <.ctor>b__4_17();
                    /*0x7bdadc0*/ bool <.ctor>b__4_24();
                    /*0x7bdae10*/ object <AddInstanceCullingStatsWidget>b__5_1();
                    /*0x7bdae3c*/ object <AddOcclusionContextStatsWidget>b__6_1();
                }

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bd9edc*/ <>c__DisplayClass4_0();
                    /*0x7bdae68*/ bool <.ctor>b__3();
                    /*0x7bdae94*/ void <.ctor>b__4(bool value);
                    /*0x7bdaec0*/ bool <.ctor>b__5();
                    /*0x7bdaeec*/ void <.ctor>b__6(bool value);
                    /*0x7bdaf18*/ bool <.ctor>b__7();
                    /*0x7bdaf44*/ void <.ctor>b__8(bool value);
                    /*0x7bdaf70*/ bool <.ctor>b__9();
                    /*0x7bdaf8c*/ void <.ctor>b__10(bool value);
                    /*0x7bdafac*/ bool <.ctor>b__11();
                    /*0x7bdafc8*/ void <.ctor>b__12(bool value);
                    /*0x7bdafe8*/ int <.ctor>b__13();
                    /*0x7bdb004*/ void <.ctor>b__14(int value);
                    /*0x7bdb020*/ bool <.ctor>b__15();
                    /*0x7bdb044*/ float <.ctor>b__18();
                    /*0x7bdb060*/ void <.ctor>b__19(float value);
                    /*0x7bdb07c*/ bool <.ctor>b__20();
                    /*0x7bdb0a0*/ float <.ctor>b__21();
                    /*0x7bdb0bc*/ void <.ctor>b__22(float value);
                    /*0x7bdb0d8*/ bool <.ctor>b__23();
                    /*0x7bdb0fc*/ bool <.ctor>b__25();
                    /*0x7bdb128*/ void <.ctor>b__26(bool value);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bda890*/ <>c__DisplayClass5_0();
                    /*0x7bdb154*/ bool <AddInstanceCullingStatsWidget>b__0();
                    /*0x7bdb188*/ bool <AddInstanceCullingStatsWidget>b__2();
                    /*0x7bdb1bc*/ bool <AddInstanceCullingStatsWidget>b__3();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x7bda898*/ <>c__DisplayClass6_0();
                    /*0x7bdb1f0*/ bool <AddOcclusionContextStatsWidget>b__0();
                }
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ int viewIndex;

                /*0x7bd7ed0*/ <>c__DisplayClass29_0();
                /*0x7bdb214*/ bool <AddInstanceCullerViewDataRow>b__0();
                /*0x7bdb230*/ object <AddInstanceCullerViewDataRow>b__1();
                /*0x7bdb298*/ object <AddInstanceCullerViewDataRow>b__2();
                /*0x7bdb2d4*/ object <AddInstanceCullerViewDataRow>b__3();
                /*0x7bdb310*/ object <AddInstanceCullerViewDataRow>b__4();
                /*0x7bdb34c*/ object <AddInstanceCullerViewDataRow>b__5();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ int eventIndex;

                /*0x7bd86ec*/ <>c__DisplayClass34_0();
                /*0x7bdb388*/ bool <AddInstanceOcclusionPassDataRow>b__0();
                /*0x7bdb3a4*/ object <AddInstanceOcclusionPassDataRow>b__1();
                /*0x7bdb3e0*/ object <AddInstanceOcclusionPassDataRow>b__2();
                /*0x7bdb478*/ object <AddInstanceOcclusionPassDataRow>b__3();
                /*0x7bdb4ac*/ object <AddInstanceOcclusionPassDataRow>b__4();
                /*0x7bdb530*/ object <AddInstanceOcclusionPassDataRow>b__5();
                /*0x7bdb5a8*/ object <AddInstanceOcclusionPassDataRow>b__6();
                /*0x7bdb5dc*/ object <AddInstanceOcclusionPassDataRow>b__7();
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int index;

                /*0x7bd8a80*/ <>c__DisplayClass35_0();
                /*0x7bdb610*/ bool <AddOcclusionContextDataRow>b__0();
                /*0x7bdb62c*/ object <AddOcclusionContextDataRow>b__1();
                /*0x7bdb65c*/ object <AddOcclusionContextDataRow>b__2();
                /*0x7bdb690*/ object <AddOcclusionContextDataRow>b__3();
            }
        }

        struct Line
        {
            /*0x10*/ Unity.Mathematics.float3 m;
            /*0x1c*/ Unity.Mathematics.float3 t;

            static /*0x7bdb728*/ UnityEngine.Rendering.Line LineOfPlaneIntersectingPlane(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b);
            static /*0x7bdb780*/ Unity.Mathematics.float4 PlaneContainingLineAndPoint(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
            static /*0x7bdb7d8*/ Unity.Mathematics.float4 PlaneContainingLineWithNormalPerpendicularToVector(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
        }

        struct ReceiverPlanes
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Plane> planes;
            /*0x18*/ int lightFacingPlaneCount;

            static /*0x7bdb82c*/ bool IsSignBitSet(float x);
            static /*0x7bdb9ec*/ UnityEngine.Rendering.ReceiverPlanes Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            /*0x7bdb838*/ Unity.Collections.NativeArray<UnityEngine.Plane> LightFacingFrustumPlaneSubArray();
            /*0x7bdb8c4*/ Unity.Collections.NativeArray<UnityEngine.Plane> SilhouettePlaneSubArray();
            /*0x7bdb98c*/ void Dispose(Unity.Jobs.JobHandle job);
        }

        struct FrustumPlaneCuller
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets;
            /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos;

            static /*0x7bdc350*/ UnityEngine.Rendering.FrustumPlaneCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.NativeArray<UnityEngine.Plane> receiverPlanes, ref UnityEngine.Rendering.ReceiverSphereCuller receiverSphereCuller, Unity.Collections.Allocator allocator);
            static /*0x7bdc8a4*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets, Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos, ref UnityEngine.Rendering.AABB bounds);
            /*0x7bdc2c0*/ void Dispose(Unity.Jobs.JobHandle job);

            struct PlanePacket4
            {
                /*0x10*/ Unity.Mathematics.float4 nx;
                /*0x20*/ Unity.Mathematics.float4 ny;
                /*0x30*/ Unity.Mathematics.float4 nz;
                /*0x40*/ Unity.Mathematics.float4 d;
                /*0x50*/ Unity.Mathematics.float4 nxAbs;
                /*0x60*/ Unity.Mathematics.float4 nyAbs;
                /*0x70*/ Unity.Mathematics.float4 nzAbs;

                /*0x7bdc7ec*/ PlanePacket4(Unity.Collections.NativeArray<UnityEngine.Plane> planes, int offset, int limit);
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

            static /*0x7bdcb1c*/ UnityEngine.Rendering.ReceiverSphereCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            static /*0x7bdcdac*/ float DistanceUntilCylinderFullyCrossesPlane(Unity.Mathematics.float3 cylinderCenter, Unity.Mathematics.float3 cylinderDirection, float cylinderRadius, UnityEngine.Plane plane);
            static /*0x7bdcedc*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Plane> lightFacingFrustumPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.ReceiverSphereCuller.SplitInfo> splitInfos, Unity.Mathematics.float3x3 worldToLightSpaceRotation, ref UnityEngine.Rendering.AABB bounds);
            /*0x7bdcabc*/ void Dispose(Unity.Jobs.JobHandle job);
            /*0x7bdc788*/ bool UseReceiverPlanes();

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

            /*0x7bdd1a0*/ GPUResidentBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc instanceCullerBatcherDesc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor);
            /*0x7bdd174*/ UnityEngine.Rendering.RenderersBatchersContext get_batchersContext();
            /*0x7bdd17c*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x7bdd198*/ UnityEngine.Rendering.InstanceCullingBatcher get_instanceCullingBatcher();
            /*0x7bdd2fc*/ void Dispose();
            /*0x7bdd354*/ void OnBeginContextRendering();
            /*0x7bdd384*/ void OnEndContextRendering();
            /*0x7bdd398*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7bdd3ac*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x7bdd3c0*/ void UpdateFrame();
            /*0x7bdd3f0*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x7bdd40c*/ void DestroyInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bdd428*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x7bdd444*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs);
            /*0x7bdd570*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            /*0x7bddb2c*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x7bddba8*/ void UpdateRenderers(Unity.Collections.NativeArray<int> renderersID);
            /*0x7bddc5c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x7bddc78*/ void UpdateRendererData(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
            /*0x7bdde74*/ void OnFinishedCulling(nint customCullingResult);
            /*0x7bddea8*/ void ProcessTrees();
            /*0x7bde1f4*/ void UpdateSpeedTreeWindAndUploadWindParamsToGPU(Unity.Collections.NativeArray<int> treeRendererIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> treeInstances, bool history);
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

            static /*0x7bde48c*/ UnityEngine.Rendering.GPUResidentDrawer get_instance();
            static /*0x7bde4d4*/ bool IsInstanceOcclusionCullingEnabled();
            static /*0x7bde53c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            static /*0x7bde5b4*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            static /*0x7bde650*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParameters, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            static /*0x7bde6ec*/ void ReinitializeIfNeeded();
            static /*0x7bde6f0*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x7bde7a8*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x7bd742c*/ UnityEngine.Rendering.DebugRendererBatcherStats GetDebugStats();
            static /*0x7bdacb4*/ bool IsEnabled();
            static /*0x7bda960*/ UnityEngine.Rendering.GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset();
            static /*0x7bdf110*/ bool IsForcedOnViaCommandLine();
            static /*0x7bdf118*/ bool IsOcclusionForcedOnViaCommandLine();
            static /*0x7bdf120*/ void Reinitialize();
            static /*0x7bdf214*/ void CleanUp();
            static /*0x7bdf144*/ void Recreate(UnityEngine.Rendering.GPUResidentDrawerSettings settings);
            static /*0x7bdfb78*/ void PostPostLateUpdateStatic();
            static /*0x7be0814*/ bool IsProjectSupported(ref string message, ref UnityEngine.LogType severity);
            static /*0x7bdaaa8*/ bool IsGPUResidentDrawerSupportedBySRP(UnityEngine.Rendering.GPUResidentDrawerSettings settings, ref string message, ref UnityEngine.LogType severity);
            static /*0x7bdfa64*/ void LogMessage(string message, UnityEngine.LogType severity);
            /*0x7bdf534*/ GPUResidentDrawer(UnityEngine.Rendering.GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount);
            /*0x7bde888*/ void InsertIntoPlayerLoop();
            /*0x7bdeda4*/ void RemoveFromPlayerLoop();
            /*0x7bdfb0c*/ UnityEngine.Rendering.GPUResidentBatcher get_batcher();
            /*0x7bdfb14*/ UnityEngine.Rendering.GPUResidentDrawerSettings get_settings();
            /*0x7bdf288*/ void Dispose();
            /*0x7bdfb48*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x7bdff0c*/ void OnBeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7bdffd0*/ void OnEndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7be0088*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7be00b8*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7bdfbd0*/ void PostPostLateUpdate();
            /*0x7be02f8*/ void ProcessMaterials(Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.NativeArray<int> unsupportedMaterials);
            /*0x7be036c*/ void ProcessMeshes(Unity.Collections.NativeArray<int> destroyedID);
            /*0x7be04a4*/ void ProcessLODGroups(Unity.Collections.NativeArray<int> changedID, Unity.Collections.NativeArray<int> destroyed, Unity.Collections.NativeArray<int> transformedID);
            /*0x7be051c*/ void ProcessRenderers(UnityEngine.TypeDispatchData rendererChanges, Unity.Collections.NativeArray<int> unsupportedRenderers);
            /*0x7be07f8*/ void TransformInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x7be0728*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> unsupportedRendererGroupIDs);
            /*0x7be070c*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7be06f0*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7be00e8*/ Unity.Collections.NativeList<int> FindUnsupportedMaterials(Unity.Collections.NativeArray<int> changedMaterialIDs);
            /*0x7be01b4*/ Unity.Collections.NativeList<int> FindUnsupportedRenderers(Unity.Collections.NativeArray<int> unsupportedMaterials);

            struct FindUnsupportedMaterialsJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash;
                /*0x20*/ Unity.Collections.NativeArray<int> changedMaterialIDs;
                /*0x30*/ Unity.Collections.NativeList<int> unsupportedMaterialIDs;

                /*0x7be08d4*/ void Execute();
            }

            struct FindUnsupportedRenderersJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray.ReadOnly<int> unsupportedMaterials;
                /*0x20*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays;
                /*0x30*/ Unity.Collections.NativeArray.ReadOnly<int> rendererGroups;
                /*0x40*/ Unity.Collections.NativeList<int> unsupportedRenderers;

                /*0x7be0bf8*/ void Execute();
            }

            class Strings
            {
                static /*0x0*/ string drawerModeDisabled;
                static /*0x8*/ string allowInEditModeDisabled;
                static /*0x10*/ string notGPUResidentRenderPipeline;
                static /*0x18*/ string rawBufferNotSupportedByPlatform;
                static /*0x20*/ string kernelNotPresent;
                static /*0x28*/ string batchRendererGroupShaderStrippingModeInvalid;

                static /*0x7be0dcc*/ Strings();
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

            /*0x7be0f84*/ DebugRendererBatcherStats();
            /*0x7be1080*/ void Dispose();
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

            /*0x7be11a0*/ GPUResidentDrawerResources();
            /*0x7be1150*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x7be1158*/ UnityEngine.ComputeShader get_instanceDataBufferCopyKernels();
            /*0x7be1160*/ UnityEngine.ComputeShader get_instanceDataBufferUploadKernels();
            /*0x7be1168*/ UnityEngine.ComputeShader get_transformUpdaterKernels();
            /*0x7be1170*/ UnityEngine.ComputeShader get_windDataUpdaterKernels();
            /*0x7be1178*/ UnityEngine.ComputeShader get_occluderDepthPyramidKernels();
            /*0x7be1180*/ UnityEngine.ComputeShader get_instanceOcclusionCullingKernels();
            /*0x7be1188*/ UnityEngine.ComputeShader get_occlusionCullingDebugKernels();
            /*0x7be1190*/ UnityEngine.Shader get_debugOcclusionTestPS();
            /*0x7be1198*/ UnityEngine.Shader get_debugOccluderPS();

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
            static /*0x7be11a8*/ uint GetBatchLayerMask(UnityEngine.Rendering.OcclusionTest occlusionTest);
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

            /*0x7be11b8*/ OcclusionCullingSettings(int viewInstanceID, UnityEngine.Rendering.OcclusionTest occlusionTest);
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

            /*0x7be11c8*/ OccluderSubviewUpdate(int subviewIndex);
        }

        struct OccluderParameters
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ int subviewCount;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture;
            /*0x28*/ UnityEngine.Vector2Int depthSize;
            /*0x30*/ bool depthIsArray;

            /*0x7be12c4*/ OccluderParameters(int viewInstanceID);
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
            static /*0x7be13a4*/ void ReinitializeGPUResidentDrawer();
            UnityEngine.Rendering.GPUResidentDrawerSettings get_gpuResidentDrawerSettings();
            /*0x7be13c8*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severity);
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

            /*0x7be1408*/ bool Equals(UnityEngine.Rendering.RangeKey other);
            /*0x7be148c*/ int GetHashCode();
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

            /*0x7be14d0*/ bool Equals(UnityEngine.Rendering.DrawKey other);
            /*0x7be1620*/ int GetHashCode();
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

            /*0x7be1690*/ int get_visibilityConfigCount();
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

            static /*0x7be16b4*/ uint PackFloatToUint8(float percent);
            /*0x7be1714*/ float CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x7be1bc8*/ uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x7be1d58*/ void Execute(int instanceIndex);

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

            /*0x7be1f24*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x7be1fcc*/ void Execute(int batchIndex);
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

            /*0x7be2548*/ void Execute();
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

            /*0x7be2a04*/ int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade);
            /*0x7be2ad0*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x7be2b78*/ void Execute(int batchIndex);
        }

        struct CompactVisibilityMasksJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x20*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;

            /*0x7be3258*/ void Execute(int startIndex, int count);
        }

        struct InstanceCullerSplitDebugArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceCullerSplitDebugArray.Info> m_Info;
            /*0x18*/ Unity.Collections.NativeArray<int> m_Counters;
            /*0x28*/ Unity.Collections.NativeQueue<Unity.Jobs.JobHandle> m_CounterSync;

            /*0x7be32c4*/ Unity.Collections.NativeArray<int> get_Counters();
            /*0x7be32d0*/ void Init();
            /*0x7be33bc*/ void Dispose();
            /*0x7be344c*/ int TryAddSplits(UnityEngine.Rendering.BatchCullingViewType viewType, int viewInstanceID, int splitCount);
            /*0x7be3534*/ void AddSync(int baseIndex, Unity.Jobs.JobHandle jobHandle);
            /*0x7be35b0*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

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

            /*0x7be37c0*/ UnityEngine.GraphicsBuffer get_CounterBuffer();
            /*0x7be37c8*/ void Init();
            /*0x7be38d4*/ void Dispose();
            /*0x7be3a10*/ int TryAdd(int viewInstanceID, UnityEngine.Rendering.InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, UnityEngine.Rendering.OcclusionTest occlusionTest);
            /*0x7be3b24*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

            struct Info
            {
                /*0x10*/ int viewInstanceID;
                /*0x14*/ UnityEngine.Rendering.InstanceOcclusionEventType eventType;
                /*0x18*/ int occluderVersion;
                /*0x1c*/ int subviewMask;
                /*0x20*/ UnityEngine.Rendering.OcclusionTest occlusionTest;

                /*0x7be3fb4*/ bool HasVersion();
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

            /*0x7be3fd8*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources, UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x7be4250*/ Unity.Jobs.JobHandle CreateFrustumCullingJob(ref UnityEngine.Rendering.BatchCullingContext cc, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref UnityEngine.Rendering.BinningConfig binningConfig, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Collections.NativeArray<byte> rendererCrossFadeValues);
            /*0x7be46a8*/ int ComputeWorstCaseDrawCommandCount(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BinningConfig binningConfig, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, int crossFadedRendererCount);
            /*0x7be4794*/ Unity.Jobs.JobHandle CreateCullJobTree(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, ref UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly instanceDataBuffer, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> batchIDs, int crossFadedRendererCount, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon);
            /*0x7be511c*/ Unity.Jobs.JobHandle CreateCompactedVisibilityMaskJob(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Jobs.JobHandle cullingJobHandle);
            /*0x7be5224*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7be52ac*/ void DisposeCompactVisibilityMasks();
            /*0x7be52d8*/ void DisposeSceneViewHiddenBits();
            /*0x7be52dc*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x7bdd5ec*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7be5310*/ void EnsureValidOcclusionTestResults(int viewInstanceID);
            /*0x7be55b8*/ void AddOcclusionCullingDispatch(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles, ref UnityEngine.Rendering.OccluderHandles occluderHandles, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x7be5fc8*/ void FlushDebugCounters();
            /*0x7be6000*/ void OnBeginSceneViewCameraRendering();
            /*0x7be6004*/ void OnEndSceneViewCameraRendering();
            /*0x7be6008*/ void UpdateFrame();
            /*0x7be6040*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7be6058*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x7be6070*/ void Dispose();

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

                static /*0x7be6128*/ ShaderIDs();
            }

            struct SetupCullingJobInput : Unity.Jobs.IJob
            {
                /*0x10*/ float lodBias;
                /*0x18*/ UnityEngine.Rendering.BatchCullingContext* context;
                /*0x20*/ UnityEngine.Rendering.ReceiverPlanes* receiverPlanes;
                /*0x28*/ UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller;
                /*0x30*/ UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller;
                /*0x38*/ float* screenRelativeMetric;

                /*0x7be62e4*/ void Execute();
            }

            class InstanceOcclusionTestPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingSettings settings;
                /*0x1c*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings;
                /*0x30*/ UnityEngine.Rendering.OccluderHandles occluderHandles;
                /*0x4c*/ UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles;

                /*0x7be63d0*/ InstanceOcclusionTestPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.InstanceCuller.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__26_0;

                static /*0x7be63d8*/ <>c();
                /*0x7be6440*/ <>c();
                /*0x7be6448*/ void <InstanceOcclusionTest>b__26_0(UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
            }
        }

        class OnCullingCompleteCallback : System.MulticastDelegate
        {
            /*0x7be64d8*/ OnCullingCompleteCallback(object object, nint method);
            /*0x7be6578*/ void Invoke(Unity.Jobs.JobHandle jobHandle, ref UnityEngine.Rendering.BatchCullingContext cullingContext, ref UnityEngine.Rendering.BatchCullingOutput cullingOutput);
        }

        struct InstanceCullingBatcherDesc
        {
            /*0x10*/ UnityEngine.Rendering.OnCullingCompleteCallback onCompleteCallback;

            static /*0x7bdfb28*/ UnityEngine.Rendering.InstanceCullingBatcherDesc NewDefault();
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

            /*0x7be658c*/ void Execute();
        }

        struct BuildDrawListsJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x30*/ Unity.Collections.NativeArray<int> internalDrawIndex;
            /*0x40*/ Unity.Collections.NativeArray<int> drawInstanceIndices;

            static /*0x7be67f8*/ int IncrementCounter(int* counter);
            /*0x7be6840*/ void Execute(int index);
        }

        struct FindDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instancesSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x7be6970*/ void Execute(int startIndex, int count);
        }

        struct FindMaterialDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<uint> materialsSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x7be6af4*/ void Execute(int startIndex, int count);
        }

        struct FindNonRegisteredInstancesJob<T> : Unity.Jobs.IJobParallelForBatch
        {
            /*0x0*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x0*/ Unity.Collections.NativeParallelHashMap<int, T> hashMap;
            /*0x0*/ Unity.Collections.NativeList.ParallelWriter<int> outInstancesWriter;

            /*0x380d0e4*/ void Execute(int startIndex, int count);
        }

        struct RegisterNewInstancesJob<T> : Unity.Jobs.IJobParallelFor
        {
            /*0x0*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x0*/ Unity.Collections.NativeArray<T> batchIDs;
            /*0x0*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<int, T> hashMap;

            /*0x380cffc*/ void Execute(int index);
        }

        struct RemoveDrawInstanceIndicesJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> drawInstanceIndices;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash;
            /*0x38*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x48*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x50*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;

            /*0x7be6c34*/ void RemoveDrawRange(ref UnityEngine.Rendering.RangeKey key);
            /*0x7be6dd8*/ void RemoveDrawBatch(ref UnityEngine.Rendering.DrawKey key);
            /*0x7be7024*/ void Execute();
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

            /*0x7be71d0*/ ref UnityEngine.Rendering.DrawRange EditDrawRange(ref UnityEngine.Rendering.RangeKey key);
            /*0x7be7358*/ ref UnityEngine.Rendering.DrawBatch EditDrawBatch(ref UnityEngine.Rendering.DrawKey key, ref UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor);
            /*0x7be7518*/ void ProcessRenderer(int i);
            /*0x7be7a84*/ void Execute();
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

            /*0x7be8748*/ CPUDrawInstanceData();
            /*0x7be7ac8*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> get_drawInstances();
            /*0x7be7ad0*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> get_batchHash();
            /*0x7be7adc*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> get_drawBatches();
            /*0x7be7ae4*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> get_rangeHash();
            /*0x7be7af0*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> get_drawRanges();
            /*0x7be7af8*/ Unity.Collections.NativeArray<int> get_drawBatchIndices();
            /*0x7be7b40*/ Unity.Collections.NativeArray<int> get_drawInstanceIndices();
            /*0x7be7b88*/ void Initialize();
            /*0x7be7d78*/ void Dispose();
            /*0x7be7f20*/ void RebuildDrawListsIfNeeded();
            /*0x7be819c*/ void DestroyDrawInstanceIndices(Unity.Collections.NativeArray<int> drawInstanceIndicesToDestroy);
            /*0x7be8244*/ void DestroyDrawInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> destroyedInstances);
            /*0x7be84cc*/ void DestroyMaterialDrawInstances(Unity.Collections.NativeArray<uint> destroyedBatchMaterials);
            /*0x7be84c0*/ void NeedsRebuild();
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

            /*0x7be875c*/ InstanceCullingBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc desc, UnityEngine.Rendering.BatchRendererGroup.OnFinishedCulling onFinishedCulling);
            /*0x7be8750*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> get_batchMaterialHash();
            /*0x7be8d18*/ ref UnityEngine.Rendering.InstanceCuller get_culler();
            /*0x7be8d20*/ void Dispose();
            /*0x7be8acc*/ UnityEngine.Rendering.BatchID GetBatchID(UnityEngine.Rendering.InstanceComponentGroup componentsOverriden);
            /*0x7be9030*/ void UpdateInstanceDataBufferLayoutVersion();
            /*0x7be9318*/ Unity.Jobs.JobHandle OnPerformCulling(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            /*0x7be9704*/ void OnFinishedCulling(nint customCullingResult);
            /*0x7be9730*/ void DestroyInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7be9754*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x7be9a20*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x7be9c2c*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x7be9c30*/ void RegisterBatchMeshes(Unity.Collections.NativeArray<int> meshIDs);
            /*0x7bea06c*/ void RegisterBatchMaterials(ref Unity.Collections.NativeArray<int> usedMaterialIDs);
            /*0x7bea4d4*/ void BuildBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<int> usedMaterialIDs, Unity.Collections.NativeArray<int> usedMeshIDs, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData);
            /*0x7bea690*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask);
            /*0x7bea6a0*/ void UpdateFrame();
            /*0x7bea6ac*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x7bea6e0*/ void OnEndContextRendering();
            /*0x7bea744*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x7bea750*/ void OnEndCameraRendering(UnityEngine.Camera camera);
        }

        struct GPUInstanceComponentDesc
        {
            /*0x10*/ int propertyID;
            /*0x14*/ int byteSize;
            /*0x18*/ bool isOverriden;
            /*0x19*/ bool isPerInstance;
            /*0x1c*/ UnityEngine.Rendering.InstanceType instanceType;
            /*0x20*/ UnityEngine.Rendering.InstanceComponentGroup componentGroup;

            /*0x7bea75c*/ GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, UnityEngine.Rendering.InstanceType inInstanceType, UnityEngine.Rendering.InstanceComponentGroup inComponentType);
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

            static /*0x7bea778*/ int NextVersion();
            static /*0x7bea7c8*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(ref Unity.Collections.NativeArray<int> instancesNumPrefixSum, UnityEngine.Rendering.InstanceHandle instance);
            /*0x7beacd8*/ GPUInstanceDataBuffer();
            /*0x7bea9d0*/ int GetPropertyIndex(int propertyID, bool assertOnFail);
            /*0x7beaa40*/ int GetGpuAddress(int propertyID, bool assertOnFail);
            /*0x7beaa68*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x7beab10*/ void Dispose();
            /*0x7beaca0*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly AsReadOnly();

            struct ReadOnly
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;

                /*0x7beacbc*/ ReadOnly(UnityEngine.Rendering.GPUInstanceDataBuffer buffer);
                /*0x7beace0*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(UnityEngine.Rendering.InstanceHandle instance);
                /*0x7beacf8*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            }

            struct ConvertCPUInstancesToGPUInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices;

                /*0x7beada8*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferBuilder : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceComponentDesc> m_Components;

            /*0x7beadd8*/ UnityEngine.Rendering.MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden);
            /*0x3907c14*/ void AddComponent<T>(int propertyID, bool isOverriden, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x7beadf4*/ void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x7beaf1c*/ UnityEngine.Rendering.GPUInstanceDataBuffer Build(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7beb96c*/ void Dispose();
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

            /*0x7beb9d4*/ GPUInstanceDataBufferUploader(ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceComponentDesc> descriptions, int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x7bebc40*/ nint GetUploadBufferPtr();
            /*0x7bebc88*/ int GetUIntPerInstance();
            /*0x7bebc90*/ int GetParamUIntOffset(int parameterIndex);
            /*0x380b6cc*/ int PrepareParamWrite<T>(int parameterIndex);
            /*0x7bebc9c*/ void AllocateUploadHandles(int handlesLength);
            /*0x3907c14*/ Unity.Jobs.JobHandle WriteInstanceDataJob<T>(int parameterIndex, Unity.Collections.NativeArray<T> instanceData, Unity.Collections.NativeArray<int> gatherIndices);
            /*0x7bebca4*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x7bec33c*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x7bec420*/ void Dispose();

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

                static /*0x7bec54c*/ UploadKernelIDs();
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

                /*0x7bec78c*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x7bec160*/ void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount);
                /*0x7bec848*/ void Dispose();
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

                /*0x7bec8a8*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferGrower : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_SrcBuffer;
            /*0x18*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_DstBuffer;

            /*0x7bec96c*/ GPUInstanceDataBufferGrower(UnityEngine.Rendering.GPUInstanceDataBuffer sourceBuffer, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7becba4*/ UnityEngine.Rendering.GPUInstanceDataBuffer SubmitToGpu(ref UnityEngine.Rendering.GPUInstanceDataBufferGrower.GPUResources gpuResources);
            /*0x7bece9c*/ void Dispose();

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

                static /*0x7becea0*/ CopyInstancesKernelIDs();
            }

            struct GPUResources : System.IDisposable
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelId;

                /*0x7bed0e0*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x7bece90*/ void CreateResources();
                /*0x7bed198*/ void Dispose();
            }
        }

        struct InstanceHandle : System.IEquatable<UnityEngine.Rendering.InstanceHandle>, System.IComparable<UnityEngine.Rendering.InstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.InstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7bed33c*/ InstanceHandle();
            static /*0x7bed1b4*/ UnityEngine.Rendering.InstanceHandle FromInt(int value);
            /*0x7bed1a4*/ int get_index();
            /*0x7bed1ac*/ void set_index(int value);
            /*0x7bea978*/ int get_instanceIndex();
            /*0x7bea920*/ UnityEngine.Rendering.InstanceType get_type();
            /*0x7bea8c4*/ bool get_valid();
            /*0x7bed208*/ bool Equals(UnityEngine.Rendering.InstanceHandle other);
            /*0x7bed270*/ int CompareTo(UnityEngine.Rendering.InstanceHandle other);
            /*0x7bed2e8*/ int GetHashCode();
        }

        struct SharedInstanceHandle : System.IEquatable<UnityEngine.Rendering.SharedInstanceHandle>, System.IComparable<UnityEngine.Rendering.SharedInstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.SharedInstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7bed4cc*/ SharedInstanceHandle();
            /*0x7bed388*/ int get_index();
            /*0x7bed390*/ void set_index(int value);
            /*0x7bed398*/ bool Equals(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x7bed400*/ int CompareTo(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x7bed478*/ int GetHashCode();
        }

        struct GPUInstanceIndex : System.IEquatable<UnityEngine.Rendering.GPUInstanceIndex>, System.IComparable<UnityEngine.Rendering.GPUInstanceIndex>
        {
            static /*0x0*/ UnityEngine.Rendering.GPUInstanceIndex Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x7bed65c*/ GPUInstanceIndex();
            /*0x7bed518*/ int get_index();
            /*0x7bed520*/ void set_index(int value);
            /*0x7bed528*/ bool Equals(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x7bed590*/ int CompareTo(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x7bed608*/ int GetHashCode();
        }

        struct InstanceAllocator
        {
            /*0x10*/ Unity.Collections.NativeArray<int> m_StructData;
            /*0x20*/ Unity.Collections.NativeList<int> m_FreeInstances;
            /*0x28*/ int m_BaseInstanceOffset;
            /*0x2c*/ int m_InstanceStride;

            /*0x7bed6a8*/ int get_length();
            /*0x7bed6b4*/ void set_length(int value);
            /*0x7bed6c0*/ void Initialize(int baseInstanceOffset, int instanceStride);
            /*0x7bed780*/ void Dispose();
            /*0x7bed7f0*/ int AllocateInstance();
            /*0x7bed91c*/ void FreeInstance(int instance);
            /*0x7bed978*/ int GetNumAllocated();
        }

        struct InstanceAllocators
        {
            /*0x10*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_MeshRenderer;
            /*0x30*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_SpeedTree;
            /*0x50*/ UnityEngine.Rendering.InstanceAllocator m_SharedInstanceAlloc;

            /*0x7bed9e0*/ void Initialize();
            /*0x7beda40*/ void Dispose();
            /*0x7beda60*/ UnityEngine.Rendering.InstanceAllocator GetInstanceAllocator(UnityEngine.Rendering.InstanceType type);
            /*0x7bedad0*/ int GetInstanceHandlesLength(UnityEngine.Rendering.InstanceType type);
            /*0x7bedaf4*/ int GetInstancesLength(UnityEngine.Rendering.InstanceType type);
            /*0x7bedb20*/ UnityEngine.Rendering.InstanceHandle AllocateInstance(UnityEngine.Rendering.InstanceType type);
            /*0x7bedbb8*/ void FreeInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7bedc4c*/ UnityEngine.Rendering.SharedInstanceHandle AllocateSharedInstance();
            /*0x7bedcb0*/ void FreeSharedInstance(UnityEngine.Rendering.SharedInstanceHandle instance);
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

            /*0x7bedd14*/ int get_instancesLength();
            /*0x7bedd20*/ void set_instancesLength(int value);
            /*0x7bedd2c*/ int get_instancesCapacity();
            /*0x7bedd38*/ void set_instancesCapacity(int value);
            /*0x7bedd44*/ void Initialize(int initCapacity);
            /*0x7bee0a0*/ void Dispose();
            /*0x7bee1b8*/ void Grow(int newCapacity);
            /*0x7bee3e4*/ void AddUnsafe(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7bee5b0*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7bee644*/ UnityEngine.Rendering.InstanceHandle IndexToInstance(int index);
            /*0x7bee650*/ bool IsValidInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7bee7a0*/ int GetFreeInstancesCount();
            /*0x7bee7b0*/ void EnsureFreeInstances(int instancesCount);
            /*0x7bee7d8*/ void AddNoGrow(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7bee8a8*/ void Remove(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7beea90*/ void Set(UnityEngine.Rendering.InstanceHandle instance, UnityEngine.Rendering.SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, ref UnityEngine.Rendering.AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame);
            /*0x7bee804*/ void SetDefault(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7beeb7c*/ UnityEngine.Rendering.SharedInstanceHandle Get_SharedInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x7beeb9c*/ void Set_TetrahedronCacheIndex(UnityEngine.Rendering.InstanceHandle instance, int tetrahedronCacheIndex);
            /*0x7beebc8*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly AsReadOnly();

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

                /*0x7beebfc*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
                /*0x7beeef4*/ int get_handlesLength();
                /*0x7beef30*/ int get_instancesLength();
                /*0x7beef70*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
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

            /*0x7bef000*/ int get_instancesLength();
            /*0x7bef00c*/ void set_instancesLength(int value);
            /*0x7bef018*/ int get_instancesCapacity();
            /*0x7bef024*/ void set_instancesCapacity(int value);
            /*0x7bef030*/ void Initialize(int initCapacity);
            /*0x7bef360*/ void Dispose();
            /*0x7bef6dc*/ void Grow(int newCapacity);
            /*0x7bef94c*/ void AddUnsafe(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7befb18*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7befbac*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData instanceData, UnityEngine.Rendering.InstanceHandle instance);
            /*0x7befc00*/ int GetFreeInstancesCount();
            /*0x7befc10*/ void EnsureFreeInstances(int instancesCount);
            /*0x7befc38*/ void AddNoGrow(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7befcdc*/ void Remove(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7befeec*/ int Get_RendererGroupID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7beff0c*/ int Get_MeshID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7beff2c*/ int Get_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7beff4c*/ void Set_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance, int refCount);
            /*0x7beff78*/ void Set(UnityEngine.Rendering.SharedInstanceHandle instance, int rendererGroupID, ref UnityEngine.Rendering.SmallIntegerArray materialIDs, int meshID, ref UnityEngine.Rendering.AABB localAABB, UnityEngine.Rendering.TransformUpdateFlags transformUpdateFlags, UnityEngine.Rendering.InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount);
            /*0x7befc64*/ void SetDefault(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x7bf00c0*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly AsReadOnly();

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

                /*0x7bf00f4*/ ReadOnly(ref UnityEngine.Rendering.CPUSharedInstanceData instanceData);
                /*0x7bf0490*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
                /*0x7bf0520*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, UnityEngine.Rendering.InstanceHandle instance);
            }
        }

        struct SmallIntegerArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<int> m_FixedArray;
            /*0x30*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<int> m_List;
            /*0x48*/ bool m_IsEmbedded;
            /*0x49*/ bool <Valid>k__BackingField;
            /*0x4c*/ int Length;

            /*0x7bf05b8*/ SmallIntegerArray(int length, Unity.Collections.Allocator allocator);
            /*0x7bf05a4*/ bool get_Valid();
            /*0x7bf05ac*/ void set_Valid(bool value);
            /*0x7bf0764*/ int get_Item(int index);
            /*0x7bf085c*/ void set_Item(int index, int value);
            /*0x7bef684*/ void Dispose();
        }

        struct EditorInstanceDataArrays
        {
            /*0x7bee09c*/ void Initialize(int initCapacity);
            /*0x7bee1b4*/ void Dispose();
            /*0x7bee3e0*/ void Grow(int newCapacity);
            /*0x7beea8c*/ void Remove(int index, int lastIndex);
            /*0x7beeb78*/ void SetDefault(int index);

            struct ReadOnly
            {
                /*0x7beef6c*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
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

            static /*0x7bf0960*/ UnityEngine.Rendering.PackedMatrix FromMatrix4x4(ref UnityEngine.Matrix4x4 m);
            static /*0x7bf09a4*/ UnityEngine.Rendering.PackedMatrix FromFloat4x4(ref Unity.Mathematics.float4x4 m);
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

            static /*0x3826a14*/ int AtomicAddLengthNoResize<T>(ref Unity.Collections.NativeList<T> list, int count);
            /*0x7bf0ae4*/ InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7bf09e8*/ bool get_hasBoundingSpheres();
            /*0x7bf09f0*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x7bf0a40*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x7bf0a90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x7bf0d4c*/ void Dispose();
            /*0x7bf0e08*/ int GetMaxInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7bf0e30*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7bf0e60*/ void EnsureIndexQueueBufferCapacity(int capacity);
            /*0x7bf0f08*/ void EnsureProbeBuffersCapacity(int capacity);
            /*0x7bf1084*/ void EnsureTransformBuffersCapacity(int capacity);
            /*0x7bf1228*/ Unity.Jobs.JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeUpdateInstanceQueue, Unity.Collections.NativeArray<int> compactTetrahedronCache, Unity.Collections.NativeArray<UnityEngine.Vector3> probeQueryPosition, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue);
            /*0x7bf13c8*/ void DispatchProbeUpdateCommand(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf16b0*/ void DispatchMotionUpdateCommand(int motionQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf1920*/ void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.TransformUpdatePacket> updateDataQueue, Unity.Collections.NativeArray<Unity.Mathematics.float4> boundingSphereUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf1cc8*/ void DispatchWindDataCopyHistoryCommand(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf1f34*/ void UpdateInstanceMotionsData(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf211c*/ void UpdateInstanceTransformsData(bool initialize, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf2754*/ void UpdateInstanceProbesData(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf2a70*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf2ad0*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf2e1c*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x7bf2edc*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap);
            /*0x7bf3048*/ void UpdateAllInstanceProbes(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf30e0*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf3124*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf3160*/ void UpdateInstanceMotions(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x7bf3174*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf3220*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf3334*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> instancesOffset, Unity.Collections.NativeArray<int> instancesCount, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf352c*/ Unity.Jobs.JobHandle ScheduleQuerySortedMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7bf365c*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x7bf3a58*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);

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

                static /*0x7bf3b38*/ InstanceTransformUpdateIDs();
            }

            class InstanceWindDataUpdateIDs
            {
                static /*0x0*/ int _WindDataQueueCount;
                static /*0x4*/ int _WindDataUpdateIndexQueue;
                static /*0x8*/ int _WindDataBuffer;
                static /*0xc*/ int _WindParamAddressArray;
                static /*0x10*/ int _WindHistoryParamAddressArray;

                static /*0x7bf3e54*/ InstanceWindDataUpdateIDs();
            }

            struct QueryRendererGroupInstancesCountJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x1a8*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x1b8*/ Unity.Collections.NativeArray<int> instancesCount;

                /*0x7bf3f7c*/ void Execute(int startIndex, int count);
            }

            struct ComputeInstancesOffsetAndResizeInstancesArrayJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesCount;
                /*0x20*/ Unity.Collections.NativeArray<int> instancesOffset;
                /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x7bf4060*/ void Execute();
            }

            struct QueryRendererGroupInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x20*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x40*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

                /*0x7bf40e8*/ void Execute(int startIndex, int count);
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

                /*0x7bf41f8*/ void Execute(int startIndex, int count);
            }

            struct QuerySortedMeshInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<int> sortedMeshID;
                /*0x1a8*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x7bf43a8*/ void Execute(int startIndex, int count);
            }

            struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int probesCount;
                /*0x18*/ UnityEngine.LightProbesQuery lightProbesQuery;
                /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Vector3> queryPostitions;
                /*0x38*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probesSphericalHarmonics;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Vector4> probesOcclusion;

                /*0x7bf45c0*/ void Execute(int index);
            }

            struct ScatterTetrahedronCacheIndicesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstances;
                /*0x20*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x7bf4714*/ void Execute(int index);
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

                /*0x7bf4750*/ void Execute(int startIndex, int count);
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

                /*0x7bf4da0*/ void Execute(int startIndex, int count);
            }

            struct MotionUpdateJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int queueWriteBase;
                /*0x18*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf8*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicUpdateQueueCount;
                /*0x100*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformUpdateInstanceQueue;

                /*0x7bf5040*/ void Execute(int chunk_index);
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

                /*0x7bf51f4*/ void Execute();
            }

            struct FreeInstancesJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.InstanceAllocators instanceAllocators;
                /*0x80*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x160*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x208*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;

                /*0x7bf5570*/ void Execute();
            }

            struct FreeRendererGroupInstancesJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<int> rendererGroupsID;
                /*0x20*/ UnityEngine.Rendering.InstanceAllocators instanceAllocators;
                /*0x80*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x160*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x208*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;

                /*0x7bf588c*/ void Execute();
            }

            struct UpdateRendererInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ bool implicitInstanceIndices;
                /*0x18*/ UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData;
                /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x1e8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap;
                /*0x1f8*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x2d8*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;

                /*0x7bf5b40*/ void Execute(int index);
            }

            struct CollectInstancesLODGroupsAndMasksJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
                /*0xf8*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<uint> lodGroupAndMasks;

                /*0x7bf602c*/ void Execute(int index);
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

                /*0x7bf60bc*/ void Execute(int startIndex, int count);
            }

            struct UpdateCompactedInstanceVisibilityJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x7bf6360*/ void Execute(int startIndex, int count);
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

            static /*0x7bf6448*/ InstanceTypeInfo();
            static /*0x7bf645c*/ void InitParentTypes();
            static /*0x7bf651c*/ void InitChildTypes();
            static /*0x7bf688c*/ void FlattenChildInstanceTypes(UnityEngine.Rendering.InstanceType instanceType, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceType> instanceTypes);
            static /*0x7bf6760*/ void ValidateTypeRelationsAreCorrectlySorted();
            static /*0x7bf6a50*/ System.Collections.Generic.List<UnityEngine.Rendering.InstanceType> GetChildTypes(UnityEngine.Rendering.InstanceType type);
        }

        struct InstanceNumInfo
        {
            /*0x10*/ UnityEngine.Rendering.InstanceNumInfo.<InstanceNums> InstanceNums;

            /*0x7bf6ad4*/ InstanceNumInfo(int meshRendererNum, int speedTreeNum);
            /*0x7bf6acc*/ void InitDefault();
            /*0x7bece94*/ int GetInstanceNum(UnityEngine.Rendering.InstanceType type);
            /*0x7beb7fc*/ int GetInstanceNumIncludingChildren(UnityEngine.Rendering.InstanceType type);
            /*0x7bece84*/ int GetTotalInstanceNum();

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

            static /*0x7bf6adc*/ UnityEngine.Rendering.OccluderDerivedData FromParameters(ref UnityEngine.Rendering.OccluderSubviewUpdate occluderSubviewUpdate);
        }

        struct OccluderHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle occluderDepthPyramid;
            /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle occlusionDebugOverlay;

            /*0x7bf6e0c*/ bool IsValid();
            /*0x7bf6f14*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
            /*0x7bf7070*/ void UseForOccluderUpdate(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
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

            /*0x7bf71cc*/ bool IsEmpty();
            /*0x7bf71dc*/ bool IsWithinLimits(ref UnityEngine.Rendering.IndirectBufferLimits limits);
            /*0x7bf7210*/ int GetExtraDrawInfoSlotIndex();
        }

        struct IndirectBufferContext
        {
            /*0x10*/ Unity.Jobs.JobHandle cullingJobHandle;
            /*0x20*/ UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState;
            /*0x24*/ int occluderVersion;
            /*0x28*/ int subviewMask;

            /*0x7bf721c*/ IndirectBufferContext(Unity.Jobs.JobHandle cullingJobHandle);
            /*0x7bf722c*/ bool Matches(UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState, int occluderVersion, int subviewMask);

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

            static /*0x7bf781c*/ void SetKeyword(UnityEngine.Rendering.ComputeCommandBuffer cmd, UnityEngine.ComputeShader cs, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7bf725c*/ int get_subviewCount();
            /*0x7bf7264*/ bool IsSubviewValid(int subviewIndex);
            /*0x7bf7288*/ UnityEngine.Vector2 get_depthBufferSizeInOccluderPixels();
            /*0x7bf72a0*/ void Dispose();
            /*0x7bf73dc*/ void UpdateMipBounds();
            /*0x7bf7598*/ void AllocateTexturesIfNecessary(bool debugOverlayEnabled);
            /*0x7bf783c*/ UnityEngine.Rendering.OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes);
            /*0x7bf7c48*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes, UnityEngine.ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel);
            /*0x7bf80f4*/ UnityEngine.Rendering.OccluderHandles Import(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x7bf81c4*/ void PrepareOccluders(ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x7bf82bc*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetDebugOutput();

            class ShaderIDs
            {
                static /*0x0*/ int _SrcDepth;
                static /*0x4*/ int _DstDepth;
                static /*0x8*/ int OccluderDepthPyramidConstants;

                static /*0x7bf83f0*/ ShaderIDs();
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

            static /*0x7bf84b8*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings FromSpan(System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
        }

        struct IndirectBufferContextHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceBuffer;
            /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceInfoBuffer;
            /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle argsBuffer;
            /*0x34*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle drawInfoBuffer;

            /*0x7bf8584*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
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

            /*0x7bf8794*/ UnityEngine.GraphicsBuffer get_instanceBuffer();
            /*0x7bf879c*/ UnityEngine.GraphicsBuffer get_instanceInfoBuffer();
            /*0x7bf87a4*/ UnityEngine.GraphicsBuffer get_argsBuffer();
            /*0x7bf87ac*/ UnityEngine.GraphicsBuffer get_drawInfoBuffer();
            /*0x7bf87b4*/ UnityEngine.GraphicsBufferHandle get_visibleInstanceBufferHandle();
            /*0x7bf87d8*/ UnityEngine.GraphicsBufferHandle get_indirectArgsBufferHandle();
            /*0x7bf87fc*/ UnityEngine.Rendering.IndirectBufferContextHandles ImportBuffers(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x7bf88d0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectInstanceInfo> get_instanceInfoGlobalArray();
            /*0x7bf88dc*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectDrawInfo> get_drawInfoGlobalArray();
            /*0x7bf88e8*/ Unity.Collections.NativeArray<int> get_allocationCounters();
            /*0x7bf88f4*/ void Init();
            /*0x7bf8a48*/ void AllocateInstanceBuffers(int maxInstanceCount);
            /*0x7bf8d80*/ void FreeInstanceBuffers();
            /*0x7bf8b88*/ void AllocateDrawBuffers(int maxDrawCount);
            /*0x7bf8df4*/ void FreeDrawBuffers();
            /*0x7bf8e68*/ void Dispose();
            /*0x7bf8f38*/ void SyncContexts();
            /*0x7bf8ccc*/ void ResetAllocators();
            /*0x7bf9018*/ void GrowBuffers();
            /*0x7bf91c0*/ void ClearContextsAndGrowBuffers();
            /*0x7bf91e0*/ int TryAllocateContext(int viewID);
            /*0x7bf9324*/ int TryGetContextIndex(int viewID);
            /*0x7bf939c*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex);
            /*0x7bf93f8*/ UnityEngine.Rendering.IndirectBufferAllocInfo GetAllocInfo(int contextIndex);
            /*0x7bf947c*/ void CopyFromStaging(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.IndirectBufferAllocInfo allocInfo);
            /*0x7bf9540*/ UnityEngine.Rendering.IndirectBufferLimits GetLimits(int contextIndex);
            /*0x7bf9554*/ UnityEngine.Rendering.IndirectBufferContext GetBufferContext(int contextIndex);
            /*0x7bf9624*/ void SetBufferContext(int contextIndex, UnityEngine.Rendering.IndirectBufferContext ctx);
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

            /*0x7bf96f4*/ void Execute(int index);
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

            /*0x7bf98dc*/ void Execute();
        }

        struct UpdateLODGroupDataJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances;
            /*0x20*/ UnityEngine.Rendering.GPUDrivenLODGroupData inputData;
            /*0xe0*/ bool supportDitheringCrossFade;
            /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0xf8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupCullingData> lodGroupsCullingData;
            /*0x108*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 rendererCount;

            /*0x7bf9b58*/ void Execute(int index);
        }

        struct FreeLODGroupDataJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> destroyedLODGroupsID;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash;
            /*0x38*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles;
            /*0x40*/ int* removedRendererCount;

            /*0x7bf9e28*/ void Execute();
        }

        class LODGroupDataPool : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> m_LODGroupData;
            /*0x18*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> m_LODGroupDataHash;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> m_LODGroupCullingData;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> m_FreeLODGroupDataHandles;
            /*0x38*/ int m_CrossfadedRendererCount;
            /*0x3c*/ bool m_SupportDitheringCrossFade;

            /*0x7bfa0d4*/ LODGroupDataPool(UnityEngine.Rendering.GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade);
            /*0x7bfa0b8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> get_lodGroupDataHash();
            /*0x7bfa0c4*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x7bfa0cc*/ int get_crossfadedRendererCount();
            /*0x7bfa224*/ void Dispose();
            /*0x7bfa2dc*/ void UpdateLODGroupTransformData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x7bfa49c*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x7bfa7b4*/ void FreeLODGroupData(Unity.Collections.NativeArray<int> destroyedLODGroupsID);
        }

        class LODGroupRenderingUtils
        {
            static /*0x7bfa854*/ float CalculateFOVHalfAngle(float fieldOfView);
            static /*0x7bfa86c*/ float CalculateScreenRelativeMetric(UnityEngine.Rendering.LODParameters lodParams, float lodBias);
            static /*0x7bfa8d0*/ float CalculateSqrPerspectiveDistance(UnityEngine.Vector3 objPosition, UnityEngine.Vector3 camPosition, float sqrScreenRelativeMetric);
            static /*0x7bf98d4*/ float CalculateLODDistance(float relativeScreenHeight, float size);
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

            /*0x7bfa8f8*/ void Init(UnityEngine.ComputeShader cs);
        }

        struct SilhouettePlaneCache : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<int, int> m_SubviewIDToIndexMap;
            /*0x20*/ Unity.Collections.NativeList<int> m_SlotFreeList;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.SilhouettePlaneCache.Slot> m_Slots;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Plane> m_PlaneStorage;

            /*0x7bfa994*/ void Init();
            /*0x7bfaad8*/ void Dispose();
            /*0x7bfab90*/ void Update(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes, int frameIndex);
            /*0x7bfafa4*/ void FreeUnusedSlots(int frameIndex, int maximumAge);
            /*0x7bfb12c*/ Unity.Collections.NativeArray<UnityEngine.Plane> GetSubArray(int viewInstanceID);

            struct Slot
            {
                /*0x10*/ bool isActive;
                /*0x14*/ int viewInstanceID;
                /*0x18*/ int planeCount;
                /*0x1c*/ int lastUsedFrameIndex;

                /*0x7bfaf90*/ Slot(int viewInstanceID, int planeCount, int frameIndex);
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

            static /*0x7bfe9a8*/ OcclusionCullingCommon();
            static /*0x7bfb658*/ bool UseOcclusionDebug(ref UnityEngine.Rendering.OccluderContext occluderCtx);
            static /*0x7bfbe04*/ void SetDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            static /*0x7bfbe9c*/ void SetDebugPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x7bfe9a0*/ OcclusionCullingCommon();
            /*0x7bfb240*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7bfb668*/ void PrepareCulling(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, bool useOcclusionDebug);
            /*0x7bfbf74*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x7bfc908*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x7bfbbb4*/ void DispatchDebugClear(UnityEngine.Rendering.ComputeCommandBuffer cmd, int viewInstanceID);
            /*0x7bfce64*/ UnityEngine.Rendering.OccluderHandles PrepareOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x7bfd5a8*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x7bfd7d8*/ bool UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x7bfdf28*/ void UpdateSilhouettePlanes(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes);
            /*0x7bfc7a0*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID);
            /*0x7bfdf34*/ void UpdateOccluderStats(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x7bfe318*/ bool HasOccluderContext(int viewInstanceID);
            /*0x7bfe370*/ bool GetOccluderContext(int viewInstanceID, ref UnityEngine.Rendering.OccluderContext occluderContext);
            /*0x7bfe4ac*/ void UpdateFrame();
            /*0x7bfd0d8*/ int NewContext(int viewInstanceID);
            /*0x7bfd3fc*/ void DeleteContext(int viewInstanceID);
            /*0x7bfe738*/ void Dispose();
            /*0x7bfe9f4*/ void <RenderDebugOcclusionTestOverlay>b__29_1(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);

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

                static /*0x7bfeaf8*/ ShaderIDs();
            }

            class OcclusionTestOverlaySetupPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingDebugShaderVariables cb;

                /*0x7bfebf4*/ OcclusionTestOverlaySetupPassData();
            }

            class OcclusionTestOverlayPassData
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle debugPyramid;

                /*0x7bfebfc*/ OcclusionTestOverlayPassData();
            }

            class OccluderOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugMaterial;
                /*0x18*/ UnityEngine.Rendering.RTHandle occluderTexture;
                /*0x20*/ UnityEngine.Rect viewport;
                /*0x30*/ int passIndex;
                /*0x34*/ UnityEngine.Vector2 validRange;

                /*0x7bfec04*/ OccluderOverlayPassData();
            }

            class UpdateOccludersPassData
            {
                /*0x10*/ UnityEngine.Rendering.OccluderParameters occluderParams;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates;
                /*0x40*/ UnityEngine.Rendering.OccluderHandles occluderHandles;

                /*0x7bfec0c*/ UpdateOccludersPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.OcclusionCullingCommon.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__29_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__32_0;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__37_0;

                static /*0x7bfec14*/ <>c();
                /*0x7bfec7c*/ <>c();
                /*0x7bfec84*/ void <RenderDebugOcclusionTestOverlay>b__29_0(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x7bfedf4*/ void <RenderDebugOccluderOverlay>b__32_0(UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);
                /*0x7bfef7c*/ void <UpdateInstanceOccluders>b__37_0(UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
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

            /*0x7bfb81c*/ OcclusionCullingCommonShaderVariables(ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass);

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

            static /*0x7bff1f4*/ UnityEngine.Rendering.RenderersBatchersContextDesc NewDefault();
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

            /*0x7bff414*/ RenderersBatchersContext(ref UnityEngine.Rendering.RenderersBatchersContextDesc desc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x7bff230*/ UnityEngine.Rendering.RenderersParameters get_renderersParameters();
            /*0x7bff240*/ UnityEngine.GraphicsBuffer get_gpuInstanceDataBuffer();
            /*0x7bff25c*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.GPUInstanceComponentDesc> get_defaultDescriptions();
            /*0x7bff2b0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> get_defaultMetadata();
            /*0x7bff2cc*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x7bff2e8*/ int get_instanceDataBufferLayoutVersion();
            /*0x7bff304*/ int get_crossfadedRendererCount();
            /*0x7bff320*/ bool get_hasBoundingSpheres();
            /*0x7bff33c*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x7bff37c*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x7bff3bc*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly get_instanceDataBuffer();
            /*0x7bff3d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x7bff3f4*/ float get_smallMeshScreenPercentage();
            /*0x7bff3fc*/ UnityEngine.Rendering.GPUResidentDrawerResources get_resources();
            /*0x7bff404*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x7bff40c*/ UnityEngine.Rendering.DebugRendererBatcherStats get_debugStats();
            /*0x7bffe50*/ void Dispose();
            /*0x7bfffcc*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x7bfffe8*/ void GrowInstanceBuffer(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x7c00128*/ void EnsureInstanceBufferCapacity();
            /*0x7c00208*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x7c00220*/ void TransformLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x7c00238*/ void DestroyLODGroups(Unity.Collections.NativeArray<int> destroyed);
            /*0x7c0025c*/ void UpdateLODGroups(Unity.Collections.NativeArray<int> changedID);
            /*0x7c002e8*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c00310*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData);
            /*0x7c00338*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x7c00354*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c00370*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c0038c*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x7c003a8*/ void ChangeInstanceBufferVersion();
            /*0x7c003cc*/ UnityEngine.Rendering.GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x7c0040c*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x7c00438*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x7c00464*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices);
            /*0x7c004b0*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x7c004f4*/ void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate);
            /*0x7c005c4*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x7c00660*/ void UpdateInstanceMotions();
            /*0x7c006a0*/ void TransformLODGroups(Unity.Collections.NativeArray<int> lodGroupsID);
            /*0x7c0072c*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);
            /*0x7c00748*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x7c00768*/ void UpdateFrame();
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

            static /*0x7c00860*/ RenderersParameters();
            static /*0x7bff7dc*/ UnityEngine.Rendering.GPUInstanceDataBuffer CreateInstanceDataBuffer(UnityEngine.Rendering.RenderersParameters.Flags flags, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            static /*0x7c007a0*/ UnityEngine.Rendering.RenderersParameters.ParamInfo <.ctor>g__GetParamInfo|14_0(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail);
            /*0x7bffba0*/ RenderersParameters(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer);

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

                static /*0x7c008b8*/ ParamNames();
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
            static /*0x3907c14*/ T* Malloc<T>(int count, Unity.Collections.Allocator allocator);
        }

        struct ParallelBitArray
        {
            /*0x10*/ Unity.Collections.Allocator m_Allocator;
            /*0x18*/ Unity.Collections.NativeArray<long> m_Bits;
            /*0x28*/ int m_Length;

            /*0x7c00c38*/ ParallelBitArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x7c00bec*/ int get_Length();
            /*0x7c00bf4*/ bool get_IsCreated();
            /*0x7c00cd8*/ void Dispose();
            /*0x7c00d28*/ void Resize(int newLength);
            /*0x7c00ee8*/ void Set(int index, bool value);
            /*0x7c00f90*/ bool Get(int index);
            /*0x7c00ff8*/ ulong GetChunk(int chunk_index);
            /*0x7c01004*/ void SetChunk(int chunk_index, ulong chunk_bits);
            /*0x7c01010*/ void InterlockedOrChunk(int chunk_index, ulong chunk_bits);
            /*0x7c0109c*/ UnityEngine.Rendering.ParallelBitArray GetSubArray(int length);
        }

        class ParallelSortExtensions
        {
            static /*0x7c0111c*/ Unity.Jobs.JobHandle ParallelSort(Unity.Collections.NativeArray<int> array);
            static /*0x7c0162c*/ void <ParallelSort>g__Swap|2_0(ref Unity.Collections.NativeArray<int> a, ref Unity.Collections.NativeArray<int> b);

            struct RadixSortBucketCountJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int jobsCount;
                /*0x18*/ int batchSize;
                /*0x20*/ Unity.Collections.NativeArray<int> array;
                /*0x30*/ Unity.Collections.NativeArray<int> buckets;

                /*0x7c0164c*/ void Execute(int index);
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

                static /*0x7c016b4*/ int AtomicIncrement(Unity.Collections.NativeArray<int> counter);
                /*0x7c01720*/ int JobIndexPrefixSum(int sum, int i);
                /*0x7c01768*/ void Execute(int index);
            }

            struct RadixSortPrefixSumJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int jobsCount;
                /*0x18*/ Unity.Collections.NativeArray<int> indicesSum;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;

                /*0x7c01854*/ void Execute(int index);
            }

            struct RadixSortBucketSortJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int batchSize;
                /*0x18*/ Unity.Collections.NativeArray<int> array;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;
                /*0x38*/ Unity.Collections.NativeArray<int> arraySorted;

                /*0x7c018cc*/ void Execute(int index);
            }
        }
    }
}

class __JobReflectionRegistrationOutput__15867191014387474753
{
    static /*0x7c0193c*/ void CreateJobReflectionData();
    static /*0x7c01eec*/ void EarlyInit();
}
