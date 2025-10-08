class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3b9b064*/ EmbeddedAttribute();
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
                /*0x3b9b06c*/ IsUnmanagedAttribute();
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

            static /*0x3b9b16c*/ Unity.Mathematics.float3 RotateExtents(Unity.Mathematics.float3 extents, Unity.Mathematics.float3 m0, Unity.Mathematics.float3 m1, Unity.Mathematics.float3 m2);
            static /*0x3b9b1e0*/ UnityEngine.Rendering.AABB Transform(Unity.Mathematics.float4x4 transform, UnityEngine.Rendering.AABB localBounds);
            /*0x3b9b074*/ Unity.Mathematics.float3 get_min();
            /*0x3b9b094*/ Unity.Mathematics.float3 get_max();
            /*0x3b9b0b4*/ string ToString();
        }

        class AABBExtensions
        {
            static /*0x3b9b2b4*/ UnityEngine.Rendering.AABB ToAABB(UnityEngine.Bounds bounds);
            static /*0x3b9b31c*/ UnityEngine.Bounds ToBounds(UnityEngine.Rendering.AABB aabb);
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

            static /*0x3b9b5c0*/ UnityEngine.Rendering.InstanceCullerViewStats GetInstanceCullerViewStats(int viewIndex);
            static /*0x3b9b684*/ UnityEngine.Rendering.InstanceOcclusionEventStats GetInstanceOcclusionEventStats(int passIndex);
            static /*0x3b9b758*/ UnityEngine.Rendering.DebugOccluderStats GetOccluderStats(int occluderIndex);
            static /*0x3b9b80c*/ int GetOcclusionContextsCounts();
            static /*0x3b9b86c*/ int GetInstanceCullerViewCount();
            static /*0x3b9b8cc*/ int GetInstanceOcclusionEventCount();
            static /*0x3b9b92c*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceCullerViewDataRow(int viewIndex);
            static /*0x3b9bf20*/ object OccluderVersionString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9bf98*/ object OcclusionTestString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9c010*/ object VisibleInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9c07c*/ object CulledInstancesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9c0e8*/ object VisiblePrimitivesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9c154*/ object CulledPrimitivesString(ref UnityEngine.Rendering.InstanceOcclusionEventStats stats);
            static /*0x3b9c1c0*/ UnityEngine.Rendering.DebugUI.Table.Row AddInstanceOcclusionPassDataRow(int eventIndex);
            static /*0x3b9c974*/ UnityEngine.Rendering.DebugUI.Table.Row AddOcclusionContextDataRow(int index);
            /*0x3b9dcb8*/ DebugDisplayGPUResidentDrawer();
            /*0x3b9b384*/ bool get_displayBatcherStats();
            /*0x3b9b408*/ void set_displayBatcherStats(bool value);
            /*0x3b9b428*/ bool GetOccluderViewInstanceID(ref int viewInstanceID);
            /*0x3b9b500*/ bool get_occlusionTestOverlayEnable();
            /*0x3b9b520*/ void set_occlusionTestOverlayEnable(bool value);
            /*0x3b9b540*/ bool get_occlusionTestOverlayCountVisible();
            /*0x3b9b560*/ void set_occlusionTestOverlayCountVisible(bool value);
            /*0x3b9b580*/ bool get_overrideOcclusionTestToAlwaysPass();
            /*0x3b9b5a0*/ void set_overrideOcclusionTestToAlwaysPass(bool value);
            /*0x3b9cd08*/ bool get_AreAnySettingsActive();
            /*0x3b9cd28*/ bool get_IsPostProcessingAllowed();
            /*0x3b9cd30*/ bool get_IsLightingActive();
            /*0x3b9cd38*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
            /*0x3b9cd40*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

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

                static /*0x3b9dccc*/ Strings();
            }

            class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
            {
                /*0x3b9cd98*/ SettingsPanel(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x3b9e0c8*/ string get_PanelName();
                /*0x3b9e108*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                /*0x3b9e500*/ void AddInstanceCullingStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);
                /*0x3b9e118*/ void AddOcclusionContextStatsWidget(UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data);

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
                    static /*0x40*/ System.Func<object> <>9__5_2;
                    static /*0x48*/ System.Func<object> <>9__5_3;
                    static /*0x50*/ System.Func<object> <>9__5_4;
                    static /*0x58*/ System.Func<object> <>9__5_5;
                    static /*0x60*/ System.Func<object> <>9__5_6;
                    static /*0x68*/ System.Func<object> <>9__5_7;
                    static /*0x70*/ System.Func<object> <>9__6_1;

                    static /*0x3b9f1e8*/ <>c();
                    /*0x3b9f250*/ <>c();
                    /*0x3b9f258*/ string <.ctor>b__4_0();
                    /*0x3b9f5c4*/ bool <.ctor>b__4_1();
                    /*0x3b9f664*/ bool <.ctor>b__4_2();
                    /*0x3b9f6b4*/ int <.ctor>b__4_16();
                    /*0x3b9f6bc*/ int <.ctor>b__4_17();
                    /*0x3b9f720*/ bool <.ctor>b__4_24();
                    /*0x3b9f770*/ object <AddInstanceCullingStatsWidget>b__5_1();
                    /*0x3b9f79c*/ object <AddInstanceCullingStatsWidget>b__5_2();
                    /*0x3b9f81c*/ object <AddInstanceCullingStatsWidget>b__5_3();
                    /*0x3b9f89c*/ object <AddInstanceCullingStatsWidget>b__5_4();
                    /*0x3b9f920*/ object <AddInstanceCullingStatsWidget>b__5_5();
                    /*0x3b9f9a0*/ object <AddInstanceCullingStatsWidget>b__5_6();
                    /*0x3b9fa20*/ object <AddInstanceCullingStatsWidget>b__5_7();
                    /*0x3b9faa4*/ object <AddOcclusionContextStatsWidget>b__6_1();
                }

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x3b9e110*/ <>c__DisplayClass4_0();
                    /*0x3b9fad0*/ bool <.ctor>b__3();
                    /*0x3b9fafc*/ void <.ctor>b__4(bool value);
                    /*0x3b9fb28*/ bool <.ctor>b__5();
                    /*0x3b9fb54*/ void <.ctor>b__6(bool value);
                    /*0x3b9fb80*/ bool <.ctor>b__7();
                    /*0x3b9fbac*/ void <.ctor>b__8(bool value);
                    /*0x3b9fbd8*/ bool <.ctor>b__9();
                    /*0x3b9fbf0*/ void <.ctor>b__10(bool value);
                    /*0x3b9fc0c*/ bool <.ctor>b__11();
                    /*0x3b9fc24*/ void <.ctor>b__12(bool value);
                    /*0x3b9fc40*/ int <.ctor>b__13();
                    /*0x3b9fc58*/ void <.ctor>b__14(int value);
                    /*0x3b9fc70*/ bool <.ctor>b__15();
                    /*0x3b9fc90*/ float <.ctor>b__18();
                    /*0x3b9fca8*/ void <.ctor>b__19(float value);
                    /*0x3b9fcc0*/ bool <.ctor>b__20();
                    /*0x3b9fce0*/ float <.ctor>b__21();
                    /*0x3b9fcf8*/ void <.ctor>b__22(float value);
                    /*0x3b9fd10*/ bool <.ctor>b__23();
                    /*0x3b9fd30*/ bool <.ctor>b__25();
                    /*0x3b9fd5c*/ void <.ctor>b__26(bool value);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x3b9f1d8*/ <>c__DisplayClass5_0();
                    /*0x3b9fd88*/ bool <AddInstanceCullingStatsWidget>b__0();
                    /*0x3b9fdbc*/ bool <AddInstanceCullingStatsWidget>b__8();
                    /*0x3b9fdf0*/ bool <AddInstanceCullingStatsWidget>b__9();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ UnityEngine.Rendering.DebugDisplayGPUResidentDrawer data;

                    /*0x3b9f1e0*/ <>c__DisplayClass6_0();
                    /*0x3b9fe24*/ bool <AddOcclusionContextStatsWidget>b__0();
                }
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ int viewIndex;

                /*0x3b9bf18*/ <>c__DisplayClass29_0();
                /*0x3b9fe44*/ bool <AddInstanceCullerViewDataRow>b__0();
                /*0x3b9fe60*/ object <AddInstanceCullerViewDataRow>b__1();
                /*0x3b9fec8*/ object <AddInstanceCullerViewDataRow>b__2();
                /*0x3b9ff04*/ object <AddInstanceCullerViewDataRow>b__3();
                /*0x3b9ff40*/ object <AddInstanceCullerViewDataRow>b__4();
                /*0x3b9ffe4*/ object <AddInstanceCullerViewDataRow>b__5();
                /*0x3ba0088*/ object <AddInstanceCullerViewDataRow>b__6();
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ int eventIndex;

                /*0x3b9c96c*/ <>c__DisplayClass36_0();
                /*0x3ba00c4*/ bool <AddInstanceOcclusionPassDataRow>b__0();
                /*0x3ba00e0*/ object <AddInstanceOcclusionPassDataRow>b__1();
                /*0x3ba011c*/ object <AddInstanceOcclusionPassDataRow>b__2();
                /*0x3ba01b4*/ object <AddInstanceOcclusionPassDataRow>b__3();
                /*0x3ba01dc*/ object <AddInstanceOcclusionPassDataRow>b__4();
                /*0x3ba0260*/ object <AddInstanceOcclusionPassDataRow>b__5();
                /*0x3ba02cc*/ object <AddInstanceOcclusionPassDataRow>b__6();
                /*0x3ba02f4*/ object <AddInstanceOcclusionPassDataRow>b__7();
                /*0x3ba031c*/ object <AddInstanceOcclusionPassDataRow>b__8();
                /*0x3ba0344*/ object <AddInstanceOcclusionPassDataRow>b__9();
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ int index;

                /*0x3b9cd00*/ <>c__DisplayClass37_0();
                /*0x3ba036c*/ bool <AddOcclusionContextDataRow>b__0();
                /*0x3ba0388*/ object <AddOcclusionContextDataRow>b__1();
                /*0x3ba03b8*/ object <AddOcclusionContextDataRow>b__2();
                /*0x3ba03e8*/ object <AddOcclusionContextDataRow>b__3();
            }
        }

        struct Line
        {
            /*0x10*/ Unity.Mathematics.float3 m;
            /*0x1c*/ Unity.Mathematics.float3 t;

            static /*0x3ba0480*/ UnityEngine.Rendering.Line LineOfPlaneIntersectingPlane(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b);
            static /*0x3ba04e0*/ Unity.Mathematics.float4 PlaneContainingLineAndPoint(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
            static /*0x3ba053c*/ Unity.Mathematics.float4 PlaneContainingLineWithNormalPerpendicularToVector(UnityEngine.Rendering.Line a, Unity.Mathematics.float3 b);
        }

        struct ReceiverPlanes
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Plane> planes;
            /*0x18*/ int lightFacingPlaneCount;

            static /*0x3ba0588*/ bool IsSignBitSet(float x);
            static /*0x3ba074c*/ UnityEngine.Rendering.ReceiverPlanes Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            /*0x3ba0594*/ Unity.Collections.NativeArray<UnityEngine.Plane> LightFacingFrustumPlaneSubArray();
            /*0x3ba0620*/ Unity.Collections.NativeArray<UnityEngine.Plane> SilhouettePlaneSubArray();
            /*0x3ba06ec*/ void Dispose(Unity.Jobs.JobHandle job);
        }

        struct FrustumPlaneCuller
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets;
            /*0x18*/ Unity.Collections.NativeList<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos;

            static /*0x3ba1178*/ UnityEngine.Rendering.FrustumPlaneCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.NativeArray<UnityEngine.Plane> receiverPlanes, ref UnityEngine.Rendering.ReceiverSphereCuller receiverSphereCuller, Unity.Collections.Allocator allocator);
            static /*0x3ba16b0*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.PlanePacket4> planePackets, Unity.Collections.NativeArray<UnityEngine.Rendering.FrustumPlaneCuller.SplitInfo> splitInfos, ref UnityEngine.Rendering.AABB bounds);
            /*0x3ba10e8*/ void Dispose(Unity.Jobs.JobHandle job);

            struct PlanePacket4
            {
                /*0x10*/ Unity.Mathematics.float4 nx;
                /*0x20*/ Unity.Mathematics.float4 ny;
                /*0x30*/ Unity.Mathematics.float4 nz;
                /*0x40*/ Unity.Mathematics.float4 d;
                /*0x50*/ Unity.Mathematics.float4 nxAbs;
                /*0x60*/ Unity.Mathematics.float4 nyAbs;
                /*0x70*/ Unity.Mathematics.float4 nzAbs;

                /*0x3ba15e8*/ PlanePacket4(Unity.Collections.NativeArray<UnityEngine.Plane> planes, int offset, int limit);
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

            static /*0x3ba1880*/ UnityEngine.Rendering.ReceiverSphereCuller Create(ref UnityEngine.Rendering.BatchCullingContext cc, Unity.Collections.Allocator allocator);
            static /*0x3ba1af8*/ float DistanceUntilCylinderFullyCrossesPlane(Unity.Mathematics.float3 cylinderCenter, Unity.Mathematics.float3 cylinderDirection, float cylinderRadius, UnityEngine.Plane plane);
            static /*0x3ba1c30*/ uint ComputeSplitVisibilityMask(Unity.Collections.NativeArray<UnityEngine.Plane> lightFacingFrustumPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.ReceiverSphereCuller.SplitInfo> splitInfos, Unity.Mathematics.float3x3 worldToLightSpaceRotation, ref UnityEngine.Rendering.AABB bounds);
            /*0x3ba1820*/ void Dispose(Unity.Jobs.JobHandle job);
            /*0x3ba1580*/ bool UseReceiverPlanes();

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
            /*0x20*/ UnityEngine.Rendering.GPUDrivenRendererDataCallback m_UpdateRendererInstancesAndBatchesCallback;
            /*0x28*/ UnityEngine.Rendering.GPUDrivenRendererDataCallback m_UpdateRendererBatchesCallback;
            /*0x30*/ UnityEngine.Rendering.InstanceCullingBatcher m_InstanceCullingBatcher;
            /*0x38*/ UnityEngine.Rendering.ParallelBitArray m_ProcessedThisFrameTreeBits;

            /*0x3ba1ee4*/ GPUResidentBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc instanceCullerBatcherDesc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor);
            /*0x3ba1ebc*/ UnityEngine.Rendering.RenderersBatchersContext get_batchersContext();
            /*0x3ba1ec4*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x3ba1edc*/ UnityEngine.Rendering.InstanceCullingBatcher get_instanceCullingBatcher();
            /*0x3ba2080*/ void Dispose();
            /*0x3ba20d4*/ void OnBeginContextRendering();
            /*0x3ba2104*/ void OnEndContextRendering();
            /*0x3ba2118*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x3ba212c*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x3ba2140*/ void UpdateFrame();
            /*0x3ba2170*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x3ba2188*/ void DestroyDrawInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3ba21a0*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x3ba21b8*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs);
            /*0x3ba22e4*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            /*0x3ba2830*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x3ba28ac*/ void UpdateRenderers(Unity.Collections.NativeArray<int> renderersID, bool materialUpdateOnly);
            /*0x3ba297c*/ Unity.Jobs.JobHandle SchedulePackedMaterialCacheUpdate(Unity.Collections.NativeArray<int> materialIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas);
            /*0x3ba2994*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x3ba29ac*/ void UpdateRendererInstancesAndBatches(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
            /*0x3ba2ba8*/ void UpdateRendererBatches(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
            /*0x3ba2cc8*/ void OnFinishedCulling(nint customCullingResult);
            /*0x3ba2cfc*/ void ProcessTrees();
            /*0x3ba304c*/ void UpdateSpeedTreeWindAndUploadWindParamsToGPU(Unity.Collections.NativeArray<int> treeRendererIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> treeInstances, bool history);
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

            static /*0x3ba3304*/ UnityEngine.Rendering.GPUResidentDrawer get_instance();
            static /*0x3ba334c*/ bool IsInstanceOcclusionCullingEnabled();
            static /*0x3ba33b4*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            static /*0x3ba342c*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
            static /*0x3ba34c8*/ void UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParameters, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            static /*0x3ba3564*/ void ReinitializeIfNeeded();
            static /*0x3ba3568*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x3ba3620*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            static /*0x3b9b3a4*/ UnityEngine.Rendering.DebugRendererBatcherStats GetDebugStats();
            static /*0x3b9f614*/ bool IsEnabled();
            static /*0x3b9f2a8*/ UnityEngine.Rendering.GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset();
            static /*0x3ba3de4*/ bool IsForcedOnViaCommandLine();
            static /*0x3ba3dec*/ bool IsOcclusionForcedOnViaCommandLine();
            static /*0x3ba3df4*/ void Reinitialize();
            static /*0x3ba3ee8*/ void CleanUp();
            static /*0x3ba3e18*/ void Recreate(UnityEngine.Rendering.GPUResidentDrawerSettings settings);
            static /*0x3ba4824*/ void PostPostLateUpdateStatic();
            static /*0x3ba5d98*/ bool IsProjectSupported(ref string message, ref UnityEngine.LogType severity);
            static /*0x3b9f408*/ bool IsGPUResidentDrawerSupportedBySRP(UnityEngine.Rendering.GPUResidentDrawerSettings settings, ref string message, ref UnityEngine.LogType severity);
            static /*0x3ba4738*/ void LogMessage(string message, UnityEngine.LogType severity);
            /*0x3ba4208*/ GPUResidentDrawer(UnityEngine.Rendering.GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount);
            /*0x3ba3700*/ void InsertIntoPlayerLoop();
            /*0x3ba3b0c*/ void RemoveFromPlayerLoop();
            /*0x3ba47e0*/ UnityEngine.Rendering.GPUResidentBatcher get_batcher();
            /*0x3ba47e8*/ UnityEngine.Rendering.GPUResidentDrawerSettings get_settings();
            /*0x3ba3f5c*/ void Dispose();
            /*0x3ba47fc*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x3ba4c60*/ void OnBeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x3ba4d20*/ void OnEndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x3ba4dd8*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x3ba4e00*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x3ba487c*/ void PostPostLateUpdate();
            /*0x3ba50b0*/ void ProcessMaterials(Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.NativeArray<int> unsupportedMaterials);
            /*0x3ba5124*/ void ProcessMeshes(Unity.Collections.NativeArray<int> destroyedID);
            /*0x3ba525c*/ void ProcessLODGroups(Unity.Collections.NativeArray<int> changedID, Unity.Collections.NativeArray<int> destroyed, Unity.Collections.NativeArray<int> transformedID);
            /*0x3ba54ac*/ void ProcessRendererMaterialAndMeshChanges(Unity.Collections.NativeArray<int> excludedRenderers, Unity.Collections.NativeArray<int> changedMaterials, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> changedPackedMaterialDatas, Unity.Collections.NativeArray<int> changedMeshes);
            /*0x3ba52d4*/ void ProcessRenderers(UnityEngine.TypeDispatchData rendererChanges, Unity.Collections.NativeArray<int> unsupportedRenderers);
            /*0x3ba5d74*/ void TransformInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x3ba5ca4*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> unsupportedRendererGroupIDs);
            /*0x3ba5c8c*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3ba5920*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3ba4e28*/ void ClassifyMaterials(Unity.Collections.NativeArray<int> materials, ref Unity.Collections.NativeList<int> unsupportedMaterials, ref Unity.Collections.NativeList<int> supportedMaterials, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas, Unity.Collections.Allocator allocator);
            /*0x3ba4fa0*/ Unity.Collections.NativeList<int> FindUnsupportedRenderers(Unity.Collections.NativeArray<int> unsupportedMaterials);
            /*0x3ba5938*/ Unity.Collections.NativeHashSet<int> GetMaterialsWithChangedPackedMaterial(Unity.Collections.NativeArray<int> materials, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas, Unity.Collections.Allocator allocator);
            /*0x3ba5a1c*/ System.ValueTuple<Unity.Collections.NativeList<int>, Unity.Collections.NativeList<int>> FindRenderersFromMaterialsOrMeshes(Unity.Collections.NativeArray<int> sortedExcludeRenderers, Unity.Collections.NativeHashSet<int> materials, Unity.Collections.NativeArray<int> meshes, Unity.Collections.Allocator rendererListAllocator);

            struct FindRenderersFromMaterialOrMeshJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeHashSet.ReadOnly<int> materialIDs;
                /*0x18*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays;
                /*0x28*/ Unity.Collections.NativeArray.ReadOnly<int> meshIDs;
                /*0x38*/ Unity.Collections.NativeArray.ReadOnly<int> meshIDArray;
                /*0x48*/ Unity.Collections.NativeArray.ReadOnly<int> rendererGroupIDs;
                /*0x58*/ Unity.Collections.NativeArray.ReadOnly<int> sortedExcludeRendererIDs;
                /*0x68*/ Unity.Collections.NativeList.ParallelWriter<int> selectedRenderGroupsForMaterials;
                /*0x70*/ Unity.Collections.NativeList.ParallelWriter<int> selectedRenderGroupsForMeshes;

                /*0x3ba5e58*/ void Execute(int startIndex, int count);
            }

            class Strings
            {
                static /*0x0*/ string drawerModeDisabled;
                static /*0x8*/ string allowInEditModeDisabled;
                static /*0x10*/ string notGPUResidentRenderPipeline;
                static /*0x18*/ string rawBufferNotSupportedByPlatform;
                static /*0x20*/ string kernelNotPresent;
                static /*0x28*/ string batchRendererGroupShaderStrippingModeInvalid;

                static /*0x3ba616c*/ Strings();
            }
        }

        class GPUResidentDrawerBurst
        {
            static /*0x3ba5d8c*/ void ClassifyMaterials(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeList<int> supportedMaterialIDs, ref Unity.Collections.NativeList<int> unsupportedMaterialIDs, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            static /*0x3ba5d90*/ void FindUnsupportedRenderers(ref Unity.Collections.NativeArray<int> unsupportedMaterials, ref Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays, ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroups, ref Unity.Collections.NativeList<int> unsupportedRenderers);
            static /*0x3ba5d94*/ void GetMaterialsWithChangedPackedMaterial(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHash, ref Unity.Collections.NativeHashSet<int> filteredMaterials);
            static /*0x3ba663c*/ void ClassifyMaterials$BurstManaged(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeList<int> supportedMaterialIDs, ref Unity.Collections.NativeList<int> unsupportedMaterialIDs, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            static /*0x3ba6b34*/ void FindUnsupportedRenderers$BurstManaged(ref Unity.Collections.NativeArray<int> unsupportedMaterials, ref Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays, ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroups, ref Unity.Collections.NativeList<int> unsupportedRenderers);
            static /*0x3ba6d04*/ void GetMaterialsWithChangedPackedMaterial$BurstManaged(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHash, ref Unity.Collections.NativeHashSet<int> filteredMaterials);

            class ClassifyMaterials_000000E6$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3ba6dfc*/ ClassifyMaterials_000000E6$PostfixBurstDelegate(object , nint );
                /*0x3ba6eb0*/ void Invoke(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeList<int> supportedMaterialIDs, ref Unity.Collections.NativeList<int> unsupportedMaterialIDs, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            }

            class ClassifyMaterials_000000E6$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3ba6ec4*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3ba6fb4*/ nint GetFunctionPointer();
                static /*0x3ba6320*/ void Invoke(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeList<int> supportedMaterialIDs, ref Unity.Collections.NativeList<int> unsupportedMaterialIDs, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            }

            class FindUnsupportedRenderers_000000E7$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3ba6fcc*/ FindUnsupportedRenderers_000000E7$PostfixBurstDelegate(object , nint );
                /*0x3ba7080*/ void Invoke(ref Unity.Collections.NativeArray<int> unsupportedMaterials, ref Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays, ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroups, ref Unity.Collections.NativeList<int> unsupportedRenderers);
            }

            class FindUnsupportedRenderers_000000E7$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3ba7094*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3ba7184*/ nint GetFunctionPointer();
                static /*0x3ba63fc*/ void Invoke(ref Unity.Collections.NativeArray<int> unsupportedMaterials, ref Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.SmallIntegerArray> materialIDArrays, ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroups, ref Unity.Collections.NativeList<int> unsupportedRenderers);
            }

            class GetMaterialsWithChangedPackedMaterial_000000E8$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3ba719c*/ GetMaterialsWithChangedPackedMaterial_000000E8$PostfixBurstDelegate(object , nint );
                /*0x3ba7250*/ void Invoke(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHash, ref Unity.Collections.NativeHashSet<int> filteredMaterials);
            }

            class GetMaterialsWithChangedPackedMaterial_000000E8$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3ba7264*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3ba7354*/ nint GetFunctionPointer();
                static /*0x3ba64c0*/ void Invoke(ref Unity.Collections.NativeArray<int> materialIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas, ref Unity.Collections.NativeParallelHashMap.ReadOnly<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHash, ref Unity.Collections.NativeHashSet<int> filteredMaterials);
            }
        }

        struct InstanceCullerViewStats
        {
            /*0x10*/ UnityEngine.Rendering.BatchCullingViewType viewType;
            /*0x14*/ int viewInstanceID;
            /*0x18*/ int splitIndex;
            /*0x1c*/ int visibleInstancesOnCPU;
            /*0x20*/ int visibleInstancesOnGPU;
            /*0x24*/ int visiblePrimitivesOnCPU;
            /*0x28*/ int visiblePrimitivesOnGPU;
            /*0x2c*/ int drawCommands;
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
            /*0x2c*/ int visiblePrimitives;
            /*0x30*/ int culledPrimitives;
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

            /*0x3ba736c*/ DebugRendererBatcherStats();
            /*0x3ba7468*/ void FinalizeInstanceCullerViewStats();
            /*0x3ba7600*/ UnityEngine.Rendering.InstanceOcclusionEventStats GetLastInstanceOcclusionEventStatsForView(int viewIndex);
            /*0x3ba7758*/ void Dispose();
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

            /*0x3ba7878*/ GPUResidentDrawerResources();
            /*0x3ba7828*/ int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version();
            /*0x3ba7830*/ UnityEngine.ComputeShader get_instanceDataBufferCopyKernels();
            /*0x3ba7838*/ UnityEngine.ComputeShader get_instanceDataBufferUploadKernels();
            /*0x3ba7840*/ UnityEngine.ComputeShader get_transformUpdaterKernels();
            /*0x3ba7848*/ UnityEngine.ComputeShader get_windDataUpdaterKernels();
            /*0x3ba7850*/ UnityEngine.ComputeShader get_occluderDepthPyramidKernels();
            /*0x3ba7858*/ UnityEngine.ComputeShader get_instanceOcclusionCullingKernels();
            /*0x3ba7860*/ UnityEngine.ComputeShader get_occlusionCullingDebugKernels();
            /*0x3ba7868*/ UnityEngine.Shader get_debugOcclusionTestPS();
            /*0x3ba7870*/ UnityEngine.Shader get_debugOccluderPS();

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
            static /*0x3ba7880*/ uint GetBatchLayerMask(UnityEngine.Rendering.OcclusionTest occlusionTest);
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

            /*0x3ba7890*/ OcclusionCullingSettings(int viewInstanceID, UnityEngine.Rendering.OcclusionTest occlusionTest);
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

            /*0x3ba78a0*/ OccluderSubviewUpdate(int subviewIndex);
        }

        struct OccluderParameters
        {
            /*0x10*/ int viewInstanceID;
            /*0x14*/ int subviewCount;
            /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle depthTexture;
            /*0x28*/ UnityEngine.Vector2Int depthSize;
            /*0x30*/ bool depthIsArray;

            /*0x3ba799c*/ OccluderParameters(int viewInstanceID);
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
            static /*0x3ba7a7c*/ void ReinitializeGPUResidentDrawer();
            UnityEngine.Rendering.GPUResidentDrawerSettings get_gpuResidentDrawerSettings();
            /*0x3ba7aa0*/ bool IsGPUResidentDrawerSupportedBySRP(ref string message, ref UnityEngine.LogType severity);
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

            /*0x3ba7ae0*/ bool Equals(UnityEngine.Rendering.RangeKey other);
            /*0x3ba7b64*/ int GetHashCode();
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

            /*0x3ba7ba8*/ bool Equals(UnityEngine.Rendering.DrawKey other);
            /*0x3ba7cf8*/ int GetHashCode();
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

            /*0x3ba7d68*/ int get_visibilityConfigCount();
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

            static /*0x3ba7d8c*/ uint PackFloatToUint8(float percent);
            /*0x3ba7dec*/ float CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x3ba8254*/ uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, UnityEngine.Rendering.InstanceFlags instanceFlags);
            /*0x3ba83ec*/ void Execute(int instanceIndex);

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

            static /*0x3ba8660*/ int GetPrimitiveCount(int indexCount, UnityEngine.MeshTopology topology, bool nativeQuads);
            /*0x3ba85bc*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x3ba86fc*/ void Execute(int batchIndex);
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

            /*0x3ba8c64*/ void Execute();
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

            /*0x3ba914c*/ int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade);
            /*0x3ba9214*/ bool IsInstanceFlipped(int rendererIndex);
            /*0x3ba92b8*/ void Execute(int batchIndex);
        }

        struct CompactVisibilityMasksJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<byte> rendererVisibilityMasks;
            /*0x20*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;

            /*0x3ba9a10*/ void Execute(int startIndex, int count);
        }

        struct InstanceCullerSplitDebugArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceCullerSplitDebugArray.Info> m_Info;
            /*0x18*/ Unity.Collections.NativeArray<int> m_Counters;
            /*0x28*/ Unity.Collections.NativeQueue<Unity.Jobs.JobHandle> m_CounterSync;

            /*0x3ba9a7c*/ Unity.Collections.NativeArray<int> get_Counters();
            /*0x3ba9a88*/ void Init();
            /*0x3ba9b74*/ void Dispose();
            /*0x3ba9c04*/ int TryAddSplits(UnityEngine.Rendering.BatchCullingViewType viewType, int viewInstanceID, int splitCount);
            /*0x3ba9cec*/ void AddSync(int baseIndex, Unity.Jobs.JobHandle jobHandle);
            /*0x3ba9d64*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

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

            /*0x3ba9f5c*/ UnityEngine.GraphicsBuffer get_CounterBuffer();
            /*0x3ba9f64*/ void Init();
            /*0x3baa070*/ void Dispose();
            /*0x3baa198*/ int TryAdd(int viewInstanceID, UnityEngine.Rendering.InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, UnityEngine.Rendering.OcclusionTest occlusionTest);
            /*0x3baa254*/ void MoveToDebugStatsAndClear(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);

            struct Info
            {
                /*0x10*/ int viewInstanceID;
                /*0x14*/ UnityEngine.Rendering.InstanceOcclusionEventType eventType;
                /*0x18*/ int occluderVersion;
                /*0x1c*/ int subviewMask;
                /*0x20*/ UnityEngine.Rendering.OcclusionTest occlusionTest;

                /*0x3baa758*/ bool HasVersion();
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

            /*0x3baa77c*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources, UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x3baaa28*/ Unity.Jobs.JobHandle CreateFrustumCullingJob(ref UnityEngine.Rendering.BatchCullingContext cc, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref UnityEngine.Rendering.BinningConfig binningConfig, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Collections.NativeArray<byte> rendererCrossFadeValues);
            /*0x3baae3c*/ int ComputeWorstCaseDrawCommandCount(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BinningConfig binningConfig, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, int crossFadedRendererCount);
            /*0x3baaf30*/ Unity.Jobs.JobHandle CreateCullJobTree(ref UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData, ref UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly instanceDataBuffer, Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, UnityEngine.Rendering.CPUDrawInstanceData drawInstanceData, Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> batchIDs, int crossFadedRendererCount, float smallMeshScreenPercentage, UnityEngine.Rendering.OcclusionCullingCommon occlusionCullingCommon);
            /*0x3bab7f4*/ Unity.Jobs.JobHandle CreateCompactedVisibilityMaskJob(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, Unity.Collections.NativeArray<byte> rendererVisibilityMasks, Unity.Jobs.JobHandle cullingJobHandle);
            /*0x3bab900*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x3bab988*/ void DisposeCompactVisibilityMasks();
            /*0x3bab9b4*/ void DisposeSceneViewHiddenBits();
            /*0x3bab9b8*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x3ba2360*/ void InstanceOcclusionTest(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OcclusionCullingSettings settings, System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x3bab9ec*/ void EnsureValidOcclusionTestResults(int viewInstanceID);
            /*0x3babc88*/ void AddOcclusionCullingDispatch(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles, ref UnityEngine.Rendering.OccluderHandles occluderHandles, UnityEngine.Rendering.RenderersBatchersContext batchersContext);
            /*0x3bac638*/ void FlushDebugCounters();
            /*0x3bac680*/ void OnBeginSceneViewCameraRendering();
            /*0x3bac684*/ void OnEndSceneViewCameraRendering();
            /*0x3bac688*/ void UpdateFrame();
            /*0x3bac6c0*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x3bac6d8*/ void OnEndCameraRendering(UnityEngine.Camera camera);
            /*0x3bac6f0*/ void Dispose();

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

                static /*0x3baced0*/ ShaderIDs();
            }

            class InstanceOcclusionTestPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingSettings settings;
                /*0x1c*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings;
                /*0x30*/ UnityEngine.Rendering.OccluderHandles occluderHandles;
                /*0x4c*/ UnityEngine.Rendering.IndirectBufferContextHandles bufferHandles;

                /*0x3bad0a8*/ InstanceOcclusionTestPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.InstanceCuller.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__25_0;

                static /*0x3bad0b0*/ <>c();
                /*0x3bad118*/ <>c();
                /*0x3bad120*/ void <InstanceOcclusionTest>b__25_0(UnityEngine.Rendering.InstanceCuller.InstanceOcclusionTestPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
            }
        }

        class InstanceCullerBurst
        {
            static /*0x3bad1b8*/ void SetupCullingJobInput(float lodBias, UnityEngine.Rendering.BatchCullingContext* context, UnityEngine.Rendering.ReceiverPlanes* receiverPlanes, UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller, UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric);
            static /*0x3bad354*/ void SetupCullingJobInput$BurstManaged(float lodBias, UnityEngine.Rendering.BatchCullingContext* context, UnityEngine.Rendering.ReceiverPlanes* receiverPlanes, UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller, UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric);

            class SetupCullingJobInput_00000142$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bad460*/ SetupCullingJobInput_00000142$PostfixBurstDelegate(object , nint );
                /*0x3bad500*/ void Invoke(float lodBias, UnityEngine.Rendering.BatchCullingContext* context, UnityEngine.Rendering.ReceiverPlanes* receiverPlanes, UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller, UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric);
            }

            class SetupCullingJobInput_00000142$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bad514*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bad604*/ nint GetFunctionPointer();
                static /*0x3bad1bc*/ void Invoke(float lodBias, UnityEngine.Rendering.BatchCullingContext* context, UnityEngine.Rendering.ReceiverPlanes* receiverPlanes, UnityEngine.Rendering.ReceiverSphereCuller* receiverSphereCuller, UnityEngine.Rendering.FrustumPlaneCuller* frustumPlaneCuller, float* screenRelativeMetric);
            }
        }

        class OnCullingCompleteCallback : System.MulticastDelegate
        {
            /*0x3bad61c*/ OnCullingCompleteCallback(object object, nint method);
            /*0x3bad6bc*/ void Invoke(Unity.Jobs.JobHandle jobHandle, ref UnityEngine.Rendering.BatchCullingContext cullingContext, ref UnityEngine.Rendering.BatchCullingOutput cullingOutput);
        }

        struct InstanceCullingBatcherDesc
        {
            /*0x10*/ UnityEngine.Rendering.OnCullingCompleteCallback onCompleteCallback;

            static /*0x3bad6d0*/ UnityEngine.Rendering.InstanceCullingBatcherDesc NewDefault();
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

            /*0x3bad6ec*/ void Execute();
        }

        struct BuildDrawListsJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;
            /*0x30*/ Unity.Collections.NativeArray<int> internalDrawIndex;
            /*0x40*/ Unity.Collections.NativeArray<int> drawInstanceIndices;

            static /*0x3bad960*/ int IncrementCounter(int* counter);
            /*0x3bad9a8*/ void Execute(int index);
        }

        struct FindDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instancesSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x3badac8*/ void Execute(int startIndex, int count);
        }

        struct FindMaterialDrawInstancesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<uint> materialsSorted;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeList.ParallelWriter<int> outDrawInstanceIndicesWriter;

            /*0x3badc9c*/ void Execute(int startIndex, int count);
        }

        struct FindNonRegisteredMeshesJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x20*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> hashMap;
            /*0x30*/ Unity.Collections.NativeList.ParallelWriter<int> outInstancesWriter;

            /*0x3badddc*/ void Execute(int startIndex, int count);
        }

        struct FindNonRegisteredMaterialsJob : Unity.Jobs.IJobParallelForBatch
        {
            /*0x10*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas;
            /*0x30*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> hashMap;
            /*0x40*/ Unity.Collections.NativeList.ParallelWriter<int> outInstancesWriter;
            /*0x48*/ Unity.Collections.NativeList.ParallelWriter<UnityEngine.Rendering.GPUDrivenPackedMaterialData> outPackedMaterialDatasWriter;

            /*0x3badf78*/ void Execute(int startIndex, int count);
        }

        struct RegisterNewMeshesJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchMeshID> batchIDs;
            /*0x30*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<int, UnityEngine.Rendering.BatchMeshID> hashMap;

            /*0x3bae1ec*/ void Execute(int index);
        }

        struct RegisterNewMaterialsJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeArray<int> instanceIDs;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas;
            /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchMaterialID> batchIDs;
            /*0x40*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHashMap;
            /*0x50*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHashMap;

            /*0x3bae260*/ void Execute(int index);
        }

        struct RemoveDrawInstanceIndicesJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray<int> drawInstanceIndices;
            /*0x20*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash;
            /*0x38*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash;
            /*0x48*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges;
            /*0x50*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches;

            /*0x3bae310*/ void RemoveDrawRange(ref UnityEngine.Rendering.RangeKey key);
            /*0x3bae494*/ void RemoveDrawBatch(ref UnityEngine.Rendering.DrawKey key);
            /*0x3bae6ac*/ void Execute();
        }

        struct UpdatePackedMaterialDataCacheJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArray.ReadOnly<int> materialIDs;
            /*0x20*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas;
            /*0x30*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialHash;

            /*0x3bae848*/ void ProcessMaterial(int i);
            /*0x3bae910*/ void Execute();
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

            /*0x3baf5b4*/ CPUDrawInstanceData();
            /*0x3bae974*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> get_drawInstances();
            /*0x3bae97c*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> get_batchHash();
            /*0x3bae988*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> get_drawBatches();
            /*0x3bae990*/ Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> get_rangeHash();
            /*0x3bae99c*/ Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> get_drawRanges();
            /*0x3bae9a4*/ Unity.Collections.NativeArray<int> get_drawBatchIndices();
            /*0x3bae9ec*/ Unity.Collections.NativeArray<int> get_drawInstanceIndices();
            /*0x3baea34*/ void Initialize();
            /*0x3baec24*/ void Dispose();
            /*0x3baedc4*/ void RebuildDrawListsIfNeeded();
            /*0x3baf040*/ void DestroyDrawInstanceIndices(Unity.Collections.NativeArray<int> drawInstanceIndicesToDestroy);
            /*0x3baf0a0*/ void DestroyDrawInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> destroyedInstances);
            /*0x3baf330*/ void DestroyMaterialDrawInstances(Unity.Collections.NativeArray<uint> destroyedBatchMaterials);
            /*0x3baf324*/ void NeedsRebuild();
        }

        class InstanceCullingBatcher : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.RenderersBatchersContext m_BatchersContext;
            /*0x18*/ UnityEngine.Rendering.CPUDrawInstanceData m_DrawInstanceData;
            /*0x20*/ UnityEngine.Rendering.BatchRendererGroup m_BRG;
            /*0x28*/ Unity.Collections.NativeParallelHashMap<uint, UnityEngine.Rendering.BatchID> m_GlobalBatchIDs;
            /*0x38*/ UnityEngine.Rendering.InstanceCuller m_Culler;
            /*0x1c0*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> m_BatchMaterialHash;
            /*0x1d0*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> m_PackedMaterialHash;
            /*0x1e0*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> m_BatchMeshHash;
            /*0x1f0*/ int m_CachedInstanceDataBufferLayoutVersion;
            /*0x1f8*/ UnityEngine.Rendering.OnCullingCompleteCallback m_OnCompleteCallback;

            /*0x3baf5d4*/ InstanceCullingBatcher(UnityEngine.Rendering.RenderersBatchersContext batcherContext, UnityEngine.Rendering.InstanceCullingBatcherDesc desc, UnityEngine.Rendering.BatchRendererGroup.OnFinishedCulling onFinishedCulling);
            /*0x3baf5bc*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> get_batchMaterialHash();
            /*0x3baf5c8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> get_packedMaterialHash();
            /*0x3bad1b0*/ ref UnityEngine.Rendering.InstanceCuller get_culler();
            /*0x3bafbe0*/ void Dispose();
            /*0x3baf9b0*/ UnityEngine.Rendering.BatchID GetBatchID(UnityEngine.Rendering.InstanceComponentGroup componentsOverriden);
            /*0x3bafef0*/ void UpdateInstanceDataBufferLayoutVersion();
            /*0x3bb01b4*/ Unity.Jobs.JobHandle OnPerformCulling(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cc, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            /*0x3bb058c*/ void OnFinishedCulling(nint customCullingResult);
            /*0x3bb05b4*/ void DestroyDrawInstances(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bb05d0*/ void DestroyMaterials(Unity.Collections.NativeArray<int> destroyedMaterials);
            /*0x3bb0908*/ void DestroyMeshes(Unity.Collections.NativeArray<int> destroyedMeshes);
            /*0x3bb0b40*/ void PostCullBeginCameraRendering(UnityEngine.Rendering.RenderRequestBatcherContext context);
            /*0x3bb0b44*/ void RegisterBatchMeshes(Unity.Collections.NativeArray<int> meshIDs);
            /*0x3bb0f7c*/ void RegisterBatchMaterials(ref Unity.Collections.NativeArray<int> usedMaterialIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> usedPackedMaterialDatas);
            /*0x3bb151c*/ Unity.Jobs.JobHandle SchedulePackedMaterialCacheUpdate(Unity.Collections.NativeArray<int> materialIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDatas);
            /*0x3bb15e4*/ void BuildBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, bool registerMaterialsAndMeshes);
            /*0x3bb16d0*/ void InstanceOccludersUpdated(int viewInstanceID, int subviewMask);
            /*0x3bb16e0*/ void UpdateFrame();
            /*0x3bb16ec*/ UnityEngine.Rendering.ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs);
            /*0x3bb171c*/ void OnEndContextRendering();
            /*0x3bb1780*/ void OnBeginCameraRendering(UnityEngine.Camera camera);
            /*0x3bb178c*/ void OnEndCameraRendering(UnityEngine.Camera camera);
        }

        class InstanceCullingBatcherBurst
        {
            static /*0x3bb1798*/ void RemoveDrawRange(ref UnityEngine.Rendering.RangeKey key, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges);
            static /*0x3bb191c*/ void RemoveDrawBatch(ref UnityEngine.Rendering.DrawKey key, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            static /*0x3baf09c*/ void RemoveDrawInstanceIndices(ref Unity.Collections.NativeArray<int> drawInstanceIndices, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            static /*0x3bb1c20*/ ref UnityEngine.Rendering.DrawRange EditDrawRange(ref UnityEngine.Rendering.RangeKey key, Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges);
            static /*0x3bb1d80*/ ref UnityEngine.Rendering.DrawBatch EditDrawBatch(ref UnityEngine.Rendering.DrawKey key, ref UnityEngine.Rendering.SubMeshDescriptor subMeshDescriptor, Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            static /*0x3bb1f20*/ void ProcessRenderer(int i, bool implicitInstanceIndices, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDataHash, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances, Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            static /*0x3bb16bc*/ void CreateDrawBatches(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDataHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances);
            static /*0x3bb2844*/ void RemoveDrawInstanceIndices$BurstManaged(ref Unity.Collections.NativeArray<int> drawInstanceIndices, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            static /*0x3bb2a04*/ void CreateDrawBatches$BurstManaged(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDataHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances);

            class RemoveDrawInstanceIndices_00000180$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bb2adc*/ RemoveDrawInstanceIndices_00000180$PostfixBurstDelegate(object , nint );
                /*0x3bb2b90*/ void Invoke(ref Unity.Collections.NativeArray<int> drawInstanceIndices, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            }

            class RemoveDrawInstanceIndices_00000180$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bb2ba4*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bb2c94*/ nint GetFunctionPointer();
                static /*0x3bb1b38*/ void Invoke(ref Unity.Collections.NativeArray<int> drawInstanceIndices, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches);
            }

            class CreateDrawBatches_00000184$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bb2cac*/ CreateDrawBatches_00000184$PostfixBurstDelegate(object , nint );
                /*0x3bb2d4c*/ void Invoke(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDataHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances);
            }

            class CreateDrawBatches_00000184$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bb2d74*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bb2e64*/ nint GetFunctionPointer();
                static /*0x3bb2694*/ void Invoke(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMeshID> batchMeshHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.BatchMaterialID> batchMaterialHash, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialDataHash, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.RangeKey, int> rangeHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawRange> drawRanges, ref Unity.Collections.NativeParallelHashMap<UnityEngine.Rendering.DrawKey, int> batchHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawBatch> drawBatches, ref Unity.Collections.NativeList<UnityEngine.Rendering.DrawInstance> drawInstances);
            }
        }

        struct GPUInstanceComponentDesc
        {
            /*0x10*/ int propertyID;
            /*0x14*/ int byteSize;
            /*0x18*/ bool isOverriden;
            /*0x19*/ bool isPerInstance;
            /*0x1c*/ UnityEngine.Rendering.InstanceType instanceType;
            /*0x20*/ UnityEngine.Rendering.InstanceComponentGroup componentGroup;

            /*0x3bb2e7c*/ GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, UnityEngine.Rendering.InstanceType inInstanceType, UnityEngine.Rendering.InstanceComponentGroup inComponentType);
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

            static /*0x3bb2e90*/ int NextVersion();
            static /*0x3bb2ee0*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(ref Unity.Collections.NativeArray<int> instancesNumPrefixSum, UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb33e4*/ GPUInstanceDataBuffer();
            /*0x3bb30e8*/ int GetPropertyIndex(int propertyID, bool assertOnFail);
            /*0x3bb3158*/ int GetGpuAddress(int propertyID, bool assertOnFail);
            /*0x3bb3180*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x3bb3228*/ void Dispose();
            /*0x3bb33b4*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly AsReadOnly();

            struct ReadOnly
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;

                /*0x3bb33cc*/ ReadOnly(UnityEngine.Rendering.GPUInstanceDataBuffer buffer);
                /*0x3bb33ec*/ UnityEngine.Rendering.GPUInstanceIndex CPUInstanceToGPUInstance(UnityEngine.Rendering.InstanceHandle instance);
                /*0x3bb33f4*/ void CPUInstanceArrayToGPUInstanceArray(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            }

            struct ConvertCPUInstancesToGPUInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesNumPrefixSum;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices;

                /*0x3bb349c*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferBuilder : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceComponentDesc> m_Components;

            /*0x3bb34cc*/ UnityEngine.Rendering.MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden);
            /*0x1ffc854*/ void AddComponent<T>(int propertyID, bool isOverriden, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x3bb34e8*/ void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, UnityEngine.Rendering.InstanceType instanceType, UnityEngine.Rendering.InstanceComponentGroup componentGroup);
            /*0x3bb3618*/ UnityEngine.Rendering.GPUInstanceDataBuffer Build(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x3bb3f08*/ void Dispose();
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

            /*0x3bb3f70*/ GPUInstanceDataBufferUploader(ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceComponentDesc> descriptions, int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x3bb41e4*/ nint GetUploadBufferPtr();
            /*0x3bb422c*/ int GetUIntPerInstance();
            /*0x3bb4234*/ int GetParamUIntOffset(int parameterIndex);
            int PrepareParamWrite<T>(int parameterIndex);
            /*0x3bb4240*/ void AllocateUploadHandles(int handlesLength);
            /*0x1ffc854*/ Unity.Jobs.JobHandle WriteInstanceDataJob<T>(int parameterIndex, Unity.Collections.NativeArray<T> instanceData, Unity.Collections.NativeArray<int> gatherIndices);
            /*0x3bb4248*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x3bb4928*/ void SubmitToGpu(UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader.GPUResources gpuResources, bool submitOnlyWrittenParams);
            /*0x3bb4a0c*/ void Dispose();

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

                static /*0x3bb4b38*/ UploadKernelIDs();
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

                /*0x3bb4da0*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x3bb474c*/ void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount);
                /*0x3bb4e5c*/ void Dispose();
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

                /*0x3bb4ebc*/ void Execute(int index);
            }
        }

        struct GPUInstanceDataBufferGrower : System.IDisposable
        {
            /*0x10*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_SrcBuffer;
            /*0x18*/ UnityEngine.Rendering.GPUInstanceDataBuffer m_DstBuffer;

            /*0x3bb4fac*/ GPUInstanceDataBufferGrower(UnityEngine.Rendering.GPUInstanceDataBuffer sourceBuffer, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x3bb51e0*/ UnityEngine.Rendering.GPUInstanceDataBuffer SubmitToGpu(ref UnityEngine.Rendering.GPUInstanceDataBufferGrower.GPUResources gpuResources);
            /*0x3bb54e0*/ void Dispose();

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

                static /*0x3bb54e4*/ CopyInstancesKernelIDs();
            }

            struct GPUResources : System.IDisposable
            {
                /*0x10*/ UnityEngine.ComputeShader cs;
                /*0x18*/ int kernelId;

                /*0x3bb574c*/ void LoadShaders(UnityEngine.Rendering.GPUResidentDrawerResources resources);
                /*0x3bb54dc*/ void CreateResources();
                /*0x3bb5804*/ void Dispose();
            }
        }

        struct InstanceHandle : System.IEquatable<UnityEngine.Rendering.InstanceHandle>, System.IComparable<UnityEngine.Rendering.InstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.InstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x3bb5954*/ InstanceHandle();
            static /*0x3badc48*/ UnityEngine.Rendering.InstanceHandle FromInt(int value);
            /*0x3bb5810*/ int get_index();
            /*0x3bb5818*/ void set_index(int value);
            /*0x3bb3090*/ int get_instanceIndex();
            /*0x3bb3038*/ UnityEngine.Rendering.InstanceType get_type();
            /*0x3bb2fdc*/ bool get_valid();
            /*0x3bb5820*/ bool Equals(UnityEngine.Rendering.InstanceHandle other);
            /*0x3bb5888*/ int CompareTo(UnityEngine.Rendering.InstanceHandle other);
            /*0x3bb5900*/ int GetHashCode();
        }

        struct SharedInstanceHandle : System.IEquatable<UnityEngine.Rendering.SharedInstanceHandle>, System.IComparable<UnityEngine.Rendering.SharedInstanceHandle>
        {
            static /*0x0*/ UnityEngine.Rendering.SharedInstanceHandle Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x3bb5ae4*/ SharedInstanceHandle();
            /*0x3bb59a0*/ int get_index();
            /*0x3bb59a8*/ void set_index(int value);
            /*0x3bb59b0*/ bool Equals(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x3bb5a18*/ int CompareTo(UnityEngine.Rendering.SharedInstanceHandle other);
            /*0x3bb5a90*/ int GetHashCode();
        }

        struct GPUInstanceIndex : System.IEquatable<UnityEngine.Rendering.GPUInstanceIndex>, System.IComparable<UnityEngine.Rendering.GPUInstanceIndex>
        {
            static /*0x0*/ UnityEngine.Rendering.GPUInstanceIndex Invalid;
            /*0x10*/ int <index>k__BackingField;

            static /*0x3bb5c74*/ GPUInstanceIndex();
            /*0x3bb5b30*/ int get_index();
            /*0x3bb5b38*/ void set_index(int value);
            /*0x3bb5b40*/ bool Equals(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x3bb5ba8*/ int CompareTo(UnityEngine.Rendering.GPUInstanceIndex other);
            /*0x3bb5c20*/ int GetHashCode();
        }

        struct InstanceAllocator
        {
            /*0x10*/ Unity.Collections.NativeArray<int> m_StructData;
            /*0x20*/ Unity.Collections.NativeList<int> m_FreeInstances;
            /*0x28*/ int m_BaseInstanceOffset;
            /*0x2c*/ int m_InstanceStride;

            /*0x3bb5cc0*/ int get_length();
            /*0x3bb5ccc*/ void set_length(int value);
            /*0x3bb5cd8*/ void Initialize(int baseInstanceOffset, int instanceStride);
            /*0x3bb5d98*/ void Dispose();
            /*0x3bb5e08*/ int AllocateInstance();
            /*0x3bb5f2c*/ void FreeInstance(int instance);
            /*0x3bb5f88*/ int GetNumAllocated();
        }

        struct InstanceAllocators
        {
            /*0x10*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_MeshRenderer;
            /*0x30*/ UnityEngine.Rendering.InstanceAllocator m_InstanceAlloc_SpeedTree;
            /*0x50*/ UnityEngine.Rendering.InstanceAllocator m_SharedInstanceAlloc;

            /*0x3bb5ff4*/ void Initialize();
            /*0x3bb6054*/ void Dispose();
            /*0x3bb6074*/ UnityEngine.Rendering.InstanceAllocator GetInstanceAllocator(UnityEngine.Rendering.InstanceType type);
            /*0x3bb60dc*/ int GetInstanceHandlesLength(UnityEngine.Rendering.InstanceType type);
            /*0x3bb6100*/ int GetInstancesLength(UnityEngine.Rendering.InstanceType type);
            /*0x3bb6124*/ UnityEngine.Rendering.InstanceHandle AllocateInstance(UnityEngine.Rendering.InstanceType type);
            /*0x3bb61bc*/ void FreeInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6250*/ UnityEngine.Rendering.SharedInstanceHandle AllocateSharedInstance();
            /*0x3bb62b4*/ void FreeSharedInstance(UnityEngine.Rendering.SharedInstanceHandle instance);
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

            /*0x3bb6318*/ int get_instancesLength();
            /*0x3bb6324*/ void set_instancesLength(int value);
            /*0x3bb6330*/ int get_instancesCapacity();
            /*0x3bb633c*/ void set_instancesCapacity(int value);
            /*0x3bb6348*/ void Initialize(int initCapacity);
            /*0x3bb669c*/ void Dispose();
            /*0x3bb67b4*/ void Grow(int newCapacity);
            /*0x3bb69d0*/ void AddUnsafe(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6b8c*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6c14*/ UnityEngine.Rendering.InstanceHandle IndexToInstance(int index);
            /*0x3bb6c20*/ int GetFreeInstancesCount();
            /*0x3bb6c30*/ void EnsureFreeInstances(int instancesCount);
            /*0x3bb6c58*/ void AddNoGrow(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6d28*/ void Remove(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6ef0*/ void Set(UnityEngine.Rendering.InstanceHandle instance, UnityEngine.Rendering.SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, ref UnityEngine.Rendering.AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame);
            /*0x3bb6c84*/ void SetDefault(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6fc8*/ UnityEngine.Rendering.SharedInstanceHandle Get_SharedInstance(UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb6fe8*/ void Set_TetrahedronCacheIndex(UnityEngine.Rendering.InstanceHandle instance, int tetrahedronCacheIndex);
            /*0x3bb7014*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly AsReadOnly();

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

                /*0x3bb7048*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
                /*0x3bb7330*/ int get_handlesLength();
                /*0x3bb736c*/ int get_instancesLength();
                /*0x3bb73ac*/ int InstanceToIndex(UnityEngine.Rendering.InstanceHandle instance);
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

            /*0x3bb7444*/ int get_instancesLength();
            /*0x3bb7450*/ void set_instancesLength(int value);
            /*0x3bb745c*/ int get_instancesCapacity();
            /*0x3bb7468*/ void set_instancesCapacity(int value);
            /*0x3bb7474*/ void Initialize(int initCapacity);
            /*0x3bb77a0*/ void Dispose();
            /*0x3bb7b24*/ void Grow(int newCapacity);
            /*0x3bb7d88*/ void AddUnsafe(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb7f44*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb7fcc*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData instanceData, UnityEngine.Rendering.InstanceHandle instance);
            /*0x3bb8024*/ int GetFreeInstancesCount();
            /*0x3bb8034*/ void EnsureFreeInstances(int instancesCount);
            /*0x3bb805c*/ void AddNoGrow(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb8100*/ void Remove(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb82f4*/ int Get_RendererGroupID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb8314*/ int Get_MeshID(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb8334*/ int Get_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb8354*/ void Set_RefCount(UnityEngine.Rendering.SharedInstanceHandle instance, int refCount);
            /*0x3bb8380*/ void Set(UnityEngine.Rendering.SharedInstanceHandle instance, int rendererGroupID, ref UnityEngine.Rendering.SmallIntegerArray materialIDs, int meshID, ref UnityEngine.Rendering.AABB localAABB, UnityEngine.Rendering.TransformUpdateFlags transformUpdateFlags, UnityEngine.Rendering.InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount);
            /*0x3bb8088*/ void SetDefault(UnityEngine.Rendering.SharedInstanceHandle instance);
            /*0x3bb84b8*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly AsReadOnly();

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

                /*0x3bb84ec*/ ReadOnly(ref UnityEngine.Rendering.CPUSharedInstanceData instanceData);
                /*0x3bb8888*/ int SharedInstanceToIndex(UnityEngine.Rendering.SharedInstanceHandle instance);
                /*0x3bb8920*/ int InstanceToIndex(ref UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData, UnityEngine.Rendering.InstanceHandle instance);
            }
        }

        struct SmallIntegerArray : System.IDisposable
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<int> m_FixedArray;
            /*0x30*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<int> m_List;
            /*0x48*/ bool m_IsEmbedded;
            /*0x49*/ bool <Valid>k__BackingField;
            /*0x4c*/ int Length;

            /*0x3bb89bc*/ SmallIntegerArray(int length, Unity.Collections.Allocator allocator);
            /*0x3bb89ac*/ bool get_Valid();
            /*0x3bb89b4*/ void set_Valid(bool value);
            /*0x3bb8b60*/ int get_Item(int index);
            /*0x3bb8c24*/ void set_Item(int index, int value);
            /*0x3bb7acc*/ void Dispose();
        }

        struct EditorInstanceDataArrays
        {
            /*0x3bb6698*/ void Initialize(int initCapacity);
            /*0x3bb67b0*/ void Dispose();
            /*0x3bb69cc*/ void Grow(int newCapacity);
            /*0x3bb6eec*/ void Remove(int index, int lastIndex);
            /*0x3bb6fc4*/ void SetDefault(int index);

            struct ReadOnly
            {
                /*0x3bb73a8*/ ReadOnly(ref UnityEngine.Rendering.CPUInstanceData instanceData);
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

            static /*0x3bb8cc4*/ UnityEngine.Rendering.PackedMatrix FromMatrix4x4(ref UnityEngine.Matrix4x4 m);
            static /*0x3bb8d04*/ UnityEngine.Rendering.PackedMatrix FromFloat4x4(ref Unity.Mathematics.float4x4 m);
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

            static /*0x1f3203c*/ int AtomicAddLengthNoResize<T>(ref Unity.Collections.NativeList<T> list, int count);
            /*0x3bb8e40*/ InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x3bb8d44*/ bool get_hasBoundingSpheres();
            /*0x3bb8d4c*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x3bb8d9c*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x3bb8dec*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x3bb90a8*/ void Dispose();
            /*0x3bb9164*/ int GetMaxInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x3bb918c*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x3bb91b4*/ void EnsureIndexQueueBufferCapacity(int capacity);
            /*0x3bb925c*/ void EnsureProbeBuffersCapacity(int capacity);
            /*0x3bb93d8*/ void EnsureTransformBuffersCapacity(int capacity);
            /*0x3bb957c*/ Unity.Jobs.JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeUpdateInstanceQueue, Unity.Collections.NativeArray<int> compactTetrahedronCache, Unity.Collections.NativeArray<UnityEngine.Vector3> probeQueryPosition, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue);
            /*0x3bb971c*/ void DispatchProbeUpdateCommand(int queueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probeUpdateDataQueue, Unity.Collections.NativeArray<UnityEngine.Vector4> probeOcclusionUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bb9a04*/ void DispatchMotionUpdateCommand(int motionQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bb9c74*/ void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformInstanceQueue, Unity.Collections.NativeArray<UnityEngine.Rendering.TransformUpdatePacket> updateDataQueue, Unity.Collections.NativeArray<Unity.Mathematics.float4> boundingSphereUpdateDataQueue, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bba01c*/ void DispatchWindDataCopyHistoryCommand(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bba288*/ void UpdateInstanceMotionsData(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bba458*/ void UpdateInstanceTransformsData(bool initialize, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbaa54*/ void UpdateInstanceProbesData(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbadb4*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbae14*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bbb008*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x3bbb084*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap);
            /*0x3bbb1c0*/ void UpdateAllInstanceProbes(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbb250*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbb298*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbb2dc*/ void UpdateInstanceMotions(ref UnityEngine.Rendering.RenderersParameters renderersParameters, UnityEngine.Rendering.GPUInstanceDataBuffer outputBuffer);
            /*0x3bbb2f0*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bbb39c*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bbb4b0*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<int> instancesOffset, Unity.Collections.NativeArray<int> instancesCount, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bbb688*/ Unity.Jobs.JobHandle ScheduleQuerySortedMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bbb798*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x3bbbb58*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);

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

                static /*0x3bbbc34*/ InstanceTransformUpdateIDs();
            }

            class InstanceWindDataUpdateIDs
            {
                static /*0x0*/ int _WindDataQueueCount;
                static /*0x4*/ int _WindDataUpdateIndexQueue;
                static /*0x8*/ int _WindDataBuffer;
                static /*0xc*/ int _WindParamAddressArray;
                static /*0x10*/ int _WindHistoryParamAddressArray;

                static /*0x3bbbf8c*/ InstanceWindDataUpdateIDs();
            }

            struct QueryRendererGroupInstancesCountJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x1a8*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x1b8*/ Unity.Collections.NativeArray<int> instancesCount;

                /*0x3bbc0c4*/ void Execute(int startIndex, int count);
            }

            struct ComputeInstancesOffsetAndResizeInstancesArrayJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<int> instancesCount;
                /*0x20*/ Unity.Collections.NativeArray<int> instancesOffset;
                /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x3bbc1a0*/ void Execute();
            }

            struct QueryRendererGroupInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash;
                /*0x20*/ Unity.Collections.NativeArray<int> rendererGroupIDs;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x40*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicNonFoundInstancesCount;

                /*0x3bbc228*/ void Execute(int startIndex, int count);
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

                /*0x3bbc33c*/ void Execute(int startIndex, int count);
            }

            struct QuerySortedMeshInstancesJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf0*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<int> sortedMeshID;
                /*0x1a8*/ Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances;

                /*0x3bbc4fc*/ void Execute(int startIndex, int count);
            }

            struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int probesCount;
                /*0x18*/ UnityEngine.LightProbesQuery lightProbesQuery;
                /*0x28*/ Unity.Collections.NativeArray<UnityEngine.Vector3> queryPostitions;
                /*0x38*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> probesSphericalHarmonics;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Vector4> probesOcclusion;

                /*0x3bbc720*/ void Execute(int index);
            }

            struct ScatterTetrahedronCacheIndicesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> probeInstances;
                /*0x20*/ Unity.Collections.NativeArray<int> compactTetrahedronCache;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x3bbc878*/ void Execute(int index);
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

                /*0x3bbc8b4*/ void Execute(int startIndex, int count);
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

                /*0x3bbcf1c*/ void Execute(int startIndex, int count);
            }

            struct MotionUpdateJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ int queueWriteBase;
                /*0x18*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0xf8*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 atomicUpdateQueueCount;
                /*0x100*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> transformUpdateInstanceQueue;

                /*0x3bbd1bc*/ void Execute(int chunk_index);
            }

            struct UpdateRendererInstancesJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ bool implicitInstanceIndices;
                /*0x18*/ UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData;
                /*0x1d8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x1e8*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataMap;
                /*0x1f8*/ UnityEngine.Rendering.CPUInstanceData instanceData;
                /*0x2d8*/ UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData;

                /*0x3bbd33c*/ void Execute(int index);
            }

            struct CollectInstancesLODGroupsAndMasksJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances;
                /*0x20*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly instanceData;
                /*0xf8*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly sharedInstanceData;
                /*0x198*/ Unity.Collections.NativeArray<uint> lodGroupAndMasks;

                /*0x3bbd840*/ void Execute(int index);
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

                /*0x3bbd8d8*/ void Execute(int startIndex, int count);
            }

            struct UpdateCompactedInstanceVisibilityJob : Unity.Jobs.IJobParallelForBatch
            {
                /*0x10*/ UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks;
                /*0x30*/ UnityEngine.Rendering.CPUInstanceData instanceData;

                /*0x3bbdd00*/ void Execute(int startIndex, int count);
            }
        }

        class InstanceDataSystemBurst
        {
            static /*0x3bbde58*/ void ReallocateInstances(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<int> rendererGroupIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData, ref Unity.Collections.NativeArray<int> instanceOffsets, ref Unity.Collections.NativeArray<int> instanceCounts, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            static /*0x3bbde64*/ void FreeRendererGroupInstances(ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroupsID, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            static /*0x3bbe068*/ void ReallocateInstances$BurstManaged(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<int> rendererGroupIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData, ref Unity.Collections.NativeArray<int> instanceOffsets, ref Unity.Collections.NativeArray<int> instanceCounts, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            static /*0x3bbe494*/ void FreeRendererGroupInstances$BurstManaged(ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroupsID, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);

            class ReallocateInstances_0000027F$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bbe7b4*/ ReallocateInstances_0000027F$PostfixBurstDelegate(object , nint );
                /*0x3bbe854*/ void Invoke(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<int> rendererGroupIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData, ref Unity.Collections.NativeArray<int> instanceOffsets, ref Unity.Collections.NativeArray<int> instanceCounts, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            }

            class ReallocateInstances_0000027F$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bbe87c*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bbe96c*/ nint GetFunctionPointer();
                static /*0x3bbde68*/ void Invoke(bool implicitInstanceIndices, ref Unity.Collections.NativeArray<int> rendererGroupIDs, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData, ref Unity.Collections.NativeArray<int> instanceOffsets, ref Unity.Collections.NativeArray<int> instanceCounts, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            }

            class FreeRendererGroupInstances_00000280$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bbe984*/ FreeRendererGroupInstances_00000280$PostfixBurstDelegate(object , nint );
                /*0x3bbea38*/ void Invoke(ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroupsID, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            }

            class FreeRendererGroupInstances_00000280$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bbea4c*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bbeb3c*/ nint GetFunctionPointer();
                static /*0x3bbdf8c*/ void Invoke(ref Unity.Collections.NativeArray.ReadOnly<int> rendererGroupsID, ref UnityEngine.Rendering.InstanceAllocators instanceAllocators, ref UnityEngine.Rendering.CPUInstanceData instanceData, ref UnityEngine.Rendering.CPUSharedInstanceData sharedInstanceData, ref Unity.Collections.NativeParallelMultiHashMap<int, UnityEngine.Rendering.InstanceHandle> rendererGroupInstanceMultiHash);
            }

            class FreeInstances_00000281$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;
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

            static /*0x3bbeb54*/ InstanceTypeInfo();
            static /*0x3bbeb68*/ void InitParentTypes();
            static /*0x3bbec28*/ void InitChildTypes();
            static /*0x3bbef68*/ void FlattenChildInstanceTypes(UnityEngine.Rendering.InstanceType instanceType, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceType> instanceTypes);
            static /*0x3bbee30*/ void ValidateTypeRelationsAreCorrectlySorted();
            static /*0x3bbf198*/ System.Collections.Generic.List<UnityEngine.Rendering.InstanceType> GetChildTypes(UnityEngine.Rendering.InstanceType type);
        }

        struct InstanceNumInfo
        {
            /*0x10*/ UnityEngine.Rendering.InstanceNumInfo.<InstanceNums> InstanceNums;

            /*0x3bbf21c*/ InstanceNumInfo(int meshRendererNum, int speedTreeNum);
            /*0x3bbf214*/ void InitDefault();
            /*0x3bbf224*/ int GetInstanceNum(UnityEngine.Rendering.InstanceType type);
            /*0x3bbf22c*/ int GetInstanceNumIncludingChildren(UnityEngine.Rendering.InstanceType type);
            /*0x3bbf410*/ int GetTotalInstanceNum();

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

            static /*0x3bbf41c*/ UnityEngine.Rendering.OccluderDerivedData FromParameters(ref UnityEngine.Rendering.OccluderSubviewUpdate occluderSubviewUpdate);
        }

        struct OccluderHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle occluderDepthPyramid;
            /*0x20*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle occlusionDebugOverlay;

            /*0x3bbf740*/ bool IsValid();
            /*0x3bbf848*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
            /*0x3bbf9a0*/ void UseForOccluderUpdate(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
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
            /*0x20*/ uint maxInstanceCountAndTopology;
        }

        struct IndirectBufferAllocInfo
        {
            /*0x10*/ int drawAllocIndex;
            /*0x14*/ int drawCount;
            /*0x18*/ int instanceAllocIndex;
            /*0x1c*/ int instanceCount;

            /*0x3bbfaf8*/ bool IsEmpty();
            /*0x3bbfb08*/ bool IsWithinLimits(ref UnityEngine.Rendering.IndirectBufferLimits limits);
            /*0x3bbfb3c*/ int GetExtraDrawInfoSlotIndex();
        }

        struct IndirectBufferContext
        {
            /*0x10*/ Unity.Jobs.JobHandle cullingJobHandle;
            /*0x20*/ UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState;
            /*0x24*/ int occluderVersion;
            /*0x28*/ int subviewMask;

            /*0x3bbfb48*/ IndirectBufferContext(Unity.Jobs.JobHandle cullingJobHandle);
            /*0x3bbfb58*/ bool Matches(UnityEngine.Rendering.IndirectBufferContext.BufferState bufferState, int occluderVersion, int subviewMask);

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

            static /*0x3bc015c*/ void SetKeyword(UnityEngine.Rendering.ComputeCommandBuffer cmd, UnityEngine.ComputeShader cs, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3bbfb88*/ int get_subviewCount();
            /*0x3bbfb90*/ bool IsSubviewValid(int subviewIndex);
            /*0x3bbfbb4*/ UnityEngine.Vector2 get_depthBufferSizeInOccluderPixels();
            /*0x3bbfbcc*/ void Dispose();
            /*0x3bbfd08*/ void UpdateMipBounds();
            /*0x3bbfeb4*/ void AllocateTexturesIfNecessary(bool debugOverlayEnabled);
            /*0x3bc0188*/ UnityEngine.Rendering.OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes);
            /*0x3bc055c*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles, Unity.Collections.NativeArray<UnityEngine.Plane> silhouettePlanes, UnityEngine.ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel);
            /*0x3bc0a38*/ UnityEngine.Rendering.OccluderHandles Import(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x3bc0ae0*/ void PrepareOccluders(ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x3bc0be0*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetDebugOutput();

            class ShaderIDs
            {
                static /*0x0*/ int _SrcDepth;
                static /*0x4*/ int _DstDepth;
                static /*0x8*/ int OccluderDepthPyramidConstants;

                static /*0x3bc0d14*/ ShaderIDs();
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

            static /*0x3bc0de4*/ UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings FromSpan(System.ReadOnlySpan<UnityEngine.Rendering.SubviewOcclusionTest> subviewOcclusionTests);
        }

        struct IndirectBufferContextHandles
        {
            /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceBuffer;
            /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle instanceInfoBuffer;
            /*0x28*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle argsBuffer;
            /*0x34*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle drawInfoBuffer;

            /*0x3bc0e8c*/ void UseForOcclusionTest(UnityEngine.Rendering.RenderGraphModule.IBaseRenderGraphBuilder builder);
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

            /*0x3bc1088*/ UnityEngine.GraphicsBuffer get_instanceBuffer();
            /*0x3bc1090*/ UnityEngine.GraphicsBuffer get_instanceInfoBuffer();
            /*0x3bc1098*/ UnityEngine.GraphicsBuffer get_argsBuffer();
            /*0x3bc10a0*/ UnityEngine.GraphicsBuffer get_drawInfoBuffer();
            /*0x3bc10a8*/ UnityEngine.GraphicsBufferHandle get_visibleInstanceBufferHandle();
            /*0x3bc10c0*/ UnityEngine.GraphicsBufferHandle get_indirectArgsBufferHandle();
            /*0x3bc10d8*/ UnityEngine.Rendering.IndirectBufferContextHandles ImportBuffers(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph);
            /*0x3bc11ac*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectInstanceInfo> get_instanceInfoGlobalArray();
            /*0x3bc11b8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectDrawInfo> get_drawInfoGlobalArray();
            /*0x3bc11c4*/ Unity.Collections.NativeArray<int> get_allocationCounters();
            /*0x3bc11d0*/ void Init();
            /*0x3bc1324*/ void AllocateInstanceBuffers(int maxInstanceCount);
            /*0x3bc165c*/ void FreeInstanceBuffers();
            /*0x3bc1464*/ void AllocateDrawBuffers(int maxDrawCount);
            /*0x3bc16d0*/ void FreeDrawBuffers();
            /*0x3bc1744*/ void Dispose();
            /*0x3bc1814*/ void SyncContexts();
            /*0x3bc15a8*/ void ResetAllocators();
            /*0x3bc18dc*/ void GrowBuffers();
            /*0x3bc1a70*/ void ClearContextsAndGrowBuffers();
            /*0x3bc1a90*/ int TryAllocateContext(int viewID);
            /*0x3bc1bd8*/ int TryGetContextIndex(int viewID);
            /*0x3bc1c50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex);
            /*0x3bc1cac*/ UnityEngine.Rendering.IndirectBufferAllocInfo GetAllocInfo(int contextIndex);
            /*0x3bc1d34*/ void CopyFromStaging(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.IndirectBufferAllocInfo allocInfo);
            /*0x3bc1dec*/ UnityEngine.Rendering.IndirectBufferLimits GetLimits(int contextIndex);
            /*0x3bc1e00*/ UnityEngine.Rendering.IndirectBufferContext GetBufferContext(int contextIndex);
            /*0x3bc1ebc*/ void SetBufferContext(int contextIndex, UnityEngine.Rendering.IndirectBufferContext ctx);
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
            /*0x6c*/ byte forceLODMask;

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

            /*0x3bc1f70*/ void Execute(int index);
        }

        struct UpdateLODGroupDataJob : Unity.Jobs.IJobParallelFor
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances;
            /*0x20*/ UnityEngine.Rendering.GPUDrivenLODGroupData inputData;
            /*0xf0*/ bool supportDitheringCrossFade;
            /*0xf8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupData> lodGroupsData;
            /*0x108*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LODGroupCullingData> lodGroupsCullingData;
            /*0x118*/ Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32 rendererCount;

            /*0x3bc2154*/ void Execute(int index);
        }

        class LODGroupDataPool : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> m_LODGroupData;
            /*0x18*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> m_LODGroupDataHash;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> m_LODGroupCullingData;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> m_FreeLODGroupDataHandles;
            /*0x38*/ int m_CrossfadedRendererCount;
            /*0x3c*/ bool m_SupportDitheringCrossFade;

            /*0x3bc2460*/ LODGroupDataPool(UnityEngine.Rendering.GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade);
            /*0x3bc2444*/ Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> get_lodGroupDataHash();
            /*0x3bc2450*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x3bc2458*/ int get_crossfadedRendererCount();
            /*0x3bc25b0*/ void Dispose();
            /*0x3bc2668*/ void UpdateLODGroupTransformData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x3bc27b8*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData inputData);
            /*0x3bc2a0c*/ void FreeLODGroupData(Unity.Collections.NativeArray<int> destroyedLODGroupsID);
        }

        class LODGroupDataPoolBurst
        {
            static /*0x3bc2a50*/ int FreeLODGroupData(ref Unity.Collections.NativeArray<int> destroyedLODGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles);
            static /*0x3bc2a4c*/ int AllocateOrGetLODGroupDataInstances(ref Unity.Collections.NativeArray<int> lodGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances);
            static /*0x3bc2c00*/ int FreeLODGroupData$BurstManaged(ref Unity.Collections.NativeArray<int> destroyedLODGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles);
            static /*0x3bc2ec4*/ int AllocateOrGetLODGroupDataInstances$BurstManaged(ref Unity.Collections.NativeArray<int> lodGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances);

            class FreeLODGroupData_000002D0$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bc3160*/ FreeLODGroupData_000002D0$PostfixBurstDelegate(object , nint );
                /*0x3bc3214*/ int Invoke(ref Unity.Collections.NativeArray<int> destroyedLODGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles);
            }

            class FreeLODGroupData_000002D0$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bc3228*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bc3318*/ nint GetFunctionPointer();
                static /*0x3bc2a54*/ int Invoke(ref Unity.Collections.NativeArray<int> destroyedLODGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles);
            }

            class AllocateOrGetLODGroupDataInstances_000002D1$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x3bc3330*/ AllocateOrGetLODGroupDataInstances_000002D1$PostfixBurstDelegate(object , nint );
                /*0x3bc33e4*/ int Invoke(ref Unity.Collections.NativeArray<int> lodGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances);
            }

            class AllocateOrGetLODGroupDataInstances_000002D1$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;

                static /*0x3bc33f8*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x3bc34e8*/ nint GetFunctionPointer();
                static /*0x3bc2b18*/ int Invoke(ref Unity.Collections.NativeArray<int> lodGroupsID, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupData> lodGroupsData, ref Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> lodGroupCullingData, ref Unity.Collections.NativeParallelHashMap<int, UnityEngine.Rendering.GPUInstanceIndex> lodGroupDataHash, ref Unity.Collections.NativeList<UnityEngine.Rendering.GPUInstanceIndex> freeLODGroupDataHandles, ref Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> lodGroupInstances);
            }
        }

        class LODGroupRenderingUtils
        {
            static /*0x3bc3500*/ float CalculateFOVHalfAngle(float fieldOfView);
            static /*0x3bc3518*/ float CalculateScreenRelativeMetric(UnityEngine.Rendering.LODParameters lodParams, float lodBias);
            static /*0x3bc357c*/ float CalculateSqrPerspectiveDistance(UnityEngine.Vector3 objPosition, UnityEngine.Vector3 camPosition, float sqrScreenRelativeMetric);
            static /*0x3bc214c*/ float CalculateLODDistance(float relativeScreenHeight, float size);
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

            /*0x3bc35a4*/ void Init(UnityEngine.ComputeShader cs);
        }

        struct SilhouettePlaneCache : System.IDisposable
        {
            /*0x10*/ Unity.Collections.NativeParallelHashMap<int, int> m_SubviewIDToIndexMap;
            /*0x20*/ Unity.Collections.NativeList<int> m_SlotFreeList;
            /*0x28*/ Unity.Collections.NativeList<UnityEngine.Rendering.SilhouettePlaneCache.Slot> m_Slots;
            /*0x30*/ Unity.Collections.NativeList<UnityEngine.Plane> m_PlaneStorage;

            /*0x3bc3640*/ void Init();
            /*0x3bc3784*/ void Dispose();
            /*0x3bc383c*/ void Update(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes, int frameIndex);
            /*0x3bc3c7c*/ void FreeUnusedSlots(int frameIndex, int maximumAge);
            /*0x3bc3dec*/ Unity.Collections.NativeArray<UnityEngine.Plane> GetSubArray(int viewInstanceID);

            struct Slot
            {
                /*0x10*/ bool isActive;
                /*0x14*/ int viewInstanceID;
                /*0x18*/ int planeCount;
                /*0x1c*/ int lastUsedFrameIndex;

                /*0x3bc3c68*/ Slot(int viewInstanceID, int planeCount, int frameIndex);
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

            static /*0x3bc7598*/ OcclusionCullingCommon();
            static /*0x3bc435c*/ bool UseOcclusionDebug(ref UnityEngine.Rendering.OccluderContext occluderCtx);
            static /*0x3bc4b60*/ void SetDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            static /*0x3bc4bf8*/ void SetDebugPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, int kernel, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x3bc7590*/ OcclusionCullingCommon();
            /*0x3bc3eec*/ void Init(UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x3bc436c*/ void PrepareCulling(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.OcclusionCullingSettings settings, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, ref UnityEngine.Rendering.OcclusionTestComputeShader shader, bool useOcclusionDebug);
            /*0x3bc4cd4*/ void RenderDebugOcclusionTestOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x3bc56ac*/ void RenderDebugOccluderOverlay(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.DebugDisplayGPUResidentDrawer debugSettings, UnityEngine.Vector2 screenPos, float maxHeight, UnityEngine.Rendering.RenderGraphModule.TextureHandle colorBuffer);
            /*0x3bc4860*/ void DispatchDebugClear(UnityEngine.Rendering.ComputeCommandBuffer cmd, int viewInstanceID);
            /*0x3bc5c54*/ UnityEngine.Rendering.OccluderHandles PrepareOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams);
            /*0x3bc627c*/ void CreateFarDepthPyramid(UnityEngine.Rendering.ComputeCommandBuffer cmd, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates, ref UnityEngine.Rendering.OccluderHandles occluderHandles);
            /*0x3bc6468*/ bool UpdateInstanceOccluders(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.OccluderParameters occluderParams, System.ReadOnlySpan<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates);
            /*0x3bc6bb4*/ void UpdateSilhouettePlanes(int viewInstanceID, Unity.Collections.NativeArray<UnityEngine.Plane> planes);
            /*0x3bc5548*/ UnityEngine.Rendering.OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID);
            /*0x3bc6bc0*/ void UpdateOccluderStats(UnityEngine.Rendering.DebugRendererBatcherStats debugStats);
            /*0x3bc6f38*/ bool HasOccluderContext(int viewInstanceID);
            /*0x3bc6f9c*/ bool GetOccluderContext(int viewInstanceID, ref UnityEngine.Rendering.OccluderContext occluderContext);
            /*0x3bc70b0*/ void UpdateFrame();
            /*0x3bc5ea4*/ int NewContext(int viewInstanceID);
            /*0x3bc6100*/ void DeleteContext(int viewInstanceID);
            /*0x3bc7310*/ void Dispose();
            /*0x3bc75e4*/ void <RenderDebugOcclusionTestOverlay>b__29_1(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);

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

                static /*0x3bc76ec*/ ShaderIDs();
            }

            class OcclusionTestOverlaySetupPassData
            {
                /*0x10*/ UnityEngine.Rendering.OcclusionCullingDebugShaderVariables cb;

                /*0x3bc77f4*/ OcclusionTestOverlaySetupPassData();
            }

            class OcclusionTestOverlayPassData
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BufferHandle debugPyramid;

                /*0x3bc77fc*/ OcclusionTestOverlayPassData();
            }

            class OccluderOverlayPassData
            {
                /*0x10*/ UnityEngine.Material debugMaterial;
                /*0x18*/ UnityEngine.Rendering.RTHandle occluderTexture;
                /*0x20*/ UnityEngine.Rect viewport;
                /*0x30*/ int passIndex;
                /*0x34*/ UnityEngine.Vector2 validRange;

                /*0x3bc7804*/ OccluderOverlayPassData();
            }

            class UpdateOccludersPassData
            {
                /*0x10*/ UnityEngine.Rendering.OccluderParameters occluderParams;
                /*0x38*/ System.Collections.Generic.List<UnityEngine.Rendering.OccluderSubviewUpdate> occluderSubviewUpdates;
                /*0x40*/ UnityEngine.Rendering.OccluderHandles occluderHandles;

                /*0x3bc780c*/ UpdateOccludersPassData();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.OcclusionCullingCommon.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__29_0;
                static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext> <>9__32_0;
                static /*0x18*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext> <>9__37_0;

                static /*0x3bc7814*/ <>c();
                /*0x3bc787c*/ <>c();
                /*0x3bc7884*/ void <RenderDebugOcclusionTestOverlay>b__29_0(UnityEngine.Rendering.OcclusionCullingCommon.OcclusionTestOverlaySetupPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext ctx);
                /*0x3bc79b0*/ void <RenderDebugOccluderOverlay>b__32_0(UnityEngine.Rendering.OcclusionCullingCommon.OccluderOverlayPassData data, UnityEngine.Rendering.RenderGraphModule.RasterGraphContext ctx);
                /*0x3bc7b28*/ void <UpdateInstanceOccluders>b__37_0(UnityEngine.Rendering.OcclusionCullingCommon.UpdateOccludersPassData data, UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext context);
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

            /*0x3bc452c*/ OcclusionCullingCommonShaderVariables(ref UnityEngine.Rendering.OccluderContext occluderCtx, ref UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass);

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

            static /*0x3bc7e24*/ UnityEngine.Rendering.RenderersBatchersContextDesc NewDefault();
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

            /*0x3bc8010*/ RenderersBatchersContext(ref UnityEngine.Rendering.RenderersBatchersContextDesc desc, UnityEngine.Rendering.GPUDrivenProcessor gpuDrivenProcessor, UnityEngine.Rendering.GPUResidentDrawerResources resources);
            /*0x3bc7e4c*/ UnityEngine.Rendering.RenderersParameters get_renderersParameters();
            /*0x3bc7e5c*/ UnityEngine.GraphicsBuffer get_gpuInstanceDataBuffer();
            /*0x3bc7e74*/ Unity.Collections.NativeArray.ReadOnly<UnityEngine.Rendering.GPUInstanceComponentDesc> get_defaultDescriptions();
            /*0x3bc7ec8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> get_defaultMetadata();
            /*0x3bc7ee0*/ Unity.Collections.NativeList<UnityEngine.Rendering.LODGroupCullingData> get_lodGroupCullingData();
            /*0x3bc7ef8*/ int get_instanceDataBufferLayoutVersion();
            /*0x3bc7f10*/ int get_crossfadedRendererCount();
            /*0x3bc7f28*/ bool get_hasBoundingSpheres();
            /*0x3bc7f40*/ UnityEngine.Rendering.CPUInstanceData.ReadOnly get_instanceData();
            /*0x3bc7f80*/ UnityEngine.Rendering.CPUSharedInstanceData.ReadOnly get_sharedInstanceData();
            /*0x3bc7fc0*/ UnityEngine.Rendering.GPUInstanceDataBuffer.ReadOnly get_instanceDataBuffer();
            /*0x3bc7fd8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> get_aliveInstances();
            /*0x3bc7ff0*/ float get_smallMeshScreenPercentage();
            /*0x3bc7ff8*/ UnityEngine.Rendering.GPUResidentDrawerResources get_resources();
            /*0x3bc8000*/ UnityEngine.Rendering.OcclusionCullingCommon get_occlusionCullingCommon();
            /*0x3bc8008*/ UnityEngine.Rendering.DebugRendererBatcherStats get_debugStats();
            /*0x3bc8a14*/ void Dispose();
            /*0x3bc8b78*/ int GetAliveInstancesOfType(UnityEngine.Rendering.InstanceType instanceType);
            /*0x3bc8b90*/ void GrowInstanceBuffer(ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            /*0x3bc8cbc*/ void EnsureInstanceBufferCapacity();
            /*0x3bc8d5c*/ void UpdateLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x3bc8d70*/ void TransformLODGroupData(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
            /*0x3bc8d84*/ void DestroyLODGroups(Unity.Collections.NativeArray<int> destroyed);
            /*0x3bc8da0*/ void UpdateLODGroups(Unity.Collections.NativeArray<int> changedID);
            /*0x3bc8e2c*/ void ReallocateAndGetInstances(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bc8e54*/ Unity.Jobs.JobHandle ScheduleUpdateInstanceDataJob(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData);
            /*0x3bc8e7c*/ void FreeRendererGroupInstances(Unity.Collections.NativeArray<int> rendererGroupsID);
            /*0x3bc8e94*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bc8eac*/ Unity.Jobs.JobHandle ScheduleQueryRendererGroupInstancesJob(Unity.Collections.NativeArray<int> rendererGroupIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bc8ec4*/ Unity.Jobs.JobHandle ScheduleQueryMeshInstancesJob(Unity.Collections.NativeArray<int> sortedMeshIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> instances);
            /*0x3bc8edc*/ void ChangeInstanceBufferVersion();
            /*0x3bc8efc*/ UnityEngine.Rendering.GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, UnityEngine.Rendering.InstanceType instanceType);
            /*0x3bc8f38*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x3bc8f60*/ void SubmitToGpu(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices, ref UnityEngine.Rendering.GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams);
            /*0x3bc8f88*/ void InitializeInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrices);
            /*0x3bc8fd4*/ void UpdateInstanceTransforms(Unity.Collections.NativeArray<UnityEngine.Rendering.InstanceHandle> instances, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices);
            /*0x3bc9018*/ void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate);
            /*0x3bc90d8*/ void UpdateInstanceWindDataHistory(Unity.Collections.NativeArray<UnityEngine.Rendering.GPUInstanceIndex> gpuInstanceIndices);
            /*0x3bc915c*/ void UpdateInstanceMotions();
            /*0x3bc919c*/ void TransformLODGroups(Unity.Collections.NativeArray<int> lodGroupsID);
            /*0x3bc9228*/ void UpdatePerFrameInstanceVisibility(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks);
            /*0x3bc9240*/ void GetVisibleTreeInstances(ref UnityEngine.Rendering.ParallelBitArray compactedVisibilityMasks, ref UnityEngine.Rendering.ParallelBitArray processedBits, Unity.Collections.NativeList<int> visibeTreeRendererIDs, Unity.Collections.NativeList<UnityEngine.Rendering.InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, ref int becomeVisibeTreeInstancesCount);
            /*0x3bc925c*/ void UpdateFrame();
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

            static /*0x3bc9350*/ RenderersParameters();
            static /*0x3bc83a8*/ UnityEngine.Rendering.GPUInstanceDataBuffer CreateInstanceDataBuffer(UnityEngine.Rendering.RenderersParameters.Flags flags, ref UnityEngine.Rendering.InstanceNumInfo instanceNumInfo);
            static /*0x3bc9294*/ UnityEngine.Rendering.RenderersParameters.ParamInfo <.ctor>g__GetParamInfo|14_0(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail);
            /*0x3bc8760*/ RenderersParameters(ref UnityEngine.Rendering.GPUInstanceDataBuffer instanceDataBuffer);

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

                static /*0x3bc93cc*/ ParamNames();
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
            static /*0x1ffc854*/ T* Malloc<T>(int count, Unity.Collections.Allocator allocator);
        }

        struct ParallelBitArray
        {
            /*0x10*/ Unity.Collections.Allocator m_Allocator;
            /*0x18*/ Unity.Collections.NativeArray<long> m_Bits;
            /*0x28*/ int m_Length;

            /*0x3bc9770*/ ParallelBitArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x3bc9724*/ int get_Length();
            /*0x3bc972c*/ bool get_IsCreated();
            /*0x3bc9810*/ void Dispose();
            /*0x3bc9860*/ void Resize(int newLength);
            /*0x3bbe3ec*/ void Set(int index, bool value);
            /*0x3bbdde4*/ bool Get(int index);
            /*0x3bc9a1c*/ ulong GetChunk(int chunk_index);
            /*0x3bbde4c*/ void SetChunk(int chunk_index, ulong chunk_bits);
            /*0x3bc9a28*/ void InterlockedOrChunk(int chunk_index, ulong chunk_bits);
            /*0x3bc9ab4*/ UnityEngine.Rendering.ParallelBitArray GetSubArray(int length);
        }

        class ParallelSortExtensions
        {
            static /*0x3bc9b34*/ Unity.Jobs.JobHandle ParallelSort(Unity.Collections.NativeArray<int> array);
            static /*0x3bca00c*/ void <ParallelSort>g__Swap|2_0(ref Unity.Collections.NativeArray<int> a, ref Unity.Collections.NativeArray<int> b);

            struct RadixSortBucketCountJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int jobsCount;
                /*0x18*/ int batchSize;
                /*0x20*/ Unity.Collections.NativeArray<int> array;
                /*0x30*/ Unity.Collections.NativeArray<int> buckets;

                /*0x3bca028*/ void Execute(int index);
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

                static /*0x3bca090*/ int AtomicIncrement(Unity.Collections.NativeArray<int> counter);
                /*0x3bca0fc*/ int JobIndexPrefixSum(int sum, int i);
                /*0x3bca144*/ void Execute(int index);
            }

            struct RadixSortPrefixSumJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int jobsCount;
                /*0x18*/ Unity.Collections.NativeArray<int> indicesSum;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;

                /*0x3bca230*/ void Execute(int index);
            }

            struct RadixSortBucketSortJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ int radix;
                /*0x14*/ int batchSize;
                /*0x18*/ Unity.Collections.NativeArray<int> array;
                /*0x28*/ Unity.Collections.NativeArray<int> indices;
                /*0x38*/ Unity.Collections.NativeArray<int> arraySorted;

                /*0x3bca2a8*/ void Execute(int index);
            }
        }
    }
}

class __JobReflectionRegistrationOutput__15867191014387474753
{
    static /*0x3bca318*/ void CreateJobReflectionData();
    static /*0x3bca804*/ void EarlyInit();
}

class $BurstDirectCallInitializer
{
    static /*0x3bca808*/ void Initialize();
}
