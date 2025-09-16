class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            class ExternalUserIdProperty
            {
                /*0x10*/ System.Action<string> UserIdChanged;
                /*0x18*/ string m_UserId;

                /*0x7d0edf4*/ ExternalUserIdProperty();
                /*0x7d0edb0*/ string get_UserId();
                /*0x7d0edb8*/ void set_UserId(string value);
            }

            class InitializationOptions
            {
                /*0x10*/ System.Collections.Generic.IDictionary<string, object> <Values>k__BackingField;

                /*0x7d0ee04*/ InitializationOptions(System.Collections.Generic.IDictionary<string, object> values);
                /*0x7d0ee34*/ InitializationOptions(Unity.Services.Core.InitializationOptions source);
                /*0x7d0edfc*/ System.Collections.Generic.IDictionary<string, object> get_Values();
            }

            class ServicesInitializationException : System.Exception
            {
                /*0x7d0eec8*/ ServicesInitializationException();
                /*0x7d0ef20*/ ServicesInitializationException(string message);
                /*0x7d0ef88*/ ServicesInitializationException(string message, System.Exception innerException);
            }

            enum ServicesInitializationState
            {
                Uninitialized = 0,
                Initializing = 1,
                Initialized = 2,
            }

            class UnityProjectNotLinkedException : Unity.Services.Core.ServicesInitializationException
            {
                /*0x7d0eff8*/ UnityProjectNotLinkedException(string message);
            }

            interface IUnityServices
            {
                /*0x3814574*/ Unity.Services.Core.ServicesInitializationState get_State();
            }

            class UnityServices
            {
                static /*0x0*/ Unity.Services.Core.IUnityServices <Instance>k__BackingField;
                static /*0x8*/ System.Threading.Tasks.TaskCompletionSource<object> <InstantiationCompletion>k__BackingField;
                static /*0x10*/ Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> <s_Services>k__BackingField;

                static /*0x7d0f554*/ UnityServices();
                static /*0x7d0effc*/ Unity.Services.Core.IUnityServices get_Instance();
                static /*0x7d0f054*/ void set_Instance(Unity.Services.Core.IUnityServices value);
                static /*0x7d0f0bc*/ System.Threading.Tasks.TaskCompletionSource<object> get_InstantiationCompletion();
                static /*0x7d0f114*/ System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> get_s_Services();
                static /*0x7d0f16c*/ Unity.Services.Core.ServicesInitializationState get_State();
                static /*0x7d0f3e0*/ string get_ExternalUserId();
                static /*0x7d0f444*/ void set_ExternalUserId(string value);
                static /*0x7d0f4ac*/ void ClearServices();
            }

            class UnityServicesBuilder
            {
                static /*0x0*/ Unity.Services.Core.UnityServicesBuilder.CreationDelegate <InstanceCreationDelegate>k__BackingField;

                static /*0x7d0f620*/ void set_InstanceCreationDelegate(Unity.Services.Core.UnityServicesBuilder.CreationDelegate value);

                class CreationDelegate : System.MulticastDelegate
                {
                    /*0x7d0f678*/ CreationDelegate(object object, nint method);
                    /*0x7d0f728*/ Unity.Services.Core.IUnityServices Invoke(string servicesId);
                }
            }

            class UnityThreadUtils
            {
                static /*0x0*/ int s_UnityThreadId;
                static /*0x8*/ System.Threading.Tasks.TaskScheduler <UnityThreadScheduler>k__BackingField;

                static /*0x7d0f73c*/ void set_UnityThreadScheduler(System.Threading.Tasks.TaskScheduler value);
                static /*0x7d0f78c*/ void CaptureUnityThreadInfo();
                static /*0x7d0f380*/ bool get_IsRunningOnUnityThread();
            }
        }
    }
}
