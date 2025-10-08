class <Module>
{
}

namespace UnityEngine
{
    class SpriteMask : UnityEngine.Renderer
    {
        static /*0x3e95d08*/ int get_frontSortingLayerID_Injected(nint _unity_self);
        static /*0x3e95dc4*/ void set_frontSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x3e95e80*/ int get_frontSortingOrder_Injected(nint _unity_self);
        static /*0x3e95f3c*/ void set_frontSortingOrder_Injected(nint _unity_self, int value);
        static /*0x3e95ff8*/ int get_backSortingLayerID_Injected(nint _unity_self);
        static /*0x3e960b4*/ void set_backSortingLayerID_Injected(nint _unity_self, int value);
        static /*0x3e96170*/ int get_backSortingOrder_Injected(nint _unity_self);
        static /*0x3e9622c*/ void set_backSortingOrder_Injected(nint _unity_self, int value);
        static /*0x3e962e8*/ float get_alphaCutoff_Injected(nint _unity_self);
        static /*0x3e963ac*/ void set_alphaCutoff_Injected(nint _unity_self, float value);
        static /*0x3e9648c*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x3e9657c*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x3e96638*/ bool get_isCustomRangeActive_Injected(nint _unity_self);
        static /*0x3e966f4*/ void set_isCustomRangeActive_Injected(nint _unity_self, bool value);
        static /*0x3e967b0*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x3e9686c*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x3e96928*/ UnityEngine.SpriteMask.MaskSource get_maskSource_Injected(nint _unity_self);
        static /*0x3e969e4*/ void set_maskSource_Injected(nint _unity_self, UnityEngine.SpriteMask.MaskSource value);
        static /*0x3e96abc*/ nint get_cachedSupportedRenderer_Injected(nint _unity_self);
        static /*0x3e96b9c*/ void GetSpriteBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        /*0x3e96be0*/ SpriteMask();
        /*0x3e95c90*/ int get_frontSortingLayerID();
        /*0x3e95d44*/ void set_frontSortingLayerID(int value);
        /*0x3e95e08*/ int get_frontSortingOrder();
        /*0x3e95ebc*/ void set_frontSortingOrder(int value);
        /*0x3e95f80*/ int get_backSortingLayerID();
        /*0x3e96034*/ void set_backSortingLayerID(int value);
        /*0x3e960f8*/ int get_backSortingOrder();
        /*0x3e961ac*/ void set_backSortingOrder(int value);
        /*0x3e96270*/ float get_alphaCutoff();
        /*0x3e96324*/ void set_alphaCutoff(float value);
        /*0x3e963f8*/ UnityEngine.Sprite get_sprite();
        /*0x3e964c8*/ void set_sprite(UnityEngine.Sprite value);
        /*0x3e965c0*/ bool get_isCustomRangeActive();
        /*0x3e96674*/ void set_isCustomRangeActive(bool value);
        /*0x3e96738*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x3e967ec*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x3e968b0*/ UnityEngine.SpriteMask.MaskSource get_maskSource();
        /*0x3e96964*/ void set_maskSource(UnityEngine.SpriteMask.MaskSource value);
        /*0x3e96a28*/ UnityEngine.Renderer get_cachedSupportedRenderer();
        /*0x3e96af8*/ UnityEngine.Bounds GetSpriteBounds();

        enum MaskSource
        {
            Sprite = 0,
            SupportedRenderers = 1,
        }
    }
}
