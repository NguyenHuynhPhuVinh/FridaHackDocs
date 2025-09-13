class <Module>
{
}

namespace Firebase
{
    class ExceptionAggregator
    {
        [ThreadStatic] static System.Collections.Generic.List<System.Exception> threadLocalExceptions;

        static /*0x2ae05ec*/ ExceptionAggregator();
        static /*0x2adfd50*/ System.Collections.Generic.List<System.Exception> get_Exceptions();
        static /*0x2adfe3c*/ System.Exception GetAndClearPendingExceptions();
        static /*0x2adff64*/ void ThrowAndClearPendingExceptions();
        static /*0x2ae0020*/ System.Exception LogException(System.Exception exception);
        static /*0x2adfc4c*/ void Wrap(System.Action action);
        static T Wrap<T>(System.Func<T> func, T errorValue);
    }

    class Dispatcher
    {
        /*0x10*/ int ownerThreadId;
        /*0x18*/ System.Collections.Generic.Queue<System.Action> queue;

        static System.Threading.Tasks.Task<TResult> RunAsyncNow<TResult>(System.Func<TResult> callback);
        /*0x2adf9d0*/ Dispatcher();
        TResult Run<TResult>(System.Func<TResult> callback);
        System.Threading.Tasks.Task<TResult> RunAsync<TResult>(System.Func<TResult> callback);
        /*0x2adfa68*/ bool ManagesThisThread();
        /*0x2adfaa8*/ void PollJobs();

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

            static /*0x2ae3190*/ UnityLoggingService();
            static /*0x2ae3124*/ Firebase.Unity.UnityLoggingService get_Instance();
            /*0x2ae3188*/ UnityLoggingService();
        }

        class UnityPlatformServices
        {
            static /*0x2ae1e78*/ void SetupServices();
        }

        class UnitySynchronizationContext : System.Threading.SynchronizationContext
        {
            static /*0x0*/ Firebase.Unity.UnitySynchronizationContext _instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Threading.ManualResetEvent> signalDictionary;
            /*0x18*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> queue;
            /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir behavior;
            /*0x28*/ int mainThreadId;

            static /*0x2ae3870*/ UnitySynchronizationContext();
            static /*0x2ae1c3c*/ void Create(UnityEngine.GameObject gameObject);
            static /*0x2ae3304*/ void Destroy();
            /*0x2ae31f0*/ UnitySynchronizationContext(UnityEngine.GameObject gameObject);
            /*0x2ae3368*/ System.Threading.ManualResetEvent GetThreadEvent();
            /*0x2ae35ac*/ void Post(System.Threading.SendOrPostCallback d, object state);
            /*0x2ae3704*/ void Send(System.Threading.SendOrPostCallback d, object state);

            class SynchronizationContextBehavoir : UnityEngine.MonoBehaviour
            {
                /*0x18*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> callbackQueue;

                /*0x2ae3fe4*/ SynchronizationContextBehavoir();
                /*0x2ae3288*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> get_CallbackQueue();
                /*0x2ae3f4c*/ System.Collections.IEnumerator Start();

                class <Start>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir <>4__this;
                    /*0x28*/ System.Tuple<System.Threading.SendOrPostCallback, object> <entry>5__1;
                    /*0x30*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> <>s__2;
                    /*0x38*/ bool <>s__3;
                    /*0x40*/ System.Exception <e>5__4;

                    /*0x2ae3fb8*/ <Start>d__3(int <>1__state);
                    /*0x2ae3fec*/ void System.IDisposable.Dispose();
                    /*0x2ae3ff0*/ bool MoveNext();
                    /*0x2ae42a0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ae42a8*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ae42e8*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class <SignaledCoroutine>d__13
            {
            }

            class <>c__DisplayClass14_0
            {
                /*0x2ae3e1c*/ <>c__DisplayClass14_0();
            }

            class <>c__DisplayClass14_1
            {
                /*0x2ae3e24*/ <>c__DisplayClass14_1();
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Threading.SendOrPostCallback d;

                /*0x2ae3860*/ <>c__DisplayClass16_0();
            }

            class <>c__DisplayClass16_1
            {
                /*0x10*/ System.Threading.ManualResetEvent newSignal;
                /*0x18*/ Firebase.Unity.UnitySynchronizationContext.<> CS$<>8__locals1;

                /*0x2ae3868*/ <>c__DisplayClass16_1();
                /*0x2ae3e2c*/ void <Send>b__0(object x);
            }
        }
    }

    namespace Platform
    {
        interface IAppConfigExtensions
        {
        }

        interface IClockService
        {
        }

        interface ILoggingService
        {
        }

        class DebugLogger : Firebase.Platform.ILoggingService
        {
            static /*0x0*/ Firebase.Platform.DebugLogger _instance;

            static /*0x2adf970*/ DebugLogger();
            static /*0x2adf904*/ Firebase.Platform.DebugLogger get_Instance();
            /*0x2adf968*/ DebugLogger();
        }

        class Services
        {
            static /*0x0*/ Firebase.Platform.IAppConfigExtensions <AppConfig>k__BackingField;
            static /*0x8*/ Firebase.Platform.IClockService <Clock>k__BackingField;
            static /*0x10*/ Firebase.Platform.ILoggingService <Logging>k__BackingField;

            static /*0x2ae2cb8*/ Services();
            static /*0x2ae2e60*/ void set_AppConfig(Firebase.Platform.IAppConfigExtensions value);
            static /*0x2ae2ec8*/ void set_Clock(Firebase.Platform.IClockService value);
            static /*0x2ae2f30*/ void set_Logging(Firebase.Platform.ILoggingService value);
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
            Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppUtilsStub : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtilsStub _instance;

            static /*0x2ae06cc*/ FirebaseAppUtilsStub();
            static /*0x2ae0638*/ Firebase.Platform.FirebaseAppUtilsStub get_Instance();
            /*0x2ae06c4*/ FirebaseAppUtilsStub();
            /*0x2ae069c*/ void TranslateDllNotFoundException(System.Action action);
            /*0x2ae06b8*/ void PollCallbacks();
            /*0x2ae06bc*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
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

            static /*0x2ae1af4*/ FirebaseHandler();
            static /*0x2ae18e4*/ Firebase.Platform.IFirebaseAppUtils get_AppUtils();
            static /*0x2ae1948*/ void set_AppUtils(Firebase.Platform.IFirebaseAppUtils value);
            static /*0x2ae19b0*/ int get_TickCount();
            static /*0x2ae1a14*/ Firebase.Dispatcher get_ThreadDispatcher();
            static /*0x2ae1a78*/ void set_ThreadDispatcher(Firebase.Dispatcher value);
            static TResult RunOnMainThread<TResult>(System.Func<TResult> f);
            static System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync<TResult>(System.Func<TResult> f);
            static /*0x2ae0ea4*/ Firebase.Platform.FirebaseHandler get_DefaultInstance();
            static /*0x2ae1ce4*/ void CreatePartialOnMainThread(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x2ae1e14*/ void Create(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x2ae20dc*/ void OnMonoBehaviourDestroyed(Firebase.Platform.FirebaseMonoBehaviour behaviour);
            /*0x2ae1bd4*/ FirebaseHandler();
            /*0x2ae1ae0*/ bool get_IsPlayMode();
            /*0x2ae1ae8*/ void set_IsPlayMode(bool value);
            /*0x2ae159c*/ void StartMonoBehaviour();
            /*0x2ae1730*/ void StopMonoBehaviour();
            /*0x2ae0f08*/ void Update();
            /*0x2ae1fcc*/ void OnApplicationFocus(bool hasFocus);
            /*0x2ae21b4*/ void <Update>b__36_0();

            class ApplicationFocusChangedEventArgs : System.EventArgs
            {
                /*0x10*/ bool <HasFocus>k__BackingField;

                /*0x2ae2078*/ ApplicationFocusChangedEventArgs();
                /*0x2ae3d98*/ void set_HasFocus(bool value);
            }

            class <>c
            {
                static /*0x0*/ Firebase.Platform.FirebaseHandler.<> <>9;
                static /*0x8*/ System.Func<bool> <>9__19_0;

                static /*0x2ae3904*/ <>c();
                /*0x2ae3964*/ <>c();
                /*0x2ae396c*/ bool <StopMonoBehaviour>b__19_0();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ Firebase.Platform.IFirebaseAppUtils appUtils;

                /*0x2ae1e0c*/ <>c__DisplayClass34_0();
                /*0x2ae3ab0*/ void <CreatePartialOnMainThread>b__0();
            }
        }

        class PlatformInformation
        {
            static /*0x0*/ string runtimeVersion;
            static /*0x8*/ float <RealtimeSinceStartupSafe>k__BackingField;

            static /*0x2ae290c*/ bool get_IsAndroid();
            static /*0x2ae292c*/ bool get_IsIOS();
            static /*0x2ae2964*/ string get_DefaultConfigLocation();
            static /*0x2ae2868*/ float get_RealtimeSinceStartup();
            static /*0x2ae2aa0*/ void set_RealtimeSinceStartupSafe(float value);
            static /*0x2ae2af8*/ string get_RuntimeName();
            static /*0x2ae2b3c*/ string get_RuntimeVersion();

            class <>c
            {
                static /*0x0*/ Firebase.Platform.PlatformInformation.<> <>9;
                static /*0x8*/ System.Func<string> <>9__6_0;
                static /*0x10*/ System.Func<string> <>9__18_0;

                static /*0x2ae3da4*/ <>c();
                /*0x2ae3e04*/ <>c();
                /*0x2ae3e0c*/ string <get_DefaultConfigLocation>b__6_0();
                /*0x2ae3e14*/ string <get_RuntimeVersion>b__18_0();
            }
        }

        class FirebaseLogger
        {
            static /*0x0*/ Firebase.Platform.MainThreadProperty<bool> incompatibleStackUnwindingEnabled;

            static /*0x2ae2648*/ FirebaseLogger();
            static /*0x2ae2210*/ bool IsStackTraceLogTypeIncompatibleWithNativeLogs(UnityEngine.StackTraceLogType logType);
            static /*0x2ae221c*/ bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs();
            static /*0x2ae24a4*/ bool get_CanRedirectNativeLogs();
            static /*0x2ae03f0*/ void LogMessage(Firebase.Platform.PlatformLogLevel logLevel, string message);
        }

        class FirebaseMonoBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x2ae2904*/ FirebaseMonoBehaviour();
            /*0x2ae272c*/ Firebase.Platform.FirebaseHandler GetFirebaseHandlerOrDestroyGameObject();
            /*0x2ae27e4*/ void OnEnable();
            /*0x2ae27e8*/ void Update();
            /*0x2ae2870*/ void OnApplicationFocus(bool hasFocus);
            /*0x2ae28a4*/ void OnDestroy();
        }

        class FirebaseEditorDispatcher
        {
            static /*0x2ae072c*/ System.Type get_EditorApplicationType();
            static /*0x2ae07cc*/ bool get_EditorIsPlaying();
            static /*0x2ae08f0*/ bool get_EditorIsPlayingOrWillChangePlaymode();
            static /*0x2ae0a14*/ void StartEditorUpdate();
            static /*0x2ae0d30*/ void StopEditorUpdate();
            static /*0x2ae0e40*/ void Update();
            static /*0x2ae1158*/ void ListenToPlayState(bool start);
            static /*0x2ae1488*/ void PlayModeStateChanged();
            static void PlayModeStateChangedWithArg<T>(T t);
            static /*0x2ae0b38*/ void AddRemoveCallbackToField(System.Reflection.FieldInfo eventField, System.Action callback, object target, bool add, string errorMessage);
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

                static /*0x2adf7bc*/ AppConfigExtensions();
                static /*0x2adf750*/ Firebase.Platform.IAppConfigExtensions get_Instance();
                /*0x2adf7b4*/ AppConfigExtensions();
            }

            class SystemClock : Firebase.Platform.IClockService
            {
                static /*0x0*/ Firebase.Platform.IClockService Instance;

                static /*0x2ae2fa0*/ SystemClock();
                /*0x2ae2f98*/ SystemClock();
            }

            class UnityConfigExtensions : Firebase.Platform.Default.AppConfigExtensions
            {
                static /*0x0*/ Firebase.Platform.Default.UnityConfigExtensions _instance;

                static /*0x2ae30c8*/ UnityConfigExtensions();
                static /*0x2ae3000*/ Firebase.Platform.IAppConfigExtensions get_DefaultInstance();
                /*0x2ae3064*/ UnityConfigExtensions();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2645F90AC4AC37B7007C26BF8B1EF0A570251899;

    struct __StaticArrayInitTypeSize=20
    {
    }
}
