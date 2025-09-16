class <Module>
{
}

namespace UnityEngine
{
    interface ICanvasRaycastFilter
    {
        bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasGroup : UnityEngine.Behaviour, UnityEngine.ICanvasRaycastFilter
    {
        static /*0x8187260*/ float get_alpha_Injected(nint _unity_self);
        static /*0x8187324*/ void set_alpha_Injected(nint _unity_self, float value);
        static /*0x81873e8*/ bool get_interactable_Injected(nint _unity_self);
        static /*0x81874a4*/ void set_interactable_Injected(nint _unity_self, bool value);
        static /*0x8187560*/ bool get_blocksRaycasts_Injected(nint _unity_self);
        static /*0x818761c*/ void set_blocksRaycasts_Injected(nint _unity_self, bool value);
        static /*0x81876d8*/ bool get_ignoreParentGroups_Injected(nint _unity_self);
        static /*0x8187794*/ void set_ignoreParentGroups_Injected(nint _unity_self, bool value);
        /*0x81877dc*/ CanvasGroup();
        /*0x81871e8*/ float get_alpha();
        /*0x818729c*/ void set_alpha(float value);
        /*0x8187370*/ bool get_interactable();
        /*0x8187424*/ void set_interactable(bool value);
        /*0x81874e8*/ bool get_blocksRaycasts();
        /*0x818759c*/ void set_blocksRaycasts(bool value);
        /*0x8187660*/ bool get_ignoreParentGroups();
        /*0x8187714*/ void set_ignoreParentGroups(bool value);
        /*0x81877d8*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x81890e0*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81891c8*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x8189378*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x8189480*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81895b8*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x81896bc*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x8189334*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x8189298*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x818951c*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        static /*0x818785c*/ bool get_hasPopInstruction_Injected(nint _unity_self);
        static /*0x8187918*/ void set_hasPopInstruction_Injected(nint _unity_self, bool value);
        static /*0x81879d4*/ int get_materialCount_Injected(nint _unity_self);
        static /*0x8187a90*/ void set_materialCount_Injected(nint _unity_self, int value);
        static /*0x8187b4c*/ int get_popMaterialCount_Injected(nint _unity_self);
        static /*0x8187c08*/ void set_popMaterialCount_Injected(nint _unity_self, int value);
        static /*0x8187cc4*/ int get_absoluteDepth_Injected(nint _unity_self);
        static /*0x8187d78*/ bool get_hasMoved_Injected(nint _unity_self);
        static /*0x8187e2c*/ bool get_cullTransparentMesh_Injected(nint _unity_self);
        static /*0x8187ee8*/ void set_cullTransparentMesh_Injected(nint _unity_self, bool value);
        static /*0x8187fa4*/ bool get_hasRectClipping_Injected(nint _unity_self);
        static /*0x8188058*/ int get_relativeDepth_Injected(nint _unity_self);
        static /*0x818810c*/ bool get_cull_Injected(nint _unity_self);
        static /*0x81881c8*/ void set_cull_Injected(nint _unity_self, bool value);
        static /*0x81882b0*/ void SetColor_Injected(nint _unity_self, ref UnityEngine.Color color);
        static /*0x8188388*/ void GetColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x818845c*/ void EnableRectClipping_Injected(nint _unity_self, ref UnityEngine.Rect rect);
        static /*0x8188528*/ void get_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x81885f0*/ void set_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x81886ac*/ void DisableRectClipping_Injected(nint _unity_self);
        static /*0x81887a4*/ void SetMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x818889c*/ nint GetMaterial_Injected(nint _unity_self, int index);
        static /*0x818899c*/ void SetPopMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x8188a94*/ nint GetPopMaterial_Injected(nint _unity_self, int index);
        static /*0x8188b8c*/ void SetTexture_Injected(nint _unity_self, nint texture);
        static /*0x8188c84*/ void SetAlphaTexture_Injected(nint _unity_self, nint texture);
        static /*0x8188d7c*/ void SetMesh_Injected(nint _unity_self, nint mesh);
        static /*0x8188e54*/ nint GetMesh_Injected(nint _unity_self);
        static /*0x8188f08*/ void Clear_Injected(nint _unity_self);
        static /*0x8188ff8*/ float GetInheritedAlpha_Injected(nint _unity_self);
        /*0x818a13c*/ CanvasRenderer();
        /*0x81877e4*/ bool get_hasPopInstruction();
        /*0x8187898*/ void set_hasPopInstruction(bool value);
        /*0x818795c*/ int get_materialCount();
        /*0x8187a10*/ void set_materialCount(int value);
        /*0x8187ad4*/ int get_popMaterialCount();
        /*0x8187b88*/ void set_popMaterialCount(int value);
        /*0x8187c4c*/ int get_absoluteDepth();
        /*0x8187d00*/ bool get_hasMoved();
        /*0x8187db4*/ bool get_cullTransparentMesh();
        /*0x8187e68*/ void set_cullTransparentMesh(bool value);
        /*0x8187f2c*/ bool get_hasRectClipping();
        /*0x8187fe0*/ int get_relativeDepth();
        /*0x8188094*/ bool get_cull();
        /*0x8188148*/ void set_cull(bool value);
        /*0x818820c*/ bool get_isMask();
        /*0x8188214*/ void set_isMask(bool value);
        /*0x8188220*/ void SetColor(UnityEngine.Color color);
        /*0x81882f4*/ UnityEngine.Color GetColor();
        /*0x81883cc*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x81884a0*/ UnityEngine.Vector2 get_clippingSoftness();
        /*0x818856c*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x8188634*/ void DisableRectClipping();
        /*0x81886e8*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x81887f8*/ UnityEngine.Material GetMaterial(int index);
        /*0x81888e0*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x81889f0*/ UnityEngine.Material GetPopMaterial(int index);
        /*0x8188ad8*/ void SetTexture(UnityEngine.Texture texture);
        /*0x8188bd0*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x8188cc8*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x8188dc0*/ UnityEngine.Mesh GetMesh();
        /*0x8188e90*/ void Clear();
        /*0x8188f44*/ float GetAlpha();
        /*0x8188f58*/ void SetAlpha(float alpha);
        /*0x8188f80*/ float GetInheritedAlpha();
        /*0x8189034*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x81890d8*/ UnityEngine.Material GetMaterial();
        /*0x8189758*/ void SetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x81897c8*/ void SetVertices(UnityEngine.UIVertex[] vertices, int size);
    }

    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x818b3e4*/ RectTransformUtility();
        static /*0x818a144*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x818a29c*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x818a3e8*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x818a544*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint);
        static /*0x818a5b4*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x818a688*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x818a734*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x818ad10*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x818ab58*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x818ae0c*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x818aebc*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x818b17c*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x818b3d4*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x818a240*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, nint elementTransform, nint canvas, ref UnityEngine.Vector2 ret);
        static /*0x818a394*/ void PixelAdjustRect_Injected(nint rectTransform, nint canvas, ref UnityEngine.Rect ret);
        static /*0x818a4e8*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, nint rect, nint cam, ref UnityEngine.Vector4 offset);
    }

    enum RenderMode
    {
        ScreenSpaceOverlay = 0,
        ScreenSpaceCamera = 1,
        WorldSpace = 2,
    }

    enum StandaloneRenderResize
    {
        Enabled = 0,
        Disabled = 1,
    }

    enum AdditionalCanvasShaderChannels
    {
        None = 0,
        TexCoord1 = 1,
        TexCoord2 = 2,
        TexCoord3 = 4,
        Normal = 8,
        Tangent = 16,
    }

    class Canvas : UnityEngine.Behaviour
    {
        static /*0x0*/ UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases;
        static /*0x8*/ UnityEngine.Canvas.WillRenderCanvases willRenderCanvases;
        static /*0x10*/ System.Action<int> <externBeginRenderOverlays>k__BackingField;
        static /*0x18*/ System.Action<int, int> <externRenderOverlaysBefore>k__BackingField;
        static /*0x20*/ System.Action<int> <externEndRenderOverlays>k__BackingField;

        static /*0x818b458*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x818b510*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x818b5c8*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x818b684*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x818d238*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x818d280*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x818d2d0*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x818d318*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x818d368*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x818d3b0*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x818d400*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x818d904*/ UnityEngine.Material GetDefaultCanvasTextMaterial();
        static /*0x818d990*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x818da1c*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x818db6c*/ void ForceUpdateCanvases();
        static /*0x818db7c*/ void SendPreWillRenderCanvases();
        static /*0x818dbe0*/ void SendWillRenderCanvases();
        static /*0x818dc44*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x818dcb0*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x818dd24*/ void EndRenderExtraOverlays(int displayIndex);
        static /*0x818b7b8*/ UnityEngine.RenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x818b874*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.RenderMode value);
        static /*0x818b930*/ bool get_isRootCanvas_Injected(nint _unity_self);
        static /*0x818ba00*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x818babc*/ float get_scaleFactor_Injected(nint _unity_self);
        static /*0x818bb80*/ void set_scaleFactor_Injected(nint _unity_self, float value);
        static /*0x818bc44*/ float get_referencePixelsPerUnit_Injected(nint _unity_self);
        static /*0x818bd08*/ void set_referencePixelsPerUnit_Injected(nint _unity_self, float value);
        static /*0x818bdcc*/ bool get_overridePixelPerfect_Injected(nint _unity_self);
        static /*0x818be88*/ void set_overridePixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x818bf44*/ bool get_vertexColorAlwaysGammaSpace_Injected(nint _unity_self);
        static /*0x818c000*/ void set_vertexColorAlwaysGammaSpace_Injected(nint _unity_self, bool value);
        static /*0x818c0bc*/ bool get_pixelPerfect_Injected(nint _unity_self);
        static /*0x818c178*/ void set_pixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x818c234*/ float get_planeDistance_Injected(nint _unity_self);
        static /*0x818c2f8*/ void set_planeDistance_Injected(nint _unity_self, float value);
        static /*0x818c3bc*/ int get_renderOrder_Injected(nint _unity_self);
        static /*0x818c470*/ bool get_overrideSorting_Injected(nint _unity_self);
        static /*0x818c52c*/ void set_overrideSorting_Injected(nint _unity_self, bool value);
        static /*0x818c5e8*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x818c6a4*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x818c760*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x818c81c*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x818c8d8*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x818c994*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x818ca50*/ int get_cachedSortingLayerValue_Injected(nint _unity_self);
        static /*0x818cb04*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(nint _unity_self);
        static /*0x818cbc0*/ void set_additionalShaderChannels_Injected(nint _unity_self, UnityEngine.AdditionalCanvasShaderChannels value);
        static /*0x818cd00*/ void get_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x818cee0*/ void set_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x818cfb8*/ nint get_rootCanvas_Injected(nint _unity_self);
        static /*0x818d07c*/ void get_renderingDisplaySize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x818d138*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone_Injected(nint _unity_self);
        static /*0x818d1f4*/ void set_updateRectTransformForStandalone_Injected(nint _unity_self, UnityEngine.StandaloneRenderResize value);
        static /*0x818d4d0*/ nint get_worldCamera_Injected(nint _unity_self);
        static /*0x818d5c0*/ void set_worldCamera_Injected(nint _unity_self, nint value);
        static /*0x818d67c*/ float get_normalizedSortingGridSize_Injected(nint _unity_self);
        static /*0x818d740*/ void set_normalizedSortingGridSize_Injected(nint _unity_self, float value);
        static /*0x818d804*/ int get_sortingGridNormalizedSize_Injected(nint _unity_self);
        static /*0x818d8c0*/ void set_sortingGridNormalizedSize_Injected(nint _unity_self, int value);
        static /*0x818d968*/ nint GetDefaultCanvasTextMaterial_Injected();
        static /*0x818d9f4*/ nint GetDefaultCanvasMaterial_Injected();
        static /*0x818da80*/ nint GetETC1SupportedCanvasMaterial_Injected();
        static /*0x818db28*/ void UpdateCanvasRectTransform_Injected(nint _unity_self, bool alignWithCamera);
        /*0x818dd90*/ Canvas();
        /*0x818b740*/ UnityEngine.RenderMode get_renderMode();
        /*0x818b7f4*/ void set_renderMode(UnityEngine.RenderMode value);
        /*0x818b8b8*/ bool get_isRootCanvas();
        /*0x818b96c*/ UnityEngine.Rect get_pixelRect();
        /*0x818ba44*/ float get_scaleFactor();
        /*0x818baf8*/ void set_scaleFactor(float value);
        /*0x818bbcc*/ float get_referencePixelsPerUnit();
        /*0x818bc80*/ void set_referencePixelsPerUnit(float value);
        /*0x818bd54*/ bool get_overridePixelPerfect();
        /*0x818be08*/ void set_overridePixelPerfect(bool value);
        /*0x818becc*/ bool get_vertexColorAlwaysGammaSpace();
        /*0x818bf80*/ void set_vertexColorAlwaysGammaSpace(bool value);
        /*0x818c044*/ bool get_pixelPerfect();
        /*0x818c0f8*/ void set_pixelPerfect(bool value);
        /*0x818c1bc*/ float get_planeDistance();
        /*0x818c270*/ void set_planeDistance(float value);
        /*0x818c344*/ int get_renderOrder();
        /*0x818c3f8*/ bool get_overrideSorting();
        /*0x818c4ac*/ void set_overrideSorting(bool value);
        /*0x818c570*/ int get_sortingOrder();
        /*0x818c624*/ void set_sortingOrder(int value);
        /*0x818c6e8*/ int get_targetDisplay();
        /*0x818c79c*/ void set_targetDisplay(int value);
        /*0x818c860*/ int get_sortingLayerID();
        /*0x818c914*/ void set_sortingLayerID(int value);
        /*0x818c9d8*/ int get_cachedSortingLayerValue();
        /*0x818ca8c*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x818cb40*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x818cc04*/ string get_sortingLayerName();
        /*0x818cd44*/ void set_sortingLayerName(string value);
        /*0x818cf24*/ UnityEngine.Canvas get_rootCanvas();
        /*0x818cff4*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x818d0c0*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone();
        /*0x818d174*/ void set_updateRectTransformForStandalone(UnityEngine.StandaloneRenderResize value);
        /*0x818d43c*/ UnityEngine.Camera get_worldCamera();
        /*0x818d50c*/ void set_worldCamera(UnityEngine.Camera value);
        /*0x818d604*/ float get_normalizedSortingGridSize();
        /*0x818d6b8*/ void set_normalizedSortingGridSize(float value);
        /*0x818d78c*/ int get_sortingGridNormalizedSize();
        /*0x818d840*/ void set_sortingGridNormalizedSize(int value);
        /*0x818daa8*/ void UpdateCanvasRectTransform(bool alignWithCamera);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x818dd98*/ WillRenderCanvases(object object, nint method);
            /*0x818de34*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x818de48*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x818de84*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x818dec0*/ void AddMarker(string name, UnityEngine.Object obj);
        static /*0x818e05c*/ void AddMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, nint obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }
}
