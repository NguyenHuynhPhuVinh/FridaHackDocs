class <Module>
{
}

namespace UnityEngine
{
    class SpriteMask : UnityEngine.Renderer
    {
        static /*0x7f6e75c*/ int get_frontSortingLayerID_Injected(nint _unity_self);
        static /*0x7f6e818*/ void set_frontSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7f6e8d4*/ int get_frontSortingOrder_Injected(nint _unity_self);
        static /*0x7f6e990*/ void set_frontSortingOrder_Injected(nint _unity_self, int value);
        static /*0x7f6ea4c*/ int get_backSortingLayerID_Injected(nint _unity_self);
        static /*0x7f6eb08*/ void set_backSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7f6ebc4*/ int get_backSortingOrder_Injected(nint _unity_self);
        static /*0x7f6ec80*/ void set_backSortingOrder_Injected(nint _unity_self, int value);
        static /*0x7f6ed3c*/ float get_alphaCutoff_Injected(nint _unity_self);
        static /*0x7f6ee00*/ void set_alphaCutoff_Injected(nint _unity_self, float value);
        static /*0x7f6eee0*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x7f6efd0*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x7f6f08c*/ bool get_isCustomRangeActive_Injected(nint _unity_self);
        static /*0x7f6f148*/ void set_isCustomRangeActive_Injected(nint _unity_self, bool value);
        static /*0x7f6f204*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x7f6f2c0*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x7f6f37c*/ UnityEngine.SpriteMask.MaskSource get_maskSource_Injected(nint _unity_self);
        static /*0x7f6f438*/ void set_maskSource_Injected(nint _unity_self, UnityEngine.SpriteMask.MaskSource value);
        static /*0x7f6f510*/ nint get_cachedSupportedRenderer_Injected(nint _unity_self);
        static /*0x7f6f5f0*/ void GetSpriteBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        /*0x7f6f634*/ SpriteMask();
        /*0x7f6e6e4*/ int get_frontSortingLayerID();
        /*0x7f6e798*/ void set_frontSortingLayerID(int value);
        /*0x7f6e85c*/ int get_frontSortingOrder();
        /*0x7f6e910*/ void set_frontSortingOrder(int value);
        /*0x7f6e9d4*/ int get_backSortingLayerID();
        /*0x7f6ea88*/ void set_backSortingLayerID(int value);
        /*0x7f6eb4c*/ int get_backSortingOrder();
        /*0x7f6ec00*/ void set_backSortingOrder(int value);
        /*0x7f6ecc4*/ float get_alphaCutoff();
        /*0x7f6ed78*/ void set_alphaCutoff(float value);
        /*0x7f6ee4c*/ UnityEngine.Sprite get_sprite();
        /*0x7f6ef1c*/ void set_sprite(UnityEngine.Sprite value);
        /*0x7f6f014*/ bool get_isCustomRangeActive();
        /*0x7f6f0c8*/ void set_isCustomRangeActive(bool value);
        /*0x7f6f18c*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x7f6f240*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x7f6f304*/ UnityEngine.SpriteMask.MaskSource get_maskSource();
        /*0x7f6f3b8*/ void set_maskSource(UnityEngine.SpriteMask.MaskSource value);
        /*0x7f6f47c*/ UnityEngine.Renderer get_cachedSupportedRenderer();
        /*0x7f6f54c*/ UnityEngine.Bounds GetSpriteBounds();

        enum MaskSource
        {
            Sprite = 0,
            SupportedRenderers = 1,
        }
    }
}
