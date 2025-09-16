class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7d352f4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7d353e8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    namespace TextCore
    {
        enum OTL_FeatureTag
        {
            kern = 1801810542,
            liga = 1818847073,
            mark = 1835102827,
            mkmk = 1835756907,
        }
    }
}

namespace TMPro
{
    class FastAction
    {
        /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

        /*0x7d35608*/ FastAction();
        /*0x7d353f0*/ void Add(System.Action rhs);
        /*0x7d354b0*/ void Remove(System.Action rhs);
        /*0x7d35570*/ void Call();
    }

    class FastAction<A>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

        /*0x38159dc*/ FastAction();
        /*0x3816710*/ void Add(System.Action<A> rhs);
        /*0x3816710*/ void Remove(System.Action<A> rhs);
        /*0x3910ae8*/ void Call(A a);
    }

    class FastAction<A, B>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

        /*0x38159dc*/ FastAction();
        /*0x3816710*/ void Add(System.Action<A, B> rhs);
        /*0x3816710*/ void Remove(System.Action<A, B> rhs);
        /*0x3910ae8*/ void Call(A a, B b);
    }

    class FastAction<A, B, C>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

        /*0x38159dc*/ FastAction();
        /*0x3816710*/ void Add(System.Action<A, B, C> rhs);
        /*0x3816710*/ void Remove(System.Action<A, B, C> rhs);
        /*0x3910ae8*/ void Call(A a, B b, C c);
    }

    struct GlyphAnchorPoint
    {
        /*0x10*/ float m_XCoordinate;
        /*0x14*/ float m_YCoordinate;

        /*0x7d356e4*/ float get_xCoordinate();
        /*0x7d356ec*/ void set_xCoordinate(float value);
        /*0x7d356f4*/ float get_yCoordinate();
        /*0x7d356fc*/ void set_yCoordinate(float value);
    }

    struct MarkPositionAdjustment
    {
        /*0x10*/ float m_XPositionAdjustment;
        /*0x14*/ float m_YPositionAdjustment;

        /*0x7d35724*/ MarkPositionAdjustment(float x, float y);
        /*0x7d35704*/ float get_xPositionAdjustment();
        /*0x7d3570c*/ void set_xPositionAdjustment(float value);
        /*0x7d35714*/ float get_yPositionAdjustment();
        /*0x7d3571c*/ void set_yPositionAdjustment(float value);
    }

    struct MarkToBaseAdjustmentRecord
    {
        /*0x10*/ uint m_BaseGlyphID;
        /*0x14*/ TMPro.GlyphAnchorPoint m_BaseGlyphAnchorPoint;
        /*0x1c*/ uint m_MarkGlyphID;
        /*0x20*/ TMPro.MarkPositionAdjustment m_MarkPositionAdjustment;

        /*0x7d3572c*/ uint get_baseGlyphID();
        /*0x7d35734*/ void set_baseGlyphID(uint value);
        /*0x7d3573c*/ TMPro.GlyphAnchorPoint get_baseGlyphAnchorPoint();
        /*0x7d35744*/ void set_baseGlyphAnchorPoint(TMPro.GlyphAnchorPoint value);
        /*0x7d3574c*/ uint get_markGlyphID();
        /*0x7d35754*/ void set_markGlyphID(uint value);
        /*0x7d3575c*/ TMPro.MarkPositionAdjustment get_markPositionAdjustment();
        /*0x7d35764*/ void set_markPositionAdjustment(TMPro.MarkPositionAdjustment value);
    }

    struct MarkToMarkAdjustmentRecord
    {
        /*0x10*/ uint m_BaseMarkGlyphID;
        /*0x14*/ TMPro.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;
        /*0x1c*/ uint m_CombiningMarkGlyphID;
        /*0x20*/ TMPro.MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

        /*0x7d3576c*/ uint get_baseMarkGlyphID();
        /*0x7d35774*/ void set_baseMarkGlyphID(uint value);
        /*0x7d3577c*/ TMPro.GlyphAnchorPoint get_baseMarkGlyphAnchorPoint();
        /*0x7d35784*/ void set_baseMarkGlyphAnchorPoint(TMPro.GlyphAnchorPoint value);
        /*0x7d3578c*/ uint get_combiningMarkGlyphID();
        /*0x7d35794*/ void set_combiningMarkGlyphID(uint value);
        /*0x7d3579c*/ TMPro.MarkPositionAdjustment get_combiningMarkPositionAdjustment();
        /*0x7d357a4*/ void set_combiningMarkPositionAdjustment(TMPro.MarkPositionAdjustment value);
    }

    struct SingleSubstitutionRecord
    {
    }

    struct MultipleSubstitutionRecord
    {
        /*0x10*/ uint m_TargetGlyphID;
        /*0x18*/ uint[] m_SubstituteGlyphIDs;

        /*0x7d357ac*/ uint get_targetGlyphID();
        /*0x7d357b4*/ void set_targetGlyphID(uint value);
        /*0x7d357bc*/ uint[] get_substituteGlyphIDs();
        /*0x7d357c4*/ void set_substituteGlyphIDs(uint[] value);
    }

    struct AlternateSubstitutionRecord
    {
    }

    struct LigatureSubstitutionRecord
    {
        /*0x10*/ uint[] m_ComponentGlyphIDs;
        /*0x18*/ uint m_LigatureGlyphID;

        static /*0x7d357ec*/ bool op_Equality(TMPro.LigatureSubstitutionRecord lhs, TMPro.LigatureSubstitutionRecord rhs);
        static /*0x7d35880*/ bool op_Inequality(TMPro.LigatureSubstitutionRecord lhs, TMPro.LigatureSubstitutionRecord rhs);
        /*0x7d357cc*/ uint[] get_componentGlyphIDs();
        /*0x7d357d4*/ void set_componentGlyphIDs(uint[] value);
        /*0x7d357dc*/ uint get_ligatureGlyphID();
        /*0x7d357e4*/ void set_ligatureGlyphID(uint value);
    }

    interface ITextPreprocessor
    {
        /*0x3814a3c*/ string PreprocessText(string text);
    }

    class MaterialReferenceManager
    {
        static /*0x0*/ TMPro.MaterialReferenceManager s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
        /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        /*0x28*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;

        static /*0x7d35898*/ TMPro.MaterialReferenceManager get_instance();
        static /*0x7d35aa0*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d35bb4*/ void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x7d35cc8*/ void AddSpriteAsset(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x7d35dd4*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
        static /*0x7d35e6c*/ void AddColorGradientPreset(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        static /*0x7d36018*/ bool TryGetFontAsset(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x7d360c0*/ bool TryGetSpriteAsset(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x7d36168*/ bool TryGetColorGradientPreset(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        static /*0x7d36210*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
        /*0x7d3591c*/ MaterialReferenceManager();
        /*0x7d35ac0*/ void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset);
        /*0x7d35bd4*/ void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset);
        /*0x7d35cf8*/ void AddSpriteAssetInternal(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        /*0x7d35e04*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
        /*0x7d35e9c*/ void AddColorGradientPreset_Internal(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        /*0x7d35f40*/ bool Contains(TMPro.TMP_FontAsset font);
        /*0x7d35fac*/ bool Contains(TMPro.TMP_SpriteAsset sprite);
        /*0x7d36048*/ bool TryGetFontAssetInternal(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        /*0x7d360f0*/ bool TryGetSpriteAssetInternal(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        /*0x7d36198*/ bool TryGetColorGradientPresetInternal(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        /*0x7d36240*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
    }

    struct TMP_MaterialReference
    {
        /*0x10*/ UnityEngine.Material material;
        /*0x18*/ int referenceCount;
    }

    struct MaterialReference
    {
        /*0x10*/ int index;
        /*0x18*/ TMPro.TMP_FontAsset fontAsset;
        /*0x20*/ TMPro.TMP_SpriteAsset spriteAsset;
        /*0x28*/ UnityEngine.Material material;
        /*0x30*/ bool isDefaultMaterial;
        /*0x31*/ bool isFallbackMaterial;
        /*0x38*/ UnityEngine.Material fallbackMaterial;
        /*0x40*/ float padding;
        /*0x44*/ int referenceCount;

        static /*0x7d36374*/ bool Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset);
        static /*0x7d36470*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        static /*0x7d366a8*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        /*0x7d362b8*/ MaterialReference(int index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
    }

    enum TextContainerAnchors
    {
        TopLeft = 0,
        Top = 1,
        TopRight = 2,
        Left = 3,
        Middle = 4,
        Right = 5,
        BottomLeft = 6,
        Bottom = 7,
        BottomRight = 8,
        Custom = 9,
    }

    class TextContainer : UnityEngine.EventSystems.UIBehaviour
    {
        static /*0x0*/ UnityEngine.Vector2 k_defaultSize;
        /*0x20*/ bool m_hasChanged;
        /*0x24*/ UnityEngine.Vector2 m_pivot;
        /*0x2c*/ TMPro.TextContainerAnchors m_anchorPosition;
        /*0x30*/ UnityEngine.Rect m_rect;
        /*0x40*/ bool m_isDefaultWidth;
        /*0x41*/ bool m_isDefaultHeight;
        /*0x42*/ bool m_isAutoFitting;
        /*0x48*/ UnityEngine.Vector3[] m_corners;
        /*0x50*/ UnityEngine.Vector3[] m_worldCorners;
        /*0x58*/ UnityEngine.Vector4 m_margins;
        /*0x68*/ UnityEngine.RectTransform m_rectTransform;
        /*0x70*/ TMPro.TextMeshPro m_textMeshPro;

        static /*0x7d372b8*/ TextContainer();
        /*0x7d37230*/ TextContainer();
        /*0x7d368a8*/ bool get_hasChanged();
        /*0x7d368b0*/ void set_hasChanged(bool value);
        /*0x7d368bc*/ UnityEngine.Vector2 get_pivot();
        /*0x7d368c4*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x7d36b24*/ TMPro.TextContainerAnchors get_anchorPosition();
        /*0x7d36b2c*/ void set_anchorPosition(TMPro.TextContainerAnchors value);
        /*0x7d36be0*/ UnityEngine.Rect get_rect();
        /*0x7d36bec*/ void set_rect(UnityEngine.Rect value);
        /*0x7d36c34*/ UnityEngine.Vector2 get_size();
        /*0x7d36c3c*/ void set_size(UnityEngine.Vector2 value);
        /*0x7d36c84*/ float get_width();
        /*0x7d36c8c*/ void set_width(float value);
        /*0x7d36ca0*/ float get_height();
        /*0x7d36ca8*/ void set_height(float value);
        /*0x7d36cbc*/ bool get_isDefaultWidth();
        /*0x7d36cc4*/ bool get_isDefaultHeight();
        /*0x7d36ccc*/ bool get_isAutoFitting();
        /*0x7d36cd4*/ void set_isAutoFitting(bool value);
        /*0x7d36ce0*/ UnityEngine.Vector3[] get_corners();
        /*0x7d36ce8*/ UnityEngine.Vector3[] get_worldCorners();
        /*0x7d36cf0*/ UnityEngine.Vector4 get_margins();
        /*0x7d36cfc*/ void set_margins(UnityEngine.Vector4 value);
        /*0x7d36d58*/ UnityEngine.RectTransform get_rectTransform();
        /*0x7d36e00*/ TMPro.TextMeshPro get_textMeshPro();
        /*0x7d36ea8*/ void Awake();
        /*0x7d36f70*/ void OnEnable();
        /*0x7d36f74*/ void OnDisable();
        /*0x7d36a14*/ void OnContainerChanged();
        /*0x7d370cc*/ void OnRectTransformDimensionsChange();
        /*0x7d36c7c*/ void SetRect(UnityEngine.Vector2 size);
        /*0x7d36f78*/ void UpdateCorners();
        /*0x7d36b68*/ UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor);
        /*0x7d3691c*/ TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot);
    }

    class TextMeshPro : TMPro.TMP_Text, UnityEngine.UI.ILayoutElement
    {
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;
        static /*0x38*/ Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;
        static /*0x40*/ Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;
        static /*0x48*/ Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;
        static /*0x50*/ Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;
        static /*0x58*/ Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;
        static /*0x60*/ Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;
        static /*0x68*/ Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;
        static /*0x70*/ Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;
        static /*0x78*/ Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;
        static /*0x80*/ Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveTextExtentMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0xa0*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6e0*/ int _SortingLayer;
        /*0x6e4*/ int _SortingLayerID;
        /*0x6e8*/ int _SortingOrder;
        /*0x6f0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6f8*/ bool m_hasFontAssetChanged;
        /*0x6fc*/ float m_previousLossyScaleY;
        /*0x700*/ UnityEngine.Renderer m_renderer;
        /*0x708*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x710*/ bool m_isFirstAllocation;
        /*0x714*/ int m_max_characters;
        /*0x718*/ int m_max_numberOfLines;
        /*0x720*/ TMPro.TMP_SubMesh[] m_subTextObjects;
        /*0x728*/ TMPro.MaskingTypes m_maskType;
        /*0x72c*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x770*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x778*/ bool m_isRegisteredForEvents;
        /*0x780*/ System.Collections.Generic.Dictionary<int, int> materialIndexPairs;

        static /*0x7d3e0f8*/ TextMeshPro();
        /*0x7d3dfcc*/ TextMeshPro();
        /*0x7d37308*/ int get_sortingLayerID();
        /*0x7d3743c*/ void set_sortingLayerID(int value);
        /*0x7d375fc*/ int get_sortingOrder();
        /*0x7d37690*/ void set_sortingOrder(int value);
        /*0x7d37850*/ bool get_autoSizeTextContainer();
        /*0x7d37858*/ void set_autoSizeTextContainer(bool value);
        /*0x7d378f8*/ TMPro.TextContainer get_textContainer();
        /*0x7d37900*/ UnityEngine.Transform get_transform();
        /*0x7d3739c*/ UnityEngine.Renderer get_renderer();
        /*0x7d379a0*/ UnityEngine.Mesh get_mesh();
        /*0x7d37a60*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x7d37b84*/ TMPro.MaskingTypes get_maskType();
        /*0x7d37b8c*/ void set_maskType(TMPro.MaskingTypes value);
        /*0x7d37cdc*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords);
        /*0x7d37dc4*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, float softnessX, float softnessY);
        /*0x7d37f14*/ void SetVerticesDirty();
        /*0x7d37fc4*/ void SetLayoutDirty();
        /*0x7d38094*/ void SetMaterialDirty();
        /*0x7d380a4*/ void SetAllDirty();
        /*0x7d380e8*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x7d38418*/ void UpdateMaterial();
        /*0x7d3854c*/ void UpdateMeshPadding();
        /*0x7d3864c*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x7d38660*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x7d386cc*/ void ClearMesh(bool updateMesh);
        /*0x7d3878c*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d38840*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d388f4*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x7d3890c*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x7d38ab0*/ void UpdateVertexData();
        /*0x7d38c84*/ void UpdateFontAsset();
        /*0x7d38c94*/ void CalculateLayoutInputHorizontal();
        /*0x7d38c98*/ void CalculateLayoutInputVertical();
        /*0x7d38c9c*/ void Awake();
        /*0x7d38fcc*/ void OnEnable();
        /*0x7d390c8*/ void OnDisable();
        /*0x7d39174*/ void OnDestroy();
        /*0x7d39240*/ void LoadFontAsset();
        /*0x7d39818*/ void ValidateEnvMapProperty();
        /*0x7d39944*/ void UpdateEnvMapMatrix();
        /*0x7d37b94*/ void SetMask(TMPro.MaskingTypes maskType);
        /*0x7d37d24*/ void SetMaskCoordinates(UnityEngine.Vector4 coords);
        /*0x7d37e24*/ void SetMaskCoordinates(UnityEngine.Vector4 coords, float softX, float softY);
        /*0x7d39b78*/ void EnableMasking();
        /*0x7d39cf0*/ void DisableMasking();
        /*0x7d39c70*/ void UpdateMask();
        /*0x7d39eb0*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x7d39fd4*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x7d3a1a8*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x7d3a1ec*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x7d3a39c*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x7d3a740*/ void SetOutlineThickness(float thickness);
        /*0x7d3a894*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x7d3a9cc*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x7d39de4*/ void CreateMaterialInstance();
        /*0x7d3ab04*/ void SetShaderDepth();
        /*0x7d3ab34*/ void SetCulling();
        /*0x7d3add0*/ void SetPerspectiveCorrection();
        /*0x7d3ae54*/ int SetArraySizes(TMPro.TMP_Text.TextProcessingElement[] textProcessingArray);
        /*0x7d3d388*/ void ComputeMarginSize();
        /*0x7d3d478*/ void OnDidApplyAnimationProperties();
        /*0x7d3d494*/ void OnTransformParentChanged();
        /*0x7d3d4c4*/ void OnRectTransformDimensionsChange();
        /*0x7d3d618*/ void InternalUpdate();
        /*0x7d381d0*/ void OnPreRenderObject();
        /*0x7d24f54*/ void GenerateTextMesh();
        /*0x7d3d974*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x7d3da18*/ void SetMeshFilters(bool state);
        /*0x7d3dbd8*/ void SetActiveSubMeshes(bool state);
        /*0x7d3d844*/ void SetActiveSubTextObjectRenderers(bool state);
        /*0x7d3dce8*/ void DestroySubMeshObjects();
        /*0x7d374f0*/ void UpdateSubMeshSortingLayerID(int id);
        /*0x7d37744*/ void UpdateSubMeshSortingOrder(int order);
        /*0x7d3ddc4*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x7d3d6c4*/ void UpdateSDFScale(float scaleDelta);
    }

    class TextMeshProUGUI : TMPro.TMP_Text, UnityEngine.UI.ILayoutElement
    {
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_GenerateTextMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_SetArraySizesMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_ParseMarkupTextMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_CharacterLookupMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_HandleGPOSFeaturesMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_CalculateVerticesPositionMarker;
        static /*0x38*/ Unity.Profiling.ProfilerMarker k_ComputeTextMetricsMarker;
        static /*0x40*/ Unity.Profiling.ProfilerMarker k_HandleVisibleCharacterMarker;
        static /*0x48*/ Unity.Profiling.ProfilerMarker k_HandleWhiteSpacesMarker;
        static /*0x50*/ Unity.Profiling.ProfilerMarker k_HandleHorizontalLineBreakingMarker;
        static /*0x58*/ Unity.Profiling.ProfilerMarker k_HandleVerticalLineBreakingMarker;
        static /*0x60*/ Unity.Profiling.ProfilerMarker k_SaveGlyphVertexDataMarker;
        static /*0x68*/ Unity.Profiling.ProfilerMarker k_ComputeCharacterAdvanceMarker;
        static /*0x70*/ Unity.Profiling.ProfilerMarker k_HandleCarriageReturnMarker;
        static /*0x78*/ Unity.Profiling.ProfilerMarker k_HandleLineTerminationMarker;
        static /*0x80*/ Unity.Profiling.ProfilerMarker k_SavePageInfoMarker;
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveTextExtentMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0xa0*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6e0*/ bool m_isRebuildingLayout;
        /*0x6e8*/ UnityEngine.Coroutine m_DelayedGraphicRebuild;
        /*0x6f0*/ UnityEngine.Coroutine m_DelayedMaterialRebuild;
        /*0x6f8*/ bool m_ShouldUpdateCulling;
        /*0x6fc*/ UnityEngine.Rect m_ClipRect;
        /*0x70c*/ bool m_ValidRect;
        /*0x710*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x718*/ bool m_hasFontAssetChanged;
        /*0x720*/ TMPro.TMP_SubMeshUI[] m_subTextObjects;
        /*0x728*/ float m_previousLossyScaleY;
        /*0x730*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x738*/ UnityEngine.CanvasRenderer m_canvasRenderer;
        /*0x740*/ UnityEngine.Canvas m_canvas;
        /*0x748*/ float m_CanvasScaleFactor;
        /*0x74c*/ bool m_isFirstAllocation;
        /*0x750*/ int m_max_characters;
        /*0x758*/ UnityEngine.Material m_baseMaterial;
        /*0x760*/ bool m_isScrollRegionSet;
        /*0x764*/ UnityEngine.Vector4 m_maskOffset;
        /*0x774*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x7b4*/ bool m_isRegisteredForEvents;
        /*0x7b8*/ System.Collections.Generic.Dictionary<int, int> materialIndexPairs;

        static /*0x7d45f20*/ TextMeshProUGUI();
        /*0x7d45dfc*/ TextMeshProUGUI();
        /*0x7d3e5ec*/ UnityEngine.Material get_materialForRendering();
        /*0x7d3e64c*/ bool get_autoSizeTextContainer();
        /*0x7d3e654*/ void set_autoSizeTextContainer(bool value);
        /*0x7d3e6f4*/ UnityEngine.Mesh get_mesh();
        /*0x7d3e6fc*/ UnityEngine.CanvasRenderer get_canvasRenderer();
        /*0x7d3e79c*/ void CalculateLayoutInputHorizontal();
        /*0x7d3e7a0*/ void CalculateLayoutInputVertical();
        /*0x7d3e7a4*/ void SetVerticesDirty();
        /*0x7d3e888*/ void SetLayoutDirty();
        /*0x7d3e978*/ void SetMaterialDirty();
        /*0x7d3ea64*/ void SetAllDirty();
        /*0x7d3eaa8*/ System.Collections.IEnumerator DelayedGraphicRebuild();
        /*0x7d3eb1c*/ System.Collections.IEnumerator DelayedMaterialRebuild();
        /*0x7d3eb90*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x7d3eefc*/ void UpdateSubObjectPivot();
        /*0x7d3efd0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x7d3f0e0*/ void UpdateMaterial();
        /*0x7d3f1cc*/ UnityEngine.Vector4 get_maskOffset();
        /*0x7d3f1e0*/ void set_maskOffset(UnityEngine.Vector4 value);
        /*0x7d3f524*/ void RecalculateClipping();
        /*0x7d3f52c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x7d3f778*/ void UpdateCulling();
        /*0x7d3f988*/ void UpdateMeshPadding();
        /*0x7d3fa88*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x7d3fb54*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x7d3fbf0*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x7d3fca8*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x7d3fda0*/ void ClearMesh();
        /*0x7d3fe90*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d3ff44*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d3fff8*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x7d40070*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x7d40258*/ void UpdateVertexData();
        /*0x7d40470*/ void UpdateFontAsset();
        /*0x7d40480*/ void Awake();
        /*0x7d40784*/ void OnEnable();
        /*0x7d40a24*/ void OnDisable();
        /*0x7d40bc8*/ void OnDestroy();
        /*0x7d40d34*/ void LoadFontAsset();
        /*0x7d408c0*/ UnityEngine.Canvas GetCanvas();
        /*0x7d41300*/ void ValidateEnvMapProperty();
        /*0x7d4142c*/ void UpdateEnvMapMatrix();
        /*0x7d41660*/ void EnableMasking();
        /*0x7d41824*/ void DisableMasking();
        /*0x7d3f20c*/ void UpdateMask();
        /*0x7d41828*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x7d41980*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x7d41b5c*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x7d41ba0*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x7d41d50*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x7d42128*/ void SetOutlineThickness(float thickness);
        /*0x7d42308*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x7d4244c*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x7d42590*/ void SetShaderDepth();
        /*0x7d4263c*/ void SetCulling();
        /*0x7d42904*/ void SetPerspectiveCorrection();
        /*0x7d42988*/ void SetMeshArrays(int size);
        /*0x7d42a34*/ int SetArraySizes(TMPro.TMP_Text.TextProcessingElement[] textProcessingArray);
        /*0x7d45070*/ void ComputeMarginSize();
        /*0x7d45160*/ void OnDidApplyAnimationProperties();
        /*0x7d45198*/ void OnCanvasHierarchyChanged();
        /*0x7d452c8*/ void OnTransformParentChanged();
        /*0x7d45318*/ void OnRectTransformDimensionsChange();
        /*0x7d454e8*/ void InternalUpdate();
        /*0x7d3ec78*/ void OnPreRenderCanvas();
        /*0x7d2cf4c*/ void GenerateTextMesh();
        /*0x7d457a4*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x7d45848*/ void SetActiveSubMeshes(bool state);
        /*0x7d45958*/ void DestroySubMeshObjects();
        /*0x7d45a34*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x7d45c3c*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x7d45594*/ void UpdateSDFScale(float scaleDelta);

        class <DelayedGraphicRebuild>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x7d46414*/ <DelayedGraphicRebuild>d__18(int <>1__state);
            /*0x7d4643c*/ void System.IDisposable.Dispose();
            /*0x7d46440*/ bool MoveNext();
            /*0x7d46510*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d46518*/ void System.Collections.IEnumerator.Reset();
            /*0x7d46550*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DelayedMaterialRebuild>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x7d46558*/ <DelayedMaterialRebuild>d__19(int <>1__state);
            /*0x7d46580*/ void System.IDisposable.Dispose();
            /*0x7d46584*/ bool MoveNext();
            /*0x7d4665c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d46664*/ void System.Collections.IEnumerator.Reset();
            /*0x7d4669c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum Compute_DistanceTransform_EventTypes
    {
        Processing = 0,
        Completed = 1,
    }

    class TMPro_EventManager
    {
        static /*0x0*/ TMPro.FastAction<object, TMPro.Compute_DT_EventArgs> COMPUTE_DT_EVENT;
        static /*0x8*/ TMPro.FastAction<bool, UnityEngine.Material> MATERIAL_PROPERTY_EVENT;
        static /*0x10*/ TMPro.FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT;
        static /*0x18*/ TMPro.FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;
        static /*0x20*/ TMPro.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT;
        static /*0x28*/ TMPro.FastAction<UnityEngine.GameObject, UnityEngine.Material, UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT;
        static /*0x30*/ TMPro.FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;
        static /*0x38*/ TMPro.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT;
        static /*0x40*/ TMPro.FastAction TMP_SETTINGS_PROPERTY_EVENT;
        static /*0x48*/ TMPro.FastAction RESOURCE_LOAD_EVENT;
        static /*0x50*/ TMPro.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;
        static /*0x58*/ TMPro.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;

        static /*0x7d46ce4*/ TMPro_EventManager();
        static /*0x7d466a4*/ void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat);
        static /*0x7d46734*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x7d467c4*/ void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x7d46854*/ void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x7d468e4*/ void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial);
        static /*0x7d4697c*/ void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged);
        static /*0x7d469fc*/ void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj);
        static /*0x7d46a7c*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        static /*0x7d46afc*/ void ON_TMP_SETTINGS_CHANGED();
        static /*0x7d46b60*/ void ON_RESOURCES_LOADED();
        static /*0x7d46bc4*/ void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x7d46c54*/ void ON_COMPUTE_DT_EVENT(object Sender, TMPro.Compute_DT_EventArgs e);
    }

    class Compute_DT_EventArgs
    {
        /*0x10*/ TMPro.Compute_DistanceTransform_EventTypes EventType;
        /*0x14*/ float ProgressPercentage;
        /*0x18*/ UnityEngine.Color[] Colors;

        /*0x7d47028*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, float progress);
        /*0x7d47060*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors);
    }

    class TMPro_ExtensionMethods
    {
        static /*0x7d47098*/ int TagToInt(string s);
        static /*0x7d47138*/ int[] ToIntArray(string text);
        static /*0x7d471ec*/ string ArrayToString(char[] chars);
        static /*0x7d472a0*/ string IntToString(int[] unicodes);
        static /*0x7d47350*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
        static /*0x7d47428*/ string IntToString(int[] unicodes, int start, int length);
        static /*0x3910ae8*/ int FindInstanceID<T>(System.Collections.Generic.List<T> list, T target);
        static /*0x7d4752c*/ bool Compare(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x7d4753c*/ bool CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x7d4754c*/ bool Compare(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7d47574*/ bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7d47594*/ UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x7d4764c*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x7d47704*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, float tint);
        static /*0x7d477e0*/ UnityEngine.Color32 GammaToLinear(UnityEngine.Color32 c);
        static /*0x7d47840*/ byte GammaToLinear(byte value);
        static /*0x7d478f0*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
        static /*0x7d478fc*/ bool Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, int accuracy);
        static /*0x7d47990*/ bool Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, int accuracy);
    }

    class TMP_Math
    {
        static float FLOAT_MAX = 32767;
        static float FLOAT_MIN = -32767;
        static int INT_MAX = 2147483647;
        static int INT_MIN = -2147483647;
        static float FLOAT_UNSET = -32767;
        static int INT_UNSET = -32767;
        static /*0x0*/ UnityEngine.Vector2 MAX_16BIT;
        static /*0x8*/ UnityEngine.Vector2 MIN_16BIT;

        static /*0x7d47a94*/ TMP_Math();
        static /*0x7d47a50*/ bool Approximately(float a, float b);
        static /*0x7d47a80*/ int Mod(int a, int b);
    }

    enum TMP_VertexDataUpdateFlags
    {
        None = 0,
        Vertices = 1,
        Uv0 = 2,
        Uv2 = 4,
        Uv4 = 8,
        Colors32 = 16,
        All = 255,
    }

    struct VertexGradient
    {
        /*0x10*/ UnityEngine.Color topLeft;
        /*0x20*/ UnityEngine.Color topRight;
        /*0x30*/ UnityEngine.Color bottomLeft;
        /*0x40*/ UnityEngine.Color bottomRight;

        /*0x7d47b00*/ VertexGradient(UnityEngine.Color color);
        /*0x7d47b24*/ VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    struct TMP_PageInfo
    {
        /*0x10*/ int firstCharacterIndex;
        /*0x14*/ int lastCharacterIndex;
        /*0x18*/ float ascender;
        /*0x1c*/ float baseLine;
        /*0x20*/ float descender;
    }

    struct TMP_LinkInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int hashCode;
        /*0x1c*/ int linkIdFirstCharacterIndex;
        /*0x20*/ int linkIdLength;
        /*0x24*/ int linkTextfirstCharacterIndex;
        /*0x28*/ int linkTextLength;
        /*0x30*/ char[] linkID;

        /*0x7d47b40*/ void SetLinkID(char[] text, int startIndex, int length);
        /*0x7d47c2c*/ string GetLinkText();
        /*0x7d47d08*/ string GetLink();
        /*0x7d47d0c*/ string GetLinkID();
    }

    struct TMP_WordInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int firstCharacterIndex;
        /*0x1c*/ int lastCharacterIndex;
        /*0x20*/ int characterCount;

        /*0x7d47da8*/ string GetWord();
    }

    struct TMP_SpriteInfo
    {
        /*0x10*/ int spriteIndex;
        /*0x14*/ int characterIndex;
        /*0x18*/ int vertexIndex;
    }

    struct Extents
    {
        static /*0x0*/ TMPro.Extents zero;
        static /*0x10*/ TMPro.Extents uninitialized;
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        static /*0x7d480b4*/ Extents();
        /*0x7d47e80*/ Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x7d47e8c*/ string ToString();
    }

    struct Mesh_Extents
    {
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        /*0x7d48148*/ Mesh_Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x7d48154*/ string ToString();
    }

    struct WordWrapState
    {
        /*0x10*/ int previous_WordBreak;
        /*0x14*/ int total_CharacterCount;
        /*0x18*/ int visible_CharacterCount;
        /*0x1c*/ int visibleSpaceCount;
        /*0x20*/ int visible_SpriteCount;
        /*0x24*/ int visible_LinkCount;
        /*0x28*/ int firstCharacterIndex;
        /*0x2c*/ int firstVisibleCharacterIndex;
        /*0x30*/ int lastCharacterIndex;
        /*0x34*/ int lastVisibleCharIndex;
        /*0x38*/ int lineNumber;
        /*0x3c*/ float maxCapHeight;
        /*0x40*/ float maxAscender;
        /*0x44*/ float maxDescender;
        /*0x48*/ float startOfLineAscender;
        /*0x4c*/ float maxLineAscender;
        /*0x50*/ float maxLineDescender;
        /*0x54*/ float pageAscender;
        /*0x58*/ TMPro.HorizontalAlignmentOptions horizontalAlignment;
        /*0x5c*/ float marginLeft;
        /*0x60*/ float marginRight;
        /*0x64*/ float xAdvance;
        /*0x68*/ float preferredWidth;
        /*0x6c*/ float preferredHeight;
        /*0x70*/ float renderedWidth;
        /*0x74*/ float renderedHeight;
        /*0x78*/ float previousLineScale;
        /*0x7c*/ int wordCount;
        /*0x80*/ TMPro.FontStyles fontStyle;
        /*0x84*/ int italicAngle;
        /*0x88*/ float fontScaleMultiplier;
        /*0x8c*/ float currentFontSize;
        /*0x90*/ float baselineOffset;
        /*0x94*/ float lineOffset;
        /*0x98*/ bool isDrivenLineSpacing;
        /*0x9c*/ int lastBaseGlyphIndex;
        /*0xa0*/ float cSpace;
        /*0xa4*/ float mSpace;
        /*0xa8*/ TMPro.TMP_TextInfo textInfo;
        /*0xb0*/ TMPro.TMP_LineInfo lineInfo;
        /*0x110*/ UnityEngine.Color32 vertexColor;
        /*0x114*/ UnityEngine.Color32 underlineColor;
        /*0x118*/ UnityEngine.Color32 strikethroughColor;
        /*0x11c*/ TMPro.HighlightState highlightState;
        /*0x130*/ TMPro.TMP_FontStyleStack basicStyleStack;
        /*0x140*/ TMPro.TMP_TextProcessingStack<int> italicAngleStack;
        /*0x160*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> colorStack;
        /*0x180*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> underlineColorStack;
        /*0x1a0*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;
        /*0x1c0*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> highlightColorStack;
        /*0x1e0*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> highlightStateStack;
        /*0x210*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> colorGradientStack;
        /*0x238*/ TMPro.TMP_TextProcessingStack<float> sizeStack;
        /*0x258*/ TMPro.TMP_TextProcessingStack<float> indentStack;
        /*0x278*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> fontWeightStack;
        /*0x298*/ TMPro.TMP_TextProcessingStack<int> styleStack;
        /*0x2b8*/ TMPro.TMP_TextProcessingStack<float> baselineStack;
        /*0x2d8*/ TMPro.TMP_TextProcessingStack<int> actionStack;
        /*0x2f8*/ TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> materialReferenceStack;
        /*0x350*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> lineJustificationStack;
        /*0x370*/ int spriteAnimationID;
        /*0x378*/ TMPro.TMP_FontAsset currentFontAsset;
        /*0x380*/ TMPro.TMP_SpriteAsset currentSpriteAsset;
        /*0x388*/ UnityEngine.Material currentMaterial;
        /*0x390*/ int currentMaterialIndex;
        /*0x394*/ TMPro.Extents meshExtents;
        /*0x3a4*/ bool tagNoParsing;
        /*0x3a5*/ bool isNonBreakingSpace;
        /*0x3a8*/ UnityEngine.Quaternion fxRotation;
        /*0x3b8*/ UnityEngine.Vector3 fxScale;
    }

    struct TagAttribute
    {
        /*0x10*/ int startIndex;
        /*0x14*/ int length;
        /*0x18*/ int hashCode;
    }

    struct RichTextTagAttribute
    {
        /*0x10*/ int nameHashCode;
        /*0x14*/ int valueHashCode;
        /*0x18*/ TMPro.TagValueType valueType;
        /*0x1c*/ int valueStartIndex;
        /*0x20*/ int valueLength;
        /*0x24*/ TMPro.TagUnitType unitType;
    }

    class TMP_Asset : UnityEngine.ScriptableObject
    {
        /*0x18*/ string m_Version;
        /*0x20*/ int m_InstanceID;
        /*0x24*/ int m_HashCode;
        /*0x28*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0x88*/ UnityEngine.Material m_Material;
        /*0x90*/ int m_MaterialHashCode;

        /*0x7d4854c*/ TMP_Asset();
        /*0x7d4837c*/ string get_version();
        /*0x7d48384*/ void set_version(string value);
        /*0x7d4838c*/ int get_instanceID();
        /*0x7d483b4*/ int get_hashCode();
        /*0x7d48430*/ void set_hashCode(int value);
        /*0x7d48438*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x7d48448*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x7d4846c*/ UnityEngine.Material get_material();
        /*0x7d48474*/ void set_material(UnityEngine.Material value);
        /*0x7d4847c*/ int get_materialHashCode();
        /*0x7d48544*/ void set_materialHashCode(int value);
    }

    class TMP_Character : TMPro.TMP_TextElement
    {
        /*0x7d48554*/ TMP_Character();
        /*0x7d4857c*/ TMP_Character(uint unicode, UnityEngine.TextCore.Glyph glyph);
        /*0x7d485ec*/ TMP_Character(uint unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
        /*0x7d48668*/ TMP_Character(uint unicode, uint glyphIndex);
    }

    struct TMP_Vertex
    {
        static /*0x0*/ TMPro.TMP_Vertex k_Zero;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector4 uv;
        /*0x2c*/ UnityEngine.Vector2 uv2;
        /*0x34*/ UnityEngine.Color32 color;

        static /*0x7d4872c*/ TMP_Vertex();
        static /*0x7d486c4*/ TMPro.TMP_Vertex get_zero();
    }

    struct TMP_Offset
    {
        static /*0x0*/ TMPro.TMP_Offset k_ZeroOffset;
        /*0x10*/ float m_Left;
        /*0x14*/ float m_Right;
        /*0x18*/ float m_Top;
        /*0x1c*/ float m_Bottom;

        static /*0x7d48a74*/ TMP_Offset();
        static /*0x7d48790*/ TMPro.TMP_Offset get_zero();
        static /*0x7d48804*/ bool op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x7d4882c*/ bool op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x7d488dc*/ TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, float b);
        /*0x7d487ec*/ TMP_Offset(float left, float right, float top, float bottom);
        /*0x7d487f8*/ TMP_Offset(float horizontal, float vertical);
        /*0x7d48730*/ float get_left();
        /*0x7d48738*/ void set_left(float value);
        /*0x7d48740*/ float get_right();
        /*0x7d48748*/ void set_right(float value);
        /*0x7d48750*/ float get_top();
        /*0x7d48758*/ void set_top(float value);
        /*0x7d48760*/ float get_bottom();
        /*0x7d48768*/ void set_bottom(float value);
        /*0x7d48770*/ float get_horizontal();
        /*0x7d48778*/ void set_horizontal(float value);
        /*0x7d48780*/ float get_vertical();
        /*0x7d48788*/ void set_vertical(float value);
        /*0x7d488f0*/ int GetHashCode();
        /*0x7d48954*/ bool Equals(object obj);
        /*0x7d489cc*/ bool Equals(TMPro.TMP_Offset other);
    }

    struct HighlightState
    {
        /*0x10*/ UnityEngine.Color32 color;
        /*0x14*/ TMPro.TMP_Offset padding;

        static /*0x7d48acc*/ bool op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        static /*0x7d48b94*/ bool op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        /*0x7d48abc*/ HighlightState(UnityEngine.Color32 color, TMPro.TMP_Offset padding);
        /*0x7d48bdc*/ int GetHashCode();
        /*0x7d48c48*/ bool Equals(object obj);
        /*0x7d48cc8*/ bool Equals(TMPro.HighlightState other);
    }

    struct TMP_CharacterInfo
    {
        /*0x10*/ TMPro.TMP_TextElementType elementType;
        /*0x14*/ char character;
        /*0x18*/ int index;
        /*0x1c*/ int stringLength;
        /*0x20*/ TMPro.TMP_TextElement textElement;
        /*0x28*/ UnityEngine.TextCore.Glyph alternativeGlyph;
        /*0x30*/ TMPro.TMP_FontAsset fontAsset;
        /*0x38*/ UnityEngine.Material material;
        /*0x40*/ int materialReferenceIndex;
        /*0x44*/ bool isUsingAlternateTypeface;
        /*0x48*/ float pointSize;
        /*0x4c*/ int lineNumber;
        /*0x50*/ int pageNumber;
        /*0x54*/ int vertexIndex;
        /*0x58*/ TMPro.TMP_Vertex vertex_BL;
        /*0x80*/ TMPro.TMP_Vertex vertex_TL;
        /*0xa8*/ TMPro.TMP_Vertex vertex_TR;
        /*0xd0*/ TMPro.TMP_Vertex vertex_BR;
        /*0xf8*/ UnityEngine.Vector3 topLeft;
        /*0x104*/ UnityEngine.Vector3 bottomLeft;
        /*0x110*/ UnityEngine.Vector3 topRight;
        /*0x11c*/ UnityEngine.Vector3 bottomRight;
        /*0x128*/ float origin;
        /*0x12c*/ float xAdvance;
        /*0x130*/ float ascender;
        /*0x134*/ float baseLine;
        /*0x138*/ float descender;
        /*0x13c*/ float adjustedAscender;
        /*0x140*/ float adjustedDescender;
        /*0x144*/ float adjustedHorizontalAdvance;
        /*0x148*/ float aspectRatio;
        /*0x14c*/ float scale;
        /*0x150*/ UnityEngine.Color32 color;
        /*0x154*/ UnityEngine.Color32 underlineColor;
        /*0x158*/ int underlineVertexIndex;
        /*0x15c*/ UnityEngine.Color32 strikethroughColor;
        /*0x160*/ int strikethroughVertexIndex;
        /*0x164*/ UnityEngine.Color32 highlightColor;
        /*0x168*/ TMPro.HighlightState highlightState;
        /*0x17c*/ TMPro.FontStyles style;
        /*0x180*/ bool isVisible;
    }

    enum ColorMode
    {
        Single = 0,
        HorizontalGradient = 1,
        VerticalGradient = 2,
        FourCornersGradient = 3,
    }

    class TMP_ColorGradient : UnityEngine.ScriptableObject
    {
        static TMPro.ColorMode k_DefaultColorMode = 3;
        static /*0x0*/ UnityEngine.Color k_DefaultColor;
        /*0x18*/ TMPro.ColorMode colorMode;
        /*0x1c*/ UnityEngine.Color topLeft;
        /*0x2c*/ UnityEngine.Color topRight;
        /*0x3c*/ UnityEngine.Color bottomLeft;
        /*0x4c*/ UnityEngine.Color bottomRight;

        static /*0x7d48f18*/ TMP_ColorGradient();
        /*0x7d48d6c*/ TMP_ColorGradient();
        /*0x7d48e08*/ TMP_ColorGradient(UnityEngine.Color color);
        /*0x7d48e74*/ TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    class TMP_Compatibility
    {
        static /*0x7d48f64*/ TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue);

        enum AnchorPositions
        {
            TopLeft = 0,
            Top = 1,
            TopRight = 2,
            Left = 3,
            Center = 4,
            Right = 5,
            BottomLeft = 6,
            Bottom = 7,
            BottomRight = 8,
            BaseLine = 9,
            None = 10,
        }
    }

    interface ITweenValue
    {
        /*0x3816f24*/ void TweenValue(float floatPercentage);
        /*0x3813ffc*/ bool get_ignoreTimeScale();
        /*0x38151b8*/ float get_duration();
        /*0x3813ffc*/ bool ValidTarget();
    }

    struct ColorTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.ColorTween.ColorTweenCallback m_Target;
        /*0x18*/ UnityEngine.Color m_StartColor;
        /*0x28*/ UnityEngine.Color m_TargetColor;
        /*0x38*/ TMPro.ColorTween.ColorTweenMode m_TweenMode;
        /*0x3c*/ float m_Duration;
        /*0x40*/ bool m_IgnoreTimeScale;

        /*0x7d48f88*/ UnityEngine.Color get_startColor();
        /*0x7d48f94*/ void set_startColor(UnityEngine.Color value);
        /*0x7d48fa0*/ UnityEngine.Color get_targetColor();
        /*0x7d48fac*/ void set_targetColor(UnityEngine.Color value);
        /*0x7d48fb8*/ TMPro.ColorTween.ColorTweenMode get_tweenMode();
        /*0x7d48fc0*/ void set_tweenMode(TMPro.ColorTween.ColorTweenMode value);
        /*0x7d48fc8*/ float get_duration();
        /*0x7d48fd0*/ void set_duration(float value);
        /*0x7d48fd8*/ bool get_ignoreTimeScale();
        /*0x7d48fe0*/ void set_ignoreTimeScale(bool value);
        /*0x7d48fec*/ void TweenValue(float floatPercentage);
        /*0x7d490d8*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
        /*0x7d491b4*/ bool GetIgnoreTimescale();
        /*0x7d491bc*/ float GetDuration();
        /*0x7d490c8*/ bool ValidTarget();

        enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2,
        }

        class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
        {
            /*0x7d4916c*/ ColorTweenCallback();
        }
    }

    struct FloatTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.FloatTween.FloatTweenCallback m_Target;
        /*0x18*/ float m_StartValue;
        /*0x1c*/ float m_TargetValue;
        /*0x20*/ float m_Duration;
        /*0x24*/ bool m_IgnoreTimeScale;

        /*0x7d491c4*/ float get_startValue();
        /*0x7d491cc*/ void set_startValue(float value);
        /*0x7d491d4*/ float get_targetValue();
        /*0x7d491dc*/ void set_targetValue(float value);
        /*0x7d491e4*/ float get_duration();
        /*0x7d491ec*/ void set_duration(float value);
        /*0x7d491f4*/ bool get_ignoreTimeScale();
        /*0x7d491fc*/ void set_ignoreTimeScale(bool value);
        /*0x7d49208*/ void TweenValue(float floatPercentage);
        /*0x7d492a4*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
        /*0x7d49380*/ bool GetIgnoreTimescale();
        /*0x7d49388*/ float GetDuration();
        /*0x7d49294*/ bool ValidTarget();

        class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
        {
            /*0x7d49338*/ FloatTweenCallback();
        }
    }

    class TweenRunner<T>
    {
        /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
        /*0x0*/ System.Collections.IEnumerator m_Tween;

        static /*0x3910ae8*/ System.Collections.IEnumerator Start(T tweenInfo);
        /*0x38159dc*/ TweenRunner();
        /*0x3816710*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
        /*0x3910ae8*/ void StartTween(T info);
        /*0x38159dc*/ void StopTween();

        class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T tweenInfo;
            /*0x0*/ float <elapsedTime>5__2;

            /*0x3815ed0*/ <Start>d__2(int <>1__state);
            /*0x38159dc*/ void System.IDisposable.Dispose();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38148bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_DefaultControls
    {
        static float kWidth = 160;
        static float kThickHeight = 30;
        static float kThinHeight = 20;
        static /*0x0*/ UnityEngine.Vector2 s_TextElementSize;
        static /*0x8*/ UnityEngine.Vector2 s_ThickElementSize;
        static /*0x10*/ UnityEngine.Vector2 s_ThinElementSize;
        static /*0x18*/ UnityEngine.Color s_DefaultSelectableColor;
        static /*0x28*/ UnityEngine.Color s_TextColor;

        static /*0x7d4b7bc*/ TMP_DefaultControls();
        static /*0x7d49390*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size);
        static /*0x7d49438*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent);
        static /*0x7d495f8*/ void SetDefaultTextValues(TMPro.TMP_Text lbl);
        static /*0x7d49680*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
        static /*0x7d494f8*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
        static /*0x7d496e0*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
        static /*0x7d497c4*/ UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x7d49a8c*/ UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x7d49d48*/ UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x7d49de8*/ UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x7d4a448*/ UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x3910ae8*/ T AddComponent<T>(UnityEngine.GameObject go);

        struct Resources
        {
            /*0x10*/ UnityEngine.Sprite standard;
            /*0x18*/ UnityEngine.Sprite background;
            /*0x20*/ UnityEngine.Sprite inputField;
            /*0x28*/ UnityEngine.Sprite knob;
            /*0x30*/ UnityEngine.Sprite checkmark;
            /*0x38*/ UnityEngine.Sprite dropdown;
            /*0x40*/ UnityEngine.Sprite mask;
        }
    }

    class TMP_Dropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
    {
        static /*0x0*/ TMPro.TMP_Dropdown.OptionData k_NothingOption;
        static /*0x8*/ TMPro.TMP_Dropdown.OptionData k_EverythingOption;
        static /*0x10*/ TMPro.TMP_Dropdown.OptionData k_MixedOption;
        static /*0x18*/ TMPro.TMP_Dropdown.OptionData s_NoOptionData;
        /*0x100*/ UnityEngine.RectTransform m_Template;
        /*0x108*/ TMPro.TMP_Text m_CaptionText;
        /*0x110*/ UnityEngine.UI.Image m_CaptionImage;
        /*0x118*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x120*/ TMPro.TMP_Text m_ItemText;
        /*0x128*/ UnityEngine.UI.Image m_ItemImage;
        /*0x130*/ int m_Value;
        /*0x134*/ bool m_MultiSelect;
        /*0x138*/ TMPro.TMP_Dropdown.OptionDataList m_Options;
        /*0x140*/ TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;
        /*0x148*/ float m_AlphaFadeSpeed;
        /*0x150*/ UnityEngine.GameObject m_Dropdown;
        /*0x158*/ UnityEngine.GameObject m_Blocker;
        /*0x160*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> m_Items;
        /*0x168*/ TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner;
        /*0x170*/ bool validTemplate;
        /*0x178*/ UnityEngine.Coroutine m_Coroutine;

        static /*0x7d4f194*/ TMP_Dropdown();
        static /*0x3910ae8*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
        static /*0x7d4c174*/ bool IsEverythingValue(int count, int value);
        static /*0x7d4e4c4*/ int EverythingValue(int count);
        static /*0x7d4c14c*/ int FirstActiveFlagIndex(int value);
        /*0x7d4bb28*/ TMP_Dropdown();
        /*0x7d4b84c*/ UnityEngine.RectTransform get_template();
        /*0x7d4b28c*/ void set_template(UnityEngine.RectTransform value);
        /*0x7d4b854*/ TMPro.TMP_Text get_captionText();
        /*0x7d4b2ac*/ void set_captionText(TMPro.TMP_Text value);
        /*0x7d4b85c*/ UnityEngine.UI.Image get_captionImage();
        /*0x7d4b864*/ void set_captionImage(UnityEngine.UI.Image value);
        /*0x7d4b884*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x7d4b88c*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x7d4b8ac*/ TMPro.TMP_Text get_itemText();
        /*0x7d4b2cc*/ void set_itemText(TMPro.TMP_Text value);
        /*0x7d4b8b4*/ UnityEngine.UI.Image get_itemImage();
        /*0x7d4b8bc*/ void set_itemImage(UnityEngine.UI.Image value);
        /*0x7d4b2ec*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
        /*0x7d4b8dc*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        /*0x7d4b904*/ TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged();
        /*0x7d4b90c*/ void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value);
        /*0x7d4b91c*/ float get_alphaFadeSpeed();
        /*0x7d4b924*/ void set_alphaFadeSpeed(float value);
        /*0x7d4b92c*/ int get_value();
        /*0x7d4b934*/ void set_value(int value);
        /*0x7d4baac*/ void SetValueWithoutNotify(int input);
        /*0x7d4b93c*/ void SetValue(int value, bool sendCallback);
        /*0x7d4bab4*/ bool get_IsExpanded();
        /*0x7d4bb14*/ bool get_MultiSelect();
        /*0x7d4bb1c*/ void set_MultiSelect(bool value);
        /*0x7d4bd20*/ void Awake();
        /*0x7d4be44*/ void Start();
        /*0x7d4bef8*/ void OnDisable();
        /*0x7d4b318*/ void RefreshShownValue();
        /*0x7d4c294*/ void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options);
        /*0x7d4c2fc*/ void AddOptions(System.Collections.Generic.List<string> options);
        /*0x7d4c4b0*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
        /*0x7d4c664*/ void ClearOptions();
        /*0x7d4c714*/ void SetupTemplate();
        /*0x7d4cdb0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d4df34*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d4df38*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d4cdb4*/ void Show();
        /*0x7d4e538*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
        /*0x7d4ea7c*/ void DestroyBlocker(UnityEngine.GameObject blocker);
        /*0x7d4ead4*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
        /*0x7d4eb40*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
        /*0x7d4eb98*/ TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate);
        /*0x7d4ec04*/ void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item);
        /*0x7d4e078*/ TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, bool selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items);
        /*0x7d4ec08*/ void AlphaFadeList(float duration, float alpha);
        /*0x7d4e3a8*/ void AlphaFadeList(float duration, float start, float end);
        /*0x7d4ec88*/ void SetAlpha(float alpha);
        /*0x7d4df3c*/ void Hide();
        /*0x7d4ed3c*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
        /*0x7d4bf9c*/ void ImmediateDestroyDropdownList();
        /*0x7d4ede0*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

        class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ TMPro.TMP_Text m_Text;
            /*0x28*/ UnityEngine.UI.Image m_Image;
            /*0x30*/ UnityEngine.RectTransform m_RectTransform;
            /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

            /*0x7d4f498*/ DropdownItem();
            /*0x7d4f330*/ TMPro.TMP_Text get_text();
            /*0x7d4f338*/ void set_text(TMPro.TMP_Text value);
            /*0x7d4f340*/ UnityEngine.UI.Image get_image();
            /*0x7d4f348*/ void set_image(UnityEngine.UI.Image value);
            /*0x7d4f350*/ UnityEngine.RectTransform get_rectTransform();
            /*0x7d4f358*/ void set_rectTransform(UnityEngine.RectTransform value);
            /*0x7d4f360*/ UnityEngine.UI.Toggle get_toggle();
            /*0x7d4f368*/ void set_toggle(UnityEngine.UI.Toggle value);
            /*0x7d4f370*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x7d4f3ec*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class OptionData
        {
            /*0x10*/ string m_Text;
            /*0x18*/ UnityEngine.Sprite m_Image;
            /*0x20*/ UnityEngine.Color m_Color;

            /*0x7d4b308*/ OptionData();
            /*0x7d4c478*/ OptionData(string text);
            /*0x7d4c62c*/ OptionData(UnityEngine.Sprite image);
            /*0x7d4f4d8*/ OptionData(string text, UnityEngine.Sprite image, UnityEngine.Color color);
            /*0x7d4f4a0*/ string get_text();
            /*0x7d4f4a8*/ void set_text(string value);
            /*0x7d4f4b0*/ UnityEngine.Sprite get_image();
            /*0x7d4f4b8*/ void set_image(UnityEngine.Sprite value);
            /*0x7d4f4c0*/ UnityEngine.Color get_color();
            /*0x7d4f4cc*/ void set_color(UnityEngine.Color value);
        }

        class OptionDataList
        {
            /*0x10*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;

            /*0x7d4bc50*/ OptionDataList();
            /*0x7d4f558*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
            /*0x7d4f560*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        }

        class DropdownEvent : UnityEngine.Events.UnityEvent<int>
        {
            /*0x7d4bcd8*/ DropdownEvent();
        }

        class <>c__DisplayClass76_0
        {
            /*0x10*/ UnityEngine.UI.Toggle nothingToggle;
            /*0x18*/ UnityEngine.UI.Toggle everythingToggle;
            /*0x20*/ TMPro.TMP_Dropdown <>4__this;

            /*0x7d4e070*/ <>c__DisplayClass76_0();
            /*0x7d4f568*/ void <Show>b__0(bool x);
            /*0x7d4f588*/ void <Show>b__1(bool x);
        }

        class <>c__DisplayClass76_1
        {
            /*0x10*/ TMPro.TMP_Dropdown.DropdownItem item;
            /*0x18*/ TMPro.TMP_Dropdown <>4__this;

            /*0x7d4e3a0*/ <>c__DisplayClass76_1();
            /*0x7d4f5a8*/ void <Show>b__2(bool x);
        }

        class <DelayedDestroyDropdownList>d__90 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delay;
            /*0x28*/ TMPro.TMP_Dropdown <>4__this;

            /*0x7d4edb8*/ <DelayedDestroyDropdownList>d__90(int <>1__state);
            /*0x7d4f5cc*/ void System.IDisposable.Dispose();
            /*0x7d4f5d0*/ bool MoveNext();
            /*0x7d4f684*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d4f68c*/ void System.Collections.IEnumerator.Reset();
            /*0x7d4f6c4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_DynamicFontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_DynamicFontAssetUtilities s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<ulong, TMPro.TMP_DynamicFontAssetUtilities.FontReference> s_SystemFontLookup;
        /*0x18*/ string[] s_SystemFontPaths;
        /*0x20*/ uint s_RegularStyleNameHashCode;

        static /*0x7d50450*/ TMP_DynamicFontAssetUtilities();
        static /*0x7d50030*/ bool TryGetSystemFontReference(string familyName, ref TMPro.TMP_DynamicFontAssetUtilities.FontReference fontRef);
        static /*0x7d503bc*/ bool TryGetSystemFontReference(string familyName, string styleName, ref TMPro.TMP_DynamicFontAssetUtilities.FontReference fontRef);
        /*0x7d5043c*/ TMP_DynamicFontAssetUtilities();
        /*0x7d4f6cc*/ void InitializeSystemFontReferenceCache();
        /*0x7d500ac*/ bool TryGetSystemFontReferenceInternal(string familyName, string styleName, ref TMPro.TMP_DynamicFontAssetUtilities.FontReference fontRef);

        struct FontReference
        {
            /*0x10*/ string familyName;
            /*0x18*/ string styleName;
            /*0x20*/ int faceIndex;
            /*0x28*/ string filePath;
            /*0x30*/ ulong hashCode;

            /*0x7d4fd80*/ FontReference(string fontFilePath, string faceNameAndStyle, int index);
        }
    }

    enum AtlasPopulationMode
    {
        Static = 0,
        Dynamic = 1,
        DynamicOS = 2,
    }

    class TMP_FontAsset : TMPro.TMP_Asset
    {
        static /*0x0*/ System.Collections.Generic.List<System.WeakReference<TMPro.TMP_FontAsset>> s_CallbackInstances;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker;
        static /*0x38*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
        static /*0x40*/ Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;
        static /*0x48*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
        static /*0x50*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
        static /*0x58*/ string s_DefaultMaterialSuffix;
        static /*0x60*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
        static /*0x68*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
        static /*0x70*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
        static /*0x78*/ System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;
        static /*0x80*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
        static /*0x88*/ uint[] k_GlyphIndexArray;
        /*0x98*/ string m_SourceFontFileGUID;
        /*0xa0*/ TMPro.FontAssetCreationSettings m_CreationSettings;
        /*0x100*/ UnityEngine.Font m_SourceFontFile;
        /*0x108*/ string m_SourceFontFilePath;
        /*0x110*/ TMPro.AtlasPopulationMode m_AtlasPopulationMode;
        /*0x114*/ bool InternalDynamicOS;
        /*0x118*/ int m_FamilyNameHashCode;
        /*0x11c*/ int m_StyleNameHashCode;
        /*0x120*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
        /*0x128*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
        /*0x130*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharacterTable;
        /*0x138*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> m_CharacterLookupDictionary;
        /*0x140*/ UnityEngine.Texture2D m_AtlasTexture;
        /*0x148*/ UnityEngine.Texture2D[] m_AtlasTextures;
        /*0x150*/ int m_AtlasTextureIndex;
        /*0x154*/ bool m_IsMultiAtlasTexturesEnabled;
        /*0x155*/ bool m_GetFontFeatures;
        /*0x156*/ bool m_ClearDynamicDataOnBuild;
        /*0x158*/ int m_AtlasWidth;
        /*0x15c*/ int m_AtlasHeight;
        /*0x160*/ int m_AtlasPadding;
        /*0x164*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
        /*0x168*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
        /*0x170*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
        /*0x178*/ TMPro.TMP_FontFeatureTable m_FontFeatureTable;
        /*0x180*/ bool m_ShouldReimportFontFeatures;
        /*0x188*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_FallbackFontAssetTable;
        /*0x190*/ TMPro.TMP_FontWeightPair[] m_FontWeightTable;
        /*0x198*/ TMPro.TMP_FontWeightPair[] fontWeights;
        /*0x1a0*/ float normalStyle;
        /*0x1a4*/ float normalSpacingOffset;
        /*0x1a8*/ float boldStyle;
        /*0x1ac*/ float boldSpacing;
        /*0x1b0*/ byte italicStyle;
        /*0x1b1*/ byte tabSize;
        /*0x1b2*/ bool IsFontAssetLookupTablesDirty;
        /*0x1b8*/ TMPro.FaceInfo_Legacy m_fontInfo;
        /*0x1c0*/ System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList;
        /*0x1c8*/ TMPro.KerningTable m_KerningTable;
        /*0x1d0*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets;
        /*0x1d8*/ UnityEngine.Texture2D atlas;
        /*0x1e0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
        /*0x1e8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
        /*0x1f0*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
        /*0x1f8*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
        /*0x200*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
        /*0x208*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
        /*0x210*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharactersToAdd;
        /*0x218*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
        /*0x220*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
        /*0x228*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

        static /*0x7d5ad8c*/ TMP_FontAsset();
        static /*0x7d50cb8*/ TMPro.TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize);
        static /*0x7d51070*/ TMPro.TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight);
        static /*0x7d50ee8*/ TMPro.TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x7d51698*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font);
        static /*0x7d51714*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x7d517d4*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x7d51124*/ TMPro.TMP_FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x7d557d8*/ string GetCharacters(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d558c4*/ int[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d55b10*/ void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d55c54*/ void UpdateFontFeaturesForFontAssetsInQueue();
        static /*0x7d55e20*/ void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture);
        static /*0x7d55f5c*/ void UpdateAtlasTexturesInQueue();
        static /*0x7d560d4*/ void UpdateFontAssetsInUpdateQueue();
        /*0x7d5aa2c*/ TMP_FontAsset();
        /*0x7d504c4*/ TMPro.FontAssetCreationSettings get_creationSettings();
        /*0x7d504d4*/ void set_creationSettings(TMPro.FontAssetCreationSettings value);
        /*0x7d504f8*/ UnityEngine.Font get_sourceFontFile();
        /*0x7d50500*/ void set_sourceFontFile(UnityEngine.Font value);
        /*0x7d50510*/ TMPro.AtlasPopulationMode get_atlasPopulationMode();
        /*0x7d50518*/ void set_atlasPopulationMode(TMPro.AtlasPopulationMode value);
        /*0x7d50520*/ int get_familyNameHashCode();
        /*0x7d5059c*/ void set_familyNameHashCode(int value);
        /*0x7d505a4*/ int get_styleNameHashCode();
        /*0x7d50620*/ void set_styleNameHashCode(int value);
        /*0x7d50628*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
        /*0x7d50630*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
        /*0x7d50640*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
        /*0x7d50ac4*/ System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable();
        /*0x7d50acc*/ void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value);
        /*0x7d50adc*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> get_characterLookupTable();
        /*0x7d50b00*/ UnityEngine.Texture2D get_atlasTexture();
        /*0x7d50b98*/ UnityEngine.Texture2D[] get_atlasTextures();
        /*0x7d50ba0*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
        /*0x7d50bb0*/ int get_atlasTextureCount();
        /*0x7d50bbc*/ bool get_isMultiAtlasTexturesEnabled();
        /*0x7d50bc4*/ void set_isMultiAtlasTexturesEnabled(bool value);
        /*0x7d50bd0*/ bool get_getFontFeatures();
        /*0x7d50bd8*/ void set_getFontFeatures(bool value);
        /*0x7d50be4*/ bool get_clearDynamicDataOnBuild();
        /*0x7d50bec*/ void set_clearDynamicDataOnBuild(bool value);
        /*0x7d50bf8*/ int get_atlasWidth();
        /*0x7d50c00*/ void set_atlasWidth(int value);
        /*0x7d50c08*/ int get_atlasHeight();
        /*0x7d50c10*/ void set_atlasHeight(int value);
        /*0x7d50c18*/ int get_atlasPadding();
        /*0x7d50c20*/ void set_atlasPadding(int value);
        /*0x7d50c28*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
        /*0x7d50c30*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
        /*0x7d50c38*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
        /*0x7d50c40*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x7d50c50*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
        /*0x7d50c58*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x7d50c68*/ TMPro.TMP_FontFeatureTable get_fontFeatureTable();
        /*0x7d50c70*/ void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value);
        /*0x7d50c80*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable();
        /*0x7d50c88*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        /*0x7d50c98*/ TMPro.TMP_FontWeightPair[] get_fontWeightTable();
        /*0x7d50ca0*/ void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value);
        /*0x7d50cb0*/ TMPro.FaceInfo_Legacy get_fontInfo();
        /*0x7d5196c*/ void RegisterCallbackInstance(TMPro.TMP_FontAsset instance);
        /*0x7d51c64*/ void OnDestroy();
        /*0x7d50664*/ void ReadFontAssetDefinition();
        /*0x7d51d8c*/ void InitializeDictionaryLookupTables();
        /*0x7d51fe4*/ void InitializeGlyphLookupDictionary();
        /*0x7d522a4*/ void InitializeCharacterLookupDictionary();
        /*0x7d52e98*/ void ClearFallbackCharacterTable();
        /*0x7d52598*/ void InitializeLigatureSubstitutionLookupDictionary();
        /*0x7d5289c*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
        /*0x7d52b10*/ void InitializeMarkToBaseAdjustmentRecordsLookupDictionary();
        /*0x7d52cd4*/ void InitializeMarkToMarkAdjustmentRecordsLookupDictionary();
        /*0x7d51de4*/ void AddSynthesizedCharactersAndFaceMetrics();
        /*0x7d537c0*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
        /*0x7d539d8*/ void AddCharacterToLookupCache(uint unicode, TMPro.TMP_Character character, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, bool isAlternativeTypeface);
        /*0x7d53638*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace();
        /*0x7d53a88*/ void SortCharacterTable();
        /*0x7d53be0*/ void SortGlyphTable();
        /*0x7d53d38*/ void SortFontFeatureTable();
        /*0x7d53d78*/ void SortAllTables();
        /*0x7d53d98*/ bool HasCharacter(int character);
        /*0x7d53e08*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
        /*0x7d54c84*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
        /*0x7d54ea4*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
        /*0x7d5506c*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
        /*0x7d55704*/ bool HasCharacters(string text);
        /*0x7d559a8*/ uint GetGlyphIndex(uint unicode);
        /*0x7d55a84*/ uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode);
        /*0x7d56124*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
        /*0x7d56144*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
        /*0x7d572b8*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
        /*0x7d572d8*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
        /*0x7d57ef4*/ bool AddGlyphInternal(uint glyphIndex);
        /*0x7d57f10*/ bool TryAddGlyphInternal(uint glyphIndex, ref UnityEngine.TextCore.Glyph glyph);
        /*0x7d54368*/ bool TryAddCharacterInternal(uint unicode, ref TMPro.TMP_Character character);
        /*0x7d58868*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref TMPro.TMP_Character character);
        /*0x7d58e40*/ void TryAddGlyphsToAtlasTextures();
        /*0x7d56da8*/ bool TryAddGlyphsToNewAtlasTexture();
        /*0x7d58640*/ void SetupNewAtlasTexture();
        /*0x7d58e44*/ void UpdateAtlasTexture();
        /*0x7d57250*/ void UpdateFontFeaturesForNewlyAddedGlyphs();
        /*0x7d55dc0*/ void UpdateGPOSFontFeaturesForNewlyAddedGlyphs();
        /*0x7d524a8*/ void ImportFontFeatures();
        /*0x7d585bc*/ void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex);
        /*0x7d58fc4*/ void UpdateLigatureSubstitutionRecords();
        /*0x7d59a6c*/ void AddLigatureSubstitutionRecords(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] records);
        /*0x7d5903c*/ void UpdateGlyphAdjustmentRecords();
        /*0x7d5915c*/ void AddPairAdjustmentRecords(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] records);
        /*0x7d59efc*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
        /*0x7d590b4*/ void UpdateDiacriticalMarkAdjustmentRecords();
        /*0x7d59474*/ void AddMarkToBaseAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] records);
        /*0x7d59770*/ void AddMarkToMarkAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] records);
        /*0x3816810*/ void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
        /*0x7d5a230*/ void UpdateFontAssetData();
        /*0x7d5a844*/ void ClearFontAssetData(bool setAtlasSizeToZero);
        /*0x7d5a9f0*/ void ClearCharacterAndGlyphTablesInternal();
        /*0x7d5aa14*/ void ClearFontFeaturesInternal();
        /*0x7d5a398*/ void ClearCharacterAndGlyphTables();
        /*0x7d5a568*/ void ClearFontFeaturesTables();
        /*0x7d5a63c*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
        /*0x7d51cc8*/ void DestroyAtlasTextures();
        /*0x7d53244*/ void UpgradeGlyphAdjustmentTableToFontFeatureTable();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Character, uint> <>9__145_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__146_0;

            static /*0x7d5b1a8*/ <>c();
            /*0x7d5b210*/ <>c();
            /*0x7d5b218*/ uint <SortCharacterTable>b__145_0(TMPro.TMP_Character c);
            /*0x7d5b230*/ uint <SortGlyphTable>b__146_0(UnityEngine.TextCore.Glyph c);
        }
    }

    class FaceInfo_Legacy
    {
        /*0x10*/ string Name;
        /*0x18*/ float PointSize;
        /*0x1c*/ float Scale;
        /*0x20*/ int CharacterCount;
        /*0x24*/ float LineHeight;
        /*0x28*/ float Baseline;
        /*0x2c*/ float Ascender;
        /*0x30*/ float CapHeight;
        /*0x34*/ float Descender;
        /*0x38*/ float CenterLine;
        /*0x3c*/ float SuperscriptOffset;
        /*0x40*/ float SubscriptOffset;
        /*0x44*/ float SubSize;
        /*0x48*/ float Underline;
        /*0x4c*/ float UnderlineThickness;
        /*0x50*/ float strikethrough;
        /*0x54*/ float strikethroughThickness;
        /*0x58*/ float TabWidth;
        /*0x5c*/ float Padding;
        /*0x60*/ float AtlasWidth;
        /*0x64*/ float AtlasHeight;

        /*0x7d5b248*/ FaceInfo_Legacy();
    }

    class TMP_Glyph : TMPro.TMP_TextElement_Legacy
    {
        static /*0x7d5b250*/ TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source);
        /*0x7d5b2cc*/ TMP_Glyph();
    }

    struct FontAssetCreationSettings
    {
        /*0x10*/ string sourceFontFileName;
        /*0x18*/ string sourceFontFileGUID;
        /*0x20*/ int faceIndex;
        /*0x24*/ int pointSizeSamplingMode;
        /*0x28*/ int pointSize;
        /*0x2c*/ int padding;
        /*0x30*/ int paddingMode;
        /*0x34*/ int packingMode;
        /*0x38*/ int atlasWidth;
        /*0x3c*/ int atlasHeight;
        /*0x40*/ int characterSetSelectionMode;
        /*0x48*/ string characterSequence;
        /*0x50*/ string referencedFontAssetGUID;
        /*0x58*/ string referencedTextAssetGUID;
        /*0x60*/ int fontStyle;
        /*0x64*/ float fontStyleModifier;
        /*0x68*/ int renderMode;
        /*0x6c*/ bool includeFontFeatures;

        /*0x7d5b2d4*/ FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode);
    }

    struct TMP_FontWeightPair
    {
        /*0x10*/ TMPro.TMP_FontAsset regularTypeface;
        /*0x18*/ TMPro.TMP_FontAsset italicTypeface;
    }

    struct KerningPairKey
    {
        /*0x10*/ uint ascii_Left;
        /*0x14*/ uint ascii_Right;
        /*0x18*/ uint key;

        /*0x7d5b3cc*/ KerningPairKey(uint ascii_left, uint ascii_right);
    }

    struct GlyphValueRecord_Legacy
    {
        /*0x10*/ float xPlacement;
        /*0x14*/ float yPlacement;
        /*0x18*/ float xAdvance;
        /*0x1c*/ float yAdvance;

        static /*0x7d5b43c*/ TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b);
        /*0x7d5b3dc*/ GlyphValueRecord_Legacy(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
    }

    class KerningPair
    {
        static /*0x0*/ TMPro.KerningPair empty;
        /*0x10*/ uint m_FirstGlyph;
        /*0x14*/ TMPro.GlyphValueRecord_Legacy m_FirstGlyphAdjustments;
        /*0x24*/ uint m_SecondGlyph;
        /*0x28*/ TMPro.GlyphValueRecord_Legacy m_SecondGlyphAdjustments;
        /*0x38*/ float xOffset;
        /*0x3c*/ bool m_IgnoreSpacingAdjustments;

        static /*0x7d5b580*/ KerningPair();
        /*0x7d5b490*/ KerningPair();
        /*0x7d5b4b4*/ KerningPair(uint left, uint right, float offset);
        /*0x7d5b4f4*/ KerningPair(uint firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments);
        /*0x7d5b450*/ uint get_firstGlyph();
        /*0x7d5b458*/ void set_firstGlyph(uint value);
        /*0x7d5b460*/ TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments();
        /*0x7d5b46c*/ uint get_secondGlyph();
        /*0x7d5b474*/ void set_secondGlyph(uint value);
        /*0x7d5b47c*/ TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments();
        /*0x7d5b488*/ bool get_ignoreSpacingAdjustments();
        /*0x7d5b574*/ void ConvertLegacyKerningData();
    }

    class KerningTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;

        /*0x7d5b5fc*/ KerningTable();
        /*0x7d5b684*/ void AddKerningPair();
        /*0x7d5b860*/ int AddKerningPair(uint first, uint second, float offset);
        /*0x7d5ba18*/ int AddGlyphPairAdjustmentRecord(uint first, TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, TMPro.GlyphValueRecord_Legacy secondAdjustments);
        /*0x7d5bc10*/ void RemoveKerningPair(int left, int right);
        /*0x7d5bd34*/ void RemoveKerningPair(int index);
        /*0x7d5bd8c*/ void SortKerningPairs();

        class <>c
        {
            static /*0x0*/ TMPro.KerningTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.KerningPair, uint> <>9__7_0;
            static /*0x10*/ System.Func<TMPro.KerningPair, uint> <>9__7_1;

            static /*0x7d5bfa4*/ <>c();
            /*0x7d5c00c*/ <>c();
            /*0x7d5c014*/ uint <SortKerningPairs>b__7_0(TMPro.KerningPair s);
            /*0x7d5c02c*/ uint <SortKerningPairs>b__7_1(TMPro.KerningPair s);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x7d5ba10*/ <>c__DisplayClass3_0();
            /*0x7d5c044*/ bool <AddKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x7d5bc08*/ <>c__DisplayClass4_0();
            /*0x7d5c080*/ bool <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ int left;
            /*0x14*/ int right;

            /*0x7d5bd2c*/ <>c__DisplayClass5_0();
            /*0x7d5c0bc*/ bool <RemoveKerningPair>b__0(TMPro.KerningPair item);
        }
    }

    class TMP_FontUtilities
    {
        static /*0x0*/ System.Collections.Generic.List<int> k_searchedFontAssets;

        static /*0x7d5c0f8*/ TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x7d5c4d8*/ TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
        static /*0x7d5c1e8*/ TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x7d5c4dc*/ TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
    }

    class TMP_FontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_FontAssetUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;

        static /*0x7d5c5d8*/ TMP_FontAssetUtilities();
        static /*0x7d5c648*/ TMPro.TMP_FontAssetUtilities get_instance();
        static /*0x7d5c6a0*/ TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x7d5c7fc*/ TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x7d5cbe8*/ TMPro.TMP_Character SearchFallbacksForCharacter(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x7d5cd88*/ TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x7d5cfa4*/ TMPro.TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_Asset> textAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x7d5d4b4*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x7d5d2e0*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        /*0x7d5c640*/ TMP_FontAssetUtilities();
    }

    enum FontFeatureLookupFlags
    {
        None = 0,
        IgnoreLigatures = 4,
        IgnoreSpacingAdjustments = 256,
    }

    struct TMP_GlyphValueRecord
    {
        /*0x10*/ float m_XPlacement;
        /*0x14*/ float m_YPlacement;
        /*0x18*/ float m_XAdvance;
        /*0x1c*/ float m_YAdvance;

        static /*0x7d5d868*/ TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b);
        /*0x7d5d7f0*/ TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
        /*0x7d5d7fc*/ TMP_GlyphValueRecord(TMPro.GlyphValueRecord_Legacy valueRecord);
        /*0x7d5d808*/ TMP_GlyphValueRecord(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
        /*0x7d5d7b0*/ float get_xPlacement();
        /*0x7d5d7b8*/ void set_xPlacement(float value);
        /*0x7d5d7c0*/ float get_yPlacement();
        /*0x7d5d7c8*/ void set_yPlacement(float value);
        /*0x7d5d7d0*/ float get_xAdvance();
        /*0x7d5d7d8*/ void set_xAdvance(float value);
        /*0x7d5d7e0*/ float get_yAdvance();
        /*0x7d5d7e8*/ void set_yAdvance(float value);
    }

    struct TMP_GlyphAdjustmentRecord
    {
        /*0x10*/ uint m_GlyphIndex;
        /*0x14*/ TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

        /*0x7d5d8a4*/ TMP_GlyphAdjustmentRecord(uint glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord);
        /*0x7d5d8b4*/ TMP_GlyphAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord);
        /*0x7d5d87c*/ uint get_glyphIndex();
        /*0x7d5d884*/ void set_glyphIndex(uint value);
        /*0x7d5d88c*/ TMPro.TMP_GlyphValueRecord get_glyphValueRecord();
        /*0x7d5d898*/ void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value);
    }

    class TMP_GlyphPairAdjustmentRecord
    {
        /*0x10*/ TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;
        /*0x24*/ TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;
        /*0x38*/ TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

        /*0x7d5d968*/ TMP_GlyphPairAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord);
        /*0x7d5d9b0*/ TMP_GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord);
        /*0x7d5d908*/ TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord();
        /*0x7d5d91c*/ void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x7d5d930*/ TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord();
        /*0x7d5d944*/ void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x7d5d958*/ TMPro.FontFeatureLookupFlags get_featureLookupFlags();
        /*0x7d5d960*/ void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value);
    }

    struct GlyphPairKey
    {
        /*0x10*/ uint firstGlyphIndex;
        /*0x14*/ uint secondGlyphIndex;
        /*0x18*/ uint key;

        /*0x7d5da64*/ GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex);
        /*0x7d5da74*/ GlyphPairKey(TMPro.TMP_GlyphPairAdjustmentRecord record);
    }

    class TMP_FontFeatureTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords;
        /*0x18*/ System.Collections.Generic.List<TMPro.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        /*0x28*/ System.Collections.Generic.List<TMPro.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords;
        /*0x30*/ System.Collections.Generic.List<TMPro.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords;
        /*0x38*/ System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<TMPro.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup;
        /*0x40*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;
        /*0x48*/ System.Collections.Generic.Dictionary<uint, TMPro.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup;
        /*0x50*/ System.Collections.Generic.Dictionary<uint, TMPro.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup;

        /*0x7d5daec*/ TMP_FontFeatureTable();
        /*0x7d5da9c*/ System.Collections.Generic.List<TMPro.MultipleSubstitutionRecord> get_multipleSubstitutionRecords();
        /*0x7d5daa4*/ void set_multipleSubstitutionRecords(System.Collections.Generic.List<TMPro.MultipleSubstitutionRecord> value);
        /*0x7d5daac*/ System.Collections.Generic.List<TMPro.LigatureSubstitutionRecord> get_ligatureRecords();
        /*0x7d5dab4*/ void set_ligatureRecords(System.Collections.Generic.List<TMPro.LigatureSubstitutionRecord> value);
        /*0x7d5dabc*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
        /*0x7d5dac4*/ void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> value);
        /*0x7d5dacc*/ System.Collections.Generic.List<TMPro.MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords();
        /*0x7d5dad4*/ void set_MarkToBaseAdjustmentRecords(System.Collections.Generic.List<TMPro.MarkToBaseAdjustmentRecord> value);
        /*0x7d5dadc*/ System.Collections.Generic.List<TMPro.MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords();
        /*0x7d5dae4*/ void set_MarkToMarkAdjustmentRecords(System.Collections.Generic.List<TMPro.MarkToMarkAdjustmentRecord> value);
        /*0x7d5dda0*/ void SortGlyphPairAdjustmentRecords();
        /*0x7d5dfb8*/ void SortMarkToBaseAdjustmentRecords();
        /*0x7d5e1d0*/ void SortMarkToMarkAdjustmentRecords();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontFeatureTable.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_1;
            static /*0x18*/ System.Func<TMPro.MarkToBaseAdjustmentRecord, uint> <>9__26_0;
            static /*0x20*/ System.Func<TMPro.MarkToBaseAdjustmentRecord, uint> <>9__26_1;
            static /*0x28*/ System.Func<TMPro.MarkToMarkAdjustmentRecord, uint> <>9__27_0;
            static /*0x30*/ System.Func<TMPro.MarkToMarkAdjustmentRecord, uint> <>9__27_1;

            static /*0x7d5e3e8*/ <>c();
            /*0x7d5e450*/ <>c();
            /*0x7d5e458*/ uint <SortGlyphPairAdjustmentRecords>b__25_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
            /*0x7d5e4a0*/ uint <SortGlyphPairAdjustmentRecords>b__25_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
            /*0x7d5e4e8*/ uint <SortMarkToBaseAdjustmentRecords>b__26_0(TMPro.MarkToBaseAdjustmentRecord s);
            /*0x7d5e4f0*/ uint <SortMarkToBaseAdjustmentRecords>b__26_1(TMPro.MarkToBaseAdjustmentRecord s);
            /*0x7d5e4f8*/ uint <SortMarkToMarkAdjustmentRecords>b__27_0(TMPro.MarkToMarkAdjustmentRecord s);
            /*0x7d5e500*/ uint <SortMarkToMarkAdjustmentRecords>b__27_1(TMPro.MarkToMarkAdjustmentRecord s);
        }
    }

    class TMP_InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.EventSystems.IScrollHandler
    {
        static float kHScrollSpeed = 0.05000000074505806;
        static float kVScrollSpeed = 0.10000000149011612;
        static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        static string kOculusQuestDeviceModel = "Oculus Quest";
        static /*0x0*/ char[] kSeparators;
        static /*0x8*/ bool s_IsQuestDeviceEvaluated;
        static /*0x9*/ bool s_IsQuestDevice;
        /*0x100*/ UnityEngine.TouchScreenKeyboard m_SoftKeyboard;
        /*0x108*/ UnityEngine.RectTransform m_RectTransform;
        /*0x110*/ UnityEngine.RectTransform m_TextViewport;
        /*0x118*/ UnityEngine.UI.RectMask2D m_TextComponentRectMask;
        /*0x120*/ UnityEngine.UI.RectMask2D m_TextViewportRectMask;
        /*0x128*/ TMPro.TMP_Text m_TextComponent;
        /*0x130*/ UnityEngine.RectTransform m_TextComponentRectTransform;
        /*0x138*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x140*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        /*0x148*/ TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        /*0x150*/ bool m_IsDrivenByLayoutComponents;
        /*0x158*/ UnityEngine.UI.LayoutGroup m_LayoutGroup;
        /*0x160*/ UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;
        /*0x168*/ float m_ScrollPosition;
        /*0x16c*/ float m_ScrollSensitivity;
        /*0x170*/ TMPro.TMP_InputField.ContentType m_ContentType;
        /*0x174*/ TMPro.TMP_InputField.InputType m_InputType;
        /*0x178*/ char m_AsteriskChar;
        /*0x17c*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        /*0x180*/ TMPro.TMP_InputField.LineType m_LineType;
        /*0x184*/ bool m_HideMobileInput;
        /*0x185*/ bool m_HideSoftKeyboard;
        /*0x188*/ TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;
        /*0x190*/ string m_RegexValue;
        /*0x198*/ float m_GlobalPointSize;
        /*0x19c*/ int m_CharacterLimit;
        /*0x1a0*/ TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;
        /*0x1a8*/ TMPro.TMP_InputField.SubmitEvent m_OnSubmit;
        /*0x1b0*/ TMPro.TMP_InputField.SelectionEvent m_OnSelect;
        /*0x1b8*/ TMPro.TMP_InputField.SelectionEvent m_OnDeselect;
        /*0x1c0*/ TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;
        /*0x1c8*/ TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;
        /*0x1d0*/ TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;
        /*0x1d8*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;
        /*0x1e0*/ TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;
        /*0x1e8*/ UnityEngine.Color m_CaretColor;
        /*0x1f8*/ bool m_CustomCaretColor;
        /*0x1fc*/ UnityEngine.Color m_SelectionColor;
        /*0x210*/ string m_Text;
        /*0x218*/ float m_CaretBlinkRate;
        /*0x21c*/ int m_CaretWidth;
        /*0x220*/ bool m_ReadOnly;
        /*0x221*/ bool m_RichText;
        /*0x224*/ int m_StringPosition;
        /*0x228*/ int m_StringSelectPosition;
        /*0x22c*/ int m_CaretPosition;
        /*0x230*/ int m_CaretSelectPosition;
        /*0x238*/ UnityEngine.RectTransform caretRectTrans;
        /*0x240*/ UnityEngine.UIVertex[] m_CursorVerts;
        /*0x248*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
        /*0x250*/ UnityEngine.Vector2 m_LastPosition;
        /*0x258*/ UnityEngine.Mesh m_Mesh;
        /*0x260*/ bool m_AllowInput;
        /*0x261*/ bool m_ShouldActivateNextUpdate;
        /*0x262*/ bool m_UpdateDrag;
        /*0x263*/ bool m_DragPositionOutOfBounds;
        /*0x264*/ bool m_CaretVisible;
        /*0x268*/ UnityEngine.Coroutine m_BlinkCoroutine;
        /*0x270*/ float m_BlinkStartTime;
        /*0x278*/ UnityEngine.Coroutine m_DragCoroutine;
        /*0x280*/ string m_OriginalText;
        /*0x288*/ bool m_WasCanceled;
        /*0x289*/ bool m_HasDoneFocusTransition;
        /*0x290*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        /*0x298*/ bool m_PreventCallback;
        /*0x299*/ bool m_TouchKeyboardAllowsInPlaceEditing;
        /*0x29a*/ bool m_IsTextComponentUpdateRequired;
        /*0x29b*/ bool m_HasTextBeenRemoved;
        /*0x29c*/ float m_PointerDownClickStartTime;
        /*0x2a0*/ float m_KeyDownStartTime;
        /*0x2a4*/ float m_DoubleClickDelay;
        /*0x2a8*/ bool m_IsApplePlatform;
        /*0x2a9*/ bool m_IsCompositionActive;
        /*0x2aa*/ bool m_ShouldUpdateIMEWindowPosition;
        /*0x2ac*/ int m_PreviousIMEInsertionLine;
        /*0x2b0*/ TMPro.TMP_FontAsset m_GlobalFontAsset;
        /*0x2b8*/ bool m_OnFocusSelectAll;
        /*0x2b9*/ bool m_isSelectAll;
        /*0x2ba*/ bool m_ResetOnDeActivation;
        /*0x2bb*/ bool m_SelectionStillActive;
        /*0x2bc*/ bool m_ReleaseSelection;
        /*0x2c0*/ UnityEngine.KeyCode m_LastKeyCode;
        /*0x2c8*/ UnityEngine.GameObject m_PreviouslySelectedObject;
        /*0x2d0*/ bool m_KeepTextSelectionVisible;
        /*0x2d1*/ bool m_RestoreOriginalTextOnEscape;
        /*0x2d2*/ bool m_isRichTextEditingAllowed;
        /*0x2d4*/ int m_LineLimit;
        /*0x2d8*/ bool isAlert;
        /*0x2e0*/ TMPro.TMP_InputValidator m_InputValidator;
        /*0x2e8*/ bool m_ShouldActivateOnSelect;
        /*0x2e9*/ bool m_isSelected;
        /*0x2ea*/ bool m_IsStringPositionDirty;
        /*0x2eb*/ bool m_IsCaretPositionDirty;
        /*0x2ec*/ bool m_forceRectTransformAdjustment;
        /*0x2ed*/ bool m_IsKeyboardBeingClosedInHoloLens;
        /*0x2f0*/ UnityEngine.Event m_ProcessingEvent;

        static /*0x7d6af80*/ TMP_InputField();
        static /*0x7d62d80*/ string get_clipboard();
        static /*0x7d62dd0*/ void set_clipboard(string value);
        /*0x7d5e6d8*/ TMP_InputField();
        /*0x7d5e508*/ UnityEngine.EventSystems.BaseInput get_inputSystem();
        /*0x7d5e618*/ string get_compositionString();
        /*0x7d5e6ac*/ int get_compositionLength();
        /*0x7d5ea6c*/ UnityEngine.Mesh get_mesh();
        /*0x7d5eb14*/ void set_shouldActivateOnSelect(bool value);
        /*0x7d5eb20*/ bool get_shouldActivateOnSelect();
        /*0x7d5eb90*/ bool get_shouldHideMobileInput();
        /*0x7d5ec28*/ void set_shouldHideMobileInput(bool value);
        /*0x7d5ecf0*/ bool get_shouldHideSoftKeyboard();
        /*0x7d5edd8*/ void set_shouldHideSoftKeyboard(bool value);
        /*0x7d5ef44*/ bool isKeyboardUsingEvents();
        /*0x7d5f0d0*/ bool isUWP();
        /*0x7d5f174*/ string get_text();
        /*0x7d5f17c*/ void set_text(string value);
        /*0x7d5f2b8*/ void SetTextWithoutNotify(string input);
        /*0x7d5f184*/ void SetText(string value, bool sendCallback);
        /*0x7d5f804*/ bool get_isFocused();
        /*0x7d5f80c*/ float get_caretBlinkRate();
        /*0x7d5f814*/ void set_caretBlinkRate(float value);
        /*0x7d5f900*/ int get_caretWidth();
        /*0x7d5f908*/ void set_caretWidth(int value);
        /*0x7d5f9d4*/ UnityEngine.RectTransform get_textViewport();
        /*0x7d5f9dc*/ void set_textViewport(UnityEngine.RectTransform value);
        /*0x7d5fa34*/ TMPro.TMP_Text get_textComponent();
        /*0x7d5fa3c*/ void set_textComponent(TMPro.TMP_Text value);
        /*0x7d5fab0*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x7d5fab8*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x7d5fb10*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
        /*0x7d5fb18*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
        /*0x7d5fccc*/ float get_scrollSensitivity();
        /*0x7d5fcd4*/ void set_scrollSensitivity(float value);
        /*0x7d5fd48*/ UnityEngine.Color get_caretColor();
        /*0x7d5fd8c*/ void set_caretColor(UnityEngine.Color value);
        /*0x7d5fdb8*/ bool get_customCaretColor();
        /*0x7d5fdc0*/ void set_customCaretColor(bool value);
        /*0x7d5fddc*/ UnityEngine.Color get_selectionColor();
        /*0x7d5fdf0*/ void set_selectionColor(UnityEngine.Color value);
        /*0x7d5fe1c*/ TMPro.TMP_InputField.SubmitEvent get_onEndEdit();
        /*0x7d5fe24*/ void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x7d5fe7c*/ TMPro.TMP_InputField.SubmitEvent get_onSubmit();
        /*0x7d5fe84*/ void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x7d5fedc*/ TMPro.TMP_InputField.SelectionEvent get_onSelect();
        /*0x7d5fee4*/ void set_onSelect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x7d5ff3c*/ TMPro.TMP_InputField.SelectionEvent get_onDeselect();
        /*0x7d5ff44*/ void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x7d5ff9c*/ TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection();
        /*0x7d5ffa4*/ void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x7d5fffc*/ TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection();
        /*0x7d60004*/ void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x7d6005c*/ TMPro.TMP_InputField.OnChangeEvent get_onValueChanged();
        /*0x7d60064*/ void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value);
        /*0x7d600bc*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged();
        /*0x7d600c4*/ void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value);
        /*0x7d6011c*/ TMPro.TMP_InputField.OnValidateInput get_onValidateInput();
        /*0x7d60124*/ void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value);
        /*0x7d6017c*/ int get_characterLimit();
        /*0x7d60184*/ void set_characterLimit(int value);
        /*0x7d60244*/ float get_pointSize();
        /*0x7d6024c*/ void set_pointSize(float value);
        /*0x7d603e8*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x7d603f0*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x7d60550*/ bool get_onFocusSelectAll();
        /*0x7d60558*/ void set_onFocusSelectAll(bool value);
        /*0x7d60564*/ bool get_resetOnDeActivation();
        /*0x7d6056c*/ void set_resetOnDeActivation(bool value);
        /*0x7d60578*/ bool get_keepTextSelectionVisible();
        /*0x7d60580*/ void set_keepTextSelectionVisible(bool value);
        /*0x7d6058c*/ bool get_restoreOriginalTextOnEscape();
        /*0x7d60594*/ void set_restoreOriginalTextOnEscape(bool value);
        /*0x7d605a0*/ bool get_isRichTextEditingAllowed();
        /*0x7d605a8*/ void set_isRichTextEditingAllowed(bool value);
        /*0x7d605b4*/ TMPro.TMP_InputField.ContentType get_contentType();
        /*0x7d605bc*/ void set_contentType(TMPro.TMP_InputField.ContentType value);
        /*0x7d606ec*/ TMPro.TMP_InputField.LineType get_lineType();
        /*0x7d606f4*/ void set_lineType(TMPro.TMP_InputField.LineType value);
        /*0x7d60818*/ int get_lineLimit();
        /*0x7d60820*/ void set_lineLimit(int value);
        /*0x7d6088c*/ TMPro.TMP_InputField.InputType get_inputType();
        /*0x7d60894*/ void set_inputType(TMPro.TMP_InputField.InputType value);
        /*0x7d60930*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
        /*0x7d60938*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
        /*0x7d60940*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
        /*0x7d609c4*/ TMPro.TMP_InputField.CharacterValidation get_characterValidation();
        /*0x7d609cc*/ void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value);
        /*0x7d60a50*/ TMPro.TMP_InputValidator get_inputValidator();
        /*0x7d60a58*/ void set_inputValidator(TMPro.TMP_InputValidator value);
        /*0x7d60af4*/ bool get_readOnly();
        /*0x7d60afc*/ void set_readOnly(bool value);
        /*0x7d60b08*/ bool get_richText();
        /*0x7d60b10*/ void set_richText(bool value);
        /*0x7d60ba4*/ bool get_multiLine();
        /*0x7d60bb8*/ char get_asteriskChar();
        /*0x7d60bc0*/ void set_asteriskChar(char value);
        /*0x7d60c34*/ bool get_wasCanceled();
        /*0x7d60c3c*/ void ClampStringPos(ref int pos);
        /*0x7d60c78*/ void ClampCaretPos(ref int pos);
        /*0x7d60cf4*/ int ClampArrayIndex(int index);
        /*0x7d60cfc*/ int get_caretPositionInternal();
        /*0x7d60d14*/ void set_caretPositionInternal(int value);
        /*0x7d60d24*/ int get_stringPositionInternal();
        /*0x7d60d3c*/ void set_stringPositionInternal(int value);
        /*0x7d60d78*/ int get_caretSelectPositionInternal();
        /*0x7d60d90*/ void set_caretSelectPositionInternal(int value);
        /*0x7d60da0*/ int get_stringSelectPositionInternal();
        /*0x7d60db8*/ void set_stringSelectPositionInternal(int value);
        /*0x7d60df4*/ bool get_hasSelection();
        /*0x7d60e30*/ int get_caretPosition();
        /*0x7d60e48*/ void set_caretPosition(int value);
        /*0x7d60f74*/ int get_selectionAnchorPosition();
        /*0x7d60e78*/ void set_selectionAnchorPosition(int value);
        /*0x7d60f8c*/ int get_selectionFocusPosition();
        /*0x7d60eb4*/ void set_selectionFocusPosition(int value);
        /*0x7d60fa4*/ int get_stringPosition();
        /*0x7d60fbc*/ void set_stringPosition(int value);
        /*0x7d6110c*/ int get_selectionStringAnchorPosition();
        /*0x7d60fec*/ void set_selectionStringAnchorPosition(int value);
        /*0x7d61124*/ int get_selectionStringFocusPosition();
        /*0x7d61048*/ void set_selectionStringFocusPosition(int value);
        /*0x7d6113c*/ void Awake();
        /*0x7d611fc*/ void OnEnable();
        /*0x7d61f40*/ void OnDisable();
        /*0x7d6246c*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        /*0x7d6263c*/ System.Collections.IEnumerator CaretBlink();
        /*0x7d626b0*/ void SetCaretVisible();
        /*0x7d5f890*/ void SetCaretActive();
        /*0x7d626e8*/ void OnFocus();
        /*0x7d62720*/ void SelectAll();
        /*0x7d62750*/ void MoveTextEnd(bool shift);
        /*0x7d628fc*/ void MoveTextStart(bool shift);
        /*0x7d629e8*/ void MoveToEndOfLine(bool shift, bool ctrl);
        /*0x7d62b90*/ void MoveToStartOfLine(bool shift, bool ctrl);
        /*0x7d5f050*/ bool InPlaceEditing();
        /*0x7d62e28*/ bool InPlaceEditingChanged();
        /*0x7d62ea8*/ bool TouchScreenKeyboardShouldBeUsed();
        /*0x7d62f58*/ void UpdateKeyboardStringPosition();
        /*0x7d630d0*/ void UpdateStringPositionFromKeyboard();
        /*0x7d632c8*/ void LateUpdate();
        /*0x7d64820*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d648f8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d64918*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d64c90*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d64d20*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d64d3c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d655c8*/ TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt);
        /*0x7d66f54*/ bool IsValidChar(char c);
        /*0x7d66f90*/ void ProcessEvent(UnityEngine.Event e);
        /*0x7d66f94*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d671a4*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d67364*/ float GetScrollPositionRelativeToViewport();
        /*0x7d661c0*/ string GetSelectedString();
        /*0x7d6763c*/ int FindNextWordBegin();
        /*0x7d66a1c*/ void MoveRight(bool shift, bool ctrl);
        /*0x7d67710*/ int FindPrevWordBegin();
        /*0x7d6658c*/ void MoveLeft(bool shift, bool ctrl);
        /*0x7d677c8*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x7d679c0*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x7d67bec*/ int PageUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x7d67e90*/ int PageDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x7d66f30*/ void MoveDown(bool shift);
        /*0x7d68170*/ void MoveDown(bool shift, bool goToLastChar);
        /*0x7d66f24*/ void MoveUp(bool shift);
        /*0x7d68340*/ void MoveUp(bool shift, bool goToFirstChar);
        /*0x7d66f3c*/ void MovePageUp(bool shift);
        /*0x7d684f8*/ void MovePageUp(bool shift, bool goToFirstChar);
        /*0x7d66f48*/ void MovePageDown(bool shift);
        /*0x7d687ac*/ void MovePageDown(bool shift, bool goToLastChar);
        /*0x7d66280*/ void Delete();
        /*0x7d65e94*/ void DeleteKey();
        /*0x7d65a40*/ void Backspace();
        /*0x7d68a74*/ void Append(string input);
        /*0x7d68b24*/ void Append(char input);
        /*0x7d68e70*/ void Insert(char c);
        /*0x7d66550*/ void UpdateTouchKeyboardFromEditChanges();
        /*0x7d64808*/ void SendOnValueChangedAndUpdateLabel();
        /*0x7d5f7a8*/ void SendOnValueChanged();
        /*0x7d68f70*/ void SendOnEndEdit();
        /*0x7d67148*/ void SendOnSubmit();
        /*0x7d68fcc*/ void SendOnFocus();
        /*0x7d69028*/ void SendOnFocusLost();
        /*0x7d69084*/ void SendOnTextSelection();
        /*0x7d6912c*/ void SendOnEndTextSelection();
        /*0x7d63fa0*/ void SendTouchScreenKeyboardStatusChanged();
        /*0x7d5f2c0*/ void UpdateLabel();
        /*0x7d62564*/ void UpdateScrollbar();
        /*0x7d691c0*/ void OnScrollbarValueChange(float value);
        /*0x7d61f3c*/ void UpdateMaskRegions();
        /*0x7d67498*/ void AdjustTextPositionRelativeToViewport(float relativePosition);
        /*0x7d63224*/ int GetCaretPositionFromStringIndex(int stringIndex);
        /*0x7d691fc*/ int GetMinCaretPositionFromStringIndex(int stringIndex);
        /*0x7d692e0*/ int GetMaxCaretPositionFromStringIndex(int stringIndex);
        /*0x7d62898*/ int GetStringIndexFromCaretPosition(int caretPosition);
        /*0x7d60ef0*/ void UpdateStringIndexFromCaretPosition();
        /*0x7d610a4*/ void UpdateCaretPositionFromStringIndex();
        /*0x7d69384*/ void ForceLabelUpdate();
        /*0x7d5f97c*/ void MarkGeometryAsDirty();
        /*0x7d69388*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x7d69454*/ void LayoutComplete();
        /*0x7d69458*/ void GraphicUpdateComplete();
        /*0x7d69398*/ void UpdateGeometry();
        /*0x7d61a3c*/ void AssignPositioningIfNeeded();
        /*0x7d6945c*/ void OnFillVBO(UnityEngine.Mesh vbo);
        /*0x7d696f8*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x7d6a3d0*/ void CreateCursorVerts();
        /*0x7d69db8*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x7d6a530*/ void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, float height, bool isCharVisible);
        /*0x7d64010*/ char Validate(string text, int pos, char ch);
        /*0x7d6a9e4*/ void ActivateInputField();
        /*0x7d63b2c*/ void ActivateInputFieldInternal();
        /*0x7d6aaf8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d6ab3c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d6ab60*/ void OnControlClick();
        /*0x7d63f64*/ void ReleaseSelection();
        /*0x7d6227c*/ void DeactivateInputField(bool clearSelection);
        /*0x7d6ab64*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d6ab9c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d6ac24*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d6acb0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        /*0x7d60630*/ void EnforceContentType();
        /*0x7d5e9d4*/ void SetTextComponentWrapMode();
        /*0x7d60b1c*/ void SetTextComponentRichTextMode();
        /*0x7d607b4*/ void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes);
        /*0x7d60918*/ void SetToCustom();
        /*0x7d60adc*/ void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x7d6acc4*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
        /*0x7d6acf0*/ void CalculateLayoutInputHorizontal();
        /*0x7d6acf4*/ void CalculateLayoutInputVertical();
        /*0x7d6acf8*/ float get_minWidth();
        /*0x7d6ad00*/ float get_preferredWidth();
        /*0x7d6ae30*/ float get_flexibleWidth();
        /*0x7d6ae38*/ float get_minHeight();
        /*0x7d6ae40*/ float get_preferredHeight();
        /*0x7d6af70*/ float get_flexibleHeight();
        /*0x7d6af78*/ int get_layoutPriority();
        /*0x7d60300*/ void SetGlobalPointSize(float pointSize);
        /*0x7d60470*/ void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset);
        /*0x7d6b030*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

        enum ContentType
        {
            Standard = 0,
            Autocorrected = 1,
            IntegerNumber = 2,
            DecimalNumber = 3,
            Alphanumeric = 4,
            Name = 5,
            EmailAddress = 6,
            Password = 7,
            Pin = 8,
            Custom = 9,
        }

        enum InputType
        {
            Standard = 0,
            AutoCorrect = 1,
            Password = 2,
        }

        enum CharacterValidation
        {
            None = 0,
            Digit = 1,
            Integer = 2,
            Decimal = 3,
            Alphanumeric = 4,
            Name = 5,
            Regex = 6,
            EmailAddress = 7,
            CustomValidator = 8,
        }

        enum LineType
        {
            SingleLine = 0,
            MultiLineSubmit = 1,
            MultiLineNewline = 2,
        }

        class OnValidateInput : System.MulticastDelegate
        {
            /*0x7d8c8fc*/ OnValidateInput(object object, nint method);
            /*0x7d8c9b0*/ char Invoke(string text, int charIndex, char addedChar);
            /*0x7d8c9c4*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
            /*0x7d8ca48*/ char EndInvoke(System.IAsyncResult result);
        }

        class SubmitEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x7d8ca70*/ SubmitEvent();
        }

        class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x7d8cab8*/ OnChangeEvent();
        }

        class SelectionEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x7d8cb00*/ SelectionEvent();
        }

        class TextSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0x7d8cb48*/ TextSelectionEvent();
        }

        class TouchScreenKeyboardEvent : UnityEngine.Events.UnityEvent<UnityEngine.TouchScreenKeyboard.Status>
        {
            /*0x7d8cb90*/ TouchScreenKeyboardEvent();
        }

        enum EditState
        {
            Continue = 0,
            Finish = 1,
        }

        class <CaretBlink>d__295 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;

            /*0x7d8cbd8*/ <CaretBlink>d__295(int <>1__state);
            /*0x7d8cc00*/ void System.IDisposable.Dispose();
            /*0x7d8cc04*/ bool MoveNext();
            /*0x7d8cd28*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d8cd30*/ void System.Collections.IEnumerator.Reset();
            /*0x7d8cd68*/ object System.Collections.IEnumerator.get_Current();
        }

        class <MouseDragOutsideRect>d__316 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;
            /*0x28*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x7d8cd70*/ <MouseDragOutsideRect>d__316(int <>1__state);
            /*0x7d8cd98*/ void System.IDisposable.Dispose();
            /*0x7d8cd9c*/ bool MoveNext();
            /*0x7d8cfe4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d8cfec*/ void System.Collections.IEnumerator.Reset();
            /*0x7d8d024*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class SetPropertyUtility
    {
        static /*0x7d8d02c*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
        static /*0x3910ae8*/ bool SetEquatableStruct<T>(ref T currentValue, T newValue);
        static /*0x3910ae8*/ bool SetStruct<T>(ref T currentValue, T newValue);
        static /*0x3910ae8*/ bool SetClass<T>(ref T currentValue, T newValue);
    }

    class TMP_InputValidator : UnityEngine.ScriptableObject
    {
        /*0x7d8d074*/ TMP_InputValidator();
        char Validate(ref string text, ref int pos, char ch);
    }

    struct TMP_LineInfo
    {
        /*0x10*/ int controlCharacterCount;
        /*0x14*/ int characterCount;
        /*0x18*/ int visibleCharacterCount;
        /*0x1c*/ int spaceCount;
        /*0x20*/ int visibleSpaceCount;
        /*0x24*/ int wordCount;
        /*0x28*/ int firstCharacterIndex;
        /*0x2c*/ int firstVisibleCharacterIndex;
        /*0x30*/ int lastCharacterIndex;
        /*0x34*/ int lastVisibleCharacterIndex;
        /*0x38*/ float length;
        /*0x3c*/ float lineHeight;
        /*0x40*/ float ascender;
        /*0x44*/ float baseline;
        /*0x48*/ float descender;
        /*0x4c*/ float maxAdvance;
        /*0x50*/ float width;
        /*0x54*/ float marginLeft;
        /*0x58*/ float marginRight;
        /*0x5c*/ TMPro.HorizontalAlignmentOptions alignment;
        /*0x60*/ TMPro.Extents lineExtents;
    }

    class TMP_ListPool<T>
    {
        static /*0x0*/ TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>> s_ListPool;

        static /*0x383e7a0*/ TMP_ListPool();
        static /*0x3836db8*/ System.Collections.Generic.List<T> Get();
        static /*0x3840c74*/ void Release(System.Collections.Generic.List<T> toRelease);

        class <>c<T>
        {
            static /*0x0*/ TMPro.TMP_ListPool.<>c<T> <>9;

            static /*0x383e7a0*/ <>c();
            /*0x38159dc*/ <>c();
            /*0x3816710*/ void <.cctor>b__3_0(System.Collections.Generic.List<T> l);
        }
    }

    class TMP_MaterialManager
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        static /*0x8*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        static /*0x18*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        static /*0x20*/ bool isFallbackListDirty;

        static /*0x7d8d07c*/ TMP_MaterialManager();
        static /*0x7d8d26c*/ void OnPreRender();
        static /*0x7d8d4f8*/ UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, int stencilID);
        static /*0x7d8e4bc*/ void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x7d8e6ac*/ UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial);
        static /*0x7d8e820*/ UnityEngine.Material SetStencil(UnityEngine.Material material, int stencilID);
        static /*0x7d8e8dc*/ void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, int stencilID);
        static /*0x7d8eba8*/ void RemoveStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x7d8ed18*/ void ReleaseBaseMaterial(UnityEngine.Material baseMaterial);
        static /*0x7d8f204*/ void ClearMaterials();
        static /*0x7d8f3c0*/ int GetStencilID(UnityEngine.GameObject obj);
        static /*0x7d8f82c*/ UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial);
        static /*0x7d8f68c*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
        static /*0x7d8fa28*/ UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
        static /*0x7d8ffa8*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
        static /*0x7d90404*/ void AddFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x7d90548*/ void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x7d8d2e4*/ void CleanupFallbackMaterials();
        static /*0x7d90720*/ void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial);
        static /*0x7d8fd18*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);

        class FallbackMaterial
        {
            /*0x10*/ long fallbackID;
            /*0x18*/ UnityEngine.Material sourceMaterial;
            /*0x20*/ int sourceMaterialCRC;
            /*0x28*/ UnityEngine.Material fallbackMaterial;
            /*0x30*/ int count;

            /*0x7d8ffa0*/ FallbackMaterial();
        }

        class MaskingMaterial
        {
            /*0x10*/ UnityEngine.Material baseMaterial;
            /*0x18*/ UnityEngine.Material stencilMaterial;
            /*0x20*/ int count;
            /*0x24*/ int stencilID;

            /*0x7d8e4b4*/ MaskingMaterial();
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x7d8eba0*/ <>c__DisplayClass11_0();
            /*0x7d90918*/ bool <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x7d8ed10*/ <>c__DisplayClass12_0();
            /*0x7d90988*/ bool <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ UnityEngine.Material baseMaterial;

            /*0x7d8f1fc*/ <>c__DisplayClass13_0();
            /*0x7d909f8*/ bool <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x7d8e818*/ <>c__DisplayClass9_0();
            /*0x7d90a68*/ bool <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }
    }

    enum VertexSortingOrder
    {
        Normal = 0,
        Reverse = 1,
    }

    struct TMP_MeshInfo
    {
        static /*0x0*/ UnityEngine.Color32 s_DefaultColor;
        static /*0x4*/ UnityEngine.Vector3 s_DefaultNormal;
        static /*0x10*/ UnityEngine.Vector4 s_DefaultTangent;
        static /*0x20*/ UnityEngine.Bounds s_DefaultBounds;
        /*0x10*/ UnityEngine.Mesh mesh;
        /*0x18*/ int vertexCount;
        /*0x20*/ UnityEngine.Vector3[] vertices;
        /*0x28*/ UnityEngine.Vector3[] normals;
        /*0x30*/ UnityEngine.Vector4[] tangents;
        /*0x38*/ UnityEngine.Vector4[] uvs0;
        /*0x40*/ UnityEngine.Vector2[] uvs2;
        /*0x48*/ UnityEngine.Color32[] colors32;
        /*0x50*/ int[] triangles;
        /*0x58*/ UnityEngine.Material material;

        static /*0x7d93188*/ TMP_MeshInfo();
        /*0x7d90ad8*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size);
        /*0x7d910b8*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size, bool isVolumetric);
        /*0x7d918f0*/ void ResizeMeshInfo(int size);
        /*0x7d91d64*/ void ResizeMeshInfo(int size, bool isVolumetric);
        /*0x7d92640*/ void Clear();
        /*0x7d926e4*/ void Clear(bool uploadChanges);
        /*0x7d9281c*/ void ClearUnusedVertices();
        /*0x7d92858*/ void ClearUnusedVertices(int startIndex);
        /*0x7d9288c*/ void ClearUnusedVertices(int startIndex, bool updateMesh);
        /*0x7d92950*/ void SortGeometry(TMPro.VertexSortingOrder order);
        /*0x7d92f90*/ void SortGeometry(System.Collections.Generic.IList<int> sortingOrder);
        /*0x7d92a04*/ void SwapVertexData(int src, int dst);
    }

    class TMP_ObjectPool<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        /*0x0*/ int <countAll>k__BackingField;

        /*0x3816810*/ TMP_ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
        /*0x3814574*/ int get_countAll();
        /*0x3815ed0*/ void set_countAll(int value);
        /*0x3814574*/ int get_countActive();
        /*0x3814574*/ int get_countInactive();
        /*0x3910ae8*/ T Get();
        /*0x3910ae8*/ void Release(T element);
    }

    class TMP_ResourceManager
    {
        static /*0x0*/ TMPro.TMP_Settings s_TextSettings;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ResourceManager.FontAssetRef> s_FontAssetReferences;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> s_FontAssetNameReferenceLookup;
        static /*0x18*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;
        static /*0x20*/ System.Collections.Generic.List<int> s_FontAssetRemovalList;
        static /*0x28*/ int k_RegularStyleHashCode;

        static /*0x7d93fc0*/ TMP_ResourceManager();
        static /*0x7d93208*/ TMPro.TMP_Settings GetTextSettings();
        static /*0x7d93320*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d9387c*/ void RemoveFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x7d939d0*/ bool TryGetFontAssetByName(int nameHashcode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x7d93a70*/ bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x7d93b34*/ void ClearFontAssetGlyphCache();
        static /*0x7d93b80*/ void RebuildFontAssetCache();
        /*0x7d93fb8*/ TMP_ResourceManager();

        struct FontAssetRef
        {
            /*0x10*/ int nameHashCode;
            /*0x14*/ int familyNameHashCode;
            /*0x18*/ int styleNameHashCode;
            /*0x20*/ long familyNameAndStyleHashCode;
            /*0x28*/ TMPro.TMP_FontAsset fontAsset;

            /*0x7d93854*/ FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, TMPro.TMP_FontAsset fontAsset);
        }
    }

    enum MarkupTag
    {
        BOLD = 66,
        SLASH_BOLD = 1613,
        ITALIC = 73,
        SLASH_ITALIC = 1606,
        UNDERLINE = 85,
        SLASH_UNDERLINE = 1626,
        STRIKETHROUGH = 83,
        SLASH_STRIKETHROUGH = 1628,
        MARK = 2699125,
        SLASH_MARK = 57644506,
        SUBSCRIPT = 92132,
        SLASH_SUBSCRIPT = 1770219,
        SUPERSCRIPT = 92150,
        SLASH_SUPERSCRIPT = 1770233,
        COLOR = 81999901,
        SLASH_COLOR = 1909026194,
        ALPHA = 75165780,
        A = 65,
        SLASH_A = 1614,
        SIZE = 3061285,
        SLASH_SIZE = 58429962,
        SPRITE = -991527447,
        NO_BREAK = 2856657,
        SLASH_NO_BREAK = 57477502,
        STYLE = 100252951,
        SLASH_STYLE = 1927738392,
        FONT = 2586451,
        SLASH_FONT = 57747708,
        SLASH_MATERIAL = -1100708252,
        LINK = 2656128,
        SLASH_LINK = 57686191,
        FONT_WEIGHT = -1889896162,
        SLASH_FONT_WEIGHT = -757976431,
        NO_PARSE = -408011596,
        SLASH_NO_PARSE = -294095813,
        POSITION = 85420,
        SLASH_POSITION = 1777699,
        VERTICAL_OFFSET = 1952379995,
        SLASH_VERTICAL_OFFSET = -11107948,
        SPACE = 100083556,
        SLASH_SPACE = 1927873067,
        PAGE = 2808691,
        SLASH_PAGE = 58683868,
        ALIGN = 75138797,
        SLASH_ALIGN = 1916026786,
        WIDTH = 105793766,
        SLASH_WIDTH = 1923459625,
        GRADIENT = -1999759898,
        SLASH_GRADIENT = -1854491959,
        CHARACTER_SPACE = -1584382009,
        SLASH_CHARACTER_SPACE = -1394426712,
        MONOSPACE = -1340221943,
        SLASH_MONOSPACE = -1638865562,
        CLASS = 82115566,
        INDENT = -1514123076,
        SLASH_INDENT = -1496889389,
        LINE_INDENT = -844305121,
        SLASH_LINE_INDENT = 93886352,
        MARGIN = -1355614050,
        SLASH_MARGIN = -1649644303,
        MARGIN_LEFT = -272933656,
        MARGIN_RIGHT = -447416589,
        LINE_HEIGHT = -799081892,
        SLASH_LINE_HEIGHT = 200452819,
        ACTION = -1827519330,
        SLASH_ACTION = -1187217679,
        SCALE = 100553336,
        SLASH_SCALE = 1928413879,
        ROTATE = -1000007783,
        SLASH_ROTATE = -764695562,
        TABLE = 226476955,
        SLASH_TABLE = -979118220,
        TH = 5862489,
        SLASH_TH = 193346070,
        TR = 5862467,
        SLASH_TR = 193346060,
        TD = 5862485,
        SLASH_TD = 193346074,
        LOWERCASE = -1506899689,
        SLASH_LOWERCASE = -1451284584,
        ALLCAPS = 218273952,
        SLASH_ALLCAPS = -797437649,
        UPPERCASE = -305409418,
        SLASH_UPPERCASE = -582368199,
        SMALLCAPS = -766062114,
        SLASH_SMALLCAPS = 199921873,
        LIGA = 2655971,
        SLASH_LIGA = 57686604,
        FRAC = 2598518,
        SLASH_FRAC = 57774681,
        NAME = 2875623,
        INDEX = 84268030,
        TINT = 2960519,
        ANIM = 2283339,
        MATERIAL = 825491659,
        HREF = 2535353,
        ANGLE = 75347905,
        PADDING = -2144568463,
        FAMILYNAME = 704251153,
        STYLENAME = -1207081936,
        DUOSPACE = 582810522,
        RED = 91635,
        GREEN = 87065851,
        BLUE = 2457214,
        YELLOW = -882444668,
        ORANGE = -1108587920,
        BLACK = 81074727,
        WHITE = 105680263,
        PURPLE = -1250222130,
        GREY = 2638345,
        LIGHTBLUE = 341063360,
        BR = 2256,
        CR = 2289,
        ZWSP = 3288238,
        ZWJ = 99623,
        NBSP = 2869039,
        SHY = 92674,
        LEFT = 2660507,
        RIGHT = 99937376,
        CENTER = -1591113269,
        JUSTIFIED = 817091359,
        FLUSH = 85552164,
        NONE = 2857034,
        PLUS = 43,
        MINUS = 45,
        PX = 2568,
        PLUS_PX = 49507,
        MINUS_PX = 47461,
        EM = 2216,
        PLUS_EM = 49091,
        MINUS_EM = 46789,
        PCT = 85031,
        PLUS_PCT = 1634348,
        MINUS_PCT = 1567082,
        PERCENTAGE = 37,
        PLUS_PERCENTAGE = 1454,
        MINUS_PERCENTAGE = 1512,
        TRUE = 2932022,
        FALSE = 85422813,
        INVALID = 1585415185,
        NOTDEF = 612146780,
        NORMAL = -1183493901,
        DEFAULT = -620974005,
        REGULAR = 1291372090,
    }

    enum TagValueType
    {
        None = 0,
        NumericalValue = 1,
        StringValue = 2,
        ColorValue = 4,
    }

    enum TagUnitType
    {
        Pixels = 0,
        FontUnits = 1,
        Percentage = 2,
    }

    class CodePoint
    {
        static uint SPACE = 32;
        static uint DOUBLE_QUOTE = 34;
        static uint NUMBER_SIGN = 35;
        static uint PERCENTAGE = 37;
        static uint PLUS = 43;
        static uint MINUS = 45;
        static uint PERIOD = 46;
        static uint HYPHEN_MINUS = 45;
        static uint SOFT_HYPHEN = 173;
        static uint HYPHEN = 8208;
        static uint NON_BREAKING_HYPHEN = 8209;
        static uint ZERO_WIDTH_SPACE = 8203;
        static uint RIGHT_SINGLE_QUOTATION = 8217;
        static uint APOSTROPHE = 39;
        static uint WORD_JOINER = 8288;
        static uint HIGH_SURROGATE_START = 55296;
        static uint HIGH_SURROGATE_END = 56319;
        static uint LOW_SURROGATE_START = 56320;
        static uint LOW_SURROGATE_END = 57343;
        static uint UNICODE_PLANE01_START = 65536;
    }

    class TMP_ScrollbarEventHandler : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
    {
        /*0x20*/ bool isSelected;

        /*0x7d94304*/ TMP_ScrollbarEventHandler();
        /*0x7d941b0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7d94218*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x7d94290*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
    }

    class TMP_SelectionCaret : UnityEngine.UI.MaskableGraphic
    {
        /*0x7d943e0*/ TMP_SelectionCaret();
        /*0x7d9430c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x7d943dc*/ void UpdateGeometry();
    }

    class TMP_Settings : UnityEngine.ScriptableObject
    {
        static /*0x0*/ TMPro.TMP_Settings s_Instance;
        static /*0x8*/ string s_CurrentAssetVersion;
        /*0x18*/ string assetVersion;
        /*0x20*/ TMPro.TextWrappingModes m_TextWrappingMode;
        /*0x24*/ bool m_enableKerning;
        /*0x28*/ System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag> m_ActiveFontFeatures;
        /*0x30*/ bool m_enableExtraPadding;
        /*0x31*/ bool m_enableTintAllSprites;
        /*0x32*/ bool m_enableParseEscapeCharacters;
        /*0x33*/ bool m_EnableRaycastTarget;
        /*0x34*/ bool m_GetFontFeaturesAtRuntime;
        /*0x38*/ int m_missingGlyphCharacter;
        /*0x3c*/ bool m_ClearDynamicDataOnBuild;
        /*0x3d*/ bool m_warningsDisabled;
        /*0x40*/ TMPro.TMP_FontAsset m_defaultFontAsset;
        /*0x48*/ string m_defaultFontAssetPath;
        /*0x50*/ float m_defaultFontSize;
        /*0x54*/ float m_defaultAutoSizeMinRatio;
        /*0x58*/ float m_defaultAutoSizeMaxRatio;
        /*0x5c*/ UnityEngine.Vector2 m_defaultTextMeshProTextContainerSize;
        /*0x64*/ UnityEngine.Vector2 m_defaultTextMeshProUITextContainerSize;
        /*0x6c*/ bool m_autoSizeTextContainer;
        /*0x6d*/ bool m_IsTextObjectScaleStatic;
        /*0x70*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_fallbackFontAssets;
        /*0x78*/ bool m_matchMaterialPreset;
        /*0x79*/ bool m_HideSubTextObjects;
        /*0x80*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x88*/ string m_defaultSpriteAssetPath;
        /*0x90*/ bool m_enableEmojiSupport;
        /*0x94*/ uint m_MissingCharacterSpriteUnicode;
        /*0x98*/ System.Collections.Generic.List<TMPro.TMP_Asset> m_EmojiFallbackTextAssets;
        /*0xa0*/ string m_defaultColorGradientPresetsPath;
        /*0xa8*/ TMPro.TMP_StyleSheet m_defaultStyleSheet;
        /*0xb0*/ string m_StyleSheetsResourcePath;
        /*0xb8*/ UnityEngine.TextAsset m_leadingCharacters;
        /*0xc0*/ UnityEngine.TextAsset m_followingCharacters;
        /*0xc8*/ TMPro.TMP_Settings.LineBreakingTable m_linebreakingRules;
        /*0xd0*/ bool m_UseModernHangulLineBreakingRules;

        static /*0x7d95ff8*/ TMP_Settings();
        static /*0x7d943e8*/ string get_version();
        static /*0x7d9448c*/ TMPro.TextWrappingModes get_textWrappingMode();
        static /*0x7d94734*/ bool get_enableKerning();
        static /*0x7d947e8*/ System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag> get_fontFeatures();
        static /*0x7d94844*/ bool get_enableExtraPadding();
        static /*0x7d948a0*/ bool get_enableTintAllSprites();
        static /*0x7d948fc*/ bool get_enableParseEscapeCharacters();
        static /*0x7d94958*/ bool get_enableRaycastTarget();
        static /*0x7d949b4*/ bool get_getFontFeaturesAtRuntime();
        static /*0x7d94a10*/ int get_missingGlyphCharacter();
        static /*0x7d94a6c*/ void set_missingGlyphCharacter(int value);
        static /*0x7d94acc*/ bool get_clearDynamicDataOnBuild();
        static /*0x7d94b28*/ bool get_warningsDisabled();
        static /*0x7d94b84*/ TMPro.TMP_FontAsset get_defaultFontAsset();
        static /*0x7d94be0*/ void set_defaultFontAsset(TMPro.TMP_FontAsset value);
        static /*0x7d94c44*/ string get_defaultFontAssetPath();
        static /*0x7d94ca0*/ float get_defaultFontSize();
        static /*0x7d94cfc*/ float get_defaultTextAutoSizingMinRatio();
        static /*0x7d94d58*/ float get_defaultTextAutoSizingMaxRatio();
        static /*0x7d94db4*/ UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize();
        static /*0x7d94e10*/ UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize();
        static /*0x7d94e6c*/ bool get_autoSizeTextContainer();
        static /*0x7d94ec8*/ bool get_isTextObjectScaleStatic();
        static /*0x7d94f24*/ void set_isTextObjectScaleStatic(bool value);
        static /*0x7d94f88*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets();
        static /*0x7d94fe4*/ void set_fallbackFontAssets(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        static /*0x7d95048*/ bool get_matchMaterialPreset();
        static /*0x7d950a4*/ bool get_hideSubTextObjects();
        static /*0x7d95100*/ TMPro.TMP_SpriteAsset get_defaultSpriteAsset();
        static /*0x7d9515c*/ void set_defaultSpriteAsset(TMPro.TMP_SpriteAsset value);
        static /*0x7d951c0*/ string get_defaultSpriteAssetPath();
        static /*0x7d9521c*/ bool get_enableEmojiSupport();
        static /*0x7d95278*/ void set_enableEmojiSupport(bool value);
        static /*0x7d952dc*/ uint get_missingCharacterSpriteUnicode();
        static /*0x7d95338*/ void set_missingCharacterSpriteUnicode(uint value);
        static /*0x7d95398*/ System.Collections.Generic.List<TMPro.TMP_Asset> get_emojiFallbackTextAssets();
        static /*0x7d953f4*/ void set_emojiFallbackTextAssets(System.Collections.Generic.List<TMPro.TMP_Asset> value);
        static /*0x7d95458*/ string get_defaultColorGradientPresetsPath();
        static /*0x7d954b4*/ TMPro.TMP_StyleSheet get_defaultStyleSheet();
        static /*0x7d95510*/ void set_defaultStyleSheet(TMPro.TMP_StyleSheet value);
        static /*0x7d95574*/ string get_styleSheetsResourcePath();
        static /*0x7d955d0*/ UnityEngine.TextAsset get_leadingCharacters();
        static /*0x7d9562c*/ UnityEngine.TextAsset get_followingCharacters();
        static /*0x7d95688*/ TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules();
        static /*0x7d9589c*/ bool get_useModernHangulLineBreakingRules();
        static /*0x7d958f8*/ void set_useModernHangulLineBreakingRules(bool value);
        static /*0x7d944e8*/ TMPro.TMP_Settings get_instance();
        static /*0x7d9595c*/ bool get_isTMPSettingsNull();
        static /*0x7d959e8*/ TMPro.TMP_Settings LoadDefaultSettings();
        static /*0x7d95b24*/ TMPro.TMP_Settings GetSettings();
        static /*0x7d95bd4*/ TMPro.TMP_FontAsset GetFontAsset();
        static /*0x7d95c8c*/ TMPro.TMP_SpriteAsset GetSpriteAsset();
        static /*0x7d95d44*/ TMPro.TMP_StyleSheet GetStyleSheet();
        static /*0x7d95718*/ void LoadLinebreakingRules();
        static /*0x7d95e04*/ System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file);
        /*0x7d95eec*/ TMP_Settings();
        /*0x7d94428*/ void SetAssetVersion();

        class LineBreakingTable
        {
            /*0x10*/ System.Collections.Generic.HashSet<uint> leadingCharacters;
            /*0x18*/ System.Collections.Generic.HashSet<uint> followingCharacters;

            /*0x7d95dfc*/ LineBreakingTable();
        }
    }

    class ShaderUtilities
    {
        static /*0x0*/ int ID_MainTex;
        static /*0x4*/ int ID_FaceTex;
        static /*0x8*/ int ID_FaceColor;
        static /*0xc*/ int ID_FaceDilate;
        static /*0x10*/ int ID_Shininess;
        static /*0x14*/ int ID_OutlineOffset1;
        static /*0x18*/ int ID_OutlineOffset2;
        static /*0x1c*/ int ID_OutlineOffset3;
        static /*0x20*/ int ID_OutlineMode;
        static /*0x24*/ int ID_IsoPerimeter;
        static /*0x28*/ int ID_Softness;
        static /*0x2c*/ int ID_UnderlayColor;
        static /*0x30*/ int ID_UnderlayOffsetX;
        static /*0x34*/ int ID_UnderlayOffsetY;
        static /*0x38*/ int ID_UnderlayDilate;
        static /*0x3c*/ int ID_UnderlaySoftness;
        static /*0x40*/ int ID_UnderlayOffset;
        static /*0x44*/ int ID_UnderlayIsoPerimeter;
        static /*0x48*/ int ID_WeightNormal;
        static /*0x4c*/ int ID_WeightBold;
        static /*0x50*/ int ID_OutlineTex;
        static /*0x54*/ int ID_OutlineWidth;
        static /*0x58*/ int ID_OutlineSoftness;
        static /*0x5c*/ int ID_OutlineColor;
        static /*0x60*/ int ID_Outline2Color;
        static /*0x64*/ int ID_Outline2Width;
        static /*0x68*/ int ID_Padding;
        static /*0x6c*/ int ID_GradientScale;
        static /*0x70*/ int ID_ScaleX;
        static /*0x74*/ int ID_ScaleY;
        static /*0x78*/ int ID_PerspectiveFilter;
        static /*0x7c*/ int ID_Sharpness;
        static /*0x80*/ int ID_TextureWidth;
        static /*0x84*/ int ID_TextureHeight;
        static /*0x88*/ int ID_BevelAmount;
        static /*0x8c*/ int ID_GlowColor;
        static /*0x90*/ int ID_GlowOffset;
        static /*0x94*/ int ID_GlowPower;
        static /*0x98*/ int ID_GlowOuter;
        static /*0x9c*/ int ID_GlowInner;
        static /*0xa0*/ int ID_LightAngle;
        static /*0xa4*/ int ID_EnvMap;
        static /*0xa8*/ int ID_EnvMatrix;
        static /*0xac*/ int ID_EnvMatrixRotation;
        static /*0xb0*/ int ID_MaskCoord;
        static /*0xb4*/ int ID_ClipRect;
        static /*0xb8*/ int ID_MaskSoftnessX;
        static /*0xbc*/ int ID_MaskSoftnessY;
        static /*0xc0*/ int ID_VertexOffsetX;
        static /*0xc4*/ int ID_VertexOffsetY;
        static /*0xc8*/ int ID_UseClipRect;
        static /*0xcc*/ int ID_StencilID;
        static /*0xd0*/ int ID_StencilOp;
        static /*0xd4*/ int ID_StencilComp;
        static /*0xd8*/ int ID_StencilReadMask;
        static /*0xdc*/ int ID_StencilWriteMask;
        static /*0xe0*/ int ID_ShaderFlags;
        static /*0xe4*/ int ID_ScaleRatio_A;
        static /*0xe8*/ int ID_ScaleRatio_B;
        static /*0xec*/ int ID_ScaleRatio_C;
        static /*0xf0*/ string Keyword_Bevel;
        static /*0xf8*/ string Keyword_Glow;
        static /*0x100*/ string Keyword_Underlay;
        static /*0x108*/ string Keyword_Ratios;
        static /*0x110*/ string Keyword_MASK_SOFT;
        static /*0x118*/ string Keyword_MASK_HARD;
        static /*0x120*/ string Keyword_MASK_TEX;
        static /*0x128*/ string Keyword_Outline;
        static /*0x130*/ string ShaderTag_ZTestMode;
        static /*0x138*/ string ShaderTag_CullMode;
        static /*0x140*/ float m_clamp;
        static /*0x144*/ bool isInitialized;
        static /*0x148*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
        static /*0x150*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;

        static /*0x7d96258*/ ShaderUtilities();
        static /*0x7d96058*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
        static /*0x7d96158*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
        static /*0x7d8d8c4*/ void GetShaderPropertyIDs();
        static /*0x7d96478*/ void UpdateShaderRatios(UnityEngine.Material mat);
        static /*0x7d968d4*/ UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material);
        static /*0x7d96918*/ bool IsMaskingEnabled(UnityEngine.Material material);
        static /*0x7d96ab4*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
        static /*0x7d97278*/ float ComputePaddingForProperties(UnityEngine.Material mat);
        static /*0x7d97578*/ float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold);
    }

    class TMP_Sprite : TMPro.TMP_TextElement_Legacy
    {
        /*0x38*/ string name;
        /*0x40*/ int hashCode;
        /*0x44*/ int unicode;
        /*0x48*/ UnityEngine.Vector2 pivot;
        /*0x50*/ UnityEngine.Sprite sprite;

        /*0x7d97e6c*/ TMP_Sprite();
    }

    class TMP_SpriteAnimator : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_animations;
        /*0x28*/ TMPro.TMP_Text m_TextComponent;

        /*0x7d980fc*/ TMP_SpriteAnimator();
        /*0x7d97e7c*/ void Awake();
        /*0x7d97ed4*/ void OnEnable();
        /*0x7d97ed8*/ void OnDisable();
        /*0x7d97edc*/ void StopAllAnimations();
        /*0x7d97f38*/ void DoSpriteAnimation(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
        /*0x7d98020*/ System.Collections.IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);

        class <DoSpriteAnimationInternal>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_SpriteAnimator <>4__this;
            /*0x28*/ int start;
            /*0x2c*/ int end;
            /*0x30*/ TMPro.TMP_SpriteAsset spriteAsset;
            /*0x38*/ int currentCharacter;
            /*0x3c*/ int framerate;
            /*0x40*/ int <currentFrame>5__2;
            /*0x48*/ TMPro.TMP_CharacterInfo <charInfo>5__3;
            /*0x1c0*/ int <materialIndex>5__4;
            /*0x1c4*/ int <vertexIndex>5__5;
            /*0x1c8*/ TMPro.TMP_MeshInfo <meshInfo>5__6;
            /*0x218*/ float <baseSpriteScale>5__7;
            /*0x21c*/ float <elapsedTime>5__8;
            /*0x220*/ float <targetTime>5__9;

            /*0x7d980d4*/ <DoSpriteAnimationInternal>d__7(int <>1__state);
            /*0x7d98188*/ void System.IDisposable.Dispose();
            /*0x7d9818c*/ bool MoveNext();
            /*0x7d98b18*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7d98b20*/ void System.Collections.IEnumerator.Reset();
            /*0x7d98b58*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_SpriteAsset : TMPro.TMP_Asset
    {
        static /*0x0*/ System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
        /*0x98*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
        /*0xa0*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
        /*0xa8*/ UnityEngine.Texture spriteSheet;
        /*0xb0*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable;
        /*0xb8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup;
        /*0xc0*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> m_GlyphTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup;
        /*0xd0*/ System.Collections.Generic.List<TMPro.TMP_Sprite> spriteInfoList;
        /*0xd8*/ System.Collections.Generic.List<TMPro.TMP_SpriteAsset> fallbackSpriteAssets;
        /*0xe0*/ bool m_IsSpriteAssetLookupTablesDirty;

        static /*0x7d9993c*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x7d99b98*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x7d99d38*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x7d99de8*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex);
        static /*0x7d9a16c*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
        static /*0x7d9a30c*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
        /*0x7d9a6a0*/ TMP_SpriteAsset();
        /*0x7d98af4*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable();
        /*0x7d990f0*/ void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value);
        /*0x7d990f8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable();
        /*0x7d9911c*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> value);
        /*0x7d99124*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable();
        /*0x7d9912c*/ void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value);
        /*0x7d99134*/ void Awake();
        /*0x7d996d0*/ UnityEngine.Material GetDefaultSpriteMaterial();
        /*0x7d98b60*/ void UpdateLookupTables();
        /*0x7d997a8*/ int GetSpriteIndexFromHashcode(int hashCode);
        /*0x7d99830*/ int GetSpriteIndexFromUnicode(uint unicode);
        /*0x7d998c4*/ int GetSpriteIndexFromName(string name);
        /*0x7d9a3bc*/ void SortGlyphTable();
        /*0x7d9a50c*/ void SortCharacterTable();
        /*0x7d9a660*/ void SortGlyphAndCharacterTables();
        /*0x7d991bc*/ void UpgradeSpriteAsset();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_SpriteAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_SpriteGlyph, uint> <>9__32_0;
            static /*0x10*/ System.Func<TMPro.TMP_SpriteCharacter, uint> <>9__33_0;

            static /*0x7d9a77c*/ <>c();
            /*0x7d9a7e4*/ <>c();
            /*0x7d9a7ec*/ uint <SortGlyphTable>b__32_0(TMPro.TMP_SpriteGlyph item);
            /*0x7d9a804*/ uint <SortCharacterTable>b__33_0(TMPro.TMP_SpriteCharacter c);
        }
    }

    class TMP_SpriteCharacter : TMPro.TMP_TextElement
    {
        /*0x30*/ string m_Name;

        /*0x7d9a680*/ TMP_SpriteCharacter();
        /*0x7d9a834*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteGlyph glyph);
        /*0x7d9a898*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph);
        /*0x7d9a914*/ TMP_SpriteCharacter(uint unicode, uint glyphIndex);
        /*0x7d9a81c*/ string get_name();
        /*0x7d9a824*/ void set_name(string value);
    }

    class TMP_SpriteGlyph : UnityEngine.TextCore.Glyph
    {
        /*0x48*/ UnityEngine.Sprite sprite;

        /*0x7d9a678*/ TMP_SpriteGlyph();
        /*0x7d9a970*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
        /*0x7d9aa2c*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite);
    }

    class TMP_Style
    {
        static /*0x0*/ TMPro.TMP_Style k_NormalStyle;
        /*0x10*/ string m_Name;
        /*0x18*/ int m_HashCode;
        /*0x20*/ string m_OpeningDefinition;
        /*0x28*/ string m_ClosingDefinition;
        /*0x30*/ uint[] m_OpeningTagArray;
        /*0x38*/ uint[] m_ClosingTagArray;

        static /*0x7d9aafc*/ TMPro.TMP_Style get_NormalStyle();
        /*0x7d9abb4*/ TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
        /*0x7d9ac6c*/ string get_name();
        /*0x7d9ac74*/ void set_name(string value);
        /*0x7d9acc0*/ int get_hashCode();
        /*0x7d9acc8*/ void set_hashCode(int value);
        /*0x7d9acdc*/ string get_styleOpeningDefinition();
        /*0x7d9ace4*/ string get_styleClosingDefinition();
        /*0x7d9acec*/ uint[] get_styleOpeningTagArray();
        /*0x7d9acf4*/ uint[] get_styleClosingTagArray();
        /*0x7d9adb8*/ void RefreshStyle();
    }

    class TMP_StyleSheet : UnityEngine.ScriptableObject
    {
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_Style> m_StyleLookupDictionary;

        /*0x7d9b390*/ TMP_StyleSheet();
        /*0x7d9af24*/ System.Collections.Generic.List<TMPro.TMP_Style> get_styles();
        /*0x7d9af2c*/ void Reset();
        /*0x7d9b24c*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x7d9b2d4*/ TMPro.TMP_Style GetStyle(string name);
        /*0x7d9b38c*/ void RefreshStyles();
        /*0x7d9af30*/ void LoadStyleDictionaryInternal();
    }

    class TMP_SubMesh : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0x28*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x30*/ UnityEngine.Material m_material;
        /*0x38*/ UnityEngine.Material m_sharedMaterial;
        /*0x40*/ UnityEngine.Material m_fallbackMaterial;
        /*0x48*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x50*/ bool m_isDefaultMaterial;
        /*0x54*/ float m_padding;
        /*0x58*/ UnityEngine.Renderer m_renderer;
        /*0x60*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x68*/ UnityEngine.Mesh m_mesh;
        /*0x70*/ TMPro.TextMeshPro m_TextComponent;
        /*0x78*/ bool m_isRegisteredForEvents;

        static /*0x7d9bb90*/ TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference);
        /*0x7d9c5f8*/ TMP_SubMesh();
        /*0x7d9b41c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x7d9b424*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x7d9b42c*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x7d9b434*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x7d9b43c*/ UnityEngine.Material get_material();
        /*0x7d9b58c*/ void set_material(UnityEngine.Material value);
        /*0x7d9b6a0*/ UnityEngine.Material get_sharedMaterial();
        /*0x7d9b6a8*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x7d9b6d4*/ UnityEngine.Material get_fallbackMaterial();
        /*0x7d9b6dc*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x7d9b824*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x7d9b82c*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x7d9b834*/ bool get_isDefaultMaterial();
        /*0x7d9b83c*/ void set_isDefaultMaterial(bool value);
        /*0x7d9b848*/ float get_padding();
        /*0x7d9b850*/ void set_padding(float value);
        /*0x7d9b858*/ UnityEngine.Renderer get_renderer();
        /*0x7d9b900*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x7d9ba24*/ UnityEngine.Mesh get_mesh();
        /*0x7d9bae0*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7d9bae8*/ TMPro.TMP_Text get_textComponent();
        /*0x7d9be84*/ void OnEnable();
        /*0x7d9bfb0*/ void OnDisable();
        /*0x7d9c078*/ void OnDestroy();
        /*0x7d9c1dc*/ void DestroySelf();
        /*0x7d9b444*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x7d9c24c*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x7d9c30c*/ UnityEngine.Material GetSharedMaterial();
        /*0x7d9b6ac*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x7d9b624*/ float GetPaddingForMaterial();
        /*0x7d9c3c0*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x7d9b698*/ void SetVerticesDirty();
        /*0x7d9b69c*/ void SetMaterialDirty();
        /*0x7d9c434*/ void UpdateMaterial();
    }

    class TMP_SubMeshUI : UnityEngine.UI.MaskableGraphic
    {
        /*0xd8*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xe0*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0xe8*/ UnityEngine.Material m_material;
        /*0xf0*/ UnityEngine.Material m_sharedMaterial;
        /*0xf8*/ UnityEngine.Material m_fallbackMaterial;
        /*0x100*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x108*/ bool m_isDefaultMaterial;
        /*0x10c*/ float m_padding;
        /*0x110*/ UnityEngine.Mesh m_mesh;
        /*0x118*/ TMPro.TextMeshProUGUI m_TextComponent;
        /*0x120*/ bool m_isRegisteredForEvents;
        /*0x121*/ bool m_materialDirty;
        /*0x124*/ int m_materialReferenceIndex;
        /*0x128*/ UnityEngine.Transform m_RootCanvasTransform;

        static /*0x7d9cd24*/ TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference);
        /*0x7d9d9b8*/ TMP_SubMeshUI();
        /*0x7d9c600*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x7d9c608*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x7d9c610*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x7d9c618*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x7d9c620*/ UnityEngine.Texture get_mainTexture();
        /*0x7d9c6dc*/ UnityEngine.Material get_material();
        /*0x7d9c7f0*/ void set_material(UnityEngine.Material value);
        /*0x7d9c96c*/ UnityEngine.Material get_sharedMaterial();
        /*0x7d9c974*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x7d9c9cc*/ UnityEngine.Material get_fallbackMaterial();
        /*0x7d9c9d4*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x7d9cb1c*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x7d9cb24*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x7d9cb34*/ UnityEngine.Material get_materialForRendering();
        /*0x7d9cb90*/ bool get_isDefaultMaterial();
        /*0x7d9cb98*/ void set_isDefaultMaterial(bool value);
        /*0x7d9cba4*/ float get_padding();
        /*0x7d9cbac*/ void set_padding(float value);
        /*0x7d9cbb4*/ UnityEngine.Mesh get_mesh();
        /*0x7d9cc74*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7d9cc84*/ TMPro.TMP_Text get_textComponent();
        /*0x7d9d00c*/ void OnEnable();
        /*0x7d9d07c*/ void OnDisable();
        /*0x7d9d138*/ void OnDestroy();
        /*0x7d9d2f4*/ void OnTransformParentChanged();
        /*0x7d9d348*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x7d9c8f8*/ float GetPaddingForMaterial();
        /*0x7d9d458*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x7d9d4cc*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x7d9d540*/ void SetAllDirty();
        /*0x7d9d544*/ void SetVerticesDirty();
        /*0x7d9d548*/ void SetLayoutDirty();
        /*0x7d9d54c*/ void SetMaterialDirty();
        /*0x7d9d590*/ void SetPivotDirty();
        /*0x7d9d5f8*/ UnityEngine.Transform GetRootCanvasTransform();
        /*0x7d9d6a4*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x7d9d6a8*/ void UpdateGeometry();
        /*0x7d9d6ac*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x7d9d6e4*/ void RefreshMaterial();
        /*0x7d9d6f4*/ void UpdateMaterial();
        /*0x7d9d8c8*/ void RecalculateClipping();
        /*0x7d9d8d0*/ UnityEngine.Material GetMaterial();
        /*0x7d9c6e4*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x7d9d8d8*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x7d9d998*/ UnityEngine.Material GetSharedMaterial();
        /*0x7d9c978*/ void SetSharedMaterial(UnityEngine.Material mat);
    }

    interface ITextElement
    {
        /*0x38148bc*/ UnityEngine.Material get_sharedMaterial();
        /*0x3815ed0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x3814574*/ int GetInstanceID();
    }

    enum TextAlignmentOptions
    {
        TopLeft = 257,
        Top = 258,
        TopRight = 260,
        TopJustified = 264,
        TopFlush = 272,
        TopGeoAligned = 288,
        Left = 513,
        Center = 514,
        Right = 516,
        Justified = 520,
        Flush = 528,
        CenterGeoAligned = 544,
        BottomLeft = 1025,
        Bottom = 1026,
        BottomRight = 1028,
        BottomJustified = 1032,
        BottomFlush = 1040,
        BottomGeoAligned = 1056,
        BaselineLeft = 2049,
        Baseline = 2050,
        BaselineRight = 2052,
        BaselineJustified = 2056,
        BaselineFlush = 2064,
        BaselineGeoAligned = 2080,
        MidlineLeft = 4097,
        Midline = 4098,
        MidlineRight = 4100,
        MidlineJustified = 4104,
        MidlineFlush = 4112,
        MidlineGeoAligned = 4128,
        CaplineLeft = 8193,
        Capline = 8194,
        CaplineRight = 8196,
        CaplineJustified = 8200,
        CaplineFlush = 8208,
        CaplineGeoAligned = 8224,
        Converted = 65535,
    }

    enum HorizontalAlignmentOptions
    {
        Left = 1,
        Center = 2,
        Right = 4,
        Justified = 8,
        Flush = 16,
        Geometry = 32,
    }

    enum VerticalAlignmentOptions
    {
        Top = 256,
        Middle = 512,
        Bottom = 1024,
        Baseline = 2048,
        Geometry = 4096,
        Capline = 8192,
    }

    enum TextRenderFlags
    {
        DontRender = 0,
        Render = 255,
    }

    enum TMP_TextElementType
    {
        Character = 0,
        Sprite = 1,
    }

    enum MaskingTypes
    {
        MaskOff = 0,
        MaskHard = 1,
        MaskSoft = 2,
    }

    enum TextOverflowModes
    {
        Overflow = 0,
        Ellipsis = 1,
        Masking = 2,
        Truncate = 3,
        ScrollRect = 4,
        Page = 5,
        Linked = 6,
    }

    enum TextWrappingModes
    {
        NoWrap = 0,
        Normal = 1,
        PreserveWhitespace = 2,
        PreserveWhitespaceNoWrap = 3,
    }

    enum MaskingOffsetMode
    {
        Percentage = 0,
        Pixel = 1,
    }

    enum TextureMappingOptions
    {
        Character = 0,
        Line = 1,
        Paragraph = 2,
        MatchAspect = 3,
    }

    enum FontStyles
    {
        Normal = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4,
        LowerCase = 8,
        UpperCase = 16,
        SmallCaps = 32,
        Strikethrough = 64,
        Superscript = 128,
        Subscript = 256,
        Highlight = 512,
    }

    enum FontWeight
    {
        Thin = 100,
        ExtraLight = 200,
        Light = 300,
        Regular = 400,
        Medium = 500,
        SemiBold = 600,
        Bold = 700,
        Heavy = 800,
        Black = 900,
    }

    class TMP_Text : UnityEngine.UI.MaskableGraphic
    {
        static /*0x0*/ TMPro.MaterialReference[] m_materialReferences;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, int> m_materialReferenceIndexLookup;
        static /*0x10*/ TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> m_materialReferenceStack;
        static /*0x68*/ UnityEngine.Color32 s_colorWhite;
        static /*0x70*/ System.Func<int, string, TMPro.TMP_FontAsset> OnFontAssetRequest;
        static /*0x78*/ System.Func<int, string, TMPro.TMP_SpriteAsset> OnSpriteAssetRequest;
        static /*0x80*/ TMPro.TMP_Text.MissingCharacterEventCallback OnMissingCharacter;
        static /*0x88*/ char[] m_htmlTag;
        static /*0x90*/ TMPro.RichTextTagAttribute[] m_xmlAttribute;
        static /*0x98*/ float[] m_attributeParameterValues;
        static /*0xa0*/ TMPro.WordWrapState m_SavedWordWrapState;
        static /*0x458*/ TMPro.WordWrapState m_SavedLineState;
        static /*0x810*/ TMPro.WordWrapState m_SavedEllipsisState;
        static /*0xbc8*/ TMPro.WordWrapState m_SavedLastValidState;
        static /*0xf80*/ TMPro.WordWrapState m_SavedSoftLineBreakState;
        static /*0x1338*/ TMPro.TMP_TextProcessingStack<TMPro.WordWrapState> m_EllipsisInsertionCandidateStack;
        static /*0x1710*/ Unity.Profiling.ProfilerMarker k_ParseTextMarker;
        static /*0x1718*/ Unity.Profiling.ProfilerMarker k_InsertNewLineMarker;
        static /*0x1720*/ UnityEngine.Vector2 k_LargePositiveVector2;
        static /*0x1728*/ UnityEngine.Vector2 k_LargeNegativeVector2;
        static /*0x1730*/ float k_LargePositiveFloat;
        static /*0x1734*/ float k_LargeNegativeFloat;
        static /*0x1738*/ int k_LargePositiveInt;
        static /*0x173c*/ int k_LargeNegativeInt;
        /*0xd8*/ string m_text;
        /*0xe0*/ bool m_IsTextBackingStringDirty;
        /*0xe8*/ TMPro.ITextPreprocessor m_TextPreprocessor;
        /*0xf0*/ bool m_isRightToLeft;
        /*0xf8*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0x100*/ TMPro.TMP_FontAsset m_currentFontAsset;
        /*0x108*/ bool m_isSDFShader;
        /*0x110*/ UnityEngine.Material m_sharedMaterial;
        /*0x118*/ UnityEngine.Material m_currentMaterial;
        /*0x120*/ int m_currentMaterialIndex;
        /*0x128*/ UnityEngine.Material[] m_fontSharedMaterials;
        /*0x130*/ UnityEngine.Material m_fontMaterial;
        /*0x138*/ UnityEngine.Material[] m_fontMaterials;
        /*0x140*/ bool m_isMaterialDirty;
        /*0x144*/ UnityEngine.Color32 m_fontColor32;
        /*0x148*/ UnityEngine.Color m_fontColor;
        /*0x158*/ UnityEngine.Color32 m_underlineColor;
        /*0x15c*/ UnityEngine.Color32 m_strikethroughColor;
        /*0x160*/ TMPro.HighlightState m_HighlightState;
        /*0x174*/ bool m_ConvertToLinearSpace;
        /*0x175*/ bool m_enableVertexGradient;
        /*0x178*/ TMPro.ColorMode m_colorMode;
        /*0x17c*/ TMPro.VertexGradient m_fontColorGradient;
        /*0x1c0*/ TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        /*0x1c8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x1d0*/ bool m_tintAllSprites;
        /*0x1d1*/ bool m_tintSprite;
        /*0x1d4*/ UnityEngine.Color32 m_spriteColor;
        /*0x1d8*/ TMPro.TMP_StyleSheet m_StyleSheet;
        /*0x1e0*/ TMPro.TMP_Style m_TextStyle;
        /*0x1e8*/ int m_TextStyleHashCode;
        /*0x1ec*/ bool m_overrideHtmlColors;
        /*0x1f0*/ UnityEngine.Color32 m_faceColor;
        /*0x1f4*/ UnityEngine.Color32 m_outlineColor;
        /*0x1f8*/ float m_outlineWidth;
        /*0x1fc*/ UnityEngine.Vector3 m_currentEnvMapRotation;
        /*0x208*/ bool m_hasEnvMapProperty;
        /*0x20c*/ float m_fontSize;
        /*0x210*/ float m_currentFontSize;
        /*0x214*/ float m_fontSizeBase;
        /*0x218*/ TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        /*0x238*/ TMPro.FontWeight m_fontWeight;
        /*0x23c*/ TMPro.FontWeight m_FontWeightInternal;
        /*0x240*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;
        /*0x260*/ bool m_enableAutoSizing;
        /*0x264*/ float m_maxFontSize;
        /*0x268*/ float m_minFontSize;
        /*0x26c*/ int m_AutoSizeIterationCount;
        /*0x270*/ int m_AutoSizeMaxIterationCount;
        /*0x274*/ bool m_IsAutoSizePointSizeSet;
        /*0x278*/ float m_fontSizeMin;
        /*0x27c*/ float m_fontSizeMax;
        /*0x280*/ TMPro.FontStyles m_fontStyle;
        /*0x284*/ TMPro.FontStyles m_FontStyleInternal;
        /*0x288*/ TMPro.TMP_FontStyleStack m_fontStyleStack;
        /*0x292*/ bool m_isUsingBold;
        /*0x294*/ TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        /*0x298*/ TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        /*0x29c*/ TMPro.TextAlignmentOptions m_textAlignment;
        /*0x2a0*/ TMPro.HorizontalAlignmentOptions m_lineJustification;
        /*0x2a8*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        /*0x2c8*/ UnityEngine.Vector3[] m_textContainerLocalCorners;
        /*0x2d0*/ float m_characterSpacing;
        /*0x2d4*/ float m_cSpacing;
        /*0x2d8*/ float m_monoSpacing;
        /*0x2dc*/ bool m_duoSpace;
        /*0x2e0*/ float m_wordSpacing;
        /*0x2e4*/ float m_lineSpacing;
        /*0x2e8*/ float m_lineSpacingDelta;
        /*0x2ec*/ float m_lineHeight;
        /*0x2f0*/ bool m_IsDrivenLineSpacing;
        /*0x2f4*/ float m_lineSpacingMax;
        /*0x2f8*/ float m_paragraphSpacing;
        /*0x2fc*/ float m_charWidthMaxAdj;
        /*0x300*/ float m_charWidthAdjDelta;
        /*0x304*/ TMPro.TextWrappingModes m_TextWrappingMode;
        /*0x308*/ bool m_isCharacterWrappingEnabled;
        /*0x309*/ bool m_isNonBreakingSpace;
        /*0x30a*/ bool m_isIgnoringAlignment;
        /*0x30c*/ float m_wordWrappingRatios;
        /*0x310*/ TMPro.TextOverflowModes m_overflowMode;
        /*0x314*/ int m_firstOverflowCharacterIndex;
        /*0x318*/ TMPro.TMP_Text m_linkedTextComponent;
        /*0x320*/ TMPro.TMP_Text parentLinkedComponent;
        /*0x328*/ bool m_isTextTruncated;
        /*0x329*/ bool m_enableKerning;
        /*0x32c*/ int m_LastBaseGlyphIndex;
        /*0x330*/ System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag> m_ActiveFontFeatures;
        /*0x338*/ bool m_enableExtraPadding;
        /*0x339*/ bool checkPaddingRequired;
        /*0x33a*/ bool m_isRichText;
        /*0x33b*/ bool m_EmojiFallbackSupport;
        /*0x33c*/ bool m_parseCtrlCharacters;
        /*0x33d*/ bool m_isOverlay;
        /*0x33e*/ bool m_isOrthographic;
        /*0x33f*/ bool m_isCullingEnabled;
        /*0x340*/ bool m_isMaskingEnabled;
        /*0x341*/ bool isMaskUpdateRequired;
        /*0x342*/ bool m_ignoreCulling;
        /*0x344*/ TMPro.TextureMappingOptions m_horizontalMapping;
        /*0x348*/ TMPro.TextureMappingOptions m_verticalMapping;
        /*0x34c*/ float m_uvLineOffset;
        /*0x350*/ TMPro.TextRenderFlags m_renderMode;
        /*0x354*/ TMPro.VertexSortingOrder m_geometrySortingOrder;
        /*0x358*/ bool m_IsTextObjectScaleStatic;
        /*0x359*/ bool m_VertexBufferAutoSizeReduction;
        /*0x35c*/ int m_firstVisibleCharacter;
        /*0x360*/ int m_maxVisibleCharacters;
        /*0x364*/ int m_maxVisibleWords;
        /*0x368*/ int m_maxVisibleLines;
        /*0x36c*/ bool m_useMaxVisibleDescender;
        /*0x370*/ int m_pageToDisplay;
        /*0x374*/ bool m_isNewPage;
        /*0x378*/ UnityEngine.Vector4 m_margin;
        /*0x388*/ float m_marginLeft;
        /*0x38c*/ float m_marginRight;
        /*0x390*/ float m_marginWidth;
        /*0x394*/ float m_marginHeight;
        /*0x398*/ float m_width;
        /*0x3a0*/ TMPro.TMP_TextInfo m_textInfo;
        /*0x3a8*/ bool m_havePropertiesChanged;
        /*0x3a9*/ bool m_isUsingLegacyAnimationComponent;
        /*0x3b0*/ UnityEngine.Transform m_transform;
        /*0x3b8*/ UnityEngine.RectTransform m_rectTransform;
        /*0x3c0*/ UnityEngine.Vector2 m_PreviousRectTransformSize;
        /*0x3c8*/ UnityEngine.Vector2 m_PreviousPivotPosition;
        /*0x3d0*/ bool <autoSizeTextContainer>k__BackingField;
        /*0x3d1*/ bool m_autoSizeTextContainer;
        /*0x3d8*/ UnityEngine.Mesh m_mesh;
        /*0x3e0*/ bool m_isVolumetricText;
        /*0x3e8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x3f0*/ TMPro.TMP_SpriteAnimator m_spriteAnimator;
        /*0x3f8*/ float m_flexibleHeight;
        /*0x3fc*/ float m_flexibleWidth;
        /*0x400*/ float m_minWidth;
        /*0x404*/ float m_minHeight;
        /*0x408*/ float m_maxWidth;
        /*0x40c*/ float m_maxHeight;
        /*0x410*/ UnityEngine.UI.LayoutElement m_LayoutElement;
        /*0x418*/ float m_preferredWidth;
        /*0x41c*/ float m_RenderedWidth;
        /*0x420*/ bool m_isPreferredWidthDirty;
        /*0x424*/ float m_preferredHeight;
        /*0x428*/ float m_RenderedHeight;
        /*0x42c*/ bool m_isPreferredHeightDirty;
        /*0x42d*/ bool m_isCalculatingPreferredValues;
        /*0x430*/ int m_layoutPriority;
        /*0x434*/ bool m_isLayoutDirty;
        /*0x435*/ bool m_isAwake;
        /*0x436*/ bool m_isWaitingOnResourceLoad;
        /*0x438*/ TMPro.TMP_Text.TextInputSources m_inputSource;
        /*0x43c*/ float m_fontScaleMultiplier;
        /*0x440*/ float tag_LineIndent;
        /*0x444*/ float tag_Indent;
        /*0x448*/ TMPro.TMP_TextProcessingStack<float> m_indentStack;
        /*0x468*/ bool tag_NoParsing;
        /*0x469*/ bool m_isTextLayoutPhase;
        /*0x46c*/ UnityEngine.Quaternion m_FXRotation;
        /*0x47c*/ UnityEngine.Vector3 m_FXScale;
        /*0x488*/ TMPro.TMP_Text.TextProcessingElement[] m_TextProcessingArray;
        /*0x490*/ int m_InternalTextProcessingArraySize;
        /*0x498*/ TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        /*0x4a0*/ int m_totalCharacterCount;
        /*0x4a4*/ int m_characterCount;
        /*0x4a8*/ int m_firstCharacterOfLine;
        /*0x4ac*/ int m_firstVisibleCharacterOfLine;
        /*0x4b0*/ int m_lastCharacterOfLine;
        /*0x4b4*/ int m_lastVisibleCharacterOfLine;
        /*0x4b8*/ int m_lineNumber;
        /*0x4bc*/ int m_lineVisibleCharacterCount;
        /*0x4c0*/ int m_lineVisibleSpaceCount;
        /*0x4c4*/ int m_pageNumber;
        /*0x4c8*/ float m_PageAscender;
        /*0x4cc*/ float m_maxTextAscender;
        /*0x4d0*/ float m_maxCapHeight;
        /*0x4d4*/ float m_ElementAscender;
        /*0x4d8*/ float m_ElementDescender;
        /*0x4dc*/ float m_maxLineAscender;
        /*0x4e0*/ float m_maxLineDescender;
        /*0x4e4*/ float m_startOfLineAscender;
        /*0x4e8*/ float m_startOfLineDescender;
        /*0x4ec*/ float m_lineOffset;
        /*0x4f0*/ TMPro.Extents m_meshExtents;
        /*0x500*/ UnityEngine.Color32 m_htmlColor;
        /*0x508*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;
        /*0x528*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;
        /*0x548*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;
        /*0x568*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;
        /*0x598*/ TMPro.TMP_ColorGradient m_colorGradientPreset;
        /*0x5a0*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;
        /*0x5c8*/ bool m_colorGradientPresetIsTinted;
        /*0x5cc*/ float m_tabSpacing;
        /*0x5d0*/ float m_spacing;
        /*0x5d8*/ TMPro.TMP_TextProcessingStack<int> m_TextStyleStacks;
        /*0x5e0*/ int m_TextStyleStackDepth;
        /*0x5e8*/ TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        /*0x608*/ int m_ItalicAngle;
        /*0x610*/ TMPro.TMP_TextProcessingStack<int> m_actionStack;
        /*0x630*/ float m_padding;
        /*0x634*/ float m_baselineOffset;
        /*0x638*/ TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        /*0x658*/ float m_xAdvance;
        /*0x65c*/ TMPro.TMP_TextElementType m_textElementType;
        /*0x660*/ TMPro.TMP_TextElement m_cached_TextElement;
        /*0x668*/ TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        /*0x688*/ TMPro.TMP_Text.SpecialCharacter m_Underline;
        /*0x6a8*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x6b0*/ TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        /*0x6b8*/ int m_spriteCount;
        /*0x6bc*/ int m_spriteIndex;
        /*0x6c0*/ int m_spriteAnimationID;
        /*0x6c4*/ bool m_ignoreActiveState;
        /*0x6c8*/ TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        /*0x6d8*/ decimal[] k_Power;

        static /*0x7d80c5c*/ TMP_Text();
        static /*0x7d6d5f4*/ void add_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x7d6d6e8*/ void remove_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x7d6d7dc*/ void add_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x7d6d8d0*/ void remove_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x7d6d9c4*/ void add_OnMissingCharacter(TMPro.TMP_Text.MissingCharacterEventCallback value);
        static /*0x7d6daa0*/ void remove_OnMissingCharacter(TMPro.TMP_Text.MissingCharacterEventCallback value);
        /*0x7d8011c*/ TMP_Text();
        /*0x7d6b038*/ string get_text();
        /*0x7d6b120*/ void set_text(string value);
        /*0x7d6b1c4*/ TMPro.ITextPreprocessor get_textPreprocessor();
        /*0x7d6b1cc*/ void set_textPreprocessor(TMPro.ITextPreprocessor value);
        /*0x7d6b1d4*/ bool get_isRightToLeftText();
        /*0x7d6b1dc*/ void set_isRightToLeftText(bool value);
        /*0x7d6b230*/ TMPro.TMP_FontAsset get_font();
        /*0x7d6b238*/ void set_font(TMPro.TMP_FontAsset value);
        /*0x7d6b310*/ UnityEngine.Material get_fontSharedMaterial();
        /*0x7d6b318*/ void set_fontSharedMaterial(UnityEngine.Material value);
        /*0x7d6b3e0*/ UnityEngine.Material[] get_fontSharedMaterials();
        /*0x7d6b3f0*/ void set_fontSharedMaterials(UnityEngine.Material[] value);
        /*0x7d6b43c*/ UnityEngine.Material get_fontMaterial();
        /*0x7d6b450*/ void set_fontMaterial(UnityEngine.Material value);
        /*0x7d6b55c*/ UnityEngine.Material[] get_fontMaterials();
        /*0x7d6b570*/ void set_fontMaterials(UnityEngine.Material[] value);
        /*0x7d6b5bc*/ UnityEngine.Color get_color();
        /*0x7d6b5d0*/ void set_color(UnityEngine.Color value);
        /*0x7d6b648*/ float get_alpha();
        /*0x7d6b650*/ void set_alpha(float value);
        /*0x7d6b67c*/ bool get_enableVertexGradient();
        /*0x7d6b684*/ void set_enableVertexGradient(bool value);
        /*0x7d6b6b4*/ TMPro.VertexGradient get_colorGradient();
        /*0x7d6b6cc*/ void set_colorGradient(TMPro.VertexGradient value);
        /*0x7d6b6f8*/ TMPro.TMP_ColorGradient get_colorGradientPreset();
        /*0x7d6b700*/ void set_colorGradientPreset(TMPro.TMP_ColorGradient value);
        /*0x7d6b734*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x7d6b73c*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x7d6b784*/ bool get_tintAllSprites();
        /*0x7d6b78c*/ void set_tintAllSprites(bool value);
        /*0x7d6b7bc*/ TMPro.TMP_StyleSheet get_styleSheet();
        /*0x7d6b7c4*/ void set_styleSheet(TMPro.TMP_StyleSheet value);
        /*0x7d6b80c*/ TMPro.TMP_Style get_textStyle();
        /*0x7d6b994*/ void set_textStyle(TMPro.TMP_Style value);
        /*0x7d6b9f0*/ bool get_overrideColorTags();
        /*0x7d6b9f8*/ void set_overrideColorTags(bool value);
        /*0x7d6ba28*/ UnityEngine.Color32 get_faceColor();
        /*0x7d6baf0*/ void set_faceColor(UnityEngine.Color32 value);
        /*0x7d6bb78*/ UnityEngine.Color32 get_outlineColor();
        /*0x7d6bc40*/ void set_outlineColor(UnityEngine.Color32 value);
        /*0x7d6bcb4*/ float get_outlineWidth();
        /*0x7d6bd70*/ void set_outlineWidth(float value);
        /*0x7d6bdd0*/ float get_fontSize();
        /*0x7d6bdd8*/ void set_fontSize(float value);
        /*0x7d6be38*/ TMPro.FontWeight get_fontWeight();
        /*0x7d6be40*/ void set_fontWeight(TMPro.FontWeight value);
        /*0x7d6be90*/ float get_pixelsPerUnit();
        /*0x7d6bffc*/ bool get_enableAutoSizing();
        /*0x7d6c004*/ void set_enableAutoSizing(bool value);
        /*0x7d6c050*/ float get_fontSizeMin();
        /*0x7d6c058*/ void set_fontSizeMin(float value);
        /*0x7d6c0a0*/ float get_fontSizeMax();
        /*0x7d6c0a8*/ void set_fontSizeMax(float value);
        /*0x7d6c0f0*/ TMPro.FontStyles get_fontStyle();
        /*0x7d6c0f8*/ void set_fontStyle(TMPro.FontStyles value);
        /*0x7d6c148*/ bool get_isUsingBold();
        /*0x7d6c150*/ TMPro.HorizontalAlignmentOptions get_horizontalAlignment();
        /*0x7d6c158*/ void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value);
        /*0x7d6c184*/ TMPro.VerticalAlignmentOptions get_verticalAlignment();
        /*0x7d6c18c*/ void set_verticalAlignment(TMPro.VerticalAlignmentOptions value);
        /*0x7d6c1b8*/ TMPro.TextAlignmentOptions get_alignment();
        /*0x7d6c1c8*/ void set_alignment(TMPro.TextAlignmentOptions value);
        /*0x7d6c20c*/ float get_characterSpacing();
        /*0x7d6c214*/ void set_characterSpacing(float value);
        /*0x7d6c264*/ float get_wordSpacing();
        /*0x7d6c26c*/ void set_wordSpacing(float value);
        /*0x7d6c2bc*/ float get_lineSpacing();
        /*0x7d6c2c4*/ void set_lineSpacing(float value);
        /*0x7d6c314*/ float get_lineSpacingAdjustment();
        /*0x7d6c31c*/ void set_lineSpacingAdjustment(float value);
        /*0x7d6c36c*/ float get_paragraphSpacing();
        /*0x7d6c374*/ void set_paragraphSpacing(float value);
        /*0x7d6c3c4*/ float get_characterWidthAdjustment();
        /*0x7d6c3cc*/ void set_characterWidthAdjustment(float value);
        /*0x7d6c41c*/ TMPro.TextWrappingModes get_textWrappingMode();
        /*0x7d6c424*/ void set_textWrappingMode(TMPro.TextWrappingModes value);
        /*0x7d6c474*/ bool get_enableWordWrapping();
        /*0x7d6c488*/ void set_enableWordWrapping(bool value);
        /*0x7d6c4dc*/ float get_wordWrappingRatios();
        /*0x7d6c4e4*/ void set_wordWrappingRatios(float value);
        /*0x7d6c534*/ TMPro.TextOverflowModes get_overflowMode();
        /*0x7d6c53c*/ void set_overflowMode(TMPro.TextOverflowModes value);
        /*0x7d6c58c*/ bool get_isTextOverflowing();
        /*0x7d6c59c*/ int get_firstOverflowCharacterIndex();
        /*0x7d6c5a4*/ TMPro.TMP_Text get_linkedTextComponent();
        /*0x7d6c5ac*/ void set_linkedTextComponent(TMPro.TMP_Text value);
        /*0x7d6c8c8*/ bool get_isTextTruncated();
        /*0x7d6c8d0*/ bool get_enableKerning();
        /*0x7d6c928*/ void set_enableKerning(bool value);
        /*0x7d6ca80*/ System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag> get_fontFeatures();
        /*0x7d6ca88*/ void set_fontFeatures(System.Collections.Generic.List<UnityEngine.TextCore.OTL_FeatureTag> value);
        /*0x7d6cad8*/ bool get_extraPadding();
        /*0x7d6cae0*/ void set_extraPadding(bool value);
        /*0x7d6cb34*/ bool get_richText();
        /*0x7d6cb3c*/ void set_richText(bool value);
        /*0x7d6cb90*/ bool get_emojiFallbackSupport();
        /*0x7d6cb98*/ void set_emojiFallbackSupport(bool value);
        /*0x7d6cbec*/ bool get_parseCtrlCharacters();
        /*0x7d6cbf4*/ void set_parseCtrlCharacters(bool value);
        /*0x7d6cc48*/ bool get_isOverlay();
        /*0x7d6cc50*/ void set_isOverlay(bool value);
        /*0x7d6cca4*/ bool get_isOrthographic();
        /*0x7d6ccac*/ void set_isOrthographic(bool value);
        /*0x7d6ccdc*/ bool get_enableCulling();
        /*0x7d6cce4*/ void set_enableCulling(bool value);
        /*0x7d6cd20*/ bool get_ignoreVisibility();
        /*0x7d6cd28*/ void set_ignoreVisibility(bool value);
        /*0x7d6cd48*/ TMPro.TextureMappingOptions get_horizontalMapping();
        /*0x7d6cd50*/ void set_horizontalMapping(TMPro.TextureMappingOptions value);
        /*0x7d6cd7c*/ TMPro.TextureMappingOptions get_verticalMapping();
        /*0x7d6cd84*/ void set_verticalMapping(TMPro.TextureMappingOptions value);
        /*0x7d6cdb0*/ float get_mappingUvLineOffset();
        /*0x7d6cdb8*/ void set_mappingUvLineOffset(float value);
        /*0x7d6cde4*/ TMPro.TextRenderFlags get_renderMode();
        /*0x7d6cdec*/ void set_renderMode(TMPro.TextRenderFlags value);
        /*0x7d6ce08*/ TMPro.VertexSortingOrder get_geometrySortingOrder();
        /*0x7d6ce10*/ void set_geometrySortingOrder(TMPro.VertexSortingOrder value);
        /*0x7d6ce2c*/ bool get_isTextObjectScaleStatic();
        /*0x7d6ce34*/ void set_isTextObjectScaleStatic(bool value);
        /*0x7d6ceb4*/ bool get_vertexBufferAutoSizeReduction();
        /*0x7d6cebc*/ void set_vertexBufferAutoSizeReduction(bool value);
        /*0x7d6cedc*/ int get_firstVisibleCharacter();
        /*0x7d6cee4*/ void set_firstVisibleCharacter(int value);
        /*0x7d6cf10*/ int get_maxVisibleCharacters();
        /*0x7d6cf18*/ void set_maxVisibleCharacters(int value);
        /*0x7d6cf44*/ int get_maxVisibleWords();
        /*0x7d6cf4c*/ void set_maxVisibleWords(int value);
        /*0x7d6cf78*/ int get_maxVisibleLines();
        /*0x7d6cf80*/ void set_maxVisibleLines(int value);
        /*0x7d6cfac*/ bool get_useMaxVisibleDescender();
        /*0x7d6cfb4*/ void set_useMaxVisibleDescender(bool value);
        /*0x7d6cfe4*/ int get_pageToDisplay();
        /*0x7d6cfec*/ void set_pageToDisplay(int value);
        /*0x7d6d018*/ UnityEngine.Vector4 get_margin();
        /*0x7d6d02c*/ void set_margin(UnityEngine.Vector4 value);
        /*0x7d6d0c8*/ TMPro.TMP_TextInfo get_textInfo();
        /*0x7d6d140*/ bool get_havePropertiesChanged();
        /*0x7d6d148*/ void set_havePropertiesChanged(bool value);
        /*0x7d6d170*/ bool get_isUsingLegacyAnimationComponent();
        /*0x7d6d178*/ void set_isUsingLegacyAnimationComponent(bool value);
        /*0x7d6d184*/ UnityEngine.Transform get_transform();
        /*0x7d6d224*/ UnityEngine.RectTransform get_rectTransform();
        /*0x7d6d2c4*/ bool get_autoSizeTextContainer();
        /*0x7d6d2cc*/ void set_autoSizeTextContainer(bool value);
        /*0x7d6d2d8*/ UnityEngine.Mesh get_mesh();
        /*0x7d6d2e0*/ bool get_isVolumetricText();
        /*0x7d6d2e8*/ void set_isVolumetricText(bool value);
        /*0x7d6d350*/ UnityEngine.Bounds get_bounds();
        /*0x7d6d400*/ UnityEngine.Bounds get_textBounds();
        /*0x7d6db7c*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d6dc30*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x7d6dce4*/ TMPro.TMP_SpriteAnimator get_spriteAnimator();
        /*0x7d6ddf4*/ float get_flexibleHeight();
        /*0x7d6ddfc*/ float get_flexibleWidth();
        /*0x7d6de04*/ float get_minWidth();
        /*0x7d6de0c*/ float get_minHeight();
        /*0x7d6de14*/ float get_maxWidth();
        /*0x7d6de1c*/ float get_maxHeight();
        /*0x7d6de24*/ UnityEngine.UI.LayoutElement get_layoutElement();
        /*0x7d6dec4*/ float get_preferredWidth();
        /*0x7d6e04c*/ float get_preferredHeight();
        /*0x7d6e204*/ float get_renderedWidth();
        /*0x7d6e24c*/ float get_renderedHeight();
        /*0x7d6e294*/ int get_layoutPriority();
        /*0x7d6e29c*/ void LoadFontAsset();
        /*0x7d6e2a0*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x7d6e2a4*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x7d6e2ac*/ void SetFontBaseMaterial(UnityEngine.Material mat);
        /*0x7d6e2b0*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x7d6e2b8*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x7d6e2bc*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x7d6e2c4*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x7d6e384*/ void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient);
        /*0x7d6e440*/ void SetTextSortingOrder(TMPro.VertexSortingOrder order);
        /*0x7d6e444*/ void SetTextSortingOrder(int[] order);
        /*0x7d6e448*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x7d6e44c*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x7d6e450*/ void SetOutlineThickness(float thickness);
        /*0x7d6e454*/ void SetShaderDepth();
        /*0x7d6e458*/ void SetCulling();
        /*0x7d6e45c*/ void UpdateCulling();
        /*0x7d6e460*/ float GetPaddingForMaterial();
        /*0x7d6e580*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x7d6e680*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x7d6e688*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x7d6e68c*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x7d6e690*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x7d6e694*/ void UpdateVertexData();
        /*0x7d6e698*/ void SetVertices(UnityEngine.Vector3[] vertices);
        /*0x7d6e69c*/ void UpdateMeshPadding();
        /*0x7d6e6a0*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x7d6e728*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x7d6e77c*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x7d6e780*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x7d6e784*/ void ParseInputText();
        /*0x7d6e89c*/ void PopulateTextBackingArray(string sourceText);
        /*0x7d6f370*/ void PopulateTextBackingArray(string sourceText, int start, int length);
        /*0x7d6f468*/ void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length);
        /*0x7d6f590*/ void PopulateTextBackingArray(char[] sourceText, int start, int length);
        /*0x7d6e8b4*/ void PopulateTextProcessingArray();
        /*0x7d6feec*/ void SetTextInternal(string sourceText);
        /*0x7d6ff38*/ void SetText(string sourceText);
        /*0x7d6ffc0*/ void SetText(string sourceText, bool syncTextInputBox);
        /*0x7d70048*/ void SetText(string sourceText, float arg0);
        /*0x7d70328*/ void SetText(string sourceText, float arg0, float arg1);
        /*0x7d70344*/ void SetText(string sourceText, float arg0, float arg1, float arg2);
        /*0x7d7035c*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        /*0x7d70370*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        /*0x7d70380*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        /*0x7d7038c*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        /*0x7d70068*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        /*0x7d70670*/ void SetText(System.Text.StringBuilder sourceText);
        /*0x7d706b4*/ void SetText(System.Text.StringBuilder sourceText, int start, int length);
        /*0x7d70710*/ void SetText(char[] sourceText);
        /*0x7d70784*/ void SetText(char[] sourceText, int start, int length);
        /*0x7d70788*/ void SetCharArray(char[] sourceText);
        /*0x7d70728*/ void SetCharArray(char[] sourceText, int start, int length);
        /*0x7d6b870*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x7d6fb20*/ void InsertOpeningTextStyle(TMPro.TMP_Style style, ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d6fcd4*/ void InsertClosingTextStyle(TMPro.TMP_Style style, ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d707a0*/ void InsertTextStyleInTextProcessingArray(ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition);
        /*0x7d6fbd8*/ bool ReplaceOpeningStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d70eb8*/ bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d6fd8c*/ void ReplaceClosingStyleTag(ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d6f6a4*/ void InsertOpeningStyleTag(TMPro.TMP_Style style, ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d6fe50*/ void InsertClosingStyleTag(ref TMPro.TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex);
        /*0x7d70d9c*/ int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex);
        /*0x7d6fa14*/ int GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer styleDefinition, int readIndex);
        /*0x7d710c0*/ int GetStyleHashCode(ref uint[] text, int index, ref int closeIndex);
        /*0x7d70fb4*/ int GetStyleHashCode(ref TMPro.TMP_Text.TextBackingContainer text, int index, ref int closeIndex);
        /*0x3816710*/ void ResizeInternalArray<T>(ref T[] array);
        /*0x381678c*/ void ResizeInternalArray<T>(ref T[] array, int size);
        /*0x7d70394*/ void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex);
        /*0x7d7119c*/ void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex);
        /*0x7d6b04c*/ string InternalTextBackingArrayToString();
        /*0x7d712cc*/ int SetArraySizes(TMPro.TMP_Text.TextProcessingElement[] unicodeChars);
        /*0x7d712d4*/ UnityEngine.Vector2 GetPreferredValues();
        /*0x7d71320*/ UnityEngine.Vector2 GetPreferredValues(float width, float height);
        /*0x7d7149c*/ UnityEngine.Vector2 GetPreferredValues(string text);
        /*0x7d71570*/ UnityEngine.Vector2 GetPreferredValues(string text, float width, float height);
        /*0x7d6dedc*/ float GetPreferredWidth();
        /*0x7d71380*/ float GetPreferredWidth(UnityEngine.Vector2 margin);
        /*0x7d71638*/ float GetPreferredWidth(UnityEngine.Vector2 margin, TMPro.TextWrappingModes wrapMode);
        /*0x7d6e064*/ float GetPreferredHeight();
        /*0x7d713ec*/ float GetPreferredHeight(UnityEngine.Vector2 margin);
        /*0x7d71698*/ UnityEngine.Vector2 GetRenderedValues();
        /*0x7d716c0*/ UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        /*0x7d6e228*/ float GetRenderedWidth();
        /*0x7d718f8*/ float GetRenderedWidth(bool onlyVisibleCharacters);
        /*0x7d6e270*/ float GetRenderedHeight();
        /*0x7d71920*/ float GetRenderedHeight(bool onlyVisibleCharacters);
        /*0x7d71948*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, TMPro.TextWrappingModes textWrapMode);
        /*0x7d79d18*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x7d79d24*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x7d6d444*/ UnityEngine.Bounds GetTextBounds();
        /*0x7d716ec*/ UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters);
        /*0x7d79d2c*/ void AdjustLineOffset(int startIndex, int endIndex, float offset);
        /*0x7d79ee4*/ void ResizeLineExtents(int size);
        /*0x7d7a09c*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x7d7a0a4*/ void ComputeMarginSize();
        /*0x7d7a0a8*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        /*0x7d79970*/ void SaveWordWrappingState(ref TMPro.WordWrapState state, int index, int count);
        /*0x7d795b0*/ int RestoreWordWrappingState(ref TMPro.WordWrapState state);
        /*0x7d7a56c*/ void SaveGlyphVertexInfo(float padding, float style_padding, UnityEngine.Color32 vertexColor);
        /*0x7d7b214*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor);
        /*0x7d7b988*/ void FillCharacterVertexBuffers(int i);
        /*0x7d7c0f8*/ void FillCharacterVertexBuffers(int i, bool isVolumetric);
        /*0x7d7cc34*/ void FillSpriteVertexBuffers(int i);
        /*0x7d7d3a4*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor);
        /*0x7d7e278*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor);
        /*0x7d7e7e8*/ void LoadDefaultSettings();
        /*0x7d7ebd0*/ void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset);
        /*0x7d7ebf8*/ void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x7d7e1bc*/ void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x7d7eea8*/ void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        /*0x7d7ef1c*/ TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        /*0x7d7ef98*/ TMPro.TMP_TextElement GetTextElement(uint unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isUsingAlternativeTypeface);
        /*0x7d7f508*/ void SetActiveSubMeshes(bool state);
        /*0x7d7f50c*/ void DestroySubMeshObjects();
        /*0x7d7f510*/ void ClearMesh();
        /*0x7d7f514*/ void ClearMesh(bool uploadGeometry);
        /*0x7d7f518*/ string GetParsedText();
        /*0x7d6c7e8*/ bool IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent);
        /*0x7d6c6c4*/ void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent);
        /*0x7d7f604*/ void DoMissingGlyphCallback(int unicode, int stringIndex, TMPro.TMP_FontAsset fontAsset);
        /*0x7d7f6b4*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
        /*0x7d7f714*/ float PackUV(float x, float y);
        /*0x7d7f774*/ void InternalUpdate();
        /*0x7d7f778*/ uint HexToInt(char hex);
        /*0x7d6f73c*/ bool IsValidUTF16(TMPro.TMP_Text.TextBackingContainer text, int index);
        /*0x7d70bac*/ uint GetUTF16(uint[] text, int i);
        /*0x7d6f7b8*/ uint GetUTF16(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x7d6f860*/ bool IsValidUTF32(TMPro.TMP_Text.TextBackingContainer text, int index);
        /*0x7d70c54*/ uint GetUTF32(uint[] text, int i);
        /*0x7d6f8dc*/ uint GetUTF32(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x7d7f7a4*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
        /*0x7d7fbb8*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        /*0x7d7fe04*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
        /*0x7d80030*/ float ConvertToFloat(char[] chars, int startIndex, int length);
        /*0x7d7feb0*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
        /*0x7d80048*/ void ClearMarkupTagAttributes();
        /*0x7d74334*/ bool ValidateHtmlTag(TMPro.TMP_Text.TextProcessingElement[] chars, int startIndex, ref int endIndex);

        class MissingCharacterEventCallback : System.MulticastDelegate
        {
            /*0x7d9d9c0*/ MissingCharacterEventCallback(object object, nint method);
            /*0x7d9da60*/ void Invoke(int unicode, int stringIndex, string text, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_Text textComponent);
            /*0x7d9da74*/ System.IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_Text textComponent, System.AsyncCallback callback, object object);
            /*0x7d9db0c*/ void EndInvoke(System.IAsyncResult result);
        }

        struct CharacterSubstitution
        {
            /*0x10*/ int index;
            /*0x14*/ uint unicode;

            /*0x7d9db18*/ CharacterSubstitution(int index, uint unicode);
        }

        enum TextInputSources
        {
            TextInputBox = 0,
            SetText = 1,
            SetTextArray = 2,
            TextString = 3,
        }

        struct TextProcessingElement
        {
            /*0x10*/ TMPro.TextProcessingElementType elementType;
            /*0x14*/ uint unicode;
            /*0x18*/ int stringIndex;
            /*0x1c*/ int length;
        }

        struct SpecialCharacter
        {
            /*0x10*/ TMPro.TMP_Character character;
            /*0x18*/ TMPro.TMP_FontAsset fontAsset;
            /*0x20*/ UnityEngine.Material material;
            /*0x28*/ int materialIndex;

            /*0x7d9db20*/ SpecialCharacter(TMPro.TMP_Character character, int materialIndex);
        }

        struct TextBackingContainer
        {
            /*0x10*/ uint[] m_Array;
            /*0x18*/ int m_Index;

            /*0x7d9dd9c*/ TextBackingContainer(int size);
            /*0x7d9dc6c*/ uint[] get_Text();
            /*0x7d9dc74*/ int get_Capacity();
            /*0x7d9dc90*/ int get_Count();
            /*0x7d9dc98*/ void set_Count(int value);
            /*0x7d9dca0*/ uint get_Item(int index);
            /*0x7d9dcd0*/ void set_Item(int index, uint value);
            /*0x7d9dd30*/ void Resize(int size);
        }

        class <>c
        {
            static /*0x0*/ TMPro.TMP_Text.<> <>9;
            static /*0x8*/ System.Action<TMPro.TMP_TextInfo> <>9__645_0;

            static /*0x7d9de08*/ <>c();
            /*0x7d9de70*/ <>c();
            /*0x7d9de78*/ void <.ctor>b__645_0(TMPro.TMP_TextInfo <p0>);
        }
    }

    enum TextElementType
    {
        Character = 1,
        Sprite = 2,
    }

    class TMP_TextElement
    {
        /*0x10*/ TMPro.TextElementType m_ElementType;
        /*0x14*/ uint m_Unicode;
        /*0x18*/ TMPro.TMP_Asset m_TextAsset;
        /*0x20*/ UnityEngine.TextCore.Glyph m_Glyph;
        /*0x28*/ uint m_GlyphIndex;
        /*0x2c*/ float m_Scale;

        /*0x7d9a82c*/ TMP_TextElement();
        /*0x7d9de7c*/ TMPro.TextElementType get_elementType();
        /*0x7d9de84*/ uint get_unicode();
        /*0x7d9de8c*/ void set_unicode(uint value);
        /*0x7d9de94*/ TMPro.TMP_Asset get_textAsset();
        /*0x7d9de9c*/ void set_textAsset(TMPro.TMP_Asset value);
        /*0x7d9dea4*/ UnityEngine.TextCore.Glyph get_glyph();
        /*0x7d9deac*/ void set_glyph(UnityEngine.TextCore.Glyph value);
        /*0x7d9deb4*/ uint get_glyphIndex();
        /*0x7d9debc*/ void set_glyphIndex(uint value);
        /*0x7d9dec4*/ float get_scale();
        /*0x7d9decc*/ void set_scale(float value);
    }

    class TMP_TextElement_Legacy
    {
        /*0x10*/ int id;
        /*0x14*/ float x;
        /*0x18*/ float y;
        /*0x1c*/ float width;
        /*0x20*/ float height;
        /*0x24*/ float xOffset;
        /*0x28*/ float yOffset;
        /*0x2c*/ float xAdvance;
        /*0x30*/ float scale;

        /*0x7d97e74*/ TMP_TextElement_Legacy();
    }

    class TMP_TextInfo
    {
        static /*0x0*/ UnityEngine.Vector2 k_InfinityVectorPositive;
        static /*0x8*/ UnityEngine.Vector2 k_InfinityVectorNegative;
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int characterCount;
        /*0x1c*/ int spriteCount;
        /*0x20*/ int spaceCount;
        /*0x24*/ int wordCount;
        /*0x28*/ int linkCount;
        /*0x2c*/ int lineCount;
        /*0x30*/ int pageCount;
        /*0x34*/ int materialCount;
        /*0x38*/ TMPro.TMP_CharacterInfo[] characterInfo;
        /*0x40*/ TMPro.TMP_WordInfo[] wordInfo;
        /*0x48*/ TMPro.TMP_LinkInfo[] linkInfo;
        /*0x50*/ TMPro.TMP_LineInfo[] lineInfo;
        /*0x58*/ TMPro.TMP_PageInfo[] pageInfo;
        /*0x60*/ TMPro.TMP_MeshInfo[] meshInfo;
        /*0x68*/ TMPro.TMP_MeshInfo[] m_CachedMeshInfo;

        static /*0x7d9ee8c*/ TMP_TextInfo();
        static /*0x3842d2c*/ void Resize<T>(ref T[] array, int size);
        static /*0x3842d68*/ void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
        /*0x7d9ded4*/ TMP_TextInfo();
        /*0x7d9e040*/ TMP_TextInfo(int characterCount);
        /*0x7d9e1b0*/ TMP_TextInfo(TMPro.TMP_Text textComponent);
        /*0x7d9e380*/ void Clear();
        /*0x7d9e3dc*/ void ClearAllData();
        /*0x7d9e54c*/ void ClearMeshInfo(bool updateMesh);
        /*0x7d9e604*/ void ClearAllMeshInfo();
        /*0x7d9e6b4*/ void ResetVertexLayout(bool isVolumetric);
        /*0x7d9e770*/ void ClearUnusedVertices(TMPro.MaterialReference[] materials);
        /*0x7d9e820*/ void ClearLineInfo();
        /*0x7d9e9ac*/ void ClearPageInfo();
        /*0x7d9ea54*/ TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData();
    }

    class TMP_TextParsingUtilities
    {
        static string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ TMPro.TMP_TextParsingUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<uint> k_EmojiLookup;
        static /*0x10*/ System.Collections.Generic.HashSet<uint> k_EmojiPresentationFormLookup;

        static /*0x7d80fe0*/ TMP_TextParsingUtilities();
        static /*0x7d9eef8*/ TMPro.TMP_TextParsingUtilities get_instance();
        static /*0x7d9acfc*/ int GetHashCode(string s);
        static /*0x7d9efc4*/ int GetHashCodeCaseSensitive(string s);
        static /*0x7d9f030*/ char ToLowerASCIIFast(char c);
        static /*0x7d9ef50*/ char ToUpperASCIIFast(char c);
        static /*0x7d9f0a4*/ uint ToUpperASCIIFast(uint c);
        static /*0x7d9f118*/ uint ToLowerASCIIFast(uint c);
        static /*0x7d9f18c*/ bool IsHighSurrogate(uint c);
        static /*0x7d9f1a0*/ bool IsLowSurrogate(uint c);
        static /*0x7d9f1b4*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
        static /*0x7d9f1c8*/ bool IsDiacriticalMark(uint c);
        static /*0x7d9f21c*/ bool IsBaseGlyph(uint c);
        static /*0x7d9f344*/ bool IsEmoji(uint c);
        static /*0x7d9f3c4*/ bool IsEmojiPresentationForm(uint c);
        static /*0x7d9f444*/ bool IsHangul(uint c);
        static /*0x7d9f4b4*/ bool IsCJK(uint c);
        /*0x7d9f660*/ TMP_TextParsingUtilities();
    }

    enum TextProcessingElementType
    {
        Undefined = 0,
        TextCharacterElement = 1,
        TextMarkupElement = 2,
    }

    struct CharacterElement
    {
        /*0x10*/ uint m_Unicode;
        /*0x18*/ TMPro.TMP_TextElement m_TextElement;

        /*0x7d9f678*/ CharacterElement(TMPro.TMP_TextElement textElement);
        /*0x7d9f668*/ uint get_Unicode();
        /*0x7d9f670*/ void set_Unicode(uint value);
    }

    struct MarkupAttribute
    {
        /*0x10*/ int m_NameHashCode;
        /*0x14*/ int m_ValueHashCode;
        /*0x18*/ int m_ValueStartIndex;
        /*0x1c*/ int m_ValueLength;

        /*0x7d9f698*/ int get_NameHashCode();
        /*0x7d9f6a0*/ void set_NameHashCode(int value);
        /*0x7d9f6a8*/ int get_ValueHashCode();
        /*0x7d9f6b0*/ void set_ValueHashCode(int value);
        /*0x7d9f6b8*/ int get_ValueStartIndex();
        /*0x7d9f6c0*/ void set_ValueStartIndex(int value);
        /*0x7d9f6c8*/ int get_ValueLength();
        /*0x7d9f6d0*/ void set_ValueLength(int value);
    }

    struct MarkupElement
    {
        /*0x10*/ TMPro.MarkupAttribute[] m_Attributes;

        /*0x7d9f894*/ MarkupElement(int nameHashCode, int startIndex, int length);
        /*0x7d9f6d8*/ int get_NameHashCode();
        /*0x7d9f704*/ void set_NameHashCode(int value);
        /*0x7d9f788*/ int get_ValueHashCode();
        /*0x7d9f7b4*/ void set_ValueHashCode(int value);
        /*0x7d9f7dc*/ int get_ValueStartIndex();
        /*0x7d9f808*/ void set_ValueStartIndex(int value);
        /*0x7d9f830*/ int get_ValueLength();
        /*0x7d9f85c*/ void set_ValueLength(int value);
        /*0x7d9f884*/ TMPro.MarkupAttribute[] get_Attributes();
        /*0x7d9f88c*/ void set_Attributes(TMPro.MarkupAttribute[] value);
    }

    struct TextProcessingElement
    {
        /*0x10*/ TMPro.TextProcessingElementType m_ElementType;
        /*0x14*/ int m_StartIndex;
        /*0x18*/ int m_Length;
        /*0x20*/ TMPro.CharacterElement m_CharacterElement;
        /*0x30*/ TMPro.MarkupElement m_MarkupElement;

        static /*0x7d9fa68*/ TMPro.TextProcessingElement get_Undefined();
        /*0x7d9f97c*/ TextProcessingElement(TMPro.TextProcessingElementType elementType, int startIndex, int length);
        /*0x7d9f990*/ TextProcessingElement(TMPro.TMP_TextElement textElement, int startIndex, int length);
        /*0x7d9f9dc*/ TextProcessingElement(TMPro.CharacterElement characterElement, int startIndex, int length);
        /*0x7d9fa0c*/ TextProcessingElement(TMPro.MarkupElement markupElement);
        /*0x7d9f92c*/ TMPro.TextProcessingElementType get_ElementType();
        /*0x7d9f934*/ void set_ElementType(TMPro.TextProcessingElementType value);
        /*0x7d9f93c*/ int get_StartIndex();
        /*0x7d9f944*/ void set_StartIndex(int value);
        /*0x7d9f94c*/ int get_Length();
        /*0x7d9f954*/ void set_Length(int value);
        /*0x7d9f95c*/ TMPro.CharacterElement get_CharacterElement();
        /*0x7d9f968*/ TMPro.MarkupElement get_MarkupElement();
        /*0x7d9f970*/ void set_MarkupElement(TMPro.MarkupElement value);
        /*0x7d9fa78*/ string DebuggerDisplay();
    }

    struct TMP_FontStyleStack
    {
        /*0x10*/ byte bold;
        /*0x11*/ byte italic;
        /*0x12*/ byte underline;
        /*0x13*/ byte strikethrough;
        /*0x14*/ byte highlight;
        /*0x15*/ byte superscript;
        /*0x16*/ byte subscript;
        /*0x17*/ byte uppercase;
        /*0x18*/ byte lowercase;
        /*0x19*/ byte smallcaps;

        /*0x7d9fb80*/ void Clear();
        /*0x7d9fb8c*/ byte Add(TMPro.FontStyles style);
        /*0x7d9fc88*/ byte Remove(TMPro.FontStyles style);
    }

    struct TMP_TextProcessingStack<T>
    {
        static int k_DefaultCapacity = 4;
        /*0x0*/ T[] itemStack;
        /*0x0*/ int index;
        /*0x0*/ T m_DefaultItem;
        /*0x0*/ int m_Capacity;
        /*0x0*/ int m_RolloverSize;
        /*0x0*/ int m_Count;

        static /*0x3910ae8*/ void SetDefault(TMPro.TMP_TextProcessingStack<T> stack, T item);
        /*0x3816710*/ TMP_TextProcessingStack(T[] stack);
        /*0x3815ed0*/ TMP_TextProcessingStack(int capacity);
        /*0x3815fb8*/ TMP_TextProcessingStack(int capacity, int rolloverSize);
        /*0x3814574*/ int get_Count();
        /*0x3910ae8*/ T get_current();
        /*0x3814574*/ int get_rolloverSize();
        /*0x3815ed0*/ void set_rolloverSize(int value);
        /*0x38159dc*/ void Clear();
        /*0x3910ae8*/ void SetDefault(T item);
        /*0x3910ae8*/ void Add(T item);
        /*0x3910ae8*/ T Remove();
        /*0x3910ae8*/ void Push(T item);
        /*0x3910ae8*/ T Pop();
        /*0x3910ae8*/ T Peek();
        /*0x3910ae8*/ T CurrentItem();
        /*0x3910ae8*/ T PreviousItem();
    }

    enum CaretPosition
    {
        None = 0,
        Left = 1,
        Right = 2,
    }

    struct CaretInfo
    {
        /*0x10*/ int index;
        /*0x14*/ TMPro.CaretPosition position;

        /*0x7d9fdcc*/ CaretInfo(int index, TMPro.CaretPosition position);
    }

    class TMP_TextUtilities
    {
        static string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ UnityEngine.Vector3[] m_rectWorldCorners;

        static /*0x7da2f48*/ TMP_TextUtilities();
        static /*0x7d9fdd4*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da05ac*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, ref TMPro.CaretPosition cursor);
        static /*0x7da07c0*/ int FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da0960*/ int FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, int line, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x7da0eb4*/ bool IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da0fd0*/ int FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x7d9ff40*/ int FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x7da11f8*/ int FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da1668*/ int FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da1c60*/ int FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da1dd8*/ int FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da2154*/ int FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x7da0d2c*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
        static /*0x7da0288*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x7da289c*/ bool IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, ref UnityEngine.Vector3 intersectingPoint);
        static /*0x7da0dec*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
        static /*0x7da2a0c*/ char ToLowerFast(char c);
        static /*0x7da2a80*/ char ToUpperFast(char c);
        static /*0x7da2af4*/ uint ToUpperASCIIFast(uint c);
        static /*0x7da2b68*/ int GetHashCode(string s);
        static /*0x7da2c34*/ int GetSimpleHashCode(string s);
        static /*0x7da2ca0*/ uint GetSimpleHashCodeLowercase(string s);
        static /*0x7da2d5c*/ uint GetHashCodeCaseInSensitive(string s);
        static /*0x7da2e18*/ int HexToInt(char hex);
        static /*0x7da2e44*/ int StringHexToInt(string s);

        struct LineSegment
        {
            /*0x10*/ UnityEngine.Vector3 Point1;
            /*0x1c*/ UnityEngine.Vector3 Point2;

            /*0x7da2fbc*/ LineSegment(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
        }
    }

    class TMP_UpdateManager
    {
        static /*0x0*/ TMPro.TMP_UpdateManager s_Instance;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_RegisterTextObjectForUpdateMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_UnregisterTextObjectForUpdateMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;
        /*0x10*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Text> m_LayoutRebuildQueue;
        /*0x20*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;
        /*0x28*/ System.Collections.Generic.List<TMPro.TMP_Text> m_GraphicRebuildQueue;
        /*0x30*/ System.Collections.Generic.HashSet<int> m_InternalUpdateLookup;
        /*0x38*/ System.Collections.Generic.List<TMPro.TMP_Text> m_InternalUpdateQueue;
        /*0x40*/ System.Collections.Generic.HashSet<int> m_CullingUpdateLookup;
        /*0x48*/ System.Collections.Generic.List<TMPro.TMP_Text> m_CullingUpdateQueue;

        static /*0x7da3d98*/ TMP_UpdateManager();
        static /*0x7da2fcc*/ TMPro.TMP_UpdateManager get_instance();
        static /*0x7da3288*/ void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x7da340c*/ void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        static /*0x7da3590*/ void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        static /*0x7da3714*/ void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        static /*0x7da3af0*/ void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x7da3be8*/ void UnRegisterTextElementForRebuild(TMPro.TMP_Text element);
        /*0x7da307c*/ TMP_UpdateManager();
        /*0x7da32e8*/ void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        /*0x7da346c*/ void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x7da35f0*/ void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x7da3774*/ void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        /*0x7da3898*/ void OnCameraPreCull();
        /*0x7da389c*/ void DoRebuilds();
        /*0x7da3c68*/ void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x7da3d00*/ void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x7da3b50*/ void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
    }

    class TMP_UpdateRegistry
    {
        static /*0x0*/ TMPro.TMP_UpdateRegistry s_Instance;
        /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        /*0x18*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        /*0x28*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;

        static /*0x7da3efc*/ TMPro.TMP_UpdateRegistry get_instance();
        static /*0x7da40fc*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x7da4280*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x7da46c8*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x7da3f80*/ TMP_UpdateRegistry();
        /*0x7da411c*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x7da42a0*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x7da4404*/ void PerformUpdateForCanvasRendererObjects();
        /*0x7da4660*/ void PerformUpdateForMeshRendererObjects();
        /*0x7da46f8*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x7da47d4*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
    }

    namespace SpriteAssetUtilities
    {
        enum SpriteAssetImportFormats
        {
            None = 0,
            TexturePackerJsonArray = 1,
        }

        class TexturePacker_JsonArray
        {
            /*0x7da48b0*/ TexturePacker_JsonArray();

            struct SpriteFrame
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float w;
                /*0x1c*/ float h;

                /*0x7da48b8*/ string ToString();
            }

            struct SpriteSize
            {
                /*0x10*/ float w;
                /*0x14*/ float h;

                /*0x7da4ac0*/ string ToString();
            }

            struct Frame
            {
                /*0x10*/ string filename;
                /*0x18*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame frame;
                /*0x28*/ bool rotated;
                /*0x29*/ bool trimmed;
                /*0x2c*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteFrame spriteSourceSize;
                /*0x3c*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize sourceSize;
                /*0x44*/ UnityEngine.Vector2 pivot;
            }

            struct Meta
            {
                /*0x10*/ string app;
                /*0x18*/ string version;
                /*0x20*/ string image;
                /*0x28*/ string format;
                /*0x30*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.SpriteSize size;
                /*0x38*/ float scale;
                /*0x40*/ string smartupdate;
            }

            class SpriteDataObject
            {
                /*0x10*/ System.Collections.Generic.List<TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Frame> frames;
                /*0x18*/ TMPro.SpriteAssetUtilities.TexturePacker_JsonArray.Meta meta;

                /*0x7da4b6c*/ SpriteDataObject();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 4897DD6635C7EC5E5C512F52F033CAEC468D545748FB8976671A32C5DE54C5D3;
    static /*0x1472*/ <PrivateImplementationDetails> A6E21FF243506C7209FE54F15FD89FE69E27C78A0370B06A269EA7E47509CE98;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=4040
    {
    }

    struct __StaticArrayInitTypeSize=5222
    {
    }
}
