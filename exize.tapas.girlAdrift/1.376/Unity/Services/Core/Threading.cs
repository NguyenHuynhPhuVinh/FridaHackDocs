class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Threading
            {
                namespace Internal
                {
                    class UnityThreadUtilsInternal : Unity.Services.Core.Threading.Internal.IUnityThreadUtils, Unity.Services.Core.Internal.IServiceComponent
                    {
                        static /*0x17415d8*/ System.Threading.Tasks.Task PostAsync(System.Action action);
                        static /*0x17416f0*/ System.Threading.Tasks.Task PostAsync(System.Action<object> action, object state);
                        static System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<T> action);
                        static System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<object, T> action, object state);
                        static /*0x1741810*/ void Send(System.Action action);
                        static /*0x1741858*/ void Send(System.Action<object> action, object state);
                        static T Send<T>(System.Func<T> action);
                        static T Send<T>(System.Func<object, T> action, object state);
                        /*0x17418e8*/ UnityThreadUtilsInternal();
                        /*0x17418b8*/ bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.get_IsRunningOnUnityThread();
                        /*0x17418c0*/ System.Threading.Tasks.Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(System.Action action);
                        /*0x17418c8*/ System.Threading.Tasks.Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(System.Action<object> action, object state);
                        System.Threading.Tasks.Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(System.Func<T> action);
                        System.Threading.Tasks.Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(System.Func<object, T> action, object state);
                        /*0x17418d4*/ void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(System.Action action);
                        /*0x17418dc*/ void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(System.Action<object> action, object state);
                        T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(System.Func<T> action);
                        T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(System.Func<object, T> action, object state);
                    }
                }
            }
        }
    }
}
