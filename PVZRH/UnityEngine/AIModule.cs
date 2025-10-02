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

            static /*0x15a9670*/ void Internal_CallOnNavMeshPreUpdate();

            class OnNavMeshPreUpdate : System.MulticastDelegate
            {
                /*0xe25c50*/ OnNavMeshPreUpdate(object object, nint method);
                /*0x9dbe20*/ void Invoke();
            }
        }
    }
}
