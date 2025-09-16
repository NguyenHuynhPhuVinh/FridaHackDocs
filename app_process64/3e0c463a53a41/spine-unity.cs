class <Module>
{
}

namespace Spine
{
    class SpineSkeletonExtensions
    {
        static /*0x739a970*/ bool IsWeighted(Spine.VertexAttachment va);
        static /*0x739a9a0*/ bool InheritsRotation(Spine.Inherit mode);
        static /*0x739a9c0*/ bool InheritsScale(Spine.Inherit mode);
    }

    namespace Unity
    {
        class AnimationReferenceAsset : UnityEngine.ScriptableObject, Spine.Unity.IHasSkeletonDataAsset, Spine.Unity.ISpineComponent
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string animationName;
            /*0x28*/ Spine.Animation animation;

            static /*0x739b1b0*/ Spine.Animation op_Implicit(Spine.Unity.AnimationReferenceAsset asset);
            /*0x739b1dc*/ AnimationReferenceAsset();
            /*0x739a9cc*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x739a9d4*/ Spine.Animation get_Animation();
            /*0x739abac*/ void Clear();
            /*0x739a9f8*/ void Initialize();
        }

        class AtlasAssetBase : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase.LoadingMode textureLoadingMode;
            /*0x20*/ Spine.Unity.OnDemandTextureLoader onDemandTextureLoader;

            /*0x739b464*/ AtlasAssetBase();
            /*0x380b9e8*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x380b6a0*/ int get_MaterialCount();
            /*0x380b128*/ bool get_IsLoaded();
            /*0x380cb08*/ void Clear();
            Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x739b1e4*/ Spine.Unity.AtlasAssetBase.LoadingMode get_TextureLoadingMode();
            /*0x739b1ec*/ void set_TextureLoadingMode(Spine.Unity.AtlasAssetBase.LoadingMode value);
            /*0x739b1f4*/ Spine.Unity.OnDemandTextureLoader get_OnDemandTextureLoader();
            /*0x739b1fc*/ void set_OnDemandTextureLoader(Spine.Unity.OnDemandTextureLoader value);
            /*0x739b204*/ void BeginCustomTextureLoading();
            /*0x739b288*/ void EndCustomTextureLoading();
            /*0x739b30c*/ void RequireTexturesLoaded(UnityEngine.Material material, ref UnityEngine.Material overrideMaterial);
            /*0x739b3ac*/ void RequireTextureLoaded(UnityEngine.Texture placeholderTexture, ref UnityEngine.Texture replacementTexture, System.Action<UnityEngine.Texture> onTextureLoaded);

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

            static /*0x739bba8*/ bool CreateAndAssignMaterials(Spine.Unity.SkeletonDataAsset skeletonDataAsset, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials, ref bool anyReplacementMaterialsChanged);
            static /*0x739bda4*/ bool CreateAndAssignMaterials(Spine.Unity.SkeletonDataAsset skeletonDataAsset, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials, ref bool anyReplacementMaterialsChanged, System.Action<Spine.Unity.SkeletonDataAsset> clearSkeletonDataAssetFunc, System.Action<Spine.Unity.SkeletonDataAsset> afterAssetModifiedFunc, Spine.Unity.BlendModeMaterials.CreateForRegionDelegate createForRegionFunc);
            static /*0x739c508*/ bool CreateForRegion(ref System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials, ref bool anyReplacementMaterialsChanged, Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            static /*0x739c760*/ Spine.Unity.BlendModeMaterials.ReplacementMaterial CreateReplacementMaterial(Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix);
            /*0x739d2b0*/ BlendModeMaterials();
            /*0x739b46c*/ bool get_RequiresBlendModeMaterials();
            /*0x739b474*/ Spine.BlendMode BlendModeForMaterial(UnityEngine.Material material);
            /*0x739b7dc*/ bool UpdateBlendmodeMaterialsRequiredState(Spine.SkeletonData skeletonData);
            /*0x739c92c*/ void ApplyMaterials(Spine.SkeletonData skeletonData);
            /*0x739d0cc*/ Spine.AtlasRegion CloneAtlasRegionWithMaterial(Spine.AtlasRegion originalRegion, System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials);

            class ReplacementMaterial
            {
                /*0x10*/ string pageName;
                /*0x18*/ UnityEngine.Material material;

                /*0x739c924*/ ReplacementMaterial();
            }

            class TemplateMaterials
            {
                /*0x10*/ UnityEngine.Material additiveTemplate;
                /*0x18*/ UnityEngine.Material multiplyTemplate;
                /*0x20*/ UnityEngine.Material screenTemplate;

                /*0x739d380*/ TemplateMaterials();
            }

            class CreateForRegionDelegate : System.MulticastDelegate
            {
                /*0x739bcf0*/ CreateForRegionDelegate(object object, nint method);
                /*0x739d388*/ bool Invoke(ref System.Collections.Generic.List<Spine.Unity.BlendModeMaterials.ReplacementMaterial> replacementMaterials, ref bool anyReplacementMaterialsChanged, Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate, string materialSuffix, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
            }

            class <>c
            {
                static /*0x0*/ Spine.Unity.BlendModeMaterials.<> <>9;
                static /*0x8*/ System.Action<Spine.Unity.SkeletonDataAsset> <>9__16_0;

                static /*0x739d39c*/ <>c();
                /*0x739d404*/ <>c();
                /*0x739d40c*/ void <CreateAndAssignMaterials>b__16_0(Spine.Unity.SkeletonDataAsset asset);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ Spine.AtlasRegion originalRegion;

                /*0x739c758*/ <>c__DisplayClass18_0();
                /*0x739d468*/ bool <CreateForRegion>b__0(Spine.Unity.BlendModeMaterials.ReplacementMaterial replacement);
            }
        }

        class EventDataReferenceAsset : UnityEngine.ScriptableObject
        {
            static bool QuietSkeletonData = true;
            /*0x18*/ Spine.Unity.SkeletonDataAsset skeletonDataAsset;
            /*0x20*/ string eventName;
            /*0x28*/ Spine.EventData eventData;

            static /*0x739d668*/ Spine.EventData op_Implicit(Spine.Unity.EventDataReferenceAsset asset);
            /*0x739d694*/ EventDataReferenceAsset();
            /*0x739d498*/ Spine.EventData get_EventData();
            /*0x739d4bc*/ void Initialize();
        }

        class OnDemandTextureLoader : UnityEngine.ScriptableObject
        {
            /*0x18*/ Spine.Unity.AtlasAssetBase atlasAsset;
            /*0x20*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureRequested;
            /*0x28*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureLoaded;
            /*0x30*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureLoadFailed;
            /*0x38*/ Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate onTextureUnloaded;

            /*0x739e0e0*/ OnDemandTextureLoader();
            /*0x380bb68*/ string GetPlaceholderTextureName(string originalTextureName);
            /*0x380b2f0*/ bool AssignPlaceholderTextures(ref System.Collections.Generic.IEnumerable<UnityEngine.Material> modifiedMaterials);
            /*0x380b2f0*/ bool HasPlaceholderTexturesAssigned(ref System.Collections.Generic.List<UnityEngine.Material> placeholderMaterials);
            /*0x739d69c*/ bool HasNullMainTexturesAssigned(ref System.Collections.Generic.List<UnityEngine.Material> nullTextureMaterials);
            /*0x380b2f0*/ bool AssignTargetTextures(ref System.Collections.Generic.IEnumerable<UnityEngine.Material> modifiedMaterials);
            /*0x380cb08*/ void BeginCustomTextureLoading();
            /*0x380cb08*/ void EndCustomTextureLoading();
            /*0x380b2f0*/ bool HasPlaceholderAssigned(UnityEngine.Material material);
            /*0x380d93c*/ void RequestLoadMaterialTextures(UnityEngine.Material material, ref UnityEngine.Material overrideMaterial);
            /*0x380da4c*/ void RequestLoadTexture(UnityEngine.Texture placeholderTexture, ref UnityEngine.Texture replacementTexture, System.Action<UnityEngine.Texture> onTextureLoaded);
            /*0x380cdf0*/ void Clear(bool clearAtlasAsset);
            /*0x739db30*/ void add_onTextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739dbcc*/ void remove_onTextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739dc68*/ void add_onTextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739dd04*/ void remove_onTextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739dda0*/ void add_onTextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739de3c*/ void remove_onTextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739ded8*/ void add_onTextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739df74*/ void remove_onTextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e010*/ void add_TextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e014*/ void remove_TextureRequested(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e018*/ void add_TextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e01c*/ void remove_TextureLoaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e020*/ void add_TextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e024*/ void remove_TextureLoadFailed(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e028*/ void add_TextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e02c*/ void remove_TextureUnloaded(Spine.Unity.OnDemandTextureLoader.TextureLoadDelegate value);
            /*0x739e030*/ void OnTextureRequested(UnityEngine.Material material, int textureIndex);
            /*0x739e05c*/ void OnTextureLoaded(UnityEngine.Material material, int textureIndex);
            /*0x739e088*/ void OnTextureLoadFailed(UnityEngine.Material material, int textureIndex);
            /*0x739e0b4*/ void OnTextureUnloaded(UnityEngine.Material material, int textureIndex);

            class TextureLoadDelegate : System.MulticastDelegate
            {
                /*0x739e0e8*/ TextureLoadDelegate(object object, nint method);
                /*0x739e1f4*/ void Invoke(Spine.Unity.OnDemandTextureLoader loader, UnityEngine.Material material, int textureIndex);
            }
        }

        class RegionlessAttachmentLoader : Spine.AttachmentLoader
        {
            static /*0x0*/ Spine.AtlasRegion emptyRegion;

            static /*0x739e208*/ Spine.AtlasRegion get_EmptyRegion();
            /*0x739e6a0*/ RegionlessAttachmentLoader();
            /*0x739e440*/ Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
            /*0x739e4b8*/ Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path, Spine.Sequence sequence);
            /*0x739e530*/ Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name);
            /*0x739e58c*/ Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name);
            /*0x739e5e8*/ Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name);
            /*0x739e644*/ Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name);
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

            static /*0x739e6e0*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase atlasAsset, bool initialize, float scale);
            static /*0x739e7a4*/ Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAssetBase[] atlasAssets, bool initialize, float scale);
            static /*0x739eac8*/ Spine.SkeletonData ReadSkeletonData(byte[] bytes, Spine.AttachmentLoader attachmentLoader, float scale);
            static /*0x739ecc4*/ Spine.SkeletonData ReadSkeletonData(string text, Spine.AttachmentLoader attachmentLoader, float scale);
            /*0x739eeec*/ SkeletonDataAsset();
            /*0x739e6a8*/ bool get_IsLoaded();
            /*0x739e6b8*/ void Reset();
            /*0x739e86c*/ void SetupRuntimeBlendModeMaterials(bool applyAdditiveMaterial, Spine.Unity.BlendModeMaterials.TemplateMaterials templateMaterials);
            /*0x739d440*/ void Clear();
            /*0x739e8fc*/ Spine.AnimationStateData GetAnimationStateData();
            /*0x739abb8*/ Spine.SkeletonData GetSkeletonData(bool quiet);
            /*0x739ed84*/ void InitializeWithData(Spine.SkeletonData sd);
            /*0x739ee18*/ void FillStateData(bool quiet);
            /*0x739e924*/ Spine.Atlas[] GetAtlasArray();
        }

        class SkeletonDataModifierAsset : UnityEngine.ScriptableObject
        {
            /*0x739f070*/ SkeletonDataModifierAsset();
            /*0x380d83c*/ void Apply(Spine.SkeletonData skeletonData);
        }

        class SpineAtlasAsset : Spine.Unity.AtlasAssetBase
        {
            /*0x28*/ UnityEngine.TextAsset atlasFile;
            /*0x30*/ UnityEngine.Material[] materials;
            /*0x38*/ Spine.TextureLoader customTextureLoader;
            /*0x40*/ Spine.Atlas atlas;

            static /*0x739f0d0*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Material[] materials, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader);
            static /*0x739f1bc*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Material materialPropertySource, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader, bool renameMaterial);
            static /*0x739f5f4*/ Spine.Unity.SpineAtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Shader shader, bool initialize, System.Func<Spine.Unity.SpineAtlasAsset, Spine.TextureLoader> newCustomTextureLoader);
            /*0x739ff94*/ SpineAtlasAsset();
            /*0x739f078*/ bool get_IsLoaded();
            /*0x739f088*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x739f090*/ int get_MaterialCount();
            /*0x739f0a8*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x739f1b0*/ void Reset();
            /*0x739f6e0*/ void Clear();
            /*0x739f6ec*/ Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x739fb84*/ UnityEngine.Mesh GenerateMesh(string name, UnityEngine.Mesh mesh, ref UnityEngine.Material material, float scale);
        }

        class NoOpTextureLoader : Spine.TextureLoader
        {
            /*0x739fb7c*/ NoOpTextureLoader();
            /*0x739ff9c*/ void Load(Spine.AtlasPage page, string path);
        }

        class MaterialsTextureLoader : Spine.TextureLoader
        {
            /*0x10*/ Spine.Unity.SpineAtlasAsset atlasAsset;

            /*0x739fb4c*/ MaterialsTextureLoader(Spine.Unity.SpineAtlasAsset atlasAsset);
            /*0x739ffa0*/ void Load(Spine.AtlasPage page, string path);
        }

        class SpineSpriteAtlasAsset : Spine.Unity.AtlasAssetBase
        {
            /*0x28*/ UnityEngine.U2D.SpriteAtlas spriteAtlasFile;
            /*0x30*/ UnityEngine.Material[] materials;
            /*0x38*/ Spine.Atlas atlas;
            /*0x40*/ bool updateRegionsInPlayMode;
            /*0x48*/ Spine.Unity.SpineSpriteAtlasAsset.SavedRegionInfo[] savedRegions;

            static /*0x73a033c*/ Spine.Unity.SpineSpriteAtlasAsset CreateRuntimeInstance(UnityEngine.U2D.SpriteAtlas spriteAtlasFile, UnityEngine.Material[] materials, bool initialize);
            static /*0x73a0fb4*/ UnityEngine.Texture2D AccessPackedTexture(UnityEngine.Sprite[] sprites);
            static /*0x73a0fe0*/ UnityEngine.Sprite[] AccessPackedSprites(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            /*0x73a1068*/ SpineSpriteAtlasAsset();
            /*0x73a02e4*/ bool get_IsLoaded();
            /*0x73a02f4*/ System.Collections.Generic.IEnumerable<UnityEngine.Material> get_Materials();
            /*0x73a02fc*/ int get_MaterialCount();
            /*0x73a0314*/ UnityEngine.Material get_PrimaryMaterial();
            /*0x73a03e8*/ void Reset();
            /*0x73a03f4*/ void Clear();
            /*0x73a0400*/ Spine.Atlas GetAtlas(bool onlyMetaData);
            /*0x73a0bb8*/ void AssignRegionsFromSavedRegions(UnityEngine.Sprite[] sprites, Spine.Atlas usedAtlas);
            /*0x73a073c*/ Spine.Atlas LoadAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);

            class SavedRegionInfo
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float width;
                /*0x1c*/ float height;
                /*0x20*/ UnityEngine.SpritePackingRotation packingRotation;

                /*0x73a1070*/ SavedRegionInfo();
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

            /*0x73a19b4*/ BoneFollower();
            /*0x73a1078*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73a1080*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x73a10a4*/ bool SetBone(string name);
            /*0x73a118c*/ void Awake();
            /*0x73a11a4*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x73a11b0*/ void Initialize();
            /*0x73a1380*/ void OnDestroy();
            /*0x73a1450*/ void LateUpdate();

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

            /*0x73a2214*/ BoneFollowerGraphic();
            /*0x73a19d0*/ Spine.Unity.SkeletonGraphic get_SkeletonGraphic();
            /*0x73a19d8*/ void set_SkeletonGraphic(Spine.Unity.SkeletonGraphic value);
            /*0x73a19fc*/ bool SetBone(string name);
            /*0x73a1b0c*/ void Awake();
            /*0x73a1b24*/ void Initialize();
            /*0x73a1c74*/ void LateUpdate();
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

            static /*0x73a3504*/ BoundingBoxFollower();
            /*0x73a3420*/ BoundingBoxFollower();
            /*0x73a2234*/ Spine.Slot get_Slot();
            /*0x73a223c*/ Spine.BoundingBoxAttachment get_CurrentAttachment();
            /*0x73a2244*/ string get_CurrentAttachmentName();
            /*0x73a224c*/ UnityEngine.PolygonCollider2D get_CurrentCollider();
            /*0x73a2254*/ bool get_IsTrigger();
            /*0x73a225c*/ void Start();
            /*0x73a2788*/ void OnEnable();
            /*0x73a2894*/ void HandleRebuild(Spine.Unity.SkeletonRenderer sr);
            /*0x73a2264*/ void Initialize(bool overwrite);
            /*0x73a289c*/ void AddCollidersForSkin(Spine.Skin skin, int slotIndex, UnityEngine.PolygonCollider2D[] previousColliders, ref int collidersCount);
            /*0x73a2e24*/ void OnDisable();
            /*0x73a2f04*/ void ClearState();
            /*0x73a2d34*/ void DisposeExcessCollidersAfter(int requiredCount);
            /*0x73a30a4*/ void LateUpdate();
            /*0x73a30c4*/ void MatchAttachment(Spine.Attachment attachment);
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

            static /*0x73a4da0*/ BoundingBoxFollowerGraphic();
            /*0x73a4cbc*/ BoundingBoxFollowerGraphic();
            /*0x73a3550*/ Spine.Slot get_Slot();
            /*0x73a3558*/ Spine.BoundingBoxAttachment get_CurrentAttachment();
            /*0x73a3560*/ string get_CurrentAttachmentName();
            /*0x73a3568*/ UnityEngine.PolygonCollider2D get_CurrentCollider();
            /*0x73a3570*/ bool get_IsTrigger();
            /*0x73a3578*/ void Start();
            /*0x73a3ad4*/ void OnEnable();
            /*0x73a3d18*/ void HandleRebuild(Spine.Unity.SkeletonGraphic sr);
            /*0x73a3580*/ void Initialize(bool overwrite);
            /*0x73a4130*/ void AddCollidersForSkin(Spine.Skin skin, int slotIndex, UnityEngine.PolygonCollider2D[] previousColliders, float scale, ref int collidersCount);
            /*0x73a46c4*/ void OnDisable();
            /*0x73a47a0*/ void ClearState();
            /*0x73a45d4*/ void DisposeExcessCollidersAfter(int requiredCount);
            /*0x73a4940*/ void LateUpdate();
            /*0x73a4960*/ void MatchAttachment(Spine.Attachment attachment);
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

            /*0x73a54c0*/ PointFollower();
            /*0x73a4dec*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73a4df4*/ Spine.Unity.ISkeletonComponent get_SkeletonComponent();
            /*0x73a4dfc*/ bool get_IsValid();
            /*0x73a4e04*/ void Initialize();
            /*0x73a50d4*/ void HandleRebuildRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer);
            /*0x73a4e98*/ void UpdateReferences();
            /*0x73a50d8*/ void OnDestroy();
            /*0x73a51a8*/ void LateUpdate();
        }

        class SkeletonSubmeshGraphic : UnityEngine.UI.MaskableGraphic
        {
            /*0x73a5558*/ SkeletonSubmeshGraphic();
            /*0x73a54d0*/ void SetMaterialDirty();
            /*0x73a54d4*/ void SetVerticesDirty();
            /*0x73a54d8*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x73a54f0*/ void OnDisable();
            /*0x73a5524*/ void OnEnable();
        }

        class SkeletonMecanimRootMotion : Spine.Unity.SkeletonRootMotionBase
        {
            static int DefaultMecanimLayerFlags = -1;
            /*0xf8*/ int mecanimLayerFlags;
            /*0xfc*/ UnityEngine.Vector2 movementDelta;
            /*0x104*/ float rotationDelta;
            /*0x108*/ Spine.Unity.SkeletonMecanim skeletonMecanim;

            /*0x73a6a70*/ SkeletonMecanimRootMotion();
            /*0x73a5560*/ Spine.Unity.SkeletonMecanim get_SkeletonMecanim();
            /*0x73a5608*/ UnityEngine.Vector2 GetRemainingRootMotion(int layerIndex);
            /*0x73a5ca4*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int layerIndex);
            /*0x73a5f98*/ void Reset();
            /*0x73a5fb8*/ void Initialize();
            /*0x73a64ac*/ void OnClipApplied(Spine.Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward);
            /*0x73a6a00*/ UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73a6a64*/ float CalculateAnimationsRotationDelta();
        }

        class SkeletonRootMotion : Spine.Unity.SkeletonRootMotionBase
        {
            static int DefaultAnimationTrackFlags = -1;
            /*0xf8*/ int animationTrackFlags;
            /*0x100*/ Spine.AnimationState animationState;
            /*0x108*/ Spine.Unity.SkeletonGraphic skeletonGraphic;

            /*0x73a7334*/ SkeletonRootMotion();
            /*0x73a6ccc*/ UnityEngine.Vector2 GetRemainingRootMotion(int trackIndex);
            /*0x73a6d54*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex);
            /*0x73a6dd0*/ float get_AdditionalScale();
            /*0x73a6e48*/ void Reset();
            /*0x73a6e64*/ void Initialize();
            /*0x73a6f78*/ UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73a7154*/ float CalculateAnimationsRotationDelta();
            /*0x73a711c*/ void ApplyMixAlphaToDelta(ref UnityEngine.Vector2 currentDelta, Spine.TrackEntry next, Spine.TrackEntry track);
            /*0x73a7260*/ void ApplyMixAlphaToDelta(ref float currentDelta, Spine.TrackEntry next, Spine.TrackEntry track);
            /*0x73a7298*/ void GetMixAlpha(ref float cumulatedMixAlpha, Spine.TrackEntry next, Spine.TrackEntry track);
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

            /*0x73a6a7c*/ SkeletonRootMotionBase();
            /*0x73a7340*/ void add_ProcessRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73a73dc*/ void remove_ProcessRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73a7478*/ void add_PhysicsUpdateRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73a7514*/ void remove_PhysicsUpdateRootMotionOverride(Spine.Unity.SkeletonRootMotionBase.RootMotionDelegate value);
            /*0x73a75b0*/ Spine.Bone get_RootMotionBone();
            /*0x73a75b8*/ bool get_UsesRigidbody();
            /*0x73a7650*/ UnityEngine.Vector2 get_PreviousRigidbodyRootMotion2D();
            /*0x73a7658*/ UnityEngine.Vector3 get_PreviousRigidbodyRootMotion3D();
            /*0x73a7664*/ UnityEngine.Vector2 get_AdditionalRigidbody2DMovement();
            /*0x73a766c*/ void set_AdditionalRigidbody2DMovement(UnityEngine.Vector2 value);
            /*0x73a7674*/ bool get_SkeletonAnimationUsesFixedUpdate();
            /*0x73a5fb4*/ void Reset();
            /*0x73a78d8*/ void Start();
            /*0x73a78e4*/ void InitializeOnRebuild(Spine.Unity.ISkeletonAnimation animatedSkeletonComponent);
            /*0x73a611c*/ void Initialize();
            /*0x73a7d08*/ void FixedUpdate();
            /*0x73a7d48*/ void PhysicsUpdate(bool skeletonAnimationUsesFixedUpdate);
            /*0x73a840c*/ void OnDisable();
            /*0x73a772c*/ void FindRigidbodyComponent();
            /*0x73a8410*/ float get_AdditionalScale();
            UnityEngine.Vector2 CalculateAnimationsMovementDelta();
            /*0x73a8418*/ float CalculateAnimationsRotationDelta();
            UnityEngine.Vector2 GetRemainingRootMotion(int trackIndex);
            /*0x3907c14*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex);
            /*0x73a8420*/ Spine.Unity.ISkeletonComponent get_TargetSkeletonComponent();
            /*0x73a848c*/ Spine.Unity.ISkeletonAnimation get_TargetSkeletonAnimationComponent();
            /*0x73a7b88*/ void SetRootMotionBone(string name);
            /*0x73a8758*/ void AdjustRootMotionToDistance(UnityEngine.Vector2 distanceToTarget, int trackIndex, bool adjustX, bool adjustY, float minX, float maxX, float minY, float maxY, bool allowXTranslation, bool allowYTranslation);
            /*0x73a8964*/ UnityEngine.Vector2 GetAnimationRootMotion(Spine.Animation animation);
            /*0x73a56c4*/ UnityEngine.Vector2 GetAnimationRootMotion(float startTime, float endTime, Spine.Animation animation);
            /*0x73a8c6c*/ float GetAnimationRootMotionRotation(Spine.Animation animation);
            /*0x73a65b4*/ float GetAnimationRootMotionRotation(float startTime, float endTime, Spine.Animation animation);
            /*0x73a8980*/ void ApplyConstraintToPos(Spine.Animation animation, Spine.TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintPos, ref UnityEngine.Vector2 pos);
            /*0x73a8c88*/ void ApplyConstraintToRotation(Spine.Animation animation, Spine.TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintRotation, ref float rotation);
            /*0x73a8a9c*/ void UpdateLastConstraintPos(Spine.TransformConstraint[] transformConstraintsItems);
            /*0x73a8d88*/ void UpdateLastConstraintRotation(Spine.TransformConstraint[] transformConstraintsItems);
            /*0x73a5d60*/ Spine.Unity.SkeletonRootMotionBase.RootMotionInfo GetAnimationRootMotionInfo(Spine.Animation animation, float currentTime);
            /*0x73a8f58*/ int GetConstraintLastPosIndex(int constraintIndex);
            /*0x73a84d8*/ void FindTransformConstraintsAffectingBone();
            /*0x73a90b0*/ UnityEngine.Vector2 GetTimelineMovementDelta(float startTime, float endTime, Spine.TranslateXTimeline xTimeline, Spine.TranslateYTimeline yTimeline, Spine.Animation animation);
            /*0x73a78f0*/ void GatherTopLevelBones();
            /*0x73a91fc*/ void HandleUpdateLocal(Spine.Unity.ISkeletonAnimation animatedSkeletonComponent);
            /*0x73a936c*/ void ApplyRootMotion(UnityEngine.Vector2 skeletonTranslationDelta, float skeletonRotationDelta, UnityEngine.Vector2 parentBoneScale, bool skeletonAnimationUsesFixedUpdate);
            /*0x73a9b34*/ void ApplyTransformConstraints();
            /*0x73a894c*/ UnityEngine.Vector2 GetScaleAffectingRootMotion();
            /*0x73a8170*/ UnityEngine.Vector2 GetScaleAffectingRootMotion(ref UnityEngine.Vector2 parentBoneScale);
            /*0x73a92e0*/ UnityEngine.Vector2 GetSkeletonSpaceMovementDelta(UnityEngine.Vector2 boneLocalDelta, ref UnityEngine.Vector2 parentBoneScale, ref UnityEngine.Vector2 totalScale);
            /*0x73a9358*/ float GetSkeletonSpaceRotationDelta(float boneLocalDelta, UnityEngine.Vector2 totalScaleAffectingRootMotion);
            /*0x73a96ec*/ void SetEffectiveBoneOffsetsTo(UnityEngine.Vector2 displacementSkeletonSpace, float rotationSkeletonSpace, UnityEngine.Vector2 parentBoneScale);
            /*0x73a8300*/ void ClearEffectiveBoneOffsets(UnityEngine.Vector2 parentBoneScale);
            /*0x73a836c*/ void ClearRigidbodyTempMovement();

            class RootMotionDelegate : System.MulticastDelegate
            {
                /*0x73a9d54*/ RootMotionDelegate(object object, nint method);
                /*0x73a9e60*/ void Invoke(Spine.Unity.SkeletonRootMotionBase component, UnityEngine.Vector2 translation, float rotation);
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

                /*0x73a90a8*/ <>c__DisplayClass80_0();
                /*0x73a9e74*/ bool <GetConstraintLastPosIndex>b__0(int addedIndex);
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

            static /*0x73aa674*/ Spine.Unity.SkeletonAnimation AddToGameObject(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            static /*0x73aa6f8*/ Spine.Unity.SkeletonAnimation NewSkeletonAnimationGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            /*0x73aac34*/ SkeletonAnimation();
            /*0x73a9e84*/ Spine.AnimationState get_AnimationState();
            /*0x73a9eac*/ void add__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73a9f4c*/ void remove__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73a9fec*/ void add__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa08c*/ void remove__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa12c*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa1cc*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa26c*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa30c*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa3ac*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa44c*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa4ec*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73aa4f0*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73aa4f4*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa4f8*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa4fc*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa500*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa504*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa508*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa50c*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa510*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73aa514*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73aa51c*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73aa524*/ bool get_UnscaledTime();
            /*0x73aa52c*/ void set_UnscaledTime(bool value);
            /*0x73aa538*/ string get_AnimationName();
            /*0x73aa580*/ void set_AnimationName(string value);
            /*0x73aa774*/ void ClearState();
            /*0x73aa7a0*/ void Initialize(bool overwrite, bool quiet);
            /*0x73aa8f4*/ void Update();
            /*0x73aa998*/ void FixedUpdate();
            /*0x73aa938*/ void Update(float deltaTime);
            /*0x73aa9dc*/ void UpdateAnimationStatus(float deltaTime);
            /*0x73aaa64*/ void ApplyAnimation();
            /*0x73aaac8*/ void AfterAnimationApplied();
            /*0x73aab74*/ void LateUpdate();
            /*0x73aabd8*/ void OnBecameVisible();
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

            static /*0x73aacf4*/ Spine.Unity.SkeletonGraphic NewSkeletonGraphicGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Transform parent, UnityEngine.Material material);
            static /*0x73aadf4*/ Spine.Unity.SkeletonGraphic AddSkeletonGraphicComponent(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Material material);
            static /*0x73ad7bc*/ void SetRectTransformSize(UnityEngine.UI.Graphic target, UnityEngine.Vector2 size);
            static /*0x73ad7f0*/ void SetRectTransformSize(UnityEngine.RectTransform targetRectTransform, UnityEngine.Vector2 size);
            /*0x73b0c80*/ SkeletonGraphic();
            /*0x73aaca0*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x73aaca8*/ UnityEngine.Color get_color();
            /*0x73aacb8*/ void set_color(UnityEngine.Color value);
            /*0x73aacc8*/ float get_MeshScale();
            /*0x73aacd0*/ UnityEngine.Vector2 get_MeshOffset();
            /*0x73aacdc*/ Spine.Unity.UpdateMode get_UpdateMode();
            /*0x73aace4*/ void set_UpdateMode(Spine.Unity.UpdateMode value);
            /*0x73aacec*/ System.Collections.Generic.List<UnityEngine.Transform> get_SeparatorParts();
            /*0x73aaf30*/ void add_assignMeshOverrideSingle(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73aafd0*/ void remove_assignMeshOverrideSingle(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73ab070*/ void add_assignMeshOverrideMultiple(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73ab110*/ void remove_assignMeshOverrideMultiple(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73ab1b0*/ void add_AssignMeshOverrideSingleRenderer(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73ab1e4*/ void remove_AssignMeshOverrideSingleRenderer(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateSingle value);
            /*0x73ab218*/ void add_AssignMeshOverrideMultipleRenderers(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73ab24c*/ void remove_AssignMeshOverrideMultipleRenderers(Spine.Unity.SkeletonGraphic.MeshAssignmentDelegateMultiple value);
            /*0x73ab280*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Texture> get_CustomTextureOverride();
            /*0x73ab288*/ System.Collections.Generic.Dictionary<UnityEngine.Texture, UnityEngine.Material> get_CustomMaterialOverride();
            /*0x73ab290*/ UnityEngine.Texture get_OverrideTexture();
            /*0x73ab298*/ void set_OverrideTexture(UnityEngine.Texture value);
            /*0x73ab2f4*/ UnityEngine.Texture get_mainTexture();
            /*0x73ab36c*/ void Awake();
            /*0x73ab764*/ void OnDestroy();
            /*0x73ab89c*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x73abb70*/ void OnDisable();
            /*0x73abcc8*/ void Update();
            /*0x73abd20*/ void FixedUpdate();
            /*0x73abd78*/ void Update(float deltaTime);
            /*0x73ab468*/ void SyncSubmeshGraphicsWithCanvasRenderers();
            /*0x73abdd0*/ void UpdateAnimationStatus(float deltaTime);
            /*0x73abe5c*/ void ApplyTransformMovementToPhysics();
            /*0x73ac044*/ UnityEngine.Vector2 GetPhysicsTransformPosition();
            /*0x73ac15c*/ float GetPhysicsTransformRotation();
            /*0x73ac330*/ void ApplyAnimation();
            /*0x73ac3a0*/ void AfterAnimationApplied();
            /*0x73ac440*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
            /*0x73ac45c*/ void LateUpdate();
            /*0x73ac518*/ void OnCullStateChanged(bool culled);
            /*0x73ac53c*/ void OnBecameVisible();
            /*0x73ac530*/ void OnBecameInvisible();
            /*0x73ac548*/ void ReapplySeparatorSlotNames();
            /*0x73a1af0*/ Spine.Skeleton get_Skeleton();
            /*0x73ac8e8*/ void set_Skeleton(Spine.Skeleton value);
            /*0x73ac8f8*/ Spine.SkeletonData get_SkeletonData();
            /*0x73a1c64*/ bool get_IsValid();
            /*0x73a3c78*/ void add_OnRebuild(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73a3bd8*/ void remove_OnRebuild(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73ac924*/ void add_OnInstructionsPrepared(Spine.Unity.SkeletonGraphic.InstructionDelegate value);
            /*0x73ac9c4*/ void remove_OnInstructionsPrepared(Spine.Unity.SkeletonGraphic.InstructionDelegate value);
            /*0x73aca64*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73acb04*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonGraphic.SkeletonRendererDelegate value);
            /*0x73acba4*/ Spine.AnimationState get_AnimationState();
            /*0x73acbc0*/ UnityEngine.Vector2 get_PhysicsPositionInheritanceFactor();
            /*0x73acbcc*/ void set_PhysicsPositionInheritanceFactor(UnityEngine.Vector2 value);
            /*0x73accac*/ float get_PhysicsRotationInheritanceFactor();
            /*0x73accb4*/ void set_PhysicsRotationInheritanceFactor(float value);
            /*0x73acd0c*/ UnityEngine.Transform get_PhysicsMovementRelativeTo();
            /*0x73acd14*/ void set_PhysicsMovementRelativeTo(UnityEngine.Transform value);
            /*0x73acc90*/ void ResetLastPosition();
            /*0x73accf4*/ void ResetLastRotation();
            /*0x73acdbc*/ void ResetLastPositionAndRotation();
            /*0x73acde4*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x73acdec*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73ace08*/ Spine.ExposedList<UnityEngine.Mesh> get_MeshesMultipleCanvasRenderers();
            /*0x73ace10*/ Spine.ExposedList<UnityEngine.Material> get_MaterialsMultipleCanvasRenderers();
            /*0x73ace18*/ Spine.ExposedList<UnityEngine.Texture> get_TexturesMultipleCanvasRenderers();
            /*0x73ace20*/ UnityEngine.Mesh GetLastMesh();
            /*0x73ace7c*/ bool MatchRectTransformWithBounds();
            /*0x73aced8*/ bool MatchRectTransformSingleRenderer();
            /*0x73ad080*/ bool MatchRectTransformMultipleRenderers();
            /*0x73ad424*/ void SetRectTransformBounds(UnityEngine.Bounds combinedBounds);
            /*0x73ad970*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73ada10*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73adab0*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73adb50*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73adbf0*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73adc90*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73add30*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73addd0*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73ade70*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73adf10*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73adfb0*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73adfb8*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73adfc0*/ bool get_UnscaledTime();
            /*0x73adfc8*/ void set_UnscaledTime(bool value);
            /*0x73adfd4*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73ae074*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73ab780*/ void Clear();
            /*0x73ae33c*/ void TrimRenderers();
            /*0x73a3d20*/ void Initialize(bool overwrite);
            /*0x73ab92c*/ void PrepareInstructionsAndRenderers(bool isInRebuild);
            /*0x73ac4fc*/ void UpdateMesh();
            /*0x73abad0*/ void UpdateMeshToInstructions();
            /*0x73b08d4*/ bool HasMultipleSubmeshInstructions();
            /*0x73ae670*/ void InitMeshBuffers();
            /*0x73ae2a4*/ void DisposeMeshBuffers();
            /*0x73af850*/ void UpdateMeshSingleCanvasRenderer(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73afd60*/ void UpdateMaterialsMultipleCanvasRenderers(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73b02b4*/ void UpdateMeshMultipleCanvasRenderers(Spine.Unity.SkeletonRendererInstruction currentInstructions);
            /*0x73b09ac*/ void HandleOnDemandLoading();
            /*0x73ae80c*/ void EnsureCanvasRendererCount(int targetCount);
            /*0x73af20c*/ void PrepareRendererGameObjects(Spine.Unity.SkeletonRendererInstruction currentInstructions, bool isInRebuild);
            /*0x73ae740*/ void DisableUnusedCanvasRenderers(int usedCount, bool isInRebuild);
            /*0x73aeca4*/ void EnsureMeshesCount(int targetCount);
            /*0x73aed54*/ void EnsureUsedTexturesAndMaterialsCount(int targetCount);
            /*0x73ae114*/ void DestroyMeshes();
            /*0x73aee48*/ void EnsureSeparatorPartCount();
            /*0x73ac6dc*/ void UpdateSeparatorPartParents();
            /*0x73b0944*/ float GetLayoutScale(Spine.Unity.SkeletonGraphic.LayoutMode mode);
            /*0x73b0c24*/ Spine.Unity.SkeletonGraphic.LayoutMode GetEffectiveLayoutMode(Spine.Unity.SkeletonGraphic.LayoutMode mode);
            /*0x73b0bf8*/ UnityEngine.Vector2 GetCurrentRectSize();

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
                /*0x73b112c*/ MeshAssignmentDelegateSingle(object object, nint method);
                /*0x73b11e0*/ void Invoke(UnityEngine.Mesh mesh, UnityEngine.Material graphicMaterial, UnityEngine.Texture texture);
            }

            class MeshAssignmentDelegateMultiple : System.MulticastDelegate
            {
                /*0x73b11f4*/ MeshAssignmentDelegateMultiple(object object, nint method);
                /*0x73b1294*/ void Invoke(int meshCount, UnityEngine.Mesh[] meshes, UnityEngine.Material[] graphicMaterials, UnityEngine.Texture[] textures);
            }

            class SkeletonRendererDelegate : System.MulticastDelegate
            {
                /*0x73b12a8*/ SkeletonRendererDelegate(object object, nint method);
                /*0x73b13b0*/ void Invoke(Spine.Unity.SkeletonGraphic skeletonGraphic);
            }

            class InstructionDelegate : System.MulticastDelegate
            {
                /*0x73b13c4*/ InstructionDelegate(object object, nint method);
                /*0x73b14cc*/ void Invoke(Spine.Unity.SkeletonRendererInstruction instruction);
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

            /*0x73b371c*/ SkeletonMecanim();
            /*0x73b14e0*/ Spine.Unity.SkeletonMecanim.MecanimTranslator get_Translator();
            /*0x73b14e8*/ void add__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73b1588*/ void remove__OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73b1628*/ void add__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b16c8*/ void remove__BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1768*/ void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1808*/ void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b18a8*/ void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1948*/ void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b19e8*/ void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1a88*/ void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b28*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73b1b2c*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x73b1b30*/ void add_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b34*/ void remove_BeforeApply(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b38*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b3c*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b40*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b44*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b48*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b4c*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x73b1b50*/ Spine.Unity.UpdateTiming get_UpdateTiming();
            /*0x73b1b58*/ void set_UpdateTiming(Spine.Unity.UpdateTiming value);
            /*0x73b1b60*/ void Initialize(bool overwrite, bool quiet);
            /*0x73b24f4*/ void Update();
            /*0x73b258c*/ void FixedUpdate();
            /*0x73b25c4*/ void Update(float deltaTime);
            /*0x73b252c*/ void UpdateAnimation(float deltaTime);
            /*0x73b25d4*/ void ApplyAnimation();
            /*0x73b350c*/ void AfterAnimationApplied();
            /*0x73b35b8*/ void LateUpdate();
            /*0x73b36b8*/ void OnBecameVisible();

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

                static /*0x73b3fa0*/ float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
                static /*0x73b4b30*/ float ToSpineAnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
                /*0x73b2054*/ MecanimTranslator();
                /*0x73b3a10*/ void add__OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73b3aac*/ void remove__OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73b3b48*/ void add_OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73b3b4c*/ void remove_OnClipApplied(Spine.Unity.SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value);
                /*0x73b3b50*/ UnityEngine.Animator get_Animator();
                /*0x73b228c*/ void Initialize(UnityEngine.Animator animator, Spine.Unity.SkeletonDataAsset skeletonDataAsset);
                /*0x73b3ca8*/ bool ApplyAnimation(Spine.Skeleton skeleton, UnityEngine.AnimatorClipInfo info, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, Spine.MixBlend layerBlendMode, bool useClipWeight1);
                /*0x73b40f8*/ bool ApplyInterruptionAnimation(Spine.Skeleton skeleton, bool interpolateWeightTo1, UnityEngine.AnimatorClipInfo info, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, Spine.MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1);
                /*0x73b400c*/ void OnClipAppliedCallback(Spine.Animation clip, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight);
                /*0x73b2624*/ void Apply(Spine.Skeleton skeleton);
                /*0x73b4928*/ System.Collections.Generic.KeyValuePair<Spine.Animation, float> GetActiveAnimationAndTime(int layer);
                /*0x73b432c*/ void InitClipInfosForLayers();
                /*0x73b3b58*/ void ClearClipInfosForLayers();
                /*0x73b48cc*/ Spine.Unity.SkeletonMecanim.MecanimTranslator.MixMode GetMixMode(int layer, Spine.MixBlend layerBlendMode);
                /*0x73b4480*/ void GetStateUpdatesFromAnimator(int layer);
                /*0x73b4788*/ void GetAnimatorClipInfos(int layer, ref bool isInterruptionActive, ref int clipInfoCount, ref int nextClipInfoCount, ref int interruptingClipInfoCount, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> clipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> nextClipInfo, ref System.Collections.Generic.IList<UnityEngine.AnimatorClipInfo> interruptingClipInfo, ref bool shallInterpolateWeightTo1);
                /*0x73b4840*/ void GetAnimatorStateInfos(int layer, ref bool isInterruptionActive, ref UnityEngine.AnimatorStateInfo stateInfo, ref UnityEngine.AnimatorStateInfo nextStateInfo, ref UnityEngine.AnimatorStateInfo interruptingStateInfo, ref float interruptingClipTimeAddition);
                /*0x73b3eac*/ Spine.Animation GetAnimation(UnityEngine.AnimationClip clip);

                class OnClipAppliedDelegate : System.MulticastDelegate
                {
                    /*0x73b4c50*/ OnClipAppliedDelegate(object object, nint method);
                    /*0x73b4d5c*/ void Invoke(Spine.Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward);
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

                    /*0x73b4b80*/ ClipInfos();
                }

                class AnimationClipEqualityComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<UnityEngine.AnimationClip> Instance;

                    static /*0x73b4ddc*/ AnimationClipEqualityComparer();
                    /*0x73b4dd4*/ AnimationClipEqualityComparer();
                    /*0x73b4d74*/ bool Equals(UnityEngine.AnimationClip x, UnityEngine.AnimationClip y);
                    /*0x73b4dbc*/ int GetHashCode(UnityEngine.AnimationClip o);
                }

                class IntEqualityComparer : System.Collections.Generic.IEqualityComparer<int>
                {
                    static /*0x0*/ System.Collections.Generic.IEqualityComparer<int> Instance;

                    static /*0x73b4e60*/ IntEqualityComparer();
                    /*0x73b4e58*/ IntEqualityComparer();
                    /*0x73b4e44*/ bool Equals(int x, int y);
                    /*0x73b4e50*/ int GetHashCode(int o);
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

            static /*0x73baf40*/ SkeletonRenderer();
            static /*0x3907c14*/ T NewSpineGameObject<T>(Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            static /*0x3907c14*/ T AddSpineComponent<T>(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset, bool quiet);
            /*0x73b377c*/ SkeletonRenderer();
            /*0x73b4ec8*/ Spine.Unity.UpdateMode get_UpdateMode();
            /*0x73b4ed0*/ void set_UpdateMode(Spine.Unity.UpdateMode value);
            /*0x73b4ed8*/ void add_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73b4f74*/ void remove_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73b5010*/ void add_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73b50cc*/ void remove_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value);
            /*0x73b5188*/ void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73b5224*/ void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value);
            /*0x73b52c0*/ System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> get_CustomMaterialOverride();
            /*0x73b52c8*/ System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> get_CustomSlotMaterials();
            /*0x73b52d0*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73b52ec*/ Spine.Skeleton get_Skeleton();
            /*0x73b5314*/ UnityEngine.Vector2 get_PhysicsPositionInheritanceFactor();
            /*0x73b531c*/ void set_PhysicsPositionInheritanceFactor(UnityEngine.Vector2 value);
            /*0x73b53ec*/ float get_PhysicsRotationInheritanceFactor();
            /*0x73b53f4*/ void set_PhysicsRotationInheritanceFactor(float value);
            /*0x73b544c*/ UnityEngine.Transform get_PhysicsMovementRelativeTo();
            /*0x73b5454*/ void set_PhysicsMovementRelativeTo(UnityEngine.Transform value);
            /*0x73b53d4*/ void ResetLastPosition();
            /*0x73b5434*/ void ResetLastRotation();
            /*0x73b57e8*/ void ResetLastPositionAndRotation();
            /*0x73b580c*/ void add_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73b58a8*/ void remove_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73b5944*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73b59e4*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73b5a84*/ Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset();
            /*0x73b5a8c*/ void SetMeshSettings(Spine.Unity.MeshGenerator.Settings settings);
            /*0x73b5adc*/ void Awake();
            /*0x73b5b18*/ void OnDisable();
            /*0x73b5b38*/ void OnDestroy();
            /*0x73b5b60*/ void ClearState();
            /*0x73b5c38*/ void EnsureMeshGeneratorCapacity(int minimumVertexCount);
            /*0x73b1c68*/ void Initialize(bool overwrite, bool quiet);
            /*0x73b5fc0*/ void ApplyTransformMovementToPhysics();
            /*0x73b54fc*/ UnityEngine.Vector2 GetPhysicsTransformPosition();
            /*0x73b5614*/ float GetPhysicsTransformRotation();
            /*0x73b6188*/ void UpdateWorldTransform(Spine.Skeleton.Physics physics);
            /*0x73b3694*/ void LateUpdate();
            /*0x73b61a4*/ void LateUpdateMesh();
            /*0x73ba28c*/ void OnBecameVisible();
            /*0x73ba2b0*/ void OnBecameInvisible();
            /*0x73ba2bc*/ void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators, bool updateStringArray);
            /*0x73ba3c8*/ void FindAndApplySeparatorSlots(System.Func<string, bool> slotNamePredicate, bool clearExistingSeparators, bool updateStringArray);
            /*0x73ba8d0*/ void ReapplySeparatorSlotNames();
            /*0x73b9ca4*/ void AssignSpriteMaskMaterials();
            /*0x73baa18*/ bool InitSpriteMaskMaterialsInsideMask();
            /*0x73baa40*/ bool InitSpriteMaskMaterialsOutsideMask();
            /*0x73baa68*/ bool InitSpriteMaskMaterialsForMaskType(UnityEngine.Rendering.CompareFunction maskFunction, ref UnityEngine.Material[] materialsToFill);
            /*0x73b9eac*/ void HandleOnDemandLoading();
            /*0x73ba094*/ void SetMaterialSettingsToFixDrawOrder();

            class SpriteMaskInteractionMaterials
            {
                /*0x10*/ UnityEngine.Material[] materialsMaskDisabled;
                /*0x18*/ UnityEngine.Material[] materialsInsideMask;
                /*0x20*/ UnityEngine.Material[] materialsOutsideMask;

                /*0x73b9a60*/ SpriteMaskInteractionMaterials();
                /*0x73b9a14*/ bool get_AnyMaterialCreated();
            }

            class InstructionDelegate : System.MulticastDelegate
            {
                /*0x73bafdc*/ InstructionDelegate(object object, nint method);
                /*0x73bb0e4*/ void Invoke(Spine.Unity.SkeletonRendererInstruction instruction);
            }

            class SkeletonRendererDelegate : System.MulticastDelegate
            {
                /*0x73bb0f8*/ SkeletonRendererDelegate(object object, nint method);
                /*0x73bb200*/ void Invoke(Spine.Unity.SkeletonRenderer skeletonRenderer);
            }

            class <>c__DisplayClass99_0
            {
                /*0x10*/ string startsWith;

                /*0x73ba3c0*/ <>c__DisplayClass99_0();
                /*0x73bb214*/ bool <FindAndApplySeparatorSlots>b__0(string slotName);
            }
        }

        class SkeletonGraphicCustomMaterials : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonGraphic skeletonGraphic;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride> customTextureOverrides;

            /*0x73bba68*/ SkeletonGraphicCustomMaterials();
            /*0x73bb238*/ void SetCustomMaterialOverrides();
            /*0x73bb394*/ void RemoveCustomMaterialOverrides();
            /*0x73bb550*/ void SetCustomTextureOverrides();
            /*0x73bb6ac*/ void RemoveCustomTextureOverrides();
            /*0x73bb868*/ void OnEnable();
            /*0x73bb9a8*/ void OnDisable();

            struct AtlasMaterialOverride : System.IEquatable<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride>
            {
                /*0x10*/ bool overrideEnabled;
                /*0x18*/ UnityEngine.Texture originalTexture;
                /*0x20*/ UnityEngine.Material replacementMaterial;

                /*0x73bbb44*/ bool Equals(Spine.Unity.SkeletonGraphicCustomMaterials.AtlasMaterialOverride other);
            }

            struct AtlasTextureOverride : System.IEquatable<Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride>
            {
                /*0x10*/ bool overrideEnabled;
                /*0x18*/ UnityEngine.Texture originalTexture;
                /*0x20*/ UnityEngine.Texture replacementTexture;

                /*0x73bbc08*/ bool Equals(Spine.Unity.SkeletonGraphicCustomMaterials.AtlasTextureOverride other);
            }
        }

        class SkeletonRendererCustomMaterials : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Spine.Unity.SkeletonRenderer skeletonRenderer;
            /*0x28*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials;
            /*0x30*/ System.Collections.Generic.List<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;

            /*0x73bc57c*/ SkeletonRendererCustomMaterials();
            /*0x73bbccc*/ void SetCustomSlotMaterials();
            /*0x73bbe6c*/ void RemoveCustomSlotMaterials();
            /*0x73bc05c*/ void SetCustomMaterialOverrides();
            /*0x73bc1b8*/ void RemoveCustomMaterialOverrides();
            /*0x73bc374*/ void OnEnable();
            /*0x73bc4bc*/ void OnDisable();

            struct SlotMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ string slotName;
                /*0x20*/ UnityEngine.Material material;

                /*0x73bc658*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.SlotMaterialOverride other);
            }

            struct AtlasMaterialOverride : System.IEquatable<Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride>
            {
                /*0x10*/ bool overrideDisabled;
                /*0x18*/ UnityEngine.Material originalMaterial;
                /*0x20*/ UnityEngine.Material replacementMaterial;

                /*0x73bc6f8*/ bool Equals(Spine.Unity.SkeletonRendererCustomMaterials.AtlasMaterialOverride other);
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

            static /*0x73bcd5c*/ Spine.Unity.SkeletonPartsRenderer NewPartsRendererGameObject(UnityEngine.Transform parent, string name, int sortingOrder);
            /*0x73bcf40*/ SkeletonPartsRenderer();
            /*0x73bc7bc*/ Spine.Unity.MeshGenerator get_MeshGenerator();
            /*0x73bc910*/ UnityEngine.MeshRenderer get_MeshRenderer();
            /*0x73bc928*/ UnityEngine.MeshFilter get_MeshFilter();
            /*0x73bc940*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonPartsRenderer.SkeletonPartsRendererDelegate value);
            /*0x73bc9dc*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonPartsRenderer.SkeletonPartsRendererDelegate value);
            /*0x73bc7d4*/ void LazyIntialize();
            /*0x73bca78*/ void OnDestroy();
            /*0x73bca8c*/ void ClearMesh();
            /*0x73bcab4*/ void RenderParts(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x73bcd28*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock block);

            class SkeletonPartsRendererDelegate : System.MulticastDelegate
            {
                /*0x73bcfac*/ SkeletonPartsRendererDelegate(object object, nint method);
                /*0x73bd0b4*/ void Invoke(Spine.Unity.SkeletonPartsRenderer skeletonPartsRenderer);
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

            static /*0x73bd334*/ Spine.Unity.SkeletonRenderSeparator AddToSkeletonRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer, int sortingLayerID, int extraPartsRenderers, int sortingOrderIncrement, int baseSortingOrder, bool addMinimumPartsRenderers);
            /*0x73be290*/ SkeletonRenderSeparator();
            /*0x73bd0c8*/ Spine.Unity.SkeletonRenderer get_SkeletonRenderer();
            /*0x73bd0d0*/ void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value);
            /*0x73bd1fc*/ void add_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73bd298*/ void remove_OnMeshAndMaterialsUpdated(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value);
            /*0x73bd8f8*/ Spine.Unity.SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement, string name);
            /*0x73bd5a8*/ void OnEnable();
            /*0x73bdac0*/ void Update();
            /*0x73bdce0*/ void OnDisable();
            /*0x73bdac4*/ void UpdateVisibility();
            /*0x73bdf58*/ void HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            /*0x73bddc4*/ void ClearPartsRendererMeshes();
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

            /*0x73be718*/ ActivateBasedOnFlipDirection();
            /*0x73be328*/ void Start();
            /*0x73be408*/ void FixedUpdate();
            /*0x73be4dc*/ void HandleFlip(bool isFlippedX);
            /*0x73be594*/ void ResetJointPositions(UnityEngine.HingeJoint2D[] joints);
            /*0x73be650*/ void CompensateMovementAfterFlipX(UnityEngine.Transform toActivate, UnityEngine.Transform toDeactivate);
        }

        class FollowLocationRigidbody : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ UnityEngine.Rigidbody ownRigidbody;

            /*0x73be7d8*/ FollowLocationRigidbody();
            /*0x73be720*/ void Awake();
            /*0x73be778*/ void FixedUpdate();
        }

        class FollowLocationRigidbody2D : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ bool followFlippedX;
            /*0x30*/ UnityEngine.Rigidbody2D ownRigidbody;

            /*0x73be8ec*/ FollowLocationRigidbody2D();
            /*0x73be7e0*/ void Awake();
            /*0x73be838*/ void FixedUpdate();
        }

        class FollowSkeletonUtilityRootRotation : UnityEngine.MonoBehaviour
        {
            static float FLIP_ANGLE_THRESHOLD = 100;
            /*0x20*/ UnityEngine.Transform reference;
            /*0x28*/ UnityEngine.Vector3 prevLocalEulerAngles;

            /*0x73beb9c*/ FollowSkeletonUtilityRootRotation();
            /*0x73be8f4*/ void Start();
            /*0x73be924*/ void FixedUpdate();
            /*0x73bea0c*/ void CompensatePositionToYRotation();
            /*0x73bead4*/ void CompensatePositionToXRotation();
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

            static /*0x73beba4*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(Spine.Skeleton skeleton, string skinName, string slotName, string attachmentName, UnityEngine.Transform parent, bool isTrigger);
            static /*0x73beee0*/ UnityEngine.PolygonCollider2D AddBoundingBoxGameObject(string name, Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.Transform parent, bool isTrigger);
            static /*0x73bf09c*/ UnityEngine.PolygonCollider2D AddBoundingBoxAsComponent(Spine.BoundingBoxAttachment box, Spine.Slot slot, UnityEngine.GameObject gameObject, bool isTrigger);
            static /*0x73bf13c*/ void SetColliderPointsLocal(UnityEngine.PolygonCollider2D collider, Spine.Slot slot, Spine.BoundingBoxAttachment box, float scale);
            static /*0x73bf274*/ UnityEngine.Bounds GetBoundingBoxBounds(Spine.BoundingBoxAttachment boundingBox, float depth);
            static /*0x73bf368*/ UnityEngine.Rigidbody2D AddBoneRigidbody2D(UnityEngine.GameObject gameObject, bool isKinematic, float gravityScale);
            /*0x73c242c*/ SkeletonUtility();
            /*0x73bf454*/ void add_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x73bf4f0*/ void remove_OnReset(Spine.Unity.SkeletonUtility.SkeletonUtilityDelegate value);
            /*0x73bf58c*/ void Update();
            /*0x73bf810*/ void UpdateToMeshScaleAndOffset(Spine.Unity.MeshGeneratorBuffers ignoredParameter);
            /*0x73bfae0*/ Spine.Unity.ISkeletonComponent get_SkeletonComponent();
            /*0x73bfbc4*/ Spine.Skeleton get_Skeleton();
            /*0x73bfc7c*/ bool get_IsValid();
            /*0x73bfd44*/ float get_PositionScale();
            /*0x73bfd4c*/ UnityEngine.Vector2 get_PositionOffset();
            /*0x73bfd54*/ void ResubscribeEvents();
            /*0x73bfd6c*/ void ResubscribeIndependentEvents();
            /*0x73c00f0*/ void ResubscribeDependentEvents();
            /*0x73c0550*/ void OnEnable();
            /*0x73c0bc0*/ void Start();
            /*0x73c0bc4*/ void OnDisable();
            /*0x73c0f60*/ void HandleRendererReset(Spine.Unity.SkeletonRenderer r);
            /*0x73c0f8c*/ void HandleRendererReset(Spine.Unity.SkeletonGraphic g);
            /*0x73c0fb8*/ void RegisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x73c1098*/ void UnregisterBone(Spine.Unity.SkeletonUtilityBone bone);
            /*0x73c10f0*/ void RegisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x73c11d0*/ void UnregisterConstraint(Spine.Unity.SkeletonUtilityConstraint constraint);
            /*0x73c07a4*/ void CollectBones();
            /*0x73bf970*/ void UpdateLocal(Spine.Unity.ISkeletonAnimation anim);
            /*0x73bfa2c*/ void UpdateWorld(Spine.Unity.ISkeletonAnimation anim);
            /*0x73bfad8*/ void UpdateComplete(Spine.Unity.ISkeletonAnimation anim);
            /*0x73c1a5c*/ void UpdateAllBones(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x73c1b3c*/ UnityEngine.Transform GetBoneRoot();
            /*0x73c1d68*/ UnityEngine.GameObject SpawnRoot(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73c20c0*/ UnityEngine.GameObject SpawnHierarchy(Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73c21c8*/ UnityEngine.GameObject SpawnBoneRecursively(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
            /*0x73c1e70*/ UnityEngine.GameObject SpawnBone(Spine.Bone bone, UnityEngine.Transform parent, Spine.Unity.SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);

            class SkeletonUtilityDelegate : System.MulticastDelegate
            {
                /*0x73c254c*/ SkeletonUtilityDelegate(object object, nint method);
                /*0x73c25e8*/ void Invoke();
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

            static /*0x73c282c*/ bool BoneTransformModeIncompatible(Spine.Bone bone);
            /*0x73c28dc*/ SkeletonUtilityBone();
            /*0x73c25fc*/ bool get_IncompatibleTransformMode();
            /*0x73c22b4*/ void Reset();
            /*0x73c2604*/ void OnEnable();
            /*0x73c2750*/ void HandleOnReset();
            /*0x73c2754*/ void OnDisable();
            /*0x73c1228*/ void DoUpdate(Spine.Unity.SkeletonUtilityBone.UpdatePhase phase);
            /*0x73c285c*/ void AddBoundingBox(string skinName, string slotName, string attachmentName);

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

            /*0x73c29bc*/ SkeletonUtilityConstraint();
            /*0x73c28f4*/ void OnEnable();
            /*0x73c29a0*/ void OnDisable();
            /*0x380cb08*/ void DoUpdate();
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
            /*0x73c29c4*/ ISkeletonAnimationDelegate(object object, nint method);
            /*0x73c2acc*/ void Invoke(Spine.Unity.ISkeletonAnimation animated);
        }

        class UpdateBonesDelegate : System.MulticastDelegate
        {
            /*0x73c0448*/ UpdateBonesDelegate(object object, nint method);
            /*0x73c2ae0*/ void Invoke(Spine.Unity.ISkeletonAnimation animated);
        }

        interface ISpineComponent
        {
        }

        interface ISkeletonAnimation : Spine.Unity.ISpineComponent
        {
            /*0x380d83c*/ void add_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x380d83c*/ void remove_OnAnimationRebuild(Spine.Unity.ISkeletonAnimationDelegate value);
            /*0x380d83c*/ void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x380d83c*/ void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value);
            /*0x380d83c*/ void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x380d83c*/ void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value);
            /*0x380d83c*/ void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x380d83c*/ void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value);
            /*0x380b6a0*/ Spine.Unity.UpdateTiming get_UpdateTiming();
        }

        interface IHasSkeletonDataAsset : Spine.Unity.ISpineComponent
        {
        }

        interface ISkeletonComponent : Spine.Unity.ISpineComponent
        {
            /*0x380b9e8*/ Spine.Skeleton get_Skeleton();
        }

        interface IAnimationStateComponent : Spine.Unity.ISpineComponent
        {
            /*0x380b9e8*/ Spine.AnimationState get_AnimationState();
        }

        class DoubleBuffered<T>
        {
            /*0x0*/ T a;
            /*0x0*/ T b;
            /*0x0*/ bool usingA;

            /*0x380cb08*/ DoubleBuffered();
            /*0x3907c14*/ T GetCurrent();
            /*0x3907c14*/ T GetNext();
        }

        class MeshGeneratorDelegate : System.MulticastDelegate
        {
            /*0x73c03a8*/ MeshGeneratorDelegate(object object, nint method);
            /*0x73c2af4*/ void Invoke(Spine.Unity.MeshGeneratorBuffers buffers);
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

            static /*0x73c35ec*/ MeshGenerator();
            static /*0x73b67e4*/ void GenerateSingleSubmeshInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, UnityEngine.Material material);
            static /*0x73c2b38*/ bool RequiresMultipleSubmeshesByDrawOrder(Spine.Skeleton skeleton);
            static /*0x73b8ccc*/ void GenerateSkeletonRendererInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials, System.Collections.Generic.List<Spine.Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles);
            static /*0x73b6d08*/ void TryReplaceMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> workingSubmeshInstructions, System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride);
            static /*0x73c3224*/ void SolveTangents2DEnsureSize(ref UnityEngine.Vector4[] tangentBuffer, ref UnityEngine.Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength);
            static /*0x73c32fc*/ void SolveTangents2DTriangles(UnityEngine.Vector2[] tempTanBuffer, int[] triangles, int triangleCount, UnityEngine.Vector3[] vertices, UnityEngine.Vector2[] uvs, int vertexCount);
            static /*0x73c34d0*/ void SolveTangents2DBuffer(UnityEngine.Vector4[] tangents, UnityEngine.Vector2[] tempTanBuffer, int vertexCount);
            /*0x73bac54*/ MeshGenerator();
            /*0x73bcd0c*/ int get_VertexCount();
            /*0x73b95b4*/ Spine.Unity.MeshGeneratorBuffers get_Buffers();
            /*0x73c2b30*/ Spine.SkeletonClipping get_SkeletonClipping();
            /*0x73b5ee8*/ void Begin();
            /*0x73b6e24*/ void AddSubmesh(Spine.Unity.SubmeshInstruction instruction, bool updateTriangles);
            /*0x73b9518*/ void BuildMesh(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x73b7abc*/ void BuildMeshWithArrays(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles);
            /*0x73c3014*/ void ScaleVertexData(float scale);
            /*0x73c3098*/ void ScaleAndOffsetVertexData(float scale, UnityEngine.Vector2 offset2D);
            /*0x73c3144*/ UnityEngine.Bounds GetMeshBounds();
            /*0x73c2e58*/ void AddAttachmentTintBlack(float r2, float g2, float b2, float a, int vertexCount);
            /*0x73c2f40*/ void PrepareOptionalUVBuffer(ref Spine.ExposedList<UnityEngine.Vector2> uvBuffer, int vertexCount);
            /*0x73c31a8*/ void ResizeOptionalUVBuffer(ref Spine.ExposedList<UnityEngine.Vector2> uvBuffer, int vertexCount);
            /*0x73b9660*/ void FillVertexData(UnityEngine.Mesh mesh);
            /*0x73b9afc*/ void FillLateVertexData(UnityEngine.Mesh mesh);
            /*0x73b9970*/ void FillTriangles(UnityEngine.Mesh mesh);
            /*0x73b5c5c*/ void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack, bool includeTangents, bool includeNormals);

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

                static /*0x73c378c*/ Spine.Unity.MeshGenerator.Settings get_Default();
            }
        }

        class MeshRendererBuffers : System.IDisposable
        {
            /*0x10*/ Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> doubleBufferedMesh;
            /*0x18*/ Spine.ExposedList<UnityEngine.Material> submeshMaterials;
            /*0x20*/ UnityEngine.Material[] sharedMaterials;

            /*0x73c3d1c*/ MeshRendererBuffers();
            /*0x73c3798*/ void Initialize();
            /*0x73c38b4*/ UnityEngine.Material[] GetUpdatedSharedMaterialsArray();
            /*0x73c3954*/ bool MaterialsChangedInLastUpdate();
            /*0x73c39f8*/ void UpdateSharedMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions);
            /*0x73c3b28*/ Spine.Unity.MeshRendererBuffers.SmartMesh GetNextMesh();
            /*0x73c3b78*/ void Clear();
            /*0x73c3bfc*/ void Dispose();

            class SmartMesh : System.IDisposable
            {
                /*0x10*/ UnityEngine.Mesh mesh;
                /*0x18*/ Spine.Unity.SkeletonRendererInstruction instructionUsed;

                /*0x73c3e5c*/ SmartMesh();
                /*0x73c3888*/ void Clear();
                /*0x73c3c88*/ void Dispose();
            }
        }

        class SkeletonRendererInstruction
        {
            /*0x10*/ Spine.ExposedList<Spine.Unity.SubmeshInstruction> submeshInstructions;
            /*0x18*/ bool immutableTriangles;
            /*0x19*/ bool hasActiveClipping;
            /*0x1c*/ int rawVertexCount;
            /*0x20*/ Spine.ExposedList<Spine.Attachment> attachments;

            static /*0x73c458c*/ bool GeometryNotEqual(Spine.Unity.SkeletonRendererInstruction a, Spine.Unity.SkeletonRendererInstruction b);
            /*0x73c3f74*/ SkeletonRendererInstruction();
            /*0x73c3dd4*/ void Clear();
            /*0x73c4058*/ void SetWithSubset(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
            /*0x73c43e0*/ void Set(Spine.Unity.SkeletonRendererInstruction other);
        }

        class SpineMesh
        {
            static /*0x73c3ed8*/ UnityEngine.Mesh NewSkeletonMesh();
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

            /*0x73c4730*/ string ToString();
        }

        class BlendModeMaterialsAsset : Spine.Unity.SkeletonDataModifierAsset
        {
            /*0x18*/ UnityEngine.Material multiplyMaterialTemplate;
            /*0x20*/ UnityEngine.Material screenMaterialTemplate;
            /*0x28*/ UnityEngine.Material additiveMaterialTemplate;
            /*0x30*/ bool applyAdditiveMaterial;

            static /*0x73c4980*/ void ApplyMaterials(Spine.SkeletonData skeletonData, UnityEngine.Material multiplyTemplate, UnityEngine.Material screenTemplate, UnityEngine.Material additiveTemplate, bool includeAdditiveSlots);
            /*0x73c51d4*/ BlendModeMaterialsAsset();
            /*0x73c4968*/ void Apply(Spine.SkeletonData skeletonData);

            class AtlasMaterialCache : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<Spine.AtlasPage, UnityEngine.Material>, Spine.AtlasPage> cache;

                /*0x73c50ec*/ AtlasMaterialCache();
                /*0x73c5174*/ Spine.AtlasRegion CloneAtlasRegionWithMaterial(Spine.AtlasRegion originalRegion, UnityEngine.Material materialTemplate);
                /*0x73c51e4*/ Spine.AtlasPage GetAtlasPageWithMaterial(Spine.AtlasPage originalPage, UnityEngine.Material materialTemplate);
                /*0x73c5420*/ void Dispose();
            }
        }

        class SpineAttributeBase : UnityEngine.PropertyAttribute
        {
            /*0x18*/ string dataField;
            /*0x20*/ string startsWith;
            /*0x28*/ bool includeNone;
            /*0x29*/ bool fallbackToTextField;
            /*0x2a*/ bool avoidGenericMenu;

            /*0x73c5470*/ SpineAttributeBase();
        }

        class SpineBone : Spine.Unity.SpineAttributeBase
        {
            /*0x73c54e0*/ SpineBone(string startsWith, string dataField, bool includeNone, bool fallbackToTextField);
        }

        class SpineSlot : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool containsBoundingBoxes;

            /*0x73c553c*/ SpineSlot(string startsWith, string dataField, bool containsBoundingBoxes, bool includeNone, bool fallbackToTextField);
        }

        class SpineAnimation : Spine.Unity.SpineAttributeBase
        {
            /*0x73c55a8*/ SpineAnimation(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool avoidGenericMenu);
        }

        class SpineEvent : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool audioOnly;

            /*0x73c5614*/ SpineEvent(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool audioOnly);
        }

        class SpineSkin : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool defaultAsEmptyString;

            /*0x73c5680*/ SpineSkin(string startsWith, string dataField, bool includeNone, bool fallbackToTextField, bool defaultAsEmptyString, bool avoidGenericMenu);
        }

        class SpineAttachment : Spine.Unity.SpineAttributeBase
        {
            /*0x2b*/ bool returnAttachmentPath;
            /*0x2c*/ bool currentSkinOnly;
            /*0x2d*/ bool placeholdersOnly;
            /*0x30*/ string skinField;
            /*0x38*/ string slotField;

            /*0x73c56f4*/ SpineAttachment(bool currentSkinOnly, bool returnAttachmentPath, bool placeholdersOnly, string slotField, string dataField, string skinField, bool includeNone, bool fallbackToTextField);
        }

        class SkeletonExtensions
        {
            static /*0x73c580c*/ void SetColor(Spine.Skeleton skeleton, UnityEngine.Color color);
            static /*0x73c5828*/ UnityEngine.Quaternion GetQuaternion(Spine.Bone bone);
            static /*0x73c5868*/ void GetWorldToLocalMatrix(Spine.Bone bone, ref float ia, ref float ib, ref float ic, ref float id);
            static /*0x73c58c0*/ UnityEngine.Vector2 WorldToLocal(Spine.Bone bone, UnityEngine.Vector2 worldPosition);
            static /*0x73c58f0*/ UnityEngine.Vector2[] GetLocalVertices(Spine.VertexAttachment va, Spine.Slot slot, UnityEngine.Vector2[] buffer);
        }

        namespace AnimationTools
        {
            class TimelineExtensions
            {
                static /*0x73c5ba4*/ UnityEngine.Vector2 Evaluate(Spine.TranslateTimeline timeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73c5c80*/ UnityEngine.Vector2 Evaluate(Spine.TranslateXTimeline xTimeline, Spine.TranslateYTimeline yTimeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73c5d98*/ float Evaluate(Spine.RotateTimeline timeline, float time, Spine.SkeletonData skeletonData);
                static /*0x73c5e2c*/ UnityEngine.Vector2 EvaluateTranslateXYMix(Spine.TransformConstraintTimeline timeline, float time);
                static /*0x73c5edc*/ float EvaluateRotateMix(Spine.TransformConstraintTimeline timeline, float time);
                static /*0x73c5f48*/ Spine.TranslateTimeline FindTranslateTimelineForBone(Spine.Animation a, int boneIndex);
                static /*0x3907c14*/ T FindTimelineForBone<T>(Spine.Animation a, int boneIndex);
                static /*0x73c6180*/ Spine.TransformConstraintTimeline FindTransformConstraintTimeline(Spine.Animation a, int transformConstraintIndex);
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

                static /*0x73c6610*/ AtlasUtilities();
                static /*0x73c63b8*/ void Init();
                static /*0x73c6404*/ void ClearCache();

                struct IntAndAtlasRegionKey
                {
                    /*0x10*/ int i;
                    /*0x18*/ Spine.AtlasRegion region;

                    /*0x73c68b0*/ int GetHashCode();
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
