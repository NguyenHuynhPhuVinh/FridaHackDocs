class <Module>
{
}

namespace UnityEngine
{
    namespace AI
    {
        class NavMesh
        {
            static /*0x0*/ UnityEngine.AI.NavMesh.OnNavMeshPreUpdate onPreUpdate;

            static /*0x3d34518*/ void ClearPreUpdateListeners();

            class OnNavMeshPreUpdate : System.MulticastDelegate
            {
                /*0x3d3456c*/ OnNavMeshPreUpdate(object object, nint method);
                /*0x3d34608*/ void Invoke();
            }
        }
    }
}
