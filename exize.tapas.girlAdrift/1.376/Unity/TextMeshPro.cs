class <Module>
{
}

namespace TMPro
{
    class FastAction
    {
        /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

        /*0xf2e090*/ FastAction();
        /*0xf2de78*/ void Add(System.Action rhs);
        /*0xf2df38*/ void Remove(System.Action rhs);
        /*0xf2dff8*/ void Call();
    }

    class FastAction<A>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

        FastAction();
        void Add(System.Action<A> rhs);
        void Remove(System.Action<A> rhs);
        void Call(A a);
    }

    class FastAction<A, B>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

        FastAction();
        void Add(System.Action<A, B> rhs);
        void Remove(System.Action<A, B> rhs);
        void Call(A a, B b);
    }

    class FastAction<A, B, C>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

        FastAction();
        void Add(System.Action<A, B, C> rhs);
        void Remove(System.Action<A, B, C> rhs);
        void Call(A a, B b, C c);
    }

    interface ITextPreprocessor
    {
        string PreprocessText(string text);
    }

    class MaterialReferenceManager
    {
        static /*0x0*/ TMPro.MaterialReferenceManager s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
        /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        /*0x28*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;

        static /*0xf2e150*/ TMPro.MaterialReferenceManager get_instance();
        static /*0xf2e314*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0xf2e3f8*/ void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset);
        static /*0xf2e4dc*/ void AddSpriteAsset(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        static /*0xf2e5e0*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
        static /*0xf2e678*/ void AddColorGradientPreset(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        static /*0xf2e804*/ bool TryGetFontAsset(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0xf2e8a0*/ bool TryGetSpriteAsset(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        static /*0xf2e93c*/ bool TryGetColorGradientPreset(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        static /*0xf2e9d8*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
        /*0xf2e1cc*/ MaterialReferenceManager();
        /*0xf2e334*/ void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset);
        /*0xf2e418*/ void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset);
        /*0xf2e50c*/ void AddSpriteAssetInternal(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        /*0xf2e610*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
        /*0xf2e6a8*/ void AddColorGradientPreset_Internal(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        /*0xf2e74c*/ bool Contains(TMPro.TMP_FontAsset font);
        /*0xf2e7a8*/ bool Contains(TMPro.TMP_SpriteAsset sprite);
        /*0xf2e834*/ bool TryGetFontAssetInternal(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        /*0xf2e8d0*/ bool TryGetSpriteAssetInternal(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        /*0xf2e96c*/ bool TryGetColorGradientPresetInternal(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        /*0xf2ea08*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
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

        static /*0xf2eaf0*/ bool Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset);
        static /*0xf2ebec*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        static /*0xf2edf8*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        /*0xf2ea74*/ MaterialReference(int index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
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
        /*0x18*/ bool m_hasChanged;
        /*0x1c*/ UnityEngine.Vector2 m_pivot;
        /*0x24*/ TMPro.TextContainerAnchors m_anchorPosition;
        /*0x28*/ UnityEngine.Rect m_rect;
        /*0x38*/ bool m_isDefaultWidth;
        /*0x39*/ bool m_isDefaultHeight;
        /*0x3a*/ bool m_isAutoFitting;
        /*0x40*/ UnityEngine.Vector3[] m_corners;
        /*0x48*/ UnityEngine.Vector3[] m_worldCorners;
        /*0x50*/ UnityEngine.Vector4 m_margins;
        /*0x60*/ UnityEngine.RectTransform m_rectTransform;
        /*0x68*/ TMPro.TextMeshPro m_textMeshPro;

        static /*0xf2fc0c*/ TextContainer();
        /*0xf2fb9c*/ TextContainer();
        /*0xf2efd0*/ bool get_hasChanged();
        /*0xf2efd8*/ void set_hasChanged(bool value);
        /*0xf2efe4*/ UnityEngine.Vector2 get_pivot();
        /*0xf2efec*/ void set_pivot(UnityEngine.Vector2 value);
        /*0xf2f284*/ TMPro.TextContainerAnchors get_anchorPosition();
        /*0xf2f28c*/ void set_anchorPosition(TMPro.TextContainerAnchors value);
        /*0xf2f340*/ UnityEngine.Rect get_rect();
        /*0xf2f34c*/ void set_rect(UnityEngine.Rect value);
        /*0xf2f3c8*/ UnityEngine.Vector2 get_size();
        /*0xf2f404*/ void set_size(UnityEngine.Vector2 value);
        /*0xf2f52c*/ float get_width();
        /*0xf2f538*/ void set_width(float value);
        /*0xf2f580*/ float get_height();
        /*0xf2f58c*/ void set_height(float value);
        /*0xf2f5d0*/ bool get_isDefaultWidth();
        /*0xf2f5d8*/ bool get_isDefaultHeight();
        /*0xf2f5e0*/ bool get_isAutoFitting();
        /*0xf2f5e8*/ void set_isAutoFitting(bool value);
        /*0xf2f5f4*/ UnityEngine.Vector3[] get_corners();
        /*0xf2f5fc*/ UnityEngine.Vector3[] get_worldCorners();
        /*0xf2f604*/ UnityEngine.Vector4 get_margins();
        /*0xf2f610*/ void set_margins(UnityEngine.Vector4 value);
        /*0xf2f66c*/ UnityEngine.RectTransform get_rectTransform();
        /*0xf2f700*/ TMPro.TextMeshPro get_textMeshPro();
        /*0xf2f794*/ void Awake();
        /*0xf2f85c*/ void OnEnable();
        /*0xf2f860*/ void OnDisable();
        /*0xf2f134*/ void OnContainerChanged();
        /*0xf2fa3c*/ void OnRectTransformDimensionsChange();
        /*0xf2f4ac*/ void SetRect(UnityEngine.Vector2 size);
        /*0xf2f864*/ void UpdateCorners();
        /*0xf2f2c8*/ UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor);
        /*0xf2f044*/ TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot);
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
        /*0x6c0*/ int _SortingLayer;
        /*0x6c4*/ int _SortingLayerID;
        /*0x6c8*/ int _SortingOrder;
        /*0x6d0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6d8*/ bool m_currentAutoSizeMode;
        /*0x6d9*/ bool m_hasFontAssetChanged;
        /*0x6dc*/ float m_previousLossyScaleY;
        /*0x6e0*/ UnityEngine.Renderer m_renderer;
        /*0x6e8*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x6f0*/ bool m_isFirstAllocation;
        /*0x6f4*/ int m_max_characters;
        /*0x6f8*/ int m_max_numberOfLines;
        /*0x700*/ TMPro.TMP_SubMesh[] m_subTextObjects;
        /*0x708*/ TMPro.MaskingTypes m_maskType;
        /*0x70c*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x750*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x758*/ bool m_isRegisteredForEvents;

        static /*0xf35f6c*/ TextMeshPro();
        /*0xf35eac*/ TextMeshPro();
        /*0xf2fc5c*/ int get_sortingLayerID();
        /*0xf2fd84*/ void set_sortingLayerID(int value);
        /*0xf2ff44*/ int get_sortingOrder();
        /*0xf2ffd8*/ void set_sortingOrder(int value);
        /*0xf30198*/ bool get_autoSizeTextContainer();
        /*0xf301a0*/ void set_autoSizeTextContainer(bool value);
        /*0xf30240*/ TMPro.TextContainer get_textContainer();
        /*0xf30248*/ UnityEngine.Transform get_transform();
        /*0xf2fcf0*/ UnityEngine.Renderer get_renderer();
        /*0xf302dc*/ UnityEngine.Mesh get_mesh();
        /*0xf3038c*/ UnityEngine.MeshFilter get_meshFilter();
        /*0xf30488*/ TMPro.MaskingTypes get_maskType();
        /*0xf30490*/ void set_maskType(TMPro.MaskingTypes value);
        /*0xf305e0*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords);
        /*0xf306c8*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, float softnessX, float softnessY);
        /*0xf30818*/ void SetVerticesDirty();
        /*0xf308c8*/ void SetLayoutDirty();
        /*0xf30998*/ void SetMaterialDirty();
        /*0xf309a8*/ void SetAllDirty();
        /*0xf309ec*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0xf30d30*/ void UpdateMaterial();
        /*0xf30e64*/ void UpdateMeshPadding();
        /*0xf30f64*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0xf30f78*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0xf30fe4*/ void ClearMesh(bool updateMesh);
        /*0xf310a4*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0xf31158*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0xf3120c*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0xf31224*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0xf313bc*/ void UpdateVertexData();
        /*0xf31554*/ void UpdateFontAsset();
        /*0xf31564*/ void CalculateLayoutInputHorizontal();
        /*0xf31568*/ void CalculateLayoutInputVertical();
        /*0xf3156c*/ void Awake();
        /*0xf31914*/ void OnEnable();
        /*0xf31a10*/ void OnDisable();
        /*0xf31abc*/ void OnDestroy();
        /*0xf31b88*/ void LoadFontAsset();
        /*0xf321f8*/ void UpdateEnvMapMatrix();
        /*0xf30498*/ void SetMask(TMPro.MaskingTypes maskType);
        /*0xf30628*/ void SetMaskCoordinates(UnityEngine.Vector4 coords);
        /*0xf30728*/ void SetMaskCoordinates(UnityEngine.Vector4 coords, float softX, float softY);
        /*0xf32474*/ void EnableMasking();
        /*0xf325ec*/ void DisableMasking();
        /*0xf3256c*/ void UpdateMask();
        /*0xf327a4*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0xf328b4*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0xf32a5c*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0xf32a94*/ UnityEngine.Material[] GetSharedMaterials();
        /*0xf32c24*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0xf32f8c*/ void SetOutlineThickness(float thickness);
        /*0xf330b8*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0xf331e0*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0xf326e0*/ void CreateMaterialInstance();
        /*0xf33308*/ void SetShaderDepth();
        /*0xf333f0*/ void SetCulling();
        /*0xf33698*/ void SetPerspectiveCorrection();
        /*0xf3371c*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0xf351ec*/ void ComputeMarginSize();
        /*0xf35310*/ void OnDidApplyAnimationProperties();
        /*0xf3532c*/ void OnTransformParentChanged();
        /*0xf3535c*/ void OnRectTransformDimensionsChange();
        /*0xf354d8*/ void InternalUpdate();
        /*0xf30ad4*/ void OnPreRenderObject();
        /*0x121f984*/ void GenerateTextMesh();
        /*0xf35824*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0xf358c0*/ void SetMeshFilters(bool state);
        /*0xf35a80*/ void SetActiveSubMeshes(bool state);
        /*0xf356f8*/ void SetActiveSubTextObjectRenderers(bool state);
        /*0xf35b88*/ void DestroySubMeshObjects();
        /*0xf2fe38*/ void UpdateSubMeshSortingLayerID(int id);
        /*0xf3008c*/ void UpdateSubMeshSortingOrder(int order);
        /*0xf35c64*/ UnityEngine.Bounds GetCompoundBounds();
        /*0xf35574*/ void UpdateSDFScale(float scaleDelta);
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
        /*0x6c0*/ bool m_isRebuildingLayout;
        /*0x6c8*/ UnityEngine.Coroutine m_DelayedGraphicRebuild;
        /*0x6d0*/ UnityEngine.Coroutine m_DelayedMaterialRebuild;
        /*0x6d8*/ UnityEngine.Rect m_ClipRect;
        /*0x6e8*/ bool m_ValidRect;
        /*0x6f0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6f8*/ bool m_hasFontAssetChanged;
        /*0x700*/ TMPro.TMP_SubMeshUI[] m_subTextObjects;
        /*0x708*/ float m_previousLossyScaleY;
        /*0x710*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x718*/ UnityEngine.CanvasRenderer m_canvasRenderer;
        /*0x720*/ UnityEngine.Canvas m_canvas;
        /*0x728*/ float m_CanvasScaleFactor;
        /*0x72c*/ bool m_isFirstAllocation;
        /*0x730*/ int m_max_characters;
        /*0x738*/ UnityEngine.Material m_baseMaterial;
        /*0x740*/ bool m_isScrollRegionSet;
        /*0x744*/ UnityEngine.Vector4 m_maskOffset;
        /*0x754*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x794*/ bool m_isRegisteredForEvents;

        static /*0xf3d178*/ TextMeshProUGUI();
        /*0xf3d0c0*/ TextMeshProUGUI();
        /*0xf36428*/ UnityEngine.Material get_materialForRendering();
        /*0xf36488*/ bool get_autoSizeTextContainer();
        /*0xf36490*/ void set_autoSizeTextContainer(bool value);
        /*0xf36530*/ UnityEngine.Mesh get_mesh();
        /*0xf36538*/ UnityEngine.CanvasRenderer get_canvasRenderer();
        /*0xf365cc*/ void CalculateLayoutInputHorizontal();
        /*0xf365d0*/ void CalculateLayoutInputVertical();
        /*0xf365d4*/ void SetVerticesDirty();
        /*0xf366b8*/ void SetLayoutDirty();
        /*0xf367a8*/ void SetMaterialDirty();
        /*0xf36894*/ void SetAllDirty();
        /*0xf368d8*/ System.Collections.IEnumerator DelayedGraphicRebuild();
        /*0xf36968*/ System.Collections.IEnumerator DelayedMaterialRebuild();
        /*0xf369f8*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0xf36d68*/ void UpdateSubObjectPivot();
        /*0xf36e3c*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0xf36f3c*/ void UpdateMaterial();
        /*0xf37028*/ UnityEngine.Vector4 get_maskOffset();
        /*0xf3703c*/ void set_maskOffset(UnityEngine.Vector4 value);
        /*0xf373b8*/ void RecalculateClipping();
        /*0xf373c0*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0xf375e0*/ void UpdateCulling();
        /*0xf377ac*/ void UpdateMeshPadding();
        /*0xf378ac*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0xf37978*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0xf37a14*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0xf37abc*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0xf37ba4*/ void ClearMesh();
        /*0xf37c94*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0xf37d48*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0xf37dfc*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0xf37e74*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0xf38054*/ void UpdateVertexData();
        /*0xf38230*/ void UpdateFontAsset();
        /*0xf38240*/ void Awake();
        /*0xf385c8*/ void OnEnable();
        /*0xf3885c*/ void OnDisable();
        /*0xf38a00*/ void OnDestroy();
        /*0xf38b5c*/ void LoadFontAsset();
        /*0xf386f8*/ UnityEngine.Canvas GetCanvas();
        /*0xf3911c*/ void UpdateEnvMapMatrix();
        /*0xf39398*/ void EnableMasking();
        /*0xf3953c*/ void DisableMasking();
        /*0xf37068*/ void UpdateMask();
        /*0xf39540*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0xf39684*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0xf39834*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0xf3986c*/ UnityEngine.Material[] GetSharedMaterials();
        /*0xf399fc*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0xf39da8*/ void SetOutlineThickness(float thickness);
        /*0xf39f6c*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0xf3a09c*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0xf3a1cc*/ void SetShaderDepth();
        /*0xf3a2f0*/ void SetCulling();
        /*0xf3a5bc*/ void SetPerspectiveCorrection();
        /*0xf3a640*/ void SetMeshArrays(int size);
        /*0xf3a6a4*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0xf3c2a8*/ void ComputeMarginSize();
        /*0xf3c3cc*/ void OnDidApplyAnimationProperties();
        /*0xf3c404*/ void OnCanvasHierarchyChanged();
        /*0xf3c51c*/ void OnTransformParentChanged();
        /*0xf3c560*/ void OnRectTransformDimensionsChange();
        /*0xf3c75c*/ void InternalUpdate();
        /*0xf36ae0*/ void OnPreRenderCanvas();
        /*0x1049ec0*/ void GenerateTextMesh();
        /*0xf3ca08*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0xf3caa4*/ void SetActiveSubMeshes(bool state);
        /*0xf3cbac*/ void DestroySubMeshObjects();
        /*0xf3cc88*/ UnityEngine.Bounds GetCompoundBounds();
        /*0xf3ced0*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0xf3c7f8*/ void UpdateSDFScale(float scaleDelta);

        class <DelayedGraphicRebuild>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0xf36940*/ <DelayedGraphicRebuild>d__18(int <>1__state);
            /*0xf3d634*/ void System.IDisposable.Dispose();
            /*0xf3d638*/ bool MoveNext();
            /*0xf3d6f0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xf3d6f8*/ void System.Collections.IEnumerator.Reset();
            /*0xf3d738*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DelayedMaterialRebuild>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0xf369d0*/ <DelayedMaterialRebuild>d__19(int <>1__state);
            /*0xf3d740*/ void System.IDisposable.Dispose();
            /*0xf3d744*/ bool MoveNext();
            /*0xf3d804*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xf3d80c*/ void System.Collections.IEnumerator.Reset();
            /*0xf3d84c*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0xf3de8c*/ TMPro_EventManager();
        static /*0xf3d854*/ void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat);
        static /*0xf3d8e4*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0xf3d974*/ void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0xf3da04*/ void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0xf3da94*/ void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial);
        static /*0xf3db2c*/ void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged);
        static /*0xf3dbac*/ void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj);
        static /*0xf3dc2c*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        static /*0xf3dcac*/ void ON_TMP_SETTINGS_CHANGED();
        static /*0xf3dd0c*/ void ON_RESOURCES_LOADED();
        static /*0xf3dd6c*/ void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0xf3ddfc*/ void ON_COMPUTE_DT_EVENT(object Sender, TMPro.Compute_DT_EventArgs e);
    }

    class Compute_DT_EventArgs
    {
        /*0x10*/ TMPro.Compute_DistanceTransform_EventTypes EventType;
        /*0x14*/ float ProgressPercentage;
        /*0x18*/ UnityEngine.Color[] Colors;

        /*0xf3e188*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, float progress);
        /*0xf3e1c0*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors);
    }

    class TMPro_ExtensionMethods
    {
        static /*0xf3e1f0*/ int[] ToIntArray(string text);
        static /*0xf3e2a4*/ string ArrayToString(char[] chars);
        static /*0xf3e350*/ string IntToString(int[] unicodes);
        static /*0xf3e400*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
        static /*0xf3e4d8*/ string IntToString(int[] unicodes, int start, int length);
        static int FindInstanceID<T>(System.Collections.Generic.List<T> list, T target);
        static /*0xf3e5f0*/ bool Compare(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0xf3e600*/ bool CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0xf3e610*/ bool Compare(UnityEngine.Color a, UnityEngine.Color b);
        static /*0xf3e640*/ bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b);
        static /*0xf3e668*/ UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0xf3e728*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0xf3e7e8*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, float tint);
        static /*0xf3e8c4*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
        static /*0xf3e8d0*/ bool Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, int accuracy);
        static /*0xf3e964*/ bool Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, int accuracy);
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

        static /*0x1029fc4*/ TMP_Math();
        static /*0x1029f80*/ bool Approximately(float a, float b);
        static /*0x1029fb0*/ int Mod(int a, int b);
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

        /*0x102a030*/ VertexGradient(UnityEngine.Color color);
        /*0x102a054*/ VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
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

        /*0x102a070*/ void SetLinkID(char[] text, int startIndex, int length);
        /*0x102a144*/ string GetLinkText();
        /*0x102a220*/ string GetLinkID();
    }

    struct TMP_WordInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int firstCharacterIndex;
        /*0x1c*/ int lastCharacterIndex;
        /*0x20*/ int characterCount;

        /*0x102a2c8*/ string GetWord();
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

        static /*0x102a65c*/ Extents();
        /*0x102a3a4*/ Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x102a3b0*/ string ToString();
    }

    struct Mesh_Extents
    {
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        /*0x102a6f0*/ Mesh_Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x102a6fc*/ string ToString();
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

        /*0x102a9d0*/ TMP_Asset();
        /*0x102a9a8*/ int get_instanceID();
    }

    class TMP_Character : TMPro.TMP_TextElement
    {
        /*0x102a9d8*/ TMP_Character();
        /*0x102aa00*/ TMP_Character(uint unicode, UnityEngine.TextCore.Glyph glyph);
        /*0x102aa54*/ TMP_Character(uint unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
        /*0x102aab4*/ TMP_Character(uint unicode, uint glyphIndex);
    }

    struct TMP_Vertex
    {
        static /*0x0*/ TMPro.TMP_Vertex k_Zero;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector2 uv;
        /*0x24*/ UnityEngine.Vector2 uv2;
        /*0x2c*/ UnityEngine.Vector2 uv4;
        /*0x34*/ UnityEngine.Color32 color;

        static /*0x102ab5c*/ TMP_Vertex();
        static /*0x102aaf4*/ TMPro.TMP_Vertex get_zero();
    }

    struct TMP_Offset
    {
        static /*0x0*/ TMPro.TMP_Offset k_ZeroOffset;
        /*0x10*/ float m_Left;
        /*0x14*/ float m_Right;
        /*0x18*/ float m_Top;
        /*0x1c*/ float m_Bottom;

        static /*0x102aeb4*/ TMP_Offset();
        static /*0x102abc0*/ TMPro.TMP_Offset get_zero();
        static /*0x102ac34*/ bool op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x102ac64*/ bool op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x102ad1c*/ TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, float b);
        /*0x102ac1c*/ TMP_Offset(float left, float right, float top, float bottom);
        /*0x102ac28*/ TMP_Offset(float horizontal, float vertical);
        /*0x102ab60*/ float get_left();
        /*0x102ab68*/ void set_left(float value);
        /*0x102ab70*/ float get_right();
        /*0x102ab78*/ void set_right(float value);
        /*0x102ab80*/ float get_top();
        /*0x102ab88*/ void set_top(float value);
        /*0x102ab90*/ float get_bottom();
        /*0x102ab98*/ void set_bottom(float value);
        /*0x102aba0*/ float get_horizontal();
        /*0x102aba8*/ void set_horizontal(float value);
        /*0x102abb0*/ float get_vertical();
        /*0x102abb8*/ void set_vertical(float value);
        /*0x102ad30*/ int GetHashCode();
        /*0x102ad94*/ bool Equals(object obj);
        /*0x102ae0c*/ bool Equals(TMPro.TMP_Offset other);
    }

    struct HighlightState
    {
        /*0x10*/ UnityEngine.Color32 color;
        /*0x14*/ TMPro.TMP_Offset padding;

        static /*0x102af0c*/ bool op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        static /*0x102afd4*/ bool op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        /*0x102aefc*/ HighlightState(UnityEngine.Color32 color, TMPro.TMP_Offset padding);
        /*0x102b01c*/ int GetHashCode();
        /*0x102b088*/ bool Equals(object obj);
        /*0x102b108*/ bool Equals(TMPro.HighlightState other);
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

        static /*0x102b358*/ TMP_ColorGradient();
        /*0x102b1ac*/ TMP_ColorGradient();
        /*0x102b248*/ TMP_ColorGradient(UnityEngine.Color color);
        /*0x102b2b4*/ TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    class TMP_Compatibility
    {
        static /*0x102b3a4*/ TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue);

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
        bool get_ignoreTimeScale();
        float get_duration();
        bool ValidTarget();
    }

    struct ColorTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.ColorTween.ColorTweenCallback m_Target;
        /*0x18*/ UnityEngine.Color m_StartColor;
        /*0x28*/ UnityEngine.Color m_TargetColor;
        /*0x38*/ TMPro.ColorTween.ColorTweenMode m_TweenMode;
        /*0x3c*/ float m_Duration;
        /*0x40*/ bool m_IgnoreTimeScale;

        /*0x102b3c8*/ UnityEngine.Color get_startColor();
        /*0x102b3d4*/ void set_startColor(UnityEngine.Color value);
        /*0x102b3e0*/ UnityEngine.Color get_targetColor();
        /*0x102b3ec*/ void set_targetColor(UnityEngine.Color value);
        /*0x102b3f8*/ TMPro.ColorTween.ColorTweenMode get_tweenMode();
        /*0x102b400*/ void set_tweenMode(TMPro.ColorTween.ColorTweenMode value);
        /*0x102b408*/ float get_duration();
        /*0x102b410*/ void set_duration(float value);
        /*0x102b418*/ bool get_ignoreTimeScale();
        /*0x102b420*/ void set_ignoreTimeScale(bool value);
        /*0x102b42c*/ void TweenValue(float floatPercentage);
        /*0x102b518*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
        /*0x102b5e8*/ bool GetIgnoreTimescale();
        /*0x102b5f0*/ float GetDuration();
        /*0x102b508*/ bool ValidTarget();

        enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2,
        }

        class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
        {
            /*0x102b5a0*/ ColorTweenCallback();
        }
    }

    struct FloatTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.FloatTween.FloatTweenCallback m_Target;
        /*0x18*/ float m_StartValue;
        /*0x1c*/ float m_TargetValue;
        /*0x20*/ float m_Duration;
        /*0x24*/ bool m_IgnoreTimeScale;

        /*0x102b5f8*/ float get_startValue();
        /*0x102b600*/ void set_startValue(float value);
        /*0x102b608*/ float get_targetValue();
        /*0x102b610*/ void set_targetValue(float value);
        /*0x102b618*/ float get_duration();
        /*0x102b620*/ void set_duration(float value);
        /*0x102b628*/ bool get_ignoreTimeScale();
        /*0x102b630*/ void set_ignoreTimeScale(bool value);
        /*0x102b63c*/ void TweenValue(float floatPercentage);
        /*0x102b6d8*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
        /*0x102b7a8*/ bool GetIgnoreTimescale();
        /*0x102b7b0*/ float GetDuration();
        /*0x102b6c8*/ bool ValidTarget();

        class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
        {
            /*0x102b760*/ FloatTweenCallback();
        }
    }

    class TweenRunner<T>
    {
        /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
        /*0x0*/ System.Collections.IEnumerator m_Tween;

        static System.Collections.IEnumerator Start(T tweenInfo);
        TweenRunner();
        void Init(UnityEngine.MonoBehaviour coroutineContainer);
        void StartTween(T info);
        void StopTween();

        class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T tweenInfo;
            /*0x0*/ float <elapsedTime>5__2;

            <Start>d__2(int <>1__state);
            void System.IDisposable.Dispose();
            bool MoveNext();
            object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            void System.Collections.IEnumerator.Reset();
            object System.Collections.IEnumerator.get_Current();
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

        static /*0x102da28*/ TMP_DefaultControls();
        static /*0x102b7b8*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size);
        static /*0x102b860*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent);
        static /*0x102ba20*/ void SetDefaultTextValues(TMPro.TMP_Text lbl);
        static /*0x102baa8*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
        static /*0x102b920*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
        static /*0x102bab8*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
        static /*0x102bb9c*/ UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x102be60*/ UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x102c120*/ UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x102c1c0*/ UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x102c9c0*/ UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources);

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
        /*0xf8*/ UnityEngine.RectTransform m_Template;
        /*0x100*/ TMPro.TMP_Text m_CaptionText;
        /*0x108*/ UnityEngine.UI.Image m_CaptionImage;
        /*0x110*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x118*/ TMPro.TMP_Text m_ItemText;
        /*0x120*/ UnityEngine.UI.Image m_ItemImage;
        /*0x128*/ int m_Value;
        /*0x130*/ TMPro.TMP_Dropdown.OptionDataList m_Options;
        /*0x138*/ TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;
        /*0x140*/ float m_AlphaFadeSpeed;
        /*0x148*/ UnityEngine.GameObject m_Dropdown;
        /*0x150*/ UnityEngine.GameObject m_Blocker;
        /*0x158*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> m_Items;
        /*0x160*/ TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner;
        /*0x168*/ bool validTemplate;
        /*0x170*/ UnityEngine.Coroutine m_Coroutine;

        static /*0x10307e8*/ TMP_Dropdown();
        static T GetOrAddComponent<T>(UnityEngine.GameObject go);
        /*0x102dcf8*/ TMP_Dropdown();
        /*0x102dab8*/ UnityEngine.RectTransform get_template();
        /*0x102d7b4*/ void set_template(UnityEngine.RectTransform value);
        /*0x102dac0*/ TMPro.TMP_Text get_captionText();
        /*0x102d7bc*/ void set_captionText(TMPro.TMP_Text value);
        /*0x102dac8*/ UnityEngine.UI.Image get_captionImage();
        /*0x102dad0*/ void set_captionImage(UnityEngine.UI.Image value);
        /*0x102dad8*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x102dae0*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x102dae8*/ TMPro.TMP_Text get_itemText();
        /*0x102d7c4*/ void set_itemText(TMPro.TMP_Text value);
        /*0x102daf0*/ UnityEngine.UI.Image get_itemImage();
        /*0x102daf8*/ void set_itemImage(UnityEngine.UI.Image value);
        /*0x102d7cc*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
        /*0x102db00*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        /*0x102db1c*/ TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged();
        /*0x102db24*/ void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value);
        /*0x102db2c*/ float get_alphaFadeSpeed();
        /*0x102db34*/ void set_alphaFadeSpeed(float value);
        /*0x102db3c*/ int get_value();
        /*0x102db44*/ void set_value(int value);
        /*0x102dc90*/ void SetValueWithoutNotify(int input);
        /*0x102db4c*/ void SetValue(int value, bool sendCallback);
        /*0x102dc98*/ bool get_IsExpanded();
        /*0x102dec4*/ void Awake();
        /*0x102dfc0*/ void Start();
        /*0x102e054*/ void OnDisable();
        /*0x102d7f0*/ void RefreshShownValue();
        /*0x102e280*/ void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options);
        /*0x102e2e8*/ void AddOptions(System.Collections.Generic.List<string> options);
        /*0x102e468*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
        /*0x102e5e8*/ void ClearOptions();
        /*0x102e698*/ void SetupTemplate();
        /*0x102ecf4*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x102f950*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x102f954*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x102ecf8*/ void Show();
        /*0x102fe88*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
        /*0x1030354*/ void DestroyBlocker(UnityEngine.GameObject blocker);
        /*0x10303ac*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
        /*0x1030418*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
        /*0x1030470*/ TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate);
        /*0x10304dc*/ void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item);
        /*0x102fa74*/ TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, bool selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items);
        /*0x10304e0*/ void AlphaFadeList(float duration, float alpha);
        /*0x102fd64*/ void AlphaFadeList(float duration, float start, float end);
        /*0x1030560*/ void SetAlpha(float alpha);
        /*0x102f958*/ void Hide();
        /*0x1030614*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
        /*0x102e0e8*/ void ImmediateDestroyDropdownList();
        /*0x10306b4*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

        class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x18*/ TMPro.TMP_Text m_Text;
            /*0x20*/ UnityEngine.UI.Image m_Image;
            /*0x28*/ UnityEngine.RectTransform m_RectTransform;
            /*0x30*/ UnityEngine.UI.Toggle m_Toggle;

            /*0x10309c8*/ DropdownItem();
            /*0x1030860*/ TMPro.TMP_Text get_text();
            /*0x1030868*/ void set_text(TMPro.TMP_Text value);
            /*0x1030870*/ UnityEngine.UI.Image get_image();
            /*0x1030878*/ void set_image(UnityEngine.UI.Image value);
            /*0x1030880*/ UnityEngine.RectTransform get_rectTransform();
            /*0x1030888*/ void set_rectTransform(UnityEngine.RectTransform value);
            /*0x1030890*/ UnityEngine.UI.Toggle get_toggle();
            /*0x1030898*/ void set_toggle(UnityEngine.UI.Toggle value);
            /*0x10308a0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x103091c*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class OptionData
        {
            /*0x10*/ string m_Text;
            /*0x18*/ UnityEngine.Sprite m_Image;

            /*0x102d7e8*/ OptionData();
            /*0x102e440*/ OptionData(string text);
            /*0x102e5c0*/ OptionData(UnityEngine.Sprite image);
            /*0x10309f0*/ OptionData(string text, UnityEngine.Sprite image);
            /*0x10309d0*/ string get_text();
            /*0x10309d8*/ void set_text(string value);
            /*0x10309e0*/ UnityEngine.Sprite get_image();
            /*0x10309e8*/ void set_image(UnityEngine.Sprite value);
        }

        class OptionDataList
        {
            /*0x10*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;

            /*0x102ddfc*/ OptionDataList();
            /*0x1030a1c*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
            /*0x1030a24*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        }

        class DropdownEvent : UnityEngine.Events.UnityEvent<int>
        {
            /*0x102de7c*/ DropdownEvent();
        }

        class <>c__DisplayClass69_0
        {
            /*0x10*/ TMPro.TMP_Dropdown.DropdownItem item;
            /*0x18*/ TMPro.TMP_Dropdown <>4__this;

            /*0x102fa6c*/ <>c__DisplayClass69_0();
            /*0x1030a2c*/ void <Show>b__0(bool x);
        }

        class <DelayedDestroyDropdownList>d__81 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delay;
            /*0x28*/ TMPro.TMP_Dropdown <>4__this;

            /*0x103068c*/ <DelayedDestroyDropdownList>d__81(int <>1__state);
            /*0x1030a50*/ void System.IDisposable.Dispose();
            /*0x1030a54*/ bool MoveNext();
            /*0x1030b00*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1030b08*/ void System.Collections.IEnumerator.Reset();
            /*0x1030b48*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum AtlasPopulationMode
    {
        Static = 0,
        Dynamic = 1,
    }

    class TMP_FontAsset : TMPro.TMP_Asset
    {
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
        /*0x40*/ UnityEngine.Font m_SourceFontFile;
        /*0x48*/ TMPro.AtlasPopulationMode m_AtlasPopulationMode;
        /*0x50*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
        /*0xb0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
        /*0xb8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
        /*0xc0*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharacterTable;
        /*0xc8*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> m_CharacterLookupDictionary;
        /*0xd0*/ UnityEngine.Texture2D m_AtlasTexture;
        /*0xd8*/ UnityEngine.Texture2D[] m_AtlasTextures;
        /*0xe0*/ int m_AtlasTextureIndex;
        /*0xe4*/ bool m_IsMultiAtlasTexturesEnabled;
        /*0xe5*/ bool m_ClearDynamicDataOnBuild;
        /*0xe8*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
        /*0xf0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
        /*0xf8*/ TMPro.FaceInfo_Legacy m_fontInfo;
        /*0x100*/ UnityEngine.Texture2D atlas;
        /*0x108*/ int m_AtlasWidth;
        /*0x10c*/ int m_AtlasHeight;
        /*0x110*/ int m_AtlasPadding;
        /*0x114*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
        /*0x118*/ System.Collections.Generic.List<TMPro.TMP_Glyph> m_glyphInfoList;
        /*0x120*/ TMPro.KerningTable m_KerningTable;
        /*0x128*/ TMPro.TMP_FontFeatureTable m_FontFeatureTable;
        /*0x130*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> fallbackFontAssets;
        /*0x138*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> m_FallbackFontAssetTable;
        /*0x140*/ TMPro.FontAssetCreationSettings m_CreationSettings;
        /*0x198*/ TMPro.TMP_FontWeightPair[] m_FontWeightTable;
        /*0x1a0*/ TMPro.TMP_FontWeightPair[] fontWeights;
        /*0x1a8*/ float normalStyle;
        /*0x1ac*/ float normalSpacingOffset;
        /*0x1b0*/ float boldStyle;
        /*0x1b4*/ float boldSpacing;
        /*0x1b8*/ byte italicStyle;
        /*0x1b9*/ byte tabSize;
        /*0x1ba*/ bool IsFontAssetLookupTablesDirty;
        /*0x1c0*/ System.Collections.Generic.HashSet<int> FallbackSearchQueryLookup;
        /*0x1c8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
        /*0x1d0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
        /*0x1d8*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
        /*0x1e0*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
        /*0x1e8*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
        /*0x1f0*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
        /*0x1f8*/ System.Collections.Generic.List<TMPro.TMP_Character> m_CharactersToAdd;
        /*0x200*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
        /*0x208*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
        /*0x210*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

        static /*0x1039100*/ TMP_FontAsset();
        static /*0x1030fdc*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font);
        static /*0x1031058*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x1034fb8*/ string GetCharacters(TMPro.TMP_FontAsset fontAsset);
        static /*0x1035098*/ int[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset);
        static /*0x1035294*/ void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x10353c8*/ void UpdateFontFeaturesForFontAssetsInQueue();
        static /*0x1035858*/ void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x103598c*/ void UpdateAtlasTexturesForFontAssetsInQueue();
        /*0x1038d6c*/ TMP_FontAsset();
        /*0x1030b50*/ string get_version();
        /*0x1030b58*/ void set_version(string value);
        /*0x1030b60*/ UnityEngine.Font get_sourceFontFile();
        /*0x1030b68*/ void set_sourceFontFile(UnityEngine.Font value);
        /*0x1030b70*/ TMPro.AtlasPopulationMode get_atlasPopulationMode();
        /*0x1030b78*/ void set_atlasPopulationMode(TMPro.AtlasPopulationMode value);
        /*0x1030b80*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x1030b90*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x1030ba8*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
        /*0x1030bb0*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
        /*0x1030bb8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
        /*0x1030e14*/ System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable();
        /*0x1030e1c*/ void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value);
        /*0x1030e24*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> get_characterLookupTable();
        /*0x1030e48*/ UnityEngine.Texture2D get_atlasTexture();
        /*0x1030ed8*/ UnityEngine.Texture2D[] get_atlasTextures();
        /*0x1030ee0*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
        /*0x1030ee8*/ int get_atlasTextureCount();
        /*0x1030ef4*/ bool get_isMultiAtlasTexturesEnabled();
        /*0x1030efc*/ void set_isMultiAtlasTexturesEnabled(bool value);
        /*0x1030f08*/ bool get_clearDynamicDataOnBuild();
        /*0x1030f10*/ void set_clearDynamicDataOnBuild(bool value);
        /*0x1030f1c*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
        /*0x1030f24*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x1030f2c*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
        /*0x1030f34*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x1030f3c*/ TMPro.FaceInfo_Legacy get_fontInfo();
        /*0x1030f44*/ int get_atlasWidth();
        /*0x1030f4c*/ void set_atlasWidth(int value);
        /*0x1030f54*/ int get_atlasHeight();
        /*0x1030f5c*/ void set_atlasHeight(int value);
        /*0x1030f64*/ int get_atlasPadding();
        /*0x1030f6c*/ void set_atlasPadding(int value);
        /*0x1030f74*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
        /*0x1030f7c*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
        /*0x1030f84*/ TMPro.TMP_FontFeatureTable get_fontFeatureTable();
        /*0x1030f8c*/ void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value);
        /*0x1030f94*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable();
        /*0x1030f9c*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        /*0x1030fa4*/ TMPro.FontAssetCreationSettings get_creationSettings();
        /*0x1030fb4*/ void set_creationSettings(TMPro.FontAssetCreationSettings value);
        /*0x1030fcc*/ TMPro.TMP_FontWeightPair[] get_fontWeightTable();
        /*0x1030fd4*/ void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value);
        /*0x103157c*/ void Awake();
        /*0x1030bdc*/ void ReadFontAssetDefinition();
        /*0x1032258*/ void InitializeDictionaryLookupTables();
        /*0x103257c*/ void InitializeGlyphLookupDictionary();
        /*0x1032804*/ void InitializeCharacterLookupDictionary();
        /*0x1032a2c*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
        /*0x1032278*/ void AddSynthesizedCharactersAndFaceMetrics();
        /*0x1032f40*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
        /*0x1033194*/ void AddCharacterToLookupCache(uint unicode, TMPro.TMP_Character character);
        /*0x103324c*/ void SortCharacterTable();
        /*0x1033388*/ void SortGlyphTable();
        /*0x10334c4*/ void SortFontFeatureTable();
        /*0x10336c8*/ void SortAllTables();
        /*0x10336f0*/ bool HasCharacter(int character);
        /*0x1033750*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
        /*0x1034548*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
        /*0x1034764*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
        /*0x103490c*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
        /*0x1034f04*/ bool HasCharacters(string text);
        /*0x103517c*/ uint GetGlyphIndex(uint unicode);
        /*0x1035b04*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
        /*0x1035b24*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
        /*0x1036be0*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
        /*0x1036c00*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
        /*0x1033c10*/ bool TryAddCharacterInternal(uint unicode, ref TMPro.TMP_Character character);
        /*0x1037a24*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref TMPro.TMP_Character character);
        /*0x1035b00*/ void TryAddGlyphsToAtlasTextures();
        /*0x1036754*/ bool TryAddGlyphsToNewAtlasTexture();
        /*0x10377ec*/ void SetupNewAtlasTexture();
        /*0x1037fd8*/ void UpdateAtlasTexture();
        /*0x1035540*/ void UpdateGlyphAdjustmentRecords();
        /*0x10382c8*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
        /*0x10385b8*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
        /*0x10385bc*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
        void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
        /*0x10385c0*/ void ClearFontAssetData(bool setAtlasSizeToZero);
        /*0x1038bc8*/ void ClearFontAssetDataInternal();
        /*0x1038be4*/ void UpdateFontAssetData();
        /*0x10385f0*/ void ClearFontAssetTables();
        /*0x1038804*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
        /*0x1031604*/ void UpgradeFontAsset();
        /*0x1032bf4*/ void UpgradeGlyphAdjustmentTableToFontFeatureTable();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Character, uint> <>9__124_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__125_0;

            static /*0x10393e0*/ <>c();
            /*0x1039444*/ <>c();
            /*0x103944c*/ uint <SortCharacterTable>b__124_0(TMPro.TMP_Character c);
            /*0x1039464*/ uint <SortGlyphTable>b__125_0(UnityEngine.TextCore.Glyph c);
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

        /*0x103947c*/ FaceInfo_Legacy();
    }

    class TMP_Glyph : TMPro.TMP_TextElement_Legacy
    {
        static /*0x1039484*/ TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source);
        /*0x1039500*/ TMP_Glyph();
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

        /*0x1039508*/ FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode);
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

        /*0x10395dc*/ KerningPairKey(uint ascii_left, uint ascii_right);
    }

    struct GlyphValueRecord_Legacy
    {
        /*0x10*/ float xPlacement;
        /*0x14*/ float yPlacement;
        /*0x18*/ float xAdvance;
        /*0x1c*/ float yAdvance;

        static /*0x103964c*/ TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b);
        /*0x10395ec*/ GlyphValueRecord_Legacy(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
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

        static /*0x1039790*/ KerningPair();
        /*0x10396a0*/ KerningPair();
        /*0x10396c4*/ KerningPair(uint left, uint right, float offset);
        /*0x1039704*/ KerningPair(uint firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments);
        /*0x1039660*/ uint get_firstGlyph();
        /*0x1039668*/ void set_firstGlyph(uint value);
        /*0x1039670*/ TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments();
        /*0x103967c*/ uint get_secondGlyph();
        /*0x1039684*/ void set_secondGlyph(uint value);
        /*0x103968c*/ TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments();
        /*0x1039698*/ bool get_ignoreSpacingAdjustments();
        /*0x1039784*/ void ConvertLegacyKerningData();
    }

    class KerningTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;

        /*0x1039080*/ KerningTable();
        /*0x1039808*/ void AddKerningPair();
        /*0x10399dc*/ int AddKerningPair(uint first, uint second, float offset);
        /*0x1039b9c*/ int AddGlyphPairAdjustmentRecord(uint first, TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, TMPro.GlyphValueRecord_Legacy secondAdjustments);
        /*0x1039d9c*/ void RemoveKerningPair(int left, int right);
        /*0x1039ec4*/ void RemoveKerningPair(int index);
        /*0x1039f1c*/ void SortKerningPairs();

        class <>c__DisplayClass3_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x1039b94*/ <>c__DisplayClass3_0();
            /*0x103a108*/ bool <AddKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x1039d94*/ <>c__DisplayClass4_0();
            /*0x103a144*/ bool <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ int left;
            /*0x14*/ int right;

            /*0x1039ebc*/ <>c__DisplayClass5_0();
            /*0x103a180*/ bool <RemoveKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c
        {
            static /*0x0*/ TMPro.KerningTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.KerningPair, uint> <>9__7_0;
            static /*0x10*/ System.Func<TMPro.KerningPair, uint> <>9__7_1;

            static /*0x103a1bc*/ <>c();
            /*0x103a220*/ <>c();
            /*0x103a228*/ uint <SortKerningPairs>b__7_0(TMPro.KerningPair s);
            /*0x103a240*/ uint <SortKerningPairs>b__7_1(TMPro.KerningPair s);
        }
    }

    class TMP_FontUtilities
    {
        static /*0x0*/ System.Collections.Generic.List<int> k_searchedFontAssets;

        static /*0x103a258*/ TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x103a5cc*/ TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
        static /*0x103a33c*/ TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x103a5d0*/ TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
    }

    class TMP_FontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_FontAssetUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;
        static /*0x10*/ bool k_IsFontEngineInitialized;

        static /*0x103a6c0*/ TMP_FontAssetUtilities();
        static /*0x103a72c*/ TMPro.TMP_FontAssetUtilities get_instance();
        static /*0x103a784*/ TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x103a8dc*/ TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x103acb8*/ TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x103af10*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x103b21c*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        /*0x103a724*/ TMP_FontAssetUtilities();
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

        static /*0x103b4a4*/ TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b);
        /*0x1038d08*/ TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
        /*0x103b438*/ TMP_GlyphValueRecord(TMPro.GlyphValueRecord_Legacy valueRecord);
        /*0x103b444*/ TMP_GlyphValueRecord(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
        /*0x103b3f8*/ float get_xPlacement();
        /*0x103b400*/ void set_xPlacement(float value);
        /*0x103b408*/ float get_yPlacement();
        /*0x103b410*/ void set_yPlacement(float value);
        /*0x103b418*/ float get_xAdvance();
        /*0x103b420*/ void set_xAdvance(float value);
        /*0x103b428*/ float get_yAdvance();
        /*0x103b430*/ void set_yAdvance(float value);
    }

    struct TMP_GlyphAdjustmentRecord
    {
        /*0x10*/ uint m_GlyphIndex;
        /*0x14*/ TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

        /*0x1038d14*/ TMP_GlyphAdjustmentRecord(uint glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord);
        /*0x103b4e0*/ TMP_GlyphAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord);
        /*0x103b4b8*/ uint get_glyphIndex();
        /*0x103b4c0*/ void set_glyphIndex(uint value);
        /*0x103b4c8*/ TMPro.TMP_GlyphValueRecord get_glyphValueRecord();
        /*0x103b4d4*/ void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value);
    }

    class TMP_GlyphPairAdjustmentRecord
    {
        /*0x10*/ TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;
        /*0x24*/ TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;
        /*0x38*/ TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

        /*0x1038d24*/ TMP_GlyphPairAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord);
        /*0x1038214*/ TMP_GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord);
        /*0x103b534*/ TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord();
        /*0x103b548*/ void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x103b55c*/ TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord();
        /*0x103b570*/ void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x103b584*/ TMPro.FontFeatureLookupFlags get_featureLookupFlags();
        /*0x103b58c*/ void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value);
    }

    struct GlyphPairKey
    {
        /*0x10*/ uint firstGlyphIndex;
        /*0x14*/ uint secondGlyphIndex;
        /*0x18*/ uint key;

        /*0x103b594*/ GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex);
        /*0x1032f18*/ GlyphPairKey(TMPro.TMP_GlyphPairAdjustmentRecord record);
    }

    class TMP_FontFeatureTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        /*0x18*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

        /*0x1038150*/ TMP_FontFeatureTable();
        /*0x103b5a4*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
        /*0x103b5ac*/ void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value);
        /*0x10334dc*/ void SortGlyphPairAdjustmentRecords();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontFeatureTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0;
            static /*0x10*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1;

            static /*0x103b5b4*/ <>c();
            /*0x103b618*/ <>c();
            /*0x103b620*/ uint <SortGlyphPairAdjustmentRecords>b__6_0(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x103b638*/ uint <SortGlyphPairAdjustmentRecords>b__6_1(TMPro.TMP_GlyphPairAdjustmentRecord s);
        }
    }

    class TMP_InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.EventSystems.IScrollHandler
    {
        static float kHScrollSpeed = 0.05000000074505806;
        static float kVScrollSpeed = 0.10000000149011612;
        static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        static /*0x0*/ char[] kSeparators;
        /*0xf8*/ UnityEngine.TouchScreenKeyboard m_SoftKeyboard;
        /*0x100*/ UnityEngine.RectTransform m_RectTransform;
        /*0x108*/ UnityEngine.RectTransform m_TextViewport;
        /*0x110*/ UnityEngine.UI.RectMask2D m_TextComponentRectMask;
        /*0x118*/ UnityEngine.UI.RectMask2D m_TextViewportRectMask;
        /*0x120*/ UnityEngine.Rect m_CachedViewportRect;
        /*0x130*/ TMPro.TMP_Text m_TextComponent;
        /*0x138*/ UnityEngine.RectTransform m_TextComponentRectTransform;
        /*0x140*/ UnityEngine.UI.Graphic m_Placeholder;
        /*0x148*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        /*0x150*/ TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        /*0x158*/ bool m_IsDrivenByLayoutComponents;
        /*0x160*/ UnityEngine.UI.LayoutGroup m_LayoutGroup;
        /*0x168*/ UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;
        /*0x170*/ float m_ScrollPosition;
        /*0x174*/ float m_ScrollSensitivity;
        /*0x178*/ TMPro.TMP_InputField.ContentType m_ContentType;
        /*0x17c*/ TMPro.TMP_InputField.InputType m_InputType;
        /*0x180*/ char m_AsteriskChar;
        /*0x184*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        /*0x188*/ TMPro.TMP_InputField.LineType m_LineType;
        /*0x18c*/ bool m_HideMobileInput;
        /*0x18d*/ bool m_HideSoftKeyboard;
        /*0x190*/ TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;
        /*0x198*/ string m_RegexValue;
        /*0x1a0*/ float m_GlobalPointSize;
        /*0x1a4*/ int m_CharacterLimit;
        /*0x1a8*/ TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;
        /*0x1b0*/ TMPro.TMP_InputField.SubmitEvent m_OnSubmit;
        /*0x1b8*/ TMPro.TMP_InputField.SelectionEvent m_OnSelect;
        /*0x1c0*/ TMPro.TMP_InputField.SelectionEvent m_OnDeselect;
        /*0x1c8*/ TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;
        /*0x1d0*/ TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;
        /*0x1d8*/ TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;
        /*0x1e0*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;
        /*0x1e8*/ TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;
        /*0x1f0*/ UnityEngine.Color m_CaretColor;
        /*0x200*/ bool m_CustomCaretColor;
        /*0x204*/ UnityEngine.Color m_SelectionColor;
        /*0x218*/ string m_Text;
        /*0x220*/ float m_CaretBlinkRate;
        /*0x224*/ int m_CaretWidth;
        /*0x228*/ bool m_ReadOnly;
        /*0x229*/ bool m_RichText;
        /*0x22c*/ int m_StringPosition;
        /*0x230*/ int m_StringSelectPosition;
        /*0x234*/ int m_CaretPosition;
        /*0x238*/ int m_CaretSelectPosition;
        /*0x240*/ UnityEngine.RectTransform caretRectTrans;
        /*0x248*/ UnityEngine.UIVertex[] m_CursorVerts;
        /*0x250*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
        /*0x258*/ UnityEngine.Vector2 m_LastPosition;
        /*0x260*/ UnityEngine.Mesh m_Mesh;
        /*0x268*/ bool m_AllowInput;
        /*0x269*/ bool m_ShouldActivateNextUpdate;
        /*0x26a*/ bool m_UpdateDrag;
        /*0x26b*/ bool m_DragPositionOutOfBounds;
        /*0x26c*/ bool m_CaretVisible;
        /*0x270*/ UnityEngine.Coroutine m_BlinkCoroutine;
        /*0x278*/ float m_BlinkStartTime;
        /*0x280*/ UnityEngine.Coroutine m_DragCoroutine;
        /*0x288*/ string m_OriginalText;
        /*0x290*/ bool m_WasCanceled;
        /*0x291*/ bool m_HasDoneFocusTransition;
        /*0x298*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        /*0x2a0*/ bool m_PreventCallback;
        /*0x2a1*/ bool m_TouchKeyboardAllowsInPlaceEditing;
        /*0x2a2*/ bool m_IsTextComponentUpdateRequired;
        /*0x2a3*/ bool m_isLastKeyBackspace;
        /*0x2a4*/ float m_PointerDownClickStartTime;
        /*0x2a8*/ float m_KeyDownStartTime;
        /*0x2ac*/ float m_DoubleClickDelay;
        /*0x2b0*/ bool m_IsCompositionActive;
        /*0x2b1*/ bool m_ShouldUpdateIMEWindowPosition;
        /*0x2b4*/ int m_PreviousIMEInsertionLine;
        /*0x2b8*/ TMPro.TMP_FontAsset m_GlobalFontAsset;
        /*0x2c0*/ bool m_OnFocusSelectAll;
        /*0x2c1*/ bool m_isSelectAll;
        /*0x2c2*/ bool m_ResetOnDeActivation;
        /*0x2c3*/ bool m_SelectionStillActive;
        /*0x2c4*/ bool m_ReleaseSelection;
        /*0x2c8*/ UnityEngine.GameObject m_PreviouslySelectedObject;
        /*0x2d0*/ bool m_RestoreOriginalTextOnEscape;
        /*0x2d1*/ bool m_isRichTextEditingAllowed;
        /*0x2d4*/ int m_LineLimit;
        /*0x2d8*/ TMPro.TMP_InputValidator m_InputValidator;
        /*0x2e0*/ bool m_isSelected;
        /*0x2e1*/ bool m_IsStringPositionDirty;
        /*0x2e2*/ bool m_IsCaretPositionDirty;
        /*0x2e3*/ bool m_forceRectTransformAdjustment;
        /*0x2e8*/ UnityEngine.Event m_ProcessingEvent;

        static /*0x104722c*/ TMP_InputField();
        static /*0x103f5ec*/ string get_clipboard();
        static /*0x103f5f4*/ void set_clipboard(string value);
        /*0x103b820*/ TMP_InputField();
        /*0x103b650*/ UnityEngine.EventSystems.BaseInput get_inputSystem();
        /*0x103b760*/ string get_compositionString();
        /*0x103b7f4*/ int get_compositionLength();
        /*0x103bb44*/ UnityEngine.Mesh get_mesh();
        /*0x103bbec*/ bool get_shouldHideMobileInput();
        /*0x103bc34*/ void set_shouldHideMobileInput(bool value);
        /*0x103bcc0*/ bool get_shouldHideSoftKeyboard();
        /*0x103bd54*/ void set_shouldHideSoftKeyboard(bool value);
        /*0x103be68*/ bool isKeyboardUsingEvents();
        /*0x103bebc*/ string get_text();
        /*0x103bec4*/ void set_text(string value);
        /*0x103c000*/ void SetTextWithoutNotify(string input);
        /*0x103becc*/ void SetText(string value, bool sendCallback);
        /*0x103c580*/ bool get_isFocused();
        /*0x103c588*/ float get_caretBlinkRate();
        /*0x103c590*/ void set_caretBlinkRate(float value);
        /*0x103c660*/ int get_caretWidth();
        /*0x103c668*/ void set_caretWidth(int value);
        /*0x103c734*/ UnityEngine.RectTransform get_textViewport();
        /*0x102c81c*/ void set_textViewport(UnityEngine.RectTransform value);
        /*0x103c73c*/ TMPro.TMP_Text get_textComponent();
        /*0x102c874*/ void set_textComponent(TMPro.TMP_Text value);
        /*0x103c744*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x102c8e8*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x103c74c*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
        /*0x103c754*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
        /*0x103c90c*/ float get_scrollSensitivity();
        /*0x103c914*/ void set_scrollSensitivity(float value);
        /*0x103c988*/ UnityEngine.Color get_caretColor();
        /*0x103c9cc*/ void set_caretColor(UnityEngine.Color value);
        /*0x103c9f8*/ bool get_customCaretColor();
        /*0x103ca00*/ void set_customCaretColor(bool value);
        /*0x103ca1c*/ UnityEngine.Color get_selectionColor();
        /*0x103ca30*/ void set_selectionColor(UnityEngine.Color value);
        /*0x103ca5c*/ TMPro.TMP_InputField.SubmitEvent get_onEndEdit();
        /*0x103ca64*/ void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x103cabc*/ TMPro.TMP_InputField.SubmitEvent get_onSubmit();
        /*0x103cac4*/ void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x103cb1c*/ TMPro.TMP_InputField.SelectionEvent get_onSelect();
        /*0x103cb24*/ void set_onSelect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x103cb7c*/ TMPro.TMP_InputField.SelectionEvent get_onDeselect();
        /*0x103cb84*/ void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x103cbdc*/ TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection();
        /*0x103cbe4*/ void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x103cc3c*/ TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection();
        /*0x103cc44*/ void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x103cc9c*/ TMPro.TMP_InputField.OnChangeEvent get_onValueChanged();
        /*0x103cca4*/ void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value);
        /*0x103ccfc*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged();
        /*0x103cd04*/ void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value);
        /*0x103cd5c*/ TMPro.TMP_InputField.OnValidateInput get_onValidateInput();
        /*0x103cd64*/ void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value);
        /*0x103cdbc*/ int get_characterLimit();
        /*0x103cdc4*/ void set_characterLimit(int value);
        /*0x103ce84*/ float get_pointSize();
        /*0x103ce8c*/ void set_pointSize(float value);
        /*0x103d028*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x102c940*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x103d110*/ bool get_onFocusSelectAll();
        /*0x103d118*/ void set_onFocusSelectAll(bool value);
        /*0x103d124*/ bool get_resetOnDeActivation();
        /*0x103d12c*/ void set_resetOnDeActivation(bool value);
        /*0x103d138*/ bool get_restoreOriginalTextOnEscape();
        /*0x103d140*/ void set_restoreOriginalTextOnEscape(bool value);
        /*0x103d14c*/ bool get_isRichTextEditingAllowed();
        /*0x103d154*/ void set_isRichTextEditingAllowed(bool value);
        /*0x103d160*/ TMPro.TMP_InputField.ContentType get_contentType();
        /*0x103d168*/ void set_contentType(TMPro.TMP_InputField.ContentType value);
        /*0x103d298*/ TMPro.TMP_InputField.LineType get_lineType();
        /*0x103d2a0*/ void set_lineType(TMPro.TMP_InputField.LineType value);
        /*0x103d3b8*/ int get_lineLimit();
        /*0x103d3c0*/ void set_lineLimit(int value);
        /*0x103d42c*/ TMPro.TMP_InputField.InputType get_inputType();
        /*0x103d434*/ void set_inputType(TMPro.TMP_InputField.InputType value);
        /*0x103d4d0*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
        /*0x103d4d8*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
        /*0x103d55c*/ TMPro.TMP_InputField.CharacterValidation get_characterValidation();
        /*0x103d564*/ void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value);
        /*0x103d5e8*/ TMPro.TMP_InputValidator get_inputValidator();
        /*0x103d5f0*/ void set_inputValidator(TMPro.TMP_InputValidator value);
        /*0x103d68c*/ bool get_readOnly();
        /*0x103d694*/ void set_readOnly(bool value);
        /*0x103d6a0*/ bool get_richText();
        /*0x103d6a8*/ void set_richText(bool value);
        /*0x103d73c*/ bool get_multiLine();
        /*0x103d750*/ char get_asteriskChar();
        /*0x103d758*/ void set_asteriskChar(char value);
        /*0x103d7cc*/ bool get_wasCanceled();
        /*0x103d7d4*/ void ClampStringPos(ref int pos);
        /*0x103d80c*/ void ClampCaretPos(ref int pos);
        /*0x103d850*/ int get_caretPositionInternal();
        /*0x103d868*/ void set_caretPositionInternal(int value);
        /*0x103d878*/ int get_stringPositionInternal();
        /*0x103d890*/ void set_stringPositionInternal(int value);
        /*0x103d8c8*/ int get_caretSelectPositionInternal();
        /*0x103d8e0*/ void set_caretSelectPositionInternal(int value);
        /*0x103d8f0*/ int get_stringSelectPositionInternal();
        /*0x103d908*/ void set_stringSelectPositionInternal(int value);
        /*0x103d940*/ bool get_hasSelection();
        /*0x103d97c*/ int get_caretPosition();
        /*0x103d994*/ void set_caretPosition(int value);
        /*0x103da40*/ int get_selectionAnchorPosition();
        /*0x103d9c8*/ void set_selectionAnchorPosition(int value);
        /*0x103da58*/ int get_selectionFocusPosition();
        /*0x103da04*/ void set_selectionFocusPosition(int value);
        /*0x103da70*/ int get_stringPosition();
        /*0x103da88*/ void set_stringPosition(int value);
        /*0x103db6c*/ int get_selectionStringAnchorPosition();
        /*0x103dabc*/ void set_selectionStringAnchorPosition(int value);
        /*0x103db84*/ int get_selectionStringFocusPosition();
        /*0x103db14*/ void set_selectionStringFocusPosition(int value);
        /*0x103db9c*/ void OnEnable();
        /*0x103e7c0*/ void OnDisable();
        /*0x103ecac*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        /*0x103ef1c*/ System.Collections.IEnumerator CaretBlink();
        /*0x103ef84*/ void SetCaretVisible();
        /*0x103c60c*/ void SetCaretActive();
        /*0x103efbc*/ void OnFocus();
        /*0x103efcc*/ void SelectAll();
        /*0x103f008*/ void MoveTextEnd(bool shift);
        /*0x103f1a0*/ void MoveTextStart(bool shift);
        /*0x103f2dc*/ void MoveToEndOfLine(bool shift, bool ctrl);
        /*0x103f45c*/ void MoveToStartOfLine(bool shift, bool ctrl);
        /*0x103f5fc*/ bool InPlaceEditing();
        /*0x103f6c0*/ void UpdateStringPositionFromKeyboard();
        /*0x103f808*/ void LateUpdate();
        /*0x1040ae0*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1040be4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1040c04*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1040e90*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1040f04*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1040f20*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1041650*/ TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt);
        /*0x1042a80*/ bool IsValidChar(char c);
        /*0x1042aa0*/ void ProcessEvent(UnityEngine.Event e);
        /*0x1042aa4*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1042ca0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1042e60*/ float GetScrollPositionRelativeToViewport();
        /*0x1042010*/ string GetSelectedString();
        /*0x1043140*/ int FindNextWordBegin();
        /*0x1042654*/ void MoveRight(bool shift, bool ctrl);
        /*0x1043214*/ int FindPrevWordBegin();
        /*0x10422a4*/ void MoveLeft(bool shift, bool ctrl);
        /*0x10432cc*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x104341c*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x1043568*/ int PageUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x1043774*/ int PageDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x1042a5c*/ void MoveDown(bool shift);
        /*0x1043980*/ void MoveDown(bool shift, bool goToLastChar);
        /*0x1042a50*/ void MoveUp(bool shift);
        /*0x1043b44*/ void MoveUp(bool shift, bool goToFirstChar);
        /*0x1042a68*/ void MovePageUp(bool shift);
        /*0x1043cf4*/ void MovePageUp(bool shift, bool goToFirstChar);
        /*0x1042a74*/ void MovePageDown(bool shift);
        /*0x1043fdc*/ void MovePageDown(bool shift, bool goToLastChar);
        /*0x10420d0*/ void Delete();
        /*0x1041dec*/ void DeleteKey();
        /*0x1041a64*/ void Backspace();
        /*0x10442d8*/ void Append(string input);
        /*0x1044388*/ void Append(char input);
        /*0x10445c4*/ void Insert(char c);
        /*0x1042268*/ void UpdateTouchKeyboardFromEditChanges();
        /*0x1040ac8*/ void SendOnValueChangedAndUpdateLabel();
        /*0x103c524*/ void SendOnValueChanged();
        /*0x10446c4*/ void SendOnEndEdit();
        /*0x1042c44*/ void SendOnSubmit();
        /*0x1044720*/ void SendOnFocus();
        /*0x104477c*/ void SendOnFocusLost();
        /*0x10447d8*/ void SendOnTextSelection();
        /*0x1044880*/ void SendOnEndTextSelection();
        /*0x1040280*/ void SendTouchScreenKeyboardStatusChanged();
        /*0x103c008*/ void UpdateLabel();
        /*0x103ee30*/ void UpdateScrollbar();
        /*0x104491c*/ void OnScrollbarValueChange(float value);
        /*0x103e7bc*/ void UpdateMaskRegions();
        /*0x1042f70*/ void AdjustTextPositionRelativeToViewport(float relativePosition);
        /*0x103edc0*/ int GetCaretPositionFromStringIndex(int stringIndex);
        /*0x1044958*/ int GetMinCaretPositionFromStringIndex(int stringIndex);
        /*0x10449cc*/ int GetMaxCaretPositionFromStringIndex(int stringIndex);
        /*0x103f140*/ int GetStringIndexFromCaretPosition(int caretPosition);
        /*0x1044a3c*/ void ForceLabelUpdate();
        /*0x103c6dc*/ void MarkGeometryAsDirty();
        /*0x1044a40*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x1044b04*/ void LayoutComplete();
        /*0x1044b08*/ void GraphicUpdateComplete();
        /*0x1044a50*/ void UpdateGeometry();
        /*0x103e2bc*/ void AssignPositioningIfNeeded();
        /*0x1044b0c*/ void OnFillVBO(UnityEngine.Mesh vbo);
        /*0x1044e64*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x1046704*/ void CreateCursorVerts();
        /*0x1045e48*/ void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x1046854*/ void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, float height, bool isCharVisible);
        /*0x10402f4*/ char Validate(string text, int pos, char ch);
        /*0x1046d84*/ void ActivateInputField();
        /*0x103fe54*/ void ActivateInputFieldInternal();
        /*0x1046e98*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1046ebc*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1046ee0*/ void OnControlClick();
        /*0x1040254*/ void ReleaseSelection();
        /*0x103eaf0*/ void DeactivateInputField(bool clearSelection);
        /*0x1046ee4*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1046f1c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x103d1dc*/ void EnforceContentType();
        /*0x103bab0*/ void SetTextComponentWrapMode();
        /*0x103d6b4*/ void SetTextComponentRichTextMode();
        /*0x103d360*/ void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes);
        /*0x103d4b8*/ void SetToCustom();
        /*0x103d674*/ void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x1046f70*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
        /*0x1046f9c*/ void CalculateLayoutInputHorizontal();
        /*0x1046fa0*/ void CalculateLayoutInputVertical();
        /*0x1046fa4*/ float get_minWidth();
        /*0x1046fac*/ float get_preferredWidth();
        /*0x10470dc*/ float get_flexibleWidth();
        /*0x10470e4*/ float get_minHeight();
        /*0x10470ec*/ float get_preferredHeight();
        /*0x104721c*/ float get_flexibleHeight();
        /*0x1047224*/ int get_layoutPriority();
        /*0x103cf40*/ void SetGlobalPointSize(float pointSize);
        /*0x103d030*/ void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset);
        /*0x10472c0*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
            /*0x120c9c4*/ OnValidateInput(object object, nint method);
            /*0x120ca9c*/ char Invoke(string text, int charIndex, char addedChar);
            /*0x120cab0*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
            /*0x120cb70*/ char EndInvoke(System.IAsyncResult result);
        }

        class SubmitEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x120cb98*/ SubmitEvent();
        }

        class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x120cbe0*/ OnChangeEvent();
        }

        class SelectionEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x120cc28*/ SelectionEvent();
        }

        class TextSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0x120cc70*/ TextSelectionEvent();
        }

        class TouchScreenKeyboardEvent : UnityEngine.Events.UnityEvent<UnityEngine.TouchScreenKeyboard.Status>
        {
            /*0x120ccb8*/ TouchScreenKeyboardEvent();
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

            /*0x120cd00*/ <CaretBlink>d__276(int <>1__state);
            /*0x120cd28*/ void System.IDisposable.Dispose();
            /*0x120cd2c*/ bool MoveNext();
            /*0x120ce38*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x120ce40*/ void System.Collections.IEnumerator.Reset();
            /*0x120ce80*/ object System.Collections.IEnumerator.get_Current();
        }

        class <MouseDragOutsideRect>d__294 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;
            /*0x28*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x120ce88*/ <MouseDragOutsideRect>d__294(int <>1__state);
            /*0x120ceb0*/ void System.IDisposable.Dispose();
            /*0x120ceb4*/ bool MoveNext();
            /*0x120d108*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x120d110*/ void System.Collections.IEnumerator.Reset();
            /*0x120d150*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class SetPropertyUtility
    {
        static /*0x120d158*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
        static bool SetEquatableStruct<T>(ref T currentValue, T newValue);
        static bool SetStruct<T>(ref T currentValue, T newValue);
        static bool SetClass<T>(ref T currentValue, T newValue);
    }

    class TMP_InputValidator : UnityEngine.ScriptableObject
    {
        /*0x120d1a0*/ TMP_InputValidator();
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

        static TMP_ListPool();
        static System.Collections.Generic.List<T> Get();
        static void Release(System.Collections.Generic.List<T> toRelease);

        class <>c<T>
        {
            static /*0x0*/ TMPro.TMP_ListPool.<>c<T> <>9;

            static <>c();
            <>c();
            void <.cctor>b__3_0(System.Collections.Generic.List<T> l);
        }
    }

    class TMP_MaterialManager
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        static /*0x8*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        static /*0x18*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        static /*0x20*/ bool isFallbackListDirty;

        static /*0x120d1a8*/ TMP_MaterialManager();
        static /*0x120d368*/ void OnPreRender();
        static /*0x120d5f4*/ UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, int stencilID);
        static /*0x120e49c*/ void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x120e698*/ UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial);
        static /*0x120e804*/ UnityEngine.Material SetStencil(UnityEngine.Material material, int stencilID);
        static /*0x120e8c0*/ void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, int stencilID);
        static /*0x120eb3c*/ void RemoveStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x120eca4*/ void ReleaseBaseMaterial(UnityEngine.Material baseMaterial);
        static /*0x120f1d8*/ void ClearMaterials();
        static /*0x120f394*/ int GetStencilID(UnityEngine.GameObject obj);
        static /*0x120f800*/ UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial);
        static /*0x120f660*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
        static /*0x120f9fc*/ UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
        static /*0x120ff40*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
        static /*0x1210360*/ void AddFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x12104a4*/ void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x120d3e0*/ void CleanupFallbackMaterials();
        static /*0x1210678*/ void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial);
        static /*0x120fccc*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);

        class FallbackMaterial
        {
            /*0x10*/ long fallbackID;
            /*0x18*/ UnityEngine.Material sourceMaterial;
            /*0x20*/ int sourceMaterialCRC;
            /*0x28*/ UnityEngine.Material fallbackMaterial;
            /*0x30*/ int count;

            /*0x120ff38*/ FallbackMaterial();
        }

        class MaskingMaterial
        {
            /*0x10*/ UnityEngine.Material baseMaterial;
            /*0x18*/ UnityEngine.Material stencilMaterial;
            /*0x20*/ int count;
            /*0x24*/ int stencilID;

            /*0x120e494*/ MaskingMaterial();
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x120e7fc*/ <>c__DisplayClass9_0();
            /*0x121086c*/ bool <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x120eb34*/ <>c__DisplayClass11_0();
            /*0x12108dc*/ bool <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x120ec9c*/ <>c__DisplayClass12_0();
            /*0x121094c*/ bool <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ UnityEngine.Material baseMaterial;

            /*0x120f1d0*/ <>c__DisplayClass13_0();
            /*0x12109bc*/ bool <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
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

        static /*0x1212edc*/ TMP_MeshInfo();
        /*0x1210a2c*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size);
        /*0x1210f24*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size, bool isVolumetric);
        /*0x12116a8*/ void ResizeMeshInfo(int size);
        /*0x1211b1c*/ void ResizeMeshInfo(int size, bool isVolumetric);
        /*0x12123f0*/ void Clear();
        /*0x1212494*/ void Clear(bool uploadChanges);
        /*0x12125cc*/ void ClearUnusedVertices();
        /*0x1212608*/ void ClearUnusedVertices(int startIndex);
        /*0x121263c*/ void ClearUnusedVertices(int startIndex, bool updateMesh);
        /*0x1212700*/ void SortGeometry(TMPro.VertexSortingOrder order);
        /*0x1212d08*/ void SortGeometry(System.Collections.Generic.IList<int> sortingOrder);
        /*0x121277c*/ void SwapVertexData(int src, int dst);
    }

    class TMP_ObjectPool<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        /*0x0*/ int <countAll>k__BackingField;

        TMP_ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
        int get_countAll();
        void set_countAll(int value);
        int get_countActive();
        int get_countInactive();
        T Get();
        void Release(T element);
    }

    class TMP_ResourceManager
    {
        static /*0x0*/ TMPro.TMP_ResourceManager s_instance;
        static /*0x8*/ TMPro.TMP_Settings s_TextSettings;
        static /*0x10*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> s_FontAssetReferences;
        static /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;

        static /*0x1212f5c*/ TMP_ResourceManager();
        static /*0x1213060*/ TMPro.TMP_Settings GetTextSettings();
        static /*0x1213170*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x12132c4*/ bool TryGetFontAsset(int hashcode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x1213358*/ void RebuildFontAssetCache(int instanceID);
        /*0x1213058*/ TMP_ResourceManager();
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
        /*0x18*/ bool isSelected;

        /*0x12135c4*/ TMP_ScrollbarEventHandler();
        /*0x1213470*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x12134d8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1213550*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
    }

    class TMP_SelectionCaret : UnityEngine.UI.MaskableGraphic
    {
        /*0x12136a0*/ TMP_SelectionCaret();
        /*0x12135cc*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x121369c*/ void UpdateGeometry();
    }

    class TMP_Settings : UnityEngine.ScriptableObject
    {
        static /*0x0*/ TMPro.TMP_Settings s_Instance;
        /*0x18*/ bool m_enableWordWrapping;
        /*0x19*/ bool m_enableKerning;
        /*0x1a*/ bool m_enableExtraPadding;
        /*0x1b*/ bool m_enableTintAllSprites;
        /*0x1c*/ bool m_enableParseEscapeCharacters;
        /*0x1d*/ bool m_EnableRaycastTarget;
        /*0x1e*/ bool m_GetFontFeaturesAtRuntime;
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
        /*0xb0*/ bool m_UseModernHangulLineBreakingRules;

        static /*0x12136a8*/ string get_version();
        static /*0x12136e8*/ bool get_enableWordWrapping();
        static /*0x12137d0*/ bool get_enableKerning();
        static /*0x12137ec*/ bool get_enableExtraPadding();
        static /*0x1213808*/ bool get_enableTintAllSprites();
        static /*0x1213824*/ bool get_enableParseEscapeCharacters();
        static /*0x1213840*/ bool get_enableRaycastTarget();
        static /*0x121385c*/ bool get_getFontFeaturesAtRuntime();
        static /*0x1213878*/ int get_missingGlyphCharacter();
        static /*0x1213894*/ void set_missingGlyphCharacter(int value);
        static /*0x12138b4*/ bool get_warningsDisabled();
        static /*0x12138d0*/ TMPro.TMP_FontAsset get_defaultFontAsset();
        static /*0x12138ec*/ string get_defaultFontAssetPath();
        static /*0x1213908*/ float get_defaultFontSize();
        static /*0x1213924*/ float get_defaultTextAutoSizingMinRatio();
        static /*0x1213940*/ float get_defaultTextAutoSizingMaxRatio();
        static /*0x121395c*/ UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize();
        static /*0x1213978*/ UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize();
        static /*0x1213994*/ bool get_autoSizeTextContainer();
        static /*0x12139b0*/ bool get_isTextObjectScaleStatic();
        static /*0x12139cc*/ void set_isTextObjectScaleStatic(bool value);
        static /*0x12139f0*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets();
        static /*0x1213a0c*/ bool get_matchMaterialPreset();
        static /*0x1213a28*/ TMPro.TMP_SpriteAsset get_defaultSpriteAsset();
        static /*0x1213a44*/ string get_defaultSpriteAssetPath();
        static /*0x1213a60*/ bool get_enableEmojiSupport();
        static /*0x1213a7c*/ void set_enableEmojiSupport(bool value);
        static /*0x1213aa0*/ uint get_missingCharacterSpriteUnicode();
        static /*0x1213abc*/ void set_missingCharacterSpriteUnicode(uint value);
        static /*0x1213adc*/ string get_defaultColorGradientPresetsPath();
        static /*0x1213af8*/ TMPro.TMP_StyleSheet get_defaultStyleSheet();
        static /*0x1213b14*/ string get_styleSheetsResourcePath();
        static /*0x1213b30*/ UnityEngine.TextAsset get_leadingCharacters();
        static /*0x1213b4c*/ UnityEngine.TextAsset get_followingCharacters();
        static /*0x1213b68*/ TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules();
        static /*0x1213ca8*/ bool get_useModernHangulLineBreakingRules();
        static /*0x1213cc4*/ void set_useModernHangulLineBreakingRules(bool value);
        static /*0x1213704*/ TMPro.TMP_Settings get_instance();
        static /*0x1213ce8*/ TMPro.TMP_Settings LoadDefaultSettings();
        static /*0x1213de0*/ TMPro.TMP_Settings GetSettings();
        static /*0x1213e5c*/ TMPro.TMP_FontAsset GetFontAsset();
        static /*0x1213ee0*/ TMPro.TMP_SpriteAsset GetSpriteAsset();
        static /*0x1213f64*/ TMPro.TMP_StyleSheet GetStyleSheet();
        static /*0x1213b98*/ void LoadLinebreakingRules();
        static /*0x1213ff0*/ System.Collections.Generic.Dictionary<int, char> GetCharacters(UnityEngine.TextAsset file);
        /*0x1214110*/ TMP_Settings();

        class LineBreakingTable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, char> leadingCharacters;
            /*0x18*/ System.Collections.Generic.Dictionary<int, char> followingCharacters;

            /*0x1213fe8*/ LineBreakingTable();
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

        static /*0x1214318*/ ShaderUtilities();
        static /*0x1214120*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
        static /*0x121421c*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
        static /*0x120d9a8*/ void GetShaderPropertyIDs();
        static /*0x12144a8*/ void UpdateShaderRatios(UnityEngine.Material mat);
        static /*0x1214904*/ UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material);
        static /*0x1214948*/ bool IsMaskingEnabled(UnityEngine.Material material);
        static /*0x1214ae4*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
        static /*0x121518c*/ float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold);
    }

    class TMP_Sprite : TMPro.TMP_TextElement_Legacy
    {
        /*0x38*/ string name;
        /*0x40*/ int hashCode;
        /*0x44*/ int unicode;
        /*0x48*/ UnityEngine.Vector2 pivot;
        /*0x50*/ UnityEngine.Sprite sprite;

        /*0x1215a0c*/ TMP_Sprite();
    }

    class TMP_SpriteAnimator : UnityEngine.MonoBehaviour
    {
        /*0x18*/ System.Collections.Generic.Dictionary<int, bool> m_animations;
        /*0x20*/ TMPro.TMP_Text m_TextComponent;

        /*0x1215c80*/ TMP_SpriteAnimator();
        /*0x1215a1c*/ void Awake();
        /*0x1215a6c*/ void OnEnable();
        /*0x1215a70*/ void OnDisable();
        /*0x1215a74*/ void StopAllAnimations();
        /*0x1215ad0*/ void DoSpriteAnimation(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
        /*0x1215bb8*/ System.Collections.IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);

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

            /*0x1215c58*/ <DoSpriteAnimationInternal>d__7(int <>1__state);
            /*0x1215d00*/ void System.IDisposable.Dispose();
            /*0x1215d04*/ bool MoveNext();
            /*0x1216608*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1216610*/ void System.Collections.IEnumerator.Reset();
            /*0x1216650*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x12174a0*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x12176c8*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x1217868*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x1217918*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex);
        static /*0x1217c38*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
        static /*0x1217dd8*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
        /*0x12181b4*/ TMP_SpriteAsset();
        /*0x1216658*/ string get_version();
        /*0x1216660*/ void set_version(string value);
        /*0x1216668*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x1216678*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x12165e4*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable();
        /*0x1216bb4*/ void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value);
        /*0x1216bbc*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable();
        /*0x1216be0*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> value);
        /*0x1216be8*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable();
        /*0x1216bf0*/ void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value);
        /*0x1216bf8*/ void Awake();
        /*0x12171bc*/ UnityEngine.Material GetDefaultSpriteMaterial();
        /*0x1216690*/ void UpdateLookupTables();
        /*0x12172a4*/ int GetSpriteIndexFromHashcode(int hashCode);
        /*0x121732c*/ int GetSpriteIndexFromUnicode(uint unicode);
        /*0x12173c0*/ int GetSpriteIndexFromName(string name);
        /*0x1217e88*/ void SortGlyphTable();
        /*0x1217fc0*/ void SortCharacterTable();
        /*0x12180fc*/ void SortGlyphAndCharacterTables();
        /*0x1216c80*/ void UpgradeSpriteAsset();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_SpriteAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_SpriteGlyph, uint> <>9__40_0;
            static /*0x10*/ System.Func<TMPro.TMP_SpriteCharacter, uint> <>9__41_0;

            static /*0x1218274*/ <>c();
            /*0x12182d8*/ <>c();
            /*0x12182e0*/ uint <SortGlyphTable>b__40_0(TMPro.TMP_SpriteGlyph item);
            /*0x12182f8*/ uint <SortCharacterTable>b__41_0(TMPro.TMP_SpriteCharacter c);
        }
    }

    class TMP_SpriteCharacter : TMPro.TMP_TextElement
    {
        /*0x30*/ string m_Name;
        /*0x38*/ int m_HashCode;

        /*0x121811c*/ TMP_SpriteCharacter();
        /*0x1218394*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteGlyph glyph);
        /*0x12183e8*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph);
        /*0x1218448*/ TMP_SpriteCharacter(uint unicode, uint glyphIndex);
        /*0x1218310*/ string get_name();
        /*0x121813c*/ void set_name(string value);
        /*0x1218384*/ int get_hashCode();
    }

    class TMP_SpriteGlyph : UnityEngine.TextCore.Glyph
    {
        /*0x40*/ UnityEngine.Sprite sprite;

        /*0x1218114*/ TMP_SpriteGlyph();
        /*0x1218488*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
        /*0x1218544*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite);
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

        static /*0x1218608*/ TMPro.TMP_Style get_NormalStyle();
        /*0x12186c4*/ TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
        /*0x1218754*/ string get_name();
        /*0x121875c*/ void set_name(string value);
        /*0x1218794*/ int get_hashCode();
        /*0x121879c*/ void set_hashCode(int value);
        /*0x12187b0*/ string get_styleOpeningDefinition();
        /*0x12187b8*/ string get_styleClosingDefinition();
        /*0x12187c0*/ int[] get_styleOpeningTagArray();
        /*0x12187c8*/ int[] get_styleClosingTagArray();
        /*0x121888c*/ void RefreshStyle();
    }

    class TMP_StyleSheet : UnityEngine.ScriptableObject
    {
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_Style> m_StyleLookupDictionary;

        /*0x1218eec*/ TMP_StyleSheet();
        /*0x1218a84*/ System.Collections.Generic.List<TMPro.TMP_Style> get_styles();
        /*0x1218a8c*/ void Reset();
        /*0x1218da8*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x1218e30*/ TMPro.TMP_Style GetStyle(string name);
        /*0x1218ee8*/ void RefreshStyles();
        /*0x1218a90*/ void LoadStyleDictionaryInternal();
    }

    class TMP_SubMesh : UnityEngine.MonoBehaviour
    {
        /*0x18*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0x20*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x28*/ UnityEngine.Material m_material;
        /*0x30*/ UnityEngine.Material m_sharedMaterial;
        /*0x38*/ UnityEngine.Material m_fallbackMaterial;
        /*0x40*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x48*/ bool m_isDefaultMaterial;
        /*0x4c*/ float m_padding;
        /*0x50*/ UnityEngine.Renderer m_renderer;
        /*0x58*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x60*/ UnityEngine.Mesh m_mesh;
        /*0x68*/ TMPro.TextMeshPro m_TextComponent;
        /*0x70*/ bool m_isRegisteredForEvents;

        static /*0x12196f0*/ TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference);
        /*0x121a194*/ TMP_SubMesh();
        /*0x1218f6c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x1218f74*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x1218f7c*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x1218f84*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x1218f8c*/ UnityEngine.Material get_material();
        /*0x12190bc*/ void set_material(UnityEngine.Material value);
        /*0x1219258*/ UnityEngine.Material get_sharedMaterial();
        /*0x1219260*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x12192a0*/ UnityEngine.Material get_fallbackMaterial();
        /*0x12192a8*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x12193e0*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x12193e8*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x12193f0*/ bool get_isDefaultMaterial();
        /*0x12193f8*/ void set_isDefaultMaterial(bool value);
        /*0x1219404*/ float get_padding();
        /*0x121940c*/ void set_padding(float value);
        /*0x1219414*/ UnityEngine.Renderer get_renderer();
        /*0x12194a8*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x12195a4*/ UnityEngine.Mesh get_mesh();
        /*0x1219654*/ void set_mesh(UnityEngine.Mesh value);
        /*0x121965c*/ TMPro.TMP_Text get_textComponent();
        /*0x1219ab4*/ void OnEnable();
        /*0x1219be0*/ void OnDisable();
        /*0x1219c94*/ void OnDestroy();
        /*0x1219ddc*/ void DestroySelf();
        /*0x1218f94*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x1219e4c*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x1219f0c*/ UnityEngine.Material GetSharedMaterial();
        /*0x1219280*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x1219130*/ float GetPaddingForMaterial();
        /*0x1219fb0*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x12191a4*/ void SetVerticesDirty();
        /*0x1219254*/ void SetMaterialDirty();
        /*0x121a024*/ void UpdateMaterial();
    }

    class TMP_SubMeshUI : UnityEngine.UI.MaskableGraphic
    {
        /*0xd0*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xd8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0xe0*/ UnityEngine.Material m_material;
        /*0xe8*/ UnityEngine.Material m_sharedMaterial;
        /*0xf0*/ UnityEngine.Material m_fallbackMaterial;
        /*0xf8*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x100*/ bool m_isDefaultMaterial;
        /*0x104*/ float m_padding;
        /*0x108*/ UnityEngine.Mesh m_mesh;
        /*0x110*/ TMPro.TextMeshProUGUI m_TextComponent;
        /*0x118*/ bool m_isRegisteredForEvents;
        /*0x119*/ bool m_materialDirty;
        /*0x11c*/ int m_materialReferenceIndex;
        /*0x120*/ UnityEngine.Transform m_RootCanvasTransform;

        static /*0x121a864*/ TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference);
        /*0x121b5dc*/ TMP_SubMeshUI();
        /*0x121a19c*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x121a1a4*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x121a1ac*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x121a1b4*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x121a1bc*/ UnityEngine.Texture get_mainTexture();
        /*0x121a278*/ UnityEngine.Material get_material();
        /*0x121a374*/ void set_material(UnityEngine.Material value);
        /*0x121a4d0*/ UnityEngine.Material get_sharedMaterial();
        /*0x121a4d8*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x121a538*/ UnityEngine.Material get_fallbackMaterial();
        /*0x121a540*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x121a688*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x121a690*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x121a698*/ UnityEngine.Material get_materialForRendering();
        /*0x121a6f4*/ bool get_isDefaultMaterial();
        /*0x121a6fc*/ void set_isDefaultMaterial(bool value);
        /*0x121a708*/ float get_padding();
        /*0x121a710*/ void set_padding(float value);
        /*0x121a718*/ UnityEngine.Mesh get_mesh();
        /*0x121a7c8*/ void set_mesh(UnityEngine.Mesh value);
        /*0x121a7d0*/ TMPro.TMP_Text get_textComponent();
        /*0x121ac14*/ void OnEnable();
        /*0x121ac84*/ void OnDisable();
        /*0x121ad2c*/ void OnDestroy();
        /*0x121aed8*/ void OnTransformParentChanged();
        /*0x121af2c*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x121a45c*/ float GetPaddingForMaterial();
        /*0x121b02c*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x121b0a0*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x121b114*/ void SetAllDirty();
        /*0x121b118*/ void SetVerticesDirty();
        /*0x121b1cc*/ void SetLayoutDirty();
        /*0x121b1d0*/ void SetMaterialDirty();
        /*0x121b214*/ void SetPivotDirty();
        /*0x121b27c*/ UnityEngine.Transform GetRootCanvasTransform();
        /*0x121b31c*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x121b320*/ void UpdateGeometry();
        /*0x121b324*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x121b35c*/ void RefreshMaterial();
        /*0x121b36c*/ void UpdateMaterial();
        /*0x121b4ec*/ void RecalculateClipping();
        /*0x121b4f4*/ UnityEngine.Material GetMaterial();
        /*0x121a280*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x121b4fc*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x121b5bc*/ UnityEngine.Material GetSharedMaterial();
        /*0x121a508*/ void SetSharedMaterial(UnityEngine.Material mat);
    }

    interface ITextElement
    {
        UnityEngine.Material get_sharedMaterial();
        void Rebuild(UnityEngine.UI.CanvasUpdate update);
        int GetInstanceID();
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
        /*0xd0*/ string m_text;
        /*0xd8*/ bool m_IsTextBackingStringDirty;
        /*0xe0*/ TMPro.ITextPreprocessor m_TextPreprocessor;
        /*0xe8*/ bool m_isRightToLeft;
        /*0xf0*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xf8*/ TMPro.TMP_FontAsset m_currentFontAsset;
        /*0x100*/ bool m_isSDFShader;
        /*0x108*/ UnityEngine.Material m_sharedMaterial;
        /*0x110*/ UnityEngine.Material m_currentMaterial;
        /*0x118*/ int m_currentMaterialIndex;
        /*0x120*/ UnityEngine.Material[] m_fontSharedMaterials;
        /*0x128*/ UnityEngine.Material m_fontMaterial;
        /*0x130*/ UnityEngine.Material[] m_fontMaterials;
        /*0x138*/ bool m_isMaterialDirty;
        /*0x13c*/ UnityEngine.Color32 m_fontColor32;
        /*0x140*/ UnityEngine.Color m_fontColor;
        /*0x150*/ UnityEngine.Color32 m_underlineColor;
        /*0x154*/ UnityEngine.Color32 m_strikethroughColor;
        /*0x158*/ bool m_enableVertexGradient;
        /*0x15c*/ TMPro.ColorMode m_colorMode;
        /*0x160*/ TMPro.VertexGradient m_fontColorGradient;
        /*0x1a0*/ TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        /*0x1a8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x1b0*/ bool m_tintAllSprites;
        /*0x1b1*/ bool m_tintSprite;
        /*0x1b4*/ UnityEngine.Color32 m_spriteColor;
        /*0x1b8*/ TMPro.TMP_StyleSheet m_StyleSheet;
        /*0x1c0*/ TMPro.TMP_Style m_TextStyle;
        /*0x1c8*/ int m_TextStyleHashCode;
        /*0x1cc*/ bool m_overrideHtmlColors;
        /*0x1d0*/ UnityEngine.Color32 m_faceColor;
        /*0x1d4*/ UnityEngine.Color32 m_outlineColor;
        /*0x1d8*/ float m_outlineWidth;
        /*0x1dc*/ float m_fontSize;
        /*0x1e0*/ float m_currentFontSize;
        /*0x1e4*/ float m_fontSizeBase;
        /*0x1e8*/ TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        /*0x208*/ TMPro.FontWeight m_fontWeight;
        /*0x20c*/ TMPro.FontWeight m_FontWeightInternal;
        /*0x210*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;
        /*0x230*/ bool m_enableAutoSizing;
        /*0x234*/ float m_maxFontSize;
        /*0x238*/ float m_minFontSize;
        /*0x23c*/ int m_AutoSizeIterationCount;
        /*0x240*/ int m_AutoSizeMaxIterationCount;
        /*0x244*/ bool m_IsAutoSizePointSizeSet;
        /*0x248*/ float m_fontSizeMin;
        /*0x24c*/ float m_fontSizeMax;
        /*0x250*/ TMPro.FontStyles m_fontStyle;
        /*0x254*/ TMPro.FontStyles m_FontStyleInternal;
        /*0x258*/ TMPro.TMP_FontStyleStack m_fontStyleStack;
        /*0x262*/ bool m_isUsingBold;
        /*0x264*/ TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        /*0x268*/ TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        /*0x26c*/ TMPro.TextAlignmentOptions m_textAlignment;
        /*0x270*/ TMPro.HorizontalAlignmentOptions m_lineJustification;
        /*0x278*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        /*0x298*/ UnityEngine.Vector3[] m_textContainerLocalCorners;
        /*0x2a0*/ float m_characterSpacing;
        /*0x2a4*/ float m_cSpacing;
        /*0x2a8*/ float m_monoSpacing;
        /*0x2ac*/ float m_wordSpacing;
        /*0x2b0*/ float m_lineSpacing;
        /*0x2b4*/ float m_lineSpacingDelta;
        /*0x2b8*/ float m_lineHeight;
        /*0x2bc*/ bool m_IsDrivenLineSpacing;
        /*0x2c0*/ float m_lineSpacingMax;
        /*0x2c4*/ float m_paragraphSpacing;
        /*0x2c8*/ float m_charWidthMaxAdj;
        /*0x2cc*/ float m_charWidthAdjDelta;
        /*0x2d0*/ bool m_enableWordWrapping;
        /*0x2d1*/ bool m_isCharacterWrappingEnabled;
        /*0x2d2*/ bool m_isNonBreakingSpace;
        /*0x2d3*/ bool m_isIgnoringAlignment;
        /*0x2d4*/ float m_wordWrappingRatios;
        /*0x2d8*/ TMPro.TextOverflowModes m_overflowMode;
        /*0x2dc*/ int m_firstOverflowCharacterIndex;
        /*0x2e0*/ TMPro.TMP_Text m_linkedTextComponent;
        /*0x2e8*/ TMPro.TMP_Text parentLinkedComponent;
        /*0x2f0*/ bool m_isTextTruncated;
        /*0x2f1*/ bool m_enableKerning;
        /*0x2f4*/ float m_GlyphHorizontalAdvanceAdjustment;
        /*0x2f8*/ bool m_enableExtraPadding;
        /*0x2f9*/ bool checkPaddingRequired;
        /*0x2fa*/ bool m_isRichText;
        /*0x2fb*/ bool m_parseCtrlCharacters;
        /*0x2fc*/ bool m_isOverlay;
        /*0x2fd*/ bool m_isOrthographic;
        /*0x2fe*/ bool m_isCullingEnabled;
        /*0x2ff*/ bool m_isMaskingEnabled;
        /*0x300*/ bool isMaskUpdateRequired;
        /*0x301*/ bool m_ignoreCulling;
        /*0x304*/ TMPro.TextureMappingOptions m_horizontalMapping;
        /*0x308*/ TMPro.TextureMappingOptions m_verticalMapping;
        /*0x30c*/ float m_uvLineOffset;
        /*0x310*/ TMPro.TextRenderFlags m_renderMode;
        /*0x314*/ TMPro.VertexSortingOrder m_geometrySortingOrder;
        /*0x318*/ bool m_IsTextObjectScaleStatic;
        /*0x319*/ bool m_VertexBufferAutoSizeReduction;
        /*0x31c*/ int m_firstVisibleCharacter;
        /*0x320*/ int m_maxVisibleCharacters;
        /*0x324*/ int m_maxVisibleWords;
        /*0x328*/ int m_maxVisibleLines;
        /*0x32c*/ bool m_useMaxVisibleDescender;
        /*0x330*/ int m_pageToDisplay;
        /*0x334*/ bool m_isNewPage;
        /*0x338*/ UnityEngine.Vector4 m_margin;
        /*0x348*/ float m_marginLeft;
        /*0x34c*/ float m_marginRight;
        /*0x350*/ float m_marginWidth;
        /*0x354*/ float m_marginHeight;
        /*0x358*/ float m_width;
        /*0x360*/ TMPro.TMP_TextInfo m_textInfo;
        /*0x368*/ bool m_havePropertiesChanged;
        /*0x369*/ bool m_isUsingLegacyAnimationComponent;
        /*0x370*/ UnityEngine.Transform m_transform;
        /*0x378*/ UnityEngine.RectTransform m_rectTransform;
        /*0x380*/ UnityEngine.Vector2 m_PreviousRectTransformSize;
        /*0x388*/ UnityEngine.Vector2 m_PreviousPivotPosition;
        /*0x390*/ bool <autoSizeTextContainer>k__BackingField;
        /*0x391*/ bool m_autoSizeTextContainer;
        /*0x398*/ UnityEngine.Mesh m_mesh;
        /*0x3a0*/ bool m_isVolumetricText;
        /*0x3a8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x3b0*/ TMPro.TMP_SpriteAnimator m_spriteAnimator;
        /*0x3b8*/ float m_flexibleHeight;
        /*0x3bc*/ float m_flexibleWidth;
        /*0x3c0*/ float m_minWidth;
        /*0x3c4*/ float m_minHeight;
        /*0x3c8*/ float m_maxWidth;
        /*0x3cc*/ float m_maxHeight;
        /*0x3d0*/ UnityEngine.UI.LayoutElement m_LayoutElement;
        /*0x3d8*/ float m_preferredWidth;
        /*0x3dc*/ float m_renderedWidth;
        /*0x3e0*/ bool m_isPreferredWidthDirty;
        /*0x3e4*/ float m_preferredHeight;
        /*0x3e8*/ float m_renderedHeight;
        /*0x3ec*/ bool m_isPreferredHeightDirty;
        /*0x3ed*/ bool m_isCalculatingPreferredValues;
        /*0x3f0*/ int m_layoutPriority;
        /*0x3f4*/ bool m_isLayoutDirty;
        /*0x3f5*/ bool m_isAwake;
        /*0x3f6*/ bool m_isWaitingOnResourceLoad;
        /*0x3f8*/ TMPro.TMP_Text.TextInputSources m_inputSource;
        /*0x3fc*/ float m_fontScaleMultiplier;
        /*0x400*/ float tag_LineIndent;
        /*0x404*/ float tag_Indent;
        /*0x408*/ TMPro.TMP_TextProcessingStack<float> m_indentStack;
        /*0x428*/ bool tag_NoParsing;
        /*0x429*/ bool m_isParsingText;
        /*0x42c*/ UnityEngine.Matrix4x4 m_FXMatrix;
        /*0x46c*/ bool m_isFXMatrixSet;
        /*0x470*/ TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;
        /*0x478*/ int m_InternalTextProcessingArraySize;
        /*0x480*/ TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        /*0x488*/ int m_totalCharacterCount;
        /*0x48c*/ int m_characterCount;
        /*0x490*/ int m_firstCharacterOfLine;
        /*0x494*/ int m_firstVisibleCharacterOfLine;
        /*0x498*/ int m_lastCharacterOfLine;
        /*0x49c*/ int m_lastVisibleCharacterOfLine;
        /*0x4a0*/ int m_lineNumber;
        /*0x4a4*/ int m_lineVisibleCharacterCount;
        /*0x4a8*/ int m_pageNumber;
        /*0x4ac*/ float m_PageAscender;
        /*0x4b0*/ float m_maxTextAscender;
        /*0x4b4*/ float m_maxCapHeight;
        /*0x4b8*/ float m_ElementAscender;
        /*0x4bc*/ float m_ElementDescender;
        /*0x4c0*/ float m_maxLineAscender;
        /*0x4c4*/ float m_maxLineDescender;
        /*0x4c8*/ float m_startOfLineAscender;
        /*0x4cc*/ float m_startOfLineDescender;
        /*0x4d0*/ float m_lineOffset;
        /*0x4d4*/ TMPro.Extents m_meshExtents;
        /*0x4e4*/ UnityEngine.Color32 m_htmlColor;
        /*0x4e8*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;
        /*0x508*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;
        /*0x528*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;
        /*0x548*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;
        /*0x578*/ TMPro.TMP_ColorGradient m_colorGradientPreset;
        /*0x580*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;
        /*0x5a8*/ bool m_colorGradientPresetIsTinted;
        /*0x5ac*/ float m_tabSpacing;
        /*0x5b0*/ float m_spacing;
        /*0x5b8*/ TMPro.TMP_TextProcessingStack<int> m_TextStyleStacks;
        /*0x5c0*/ int m_TextStyleStackDepth;
        /*0x5c8*/ TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        /*0x5e8*/ int m_ItalicAngle;
        /*0x5f0*/ TMPro.TMP_TextProcessingStack<int> m_actionStack;
        /*0x610*/ float m_padding;
        /*0x614*/ float m_baselineOffset;
        /*0x618*/ TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        /*0x638*/ float m_xAdvance;
        /*0x63c*/ TMPro.TMP_TextElementType m_textElementType;
        /*0x640*/ TMPro.TMP_TextElement m_cached_TextElement;
        /*0x648*/ TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        /*0x668*/ TMPro.TMP_Text.SpecialCharacter m_Underline;
        /*0x688*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x690*/ TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        /*0x698*/ int m_spriteCount;
        /*0x69c*/ int m_spriteIndex;
        /*0x6a0*/ int m_spriteAnimationID;
        /*0x6a4*/ bool m_ignoreActiveState;
        /*0x6a8*/ TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        /*0x6b8*/ decimal[] k_Power;

        static /*0x115d160*/ TMP_Text();
        static /*0x1144c78*/ void add_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x1144d6c*/ void remove_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x1144e60*/ void add_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x1144f54*/ void remove_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        /*0x115c430*/ TMP_Text();
        /*0x1142588*/ string get_text();
        /*0x1142670*/ void set_text(string value);
        /*0x1142708*/ TMPro.ITextPreprocessor get_textPreprocessor();
        /*0x1142710*/ void set_textPreprocessor(TMPro.ITextPreprocessor value);
        /*0x1142718*/ bool get_isRightToLeftText();
        /*0x1142720*/ void set_isRightToLeftText(bool value);
        /*0x1142774*/ TMPro.TMP_FontAsset get_font();
        /*0x114277c*/ void set_font(TMPro.TMP_FontAsset value);
        /*0x1142844*/ UnityEngine.Material get_fontSharedMaterial();
        /*0x114284c*/ void set_fontSharedMaterial(UnityEngine.Material value);
        /*0x1142914*/ UnityEngine.Material[] get_fontSharedMaterials();
        /*0x1142924*/ void set_fontSharedMaterials(UnityEngine.Material[] value);
        /*0x1142970*/ UnityEngine.Material get_fontMaterial();
        /*0x1142984*/ void set_fontMaterial(UnityEngine.Material value);
        /*0x1142a80*/ UnityEngine.Material[] get_fontMaterials();
        /*0x1142a94*/ void set_fontMaterials(UnityEngine.Material[] value);
        /*0x1142ae0*/ UnityEngine.Color get_color();
        /*0x1142af4*/ void set_color(UnityEngine.Color value);
        /*0x1142b6c*/ float get_alpha();
        /*0x1142b74*/ void set_alpha(float value);
        /*0x1142ba0*/ bool get_enableVertexGradient();
        /*0x1142ba8*/ void set_enableVertexGradient(bool value);
        /*0x1142bd8*/ TMPro.VertexGradient get_colorGradient();
        /*0x1142bec*/ void set_colorGradient(TMPro.VertexGradient value);
        /*0x1142c14*/ TMPro.TMP_ColorGradient get_colorGradientPreset();
        /*0x1142c1c*/ void set_colorGradientPreset(TMPro.TMP_ColorGradient value);
        /*0x1142c38*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x1142c40*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x1142c7c*/ bool get_tintAllSprites();
        /*0x1142c84*/ void set_tintAllSprites(bool value);
        /*0x1142cb4*/ TMPro.TMP_StyleSheet get_styleSheet();
        /*0x1142cbc*/ void set_styleSheet(TMPro.TMP_StyleSheet value);
        /*0x1142cf8*/ TMPro.TMP_Style get_textStyle();
        /*0x1142e20*/ void set_textStyle(TMPro.TMP_Style value);
        /*0x1142e6c*/ bool get_overrideColorTags();
        /*0x1142e74*/ void set_overrideColorTags(bool value);
        /*0x1142ea4*/ UnityEngine.Color32 get_faceColor();
        /*0x114321c*/ void set_faceColor(UnityEngine.Color32 value);
        /*0x11432a4*/ UnityEngine.Color32 get_outlineColor();
        /*0x114361c*/ void set_outlineColor(UnityEngine.Color32 value);
        /*0x1143690*/ float get_outlineWidth();
        /*0x114374c*/ void set_outlineWidth(float value);
        /*0x11437ac*/ float get_fontSize();
        /*0x11437b4*/ void set_fontSize(float value);
        /*0x1143814*/ TMPro.FontWeight get_fontWeight();
        /*0x114381c*/ void set_fontWeight(TMPro.FontWeight value);
        /*0x114386c*/ float get_pixelsPerUnit();
        /*0x11439dc*/ bool get_enableAutoSizing();
        /*0x11439e4*/ void set_enableAutoSizing(bool value);
        /*0x1143a30*/ float get_fontSizeMin();
        /*0x1143a38*/ void set_fontSizeMin(float value);
        /*0x1143a80*/ float get_fontSizeMax();
        /*0x1143a88*/ void set_fontSizeMax(float value);
        /*0x1143ad0*/ TMPro.FontStyles get_fontStyle();
        /*0x1143ad8*/ void set_fontStyle(TMPro.FontStyles value);
        /*0x1143b28*/ bool get_isUsingBold();
        /*0x1143b30*/ TMPro.HorizontalAlignmentOptions get_horizontalAlignment();
        /*0x1143b38*/ void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value);
        /*0x1143b64*/ TMPro.VerticalAlignmentOptions get_verticalAlignment();
        /*0x1143b6c*/ void set_verticalAlignment(TMPro.VerticalAlignmentOptions value);
        /*0x1143b98*/ TMPro.TextAlignmentOptions get_alignment();
        /*0x1143ba8*/ void set_alignment(TMPro.TextAlignmentOptions value);
        /*0x1143bec*/ float get_characterSpacing();
        /*0x1143bf4*/ void set_characterSpacing(float value);
        /*0x1143c44*/ float get_wordSpacing();
        /*0x1143c4c*/ void set_wordSpacing(float value);
        /*0x1143c9c*/ float get_lineSpacing();
        /*0x1143ca4*/ void set_lineSpacing(float value);
        /*0x1143cf4*/ float get_lineSpacingAdjustment();
        /*0x1143cfc*/ void set_lineSpacingAdjustment(float value);
        /*0x1143d4c*/ float get_paragraphSpacing();
        /*0x1143d54*/ void set_paragraphSpacing(float value);
        /*0x1143da4*/ float get_characterWidthAdjustment();
        /*0x1143dac*/ void set_characterWidthAdjustment(float value);
        /*0x1143dfc*/ bool get_enableWordWrapping();
        /*0x1143e04*/ void set_enableWordWrapping(bool value);
        /*0x1143e58*/ float get_wordWrappingRatios();
        /*0x1143e60*/ void set_wordWrappingRatios(float value);
        /*0x1143eb0*/ TMPro.TextOverflowModes get_overflowMode();
        /*0x1143eb8*/ void set_overflowMode(TMPro.TextOverflowModes value);
        /*0x1143f08*/ bool get_isTextOverflowing();
        /*0x1143f18*/ int get_firstOverflowCharacterIndex();
        /*0x1143f20*/ TMPro.TMP_Text get_linkedTextComponent();
        /*0x1143f28*/ void set_linkedTextComponent(TMPro.TMP_Text value);
        /*0x114420c*/ bool get_isTextTruncated();
        /*0x1144214*/ bool get_enableKerning();
        /*0x114421c*/ void set_enableKerning(bool value);
        /*0x1144270*/ bool get_extraPadding();
        /*0x1144278*/ void set_extraPadding(bool value);
        /*0x11442cc*/ bool get_richText();
        /*0x11442d4*/ void set_richText(bool value);
        /*0x1144328*/ bool get_parseCtrlCharacters();
        /*0x1144330*/ void set_parseCtrlCharacters(bool value);
        /*0x1144384*/ bool get_isOverlay();
        /*0x114438c*/ void set_isOverlay(bool value);
        /*0x11443e0*/ bool get_isOrthographic();
        /*0x11443e8*/ void set_isOrthographic(bool value);
        /*0x1144418*/ bool get_enableCulling();
        /*0x1144420*/ void set_enableCulling(bool value);
        /*0x114445c*/ bool get_ignoreVisibility();
        /*0x1144464*/ void set_ignoreVisibility(bool value);
        /*0x1144484*/ TMPro.TextureMappingOptions get_horizontalMapping();
        /*0x114448c*/ void set_horizontalMapping(TMPro.TextureMappingOptions value);
        /*0x11444b8*/ TMPro.TextureMappingOptions get_verticalMapping();
        /*0x11444c0*/ void set_verticalMapping(TMPro.TextureMappingOptions value);
        /*0x11444ec*/ float get_mappingUvLineOffset();
        /*0x11444f4*/ void set_mappingUvLineOffset(float value);
        /*0x1144520*/ TMPro.TextRenderFlags get_renderMode();
        /*0x1144528*/ void set_renderMode(TMPro.TextRenderFlags value);
        /*0x1144544*/ TMPro.VertexSortingOrder get_geometrySortingOrder();
        /*0x114454c*/ void set_geometrySortingOrder(TMPro.VertexSortingOrder value);
        /*0x1144568*/ bool get_isTextObjectScaleStatic();
        /*0x1144570*/ void set_isTextObjectScaleStatic(bool value);
        /*0x11445f0*/ bool get_vertexBufferAutoSizeReduction();
        /*0x11445f8*/ void set_vertexBufferAutoSizeReduction(bool value);
        /*0x1144618*/ int get_firstVisibleCharacter();
        /*0x1144620*/ void set_firstVisibleCharacter(int value);
        /*0x114464c*/ int get_maxVisibleCharacters();
        /*0x1144654*/ void set_maxVisibleCharacters(int value);
        /*0x1144680*/ int get_maxVisibleWords();
        /*0x1144688*/ void set_maxVisibleWords(int value);
        /*0x11446b4*/ int get_maxVisibleLines();
        /*0x11446bc*/ void set_maxVisibleLines(int value);
        /*0x11446e8*/ bool get_useMaxVisibleDescender();
        /*0x11446f0*/ void set_useMaxVisibleDescender(bool value);
        /*0x1144720*/ int get_pageToDisplay();
        /*0x1144728*/ void set_pageToDisplay(int value);
        /*0x1144754*/ UnityEngine.Vector4 get_margin();
        /*0x1144768*/ void set_margin(UnityEngine.Vector4 value);
        /*0x1144804*/ TMPro.TMP_TextInfo get_textInfo();
        /*0x114480c*/ bool get_havePropertiesChanged();
        /*0x1144814*/ void set_havePropertiesChanged(bool value);
        /*0x114483c*/ bool get_isUsingLegacyAnimationComponent();
        /*0x1144844*/ void set_isUsingLegacyAnimationComponent(bool value);
        /*0x1144850*/ UnityEngine.Transform get_transform();
        /*0x11448e4*/ UnityEngine.RectTransform get_rectTransform();
        /*0x1144978*/ bool get_autoSizeTextContainer();
        /*0x1144980*/ void set_autoSizeTextContainer(bool value);
        /*0x114498c*/ UnityEngine.Mesh get_mesh();
        /*0x1144994*/ bool get_isVolumetricText();
        /*0x114499c*/ void set_isVolumetricText(bool value);
        /*0x1144a04*/ UnityEngine.Bounds get_bounds();
        /*0x1144ab4*/ UnityEngine.Bounds get_textBounds();
        /*0x1145048*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x11450fc*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x11451b0*/ TMPro.TMP_SpriteAnimator get_spriteAnimator();
        /*0x114529c*/ float get_flexibleHeight();
        /*0x11452a4*/ float get_flexibleWidth();
        /*0x11452ac*/ float get_minWidth();
        /*0x11452b4*/ float get_minHeight();
        /*0x11452bc*/ float get_maxWidth();
        /*0x11452c4*/ float get_maxHeight();
        /*0x11452cc*/ UnityEngine.UI.LayoutElement get_layoutElement();
        /*0x1145360*/ float get_preferredWidth();
        /*0x11454b8*/ float get_preferredHeight();
        /*0x114565c*/ float get_renderedWidth();
        /*0x1145664*/ float get_renderedHeight();
        /*0x114568c*/ int get_layoutPriority();
        /*0x1145694*/ void LoadFontAsset();
        /*0x1145698*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x114569c*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x11456a4*/ void SetFontBaseMaterial(UnityEngine.Material mat);
        /*0x11456a8*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x11456b0*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x11456b4*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x11456bc*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x114577c*/ void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient);
        /*0x1145834*/ void SetTextSortingOrder(TMPro.VertexSortingOrder order);
        /*0x1145838*/ void SetTextSortingOrder(int[] order);
        /*0x114583c*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x1145840*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x1145844*/ void SetOutlineThickness(float thickness);
        /*0x1145848*/ void SetShaderDepth();
        /*0x114584c*/ void SetCulling();
        /*0x1145850*/ void UpdateCulling();
        /*0x1145854*/ float GetPaddingForMaterial();
        /*0x1145974*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x1145a74*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x1145a7c*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x1145a80*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x1145a84*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x1145a88*/ void UpdateVertexData();
        /*0x1145a8c*/ void SetVertices(UnityEngine.Vector3[] vertices);
        /*0x1145a90*/ void UpdateMeshPadding();
        /*0x1145a94*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x1145b1c*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x1145b70*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x1145b74*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x1145b78*/ void ParseInputText();
        /*0x1145c78*/ void PopulateTextBackingArray(string sourceText);
        /*0x1146700*/ void PopulateTextBackingArray(string sourceText, int start, int length);
        /*0x11467f8*/ void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length);
        /*0x1146920*/ void PopulateTextBackingArray(char[] sourceText, int start, int length);
        /*0x1145c90*/ void PopulateTextProcessingArray();
        /*0x1147cc8*/ void SetTextInternal(string sourceText);
        /*0x1147d14*/ void SetText(string sourceText, bool syncTextInputBox);
        /*0x1147d90*/ void SetText(string sourceText, float arg0);
        /*0x1148070*/ void SetText(string sourceText, float arg0, float arg1);
        /*0x114808c*/ void SetText(string sourceText, float arg0, float arg1, float arg2);
        /*0x11480a4*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        /*0x11480b8*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        /*0x11480c8*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        /*0x11480d4*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        /*0x1147db0*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        /*0x11483b8*/ void SetText(System.Text.StringBuilder sourceText);
        /*0x11483fc*/ void SetText(System.Text.StringBuilder sourceText, int start, int length);
        /*0x1148458*/ void SetText(char[] sourceText);
        /*0x11484cc*/ void SetText(char[] sourceText, int start, int length);
        /*0x11484d0*/ void SetCharArray(char[] sourceText);
        /*0x1148470*/ void SetCharArray(char[] sourceText, int start, int length);
        /*0x1142d30*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x11470f0*/ bool ReplaceOpeningStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x11488f0*/ bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1147510*/ void ReplaceClosingStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1148d10*/ void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1146a34*/ bool InsertOpeningStyleTag(TMPro.TMP_Style style, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1147900*/ void InsertClosingStyleTag(ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x11487d4*/ int GetMarkupTagHashCode(int[] tagDefinition, int readIndex);
        /*0x1146fe4*/ int GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, int readIndex);
        /*0x1149100*/ int GetStyleHashCode(ref int[] text, int index, ref int closeIndex);
        /*0x11484e8*/ int GetStyleHashCode(ref TMPro.TMP_Text.TextBackingContainer text, int index, ref int closeIndex);
        void ResizeInternalArray<T>(ref T[] array);
        void ResizeInternalArray<T>(ref T[] array, int size);
        /*0x11480dc*/ void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex);
        /*0x11491dc*/ void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex);
        /*0x114259c*/ string InternalTextBackingArrayToString();
        /*0x114930c*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x1149314*/ UnityEngine.Vector2 GetPreferredValues();
        /*0x1149360*/ UnityEngine.Vector2 GetPreferredValues(float width, float height);
        /*0x1149514*/ UnityEngine.Vector2 GetPreferredValues(string text);
        /*0x114963c*/ UnityEngine.Vector2 GetPreferredValues(string text, float width, float height);
        /*0x1145378*/ float GetPreferredWidth();
        /*0x114940c*/ float GetPreferredWidth(UnityEngine.Vector2 margin);
        /*0x11454d0*/ float GetPreferredHeight();
        /*0x1149468*/ float GetPreferredHeight(UnityEngine.Vector2 margin);
        /*0x1149700*/ UnityEngine.Vector2 GetRenderedValues();
        /*0x1149740*/ UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        /*0x1145660*/ float GetRenderedWidth();
        /*0x1149960*/ float GetRenderedWidth(bool onlyVisibleCharacters);
        /*0x1145678*/ float GetRenderedHeight();
        /*0x1149968*/ float GetRenderedHeight(bool onlyVisibleCharacters);
        /*0x1149980*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled);
        /*0x1152054*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x1152060*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x1144af8*/ UnityEngine.Bounds GetTextBounds();
        /*0x1149784*/ UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters);
        /*0x1152068*/ void AdjustLineOffset(int startIndex, int endIndex, float offset);
        /*0x1152220*/ void ResizeLineExtents(int size);
        /*0x11523c8*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x11523d0*/ void ComputeMarginSize();
        /*0x11523d4*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        /*0x1151d94*/ void SaveWordWrappingState(ref TMPro.WordWrapState state, int index, int count);
        /*0x1151aac*/ int RestoreWordWrappingState(ref TMPro.WordWrapState state);
        /*0x11528a0*/ void SaveGlyphVertexInfo(float padding, float style_padding, UnityEngine.Color32 vertexColor);
        /*0x1155b80*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor);
        /*0x1157dc0*/ void FillCharacterVertexBuffers(int i, int index_X4);
        /*0x1158498*/ void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric);
        /*0x1158f7c*/ void FillSpriteVertexBuffers(int i, int index_X4);
        /*0x1159654*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor);
        /*0x115a5c4*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor);
        /*0x115aa9c*/ void LoadDefaultSettings();
        /*0x115ad10*/ void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset);
        /*0x115ad38*/ void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x115a414*/ void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x115af7c*/ void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        /*0x115aff4*/ TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        /*0x115b06c*/ TMPro.TMP_TextElement GetTextElement(uint unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isUsingAlternativeTypeface);
        /*0x115b450*/ void SetActiveSubMeshes(bool state);
        /*0x115b454*/ void DestroySubMeshObjects();
        /*0x115b458*/ void ClearMesh();
        /*0x115b45c*/ void ClearMesh(bool uploadGeometry);
        /*0x115b460*/ string GetParsedText();
        /*0x114412c*/ bool IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent);
        /*0x1144014*/ void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent);
        /*0x115a564*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
        /*0x115b558*/ float PackUV(float x, float y);
        /*0x115b5b8*/ void InternalUpdate();
        /*0x115b5bc*/ int HexToInt(char hex);
        /*0x115b5e8*/ int GetUTF16(string text, int i);
        /*0x11485f4*/ int GetUTF16(int[] text, int i);
        /*0x115b690*/ int GetUTF16(uint[] text, int i);
        /*0x115b738*/ int GetUTF16(System.Text.StringBuilder text, int i);
        /*0x1146e04*/ int GetUTF16(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x115b7e0*/ int GetUTF32(string text, int i);
        /*0x114869c*/ int GetUTF32(int[] text, int i);
        /*0x115b918*/ int GetUTF32(uint[] text, int i);
        /*0x115ba50*/ int GetUTF32(System.Text.StringBuilder text, int i);
        /*0x1146eac*/ int GetUTF32(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x115bb88*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
        /*0x115bf9c*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        /*0x115c1e8*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
        /*0x115c418*/ float ConvertToFloat(char[] chars, int startIndex, int length);
        /*0x115c294*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
        /*0x114ba2c*/ bool ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, int startIndex, ref int endIndex);

        struct CharacterSubstitution
        {
            /*0x10*/ int index;
            /*0x14*/ uint unicode;

            /*0x121b5e4*/ CharacterSubstitution(int index, uint unicode);
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

            /*0x121b5ec*/ SpecialCharacter(TMPro.TMP_Character character, int materialIndex);
        }

        struct TextBackingContainer
        {
            /*0x10*/ uint[] m_Array;
            /*0x18*/ int m_Count;

            /*0x121b7f8*/ TextBackingContainer(int size);
            /*0x121b6d8*/ int get_Capacity();
            /*0x121b6f4*/ int get_Count();
            /*0x121b6fc*/ void set_Count(int value);
            /*0x121b704*/ uint get_Item(int index);
            /*0x121b734*/ void set_Item(int index, uint value);
            /*0x121b794*/ void Resize(int size);
        }

        class <>c
        {
            static /*0x0*/ TMPro.TMP_Text.<> <>9;
            static /*0x8*/ System.Action<TMPro.TMP_TextInfo> <>9__622_0;

            static /*0x121b858*/ <>c();
            /*0x121b8bc*/ <>c();
            /*0x121b8c4*/ void <.ctor>b__622_0(TMPro.TMP_TextInfo <p0>);
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

        /*0x121838c*/ TMP_TextElement();
        /*0x121b8c8*/ TMPro.TextElementType get_elementType();
        /*0x121b8d0*/ uint get_unicode();
        /*0x121b8d8*/ void set_unicode(uint value);
        /*0x121b8e0*/ TMPro.TMP_Asset get_textAsset();
        /*0x121b8e8*/ void set_textAsset(TMPro.TMP_Asset value);
        /*0x121b8f0*/ UnityEngine.TextCore.Glyph get_glyph();
        /*0x121b8f8*/ void set_glyph(UnityEngine.TextCore.Glyph value);
        /*0x121b900*/ uint get_glyphIndex();
        /*0x121b908*/ void set_glyphIndex(uint value);
        /*0x121b910*/ float get_scale();
        /*0x121b918*/ void set_scale(float value);
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

        /*0x1215a14*/ TMP_TextElement_Legacy();
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

        static /*0x121c5f4*/ TMP_TextInfo();
        static void Resize<T>(ref T[] array, int size);
        static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
        /*0x121b920*/ TMP_TextInfo();
        /*0x121ba48*/ TMP_TextInfo(int characterCount);
        /*0x121bb74*/ TMP_TextInfo(TMPro.TMP_Text textComponent);
        /*0x121bce0*/ void Clear();
        /*0x121bd3c*/ void ClearAllData();
        /*0x121be68*/ void ClearMeshInfo(bool updateMesh);
        /*0x121bed8*/ void ClearAllMeshInfo();
        /*0x121bf3c*/ void ResetVertexLayout(bool isVolumetric);
        /*0x121bfb0*/ void ClearUnusedVertices(TMPro.MaterialReference[] materials);
        /*0x121c014*/ void ClearLineInfo();
        /*0x121c194*/ void ClearPageInfo();
        /*0x121c22c*/ TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData();
    }

    class TMP_TextParsingUtilities
    {
        static string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ TMPro.TMP_TextParsingUtilities s_Instance;

        static /*0x121c660*/ TMP_TextParsingUtilities();
        static /*0x121c6cc*/ TMPro.TMP_TextParsingUtilities get_instance();
        static /*0x12187d0*/ int GetHashCode(string s);
        static /*0x1218318*/ int GetHashCodeCaseSensitive(string s);
        static /*0x121c798*/ char ToLowerASCIIFast(char c);
        static /*0x121c724*/ char ToUpperASCIIFast(char c);
        static /*0x121c80c*/ uint ToUpperASCIIFast(uint c);
        static /*0x121c880*/ uint ToLowerASCIIFast(uint c);
        static /*0x121c8f4*/ bool IsHighSurrogate(uint c);
        static /*0x121c908*/ bool IsLowSurrogate(uint c);
        static /*0x121c91c*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
        /*0x121c6c4*/ TMP_TextParsingUtilities();
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

        /*0x121c930*/ void Clear();
        /*0x121c93c*/ byte Add(TMPro.FontStyles style);
        /*0x121ca38*/ byte Remove(TMPro.FontStyles style);
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

        static void SetDefault(TMPro.TMP_TextProcessingStack<T> stack, T item);
        TMP_TextProcessingStack(T[] stack);
        TMP_TextProcessingStack(int capacity);
        TMP_TextProcessingStack(int capacity, int rolloverSize);
        int get_Count();
        T get_current();
        int get_rolloverSize();
        void set_rolloverSize(int value);
        void Clear();
        void SetDefault(T item);
        void Add(T item);
        T Remove();
        void Push(T item);
        T Pop();
        T Peek();
        T CurrentItem();
        T PreviousItem();
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

        /*0x121cb58*/ CaretInfo(int index, TMPro.CaretPosition position);
    }

    class TMP_TextUtilities
    {
        static string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ UnityEngine.Vector3[] m_rectWorldCorners;

        static /*0x121f880*/ TMP_TextUtilities();
        static /*0x121cb60*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121d1fc*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, ref TMPro.CaretPosition cursor);
        static /*0x121d3dc*/ int FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121d55c*/ int FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, int line, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x121da5c*/ bool IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121db78*/ int FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x121ccc4*/ int FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x121dd84*/ int FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121e198*/ int FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121e760*/ int FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121e8b8*/ int FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121ebf4*/ int FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x121d8d4*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
        static /*0x121d000*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x121f310*/ bool IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, ref UnityEngine.Vector3 intersectingPoint);
        static /*0x121d994*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
        static /*0x121f47c*/ char ToLowerFast(char c);
        static /*0x121f4f0*/ char ToUpperFast(char c);
        static /*0x121f564*/ uint ToUpperASCIIFast(uint c);
        static /*0x121f5d8*/ int GetHashCode(string s);
        static /*0x1217434*/ int GetSimpleHashCode(string s);
        static /*0x121f694*/ uint GetSimpleHashCodeLowercase(string s);
        static /*0x121f750*/ int HexToInt(char hex);
        static /*0x121f77c*/ int StringHexToInt(string s);

        struct LineSegment
        {
            /*0x10*/ UnityEngine.Vector3 Point1;
            /*0x1c*/ UnityEngine.Vector3 Point2;

            /*0x12ea264*/ LineSegment(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
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

        static /*0x12eafb8*/ TMP_UpdateManager();
        static /*0x12ea274*/ TMPro.TMP_UpdateManager get_instance();
        static /*0x12ea4e8*/ void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x12ea65c*/ void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        static /*0x12ea7d0*/ void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        static /*0x12ea944*/ void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        static /*0x12ead10*/ void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x12eae08*/ void UnRegisterTextElementForRebuild(TMPro.TMP_Text element);
        /*0x12ea31c*/ TMP_UpdateManager();
        /*0x12ea548*/ void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        /*0x12ea6bc*/ void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x12ea830*/ void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x12ea9a4*/ void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        /*0x12eaab8*/ void OnCameraPreCull();
        /*0x12eaabc*/ void DoRebuilds();
        /*0x12eae88*/ void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x12eaf20*/ void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x12ead70*/ void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
    }

    class TMP_UpdateRegistry
    {
        static /*0x0*/ TMPro.TMP_UpdateRegistry s_Instance;
        /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        /*0x18*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        /*0x28*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;

        static /*0x12eb11c*/ TMPro.TMP_UpdateRegistry get_instance();
        static /*0x12eb2f4*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x12eb470*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x12eb8b0*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x12eb198*/ TMP_UpdateRegistry();
        /*0x12eb314*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x12eb490*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x12eb5ec*/ void PerformUpdateForCanvasRendererObjects();
        /*0x12eb848*/ void PerformUpdateForMeshRendererObjects();
        /*0x12eb8e0*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x12eb9bc*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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
            /*0x12eba98*/ TexturePacker_JsonArray();

            struct SpriteFrame
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float w;
                /*0x1c*/ float h;

                /*0x12ebaa0*/ string ToString();
            }

            struct SpriteSize
            {
                /*0x10*/ float w;
                /*0x14*/ float h;

                /*0x12ebd18*/ string ToString();
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

                /*0x12ebdc4*/ SpriteDataObject();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

    struct __StaticArrayInitTypeSize=12
    {
    }
}
