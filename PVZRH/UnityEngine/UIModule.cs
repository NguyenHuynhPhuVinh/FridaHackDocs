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
        /*0x15b84e0*/ CanvasGroup();
        /*0x1826770*/ float get_alpha();
        /*0x1826830*/ void set_alpha(float value);
        /*0x18267f0*/ bool get_interactable();
        /*0x1826730*/ bool get_blocksRaycasts();
        /*0x18267b0*/ bool get_ignoreParentGroups();
        /*0x1826880*/ void set_ignoreParentGroups(bool value);
        /*0x1826730*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x1826fb0*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x1826980*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x18268d0*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x1826f60*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x18268d0*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x1826980*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        /*0x15b84e0*/ CanvasRenderer();
        /*0x18272f0*/ void set_hasPopInstruction(bool value);
        /*0x1827180*/ int get_materialCount();
        /*0x1827340*/ void set_materialCount(int value);
        /*0x1827380*/ void set_popMaterialCount(int value);
        /*0x1827080*/ int get_absoluteDepth();
        /*0x1827140*/ bool get_hasMoved();
        /*0x18270c0*/ bool get_cullTransparentMesh();
        /*0x1827250*/ void set_cullTransparentMesh(bool value);
        /*0x1827100*/ bool get_cull();
        /*0x18272a0*/ void set_cull(bool value);
        /*0x1826c90*/ void SetColor(UnityEngine.Color color);
        /*0x1826b20*/ UnityEngine.Color GetColor();
        /*0x1826a80*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x1827210*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x18269f0*/ void DisableRectClipping();
        /*0x1826e00*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x1826bb0*/ UnityEngine.Material GetMaterial(int index);
        /*0x1826eb0*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x1826f10*/ void SetTexture(UnityEngine.Texture texture);
        /*0x1826bf0*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x1826e60*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x1826940*/ void Clear();
        /*0x1826ce0*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x1826b70*/ UnityEngine.Material GetMaterial();
        /*0x1826c40*/ void SetColor_Injected(ref UnityEngine.Color color);
        /*0x1826ad0*/ void GetColor_Injected(ref UnityEngine.Color ret);
        /*0x1826a30*/ void EnableRectClipping_Injected(ref UnityEngine.Rect rect);
        /*0x18271c0*/ void set_clippingSoftness_Injected(ref UnityEngine.Vector2 value);
    }

    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x1829510*/ RectTransformUtility();
        static /*0x1828880*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x1828970*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x1828a70*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x1828be0*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x1828b00*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x1828fc0*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x1828d20*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x1828e40*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x1829450*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x18283c0*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x1828160*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x18287f0*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x1828810*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, ref UnityEngine.Vector2 ret);
        static /*0x1828910*/ void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, ref UnityEngine.Rect ret);
        static /*0x1828a00*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, ref UnityEngine.Vector4 offset);
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

        static /*0x18276b0*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x1827d10*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x1827770*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x1827dd0*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x1827870*/ System.Action<int> get_externBeginRenderOverlays();
        static /*0x1827ed0*/ void set_externBeginRenderOverlays(System.Action<int> value);
        static /*0x18278f0*/ System.Action<int, int> get_externRenderOverlaysBefore();
        static /*0x1827f90*/ void set_externRenderOverlaysBefore(System.Action<int, int> value);
        static /*0x18278b0*/ System.Action<int> get_externEndRenderOverlays();
        static /*0x1827f30*/ void set_externEndRenderOverlays(System.Action<int> value);
        static /*0x1827670*/ void SetExternalCanvasEnabled(bool enabled);
        static /*0x1827510*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x1827540*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x1827480*/ void ForceUpdateCanvases();
        static /*0x18275d0*/ void SendPreWillRenderCanvases();
        static /*0x1827620*/ void SendWillRenderCanvases();
        static /*0x18273c0*/ void BeginRenderExtraOverlays(int displayIndex);
        static /*0x1827570*/ void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder);
        static /*0x1827420*/ void EndRenderExtraOverlays(int displayIndex);
        /*0x15b84e0*/ Canvas();
        /*0x1827a30*/ UnityEngine.RenderMode get_renderMode();
        /*0x1827930*/ bool get_isRootCanvas();
        /*0x1827b90*/ float get_scaleFactor();
        /*0x1828090*/ void set_scaleFactor(float value);
        /*0x18279f0*/ float get_referencePixelsPerUnit();
        /*0x1828040*/ void set_referencePixelsPerUnit(float value);
        /*0x18279b0*/ bool get_pixelPerfect();
        /*0x1827a70*/ int get_renderOrder();
        /*0x1827970*/ bool get_overrideSorting();
        /*0x1827ff0*/ void set_overrideSorting(bool value);
        /*0x1827c50*/ int get_sortingOrder();
        /*0x1828120*/ void set_sortingOrder(int value);
        /*0x1827c90*/ int get_targetDisplay();
        /*0x1827bd0*/ int get_sortingLayerID();
        /*0x18280e0*/ void set_sortingLayerID(int value);
        /*0x1827830*/ UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels();
        /*0x1827e90*/ void set_additionalShaderChannels(UnityEngine.AdditionalCanvasShaderChannels value);
        /*0x1827c10*/ string get_sortingLayerName();
        /*0x1827b50*/ UnityEngine.Canvas get_rootCanvas();
        /*0x1827b00*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x1827cd0*/ UnityEngine.Camera get_worldCamera();
        /*0x1827ab0*/ void get_renderingDisplaySize_Injected(ref UnityEngine.Vector2 ret);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0xe25c50*/ WillRenderCanvases(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }
    }

    class UISystemProfilerApi
    {
        static /*0x18295d0*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x1829610*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x1829580*/ void AddMarker(string name, UnityEngine.Object obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }
}
