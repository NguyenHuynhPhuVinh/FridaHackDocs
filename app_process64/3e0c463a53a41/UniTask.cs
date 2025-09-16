class <Module>
{
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class AsyncMethodBuilderAttribute : System.Attribute
            {
                /*0x10*/ System.Type <BuilderType>k__BackingField;

                /*0x7901ba0*/ AsyncMethodBuilderAttribute(System.Type builderType);
            }
        }
    }
}

namespace Cysharp
{
    namespace Threading
    {
        namespace Tasks
        {
            struct AsyncUnit : System.IEquatable<Cysharp.Threading.Tasks.AsyncUnit>
            {
                static /*0x0*/ Cysharp.Threading.Tasks.AsyncUnit Default;

                /*0x7901bd0*/ int GetHashCode();
                /*0x7901bd8*/ bool Equals(Cysharp.Threading.Tasks.AsyncUnit other);
                /*0x7901be0*/ string ToString();
            }

            class CancellationTokenExtensions
            {
                static /*0x0*/ System.Action<object> cancellationTokenCallback;
                static /*0x8*/ System.Action<object> disposeCallback;

                static /*0x79020d8*/ CancellationTokenExtensions();
                static /*0x7901c20*/ void Callback(object state);
                static /*0x7901cac*/ System.Threading.CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(System.Threading.CancellationToken cancellationToken, System.Action callback);
                static /*0x7901e4c*/ System.Threading.CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(System.Threading.CancellationToken cancellationToken, System.Action<object> callback, object state);
                static /*0x7901ff8*/ void DisposeCallback(object state);
            }

            class CancellationTokenSourceExtensions
            {
                static /*0x0*/ System.Action<object> CancelCancellationTokenSourceStateDelegate;

                static /*0x79023c8*/ CancellationTokenSourceExtensions();
                static /*0x79021bc*/ void CancelCancellationTokenSourceState(object state);
                static /*0x7902240*/ System.IDisposable CancelAfterSlim(System.Threading.CancellationTokenSource cts, int millisecondsDelay, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming);
                static /*0x79022f4*/ System.IDisposable CancelAfterSlim(System.Threading.CancellationTokenSource cts, System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming);
            }

            class EnumerableAsyncExtensions
            {
                static /*0x3830700*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> Select<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, Cysharp.Threading.Tasks.UniTask> selector);
                static /*0x3830700*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<TR>> Select<T, TR>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> selector);
                static /*0x3830700*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> Select<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, int, Cysharp.Threading.Tasks.UniTask> selector);
                static /*0x3830700*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<TR>> Select<T, TR>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, int, Cysharp.Threading.Tasks.UniTask<TR>> selector);
            }

            class EnumeratorAsyncExtensions
            {
                static /*0x7902468*/ Cysharp.Threading.Tasks.UniTask ToUniTask(System.Collections.IEnumerator enumerator, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);

                class EnumeratorPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise> pool;
                    static /*0x10*/ System.Reflection.FieldInfo waitForSeconds_Seconds;
                    /*0x10*/ Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise nextNode;
                    /*0x18*/ System.Collections.IEnumerator innerEnumerator;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ int initialFrame;
                    /*0x2c*/ bool loopRunning;
                    /*0x2d*/ bool calledGetResult;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x7902714*/ EnumeratorPromise();
                    static /*0x7902530*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Collections.IEnumerator innerEnumerator, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    static /*0x7902a8c*/ System.Collections.IEnumerator ConsumeEnumerator(System.Collections.IEnumerator enumerator);
                    static /*0x79031a0*/ System.Collections.IEnumerator UnwrapWaitForSeconds(UnityEngine.WaitForSeconds waitForSeconds);
                    static /*0x7903234*/ System.Collections.IEnumerator UnwrapWaitAsyncOperation(UnityEngine.AsyncOperation asyncOperation);
                    /*0x79029f8*/ EnumeratorPromise();
                    /*0x790270c*/ ref Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise get_NextNode();
                    /*0x7902dec*/ void GetResult(short token);
                    /*0x7902ec4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7902f1c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7902fd4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7902af8*/ bool MoveNext();
                    /*0x7903044*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise.<> <>9;

                        static /*0x79032c8*/ <>c();
                        /*0x7903330*/ <>c();
                        /*0x7903338*/ int <.cctor>b__4_0();
                    }

                    class <ConsumeEnumerator>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ System.Collections.IEnumerator enumerator;
                        /*0x28*/ UnityEngine.CustomYieldInstruction <cyi>5__2;
                        /*0x30*/ System.Collections.IEnumerator <innerCoroutine>5__3;

                        /*0x7903178*/ <ConsumeEnumerator>d__19(int <>1__state);
                        /*0x790339c*/ void System.IDisposable.Dispose();
                        /*0x79033a0*/ bool MoveNext();
                        /*0x790391c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x7903924*/ void System.Collections.IEnumerator.Reset();
                        /*0x790395c*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <UnwrapWaitAsyncOperation>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ UnityEngine.AsyncOperation asyncOperation;

                        /*0x79032a0*/ <UnwrapWaitAsyncOperation>d__22(int <>1__state);
                        /*0x7903964*/ void System.IDisposable.Dispose();
                        /*0x7903968*/ bool MoveNext();
                        /*0x79039c4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x79039cc*/ void System.Collections.IEnumerator.Reset();
                        /*0x7903a04*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <UnwrapWaitForSeconds>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ UnityEngine.WaitForSeconds waitForSeconds;
                        /*0x28*/ float <second>5__2;
                        /*0x2c*/ float <elapsed>5__3;

                        /*0x790320c*/ <UnwrapWaitForSeconds>d__21(int <>1__state);
                        /*0x7903a0c*/ void System.IDisposable.Dispose();
                        /*0x7903a10*/ bool MoveNext();
                        /*0x7903b2c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x7903b34*/ void System.Collections.IEnumerator.Reset();
                        /*0x7903b6c*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            interface IUniTaskAsyncEnumerable<T>
            {
                /*0x380ba14*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);
            }

            interface IUniTaskAsyncEnumerator<T> : Cysharp.Threading.Tasks.IUniTaskAsyncDisposable
            {
                /*0x3907c14*/ T get_Current();
                /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
            }

            interface IUniTaskAsyncDisposable
            {
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
            }

            class UniTaskAsyncEnumerableExtensions
            {
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTaskCancelableAsyncEnumerable<T> WithCancellation<T>(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> source, System.Threading.CancellationToken cancellationToken);
            }

            struct UniTaskCancelableAsyncEnumerable<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> enumerable;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;

                /*0x3907c14*/ UniTaskCancelableAsyncEnumerable(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> enumerable, System.Threading.CancellationToken cancellationToken);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTaskCancelableAsyncEnumerable.Enumerator<T> GetAsyncEnumerator();

                struct Enumerator<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> enumerator;

                    /*0x380d83c*/ Enumerator(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> enumerator);
                    /*0x3907c14*/ T get_Current();
                    /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
                }
            }

            enum UniTaskStatus
            {
                Pending = 0,
                Succeeded = 1,
                Faulted = 2,
                Canceled = 3,
            }

            interface IUniTaskSource
            {
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                void OnCompleted(System.Action<object> continuation, object state, short token);
                void GetResult(short token);
                /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
            }

            interface IUniTaskSource<T> : Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x3907c14*/ T GetResult(short token);
            }

            class UniTaskStatusExtensions
            {
                static /*0x7903b74*/ bool IsCompleted(Cysharp.Threading.Tasks.UniTaskStatus status);
                static /*0x7903b80*/ bool IsCompletedSuccessfully(Cysharp.Threading.Tasks.UniTaskStatus status);
            }

            class MoveNextSource : Cysharp.Threading.Tasks.IUniTaskSource<bool>, Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<bool> completionSource;

                /*0x7903dbc*/ MoveNextSource();
                /*0x7903b8c*/ bool GetResult(short token);
                /*0x7903be4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x7903c3c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x7903cac*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x7903d64*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
            }

            class UniTaskLoopRunners
            {
                struct UniTaskLoopRunnerInitialization
                {
                }

                struct UniTaskLoopRunnerEarlyUpdate
                {
                }

                struct UniTaskLoopRunnerFixedUpdate
                {
                }

                struct UniTaskLoopRunnerPreUpdate
                {
                }

                struct UniTaskLoopRunnerUpdate
                {
                }

                struct UniTaskLoopRunnerPreLateUpdate
                {
                }

                struct UniTaskLoopRunnerPostLateUpdate
                {
                }

                struct UniTaskLoopRunnerLastInitialization
                {
                }

                struct UniTaskLoopRunnerLastEarlyUpdate
                {
                }

                struct UniTaskLoopRunnerLastFixedUpdate
                {
                }

                struct UniTaskLoopRunnerLastPreUpdate
                {
                }

                struct UniTaskLoopRunnerLastUpdate
                {
                }

                struct UniTaskLoopRunnerLastPreLateUpdate
                {
                }

                struct UniTaskLoopRunnerLastPostLateUpdate
                {
                }

                struct UniTaskLoopRunnerYieldInitialization
                {
                }

                struct UniTaskLoopRunnerYieldEarlyUpdate
                {
                }

                struct UniTaskLoopRunnerYieldFixedUpdate
                {
                }

                struct UniTaskLoopRunnerYieldPreUpdate
                {
                }

                struct UniTaskLoopRunnerYieldUpdate
                {
                }

                struct UniTaskLoopRunnerYieldPreLateUpdate
                {
                }

                struct UniTaskLoopRunnerYieldPostLateUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldInitialization
                {
                }

                struct UniTaskLoopRunnerLastYieldEarlyUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldFixedUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldPreUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldPreLateUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldPostLateUpdate
                {
                }

                struct UniTaskLoopRunnerTimeUpdate
                {
                }

                struct UniTaskLoopRunnerLastTimeUpdate
                {
                }

                struct UniTaskLoopRunnerYieldTimeUpdate
                {
                }

                struct UniTaskLoopRunnerLastYieldTimeUpdate
                {
                }
            }

            enum PlayerLoopTiming
            {
                Initialization = 0,
                LastInitialization = 1,
                EarlyUpdate = 2,
                LastEarlyUpdate = 3,
                FixedUpdate = 4,
                LastFixedUpdate = 5,
                PreUpdate = 6,
                LastPreUpdate = 7,
                Update = 8,
                LastUpdate = 9,
                PreLateUpdate = 10,
                LastPreLateUpdate = 11,
                PostLateUpdate = 12,
                LastPostLateUpdate = 13,
                TimeUpdate = 14,
                LastTimeUpdate = 15,
            }

            enum InjectPlayerLoopTimings
            {
                All = 65535,
                Standard = 30037,
                Minimum = 8464,
                Initialization = 1,
                LastInitialization = 2,
                EarlyUpdate = 4,
                LastEarlyUpdate = 8,
                FixedUpdate = 16,
                LastFixedUpdate = 32,
                PreUpdate = 64,
                LastPreUpdate = 128,
                Update = 256,
                LastUpdate = 512,
                PreLateUpdate = 1024,
                LastPreLateUpdate = 2048,
                PostLateUpdate = 4096,
                LastPostLateUpdate = 8192,
                TimeUpdate = 16384,
                LastTimeUpdate = 32768,
            }

            interface IPlayerLoopItem
            {
                /*0x380b128*/ bool MoveNext();
            }

            class PlayerLoopHelper
            {
                static /*0x0*/ Cysharp.Threading.Tasks.Internal.ContinuationQueue ThrowMarkerContinuationQueue;
                static /*0x8*/ Cysharp.Threading.Tasks.Internal.PlayerLoopRunner ThrowMarkerPlayerLoopRunner;
                static /*0x10*/ int mainThreadId;
                static /*0x18*/ string applicationDataPath;
                static /*0x20*/ System.Threading.SynchronizationContext unitySynchronizationContext;
                static /*0x28*/ Cysharp.Threading.Tasks.Internal.ContinuationQueue[] yielders;
                static /*0x30*/ Cysharp.Threading.Tasks.Internal.PlayerLoopRunner[] runners;

                static /*0x7906080*/ PlayerLoopHelper();
                static /*0x7903dc4*/ System.Threading.SynchronizationContext get_UnitySynchronizationContext();
                static /*0x7903e1c*/ int get_MainThreadId();
                static /*0x79030f8*/ bool get_IsMainThread();
                static /*0x7903e74*/ UnityEngine.LowLevel.PlayerLoopSystem[] InsertRunner(UnityEngine.LowLevel.PlayerLoopSystem loopSystem, bool injectOnFirst, System.Type loopRunnerYieldType, Cysharp.Threading.Tasks.Internal.ContinuationQueue cq, System.Type loopRunnerType, Cysharp.Threading.Tasks.Internal.PlayerLoopRunner runner);
                static /*0x79041a8*/ UnityEngine.LowLevel.PlayerLoopSystem[] RemoveRunner(UnityEngine.LowLevel.PlayerLoopSystem loopSystem, System.Type loopRunnerYieldType, System.Type loopRunnerType);
                static /*0x79042d0*/ UnityEngine.LowLevel.PlayerLoopSystem[] InsertUniTaskSynchronizationContext(UnityEngine.LowLevel.PlayerLoopSystem loopSystem);
                static /*0x79046c4*/ void Init();
                static /*0x790538c*/ int FindLoopSystemIndex(UnityEngine.LowLevel.PlayerLoopSystem[] playerLoopList, System.Type systemType);
                static /*0x79054a0*/ void InsertLoop(UnityEngine.LowLevel.PlayerLoopSystem[] copyList, Cysharp.Threading.Tasks.InjectPlayerLoopTimings injectTimings, System.Type loopType, Cysharp.Threading.Tasks.InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, System.Type loopRunnerYieldType, System.Type loopRunnerType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming);
                static /*0x7904890*/ void Initialize(ref UnityEngine.LowLevel.PlayerLoopSystem playerLoop, Cysharp.Threading.Tasks.InjectPlayerLoopTimings injectTimings);
                static /*0x7902d4c*/ void AddAction(Cysharp.Threading.Tasks.PlayerLoopTiming timing, Cysharp.Threading.Tasks.IPlayerLoopItem action);
                static /*0x790598c*/ void ThrowInvalidLoopTiming(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming);
                static /*0x7905d34*/ void AddContinuation(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Action continuation);

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.PlayerLoopHelper.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.LowLevel.PlayerLoopSystem, bool> <>9__21_0;
                    static /*0x10*/ System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__21_1;
                    static /*0x18*/ System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__21_2;

                    static /*0x7906140*/ <>c();
                    /*0x79061a8*/ <>c();
                    /*0x79061b0*/ bool <InsertUniTaskSynchronizationContext>b__21_0(UnityEngine.LowLevel.PlayerLoopSystem ls);
                    /*0x7906228*/ bool <InsertUniTaskSynchronizationContext>b__21_1(UnityEngine.LowLevel.PlayerLoopSystem x);
                    /*0x7906288*/ bool <InsertUniTaskSynchronizationContext>b__21_2(UnityEngine.LowLevel.PlayerLoopSystem x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ System.Type loopRunnerYieldType;
                    /*0x18*/ System.Type loopRunnerType;

                    /*0x79042c8*/ <>c__DisplayClass20_0();
                    /*0x79062e8*/ bool <RemoveRunner>b__0(UnityEngine.LowLevel.PlayerLoopSystem ls);
                }
            }

            class PlayerLoopTimer : System.IDisposable, Cysharp.Threading.Tasks.IPlayerLoopItem
            {
                /*0x10*/ System.Threading.CancellationToken cancellationToken;
                /*0x18*/ System.Action<object> timerCallback;
                /*0x20*/ object state;
                /*0x28*/ Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming;
                /*0x2c*/ bool periodic;
                /*0x2d*/ bool isRunning;
                /*0x2e*/ bool tryStop;
                /*0x2f*/ bool isDisposed;

                static /*0x79063f0*/ Cysharp.Threading.Tasks.PlayerLoopTimer Create(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                static /*0x79023a0*/ Cysharp.Threading.Tasks.PlayerLoopTimer StartNew(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x7906378*/ PlayerLoopTimer(bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x7906750*/ void Restart();
                /*0x380ccb4*/ void ResetCore(System.Nullable<System.TimeSpan> newInterval);
                /*0x790681c*/ void Dispose();
                /*0x7906828*/ bool Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext();
                /*0x380b128*/ bool MoveNextCore();
            }

            class DeltaTimePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ int initialFrame;
                /*0x34*/ float elapsed;
                /*0x38*/ float interval;

                /*0x7906694*/ DeltaTimePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x7906900*/ bool MoveNextCore();
                /*0x790696c*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class IgnoreTimeScalePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ int initialFrame;
                /*0x34*/ float elapsed;
                /*0x38*/ float interval;

                /*0x790651c*/ IgnoreTimeScalePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x7906a6c*/ bool MoveNextCore();
                /*0x7906ad8*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class RealtimePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch;
                /*0x38*/ long intervalTicks;

                /*0x79065d8*/ RealtimePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x7906bd8*/ bool MoveNextCore();
                /*0x7906d44*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class TaskPool
            {
                static /*0x0*/ int MaxPoolSize;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, System.Func<int>> sizes;

                static /*0x7906e68*/ TaskPool();
                static /*0x79028b0*/ void RegisterSizeGetter(System.Type type, System.Func<int> getSize);
            }

            interface ITaskPoolNode<T>
            {
                /*0x380b9e8*/ ref T get_NextNode();
            }

            struct TaskPool<T>
            {
                /*0x0*/ int gate;
                /*0x0*/ int size;
                /*0x0*/ T root;

                /*0x380b6a0*/ int get_Size();
                /*0x380b2f0*/ bool TryPop(ref T result);
                /*0x3907c14*/ bool TryPush(T item);
            }

            interface ITriggerHandler<T>
            {
                /*0x3907c14*/ void OnNext(T value);
                /*0x380cb08*/ void OnCompleted();
                /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> get_Prev();
                /*0x380d83c*/ void set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> get_Next();
                /*0x380d83c*/ void set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
            }

            struct TriggerEvent<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> head;
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> iteratingHead;
                /*0x0*/ bool preserveRemoveSelf;
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> iteratingNode;

                /*0x380d83c*/ void LogError(System.Exception ex);
                /*0x3907c14*/ void SetResult(T value);
                /*0x380cb08*/ void SetCompleted();
                /*0x380d83c*/ void Add(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                /*0x380d83c*/ void Remove(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
            }

            class UniTaskCancellationExtensions
            {
                static /*0x7906fcc*/ System.Threading.CancellationToken GetCancellationTokenOnDestroy(UnityEngine.MonoBehaviour monoBehaviour);
            }

            struct UniTask
            {
                static /*0x0*/ Cysharp.Threading.Tasks.UniTask CanceledUniTask;
                static /*0x10*/ Cysharp.Threading.Tasks.UniTask CompletedTask;
                /*0x10*/ Cysharp.Threading.Tasks.IUniTaskSource source;
                /*0x18*/ short token;

                static /*0x79099dc*/ UniTask();
                static /*0x7907418*/ Cysharp.Threading.Tasks.YieldAwaitable Yield();
                static /*0x7907420*/ Cysharp.Threading.Tasks.YieldAwaitable Yield(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                static /*0x7907428*/ Cysharp.Threading.Tasks.UniTask Yield(System.Threading.CancellationToken cancellationToken);
                static /*0x790763c*/ Cysharp.Threading.Tasks.UniTask NextFrame();
                static /*0x79078b0*/ Cysharp.Threading.Tasks.UniTask WaitForEndOfFrame(UnityEngine.MonoBehaviour coroutineRunner, System.Threading.CancellationToken cancellationToken);
                static /*0x7907ab8*/ Cysharp.Threading.Tasks.UniTask DelayFrame(int delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x7907d8c*/ Cysharp.Threading.Tasks.UniTask Delay(int millisecondsDelay, bool ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x7907e40*/ Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, bool ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x7907ebc*/ Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x79086ac*/ Cysharp.Threading.Tasks.UniTask FromException(System.Exception ex);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> FromException<T>(System.Exception ex);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> FromResult<T>(T value);
                static /*0x790879c*/ Cysharp.Threading.Tasks.UniTask FromCanceled(System.Threading.CancellationToken cancellationToken);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> FromCanceled<T>(System.Threading.CancellationToken cancellationToken);
                static /*0x7908904*/ Cysharp.Threading.Tasks.UniTask Create(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                static /*0x7908928*/ Cysharp.Threading.Tasks.UniTask Defer(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                static /*0x79089dc*/ Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable SwitchToMainThread(System.Threading.CancellationToken cancellationToken);
                static /*0x7908a24*/ Cysharp.Threading.Tasks.UniTask WaitUntil(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);
                static /*0x7908c68*/ Cysharp.Threading.Tasks.UniTask WaitWhile(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T[]> WhenAll<T>(Cysharp.Threading.Tasks.UniTask<T> tasks);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T[]> WhenAll<T>(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<T>> tasks);
                static /*0x7908eac*/ Cysharp.Threading.Tasks.UniTask WhenAll(Cysharp.Threading.Tasks.UniTask[] tasks);
                static /*0x79093a4*/ Cysharp.Threading.Tasks.UniTask WhenAll(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> tasks);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2>> WhenAll<T1, T2>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4, Cysharp.Threading.Tasks.UniTask<T5> task5, Cysharp.Threading.Tasks.UniTask<T6> task6, Cysharp.Threading.Tasks.UniTask<T7> task7);
                static /*0x79094fc*/ Cysharp.Threading.Tasks.UniTask<int> WhenAny(Cysharp.Threading.Tasks.UniTask[] tasks);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<int, T1, T2>> WhenAny<T1, T2>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                /*0x7906fe0*/ UniTask(Cysharp.Threading.Tasks.IUniTaskSource source, short token);
                /*0x7907008*/ Cysharp.Threading.Tasks.UniTaskStatus get_Status();
                /*0x79070bc*/ Cysharp.Threading.Tasks.UniTask.Awaiter GetAwaiter();
                /*0x79070e8*/ Cysharp.Threading.Tasks.UniTask<bool> SuppressCancellationThrow();
                /*0x79072d8*/ string ToString();

                class IsCanceledSource : Cysharp.Threading.Tasks.IUniTaskSource<bool>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ Cysharp.Threading.Tasks.IUniTaskSource source;

                    /*0x79072a8*/ IsCanceledSource(Cysharp.Threading.Tasks.IUniTaskSource source);
                    /*0x7909ad4*/ bool GetResult(short token);
                    /*0x7909c04*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x7909c08*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7909cb0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7909d54*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask task;

                    /*0x7909e18*/ Awaiter(ref Cysharp.Threading.Tasks.UniTask task);
                    /*0x7909e28*/ bool get_IsCompleted();
                    /*0x7909f18*/ void GetResult();
                    /*0x7909fcc*/ void OnCompleted(System.Action continuation);
                    /*0x790a0dc*/ void UnsafeOnCompleted(System.Action continuation);
                    /*0x790a1ec*/ void SourceOnCompleted(System.Action<object> continuation, object state);
                }

                class YieldPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.YieldPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.YieldPromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.YieldPromise nextNode;
                    /*0x18*/ System.Threading.CancellationToken cancellationToken;
                    /*0x20*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x790a2dc*/ YieldPromise();
                    static /*0x79074b0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790a3f0*/ YieldPromise();
                    /*0x790a2d4*/ ref Cysharp.Threading.Tasks.UniTask.YieldPromise get_NextNode();
                    /*0x790a3f8*/ void GetResult(short token);
                    /*0x790a4c4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790a51c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790a5d4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790a644*/ bool MoveNext();
                    /*0x790a6f8*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.YieldPromise.<> <>9;

                        static /*0x790a798*/ <>c();
                        /*0x790a800*/ <>c();
                        /*0x790a808*/ int <.cctor>b__4_0();
                    }
                }

                class NextFramePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.NextFramePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.NextFramePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.NextFramePromise nextNode;
                    /*0x18*/ int frameCount;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x790a874*/ NextFramePromise();
                    static /*0x79076f4*/ Cysharp.Threading.Tasks.IUniTaskSource Create(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790a988*/ NextFramePromise();
                    /*0x790a86c*/ ref Cysharp.Threading.Tasks.UniTask.NextFramePromise get_NextNode();
                    /*0x790a990*/ void GetResult(short token);
                    /*0x790aa5c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790aab4*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790ab6c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790abdc*/ bool MoveNext();
                    /*0x790acc8*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.NextFramePromise.<> <>9;

                        static /*0x790ad68*/ <>c();
                        /*0x790add0*/ <>c();
                        /*0x790add8*/ int <.cctor>b__4_0();
                    }
                }

                class WaitForEndOfFramePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise>, System.Collections.IEnumerator
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise> pool;
                    static /*0x10*/ UnityEngine.WaitForEndOfFrame waitForEndOfFrameYieldInstruction;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise nextNode;
                    /*0x18*/ System.Threading.CancellationToken cancellationToken;
                    /*0x20*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;
                    /*0x48*/ bool isFirst;

                    static /*0x790ae44*/ WaitForEndOfFramePromise();
                    static /*0x7907944*/ Cysharp.Threading.Tasks.IUniTaskSource Create(UnityEngine.MonoBehaviour coroutineRunner, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790afb0*/ WaitForEndOfFramePromise();
                    /*0x790ae3c*/ ref Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise get_NextNode();
                    /*0x790afc0*/ void GetResult(short token);
                    /*0x790b08c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790b0e4*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790b19c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790b20c*/ bool TryReturn();
                    /*0x790b2c0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x790b318*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x790b2b4*/ void Reset();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise.<> <>9;

                        static /*0x790b3e0*/ <>c();
                        /*0x790b448*/ <>c();
                        /*0x790b450*/ int <.cctor>b__4_0();
                    }
                }

                class DelayFramePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.DelayFramePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.DelayFramePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.DelayFramePromise nextNode;
                    /*0x18*/ int initialFrame;
                    /*0x1c*/ int delayFrameCount;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ int currentFrameCount;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x790b4bc*/ DelayFramePromise();
                    static /*0x7907bc0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(int delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790b5d0*/ DelayFramePromise();
                    /*0x790b4b4*/ ref Cysharp.Threading.Tasks.UniTask.DelayFramePromise get_NextNode();
                    /*0x790b5d8*/ void GetResult(short token);
                    /*0x790b6a4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790b6fc*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790b7b4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790b824*/ bool MoveNext();
                    /*0x790b940*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayFramePromise.<> <>9;

                        static /*0x790b9e4*/ <>c();
                        /*0x790ba4c*/ <>c();
                        /*0x790ba54*/ int <.cctor>b__4_0();
                    }
                }

                class DelayPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.DelayPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.DelayPromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.DelayPromise nextNode;
                    /*0x18*/ int initialFrame;
                    /*0x1c*/ float delayTimeSpan;
                    /*0x20*/ float elapsed;
                    /*0x28*/ System.Threading.CancellationToken cancellationToken;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x790bac0*/ DelayPromise();
                    static /*0x79084a8*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790bbd4*/ DelayPromise();
                    /*0x790bab8*/ ref Cysharp.Threading.Tasks.UniTask.DelayPromise get_NextNode();
                    /*0x790bbdc*/ void GetResult(short token);
                    /*0x790bca8*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790bd00*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790bdb8*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790be28*/ bool MoveNext();
                    /*0x790bf2c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayPromise.<> <>9;

                        static /*0x790bfd0*/ <>c();
                        /*0x790c038*/ <>c();
                        /*0x790c040*/ int <.cctor>b__4_0();
                    }
                }

                class DelayIgnoreTimeScalePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise nextNode;
                    /*0x18*/ float delayFrameTimeSpan;
                    /*0x1c*/ float elapsed;
                    /*0x20*/ int initialFrame;
                    /*0x28*/ System.Threading.CancellationToken cancellationToken;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x790c0ac*/ DelayIgnoreTimeScalePromise();
                    static /*0x79080b0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayFrameTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790c1c0*/ DelayIgnoreTimeScalePromise();
                    /*0x790c0a4*/ ref Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise get_NextNode();
                    /*0x790c1c8*/ void GetResult(short token);
                    /*0x790c294*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790c2ec*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790c3a4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790c414*/ bool MoveNext();
                    /*0x790c518*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise.<> <>9;

                        static /*0x790c5bc*/ <>c();
                        /*0x790c624*/ <>c();
                        /*0x790c62c*/ int <.cctor>b__4_0();
                    }
                }

                class DelayRealtimePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise nextNode;
                    /*0x18*/ long delayTimeSpanTicks;
                    /*0x20*/ Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch;
                    /*0x28*/ System.Threading.CancellationToken cancellationToken;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x790c698*/ DelayRealtimePromise();
                    static /*0x79082b4*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790c7ac*/ DelayRealtimePromise();
                    /*0x790c690*/ ref Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise get_NextNode();
                    /*0x790c7b4*/ void GetResult(short token);
                    /*0x790c880*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790c8d8*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790c990*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790ca00*/ bool MoveNext();
                    /*0x790cb3c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise.<> <>9;

                        static /*0x790cbdc*/ <>c();
                        /*0x790cc44*/ <>c();
                        /*0x790cc4c*/ int <.cctor>b__4_0();
                    }
                }

                class CanceledUniTaskCache<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> Task;

                    static /*0x38358cc*/ CanceledUniTaskCache();
                }

                class ExceptionResultSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                    /*0x18*/ bool calledGet;

                    /*0x7908898*/ ExceptionResultSource(System.Exception exception);
                    /*0x790ccb0*/ void GetResult(short token);
                    /*0x790cd2c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790cd34*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790cd3c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790cd64*/ void Finalize();
                }

                class ExceptionResultSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                    /*0x0*/ bool calledGet;

                    /*0x380d83c*/ ExceptionResultSource(System.Exception exception);
                    /*0x3907c14*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x380cb08*/ void Finalize();
                }

                class CanceledResultSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Threading.CancellationToken cancellationToken;

                    /*0x79088d4*/ CanceledResultSource(System.Threading.CancellationToken cancellationToken);
                    /*0x790d208*/ void GetResult(short token);
                    /*0x790d24c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790d254*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790d25c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                class CanceledResultSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;

                    /*0x3907c14*/ CanceledResultSource(System.Threading.CancellationToken cancellationToken);
                    /*0x3907c14*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                class DeferPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Func<Cysharp.Threading.Tasks.UniTask> factory;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter awaiter;

                    /*0x79089ac*/ DeferPromise(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                    /*0x790d284*/ void GetResult(short token);
                    /*0x790d338*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790d4a0*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790d588*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                }

                class WaitUntilPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.WaitUntilPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.WaitUntilPromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.WaitUntilPromise nextNode;
                    /*0x18*/ System.Func<bool> predicate;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x790d67c*/ WaitUntilPromise();
                    static /*0x7908ac0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790d790*/ WaitUntilPromise();
                    /*0x790d674*/ ref Cysharp.Threading.Tasks.UniTask.WaitUntilPromise get_NextNode();
                    /*0x790d798*/ void GetResult(short token);
                    /*0x790d864*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790d8bc*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790d974*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790d9e4*/ bool MoveNext();
                    /*0x790db58*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitUntilPromise.<> <>9;

                        static /*0x790dc0c*/ <>c();
                        /*0x790dc74*/ <>c();
                        /*0x790dc7c*/ int <.cctor>b__4_0();
                    }
                }

                class WaitWhilePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.WaitWhilePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.WaitWhilePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.WaitWhilePromise nextNode;
                    /*0x18*/ System.Func<bool> predicate;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x790dce8*/ WaitWhilePromise();
                    static /*0x7908d04*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x790ddfc*/ WaitWhilePromise();
                    /*0x790dce0*/ ref Cysharp.Threading.Tasks.UniTask.WaitWhilePromise get_NextNode();
                    /*0x790de04*/ void GetResult(short token);
                    /*0x790ded0*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790df28*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790dfe0*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790e050*/ bool MoveNext();
                    /*0x790e1c4*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitWhilePromise.<> <>9;

                        static /*0x790e278*/ <>c();
                        /*0x790e2e0*/ <>c();
                        /*0x790e2e8*/ int <.cctor>b__4_0();
                    }
                }

                class WhenAllPromise<T> : Cysharp.Threading.Tasks.IUniTaskSource<T[]>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T[] result;
                    /*0x0*/ int completeCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T[]> core;

                    static /*0x383b458*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T> awaiter, int i);
                    /*0x380d8b8*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T> tasks, int tasksLength);
                    T[] GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T> <>9;
                        static /*0x0*/ System.Action<object> <>9__3_0;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__3_0(object state);
                    }
                }

                class WhenAllPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ int completeCount;
                    /*0x14*/ int tasksLength;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x790e34c*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAllPromise self, ref Cysharp.Threading.Tasks.UniTask.Awaiter awaiter);
                    /*0x7908f6c*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask[] tasks, int tasksLength);
                    /*0x790e514*/ void GetResult(short token);
                    /*0x790e59c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790e5f4*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790e6ac*/ void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__3_0;

                        static /*0x790e71c*/ <>c();
                        /*0x790e784*/ <>c();
                        /*0x790e78c*/ void <.ctor>b__3_0(object state);
                    }
                }

                class WhenAllPromise<T1, T2> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2>> core;

                    static /*0x383af28*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    /*0x3907c14*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                    /*0x3907c14*/ System.ValueTuple<T1, T2> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2> <>9;
                        static /*0x0*/ System.Action<object> <>9__4_0;
                        static /*0x0*/ System.Action<object> <>9__4_1;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__4_0(object state);
                        /*0x380d83c*/ void <.ctor>b__4_1(object state);
                    }
                }

                class WhenAllPromise<T1, T2, T3> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2, T3>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ T3 t3;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2, T3>> core;

                    static /*0x383af28*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    /*0x3907c14*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3);
                    /*0x3907c14*/ System.ValueTuple<T1, T2, T3> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2, T3>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2, T3> <>9;
                        static /*0x0*/ System.Action<object> <>9__5_0;
                        static /*0x0*/ System.Action<object> <>9__5_1;
                        static /*0x0*/ System.Action<object> <>9__5_2;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__5_0(object state);
                        /*0x380d83c*/ void <.ctor>b__5_1(object state);
                        /*0x380d83c*/ void <.ctor>b__5_2(object state);
                    }
                }

                class WhenAllPromise<T1, T2, T3, T4> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2, T3, T4>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ T3 t3;
                    /*0x0*/ T4 t4;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2, T3, T4>> core;

                    static /*0x383af28*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT4(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T4> awaiter);
                    /*0x3907c14*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4);
                    /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2, T3, T4>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2, T3, T4> <>9;
                        static /*0x0*/ System.Action<object> <>9__6_0;
                        static /*0x0*/ System.Action<object> <>9__6_1;
                        static /*0x0*/ System.Action<object> <>9__6_2;
                        static /*0x0*/ System.Action<object> <>9__6_3;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__6_0(object state);
                        /*0x380d83c*/ void <.ctor>b__6_1(object state);
                        /*0x380d83c*/ void <.ctor>b__6_2(object state);
                        /*0x380d83c*/ void <.ctor>b__6_3(object state);
                    }
                }

                class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ T3 t3;
                    /*0x0*/ T4 t4;
                    /*0x0*/ T5 t5;
                    /*0x0*/ T6 t6;
                    /*0x0*/ T7 t7;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>> core;

                    static /*0x383af28*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT4(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T4> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT5(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T5> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT6(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T6> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT7(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T7> awaiter);
                    /*0x3907c14*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4, Cysharp.Threading.Tasks.UniTask<T5> task5, Cysharp.Threading.Tasks.UniTask<T6> task6, Cysharp.Threading.Tasks.UniTask<T7> task7);
                    /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2, T3, T4, T5, T6, T7>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7> <>9;
                        static /*0x0*/ System.Action<object> <>9__9_0;
                        static /*0x0*/ System.Action<object> <>9__9_1;
                        static /*0x0*/ System.Action<object> <>9__9_2;
                        static /*0x0*/ System.Action<object> <>9__9_3;
                        static /*0x0*/ System.Action<object> <>9__9_4;
                        static /*0x0*/ System.Action<object> <>9__9_5;
                        static /*0x0*/ System.Action<object> <>9__9_6;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__9_0(object state);
                        /*0x380d83c*/ void <.ctor>b__9_1(object state);
                        /*0x380d83c*/ void <.ctor>b__9_2(object state);
                        /*0x380d83c*/ void <.ctor>b__9_3(object state);
                        /*0x380d83c*/ void <.ctor>b__9_4(object state);
                        /*0x380d83c*/ void <.ctor>b__9_5(object state);
                        /*0x380d83c*/ void <.ctor>b__9_6(object state);
                    }
                }

                class WhenAnyPromise : Cysharp.Threading.Tasks.IUniTaskSource<int>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ int completedCount;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<int> core;

                    static /*0x790e940*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise self, ref Cysharp.Threading.Tasks.UniTask.Awaiter awaiter, int i);
                    /*0x790958c*/ WhenAnyPromise(Cysharp.Threading.Tasks.UniTask[] tasks, int tasksLength);
                    /*0x790eafc*/ int GetResult(short token);
                    /*0x790eb84*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x790ebdc*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x790ec4c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x790ed04*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAnyPromise.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__2_0;

                        static /*0x790ed08*/ <>c();
                        /*0x790ed70*/ <>c();
                        /*0x790ed78*/ void <.ctor>b__2_0(object state);
                    }
                }

                class WhenAnyPromise<T1, T2> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<int, T1, T2>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<int, T1, T2>> core;

                    static /*0x383af28*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x383af28*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    /*0x3907c14*/ WhenAnyPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                    /*0x3907c14*/ System.ValueTuple<int, T1, T2> GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c<T1, T2>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAnyPromise.<>c<T1, T2> <>9;
                        static /*0x0*/ System.Action<object> <>9__2_0;
                        static /*0x0*/ System.Action<object> <>9__2_1;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380d83c*/ void <.ctor>b__2_0(object state);
                        /*0x380d83c*/ void <.ctor>b__2_1(object state);
                    }
                }

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTask.<> <>9;

                    static /*0x790ef30*/ <>c();
                    /*0x790ef98*/ <>c();
                    /*0x790efa0*/ Cysharp.Threading.Tasks.UniTask <.cctor>b__178_0();
                }
            }

            class AwaiterActions
            {
                static /*0x0*/ System.Action<object> InvokeContinuationDelegate;

                static /*0x790f0c0*/ AwaiterActions();
                static /*0x790f054*/ void Continuation(object state);
            }

            struct UniTask<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.IUniTaskSource<T> source;
                /*0x0*/ T result;
                /*0x0*/ short token;

                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask op_Implicit(Cysharp.Threading.Tasks.UniTask<T> self);
                /*0x3907c14*/ UniTask(T result);
                UniTask(Cysharp.Threading.Tasks.IUniTaskSource<T> source, short token);
                /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus get_Status();
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> GetAwaiter();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AsUniTask();
                /*0x380b9e8*/ string ToString();

                struct Awaiter<T> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;

                    /*0x380d83c*/ Awaiter(ref Cysharp.Threading.Tasks.UniTask<T> task);
                    /*0x380b128*/ bool get_IsCompleted();
                    /*0x3907c14*/ T GetResult();
                    /*0x380d83c*/ void OnCompleted(System.Action continuation);
                    /*0x380d83c*/ void UnsafeOnCompleted(System.Action continuation);
                    /*0x380d93c*/ void SourceOnCompleted(System.Action<object> continuation, object state);
                }
            }

            enum DelayType
            {
                DeltaTime = 0,
                UnscaledDeltaTime = 1,
                Realtime = 2,
            }

            struct YieldAwaitable
            {
                /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming timing;

                /*0x790f160*/ YieldAwaitable(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                /*0x790f168*/ Cysharp.Threading.Tasks.YieldAwaitable.Awaiter GetAwaiter();

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming timing;

                    /*0x790f170*/ Awaiter(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x790f178*/ bool get_IsCompleted();
                    /*0x790f180*/ void GetResult();
                    /*0x790f184*/ void OnCompleted(System.Action continuation);
                    /*0x790f1ec*/ void UnsafeOnCompleted(System.Action continuation);
                }
            }

            class CompletedTasks
            {
                static /*0x0*/ Cysharp.Threading.Tasks.UniTask<Cysharp.Threading.Tasks.AsyncUnit> AsyncUnit;
                static /*0x10*/ Cysharp.Threading.Tasks.UniTask<bool> True;
                static /*0x20*/ Cysharp.Threading.Tasks.UniTask<bool> False;
                static /*0x30*/ Cysharp.Threading.Tasks.UniTask<int> Zero;
                static /*0x40*/ Cysharp.Threading.Tasks.UniTask<int> MinusOne;
                static /*0x50*/ Cysharp.Threading.Tasks.UniTask<int> One;

                static /*0x790f254*/ CompletedTasks();
            }

            struct SwitchToMainThreadAwaitable
            {
                /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming;
                /*0x18*/ System.Threading.CancellationToken cancellationToken;

                /*0x7908a14*/ SwitchToMainThreadAwaitable(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken);
                /*0x790f404*/ Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable.Awaiter GetAwaiter();

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming;
                    /*0x18*/ System.Threading.CancellationToken cancellationToken;

                    /*0x790f43c*/ Awaiter(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken);
                    /*0x790f44c*/ bool get_IsCompleted();
                    /*0x790f4fc*/ void GetResult();
                    /*0x790f554*/ void OnCompleted(System.Action continuation);
                    /*0x790f5bc*/ void UnsafeOnCompleted(System.Action continuation);
                }
            }

            class ExceptionHolder
            {
                /*0x10*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                /*0x18*/ bool calledGet;

                /*0x790f624*/ ExceptionHolder(System.Runtime.ExceptionServices.ExceptionDispatchInfo exception);
                /*0x790f654*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo GetException();
                /*0x790f6c4*/ void Finalize();
            }

            struct UniTaskCompletionSourceCore<TResult>
            {
                /*0x0*/ TResult result;
                /*0x0*/ object error;
                /*0x0*/ short version;
                /*0x0*/ bool hasUnhandledError;
                /*0x0*/ int completedCount;
                /*0x0*/ System.Action<object> continuation;
                /*0x0*/ object continuationState;

                /*0x380cb08*/ void Reset();
                /*0x380cb08*/ void ReportUnhandledError();
                /*0x3907c14*/ bool TrySetResult(TResult result);
                /*0x380b2f0*/ bool TrySetException(System.Exception error);
                /*0x3907c14*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x380b674*/ short get_Version();
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x3907c14*/ TResult GetResult(short token);
                void OnCompleted(System.Action<object> continuation, object state, short token);
                void ValidateToken(short token);
            }

            class UniTaskCompletionSourceCoreShared
            {
                static /*0x0*/ System.Action<object> s_sentinel;

                static /*0x790f7fc*/ UniTaskCompletionSourceCoreShared();
                static /*0x790f7b0*/ void CompletionSentinel(object _);
            }

            class AutoResetUniTaskCompletionSource : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource>
            {
                static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource> pool;
                /*0x10*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource nextNode;
                /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                static /*0x790f8a4*/ AutoResetUniTaskCompletionSource();
                static /*0x790f9c0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource Create();
                static /*0x7902a00*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource CreateFromCanceled(System.Threading.CancellationToken cancellationToken, ref short token);
                /*0x790f9b8*/ AutoResetUniTaskCompletionSource();
                /*0x790f89c*/ ref Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource get_NextNode();
                /*0x790fa60*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x790fab8*/ void GetResult(short token);
                /*0x790fb84*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x790fbdc*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x790fc94*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x790fd04*/ bool TryReturn();

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource.<> <>9;

                    static /*0x790fda0*/ <>c();
                    /*0x790fe08*/ <>c();
                    /*0x790fe10*/ int <.cctor>b__4_0();
                }
            }

            class AutoResetUniTaskCompletionSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>>
            {
                static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>> pool;
                /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> nextNode;
                /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;

                static /*0x38358cc*/ AutoResetUniTaskCompletionSource();
                static /*0x382dee4*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> Create();
                static /*0x3907c14*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> CreateFromCanceled(System.Threading.CancellationToken cancellationToken, ref short token);
                /*0x380cb08*/ AutoResetUniTaskCompletionSource();
                /*0x380b9e8*/ ref Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> get_NextNode();
                /*0x3907c14*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x3907c14*/ T GetResult(short token);
                void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x380b128*/ bool TryReturn();

                class <>c<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource.<>c<T> <>9;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x380b6a0*/ int <.cctor>b__4_0();
                }
            }

            class UniTaskCompletionSource : Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x10*/ System.Threading.CancellationToken cancellationToken;
                /*0x18*/ Cysharp.Threading.Tasks.ExceptionHolder exception;
                /*0x20*/ object gate;
                /*0x28*/ System.Action<object> singleContinuation;
                /*0x30*/ object singleState;
                /*0x38*/ System.Collections.Generic.List<System.ValueTuple<System.Action<object>, object>> secondaryContinuationList;
                /*0x40*/ int intStatus;
                /*0x44*/ bool handled;

                /*0x790fe74*/ UniTaskCompletionSource();
                /*0x790fe7c*/ void MarkHandled();
                /*0x790fe94*/ Cysharp.Threading.Tasks.UniTask get_Task();
                /*0x7901ca4*/ bool TrySetResult();
                /*0x7910310*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x7910348*/ void GetResult(short token);
                /*0x7910430*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x7910438*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x7910440*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x790fec0*/ bool TrySignalCompletion(Cysharp.Threading.Tasks.UniTaskStatus status);
            }

            class UniTaskCompletionSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ T result;
                /*0x0*/ Cysharp.Threading.Tasks.ExceptionHolder exception;
                /*0x0*/ object gate;
                /*0x0*/ System.Action<object> singleContinuation;
                /*0x0*/ object singleState;
                /*0x0*/ System.Collections.Generic.List<System.ValueTuple<System.Action<object>, object>> secondaryContinuationList;
                /*0x0*/ int intStatus;
                /*0x0*/ bool handled;

                /*0x380cb08*/ UniTaskCompletionSource();
                /*0x380cb08*/ void MarkHandled();
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                /*0x3907c14*/ bool TrySetResult(T result);
                /*0x3907c14*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x380b2f0*/ bool TrySetException(System.Exception exception);
                /*0x3907c14*/ T GetResult(short token);
                void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x380b228*/ bool TrySignalCompletion(Cysharp.Threading.Tasks.UniTaskStatus status);
            }

            class UniTaskExtensions
            {
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> AsUniTask<T>(System.Threading.Tasks.Task<T> task, bool useCurrentSynchronizationContext);
                static /*0x79106d8*/ Cysharp.Threading.Tasks.UniTask AttachExternalCancellation(Cysharp.Threading.Tasks.UniTask task, System.Threading.CancellationToken cancellationToken);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> AttachExternalCancellation<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Threading.CancellationToken cancellationToken);
                static /*0x79109ac*/ Cysharp.Threading.Tasks.UniTask Timeout(Cysharp.Threading.Tasks.UniTask task, System.TimeSpan timeout, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming timeoutCheckTiming, System.Threading.CancellationTokenSource taskCancellationTokenSource);
                static /*0x7910a98*/ void Forget(Cysharp.Threading.Tasks.UniTask task);
                static /*0x7910e4c*/ void Forget(Cysharp.Threading.Tasks.UniTask task, System.Action<System.Exception> exceptionHandler, bool handleExceptionOnMainThread);
                static /*0x7910e5c*/ Cysharp.Threading.Tasks.UniTaskVoid ForgetCoreWithCatch(Cysharp.Threading.Tasks.UniTask task, System.Action<System.Exception> exceptionHandler, bool handleExceptionOnMainThread);
                static /*0x3907c14*/ void Forget<T>(Cysharp.Threading.Tasks.UniTask<T> task);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask ContinueWith<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Action<T> continuationFunction);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask ContinueWith<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, Cysharp.Threading.Tasks.UniTask> continuationFunction);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TR> ContinueWith<T, TR>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, TR> continuationFunction);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TR> ContinueWith<T, TR>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> continuationFunction);
                static /*0x7910f3c*/ Cysharp.Threading.Tasks.UniTask ContinueWith(Cysharp.Threading.Tasks.UniTask task, System.Action continuationFunction);
                static /*0x7911008*/ Cysharp.Threading.Tasks.UniTask ContinueWith(Cysharp.Threading.Tasks.UniTask task, System.Func<Cysharp.Threading.Tasks.UniTask> continuationFunction);
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> ContinueWith<T>(Cysharp.Threading.Tasks.UniTask task, System.Func<T> continuationFunction);

                class AttachExternalCancellationSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ System.Action<object> cancellationCallbackDelegate;
                    /*0x10*/ System.Threading.CancellationToken cancellationToken;
                    /*0x18*/ System.Threading.CancellationTokenRegistration tokenRegistration;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x79113f4*/ AttachExternalCancellationSource();
                    static /*0x791119c*/ void CancellationCallback(object state);
                    /*0x79108ac*/ AttachExternalCancellationSource(Cysharp.Threading.Tasks.UniTask task, System.Threading.CancellationToken cancellationToken);
                    /*0x79110d4*/ Cysharp.Threading.Tasks.UniTaskVoid RunTask(Cysharp.Threading.Tasks.UniTask task);
                    /*0x791121c*/ void GetResult(short token);
                    /*0x7911274*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x79112cc*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x791133c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();

                    struct <RunTask>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                        /*0x20*/ Cysharp.Threading.Tasks.UniTask task;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTaskExtensions.AttachExternalCancellationSource <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x7911494*/ void MoveNext();
                        /*0x791193c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class AttachExternalCancellationSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ System.Action<object> cancellationCallbackDelegate;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration tokenRegistration;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;

                    static /*0x38358cc*/ AttachExternalCancellationSource();
                    static /*0x3837da0*/ void CancellationCallback(object state);
                    /*0x3907c14*/ AttachExternalCancellationSource(Cysharp.Threading.Tasks.UniTask<T> task, System.Threading.CancellationToken cancellationToken);
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTaskVoid RunTask(Cysharp.Threading.Tasks.UniTask<T> task);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x3907c14*/ T GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();

                    struct <RunTask>d__5<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.AttachExternalCancellationSource<T> <>4__this;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                        /*0x380cb08*/ void MoveNext();
                        /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<> <>9;
                    static /*0x8*/ System.Action<object> <>9__16_0;

                    static /*0x7911944*/ <>c();
                    /*0x79119ac*/ <>c();
                    /*0x79119b4*/ void <Forget>b__16_0(object state);
                }

                class <>c__0<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<>c__0<T> <>9;
                    static /*0x0*/ System.Action<System.Threading.Tasks.Task<T>, object> <>9__0_0;

                    static /*0x38358cc*/ <>c__0();
                    /*0x380cb08*/ <>c__0();
                    /*0x380d93c*/ void <AsUniTask>b__0_0(System.Threading.Tasks.Task<T> x, object state);
                }

                class <>c__19<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<>c__19<T> <>9;
                    static /*0x0*/ System.Action<object> <>9__19_0;

                    static /*0x38358cc*/ <>c__19();
                    /*0x380cb08*/ <>c__19();
                    /*0x380d83c*/ void <Forget>b__19_0(object state);
                }

                struct <ContinueWith>d__22<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x0*/ System.Action<T> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Action<T> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__23<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__24<T, TR> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<TR> <>t__builder;
                    /*0x0*/ System.Func<T, TR> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Func<T, TR> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__25<T, TR> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<TR> <>t__builder;
                    /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<TR> <>u__2;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x38*/ System.Action continuationFunction;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x7911c90*/ void MoveNext();
                    /*0x79120ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x38*/ System.Func<Cysharp.Threading.Tasks.UniTask> continuationFunction;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x79120b4*/ void MoveNext();
                    /*0x79126d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__28<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x0*/ System.Func<T> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x380cb08*/ void MoveNext();
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ForgetCoreWithCatch>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                    /*0x20*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x30*/ bool handleExceptionOnMainThread;
                    /*0x38*/ System.Action<System.Exception> exceptionHandler;
                    /*0x40*/ object <>7__wrap1;
                    /*0x48*/ int <>7__wrap2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x60*/ System.Exception <ex>5__4;
                    /*0x68*/ Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable.Awaiter <>u__2;

                    /*0x79126d4*/ void MoveNext();
                    /*0x7912cf0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Timeout>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ System.TimeSpan timeout;
                    /*0x30*/ Cysharp.Threading.Tasks.DelayType delayType;
                    /*0x34*/ Cysharp.Threading.Tasks.PlayerLoopTiming timeoutCheckTiming;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x48*/ System.Threading.CancellationTokenSource taskCancellationTokenSource;
                    /*0x50*/ System.Threading.CancellationTokenSource <delayCancellationTokenSource>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<int, bool, bool>> <>u__1;

                    /*0x7912cf4*/ void MoveNext();
                    /*0x7913478*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class UniTaskObservableExtensions
            {
                static /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> ToUniTask<T>(System.IObservable<T> source, bool useFirstValue, System.Threading.CancellationToken cancellationToken);

                class ToUniTaskObserver<T> : System.IObserver<T>
                {
                    static /*0x0*/ System.Action<object> callback;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                    /*0x0*/ bool hasValue;
                    /*0x0*/ T latestValue;

                    static /*0x38358cc*/ ToUniTaskObserver();
                    static /*0x3837da0*/ void OnCanceled(object state);
                    /*0x380d978*/ ToUniTaskObserver(Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise, Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable, System.Threading.CancellationToken cancellationToken);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }

                class FirstValueToUniTaskObserver<T> : System.IObserver<T>
                {
                    static /*0x0*/ System.Action<object> callback;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                    /*0x0*/ bool hasValue;

                    static /*0x38358cc*/ FirstValueToUniTaskObserver();
                    static /*0x3837da0*/ void OnCanceled(object state);
                    /*0x380d978*/ FirstValueToUniTaskObserver(Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise, Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable, System.Threading.CancellationToken cancellationToken);
                    /*0x3907c14*/ void OnNext(T value);
                    /*0x380d83c*/ void OnError(System.Exception error);
                    /*0x380cb08*/ void OnCompleted();
                }
            }

            class UniTaskScheduler
            {
                static /*0x0*/ System.Action<System.Exception> UnobservedTaskException;
                static /*0x8*/ bool PropagateOperationCanceledException;
                static /*0xc*/ UnityEngine.LogType UnobservedExceptionWriteLogType;
                static /*0x10*/ bool DispatchUnityMainThread;
                static /*0x18*/ System.Threading.SendOrPostCallback handleExceptionInvoke;

                static /*0x791353c*/ UniTaskScheduler();
                static /*0x791347c*/ void InvokeUnobservedTaskException(object state);
                static /*0x790ce50*/ void PublishUnobservedTaskException(System.Exception ex);
            }

            class UniTaskSynchronizationContext : System.Threading.SynchronizationContext
            {
                static /*0x0*/ System.Threading.SpinLock gate;
                static /*0x4*/ bool dequing;
                static /*0x8*/ int actionListCount;
                static /*0x10*/ Cysharp.Threading.Tasks.UniTaskSynchronizationContext.Callback[] actionList;
                static /*0x18*/ int waitingListCount;
                static /*0x20*/ Cysharp.Threading.Tasks.UniTaskSynchronizationContext.Callback[] waitingList;

                static /*0x7913a30*/ UniTaskSynchronizationContext();
                static /*0x79135f0*/ void Run();

                struct Callback
                {
                    /*0x10*/ System.Threading.SendOrPostCallback callback;
                    /*0x18*/ object state;

                    /*0x791396c*/ void Invoke();
                }
            }

            struct UniTaskVoid
            {
                /*0x7910f38*/ void Forget();
            }

            class UnityAsyncExtensions
            {
                static /*0x7913b08*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                static /*0x7913bb8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Networking.UnityWebRequest> ToUniTask(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation, System.IProgress<float> progress, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);

                struct UnityWebRequestAsyncOperationAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation;
                    /*0x18*/ System.Action<UnityEngine.AsyncOperation> continuationAction;

                    /*0x7913b94*/ UnityWebRequestAsyncOperationAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    /*0x791414c*/ bool get_IsCompleted();
                    /*0x7914168*/ UnityEngine.Networking.UnityWebRequest GetResult();
                    /*0x791421c*/ void OnCompleted(System.Action continuation);
                    /*0x7914220*/ void UnsafeOnCompleted(System.Action continuation);
                }

                class UnityWebRequestAsyncOperationConfiguredSource : Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Networking.UnityWebRequest>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource nextNode;
                    /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation;
                    /*0x20*/ System.IProgress<float> progress;
                    /*0x28*/ System.Threading.CancellationToken cancellationToken;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<UnityEngine.Networking.UnityWebRequest> core;

                    static /*0x7914310*/ UnityWebRequestAsyncOperationConfiguredSource();
                    static /*0x7913f70*/ Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Networking.UnityWebRequest> Create(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.IProgress<float> progress, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7914424*/ UnityWebRequestAsyncOperationConfiguredSource();
                    /*0x7914308*/ ref Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource get_NextNode();
                    /*0x791442c*/ UnityEngine.Networking.UnityWebRequest GetResult(short token);
                    /*0x79144f4*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x79144f8*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7914550*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7914608*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7914678*/ bool MoveNext();
                    /*0x791486c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource.<> <>9;

                        static /*0x7914930*/ <>c();
                        /*0x7914998*/ <>c();
                        /*0x79149a0*/ int <.cctor>b__4_0();
                    }
                }
            }

            class UnityWebRequestException : System.Exception
            {
                /*0x90*/ UnityEngine.Networking.UnityWebRequest <UnityWebRequest>k__BackingField;
                /*0x98*/ UnityEngine.Networking.UnityWebRequest.Result <Result>k__BackingField;
                /*0xa0*/ string <Error>k__BackingField;
                /*0xa8*/ string <Text>k__BackingField;
                /*0xb0*/ long <ResponseCode>k__BackingField;
                /*0xb8*/ System.Collections.Generic.Dictionary<string, string> <ResponseHeaders>k__BackingField;
                /*0xc0*/ string msg;

                /*0x7913e34*/ UnityWebRequestException(UnityEngine.Networking.UnityWebRequest unityWebRequest);
                /*0x7914a04*/ UnityEngine.Networking.UnityWebRequest get_UnityWebRequest();
                /*0x7914a0c*/ string get_Error();
                /*0x7914a14*/ string get_Text();
                /*0x7914a1c*/ string get_Message();
            }

            namespace Triggers
            {
                class AsyncAwakeTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7914ba8*/ AsyncAwakeTrigger();
                    /*0x7914a88*/ Cysharp.Threading.Tasks.UniTask AwakeAsync();
                }

                class AsyncDestroyTrigger : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ bool awakeCalled;
                    /*0x21*/ bool called;
                    /*0x28*/ System.Threading.CancellationTokenSource cancellationTokenSource;

                    /*0x7914f08*/ AsyncDestroyTrigger();
                    /*0x7914bf0*/ System.Threading.CancellationToken get_CancellationToken();
                    /*0x7914d10*/ void Awake();
                    /*0x7914d1c*/ void OnDestroy();
                    /*0x7914d58*/ Cysharp.Threading.Tasks.UniTask OnDestroyAsync();

                    class AwakeMonitor : Cysharp.Threading.Tasks.IPlayerLoopItem
                    {
                        /*0x10*/ Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger trigger;

                        /*0x7914ce0*/ AwakeMonitor(Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger trigger);
                        /*0x7914f10*/ bool MoveNext();
                    }

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__7_0;

                        static /*0x7914fa0*/ <>c();
                        /*0x7915008*/ <>c();
                        /*0x7915010*/ void <OnDestroyAsync>b__7_0(object state);
                    }
                }

                class AsyncStartTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x42*/ bool called;

                    /*0x791522c*/ AsyncStartTrigger();
                    /*0x7915094*/ void Start();
                    /*0x791510c*/ Cysharp.Threading.Tasks.UniTask StartAsync();
                }

                class AsyncTriggerBase<T> : UnityEngine.MonoBehaviour, Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.TriggerEvent<T> triggerEvent;
                    /*0x0*/ bool calledAwake;
                    /*0x0*/ bool calledDestroy;

                    /*0x380cb08*/ AsyncTriggerBase();
                    /*0x380cb08*/ void Awake();
                    /*0x380cb08*/ void OnDestroy();
                    /*0x380d83c*/ void AddHandler(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                    /*0x380d83c*/ void RemoveHandler(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                    /*0x3907c14*/ void RaiseEvent(T value);
                    /*0x380ba14*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);

                    class AsyncTriggerEnumerator<T> : Cysharp.Threading.Tasks.MoveNextSource, Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T>, Cysharp.Threading.Tasks.IUniTaskAsyncDisposable, Cysharp.Threading.Tasks.ITriggerHandler<T>
                    {
                        static /*0x0*/ System.Action<object> cancellationCallback;
                        /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> parent;
                        /*0x0*/ System.Threading.CancellationToken cancellationToken;
                        /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                        /*0x0*/ bool called;
                        /*0x0*/ bool isDisposed;
                        /*0x0*/ T <Current>k__BackingField;
                        /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
                        /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

                        static /*0x38358cc*/ AsyncTriggerEnumerator();
                        static /*0x3837da0*/ void CancellationCallback(object state);
                        /*0x3907c14*/ AsyncTriggerEnumerator(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> parent, System.Threading.CancellationToken cancellationToken);
                        /*0x3907c14*/ void OnNext(T value);
                        /*0x380cb08*/ void OnCompleted();
                        /*0x3907c14*/ T get_Current();
                        /*0x3907c14*/ void set_Current(T value);
                        /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev();
                        /*0x380d83c*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                        /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next();
                        /*0x380d83c*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
                        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
                    }

                    class AwakeMonitor<T> : Cysharp.Threading.Tasks.IPlayerLoopItem
                    {
                        /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger;

                        /*0x380d83c*/ AwakeMonitor(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger);
                        /*0x380b128*/ bool MoveNext();
                    }
                }

                interface IAsyncOneShotTrigger
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OneShotAsync();
                }

                class AsyncTriggerHandler<T> : Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger, Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITriggerHandler<T>, System.IDisposable, Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler, Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler, Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler, Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler, Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler
                {
                    static /*0x0*/ System.Action<object> cancellationCallback;
                    /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                    /*0x0*/ bool isDisposed;
                    /*0x0*/ bool callOnce;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;
                    /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
                    /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

                    static /*0x38358cc*/ AsyncTriggerHandler();
                    static /*0x3837da0*/ void CancellationCallback(object state);
                    AsyncTriggerHandler(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger, bool callOnce);
                    /*0x3907c14*/ AsyncTriggerHandler(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger, System.Threading.CancellationToken cancellationToken, bool callOnce);
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync();
                    /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev();
                    /*0x380d83c*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                    /*0x380b9e8*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next();
                    /*0x380d83c*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                    /*0x380cb08*/ void Dispose();
                    /*0x3907c14*/ T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token);
                    /*0x3907c14*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(T value);
                    /*0x380cb08*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted();
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync();
                    Cysharp.Threading.Tasks.UniTask<int> Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync();
                    /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync();
                    /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync();
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync();
                    Cysharp.Threading.Tasks.UniTask<float> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync();
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync();
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync();
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync();
                }

                interface IAsyncFixedUpdateHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync();
                }

                class AsyncFixedUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79155bc*/ AsyncFixedUpdateTrigger();
                    /*0x7915274*/ void FixedUpdate();
                    /*0x79152e4*/ Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler();
                    /*0x7915360*/ Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79153e4*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync();
                    /*0x79154cc*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncLateUpdateHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync();
                }

                class AsyncLateUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791594c*/ AsyncLateUpdateTrigger();
                    /*0x7915604*/ void LateUpdate();
                    /*0x7915674*/ Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler GetLateUpdateAsyncHandler();
                    /*0x79156f0*/ Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler GetLateUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7915774*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync();
                    /*0x791585c*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAnimatorIKHandler
                {
                    Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync();
                }

                class AsyncAnimatorIKTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<int>
                {
                    /*0x7915cc4*/ AsyncAnimatorIKTrigger();
                    /*0x7915994*/ void OnAnimatorIK(int layerIndex);
                    /*0x79159ec*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler();
                    /*0x7915a68*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7915aec*/ Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync();
                    /*0x7915bd4*/ Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAnimatorMoveHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync();
                }

                class AsyncAnimatorMoveTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7916054*/ AsyncAnimatorMoveTrigger();
                    /*0x7915d0c*/ void OnAnimatorMove();
                    /*0x7915d7c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler();
                    /*0x7915df8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7915e7c*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync();
                    /*0x7915f64*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationFocusHandler
                {
                    /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync();
                }

                class AsyncApplicationFocusTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<bool>
                {
                    /*0x79163cc*/ AsyncApplicationFocusTrigger();
                    /*0x791609c*/ void OnApplicationFocus(bool hasFocus);
                    /*0x79160f4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler();
                    /*0x7916170*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79161f4*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync();
                    /*0x79162dc*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationPauseHandler
                {
                    /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync();
                }

                class AsyncApplicationPauseTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<bool>
                {
                    /*0x7916744*/ AsyncApplicationPauseTrigger();
                    /*0x7916414*/ void OnApplicationPause(bool pauseStatus);
                    /*0x791646c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler();
                    /*0x79164e8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791656c*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync();
                    /*0x7916654*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationQuitHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync();
                }

                class AsyncApplicationQuitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7916ad4*/ AsyncApplicationQuitTrigger();
                    /*0x791678c*/ void OnApplicationQuit();
                    /*0x79167fc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler();
                    /*0x7916878*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79168fc*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync();
                    /*0x79169e4*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAudioFilterReadHandler
                {
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync();
                }

                class AsyncAudioFilterReadTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<System.ValueTuple<System.Single[], int>>
                {
                    /*0x7916ed0*/ AsyncAudioFilterReadTrigger();
                    /*0x7916b1c*/ void OnAudioFilterRead(float[] data, int channels);
                    /*0x7916bb8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler();
                    /*0x7916c34*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7916cb8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync();
                    /*0x7916dbc*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBecameInvisibleHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync();
                }

                class AsyncBecameInvisibleTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7917260*/ AsyncBecameInvisibleTrigger();
                    /*0x7916f18*/ void OnBecameInvisible();
                    /*0x7916f88*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler();
                    /*0x7917004*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7917088*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync();
                    /*0x7917170*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBecameVisibleHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync();
                }

                class AsyncBecameVisibleTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79175f0*/ AsyncBecameVisibleTrigger();
                    /*0x79172a8*/ void OnBecameVisible();
                    /*0x7917318*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler();
                    /*0x7917394*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7917418*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync();
                    /*0x7917500*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBeforeTransformParentChangedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync();
                }

                class AsyncBeforeTransformParentChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7917980*/ AsyncBeforeTransformParentChangedTrigger();
                    /*0x7917638*/ void OnBeforeTransformParentChanged();
                    /*0x79176a8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler();
                    /*0x7917724*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79177a8*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync();
                    /*0x7917890*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCanvasGroupChangedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync();
                }

                class AsyncOnCanvasGroupChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7917d10*/ AsyncOnCanvasGroupChangedTrigger();
                    /*0x79179c8*/ void OnCanvasGroupChanged();
                    /*0x7917a38*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler();
                    /*0x7917ab4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7917b38*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync();
                    /*0x7917c20*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionEnterHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync();
                }

                class AsyncCollisionEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x79180d4*/ AsyncCollisionEnterTrigger();
                    /*0x7917d58*/ void OnCollisionEnter(UnityEngine.Collision coll);
                    /*0x7917db0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler();
                    /*0x7917e2c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7917eb0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync();
                    /*0x7917fbc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionEnter2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync();
                }

                class AsyncCollisionEnter2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x7918498*/ AsyncCollisionEnter2DTrigger();
                    /*0x791811c*/ void OnCollisionEnter2D(UnityEngine.Collision2D coll);
                    /*0x7918174*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler();
                    /*0x79181f0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7918274*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync();
                    /*0x7918380*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionExitHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync();
                }

                class AsyncCollisionExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x791885c*/ AsyncCollisionExitTrigger();
                    /*0x79184e0*/ void OnCollisionExit(UnityEngine.Collision coll);
                    /*0x7918538*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler();
                    /*0x79185b4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7918638*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync();
                    /*0x7918744*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionExit2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync();
                }

                class AsyncCollisionExit2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x7918c20*/ AsyncCollisionExit2DTrigger();
                    /*0x79188a4*/ void OnCollisionExit2D(UnityEngine.Collision2D coll);
                    /*0x79188fc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler();
                    /*0x7918978*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79189fc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync();
                    /*0x7918b08*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionStayHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync();
                }

                class AsyncCollisionStayTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x7918fe4*/ AsyncCollisionStayTrigger();
                    /*0x7918c68*/ void OnCollisionStay(UnityEngine.Collision coll);
                    /*0x7918cc0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler();
                    /*0x7918d3c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7918dc0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync();
                    /*0x7918ecc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionStay2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync();
                }

                class AsyncCollisionStay2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x79193a8*/ AsyncCollisionStay2DTrigger();
                    /*0x791902c*/ void OnCollisionStay2D(UnityEngine.Collision2D coll);
                    /*0x7919084*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler();
                    /*0x7919100*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7919184*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync();
                    /*0x7919290*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnControllerColliderHitHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync();
                }

                class AsyncControllerColliderHitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.ControllerColliderHit>
                {
                    /*0x791976c*/ AsyncControllerColliderHitTrigger();
                    /*0x79193f0*/ void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit);
                    /*0x7919448*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler();
                    /*0x79194c4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7919548*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync();
                    /*0x7919654*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDisableHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync();
                }

                class AsyncDisableTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7919afc*/ AsyncDisableTrigger();
                    /*0x79197b4*/ void OnDisable();
                    /*0x7919824*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler GetOnDisableAsyncHandler();
                    /*0x79198a0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler GetOnDisableAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7919924*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync();
                    /*0x7919a0c*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDrawGizmosHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync();
                }

                class AsyncDrawGizmosTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7919e8c*/ AsyncDrawGizmosTrigger();
                    /*0x7919b44*/ void OnDrawGizmos();
                    /*0x7919bb4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler();
                    /*0x7919c30*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7919cb4*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync();
                    /*0x7919d9c*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDrawGizmosSelectedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync();
                }

                class AsyncDrawGizmosSelectedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791a21c*/ AsyncDrawGizmosSelectedTrigger();
                    /*0x7919ed4*/ void OnDrawGizmosSelected();
                    /*0x7919f44*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler();
                    /*0x7919fc0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791a044*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync();
                    /*0x791a12c*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnEnableHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync();
                }

                class AsyncEnableTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791a5ac*/ AsyncEnableTrigger();
                    /*0x791a264*/ void OnEnable();
                    /*0x791a2d4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler GetOnEnableAsyncHandler();
                    /*0x791a350*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler GetOnEnableAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791a3d4*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync();
                    /*0x791a4bc*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnGUIHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync();
                }

                class AsyncGUITrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791a93c*/ AsyncGUITrigger();
                    /*0x791a5f4*/ void OnGUI();
                    /*0x791a664*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler GetOnGUIAsyncHandler();
                    /*0x791a6e0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler GetOnGUIAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791a764*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync();
                    /*0x791a84c*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnJointBreakHandler
                {
                    Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync();
                }

                class AsyncJointBreakTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<float>
                {
                    /*0x791acb4*/ AsyncJointBreakTrigger();
                    /*0x791a984*/ void OnJointBreak(float breakForce);
                    /*0x791a9dc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler();
                    /*0x791aa58*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791aadc*/ Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync();
                    /*0x791abc4*/ Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnJointBreak2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync();
                }

                class AsyncJointBreak2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Joint2D>
                {
                    /*0x791b078*/ AsyncJointBreak2DTrigger();
                    /*0x791acfc*/ void OnJointBreak2D(UnityEngine.Joint2D brokenJoint);
                    /*0x791ad54*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler();
                    /*0x791add0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791ae54*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync();
                    /*0x791af60*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleCollisionHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync();
                }

                class AsyncParticleCollisionTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.GameObject>
                {
                    /*0x791b43c*/ AsyncParticleCollisionTrigger();
                    /*0x791b0c0*/ void OnParticleCollision(UnityEngine.GameObject other);
                    /*0x791b118*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler();
                    /*0x791b194*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791b218*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync();
                    /*0x791b324*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleSystemStoppedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync();
                }

                class AsyncParticleSystemStoppedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791b7cc*/ AsyncParticleSystemStoppedTrigger();
                    /*0x791b484*/ void OnParticleSystemStopped();
                    /*0x791b4f4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler();
                    /*0x791b570*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791b5f4*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync();
                    /*0x791b6dc*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleTriggerHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync();
                }

                class AsyncParticleTriggerTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791bb5c*/ AsyncParticleTriggerTrigger();
                    /*0x791b814*/ void OnParticleTrigger();
                    /*0x791b884*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler();
                    /*0x791b900*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791b984*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync();
                    /*0x791ba6c*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleUpdateJobScheduledHandler
                {
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync();
                }

                class AsyncParticleUpdateJobScheduledTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.ParticleSystemJobs.ParticleSystemJobData>
                {
                    /*0x791bf5c*/ AsyncParticleUpdateJobScheduledTrigger();
                    /*0x791bba4*/ void OnParticleUpdateJobScheduled(UnityEngine.ParticleSystemJobs.ParticleSystemJobData particles);
                    /*0x791bc2c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler();
                    /*0x791bca8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791bd2c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync();
                    /*0x791be40*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPostRenderHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync();
                }

                class AsyncPostRenderTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791c2ec*/ AsyncPostRenderTrigger();
                    /*0x791bfa4*/ void OnPostRender();
                    /*0x791c014*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler();
                    /*0x791c090*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791c114*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync();
                    /*0x791c1fc*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPreCullHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync();
                }

                class AsyncPreCullTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791c67c*/ AsyncPreCullTrigger();
                    /*0x791c334*/ void OnPreCull();
                    /*0x791c3a4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler GetOnPreCullAsyncHandler();
                    /*0x791c420*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791c4a4*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync();
                    /*0x791c58c*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPreRenderHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync();
                }

                class AsyncPreRenderTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791ca0c*/ AsyncPreRenderTrigger();
                    /*0x791c6c4*/ void OnPreRender();
                    /*0x791c734*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler();
                    /*0x791c7b0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791c834*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync();
                    /*0x791c91c*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRectTransformDimensionsChangeHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync();
                }

                class AsyncRectTransformDimensionsChangeTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791cd9c*/ AsyncRectTransformDimensionsChangeTrigger();
                    /*0x791ca54*/ void OnRectTransformDimensionsChange();
                    /*0x791cac4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler();
                    /*0x791cb40*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791cbc4*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync();
                    /*0x791ccac*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRectTransformRemovedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync();
                }

                class AsyncRectTransformRemovedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791d12c*/ AsyncRectTransformRemovedTrigger();
                    /*0x791cde4*/ void OnRectTransformRemoved();
                    /*0x791ce54*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler();
                    /*0x791ced0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791cf54*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync();
                    /*0x791d03c*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRenderImageHandler
                {
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync();
                }

                class AsyncRenderImageTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>>
                {
                    /*0x791d528*/ AsyncRenderImageTrigger();
                    /*0x791d174*/ void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination);
                    /*0x791d210*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler();
                    /*0x791d28c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791d310*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync();
                    /*0x791d414*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRenderObjectHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync();
                }

                class AsyncRenderObjectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791d8b8*/ AsyncRenderObjectTrigger();
                    /*0x791d570*/ void OnRenderObject();
                    /*0x791d5e0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler();
                    /*0x791d65c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791d6e0*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync();
                    /*0x791d7c8*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnServerInitializedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync();
                }

                class AsyncServerInitializedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791dc48*/ AsyncServerInitializedTrigger();
                    /*0x791d900*/ void OnServerInitialized();
                    /*0x791d970*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler();
                    /*0x791d9ec*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791da70*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync();
                    /*0x791db58*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTransformChildrenChangedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync();
                }

                class AsyncTransformChildrenChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791dfd8*/ AsyncTransformChildrenChangedTrigger();
                    /*0x791dc90*/ void OnTransformChildrenChanged();
                    /*0x791dd00*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler();
                    /*0x791dd7c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791de00*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync();
                    /*0x791dee8*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTransformParentChangedHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync();
                }

                class AsyncTransformParentChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791e368*/ AsyncTransformParentChangedTrigger();
                    /*0x791e020*/ void OnTransformParentChanged();
                    /*0x791e090*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler();
                    /*0x791e10c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791e190*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync();
                    /*0x791e278*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerEnterHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync();
                }

                class AsyncTriggerEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x791e72c*/ AsyncTriggerEnterTrigger();
                    /*0x791e3b0*/ void OnTriggerEnter(UnityEngine.Collider other);
                    /*0x791e408*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler();
                    /*0x791e484*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791e508*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync();
                    /*0x791e614*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerEnter2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync();
                }

                class AsyncTriggerEnter2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x791eaf0*/ AsyncTriggerEnter2DTrigger();
                    /*0x791e774*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
                    /*0x791e7cc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler();
                    /*0x791e848*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791e8cc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync();
                    /*0x791e9d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerExitHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync();
                }

                class AsyncTriggerExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x791eeb4*/ AsyncTriggerExitTrigger();
                    /*0x791eb38*/ void OnTriggerExit(UnityEngine.Collider other);
                    /*0x791eb90*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler();
                    /*0x791ec0c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791ec90*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync();
                    /*0x791ed9c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerExit2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync();
                }

                class AsyncTriggerExit2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x791f278*/ AsyncTriggerExit2DTrigger();
                    /*0x791eefc*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
                    /*0x791ef54*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler();
                    /*0x791efd0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791f054*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync();
                    /*0x791f160*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerStayHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync();
                }

                class AsyncTriggerStayTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x791f63c*/ AsyncTriggerStayTrigger();
                    /*0x791f2c0*/ void OnTriggerStay(UnityEngine.Collider other);
                    /*0x791f318*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler();
                    /*0x791f394*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791f418*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync();
                    /*0x791f524*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerStay2DHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync();
                }

                class AsyncTriggerStay2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x791fa00*/ AsyncTriggerStay2DTrigger();
                    /*0x791f684*/ void OnTriggerStay2D(UnityEngine.Collider2D other);
                    /*0x791f6dc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler();
                    /*0x791f758*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791f7dc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync();
                    /*0x791f8e8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnValidateHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync();
                }

                class AsyncValidateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x791fd90*/ AsyncValidateTrigger();
                    /*0x791fa48*/ void OnValidate();
                    /*0x791fab8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler GetOnValidateAsyncHandler();
                    /*0x791fb34*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler GetOnValidateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791fbb8*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync();
                    /*0x791fca0*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnWillRenderObjectHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync();
                }

                class AsyncWillRenderObjectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7920120*/ AsyncWillRenderObjectTrigger();
                    /*0x791fdd8*/ void OnWillRenderObject();
                    /*0x791fe48*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler();
                    /*0x791fec4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x791ff48*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync();
                    /*0x7920030*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncResetHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask ResetAsync();
                }

                class AsyncResetTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79204b0*/ AsyncResetTrigger();
                    /*0x7920168*/ void Reset();
                    /*0x79201d8*/ Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler GetResetAsyncHandler();
                    /*0x7920254*/ Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler GetResetAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79202d8*/ Cysharp.Threading.Tasks.UniTask ResetAsync();
                    /*0x79203c0*/ Cysharp.Threading.Tasks.UniTask ResetAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncUpdateHandler
                {
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask UpdateAsync();
                }

                class AsyncUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7920840*/ AsyncUpdateTrigger();
                    /*0x79204f8*/ void Update();
                    /*0x7920568*/ Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler GetUpdateAsyncHandler();
                    /*0x79205e4*/ Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler GetUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7920668*/ Cysharp.Threading.Tasks.UniTask UpdateAsync();
                    /*0x7920750*/ Cysharp.Threading.Tasks.UniTask UpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBeginDragHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync();
                }

                class AsyncBeginDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7920c04*/ AsyncBeginDragTrigger();
                    /*0x7920888*/ void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x79208e0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler();
                    /*0x792095c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79209e0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync();
                    /*0x7920aec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCancelHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync();
                }

                class AsyncCancelTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7920fc8*/ AsyncCancelTrigger();
                    /*0x7920c4c*/ void UnityEngine.EventSystems.ICancelHandler.OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x7920ca4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler GetOnCancelAsyncHandler();
                    /*0x7920d20*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler GetOnCancelAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7920da4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync();
                    /*0x7920eb0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDeselectHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync();
                }

                class AsyncDeselectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x792138c*/ AsyncDeselectTrigger();
                    /*0x7921010*/ void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x7921068*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler GetOnDeselectAsyncHandler();
                    /*0x79210e4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7921168*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync();
                    /*0x7921274*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDragHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync();
                }

                class AsyncDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7921750*/ AsyncDragTrigger();
                    /*0x79213d4*/ void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x792142c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler GetOnDragAsyncHandler();
                    /*0x79214a8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler GetOnDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792152c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync();
                    /*0x7921638*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDropHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync();
                }

                class AsyncDropTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7921b14*/ AsyncDropTrigger();
                    /*0x7921798*/ void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x79217f0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler GetOnDropAsyncHandler();
                    /*0x792186c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler GetOnDropAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79218f0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync();
                    /*0x79219fc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnEndDragHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync();
                }

                class AsyncEndDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7921ed8*/ AsyncEndDragTrigger();
                    /*0x7921b5c*/ void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7921bb4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler GetOnEndDragAsyncHandler();
                    /*0x7921c30*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7921cb4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync();
                    /*0x7921dc0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnInitializePotentialDragHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync();
                }

                class AsyncInitializePotentialDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x792229c*/ AsyncInitializePotentialDragTrigger();
                    /*0x7921f20*/ void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7921f78*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler();
                    /*0x7921ff4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7922078*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync();
                    /*0x7922184*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnMoveHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync();
                }

                class AsyncMoveTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.AxisEventData>, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7922660*/ AsyncMoveTrigger();
                    /*0x79222e4*/ void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData);
                    /*0x792233c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler GetOnMoveAsyncHandler();
                    /*0x79223b8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler GetOnMoveAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792243c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync();
                    /*0x7922548*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerClickHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync();
                }

                class AsyncPointerClickTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7922a24*/ AsyncPointerClickTrigger();
                    /*0x79226a8*/ void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7922700*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler();
                    /*0x792277c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7922800*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync();
                    /*0x792290c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerDownHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync();
                }

                class AsyncPointerDownTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7922de8*/ AsyncPointerDownTrigger();
                    /*0x7922a6c*/ void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7922ac4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler();
                    /*0x7922b40*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7922bc4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync();
                    /*0x7922cd0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerEnterHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync();
                }

                class AsyncPointerEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x79231ac*/ AsyncPointerEnterTrigger();
                    /*0x7922e30*/ void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7922e88*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler();
                    /*0x7922f04*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7922f88*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync();
                    /*0x7923094*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerExitHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync();
                }

                class AsyncPointerExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7923570*/ AsyncPointerExitTrigger();
                    /*0x79231f4*/ void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x792324c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler();
                    /*0x79232c8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792334c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync();
                    /*0x7923458*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerUpHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync();
                }

                class AsyncPointerUpTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7923934*/ AsyncPointerUpTrigger();
                    /*0x79235b8*/ void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7923610*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler();
                    /*0x792368c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7923710*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync();
                    /*0x792381c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnScrollHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync();
                }

                class AsyncScrollTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7923cf8*/ AsyncScrollTrigger();
                    /*0x792397c*/ void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x79239d4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler GetOnScrollAsyncHandler();
                    /*0x7923a50*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler GetOnScrollAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7923ad4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync();
                    /*0x7923be0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnSelectHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync();
                }

                class AsyncSelectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x79240bc*/ AsyncSelectTrigger();
                    /*0x7923d40*/ void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x7923d98*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler GetOnSelectAsyncHandler();
                    /*0x7923e14*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler GetOnSelectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7923e98*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync();
                    /*0x7923fa4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnSubmitHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync();
                }

                class AsyncSubmitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7924480*/ AsyncSubmitTrigger();
                    /*0x7924104*/ void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x792415c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler GetOnSubmitAsyncHandler();
                    /*0x79241d8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792425c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync();
                    /*0x7924368*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnUpdateSelectedHandler
                {
                    /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync();
                }

                class AsyncUpdateSelectedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7924844*/ AsyncUpdateSelectedTrigger();
                    /*0x79244c8*/ void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x7924520*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler();
                    /*0x792459c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7924620*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync();
                    /*0x792472c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync(System.Threading.CancellationToken cancellationToken);
                }
            }

            namespace Internal
            {
                class ArrayPool<T>
                {
                    static /*0x0*/ T[] EmptyArray;
                    static /*0x0*/ Cysharp.Threading.Tasks.Internal.ArrayPool<T> Shared;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.MinimumQueue<T[]> buckets;
                    /*0x0*/ System.Threading.SpinLock[] locks;

                    static /*0x38358cc*/ ArrayPool();
                    static /*0x3824360*/ int CalculateSize(int size);
                    static /*0x3824360*/ int GetQueueIndex(int size);
                    /*0x380cb08*/ ArrayPool();
                    /*0x380ba90*/ T[] Rent(int minimumLength);
                    void Return(T[] array, bool clearArray);
                }

                class ArrayPoolUtil
                {
                    static /*0x383a19c*/ void EnsureCapacity<T>(ref T[] array, int index, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                    static /*0x383a19c*/ void EnsureCapacityCore<T>(ref T[] array, int index, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.ArrayPoolUtil.RentArray<T> Materialize<T>(System.Collections.Generic.IEnumerable<T> source);

                    struct RentArray<T> : System.IDisposable
                    {
                        /*0x0*/ T[] Array;
                        /*0x0*/ int Length;
                        /*0x0*/ Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool;

                        RentArray(T[] array, int length, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                        /*0x380cb08*/ void Dispose();
                        /*0x380cdf0*/ void DisposeManually(bool clearArray);
                    }
                }

                class ContinuationQueue
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming timing;
                    /*0x14*/ System.Threading.SpinLock gate;
                    /*0x18*/ bool dequing;
                    /*0x1c*/ int actionListCount;
                    /*0x20*/ System.Action[] actionList;
                    /*0x28*/ int waitingListCount;
                    /*0x30*/ System.Action[] waitingList;

                    /*0x79056f4*/ ContinuationQueue(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x7905dd4*/ void Enqueue(System.Action continuation);
                    /*0x792488c*/ void Run();
                    /*0x7924890*/ void RunCore();
                }

                class Error
                {
                    static /*0x3907c14*/ void ThrowArgumentNullException<T>(T value, string paramName);
                    static /*0x7924bf0*/ void ThrowArgumentNullExceptionCore(string paramName);
                    static /*0x3907c14*/ void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField);
                    static /*0x7924c34*/ void ThrowInvalidOperationExceptionCore(string message);
                    static /*0x7913440*/ void ThrowOperationCanceledException();
                }

                class MinimumQueue<T>
                {
                    /*0x0*/ T[] array;
                    /*0x0*/ int head;
                    /*0x0*/ int tail;
                    /*0x0*/ int size;

                    /*0x380cffc*/ MinimumQueue(int capacity);
                    /*0x380b6a0*/ int get_Count();
                    /*0x3907c14*/ void Enqueue(T item);
                    /*0x3907c14*/ T Dequeue();
                    /*0x380cb08*/ void Grow();
                    /*0x380cffc*/ void SetCapacity(int capacity);
                    /*0x380d83c*/ void MoveNext(ref int index);
                    /*0x380cb08*/ void ThrowForEmptyQueue();
                }

                class PlayerLoopRunner
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming timing;
                    /*0x18*/ object runningAndQueueLock;
                    /*0x20*/ object arrayLock;
                    /*0x28*/ System.Action<System.Exception> unhandledExceptionCallback;
                    /*0x30*/ int tail;
                    /*0x34*/ bool running;
                    /*0x38*/ Cysharp.Threading.Tasks.IPlayerLoopItem[] loopItems;
                    /*0x40*/ Cysharp.Threading.Tasks.Internal.MinimumQueue<Cysharp.Threading.Tasks.IPlayerLoopItem> waitQueue;

                    /*0x79057a4*/ PlayerLoopRunner(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x7905a18*/ void AddAction(Cysharp.Threading.Tasks.IPlayerLoopItem item);
                    /*0x7924c78*/ void Run();
                    /*0x7924c7c*/ void RunCore();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Internal.PlayerLoopRunner.<> <>9;
                        static /*0x8*/ System.Action<System.Exception> <>9__9_0;

                        static /*0x7925654*/ <>c();
                        /*0x79256bc*/ <>c();
                        /*0x79256c4*/ void <.ctor>b__9_0(System.Exception ex);
                    }
                }

                class PooledDelegate<T> : Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.Internal.PooledDelegate<T>>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.Internal.PooledDelegate<T>> pool;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.PooledDelegate<T> nextNode;
                    /*0x0*/ System.Action<T> runDelegate;
                    /*0x0*/ System.Action continuation;

                    static /*0x38358cc*/ PooledDelegate();
                    static /*0x382eaf0*/ System.Action<T> Create(System.Action continuation);
                    /*0x380cb08*/ PooledDelegate();
                    /*0x380b9e8*/ ref Cysharp.Threading.Tasks.Internal.PooledDelegate<T> get_NextNode();
                    /*0x3907c14*/ void Run(T _);

                    class <>c<T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Internal.PooledDelegate.<>c<T> <>9;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380b6a0*/ int <.cctor>b__4_0();
                    }
                }

                class RuntimeHelpersAbstraction
                {
                    static /*0x3818690*/ bool IsWellKnownNoReferenceContainsType<T>();
                    static /*0x792571c*/ bool WellKnownNoReferenceContainsTypeInitialize(System.Type t);

                    class WellKnownNoReferenceContainsType<T>
                    {
                        static /*0x0*/ bool IsWellKnownType;

                        static /*0x38358cc*/ WellKnownNoReferenceContainsType();
                    }
                }

                class StateTuple
                {
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1> Create<T1>(T1 item1);
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2);
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3);
                }

                class StateTuple<T1> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;

                    /*0x380cb08*/ StateTuple();
                    /*0x380cb08*/ void Dispose();
                }

                class StatePool<T1>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1>> queue;

                    static /*0x38358cc*/ StatePool();
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1> Create(T1 item1);
                    static /*0x3837da0*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1> tuple);
                }

                class StateTuple<T1, T2> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;
                    /*0x0*/ T2 Item2;

                    /*0x380cb08*/ StateTuple();
                    /*0x380cb08*/ void Dispose();
                }

                class StatePool<T1, T2>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2>> queue;

                    static /*0x38358cc*/ StatePool();
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> Create(T1 item1, T2 item2);
                    static /*0x3837da0*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> tuple);
                }

                class StateTuple<T1, T2, T3> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;
                    /*0x0*/ T2 Item2;
                    /*0x0*/ T3 Item3;

                    /*0x380cb08*/ StateTuple();
                    /*0x380cb08*/ void Dispose();
                }

                class StatePool<T1, T2, T3>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3>> queue;

                    static /*0x38358cc*/ StatePool();
                    static /*0x3907c14*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3);
                    static /*0x3837da0*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> tuple);
                }

                class UnityWebRequestResultExtensions
                {
                    static /*0x7913dfc*/ bool IsError(UnityEngine.Networking.UnityWebRequest unityWebRequest);
                }

                struct ValueStopwatch
                {
                    static /*0x0*/ double TimestampToTicks;
                    /*0x10*/ long startTimestamp;

                    static /*0x7925bf8*/ ValueStopwatch();
                    static /*0x7906e18*/ Cysharp.Threading.Tasks.Internal.ValueStopwatch StartNew();
                    /*0x7925bf0*/ ValueStopwatch(long startTimestamp);
                    /*0x790cb2c*/ bool get_IsInvalid();
                    /*0x7906c3c*/ long get_ElapsedTicks();
                }

                class SingleAssignmentDisposable : System.IDisposable
                {
                    /*0x10*/ object gate;
                    /*0x18*/ System.IDisposable current;
                    /*0x20*/ bool disposed;

                    /*0x7926010*/ SingleAssignmentDisposable();
                    /*0x7925c80*/ void set_Disposable(System.IDisposable value);
                    /*0x7925e84*/ void Dispose();
                }
            }

            namespace CompilerServices
            {
                struct AsyncUniTaskMethodBuilder
                {
                    /*0x10*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise runnerPromise;
                    /*0x18*/ System.Exception ex;

                    static /*0x792607c*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder Create();
                    /*0x7926088*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x792617c*/ void SetException(System.Exception exception);
                    /*0x792623c*/ void SetResult();
                    /*0x380d93c*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x380d83c*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x79120b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct AsyncUniTaskMethodBuilder<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T> runnerPromise;
                    /*0x0*/ System.Exception ex;
                    /*0x0*/ T result;

                    static /*0x3907c14*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> Create();
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x380d83c*/ void SetException(System.Exception exception);
                    /*0x3907c14*/ void SetResult(T result);
                    /*0x380d93c*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x380d83c*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct AsyncUniTaskVoidMethodBuilder
                {
                    /*0x10*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner runner;

                    static /*0x79262e8*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder Create();
                    /*0x79262f0*/ Cysharp.Threading.Tasks.UniTaskVoid get_Task();
                    /*0x79262f8*/ void SetException(System.Exception exception);
                    /*0x7926418*/ void SetResult();
                    /*0x380d93c*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x380d83c*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x7911940*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                interface IStateMachineRunner
                {
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x380b9e8*/ System.Action get_ReturnAction();
                }

                interface IStateMachineRunnerPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x380cb08*/ void SetResult();
                    /*0x380d83c*/ void SetException(System.Exception exception);
                }

                interface IStateMachineRunnerPromise<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x3907c14*/ void SetResult(T result);
                    /*0x380d83c*/ void SetException(System.Exception exception);
                }

                class AsyncUniTaskVoid<TStateMachine> : Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>> pool;
                    /*0x0*/ System.Action <ReturnAction>k__BackingField;
                    /*0x0*/ TStateMachine stateMachine;
                    /*0x0*/ System.Action <MoveNext>k__BackingField;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine> nextNode;

                    static /*0x38358cc*/ AsyncUniTaskVoid();
                    static /*0x383af28*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner runnerFieldRef);
                    /*0x380cb08*/ AsyncUniTaskVoid();
                    /*0x380b9e8*/ System.Action get_ReturnAction();
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x380b9e8*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine> get_NextNode();
                    /*0x380cb08*/ void Return();
                    /*0x380cb08*/ void Run();
                    Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(System.Action<object> continuation, object state, short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c<TStateMachine>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<TStateMachine> <>9;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380b6a0*/ int <.cctor>b__10_0();
                    }
                }

                class AsyncUniTask<TStateMachine> : Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine>>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine>> pool;
                    /*0x0*/ System.Action returnDelegate;
                    /*0x0*/ System.Action <MoveNext>k__BackingField;
                    /*0x0*/ TStateMachine stateMachine;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine> nextNode;

                    static /*0x38358cc*/ AsyncUniTask();
                    static /*0x383af28*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise runnerPromiseFieldRef);
                    /*0x380cb08*/ AsyncUniTask();
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x380b9e8*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine> get_NextNode();
                    /*0x380cb08*/ void Return();
                    /*0x380cb08*/ void Run();
                    /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x380cb08*/ void SetResult();
                    /*0x380d83c*/ void SetException(System.Exception exception);
                    void GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<TStateMachine>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<TStateMachine> <>9;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380b6a0*/ int <.cctor>b__12_0();
                    }
                }

                class AsyncUniTask<TStateMachine, T> : Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T>, Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T>>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T>> pool;
                    /*0x0*/ System.Action returnDelegate;
                    /*0x0*/ System.Action <MoveNext>k__BackingField;
                    /*0x0*/ TStateMachine stateMachine;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T> nextNode;

                    static /*0x38358cc*/ AsyncUniTask();
                    static /*0x383af28*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T> runnerPromiseFieldRef);
                    /*0x380cb08*/ AsyncUniTask();
                    /*0x380b9e8*/ System.Action get_MoveNext();
                    /*0x380b9e8*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T> get_NextNode();
                    /*0x380cb08*/ void Return();
                    /*0x380cb08*/ void Run();
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x3907c14*/ void SetResult(T result);
                    /*0x380d83c*/ void SetException(System.Exception exception);
                    /*0x3907c14*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<TStateMachine, T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<TStateMachine, T> <>9;

                        static /*0x38358cc*/ <>c();
                        /*0x380cb08*/ <>c();
                        /*0x380b6a0*/ int <.cctor>b__12_0();
                    }
                }
            }
        }
    }
}
