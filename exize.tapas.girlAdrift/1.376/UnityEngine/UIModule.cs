class <Module>
{
}

namespace UnityEngine
{
    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x139e960*/ RectTransformUtility();
        static /*0x139d9f8*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x139daf8*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x139dbec*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x139dcf0*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x139ddc4*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x139de70*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x139e28c*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x139e15c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x139e38c*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x139e43c*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x139e700*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x139e950*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x139da9c*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, ref UnityEngine.Vector2 ret);
        static /*0x139db98*/ void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, ref UnityEngine.Rect ret);
        static /*0x139dc94*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, ref UnityEngine.Vector4 offset);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x139f238*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x139f3e8*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x139f520*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x139f3a4*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x139f308*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x139f484*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        /*0x139e9c8*/ void set_hasPopInstruction(bool value);
        /*0x139ea0c*/ int get_materialCount();
        /*0x139ea48*/ void set_materialCount(int value);
        /*0x139ea8c*/ void set_popMaterialCount(int value);
        /*0x139ead0*/ int get_absoluteDepth();
        /*0x139eb0c*/ bool get_hasMoved();
        /*0x139eb48*/ bool get_cullTransparentMesh();
        /*0x139eb84*/ void set_cullTransparentMesh(bool value);
        /*0x139ebc8*/ bool get_cull();
        /*0x139ec04*/ void set_cull(bool value);
        /*0x139ec48*/ void SetColor(UnityEngine.Color color);
        /*0x139ece0*/ UnityEngine.Color GetColor();
        /*0x139ed7c*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x139ee14*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x139eea0*/ void DisableRectClipping();
        /*0x139eedc*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x139ef30*/ UnityEngine.Material GetMaterial(int index);
        /*0x139ef74*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x139efc8*/ void SetTexture(UnityEngine.Texture texture);
        /*0x139f00c*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x139f050*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x139f094*/ void Clear();
        /*0x139f0d0*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x139f1f8*/ UnityEngine.Material GetMaterial();
        /*0x139ec9c*/ void SetColor_Injected(ref UnityEngine.Color color);
        /*0x139ed38*/ void GetColor_Injected(ref UnityEngine.Color ret);
        /*0x139edd0*/ void EnableRectClipping_Injected(ref UnityEngine.Rect rect);
        /*0x139ee5c*/ void set_clippingSoftness_Injected(ref UnityEngine.Vector2 value);
    }

    enum RenderMode
    {
        ScreenSpaceOverlay = 0,
        ScreenSpaceCamera = 1,
        WorldSpace = 2,
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

        static /*0x139f5bc*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x139f674*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x139f72c*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x139f7e8*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x139fdac*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x139fdf4*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x139fe40*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x139fe88*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x139fed4*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x139ff1c*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x139ff68*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x139ffe0*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x13a0008*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x13a0030*/ void ForceUpdateCanvases();
        static /*0x13a0040*/ void SendPreWillRenderCanvases();
        static /*0x13a00a4*/ void SendWillRenderCanvases();
        static /*0x13a0108*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x13a0174*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x13a01e8*/ void EndRenderExtraOverlays(int displayIndex);
        /*0x13a0254*/ Canvas();
        /*0x139f8a4*/ UnityEngine.RenderMode get_renderMode();
        /*0x139f8e0*/ bool get_isRootCanvas();
        /*0x139f91c*/ float get_scaleFactor();
        /*0x139f958*/ void set_scaleFactor(float value);
        /*0x139f9a4*/ float get_referencePixelsPerUnit();
        /*0x139f9e0*/ void set_referencePixelsPerUnit(float value);
        /*0x139fa2c*/ bool get_pixelPerfect();
        /*0x139fa68*/ int get_renderOrder();
        /*0x139faa4*/ bool get_overrideSorting();
        /*0x139fae0*/ void set_overrideSorting(bool value);
        /*0x139fb24*/ int get_sortingOrder();
        /*0x139fb60*/ void set_sortingOrder(int value);
        /*0x139fba4*/ int get_targetDisplay();
        /*0x139fbe0*/ int get_sortingLayerID();
        /*0x139fc1c*/ void set_sortingLayerID(int value);
        /*0x139fc60*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x139fc9c*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x139fce0*/ UnityEngine.Canvas get_rootCanvas();
        /*0x139fd1c*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x139ffa4*/ UnityEngine.Camera get_worldCamera();
        /*0x139fd68*/ void get_renderingDisplaySize_Injected(ref UnityEngine.Vector2 ret);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x13a025c*/ WillRenderCanvases(object object, nint method);
            /*0x13a0318*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x13a032c*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x13a0368*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x13a03a4*/ void AddMarker(string name, UnityEngine.Object obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }

    interface ICanvasRaycastFilter
    {
        bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasGroup : UnityEngine.Behaviour, UnityEngine.ICanvasRaycastFilter
    {
        /*0x13a03e8*/ float get_alpha();
        /*0x13a0424*/ void set_alpha(float value);
        /*0x13a0470*/ bool get_interactable();
        /*0x13a04ac*/ void set_interactable(bool value);
        /*0x13a04f0*/ bool get_blocksRaycasts();
        /*0x13a052c*/ void set_blocksRaycasts(bool value);
        /*0x13a0570*/ bool get_ignoreParentGroups();
        /*0x13a05ac*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }
}
