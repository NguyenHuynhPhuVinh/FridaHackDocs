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
        /*0x2b0fc24*/ float get_alpha();
        /*0x2b0fc64*/ void set_alpha(float value);
        /*0x2b0fcb4*/ bool get_interactable();
        /*0x2b0fcf4*/ void set_interactable(bool value);
        /*0x2b0fd44*/ bool get_blocksRaycasts();
        /*0x2b0fd84*/ void set_blocksRaycasts(bool value);
        /*0x2b0fdd4*/ bool get_ignoreParentGroups();
        /*0x2b0fe14*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
    }

    class CanvasRenderer : UnityEngine.Component
    {
        /*0x18*/ bool <isMask>k__BackingField;

        static /*0x2b10720*/ void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2b108ec*/ void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices);
        static /*0x2b10a34*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        static /*0x2b1089c*/ void SplitIndicesStreamsInternal(object verts, object indices);
        static /*0x2b107fc*/ void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);
        static /*0x2b10990*/ void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);
        /*0x2b0fe54*/ void set_hasPopInstruction(bool value);
        /*0x2b0fea4*/ int get_materialCount();
        /*0x2b0fee4*/ void set_materialCount(int value);
        /*0x2b0ff34*/ void set_popMaterialCount(int value);
        /*0x2b0ff84*/ int get_absoluteDepth();
        /*0x2b0ffc4*/ bool get_hasMoved();
        /*0x2b10004*/ bool get_cull();
        /*0x2b10044*/ void set_cull(bool value);
        /*0x2b10094*/ void SetColor(UnityEngine.Color color);
        /*0x2b1013c*/ UnityEngine.Color GetColor();
        /*0x2b101e8*/ void EnableRectClipping(UnityEngine.Rect rect);
        /*0x2b10290*/ void set_clippingSoftness(UnityEngine.Vector2 value);
        /*0x2b10334*/ void DisableRectClipping();
        /*0x2b10374*/ void SetMaterial(UnityEngine.Material material, int index);
        /*0x2b103cc*/ UnityEngine.Material GetMaterial(int index);
        /*0x2b1041c*/ void SetPopMaterial(UnityEngine.Material material, int index);
        /*0x2b10474*/ void SetTexture(UnityEngine.Texture texture);
        /*0x2b104c4*/ void SetAlphaTexture(UnityEngine.Texture texture);
        /*0x2b10514*/ void SetMesh(UnityEngine.Mesh mesh);
        /*0x2b10564*/ void Clear();
        /*0x2b105a4*/ float GetInheritedAlpha();
        /*0x2b105e4*/ void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture);
        /*0x2b100ec*/ void SetColor_Injected(ref UnityEngine.Color color);
        /*0x2b10198*/ void GetColor_Injected(ref UnityEngine.Color ret);
        /*0x2b10240*/ void EnableRectClipping_Injected(ref UnityEngine.Rect rect);
        /*0x2b102e4*/ void set_clippingSoftness_Injected(ref UnityEngine.Vector2 value);
    }

    class RectTransformUtility
    {
        static /*0x0*/ UnityEngine.Vector3[] s_Corners;

        static /*0x2b11928*/ RectTransformUtility();
        static /*0x2b10ad4*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas);
        static /*0x2b10bec*/ UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas);
        static /*0x2b10cf0*/ bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x2b10e0c*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam);
        static /*0x2b10ecc*/ bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset);
        static /*0x2b10f84*/ bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector3 worldPoint);
        static /*0x2b11234*/ bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, ref UnityEngine.Vector2 localPoint);
        static /*0x2b1111c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos);
        static /*0x2b11314*/ UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint);
        static /*0x2b113d0*/ void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive);
        static /*0x2b11688*/ void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive);
        static /*0x2b11918*/ UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input);
        static /*0x2b10b84*/ void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, ref UnityEngine.Vector2 ret);
        static /*0x2b10c98*/ void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, ref UnityEngine.Rect ret);
        static /*0x2b10da4*/ bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, ref UnityEngine.Vector4 offset);
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

        static /*0x2b0ef7c*/ void add_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2b0f038*/ void remove_preWillRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2b0f0f4*/ void add_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2b0f1b4*/ void remove_willRenderCanvases(UnityEngine.Canvas.WillRenderCanvases value);
        static /*0x2b0f8dc*/ UnityEngine.Material GetDefaultCanvasMaterial();
        static /*0x2b0f910*/ UnityEngine.Material GetETC1SupportedCanvasMaterial();
        static /*0x2b0f944*/ void ForceUpdateCanvases();
        static /*0x2b0f958*/ void SendPreWillRenderCanvases();
        static /*0x2b0f9b4*/ void SendWillRenderCanvases();
        /*0x2b0fc1c*/ Canvas();
        /*0x2b0f274*/ UnityEngine.RenderMode get_renderMode();
        /*0x2b0f2b4*/ void set_renderMode(UnityEngine.RenderMode value);
        /*0x2b0f304*/ bool get_isRootCanvas();
        /*0x2b0f344*/ float get_scaleFactor();
        /*0x2b0f384*/ void set_scaleFactor(float value);
        /*0x2b0f3d4*/ float get_referencePixelsPerUnit();
        /*0x2b0f414*/ void set_referencePixelsPerUnit(float value);
        /*0x2b0f464*/ bool get_pixelPerfect();
        /*0x2b0f4a4*/ void set_pixelPerfect(bool value);
        /*0x2b0f4f4*/ float get_planeDistance();
        /*0x2b0f534*/ int get_renderOrder();
        /*0x2b0f574*/ bool get_overrideSorting();
        /*0x2b0f5b4*/ void set_overrideSorting(bool value);
        /*0x2b0f604*/ int get_sortingOrder();
        /*0x2b0f644*/ void set_sortingOrder(int value);
        /*0x2b0f694*/ int get_targetDisplay();
        /*0x2b0f6d4*/ int get_sortingLayerID();
        /*0x2b0f714*/ void set_sortingLayerID(int value);
        /*0x2b0f764*/ UnityEngine.Canvas get_rootCanvas();
        /*0x2b0f7a4*/ UnityEngine.Vector2 get_renderingDisplaySize();
        /*0x2b0f84c*/ UnityEngine.Camera get_worldCamera();
        /*0x2b0f88c*/ void set_worldCamera(UnityEngine.Camera value);
        /*0x2b0f7fc*/ void get_renderingDisplaySize_Injected(ref UnityEngine.Vector2 ret);

        class WillRenderCanvases : System.MulticastDelegate
        {
            /*0x2b11a64*/ WillRenderCanvases(object object, nint method);
            /*0x2b0fa10*/ void Invoke();
            /*0x2b11ac4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2b11af0*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class UISystemProfilerApi
    {
        static /*0x2b11994*/ void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x2b119d4*/ void EndSample(UnityEngine.UISystemProfilerApi.SampleType type);
        static /*0x2b11a14*/ void AddMarker(string name, UnityEngine.Object obj);

        enum SampleType
        {
            Layout = 0,
            Render = 1,
        }
    }
}
