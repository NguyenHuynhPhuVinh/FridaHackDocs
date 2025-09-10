class <Module>
{
}

namespace Firebase
{
    class ExceptionAggregator
    {
        [ThreadStatic] static System.Collections.Generic.List<System.Exception> threadLocalExceptions;

        static /*0x16a06f0*/ System.Collections.Generic.List<System.Exception> get_Exceptions();
        static /*0x16a07a0*/ System.Exception GetAndClearPendingExceptions();
        static /*0x16a08c0*/ void ThrowAndClearPendingExceptions();
        static /*0x16a08f4*/ System.Exception LogException(System.Exception exception);
        static /*0x16a0f00*/ void Wrap(System.Action action);
        static T Wrap<T>(System.Func<T> func, T errorValue);
        /*0x16a1018*/ ExceptionAggregator();
    }

    class Dispatcher
    {
        /*0x10*/ int ownerThreadId;
        /*0x18*/ System.Collections.Generic.Queue<System.Action> queue;

        static System.Threading.Tasks.Task<TResult> RunAsyncNow<TResult>(System.Func<TResult> callback);
        /*0x16a1020*/ Dispatcher();
        TResult Run<TResult>(System.Func<TResult> callback);
        System.Threading.Tasks.Task<TResult> RunAsync<TResult>(System.Func<TResult> callback);
        /*0x16a10b8*/ bool ManagesThisThread();
        /*0x16a10ec*/ void PollJobs();

        class CallbackStorage<TResult>
        {
            /*0x0*/ TResult <Result>k__BackingField;
            /*0x0*/ System.Exception <Exception>k__BackingField;

            CallbackStorage();
            TResult get_Result();
            void set_Result(TResult value);
            System.Exception get_Exception();
            void set_Exception(System.Exception value);
        }

        class <>c__DisplayClass4_0<TResult>
        {
            /*0x0*/ Firebase.Dispatcher.CallbackStorage<TResult> result;
            /*0x0*/ System.Func<TResult> callback;
            /*0x0*/ System.Threading.EventWaitHandle waitHandle;

            <>c__DisplayClass4_0();
            void <Run>b__0();
        }

        class <>c__DisplayClass5_0<TResult>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TResult> tcs;
            /*0x0*/ System.Func<TResult> callback;

            <>c__DisplayClass5_0();
            void <RunAsync>b__0();
        }
    }

    namespace Unity
    {
        class UnityLoggingService : Firebase.Platform.ILoggingService
        {
            static /*0x0*/ Firebase.Unity.UnityLoggingService _instance;

            static /*0x16a12d4*/ UnityLoggingService();
            static /*0x16a1210*/ Firebase.Unity.UnityLoggingService get_Instance();
            /*0x16a12cc*/ UnityLoggingService();
            /*0x16a1268*/ void LogMessage(Firebase.Platform.PlatformLogLevel level, string message);
        }

        class UnityPlatformServices
        {
            static /*0x16a1338*/ void SetupServices();
            /*0x16a14b0*/ UnityPlatformServices();
        }

        class UnitySynchronizationContext : System.Threading.SynchronizationContext
        {
            static int Timeout = 15000;
            static /*0x0*/ Firebase.Unity.UnitySynchronizationContext _instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Threading.ManualResetEvent> signalDictionary;
            /*0x18*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> queue;
            /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir behavior;
            /*0x28*/ int mainThreadId;

            static /*0x16a1f00*/ UnitySynchronizationContext();
            static /*0x16a15c4*/ Firebase.Unity.UnitySynchronizationContext get_Instance();
            static /*0x16a1684*/ void Create(UnityEngine.GameObject gameObject);
            static /*0x16a1718*/ void Destroy();
            /*0x16a14b8*/ UnitySynchronizationContext(UnityEngine.GameObject gameObject);
            /*0x16a1770*/ System.Threading.ManualResetEvent GetThreadEvent();
            /*0x16a198c*/ void PostCoroutine(System.Func<System.Collections.IEnumerator> coroutine);
            /*0x16a1a24*/ System.Collections.IEnumerator SignaledCoroutine(System.Func<System.Collections.IEnumerator> coroutine, System.Threading.ManualResetEvent newSignal);
            /*0x16a1ac8*/ void SendCoroutine(System.Func<System.Collections.IEnumerator> coroutine, int timeout);
            /*0x16a1c44*/ void Post(System.Threading.SendOrPostCallback d, object state);
            /*0x16a1d8c*/ void Send(System.Threading.SendOrPostCallback d, object state);
            /*0x16a1f98*/ void <PostCoroutine>b__12_0(object x);

            class SynchronizationContextBehavoir : UnityEngine.MonoBehaviour
            {
                /*0x18*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> callbackQueue;

                /*0x16a20bc*/ SynchronizationContextBehavoir();
                /*0x16a1544*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> get_CallbackQueue();
                /*0x16a202c*/ System.Collections.IEnumerator Start();

                class <Start>d__3 : System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir <>4__this;
                    /*0x28*/ System.Tuple<System.Threading.SendOrPostCallback, object> <entry>5__1;
                    /*0x30*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> <>s__2;
                    /*0x38*/ System.Exception <e>5__3;

                    /*0x16a2094*/ <Start>d__3(int <>1__state);
                    /*0x16a20c4*/ void System.IDisposable.Dispose();
                    /*0x16a20c8*/ bool MoveNext();
                    /*0x16a2324*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x16a232c*/ void System.Collections.IEnumerator.Reset();
                    /*0x16a236c*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class <SignaledCoroutine>d__13 : System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ System.Func<System.Collections.IEnumerator> coroutine;
                /*0x28*/ System.Threading.ManualResetEvent newSignal;
                /*0x30*/ Firebase.Unity.UnitySynchronizationContext <>4__this;

                /*0x16a1aa0*/ <SignaledCoroutine>d__13(int <>1__state);
                /*0x16a2374*/ void System.IDisposable.Dispose();
                /*0x16a2378*/ bool MoveNext();
                /*0x16a23e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x16a23f0*/ void System.Collections.IEnumerator.Reset();
                /*0x16a2430*/ object System.Collections.IEnumerator.get_Current();
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ Firebase.Unity.UnitySynchronizationContext <>4__this;
                /*0x18*/ System.Func<System.Collections.IEnumerator> coroutine;

                /*0x16a1c34*/ <>c__DisplayClass14_0();
            }

            class <>c__DisplayClass14_1
            {
                /*0x10*/ System.Threading.ManualResetEvent newSignal;
                /*0x18*/ Firebase.Unity.UnitySynchronizationContext.<> CS$<>8__locals1;

                /*0x16a1c3c*/ <>c__DisplayClass14_1();
                /*0x16a2438*/ System.Collections.IEnumerator <SendCoroutine>b__0();
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Threading.SendOrPostCallback d;

                /*0x16a1ef0*/ <>c__DisplayClass16_0();
            }

            class <>c__DisplayClass16_1
            {
                /*0x10*/ System.Threading.ManualResetEvent newSignal;
                /*0x18*/ Firebase.Unity.UnitySynchronizationContext.<> CS$<>8__locals1;

                /*0x16a1ef8*/ <>c__DisplayClass16_1();
                /*0x16a2464*/ void <Send>b__0(object x);
            }
        }
    }

    namespace Platform
    {
        interface IAppConfigExtensions
        {
            string GetWriteablePath(Firebase.Platform.IFirebaseAppPlatform app);
            void SetDatabaseUrl(Firebase.Platform.IFirebaseAppPlatform app, string databaseUrl);
            string GetDatabaseUrl(Firebase.Platform.IFirebaseAppPlatform app);
            void SetEditorP12Password(Firebase.Platform.IFirebaseAppPlatform app, string p12Password);
            string GetEditorP12Password(Firebase.Platform.IFirebaseAppPlatform app);
            void SetEditorP12FileName(Firebase.Platform.IFirebaseAppPlatform app, string p12Filename);
            string GetEditorP12FileName(Firebase.Platform.IFirebaseAppPlatform app);
            void SetEditorServiceAccountEmail(Firebase.Platform.IFirebaseAppPlatform app, string email);
            string GetEditorServiceAccountEmail(Firebase.Platform.IFirebaseAppPlatform app);
            void SetCertPemFile(Firebase.Platform.IFirebaseAppPlatform app, string certName);
            string GetCertPemFile(Firebase.Platform.IFirebaseAppPlatform app);
            void SetCertUpdateUrl(Firebase.Platform.IFirebaseAppPlatform app, System.Uri certUrl);
            System.Uri GetCertUpdateUrl(Firebase.Platform.IFirebaseAppPlatform app);
        }

        interface IClockService
        {
            System.DateTime get_Now();
            System.DateTime get_UtcNow();
        }

        interface ILoggingService
        {
            void LogMessage(Firebase.Platform.PlatformLogLevel level, string message);
        }

        class DebugLogger : Firebase.Platform.ILoggingService
        {
            static /*0x0*/ Firebase.Platform.DebugLogger _instance;

            static /*0x16a25cc*/ DebugLogger();
            static /*0x16a2568*/ Firebase.Platform.DebugLogger get_Instance();
            /*0x16a25c4*/ DebugLogger();
            /*0x16a25c0*/ void LogMessage(Firebase.Platform.PlatformLogLevel level, string message);
        }

        class Services
        {
            static /*0x0*/ Firebase.Platform.IAppConfigExtensions <AppConfig>k__BackingField;
            static /*0x8*/ Firebase.Platform.IClockService <Clock>k__BackingField;
            static /*0x10*/ Firebase.Platform.ILoggingService <Logging>k__BackingField;

            static /*0x16a2630*/ Services();
            static /*0x16a27f4*/ Firebase.Platform.IAppConfigExtensions get_AppConfig();
            static /*0x16a284c*/ void set_AppConfig(Firebase.Platform.IAppConfigExtensions value);
            static /*0x16a28a8*/ Firebase.Platform.IClockService get_Clock();
            static /*0x16a2900*/ void set_Clock(Firebase.Platform.IClockService value);
            static /*0x16a295c*/ Firebase.Platform.ILoggingService get_Logging();
            static /*0x16a29b4*/ void set_Logging(Firebase.Platform.ILoggingService value);
        }

        enum PlatformLogLevel
        {
            Verbose = 0,
            Debug = 1,
            Info = 2,
            Warning = 3,
            Error = 4,
            Assert = 5,
        }

        interface IFirebaseAppUtils
        {
            void TranslateDllNotFoundException(System.Action action);
            void PollCallbacks();
            Firebase.Platform.IFirebaseAppPlatform GetDefaultInstance();
            string GetDefaultInstanceName();
            Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppUtilsStub : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtilsStub _instance;

            static /*0x16a2ae4*/ FirebaseAppUtilsStub();
            static /*0x16a2a10*/ Firebase.Platform.FirebaseAppUtilsStub get_Instance();
            /*0x16a2adc*/ FirebaseAppUtilsStub();
            /*0x16a2a68*/ void TranslateDllNotFoundException(System.Action action);
            /*0x16a2a88*/ void PollCallbacks();
            /*0x16a2a8c*/ Firebase.Platform.IFirebaseAppPlatform GetDefaultInstance();
            /*0x16a2a94*/ string GetDefaultInstanceName();
            /*0x16a2ad4*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        interface IFirebaseAppPlatform
        {
            object get_AppObject();
            string get_Name();
            System.Uri get_DatabaseUrl();
        }

        class MainThreadProperty<T>
        {
            /*0x0*/ System.Func<T> getPropertyDelegate;
            /*0x0*/ int lastGetPropertyTickCount;
            /*0x0*/ T cachedValue;

            MainThreadProperty(System.Func<T> getPropertyDelegate);
            T get_Value();
            T <get_Value>b__5_0();
        }

        class FirebaseHandler
        {
            static /*0x0*/ Firebase.Platform.FirebaseMonoBehaviour firebaseMonoBehaviour;
            static /*0x8*/ Firebase.Platform.IFirebaseAppUtils <AppUtils>k__BackingField;
            static /*0x10*/ int tickCount;
            static /*0x18*/ Firebase.Dispatcher <ThreadDispatcher>k__BackingField;
            static /*0x20*/ Firebase.Platform.FirebaseHandler firebaseHandler;
            /*0x10*/ bool <IsPlayMode>k__BackingField;
            /*0x18*/ System.EventHandler<System.EventArgs> Updated;
            /*0x20*/ System.Action UpdatedEventWrapper;
            /*0x28*/ System.EventHandler<Firebase.Platform.FirebaseHandler.ApplicationFocusChangedEventArgs> ApplicationFocusChanged;

            static /*0x16a2d1c*/ FirebaseHandler();
            static /*0x16a2b48*/ Firebase.Platform.IFirebaseAppUtils get_AppUtils();
            static /*0x16a2ba0*/ void set_AppUtils(Firebase.Platform.IFirebaseAppUtils value);
            static /*0x16a2bfc*/ int get_TickCount();
            static /*0x16a2c54*/ Firebase.Dispatcher get_ThreadDispatcher();
            static /*0x16a2cac*/ void set_ThreadDispatcher(Firebase.Dispatcher value);
            static TResult RunOnMainThread<TResult>(System.Func<TResult> f);
            static System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync<TResult>(System.Func<TResult> f);
            static /*0x16a390c*/ Firebase.Platform.FirebaseHandler get_DefaultInstance();
            static /*0x16a3964*/ void CreatePartialOnMainThread(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x16a3a84*/ void Create(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x16a3d94*/ void Terminate();
            static /*0x16a3e78*/ void OnMonoBehaviourDestroyed(Firebase.Platform.FirebaseMonoBehaviour behaviour);
            /*0x16a2ddc*/ FirebaseHandler();
            /*0x16a2d08*/ bool get_IsPlayMode();
            /*0x16a2d10*/ void set_IsPlayMode(bool value);
            /*0x16a31ac*/ void StartMonoBehaviour();
            /*0x16a33e8*/ void StopMonoBehaviour();
            /*0x16a3564*/ bool IsMainThread();
            /*0x16a364c*/ void add_Updated(System.EventHandler<System.EventArgs> value);
            /*0x16a36fc*/ void remove_Updated(System.EventHandler<System.EventArgs> value);
            /*0x16a37ac*/ void add_ApplicationFocusChanged(System.EventHandler<Firebase.Platform.FirebaseHandler.ApplicationFocusChangedEventArgs> value);
            /*0x16a385c*/ void remove_ApplicationFocusChanged(System.EventHandler<Firebase.Platform.FirebaseHandler.ApplicationFocusChangedEventArgs> value);
            /*0x16a3adc*/ void Update();
            /*0x16a3cb0*/ void OnApplicationFocus(bool hasFocus);
            /*0x16a3f2c*/ void <Update>b__36_0();

            class ApplicationFocusChangedEventArgs : System.EventArgs
            {
                /*0x10*/ bool <HasFocus>k__BackingField;

                /*0x16a3d3c*/ ApplicationFocusChangedEventArgs();
                /*0x16a3f58*/ bool get_HasFocus();
                /*0x16a3f60*/ void set_HasFocus(bool value);
            }

            class <>c
            {
                static /*0x0*/ Firebase.Platform.FirebaseHandler.<> <>9;
                static /*0x8*/ System.Func<bool> <>9__19_0;

                static /*0x16a3f6c*/ <>c();
                /*0x16a3fd0*/ <>c();
                /*0x16a3fd8*/ bool <StopMonoBehaviour>b__19_0();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ Firebase.Platform.IFirebaseAppUtils appUtils;

                /*0x16a3a7c*/ <>c__DisplayClass34_0();
                /*0x16a40e8*/ void <CreatePartialOnMainThread>b__0();
            }
        }

        class PlatformInformation
        {
            static /*0x0*/ string runtimeVersion;
            static /*0x8*/ float <RealtimeSinceStartupSafe>k__BackingField;

            static /*0x16a4388*/ bool get_IsAndroid();
            static /*0x16a43a4*/ bool get_IsIOS();
            static /*0x16a43c0*/ string get_DefaultConfigLocation();
            static /*0x16a44cc*/ System.Threading.SynchronizationContext get_SynchronizationContext();
            static /*0x16a4518*/ float get_RealtimeSinceStartup();
            static /*0x16a4520*/ float get_RealtimeSinceStartupSafe();
            static /*0x16a4568*/ void set_RealtimeSinceStartupSafe(float value);
            static /*0x16a45bc*/ string get_RuntimeName();
            static /*0x16a45fc*/ string get_RuntimeVersion();

            class <>c
            {
                static /*0x0*/ Firebase.Platform.PlatformInformation.<> <>9;
                static /*0x8*/ System.Func<string> <>9__6_0;
                static /*0x10*/ System.Func<string> <>9__18_0;

                static /*0x16a4750*/ <>c();
                /*0x16a47b4*/ <>c();
                /*0x16a47bc*/ string <get_DefaultConfigLocation>b__6_0();
                /*0x16a47c4*/ string <get_RuntimeVersion>b__18_0();
            }
        }

        class FirebaseLogger
        {
            static /*0x0*/ Firebase.Platform.MainThreadProperty<bool> incompatibleStackUnwindingEnabled;

            static /*0x16a4bc0*/ FirebaseLogger();
            static /*0x16a47cc*/ bool IsStackTraceLogTypeIncompatibleWithNativeLogs(UnityEngine.StackTraceLogType logType);
            static /*0x16a47d8*/ bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs();
            static /*0x16a4a48*/ bool get_CanRedirectNativeLogs();
            static /*0x16a0d48*/ void LogMessage(Firebase.Platform.PlatformLogLevel logLevel, string message);
            /*0x16a4bb8*/ FirebaseLogger();
        }

        class FirebaseMonoBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x16a4e34*/ FirebaseMonoBehaviour();
            /*0x16a4c98*/ Firebase.Platform.FirebaseHandler GetFirebaseHandlerOrDestroyGameObject();
            /*0x16a4d3c*/ void OnEnable();
            /*0x16a4d40*/ void Update();
            /*0x16a4dbc*/ void OnApplicationFocus(bool hasFocus);
            /*0x16a4de0*/ void OnDestroy();
        }

        class FirebaseEditorDispatcher
        {
            static /*0x16a4e3c*/ System.Type get_EditorApplicationType();
            static /*0x16a2e34*/ bool get_EditorIsPlaying();
            static /*0x16a4ed0*/ bool get_EditorIsPlayingOrWillChangePlaymode();
            static /*0x16a3310*/ void StartEditorUpdate();
            static /*0x16a515c*/ void StopEditorUpdate();
            static /*0x16a5220*/ void Update();
            static /*0x16a2ee8*/ void ListenToPlayState(bool start);
            static /*0x16a5278*/ void PlayModeStateChanged();
            static void PlayModeStateChangedWithArg<T>(T t);
            static /*0x16a4f84*/ void AddRemoveCallbackToField(System.Reflection.FieldInfo eventField, System.Action callback, object target, bool add, string errorMessage);
            static /*0x16a3e54*/ void Terminate(bool isPlayMode);
            /*0x16a5368*/ FirebaseEditorDispatcher();
        }

        namespace Default
        {
            class AppConfigExtensions : Firebase.Platform.IAppConfigExtensions
            {
                static /*0x0*/ System.Uri DefaultUpdateUrl;
                static /*0x8*/ string Default;
                static /*0x10*/ object Sync;
                static /*0x18*/ Firebase.Platform.Default.AppConfigExtensions _instance;
                static /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, string>> SStringState;

                static /*0x16a5b6c*/ AppConfigExtensions();
                static /*0x16a279c*/ Firebase.Platform.IAppConfigExtensions get_Instance();
                static T GetState<T>(Firebase.Platform.IFirebaseAppPlatform app, int state, System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, T>> store);
                static void SetState<T>(Firebase.Platform.IFirebaseAppPlatform app, int state, T value, System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, T>> store);
                /*0x16a5370*/ AppConfigExtensions();
                /*0x16a5378*/ string GetWriteablePath(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a53c0*/ void SetDatabaseUrl(Firebase.Platform.IFirebaseAppPlatform app, string databaseUrl);
                /*0x16a544c*/ string GetDatabaseUrl(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a55b8*/ void SetEditorP12Password(Firebase.Platform.IFirebaseAppPlatform app, string p12Password);
                /*0x16a5644*/ string GetEditorP12Password(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a56c0*/ void SetEditorP12FileName(Firebase.Platform.IFirebaseAppPlatform app, string p12Filename);
                /*0x16a574c*/ string GetEditorP12FileName(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a57c8*/ void SetEditorServiceAccountEmail(Firebase.Platform.IFirebaseAppPlatform app, string email);
                /*0x16a5854*/ string GetEditorServiceAccountEmail(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a58d0*/ void SetCertPemFile(Firebase.Platform.IFirebaseAppPlatform app, string certName);
                /*0x16a595c*/ string GetCertPemFile(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a59d8*/ void SetCertUpdateUrl(Firebase.Platform.IFirebaseAppPlatform app, System.Uri certUrl);
                /*0x16a5a84*/ System.Uri GetCertUpdateUrl(Firebase.Platform.IFirebaseAppPlatform app);

                enum ExtraStringState
                {
                    DatabaseUrl = 0,
                    P12FileName = 1,
                    P12Password = 2,
                    ServiceAccountEmail = 3,
                    CertTxtFileName = 4,
                    WebCertUpdateUrl = 5,
                }
            }

            class SystemClock : Firebase.Platform.IClockService
            {
                static /*0x0*/ Firebase.Platform.IClockService Instance;

                static /*0x16a5d74*/ SystemClock();
                /*0x16a5ccc*/ SystemClock();
                /*0x16a5cd4*/ System.DateTime get_Now();
                /*0x16a5d24*/ System.DateTime get_UtcNow();
            }

            class UnityConfigExtensions : Firebase.Platform.Default.AppConfigExtensions
            {
                static /*0x0*/ Firebase.Platform.Default.UnityConfigExtensions _instance;

                static /*0x16a62a8*/ UnityConfigExtensions();
                static /*0x16a1458*/ Firebase.Platform.IAppConfigExtensions get_DefaultInstance();
                /*0x16a6250*/ UnityConfigExtensions();
                /*0x16a5dd8*/ string GetWriteablePath(Firebase.Platform.IFirebaseAppPlatform app);
                /*0x16a5ee4*/ void SetEditorP12FileName(Firebase.Platform.IFirebaseAppPlatform app, string p12Filename);

                class <>c
                {
                    static /*0x0*/ Firebase.Platform.Default.UnityConfigExtensions.<> <>9;
                    static /*0x8*/ System.Func<string> <>9__3_0;
                    static /*0x10*/ System.Func<string> <>9__4_0;

                    static /*0x16a6308*/ <>c();
                    /*0x16a636c*/ <>c();
                    /*0x16a6374*/ string <GetWriteablePath>b__3_0();
                    /*0x16a637c*/ string <SetEditorP12FileName>b__4_0();
                }
            }
        }
    }
}
