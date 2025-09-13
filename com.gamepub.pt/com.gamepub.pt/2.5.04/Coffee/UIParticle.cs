class <Module>
{
}

namespace Coffee
{
    namespace UIParticleExtensions
    {
        class BakingCamera : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ Coffee.UIParticleExtensions.BakingCamera s_Instance;
            static /*0x8*/ UnityEngine.Vector3 s_OrthoPosition;
            static /*0x14*/ UnityEngine.Quaternion s_OrthoRotation;
            /*0x18*/ UnityEngine.Camera _camera;

            static /*0x2a6d33c*/ BakingCamera();
            static /*0x2a6cd24*/ Coffee.UIParticleExtensions.BakingCamera get_Instance();
            static /*0x2a6ce18*/ Coffee.UIParticleExtensions.BakingCamera Create();
            static /*0x2a6d06c*/ UnityEngine.Camera GetCamera(UnityEngine.Canvas canvas);
            /*0x2a6d334*/ BakingCamera();
            /*0x2a6cf74*/ void Awake();
        }

        class CombineInstanceEx
        {
            /*0x10*/ int count;
            /*0x18*/ long hash;
            /*0x20*/ int index;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.CombineInstance> combineInstances;
            /*0x30*/ UnityEngine.Mesh mesh;
            /*0x38*/ UnityEngine.Matrix4x4 transform;

            /*0x2a6e200*/ CombineInstanceEx();
            /*0x2a6d940*/ void Combine();
            /*0x2a6ddb0*/ void Clear();
            /*0x2a6e10c*/ void Push(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 transform);
        }

        class MeshHelper
        {
            static /*0x0*/ System.Collections.Generic.List<bool> <activeMeshIndices>k__BackingField;
            static /*0x8*/ System.Collections.Generic.List<Coffee.UIParticleExtensions.CombineInstanceEx> s_CachedInstance;
            static /*0x10*/ int count;

            static /*0x2a6e5d4*/ MeshHelper();
            static /*0x2a6e428*/ System.Collections.Generic.List<bool> get_activeMeshIndices();
            static /*0x2a6e48c*/ void set_activeMeshIndices(System.Collections.Generic.List<bool> value);
            static /*0x2a6e4f4*/ void Init();
            static /*0x2a6e6f8*/ Coffee.UIParticleExtensions.CombineInstanceEx Get(int index, long hash);
            static /*0x2a6e97c*/ UnityEngine.Mesh GetTemporaryMesh();
            static /*0x2a6e9d4*/ void Push(int index, long hash, UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 transform);
            static /*0x2a6ebb0*/ void Clear();
            static /*0x2a6ed60*/ void CombineMesh(UnityEngine.Mesh result);
            static /*0x2a6eb50*/ void DiscardTemporaryMesh(UnityEngine.Mesh mesh);
        }

        class ModifiedMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIParticleExtensions.ModifiedMaterial.MatEntry> s_Entries;

            static /*0x2a6f628*/ ModifiedMaterial();
            static /*0x2a6f0b8*/ UnityEngine.Material Add(UnityEngine.Material baseMat, UnityEngine.Texture texture, int id);
            static /*0x2a6f36c*/ void Remove(UnityEngine.Material customMat);
            static /*0x2a6f550*/ void DestroyImmediate(UnityEngine.Object obj);
            /*0x2a6f620*/ ModifiedMaterial();

            class MatEntry
            {
                /*0x10*/ UnityEngine.Material baseMat;
                /*0x18*/ UnityEngine.Material customMat;
                /*0x20*/ int count;
                /*0x28*/ UnityEngine.Texture texture;
                /*0x30*/ int id;

                /*0x2a6f364*/ MatEntry();
            }
        }

        class SpriteExtensions
        {
            static /*0x2a6fbf0*/ UnityEngine.Texture2D GetActualTexture(UnityEngine.Sprite self);
        }

        class ListExtensions
        {
            static /*0x2a6e28c*/ bool SequenceEqualFast(System.Collections.Generic.List<bool> self, System.Collections.Generic.List<bool> value);
            static /*0x2a6e380*/ int CountFast(System.Collections.Generic.List<bool> self);
            static bool AnyFast<T>(System.Collections.Generic.List<T> self);
            static bool AnyFast<T>(System.Collections.Generic.List<T> self, System.Predicate<T> predicate);
        }

        class MeshExtensions
        {
            static /*0x2a6dcc4*/ void Clear(UnityEngine.CombineInstance[] self);
        }

        class MeshPool
        {
            static /*0x0*/ System.Collections.Generic.Stack<UnityEngine.Mesh> s_Pool;
            static /*0x8*/ System.Collections.Generic.HashSet<int> s_HashPool;

            static /*0x2a6ef10*/ MeshPool();
            static /*0x2a6ef0c*/ void Init();
            static /*0x2a6db1c*/ UnityEngine.Mesh Rent();
            static /*0x2a6df88*/ void Return(UnityEngine.Mesh mesh);
        }

        class CombineInstanceArrayPool
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.CombineInstance[]> s_Pool;

            static /*0x2a6d42c*/ CombineInstanceArrayPool();
            static /*0x2a6d3a8*/ void Init();
            static /*0x2a6d4b4*/ UnityEngine.CombineInstance[] Get(System.Collections.Generic.List<UnityEngine.CombineInstance> src);
            static /*0x2a6d718*/ UnityEngine.CombineInstance[] Get(System.Collections.Generic.List<Coffee.UIParticleExtensions.CombineInstanceEx> src, int count);
        }

        class ParticleSystemExtensions
        {
            static /*0x2a6f6b0*/ void SortForRendering(System.Collections.Generic.List<UnityEngine.ParticleSystem> self, UnityEngine.Transform transform, bool sortByMaterial);
            static /*0x2a6f7b4*/ int GetIndex(System.Collections.Generic.IList<UnityEngine.ParticleSystem> list, UnityEngine.Object ps);
            static /*0x2a6f930*/ long GetMaterialHash(UnityEngine.ParticleSystem self, bool trail);
            static /*0x2a6faa8*/ UnityEngine.Texture2D GetTextureForSprite(UnityEngine.ParticleSystem self);
            static /*0x2a6fc7c*/ void Exec(System.Collections.Generic.List<UnityEngine.ParticleSystem> self, System.Action<UnityEngine.ParticleSystem> action);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Transform transform;
                /*0x18*/ bool sortByMaterial;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> self;

                /*0x2a6f7ac*/ <>c__DisplayClass0_0();
                /*0x2a7440c*/ int <SortForRendering>b__0(UnityEngine.ParticleSystem a, UnityEngine.ParticleSystem b);
            }

            class <>c
            {
                static /*0x0*/ Coffee.UIParticleExtensions.ParticleSystemExtensions.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.ParticleSystem> <>9__4_0;

                static /*0x2a74334*/ <>c();
                /*0x2a74394*/ <>c();
                /*0x2a7439c*/ bool <Exec>b__4_0(UnityEngine.ParticleSystem p);
            }
        }
    }

    namespace UIExtensions
    {
        class AnimatableProperty : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ string m_Name;
            /*0x18*/ Coffee.UIExtensions.AnimatableProperty.ShaderPropertyType m_Type;
            /*0x1c*/ int <id>k__BackingField;

            /*0x2a6ccc8*/ AnimatableProperty();
            /*0x2a6ca58*/ int get_id();
            /*0x2a6ca60*/ void set_id(int value);
            /*0x2a6ca68*/ Coffee.UIExtensions.AnimatableProperty.ShaderPropertyType get_type();
            /*0x2a6ca70*/ void UpdateMaterialProperties(UnityEngine.Material material, UnityEngine.MaterialPropertyBlock mpb);
            /*0x2a6cc98*/ void OnBeforeSerialize();
            /*0x2a6cc9c*/ void OnAfterDeserialize();

            enum ShaderPropertyType
            {
                Color = 0,
                Vector = 1,
                Float = 2,
                Range = 3,
                Texture = 4,
            }
        }

        class UIParticle : UnityEngine.UI.MaskableGraphic
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Material> s_TempMaterials;
            static /*0x8*/ UnityEngine.MaterialPropertyBlock s_Mpb;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Material> s_PrevMaskMaterials;
            static /*0x18*/ System.Collections.Generic.List<UnityEngine.Material> s_PrevModifiedMaterials;
            static /*0x20*/ System.Collections.Generic.List<UnityEngine.Component> s_Components;
            static /*0x28*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> s_ParticleSystems;
            /*0xd0*/ bool m_IsTrail;
            /*0xd1*/ bool m_IgnoreCanvasScaler;
            /*0xd4*/ float m_Scale;
            /*0xd8*/ UnityEngine.Vector3 m_Scale3D;
            /*0xe8*/ Coffee.UIExtensions.AnimatableProperty[] m_AnimatableProperties;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> m_Particles;
            /*0xf8*/ bool m_ShrinkByMaterial;
            /*0xf9*/ bool _shouldBeRemoved;
            /*0xfa*/ UnityEngine.DrivenRectTransformTracker _tracker;
            /*0x100*/ UnityEngine.Mesh _bakedMesh;
            /*0x108*/ System.Collections.Generic.List<UnityEngine.Material> _modifiedMaterials;
            /*0x110*/ System.Collections.Generic.List<UnityEngine.Material> _maskMaterials;
            /*0x118*/ System.Collections.Generic.List<bool> _activeMeshIndices;
            /*0x120*/ UnityEngine.Vector3 _cachedPosition;

            static /*0x2a726fc*/ UIParticle();
            /*0x2a725b0*/ UIParticle();
            /*0x2a6fdcc*/ bool get_raycastTarget();
            /*0x2a6fdd4*/ void set_raycastTarget(bool value);
            /*0x2a6fdd8*/ bool get_ignoreCanvasScaler();
            /*0x2a6fde0*/ void set_ignoreCanvasScaler(bool value);
            /*0x2a6fe58*/ bool get_shrinkByMaterial();
            /*0x2a6fe60*/ void set_shrinkByMaterial(bool value);
            /*0x2a6fed8*/ float get_scale();
            /*0x2a6fee0*/ void set_scale(float value);
            /*0x2a6ff18*/ UnityEngine.Vector3 get_scale3D();
            /*0x2a6ff24*/ void set_scale3D(UnityEngine.Vector3 value);
            /*0x2a6ffc4*/ UnityEngine.Mesh get_bakedMesh();
            /*0x2a6ffcc*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> get_particles();
            /*0x2a6ffd4*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_materials();
            /*0x2a6ffdc*/ UnityEngine.Material get_materialForRendering();
            /*0x2a70004*/ System.Collections.Generic.List<bool> get_activeMeshIndices();
            /*0x2a7000c*/ void set_activeMeshIndices(System.Collections.Generic.List<bool> value);
            /*0x2a700c8*/ UnityEngine.Vector3 get_cachedPosition();
            /*0x2a700d8*/ void set_cachedPosition(UnityEngine.Vector3 value);
            /*0x2a700e8*/ void Play();
            /*0x2a701ec*/ void Pause();
            /*0x2a702f0*/ void Stop();
            /*0x2a703f4*/ void Clear();
            /*0x2a704f8*/ void SetParticleSystemInstance(UnityEngine.GameObject instance);
            /*0x2a70500*/ void SetParticleSystemInstance(UnityEngine.GameObject instance, bool destroyOldParticles);
            /*0x2a70b94*/ void SetParticleSystemPrefab(UnityEngine.GameObject prefab);
            /*0x2a6feac*/ void RefreshParticles();
            /*0x2a70894*/ void RefreshParticles(UnityEngine.GameObject root);
            /*0x2a70c7c*/ void UpdateMaterial();
            /*0x2a71458*/ void ClearPreviousMaterials();
            /*0x2a71764*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial, UnityEngine.Texture2D texture);
            /*0x2a71b7c*/ void UpdateMaterialProperties();
            /*0x2a71918*/ void UpdateMaterialProperties(UnityEngine.Renderer r, int index);
            /*0x2a71df0*/ void OnEnable();
            /*0x2a722a0*/ System.Collections.IEnumerator Start();
            /*0x2a72338*/ void OnDisable();
            /*0x2a725a8*/ void UpdateGeometry();
            /*0x2a725ac*/ void OnDidApplyAnimationProperties();
            /*0x2a720c0*/ void InitializeIfNeeded();
            /*0x2a72874*/ bool <RefreshParticles>b__57_0(UnityEngine.ParticleSystem x);
            /*0x2a72918*/ void <RefreshParticles>b__57_1(UnityEngine.ParticleSystem p);

            class <>c
            {
                static /*0x0*/ Coffee.UIExtensions.UIParticle.<> <>9;
                static /*0x8*/ System.Action<UnityEngine.ParticleSystem> <>9__49_0;
                static /*0x10*/ System.Action<UnityEngine.ParticleSystem> <>9__50_0;
                static /*0x18*/ System.Action<UnityEngine.ParticleSystem> <>9__51_0;
                static /*0x20*/ System.Action<UnityEngine.ParticleSystem> <>9__52_0;
                static /*0x28*/ System.Action<UnityEngine.ParticleSystem> <>9__63_0;
                static /*0x30*/ System.Predicate<UnityEngine.ParticleSystem> <>9__64_1;
                static /*0x38*/ System.Predicate<UnityEngine.ParticleSystem> <>9__64_0;
                static /*0x40*/ System.Action<UnityEngine.ParticleSystem> <>9__65_0;

                static /*0x2a747bc*/ <>c();
                /*0x2a7481c*/ <>c();
                /*0x2a74824*/ void <Play>b__49_0(UnityEngine.ParticleSystem p);
                /*0x2a74840*/ void <Pause>b__50_0(UnityEngine.ParticleSystem p);
                /*0x2a7485c*/ void <Stop>b__51_0(UnityEngine.ParticleSystem p);
                /*0x2a74878*/ void <Clear>b__52_0(UnityEngine.ParticleSystem p);
                /*0x2a74894*/ void <OnEnable>b__63_0(UnityEngine.ParticleSystem p);
                /*0x2a748f8*/ bool <Start>b__64_0(UnityEngine.ParticleSystem ps);
                /*0x2a74a80*/ bool <Start>b__64_1(UnityEngine.ParticleSystem p);
                /*0x2a74b10*/ void <OnDisable>b__65_0(UnityEngine.ParticleSystem p);
            }

            class <Start>d__64 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Coffee.UIExtensions.UIParticle <>4__this;

                /*0x2a7230c*/ <Start>d__64(int <>1__state);
                /*0x2a74b74*/ void System.IDisposable.Dispose();
                /*0x2a74b78*/ bool MoveNext();
                /*0x2a74d60*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2a74d68*/ void System.Collections.IEnumerator.Reset();
                /*0x2a74da8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class UIParticleUpdater
        {
            static /*0x0*/ System.Collections.Generic.List<Coffee.UIExtensions.UIParticle> s_ActiveParticles;
            static /*0x8*/ UnityEngine.MaterialPropertyBlock s_Mpb;
            static /*0x10*/ UnityEngine.ParticleSystem.Particle[] s_Particles;
            static /*0x18*/ int frameCount;

            static /*0x2a74278*/ UIParticleUpdater();
            static /*0x2a71fec*/ void Register(Coffee.UIExtensions.UIParticle particle);
            static /*0x2a724d4*/ void Unregister(Coffee.UIExtensions.UIParticle particle);
            static /*0x2a729a0*/ void InitializeOnLoad();
            static /*0x2a72ad4*/ void Refresh();
            static /*0x2a72d40*/ void Refresh(Coffee.UIExtensions.UIParticle particle);
            static /*0x2a72ecc*/ void ModifyScale(Coffee.UIExtensions.UIParticle particle);
            static /*0x2a73f50*/ UnityEngine.Matrix4x4 GetScaledMatrix(UnityEngine.ParticleSystem particle);
            static /*0x2a73070*/ void BakeMesh(Coffee.UIExtensions.UIParticle particle);
            static /*0x2a741bc*/ bool CanBakeMesh(UnityEngine.ParticleSystemRenderer renderer);
        }
    }
}
