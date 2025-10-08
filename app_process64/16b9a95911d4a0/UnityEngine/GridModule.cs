class <Module>
{
}

namespace UnityEngine
{
    class Grid : UnityEngine.GridLayout
    {
        static /*0x3e306b8*/ UnityEngine.Vector3 Swizzle(UnityEngine.GridLayout.CellSwizzle swizzle, UnityEngine.Vector3 position);
        static /*0x3e30774*/ UnityEngine.Vector3 InverseSwizzle(UnityEngine.GridLayout.CellSwizzle swizzle, UnityEngine.Vector3 position);
        static /*0x3e30100*/ void get_cellSize_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e301d4*/ void set_cellSize_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e302b0*/ void get_cellGap_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3e30384*/ void set_cellGap_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3e30440*/ UnityEngine.GridLayout.CellLayout get_cellLayout_Injected(nint _unity_self);
        static /*0x3e304fc*/ void set_cellLayout_Injected(nint _unity_self, UnityEngine.GridLayout.CellLayout value);
        static /*0x3e305b8*/ UnityEngine.GridLayout.CellSwizzle get_cellSwizzle_Injected(nint _unity_self);
        static /*0x3e30674*/ void set_cellSwizzle_Injected(nint _unity_self, UnityEngine.GridLayout.CellSwizzle value);
        static /*0x3e30720*/ void Swizzle_Injected(UnityEngine.GridLayout.CellSwizzle swizzle, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3e307dc*/ void InverseSwizzle_Injected(UnityEngine.GridLayout.CellSwizzle swizzle, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x3e30830*/ Grid();
        /*0x3e2fdf8*/ UnityEngine.Vector3 GetCellCenterLocal(UnityEngine.Vector3Int position);
        /*0x3e2ff78*/ UnityEngine.Vector3 GetCellCenterWorld(UnityEngine.Vector3Int position);
        /*0x3e30068*/ UnityEngine.Vector3 get_cellSize();
        /*0x3e30144*/ void set_cellSize(UnityEngine.Vector3 value);
        /*0x3e30218*/ UnityEngine.Vector3 get_cellGap();
        /*0x3e302f4*/ void set_cellGap(UnityEngine.Vector3 value);
        /*0x3e303c8*/ UnityEngine.GridLayout.CellLayout get_cellLayout();
        /*0x3e3047c*/ void set_cellLayout(UnityEngine.GridLayout.CellLayout value);
        /*0x3e30540*/ UnityEngine.GridLayout.CellSwizzle get_cellSwizzle();
        /*0x3e305f4*/ void set_cellSwizzle(UnityEngine.GridLayout.CellSwizzle value);
    }

    class GridLayout : UnityEngine.Behaviour
    {
        static /*0x3e30840*/ void CellToLocalInterpolated_Injected(nint _unity_self, ref UnityEngine.Vector3 cellPosition, ref UnityEngine.Vector3 ret);
        static /*0x3e30938*/ void LocalToCellInterpolated_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Vector3 ret);
        static /*0x3e30a30*/ void CellToWorld_Injected(nint _unity_self, ref UnityEngine.Vector3Int cellPosition, ref UnityEngine.Vector3 ret);
        static /*0x3e30b28*/ void WorldToCell_Injected(nint _unity_self, ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3Int ret);
        static /*0x3e30b7c*/ void LocalToWorld_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Vector3 ret);
        static /*0x3e30c74*/ void WorldToLocal_Injected(nint _unity_self, ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 ret);
        static /*0x3e30cc8*/ void GetLayoutCellCenter_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        /*0x3e30838*/ GridLayout();
        /*0x3e2fed4*/ UnityEngine.Vector3 CellToLocalInterpolated(UnityEngine.Vector3 cellPosition);
        /*0x3e30894*/ UnityEngine.Vector3 LocalToCellInterpolated(UnityEngine.Vector3 localPosition);
        /*0x3e3098c*/ UnityEngine.Vector3 CellToWorld(UnityEngine.Vector3Int cellPosition);
        /*0x3e30a84*/ UnityEngine.Vector3Int WorldToCell(UnityEngine.Vector3 worldPosition);
        /*0x3e2ffc4*/ UnityEngine.Vector3 LocalToWorld(UnityEngine.Vector3 localPosition);
        /*0x3e30bd0*/ UnityEngine.Vector3 WorldToLocal(UnityEngine.Vector3 worldPosition);
        /*0x3e2fe3c*/ UnityEngine.Vector3 GetLayoutCellCenter();
        /*0x3e30d0c*/ void DoNothing();

        enum CellLayout
        {
            Rectangle = 0,
            Hexagon = 1,
            Isometric = 2,
            IsometricZAsY = 3,
        }

        enum CellSwizzle
        {
            XYZ = 0,
            XZY = 1,
            YXZ = 2,
            YZX = 3,
            ZXY = 4,
            ZYX = 5,
        }
    }
}
