class <Module>
{
}

namespace UnityEngine
{
    class SpriteMask : UnityEngine.Renderer
    {
        /*0x16557c0*/ void set_frontSortingLayerID(int value);
        /*0x1655800*/ void set_frontSortingOrder(int value);
        /*0x1655770*/ void set_alphaCutoff(float value);
        /*0x1655890*/ void set_sprite(UnityEngine.Sprite value);
        /*0x1655840*/ void set_isCustomRangeActive(bool value);
    }

    class SpriteMaskUtility
    {
        static /*0x1655730*/ bool HasSpriteMaskInLayerRange(UnityEngine.Rendering.SortingLayerRange range);
        static /*0x16556f0*/ bool HasSpriteMaskInLayerRange_Injected(ref UnityEngine.Rendering.SortingLayerRange range);
    }
}
