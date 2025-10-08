class <Module>
{
}

namespace Firebase
{
    class AppOptions : System.IDisposable
    {
        /*0x10*/ System.Uri <DatabaseUrl>k__BackingField;
        /*0x18*/ string <AppId>k__BackingField;
        /*0x20*/ string <ApiKey>k__BackingField;
        /*0x28*/ string <MessageSenderId>k__BackingField;
        /*0x30*/ string <StorageBucket>k__BackingField;
        /*0x38*/ string <ProjectId>k__BackingField;
        /*0x40*/ string <PackageName>k__BackingField;

        /*0x2d24b70*/ AppOptions(Firebase.AppOptionsInternal other);
        /*0x2d24b2c*/ void Dispose();
        /*0x2d24b30*/ void set_DatabaseUrl(System.Uri value);
        /*0x2d24b38*/ void set_AppId(string value);
        /*0x2d24b40*/ void set_ApiKey(string value);
        /*0x2d24b48*/ void set_MessageSenderId(string value);
        /*0x2d24b50*/ string get_StorageBucket();
        /*0x2d24b58*/ void set_StorageBucket(string value);
        /*0x2d24b60*/ void set_ProjectId(string value);
        /*0x2d24b68*/ void set_PackageName(string value);
    }

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
        /*0x8c*/ int <ErrorCode>k__BackingField;

        /*0x2d25154*/ FirebaseException(int errorCode, string message);
        /*0x2d251c8*/ int get_ErrorCode();
        /*0x2d251d0*/ void set_ErrorCode(int value);
    }

    class InitializationException : System.Exception
    {
        /*0x8c*/ Firebase.InitResult <InitResult>k__BackingField;

        /*0x2d251e8*/ InitializationException(Firebase.InitResult result);
        /*0x2d25254*/ InitializationException(Firebase.InitResult result, string message);
        /*0x2d252c8*/ InitializationException(Firebase.InitResult result, string message, System.Exception inner);
        /*0x2d251d8*/ Firebase.InitResult get_InitResult();
        /*0x2d251e0*/ void set_InitResult(Firebase.InitResult value);
    }

    class ErrorMessages
    {
        static /*0x0*/ string DEPENDENCY_NOT_FOUND_ERROR_ANDROID;
        static /*0x8*/ string DEPENDENCY_NOT_FOUND_ERROR_IOS;
        static /*0x10*/ string DEPENDENCY_NOT_FOUND_ERROR_GENERIC;
        static /*0x18*/ string DLL_NOT_FOUND_ERROR_ANDROID;
        static /*0x20*/ string DLL_NOT_FOUND_ERROR_IOS;
        static /*0x28*/ string DLL_NOT_FOUND_ERROR_GENERIC;

        static /*0x2d254b4*/ ErrorMessages();
        static /*0x2d2534c*/ string get_DependencyNotFoundErrorMessage();
        static /*0x2d253f0*/ string get_DllNotFoundExceptionErrorMessage();
    }

    class LogUtil : System.IDisposable
    {
        static /*0x0*/ Firebase.LogUtil _instance;
        static /*0x8*/ object InitializeLoggingLock;
        /*0x10*/ bool _disposed;

        static /*0x2d256a0*/ LogUtil();
        static /*0x2d25858*/ void InitializeLogging();
        static /*0x2d25a0c*/ Firebase.Platform.PlatformLogLevel ConvertLogLevel(Firebase.LogLevel logLevel);
        static /*0x2d25a18*/ void LogMessage(Firebase.LogLevel logLevel, string message);
        static /*0x2d255fc*/ void LogMessageFromCallback(Firebase.LogLevel logLevel, string message);
        /*0x2d2575c*/ LogUtil();
        /*0x2d25bfc*/ void Finalize();
        /*0x2d25cc4*/ void Dispose();
        /*0x2d25c98*/ void Dispose(bool disposing);
        /*0x2d25d34*/ void <.ctor>b__9_0(object sender, System.EventArgs e);

        class LogMessageDelegate : System.MulticastDelegate
        {
            /*0x2d25aa8*/ LogMessageDelegate(object object, nint method);
            /*0x2d25d60*/ void Invoke(Firebase.LogLevel log_level, string message);
        }
    }

    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x2d25d74*/ MonoPInvokeCallbackAttribute(System.Type t);
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

        /*0x2d25d7c*/ FutureBase(nint cPtr, bool cMemoryOwn);
        /*0x2d25ddc*/ void Finalize();
        /*0x2d25e6c*/ void Dispose();
        /*0x2d25ed8*/ void Dispose(bool disposing);
        /*0x2d26100*/ Firebase.FutureStatus status();
        /*0x2d2645c*/ int error();
        /*0x2d265a0*/ string error_message();
    }

    class StringStringMap : System.IDisposable, System.Collections.Generic.IDictionary<string, string>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x2d2675c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.StringStringMap obj);
        /*0x2d266fc*/ StringStringMap(nint cPtr, bool cMemoryOwn);
        /*0x2d28218*/ StringStringMap();
        /*0x2d267a0*/ void Finalize();
        /*0x2d26834*/ void Dispose();
        /*0x2d268a4*/ void Dispose(bool disposing);
        /*0x2d26acc*/ string get_Item(string key);
        /*0x2d26ba8*/ void set_Item(string key, string value);
        /*0x2d26c80*/ bool TryGetValue(string key, ref string value);
        /*0x2d26db4*/ int get_Count();
        /*0x2d26e80*/ bool get_IsReadOnly();
        /*0x2d26e88*/ System.Collections.Generic.ICollection<string> get_Keys();
        /*0x2d27238*/ System.Collections.Generic.ICollection<string> get_Values();
        /*0x2d277c0*/ void Add(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x2d279ec*/ bool Remove(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x2d27ae4*/ bool Contains(System.Collections.Generic.KeyValuePair<string, string> item);
        /*0x2d27d24*/ void CopyTo(System.Collections.Generic.KeyValuePair<string, string> array, int arrayIndex);
        /*0x2d28080*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
        /*0x2d281c0*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x2d274e4*/ Firebase.StringStringMap.StringStringMapEnumerator GetEnumerator();
        /*0x2d26db8*/ uint size();
        /*0x2d283b8*/ void Clear();
        /*0x2d26ad0*/ string getitem(string key);
        /*0x2d26bac*/ void setitem(string key, string x);
        /*0x2d26cdc*/ bool ContainsKey(string key);
        /*0x2d27918*/ void Add(string key, string value);
        /*0x2d27c4c*/ bool Remove(string key);
        /*0x2d26fcc*/ nint create_iterator_begin();
        /*0x2d27094*/ string get_next_key(nint swigiterator);
        /*0x2d2716c*/ void destroy_iterator(nint swigiterator);

        class StringStringMapEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable
        {
            /*0x10*/ Firebase.StringStringMap collectionRef;
            /*0x18*/ System.Collections.Generic.IList<string> keyCollection;
            /*0x20*/ int currentIndex;
            /*0x28*/ object currentObject;
            /*0x30*/ int currentSize;

            /*0x2d280d8*/ StringStringMapEnumerator(Firebase.StringStringMap collection);
            /*0x2d2753c*/ System.Collections.Generic.KeyValuePair<string, string> get_Current();
            /*0x2d289fc*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x2d2764c*/ bool MoveNext();
            /*0x2d28a60*/ void Reset();
            /*0x2d28af8*/ void Dispose();
        }
    }

    class StringList : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IList<string>, System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x2d28b6c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.StringList obj);
        /*0x2d28b0c*/ StringList(nint cPtr, bool cMemoryOwn);
        /*0x2d29580*/ StringList();
        /*0x2d28bb0*/ void Finalize();
        /*0x2d28c44*/ void Dispose();
        /*0x2d28cb4*/ void Dispose(bool disposing);
        /*0x2d28edc*/ bool get_IsReadOnly();
        /*0x2d28ee4*/ string get_Item(int index);
        /*0x2d28fc0*/ void set_Item(int index, string value);
        /*0x2d29098*/ int get_Count();
        /*0x2d29164*/ void CopyTo(string[] array, int arrayIndex);
        /*0x2d2919c*/ void CopyTo(int index, string[] array, int arrayIndex, int count);
        /*0x2d2946c*/ System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
        /*0x2d29528*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x2d296a4*/ void Clear();
        /*0x2d297dc*/ void Add(string x);
        /*0x2d2909c*/ uint size();
        /*0x2d29394*/ string getitemcopy(int index);
        /*0x2d28ee8*/ string getitem(int index);
        /*0x2d28fc4*/ void setitem(int index, string val);
        /*0x2d29b9c*/ void Insert(int index, string x);
        /*0x2d29d18*/ void RemoveAt(int index);
        /*0x2d29e68*/ bool Contains(string value);
        /*0x2d29fe4*/ int IndexOf(string value);
        /*0x2d2a15c*/ bool Remove(string value);

        class StringListEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<string>, System.IDisposable
        {
            /*0x10*/ Firebase.StringList collectionRef;
            /*0x18*/ int currentIndex;
            /*0x20*/ object currentObject;
            /*0x28*/ int currentSize;

            /*0x2d294c4*/ StringListEnumerator(Firebase.StringList collection);
            /*0x2d2a2d8*/ string get_Current();
            /*0x2d2a3ac*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x2d2a3b0*/ bool MoveNext();
            /*0x2d2a428*/ void Reset();
            /*0x2d2a4c0*/ void Dispose();
        }
    }

    class FutureString : Firebase.FutureBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.FutureString.Action> Callbacks;
        static /*0x8*/ int CallbackIndex;
        static /*0x10*/ object CallbackLock;
        /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x38*/ nint callbackData;
        /*0x40*/ Firebase.FutureString.SWIG_CompletionDelegate SWIG_CompletionCB;

        static /*0x2d2b5e4*/ FutureString();
        static /*0x2d2abb4*/ System.Threading.Tasks.Task<string> GetTask(Firebase.FutureString fu);
        static /*0x2d2a4d4*/ void SWIG_CompletionDispatcher(int key);
        static /*0x2d2b2bc*/ void SWIG_FreeCompletionData(nint data);
        /*0x2d2a6c8*/ FutureString(nint cPtr, bool cMemoryOwn);
        /*0x2d2a804*/ void Dispose(bool disposing);
        /*0x2d2b0e4*/ void ThrowIfDisposed();
        /*0x2d2ae70*/ void SetOnCompletionCallback(Firebase.FutureString.Action userCompletionCallback);
        /*0x2d2a9cc*/ void SetCompletionData(nint data);
        /*0x2d2b1dc*/ nint SWIG_OnCompletion(Firebase.FutureString.SWIG_CompletionDelegate cs_callback, int cs_key);
        /*0x2d2b488*/ string GetResult();

        class Action : System.MulticastDelegate
        {
            /*0x2d2add4*/ Action(object object, nint method);
            /*0x2d2b664*/ void Invoke();
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x2d2b13c*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x2d2b678*/ void Invoke(int index);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ Firebase.FutureString fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<string> tcs;

            /*0x2d2adcc*/ <>c__DisplayClass5_0();
            /*0x2d2b68c*/ void <GetTask>b__0();
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

        static /*0x2d2c85c*/ FutureVoid();
        static /*0x2d2bf88*/ System.Threading.Tasks.Task GetTask(Firebase.FutureVoid fu);
        static /*0x2d2b8a8*/ void SWIG_CompletionDispatcher(int key);
        static /*0x2d2c690*/ void SWIG_FreeCompletionData(nint data);
        /*0x2d2ba9c*/ FutureVoid(nint cPtr, bool cMemoryOwn);
        /*0x2d2bbd8*/ void Dispose(bool disposing);
        /*0x2d2c4b8*/ void ThrowIfDisposed();
        /*0x2d2c244*/ void SetOnCompletionCallback(Firebase.FutureVoid.Action userCompletionCallback);
        /*0x2d2bda0*/ void SetCompletionData(nint data);
        /*0x2d2c5b0*/ nint SWIG_OnCompletion(Firebase.FutureVoid.SWIG_CompletionDelegate cs_callback, int cs_key);

        class Action : System.MulticastDelegate
        {
            /*0x2d2c1a8*/ Action(object object, nint method);
            /*0x2d2c8dc*/ void Invoke();
        }

        class SWIG_CompletionDelegate : System.MulticastDelegate
        {
            /*0x2d2c510*/ SWIG_CompletionDelegate(object object, nint method);
            /*0x2d2c8f0*/ void Invoke(int index);
        }

        class <>c__DisplayClass5_0
        {
            /*0x10*/ Firebase.FutureVoid fu;
            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<int> tcs;

            /*0x2d2c1a0*/ <>c__DisplayClass5_0();
            /*0x2d2c904*/ void <GetTask>b__0();
        }
    }

    enum InitResult
    {
        Success = 0,
        FailedMissingDependency = 1,
    }

    class AppOptionsInternal : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        /*0x2d2cb40*/ AppOptionsInternal(nint cPtr, bool cMemoryOwn);
        /*0x2d2cba0*/ void Finalize();
        /*0x2d2cdd4*/ void Dispose();
        /*0x2d2cc28*/ void Dispose(bool disposing);
        /*0x2d24c40*/ System.Uri get_DatabaseUrl();
        /*0x2d2ceb4*/ string GetDatabaseUrlInternal();
        /*0x2d24ca4*/ string get_AppId();
        /*0x2d24d6c*/ string get_ApiKey();
        /*0x2d24e34*/ string get_MessageSenderId();
        /*0x2d24efc*/ string get_StorageBucket();
        /*0x2d24fc4*/ string get_ProjectId();
        /*0x2d2508c*/ string get_PackageName();
    }

    class FirebaseApp : System.IDisposable
    {
        static int CheckDependenciesNoThread = -1;
        static int CheckDependenciesPendingThread = -2;
        static /*0x0*/ object disposeLock;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, Firebase.FirebaseApp> nameToProxy;
        static /*0x10*/ System.Collections.Generic.Dictionary<nint, Firebase.FirebaseApp> cPtrToProxy;
        static /*0x18*/ bool AppUtilCallbacksInitialized;
        static /*0x20*/ object AppUtilCallbacksLock;
        static /*0x28*/ bool PreventOnAllAppsDestroyed;
        static /*0x29*/ bool crashlyticsInitializationAttempted;
        static /*0x2a*/ bool userAgentRegistered;
        static /*0x2c*/ int CheckDependenciesThread;
        static /*0x30*/ object CheckDependenciesThreadLock;
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;
        /*0x28*/ string name;
        /*0x30*/ System.EventHandler AppDisposed;
        /*0x38*/ Firebase.Platform.FirebaseAppPlatform appPlatform;

        static /*0x2d2da40*/ FirebaseApp();
        static /*0x2d2d4dc*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.FirebaseApp obj);
        static /*0x2d2dc10*/ void TranslateDllNotFoundException(System.Action closureToExecute);
        static /*0x2d2dd5c*/ Firebase.FirebaseApp get_DefaultInstance();
        static /*0x2d2de88*/ Firebase.FirebaseApp GetInstance(string name);
        static /*0x2d2e048*/ Firebase.FirebaseApp Create();
        static /*0x2d2f010*/ Firebase.LogLevel get_LogLevel();
        static /*0x2d2f644*/ void InitializeAppUtilCallbacks();
        static /*0x2d2f488*/ void OnAllAppsDestroyed();
        static /*0x2d2cf7c*/ System.Uri UrlStringToUri(string urlString);
        static /*0x2d3049c*/ object WeakReferenceGetTarget(System.WeakReference weakReference);
        static /*0x2d3052c*/ bool InitializeCrashlyticsIfPresent();
        static /*0x2d2e394*/ Firebase.FirebaseApp CreateAndTrack(Firebase.FirebaseApp.CreateDelegate createDelegate, Firebase.FirebaseApp existingProxy);
        static /*0x2d30c3c*/ void SetCheckDependenciesThread(int threadId);
        static /*0x2d2e14c*/ void ThrowIfCheckDependenciesRunning();
        static /*0x2d30b18*/ bool IsCheckDependenciesRunning();
        static /*0x2d30e24*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync();
        static /*0x2d30fc8*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync();
        static /*0x2d31114*/ Firebase.DependencyStatus CheckDependencies();
        static /*0x2d311ec*/ Firebase.DependencyStatus CheckDependenciesInternal();
        static /*0x2d314c8*/ System.Threading.Tasks.Task FixDependenciesAsync();
        static /*0x2d315b8*/ void ResetDefaultAppCPtr();
        static /*0x2d31bac*/ Firebase.FirebaseApp CreateInternal();
        static /*0x2d2f39c*/ void ReleaseReferenceInternal(Firebase.FirebaseApp app);
        static /*0x2d308b0*/ void RegisterLibrariesInternal(Firebase.StringStringMap libraries);
        static /*0x2d30a2c*/ void LogHeartbeatInternal(Firebase.FirebaseApp app);
        static /*0x2d30978*/ void AppSetDefaultConfigPath(string path);
        static /*0x2d2ddd0*/ string get_DefaultName();
        /*0x2d2d46c*/ FirebaseApp(nint cPtr, bool cMemoryOwn);
        /*0x2d2d520*/ void Finalize();
        /*0x2d2d664*/ void Dispose();
        /*0x2d2d5a8*/ void Dispose(bool disposing);
        /*0x2d2ef70*/ string get_Name();
        /*0x2d2f0c0*/ void add_AppDisposed(System.EventHandler value);
        /*0x2d2f15c*/ void remove_AppDisposed(System.EventHandler value);
        /*0x2d2f1f8*/ void AddReference();
        /*0x2d2d790*/ void RemoveReference();
        /*0x2d2efb8*/ void ThrowIfNull();
        /*0x2d31930*/ Firebase.AppOptions get_Options();
        /*0x2d319a0*/ Firebase.AppOptionsInternal options();
        /*0x2d2d6c8*/ string get_NameInternal();

        class EnableModuleParams
        {
            /*0x10*/ string <CppModuleName>k__BackingField;
            /*0x18*/ string <CSharpClassName>k__BackingField;
            /*0x20*/ bool <AlwaysEnable>k__BackingField;

            /*0x2d3020c*/ EnableModuleParams(string csharp, string cpp, bool always);
            /*0x2d31f1c*/ string get_CppModuleName();
            /*0x2d31f24*/ void set_CppModuleName(string value);
            /*0x2d31f2c*/ string get_CSharpClassName();
            /*0x2d31f34*/ void set_CSharpClassName(string value);
            /*0x2d31f3c*/ bool get_AlwaysEnable();
            /*0x2d31f44*/ void set_AlwaysEnable(bool value);
        }

        class CreateDelegate : System.MulticastDelegate
        {
            /*0x2d2e2f8*/ CreateDelegate(object object, nint method);
            /*0x2d31f4c*/ Firebase.FirebaseApp Invoke();
        }

        class <>c
        {
            static /*0x0*/ Firebase.FirebaseApp.<> <>9;
            static /*0x8*/ Firebase.FirebaseApp.CreateDelegate <>9__15_0;
            static /*0x10*/ System.Func<bool> <>9__48_0;
            static /*0x18*/ System.Func<Firebase.DependencyStatus> <>9__56_0;
            static /*0x20*/ System.Func<System.Threading.Tasks.Task, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__57_1;
            static /*0x28*/ System.Func<System.Threading.Tasks.Task<Firebase.DependencyStatus>, System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__57_0;
            static /*0x30*/ System.Action<System.Threading.Tasks.Task> <>9__60_1;

            static /*0x2d31f60*/ <>c();
            /*0x2d31fc8*/ <>c();
            /*0x2d31fd0*/ Firebase.FirebaseApp <Create>b__15_0();
            /*0x2d3201c*/ bool <CreateAndTrack>b__48_0();
            /*0x2d32068*/ Firebase.DependencyStatus <CheckDependenciesAsync>b__56_0();
            /*0x2d320e8*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask);
            /*0x2d32274*/ System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(System.Threading.Tasks.Task t);
            /*0x2d322c0*/ void <FixDependenciesAsync>b__60_1(System.Threading.Tasks.Task t);
        }

        class <>c__DisplayClass58_0
        {
            /*0x10*/ Firebase.DependencyStatus status;

            /*0x2d311e4*/ <>c__DisplayClass58_0();
            /*0x2d32358*/ void <CheckDependencies>b__0();
        }

        class <>c__DisplayClass60_0
        {
            /*0x10*/ System.Threading.Tasks.Task task;

            /*0x2d315b0*/ <>c__DisplayClass60_0();
            /*0x2d323b0*/ void <FixDependenciesAsync>b__0();
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

    class VariantVariantMap : System.IDisposable, System.Collections.Generic.IDictionary<Firebase.Variant, Firebase.Variant>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.Collections.IEnumerable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        /*0x2d32558*/ VariantVariantMap(nint cPtr, bool cMemoryOwn);
        /*0x2d325b8*/ void Finalize();
        /*0x2d3264c*/ void Dispose();
        /*0x2d326bc*/ void Dispose(bool disposing);
        /*0x2d328e4*/ Firebase.Variant get_Item(Firebase.Variant key);
        /*0x2d32a08*/ void set_Item(Firebase.Variant key, Firebase.Variant value);
        /*0x2d32b10*/ bool TryGetValue(Firebase.Variant key, ref Firebase.Variant value);
        /*0x2d32c58*/ int get_Count();
        /*0x2d32d24*/ bool get_IsReadOnly();
        /*0x2d32d2c*/ System.Collections.Generic.ICollection<Firebase.Variant> get_Keys();
        /*0x2d33108*/ System.Collections.Generic.ICollection<Firebase.Variant> get_Values();
        /*0x2d33690*/ void Add(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x2d338ec*/ bool Remove(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x2d339e4*/ bool Contains(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> item);
        /*0x2d33c30*/ void CopyTo(System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> array, int arrayIndex);
        /*0x2d33f8c*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant>>.GetEnumerator();
        /*0x2d340cc*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x2d333b4*/ Firebase.VariantVariantMap.VariantVariantMapEnumerator GetEnumerator();
        /*0x2d32c5c*/ uint size();
        /*0x2d341a0*/ void Clear();
        /*0x2d328e8*/ Firebase.Variant getitem(Firebase.Variant key);
        /*0x2d32a0c*/ void setitem(Firebase.Variant key, Firebase.Variant x);
        /*0x2d32b6c*/ bool ContainsKey(Firebase.Variant key);
        /*0x2d337e8*/ void Add(Firebase.Variant key, Firebase.Variant value);
        /*0x2d33b44*/ bool Remove(Firebase.Variant key);
        /*0x2d32e70*/ nint create_iterator_begin();
        /*0x2d32f38*/ Firebase.Variant get_next_key(nint swigiterator);
        /*0x2d3303c*/ void destroy_iterator(nint swigiterator);

        class VariantVariantMapEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant>>, System.IDisposable
        {
            /*0x10*/ Firebase.VariantVariantMap collectionRef;
            /*0x18*/ System.Collections.Generic.IList<Firebase.Variant> keyCollection;
            /*0x20*/ int currentIndex;
            /*0x28*/ object currentObject;
            /*0x30*/ int currentSize;

            /*0x2d33fe4*/ VariantVariantMapEnumerator(Firebase.VariantVariantMap collection);
            /*0x2d3340c*/ System.Collections.Generic.KeyValuePair<Firebase.Variant, Firebase.Variant> get_Current();
            /*0x2d347c4*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x2d3351c*/ bool MoveNext();
            /*0x2d34828*/ void Reset();
            /*0x2d348c0*/ void Dispose();
        }
    }

    class VariantList : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<Firebase.Variant>
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x2d34934*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.VariantList obj);
        /*0x2d348d4*/ VariantList(nint cPtr, bool cMemoryOwn);
        /*0x2d34f84*/ VariantList();
        /*0x2d34978*/ void Finalize();
        /*0x2d34a08*/ void Dispose();
        /*0x2d34a74*/ void Dispose(bool disposing);
        /*0x2d34c9c*/ Firebase.Variant get_Item(int index);
        /*0x2d34da4*/ int get_Count();
        /*0x2d34e70*/ System.Collections.Generic.IEnumerator<Firebase.Variant> global::System.Collections.Generic.IEnumerable<Firebase.Variant>.GetEnumerator();
        /*0x2d34f2c*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
        /*0x2d350a8*/ void Add(Firebase.Variant x);
        /*0x2d34da8*/ uint size();
        /*0x2d34ca0*/ Firebase.Variant getitem(int index);

        class VariantListEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<Firebase.Variant>, System.IDisposable
        {
            /*0x10*/ Firebase.VariantList collectionRef;
            /*0x18*/ int currentIndex;
            /*0x20*/ object currentObject;
            /*0x28*/ int currentSize;

            /*0x2d34ec8*/ VariantListEnumerator(Firebase.VariantList collection);
            /*0x2d3530c*/ Firebase.Variant get_Current();
            /*0x2d35428*/ object global::System.Collections.IEnumerator.get_Current();
            /*0x2d3542c*/ bool MoveNext();
            /*0x2d354a4*/ void Reset();
            /*0x2d3553c*/ void Dispose();
        }
    }

    class Variant : System.IDisposable
    {
        /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
        /*0x20*/ bool swigCMemOwn;

        static /*0x2d342d8*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Variant obj);
        static /*0x2d35874*/ Firebase.Variant FromBlob(byte[] blob);
        static /*0x2d35ab8*/ Firebase.Variant FromObject(object o);
        static /*0x2d36178*/ Firebase.Variant Null();
        static /*0x2d36614*/ Firebase.Variant EmptyVector();
        static /*0x2d367f4*/ Firebase.Variant EmptyMap();
        static /*0x2d35904*/ Firebase.Variant EmptyMutableBlob(uint sizeBytes);
        static /*0x2d36348*/ Firebase.Variant FromInt64(long value);
        static /*0x2d36434*/ Firebase.Variant FromDouble(double value);
        static /*0x2d36528*/ Firebase.Variant FromBool(bool value);
        static /*0x2d3625c*/ Firebase.Variant FromString(string value);
        /*0x2d343a0*/ Variant(nint cPtr, bool cMemoryOwn);
        /*0x2d35550*/ void Finalize();
        /*0x2d355e0*/ void Dispose();
        /*0x2d3564c*/ void Dispose(bool disposing);
        /*0x2d366f8*/ Firebase.VariantList vector();
        /*0x2d368d8*/ Firebase.VariantVariantMap map();
        /*0x2d359f0*/ nint untyped_mutable_blob_data();
    }

    class AppUtilPINVOKE
    {
        static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        static /*0x8*/ Firebase.AppUtilPINVOKE.SWIGStringHelper swigStringHelper;

        static /*0x2d36ef4*/ AppUtilPINVOKE();
        static /*0x2d26084*/ void delete_FutureBase(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d261c8*/ int FutureBase_status(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d26524*/ int FutureBase_error(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d26668*/ string FutureBase_error_message(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d282d8*/ nint new_StringStringMap__SWIG_0();
        static /*0x2d2833c*/ uint StringStringMap_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d28474*/ void StringStringMap_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d284f0*/ string StringStringMap_getitem(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d285a0*/ void StringStringMap_setitem(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        static /*0x2d2865c*/ bool StringStringMap_ContainsKey(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d28700*/ void StringStringMap_Add(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        static /*0x2d287bc*/ bool StringStringMap_Remove(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d28860*/ nint StringStringMap_create_iterator_begin(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d288dc*/ string StringStringMap_get_next_key(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2d28978*/ void StringStringMap_destroy_iterator(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2d26a50*/ void delete_StringStringMap(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d29640*/ nint new_StringList__SWIG_0();
        static /*0x2d29760*/ void StringList_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d298a8*/ void StringList_Add(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d29940*/ uint StringList_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d299bc*/ string StringList_getitemcopy(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x2d29a58*/ string StringList_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x2d29af4*/ void StringList_setitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        static /*0x2d29c70*/ void StringList_Insert(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        static /*0x2d29de4*/ void StringList_RemoveAt(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x2d29f40*/ bool StringList_Contains(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d2a0bc*/ int StringList_IndexOf(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d2a234*/ bool StringList_Remove(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        static /*0x2d28e60*/ void delete_StringList(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2b370*/ nint FutureString_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureString.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x2d2b40c*/ void FutureString_SWIG_FreeCompletionData(nint jarg1);
        static /*0x2d2b550*/ string FutureString_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2ab38*/ void delete_FutureString(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2c744*/ nint FutureVoid_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);
        static /*0x2d2c7e0*/ void FutureVoid_SWIG_FreeCompletionData(nint jarg1);
        static /*0x2d2bf0c*/ void delete_FutureVoid(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d060*/ string AppOptionsInternal_GetDatabaseUrlInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d0f4*/ string AppOptionsInternal_AppId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d188*/ string AppOptionsInternal_ApiKey_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d21c*/ string AppOptionsInternal_MessageSenderId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d2b0*/ string AppOptionsInternal_StorageBucket_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d344*/ string AppOptionsInternal_ProjectId_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2d3d8*/ string AppOptionsInternal_PackageName_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2ce38*/ void delete_AppOptionsInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d31a9c*/ nint FirebaseApp_options(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d31b18*/ string FirebaseApp_NameInternal_get(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d31820*/ nint FirebaseApp_CreateInternal__SWIG_0();
        static /*0x2d31c98*/ void FirebaseApp_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2f05c*/ int FirebaseApp_GetLogLevelInternal();
        static /*0x2d31d14*/ void FirebaseApp_RegisterLibrariesInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d31d90*/ void FirebaseApp_LogHeartbeatInternal(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d31e0c*/ void FirebaseApp_AppSetDefaultConfigPath(string jarg1);
        static /*0x2d31e98*/ string FirebaseApp_DefaultName_get();
        static /*0x2d36fc4*/ void PollCallbacks();
        static /*0x2d37028*/ void AppEnableLogCallback(bool jarg1);
        static /*0x2d370a4*/ void SetEnabledAllAppCallbacks(bool jarg1);
        static /*0x2d37120*/ void SetEnabledAppCallbackByName(string jarg1, bool jarg2);
        static /*0x2d371b4*/ bool GetEnabledAppCallbackByName(string jarg1);
        static /*0x2d3724c*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate jarg1);
        static /*0x2d372cc*/ int CheckAndroidDependencies();
        static /*0x2d37330*/ nint FixAndroidDependencies();
        static /*0x2d37394*/ void InitializePlayServicesInternal();
        static /*0x2d373f8*/ void TerminatePlayServicesInternal();
        static /*0x2d34124*/ uint VariantVariantMap_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d3425c*/ void VariantVariantMap_Clear(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d3431c*/ nint VariantVariantMap_getitem(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x2d34400*/ void VariantVariantMap_setitem(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x2d34494*/ bool VariantVariantMap_ContainsKey(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x2d34520*/ void VariantVariantMap_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2, System.Runtime.InteropServices.HandleRef jarg3);
        static /*0x2d345b4*/ bool VariantVariantMap_Remove(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x2d34640*/ nint VariantVariantMap_create_iterator_begin(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d346bc*/ nint VariantVariantMap_get_next_key(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2d34740*/ void VariantVariantMap_destroy_iterator(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
        static /*0x2d32868*/ void delete_VariantVariantMap(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d35044*/ nint new_VariantList__SWIG_0();
        static /*0x2d35188*/ void VariantList_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
        static /*0x2d3520c*/ uint VariantList_size(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d35288*/ nint VariantList_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        static /*0x2d34c20*/ void delete_VariantList(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d357f8*/ void delete_Variant(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d369d4*/ nint Variant_Null();
        static /*0x2d36a38*/ nint Variant_EmptyVector();
        static /*0x2d36a9c*/ nint Variant_EmptyMap();
        static /*0x2d36b00*/ nint Variant_EmptyMutableBlob(uint jarg1);
        static /*0x2d36b7c*/ nint Variant_vector__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d36bf8*/ nint Variant_map__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d36c74*/ nint Variant_FromInt64(long jarg1);
        static /*0x2d36cf0*/ nint Variant_FromDouble(double jarg1);
        static /*0x2d36d68*/ nint Variant_FromBool(bool jarg1);
        static /*0x2d36de4*/ nint Variant_FromString(string jarg1);
        static /*0x2d36e78*/ nint Variant_untyped_mutable_blob_data(System.Runtime.InteropServices.HandleRef jarg1);
        static /*0x2d2a788*/ nint FutureString_SWIGUpcast(nint jarg1);
        static /*0x2d2bb5c*/ nint FutureVoid_SWIGUpcast(nint jarg1);

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

            static /*0x2d38118*/ SWIGExceptionHelper();
            static /*0x2d37cec*/ void SWIGRegisterExceptionCallbacks_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            static /*0x2d37e58*/ void SWIGRegisterExceptionCallbacksArgument_AppUtil(Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
            static /*0x2d3745c*/ void SetPendingApplicationException(string message);
            static /*0x2d374ec*/ void SetPendingArithmeticException(string message);
            static /*0x2d3757c*/ void SetPendingDivideByZeroException(string message);
            static /*0x2d3760c*/ void SetPendingIndexOutOfRangeException(string message);
            static /*0x2d3769c*/ void SetPendingInvalidCastException(string message);
            static /*0x2d3772c*/ void SetPendingInvalidOperationException(string message);
            static /*0x2d377bc*/ void SetPendingIOException(string message);
            static /*0x2d3784c*/ void SetPendingNullReferenceException(string message);
            static /*0x2d378dc*/ void SetPendingOutOfMemoryException(string message);
            static /*0x2d3796c*/ void SetPendingOverflowException(string message);
            static /*0x2d379fc*/ void SetPendingSystemException(string message);
            static /*0x2d37a8c*/ void SetPendingArgumentException(string message, string paramName);
            static /*0x2d37b2c*/ void SetPendingArgumentNullException(string message, string paramName);
            static /*0x2d37c0c*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
            /*0x2d36fb4*/ SWIGExceptionHelper();

            class ExceptionDelegate : System.MulticastDelegate
            {
                /*0x2d38568*/ ExceptionDelegate(object object, nint method);
                /*0x2d386cc*/ void Invoke(string message);
            }

            class ExceptionArgumentDelegate : System.MulticastDelegate
            {
                /*0x2d38618*/ ExceptionArgumentDelegate(object object, nint method);
                /*0x2d386e0*/ void Invoke(string message, string paramName);
            }
        }

        class SWIGPendingException
        {
            static /*0x0*/ int numExceptionsPending;
            static /*0x8*/ object exceptionsLock;
            [ThreadStatic] static System.Exception pendingException;

            static /*0x2d386f4*/ SWIGPendingException();
            static /*0x2d26244*/ bool get_Pending();
            static /*0x2d37f0c*/ void Set(System.Exception e);
            static /*0x2d262cc*/ System.Exception Retrieve();
        }

        class SWIGStringHelper
        {
            static /*0x0*/ Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

            static /*0x2d38820*/ SWIGStringHelper();
            static /*0x2d387a0*/ void SWIGRegisterStringCallback_AppUtil(Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            static /*0x2d3879c*/ string CreateString(string cString);
            /*0x2d36fbc*/ SWIGStringHelper();

            class SWIGStringDelegate : System.MulticastDelegate
            {
                /*0x2d388cc*/ SWIGStringDelegate(object object, nint method);
                /*0x2d3897c*/ string Invoke(string message);
            }
        }
    }

    class AppUtil
    {
        static /*0x2d38990*/ void PollCallbacks();
        static /*0x2d25958*/ void AppEnableLogCallback(bool arg0);
        static /*0x2d30264*/ void SetEnabledAllAppCallbacks(bool arg0);
        static /*0x2d303d8*/ void SetEnabledAppCallbackByName(string arg0, bool arg1);
        static /*0x2d30318*/ bool GetEnabledAppCallbackByName(string arg0);
        static /*0x2d25b48*/ void SetLogFunction(Firebase.LogUtil.LogMessageDelegate arg0);
        static /*0x2d31410*/ Firebase.GooglePlayServicesAvailability CheckAndroidDependencies();
        static /*0x2d324c0*/ System.Threading.Tasks.Task FixAndroidDependenciesAsync();
        static /*0x2d31774*/ void InitializePlayServicesInternal();
        static /*0x2d31884*/ void TerminatePlayServicesInternal();
    }

    class VersionInfo
    {
        static /*0x2d30830*/ string get_SdkVersion();
        static /*0x2d30870*/ string get_BuildSource();
    }

    namespace Platform
    {
        class FirebaseAppUtils : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtils instance;

            static /*0x2d38b94*/ FirebaseAppUtils();
            static /*0x2d307d8*/ Firebase.Platform.FirebaseAppUtils get_Instance();
            /*0x2d38b8c*/ FirebaseAppUtils();
            /*0x2d38a3c*/ void TranslateDllNotFoundException(System.Action action);
            /*0x2d38a90*/ void PollCallbacks();
            /*0x2d38a94*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppPlatform
        {
            /*0x10*/ System.WeakReference <app>k__BackingField;
        }
    }
}
