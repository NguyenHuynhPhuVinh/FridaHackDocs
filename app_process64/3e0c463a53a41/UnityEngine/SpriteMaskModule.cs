class <Module>
{
}

namespace UnityEngine
{
    class SpriteMask : UnityEngine.Renderer
    {
        static /*0x7f5732c*/ int get_frontSortingLayerID_Injected(nint _unity_self);
        static /*0x7f573e8*/ void set_frontSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7f574a4*/ int get_frontSortingOrder_Injected(nint _unity_self);
        static /*0x7f57560*/ void set_frontSortingOrder_Injected(nint _unity_self, int value);
        static /*0x7f5761c*/ int get_backSortingLayerID_Injected(nint _unity_self);
        static /*0x7f576d8*/ void set_backSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7f57794*/ int get_backSortingOrder_Injected(nint _unity_self);
        static /*0x7f57850*/ void set_backSortingOrder_Injected(nint _unity_self, int value);
        static /*0x7f5790c*/ float get_alphaCutoff_Injected(nint _unity_self);
        static /*0x7f579d0*/ void set_alphaCutoff_Injected(nint _unity_self, float value);
        static /*0x7f57ab0*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x7f57ba0*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x7f57c5c*/ bool get_isCustomRangeActive_Injected(nint _unity_self);
        static /*0x7f57d18*/ void set_isCustomRangeActive_Injected(nint _unity_self, bool value);
        static /*0x7f57dd4*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x7f57e90*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x7f57f4c*/ UnityEngine.SpriteMask.MaskSource get_maskSource_Injected(nint _unity_self);
        static /*0x7f58008*/ void set_maskSource_Injected(nint _unity_self, UnityEngine.SpriteMask.MaskSource value);
        static /*0x7f580e0*/ nint get_cachedSupportedRenderer_Injected(nint _unity_self);
        static /*0x7f581c0*/ void GetSpriteBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        /*0x7f58204*/ SpriteMask();
        /*0x7f572b4*/ int get_frontSortingLayerID();
        /*0x7f57368*/ void set_frontSortingLayerID(int value);
        /*0x7f5742c*/ int get_frontSortingOrder();
        /*0x7f574e0*/ void set_frontSortingOrder(int value);
        /*0x7f575a4*/ int get_backSortingLayerID();
        /*0x7f57658*/ void set_backSortingLayerID(int value);
        /*0x7f5771c*/ int get_backSortingOrder();
        /*0x7f577d0*/ void set_backSortingOrder(int value);
        /*0x7f57894*/ float get_alphaCutoff();
        /*0x7f57948*/ void set_alphaCutoff(float value);
        /*0x7f57a1c*/ UnityEngine.Sprite get_sprite();
        /*0x7f57aec*/ void set_sprite(UnityEngine.Sprite value);
        /*0x7f57be4*/ bool get_isCustomRangeActive();
        /*0x7f57c98*/ void set_isCustomRangeActive(bool value);
        /*0x7f57d5c*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x7f57e10*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x7f57ed4*/ UnityEngine.SpriteMask.MaskSource get_maskSource();
        /*0x7f57f88*/ void set_maskSource(UnityEngine.SpriteMask.MaskSource value);
        /*0x7f5804c*/ UnityEngine.Renderer get_cachedSupportedRenderer();
        /*0x7f5811c*/ UnityEngine.Bounds GetSpriteBounds();

        enum MaskSource
        {
            Sprite = 0,
            SupportedRenderers = 1,
        }
    }
}
