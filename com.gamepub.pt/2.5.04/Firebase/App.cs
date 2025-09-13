class <Module>
{
}

namespace Firebase
{
    enum DependencyStatus
    {
        Available = 0,
        UnavailableDisabled = 1,
        UnavailableInvalid = 2,
        UnavilableMissing = 3,
        UnavailablePermission = 4,
        UnavailableUpdaterequired = 5,
        UnavailableUpdating = 6,
        UnavailableOther = 7,
    }

    class FirebaseException : System.Exception
    {
        /*0x88*/ int <ErrorCode>k__BackingField;

        /*0x2a40298*/ FirebaseException(int errorCode, string message);
        /*0x2a40318*/ void set_ErrorCode(int value);
    }

    class InitializationException : System.Exception
    {
        /*0x88*/ Firebase.InitResult <InitResult>k__BackingField;

        /*0x2a426b4*/ InitializationException(Firebase.InitResult result);
        /*0x2a3c390*/ InitializationException(Firebase.InitResult result, string message);
        /*0x2a3ec7c*/ InitializationException(Firebase.InitResult result, string message, System.Exception inner);
        /*0x2a426a4*/ Firebase.InitResult get_InitResult();
        /*0x2a426ac*/ void set_InitResult(Firebase.InitResult value);
    }

    class ErrorMessages
    {
        static /*0x0*/ string DEPENDENCY_NOT_FOUND_ERROR_ANDROID;
        static /*0x8*/ string DEPENDENCY_NOT_FOUND_ERROR_IOS;
        static /*0x10*/ string DEPENDENCY_NOT_FOUND_ERROR_GENERIC;
        static /*0x18*/ string DLL_NOT_FOUND_ERROR_ANDROID;
        static /*0x20*/ string DLL_NOT_FOUND_ERROR_IOS;
        static /*0x28*/ string DLL_NOT_FOUND_ERROR_GENERIC;

        static /*0x2a3b80c*/ ErrorMessages();
        static /*0x2a3b634*/ string get_DependencyNotFoundErrorMessage();
        static /*0x2a3b708*/ string get_DllNotFoundExceptionErrorMessage();
    }

    class LogUtil : System.IDisposable
    {
        static /*0x0*/ Firebase.LogUtil _instance;
        static /*0x8*/ object InitializeLoggingLock;
        /*0x10*/ bool _disposed;

        static /*0x2a427e4*/ LogUtil();
        static /*0x2a3c108*/ void InitializeLogging();
        static /*0x2a40224*/ Firebase.Platform.PlatformLogLevel ConvertLogLevel(Firebase.LogLevel logLevel);
        static /*0x2a3e910*/ void LogMessage(Firebase.LogLevel logLevel, string message);
        static /*0x2a4272c*/ void LogMessageFromCallback(Firebase.LogLevel logLevel, string message);
        /*0x2a4287c*/ LogUtil();
        /*0x2a429d4*/ void Finalize();
        /*0x2a42a88*/ void Dispose();
        /*0x2a42a50*/ void Dispose(bool disposing);
        /*0x2a42b04*/ void <.ctor>b__9_0(object sender, System.EventArgs e);

        class LogMessageDelegate : System.MulticastDelegate
        {
            /*0x2a42974*/ LogMessageDelegate(object object, nint method);
            /*0x2a450b0*/ void Invoke(Firebase.LogLevel log_level, string message);
            /*0x2a45328*/ System.IAsyncResult BeginInvoke(Firebase.LogLevel log_level, string message, System.AsyncCallback callback, object object);
            /*0x2a453bc*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x2a42b3c*/ MonoPInvokeCallbackAttribute(System.Type t);
    }

    enum FutureStatus
    {
        Complete = 0,
        Pending = 1,
        Invalid = 2,
    }

    class FutureBase : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        /*0x2a40320*/ FutureBase(nint cPtr, bool cMemoryOwn);
        /*0x2a40384*/ void Finalize();
        /*0x2a403f8*/ void Dispose();
        /*0x2a40470*/ void Dispose(bool disposing);
        /*0x2a40648*/ Firebase.FutureStatus status();
        /*0x2a4074c*/ int error();
        /*0x2a40850*/ string error_message();
    }

    class FutureString : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureString.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureString.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x2a41960*/ FutureString();
        static /*0x2a40e38*/ System.Threading.Tasks.Task<string> GetTask(Firebase.FutureString fu);
        static /*0x2a40954*/ void SWIG_CompletionDispatcher(int key);
        /*0x2a40b48*/ FutureString(nint cPtr, bool cMemoryOwn);
        /*0x2a40c04*/ void Dispose(bool disposing);
        /*0x2a41334*/ void ThrowIfDisposed();
        /*0x2a410a8*/ void SetOnCompletionCallback(Firebase.FutureString.Action userCompletionCallback);
        /*0x2a40e04*/ void SetCompletionData(nint data);
        /*0x2a4142c*/ nint SWIG_OnCompletion(Firebase.FutureString.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x2a41548*/ void SWIG_FreeCompletionData(nint data);
        /*0x2a4185c*/ string GetResult();

        class Action : System.MulticastDelegate
        {
            /*0x2a41048*/ Action(object object, nint method);
            /*0x2a41650*/ void Invoke();
            /*0x2a44884*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a448b0*/ void EndInvoke(System.IAsyncResult result);
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x2a413cc*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x2a448bc*/ void Invoke(int index);
            /*0x2a44ae8*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
            /*0x2a44b70*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Firebase.FutureString fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<string> tcs;

            /*0x2a41040*/ <>c__DisplayClass4_0();
            /*0x2a4463c*/ void <GetTask>b__0();
        }
    }

    class FutureVoid : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureVoid.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureVoid.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x2a42624*/ FutureVoid();
        static /*0x2a3a560*/ System.Threading.Tasks.Task GetTask(Firebase.FutureVoid fu);
        static /*0x2a419e0*/ void SWIG_CompletionDispatcher(int key);
        /*0x2a3a4a4*/ FutureVoid(nint cPtr, bool cMemoryOwn);
        /*0x2a41bd4*/ void Dispose(bool disposing);
        /*0x2a420fc*/ void ThrowIfDisposed();
        /*0x2a41e70*/ void SetOnCompletionCallback(Firebase.FutureVoid.Action userCompletionCallback);
        /*0x2a41dd4*/ void SetCompletionData(nint data);
        /*0x2a421f4*/ nint SWIG_OnCompletion(Firebase.FutureVoid.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x2a42310*/ void SWIG_FreeCompletionData(nint data);

        class Action : System.MulticastDelegate
        {
            /*0x2a41e10*/ Action(object object, nint method);
            /*0x2a42418*/ void Invoke();
            /*0x2a44db8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a44de4*/ void EndInvoke(System.IAsyncResult result);
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x2a42194*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x2a44df0*/ void Invoke(int index);
            /*0x2a4501c*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
            /*0x2a450a4*/ void EndInvoke(System.IAsyncResult result);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ Firebase.FutureVoid fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<int> tcs;

            /*0x2a41e08*/ <>c__DisplayClass4_0();
            /*0x2a44b7c*/ void <GetTask>b__0();
        }
    }

    enum InitResult
    {
        Success = 0,
        FailedMissingDependency = 1,
    }

    class FirebaseApp : System.IDisposable
    {
        static /*0x0*/ object disposeLock;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, Firebase.FirebaseApp> nameToProxy;
        static /*0x10*/ System.Collections.Generic.Dictionary<nint, Firebase.FirebaseApp> cPtrToProxy;
        static /*0x18*/ bool AppUtilCallbacksInitialized;
        static /*0x20*/ object AppUtilCallbacksLock;
        static /*0x28*/ bool PreventOnAllAppsDestroyed;
        static /*0x29*/ bool crashlyticsInitializationAttempted;
        static /*0x2c*/ int CheckDependenciesThread;
        static /*0x30*/ object CheckDependenciesThreadLock;
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;
        /*0x28*/ string name;
        /*0x30*/ System.EventHandler AppDisposed;
        /*0x38*/ Firebase.Platform.FirebaseAppPlatform appPlatform;

        static /*0x2a3bf6c*/ FirebaseApp();
        static /*0x2a3b97c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FirebaseApp obj);
        static /*0x2a3c214*/ void TranslateDllNotFoundException(System.Action closureToExecute);
        static /*0x2a3c410*/ Firebase.FirebaseApp get_DefaultInstance();
        static /*0x2a3c58c*/ Firebase.FirebaseApp GetInstance(string name);
        static /*0x2a3c770*/ Firebase.FirebaseApp Create();
        static /*0x2a3d664*/ Firebase.LogLevel get_LogLevel();
        static /*0x2a3dcc0*/ void InitializeAppUtilCallbacks();
        static /*0x2a3dadc*/ void OnAllAppsDestroyed();
        static /*0x2a3e9b8*/ bool InitializeCrashlyticsIfPresent();
        static /*0x2a3cab0*/ Firebase.FirebaseApp CreateAndTrack(Firebase.FirebaseApp.CreateDelegate createDelegate, Firebase.FirebaseApp existingProxy);
        static /*0x2a3f464*/ void SetCheckDependenciesThread(int threadId);
        static /*0x2a3c888*/ void ThrowIfCheckDependenciesRunning();
        static /*0x2a3f32c*/ bool IsCheckDependenciesRunning();
        static /*0x2a3f680*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync();
        static /*0x2a3f864*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync();
        static /*0x2a3f9d8*/ Firebase.DependencyStatus CheckDependencies();
        static /*0x2a3fabc*/ Firebase.DependencyStatus CheckDependenciesInternal();
        static /*0x2a3fcc8*/ System.Threading.Tasks.Task FixDependenciesAsync();
        static /*0x2a3fdac*/ void ResetDefaultAppCPtr();
        static /*0x2a3ff78*/ Firebase.FirebaseApp CreateInternal();
        static /*0x2a3d9ac*/ void ReleaseReferenceInternal(Firebase.FirebaseApp app);
        static /*0x2a3f0b8*/ void RegisterLibraryInternal(string library, string version);
        static /*0x2a3f1fc*/ void LogHeartbeatInternal(Firebase.FirebaseApp app);
        static /*0x2a3ed70*/ void AppSetDefaultConfigPath(string path);
        static /*0x2a3c498*/ string get_DefaultName();
        /*0x2a3b914*/ FirebaseApp(nint cPtr, bool cMemoryOwn);
        /*0x2a3b9e8*/ void Finalize();
        /*0x2a3baf8*/ void Dispose();
        /*0x2a3ba54*/ void Dispose(bool disposing);
        /*0x2a3d594*/ string get_Name();
        /*0x2a3d6bc*/ void add_AppDisposed(System.EventHandler value);
        /*0x2a3d75c*/ void remove_AppDisposed(System.EventHandler value);
        /*0x2a3d7fc*/ void AddReference();
        /*0x2a3bc6c*/ void RemoveReference();
        /*0x2a3d5cc*/ void ThrowIfNull();
        /*0x2a3bb68*/ string get_NameInternal();

        class EnableModuleParams
        {
            /*0x10*/ string <CppModuleName>k__BackingField;
            /*0x18*/ string <CSharpClassName>k__BackingField;
            /*0x20*/ bool <AlwaysEnable>k__BackingField;

            /*0x2a3e8cc*/ EnableModuleParams(string csharp, string cpp, bool always);
            /*0x2a44608*/ string get_CppModuleName();
            /*0x2a44610*/ void set_CppModuleName(string value);
            /*0x2a44618*/ string get_CSharpClassName();
            /*0x2a44620*/ void set_CSharpClassName(string value);
            /*0x2a44628*/ bool get_AlwaysEnable();
            /*0x2a44630*/ void set_AlwaysEnable(bool value);
        }

        class CreateDelegate : System.MulticastDelegate
        {
            /*0x2a3ca50*/ CreateDelegate(object object, nint method);
            /*0x2a3ee60*/ Firebase.FirebaseApp Invoke();
            /*0x2a445d0*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a445fc*/ Firebase.FirebaseApp EndInvoke(System.IAsyncResult result);
        }

        class <>c
        {
            static /*0x0*/ Firebase.FirebaseApp.<> <>9;
            static /*0x8*/ Firebase.FirebaseApp.CreateDelegate <>9__14_0;
            static /*0x10*/ System.Func<bool> <>9__46_0;
            static /*0x18*/ System.Func<Firebase.DependencyStatus> <>9__54_0;
            static /*0x20*/ System.Func<System.Threading.Tasks.Task, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__55_1;
            static /*0x28*/ System.Func<System.Threading.Tasks.Task<Firebase.DependencyStatus>, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__55_0;
            static /*0x30*/ System.Action<System.Threading.Tasks.Task> <>9__58_1;

            static /*0x2a43fe8*/ <>c();
            /*0x2a44048*/ <>c();
            /*0x2a44050*/ Firebase.FirebaseApp <Create>b__14_0();
            /*0x2a440a8*/ bool <CreateAndTrack>b__46_0();
            /*0x2a44100*/ Firebase.DependencyStatus <CheckDependenciesAsync>b__54_0();
            /*0x2a44194*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__55_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask);
            /*0x2a44340*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__55_1(System.Threading.Tasks.Task t);
            /*0x2a44398*/ void <FixDependenciesAsync>b__58_1(System.Threading.Tasks.Task t);
        }

        class <>c__DisplayClass56_0
        {
            /*0x10*/ Firebase.DependencyStatus status;

            /*0x2a3fab4*/ <>c__DisplayClass56_0();
            /*0x2a4443c*/ void <CheckDependencies>b__0();
        }

        class <>c__DisplayClass58_0
        {
            /*0x10*/ System.Threading.Tasks.Task task;

            /*0x2a3fda4*/ <>c__DisplayClass58_0();
            /*0x2a444a0*/ void <FixDependenciesAsync>b__0();
        }
    }

    enum LogLevel
    {
        Verbose = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
        Assert = 5,
    }

    enum GooglePlayServicesAvailability
    {
        AvailabilityAvailable = 0,
        AvailabilityUnavailableDisabled = 1,
        AvailabilityUnavailableInvalid = 2,
        AvailabilityUnavailableMissing = 3,
        AvailabilityUnavailablePermissions = 4,
        AvailabilityUnavailableUpdateRequired = 5,
        AvailabilityUnavailableUpdating = 6,
        AvailabilityUnavailableOther = 7,
    }

    class AppUtilPINVOKE
    {
        static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        static /*0x8*/ Firebase.AppUtilPINVOKE.SWIGStringHelper swigStringHelper;

        static /*0x2a3aa18*/ AppUtilPINVOKE();
        static /*0x2a3aad0*/ void delete_FutureBase(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3ab50*/ int FutureBase_status(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3abd0*/ int FutureBase_error(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3ac50*/ string FutureBase_error_message(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3ace8*/ nint FutureString_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureString.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x2a3ad88*/ void FutureString_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2a3ae18*/ string FutureString_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3aeb0*/ void delete_FutureString(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3af30*/ nint FutureVoid_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x2a3afd0*/ void FutureVoid_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2a3b060*/ void delete_FutureVoid(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3b0e0*/ string FirebaseApp_NameInternal_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3b178*/ nint FirebaseApp_CreateInternal__SWIG_0();
        static /*0x2a3b1ec*/ void FirebaseApp_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3b26c*/ int FirebaseApp_GetLogLevelInternal();
        static /*0x2a3b2e0*/ void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);
        static /*0x2a3b398*/ void FirebaseApp_LogHeartbeatInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2a3b418*/ void FirebaseApp_AppSetDefaultConfigPath(string jarg1);
        static /*0x2a3b4a8*/ string FirebaseApp_DefaultName_get();
        static /*0x2a397d8*/ void PollCallbacks();
        static /*0x2a39b78*/ void AppEnableLogCallback(bool jarg1);
        static /*0x2a39ce8*/ void SetEnabledAllAppCallbacks(bool jarg1);
        static /*0x2a39e68*/ void SetEnabledAppCallbackByName(string jarg1, bool jarg2);
        static /*0x2a3a004*/ bool GetEnabledAppCallbackByName(string jarg1);
        static /*0x2a3a190*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate jarg1);
        static /*0x2a3a308*/ int CheckAndroidDependencies();
        static /*0x2a3a430*/ nint FixAndroidDependencies();
        static /*0x2a3a850*/ void InitializePlayServicesInternal();
        static /*0x2a3a9a8*/ void TerminatePlayServicesInternal();
        static /*0x2a3b534*/ nint FutureString_SWIGUpcast(nint jarg1);
        static /*0x2a3b5b4*/ nint FutureVoid_SWIGUpcast(nint jarg1);

        class SWIGExceptionHelper
        {
            static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            static /*0x8*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            static /*0x10*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            static /*0x18*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            static /*0x20*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            static /*0x28*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            static /*0x30*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            static /*0x38*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            static /*0x40*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            static /*0x48*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            static /*0x50*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            static /*0x58*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            static /*0x60*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            static /*0x68*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

            static /*0x2a43950*/ SWIGExceptionHelper();
            static /*0x2a434e4*/ void SWIGRegisterExceptionCallbacks_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            static /*0x2a43658*/ void SWIGRegisterExceptionCallbacksArgument_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
            static /*0x2a42b44*/ void SetPendingApplicationException(string message);
            static /*0x2a42be8*/ void SetPendingArithmeticException(string message);
            static /*0x2a42c8c*/ void SetPendingDivideByZeroException(string message);
            static /*0x2a42d30*/ void SetPendingIndexOutOfRangeException(string message);
            static /*0x2a42dd4*/ void SetPendingInvalidCastException(string message);
            static /*0x2a42e78*/ void SetPendingInvalidOperationException(string message);
            static /*0x2a42f1c*/ void SetPendingIOException(string message);
            static /*0x2a42fc0*/ void SetPendingNullReferenceException(string message);
            static /*0x2a43064*/ void SetPendingOutOfMemoryException(string message);
            static /*0x2a43108*/ void SetPendingOverflowException(string message);
            static /*0x2a431ac*/ void SetPendingSystemException(string message);
            static /*0x2a43250*/ void SetPendingArgumentException(string message, string paramName);
            static /*0x2a432fc*/ void SetPendingArgumentNullException(string message, string paramName);
            static /*0x2a433f0*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
            /*0x2a3aac0*/ SWIGExceptionHelper();

            class ExceptionDelegate : System.MulticastDelegate
            {
                /*0x2a43d10*/ ExceptionDelegate(object object, nint method);
                /*0x2a45798*/ void Invoke(string message);
                /*0x2a45b10*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x2a45b34*/ void EndInvoke(System.IAsyncResult result);
            }

            class ExceptionArgumentDelegate : System.MulticastDelegate
            {
                /*0x2a43d70*/ ExceptionArgumentDelegate(object object, nint method);
                /*0x2a453c8*/ void Invoke(string message, string paramName);
                /*0x2a4575c*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                /*0x2a4578c*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class SWIGPendingException
        {
            static /*0x0*/ int numExceptionsPending;
            static /*0x8*/ object exceptionsLock;
            [ThreadStatic] static System.Exception pendingException;

            static /*0x2a43dd0*/ SWIGPendingException();
            static /*0x2a39848*/ bool get_Pending();
            static /*0x2a43710*/ void Set(System.Exception e);
            static /*0x2a398e4*/ System.Exception Retrieve();
        }

        class SWIGStringHelper
        {
            static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

            static /*0x2a43ef0*/ SWIGStringHelper();
            static /*0x2a43e6c*/ void SWIGRegisterStringCallback_AppUtil(Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            static /*0x2a43e68*/ string CreateString(string cString);
            /*0x2a3aac8*/ SWIGStringHelper();

            class SWIGStringDelegate : System.MulticastDelegate
            {
                /*0x2a43f88*/ SWIGStringDelegate(object object, nint method);
                /*0x2a45b40*/ string Invoke(string message);
                /*0x2a45ec0*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x2a45ee4*/ string EndInvoke(System.IAsyncResult result);
            }
        }
    }

    class AppUtil
    {
        static /*0x2a396f0*/ void PollCallbacks();
        static /*0x2a39a88*/ void AppEnableLogCallback(bool arg0);
        static /*0x2a39bf8*/ void SetEnabledAllAppCallbacks(bool arg0);
        static /*0x2a39d68*/ void SetEnabledAppCallbackByName(string arg0, bool arg1);
        static /*0x2a39f08*/ bool GetEnabledAppCallbackByName(string arg0);
        static /*0x2a3a0a0*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate arg0);
        static /*0x2a3a214*/ Firebase.GooglePlayServicesAvailability CheckAndroidDependencies();
        static /*0x2a3a37c*/ System.Threading.Tasks.Task FixAndroidDependenciesAsync();
        static /*0x2a3a768*/ void InitializePlayServicesInternal();
        static /*0x2a3a8c0*/ void TerminatePlayServicesInternal();
    }

    class VersionInfo
    {
        static /*0x2a3f074*/ string get_SdkVersion();
        static /*0x2a3f1b8*/ string get_BuildSource();
    }

    namespace Platform
    {
        class FirebaseAppUtils : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtils instance;

            static /*0x2a40238*/ FirebaseAppUtils();
            static /*0x2a3ed0c*/ Firebase.Platform.FirebaseAppUtils get_Instance();
            /*0x2a40230*/ FirebaseAppUtils();
            /*0x2a400b4*/ void TranslateDllNotFoundException(System.Action action);
            /*0x2a40114*/ void PollCallbacks();
            /*0x2a40118*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppPlatform
        {
        }
    }

    namespace Internal
    {
        class TaskCompletionSourceCompat<T>
        {
            static void SetExceptionInternal(System.Threading.Tasks.TaskCompletionSource<T> tcs, System.AggregateException exception);
            static void SetException(System.Threading.Tasks.TaskCompletionSource<T> tcs, System.AggregateException exception);
        }
    }
}
