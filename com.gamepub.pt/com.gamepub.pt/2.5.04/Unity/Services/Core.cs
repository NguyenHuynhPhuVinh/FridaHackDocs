class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            interface IUnityServices
            {
                Unity.Services.Core.ServicesInitializationState get_State();
                Unity.Services.Core.InitializationOptions get_Options();
            }

            class InitializationOptions
            {
                /*0x10*/ System.Collections.Generic.IDictionary<string, object> <Values>k__BackingField;

                /*0x2b342fc*/ InitializationOptions(System.Collections.Generic.IDictionary<string, object> values);
                /*0x2b34328*/ InitializationOptions(Unity.Services.Core.InitializationOptions source);
                /*0x2b342f4*/ System.Collections.Generic.IDictionary<string, object> get_Values();
            }

            class ServicesInitializationException : System.Exception
            {
                /*0x2b34450*/ ServicesInitializationException();
                /*0x2b344b4*/ ServicesInitializationException(string message);
                /*0x2b34528*/ ServicesInitializationException(string message, System.Exception innerException);
            }

            enum ServicesInitializationState
            {
                Uninitialized = 0,
                Initializing = 1,
                Initialized = 2,
            }

            class RequestFailedException : System.Exception
            {
                /*0x88*/ int <ErrorCode>k__BackingField;

                /*0x2b343c0*/ RequestFailedException(int errorCode, string message, System.Exception innerException);
            }

            class UnityServices
            {
                static /*0x0*/ Unity.Services.Core.IUnityServices <Instance>k__BackingField;
                static /*0x8*/ System.Threading.Tasks.TaskCompletionSource<object> <InstantiationCompletion>k__BackingField;

                static /*0x2b345a4*/ Unity.Services.Core.IUnityServices get_Instance();
                static /*0x2b345f0*/ void set_Instance(Unity.Services.Core.IUnityServices value);
                static /*0x2b34640*/ System.Threading.Tasks.TaskCompletionSource<object> get_InstantiationCompletion();
                static /*0x2b3468c*/ Unity.Services.Core.ServicesInitializationState get_State();
            }

            class UnityThreadUtils
            {
                static /*0x0*/ int s_UnityThreadId;
                static /*0x8*/ System.Threading.Tasks.TaskScheduler UnityThreadScheduler;

                static /*0x2b34880*/ void CaptureUnityThreadInfo();
                static /*0x2b34814*/ bool get_IsRunningOnUnityThread();
            }
        }
    }
}
