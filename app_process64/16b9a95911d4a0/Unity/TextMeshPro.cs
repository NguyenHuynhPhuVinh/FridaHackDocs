class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3cbfe54*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3cbff48*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace TMPro
{
    class ChainingContextualSubstitution : TMPro.ISubstitutionLookup
    {
        /*0x10*/ TMPro.GlyphArray[] m_backtrackingSequence;
        /*0x18*/ TMPro.GlyphArray[] _inputSequence;
        /*0x20*/ TMPro.GlyphArray[] _lookAheadSequence;
        /*0x28*/ ushort[] _sequenceIndices;
        /*0x30*/ ushort[] _lookupListIndices;
        /*0x38*/ ushort _lookupIndex;
        /*0x40*/ System.Collections.Generic.HashSet<ushort> _backtrackingSequence;
        /*0x48*/ System.Collections.Generic.HashSet<ushort> _inputLookAheadSequence;
        /*0x50*/ TMPro.TMP_FontAsset _fontAsset;

        /*0x3cbff58*/ ChainingContextualSubstitution(TMPro.GlyphArray[] backtracking, TMPro.GlyphArray[] input, TMPro.GlyphArray[] lookAhead, ushort[] sequenceIndices, ushort[] lookupListIndices, ushort lookupIndex);
        /*0x3cbff50*/ ushort get_LookupIndex();
        /*0x3cbfff4*/ void Initialize(TMPro.TMP_FontAsset fontAsset);
        /*0x3cc02e8*/ void DoSubstitution(ref TMPro.TMP_Text.UnicodeChar[] text, ref TMPro.TMP_CharacterInfo[] characterInfo, int position, ref int characterCount);
    }

    class FastAction
    {
        /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

        /*0x3cc081c*/ FastAction();
        /*0x3cc05c0*/ void Add(System.Action rhs);
        /*0x3cc0680*/ void Remove(System.Action rhs);
        /*0x3cc0740*/ void Call();
    }

    class FastAction<A>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

        /*0x1f309e4*/ FastAction();
        /*0x1f30ebc*/ void Add(System.Action<A> rhs);
        /*0x1f30ebc*/ void Remove(System.Action<A> rhs);
        /*0x1ffc854*/ void Call(A a);
    }

    class FastAction<A, B>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

        /*0x1f309e4*/ FastAction();
        /*0x1f30ebc*/ void Add(System.Action<A, B> rhs);
        /*0x1f30ebc*/ void Remove(System.Action<A, B> rhs);
        /*0x1ffc854*/ void Call(A a, B b);
    }

    class FastAction<A, B, C>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

        /*0x1f309e4*/ FastAction();
        /*0x1f30ebc*/ void Add(System.Action<A, B, C> rhs);
        /*0x1f30ebc*/ void Remove(System.Action<A, B, C> rhs);
        /*0x1ffc854*/ void Call(A a, B b, C c);
    }

    interface ITextPreprocessor
    {
        /*0x1f302cc*/ string PreprocessText(string text);
    }

    class LigatureSubstitution : TMPro.ISubstitutionLookup
    {
        /*0x10*/ TMPro.LigatureSet[] _sets;
        /*0x18*/ ushort _lookupIndex;
        /*0x20*/ System.Collections.Generic.Dictionary<ushort, TMPro.LigatureSet> _ligatureDictionary;
        /*0x28*/ TMPro.TMP_FontAsset _fontAsset;

        /*0x3cc0900*/ LigatureSubstitution(TMPro.LigatureSet[] sets, ushort lookupIndex);
        /*0x3cc08f8*/ ushort get_LookupIndex();
        /*0x3cc093c*/ System.Collections.Generic.IList<ushort> GetSubstitutionGlyphs();
        /*0x3cc0a24*/ void Initialize(TMPro.TMP_FontAsset fontAsset);
        /*0x3cc0b3c*/ void DoSubstitution(ref TMPro.TMP_Text.UnicodeChar[] text, ref TMPro.TMP_CharacterInfo[] characterInfo, int position, ref int characterCount);
    }

    class LigatureSet
    {
        /*0x10*/ ushort _firstGLyph;
        /*0x18*/ TMPro.GlyphArray[] _successiveGlyphs;
        /*0x20*/ ushort[] _outputGlyphs;

        /*0x3cc0f44*/ LigatureSet(ushort firstGlyph, TMPro.GlyphArray[] successiveGlyphs, ushort[] outputGlyphs);
        /*0x3cc0f2c*/ ushort get_FirstGlyph();
        /*0x3cc0f34*/ TMPro.GlyphArray[] get_SuccessiveGlyphs();
        /*0x3cc0f3c*/ ushort[] get_OutputGlyphs();
    }

    class MaterialReferenceManager
    {
        static /*0x0*/ TMPro.MaterialReferenceManager s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
        /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        /*0x28*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;

        static /*0x3cc0f98*/ TMPro.MaterialReferenceManager get_instance();
        static /*0x3cc11a0*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cc129c*/ void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x3cc1398*/ void AddSpriteAsset(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x3cc14b0*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
        static /*0x3cc1550*/ void AddColorGradientPreset(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        static /*0x3cc1708*/ bool TryGetFontAsset(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x3cc17bc*/ bool TryGetSpriteAsset(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x3cc1870*/ bool TryGetColorGradientPreset(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        static /*0x3cc1924*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
        /*0x3cc101c*/ MaterialReferenceManager();
        /*0x3cc11c0*/ void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset);
        /*0x3cc12bc*/ void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset);
        /*0x3cc13c8*/ void AddSpriteAssetInternal(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        /*0x3cc14e0*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
        /*0x3cc1580*/ void AddColorGradientPreset_Internal(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        /*0x3cc1620*/ bool Contains(TMPro.TMP_FontAsset font);
        /*0x3cc1694*/ bool Contains(TMPro.TMP_SpriteAsset sprite);
        /*0x3cc1738*/ bool TryGetFontAssetInternal(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        /*0x3cc17ec*/ bool TryGetSpriteAssetInternal(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        /*0x3cc18a0*/ bool TryGetColorGradientPresetInternal(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        /*0x3cc1954*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
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

        static /*0x3cc1a94*/ bool Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset);
        static /*0x3cc1b9c*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        static /*0x3cc1de4*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        /*0x3cc19d8*/ MaterialReference(int index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
    }

    class MultipleSubstitution : TMPro.ISubstitutionLookup
    {
        static uint SaraAm = 3635;
        /*0x10*/ ushort[] _inputGlyphs;
        /*0x18*/ TMPro.GlyphArray[] _outputGlyphs;
        /*0x20*/ ushort _lookupIndex;
        /*0x28*/ System.Collections.Generic.Dictionary<ushort, System.UInt16[]> _glyphDictionary;
        /*0x30*/ TMPro.TMP_FontAsset _fontAsset;

        static /*0x3cc280c*/ bool IsToneMark(uint codepoint);
        static /*0x3cc2754*/ void ResizeTextBuffer(ref TMPro.TMP_Text.UnicodeChar[] text, int sizeIncrease);
        /*0x3cc1ffc*/ MultipleSubstitution(ushort[] inputGlyphs, TMPro.GlyphArray[] outputGlyphs, ushort lookupIndex);
        /*0x3cc1ff4*/ ushort get_LookupIndex();
        /*0x3cc2054*/ System.Collections.Generic.IList<ushort> GetSubstitutionGlyphs();
        /*0x3cc2138*/ void Initialize(TMPro.TMP_FontAsset fontAsset);
        /*0x3cc2268*/ void DoSubstitution(ref TMPro.TMP_Text.UnicodeChar[] text, ref TMPro.TMP_CharacterInfo[] characterInfo, int position, ref int characterCount);
    }

    class SingleSubstitution : TMPro.ISubstitutionLookup
    {
        /*0x10*/ ushort[] _inputGlyphs;
        /*0x18*/ ushort[] _outputGlyphs;
        /*0x20*/ ushort _lookupIndex;
        /*0x28*/ System.Collections.Generic.Dictionary<ushort, ushort> _glyphDictionary;
        /*0x30*/ TMPro.TMP_FontAsset _fontAsset;

        /*0x3cc283c*/ SingleSubstitution(ushort[] inputGlyphs, ushort[] outputGlyphs, ushort lookupIndex);
        /*0x3cc2834*/ ushort get_LookupIndex();
        /*0x3cc2894*/ void Initialize(TMPro.TMP_FontAsset fontAsset);
        /*0x3cc29cc*/ System.Collections.Generic.IList<ushort> GetSubstitutionGlyphs();
        /*0x3cc29d4*/ void DoSubstitution(ref TMPro.TMP_Text.UnicodeChar[] text, ref TMPro.TMP_CharacterInfo[] characterInfo, int position, ref int characterCount);
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

        static /*0x3cc3584*/ TextContainer();
        /*0x3cc34fc*/ TextContainer();
        /*0x3cc2b78*/ bool get_hasChanged();
        /*0x3cc2b80*/ void set_hasChanged(bool value);
        /*0x3cc2b88*/ UnityEngine.Vector2 get_pivot();
        /*0x3cc2b90*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x3cc2dec*/ TMPro.TextContainerAnchors get_anchorPosition();
        /*0x3cc2df4*/ void set_anchorPosition(TMPro.TextContainerAnchors value);
        /*0x3cc2ea4*/ UnityEngine.Rect get_rect();
        /*0x3cc2eb0*/ void set_rect(UnityEngine.Rect value);
        /*0x3cc2efc*/ UnityEngine.Vector2 get_size();
        /*0x3cc2f04*/ void set_size(UnityEngine.Vector2 value);
        /*0x3cc2f4c*/ float get_width();
        /*0x3cc2f54*/ void set_width(float value);
        /*0x3cc2f68*/ float get_height();
        /*0x3cc2f70*/ void set_height(float value);
        /*0x3cc2f84*/ bool get_isDefaultWidth();
        /*0x3cc2f8c*/ bool get_isDefaultHeight();
        /*0x3cc2f94*/ bool get_isAutoFitting();
        /*0x3cc2f9c*/ void set_isAutoFitting(bool value);
        /*0x3cc2fa4*/ UnityEngine.Vector3[] get_corners();
        /*0x3cc2fac*/ UnityEngine.Vector3[] get_worldCorners();
        /*0x3cc2fb4*/ UnityEngine.Vector4 get_margins();
        /*0x3cc2fc0*/ void set_margins(UnityEngine.Vector4 value);
        /*0x3cc301c*/ UnityEngine.RectTransform get_rectTransform();
        /*0x3cc30c8*/ TMPro.TextMeshPro get_textMeshPro();
        /*0x3cc3174*/ void Awake();
        /*0x3cc323c*/ void OnEnable();
        /*0x3cc3240*/ void OnDisable();
        /*0x3cc2cdc*/ void OnContainerChanged();
        /*0x3cc3398*/ void OnRectTransformDimensionsChange();
        /*0x3cc2f44*/ void SetRect(UnityEngine.Vector2 size);
        /*0x3cc3244*/ void UpdateCorners();
        /*0x3cc2e2c*/ UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor);
        /*0x3cc2be4*/ TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot);
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
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6c8*/ int _SortingLayer;
        /*0x6cc*/ int _SortingLayerID;
        /*0x6d0*/ int _SortingOrder;
        /*0x6d8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6e0*/ bool m_currentAutoSizeMode;
        /*0x6e1*/ bool m_hasFontAssetChanged;
        /*0x6e4*/ float m_previousLossyScaleY;
        /*0x6e8*/ UnityEngine.Renderer m_renderer;
        /*0x6f0*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x6f8*/ bool m_isFirstAllocation;
        /*0x6fc*/ int m_max_characters;
        /*0x700*/ int m_max_numberOfLines;
        /*0x708*/ TMPro.TMP_SubMesh[] m_subTextObjects;
        /*0x710*/ TMPro.MaskingTypes m_maskType;
        /*0x714*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x758*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x760*/ bool m_isRegisteredForEvents;

        static /*0x3cc9d9c*/ TextMeshPro();
        /*0x3cc9cc4*/ TextMeshPro();
        /*0x3cc35d4*/ int get_sortingLayerID();
        /*0x3cc3714*/ void set_sortingLayerID(int value);
        /*0x3cc38d4*/ int get_sortingOrder();
        /*0x3cc3968*/ void set_sortingOrder(int value);
        /*0x3cc3b28*/ bool get_autoSizeTextContainer();
        /*0x3cc3b30*/ void set_autoSizeTextContainer(bool value);
        /*0x3cc3bd0*/ TMPro.TextContainer get_textContainer();
        /*0x3cc3bd8*/ UnityEngine.Transform get_transform();
        /*0x3cc3668*/ UnityEngine.Renderer get_renderer();
        /*0x3cc3c84*/ UnityEngine.Mesh get_mesh();
        /*0x3cc3d44*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x3cc3e6c*/ TMPro.MaskingTypes get_maskType();
        /*0x3cc3e74*/ void set_maskType(TMPro.MaskingTypes value);
        /*0x3cc3fc4*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords);
        /*0x3cc40ac*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, float softnessX, float softnessY);
        /*0x3cc41fc*/ void SetVerticesDirty();
        /*0x3cc42ac*/ void SetLayoutDirty();
        /*0x3cc437c*/ void SetMaterialDirty();
        /*0x3cc438c*/ void SetAllDirty();
        /*0x3cc43d0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x3cc46fc*/ void UpdateMaterial();
        /*0x3cc4830*/ void UpdateMeshPadding();
        /*0x3cc4930*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x3cc4940*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x3cc49ac*/ void ClearMesh(bool updateMesh);
        /*0x3cc4a6c*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3cc4b1c*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3cc4bcc*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x3cc4be4*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x3cc4d84*/ void UpdateVertexData();
        /*0x3cc4f54*/ void UpdateFontAsset();
        /*0x3cc4f64*/ void CalculateLayoutInputHorizontal();
        /*0x3cc4f68*/ void CalculateLayoutInputVertical();
        /*0x3cc4f6c*/ void Awake();
        /*0x3cc53b4*/ void OnEnable();
        /*0x3cc54b0*/ void OnDisable();
        /*0x3cc555c*/ void OnDestroy();
        /*0x3cc5628*/ void LoadFontAsset();
        /*0x3cc5c78*/ void UpdateEnvMapMatrix();
        /*0x3cc3e7c*/ void SetMask(TMPro.MaskingTypes maskType);
        /*0x3cc400c*/ void SetMaskCoordinates(UnityEngine.Vector4 coords);
        /*0x3cc410c*/ void SetMaskCoordinates(UnityEngine.Vector4 coords, float softX, float softY);
        /*0x3cc5ed4*/ void EnableMasking();
        /*0x3cc604c*/ void DisableMasking();
        /*0x3cc5fcc*/ void UpdateMask();
        /*0x3cc620c*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x3cc632c*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x3cc6508*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x3cc654c*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x3cc6704*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x3cc6ab4*/ void SetOutlineThickness(float thickness);
        /*0x3cc6c08*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x3cc6d3c*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x3cc6140*/ void CreateMaterialInstance();
        /*0x3cc6e70*/ void SetShaderDepth();
        /*0x3cc6f70*/ void SetCulling();
        /*0x3cc7230*/ void SetPerspectiveCorrection();
        /*0x3cc72bc*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x3cc9094*/ void ComputeMarginSize();
        /*0x3cc9188*/ void OnDidApplyAnimationProperties();
        /*0x3cc91a4*/ void OnTransformParentChanged();
        /*0x3cc91d4*/ void OnRectTransformDimensionsChange();
        /*0x3cc9328*/ void InternalUpdate();
        /*0x3cc44b8*/ void OnPreRenderObject();
        /*0x3cb1048*/ void GenerateTextMesh();
        /*0x3cc966c*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x3cc9710*/ void SetMeshFilters(bool state);
        /*0x3cc9904*/ void SetActiveSubMeshes(bool state);
        /*0x3cc9534*/ void SetActiveSubTextObjectRenderers(bool state);
        /*0x3cc9a20*/ void DestroySubMeshObjects();
        /*0x3cc37c8*/ void UpdateSubMeshSortingLayerID(int id);
        /*0x3cc3a1c*/ void UpdateSubMeshSortingOrder(int order);
        /*0x3cc9afc*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x3cc93c4*/ void UpdateSDFScale(float scaleDelta);
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
        static /*0x88*/ Unity.Profiling.ProfilerMarker k_SaveProcessingStatesMarker;
        static /*0x90*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIMarker;
        static /*0x98*/ Unity.Profiling.ProfilerMarker k_GenerateTextPhaseIIIMarker;
        /*0x6c8*/ bool m_isRebuildingLayout;
        /*0x6d0*/ UnityEngine.Coroutine m_DelayedGraphicRebuild;
        /*0x6d8*/ UnityEngine.Coroutine m_DelayedMaterialRebuild;
        /*0x6e0*/ UnityEngine.Rect m_ClipRect;
        /*0x6f0*/ bool m_ValidRect;
        /*0x6f8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x700*/ bool m_hasFontAssetChanged;
        /*0x708*/ TMPro.TMP_SubMeshUI[] m_subTextObjects;
        /*0x710*/ float m_previousLossyScaleY;
        /*0x718*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x720*/ UnityEngine.CanvasRenderer m_canvasRenderer;
        /*0x728*/ UnityEngine.Canvas m_canvas;
        /*0x730*/ float m_CanvasScaleFactor;
        /*0x734*/ bool m_isFirstAllocation;
        /*0x738*/ int m_max_characters;
        /*0x740*/ UnityEngine.Material m_baseMaterial;
        /*0x748*/ bool m_isScrollRegionSet;
        /*0x74c*/ UnityEngine.Vector4 m_maskOffset;
        /*0x75c*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x79c*/ bool m_isRegisteredForEvents;
        /*0x7a0*/ TMPro.TMP_GlyphValueRecord _previousGlyphAdjustments;

        static /*0x3cd19bc*/ TextMeshProUGUI();
        /*0x3cd18ec*/ TextMeshProUGUI();
        /*0x3cca2a4*/ UnityEngine.Material get_materialForRendering();
        /*0x3cca304*/ bool get_autoSizeTextContainer();
        /*0x3cca30c*/ void set_autoSizeTextContainer(bool value);
        /*0x3cca3ac*/ UnityEngine.Mesh get_mesh();
        /*0x3cca3b4*/ UnityEngine.CanvasRenderer get_canvasRenderer();
        /*0x3cca460*/ void CalculateLayoutInputHorizontal();
        /*0x3cca464*/ void CalculateLayoutInputVertical();
        /*0x3cca468*/ void SetVerticesDirty();
        /*0x3cca54c*/ void SetLayoutDirty();
        /*0x3cca63c*/ void SetMaterialDirty();
        /*0x3cca728*/ void SetAllDirty();
        /*0x3cca76c*/ System.Collections.IEnumerator DelayedGraphicRebuild();
        /*0x3cca7e0*/ System.Collections.IEnumerator DelayedMaterialRebuild();
        /*0x3cca854*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x3ccabb8*/ void UpdateSubObjectPivot();
        /*0x3ccac94*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x3ccada4*/ void UpdateMaterial();
        /*0x3ccae90*/ UnityEngine.Vector4 get_maskOffset();
        /*0x3ccaea4*/ void set_maskOffset(UnityEngine.Vector4 value);
        /*0x3ccb1f0*/ void RecalculateClipping();
        /*0x3ccb1f8*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x3ccb474*/ void UpdateCulling();
        /*0x3ccb690*/ void UpdateMeshPadding();
        /*0x3ccb790*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x3ccb864*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x3ccb908*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x3ccb9c4*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x3ccbab8*/ void ClearMesh();
        /*0x3ccbbb0*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3ccbc60*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3ccbd10*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x3ccbd88*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x3ccbf6c*/ void UpdateVertexData();
        /*0x3ccc180*/ void UpdateFontAsset();
        /*0x3ccc190*/ void Awake();
        /*0x3ccc5ac*/ void OnEnable();
        /*0x3ccc858*/ void OnDisable();
        /*0x3ccc9fc*/ void OnDestroy();
        /*0x3cccba4*/ void LoadFontAsset();
        /*0x3ccc6e8*/ UnityEngine.Canvas GetCanvas();
        /*0x3ccd150*/ void UpdateEnvMapMatrix();
        /*0x3ccd3ac*/ void EnableMasking();
        /*0x3ccd568*/ void DisableMasking();
        /*0x3ccaed0*/ void UpdateMask();
        /*0x3ccd56c*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x3ccd6c0*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x3ccd8a4*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x3ccd8e8*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x3ccdaa0*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x3ccdedc*/ void SetOutlineThickness(float thickness);
        /*0x3cce0ac*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x3cce1ec*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x3cce32c*/ void SetShaderDepth();
        /*0x3cce458*/ void SetCulling();
        /*0x3cce74c*/ void SetPerspectiveCorrection();
        /*0x3cce7d8*/ void SetMeshArrays(int size);
        /*0x3cce884*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x3cd0bbc*/ void ComputeMarginSize();
        /*0x3cd0cb0*/ void OnDidApplyAnimationProperties();
        /*0x3cd0ce8*/ void OnCanvasHierarchyChanged();
        /*0x3cd0e18*/ void OnTransformParentChanged();
        /*0x3cd0e68*/ void OnRectTransformDimensionsChange();
        /*0x3cd1038*/ void InternalUpdate();
        /*0x3cca93c*/ void OnPreRenderCanvas();
        /*0x3cb8534*/ void GenerateTextMesh();
        /*0x3cd12c8*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x3cd136c*/ void SetActiveSubMeshes(bool state);
        /*0x3cd1488*/ void DestroySubMeshObjects();
        /*0x3cd1564*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x3cd172c*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x3cd10d4*/ void UpdateSDFScale(float scaleDelta);

        class <DelayedGraphicRebuild>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x3cd1ec4*/ <DelayedGraphicRebuild>d__18(int <>1__state);
            /*0x3cd1eec*/ void System.IDisposable.Dispose();
            /*0x3cd1ef0*/ bool MoveNext();
            /*0x3cd1fc4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3cd1fcc*/ void System.Collections.IEnumerator.Reset();
            /*0x3cd2004*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DelayedMaterialRebuild>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x3cd200c*/ <DelayedMaterialRebuild>d__19(int <>1__state);
            /*0x3cd2034*/ void System.IDisposable.Dispose();
            /*0x3cd2038*/ bool MoveNext();
            /*0x3cd2114*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3cd211c*/ void System.Collections.IEnumerator.Reset();
            /*0x3cd2154*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x3cd27ec*/ TMPro_EventManager();
        static /*0x3cd215c*/ void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat);
        static /*0x3cd21f8*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x3cd2294*/ void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x3cd2330*/ void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x3cd23cc*/ void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial);
        static /*0x3cd2464*/ void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged);
        static /*0x3cd24f8*/ void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj);
        static /*0x3cd2578*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        static /*0x3cd25f8*/ void ON_TMP_SETTINGS_CHANGED();
        static /*0x3cd265c*/ void ON_RESOURCES_LOADED();
        static /*0x3cd26c0*/ void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x3cd275c*/ void ON_COMPUTE_DT_EVENT(object Sender, TMPro.Compute_DT_EventArgs e);
    }

    class Compute_DT_EventArgs
    {
        /*0x10*/ TMPro.Compute_DistanceTransform_EventTypes EventType;
        /*0x14*/ float ProgressPercentage;
        /*0x18*/ UnityEngine.Color[] Colors;

        /*0x3cd2b30*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, float progress);
        /*0x3cd2b68*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors);
    }

    class TMPro_ExtensionMethods
    {
        static /*0x3cd2ba0*/ int[] ToIntArray(string text);
        static /*0x3cd2c54*/ string ArrayToString(char[] chars);
        static /*0x3cd2d10*/ string IntToString(int[] unicodes);
        static /*0x3cd2db4*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
        static /*0x3cd2ea0*/ string IntToString(int[] unicodes, int start, int length);
        static /*0x1ffc854*/ int FindInstanceID<T>(System.Collections.Generic.List<T> list, T target);
        static /*0x3cd2fa0*/ bool Compare(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x3cd2fb0*/ bool CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x3cd2fc0*/ bool Compare(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x3cd2fe8*/ bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x3cd300c*/ UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x3cd30f0*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x3cd31d4*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, float tint);
        static /*0x3cd32bc*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
        static /*0x3cd32c8*/ bool Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, int accuracy);
        static /*0x3cd3348*/ bool Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, int accuracy);
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

        static /*0x3cd33ec*/ TMP_Math();
        static /*0x3cd33b0*/ bool Approximately(float a, float b);
        static /*0x3cd33d8*/ int Mod(int a, int b);
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

        /*0x3cd3458*/ VertexGradient(UnityEngine.Color color);
        /*0x3cd347c*/ VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
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

        /*0x3cd34a0*/ void SetLinkID(char[] text, int startIndex, int length);
        /*0x3cd358c*/ string GetLinkText();
        /*0x3cd3660*/ string GetLinkID();
    }

    struct TMP_WordInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int firstCharacterIndex;
        /*0x1c*/ int lastCharacterIndex;
        /*0x20*/ int characterCount;

        /*0x3cd36fc*/ string GetWord();
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

        static /*0x3cd3a04*/ Extents();
        /*0x3cd37d0*/ Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x3cd37dc*/ string ToString();
    }

    struct Mesh_Extents
    {
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        /*0x3cd3a98*/ Mesh_Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x3cd3aa4*/ string ToString();
    }

    struct WordWrapState
    {
        /*0x10*/ int previous_WordBreak;
        /*0x14*/ int total_CharacterCount;
        /*0x18*/ int visible_CharacterCount;
        /*0x1c*/ int visible_SpriteCount;
        /*0x20*/ int visible_LinkCount;
        /*0x24*/ int firstCharacterIndex;
        /*0x28*/ int firstVisibleCharacterIndex;
        /*0x2c*/ int lastCharacterIndex;
        /*0x30*/ int lastVisibleCharIndex;
        /*0x34*/ int lineNumber;
        /*0x38*/ float maxCapHeight;
        /*0x3c*/ float maxAscender;
        /*0x40*/ float maxDescender;
        /*0x44*/ float startOfLineAscender;
        /*0x48*/ float maxLineAscender;
        /*0x4c*/ float maxLineDescender;
        /*0x50*/ float pageAscender;
        /*0x54*/ TMPro.HorizontalAlignmentOptions horizontalAlignment;
        /*0x58*/ float marginLeft;
        /*0x5c*/ float marginRight;
        /*0x60*/ float xAdvance;
        /*0x64*/ float preferredWidth;
        /*0x68*/ float preferredHeight;
        /*0x6c*/ float previousLineScale;
        /*0x70*/ int wordCount;
        /*0x74*/ TMPro.FontStyles fontStyle;
        /*0x78*/ int italicAngle;
        /*0x7c*/ float fontScaleMultiplier;
        /*0x80*/ float currentFontSize;
        /*0x84*/ float baselineOffset;
        /*0x88*/ float lineOffset;
        /*0x8c*/ bool isDrivenLineSpacing;
        /*0x90*/ float glyphHorizontalAdvanceAdjustment;
        /*0x94*/ float cSpace;
        /*0x98*/ float mSpace;
        /*0xa0*/ TMPro.TMP_TextInfo textInfo;
        /*0xa8*/ TMPro.TMP_LineInfo lineInfo;
        /*0x104*/ UnityEngine.Color32 vertexColor;
        /*0x108*/ UnityEngine.Color32 underlineColor;
        /*0x10c*/ UnityEngine.Color32 strikethroughColor;
        /*0x110*/ UnityEngine.Color32 highlightColor;
        /*0x114*/ TMPro.TMP_FontStyleStack basicStyleStack;
        /*0x120*/ TMPro.TMP_TextProcessingStack<int> italicAngleStack;
        /*0x140*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> colorStack;
        /*0x160*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> underlineColorStack;
        /*0x180*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;
        /*0x1a0*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> highlightColorStack;
        /*0x1c0*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> highlightStateStack;
        /*0x1f0*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> colorGradientStack;
        /*0x218*/ TMPro.TMP_TextProcessingStack<float> sizeStack;
        /*0x238*/ TMPro.TMP_TextProcessingStack<float> indentStack;
        /*0x258*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> fontWeightStack;
        /*0x278*/ TMPro.TMP_TextProcessingStack<int> styleStack;
        /*0x298*/ TMPro.TMP_TextProcessingStack<float> baselineStack;
        /*0x2b8*/ TMPro.TMP_TextProcessingStack<int> actionStack;
        /*0x2d8*/ TMPro.TMP_TextProcessingStack<TMPro.MaterialReference> materialReferenceStack;
        /*0x330*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> lineJustificationStack;
        /*0x350*/ int spriteAnimationID;
        /*0x358*/ TMPro.TMP_FontAsset currentFontAsset;
        /*0x360*/ TMPro.TMP_SpriteAsset currentSpriteAsset;
        /*0x368*/ UnityEngine.Material currentMaterial;
        /*0x370*/ int currentMaterialIndex;
        /*0x374*/ TMPro.Extents meshExtents;
        /*0x384*/ bool tagNoParsing;
        /*0x385*/ bool isNonBreakingSpace;
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
        /*0x18*/ int m_InstanceID;
        /*0x1c*/ int hashCode;
        /*0x20*/ UnityEngine.Material material;
        /*0x28*/ int materialHashCode;

        /*0x3cd3cf4*/ TMP_Asset();
        /*0x3cd3ccc*/ int get_instanceID();
    }

    class TMP_Character : TMPro.TMP_TextElement
    {
        /*0x3cd3cfc*/ TMP_Character();
        /*0x3cd3d24*/ TMP_Character(uint unicode, UnityEngine.TextCore.Glyph glyph);
        /*0x3cd3d94*/ TMP_Character(uint unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
        /*0x3cd3e10*/ TMP_Character(uint unicode, uint glyphIndex);
    }

    struct TMP_Vertex
    {
        static /*0x0*/ TMPro.TMP_Vertex k_Zero;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector2 uv;
        /*0x24*/ UnityEngine.Vector2 uv2;
        /*0x2c*/ UnityEngine.Vector2 uv4;
        /*0x34*/ UnityEngine.Color32 color;

        static /*0x3cd3ed4*/ TMP_Vertex();
        static /*0x3cd3e6c*/ TMPro.TMP_Vertex get_zero();
    }

    struct TMP_Offset
    {
        static /*0x0*/ TMPro.TMP_Offset k_ZeroOffset;
        /*0x10*/ float m_Left;
        /*0x14*/ float m_Right;
        /*0x18*/ float m_Top;
        /*0x1c*/ float m_Bottom;

        static /*0x3cd421c*/ TMP_Offset();
        static /*0x3cd3f38*/ TMPro.TMP_Offset get_zero();
        static /*0x3cd3fac*/ bool op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x3cd3fd4*/ bool op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x3cd4084*/ TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, float b);
        /*0x3cd3f94*/ TMP_Offset(float left, float right, float top, float bottom);
        /*0x3cd3fa0*/ TMP_Offset(float horizontal, float vertical);
        /*0x3cd3ed8*/ float get_left();
        /*0x3cd3ee0*/ void set_left(float value);
        /*0x3cd3ee8*/ float get_right();
        /*0x3cd3ef0*/ void set_right(float value);
        /*0x3cd3ef8*/ float get_top();
        /*0x3cd3f00*/ void set_top(float value);
        /*0x3cd3f08*/ float get_bottom();
        /*0x3cd3f10*/ void set_bottom(float value);
        /*0x3cd3f18*/ float get_horizontal();
        /*0x3cd3f20*/ void set_horizontal(float value);
        /*0x3cd3f28*/ float get_vertical();
        /*0x3cd3f30*/ void set_vertical(float value);
        /*0x3cd4098*/ int GetHashCode();
        /*0x3cd40fc*/ bool Equals(object obj);
        /*0x3cd4174*/ bool Equals(TMPro.TMP_Offset other);
    }

    struct HighlightState
    {
        /*0x10*/ UnityEngine.Color32 color;
        /*0x14*/ TMPro.TMP_Offset padding;

        static /*0x3cd4274*/ bool op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        static /*0x3cd4314*/ bool op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        /*0x3cd4264*/ HighlightState(UnityEngine.Color32 color, TMPro.TMP_Offset padding);
        /*0x3cd435c*/ int GetHashCode();
        /*0x3cd43c8*/ bool Equals(object obj);
        /*0x3cd4448*/ bool Equals(TMPro.HighlightState other);
    }

    struct TMP_CharacterInfo
    {
        /*0x10*/ char character;
        /*0x14*/ int index;
        /*0x18*/ int stringLength;
        /*0x1c*/ TMPro.TMP_TextElementType elementType;
        /*0x20*/ TMPro.TMP_TextElement textElement;
        /*0x28*/ TMPro.TMP_FontAsset fontAsset;
        /*0x30*/ TMPro.TMP_SpriteAsset spriteAsset;
        /*0x38*/ int spriteIndex;
        /*0x40*/ UnityEngine.Material material;
        /*0x48*/ int materialReferenceIndex;
        /*0x4c*/ bool isUsingAlternateTypeface;
        /*0x50*/ float pointSize;
        /*0x54*/ int lineNumber;
        /*0x58*/ int pageNumber;
        /*0x5c*/ int vertexIndex;
        /*0x60*/ TMPro.TMP_Vertex vertex_BL;
        /*0x88*/ TMPro.TMP_Vertex vertex_TL;
        /*0xb0*/ TMPro.TMP_Vertex vertex_TR;
        /*0xd8*/ TMPro.TMP_Vertex vertex_BR;
        /*0x100*/ UnityEngine.Vector3 topLeft;
        /*0x10c*/ UnityEngine.Vector3 bottomLeft;
        /*0x118*/ UnityEngine.Vector3 topRight;
        /*0x124*/ UnityEngine.Vector3 bottomRight;
        /*0x130*/ float origin;
        /*0x134*/ float xAdvance;
        /*0x138*/ float ascender;
        /*0x13c*/ float baseLine;
        /*0x140*/ float descender;
        /*0x144*/ float adjustedAscender;
        /*0x148*/ float adjustedDescender;
        /*0x14c*/ float aspectRatio;
        /*0x150*/ float scale;
        /*0x154*/ UnityEngine.Color32 color;
        /*0x158*/ UnityEngine.Color32 underlineColor;
        /*0x15c*/ int underlineVertexIndex;
        /*0x160*/ UnityEngine.Color32 strikethroughColor;
        /*0x164*/ int strikethroughVertexIndex;
        /*0x168*/ UnityEngine.Color32 highlightColor;
        /*0x16c*/ TMPro.HighlightState highlightState;
        /*0x180*/ TMPro.FontStyles style;
        /*0x184*/ bool isVisible;
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

        static /*0x3cd4698*/ TMP_ColorGradient();
        /*0x3cd44ec*/ TMP_ColorGradient();
        /*0x3cd4588*/ TMP_ColorGradient(UnityEngine.Color color);
        /*0x3cd45f4*/ TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    class TMP_Compatibility
    {
        static /*0x3cd46e4*/ TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue);

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
        void TweenValue(float floatPercentage);
        /*0x1f2fe14*/ bool get_ignoreTimeScale();
        /*0x1f30804*/ float get_duration();
        /*0x1f2fe14*/ bool ValidTarget();
    }

    struct ColorTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.ColorTween.ColorTweenCallback m_Target;
        /*0x18*/ UnityEngine.Color m_StartColor;
        /*0x28*/ UnityEngine.Color m_TargetColor;
        /*0x38*/ TMPro.ColorTween.ColorTweenMode m_TweenMode;
        /*0x3c*/ float m_Duration;
        /*0x40*/ bool m_IgnoreTimeScale;

        /*0x3cd4708*/ UnityEngine.Color get_startColor();
        /*0x3cd4714*/ void set_startColor(UnityEngine.Color value);
        /*0x3cd4720*/ UnityEngine.Color get_targetColor();
        /*0x3cd472c*/ void set_targetColor(UnityEngine.Color value);
        /*0x3cd4738*/ TMPro.ColorTween.ColorTweenMode get_tweenMode();
        /*0x3cd4740*/ void set_tweenMode(TMPro.ColorTween.ColorTweenMode value);
        /*0x3cd4748*/ float get_duration();
        /*0x3cd4750*/ void set_duration(float value);
        /*0x3cd4758*/ bool get_ignoreTimeScale();
        /*0x3cd4760*/ void set_ignoreTimeScale(bool value);
        /*0x3cd4768*/ void TweenValue(float floatPercentage);
        /*0x3cd4834*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
        /*0x3cd4910*/ bool GetIgnoreTimescale();
        /*0x3cd4918*/ float GetDuration();
        /*0x3cd4824*/ bool ValidTarget();

        enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2,
        }

        class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
        {
            /*0x3cd48c8*/ ColorTweenCallback();
        }
    }

    struct FloatTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.FloatTween.FloatTweenCallback m_Target;
        /*0x18*/ float m_StartValue;
        /*0x1c*/ float m_TargetValue;
        /*0x20*/ float m_Duration;
        /*0x24*/ bool m_IgnoreTimeScale;

        /*0x3cd4920*/ float get_startValue();
        /*0x3cd4928*/ void set_startValue(float value);
        /*0x3cd4930*/ float get_targetValue();
        /*0x3cd4938*/ void set_targetValue(float value);
        /*0x3cd4940*/ float get_duration();
        /*0x3cd4948*/ void set_duration(float value);
        /*0x3cd4950*/ bool get_ignoreTimeScale();
        /*0x3cd4958*/ void set_ignoreTimeScale(bool value);
        /*0x3cd4960*/ void TweenValue(float floatPercentage);
        /*0x3cd4a04*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
        /*0x3cd4ae0*/ bool GetIgnoreTimescale();
        /*0x3cd4ae8*/ float GetDuration();
        /*0x3cd49f4*/ bool ValidTarget();

        class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
        {
            /*0x3cd4a98*/ FloatTweenCallback();
        }
    }

    class TweenRunner<T>
    {
        /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
        /*0x0*/ System.Collections.IEnumerator m_Tween;

        static /*0x1ffc854*/ System.Collections.IEnumerator Start(T tweenInfo);
        /*0x1f309e4*/ TweenRunner();
        /*0x1f30ebc*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
        /*0x1ffc854*/ void StartTween(T info);
        /*0x1f309e4*/ void StopTween();

        class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T tweenInfo;
            /*0x0*/ float <elapsedTime>5__2;

            /*0x1f30b78*/ <Start>d__2(int <>1__state);
            /*0x1f309e4*/ void System.IDisposable.Dispose();
            /*0x1f2fe14*/ bool MoveNext();
            /*0x1f30214*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
            /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x3cd6c68*/ TMP_DefaultControls();
        static /*0x3cd4af0*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size);
        static /*0x3cd4b98*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent);
        static /*0x3cd4d58*/ void SetDefaultTextValues(TMPro.TMP_Text lbl);
        static /*0x3cd4de0*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
        static /*0x3cd4c58*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
        static /*0x3cd4e40*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
        static /*0x3cd4f24*/ UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x3cd5208*/ UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x3cd54d4*/ UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x3cd5574*/ UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x3cd5bf8*/ UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources);

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
        static /*0x0*/ TMPro.TMP_Dropdown.OptionData s_NoOptionData;
        /*0x100*/ UnityEngine.RectTransform m_Template;
        /*0x108*/ TMPro.TMP_Text m_CaptionText;
        /*0x110*/ UnityEngine.UI.Image m_CaptionImage;
        /*0x118*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x120*/ TMPro.TMP_Text m_ItemText;
        /*0x128*/ UnityEngine.UI.Image m_ItemImage;
        /*0x130*/ int m_Value;
        /*0x138*/ TMPro.TMP_Dropdown.OptionDataList m_Options;
        /*0x140*/ TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;
        /*0x148*/ float m_AlphaFadeSpeed;
        /*0x150*/ UnityEngine.GameObject m_Dropdown;
        /*0x158*/ UnityEngine.GameObject m_Blocker;
        /*0x160*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> m_Items;
        /*0x168*/ TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner;
        /*0x170*/ bool validTemplate;
        /*0x178*/ UnityEngine.Coroutine m_Coroutine;

        static /*0x3cd9b74*/ TMP_Dropdown();
        static /*0x1ffc854*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
        /*0x3cd6fbc*/ TMP_Dropdown();
        /*0x3cd6cf8*/ UnityEngine.RectTransform get_template();
        /*0x3cd69ac*/ void set_template(UnityEngine.RectTransform value);
        /*0x3cd6d00*/ TMPro.TMP_Text get_captionText();
        /*0x3cd69cc*/ void set_captionText(TMPro.TMP_Text value);
        /*0x3cd6d08*/ UnityEngine.UI.Image get_captionImage();
        /*0x3cd6d10*/ void set_captionImage(UnityEngine.UI.Image value);
        /*0x3cd6d30*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x3cd6d38*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x3cd6d58*/ TMPro.TMP_Text get_itemText();
        /*0x3cd69ec*/ void set_itemText(TMPro.TMP_Text value);
        /*0x3cd6d60*/ UnityEngine.UI.Image get_itemImage();
        /*0x3cd6d68*/ void set_itemImage(UnityEngine.UI.Image value);
        /*0x3cd6a0c*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
        /*0x3cd6d88*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        /*0x3cd6db0*/ TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged();
        /*0x3cd6db8*/ void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value);
        /*0x3cd6dc8*/ float get_alphaFadeSpeed();
        /*0x3cd6dd0*/ void set_alphaFadeSpeed(float value);
        /*0x3cd6dd8*/ int get_value();
        /*0x3cd6de0*/ void set_value(int value);
        /*0x3cd6f54*/ void SetValueWithoutNotify(int input);
        /*0x3cd6de8*/ void SetValue(int value, bool sendCallback);
        /*0x3cd6f5c*/ bool get_IsExpanded();
        /*0x3cd71b4*/ void Awake();
        /*0x3cd72b0*/ void Start();
        /*0x3cd7364*/ void OnDisable();
        /*0x3cd6a2c*/ void RefreshShownValue();
        /*0x3cd75f4*/ void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options);
        /*0x3cd765c*/ void AddOptions(System.Collections.Generic.List<string> options);
        /*0x3cd77b0*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
        /*0x3cd7904*/ void ClearOptions();
        /*0x3cd79e4*/ void SetupTemplate();
        /*0x3cd8078*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cd8d0c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3cd8d10*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3cd807c*/ void Show();
        /*0x3cd91fc*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
        /*0x3cd96d4*/ void DestroyBlocker(UnityEngine.GameObject blocker);
        /*0x3cd972c*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
        /*0x3cd9798*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
        /*0x3cd97f0*/ TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate);
        /*0x3cd985c*/ void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item);
        /*0x3cd8e48*/ TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, bool selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items);
        /*0x3cd9860*/ void AlphaFadeList(float duration, float alpha);
        /*0x3cd90f0*/ void AlphaFadeList(float duration, float start, float end);
        /*0x3cd98ec*/ void SetAlpha(float alpha);
        /*0x3cd8d14*/ void Hide();
        /*0x3cd999c*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
        /*0x3cd7404*/ void ImmediateDestroyDropdownList();
        /*0x3cd9a40*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

        class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ TMPro.TMP_Text m_Text;
            /*0x28*/ UnityEngine.UI.Image m_Image;
            /*0x30*/ UnityEngine.RectTransform m_RectTransform;
            /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

            /*0x3cd9d4c*/ DropdownItem();
            /*0x3cd9bf0*/ TMPro.TMP_Text get_text();
            /*0x3cd9bf8*/ void set_text(TMPro.TMP_Text value);
            /*0x3cd9c00*/ UnityEngine.UI.Image get_image();
            /*0x3cd9c08*/ void set_image(UnityEngine.UI.Image value);
            /*0x3cd9c10*/ UnityEngine.RectTransform get_rectTransform();
            /*0x3cd9c18*/ void set_rectTransform(UnityEngine.RectTransform value);
            /*0x3cd9c20*/ UnityEngine.UI.Toggle get_toggle();
            /*0x3cd9c28*/ void set_toggle(UnityEngine.UI.Toggle value);
            /*0x3cd9c30*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x3cd9cac*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class OptionData
        {
            /*0x10*/ string m_Text;
            /*0x18*/ UnityEngine.Sprite m_Image;

            /*0x3cd6a24*/ OptionData();
            /*0x3cd7780*/ OptionData(string text);
            /*0x3cd78d4*/ OptionData(UnityEngine.Sprite image);
            /*0x3cd9d74*/ OptionData(string text, UnityEngine.Sprite image);
            /*0x3cd9d54*/ string get_text();
            /*0x3cd9d5c*/ void set_text(string value);
            /*0x3cd9d64*/ UnityEngine.Sprite get_image();
            /*0x3cd9d6c*/ void set_image(UnityEngine.Sprite value);
        }

        class OptionDataList
        {
            /*0x10*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;

            /*0x3cd70e4*/ OptionDataList();
            /*0x3cd9db8*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
            /*0x3cd9dc0*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        }

        class DropdownEvent : UnityEngine.Events.UnityEvent<int>
        {
            /*0x3cd716c*/ DropdownEvent();
        }

        class <>c__DisplayClass69_0
        {
            /*0x10*/ TMPro.TMP_Dropdown.DropdownItem item;
            /*0x18*/ TMPro.TMP_Dropdown <>4__this;

            /*0x3cd8e40*/ <>c__DisplayClass69_0();
            /*0x3cd9dc8*/ void <Show>b__0(bool x);
        }

        class <DelayedDestroyDropdownList>d__81 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delay;
            /*0x28*/ TMPro.TMP_Dropdown <>4__this;

            /*0x3cd9a18*/ <DelayedDestroyDropdownList>d__81(int <>1__state);
            /*0x3cd9dec*/ void System.IDisposable.Dispose();
            /*0x3cd9df0*/ bool MoveNext();
            /*0x3cd9ea8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3cd9eb0*/ void System.Collections.IEnumerator.Reset();
            /*0x3cd9ee8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_DynamicFontFallback
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> _fallbackFonts;

        static /*0x3cda138*/ TMP_DynamicFontFallback();
        static /*0x3cd9ef0*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_FallbackFonts();
        static /*0x3cd9f48*/ void AddFallbackFont(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cda074*/ void EvictAllFallbackFonts();
    }

    class FontReference
    {
        /*0x10*/ EA.StringInternUtils.NativeMemoryByteArray NativeMemoryFont;
        /*0x18*/ int RefCount;

        /*0x3cda2b0*/ FontReference(string fontPathName);
        /*0x3cda1d0*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(int pointSize);
        /*0x3cda560*/ void AddRef();
        /*0x3cda5e8*/ bool Release();
        /*0x3cda2a0*/ bool IsValid();
    }

    class TMP_DynamicFontLoader
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, TMPro.FontReference> LoadedFonts;

        static /*0x3cdaa18*/ TMP_DynamicFontLoader();
        static /*0x3cda6a8*/ TMPro.FontReference LoadFont(string fontPath);
        static /*0x3cda878*/ void UnloadFont(string fontPath);
        static /*0x3cda820*/ string GetFontName(string fontPath);
    }

    enum AtlasPopulationMode
    {
        Static = 0,
        Dynamic = 1,
    }

    class TMP_FontAsset : TMPro.TMP_Asset
    {
        static string AddressablesRootAssetsPath = "UnityCache";
        static string ExtractedAssetsPath = "ExtractedAssets";
        static /*0x0*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
        static /*0x8*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
        static /*0x10*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
        static /*0x18*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
        static /*0x20*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
        static /*0x28*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
        static /*0x30*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
        static /*0x38*/ string s_DefaultMaterialSuffix;
        static /*0x40*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
        static /*0x48*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
        static /*0x50*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
        static /*0x58*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;
        static /*0x60*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
        static /*0x68*/ uint[] k_GlyphIndexArray;
        /*0x30*/ string m_Version;
        /*0x38*/ string m_SourceFontFileGUID;
        /*0x40*/ string m_editorSourceFontPath;
        /*0x48*/ string m_deviceSourceFontPath;
        /*0x50*/ TMPro.FontReference m_rawSourceFontFile;
        /*0x58*/ TMPro.AtlasPopulationMode m_AtlasPopulationMode;
        /*0x60*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0xc0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
        /*0xd0*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharacterTable;
        /*0xd8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> m_CharacterLookupDictionary;
        /*0xe0*/ UnityEngine.Texture2D m_AtlasTexture;
        /*0xe8*/ UnityEngine.Texture2D[] m_AtlasTextures;
        /*0xf0*/ int m_AtlasTextureIndex;
        /*0xf4*/ bool m_IsMultiAtlasTexturesEnabled;
        /*0xf5*/ bool m_ClearDynamicDataOnBuild;
        /*0xf8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
        /*0x100*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
        /*0x108*/ TMPro.FaceInfo_Legacy m_fontInfo;
        /*0x110*/ UnityEngine.Texture2D atlas;
        /*0x118*/ int m_AtlasWidth;
        /*0x11c*/ int m_AtlasHeight;
        /*0x120*/ int m_AtlasPadding;
        /*0x124*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
        /*0x128*/ System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList;
        /*0x130*/ TMPro.KerningTable m_KerningTable;
        /*0x138*/ TMPro.TMP_FontFeatureTable m_FontFeatureTable;
        /*0x140*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets;
        /*0x148*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_FallbackFontAssetTable;
        /*0x150*/ TMPro.FontAssetCreationSettings m_CreationSettings;
        /*0x1a8*/ TMPro.TMP_FontWeightPair[] m_FontWeightTable;
        /*0x1b0*/ TMPro.TMP_FontWeightPair[] fontWeights;
        /*0x1b8*/ float normalStyle;
        /*0x1bc*/ float normalSpacingOffset;
        /*0x1c0*/ float boldStyle;
        /*0x1c4*/ float boldSpacing;
        /*0x1c8*/ byte italicStyle;
        /*0x1c9*/ byte tabSize;
        /*0x1ca*/ bool IsFontAssetLookupTablesDirty;
        /*0x1d0*/ System.Collections.Generic.HashSet<int> FallbackSearchQueryLookup;
        /*0x1d8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
        /*0x1e0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
        /*0x1e8*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
        /*0x1f0*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
        /*0x1f8*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
        /*0x200*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
        /*0x208*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharactersToAdd;
        /*0x210*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
        /*0x218*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
        /*0x220*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

        static /*0x3ce2f48*/ TMP_FontAsset();
        static /*0x3cdb338*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font);
        static /*0x3cdb3b4*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x3cdf3dc*/ string GetCharacters(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cdf4d0*/ int[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cdf6ac*/ void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cdf7a0*/ void UpdateFontFeaturesForFontAssetsInQueue();
        static /*0x3cdfc6c*/ void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x3cdfd60*/ void UpdateAtlasTexturesForFontAssetsInQueue();
        /*0x3ce2b00*/ TMP_FontAsset();
        /*0x3cdaab0*/ string get_version();
        /*0x3cdaab8*/ void set_version(string value);
        /*0x3cdaac0*/ void set_sourceFontFile(UnityEngine.Font value);
        /*0x3cdaac4*/ void set_sourceFontFilePath(string value);
        /*0x3cdab68*/ string get_sourceFontFilePath();
        /*0x3cdac8c*/ bool get_m_isFontLoaded();
        /*0x3cdacac*/ TMPro.FontReference get_rawSourceFontFile();
        /*0x3cdad40*/ void set_rawSourceFontFile(TMPro.FontReference value);
        /*0x3cdade4*/ TMPro.AtlasPopulationMode get_atlasPopulationMode();
        /*0x3cdadec*/ void set_atlasPopulationMode(TMPro.AtlasPopulationMode value);
        /*0x3cdadf4*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x3cdae04*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x3cdae28*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
        /*0x3cdae30*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
        /*0x3cdae38*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
        /*0x3cdb090*/ System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable();
        /*0x3cdb098*/ void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value);
        /*0x3cdb0a0*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> get_characterLookupTable();
        /*0x3cdb0c4*/ UnityEngine.Texture2D get_atlasTexture();
        /*0x3cdb15c*/ UnityEngine.Texture2D[] get_atlasTextures();
        /*0x3cdb164*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
        /*0x3cdb16c*/ int get_atlasTextureCount();
        /*0x3cdb178*/ bool get_isMultiAtlasTexturesEnabled();
        /*0x3cdb180*/ void set_isMultiAtlasTexturesEnabled(bool value);
        /*0x3cdb188*/ bool get_clearDynamicDataOnBuild();
        /*0x3cdb190*/ void set_clearDynamicDataOnBuild(bool value);
        /*0x3cdb198*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
        /*0x3cdb1a0*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x3cdb1a8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
        /*0x3cdb1b0*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x3cdb1c0*/ TMPro.FaceInfo_Legacy get_fontInfo();
        /*0x3cdb1c8*/ int get_atlasWidth();
        /*0x3cdb1d0*/ void set_atlasWidth(int value);
        /*0x3cdb1d8*/ int get_atlasHeight();
        /*0x3cdb1e0*/ void set_atlasHeight(int value);
        /*0x3cdb1e8*/ int get_atlasPadding();
        /*0x3cdb1f0*/ void set_atlasPadding(int value);
        /*0x3cdb1f8*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
        /*0x3cdb200*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
        /*0x3cdb208*/ TMPro.TMP_FontFeatureTable get_fontFeatureTable();
        /*0x3cdb210*/ void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value);
        /*0x3cdb220*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable();
        /*0x3cdb228*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        /*0x3cdb2ec*/ TMPro.FontAssetCreationSettings get_creationSettings();
        /*0x3cdb2fc*/ void set_creationSettings(TMPro.FontAssetCreationSettings value);
        /*0x3cdb320*/ TMPro.TMP_FontWeightPair[] get_fontWeightTable();
        /*0x3cdb328*/ void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value);
        /*0x3cdb8d4*/ void Awake();
        /*0x3cdae5c*/ void ReadFontAssetDefinition();
        /*0x3cdc470*/ void InitializeDictionaryLookupTables();
        /*0x3cdc798*/ void InitializeGlyphLookupDictionary();
        /*0x3cdcaa8*/ void InitializeCharacterLookupDictionary();
        /*0x3cdcd00*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
        /*0x3cdc490*/ void AddSynthesizedCharactersAndFaceMetrics();
        /*0x3cdd974*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
        /*0x3cddbc4*/ void AddCharacterToLookupCache(uint unicode, TMPro.TMP_Character character);
        /*0x3cdd7b8*/ bool LoadDynamicFontFace();
        /*0x3cddc88*/ void UnloadDynamicFontFace();
        /*0x3cddca8*/ void SortCharacterTable();
        /*0x3cdddfc*/ void SortGlyphTable();
        /*0x3cddf50*/ void SortFontFeatureTable();
        /*0x3cddf68*/ void SortAllTables();
        /*0x3cddf94*/ bool HasCharacter(int character);
        /*0x3cddffc*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
        /*0x3cdeb54*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
        /*0x3cdec48*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
        /*0x3cdedd0*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
        /*0x3cdf310*/ bool HasCharacters(string text);
        /*0x3cdf5bc*/ uint GetGlyphIndex(uint unicode);
        /*0x3cdfef4*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
        /*0x3cdff10*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
        /*0x3ce0d74*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
        /*0x3ce0d90*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
        /*0x3cde3f0*/ bool TryAddCharacterInternal(uint unicode, ref TMPro.TMP_Character character);
        /*0x3ce1a80*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref TMPro.TMP_Character character);
        /*0x3cdfef0*/ void TryAddGlyphsToAtlasTextures();
        /*0x3ce09c8*/ bool TryAddGlyphsToNewAtlasTexture();
        /*0x3ce1810*/ void SetupNewAtlasTexture();
        /*0x3ce1ea0*/ void UpdateAtlasTexture();
        /*0x3cdf934*/ void UpdateGlyphAdjustmentRecords();
        /*0x3ce2018*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
        /*0x3ce22dc*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
        /*0x3ce22e0*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
        /*0x1f30ff0*/ void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
        /*0x3ce22e4*/ void ClearFontAssetData(bool setAtlasSizeToZero);
        /*0x3ce29c0*/ void ClearFontAssetDataInternal();
        /*0x3ce29dc*/ void UpdateFontAssetData();
        /*0x3ce2314*/ void ClearFontAssetTables();
        /*0x3ce2660*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
        /*0x3cdb95c*/ void UpgradeFontAsset();
        /*0x3cdd420*/ void UpgradeGlyphAdjustmentTableToFontFeatureTable();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Character, uint> <>9__137_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__138_0;

            static /*0x3ce3254*/ <>c();
            /*0x3ce32bc*/ <>c();
            /*0x3ce32c4*/ uint <SortCharacterTable>b__137_0(TMPro.TMP_Character c);
            /*0x3ce32d8*/ uint <SortGlyphTable>b__138_0(UnityEngine.TextCore.Glyph c);
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

        /*0x3ce32f0*/ FaceInfo_Legacy();
    }

    class TMP_Glyph : TMPro.TMP_TextElement_Legacy
    {
        static /*0x3ce32f8*/ TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source);
        /*0x3ce3374*/ TMP_Glyph();
    }

    struct FontAssetCreationSettings
    {
        /*0x10*/ string sourceFontFileName;
        /*0x18*/ string sourceFontFileGUID;
        /*0x20*/ int pointSizeSamplingMode;
        /*0x24*/ int pointSize;
        /*0x28*/ int padding;
        /*0x2c*/ int packingMode;
        /*0x30*/ int atlasWidth;
        /*0x34*/ int atlasHeight;
        /*0x38*/ int characterSetSelectionMode;
        /*0x40*/ string characterSequence;
        /*0x48*/ string referencedFontAssetGUID;
        /*0x50*/ string referencedTextAssetGUID;
        /*0x58*/ int fontStyle;
        /*0x5c*/ float fontStyleModifier;
        /*0x60*/ int renderMode;
        /*0x64*/ bool includeFontFeatures;

        /*0x3ce337c*/ FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode);
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

        /*0x3ce346c*/ KerningPairKey(uint ascii_left, uint ascii_right);
    }

    struct GlyphValueRecord_Legacy
    {
        /*0x10*/ float xPlacement;
        /*0x14*/ float yPlacement;
        /*0x18*/ float xAdvance;
        /*0x1c*/ float yAdvance;

        static /*0x3ce34dc*/ TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b);
        /*0x3ce347c*/ GlyphValueRecord_Legacy(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
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

        static /*0x3ce3620*/ KerningPair();
        /*0x3ce3530*/ KerningPair();
        /*0x3ce3554*/ KerningPair(uint left, uint right, float offset);
        /*0x3ce3594*/ KerningPair(uint firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments);
        /*0x3ce34f0*/ uint get_firstGlyph();
        /*0x3ce34f8*/ void set_firstGlyph(uint value);
        /*0x3ce3500*/ TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments();
        /*0x3ce350c*/ uint get_secondGlyph();
        /*0x3ce3514*/ void set_secondGlyph(uint value);
        /*0x3ce351c*/ TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments();
        /*0x3ce3528*/ bool get_ignoreSpacingAdjustments();
        /*0x3ce3614*/ void ConvertLegacyKerningData();
    }

    class KerningTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;

        /*0x3ce2ec0*/ KerningTable();
        /*0x3ce3694*/ void AddKerningPair();
        /*0x3ce3804*/ int AddKerningPair(uint first, uint second, float offset);
        /*0x3ce3978*/ int AddGlyphPairAdjustmentRecord(uint first, TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, TMPro.GlyphValueRecord_Legacy secondAdjustments);
        /*0x3ce3b2c*/ void RemoveKerningPair(int left, int right);
        /*0x3ce3c5c*/ void RemoveKerningPair(int index);
        /*0x3ce3cb4*/ void SortKerningPairs();

        class <>c
        {
            static /*0x0*/ TMPro.KerningTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.KerningPair, uint> <>9__7_0;
            static /*0x10*/ System.Func<TMPro.KerningPair, uint> <>9__7_1;

            static /*0x3ce3ecc*/ <>c();
            /*0x3ce3f34*/ <>c();
            /*0x3ce3f3c*/ uint <SortKerningPairs>b__7_0(TMPro.KerningPair s);
            /*0x3ce3f50*/ uint <SortKerningPairs>b__7_1(TMPro.KerningPair s);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x3ce3970*/ <>c__DisplayClass3_0();
            /*0x3ce3f64*/ bool <AddKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x3ce3b24*/ <>c__DisplayClass4_0();
            /*0x3ce3f9c*/ bool <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ int left;
            /*0x14*/ int right;

            /*0x3ce3c54*/ <>c__DisplayClass5_0();
            /*0x3ce3fd4*/ bool <RemoveKerningPair>b__0(TMPro.KerningPair item);
        }
    }

    class TMP_FontUtilities
    {
        static /*0x0*/ System.Collections.Generic.List<int> k_searchedFontAssets;

        static /*0x3ce400c*/ TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x3ce4264*/ TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
        static /*0x3ce4144*/ TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x3ce4268*/ TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
    }

    class TMP_FontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_FontAssetUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;
        static /*0x10*/ bool k_IsFontEngineInitialized;

        static /*0x3ce4374*/ TMP_FontAssetUtilities();
        static /*0x3ce43e4*/ TMPro.TMP_FontAssetUtilities get_instance();
        static /*0x3ce443c*/ TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x3ce4590*/ TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x3ce4824*/ TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x3ce4a94*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x3ce4db8*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x3ce4fa4*/ UnityEngine.TextCore.Glyph GetGlyphFromFontAsset(ushort glyphId, TMPro.TMP_FontAsset sourceFontAsset);
        /*0x3ce43dc*/ TMP_FontAssetUtilities();
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

        static /*0x3ce50f0*/ TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b);
        /*0x3ce5078*/ TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
        /*0x3ce5084*/ TMP_GlyphValueRecord(TMPro.GlyphValueRecord_Legacy valueRecord);
        /*0x3ce5090*/ TMP_GlyphValueRecord(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
        /*0x3ce5038*/ float get_xPlacement();
        /*0x3ce5040*/ void set_xPlacement(float value);
        /*0x3ce5048*/ float get_yPlacement();
        /*0x3ce5050*/ void set_yPlacement(float value);
        /*0x3ce5058*/ float get_xAdvance();
        /*0x3ce5060*/ void set_xAdvance(float value);
        /*0x3ce5068*/ float get_yAdvance();
        /*0x3ce5070*/ void set_yAdvance(float value);
    }

    struct TMP_GlyphAdjustmentRecord
    {
        /*0x10*/ uint m_GlyphIndex;
        /*0x14*/ TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

        /*0x3ce512c*/ TMP_GlyphAdjustmentRecord(uint glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord);
        /*0x3ce513c*/ TMP_GlyphAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord);
        /*0x3ce5104*/ uint get_glyphIndex();
        /*0x3ce510c*/ void set_glyphIndex(uint value);
        /*0x3ce5114*/ TMPro.TMP_GlyphValueRecord get_glyphValueRecord();
        /*0x3ce5120*/ void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value);
    }

    class TMP_GlyphPairAdjustmentRecord
    {
        /*0x10*/ TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;
        /*0x24*/ TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;
        /*0x38*/ TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

        /*0x3ce51f0*/ TMP_GlyphPairAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord);
        /*0x3ce5238*/ TMP_GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord);
        /*0x3ce5190*/ TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord();
        /*0x3ce51a4*/ void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x3ce51b8*/ TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord();
        /*0x3ce51cc*/ void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x3ce51e0*/ TMPro.FontFeatureLookupFlags get_featureLookupFlags();
        /*0x3ce51e8*/ void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value);
    }

    struct GlyphPairKey
    {
        /*0x10*/ uint firstGlyphIndex;
        /*0x14*/ uint secondGlyphIndex;
        /*0x18*/ uint key;

        /*0x3ce52ec*/ GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex);
        /*0x3ce52fc*/ GlyphPairKey(TMPro.TMP_GlyphPairAdjustmentRecord record);
    }

    interface ISubstitutionLookup
    {
        /*0x1f30ebc*/ void Initialize(TMPro.TMP_FontAsset fontAsset);
        void DoSubstitution(ref TMPro.TMP_Text.UnicodeChar[] text, ref TMPro.TMP_CharacterInfo[] characterInfo, int position, ref int characterCount);
    }

    struct GlyphArray
    {
        /*0x10*/ ushort[] _glyphs;

        /*0x3ce5328*/ GlyphArray(ushort[] glyphs);
        /*0x3ce5320*/ ushort[] get_Glyphs();
    }

    class TMP_FontFeatureTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        /*0x18*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;
        /*0x20*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_MarkToBaseAdjustmentRecords;
        /*0x28*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_GlyphPairAdjustmentRecord> m_MarkToBaseLookupDictionary;
        /*0x30*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_MarkToMarkAdjustmentRecords;
        /*0x38*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_GlyphPairAdjustmentRecord> m_MarkToMarkLookupDictionary;
        /*0x40*/ System.Collections.Generic.List<TMPro.SingleSubstitution> m_SingleSubstitutions;
        /*0x48*/ System.Collections.Generic.List<TMPro.MultipleSubstitution> m_MultipleSubstitutions;
        /*0x50*/ System.Collections.Generic.List<TMPro.LigatureSubstitution> m_LigatureSubstitutions;
        /*0x58*/ System.Collections.Generic.List<TMPro.ChainingContextualSubstitution> m_ChainingContextualSubstitutions;
        /*0x60*/ float m_unitsPerEm;
        /*0x68*/ System.Collections.Generic.List<ushort> CcmpFeature;
        /*0x70*/ System.Collections.Generic.Dictionary<ushort, TMPro.ISubstitutionLookup> SubstitutionLookups;

        /*0x3ce5380*/ TMP_FontFeatureTable();
        /*0x3ce5330*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
        /*0x3ce5338*/ void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value);
        /*0x3ce5340*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_MarkToBaseAdjustmentRecords();
        /*0x3ce5348*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_MarkToMarkAdjustmentRecords();
        /*0x3ce5350*/ System.Collections.Generic.List<TMPro.SingleSubstitution> get_SingleSubstitutions();
        /*0x3ce5358*/ System.Collections.Generic.List<TMPro.MultipleSubstitution> get_MultipleSubstitutions();
        /*0x3ce5360*/ System.Collections.Generic.List<TMPro.LigatureSubstitution> get_LigatureSubstitutions();
        /*0x3ce5368*/ System.Collections.Generic.List<TMPro.ChainingContextualSubstitution> get_ChainingContextualSubstitutions();
        /*0x3ce5370*/ float get_UnitsPerEm();
        /*0x3ce5378*/ void set_UnitsPerEm(float value);
        /*0x3ce56d0*/ void SortGlyphPairAdjustmentRecords();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontFeatureTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_0;
            static /*0x10*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_1;
            static /*0x18*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_2;
            static /*0x20*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_3;
            static /*0x28*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_4;
            static /*0x30*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__32_5;

            static /*0x3ce5bbc*/ <>c();
            /*0x3ce5c24*/ <>c();
            /*0x3ce5c2c*/ uint <SortGlyphPairAdjustmentRecords>b__32_0(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x3ce5c40*/ uint <SortGlyphPairAdjustmentRecords>b__32_1(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x3ce5c54*/ uint <SortGlyphPairAdjustmentRecords>b__32_2(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x3ce5c68*/ uint <SortGlyphPairAdjustmentRecords>b__32_3(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x3ce5c7c*/ uint <SortGlyphPairAdjustmentRecords>b__32_4(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x3ce5c90*/ uint <SortGlyphPairAdjustmentRecords>b__32_5(TMPro.TMP_GlyphPairAdjustmentRecord s);
        }
    }

    class TMP_InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.EventSystems.IScrollHandler
    {
        static float kHScrollSpeed = 0.05000000074505806;
        static float kVScrollSpeed = 0.10000000149011612;
        static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        static /*0x0*/ char[] kSeparators;
        /*0x100*/ UnityEngine.TouchScreenKeyboard m_SoftKeyboard;
        /*0x108*/ UnityEngine.RectTransform m_RectTransform;
        /*0x110*/ UnityEngine.RectTransform m_TextViewport;
        /*0x118*/ UnityEngine.UI.RectMask2D m_TextComponentRectMask;
        /*0x120*/ UnityEngine.UI.RectMask2D m_TextViewportRectMask;
        /*0x128*/ UnityEngine.Rect m_CachedViewportRect;
        /*0x138*/ TMPro.TMP_Text m_TextComponent;
        /*0x140*/ UnityEngine.RectTransform m_TextComponentRectTransform;
        /*0x148*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x150*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        /*0x158*/ TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        /*0x160*/ bool m_IsDrivenByLayoutComponents;
        /*0x168*/ UnityEngine.UI.LayoutGroup m_LayoutGroup;
        /*0x170*/ UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;
        /*0x178*/ float m_ScrollPosition;
        /*0x17c*/ float m_ScrollSensitivity;
        /*0x180*/ TMPro.TMP_InputField.ContentType m_ContentType;
        /*0x184*/ TMPro.TMP_InputField.InputType m_InputType;
        /*0x188*/ char m_AsteriskChar;
        /*0x18c*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        /*0x190*/ TMPro.TMP_InputField.LineType m_LineType;
        /*0x194*/ bool m_HideMobileInput;
        /*0x195*/ bool m_HideSoftKeyboard;
        /*0x198*/ TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;
        /*0x1a0*/ string m_RegexValue;
        /*0x1a8*/ float m_GlobalPointSize;
        /*0x1ac*/ int m_CharacterLimit;
        /*0x1b0*/ TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;
        /*0x1b8*/ TMPro.TMP_InputField.SubmitEvent m_OnSubmit;
        /*0x1c0*/ TMPro.TMP_InputField.SelectionEvent m_OnSelect;
        /*0x1c8*/ TMPro.TMP_InputField.SelectionEvent m_OnDeselect;
        /*0x1d0*/ TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;
        /*0x1d8*/ TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;
        /*0x1e0*/ TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;
        /*0x1e8*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;
        /*0x1f0*/ TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;
        /*0x1f8*/ UnityEngine.Color m_CaretColor;
        /*0x208*/ bool m_CustomCaretColor;
        /*0x20c*/ UnityEngine.Color m_SelectionColor;
        /*0x220*/ string m_Text;
        /*0x228*/ float m_CaretBlinkRate;
        /*0x22c*/ int m_CaretWidth;
        /*0x230*/ bool m_ReadOnly;
        /*0x231*/ bool m_RichText;
        /*0x234*/ int m_StringPosition;
        /*0x238*/ int m_StringSelectPosition;
        /*0x23c*/ int m_CaretPosition;
        /*0x240*/ int m_CaretSelectPosition;
        /*0x248*/ UnityEngine.RectTransform caretRectTrans;
        /*0x250*/ UnityEngine.UIVertex[] m_CursorVerts;
        /*0x258*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
        /*0x260*/ UnityEngine.Vector2 m_LastPosition;
        /*0x268*/ UnityEngine.Mesh m_Mesh;
        /*0x270*/ bool m_AllowInput;
        /*0x271*/ bool m_ShouldActivateNextUpdate;
        /*0x272*/ bool m_UpdateDrag;
        /*0x273*/ bool m_DragPositionOutOfBounds;
        /*0x274*/ bool m_CaretVisible;
        /*0x278*/ UnityEngine.Coroutine m_BlinkCoroutine;
        /*0x280*/ float m_BlinkStartTime;
        /*0x288*/ UnityEngine.Coroutine m_DragCoroutine;
        /*0x290*/ string m_OriginalText;
        /*0x298*/ bool m_WasCanceled;
        /*0x299*/ bool m_HasDoneFocusTransition;
        /*0x2a0*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        /*0x2a8*/ bool m_PreventCallback;
        /*0x2a9*/ bool m_TouchKeyboardAllowsInPlaceEditing;
        /*0x2aa*/ bool m_IsTextComponentUpdateRequired;
        /*0x2ab*/ bool m_isLastKeyBackspace;
        /*0x2ac*/ float m_PointerDownClickStartTime;
        /*0x2b0*/ float m_KeyDownStartTime;
        /*0x2b4*/ float m_DoubleClickDelay;
        /*0x2b8*/ bool m_IsCompositionActive;
        /*0x2b9*/ bool m_ShouldUpdateIMEWindowPosition;
        /*0x2bc*/ int m_PreviousIMEInsertionLine;
        /*0x2c0*/ TMPro.TMP_FontAsset m_GlobalFontAsset;
        /*0x2c8*/ bool m_OnFocusSelectAll;
        /*0x2c9*/ bool m_isSelectAll;
        /*0x2ca*/ bool m_ResetOnDeActivation;
        /*0x2cb*/ bool m_SelectionStillActive;
        /*0x2cc*/ bool m_ReleaseSelection;
        /*0x2d0*/ UnityEngine.GameObject m_PreviouslySelectedObject;
        /*0x2d8*/ bool m_RestoreOriginalTextOnEscape;
        /*0x2d9*/ bool m_isRichTextEditingAllowed;
        /*0x2dc*/ int m_LineLimit;
        /*0x2e0*/ TMPro.TMP_InputValidator m_InputValidator;
        /*0x2e8*/ bool m_isSelected;
        /*0x2e9*/ bool m_IsStringPositionDirty;
        /*0x2ea*/ bool m_IsCaretPositionDirty;
        /*0x2eb*/ bool m_forceRectTransformAdjustment;
        /*0x2f0*/ UnityEngine.Event m_ProcessingEvent;

        static /*0x3cf1174*/ TMP_InputField();
        static /*0x3cea1cc*/ string get_clipboard();
        static /*0x3cea21c*/ void set_clipboard(string value);
        /*0x3ce5e74*/ TMP_InputField();
        /*0x3ce5ca4*/ UnityEngine.EventSystems.BaseInput get_inputSystem();
        /*0x3ce5db4*/ string get_compositionString();
        /*0x3ce5e48*/ int get_compositionLength();
        /*0x3ce634c*/ UnityEngine.Mesh get_mesh();
        /*0x3ce63f4*/ bool get_shouldHideMobileInput();
        /*0x3ce647c*/ void set_shouldHideMobileInput(bool value);
        /*0x3ce6538*/ bool get_shouldHideSoftKeyboard();
        /*0x3ce660c*/ void set_shouldHideSoftKeyboard(bool value);
        /*0x3ce6760*/ bool isKeyboardUsingEvents();
        /*0x3ce67e0*/ string get_text();
        /*0x3ce67e8*/ void set_text(string value);
        /*0x3ce6924*/ void SetTextWithoutNotify(string input);
        /*0x3ce67f0*/ void SetText(string value, bool sendCallback);
        /*0x3ce6e10*/ bool get_isFocused();
        /*0x3ce6e18*/ float get_caretBlinkRate();
        /*0x3ce6e20*/ void set_caretBlinkRate(float value);
        /*0x3ce6ef4*/ int get_caretWidth();
        /*0x3ce6efc*/ void set_caretWidth(int value);
        /*0x3ce6fc0*/ UnityEngine.RectTransform get_textViewport();
        /*0x3ce6fc8*/ void set_textViewport(UnityEngine.RectTransform value);
        /*0x3ce7020*/ TMPro.TMP_Text get_textComponent();
        /*0x3ce7028*/ void set_textComponent(TMPro.TMP_Text value);
        /*0x3ce709c*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x3ce70a4*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x3ce70fc*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
        /*0x3ce7104*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
        /*0x3ce72a8*/ float get_scrollSensitivity();
        /*0x3ce72b0*/ void set_scrollSensitivity(float value);
        /*0x3ce731c*/ UnityEngine.Color get_caretColor();
        /*0x3ce7360*/ void set_caretColor(UnityEngine.Color value);
        /*0x3ce73f4*/ bool get_customCaretColor();
        /*0x3ce73fc*/ void set_customCaretColor(bool value);
        /*0x3ce7418*/ UnityEngine.Color get_selectionColor();
        /*0x3ce742c*/ void set_selectionColor(UnityEngine.Color value);
        /*0x3ce7474*/ TMPro.TMP_InputField.SubmitEvent get_onEndEdit();
        /*0x3ce747c*/ void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x3ce74d4*/ TMPro.TMP_InputField.SubmitEvent get_onSubmit();
        /*0x3ce74dc*/ void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x3ce7534*/ TMPro.TMP_InputField.SelectionEvent get_onSelect();
        /*0x3ce753c*/ void set_onSelect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x3ce7594*/ TMPro.TMP_InputField.SelectionEvent get_onDeselect();
        /*0x3ce759c*/ void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x3ce75f4*/ TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection();
        /*0x3ce75fc*/ void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x3ce7654*/ TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection();
        /*0x3ce765c*/ void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x3ce76b4*/ TMPro.TMP_InputField.OnChangeEvent get_onValueChanged();
        /*0x3ce76bc*/ void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value);
        /*0x3ce7714*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged();
        /*0x3ce771c*/ void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value);
        /*0x3ce7774*/ TMPro.TMP_InputField.OnValidateInput get_onValidateInput();
        /*0x3ce777c*/ void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value);
        /*0x3ce77d4*/ int get_characterLimit();
        /*0x3ce77dc*/ void set_characterLimit(int value);
        /*0x3ce7890*/ float get_pointSize();
        /*0x3ce7898*/ void set_pointSize(float value);
        /*0x3ce7a2c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x3ce7a34*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x3ce7b94*/ bool get_onFocusSelectAll();
        /*0x3ce7b9c*/ void set_onFocusSelectAll(bool value);
        /*0x3ce7ba4*/ bool get_resetOnDeActivation();
        /*0x3ce7bac*/ void set_resetOnDeActivation(bool value);
        /*0x3ce7bb4*/ bool get_restoreOriginalTextOnEscape();
        /*0x3ce7bbc*/ void set_restoreOriginalTextOnEscape(bool value);
        /*0x3ce7bc4*/ bool get_isRichTextEditingAllowed();
        /*0x3ce7bcc*/ void set_isRichTextEditingAllowed(bool value);
        /*0x3ce7bd4*/ TMPro.TMP_InputField.ContentType get_contentType();
        /*0x3ce7bdc*/ void set_contentType(TMPro.TMP_InputField.ContentType value);
        /*0x3ce7d50*/ TMPro.TMP_InputField.LineType get_lineType();
        /*0x3ce7d58*/ void set_lineType(TMPro.TMP_InputField.LineType value);
        /*0x3ce7e78*/ int get_lineLimit();
        /*0x3ce7e80*/ void set_lineLimit(int value);
        /*0x3ce7ef4*/ TMPro.TMP_InputField.InputType get_inputType();
        /*0x3ce7efc*/ void set_inputType(TMPro.TMP_InputField.InputType value);
        /*0x3ce7f90*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
        /*0x3ce7f98*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
        /*0x3ce8014*/ TMPro.TMP_InputField.CharacterValidation get_characterValidation();
        /*0x3ce801c*/ void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value);
        /*0x3ce8098*/ TMPro.TMP_InputValidator get_inputValidator();
        /*0x3ce80a0*/ void set_inputValidator(TMPro.TMP_InputValidator value);
        /*0x3ce813c*/ bool get_readOnly();
        /*0x3ce8144*/ void set_readOnly(bool value);
        /*0x3ce814c*/ bool get_richText();
        /*0x3ce8154*/ void set_richText(bool value);
        /*0x3ce81e4*/ bool get_multiLine();
        /*0x3ce81f8*/ char get_asteriskChar();
        /*0x3ce8200*/ void set_asteriskChar(char value);
        /*0x3ce826c*/ bool get_wasCanceled();
        /*0x3ce8274*/ void ClampStringPos(ref int pos);
        /*0x3ce82a8*/ void ClampCaretPos(ref int pos);
        /*0x3ce82ec*/ int get_caretPositionInternal();
        /*0x3ce8304*/ void set_caretPositionInternal(int value);
        /*0x3ce8314*/ int get_stringPositionInternal();
        /*0x3ce832c*/ void set_stringPositionInternal(int value);
        /*0x3ce8360*/ int get_caretSelectPositionInternal();
        /*0x3ce8378*/ void set_caretSelectPositionInternal(int value);
        /*0x3ce8388*/ int get_stringSelectPositionInternal();
        /*0x3ce83a0*/ void set_stringSelectPositionInternal(int value);
        /*0x3ce83d4*/ bool get_hasSelection();
        /*0x3ce8410*/ int get_caretPosition();
        /*0x3ce8428*/ void set_caretPosition(int value);
        /*0x3ce84d4*/ int get_selectionAnchorPosition();
        /*0x3ce845c*/ void set_selectionAnchorPosition(int value);
        /*0x3ce84ec*/ int get_selectionFocusPosition();
        /*0x3ce8498*/ void set_selectionFocusPosition(int value);
        /*0x3ce8504*/ int get_stringPosition();
        /*0x3ce851c*/ void set_stringPosition(int value);
        /*0x3ce8600*/ int get_selectionStringAnchorPosition();
        /*0x3ce8550*/ void set_selectionStringAnchorPosition(int value);
        /*0x3ce8618*/ int get_selectionStringFocusPosition();
        /*0x3ce85a8*/ void set_selectionStringFocusPosition(int value);
        /*0x3ce8630*/ void OnEnable();
        /*0x3ce930c*/ void OnDisable();
        /*0x3ce9810*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        /*0x3ce9a90*/ System.Collections.IEnumerator CaretBlink();
        /*0x3ce9b24*/ void SetCaretVisible();
        /*0x3ce6e94*/ void SetCaretActive();
        /*0x3ce9b58*/ void OnFocus();
        /*0x3ce9b68*/ void SelectAll();
        /*0x3ce9ba8*/ void MoveTextEnd(bool shift);
        /*0x3ce9d5c*/ void MoveTextStart(bool shift);
        /*0x3ce9eb0*/ void MoveToEndOfLine(bool shift, bool ctrl);
        /*0x3cea03c*/ void MoveToStartOfLine(bool shift, bool ctrl);
        /*0x3cea274*/ bool InPlaceEditing();
        /*0x3cea378*/ void UpdateStringPositionFromKeyboard();
        /*0x3cea4c4*/ void LateUpdate();
        /*0x3ceb830*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3ceb908*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3ceb928*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cebbe4*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cebc94*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cebcb0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cec448*/ TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt);
        /*0x3ced8f0*/ bool IsValidChar(char c);
        /*0x3ced904*/ void ProcessEvent(UnityEngine.Event e);
        /*0x3ced908*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3cedb04*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cedcc0*/ float GetScrollPositionRelativeToViewport();
        /*0x3cece60*/ string GetSelectedString();
        /*0x3cedf38*/ int FindNextWordBegin();
        /*0x3ced4ec*/ void MoveRight(bool shift, bool ctrl);
        /*0x3cee00c*/ int FindPrevWordBegin();
        /*0x3ced150*/ void MoveLeft(bool shift, bool ctrl);
        /*0x3cee0c4*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x3cee20c*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x3cee354*/ int PageUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x3cee548*/ int PageDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x3ced8d8*/ void MoveDown(bool shift);
        /*0x3cee75c*/ void MoveDown(bool shift, bool goToLastChar);
        /*0x3ced8d0*/ void MoveUp(bool shift);
        /*0x3cee90c*/ void MoveUp(bool shift, bool goToFirstChar);
        /*0x3ced8e0*/ void MovePageUp(bool shift);
        /*0x3ceeaa8*/ void MovePageUp(bool shift, bool goToFirstChar);
        /*0x3ced8e8*/ void MovePageDown(bool shift);
        /*0x3ceed40*/ void MovePageDown(bool shift, bool goToLastChar);
        /*0x3cecf2c*/ void Delete();
        /*0x3cecc38*/ void DeleteKey();
        /*0x3cec8a0*/ void Backspace();
        /*0x3ceefe8*/ void Append(string input);
        /*0x3cef098*/ void Append(char input);
        /*0x3cef2f8*/ void Insert(char c);
        /*0x3ced114*/ void UpdateTouchKeyboardFromEditChanges();
        /*0x3ceb818*/ void SendOnValueChangedAndUpdateLabel();
        /*0x3ce6db4*/ void SendOnValueChanged();
        /*0x3cef3f4*/ void SendOnEndEdit();
        /*0x3cedaa8*/ void SendOnSubmit();
        /*0x3cef450*/ void SendOnFocus();
        /*0x3cef4ac*/ void SendOnFocusLost();
        /*0x3cef508*/ void SendOnTextSelection();
        /*0x3cef5a8*/ void SendOnEndTextSelection();
        /*0x3ceaf9c*/ void SendTouchScreenKeyboardStatusChanged();
        /*0x3ce692c*/ void UpdateLabel();
        /*0x3ce99b8*/ void UpdateScrollbar();
        /*0x3cef64c*/ void OnScrollbarValueChange(float value);
        /*0x3ce9308*/ void UpdateMaskRegions();
        /*0x3cedda0*/ void AdjustTextPositionRelativeToViewport(float relativePosition);
        /*0x3ce9948*/ int GetCaretPositionFromStringIndex(int stringIndex);
        /*0x3cef688*/ int GetMinCaretPositionFromStringIndex(int stringIndex);
        /*0x3cef6fc*/ int GetMaxCaretPositionFromStringIndex(int stringIndex);
        /*0x3ce9cf8*/ int GetStringIndexFromCaretPosition(int caretPosition);
        /*0x3cef76c*/ void ForceLabelUpdate();
        /*0x3ce6f68*/ void MarkGeometryAsDirty();
        /*0x3cef770*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x3cef834*/ void LayoutComplete();
        /*0x3cef838*/ void GraphicUpdateComplete();
        /*0x3cef780*/ void UpdateGeometry();
        /*0x3ce8e08*/ void AssignPositioningIfNeeded();
        /*0x3cef83c*/ void OnFillVBO(UnityEngine.Mesh vbo);
        /*0x3cefb5c*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x3cf071c*/ void CreateCursorVerts();
        /*0x3cf0148*/ void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x3cf0864*/ void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, float height, bool isCharVisible);
        /*0x3ceb00c*/ char Validate(string text, int pos, char ch);
        /*0x3cf0cd4*/ void ActivateInputField();
        /*0x3ceab70*/ void ActivateInputFieldInternal();
        /*0x3cf0de8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3cf0e0c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3cf0e28*/ void OnControlClick();
        /*0x3ceaf60*/ void ReleaseSelection();
        /*0x3ce9648*/ void DeactivateInputField(bool clearSelection);
        /*0x3cf0e2c*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3cf0e64*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3ce7c48*/ void EnforceContentType();
        /*0x3ce62b4*/ void SetTextComponentWrapMode();
        /*0x3ce815c*/ void SetTextComponentRichTextMode();
        /*0x3ce7e10*/ void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes);
        /*0x3ce7f78*/ void SetToCustom();
        /*0x3ce8124*/ void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x3cf0eb8*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
        /*0x3cf0ee4*/ void CalculateLayoutInputHorizontal();
        /*0x3cf0ee8*/ void CalculateLayoutInputVertical();
        /*0x3cf0eec*/ float get_minWidth();
        /*0x3cf0ef4*/ float get_preferredWidth();
        /*0x3cf1024*/ float get_flexibleWidth();
        /*0x3cf102c*/ float get_minHeight();
        /*0x3cf1034*/ float get_preferredHeight();
        /*0x3cf1164*/ float get_flexibleHeight();
        /*0x3cf116c*/ int get_layoutPriority();
        /*0x3ce7944*/ void SetGlobalPointSize(float pointSize);
        /*0x3ce7ab4*/ void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset);
        /*0x3cf1214*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
            /*0x3cf121c*/ OnValidateInput(object object, nint method);
            /*0x3cf12d0*/ char Invoke(string text, int charIndex, char addedChar);
            /*0x3cf12e4*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
            /*0x3cf1368*/ char EndInvoke(System.IAsyncResult result);
        }

        class SubmitEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x3ce614c*/ SubmitEvent();
        }

        class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x3ce6224*/ OnChangeEvent();
        }

        class SelectionEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x3ce6194*/ SelectionEvent();
        }

        class TextSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0x3ce61dc*/ TextSelectionEvent();
        }

        class TouchScreenKeyboardEvent : UnityEngine.Events.UnityEvent<UnityEngine.TouchScreenKeyboard.Status>
        {
            /*0x3ce626c*/ TouchScreenKeyboardEvent();
        }

        enum EditState
        {
            Continue = 0,
            Finish = 1,
        }

        class <CaretBlink>d__276 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;

            /*0x3ce9afc*/ <CaretBlink>d__276(int <>1__state);
            /*0x3cf1390*/ void System.IDisposable.Dispose();
            /*0x3cf1394*/ bool MoveNext();
            /*0x3cf14d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3cf14dc*/ void System.Collections.IEnumerator.Reset();
            /*0x3cf1514*/ object System.Collections.IEnumerator.get_Current();
        }

        class <MouseDragOutsideRect>d__294 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;
            /*0x28*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x3cebc6c*/ <MouseDragOutsideRect>d__294(int <>1__state);
            /*0x3cf151c*/ void System.IDisposable.Dispose();
            /*0x3cf1520*/ bool MoveNext();
            /*0x3cf1734*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3cf173c*/ void System.Collections.IEnumerator.Reset();
            /*0x3cf1774*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class SetPropertyUtility
    {
        static /*0x3ce73a8*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
        static /*0x1ffc854*/ bool SetEquatableStruct<T>(ref T currentValue, T newValue);
        static /*0x1ffc854*/ bool SetStruct<T>(ref T currentValue, T newValue);
        static /*0x1ffc854*/ bool SetClass<T>(ref T currentValue, T newValue);
    }

    class TMP_InputValidator : UnityEngine.ScriptableObject
    {
        /*0x3cf177c*/ TMP_InputValidator();
        char Validate(ref string text, ref int pos, char ch);
    }

    struct TMP_LineInfo
    {
        /*0x10*/ int controlCharacterCount;
        /*0x14*/ int characterCount;
        /*0x18*/ int visibleCharacterCount;
        /*0x1c*/ int spaceCount;
        /*0x20*/ int wordCount;
        /*0x24*/ int firstCharacterIndex;
        /*0x28*/ int firstVisibleCharacterIndex;
        /*0x2c*/ int lastCharacterIndex;
        /*0x30*/ int lastVisibleCharacterIndex;
        /*0x34*/ float length;
        /*0x38*/ float lineHeight;
        /*0x3c*/ float ascender;
        /*0x40*/ float baseline;
        /*0x44*/ float descender;
        /*0x48*/ float maxAdvance;
        /*0x4c*/ float width;
        /*0x50*/ float marginLeft;
        /*0x54*/ float marginRight;
        /*0x58*/ TMPro.HorizontalAlignmentOptions alignment;
        /*0x5c*/ TMPro.Extents lineExtents;
    }

    class TMP_ListPool<T>
    {
        static /*0x0*/ TMPro.TMP_ObjectPool<System.Collections.Generic.List<T>> s_ListPool;

        static /*0x1f33998*/ TMP_ListPool();
        static /*0x1f327a0*/ System.Collections.Generic.List<T> Get();
        static /*0x1f350f8*/ void Release(System.Collections.Generic.List<T> toRelease);

        class <>c<T>
        {
            static /*0x0*/ TMPro.TMP_ListPool.<>c<T> <>9;

            static /*0x1f33998*/ <>c();
            /*0x1f309e4*/ <>c();
            /*0x1f30ebc*/ void <.cctor>b__3_0(System.Collections.Generic.List<T> l);
        }
    }

    class TMP_MaterialManager
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        static /*0x8*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        static /*0x18*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        static /*0x20*/ bool isFallbackListDirty;

        static /*0x3cf1784*/ TMP_MaterialManager();
        static /*0x3cf1974*/ void OnPreRender();
        static /*0x3cf1c4c*/ UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, int stencilID);
        static /*0x3cf1ff4*/ void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x3cf221c*/ UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial);
        static /*0x3cf2398*/ UnityEngine.Material SetStencil(UnityEngine.Material material, int stencilID);
        static /*0x3cf2454*/ void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, int stencilID);
        static /*0x3cf26c8*/ void RemoveStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x3cf2830*/ void ReleaseBaseMaterial(UnityEngine.Material baseMaterial);
        static /*0x3cf2db0*/ void ClearMaterials();
        static /*0x3cf2fb8*/ int GetStencilID(UnityEngine.GameObject obj);
        static /*0x3cf342c*/ UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial);
        static /*0x3cf3284*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
        static /*0x3cf3634*/ UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
        static /*0x3cf3ba4*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
        static /*0x3cf4004*/ void AddFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x3cf4154*/ void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x3cf19ec*/ void CleanupFallbackMaterials();
        static /*0x3cf42ec*/ void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial);
        static /*0x3cf3938*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);

        class FallbackMaterial
        {
            /*0x10*/ long fallbackID;
            /*0x18*/ UnityEngine.Material sourceMaterial;
            /*0x20*/ int sourceMaterialCRC;
            /*0x28*/ UnityEngine.Material fallbackMaterial;
            /*0x30*/ int count;

            /*0x3d0aa7c*/ FallbackMaterial();
        }

        class MaskingMaterial
        {
            /*0x10*/ UnityEngine.Material baseMaterial;
            /*0x18*/ UnityEngine.Material stencilMaterial;
            /*0x20*/ int count;
            /*0x24*/ int stencilID;

            /*0x3d0aa84*/ MaskingMaterial();
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x3d0aa8c*/ <>c__DisplayClass11_0();
            /*0x3d0aa94*/ bool <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x3d0ab04*/ <>c__DisplayClass12_0();
            /*0x3d0ab0c*/ bool <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ UnityEngine.Material baseMaterial;

            /*0x3d0ab7c*/ <>c__DisplayClass13_0();
            /*0x3d0ab84*/ bool <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x3d0abf4*/ <>c__DisplayClass9_0();
            /*0x3d0abfc*/ bool <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
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
        /*0x38*/ UnityEngine.Vector2[] uvs0;
        /*0x40*/ UnityEngine.Vector2[] uvs2;
        /*0x48*/ UnityEngine.Color32[] colors32;
        /*0x50*/ int[] triangles;
        /*0x58*/ UnityEngine.Material material;

        static /*0x3d0d264*/ TMP_MeshInfo();
        /*0x3d0ac6c*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size);
        /*0x3d0b1ec*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size, bool isVolumetric);
        /*0x3d0ba00*/ void ResizeMeshInfo(int size);
        /*0x3d0be78*/ void ResizeMeshInfo(int size, bool isVolumetric);
        /*0x3d0c74c*/ void Clear();
        /*0x3d0c7f0*/ void Clear(bool uploadChanges);
        /*0x3d0c918*/ void ClearUnusedVertices();
        /*0x3d0c94c*/ void ClearUnusedVertices(int startIndex);
        /*0x3d0c978*/ void ClearUnusedVertices(int startIndex, bool updateMesh);
        /*0x3d0ca3c*/ void SortGeometry(TMPro.VertexSortingOrder order);
        /*0x3d0d06c*/ void SortGeometry(System.Collections.Generic.IList<int> sortingOrder);
        /*0x3d0caf0*/ void SwapVertexData(int src, int dst);
    }

    class TMP_ObjectPool<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        /*0x0*/ int <countAll>k__BackingField;

        /*0x1f30ff0*/ TMP_ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
        /*0x1f2ffc8*/ int get_countAll();
        /*0x1f30b78*/ void set_countAll(int value);
        /*0x1f2ffc8*/ int get_countActive();
        /*0x1f2ffc8*/ int get_countInactive();
        /*0x1ffc854*/ T Get();
        /*0x1ffc854*/ void Release(T element);
    }

    class TMP_ResourceManager
    {
        static /*0x0*/ TMPro.TMP_ResourceManager s_instance;
        static /*0x8*/ TMPro.TMP_Settings s_TextSettings;
        static /*0x10*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> s_FontAssetReferences;
        static /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;

        static /*0x3d0d2e4*/ TMP_ResourceManager();
        static /*0x3d0d404*/ TMPro.TMP_Settings GetTextSettings();
        static /*0x3d0d514*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x3d0d628*/ bool TryGetFontAsset(int hashcode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x3d0d6d4*/ void RebuildFontAssetCache(int instanceID);
        /*0x3d0d3fc*/ TMP_ResourceManager();
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
        RED = 91635,
        GREEN = 87065851,
        BLUE = 2457214,
        YELLOW = -882444668,
        ORANGE = -1108587920,
        BLACK = 81074727,
        WHITE = 105680263,
        PURPLE = -1250222130,
        BR = 2256,
        ZWSP = 3288238,
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
        NORMAL = -1183493901,
        DEFAULT = -620974005,
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

        /*0x3d0d950*/ TMP_ScrollbarEventHandler();
        /*0x3d0d7fc*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3d0d864*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x3d0d8dc*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
    }

    class TMP_SelectionCaret : UnityEngine.UI.MaskableGraphic
    {
        /*0x3d0da2c*/ TMP_SelectionCaret();
        /*0x3d0d958*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x3d0da28*/ void UpdateGeometry();
    }

    class TMP_Settings : UnityEngine.ScriptableObject
    {
        static string ExpectedAssetName = "TMP Settings";
        static /*0x0*/ TMPro.TMP_Settings s_Instance;
        /*0x18*/ bool m_enableWordWrapping;
        /*0x19*/ bool m_enableKerning;
        /*0x1a*/ bool m_enableExtraPadding;
        /*0x1b*/ bool m_enableTintAllSprites;
        /*0x1c*/ bool m_enableParseEscapeCharacters;
        /*0x1d*/ bool m_EnableRaycastTarget;
        /*0x1e*/ bool m_allowSavingGeneratedFonts;
        /*0x20*/ int m_missingGlyphCharacter;
        /*0x24*/ bool m_warningsDisabled;
        /*0x28*/ TMPro.TMP_FontAsset m_defaultFontAsset;
        /*0x30*/ string m_defaultFontAssetPath;
        /*0x38*/ float m_defaultFontSize;
        /*0x3c*/ float m_defaultAutoSizeMinRatio;
        /*0x40*/ float m_defaultAutoSizeMaxRatio;
        /*0x44*/ UnityEngine.Vector2 m_defaultTextMeshProTextContainerSize;
        /*0x4c*/ UnityEngine.Vector2 m_defaultTextMeshProUITextContainerSize;
        /*0x54*/ bool m_autoSizeTextContainer;
        /*0x55*/ bool m_IsTextObjectScaleStatic;
        /*0x58*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_fallbackFontAssets;
        /*0x60*/ bool m_matchMaterialPreset;
        /*0x68*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x70*/ string m_defaultSpriteAssetPath;
        /*0x78*/ bool m_enableEmojiSupport;
        /*0x7c*/ uint m_MissingCharacterSpriteUnicode;
        /*0x80*/ string m_defaultColorGradientPresetsPath;
        /*0x88*/ TMPro.TMP_StyleSheet m_defaultStyleSheet;
        /*0x90*/ string m_StyleSheetsResourcePath;
        /*0x98*/ UnityEngine.TextAsset m_leadingCharacters;
        /*0xa0*/ UnityEngine.TextAsset m_followingCharacters;
        /*0xa8*/ TMPro.TMP_Settings.LineBreakingTable m_linebreakingRules;
        /*0xb0*/ string[] m_scriptsWithOpenTypeSupport;
        /*0xb8*/ bool m_UseModernHangulLineBreakingRules;

        static /*0x3d0da34*/ string get_version();
        static /*0x3d0da74*/ bool get_enableWordWrapping();
        static /*0x3d0db60*/ bool get_enableKerning();
        static /*0x3d0db7c*/ bool get_enableExtraPadding();
        static /*0x3d0db98*/ bool get_enableTintAllSprites();
        static /*0x3d0dbb4*/ bool get_enableParseEscapeCharacters();
        static /*0x3d0dbd0*/ bool get_enableRaycastTarget();
        static /*0x3d0dbec*/ bool get_getFontFeaturesAtRuntime();
        static /*0x3d0dbf4*/ bool get_AllowSavingGeneratedFonts();
        static /*0x3d0dc10*/ void set_AllowSavingGeneratedFonts(bool value);
        static /*0x3d0dc34*/ int get_missingGlyphCharacter();
        static /*0x3d0dc50*/ void set_missingGlyphCharacter(int value);
        static /*0x3d0dc70*/ bool get_warningsDisabled();
        static /*0x3d0dc78*/ TMPro.TMP_FontAsset get_defaultFontAsset();
        static /*0x3d0dc94*/ string get_defaultFontAssetPath();
        static /*0x3d0dcb0*/ float get_defaultFontSize();
        static /*0x3d0dccc*/ float get_defaultTextAutoSizingMinRatio();
        static /*0x3d0dce8*/ float get_defaultTextAutoSizingMaxRatio();
        static /*0x3d0dd04*/ UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize();
        static /*0x3d0dd20*/ UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize();
        static /*0x3d0dd3c*/ bool get_autoSizeTextContainer();
        static /*0x3d0dd58*/ bool get_isTextObjectScaleStatic();
        static /*0x3d0dd74*/ void set_isTextObjectScaleStatic(bool value);
        static /*0x3d0dd98*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets();
        static /*0x3d0de20*/ bool get_matchMaterialPreset();
        static /*0x3d0de3c*/ TMPro.TMP_SpriteAsset get_defaultSpriteAsset();
        static /*0x3d0de58*/ string get_defaultSpriteAssetPath();
        static /*0x3d0de74*/ bool get_enableEmojiSupport();
        static /*0x3d0de90*/ void set_enableEmojiSupport(bool value);
        static /*0x3d0deb4*/ uint get_missingCharacterSpriteUnicode();
        static /*0x3d0ded0*/ void set_missingCharacterSpriteUnicode(uint value);
        static /*0x3d0def0*/ string get_defaultColorGradientPresetsPath();
        static /*0x3d0df0c*/ TMPro.TMP_StyleSheet get_defaultStyleSheet();
        static /*0x3d0df8c*/ string get_styleSheetsResourcePath();
        static /*0x3d0dfa8*/ UnityEngine.TextAsset get_leadingCharacters();
        static /*0x3d0dfc4*/ UnityEngine.TextAsset get_followingCharacters();
        static /*0x3d0dfe0*/ TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules();
        static /*0x3d0e14c*/ string[] get_scriptsWithOpenTypeSupport();
        static /*0x3d0e168*/ bool get_useModernHangulLineBreakingRules();
        static /*0x3d0e184*/ void set_useModernHangulLineBreakingRules(bool value);
        static /*0x3d0da90*/ TMPro.TMP_Settings get_instance();
        static /*0x3d0e1a8*/ void set_instance(TMPro.TMP_Settings value);
        static /*0x3d0e200*/ TMPro.TMP_Settings GetSettings();
        static /*0x3d0e27c*/ TMPro.TMP_FontAsset GetFontAsset();
        static /*0x3d0e300*/ TMPro.TMP_SpriteAsset GetSpriteAsset();
        static /*0x3d0e384*/ TMPro.TMP_StyleSheet GetStyleSheet();
        static /*0x3d0e010*/ void LoadLinebreakingRules();
        static /*0x3d0e410*/ System.Collections.Generic.Dictionary<int, char> GetCharacters(UnityEngine.TextAsset file);
        /*0x3d0e548*/ TMP_Settings();

        class LineBreakingTable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, char> leadingCharacters;
            /*0x18*/ System.Collections.Generic.Dictionary<int, char> followingCharacters;

            /*0x3d0e408*/ LineBreakingTable();
        }
    }

    class ShaderUtilities
    {
        static /*0x0*/ int ID_MainTex;
        static /*0x4*/ int ID_FaceTex;
        static /*0x8*/ int ID_FaceColor;
        static /*0xc*/ int ID_FaceDilate;
        static /*0x10*/ int ID_Shininess;
        static /*0x14*/ int ID_UnderlayColor;
        static /*0x18*/ int ID_UnderlayOffsetX;
        static /*0x1c*/ int ID_UnderlayOffsetY;
        static /*0x20*/ int ID_UnderlayDilate;
        static /*0x24*/ int ID_UnderlaySoftness;
        static /*0x28*/ int ID_UnderlayOffset;
        static /*0x2c*/ int ID_UnderlayIsoPerimeter;
        static /*0x30*/ int ID_WeightNormal;
        static /*0x34*/ int ID_WeightBold;
        static /*0x38*/ int ID_OutlineTex;
        static /*0x3c*/ int ID_OutlineWidth;
        static /*0x40*/ int ID_OutlineSoftness;
        static /*0x44*/ int ID_OutlineColor;
        static /*0x48*/ int ID_Outline2Color;
        static /*0x4c*/ int ID_Outline2Width;
        static /*0x50*/ int ID_Padding;
        static /*0x54*/ int ID_GradientScale;
        static /*0x58*/ int ID_ScaleX;
        static /*0x5c*/ int ID_ScaleY;
        static /*0x60*/ int ID_PerspectiveFilter;
        static /*0x64*/ int ID_Sharpness;
        static /*0x68*/ int ID_TextureWidth;
        static /*0x6c*/ int ID_TextureHeight;
        static /*0x70*/ int ID_BevelAmount;
        static /*0x74*/ int ID_GlowColor;
        static /*0x78*/ int ID_GlowOffset;
        static /*0x7c*/ int ID_GlowPower;
        static /*0x80*/ int ID_GlowOuter;
        static /*0x84*/ int ID_GlowInner;
        static /*0x88*/ int ID_LightAngle;
        static /*0x8c*/ int ID_EnvMap;
        static /*0x90*/ int ID_EnvMatrix;
        static /*0x94*/ int ID_EnvMatrixRotation;
        static /*0x98*/ int ID_MaskCoord;
        static /*0x9c*/ int ID_ClipRect;
        static /*0xa0*/ int ID_MaskSoftnessX;
        static /*0xa4*/ int ID_MaskSoftnessY;
        static /*0xa8*/ int ID_VertexOffsetX;
        static /*0xac*/ int ID_VertexOffsetY;
        static /*0xb0*/ int ID_UseClipRect;
        static /*0xb4*/ int ID_StencilID;
        static /*0xb8*/ int ID_StencilOp;
        static /*0xbc*/ int ID_StencilComp;
        static /*0xc0*/ int ID_StencilReadMask;
        static /*0xc4*/ int ID_StencilWriteMask;
        static /*0xc8*/ int ID_ShaderFlags;
        static /*0xcc*/ int ID_ScaleRatio_A;
        static /*0xd0*/ int ID_ScaleRatio_B;
        static /*0xd4*/ int ID_ScaleRatio_C;
        static /*0xd8*/ string Keyword_Bevel;
        static /*0xe0*/ string Keyword_Glow;
        static /*0xe8*/ string Keyword_Underlay;
        static /*0xf0*/ string Keyword_Ratios;
        static /*0xf8*/ string Keyword_MASK_SOFT;
        static /*0x100*/ string Keyword_MASK_HARD;
        static /*0x108*/ string Keyword_MASK_TEX;
        static /*0x110*/ string Keyword_Outline;
        static /*0x118*/ string ShaderTag_ZTestMode;
        static /*0x120*/ string ShaderTag_CullMode;
        static /*0x128*/ float m_clamp;
        static /*0x12c*/ bool isInitialized;
        static /*0x130*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
        static /*0x138*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;

        static /*0x3d0e758*/ ShaderUtilities();
        static /*0x3d0e558*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
        static /*0x3d0e658*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
        static /*0x3d0e96c*/ void GetShaderPropertyIDs();
        static /*0x3d0f52c*/ void UpdateShaderRatios(UnityEngine.Material mat);
        static /*0x3d0f99c*/ UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material);
        static /*0x3d0f9e0*/ bool IsMaskingEnabled(UnityEngine.Material material);
        static /*0x3d0fb7c*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
        static /*0x3d10230*/ float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold);
    }

    class TMP_Sprite : TMPro.TMP_TextElement_Legacy
    {
        /*0x38*/ string name;
        /*0x40*/ int hashCode;
        /*0x44*/ int unicode;
        /*0x48*/ UnityEngine.Vector2 pivot;
        /*0x50*/ UnityEngine.Sprite sprite;

        /*0x3d10b08*/ TMP_Sprite();
    }

    class TMP_SpriteAnimator : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_animations;
        /*0x28*/ TMPro.TMP_Text m_TextComponent;

        /*0x3d10db8*/ TMP_SpriteAnimator();
        /*0x3d10b18*/ void Awake();
        /*0x3d10b80*/ void OnEnable();
        /*0x3d10b84*/ void OnDisable();
        /*0x3d10b88*/ void StopAllAnimations();
        /*0x3d10be4*/ void DoSpriteAnimation(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
        /*0x3d10cdc*/ System.Collections.IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);

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

            /*0x3d10d90*/ <DoSpriteAnimationInternal>d__7(int <>1__state);
            /*0x3d10e44*/ void System.IDisposable.Dispose();
            /*0x3d10e48*/ bool MoveNext();
            /*0x3d117cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3d117d4*/ void System.Collections.IEnumerator.Reset();
            /*0x3d1180c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class TMP_SpriteAsset : TMPro.TMP_Asset
    {
        static /*0x0*/ System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
        /*0x30*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
        /*0x38*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
        /*0x40*/ string m_Version;
        /*0x48*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0xa8*/ UnityEngine.Texture spriteSheet;
        /*0xb0*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> m_SpriteCharacterTable;
        /*0xb8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> m_SpriteCharacterLookup;
        /*0xc0*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> m_SpriteGlyphTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteGlyph> m_SpriteGlyphLookup;
        /*0xd0*/ System.Collections.Generic.List<TMPro.TMP_Sprite> spriteInfoList;
        /*0xd8*/ System.Collections.Generic.List<TMPro.TMP_SpriteAsset> fallbackSpriteAssets;
        /*0xe0*/ bool m_IsSpriteAssetLookupTablesDirty;

        static /*0x3d12684*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x3d128a8*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x3d12a50*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x3d12b00*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex);
        static /*0x3d12e34*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
        static /*0x3d12fdc*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
        /*0x3d13404*/ TMP_SpriteAsset();
        /*0x3d11814*/ string get_version();
        /*0x3d1181c*/ void set_version(string value);
        /*0x3d11824*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x3d11834*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x3d117a8*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable();
        /*0x3d11dfc*/ void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value);
        /*0x3d11e04*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable();
        /*0x3d11e28*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> value);
        /*0x3d11e30*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable();
        /*0x3d11e38*/ void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value);
        /*0x3d11e40*/ void Awake();
        /*0x3d12398*/ UnityEngine.Material GetDefaultSpriteMaterial();
        /*0x3d11858*/ void UpdateLookupTables();
        /*0x3d12480*/ int GetSpriteIndexFromHashcode(int hashCode);
        /*0x3d1250c*/ int GetSpriteIndexFromUnicode(uint unicode);
        /*0x3d125a4*/ int GetSpriteIndexFromName(string name);
        /*0x3d1308c*/ void SortGlyphTable();
        /*0x3d131dc*/ void SortCharacterTable();
        /*0x3d13330*/ void SortGlyphAndCharacterTables();
        /*0x3d11ec8*/ void UpgradeSpriteAsset();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_SpriteAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_SpriteGlyph, uint> <>9__40_0;
            static /*0x10*/ System.Func<TMPro.TMP_SpriteCharacter, uint> <>9__41_0;

            static /*0x3d134e0*/ <>c();
            /*0x3d13548*/ <>c();
            /*0x3d13550*/ uint <SortGlyphTable>b__40_0(TMPro.TMP_SpriteGlyph item);
            /*0x3d13568*/ uint <SortCharacterTable>b__41_0(TMPro.TMP_SpriteCharacter c);
        }
    }

    class TMP_SpriteCharacter : TMPro.TMP_TextElement
    {
        /*0x30*/ string m_Name;
        /*0x38*/ int m_HashCode;

        /*0x3d13350*/ TMP_SpriteCharacter();
        /*0x3d13600*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteGlyph glyph);
        /*0x3d13664*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph);
        /*0x3d136e0*/ TMP_SpriteCharacter(uint unicode, uint glyphIndex);
        /*0x3d1357c*/ string get_name();
        /*0x3d13370*/ void set_name(string value);
        /*0x3d135f0*/ int get_hashCode();
    }

    class TMP_SpriteGlyph : UnityEngine.TextCore.Glyph
    {
        /*0x48*/ UnityEngine.Sprite sprite;

        /*0x3d13348*/ TMP_SpriteGlyph();
        /*0x3d1373c*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
        /*0x3d137f8*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite);
    }

    class TMP_Style
    {
        static /*0x0*/ TMPro.TMP_Style k_NormalStyle;
        /*0x10*/ string m_Name;
        /*0x18*/ int m_HashCode;
        /*0x20*/ string m_OpeningDefinition;
        /*0x28*/ string m_ClosingDefinition;
        /*0x30*/ int[] m_OpeningTagArray;
        /*0x38*/ int[] m_ClosingTagArray;
        /*0x40*/ uint[] m_OpeningTagUnicodeArray;
        /*0x48*/ uint[] m_ClosingTagUnicodeArray;

        static /*0x3d138c8*/ TMPro.TMP_Style get_NormalStyle();
        /*0x3d13980*/ TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
        /*0x3d13a3c*/ string get_name();
        /*0x3d13a44*/ void set_name(string value);
        /*0x3d13a90*/ int get_hashCode();
        /*0x3d13a98*/ void set_hashCode(int value);
        /*0x3d13aac*/ string get_styleOpeningDefinition();
        /*0x3d13ab4*/ string get_styleClosingDefinition();
        /*0x3d13abc*/ int[] get_styleOpeningTagArray();
        /*0x3d13ac4*/ int[] get_styleClosingTagArray();
        /*0x3d13b88*/ void RefreshStyle();
    }

    class TMP_StyleSheet : UnityEngine.ScriptableObject
    {
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_Style> m_StyleLookupDictionary;

        /*0x3d141ec*/ TMP_StyleSheet();
        /*0x3d13db8*/ System.Collections.Generic.List<TMPro.TMP_Style> get_styles();
        /*0x3d13dc0*/ void Reset();
        /*0x3d140a0*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x3d1412c*/ TMPro.TMP_Style GetStyle(string name);
        /*0x3d141e8*/ void RefreshStyles();
        /*0x3d13dc4*/ void LoadStyleDictionaryInternal();
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

        static /*0x3d14ac4*/ TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference);
        /*0x3d155d0*/ TMP_SubMesh();
        /*0x3d14278*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x3d14280*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x3d14288*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x3d14290*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x3d14298*/ UnityEngine.Material get_material();
        /*0x3d143fc*/ void set_material(UnityEngine.Material value);
        /*0x3d145c4*/ UnityEngine.Material get_sharedMaterial();
        /*0x3d145cc*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x3d145f8*/ UnityEngine.Material get_fallbackMaterial();
        /*0x3d14600*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x3d14750*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x3d14758*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x3d14760*/ bool get_isDefaultMaterial();
        /*0x3d14768*/ void set_isDefaultMaterial(bool value);
        /*0x3d14770*/ float get_padding();
        /*0x3d14778*/ void set_padding(float value);
        /*0x3d14780*/ UnityEngine.Renderer get_renderer();
        /*0x3d1482c*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x3d14954*/ UnityEngine.Mesh get_mesh();
        /*0x3d14a10*/ void set_mesh(UnityEngine.Mesh value);
        /*0x3d14a18*/ TMPro.TMP_Text get_textComponent();
        /*0x3d14ea0*/ void OnEnable();
        /*0x3d14fcc*/ void OnDisable();
        /*0x3d15098*/ void OnDestroy();
        /*0x3d15200*/ void DestroySelf();
        /*0x3d142a0*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x3d15270*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x3d15330*/ UnityEngine.Material GetSharedMaterial();
        /*0x3d145d0*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x3d1449c*/ float GetPaddingForMaterial();
        /*0x3d153ec*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x3d14510*/ void SetVerticesDirty();
        /*0x3d145c0*/ void SetMaterialDirty();
        /*0x3d15460*/ void UpdateMaterial();
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

        static /*0x3d15d08*/ TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference);
        /*0x3d16ad4*/ TMP_SubMeshUI();
        /*0x3d155d8*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x3d155e0*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x3d155e8*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x3d155f0*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x3d155f8*/ UnityEngine.Texture get_mainTexture();
        /*0x3d156b4*/ UnityEngine.Material get_material();
        /*0x3d157c8*/ void set_material(UnityEngine.Material value);
        /*0x3d15944*/ UnityEngine.Material get_sharedMaterial();
        /*0x3d1594c*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x3d159a4*/ UnityEngine.Material get_fallbackMaterial();
        /*0x3d159ac*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x3d15afc*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x3d15b04*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x3d15b14*/ UnityEngine.Material get_materialForRendering();
        /*0x3d15b74*/ bool get_isDefaultMaterial();
        /*0x3d15b7c*/ void set_isDefaultMaterial(bool value);
        /*0x3d15b84*/ float get_padding();
        /*0x3d15b8c*/ void set_padding(float value);
        /*0x3d15b94*/ UnityEngine.Mesh get_mesh();
        /*0x3d15c50*/ void set_mesh(UnityEngine.Mesh value);
        /*0x3d15c60*/ TMPro.TMP_Text get_textComponent();
        /*0x3d160c4*/ void OnEnable();
        /*0x3d16134*/ void OnDisable();
        /*0x3d161f4*/ void OnDestroy();
        /*0x3d163b8*/ void OnTransformParentChanged();
        /*0x3d1640c*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x3d158d0*/ float GetPaddingForMaterial();
        /*0x3d1651c*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x3d16590*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x3d16604*/ void SetAllDirty();
        /*0x3d16608*/ void SetVerticesDirty();
        /*0x3d166bc*/ void SetLayoutDirty();
        /*0x3d166c0*/ void SetMaterialDirty();
        /*0x3d16704*/ void SetPivotDirty();
        /*0x3d1676c*/ UnityEngine.Transform GetRootCanvasTransform();
        /*0x3d16814*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x3d16818*/ void UpdateGeometry();
        /*0x3d1681c*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x3d16854*/ void RefreshMaterial();
        /*0x3d16864*/ void UpdateMaterial();
        /*0x3d169e4*/ void RecalculateClipping();
        /*0x3d169ec*/ UnityEngine.Material GetMaterial();
        /*0x3d156bc*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x3d169f4*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x3d16ab4*/ UnityEngine.Material GetSharedMaterial();
        /*0x3d15950*/ void SetSharedMaterial(UnityEngine.Material mat);
    }

    interface ITextElement
    {
        /*0x1f30214*/ UnityEngine.Material get_sharedMaterial();
        /*0x1f30b78*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x1f2ffc8*/ int GetInstanceID();
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
        static /*0x80*/ char[] m_htmlTag;
        static /*0x88*/ TMPro.RichTextTagAttribute[] m_xmlAttribute;
        static /*0x90*/ float[] m_attributeParameterValues;
        static /*0x98*/ TMPro.WordWrapState m_SavedWordWrapState;
        static /*0x410*/ TMPro.WordWrapState m_SavedLineState;
        static /*0x788*/ TMPro.WordWrapState m_SavedEllipsisState;
        static /*0xb00*/ TMPro.WordWrapState m_SavedLastValidState;
        static /*0xe78*/ TMPro.WordWrapState m_SavedSoftLineBreakState;
        static /*0x11f0*/ TMPro.TMP_TextProcessingStack<TMPro.WordWrapState> m_EllipsisInsertionCandidateStack;
        static /*0x1588*/ Unity.Profiling.ProfilerMarker k_ParseTextMarker;
        static /*0x1590*/ Unity.Profiling.ProfilerMarker k_InsertNewLineMarker;
        static /*0x1598*/ UnityEngine.Vector2 k_LargePositiveVector2;
        static /*0x15a0*/ UnityEngine.Vector2 k_LargeNegativeVector2;
        static /*0x15a8*/ float k_LargePositiveFloat;
        static /*0x15ac*/ float k_LargeNegativeFloat;
        static /*0x15b0*/ int k_LargePositiveInt;
        static /*0x15b4*/ int k_LargeNegativeInt;
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
        /*0x160*/ bool m_enableVertexGradient;
        /*0x164*/ TMPro.ColorMode m_colorMode;
        /*0x168*/ TMPro.VertexGradient m_fontColorGradient;
        /*0x1a8*/ TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        /*0x1b0*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x1b8*/ bool m_tintAllSprites;
        /*0x1b9*/ bool m_tintSprite;
        /*0x1bc*/ UnityEngine.Color32 m_spriteColor;
        /*0x1c0*/ TMPro.TMP_StyleSheet m_StyleSheet;
        /*0x1c8*/ TMPro.TMP_Style m_TextStyle;
        /*0x1d0*/ int m_TextStyleHashCode;
        /*0x1d4*/ bool m_overrideHtmlColors;
        /*0x1d8*/ UnityEngine.Color32 m_faceColor;
        /*0x1dc*/ UnityEngine.Color32 m_outlineColor;
        /*0x1e0*/ float m_outlineWidth;
        /*0x1e4*/ float m_fontSize;
        /*0x1e8*/ float m_currentFontSize;
        /*0x1ec*/ float m_fontSizeBase;
        /*0x1f0*/ TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        /*0x210*/ TMPro.FontWeight m_fontWeight;
        /*0x214*/ TMPro.FontWeight m_FontWeightInternal;
        /*0x218*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;
        /*0x238*/ bool m_enableAutoSizing;
        /*0x23c*/ float m_maxFontSize;
        /*0x240*/ float m_minFontSize;
        /*0x244*/ int m_AutoSizeIterationCount;
        /*0x248*/ int m_AutoSizeMaxIterationCount;
        /*0x24c*/ bool m_IsAutoSizePointSizeSet;
        /*0x250*/ float m_fontSizeMin;
        /*0x254*/ float m_fontSizeMax;
        /*0x258*/ TMPro.FontStyles m_fontStyle;
        /*0x25c*/ TMPro.FontStyles m_FontStyleInternal;
        /*0x260*/ TMPro.TMP_FontStyleStack m_fontStyleStack;
        /*0x26a*/ bool m_isUsingBold;
        /*0x26c*/ TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        /*0x270*/ TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        /*0x274*/ TMPro.TextAlignmentOptions m_textAlignment;
        /*0x278*/ TMPro.HorizontalAlignmentOptions m_lineJustification;
        /*0x280*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        /*0x2a0*/ UnityEngine.Vector3[] m_textContainerLocalCorners;
        /*0x2a8*/ float m_characterSpacing;
        /*0x2ac*/ float m_cSpacing;
        /*0x2b0*/ float m_monoSpacing;
        /*0x2b4*/ float m_wordSpacing;
        /*0x2b8*/ float m_lineSpacing;
        /*0x2bc*/ float m_lineSpacingDelta;
        /*0x2c0*/ float m_lineHeight;
        /*0x2c4*/ bool m_IsDrivenLineSpacing;
        /*0x2c8*/ float m_lineSpacingMax;
        /*0x2cc*/ float m_paragraphSpacing;
        /*0x2d0*/ float m_charWidthMaxAdj;
        /*0x2d4*/ float m_charWidthAdjDelta;
        /*0x2d8*/ bool m_enableWordWrapping;
        /*0x2d9*/ bool m_isCharacterWrappingEnabled;
        /*0x2da*/ bool m_isNonBreakingSpace;
        /*0x2db*/ bool m_isIgnoringAlignment;
        /*0x2dc*/ float m_wordWrappingRatios;
        /*0x2e0*/ TMPro.TextOverflowModes m_overflowMode;
        /*0x2e4*/ int m_firstOverflowCharacterIndex;
        /*0x2e8*/ TMPro.TMP_Text m_linkedTextComponent;
        /*0x2f0*/ TMPro.TMP_Text parentLinkedComponent;
        /*0x2f8*/ bool m_isTextTruncated;
        /*0x2f9*/ bool m_enableKerning;
        /*0x2fc*/ float m_GlyphHorizontalAdvanceAdjustment;
        /*0x300*/ bool m_enableExtraPadding;
        /*0x301*/ bool checkPaddingRequired;
        /*0x302*/ bool m_isRichText;
        /*0x303*/ bool m_parseCtrlCharacters;
        /*0x304*/ bool m_isOverlay;
        /*0x305*/ bool m_isOrthographic;
        /*0x306*/ bool m_isCullingEnabled;
        /*0x307*/ bool m_isMaskingEnabled;
        /*0x308*/ bool isMaskUpdateRequired;
        /*0x309*/ bool m_ignoreCulling;
        /*0x30c*/ TMPro.TextureMappingOptions m_horizontalMapping;
        /*0x310*/ TMPro.TextureMappingOptions m_verticalMapping;
        /*0x314*/ float m_uvLineOffset;
        /*0x318*/ TMPro.TextRenderFlags m_renderMode;
        /*0x31c*/ TMPro.VertexSortingOrder m_geometrySortingOrder;
        /*0x320*/ bool m_IsTextObjectScaleStatic;
        /*0x321*/ bool m_VertexBufferAutoSizeReduction;
        /*0x324*/ int m_firstVisibleCharacter;
        /*0x328*/ int m_maxVisibleCharacters;
        /*0x32c*/ int m_maxVisibleWords;
        /*0x330*/ int m_maxVisibleLines;
        /*0x334*/ bool m_useMaxVisibleDescender;
        /*0x338*/ int m_pageToDisplay;
        /*0x33c*/ bool m_isNewPage;
        /*0x340*/ UnityEngine.Vector4 m_margin;
        /*0x350*/ float m_marginLeft;
        /*0x354*/ float m_marginRight;
        /*0x358*/ float m_marginWidth;
        /*0x35c*/ float m_marginHeight;
        /*0x360*/ float m_width;
        /*0x368*/ TMPro.TMP_TextInfo m_textInfo;
        /*0x370*/ bool m_havePropertiesChanged;
        /*0x371*/ bool m_isUsingLegacyAnimationComponent;
        /*0x378*/ UnityEngine.Transform m_transform;
        /*0x380*/ UnityEngine.RectTransform m_rectTransform;
        /*0x388*/ UnityEngine.Vector2 m_PreviousRectTransformSize;
        /*0x390*/ UnityEngine.Vector2 m_PreviousPivotPosition;
        /*0x398*/ bool <autoSizeTextContainer>k__BackingField;
        /*0x399*/ bool m_autoSizeTextContainer;
        /*0x3a0*/ UnityEngine.Mesh m_mesh;
        /*0x3a8*/ bool m_isVolumetricText;
        /*0x3b0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x3b8*/ TMPro.TMP_SpriteAnimator m_spriteAnimator;
        /*0x3c0*/ float m_flexibleHeight;
        /*0x3c4*/ float m_flexibleWidth;
        /*0x3c8*/ float m_minWidth;
        /*0x3cc*/ float m_minHeight;
        /*0x3d0*/ float m_maxWidth;
        /*0x3d4*/ float m_maxHeight;
        /*0x3d8*/ UnityEngine.UI.LayoutElement m_LayoutElement;
        /*0x3e0*/ float m_preferredWidth;
        /*0x3e4*/ float m_renderedWidth;
        /*0x3e8*/ bool m_isPreferredWidthDirty;
        /*0x3ec*/ float m_preferredHeight;
        /*0x3f0*/ float m_renderedHeight;
        /*0x3f4*/ bool m_isPreferredHeightDirty;
        /*0x3f5*/ bool m_isCalculatingPreferredValues;
        /*0x3f8*/ int m_layoutPriority;
        /*0x3fc*/ bool m_isLayoutDirty;
        /*0x3fd*/ bool m_isAwake;
        /*0x3fe*/ bool m_isWaitingOnResourceLoad;
        /*0x400*/ TMPro.TMP_Text.TextInputSources m_inputSource;
        /*0x404*/ float m_fontScaleMultiplier;
        /*0x408*/ float tag_LineIndent;
        /*0x40c*/ float tag_Indent;
        /*0x410*/ TMPro.TMP_TextProcessingStack<float> m_indentStack;
        /*0x430*/ bool tag_NoParsing;
        /*0x431*/ bool m_isParsingText;
        /*0x434*/ UnityEngine.Matrix4x4 m_FXMatrix;
        /*0x474*/ bool m_isFXMatrixSet;
        /*0x478*/ TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;
        /*0x480*/ int m_InternalTextProcessingArraySize;
        /*0x488*/ TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        /*0x490*/ int m_totalCharacterCount;
        /*0x494*/ int m_characterCount;
        /*0x498*/ int m_firstCharacterOfLine;
        /*0x49c*/ int m_firstVisibleCharacterOfLine;
        /*0x4a0*/ int m_lastCharacterOfLine;
        /*0x4a4*/ int m_lastVisibleCharacterOfLine;
        /*0x4a8*/ int m_lineNumber;
        /*0x4ac*/ int m_lineVisibleCharacterCount;
        /*0x4b0*/ int m_pageNumber;
        /*0x4b4*/ float m_PageAscender;
        /*0x4b8*/ float m_maxTextAscender;
        /*0x4bc*/ float m_maxCapHeight;
        /*0x4c0*/ float m_ElementAscender;
        /*0x4c4*/ float m_ElementDescender;
        /*0x4c8*/ float m_maxLineAscender;
        /*0x4cc*/ float m_maxLineDescender;
        /*0x4d0*/ float m_startOfLineAscender;
        /*0x4d4*/ float m_startOfLineDescender;
        /*0x4d8*/ float m_lineOffset;
        /*0x4dc*/ TMPro.Extents m_meshExtents;
        /*0x4ec*/ UnityEngine.Color32 m_htmlColor;
        /*0x4f0*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;
        /*0x510*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;
        /*0x530*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;
        /*0x550*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;
        /*0x580*/ TMPro.TMP_ColorGradient m_colorGradientPreset;
        /*0x588*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;
        /*0x5b0*/ bool m_colorGradientPresetIsTinted;
        /*0x5b4*/ float m_tabSpacing;
        /*0x5b8*/ float m_spacing;
        /*0x5c0*/ TMPro.TMP_TextProcessingStack<int> m_TextStyleStacks;
        /*0x5c8*/ int m_TextStyleStackDepth;
        /*0x5d0*/ TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        /*0x5f0*/ int m_ItalicAngle;
        /*0x5f8*/ TMPro.TMP_TextProcessingStack<int> m_actionStack;
        /*0x618*/ float m_padding;
        /*0x61c*/ float m_baselineOffset;
        /*0x620*/ TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        /*0x640*/ float m_xAdvance;
        /*0x644*/ TMPro.TMP_TextElementType m_textElementType;
        /*0x648*/ TMPro.TMP_TextElement m_cached_TextElement;
        /*0x650*/ TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        /*0x670*/ TMPro.TMP_Text.SpecialCharacter m_Underline;
        /*0x690*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x698*/ TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        /*0x6a0*/ int m_spriteCount;
        /*0x6a4*/ int m_spriteIndex;
        /*0x6a8*/ int m_spriteAnimationID;
        /*0x6ac*/ bool m_ignoreActiveState;
        /*0x6b0*/ TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        /*0x6c0*/ decimal[] k_Power;

        static /*0x3d0a62c*/ TMP_Text();
        static /*0x3cf6730*/ void add_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x3cf6824*/ void remove_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x3cf6918*/ void add_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x3cf6a0c*/ void remove_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        /*0x3d09bdc*/ TMP_Text();
        /*0x3cf44a4*/ string get_text();
        /*0x3cf4588*/ void set_text(string value);
        /*0x3cf462c*/ TMPro.ITextPreprocessor get_textPreprocessor();
        /*0x3cf4634*/ void set_textPreprocessor(TMPro.ITextPreprocessor value);
        /*0x3cf463c*/ bool get_isRightToLeftText();
        /*0x3cf4644*/ void set_isRightToLeftText(bool value);
        /*0x3cf4694*/ TMPro.TMP_FontAsset get_font();
        /*0x3cf469c*/ void set_font(TMPro.TMP_FontAsset value);
        /*0x3cf4774*/ UnityEngine.Material get_fontSharedMaterial();
        /*0x3cf477c*/ void set_fontSharedMaterial(UnityEngine.Material value);
        /*0x3cf4844*/ UnityEngine.Material[] get_fontSharedMaterials();
        /*0x3cf4854*/ void set_fontSharedMaterials(UnityEngine.Material[] value);
        /*0x3cf48a0*/ UnityEngine.Material get_fontMaterial();
        /*0x3cf48b4*/ void set_fontMaterial(UnityEngine.Material value);
        /*0x3cf49bc*/ UnityEngine.Material[] get_fontMaterials();
        /*0x3cf49d0*/ void set_fontMaterials(UnityEngine.Material[] value);
        /*0x3cf4a1c*/ UnityEngine.Color get_color();
        /*0x3cf4a30*/ void set_color(UnityEngine.Color value);
        /*0x3cf4aa8*/ float get_alpha();
        /*0x3cf4ab0*/ void set_alpha(float value);
        /*0x3cf4adc*/ bool get_enableVertexGradient();
        /*0x3cf4ae4*/ void set_enableVertexGradient(bool value);
        /*0x3cf4b14*/ TMPro.VertexGradient get_colorGradient();
        /*0x3cf4b2c*/ void set_colorGradient(TMPro.VertexGradient value);
        /*0x3cf4b58*/ TMPro.TMP_ColorGradient get_colorGradientPreset();
        /*0x3cf4b60*/ void set_colorGradientPreset(TMPro.TMP_ColorGradient value);
        /*0x3cf4b94*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x3cf4b9c*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x3cf4be4*/ bool get_tintAllSprites();
        /*0x3cf4bec*/ void set_tintAllSprites(bool value);
        /*0x3cf4c1c*/ TMPro.TMP_StyleSheet get_styleSheet();
        /*0x3cf4c24*/ void set_styleSheet(TMPro.TMP_StyleSheet value);
        /*0x3cf4c6c*/ TMPro.TMP_Style get_textStyle();
        /*0x3cf4db4*/ void set_textStyle(TMPro.TMP_Style value);
        /*0x3cf4e10*/ bool get_overrideColorTags();
        /*0x3cf4e18*/ void set_overrideColorTags(bool value);
        /*0x3cf4e48*/ UnityEngine.Color32 get_faceColor();
        /*0x3cf4f0c*/ void set_faceColor(UnityEngine.Color32 value);
        /*0x3cf4f90*/ UnityEngine.Color32 get_outlineColor();
        /*0x3cf5054*/ void set_outlineColor(UnityEngine.Color32 value);
        /*0x3cf50c4*/ float get_outlineWidth();
        /*0x3cf5180*/ void set_outlineWidth(float value);
        /*0x3cf51d8*/ float get_fontSize();
        /*0x3cf51e0*/ void set_fontSize(float value);
        /*0x3cf523c*/ TMPro.FontWeight get_fontWeight();
        /*0x3cf5244*/ void set_fontWeight(TMPro.FontWeight value);
        /*0x3cf5290*/ float get_pixelsPerUnit();
        /*0x3cf5408*/ bool get_enableAutoSizing();
        /*0x3cf5410*/ void set_enableAutoSizing(bool value);
        /*0x3cf5458*/ float get_fontSizeMin();
        /*0x3cf5460*/ void set_fontSizeMin(float value);
        /*0x3cf54a4*/ float get_fontSizeMax();
        /*0x3cf54ac*/ void set_fontSizeMax(float value);
        /*0x3cf54f0*/ TMPro.FontStyles get_fontStyle();
        /*0x3cf54f8*/ void set_fontStyle(TMPro.FontStyles value);
        /*0x3cf5544*/ bool get_isUsingBold();
        /*0x3cf554c*/ TMPro.HorizontalAlignmentOptions get_horizontalAlignment();
        /*0x3cf5554*/ void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value);
        /*0x3cf5584*/ TMPro.VerticalAlignmentOptions get_verticalAlignment();
        /*0x3cf558c*/ void set_verticalAlignment(TMPro.VerticalAlignmentOptions value);
        /*0x3cf55bc*/ TMPro.TextAlignmentOptions get_alignment();
        /*0x3cf55cc*/ void set_alignment(TMPro.TextAlignmentOptions value);
        /*0x3cf5610*/ float get_characterSpacing();
        /*0x3cf5618*/ void set_characterSpacing(float value);
        /*0x3cf5664*/ float get_wordSpacing();
        /*0x3cf566c*/ void set_wordSpacing(float value);
        /*0x3cf56b8*/ float get_lineSpacing();
        /*0x3cf56c0*/ void set_lineSpacing(float value);
        /*0x3cf570c*/ float get_lineSpacingAdjustment();
        /*0x3cf5714*/ void set_lineSpacingAdjustment(float value);
        /*0x3cf5760*/ float get_paragraphSpacing();
        /*0x3cf5768*/ void set_paragraphSpacing(float value);
        /*0x3cf57b4*/ float get_characterWidthAdjustment();
        /*0x3cf57bc*/ void set_characterWidthAdjustment(float value);
        /*0x3cf5808*/ bool get_enableWordWrapping();
        /*0x3cf5810*/ void set_enableWordWrapping(bool value);
        /*0x3cf5860*/ float get_wordWrappingRatios();
        /*0x3cf5868*/ void set_wordWrappingRatios(float value);
        /*0x3cf58b4*/ TMPro.TextOverflowModes get_overflowMode();
        /*0x3cf58bc*/ void set_overflowMode(TMPro.TextOverflowModes value);
        /*0x3cf5908*/ bool get_isTextOverflowing();
        /*0x3cf5918*/ int get_firstOverflowCharacterIndex();
        /*0x3cf5920*/ TMPro.TMP_Text get_linkedTextComponent();
        /*0x3cf5928*/ void set_linkedTextComponent(TMPro.TMP_Text value);
        /*0x3cf5c3c*/ bool get_isTextTruncated();
        /*0x3cf5c44*/ bool get_enableKerning();
        /*0x3cf5c4c*/ void set_enableKerning(bool value);
        /*0x3cf5c9c*/ bool get_extraPadding();
        /*0x3cf5ca4*/ void set_extraPadding(bool value);
        /*0x3cf5cf4*/ bool get_richText();
        /*0x3cf5cfc*/ void set_richText(bool value);
        /*0x3cf5d4c*/ bool get_parseCtrlCharacters();
        /*0x3cf5d54*/ void set_parseCtrlCharacters(bool value);
        /*0x3cf5da4*/ bool get_isOverlay();
        /*0x3cf5dac*/ void set_isOverlay(bool value);
        /*0x3cf5dfc*/ bool get_isOrthographic();
        /*0x3cf5e04*/ void set_isOrthographic(bool value);
        /*0x3cf5e34*/ bool get_enableCulling();
        /*0x3cf5e3c*/ void set_enableCulling(bool value);
        /*0x3cf5e78*/ bool get_ignoreVisibility();
        /*0x3cf5e80*/ void set_ignoreVisibility(bool value);
        /*0x3cf5ea0*/ TMPro.TextureMappingOptions get_horizontalMapping();
        /*0x3cf5ea8*/ void set_horizontalMapping(TMPro.TextureMappingOptions value);
        /*0x3cf5ed8*/ TMPro.TextureMappingOptions get_verticalMapping();
        /*0x3cf5ee0*/ void set_verticalMapping(TMPro.TextureMappingOptions value);
        /*0x3cf5f10*/ float get_mappingUvLineOffset();
        /*0x3cf5f18*/ void set_mappingUvLineOffset(float value);
        /*0x3cf5f44*/ TMPro.TextRenderFlags get_renderMode();
        /*0x3cf5f4c*/ void set_renderMode(TMPro.TextRenderFlags value);
        /*0x3cf5f68*/ TMPro.VertexSortingOrder get_geometrySortingOrder();
        /*0x3cf5f70*/ void set_geometrySortingOrder(TMPro.VertexSortingOrder value);
        /*0x3cf5f90*/ bool get_isTextObjectScaleStatic();
        /*0x3cf5f98*/ void set_isTextObjectScaleStatic(bool value);
        /*0x3cf6028*/ bool get_vertexBufferAutoSizeReduction();
        /*0x3cf6030*/ void set_vertexBufferAutoSizeReduction(bool value);
        /*0x3cf6050*/ int get_firstVisibleCharacter();
        /*0x3cf6058*/ void set_firstVisibleCharacter(int value);
        /*0x3cf6088*/ int get_maxVisibleCharacters();
        /*0x3cf6090*/ void set_maxVisibleCharacters(int value);
        /*0x3cf60c0*/ int get_maxVisibleWords();
        /*0x3cf60c8*/ void set_maxVisibleWords(int value);
        /*0x3cf60f8*/ int get_maxVisibleLines();
        /*0x3cf6100*/ void set_maxVisibleLines(int value);
        /*0x3cf6130*/ bool get_useMaxVisibleDescender();
        /*0x3cf6138*/ void set_useMaxVisibleDescender(bool value);
        /*0x3cf6168*/ int get_pageToDisplay();
        /*0x3cf6170*/ void set_pageToDisplay(int value);
        /*0x3cf61a0*/ UnityEngine.Vector4 get_margin();
        /*0x3cf61b4*/ void set_margin(UnityEngine.Vector4 value);
        /*0x3cf624c*/ TMPro.TMP_TextInfo get_textInfo();
        /*0x3cf6254*/ bool get_havePropertiesChanged();
        /*0x3cf625c*/ void set_havePropertiesChanged(bool value);
        /*0x3cf6284*/ bool get_isUsingLegacyAnimationComponent();
        /*0x3cf628c*/ void set_isUsingLegacyAnimationComponent(bool value);
        /*0x3cf6294*/ UnityEngine.Transform get_transform();
        /*0x3cf6340*/ UnityEngine.RectTransform get_rectTransform();
        /*0x3cf63ec*/ bool get_autoSizeTextContainer();
        /*0x3cf63f4*/ void set_autoSizeTextContainer(bool value);
        /*0x3cf63fc*/ UnityEngine.Mesh get_mesh();
        /*0x3cf6404*/ bool get_isVolumetricText();
        /*0x3cf640c*/ void set_isVolumetricText(bool value);
        /*0x3cf6474*/ UnityEngine.Bounds get_bounds();
        /*0x3cf6524*/ UnityEngine.Bounds get_textBounds();
        /*0x3cf6b00*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3cf6bb0*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x3cf6c60*/ TMPro.TMP_SpriteAnimator get_spriteAnimator();
        /*0x3cf6d74*/ float get_flexibleHeight();
        /*0x3cf6d7c*/ float get_flexibleWidth();
        /*0x3cf6d84*/ float get_minWidth();
        /*0x3cf6d8c*/ float get_minHeight();
        /*0x3cf6d94*/ float get_maxWidth();
        /*0x3cf6d9c*/ float get_maxHeight();
        /*0x3cf6da4*/ UnityEngine.UI.LayoutElement get_layoutElement();
        /*0x3cf6e50*/ float get_preferredWidth();
        /*0x3cf6fa8*/ float get_preferredHeight();
        /*0x3cf713c*/ float get_renderedWidth();
        /*0x3cf7184*/ float get_renderedHeight();
        /*0x3cf71cc*/ int get_layoutPriority();
        /*0x3cf71d4*/ void LoadFontAsset();
        /*0x3cf71d8*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x3cf71dc*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x3cf71e4*/ void SetFontBaseMaterial(UnityEngine.Material mat);
        /*0x3cf71e8*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x3cf71f0*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x3cf71f4*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x3cf71fc*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x3cf72bc*/ void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient);
        /*0x3cf7378*/ void SetTextSortingOrder(TMPro.VertexSortingOrder order);
        /*0x3cf737c*/ void SetTextSortingOrder(int[] order);
        /*0x3cf7380*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x3cf7384*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x3cf7388*/ void SetOutlineThickness(float thickness);
        /*0x3cf738c*/ void SetShaderDepth();
        /*0x3cf7390*/ void SetCulling();
        /*0x3cf7394*/ void UpdateCulling();
        /*0x3cf7398*/ float GetPaddingForMaterial();
        /*0x3cf74b8*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x3cf75b8*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x3cf75c0*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x3cf75c4*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x3cf75c8*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x3cf75cc*/ void UpdateVertexData();
        /*0x3cf75d0*/ void SetVertices(UnityEngine.Vector3[] vertices);
        /*0x3cf75d4*/ void UpdateMeshPadding();
        /*0x3cf75d8*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x3cf7658*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x3cf76a8*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x3cf76ac*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x3cf76b0*/ void ParseInputText();
        /*0x3cf77b4*/ void PopulateTextBackingArray(string sourceText);
        /*0x3cf8154*/ void PopulateTextBackingArray(string sourceText, int start, int length);
        /*0x3cf824c*/ void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length);
        /*0x3cf8370*/ void PopulateTextBackingArray(char[] sourceText, int start, int length);
        /*0x3cf77cc*/ void PopulateTextProcessingArray();
        /*0x3cf96e0*/ void SetTextInternal(string sourceText);
        /*0x3cf972c*/ void SetText(string sourceText, bool syncTextInputBox);
        /*0x3cf97b4*/ void SetText(string sourceText, float arg0);
        /*0x3cf9b24*/ void SetText(string sourceText, float arg0, float arg1);
        /*0x3cf9b40*/ void SetText(string sourceText, float arg0, float arg1, float arg2);
        /*0x3cf9b58*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        /*0x3cf9b6c*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        /*0x3cf9b7c*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        /*0x3cf9b88*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        /*0x3cf97d4*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        /*0x3cf9e84*/ void SetText(System.Text.StringBuilder sourceText);
        /*0x3cf9ec8*/ void SetText(System.Text.StringBuilder sourceText, int start, int length);
        /*0x3cf9f24*/ void SetText(char[] sourceText);
        /*0x3cf9f98*/ void SetText(char[] sourceText, int start, int length);
        /*0x3cf9f9c*/ void SetCharArray(char[] sourceText);
        /*0x3cf9f3c*/ void SetCharArray(char[] sourceText, int start, int length);
        /*0x3cf4cc4*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x3cf8b1c*/ bool ReplaceOpeningStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cfa3b4*/ bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cf8f38*/ void ReplaceClosingStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cfa7d0*/ void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cf8480*/ bool InsertOpeningStyleTag(TMPro.TMP_Style style, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cf9320*/ void InsertClosingStyleTag(ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x3cfa2b0*/ int GetMarkupTagHashCode(int[] tagDefinition, int readIndex);
        /*0x3cf8a28*/ int GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, int readIndex);
        /*0x3cfabb8*/ int GetStyleHashCode(ref int[] text, int index, ref int closeIndex);
        /*0x3cf9fb4*/ int GetStyleHashCode(ref TMPro.TMP_Text.TextBackingContainer text, int index, ref int closeIndex);
        /*0x1f30ebc*/ void ResizeInternalArray<T>(ref T[] array);
        /*0x1f30ee8*/ void ResizeInternalArray<T>(ref T[] array, int size);
        /*0x3cf9b90*/ void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex);
        /*0x3cfac8c*/ void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex);
        /*0x3cf44b8*/ string InternalTextBackingArrayToString();
        /*0x3cfadb8*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x3cfadc0*/ UnityEngine.Vector2 GetPreferredValues();
        /*0x3cfae0c*/ UnityEngine.Vector2 GetPreferredValues(float width, float height);
        /*0x3cfafb4*/ UnityEngine.Vector2 GetPreferredValues(string text);
        /*0x3cfb0dc*/ UnityEngine.Vector2 GetPreferredValues(string text, float width, float height);
        /*0x3cf6e68*/ float GetPreferredWidth();
        /*0x3cfaeb8*/ float GetPreferredWidth(UnityEngine.Vector2 margin);
        /*0x3cf6fc0*/ float GetPreferredHeight();
        /*0x3cfaf14*/ float GetPreferredHeight(UnityEngine.Vector2 margin);
        /*0x3cfb1a0*/ UnityEngine.Vector2 GetRenderedValues();
        /*0x3cfb1c8*/ UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        /*0x3cf7160*/ float GetRenderedWidth();
        /*0x3cfb40c*/ float GetRenderedWidth(bool onlyVisibleCharacters);
        /*0x3cf71a8*/ float GetRenderedHeight();
        /*0x3cfb430*/ float GetRenderedHeight(bool onlyVisibleCharacters);
        /*0x3cfb454*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled);
        /*0x3d037f0*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x3d037fc*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x3cf6568*/ UnityEngine.Bounds GetTextBounds();
        /*0x3cfb1f0*/ UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters);
        /*0x3d03804*/ void AdjustLineOffset(int startIndex, int endIndex, float offset);
        /*0x3d039c0*/ void ResizeLineExtents(int size);
        /*0x3d03b64*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x3d03b6c*/ void ComputeMarginSize();
        /*0x3d03b70*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        /*0x3d0349c*/ void SaveWordWrappingState(ref TMPro.WordWrapState state, int index, int count);
        /*0x3d03124*/ int RestoreWordWrappingState(ref TMPro.WordWrapState state);
        /*0x3d04038*/ void SaveGlyphVertexInfo(float padding, float style_padding, UnityEngine.Color32 vertexColor);
        /*0x3d04bac*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor);
        /*0x3d05318*/ void FillCharacterVertexBuffers(int i, int index_X4);
        /*0x3d05a4c*/ void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric);
        /*0x3d06564*/ void FillSpriteVertexBuffers(int i, int index_X4);
        /*0x3d06c98*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor);
        /*0x3d07c3c*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor);
        /*0x3d08184*/ void LoadDefaultSettings();
        /*0x3d08430*/ void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset);
        /*0x3d08458*/ void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x3d07a88*/ void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x3d086a8*/ void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        /*0x3d0871c*/ TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        /*0x3d087c0*/ TMPro.TMP_TextElement GetTextElement(uint unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isUsingAlternativeTypeface);
        /*0x3d08bb8*/ void SetActiveSubMeshes(bool state);
        /*0x3d08bbc*/ void DestroySubMeshObjects();
        /*0x3d08bc0*/ void ClearMesh();
        /*0x3d08bc4*/ void ClearMesh(bool uploadGeometry);
        /*0x3d08bc8*/ string GetParsedText();
        /*0x3cf5b5c*/ bool IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent);
        /*0x3cf5a38*/ void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent);
        /*0x3d07be4*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
        /*0x3d08cbc*/ float PackUV(float x, float y);
        /*0x3d08d1c*/ void InternalUpdate();
        /*0x3d08d20*/ int HexToInt(char hex);
        /*0x3d08d4c*/ int GetUTF16(string text, int i);
        /*0x3cfa0c0*/ int GetUTF16(int[] text, int i);
        /*0x3d08df4*/ int GetUTF16(uint[] text, int i);
        /*0x3d08e9c*/ int GetUTF16(System.Text.StringBuilder text, int i);
        /*0x3cf8848*/ int GetUTF16(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x3d08f44*/ int GetUTF32(string text, int i);
        /*0x3cfa168*/ int GetUTF32(int[] text, int i);
        /*0x3d0907c*/ int GetUTF32(uint[] text, int i);
        /*0x3d091c4*/ int GetUTF32(System.Text.StringBuilder text, int i);
        /*0x3cf88f0*/ int GetUTF32(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x3d092fc*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
        /*0x3d09758*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        /*0x3d099a4*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
        /*0x3d09bc4*/ float ConvertToFloat(char[] chars, int startIndex, int length);
        /*0x3d09a50*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
        /*0x3cfd624*/ bool ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, int startIndex, ref int endIndex);

        struct CharacterSubstitution
        {
            /*0x10*/ int index;
            /*0x14*/ uint unicode;

            /*0x3d16adc*/ CharacterSubstitution(int index, uint unicode);
        }

        enum TextInputSources
        {
            TextInputBox = 0,
            SetText = 1,
            SetTextArray = 2,
            TextString = 3,
        }

        struct UnicodeChar
        {
            /*0x10*/ int unicode;
            /*0x14*/ int stringIndex;
            /*0x18*/ int length;
        }

        struct SpecialCharacter
        {
            /*0x10*/ TMPro.TMP_Character character;
            /*0x18*/ TMPro.TMP_FontAsset fontAsset;
            /*0x20*/ UnityEngine.Material material;
            /*0x28*/ int materialIndex;

            /*0x3d16ae4*/ SpecialCharacter(TMPro.TMP_Character character, int materialIndex);
        }

        struct TextBackingContainer
        {
            /*0x10*/ uint[] m_Array;
            /*0x18*/ int m_Count;

            /*0x3d16d54*/ TextBackingContainer(int size);
            /*0x3d16c30*/ int get_Capacity();
            /*0x3d16c48*/ int get_Count();
            /*0x3d16c50*/ void set_Count(int value);
            /*0x3d16c58*/ uint get_Item(int index);
            /*0x3d16c88*/ void set_Item(int index, uint value);
            /*0x3d16ce8*/ void Resize(int size);
        }

        class <>c
        {
            static /*0x0*/ TMPro.TMP_Text.<> <>9;
            static /*0x8*/ System.Action<TMPro.TMP_TextInfo> <>9__622_0;

            static /*0x3d16dc0*/ <>c();
            /*0x3d16e28*/ <>c();
            /*0x3d16e30*/ void <.ctor>b__622_0(TMPro.TMP_TextInfo <p0>);
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

        /*0x3d135f8*/ TMP_TextElement();
        /*0x3d16e34*/ TMPro.TextElementType get_elementType();
        /*0x3d16e3c*/ uint get_unicode();
        /*0x3d16e44*/ void set_unicode(uint value);
        /*0x3d16e4c*/ TMPro.TMP_Asset get_textAsset();
        /*0x3d16e54*/ void set_textAsset(TMPro.TMP_Asset value);
        /*0x3d16e5c*/ UnityEngine.TextCore.Glyph get_glyph();
        /*0x3d16e64*/ void set_glyph(UnityEngine.TextCore.Glyph value);
        /*0x3d16e6c*/ uint get_glyphIndex();
        /*0x3d16e74*/ void set_glyphIndex(uint value);
        /*0x3d16e7c*/ float get_scale();
        /*0x3d16e84*/ void set_scale(float value);
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

        /*0x3d10b10*/ TMP_TextElement_Legacy();
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

        static /*0x3d17e28*/ TMP_TextInfo();
        static /*0x1f36244*/ void Resize<T>(ref T[] array, int size);
        static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
        /*0x3d16e8c*/ TMP_TextInfo();
        /*0x3d16ff8*/ TMP_TextInfo(int characterCount);
        /*0x3d17168*/ TMP_TextInfo(TMPro.TMP_Text textComponent);
        /*0x3d17338*/ void Clear();
        /*0x3d1738c*/ void ClearAllData();
        /*0x3d174fc*/ void ClearMeshInfo(bool updateMesh);
        /*0x3d175b0*/ void ClearAllMeshInfo();
        /*0x3d17660*/ void ResetVertexLayout(bool isVolumetric);
        /*0x3d17718*/ void ClearUnusedVertices(TMPro.MaterialReference[] materials);
        /*0x3d177c8*/ void ClearLineInfo();
        /*0x3d17958*/ void ClearPageInfo();
        /*0x3d17a00*/ TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData();
    }

    class TMP_TextParsingUtilities
    {
        static string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ TMPro.TMP_TextParsingUtilities s_Instance;

        static /*0x3d17e94*/ TMP_TextParsingUtilities();
        static /*0x3d17f04*/ TMPro.TMP_TextParsingUtilities get_instance();
        static /*0x3d13acc*/ int GetHashCode(string s);
        static /*0x3d13584*/ int GetHashCodeCaseSensitive(string s);
        static /*0x3d17fd0*/ char ToLowerASCIIFast(char c);
        static /*0x3d17f5c*/ char ToUpperASCIIFast(char c);
        static /*0x3d18044*/ uint ToUpperASCIIFast(uint c);
        static /*0x3d180b8*/ uint ToLowerASCIIFast(uint c);
        static /*0x3d1812c*/ bool IsHighSurrogate(uint c);
        static /*0x3d18140*/ bool IsLowSurrogate(uint c);
        static /*0x3d18154*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
        /*0x3d17efc*/ TMP_TextParsingUtilities();
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

        /*0x3d18168*/ void Clear();
        /*0x3d18174*/ byte Add(TMPro.FontStyles style);
        /*0x3d18278*/ byte Remove(TMPro.FontStyles style);
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

        static /*0x1ffc854*/ void SetDefault(TMPro.TMP_TextProcessingStack<T> stack, T item);
        /*0x1f30ebc*/ TMP_TextProcessingStack(T[] stack);
        /*0x1f30b78*/ TMP_TextProcessingStack(int capacity);
        /*0x1f30bb4*/ TMP_TextProcessingStack(int capacity, int rolloverSize);
        /*0x1f2ffc8*/ int get_Count();
        /*0x1ffc854*/ T get_current();
        /*0x1f2ffc8*/ int get_rolloverSize();
        /*0x1f30b78*/ void set_rolloverSize(int value);
        /*0x1f309e4*/ void Clear();
        /*0x1ffc854*/ void SetDefault(T item);
        /*0x1ffc854*/ void Add(T item);
        /*0x1ffc854*/ T Remove();
        /*0x1ffc854*/ void Push(T item);
        /*0x1ffc854*/ T Pop();
        /*0x1ffc854*/ T Peek();
        /*0x1ffc854*/ T CurrentItem();
        /*0x1ffc854*/ T PreviousItem();
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

        /*0x3d183c4*/ CaretInfo(int index, TMPro.CaretPosition position);
    }

    class TMP_TextUtilities
    {
        static string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ UnityEngine.Vector3[] m_rectWorldCorners;

        static /*0x3d1b2b4*/ TMP_TextUtilities();
        static /*0x3d183cc*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d18b68*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, ref TMPro.CaretPosition cursor);
        static /*0x3d18d44*/ int FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d18ec4*/ int FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, int line, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x3d193bc*/ bool IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d194d8*/ int FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x3d18528*/ int FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x3d196dc*/ int FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d19ae8*/ int FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d1a1e0*/ int FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d1a338*/ int FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d1a66c*/ int FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x3d19234*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
        static /*0x3d1884c*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x3d1ad44*/ bool IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, ref UnityEngine.Vector3 intersectingPoint);
        static /*0x3d192f4*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
        static /*0x3d1aeb0*/ char ToLowerFast(char c);
        static /*0x3d1af24*/ char ToUpperFast(char c);
        static /*0x3d1af98*/ uint ToUpperASCIIFast(uint c);
        static /*0x3d1b00c*/ int GetHashCode(string s);
        static /*0x3d12618*/ int GetSimpleHashCode(string s);
        static /*0x3d1b0c8*/ uint GetSimpleHashCodeLowercase(string s);
        static /*0x3d1b184*/ int HexToInt(char hex);
        static /*0x3d1b1b0*/ int StringHexToInt(string s);

        struct LineSegment
        {
            /*0x10*/ UnityEngine.Vector3 Point1;
            /*0x1c*/ UnityEngine.Vector3 Point2;

            /*0x3d1b328*/ LineSegment(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
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

        static /*0x3d1c0b4*/ TMP_UpdateManager();
        static /*0x3d1b338*/ TMPro.TMP_UpdateManager get_instance();
        static /*0x3d1b5f4*/ void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x3d1b72c*/ void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        static /*0x3d1b864*/ void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        static /*0x3d1b99c*/ void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        static /*0x3d1bddc*/ void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x3d1bee4*/ void UnRegisterTextElementForRebuild(TMPro.TMP_Text element);
        /*0x3d1b3e8*/ TMP_UpdateManager();
        /*0x3d1b654*/ void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        /*0x3d1b78c*/ void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x3d1b8c4*/ void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x3d1b9fc*/ void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        /*0x3d1bad4*/ void OnCameraPreCull();
        /*0x3d1bad8*/ void DoRebuilds();
        /*0x3d1bf64*/ void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x3d1c00c*/ void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x3d1be3c*/ void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
    }

    class TMP_UpdateRegistry
    {
        static /*0x0*/ TMPro.TMP_UpdateRegistry s_Instance;
        /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        /*0x18*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        /*0x28*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;

        static /*0x3d1c228*/ TMPro.TMP_UpdateRegistry get_instance();
        static /*0x3d1c428*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x3d1c56c*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x3d1c9d8*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x3d1c2ac*/ TMP_UpdateRegistry();
        /*0x3d1c448*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x3d1c58c*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x3d1c6b0*/ void PerformUpdateForCanvasRendererObjects();
        /*0x3d1c970*/ void PerformUpdateForMeshRendererObjects();
        /*0x3d1ca08*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x3d1caf4*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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
            /*0x3d1cbe0*/ TexturePacker_JsonArray();

            struct SpriteFrame
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float w;
                /*0x1c*/ float h;

                /*0x3d1cbe8*/ string ToString();
            }

            struct SpriteSize
            {
                /*0x10*/ float w;
                /*0x14*/ float h;

                /*0x3d1cdf0*/ string ToString();
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

                /*0x3d1ce9c*/ SpriteDataObject();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 2B31235663AC66468ED0551CE52782FF84142F1CA2CD6829FBAC5B0026637A1B;
    static /*0xfc9*/ <PrivateImplementationDetails> 793691E33CF3E02E4A10AB25C24AAD443FEEBFB3A9E38DB9F34A3CD50DE91DAB;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=3846
    {
    }

    struct __StaticArrayInitTypeSize=4029
    {
    }
}
