class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3a78c18*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3a78d0c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    namespace U2D
    {
        namespace Animation
        {
            class BaseDeformationSystem
            {
                /*0x10*/ int m_ObjectId;
                /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkins;
                /*0x20*/ UnityEngine.SpriteRenderer[] m_SpriteRenderers;
                /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkinsToAdd;
                /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkinsToRemove;
                /*0x38*/ System.Collections.Generic.List<int> m_TransformIdsToRemove;
                /*0x40*/ UnityEngine.U2D.Animation.NativeByteArray m_DeformedVerticesBuffer;
                /*0x48*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> m_FinalBoneTransforms;
                /*0x58*/ Unity.Collections.NativeArray<bool> m_IsSpriteSkinActiveForDeform;
                /*0x68*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> m_SpriteSkinData;
                /*0x78*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> m_PerSkinJobData;
                /*0x88*/ Unity.Collections.NativeArray<UnityEngine.Bounds> m_BoundsData;
                /*0x98*/ Unity.Collections.NativeArray<nint> m_Buffers;
                /*0xa8*/ Unity.Collections.NativeArray<int> m_BufferSizes;
                /*0xb8*/ Unity.Collections.NativeArray<nint> m_BoneTransformBuffers;
                /*0xc8*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_BoneLookupData;
                /*0xd8*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_VertexLookupData;
                /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> m_SkinBatchArray;
                /*0xf8*/ UnityEngine.U2D.Animation.TransformAccessJob m_LocalToWorldTransformAccessJob;
                /*0x100*/ UnityEngine.U2D.Animation.TransformAccessJob m_WorldToLocalTransformAccessJob;
                /*0x108*/ Unity.Jobs.JobHandle m_DeformJobHandle;

                /*0x3a7bef8*/ BaseDeformationSystem();
                /*0x1f2ffc8*/ UnityEngine.U2D.Animation.DeformationMethods get_deformationMethod();
                /*0x3a78d14*/ void RemoveBoneTransforms(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a79034*/ void AddBoneTransforms(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a79314*/ void UpdateMaterial(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a79318*/ bool AddSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a793dc*/ void CopyToSpriteSkinData(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7958c*/ void RemoveSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a79704*/ System.Collections.Generic.HashSet<UnityEngine.U2D.Animation.SpriteSkin> GetSpriteSkins();
                /*0x3a7970c*/ void Initialize(int objectId);
                /*0x3a7a30c*/ void InitializeArrays();
                /*0x3a79a64*/ void BatchRemoveSpriteSkins();
                /*0x3a79ecc*/ void BatchAddSpriteSkins();
                /*0x3a7ac84*/ void ResizeAndCopyArrays(int updatedCount);
                /*0x3a7adb8*/ void Cleanup();
                /*0x1f309e4*/ void Update();
                /*0x3a7b28c*/ void PrepareDataForDeformation(ref Unity.Jobs.JobHandle localToWorldJobHandle, ref Unity.Jobs.JobHandle worldToLocalJobHandle);
                /*0x3a7b500*/ void ValidateSpriteSkinData();
                /*0x3a7b960*/ bool GotVerticesToDeform(ref int vertexBufferSize);
                /*0x3a7b978*/ Unity.Jobs.JobHandle SchedulePrepareJob(int batchCount);
                /*0x3a7ba34*/ Unity.Jobs.JobHandle ScheduleBoneJobBatched(Unity.Jobs.JobHandle jobHandle, UnityEngine.U2D.Animation.PerSkinJobData skinBatch);
                /*0x3a7baec*/ Unity.Jobs.JobHandle ScheduleSkinDeformBatchedJob(Unity.Jobs.JobHandle jobHandle, UnityEngine.U2D.Animation.PerSkinJobData skinBatch);
                /*0x3a7bbb0*/ Unity.Jobs.JobHandle ScheduleCopySpriteRendererBuffersJob(Unity.Jobs.JobHandle jobHandle, int batchCount);
                /*0x3a7bc84*/ Unity.Jobs.JobHandle ScheduleCalculateSpriteSkinAABBJob(Unity.Jobs.JobHandle jobHandle, int batchCount);
                /*0x3a7bd40*/ void DeactivateDeformableBuffers();
                /*0x3a7bddc*/ bool IsSpriteSkinActiveForDeformation(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7bdf8*/ Unity.Collections.NativeArray<byte> GetDeformableBufferForSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);

                class Profiling
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker transformAccessJob;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker getSpriteSkinBatchData;
                    static /*0x10*/ Unity.Profiling.ProfilerMarker scheduleJobs;
                    static /*0x18*/ Unity.Profiling.ProfilerMarker setBatchDeformableBufferAndLocalAABB;
                    static /*0x20*/ Unity.Profiling.ProfilerMarker setBoneTransformsArray;

                    static /*0x3a7c04c*/ Profiling();
                }
            }

            class CpuDeformationSystem : UnityEngine.U2D.Animation.BaseDeformationSystem
            {
                static string k_GpuSkinningShaderKeyword = "SKINNED_SPRITE";
                /*0x118*/ Unity.Jobs.JobHandle m_BoundJobHandle;
                /*0x128*/ Unity.Jobs.JobHandle m_CopyJobHandle;

                /*0x3a7c828*/ CpuDeformationSystem();
                /*0x3a7c1c0*/ UnityEngine.U2D.Animation.DeformationMethods get_deformationMethod();
                /*0x3a7c1c8*/ void Cleanup();
                /*0x3a7c1f0*/ void UpdateMaterial(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7c278*/ void Update();
                /*0x3a7c694*/ void ResizeBuffers(int vertexBufferSize, ref UnityEngine.U2D.Animation.PerSkinJobData skinBatch);
            }

            struct PerSkinJobData
            {
                /*0x10*/ int deformVerticesStartPos;
                /*0x14*/ Unity.Mathematics.int2 bindPosesIndex;
                /*0x1c*/ Unity.Mathematics.int2 verticesIndex;
            }

            struct SpriteSkinData
            {
                /*0x10*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector3> vertices;
                /*0x20*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights;
                /*0x30*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Matrix4x4> bindPoses;
                /*0x40*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector4> tangents;
                /*0x50*/ bool hasTangents;
                /*0x54*/ int spriteVertexStreamSize;
                /*0x58*/ int spriteVertexCount;
                /*0x5c*/ int tangentVertexOffset;
                /*0x60*/ int deformVerticesStartPos;
                /*0x64*/ int transformId;
                /*0x68*/ UnityEngine.U2D.Animation.NativeCustomSlice<int> boneTransformId;
            }

            struct PrepareDeformJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobData;
                /*0x20*/ int batchDataSize;
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> boneLookupData;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> vertexLookupData;

                /*0x3a7c82c*/ void Execute();
            }

            struct BoneDeformBatchedJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransform;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> rootTransform;
                /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> boneLookupData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x50*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> rootTransformIndex;
                /*0x58*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> boneTransformIndex;
                /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> finalBoneTransforms;

                /*0x3a7c8cc*/ void Execute(int i);
            }

            struct SkinDeformBatchedJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeSlice<byte> vertices;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> finalBoneTransforms;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> vertexLookupData;

                /*0x3a7cafc*/ void Execute(int i);
            }

            struct CalculateSpriteSkinAABBJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeSlice<byte> vertices;
                /*0x20*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Bounds> bounds;

                /*0x3a7d22c*/ void Execute(int i);
            }

            struct FillPerSkinJobSingleThread : Unity.Jobs.IJob
            {
                /*0x10*/ UnityEngine.U2D.Animation.PerSkinJobData combinedSkinBatch;
                /*0x28*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x38*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinDataArray;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobDataArray;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> combinedSkinBatchArray;

                /*0x3a7d544*/ void Execute();
            }

            struct CopySpriteRendererBuffersJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x30*/ nint ptrVertices;
                /*0x38*/ Unity.Collections.NativeArray<nint> buffers;
                /*0x48*/ Unity.Collections.NativeArray<int> bufferSizes;

                /*0x3a7d6ec*/ void Execute(int i);
            }

            struct CopySpriteRendererBoneTransformBuffersJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobData;
                /*0x40*/ nint ptrBoneTransforms;
                /*0x48*/ Unity.Collections.NativeArray<nint> buffers;
                /*0x58*/ Unity.Collections.NativeArray<int> bufferSizes;

                /*0x3a7d75c*/ void Execute(int i);
            }

            enum DeformationMethods
            {
                Cpu = 0,
                Gpu = 1,
                None = 2,
            }

            class DeformationManager : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.U2D.Animation.DeformationManager s_Instance;
                /*0x18*/ UnityEngine.U2D.Animation.BaseDeformationSystem[] m_DeformationSystems;
                /*0x20*/ UnityEngine.GameObject m_Helper;
                /*0x28*/ bool <canUseGpuDeformation>k__BackingField;
                /*0x29*/ bool m_WasUsingGpuDeformationLastFrame;

                static /*0x3a7d7fc*/ UnityEngine.U2D.Animation.DeformationManager get_instance();
                /*0x3a7e7e0*/ DeformationManager();
                /*0x3a7d950*/ UnityEngine.GameObject get_helperGameObject();
                /*0x3a7d958*/ bool get_canUseGpuDeformation();
                /*0x3a7d960*/ void set_canUseGpuDeformation(bool value);
                /*0x3a7d968*/ void OnEnable();
                /*0x3a7d938*/ void Init();
                /*0x3a7dad8*/ void CreateBatchSystems();
                /*0x3a7dc80*/ void CreateHelper();
                /*0x3a7ded4*/ void OnHelperDestroyed(UnityEngine.GameObject helperGo);
                /*0x3a7df70*/ void OnDisable();
                /*0x3a7e114*/ void Update();
                /*0x3a7e198*/ bool HasToggledGpuDeformation();
                /*0x3a7e1c8*/ void MoveSpriteSkinsToActiveSystem();
                /*0x3a7e4e0*/ void AddSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7e6f8*/ void RemoveBoneTransforms(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7e75c*/ void AddSpriteSkinBoneTransform(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
            }

            class DeformationManagerUpdater : UnityEngine.MonoBehaviour
            {
                /*0x20*/ System.Action<UnityEngine.GameObject> <onDestroyingComponent>k__BackingField;
                /*0x28*/ Unity.Profiling.ProfilerMarker m_ProfilerMarker;

                /*0x3a7e900*/ DeformationManagerUpdater();
                /*0x3a7e7e8*/ System.Action<UnityEngine.GameObject> get_onDestroyingComponent();
                /*0x3a7e7f0*/ void set_onDestroyingComponent(System.Action<UnityEngine.GameObject> value);
                /*0x3a7e7f8*/ void OnDestroy();
                /*0x3a7e82c*/ void LateUpdate();
            }

            class GpuDeformationSystem : UnityEngine.U2D.Animation.BaseDeformationSystem
            {
                static string k_GpuSkinningShaderKeyword = "SKINNED_SPRITE";
                static string k_GlobalSpriteBoneBufferId = "_SpriteBoneTransforms";
                static /*0x0*/ UnityEngine.ComputeBuffer s_FallbackBuffer;
                /*0x118*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_KeywordEnabledMaterials;
                /*0x120*/ Unity.Collections.NativeArray<int> m_BoneTransformBufferSizes;
                /*0x130*/ UnityEngine.ComputeBuffer m_BoneTransformsComputeBuffer;

                static /*0x3a7e968*/ void CreateFallbackBuffer();
                static /*0x3a7ea94*/ void ClearFallbackBuffer();
                static /*0x3a7eb08*/ bool DoesShaderSupportGpuDeformation(UnityEngine.Material material);
                static /*0x3a7ec54*/ bool IsComputeBufferValid(UnityEngine.ComputeBuffer buffer);
                /*0x3a7de50*/ GpuDeformationSystem();
                /*0x3a7eb00*/ UnityEngine.U2D.Animation.DeformationMethods get_deformationMethod();
                /*0x3a7ec64*/ void InitializeArrays();
                /*0x3a7ed1c*/ void Cleanup();
                /*0x3a7f024*/ void ResizeAndCopyArrays(int updatedCount);
                /*0x3a7eda0*/ void CleanupComputeResources();
                /*0x3a7f0d0*/ void UpdateMaterial(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7f158*/ bool AddSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a7f238*/ void Update();
                /*0x3a7f66c*/ void ResizeBuffers(int vertexBufferSize, ref UnityEngine.U2D.Animation.PerSkinJobData skinBatch);
                /*0x3a7f8f0*/ void CreateComputeBuffer(int bufferSize);
                /*0x3a7f86c*/ void SetComputeBuffer();
                /*0x3a7f790*/ Unity.Jobs.JobHandle ScheduleCopySpriteRendererBoneTransformBuffersJob(Unity.Jobs.JobHandle jobHandle, int batchCount);
            }

            class TransformAccessJob
            {
                /*0x10*/ UnityEngine.Transform[] m_Transform;
                /*0x18*/ UnityEngine.Jobs.TransformAccessArray m_TransformAccessArray;
                /*0x20*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> m_TransformData;
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> m_TransformMatrix;
                /*0x38*/ bool m_Dirty;
                /*0x40*/ Unity.Jobs.JobHandle m_JobHandle;

                static /*0x1ffc854*/ void ArrayAdd<T>(ref T[] array, T item);
                static /*0x1f36244*/ void ArrayRemoveAt<T>(ref T[] array, int index);
                /*0x3a7996c*/ TransformAccessJob();
                /*0x3a7b1a0*/ void Destroy();
                /*0x3a7f9cc*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> get_transformData();
                /*0x3a7f9d4*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> get_transformMatrix();
                /*0x3a79140*/ void AddTransform(UnityEngine.Transform t);
                /*0x3a7f9ec*/ void UpdateTransformIndex();
                /*0x3a7b6fc*/ Unity.Jobs.JobHandle StartLocalToWorldJob();
                /*0x3a7b79c*/ Unity.Jobs.JobHandle StartWorldToLocalJob();
                /*0x3a7fbdc*/ string GetDebugLog();
                /*0x3a7a568*/ void RemoveTransformsByIds(System.Collections.Generic.IList<int> idsToRemove);
                /*0x3a78df0*/ void RemoveTransformById(int transformId);

                struct TransformData
                {
                    /*0x10*/ int transformIndex;
                    /*0x14*/ int refCount;

                    /*0x3a7f9e0*/ TransformData(int index);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ int id;

                    /*0x3a7fee8*/ <>c__DisplayClass20_0();
                    /*0x3a7fef8*/ bool <RemoveTransformsByIds>b__0(UnityEngine.Transform t);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ int transformId;

                    /*0x3a7fef0*/ <>c__DisplayClass21_0();
                    /*0x3a7ff28*/ bool <RemoveTransformById>b__0(UnityEngine.Transform t);
                }
            }

            struct LocalToWorldTransformAccessJob : UnityEngine.Jobs.IJobParallelForTransform
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> outMatrix;

                /*0x3a7ff58*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
            }

            struct WorldToLocalTransformAccessJob : UnityEngine.Jobs.IJobParallelForTransform
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> outMatrix;

                /*0x3a7ffcc*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
            }

            struct UpdateBoundJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<int> rootTransformId;
                /*0x20*/ Unity.Collections.NativeArray<int> rootBoneTransformId;
                /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> rootTransform;
                /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransform;
                /*0x50*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> rootTransformIndex;
                /*0x58*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> boneTransformIndex;
                /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Bounds> spriteSkinBound;
                /*0x70*/ Unity.Collections.NativeArray<UnityEngine.Bounds> bounds;

                /*0x3a80040*/ void Execute(int i);
            }

            class Bone : UnityEngine.MonoBehaviour
            {
                /*0x20*/ string m_Guid;

                /*0x3a8040c*/ Bone();
                /*0x3a803fc*/ string get_guid();
                /*0x3a80404*/ void set_guid(string value);
            }

            class VertexBuffer
            {
                /*0x10*/ int m_Id;
                /*0x14*/ bool m_IsActive;
                /*0x18*/ int m_DeactivateFrame;
                /*0x20*/ UnityEngine.U2D.Animation.NativeByteArray[] m_Buffers;
                /*0x28*/ int m_ActiveIndex;

                static /*0x3a805dc*/ int GetCurrentFrame();
                /*0x3a8042c*/ VertexBuffer(int id, int size, bool needDoubleBuffering);
                /*0x3a80414*/ int get_bufferCount();
                /*0x3a805d4*/ int GetHashCode();
                /*0x3a805e4*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int size);
                /*0x3a80724*/ void ResizeBuffer(int bufferId, int newSize);
                /*0x3a808a4*/ void Deactivate();
                /*0x3a808cc*/ void Dispose();
                /*0x3a809cc*/ bool IsSafeToDispose();
            }

            class BufferManager : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.U2D.Animation.BufferManager s_Instance;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.VertexBuffer> m_Buffers;
                /*0x20*/ System.Collections.Generic.Queue<UnityEngine.U2D.Animation.VertexBuffer> m_BuffersToDispose;
                /*0x28*/ bool <needDoubleBuffering>k__BackingField;

                static /*0x3a7af9c*/ UnityEngine.U2D.Animation.BufferManager get_instance();
                /*0x3a81358*/ BufferManager();
                /*0x3a80a00*/ int get_bufferCount();
                /*0x3a80bdc*/ bool get_needDoubleBuffering();
                /*0x3a80be4*/ void set_needDoubleBuffering(bool value);
                /*0x3a80bec*/ void OnEnable();
                /*0x3a80d24*/ void OnDisable();
                /*0x3a80e4c*/ void ForceClearBuffers();
                /*0x3a7c77c*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int id, int bufferSize);
                /*0x3a8117c*/ UnityEngine.U2D.Animation.VertexBuffer CreateBuffer(int id, int bufferSize);
                /*0x3a7b0b8*/ void ReturnBuffer(int id);
                /*0x3a81280*/ void Update();
            }

            class IconUtility
            {
                static string IconPath = "Packages/com.unity.2d.animation/Editor/Assets/ComponentIcons/";
            }

            class MeshUtilities
            {
                static /*0x3a81440*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> GetOutlineEdges(ref Unity.Collections.NativeArray<ushort> indices);
                static /*0x3a81434*/ void AddToEdgeMap(ref Unity.Mathematics.int2 edge, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, Unity.Mathematics.int3> edgeMap);
                static /*0x3a81438*/ void SortEdges(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> unsortedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> sortedEdges);
                static /*0x3a8143c*/ int GetFirstUnusedIndex(ref Unity.Collections.NativeArray<bool> usedValues);
                static /*0x3a819f8*/ void AddToEdgeMap$BurstManaged(ref Unity.Mathematics.int2 edge, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, Unity.Mathematics.int3> edgeMap);
                static /*0x3a81b28*/ void SortEdges$BurstManaged(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> unsortedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> sortedEdges);
                static /*0x3a81f2c*/ int GetFirstUnusedIndex$BurstManaged(ref Unity.Collections.NativeArray<bool> usedValues);

                class AddToEdgeMap_00000081$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x3a81f5c*/ AddToEdgeMap_00000081$PostfixBurstDelegate(object , nint );
                    /*0x3a82010*/ void Invoke(ref Unity.Mathematics.int2 edge, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, Unity.Mathematics.int3> edgeMap);
                    /*0x3a82024*/ System.IAsyncResult BeginInvoke(ref Unity.Mathematics.int2 edge, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, Unity.Mathematics.int3> edgeMap, System.AsyncCallback , object );
                    /*0x3a820e8*/ void EndInvoke(System.IAsyncResult );
                }

                class AddToEdgeMap_00000081$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;

                    static /*0x3a820f4*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x3a821e4*/ nint GetFunctionPointer();
                    static /*0x3a81800*/ void Invoke(ref Unity.Mathematics.int2 edge, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, Unity.Mathematics.int3> edgeMap);
                }

                class SortEdges_00000082$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x3a821fc*/ SortEdges_00000082$PostfixBurstDelegate(object , nint );
                    /*0x3a822b0*/ void Invoke(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> unsortedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> sortedEdges);
                    /*0x3a822c4*/ System.IAsyncResult BeginInvoke(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> unsortedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> sortedEdges, System.AsyncCallback , object );
                    /*0x3a8236c*/ void EndInvoke(System.IAsyncResult );
                }

                class SortEdges_00000082$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;

                    static /*0x3a82378*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x3a82468*/ nint GetFunctionPointer();
                    static /*0x3a818a0*/ void Invoke(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> unsortedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> sortedEdges);
                }

                class GetFirstUnusedIndex_00000083$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x3a82480*/ GetFirstUnusedIndex_00000083$PostfixBurstDelegate(object , nint );
                    /*0x3a82530*/ int Invoke(ref Unity.Collections.NativeArray<bool> usedValues);
                    /*0x3a82544*/ System.IAsyncResult BeginInvoke(ref Unity.Collections.NativeArray<bool> usedValues, System.AsyncCallback , object );
                    /*0x3a825d0*/ int EndInvoke(System.IAsyncResult );
                }

                class GetFirstUnusedIndex_00000083$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;

                    static /*0x3a825f8*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x3a826e8*/ nint GetFunctionPointer();
                    static /*0x3a81940*/ int Invoke(ref Unity.Collections.NativeArray<bool> usedValues);
                }
            }

            class NativeArrayHelpers
            {
                static /*0x1f36284*/ void ResizeIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static /*0x1f36284*/ void ResizeAndCopyIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static /*0x1ffc854*/ void DisposeIfCreated<T>(Unity.Collections.NativeArray<T> nativeArray);
                static /*0x1ffc854*/ void CopyFromNativeSlice<T, S>(Unity.Collections.NativeArray<T> nativeArray, int dstStartIndex, int dstEndIndex, Unity.Collections.NativeSlice<S> slice, int srcStartIndex, int srcEndIndex);
            }

            struct NativeCustomSlice<T>
            {
                /*0x0*/ nint data;
                /*0x0*/ int length;
                /*0x0*/ int stride;

                static /*0x1ffc854*/ UnityEngine.U2D.Animation.NativeCustomSlice<T> Default();
                /*0x1ffc854*/ NativeCustomSlice(Unity.Collections.NativeSlice<T> nativeSlice);
                /*0x1ffc854*/ NativeCustomSlice(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                /*0x1ffc854*/ T get_Item(int index);
                /*0x1f2ffc8*/ int get_Length();
            }

            struct NativeCustomSliceEnumerator<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ UnityEngine.U2D.Animation.NativeCustomSlice<T> nativeCustomSlice;
                /*0x0*/ int index;

                /*0x1ffc854*/ NativeCustomSliceEnumerator(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1f309e4*/ void Reset();
                /*0x1ffc854*/ T get_Current();
                /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                /*0x1f309e4*/ void System.IDisposable.Dispose();
            }

            class SkeletonAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.U2D.SpriteBone[] m_SpriteBones;

                /*0x3a82710*/ SkeletonAsset();
                /*0x3a82700*/ UnityEngine.U2D.SpriteBone[] GetSpriteBones();
                /*0x3a82708*/ void SetSpriteBones(UnityEngine.U2D.SpriteBone[] spriteBones);
            }

            interface ISpriteLibraryCategory
            {
                /*0x1f30214*/ string get_name();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.ISpriteLibraryLabel> get_labels();
            }

            interface ISpriteLibraryLabel
            {
                /*0x1f30214*/ string get_name();
                /*0x1f30214*/ UnityEngine.Sprite get_sprite();
            }

            class SpriteLibrary : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Library;
                /*0x28*/ UnityEngine.U2D.Animation.SpriteLibraryAsset m_SpriteLibraryAsset;
                /*0x30*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.SpriteLibrary.CategoryEntrySprite> m_CategoryEntryHashCache;
                /*0x38*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> m_CategoryEntryCache;
                /*0x40*/ int m_PreviousSpriteLibraryAsset;
                /*0x48*/ long m_PreviousModificationHash;

                static /*0x3a83414*/ int GetHashForCategoryAndEntry(string category, string entry);
                static /*0x3a83ccc*/ UnityEngine.U2D.Animation.SpriteCategoryEntry GetEntry(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> entries, string entry, bool addIfNotExist);
                /*0x3a84748*/ SpriteLibrary();
                /*0x3a82718*/ void set_spriteLibraryAsset(UnityEngine.U2D.Animation.SpriteLibraryAsset value);
                /*0x3a833e0*/ UnityEngine.U2D.Animation.SpriteLibraryAsset get_spriteLibraryAsset();
                /*0x3a833e8*/ void OnEnable();
                /*0x3a833ec*/ void OnPreviewUpdate();
                /*0x3a833f0*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x3a834c8*/ UnityEngine.Sprite GetSprite(int hash);
                /*0x3a83570*/ void UpdateCacheOverridesIfNeeded();
                /*0x3a83824*/ bool GetCategoryAndEntryNameFromHash(int hash, ref string category, ref string entry);
                /*0x3a8393c*/ UnityEngine.Sprite GetSpriteFromCategoryAndEntryHash(int hash, ref bool validEntry);
                /*0x3a83a04*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> GetEntries(string category, bool addIfNotExist);
                /*0x3a83f24*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category, string label);
                /*0x3a84068*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category);
                /*0x3a84250*/ void AddOverride(UnityEngine.Sprite sprite, string category, string label);
                /*0x3a842a8*/ void RemoveOverride(string category);
                /*0x3a843e0*/ void RemoveOverride(string category, string label);
                /*0x3a84528*/ bool HasOverride(string category, string label);
                /*0x3a8334c*/ void RefreshSpriteResolvers();
                /*0x3a84648*/ System.Collections.Generic.IEnumerable<string> get_categoryNames();
                /*0x3a846a0*/ System.Collections.Generic.IEnumerable<string> GetEntryNames(string category);
                /*0x3a827bc*/ void CacheOverrides();

                struct CategoryEntrySprite
                {
                    /*0x10*/ string category;
                    /*0x18*/ string entry;
                    /*0x20*/ UnityEngine.Sprite sprite;
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ string category;

                    /*0x3a83c1c*/ <>c__DisplayClass18_0();
                    /*0x3a847d0*/ bool <GetEntries>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ string entry;

                    /*0x3a83e74*/ <>c__DisplayClass19_0();
                    /*0x3a847f0*/ bool <GetEntry>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ int categoryHash;

                    /*0x3a84248*/ <>c__DisplayClass21_0();
                    /*0x3a84810*/ bool <AddOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ string category;

                    /*0x3a843d8*/ <>c__DisplayClass23_0();
                    /*0x3a84830*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string label;

                    /*0x3a84520*/ <>c__DisplayClass24_0();
                    /*0x3a84850*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }
            }

            interface INameHash
            {
                /*0x1f30214*/ string get_name();
                /*0x1f30ebc*/ void set_name(string value);
                /*0x1f2ffc8*/ int get_hash();
            }

            class SpriteCategoryEntry : UnityEngine.U2D.Animation.INameHash, UnityEngine.U2D.Animation.ISpriteLibraryLabel
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ UnityEngine.Sprite m_Sprite;

                /*0x3a83e7c*/ SpriteCategoryEntry();
                /*0x3a84870*/ string get_name();
                /*0x3a83e84*/ void set_name(string value);
                /*0x3a84878*/ int get_hash();
                /*0x3a84880*/ UnityEngine.Sprite get_sprite();
                /*0x3a84888*/ void set_sprite(UnityEngine.Sprite value);
                /*0x3a84890*/ void UpdateHash();
            }

            class SpriteLibCategory : UnityEngine.U2D.Animation.INameHash, UnityEngine.U2D.Animation.ISpriteLibraryCategory
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> m_CategoryList;

                /*0x3a83c24*/ SpriteLibCategory();
                /*0x3a8491c*/ string get_name();
                /*0x3a83c2c*/ void set_name(string value);
                /*0x3a84924*/ int get_hash();
                /*0x3a8492c*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> get_categoryList();
                /*0x3a84934*/ void set_categoryList(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> value);
                /*0x3a8493c*/ System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.ISpriteLibraryLabel> get_labels();
                /*0x3a84944*/ void UpdateHash();
                /*0x3a84b40*/ void ValidateLabels(bool log);

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ bool log;

                    /*0x3a84c00*/ <>c__DisplayClass14_0();
                    /*0x3a85118*/ void <ValidateLabels>b__0(string originalName, string newName);
                }
            }

            class SpriteLibraryAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Labels;
                /*0x20*/ long m_ModificationHash;
                /*0x28*/ int m_Version;

                static /*0x3a851c8*/ UnityEngine.U2D.Animation.SpriteLibraryAsset CreateAsset(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> categories, string assetName, long modificationHash);
                static /*0x3a84c08*/ void RenameDuplicate(System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.INameHash> nameHashList, System.Action<string, string> onRename);
                /*0x3a86358*/ SpriteLibraryAsset();
                /*0x3a85534*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> get_categories();
                /*0x3a8553c*/ void set_categories(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> value);
                /*0x3a8555c*/ long get_modificationHash();
                /*0x3a85564*/ void set_modificationHash(long value);
                /*0x3a8556c*/ void set_version(int value);
                /*0x3a85574*/ void OnEnable();
                /*0x3a855a0*/ void UpdateToVersionOne();
                /*0x3a855bc*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash);
                /*0x3a8573c*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash, ref bool validEntry);
                /*0x3a83f98*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x3a858b4*/ System.Collections.Generic.IEnumerable<string> GetCategoryNames();
                /*0x3a859b0*/ System.Collections.Generic.IEnumerable<string> GetCategorylabelNames(string category);
                /*0x3a859b4*/ System.Collections.Generic.IEnumerable<string> GetCategoryLabelNames(string category);
                /*0x3a85ba4*/ void AddCategoryLabel(UnityEngine.Sprite sprite, string category, string label);
                /*0x3a86034*/ void RemoveCategoryLabel(string category, string label, bool deleteCategory);
                /*0x3a85394*/ void UpdateHashes();
                /*0x3a8526c*/ void ValidateCategories(bool log);

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.U2D.Animation.SpriteLibCategory, string> <>9__17_0;
                    static /*0x10*/ System.Func<UnityEngine.U2D.Animation.SpriteCategoryEntry, string> <>9__19_1;

                    static /*0x3a863e0*/ <>c();
                    /*0x3a86448*/ <>c();
                    /*0x3a86450*/ string <GetCategoryNames>b__17_0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x3a86464*/ string <GetCategoryLabelNames>b__19_1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ int categoryHash;
                    /*0x14*/ int labelHash;

                    /*0x3a85734*/ <>c__DisplayClass14_0();
                    /*0x3a86478*/ bool <GetSprite>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x3a86498*/ bool <GetSprite>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ string category;

                    /*0x3a85b9c*/ <>c__DisplayClass19_0();
                    /*0x3a864b8*/ bool <GetCategoryLabelNames>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ int catHash;

                    /*0x3a86024*/ <>c__DisplayClass20_0();
                    /*0x3a864d8*/ bool <AddCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass20_1
                {
                    /*0x10*/ int labelHash;

                    /*0x3a8602c*/ <>c__DisplayClass20_1();
                    /*0x3a864f8*/ bool <AddCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry y);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ int catHash;
                    /*0x18*/ UnityEngine.U2D.Animation.SpriteLibCategory libCategory;

                    /*0x3a86328*/ <>c__DisplayClass21_0();
                    /*0x3a86518*/ bool <RemoveCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x3a86538*/ bool <RemoveCategoryLabel>b__2(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass21_1
                {
                    /*0x10*/ int labelHash;

                    /*0x3a86330*/ <>c__DisplayClass21_1();
                    /*0x3a86564*/ bool <RemoveCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ bool log;

                    /*0x3a86338*/ <>c__DisplayClass23_0();
                    /*0x3a86584*/ void <ValidateCategories>b__0(string originalName, string newName);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash category;

                    /*0x3a86340*/ <>c__DisplayClass24_0();
                    /*0x3a8671c*/ bool <RenameDuplicate>b__0(UnityEngine.U2D.Animation.INameHash x);
                }

                class <>c__DisplayClass24_1
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash categoryClash;

                    /*0x3a86348*/ <>c__DisplayClass24_1();
                }

                class <>c__DisplayClass24_2
                {
                    /*0x10*/ int nameHash;
                    /*0x18*/ string name;
                    /*0x20*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> CS$<>8__locals1;

                    /*0x3a86350*/ <>c__DisplayClass24_2();
                    /*0x3a86920*/ bool <RenameDuplicate>b__1(UnityEngine.U2D.Animation.INameHash x);
                }
            }

            class SpriteCategoryEntryOverride : UnityEngine.U2D.Animation.SpriteCategoryEntry
            {
                /*0x28*/ bool m_FromMain;
                /*0x30*/ UnityEngine.Sprite m_SpriteOverride;

                /*0x3a86a78*/ SpriteCategoryEntryOverride();
                /*0x3a86a58*/ bool get_fromMain();
                /*0x3a86a60*/ void set_fromMain(bool value);
                /*0x3a86a68*/ UnityEngine.Sprite get_spriteOverride();
                /*0x3a86a70*/ void set_spriteOverride(UnityEngine.Sprite value);
            }

            class SpriteLibCategoryOverride : UnityEngine.U2D.Animation.SpriteLibCategory
            {
                /*0x28*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> m_OverrideEntries;
                /*0x30*/ bool m_FromMain;
                /*0x34*/ int m_EntryOverrideCount;

                /*0x3a86df4*/ SpriteLibCategoryOverride();
                /*0x3a86a80*/ bool get_fromMain();
                /*0x3a86a88*/ void set_fromMain(bool value);
                /*0x3a86a90*/ int get_entryOverrideCount();
                /*0x3a86a98*/ void set_entryOverrideCount(int value);
                /*0x3a86aa0*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> get_overrideEntries();
                /*0x3a86aa8*/ void set_overrideEntries(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> value);
                /*0x3a86ab0*/ void UpdateOverrideCount();
                /*0x3a86cfc*/ void RenameDuplicateOverrideEntries();

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibCategoryOverride.<> <>9;
                    static /*0x8*/ System.Action<string, string> <>9__13_0;

                    static /*0x3a86dfc*/ <>c();
                    /*0x3a86e64*/ <>c();
                    /*0x3a86e6c*/ void <RenameDuplicateOverrideEntries>b__13_0(string _, string _);
                }
            }

            class SpriteLibrarySourceAsset : UnityEngine.ScriptableObject
            {
                static string defaultName = "New Sprite Library Asset";
                static string extension = ".spriteLib";
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> m_Library;
                /*0x20*/ string m_PrimaryLibraryGUID;
                /*0x28*/ long m_ModificationHash;
                /*0x30*/ int m_Version;

                /*0x3a87360*/ SpriteLibrarySourceAsset();
                /*0x3a86e70*/ System.Collections.Generic.IReadOnlyList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> get_library();
                /*0x3a86e78*/ string get_primaryLibraryGUID();
                /*0x3a86e80*/ long get_modificationHash();
                /*0x3a86e88*/ int get_version();
                /*0x3a86e90*/ void InitializeWithAsset(UnityEngine.U2D.Animation.SpriteLibrarySourceAsset source);
                /*0x3a86f3c*/ void SetLibrary(System.Collections.Generic.IList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> newLibrary);
                /*0x3a87054*/ void SetPrimaryLibraryGUID(string newPrimaryLibraryGUID);
                /*0x3a870a4*/ void AddCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride newCategory);
                /*0x3a8713c*/ void RemoveCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride categoryToRemove);
                /*0x3a871d4*/ void ClearCategories();
                /*0x3a87270*/ void RemoveCategory(int indexToRemove);
                /*0x3a86ffc*/ void UpdateModificationHash();
            }

            class SpriteLibraryUtility
            {
                static /*0x0*/ System.Func<string, int> GetStringHash;

                static /*0x3a874b4*/ SpriteLibraryUtility();
                static /*0x3a873f0*/ int Convert32BitTo30BitHash(int input);
                static /*0x3a8744c*/ int Bit30Hash_GetStringHash(string value);
                static /*0x3a87444*/ int PreserveFirst30Bits(int input);
                static /*0x3a872f8*/ long GenerateHash();
            }

            class SpriteResolver : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ float m_CategoryHash;
                /*0x24*/ float m_labelHash;
                /*0x28*/ float m_SpriteKey;
                /*0x2c*/ int m_SpriteHash;
                /*0x30*/ int m_CategoryHashInt;
                /*0x34*/ int m_LabelHashInt;
                /*0x38*/ int m_PreviousCategoryHash;
                /*0x3c*/ int m_PreviousLabelHash;
                /*0x40*/ int m_PreviousSpriteKeyInt;
                /*0x44*/ int m_PreviousSpriteHash;

                static /*0x3a886d4*/ bool IsInGUIUpdateLoop();
                static /*0x3a87ed4*/ int ConvertCategoryLabelHashToSpriteKey(UnityEngine.U2D.Animation.SpriteLibrary library, int categoryHash, int labelHash);
                /*0x3a88934*/ SpriteResolver();
                /*0x3a87554*/ void Reset();
                /*0x3a8764c*/ void SetSprite(UnityEngine.Sprite sprite);
                /*0x3a87c98*/ void OnEnable();
                /*0x3a87cb0*/ void InitializeSerializedData();
                /*0x3a875f0*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x3a88514*/ bool SetCategoryAndLabel(string category, string label);
                /*0x3a88540*/ string GetCategory();
                /*0x3a88608*/ string GetLabel();
                /*0x3a87c30*/ UnityEngine.U2D.Animation.SpriteLibrary get_spriteLibrary();
                /*0x3a886d0*/ void OnPreviewUpdate();
                /*0x3a886f0*/ void LateUpdate();
                /*0x3a886f4*/ void ResolveUpdatedValue();
                /*0x3a88884*/ UnityEngine.Sprite GetSprite(ref bool validEntry);
                /*0x3a84558*/ bool ResolveSpriteToSpriteRenderer();
                /*0x3a88930*/ void OnTransformParentChanged();
            }

            struct PositionVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
            }

            struct PositionTangentVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector4 tangent;
            }

            enum SpriteSkinState
            {
                SpriteNotFound = 0,
                SpriteHasNoSkinningInformation = 1,
                SpriteHasNoWeights = 2,
                RootTransformNotFound = 3,
                InvalidTransformArray = 4,
                InvalidTransformArrayLength = 5,
                TransformArrayContainsNull = 6,
                InvalidBoneWeights = 7,
                Ready = 8,
            }

            class SpriteSkin : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x20*/ UnityEngine.Transform m_RootBone;
                /*0x28*/ UnityEngine.Transform[] m_BoneTransforms;
                /*0x30*/ UnityEngine.Bounds m_Bounds;
                /*0x48*/ bool m_AlwaysUpdate;
                /*0x49*/ bool m_AutoRebind;
                /*0x50*/ UnityEngine.U2D.Animation.NativeByteArray m_DeformedVertices;
                /*0x58*/ int m_CurrentDeformVerticesLength;
                /*0x60*/ UnityEngine.SpriteRenderer m_SpriteRenderer;
                /*0x68*/ int m_CurrentDeformSprite;
                /*0x6c*/ int m_SpriteId;
                /*0x70*/ bool m_IsValid;
                /*0x74*/ UnityEngine.U2D.Animation.SpriteSkinState m_State;
                /*0x78*/ int m_TransformsHash;
                /*0x7c*/ bool m_ForceCpuDeformation;
                /*0x80*/ int m_TransformId;
                /*0x88*/ Unity.Collections.NativeArray<int> m_BoneTransformId;
                /*0x98*/ int m_RootBoneTransformId;
                /*0xa0*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector2> m_SpriteUVs;
                /*0xb0*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector3> m_SpriteVertices;
                /*0xc0*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector4> m_SpriteTangents;
                /*0xd0*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> m_SpriteBoneWeights;
                /*0xe0*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Matrix4x4> m_SpriteBindPoses;
                /*0xf0*/ UnityEngine.U2D.Animation.NativeCustomSlice<int> m_BoneTransformIdNativeSlice;
                /*0x100*/ bool m_SpriteHasTangents;
                /*0x104*/ int m_SpriteVertexStreamSize;
                /*0x108*/ int m_SpriteVertexCount;
                /*0x10c*/ int m_SpriteTangentVertexOffset;
                /*0x110*/ int m_DataIndex;
                /*0x114*/ bool m_BoneCacheUpdateToDate;
                /*0x118*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> hierarchyCache;
                /*0x120*/ Unity.Collections.NativeArray<int> m_OutlineIndexCache;
                /*0x130*/ Unity.Collections.NativeArray<UnityEngine.Vector3> m_StaticOutlineVertexCache;
                /*0x140*/ Unity.Collections.NativeArray<UnityEngine.Vector3> m_DeformedOutlineVertexCache;
                /*0x150*/ int m_VertexDeformationHash;
                /*0x158*/ UnityEngine.Sprite m_Sprite;
                /*0x160*/ UnityEngine.U2D.Animation.DeformationMethods <currentDeformationMethod>k__BackingField;
                /*0x168*/ UnityEngine.U2D.Animation.BaseDeformationSystem <deformationSystem>k__BackingField;

                static /*0x3a8b31c*/ bool IsInGUIUpdateLoop();
                static /*0x3a8c2e0*/ int CountChildren(UnityEngine.Transform transform);
                static /*0x3a8b6c8*/ int GetNewVertexDeformationHash();
                /*0x3a8c67c*/ SpriteSkin();
                /*0x3a8893c*/ Unity.Collections.NativeArray<int> get_boneTransformId();
                /*0x3a88948*/ int get_rootBoneTransformId();
                /*0x3a88950*/ UnityEngine.U2D.Animation.DeformationMethods get_currentDeformationMethod();
                /*0x3a88958*/ void set_currentDeformationMethod(UnityEngine.U2D.Animation.DeformationMethods value);
                /*0x3a88960*/ UnityEngine.U2D.Animation.BaseDeformationSystem get_deformationSystem();
                /*0x3a88968*/ void set_deformationSystem(UnityEngine.U2D.Animation.BaseDeformationSystem value);
                /*0x3a88978*/ Unity.Collections.NativeArray<int> get_outlineIndices();
                /*0x3a88984*/ Unity.Collections.NativeArray<UnityEngine.Vector3> get_outlineVertices();
                /*0x3a88990*/ int get_vertexDeformationHash();
                /*0x3a88998*/ UnityEngine.Sprite get_sprite();
                /*0x3a889a0*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x3a889a8*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> get_spriteBoneWeights();
                /*0x3a889b4*/ int get_dataIndex();
                /*0x3a889bc*/ void SetDataIndex(int index);
                /*0x3a889c4*/ bool get_autoRebind();
                /*0x3a889cc*/ void set_autoRebind(bool value);
                /*0x3a893d8*/ UnityEngine.Transform[] get_boneTransforms();
                /*0x3a893e0*/ UnityEngine.U2D.Animation.SpriteSkinState SetBoneTransforms(UnityEngine.Transform[] boneTransformsArray);
                /*0x3a89454*/ UnityEngine.Transform get_rootBone();
                /*0x3a8945c*/ UnityEngine.U2D.Animation.SpriteSkinState SetRootBone(UnityEngine.Transform rootBoneTransform);
                /*0x3a894f4*/ UnityEngine.Bounds get_bounds();
                /*0x3a89508*/ void set_bounds(UnityEngine.Bounds value);
                /*0x3a8951c*/ bool get_alwaysUpdate();
                /*0x3a89524*/ void set_alwaysUpdate(bool value);
                /*0x3a8952c*/ bool get_forceCpuDeformation();
                /*0x3a89534*/ void set_forceCpuDeformation(bool value);
                /*0x3a89a08*/ bool ResetBindPose();
                /*0x3a89b78*/ bool get_isValid();
                /*0x3a89d14*/ void Awake();
                /*0x3a89dfc*/ void OnEnable();
                /*0x3a8a13c*/ void OnDisable();
                /*0x3a89f3c*/ void RefreshBoneTransforms();
                /*0x3a8a928*/ void OnSpriteChanged(UnityEngine.SpriteRenderer updatedSpriteRenderer);
                /*0x3a8a480*/ void CacheBoneTransformIds();
                /*0x3a89420*/ void OnBoneTransformChanged();
                /*0x3a8aa40*/ void OnBeforeSerialize();
                /*0x3a8aa48*/ void OnAfterDeserialize();
                /*0x3a8aa44*/ void OnBeforeSerializeBatch();
                /*0x3a8aa4c*/ void OnAfterSerializeBatch();
                /*0x3a8aa50*/ void OnEditorEnable();
                /*0x3a893a4*/ UnityEngine.U2D.Animation.SpriteSkinState CacheValidFlag();
                /*0x3a7b83c*/ bool BatchValidate();
                /*0x3a8aa54*/ void Reset();
                /*0x3a8aaa4*/ void ResetBoneTransformIdCache();
                /*0x3a8ab00*/ UnityEngine.U2D.Animation.NativeByteArray GetDeformedVertices(int spriteVertexCount);
                /*0x3a8abd0*/ bool HasCurrentDeformedVertices();
                /*0x3a8ac04*/ Unity.Collections.NativeArray<byte> GetCurrentDeformedVertices();
                /*0x3a8ad04*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionVertex> GetCurrentDeformedVertexPositions();
                /*0x3a8ae40*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents();
                /*0x3a8af7c*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector3> GetDeformedVertexPositionData();
                /*0x3a8b19c*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector4> GetDeformedVertexTangentData();
                /*0x3a8a3f4*/ void DisposeOutlineCaches();
                /*0x3a8b318*/ void OnPreviewUpdate();
                /*0x3a8b338*/ void Deform();
                /*0x3a7c758*/ void PostDeform(bool didDeform);
                /*0x3a89080*/ void CacheCurrentSprite(bool rebind);
                /*0x3a89580*/ void UpdateSpriteDeformationData();
                /*0x3a8ba44*/ void UpdateDeformedOutlineCache();
                /*0x3a8bfb8*/ void CacheSpriteOutline();
                /*0x3a8c060*/ void CacheOutlineIndices(ref int maxIndex);
                /*0x3a8c1a0*/ void CacheOutlineVertices(int cacheSize);
                /*0x3a79508*/ void CopyToSpriteSkinData(ref UnityEngine.U2D.Animation.SpriteSkinData data);
                /*0x3a7b8bc*/ bool NeedToUpdateDeformationCache();
                /*0x3a88a74*/ void CacheHierarchy();
                /*0x3a8a274*/ void DeactivateSkinning();
                /*0x3a8c674*/ void ResetSprite();
                /*0x3a7e6c0*/ void SetDeformationSystem(UnityEngine.U2D.Animation.BaseDeformationSystem newDeformationSystem);

                class Profiling
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker cacheCurrentSprite;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker cacheHierarchy;
                    static /*0x10*/ Unity.Profiling.ProfilerMarker getSpriteBonesTransformFromGuid;
                    static /*0x18*/ Unity.Profiling.ProfilerMarker getSpriteBonesTransformFromPath;

                    static /*0x3a8c784*/ Profiling();
                }

                struct TransformData
                {
                    /*0x10*/ string fullName;
                    /*0x18*/ UnityEngine.Transform transform;
                }
            }

            class SpriteSkinContainer : UnityEngine.ScriptableObject
            {
                static /*0x0*/ System.Action<UnityEngine.U2D.Animation.SpriteSkin> onAddedSpriteSkin;
                static /*0x8*/ System.Action<UnityEngine.U2D.Animation.SpriteSkin> onRemovedSpriteSkin;
                static /*0x10*/ System.Action<UnityEngine.U2D.Animation.SpriteSkin> onBoneTransformChanged;
                static /*0x18*/ UnityEngine.U2D.Animation.SpriteSkinContainer s_Instance;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkin;

                static /*0x3a8c8bc*/ void add_onAddedSpriteSkin(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a8c988*/ void remove_onAddedSpriteSkin(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a8ca54*/ void add_onRemovedSpriteSkin(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a8cb24*/ void remove_onRemovedSpriteSkin(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a8cbf4*/ void add_onBoneTransformChanged(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a8ccc4*/ void remove_onBoneTransformChanged(System.Action<UnityEngine.U2D.Animation.SpriteSkin> value);
                static /*0x3a89f7c*/ UnityEngine.U2D.Animation.SpriteSkinContainer get_instance();
                /*0x3a8cd9c*/ SpriteSkinContainer();
                /*0x3a8cd94*/ System.Collections.Generic.IReadOnlyList<UnityEngine.U2D.Animation.SpriteSkin> get_spriteSkins();
                /*0x3a8a0a0*/ void AddSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a8a358*/ void RemoveSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x3a8a9d4*/ void BoneTransformsChanged(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
            }

            class SpriteSkinHelpers
            {
                static /*0x3a8c354*/ void CacheChildren(UnityEngine.Transform current, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> cache);
                static /*0x3a8c540*/ string GenerateTransformPath(UnityEngine.Transform rootBone, UnityEngine.Transform child);
                static /*0x3a8bb40*/ bool GetSpriteBonesTransforms(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, ref UnityEngine.Transform[] outTransform);
                static /*0x3a8ce2c*/ bool GetSpriteBonesTransformFromPath(UnityEngine.U2D.SpriteBone[] spriteBones, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> hierarchyCache, UnityEngine.Transform[] outNewBoneTransform);
                static /*0x3a8d2d0*/ void CalculateBoneTransformsPath(int index, UnityEngine.U2D.SpriteBone[] spriteBones, string[] paths);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string boneHash;

                    /*0x3a8ce24*/ <>c__DisplayClass2_0();
                    /*0x3a8d42c*/ bool <GetSpriteBonesTransforms>b__0(UnityEngine.U2D.Animation.Bone x);
                }
            }

            class NativeByteArray
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> <array>k__BackingField;

                /*0x3a805a8*/ NativeByteArray(Unity.Collections.NativeArray<byte> array);
                /*0x3a8071c*/ int get_Length();
                /*0x3a80988*/ bool get_IsCreated();
                /*0x3a8d44c*/ byte get_Item(int index);
                /*0x3a8d458*/ Unity.Collections.NativeArray<byte> get_array();
                /*0x3a80844*/ void Dispose();
            }

            class SpriteSkinUtility
            {
                static /*0x3a7d9ec*/ bool CanUseGpuDeformation();
                static /*0x3a7d9f4*/ bool IsUsingGpuDeformation();
                static /*0x3a7e668*/ bool CanSpriteSkinUseGpuDeformation(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x3a89b90*/ UnityEngine.U2D.Animation.SpriteSkinState Validate(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x3a8d468*/ void CreateBoneHierarchy(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x3a8b678*/ int GetVertexStreamSize(UnityEngine.Sprite sprite);
                static /*0x3a8b0f8*/ int GetVertexStreamOffset(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
                static /*0x3a8d64c*/ void CreateGameObject(int index, UnityEngine.U2D.SpriteBone[] spriteBones, UnityEngine.Transform[] transforms, UnityEngine.Transform root);
                static /*0x3a8d8c0*/ int GetHash(UnityEngine.Matrix4x4 matrix);
                static /*0x3a8b574*/ int CalculateTransformHash(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x3a8d8d0*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 rootInv, Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> boneTransforms, Unity.Collections.NativeSlice<UnityEngine.Matrix4x4> bindPoses, Unity.Collections.NativeArray<byte> deformableVertices);
                static /*0x3a8e5c8*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed);
                static /*0x3a8dbec*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<Unity.Mathematics.float4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed, Unity.Collections.NativeSlice<Unity.Mathematics.float4> deformedTangents);
                static /*0x3a8b6d0*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 invRoot, UnityEngine.Transform[] boneTransformsArray, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x3a8eb1c*/ void Bake(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x3a8ec18*/ void CalculateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x3a7d308*/ UnityEngine.Bounds CalculateSpriteSkinBounds(Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformablePositions);
                static /*0x3a8b924*/ void UpdateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformedVertices);
            }

            class BurstedSpriteSkinUtilities
            {
                static /*0x3a8d464*/ bool ValidateBoneWeights(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                static /*0x3a8c05c*/ void SetVertexPositionFromByteBuffer(ref Unity.Collections.NativeArray<byte> buffer, ref Unity.Collections.NativeArray<int> indices, ref Unity.Collections.NativeArray<UnityEngine.Vector3> vertices, int stride);
                static /*0x3a8ef7c*/ bool ValidateBoneWeights$BurstManaged(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                static /*0x3a8f0c0*/ void SetVertexPositionFromByteBuffer$BurstManaged(ref Unity.Collections.NativeArray<byte> buffer, ref Unity.Collections.NativeArray<int> indices, ref Unity.Collections.NativeArray<UnityEngine.Vector3> vertices, int stride);

                class ValidateBoneWeights_000001A7$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x3a8f174*/ ValidateBoneWeights_000001A7$PostfixBurstDelegate(object , nint );
                    /*0x3a8f228*/ bool Invoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                    /*0x3a8f23c*/ System.IAsyncResult BeginInvoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount, System.AsyncCallback , object );
                    /*0x3a8f2ec*/ bool EndInvoke(System.IAsyncResult );
                }

                class ValidateBoneWeights_000001A7$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;

                    static /*0x3a8f314*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x3a8f404*/ nint GetFunctionPointer();
                    static /*0x3a8edac*/ bool Invoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                }

                class SetVertexPositionFromByteBuffer_000001A8$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x3a8f41c*/ SetVertexPositionFromByteBuffer_000001A8$PostfixBurstDelegate(object , nint );
                    /*0x3a8f4d0*/ void Invoke(ref Unity.Collections.NativeArray<byte> buffer, ref Unity.Collections.NativeArray<int> indices, ref Unity.Collections.NativeArray<UnityEngine.Vector3> vertices, int stride);
                    /*0x3a8f4e4*/ System.IAsyncResult BeginInvoke(ref Unity.Collections.NativeArray<byte> buffer, ref Unity.Collections.NativeArray<int> indices, ref Unity.Collections.NativeArray<UnityEngine.Vector3> vertices, int stride, System.AsyncCallback , object );
                    /*0x3a8f600*/ void EndInvoke(System.IAsyncResult );
                }

                class SetVertexPositionFromByteBuffer_000001A8$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;

                    static /*0x3a8f60c*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x3a8f6fc*/ nint GetFunctionPointer();
                    static /*0x3a8ee4c*/ void Invoke(ref Unity.Collections.NativeArray<byte> buffer, ref Unity.Collections.NativeArray<int> indices, ref Unity.Collections.NativeArray<UnityEngine.Vector3> vertices, int stride);
                }
            }

            class UpdateOrder
            {
                static int spriteResolverUpdateOrder = -20;
                static int ikUpdateOrder = -10;
                static int spriteSkinUpdateOrder = 10;
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> CD9453CE9DA4A675A3BE1450D19406F93ADEB9AABA50D0363F06682AE15CD674;
    static /*0xa81*/ <PrivateImplementationDetails> DF28BB77BD7F6C02785219DD7DD5BBEB28DB281FB4E39F1A367CC4C929E6DE7B;

    struct __StaticArrayInitTypeSize=2689
    {
    }

    struct __StaticArrayInitTypeSize=2849
    {
    }
}

class __JobReflectionRegistrationOutput__12640072059193112690
{
    static /*0x3a8f714*/ void CreateJobReflectionData();
    static /*0x3a8f8f0*/ void EarlyInit();
}

class $BurstDirectCallInitializer
{
    static /*0x3a8f8f4*/ void Initialize();
}
