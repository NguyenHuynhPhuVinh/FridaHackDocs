class <Module>
{
}

namespace Spine
{
    class SpineSkeletonExtensions
    {
        static /*0x73b1da0*/ bool IsWeighted(Spine.VertexAttachment va);
        static /*0x73b1dd0*/ bool InheritsRotation(Spine.Inherit mode);
        static /*0x73b1df0*/ bool InheritsScale(Spine.Inherit mode);
    }

    namespace Unity
    {
        class AnimationReferenceAsset : UnityEngine.ScriptableObject, Spine.Unity.IHasSkeletonDataAsset, Spine.Unity.ISpineComponent
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string animationName;
            /*0x28*/ Spine.Animation animation;

            static /*0x73b25e0*/ Spine.Animation op_Implicit(Spine.Unity.AnimationReferenceAsset asset);
            /*0x73b260c*/ AnimationReferenceAsset();
            /*0x73b1dfc*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x73b1e04*/ Spine.Animation get_Animation();
            /*0x73b1fdc*/ void Clear();
            /*0x73b1e28*/ void Initialize();
        }

        class AtlasAssetBase : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase.LoadingMode textureLoadingMode;
            /*0x20*/ Spine.Unity.OnDemandTextureLoader onDemandTextureLoader;

            /*0x73b2894*/ AtlasAssetBase();
            /*0x38148bc*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x3814574*/ int get_MaterialCount();
            /*0x3813ffc*/ bool get_IsLoaded();
            /*0x38159dc*/ void Clear();
            Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x73b2614*/ Spine.Unity.AtlasAssetBase.LoadingMode get_TextureLoadingMode();
            /*0x73b261c*/ void set_TextureLoadingMode(Spine.Unity.AtlasAssetBase.LoadingMode value);
            /*0x73b2624*/ Spine.Unity.OnDemandTextureLoader get_OnDemandTextureLoader();
            /*0x73b262c*/ void set_OnDemandTextureLoader(Spine.Unity.OnDemandTextureLoader value);
            /*0x73b2634*/ void BeginCustomTextureLoading();
            /*0x73b26b8*/ void EndCustomTextureLoading();
            /*0x73b273c*/ void RequireTexturesLoaded(UnityEngine.Material material, ref UnityEngine.Material overrideMaterial);
            /*0x73b27dc*/ void RequireTextureLoaded(UnityEngine.Texture placeholderTexture, ref UnityEngine.Texture replacementTexture, System.Action<UnityEngine.Texture> onTextureLoaded);

            enum LoadingMode
            {
                Normal = 0,
                OnDemand = 1,
            }
        }

        class BlendModeMaterials
        {
            static string MATERIAL_SUFFIX_MULTIPLY = "-Multiply";
            static string MATERIAL_SUFFIX_SCREEN = "-Screen";
            static string MATERIAL_SUFFIX_ADDITIVE = "-Additive";
            /*0x10*/ bool requiresBlendModeMaterials;
            /*0x11*/ bool applyAdditiveMaterial;
            /*0x18*/ System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> additiveMaterials;
            /*0x20*/ System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> multiplyMaterials;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> screenMaterials;

            static /*0x73b2fd8*/ bool CreateAndAssignMaterials(Spine.Unity.SkeletonDataAsset skeletonDataAsset, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials, ref bool anyReplacementMaterialsChanged);
            static /*0x73b31d4*/ bool CreateAndAssignMaterials(Spine.Unity.SkeletonDataAsset skeletonDataAsset, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials, ref bool anyReplacementMaterialsChanged, System.Action<Spine.Unity.SkeletonDataAsset> clearSkeletonDataAssetFunc, System.Action<Spine.Unity.SkeletonDataAsset> afterAssetModifiedFunc, Spine.Unity.BlendModeMaterials.CreateForRegionDelegate createForRegionFunc);
            static /*0x73b3938*/ bool CreateForRegion(ref System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials, ref bool anyReplacementMaterialsChanged, Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            static /*0x73b3b90*/ Spine.Unity.BlendModeMaterials.ReplacementMaterial CreateReplacementMaterial(Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix);
            /*0x73b46e0*/ BlendModeMaterials();
            /*0x73b289c*/ bool get_RequiresBlendModeMaterials();
            /*0x73b28a4*/ Spine.BlendMode BlendModeForMaterial(UnityEngine.Material material);
            /*0x73b2c0c*/ bool UpdateBlendmodeMaterialsRequiredState(Spine.SkeletonData skeletonData);
            /*0x73b3d5c*/ void ApplyMaterials(Spine.SkeletonData skeletonData);
            /*0x73b44fc*/ Spine.AtlasRegion CloneAtlasRegionWithMaterial(Spine.AtlasRegion originalRegion, System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials);

            class ReplacementMaterial
            {
                /*0x10*/ string pageName;
                /*0x18*/ UnityEngine.Material material;

                /*0x73b3d54*/ ReplacementMaterial();
            }

            class TemplateMaterials
            {
                /*0x10*/ UnityEngine.Material additiveTemplate;
                /*0x18*/ UnityEngine.Material multiplyTemplate;
                /*0x20*/ UnityEngine.Material screenTemplate;

                /*0x73b47b0*/ TemplateMaterials();
            }

            class CreateForRegionDelegate : System.MulticastDelegate
            {
                /*0x73b3120*/ CreateForRegionDelegate(object object, nint method);
                /*0x73b47b8*/ bool Invoke(ref System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials, ref bool anyReplacementMaterialsChanged, Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            }

            class <>c
            {
                static /*0x0*/ Spine.Unity.BlendModeMaterials.<> <>9;
                static /*0x8*/ System.Action<Spine.Unity.SkeletonDataAsset> <>9__16_0;

                static /*0x73b47cc*/ <>c();
                /*0x73b4834*/ <>c();
                /*0x73b483c*/ void <CreateAndAssignMaterials>b__16_0(Spine.Unity.SkeletonDataAsset asset);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ Spine.AtlasRegion originalRegion;

                /*0x73b3b88*/ <>c__DisplayClass18_0();
                /*0x73b4898*/ bool <CreateForRegion>b__0(Spine.Unity.BlendModeMaterials.ReplacementMaterial replacement);
            }
        }

        class EventDataReferenceAsset : UnityEngine.ScriptableObject
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string eventName;
            /*0x28*/ Spine.EventData eventData;

            static /*0x73b4a98*/ Spine.EventData op_Implicit(Spine.Unity.EventDataReferenceAsset asset);
            /*0x73b4ac4*/ EventDataReferenceAsset();
            /*0x73b48c8*/ Spine.EventData get_EventData();
            /*0x73b48ec*/ void Initialize();
        }

        class OnDemandTextureLoader : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase atlasAsset;
            /*0x20*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureRequested;
            /*0x28*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureLoaded;
            /*0x30*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureLoadFailed;
            /*0x38*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureUnloaded;

            /*0x73b5510*/ OnDemandTextureLoader();
            /*0x3814a3c*/ string GetPlaceholderTextureName(string originalTextureName);
            /*0x38141c4*/ bool AssignPlaceholderTextures(ref System.Collections.Generic.IEnumerable<UnityEngine.Material> modifiedMaterials);
            /*0x38141c4*/ bool HasPlaceholderTexturesAssigned(ref System.Collections.Generic.List<UnityEngine.Material> placeholderMaterials);
            /*0x73b4acc*/ bool HasNullMainTexturesAssigned(ref System.Collections.Generic.List<UnityEngine.Material> nullTextureMaterials);
            /*0x38141c4*/ bool AssignTargetTextures(ref System.Collections.Generic.IEnumerable<UnityEngine.Material> modifiedMaterials);
            /*0x38159dc*/ void BeginCustomTextureLoading();
            /*0x38159dc*/ void EndCustomTextureLoading();
            /*0x38141c4*/ bool HasPlaceholderAssigned(UnityEngine.Material material);
            /*0x3816810*/ void RequestLoadMaterialTextures(UnityEngine.Material material, ref UnityEngine.Material overrideMaterial);
            /*0x3816920*/ void RequestLoadTexture(UnityEngine.Texture placeholderTexture, ref UnityEngine.Texture replacementTexture, System.Action<UnityEngine.Texture> onTextureLoaded);
            /*0x3815cc4*/ void Clear(bool clearAtlasAsset);
            /*0x73b4f60*/ void add_onTextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b4ffc*/ void remove_onTextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5098*/ void add_onTextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5134*/ void remove_onTextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b51d0*/ void add_onTextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b526c*/ void remove_onTextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5308*/ void add_onTextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b53a4*/ void remove_onTextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5440*/ void add_TextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5444*/ void remove_TextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5448*/ void add_TextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b544c*/ void remove_TextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5450*/ void add_TextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5454*/ void remove_TextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5458*/ void add_TextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b545c*/ void remove_TextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x73b5460*/ void OnTextureRequested(UnityEngine.Material material, int textureIndex);
            /*0x73b548c*/ void OnTextureLoaded(UnityEngine.Material material, int textureIndex);
            /*0x73b54b8*/ void OnTextureLoadFailed(UnityEngine.Material material, int textureIndex);
            /*0x73b54e4*/ void OnTextureUnloaded(UnityEngine.Material material, int textureIndex);

            class TextureLoadDelegate : System.MulticastDelegate
            {
                /*0x73b5518*/ TextureLoadDelegate(object object, nint method);
                /*0x73b5624*/ void Invoke(Spine.Unity.OnDemandTextureLoader loader, UnityEngine.Material material, int textureIndex);
            }
        }

        class RegionlessAttachmentLoader : Spine.AttachmentLoader
        {
            static /*0x0*/ Spine.AtlasRegion emptyRegion;

            static /*0x73b5638*/ Spine.AtlasRegion get_EmptyRegion();
            /*0x73b5ad0*/ RegionlessAttachmentLoader();
            /*0x73b5870*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
            /*0x73b58e8*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
            /*0x73b5960*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
            /*0x73b59bc*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
            /*0x73b5a18*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
            /*0x73b5a74*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
        }

        class SkeletonDataAsset : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase[] atlasAssets;
            /*0x20*/ float scale;
            /*0x28*/ UnityEngine.TextAsset skeletonJSON;
            /*0x30*/ bool isUpgradingBlendModeMaterials;
            /*0x38*/ Spine.Unity.BlendModeMaterials blendModeMaterials;
            /*0x40*/ System.Collections.Generic.List<Spine.Unity.SkeletonDataModifierAsset> skeletonDataModifiers;
            /*0x48*/ string[] fromAnimation;
            /*0x50*/ string[] toAnimation;
            /*0x58*/ float[] duration;
            /*0x60*/ float defaultMix;
            /*0x68*/ UnityEngine.RuntimeAnimatorController controller;
            /*0x70*/ Spine.SkeletonData skeletonData;
            /*0x78*/ Spine.AnimationStateData stateData;

            static /*0x73b5b10*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase atlasAsset, bool initialize, float scale);
            static /*0x73b5bd4*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase[] atlasAssets, bool initialize, float scale);
            static /*0x73b5ef8*/ Spine.SkeletonData ReadSkeletonData(byte[] bytes, Spine.AttachmentLoader attachmentLoader, float scale);
            static /*0x73b60f4*/ Spine.SkeletonData ReadSkeletonData(string text, Spine.AttachmentLoader attachmentLoader, float scale);
            /*0x73b631c*/ SkeletonDataAsset();
            /*0x73b5ad8*/ bool get_IsLoaded();
            /*0x73b5ae8*/ void Reset();
            /*0x73b5c9c*/ void SetupRuntimeBlendModeMaterials(bool applyAdditiveMaterial, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials);
            /*0x73b4870*/ void Clear();
            /*0x73b5d2c*/ Spine.AnimationStateData GetAnimationStateData();
            /*0x73b1fe8*/ Spine.SkeletonData GetSkeletonData(bool quiet);
            /*0x73b61b4*/ void InitializeWithData(Spine.SkeletonData sd);
            /*0x73b6248*/ void FillStateData(bool quiet);
            /*0x73b5d54*/ Spine.Atlas[] GetAtlasArray();
        }

        class SkeletonDataModifierAsset : UnityEngine.ScriptableObject
        {
            /*0x73b64a0*/ SkeletonDataModifierAsset();
            /*0x3816710*/ void Apply(Spine.SkeletonData skeletonData);
        }

        class SpineAtlasAsset : Spine.Unity.AtlasAssetBase
        {
            /*0x28*/ UnityEngine.TextAsset atlasFile;
            /*0x30*/ UnityEngine.Material[] materials;
            /*0x38*/ Spine.TextureLoader customTextureLoader;
            /*0x40*/ Spine.Atlas atlas;

            static /*0x73b6500*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Material[] materials, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader);
            static /*0x73b65ec*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Material materialPropertySource, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader, bool renameMaterial);
            static /*0x73b6a24*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Shader shader, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader);
            /*0x73b73c4*/ SpineAtlasAsset();
            /*0x73b64a8*/ bool get_IsLoaded();
            /*0x73b64b8*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x73b64c0*/ int get_MaterialCount();
            /*0x73b64d8*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x73b65e0*/ void Reset();
            /*0x73b6b10*/ void Clear();
            /*0x73b6b1c*/ Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x73b6fb4*/ UnityEngine.Mesh GenerateMesh(string name, UnityEngine.Mesh mesh, ref UnityEngine.Material material, float scale);
        }

        class NoOpTextureLoader : Spine.TextureLoader
        {
            /*0x73b6fac*/ NoOpTextureLoader();
            /*0x73b73cc*/ void Load(Spine.AtlasPage page, string path);
        }

        class MaterialsTextureLoader : Spine.TextureLoader
        {
            /*0x10*/ Spine.Unity.SpineAtlasAsset atlasAsset;

            /*0x73b6f7c*/ MaterialsTextureLoader(Spine.Unity.SpineAtlasAsset atlasAsset);
            /*0x73b73d0*/ void Load(Spine.AtlasPage page, string path);
        }

        class SpineSpriteAtlasAsset : Spine.Unity.AtlasAssetBase
        {
            /*0x28*/ UnityEngine.U2D.SpriteAtlas spriteAtlasFile;
            /*0x30*/ UnityEngine.Material[] materials;
            /*0x38*/ Spine.Atlas atlas;
            /*0x40*/ bool updateRegionsInPlayMode;
            /*0x48*/ Spine.Unity.SpineSpriteAtlasAsset.SavedRegionInfo[] savedRegions;

            static /*0x73b776c*/ Spine.Unity.SpineSpriteAtlasAsset CreateRuntimeInstance(UnityEngine.U2D.SpriteAtlas spriteAtlasFile, UnityEngine.Material[] materials, bool initialize);
            static /*0x73b83e4*/ UnityEngine.Texture2D AccessPackedTexture(UnityEngine.Sprite[] sprites);
            static /*0x73b8410*/ UnityEngine.Sprite[] AccessPackedSprites(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            /*0x73b8498*/ SpineSpriteAtlasAsset();
            /*0x73b7714*/ bool get_IsLoaded();
            /*0x73b7724*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x73b772c*/ int get_MaterialCount();
            /*0x73b7744*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x73b7818*/ void Reset();
            /*0x73b7824*/ void Clear();
            /*0x73b7830*/ Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x73b7fe8*/ void AssignRegionsFromSavedRegions(UnityEngine.Sprite[] sprites, Spine.Atlas usedAtlas);
            /*0x73b7b6c*/ Spine.Atlas LoadAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);

            class SavedRegionInfo
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float width;
                /*0x1c*/ float height;
                /*0x20*/ UnityEngine.SpritePackingRotation packingRotation;

                /*0x73b84a0*/ SavedRegionInfo();
            }
        }

        class BoneFollower : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ string boneName;
            /*0x30*/ bool followXYPosition;
            /*0x31*/ bool followZPosition;
            /*0x32*/ bool followBoneRotation;
            /*0x33*/ bool followSkeletonFlip;
            /*0x34*/ bool followLocalScale;
            /*0x35*/ bool followParentWorldScale;
            /*0x38*/ Spine.Unity.BoneFollower.AxisOrientation maintainedAxisOrientation;
            /*0x3c*/ bool initializeOnAwake;
            /*0x3d*/ bool valid;
            /*0x40*/ Spine.Bone bone;
            /*0x48*/ UnityEngine.Transform skeletonTransform;
            /*0x50*/ bool skeletonTransformIsParent;

            /*0x73b8de4*/ BoneFollower();
            /*0x73b84a8*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73b84b0*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x73b84d4*/ bool SetBone(string name);
            /*0x73b85bc*/ void Awake();
            /*0x73b85d4*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x73b85e0*/ void Initialize();
            /*0x73b87b0*/ void OnDestroy();
            /*0x73b8880*/ void LateUpdate();

            enum AxisOrientation
            {
                XAxis = 1,
                YAxis = 2,
            }
        }

        class BoneFollowerGraphic : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x28*/ bool initializeOnAwake;
            /*0x30*/ string boneName;
            /*0x38*/ bool followBoneRotation;
            /*0x39*/ bool followSkeletonFlip;
            /*0x3a*/ bool followLocalScale;
            /*0x3b*/ bool followParentWorldScale;
            /*0x3c*/ bool followXYPosition;
            /*0x3d*/ bool followZPosition;
            /*0x40*/ Spine.Unity.BoneFollower.AxisOrientation maintainedAxisOrientation;
            /*0x48*/ Spine.Bone bone;
            /*0x50*/ UnityEngine.Transform skeletonTransform;
            /*0x58*/ bool skeletonTransformIsParent;
            /*0x59*/ bool valid;

            /*0x73b9644*/ BoneFollowerGraphic();
            /*0x73b8e00*/ Spine.Unity.SkeletonGraphic get_SkeletonGraphic();
            /*0x73b8e08*/ void set_SkeletonGraphic(Spine.Unity.SkeletonGraphic value);
            /*0x73b8e2c*/ bool SetBone(string name);
            /*0x73b8f3c*/ void Awake();
            /*0x73b8f54*/ void Initialize();
            /*0x73b90a4*/ void LateUpdate();
        }

        class BoundingBoxFollower : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool DebugMessages;
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ string slotName;
            /*0x30*/ bool isTrigger;
            /*0x31*/ bool usedByEffector;
            /*0x32*/ bool usedByComposite;
            /*0x33*/ bool clearStateOnDisable;
            /*0x38*/ Spine.Slot slot;
            /*0x40*/ Spine.BoundingBoxAttachment currentAttachment;
            /*0x48*/ string currentAttachmentName;
            /*0x50*/ UnityEngine.PolygonCollider2D currentCollider;
            /*0x58*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, UnityEngine.PolygonCollider2D> colliderTable;
            /*0x60*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, string> nameTable;

            static /*0x73ba934*/ BoundingBoxFollower();
            /*0x73ba850*/ BoundingBoxFollower();
            /*0x73b9664*/ Spine.Slot get_Slot();
            /*0x73b966c*/ Spine.BoundingBoxAttachment get_CurrentAttachment();
            /*0x73b9674*/ string get_CurrentAttachmentName();
            /*0x73b967c*/ UnityEngine.PolygonCollider2D get_CurrentCollider();
            /*0x73b9684*/ bool get_IsTrigger();
            /*0x73b968c*/ void Start();
            /*0x73b9bb8*/ void OnEnable();
            /*0x73b9cc4*/ void HandleRebuild(Spine.Unity.SkeletonRenderer sr);
            /*0x73b9694*/ void Initialize(bool overwrite);
            /*0x73b9ccc*/ void AddCollidersForSkin(Spine.Skin skin, int slotIndex, UnityEngine.PolygonCollider2D[] previousColliders, ref int collidersCount);
            /*0x73ba254*/ void OnDisable();
            /*0x73ba334*/ void ClearState();
            /*0x73ba164*/ void DisposeExcessCollidersAfter(int requiredCount);
            /*0x73ba4d4*/ void LateUpdate();
            /*0x73ba4f4*/ void MatchAttachment(Spine.Attachment attachment);
        }

        class BoundingBoxFollowerGraphic : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool DebugMessages;
            /*0x20*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x28*/ string slotName;
            /*0x30*/ bool isTrigger;
            /*0x31*/ bool usedByEffector;
            /*0x32*/ bool usedByComposite;
            /*0x33*/ bool clearStateOnDisable;
            /*0x38*/ Spine.Slot slot;
            /*0x40*/ Spine.BoundingBoxAttachment currentAttachment;
            /*0x48*/ string currentAttachmentName;
            /*0x50*/ UnityEngine.PolygonCollider2D currentCollider;
            /*0x58*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, UnityEngine.PolygonCollider2D> colliderTable;
            /*0x60*/ System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, string> nameTable;

            static /*0x73bc1d0*/ BoundingBoxFollowerGraphic();
            /*0x73bc0ec*/ BoundingBoxFollowerGraphic();
            /*0x73ba980*/ Spine.Slot get_Slot();
            /*0x73ba988*/ Spine.BoundingBoxAttachment get_CurrentAttachment();
            /*0x73ba990*/ string get_CurrentAttachmentName();
            /*0x73ba998*/ UnityEngine.PolygonCollider2D get_CurrentCollider();
            /*0x73ba9a0*/ bool get_IsTrigger();
            /*0x73ba9a8*/ void Start();
            /*0x73baf04*/ void OnEnable();
            /*0x73bb148*/ void HandleRebuild(Spine.Unity.SkeletonGraphic sr);
            /*0x73ba9b0*/ void Initialize(bool overwrite);
            /*0x73bb560*/ void AddCollidersForSkin(Spine.Skin skin, int slotIndex, UnityEngine.PolygonCollider2D[] previousColliders, float scale, ref int collidersCount);
            /*0x73bbaf4*/ void OnDisable();
            /*0x73bbbd0*/ void ClearState();
            /*0x73bba04*/ void DisposeExcessCollidersAfter(int requiredCount);
            /*0x73bbd70*/ void LateUpdate();
            /*0x73bbd90*/ void MatchAttachment(Spine.Attachment attachment);
        }

        class PointFollower : UnityEngine.MonoBehaviour, Spine.Unity.ISpineComponent
        {
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ string slotName;
            /*0x30*/ string pointAttachmentName;
            /*0x38*/ bool followRotation;
            /*0x39*/ bool followSkeletonFlip;
            /*0x3a*/ bool followSkeletonZPosition;
            /*0x40*/ UnityEngine.Transform skeletonTransform;
            /*0x48*/ bool skeletonTransformIsParent;
            /*0x50*/ Spine.PointAttachment point;
            /*0x58*/ Spine.Bone bone;
            /*0x60*/ bool valid;

            /*0x73bc8f0*/ PointFollower();
            /*0x73bc21c*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73bc224*/ Spine.Unity.ISkeletonComponent get_SkeletonComponent();
            /*0x73bc22c*/ bool get_IsValid();
            /*0x73bc234*/ void Initialize();
            /*0x73bc504*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x73bc2c8*/ void UpdateReferences();
            /*0x73bc508*/ void OnDestroy();
            /*0x73bc5d8*/ void LateUpdate();
        }

        class SkeletonSubmeshGraphic : UnityEngine.UI.MaskableGraphic
        {
            /*0x73bc988*/ SkeletonSubmeshGraphic();
            /*0x73bc900*/ void SetMaterialDirty();
            /*0x73bc904*/ void SetVerticesDirty();
            /*0x73bc908*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x73bc920*/ void OnDisable();
            /*0x73bc954*/ void OnEnable();
        }

        class SkeletonMecanimRootMotion : Spine.Unity.SkeletonRootMotionBase
        {
            static int DefaultMecanimLayerFlags = -1;
            /*0xf8*/ int mecanimLayerFlags;
            /*0xfc*/ UnityEngine.Vector2 movementDelta;
            /*0x104*/ float rotationDelta;
            /*0x108*/ Spine.Unity.SkeletonMecanim skeletonMecanim;

            /*0x73bdea0*/ SkeletonMecanimRootMotion();
            /*0x73bc990*/ Spine.Unity.SkeletonMecanim get_SkeletonMecanim();
            /*0x73bca38*/ UnityEngine.Vector2 GetRemainingRootMotion(int layerIndex);
            /*0x73bd0d4*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int layerIndex);
            /*0x73bd3c8*/ void Reset();
            /*0x73bd3e8*/ void Initialize();
            /*0x73bd8dc*/ void OnClipApplied(Spine.Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward);
            /*0x73bde30*/ UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73bde94*/ float CalculateAnimationsRotationDelta();
        }

        class SkeletonRootMotion : Spine.Unity.SkeletonRootMotionBase
        {
            static int DefaultAnimationTrackFlags = -1;
            /*0xf8*/ int animationTrackFlags;
            /*0x100*/ Spine.AnimationState animationState;
            /*0x108*/ Spine.Unity.SkeletonGraphic skeletonGraphic;

            /*0x73be764*/ SkeletonRootMotion();
            /*0x73be0fc*/ UnityEngine.Vector2 GetRemainingRootMotion(int trackIndex);
            /*0x73be184*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex);
            /*0x73be200*/ float get_AdditionalScale();
            /*0x73be278*/ void Reset();
            /*0x73be294*/ void Initialize();
            /*0x73be3a8*/ UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73be584*/ float CalculateAnimationsRotationDelta();
            /*0x73be54c*/ void ApplyMixAlphaToDelta(ref UnityEngine.Vector2 currentDelta, Spine.TrackEntry next, Spine.TrackEntry track);
            /*0x73be690*/ void ApplyMixAlphaToDelta(ref float currentDelta, Spine.TrackEntry next, Spine.TrackEntry track);
            /*0x73be6c8*/ void GetMixAlpha(ref float cumulatedMixAlpha, Spine.TrackEntry next, Spine.TrackEntry track);
        }

        class SkeletonRootMotionBase : UnityEngine.MonoBehaviour
        {
            /*0x20*/ string rootMotionBoneName;
            /*0x28*/ bool transformPositionX;
            /*0x29*/ bool transformPositionY;
            /*0x2a*/ bool transformRotation;
            /*0x2c*/ float rootMotionScaleX;
            /*0x30*/ float rootMotionScaleY;
            /*0x34*/ float rootMotionScaleRotation;
            /*0x38*/ float rootMotionTranslateXPerY;
            /*0x3c*/ float rootMotionTranslateYPerX;
            /*0x40*/ UnityEngine.Rigidbody2D rigidBody2D;
            /*0x48*/ bool applyRigidbody2DGravity;
            /*0x50*/ UnityEngine.Rigidbody rigidBody;
            /*0x58*/ Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate ProcessRootMotionOverride;
            /*0x60*/ Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate PhysicsUpdateRootMotionOverride;
            /*0x68*/ bool disableOnOverride;
            /*0x70*/ Spine.Unity.ISkeletonComponent skeletonComponent;
            /*0x78*/ Spine.Bone rootMotionBone;
            /*0x80*/ int rootMotionBoneIndex;
            /*0x88*/ System.Collections.Generic.List<int> transformConstraintIndices;
            /*0x90*/ System.Collections.Generic.List<UnityEngine.Vector2> transformConstraintLastPos;
            /*0x98*/ System.Collections.Generic.List<float> transformConstraintLastRotation;
            /*0xa0*/ System.Collections.Generic.List<Spine.Bone> topLevelBones;
            /*0xa8*/ UnityEngine.Vector2 initialOffset;
            /*0xb0*/ bool accumulatedUntilFixedUpdate;
            /*0xb4*/ UnityEngine.Vector2 tempSkeletonDisplacement;
            /*0xbc*/ UnityEngine.Vector3 rigidbodyDisplacement;
            /*0xc8*/ UnityEngine.Vector3 previousRigidbodyRootMotion;
            /*0xd4*/ UnityEngine.Vector2 additionalRigidbody2DMovement;
            /*0xdc*/ UnityEngine.Quaternion rigidbodyLocalRotation;
            /*0xec*/ float rigidbody2DRotation;
            /*0xf0*/ float initialOffsetRotation;
            /*0xf4*/ float tempSkeletonRotation;

            /*0x73bdeac*/ SkeletonRootMotionBase();
            /*0x73be770*/ void add_ProcessRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73be80c*/ void remove_ProcessRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73be8a8*/ void add_PhysicsUpdateRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73be944*/ void remove_PhysicsUpdateRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73be9e0*/ Spine.Bone get_RootMotionBone();
            /*0x73be9e8*/ bool get_UsesRigidbody();
            /*0x73bea80*/ UnityEngine.Vector2 get_PreviousRigidbodyRootMotion2D();
            /*0x73bea88*/ UnityEngine.Vector3 get_PreviousRigidbodyRootMotion3D();
            /*0x73bea94*/ UnityEngine.Vector2 get_AdditionalRigidbody2DMovement();
            /*0x73bea9c*/ void set_AdditionalRigidbody2DMovement(UnityEngine.Vector2 value);
            /*0x73beaa4*/ bool get_SkeletonAnimationUsesFixedUpdate();
            /*0x73bd3e4*/ void Reset();
            /*0x73bed08*/ void Start();
            /*0x73bed14*/ void InitializeOnRebuild(Spine.Unity.ISkeletonAnimation animatedSkeletonComponent);
            /*0x73bd54c*/ void Initialize();
            /*0x73bf138*/ void FixedUpdate();
            /*0x73bf178*/ void PhysicsUpdate(bool skeletonAnimationUsesFixedUpdate);
            /*0x73bf83c*/ void OnDisable();
            /*0x73beb5c*/ void FindRigidbodyComponent();
            /*0x73bf840*/ float get_AdditionalScale();
            UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73bf848*/ float CalculateAnimationsRotationDelta();
            UnityEngine.Vector2 GetRemainingRootMotion(int trackIndex);
            /*0x3910ae8*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex);
            /*0x73bf850*/ Spine.Unity.ISkeletonComponent get_TargetSkeletonComponent();
            /*0x73bf8bc*/ Spine.Unity.ISkeletonAnimation get_TargetSkeletonAnimationComponent();
            /*0x73befb8*/ void SetRootMotionBone(string name);
            /*0x73bfb88*/ void AdjustRootMotionToDistance(UnityEngine.Vector2 distanceToTarget, int trackIndex, bool adjustX, bool adjustY, float minX, float maxX, float minY, float maxY, bool allowXTranslation, bool allowYTranslation);
            /*0x73bfd94*/ UnityEngine.Vector2 GetAnimationRootMotion(Spine.Animation animation);
            /*0x73bcaf4*/ UnityEngine.Vector2 GetAnimationRootMotion(float startTime, float endTime, Spine.Animation animation);
            /*0x73c009c*/ float GetAnimationRootMotionRotation(Spine.Animation animation);
            /*0x73bd9e4*/ float GetAnimationRootMotionRotation(float startTime, float endTime, Spine.Animation animation);
            /*0x73bfdb0*/ void ApplyConstraintToPos(Spine.Animation animation, Spine.TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintPos, ref UnityEngine.Vector2 pos);
            /*0x73c00b8*/ void ApplyConstraintToRotation(Spine.Animation animation, Spine.TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintRotation, ref float rotation);
            /*0x73bfecc*/ void UpdateLastConstraintPos(Spine.TransformConstraint[] transformConstraintsItems);
            /*0x73c01b8*/ void UpdateLastConstraintRotation(Spine.TransformConstraint[] transformConstraintsItems);
            /*0x73bd190*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetAnimationRootMotionInfo(Spine.Animation animation, float currentTime);
            /*0x73c0388*/ int GetConstraintLastPosIndex(int constraintIndex);
            /*0x73bf908*/ void FindTransformConstraintsAffectingBone();
            /*0x73c04e0*/ UnityEngine.Vector2 GetTimelineMovementDelta(float startTime, float endTime, Spine.TranslateXTimeline xTimeline, Spine.TranslateYTimeline yTimeline, Spine.Animation animation);
            /*0x73bed20*/ void GatherTopLevelBones();
            /*0x73c062c*/ void HandleUpdateLocal(Spine.Unity.ISkeletonAnimation animatedSkeletonComponent);
            /*0x73c079c*/ void ApplyRootMotion(UnityEngine.Vector2 skeletonTranslationDelta, float skeletonRotationDelta, UnityEngine.Vector2 parentBoneScale, bool skeletonAnimationUsesFixedUpdate);
            /*0x73c0f64*/ void ApplyTransformConstraints();
            /*0x73bfd7c*/ UnityEngine.Vector2 GetScaleAffectingRootMotion();
            /*0x73bf5a0*/ UnityEngine.Vector2 GetScaleAffectingRootMotion(ref UnityEngine.Vector2 parentBoneScale);
            /*0x73c0710*/ UnityEngine.Vector2 GetSkeletonSpaceMovementDelta(UnityEngine.Vector2 boneLocalDelta, ref UnityEngine.Vector2 parentBoneScale, ref UnityEngine.Vector2 totalScale);
            /*0x73c0788*/ float GetSkeletonSpaceRotationDelta(float boneLocalDelta, UnityEngine.Vector2 totalScaleAffectingRootMotion);
            /*0x73c0b1c*/ void SetEffectiveBoneOffsetsTo(UnityEngine.Vector2 displacementSkeletonSpace, float rotationSkeletonSpace, UnityEngine.Vector2 parentBoneScale);
            /*0x73bf730*/ void ClearEffectiveBoneOffsets(UnityEngine.Vector2 parentBoneScale);
            /*0x73bf79c*/ void ClearRigidbodyTempMovement();

            class RootMotionDelegate : System.MulticastDelegate
            {
                /*0x73c1184*/ RootMotionDelegate(object object, nint method);
                /*0x73c1290*/ void Invoke(Spine.Unity.SkeletonRootMotionBase component, UnityEngine.Vector2 translation, float rotation);
            }

            struct RootMotionInfo
            {
                /*0x10*/ UnityEngine.Vector2 start;
                /*0x18*/ UnityEngine.Vector2 current;
                /*0x20*/ UnityEngine.Vector2 mid;
                /*0x28*/ UnityEngine.Vector2 end;
                /*0x30*/ bool timeIsPastMid;
            }

            class <>c__DisplayClass80_0
            {
                /*0x10*/ int constraintIndex;

                /*0x73c04d8*/ <>c__DisplayClass80_0();
                /*0x73c12a4*/ bool <GetConstraintLastPosIndex>b__0(int addedIndex);
            }
        }

        class SkeletonAnimation : Spine.Unity.SkeletonRenderer, Spine.Unity.ISkeletonAnimation, Spine.Unity.ISpineComponent, Spine.Unity.IAnimationStateComponent
        {
            /*0x110*/ Spine.AnimationState state;
            /*0x118*/ bool wasUpdatedAfterInit;
            /*0x120*/ Spine.Unity.ISkeletonAnimationDelegate _OnAnimationRebuild;
            /*0x128*/ Spine.Unity.UpdateBonesDelegate _BeforeApply;
            /*0x130*/ Spine.Unity.UpdateBonesDelegate _UpdateLocal;
            /*0x138*/ Spine.Unity.UpdateBonesDelegate _UpdateWorld;
            /*0x140*/ Spine.Unity.UpdateBonesDelegate _UpdateComplete;
            /*0x148*/ Spine.Unity.UpdateTiming updateTiming;
            /*0x14c*/ bool unscaledTime;
            /*0x150*/ string _animationName;
            /*0x158*/ bool loop;
            /*0x15c*/ float timeScale;

            static /*0x73c1aa4*/ Spine.Unity.SkeletonAnimation AddToGameObject(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            static /*0x73c1b28*/ Spine.Unity.SkeletonAnimation NewSkeletonAnimationGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            /*0x73c2064*/ SkeletonAnimation();
            /*0x73c12b4*/ Spine.AnimationState get_AnimationState();
            /*0x73c12dc*/ void add__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c137c*/ void remove__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c141c*/ void add__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c14bc*/ void remove__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c155c*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c15fc*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c169c*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c173c*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c17dc*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c187c*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c191c*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c1920*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c1924*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1928*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c192c*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1930*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1934*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1938*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c193c*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1940*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c1944*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73c194c*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73c1954*/ bool get_UnscaledTime();
            /*0x73c195c*/ void set_UnscaledTime(bool value);
            /*0x73c1968*/ string get_AnimationName();
            /*0x73c19b0*/ void set_AnimationName(string value);
            /*0x73c1ba4*/ void ClearState();
            /*0x73c1bd0*/ void Initialize(bool overwrite, bool quiet);
            /*0x73c1d24*/ void Update();
            /*0x73c1dc8*/ void FixedUpdate();
            /*0x73c1d68*/ void Update(float deltaTime);
            /*0x73c1e0c*/ void UpdateAnimationStatus(float deltaTime);
            /*0x73c1e94*/ void ApplyAnimation();
            /*0x73c1ef8*/ void AfterAnimationApplied();
            /*0x73c1fa4*/ void LateUpdate();
            /*0x73c2008*/ void OnBecameVisible();
        }

        class SkeletonGraphic : UnityEngine.UI.MaskableGraphic, Spine.Unity.ISkeletonComponent, Spine.Unity.ISpineComponent, Spine.Unity.IAnimationStateComponent, Spine.Unity.ISkeletonAnimation, Spine.Unity.IHasSkeletonDataAsset
        {
            static bool EditReferenceRect = false;
            static string SeparatorPartGameObjectName = "Part";
            /*0xd8*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0xe0*/ UnityEngine.Material additiveMaterial;
            /*0xe8*/ UnityEngine.Material multiplyMaterial;
            /*0xf0*/ UnityEngine.Material screenMaterial;
            /*0xf8*/ UnityEngine.Color m_SkeletonColor;
            /*0x108*/ string initialSkinName;
            /*0x110*/ bool initialFlipX;
            /*0x111*/ bool initialFlipY;
            /*0x118*/ string startingAnimation;
            /*0x120*/ bool startingLoop;
            /*0x124*/ float timeScale;
            /*0x128*/ bool freeze;
            /*0x12c*/ float meshScale;
            /*0x130*/ UnityEngine.Vector2 meshOffset;
            /*0x138*/ Spine.Unity.SkeletonGraphic.LayoutMode layoutScaleMode;
            /*0x13c*/ UnityEngine.Vector2 referenceSize;
            /*0x144*/ UnityEngine.Vector2 pivotOffset;
            /*0x14c*/ float referenceScale;
            /*0x150*/ float layoutScale;
            /*0x154*/ Spine.Unity.UpdateMode updateMode;
            /*0x158*/ Spine.Unity.UpdateMode updateWhenInvisible;
            /*0x15c*/ bool allowMultipleCanvasRenderers;
            /*0x160*/ System.Collections.Generic.List<UnityEngine.CanvasRenderer> canvasRenderers;
            /*0x168*/ System.Collections.Generic.List<Spine.Unity.SkeletonSubmeshGraphic> submeshGraphics;
            /*0x170*/ int usedRenderersCount;
            /*0x178*/ string[] separatorSlotNames;
            /*0x180*/ System.Collections.Generic.List<Spine.Slot> separatorSlots;
            /*0x188*/ bool enableSeparatorSlots;
            /*0x190*/ System.Collections.Generic.List<UnityEngine.Transform> separatorParts;
            /*0x198*/ bool updateSeparatorPartLocation;
            /*0x199*/ bool updateSeparatorPartScale;
            /*0x19a*/ bool wasUpdatedAfterInit;
            /*0x1a0*/ UnityEngine.Texture baseTexture;
            /*0x1a8*/ bool disableMeshAssignmentOnOverride;
            /*0x1b0*/ Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle assignMeshOverrideSingle;
            /*0x1b8*/ Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple assignMeshOverrideMultiple;
            /*0x1c0*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Texture> customTextureOverride;
            /*0x1c8*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Material> customMaterialOverride;
            /*0x1d0*/ UnityEngine.Texture overrideTexture;
            /*0x1d8*/ Spine.Skeleton skeleton;
            /*0x1e0*/ Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate OnRebuild;
            /*0x1e8*/ Spine.Unity.SkeletonGraphic.InstructionDelegate OnInstructionsPrepared;
            /*0x1f0*/ Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate OnMeshAndMaterialsUpdated;
            /*0x1f8*/ Spine.AnimationState state;
            /*0x200*/ UnityEngine.Vector2 physicsPositionInheritanceFactor;
            /*0x208*/ float physicsRotationInheritanceFactor;
            /*0x210*/ UnityEngine.Transform physicsMovementRelativeTo;
            /*0x218*/ UnityEngine.Vector2 lastPosition;
            /*0x220*/ float lastRotation;
            /*0x228*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0x230*/ Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> meshBuffers;
            /*0x238*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;
            /*0x240*/ Spine.ExposedList<UnityEngine.Mesh> meshes;
            /*0x248*/ Spine.ExposedList<UnityEngine.Material> usedMaterials;
            /*0x250*/ Spine.ExposedList<UnityEngine.Texture> usedTextures;
            /*0x258*/ Spine.Unity.ISkeletonAnimationDelegate OnAnimationRebuild;
            /*0x260*/ Spine.Unity.UpdateBonesDelegate BeforeApply;
            /*0x268*/ Spine.Unity.UpdateBonesDelegate UpdateLocal;
            /*0x270*/ Spine.Unity.UpdateBonesDelegate UpdateWorld;
            /*0x278*/ Spine.Unity.UpdateBonesDelegate UpdateComplete;
            /*0x280*/ Spine.Unity.UpdateTiming updateTiming;
            /*0x284*/ bool unscaledTime;
            /*0x288*/ Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;

            static /*0x73c2124*/ Spine.Unity.SkeletonGraphic NewSkeletonGraphicGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Transform parent, UnityEngine.Material material);
            static /*0x73c2224*/ Spine.Unity.SkeletonGraphic AddSkeletonGraphicComponent(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Material material);
            static /*0x73c4bec*/ void SetRectTransformSize(UnityEngine.UI.Graphic target, UnityEngine.Vector2 size);
            static /*0x73c4c20*/ void SetRectTransformSize(UnityEngine.RectTransform targetRectTransform, UnityEngine.Vector2 size);
            /*0x73c80b0*/ SkeletonGraphic();
            /*0x73c20d0*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x73c20d8*/ UnityEngine.Color get_color();
            /*0x73c20e8*/ void set_color(UnityEngine.Color value);
            /*0x73c20f8*/ float get_MeshScale();
            /*0x73c2100*/ UnityEngine.Vector2 get_MeshOffset();
            /*0x73c210c*/ Spine.Unity.UpdateMode get_UpdateMode();
            /*0x73c2114*/ void set_UpdateMode(Spine.Unity.UpdateMode value);
            /*0x73c211c*/ System.Collections.Generic.List<UnityEngine.Transform> get_SeparatorParts();
            /*0x73c2360*/ void add_assignMeshOverrideSingle(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73c2400*/ void remove_assignMeshOverrideSingle(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73c24a0*/ void add_assignMeshOverrideMultiple(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73c2540*/ void remove_assignMeshOverrideMultiple(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73c25e0*/ void add_AssignMeshOverrideSingleRenderer(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73c2614*/ void remove_AssignMeshOverrideSingleRenderer(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73c2648*/ void add_AssignMeshOverrideMultipleRenderers(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73c267c*/ void remove_AssignMeshOverrideMultipleRenderers(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73c26b0*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Texture> get_CustomTextureOverride();
            /*0x73c26b8*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Material> get_CustomMaterialOverride();
            /*0x73c26c0*/ UnityEngine.Texture get_OverrideTexture();
            /*0x73c26c8*/ void set_OverrideTexture(UnityEngine.Texture value);
            /*0x73c2724*/ UnityEngine.Texture get_mainTexture();
            /*0x73c279c*/ void Awake();
            /*0x73c2b94*/ void OnDestroy();
            /*0x73c2ccc*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x73c2fa0*/ void OnDisable();
            /*0x73c30f8*/ void Update();
            /*0x73c3150*/ void FixedUpdate();
            /*0x73c31a8*/ void Update(float deltaTime);
            /*0x73c2898*/ void SyncSubmeshGraphicsWithCanvasRenderers();
            /*0x73c3200*/ void UpdateAnimationStatus(float deltaTime);
            /*0x73c328c*/ void ApplyTransformMovementToPhysics();
            /*0x73c3474*/ UnityEngine.Vector2 GetPhysicsTransformPosition();
            /*0x73c358c*/ float GetPhysicsTransformRotation();
            /*0x73c3760*/ void ApplyAnimation();
            /*0x73c37d0*/ void AfterAnimationApplied();
            /*0x73c3870*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
            /*0x73c388c*/ void LateUpdate();
            /*0x73c3948*/ void OnCullStateChanged(bool culled);
            /*0x73c396c*/ void OnBecameVisible();
            /*0x73c3960*/ void OnBecameInvisible();
            /*0x73c3978*/ void ReapplySeparatorSlotNames();
            /*0x73b8f20*/ Spine.Skeleton get_Skeleton();
            /*0x73c3d18*/ void set_Skeleton(Spine.Skeleton value);
            /*0x73c3d28*/ Spine.SkeletonData get_SkeletonData();
            /*0x73b9094*/ bool get_IsValid();
            /*0x73bb0a8*/ void add_OnRebuild(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73bb008*/ void remove_OnRebuild(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73c3d54*/ void add_OnInstructionsPrepared(Spine.Unity.SkeletonGraphic.InstructionDelegate value);
            /*0x73c3df4*/ void remove_OnInstructionsPrepared(Spine.Unity.SkeletonGraphic.InstructionDelegate value);
            /*0x73c3e94*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73c3f34*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73c3fd4*/ Spine.AnimationState get_AnimationState();
            /*0x73c3ff0*/ UnityEngine.Vector2 get_PhysicsPositionInheritanceFactor();
            /*0x73c3ffc*/ void set_PhysicsPositionInheritanceFactor(UnityEngine.Vector2 value);
            /*0x73c40dc*/ float get_PhysicsRotationInheritanceFactor();
            /*0x73c40e4*/ void set_PhysicsRotationInheritanceFactor(float value);
            /*0x73c413c*/ UnityEngine.Transform get_PhysicsMovementRelativeTo();
            /*0x73c4144*/ void set_PhysicsMovementRelativeTo(UnityEngine.Transform value);
            /*0x73c40c0*/ void ResetLastPosition();
            /*0x73c4124*/ void ResetLastRotation();
            /*0x73c41ec*/ void ResetLastPositionAndRotation();
            /*0x73c4214*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x73c421c*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73c4238*/ Spine.ExposedList<UnityEngine.Mesh> get_MeshesMultipleCanvasRenderers();
            /*0x73c4240*/ Spine.ExposedList<UnityEngine.Material> get_MaterialsMultipleCanvasRenderers();
            /*0x73c4248*/ Spine.ExposedList<UnityEngine.Texture> get_TexturesMultipleCanvasRenderers();
            /*0x73c4250*/ UnityEngine.Mesh GetLastMesh();
            /*0x73c42ac*/ bool MatchRectTransformWithBounds();
            /*0x73c4308*/ bool MatchRectTransformSingleRenderer();
            /*0x73c44b0*/ bool MatchRectTransformMultipleRenderers();
            /*0x73c4854*/ void SetRectTransformBounds(UnityEngine.Bounds combinedBounds);
            /*0x73c4da0*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c4e40*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c4ee0*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c4f80*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c5020*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c50c0*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c5160*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c5200*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c52a0*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c5340*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c53e0*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73c53e8*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73c53f0*/ bool get_UnscaledTime();
            /*0x73c53f8*/ void set_UnscaledTime(bool value);
            /*0x73c5404*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73c54a4*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73c2bb0*/ void Clear();
            /*0x73c576c*/ void TrimRenderers();
            /*0x73bb150*/ void Initialize(bool overwrite);
            /*0x73c2d5c*/ void PrepareInstructionsAndRenderers(bool isInRebuild);
            /*0x73c392c*/ void UpdateMesh();
            /*0x73c2f00*/ void UpdateMeshToInstructions();
            /*0x73c7d04*/ bool HasMultipleSubmeshInstructions();
            /*0x73c5aa0*/ void InitMeshBuffers();
            /*0x73c56d4*/ void DisposeMeshBuffers();
            /*0x73c6c80*/ void UpdateMeshSingleCanvasRenderer(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73c7190*/ void UpdateMaterialsMultipleCanvasRenderers(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73c76e4*/ void UpdateMeshMultipleCanvasRenderers(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73c7ddc*/ void HandleOnDemandLoading();
            /*0x73c5c3c*/ void EnsureCanvasRendererCount(int targetCount);
            /*0x73c663c*/ void PrepareRendererGameObjects(Spine.Unity.SkeletonRendererInstruction currentInstructions, bool isInRebuild);
            /*0x73c5b70*/ void DisableUnusedCanvasRenderers(int usedCount, bool isInRebuild);
            /*0x73c60d4*/ void EnsureMeshesCount(int targetCount);
            /*0x73c6184*/ void EnsureUsedTexturesAndMaterialsCount(int targetCount);
            /*0x73c5544*/ void DestroyMeshes();
            /*0x73c6278*/ void EnsureSeparatorPartCount();
            /*0x73c3b0c*/ void UpdateSeparatorPartParents();
            /*0x73c7d74*/ float GetLayoutScale(Spine.Unity.SkeletonGraphic.LayoutMode mode);
            /*0x73c8054*/ Spine.Unity.SkeletonGraphic.LayoutMode GetEffectiveLayoutMode(Spine.Unity.SkeletonGraphic.LayoutMode mode);
            /*0x73c8028*/ UnityEngine.Vector2 GetCurrentRectSize();

            enum LayoutMode
            {
                None = 0,
                WidthControlsHeight = 1,
                HeightControlsWidth = 2,
                FitInParent = 3,
                EnvelopeParent = 4,
            }

            class MeshAssignmentDelegateSingle : System.MulticastDelegate
            {
                /*0x73c855c*/ MeshAssignmentDelegateSingle(object object, nint method);
                /*0x73c8610*/ void Invoke(UnityEngine.Mesh mesh, UnityEngine.Material graphicMaterial, UnityEngine.Texture texture);
            }

            class MeshAssignmentDelegateMultiple : System.MulticastDelegate
            {
                /*0x73c8624*/ MeshAssignmentDelegateMultiple(object object, nint method);
                /*0x73c86c4*/ void Invoke(int meshCount, UnityEngine.Mesh[] meshes, UnityEngine.Material[] graphicMaterials, UnityEngine.Texture[] textures);
            }

            class SkeletonRendererDelegate : System.MulticastDelegate
            {
                /*0x73c86d8*/ SkeletonRendererDelegate(object object, nint method);
                /*0x73c87e0*/ void Invoke(Spine.Unity.SkeletonGraphic skeletonGraphic);
            }

            class InstructionDelegate : System.MulticastDelegate
            {
                /*0x73c87f4*/ InstructionDelegate(object object, nint method);
                /*0x73c88fc*/ void Invoke(Spine.Unity.SkeletonRendererInstruction instruction);
            }
        }

        class SkeletonMecanim : Spine.Unity.SkeletonRenderer, Spine.Unity.ISkeletonAnimation, Spine.Unity.ISpineComponent
        {
            /*0x110*/ Spine.Unity.SkeletonMecanim.MecanimTranslator translator;
            /*0x118*/ bool wasUpdatedAfterInit;
            /*0x120*/ Spine.Unity.ISkeletonAnimationDelegate _OnAnimationRebuild;
            /*0x128*/ Spine.Unity.UpdateBonesDelegate _BeforeApply;
            /*0x130*/ Spine.Unity.UpdateBonesDelegate _UpdateLocal;
            /*0x138*/ Spine.Unity.UpdateBonesDelegate _UpdateWorld;
            /*0x140*/ Spine.Unity.UpdateBonesDelegate _UpdateComplete;
            /*0x148*/ Spine.Unity.UpdateTiming updateTiming;

            /*0x73cab4c*/ SkeletonMecanim();
            /*0x73c8910*/ Spine.Unity.SkeletonMecanim.MecanimTranslator get_Translator();
            /*0x73c8918*/ void add__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c89b8*/ void remove__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c8a58*/ void add__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8af8*/ void remove__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8b98*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8c38*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8cd8*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8d78*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8e18*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8eb8*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f58*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c8f5c*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73c8f60*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f64*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f68*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f6c*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f70*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f74*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f78*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f7c*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73c8f80*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73c8f88*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73c8f90*/ void Initialize(bool overwrite, bool quiet);
            /*0x73c9924*/ void Update();
            /*0x73c99bc*/ void FixedUpdate();
            /*0x73c99f4*/ void Update(float deltaTime);
            /*0x73c995c*/ void UpdateAnimation(float deltaTime);
            /*0x73c9a04*/ void ApplyAnimation();
            /*0x73ca93c*/ void AfterAnimationApplied();
            /*0x73ca9e8*/ void LateUpdate();
            /*0x73caae8*/ void OnBecameVisible();

            class MecanimTranslator
            {
                static float WeightEpsilon = 0.00009999999747378752;
                /*0x10*/ bool autoReset;
                /*0x11*/ bool useCustomMixMode;
                /*0x18*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.MixMode[] layerMixModes;
                /*0x20*/ Spine.MixBlend[] layerBlendModes;
                /*0x28*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate _OnClipApplied;
                /*0x30*/ System.Collections.Generic.Dictionary<int, Spine.Animation> animationTable;
                /*0x38*/ System.Collections.Generic.Dictionary<UnityEngine.AnimationClip, int> clipNameHashCodeTable;
                /*0x40*/ System.Collections.Generic.List<Spine.Animation> previousAnimations;
                /*0x48*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.ClipInfos[] layerClipInfos;
                /*0x50*/ UnityEngine.Animator animator;

                static /*0x73cb3d0*/ float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
                static /*0x73cbf60*/ float ToSpineAnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
                /*0x73c9484*/ MecanimTranslator();
                /*0x73cae40*/ void add__OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73caedc*/ void remove__OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73caf78*/ void add_OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73caf7c*/ void remove_OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73caf80*/ UnityEngine.Animator get_Animator();
                /*0x73c96bc*/ void Initialize(UnityEngine.Animator animator, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
                /*0x73cb0d8*/ bool ApplyAnimation(Spine.Skeleton skeleton, UnityEngine.AnimatorClipInfo info, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, Spine.MixBlend layerBlendMode, bool useClipWeight1);
                /*0x73cb528*/ bool ApplyInterruptionAnimation(Spine.Skeleton skeleton, bool interpolateWeightTo1, UnityEngine.AnimatorClipInfo info, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, Spine.MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1);
                /*0x73cb43c*/ void OnClipAppliedCallback(Spine.Animation clip, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight);
                /*0x73c9a54*/ void Apply(Spine.Skeleton skeleton);
                /*0x73cbd58*/ System.Collections.Generic.KeyValuePair<Spine.Animation, float> GetActiveAnimationAndTime(int layer);
                /*0x73cb75c*/ void InitClipInfosForLayers();
                /*0x73caf88*/ void ClearClipInfosForLayers();
                /*0x73cbcfc*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.MixMode GetMixMode(int layer, Spine.MixBlend layerBlendMode);
                /*0x73cb8b0*/ void GetStateUpdatesFromAnimator(int layer);
                /*0x73cbbb8*/ void GetAnimatorClipInfos(int layer, ref bool isInterruptionActive, ref int clipInfoCount, ref int nextClipInfoCount, ref int interruptingClipInfoCount, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> clipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> nextClipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> interruptingClipInfo, ref bool shallInterpolateWeightTo1);
                /*0x73cbc70*/ void GetAnimatorStateInfos(int layer, ref bool isInterruptionActive, ref UnityEngine.AnimatorStateInfo stateInfo, ref UnityEngine.AnimatorStateInfo nextStateInfo, ref UnityEngine.AnimatorStateInfo interruptingStateInfo, ref float interruptingClipTimeAddition);
                /*0x73cb2dc*/ Spine.Animation GetAnimation(UnityEngine.AnimationClip clip);

                class OnClipAppliedDelegate : System.MulticastDelegate
                {
                    /*0x73cc080*/ OnClipAppliedDelegate(object object, nint method);
                    /*0x73cc18c*/ void Invoke(Spine.Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward);
                }

                enum MixMode
                {
                    AlwaysMix = 0,
                    MixNext = 1,
                    Hard = 2,
                }

                class ClipInfos
                {
                    /*0x10*/ bool isInterruptionActive;
                    /*0x11*/ bool isLastFrameOfInterruption;
                    /*0x14*/ int clipInfoCount;
                    /*0x18*/ int nextClipInfoCount;
                    /*0x1c*/ int interruptingClipInfoCount;
                    /*0x20*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clipInfos;
                    /*0x28*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> nextClipInfos;
                    /*0x30*/ System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> interruptingClipInfos;
                    /*0x38*/ UnityEngine.AnimatorStateInfo stateInfo;
                    /*0x5c*/ UnityEngine.AnimatorStateInfo nextStateInfo;
                    /*0x80*/ UnityEngine.AnimatorStateInfo interruptingStateInfo;
                    /*0xa4*/ float interruptingClipTimeAddition;

                    /*0x73cbfb0*/ ClipInfos();
                }

                class AnimationClipEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip> Instance;

                    static /*0x73cc20c*/ AnimationClipEqualityComparer();
                    /*0x73cc204*/ AnimationClipEqualityComparer();
                    /*0x73cc1a4*/ bool Equals(UnityEngine.AnimationClip x, UnityEngine.AnimationClip y);
                    /*0x73cc1ec*/ int GetHashCode(UnityEngine.AnimationClip o);
                }

                class IntEqualityComparer : System.Collections.Generic.IEqualityComparer<int>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<int> Instance;

                    static /*0x73cc290*/ IntEqualityComparer();
                    /*0x73cc288*/ IntEqualityComparer();
                    /*0x73cc274*/ bool Equals(int x, int y);
                    /*0x73cc280*/ int GetHashCode(int o);
                }
            }
        }

        class SkeletonRenderer : UnityEngine.MonoBehaviour, Spine.Unity.ISkeletonComponent, Spine.Unity.ISpineComponent, Spine.Unity.IHasSkeletonDataAsset
        {
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = 8;
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = 4;
            static UnityEngine.Rendering.CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = 5;
            static /*0x0*/ int STENCIL_COMP_PARAM_ID;
            static /*0x4*/ int SUBMESH_DUMMY_PARAM_ID;
            /*0x20*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x28*/ string initialSkinName;
            /*0x30*/ bool initialFlipX;
            /*0x31*/ bool initialFlipY;
            /*0x34*/ Spine.Unity.UpdateMode updateMode;
            /*0x38*/ Spine.Unity.UpdateMode updateWhenInvisible;
            /*0x40*/ string[] separatorSlotNames;
            /*0x48*/ System.Collections.Generic.List<Spine.Slot> separatorSlots;
            /*0x50*/ float zSpacing;
            /*0x54*/ bool useClipping;
            /*0x55*/ bool immutableTriangles;
            /*0x56*/ bool pmaVertexColors;
            /*0x57*/ bool clearStateOnDisable;
            /*0x58*/ bool tintBlack;
            /*0x59*/ bool singleSubmesh;
            /*0x5a*/ bool fixDrawOrder;
            /*0x5b*/ bool addNormals;
            /*0x5c*/ bool calculateTangents;
            /*0x60*/ UnityEngine.SpriteMaskInteraction maskInteraction;
            /*0x68*/ Spine.Unity.SkeletonRenderer.SpriteMaskInteractionMaterials maskMaterials;
            /*0x70*/ bool disableRenderingOnOverride;
            /*0x78*/ Spine.Unity.SkeletonRenderer.InstructionDelegate generateMeshOverride;
            /*0x80*/ Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;
            /*0x88*/ System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride;
            /*0x90*/ System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials;
            /*0x98*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;
            /*0xa0*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0xa8*/ Spine.Unity.MeshRendererBuffers rendererBuffers;
            /*0xb0*/ UnityEngine.MeshRenderer meshRenderer;
            /*0xb8*/ UnityEngine.MeshFilter meshFilter;
            /*0xc0*/ bool valid;
            /*0xc8*/ Spine.Skeleton skeleton;
            /*0xd0*/ UnityEngine.Vector2 physicsPositionInheritanceFactor;
            /*0xd8*/ float physicsRotationInheritanceFactor;
            /*0xe0*/ UnityEngine.Transform physicsMovementRelativeTo;
            /*0xe8*/ UnityEngine.Vector2 lastPosition;
            /*0xf0*/ float lastRotation;
            /*0xf8*/ Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate OnRebuild;
            /*0x100*/ Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated;
            /*0x108*/ UnityEngine.MaterialPropertyBlock reusedPropertyBlock;

            static /*0x73d2370*/ SkeletonRenderer();
            static /*0x3910ae8*/ T NewSpineGameObject<T>(Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            static /*0x3910ae8*/ T AddSpineComponent<T>(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            /*0x73cabac*/ SkeletonRenderer();
            /*0x73cc2f8*/ Spine.Unity.UpdateMode get_UpdateMode();
            /*0x73cc300*/ void set_UpdateMode(Spine.Unity.UpdateMode value);
            /*0x73cc308*/ void add_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73cc3a4*/ void remove_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73cc440*/ void add_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73cc4fc*/ void remove_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73cc5b8*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73cc654*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73cc6f0*/ System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> get_CustomMaterialOverride();
            /*0x73cc6f8*/ System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> get_CustomSlotMaterials();
            /*0x73cc700*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73cc71c*/ Spine.Skeleton get_Skeleton();
            /*0x73cc744*/ UnityEngine.Vector2 get_PhysicsPositionInheritanceFactor();
            /*0x73cc74c*/ void set_PhysicsPositionInheritanceFactor(UnityEngine.Vector2 value);
            /*0x73cc81c*/ float get_PhysicsRotationInheritanceFactor();
            /*0x73cc824*/ void set_PhysicsRotationInheritanceFactor(float value);
            /*0x73cc87c*/ UnityEngine.Transform get_PhysicsMovementRelativeTo();
            /*0x73cc884*/ void set_PhysicsMovementRelativeTo(UnityEngine.Transform value);
            /*0x73cc804*/ void ResetLastPosition();
            /*0x73cc864*/ void ResetLastRotation();
            /*0x73ccc18*/ void ResetLastPositionAndRotation();
            /*0x73ccc3c*/ void add_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73cccd8*/ void remove_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73ccd74*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73cce14*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73cceb4*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x73ccebc*/ void SetMeshSettings(Spine.Unity.MeshGenerator.Settings settings);
            /*0x73ccf0c*/ void Awake();
            /*0x73ccf48*/ void OnDisable();
            /*0x73ccf68*/ void OnDestroy();
            /*0x73ccf90*/ void ClearState();
            /*0x73cd068*/ void EnsureMeshGeneratorCapacity(int minimumVertexCount);
            /*0x73c9098*/ void Initialize(bool overwrite, bool quiet);
            /*0x73cd3f0*/ void ApplyTransformMovementToPhysics();
            /*0x73cc92c*/ UnityEngine.Vector2 GetPhysicsTransformPosition();
            /*0x73cca44*/ float GetPhysicsTransformRotation();
            /*0x73cd5b8*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
            /*0x73caac4*/ void LateUpdate();
            /*0x73cd5d4*/ void LateUpdateMesh();
            /*0x73d16bc*/ void OnBecameVisible();
            /*0x73d16e0*/ void OnBecameInvisible();
            /*0x73d16ec*/ void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators, bool updateStringArray);
            /*0x73d17f8*/ void FindAndApplySeparatorSlots(System.Func<string, bool> slotNamePredicate, bool clearExistingSeparators, bool updateStringArray);
            /*0x73d1d00*/ void ReapplySeparatorSlotNames();
            /*0x73d10d4*/ void AssignSpriteMaskMaterials();
            /*0x73d1e48*/ bool InitSpriteMaskMaterialsInsideMask();
            /*0x73d1e70*/ bool InitSpriteMaskMaterialsOutsideMask();
            /*0x73d1e98*/ bool InitSpriteMaskMaterialsForMaskType(UnityEngine.Rendering.CompareFunction maskFunction, ref UnityEngine.Material[] materialsToFill);
            /*0x73d12dc*/ void HandleOnDemandLoading();
            /*0x73d14c4*/ void SetMaterialSettingsToFixDrawOrder();

            class SpriteMaskInteractionMaterials
            {
                /*0x10*/ UnityEngine.Material[] materialsMaskDisabled;
                /*0x18*/ UnityEngine.Material[] materialsInsideMask;
                /*0x20*/ UnityEngine.Material[] materialsOutsideMask;

                /*0x73d0e90*/ SpriteMaskInteractionMaterials();
                /*0x73d0e44*/ bool get_AnyMaterialCreated();
            }

            class InstructionDelegate : System.MulticastDelegate
            {
                /*0x73d240c*/ InstructionDelegate(object object, nint method);
                /*0x73d2514*/ void Invoke(Spine.Unity.SkeletonRendererInstruction instruction);
            }

            class SkeletonRendererDelegate : System.MulticastDelegate
            {
                /*0x73d2528*/ SkeletonRendererDelegate(object object, nint method);
                /*0x73d2630*/ void Invoke(Spine.Unity.SkeletonRenderer skeletonRenderer);
            }

            class <>c__DisplayClass99_0
            {
                /*0x10*/ string startsWith;

                /*0x73d17f0*/ <>c__DisplayClass99_0();
                /*0x73d2644*/ bool <FindAndApplySeparatorSlots>b__0(string slotName);
            }
        }

        class SkeletonGraphicCustomMaterials : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride> customTextureOverrides;

            /*0x73d2e98*/ SkeletonGraphicCustomMaterials();
            /*0x73d2668*/ void SetCustomMaterialOverrides();
            /*0x73d27c4*/ void RemoveCustomMaterialOverrides();
            /*0x73d2980*/ void SetCustomTextureOverrides();
            /*0x73d2adc*/ void RemoveCustomTextureOverrides();
            /*0x73d2c98*/ void OnEnable();
            /*0x73d2dd8*/ void OnDisable();

            struct AtlasMaterialOverride : System.IEquatable<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride>
            {
                /*0x10*/ bool overrideEnabled;
                /*0x18*/ UnityEngine.Texture originalTexture;
                /*0x20*/ UnityEngine.Material replacementMaterial;

                /*0x73d2f74*/ bool Equals(Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride other);
            }

            struct AtlasTextureOverride : System.IEquatable<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride>
            {
                /*0x10*/ bool overrideEnabled;
                /*0x18*/ UnityEngine.Texture originalTexture;
                /*0x20*/ UnityEngine.Texture replacementTexture;

                /*0x73d3038*/ bool Equals(Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride other);
            }
        }

        class SkeletonRendererCustomMaterials : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;

            /*0x73d39ac*/ SkeletonRendererCustomMaterials();
            /*0x73d30fc*/ void SetCustomSlotMaterials();
            /*0x73d329c*/ void RemoveCustomSlotMaterials();
            /*0x73d348c*/ void SetCustomMaterialOverrides();
            /*0x73d35e8*/ void RemoveCustomMaterialOverrides();
            /*0x73d37a4*/ void OnEnable();
            /*0x73d38ec*/ void OnDisable();

            struct SlotMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ string slotName;
                /*0x20*/ UnityEngine.Material material;

                /*0x73d3a88*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride other);
            }

            struct AtlasMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ UnityEngine.Material originalMaterial;
                /*0x20*/ UnityEngine.Material replacementMaterial;

                /*0x73d3b28*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride other);
            }
        }

        class SkeletonPartsRenderer : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.MeshGenerator meshGenerator;
            /*0x28*/ UnityEngine.MeshRenderer meshRenderer;
            /*0x30*/ UnityEngine.MeshFilter meshFilter;
            /*0x38*/ Spine.Unity.SkeletonPartsRenderer.SkeletonPartsRendererDelegate OnMeshAndMaterialsUpdated;
            /*0x40*/ Spine.Unity.MeshRendererBuffers buffers;
            /*0x48*/ Spine.Unity.SkeletonRendererInstruction currentInstructions;

            static /*0x73d418c*/ Spine.Unity.SkeletonPartsRenderer NewPartsRendererGameObject(UnityEngine.Transform parent, string name, int sortingOrder);
            /*0x73d4370*/ SkeletonPartsRenderer();
            /*0x73d3bec*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x73d3d40*/ UnityEngine.MeshRenderer get_MeshRenderer();
            /*0x73d3d58*/ UnityEngine.MeshFilter get_MeshFilter();
            /*0x73d3d70*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonPartsRenderer.SkeletonPartsRendererDelegate value);
            /*0x73d3e0c*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonPartsRenderer.SkeletonPartsRendererDelegate value);
            /*0x73d3c04*/ void LazyIntialize();
            /*0x73d3ea8*/ void OnDestroy();
            /*0x73d3ebc*/ void ClearMesh();
            /*0x73d3ee4*/ void RenderParts(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x73d4158*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock block);

            class SkeletonPartsRendererDelegate : System.MulticastDelegate
            {
                /*0x73d43dc*/ SkeletonPartsRendererDelegate(object object, nint method);
                /*0x73d44e4*/ void Invoke(Spine.Unity.SkeletonPartsRenderer skeletonPartsRenderer);
            }
        }

        class SkeletonRenderSeparator : UnityEngine.MonoBehaviour
        {
            static int DefaultSortingOrderIncrement = 5;
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ UnityEngine.MeshRenderer mainMeshRenderer;
            /*0x30*/ bool copyPropertyBlock;
            /*0x31*/ bool copyMeshRendererFlags;
            /*0x38*/ System.Collections.Generic.List<Spine.Unity.SkeletonPartsRenderer> partsRenderers;
            /*0x40*/ bool isVisible;
            /*0x48*/ Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated;
            /*0x50*/ UnityEngine.MaterialPropertyBlock copiedBlock;

            static /*0x73d4764*/ Spine.Unity.SkeletonRenderSeparator AddToSkeletonRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer, int sortingLayerID, int extraPartsRenderers, int sortingOrderIncrement, int baseSortingOrder, bool addMinimumPartsRenderers);
            /*0x73d56c0*/ SkeletonRenderSeparator();
            /*0x73d44f8*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73d4500*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x73d462c*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73d46c8*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73d4d28*/ Spine.Unity.SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement, string name);
            /*0x73d49d8*/ void OnEnable();
            /*0x73d4ef0*/ void Update();
            /*0x73d5110*/ void OnDisable();
            /*0x73d4ef4*/ void UpdateVisibility();
            /*0x73d5388*/ void HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            /*0x73d51f4*/ void ClearPartsRendererMeshes();
        }

        class ActivateBasedOnFlipDirection : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x30*/ UnityEngine.GameObject activeOnNormalX;
            /*0x38*/ UnityEngine.GameObject activeOnFlippedX;
            /*0x40*/ UnityEngine.HingeJoint2D[] jointsNormalX;
            /*0x48*/ UnityEngine.HingeJoint2D[] jointsFlippedX;
            /*0x50*/ Spine.Unity.ISkeletonComponent skeletonComponent;
            /*0x58*/ bool wasFlippedXBefore;

            /*0x73d5b48*/ ActivateBasedOnFlipDirection();
            /*0x73d5758*/ void Start();
            /*0x73d5838*/ void FixedUpdate();
            /*0x73d590c*/ void HandleFlip(bool isFlippedX);
            /*0x73d59c4*/ void ResetJointPositions(UnityEngine.HingeJoint2D[] joints);
            /*0x73d5a80*/ void CompensateMovementAfterFlipX(UnityEngine.Transform toActivate, UnityEngine.Transform toDeactivate);
        }

        class FollowLocationRigidbody : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ UnityEngine.Rigidbody ownRigidbody;

            /*0x73d5c08*/ FollowLocationRigidbody();
            /*0x73d5b50*/ void Awake();
            /*0x73d5ba8*/ void FixedUpdate();
        }

        class FollowLocationRigidbody2D : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ bool followFlippedX;
            /*0x30*/ UnityEngine.Rigidbody2D ownRigidbody;

            /*0x73d5d1c*/ FollowLocationRigidbody2D();
            /*0x73d5c10*/ void Awake();
            /*0x73d5c68*/ void FixedUpdate();
        }

        class FollowSkeletonUtilityRootRotation : UnityEngine.MonoBehaviour
        {
            static float FLIP_ANGLE_THRESHOLD = 100;
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ UnityEngine.Vector3 prevLocalEulerAngles;

            /*0x73d5fcc*/ FollowSkeletonUtilityRootRotation();
            /*0x73d5d24*/ void Start();
            /*0x73d5d54*/ void FixedUpdate();
            /*0x73d5e3c*/ void CompensatePositionToYRotation();
            /*0x73d5f04*/ void CompensatePositionToXRotation();
        }

        class SkeletonUtility : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate OnReset;
            /*0x28*/ UnityEngine.Transform boneRoot;
            /*0x30*/ bool flipBy180DegreeRotation;
            /*0x38*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x40*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x48*/ Spine.Unity.ISkeletonAnimation skeletonAnimation;
            /*0x50*/ Spine.Unity.ISkeletonComponent skeletonComponent;
            /*0x58*/ System.Collections.Generic.List<Spine.Unity.SkeletonUtilityBone> boneComponents;
            /*0x60*/ System.Collections.Generic.List<Spine.Unity.SkeletonUtilityConstraint> constraintComponents;
            /*0x68*/ float positionScale;
            /*0x6c*/ float lastPositionScale;
            /*0x70*/ UnityEngine.Vector2 positionOffset;
            /*0x78*/ bool hasOverrideBones;
            /*0x79*/ bool hasConstraints;
            /*0x7a*/ bool needToReprocessBones;

            static /*0x73d5fd4*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(Spine.Skeleton skeleton, string skinName, string slotName, string attachmentName, UnityEngine.Transform parent, bool isTrigger);
            static /*0x73d6310*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(string name, Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.Transform parent, bool isTrigger);
            static /*0x73d64cc*/ UnityEngine.PolygonCollider2D AddBoundingBoxAsComponent(Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.GameObject gameObject, bool isTrigger);
            static /*0x73d656c*/ void SetColliderPointsLocal(UnityEngine.PolygonCollider2D collider, Spine.Slot slot, Spine.BoundingBoxAttachment box, float scale);
            static /*0x73d66a4*/ UnityEngine.Bounds GetBoundingBoxBounds(Spine.BoundingBoxAttachment boundingBox, float depth);
            static /*0x73d6798*/ UnityEngine.Rigidbody2D AddBoneRigidbody2D(UnityEngine.GameObject gameObject, bool isKinematic, float gravityScale);
            /*0x73d985c*/ SkeletonUtility();
            /*0x73d6884*/ void add_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x73d6920*/ void remove_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x73d69bc*/ void Update();
            /*0x73d6c40*/ void UpdateToMeshScaleAndOffset(Spine.Unity.MeshGeneratorBuffers ignoredParameter);
            /*0x73d6f10*/ Spine.Unity.ISkeletonComponent get_SkeletonComponent();
            /*0x73d6ff4*/ Spine.Skeleton get_Skeleton();
            /*0x73d70ac*/ bool get_IsValid();
            /*0x73d7174*/ float get_PositionScale();
            /*0x73d717c*/ UnityEngine.Vector2 get_PositionOffset();
            /*0x73d7184*/ void ResubscribeEvents();
            /*0x73d719c*/ void ResubscribeIndependentEvents();
            /*0x73d7520*/ void ResubscribeDependentEvents();
            /*0x73d7980*/ void OnEnable();
            /*0x73d7ff0*/ void Start();
            /*0x73d7ff4*/ void OnDisable();
            /*0x73d8390*/ void HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            /*0x73d83bc*/ void HandleRendererReset(Spine.Unity.SkeletonGraphic g);
            /*0x73d83e8*/ void RegisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x73d84c8*/ void UnregisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x73d8520*/ void RegisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x73d8600*/ void UnregisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x73d7bd4*/ void CollectBones();
            /*0x73d6da0*/ void UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
            /*0x73d6e5c*/ void UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
            /*0x73d6f08*/ void UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
            /*0x73d8e8c*/ void UpdateAllBones(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x73d8f6c*/ UnityEngine.Transform GetBoneRoot();
            /*0x73d9198*/ UnityEngine.GameObject SpawnRoot(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73d94f0*/ UnityEngine.GameObject SpawnHierarchy(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73d95f8*/ UnityEngine.GameObject SpawnBoneRecursively(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73d92a0*/ UnityEngine.GameObject SpawnBone(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);

            class SkeletonUtilityDelegate : System.MulticastDelegate
            {
                /*0x73d997c*/ SkeletonUtilityDelegate(object object, nint method);
                /*0x73d9a18*/ void Invoke();
            }
        }

        class SkeletonUtilityBone : UnityEngine.MonoBehaviour
        {
            /*0x20*/ string boneName;
            /*0x28*/ UnityEngine.Transform parentReference;
            /*0x30*/ Spine.Unity.SkeletonUtilityBone.Mode mode;
            /*0x34*/ bool position;
            /*0x35*/ bool rotation;
            /*0x36*/ bool scale;
            /*0x37*/ bool zPosition;
            /*0x38*/ float overrideAlpha;
            /*0x40*/ Spine.Unity.SkeletonUtility hierarchy;
            /*0x48*/ Spine.Bone bone;
            /*0x50*/ bool transformLerpComplete;
            /*0x51*/ bool valid;
            /*0x58*/ UnityEngine.Transform cachedTransform;
            /*0x60*/ UnityEngine.Transform skeletonTransform;
            /*0x68*/ bool incompatibleTransformMode;

            static /*0x73d9c5c*/ bool BoneTransformModeIncompatible(Spine.Bone bone);
            /*0x73d9d0c*/ SkeletonUtilityBone();
            /*0x73d9a2c*/ bool get_IncompatibleTransformMode();
            /*0x73d96e4*/ void Reset();
            /*0x73d9a34*/ void OnEnable();
            /*0x73d9b80*/ void HandleOnReset();
            /*0x73d9b84*/ void OnDisable();
            /*0x73d8658*/ void DoUpdate(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x73d9c8c*/ void AddBoundingBox(string skinName, string slotName, string attachmentName);

            enum Mode
            {
                Follow = 0,
                Override = 1,
            }

            enum UpdatePhase
            {
                Local = 0,
                World = 1,
                Complete = 2,
            }
        }

        class SkeletonUtilityConstraint : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonUtilityBone bone;
            /*0x28*/ Spine.Unity.SkeletonUtility hierarchy;

            /*0x73d9dec*/ SkeletonUtilityConstraint();
            /*0x73d9d24*/ void OnEnable();
            /*0x73d9dd0*/ void OnDisable();
            /*0x38159dc*/ void DoUpdate();
        }

        enum UpdateMode
        {
            Nothing = 0,
            OnlyAnimationStatus = 1,
            OnlyEventTimelines = 4,
            EverythingExceptMesh = 2,
            FullUpdate = 3,
        }

        enum UpdateTiming
        {
            ManualUpdate = 0,
            InUpdate = 1,
            InFixedUpdate = 2,
            InLateUpdate = 3,
        }

        class ISkeletonAnimationDelegate : System.MulticastDelegate
        {
            /*0x73d9df4*/ ISkeletonAnimationDelegate(object object, nint method);
            /*0x73d9efc*/ void Invoke(Spine.Unity.ISkeletonAnimation animated);
        }

        class UpdateBonesDelegate : System.MulticastDelegate
        {
            /*0x73d7878*/ UpdateBonesDelegate(object object, nint method);
            /*0x73d9f10*/ void Invoke(Spine.Unity.ISkeletonAnimation animated);
        }

        interface ISpineComponent
        {
        }

        interface ISkeletonAnimation : Spine.Unity.ISpineComponent
        {
            /*0x3816710*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x3816710*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x3816710*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x3816710*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x3816710*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x3816710*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x3816710*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x3816710*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x3814574*/ Spine.Unity.UpdateTiming get_UpdateTiming();
        }

        interface IHasSkeletonDataAsset : Spine.Unity.ISpineComponent
        {
        }

        interface ISkeletonComponent : Spine.Unity.ISpineComponent
        {
            /*0x38148bc*/ Spine.Skeleton get_Skeleton();
        }

        interface IAnimationStateComponent : Spine.Unity.ISpineComponent
        {
            /*0x38148bc*/ Spine.AnimationState get_AnimationState();
        }

        class DoubleBuffered<T>
        {
            /*0x0*/ T a;
            /*0x0*/ T b;
            /*0x0*/ bool usingA;

            /*0x38159dc*/ DoubleBuffered();
            /*0x3910ae8*/ T GetCurrent();
            /*0x3910ae8*/ T GetNext();
        }

        class MeshGeneratorDelegate : System.MulticastDelegate
        {
            /*0x73d77d8*/ MeshGeneratorDelegate(object object, nint method);
            /*0x73d9f24*/ void Invoke(Spine.Unity.MeshGeneratorBuffers buffers);
        }

        struct MeshGeneratorBuffers
        {
            /*0x10*/ int vertexCount;
            /*0x18*/ UnityEngine.Vector3[] vertexBuffer;
            /*0x20*/ UnityEngine.Vector2[] uvBuffer;
            /*0x28*/ UnityEngine.Color32[] colorBuffer;
            /*0x30*/ Spine.Unity.MeshGenerator meshGenerator;
        }

        class MeshGenerator
        {
            static float BoundsMinDefault = Infinity;
            static float BoundsMaxDefault = -Infinity;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.Vector3> AttachmentVerts;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Vector2> AttachmentUVs;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Color32> AttachmentColors32;
            static /*0x18*/ System.Collections.Generic.List<int> AttachmentIndices;
            /*0x10*/ Spine.Unity.MeshGenerator.Settings settings;
            /*0x20*/ Spine.ExposedList<UnityEngine.Vector3> vertexBuffer;
            /*0x28*/ Spine.ExposedList<UnityEngine.Vector2> uvBuffer;
            /*0x30*/ Spine.ExposedList<UnityEngine.Color32> colorBuffer;
            /*0x38*/ Spine.ExposedList<Spine.ExposedList<int>> submeshes;
            /*0x40*/ UnityEngine.Vector2 meshBoundsMin;
            /*0x48*/ UnityEngine.Vector2 meshBoundsMax;
            /*0x50*/ float meshBoundsThickness;
            /*0x54*/ int submeshIndex;
            /*0x58*/ Spine.SkeletonClipping clipper;
            /*0x60*/ float[] tempVerts;
            /*0x68*/ int[] regionTriangles;
            /*0x70*/ UnityEngine.Vector3[] normals;
            /*0x78*/ UnityEngine.Vector4[] tangents;
            /*0x80*/ UnityEngine.Vector2[] tempTanBuffer;
            /*0x88*/ Spine.ExposedList<UnityEngine.Vector2> uv2;
            /*0x90*/ Spine.ExposedList<UnityEngine.Vector2> uv3;

            static /*0x73daa1c*/ MeshGenerator();
            static /*0x73cdc14*/ void GenerateSingleSubmeshInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, UnityEngine.Material material);
            static /*0x73d9f68*/ bool RequiresMultipleSubmeshesByDrawOrder(Spine.Skeleton skeleton);
            static /*0x73d00fc*/ void GenerateSkeletonRendererInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials, System.Collections.Generic.List<Spine.Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles);
            static /*0x73ce138*/ void TryReplaceMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> workingSubmeshInstructions, System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride);
            static /*0x73da654*/ void SolveTangents2DEnsureSize(ref UnityEngine.Vector4[] tangentBuffer, ref UnityEngine.Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength);
            static /*0x73da72c*/ void SolveTangents2DTriangles(UnityEngine.Vector2[] tempTanBuffer, int[] triangles, int triangleCount, UnityEngine.Vector3[] vertices, UnityEngine.Vector2[] uvs, int vertexCount);
            static /*0x73da900*/ void SolveTangents2DBuffer(UnityEngine.Vector4[] tangents, UnityEngine.Vector2[] tempTanBuffer, int vertexCount);
            /*0x73d2084*/ MeshGenerator();
            /*0x73d413c*/ int get_VertexCount();
            /*0x73d09e4*/ Spine.Unity.MeshGeneratorBuffers get_Buffers();
            /*0x73d9f60*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73cd318*/ void Begin();
            /*0x73ce254*/ void AddSubmesh(Spine.Unity.SubmeshInstruction instruction, bool updateTriangles);
            /*0x73d0948*/ void BuildMesh(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x73ceeec*/ void BuildMeshWithArrays(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x73da444*/ void ScaleVertexData(float scale);
            /*0x73da4c8*/ void ScaleAndOffsetVertexData(float scale, UnityEngine.Vector2 offset2D);
            /*0x73da574*/ UnityEngine.Bounds GetMeshBounds();
            /*0x73da288*/ void AddAttachmentTintBlack(float r2, float g2, float b2, float a, int vertexCount);
            /*0x73da370*/ void PrepareOptionalUVBuffer(ref Spine.ExposedList<UnityEngine.Vector2> uvBuffer, int vertexCount);
            /*0x73da5d8*/ void ResizeOptionalUVBuffer(ref Spine.ExposedList<UnityEngine.Vector2> uvBuffer, int vertexCount);
            /*0x73d0a90*/ void FillVertexData(UnityEngine.Mesh mesh);
            /*0x73d0f2c*/ void FillLateVertexData(UnityEngine.Mesh mesh);
            /*0x73d0da0*/ void FillTriangles(UnityEngine.Mesh mesh);
            /*0x73cd08c*/ void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack, bool includeTangents, bool includeNormals);

            struct Settings
            {
                /*0x10*/ bool useClipping;
                /*0x14*/ float zSpacing;
                /*0x18*/ bool tintBlack;
                /*0x19*/ bool canvasGroupCompatible;
                /*0x1a*/ bool pmaVertexColors;
                /*0x1b*/ bool addNormals;
                /*0x1c*/ bool calculateTangents;
                /*0x1d*/ bool immutableTriangles;

                static /*0x73dabbc*/ Spine.Unity.MeshGenerator.Settings get_Default();
            }
        }

        class MeshRendererBuffers : System.IDisposable
        {
            /*0x10*/ Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> doubleBufferedMesh;
            /*0x18*/ Spine.ExposedList<UnityEngine.Material> submeshMaterials;
            /*0x20*/ UnityEngine.Material[] sharedMaterials;

            /*0x73db14c*/ MeshRendererBuffers();
            /*0x73dabc8*/ void Initialize();
            /*0x73dace4*/ UnityEngine.Material[] GetUpdatedSharedMaterialsArray();
            /*0x73dad84*/ bool MaterialsChangedInLastUpdate();
            /*0x73dae28*/ void UpdateSharedMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions);
            /*0x73daf58*/ Spine.Unity.MeshRendererBuffers.SmartMesh GetNextMesh();
            /*0x73dafa8*/ void Clear();
            /*0x73db02c*/ void Dispose();

            class SmartMesh : System.IDisposable
            {
                /*0x10*/ UnityEngine.Mesh mesh;
                /*0x18*/ Spine.Unity.SkeletonRendererInstruction instructionUsed;

                /*0x73db28c*/ SmartMesh();
                /*0x73dacb8*/ void Clear();
                /*0x73db0b8*/ void Dispose();
            }
        }

        class SkeletonRendererInstruction
        {
            /*0x10*/ Spine.ExposedList<Spine.Unity.SubmeshInstruction> submeshInstructions;
            /*0x18*/ bool immutableTriangles;
            /*0x19*/ bool hasActiveClipping;
            /*0x1c*/ int rawVertexCount;
            /*0x20*/ Spine.ExposedList<Spine.Attachment> attachments;

            static /*0x73db9bc*/ bool GeometryNotEqual(Spine.Unity.SkeletonRendererInstruction a, Spine.Unity.SkeletonRendererInstruction b);
            /*0x73db3a4*/ SkeletonRendererInstruction();
            /*0x73db204*/ void Clear();
            /*0x73db488*/ void SetWithSubset(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x73db810*/ void Set(Spine.Unity.SkeletonRendererInstruction other);
        }

        class SpineMesh
        {
            static /*0x73db308*/ UnityEngine.Mesh NewSkeletonMesh();
        }

        struct SubmeshInstruction
        {
            /*0x10*/ Spine.Skeleton skeleton;
            /*0x18*/ int startSlot;
            /*0x1c*/ int endSlot;
            /*0x20*/ UnityEngine.Material material;
            /*0x28*/ bool forceSeparate;
            /*0x2c*/ int preActiveClippingSlotSource;
            /*0x30*/ int rawTriangleCount;
            /*0x34*/ int rawVertexCount;
            /*0x38*/ int rawFirstVertexIndex;
            /*0x3c*/ bool hasClipping;
            /*0x3d*/ bool hasPMAAdditiveSlot;

            /*0x73dbb60*/ string ToString();
        }

        class BlendModeMaterialsAsset : Spine.Unity.SkeletonDataModifierAsset
        {
            /*0x18*/ UnityEngine.Material multiplyMaterialTemplate;
            /*0x20*/ UnityEngine.Material screenMaterialTemplate;
            /*0x28*/ UnityEngine.Material additiveMaterialTemplate;
            /*0x30*/ bool applyAdditiveMaterial;

            static /*0x73dbdb0*/ void ApplyMaterials(Spine.SkeletonData skeletonData, UnityEngine.Material multiplyTemplate, UnityEngine.Material screenTemplate, UnityEngine.Material additiveTemplate, bool includeAdditiveSlots);
            /*0x73dc604*/ BlendModeMaterialsAsset();
            /*0x73dbd98*/ void Apply(Spine.SkeletonData skeletonData);

            class AtlasMaterialCache : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<Spine.AtlasPage, UnityEngine.Material>, Spine.AtlasPage> cache;

                /*0x73dc51c*/ AtlasMaterialCache();
                /*0x73dc5a4*/ Spine.AtlasRegion CloneAtlasRegionWithMaterial(Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate);
                /*0x73dc614*/ Spine.AtlasPage GetAtlasPageWithMaterial(Spine.AtlasPage originalPage, UnityEngine.Material materialTemplate);
                /*0x73dc850*/ void Dispose();
            }
        }

        class SpineAttributeBase : UnityEngine.PropertyAttribute
        {
            /*0x18*/ string dataField;
            /*0x20*/ string startsWith;
            /*0x28*/ bool includeNone;
            /*0x29*/ bool fallbackToTextField;
            /*0x2a*/ bool avoidGenericMenu;

            /*0x73dc8a0*/ SpineAttributeBase();
        }

        class SpineBone : Spine.Unity.SpineAttributeBase
        {
            /*0x73dc910*/ SpineBone(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineSlot : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool containsBoundingBoxes;

            /*0x73dc96c*/ SpineSlot(string startsWith, string dataField, bool containsBoundingBoxes, bool includeNone, bool fallbackToTextField);
        }

        class SpineAnimation : Spine.Unity.SpineAttributeBase
        {
            /*0x73dc9d8*/ SpineAnimation(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool avoidGenericMenu);
        }

        class SpineEvent : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool audioOnly;

            /*0x73dca44*/ SpineEvent(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool audioOnly);
        }

        class SpineSkin : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool defaultAsEmptyString;

            /*0x73dcab0*/ SpineSkin(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool defaultAsEmptyString, bool avoidGenericMenu);
        }

        class SpineAttachment : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool returnAttachmentPath;
            /*0x2c*/ bool currentSkinOnly;
            /*0x2d*/ bool placeholdersOnly;
            /*0x30*/ string skinField;
            /*0x38*/ string slotField;

            /*0x73dcb24*/ SpineAttachment(bool currentSkinOnly, bool returnAttachmentPath, bool placeholdersOnly, string slotField, string dataField, string skinField, bool includeNone, bool fallbackToTextField);
        }

        class SkeletonExtensions
        {
            static /*0x73dcc3c*/ void SetColor(Spine.Skeleton skeleton, UnityEngine.Color color);
            static /*0x73dcc58*/ UnityEngine.Quaternion GetQuaternion(Spine.Bone bone);
            static /*0x73dcc98*/ void GetWorldToLocalMatrix(Spine.Bone bone, ref float ia, ref float ib, ref float ic, ref float id);
            static /*0x73dccf0*/ UnityEngine.Vector2 WorldToLocal(Spine.Bone bone, UnityEngine.Vector2 worldPosition);
            static /*0x73dcd20*/ UnityEngine.Vector2[] GetLocalVertices(Spine.VertexAttachment va, Spine.Slot slot, UnityEngine.Vector2[] buffer);
        }

        namespace AnimationTools
        {
            class TimelineExtensions
            {
                static /*0x73dcfd4*/ UnityEngine.Vector2 Evaluate(Spine.TranslateTimeline timeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73dd0b0*/ UnityEngine.Vector2 Evaluate(Spine.TranslateXTimeline xTimeline, Spine.TranslateYTimeline yTimeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73dd1c8*/ float Evaluate(Spine.RotateTimeline timeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73dd25c*/ UnityEngine.Vector2 EvaluateTranslateXYMix(Spine.TransformConstraintTimeline timeline, float time);
                static /*0x73dd30c*/ float EvaluateRotateMix(Spine.TransformConstraintTimeline timeline, float time);
                static /*0x73dd378*/ Spine.TranslateTimeline FindTranslateTimelineForBone(Spine.Animation a, int boneIndex);
                static /*0x3910ae8*/ T FindTimelineForBone<T>(Spine.Animation a, int boneIndex);
                static /*0x73dd5b0*/ Spine.TransformConstraintTimeline FindTransformConstraintTimeline(Spine.Animation a, int transformConstraintIndex);
            }
        }

        namespace AttachmentTools
        {
            class AtlasUtilities
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<Spine.AtlasRegion, int> existingRegions;
                static /*0x8*/ System.Collections.Generic.List<int> regionIndices;
                static /*0x10*/ System.Collections.Generic.List<Spine.AtlasRegion> originalRegions;
                static /*0x18*/ System.Collections.Generic.List<Spine.AtlasRegion> repackedRegions;
                static /*0x20*/ System.Collections.Generic.List<UnityEngine.Texture2D> texturesToPackAtParam;
                static /*0x28*/ System.Collections.Generic.List<Spine.Attachment> inoutAttachments;
                static /*0x30*/ System.Collections.Generic.Dictionary<Spine.Unity.AttachmentTools.AtlasUtilities.IntAndAtlasRegionKey, UnityEngine.Texture2D> CachedRegionTextures;
                static /*0x38*/ System.Collections.Generic.List<UnityEngine.Texture2D> CachedRegionTexturesList;

                static /*0x73dda40*/ AtlasUtilities();
                static /*0x73dd7e8*/ void Init();
                static /*0x73dd834*/ void ClearCache();

                struct IntAndAtlasRegionKey
                {
                    /*0x10*/ int i;
                    /*0x18*/ Spine.AtlasRegion region;

                    /*0x73ddce0*/ int GetHashCode();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 753D5E1ADA77B20B9959A1030B8E0BA5CF925F2881D3635C3F791E5A0AE0EEB1;

    struct __StaticArrayInitTypeSize=24
    {
    }
}
