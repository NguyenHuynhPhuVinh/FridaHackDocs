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

            static /*0x2b3a0f0*/ void Internal_CallOnNavMeshPreUpdate();

            class OnNavMeshPreUpdate : System.MulticastDelegate
            {
                /*0x2b3a358*/ OnNavMeshPreUpdate(object object, nint method);
                /*0x2b3a14c*/ void Invoke();
                /*0x2b3a3b8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x2b3a3e4*/ void EndInvoke(System.IAsyncResult result);
            }
        }
    }
}
