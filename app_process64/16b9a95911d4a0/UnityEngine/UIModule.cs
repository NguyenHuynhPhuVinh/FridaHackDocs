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
        static /*0x40bd37c*/ float get_alpha_Injected(nint _unity_self);
        static /*0x40bd440*/ void set_alpha_Injected(nint _unity_self, float value);
        static /*0x40bd504*/ bool get_interactable_Injected(nint _unity_self);
        static /*0x40bd5c0*/ void set_interactable_Injected(nint _unity_self, bool value);
        static /*0x40bd67c*/ bool get_blocksRaycasts_Injected(nint _unity_self);
        static /*0x40bd738*/ void set_blocksRaycasts_Injected(nint _unity_self, bool value);
        static /*0x40bd7f4*/ bool get_ignoreParentGroups_Injected(nint _unity_self);
        static /*0x40bd8b0*/ void set_ignoreParentGroups_Injected(nint _unity_self, bool value);
        /*0x40bd8f8*/ CanvasGroup();
        /*0x40bd304*/ float get_alpha();
        /*0x40bd3b8*/ void set_alpha(float value);
        /*0x40bd48c*/ bool get_interactable();
        /*0x40bd540*/ void set_interactable(bool value);
        /*0x40bd604*/ bool get_blocksRaycasts();
        /*0x40bd6b8*/ void set_blocksRaycasts(bool value);
        /*0x40bd77c*/ bool get_ignoreParentGroups();
        /*0x40bd830*/ void set_ignoreParentGroups(bool value);
        /*0x40bd8f4*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x40bf1f8*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x40bf2e0*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x40bf490*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x40bf598*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x40bf6d0*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x40bf7d4*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x40bf44c*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x40bf3b0*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x40bf634*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        static /*0x40bd978*/ bool get_hasPopInstruction_Injected(nint _unity_self);
        static /*0x40bda34*/ void set_hasPopInstruction_Injected(nint _unity_self, bool value);
        static /*0x40bdaf0*/ int get_materialCount_Injected(nint _unity_self);
        static /*0x40bdbac*/ void set_materialCount_Injected(nint _unity_self, int value);
        static /*0x40bdc68*/ int get_popMaterialCount_Injected(nint _unity_self);
        static /*0x40bdd24*/ void set_popMaterialCount_Injected(nint _unity_self, int value);
        static /*0x40bdde0*/ int get_absoluteDepth_Injected(nint _unity_self);
        static /*0x40bde94*/ bool get_hasMoved_Injected(nint _unity_self);
        static /*0x40bdf48*/ bool get_cullTransparentMesh_Injected(nint _unity_self);
        static /*0x40be004*/ void set_cullTransparentMesh_Injected(nint _unity_self, bool value);
        static /*0x40be0c0*/ bool get_hasRectClipping_Injected(nint _unity_self);
        static /*0x40be174*/ int get_relativeDepth_Injected(nint _unity_self);
        static /*0x40be228*/ bool get_cull_Injected(nint _unity_self);
        static /*0x40be2e4*/ void set_cull_Injected(nint _unity_self, bool value);
        static /*0x40be3c8*/ void SetColor_Injected(nint _unity_self, ref UnityEngine.Color color);
        static /*0x40be4a0*/ void GetColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x40be574*/ void EnableRectClipping_Injected(nint _unity_self, ref UnityEngine.Rect rect);
        static /*0x40be640*/ void get_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x40be708*/ void set_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x40be7c4*/ void DisableRectClipping_Injected(nint _unity_self);
        static /*0x40be8bc*/ void SetMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x40be9b4*/ nint GetMaterial_Injected(nint _unity_self, int index);
        static /*0x40beab4*/ void SetPopMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x40bebac*/ nint GetPopMaterial_Injected(nint _unity_self, int index);
        static /*0x40beca4*/ void SetTexture_Injected(nint _unity_self, nint texture);
        static /*0x40bed9c*/ void SetAlphaTexture_Injected(nint _unity_self, nint texture);
        static /*0x40bee94*/ void SetMesh_Injected(nint _unity_self, nint mesh);
        static /*0x40bef6c*/ nint GetMesh_Injected(nint _unity_self);
        static /*0x40bf020*/ void Clear_Injected(nint _unity_self);
        static /*0x40bf110*/ float GetInheritedAlpha_Injected(nint _unity_self);
        /*0x40bfea8*/ CanvasRenderer();
        /*0x40bd900*/ bool get_hasPopInstruction();
        /*0x40bd9b4*/ void set_hasPopInstruction(bool value);
        /*0x40bda78*/ int get_materialCount();
        /*0x40bdb2c*/ void set_materialCount(int value);
        /*0x40bdbf0*/ int get_popMaterialCount();
        /*0x40bdca4*/ void set_popMaterialCount(int value);
        /*0x40bdd68*/ int get_absoluteDepth();
        /*0x40bde1c*/ bool get_hasMoved();
        /*0x40bded0*/ bool get_cullTransparentMesh();
        /*0x40bdf84*/ void set_cullTransparentMesh(bool value);
        /*0x40be048*/ bool get_hasRectClipping();
        /*0x40be0fc*/ int get_relativeDepth();
        /*0x40be1b0*/ bool get_cull();
        /*0x40be264*/ void set_cull(bool value);
        /*0x40be328*/ bool get_isMask();
        /*0x40be330*/ void set_isMask(bool value);
        /*0x40be338*/ void SetColor(UnityEngine.Color color);
        /*0x40be40c*/ UnityEngine.Color GetColor();
        /*0x40be4e4*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x40be5b8*/ UnityEngine.Vector2 get_clippingSoftness();
        /*0x40be684*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x40be74c*/ void DisableRectClipping();
        /*0x40be800*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x40be910*/ UnityEngine.Material GetMaterial(int index);
        /*0x40be9f8*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x40beb08*/ UnityEngine.Material GetPopMaterial(int index);
        /*0x40bebf0*/ void SetTexture(UnityEngine.Texture texture);
        /*0x40bece8*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x40bede0*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x40beed8*/ UnityEngine.Mesh GetMesh();
        /*0x40befa8*/ void Clear();
        /*0x40bf05c*/ float GetAlpha();
        /*0x40bf070*/ void SetAlpha(float alpha);
        /*0x40bf098*/ float GetInheritedAlpha();
        /*0x40bf14c*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x40bf1f0*/ UnityEngine.Material GetMaterial();
        /*0x40bf870*/ void SetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x40bf8e0*/ void SetVertices(UnityEngine.UIVertex[] vertices, int size);
    }

    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x40c1488*/ RectTransformUtility();
        static /*0x40bfeb0*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x40c0008*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x40c0154*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x40c02b0*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x40c0384*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x40c0430*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x40c0a1c*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x40c0848*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x40c0b18*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x40c0bc8*/ UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child);
        static /*0x40c0ea0*/ UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans);
        static /*0x40c0f28*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x40c121c*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x40c1478*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x40bffac*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, nint elementTransform, nint canvas, ref UnityEngine.Vector2 ret);
        static /*0x40c0100*/ void PixelAdjustRect_Injected(nint rectTransform, nint canvas, ref UnityEngine.Rect ret);
        static /*0x40c0254*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, nint rect, nint cam, ref UnityEngine.Vector4 offset);
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

        static /*0x40c14fc*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x40c15b4*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x40c166c*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x40c1728*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x40c330c*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x40c3354*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x40c33a4*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x40c33ec*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x40c343c*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x40c3484*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x40c34d4*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x40c39d8*/ UnityEngine.Material GetDefaultCanvasTextMaterial();
        static /*0x40c3a60*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x40c3ae8*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x40c3c34*/ void ForceUpdateCanvases();
        static /*0x40c3c44*/ void SendPreWillRenderCanvases();
        static /*0x40c3ca8*/ void SendWillRenderCanvases();
        static /*0x40c3d0c*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x40c3d74*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x40c3dec*/ void EndRenderExtraOverlays(int displayIndex);
        static /*0x40c185c*/ UnityEngine.RenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x40c1918*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.RenderMode value);
        static /*0x40c19d4*/ bool get_isRootCanvas_Injected(nint _unity_self);
        static /*0x40c1aa4*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x40c1b60*/ float get_scaleFactor_Injected(nint _unity_self);
        static /*0x40c1c24*/ void set_scaleFactor_Injected(nint _unity_self, float value);
        static /*0x40c1ce8*/ float get_referencePixelsPerUnit_Injected(nint _unity_self);
        static /*0x40c1dac*/ void set_referencePixelsPerUnit_Injected(nint _unity_self, float value);
        static /*0x40c1e70*/ bool get_overridePixelPerfect_Injected(nint _unity_self);
        static /*0x40c1f2c*/ void set_overridePixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x40c1fe8*/ bool get_vertexColorAlwaysGammaSpace_Injected(nint _unity_self);
        static /*0x40c20a4*/ void set_vertexColorAlwaysGammaSpace_Injected(nint _unity_self, bool value);
        static /*0x40c2160*/ bool get_pixelPerfect_Injected(nint _unity_self);
        static /*0x40c221c*/ void set_pixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x40c22d8*/ float get_planeDistance_Injected(nint _unity_self);
        static /*0x40c239c*/ void set_planeDistance_Injected(nint _unity_self, float value);
        static /*0x40c2460*/ int get_renderOrder_Injected(nint _unity_self);
        static /*0x40c2514*/ bool get_overrideSorting_Injected(nint _unity_self);
        static /*0x40c25d0*/ void set_overrideSorting_Injected(nint _unity_self, bool value);
        static /*0x40c268c*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x40c2748*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x40c2804*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x40c28c0*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x40c297c*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x40c2a38*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x40c2af4*/ int get_cachedSortingLayerValue_Injected(nint _unity_self);
        static /*0x40c2ba8*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(nint _unity_self);
        static /*0x40c2c64*/ void set_additionalShaderChannels_Injected(nint _unity_self, UnityEngine.AdditionalCanvasShaderChannels value);
        static /*0x40c2dd4*/ void get_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x40c2fb4*/ void set_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x40c308c*/ nint get_rootCanvas_Injected(nint _unity_self);
        static /*0x40c3150*/ void get_renderingDisplaySize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x40c320c*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone_Injected(nint _unity_self);
        static /*0x40c32c8*/ void set_updateRectTransformForStandalone_Injected(nint _unity_self, UnityEngine.StandaloneRenderResize value);
        static /*0x40c35a4*/ nint get_worldCamera_Injected(nint _unity_self);
        static /*0x40c3694*/ void set_worldCamera_Injected(nint _unity_self, nint value);
        static /*0x40c3750*/ float get_normalizedSortingGridSize_Injected(nint _unity_self);
        static /*0x40c3814*/ void set_normalizedSortingGridSize_Injected(nint _unity_self, float value);
        static /*0x40c38d8*/ int get_sortingGridNormalizedSize_Injected(nint _unity_self);
        static /*0x40c3994*/ void set_sortingGridNormalizedSize_Injected(nint _unity_self, int value);
        static /*0x40c3a38*/ nint GetDefaultCanvasTextMaterial_Injected();
        static /*0x40c3ac0*/ nint GetDefaultCanvasMaterial_Injected();
        static /*0x40c3b48*/ nint GetETC1SupportedCanvasMaterial_Injected();
        static /*0x40c3bf0*/ void UpdateCanvasRectTransform_Injected(nint _unity_self, bool alignWithCamera);
        /*0x40c3e54*/ Canvas();
        /*0x40c17e4*/ UnityEngine.RenderMode get_renderMode();
        /*0x40c1898*/ void set_renderMode(UnityEngine.RenderMode value);
        /*0x40c195c*/ bool get_isRootCanvas();
        /*0x40c1a10*/ UnityEngine.Rect get_pixelRect();
        /*0x40c1ae8*/ float get_scaleFactor();
        /*0x40c1b9c*/ void set_scaleFactor(float value);
        /*0x40c1c70*/ float get_referencePixelsPerUnit();
        /*0x40c1d24*/ void set_referencePixelsPerUnit(float value);
        /*0x40c1df8*/ bool get_overridePixelPerfect();
        /*0x40c1eac*/ void set_overridePixelPerfect(bool value);
        /*0x40c1f70*/ bool get_vertexColorAlwaysGammaSpace();
        /*0x40c2024*/ void set_vertexColorAlwaysGammaSpace(bool value);
        /*0x40c20e8*/ bool get_pixelPerfect();
        /*0x40c219c*/ void set_pixelPerfect(bool value);
        /*0x40c2260*/ float get_planeDistance();
        /*0x40c2314*/ void set_planeDistance(float value);
        /*0x40c23e8*/ int get_renderOrder();
        /*0x40c249c*/ bool get_overrideSorting();
        /*0x40c2550*/ void set_overrideSorting(bool value);
        /*0x40c2614*/ int get_sortingOrder();
        /*0x40c26c8*/ void set_sortingOrder(int value);
        /*0x40c278c*/ int get_targetDisplay();
        /*0x40c2840*/ void set_targetDisplay(int value);
        /*0x40c2904*/ int get_sortingLayerID();
        /*0x40c29b8*/ void set_sortingLayerID(int value);
        /*0x40c2a7c*/ int get_cachedSortingLayerValue();
        /*0x40c2b30*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x40c2be4*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x40c2ca8*/ string get_sortingLayerName();
        /*0x40c2e18*/ void set_sortingLayerName(string value);
        /*0x40c2ff8*/ UnityEngine.Canvas get_rootCanvas();
        /*0x40c30c8*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x40c3194*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone();
        /*0x40c3248*/ void set_updateRectTransformForStandalone(UnityEngine.StandaloneRenderResize value);
        /*0x40c3510*/ UnityEngine.Camera get_worldCamera();
        /*0x40c35e0*/ void set_worldCamera(UnityEngine.Camera value);
        /*0x40c36d8*/ float get_normalizedSortingGridSize();
        /*0x40c378c*/ void set_normalizedSortingGridSize(float value);
        /*0x40c3860*/ int get_sortingGridNormalizedSize();
        /*0x40c3914*/ void set_sortingGridNormalizedSize(int value);
        /*0x40c3b70*/ void UpdateCanvasRectTransform(bool alignWithCamera);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x40c3e5c*/ WillRenderCanvases(object object, nint method);
            /*0x40c3ef8*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x40c3f0c*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x40c3f48*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x40c3f84*/ void AddMarker(string name, UnityEngine.Object obj);
        static /*0x40c4120*/ void AddMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, nint obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }
}
