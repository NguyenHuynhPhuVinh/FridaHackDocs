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
        static /*0x819e690*/ float get_alpha_Injected(nint _unity_self);
        static /*0x819e754*/ void set_alpha_Injected(nint _unity_self, float value);
        static /*0x819e818*/ bool get_interactable_Injected(nint _unity_self);
        static /*0x819e8d4*/ void set_interactable_Injected(nint _unity_self, bool value);
        static /*0x819e990*/ bool get_blocksRaycasts_Injected(nint _unity_self);
        static /*0x819ea4c*/ void set_blocksRaycasts_Injected(nint _unity_self, bool value);
        static /*0x819eb08*/ bool get_ignoreParentGroups_Injected(nint _unity_self);
        static /*0x819ebc4*/ void set_ignoreParentGroups_Injected(nint _unity_self, bool value);
        /*0x819ec0c*/ CanvasGroup();
        /*0x819e618*/ float get_alpha();
        /*0x819e6cc*/ void set_alpha(float value);
        /*0x819e7a0*/ bool get_interactable();
        /*0x819e854*/ void set_interactable(bool value);
        /*0x819e918*/ bool get_blocksRaycasts();
        /*0x819e9cc*/ void set_blocksRaycasts(bool value);
        /*0x819ea90*/ bool get_ignoreParentGroups();
        /*0x819eb44*/ void set_ignoreParentGroups(bool value);
        /*0x819ec08*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x81a0510*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81a05f8*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81a07a8*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81a08b0*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x81a09e8*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x81a0aec*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x81a0764*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x81a06c8*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x81a094c*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        static /*0x819ec8c*/ bool get_hasPopInstruction_Injected(nint _unity_self);
        static /*0x819ed48*/ void set_hasPopInstruction_Injected(nint _unity_self, bool value);
        static /*0x819ee04*/ int get_materialCount_Injected(nint _unity_self);
        static /*0x819eec0*/ void set_materialCount_Injected(nint _unity_self, int value);
        static /*0x819ef7c*/ int get_popMaterialCount_Injected(nint _unity_self);
        static /*0x819f038*/ void set_popMaterialCount_Injected(nint _unity_self, int value);
        static /*0x819f0f4*/ int get_absoluteDepth_Injected(nint _unity_self);
        static /*0x819f1a8*/ bool get_hasMoved_Injected(nint _unity_self);
        static /*0x819f25c*/ bool get_cullTransparentMesh_Injected(nint _unity_self);
        static /*0x819f318*/ void set_cullTransparentMesh_Injected(nint _unity_self, bool value);
        static /*0x819f3d4*/ bool get_hasRectClipping_Injected(nint _unity_self);
        static /*0x819f488*/ int get_relativeDepth_Injected(nint _unity_self);
        static /*0x819f53c*/ bool get_cull_Injected(nint _unity_self);
        static /*0x819f5f8*/ void set_cull_Injected(nint _unity_self, bool value);
        static /*0x819f6e0*/ void SetColor_Injected(nint _unity_self, ref UnityEngine.Color color);
        static /*0x819f7b8*/ void GetColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x819f88c*/ void EnableRectClipping_Injected(nint _unity_self, ref UnityEngine.Rect rect);
        static /*0x819f958*/ void get_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x819fa20*/ void set_clippingSoftness_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x819fadc*/ void DisableRectClipping_Injected(nint _unity_self);
        static /*0x819fbd4*/ void SetMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x819fccc*/ nint GetMaterial_Injected(nint _unity_self, int index);
        static /*0x819fdcc*/ void SetPopMaterial_Injected(nint _unity_self, nint material, int index);
        static /*0x819fec4*/ nint GetPopMaterial_Injected(nint _unity_self, int index);
        static /*0x819ffbc*/ void SetTexture_Injected(nint _unity_self, nint texture);
        static /*0x81a00b4*/ void SetAlphaTexture_Injected(nint _unity_self, nint texture);
        static /*0x81a01ac*/ void SetMesh_Injected(nint _unity_self, nint mesh);
        static /*0x81a0284*/ nint GetMesh_Injected(nint _unity_self);
        static /*0x81a0338*/ void Clear_Injected(nint _unity_self);
        static /*0x81a0428*/ float GetInheritedAlpha_Injected(nint _unity_self);
        /*0x81a156c*/ CanvasRenderer();
        /*0x819ec14*/ bool get_hasPopInstruction();
        /*0x819ecc8*/ void set_hasPopInstruction(bool value);
        /*0x819ed8c*/ int get_materialCount();
        /*0x819ee40*/ void set_materialCount(int value);
        /*0x819ef04*/ int get_popMaterialCount();
        /*0x819efb8*/ void set_popMaterialCount(int value);
        /*0x819f07c*/ int get_absoluteDepth();
        /*0x819f130*/ bool get_hasMoved();
        /*0x819f1e4*/ bool get_cullTransparentMesh();
        /*0x819f298*/ void set_cullTransparentMesh(bool value);
        /*0x819f35c*/ bool get_hasRectClipping();
        /*0x819f410*/ int get_relativeDepth();
        /*0x819f4c4*/ bool get_cull();
        /*0x819f578*/ void set_cull(bool value);
        /*0x819f63c*/ bool get_isMask();
        /*0x819f644*/ void set_isMask(bool value);
        /*0x819f650*/ void SetColor(UnityEngine.Color color);
        /*0x819f724*/ UnityEngine.Color GetColor();
        /*0x819f7fc*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x819f8d0*/ UnityEngine.Vector2 get_clippingSoftness();
        /*0x819f99c*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x819fa64*/ void DisableRectClipping();
        /*0x819fb18*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x819fc28*/ UnityEngine.Material GetMaterial(int index);
        /*0x819fd10*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x819fe20*/ UnityEngine.Material GetPopMaterial(int index);
        /*0x819ff08*/ void SetTexture(UnityEngine.Texture texture);
        /*0x81a0000*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x81a00f8*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x81a01f0*/ UnityEngine.Mesh GetMesh();
        /*0x81a02c0*/ void Clear();
        /*0x81a0374*/ float GetAlpha();
        /*0x81a0388*/ void SetAlpha(float alpha);
        /*0x81a03b0*/ float GetInheritedAlpha();
        /*0x81a0464*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x81a0508*/ UnityEngine.Material GetMaterial();
        /*0x81a0b88*/ void SetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        /*0x81a0bf8*/ void SetVertices(UnityEngine.UIVertex[] vertices, int size);
    }

    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x81a2814*/ RectTransformUtility();
        static /*0x81a1574*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x81a16cc*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x81a1818*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x81a1974*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint);
        static /*0x81a19e4*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x81a1ab8*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x81a1b64*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x81a2140*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x81a1f88*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x81a223c*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x81a22ec*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x81a25ac*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x81a2804*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x81a1670*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, nint elementTransform, nint canvas, ref UnityEngine.Vector2 ret);
        static /*0x81a17c4*/ void PixelAdjustRect_Injected(nint rectTransform, nint canvas, ref UnityEngine.Rect ret);
        static /*0x81a1918*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, nint rect, nint cam, ref UnityEngine.Vector4 offset);
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

        static /*0x81a2888*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x81a2940*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x81a29f8*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x81a2ab4*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x81a4668*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x81a46b0*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x81a4700*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x81a4748*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x81a4798*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x81a47e0*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x81a4830*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x81a4d34*/ UnityEngine.Material GetDefaultCanvasTextMaterial();
        static /*0x81a4dc0*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x81a4e4c*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x81a4f9c*/ void ForceUpdateCanvases();
        static /*0x81a4fac*/ void SendPreWillRenderCanvases();
        static /*0x81a5010*/ void SendWillRenderCanvases();
        static /*0x81a5074*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x81a50e0*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x81a5154*/ void EndRenderExtraOverlays(int displayIndex);
        static /*0x81a2be8*/ UnityEngine.RenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x81a2ca4*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.RenderMode value);
        static /*0x81a2d60*/ bool get_isRootCanvas_Injected(nint _unity_self);
        static /*0x81a2e30*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x81a2eec*/ float get_scaleFactor_Injected(nint _unity_self);
        static /*0x81a2fb0*/ void set_scaleFactor_Injected(nint _unity_self, float value);
        static /*0x81a3074*/ float get_referencePixelsPerUnit_Injected(nint _unity_self);
        static /*0x81a3138*/ void set_referencePixelsPerUnit_Injected(nint _unity_self, float value);
        static /*0x81a31fc*/ bool get_overridePixelPerfect_Injected(nint _unity_self);
        static /*0x81a32b8*/ void set_overridePixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x81a3374*/ bool get_vertexColorAlwaysGammaSpace_Injected(nint _unity_self);
        static /*0x81a3430*/ void set_vertexColorAlwaysGammaSpace_Injected(nint _unity_self, bool value);
        static /*0x81a34ec*/ bool get_pixelPerfect_Injected(nint _unity_self);
        static /*0x81a35a8*/ void set_pixelPerfect_Injected(nint _unity_self, bool value);
        static /*0x81a3664*/ float get_planeDistance_Injected(nint _unity_self);
        static /*0x81a3728*/ void set_planeDistance_Injected(nint _unity_self, float value);
        static /*0x81a37ec*/ int get_renderOrder_Injected(nint _unity_self);
        static /*0x81a38a0*/ bool get_overrideSorting_Injected(nint _unity_self);
        static /*0x81a395c*/ void set_overrideSorting_Injected(nint _unity_self, bool value);
        static /*0x81a3a18*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x81a3ad4*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x81a3b90*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x81a3c4c*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x81a3d08*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x81a3dc4*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x81a3e80*/ int get_cachedSortingLayerValue_Injected(nint _unity_self);
        static /*0x81a3f34*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(nint _unity_self);
        static /*0x81a3ff0*/ void set_additionalShaderChannels_Injected(nint _unity_self, UnityEngine.AdditionalCanvasShaderChannels value);
        static /*0x81a4130*/ void get_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x81a4310*/ void set_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x81a43e8*/ nint get_rootCanvas_Injected(nint _unity_self);
        static /*0x81a44ac*/ void get_renderingDisplaySize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x81a4568*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone_Injected(nint _unity_self);
        static /*0x81a4624*/ void set_updateRectTransformForStandalone_Injected(nint _unity_self, UnityEngine.StandaloneRenderResize value);
        static /*0x81a4900*/ nint get_worldCamera_Injected(nint _unity_self);
        static /*0x81a49f0*/ void set_worldCamera_Injected(nint _unity_self, nint value);
        static /*0x81a4aac*/ float get_normalizedSortingGridSize_Injected(nint _unity_self);
        static /*0x81a4b70*/ void set_normalizedSortingGridSize_Injected(nint _unity_self, float value);
        static /*0x81a4c34*/ int get_sortingGridNormalizedSize_Injected(nint _unity_self);
        static /*0x81a4cf0*/ void set_sortingGridNormalizedSize_Injected(nint _unity_self, int value);
        static /*0x81a4d98*/ nint GetDefaultCanvasTextMaterial_Injected();
        static /*0x81a4e24*/ nint GetDefaultCanvasMaterial_Injected();
        static /*0x81a4eb0*/ nint GetETC1SupportedCanvasMaterial_Injected();
        static /*0x81a4f58*/ void UpdateCanvasRectTransform_Injected(nint _unity_self, bool alignWithCamera);
        /*0x81a51c0*/ Canvas();
        /*0x81a2b70*/ UnityEngine.RenderMode get_renderMode();
        /*0x81a2c24*/ void set_renderMode(UnityEngine.RenderMode value);
        /*0x81a2ce8*/ bool get_isRootCanvas();
        /*0x81a2d9c*/ UnityEngine.Rect get_pixelRect();
        /*0x81a2e74*/ float get_scaleFactor();
        /*0x81a2f28*/ void set_scaleFactor(float value);
        /*0x81a2ffc*/ float get_referencePixelsPerUnit();
        /*0x81a30b0*/ void set_referencePixelsPerUnit(float value);
        /*0x81a3184*/ bool get_overridePixelPerfect();
        /*0x81a3238*/ void set_overridePixelPerfect(bool value);
        /*0x81a32fc*/ bool get_vertexColorAlwaysGammaSpace();
        /*0x81a33b0*/ void set_vertexColorAlwaysGammaSpace(bool value);
        /*0x81a3474*/ bool get_pixelPerfect();
        /*0x81a3528*/ void set_pixelPerfect(bool value);
        /*0x81a35ec*/ float get_planeDistance();
        /*0x81a36a0*/ void set_planeDistance(float value);
        /*0x81a3774*/ int get_renderOrder();
        /*0x81a3828*/ bool get_overrideSorting();
        /*0x81a38dc*/ void set_overrideSorting(bool value);
        /*0x81a39a0*/ int get_sortingOrder();
        /*0x81a3a54*/ void set_sortingOrder(int value);
        /*0x81a3b18*/ int get_targetDisplay();
        /*0x81a3bcc*/ void set_targetDisplay(int value);
        /*0x81a3c90*/ int get_sortingLayerID();
        /*0x81a3d44*/ void set_sortingLayerID(int value);
        /*0x81a3e08*/ int get_cachedSortingLayerValue();
        /*0x81a3ebc*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x81a3f70*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x81a4034*/ string get_sortingLayerName();
        /*0x81a4174*/ void set_sortingLayerName(string value);
        /*0x81a4354*/ UnityEngine.Canvas get_rootCanvas();
        /*0x81a4424*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x81a44f0*/ UnityEngine.StandaloneRenderResize get_updateRectTransformForStandalone();
        /*0x81a45a4*/ void set_updateRectTransformForStandalone(UnityEngine.StandaloneRenderResize value);
        /*0x81a486c*/ UnityEngine.Camera get_worldCamera();
        /*0x81a493c*/ void set_worldCamera(UnityEngine.Camera value);
        /*0x81a4a34*/ float get_normalizedSortingGridSize();
        /*0x81a4ae8*/ void set_normalizedSortingGridSize(float value);
        /*0x81a4bbc*/ int get_sortingGridNormalizedSize();
        /*0x81a4c70*/ void set_sortingGridNormalizedSize(int value);
        /*0x81a4ed8*/ void UpdateCanvasRectTransform(bool alignWithCamera);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x81a51c8*/ WillRenderCanvases(object object, nint method);
            /*0x81a5264*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x81a5278*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x81a52b4*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x81a52f0*/ void AddMarker(string name, UnityEngine.Object obj);
        static /*0x81a548c*/ void AddMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, nint obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }
}
