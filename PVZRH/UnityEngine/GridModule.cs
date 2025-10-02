class <Module>
{
}

namespace UnityEngine
{
    class Grid : UnityEngine.GridLayout
    {
    }

    class GridLayout : UnityEngine.Behaviour
    {
        /*0x15b84e0*/ GridLayout();
        /*0x1628df0*/ UnityEngine.Vector3 CellToLocalInterpolated(UnityEngine.Vector3 cellPosition);
        /*0x1628eb0*/ UnityEngine.Vector3 CellToWorld(UnityEngine.Vector3Int cellPosition);
        /*0x1629030*/ UnityEngine.Vector3Int WorldToCell(UnityEngine.Vector3 worldPosition);
        /*0x1628f70*/ UnityEngine.Vector3 LocalToWorld(UnityEngine.Vector3 localPosition);
        /*0x32d010*/ void DoNothing();
        /*0x1628d90*/ void CellToLocalInterpolated_Injected(ref UnityEngine.Vector3 cellPosition, ref UnityEngine.Vector3 ret);
        /*0x1628e50*/ void CellToWorld_Injected(ref UnityEngine.Vector3Int cellPosition, ref UnityEngine.Vector3 ret);
        /*0x1628fd0*/ void WorldToCell_Injected(ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3Int ret);
        /*0x1628f10*/ void LocalToWorld_Injected(ref UnityEngine.Vector3 localPosition, ref UnityEngine.Vector3 ret);
    }
}
