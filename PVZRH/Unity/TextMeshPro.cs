class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1453af0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    class FastAction
    {
        /*0x10*/ System.Collections.Generic.LinkedList<System.Action> delegates;
        /*0x18*/ System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup;

        /*0x143e380*/ FastAction();
        /*0x143e170*/ void Add(System.Action rhs);
        /*0x143e2c0*/ void Remove(System.Action rhs);
        /*0x143e230*/ void Call();
    }

    class FastAction<A>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup;

        /*0x180fc0*/ FastAction();
        /*0x17aec0*/ void Add(System.Action<A> rhs);
        /*0x17aec0*/ void Remove(System.Action<A> rhs);
        /*0x2a5510*/ void Call(A a);
    }

    class FastAction<A, B>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup;

        /*0x180fc0*/ FastAction();
        /*0x17aec0*/ void Add(System.Action<A, B> rhs);
        /*0x17aec0*/ void Remove(System.Action<A, B> rhs);
        /*0x2a5510*/ void Call(A a, B b);
    }

    class FastAction<A, B, C>
    {
        /*0x0*/ System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates;
        /*0x0*/ System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup;

        /*0x180fc0*/ FastAction();
        /*0x17aec0*/ void Add(System.Action<A, B, C> rhs);
        /*0x17aec0*/ void Remove(System.Action<A, B, C> rhs);
        /*0x2a5510*/ void Call(A a, B b, C c);
    }

    interface ITextPreprocessor
    {
        /*0x1858d0*/ string PreprocessText(string text);
    }

    class MaterialReferenceManager
    {
        static /*0x0*/ TMPro.MaterialReferenceManager s_Instance;
        /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
        /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> m_FontAssetReferenceLookup;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
        /*0x28*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_ColorGradient> m_ColorGradientReferenceLookup;

        static /*0x143f0d0*/ TMPro.MaterialReferenceManager get_instance();
        static /*0x143e620*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x143e930*/ void AddSpriteAsset(TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x143e9f0*/ void AddSpriteAsset(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x143e750*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
        static /*0x143e4d0*/ void AddColorGradientPreset(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        static /*0x143ed00*/ bool TryGetFontAsset(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x143ef00*/ bool TryGetSpriteAsset(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        static /*0x143ec00*/ bool TryGetColorGradientPreset(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        static /*0x143ee00*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
        /*0x143ef80*/ MaterialReferenceManager();
        /*0x143e570*/ void AddFontAssetInternal(TMPro.TMP_FontAsset fontAsset);
        /*0x143e7c0*/ void AddSpriteAssetInternal(TMPro.TMP_SpriteAsset spriteAsset);
        /*0x143e870*/ void AddSpriteAssetInternal(int hashCode, TMPro.TMP_SpriteAsset spriteAsset);
        /*0x143e6e0*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
        /*0x143e440*/ void AddColorGradientPreset_Internal(int hashCode, TMPro.TMP_ColorGradient spriteAsset);
        /*0x143eac0*/ bool Contains(TMPro.TMP_FontAsset font);
        /*0x143eb20*/ bool Contains(TMPro.TMP_SpriteAsset sprite);
        /*0x143ec80*/ bool TryGetFontAssetInternal(int hashCode, ref TMPro.TMP_FontAsset fontAsset);
        /*0x143ee80*/ bool TryGetSpriteAssetInternal(int hashCode, ref TMPro.TMP_SpriteAsset spriteAsset);
        /*0x143eb80*/ bool TryGetColorGradientPresetInternal(int hashCode, ref TMPro.TMP_ColorGradient gradientPreset);
        /*0x143ed80*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
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

        static /*0x143f740*/ bool Contains(TMPro.MaterialReference[] materialReferences, TMPro.TMP_FontAsset fontAsset);
        static /*0x143f4e0*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_FontAsset fontAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        static /*0x143f2a0*/ int AddMaterialReference(UnityEngine.Material material, TMPro.TMP_SpriteAsset spriteAsset, ref TMPro.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
        /*0x143f830*/ MaterialReference(int index, TMPro.TMP_FontAsset fontAsset, TMPro.TMP_SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
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

        static /*0x1441570*/ TextContainer();
        /*0x14415b0*/ TextContainer();
        /*0x796120*/ bool get_hasChanged();
        /*0x7963b0*/ void set_hasChanged(bool value);
        /*0x1441650*/ UnityEngine.Vector2 get_pivot();
        /*0x14419d0*/ void set_pivot(UnityEngine.Vector2 value);
        /*0xbe6c70*/ TMPro.TextContainerAnchors get_anchorPosition();
        /*0x14417c0*/ void set_anchorPosition(TMPro.TextContainerAnchors value);
        /*0x10daa90*/ UnityEngine.Rect get_rect();
        /*0x1441a50*/ void set_rect(UnityEngine.Rect value);
        /*0x1441700*/ UnityEngine.Vector2 get_size();
        /*0x1441ab0*/ void set_size(UnityEngine.Vector2 value);
        /*0x14417b0*/ float get_width();
        /*0x1441b40*/ void set_width(float value);
        /*0x1441630*/ float get_height();
        /*0x14418f0*/ void set_height(float value);
        /*0xb61dd0*/ bool get_isDefaultWidth();
        /*0xf17ee0*/ bool get_isDefaultHeight();
        /*0x133a5d0*/ bool get_isAutoFitting();
        /*0x133a600*/ void set_isAutoFitting(bool value);
        /*0x4e40d0*/ UnityEngine.Vector3[] get_corners();
        /*0x4e40e0*/ UnityEngine.Vector3[] get_worldCorners();
        /*0x1441640*/ UnityEngine.Vector4 get_margins();
        /*0x1441940*/ void set_margins(UnityEngine.Vector4 value);
        /*0x1441670*/ UnityEngine.RectTransform get_rectTransform();
        /*0x1441720*/ TMPro.TextMeshPro get_textMeshPro();
        /*0x1440b10*/ void Awake();
        /*0x14410b0*/ void OnEnable();
        /*0x32d010*/ void OnDisable();
        /*0x1440f20*/ void OnContainerChanged();
        /*0x14410c0*/ void OnRectTransformDimensionsChange();
        /*0x1441380*/ void SetRect(UnityEngine.Vector2 size);
        /*0x14413d0*/ void UpdateCorners();
        /*0x1440dd0*/ UnityEngine.Vector2 GetPivot(TMPro.TextContainerAnchors anchor);
        /*0x1440bc0*/ TMPro.TextContainerAnchors GetAnchorPosition(UnityEngine.Vector2 pivot);
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
        /*0x6d0*/ int _SortingLayer;
        /*0x6d4*/ int _SortingLayerID;
        /*0x6d8*/ int _SortingOrder;
        /*0x6e0*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x6e8*/ bool m_currentAutoSizeMode;
        /*0x6e9*/ bool m_hasFontAssetChanged;
        /*0x6ec*/ float m_previousLossyScaleY;
        /*0x6f0*/ UnityEngine.Renderer m_renderer;
        /*0x6f8*/ UnityEngine.MeshFilter m_meshFilter;
        /*0x700*/ bool m_isFirstAllocation;
        /*0x704*/ int m_max_characters;
        /*0x708*/ int m_max_numberOfLines;
        /*0x710*/ TMPro.TMP_SubMesh[] m_subTextObjects;
        /*0x718*/ TMPro.MaskingTypes m_maskType;
        /*0x71c*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x760*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x768*/ bool m_isRegisteredForEvents;

        static /*0x14528f0*/ TextMeshPro();
        /*0x1452dc0*/ TextMeshPro();
        /*0x1453200*/ int get_sortingLayerID();
        /*0x1453520*/ void set_sortingLayerID(int value);
        /*0x1453290*/ int get_sortingOrder();
        /*0x14536e0*/ void set_sortingOrder(int value);
        /*0x144ac80*/ bool get_autoSizeTextContainer();
        /*0x1453480*/ void set_autoSizeTextContainer(bool value);
        /*0x388e90*/ TMPro.TextContainer get_textContainer();
        /*0x1453320*/ UnityEngine.Transform get_transform();
        /*0x1453160*/ UnityEngine.Renderer get_renderer();
        /*0x1453090*/ UnityEngine.Mesh get_mesh();
        /*0x1452f60*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x1452f50*/ TMPro.MaskingTypes get_maskType();
        /*0x1453510*/ void set_maskType(TMPro.MaskingTypes value);
        /*0x1450980*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords);
        /*0x1450bd0*/ void SetMask(TMPro.MaskingTypes type, UnityEngine.Vector4 maskCoords, float softnessX, float softnessY);
        /*0x14518d0*/ void SetVerticesDirty();
        /*0x1450710*/ void SetLayoutDirty();
        /*0x1450ce0*/ void SetMaterialDirty();
        /*0x14451d0*/ void SetAllDirty();
        /*0x144d580*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x1451db0*/ void UpdateMaterial();
        /*0x1451ef0*/ void UpdateMeshPadding();
        /*0x144bb90*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x144c500*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x144b3d0*/ void ClearMesh(bool updateMesh);
        /*0x1452e90*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x14533c0*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x1451c50*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x14524d0*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x14526c0*/ void UpdateVertexData();
        /*0x14495f0*/ void UpdateFontAsset();
        /*0x32d010*/ void CalculateLayoutInputHorizontal();
        /*0x32d010*/ void CalculateLayoutInputVertical();
        /*0x144af30*/ void Awake();
        /*0x144ced0*/ void OnEnable();
        /*0x144ce30*/ void OnDisable();
        /*0x144cd30*/ void OnDestroy();
        /*0x144c640*/ void LoadFontAsset();
        /*0x1451970*/ void UpdateEnvMapMatrix();
        /*0x1450a20*/ void SetMask(TMPro.MaskingTypes maskType);
        /*0x14508f0*/ void SetMaskCoordinates(UnityEngine.Vector4 coords);
        /*0x14507e0*/ void SetMaskCoordinates(UnityEngine.Vector4 coords, float softX, float softY);
        /*0x144ba50*/ void EnableMasking();
        /*0x144b800*/ void DisableMasking();
        /*0x1451c70*/ void UpdateMask();
        /*0x144bea0*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x144bfe0*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x1448a80*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x144c230*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x1451470*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x14510d0*/ void SetOutlineThickness(float thickness);
        /*0x1450580*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x1450f40*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x144b610*/ void CreateMaterialInstance();
        /*0x1451320*/ void SetShaderDepth();
        /*0x1450230*/ void SetCulling();
        /*0x1451260*/ void SetPerspectiveCorrection();
        /*0x144d910*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x144b4c0*/ void ComputeMarginSize();
        /*0x144ce00*/ void OnDidApplyAnimationProperties();
        /*0x144d540*/ void OnTransformParentChanged();
        /*0x144d390*/ void OnRectTransformDimensionsChange();
        /*0x144c580*/ void InternalUpdate();
        /*0x144cfd0*/ void OnPreRenderObject();
        /*0x1426950*/ void GenerateTextMesh();
        /*0x144c450*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x1450d00*/ void SetMeshFilters(bool state);
        /*0x144d660*/ void SetActiveSubMeshes(bool state);
        /*0x144d7a0*/ void SetActiveSubTextObjectRenderers(bool state);
        /*0x144b6f0*/ void DestroySubMeshObjects();
        /*0x1452230*/ void UpdateSubMeshSortingLayerID(int id);
        /*0x1452380*/ void UpdateSubMeshSortingOrder(int order);
        /*0x144bbb0*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x1452020*/ void UpdateSDFScale(float scaleDelta);
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
        /*0x6d0*/ bool m_isRebuildingLayout;
        /*0x6d8*/ UnityEngine.Coroutine m_DelayedGraphicRebuild;
        /*0x6e0*/ UnityEngine.Coroutine m_DelayedMaterialRebuild;
        /*0x6e8*/ UnityEngine.Rect m_ClipRect;
        /*0x6f8*/ bool m_ValidRect;
        /*0x700*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x708*/ bool m_hasFontAssetChanged;
        /*0x710*/ TMPro.TMP_SubMeshUI[] m_subTextObjects;
        /*0x718*/ float m_previousLossyScaleY;
        /*0x720*/ UnityEngine.Vector3[] m_RectTransformCorners;
        /*0x728*/ UnityEngine.CanvasRenderer m_canvasRenderer;
        /*0x730*/ UnityEngine.Canvas m_canvas;
        /*0x738*/ float m_CanvasScaleFactor;
        /*0x73c*/ bool m_isFirstAllocation;
        /*0x740*/ int m_max_characters;
        /*0x748*/ UnityEngine.Material m_baseMaterial;
        /*0x750*/ bool m_isScrollRegionSet;
        /*0x754*/ UnityEngine.Vector4 m_maskOffset;
        /*0x764*/ UnityEngine.Matrix4x4 m_EnvMapMatrix;
        /*0x7a4*/ bool m_isRegisteredForEvents;

        static /*0x144a620*/ TextMeshProUGUI();
        /*0x144aaf0*/ TextMeshProUGUI();
        /*0x144ad40*/ UnityEngine.Material get_materialForRendering();
        /*0x144ac80*/ bool get_autoSizeTextContainer();
        /*0x144ae70*/ void set_autoSizeTextContainer(bool value);
        /*0x144ada0*/ UnityEngine.Mesh get_mesh();
        /*0x144ac90*/ UnityEngine.CanvasRenderer get_canvasRenderer();
        /*0x32d010*/ void CalculateLayoutInputHorizontal();
        /*0x32d010*/ void CalculateLayoutInputVertical();
        /*0x1449010*/ void SetVerticesDirty();
        /*0x1448220*/ void SetLayoutDirty();
        /*0x1448300*/ void SetMaterialDirty();
        /*0x14451d0*/ void SetAllDirty();
        /*0x1442510*/ System.Collections.IEnumerator DelayedGraphicRebuild();
        /*0x1442580*/ System.Collections.IEnumerator DelayedMaterialRebuild();
        /*0x1444fa0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x144a060*/ void UpdateSubObjectPivot();
        /*0x1443460*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x1449b20*/ void UpdateMaterial();
        /*0x144ad30*/ UnityEngine.Vector4 get_maskOffset();
        /*0x144af00*/ void set_maskOffset(UnityEngine.Vector4 value);
        /*0x1445080*/ void RecalculateClipping();
        /*0x1442270*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x14490e0*/ void UpdateCulling();
        /*0x1449c80*/ void UpdateMeshPadding();
        /*0x1443a70*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x1443990*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x1442940*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x1443890*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x1441ff0*/ void ClearMesh();
        /*0x144abc0*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x144adb0*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x1449610*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x144a160*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x144a3a0*/ void UpdateVertexData();
        /*0x14495f0*/ void UpdateFontAsset();
        /*0x1441b90*/ void Awake();
        /*0x14446d0*/ void OnEnable();
        /*0x1444540*/ void OnDisable();
        /*0x1444390*/ void OnDestroy();
        /*0x1443c50*/ void LoadFontAsset();
        /*0x1442c60*/ UnityEngine.Canvas GetCanvas();
        /*0x1449310*/ void UpdateEnvMapMatrix();
        /*0x1442700*/ void EnableMasking();
        /*0x32d010*/ void DisableMasking();
        /*0x14496a0*/ void UpdateMask();
        /*0x14430a0*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x1443210*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x1448a80*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x14435c0*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x1448ae0*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x1448640*/ void SetOutlineThickness(float thickness);
        /*0x1448080*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x14484a0*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x1448930*/ void SetShaderDepth();
        /*0x1447ce0*/ void SetCulling();
        /*0x1448870*/ void SetPerspectiveCorrection();
        /*0x14483e0*/ void SetMeshArrays(int size);
        /*0x1445220*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x1442120*/ void ComputeMarginSize();
        /*0x1444500*/ void OnDidApplyAnimationProperties();
        /*0x1444260*/ void OnCanvasHierarchyChanged();
        /*0x1444f40*/ void OnTransformParentChanged();
        /*0x1444c10*/ void OnRectTransformDimensionsChange();
        /*0x1443b90*/ void InternalUpdate();
        /*0x1444950*/ void OnPreRenderCanvas();
        /*0x14322c0*/ void GenerateTextMesh();
        /*0x14437e0*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x1445090*/ void SetActiveSubMeshes(bool state);
        /*0x14425f0*/ void DestroySubMeshObjects();
        /*0x1442db0*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x14429f0*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x1449db0*/ void UpdateSDFScale(float scaleDelta);

        class <DelayedGraphicRebuild>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x32f460*/ <DelayedGraphicRebuild>d__18(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14538a0*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1453980*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DelayedMaterialRebuild>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TextMeshProUGUI <>4__this;

            /*0x32f460*/ <DelayedMaterialRebuild>d__19(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14539c0*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1453ab0*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x143ff30*/ TMPro_EventManager();
        static /*0x143fb30*/ void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat);
        static /*0x143faa0*/ void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x143fc20*/ void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x143fcb0*/ void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x143fa00*/ void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial);
        static /*0x143fe50*/ void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged);
        static /*0x143f8f0*/ void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj);
        static /*0x143fdd0*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        static /*0x143fed0*/ void ON_TMP_SETTINGS_CHANGED();
        static /*0x143fbc0*/ void ON_RESOURCES_LOADED();
        static /*0x143fd40*/ void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj);
        static /*0x143f970*/ void ON_COMPUTE_DT_EVENT(object Sender, TMPro.Compute_DT_EventArgs e);
    }

    class Compute_DT_EventArgs
    {
        /*0x10*/ TMPro.Compute_DistanceTransform_EventTypes EventType;
        /*0x14*/ float ProgressPercentage;
        /*0x18*/ UnityEngine.Color[] Colors;

        /*0x143e130*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, float progress);
        /*0x12f3850*/ Compute_DT_EventArgs(TMPro.Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors);
    }

    class TMPro_ExtensionMethods
    {
        static /*0x14409a0*/ int[] ToIntArray(string text);
        static /*0x1440360*/ string ArrayToString(char[] chars);
        static /*0x1440610*/ string IntToString(int[] unicodes);
        static /*0x1440a40*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
        static /*0x14406a0*/ string IntToString(int[] unicodes, int start, int length);
        static /*0x2a5510*/ int FindInstanceID<T>(System.Collections.Generic.List<T> list, T target);
        static /*0x1440470*/ bool Compare(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x1440440*/ bool CompareRGB(UnityEngine.Color32 a, UnityEngine.Color32 b);
        static /*0x1245350*/ bool Compare(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x1236c60*/ bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x14407e0*/ UnityEngine.Color32 Multiply(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x14407e0*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
        static /*0x14408c0*/ UnityEngine.Color32 Tint(UnityEngine.Color32 c1, float tint);
        static /*0x14407b0*/ UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2);
        static /*0x1440580*/ bool Compare(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, int accuracy);
        static /*0x14404b0*/ bool Compare(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2, int accuracy);
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

        static /*0x1477040*/ TMP_Math();
        static /*0x1477010*/ bool Approximately(float a, float b);
        static /*0x10ef130*/ int Mod(int a, int b);
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

        /*0x1477930*/ VertexGradient(UnityEngine.Color color);
        /*0x11fcab0*/ VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
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

        /*0x1476f30*/ void SetLinkID(char[] text, int startIndex, int length);
        /*0x1476e20*/ string GetLinkText();
        /*0x1476d80*/ string GetLinkID();
    }

    struct TMP_WordInfo
    {
        /*0x10*/ TMPro.TMP_Text textComponent;
        /*0x18*/ int firstCharacterIndex;
        /*0x1c*/ int lastCharacterIndex;
        /*0x20*/ int characterCount;

        /*0x14773c0*/ string GetWord();
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

        static /*0x1454240*/ Extents();
        /*0xbee490*/ Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x1454060*/ string ToString();
    }

    struct Mesh_Extents
    {
        /*0x10*/ UnityEngine.Vector2 min;
        /*0x18*/ UnityEngine.Vector2 max;

        /*0xbee490*/ Mesh_Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max);
        /*0x14553b0*/ string ToString();
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

        /*0x533ec0*/ TMP_Asset();
        /*0x1455610*/ int get_instanceID();
    }

    class TMP_Character : TMPro.TMP_TextElement
    {
        /*0x1455640*/ TMP_Character();
        /*0x14556d0*/ TMP_Character(uint unicode, UnityEngine.TextCore.Glyph glyph);
        /*0x1455750*/ TMP_Character(uint unicode, TMPro.TMP_FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
        /*0x1455670*/ TMP_Character(uint unicode, uint glyphIndex);
    }

    struct TMP_Vertex
    {
        static /*0x0*/ TMPro.TMP_Vertex k_Zero;
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ UnityEngine.Vector2 uv;
        /*0x24*/ UnityEngine.Vector2 uv2;
        /*0x2c*/ UnityEngine.Vector2 uv4;
        /*0x34*/ UnityEngine.Color32 color;

        static /*0x32d010*/ TMP_Vertex();
        static /*0x1477350*/ TMPro.TMP_Vertex get_zero();
    }

    struct TMP_Offset
    {
        static /*0x0*/ TMPro.TMP_Offset k_ZeroOffset;
        /*0x10*/ float m_Left;
        /*0x14*/ float m_Right;
        /*0x18*/ float m_Top;
        /*0x1c*/ float m_Bottom;

        static /*0x14771d0*/ TMP_Offset();
        static /*0x1477230*/ TMPro.TMP_Offset get_zero();
        static /*0x1245350*/ bool op_Equality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x1477290*/ bool op_Inequality(TMPro.TMP_Offset lhs, TMPro.TMP_Offset rhs);
        static /*0x10c62d0*/ TMPro.TMP_Offset op_Multiply(TMPro.TMP_Offset a, float b);
        /*0x11534a0*/ TMP_Offset(float left, float right, float top, float bottom);
        /*0x1477210*/ TMP_Offset(float horizontal, float vertical);
        /*0xf72200*/ float get_left();
        /*0x14668c0*/ void set_left(float value);
        /*0xa5a890*/ float get_right();
        /*0x14668d0*/ void set_right(float value);
        /*0xa5a910*/ float get_top();
        /*0x14544b0*/ void set_top(float value);
        /*0x1202400*/ float get_bottom();
        /*0x1202470*/ void set_bottom(float value);
        /*0xf72200*/ float get_horizontal();
        /*0x12303b0*/ void set_horizontal(float value);
        /*0xa5a910*/ float get_vertical();
        /*0x1477340*/ void set_vertical(float value);
        /*0x1477180*/ int GetHashCode();
        /*0x1477120*/ bool Equals(object obj);
        /*0x14770a0*/ bool Equals(TMPro.TMP_Offset other);
    }

    struct HighlightState
    {
        /*0x10*/ UnityEngine.Color32 color;
        /*0x14*/ TMPro.TMP_Offset padding;

        static /*0x14547e0*/ bool op_Equality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        static /*0x14548d0*/ bool op_Inequality(TMPro.HighlightState lhs, TMPro.HighlightState rhs);
        /*0xa5a210*/ HighlightState(UnityEngine.Color32 color, TMPro.TMP_Offset padding);
        /*0x1454780*/ int GetHashCode();
        /*0x1454680*/ bool Equals(object obj);
        /*0x14546f0*/ bool Equals(TMPro.HighlightState other);
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

        static /*0x14557e0*/ TMP_ColorGradient();
        /*0x1455820*/ TMP_ColorGradient();
        /*0x14558d0*/ TMP_ColorGradient(UnityEngine.Color color);
        /*0x1455920*/ TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
    }

    class TMP_Compatibility
    {
        static /*0x1455990*/ TMPro.TextAlignmentOptions ConvertTextAlignmentEnumValues(TMPro.TextAlignmentOptions oldValue);

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
        /*0x178d00*/ void TweenValue(float floatPercentage);
        /*0x17cb40*/ bool get_ignoreTimeScale();
        /*0x17fc30*/ float get_duration();
        /*0x17cb40*/ bool ValidTarget();
    }

    struct ColorTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.ColorTween.ColorTweenCallback m_Target;
        /*0x18*/ UnityEngine.Color m_StartColor;
        /*0x28*/ UnityEngine.Color m_TargetColor;
        /*0x38*/ TMPro.ColorTween.ColorTweenMode m_TweenMode;
        /*0x3c*/ float m_Duration;
        /*0x40*/ bool m_IgnoreTimeScale;

        /*0xa5a790*/ UnityEngine.Color get_startColor();
        /*0xf2b430*/ void set_startColor(UnityEngine.Color value);
        /*0x716050*/ UnityEngine.Color get_targetColor();
        /*0xdd5220*/ void set_targetColor(UnityEngine.Color value);
        /*0x3e3ae0*/ TMPro.ColorTween.ColorTweenMode get_tweenMode();
        /*0xc6dab0*/ void set_tweenMode(TMPro.ColorTween.ColorTweenMode value);
        /*0x4ccc40*/ float get_duration();
        /*0x4ccc50*/ void set_duration(float value);
        /*0x995050*/ bool get_ignoreTimeScale();
        /*0x995180*/ void set_ignoreTimeScale(bool value);
        /*0x1453de0*/ void TweenValue(float floatPercentage);
        /*0x1453d20*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
        /*0x995050*/ bool GetIgnoreTimescale();
        /*0x4ccc40*/ float GetDuration();
        /*0xfbe040*/ bool ValidTarget();

        enum ColorTweenMode
        {
            All = 0,
            RGB = 1,
            Alpha = 2,
        }

        class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
        {
            /*0x1453ce0*/ ColorTweenCallback();
        }
    }

    struct FloatTween : TMPro.ITweenValue
    {
        /*0x10*/ TMPro.FloatTween.FloatTweenCallback m_Target;
        /*0x18*/ float m_StartValue;
        /*0x1c*/ float m_TargetValue;
        /*0x20*/ float m_Duration;
        /*0x24*/ bool m_IgnoreTimeScale;

        /*0xa5a910*/ float get_startValue();
        /*0x14544b0*/ void set_startValue(float value);
        /*0x1202400*/ float get_targetValue();
        /*0x1202470*/ void set_targetValue(float value);
        /*0x8c2b50*/ float get_duration();
        /*0x10e91a0*/ void set_duration(float value);
        /*0x8b9820*/ bool get_ignoreTimeScale();
        /*0xe29380*/ void set_ignoreTimeScale(bool value);
        /*0x1454430*/ void TweenValue(float floatPercentage);
        /*0x1454370*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
        /*0x8b9820*/ bool GetIgnoreTimescale();
        /*0x8c2b50*/ float GetDuration();
        /*0xfbe040*/ bool ValidTarget();

        class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
        {
            /*0x1454330*/ FloatTweenCallback();
        }
    }

    class TweenRunner<T>
    {
        /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
        /*0x0*/ System.Collections.IEnumerator m_Tween;

        static /*0x2a5510*/ System.Collections.IEnumerator Start(T tweenInfo);
        /*0x180fc0*/ TweenRunner();
        /*0x17aec0*/ void Init(UnityEngine.MonoBehaviour coroutineContainer);
        /*0x2a5510*/ void StartTween(T info);
        /*0x180fc0*/ void StopTween();

        class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ T tweenInfo;
            /*0x0*/ float <elapsedTime>5__2;

            /*0x17aa40*/ <Start>d__2(int <>1__state);
            /*0x180fc0*/ void System.IDisposable.Dispose();
            /*0x17cb40*/ bool MoveNext();
            /*0x1803b0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
            /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x1458360*/ TMP_DefaultControls();
        static /*0x1457f50*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size);
        static /*0x1457ff0*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent);
        static /*0x1458100*/ void SetDefaultTextValues(TMPro.TMP_Text lbl);
        static /*0x14580b0*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
        static /*0x1458280*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
        static /*0x14581a0*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
        static /*0x1457b10*/ UnityEngine.GameObject CreateScrollbar(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x1455aa0*/ UnityEngine.GameObject CreateButton(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x1457ea0*/ UnityEngine.GameObject CreateText(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x1457120*/ UnityEngine.GameObject CreateInputField(TMPro.TMP_DefaultControls.Resources resources);
        static /*0x1455e60*/ UnityEngine.GameObject CreateDropdown(TMPro.TMP_DefaultControls.Resources resources);

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

        static /*0x145b800*/ TMP_Dropdown();
        static /*0x2a5510*/ T GetOrAddComponent<T>(UnityEngine.GameObject go);
        /*0x145b880*/ TMP_Dropdown();
        /*0x136fc90*/ UnityEngine.RectTransform get_template();
        /*0x145bbd0*/ void set_template(UnityEngine.RectTransform value);
        /*0x136fcb0*/ TMPro.TMP_Text get_captionText();
        /*0x145bad0*/ void set_captionText(TMPro.TMP_Text value);
        /*0x1355380*/ UnityEngine.UI.Image get_captionImage();
        /*0x145baa0*/ void set_captionImage(UnityEngine.UI.Image value);
        /*0x134cc10*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x145bba0*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x10f4ac0*/ TMPro.TMP_Text get_itemText();
        /*0x145bb30*/ void set_itemText(TMPro.TMP_Text value);
        /*0x10d2010*/ UnityEngine.UI.Image get_itemImage();
        /*0x145bb00*/ void set_itemImage(UnityEngine.UI.Image value);
        /*0x145ba80*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
        /*0x145bb60*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        /*0x1369470*/ TMPro.TMP_Dropdown.DropdownEvent get_onValueChanged();
        /*0x13694a0*/ void set_onValueChanged(TMPro.TMP_Dropdown.DropdownEvent value);
        /*0x10f4780*/ float get_alphaFadeSpeed();
        /*0x10f4f30*/ void set_alphaFadeSpeed(float value);
        /*0x134cc20*/ int get_value();
        /*0x145bc00*/ void set_value(int value);
        /*0x1459e60*/ void SetValueWithoutNotify(int input);
        /*0x1459e70*/ void SetValue(int value, bool sendCallback);
        /*0x145ba20*/ bool get_IsExpanded();
        /*0x1458c80*/ void Awake();
        /*0x145b740*/ void Start();
        /*0x1459940*/ void OnDisable();
        /*0x1459b20*/ void RefreshShownValue();
        /*0x1458730*/ void AddOptions(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options);
        /*0x14587a0*/ void AddOptions(System.Collections.Generic.List<string> options);
        /*0x1458910*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
        /*0x1458d90*/ void ClearOptions();
        /*0x1459fe0*/ void SetupTemplate();
        /*0x14599f0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x14599f0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1459930*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x145a6d0*/ void Show();
        /*0x1458e50*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
        /*0x1459480*/ void DestroyBlocker(UnityEngine.GameObject blocker);
        /*0x1459340*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
        /*0x14594d0*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
        /*0x14593a0*/ TMPro.TMP_Dropdown.DropdownItem CreateItem(TMPro.TMP_Dropdown.DropdownItem itemTemplate);
        /*0x32d010*/ void DestroyItem(TMPro.TMP_Dropdown.DropdownItem item);
        /*0x1458410*/ TMPro.TMP_Dropdown.DropdownItem AddItem(TMPro.TMP_Dropdown.OptionData data, bool selected, TMPro.TMP_Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<TMPro.TMP_Dropdown.DropdownItem> items);
        /*0x1458bf0*/ void AlphaFadeList(float duration, float alpha);
        /*0x1458a80*/ void AlphaFadeList(float duration, float start, float end);
        /*0x1459db0*/ void SetAlpha(float alpha);
        /*0x1459520*/ void Hide();
        /*0x1459400*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
        /*0x1459730*/ void ImmediateDestroyDropdownList();
        /*0x1459a00*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

        class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x20*/ TMPro.TMP_Text m_Text;
            /*0x28*/ UnityEngine.UI.Image m_Image;
            /*0x30*/ UnityEngine.RectTransform m_RectTransform;
            /*0x38*/ UnityEngine.UI.Toggle m_Toggle;

            /*0x31c640*/ DropdownItem();
            /*0x61a260*/ TMPro.TMP_Text get_text();
            /*0x7965a0*/ void set_text(TMPro.TMP_Text value);
            /*0x79a150*/ UnityEngine.UI.Image get_image();
            /*0x98b030*/ void set_image(UnityEngine.UI.Image value);
            /*0x997630*/ UnityEngine.RectTransform get_rectTransform();
            /*0x997640*/ void set_rectTransform(UnityEngine.RectTransform value);
            /*0x995140*/ UnityEngine.UI.Toggle get_toggle();
            /*0xe5a080*/ void set_toggle(UnityEngine.UI.Toggle value);
            /*0x1453fe0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x1453f50*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class OptionData
        {
            /*0x10*/ string m_Text;
            /*0x18*/ UnityEngine.Sprite m_Image;

            /*0x32f970*/ OptionData();
            /*0x49b490*/ OptionData(string text);
            /*0xe78ae0*/ OptionData(UnityEngine.Sprite image);
            /*0xce3b90*/ OptionData(string text, UnityEngine.Sprite image);
            /*0x73d3e0*/ string get_text();
            /*0x9f12f0*/ void set_text(string value);
            /*0x32f410*/ UnityEngine.Sprite get_image();
            /*0x7963c0*/ void set_image(UnityEngine.Sprite value);
        }

        class OptionDataList
        {
            /*0x10*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options;

            /*0x1455590*/ OptionDataList();
            /*0x73d3e0*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> get_options();
            /*0x9f12f0*/ void set_options(System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> value);
        }

        class DropdownEvent : UnityEngine.Events.UnityEvent<int>
        {
            /*0x1453f10*/ DropdownEvent();
        }

        class <>c__DisplayClass69_0
        {
            /*0x10*/ TMPro.TMP_Dropdown.DropdownItem item;
            /*0x18*/ TMPro.TMP_Dropdown <>4__this;

            /*0x32f970*/ <>c__DisplayClass69_0();
            /*0x14776b0*/ void <Show>b__0(bool x);
        }

        class <DelayedDestroyDropdownList>d__81 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delay;
            /*0x28*/ TMPro.TMP_Dropdown <>4__this;

            /*0x32f460*/ <DelayedDestroyDropdownList>d__81(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14774c0*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x1477580*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x14651e0*/ TMP_FontAsset();
        static /*0x145d890*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font);
        static /*0x145d910*/ TMPro.TMP_FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, TMPro.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
        static /*0x145e010*/ string GetCharacters(TMPro.TMP_FontAsset fontAsset);
        static /*0x145df30*/ int[] GetCharactersArray(TMPro.TMP_FontAsset fontAsset);
        static /*0x145fd50*/ void RegisterFontAssetForFontFeatureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x1463700*/ void UpdateFontFeaturesForFontAssetsInQueue();
        static /*0x145fc50*/ void RegisterFontAssetForAtlasTextureUpdate(TMPro.TMP_FontAsset fontAsset);
        static /*0x1463430*/ void UpdateAtlasTexturesForFontAssetsInQueue();
        /*0x1465540*/ TMP_FontAsset();
        /*0x997630*/ string get_version();
        /*0x997640*/ void set_version(string value);
        /*0xb61870*/ UnityEngine.Font get_sourceFontFile();
        /*0xcf6cd0*/ void set_sourceFontFile(UnityEngine.Font value);
        /*0x12f47d0*/ TMPro.AtlasPopulationMode get_atlasPopulationMode();
        /*0x136a110*/ void set_atlasPopulationMode(TMPro.AtlasPopulationMode value);
        /*0x1465b30*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x1465c90*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x136fc00*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
        /*0x1465d00*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
        /*0x1465b70*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
        /*0xefdcf0*/ System.Collections.Generic.List<TMPro.TMP_Character> get_characterTable();
        /*0x1465c00*/ void set_characterTable(System.Collections.Generic.List<TMPro.TMP_Character> value);
        /*0x1465a90*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_Character> get_characterLookupTable();
        /*0x14659f0*/ UnityEngine.Texture2D get_atlasTexture();
        /*0x136fc10*/ UnityEngine.Texture2D[] get_atlasTextures();
        /*0x1465be0*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
        /*0x14659e0*/ int get_atlasTextureCount();
        /*0x1465bb0*/ bool get_isMultiAtlasTexturesEnabled();
        /*0x1465d20*/ void set_isMultiAtlasTexturesEnabled(bool value);
        /*0x1465ad0*/ bool get_clearDynamicDataOnBuild();
        /*0x1465c20*/ void set_clearDynamicDataOnBuild(bool value);
        /*0x10d00b0*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
        /*0x136fd30*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x10d0110*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
        /*0x139f000*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
        /*0x136fc50*/ TMPro.FaceInfo_Legacy get_fontInfo();
        /*0xbf2c70*/ int get_atlasWidth();
        /*0xbf30a0*/ void set_atlasWidth(int value);
        /*0x14659c0*/ int get_atlasHeight();
        /*0x1465bc0*/ void set_atlasHeight(int value);
        /*0x1404ac0*/ int get_atlasPadding();
        /*0x1404ad0*/ void set_atlasPadding(int value);
        /*0x14659d0*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
        /*0x1465bd0*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
        /*0x10d2010*/ TMPro.TMP_FontFeatureTable get_fontFeatureTable();
        /*0x10f5010*/ void set_fontFeatureTable(TMPro.TMP_FontFeatureTable value);
        /*0x1369450*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssetTable();
        /*0x1369480*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<TMPro.TMP_FontAsset> value);
        /*0x1465ae0*/ TMPro.FontAssetCreationSettings get_creationSettings();
        /*0x1465c30*/ void set_creationSettings(TMPro.FontAssetCreationSettings value);
        /*0x12e8020*/ TMPro.TMP_FontWeightPair[] get_fontWeightTable();
        /*0x1465ce0*/ void set_fontWeightTable(TMPro.TMP_FontWeightPair[] value);
        /*0x145d1e0*/ void Awake();
        /*0x145f9f0*/ void ReadFontAssetDefinition();
        /*0x145f570*/ void InitializeDictionaryLookupTables();
        /*0x145f5a0*/ void InitializeGlyphLookupDictionary();
        /*0x145f300*/ void InitializeCharacterLookupDictionary();
        /*0x145f820*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
        /*0x145ce50*/ void AddSynthesizedCharactersAndFaceMetrics();
        /*0x145cb30*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
        /*0x145ca80*/ void AddCharacterToLookupCache(uint unicode, TMPro.TMP_Character character);
        /*0x14603d0*/ void SortCharacterTable();
        /*0x1460580*/ void SortGlyphTable();
        /*0x1460550*/ void SortFontFeatureTable();
        /*0x14600e0*/ void SortAllTables();
        /*0x145e470*/ bool HasCharacter(int character);
        /*0x145e4e0*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
        /*0x145e220*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
        /*0x145ea60*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
        /*0x145ebc0*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
        /*0x145f250*/ bool HasCharacters(string text);
        /*0x145e110*/ uint GetGlyphIndex(uint unicode);
        /*0x1462820*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
        /*0x1460fd0*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
        /*0x1461c00*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
        /*0x1461c30*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
        /*0x1460700*/ bool TryAddCharacterInternal(uint unicode, ref TMPro.TMP_Character character);
        /*0x1462cf0*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref TMPro.TMP_Character character);
        /*0x32d010*/ void TryAddGlyphsToAtlasTextures();
        /*0x1462850*/ bool TryAddGlyphsToNewAtlasTexture();
        /*0x145fe50*/ void SetupNewAtlasTexture();
        /*0x1463280*/ void UpdateAtlasTexture();
        /*0x1463880*/ void UpdateGlyphAdjustmentRecords();
        /*0x1463bf0*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
        /*0x32d010*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
        /*0x32d010*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
        /*0x183150*/ void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
        /*0x145d600*/ void ClearFontAssetData(bool setAtlasSizeToZero);
        /*0x145d5d0*/ void ClearFontAssetDataInternal();
        /*0x14635a0*/ void UpdateFontAssetData();
        /*0x145d640*/ void ClearFontAssetTables();
        /*0x145d260*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
        /*0x1463f30*/ void UpgradeFontAsset();
        /*0x1464d70*/ void UpgradeGlyphAdjustmentTableToFontFeatureTable();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_Character, uint> <>9__124_0;
            static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__125_0;

            static /*0x14777e0*/ <>c();
            /*0x32f970*/ <>c();
            /*0x4c9d10*/ uint <SortCharacterTable>b__124_0(TMPro.TMP_Character c);
            /*0x1477600*/ uint <SortGlyphTable>b__125_0(UnityEngine.TextCore.Glyph c);
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

        /*0x32f970*/ FaceInfo_Legacy();
    }

    class TMP_Glyph : TMPro.TMP_TextElement_Legacy
    {
        static /*0x14668e0*/ TMPro.TMP_Glyph Clone(TMPro.TMP_Glyph source);
        /*0x534220*/ TMP_Glyph();
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

        /*0x14544c0*/ FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode);
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

        /*0x14549c0*/ KerningPairKey(uint ascii_left, uint ascii_right);
    }

    struct GlyphValueRecord_Legacy
    {
        /*0x10*/ float xPlacement;
        /*0x14*/ float yPlacement;
        /*0x18*/ float xAdvance;
        /*0x1c*/ float yAdvance;

        static /*0x1245b70*/ TMPro.GlyphValueRecord_Legacy op_Addition(TMPro.GlyphValueRecord_Legacy a, TMPro.GlyphValueRecord_Legacy b);
        /*0x1454620*/ GlyphValueRecord_Legacy(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
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

        static /*0x14549f0*/ KerningPair();
        /*0x1454b30*/ KerningPair();
        /*0x1454a80*/ KerningPair(uint left, uint right, float offset);
        /*0x1454ad0*/ KerningPair(uint firstGlyph, TMPro.GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, TMPro.GlyphValueRecord_Legacy secondGlyphAdjustments);
        /*0x417e30*/ uint get_firstGlyph();
        /*0xdcd9c0*/ void set_firstGlyph(uint value);
        /*0x8b8fc0*/ TMPro.GlyphValueRecord_Legacy get_firstGlyphAdjustments();
        /*0x3e3ad0*/ uint get_secondGlyph();
        /*0xc70b30*/ void set_secondGlyph(uint value);
        /*0xa75be0*/ TMPro.GlyphValueRecord_Legacy get_secondGlyphAdjustments();
        /*0xc77220*/ bool get_ignoreSpacingAdjustments();
        /*0x14549e0*/ void ConvertLegacyKerningData();
    }

    class KerningTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.KerningPair> kerningPairs;

        /*0x1455330*/ KerningTable();
        /*0x1454e30*/ void AddKerningPair();
        /*0x1454cd0*/ int AddKerningPair(uint first, uint second, float offset);
        /*0x1454b60*/ int AddGlyphPairAdjustmentRecord(uint first, TMPro.GlyphValueRecord_Legacy firstAdjustments, uint second, TMPro.GlyphValueRecord_Legacy secondAdjustments);
        /*0x1454f80*/ void RemoveKerningPair(int left, int right);
        /*0x1455090*/ void RemoveKerningPair(int index);
        /*0x14550f0*/ void SortKerningPairs();

        class <>c
        {
            static /*0x0*/ TMPro.KerningTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.KerningPair, uint> <>9__7_0;
            static /*0x10*/ System.Func<TMPro.KerningPair, uint> <>9__7_1;

            static /*0x14778c0*/ <>c();
            /*0x32f970*/ <>c();
            /*0x4c9cf0*/ uint <SortKerningPairs>b__7_0(TMPro.KerningPair s);
            /*0x1477620*/ uint <SortKerningPairs>b__7_1(TMPro.KerningPair s);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x32f970*/ <>c__DisplayClass3_0();
            /*0x1477640*/ bool <AddKerningPair>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ uint first;
            /*0x14*/ uint second;

            /*0x32f970*/ <>c__DisplayClass4_0();
            /*0x1477640*/ bool <AddGlyphPairAdjustmentRecord>b__0(TMPro.KerningPair item);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ int left;
            /*0x14*/ int right;

            /*0x32f970*/ <>c__DisplayClass5_0();
            /*0x1477670*/ bool <RemoveKerningPair>b__0(TMPro.KerningPair item);
        }
    }

    class TMP_FontUtilities
    {
        static /*0x0*/ System.Collections.Generic.List<int> k_searchedFontAssets;

        static /*0x1466480*/ TMPro.TMP_FontAsset SearchForCharacter(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x1466390*/ TMPro.TMP_FontAsset SearchForCharacter(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
        static /*0x1466030*/ TMPro.TMP_FontAsset SearchForCharacterInternal(TMPro.TMP_FontAsset font, uint unicode, ref TMPro.TMP_Character character);
        static /*0x14662a0*/ TMPro.TMP_FontAsset SearchForCharacterInternal(System.Collections.Generic.List<TMPro.TMP_FontAsset> fonts, uint unicode, ref TMPro.TMP_Character character);
    }

    class TMP_FontAssetUtilities
    {
        static /*0x0*/ TMPro.TMP_FontAssetUtilities s_Instance;
        static /*0x8*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;
        static /*0x10*/ bool k_IsFontEngineInitialized;

        static /*0x145c9c0*/ TMP_FontAssetUtilities();
        static /*0x145ca30*/ TMPro.TMP_FontAssetUtilities get_instance();
        static /*0x145c050*/ TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x145bc10*/ TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x145c1e0*/ TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, TMPro.TMP_FontAsset sourceFontAsset, System.Collections.Generic.List<TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isAlternativeTypeface);
        static /*0x145c680*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        static /*0x145c490*/ TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks);
        /*0x32f970*/ TMP_FontAssetUtilities();
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

        static /*0x14668a0*/ TMPro.TMP_GlyphValueRecord op_Addition(TMPro.TMP_GlyphValueRecord a, TMPro.TMP_GlyphValueRecord b);
        /*0x11534a0*/ TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);
        /*0x11f1850*/ TMP_GlyphValueRecord(TMPro.GlyphValueRecord_Legacy valueRecord);
        /*0x1454620*/ TMP_GlyphValueRecord(UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord);
        /*0xf72200*/ float get_xPlacement();
        /*0x14668c0*/ void set_xPlacement(float value);
        /*0xa5a890*/ float get_yPlacement();
        /*0x14668d0*/ void set_yPlacement(float value);
        /*0xa5a910*/ float get_xAdvance();
        /*0x14544b0*/ void set_xAdvance(float value);
        /*0x1202400*/ float get_yAdvance();
        /*0x1202470*/ void set_yAdvance(float value);
    }

    struct TMP_GlyphAdjustmentRecord
    {
        /*0x10*/ uint m_GlyphIndex;
        /*0x14*/ TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

        /*0xa5a210*/ TMP_GlyphAdjustmentRecord(uint glyphIndex, TMPro.TMP_GlyphValueRecord glyphValueRecord);
        /*0x1466580*/ TMP_GlyphAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord);
        /*0x6bba50*/ uint get_glyphIndex();
        /*0x6bbd40*/ void set_glyphIndex(uint value);
        /*0xa5a8c0*/ TMPro.TMP_GlyphValueRecord get_glyphValueRecord();
        /*0x1466650*/ void set_glyphValueRecord(TMPro.TMP_GlyphValueRecord value);
    }

    class TMP_GlyphPairAdjustmentRecord
    {
        /*0x10*/ TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;
        /*0x24*/ TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;
        /*0x38*/ TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

        /*0x1466660*/ TMP_GlyphPairAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord);
        /*0x14666b0*/ TMP_GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord);
        /*0x8c7e80*/ TMPro.TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord();
        /*0x1466880*/ void set_firstAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0x1466860*/ TMPro.TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord();
        /*0x1466890*/ void set_secondAdjustmentRecord(TMPro.TMP_GlyphAdjustmentRecord value);
        /*0xeab1d0*/ TMPro.FontFeatureLookupFlags get_featureLookupFlags();
        /*0x12d8f70*/ void set_featureLookupFlags(TMPro.FontFeatureLookupFlags value);
    }

    struct GlyphPairKey
    {
        /*0x10*/ uint firstGlyphIndex;
        /*0x14*/ uint secondGlyphIndex;
        /*0x18*/ uint key;

        /*0x14545d0*/ GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex);
        /*0x14545f0*/ GlyphPairKey(TMPro.TMP_GlyphPairAdjustmentRecord record);
    }

    class TMP_FontFeatureTable
    {
        /*0x10*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
        /*0x18*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

        /*0x1465f70*/ TMP_FontFeatureTable();
        /*0x73d3e0*/ System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
        /*0x9f12f0*/ void set_glyphPairAdjustmentRecords(System.Collections.Generic.List<TMPro.TMP_GlyphPairAdjustmentRecord> value);
        /*0x1465d30*/ void SortGlyphPairAdjustmentRecords();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_FontFeatureTable.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0;
            static /*0x10*/ System.Func<TMPro.TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1;

            static /*0x1477850*/ <>c();
            /*0x32f970*/ <>c();
            /*0x14775c0*/ uint <SortGlyphPairAdjustmentRecords>b__6_0(TMPro.TMP_GlyphPairAdjustmentRecord s);
            /*0x14775e0*/ uint <SortGlyphPairAdjustmentRecords>b__6_1(TMPro.TMP_GlyphPairAdjustmentRecord s);
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

        static /*0x14743b0*/ TMP_InputField();
        static /*0x14748c0*/ string get_clipboard();
        static /*0x14757f0*/ void set_clipboard(string value);
        /*0x1474440*/ TMP_InputField();
        /*0x1474ab0*/ UnityEngine.EventSystems.BaseInput get_inputSystem();
        /*0x1474930*/ string get_compositionString();
        /*0x1474900*/ int get_compositionLength();
        /*0x1474c10*/ UnityEngine.Mesh get_mesh();
        /*0x1475150*/ bool get_shouldHideMobileInput();
        /*0x14767a0*/ void set_shouldHideMobileInput(bool value);
        /*0x14751b0*/ bool get_shouldHideSoftKeyboard();
        /*0x1476840*/ void set_shouldHideSoftKeyboard(bool value);
        /*0x1475270*/ bool isKeyboardUsingEvents();
        /*0x135fd50*/ string get_text();
        /*0x1476bd0*/ void set_text(string value);
        /*0x1472e30*/ void SetTextWithoutNotify(string input);
        /*0x1472e40*/ void SetText(string value, bool sendCallback);
        /*0x1474bc0*/ bool get_isFocused();
        /*0x14747a0*/ float get_caretBlinkRate();
        /*0x1475350*/ void set_caretBlinkRate(float value);
        /*0x1474890*/ int get_caretWidth();
        /*0x1475640*/ void set_caretWidth(int value);
        /*0x1355380*/ UnityEngine.RectTransform get_textViewport();
        /*0x1476b80*/ void set_textViewport(UnityEngine.RectTransform value);
        /*0x1369450*/ TMPro.TMP_Text get_textComponent();
        /*0x1476b20*/ void set_textComponent(TMPro.TMP_Text value);
        /*0x1474d80*/ UnityEngine.UI.Graphic get_placeholder();
        /*0x14761a0*/ void set_placeholder(UnityEngine.UI.Graphic value);
        /*0x1475250*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
        /*0x1476be0*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
        /*0x12e7fd0*/ float get_scrollSensitivity();
        /*0x1476420*/ void set_scrollSensitivity(float value);
        /*0x14747b0*/ UnityEngine.Color get_caretColor();
        /*0x14753c0*/ void set_caretColor(UnityEngine.Color value);
        /*0x14749f0*/ bool get_customCaretColor();
        /*0x1475a70*/ void set_customCaretColor(bool value);
        /*0x14750c0*/ UnityEngine.Color get_selectionColor();
        /*0x1476560*/ void set_selectionColor(UnityEngine.Color value);
        /*0x1474cf0*/ TMPro.TMP_InputField.SubmitEvent get_onEndEdit();
        /*0x1475f10*/ void set_onEndEdit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x1474d30*/ TMPro.TMP_InputField.SubmitEvent get_onSubmit();
        /*0x1476010*/ void set_onSubmit(TMPro.TMP_InputField.SubmitEvent value);
        /*0x1474d20*/ TMPro.TMP_InputField.SelectionEvent get_onSelect();
        /*0x1475fc0*/ void set_onSelect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x1474ce0*/ TMPro.TMP_InputField.SelectionEvent get_onDeselect();
        /*0x1475ec0*/ void set_onDeselect(TMPro.TMP_InputField.SelectionEvent value);
        /*0x1474d40*/ TMPro.TMP_InputField.TextSelectionEvent get_onTextSelection();
        /*0x1476060*/ void set_onTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x1474d00*/ TMPro.TMP_InputField.TextSelectionEvent get_onEndTextSelection();
        /*0x1475f60*/ void set_onEndTextSelection(TMPro.TMP_InputField.TextSelectionEvent value);
        /*0x1474d70*/ TMPro.TMP_InputField.OnChangeEvent get_onValueChanged();
        /*0x1476150*/ void set_onValueChanged(TMPro.TMP_InputField.OnChangeEvent value);
        /*0x1474d50*/ TMPro.TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged();
        /*0x14760b0*/ void set_onTouchScreenKeyboardStatusChanged(TMPro.TMP_InputField.TouchScreenKeyboardEvent value);
        /*0x1474d60*/ TMPro.TMP_InputField.OnValidateInput get_onValidateInput();
        /*0x1476100*/ void set_onValidateInput(TMPro.TMP_InputField.OnValidateInput value);
        /*0x14748a0*/ int get_characterLimit();
        /*0x14756d0*/ void set_characterLimit(int value);
        /*0x1474d90*/ float get_pointSize();
        /*0x14761f0*/ void set_pointSize(float value);
        /*0x1474a10*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x1475ad0*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x1474d10*/ bool get_onFocusSelectAll();
        /*0x1475fb0*/ void set_onFocusSelectAll(bool value);
        /*0x1475090*/ bool get_resetOnDeActivation();
        /*0x1476370*/ void set_resetOnDeActivation(bool value);
        /*0x14750a0*/ bool get_restoreOriginalTextOnEscape();
        /*0x1476380*/ void set_restoreOriginalTextOnEscape(bool value);
        /*0x1474bd0*/ bool get_isRichTextEditingAllowed();
        /*0x1475cf0*/ void set_isRichTextEditingAllowed(bool value);
        /*0x14749e0*/ TMPro.TMP_InputField.ContentType get_contentType();
        /*0x1475840*/ void set_contentType(TMPro.TMP_InputField.ContentType value);
        /*0x1474c00*/ TMPro.TMP_InputField.LineType get_lineType();
        /*0x1475de0*/ void set_lineType(TMPro.TMP_InputField.LineType value);
        /*0x1474bf0*/ int get_lineLimit();
        /*0x1475d70*/ void set_lineLimit(int value);
        /*0x1474bb0*/ TMPro.TMP_InputField.InputType get_inputType();
        /*0x1475c10*/ void set_inputType(TMPro.TMP_InputField.InputType value);
        /*0x1474be0*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
        /*0x1475d00*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
        /*0x14748b0*/ TMPro.TMP_InputField.CharacterValidation get_characterValidation();
        /*0x1475780*/ void set_characterValidation(TMPro.TMP_InputField.CharacterValidation value);
        /*0x13e3e00*/ TMPro.TMP_InputValidator get_inputValidator();
        /*0x1475c80*/ void set_inputValidator(TMPro.TMP_InputValidator value);
        /*0x1475080*/ bool get_readOnly();
        /*0x1476360*/ void set_readOnly(bool value);
        /*0x14750b0*/ bool get_richText();
        /*0x1476390*/ void set_richText(bool value);
        /*0x1474cc0*/ bool get_multiLine();
        /*0x1474790*/ char get_asteriskChar();
        /*0x14752f0*/ void set_asteriskChar(char value);
        /*0x1475260*/ bool get_wasCanceled();
        /*0x1468b30*/ void ClampStringPos(ref int pos);
        /*0x1468ad0*/ void ClampCaretPos(ref int pos);
        /*0x1474810*/ int get_caretPositionInternal();
        /*0x1475430*/ void set_caretPositionInternal(int value);
        /*0x14750d0*/ int get_stringPositionInternal();
        /*0x1476990*/ void set_stringPositionInternal(int value);
        /*0x1474850*/ int get_caretSelectPositionInternal();
        /*0x14755d0*/ void set_caretSelectPositionInternal(int value);
        /*0x1475110*/ int get_stringSelectPositionInternal();
        /*0x1476ad0*/ void set_stringSelectPositionInternal(int value);
        /*0x1474a20*/ bool get_hasSelection();
        /*0x1474850*/ int get_caretPosition();
        /*0x14754a0*/ void set_caretPosition(int value);
        /*0x1474810*/ int get_selectionAnchorPosition();
        /*0x14764b0*/ void set_selectionAnchorPosition(int value);
        /*0x1474850*/ int get_selectionFocusPosition();
        /*0x14765d0*/ void set_selectionFocusPosition(int value);
        /*0x1475110*/ int get_stringPosition();
        /*0x14769e0*/ void set_stringPosition(int value);
        /*0x14750d0*/ int get_selectionStringAnchorPosition();
        /*0x1476680*/ void set_selectionStringAnchorPosition(int value);
        /*0x1475110*/ int get_selectionStringFocusPosition();
        /*0x1476710*/ void set_selectionStringFocusPosition(int value);
        /*0x1470080*/ void OnEnable();
        /*0x146f840*/ void OnDisable();
        /*0x146f530*/ void ON_TEXT_CHANGED(UnityEngine.Object obj);
        /*0x1468a60*/ System.Collections.IEnumerator CaretBlink();
        /*0x1472ad0*/ void SetCaretVisible();
        /*0x1472a00*/ void SetCaretActive();
        /*0x1470e10*/ void OnFocus();
        /*0x14724b0*/ void SelectAll();
        /*0x146e780*/ void MoveTextEnd(bool shift);
        /*0x146e960*/ void MoveTextStart(bool shift);
        /*0x146eb30*/ void MoveToEndOfLine(bool shift, bool ctrl);
        /*0x146ee20*/ void MoveToStartOfLine(bool shift, bool ctrl);
        /*0x146b480*/ bool InPlaceEditing();
        /*0x14737a0*/ void UpdateStringPositionFromKeyboard();
        /*0x146bbf0*/ void LateUpdate();
        /*0x146c950*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x146f790*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x146fbb0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x146ca40*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x14708c0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x1470e60*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x146b740*/ TMPro.TMP_InputField.EditState KeyPressed(UnityEngine.Event evt);
        /*0x146b720*/ bool IsValidChar(char c);
        /*0x1472320*/ void ProcessEvent(UnityEngine.Event e);
        /*0x1471a80*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1471730*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x146b1f0*/ float GetScrollPositionRelativeToViewport();
        /*0x146b310*/ string GetSelectedString();
        /*0x14697c0*/ int FindNextWordBegin();
        /*0x146e040*/ void MoveRight(bool shift, bool ctrl);
        /*0x14698e0*/ int FindPrevWordBegin();
        /*0x146cee0*/ void MoveLeft(bool shift, bool ctrl);
        /*0x146c680*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x146c3e0*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x1471fd0*/ int PageUpCharacterPosition(int originalPos, bool goToFirstChar);
        /*0x1471c50*/ int PageDownCharacterPosition(int originalPos, bool goToLastChar);
        /*0x146ced0*/ void MoveDown(bool shift);
        /*0x146cad0*/ void MoveDown(bool shift, bool goToLastChar);
        /*0x146f140*/ void MoveUp(bool shift);
        /*0x146f150*/ void MoveUp(bool shift, bool goToFirstChar);
        /*0x146e030*/ void MovePageUp(bool shift);
        /*0x146dad0*/ void MovePageUp(bool shift, bool goToFirstChar);
        /*0x146dac0*/ void MovePageDown(bool shift);
        /*0x146d540*/ void MovePageDown(bool shift, bool goToLastChar);
        /*0x1469250*/ void Delete();
        /*0x1468f70*/ void DeleteKey();
        /*0x14686b0*/ void Backspace();
        /*0x14678e0*/ void Append(string input);
        /*0x1467990*/ void Append(char input);
        /*0x146b580*/ void Insert(char c);
        /*0x1473b00*/ void UpdateTouchKeyboardFromEditChanges();
        /*0x14728d0*/ void SendOnValueChangedAndUpdateLabel();
        /*0x1472930*/ void SendOnValueChanged();
        /*0x1472540*/ void SendOnEndEdit();
        /*0x1472770*/ void SendOnSubmit();
        /*0x1472710*/ void SendOnFocus();
        /*0x14726b0*/ void SendOnFocusLost();
        /*0x14727d0*/ void SendOnTextSelection();
        /*0x14725a0*/ void SendOnEndTextSelection();
        /*0x1472990*/ void SendTouchScreenKeyboardStatusChanged();
        /*0x1473120*/ void UpdateLabel();
        /*0x14736a0*/ void UpdateScrollbar();
        /*0x1471950*/ void OnScrollbarValueChange(float value);
        /*0x32d010*/ void UpdateMaskRegions();
        /*0x14676a0*/ void AdjustTextPositionRelativeToViewport(float relativePosition);
        /*0x146b0a0*/ int GetCaretPositionFromStringIndex(int stringIndex);
        /*0x146b140*/ int GetMinCaretPositionFromStringIndex(int stringIndex);
        /*0x146b0a0*/ int GetMaxCaretPositionFromStringIndex(int stringIndex);
        /*0x146b3f0*/ int GetStringIndexFromCaretPosition(int caretPosition);
        /*0x14699f0*/ void ForceLabelUpdate();
        /*0x146c900*/ void MarkGeometryAsDirty();
        /*0x1472330*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x32d010*/ void LayoutComplete();
        /*0x32d010*/ void GraphicUpdateComplete();
        /*0x1473060*/ void UpdateGeometry();
        /*0x1467f30*/ void AssignPositioningIfNeeded();
        /*0x14708f0*/ void OnFillVBO(UnityEngine.Mesh vbo);
        /*0x1469a00*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x1468b70*/ void CreateCursorVerts();
        /*0x146a600*/ void GenerateHightlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
        /*0x1466f50*/ void AdjustRectTransformRelativeToViewport(UnityEngine.Vector2 startPosition, float height, bool isCharVisible);
        /*0x1473b50*/ char Validate(string text, int pos, char ch);
        /*0x1466e10*/ void ActivateInputField();
        /*0x1466980*/ void ActivateInputFieldInternal();
        /*0x1471990*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x1470e30*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x32d010*/ void OnControlClick();
        /*0x14723f0*/ void ReleaseSelection();
        /*0x1468d30*/ void DeactivateInputField(bool clearSelection);
        /*0x146f7c0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x14719f0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x14695c0*/ void EnforceContentType();
        /*0x1472d80*/ void SetTextComponentWrapMode();
        /*0x1472cf0*/ void SetTextComponentRichTextMode();
        /*0x1472fc0*/ void SetToCustomIfContentTypeIsNot(TMPro.TMP_InputField.ContentType[] allowedContentTypes);
        /*0x1473030*/ void SetToCustom();
        /*0x1473030*/ void SetToCustom(TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x1469590*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
        /*0x32d010*/ void CalculateLayoutInputHorizontal();
        /*0x32d010*/ void CalculateLayoutInputVertical();
        /*0x1301790*/ float get_minWidth();
        /*0x1474f10*/ float get_preferredWidth();
        /*0x1474a00*/ float get_flexibleWidth();
        /*0x1301790*/ float get_minHeight();
        /*0x1474da0*/ float get_preferredHeight();
        /*0x1474a00*/ float get_flexibleHeight();
        /*0x6bba80*/ int get_layoutPriority();
        /*0x1472c00*/ void SetGlobalPointSize(float pointSize);
        /*0x1472b10*/ void SetGlobalFontAsset(TMPro.TMP_FontAsset fontAsset);
        /*0x1473050*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

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
            /*0x1495390*/ OnValidateInput(object object, nint method);
            /*0x723400*/ char Invoke(string text, int charIndex, char addedChar);
            /*0x14952c0*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
            /*0x1495360*/ char EndInvoke(System.IAsyncResult result);
        }

        class SubmitEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x1498420*/ SubmitEvent();
        }

        class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x1495280*/ OnChangeEvent();
        }

        class SelectionEvent : UnityEngine.Events.UnityEvent<string>
        {
            /*0x1495450*/ SelectionEvent();
        }

        class TextSelectionEvent : UnityEngine.Events.UnityEvent<string, int, int>
        {
            /*0x14ac860*/ TextSelectionEvent();
        }

        class TouchScreenKeyboardEvent : UnityEngine.Events.UnityEvent<UnityEngine.TouchScreenKeyboard.Status>
        {
            /*0x14ac8a0*/ TouchScreenKeyboardEvent();
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

            /*0x32f460*/ <CaretBlink>d__276(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14ac8e0*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x14aca40*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
        }

        class <MouseDragOutsideRect>d__294 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ TMPro.TMP_InputField <>4__this;
            /*0x28*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x32f460*/ <MouseDragOutsideRect>d__294(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14ad6c0*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x14ad960*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class SetPropertyUtility
    {
        static /*0x1495490*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
        static /*0x2a5510*/ bool SetEquatableStruct<T>(ref T currentValue, T newValue);
        static /*0x2a5510*/ bool SetStruct<T>(ref T currentValue, T newValue);
        static /*0x2a5510*/ bool SetClass<T>(ref T currentValue, T newValue);
    }

    class TMP_InputValidator : UnityEngine.ScriptableObject
    {
        /*0x533ec0*/ TMP_InputValidator();
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

        static /*0x180ff0*/ TMP_ListPool();
        static /*0x180cf0*/ System.Collections.Generic.List<T> Get();
        static /*0x177be0*/ void Release(System.Collections.Generic.List<T> toRelease);

        class <>c<T>
        {
            static /*0x0*/ TMPro.TMP_ListPool.<>c<T> <>9;

            static /*0x180ff0*/ <>c();
            /*0x180fc0*/ <>c();
            /*0x17aec0*/ void <.cctor>b__3_0(System.Collections.Generic.List<T> l);
        }
    }

    class TMP_MaterialManager
    {
        static /*0x0*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.MaskingMaterial> m_materialList;
        static /*0x8*/ System.Collections.Generic.Dictionary<long, TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, long> m_fallbackMaterialLookup;
        static /*0x18*/ System.Collections.Generic.List<TMPro.TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;
        static /*0x20*/ bool isFallbackListDirty;

        static /*0x149b460*/ TMP_MaterialManager();
        static /*0x149a660*/ void OnPreRender();
        static /*0x149a270*/ UnityEngine.Material GetStencilMaterial(UnityEngine.Material baseMaterial, int stencilID);
        static /*0x149ae00*/ void ReleaseStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x14992b0*/ UnityEngine.Material GetBaseMaterial(UnityEngine.Material stencilMaterial);
        static /*0x149b370*/ UnityEngine.Material SetStencil(UnityEngine.Material material, int stencilID);
        static /*0x1498790*/ void AddMaskingMaterial(UnityEngine.Material baseMaterial, UnityEngine.Material stencilMaterial, int stencilID);
        static /*0x149b210*/ void RemoveStencilMaterial(UnityEngine.Material stencilMaterial);
        static /*0x149a6e0*/ void ReleaseBaseMaterial(UnityEngine.Material baseMaterial);
        static /*0x1498c70*/ void ClearMaterials();
        static /*0x1499e70*/ int GetStencilID(UnityEngine.GameObject obj);
        static /*0x1499c60*/ UnityEngine.Material GetMaterialForRendering(UnityEngine.UI.MaskableGraphic graphic, UnityEngine.Material baseMaterial);
        static /*0x1499130*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
        static /*0x1499910*/ UnityEngine.Material GetFallbackMaterial(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
        static /*0x1499430*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
        static /*0x1498650*/ void AddFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x149b060*/ void RemoveFallbackMaterialReference(UnityEngine.Material targetMaterial);
        static /*0x1498a10*/ void CleanupFallbackMaterials();
        static /*0x149ac20*/ void ReleaseFallbackMaterial(UnityEngine.Material fallbackMaterial);
        static /*0x1498e60*/ void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination);

        class FallbackMaterial
        {
            /*0x10*/ long fallbackID;
            /*0x18*/ UnityEngine.Material sourceMaterial;
            /*0x20*/ int sourceMaterialCRC;
            /*0x28*/ UnityEngine.Material fallbackMaterial;
            /*0x30*/ int count;

            /*0x32f970*/ FallbackMaterial();
        }

        class MaskingMaterial
        {
            /*0x10*/ UnityEngine.Material baseMaterial;
            /*0x18*/ UnityEngine.Material stencilMaterial;
            /*0x20*/ int count;
            /*0x24*/ int stencilID;

            /*0x32f970*/ MaskingMaterial();
        }

        class <>c__DisplayClass11_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x32f970*/ <>c__DisplayClass11_0();
            /*0x14ad9a0*/ bool <AddMaskingMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x32f970*/ <>c__DisplayClass12_0();
            /*0x14ada10*/ bool <RemoveStencilMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ UnityEngine.Material baseMaterial;

            /*0x32f970*/ <>c__DisplayClass13_0();
            /*0x14ada80*/ bool <ReleaseBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
        }

        class <>c__DisplayClass9_0
        {
            /*0x10*/ UnityEngine.Material stencilMaterial;

            /*0x32f970*/ <>c__DisplayClass9_0();
            /*0x14adaf0*/ bool <GetBaseMaterial>b__0(TMPro.TMP_MaterialManager.MaskingMaterial item);
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

        static /*0x149d420*/ TMP_MeshInfo();
        /*0x149d4c0*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size);
        /*0x149db00*/ TMP_MeshInfo(UnityEngine.Mesh mesh, int size, bool isVolumetric);
        /*0x149b980*/ void ResizeMeshInfo(int size);
        /*0x149be90*/ void ResizeMeshInfo(int size, bool isVolumetric);
        /*0x149b790*/ void Clear();
        /*0x149b840*/ void Clear(bool uploadChanges);
        /*0x149b750*/ void ClearUnusedVertices();
        /*0x149b660*/ void ClearUnusedVertices(int startIndex);
        /*0x149b6a0*/ void ClearUnusedVertices(int startIndex, bool updateMesh);
        /*0x149ca00*/ void SortGeometry(TMPro.VertexSortingOrder order);
        /*0x149cab0*/ void SortGeometry(System.Collections.Generic.IList<int> sortingOrder);
        /*0x149cc50*/ void SwapVertexData(int src, int dst);
    }

    class TMP_ObjectPool<T>
    {
        /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        /*0x0*/ UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        /*0x0*/ int <countAll>k__BackingField;

        /*0x183150*/ TMP_ObjectPool(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease);
        /*0x180980*/ int get_countAll();
        /*0x17aa40*/ void set_countAll(int value);
        /*0x180980*/ int get_countActive();
        /*0x180980*/ int get_countInactive();
        /*0x2a5510*/ T Get();
        /*0x2a5510*/ void Release(T element);
    }

    class TMP_ResourceManager
    {
        static /*0x0*/ TMPro.TMP_ResourceManager s_instance;
        static /*0x8*/ TMPro.TMP_Settings s_TextSettings;
        static /*0x10*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> s_FontAssetReferences;
        static /*0x18*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_FontAsset> s_FontAssetReferenceLookup;

        static /*0x149ea40*/ TMP_ResourceManager();
        static /*0x149e760*/ TMPro.TMP_Settings GetTextSettings();
        static /*0x149e5f0*/ void AddFontAsset(TMPro.TMP_FontAsset fontAsset);
        static /*0x149e9a0*/ bool TryGetFontAsset(int hashcode, ref TMPro.TMP_FontAsset fontAsset);
        static /*0x149e880*/ void RebuildFontAssetCache(int instanceID);
        /*0x32f970*/ TMP_ResourceManager();
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

        /*0x31c640*/ TMP_ScrollbarEventHandler();
        /*0x149ebd0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x149ec30*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        /*0x149eb70*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
    }

    class TMP_SelectionCaret : UnityEngine.UI.MaskableGraphic
    {
        /*0x149ed50*/ TMP_SelectionCaret();
        /*0x149ec90*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x32d010*/ void UpdateGeometry();
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

        static /*0x149f960*/ string get_version();
        static /*0x149f550*/ bool get_enableWordWrapping();
        static /*0x149f4d0*/ bool get_enableKerning();
        static /*0x149f4b0*/ bool get_enableExtraPadding();
        static /*0x149f530*/ bool get_enableTintAllSprites();
        static /*0x149f4f0*/ bool get_enableParseEscapeCharacters();
        static /*0x149f510*/ bool get_enableRaycastTarget();
        static /*0x149f5c0*/ bool get_getFontFeaturesAtRuntime();
        static /*0x149f8e0*/ int get_missingGlyphCharacter();
        static /*0x149fa40*/ void set_missingGlyphCharacter(int value);
        static /*0x149f990*/ bool get_warningsDisabled();
        static /*0x149f340*/ TMPro.TMP_FontAsset get_defaultFontAsset();
        static /*0x149f320*/ string get_defaultFontAssetPath();
        static /*0x149f360*/ float get_defaultFontSize();
        static /*0x149f410*/ float get_defaultTextAutoSizingMinRatio();
        static /*0x149f3f0*/ float get_defaultTextAutoSizingMaxRatio();
        static /*0x149f430*/ UnityEngine.Vector2 get_defaultTextMeshProTextContainerSize();
        static /*0x149f460*/ UnityEngine.Vector2 get_defaultTextMeshProUITextContainerSize();
        static /*0x149f2d0*/ bool get_autoSizeTextContainer();
        static /*0x149f6b0*/ bool get_isTextObjectScaleStatic();
        static /*0x149f9e0*/ void set_isTextObjectScaleStatic(bool value);
        static /*0x149f570*/ System.Collections.Generic.List<TMPro.TMP_FontAsset> get_fallbackFontAssets();
        static /*0x149f8a0*/ bool get_matchMaterialPreset();
        static /*0x149f3a0*/ TMPro.TMP_SpriteAsset get_defaultSpriteAsset();
        static /*0x149f380*/ string get_defaultSpriteAssetPath();
        static /*0x149f490*/ bool get_enableEmojiSupport();
        static /*0x149f9b0*/ void set_enableEmojiSupport(bool value);
        static /*0x149f8c0*/ uint get_missingCharacterSpriteUnicode();
        static /*0x149fa10*/ void set_missingCharacterSpriteUnicode(uint value);
        static /*0x149f2f0*/ string get_defaultColorGradientPresetsPath();
        static /*0x149f3c0*/ TMPro.TMP_StyleSheet get_defaultStyleSheet();
        static /*0x149f900*/ string get_styleSheetsResourcePath();
        static /*0x149f6d0*/ UnityEngine.TextAsset get_leadingCharacters();
        static /*0x149f590*/ UnityEngine.TextAsset get_followingCharacters();
        static /*0x149f700*/ TMPro.TMP_Settings.LineBreakingTable get_linebreakingRules();
        static /*0x149f930*/ bool get_useModernHangulLineBreakingRules();
        static /*0x149fa70*/ void set_useModernHangulLineBreakingRules(bool value);
        static /*0x149f5e0*/ TMPro.TMP_Settings get_instance();
        static /*0x149f050*/ TMPro.TMP_Settings LoadDefaultSettings();
        static /*0x149eee0*/ TMPro.TMP_Settings GetSettings();
        static /*0x149ee60*/ TMPro.TMP_FontAsset GetFontAsset();
        static /*0x149ef50*/ TMPro.TMP_SpriteAsset GetSpriteAsset();
        static /*0x149efd0*/ TMPro.TMP_StyleSheet GetStyleSheet();
        static /*0x149f150*/ void LoadLinebreakingRules();
        static /*0x149ed60*/ System.Collections.Generic.Dictionary<int, char> GetCharacters(UnityEngine.TextAsset file);
        /*0x149f2c0*/ TMP_Settings();

        class LineBreakingTable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<int, char> leadingCharacters;
            /*0x18*/ System.Collections.Generic.Dictionary<int, char> followingCharacters;

            /*0x32f970*/ LineBreakingTable();
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

        static /*0x1497d40*/ ShaderUtilities();
        static /*0x14981a0*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
        static /*0x1498080*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
        static /*0x1496a50*/ void GetShaderPropertyIDs();
        static /*0x1497770*/ void UpdateShaderRatios(UnityEngine.Material mat);
        static /*0x14954d0*/ UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material);
        static /*0x14975a0*/ bool IsMaskingEnabled(UnityEngine.Material material);
        static /*0x14960f0*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
        static /*0x1495520*/ float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold);
    }

    class TMP_Sprite : TMPro.TMP_TextElement_Legacy
    {
        /*0x38*/ string name;
        /*0x40*/ int hashCode;
        /*0x44*/ int unicode;
        /*0x48*/ UnityEngine.Vector2 pivot;
        /*0x50*/ UnityEngine.Sprite sprite;

        /*0x32f970*/ TMP_Sprite();
    }

    class TMP_SpriteAnimator : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.Dictionary<int, bool> m_animations;
        /*0x28*/ TMPro.TMP_Text m_TextComponent;

        /*0x149fd30*/ TMP_SpriteAnimator();
        /*0x149faa0*/ void Awake();
        /*0x32d010*/ void OnEnable();
        /*0x32d010*/ void OnDisable();
        /*0x149fce0*/ void StopAllAnimations();
        /*0x149fbb0*/ void DoSpriteAnimation(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
        /*0x149faf0*/ System.Collections.IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMPro.TMP_SpriteAsset spriteAsset, int start, int end, int framerate);

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

            /*0x32f460*/ <DoSpriteAnimationInternal>d__7(int <>1__state);
            /*0x32d010*/ void System.IDisposable.Dispose();
            /*0x14aca80*/ bool MoveNext();
            /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x14ad680*/ void System.Collections.IEnumerator.Reset();
            /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x14a09e0*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicode(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x14a0790*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x14a0920*/ TMPro.TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMPro.TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
        static /*0x14a0340*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCode(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex);
        static /*0x14a01b0*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<TMPro.TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
        static /*0x14a00f0*/ TMPro.TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMPro.TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
        /*0x14a1cf0*/ TMP_SpriteAsset();
        /*0xb61870*/ string get_version();
        /*0xcf6cd0*/ void set_version(string value);
        /*0x14a1dc0*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
        /*0x14a1e80*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
        /*0x14a1e40*/ System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> get_spriteCharacterTable();
        /*0x1465d00*/ void set_spriteCharacterTable(System.Collections.Generic.List<TMPro.TMP_SpriteCharacter> value);
        /*0x14a1e00*/ System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> get_spriteCharacterLookupTable();
        /*0xb699b0*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, TMPro.TMP_SpriteCharacter> value);
        /*0xefdcf0*/ System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> get_spriteGlyphTable();
        /*0x1465c00*/ void set_spriteGlyphTable(System.Collections.Generic.List<TMPro.TMP_SpriteGlyph> value);
        /*0x149fdb0*/ void Awake();
        /*0x149fe30*/ UnityEngine.Material GetDefaultSpriteMaterial();
        /*0x14a1250*/ void UpdateLookupTables();
        /*0x149ff10*/ int GetSpriteIndexFromHashcode(int hashCode);
        /*0x14a0050*/ int GetSpriteIndexFromUnicode(uint unicode);
        /*0x149ffa0*/ int GetSpriteIndexFromName(string name);
        /*0x14a10d0*/ void SortGlyphTable();
        /*0x14a0c80*/ void SortCharacterTable();
        /*0x14a0e00*/ void SortGlyphAndCharacterTables();
        /*0x14a17e0*/ void UpgradeSpriteAsset();

        class <>c
        {
            static /*0x0*/ TMPro.TMP_SpriteAsset.<> <>9;
            static /*0x8*/ System.Func<TMPro.TMP_SpriteGlyph, uint> <>9__40_0;
            static /*0x10*/ System.Func<TMPro.TMP_SpriteCharacter, uint> <>9__41_0;

            static /*0x14adbd0*/ <>c();
            /*0x32f970*/ <>c();
            /*0x1477600*/ uint <SortGlyphTable>b__40_0(TMPro.TMP_SpriteGlyph item);
            /*0x4c9d10*/ uint <SortCharacterTable>b__41_0(TMPro.TMP_SpriteCharacter c);
        }
    }

    class TMP_SpriteCharacter : TMPro.TMP_TextElement
    {
        /*0x30*/ string m_Name;
        /*0x38*/ int m_HashCode;

        /*0x14a1f90*/ TMP_SpriteCharacter();
        /*0x14a1f20*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteGlyph glyph);
        /*0x14a1fb0*/ TMP_SpriteCharacter(uint unicode, TMPro.TMP_SpriteAsset spriteAsset, TMPro.TMP_SpriteGlyph glyph);
        /*0x14a1ec0*/ TMP_SpriteCharacter(uint unicode, uint glyphIndex);
        /*0x997630*/ string get_name();
        /*0x14a2040*/ void set_name(string value);
        /*0xeab1d0*/ int get_hashCode();
    }

    class TMP_SpriteGlyph : UnityEngine.TextCore.Glyph
    {
        /*0x48*/ UnityEngine.Sprite sprite;

        /*0x14a2260*/ TMP_SpriteGlyph();
        /*0x14a21c0*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
        /*0x14a2100*/ TMP_SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite);
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

        static /*0x14a2ab0*/ TMPro.TMP_Style get_NormalStyle();
        /*0x14a29f0*/ TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition);
        /*0x73d3e0*/ string get_name();
        /*0x14a2bb0*/ void set_name(string value);
        /*0x8a5c20*/ int get_hashCode();
        /*0x14a2ba0*/ void set_hashCode(int value);
        /*0x61a260*/ string get_styleOpeningDefinition();
        /*0x79a150*/ string get_styleClosingDefinition();
        /*0x997630*/ int[] get_styleOpeningTagArray();
        /*0x995140*/ int[] get_styleClosingTagArray();
        /*0x14a27a0*/ void RefreshStyle();
    }

    class TMP_StyleSheet : UnityEngine.ScriptableObject
    {
        /*0x18*/ System.Collections.Generic.List<TMPro.TMP_Style> m_StyleList;
        /*0x20*/ System.Collections.Generic.Dictionary<int, TMPro.TMP_Style> m_StyleLookupDictionary;

        /*0x14a2720*/ TMP_StyleSheet();
        /*0x32f410*/ System.Collections.Generic.List<TMPro.TMP_Style> get_styles();
        /*0x14a2710*/ void Reset();
        /*0x14a2330*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x14a2270*/ TMPro.TMP_Style GetStyle(string name);
        /*0x14a2710*/ void RefreshStyles();
        /*0x14a23c0*/ void LoadStyleDictionaryInternal();
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

        static /*0x14a4430*/ TMPro.TMP_SubMesh AddSubTextObject(TMPro.TextMeshPro textComponent, TMPro.MaterialReference materialReference);
        /*0x31c640*/ TMP_SubMesh();
        /*0x61a260*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x7965a0*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x79a150*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x98b030*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x14a54d0*/ UnityEngine.Material get_material();
        /*0x14a5940*/ void set_material(UnityEngine.Material value);
        /*0x995140*/ UnityEngine.Material get_sharedMaterial();
        /*0x14a5150*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0xb61870*/ UnityEngine.Material get_fallbackMaterial();
        /*0x14a57e0*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x4e40d0*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x4e4360*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x9ef740*/ bool get_isDefaultMaterial();
        /*0x9ef990*/ void set_isDefaultMaterial(bool value);
        /*0x136fc20*/ float get_padding();
        /*0x14a59e0*/ void set_padding(float value);
        /*0x14a56c0*/ UnityEngine.Renderer get_renderer();
        /*0x14a54e0*/ UnityEngine.MeshFilter get_meshFilter();
        /*0x14a5600*/ UnityEngine.Mesh get_mesh();
        /*0xe69480*/ void set_mesh(UnityEngine.Mesh value);
        /*0x14a5750*/ TMPro.TMP_Text get_textComponent();
        /*0x14a4ea0*/ void OnEnable();
        /*0x14a4de0*/ void OnDisable();
        /*0x14a4c90*/ void OnDestroy();
        /*0x14a4920*/ void DestroySelf();
        /*0x14a4980*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x14a4860*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x14a4bf0*/ UnityEngine.Material GetSharedMaterial();
        /*0x14a5150*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x14a4b60*/ float GetPaddingForMaterial();
        /*0x14a5450*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x14a5190*/ void SetVerticesDirty();
        /*0x14a5140*/ void SetMaterialDirty();
        /*0x14a5240*/ void UpdateMaterial();
    }

    class TMP_SubMeshUI : UnityEngine.UI.MaskableGraphic
    {
        /*0xe0*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0xe8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0xf0*/ UnityEngine.Material m_material;
        /*0xf8*/ UnityEngine.Material m_sharedMaterial;
        /*0x100*/ UnityEngine.Material m_fallbackMaterial;
        /*0x108*/ UnityEngine.Material m_fallbackSourceMaterial;
        /*0x110*/ bool m_isDefaultMaterial;
        /*0x114*/ float m_padding;
        /*0x118*/ UnityEngine.Mesh m_mesh;
        /*0x120*/ TMPro.TextMeshProUGUI m_TextComponent;
        /*0x128*/ bool m_isRegisteredForEvents;
        /*0x129*/ bool m_materialDirty;
        /*0x12c*/ int m_materialReferenceIndex;
        /*0x130*/ UnityEngine.Transform m_RootCanvasTransform;

        static /*0x14a2bf0*/ TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference);
        /*0x149ed50*/ TMP_SubMeshUI();
        /*0x139ece0*/ TMPro.TMP_FontAsset get_fontAsset();
        /*0x14126d0*/ void set_fontAsset(TMPro.TMP_FontAsset value);
        /*0x10d00b0*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x136fd30*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x14a3eb0*/ UnityEngine.Texture get_mainTexture();
        /*0x14a3fd0*/ UnityEngine.Material get_material();
        /*0x14a4310*/ void set_material(UnityEngine.Material value);
        /*0x136fc50*/ UnityEngine.Material get_sharedMaterial();
        /*0x14a3ac0*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x136fc90*/ UnityEngine.Material get_fallbackMaterial();
        /*0x14a4160*/ void set_fallbackMaterial(UnityEngine.Material value);
        /*0x136fcb0*/ UnityEngine.Material get_fallbackSourceMaterial();
        /*0x136fd70*/ void set_fallbackSourceMaterial(UnityEngine.Material value);
        /*0x14a3f70*/ UnityEngine.Material get_materialForRendering();
        /*0x14a3ea0*/ bool get_isDefaultMaterial();
        /*0x14a4300*/ void set_isDefaultMaterial(bool value);
        /*0x14a40b0*/ float get_padding();
        /*0x14a4420*/ void set_padding(float value);
        /*0x14a3fe0*/ UnityEngine.Mesh get_mesh();
        /*0x134cc40*/ void set_mesh(UnityEngine.Mesh value);
        /*0x14a40c0*/ TMPro.TMP_Text get_textComponent();
        /*0x14a38e0*/ void OnEnable();
        /*0x14a3820*/ void OnDisable();
        /*0x14a3640*/ void OnDestroy();
        /*0x14a3950*/ void OnTransformParentChanged();
        /*0x14a32d0*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        /*0x14a34c0*/ float GetPaddingForMaterial();
        /*0x14a3430*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x14a3e10*/ void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        /*0x32d010*/ void SetAllDirty();
        /*0x14a3b20*/ void SetVerticesDirty();
        /*0x32d010*/ void SetLayoutDirty();
        /*0x14a39f0*/ void SetMaterialDirty();
        /*0x14a3a40*/ void SetPivotDirty();
        /*0x14a3550*/ UnityEngine.Transform GetRootCanvasTransform();
        /*0x32d010*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
        /*0x32d010*/ void UpdateGeometry();
        /*0x14a39b0*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x1450ce0*/ void RefreshMaterial();
        /*0x14a3be0*/ void UpdateMaterial();
        /*0x1445080*/ void RecalculateClipping();
        /*0x136fc50*/ UnityEngine.Material GetMaterial();
        /*0x14a3110*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x14a3050*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x14a3610*/ UnityEngine.Material GetSharedMaterial();
        /*0x14a3ac0*/ void SetSharedMaterial(UnityEngine.Material mat);
    }

    interface ITextElement
    {
        /*0x1803b0*/ UnityEngine.Material get_sharedMaterial();
        /*0x17aa40*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
        /*0x180980*/ int GetInstanceID();
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
        /*0xe0*/ string m_text;
        /*0xe8*/ bool m_IsTextBackingStringDirty;
        /*0xf0*/ TMPro.ITextPreprocessor m_TextPreprocessor;
        /*0xf8*/ bool m_isRightToLeft;
        /*0x100*/ TMPro.TMP_FontAsset m_fontAsset;
        /*0x108*/ TMPro.TMP_FontAsset m_currentFontAsset;
        /*0x110*/ bool m_isSDFShader;
        /*0x118*/ UnityEngine.Material m_sharedMaterial;
        /*0x120*/ UnityEngine.Material m_currentMaterial;
        /*0x128*/ int m_currentMaterialIndex;
        /*0x130*/ UnityEngine.Material[] m_fontSharedMaterials;
        /*0x138*/ UnityEngine.Material m_fontMaterial;
        /*0x140*/ UnityEngine.Material[] m_fontMaterials;
        /*0x148*/ bool m_isMaterialDirty;
        /*0x14c*/ UnityEngine.Color32 m_fontColor32;
        /*0x150*/ UnityEngine.Color m_fontColor;
        /*0x160*/ UnityEngine.Color32 m_underlineColor;
        /*0x164*/ UnityEngine.Color32 m_strikethroughColor;
        /*0x168*/ bool m_enableVertexGradient;
        /*0x16c*/ TMPro.ColorMode m_colorMode;
        /*0x170*/ TMPro.VertexGradient m_fontColorGradient;
        /*0x1b0*/ TMPro.TMP_ColorGradient m_fontColorGradientPreset;
        /*0x1b8*/ TMPro.TMP_SpriteAsset m_spriteAsset;
        /*0x1c0*/ bool m_tintAllSprites;
        /*0x1c1*/ bool m_tintSprite;
        /*0x1c4*/ UnityEngine.Color32 m_spriteColor;
        /*0x1c8*/ TMPro.TMP_StyleSheet m_StyleSheet;
        /*0x1d0*/ TMPro.TMP_Style m_TextStyle;
        /*0x1d8*/ int m_TextStyleHashCode;
        /*0x1dc*/ bool m_overrideHtmlColors;
        /*0x1e0*/ UnityEngine.Color32 m_faceColor;
        /*0x1e4*/ UnityEngine.Color32 m_outlineColor;
        /*0x1e8*/ float m_outlineWidth;
        /*0x1ec*/ float m_fontSize;
        /*0x1f0*/ float m_currentFontSize;
        /*0x1f4*/ float m_fontSizeBase;
        /*0x1f8*/ TMPro.TMP_TextProcessingStack<float> m_sizeStack;
        /*0x218*/ TMPro.FontWeight m_fontWeight;
        /*0x21c*/ TMPro.FontWeight m_FontWeightInternal;
        /*0x220*/ TMPro.TMP_TextProcessingStack<TMPro.FontWeight> m_FontWeightStack;
        /*0x240*/ bool m_enableAutoSizing;
        /*0x244*/ float m_maxFontSize;
        /*0x248*/ float m_minFontSize;
        /*0x24c*/ int m_AutoSizeIterationCount;
        /*0x250*/ int m_AutoSizeMaxIterationCount;
        /*0x254*/ bool m_IsAutoSizePointSizeSet;
        /*0x258*/ float m_fontSizeMin;
        /*0x25c*/ float m_fontSizeMax;
        /*0x260*/ TMPro.FontStyles m_fontStyle;
        /*0x264*/ TMPro.FontStyles m_FontStyleInternal;
        /*0x268*/ TMPro.TMP_FontStyleStack m_fontStyleStack;
        /*0x272*/ bool m_isUsingBold;
        /*0x274*/ TMPro.HorizontalAlignmentOptions m_HorizontalAlignment;
        /*0x278*/ TMPro.VerticalAlignmentOptions m_VerticalAlignment;
        /*0x27c*/ TMPro.TextAlignmentOptions m_textAlignment;
        /*0x280*/ TMPro.HorizontalAlignmentOptions m_lineJustification;
        /*0x288*/ TMPro.TMP_TextProcessingStack<TMPro.HorizontalAlignmentOptions> m_lineJustificationStack;
        /*0x2a8*/ UnityEngine.Vector3[] m_textContainerLocalCorners;
        /*0x2b0*/ float m_characterSpacing;
        /*0x2b4*/ float m_cSpacing;
        /*0x2b8*/ float m_monoSpacing;
        /*0x2bc*/ float m_wordSpacing;
        /*0x2c0*/ float m_lineSpacing;
        /*0x2c4*/ float m_lineSpacingDelta;
        /*0x2c8*/ float m_lineHeight;
        /*0x2cc*/ bool m_IsDrivenLineSpacing;
        /*0x2d0*/ float m_lineSpacingMax;
        /*0x2d4*/ float m_paragraphSpacing;
        /*0x2d8*/ float m_charWidthMaxAdj;
        /*0x2dc*/ float m_charWidthAdjDelta;
        /*0x2e0*/ bool m_enableWordWrapping;
        /*0x2e1*/ bool m_isCharacterWrappingEnabled;
        /*0x2e2*/ bool m_isNonBreakingSpace;
        /*0x2e3*/ bool m_isIgnoringAlignment;
        /*0x2e4*/ float m_wordWrappingRatios;
        /*0x2e8*/ TMPro.TextOverflowModes m_overflowMode;
        /*0x2ec*/ int m_firstOverflowCharacterIndex;
        /*0x2f0*/ TMPro.TMP_Text m_linkedTextComponent;
        /*0x2f8*/ TMPro.TMP_Text parentLinkedComponent;
        /*0x300*/ bool m_isTextTruncated;
        /*0x301*/ bool m_enableKerning;
        /*0x304*/ float m_GlyphHorizontalAdvanceAdjustment;
        /*0x308*/ bool m_enableExtraPadding;
        /*0x309*/ bool checkPaddingRequired;
        /*0x30a*/ bool m_isRichText;
        /*0x30b*/ bool m_parseCtrlCharacters;
        /*0x30c*/ bool m_isOverlay;
        /*0x30d*/ bool m_isOrthographic;
        /*0x30e*/ bool m_isCullingEnabled;
        /*0x30f*/ bool m_isMaskingEnabled;
        /*0x310*/ bool isMaskUpdateRequired;
        /*0x311*/ bool m_ignoreCulling;
        /*0x314*/ TMPro.TextureMappingOptions m_horizontalMapping;
        /*0x318*/ TMPro.TextureMappingOptions m_verticalMapping;
        /*0x31c*/ float m_uvLineOffset;
        /*0x320*/ TMPro.TextRenderFlags m_renderMode;
        /*0x324*/ TMPro.VertexSortingOrder m_geometrySortingOrder;
        /*0x328*/ bool m_IsTextObjectScaleStatic;
        /*0x329*/ bool m_VertexBufferAutoSizeReduction;
        /*0x32c*/ int m_firstVisibleCharacter;
        /*0x330*/ int m_maxVisibleCharacters;
        /*0x334*/ int m_maxVisibleWords;
        /*0x338*/ int m_maxVisibleLines;
        /*0x33c*/ bool m_useMaxVisibleDescender;
        /*0x340*/ int m_pageToDisplay;
        /*0x344*/ bool m_isNewPage;
        /*0x348*/ UnityEngine.Vector4 m_margin;
        /*0x358*/ float m_marginLeft;
        /*0x35c*/ float m_marginRight;
        /*0x360*/ float m_marginWidth;
        /*0x364*/ float m_marginHeight;
        /*0x368*/ float m_width;
        /*0x370*/ TMPro.TMP_TextInfo m_textInfo;
        /*0x378*/ bool m_havePropertiesChanged;
        /*0x379*/ bool m_isUsingLegacyAnimationComponent;
        /*0x380*/ UnityEngine.Transform m_transform;
        /*0x388*/ UnityEngine.RectTransform m_rectTransform;
        /*0x390*/ UnityEngine.Vector2 m_PreviousRectTransformSize;
        /*0x398*/ UnityEngine.Vector2 m_PreviousPivotPosition;
        /*0x3a0*/ bool <autoSizeTextContainer>k__BackingField;
        /*0x3a1*/ bool m_autoSizeTextContainer;
        /*0x3a8*/ UnityEngine.Mesh m_mesh;
        /*0x3b0*/ bool m_isVolumetricText;
        /*0x3b8*/ System.Action<TMPro.TMP_TextInfo> OnPreRenderText;
        /*0x3c0*/ TMPro.TMP_SpriteAnimator m_spriteAnimator;
        /*0x3c8*/ float m_flexibleHeight;
        /*0x3cc*/ float m_flexibleWidth;
        /*0x3d0*/ float m_minWidth;
        /*0x3d4*/ float m_minHeight;
        /*0x3d8*/ float m_maxWidth;
        /*0x3dc*/ float m_maxHeight;
        /*0x3e0*/ UnityEngine.UI.LayoutElement m_LayoutElement;
        /*0x3e8*/ float m_preferredWidth;
        /*0x3ec*/ float m_renderedWidth;
        /*0x3f0*/ bool m_isPreferredWidthDirty;
        /*0x3f4*/ float m_preferredHeight;
        /*0x3f8*/ float m_renderedHeight;
        /*0x3fc*/ bool m_isPreferredHeightDirty;
        /*0x3fd*/ bool m_isCalculatingPreferredValues;
        /*0x400*/ int m_layoutPriority;
        /*0x404*/ bool m_isLayoutDirty;
        /*0x405*/ bool m_isAwake;
        /*0x406*/ bool m_isWaitingOnResourceLoad;
        /*0x408*/ TMPro.TMP_Text.TextInputSources m_inputSource;
        /*0x40c*/ float m_fontScaleMultiplier;
        /*0x410*/ float tag_LineIndent;
        /*0x414*/ float tag_Indent;
        /*0x418*/ TMPro.TMP_TextProcessingStack<float> m_indentStack;
        /*0x438*/ bool tag_NoParsing;
        /*0x439*/ bool m_isParsingText;
        /*0x43c*/ UnityEngine.Matrix4x4 m_FXMatrix;
        /*0x47c*/ bool m_isFXMatrixSet;
        /*0x480*/ TMPro.TMP_Text.UnicodeChar[] m_TextProcessingArray;
        /*0x488*/ int m_InternalTextProcessingArraySize;
        /*0x490*/ TMPro.TMP_CharacterInfo[] m_internalCharacterInfo;
        /*0x498*/ int m_totalCharacterCount;
        /*0x49c*/ int m_characterCount;
        /*0x4a0*/ int m_firstCharacterOfLine;
        /*0x4a4*/ int m_firstVisibleCharacterOfLine;
        /*0x4a8*/ int m_lastCharacterOfLine;
        /*0x4ac*/ int m_lastVisibleCharacterOfLine;
        /*0x4b0*/ int m_lineNumber;
        /*0x4b4*/ int m_lineVisibleCharacterCount;
        /*0x4b8*/ int m_pageNumber;
        /*0x4bc*/ float m_PageAscender;
        /*0x4c0*/ float m_maxTextAscender;
        /*0x4c4*/ float m_maxCapHeight;
        /*0x4c8*/ float m_ElementAscender;
        /*0x4cc*/ float m_ElementDescender;
        /*0x4d0*/ float m_maxLineAscender;
        /*0x4d4*/ float m_maxLineDescender;
        /*0x4d8*/ float m_startOfLineAscender;
        /*0x4dc*/ float m_startOfLineDescender;
        /*0x4e0*/ float m_lineOffset;
        /*0x4e4*/ TMPro.Extents m_meshExtents;
        /*0x4f4*/ UnityEngine.Color32 m_htmlColor;
        /*0x4f8*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_colorStack;
        /*0x518*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_underlineColorStack;
        /*0x538*/ TMPro.TMP_TextProcessingStack<UnityEngine.Color32> m_strikethroughColorStack;
        /*0x558*/ TMPro.TMP_TextProcessingStack<TMPro.HighlightState> m_HighlightStateStack;
        /*0x588*/ TMPro.TMP_ColorGradient m_colorGradientPreset;
        /*0x590*/ TMPro.TMP_TextProcessingStack<TMPro.TMP_ColorGradient> m_colorGradientStack;
        /*0x5b8*/ bool m_colorGradientPresetIsTinted;
        /*0x5bc*/ float m_tabSpacing;
        /*0x5c0*/ float m_spacing;
        /*0x5c8*/ TMPro.TMP_TextProcessingStack<int> m_TextStyleStacks;
        /*0x5d0*/ int m_TextStyleStackDepth;
        /*0x5d8*/ TMPro.TMP_TextProcessingStack<int> m_ItalicAngleStack;
        /*0x5f8*/ int m_ItalicAngle;
        /*0x600*/ TMPro.TMP_TextProcessingStack<int> m_actionStack;
        /*0x620*/ float m_padding;
        /*0x624*/ float m_baselineOffset;
        /*0x628*/ TMPro.TMP_TextProcessingStack<float> m_baselineOffsetStack;
        /*0x648*/ float m_xAdvance;
        /*0x64c*/ TMPro.TMP_TextElementType m_textElementType;
        /*0x650*/ TMPro.TMP_TextElement m_cached_TextElement;
        /*0x658*/ TMPro.TMP_Text.SpecialCharacter m_Ellipsis;
        /*0x678*/ TMPro.TMP_Text.SpecialCharacter m_Underline;
        /*0x698*/ TMPro.TMP_SpriteAsset m_defaultSpriteAsset;
        /*0x6a0*/ TMPro.TMP_SpriteAsset m_currentSpriteAsset;
        /*0x6a8*/ int m_spriteCount;
        /*0x6ac*/ int m_spriteIndex;
        /*0x6b0*/ int m_spriteAnimationID;
        /*0x6b4*/ bool m_ignoreActiveState;
        /*0x6b8*/ TMPro.TMP_Text.TextBackingContainer m_TextBackingArray;
        /*0x6c8*/ decimal[] k_Power;

        static /*0x1491560*/ TMP_Text();
        static /*0x1492720*/ void add_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x14938e0*/ void remove_OnFontAssetRequest(System.Func<int, string, TMPro.TMP_FontAsset> value);
        static /*0x14928f0*/ void add_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        static /*0x1493ab0*/ void remove_OnSpriteAssetRequest(System.Func<int, string, TMPro.TMP_SpriteAsset> value);
        /*0x1491b20*/ TMP_Text();
        /*0x14936d0*/ string get_text();
        /*0x1495020*/ void set_text(string value);
        /*0x10d0110*/ TMPro.ITextPreprocessor get_textPreprocessor();
        /*0x139f000*/ void set_textPreprocessor(TMPro.ITextPreprocessor value);
        /*0x137cf40*/ bool get_isRightToLeftText();
        /*0x1494730*/ void set_isRightToLeftText(bool value);
        /*0x136fc90*/ TMPro.TMP_FontAsset get_font();
        /*0x14944f0*/ void set_font(TMPro.TMP_FontAsset value);
        /*0x134cc10*/ UnityEngine.Material get_fontSharedMaterial();
        /*0x1494240*/ void set_fontSharedMaterial(UnityEngine.Material value);
        /*0x1492d20*/ UnityEngine.Material[] get_fontSharedMaterials();
        /*0x14941e0*/ void set_fontSharedMaterials(UnityEngine.Material[] value);
        /*0x1492ce0*/ UnityEngine.Material get_fontMaterial();
        /*0x14940d0*/ void set_fontMaterial(UnityEngine.Material value);
        /*0x1492d00*/ UnityEngine.Material[] get_fontMaterials();
        /*0x14941e0*/ void set_fontMaterials(UnityEngine.Material[] value);
        /*0x1492b50*/ UnityEngine.Color get_color();
        /*0x1493db0*/ void set_color(UnityEngine.Color value);
        /*0x1492a10*/ float get_alpha();
        /*0x1493c10*/ void set_alpha(float value);
        /*0x1492b90*/ bool get_enableVertexGradient();
        /*0x1493f30*/ void set_enableVertexGradient(bool value);
        /*0x1492b20*/ TMPro.VertexGradient get_colorGradient();
        /*0x1493d60*/ void set_colorGradient(TMPro.VertexGradient value);
        /*0x1474cf0*/ TMPro.TMP_ColorGradient get_colorGradientPreset();
        /*0x1493d20*/ void set_colorGradientPreset(TMPro.TMP_ColorGradient value);
        /*0x1474d30*/ TMPro.TMP_SpriteAsset get_spriteAsset();
        /*0x1494ef0*/ void set_spriteAsset(TMPro.TMP_SpriteAsset value);
        /*0x14937d0*/ bool get_tintAllSprites();
        /*0x14950d0*/ void set_tintAllSprites(bool value);
        /*0x1474ce0*/ TMPro.TMP_StyleSheet get_styleSheet();
        /*0x1494f50*/ void set_styleSheet(TMPro.TMP_StyleSheet value);
        /*0x1493650*/ TMPro.TMP_Style get_textStyle();
        /*0x1494fb0*/ void set_textStyle(TMPro.TMP_Style value);
        /*0x1493180*/ bool get_overrideColorTags();
        /*0x1494d50*/ void set_overrideColorTags(bool value);
        /*0x1492bc0*/ UnityEngine.Color32 get_faceColor();
        /*0x1494020*/ void set_faceColor(UnityEngine.Color32 value);
        /*0x1492fc0*/ UnityEngine.Color32 get_outlineColor();
        /*0x1494c10*/ void set_outlineColor(UnityEngine.Color32 value);
        /*0x14930b0*/ float get_outlineWidth();
        /*0x1494c80*/ void set_outlineWidth(float value);
        /*0x1492d50*/ float get_fontSize();
        /*0x14943c0*/ void set_fontSize(float value);
        /*0x1492d70*/ TMPro.FontWeight get_fontWeight();
        /*0x1494490*/ void set_fontWeight(TMPro.FontWeight value);
        /*0x14931c0*/ float get_pixelsPerUnit();
        /*0x1492b60*/ bool get_enableAutoSizing();
        /*0x1493e40*/ void set_enableAutoSizing(bool value);
        /*0x1492d40*/ float get_fontSizeMin();
        /*0x1494360*/ void set_fontSizeMin(float value);
        /*0x43b2c0*/ float get_fontSizeMax();
        /*0x1494300*/ void set_fontSizeMax(float value);
        /*0x1492d60*/ TMPro.FontStyles get_fontStyle();
        /*0x1494430*/ void set_fontStyle(TMPro.FontStyles value);
        /*0x1492e20*/ bool get_isUsingBold();
        /*0x1492da0*/ TMPro.HorizontalAlignmentOptions get_horizontalAlignment();
        /*0x1494620*/ void set_horizontalAlignment(TMPro.HorizontalAlignmentOptions value);
        /*0x14938a0*/ TMPro.VerticalAlignmentOptions get_verticalAlignment();
        /*0x1495160*/ void set_verticalAlignment(TMPro.VerticalAlignmentOptions value);
        /*0x1492a00*/ TMPro.TextAlignmentOptions get_alignment();
        /*0x1493bc0*/ void set_alignment(TMPro.TextAlignmentOptions value);
        /*0x1492b00*/ float get_characterSpacing();
        /*0x1493c60*/ void set_characterSpacing(float value);
        /*0x14938c0*/ float get_wordSpacing();
        /*0x14951c0*/ void set_wordSpacing(float value);
        /*0x1492f10*/ float get_lineSpacing();
        /*0x1494900*/ void set_lineSpacing(float value);
        /*0x1492f00*/ float get_lineSpacingAdjustment();
        /*0x14948a0*/ void set_lineSpacingAdjustment(float value);
        /*0x14931a0*/ float get_paragraphSpacing();
        /*0x1494db0*/ void set_paragraphSpacing(float value);
        /*0x1492b10*/ float get_characterWidthAdjustment();
        /*0x1493cc0*/ void set_characterWidthAdjustment(float value);
        /*0x1492ba0*/ bool get_enableWordWrapping();
        /*0x1493f60*/ void set_enableWordWrapping(bool value);
        /*0x14938d0*/ float get_wordWrappingRatios();
        /*0x1495220*/ void set_wordWrappingRatios(float value);
        /*0x13e3ed0*/ TMPro.TextOverflowModes get_overflowMode();
        /*0x1494cf0*/ void set_overflowMode(TMPro.TextOverflowModes value);
        /*0x1492e00*/ bool get_isTextOverflowing();
        /*0x13e3e10*/ int get_firstOverflowCharacterIndex();
        /*0x1492f20*/ TMPro.TMP_Text get_linkedTextComponent();
        /*0x1494960*/ void set_linkedTextComponent(TMPro.TMP_Text value);
        /*0x1492e10*/ bool get_isTextTruncated();
        /*0x1492b80*/ bool get_enableKerning();
        /*0x1493ed0*/ void set_enableKerning(bool value);
        /*0x1492bb0*/ bool get_extraPadding();
        /*0x1493fc0*/ void set_extraPadding(bool value);
        /*0x14934d0*/ bool get_richText();
        /*0x1494e90*/ void set_richText(bool value);
        /*0x14931b0*/ bool get_parseCtrlCharacters();
        /*0x1494e10*/ void set_parseCtrlCharacters(bool value);
        /*0x1492de0*/ bool get_isOverlay();
        /*0x14946d0*/ void set_isOverlay(bool value);
        /*0x1492dd0*/ bool get_isOrthographic();
        /*0x14946a0*/ void set_isOrthographic(bool value);
        /*0x1492b70*/ bool get_enableCulling();
        /*0x1493e90*/ void set_enableCulling(bool value);
        /*0x1492dc0*/ bool get_ignoreVisibility();
        /*0x1494680*/ void set_ignoreVisibility(bool value);
        /*0x1492db0*/ TMPro.TextureMappingOptions get_horizontalMapping();
        /*0x1494650*/ void set_horizontalMapping(TMPro.TextureMappingOptions value);
        /*0x14938b0*/ TMPro.TextureMappingOptions get_verticalMapping();
        /*0x1495190*/ void set_verticalMapping(TMPro.TextureMappingOptions value);
        /*0x1492f30*/ float get_mappingUvLineOffset();
        /*0x1494a80*/ void set_mappingUvLineOffset(float value);
        /*0x14934c0*/ TMPro.TextRenderFlags get_renderMode();
        /*0x1494e70*/ void set_renderMode(TMPro.TextRenderFlags value);
        /*0x1492d80*/ TMPro.VertexSortingOrder get_geometrySortingOrder();
        /*0x14945c0*/ void set_geometrySortingOrder(TMPro.VertexSortingOrder value);
        /*0x1492df0*/ bool get_isTextObjectScaleStatic();
        /*0x1494790*/ void set_isTextObjectScaleStatic(bool value);
        /*0x1493890*/ bool get_vertexBufferAutoSizeReduction();
        /*0x1495130*/ void set_vertexBufferAutoSizeReduction(bool value);
        /*0x1492cb0*/ int get_firstVisibleCharacter();
        /*0x14940a0*/ void set_firstVisibleCharacter(int value);
        /*0x1492f60*/ int get_maxVisibleCharacters();
        /*0x1494b80*/ void set_maxVisibleCharacters(int value);
        /*0x1492f80*/ int get_maxVisibleWords();
        /*0x1494be0*/ void set_maxVisibleWords(int value);
        /*0x1492f70*/ int get_maxVisibleLines();
        /*0x1494bb0*/ void set_maxVisibleLines(int value);
        /*0x1493880*/ bool get_useMaxVisibleDescender();
        /*0x1495100*/ void set_useMaxVisibleDescender(bool value);
        /*0x1493190*/ int get_pageToDisplay();
        /*0x1494d80*/ void set_pageToDisplay(int value);
        /*0x1492f40*/ UnityEngine.Vector4 get_margin();
        /*0x1494ac0*/ void set_margin(UnityEngine.Vector4 value);
        /*0x13e3df0*/ TMPro.TMP_TextInfo get_textInfo();
        /*0x1492d90*/ bool get_havePropertiesChanged();
        /*0x14945f0*/ void set_havePropertiesChanged(bool value);
        /*0x1492e30*/ bool get_isUsingLegacyAnimationComponent();
        /*0x1494820*/ void set_isUsingLegacyAnimationComponent(bool value);
        /*0x14937e0*/ UnityEngine.Transform get_transform();
        /*0x1493420*/ UnityEngine.RectTransform get_rectTransform();
        /*0x1492a20*/ bool get_autoSizeTextContainer();
        /*0x1493c50*/ void set_autoSizeTextContainer(bool value);
        /*0x144ada0*/ UnityEngine.Mesh get_mesh();
        /*0x1492e40*/ bool get_isVolumetricText();
        /*0x1494830*/ void set_isVolumetricText(bool value);
        /*0x1492a30*/ UnityEngine.Bounds get_bounds();
        /*0x14935f0*/ UnityEngine.Bounds get_textBounds();
        /*0x1492830*/ void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x14939f0*/ void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value);
        /*0x14934e0*/ TMPro.TMP_SpriteAnimator get_spriteAnimator();
        /*0x1492cc0*/ float get_flexibleHeight();
        /*0x1492cd0*/ float get_flexibleWidth();
        /*0x1492fb0*/ float get_minWidth();
        /*0x1492fa0*/ float get_minHeight();
        /*0x1492f90*/ float get_maxWidth();
        /*0x1492f50*/ float get_maxHeight();
        /*0x1492e50*/ UnityEngine.UI.LayoutElement get_layoutElement();
        /*0x1493400*/ float get_preferredWidth();
        /*0x14933e0*/ float get_preferredHeight();
        /*0x14800d0*/ float get_renderedWidth();
        /*0x147fff0*/ float get_renderedHeight();
        /*0x1492ef0*/ int get_layoutPriority();
        /*0x32d010*/ void LoadFontAsset();
        /*0x32d010*/ void SetSharedMaterial(UnityEngine.Material mat);
        /*0x388e90*/ UnityEngine.Material GetMaterial(UnityEngine.Material mat);
        /*0x32d010*/ void SetFontBaseMaterial(UnityEngine.Material mat);
        /*0x388e90*/ UnityEngine.Material[] GetSharedMaterials();
        /*0x32d010*/ void SetSharedMaterials(UnityEngine.Material[] materials);
        /*0x388e90*/ UnityEngine.Material[] GetMaterials(UnityEngine.Material[] mats);
        /*0x147b540*/ UnityEngine.Material CreateMaterialInstance(UnityEngine.Material source);
        /*0x148a470*/ void SetVertexColorGradient(TMPro.TMP_ColorGradient gradient);
        /*0x32d010*/ void SetTextSortingOrder(TMPro.VertexSortingOrder order);
        /*0x32d010*/ void SetTextSortingOrder(int[] order);
        /*0x32d010*/ void SetFaceColor(UnityEngine.Color32 color);
        /*0x32d010*/ void SetOutlineColor(UnityEngine.Color32 color);
        /*0x32d010*/ void SetOutlineThickness(float thickness);
        /*0x32d010*/ void SetShaderDepth();
        /*0x32d010*/ void SetCulling();
        /*0x32d010*/ void UpdateCulling();
        /*0x147f3a0*/ float GetPaddingForMaterial();
        /*0x147f4f0*/ float GetPaddingForMaterial(UnityEngine.Material mat);
        /*0x388e90*/ UnityEngine.Vector3[] GetTextContainerLocalCorners();
        /*0x32d010*/ void ForceMeshUpdate(bool ignoreActiveState, bool forceTextReparsing);
        /*0x32d010*/ void UpdateGeometry(UnityEngine.Mesh mesh, int index);
        /*0x32d010*/ void UpdateVertexData(TMPro.TMP_VertexDataUpdateFlags flags);
        /*0x32d010*/ void UpdateVertexData();
        /*0x32d010*/ void SetVertices(UnityEngine.Vector3[] vertices);
        /*0x32d010*/ void UpdateMeshPadding();
        /*0x147b670*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x147b600*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x32d010*/ void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        /*0x32d010*/ void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        /*0x1484120*/ void ParseInputText();
        /*0x1484630*/ void PopulateTextBackingArray(string sourceText);
        /*0x1484410*/ void PopulateTextBackingArray(string sourceText, int start, int length);
        /*0x1484300*/ void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length);
        /*0x1484510*/ void PopulateTextBackingArray(char[] sourceText, int start, int length);
        /*0x1484700*/ void PopulateTextProcessingArray();
        /*0x1489b70*/ void SetTextInternal(string sourceText);
        /*0x1489fb0*/ void SetText(string sourceText, bool syncTextInputBox);
        /*0x148a2b0*/ void SetText(string sourceText, float arg0);
        /*0x1489c70*/ void SetText(string sourceText, float arg0, float arg1);
        /*0x148a210*/ void SetText(string sourceText, float arg0, float arg1, float arg2);
        /*0x148a260*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3);
        /*0x148a1b0*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4);
        /*0x148a0e0*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
        /*0x148a140*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);
        /*0x1489d00*/ void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7);
        /*0x1489cb0*/ void SetText(System.Text.StringBuilder sourceText);
        /*0x148a300*/ void SetText(System.Text.StringBuilder sourceText, int start, int length);
        /*0x1489b40*/ void SetText(char[] sourceText);
        /*0x148a2f0*/ void SetText(char[] sourceText, int start, int length);
        /*0x1489b40*/ void SetCharArray(char[] sourceText);
        /*0x14899c0*/ void SetCharArray(char[] sourceText, int start, int length);
        /*0x1480310*/ TMPro.TMP_Style GetStyle(int hashCode);
        /*0x14860d0*/ bool ReplaceOpeningStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1486920*/ bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, ref int srcOffset, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1485560*/ void ReplaceClosingStyleTag(ref TMPro.TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1485cf0*/ void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x14833e0*/ bool InsertOpeningStyleTag(TMPro.TMP_Style style, int srcIndex, ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x1482370*/ void InsertClosingStyleTag(ref TMPro.TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex);
        /*0x147f1f0*/ int GetMarkupTagHashCode(int[] tagDefinition, int readIndex);
        /*0x147f2e0*/ int GetMarkupTagHashCode(TMPro.TMP_Text.TextBackingContainer tagDefinition, int readIndex);
        /*0x1480130*/ int GetStyleHashCode(ref int[] text, int index, ref int closeIndex);
        /*0x1480220*/ int GetStyleHashCode(ref TMPro.TMP_Text.TextBackingContainer text, int index, ref int closeIndex);
        /*0x17aec0*/ void ResizeInternalArray<T>(ref T[] array);
        /*0x182a70*/ void ResizeInternalArray<T>(ref T[] array, int size);
        /*0x1477950*/ void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex);
        /*0x1477df0*/ void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex);
        /*0x1483b60*/ string InternalTextBackingArrayToString();
        /*0x388e90*/ int SetArraySizes(TMPro.TMP_Text.UnicodeChar[] unicodeChars);
        /*0x147fd40*/ UnityEngine.Vector2 GetPreferredValues();
        /*0x147f9b0*/ UnityEngine.Vector2 GetPreferredValues(float width, float height);
        /*0x147fa20*/ UnityEngine.Vector2 GetPreferredValues(string text);
        /*0x147fbd0*/ UnityEngine.Vector2 GetPreferredValues(string text, float width, float height);
        /*0x147fda0*/ float GetPreferredWidth();
        /*0x147ff30*/ float GetPreferredWidth(UnityEngine.Vector2 margin);
        /*0x147f7c0*/ float GetPreferredHeight();
        /*0x147f700*/ float GetPreferredHeight(UnityEngine.Vector2 margin);
        /*0x1480060*/ UnityEngine.Vector2 GetRenderedValues();
        /*0x1480020*/ UnityEngine.Vector2 GetRenderedValues(bool onlyVisibleCharacters);
        /*0x14800d0*/ float GetRenderedWidth();
        /*0x14800a0*/ float GetRenderedWidth(bool onlyVisibleCharacters);
        /*0x147fff0*/ float GetRenderedHeight();
        /*0x147ffc0*/ float GetRenderedHeight(bool onlyVisibleCharacters);
        /*0x14783a0*/ UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled);
        /*0xbd0340*/ UnityEngine.Bounds GetCompoundBounds();
        /*0x147ee80*/ UnityEngine.Rect GetCanvasSpaceClippingRect();
        /*0x1480740*/ UnityEngine.Bounds GetTextBounds();
        /*0x1480400*/ UnityEngine.Bounds GetTextBounds(bool onlyVisibleCharacters);
        /*0x1477f50*/ void AdjustLineOffset(int startIndex, int endIndex, float offset);
        /*0x1486e30*/ void ResizeLineExtents(int size);
        /*0x388e90*/ TMPro.TMP_TextInfo GetTextInfo(string text);
        /*0x32d010*/ void ComputeMarginSize();
        /*0x1482ae0*/ void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender);
        /*0x1489440*/ void SaveWordWrappingState(ref TMPro.WordWrapState state, int index, int count);
        /*0x1487080*/ int RestoreWordWrappingState(ref TMPro.WordWrapState state);
        /*0x1487650*/ void SaveGlyphVertexInfo(float padding, float style_padding, UnityEngine.Color32 vertexColor);
        /*0x1488a90*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor);
        /*0x147cc50*/ void FillCharacterVertexBuffers(int i, int index_X4);
        /*0x147d530*/ void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric);
        /*0x147e380*/ void FillSpriteVertexBuffers(int i, int index_X4);
        /*0x147bca0*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor);
        /*0x147b710*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor);
        /*0x1483d40*/ void LoadDefaultSettings();
        /*0x1480100*/ void GetSpecialCharacters(TMPro.TMP_FontAsset fontAsset);
        /*0x147eeb0*/ void GetEllipsisSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x14817f0*/ void GetUnderlineSpecialCharacter(TMPro.TMP_FontAsset fontAsset);
        /*0x1486dd0*/ void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c);
        /*0x147f160*/ TMPro.TMP_FontAsset GetFontAssetForWeight(int fontWeight);
        /*0x1480a40*/ TMPro.TMP_TextElement GetTextElement(uint unicode, TMPro.TMP_FontAsset fontAsset, TMPro.FontStyles fontStyle, TMPro.FontWeight fontWeight, ref bool isUsingAlternativeTypeface);
        /*0x32d010*/ void SetActiveSubMeshes(bool state);
        /*0x32d010*/ void DestroySubMeshObjects();
        /*0x32d010*/ void ClearMesh();
        /*0x32d010*/ void ClearMesh(bool uploadGeometry);
        /*0x147f610*/ string GetParsedText();
        /*0x1483c50*/ bool IsSelfOrLinkedAncestor(TMPro.TMP_Text targetTextComponent);
        /*0x1485420*/ void ReleaseLinkedTextComponent(TMPro.TMP_Text targetTextComponent);
        /*0x14840e0*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
        /*0x14840a0*/ float PackUV(float x, float y);
        /*0x32d010*/ void InternalUpdate();
        /*0x1482250*/ int HexToInt(char hex);
        /*0x1481040*/ int GetUTF16(string text, int i);
        /*0x1480f70*/ int GetUTF16(int[] text, int i);
        /*0x1480f70*/ int GetUTF16(uint[] text, int i);
        /*0x1480e90*/ int GetUTF16(System.Text.StringBuilder text, int i);
        /*0x1481120*/ int GetUTF16(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x14811f0*/ int GetUTF32(string text, int i);
        /*0x1481380*/ int GetUTF32(int[] text, int i);
        /*0x1481380*/ int GetUTF32(uint[] text, int i);
        /*0x1481660*/ int GetUTF32(System.Text.StringBuilder text, int i);
        /*0x1481500*/ int GetUTF32(TMPro.TMP_Text.TextBackingContainer text, int i);
        /*0x1481c20*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
        /*0x1481950*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
        /*0x147ec60*/ int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters);
        /*0x147b510*/ float ConvertToFloat(char[] chars, int startIndex, int length);
        /*0x147b360*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
        /*0x148a520*/ bool ValidateHtmlTag(TMPro.TMP_Text.UnicodeChar[] chars, int startIndex, ref int endIndex);

        struct CharacterSubstitution
        {
            /*0x10*/ int index;
            /*0x14*/ uint unicode;

            /*0xa59f20*/ CharacterSubstitution(int index, uint unicode);
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

            /*0x14982c0*/ SpecialCharacter(TMPro.TMP_Character character, int materialIndex);
        }

        struct TextBackingContainer
        {
            /*0x10*/ uint[] m_Array;
            /*0x18*/ int m_Count;

            /*0x14ac740*/ TextBackingContainer(int size);
            /*0x728950*/ int get_Capacity();
            /*0x834a60*/ int get_Count();
            /*0xf0fbd0*/ void set_Count(int value);
            /*0x14ac7a0*/ uint get_Item(int index);
            /*0x14ac7d0*/ void set_Item(int index, uint value);
            /*0x14ac6f0*/ void Resize(int size);
        }

        class <>c
        {
            static /*0x0*/ TMPro.TMP_Text.<> <>9;
            static /*0x8*/ System.Action<TMPro.TMP_TextInfo> <>9__622_0;

            static /*0x14adb60*/ <>c();
            /*0x32f970*/ <>c();
            /*0x32d010*/ void <.ctor>b__622_0(TMPro.TMP_TextInfo <p0>);
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

        /*0x32f970*/ TMP_TextElement();
        /*0x793eb0*/ TMPro.TextElementType get_elementType();
        /*0x70a440*/ uint get_unicode();
        /*0xc70b20*/ void set_unicode(uint value);
        /*0x32f410*/ TMPro.TMP_Asset get_textAsset();
        /*0x7963c0*/ void set_textAsset(TMPro.TMP_Asset value);
        /*0x61a260*/ UnityEngine.TextCore.Glyph get_glyph();
        /*0x7965a0*/ void set_glyph(UnityEngine.TextCore.Glyph value);
        /*0x3e3ae0*/ uint get_glyphIndex();
        /*0xc6dab0*/ void set_glyphIndex(uint value);
        /*0x4ccc40*/ float get_scale();
        /*0x4ccc50*/ void set_scale(float value);
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

        /*0x32f970*/ TMP_TextElement_Legacy();
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

        static /*0x14a6760*/ TMP_TextInfo();
        static /*0x1827f0*/ void Resize<T>(ref T[] array, int size);
        static /*0x182ab0*/ void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
        /*0x14a67c0*/ TMP_TextInfo();
        /*0x14a6ab0*/ TMP_TextInfo(int characterCount);
        /*0x14a6900*/ TMP_TextInfo(TMPro.TMP_Text textComponent);
        /*0x14a6100*/ void Clear();
        /*0x14a59f0*/ void ClearAllData();
        /*0x14a5e80*/ void ClearMeshInfo(bool updateMesh);
        /*0x14a5b40*/ void ClearAllMeshInfo();
        /*0x14a66a0*/ void ResetVertexLayout(bool isVolumetric);
        /*0x14a6040*/ void ClearUnusedVertices(TMPro.MaterialReference[] materials);
        /*0x14a5bf0*/ void ClearLineInfo();
        /*0x14a5f40*/ void ClearPageInfo();
        /*0x14a6170*/ TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData();
    }

    class TMP_TextParsingUtilities
    {
        static string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ TMPro.TMP_TextParsingUtilities s_Instance;

        static /*0x14a6f00*/ TMP_TextParsingUtilities();
        static /*0x14a6f70*/ TMPro.TMP_TextParsingUtilities get_instance();
        static /*0x14a6c60*/ int GetHashCode(string s);
        static /*0x14a6c00*/ int GetHashCodeCaseSensitive(string s);
        static /*0x14a6d80*/ char ToLowerASCIIFast(char c);
        static /*0x14a6ea0*/ char ToUpperASCIIFast(char c);
        static /*0x14a6e40*/ uint ToUpperASCIIFast(uint c);
        static /*0x14a6de0*/ uint ToLowerASCIIFast(uint c);
        static /*0x14a6d40*/ bool IsHighSurrogate(uint c);
        static /*0x14a6d60*/ bool IsLowSurrogate(uint c);
        static /*0x14a6bf0*/ uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate);
        /*0x32f970*/ TMP_TextParsingUtilities();
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

        /*0x1498510*/ void Clear();
        /*0x1498460*/ byte Add(TMPro.FontStyles style);
        /*0x1498520*/ byte Remove(TMPro.FontStyles style);
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

        static /*0x2a5510*/ void SetDefault(TMPro.TMP_TextProcessingStack<T> stack, T item);
        /*0x17aec0*/ TMP_TextProcessingStack(T[] stack);
        /*0x17aa40*/ TMP_TextProcessingStack(int capacity);
        /*0x1817d0*/ TMP_TextProcessingStack(int capacity, int rolloverSize);
        /*0x180980*/ int get_Count();
        /*0x2a5510*/ T get_current();
        /*0x180980*/ int get_rolloverSize();
        /*0x17aa40*/ void set_rolloverSize(int value);
        /*0x180fc0*/ void Clear();
        /*0x2a5510*/ void SetDefault(T item);
        /*0x2a5510*/ void Add(T item);
        /*0x2a5510*/ T Remove();
        /*0x2a5510*/ void Push(T item);
        /*0x2a5510*/ T Pop();
        /*0x2a5510*/ T Peek();
        /*0x2a5510*/ T CurrentItem();
        /*0x2a5510*/ T PreviousItem();
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

        /*0xa59f20*/ CaretInfo(int index, TMPro.CaretPosition position);
    }

    class TMP_TextUtilities
    {
        static string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
        static string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
        static /*0x0*/ UnityEngine.Vector3[] m_rectWorldCorners;

        static /*0x14ac680*/ TMP_TextUtilities();
        static /*0x14ab280*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14ab450*/ int GetCursorIndexFromPosition(TMPro.TMP_Text textComponent, UnityEngine.Vector3 position, UnityEngine.Camera camera, ref TMPro.CaretPosition cursor);
        static /*0x14a9330*/ int FindNearestLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14a8760*/ int FindNearestCharacterOnLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, int line, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x14abb80*/ bool IsIntersectingRectTransform(UnityEngine.RectTransform rectTransform, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14a71b0*/ int FindIntersectingCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x14a8d70*/ int FindNearestCharacter(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera, bool visibleOnly);
        static /*0x14a7f30*/ int FindIntersectingWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14aa420*/ int FindNearestWord(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14a75e0*/ int FindIntersectingLine(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14a77d0*/ int FindIntersectingLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14a95f0*/ int FindNearestLink(TMPro.TMP_Text text, UnityEngine.Vector3 position, UnityEngine.Camera camera);
        static /*0x14abe20*/ bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d);
        static /*0x14abfa0*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.Transform transform, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x14ab9a0*/ bool IntersectLinePlane(TMPro.TMP_TextUtilities.LineSegment line, UnityEngine.Vector3 point, UnityEngine.Vector3 normal, ref UnityEngine.Vector3 intersectingPoint);
        static /*0x14a6fc0*/ float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point);
        static /*0x14ac560*/ char ToLowerFast(char c);
        static /*0x14ac620*/ char ToUpperFast(char c);
        static /*0x14ac5c0*/ uint ToUpperASCIIFast(uint c);
        static /*0x14ab6c0*/ int GetHashCode(string s);
        static /*0x14a6c00*/ int GetSimpleHashCode(string s);
        static /*0x14ab7a0*/ uint GetSimpleHashCodeLowercase(string s);
        static /*0x14ab880*/ int HexToInt(char hex);
        static /*0x14ac360*/ int StringHexToInt(string s);

        struct LineSegment
        {
            /*0x10*/ UnityEngine.Vector3 Point1;
            /*0x1c*/ UnityEngine.Vector3 Point2;

            /*0x1201cd0*/ LineSegment(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2);
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

        static /*0x14aed30*/ TMP_UpdateManager();
        static /*0x14af0a0*/ TMPro.TMP_UpdateManager get_instance();
        static /*0x14ae990*/ void RegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x14ae890*/ void RegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        static /*0x14ae790*/ void RegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        static /*0x14ae690*/ void RegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        static /*0x14aec60*/ void UnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        static /*0x14aea90*/ void UnRegisterTextElementForRebuild(TMPro.TMP_Text element);
        /*0x14aee80*/ TMP_UpdateManager();
        /*0x14ae3e0*/ void InternalRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
        /*0x14ae320*/ void InternalRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x14ae260*/ void InternalRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x14ae1a0*/ void InternalRegisterTextElementForCullingUpdate(TMPro.TMP_Text element);
        /*0x14ae680*/ void OnCameraPreCull();
        /*0x14adeb0*/ void DoRebuilds();
        /*0x14ae4a0*/ void InternalUnRegisterTextElementForGraphicRebuild(TMPro.TMP_Text element);
        /*0x14ae540*/ void InternalUnRegisterTextElementForLayoutRebuild(TMPro.TMP_Text element);
        /*0x14ae5e0*/ void InternalUnRegisterTextObjectForUpdate(TMPro.TMP_Text textObject);
    }

    class TMP_UpdateRegistry
    {
        static /*0x0*/ TMPro.TMP_UpdateRegistry s_Instance;
        /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        /*0x18*/ System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        /*0x28*/ System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;

        static /*0x14afec0*/ TMPro.TMP_UpdateRegistry get_instance();
        static /*0x14afa30*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x14af900*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        static /*0x14afb60*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x14afd60*/ TMP_UpdateRegistry();
        /*0x14af2b0*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x14af180*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x14af5e0*/ void PerformUpdateForCanvasRendererObjects();
        /*0x14af8a0*/ void PerformUpdateForMeshRendererObjects();
        /*0x14af4e0*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
        /*0x14af3e0*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
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
            /*0x32f970*/ TexturePacker_JsonArray();

            struct SpriteFrame
            {
                /*0x10*/ float x;
                /*0x14*/ float y;
                /*0x18*/ float w;
                /*0x1c*/ float h;

                /*0x14adc40*/ string ToString();
            }

            struct SpriteSize
            {
                /*0x10*/ float w;
                /*0x14*/ float h;

                /*0x14ade10*/ string ToString();
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

                /*0x32f970*/ SpriteDataObject();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;
    static /*0xc*/ <PrivateImplementationDetails> 8888F405A0F13565CE61E72C16289D7F52D50B6F9F074009144957058CC0160C;
    static /*0xdeb*/ <PrivateImplementationDetails> A0BB68DF4543FF935410ECA29946D43697DAD4F551DD546985F312A295B87E9D;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=3551
    {
    }

    struct __StaticArrayInitTypeSize=5236
    {
    }
}
