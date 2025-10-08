class <Module>
{
}

namespace Firebase
{
    class ExceptionAggregator
    {
        [ThreadStatic] static System.Collections.Generic.List<System.Exception> threadLocalExceptions;

        static /*0x2d463e8*/ System.Collections.Generic.List<System.Exception> get_Exceptions();
        static /*0x2d46498*/ System.Exception GetAndClearPendingExceptions();
        static /*0x2d465e8*/ void ThrowAndClearPendingExceptions();
        static /*0x2d4661c*/ System.Exception LogException(System.Exception exception);
        static /*0x2d46bb4*/ void Wrap(System.Action action);
    }

    class Dispatcher
    {
        /*0x10*/ int ownerThreadId;
        /*0x18*/ System.Collections.Generic.Queue<System.Action> queue;

        static /*0x1f327cc*/ System.Threading.Tasks.Task<TResult> RunAsyncNow<TResult>(System.Func<TResult> callback);
        /*0x2d46c88*/ Dispatcher();
        /*0x1ffc854*/ TResult Run<TResult>(System.Func<TResult> callback);
        /*0x1f302cc*/ System.Threading.Tasks.Task<TResult> RunAsync<TResult>(System.Func<TResult> callback);
        /*0x2d46d30*/ bool ManagesThisThread();
        /*0x2d46d64*/ void PollJobs();

        class CallbackStorage<TResult>
        {
            /*0x0*/ TResult <Result>k__BackingField;
            /*0x0*/ System.Exception <Exception>k__BackingField;

            /*0x1f309e4*/ CallbackStorage();
            /*0x1ffc854*/ TResult get_Result();
            /*0x1ffc854*/ void set_Result(TResult value);
            /*0x1f30214*/ System.Exception get_Exception();
            /*0x1f30ebc*/ void set_Exception(System.Exception value);
        }

        class <>c__DisplayClass4_0<TResult>
        {
            /*0x0*/ Firebase.Dispatcher.CallbackStorage<TResult> result;
            /*0x0*/ System.Func<TResult> callback;
            /*0x0*/ System.Threading.EventWaitHandle waitHandle;

            /*0x1f309e4*/ <>c__DisplayClass4_0();
            /*0x1f309e4*/ void <Run>b__0();
        }

        class <>c__DisplayClass5_0<TResult>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TResult> tcs;
            /*0x0*/ System.Func<TResult> callback;

            /*0x1f309e4*/ <>c__DisplayClass5_0();
            /*0x1f309e4*/ void <RunAsync>b__0();
        }
    }

    namespace Unity
    {
        class UnityLoggingService : Firebase.Platform.ILoggingService
        {
            static /*0x0*/ Firebase.Unity.UnityLoggingService _instance;

            static /*0x2d46f28*/ UnityLoggingService();
            static /*0x2d46ec8*/ Firebase.Unity.UnityLoggingService get_Instance();
            /*0x2d46f20*/ UnityLoggingService();
        }

        class UnityPlatformServices
        {
            static /*0x2d46f90*/ void SetupServices();
        }

        class UnitySynchronizationContext : System.Threading.SynchronizationContext
        {
            static /*0x0*/ Firebase.Unity.UnitySynchronizationContext _instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Threading.ManualResetEvent> signalDictionary;
            /*0x18*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> queue;
            /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir behavior;
            /*0x28*/ int mainThreadId;

            static /*0x2d47880*/ UnitySynchronizationContext();
            static /*0x2d47248*/ void Create(UnityEngine.GameObject gameObject);
            static /*0x2d472ec*/ void Destroy();
            /*0x2d4711c*/ UnitySynchronizationContext(UnityEngine.GameObject gameObject);
            /*0x2d47350*/ System.Threading.ManualResetEvent GetThreadEvent();
            /*0x2d47590*/ void Post(System.Threading.SendOrPostCallback d, object state);
            /*0x2d476e4*/ void Send(System.Threading.SendOrPostCallback d, object state);

            class SynchronizationContextBehavoir : UnityEngine.MonoBehaviour
            {
                /*0x20*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> callbackQueue;

                /*0x2d479c0*/ SynchronizationContextBehavoir();
                /*0x2d471c4*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> get_CallbackQueue();
                /*0x2d4792c*/ System.Collections.IEnumerator Start();

                class <Start>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir <>4__this;
                    /*0x28*/ System.Tuple<System.Threading.SendOrPostCallback, object> <entry>5__1;
                    /*0x30*/ System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback, object>> <>s__2;
                    /*0x38*/ bool <>s__3;
                    /*0x40*/ System.Exception <e>5__4;

                    /*0x2d47998*/ <Start>d__3(int <>1__state);
                    /*0x2d479c8*/ void System.IDisposable.Dispose();
                    /*0x2d479cc*/ bool MoveNext();
                    /*0x2d47dbc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2d47dc4*/ void System.Collections.IEnumerator.Reset();
                    /*0x2d47dfc*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class <SignaledCoroutine>d__13
            {
            }

            class <>c__DisplayClass14_0
            {
                /*0x2d47e04*/ <>c__DisplayClass14_0();
            }

            class <>c__DisplayClass14_1
            {
                /*0x2d47e0c*/ <>c__DisplayClass14_1();
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Threading.SendOrPostCallback d;

                /*0x2d47870*/ <>c__DisplayClass16_0();
            }

            class <>c__DisplayClass16_1
            {
                /*0x10*/ System.Threading.ManualResetEvent newSignal;
                /*0x18*/ Firebase.Unity.UnitySynchronizationContext.<> CS$<>8__locals1;

                /*0x2d47878*/ <>c__DisplayClass16_1();
                /*0x2d47e14*/ void <Send>b__0(object x);
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

            static /*0x2d47f78*/ DebugLogger();
            static /*0x2d47f18*/ Firebase.Platform.DebugLogger get_Instance();
            /*0x2d47f70*/ DebugLogger();
        }

        class Services
        {
            static /*0x0*/ Firebase.Platform.IAppConfigExtensions <AppConfig>k__BackingField;
            static /*0x8*/ Firebase.Platform.IClockService <Clock>k__BackingField;
            static /*0x10*/ Firebase.Platform.ILoggingService <Logging>k__BackingField;

            static /*0x2d47fe0*/ Services();
            static /*0x2d481c0*/ void set_AppConfig(Firebase.Platform.IAppConfigExtensions value);
            static /*0x2d48228*/ void set_Clock(Firebase.Platform.IClockService value);
            static /*0x2d48288*/ void set_Logging(Firebase.Platform.ILoggingService value);
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
            /*0x1f30ebc*/ void TranslateDllNotFoundException(System.Action action);
            /*0x1f309e4*/ void PollCallbacks();
            /*0x1f2ffc8*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class FirebaseAppUtilsStub : Firebase.Platform.IFirebaseAppUtils
        {
            static /*0x0*/ Firebase.Platform.FirebaseAppUtilsStub _instance;

            static /*0x2d48374*/ FirebaseAppUtilsStub();
            static /*0x2d482e8*/ Firebase.Platform.FirebaseAppUtilsStub get_Instance();
            /*0x2d4836c*/ FirebaseAppUtilsStub();
            /*0x2d48340*/ void TranslateDllNotFoundException(System.Action action);
            /*0x2d48360*/ void PollCallbacks();
            /*0x2d48364*/ Firebase.Platform.PlatformLogLevel GetLogLevel();
        }

        class MainThreadProperty<T>
        {
            /*0x0*/ System.Func<T> getPropertyDelegate;
            /*0x0*/ int lastGetPropertyTickCount;
            /*0x0*/ T cachedValue;

            /*0x1f30ebc*/ MainThreadProperty(System.Func<T> getPropertyDelegate);
            /*0x1ffc854*/ T get_Value();
            /*0x1ffc854*/ T <get_Value>b__5_0();
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

            static /*0x2d485b4*/ FirebaseHandler();
            static /*0x2d483dc*/ Firebase.Platform.IFirebaseAppUtils get_AppUtils();
            static /*0x2d48434*/ void set_AppUtils(Firebase.Platform.IFirebaseAppUtils value);
            static /*0x2d48494*/ int get_TickCount();
            static /*0x2d484ec*/ Firebase.Dispatcher get_ThreadDispatcher();
            static /*0x2d48544*/ void set_ThreadDispatcher(Firebase.Dispatcher value);
            static /*0x1ffc854*/ TResult RunOnMainThread<TResult>(System.Func<TResult> f);
            static /*0x1f327cc*/ System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync<TResult>(System.Func<TResult> f);
            static /*0x2d48f30*/ Firebase.Platform.FirebaseHandler get_DefaultInstance();
            static /*0x2d48f88*/ void CreatePartialOnMainThread(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x2d490c0*/ void Create(Firebase.Platform.IFirebaseAppUtils appUtils);
            static /*0x2d493e4*/ void OnMonoBehaviourDestroyed(Firebase.Platform.FirebaseMonoBehaviour behaviour);
            /*0x2d48690*/ FirebaseHandler();
            /*0x2d485a4*/ bool get_IsPlayMode();
            /*0x2d485ac*/ void set_IsPlayMode(bool value);
            /*0x2d48b30*/ void StartMonoBehaviour();
            /*0x2d48dbc*/ void StopMonoBehaviour();
            /*0x2d49118*/ void Update();
            /*0x2d49300*/ void OnApplicationFocus(bool hasFocus);
            /*0x2d494b0*/ void <Update>b__36_0();

            class ApplicationFocusChangedEventArgs : System.EventArgs
            {
                /*0x10*/ bool <HasFocus>k__BackingField;

                /*0x2d4938c*/ ApplicationFocusChangedEventArgs();
                /*0x2d494d8*/ void set_HasFocus(bool value);
            }

            class <>c
            {
                static /*0x0*/ Firebase.Platform.FirebaseHandler.<> <>9;
                static /*0x8*/ System.Func<bool> <>9__19_0;

                static /*0x2d494e0*/ <>c();
                /*0x2d49548*/ <>c();
                /*0x2d49550*/ bool <StopMonoBehaviour>b__19_0();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ Firebase.Platform.IFirebaseAppUtils appUtils;

                /*0x2d490b8*/ <>c__DisplayClass34_0();
                /*0x2d49660*/ void <CreatePartialOnMainThread>b__0();
            }
        }

        class PlatformInformation
        {
            static /*0x0*/ string runtimeVersion;
            static /*0x8*/ float <RealtimeSinceStartupSafe>k__BackingField;

            static /*0x2d498e4*/ bool get_IsAndroid();
            static /*0x2d49940*/ bool get_IsIOS();
            static /*0x2d499c4*/ string get_DefaultConfigLocation();
            static /*0x2d49ae4*/ float get_RealtimeSinceStartup();
            static /*0x2d49aec*/ void set_RealtimeSinceStartupSafe(float value);
            static /*0x2d49b40*/ string get_RuntimeName();
            static /*0x2d49b80*/ string get_RuntimeVersion();

            class <>c
            {
                static /*0x0*/ Firebase.Platform.PlatformInformation.<> <>9;
                static /*0x8*/ System.Func<string> <>9__6_0;
                static /*0x10*/ System.Func<string> <>9__18_0;

                static /*0x2d49ce8*/ <>c();
                /*0x2d49d50*/ <>c();
                /*0x2d49d58*/ string <get_DefaultConfigLocation>b__6_0();
                /*0x2d49da8*/ string <get_RuntimeVersion>b__18_0();
            }
        }

        class FirebaseLogger
        {
            static /*0x0*/ Firebase.Platform.MainThreadProperty<bool> incompatibleStackUnwindingEnabled;

            static /*0x2d4a1ec*/ FirebaseLogger();
            static /*0x2d49df8*/ bool IsStackTraceLogTypeIncompatibleWithNativeLogs(UnityEngine.StackTraceLogType logType);
            static /*0x2d49e04*/ bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs();
            static /*0x2d4a068*/ bool get_CanRedirectNativeLogs();
            static /*0x2d469ec*/ void LogMessage(Firebase.Platform.PlatformLogLevel logLevel, string message);
        }

        class FirebaseMonoBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x2d4a470*/ FirebaseMonoBehaviour();
            /*0x2d4a2d4*/ Firebase.Platform.FirebaseHandler GetFirebaseHandlerOrDestroyGameObject();
            /*0x2d4a378*/ void OnEnable();
            /*0x2d4a37c*/ void Update();
            /*0x2d4a3f8*/ void OnApplicationFocus(bool hasFocus);
            /*0x2d4a41c*/ void OnDestroy();
        }

        class FirebaseEditorDispatcher
        {
            static /*0x2d4a478*/ System.Type get_EditorApplicationType();
            static /*0x2d4873c*/ bool get_EditorIsPlaying();
            static /*0x2d4a500*/ bool get_EditorIsPlayingOrWillChangePlaymode();
            static /*0x2d48cb0*/ void StartEditorUpdate();
            static /*0x2d4a7e4*/ void StopEditorUpdate();
            static /*0x2d4a8dc*/ void Update();
            static /*0x2d48834*/ void ListenToPlayState(bool start);
            static /*0x2d4a934*/ void PlayModeStateChanged();
            static /*0x1ffc854*/ void PlayModeStateChangedWithArg<T>(T t);
            static /*0x2d4a5f8*/ void AddRemoveCallbackToField(System.Reflection.FieldInfo eventField, System.Action callback, object target, bool add, string errorMessage);
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

                static /*0x2d4aa2c*/ AppConfigExtensions();
                static /*0x2d48168*/ Firebase.Platform.IAppConfigExtensions get_Instance();
                /*0x2d4aa24*/ AppConfigExtensions();
            }

            class SystemClock : Firebase.Platform.IClockService
            {
                static /*0x0*/ Firebase.Platform.IClockService Instance;

                static /*0x2d4abbc*/ SystemClock();
                /*0x2d4abb4*/ SystemClock();
            }

            class UnityConfigExtensions : Firebase.Platform.Default.AppConfigExtensions
            {
                static /*0x0*/ Firebase.Platform.Default.UnityConfigExtensions _instance;

                static /*0x2d4ac7c*/ UnityConfigExtensions();
                static /*0x2d470c4*/ Firebase.Platform.IAppConfigExtensions get_DefaultInstance();
                /*0x2d4ac24*/ UnityConfigExtensions();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 49099593592620E150DA54A7EF0F932A27DCDB0B8F245B90432DA0E622C461C1;

    struct __StaticArrayInitTypeSize=20
    {
    }
}
