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

            static /*0x7dc2c98*/ void ClearPreUpdateListeners();
            static /*0x7dc2cec*/ void Internal_CallOnNavMeshPreUpdate();

            class OnNavMeshPreUpdate : System.MulticastDelegate
            {
                /*0x7dc2d50*/ OnNavMeshPreUpdate(object object, nint method);
                /*0x7dc2dec*/ void Invoke();
            }
        }
    }
}
