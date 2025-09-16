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

                /*0x7cf79c4*/ ExternalUserIdProperty();
                /*0x7cf7980*/ string get_UserId();
                /*0x7cf7988*/ void set_UserId(string value);
            }

            class InitializationOptions
            {
                /*0x10*/ System.Collections.Generic.IDictionary<string, object> <Values>k__BackingField;

                /*0x7cf79d4*/ InitializationOptions(System.Collections.Generic.IDictionary<string, object> values);
                /*0x7cf7a04*/ InitializationOptions(Unity.Services.Core.InitializationOptions source);
                /*0x7cf79cc*/ System.Collections.Generic.IDictionary<string, object> get_Values();
            }

            class ServicesInitializationException : System.Exception
            {
                /*0x7cf7a98*/ ServicesInitializationException();
                /*0x7cf7af0*/ ServicesInitializationException(string message);
                /*0x7cf7b58*/ ServicesInitializationException(string message, System.Exception innerException);
            }

            enum ServicesInitializationState
            {
                Uninitialized = 0,
                Initializing = 1,
                Initialized = 2,
            }

            class UnityProjectNotLinkedException : Unity.Services.Core.ServicesInitializationException
            {
                /*0x7cf7bc8*/ UnityProjectNotLinkedException(string message);
            }

            interface IUnityServices
            {
                /*0x380b6a0*/ Unity.Services.Core.ServicesInitializationState get_State();
            }

            class UnityServices
            {
                static /*0x0*/ Unity.Services.Core.IUnityServices <Instance>k__BackingField;
                static /*0x8*/ System.Threading.Tasks.TaskCompletionSource<object> <InstantiationCompletion>k__BackingField;
                static /*0x10*/ Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> <s_Services>k__BackingField;

                static /*0x7cf8124*/ UnityServices();
                static /*0x7cf7bcc*/ Unity.Services.Core.IUnityServices get_Instance();
                static /*0x7cf7c24*/ void set_Instance(Unity.Services.Core.IUnityServices value);
                static /*0x7cf7c8c*/ System.Threading.Tasks.TaskCompletionSource<object> get_InstantiationCompletion();
                static /*0x7cf7ce4*/ System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> get_s_Services();
                static /*0x7cf7d3c*/ Unity.Services.Core.ServicesInitializationState get_State();
                static /*0x7cf7fb0*/ string get_ExternalUserId();
                static /*0x7cf8014*/ void set_ExternalUserId(string value);
                static /*0x7cf807c*/ void ClearServices();
            }

            class UnityServicesBuilder
            {
                static /*0x0*/ Unity.Services.Core.UnityServicesBuilder.CreationDelegate <InstanceCreationDelegate>k__BackingField;

                static /*0x7cf81f0*/ void set_InstanceCreationDelegate(Unity.Services.Core.UnityServicesBuilder.CreationDelegate value);

                class CreationDelegate : System.MulticastDelegate
                {
                    /*0x7cf8248*/ CreationDelegate(object object, nint method);
                    /*0x7cf82f8*/ Unity.Services.Core.IUnityServices Invoke(string servicesId);
                }
            }

            class UnityThreadUtils
            {
                static /*0x0*/ int s_UnityThreadId;
                static /*0x8*/ System.Threading.Tasks.TaskScheduler <UnityThreadScheduler>k__BackingField;

                static /*0x7cf830c*/ void set_UnityThreadScheduler(System.Threading.Tasks.TaskScheduler value);
                static /*0x7cf835c*/ void CaptureUnityThreadInfo();
                static /*0x7cf7f50*/ bool get_IsRunningOnUnityThread();
            }
        }
    }
}
