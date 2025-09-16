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

            static /*0x7dda0c8*/ void ClearPreUpdateListeners();
            static /*0x7dda11c*/ void Internal_CallOnNavMeshPreUpdate();

            class OnNavMeshPreUpdate : System.MulticastDelegate
            {
                /*0x7dda180*/ OnNavMeshPreUpdate(object object, nint method);
                /*0x7dda21c*/ void Invoke();
            }
        }
    }
}
